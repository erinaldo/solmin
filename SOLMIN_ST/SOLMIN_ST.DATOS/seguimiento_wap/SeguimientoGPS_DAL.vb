Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Reflection
Public Class SeguimientoGPS_DAL
    Private objSql As New SqlManager
    Public Function Listar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As List(Of SeguimientoGPS)
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Dim objEntidad As SeguimientoGPS
        Try
            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)
            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SEGUIMIENTO_GPS", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New SeguimientoGPS
                objEntidad.NCSOTR = objData("NCSOTR")
                objEntidad.NCRRSR = objData("NCRRSR")
                objEntidad.NPLCTR = objData("NPLCTR")
                objEntidad.FECGPS = objData("FECGPS")
                objEntidad.FECGPS_S = objData("FECGPS_S")
                objEntidad.HORA = objData("HORA")
                objEntidad.HORA_S = objData("HORA_S")
                objEntidad.GPSLAT = objData("GPSLAT")
                objEntidad.GPSLON = objData("GPSLON")
                objEntidad.KMSVEL = objData("KMSVEL")
                objGenericCollection.Add(objEntidad)
            Next
        Catch ex As Exception

        End Try
        Return objGenericCollection
    End Function
    Public Function Lista_GPS_RZTR11A(ByVal obeSeguimientoGPS As SeguimientoGPS) As List(Of SeguimientoGPS)
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Dim objEntidad As SeguimientoGPS
        Try

            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objParam.Add("PNFECGPS", obeSeguimientoGPS.FECGPS)

            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GPS_RZTR11A", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New SeguimientoGPS
                objEntidad.NPLCTR = objData("NPLCTR")
                objEntidad.FECGPS = objData("FECGPS")
                objEntidad.FECGPS_S = objData("FECGPS_S")
                objEntidad.HORA = objData("HORA")
                objEntidad.HORA_S = objData("HORA_S")
                objEntidad.GPSLAT = objData("GPSLAT")
                objEntidad.GPSLON = objData("GPSLON")
                objEntidad.KMSVEL = objData("KMSVEL")
                objGenericCollection.Add(objEntidad)
            Next
        Catch ex As Exception

        End Try
        Return objGenericCollection
    End Function

    Public Function VerificarExistenciaSeguimientoRZTR11S(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Try
            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)
            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objParam.Add("PNFECGPS", obeSeguimientoGPS.FECGPS)
            objParam.Add("PNHORA", obeSeguimientoGPS.HORA)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_SEGUIMIENTO_RZTR11S", objParam)
        Catch ex As Exception

        End Try
        Return oDt.Rows.Count
    End Function

    'SP_SOLMIN_ST_OBTENER_SEGUIMIENTO_RZTR11S


    Public Function Importar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Try
            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)
            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objParam.Add("PNFECGPS", obeSeguimientoGPS.FECGPS)
            objParam.Add("PNHORA", obeSeguimientoGPS.HORA)
            objParam.Add("PSCULUSA", obeSeguimientoGPS.CULUSA)
            objParam.Add("PSNTRMNL", obeSeguimientoGPS.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_IMPORTAR_SEGUIMIENTO_GPS", objParam)
            retorno = 1
        Catch ex As Exception
            Throw New Exception(ex.ToString())
        End Try
        Return retorno
    End Function
    Public Function Insertar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Try

            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)
            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objParam.Add("PNFECGPS", obeSeguimientoGPS.FECGPS)
            objParam.Add("PNHORA", obeSeguimientoGPS.HORA)
            objParam.Add("PSCULUSA", obeSeguimientoGPS.CULUSA)
            objParam.Add("PSNTRMNL", obeSeguimientoGPS.NTRMNL)
            objParam.Add("PSGPSLAT", obeSeguimientoGPS.GPSLAT)
            objParam.Add("PSGPSLON", obeSeguimientoGPS.GPSLON)
            objParam.Add("PNKMSVEL", obeSeguimientoGPS.KMSVEL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_SEGUIMIENTO_GPS", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function

    Public Function Eliminar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Try
            objParam.Add("PNNCSOTR", obeSeguimientoGPS.NCSOTR)
            objParam.Add("PNNCRRSR", obeSeguimientoGPS.NCRRSR)
            objParam.Add("PSNPLCTR", obeSeguimientoGPS.NPLCTR)
            objParam.Add("PNFECGPS", obeSeguimientoGPS.FECGPS)
            objParam.Add("PNHORA", obeSeguimientoGPS.HORA)
            objParam.Add("PSCULUSA", obeSeguimientoGPS.CULUSA)
            objParam.Add("PSNTRMNL", obeSeguimientoGPS.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeSeguimientoGPS.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SEGUIMIENTO_GPS", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function

    Public Function ActualizarRZST20(ByVal Entidad As SeguimientoGPS) As Int32
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Dim objGenericCollection As New List(Of SeguimientoGPS)
        Try
            objParam.Add("PNNCSOTR", Entidad.NCSOTR)
            objParam.Add("PNNCRRSR", Entidad.NCRRSR)
            objParam.Add("PNNCOREG", Entidad.NCOREG)
            objParam.Add("PSCULUSA", Entidad.CULUSA)
            objParam.Add("PSNTRMNL", Entidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Entidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_RZST20", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function


End Class
