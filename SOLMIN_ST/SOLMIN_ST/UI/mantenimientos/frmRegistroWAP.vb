Imports system
Imports system.Windows.Forms
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports SOLMIN_ST.ENTIDADES

Public Class frmRegistroWAP

#Region "Atributo"
  Private vNPLCUN As String = ""
  Private _CCMPN As String = ""
  Private _NGSGWP As String = ""
  Private _NCOREG As String = ""
  Private _SESTRG As String = ""

  Public Property SESTRG() As String
    Get
      Return _SESTRG
    End Get
    Set(ByVal value As String)
      _SESTRG = value
    End Set
  End Property
  Public Property NGSGWP() As String
    Get
      Return _NGSGWP
    End Get
    Set(ByVal value As String)
      _NGSGWP = value
    End Set
  End Property
  Public Property NCOREG() As String
    Get
      Return _NCOREG
    End Get
    Set(ByVal value As String)
      _NCOREG = value
    End Set
  End Property
  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

#End Region

  Public Sub ShowForm(ByVal owner As IWin32Window)
    'Forzando destruccion de memoria
    ClearMemory()
    'Mostrando el formulario
    Me.ShowDialog(owner)
  End Sub

  Private Sub frmRegistroWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Alinear_Columnas_Grilla()
    If SESTRG = "C" Then
      Me.btnReiniciarCiclo.Enabled = False
      'Me.btnModificar.Enabled = False
    Else
      Me.btnReiniciarCiclo.Enabled = True
      Me.btnModificar.Enabled = True
    End If
    Me.Listar_RegistroWAP(vNPLCUN)
  End Sub

  Private Sub Listar_RegistroWAP(ByVal lstr_lpPlaca As String)
    Dim objLogica As New SeguimientoWAP_BLL
    Dim dwvrow As DataGridViewRow
    Dim ht As New Hashtable
    ht.Add("NPLCTR", lstr_lpPlaca)
    ht.Add("CCMPN", _CCMPN)
    ht.Add("NCOREG", _NCOREG)
    Me.gwdDatos.Rows.Clear()
    For Each dtrow As DataRow In objLogica.Listar_Ultimo_Ciclo_Tracto(ht).Rows
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)
      dwvrow.Cells(0).Value = dtrow("CICLO")
      dwvrow.Cells(1).Value = dtrow("NPLCTR")
      dwvrow.Cells(2).Value = dtrow("NCOEVT")
      dwvrow.Cells(3).Value = dtrow("TNMEV")
      If dtrow("FRGTRO") = "00/00/0000" Then
        dwvrow.Cells(4).Value = ""
      Else
        dwvrow.Cells(4).Value = dtrow("FRGTRO")
      End If
      If dtrow("HRGTRO").ToString.Trim = "00:00:00 am" Or dtrow("HRGTRO").ToString.Trim = "00:00:00" Then
        dwvrow.Cells(5).Value = ""
      Else
        dwvrow.Cells(5).Value = dtrow("HRGTRO")
      End If
      dwvrow.Cells(6).Value = dtrow("TOBS").ToString.Trim
      dwvrow.Cells(7).Value = dtrow("CULUSA").ToString.Trim

      Me.gwdDatos.Rows.Add(dwvrow)
    Next
  End Sub

  Private Sub gwDatos_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    Try
      If Me.gwdDatos.Rows.Count > 0 Then
        Me.gwdDatos.CurrentRow.Selected = False
      End If
    Catch : End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    If Me.gwdDatos.RowCount = 0 Then Exit Sub
    If Me.gwdDatos.CurrentRow.Selected = False Then
      HelpClass.MsgBox("Falta seleccionar el Registro a Modificar.")
      Exit Sub
    End If
    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    If Me.gwdDatos.Item("FRGTRO", lint_Indice).Value <> "" Then
      HelpClass.MsgBox("Ya se Registró.")
      Exit Sub
    End If

    Dim frm_frmAsignarRegistroWAP As New frmAsignarRegistroWAP
    With frm_frmAsignarRegistroWAP
      .CCMPN = _CCMPN
      If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      Dim objEntidad As New RegistroWAP
      Dim objLogica As New SeguimientoWAP_BLL

      objEntidad.CICLO = Me.gwdDatos.Item("CICLO", lint_Indice).Value.ToString.Trim
      objEntidad.NPLCTR = Me.gwdDatos.Item("NPLCTR", lint_Indice).Value.ToString.Trim
      objEntidad.NCOEVT = Me.gwdDatos.Item("NCOEVT", lint_Indice).Value.ToString.Trim
      objEntidad.FRGTRO = .FRGTRO
      objEntidad.HRGTRO = HelpClass.ConvertHoraNumeric(.HRGTRO)
      objEntidad.TOBS = .TOBS
      objEntidad.CULUSA = MainModule.USUARIO
      objEntidad.FULTAC = HelpClass.TodayNumeric
      objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      objEntidad.CCMPN = _CCMPN
      If objLogica.Modificar_Registro_WAP(objEntidad) = "-1" Then
        HelpClass.ErrorMsgBox()
      Else
        HelpClass.MsgBox("Se Registró Satisfactoriamente")
        Me.gwdDatos.Item("FRGTRO", lint_Indice).Value = HelpClass.CNumero_a_Fecha(.FRGTRO).ToString.Substring(0, 10)
        Me.gwdDatos.Item("HRGTRO", lint_Indice).Value = .HRGTRO
        Me.gwdDatos.Item("TOBS", lint_Indice).Value = .TOBS.Trim
      End If
    End With

  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub btnbtnReiniciarCiclo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciarCiclo.Click
    ReiniciarCicloWap()
  End Sub

  Private Sub ReiniciarCicloWap()
    If Me.gwdDatos.Rows.Count <> 0 Then
      Dim dblExiste As Double = False
      For Each odgvRow As DataGridViewRow In Me.gwdDatos.Rows
        If odgvRow.Cells("FRGTRO").Value <> "" Then
          dblExiste = True
          Exit For
        End If
      Next
      If Not dblExiste Then
        HelpClass.MsgBox("No se puede reiniciar, para reiniciar el ciclo debe de tener por lo menos un evento")
        Exit Sub
      End If
    End If
    Dim objSeguimientoWap As New SeguimientoWAP_BLL
    Dim objEntidadSeguimientoWap As New SeguimientoWap
    Dim objEntidadUsuarioWap As New UsuarioWap

    objEntidadSeguimientoWap.FRGTRO = HelpClass.TodayNumeric
    objEntidadSeguimientoWap.HRGTRO = HelpClass.NowNumeric
    objEntidadSeguimientoWap.CUSCRT = MainModule.USUARIO
    objEntidadSeguimientoWap.NPLCTR = vNPLCUN
    objEntidadSeguimientoWap.CCMPN = CCMPN
    objEntidadSeguimientoWap.NGSGWP = NGSGWP
    objEntidadSeguimientoWap.NCOREG = NCOREG

    If objSeguimientoWap.Reiniciar_Ciclo_Wap(objEntidadSeguimientoWap) = 0 Then
      HelpClass.ErrorMsgBox()
    Else
      Me.Listar_RegistroWAP(vNPLCUN)
    End If

  End Sub

End Class

