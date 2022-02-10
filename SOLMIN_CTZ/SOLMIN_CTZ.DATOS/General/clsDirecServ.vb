Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsDirecServ

    Public Function Lista_Direccion_Servicio(ByVal codigo As Decimal, ByVal direccion As String, ByVal PNCCLNT As Decimal, ByVal CPLNDV As Decimal) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", codigo)
        parameter.Add("PSDEDISE", direccion)
        parameter.Add("PNCCLNT", PNCCLNT)
        parameter.Add("CPLNDV", CPLNDV)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_DIRECCION_SERVICIO", parameter)

        Return output
    End Function







    Public Function Buscar_Direccion_Servicio(ByVal codigo As Decimal, _
                                          ByVal direccion As String, _
                                          ByVal ubigeo As Decimal, _
                                          ByVal referencia As String) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", codigo)
        parameter.Add("PSDEDISE", direccion)
        parameter.Add("PSDREFSE", referencia)
        parameter.Add("PNUBIGEO", ubigeo)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_BUSCA_DIRECCION_SERVICIO", parameter)

        Return output

    End Function

    Public Function Insertar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSDEDISE", _beDireccion.Direccion)
        parameter.Add("PSDREFSE", _beDireccion.Referencia)
        parameter.Add("PNCUBGEO", _beDireccion.Ubigeo)
        parameter.Add("PSNTRMNL", _beDireccion.MachineName)
        parameter.Add("PSCULUSA", _beDireccion.Usuario_creador)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_DIRECCION_SERVICIO", parameter)
        Return output
    End Function

    Public Function Modificar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As Integer


        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", _beDireccion.Codigo)
        parameter.Add("PSDEDISE", _beDireccion.Direccion)
        parameter.Add("PSDREFSE", _beDireccion.Referencia)
        parameter.Add("PNCUBGEO", _beDireccion.Ubigeo)
        parameter.Add("PSNTRMNL", _beDireccion.MachineName)
        parameter.Add("PSCULUSA", _beDireccion.Usuario_act)

        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_MODIFICAR_DIRECCION_SERVICIO", parameter)

        Return 1
    End Function

    Public Function Eliminar_Direccion_Servicio(ByVal _beDireccion As beDirecServ) As Integer


        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", _beDireccion.Codigo)
        parameter.Add("PSNTRMNL", _beDireccion.MachineName)
        parameter.Add("PSCULUSA", _beDireccion.Usuario_act)

        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_ANULAR_DIRECCION_SERVICIO", parameter)

        Return 1
    End Function


    Public Function Lista_ClienteXDireccion(ByVal PNCDIRSE As Decimal) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PNCDIRSE", PNCDIRSE)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CLIENTE_X_DIRECCION", parameter)

        Return output
    End Function


    Public Function Lista_TipoCODVAR(ByVal PSCODVAR As String) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PSCODVAR", PSCODVAR)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_CODVAR_GENERAL", parameter)

        Return output
    End Function


    Public Function Lista_ZonaFacturacion() As List(Of beZonaFacturacion)
        Dim output As New List(Of beZonaFacturacion)
        Dim dt As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        dt = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_ZONA_FACTURACION_TODOS", parameter)
        Dim entidad As beZonaFacturacion
        For Each dr As DataRow In dt.Rows
            entidad = New beZonaFacturacion
            entidad.CZNFCC = dr("CZNFCC")
            entidad.TZNFCC = dr("TZNFCC")
            output.Add(entidad)
        Next
        Return output
    End Function




    Public Function RegistrarAsignacionClienteDirServicio(ByVal _beDireccion As beClienteDireccion) As Integer
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PSTIPO", _beDireccion.PSTIPO)
        parameter.Add("PNCCLNT", _beDireccion.PNCCLNT)
        parameter.Add("PNCDIRSE", _beDireccion.PNCDIRSE)
        parameter.Add("PNCPLNDV", _beDireccion.PNCPLNDV)
        parameter.Add("PNCZNFCC", _beDireccion.PNCZNFCC)
        parameter.Add("PSCULUSA", ConfigurationWizard.UserName)
        parameter.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_REGISTRAR_ASIGNACION_CLIENTE_DIR_SERVICIO", parameter)
        Return 1
    End Function


    Public Function EliminarAsignacionClienteDirServicio(ByVal _beDireccion As beClienteDireccion) As Integer
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PNCDIRSE", _beDireccion.PNCDIRSE)
        parameter.Add("PNITEM", _beDireccion.PNITEM)
        parameter.Add("PNCCLNT", _beDireccion.PNCCLNT)
        parameter.Add("PSCULUSA", ConfigurationWizard.UserName)
        parameter.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_ELIMINAR_ASIGNACION_CLIENTE_DIR_SERVICIO", parameter)
        Return 1
    End Function

    Public Function ValidarRegistroDirCliente(ByVal PNCCLNT As Decimal, ByVal PNCDIRSE As Decimal, ByVal PNCPLNDV As Decimal) As String

        Dim output As DataTable
        Dim strMensaje As String = String.Empty
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PNCCLNT", PNCCLNT)
        parameter.Add("PNCDIRSE", PNCDIRSE)
        parameter.Add("PNCPLNDV", PNCPLNDV)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_REGISTRO_DIRECCION_CLIENTE", parameter)

        For Each item As DataRow In output.Rows
            If item("STATUS") = "N" Then
                strMensaje += item("OBSRESULT") & Chr(13)
            End If
        Next


        Return strMensaje.Trim
    End Function


    Public Function BuscarDireccion_ServicioxDescripcion(ByVal PNCDIRSE As String) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PSDEDISE", PNCDIRSE)
        output = sqlManager.ExecuteDataTable("SP_SOLMIN_SC_BUSCAR_DIRECCION_SERVICIO_X_DESCRIPCION", parameter)

        Return output
    End Function





End Class
