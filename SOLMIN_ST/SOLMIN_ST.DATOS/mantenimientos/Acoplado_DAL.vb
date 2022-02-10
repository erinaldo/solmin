Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 16/07/2009 
'** Descripción: capa de acceso a datos.
'****************************************************************************************************
Namespace mantenimientos

    Public Class Acoplado_DAL

        Private objSql As New SqlManager


        Public Function Registrar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            'Try
            Dim objParam As New Parameter
            objParam.Add("POS_NPLCAC", objEntidad.NPLCAC, ParameterDirection.Output)
            objParam.Add("PSTCLRUN", objEntidad.TCLRUN)
            objParam.Add("PNQPSTRA", objEntidad.QPSTRA)
            objParam.Add("PNNEJSUN", objEntidad.NEJSUN)
            objParam.Add("PNNCPCRU", objEntidad.NCPCRU)
            objParam.Add("PSNSRCHU", objEntidad.NSRCHU)
            objParam.Add("PNQLNGAC", objEntidad.QLNGAC)
            objParam.Add("PNQANCAC", objEntidad.QANCAC)
            objParam.Add("PNQALTAC", objEntidad.QALTAC)
            objParam.Add("PNCTIACP", objEntidad.CTIACP)
            objParam.Add("PSNRGMT2", objEntidad.NRGMT2)
            objParam.Add("PSTCNFG2", objEntidad.TCNFG2)
            objParam.Add("PSTMRCVH", objEntidad.TMRCVH)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ACOPLADO", objParam)

            objEntidad.NPLCAC = objSql.ParameterCollection("POS_NPLCAC")


            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    objEntidad.NPLCAC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Registrar_Acoplado_Antiguo(ByVal objEntidad As Acoplado) As Acoplado
            Try
                Dim objParam As New Parameter
                objParam.Add("POS_NPLCAC", objEntidad.NPLCAC, ParameterDirection.Output)
                objParam.Add("PSTCLRUN", objEntidad.TCLRUN)
                objParam.Add("PNQPSTRA", objEntidad.QPSTRA)
                objParam.Add("PNNEJSUN", objEntidad.NEJSUN)
                objParam.Add("PNNCPCRU", objEntidad.NCPCRU)
                objParam.Add("PSNSRCHU", objEntidad.NSRCHU)
                objParam.Add("PNQLNGAC", objEntidad.QLNGAC)
                objParam.Add("PNQANCAC", objEntidad.QANCAC)
                objParam.Add("PNQALTAC", objEntidad.QALTAC)
                objParam.Add("PSNRGMT2", objEntidad.NRGMT2)
                objParam.Add("PSTCNFG2", objEntidad.TCNFG2)
                objParam.Add("PSTMRCVH", objEntidad.TMRCVH)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PNCTRSPT", objEntidad.CTRSPT)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_ACOPLADO_ANTIGUO", objParam)
                objEntidad.NPLCAC = objSql.ParameterCollection("POS_NPLCAC")

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NPLCAC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Modificar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSTCLRUN", objEntidad.TCLRUN)
            objParam.Add("PNQPSTRA", objEntidad.QPSTRA)
            objParam.Add("PNNEJSUN", objEntidad.NEJSUN)
            objParam.Add("PNNCPCRU", objEntidad.NCPCRU)
            objParam.Add("PSNSRCHU", objEntidad.NSRCHU)
            objParam.Add("PNQLNGAC", objEntidad.QLNGAC)
            objParam.Add("PNQANCAC", objEntidad.QANCAC)
            objParam.Add("PNQALTAC", objEntidad.QALTAC)
            objParam.Add("PNCTIACP", objEntidad.CTIACP)
            objParam.Add("PSNRGMT2", objEntidad.NRGMT2)
            objParam.Add("PSTCNFG2", objEntidad.TCNFG2)
            objParam.Add("PSTMRCVH", objEntidad.TMRCVH)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_ACOPLADO", objParam)

            'Catch ex As Exception
            '    objEntidad.NPLCAC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Acoplado(ByVal objEntidad As Acoplado) As Acoplado
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINA_ACOPLADO", objParam)

            'Catch ex As Exception
            '    objEntidad.NPLCAC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function BuscarAcoplado(ByVal objEntidad As Acoplado) As List(Of Acoplado)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Acoplado)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_ACOPLADO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Acoplado

                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                objDatos.QPSTRA = objDataRow("QPSTRA").ToString.Trim
                objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                objDatos.NCPCRU = objDataRow("NCPCRU").ToString.Trim
                objDatos.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                objDatos.QLNGAC = objDataRow("QLNGAC").ToString.Trim
                objDatos.QANCAC = objDataRow("QANCAC").ToString.Trim
                objDatos.QALTAC = objDataRow("QALTAC").ToString.Trim
                objDatos.CTIACP = objDataRow("CTIACP").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.NRGMT2 = objDataRow("NRGMT2").ToString.Trim
                objDatos.TCNFG2 = objDataRow("TCNFG2").ToString.Trim
                objDatos.TMRCVH = objDataRow("TMRCVH").ToString.Trim

                objDatos.TDEACP = objDataRow("TDEACP").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Acoplado(ByVal objEntidad As Acoplado) As List(Of Acoplado)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Acoplado)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACOPLADOS", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Acoplado

                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                objDatos.QPSTRA = objDataRow("QPSTRA").ToString.Trim
                objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                objDatos.NCPCRU = objDataRow("NCPCRU").ToString.Trim
                objDatos.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                objDatos.QLNGAC = objDataRow("QLNGAC").ToString.Trim
                objDatos.QANCAC = objDataRow("QANCAC").ToString.Trim
                objDatos.QALTAC = objDataRow("QALTAC").ToString.Trim
                objDatos.CTIACP = objDataRow("CTIACP").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.NRGMT2 = objDataRow("NRGMT2").ToString.Trim
                objDatos.TCNFG2 = objDataRow("TCNFG2").ToString.Trim
                objDatos.TMRCVH = objDataRow("TMRCVH").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.TDEACP = objDataRow("TDEACP").ToString.Trim
                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim


                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Lista_Artefacto_Fluviales(ByVal objEntidad As Acoplado) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of Acoplado)
            'Dim objDatos As Acoplado
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)

            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ARTEFACTOS_FLUVIALES", objParam)
            'Procesandolos como una Lista
            'For Each objDataRow As DataRow In objDataTable.Rows
            '    objDatos = New Acoplado
            '    objDatos.NPLCAC = objDataRow("NPLCAC").ToString
            '    objDatos.TOBS = objDataRow("TOBS").ToString.Trim

            '    objGenericCollection.Add(objDatos)
            'Next

            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

        'Cambiar_Tipo_Acoplado
        Public Function Modificar_Asignacion_Acoplado_Transportista(ByVal objEntidad As Acoplado) As Int32
            Dim objDataTable As New DataTable
            Dim result As Int32 = 0
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSSTPACP", objEntidad.STPACP)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACOPLADO_TIPO_UPDATE", objParam)

            result = 1
            Return result

        End Function

        'Obtener_Acoplado_Tipo
        Public Function Obtener_Datos_Asignacion_Acoplado_Transportista(ByVal objEntidad As Acoplado) As List(Of Acoplado)

            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Acoplado)
            Dim objParam As New Parameter

            'Obteniendo resultados
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ACOPLADO_TIPO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Acoplado

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.CPLNDV = objDataRow("CPLNDV").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                objDatos.STPACP = objDataRow("STPACP").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            Return objGenericCollection
        End Function


        Public Function Listar_AcopladoPaginado(ByVal objEntidad As Acoplado, ByRef TotalPaginas As Decimal) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Acoplado)
            Dim objParam As New Parameter
            Dim ds As New DataSet

            'Try
            'Obteniendo resultados
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PAGESIZE", objEntidad.PAGESIZE)
            objParam.Add("PAGENUMBER", objEntidad.PAGENUMBER)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_ACOPLADOS_PAG", objParam)
            objDataTable = ds.Tables(0)
            TotalPaginas = ds.Tables(1).Rows(0)("PAGINAS")
            'Procesandolos como una Lista
            'For Each objDataRow As DataRow In objDataTable.Rows

            '    Dim objDatos As New Acoplado

            '    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
            '    objDatos.TCLRUN = objDataRow("TCLRUN").ToString.Trim
            '    objDatos.QPSTRA = objDataRow("QPSTRA").ToString.Trim
            '    objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim
            '    objDatos.NCPCRU = objDataRow("NCPCRU").ToString.Trim
            '    objDatos.NSRCHU = objDataRow("NSRCHU").ToString.Trim
            '    objDatos.QLNGAC = objDataRow("QLNGAC").ToString.Trim
            '    objDatos.QANCAC = objDataRow("QANCAC").ToString.Trim
            '    objDatos.QALTAC = objDataRow("QALTAC").ToString.Trim
            '    objDatos.CTIACP = objDataRow("CTIACP").ToString.Trim
            '    objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
            '    objDatos.NRGMT2 = objDataRow("NRGMT2").ToString.Trim
            '    objDatos.TCNFG2 = objDataRow("TCNFG2").ToString.Trim
            '    objDatos.TMRCVH = objDataRow("TMRCVH").ToString.Trim
            '    objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
            '    objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
            '    objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
            '    objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
            '    objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
            '    objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
            '    objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
            '    objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
            '    objDatos.TDEACP = objDataRow("TDEACP").ToString.Trim
            '    objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim


            '    objGenericCollection.Add(objDatos)

            'Next

            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

    End Class

End Namespace
