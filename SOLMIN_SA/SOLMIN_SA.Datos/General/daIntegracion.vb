Imports System.Data
Imports System.Data.SqlClient
Imports RANSA.TYPEDEF

Public Class daIntegracion

    Public Function Integracion_Lista_Orden_Compra_Cabecera(ByVal NORCML As Int64) As beOrdenCompra
        Dim oDs As New DataSet
        Dim obeOrdenCompra As New beOrdenCompra()
        Dim ocnx As New SqlConnection()
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            ocnx.Open()
            Dim query As String = "SELECT * FROM WHI_SOLING_CAB WHERE  vc_PurchaseOrder=" & NORCML
            Dim oda As New SqlDataAdapter(query, ocnx)
            Dim Fecha As Date
            oda.Fill(oDs, "CAB_OC")
            ocnx.Close()
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
                    obeOrdenCompra.pNRUCPR_RucProveedor = IIf(oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalCode") Is DBNull.Value, "", oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalCode"))
                    obeOrdenCompra.pTPRVCL_DescripcionProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFiscalName")).ToString.Trim
                    obeOrdenCompra.pTNROFX_FaxProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierFax")).ToString.Trim
                    obeOrdenCompra.pTPRSCN_ContactoProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReference")).ToString.Trim
                    obeOrdenCompra.pTLFN02_TelefonoContacto = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReferenceTelephone")).ToString.Trim
                    obeOrdenCompra.pTEAMI3_EmailContacto = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierReferenceEmail")).ToString.Trim
                    obeOrdenCompra.pTPDRPRC_DireccionProveedor = ("" & oDs.Tables(0).Rows.Item(0).Item("vc_SupplierAddressLine1")).ToString.Trim
                End With

            End If
        Catch ex As Exception
            obeOrdenCompra = Nothing
        Finally
            ocnx.Close()
        End Try

        Return obeOrdenCompra

    End Function

    Public Function Integracion_Lista_Orden_Compra_Detalle(ByVal NORCML As Int64) As DataSet
        Dim oDs As New DataSet
        Dim ocnx As New SqlConnection
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Dim query As String = "SELECT * FROM WHI_SOLING_DET WHERE vc_PurchaseOrder =" & NORCML
            ocnx.Open()
            Dim oda As New SqlDataAdapter(query, ocnx)
            oda.Fill(oDs, "DET_OC")
        Catch ex As Exception
            oDs = Nothing
        Finally
            ocnx.Close()
        End Try
        Return oDs
    End Function

    Public Function Integracion_Insertar_Recepcion_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim ocnx As New SqlConnection
        Dim n As Integer = -1
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Using cmd As New SqlCommand("SP_INSERTAR_RECEPCION_CABECERA", ocnx)
                cmd.CommandTimeout = daCnx.GetConnectionTime()
                ocnx.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@in_DeliveryGuideNumber", SqlDbType.Int).Value = objParametros.Item("in_DeliveryGuideNumber").Value
                cmd.Parameters.Add("@vc_PurchaseOrder", SqlDbType.VarChar).Value = objParametros.Item("vc_PurchaseOrder").Value
                cmd.Parameters.Add("@dt_DeliveryGuideDate", SqlDbType.DateTime).Value = objParametros.Item("dt_DeliveryGuideDate").Value
                cmd.Parameters.Add("@vc_VehiclePlate", SqlDbType.VarChar).Value = objParametros.Item("vc_VehiclePlate").Value
                cmd.Parameters.Add("@vc_TransportCarrierName", SqlDbType.VarChar).Value = objParametros.Item("vc_TransportCarrierName").Value
                cmd.Parameters.Add("@vc_TransportCarrierFiscalCode", SqlDbType.VarChar).Value = objParametros.Item("vc_TransportCarrierFiscalCode").Value
                cmd.Parameters.Add("@vc_Driver", SqlDbType.VarChar).Value = objParametros.Item("vc_Driver").Value
                cmd.Parameters.Add("@vc_DriversLicense", SqlDbType.VarChar).Value = objParametros.Item("vc_DriversLicense").Value
                cmd.Parameters.Add("@vc_DeliveryGuideComments", SqlDbType.VarChar).Value = objParametros.Item("vc_DeliveryGuideComments").Value
                n = cmd.ExecuteNonQuery
                If n <= 0 Then Throw New Exception("No se pudo realizar la operacion")
                ocnx.Close()
            End Using
        Catch ex As Exception
        End Try
        Return n
    End Function

    Public Function Integracion_Insertar_Recepcion_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim ocnx As New SqlConnection
        Dim n As Integer = -1
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Using cmd As New SqlCommand("SP_INSERTAR_RECEPCION_DETALLE", ocnx)
                cmd.CommandTimeout = daCnx.GetConnectionTime()
                ocnx.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@in_DeliveryGuideLine", SqlDbType.Int).Value = objParametros.Item("in_DeliveryGuideLine").Value
                cmd.Parameters.Add("@in_DeliveryGuideNumber", SqlDbType.Int).Value = objParametros.Item("in_DeliveryGuideNumber").Value
                cmd.Parameters.Add("@vc_PurchaseOrder", SqlDbType.VarChar).Value = objParametros.Item("vc_PurchaseOrder").Value
                cmd.Parameters.Add("@vc_PurchaseorderLine", SqlDbType.VarChar).Value = objParametros.Item("vc_PurchaseorderLine").Value
                cmd.Parameters.Add("@vc_SupplierCode", SqlDbType.VarChar).Value = objParametros.Item("vc_SupplierCode").Value
                cmd.Parameters.Add("@vc_SupplierFiscalCode", SqlDbType.VarChar).Value = objParametros.Item("vc_SupplierFiscalCode").Value
                cmd.Parameters.Add("@vc_SupplierFiscalName", SqlDbType.VarChar).Value = objParametros.Item("vc_SupplierFiscalName").Value
                cmd.Parameters.Add("@vc_StockCode", SqlDbType.VarChar).Value = objParametros.Item("vc_StockCode").Value
                cmd.Parameters.Add("@vc_LineDescriptionLine1", SqlDbType.VarChar).Value = objParametros.Item("vc_LineDescriptionLine1").Value
                cmd.Parameters.Add("@vc_LineDescriptionLine2", SqlDbType.VarChar).Value = objParametros.Item("vc_LineDescriptionLine2").Value
                cmd.Parameters.Add("@vc_UnitMeasureCode", SqlDbType.Int).Value = objParametros.Item("vc_UnitMeasureCode").Value
                cmd.Parameters.Add("@fl_QuantityReceived", SqlDbType.Float).Value = objParametros.Item("fl_QuantityReceived").Value
                cmd.Parameters.Add("@vc_MDFCode", SqlDbType.VarChar).Value = objParametros.Item("vc_MDFCode").Value
                cmd.Parameters.Add("@in_SupplierDeliveryGuideNumber", SqlDbType.Int).Value = objParametros.Item("in_SupplierDeliveryGuideNumber").Value
                n = cmd.ExecuteNonQuery
                If n <= 0 Then Throw New Exception("No se pudo realizar la operacion")
                ocnx.Close()
            End Using
        Catch ex As Exception
        Finally
            ocnx.Close()
        End Try
        Return n
    End Function

    Public Function Integracion_Insertar_Despacho_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim ocnx As New SqlConnection
        Dim n As Integer = -1
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Using cmd As New SqlCommand("SP_INSERTAR_DESPACHO_CABECERA", ocnx)
                cmd.CommandTimeout = daCnx.GetConnectionTime()
                ocnx.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@in_ReferralGuideNumber", SqlDbType.Int).Value = objParametros.Item("in_ReferralGuideNumber").Value
                cmd.Parameters.Add("@vc_OrderType", SqlDbType.VarChar).Value = objParametros.Item("vc_OrderType").Value
                cmd.Parameters.Add("@vc_OrderNumber", SqlDbType.VarChar).Value = objParametros.Item("vc_OrderNumber").Value.ToString
                cmd.Parameters.Add("@dt_ReferralGuideDate", SqlDbType.DateTime).Value = objParametros.Item("dt_ReferralGuideDate").Value
                cmd.Parameters.Add("@vc_TransferReason", SqlDbType.VarChar).Value = objParametros.Item("vc_TransferReason").Value
                cmd.Parameters.Add("@vc_HomeName", SqlDbType.VarChar).Value = objParametros.Item("vc_HomeName").Value
                cmd.Parameters.Add("@vc_HomeAddress", SqlDbType.VarChar).Value = objParametros.Item("vc_HomeAddress").Value
                cmd.Parameters.Add("@vc_CustomerCodeDeliver", SqlDbType.VarChar).Value = objParametros.Item("vc_CustomerCodeDeliver").Value
                cmd.Parameters.Add("@vc_CustomerFiscalCodeDeliver", SqlDbType.VarChar).Value = objParametros.Item("vc_CustomerFiscalCodeDeliver").Value
                cmd.Parameters.Add("@vc_CustomerAddressDeliverLine1", SqlDbType.VarChar).Value = objParametros.Item("vc_CustomerAddressDeliverLine1").Value
                cmd.Parameters.Add("@vc_CustomerAddressDeliverLine2", SqlDbType.VarChar).Value = objParametros.Item("vc_CustomerAddressDeliverLine2").Value
                cmd.Parameters.Add("@vc_CustomerAddressLine3", SqlDbType.VarChar).Value = objParametros.Item("vc_CustomerAddressLine3").Value
                cmd.Parameters.Add("@vc_CustomerFiscalName", SqlDbType.VarChar).Value = "" & objParametros.Item("vc_CustomerFiscalName").Value & ""
                cmd.Parameters.Add("@vc_VehiclePlate", SqlDbType.VarChar).Value = objParametros.Item("vc_VehiclePlate").Value
                cmd.Parameters.Add("@vc_TransportCarrierName", SqlDbType.VarChar).Value = objParametros.Item("vc_TransportCarrierName").Value
                cmd.Parameters.Add("@vc_TransportCarrierFiscalCode", SqlDbType.VarChar).Value = "" & objParametros.Item("vc_TransportCarrierFiscalCode").Value & ""
                cmd.Parameters.Add("@vc_TransportCarrierAddress", SqlDbType.VarChar).Value = objParametros.Item("vc_TransportCarrierAddress").Value
                cmd.Parameters.Add("@vc_Driver", SqlDbType.VarChar).Value = objParametros.Item("vc_Driver").Value
                cmd.Parameters.Add("@vc_DriversLicense", SqlDbType.VarChar).Value = objParametros.Item("vc_DriversLicense").Value
                cmd.Parameters.Add("@vc_ReferralGuideComments", SqlDbType.VarChar).Value = objParametros.Item("vc_ReferralGuideComments").Value
                n = cmd.ExecuteNonQuery
                If n <= 0 Then Throw New Exception("No se pudo realizar la operacion")
            End Using
        Catch ex As Exception
        End Try
        Return n
    End Function

    Public Function Integracion_Insertar_Despacho_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As Int32
        Dim ocnx As New SqlConnection
        Dim n As Integer = -1
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Using cmd As New SqlCommand("SP_INSERTAR_DESPACHO_DETALLE", ocnx)
                cmd.CommandTimeout = daCnx.GetConnectionTime()
                ocnx.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@in_ReferralGuideLine", SqlDbType.VarChar).Value = objParametros.Item("in_ReferralGuideLine").Value
                cmd.Parameters.Add("@in_ReferralGuideNumber", SqlDbType.Int).Value = Convert.ToInt32(objParametros.Item("in_ReferralGuideNumber").Value)
                cmd.Parameters.Add("@vc_OrderNumber", SqlDbType.VarChar).Value = objParametros.Item("vc_OrderNumber").Value
                cmd.Parameters.Add("@vc_OrderType", SqlDbType.VarChar).Value = objParametros.Item("vc_OrderType").Value
                cmd.Parameters.Add("@vc_OrderNUmberLine", SqlDbType.VarChar).Value = objParametros.Item("vc_OrderNUmberLine").Value
                cmd.Parameters.Add("@vc_StockCode", SqlDbType.VarChar).Value = objParametros.Item("vc_StockCode").Value
                cmd.Parameters.Add("@vc_LineDescriptionLine1", SqlDbType.VarChar).Value = objParametros.Item("vc_LineDescriptionLine1").Value
                cmd.Parameters.Add("@vc_LineDescriptionLine2", SqlDbType.VarChar).Value = objParametros.Item("vc_LineDescriptionLine2").Value
                cmd.Parameters.Add("@vc_UnitMeasure", SqlDbType.Int).Value = Convert.ToInt32(objParametros.Item("vc_UnitMeasure").Value)
                cmd.Parameters.Add("@fl_Quantity", SqlDbType.Float).Value = Convert.ToInt64(objParametros.Item("fl_Quantity").Value)
                n = cmd.ExecuteNonQuery
                If n <= 0 Then Throw New Exception("No se pudo realizar la operacion")
            End Using
        Catch ex As Exception
        End Try
        Return n
    End Function

    Public Function Integracion_Obtener_Pedido_Cabecera(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As DataTable
        Dim ocnx As New SqlConnection
        Dim oDs As New DataSet()
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Dim cmd As New SqlCommand("SP_OBTENER_PEDIDO_CABECERA", ocnx)
            cmd.CommandTimeout = daCnx.GetConnectionTime()
            ocnx.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vc_OrderNumber", SqlDbType.VarChar).Value = objParametros.Item("in_vc_OrderNumber").Value
            cmd.Parameters.Add("@vc_OrderType", SqlDbType.VarChar).Value = objParametros.Item("in_vc_OrderType").Value
            Dim oda As New SqlDataAdapter(cmd)
            oda.Fill(oDs, "PEDIDO_CABECERA")
        Catch ex As Exception
            oDs = Nothing
        Finally
            ocnx.Close()
        End Try
        Return oDs.Tables(0)
    End Function

    Public Function Integracion_Obtener_Pedido_Detalle(ByVal objParametros As Db2Manager.RansaData.iSeries.DataObjects.Parameter) As DataTable
        Dim ocnx As New SqlConnection
        Dim oDs As New DataSet()
        Try
            ocnx = New SqlConnection(daCnx.GetConnectionStringABB())
            Dim cmd As New SqlCommand("[SP_OBTENER_PEDIDO_DETALLE]", ocnx)
            cmd.CommandTimeout = daCnx.GetConnectionTime()
            ocnx.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vc_OrderNumber", SqlDbType.VarChar).Value = objParametros.Item("in_vc_OrderNumber").Value
            cmd.Parameters.Add("@vc_OrderType", SqlDbType.VarChar).Value = objParametros.Item("in_vc_OrderType").Value
            Dim oda As New SqlDataAdapter(cmd)
            oda.Fill(oDs, "PEDIDO_DETALLE")
        Catch ex As Exception
            oDs = Nothing
        Finally
            ocnx.Close()
        End Try
        Return oDs.Tables(0)
    End Function

End Class


