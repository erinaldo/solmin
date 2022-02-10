Imports RANSA.TypeDef
Imports RANSA.DATA

Public Class brPlantaClienteProveedor
    Inherits brBase(Of bePlantaClienteProveedor, daPlantaClienteProveedor)
    Public Function EliminarPlantaClienteTercero(ByVal obj As TYPEDEF.bePlantaClienteProveedor) As Integer
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.EliminarPlantaClienteTercero(obj)
    End Function

    Public Function fintInsertarPlantaClienteTercero(ByVal obj As TYPEDEF.bePlantaClienteProveedor) As Integer
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.fintInsertarPlantaClienteTercero(obj)
    End Function


    Public Function CargarUbigeo() As List(Of bePlantaClienteProveedor)
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.CargarUbigeo()
    End Function

    Public Function Listado_Planta_x_Cliente_Tercero_RZOL05A(pCodCliente As Decimal, RUC As String, RAZON_SOCIAL As String, CodProvCliente As String, pNROPAG As Decimal, pPAGESIZE As Decimal, ByRef pCANT_PAG As Decimal) As DataTable
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.Listado_Planta_x_Cliente_Tercero_RZOL05A(pCodCliente, RUC, RAZON_SOCIAL, CodProvCliente, pNROPAG, pPAGESIZE, pCANT_PAG)
    End Function

    Public Function EliminarRelacionTercero_RZOL05A(pCodCliente As Decimal, pCodProvCliente As String) As String
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.EliminarRelacionTercero_RZOL05A(pCodCliente, pCodProvCliente)
    End Function

    Public Function RegistrarRelacionTercero_Cmasivo_RZOL05A(pCodCliente As Decimal, RucProv As String, pCodProvCliente As String) As String
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.RegistrarRelacionTercero_Cmasivo_RZOL05A(pCodCliente, RucProv, pCodProvCliente)
    End Function

    Public Function ValidarRUCProveedor_Cmasivo_RZOL05A(RucProv As String) As String
        Dim odaPlantaClienteProveedor As New daPlantaClienteProveedor
        Return odaPlantaClienteProveedor.ValidarRUCProveedor_Cmasivo_RZOL05A(RucProv)
    End Function

End Class
