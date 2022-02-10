Public Class clsCliente

    Public Function Obtener_datos_cliente(ByVal PNCCLNT As Decimal) As DataTable
        Dim oCliente As New Datos.clsCliente
        Return oCliente.Obtener_datos_cliente(PNCCLNT)
    End Function

    Public Function fdsCodigoClienteDelPortar(ByVal CCLNT As Decimal) As Decimal
        Dim oCliente As New Datos.clsCliente
        Return oCliente.fdsCodigoClienteDelPortar(CCLNT)
    End Function
End Class
