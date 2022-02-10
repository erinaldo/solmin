Imports system
Imports system.Windows.Forms
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports SOLMIN_ST.ENTIDADES

Public Class frmGPSWAP

#Region "Atributo"
  Private InfoSeguimientoGPS As New SeguimientoGPS
  Private _SESTRG As Int32 = 0

  Public Property oInfoSeguimientoGPS() As SeguimientoGPS
    Get
      Return InfoSeguimientoGPS
    End Get
    Set(ByVal value As SeguimientoGPS)
      InfoSeguimientoGPS = value
    End Set
  End Property

  Public WriteOnly Property Estado() As Int32
    Set(ByVal value As Int32)
      _SESTRG = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub frmGPSWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      If oInfoSeguimientoGPS.NPLCTR.Trim = "" Then Exit Sub
      oInfoSeguimientoGPS.NGSGWP = IIf(oInfoSeguimientoGPS.NGSGWP.Trim.Equals(""), "01", oInfoSeguimientoGPS.NGSGWP)
      Me.txtUnidad.ReadOnly = True
      Me.txtSolicitud.ReadOnly = True
      Me.txtCorrelativo.ReadOnly = True
      Me.txtCiclo.ReadOnly = True
      Me.txtUnidad.Text = oInfoSeguimientoGPS.NPLCTR
      Me.txtSolicitud.Text = oInfoSeguimientoGPS.NCSOTR
      Me.txtCorrelativo.Text = oInfoSeguimientoGPS.NCRRSR

      Me.TabControl1.SelectedTab.Name = "TABWAP"
      Me.btnNuevo.Visible = False
      Me.btnModificar.Visible = False
      Me.btnEliminar.Visible = False
      Me.btnReiniciarCiclo.Visible = True
      Me.btnImportar.Visible = False
      Me.gwdDatos.AutoGenerateColumns = False
      Me.gwdDatosGPS.AutoGenerateColumns = False

      Me.Alinear_Columnas_Grilla()
      Me.Listar_RegistroWAP()
      Me.Listar_RegistroGPS()

      Me.Separator1.Visible = False
      Me.Separator2.Visible = False
      Me.Separator3.Visible = True
      Me.Separator4.Visible = False
      If _SESTRG = 1 Then
        Me.btnReiniciarCiclo_Click(Nothing, Nothing)
      End If
    Catch ex As Exception

    End Try

  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
      Dim ofrmNuevoSeguimientoGPS As New frmNuevoSeguimientoGPS
      ofrmNuevoSeguimientoGPS.modificar = False
      ofrmNuevoSeguimientoGPS.obeInfoSeguimientoGPS = oInfoSeguimientoGPS
      If (ofrmNuevoSeguimientoGPS.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
        Listar_RegistroGPS()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Try
      If gwdDatosGPS.Rows.Count <= 0 Then Exit Sub
      Dim ofrmNuevoSeguimientoGPS As New frmNuevoSeguimientoGPS
      ofrmNuevoSeguimientoGPS.modificar = True
      oInfoSeguimientoGPS.FECGPS = gwdDatosGPS.CurrentRow.Cells("FECGPS").Value
      oInfoSeguimientoGPS.HORA_S = gwdDatosGPS.CurrentRow.Cells("HORA_S").Value
      oInfoSeguimientoGPS.GPSLAT = gwdDatosGPS.CurrentRow.Cells("GPSLAT").Value
      oInfoSeguimientoGPS.GPSLON = gwdDatosGPS.CurrentRow.Cells("GPSLON").Value
      oInfoSeguimientoGPS.KMSVEL = gwdDatosGPS.CurrentRow.Cells("KMSVEL").Value
      ofrmNuevoSeguimientoGPS.obeInfoSeguimientoGPS = oInfoSeguimientoGPS
      If (ofrmNuevoSeguimientoGPS.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
        Listar_RegistroGPS()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Try
      If gwdDatosGPS.Rows.Count <= 0 Then Exit Sub
      Dim oblSeguimiento As New SeguimientoGPS_BLL
      Dim retorno As Int32 = 0
      Dim oEntidad As New SeguimientoGPS
      oEntidad.NPLCTR = oInfoSeguimientoGPS.NPLCTR
      oEntidad.NCRRSR = oInfoSeguimientoGPS.NCRRSR
      oEntidad.NCSOTR = oInfoSeguimientoGPS.NCSOTR
      oEntidad.CULUSA = MainModule.USUARIO
            oEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      oEntidad.FECGPS = gwdDatosGPS.CurrentRow.Cells("FECGPS").Value
      oEntidad.HORA = gwdDatosGPS.CurrentRow.Cells("HORA").Value
      If (MessageBox.Show("Está seguro de eliminar el registro ?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK) Then
        retorno = oblSeguimiento.Eliminar_Seguimiento_GPS(oEntidad)
        If (retorno = 1) Then
          MessageBox.Show("Se eliminó el registro", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Listar_RegistroGPS()
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
    Try
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
        .CCMPN = oInfoSeguimientoGPS.CCMPN
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
        objEntidad.CCMPN = oInfoSeguimientoGPS.CCMPN
        If objLogica.Modificar_Registro_WAP(objEntidad) = "-1" Then
          HelpClass.ErrorMsgBox()
        Else
          HelpClass.MsgBox("Se Registró Satisfactoriamente")
          Me.gwdDatos.Item("FRGTRO", lint_Indice).Value = HelpClass.CNumero_a_Fecha(.FRGTRO).ToString.Substring(0, 10)
          Me.gwdDatos.Item("HRGTRO", lint_Indice).Value = .HRGTRO
          Me.gwdDatos.Item("TOBS", lint_Indice).Value = .TOBS.Trim
        End If
      End With
    Catch ex As Exception

    End Try

  End Sub

  Private Sub btnReiniciarCiclo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciarCiclo.Click
    Try
      Me.ReiniciarCicloWap()
      If (gwdDatos.Rows.Count > 0) Then
        Dim retorno As Int32 = 0
        Dim oblSeguimiento As New SeguimientoGPS_BLL
        Dim oEntidad As New SeguimientoGPS
        oEntidad.NCSOTR = oInfoSeguimientoGPS.NCSOTR
        oEntidad.NCRRSR = oInfoSeguimientoGPS.NCRRSR
        oEntidad.NCOREG = Me.gwdDatos.Rows(0).Cells("CICLO").Value
        oEntidad.CULUSA = MainModule.USUARIO
                oEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        oEntidad.CCMPN = Me.oInfoSeguimientoGPS.CCMPN
        retorno = oblSeguimiento.ActualizarRZST20(oEntidad)
        Me.txtCiclo.Text = Me.gwdDatos.Rows(0).Cells("CICLO").Value
      Else
        Me.txtCiclo.Text = ""
      End If
    Catch ex As Exception
    End Try

  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Try
      Dim ofrmImportarGPSDatos As New frmImportarGPSDatos
      ofrmImportarGPSDatos.oInfobeSeguimientoGPS = oInfoSeguimientoGPS
      ofrmImportarGPSDatos.oListActualGPS = gwdDatosGPS.DataSource
      If (ofrmImportarGPSDatos.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
        Listar_RegistroGPS()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    Dim tabNameActual As String = ""
    Dim TabOpcion As Int32 = -1
    tabNameActual = TabControl1.SelectedTab.Name
    Select Case tabNameActual
      Case "TABWAP"
        TabOpcion = 1
      Case "TABGPS"
        TabOpcion = 2
    End Select

    btnNuevo.Visible = IIf(TabOpcion = 2, True, False)
    btnModificar.Visible = IIf(TabOpcion = 2, True, False)
    btnEliminar.Visible = IIf(TabOpcion = 2, True, False)
    btnImportar.Visible = IIf(TabOpcion = 2, True, False)
    btnImportar.Visible = IIf(TabOpcion = 2, True, False)
    btnAsignar.Visible = IIf(TabOpcion = 1, True, False)
    btnReiniciarCiclo.Visible = IIf(TabOpcion = 1, True, False)

    Separator1.Visible = IIf(TabOpcion = 2, True, False)
    Separator2.Visible = IIf(TabOpcion = 2, True, False)
    Separator3.Visible = IIf(TabOpcion = 1, True, False)
    Separator4.Visible = IIf(TabOpcion = 2, True, False)

  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    Try
      If Me.gwdDatos.Rows.Count > 0 Then
        Me.gwdDatos.CurrentRow.Selected = False
      End If
    Catch : End Try
  End Sub

#End Region

#Region "Métodos y Procedimiento"

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Listar_RegistroGPS()
    Dim oblSeguimientoGPS As New SeguimientoGPS_BLL
    gwdDatosGPS.DataSource = oblSeguimientoGPS.Listar_Seguimiento_GPS(oInfoSeguimientoGPS)

  End Sub

  Private Sub Listar_RegistroWAP()
    Dim orden As Int32 = 1
    Dim objLogica As New SeguimientoWAP_BLL
    Dim dwvrow As DataGridViewRow
    Dim ht As New Hashtable
    ht.Add("NCOREG", oInfoSeguimientoGPS.NCOREG)
    ht.Add("NGSGWP", oInfoSeguimientoGPS.NGSGWP)

    Me.gwdDatos.Rows.Clear()
    For Each dtrow As DataRow In objLogica.Listar_Ultimo_Ciclo_Tracto_Multimodal(ht).Rows
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)

      dwvrow.Cells(0).Value = orden
      dwvrow.Cells(1).Value = dtrow("CICLO")
      dwvrow.Cells(2).Value = dtrow("NPLCTR")
      dwvrow.Cells(3).Value = dtrow("NCOEVT")
      dwvrow.Cells(4).Value = dtrow("TNMEV")
      If dtrow("FRGTRO") = "00/00/0000" Then
        dwvrow.Cells(5).Value = ""
      Else
        dwvrow.Cells(5).Value = dtrow("FRGTRO")
      End If
      If dtrow("HRGTRO").ToString.Trim = "00:00:00 am" Or dtrow("HRGTRO").ToString.Trim = "00:00:00" Then
        dwvrow.Cells(6).Value = ""
      Else
        dwvrow.Cells(6).Value = dtrow("HRGTRO")
      End If
      dwvrow.Cells(7).Value = dtrow("TOBS").ToString.Trim
      dwvrow.Cells(8).Value = dtrow("CULUSA").ToString.Trim

      Me.gwdDatos.Rows.Add(dwvrow)
      orden += 1
    Next

    If (gwdDatos.Rows.Count > 0) Then
      Me.txtCiclo.Text = gwdDatos.Rows(0).Cells("CICLO").Value
    Else
      Me.txtCiclo.Text = ""
    End If

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
    objEntidadSeguimientoWap.NPLCTR = oInfoSeguimientoGPS.NPLCTR
    objEntidadSeguimientoWap.CCMPN = oInfoSeguimientoGPS.CCMPN
    objEntidadSeguimientoWap.NGSGWP = oInfoSeguimientoGPS.NGSGWP
    objEntidadSeguimientoWap.NCOREG = IIf(oInfoSeguimientoGPS.NCOREG = 0, String.Empty, oInfoSeguimientoGPS.NCOREG)
    oInfoSeguimientoGPS.NCOREG = objSeguimientoWap.Reiniciar_Ciclo_Wap(objEntidadSeguimientoWap)
    If oInfoSeguimientoGPS.NCOREG = 0 Then
      HelpClass.ErrorMsgBox()
    Else
      Me.Listar_RegistroWAP()
    End If

  End Sub

#End Region

End Class
