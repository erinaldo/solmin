Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsDirDelServicio

    Public Function Lista_Direccion_Servicio(ByVal codigo As Decimal, ByVal direccion As String, ByVal PNCCLNT As Decimal) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", codigo)
        parameter.Add("PSDEDISE", direccion)
        parameter.Add("PNCCLNT", PNCCLNT)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_DIRECCION_SERVICIO", parameter)

        Return output
    End Function


    Public Function Buscar_Direccion_Servicio(ByVal codigo As Decimal, _
                                            ByVal direccion As String, _
                                            ByVal ubigeo As Decimal, _
                                            ByVal referencia As String, _
                                            ByVal PNCCLNTOP As Decimal, _
                                            ByVal PNCCLNTFC As Decimal, _
                                            ByVal PSTIPODIR As String, _
                                            ByVal PSCCMPN As String, _
                                            ByVal PSCDVSN As String, _
                                            ByVal PNCPLNDVOP As Decimal, _
                                            ByVal PNCPLNDVFC As Decimal) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", codigo)
        parameter.Add("PSDEDISE", direccion)
        parameter.Add("PSDREFSE", referencia)
        parameter.Add("PNUBIGEO", ubigeo)
        parameter.Add("PNCCLNTOP", PNCCLNTOP)
        parameter.Add("PNCCLNTFC", PNCCLNTFC)
        parameter.Add("PSTIPODIR", PSTIPODIR)
        parameter.Add("PSCCMPN", PSCCMPN)
        parameter.Add("PSCDVSN", PSCDVSN)
        parameter.Add("PNCPLNDVOP", PNCPLNDVOP)
        parameter.Add("PNCPLNDVFC", PNCPLNDVFC)

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
        parameter.Add("PSNTRMNL", HelpClass.NombreMaquina)
        'NombreMaquina
        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_REGISTRAR_ASIGNACION_CLIENTE_DIR_SERVICIO", parameter)
        Return 1
    End Function


    Public Function EliminarAsignacionClienteDirServicio(ByVal _beDireccion As beClienteDireccion) As Integer
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PNCCLNT", _beDireccion.PNCCLNT)
        parameter.Add("PNCDIRSE", _beDireccion.PNCDIRSE)
        parameter.Add("PSCULUSA", ConfigurationWizard.UserName)
        parameter.Add("PSNTRMNL", HelpClass.NombreMaquina)

        sqlManager.ExecuteNonQuery("SP_SOLMIN_CT_ELIMINAR_ASIGNACION_CLIENTE_DIR_SERVICIO", parameter)
        Return 1
    End Function


    Public Function Lista_CargaInicialDirServicio(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCPLNDVOP As Decimal, ByVal PNCPLNDVFC As Decimal) As DataSet

        Dim output As DataSet

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        parameter.Add("PSCCMPN", PSCCMPN)
        parameter.Add("PSCDVSN", PSCDVSN)
        parameter.Add("PNCPLNDVOP", PNCPLNDVOP)
        parameter.Add("PNCPLNDVFC", PNCPLNDVFC)

        output = sqlManager.ExecuteDataSet("SP_SOLMIN_CT_LISTAR_VALORES_INICIALES_BUSQ_DIR_SERVICIO", parameter)

        Return output
    End Function



End Class
