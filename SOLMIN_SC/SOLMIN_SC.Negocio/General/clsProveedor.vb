Public Class clsProveedor
    Private oProveedor As Datos.clsProveedor
    Private oDt As DataTable

    Sub New()
        oProveedor = New Datos.clsProveedor
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Buscar_Proovedor(ByVal pstrCodCliente As String, ByVal pstrCodProv As String) As String
        Return oDt.Select("CCLNT=" & pstrCodCliente & "AND CPRVCL=" & pstrCodProv)(0).Item(1).ToString.Trim
    End Function

    Public Function Buscar_Codigo_Proovedor(ByVal pstrCodCliente As String, ByVal pstrNomProv As String) As String
        Return oDt.Select("CCLNT=" & pstrCodCliente & "AND TPRVCL='" & Trim(pstrNomProv) & "'")(0).Item(0).ToString.Trim
    End Function

    Public Function Lista_Proveedor_X_Cliente(ByVal pdblCodCli As Double, ByVal pstrEstado As String, ByVal pstrNomProv As String) As DataTable
        Return oProveedor.Lista_Proveedor_X_Cliente(pdblCodCli, pstrEstado, pstrNomProv)
    End Function

    Public Function Cargar_Datos_Proveedor(ByVal pdblCodClie As Double, ByVal pdblCodProv As Double) As DataTable
        Return oProveedor.Cargar_Datos_Proveedor(pdblCodClie, pdblCodProv)
    End Function

    Public Sub Crear_Proveedor(ByVal pstrNomProv As String, ByVal pstrDesc As String, ByVal pdblRUC As String, ByVal pstrTelefono As String, ByVal pstrFax As String, _
                                    ByVal pstrEmail As String, ByVal pstrDireccion As String, ByVal pdblPais As Double, _
                                    ByVal pstrDatContContrato As String, ByVal pstrDatTelContrato As String, ByVal pstrDatCorreoContrato As String, ByVal pdblCodCliente As Double, ByVal pstrCodClienteProveedor As String)
        oProveedor.Crear_Proveedor(pstrNomProv, pstrDesc, pdblRUC, pstrTelefono, pstrFax, pstrEmail, pstrDireccion, pdblPais, pstrDatContContrato, pstrDatTelContrato, pstrDatCorreoContrato, pdblCodCliente, pstrCodClienteProveedor)
       
    End Sub

    Public Sub Actualizar_Proveedor(ByVal pdblCodigo As Double, ByVal pstrNomProv As String, ByVal pstrDesc As String, ByVal pdblRUC As Double, ByVal pstrTelefono As String, ByVal pstrFax As String, _
                                    ByVal pstrEmail As String, ByVal pstrDireccion As String, ByVal pdblPais As Double, _
                                    ByVal pstrDatContContrato As String, ByVal pstrDatTelContrato As String, ByVal pstrDatCorreoContrato As String, ByVal pdblCodCliente As Double, ByVal pstrCodClienteProveedor As String, ByVal pstrEstado As String)
        oProveedor.Actualizar_Proveedor(pdblCodigo, pstrNomProv, pstrDesc, pdblRUC, pstrTelefono, pstrFax, pstrEmail, pstrDireccion, pdblPais, pstrDatContContrato, pstrDatTelContrato, pstrDatCorreoContrato, pdblCodCliente, pstrCodClienteProveedor, pstrEstado)
    End Sub

    Public Function Codigo_Proveedor_Cliente(ByVal dblCodCliente As Double) As DataTable
        Return oProveedor.Codigo_Proveedor_Cliente(dblCodCliente)
    End Function

    Public Function Lista_Relacion_Proveedor_X_Cliente(ByVal PNCCLNT As Decimal) As DataTable
        Dim odtProveedores As New DataTable
        Dim dr As DataRow
        odtProveedores = oProveedor.Lista_Relacion_Proveedor_X_Cliente(PNCCLNT)
        dr = odtProveedores.NewRow
        dr("CPRVCL") = "0"
        dr("TPRVCL") = "TODOS"
        odtProveedores.Rows.InsertAt(dr, 0)
        Return odtProveedores
    End Function
End Class
