Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Namespace mantenimientos
    Public Class Tracto_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Tracto(ByVal objEntidad As Tracto) As Tracto

            'Try
            Dim objParam As New Parameter

            objParam.Add("POSNPLCUN", objEntidad.NPLCUN, ParameterDirection.Output)
            objParam.Add("PINNEJSUN", objEntidad.NEJSUN)
            objParam.Add("PISNSRCHU", objEntidad.NSRCHU)
            objParam.Add("PISNSRMTU", objEntidad.NSRMTU)
            objParam.Add("PINFFBRUN", objEntidad.FFBRUN)
            objParam.Add("PISTCLRUN", objEntidad.TCLRUN)
            objParam.Add("PISTCRRUN", objEntidad.TCRRUN)
            objParam.Add("PINNCPCRU", objEntidad.NCPCRU)
            objParam.Add("PINCTITRA", objEntidad.CTITRA)
            objParam.Add("PINQPSOTR", objEntidad.QPSOTR)
            objParam.Add("PISTMRCTR", objEntidad.TMRCTR)
            objParam.Add("PISNRGMT1", objEntidad.NRGMT1)
            objParam.Add("PSNTERPM", objEntidad.NTERPM)
            objParam.Add("PISCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PINFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PINHRACRT", objEntidad.HRACRT)
            objParam.Add("PISNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRA_TRACTO", objParam)
            objEntidad.NPLCUN = objSql.ParameterCollection("POSNPLCUN")

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    objEntidad.NPLCUN = "0"
            'End Try

            Return objEntidad
        End Function

        Public Function Registrar_Tracto_Antiguo(ByVal objEntidad As Tracto) As Tracto
            Try
                Dim objParam As New Parameter

                objParam.Add("POSNPLCUN", objEntidad.NPLCUN, ParameterDirection.Output)
                objParam.Add("PINNEJSUN", objEntidad.NEJSUN)
                objParam.Add("PISNSRCHU", objEntidad.NSRCHU)
                objParam.Add("PISNSRMTU", objEntidad.NSRMTU)
                objParam.Add("PINFFBRUN", objEntidad.FFBRUN)
                objParam.Add("PISTCLRUN", objEntidad.TCLRUN)
                objParam.Add("PISTCRRUN", objEntidad.TCRRUN)
                objParam.Add("PINNCPCRU", objEntidad.NCPCRU)
                objParam.Add("PINQPSOTR", objEntidad.QPSOTR)
                objParam.Add("PISTMRCTR", objEntidad.TMRCTR)
                objParam.Add("PISNRGMT1", objEntidad.NRGMT1)
                objParam.Add("PISCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PINFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PINHRACRT", objEntidad.HRACRT)
                objParam.Add("PISNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PNCTRSPT", objEntidad.CTRSPT)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TRACTO", objParam)
                objEntidad.NPLCUN = objSql.ParameterCollection("POSNPLCUN")

            Catch ex As Exception
                MsgBox(ex.Message)
                objEntidad.NPLCUN = "0"
            End Try

            Return objEntidad
        End Function



        Public Function Modificar_Tracto(ByVal objEntidad As Tracto) As Tracto

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PNNEJSUN", objEntidad.NEJSUN)
            objParam.Add("PSNSRCHU", objEntidad.NSRCHU)
            objParam.Add("PSNSRMTU", objEntidad.NSRMTU)
            objParam.Add("PNFFBRUN", objEntidad.FFBRUN)
            objParam.Add("PSTCLRUN", objEntidad.TCLRUN)
            objParam.Add("PSTCRRUN", objEntidad.TCRRUN)
            objParam.Add("PNNCPCRU", objEntidad.NCPCRU)
            objParam.Add("PNCTITRA", objEntidad.CTITRA)
            objParam.Add("PNQPSOTR", objEntidad.QPSOTR)
            objParam.Add("PSTMRCTR", objEntidad.TMRCTR)
            objParam.Add("PSNRGMT1", objEntidad.NRGMT1)
            objParam.Add("PSNTERPM", objEntidad.NTERPM)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICA_TRACTO", objParam)

            'Catch ex As Exception
            '    objEntidad.NPLCUN = "0"
            'End Try

            Return objEntidad
        End Function

        Public Function Cambiar_Estado_Tracto(ByVal objEntidad As Tracto) As Tracto

            Try
                Dim objParam As New Parameter
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PSSESTRG", objEntidad.SESTRG)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINA_TRACTO", objParam)

            Catch ex As Exception
                'objEntidad.NPLCUN = 0
            End Try

            Return objEntidad
        End Function

        Public Function Eliminar_Tracto(ByVal objEntidad As Tracto) As Tracto
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)


            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRACTO", objParam)

            'Catch ex As Exception
            '    objEntidad.NPLCUN = "0"
            'End Try

            Return objEntidad
        End Function

        Public Function Listar_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                If (String.IsNullOrEmpty(objEntidad.CCMPN) = False) Then
                    objParam.Add("PSCCMPN", objEntidad.CCMPN)
                End If

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO", objParam)
                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    Dim objDatos As New Tracto

                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                    objDatos.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                    objDatos.NSRMTU = objDataRow("NSRMTU").ToString.Trim
                    objDatos.FFBRUN = objDataRow("FFBRUN").ToString.Trim
                    objDatos.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                    objDatos.TCRRUN = objDataRow("TCRRUN").ToString.Trim
                    objDatos.NCPCRU = objDataRow("NCPCRU").ToString.Trim
                    objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
                    objDatos.QPSOTR = objDataRow("QPSOTR").ToString.Trim
                    objDatos.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                    objDatos.NRGMT1 = objDataRow("NRGMT1").ToString.Trim
                    objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                    objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                    objDatos.NTERPM = objDataRow("NTERPM").ToString.Trim


                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Tracto_X_Transportista(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO_X_TRANSPORTISTA", objParam)

                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    Dim objDatos As New Tracto

                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Tracto_x_Transportista_AS400(ByVal objetoParametro As Hashtable) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados       
                objParam.Add("PNCTRSPT", objetoParametro("PNCTRSPT"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO_X_TRANSPORTISTA_AS400", objParam)

                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows

                    Dim objDatos As New Tracto

                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                    objDatos.FFBRUN = objDataRow("FFBRUN").ToString.Trim
                    objDatos.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                    objDatos.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                    objDatos.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                    objDatos.QPSOTR = objDataRow("QPSOTR").ToString.Trim
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                    objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim

                    objGenericCollection.Add(objDatos)

                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Posicion_GPS_Flota_Propia(ByVal strCompania As String) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados        
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
                objDataTable = objSql.ExecuteDataTable("sp_solmin_st_listar_flota_transportista_propio", Nothing)
            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        Public Function Obtener_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim olbeTracto As New List(Of Tracto)
            'Try

            'Obteniendo resultados
            objParam.Add("PISNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_TRACTO", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                objEntidad.NEJSUN = objDataRow("NEJSUN").ToString.Trim
                objEntidad.NSRCHU = objDataRow("NSRCHU").ToString.Trim
                objEntidad.NSRMTU = objDataRow("NSRMTU").ToString.Trim
                objEntidad.FFBRUN = objDataRow("FFBRUN").ToString.Trim
                objEntidad.TCLRUN = objDataRow("TCLRUN").ToString.Trim
                objEntidad.TCRRUN = objDataRow("TCRRUN").ToString.Trim
                objEntidad.NCPCRU = objDataRow("NCPCRU").ToString.Trim
                objEntidad.CTITRA = objDataRow("CTITRA").ToString.Trim
                objEntidad.QPSOTR = objDataRow("QPSOTR").ToString.Trim
                objEntidad.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                objEntidad.NRGMT1 = objDataRow("NRGMT1").ToString.Trim
                objEntidad.NTERPM = objDataRow("NTERPM").ToString.Trim
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
            'Catch ex As Exception
            'End Try
            Return olbeTracto

        End Function

        Public Function Buscar_Tracto(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRACTO", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Tracto
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString().Trim()
                objDatos.NEJSUN = objDataRow("NEJSUN").ToString().Trim()
                objDatos.NSRCHU = objDataRow("NSRCHU").ToString().Trim()
                objDatos.NSRMTU = objDataRow("NSRMTU").ToString().Trim()
                objDatos.FFBRUN = objDataRow("FFBRUN").ToString().Trim()
                objDatos.TCLRUN = objDataRow("TCLRUN").ToString().Trim()
                objDatos.TCRRUN = objDataRow("TCRRUN").ToString().Trim()
                objDatos.NCPCRU = objDataRow("NCPCRU").ToString().Trim()
                objDatos.CTITRA = objDataRow("CTITRA").ToString().Trim()
                objDatos.QPSOTR = objDataRow("QPSOTR").ToString().Trim()
                objDatos.TMRCTR = objDataRow("TMRCTR").ToString().Trim()
                objDatos.NRGMT1 = objDataRow("NRGMT1").ToString().Trim()
                objDatos.NTERPM = objDataRow("NTERPM").ToString.Trim
                objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Lista_Vehiculos_Fluviales(ByVal objEntidad As Tracto) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of Tracto)
            'Dim objDatos As Tracto
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)

                'Obteniendo resultados
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_UNIDADES_FLUVIALES", objParam)
                'Procesandolos como una Lista
                'For Each objDataRow As DataRow In objDataTable.Rows
                '    objDatos = New Tracto
                '    objDatos.NPLCUN = objDataRow("NPLCUN").ToString
                '    objDatos.TOBS = objDataRow("TOBS").ToString.Trim

                '    objGenericCollection.Add(objDatos)
                'Next

            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        Public Function Registrar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As Tracto
            Try
                Dim objParam As New Parameter
                objParam.Add("PON_NMRCRL", objEntidad.NMRCRL, ParameterDirection.Output)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PNCTPCRA", objEntidad.CTPCRA)
                objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
                objParam.Add("PSTCMCND", objEntidad.TCMCND)
                objParam.Add("PNFECSEG", objEntidad.FECSEG)
                objParam.Add("PNHRASEG", objEntidad.HRASEG)
                objParam.Add("PSTDSDES", objEntidad.TDSDES)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_BITACORA_VEHICULO", objParam)
                objEntidad.NMRCRL = objSql.ParameterCollection("PON_NMRCRL")
            Catch ex As Exception
                objEntidad.NMRCRL = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
                objParam.Add("PNFECSEG", objEntidad.FECSEG)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_BITACORA_VEHICULO", objParam)
                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows
                    Dim objDatos As New Tracto
                    objDatos.NMRCRL = objDataRow("NMRCRL")
                    objDatos.NRITEM = objDataRow("ROWNUMBER")
                    objDatos.FECSEG_S = objDataRow("FECSEG_S").ToString.Trim
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                    objDatos.TCMCND = objDataRow("TCMCND").ToString.Trim
                    objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim

                    objGenericCollection.Add(objDatos)
                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Eliminar_Bitacora_Vehiculo(ByVal objEntidad As Tracto) As Tracto
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNMRCRL", objEntidad.NMRCRL)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_BITACORA_VEHICULO", objParam)

            Catch ex As Exception
                objEntidad.NMRCRL = "0"
            End Try

            Return objEntidad

        End Function

        Public Function Listar_Control_Flota(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Try
                'Obteniendo resultados
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PNCTPCRA", objEntidad.CTPCRA)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONTROL_FLOTA", objParam)
                'Procesandolos como una Lista
                For Each objDataRow As DataRow In objDataTable.Rows
                    Dim objDatos As New Tracto

                    objDatos.NMRCRL = objDataRow("NMRCRL")
                    objDatos.FECSEG_S = objDataRow("FECSEG_S").ToString.Trim
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                    objDatos.TCMCND = objDataRow("TCMCND").ToString.Trim
                    objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
                    objDatos.GPSLAT = objDataRow("GPSLAT").ToString.Trim
                    objDatos.GPSLON = objDataRow("GPSLON").ToString.Trim
                    objDatos.FECGPS = objDataRow("FECGPS").ToString.Trim
                    objDatos.HORGPS = objDataRow("HORGPS").ToString.Trim
                    objDatos.SEGWAP = objDataRow("SEGUIMIENTO").ToString.Trim
                    objGenericCollection.Add(objDatos)
                Next

            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        ' Public Function Cambiar_Tipo_Tracto(ByVal objEntidad As Tracto) As Int32
        Public Function Modificar_Asignacion_Tracto_Transportista(ByVal objEntidad As Tracto) As Int32
            Dim objParam As New Parameter
            Dim Result As Int32 = 0

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSSTPVHP", objEntidad.STPVHP)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VEHICULO_TIPO_UPDATE", objParam)

            Result = 1

            Return Result

        End Function

        'Obtener_Tracto_Tipo
        Public Function Obtener_Asignacion_Tracto_Transportista(ByVal objEntidad As Tracto) As List(Of Tracto)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter

            'Obteniendo resultados

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VEHICULO_TIPO", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Tracto

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.CPLNDV = objDataRow("CPLNDV")
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim

                objDatos.STPVHP = objDataRow("STPVHP").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next

            Return objGenericCollection
        End Function


        Public Function Buscar_Tracto_Paginado(ByVal objEntidad As Tracto, ByRef TotalPaginas As Decimal) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Tracto)
            Dim objParam As New Parameter
            Dim ds As New DataSet
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PAGESIZE", objEntidad.PAGESIZE)
            objParam.Add("PAGENUMBER", objEntidad.PAGENUMBER)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_BUSCAR_TRACTO_PAG", objParam)
            objDataTable = ds.Tables(0)
            TotalPaginas = ds.Tables(1).Rows(0)("PAGINAS")
            Return objDataTable
        End Function

    End Class

End Namespace
