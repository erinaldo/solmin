Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class Urea_DAL

    Public Function Registrar_Urea(ByVal objEntidad As Urea) As String
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objSql As New SqlManager

        objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
        objParam.Add("PNNRITEM", objEntidad.NRITEM)
        objParam.Add("PSNRODCM", objEntidad.NRODCM)
        objParam.Add("PNFCGURA", objEntidad.FCGURA)
        objParam.Add("PNQLTSCM", objEntidad.QLTSCM)
        objParam.Add("PNCMNDA1", objEntidad.CMNDA1)
        objParam.Add("PNCSTGLN", objEntidad.CSTGLN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_UREA", objParam)
        
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim
        Return msg
    End Function


    Public Function Listar_Item_Urea(ByVal objEntidad As Urea) As DataTable
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
        objParam.Add("PNNRITEM", objEntidad.NRITEM)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ITEM_UREA", objParam)
        Return dt
    End Function

    Public Function Listar_Urea_Asignado_x_Liquidacion(ByVal objEntidad As Urea) As DataTable
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UREA_ASIGNADA_X_LIQUIDACION", objParam)
        For Each item As DataRow In dt.Rows
            item("FCGURA") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCGURA"))
        Next

        Return dt
    End Function


    Public Function Eliminar_Urea_Liquidacion_Asignado(ByVal objEntidad As Urea) As String
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objEntidad.CCMPN)     'COMPAÑIA
        objParam.Add("PNNLQCMB", objEntidad.NLQCMB)   'NUMERO DE LIQUIDACION
        objParam.Add("PNNRITEM", objEntidad.NRITEM)     'DIVISIÓN
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ELIMINAR_UREA_ASIGNADO", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim
        Return msg
    End Function

 
End Class
