Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF

Public Class frmExactirudRegInv

#Region "Propiedades"
    Private _PSCCMPN As String
    Private _PDCPLNDV As Decimal
    Private _PDCCLNT As Decimal
    Private _PSDESCCLNT As String
#End Region

#Region "Variables"
    Private DtReporte As New DataTable
    Dim sNroEri As String
    Private PNFECHINV As Decimal
#End Region

#Region "Metodos y Funciones"
    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub CargarCompania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarPlanta()
        If Not UcCompania_Cmb011.CCMPN_CodigoCompania <> Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            Return
        End If
        UcPLanta_Cmb011.CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por los siguientes errores: {0}", Environment.NewLine)
        If UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            'MessageBox.Show("Debe de seleccionar Campaña.", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar Campaña. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcPLanta_Cmb011.Planta = Nothing Or UcPLanta_Cmb011.Planta = 0 Then
            'MessageBox.Show("Debe de seleccionar Planta.", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar Planta. {0}", Environment.NewLine)
            booOk = False
        End If
        If txtCliente.pCodigo.ToString().Trim() = Nothing Or txtCliente.pCodigo.ToString().Trim() = String.Empty Or txtCliente.pCodigo = 0 Then
            'MessageBox.Show("Debe de ingresar Cliente.", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de ingresar Cliente. {0}", Environment.NewLine)
            booOk = False
        End If
        If dteFechaInvInicial.Value = Nothing Then
            'MessageBox.Show("Debe seleccionar una fecha de Inicio", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe seleccionar una fecha de Inicio. {0}", Environment.NewLine)
            booOk = False
        End If
        If dteFechaInvFinal.Value = Nothing Then
            'MessageBox.Show("Debe seleccionar una fecha de Fin", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe seleccionar una fecha de Fin. {0}", Environment.NewLine)
            booOk = False
        End If
        If Not booOk Then
            MessageBox.Show(strMensajeError, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function

    Private Sub ListarCabeceraERI()
        dgCabInventario.DataSource = Nothing
        dgDetInventario.DataSource = Nothing

        Try
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim dtListaCabEri As New DataTable
            DtReporte = oblInventarioMercaderia.ListarCabeceraERI(ObtenerObjetobeCabeceraERI()).Tables(0)
            dtListaCabEri = DtReporte.Copy()
            dgCabInventario.AutoGenerateColumns = False
            dgCabInventario.DataSource = dtListaCabEri
            If dgCabInventario.RowCount > 0 Then
                tsbExportarXLS.Enabled = True
                tsbGenerarInvSistema.Enabled = True
                tsbAdjuntarInvFi.Enabled = True
                tsbAjustarInv.Enabled = True
                Dim strFechaInv As String
                For i1 As Integer = 0 To dgCabInventario.RowCount - 1
                    strFechaInv = dgCabInventario.Rows(i1).Cells("fecinv").Value
                    dgCabInventario.Rows(i1).Cells("fecinvdes").Value = HelpClass.CFecha_de_8_a_10(strFechaInv)
                Next
            Else
                tsbExportarXLS.Enabled = False
                'tsbGenerarInvSistema.Enabled = False
                tsbAdjuntarInvFi.Enabled = False
                tsbAjustarInv.Enabled = False
            End If


        Catch ex As Exception
            'MessageBox.Show("Ocurrio un error al listar el cabecera de ERI : " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ListarDetalleERI(ByVal snroEri As String)
        Try
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim dtListaDetEri As New DataTable
            dtListaDetEri = oblInventarioMercaderia.ListarDetalleERI(ObtenerObjetobeInventarioDetallERI()).Tables(0)
            'dtListaDetEri.Columns.Remove("NCRRDT")
            dgDetInventario.AutoGenerateColumns = False
            dgDetInventario.DataSource = dtListaDetEri
            If dgDetInventario.RowCount > 0 Then
                tsbExportarXLS.Enabled = True
                tsbGenerarInvSistema.Enabled = True
                tsbAdjuntarInvFi.Enabled = True
                tsbAjustarInv.Enabled = True
                Dim intConta As Integer = 0
                For i1 As Integer = 0 To dgDetInventario.RowCount - 1
                    intConta = intConta + 1
                    dgDetInventario.Rows(i1).Cells("nroCorrelativo").Value = intConta.ToString()
                Next
            Else
                dgDetInventario.DataSource = Nothing
                tsbExportarXLS.Enabled = True
                'tsbGenerarInvSistema.Enabled = True
                tsbAdjuntarInvFi.Enabled = True
                tsbAjustarInv.Enabled = True
            End If
        Catch ex As Exception
            'MessageBox.Show("Ocurrio un error al listar el detalle de ERI : " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function ObtenerObjetobeInventarioExcel()
        Dim objbeInvenatarioExcel As New beInventarioExcel
        objbeInvenatarioExcel.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeInvenatarioExcel.PSCRGVTA = txtCliente.pNegocio
        objbeInvenatarioExcel.PNCPLNDV = UcPLanta_Cmb011.Planta
        objbeInvenatarioExcel.PNCCLNT = txtCliente.pCodigo
        objbeInvenatarioExcel.PNNROERI = Convert.ToDecimal(sNroEri)
        Return objbeInvenatarioExcel
    End Function

    Private Function ObtenerObjetobeInventarioDetallERI() As beInventarioDetallERI
        Dim objbeInventarioDetallEri As New beInventarioDetallERI
        objbeInventarioDetallEri.IN_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeInventarioDetallEri.IN_CRGVTA = txtCliente.pNegocio
        objbeInventarioDetallEri.IN_CPLNDV = UcPLanta_Cmb011.Planta
        objbeInventarioDetallEri.IN_CCLNT = txtCliente.pCodigo
        objbeInventarioDetallEri.IN_NROERI = Convert.ToDecimal(sNroEri)
        Return objbeInventarioDetallEri
    End Function

    Private Function ObtenerObjetobeCabeceraERI() As beCabeceraERI
        Dim objbeCabeceraEri As New beCabeceraERI
        objbeCabeceraEri.IN_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeCabeceraEri.IN_CRGVTA = txtCliente.pNegocio
        objbeCabeceraEri.IN_CPLNDV = UcPLanta_Cmb011.Planta
        objbeCabeceraEri.IN_CCLNT = txtCliente.pCodigo
        objbeCabeceraEri.IN_FECINVINI = Convert.ToDecimal(HelpClass.CDate_a_Numero8Digitos(dteFechaInvInicial.Value))
        objbeCabeceraEri.IN_FECINVFIN = Convert.ToDecimal(HelpClass.CDate_a_Numero8Digitos(dteFechaInvFinal.Value))
        Return objbeCabeceraEri
    End Function

    Private Sub Limpiar()
        dgDetInventario.AutoGenerateColumns = False
        dgDetInventario.DataSource = Nothing
    End Sub
#End Region

#Region "Eventos de Formulario"
    Private Sub frmExactirudRegInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarCompania()
        CargarPlanta()
        dteFechaInvInicial.Value = Now
        dteFechaInvFinal.Value = Now
        dteFechaInvInicial.Format = DateTimePickerFormat.Custom
        dteFechaInvInicial.CustomFormat = "dd/MM/yyyy"
        dteFechaInvFinal.Format = DateTimePickerFormat.Custom
        dteFechaInvFinal.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        If Not UcCompania_Cmb011.CCMPN_CodigoCompania <> Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            Return
        End If
        UcPLanta_Cmb011.CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub dgCabInventario_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCabInventario.SelectionChanged
        If Me.dgCabInventario.CurrentCellAddress.Y = -1 Then
            Limpiar()
            dgDetInventario.DataSource = Nothing
            Exit Sub
        End If
        sNroEri = dgCabInventario.CurrentRow.Cells("nroeri").Value
        PNFECHINV = dgCabInventario.CurrentRow.Cells("fecinv").Value
        If Not IsDBNull(sNroEri) Then
            ListarDetalleERI(Convert.ToDecimal(sNroEri))
            _PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            _PDCPLNDV = UcPLanta_Cmb011.Planta
            _PDCCLNT = txtCliente.pCodigo
            _PSDESCCLNT = txtCliente.pRazonSocial
        End If
    End Sub

    Private Sub dgCabInventario_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgCabInventario.CellMouseClick
        If dgCabInventario.RowCount > 0 Then
            sNroEri = dgCabInventario.CurrentRow.Cells("nroeri").Value
            PNFECHINV = dgCabInventario.CurrentRow.Cells("fecinv").Value
            If Not IsDBNull(sNroEri) Then
                ListarDetalleERI(Convert.ToDecimal(sNroEri))
                _PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                _PDCPLNDV = UcPLanta_Cmb011.Planta
                _PDCCLNT = txtCliente.pCodigo
                _PSDESCCLNT = txtCliente.pRazonSocial
            End If
        Else
            dgDetInventario.DataSource = Nothing
        End If
    End Sub

    Private Sub tsbGenerarInvSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarInvSistema.Click
        If Not AsValidarFiltro() Then
            Return
        End If
        _PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        _PDCPLNDV = UcPLanta_Cmb011.Planta
        _PDCCLNT = txtCliente.pCodigo
        _PSDESCCLNT = txtCliente.pRazonSocial
        Dim frm As New frmGenerarERI
        frm.PSCCMPN = _PSCCMPN
        frm.PNCPLNDV = _PDCPLNDV
        frm.PNCCLNT = _PDCCLNT
        frm.PSDESCCLNT = _PSDESCCLNT
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            If Not AsValidarFiltro() Then
                Return
            End If
            ListarCabeceraERI()
        End If

        frm.Close()
        frm = Nothing

    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        If Not AsValidarFiltro() Then
            Return
        End If
        ListarCabeceraERI()
    End Sub

    Private Sub tsbExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarXLS.Click
        Try
            Dim oDt As New DataTable
            Dim odtNew As New DataTable
            Dim oDs As New DataSet
            Dim oblInventarioMercaderia As New blRegistroInventario()
            If dgCabInventario.RowCount > 0 Then
                Dim SNROERI As String = dgCabInventario.CurrentRow.Cells("nroeri").Value
                If Not IsDBNull(SNROERI) Then
                    oDt = oblInventarioMercaderia.ListaInventarioExportXFecha(ObtenerObjetobeInventarioExcel()).Tables(0)
                    odtNew = oDt.Copy()
                    odtNew.TableName = "Inventario de Productos"
                    odtNew.Columns(0).ColumnName = "CÓDIGO \n MERCADERIA"
                    odtNew.Columns(1).ColumnName = "ORDEN \n SERVICIO"
                    odtNew.Columns(2).ColumnName = "DETALLE \n MERCADERIA"
                    odtNew.Columns(3).ColumnName = " \n STOCK SISTEMA"
                    odtNew.Columns(4).ColumnName = " \n STOCK FISICO"
                    odtNew.Columns(5).ColumnName = " \n UNIDAD"
                    odtNew.Columns(6).ColumnName = " \n PORCENTAJE ERI"
                    oDs.Tables.Add(odtNew)
                    Dim strTitulo As New List(Of String)
                    strTitulo.Add("Compañía : \n" & UcCompania_Cmb011.CCMPN_Descripcion)
                    strTitulo.Add("Planta : \n" & UcPLanta_Cmb011.DescripcionPlanta)
                    strTitulo.Add("Cliente : \n" & txtCliente.pRazonSocial)
                    strTitulo.Add("Nro. Doc. ERI : \n" & SNROERI)
                    strTitulo.Add("Fecha : \n" & Date.Now.ToShortDateString)
                    '==========================Exportamos==========================
                    HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al exportar: " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub tsbAdjuntarInvFi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntarInvFi.Click
        If Me.dgCabInventario.CurrentCellAddress.Y < 0 Then Exit Sub
        If dgCabInventario.RowCount <= 0 Then
            MessageBox.Show("Seleccione un registro para adjuntar inventario ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If dgCabInventario.CurrentRow.Cells("stseri").Value.ToString().Trim() = "C" Then
            MessageBox.Show("No se puede Adjuntar Reg. Inventario por que el registro tiene estado Cerrado ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim frm As New frmAdjuntarInvFisicoERI
        frm.PSCCMPN = _PSCCMPN
        frm.PNCPLNDV = _PDCPLNDV
        frm.PNCCLNT = _PDCCLNT
        frm.PSNroEri = sNroEri
        frm.PSCRGVTA = txtCliente.pNegocio
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            If Not AsValidarFiltro() Then
                Return
            End If
            ListarCabeceraERI()
        End If
        frm.Close()
        frm = Nothing
    End Sub

    Private Sub tsbAjustarInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAjustarInv.Click
        If Me.dgCabInventario.CurrentCellAddress.Y < 0 Then Exit Sub
        If dgCabInventario.RowCount <= 0 Then
            MessageBox.Show("Seleccione un registro para Generar ajuste de inventario ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If dgCabInventario.CurrentRow.Cells("stseri").Value.ToString().Trim() = "C" Then
            MessageBox.Show("No se puede Ajustar Inventario por que el registro tiene estado Cerrado ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim frm As New frmAjustarInventario
        frm.PSCCMPN = _PSCCMPN
        frm.PNCPLNDV = _PDCPLNDV
        frm.PNCCLNT = _PDCCLNT
        If sNroEri = String.Empty Then
            sNroEri = "0"
        End If
        frm.PNNROERI = Convert.ToDecimal(sNroEri)
        frm.PNFECHINV = PNFECHINV
        frm.PSCRGVTA = txtCliente.pNegocio
        frm.PSCTPDP6 = "1"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            If Not AsValidarFiltro() Then
                Return
            End If
            ListarCabeceraERI()
        End If
        frm.Close()
        frm = Nothing
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
#End Region
End Class