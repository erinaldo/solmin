Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario

Namespace mantenimientos

    Public Class GuiaTransportista_DAL
        Private objSql As New SqlManager

        Public Function Verificacion_Existencia_Operacion_Transporte(ByVal objEntidad As OperacionTransporte) As OperacionTransporte
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PON_NPLNMT", 0, ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_PLANEAMIENTO_DE_OPERACION", objParam)

                objEntidad.NPLNMT = objSql.ParameterCollection("PON_NPLNMT")
            Catch ex As Exception
                objEntidad.NPLNMT = 0
            End Try
            Return objEntidad
        End Function

        Public Function Obtener_Numero_Guia_Transporte(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
                objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_GUIA_DE_TRANSPORTE", objParam)

                objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
            Catch ex As Exception
                objEntidad.NGUIRM = 0
            End Try
            Return objEntidad
        End Function

        Public Function Obtener_Informacion_Orden_Servicio(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR, ParameterDirection.Output)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS, ParameterDirection.Output)
            objParam.Add("PNQMRCDR", objEntidad.QMRCMC, ParameterDirection.Output)
            objParam.Add("PNCUNDMD", objEntidad.CUNDMD, ParameterDirection.Output)
            objParam.Add("PNCMNFLT", objEntidad.CMNFLT, ParameterDirection.Output)
            objParam.Add("PNQKMREC", objEntidad.QKMREC, ParameterDirection.Output)
            objParam.Add("PSTNMBRM", objEntidad.TNMBRM, ParameterDirection.Output)
            objParam.Add("PSTDRCRM", objEntidad.TDRCRM, ParameterDirection.Output)
            objParam.Add("PSTPDCIR", objEntidad.TPDCIR, ParameterDirection.Output)
            objParam.Add("PNNRUCRM", objEntidad.NRUCRM, ParameterDirection.Output)

            'EN MODIFICACION
            '------------------------------------------------------
            objParam.Add("PSNPLCTR", objEntidad.NPLCTR)
            objParam.Add("PSTCNFVH", objEntidad.TCNFVH, ParameterDirection.Output)

            objParam.Add("PNCCNCST", objEntidad.CCNCST, ParameterDirection.Output)
            objParam.Add("PSTDSCAR", objEntidad.TDSCAR, ParameterDirection.Output)
            objParam.Add("PNCCLNT", objEntidad.CCLNT, ParameterDirection.Output)

            objParam.Add("PNCUBORI", objEntidad.CUBORI, ParameterDirection.Output)
            objParam.Add("PNCUBDES", objEntidad.CUBDES, ParameterDirection.Output)
            'objParam.Add("PSCMNFLTDESC", objEntidad.CMNFLTDESC, ParameterDirection.Output)
            '------------------------------------------------------

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_INFORMACION_ORDEN_SERVICIO", objParam)

            objEntidad.CLCLOR = objSql.ParameterCollection("PNCLCLOR")
            objEntidad.CLCLDS = objSql.ParameterCollection("PNCLCLDS")
            objEntidad.QMRCMC = objSql.ParameterCollection("PNQMRCDR")
            objEntidad.CUNDMD = objSql.ParameterCollection("PNCUNDMD")
            objEntidad.CMNFLT = objSql.ParameterCollection("PNCMNFLT")
            objEntidad.QKMREC = objSql.ParameterCollection("PNQKMREC")
            objEntidad.TNMBRM = objSql.ParameterCollection("PSTNMBRM").ToString.Trim
            objEntidad.TDRCRM = objSql.ParameterCollection("PSTDRCRM").ToString.Trim
            objEntidad.TPDCIR = objSql.ParameterCollection("PSTPDCIR").ToString.Trim
            objEntidad.NRUCRM = objSql.ParameterCollection("PNNRUCRM")
            objEntidad.CCLNT = objSql.ParameterCollection("PNCCLNT")

            objEntidad.CUBORI = objSql.ParameterCollection("PNCUBORI")
            objEntidad.CUBDES = objSql.ParameterCollection("PNCUBDES")

            objEntidad.TNMBCN = objEntidad.TNMBRM
            objEntidad.TDRCNS = objEntidad.TDRCRM
            objEntidad.TPDCIC = objEntidad.TPDCIR
            objEntidad.NRUCCN = objEntidad.NRUCRM

            'EN MODIFICACION
            '------------------------------------------------------
            objEntidad.TCNFVH = objSql.ParameterCollection("PSTCNFVH").ToString.Trim
            If objEntidad.TCNFVH = "0" OrElse objEntidad.TCNFVH = "" Then objEntidad.TCNFVH = ""

            objEntidad.CCNCST = objSql.ParameterCollection("PNCCNCST")
            objEntidad.TDSCAR = objSql.ParameterCollection("PSTDSCAR").ToString.Trim
            If objEntidad.TDSCAR.Length > 30 Then
                objEntidad.TDSCAR = objEntidad.TDSCAR.Substring(0, 30)
            End If
            'objEntidad.CMNFLTDESC = objSql.ParameterCollection("PSCMNFLTDESC").ToString.Trim
            'PSCMNFLTDESC
            '------------------------------------------------------

            'Catch ex As Exception
            '    Return New GuiaTransportista
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_Tractos_x_Planeamiento(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNPLNMT", objEntidad.NPLNMT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO_X_PLANEAMIENTO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NRUCTR = objData("NRUCTR").ToString.Trim
                obj_Entidad.NPLCTR = objData("NPLCTR").ToString.Trim
                obj_Entidad.NPLCAC = objData("NPLCAC").ToString.Trim
                obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
                obj_Entidad.CBRCND = objData("CBRCND").ToString.Trim
                obj_Entidad.CBRCN2 = objData("CBRCN2").ToString.Trim
                obj_Entidad.CBRCND2 = objData("CBRCND2").ToString.Trim
                obj_Entidad.RUTA = objData("RUTA").ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guias_General(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            'objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PSCPLNDV", objetoParametro("PSCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))


            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objParam.Add("PNNORSRT", objetoParametro("PNNORSRT"))
            objParam.Add("PSFLGSTA", objetoParametro("PSFLGSTA"))
            objParam.Add("PSSESGRP", objetoParametro("PSSESGRP"))
            'objParam.Add("PNRESAPR", objetoParametro("PNRESAPR"))
            objParam.Add("PNFENINI", objetoParametro("PNFENINI"))
            objParam.Add("PNFENFIN", objetoParametro("PNFENFIN"))

            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
            objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))

            objParam.Add("PSFTRTSG", objetoParametro("PSFTRTSG"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_GENERAL", objParam)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_GENERAL_V2", objParam)
            '
            Dim objEntidad As GuiaTransportista

            For Each objData As DataRow In objDataTable.Rows

                'objEntidad = LeerDatos(fila)
                objEntidad = New GuiaTransportista

                objEntidad.CHECK = True
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.NGUIRM = objData("NGUIRM")

                objEntidad.NGUITS = objData("NGUITS")
                objEntidad.CTDGRT = objData("CTDGRT")
 

                objEntidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData("FGUIRM"))
                objEntidad.NPLNMT = objData("NPLNMT")
              
                objEntidad.NOPRCN = objData("NOPRCN")
              
                objEntidad.CTRSPT = objData("CTRSPT")
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
             
                objEntidad.SESTRG = objData("SESTRG").ToString.Trim
              
                objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData("CPLNDV")
               
                objEntidad.RUTA = objData("RUTA").ToString.Trim
                objEntidad.CBRCND = objData("CBRCND").ToString.Trim
              
                objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim
              
                objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim

                objEntidad.NCSOTR = objData("NCSOTR").ToString.Trim
                objEntidad.QSLCIT = objData("QSLCIT").ToString.Trim
                objEntidad.NDCORM = objData("NDCORM").ToString.Trim
                objEntidad.NMVJCS = objData("NMVJCS").ToString.Trim
                objEntidad.NRUCTR = objData("NRUCTR")

                'JMC  -----------------------------------------------------------------
                objEntidad.FLGSTA_DESC = objData("FLGSTA_DESC").ToString.Trim
                objEntidad.FLGSTA = objData("FLGSTA").ToString.Trim
             
                objEntidad.PLANTA_FACT = objData("PLANTA_FACT") 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                objEntidad.PLANTA = objData("PLANTA") ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                objEntidad.CEBED = objData("CEBED")
                objEntidad.CEBEO = objData("CEBEO")

                objEntidad.CCLNT = objData("CCLNT")
                objEntidad.FTRTSG = objData("FTRTSG").ToString.Trim
                objEntidad.NMRGIM = objData("NMRGIM")
                objEntidad.NMRGIM_DESC = objData("NMRGIM_DESC")

                objEntidad.CRGVTA = objData("CRGVTA")
                objEntidad.APROB_TARIFA = objData("APROB_TARIFA")


                'objEntidad.CLCLOR = objData("CLCLOR")
                'objEntidad.CLCLDS = objData("CLCLDS")
                'objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                'objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                'objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                'objEntidad.QMRCMC = objData("QMRCMC")
                'objEntidad.PMRCMC = objData("PMRCMC")
                'objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                'objEntidad.QGLGSL = objData("QGLGSL")
                'objEntidad.QGLDSL = objData("QGLDSL")
                'objEntidad.NRHJCR = objData("NRHJCR")
                'objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                'objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                'objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                'objEntidad.NRUCRM = objData("NRUCRM")
                'objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                'objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                'objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                'objEntidad.NRUCCN = objData("NRUCCN")
                'objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                'objEntidad.CMNFLT = objData("CMNFLT")
                'objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                'objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                'objEntidad.QKMREC = objData("QKMREC")
                'objEntidad.ICSTRM = objData("ICSTRM")
                'objEntidad.QPSOBR = objData("QPSOBR")
                'objEntidad.QVLMOR = objData("QVLMOR")
                'objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                'objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                'objEntidad.IVLPRT = objData("IVLPRT")
                'objEntidad.CMNVLP = objData("CMNVLP")
                'objEntidad.CUBORI = objData("CUBORI")
                'objEntidad.CUBDES = objData("CUBDES")
                'objEntidad.FEMVLH = objData("FEMVLH")       
                ' objEntidad.FEMVLH_S = HelpClass.FechaNum_a_Fecha(objData("FEMVLH_S"))
                ' objEntidad.FCHFTR_S = HelpClass.FechaNum_a_Fecha(objData("FCHFTR_S"))
                ' objEntidad.FECETA_S = HelpClass.FechaNum_a_Fecha(objData("FECETA_S"))
                ' objEntidad.FECETD_S = HelpClass.FechaNum_a_Fecha(objData("FECETD_S"))
                'EN MODIFICACION
                'objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                'objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                'objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                'objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                'objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                'objEntidad.CMRCDR = objData("CMRCDR")
                'objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                'If objData("USUENA").ToString.Trim.Equals("") Then
                '    objEntidad.USUARIO_ENVIO = ""
                'Else
                '    objEntidad.USUARIO_ENVIO = objData("USUENA").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objData("FCHENA").ToString.Trim) & " " & HelpClass.CNumero_a_Hora(objData("HRAENA").ToString.Trim)
                'End If
                'If objData("USRAPR").ToString.Trim.Equals("") Then
                '    objEntidad.USUARIO_APROBADOR = ""
                'Else
                '    objEntidad.USUARIO_APROBADOR = objData("USRAPR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objData("FCHAPR").ToString.Trim) & " " & HelpClass.CNumero_a_Hora(objData("HRAAPR").ToString.Trim)
                'End If
                'objEntidad.OBSRV_APROBACION = objData("TOBS").ToString.Trim

                'objEntidad.COD_AR_RESP = objData("COD_AR_RESP")
                'objEntidad.ARE_RESP = objData("ARE_RESP").ToString.Trim
                'objEntidad.FLGGTI = objData("FLGGTI")
                'objEntidad.CRGVTA = objData("CRGVTA").ToString.Trim
                'objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                'objEntidad.SSINVJ = objData("SSINVJ").ToString.Trim

                objGenericCollection.Add(objEntidad)

            Next


            Return objGenericCollection
        End Function

        Private Function LeerDatos(ByVal objData As DataRow) As GuiaTransportista
            Dim objEntidad = New GuiaTransportista

            objEntidad.CHECK = True
            objEntidad.CTRMNC = objData("CTRMNC")
            objEntidad.NGUIRM = objData("NGUIRM")
            'objEntidad.FGUIRM_S = HelpClass.CFecha_de_8_a_10(objData("FGUIRM").ToString.Trim)
            objEntidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData("FGUIRM"))
            objEntidad.NPLNMT = objData("NPLNMT")
            objEntidad.CLCLOR = objData("CLCLOR")
            objEntidad.CLCLDS = objData("CLCLDS")
            objEntidad.TDIROR = objData("TDIROR").ToString.Trim
            objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
            objEntidad.NOPRCN = objData("NOPRCN")
            objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
            objEntidad.QMRCMC = objData("QMRCMC")
            objEntidad.PMRCMC = objData("PMRCMC")
            objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
            objEntidad.QGLGSL = objData("QGLGSL")
            objEntidad.QGLDSL = objData("QGLDSL")
            objEntidad.NRHJCR = objData("NRHJCR")
            objEntidad.CTRSPT = objData("CTRSPT")
            objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
            objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
            objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
            objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
            objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
            objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
            objEntidad.NRUCRM = objData("NRUCRM")
            objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
            objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
            objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
            objEntidad.NRUCCN = objData("NRUCCN")
            objEntidad.SACRGO = objData("SACRGO").ToString.Trim
            objEntidad.CMNFLT = objData("CMNFLT")
            objEntidad.SESTRG = objData("SESTRG").ToString.Trim
            objEntidad.FLGADC = objData("FLGADC").ToString.Trim
            objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
            objEntidad.QKMREC = objData("QKMREC")
            objEntidad.ICSTRM = objData("ICSTRM")
            objEntidad.QPSOBR = objData("QPSOBR")
            objEntidad.QVLMOR = objData("QVLMOR")
            objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
            objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
            objEntidad.IVLPRT = objData("IVLPRT")
            objEntidad.CMNVLP = objData("CMNVLP")
            objEntidad.CCMPN = objData("CCMPN").ToString.Trim
            objEntidad.CDVSN = objData("CDVSN").ToString.Trim
            objEntidad.CPLNDV = objData("CPLNDV")
            objEntidad.CUBORI = objData("CUBORI")
            objEntidad.CUBDES = objData("CUBDES")
            objEntidad.FEMVLH = objData("FEMVLH")
            'objEntidad.FEMVLH_S = HelpClass.CFecha_de_8_a_10(objData("FEMVLH_S").ToString.Trim)
            'objEntidad.FCHFTR_S = HelpClass.CFecha_de_8_a_10(objData("FCHFTR_S").ToString.Trim)
            'objEntidad.FECETA_S = HelpClass.CFecha_de_8_a_10(objData("FECETA_S").ToString.Trim)
            'objEntidad.FECETD_S = HelpClass.CFecha_de_8_a_10(objData("FECETD_S").ToString.Trim)
            objEntidad.FEMVLH_S = HelpClass.FechaNum_a_Fecha(objData("FEMVLH_S"))
            objEntidad.FCHFTR_S = HelpClass.FechaNum_a_Fecha(objData("FCHFTR_S"))
            objEntidad.FECETA_S = HelpClass.FechaNum_a_Fecha(objData("FECETA_S"))
            objEntidad.FECETD_S = HelpClass.FechaNum_a_Fecha(objData("FECETD_S"))
            objEntidad.RUTA = objData("RUTA").ToString.Trim
            objEntidad.CBRCND = objData("CBRCND").ToString.Trim
            'objEntidad.TOBS = objData("TOBS").ToString.Trim
            'EN MODIFICACION
            objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
            objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
            objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
            objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

            objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
            objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
            objEntidad.CMRCDR = objData("CMRCDR")
            objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

            objEntidad.SESGRP = objData("SESGRP").ToString.Trim
            objEntidad.NORSRT = objData("NORSRT").ToString.Trim
            objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
            objEntidad.NOREMB = objData("NOREMB").ToString.Trim

            objEntidad.NCSOTR = objData("NCSOTR").ToString.Trim
            objEntidad.QSLCIT = objData("QSLCIT").ToString.Trim
            objEntidad.NDCORM = objData("NDCORM").ToString.Trim
            objEntidad.NMVJCS = objData("NMVJCS").ToString.Trim
            objEntidad.NRUCTR = objData("NRUCTR")
            objEntidad.SSINVJ = objData("SSINVJ").ToString.Trim
            'JMC  -----------------------------------------------------------------
            objEntidad.FLGSTA_DESC = objData("FLGSTA_DESC").ToString.Trim
            If objData("USUENA").ToString.Trim.Equals("") Then
                objEntidad.USUARIO_ENVIO = ""
            Else
                objEntidad.USUARIO_ENVIO = objData("USUENA").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objData("FCHENA").ToString.Trim) & " " & HelpClass.CNumero_a_Hora(objData("HRAENA").ToString.Trim)
            End If
            If objData("USRAPR").ToString.Trim.Equals("") Then
                objEntidad.USUARIO_APROBADOR = ""
            Else
                objEntidad.USUARIO_APROBADOR = objData("USRAPR").ToString.Trim & " " & HelpClass.FechaNum_a_Fecha(objData("FCHAPR").ToString.Trim) & " " & HelpClass.CNumero_a_Hora(objData("HRAAPR").ToString.Trim)
            End If
            'objEntidad.OBSRV_APROBACION = objData("TOBS1").ToString.Trim
            objEntidad.OBSRV_APROBACION = objData("TOBS").ToString.Trim
            objEntidad.FLGSTA = objData("FLGSTA").ToString.Trim
            objEntidad.COD_AR_RESP = objData("COD_AR_RESP")
            objEntidad.ARE_RESP = objData("ARE_RESP").ToString.Trim


            objEntidad.FLGGTI = objData("FLGGTI")
            'objEntidad.CECOTI = objData("CECOTI")

            objEntidad.PLANTA_FACT = objData("PLANTA_FACT") 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            objEntidad.PLANTA = objData("PLANTA") ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            objEntidad.CEBED = objData("CEBED")
            'objEntidad.CECOD = objData("CECOD")
            objEntidad.CEBEO = objData("CEBEO")
            objEntidad.CRGVTA = objData("CRGVTA").ToString.Trim
            objEntidad.CCLNT = objData("CCLNT")
            objEntidad.FTRTSG = objData("FTRTSG").ToString.Trim

            objEntidad.NMRGIM = objData("NMRGIM")

            objEntidad.NMRGIM_DESC = objData("NMRGIM_DESC")
            'NMRGIM

            '----------------------------------------------------------------------
            Return objEntidad
        End Function

        Public Function Listar_Guias_x_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFGUIRM", objEntidad.FGUIRM)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT")
                obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guias_x_Transportista(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista

            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNNGUIRM", objEntidad("NGUIRM"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE", objParam)


            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista

                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NGUIRS = objData("NGUIRS")
                obj_Entidad.DNGUIRS = Formato_Documento.FormatearDocGuiaRemision(objData("CTDGRM"), objData("NGUIRS"))
                obj_Entidad.TCMPCL = objData("CCLNT") & " - " & objData("TCMPCL").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT")
                obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
                obj_Entidad.CTDGRM = objData("CTDGRM")

                objGenericCollection.Add(obj_Entidad)
            Next

            Return objGenericCollection
        End Function

      


        Public Function Listar_Guias_x_Transportista_Proveedor(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNNGUIRM", objEntidad("NGUIRM"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE_PROVEEDOR", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista
                'If IsNumeric(objData("NGUIRM")) Then
                obj_Entidad.NGUIRM_S = objData("NGUIRM")
                obj_Entidad.NGUIRS = objData("NGUIRS")
                obj_Entidad.DNGUIRS = objData("NGUIRS")
                obj_Entidad.TCMPCL = objData("CPRVCL") & " - " & objData("TCMPCL").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT")
                obj_Entidad.CPRVCL = objData("CPRVCL")
                obj_Entidad.NGUIRM = 0

                obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
                objGenericCollection.Add(obj_Entidad)

            Next

            Return objGenericCollection
        End Function

        Public Function Registrar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

            Dim objParam As New Parameter

            objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
            objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
            objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
            objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
            objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)
            objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
            objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
            objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
            objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
            objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
            objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
            objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
            objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
            objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
            objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
            objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
            objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
            objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
            objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
            objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
            objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
            objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
            objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
            objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
            objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
            objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
            objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
            objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
            objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
            objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
            objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
            objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
            objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
            objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
            objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
            objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
            objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
            objParam.Add("PARAM_FECETD", objEntidad.FECETD)
            objParam.Add("PARAM_FECETA", objEntidad.FECETA)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
            'EN MODIFICACION
            objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("PARAM_CTPOV2", objEntidad.CTPOV2)

            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

            objParam.Add("PARAM_HRAINI", objEntidad.HRAINI)


            objParam.Add("PARAM_NGUITS", objEntidad.NGUITS)
            objParam.Add("PARAM_CTDGRT", objEntidad.CTDGRT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GUIA_TRANSPORTISTA_AUTOGENERADA", objParam)

            objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
       
            Return objEntidad
        End Function

        Public Function Registrar_Guia_Transportista_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

            Dim objParam As New Parameter

            objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
            objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)

            objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
            objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
            objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)
            objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
            objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
            objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
            objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
            objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
            objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
            objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
            objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
            objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
            objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
            objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
            objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
            objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
            objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
            objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
            objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
            objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
            objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
            objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
            objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
            objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
            objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
            objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
            objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
            objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
            objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
            objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
            objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
            objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
            objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
            objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
            objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
            objParam.Add("PARAM_FECETD", objEntidad.FECETD)
            objParam.Add("PARAM_FECETA", objEntidad.FECETA)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
            'EN MODIFICACION
            objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("PARAM_CTPOV2", objEntidad.CTPOV2)

            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

            objParam.Add("PARAM_HRAINI", IIf(objEntidad.HRAINI = String.Empty, 0, objEntidad.HRAINI))


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            Dim dt As New DataTable

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GUIA_TRANSPORTISTA_MANUAL", objParam)
            objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")

 
            Return objEntidad
        End Function

        Public Function Modificar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

            Dim objParam As New Parameter

            objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
            objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
            objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
            objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
            objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
            objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
            objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
            objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
            objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
            objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
            objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
            objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
            objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
            objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
            objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
            objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
            objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
            objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
            objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
            objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
            objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
            objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
            objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
            objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
            objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
            objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
            objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
            objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
           
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
            objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
            objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
            objParam.Add("PARAM_FECETD", objEntidad.FECETD)
            objParam.Add("PARAM_FECETA", objEntidad.FECETA)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            'EN MODIFICACION
            objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
            objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
            objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
            objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)

            objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)

            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

            objParam.Add("PARAM_HRAINI", IIf(objEntidad.HRAINI = String.Empty, 0, objEntidad.HRAINI))

         
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_GUIA_TRANSPORTISTA_AUTOGENERADA", objParam)

            objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
           
            Return objEntidad
        End Function


        Public Function Registrar_Guia_Transportista_General(ByVal objEntidad As GuiaTransportista, ByRef msgError As String) As GuiaTransportista

            Dim objParam As New Parameter

            objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
            objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM)

            objParam.Add("PARAM_GENERAR_GT", objEntidad.GENERAR_GT)
            objParam.Add("PARAM_NGUITS", objEntidad.NGUITS)
            objParam.Add("PARAM_CTDGRT", objEntidad.CTDGRT)

            objParam.Add("PARAM_NCSOTR", objEntidad.NCSOTR)
            objParam.Add("PARAM_NCRRSR", objEntidad.NCRRSR)

            objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
            objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
            objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)
            objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
            objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
            objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
            objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
            objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
            objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
            objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
            objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
            objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
            objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
            objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
            objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
            objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
            objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
            objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
            objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
            objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
            objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
            objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
            objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
            objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
            objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
            objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
            objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
            objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
            objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
            objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
            objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
            objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
            objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
            objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
            objParam.Add("PARAM_FECETD", objEntidad.FECETD)
            objParam.Add("PARAM_FECETA", objEntidad.FECETA)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
            'EN MODIFICACION
            objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("PARAM_CTPOV2", objEntidad.CTPOV2)

            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

            objParam.Add("PARAM_HRAINI", IIf(objEntidad.HRAINI = String.Empty, 0, objEntidad.HRAINI))

            objParam.Add("PARAM_FLGAPA", objEntidad.FLGAPA)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            Dim dt As New DataTable
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_GUIA_TRANSPORTISTA_GENERAL", objParam)

            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msgError = msgError & item("OBSRESULT") & Chr(13)
                End If
            Next
            msgError = msgError.Trim

            If msgError.Length = 0 And dt.Rows.Count > 0 Then
                objEntidad.NGUIRM = dt.Rows(0)("NGUIRM")
                objEntidad.NGUITS = dt.Rows(0)("NGUITS")
            End If

            'Catch ex As Exception
            '    objEntidad.NGUIRM = 0
            'End Try
            Return objEntidad
        End Function

        Public Sub Modificar_Guia_Transportista_General(ByVal objEntidad As GuiaTransportista)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
            'objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
            objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM)
            objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
            objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
            objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
            objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
            objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
            objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
            objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
            objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
            objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
            objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
            objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
            objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
            objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
            objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
            objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
            objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
            objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
            objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
            objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
            objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
            objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
            objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
            objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
            objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
            objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
            objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
            'objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
            'objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            'objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            'objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
            objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
            objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
            objParam.Add("PARAM_FECETD", objEntidad.FECETD)
            objParam.Add("PARAM_FECETA", objEntidad.FECETA)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            'EN MODIFICACION
            objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
            objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
            objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
            objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)

            objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)

            objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

            objParam.Add("PARAM_HRAINI", IIf(objEntidad.HRAINI = String.Empty, 0, objEntidad.HRAINI))

            'objParam.Add("PARAM_NGUITS", objEntidad.NGUITS)
            'objParam.Add("PARAM_CTDGRT", objEntidad.CTDGRT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_GUIA_TRANSPORTISTA_GENERAL", objParam)

            'objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
            'Catch ex As Exception
            '    objEntidad.NGUIRM = 0
            'End Try

        End Sub


        Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            'Try

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            Select Case objetoParametro("ESTADO")
                Case 0
                    objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                    objParam.Add("PSFLGSTA", objetoParametro("PSFLGSTA"))
                    objParam.Add("PSSESGRP", objetoParametro("PSSESGRP"))
                    objParam.Add("PNRESAPR", objetoParametro("PNRESAPR"))
                    objParam.Add("PNFENINI", objetoParametro("PNFENINI"))
                    objParam.Add("PNFENFIN", objetoParametro("PNFENFIN"))
                    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V2_LA", objParam)
                Case 1
                    objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                    objParam.Add("PNNORSRT", objetoParametro("PNNORSRT"))
                    objParam.Add("PSFLGSTA", objetoParametro("PSFLGSTA"))
                    objParam.Add("PSSESGRP", objetoParametro("PSSESGRP"))
                    objParam.Add("PNRESAPR", objetoParametro("PNRESAPR"))
                    objParam.Add("PNFENINI", objetoParametro("PNFENINI"))
                    objParam.Add("PNFENFIN", objetoParametro("PNFENFIN"))
                    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V5_LA", objParam)
                Case 2
                    objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
                    objParam.Add("PSFLGSTA", objetoParametro("PSFLGSTA"))
                    objParam.Add("PSSESGRP", objetoParametro("PSSESGRP"))
                    objParam.Add("PNRESAPR", objetoParametro("PNRESAPR"))
                    objParam.Add("PNFENINI", objetoParametro("PNFENINI"))
                    objParam.Add("PNFENFIN", objetoParametro("PNFENFIN"))
                    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V3_LA", objParam)
                Case 3
                    objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
                    objParam.Add("PSFLGSTA", objetoParametro("PSFLGSTA"))
                    objParam.Add("PSSESGRP", objetoParametro("PSSESGRP"))
                    objParam.Add("PNRESAPR", objetoParametro("PNRESAPR"))
                    objParam.Add("PNFENINI", objetoParametro("PNFENINI"))
                    objParam.Add("PNFENFIN", objetoParametro("PNFENFIN"))
                    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V4_LA", objParam)
            End Select


            For Each fila As DataRow In objDataTable.Rows
                objEntidad = LeerDatos(fila)
                objGenericCollection.Add(objEntidad)
            Next
            ''Catch ex As Exception
            ''    Dim s As String = ""
            ''End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Transportista_Reparto(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try


            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))

            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PSCPLNDV", objetoParametro("PSCPLNDV"))
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_X_OPERACION_REPARTO", objParam)

            'Catch ex As Exception
            '          Dim s As String = ""
            '      End Try
            Return objDataTable
        End Function

        Public Function Listar_Viaje_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            'Try
            objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            'objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PSCPLNDV", objetoParametro("PSCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VIAJE_CONSOLIDADO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objEntidad = New GuiaTransportista
                objEntidad.CHECK = True
                objEntidad.NMVJCS = objData("NMVJCS")
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.FCHVJC_S = Validacion.CFecha_a_Numero10Digitos(objData("FCHVJC").ToString)
                objEntidad.RUTA = objData("RUTA").ToString.Trim
                objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                objEntidad.PSOVOL = Format(objData("PSOVOL"), "###,###.00")
                objEntidad.PMRCMC = Format(objData("PMRCMC"), "###,###.00")
                objEntidad.QPSOBR = Format(objData("QPSOBR"), "###,###.00")
                objEntidad.FLGSTS = objData("FLGSTS").ToString.Trim
                objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData("CPLNDV")
                objEntidad.TPLNTA = objData("TPLNTA")
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '          Dim s As String = ""
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Moneda(ByVal strCompania As String) As DataTable
            Dim objDataTable As New DataTable
            'Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_MONEDA", Nothing)
            'Catch : End Try

            Return objDataTable
        End Function

        Public Function Obtener_Codigo_Transportista(ByVal lstr_RUC As String, ByVal strCompania As String) As Double
            Dim lstr_Codigo As Double = 0

            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", strCompania)
            objParam.Add("PSNRUCTR", lstr_RUC)
            objParam.Add("PNCTRSPT", 0, ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CODIGO_TRANSPORTISTA", objParam)

            lstr_Codigo = objSql.ParameterCollection("PNCTRSPT").ToString
            'Catch : End Try

            Return lstr_Codigo
        End Function

        Public Function Obtener_RUC_Transportista(ByVal lstr_Codigo As Double, ByVal strCompania As String) As String
            Dim lstr_RUC As String = ""

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", strCompania)
            objParam.Add("PNCTRSPT", lstr_Codigo)
            objParam.Add("PSNRUCTR", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_RUC_TRANSPORTISTA", objParam)

            lstr_RUC = objSql.ParameterCollection("PSNRUCTR").ToString
            'Catch : End Try

            Return lstr_RUC
        End Function

        Public Function Obtener_Guia_Transportista_RPT(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Dim obj_Entidad As New GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            For Each objData As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_GUIA_TRANSPORTISTA_RPT", objParam).Rows

                obj_Entidad.CTRMNC = objData("CTRMNC")
                obj_Entidad.NGUIRM = objData("NGUIRM")

                obj_Entidad.CTDGRT = objData("CTDGRT")
                obj_Entidad.NGUITS = objData("NGUITS")
               

                obj_Entidad.FGUIRM = objData("FGUIRM")
                obj_Entidad.TRFRGU = objData("TRFRGU").ToString.Trim
                obj_Entidad.QMRCMC = objData("QMRCMC")
                obj_Entidad.PMRCMC = objData("PMRCMC")
                obj_Entidad.CUNDMD = objData("CUNDMD").ToString.Trim
                obj_Entidad.QGLGSL = objData("QGLGSL")
                obj_Entidad.QGLDSL = objData("QGLDSL")
                obj_Entidad.NRHJCR = objData("NRHJCR")
                obj_Entidad.CTRSPT = objData("CTRSPT")
                obj_Entidad.NPLCTR = objData("NPLCTR").ToString.Trim
                obj_Entidad.NPLCAC = objData("NPLCAC").ToString.Trim
                obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
                obj_Entidad.TNMBRM = objData("TNMBRM").ToString.Trim
                obj_Entidad.TDRCRM = objData("TDRCRM").ToString.Trim
                obj_Entidad.TPDCIR = objData("TPDCIR").ToString.Trim
                obj_Entidad.NRUCRM = objData("NRUCRM")
                obj_Entidad.TNMBCN = objData("TNMBCN").ToString.Trim
                obj_Entidad.TDRCNS = objData("TDRCNS").ToString.Trim
                obj_Entidad.TPDCIC = objData("TPDCIC").ToString.Trim
                obj_Entidad.NRUCCN = objData("NRUCCN")
                obj_Entidad.NOPRCN = objData("NOPRCN")
                obj_Entidad.NPLNMT = objData("NPLNMT")
                obj_Entidad.NORSRT = objData("NORSRT").ToString.Trim
                obj_Entidad.NRGUCL_S = objData("NRGUCL").ToString.Trim
                obj_Entidad.QKMREC = objData("QKMREC")
                obj_Entidad.ICSTRM = objData("ICSTRM")
                obj_Entidad.QPSOBR = objData("QPSOBR")
                obj_Entidad.QVLMOR = objData("QVLMOR")
                obj_Entidad.SMRPLG = objData("SMRPLG").ToString.Trim
                obj_Entidad.SMRPRC = objData("SMRPRC").ToString.Trim
                obj_Entidad.IVLPRT = objData("IVLPRT")
                obj_Entidad.CMNVLP = objData("CMNVLP")
                obj_Entidad.CUBORI_S = objData("CUBORI").ToString.Trim
                obj_Entidad.CUBDES_S = objData("CUBDES").ToString.Trim
                obj_Entidad.TDIROR = objData("TDIROR").ToString.Trim
                obj_Entidad.TDIRDS = objData("TDIRDS").ToString.Trim
                obj_Entidad.FEMVLH = objData("FEMVLH")
                obj_Entidad.TOBS = objData("TOBS").ToString.Trim
                obj_Entidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                obj_Entidad.TCNFVH = objData("TCNFVH").ToString.Trim
                obj_Entidad.CMEDTR = objData("CMEDTR").ToString.Trim
               
            Next
            'Catch : End Try
            Return obj_Entidad
        End Function

        Public Function Registrar_GuiasCliente_Automatico(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION
                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
                objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
                objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
                objParam.Add("TIPOGUIA", objEntidad.FLAG_PSOVOL)
                objParam.Add("PNNGRPRV", objEntidad.TOBS)
                objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
                '------------------------------------------
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        'Public Function Registrar_GuiasCliente_Automatico_Origen(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
        Public Sub Registrar_GuiasCliente_Automatico_Origen(ByVal objEntidad As GuiaTransportista)
            'Try
            Dim objParam As New Parameter
            '-- SE MODIFICO, SE AGREGO OPERACION
            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
            objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
            objParam.Add("TIPOGUIA", objEntidad.FLAG_PSOVOL)
            objParam.Add("PNNGRPRV", objEntidad.TOBS)
            objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
            '------------------------------------------
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objParam.Add("PSNGUIRS", objEntidad.NGUIRS)
            objParam.Add("PSCTDGRM", objEntidad.CTDGRM)
            objParam.Add("PSCTPCRG", objEntidad.CTPCRG)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE_SALM", objParam)

            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            'Return objEntidad
        End Sub






        Public Function Registrar_GuiasCliente_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION
                objParam.Add("PNCTRMNC", objEntidad.CTRMNC, ParameterDirection.Output)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL, ParameterDirection.Output)
                objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                'objParam.Add("PNNRSERI", objEntidad.NRSERI)
                'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
                objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
                objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
                '------------------------------------------
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNPSOVOL", objEntidad.PSOVOL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE_MANUAL", objParam)
                objEntidad.NRGUCL = objSql.ParameterCollection("PNNRGUCL")
                objEntidad.CTRMNC = objSql.ParameterCollection("PNCTRMNC")
                objEntidad.NGUIRM = objSql.ParameterCollection("PNNGUIRM")
            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function


        Public Function Registrar_GuiasCliente_Manual_Salm(ByVal objEntidad As GuiaTransportista) As String
            'Try
            Dim dtresult As New DataTable
            Dim objParam As New Parameter
            '-- SE MODIFICO, SE AGREGO OPERACION
            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            'objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNGUIRT", objEntidad.NGUIRM)
            'objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PSNGUIRS", objEntidad.NGUIRS)
            objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            'objParam.Add("PNNRSERI", objEntidad.NRSERI)
            'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
            objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
            objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
            '------------------------------------------
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNPSOVOL", objEntidad.PSOVOL)


            objParam.Add("PSCTDGRM", objEntidad.CTDGRM)
            objParam.Add("PSCTPCRG", objEntidad.CTPCRG)
 

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE_MANUAL_SALM", objParam)
            Dim msg As String = ""
            For Each item As DataRow In dtresult.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(13)
                End If
                'STATUS
            Next
            msg = msg.Trim
            'objEntidad.NRGUCL = objSql.ParameterCollection("PNNRGUCL")
            'objEntidad.CTRMNC = objSql.ParameterCollection("PNCTRMNC")
            'objEntidad.NGUIRM = objSql.ParameterCollection("PNNGUIRM")
            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            Return msg
        End Function


        Public Function Registrar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSNORCMC", objEntidad.NORCMC)
            objParam.Add("PNNRITOC", objEntidad.NRITOC)
            objParam.Add("PNQCNTIT", objEntidad.QCNTIT)
            objParam.Add("PSCREFFW", objEntidad.CREFFW)
            objParam.Add("PNNSEQIN", objEntidad.NSEQIN)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_COMPRA", objParam)

            'Catch ex As Exception
            '    objEntidad.NORCMC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Registrar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PSCTDGRT", objEntidad.CTDGRT)
            objParam.Add("PSNGTSAD", objEntidad.NGTSAD)
            objParam.Add("PNFGUIRM", objEntidad.FGUIRM)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            'objParam.Add("PNNGUIAD", objEntidad.NGUIAD)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)

          
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_ANEXO_GUIA_TRANSPORTISTA", objParam)

            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            Return objEntidad
        End Function


        Public Function Agregar_Guia_Transportista_Adicional(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte

            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_GUIA_TRANSPORTISTA_ADICIONAL", objParam)

            'Catch ex As Exception
            '    objEntidad.NGUITR = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNGUIAD", objEntidad.NGUIAD)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA_ANEXA", objParam)

            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_GuiasCliente(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_CLIENTE", objParam)

            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)



            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_ORDEN_COMPRA_CLIENTE", objParam)

            'Catch ex As Exception
            '    objEntidad.NORCMC = 0
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Orden_Compra(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSNORCMC", objEntidad.NORCMC)
            objParam.Add("PNNRITOC", objEntidad.NRITOC)
            objParam.Add("PNNCRRGR", objEntidad.NCRRGR)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                   

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_ORDEN_COMPRA", objParam)

            'Catch ex As Exception
            '    objEntidad.NORCMC = 0
            'End Try
            Return objEntidad
        End Function

        'Public Function Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
        Public Sub Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA", objParam)

            'Catch ex As Exception
            '    objEntidad.CTRMNC = 0
            'End Try
            'Return objEntidad
        End Sub


        Public Sub Listar_Guias_X_GuiaTransportista(ByVal objEntidad As GuiaTransportista, ByRef listGRCliente As List(Of GuiaTransportista), ByRef listGTAnexo As List(Of GuiaTransportista), ByRef listOC As List(Of ENTIDADES.GuiaOCManifiestoCarga), ByRef dtPesoGT As DataTable)
            Dim obj_Entidad As GuiaTransportista
            Dim obj_EntidadOC As ENTIDADES.GuiaOCManifiestoCarga


            Dim objParam As New Parameter
            Dim ds As New DataSet
            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            Dim dtGRCliente As New DataTable
            Dim dtGTAnexo As New DataTable
            Dim dtOC As New DataTable
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_GUIAS_X_GT", objParam)
            dtGRCliente = ds.Tables(0)           
            dtOC = ds.Tables(1)
            dtGTAnexo = ds.Tables(2)
            dtPesoGT = ds.Tables(3)

            listGRCliente = New List(Of GuiaTransportista)

            For Each objData As DataRow In dtGRCliente.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NRGUCL = objData("NRGUCL")
                obj_Entidad.NGUIRS = objData("NGUIRS")
                obj_Entidad.DNGUIRS = Formato_Documento.FormatearDocGuiaRemision(objData("CTDGRM"), objData("NGUIRS"))
                obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT")
                obj_Entidad.FCGUCL_S = HelpClass.FechaNum_a_Fecha(objData("FCGUCL"))
                obj_Entidad.SESTRG = objData("CASE").ToString.Trim
                obj_Entidad.NOPRCN = objData("NOPRCN")
                listGRCliente.Add(obj_Entidad)
            Next

            listGTAnexo = New List(Of GuiaTransportista)
            For Each objData As DataRow In dtGTAnexo.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NGUIAD = objData("NGUIAD")

                obj_Entidad.NGTSAD = objData("NGTSAD")
                obj_Entidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData("FGUIRM"))
                listGTAnexo.Add(obj_Entidad)
            Next

            listOC = New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            For Each objData As DataRow In dtOC.Rows
                obj_EntidadOC = New ENTIDADES.GuiaOCManifiestoCarga
                obj_EntidadOC.NGUIRM = objData("NGUIRM")
                obj_EntidadOC.NRGUCL = objData("NRGUCL")
                obj_EntidadOC.NGUIRS = objData("NGUIRS")
                obj_EntidadOC.DNGUIRS = Formato_Documento.FormatearDocGuiaRemision(objData("CTDGRM"), objData("NGUIRS"))
                obj_EntidadOC.NORCMC = objData("NORCMC").ToString.Trim
                obj_EntidadOC.NRITOC = objData("NRITOC")
                obj_EntidadOC.TDITES = objData("TDITES").ToString.Trim
                obj_EntidadOC.TUNDIT = objData("TUNDIT").ToString.Trim
                obj_EntidadOC.QCNTIT = objData("QCNTIT")
                obj_EntidadOC.CREFFW = objData("CREFFW").ToString.Trim
                obj_EntidadOC.NSEQIN = objData("NSEQIN")
                obj_EntidadOC.NCRRGR = objData("NCRRGR")
                listOC.Add(obj_EntidadOC)
            Next



        End Sub

        Public Function Listar_Guias_Anexas_Cliente(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ANEXO_GUIA_CLIENTE_LA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NRGUCL = objData("NRGUCL")
                obj_Entidad.NGUIRS = objData("NGUIRS")
                obj_Entidad.DNGUIRS = Formato_Documento.FormatearDocGuiaRemision(objData("CTDGRM"), objData("NGUIRS"))
                obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT")
                obj_Entidad.FCGUCL_S = HelpClass.FechaNum_a_Fecha(objData("FCGUCL"))
                obj_Entidad.SESTRG = objData("CASE").ToString.Trim
                obj_Entidad.NOPRCN = objData("NOPRCN")
                objGenericCollection.Add(obj_Entidad)
            Next

            Return objGenericCollection
        End Function

        Public Function Listar_Guias_Anexas_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ANEXO_GUIA_TRANSPORTISTA_LA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NGUIAD = objData("NGUIAD")
                'obj_Entidad.FGUIRM_S = HelpClass.CFecha_de_8_a_10(objData("FGUIRM").ToString.Trim)
                obj_Entidad.NGTSAD = objData("NGTSAD")
                obj_Entidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData("FGUIRM"))
                objGenericCollection.Add(obj_Entidad)
            Next

            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Ordenes_Compra_x_MC(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Dim obj_Entidad As ENTIDADES.GuiaOCManifiestoCarga
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ORDENES_COMPRA_X_GUIA_TRANSPORTISTA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New ENTIDADES.GuiaOCManifiestoCarga
                obj_Entidad.NGUIRM = objData("NGUIRM")
                obj_Entidad.NRGUCL = objData("NRGUCL")
                obj_Entidad.NGUIRS = objData("NGUIRS")
                obj_Entidad.DNGUIRS = Formato_Documento.FormatearDocGuiaRemision(objData("CTDGRM"), objData("NGUIRS"))
                obj_Entidad.NORCMC = objData("NORCMC").ToString.Trim
                obj_Entidad.NRITOC = objData("NRITOC")
                obj_Entidad.TDITES = objData("TDITES").ToString.Trim
                obj_Entidad.TUNDIT = objData("TUNDIT").ToString.Trim
                obj_Entidad.QCNTIT = objData("QCNTIT")
                obj_Entidad.CREFFW = objData("CREFFW").ToString.Trim
                obj_Entidad.NSEQIN = objData("NSEQIN")
                obj_Entidad.NCRRGR = objData("NCRRGR")
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Solicitudes_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of Detalle_Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
            Dim obj_Entidad As Detalle_Solicitud_Transporte
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNGUIRM", objetoParametro("PNNGUIRM"))
            objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_GUIA_TRANSPORTISTA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New Detalle_Solicitud_Transporte
                obj_Entidad.NCSOTR = objData("NCSOTR").ToString.Trim
                obj_Entidad.NCRRSR = objData("NCRRSR").ToString.Trim
                obj_Entidad.FASGTR = objData("FASGTR").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT").ToString.Trim
                obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
                obj_Entidad.CTRSPT = objData("CTRSPT").ToString.Trim
                obj_Entidad.NPLCUN = objData("NPLCUN").ToString.Trim
                obj_Entidad.NGUITR = objData("NGUITR").ToString.Trim
                obj_Entidad.NPLNMT = objData("NPLNMT").ToString.Trim
                obj_Entidad.NOPRCN = objData("NOPRCN").ToString.Trim
                obj_Entidad.SESTOP = objData("SESTOP").ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          Return New List(Of Detalle_Solicitud_Transporte)
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Remision_x_Operacion(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim obj_Entidad As GuiaTransportista
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_REMISION_x_OPERACION", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New GuiaTransportista

                obj_Entidad.NOPRCN = objData("NOPRCN").ToString.Trim
                obj_Entidad.NGUIRM = objData("NGUITR").ToString.Trim
                obj_Entidad.FGUIRM = objData("FGUITR").ToString.Trim
                obj_Entidad.CTRSPT = objData("CTRSPT").ToString.Trim
                obj_Entidad.NPLCTR = objData("NPLVHT").ToString.Trim
                obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
                obj_Entidad.CBRCND = objData("TDSTRT").ToString.Trim
                obj_Entidad.SRPTRM = objData("SRPTRM").ToString.Trim
                obj_Entidad.FSLDCM = objData("FSLDCM").ToString.Trim
                obj_Entidad.FLLGCM = objData("FLLGCM").ToString.Trim
                obj_Entidad.QPSOBR = objData("PBRTOR").ToString.Trim
                obj_Entidad.QMRCMC = objData("QBLORG").ToString.Trim
                obj_Entidad.QVLMOR = objData("QVLMOR").ToString.Trim
                obj_Entidad.QKMREC = objData("QKLMRC").ToString.Trim
                obj_Entidad.CCLNT = objData("CCLNT1").ToString.Trim
                obj_Entidad.TCMPCL = objData("TRFMRC").ToString.Trim
                obj_Entidad.CCMPN = objData("CCMPN").ToString.Trim
                obj_Entidad.CDVSN = objData("CDVSN").ToString.Trim
                obj_Entidad.CPLNDV = objData("CPLNDV").ToString.Trim

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          Return New List(Of GuiaTransportista)
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Configuracion_Vehicular(ByVal strCompania As String) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim obj_Entidad As ClaseGeneral
            'Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CONFIGURACION_VEHICULAR", Nothing)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New ClaseGeneral

                obj_Entidad.TCNFVH = objData("TCNFVH").ToString.Trim
                obj_Entidad.TDSCM1 = objData("TDSCM1").ToString.Trim
                obj_Entidad.QCRUTV = objData("QCRUTV")

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          Return New List(Of ClaseGeneral)
            '      End Try
            Return objGenericCollection
        End Function

        ' Liquidaci�n de Fletes
        Public Function Listar_GRemPendientesGTranspLiquidacion(ByVal oFiltro As TD_GuiaTransportistaPK) As List(Of TD_Obj_GuiaRemisionGTransp)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GuiaRemisionGTransp)
            Dim oGuiaRemisionGTransp As TD_Obj_GuiaRemisionGTransp
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_CTRMNC", oFiltro.pCTRMNC_CodigoTransportista)
            objParam.Add("IN_NGUIRM", oFiltro.pNGUIRM_NroGuiaTransportista)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Ccompania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_PENDIENTES_PARA_LIQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                oGuiaRemisionGTransp = New TD_Obj_GuiaRemisionGTransp()

                oGuiaRemisionGTransp.pCTRMNC_CodigoTransportista = oFiltro.pCTRMNC_CodigoTransportista
                oGuiaRemisionGTransp.pNGUIRM_NroGuiaTransportista = oFiltro.pNGUIRM_NroGuiaTransportista
                oGuiaRemisionGTransp.pNRGUCL_NroGuiaRemision = objData("NRGUCL")
                oGuiaRemisionGTransp.pTCMPCL_RazonSocialCliente = objData("TCMPCL")
                oGuiaRemisionGTransp.pCCLNT_CodigoCliente = objData("CCLNT")
                oGuiaRemisionGTransp.pFCGUCL_FechaGuiaRemision = objData("FCGUCL")
                oGuiaRemisionGTransp.pNGUIRS = objData("NGUIRS")

                objGenericCollection.Add(oGuiaRemisionGTransp)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objEntidad.pNGUIRM_NroGuiaTransportista
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                obj_Entidad.pNGUIRS_GuiaRemisionCargada = objData("NGUIRS")
 

                obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                'obj_Entidad.pTCMTRT_Proveedor = objData("PROVEEDOR")
                obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim
                obj_Entidad.pCantLiq = objData("CANTLIQ")
                obj_Entidad.pNUMEROCO = objData("NUMEROCO")

                objGenericCollection.Add(obj_Entidad)
            Next

            Return objGenericCollection
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As Hashtable) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_CTRMNC", objEntidad("CTRMNC"))
            objParam.Add("IN_NGUIRM", objEntidad("NGUIRM"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_GUIA_TRANSPORTE_PARA_LIQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objEntidad("NGUIRM") 'objEntidad.pNGUIRM_NroGuiaTransportista
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          sErrorMessage = ex.ToString
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion_Reparto(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ_REPARTO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim
                obj_Entidad.pCantLiq = objData("CANTLIQ")
                obj_Entidad.pNUMEROCO = objData("NUMEROCO")

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          sErrorMessage = ex.ToString
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion_Multimodal(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ_MULTIMODAL", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '          sErrorMessage = ex.ToString
            '      End Try
            Return objGenericCollection
        End Function

        Public Function Listar_GRemHijasCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemHijasCargadasGTranspLiqPK) As List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemHijasCargadasGTranspLiq
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_HIJAS_CARGADAS_PARA_LIQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemHijasCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objEntidad.pNOPRCN_NroOperacion
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objEntidad.pNGUITR_GuiaRemisionCargada
                obj_Entidad.pNGUIRF_NroDocumentoReferencia = objData("NGUIRF")
                obj_Entidad.pQCCMP1_CantidadComponente1Gsl = objData("QCCMP1")
                obj_Entidad.pQCCMP2_CantidadComponente2Dsl = objData("QCCMP2")
                obj_Entidad.pTDSEXO_Observacion = objData("TDSEXO").ToString.Trim
                obj_Entidad.pCCLNT1_CodigoCliente = objData("CCLNT1")

                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_GRemServCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemServCargadasGTranspLiq
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_PARA_LIQ", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemServCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = oFiltro.pNOPRCN_NroOperacion
                obj_Entidad.pNGUITR_NroGuiaRemision = oFiltro.pNGUITR_NroGuiaRemision
                obj_Entidad.pNCRRGU_CorrServ = objData("NCRRGU")
                obj_Entidad.pCSRVC_Servicio = objData("CSRVC")
                obj_Entidad.pTCMTRF_DetalleServicio = ("" & objData("TCMTRF")).ToString.Trim
                obj_Entidad.pISRVGU_importeServicio = objData("ISRVGU")

                obj_Entidad.pNRUCTR_RucProveedor = objData("NRUCTR").ToString.Trim
                obj_Entidad.pTCMTRT_Proveedor = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pCMNDGU_MonedaGuia = objData("CMNDGU")
                obj_Entidad.pCMNDGU_MonedaGuia_S = ("" & objData("CMNDGU_S")).ToString.Trim

                obj_Entidad.pQCNDTG_CantidadServicio = objData("QCNDTG")
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pSFCTTR_StatusFacturado = ("" & objData("SFCTTR")).ToString.Trim

                obj_Entidad.pILQDTR_ImporteLiquidacionTransp = objData("ILQDTR")
                obj_Entidad.pQCNDLG_CantidadServicioLiquidacion = objData("QCNDLG")
                obj_Entidad.pCUNDTR_Unidad = ("" & objData("CUNDTR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSLQDTR_StatusLiquTransporte = ("" & objData("SLQDTR")).ToString.Trim

                obj_Entidad.pTRFSRG_RefrenciaServicioGuia = ("" & objData("TRFSRG")).ToString.Trim
                obj_Entidad.pCMNLQT_Moneda = objData("CMNLQT")
                obj_Entidad.pVLRFDT_ValReferencia = objData("VLRFDT")
                obj_Entidad.pCMNLQT_Moneda_S = ("" & objData("CMNLQT_S")).ToString.Trim
                obj_Entidad.pSFCTOP_SERV = ("" & objData("SFCTOP_SERV")).ToString.Trim

                'obj_Entidad.pSFLGTI_StTarifaInterna = objData("SFLGTI").ToString().Trim()
                'obj_Entidad.pQCNDTI_CantidadTarifaInterna = objData("QCNDTI")
                'obj_Entidad.pCUNDTI_UnidadTarifaInterna = objData("CUNDTI").ToString().Trim()
                'obj_Entidad.pISRVTI_ImporteTarifaInt = objData("ISRVTI")
                'obj_Entidad.pCMNDTI_DESC_Moneda = objData("CMNDTI_DESC").ToString().Trim()
                'obj_Entidad.pNUMEROCO_NroTarifaInterna = objData("NUMEROCO")
                'obj_Entidad.pCMNDTI = objData("CMNDTI").ToString().Trim()

                'obj_Entidad.pSENITEM = objData("SENITEM")

                obj_Entidad.COBRO_S = objData("COBRO_S")
                obj_Entidad.PAGO_S = objData("PAGO_S")
                obj_Entidad.MARGEN_S = objData("MARGEN_S")
                obj_Entidad.MARGEN_POR = objData("MARGEN_POR")

                obj_Entidad.pFLGOTF_FlagTarifaOS = objData("FLGOTF")

               
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function




        Public Function Listar_Estado_Operacion_Guia(pNOPRN As Decimal, pGuiaRem As Decimal) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
            'Dim obj_Entidad As TD_Obj_GRemServCargadasGTranspLiq
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", pNOPRN)
            objParam.Add("IN_NGUITR", pGuiaRem)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ESTADO_OPERACION_GUIA", objParam)
            Return objDataTable
        End Function


        Public Function Listar_GRemServCargadasGTranspLiquidacion_Refactura(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemServCargadasGTranspLiq
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_PARA_LIQ_REFACTURA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemServCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = oFiltro.pNOPRCN_NroOperacion
                obj_Entidad.pNGUITR_NroGuiaRemision = oFiltro.pNGUITR_NroGuiaRemision
                obj_Entidad.pNCRRGU_CorrServ = objData("NCRRGU")
                obj_Entidad.pCSRVC_Servicio = objData("CSRVC")
                obj_Entidad.pTCMTRF_DetalleServicio = ("" & objData("TCMTRF")).ToString.Trim
                obj_Entidad.pISRVGU_importeServicio = objData("ISRVGU")
                obj_Entidad.pCMNDGU_MonedaGuia = objData("CMNDGU")
                obj_Entidad.pCMNDGU_MonedaGuia_S = ("" & objData("CMNDGU_S")).ToString.Trim

                obj_Entidad.pQCNDTG_CantidadServicio = objData("QCNDTG")
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_ServiciosPorDefectoPorCliente(ByVal oFiltro As TD_Qry_ServiciosFijosPorCliente) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_CCMPN", oFiltro.pCCMPN_Compania)
            objParam.Add("IN_CDVSN", oFiltro.pCDVSN_Division)
            objParam.Add("IN_CPLNDV", oFiltro.pCPLNDV_Planta)
            objParam.Add("IN_CCLNT", oFiltro.pCCLNT_CodigoCliente)
            objParam.Add("IN_NORSRT", oFiltro.pNORSRT_OrdenServicio)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_TRANSP_POR_CLIENTE", objParam)
            'Catch
            '          objDataTable = New DataTable
            '      End Try
            Return objDataTable
        End Function

        Public Function Registrar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)


                objParam.Add("IN_NGUIRS", objEntidad.pNGUITR_GuiaRemisionCargadaTXT)

                objParam.Add("IN_FGUITR", objEntidad.pFGUITR_FechaGuiaRemisionFNum)
                objParam.Add("IN_RELGUI", objEntidad.pRELGUI_RelacionGuiaHijas)
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NLQDCN", objEntidad.pNLQDCN_NroLiquidacion)
                objParam.Add("IN_CTRSPT", objEntidad.pCTRSPT_Transportista)
                objParam.Add("IN_NPLVHT", objEntidad.pNPLVHT_Tracto)
                objParam.Add("IN_CBRCNT", objEntidad.pCBRCNT_Brevete)
                objParam.Add("IN_CMRCDR", objEntidad.pCMRCDR_Mercaderia)
                objParam.Add("IN_CCLNT1", objEntidad.pCCLNT1_CodigoCliente)
                objParam.Add("IN_CLCLOR", objEntidad.pCLCLOR_CodigoLocalidadOrigen)
                objParam.Add("IN_CLCLDS", objEntidad.pCLCLDS_CodigoLocalidadDestino)
                objParam.Add("IN_FRCGRM", objEntidad.pFRCGRM_FechaRecepGuiaRemisionFNum)
                objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
                objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
                objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
                objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
                objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
                objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
                objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
                objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
                objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
                objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
                objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
                objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
                objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
                objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
                objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
                objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
                objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
                objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
                objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
                objParam.Add("IN_SSINVJ", objEntidad.pSSINVJ_FlagSiniestroViaje)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                objParam.Add("OU_ERRMSG", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_GUIA_TRANSPORTISTA_PARA_LIQ", objParam)
                sErrorMesage = objSql.ParameterCollection("OU_ERRMSG")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        'Public Function Registrar_GuiaRemisionLiqTransp_Reparto(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
        '  Dim bResultado As Boolean = True
        '  Try
        '    Dim objParam As New Parameter

        '    objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
        '    objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
        '    objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)
        '    objParam.Add("IN_FGUITR", objEntidad.pFGUITR_FechaGuiaRemisionFNum)
        '    objParam.Add("IN_RELGUI", objEntidad.pRELGUI_RelacionGuiaHijas)
        '    objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
        '    objParam.Add("IN_NLQDCN", objEntidad.pNLQDCN_NroLiquidacion)
        '    objParam.Add("IN_CTRSPT", objEntidad.pCTRSPT_Transportista)
        '    objParam.Add("IN_NPLVHT", objEntidad.pNPLVHT_Tracto)
        '    objParam.Add("IN_CBRCNT", objEntidad.pCBRCNT_Brevete)
        '    objParam.Add("IN_CMRCDR", objEntidad.pCMRCDR_Mercaderia)
        '    objParam.Add("IN_CCLNT1", objEntidad.pCCLNT1_CodigoCliente)
        '    objParam.Add("IN_CLCLOR", objEntidad.pCLCLOR_CodigoLocalidadOrigen)
        '    objParam.Add("IN_CLCLDS", objEntidad.pCLCLDS_CodigoLocalidadDestino)
        '    objParam.Add("IN_FRCGRM", objEntidad.pFRCGRM_FechaRecepGuiaRemisionFNum)
        '    objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
        '    objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
        '    objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
        '    objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
        '    objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
        '    objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
        '    objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
        '    objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
        '    objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
        '    objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
        '    objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
        '    objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
        '    objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
        '    objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
        '    objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
        '    objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
        '    objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
        '    objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
        '    objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
        '    objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
        '    objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
        '    objParam.Add("OU_ERRMSG", "", ParameterDirection.Output)

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        '    objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_GUIA_TRANSPORTISTA_PARA_LIQ_REPARTO", objParam)
        '    sErrorMesage = objSql.ParameterCollection("OU_ERRMSG")
        '    If sErrorMesage <> "" Then bResultado = False
        '  Catch ex As Exception
        '    sErrorMesage = ex.Message
        '    bResultado = False
        '  End Try
        '  Return bResultado
        'End Function
        'Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean

        Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As Int32
            'Dim bResultado As Boolean = True
            Dim bResultado As Int32 = 0
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_FTRMOP", objEntidad.pFTRMOP_FechaOperacionFNum)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP2", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportistaProvVarios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef msgError As String) As Int32
            'Dim bResultado As Boolean = True
            Dim bResultado As Int32 = 0
            msgError = ""
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_FTRMOP", objEntidad.pFTRMOP_FechaOperacionFNum)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                'objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_PROV_VARIOS", objParam)
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_PROV_VARIOS_V2", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                msgError = ex.Message
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByVal sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_REPARTO2", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False

            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_FCHVJC", objEntidad.FCHVJC)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_CONSOLIDADO", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(ByVal objEntidad As TransporteConsolidado) As String

            'Dim bResultado As Int32 = 0
            Dim msgError As String = ""
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_FTRMOP", objEntidad.FCHVJC)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_CONSOLIDADO2", objParam)
            Catch ex As Exception
                msgError = ex.Message
            End Try
            Return msgError
        End Function

        Public Sub Registrar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq)
            'Dim bResultado As Boolean = True
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
            objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
            objParam.Add("IN_CMNLQT", objEntidad.pCMNLQT_Moneda)
            objParam.Add("IN_ILQDTR", objEntidad.pILQDTR_ImporteLiquidacionTransp)
            objParam.Add("IN_QCNDLG", objEntidad.pQCNDLG_CantidadServicioLiquidacion)
            objParam.Add("IN_CUNDTR", objEntidad.pCUNDTR_Unidad)
            objParam.Add("IN_SLQDTR", objEntidad.pSLQDTR_StatusLiquTransporte)
            objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
            objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            'Catch ex As Exception
            '    sErrorMesage = ex.Message
            '    bResultado = False
            'End Try
            'Return bResultado
        End Sub

        Public Function Eliminar_GRemCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As String
            'Dim bResultado As Boolean = True
            Dim sErrorMensaje As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_CTRMNC", oFiltro.pCTRMNC_CodigoTransportista)
            objParam.Add("IN_NGUIRM", oFiltro.pNGUIRM_NroGuiaTransportista)
            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)
            objParam.Add("IN_MMCUSR", oFiltro.pMMCUSR_Usuario)
            objParam.Add("IN_NTRMNL", oFiltro.pNTRMNL_Terminal)
            objParam.Add("OU_ERRMSG", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GREMISION_CARGADAS_PARA_LIQ", objParam)

            sErrorMensaje = ("" & objSql.ParameterCollection("OU_ERRMSG"))
            'If sErrorMensaje <> "" Then bResultado = False
            'Catch ex As Exception
            '    bResultado = False
            'End Try
            'Return bResultado
            Return sErrorMensaje
        End Function

        Public Sub Eliminar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK)
            'Dim bResultado As Boolean = True
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
            objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            'Catch ex As Exception
            '    sErrorMesage = ex.Message
            '    bResultado = False
            'End Try
            'Return bResultado
        End Sub
        Public Function Eliminar_LiquServGuiaRemisionLiqTransp_Refactura(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_SERVICIO_LIQTRANSP_REFACTURA", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Agregar_GRemServCargadasGTranspLiq(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CSRVC", objEntidad.pCSRVC_Servicio)

                objParam.Add("IN_TRFSRG", objEntidad.pTRFSRG_RefrenciaServicioGuia)
                objParam.Add("IN_CMNDGU", objEntidad.pCMNDGU_MonedaGuia)
                objParam.Add("IN_ISRVGU", objEntidad.pISRVGU_importeServicio)
                objParam.Add("IN_QCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
                objParam.Add("IN_CUNDSR", objEntidad.pCUNDSR_Unidad)
                objParam.Add("IN_SFCTTR", objEntidad.pSFCTTR_StatusFacturado)

                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        Public Function Agregar_GRemServCargadasGTranspLiq_ReFactura(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CSRVC", objEntidad.pCSRVC_Servicio)

                'objParam.Add("IN_TRFSRG", objEntidad.pTRFSRG_RefrenciaServicioGuia)
                objParam.Add("IN_CMNDGU", objEntidad.pCMNDGU_MonedaGuia)
                objParam.Add("IN_ISRVGU", objEntidad.pISRVGU_importeServicio)
                objParam.Add("IN_QCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
                objParam.Add("IN_CUNDSR", objEntidad.pCUNDSR_Unidad)
                ' objParam.Add("IN_SFCTTR", objEntidad.pSFCTTR_StatusFacturado)

                ' objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                'objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIO_LIQTRANSP_REFACTURA", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Obtener_Guia_Remision(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As TD_Obj_InfGRemCargada
            Dim objDataSet As New DataSet
            'Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of TD_Obj_InfGRemCargada)
            Dim obj_Entidad As New TD_Obj_InfGRemCargada
            Dim strGuiaReferencia As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_OBTENER_GREMISION_SERV_CARGADA", objParam)
            For Each objData As DataRow In objDataSet.Tables(1).Rows
                strGuiaReferencia = strGuiaReferencia + objData("NGUIRF").ToString.Trim + ","
            Next
            If strGuiaReferencia.Trim.Length > 0 Then strGuiaReferencia = strGuiaReferencia.Trim.Substring(0, strGuiaReferencia.Length - 1)
            For Each objData As DataRow In objDataSet.Tables(0).Rows
                'obj_Entidad = New TD_Obj_InfGRemCargada
                obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                obj_Entidad.pFSLDCM_FechaSalidaCamion = objData("FSLDCM")
                obj_Entidad.pCPRCN1_CodigoPropietarioContenedor1 = objData("CPRCN1")
                obj_Entidad.pNSRCN1_SerieContenedor1 = objData("NSRCN1")
                obj_Entidad.pCPRCN2_CodigoPropietarioContenedor2 = objData("CPRCN2")
                obj_Entidad.pNSRCN2_SerieContenedor2 = objData("NSRCN2")
                obj_Entidad.pQGLGSL_CantidadGlsGasolina = objData("QGLGSL")
                obj_Entidad.pQGLDSL_CantidadGlsDiesel = objData("QGLDSL")
                obj_Entidad.pNRHJCR_NroHojasCargui = objData("NRHJCR")
                obj_Entidad.pQKLMRC_KilometrosRecorridos = objData("QKLMRC")
                obj_Entidad.pQBLRMS_CantidadBultosRemision = objData("QBLRMS")
                obj_Entidad.pQBLRCP_CantidadBultosRecepcion = objData("QBLRCP")
                obj_Entidad.pPBRTOR_PesoBrutoRemision = objData("PBRTOR")
                obj_Entidad.pPBRDST_PesoBrutoRecepcion = objData("PBRDST")
                obj_Entidad.pPTRAOR_PesoTaraRemision = objData("PTRAOR")
                obj_Entidad.pPTRDST_PesoTaraRecepcion = objData("PTRDST")
                obj_Entidad.pQVLMOR_VolumenRemision = objData("QVLMOR")
                obj_Entidad.pQVLMDS_VolumenRecepcion = objData("QVLMDS")
                obj_Entidad.pQHRSRV_CantidadHorasServicio = objData("QHRSRV")
                obj_Entidad.pRELGUI_RelacionGuiaHijas = strGuiaReferencia

                obj_Entidad.pCTRMNC_CodigoTransportista = objData("CTRSPT")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
                obj_Entidad.pCCLNT1_CodigoCliente = objData("CCLNT1")
                obj_Entidad.pCLCLOR_CodigoLocalidadOrigen = objData("CLCLOR")
                obj_Entidad.pTCMLCO_LocalidadOrigen = objData("TCMLCO")
                obj_Entidad.pCLCLDS_CodigoLocalidadDestino = objData("CLCLDS")
                obj_Entidad.pTCMLCD_LocalidadDestino = objData("TCMLCD")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = objData("TCMTRT")
                obj_Entidad.pNPLVHT_Tracto = objData("NPLVHT")
                obj_Entidad.pCBRCNT_Brevete = objData("CBRCNT")
                obj_Entidad.pCMRCDR_Mercaderia = objData("CMRCDR")
                obj_Entidad.pTAMRCD_DetalleMercaderia = objData("TCMRCD").ToString

                obj_Entidad.pCRGVTA = objData("CRGVTA").ToString 'ECM-HUNDRED-20150821

                If IsDBNull(objData("FLLGCM")) = True Then
                    obj_Entidad.pFLLGCM_FechaLlegadaCamion = New Date
                Else
                    obj_Entidad.pFLLGCM_FechaLlegadaCamion = objData("FLLGCM")
                End If
                obj_Entidad.pNOREMB_OrdenEmbarcador = objData("NOREMB")
                obj_Entidad.pSSINVJ_FlagSiniestroViaje = objData("SSINVJ")
                'objGenericCollection.Add(obj_Entidad)


                'Codigo agregado por MREATEGUIP - Ajuste Moneda
                '----- Ini -----
                If Not objData("MONEDA_OS") Is DBNull.Value Then
                    obj_Entidad.pMONEDA_OS = objData("MONEDA_OS")
                End If

                If Not objData("BLQ_MONEDA") Is DBNull.Value Then
                    obj_Entidad.pBLQ_MONEDA = objData("BLQ_MONEDA")
                End If
                '----- Fin -----

            Next
            'Catch : End Try
            Return obj_Entidad
        End Function



        Public Function Get_Guia_Remision(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As TD_Obj_InfGRemCargada
            Dim objDataSet As New DataSet

            Dim obj_Entidad As New TD_Obj_InfGRemCargada
            Dim strGuiaReferencia As String = ""
            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_GET_GREMISION_SERV_CARGADA", objParam)
            For Each objData As DataRow In objDataSet.Tables(1).Rows
                strGuiaReferencia = strGuiaReferencia + objData("NGUIRF").ToString.Trim + ","
            Next
            If strGuiaReferencia.Trim.Length > 0 Then strGuiaReferencia = strGuiaReferencia.Trim.Substring(0, strGuiaReferencia.Length - 1)
            For Each objData As DataRow In objDataSet.Tables(0).Rows




                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                obj_Entidad.pNGUITR_GuiaRemisionCargadaTXT = objData("NGUIRS")

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")

                obj_Entidad.pFGUITR_FechaGuiaRemision = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(objData("FGUITR"))
                obj_Entidad.pFSLDCM_FechaSalidaCamion = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(objData("FSLDCM"))
                obj_Entidad.pCPRCN1_CodigoPropietarioContenedor1 = objData("CPRCN1")
                obj_Entidad.pNSRCN1_SerieContenedor1 = objData("NSRCN1")
                obj_Entidad.pCPRCN2_CodigoPropietarioContenedor2 = objData("CPRCN2")
                obj_Entidad.pNSRCN2_SerieContenedor2 = objData("NSRCN2")
                obj_Entidad.pQGLGSL_CantidadGlsGasolina = objData("QGLGSL")
                obj_Entidad.pQGLDSL_CantidadGlsDiesel = objData("QGLDSL")
                obj_Entidad.pNRHJCR_NroHojasCargui = objData("NRHJCR")
                obj_Entidad.pQKLMRC_KilometrosRecorridos = objData("QKLMRC")
                obj_Entidad.pQBLRMS_CantidadBultosRemision = objData("QBLRMS")
                obj_Entidad.pQBLRCP_CantidadBultosRecepcion = objData("QBLRCP")
                obj_Entidad.pPBRTOR_PesoBrutoRemision = objData("PBRTOR")
                obj_Entidad.pPBRDST_PesoBrutoRecepcion = objData("PBRDST")
                obj_Entidad.pPTRAOR_PesoTaraRemision = objData("PTRAOR")
                obj_Entidad.pPTRDST_PesoTaraRecepcion = objData("PTRDST")
                obj_Entidad.pQVLMOR_VolumenRemision = objData("QVLMOR")
                obj_Entidad.pQVLMDS_VolumenRecepcion = objData("QVLMDS")
                obj_Entidad.pQHRSRV_CantidadHorasServicio = objData("QHRSRV")
                obj_Entidad.pRELGUI_RelacionGuiaHijas = strGuiaReferencia

                obj_Entidad.pCTRMNC_CodigoTransportista = objData("CTRSPT")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
                obj_Entidad.pNGUITS_NroGuiaTransportistaTXT = objData("NGUITS")



                obj_Entidad.pCCLNT1_CodigoCliente = objData("CCLNT1")
                obj_Entidad.pCLCLOR_CodigoLocalidadOrigen = objData("CLCLOR")
                obj_Entidad.pTCMLCO_LocalidadOrigen = objData("TCMLCO")
                obj_Entidad.pCLCLDS_CodigoLocalidadDestino = objData("CLCLDS")
                obj_Entidad.pTCMLCD_LocalidadDestino = objData("TCMLCD")
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = objData("TCMTRT")
                obj_Entidad.pNPLVHT_Tracto = objData("NPLVHT")
                obj_Entidad.pCBRCNT_Brevete = objData("CBRCNT")
                obj_Entidad.pCMRCDR_Mercaderia = objData("CMRCDR")
                obj_Entidad.pTAMRCD_DetalleMercaderia = objData("TCMRCD").ToString

                obj_Entidad.pCRGVTA = objData("CRGVTA").ToString 'ECM-HUNDRED-20150821
                obj_Entidad.pNRUCTR_Transportista = objData("NRUCTR").ToString



                'If IsDBNull(objData("FLLGCM")) = True Then
                '    obj_Entidad.pFLLGCM_FechaLlegadaCamion = New Date
                'Else
                '    obj_Entidad.pFLLGCM_FechaLlegadaCamion = objData("FLLGCM")
                'End If

                If IsDBNull(objData("FLLGCM")) = True Or ("" & objData("FLLGCM")) = "0" Then
                    obj_Entidad.pFLLGCM_FechaLlegadaCamion = New Date
                Else
                    obj_Entidad.pFLLGCM_FechaLlegadaCamion = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(objData("FLLGCM"))
                End If


                obj_Entidad.pNOREMB_OrdenEmbarcador = objData("NOREMB")
                obj_Entidad.pSSINVJ_FlagSiniestroViaje = objData("SSINVJ")
                '----- Ini -----
                If Not objData("MONEDA_OS") Is DBNull.Value Then
                    obj_Entidad.pMONEDA_OS = objData("MONEDA_OS")
                End If

                'If Not objData("BLQ_MONEDA") Is DBNull.Value Then
                '    obj_Entidad.pBLQ_MONEDA = objData("BLQ_MONEDA")
                'End If
                obj_Entidad.SESGRP = objData("SESGRP")
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.SGUIFC = objData("SGUIFC")
                obj_Entidad.FLGSTA = objData("FLGSTA")

                '----- Fin -----

            Next

            Return obj_Entidad
        End Function


        Public Function Modificar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
                objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
                objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
                objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
                objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
                objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
                objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
                objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
                objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
                objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
                objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
                objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
                objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
                objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
                objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
                objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
                objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
                objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
                objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
                objParam.Add("IN_SSINVJ", objEntidad.pSSINVJ_FlagSiniestroViaje)
                objParam.Add("IN_FULTAC", Format(Now, "yyyyMMdd"))
                objParam.Add("IN_HULTAC", Format(Now, "HHmmss"))
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_MODIFICAR_GUIA_TRANSPORTISTA_PARA_LIQ", objParam)
                bResultado = True
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        '____ACD____

        Public Function Listar_Consistencia_Liquidacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Dim strServicio As String = ""
            'Try
            objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            objParam.Add("PNNGUIRM", objParametro("PSNGUIRM"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objParam.Add("PNFECACT", objParametro("PNFECHA"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            Dim dt As New DataTable
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_ORDEN_SERVICIOS", objParam)


            For Each objDataRow As DataRow In dt.Rows
                objEntidad = New Factura_Transporte

                objEntidad.NMNFCR = objDataRow("NMNFCR")
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                'objEntidad.NRUCTR = Val(objDataRow("NRUCTR"))
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                'OJO CSRVC
                objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim 'IIf(objDataRow("TCMTRF").ToString.Trim = "FLETE", "1 " & objDataRow("TCMTRF").ToString.Trim, objDataRow("TCMTRF").ToString.Trim)

                objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                objEntidad.SFCTTR = objDataRow("SFCTTR")
                objEntidad.SLQDTR = objDataRow("SLQDTR")

                objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                objEntidad.PESOL = objDataRow("PESOL") / 1000
                objEntidad.QCNDLG = objDataRow("QCNDLG")
                objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                objEntidad.CSTNDT = objDataRow("CSTNDT")  'ACD... IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                objEntidad.QMRCDR = objDataRow("QMRCDR")
                objEntidad.TCMCRA = objDataRow("TCMCRA")
                objEntidad.NRUCTR_LIQ = ("" & objDataRow("NRUCTR_LIQ")).ToString.Trim
                objEntidad.TCMTRT_LIQ = ("" & objDataRow("TCMTRT_LIQ")).ToString.Trim

                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of Factura_Transporte)()
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Reparto(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNNMOPRP", objParametro("PNNMOPRP"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objParam.Add("PNFECACT", objParametro("PNFECHA"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_REPARTO", objParam).Rows
                objEntidad = New Factura_Transporte

                objEntidad.NMNFCR = objDataRow("NMNFCR")
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                'ojo
                objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim

                objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                objEntidad.SFCTTR = objDataRow("SFCTTR")
                objEntidad.SLQDTR = objDataRow("SLQDTR")

                objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                objEntidad.PESOL = objDataRow("PESOL") / 1000
                objEntidad.QCNDLG = objDataRow("QCNDLG")
                objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                objEntidad.CSTNDT = objDataRow("CSTNDT") 'IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                objEntidad.QMRCDR = objDataRow("QMRCDR")
                objEntidad.TCMCRA = objDataRow("TCMCRA")
                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of Factura_Transporte)()
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Multimodal(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNNMOPMM", objParametro("PNNMOPMM"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objParam.Add("PNFECACT", objParametro("PNFECHA"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_MULTIMODAL", objParam).Rows
                objEntidad = New Factura_Transporte

                objEntidad.NMNFCR = objDataRow("NMNFCR")
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                'ojo
                objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim

                objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                objEntidad.SFCTTR = objDataRow("SFCTTR")
                objEntidad.SLQDTR = objDataRow("SLQDTR")
                objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                objEntidad.PESOL = objDataRow("PESOL") / 1000
                objEntidad.QCNDLG = objDataRow("QCNDLG")
                objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                objEntidad.CSTNDT = objDataRow("CSTNDT") ' IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                objEntidad.QMRCDR = objDataRow("QMRCDR")
                objEntidad.TCMCRA = objDataRow("TCMCRA")
                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of Factura_Transporte)()
            'End Try
            Return objGenericCollection
        End Function
        '____FIN ACD____

        Public Function Existe_Guia_Remision_Anexo_Guia_Cliente(ByVal objParametro As Hashtable) As Int32
            Dim retorno As Int32 = 0
            Dim objParam As New Parameter
            Dim odt As New DataTable
            Try
                objParam.Add("PARAM_CTRMNC", objParametro("PNCTRMNC"))
                objParam.Add("PARAM_NGUIRM", objParametro("PNNGUIRM"))
                objParam.Add("PARAM_NRGUCL", objParametro("PNNRGUCL"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                odt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_GUIA_DE_REMISION_ANEXO_GUIAS_CLIENTE", objParam)
                If (odt.Rows.Count > 0) Then
                    retorno = 1
                Else
                    retorno = 0
                End If
            Catch ex As Exception
                retorno = 0
            End Try
            Return retorno
        End Function

        Public Function Listar_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNCTRSPT", objParametro("PNCTRSPT"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objParam.Add("PNFECINI", objParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objParametro("PNFECFIN"))

            objParam.Add("PSSESTRG", objParametro("PSSESTRG"))

            objParam.Add("PNNRFSAP_INI", objParametro("PNNRFSAP_INI"))
            objParam.Add("PNNRFSAP_FIN", objParametro("PNNRFSAP_FIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            'SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIO_SAP

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIO_SAP", objParam)



            'Select Case objParametro("ESTADO")
            '    Case 0
            '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_NORMAL_LA", objParam)
            '    Case 1
            '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIADO_LA", objParam)
            '    Case 2
            '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ANULADO_LA", objParam)
            'End Select

            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New LiquidacionOperacion
                objEntidad.NLQDCN = objDataRow("NLQDCN")
                'objEntidad.FLQDCN_S = HelpClass.CFecha_de_8_a_10(objDataRow("FLQDCN").ToString.Trim)
                objEntidad.FLQDCN_S = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                objEntidad.FLQDCN_FORMAT = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                objEntidad.NRFSAP = objDataRow("NRFSAP")
                objEntidad.TSTERS = objDataRow("TSTERS").ToString.Trim
                objEntidad.FSTTRS = objDataRow("FSTTRS").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NUMOPG = objDataRow("NUMOPG")
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.ITCCTC = objDataRow("ITCCTC")
                objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objDataRow("CPLNDV")

                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of LiquidacionOperacion)
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_x_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
            Dim objEntidad As ClaseGeneral
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_X_LIQUIDACION_FLETE_LA", objParam).Rows
                objEntidad = New ClaseGeneral
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                'objEntidad.FECINI = HelpClass.CFecha_de_8_a_10(objDataRow("FINCOP").ToString.Trim)
                objEntidad.FECINI = HelpClass.FechaNum_a_Fecha(objDataRow("FINCOP"))
                objEntidad.NPLNMT = objDataRow("NPLNMT")
                objEntidad.NORINS = objDataRow("NORINS")
                objEntidad.NGUITR = objDataRow("NMNFCR")
                objEntidad.NGUIRM = objDataRow("NGUITR")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.RUTA = objDataRow("ORIGEN").ToString.Trim & " <-> " & objDataRow("DESTINO").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLCUN = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objEntidad.CBRCND = objDataRow("TNMCMC").ToString.Trim & ", " & objDataRow("APEPAT").ToString.Trim & " " & objDataRow("APEMAT").ToString.Trim
                objEntidad.SESPLN = objDataRow("SESTOP").ToString.Trim
                objEntidad.IMPSOL = objDataRow("IMPORTE")
                objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objDataRow("CPLNDV")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                'objEntidad.CCNTCS = objDataRow("CCNCST").ToString.Trim
                'objEntidad.CCNCS1 = objDataRow("CCNCS1").ToString.Trim

                objEntidad.NRFSAP = objDataRow("NRFSAP").ToString.Trim
                objEntidad.NENMRS = objDataRow("NENMRS").ToString.Trim

                objEntidad.CODMTR = objDataRow("CODMTR").ToString.Trim
                objEntidad.NCCSAP = objDataRow("NCCSAP").ToString.Trim
                objEntidad.TSTERS = objDataRow("TSTERS").ToString.Trim


 

                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of ClaseGeneral)
            'End Try
            Return objGenericCollection
        End Function

        Public Function Liquidacion_Flete_Enviar_SAP(ByVal objParametro As Hashtable) As Int64
            Dim objParam As New Parameter
            Dim lintResultado As Int64 = 0
            Try
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN").ToString.PadLeft(10, "0"))
                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP012C", objParam)
                objParam = New Parameter
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNRESULT", 0, ParameterDirection.Output)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_LIQUIDACION_FLETE_ENVIAR_SAP", objParam)
                lintResultado = objSql.ParameterCollection("PNRESULT")
            Catch ex As Exception
                lintResultado = 0
            End Try
            Return lintResultado
        End Function

        Public Function Verificar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int32 = 0

            Try
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PNRESULT", 0, ParameterDirection.Output)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_LIQUIDACION_FLETE_SAP", objParam)
                lintResult = Val("" & objSql.ParameterCollection("PNRESULT"))
            Catch ex As Exception
                lintResult = -1
            End Try
            Return lintResult
        End Function


        Public Function Lista_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_SAP", objParam).Rows
                objEntidad = New LiquidacionOperacion
                objEntidad.NCRRRT = objDataRow("NCRRLT")
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.CSRVC = objDataRow("CSRVC")
                objEntidad.TABTRF = objDataRow("TABTRF").ToString.Trim
                objEntidad.NORINS = objDataRow("NORINS")
                objEntidad.NRFSAP = objDataRow("NRFSAP")
                objEntidad.NENMRS = objDataRow("NENMRS")
                objEntidad.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.FCHCRT_S = objDataRow("FCHCRT_S").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.QCNDLG = objDataRow("QCNDLG")
                objEntidad.ILQDTR_TOT = objDataRow("ILQDTR_TOT")
                objEntidad.FechaActual = objDataRow("FECHA_ACTUAL")
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '    objGenericCollection = New List(Of LiquidacionOperacion)()
            'End Try
            Return objGenericCollection
        End Function

        Public Function Anular_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As String
            Dim objParam As New Parameter
            Dim lintResultado As String = ""
            'Try

            objParam.Add("PARAM_NRFSAP", objParametro("NRFSAP").ToString.PadLeft(10, "0"))
            objParam.Add("PARAM_NCRROP", objParametro("NCRROP").ToString.PadLeft(4, "0"))
            objParam.Add("PARAM_FCHANU", objParametro("FCHANU").ToString.PadLeft(8, "0"))
            'objParam.Add("PARAM_FSTTRS", objParametro("FSTTRS").ToString.PadLeft(1, " "), ParameterDirection.Output)
            objParam.Add("PARAM_STERSP", objParametro("STERSP").ToString.PadLeft(1, " "), ParameterDirection.Output)


            objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP12AC", objParam)
            lintResultado = objSql.ParameterCollection("PARAM_STERSP").ToString.Trim

            'Catch ex As Exception
            '    lintResultado = ""
            '    error_ejecucion = ex.Message
            'End Try
            Return lintResultado
        End Function

        Public Sub Eliminar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter
            Dim lintResultado As Int32 = 0
            'Try

            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PNNRFSAP", objParametro("PNNRFSAP"))
            objParam.Add("PNNCRRLT", objParametro("PNNCRRLT"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_FLETE_SAP", objParam)
            'lintResultado = 1
            'Catch ex As Exception
            '    lintResultado = 0
            'End Try
            'Return lintResultado
        End Sub

        Public Function Actualizar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Hashtable
            Dim objParam As New Parameter
            Dim hasResultado As New Hashtable
            Try

                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))
                objParam.Add("PNRESULT", 0, ParameterDirection.Output)
                objParam.Add("PSRESULT", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_LIQUIDACION_FLETE_SAP", objParam)
                hasResultado.Add("INTRESULT", objSql.ParameterCollection("PNRESULT"))
                hasResultado.Add("STRRESULT", objSql.ParameterCollection("PSRESULT"))
            Catch ex As Exception
                hasResultado.Add("INTRESULT", 0)
                hasResultado.Add("STRRESULT", "")
            End Try
            Return hasResultado
        End Function

        Public Function Anular_Liquidacion_Flete_Propio(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim intResultado As Int32 = 0
            Try
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCULUSA", objParametro("PSMMCUSR"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_FLETE_PROPIO", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

        '------------ACD
        Public Function Lista_Bultos_x_Dia(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objParametro("CCLNT"))
            objParam.Add("PSNGRPRV", objParametro("NGRPRV"))
            objParam.Add("PSCREFFW", objParametro("CREFFW"))
            objParam.Add("PNFECINI", objParametro("FECINI"))
            objParam.Add("PNFECFIN", objParametro("FECFIN"))
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objParam.Add("PNCPLNDV", objParametro("CPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_BULTO_1", objParam)
            Return objDataTable
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        Public Function Auditoria(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Dim objParam As New Parameter
            Dim oDt As DataTable
            'Try
            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AUDITORIA_GUIA_TRANSPORTISTA", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New GuiaTransportista()
                objEntidad.USRCRT = objData.Item("CUSCRT")
                objEntidad.FCHCRT_S = objData.Item("FCHCRT")
                objEntidad.HRACRT_S = objData.Item("HRACRT")
                objEntidad.NTRMCR = objData.Item("NTRMCR")
                objEntidad.FULTAC_S = objData.Item("FULTAC")
                objEntidad.HULTAC_S = objData.Item("HULTAC")
                objEntidad.CULUSA = objData.Item("CULUSA")
                objEntidad.NTRMNL = objData.Item("NTRMNL")
            Next
            'Catch ex As Exception
            '    Return objEntidad
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_Consistencia_Bulto_x_Operacion(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of Multimodal)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCTRMNC", objEntidad.CTRSPT)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CONSISTENCIA_BULTO_X_OPERACION", objParam)
            'Catch
            '    objDataTable = New DataTable
            'End Try

            Return objDataTable
        End Function

        Public Function Lista_Guia_Salida_Zona_GR(ByVal objEntidad As GuiaTransportista) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNNGUIRM", objEntidad.NRGUCL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_SALIDA_ZONA_GR", objParam)
            Return objDataTable
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        Public Function Lista_Movimiento_Bulto_Zona_GP(ByVal objEntidad As GuiaTransportista) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSNGRPRV", objEntidad.TOBS)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_BULTO_ZONA_GP", objParam)
            Return objDataTable
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        Public Function Importar_Bulto_Guia_Remision(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNCCLNT_GT", objEntidad.CCLNT)
                objParam.Add("PNCCLNT_GR", objEntidad.NRHJCR)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
                objParam.Add("PNNRGUSA", objEntidad.NRGUSA)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_MIGRAR_BULTO_X_GUIA_REMISION", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Guia_Remision_Actualizacion(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUI_REMISION_CARGO_PLAN", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Actualizar_Datos_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int16
            Dim objParam As New Parameter
            Dim intResultado As Int16 = 0
            Try
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
                objParam.Add("PNNLQDCN", objParametro("NLQDCN"))
                objParam.Add("PNFECACT", objParametro("FECACT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_DATOS_LIQUIDACION_SAP", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

        Public Function Listar_Pasajeros_x_Programacion(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Viaje_Ruta)
            Dim obj_Entidad As Viaje_Ruta
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNNPRGVJ", objEntidad("NPRGVJ"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PNCLCLOR", objEntidad("CLCLOR"))
            objParam.Add("PNCLCLDS", objEntidad("CLCLDS"))
            objParam.Add("PNCMEDTR", objEntidad("CMEDTR"))
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PASAJEROS_PROGRAMACION", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New Viaje_Ruta
                obj_Entidad.PNNPRGVJ = objData("NPRGVJ")
                obj_Entidad.RUTA = objData("RUTA").ToString.Trim
                obj_Entidad.PSFSLDRT = objData("FSLDRT").ToString.Trim
                obj_Entidad.PSHSLDRT = objData("HSLDRT").ToString.Trim
                obj_Entidad.PSNMBPER = objData("NMBPER").ToString.Trim
                obj_Entidad.PNNCRRRT = objData("NCRRRT")
                obj_Entidad.PNNCRRIN = objData("NCRRIN")
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Pasajeros_Guia_Transporte(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Viaje_Ruta)
            Dim obj_Entidad As Viaje_Ruta
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objEntidad("CTRMNC"))
            objParam.Add("PNNGUITR", objEntidad("NGUITR"))
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PASAJEROS_GUIA_TRANSPORTE", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New Viaje_Ruta
                obj_Entidad.PNNPRGVJ = objData("NPRGVJ")
                obj_Entidad.RUTA = objData("RUTA").ToString.Trim
                obj_Entidad.PSFSLDRT = objData("FSLDRT").ToString.Trim
                obj_Entidad.PSHSLDRT = objData("HSLDRT").ToString.Trim
                obj_Entidad.PSNMBPER = objData("NMBPER").ToString.Trim
                obj_Entidad.PNNGUITR = objData("NGUITR")
                obj_Entidad.PNNCRRRT = objData("NCRRRT")
                obj_Entidad.PNNCRRIN = objData("NCRRIN")
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Registrar_Pasajero_Automatico(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPRGVJ", objEntidad.PNNPRGVJ)
                objParam.Add("PNNCRRRT", objEntidad.PNNCRRRT)
                objParam.Add("PNNCRRIN", objEntidad.PNNCRRIN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNFULTAC", objEntidad.PNFULTAC)
                objParam.Add("PNHULTAC", objEntidad.PNHULTAC)
                objParam.Add("PSCULUSA", objEntidad.PSCULUSA)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_PASAJERO_GUIA_TRANSPORTE", objParam)

            Catch ex As Exception
                objEntidad.PNNPRGVJ = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Pasajero_Guia_Transporte(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNPRGVJ", objEntidad.PNNPRGVJ)
                objParam.Add("PNNCRRRT", objEntidad.PNNCRRRT)
                objParam.Add("PNNCRRIN", objEntidad.PNNCRRIN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNFULTAC", objEntidad.PNFULTAC)
                objParam.Add("PNHULTAC", objEntidad.PNHULTAC)
                objParam.Add("PSCULUSA", objEntidad.PSCULUSA)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_PASAJERO_GUIA_TRANSPORTE", objParam)

            Catch ex As Exception
                objEntidad.PNNPRGVJ = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Guia_Transportista_Mercaderia(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista


            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))

            objParam.Add("PSCPLNDV", objetoParametro("PSCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSFSTENV", objetoParametro("PSFSTENV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_MERCADERIA_LA_v2", objParam)



            For Each objData As DataRow In objDataTable.Rows
                objEntidad = New GuiaTransportista

                objEntidad.CHECK = True
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.NGUIRM = objData("NGUIRM")

                objEntidad.NGUITS = objData("NGUITS")


                objEntidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData("FGUIRM").ToString.Trim)
                objEntidad.NPLNMT = objData("NPLNMT")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                objEntidad.QMRCMC = objData("QMRCMC")
                objEntidad.PMRCMC = objData("PMRCMC")
                objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                objEntidad.QGLGSL = objData("QGLGSL")
                objEntidad.QGLDSL = objData("QGLDSL")
                objEntidad.NRHJCR = objData("NRHJCR")
                objEntidad.CTRSPT = objData("CTRSPT")
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                objEntidad.NRUCRM = objData("NRUCRM")
                objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                objEntidad.NRUCCN = objData("NRUCCN")
                objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                objEntidad.CMNFLT = objData("CMNFLT")
                objEntidad.SESTRG = objData("SESTRG").ToString.Trim
                objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                objEntidad.QKMREC = objData("QKMREC")
                'objEntidad.ICSTRM = objData("ICSTRM")
                objEntidad.QPSOBR = objData("QPSOBR")
                objEntidad.QVLMOR = objData("QVLMOR")
                objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                'objEntidad.IVLPRT = objData("IVLPRT")
                objEntidad.CMNVLP = objData("CMNVLP")
                objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData("CPLNDV")
                objEntidad.CUBORI = objData("CUBORI")
                objEntidad.CUBDES = objData("CUBDES")
                objEntidad.FEMVLH = objData("FEMVLH")

                objEntidad.FEMVLH_S = HelpClass.FechaNum_a_Fecha(objData("FEMVLH_S"))
                objEntidad.FCHFTR_S = HelpClass.FechaNum_a_Fecha(objData("FCHFTR_S"))
                objEntidad.FECETA_S = HelpClass.FechaNum_a_Fecha(objData("FECETA_S"))
                objEntidad.FECETD_S = HelpClass.FechaNum_a_Fecha(objData("FECETD_S"))
                objEntidad.RUTA = objData("RUTA").ToString.Trim
                objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                objEntidad.TOBS = objData("TOBS").ToString.Trim
                'EN MODIFICACION
                objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

                objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                objEntidad.CMRCDR = objData("CMRCDR")
                objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
                objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                Select Case objData("CTPOVJ").ToString.Trim
                    Case "E"
                        objEntidad.CTPOV2 = "EXCLUSIVO"
                    Case "R"
                        objEntidad.CTPOV2 = "REPARTO"
                    Case "M"
                        objEntidad.CTPOV2 = "MULTIMODAL"
                    Case "C"
                        objEntidad.CTPOV2 = "CONSOLIDADO"
                End Select

                objEntidad.NMRGIM = objData("NMRGIM")

                objEntidad.NMOPMM = objData("NMOPMM")
                objEntidad.NMOPRP = objData("NMOPRP")
                objEntidad.NMVJCS = objData("NMVJCS")
                objEntidad.NRUCTR = objData("NRUCTR")

                Dim FSTENV As String = IIf(objData("FSTENV").Equals(DBNull.Value), "", objData("FSTENV"))
                Dim STATUS_DESC As String = IIf(objData("STATUS_DESC").Equals(DBNull.Value), "", objData("STATUS_DESC"))

                If STATUS_DESC.Trim = "" Then
                    objEntidad.STATUS_ENVIO = ""
                Else
                    objEntidad.STATUS_ENVIO = String.Format("{0}-{1}", FSTENV, STATUS_DESC)
                End If
                If Not String.IsNullOrEmpty(objData("USUENV").ToString.Trim) Then
                    objEntidad.USUARIO_ENVIO = String.Format("{0}-{1}-{2}", objData("USUENV"), objData("FCHENV"), objData("HRAENV"))
                Else
                    objEntidad.USUARIO_ENVIO = ""
                End If
                objEntidad.FSTENV = FSTENV
                objEntidad.CCLNT = objData("CCLNT")
                objEntidad.MSTENV = objData("MSTENV")
                objEntidad.MSTEN2 = objData("MSTEN2")

                objEntidad.RECURSO_REASIG = objData("RECURSO_REASIG")
                objEntidad.CMEDTR = objData("CMEDTR")
                'objEntidad.HRAINI = objData("HRAINI")
                'objEntidad.HRAFIN = objData("HRAFTR")


                'objEntidad.MONEDA_FLETE = objData("MONEDA_FLETE")
                'objEntidad.CUNDMD_DESC = objData("UNI_MED")
                objEntidad.PLANTA = objData("PLANTA")



                objGenericCollection.Add(objEntidad)
            Next

            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Transportista_Pasajero(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            'Try

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_PASAJERO", objParam)

            'Select Case objetoParametro("ESTADO")
            '  Case 0
            '    objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V2", objParam)
            '  Case 1
            '    objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V1", objParam)
            '  Case 2
            '    objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
            '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V3", objParam)
            '  Case 3
            '    objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
            '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V4", objParam)
            'End Select

            For Each objData As DataRow In objDataTable.Rows
                objEntidad = New GuiaTransportista

                objEntidad.CHECK = True
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.NGUIRM = objData("NGUIRM")
                objEntidad.FGUIRM_S = objData("FGUIRM")
                objEntidad.NPLNMT = objData("NPLNMT")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                objEntidad.QMRCMC = objData("QMRCMC")
                objEntidad.PMRCMC = objData("PMRCMC")
                objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                objEntidad.QGLGSL = objData("QGLGSL")
                objEntidad.QGLDSL = objData("QGLDSL")
                objEntidad.NRHJCR = objData("NRHJCR")
                objEntidad.CTRSPT = objData("CTRSPT")
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                objEntidad.NRUCRM = objData("NRUCRM")
                objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                objEntidad.NRUCCN = objData("NRUCCN")
                objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                objEntidad.CMNFLT = objData("CMNFLT")
                objEntidad.SESTRG = objData("SESTRG").ToString.Trim
                objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                objEntidad.QKMREC = objData("QKMREC")
                objEntidad.ICSTRM = objData("ICSTRM")
                objEntidad.QPSOBR = objData("QPSOBR")
                objEntidad.QVLMOR = objData("QVLMOR")
                objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                objEntidad.IVLPRT = objData("IVLPRT")
                objEntidad.CMNVLP = objData("CMNVLP")
                objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData("CPLNDV")
                objEntidad.CUBORI = objData("CUBORI")
                objEntidad.CUBDES = objData("CUBDES")
                objEntidad.FEMVLH = objData("FEMVLH")
                objEntidad.FEMVLH_S = objData("FEMVLH_S")
                objEntidad.FCHFTR_S = objData("FCHFTR_S")
                objEntidad.FECETA_S = objData("FECETA_S")
                objEntidad.FECETD_S = objData("FECETD_S")
                objEntidad.RUTA = objData("RUTA").ToString.Trim
                objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                objEntidad.TOBS = objData("TOBS").ToString.Trim
                'EN MODIFICACION
                objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

                objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                objEntidad.CMRCDR = objData("CMRCDR")
                objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
                objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                objEntidad.CMEDTR = objData("CMEDTR").ToString.Trim
                objEntidad.CCLNT = objData("CCLNT")

                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '    Dim s As String = ""
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_Liquidacion_Correo(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As DataTable
            Dim objParam As New Parameter
            'Try
            objDataTable = New DataTable
            objParam.Add("PNNLQDCN", objetoParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_LIQUIDACION_CORREO", objParam)
            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
        End Function

        Public Function Actualizar_Operaciones_Guia_Transporte(ByVal objetoParametro As Hashtable) As Int16

            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCTRSPT", objetoParametro("CTRSPT"))
            objParam.Add("PNNGUIRM", objetoParametro("NGUIRM"))
            objParam.Add("PNFGUIRM", objetoParametro("FGUIRM"))
            objParam.Add("PSNOPRCN", objetoParametro("NOPRCN"))
            objParam.Add("PSCCMPN", objetoParametro("CCMPN"))
            objParam.Add("PSCULUSA", objetoParametro("CULUSA"))
            objParam.Add("PNFULTAC", objetoParametro("FULTAC"))
            objParam.Add("PNHULTAC", objetoParametro("HULTAC"))
            objParam.Add("PSNTRMNL", objetoParametro("NTRMNL"))
            objParam.Add("PSSESTRG", objetoParametro("SESTRG"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_OPERACION_GUIA_TRANSPORTE", objParam)
            Return 1
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function

        Public Function Listar_Operaciones_Guia_Transporte(ByVal objetoParametro As Hashtable, ByRef intTipoViaje As Int16) As DataTable
            Dim objDataTable As DataTable
            Dim objParam As New Parameter
            Dim strTipoViaje As String = ""
            'Try
            objParam.Add("PNCTRSPT", objetoParametro("CTRMNC"))
            objParam.Add("PNNGUIRM", objetoParametro("NGUITR"))
            objParam.Add("PSTPOVJ", 0, ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACIONES_GUIA_TRANSPORTE", objParam)
            strTipoViaje = objSql.ParameterCollection("PSTPOVJ")
            intTipoViaje = IIf(strTipoViaje = "N", 0, 1)
            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
        End Function

        Public Function Validar_Operacion_Guia_Remision(ByVal objetoParametro As Hashtable, ByRef intCMRCDR As Integer, ByRef strTCMRCD As String) As Int16
            Dim objParam As New Parameter
            Dim intTipoViaje As Int16 = 0
            Try
                objParam.Add("PNNOPRCN", objetoParametro("NOPRCN"))
                objParam.Add("PNNGUIRM", objetoParametro("NGUIRM"))
                objParam.Add("PNCMRCDR", 0, ParameterDirection.Output)
                objParam.Add("PSTCMRCD", "", ParameterDirection.Output)
                objParam.Add("PNSTATUS", 0, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_OPERACION_GUIA_REMISION", objParam)
                intTipoViaje = objSql.ParameterCollection("PNSTATUS")
                intCMRCDR = objSql.ParameterCollection("PNCMRCDR")
                strTCMRCD = objSql.ParameterCollection("PSTCMRCD").ToString.Trim
            Catch ex As Exception
                intTipoViaje = 0
            End Try
            Return intTipoViaje
        End Function
        Public Function Actualizar_Guia_Numero_Imagen(ByVal objHash As Hashtable) As Boolean
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION
                objParam.Add("PNCTRMNC", objHash("PARAM_CTRMNC"))
                objParam.Add("PNNGUIRM", objHash("PARAM_NGUIRM"))
                objParam.Add("PNNMRGIM", objHash("PARAM_NMRGIM"))
                objParam.Add("PSCULUSA", objHash("PARAM_CULUSA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_GUIA_NUMERO_IMAGEN", objParam)

            Catch ex As Exception
                Return False

            End Try
            Return True
        End Function

        Public Function Eliminar_Correlativo_Imagen(ByVal objHash As Hashtable) As Boolean
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION                
                objParam.Add("PNNMRGIM", objHash("PARAM_NMRGIM"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CORRELATIVO_IMAGEN", objParam)

            Catch ex As Exception
                Return False

            End Try
            Return True
        End Function

        Public Function Lista_Guia_Transporte_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            'Try
            objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_CONSOLIDADO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objEntidad = New GuiaTransportista
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.NGUIRM = objData("NGUIRM")
                objEntidad.FGUIRM_S = Validacion.CFecha_a_Numero10Digitos(objData("FGUIRM"))
                objEntidad.NPLNMT = objData("NPLNMT")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.QMRCMC = objData("QMRCMC")
                objEntidad.PMRCMC = objData("PMRCMC")
                objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                objEntidad.QGLGSL = objData("QGLGSL")
                objEntidad.QGLDSL = objData("QGLDSL")
                objEntidad.NRHJCR = objData("NRHJCR")
                objEntidad.CTRSPT = objData("CTRMNC")
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                objEntidad.QKMREC = objData("QKMREC")
                objEntidad.QPSOBR = objData("QPSOBR")
                objEntidad.QVLMOR = objData("QVLMOR")
                objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData("CPLNDV")
                objEntidad.CCLNT = objData("CCLNT")
                objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim
                objEntidad.CMRCDR = objData("CMRCDR")
                objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim
                objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                objEntidad.SSINVJ = objData("SSINVJ").ToString.Trim
                objGenericCollection.Add(objEntidad)
            Next
            'Catch ex As Exception
            '    Dim s As String = ""
            'End Try
            Return objGenericCollection
        End Function
        '------PENDIENTE
        Public Function Listar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", objEntidad.CCMPN)
            objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_GUIA_TRANSPORTE_PARA_LIQ_CONSOLIDADO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM") 'objEntidad.pNGUIRM_NroGuiaTransportista
                obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                'obj_Entidad.pFGUITR_FechaGuiaRemision =  objData("FGUITR") 
                obj_Entidad.pFGUITR_FechaGuiaRemision = HelpClass.FechaNum_a_Fecha(objData("FGUITR"))
                obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim
                obj_Entidad.pPSOVOL_PesoVolumen = Format(objData("PSOVOL"), "###,###.00")
                obj_Entidad.pPMRCMC_PesoNeto = Format(objData("PMRCMC"), "###,###.00")
                obj_Entidad.pPBRTOR_PesoBruto = Format(objData("PBRTOR"), "###,###.00")
                'obj_Entidad.pNCRDCO = objData("NCRDCO")
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '    sErrorMessage = ex.ToString
            'End Try
            Return objGenericCollection
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal oFiltro As TransporteConsolidado, ByRef sErrorMensaje As String) As Boolean
            Dim bResultado As Boolean = True
            sErrorMensaje = ""
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", oFiltro.CCMPN)
            objParam.Add("IN_NMVJCS", oFiltro.NMVJCS)
            objParam.Add("IN_MMCUSR", oFiltro.CUSCTR)
            objParam.Add("IN_NTRMNL", oFiltro.NTRMNL)
            objParam.Add("OU_ERRMSG", "", ParameterDirection.InputOutput)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GREMISION_CARGADAS_PARA_LIQ_CONSOLIDADO", objParam)

            sErrorMensaje = ("" & objSql.ParameterCollection("OU_ERRMSG"))
            If sErrorMensaje <> "" Then bResultado = False
            'Catch ex As Exception
            '    bResultado = False
            'End Try
            Return bResultado
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Consolidado(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("IN_NMVJCS", objParametro("NMVJCS"))
            objParam.Add("IN_CCMPN", objParametro("CCMPN"))
            objParam.Add("IN_CDVSN", objParametro("CDVSN"))
            objParam.Add("IN_CPLNDV", objParametro("CPLNDV"))
            objParam.Add("IN_FECACT", objParametro("FECHA"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

            For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_CONSOLIDADO", objParam).Rows
                objEntidad = New Factura_Transporte

                objEntidad.NMNFCR = objDataRow("NMNFCR")
                objEntidad.NOPRCN = objDataRow("NOPRCN")
                objEntidad.NORSRT = objDataRow("NORSRT")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                objEntidad.CTRSPT = objDataRow("CTRSPT")
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                objEntidad.ISRVGU = objDataRow("ISRVGU")
                objEntidad.QCNDTG = objDataRow("QCNDTG")
                objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.VLRFDT = objDataRow("VLRFDT")
                'ojo
                objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim
                objEntidad.IVNTA = objDataRow("IVNTA")
                objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                objEntidad.CPRCN1 = objDataRow("CPRCN1")
                objEntidad.NSRCN1 = objDataRow("NSRCN1")
                objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                objEntidad.CPRCN2 = objDataRow("CPRCN2")
                objEntidad.NSRCN2 = objDataRow("NSRCN2")
                objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                objEntidad.CTIGVA = objDataRow("CTIGVA")
                objEntidad.PIGVA = objDataRow("PIGVA")
                objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                objEntidad.PESOL = objDataRow("PESOL") / 1000
                objEntidad.QCNDLG = objDataRow("QCNDLG")
                objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                objEntidad.CSTNDT = objDataRow("CSTNDT") 'IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                objEntidad.QMRCDR = objDataRow("QMRCDR")
                objEntidad.TCMCRA = objDataRow("TCMCRA")
                ' NUEVO
                '-------------------------------
                objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                '-------------------------------
                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of Factura_Transporte)()
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dtOperaciones As DataTable

            objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            dtOperaciones = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_SERV_IMPORTES", objParam)

            Return dtOperaciones
        End Function

        Public Function Actualizar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter

            objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
            objParam.Add("PNISRVGU", objParametro("ISRVGU"))
            objParam.Add("PNILQDTR", objParametro("ILQDTR"))
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_OPERACIONES_X_SERV_IMPORTES", objParam)

        End Function

        Public Function Eliminar_Guia_Transportista_Reparto(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PSSESTRG", objEntidad.SESTRG)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA_REPARTO", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Ruta_Optima_Reparto(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objGuiaTransportista As GuiaTransportista
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNMOPRP", objEntidad.NMOPRP)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RUTA_OPTIMA_X_OPERACION_REPARTO", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objGuiaTransportista = New GuiaTransportista
                objGuiaTransportista.NMOPRP = objData("NMOPRP")
                objGuiaTransportista.ITEMAN = objData("NMOPRP")
                objGuiaTransportista.CTRSPT = objData("CTRSPT")
                'objGuiaTransportista.NRHJCR = objData("NRHJCR")
                objGuiaTransportista.TDIROR = objData("TDIROR")
                objGuiaTransportista.TDIRDS = objData("TDIRDS")
                objGuiaTransportista.TCMRCD = objData("TCMRCD")
                objGuiaTransportista.QKMREC = objData("QKMREC")
                objGuiaTransportista.CBRCNT = objData("CBRCNT")
                objGuiaTransportista.CBRCND = objData("CBRCND")
                objGuiaTransportista.SESGRP = objData("SESGRP")
                objGuiaTransportista.CLCLOR = objData("CLCLOR")
                objGuiaTransportista.CLCLDS = objData("CLCLDS")
                objGuiaTransportista.NOPRCN = objData("NOPRCN")
                objGuiaTransportista.CMRCDR = objData("CMRCDR")
                objGenericCollection.Add(objGuiaTransportista)
            Next
            'Catch ex As Exception
            '    Dim s As String = ""
            'End Try
            Return objGenericCollection
        End Function

        Public Function Validar_GuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_FTRMOP", objEntidad.pFTRMOP_FechaOperacionFNum)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                objParam.Add("IN_TIPO", objEntidad.pTipo)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("IN_TIPO", objEntidad.TIPO)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_REPARTO", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Sub Validar_Generacion_Reparto_Asiento_TarifaInterna(ByVal compania As String, ByVal nroReparto As String, ByRef sErrorMesage As String)
            Try
                Dim objParam As New Parameter
                Dim dt As New DataTable

                objParam.Add("IN_NMOPRP", nroReparto)
                'objParam.Add("IN_MENSAJE", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

                'objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GENERACION_REPARTO_ASIENTO_CO_TARIFA_INTERNA", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("IN_MENSAJE")
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GENERACION_REPARTO_ASIENTO_CO_TARIFA_INTERNA_SALM", objParam)

                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next
                sErrorMesage = sErrorMesage.Trim
            Catch ex As Exception
                sErrorMesage = ex.Message
            End Try

        End Sub

        Public Function Procesar_Generacion_Reparto_Asiento_TarifaInterna(ByVal objEntidad As Repartos, ByRef msgTarifaInterna As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                Dim dtResult As New DataTable

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_FECHADOC", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
                objParam.Add("IN_FECHA_CONT", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                dtResult = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROCESAR_REPARTO_GENERACION_ASIENTO_CO_TARIFA_INTERNA", objParam)

                For Each row As DataRow In dtResult.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        msgTarifaInterna = msgTarifaInterna & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next

                msgTarifaInterna = msgTarifaInterna.Trim

                bResultado = True
            Catch ex As Exception
                msgTarifaInterna = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_Reparto_ProVarios(ByVal objEntidad As Repartos, ByRef sErrorMesage As String, ByRef sErrorAlerta As String, ByRef msgAlertaValorRefer As String) As Boolean
            Dim bResultado As Boolean = True
            'Dim slist() As String
            Dim msg As String = ""
            Dim dt As New DataTable
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                'objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("IN_TIPO", objEntidad.TIPO)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_REPARTO_PROV_VARIOS", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'sErrorMesage = sErrorMesage.Trim
                'If sErrorMesage.Length > 0 Then
                '    slist = sErrorMesage.Split("|")
                '    For Each Item As String In slist
                '        msg = msg & Chr(13) & Item
                '    Next
                '    msg = msg.Trim
                'End If
                'sErrorMesage = msg

                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_REPARTO_PROV_VARIOS_SALM", objParam)
                sErrorMesage = sErrorMesage.Trim
                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "E" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                    If row("STATUS").ToString.Trim = "A" Then
                        sErrorAlerta = sErrorAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If

                    If row("STATUS").ToString.Trim = "V" Then
                        msgAlertaValorRefer = msgAlertaValorRefer & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If

                Next
                sErrorMesage = sErrorMesage.Trim
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete(ByVal objEntidad As Repartos) As Int32
            Dim bResultado As Int32 = 0 'As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_REPARTO2", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                bResultado = 1
            End Try
            Return bResultado
        End Function


        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete_Prov_Varios(ByVal objEntidad As Repartos) As Int32
            Dim bResultado As Int32 = 0 'As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_REPARTO2_PROV_VARIOS", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String, ByRef sErrorMesageAlerta As String) As Boolean
            Dim bResultado As Boolean = True
            Dim dt As New DataTable
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("IN_TIPO", objEntidad.TIPO)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_CONSOLIDADO", objParam)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_CONSOLIDADO_SALM", objParam)
                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "E" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                    If row("STATUS").ToString.Trim = "A" Then
                        sErrorMesageAlerta = sErrorMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If

                Next
                sErrorMesage = sErrorMesage.Trim
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Sub Validar_Generacion_Consolidado_AsientoCO_TarifaInterna(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String)

            Try
                Dim objParam As New Parameter
                Dim dt As New DataTable()

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                'objParam.Add("IN_MENSAJE", "", ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GENERACION_CONSOLIDADO_ASIENTO_CO_TARIFA_INTERNA", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("IN_MENSAJE")
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GENERACION_CONSOLIDADO_ASIENTO_CO_TARIFA_INTERNA_SALM", objParam)
                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next
                sErrorMesage = sErrorMesage.Trim
            Catch ex As Exception
                sErrorMesage = ex.Message

            End Try

        End Sub

        Public Sub Procesar_Generacion_Consolidado_AsientoCO_TarifaInterna(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String)
            Try
                Dim objParam As New Parameter
                Dim dtResult As New DataTable

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_MMCUSR", Environment.UserName)
                objParam.Add("IN_NTRMNL", Environment.MachineName)
                objParam.Add("IN_FECHADOC", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
                objParam.Add("IN_FECHA_CONT", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                dtResult = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROCESAR_CONSOLIDADO_GENERACION_ASIENTO_CO_TARIFA_INTERNA", objParam)

                For Each row As DataRow In dtResult.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next

                sErrorMesage = sErrorMesage.Trim


            Catch ex As Exception
                sErrorMesage = ex.Message
            End Try
        End Sub

        Public Function Validar_CodMaterial_SAP_Alquiler(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Dim objParam As New Parameter
            Dim msgError As String = ""
            Dim dt As New DataTable
            Dim ValCodMat As Boolean = True
            Dim ValCodCuenta As Boolean = True
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            'objParam.Add("IN_NGUITR", objEntidad.pNGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CODIGO_MATERIAL_SAP_ALQUILER", objParam)
            For Each Item As DataRow In dt.Rows
                If Item("CODMTR") = 0 Then
                    ValCodMat = False
                End If
                If Item("NCCSAP") = 0 Then
                    ValCodCuenta = False
                End If
            Next
            If ValCodMat = False OrElse ValCodCuenta = False Then
                msgError = "Los servicios de la operación " & objEntidad.pNOPRCN_NroOperacion & " no tienen Cod. Material SAP o Cod. Contable SAP."
            End If
            msgError = msgError.Trim
            Return msgError
        End Function


        Public Function Validar_CodMaterial_SAP(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Dim objParam As New Parameter
            Dim msgError As String = ""
            Dim dt As New DataTable
            Dim ValCodMat As Boolean = True
            Dim ValCodCuenta As Boolean = True
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            'objParam.Add("IN_NGUITR", objEntidad.pNGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CODIGO_MATERIAL_SAP", objParam)
            For Each Item As DataRow In dt.Rows
                If Item("CODMTR") = 0 Then
                    ValCodMat = False
                End If
                If Item("NCCSAP") = 0 Then
                    ValCodCuenta = False
                End If
            Next
            If ValCodMat = False OrElse ValCodCuenta = False Then
                msgError = "Los servicios de la operaci�n " & objEntidad.pNOPRCN_NroOperacion & " no tienen Cod. Material SAP o Cod. Contable SAP."
            End If
            msgError = msgError.Trim
            Return msgError
        End Function

        Public Function Validar_CodMaterial_SAP_Prov_varios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Dim objParam As New Parameter
            Dim msgError As String = ""
            Dim dt As New DataTable
            Dim ValCodMat As Boolean = True
            Dim ValCodCuenta As Boolean = True
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            'objParam.Add("IN_NGUITR", objEntidad.pNGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CODIGO_MATERIAL_SAP_PROV_VARIOS", objParam)
            'For Each Item As DataRow In dt.Rows
            '    If Item("CODMTR") = 0 Then
            '        ValCodMat = False
            '    End If
            '    If Item("NCCSAP") = 0 Then
            '        ValCodCuenta = False
            '    End If
            'Next
            'If ValCodMat = False OrElse ValCodCuenta = False Then
            '    msgError = "Los servicios de la operación " & objEntidad.pNOPRCN_NroOperacion & " no tienen Cod. Material SAP o Cod. Contable SAP."
            'End If
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_CODIGO_MATERIAL_SAP_PROV_VARIOS_SALM", objParam)
            For Each row As DataRow In dt.Rows
                If row("STATUS").ToString.Trim = "N" Then
                    msgError = msgError & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            msgError = msgError.Trim
            Return msgError
        End Function
        Public Sub Validar_Asiento_CO_Tarifa_Interna(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String)

            'Dim slist() As String
            Dim msg As String = ""
            Dim dt As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                'objParam.Add("IN_MENSAJE", String.Empty, ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
                'objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_GENERACION_ASIENTO_CO_TARIFA_INTERNA", objParam)
                'sErrorMesage = objSql.ParameterCollection("IN_MENSAJE").ToString().Trim()

                'sErrorMesage = sErrorMesage.Trim
                'If sErrorMesage.Length > 0 Then
                '    slist = sErrorMesage.Split("/")
                '    For Each Item As String In slist
                '        msg = msg & Chr(13) & Item
                '    Next
                '    msg = msg.Trim
                'End If
                'sErrorMesage = msg
                sErrorMesage = sErrorMesage.Trim
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GENERACION_ASIENTO_CO_TARIFA_INTERNA_SALM", objParam)
                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next
                sErrorMesage = sErrorMesage.Trim
            Catch ex As Exception
                sErrorMesage = ex.Message
            End Try

        End Sub
        Public Function Procesar_Asiento_CO_Tarifa_Interna(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef msgTarifaInterna As String) As String
            Dim bResultado As Boolean = True
            Dim msg As String = ""
            Dim dtResult As New DataTable

            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                objParam.Add("IN_FECHADOC", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
                objParam.Add("IN_FECHA_CONT", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
                dtResult = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROCESAR_GENERACION_ASIENTO_CO_TARIFA_INTERNA", objParam)
                For Each row As DataRow In dtResult.Rows
                    If row("STATUS").ToString.Trim = "N" Then
                        msgTarifaInterna = msgTarifaInterna & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                Next
                msgTarifaInterna = msgTarifaInterna.Trim

                If msgTarifaInterna <> "" Then bResultado = False
            Catch ex As Exception
                msgTarifaInterna = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Listar_Liquidacion_Flete_SAP_info(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PNNRFSAP", objParametro("PNNRFSAP"))
            objParam.Add("PNNCRRLT", objParametro("PNNCRRLT"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_LIQUIDACION_FLETE_SAP_INFO", objParam)
            Return dt
        End Function

        Public Sub Actualizar_Liquidacion_Flete_SAP_info(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PNNRFSAP", objParametro("PNNRFSAP"))
            objParam.Add("PNNCRRLT", objParametro("PNNCRRLT"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_LIQUIDACION_FLETE_SAP_INFO", objParam)
        End Sub

        Public Function Registrar_LiquServGuiaRemisionLiqTranspAdi(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean

            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CMNLQT", objEntidad.pCMNLQT_Moneda)
                objParam.Add("IN_ILQDTR", objEntidad.pILQDTR_ImporteLiquidacionTransp)
                objParam.Add("IN_QCNDLG", objEntidad.pQCNDLG_CantidadServicioLiquidacion)
                objParam.Add("IN_CUNDTR", objEntidad.pCUNDTR_Unidad)
                objParam.Add("IN_SLQDTR", objEntidad.pSLQDTR_StatusLiquTransporte)
                objParam.Add("IN_NRUCTR", objEntidad.pNRUCTR_RucProveedor)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_SERVICIOS_LIQTRANSP", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Sub Agregar_GRemServProCargadasGTranspLiq(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef NCRRGU As Decimal)
            Dim bResultado As Boolean = True
            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
            objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
            objParam.Add("IN_CSRVC", objEntidad.pCSRVC_Servicio)

            objParam.Add("IN_NRUCTR", objEntidad.pNRUCTR_RucProveedor)
            objParam.Add("IN_CCMPN", objEntidad.pCCMPN_Compania)
            objParam.Add("IN_TRFSRG", objEntidad.pTRFSRG_RefrenciaServicioGuia)
            objParam.Add("IN_CMNDGU", objEntidad.pCMNDGU_MonedaGuia)
            objParam.Add("IN_ISRVGU", objEntidad.pISRVGU_importeServicio)
            objParam.Add("IN_QCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
            objParam.Add("IN_CUNDSR", objEntidad.pCUNDSR_Unidad)
            objParam.Add("IN_SFCTTR", objEntidad.pSFCTTR_StatusFacturado)

            objParam.Add("PSSFLGTI", objEntidad.pSSFLGTI_StatusLiquTransporteTI)
            objParam.Add("PNQCNDTI", objEntidad.pNQCNDTI_CantidadServicioLiquidacionTI)
            objParam.Add("PSCUNDTI", objEntidad.pCUNDTI_UnidadMedidaTI)
            objParam.Add("PNISRVTI", objEntidad.pNISRVTI_ImporteLiquidacionTranspTI)
            objParam.Add("PNCMNDTI", objEntidad.pNCMNDTI_MonedaTI)

            objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
            objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

            Dim dt As New DataTable
            'objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIOPROV_LIQTRANSP", objParam)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIOPROV_LIQTRANSP", objParam)
            If dt.Rows.Count > 0 Then
                NCRRGU = dt.Rows(0)("NCRRGU")
            End If

            'Catch ex As Exception
            '    sErrorMesage = ex.Message
            '    bResultado = False
            'End Try
            'Return bResultado
        End Sub

        ' IN IN_NRALQT NUMERIC(10, 0) ,
        'IN IN_TIPO NUMERIC(1, 0) ,
        'IN IN_MMCUSR VARCHAR(10) ,
        'IN IN_NTRMNL VARCHAR(10) ,
        'OUT OU_MSGERR VARCHAR(1000)

        Public Function Validar_GuiaTransportista_ProvVarios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String, ByRef sErrorMesageAlerta As String) As Boolean
            Dim bResultado As Boolean = True

            Dim dt As New DataTable
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                objParam.Add("IN_TIPO", objEntidad.pTipo)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)


                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_PROV_VARIOS_SALM", objParam)
                sErrorMesage = sErrorMesage.Trim
                For Each row As DataRow In dt.Rows
                    If row("STATUS").ToString.Trim = "E" Then
                        sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                    If row("STATUS").ToString.Trim = "A" Then
                        sErrorMesageAlerta = sErrorMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    End If
                    'If row("STATUS").ToString.Trim = "V" Then
                    '    msgAlertaValorRef = msgAlertaValorRef & row("OBSRESULT").ToString.Trim & Environment.NewLine
                    'End If
                Next
                sErrorMesage = sErrorMesage.Trim
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_ProvAlquiler(ByVal CCMPN As String, ByVal IN_NRALQT As Decimal, ByVal IN_TIPO As Decimal, ByVal IN_MMCUSR As String, ByVal IN_NTRMNL As String, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Dim slist() As String
            Dim msg As String = ""
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NRALQT", IN_NRALQT)
                objParam.Add("IN_TIPO", IN_TIPO)
                objParam.Add("IN_MMCUSR", IN_MMCUSR)
                objParam.Add("IN_NTRMNL", IN_NTRMNL)

                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_PROV_ALQUILER", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                sErrorMesage = sErrorMesage.Trim
                If sErrorMesage.Length > 0 Then
                    slist = sErrorMesage.Split("|")
                    For Each Item As String In slist
                        msg = msg & Chr(13) & Item
                    Next
                    msg = msg.Trim
                End If
                sErrorMesage = msg
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        Public Function Listar_Servicio_Guia_ProvVarios(ByVal CCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal) As DataTable
            Dim dtTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", NOPRCN)
            objParam.Add("IN_NGUITR", NGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)

            dtTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_LIQUIDACION_PROV_VARIOS", objParam)
            Return dtTable
        End Function

        Public Function Listar_Servicio_Guia_Prov_Validacion(ByVal CCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal) As DataSet
            Dim dtTable As New DataSet
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", NOPRCN)
            objParam.Add("IN_NGUITR", NGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)

            dtTable = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_SERVICIO_LIQUIDACION_PROV_VALIDA", objParam)
            Return dtTable
        End Function

        Public Function Listar_Servicio_Guia_Reparto_Prov_Validacion(ByVal pCCMPN As String, ByVal IN_CDVSN As String, ByVal IN_NMOPRP As Decimal) As DataSet
            Dim dtTable As New DataSet
            Dim objParam As New Parameter
            objParam.Add("IN_NMOPRP", IN_NMOPRP)
            objParam.Add("IN_CCMPN", pCCMPN)
            objParam.Add("IN_CDVSN", IN_CDVSN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dtTable = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_SERVICIO_LIQUIDACION_REPARTO_PROV_VALIDA", objParam)
            Return dtTable
        End Function



        Public Function Listar_GRemServCargadasGTranspLiqVal(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As DataTable
            Dim objDataTable As New DataTable

            'Try
            Dim objParam As New Parameter

            objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_VALIDA", objParam)

            'Catch : End Try
            Return objDataTable
        End Function


        Public Function Listar_GRemServCargadasGTranspRepartoLiqVal(ByVal CCMPN As String, ByVal CDVSN As String, ByVal IN_NMOPRP As Decimal) As DataTable
            Dim objDataTable As New DataTable

            'Try
            Dim objParam As New Parameter
            objParam.Add("IN_NMOPRP", IN_NMOPRP)
            objParam.Add("IN_CCMPN", CCMPN)
            objParam.Add("IN_CDVSN", CDVSN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_REPARTO_VALIDA", objParam)

            'Catch : End Try
            Return objDataTable
        End Function

        Public Function Listar_Asiento_CO_X_Operacion(ByVal nroOperacion As Decimal, ByVal nroGuia As Decimal, ByVal compania As String) As List(Of ENTIDADES.consultas.AsientoCO)
            Dim lista As New List(Of ENTIDADES.consultas.AsientoCO)

            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", nroOperacion)
            objParam.Add("IN_NGUITR", nroGuia)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

            Dim dtResult As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ASIENTO_CO_X_OPERACION", objParam)

            For Each fila As DataRow In dtResult.Rows

                Dim entidad As ENTIDADES.consultas.AsientoCO = New ENTIDADES.consultas.AsientoCO()
                entidad.NCRDCO = fila("NCRDCO")
                entidad.DOCDATE = fila("DOCDATE")
                entidad.POSTDATE = fila("POSTDATE")
                entidad.IMPORTECO = fila("IMPORTECO")
                entidad.NCCSAP = fila("NCCSAP")
                entidad.D_HDR_TX = fila("D_HDR_TX")
                lista.Add(entidad)

            Next

            Return lista

        End Function

        Public Function Listar_AsientoDetalle_CO(ByVal nroTarifa As Decimal, ByVal compania As String) As List(Of ENTIDADES.consultas.DetalleAsientoCO)
            Dim lista As New List(Of ENTIDADES.consultas.DetalleAsientoCO)

            Dim objParam As New Parameter
            objParam.Add("IN_NCRDCO", nroTarifa)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

            Dim dtResult As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DETALLE_ASIENTO_CO", objParam)

            For Each fila As DataRow In dtResult.Rows

                Dim entidad As ENTIDADES.consultas.DetalleAsientoCO = New ENTIDADES.consultas.DetalleAsientoCO()
                entidad.NCRDCO = fila("NCRDCO")
                entidad.SENITEM = fila("SENITEM")
                entidad.DESC_SERV = fila("DESC_SERV")
                entidad.POSTQUUN = fila("POSTQUUN")
                entidad.CANTIDAD = fila("CANTIDAD")
                entidad.VALU_TCU = fila("VALU_TCU")
                entidad.CMNDA = fila("CMNDA")
                entidad.COST_ELE = fila("COST_ELE")
                entidad.CCNCOS = fila("CCNCOS")
                entidad.SEN_ORDE = fila("SEN_ORDE")
                entidad.REC_CCTR = fila("REC_CCTR")
                entidad.REC_ORDE = fila("REC_ORDE")
                entidad.UNID_MED = fila("UNID_MED")
                entidad.TMNDA = fila("TMNDA")
                lista.Add(entidad)

            Next

            Return lista

        End Function

        Public Function ObtenerNumeroCO(ByVal numero As Decimal, ByRef NumeroSAP As Decimal, ByVal compania As String) As Boolean
            Dim objParam As New Parameter
            objParam.Add("PNNCRDO", numero)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

            Dim dtResult As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_NROCO", objParam)

            For Each fila As DataRow In dtResult.Rows
                NumeroSAP = fila("NCCSAP")
            Next

            Return (NumeroSAP > 0)

        End Function

        Public Function Listar_NumerosCO(ByVal parametros As Hashtable) As DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", parametros("PSCCMPN"))
            objParam.Add("PSCDVSN", parametros("PSCDVSN"))
            objParam.Add("PNNLQDCN", parametros("PNNLQDCN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(parametros("PSCCMPN"))
            Dim dtResult As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_NROCO_X_LIQUIDACION", objParam)

            Return dtResult
        End Function

        Public Function Procesar_Anulacion_CO_Tarifa_Interna(ByVal nroCO As Decimal, ByVal compania As String, ByVal TipoPeriodoAnulacion As String) As String
            Dim objParam As New Parameter
            Dim dtResult As New DataTable
            Dim sErrorMesage As String = ""
            objParam.Add("IN_NCRDCO", nroCO)
            objParam.Add("IN_MMCUSR", Environment.UserName)
            objParam.Add("IN_NTRMNL", Environment.MachineName)
            objParam.Add("IN_FECHADOC", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
            objParam.Add("IN_FECHA_CONT", HelpClass.CDate_a_Numero8Digitos(DateTime.Now))
            objParam.Add("IN_TIPOPERIODOANUL", TipoPeriodoAnulacion)
            'objParam.Add("IN_MENSAJE", String.Empty, ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

            dtResult = objSql.ExecuteDataTable("SP_SOLMIN_ST_PROCESAR_ANULACION_ASIENTO_CO_TARIFA_INTERNA", objParam)

            For Each row As DataRow In dtResult.Rows
                If row("STATUS").ToString.Trim = "N" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            sErrorMesage = sErrorMesage.Trim
            Return sErrorMesage
            'strMessage = objSql.ParameterCollection("IN_MENSAJE")

            'Return String.IsNullOrEmpty(strMessage)

        End Function

        Public Function Listar_Liquidacion_Flete_Prov_Varios(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable

            objParam.Add("PNCTRSPT", objParametro("PNCTRSPT"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))

            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            objParam.Add("PSCPLNDV", objParametro("PSCPLNDV"))
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            objParam.Add("PNFECINI", objParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objParametro("PNFECFIN"))

            objParam.Add("PSSESTRG", objParametro("PSSESTRG"))

            objParam.Add("PNNRFSAP_INI", objParametro("PNNRFSAP_INI"))
            objParam.Add("PNNRFSAP_FIN", objParametro("PNNRFSAP_FIN"))
            objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            'SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIO_SAP

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIO_SAP_PROV_VARIOS", objParam)

            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New LiquidacionOperacion
                objEntidad.NLQDCN = objDataRow("NLQDCN")
                'objEntidad.FLQDCN_S = HelpClass.CFecha_de_8_a_10(objDataRow("FLQDCN").ToString.Trim)
                objEntidad.FLQDCN_S = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                objEntidad.FLQDCN_FORMAT = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                'objEntidad.NRFSAP = objDataRow("NRFSAP")
                'objEntidad.CADNRFSAP = "" & objDataRow("NRFSAP")
                'objEntidad.TSTERS = objDataRow("TSTERS").ToString.Trim
                'objEntidad.FSTTRS = objDataRow("FSTTRS").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NUMOPG = objDataRow("NUMOPG")
                'objEntidad.ILQDTR = objDataRow("ILQDTR")

                objEntidad.ILQDTR_S = objDataRow("ILQDTR_S")
                objEntidad.ILQDTR_D = objDataRow("ILQDTR_D")

                objEntidad.ITCCTC = objDataRow("ITCCTC")
                objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objDataRow("CPLNDV")
                objEntidad.TPLNTA = objDataRow("TPLNTA").ToString.Trim  'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                objEntidad.SIN_REFSAP = objDataRow("SIN_REFSAP")


                objGenericCollection.Add(objEntidad)
            Next
 
            Return objGenericCollection
        End Function

        Public Sub Anular_Liquidacion_Flete_Propio_Prov_Varios(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter
            'Dim intResultado As Int32 = 0
            'Try
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCULUSA", objParametro("PSMMCUSR"))
            objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
            objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
            objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_FLETE_PROPIO_PROV_VARIOS", objParam)
            'intResultado = 1
            'Catch ex As Exception
            '    intResultado = 0
            'End Try
            'Return intResultado
        End Sub

        Public Function Actualizar_Liquidacion_Flete_SAP_Prov_Varios(ByVal objParametro As Hashtable) As Hashtable
            Dim objParam As New Parameter
            Dim hasResultado As New Hashtable
            'Try

            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
            objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
            objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
            objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))
            objParam.Add("PNRESULT", 0, ParameterDirection.Output)
            objParam.Add("PSRESULT", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_LIQUIDACION_FLETE_SAP_PROV_VARIOS", objParam)
            hasResultado.Add("INTRESULT", objSql.ParameterCollection("PNRESULT"))
            hasResultado.Add("STRRESULT", objSql.ParameterCollection("PSRESULT"))

            'Catch ex As Exception
            '    hasResultado.Add("INTRESULT", 0)
            '    hasResultado.Add("STRRESULT", "")
            'End Try
            Return hasResultado
        End Function

        Public Function Lista_Servicio_X_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objDataTable As New DataTable

            'Try

            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_X_LIQUIDACION_SAP", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New LiquidacionOperacion
                objEntidad.NCRRRT = objDataRow("NCRRLT")
                objEntidad.NGUITR = objDataRow("NGUITR")
                objEntidad.CSRVC = objDataRow("CSRVC")
                objEntidad.TABTRF = objDataRow("TABTRF").ToString.Trim
                objEntidad.NORINS = objDataRow("NORINS")
                objEntidad.NRFSAP = objDataRow("NRFSAP")
                objEntidad.NENMRS = objDataRow("NENMRS")
                objEntidad.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.FCHCRT_S = objDataRow("FCHCRT_S").ToString.Trim
                objEntidad.IMPOCOS = objDataRow("IMPOCOS")
                objEntidad.IMPOCOD = objDataRow("IMPOCOD")
                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of LiquidacionOperacion)()
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Liquidaciones_Flete_X_Liquidacion(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            'Try
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            'SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIO_SAP

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_X_LIQ_OPERACION", objParam)

            For Each objDataRow As DataRow In objDataTable.Rows
                objEntidad = New LiquidacionOperacion
                objEntidad.NLQDCN = objDataRow("NLQDCN")
                'objEntidad.FLQDCN_S = HelpClass.CFecha_de_8_a_10(objDataRow("FLQDCN").ToString.Trim)
                objEntidad.FLQDCN_S = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                objEntidad.FLQDCN_FORMAT = HelpClass.FechaNum_a_Fecha(objDataRow("FLQDCN"))
                objEntidad.NRFSAP = objDataRow("NRFSAP")
                'objEntidad.TSTERS = objDataRow("TSTERS").ToString.Trim
                'objEntidad.FSTTRS = objDataRow("FSTTRS").ToString.Trim
                objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objEntidad.NUMOPG = objDataRow("NUMOPG")
                objEntidad.ILQDTR = objDataRow("ILQDTR")
                objEntidad.ITCCTC = objDataRow("ITCCTC")
                objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objDataRow("CPLNDV")
                objEntidad.TIPO = objDataRow("TIPO").ToString.Trim
                objEntidad.FechaActual = objDataRow("FECHA_ACTUAL")

                objGenericCollection.Add(objEntidad)
            Next

            'Catch ex As Exception
            '    objGenericCollection = New List(Of LiquidacionOperacion)
            'End Try
            Return objGenericCollection
        End Function



        Public Function Listar_Datos_Operacion_Flete(ByVal objParametro As Hashtable) As DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DATOS_OPERACION_FLETE", objParam)
            Return objDataTable
        End Function


        Public Function Actualizar_Datos_Liquidacion_Flete_SAP_Prov_varios(ByVal objParametro As Hashtable) As Int16
            Dim objParam As New Parameter
            Dim intResultado As Int16 = 0
            Try
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
                objParam.Add("PNNLQDCN", objParametro("NLQDCN"))
                objParam.Add("PNFECACT", objParametro("FECACT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_DATOS_LIQUIDACION_SAP_PROV_VARIOS", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

        Public Function Listar_servicios_liquidacion_servicios_sap(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objParam.Add("PNNLQDCN", objParametro("NLQDCN"))
            objParam.Add("PNNGUITR", objParametro("NGUITR"))
            objParam.Add("PNNCRRGU", objParametro("NCRRGU"))
            objParam.Add("PNCSRVC", objParametro("CSRVC"))
            'objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIOS_LIQUIDACION_SAP", objParam)
            Return dt
        End Function

        Public Function Listar_servicios_liquidacion_sap_validacion(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objParam.Add("PNNLQDCN", objParametro("NLQDCN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_SAP_VALIDACION", objParam)
            Return dt
        End Function


        Public Function Listar_Datos_Guia_Cargada(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", objParametro("CCMPN"))
            objParam.Add("PSCDVSN", objParametro("CDVSN"))
            objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
            objParam.Add("PNNGUITR ", objParametro("NGUITR "))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DATOS_CARGA_VIAJE", objParam)
            Return dt
        End Function


        'JMC --------------------------------------------------
        Public Function Validar_Diferencia(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal IN_NMOPRP As Decimal) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
            objParam.Add("IN_NMOPRP", IN_NMOPRP)
            '
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_GREMISION_CARGADOS", objParam)
            dt.Columns.Add("DIFSOLES", Type.GetType("System.Decimal"))
            dt.Columns.Add("FMRG")

            dt.Columns.Add("MONCOSOL", Type.GetType("System.Decimal"))
            dt.Columns.Add("MONPASOL", Type.GetType("System.Decimal"))
            dt.Columns.Add("MARGENPOR", Type.GetType("System.Decimal"))

            For Each Item As DataRow In dt.Rows
                Item("MONCOSOL") = 0
                Item("MONPASOL") = 0
                ' MONEDA DIFERENTE SOLES
                If Item("CMNDGU") <> 0 Then
                    If Item("CMNDGU") <> 1 Then
                        Item("MONCOSOL") = (Item("MONTO_COBRO") * Item("TIPO_CAMBIO"))
                    Else
                        'SI ES SOLES
                        Item("MONCOSOL") = Item("MONTO_COBRO")
                    End If
                End If

                ' MONEDA DIFERENTE SOLES
                If Item("CMNLQT") <> 0 Then
                    If Item("CMNLQT") <> 1 Then
                        Item("MONPASOL") = (Item("MONTO_PAGO") * Item("TIPO_CAMBIO"))
                    Else
                        'SI ES SOLES
                        Item("MONPASOL") = Item("MONTO_PAGO")
                    End If
                End If

                Item("DIFSOLES") = Item("MONCOSOL") - Item("MONPASOL")
                If Item("DIFSOLES") < 0 Then
                    Item("FMRG") = "X"
                Else
                    Item("FMRG") = ""
                End If

                If Item("MONCOSOL") = 0 Then
                    Item("MARGENPOR") = 0
                Else
                    Item("MARGENPOR") = Math.Round((Item("DIFSOLES") / Item("MONCOSOL")) * 100, 2)
                End If
            Next
            Return dt
        End Function

        Public Sub ACTUALIZAR_STATUS_ENVIO_APROBACION(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal NLBFLT As Decimal, ByVal IN_NMOPRP As Decimal)
            Dim objParam As New Parameter
            objParam.Add("PCTRMNC", objEntidad.pCTRSPT)
            objParam.Add("PRESAPR", NLBFLT)
            objParam.Add("PNGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
            objParam.Add("PSCULUSA", objEntidad.pMMCUSR_Usuario)
            objParam.Add("IN_NMOPRP", IN_NMOPRP)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_STATUS_ENVIO_APROBACION", objParam)
        End Sub


        Public Sub ACTUALIZAR_STATUS_SEGUIMIENTO_APROBACION(ByVal obeAprobacionMargen As beAprobacionMargen)
            Dim objParam As New Parameter
            objParam.Add("PNNOPRCN", obeAprobacionMargen.PNNOPRCN)
            objParam.Add("PNCTRMNC", obeAprobacionMargen.PNCTRMNC)
            objParam.Add("PNNGUIRM", obeAprobacionMargen.PNNGUIRM)
            objParam.Add("PNNMOPRP", obeAprobacionMargen.PNNMOPRP)
            objParam.Add("PNRESAPR", obeAprobacionMargen.PNRESAPR)
            objParam.Add("PSFLGSTA", obeAprobacionMargen.PSFLGSTA)
            objParam.Add("PSTOBS", obeAprobacionMargen.PSTOBS)
            objParam.Add("PSCULUSA", obeAprobacionMargen.PSCULUSA)
            objParam.Add("PSNTRMNL", obeAprobacionMargen.PSNTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeAprobacionMargen.PSCCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_STATUS_SEGUIMIENTO_APROBACION", objParam)



        End Sub




        Public Function LISTAR_SERVICIOS_HISTORIAL_ACUTALIZACION(ByVal pCCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal, ByVal NCRRGU As Decimal) As DataTable
            Dim dt As New DataTable

            Dim objParam As New Parameter
            objParam.Add("IN_NOPRCN", NOPRCN)
            objParam.Add("IN_NGUITR", NGUITR)
            objParam.Add("IN_NCRRGU", NCRRGU)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_HISTORIAL_ACUTALIZACION", objParam)
            Return dt
        End Function

        Public Function lISTAR_SERVICIO_OPERACION_VALIDACION_LOG(ByVal pCCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal, ByVal NCRRGU As Decimal) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNOPRCN", NOPRCN)
            objParam.Add("PNNGUITR", NGUITR)
            objParam.Add("PNNCRRGU", NCRRGU)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_OPERACION_VALIDACION_LOG", objParam)
            Return dt
        End Function

        Public Sub Grabar_Log_Servicio(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByVal Obsr As String, ByVal Tipo As String)

            Dim objParam As New Parameter
            objParam.Add("PNNOPRCN", objEntidad.pNOPRCN_NroOperacion)
            objParam.Add("PNNGUITR", objEntidad.pNGUITR_NroGuiaRemision)
            objParam.Add("PNNCRRGU", objEntidad.pNCRRGU_CorrServ)
            'objParam.Add("PNCSRVC", objEntidad.pCSRVC_Servicio)
            'objParam.Add("PNCMNDGU", objEntidad.pCMNDGU_MonedaGuia)
            'objParam.Add("PNISRVGU", objEntidad.pISRVGU_importeServicio)
            'objParam.Add("PNQCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
            'objParam.Add("PSSFCTTR", objEntidad.pSFCTTR_StatusFacturado)
            'objParam.Add("PSSLQDTR", objEntidad.pSLQDTR_StatusLiquTransporte) '
            'objParam.Add("PNCMNLQT", objEntidad.pCMNLQT_Moneda)
            'objParam.Add("PNILQDTR", objEntidad.pILQDTR_ImporteLiquidacionTransp)
            'objParam.Add("PNQCNDLG", objEntidad.pQCNDLG_CantidadServicioLiquidacion)
            objParam.Add("PSTOBSAC", Obsr)
            objParam.Add("PSCUSCRT", objEntidad.pMMCUSR_Usuario)
            objParam.Add("PSNTRMCR", objEntidad.pNTRMNL_Terminal)
            objParam.Add("PSTIPO", Tipo)
            'objParam.Add("PSESTADO", objEntidad.pSESTRG)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_SERVICIO_LOG", objParam)
        End Sub

        'Public Sub APROBAR_MARGEN_X_OPERACION(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal PNNMOPRP As Decimal, ByVal PSFLGSTA As String)

        '    Dim objParam As New Parameter
        '    objParam.Add("PCTRMNC", objEntidad.pCTRSPT)
        '    objParam.Add("PNGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
        '    objParam.Add("PSCULUSA", objEntidad.pMMCUSR_Usuario)
        '    objParam.Add("PSTOBS", objEntidad.pTOBS_Observacion)
        '    objParam.Add("PNNMOPRP", PNNMOPRP)
        '    objParam.Add("PSFLGSTA", PSFLGSTA)
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)
        '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_APROBAR_MARGEN_X_OPERACION", objParam)
        'End Sub

        'Public Function VALIDAR_USUSARIO_APROBADOR(ByVal pCCMPN As String, ByVal pUsuario As String, ByVal PSTIPO As String) As Boolean
        '    Dim dt As New DataTable
        '    Dim objParam As New Parameter
        '    objParam.Add("PSCUSCRT", pUsuario)
        '    objParam.Add("PSTIPO", PSTIPO)
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
        '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_USUASRIO_APROBADOR", objParam)
        '    If dt.Rows.Count > 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End Function

        'Public Function LISTAR_ACCESO_DESTINO_APROBACION(ByVal pCCMPN As String, ByVal pUsuario As String) As DataTable
        '    Dim dt As New DataTable
        '    Dim objParam As New Parameter
        '    objParam.Add("IN_USUARIO", pUsuario)
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
        '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACCESO_DESTINO_APROBACION", objParam)
        '    Return dt
        'End Function

        Public Function LISTAR_AREA_RESPONSABLE_MARGEN(ByVal pCCMPN As String, ByVal pMargen As Decimal) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            objParam.Add("PNMARGEN", pMargen)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_NIVELES_APROBACION", objParam)
            Return dt
        End Function

        Public Function LISTAR_NIVELES_APROBACION(ByVal pCCMPN As String) As DataTable
            Dim dt As New DataTable
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_AREAS_APROBACION", Nothing)
            Return dt
        End Function

        Public Function Listar_Datos_Guia_Operacion(ByVal objParametro As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("IN_NOPRCN", objParametro("IN_NOPRCN"))
            objParam.Add("IN_GUIA_TRANS", objParametro("IN_GUIA_TRANS"))
            objParam.Add("IN_CTRMNC", objParametro("IN_CTRMNC"))
            objParam.Add("IN_GUIA_REM", objParametro("IN_GUIA_REM"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DATOS_GUIA_OPERACION", objParam)

            Return dt
        End Function


        Public Function ListaServiciosConsolidados(ByVal numConsolidado As Decimal, ByVal compania As String, ByVal division As String) As DataTable
            Dim objDataTable As New DataTable

            Dim objParam As New Parameter

            objParam.Add("IN_NMVJCS", numConsolidado)
            objParam.Add("IN_CCMPN", compania)
            objParam.Add("IN_CDVSN", division)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(compania)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_CONSOLDADO_VALIDA", objParam)

            Return objDataTable
        End Function

        Public Function validarGeneracionDeOperacion(ByVal objParametro As Hashtable) As String
            Dim msj As String = String.Empty
            Dim objParam As New Parameter
            Dim dt As New DataTable

            objParam.Add("PARAM_NCSOTR", objParametro("NCSOTR"))
            'objParam.Add("PARAM_NORSRT", objParametro("NORSRT"))
            objParam.Add("PARAM_NRUCTR", objParametro("NRUCTR"))
            objParam.Add("PARAM_TRACTO", objParametro("TRACTO"))
            objParam.Add("PARAM_ACOPLADO", objParametro("ACOPLADO"))
            objParam.Add("PARAM_HATNSR", objParametro("HATNSR"))
            objParam.Add("PARAM_CHECKHORA", "SI") ' SI => se valida que se ingrese hora en caso el cliente esté configurado
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDA_GENERACION_OPERACION_SALM", objParam)
            For Each row As DataRow In dt.Rows
                If row("STATUS").ToString.Trim = "N" Then
                    msj = msj & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            msj = msj.Trim
            Return msj
        End Function

        Public Sub EnviarTarifaInternaSAP(ByVal pNCRDCO As String, ByVal pCCMPN As String)
            Dim objParam As New Parameter
            objParam.Add("PARAM_NCRDCO", pNCRDCO)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP108U", objParam)
        End Sub


        Public Function Listar_Seguimiento_Operacion_Margen(ByVal pCCMPN As String, ByVal NOPRCN As Decimal) As DataTable
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("NOPRCN", NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SEGUIMIENTO_MARGEN_OPERACION", objParam)
            For Each objDataRow As DataRow In dt.Rows
                objDataRow("FCHCRT") = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FCHCRT"))
                objDataRow("HRACRT") = HelpClass.HoraNum_a_Hora(objDataRow("HRACRT"))
            Next
            Return dt
        End Function

        Public Sub RegistraEnvioRespuestaSwMilpo(ByVal objetoParametro As Hashtable)
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))

            objParam.Add("PSFSTENV", objetoParametro("PSFSTENV"))
            objParam.Add("PSMSTENV", objetoParametro("PSMSTENV"))
            objParam.Add("PSMSTEN2", objetoParametro("PSMSTEN2"))
            objParam.Add("PSUSUENV", objetoParametro("PSUSUENV"))
            objParam.Add("PSUNIREL", objetoParametro("PSUNIREL"))


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_INFO_GUIA_ENVIO_CLIENTE", objParam)

        End Sub

        Public Function Cargar_Envio_Despacho(ByVal PNCTRMNC As String, ByVal PNNGUITR As String, ByVal CCMPN As String) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", PNCTRMNC)
            objParam.Add("PNNGUITR", PNNGUITR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_INFO_GUIA_ENVIO_CLIENTE", objParam)

            objDataSet.Tables(1).Columns.Add("F_FCGUCL", System.Type.GetType("System.String"))
            objDataSet.Tables(1).Columns.Add("MOTIVO_TRASLADO", System.Type.GetType("System.String"))
            Dim motivo_traslado As String = ""
            For Each dr As DataRow In objDataSet.Tables(1).Rows

                If dr("MOT_TRASLADO").ToString.Trim = "" Then
                    motivo_traslado = dr("MOT_TRASLADO_CLNT").ToString.Trim
                Else
                    motivo_traslado = dr("MOT_TRASLADO").ToString.Trim
                End If
                dr("MOTIVO_TRASLADO") = motivo_traslado
                dr("F_FCGUCL") = HelpClass.FechaNum_a_Fecha(dr("FCGUCL").ToString.Trim)
            Next

            objDataSet.Tables(2).Columns.Add("F_FBULTO", System.Type.GetType("System.String"))
            For Each dr As DataRow In objDataSet.Tables(2).Rows
                dr("F_FBULTO") = HelpClass.FechaNum_a_Fecha(dr("FBULTO").ToString.Trim)
            Next

            Return objDataSet
        End Function

        Public Function OBTENER_INFO_GUIA_ENVIO_CLIENTE(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFO_GUIA_ENVIO_CLIENTE", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objEntidad = New GuiaTransportista
                objEntidad.CTRMNC = objData("CTRMNC")
                objEntidad.NGUIRM = objData("NGUIRM")
                Dim FSTENV As String = IIf(objData("FSTENV").Equals(DBNull.Value), "", objData("FSTENV"))
                Dim STATUS_DESC As String = IIf(objData("STATUS_DESC").Equals(DBNull.Value), "", objData("STATUS_DESC"))
                If STATUS_DESC.Trim = "" Then
                    objEntidad.STATUS_ENVIO = "N-No enviado"
                Else
                    objEntidad.STATUS_ENVIO = String.Format("{0}-{1}", FSTENV, STATUS_DESC)
                End If
                If Not String.IsNullOrEmpty(objData("USUENV").ToString.Trim) Then
                    objEntidad.USUARIO_ENVIO = String.Format("{0}-{1}-{2}", objData("USUENV"), objData("FCHENV"), objData("HRAENV"))
                Else
                    objEntidad.USUARIO_ENVIO = ""
                End If
                objEntidad.FSTENV = FSTENV
                objEntidad.MSTENV = ("" & objData("MSTENV")).ToString.Trim
                objEntidad.MSTEN2 = ("" & objData("MSTEN2")).ToString.Trim

                objGenericCollection.Add(objEntidad)
            Next
            Return objGenericCollection
        End Function

        'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
        Public Function Estimacion_Ingreso_Revertir_ST(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))

            dt = objSql.ExecuteDataTable("SP_SOLMIN_LISTA_ESTIMACION_INGRESO_REVERTIR_ST_ANULACION", objParam)
            Return dt
        End Function
        'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

        Public Function Lista_Acceso_Usuario_Periodo_Anulacion(ByVal IN_CCMPRN As String, ByVal PSCCMPN As String) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter

            objParam.Add("IN_CCMPRN", IN_CCMPRN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_USUARIO_PERIODO_ANULACION", objParam)
            Return dt
        End Function


        Public Function Obtener_Informacion_OS(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            'Try
            Dim obeGuiaTransportista As New GuiaTransportista
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFORMACION_OS_TRANSP", objParam)
            If dt.Rows.Count > 0 Then
                obeGuiaTransportista.NPLNMT = dt.Rows(0)("NPLNMT")
                obeGuiaTransportista.CLCLOR = dt.Rows(0)("CLCLOR")
                obeGuiaTransportista.CLCLDS = dt.Rows(0)("CLCLDS")
                obeGuiaTransportista.QMRCMC = dt.Rows(0)("QMRCDR")
                obeGuiaTransportista.CUNDMD = dt.Rows(0)("CUNDMD")
                obeGuiaTransportista.CMNFLT = dt.Rows(0)("CMNFLT")
                obeGuiaTransportista.QKMREC = dt.Rows(0)("QKMREC")
                obeGuiaTransportista.TNMBRM = dt.Rows(0)("PSTNMBRM").ToString.Trim
                obeGuiaTransportista.TDRCRM = dt.Rows(0)("PSTDRCRM").ToString.Trim
                obeGuiaTransportista.TPDCIR = dt.Rows(0)("PSTPDCIR").ToString.Trim
                obeGuiaTransportista.NRUCRM = dt.Rows(0)("PNNRUCRM")
                obeGuiaTransportista.CCLNT = dt.Rows(0)("CCLNT")
                obeGuiaTransportista.CUBORI = dt.Rows(0)("CUBORI")
                obeGuiaTransportista.CUBDES = dt.Rows(0)("CUBDES")
                obeGuiaTransportista.CMNFLTDESC = dt.Rows(0)("CMNFLTDESC")
                'obeGuiaTransportista.TNMBCN = objEntidad.TNMBRM
                'obeGuiaTransportista.TDRCNS = objEntidad.TDRCRM
                'obeGuiaTransportista.TPDCIC = objEntidad.TPDCIR
                'obeGuiaTransportista.NRUCCN = objEntidad.NRUCRM
                obeGuiaTransportista.TNMBCN = obeGuiaTransportista.TNMBRM
                obeGuiaTransportista.TDRCNS = obeGuiaTransportista.TDRCRM
                obeGuiaTransportista.TPDCIC = obeGuiaTransportista.TPDCIR
                obeGuiaTransportista.NRUCCN = obeGuiaTransportista.NRUCRM
                obeGuiaTransportista.TCNFVH = dt.Rows(0)("PSTCNFVH").ToString.Trim
                If obeGuiaTransportista.TCNFVH = "0" OrElse obeGuiaTransportista.TCNFVH = "" Then obeGuiaTransportista.TCNFVH = ""
                obeGuiaTransportista.CCNCST = dt.Rows(0)("CCNCST")
                obeGuiaTransportista.TDSCAR = dt.Rows(0)("TDSCAR").ToString.Trim
                If obeGuiaTransportista.TDSCAR.Length > 30 Then
                    obeGuiaTransportista.TDSCAR = obeGuiaTransportista.TDSCAR.Substring(0, 30)
                End If
                obeGuiaTransportista.CUNDMD_DESC = dt.Rows(0)("UM_DESC").ToString.Trim

                obeGuiaTransportista.TCMTRT = dt.Rows(0)("TCMTRT").ToString.Trim
                obeGuiaTransportista.CTRMNC = dt.Rows(0)("CTRMNC")

                obeGuiaTransportista.TDIROR = dt.Rows(0)("TDIROR")
                obeGuiaTransportista.TDIRDS = dt.Rows(0)("TDIRDS")
                obeGuiaTransportista.CMEDTR = dt.Rows(0)("CMEDTR")
                obeGuiaTransportista.CTPOVJ = dt.Rows(0)("CTPOVJ")
                'QMRCDR

            End If


            Return obeGuiaTransportista
        End Function



        Public Function Get_Guia_Transportista(ByVal objetoParametro As Hashtable) As GuiaTransportista
            Dim objData As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New GuiaTransportista
            Dim objEntidad As New GuiaTransportista

            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            'objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_GET_GUIA_TRANSPORTISTA", objParam)
            'End If


            If objData.Rows.Count > 0 Then

                objEntidad.CTRMNC = objData.Rows(0)("CTRMNC")
                objEntidad.NGUIRM = objData.Rows(0)("NGUIRM")

                objEntidad.CTDGRT = objData.Rows(0)("CTDGRT")
                objEntidad.NGUITS = objData.Rows(0)("NGUITS")

                objEntidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(objData.Rows(0)("FGUIRM").ToString.Trim)
                objEntidad.NPLNMT = objData.Rows(0)("NPLNMT")
                objEntidad.CLCLOR = objData.Rows(0)("CLCLOR")
                objEntidad.CLCLDS = objData.Rows(0)("CLCLDS")
                objEntidad.TDIROR = objData.Rows(0)("TDIROR").ToString.Trim
                objEntidad.TDIRDS = objData.Rows(0)("TDIRDS").ToString.Trim
                objEntidad.NOPRCN = objData.Rows(0)("NOPRCN")
                objEntidad.TRFRGU = objData.Rows(0)("TRFRGU").ToString.Trim
                objEntidad.QMRCMC = objData.Rows(0)("QMRCMC")
                objEntidad.PMRCMC = objData.Rows(0)("PMRCMC")
                objEntidad.CUNDMD = objData.Rows(0)("CUNDMD").ToString.Trim
                objEntidad.QGLGSL = objData.Rows(0)("QGLGSL")
                objEntidad.QGLDSL = objData.Rows(0)("QGLDSL")
                objEntidad.NRHJCR = objData.Rows(0)("NRHJCR")
                objEntidad.CTRSPT = objData.Rows(0)("CTRSPT")
                objEntidad.NPLCTR = objData.Rows(0)("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = objData.Rows(0)("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = objData.Rows(0)("CBRCNT").ToString.Trim
                objEntidad.TNMBRM = objData.Rows(0)("TNMBRM").ToString.Trim
                objEntidad.TDRCRM = objData.Rows(0)("TDRCRM").ToString.Trim
                objEntidad.TPDCIR = objData.Rows(0)("TPDCIR").ToString.Trim
                objEntidad.NRUCRM = objData.Rows(0)("NRUCRM")
                objEntidad.TNMBCN = objData.Rows(0)("TNMBCN").ToString.Trim
                objEntidad.TDRCNS = objData.Rows(0)("TDRCNS").ToString.Trim
                objEntidad.TPDCIC = objData.Rows(0)("TPDCIC").ToString.Trim
                objEntidad.NRUCCN = objData.Rows(0)("NRUCCN")
                objEntidad.SACRGO = objData.Rows(0)("SACRGO").ToString.Trim
                objEntidad.CMNFLT = objData.Rows(0)("CMNFLT")
                objEntidad.SESTRG = objData.Rows(0)("SESTRG").ToString.Trim
                objEntidad.FLGADC = objData.Rows(0)("FLGADC").ToString.Trim
                objEntidad.SIDAVL = objData.Rows(0)("SIDAVL").ToString.Trim
                objEntidad.QKMREC = objData.Rows(0)("QKMREC")
                objEntidad.ICSTRM = objData.Rows(0)("ICSTRM")
                objEntidad.QPSOBR = objData.Rows(0)("QPSOBR")
                objEntidad.QVLMOR = objData.Rows(0)("QVLMOR")
                objEntidad.SMRPLG = objData.Rows(0)("SMRPLG").ToString.Trim
                objEntidad.SMRPRC = objData.Rows(0)("SMRPRC").ToString.Trim
                objEntidad.IVLPRT = objData.Rows(0)("IVLPRT")
                objEntidad.CMNVLP = objData.Rows(0)("CMNVLP")
                objEntidad.CCMPN = objData.Rows(0)("CCMPN").ToString.Trim
                objEntidad.CDVSN = objData.Rows(0)("CDVSN").ToString.Trim
                objEntidad.CPLNDV = objData.Rows(0)("CPLNDV")
                objEntidad.CUBORI = objData.Rows(0)("CUBORI")
                objEntidad.CUBDES = objData.Rows(0)("CUBDES")
                objEntidad.FEMVLH = objData.Rows(0)("FEMVLH")

                objEntidad.FEMVLH_S = HelpClass.FechaNum_a_Fecha(objData.Rows(0)("FEMVLH_S"))
                objEntidad.FCHFTR_S = HelpClass.FechaNum_a_Fecha(objData.Rows(0)("FCHFTR_S"))
                objEntidad.FECETA_S = HelpClass.FechaNum_a_Fecha(objData.Rows(0)("FECETA_S"))
                objEntidad.FECETD_S = HelpClass.FechaNum_a_Fecha(objData.Rows(0)("FECETD_S"))

                objEntidad.CBRCND = objData.Rows(0)("CBRCND").ToString.Trim
                objEntidad.TOBS = objData.Rows(0)("TOBS").ToString.Trim

                objEntidad.TCNFVH = objData.Rows(0)("TCNFVH").ToString.Trim
               
                objEntidad.TCMTRT = objData.Rows(0)("TCMTRT").ToString.Trim

                objEntidad.TCMLCO = objData.Rows(0)("TCMLCO").ToString.Trim
                objEntidad.TCMLCD = objData.Rows(0)("TCMLCD").ToString.Trim
                objEntidad.CMRCDR = objData.Rows(0)("CMRCDR")


                objEntidad.SESGRP = objData.Rows(0)("SESGRP").ToString.Trim
                objEntidad.NORSRT = objData.Rows(0)("NORSRT").ToString.Trim

                objEntidad.NOREMB = objData.Rows(0)("NOREMB").ToString.Trim
               

                objEntidad.NMOPMM = objData.Rows(0)("NMOPMM")
                objEntidad.NMOPRP = objData.Rows(0)("NMOPRP")
                objEntidad.NMVJCS = objData.Rows(0)("NMVJCS")
                objEntidad.NRUCTR = objData.Rows(0)("NRUCTR")

                 
                objEntidad.CCLNT = objData.Rows(0)("CCLNT")
                objEntidad.MSTENV = objData.Rows(0)("MSTENV")
                objEntidad.MSTEN2 = objData.Rows(0)("MSTEN2")


                objEntidad.CMEDTR = objData.Rows(0)("CMEDTR")
                objEntidad.HRAINI = objData.Rows(0)("HRAINI")
                objEntidad.HRAFIN = objData.Rows(0)("HRAFTR")

              
                objEntidad.CMNFLTDESC = objData.Rows(0)("MONEDA_FLETE")
                objEntidad.CUNDMD_DESC = objData.Rows(0)("UNI_MED")

                'objEntidad.UBIGEO_O = objData.Rows(0)("UBIGEO_ORIGEN")
                'objEntidad.UBIGEO_D = objData.Rows(0)("UBIGEO_DESTINO")

                objEntidad.FLGAPA = objData.Rows(0)("FLGAPA")

 
            End If
            Return objEntidad
        End Function



        'Nuevo
        Public Function Validar_Margen_Operacion(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As DataSet
            Dim ds As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CCMPN", objEntidad.pCCMPN_Compania)
            lobjParams.Add("IN_CTRMNC", objEntidad.pCTRSPT)
            lobjParams.Add("IN_GUIATR", objEntidad.pNGUIRM_NroGuiaTransportista)
            lobjParams.Add("IN_TIPO_VIAJE", objEntidad.pTIPVIAJ)
            lobjParams.Add("IN_NRO_VIAJE", objEntidad.pNOPRCN_NroOperacion)
            ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_VALIDAR_MARGEN_OPERACION", lobjParams)
            Return ds
        End Function

        Public Sub Enviar_Aprobar_Operacion(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision)

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", objEntidad.pCCMPN_Compania)
            lobjParams.Add("PNCTRMNC", objEntidad.pCTRSPT)
            lobjParams.Add("PNGUIATR", objEntidad.pNGUIRM_NroGuiaTransportista)
            lobjParams.Add("PSTIPOVJE", objEntidad.pTIPVIAJ)
            lobjParams.Add("PNNROVJE", objEntidad.pNROVIAJ)
            lobjParams.Add("PNMRGAPROB", objEntidad.pMRGPOR)
            lobjParams.Add("PNNLBFLT", objEntidad.pNLBFLT)
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_ENVIAR_APROBACION_OPERACION", lobjParams)

        End Sub

        Public Function Listar_Operacion_Pendiente_Aprobacion_MRG(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", objEntidad.pCCMPN_Compania)
            objParam.Add("IN_CDVSN", objEntidad.pCDVSN_Division)
            objParam.Add("IN_TIPO_VIAJE", objEntidad.pTIPVIAJ)
            objParam.Add("IN_NRO_VIAJE", objEntidad.pNROVIAJ)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_PENDIENTE_APROBACION_MRG", objParam)
            Return dt
        End Function
        Public Function Listar_ServicioXViaje(ByVal objEntidad As TD_obj_ListarServicioXViaje) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", objEntidad.pCCMPN)
            objParam.Add("IN_CDVSN", objEntidad.pCDVSN)
            objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC)
            objParam.Add("IN_NGUITR", objEntidad.pNGUITR)
            objParam.Add("IN_TIPO_VIAJE", objEntidad.pTIPVIAJ)
            objParam.Add("IN_NRO_VIAJE", objEntidad.pNROVIAJ)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_X_VIAJE", objParam)
            Return dt
        End Function



        'Public Function Actualizar_Status_Seguiniento_Aprobacion(ByVal objEntidad As TD_obj_ActualizarStatusSeguinientoAprobacion) As Integer
        '    Dim intNumReg As Integer
        '    Dim dt As DataTable
        '    Dim objParam As New Parameter
        '    objParam.Add("IN_CCMPN", objEntidad.pCCMPN)
        '    objParam.Add("IN_CDVSN", objEntidad.pCDVSN)
        '    objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC)
        '    objParam.Add("IN_NGUITR", objEntidad.pNGUITR)
        '    objParam.Add("IN_TIPO_VIAJE", objEntidad.pTIPVIAJ)
        '    objParam.Add("IN_NRO_VIAJE", objEntidad.pNROVIAJ)
        '    'objParam.Add("PSAPRBOP", objEntidad.pAPRBOP)
        '    'objParam.Add("PNFCHAPR", objEntidad.pFCHAPR)
        '    'objParam.Add("PSOBSAPR", objEntidad.pOBSAPR)
        '    objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
        '    objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        '    dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_X_VIAJE", objParam)
        '    intNumReg = 1
        '    Return intNumReg
        'End Function


        Public Function Listar_datos_Guia_por_Liquidar(ByVal objetoParametro As Hashtable) As GuiaTransportista
            Dim dt As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
            objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
            'objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
            'objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
            'objParam.Add("PSFTRTSG", objetoParametro("PSFTRTSG"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GET_CARGA_GUIA_TRANSPORTISTA", objParam)
            Dim objEntidad As New GuiaTransportista



            If dt.Rows.Count > 0 Then
                objEntidad.CCLNT = dt.Rows(0)("CCLNT")
                objEntidad.NOPRCN = dt.Rows(0)("NOPRCN")
                objEntidad.CTRMNC = dt.Rows(0)("CTRMNC")
                objEntidad.NGUIRM = dt.Rows(0)("NGUIRM")
                objEntidad.NGUITS = dt.Rows(0)("NGUITS")
                objEntidad.NPLNMT = dt.Rows(0)("NPLNMT")
                objEntidad.CLCLOR = dt.Rows(0)("CLCLOR")
                objEntidad.CLCLDS = dt.Rows(0)("CLCLDS")
                objEntidad.TCMLCO = dt.Rows(0)("TCMLCO").ToString.Trim
                objEntidad.TCMLCD = dt.Rows(0)("TCMLCD").ToString.Trim
                objEntidad.NOPRCN = dt.Rows(0)("NOPRCN")
                objEntidad.CTRSPT = dt.Rows(0)("CTRSPT")
                objEntidad.TCMTRT = dt.Rows(0)("TCMTRT").ToString.Trim
                objEntidad.NPLCTR = dt.Rows(0)("NPLCTR").ToString.Trim
                objEntidad.NPLCAC = dt.Rows(0)("NPLCAC").ToString.Trim
                objEntidad.CBRCNT = dt.Rows(0)("CBRCNT").ToString.Trim
                objEntidad.CMRCDR = dt.Rows(0)("CMRCDR")
                objEntidad.TCMRCD = dt.Rows(0)("TCMRCD").ToString.Trim
                objEntidad.QGLGSL = dt.Rows(0)("QGLGSL")
                objEntidad.QGLDSL = dt.Rows(0)("QGLDSL")
                objEntidad.NRHJCR = dt.Rows(0)("NRHJCR")
                objEntidad.QKMREC = dt.Rows(0)("QKMREC")
                objEntidad.QMRCMC = dt.Rows(0)("QMRCMC")
                objEntidad.PMRCMC = dt.Rows(0)("PMRCMC")
                objEntidad.QPSOBR = dt.Rows(0)("QPSOBR")
                objEntidad.QVLMOR = dt.Rows(0)("QVLMOR")
                objEntidad.NOREMB = dt.Rows(0)("NOREMB").ToString.Trim
                objEntidad.SSINVJ = dt.Rows(0)("SSINVJ").ToString.Trim
                objEntidad.NRUCTR = dt.Rows(0)("NRUCTR")
                'objEntidad.FGUIRM_S = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FGUIRM"))
                'objEntidad.TDIROR = dt.Rows(0)("TDIROR").ToString.Trim
                'objEntidad.TDIRDS = dt.Rows(0)("TDIRDS").ToString.Trim
                'objEntidad.TRFRGU = dt.Rows(0)("TRFRGU").ToString.Trim
                'objEntidad.CUNDMD = dt.Rows(0)("CUNDMD").ToString.Trim
                'objEntidad.TNMBRM = dt.Rows(0)("TNMBRM").ToString.Trim
                'objEntidad.TDRCRM = dt.Rows(0)("TDRCRM").ToString.Trim
                'objEntidad.TPDCIR = dt.Rows(0)("TPDCIR").ToString.Trim
                'objEntidad.NRUCRM = dt.Rows(0)("NRUCRM")
                'objEntidad.TNMBCN = dt.Rows(0)("TNMBCN").ToString.Trim
                'objEntidad.TDRCNS = dt.Rows(0)("TDRCNS").ToString.Trim
                'objEntidad.TPDCIC = dt.Rows(0)("TPDCIC").ToString.Trim
                'objEntidad.NRUCCN = dt.Rows(0)("NRUCCN")
                'objEntidad.SACRGO = dt.Rows(0)("SACRGO").ToString.Trim
                'objEntidad.CMNFLT = dt.Rows(0)("CMNFLT")
                'objEntidad.SESTRG = dt.Rows(0)("SESTRG").ToString.Trim
                'objEntidad.FLGADC = dt.Rows(0)("FLGADC").ToString.Trim
                'objEntidad.SIDAVL = dt.Rows(0)("SIDAVL").ToString.Trim
                'objEntidad.ICSTRM = dt.Rows(0)("ICSTRM")
                'objEntidad.SMRPLG = dt.Rows(0)("SMRPLG").ToString.Trim
                'objEntidad.SMRPRC = dt.Rows(0)("SMRPRC").ToString.Trim
                'objEntidad.IVLPRT = dt.Rows(0)("IVLPRT")
                'objEntidad.CMNVLP = dt.Rows(0)("CMNVLP")
                'objEntidad.CCMPN = dt.Rows(0)("CCMPN").ToString.Trim
                'objEntidad.CDVSN = dt.Rows(0)("CDVSN").ToString.Trim
                'objEntidad.CPLNDV = dt.Rows(0)("CPLNDV")
                'objEntidad.CUBORI = dt.Rows(0)("CUBORI")
                'objEntidad.CUBDES = dt.Rows(0)("CUBDES")
                'objEntidad.FEMVLH = dt.Rows(0)("FEMVLH")
                'objEntidad.FEMVLH_S = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FEMVLH_S"))
                'objEntidad.FCHFTR_S = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FCHFTR_S"))
                'objEntidad.FECETA_S = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FECETA_S"))
                'objEntidad.FECETD_S = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FECETD_S"))
                'objEntidad.RUTA = dt.Rows(0)("RUTA").ToString.Trim
                'objEntidad.CBRCND = dt.Rows(0)("CBRCND").ToString.Trim
                'objEntidad.TCNFVH = dt.Rows(0)("TCNFVH").ToString.Trim
                'objEntidad.TCNFG1 = dt.Rows(0)("TCNFG1").ToString.Trim
                'objEntidad.TCNFG2 = dt.Rows(0)("TCNFG2").ToString.Trim
                'objEntidad.SESGRP = dt.Rows(0)("SESGRP").ToString.Trim
                'objEntidad.NORSRT = dt.Rows(0)("NORSRT").ToString.Trim
                'objEntidad.TCMPCL = dt.Rows(0)("TCMPCL").ToString.Trim
                'objEntidad.NCSOTR = dt.Rows(0)("NCSOTR").ToString.Trim
                'objEntidad.QSLCIT = dt.Rows(0)("QSLCIT").ToString.Trim
                'objEntidad.NDCORM = dt.Rows(0)("NDCORM").ToString.Trim
                'objEntidad.NMVJCS = dt.Rows(0)("NMVJCS").ToString.Trim
                'objEntidad.NRUCTR = dt.Rows(0)("NRUCTR")
                'objEntidad.FLGSTA = dt.Rows(0)("FLGSTA").ToString.Trim
                'objEntidad.PLANTA_FACT = dt.Rows(0)("PLANTA_FACT") 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                'objEntidad.PLANTA = dt.Rows(0)("PLANTA") ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                'objEntidad.CRGVTA = dt.Rows(0)("CRGVTA").ToString.Trim
                'objEntidad.CCLNT = dt.Rows(0)("CCLNT")
                'objEntidad.FTRTSG = dt.Rows(0)("FTRTSG").ToString.Trim

            End If

            Return objEntidad
        End Function


        Public Sub Cancelar_Envio_Aprobacion_Viaje(ByVal objEntidad As TD_obj_ActualizarStatusSeguinientoAprobacion)

            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.pCCMPN)
            objParam.Add("PNCTRMNC", objEntidad.pCTRMNC)
            objParam.Add("PNGUIATR", objEntidad.pNGUITR)
            objParam.Add("PSTIPOVJE", objEntidad.pTIPVIAJ)
            objParam.Add("PNNROVJE", objEntidad.pNROVIAJ)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CANCELAR_ENVIO_APROBACION_VIAJE", objParam)

        End Sub


        Public Sub Aceptar_Envio_Aprobacion_Viaje(ByVal objEntidad As TD_obj_ActualizarStatusSeguinientoAprobacion)
            'Dim intNumReg As Integer
            'Dim dt As DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.pCCMPN)
            objParam.Add("PNCTRMNC", objEntidad.pCTRMNC)
            objParam.Add("PNGUIATR", objEntidad.pNGUITR)
            objParam.Add("PSTIPOVJE", objEntidad.pTIPVIAJ)
            objParam.Add("PNNROVJE", objEntidad.pNROVIAJ)
            objParam.Add("PSAPRBOP", objEntidad.pAPRBOP)
            objParam.Add("PNFCHAPR", objEntidad.pFCHAPR)
            objParam.Add("PSOBSAPR", objEntidad.pOBSAPR)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACEPTAR_ENVIO_APROBACION_VIAJE", objParam)
            'intNumReg = 1
            'Return intNumReg
        End Sub



        Public Function Obtener_Informacion_Recurso_Guia_Transporte(pCCMPN As String, pNoprcn As Decimal, pNCSOTR As Decimal, pNCRRSR As Decimal) As GuiaTransportista
            'Try
            Dim obeGuiaTransportista As New GuiaTransportista
            Dim dt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PNNOPRCN", pNoprcn)
            objParam.Add("PNNCSOTR", pNCSOTR)
            objParam.Add("PNNCRRSR", pNCRRSR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pCCMPN)


            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFORMACION_RECURSO_GUIA_TRANSPORTISTA", objParam)
            If dt.Rows.Count > 0 Then
                obeGuiaTransportista.NPLNMT = dt.Rows(0)("NPLNMT")
                obeGuiaTransportista.CLCLOR = dt.Rows(0)("CLCLOR")
                obeGuiaTransportista.CLCLDS = dt.Rows(0)("CLCLDS")
                obeGuiaTransportista.QMRCMC = dt.Rows(0)("QMRCDR")
                obeGuiaTransportista.CUNDMD = dt.Rows(0)("CUNDMD")
                obeGuiaTransportista.CMNFLT = dt.Rows(0)("CMNFLT")
                obeGuiaTransportista.QKMREC = dt.Rows(0)("QKMREC")
                obeGuiaTransportista.TNMBRM = dt.Rows(0)("PSTNMBRM").ToString.Trim
                obeGuiaTransportista.TDRCRM = dt.Rows(0)("PSTDRCRM").ToString.Trim
                obeGuiaTransportista.TPDCIR = dt.Rows(0)("PSTPDCIR").ToString.Trim
                obeGuiaTransportista.NRUCRM = dt.Rows(0)("PNNRUCRM")
                obeGuiaTransportista.CCLNT = dt.Rows(0)("CCLNT")
                obeGuiaTransportista.CUBORI = dt.Rows(0)("CUBORI")
                obeGuiaTransportista.CUBDES = dt.Rows(0)("CUBDES")
                obeGuiaTransportista.CMNFLTDESC = dt.Rows(0)("CMNFLTDESC")
                'obeGuiaTransportista.TNMBCN = objEntidad.TNMBRM
                'obeGuiaTransportista.TDRCNS = objEntidad.TDRCRM
                'obeGuiaTransportista.TPDCIC = objEntidad.TPDCIR
                'obeGuiaTransportista.NRUCCN = objEntidad.NRUCRM
                obeGuiaTransportista.TNMBCN = obeGuiaTransportista.TNMBRM
                obeGuiaTransportista.TDRCNS = obeGuiaTransportista.TDRCRM
                obeGuiaTransportista.TPDCIC = obeGuiaTransportista.TPDCIR
                obeGuiaTransportista.NRUCCN = obeGuiaTransportista.NRUCRM
                obeGuiaTransportista.TCNFVH = dt.Rows(0)("PSTCNFVH").ToString.Trim
                If obeGuiaTransportista.TCNFVH = "0" OrElse obeGuiaTransportista.TCNFVH = "" Then obeGuiaTransportista.TCNFVH = ""
                obeGuiaTransportista.CCNCST = dt.Rows(0)("CCNCST")
                obeGuiaTransportista.TDSCAR = dt.Rows(0)("TDSCAR").ToString.Trim
                If obeGuiaTransportista.TDSCAR.Length > 30 Then
                    obeGuiaTransportista.TDSCAR = obeGuiaTransportista.TDSCAR.Substring(0, 30)
                End If
                obeGuiaTransportista.CUNDMD_DESC = dt.Rows(0)("UM_DESC").ToString.Trim

                obeGuiaTransportista.TCMTRT = dt.Rows(0)("TCMTRT").ToString.Trim
                obeGuiaTransportista.CTRMNC = dt.Rows(0)("CTRMNC")

                obeGuiaTransportista.TDIROR = dt.Rows(0)("TDIROR")
                obeGuiaTransportista.TDIRDS = dt.Rows(0)("TDIRDS")
                obeGuiaTransportista.CMEDTR = dt.Rows(0)("CMEDTR")
                obeGuiaTransportista.CTPOVJ = dt.Rows(0)("CTPOVJ")
                'QMRCDR
                obeGuiaTransportista.NPLCTR = ("" & dt.Rows(0)("NPLCTR")).ToString.Trim
                obeGuiaTransportista.NPLCAC = dt.Rows(0)("NPLCAC")
                obeGuiaTransportista.CBRCNT = ("" & dt.Rows(0)("CBRCNT")).ToString.Trim
                obeGuiaTransportista.CBRCND = ("" & dt.Rows(0)("CBRCND")).ToString.Trim
                obeGuiaTransportista.NRUCTR = dt.Rows(0)("NRUCTR")

                obeGuiaTransportista.TCMLCO = ("" & dt.Rows(0)("TCMLCO")).ToString.Trim
                obeGuiaTransportista.TCMLCD = ("" & dt.Rows(0)("TCMLCD")).ToString.Trim
                obeGuiaTransportista.UBIGEO_O = ("" & dt.Rows(0)("UBIGEO_ORIGEN")).ToString.Trim
                obeGuiaTransportista.UBIGEO_D = ("" & dt.Rows(0)("UBIGEO_DESTINO")).ToString.Trim
              

            End If


            Return obeGuiaTransportista
        End Function

        'nuevo
        Public Function Lista_Historial_Liquidacion(ByVal objEntidad As TD_obj_Historial_Liquidacion) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_TIPO_LISTADO", objEntidad.pTIPO_LISTADO)
            objParam.Add("IN_CCMPN", objEntidad.pCCMPN)
            objParam.Add("IN_CDVSN", objEntidad.pCDVSN)
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN)
            objParam.Add("IN_FINCOP_INI", objEntidad.pFINCOP_INI)
            objParam.Add("IN_FINCOP_FIN", objEntidad.pFINCOP_FIN)

            objParam.Add("IN_CDUPSP", objEntidad.pCDUPSP)
            objParam.Add("IN_CCLNT", objEntidad.pCCLNT)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_HISTORIAL_LIQUIDACIONES", objParam)


            If objEntidad.pTIPO_LISTADO = "HSV" Then
                For Each item As DataRow In dt.Rows
                    item("FECHA_C") = HelpClass.CNumero8Digitos_a_Fecha(item("FECHA_C"))
                    item("HRACRT") = HelpClass.HoraNum_a_Hora(item("HRACRT"))
                Next
             
            End If
            If objEntidad.pTIPO_LISTADO = "HMR" Then
                For Each item As DataRow In dt.Rows
                    item("FECHA_SEG") = HelpClass.CNumero8Digitos_a_Fecha(item("FECHA_SEG"))
                    item("HORA_SEG") = HelpClass.HoraNum_a_Hora(item("HORA_SEG"))
                Next
            End If


          

            Return dt
        End Function
        Public Function Lista_Detalle_Liquidacion(ByVal objEntidad As TD_obj_Detalle_Liquidacion) As DataTable
            Dim dt As DataTable
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", objEntidad.pCCMPN)
            objParam.Add("IN_CDVSN", objEntidad.pCDVSN)
            objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN)
            objParam.Add("IN_FECHA_INI", objEntidad.pFECHA_INI)
            objParam.Add("IN_FECHA_FIN", objEntidad.pFECHA_FIN)
            objParam.Add("IN_CPLNDV", objEntidad.pCPLNDV)

            objParam.Add("IN_CDUPSP", objEntidad.pCDUPSP)
            objParam.Add("IN_CCLNT", objEntidad.pCCLNT)

   
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DETALLE_LIQUIDACIONES", objParam)

            Return dt
        End Function

        Public Function Es_Operacion_Servicio_Flete(pCCMPN As String, pNOPRCN As Decimal) As Boolean
            Dim dt As DataTable
            Dim esOpServicioFlete As Boolean = False
            Dim objParam As New Parameter
            objParam.Add("IN_CCMPN", pCCMPN)
            objParam.Add("IN_NOPRCN", pNOPRCN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_OS", objParam)
            If dt.Rows.Count > 0 Then
                esOpServicioFlete = True
            End If
            Return esOpServicioFlete
        End Function


        Public Function Listar_Peso_Neto_Guia_Transporte_Por_Almacen(ByVal objEntidad As GuiaTransportista, ByRef pesoGT As Decimal) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim ds As New DataSet

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)


            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_PESO_NETO_GUIA_TRANSPORTE_POR_ALMACEN", objParam)
            dt = ds.Tables(0)

            pesoGT = ds.Tables(1).Rows(0)("PMRCMC")

            Return dt

        End Function

        Public Function Actualizar_Peso_Neto_Guia_Transporte_Por_Almacen(ByVal objEntidad As GuiaTransportista) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNPMRCMC", objEntidad.PMRCMC)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ACTUALIZAR_PESO_NETO_GUIA_TRANSPORTE_POR_ALMACEN", objParam)

            Return dt

        End Function

        Public Function Actualizar_Peso_Neto_Guia_Transporte_Anexas_Por_Almacen(ByVal objEntidad As GuiaTransportista) As DataTable

            Dim objParam As New Parameter
            Dim dt As New DataTable

            objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNNRGUCL", objEntidad.NRGUCL)

            objParam.Add("PNPSOVOL", objEntidad.QPSOBR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ACTUALIZAR_PESO_NETO_GUIA_TRANSPORTE_ANEXAS_POR_ALMACEN", objParam)

            Return dt

        End Function



    End Class
End Namespace
