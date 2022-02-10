Imports SOLMIN_SC.NEGOCIO
Imports SOLMIN_SC.Entidad
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Imports System.Text
Imports System.IO
Imports Ransa.Utilitario.UCPaginacion
'Imports SOLMIN_SC.Utilitario.HelpClassUtility

Public Class frmCompaniaTransporte

#Region "Variables"

  Dim objNegocio As New Negocio.clsCiaTransporte
  Private dtPrincipal As New DataTable
  Private TotalPaginas As Integer

  Private texto_Guardar As String = "Guardar"
  Private texto_Modificar As String = "Modificar"
  Private texto_Registrar As String = "Registrar"

#End Region

  Private Sub Buscar_Cia_Transportista()

    Dim objLogica As New Negocio.clsCiaTransporte()
    Dim objEntidad As New Entidad.beCiaTransporte()
    UcPaginacion.PageNumber = 1

    If Me.txtCodBusqueda.Text = Nothing Then
      objEntidad.PNCAGNCR_INI = 0
      objEntidad.PNCAGNCR_FIN = 999999
    Else
      objEntidad.PNCAGNCR_INI = Val(Me.txtCodBusqueda.Text)
      objEntidad.PNCAGNCR_FIN = Val(Me.txtCodBusqueda.Text)
    End If
    objEntidad.PSTNMCIN = Me.txtTransportista.Text.ToUpper.Trim
    If (Me.cmbEstado.SelectedValue = "1") Then
      objEntidad.PSSESTRG = "A"
    ElseIf (Me.cmbEstado.SelectedValue = "2") Then
      objEntidad.PSSESTRG = "*"
    End If
    Dim dtResultado As New DataTable
    dtResultado = objLogica.Lista_Cia_Transporte(objEntidad)
    dtPrincipal = dtResultado.Copy
    TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
    UcPaginacion.PageCount = TotalPaginas

  End Sub

  Enum Mantenimiento
    Inicio
    Edicion
    Nuevo
    Inactivo
  End Enum

    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento)

        Dim Estado As String = ""
        Estado = cmbEstado.SelectedValue
        '1 : Activo
        '2 : Inactivo

        Select Case opc

            Case Mantenimiento.Inicio

                txtCodigo.Text = ""
                txtCompaniaTransporte.Text = ""
                txtDireccion.Text = ""
                cmbMedioTransporte.SelectedValue = 0
                cmbPais.SelectedValue = -1D

                txtCodigo.Enabled = False
                txtCompaniaTransporte.Enabled = False
                txtDireccion.Enabled = False
                cmbMedioTransporte.Enabled = False
                cmbPais.Enabled = False

                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Modificar
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True

                Select Case Estado
                    Case "1"
                        btnNuevo.Enabled = True
                        btnRestablecer.Enabled = False
                    Case "2"
                        btnNuevo.Enabled = False
                        btnRestablecer.Enabled = True
                        btnGuardar.Enabled = False
                        btnEliminar.Enabled = False

                End Select

            Case Mantenimiento.Nuevo

                txtCompaniaTransporte.Enabled = True
                txtDireccion.Enabled = True
                cmbMedioTransporte.Enabled = True
                cmbPais.Enabled = True
                txtCodigo.Text = ""
                txtCompaniaTransporte.Text = ""
                txtDireccion.Text = ""
                cmbMedioTransporte.SelectedValue = 0
                cmbPais.SelectedValue = -1D
                txtCodigo.Focus()


                btnRestablecer.Enabled = False
                btnEliminar.Enabled = False
                btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Registrar
                btnNuevo.Enabled = False
                txtCodigo.Enabled = False

            Case Mantenimiento.Edicion

                btnGuardar.Text = texto_Guardar
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnRestablecer.Enabled = False


                txtCodigo.Enabled = False
                txtCompaniaTransporte.Enabled = True
                txtDireccion.Enabled = True
                cmbMedioTransporte.Enabled = True
                cmbPais.Enabled = True

        End Select

    End Sub

  

  Private Sub txtTransportista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransportista.KeyPress
    Try
      If e.KeyChar = Chr(13) Then
                btnBuscar_Click(btnBuscar, Nothing)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

    Private Sub txtCodBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBusqueda.KeyPress
        If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
        Select Case AscW(e.KeyChar)
            Case 8
                e.Handled = False
            Case 13
                btnBuscar_Click(btnBuscar, Nothing)
        End Select
    End Sub

    'Private Sub dtgCiaTransporte_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCiaTransporte.CellClick
    '  Try
    '    If e.RowIndex < 0 Or Me.dtgCiaTransporte.CurrentCellAddress.Y < 0 Then
    '      Exit Sub
    '          End If
    '          HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '    SeleccionarRegistro()

    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

    'Private Sub dtgCiaTransporte_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgCiaTransporte.KeyUp
    '    Try
    '        If dtgCiaTransporte.CurrentCellAddress.Y < 0 Then Exit Sub
    '        Select Case e.KeyCode
    '            Case Keys.Enter, Keys.Up, Keys.Down
    '                HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '                SeleccionarRegistro()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub dtgCiaTransporte_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCiaTransporte.CurrentCellChanged

    '    Try
    '        If dtgCiaTransporte.CurrentRow IsNot Nothing Then
    '            If Me.dtgCiaTransporte.CurrentCellAddress.Y < 0 Then
    '                Exit Sub
    '            End If
    '            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '            SeleccionarRegistro()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub SeleccionarRegistro()

        If dtgCiaTransporte.CurrentRow IsNot Nothing Then
            Dim lint_indice As Integer = Me.dtgCiaTransporte.CurrentCellAddress.Y
            Me.txtCodigo.Text = Me.dtgCiaTransporte.Item("CCIANV", lint_indice).Value.ToString.Trim
            Me.txtCompaniaTransporte.Text = ("" & Me.dtgCiaTransporte.Item("TNMCIN", lint_indice).Value).ToString.Trim
            Me.txtDireccion.Text = ("" & Me.dtgCiaTransporte.Item("TDIRCN", lint_indice).Value).ToString.Trim

            Dim CMEDTR As Decimal = Me.dtgCiaTransporte.Item("CMEDTR", lint_indice).Value
            If CMEDTR = 0 Then
                Me.cmbMedioTransporte.SelectedValue = 0
            ElseIf CMEDTR > 0 Then
                Me.cmbMedioTransporte.SelectedValue = CMEDTR
            End If
            Dim CPAIS As Decimal = Me.dtgCiaTransporte.Item("CPAIS", lint_indice).Value
            If CPAIS = 0 Then
                Me.cmbPais.SelectedValue = -1D
            ElseIf CPAIS > 0 Then
                Me.cmbPais.SelectedValue = CPAIS
            End If
        Else
            Me.txtCodigo.Clear()
            Me.txtCompaniaTransporte.Clear()
            Me.txtDireccion.Clear()
            Me.cmbMedioTransporte.SelectedValue = 0
            Me.cmbPais.SelectedValue = -1D

        End If
    End Sub


    Private Sub frmCompaniaTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgCiaTransporte.AutoGenerateColumns = False
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Cargar_Medio_Transporte()
            Llenar_Paises()
            LlenarEstado()
            cmbEstado_SelectionChangeCommitted(cmbEstado, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub LlenarEstado()

        Dim dt As New DataTable
    dt.Columns.Add("Display")
    dt.Columns.Add("Value")
    Dim dr As DataRow

    dr = dt.NewRow
    dr("Display") = "Activo"
    dr("Value") = "1"
    dt.Rows.Add(dr)

    dr = dt.NewRow
    dr("Display") = "Inactivo"
    dr("Value") = "2"
    dt.Rows.Add(dr)

    cmbEstado.DataSource = dt
    cmbEstado.DisplayMember = "Display"
    cmbEstado.ValueMember = "Value"
    cmbEstado.SelectedValue = "1"

  End Sub

  Private Sub Cargar_Medio_Transporte()
    Dim oEnvio As New clsEnvio
    Dim dtMedio As New DataTable
    dtMedio = oEnvio.Listar_Envio(1)
    Dim dr As DataRow
    dr = dtMedio.NewRow
    dr("CMEDTR") = "0"
    dr("TNMMDT") = "::Seleccione::"
    dtMedio.Rows.InsertAt(dr, 0)
    cmbMedioTransporte.DataSource = dtMedio
    cmbMedioTransporte.ValueMember = "CMEDTR"
    cmbMedioTransporte.DisplayMember = "TNMMDT"
  End Sub

  Private Sub Llenar_Paises()
    Dim oBL_Pais As New Negocio.clsPais
    Dim obePais As bePais
    Dim oListPaisOrigen As New List(Of bePais)

    oListPaisOrigen = oBL_Pais.Listar_Pais
    obePais = New bePais
    obePais.PNCPAIS = -1
        obePais.PSTCMPPS = "::Seleccione::"
    oListPaisOrigen.Insert(0, obePais)

    Me.cmbPais.DataSource = oListPaisOrigen
    Me.cmbPais.ValueMember = "PNCPAIS"
    Me.cmbPais.DisplayMember = "PSTCMPPS"
    Me.cmbPais.SelectedValue = -1D

  End Sub
 

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
            HabilitarBotonMantenimiento(Mantenimiento.Nuevo)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    Me.txtCompaniaTransporte.Text = Me.txtCompaniaTransporte.Text.Trim
    If Me.txtCompaniaTransporte.Text = "" Then
      sbMensaje.AppendLine("* Compañia de Transporte")
    End If
    Return sbMensaje.ToString
  End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim TextoOpcion As String = btnGuardar.Text
            Select Case TextoOpcion
                Case texto_Modificar
                    If Me.dtgCiaTransporte.CurrentRow IsNot Nothing Then
                        HabilitarBotonMantenimiento(Mantenimiento.Edicion)
                    End If
                Case texto_Guardar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Modificar_Registro()
                    End If
                Case texto_Registrar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Registrar_Registro()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Registrar_Registro()
        Dim PNCMEDIOTRANSPORTE As Decimal = 0
        Dim PNCPAIS As Decimal = 0
        PNCMEDIOTRANSPORTE = Me.cmbMedioTransporte.SelectedValue
        PNCPAIS = Me.cmbPais.SelectedValue
        If PNCPAIS = -1D Then
            PNCPAIS = 0
        End If
        If objNegocio.Registrar_CiaTransporte(Me.txtCompaniaTransporte.Text.Trim, Me.txtDireccion.Text.Trim, PNCMEDIOTRANSPORTE, PNCPAIS) = 1 Then
            MessageBox.Show("Registro ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Cia_Transportista()
            ListarCiaTransporte()
        End If
    End Sub


  Public Sub Modificar_Registro()

    Dim PNCMEDIOTRANSPORTE As Decimal = 0
    Dim PNCPAIS As Decimal = 0
    PNCMEDIOTRANSPORTE = Me.cmbMedioTransporte.SelectedValue
    PNCPAIS = Me.cmbPais.SelectedValue
    If PNCPAIS = -1D Then
      PNCPAIS = 0
    End If
        If objNegocio.Actualizar_CiaTransporte(Me.txtCodigo.Text.Trim, Me.txtCompaniaTransporte.Text.Trim, Me.txtDireccion.Text.Trim, PNCMEDIOTRANSPORTE, PNCPAIS) = 1 Then
            MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Cia_Transportista()
            ListarCiaTransporte()
        End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Try
      If dtgCiaTransporte.CurrentRow IsNot Nothing Then
        If MessageBox.Show("Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
          If objNegocio.Eliminar_CiaTransporte(Me.txtCodigo.Text) = 1 Then
                        MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Cia_Transportista()
            ListarCiaTransporte()
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        Try
            If MessageBox.Show("Desea restablecer el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If objNegocio.Restablecer_CiaTransporte(Me.txtCodigo.Text) = 1 Then
                    MessageBox.Show("Registro restablecido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
                    Buscar_Cia_Transportista()
                    ListarCiaTransporte()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


  Private Sub txtCompaniaTransporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompaniaTransporte.KeyPress, txtDireccion.KeyPress, cmbMedioTransporte.KeyPress
    If e.KeyChar = ChrW(Keys.Enter) Then
      e.Handled = True
      SendKeys.Send("{TAB}")
    End If
  End Sub

  

    Private Sub cmbEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectionChangeCommitted
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Cia_Transportista()
            ListarCiaTransporte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
      UcPaginacion.PageCount = TotalPaginas
      ListarCiaTransporte()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Sub ListarCiaTransporte()
    Me.dtgCiaTransporte.DataSource = Nothing
        dtgCiaTransporte.DataSource = HelpUtil.PaginarDatos(dtPrincipal, UcPaginacion.PageSize, UcPaginacion.PageNumber)
        SeleccionarRegistro()
  End Sub

   
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim odtExportar As New DataTable
            Dim MdataColumna As String = ""

            If Me.dtgCiaTransporte.RowCount = 0 OrElse Me.dtgCiaTransporte.CurrentCellAddress.Y < 0 Then Exit Sub
            If dtgCiaTransporte.Rows.Count = 0 Then Exit Sub

            odtExportar.Columns.Add("CCIANV")
            MdataColumna = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("CCIANV").Caption = MdataColumna

            odtExportar.Columns.Add("TNMCIN")
            MdataColumna = NPOI_SC.FormatDato("Compañia de Transporte", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TNMCIN").Caption = MdataColumna

            odtExportar.Columns.Add("TDIRCN")
            MdataColumna = NPOI_SC.FormatDato("Dirección", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TDIRCN").Caption = MdataColumna

            odtExportar.Columns.Add("TNMMDT")
            MdataColumna = NPOI_SC.FormatDato("Medio de Transporte", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TNMMDT").Caption = MdataColumna

            odtExportar.Columns.Add("TCMPPS")
            MdataColumna = NPOI_SC.FormatDato("País", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TCMPPS").Caption = MdataColumna

            odtExportar.Columns.Add("SESTRG_DESC")
            MdataColumna = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("SESTRG_DESC").Caption = MdataColumna

            Dim dr As DataRow

            Dim NameColumna As String = ""
            For Each drDatos As DataRow In dtPrincipal.Rows
                dr = odtExportar.NewRow
                For Each dcColumna As DataColumn In odtExportar.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos(NameColumna)
                Next
                odtExportar.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(2) = "Hora:|" & Now.ToString("hh:mm:ss")
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtExportar, "LISTADO DE CONPAÑIAS DE TRANSPORTE", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO DE CONPAÑIAS DE TRANSPORTE")
            ' HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTADO DE VAPORES", Nothing, oLisParametros)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Cia_Transportista()
            ListarCiaTransporte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgCiaTransporte_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCiaTransporte.SelectionChanged
        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
        SeleccionarRegistro()
    End Sub
End Class


