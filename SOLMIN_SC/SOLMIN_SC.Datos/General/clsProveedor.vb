Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsProveedor
    Public Function Lista_Proveedor() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PROVEEDORES", Nothing)
        Return dt
    End Function

    Public Function Lista_Proveedor_X_Cliente(ByVal pdblCodCli As Double, ByVal pstrEstado As String, ByVal pstrNomProv As String)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCodCli)
        lobjParams.Add("PSTPRVCL", pstrNomProv)
        lobjParams.Add("PSSESTRG", pstrEstado)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PROVEEDORES", lobjParams)
        Return dt
    End Function

    Public Function Cargar_Datos_Proveedor(ByVal pdblCodClie As Double, ByVal pdblCodProv As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCodClie)
        lobjParams.Add("PSCPRVCL", pdblCodProv)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DATOS_PROVEEDOR", lobjParams)
        Return dt
    End Function

    Public Sub Crear_Proveedor(ByVal pstrNomProv As String, ByVal pstrDesc As String, ByVal pdblRUC As String, ByVal pstrTelefono As String, ByVal pstrFax As String, _
                               ByVal pstrEmail As String, ByVal pstrDireccion As String, ByVal pdblPais As Double, ByVal pstrDatContContrato As String, _
                               ByVal pstrDatTelContrato As String, ByVal pstrDatCorreoContrato As String, ByVal pdblCodCliente As Double, ByVal pstrCodClienteProveedor As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTPRVCL", pstrNomProv)
        lobjParams.Add("PSTPRCL1", pstrDesc)
        lobjParams.Add("PSNRUCPR", pdblRUC)
        lobjParams.Add("PSTLFNO1", pstrTelefono)
        lobjParams.Add("PSTNROFX", pstrFax)
        lobjParams.Add("PSTEMAI2", pstrEmail)
        lobjParams.Add("PSTDRPRC", pstrDireccion)
        lobjParams.Add("PNCPAIS", pdblPais)
        lobjParams.Add("PSTPRSCN", pstrDatContContrato)
        lobjParams.Add("PSTLFNO2", pstrDatTelContrato)
        lobjParams.Add("PSTEMAI3", pstrDatCorreoContrato)
        lobjParams.Add("PNCCLNT", pdblCodCliente)
        lobjParams.Add("PSCPRPCL", pstrCodClienteProveedor)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))

        lobjSql.ExecuteNonQuery("SP_SOLSC_CREAR_PROVEEDOR", lobjParams)

    End Sub

    Public Sub Actualizar_Proveedor(ByVal pdblCodigo As Double, ByVal pstrNomProv As String, ByVal pstrDesc As String, ByVal pdblRUC As Double, ByVal pstrTelefono As String, ByVal pstrFax As String, _
                                    ByVal pstrEmail As String, ByVal pstrDireccion As String, ByVal pdblPais As Double, ByVal pstrDatContContrato As String, ByVal pstrDatTelContrato As String, _
                                    ByVal pstrDatCorreoContrato As String, ByVal pdblCodCliente As Double, ByVal pstrCodClienteProveedor As String, ByVal pstrEstado As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCPRVCL", pdblCodigo)
        lobjParams.Add("PSTPRVCL", pstrNomProv)
        lobjParams.Add("PSTPRCL1", pstrDesc)
        lobjParams.Add("PSNRUCPR", pdblRUC)
        lobjParams.Add("PSTLFNO1", pstrTelefono)
        lobjParams.Add("PSTNROFX", pstrFax)
        lobjParams.Add("PSTEMAI2", pstrEmail)
        lobjParams.Add("PSTDRPRC", pstrDireccion)
        lobjParams.Add("PNCPAIS", pdblPais)
        lobjParams.Add("PSTPRSCN", pstrDatContContrato)
        lobjParams.Add("PSTLFNO2", pstrDatTelContrato)
        lobjParams.Add("PSTEMAI3", pstrDatCorreoContrato)
        lobjParams.Add("PNCCLNT", pdblCodCliente)
        lobjParams.Add("PSCPRPCL", pstrCodClienteProveedor)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHULTAC", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEstado)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_PROVEEDOR", lobjParams)

    End Sub

    Public Function Codigo_Proveedor_Cliente(ByVal dblCodCliente As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", dblCodCliente)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_CODIGO_PROVEEDOR_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Relacion_Proveedor_X_Cliente(ByVal PNCCLNT As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_RELACION_PROVEEDORES_X_CLIENTE", lobjParams)
        Return dt
    End Function

End Class
