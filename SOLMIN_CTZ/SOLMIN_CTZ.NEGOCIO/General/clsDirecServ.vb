Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsDirecServ

    Dim direcserv As New SOLMIN_CTZ.DATOS.clsDirecServ

    Public Function Lista_Direccion_Servicio(ByVal codigo As Decimal, ByVal direccion As String, ByVal PNCCLNT As Decimal, ByVal CPLNDV As Decimal) As DataTable

        Dim output As DataTable = direcserv.Lista_Direccion_Servicio(codigo, direccion, PNCCLNT, CPLNDV)
        Return output
    End Function

    Public Function Buscar_Direccion_Servicio(ByVal codigo As Decimal, _
                                          ByVal direccion As String, _
                                          ByVal ubigeo As Decimal, _
                                          ByVal referencia As String) As DataTable

        Dim output As DataTable = direcserv.Buscar_Direccion_Servicio(codigo, _
                                                                      direccion, _
                                                                      ubigeo, _
                                                                      referencia)
        Return output
    End Function

    Public Function Insertar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As String

        Dim output As DataTable = direcserv.Insertar_Direccion_Servicio(_beDireccion)
        Dim mensaje As String = String.Empty

        For Each row As DataRow In output.Rows
            mensaje = mensaje & row.Item("OBSRESULT") & vbNewLine
        Next

        Return mensaje

    End Function

    Public Function Modificar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As String

        Dim estado As Integer = direcserv.Modificar_Direccion_Servicio(_beDireccion)
        Dim mensaje As String = String.Empty

        If estado = 1 Then
            mensaje = "Se actualizó el registro correctamente"
        End If

        Return mensaje
    End Function

    Public Function Eliminar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As String

        Dim estado As Integer = direcserv.Eliminar_Direccion_Servicio(_beDireccion)
        Dim mensaje As String = String.Empty

        If estado = 1 Then
            mensaje = "Se eliminó el registro correctamente"
        End If

        Return mensaje
    End Function


    Public Function Lista_ClienteXDireccion(ByVal PNCDIRSE As Decimal) As DataTable

        Return direcserv.Lista_ClienteXDireccion(PNCDIRSE)
    End Function


    Public Function Lista_TipoCODVAR(ByVal PSCODVAR As String) As DataTable

        Return direcserv.Lista_TipoCODVAR(PSCODVAR)
    End Function


    Public Function Lista_ZonaFacturacion() As List(Of beZonaFacturacion)
        Return direcserv.Lista_ZonaFacturacion()
    End Function




    Public Function RegistrarAsignacionClienteDirServicio(ByVal _beDireccion As beClienteDireccion) As String
        Dim retorno As Integer = direcserv.RegistrarAsignacionClienteDirServicio(_beDireccion)
        Dim mensaje As String = String.Empty

        If retorno = 1 Then
            mensaje = "Se guardó el registro correctamente"
        End If
        Return mensaje
    End Function


    Public Function EliminarAsignacionClienteDirServicio(ByVal _beDireccion As beClienteDireccion) As String
        Dim retorno As Integer = direcserv.EliminarAsignacionClienteDirServicio(_beDireccion)
        Dim mensaje As String = String.Empty
        If retorno = 1 Then
            mensaje = "Se eliminó el registro correctamente"
        End If
        Return mensaje
    End Function


    Public Function ValidarRegistroDirCliente(ByVal PNCCLNT As Decimal, ByVal PNCDIRSE As Decimal, ByVal PNCPLNDV As Decimal) As String
        Dim retorno As String = direcserv.ValidarRegistroDirCliente(PNCCLNT, PNCDIRSE, PNCPLNDV)
        Return retorno
    End Function

    Public Function BuscarDireccion_ServicioxDescripcion(ByVal PNCDIRSE As String) As DataTable
        Dim output As DataTable = direcserv.BuscarDireccion_ServicioxDescripcion(PNCDIRSE)
        Return output
    End Function

End Class
