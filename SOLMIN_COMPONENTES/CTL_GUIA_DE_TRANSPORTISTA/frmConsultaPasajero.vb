Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmConsultaPasajero

  Private _PLANTA As String = ""
  Private _COMPANIA As String = ""
  Private _TIPOGUIA As Int16 = 0
  Private _COD_TRANSPORTISTA As Int32 = 0
  Private _GUIA_TRANSPORTISTA As Int64 = 0
  Private _CLIENTE As Int32 = 0
  Private _USUARIO As String = ""
  Private _ORIGEN As Int32 = 0
  Private _DESTINO As Int32 = 0
  Private _RUTA_PASAJERO As String = ""
  Private _CMEDTR As Int32 = 0

  Public WriteOnly Property CLIENTE() As Int32
    Set(ByVal value As Int32)
      _CLIENTE = value
    End Set
  End Property

  Public WriteOnly Property GUIA_TRANSPORTISTA() As Int64
    Set(ByVal value As Int64)
      _GUIA_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property COD_TRANSPORTISTA() As Int32
    Set(ByVal value As Int32)
      _COD_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property TIPO_GUIA() As Int16
    Set(ByVal value As Int16)
      _TIPOGUIA = value
    End Set
  End Property

  Public WriteOnly Property PLANTA() As String
    Set(ByVal value As String)
      _PLANTA = value
    End Set
  End Property

  Public WriteOnly Property COMPANIA() As String
    Set(ByVal value As String)
      _COMPANIA = value
    End Set
  End Property

  Public WriteOnly Property USUARIO() As String
    Set(ByVal value As String)
      _USUARIO = value
    End Set
  End Property

  Public WriteOnly Property RUTA_PASAJERO() As String
    Set(ByVal value As String)
      _RUTA_PASAJERO = value
    End Set
  End Property

  Public WriteOnly Property ORIGEN() As Int32
    Set(ByVal value As Int32)
      _ORIGEN = value
    End Set
  End Property

  Public WriteOnly Property DESTINO() As Int32
    Set(ByVal value As Int32)
      _DESTINO = value
    End Set
  End Property

  Public WriteOnly Property MEDIO_TRANSPORTE() As Int32
    Set(ByVal value As Int32)
      _CMEDTR = value
    End Set
  End Property

  Private Sub frmConsultaGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If _TIPOGUIA = 0 Then
      Me.txtFiltroProgramacion.Visible = True
    End If
    'Else
    Me.UcCliente_GuiaRemision.CCMPN = _COMPANIA
    Me.UcCliente_GuiaRemision.pCargar(Me._CLIENTE)
    Me.txtRuta.Text = Me._RUTA_PASAJERO
  End Sub

  Private Sub txtFiltroGuiaRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroProgramacion.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtFiltroGuiaRemision_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroProgramacion.KeyUp
    Try
      If e.KeyCode = Keys.Enter Then
        If Me.txtFiltroProgramacion.Text.Trim.Equals("") Then Exit Sub
        Me.btnBuscar_Click(Nothing, Nothing)
        If Me.dtgGuiaRemision.RowCount = 1 Then
          Me.dtgGuiaRemision.Item("SELECCIONAR", 0).Value = True
        End If
      End If
    Catch : End Try
  End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.UcCliente_GuiaRemision.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Information)
                Exit Sub
            End If
            If _TIPOGUIA = 0 Then
                Me.Listar_Pasajeros_x_Programacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub Listar_Pasajeros_x_Programacion()
    Dim obj_Logica As New GuiaTransportista_BLL
    Dim obj_Entidad As New Hashtable
    Dim dwvrow As DataGridViewRow
        'Try
        If Me.lblGuia.Checked Then
            If Me.txtFiltroProgramacion.Text.Trim = "" Then
                HelpClass.MsgBox("Ingrese Guía Remisión", MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        obj_Entidad.Add("CCMPN", Me._COMPANIA)
        obj_Entidad.Add("CPLNDV", Me._PLANTA)
        obj_Entidad.Add("CCLNT", Me.UcCliente_GuiaRemision.pCodigo)
        obj_Entidad.Add("NPRGVJ", IIf(Me.lblGuia.Checked = True, Me.txtFiltroProgramacion.Text, 0))
        obj_Entidad.Add("FECINI", IIf(Me.dtpFechaFiltroInicio.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroInicio.Value), Double), 0))
        obj_Entidad.Add("FECFIN", IIf(Me.dtpFechaFiltroFin.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroFin.Value), Double), 0))
        obj_Entidad.Add("CLCLOR", Me._ORIGEN)
        obj_Entidad.Add("CLCLDS", Me._DESTINO)
        obj_Entidad.Add("CMEDTR", Me._CMEDTR)
        Me.dtgGuiaRemision.Rows.Clear()
        For Each objEntidad As Viaje_Ruta In obj_Logica.Listar_Pasajeros_x_Programacion(obj_Entidad)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgGuiaRemision)
            dwvrow.Cells(0).Value = False
            dwvrow.Cells(1).Value = objEntidad.PNNPRGVJ
            dwvrow.Cells(2).Value = objEntidad.RUTA
            dwvrow.Cells(3).Value = objEntidad.PSFSLDRT
            dwvrow.Cells(4).Value = objEntidad.PSHSLDRT
            dwvrow.Cells(5).Value = objEntidad.PSNMBPER
            dwvrow.Cells(6).Value = objEntidad.PNNCRRRT
            dwvrow.Cells(7).Value = objEntidad.PNNCRRIN
            Me.dtgGuiaRemision.Rows.Add(dwvrow)
        Next
        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub lblGuiaRemi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGuia.CheckedChanged
    If Me._TIPOGUIA = 0 Then
      If Me.lblGuia.Checked = True Then
        Me.txtFiltroProgramacion.Enabled = True
        Me.dtpFechaFiltroInicio.Enabled = False
        Me.dtpFechaFiltroFin.Enabled = False
      Else
        Me.txtFiltroProgramacion.Enabled = False
        Me.dtpFechaFiltroInicio.Enabled = True
        Me.dtpFechaFiltroFin.Enabled = True
      End If
    End If

  End Sub

  Private Sub dtgGuiaRemision_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGuiaRemision.CellDoubleClick
    If e.RowIndex = -1 And e.ColumnIndex = 0 Then
      If Me.dtgGuiaRemision.RowCount = 0 Then Exit Sub
      Dim lintEstado As Boolean = Me.dtgGuiaRemision.Item(0, 0).Value
      For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
        Me.dtgGuiaRemision.Item(0, lint_Contador).Value = Not lintEstado
        Me.dtgGuiaRemision.EndEdit()
      Next
    End If
  End Sub

  Private Function Validar_Check_Grilla(ByVal dtgGrilla As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) As Boolean
    Dim lbool_Estado As Boolean = False
    For lint_Contador As Integer = 0 To dtgGrilla.RowCount - 1
      If dtgGrilla.Item(0, lint_Contador).Value = True Then
        lbool_Estado = True
        Exit For
      End If
    Next
    Return lbool_Estado
  End Function

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try

       
        If _TIPOGUIA = 0 Then
            Me.dtgGuiaRemision.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If Me.Validar_Check_Grilla(Me.dtgGuiaRemision) = False Then
                HelpClass.MsgBox("Falta Seleccionar Pasajero", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obj_Logica As New GuiaTransportista_BLL
            Dim obj_EntidadGuia As Viaje_Ruta

            Dim lintContador As Int32 = 0

            For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
                If CBool(Me.dtgGuiaRemision.Item(0, lint_Contador).FormattedValue) = True Then
                    obj_EntidadGuia = New Viaje_Ruta
                    'Llenando los datos de la guia de Anexo
                    obj_EntidadGuia.PNNPRGVJ = Me.dtgGuiaRemision.Item("NPRGVJ", lint_Contador).Value
                    obj_EntidadGuia.PNNCRRRT = Me.dtgGuiaRemision.Item("NCRRRT", lint_Contador).Value
                    obj_EntidadGuia.PNNCRRIN = Me.dtgGuiaRemision.Item("NCRRIN", lint_Contador).Value
                    obj_EntidadGuia.PNCTRMNC = Me._COD_TRANSPORTISTA
                    obj_EntidadGuia.PNNGUITR = Me._GUIA_TRANSPORTISTA
                    obj_EntidadGuia.PNFULTAC = HelpClass.TodayNumeric
                    obj_EntidadGuia.PNHULTAC = HelpClass.NowNumeric
                    obj_EntidadGuia.PSCULUSA = Me._USUARIO
                        obj_EntidadGuia.PSNTRMNL = ""
                    obj_EntidadGuia.PSCCMPN = Me._COMPANIA

                    'Proceso de registro
                    If obj_Logica.Registrar_Pasajero_Automatico(obj_EntidadGuia).PNNPRGVJ = 0 Then
                        HelpClass.MsgBox("Ocurrió un error al registrar al Pasajero" & Me.dtgGuiaRemision.Item("NMBPER", lint_Contador).Value, MessageBoxIcon.Error)
                        lintContador += 1
                    End If
                    Me.dtgGuiaRemision.Item(0, lint_Contador).Value = False
                    Me.dtgGuiaRemision.EndEdit()
                End If
            Next
            If lintContador = 0 Then
                HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
                Me.btnBuscar_Click(Nothing, Nothing)
                End If

            End If
            Catch ex As Exception
                HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
            End Try



    End Sub

  Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtGuiaRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub
  
End Class
