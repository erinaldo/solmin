Imports Ransa.TypeDef
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports System.IO
Imports RANSA.Utilitario

Public Class frmMovPorFechaDet

#Region " Funciones y Procedimientos "

    Private Sub Cargar_Cliente()
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub

    Private Sub Cargar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcPLanta_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Controles()
      
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        Dim oListColumME As New Hashtable
        Dim oColumnasME As New DataGridViewTextBoxColumn
        oColumnasME.Name = "CODIGO"
        oColumnasME.DataPropertyName = "PNCMEDTR"
        oColumnasME.HeaderText = "Código "
        oListColumME.Add(1, oColumnasME)
        oColumnasME = New DataGridViewTextBoxColumn
        oColumnasME.Name = "DETALLE"
        oColumnasME.DataPropertyName = "PSTNMMDT"
        oColumnasME.HeaderText = "Medio Envío"
        oListColumME.Add(2, oColumnasME)

        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
      
        Dim oListaMedEnv As New List(Of beGeneral)
        oListaMedEnv = obrGeneral.ListaMedioTransporte(obeMedioTransporte)
        txtMedioEnvio.DataSource = oListaMedEnv

        txtMedioEnvio.ListColumnas = oListColumME
        txtMedioEnvio.Cargas()
        txtMedioEnvio.ValueMember = "PNCMEDTR"
        txtMedioEnvio.DispleyMember = "PSTNMMDT"

        'MPS
        Dim oListColumMEC As New Hashtable
        Dim oColumnasMEC As New DataGridViewTextBoxColumn
        oColumnasMEC.Name = "CODIGO"
        oColumnasMEC.DataPropertyName = "PNCMEDTR"
        oColumnasMEC.HeaderText = "Código "
        oListColumMEC.Add(1, oColumnasMEC)
        oColumnasMEC = New DataGridViewTextBoxColumn
        oColumnasMEC.Name = "DETALLE"
        oColumnasMEC.DataPropertyName = "PSTNMMDT"
        oColumnasMEC.HeaderText = "Medio Envío Confirmado"
        oListColumMEC.Add(2, oColumnasMEC)

        Dim obeMedioTransporteC As New Ransa.TypeDef.beGeneral
      
        Dim oListaMedEnvC As New List(Of beGeneral)
        oListaMedEnvC = obrGeneral.ListaMedioTransporte(obeMedioTransporteC)
        txtMedioEnvioC.DataSource = oListaMedEnvC
        txtMedioEnvioC.ListColumnas = oListColumMEC
        txtMedioEnvioC.Cargas()
        txtMedioEnvioC.ValueMember = "PNCMEDTR"
        txtMedioEnvioC.DispleyMember = "PSTNMMDT"

    End Sub

   

  
#End Region
#Region " Eventos"
    Private Sub frmMovimientoPorFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Cargar_Cliente()
            Cargar_Compania()
            Cargar_Controles()
            cmbMovimiento.SelectedItem() = "TODOS"
            rbOC.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Ingrese cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim oIngresoMovimientos As New beIngresoMovimientos
            Dim odtConsultaIntegral As New DataTable
            Dim bIngresoMovimientos As New brIngresoMovimientos
            With oIngresoMovimientos
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                If UcPLanta_Cmb011.Planta = -1 Then
                    .PNCPLNDV = 0
                Else
                    .PNCPLNDV = UcPLanta_Cmb011.Planta
                End If

                .PNCCLNT = txtCliente.pCodigo
                .PNFECINI = HelpClass.CtypeDate(Me.dteFechaInicial.Value)
                .PNFECFIN = HelpClass.CtypeDate(Me.dteFechaFinal.Value)
                Select Case cmbMovimiento.SelectedItem.ToString
                    Case "TODOS"
                        .PSTIPOMOV = "T"
                    Case "Recepcion"
                        .PSTIPOMOV = "R"
                    Case "Despacho"
                        .PSTIPOMOV = "D"
                End Select
                If txtMedioEnvio.Resultado Is Nothing Then
                    .PNMEDIOSUG = 0
                Else
                    .PNMEDIOSUG = CType(txtMedioEnvio.Resultado, beGeneral).PNCMEDTR
                End If

                If txtMedioEnvioC.Resultado Is Nothing Then
                    .PNMEDIOCONF = 0
                Else
                    .PNMEDIOCONF = CType(txtMedioEnvioC.Resultado, beGeneral).PNCMEDTR
                End If

                .PSNORCML = txtOC.Text.Trim
                .PNGUIAREMISION = Val(txtGRdespacho.Text)
                .PSGUIAPROV = txtGuiaProv.Text.Trim
                .PSBULTO = txtbulto.Text.Trim

                Dim c As Cursor = Me.Cursor
                Me.Cursor = Cursors.WaitCursor
                If rbItem.Checked = True Then

                    odtConsultaIntegral = bIngresoMovimientos.dtListarConsultaIntegralOCItem(oIngresoMovimientos)

                  

                    dgRecepcion.AutoGenerateColumns = False
                    dgRecepcion.DataSource = odtConsultaIntegral
                    dgRecepcion.Columns("NRO_ITEM").Visible = True
                    dgRecepcion.Columns("COD_PRODUCTO").Visible = True
                    dgRecepcion.Columns("DESCRIPCION_NRO_ITEM").Visible = True
                    dgRecepcion.Columns("ITEM_PAQUETE").Visible = False
                    dgRecepcion.Columns("CANTIDAD_PAQUETE").Visible = False
                    dgRecepcion.Columns("ALTO_PAQUETE").Visible = False
                    dgRecepcion.Columns("ANCHO_PAQUETE").Visible = False
                    dgRecepcion.Columns("LARGO_PAQUETE").Visible = False
                    dgRecepcion.Columns("VOLUMEN_PAQUETE").Visible = False
                    dgRecepcion.Columns("PESO_PAQUETE").Visible = False

                Else


                    odtConsultaIntegral = bIngresoMovimientos.dtListarConsultaIntegralOC(oIngresoMovimientos)
                    dgRecepcion.AutoGenerateColumns = False
                    dgRecepcion.DataSource = odtConsultaIntegral
                    dgRecepcion.Columns("NRO_ITEM").Visible = False
                    dgRecepcion.Columns("COD_PRODUCTO").Visible = False
                    dgRecepcion.Columns("DESCRIPCION_NRO_ITEM").Visible = False
                    dgRecepcion.Columns("ITEM_PAQUETE").Visible = False
                    dgRecepcion.Columns("CANTIDAD_PAQUETE").Visible = False
                    dgRecepcion.Columns("ALTO_PAQUETE").Visible = True
                    dgRecepcion.Columns("ANCHO_PAQUETE").Visible = True
                    dgRecepcion.Columns("LARGO_PAQUETE").Visible = True
                    dgRecepcion.Columns("VOLUMEN_PAQUETE").Visible = True
                    dgRecepcion.Columns("PESO_PAQUETE").Visible = True

                End If
                Me.Cursor = c
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub rbOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOC.CheckedChanged
        txtCodItem.Enabled = rbItem.Checked
    End Sub

    Private Sub rbItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbItem.CheckedChanged
        txtCodItem.Enabled = rbItem.Checked
    End Sub

   
#End Region

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Try
            Dim objListdt As New List(Of DataTable)
            Dim tabTraking As New DataTable

            tabTraking.TableName = "Reporte"

            For columna As Integer = 0 To dgRecepcion.Columns.Count - 1
                If dgRecepcion.Columns(columna).Visible = True Then
                    tabTraking.Columns.Add(dgRecepcion.Columns(columna).Name)
                End If
            Next

            'tabTraking.Columns.Add("CLIENTE")
            'tabTraking.Columns.Add("ORDEN_COMPRA")

            'If rbItem.Checked = True Then
            '    tabTraking.Columns.Add("NRO_ITEM")
            '    tabTraking.Columns.Add("COD_PRODUCTO")
            '    tabTraking.Columns.Add("DESCRIPCION_NRO_ITEM")
            'End If

            'tabTraking.Columns.Add("COD_BULTO")
            'tabTraking.Columns.Add("DESCRIPCION_BULTO")
            'tabTraking.Columns.Add("TIPO_CARGA")
            'tabTraking.Columns.Add("CUENTA_TERRESTRE")
            'tabTraking.Columns.Add("CUENTA_AEREA")
            'tabTraking.Columns.Add("CUENTA_FLUVIAL")
            'tabTraking.Columns.Add("CUENTA_ALMACENES")
            'tabTraking.Columns.Add("PLANTA")
            'tabTraking.Columns.Add("TIPO_ALMACEN")
            'tabTraking.Columns.Add("ALMACEN")
            'tabTraking.Columns.Add("ZONA_ALMACEN")
            'tabTraking.Columns.Add("UBICACION")
            'tabTraking.Columns.Add("F_RECEP_ALMACEN_OL")
            'tabTraking.Columns.Add("F_RECEP_CL")
            'tabTraking.Columns.Add("GUIA_PROVEEDOR")
            'tabTraking.Columns.Add("INCIDENCIA_MOTIVO")
            'tabTraking.Columns.Add("CANTIDAD_BULTO")
            'tabTraking.Columns.Add("TIPO_BULTO")

            'tabTraking.Columns.Add("PESO_BULTO")
            'tabTraking.Columns.Add("UNIDAD_PESO_BULTO")
            'tabTraking.Columns.Add("VOLUMEN_BULTO")
            'tabTraking.Columns.Add("UNIDAD_VOLUMEN_BULTO")
            'If rbOC.Checked = True Then
            '    tabTraking.Columns.Add("ITEM_PAQUETE")
            '    tabTraking.Columns.Add("CANTIDAD_PAQUETE")
            '    tabTraking.Columns.Add("ALTO_PAQUETE")
            '    tabTraking.Columns.Add("ANCHO_PAQUETE")
            '    tabTraking.Columns.Add("LARGO_PAQUETE")
            '    tabTraking.Columns.Add("VOLUMEN_PAQUETE")
            '    tabTraking.Columns.Add("PESO_PAQUETE")
            'End If

            'tabTraking.Columns.Add("DIA_CL")
            'tabTraking.Columns.Add("SENTIDO_CARGA")
            'tabTraking.Columns.Add("LUGAR_ENTREGA")
            'tabTraking.Columns.Add("F_SALIDA_ALMACEN_OL")
            'tabTraking.Columns.Add("F_SALIDA_CL")
            'tabTraking.Columns.Add("ESTADO_INVENTARIO")
            'tabTraking.Columns.Add("GUIA_REMISION_CLIENTE")
            'tabTraking.Columns.Add("MEDIO_ENVIO_SUGERIDO")
            'tabTraking.Columns.Add("MEDIO_ENVIO")
            'tabTraking.Columns.Add("LUGAR_ORIGEN")
            'tabTraking.Columns.Add("LUGAR_DESTINO")
            'tabTraking.Columns.Add("FECHA_SALIDA_REAL")
            'tabTraking.Columns.Add("FECHA_ESTIMADA_LLEGADA")
            'tabTraking.Columns.Add("FECHA_LLEGADA_REAL")
            'tabTraking.Columns.Add("TRANSPORTISTA")
            'tabTraking.Columns.Add("PLACA_TRACTO")
            'tabTraking.Columns.Add("TIPO_UNIDAD")
            'tabTraking.Columns.Add("MODELO_TRACTO")
            'tabTraking.Columns.Add("ESTADO_TRANSITO")
            'tabTraking.Columns.Add("FECHA_CONF_LLEGADA")

            '-----------
            objListdt.Add(tabTraking)
            Dim dr As DataRow
            Dim colName As String
            For Fila As Integer = 0 To dgRecepcion.Rows.Count - 1
                dr = tabTraking.NewRow
                For Columna As Integer = 0 To tabTraking.Columns.Count - 1
                    colName = tabTraking.Columns(Columna).ColumnName
                    If (dgRecepcion.Rows(Fila).Cells(colName).Value IsNot Nothing) Then
                        dr(colName) = dgRecepcion.Rows(Fila).Cells(colName).FormattedValue
                    End If
                Next
                tabTraking.Rows.Add(dr)
            Next

            Dim titulo As String = ""
            Dim NameColumna As String = ""
            For columna As Integer = 0 To dgRecepcion.Columns.Count - 1
                titulo = dgRecepcion.Columns(columna).HeaderText
                NameColumna = dgRecepcion.Columns(columna).Name
                If tabTraking.Columns(NameColumna) IsNot Nothing Then
                    tabTraking.Columns(NameColumna).ColumnName = titulo
                End If
            Next

            'tabTraking.Columns.Item("CLIENTE").ColumnName = "Cliente"
            'tabTraking.Columns.Item("ORDEN_COMPRA").ColumnName = "No O/C"

            'If rbItem.Checked = True Then
            '    tabTraking.Columns.Item("NRO_ITEM").ColumnName = "Nro Item"
            '    tabTraking.Columns.Item("COD_PRODUCTO").ColumnName = "Código Item"
            '    tabTraking.Columns.Item("DESCRIPCION_NRO_ITEM").ColumnName = "Descripción Item"
            'End If

            'tabTraking.Columns.Item("COD_BULTO").ColumnName = "Numero Bulto"
            'tabTraking.Columns.Item("DESCRIPCION_BULTO").ColumnName = "Descripcion Bulto"
            'tabTraking.Columns.Item("TIPO_CARGA").ColumnName = "Tipo de Carga"
            'tabTraking.Columns.Item("CUENTA_TERRESTRE").ColumnName = "Cuenta Imputación Terrestre"
            'tabTraking.Columns.Item("CUENTA_AEREA").ColumnName = "Cuenta Imputación Aérea"
            'tabTraking.Columns.Item("CUENTA_FLUVIAL").ColumnName = "Cuenta Imputación Fluvial"
            'tabTraking.Columns.Item("CUENTA_ALMACENES").ColumnName = "Cuenta Imputación Almacenes"
            'tabTraking.Columns.Item("PLANTA").ColumnName = "Planta"
            'tabTraking.Columns.Item("TIPO_ALMACEN").ColumnName = "Tipo Almacén"
            'tabTraking.Columns.Item("ALMACEN").ColumnName = "Almacén"
            'tabTraking.Columns.Item("ZONA_ALMACEN").ColumnName = "Zona"
            'tabTraking.Columns.Item("UBICACION").ColumnName = "Ubicación"
            'tabTraking.Columns.Item("F_RECEP_ALMACEN_OL").ColumnName = "Fec Recepción Almacén"
            'tabTraking.Columns.Item("F_RECEP_CL").ColumnName = "Fec Recepción CL"
            'tabTraking.Columns.Item("GUIA_PROVEEDOR").ColumnName = "Guía proveedor"
            'tabTraking.Columns.Item("INCIDENCIA_MOTIVO").ColumnName = "Incidencia / Motivo"
            'tabTraking.Columns.Item("CANTIDAD_BULTO").ColumnName = "Cantidad Bulto"
            'tabTraking.Columns.Item("TIPO_BULTO").ColumnName = "Tipo Bulto"

            'tabTraking.Columns.Item("PESO_BULTO").ColumnName = "Peso Bulto"
            'tabTraking.Columns.Item("UNIDAD_PESO_BULTO").ColumnName = "Unidad Bulto"
            'tabTraking.Columns.Item("VOLUMEN_BULTO").ColumnName = "Volumen Bulto"
            'tabTraking.Columns.Item("UNIDAD_VOLUMEN_BULTO").ColumnName = "Unidad Volumen"
            'If rbOC.Checked = True Then
            '    tabTraking.Columns.Item("ITEM_PAQUETE").ColumnName = "Item Paquete"
            '    tabTraking.Columns.Item("CANTIDAD_PAQUETE").ColumnName = "Cantidad Paquete"
            '    tabTraking.Columns.Item("ALTO_PAQUETE").ColumnName = "Altura (m)"
            '    tabTraking.Columns.Item("ANCHO_PAQUETE").ColumnName = "Ancho (m)"
            '    tabTraking.Columns.Item("LARGO_PAQUETE").ColumnName = "Largo (m)"
            '    tabTraking.Columns.Item("VOLUMEN_PAQUETE").ColumnName = "Volumen Paquete"
            '    tabTraking.Columns.Item("PESO_PAQUETE").ColumnName = "Peso Paquete"
            'End If

            'tabTraking.Columns.Item("DIA_CL").ColumnName = "Días en almacén"
            'tabTraking.Columns.Item("SENTIDO_CARGA").ColumnName = "Sentido"
            'tabTraking.Columns.Item("LUGAR_ENTREGA").ColumnName = "Lugar Entrega"
            'tabTraking.Columns.Item("F_SALIDA_ALMACEN_OL").ColumnName = "Fec Salida Almacén"
            'tabTraking.Columns.Item("F_SALIDA_CL").ColumnName = "Fec Salida CL"
            'tabTraking.Columns.Item("ESTADO_INVENTARIO").ColumnName = "Estado Inventario"
            'tabTraking.Columns.Item("GUIA_REMISION_CLIENTE").ColumnName = "Guía Remisión Cliente"
            'tabTraking.Columns.Item("MEDIO_ENVIO_SUGERIDO").ColumnName = "Medio Sugerido"
            'tabTraking.Columns.Item("MEDIO_ENVIO").ColumnName = "Medio Envio"
            'tabTraking.Columns.Item("LUGAR_ORIGEN").ColumnName = "Origen"
            'tabTraking.Columns.Item("LUGAR_DESTINO").ColumnName = "Destino"
            'tabTraking.Columns.Item("FECHA_SALIDA_REAL").ColumnName = "Fecha Real Salida"
            'tabTraking.Columns.Item("FECHA_ESTIMADA_LLEGADA").ColumnName = "Fecha Estimada Llegada"
            'tabTraking.Columns.Item("FECHA_LLEGADA_REAL").ColumnName = "Fecha Real Llegada"
            'tabTraking.Columns.Item("TRANSPORTISTA").ColumnName = "Transportista"
            'tabTraking.Columns.Item("PLACA_TRACTO").ColumnName = "Placa"
            'tabTraking.Columns.Item("TIPO_UNIDAD").ColumnName = "Tipo Unidad"
            'tabTraking.Columns.Item("MODELO_TRACTO").ColumnName = "Nombre Unidad"
            'tabTraking.Columns.Item("ESTADO_TRANSITO").ColumnName = "Estado entrega"
            'tabTraking.Columns.Item("FECHA_CONF_LLEGADA").ColumnName = "Fecha confirmación bulto"

            HelpClass.ExportExcel(objListdt, "Listado movimientos almacén")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub
End Class
