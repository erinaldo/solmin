Public Class brGeneral_BL


    Public Function olTipoOrigen(ByVal strTipoMov As String) As List(Of Ransa.TypeDef.beGeneral)
        Dim obeParam As New Ransa.TypeDef.beGeneral
        obeParam.PSCODVAR = "TIPORG"
        Return New brGeneral_DAL().ListaTablaAyuda(obeParam)
    End Function

    Public Function ConsultaCodCliente(CodCliente As Decimal) As DataTable
        Return New brGeneral_DAL().ConsultaCodCliente(CodCliente)
    End Function

    Public Function RegistrarProveedorRelacion(obeProveedor As beProveedor) As String
        Return New brGeneral_DAL().RegistrarProveedorRelacion(obeProveedor)
    End Function
End Class
