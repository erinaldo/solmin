Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class RecursoEquipo_DAL
    Private objSql As New SqlManager


    Public Function Registrar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo

        'Try
        Dim objParam As New Parameter

        objParam.Add("POSNPLRCS", objEntidad.NPLRCS, ParameterDirection.Output)
        'objParam.Add("PINNEJSUN", objEntidad.NEJSUN)
        'objParam.Add("PISNSRCHU", objEntidad.NSRCHU)
        'objParam.Add("PISNSRMTU", objEntidad.NSRMTU)
        objParam.Add("PINFFBRUN", objEntidad.FFBRUN)
        objParam.Add("PISTCLRUN", objEntidad.TCLRUN)
        objParam.Add("PINQPSOTR", objEntidad.QPSOTR)
        objParam.Add("PISTMRCTR", objEntidad.TMRCTR)
        objParam.Add("PISCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PINFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PINHRACRT", objEntidad.HRACRT)
        objParam.Add("PISNTRMCR", objEntidad.NTRMCR)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)

        'ejecuta el procedimiento almacenado
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRA_RECURSO_EQUIPO", objParam)
        objEntidad.NPLRCS = objSql.ParameterCollection("POSNPLRCS")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    objEntidad.NPLRCS = "0"
        'End Try

        Return objEntidad
    End Function

    Public Function Modificar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo
        Try
            Dim objParam As New Parameter

            objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
            'objParam.Add("PNNEJSUN", objEntidad.NEJSUN)
            'objParam.Add("PSNSRCHU", objEntidad.NSRCHU)
            'objParam.Add("PSNSRMTU", objEntidad.NSRMTU)
            objParam.Add("PNFFBRUN", objEntidad.FFBRUN)
            objParam.Add("PSTCLRUN", objEntidad.TCLRUN)
            'objParam.Add("PSTCRRUN", objEntidad.TCRRUN)
            'objParam.Add("PNNCPCRU", objEntidad.NCPCRU)
            'objParam.Add("PNCTIEQP", objEntidad.CTIEQP)
            objParam.Add("PNQPSOTR", objEntidad.QPSOTR)
            objParam.Add("PSTMRCTR", objEntidad.TMRCTR)
            'objParam.Add("PSNRGMT1", objEntidad.NRGMT1)
            'objParam.Add("PSNTERPM", objEntidad.NTERPM)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICA_RECURSO_EQUIPO", objParam)

        Catch ex As Exception
            objEntidad.NPLRCS = "0"
        End Try

        Return objEntidad
    End Function

    Public Function Eliminar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As RecursoEquipo
        Try
            Dim objParam As New Parameter

            objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)


            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_RECURSO_EQUIPO", objParam)

        Catch ex As Exception
            objEntidad.NPLCAC = "0"
        End Try

        Return objEntidad
    End Function

    Public Function Buscar_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of RecursoEquipo)
        Dim objParam As New Parameter

        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        'Obteniendo resultados
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_RECURSO_EQUIPO", objParam)
        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
            Dim objDatos As New RecursoEquipo
            objDatos.NPLRCS = objDataRow("NPLRCS").ToString().Trim()
            objDatos.FFBRUN = objDataRow("FFBRUN").ToString().Trim()
            objDatos.TCLRUN = objDataRow("TCLRUN").ToString().Trim()
            objDatos.QPSOTR = objDataRow("QPSOTR").ToString().Trim()
            objDatos.TMRCTR = objDataRow("TMRCTR").ToString().Trim()
            objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim

            objGenericCollection.Add(objDatos)
        Next

        Return objGenericCollection
    End Function

    Public Function Obtener_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim olbeTracto As New List(Of RecursoEquipo)
        Try

            'Obteniendo resultados
            objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_RECURSO_EQUIPO", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad.NPLRCS = objDataRow("NPLRCS").ToString.Trim
                'objEntidad.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                'objEntidad.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                'objEntidad.NSRMTU = objDataRow("NSRMTU").ToString.Trim
                objEntidad.FFBRUN = objDataRow("FFBRUN").ToString.Trim
                objEntidad.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                'objEntidad.TCRRUN = objDataRow("TCRRUN").ToString.Trim
                'objEntidad.NCPCRU = objDataRow("NCPCRU").ToString.Trim
                'objEntidad.CTIEQP = objDataRow("CTIEQP").ToString.Trim
                objEntidad.QPSOTR = objDataRow("QPSOTR").ToString.Trim
                objEntidad.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                'objEntidad.NRGMT1 = objDataRow("NRGMT1").ToString.Trim
                'objEntidad.NTERPM = objDataRow("NTERPM").ToString.Trim
                objEntidad.SESTRG = objDataRow("SESTRG").ToString.Trim
                objEntidad.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objEntidad.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objEntidad.HRACRT = objDataRow("HRACRT").ToString.Trim
                objEntidad.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objEntidad.CULUSA = objDataRow("CULUSA").ToString.Trim
                objEntidad.FULTAC = objDataRow("FULTAC").ToString.Trim
                objEntidad.HULTAC = objDataRow("HULTAC").ToString.Trim
                'objEntidad.STPVHP = objDataRow("STPVHP").ToString.Trim
                olbeTracto.Add(objEntidad)
            Next
        Catch ex As Exception
        End Try
        Return olbeTracto

    End Function

    Public Function Listar_Tipo_Recurso_Equipo(ByVal objEntidad As RecursoEquipo) As List(Of RecursoEquipo)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of RecursoEquipo)
        Dim objParam As New Parameter

        Try
            'Obteniendo resultados
            ''objParam.Add("PSTDETRA", objEntidad.TDETRA)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_RECURSO_EQUIPO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New RecursoEquipo

                objDatos.CTIEQP = objDataRow("CTITRA").ToString.Trim
                objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
                'objDatos.TABDES = objDataRow("TABDES").ToString.Trim
                'objDatos.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                'objDatos.IMGTRA = objDataRow("IMGTRA").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim

                Dim lstr_URL As String = My.Settings.DAL_URL + "imagenes/solmin/tracto/"
                Dim lstr_URLArchivo As String = lstr_URL & objDataRow("CTITRA").ToString.Trim & ".jpg"
                Dim lstr_URLDefault As String = lstr_URL & "BlankPicture.jpg"

                'Try
                '    objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLArchivo))
                'Catch ex As Exception
                '    objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLDefault))
                'End Try

                objGenericCollection.Add(objDatos)

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return objGenericCollection
    End Function

    'Public Function Cambiar_Estado_Tracto(ByVal objEntidad As Tracto) As Tracto

    '    Try
    '        Dim objParam As New Parameter
    '        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
    '        objParam.Add("PSSESTRG", objEntidad.SESTRG)
    '        objParam.Add("PSCULUSA", objEntidad.CULUSA)
    '        objParam.Add("PNFULTAC", objEntidad.FULTAC)
    '        objParam.Add("PNHULTAC", objEntidad.HULTAC)
    '        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
    '        objParam.Add("PSCCMPN", objEntidad.CCMPN)

    '        'ejecuta el procedimiento almacenado
    '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
    '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINA_TRACTO", objParam)

    '    Catch ex As Exception
    '        'objEntidad.NPLCUN = 0
    '    End Try

    '    Return objEntidad
    'End Function

End Class
