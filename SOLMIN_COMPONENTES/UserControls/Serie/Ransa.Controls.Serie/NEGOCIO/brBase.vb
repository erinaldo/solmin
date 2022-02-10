Imports RANSA.TYPEDEF
'Imports RANSA.DATA

Public Class brBase(Of T As beBase(Of T), D As {daBase(Of T), New})
    Protected oData As D

    Public Sub New()
        oData = New D
    End Sub

    Public Function Listar() As List(Of T)
        Return oData.Listar()
    End Function

    Public Function Listar(ByVal ParamArray params As Object()) As List(Of T)
        Return oData.Listar(params)
    End Function

    Public Function ListarReporte(ByVal ParamArray params As Object()) As DataTable
        Return oData.ListarReporte(params)
    End Function

    'Public Function Listar(ByVal pageNumber As Int32, ByVal pageSize As Int32, ByVal ParamArray params As Object())
    '    oData = New D
    '    Return oData.Listar(pageNumber, pageSize, params)
    '    oData = Nothing
    'End Function

    Public Function Insertar(ByVal obj As T) As Boolean
        Return oData.Insertar(obj)
    End Function

    Public Function Update(ByVal obj As T) As Boolean
        Return oData.Update(obj)
    End Function

    Public Function Delete(ByVal obj As T) As Boolean
        Return oData.Delete(obj)
    End Function

    Public Function Delete(ByVal ParamArray parameters As Object())
        Return oData.Delete(parameters)
    End Function

    'Public Function RegistrarProveedorGeneral(ByVal obeProveedor As beProveedor) As beProveedor
    '    Dim odaProveedores As New daProveedor
    '    Return odaProveedores.RegistrarProveedorGeneral(obeProveedor)
    'End Function

    'Public Function ObtenerProveedor(ByVal obeProveedor As beProveedor) As beProveedor
    '    Dim odaProveedores As New daProveedor
    '    Return odaProveedores.ObtenerProveedor(obeProveedor)
    'End Function

    ''' <summary>
    '''Obtiene Código del proveedor 
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function ObtenerCodigoProveedorPorCodCliente(ByVal obeProveedor As beProveedor) As Decimal
    '    Dim odaProveedores As New daProveedor
    '    Return odaProveedores.ObtenerCodigoProveedorPorCodCliente(obeProveedor)
    'End Function

    'Public Function Listar_proveedor_X_RUC(PSNRUCPR As String) As DataTable
    '    Dim odaProveedores As New daProveedor
    '    Return odaProveedores.Listar_proveedor_X_RUC(PSNRUCPR)
    'End Function


End Class
