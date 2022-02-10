Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF

Public Class frmDisponibilidadInventario

#Region "Variables"
    Private DtReporte As New DataTable

#End Region

#Region "Eventos de Formulario"
    Private Sub frmDisponibilidadInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Listar_Compania()
        CargarClientes()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TYPEDEF.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        If Not AsValidarFiltro() Then
            Return
        End If
        ListarDisponibilidadInventario()
    End Sub

    Private Sub tsbExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarXLS.Click
        Try
            Dim oDt As New DataTable
            Dim odtNew As New DataTable
            Dim oDs As New DataSet
            Dim oblInventarioMercaderia As New blRegistroInventario()
            If dgDisInventario.RowCount > 0 Then
                'oDt = oblInventarioMercaderia.ListarDisponibilidadInventario(ObtenerObjetobeDisponibilidadInventario()).Tables(0)
                odtNew = DtReporte.Copy()
                odtNew.TableName = "Disponibilidad de Inventario"
                odtNew.Columns(0).ColumnName = "CÓDIGO \n MERCADERIA"
                odtNew.Columns(1).ColumnName = "ORDEN \n SERVICIO"
                odtNew.Columns(2).ColumnName = "DETALLE \n MERCADERIA"
                odtNew.Columns(3).ColumnName = " STOCK \n CANTIDAD DISPONIBLE " + vbNewLine + "(A)"
                odtNew.Columns(4).ColumnName = " STOCK \n CANTIDAD INMOVILIZADO " + vbNewLine + "(B)"
                odtNew.Columns(5).ColumnName = " STOCK \n UNIDAD"
                odtNew.Columns(6).ColumnName = " STOCK \n PESO DISPONIBLE"
                odtNew.Columns(7).ColumnName = " STOCK \n PESO INMOVILIZADO"
                odtNew.Columns(8).ColumnName = " STOCK \n UNIDAD MEDIDA"
                odtNew.Columns(9).ColumnName = "DISPONIBILIDAD DE \n INVENTARIO" + vbNewLine + "(B/A)"
                oDs.Tables.Add(odtNew)
                Dim strTitulo As New List(Of String)
                strTitulo.Add("Compañia : \n" & UcCompania_Cmb011.CCMPN_Descripcion)
                strTitulo.Add("División : \n" & UcDivision_Cmb011.DivisionDescripcion)
                strTitulo.Add("Planta : \n" & UcPLanta_Cmb011.DescripcionPlanta)
                strTitulo.Add("Cliente : \n" & txtCliente.pRazonSocial)
                strTitulo.Add("Fecha : \n" & dteFechaInvInicial.Value.ToShortDateString)
                '==========================Exportamos==========================
                HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al exportar: " + ex.Message, "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos y Funciones"
    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub ListarDisponibilidadInventario()
        Try
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim dtListaCabEri As New DataTable
            DtReporte = oblInventarioMercaderia.ListarDisponibilidadInventario(ObtenerObjetobeDisponibilidadInventario()).Tables(0)
            dtListaCabEri = DtReporte.Copy()
            dgDisInventario.AutoGenerateColumns = False
            dgDisInventario.DataSource = dtListaCabEri
            If dgDisInventario.RowCount > 0 Then
                tsbExportarXLS.Enabled = True
                tsbExportarXLS.Enabled = True
            End If

        Catch ex As Exception
            'MessageBox.Show("Ocurrio un error al listar el cabecera de ERI : " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function ObtenerObjetobeDisponibilidadInventario() As beProductoxRegularizar
        Dim objbeProductoxRegularizar As New beProductoxRegularizar
        objbeProductoxRegularizar.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeProductoxRegularizar.PSCCVSN = UcDivision_Cmb011.Division
        objbeProductoxRegularizar.PNCPLNDV = UcPLanta_Cmb011.Planta
        objbeProductoxRegularizar.PNCCLNT = txtCliente.pCodigo
        objbeProductoxRegularizar.PSCTPDP6 = "1"
        objbeProductoxRegularizar.PNFECINV = Convert.ToDecimal(HelpClass.CDate_a_Numero8Digitos(dteFechaInvInicial.Value))
        Return objbeProductoxRegularizar
    End Function

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por lo siguiente : {0}", Environment.NewLine)
        If UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            'MessageBox.Show("Debe de seleccionar Campaña.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar Campaña. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcDivision_Cmb011.Division = Nothing Or UcDivision_Cmb011.Division.Trim() = String.Empty Then
            'MessageBox.Show("Debe de seleccionar Division.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar División. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcPLanta_Cmb011.Planta = Nothing Or UcPLanta_Cmb011.Planta = 0 Then
            'MessageBox.Show("Debe de seleccionar Planta.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar Planta. {0}", Environment.NewLine)
            booOk = False
        End If
        If txtCliente.pCodigo.ToString().Trim() = Nothing Or txtCliente.pCodigo.ToString().Trim() = String.Empty Or txtCliente.pCodigo = 0 Then
            'MessageBox.Show("Debe de ingresar Cliente.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de ingresar Cliente. {0}", Environment.NewLine)
            booOk = False
        End If
        If dteFechaInvInicial.Value = Nothing Then
            'MessageBox.Show("Debe seleccionar una fecha.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe seleccionar una fecha. {0}", Environment.NewLine)
            booOk = False
        End If
        If Not booOk Then
            MessageBox.Show(strMensajeError, "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function
#End Region

End Class