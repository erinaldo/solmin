Imports RANSA.DAO
Imports RANSA.DATA
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario
Public Class blIntegracion

    Public Function Integracion_Lista_Orden_Compra_Cabecera(ByVal strOrdenDeCompra As String, ByVal strUsuario As String) As beOrdenCompra
        Dim oDs As DataSet
        Dim Fecha As Date
        Dim obeOrdenCompra As New beOrdenCompra
        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        oDs = oIntegracionABB.Integracion_Lista_Orden_Compra_Cabecera(strOrdenDeCompra, strUsuario)

        If oDs.Tables(0).Rows.Count > 0 Then
            With oDs.Tables(0).Rows.Item(0)
                obeOrdenCompra.pNORCML_NroOrdenCompra = ("" & .Item("vc_PurchaseOrder")).ToString.Trim
                obeOrdenCompra.pTDSCML_Descripcion = ("" & .Item("vc_OrderDescripcion")).ToString.Trim
                If (.Item("dt_OrderDate") IsNot DBNull.Value) Then
                    Fecha = Convert.ToDateTime(Convert.ToDateTime(.Item("dt_OrderDate")).Day & "/" & Convert.ToDateTime(.Item("dt_OrderDate")).Month & "/" & Convert.ToDateTime(.Item("dt_OrderDate")).Year)
                    obeOrdenCompra.pEXISTE_FechaOCDte = True
                Else
                    Fecha = Convert.ToDateTime("01/01/01")
                    obeOrdenCompra.pEXISTE_FechaOCDte = False
                End If
                obeOrdenCompra.pFORCML_FechaOCDte = Fecha
                obeOrdenCompra.pTCTCST_CentroCosto = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_CentroCosto")).ToString.Trim
                obeOrdenCompra.pNTPDES_Prioridad = IIf(oDs.Tables(0).Rows.Item(0).Item("vc_UrgencyLevel") Is DBNull.Value Or oDs.Tables(0).Rows.Item(0).Item("vc_UrgencyLevel") = "", 0, oDs.Tables(0).Rows.Item(0).Item("vc_UrgencyLevel"))
                obeOrdenCompra.PCPRPCL_CodigoClienteProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierCode")).ToString.Trim
                obeOrdenCompra.pNRUCPR_RucProveedor = Val(oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalCode"))
                obeOrdenCompra.pTNROFX_FaxProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFax")).ToString.Trim
                obeOrdenCompra.pTLFN02_TelefonoContacto = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReferenceTelephone")).ToString.Trim
                obeOrdenCompra.pTPRSCN_ContactoProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReference")).ToString.Trim
                obeOrdenCompra.pTPRVCL_DescripcionProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalName")).ToString.Trim
                'obeOrdenCompra.pTPRCL1_DescripcionProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_Nombre")).ToString.Trim
                obeOrdenCompra.pTEAMI3_EmailContacto = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReferenceEmail")).ToString.Trim
                obeOrdenCompra.pTPDRPRC_DireccionProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierAddressLine1")).ToString.Trim & ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierAddressLine2")).ToString.Trim & ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierAddressLine3")).ToString.Trim
                obeOrdenCompra.pTDSCML_Descripcion = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalName")).ToString.Trim

                Select Case oDs.Tables(0).Rows.Item(0).Item("bi_Origen")
                    'local
                    Case True : obeOrdenCompra.pTTINTC_TerminoIntern = "FOB"
                        'Importado
                    Case False : obeOrdenCompra.pTTINTC_TerminoIntern = "LOC"
                End Select

            End With
        End If
        Return obeOrdenCompra
    End Function

    Public Function Integracion_Lista_Orden_Compra_Detalle(ByVal strOrdeDeCompra As String, ByVal strUsuario As String) As DataSet
        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        Return oIntegracionABB.Integracion_Lista_Orden_Compra_Detalle(strOrdeDeCompra, strUsuario)
    End Function

    'Public Function Integracion_Insertar_Recepcion_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
    '    Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
    '    Return oIntegracionABB.Integracion_Insertar_Recepcion_Cabecera(objParametros)
    'End Function

    'Public Function Integracion_Insertar_Recepcion_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
    '    Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
    '    Return oIntegracionABB.Integracion_Insertar_Recepcion_Detalle(objParametros)
    'End Function

    Public Function Integracion_Insertar_Despacho_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim objData = New System.Collections.Hashtable
        objData.Add("vc_RansaOutGuide", objParametros.Item("vc_RansaOutGuide").Value.ToString)
        objData.Add("dt_ReferralGuideDate", objParametros.Item("dt_ReferralGuideDate").Value.ToString)
        objData.Add("vc_TransferReason", objParametros.Item("vc_TransferReason").Value.ToString)
        objData.Add("vc_HomeName", objParametros.Item("vc_HomeName").Value.ToString)
        objData.Add("vc_HomeAddress", objParametros.Item("vc_HomeAddress").Value.ToString)
        objData.Add("vc_CustomerCodeDeliver", objParametros.Item("vc_CustomerCodeDeliver").Value.ToString)
        objData.Add("vc_CustomerFiscalCodeDeliver", objParametros.Item("vc_CustomerFiscalCodeDeliver").Value.ToString)
        objData.Add("vc_CustomerAddressDeliverLine1", objParametros.Item("vc_CustomerAddressDeliverLine1").Value.ToString)
        objData.Add("vc_CustomerAddressDeliverLine2", objParametros.Item("vc_CustomerAddressDeliverLine2").Value.ToString)
        objData.Add("vc_CustomerFiscalName", "" & objParametros.Item("vc_CustomerFiscalName").Value.ToString & "")
        objData.Add("vc_VehiclePlate", objParametros.Item("vc_VehiclePlate").Value.ToString)
        objData.Add("vc_TransportCarrierName", objParametros.Item("vc_TransportCarrierName").Value.ToString)
        objData.Add("vc_TransportCarrierFiscalCode", "" & objParametros.Item("vc_TransportCarrierFiscalCode").Value.ToString & "")
        objData.Add("vc_TransportCarrierAddress", objParametros.Item("vc_TransportCarrierAddress").Value.ToString)
        objData.Add("vc_Driver", objParametros.Item("vc_Driver").Value.ToString)
        objData.Add("vc_DriversLicense", objParametros.Item("vc_DriversLicense").Value.ToString)
        objData.Add("vc_ReferralGuideComments", objParametros.Item("vc_ReferralGuideComments").Value.ToString)
        objData.Add("vc_Usuario", objParametros.Item("vc_Usuario").Value.ToString)
        objData.Add("vc_OrderType", objParametros.Item("vc_OrderType").Value.ToString)
        objData.Add("vc_OrderNumber", objParametros.Item("vc_OrderNumber").Value.ToString)

        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        Return oIntegracionABB.Integracion_Insertar_Despacho_Cabecera(HelpClass.HashToXmlString(objData))

        ' Return New daIntegracion().Integracion_Insertar_Despacho_Cabecera(objParametros)
        ' Return oIntegracionABB.Integracion_Insertar_Despacho_Cabecera( _
        ' objParametros.Item("in_ReferralGuideNumber").Value, _
        'objParametros.Item("vc_OrderType").Value, _
        ' objParametros.Item("vc_OrderNumber").Value.ToString, _
        'objParametros.Item("dt_ReferralGuideDate").Value, _
        ' objParametros.Item("vc_TransferReason").Value, _
        'objParametros.Item("vc_HomeName").Value, _
        'objParametros.Item("vc_HomeAddress").Value, _
        'objParametros.Item("vc_CustomerCodeDeliver").Value, _
        'objParametros.Item("vc_CustomerFiscalCodeDeliver").Value, _
        '  objParametros.Item("vc_CustomerAddressDeliverLine1").Value, _
        ' "" & objParametros.Item("vc_CustomerFiscalName").Value & "", _
        'objParametros.Item("vc_VehiclePlate").Value, _
        'objParametros.Item("vc_TransportCarrierName").Value, _
        ' "" & objParametros.Item("vc_TransportCarrierFiscalCode").Value & "", _
        'objParametros.Item("vc_TransportCarrierAddress").Value, _
        'objParametros.Item("vc_Driver").Value, _
        'objParametros.Item("vc_DriversLicense").Value, _
        'objParametros.Item("vc_ReferralGuideComments").Value)
    End Function

    Public Function Integracion_Insertar_Despacho_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        Return oIntegracionABB.Integracion_Insertar_Despacho_Detalle( _
        objParametros.Item("in_ReferralGuideNumber").Value, _
        objParametros.Item("vc_OrderNumber").Value, _
        objParametros.Item("vc_OrderType").Value, _
        objParametros.Item("in_OrderLine").Value, _
        objParametros.Item("vc_StockCode").Value, _
        objParametros.Item("vc_LineDescriptionLine1").Value, _
        objParametros.Item("vc_UnitMeasure").Value, _
        objParametros.Item("fl_Quantity").Value, _
        objParametros.Item("vc_Usuario").Value, _
        objParametros.Item("vc_ReferenceGuide").Value)




    End Function
    Public Function Integracion_Obtener_Pedido_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As DataTable
        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        Return oIntegracionABB.Integracion_Obtener_Pedido_Cabecera(objParametros.Item("in_vc_OrderNumber").Value, objParametros.Item("in_vc_OrderType").Value)
    End Function

    Public Function Integracion_Obtener_Pedido_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As DataTable
        Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
        Return oIntegracionABB.Integracion_Obtener_Pedido_Detalle(objParametros.Item("in_vc_OrderNumber").Value, objParametros.Item("in_vc_OrderType").Value)
    End Function
End Class
