Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario

Namespace Operaciones
    Public Class Solicitud_Transporte_DAL
        Private objSql As New SqlManager

        Public Function Registrar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte, ByRef msg As String) As Solicitud_Transporte

            Dim objParam As New Parameter

            objParam.Add("PARAM_NORSRT", objEntidad.NORSRT)
            objParam.Add("PARAM_FECOST", objEntidad.FECOST)
            objParam.Add("PARAM_HRAOTR", objEntidad.HRAOTR)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objParam.Add("PARAM_CUNDVH", objEntidad.CUNDVH)
            objParam.Add("PARAM_CMRCDR", objEntidad.CMRCDR)
            objParam.Add("PARAM_QMRCDR", objEntidad.QMRCDR)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QSLCIT", objEntidad.QSLCIT)
            objParam.Add("PARAM_QATNAN", objEntidad.QATNAN)
            objParam.Add("PARAM_FINCRG", objEntidad.FINCRG)
            objParam.Add("PARAM_HINCIN", objEntidad.HINCIN)
            objParam.Add("PARAM_FENTCL", objEntidad.FENTCL)
            objParam.Add("PARAM_HRAENT", objEntidad.HRAENT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_TDRCOR", objEntidad.TDRCOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDRENT", objEntidad.TDRENT)
            objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
            objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)


            objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)


            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_SFCRTV", objEntidad.SFCRTV)
            'OJO FALTA AGREGAR EN PRODUCCION
            objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
            objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_CCTCSC", objEntidad.CCTCSC)
            objParam.Add("PARAM_TRFRN", objEntidad.TRFRN)
            objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("PARAM_SPRSTR", objEntidad.SPRSTR)

            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)

            objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
            objParam.Add("PSCTIPCG", objEntidad.CTIPCG)
            

            objParam.Add("PNFATNSR", objEntidad.FATNSR)
            objParam.Add("PNHATNSR", objEntidad.HATNSR)
            objParam.Add("PSTPSOTR", objEntidad.TPSOTR)




            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)


            'ejecuta el procedimiento almacenado
            Dim dt As New DataTable

            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_SOLICITUD_TRANSPORTE", objParam)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_SOLICITUD_TRANSPORTE", objParam)

            msg = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT")
                End If
            Next
            msg = msg.Trim

            If msg = "" Then
                objEntidad.NCSOTR = dt.Rows(0)("NCSOTR")
            End If
           
            Return objEntidad
        End Function

        Public Function Modificar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NCSOTR", objEntidad.NCSOTR)
            objParam.Add("PARAM_NORSRT", objEntidad.NORSRT)
            objParam.Add("PARAM_FECOST", objEntidad.FECOST)
            objParam.Add("PARAM_HRAOTR", objEntidad.HRAOTR)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objParam.Add("PARAM_CUNDVH", objEntidad.CUNDVH)
            objParam.Add("PARAM_CMRCDR", objEntidad.CMRCDR)
            objParam.Add("PARAM_QMRCDR", objEntidad.QMRCDR)
            objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
            objParam.Add("PARAM_QSLCIT", objEntidad.QSLCIT)

            objParam.Add("PARAM_FINCRG", objEntidad.FINCRG)
            objParam.Add("PARAM_HINCIN", objEntidad.HINCIN)
            objParam.Add("PARAM_FENTCL", objEntidad.FENTCL)
            objParam.Add("PARAM_HRAENT", objEntidad.HRAENT)
            objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("PARAM_TDRCOR", objEntidad.TDRCOR)
            objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
            objParam.Add("PARAM_TDRENT", objEntidad.TDRENT)
            objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
           
            objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
            objParam.Add("PARAM_TOBS", objEntidad.TOBS)
            objParam.Add("PARAM_SFCRTV", objEntidad.SFCRTV)
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_CMEDTR", objEntidad.CMEDTR)
            objParam.Add("PARAM_CCTCSC", objEntidad.CCTCSC)
            objParam.Add("PARAM_TRFRN", objEntidad.TRFRN)
            objParam.Add("PARAM_SPRSTR", objEntidad.SPRSTR)

            objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
            objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)

            objParam.Add("PSCTTRAN", objEntidad.CTTRAN)
            objParam.Add("PSCTIPCG", objEntidad.CTIPCG)
          

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_SOLICITUD_TRANSPORTE_1", objParam)
           
            Return objEntidad
        End Function

        

        Public Function Cambiar_Estado_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte)

            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
         
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CAMBIAR_ESTADO_SOLC_TRANSP", objParam)
            
            Return objEntidad
        End Function

        Public Function Eliminar_Solicitud_Transporte_Reparto(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte

            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNPLNMT", objEntidad.NPLNMT)
            objParam.Add("OURESULT", 0, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SOLICITUD_TRANSPORTE_REPARTO", objParam)
            objEntidad.NCRRSR = objSql.ParameterCollection("OURESULT")
          
            Return objEntidad
        End Function



        Public Function Listar_Solicitudes_Transporte_Export(ByVal objParametros As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", objParametros.NCSOTR) 'objParametros(0)
            objParam.Add("PNCCLNT", objParametros.CCLNT) 'objParametros(1)
            objParam.Add("PSSESSLC", objParametros.SESSLC) 'objParametros(2)
            objParam.Add("PSSESTRG", objParametros.SESTRG)

            objParam.Add("PNFECINI", objParametros.FE_INI) 'objParametros(3)
            objParam.Add("PNFECFIN", objParametros.FE_FIN) 'objParametros(4)

            objParam.Add("PNCMEDTR", objParametros.CMEDTR)  'objParametros(5)
            objParam.Add("PSCCMPN", objParametros.CCMPN)  'objParametros(6)
            objParam.Add("PSCDVSN", objParametros.CDVSN)  'objParametros(7)
            objParam.Add("PSCPLNDV", objParametros.CPLNDV) 'objParametros(8)
            objParam.Add("PNNOPRCN", objParametros.NOPRCN) 'objParametros(8)
            objParam.Add("PSCURSCRT", objParametros.CUSCRT)
            objParam.Add("PSTRFRN", objParametros.TRFRN)
            objParam.Add("PSSPRSTR", objParametros.SPRSTR)
            objParam.Add("PNNUMREQT", objParametros.NUMREQT)
            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_LM_Export", objParam)

            For Each dc As DataColumn In objDataTable.Columns
                dc.ColumnName = dc.ColumnName.Replace("""", "")
            Next

            For Each dr As DataRow In objDataTable.Rows
                dr.Item("Fecha Solicitud") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Solicitud").ToString)
                dr.Item("Fecha Carga") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Carga").ToString)
                dr.Item("Fecha Entrega") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Entrega").ToString)
            Next

          
            Return objDataTable
        End Function

        Public Function Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(ByVal objParametros As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objParametros.CCMPN)
            objParam.Add("PSCDVSN", objParametros.CDVSN)
            objParam.Add("PNCPLNDV", objParametros.CPLNDV)
            objParam.Add("PNCCLNT", objParametros.CCLNT)

            objParam.Add("PNFECOST_INI", objParametros.FE_INI)
            objParam.Add("PNFECOST_FIN", objParametros.FE_FIN)
            objParam.Add("PNHRAOTR_INI", objParametros.HR_INI)
            objParam.Add("PNHRAOTR_FIN", objParametros.HR_FIN)

            objParam.Add("PNNCSOTR", CDec(objParametros.NCSOTR))
            objParam.Add("PSCUSCRT", objParametros.CUSCRT)

            objParam.Add("PNCMEDTR", objParametros.CMEDTR)
            objParam.Add("PSSPRSTR", objParametros.SPRSTR)
            objParam.Add("PSSESSLC", objParametros.SESSLC)
            objParam.Add("PNNUMREQT", objParametros.NUMREQT)

            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_REPORT", objParam)

            For Each dc As DataColumn In objDataTable.Columns
                dc.ColumnName = dc.ColumnName.Replace("""", "")
            Next

            For Each dr As DataRow In objDataTable.Rows
                dr.Item("Fecha Solicitud") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Solicitud").ToString)
                dr.Item("Fecha Carga") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Carga").ToString)
                dr.Item("Fecha Entrega") = HelpClass.CFecha_de_8_a_10(dr.Item("Fecha Entrega").ToString)
            Next

          
            Return objDataTable
        End Function


      

        Public Function Listar_Solicitudes_Transporte_Estado(ByVal objParametros As Solicitud_Transporte) As List(Of Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            Dim objDatos As Solicitud_Transporte

            objParam.Add("PNNCSOTR", objParametros.NCSOTR) 'objParametros(0)
            objParam.Add("PNCCLNT", objParametros.CCLNT) 'objParametros(1)
            objParam.Add("PSSESSLC", objParametros.SESSLC) 'objParametros(2)
            objParam.Add("PSSESTRG", objParametros.SESTRG)

            objParam.Add("PNFECINI", objParametros.FE_INI) 'objParametros(3)
            objParam.Add("PNFECFIN", objParametros.FE_FIN) 'objParametros(4)


            objParam.Add("PNHRAOTR_INI", objParametros.HR_INI) 'objParametros(3)
            objParam.Add("PNHRAOTR_FIN", objParametros.HR_FIN) 'objParametros(4)

            objParam.Add("PNCMEDTR", objParametros.CMEDTR)  'objParametros(5)
            objParam.Add("PSCCMPN", objParametros.CCMPN)  'objParametros(6)
            objParam.Add("PSCDVSN", objParametros.CDVSN)  'objParametros(7)
            objParam.Add("PSCPLNDV", objParametros.CPLNDV) 'objParametros(8)
            objParam.Add("PNNOPRCN", objParametros.NOPRCN) 'objParametros(8)
            objParam.Add("PSCURSCRT", objParametros.CUSCRT)
            objParam.Add("PSTRFRN", objParametros.TRFRN)
            objParam.Add("PSSPRSTR", objParametros.SPRSTR)

            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_LA_V2", objParam)

            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New Solicitud_Transporte
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.FECOST = HelpClass.CFecha_de_8_a_10(objData("FECOST").ToString).ToString.Trim
                objDatos.HRAOTR = HelpClass.HoraNum_a_Hora(objData("HRAOTR")).ToString.Trim
                objDatos.FINCRG = HelpClass.CFecha_de_8_a_10(objData("FINCRG").ToString).ToString.Trim
                objDatos.HINCIN = HelpClass.HoraNum_a_Hora(objData("HINCIN")).ToString.Trim
                objDatos.FENTCL = HelpClass.CFecha_de_8_a_10(objData("FENTCL").ToString).ToString.Trim
                objDatos.HRAENT = HelpClass.HoraNum_a_Hora(objData("HRAENT")).ToString.Trim
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
                objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
                objDatos.QANPRG = objData("QANPRG")
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.SESSLC = objData("SESSLC").ToString.Trim
                objDatos.NORSRT = objData("NORSRT").ToString.Trim
                objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
                If objData("TOBS").ToString.Trim.Length > 50 Then
                    objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
                Else
                    objDatos.TOBS = objData("TOBS").ToString.Trim
                End If
                objDatos.CANTOP = objData("CANTOP").ToString.Trim
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
                objDatos.CDVSN = objData("CDVSN").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.SFCRTV = objData("SFCRTV").ToString.Trim
                objDatos.CCTCSC = objData("CCTCSC").ToString.Trim
                objDatos.CMEDTR = objData("CMEDTR").ToString.Trim
                objDatos.TNMMDT = objData("TNMMDT").ToString.Trim
                objDatos.CLCLOR_C = objData("CLCLOR_C")
                objDatos.CLCLDS_C = objData("CLCLDS_C")
                objDatos.CUSCRT = objData("CUSCRT")
                objDatos.TRFRN = objData("TRFRN")
                objDatos.SESTRG = objData("SESTRG")
                objDatos.FULTAC = objData("CULUSA").ToString & " - " & HelpClass.CNumero8Digitos_a_Fecha(objData("FULTAC")).ToString & " - " & HelpClass.HoraNum_a_Hora(objData("HULTAC")).ToString
                objDatos.SPRSTR = objData("SPRSTR")
                'objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

                objDatos.CUBORI = objData("CUBORI")
                objDatos.UBIGEO_O = objData("UBIGEO_O").ToString.Trim
                objDatos.CUBDES = objData("CUBDES")
                objDatos.UBIGEO_D = objData("UBIGEO_D").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
            
            Return objGenericCollection
        End Function


        Public Function Listar_Solicitudes_Transporte_Estado_Requerimiento(ByVal objParametros As Solicitud_Transporte) As List(Of Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            Dim objDatos As Solicitud_Transporte

            objParam.Add("PNNUMREQT", objParametros.NUMREQT)
            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_LA_REQ", objParam)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New Solicitud_Transporte
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.FECOST = HelpClass.CFecha_de_8_a_10(objData("FECOST").ToString).ToString.Trim
                objDatos.HRAOTR = HelpClass.HoraNum_a_Hora(objData("HRAOTR")).ToString.Trim
                objDatos.FINCRG = HelpClass.CFecha_de_8_a_10(objData("FINCRG").ToString).ToString.Trim
                objDatos.HINCIN = HelpClass.HoraNum_a_Hora(objData("HINCIN")).ToString.Trim
                objDatos.FENTCL = HelpClass.CFecha_de_8_a_10(objData("FENTCL").ToString).ToString.Trim
                objDatos.HRAENT = HelpClass.HoraNum_a_Hora(objData("HRAENT")).ToString.Trim
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
                objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
                objDatos.QANPRG = objData("QANPRG")
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.SESSLC = objData("SESSLC").ToString.Trim
                objDatos.NORSRT = objData("NORSRT").ToString.Trim
                objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
                If objData("TOBS").ToString.Trim.Length > 50 Then
                    objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
                Else
                    objDatos.TOBS = objData("TOBS").ToString.Trim
                End If
                objDatos.CANTOP = objData("CANTOP").ToString.Trim
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
                objDatos.CDVSN = objData("CDVSN").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.SFCRTV = objData("SFCRTV").ToString.Trim
                objDatos.CCTCSC = objData("CCTCSC").ToString.Trim
                objDatos.CMEDTR = objData("CMEDTR").ToString.Trim
                objDatos.TNMMDT = objData("TNMMDT").ToString.Trim
                objDatos.CLCLOR_C = objData("CLCLOR_C")
                objDatos.CLCLDS_C = objData("CLCLDS_C")
                objDatos.CUSCRT = objData("CUSCRT")
                objDatos.TRFRN = objData("TRFRN")
                objDatos.SESTRG = objData("SESTRG")
                objDatos.FULTAC = objData("CULUSA").ToString & " - " & HelpClass.CNumero8Digitos_a_Fecha(objData("FULTAC")).ToString & " - " & HelpClass.HoraNum_a_Hora(objData("HULTAC")).ToString
                objDatos.SPRSTR = objData("SPRSTR")
                'objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

                objDatos.CUBORI = objData("CUBORI")
                objDatos.UBIGEO_O = objData("UBIGEO_O").ToString.Trim
                objDatos.CUBDES = objData("CUBDES")
                objDatos.UBIGEO_D = objData("UBIGEO_D").ToString.Trim

                objDatos.NDCORM = Val(objData("NDCORM").ToString.Trim)
                objDatos.NUMREQT = Val(objData("NUMREQT").ToString.Trim)
                objDatos.UNIDADES = Val(objData("UNIDADES"))
                objGenericCollection.Add(objDatos)
            Next
            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Transporte_Estado(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objParam As New Parameter
            Dim objDatos As GuiaTransportista
            Dim objListaDr As DataRow()

            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCDVSN", objEntidad("CDVSN"))
            objParam.Add("PSCPLNDV", objEntidad("CPLNDV"))
            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNCMEDTR", objEntidad("CMEDTR"))
            objParam.Add("PSTIPOBUSQ", objEntidad("TIPOBUSQ"))
            objParam.Add("PSDOCBUSQ", objEntidad("DOCBUSQ"))
            objParam.Add("PNCTRSPT", objEntidad("CTRSPT"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PSFLFECHA", objEntidad("FLFECH"))

            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))
            Dim strGuiaTransporte As String = ""
            'Obteniendo resultados
            Dim oDs As DataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_SEGUIMIENTO_TRASLADO_DIRECTO_LM_LA", objParam)

            Dim tipoGuia As String = ""
            Dim GuiaTransp As String = ""
            'Procesandolos como una Lista
            For Each objData As DataRow In oDs.Tables(1).Rows
                objDatos = New GuiaTransportista
                objDatos.CCLNT = objData("CCLNT")
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.CPLNDV_S = objData("PLANTA").ToString.Trim
                objDatos.FEMVLH_1 = HelpClass.CFecha_de_8_a_10(objData("FEMVLH_1").ToString.Trim)
                objDatos.FLGCNL = objData("FLGCNL").ToString.Trim

                objDatos.FGUIRM_S = HelpClass.CFecha_de_8_a_10(objData("FGUIRM").ToString.Trim)
                objDatos.FECETD_S = HelpClass.CFecha_de_8_a_10(objData("FECETD").ToString.Trim)
                objDatos.FECETA_S = HelpClass.CFecha_de_8_a_10(objData("FECETA").ToString.Trim)
                objDatos.FEMVLH_S = HelpClass.CFecha_de_8_a_10(objData("FEMVLH").ToString.Trim)
                objDatos.FCHFTR_S = HelpClass.CFecha_de_8_a_10(objData("FCHFTR").ToString.Trim)
                objDatos.TNMMDT = objData("MEDENVIO").ToString.Trim
                objDatos.NGUIRM = objData("NGUITR")
                'strGuiaTransporte = objData("NGUITR").ToString.PadLeft(10, "0").Trim
                'objDatos.NGUIRM_S = strGuiaTransporte.Substring(0, 3) & "-" & strGuiaTransporte.Substring(3, 7)
                objDatos.NGUIRM_S = objData("NGUITR")

                tipoGuia = ("" & objData("CTDGRT")).ToString.Trim
                GuiaTransp = ("" & objData("NGUITS")).ToString.Trim
                If GuiaTransp.Length = 10 Then
                    GuiaTransp = GuiaTransp.Substring(0, 3) & "-" & GuiaTransp.Substring(3, 7)
                End If
                'If GuiaTransp.Length = 12 Then
                '    GuiaTransp = GuiaTransp.Substring(0, 4) & "-" & GuiaTransp.Substring(4, 8)
                'End If
                If tipoGuia = "E" Then
                    GuiaTransp = GuiaTransp.Substring(0, 4) & "-" & GuiaTransp.Substring(4)
                End If

                'Select Case tipoGuia
                '    Case "F"
                '        GuiaTransp = GuiaTransp.Substring(0, 3) & "-" & GuiaTransp.Substring(3, 7)
                '    Case "E"
                '        GuiaTransp = GuiaTransp.Substring(0, 4) & "-" & GuiaTransp.Substring(4, 8)
                'End Select
                objDatos.NGUITS = GuiaTransp


                objDatos.TDIROR = objData("ORIGEN").ToString.Trim
                objDatos.TDIRDS = objData("DESTINO").ToString.Trim
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.CTRMNC = objData("CTRMNC").ToString.Trim
                objDatos.NRUCTR = objData("NRUCTR").ToString
                objDatos.NPLCTR = objData("NPLCTR").ToString.Trim
                objDatos.NPLCAC = objData("NPLCAC").ToString
                objDatos.TOBS = objData("TMRCTR").ToString.Trim
                objDatos.NCSOTR = objData("NCSOTR")
                objDatos.NCRRSR = objData("NCRRSR")
                objDatos.SEGUIMIENTO = objData("SEGUIMIENTO").ToString.Trim
                objDatos.GPSLAT = objData("GPSLAT").ToString.Trim
                objDatos.GPSLON = objData("GPSLON").ToString.Trim
                objDatos.FECGPS = objData("FECGPS").ToString.Trim
                objDatos.HORGPS = objData("HORGPS").ToString.Trim
                objDatos.NGSGWP = objData("NGSGWP").ToString.Trim
                objDatos.NCOREG = objData("NCOREG")
                objDatos.CMEDTR = objData("CMEDTR")
                objDatos.NOPRCN = objData("NOPRCN")
                objDatos.NMRGIM = objData("NMRGIM")
                objDatos.CMEDTR = objData("CMEDTR").ToString()
                objDatos.CLCLOR = objData("CLCLOR").ToString()
                objDatos.CLCLDS = objData("CLCLDS").ToString()
                objDatos.HRAINI = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(objData("HRAINI"))


                objDatos.HRAFIN = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(objData("HRAFTR"))


                '------------------------------------------------------------------------------------------------------------------------------------
                objListaDr = oDs.Tables(0).Select("CTRMNC =" & objData("CTRMNC") & " AND NGUITR =" & objData("NGUITR"))
                If objListaDr.Length > 0 Then
                    If objListaDr(0).Item(2) = 0 Then
                        objDatos.FLAG_PSOVOL = 1
                    End If
                Else
                    objDatos.FLAG_PSOVOL = 1
                End If
                '------------------------------------------------------------------------------------------------------------------------------------
                objGenericCollection.Add(objDatos)
            Next
            oOrigen = objEntidad("CLCLOR")
            oDestino = objEntidad("CLCLDS")
            If oOrigen = "" Then oOrigen = "TODOS"
            If oDestino = "" Then oDestino = "TODOS"
            If oOrigen = "TODOS" And oDestino = "TODOS" Then
                objTransporte = objGenericCollection
            Else
                objTransporte = objGenericCollection.FindAll(AddressOf findRutaOrigenDestino)
            End If

            Return objTransporte
        End Function

        Dim objTransporte As New List(Of GuiaTransportista)
        Dim oOrigen As String = ""
        Dim oDestino As String = ""

        Private Function findRutaOrigenDestino(ByVal objSolTrans As GuiaTransportista) As Boolean
            If oOrigen <> "TODOS" And oDestino = "TODOS" Then
                Return objSolTrans.TDIROR = oOrigen
            ElseIf oDestino <> "TODOS" And oOrigen = "TODOS" Then
                Return objSolTrans.TDIRDS = oDestino
            Else
                Return objSolTrans.TDIROR = oOrigen And objSolTrans.TDIRDS = oDestino
            End If
        End Function

        Public Function Listar_Solicitudes_Transporte_Multimodal(ByVal objEntidad As Multimodal) As List(Of Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            Dim objDatos As Solicitud_Transporte
            'Try
            objParam.Add("PNNMOPMM", objEntidad.NMOPMM)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SOLICITUD_X_OPERACION_MULTIMODAL", objParam)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New Solicitud_Transporte
                objDatos.NMOPMM = objData("NMOPMM").ToString.Trim
                objDatos.NCRRRT = objData("NCRRRT").ToString.Trim
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.FECOST = objData("FECOST").ToString.Trim
                objDatos.HRAOTR = objData("HRAOTR").ToString.Trim
                objDatos.FINCRG = objData("FINCRG").ToString.Trim
                objDatos.HINCIN = objData("HINCIN").ToString.Trim
                objDatos.FENTCL = objData("FENTCL").ToString.Trim
                objDatos.HRAENT = objData("HRAENT").ToString.Trim
                objDatos.CLCLOR_C = objData("CLCLOR_C")
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.CLCLDS_C = objData("CLCLDS_C")
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
                objDatos.CUNDMD_C = objData("CUNDMD_C").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
                objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.SESSLC = objData("SESSLC").ToString.Trim
                objDatos.NORSRT = objData("NORSRT").ToString.Trim
                objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
                If objData("TOBS").ToString.Trim.Length > 50 Then
                    objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
                Else
                    objDatos.TOBS = objData("TOBS").ToString.Trim
                End If
                objDatos.CANTOP = objData("CANTOP")
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
                objDatos.CDVSN = objData("CDVSN").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.SFCRTV = objData("SFCRTV")
                objDatos.TNMMDT = objData("TNMMDT")
                objDatos.CMEDTR = objData("CMEDTR")
                objDatos.DESC_NIVEL = objData("DESC_NIVEL")
                objDatos.DESC_CARGA = objData("DESC_CARGA")

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Solicitudes_Transporte_Reparto(ByVal objEntidad As Repartos) As List(Of Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            Dim objDatos As Solicitud_Transporte
            'Try
            objParam.Add("PNNMOPRP", objEntidad.NMOPRP)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)

            objParam.Add("PSCPLNDV", objEntidad.CPLNDV)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SOLICITUD_X_OPERACION_REPARTO", objParam)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New Solicitud_Transporte
                objDatos.NMOPRP = objData("NMOPRP").ToString.Trim
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.FECOST = objData("FECOST").ToString.Trim
                objDatos.HRAOTR = objData("HRAOTR").ToString.Trim
                objDatos.FINCRG = objData("FINCRG").ToString.Trim
                objDatos.HINCIN = objData("HINCIN").ToString.Trim
                objDatos.FENTCL = objData("FENTCL").ToString.Trim
                objDatos.HRAENT = objData("HRAENT").ToString.Trim
                objDatos.CLCLOR_C = objData("CLCLOR_C")
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.CLCLDS_C = objData("CLCLDS_C")
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
                objDatos.TCMRCD = objData("TCMRCD").ToString.Trim
                objDatos.CUNDMD_C = objData("CUNDMD_C").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
                objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.SESSLC = objData("SESSLC").ToString.Trim
                objDatos.NORSRT = objData("NORSRT").ToString.Trim
                objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
                If objData("TOBS").ToString.Trim.Length > 50 Then
                    objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
                Else
                    objDatos.TOBS = objData("TOBS").ToString.Trim
                End If
                objDatos.CANTOP = objData("CANTOP")
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
                objDatos.CDVSN = objData("CDVSN").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.SFCRTV = objData("SFCRTV")
                objDatos.TNMMDT = objData("TNMMDT")
                objDatos.NPLCUN = objData("NPLCUN")
                objDatos.CBRCNT = objData("CBRCNT").ToString()
                objDatos.CBRCND = objData("CBRCND").ToString()
                objDatos.NOPRCN = objData("NOPRCN")
                objDatos.NPLNMT = objData("NPLNMT")
                objDatos.NORINS = objData("NORINS")
                objDatos.SEGUIMIENTO = objData("SEGUIMIENTO").ToString.Trim
                objDatos.NGSGWP = objData("NGSGWP").ToString.Trim
                objDatos.NCOREG = objData("NCOREG")
                objDatos.CCLNFC = objData("CCLNFC")
                objDatos.CLIENTE_FACT = objData("CLIENTE_FACT")
                objDatos.CTTRAN = objData("CTTRAN")
                objDatos.CTIPCG = objData("CTIPCG")
                objDatos.DESC_NIVEL = objData("DESC_NIVEL")
                objDatos.DESC_CARGA = objData("DESC_CARGA")


                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                objDatos.TPLNTA = objData("TPLNTA")
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                objDatos.NGUITR = objData("NGUITR")

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            '    objGenericCollection = New List(Of Solicitud_Transporte)
            'End Try
            Return objGenericCollection
        End Function

        Public Function Obtener_Datos_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_SOLICITUD_TRANSPORTE", objParam)
            With objDataTable.Rows(0)
                objEntidad.FECOST = .Item("FECOST").ToString.Trim
                objEntidad.HRAOTR = .Item("HRAOTR").ToString.Trim
                objEntidad.CCLNT = .Item("CCLNT").ToString.Trim
                objEntidad.NORSRT = .Item("NORSRT").ToString.Trim
                objEntidad.CTPOSR = .Item("CTPOSR").ToString.Trim
                objEntidad.CUNDVH = .Item("CUNDVH").ToString.Trim
                objEntidad.CMRCDR = .Item("CMRCDR").ToString.Trim
                objEntidad.QMRCDR = .Item("QMRCDR").ToString.Trim
                objEntidad.CUNDMD = .Item("CUNDMD").ToString.Trim
                objEntidad.QSLCIT = CType(.Item("QSLCIT"), Integer).ToString
                objEntidad.QATNAN = CType(.Item("QATNAN"), Integer).ToString
                objEntidad.FINCRG = .Item("FINCRG").ToString.Trim
                objEntidad.HINCIN = .Item("HINCIN").ToString.Trim
                objEntidad.FENTCL = .Item("FENTCL").ToString.Trim
                objEntidad.HRAENT = .Item("HRAENT").ToString.Trim
                objEntidad.CLCLOR_C = .Item("CLCLOR")
                objEntidad.CLCLOR = .Item("CLCLOR").ToString.Trim
                objEntidad.CLCLOR_D = .Item("CLCLOR_D").ToString.Trim
                objEntidad.TDRCOR = .Item("TDRCOR").ToString.Trim
                objEntidad.CLCLDS_C = .Item("CLCLDS")
                objEntidad.CLCLDS = .Item("CLCLDS").ToString.Trim
                objEntidad.CLCLDS_D = .Item("CLCLDS_D").ToString.Trim
                objEntidad.TDRENT = .Item("TDRENT").ToString.Trim
                objEntidad.SESSLC = .Item("SESSLC").ToString.Trim
                objEntidad.CUSCRT = .Item("CUSCRT").ToString.Trim
                objEntidad.FCHCRT = .Item("FCHCRT").ToString.Trim
                objEntidad.HRACRT = .Item("HRACRT").ToString.Trim
                objEntidad.NTRMCR = .Item("NTRMCR").ToString.Trim
                objEntidad.CULUSA = .Item("CULUSA").ToString.Trim
                objEntidad.FULTAC = .Item("FULTAC").ToString.Trim
                objEntidad.HULTAC = .Item("HULTAC").ToString.Trim
                objEntidad.NTRMNL = .Item("NTRMNL").ToString.Trim
                objEntidad.TOBS = .Item("TOBS").ToString.Trim
                objEntidad.SFCRTV = .Item("SFCRTV").ToString.Trim
                objEntidad.CMEDTR = .Item("CMEDTR").ToString.Trim
                objEntidad.CCTCSC = .Item("CCTCSC").ToString.Trim
                objEntidad.TRFRN = .Item("TRFRN").ToString.Trim
                objEntidad.SPRSTR = .Item("SPRSTR").ToString.Trim
                objEntidad.CUBORI = .Item("CUBORI")
                objEntidad.UBIGEO_O = .Item("UBIGEO_O").ToString.Trim
                objEntidad.CUBDES = .Item("CUBDES")
                objEntidad.UBIGEO_D = .Item("UBIGEO_D").ToString.Trim
                objEntidad.CTTRAN = .Item("CTTRAN").ToString()
                objEntidad.CTIPCG = .Item("CTIPCG").ToString()




                objEntidad.SFCRTV = .Item("SFCRTV").ToString.Trim 'ECM-HUNDRED


                objEntidad.FATNSR_S = .Item("FATNSR").ToString()
                objEntidad.HATNSR_S = .Item("HATNSR").ToString()
                objEntidad.TPSOTR = .Item("TPSOTR").ToString()



                'YA ESTABAN COMENTADOS ANTES 20200909
       

            End With
          
            Return objEntidad
        End Function

        Public Function Lista_ObtenerSolicitud_Envio(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_X_ID", objParam)
           
            Return objDataTable
        End Function

        Public Function Lista_Destinatarios(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DESTINATARIO_SOLICITUD", Nothing)
           
            Return objDataTable
        End Function

      

        Public Function Listar_Solicitudes_Transporte(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", objParametros("PNNCSOTR"))
            objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
            objParam.Add("PSSESSLC", objParametros("PSSESSLC"))
            If objParametros("PNFECINI") <> "" And objParametros("PNFECFIN") <> "" Then
                objParam.Add("PNFECINI", objParametros("PNFECINI"))
                objParam.Add("PNFECFIN", objParametros("PNFECFIN"))
            End If
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("PSCCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPTSOLICITUDES", objParam)
            Return objDataTable
           
        End Function


        Public Function Listar_Solicitudes_Transporte2(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            

            objParam.Add("PNNCSOTR", objParametros("PNNCSOTR"))
            objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
            objParam.Add("PSSESSLC", objParametros("PSSESSLC").ToString.Trim)
            objParam.Add("PNCMEDTR", objParametros("PNCMEDTR"))
            If objParametros("PNFECINI") <> "" And objParametros("PNFECFIN") <> "" Then
                objParam.Add("PNFECINI", objParametros("PNFECINI"))
                objParam.Add("PNFECFIN", objParametros("PNFECFIN"))
            End If
            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametros("PNCPLNDV"))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPTSOLICITUDES2", objParam)

            For intCont As Integer = 0 To objDataTable.Rows.Count - 1
                Dim strCon1 As String = ""
                Dim strCon2 As String = ""
                If objDataTable.Rows(intCont).Item("CBRCND").ToString.Trim.Length > 0 Then
                    strCon1 = objDataTable.Rows(intCont).Item("CBRCND")
                End If
               

                If strCon1.Trim.Length > 0 Then
                    objDataTable.Rows(intCont).Item("CBRCND") = strCon1 & Chr(10) & strCon2
                ElseIf strCon1.Trim.Length > 0 Then
                    objDataTable.Rows(intCont).Item("CBRCND") = strCon1 & Chr(10) & strCon2
                Else
                    objDataTable.Rows(intCont).Item("CBRCND") = ""
                End If
            Next
            Return objDataTable
          
        End Function

       

        Public Function Listar_Solicitudes_Vehiculo(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", objParametros("PNNCSOTR"))
            objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
            objParam.Add("PSSESSLC", objParametros("PSSESSLC").ToString.Trim)
            objParam.Add("PNCMEDTR", objParametros("PNCMEDTR"))
            If objParametros("PNFECINI") <> "" And objParametros("PNFECFIN") <> "" Then
                objParam.Add("PNFECINI", objParametros("PNFECINI"))
                objParam.Add("PNFECFIN", objParametros("PNFECFIN"))
            End If
            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametros("PNCPLNDV"))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPTVEHICULOS", objParam)

            Return objDataTable
           
        End Function

        Public Function Obtener_Detalle_Solicitud_Asignada(ByVal objEntidad As ClaseGeneral) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral
            'Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SOLICITUD_ASIGNADA_LA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.CTPOVJ = objData("CTPOVJ").ToString.Trim

                objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
              
                objDatos.NRUCTR = objData("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objData("NPLCAC").ToString.Trim
                objDatos.CBRCNT = objData("CBRCNT").ToString.Trim
                objDatos.CBRCND = objData("CBRCND").ToString.Trim
               
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                 
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.NGUITS = objData("NGUITS").ToString.Trim




                objDatos.CBRCN2 = objData("CBRCN2").ToString.Trim
                objDatos.NORINSS = objData("NORINS").ToString.Trim
                objDatos.CBRCND2 = objData("CBRCND2").ToString.Trim
                 
                objDatos.CTRSPT = objData("CTRSPT")
                objDatos.CTRMNC = objData("CTRSPT")

                objDatos.CPLNDV_DESC = objData("CPLNDV_DESC")
              

                objDatos.NMRGIM = objData("NMRGIM")
                objDatos.NMRGIM_IMG = objData("NMRGIM_IMG")

                objDatos.FATNSR = HelpClass.CFecha_de_8_a_10(objData("FATNSR").ToString.Trim)
                objDatos.HATNSR = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(objData("HATNSR"))

                objDatos.F_ATENCION = HelpClass.CFecha_de_8_a_10(objData("FATNSR").ToString.Trim) & " " & Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(objData("HATNSR"))


                objDatos.NPLNMT = objData("NPLNMT")
                objDatos.NCRRPL = objData("NCRRPL")
                objDatos.NSBCRP = objData("NSBCRP")


                objGenericCollection.Add(objDatos)
            Next
           
            Return objGenericCollection
        End Function

        Public Function Lista_Unidad_Asignada_Multimodal(ByVal objEntidad As Multimodal) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral

            objParam.Add("PNNMOPMM", objEntidad.NMOPMM)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_UNIDAD_ASIGNADA_MULTIMODAL", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
                objDatos.NPLNJT = objData("NPLNJT").ToString.Trim
                objDatos.NCRRPL = objData("NCRRPL").ToString.Trim
                objDatos.NRUCTR = objData("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objData("NPLCAC").ToString.Trim
                objDatos.CBRCND = objData("CBRCNT").ToString.Trim
                objDatos.CBRCNT = objData("CBRCND").ToString.Trim
                objDatos.FASGTR = objData("FASGTR").ToString.Trim
                objDatos.HASGTR = objData("HASGTR").ToString.Trim
                objDatos.SESPLN = objData("SESPLN").ToString.Trim
                objDatos.FATALM = objData("FATALM").ToString.Trim
                objDatos.HATALM = objData("HATALM").ToString.Trim
                objDatos.FSLALM = objData("FSLALM").ToString.Trim
                objDatos.HSLALM = objData("HSLALM").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.SEGUIMIENTO = objData("SEGUIMIENTO").ToString.Trim
                objDatos.GPSLAT = objData("GPSLAT").ToString.Trim
                objDatos.GPSLON = objData("GPSLON").ToString.Trim
                objDatos.FECGPS = objData("FECGPS").ToString.Trim
                objDatos.HORGPS = objData("HORGPS").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CBRCN2 = objData("CBRCN2").ToString.Trim
                objDatos.NORINSS = objData("NORINS").ToString.Trim
                objDatos.NPLNMT = objData("NPLNMT").ToString.Trim
                If objData("CBRCND2").ToString.Trim.Length = 0 Then
                    objDatos.CBRCND2 = objData("CBRCND").ToString.Trim
                Else
                    objDatos.CBRCND2 = objData("CBRCND").ToString.Trim & Chr(10) & objData("CBRCND2").ToString.Trim
                End If
                objDatos.NCOREG = objData("NCOREG").ToString.Trim
                objDatos.NGSGWP = objData("NGSGWP").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
           
            Return objGenericCollection
        End Function

        

        Public Function Verificar_Existencia_Guia_Transportista(ByVal obj_Entidad As ClaseGeneral) As ClaseGeneral
            Dim objEntidad As New ClaseGeneral

            Dim objParam As New Parameter
            objParam.Add("PSNRUCTR", obj_Entidad.NRUCTR)
            objParam.Add("PNNCSOTR", obj_Entidad.NCSOTR)
            objParam.Add("PNNCRRSR", obj_Entidad.NCRRSR)
            objParam.Add("PONNGUITR", obj_Entidad.NGUITR, ParameterDirection.Output)
            objParam.Add("PONNGUITR_S", 0, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj_Entidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_EXISTENCIA_GUIA_TRANSPORTISTA", objParam)
            objEntidad.NGUITR = objSql.ParameterCollection("PONNGUITR").ToString()
            objEntidad.SESPLN = objSql.ParameterCollection("PONNGUITR_S").ToString()
           
            Return objEntidad
        End Function

        Public Function Actualizar_Fechas_Servicio_Almacen(ByVal obj_Entidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte

            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", obj_Entidad.NCSOTR)
            objParam.Add("PNNCRRSR", obj_Entidad.NCRRSR)
            objParam.Add("PNNPLNJT", obj_Entidad.NPLNJT)
            objParam.Add("PNNCRRPL", obj_Entidad.NCRRPL)
            objParam.Add("PNNGUITR", obj_Entidad.NGUITR)
            objParam.Add("PNFATALM", obj_Entidad.FATALM)
            objParam.Add("PNHATALM", obj_Entidad.HATALM)
            objParam.Add("PNFSLALM", obj_Entidad.FSLALM)
            objParam.Add("PNHSLALM", obj_Entidad.HSLALM)
            objParam.Add("PSCULUSA", obj_Entidad.CULUSA)
            objParam.Add("PNFULTAC", obj_Entidad.FULTAC)
            objParam.Add("PNHULTAC", obj_Entidad.HULTAC)
            objParam.Add("PSNTRMNL", obj_Entidad.NTRMNL)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj_Entidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FECHAS_SERVICIO_ALMACEN", objParam)

           
            Return obj_Entidad
        End Function

        Public Function Actualizar_Salida_Avion(ByVal obj_Entidad As Detalle_Solicitud_Transporte) As Int32
            Dim lintRespuesta As Int32 = 0
            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", obj_Entidad.NCSOTR)
            objParam.Add("PNNCRRSR", obj_Entidad.NCRRSR)
            objParam.Add("PNFATALM", obj_Entidad.FATALM)
            objParam.Add("PNHATALM", obj_Entidad.HATALM)
            objParam.Add("PNFSLALM", obj_Entidad.FSLALM)
            objParam.Add("PNHSLALM", obj_Entidad.HSLALM)
            objParam.Add("PSCULUSA", obj_Entidad.CULUSA)
            objParam.Add("PNFULTAC", obj_Entidad.FULTAC)
            objParam.Add("PNHULTAC", obj_Entidad.HULTAC)
            objParam.Add("PSNTRMNL", obj_Entidad.NTRMNL)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj_Entidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FECHAS_SALIDA_AVION", objParam)
            lintRespuesta = 1
           
            Return lintRespuesta
        End Function

        Public Function Asignar_Orden_Servicio_A_Solicitud(ByVal obj_Entidad As Solicitud_Transporte) As Solicitud_Transporte

            Dim objParam As New Parameter

            objParam.Add("PNNCSOTR", obj_Entidad.NCSOTR)
            objParam.Add("PNNORSRT", obj_Entidad.NORSRT)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj_Entidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ASIGNAR_ORDEN_SERVICIO_A_SOLICITUD", objParam)
           
            Return obj_Entidad
        End Function

        'Public Function Lista_Solicitud_X_Cliente(ByVal objParametros As List(Of String)) As List(Of ClaseGeneral)
        Public Function Lista_Solicitud_X_Cliente(ByVal objParametros As ENTIDADES.Operaciones.OperacionTransporte) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral
            

            objParam.Add("PSNCSOTR", objParametros.NCSOTR)
            objParam.Add("PNCCLNT", objParametros.CCLNT)
            objParam.Add("PSNRUCTR", objParametros.NRUCTR)
            objParam.Add("PSNPLCUN", objParametros.NPLCUN)
            objParam.Add("PNFECINI", objParametros.FECINI)
            objParam.Add("PNFECFIN", objParametros.FECFIN)
            objParam.Add("PSCCMPN", objParametros.CCMPN)
            objParam.Add("PSCDVSN", objParametros.CDVSN)
            objParam.Add("PNCPLNDV", objParametros.CPLNDV)
            objParam.Add("PNNOPRCN", objParametros.NOPRCN)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN)

            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SOLICITUD_X_CLIENTE_1", objParam)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SOLICITUD_X_CLIENTE", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.NCRRSR = objData("NCRRSR").ToString.Trim
                objDatos.NPLNJT = objData("NPLNJT").ToString.Trim
                objDatos.NCRRPL = objData("NCRRPL").ToString.Trim
                objDatos.NRUCTR = objData("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
                objDatos.NPLCAC = objData("NPLCAC").ToString.Trim
                objDatos.CBRCNT = objData("CBRCNT").ToString.Trim
                objDatos.CBRCND = objData("CBRCND").ToString.Trim
               
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.RUTA = objData("RUTA").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.CBRCN2 = objData("CBRCN2").ToString.Trim
                objDatos.CBRCND2 = objData("CBRCND2").ToString.Trim
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
               
                objDatos.CMEDTR = objData("CMEDTR")
                objDatos.CTPOVJ = objData("CTPOVJ")

              

                objDatos.FATNSR = objData("FATNSR")
                objDatos.NGUITS = objData("NGUITS")




                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection
        End Function

        Public Function Reporte_Mensual_Vehiculo(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As New ClaseGeneral

            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objParam.Add("PNCCLNT", objParametros("CCLNT"))
            objParam.Add("PNFECINI", objParametros("FECINI"))
            objParam.Add("PNFECFIN", objParametros("FECFIN"))
            objParam.Add("PSNPLCUN", objParametros("NPLCUN"))
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_VEHICULO", objParam)

            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_VEHICULO_PRD", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NPLCUN = objData("NPLCUN").ToString.Trim
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.FASGTR = objData("FASGTR").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.SINDRC = ("" & objData("SINDRC").ToString.Trim)
                objDatos.RUTA = objData("ORIGEN").ToString.Trim & " - " & objData("DESTIN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.FGUIRM = ("" & objData("FGUIRM").ToString.Trim)
                objDatos.QKMREC = Val("" & objData("QKMREC").ToString.Trim)

                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection
        End Function

        Public Function Reporte_Mensual_Conductor(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral

            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objParam.Add("PNCCLNT", objParametros("CCLNT"))
            objParam.Add("PNFECINI", objParametros("FECINI"))
            objParam.Add("PNFECFIN", objParametros("FECFIN"))
            objParam.Add("PSCBRCNT", objParametros("CBRCNT"))
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_CONDUCTOR", objParam)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_CONDUCTOR_PRD", objParam)

            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.CONDUCTOR = objData("CONDUCTOR").ToString
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.FASGTR = objData("FASGTR").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.SINDRC = ("" & objData("SINDRC").ToString.Trim)
                objDatos.RUTA = objData("ORIGEN").ToString.Trim & " - " & objData("DESTIN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.FGUIRM = ("" & objData("FGUIRM").ToString.Trim)
                objDatos.QKMREC = Val("" & objData("QKMREC"))

                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection
        End Function

        Public Function Reporte_Mensual_Transportista(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral

            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objParam.Add("PNCCLNT", objParametros("CCLNT"))
            objParam.Add("PNFECINI", objParametros("FECINI"))
            objParam.Add("PNFECFIN", objParametros("FECFIN"))
            objParam.Add("PSNRUCTR", objParametros("NRUCTR"))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_TRANSPORTISTA", objParam)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_TRANSPORTISTA_PRD", objParam)


            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.TCMTRT = objData("TCMTRT").ToString.Trim
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.FASGTR = objData("FASGTR").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.SINDRC = objData("SINDRC").ToString.Trim
                objDatos.RUTA = objData("ORIGEN").ToString.Trim & " - " & objData("DESTIN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.FGUIRM = objData("FGUIRM").ToString.Trim
                objDatos.QKMREC = objData("QKMREC").ToString.Trim
                
                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection
        End Function

        Public Function Reporte_Mensual_Acoplado(ByVal objParametros As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral
            'Try
            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objParam.Add("PNCCLNT", objParametros("CCLNT"))
            objParam.Add("PNFECINI", objParametros("FECINI"))
            objParam.Add("PNFECFIN", objParametros("FECFIN"))
            objParam.Add("PSNPLCAC", objParametros("NPLCAC"))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_ACOPLADO", objParam)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_RESUMEN_MENSUAL_SOLICITUD_X_ACOPLADO_PRD", objParam)
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NPLCAC = ("" & objData("NPLCAC").ToString.Trim)
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.FASGTR = objData("FASGTR").ToString.Trim
                objDatos.NOPRCN = objData("NOPRCN").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.SINDRC = ("" & objData("SINDRC").ToString.Trim)
                objDatos.RUTA = objData("ORIGEN").ToString.Trim & " - " & objData("DESTIN").ToString.Trim
                objDatos.NGUITR = objData("NGUITR").ToString.Trim
                objDatos.FGUIRM = ("" & objData("FGUIRM").ToString.Trim)
                objDatos.QKMREC = Val("" & objData("QKMREC").ToString.Trim)

                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            '    Return objGenericCollection
            'End Try
            Return objGenericCollection
        End Function

        Public Function Auditoria(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
            Dim objParam As New Parameter
            Dim oDt As DataTable
            'Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AUDITORIA_SOLICITUD_TRANSPORTE", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New Solicitud_Transporte()
                objEntidad.CUSCRT = objData.Item("CUSCRT")
                objEntidad.FCHCRT = objData.Item("FCHCRT")
                objEntidad.HRACRT = objData.Item("HRACRT")
                objEntidad.NTRMCR = objData.Item("NTRMCR")
                objEntidad.FULTAC = objData.Item("FULTAC")
                objEntidad.HULTAC = objData.Item("HULTAC")
                objEntidad.CULUSA = objData.Item("CULUSA")
                objEntidad.NTRMNL = objData.Item("NTRMNL")
            Next
            'Catch ex As Exception
            '    Return objEntidad
            'End Try
            Return objEntidad
        End Function

        Public Function Anulacion_Operacion_Transporte_Multimodal(ByVal objEntidad As Solicitud_Transporte) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0

            'Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("OURESULT", 0, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_OPERACION_TRANSPORTE_MULTIMODAL", objParam)
            lintResult = objSql.ParameterCollection("OURESULT")
            'Catch ex As Exception
            '    lintResult = 0
            'End Try
            Return lintResult
        End Function
        'MOD
        Public Function Anulacion_Operacion_Transporte(ByVal objEntidad As Solicitud_Transporte) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0

            'Try
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("OURESULT", 0, ParameterDirection.Output)
            'Agregar campos nuevos
            objParam.Add("PNOPAN_CGSTO", objEntidad.PNOPAN_CGSTO)
            objParam.Add("PSFLGAPG", objEntidad.FLGAPG)
            objParam.Add("PNNOPRCR", objEntidad.NOPRCR)
            objParam.Add("PSUSLAOP", objEntidad.USLAOP)
            objParam.Add("PSUATAOP", objEntidad.UATAOP)
            objParam.Add("PSMOTAOP", objEntidad.MOTAOP)
            objParam.Add("PSOBSAOP", objEntidad.OBSAOP)
            objParam.Add("PSTRFSRC", objEntidad.TRFSRC)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_OPERACION_TRANSPORTE_1", objParam)
            lintResult = objSql.ParameterCollection("OURESULT")
            'Catch ex As Exception
            '    lintResult = 0
            'End Try
            Return lintResult
        End Function

        Public Function Anulacion_Operacion_Transporte_Alquiler(ByVal CCMPN As String, ByVal PARAM_NRALQT As Decimal, ByVal PSCULUSA As String, ByVal PSNTRMNL As String) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0

            'Try
            objParam.Add("PARAM_NRALQT", PARAM_NRALQT)
            objParam.Add("PSCULUSA", PSCULUSA)
            objParam.Add("PSNTRMNL", PSNTRMNL)
            objParam.Add("OURESULT", 0, ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_OPERACION_TRANSPORTE_ALQUILER", objParam)
            lintResult = objSql.ParameterCollection("OURESULT")
            'Catch ex As Exception
            '    lintResult = 0
            'End Try
            Return lintResult
        End Function

        Public Function Listar_Solicitud_Transporte_Selva(ByVal objParametros As List(Of String)) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDatos As ClaseGeneral
            'Try
            objParam.Add("PNCCLNT", objParametros(0))
            objParam.Add("PNNCSOTR", objParametros(1))
            objParam.Add("PSSESSLC", objParametros(2))
            objParam.Add("PNFECINI", objParametros(3))
            objParam.Add("PNFECFIN", objParametros(4))
            objParam.Add("PSCCMPN", objParametros(5))
            objParam.Add("PSCDVSN", objParametros(6))
            objParam.Add("PSCPLNDV", objParametros(7))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(5))

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_REMISION_SELVA", objParam)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New ClaseGeneral
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.FECOST = objData("FECOST").ToString.Trim
                objDatos.TCMPCL = objData("TCMPCL").ToString.Trim
                objDatos.FATALM = objData("FATALM").ToString.Trim
                objDatos.NGUIRM = objData("NGUIRM")
                objDatos.NGUITR = objData("NGUITR")
                objDatos.TCMRCD = objData("DESMER").ToString.Trim
                objDatos.PMRCDR = objData("PMRCMC")
                objDatos.NORCMC = objData("NORCMC").ToString.Trim
                objDatos.NRITOC = objData("NRITOC").ToString.Trim
                objDatos.CCTCSC = objData("CCTCSC").ToString.Trim
                objDatos.FSLDCM = objData("FSLDCM").ToString.Trim
                objDatos.FLLGCM = objData("FLLGCM").ToString.Trim
                objDatos.TOBS = objData("TOBS").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function


        Public Function Exportar_Reporte_Cargo_Plan_Terrestre(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_1", objParam)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_1_ST", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_1_LA", objParam)

            objDataSet.Tables(0).Columns.Add("F_DE_INGRESO_1", System.Type.GetType("System.String"))

            For Each dr As DataRow In objDataSet.Tables(0).Rows
                dr("F_DE_INGRESO_1") = HelpClass.CFecha_de_8_a_10(dr("F_DE_INGRESO").ToString.Trim)
            Next
            objDataSet.Tables(0).Columns.Remove("F_DE_INGRESO")
            objDataSet.Tables(0).Columns("F_DE_INGRESO_1").ColumnName = "F_DE_INGRESO"

            objDataSet.Tables(1).Columns.Add("FECHA_1", System.Type.GetType("System.String"))

            For Each dr As DataRow In objDataSet.Tables(1).Rows
                dr("FECHA_1") = HelpClass.CFecha_de_8_a_10(dr("FECHA").ToString.Trim)
            Next
            objDataSet.Tables(1).Columns.Remove("FECHA")
            objDataSet.Tables(1).Columns("FECHA_1").ColumnName = "FECHA"


            'Catch : End Try

            Return objDataSet
        End Function
        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Terrestre_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_1", objParam)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_1_ST", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_PPC", objParam)



            objDataSet.Tables(0).Columns.Add("F_DE_INGRESO_1", System.Type.GetType("System.String"))

            For Each dr As DataRow In objDataSet.Tables(0).Rows
                dr("F_DE_INGRESO_1") = HelpClass.CFecha_de_8_a_10(dr("F_DE_INGRESO").ToString.Trim)
            Next
            objDataSet.Tables(0).Columns.Remove("F_DE_INGRESO")
            objDataSet.Tables(0).Columns("F_DE_INGRESO_1").ColumnName = "F_DE_INGRESO"

            objDataSet.Tables(1).Columns.Add("FECHA_1", System.Type.GetType("System.String"))

            For Each dr As DataRow In objDataSet.Tables(1).Rows
                dr("FECHA_1") = HelpClass.CFecha_de_8_a_10(dr("FECHA").ToString.Trim)
            Next
            objDataSet.Tables(1).Columns.Remove("FECHA")
            objDataSet.Tables(1).Columns("FECHA_1").ColumnName = "FECHA"


            'Catch : End Try

            Return objDataSet
        End Function


        Public Function Exportar_Reporte_Cargo_Plan_Aereo(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objDato_Default As DataTable
            Dim objDato_1 As New DataTable
            objDato_1.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            objDato_1.Columns.Add(New DataColumn("KG", GetType(System.Double)))
            objDato_1.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            objDato_1.Columns.Add(New DataColumn("BUL", GetType(System.Int64)))
            Dim objDato_2 As New DataTable
            objDato_2.Columns.Add(New DataColumn("BULTOS", GetType(System.Int64)))
            objDato_2.Columns.Add(New DataColumn("PESO", GetType(System.Double)))
            objDato_2.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            Dim objDataRow As DataRow
            Dim objParam As New Parameter
            Try
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
                objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_LMZ", objParam)

                objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_LMZ_ST", objParam)


                'TI = DETALLE
                'T2 = CABECERA
                'T3 = CI DISTRIBUIDAS POR OC
                objDato_Default = New DataTable
                objDato_Default = objDataSet.Tables(0).Copy
                objDato_Default.Columns.Remove("ITEM")
                objDato_Default.Columns.Remove("GUIA_PROV")
                objDato_Default.Columns.Remove("PROVEEDOR")
                objDato_Default.Columns.Remove("CONTENIDO")
                objDato_Default.Columns.Remove("F_DE_INGRESO")
                objDato_Default.Columns.Remove("GUIA_REMISION")
                objDato_Default.Columns.Remove("CUENTA_IMPUTACION")

                Dim drSelect As DataRow() = Nothing
                Dim TotalKG As Double = 0
                Dim TotalM3 As Double = 0
                Dim TotalBUL As Int64 = 0
                Dim OriginalCount As Integer = objDato_Default.Rows.Count
                Dim Indice As Integer = 0
                '===========================================================
                '=====================RESUMEN POR LOTES=====================
                '===========================================================
                While Indice <= OriginalCount - 1
                    drSelect = objDato_Default.Select("LOTE = '" + objDato_Default.Rows(Indice)("LOTE").ToString.Trim + "'")
                    For Each dr As DataRow In drSelect
                        TotalKG += Convert.ToDouble(dr("PESO"))
                        TotalM3 += Convert.ToDouble(dr("M3"))
                        TotalBUL += Convert.ToInt64(dr("BULTOS"))
                    Next
                    If drSelect.Length > 0 Then
                        objDataRow = objDato_1.NewRow
                        objDataRow.Item("LOTE") = objDato_Default.Rows(Indice)("LOTE").ToString.Trim
                        objDataRow.Item("KG") = TotalKG
                        objDataRow.Item("M3") = TotalM3
                        objDataRow.Item("BUL") = TotalBUL
                        objDato_1.Rows.Add(objDataRow)
                        Indice = Indice + drSelect.Length
                    End If
                    TotalKG = 0
                    TotalM3 = 0
                    TotalBUL = 0
                End While
                '===========================================================
                TotalKG = 0
                TotalM3 = 0
                TotalBUL = 0
                '===========================================================
                '=====================TOTALES KG, M3 Y BULTOS===============
                '===========================================================
                For i As Integer = 0 To OriginalCount - 1
                    TotalKG += Convert.ToDouble(objDato_Default.Rows(i)("PESO"))
                    TotalM3 += Convert.ToDouble(objDato_Default.Rows(i)("M3"))
                    TotalBUL += Convert.ToInt64(objDato_Default.Rows(i)("BULTOS"))
                Next i
                objDataRow = objDato_2.NewRow
                objDataRow.Item("BULTOS") = TotalBUL
                objDataRow.Item("PESO") = TotalKG
                objDataRow.Item("M3") = TotalM3
                objDato_2.Rows.Add(objDataRow)
                '===========================================================
                '============logica para resumenes por CI===================
                '===========================================================
                Dim oDtCI_x_OS As New DataTable
                Dim oDtDetalle As New DataTable
                Dim oDtTempCopy As New DataTable
                Dim oDtDetAdicional As New DataTable
                Dim fechaRng As String = ""
                Dim where As String = ""
                Dim drw As DataRow = Nothing
                oDtDetalle = objDataSet.Tables(0).Copy
                oDtDetalle.Columns.Add("POR_CI", GetType(System.Double))
                'oDtDetalle.Columns.Add("POR", GetType(System.Double))
                oDtDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
                '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
                oDtCI_x_OS.TableName = "CI_x_OS"
                oDtCI_x_OS = objDataSet.Tables(2)
                '================================================
                oDtTempCopy = oDtDetalle.Clone
                For Each dr As DataRow In oDtDetalle.Rows
                    Dim y As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                    Dim m As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                    Dim d As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                    fechaRng = y & m & d
                    where = "NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                    oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                    '===CARGAMOS DATA ADICIONAL==='
                    If oDtDetAdicional.Rows.Count > 0 Then
                        dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                        dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim
                    Else
                        dr("FLAG_DIST") = "0"
                    End If
                    oDtTempCopy.ImportRow(dr)
                    For i As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                        drw = oDtTempCopy.NewRow
                        drw("PESO") = dr("PESO")
                        drw("POR_CI") = oDtDetAdicional.Rows(i).Item("IPRCTJ")
                        drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(i).Item("TCTCSA").ToString.Trim
                        drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                        oDtTempCopy.Rows.Add(drw)
                    Next
                Next
                '============ RESUMEN CUENTA DE IMPUTACION ===========
                Dim TotPor As Double = 0D
                Dim oDtCtaImput As New DataTable
                Dim oDrCtaImput As DataRow
                oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
                oDtCtaImput.Columns.Add("Importe", GetType(System.Double))
                Dim oDtv As DataView = New DataView(oDtTempCopy.Copy)
                oDtv.Sort = "CUENTA_IMPUTACION DESC"
                Dim oTabla As New DataTable
                oTabla = oDtv.ToTable
                OriginalCount = oTabla.Rows.Count

                For i As Integer = 0 To OriginalCount - 1
                    drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim + "' AND  FLAG_DIST <> 'CI_SG'") 'ACA ES EL PUNTO
                    TotPor = 0
                    For Each dr As DataRow In drSelect
                        If objDato_2.Rows(0).Item("PESO") = 0 Then objDato_2.Rows(0).Item("PESO") = 1 'Neutralizamos el total pues el detalle contendra 0 tambien
                        If IsDBNull(dr("POR_CI")) Then
                            TotPor += 100 * (dr("PESO") / objDato_2.Rows(0).Item("PESO")) 'Convert.ToDouble(dr("POR")) * 
                        Else
                            TotPor += 100 * (dr("PESO") / objDato_2.Rows(0).Item("PESO")) * Convert.ToDouble(dr("POR_CI")) * 0.01 'Convert.ToDouble(dr("POR")) 
                        End If
                    Next
                    If drSelect.Length > 0 Then
                        oDrCtaImput = oDtCtaImput.NewRow
                        oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim)
                        oDrCtaImput.Item("Importe") = TotPor * objDataSet.Tables(1).Rows(0).Item("ITRSRT") * 0.01
                        oDtCtaImput.Rows.Add(oDrCtaImput)
                        i = i + drSelect.Length - 1
                    End If
                Next i
                objDataSet.Tables.Remove("Table") 'Quitamos la tabla original y dejamos la tabla copia
                objDataSet.Tables("Table1").TableName = "T_Cabecera"
                oDtTempCopy.Columns.Remove("FLAG_DIST")
                oDtTempCopy.TableName = "T_Detalle"
                objDataSet.Tables.Add(oDtTempCopy.Copy)
                oDtCtaImput.TableName = "ResCuenta"
                objDataSet.Tables.Add(oDtCtaImput.Copy)
                objDato_1.TableName = "T_ResLote"
                objDato_2.TableName = "T_Totales"
                objDataSet.Tables.Add(objDato_1)
                objDataSet.Tables.Add(objDato_2)

            Catch ex As Exception
            End Try

            Return objDataSet
        End Function
        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Aereo_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objDato_Default As DataTable
            Dim objDato_1 As New DataTable
            objDato_1.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            objDato_1.Columns.Add(New DataColumn("KG", GetType(System.Double)))
            objDato_1.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            objDato_1.Columns.Add(New DataColumn("BUL", GetType(System.Int64)))
            Dim objDato_2 As New DataTable
            objDato_2.Columns.Add(New DataColumn("BULTOS", GetType(System.Int64)))
            objDato_2.Columns.Add(New DataColumn("PESO", GetType(System.Double)))
            objDato_2.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            Dim objDataRow As DataRow
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_LMZ", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_LMZ_ST_PPC", objParam)


            'TI = DETALLE
            'T2 = CABECERA
            'T3 = CI DISTRIBUIDAS POR OC
            objDato_Default = New DataTable
            objDato_Default = objDataSet.Tables(0).Copy
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("CONTENIDO")
            objDato_Default.Columns.Remove("F_DE_INGRESO")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("CUENTA_IMPUTACION")

            Dim drSelect As DataRow() = Nothing
            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            Dim TotalBUL As Int64 = 0
            Dim OriginalCount As Integer = objDato_Default.Rows.Count
            Dim Indice As Integer = 0
            '===========================================================
            '=====================RESUMEN POR LOTES=====================
            '===========================================================
            While Indice <= OriginalCount - 1
                drSelect = objDato_Default.Select("LOTE = '" + objDato_Default.Rows(Indice)("LOTE").ToString.Trim + "'")
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("PESO"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                    TotalBUL += Convert.ToInt64(dr("BULTOS"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = objDato_1.NewRow
                    objDataRow.Item("LOTE") = objDato_Default.Rows(Indice)("LOTE").ToString.Trim
                    objDataRow.Item("KG") = TotalKG
                    objDataRow.Item("M3") = TotalM3
                    objDataRow.Item("BUL") = TotalBUL
                    objDato_1.Rows.Add(objDataRow)
                    Indice = Indice + drSelect.Length
                End If
                TotalKG = 0
                TotalM3 = 0
                TotalBUL = 0
            End While
            '===========================================================
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0
            '===========================================================
            '=====================TOTALES KG, M3 Y BULTOS===============
            '===========================================================
            For i As Integer = 0 To OriginalCount - 1
                TotalKG += Convert.ToDouble(objDato_Default.Rows(i)("PESO"))
                TotalM3 += Convert.ToDouble(objDato_Default.Rows(i)("M3"))
                TotalBUL += Convert.ToInt64(objDato_Default.Rows(i)("BULTOS"))
            Next i
            objDataRow = objDato_2.NewRow
            objDataRow.Item("BULTOS") = TotalBUL
            objDataRow.Item("PESO") = TotalKG
            objDataRow.Item("M3") = TotalM3
            objDato_2.Rows.Add(objDataRow)
            '===========================================================
            '============logica para resumenes por CI===================
            '===========================================================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtDetalle As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim fechaRng As String = ""
            Dim where As String = ""
            Dim drw As DataRow = Nothing
            oDtDetalle = objDataSet.Tables(0).Copy
            oDtDetalle.Columns.Add("POR_CI", GetType(System.Double))
            'oDtDetalle.Columns.Add("POR", GetType(System.Double))
            oDtDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2)
            '================================================
            oDtTempCopy = oDtDetalle.Clone
            For Each dr As DataRow In oDtDetalle.Rows
                Dim y As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = objDataSet.Tables(1).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For i As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("PESO") = dr("PESO")
                    drw("POR_CI") = oDtDetAdicional.Rows(i).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(i).Item("TCTCSA").ToString.Trim
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next



            Next


            '============ RESUMEN CUENTA DE IMPUTACION ===========
            Dim TotPor As Double = 0D
            Dim oDtCtaImput As New DataTable
            Dim oDrCtaImput As DataRow
            oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImput.Columns.Add("Importe", GetType(System.Double))
            Dim oDtv As DataView = New DataView(oDtTempCopy.Copy)
            oDtv.Sort = "CUENTA_IMPUTACION DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            OriginalCount = oTabla.Rows.Count

            For i As Integer = 0 To OriginalCount - 1
                drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim + "' AND  FLAG_DIST <> 'CI_SG'") 'ACA ES EL PUNTO
                TotPor = 0
                For Each dr As DataRow In drSelect
                    If objDato_2.Rows(0).Item("PESO") = 0 Then objDato_2.Rows(0).Item("PESO") = 1 'Neutralizamos el total pues el detalle contendra 0 tambien
                    If IsDBNull(dr("POR_CI")) Then
                        TotPor += 100 * (dr("PESO") / objDato_2.Rows(0).Item("PESO")) 'Convert.ToDouble(dr("POR")) * 
                    Else
                        TotPor += 100 * (dr("PESO") / objDato_2.Rows(0).Item("PESO")) * Convert.ToDouble(dr("POR_CI")) * 0.01 'Convert.ToDouble(dr("POR")) 
                    End If
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImput = oDtCtaImput.NewRow
                    oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(i)("CUENTA_IMPUTACION").ToString.Trim)
                    oDrCtaImput.Item("Importe") = TotPor * objDataSet.Tables(1).Rows(0).Item("ITRSRT") * 0.01
                    oDtCtaImput.Rows.Add(oDrCtaImput)
                    i = i + drSelect.Length - 1
                End If
            Next i
            objDataSet.Tables.Remove("Table") 'Quitamos la tabla original y dejamos la tabla copia
            objDataSet.Tables("Table1").TableName = "T_Cabecera"
            oDtTempCopy.Columns.Remove("FLAG_DIST")
            oDtTempCopy.TableName = "T_Detalle"
            objDataSet.Tables.Add(oDtTempCopy.Copy)
            oDtCtaImput.TableName = "ResCuenta"
            objDataSet.Tables.Add(oDtCtaImput.Copy)
            objDato_1.TableName = "T_ResLote"
            objDato_2.TableName = "T_Totales"
            objDataSet.Tables.Add(objDato_1)
            objDataSet.Tables.Add(objDato_2)







            'Catch ex As Exception
            'End Try

            Return objDataSet
        End Function


        Public Function Exportar_Reporte_Cargo_Plan_Fluvial(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objDato_Default As DataTable
            Dim objDataRow As DataRow
            Dim objParam As New Parameter
            '==================================
            Dim oDtMaterial As New DataTable
            Dim oDtResLote As New DataTable
            Dim oDtResCuenta As New DataTable
            TablaFluvialResumenLote(oDtResLote)
            TablaFluvialDetalleMaterial(oDtMaterial)
            TablaFluvialResumenCuenta(oDtResCuenta)

            'Try
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL", objParam)


            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_IMG", objParam)

            objDataSet.Tables(0).TableName = "CABECERA"
            objDataSet.Tables(1).TableName = "DETALLE"
            objDataSet.Tables(2).TableName = "DISTRIBUCION_CI"

            '===========================================================
            '============logica para resumenes por CI===================
            '===========================================================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtDetalle As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim fechaRng As String = ""
            Dim where As String = ""
            Dim drw As DataRow = Nothing
            oDtDetalle = objDataSet.Tables("DETALLE").Copy
            oDtDetalle.Columns.Add("POR_CI", GetType(System.Double))
            'oDtDetalle.Columns.Add("POR", GetType(System.Double))
            oDtDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            oDtCI_x_OS = objDataSet.Tables("DISTRIBUCION_CI")
            oDtCI_x_OS.TableName = "CI_x_OS"
            '================================================
            oDtTempCopy = oDtDetalle.Clone
            For Each dr As DataRow In oDtDetalle.Rows
                Dim y As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For i As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(i).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(i).Item("TCTCSF").ToString.Trim
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next



            '==================RESUMEN DE LOTES=====================
            Dim drSelect As DataRow() = Nothing
            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            objDato_Default = New DataTable
            objDato_Default = objDataSet.Tables(1).Copy
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            Dim oDtv As DataView = New DataView(objDato_Default)
            oDtv.Sort = "LOTE DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count
            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("LOTE = '" + oTabla.Rows(i)("LOTE").ToString.Trim + "'")
                TotalKG = 0
                TotalM3 = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = oDtResLote.NewRow
                    objDataRow.Item("LOTE") = oTabla.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("PESO") = TotalKG
                    objDataRow.Item("VOLUMEN") = TotalM3
                    oDtResLote.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i
            '========================================================================
            '================RESUMEN DE CUENTAS=================
            Dim drSelectCuentas As DataRow() = Nothing
            objDato_Default = New DataTable
            objDato_Default = oDtTempCopy.Copy
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            objDato_Default.Columns.Remove("KG")
            objDato_Default.Columns.Remove("M3")
            objDato_Default.Columns.Remove("LOTE")
            objDato_Default.Columns.Remove("BULTOS")
            Dim oDtvCuentas As DataView = New DataView(objDato_Default)
            oDtvCuentas.RowFilter = "FLAG_DIST <> 'CI_SG' "  '" POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaCuentas As New DataTable
            oTablaCuentas = oDtvCuentas.ToTable(True, "CUENTA_IMPUTACION")

            For i As Integer = 0 To oTablaCuentas.Rows.Count - 1
                objDataRow = oDtResCuenta.NewRow
                objDataRow.Item("CUENTA") = oTablaCuentas.Rows(i)("CUENTA_IMPUTACION").ToString.Trim
                objDataRow.Item("PORCENTAJE") = 0
                objDataRow.Item("MONTO") = 0
                oDtResCuenta.Rows.Add(objDataRow)
            Next
            '============================================================================
            '============================================================================
            '===Copiamos las tablas a un nuevo DataSet que sera enviado al Cargo Plan====
            Dim objDsFluvial As New DataSet
            oDtTempCopy.Columns.Remove("FLAG_DIST") 'Quitamos el Flag usado
            objDsFluvial.Tables.Add(objDataSet.Tables("CABECERA").Copy)
            objDsFluvial.Tables.Add(oDtTempCopy.Copy)
            objDsFluvial.Tables.Add(oDtMaterial.Copy)
            objDsFluvial.Tables.Add(oDtResLote.Copy)
            objDsFluvial.Tables.Add(oDtResCuenta.Copy)
            '============================================================================
            '============================================================================
            '============================================================================
            'objDataSet.Tables.Add(oDtMaterial.Copy)
            'objDataSet.Tables.Add(oDtResLote.Copy)
            'objDataSet.Tables.Add(oDtResCuenta.Copy)

            Return objDsFluvial 'objDataSet
            'Catch ex As Exception
            '    Return objDataSet
            'End Try
        End Function
        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Fluvial_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objDato_Default As DataTable
            Dim objDataRow As DataRow
            Dim objParam As New Parameter
            '==================================
            Dim oDtMaterial As New DataTable
            Dim oDtResLote As New DataTable
            Dim oDtResCuenta As New DataTable
            TablaFluvialResumenLote(oDtResLote)
            TablaFluvialDetalleMaterial(oDtMaterial)
            TablaFluvialResumenCuenta(oDtResCuenta)

            'Try
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUIRM", objEntidad.PSNGUIRM)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL", objParam)


            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_IMG_PPC", objParam)


            objDataSet.Tables(0).TableName = "CABECERA"
            objDataSet.Tables(1).TableName = "DETALLE"
            objDataSet.Tables(2).TableName = "DISTRIBUCION_CI"

            '===========================================================
            '============logica para resumenes por CI===================
            '===========================================================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtDetalle As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim fechaRng As String = ""
            Dim where As String = ""
            Dim drw As DataRow = Nothing
            oDtDetalle = objDataSet.Tables("DETALLE").Copy
            oDtDetalle.Columns.Add("POR_CI", GetType(System.Double))
            'oDtDetalle.Columns.Add("POR", GetType(System.Double))
            oDtDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            oDtCI_x_OS = objDataSet.Tables("DISTRIBUCION_CI")
            oDtCI_x_OS.TableName = "CI_x_OS"
            '================================================
            oDtTempCopy = oDtDetalle.Clone
            For Each dr As DataRow In oDtDetalle.Rows
                Dim y As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = objDataSet.Tables(0).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For i As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(i).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(i).Item("TCTCSF").ToString.Trim
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next



            '==================RESUMEN DE LOTES=====================
            Dim drSelect As DataRow() = Nothing
            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            objDato_Default = New DataTable
            objDato_Default = objDataSet.Tables(1).Copy
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            Dim oDtv As DataView = New DataView(objDato_Default)
            oDtv.Sort = "LOTE DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count
            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("LOTE = '" + oTabla.Rows(i)("LOTE").ToString.Trim + "'")
                TotalKG = 0
                TotalM3 = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = oDtResLote.NewRow
                    objDataRow.Item("LOTE") = oTabla.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("PESO") = TotalKG
                    objDataRow.Item("VOLUMEN") = TotalM3
                    oDtResLote.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i
            '========================================================================
            '================RESUMEN DE CUENTAS=================
            Dim drSelectCuentas As DataRow() = Nothing
            objDato_Default = New DataTable
            objDato_Default = oDtTempCopy.Copy
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            objDato_Default.Columns.Remove("KG")
            objDato_Default.Columns.Remove("M3")
            objDato_Default.Columns.Remove("LOTE")
            objDato_Default.Columns.Remove("BULTOS")
            Dim oDtvCuentas As DataView = New DataView(objDato_Default)
            oDtvCuentas.RowFilter = "FLAG_DIST <> 'CI_SG' "  '" POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaCuentas As New DataTable
            oTablaCuentas = oDtvCuentas.ToTable(True, "CUENTA_IMPUTACION")

            For i As Integer = 0 To oTablaCuentas.Rows.Count - 1
                objDataRow = oDtResCuenta.NewRow
                objDataRow.Item("CUENTA") = oTablaCuentas.Rows(i)("CUENTA_IMPUTACION").ToString.Trim
                objDataRow.Item("PORCENTAJE") = 0
                objDataRow.Item("MONTO") = 0
                oDtResCuenta.Rows.Add(objDataRow)
            Next
            '============================================================================
            '============================================================================
            '===Copiamos las tablas a un nuevo DataSet que sera enviado al Cargo Plan====
            Dim objDsFluvial As New DataSet
            oDtTempCopy.Columns.Remove("FLAG_DIST") 'Quitamos el Flag usado
            objDsFluvial.Tables.Add(objDataSet.Tables("CABECERA").Copy)
            objDsFluvial.Tables.Add(oDtTempCopy.Copy)
            objDsFluvial.Tables.Add(oDtMaterial.Copy)
            objDsFluvial.Tables.Add(oDtResLote.Copy)
            objDsFluvial.Tables.Add(oDtResCuenta.Copy)
            '============================================================================
            '============================================================================
            '============================================================================
            'objDataSet.Tables.Add(oDtMaterial.Copy)
            'objDataSet.Tables.Add(oDtResLote.Copy)
            'objDataSet.Tables.Add(oDtResCuenta.Copy)



            objDsFluvial.Tables("DETALLE").Columns.Add("SIN_CUENTA").SetOrdinal(21)


            Dim grafo, orden, elementopep, centro_coste, cuenta_mayor As String



            For Each dr As DataRow In objDsFluvial.Tables("DETALLE").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()

                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next



            Return objDsFluvial 'objDataSet
            'Catch ex As Exception
            '    Return objDataSet
            'End Try
        End Function


        Private Sub TablaFluvialResumenLote(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PORCENTAJE", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PESO", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("VOLUMEN", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("MONTO", GetType(System.Double)))
        End Sub

        Private Sub TablaFluvialDetalleMaterial(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("MATERIAL", GetType(System.String)))
        End Sub

        Private Sub TablaFluvialResumenCuenta(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("CUENTA", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PORCENTAJE", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("MONTO", GetType(System.Double)))
        End Sub

        Private Sub TablaFluvialResumenLote_All(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PORCENTAJE", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PESO", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("VOLUMEN", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("MONTO", GetType(System.Double)))
        End Sub

        Private Sub TablaFluvialDetalleMaterial_All(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("MATERIAL", GetType(System.String)))
        End Sub

        Private Sub TablaFluvialResumenCuenta_All(ByRef oDt As DataTable)
            oDt.Columns.Clear()
            oDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("CUENTA", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("PORCENTAJE", GetType(System.Double)))
            oDt.Columns.Add(New DataColumn("MONTO", GetType(System.Double)))
        End Sub


        Public Function Exportar_Reporte_Cargo_Plan_Terrestre_All(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))

            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_ALL_LM", objParam)


            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_ALL_LM_ST", objParam)


            ''''Crea las Variables Principales
            Dim objCabereca As New DataTable
            Dim ObjDetalle As New DataTable
            Dim ObjTotales As New DataTable
            Dim strNroCargoPlan As String = ""
            '''' En el Detalle
            '''' Inserta la Cantidad de Registros Por Cliente , Nro Solic y Correlativo
            ObjDetalle = objDataSet.Tables(1).Copy

            ''''Crea la tabla para la Cabecera
            objCabereca.Columns.Add("CCLNT", Type.GetType("System.String"))
            objCabereca.Columns.Add("CTRMNC", Type.GetType("System.String"))
            objCabereca.Columns.Add("NGUIRM", Type.GetType("System.String"))

            objCabereca.Columns.Add("TITULO", Type.GetType("System.String"))
            objCabereca.Columns.Add("FECHA", Type.GetType("System.String"))
            objCabereca.Columns.Add("CHOFER", Type.GetType("System.String"))
            objCabereca.Columns.Add("MARCA", Type.GetType("System.String"))
            objCabereca.Columns.Add("BREVETE", Type.GetType("System.String"))
            objCabereca.Columns.Add("PLACAS", Type.GetType("System.String"))
            objCabereca.Columns.Add("ORIGEN", Type.GetType("System.String"))
            objCabereca.Columns.Add("DESTINO", Type.GetType("System.String"))
            objCabereca.Columns.Add("OPERACION", Type.GetType("System.String"))
            objCabereca.Columns.Add("TRANSPORTISTA", Type.GetType("System.String"))
            objCabereca.Columns.Add("TARIFA_MONEDA", Type.GetType("System.Double"))
            objCabereca.Columns.Add("TARIFA_MONTO", Type.GetType("System.Double"))
            objCabereca.Columns.Add("CARGO_PLAN", Type.GetType("System.String"))

            Dim workRow As DataRow
            Dim strLugar As String = ""
            Dim drSelect As DataRow() = Nothing
            Dim i As Integer
            For i = 0 To objDataSet.Tables(0).Rows.Count - 1
                'Para El TiTulo ""Busca el primer registro de Almacen y lo pinta en la cabecera""
                drSelect = ObjDetalle.Select("CCLNT = " + objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString + "  and CTRMNC = " + objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString + "  and NGUIRM = " + objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString + "")
                If drSelect.Length > 0 Then
                    strLugar = drSelect(0).Item("TCMPAL").ToString
                Else
                    strLugar = ""
                End If
                workRow = objCabereca.NewRow()
                workRow("CCLNT") = objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString
                workRow("CTRMNC") = objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString
                workRow("NGUIRM") = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString
                workRow("TITULO") = objDataSet.Tables(0).Rows(i).Item("TIPO_VEHICULO").ToString.Trim & "  -  " & "ALMACEN : " & strLugar.Trim
                workRow("FECHA") = "FECHA : " & objDataSet.Tables(0).Rows(i).Item("FECHA").ToString
                workRow("CHOFER") = "CHOFER :  " & objDataSet.Tables(0).Rows(i).Item("CONDUCTOR").ToString
                workRow("MARCA") = "MARCA :  " & objDataSet.Tables(0).Rows(i).Item("MARCA").ToString
                workRow("BREVETE") = "BREVETE :  " & objDataSet.Tables(0).Rows(i).Item("BREVETE").ToString
                workRow("PLACAS") = "PLACAS :  " & objDataSet.Tables(0).Rows(i).Item("TRACTO").ToString & " / " & objDataSet.Tables(0).Rows(i).Item("ACOPLADO").ToString
                workRow("ORIGEN") = "ORIGEN :  " & objDataSet.Tables(0).Rows(i).Item("ORIGEN").ToString
                workRow("DESTINO") = "DESTINO :  " & objDataSet.Tables(0).Rows(i).Item("DESTINO").ToString
                workRow("OPERACION") = "NRO. OPERACION :  " & objDataSet.Tables(0).Rows(i).Item("OPERACION").ToString
                workRow("TRANSPORTISTA") = "TRANSPORTISTA :  " & objDataSet.Tables(0).Rows(i).Item("TCMTRT").ToString
                workRow("TARIFA_MONEDA") = objDataSet.Tables(0).Rows(i).Item("CMNDGU")
                workRow("TARIFA_MONTO") = objDataSet.Tables(0).Rows(i).Item("ISRVGU")
                strNroCargoPlan = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString.PadLeft(10, "0").Substring(0, 3) & "-" & objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString.PadLeft(10, "0").Substring(3)
                workRow("CARGO_PLAN") = "NRO. CARGO PLAN :  " & strNroCargoPlan
                objCabereca.Rows.Add(workRow)
            Next
            '''' Creamos el Resumen por Transportista
            Dim objResTransp As New DataTable
            Dim TotCostoTrans As Double = 0D
            objResTransp.Columns.Add("CTRMNC", Type.GetType("System.Double"))
            objResTransp.Columns.Add("TRANSPORTISTA", Type.GetType("System.String"))
            objResTransp.Columns.Add("TARIFA_MONTO", Type.GetType("System.Double"))
            Dim oDvRes As DataView = New DataView(objCabereca.Copy)
            oDvRes.Sort = "CTRMNC DESC"
            Dim oTabRes As New DataTable
            oTabRes = oDvRes.ToTable
            For iii As Integer = 0 To oTabRes.Rows.Count - 1
                Dim dt As New DataTable
                dt = oTabRes.Copy
                dt.DefaultView.RowFilter = "CTRMNC =" & oTabRes.Rows(iii).Item("CTRMNC").ToString.Trim
                TotCostoTrans = 0
                dt = dt.DefaultView.ToTable
                For dr As Integer = 0 To dt.Rows.Count - 1
                    TotCostoTrans += Convert.ToDouble(dt.Rows(dr).Item("TARIFA_MONTO"))
                Next
                If dt.Rows.Count > 0 Then
                    workRow = objResTransp.NewRow
                    workRow("CTRMNC") = oTabRes.Rows(iii).Item("CTRMNC")
                    workRow("TRANSPORTISTA") = oTabRes.Rows(iii).Item("TRANSPORTISTA")
                    workRow("TARIFA_MONTO") = TotCostoTrans
                    objResTransp.Rows.Add(workRow)
                End If
                iii = iii + dt.Rows.Count - 1
            Next
            '''' Llaves Principales
            Dim strCCLNT As String = ""
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""

            ''''Crea la tabla para los Totales
            ObjTotales.Columns.Add("CCLNT", Type.GetType("System.String"))
            ObjTotales.Columns.Add("CTRMNC", Type.GetType("System.String"))
            ObjTotales.Columns.Add("NGUIRM", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TBULTOS", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TPESO", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TM3", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TVOL", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TPORCE", Type.GetType("System.String"))
            '================================================
            '''' Crea Los Totales
            '================================================
            Dim TotalKG As Double = 0D
            Dim TotalM3 As Double = 0D
            Dim TotalBUL As Double = 0D
            Dim TotalVOL As Double = 0D
            Dim TotalPORCE As Double = 0D
            '''' limpia llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            Dim objDataRow As DataRow

            For m As Integer = 0 To ObjDetalle.Rows.Count - 1
                If (strCCLNT = "" AndAlso strCTRMNC = "" AndAlso strNGUIRM = "") OrElse (ObjDetalle.Rows(m)("CCLNT").ToString = strCCLNT AndAlso ObjDetalle.Rows(m)("CTRMNC").ToString = strCTRMNC AndAlso ObjDetalle.Rows(m)("NGUIRM").ToString = strNGUIRM) Then
                    TotalKG += Convert.ToDouble(ObjDetalle.Rows(m)("PESO"))
                    TotalM3 += Convert.ToDouble(ObjDetalle.Rows(m)("M3"))
                    TotalBUL += Convert.ToDouble(ObjDetalle.Rows(m)("BULTOS"))
                    TotalVOL += Convert.ToDouble(ObjDetalle.Rows(m)("PESO_VOL"))
                    TotalPORCE += Convert.ToDouble(ObjDetalle.Rows(m)("POR"))
                Else
                    objDataRow = ObjTotales.NewRow

                    objDataRow("CCLNT") = strCCLNT
                    objDataRow("CTRMNC") = strCTRMNC
                    objDataRow("NGUIRM") = strNGUIRM
                    objDataRow("TBULTOS") = TotalBUL
                    objDataRow("TPESO") = TotalKG
                    objDataRow("TM3") = TotalM3
                    objDataRow("TVOL") = TotalVOL 'Para el peso volumen
                    objDataRow("TPORCE") = TotalPORCE 'Para el porcentaje
                    ObjTotales.Rows.Add(objDataRow)

                    TotalKG = Convert.ToDouble(ObjDetalle.Rows(m)("PESO"))
                    TotalM3 = Convert.ToDouble(ObjDetalle.Rows(m)("M3"))
                    TotalBUL = Convert.ToDouble(ObjDetalle.Rows(m)("BULTOS"))
                    TotalVOL = Convert.ToDouble(ObjDetalle.Rows(m)("PESO_VOL"))
                    TotalPORCE = Convert.ToDouble(ObjDetalle.Rows(m)("POR"))
                End If
                strCCLNT = ObjDetalle.Rows(m)("CCLNT").ToString
                strCTRMNC = ObjDetalle.Rows(m)("CTRMNC").ToString
                strNGUIRM = ObjDetalle.Rows(m)("NGUIRM").ToString
            Next m
            ''''Para El Ultimo siempre que Exista Data
            If ObjDetalle.Rows.Count > 0 Then
                objDataRow = ObjTotales.NewRow
                objDataRow("CCLNT") = strCCLNT
                objDataRow("CTRMNC") = strCTRMNC
                objDataRow("NGUIRM") = strNGUIRM
                objDataRow("TBULTOS") = TotalBUL
                objDataRow("TPESO") = TotalKG
                objDataRow("TM3") = TotalM3
                objDataRow("TVOL") = TotalVOL 'Para el peso volumen
                objDataRow("TPORCE") = TotalPORCE 'Para el porcentaje
                ObjTotales.Rows.Add(objDataRow)
            End If
            '''' Se cambia el nombre de la columna de Guia Remision
            ObjDetalle.Columns("GUIA_REMISION").ColumnName = "GUIA_PROV"
            'Se da nombre a tablas principales usadas
            Dim DsReturn As New Data.DataSet 'DataSet principal a enviar al NPOI
            objCabereca.TableName = "DT_Filtros"
            ObjDetalle.TableName = "DT_Detalle"
            ObjTotales.TableName = "DT_Totales"
            '''' Se insertan al dataset para NPOI
            DsReturn.Tables.Add(objCabereca)
            DsReturn.Tables.Add(ObjTotales)
            '''' Hacemos los cambios en la tabla de Detalle antes de insertarlo
            ObjDetalle.Columns.Add("POR_CI", GetType(System.Double))
            ObjDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = ObjDetalle.Clone
            For Each dr As DataRow In ObjDetalle.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM
                Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM & " AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim  
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("POR") = dr("POR")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCST")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next
            '================================================
            ''''Struct Reporte General
            '================================================
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy 'objDataSet.Tables(1).Copy()

            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""
            Dim dblTVOL As Double = 0D

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA_CI", GetType(System.Double)))
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA", GetType(System.Double)))
            ObjGeneralReport.Columns.Remove("FLAG_DIST")
            'Llena las Cabeceras en el Detalle
            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                dblTVOL = 0
                'Busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objDataSet.Tables(0), strPk0, strPk1, strPk2)
                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = RowFiltro.Item("ORIGEN")
                    RowTemp.Item("DESTINO") = RowFiltro.Item("DESTINO")
                    RowTemp.Item("MEDIO") = RowFiltro.Item("TCMTRT") + Chr(10) + RowFiltro.Item("MARCA")
                    RowTemp.Item("OPERACION") = RowFiltro.Item("OPERACION")
                    'dblTVOL = SearchDataTable(ObjTotales, strPk0, strPk1, strPk2).Rows(0).Item("TVOL")

                    If IsDBNull(RowTemp.Item("POR_CI")) Then
                        RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01, 2)
                    Else
                        RowTemp.Item("TARIFA_CI") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01 * RowTemp.Item("POR_CI") * 0.01, 2)
                    End If
                    'If IsDBNull(RowTemp.Item("POR_CI")) Then
                    '  RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01, 2)
                    'Else
                    '  RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01 * RowTemp.Item("POR_CI") * 0.01, 2)
                    'End If
                    RowTemp.AcceptChanges()
                Next
            Next
            ObjGeneralReport.Columns.Remove("CLIENTE")
            ObjGeneralReport.Columns.Remove("POR")
            ObjGeneralReport.Columns.Remove("CREFFW")
            ObjGeneralReport.Columns.Remove("TCMPAL")
            ObjGeneralReport.Columns.Remove("CCLNT1")
            '=======================================================
            '==RESUMEN COSTOS - CUENTA DE IMPUTACION X CARGO PLAN===
            '=======================================================
            Dim oDtCtaImput As New DataTable
            Dim oDrCtaImput As DataRow
            Dim TotPor As Double = 0D
            oDtCtaImput.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImput.Columns.Add("CTRMNC", GetType(System.String))
            oDtCtaImput.Columns.Add("NGUIRM", GetType(System.String))
            oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImput.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtv As DataView = New DataView(oDtTempCopy.Copy) 'DataView(ObjDetalle.Copy)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM, CUENTA_IMPUTACION DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count
            For ii As Integer = 0 To OriginalCount - 1
                drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim + "' AND CCLNT = " + oTabla.Rows(ii)("CCLNT").ToString.Trim + " AND CTRMNC = " + _
                                                    oTabla.Rows(ii)("CTRMNC").ToString.Trim + " AND NGUIRM =" + oTabla.Rows(ii)("NGUIRM").ToString.Trim + " AND FLAG_DIST <> 'CI_SG' ")
                TotPor = 0
                For Each dr As DataRow In drSelect
                    If IsDBNull(dr("POR_CI")) Then
                        TotPor += Convert.ToDouble(dr("POR"))
                    Else
                        TotPor += Convert.ToDouble(dr("POR")) * Convert.ToDouble(dr("POR_CI")) * 0.01
                    End If
                    'TotPor += Convert.ToDouble(dr("PESO_VOL"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImput = oDtCtaImput.NewRow
                    oDrCtaImput.Item("CCLNT") = oTabla.Rows(ii)("CCLNT").ToString.Trim
                    oDrCtaImput.Item("CTRMNC") = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                    oDrCtaImput.Item("NGUIRM") = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                    oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim)
                    Dim tmpTrfMonto As Double = SearchDataTable(objCabereca, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TARIFA_MONTO")
                    Dim tmpPsoVol As Double = SearchDataTable(ObjTotales, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TVOL")
                    where = "CCLNT = " + oDrCtaImput.Item("CCLNT") + " AND CTRMNC = " + oDrCtaImput.Item("CTRMNC") + " AND NGUIRM =" + oDrCtaImput.Item("NGUIRM")
                    Dim tmpTarifa As Double = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("ISRVGU")
                    oDrCtaImput.Item("Tarifa") = TotPor * tmpTarifa * 0.01 '      Math.Round(IIf(tmpPsoVol = 0, 0, TotPor * tmpTrfMonto / tmpPsoVol), 2)
                    oDtCtaImput.Rows.Add(oDrCtaImput)
                    ii = ii + drSelect.Length - 1
                End If
            Next
            '================================================
            '============RESUMEN COSTOS-LOTES===============
            '================================================
            Dim oDtLote As New DataTable
            Dim oDrLote As DataRow
            Dim dtSelect As New DataTable
            Dim TotPesoLote As Double = 0D
            Dim TotM3Lote As Double = 0D
            Dim TotCostoLote As Double = 0D
            oDtLote.Columns.Add("CCLNT", GetType(System.String))
            oDtLote.Columns.Add("Lote", GetType(System.String))
            oDtLote.Columns.Add("Tns.", GetType(System.String))
            oDtLote.Columns.Add("M3", GetType(System.String))
            oDtLote.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvLote As DataView = New DataView(ObjGeneralReport.Copy)
            oDtvLote.Sort = "CCLNT, LOTE, TARIFA DESC"
            oDtvLote.RowFilter = " POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaLote As New DataTable
            oTablaLote = oDtvLote.ToTable
            Dim OriginalCountLote As Integer = oTablaLote.Rows.Count
            For ii As Integer = 0 To OriginalCountLote - 1
                dtSelect = SearchGenericoDataTable(oTablaLote, "LOTE = '" + oTablaLote.Rows(ii)("LOTE").ToString.Trim + "' AND CCLNT = " + oTablaLote.Rows(ii)("CCLNT").ToString.Trim)
                TotPesoLote = 0D
                TotM3Lote = 0D
                TotCostoLote = 0D
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoLote += Convert.ToDouble(dr("PESO"))
                    TotM3Lote += Convert.ToDouble(dr("M3"))
                    TotCostoLote += Convert.ToDouble(dr("TARIFA"))
                Next
                If dtSelect.Rows.Count > 0 Then
                    oDrLote = oDtLote.NewRow
                    oDrLote.Item("CCLNT") = oTablaLote.Rows(ii)("CCLNT").ToString.Trim
                    oDrLote.Item("Lote") = IIf(oTablaLote.Rows(ii)("LOTE").ToString.Trim = "", "SIN LOTE", oTablaLote.Rows(ii)("LOTE").ToString.Trim)
                    oDrLote.Item("Tns.") = TotPesoLote / 1000 'Convertimos Kilos a Toneladas
                    oDrLote.Item("M3") = TotM3Lote
                    oDrLote.Item("Tarifa") = TotCostoLote
                    oDtLote.Rows.Add(oDrLote)
                    ii = ii + dtSelect.Rows.Count - 1
                End If
            Next
            '=============================================================
            '===========RESUMEN COSTOS - CUENTA DE IMPUTACION GENERAL=====
            '=============================================================
            Dim TotPesoGralCI As Double = 0D
            Dim oDtCtaImputGral As New DataTable
            Dim oDrCtaImputGral As DataRow
            oDtCtaImputGral.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvCIGral As DataView = New DataView(oDtCtaImput.Copy)
            oDtvCIGral.Sort = "CCLNT, Cuenta, Tarifa DESC"
            Dim oTablaCIGral As New DataTable
            oTablaCIGral = oDtvCIGral.ToTable
            Dim CountTablaCIGral As Integer = oTablaCIGral.Rows.Count
            For iCIGral As Integer = 0 To CountTablaCIGral - 1
                dtSelect = SearchGenericoDataTable(oTablaCIGral, "Cuenta = '" + oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim + "' AND CCLNT = " + oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim)
                TotPesoGralCI = 0
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoGralCI += Convert.ToDouble(dr("Tarifa"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImputGral = oDtCtaImputGral.NewRow
                    oDrCtaImputGral.Item("CCLNT") = oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim
                    oDrCtaImputGral.Item("Cuenta") = oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim
                    oDrCtaImputGral.Item("Tarifa") = TotPesoGralCI
                    oDtCtaImputGral.Rows.Add(oDrCtaImputGral)
                    iCIGral = iCIGral + dtSelect.Rows.Count - 1 ''iCIGral = iCIGral + drSelect.Length - 1
                End If
            Next
            '================================================
            '================================================
            Dim oDtvClientes As DataView = New DataView(ObjDetalle)
            Dim oTablaClientes As New DataTable
            oTablaClientes = oDtvClientes.ToTable(True, "CCLNT", "TCMPCL")
            oTablaClientes.TableName = "DT_Clientes"
            ObjGeneralReport.TableName = "DT_General"
            oDtCtaImput.TableName = "DT_ResCntImputacion"
            objResTransp.TableName = "DT_ResCosto_Trans"
            oDtCtaImputGral.TableName = "DT_ResCntImputacionGral"
            oDtLote.TableName = "DT_ResLoteGral"

            'Se agrega el DataSet
            oDtTempCopy.Columns.Remove("FLAG_DIST")
            DsReturn.Tables.Add(oDtTempCopy) 'ObjDetalle 'CAMBIO EL DETALLE POR EL DETALLE AMPLIADO

            DsReturn.Tables.Add(oTablaClientes.Copy)
            DsReturn.Tables.Add(ObjGeneralReport)
            DsReturn.Tables.Add(oDtCtaImput)
            DsReturn.Tables.Add(objResTransp)
            DsReturn.Tables.Add(oDtCtaImputGral)
            DsReturn.Tables.Add(oDtLote)
            Return DsReturn
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return Nothing
            'End Try
        End Function
        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Terrestre_All_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim objDataSet As New DataSet
            Dim objParam As New Parameter
            'Try

            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))

            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_ALL_LM", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_TERRESTRE_ALL_LM_ST_PPC", objParam)


            ''''Crea las Variables Principales
            Dim objCabereca As New DataTable
            Dim ObjDetalle As New DataTable
            Dim ObjTotales As New DataTable
            Dim strNroCargoPlan As String = ""
            '''' En el Detalle
            '''' Inserta la Cantidad de Registros Por Cliente , Nro Solic y Correlativo
            ObjDetalle = objDataSet.Tables(1).Copy

            ''''Crea la tabla para la Cabecera
            objCabereca.Columns.Add("CCLNT", Type.GetType("System.String"))
            objCabereca.Columns.Add("CTRMNC", Type.GetType("System.String"))
            objCabereca.Columns.Add("NGUIRM", Type.GetType("System.String"))

            objCabereca.Columns.Add("TITULO", Type.GetType("System.String"))
            objCabereca.Columns.Add("FECHA", Type.GetType("System.String"))
            objCabereca.Columns.Add("CHOFER", Type.GetType("System.String"))
            objCabereca.Columns.Add("MARCA", Type.GetType("System.String"))
            objCabereca.Columns.Add("BREVETE", Type.GetType("System.String"))
            objCabereca.Columns.Add("PLACAS", Type.GetType("System.String"))
            objCabereca.Columns.Add("ORIGEN", Type.GetType("System.String"))
            objCabereca.Columns.Add("DESTINO", Type.GetType("System.String"))
            objCabereca.Columns.Add("OPERACION", Type.GetType("System.String"))
            objCabereca.Columns.Add("TRANSPORTISTA", Type.GetType("System.String"))
            objCabereca.Columns.Add("TARIFA_MONEDA", Type.GetType("System.Double"))
            objCabereca.Columns.Add("TARIFA_MONTO", Type.GetType("System.Double"))
            objCabereca.Columns.Add("CARGO_PLAN", Type.GetType("System.String"))

            Dim workRow As DataRow
            Dim strLugar As String = ""
            Dim drSelect As DataRow() = Nothing
            Dim i As Integer
            For i = 0 To objDataSet.Tables(0).Rows.Count - 1
                'Para El TiTulo ""Busca el primer registro de Almacen y lo pinta en la cabecera""
                drSelect = ObjDetalle.Select("CCLNT = " + objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString + "  and CTRMNC = " + objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString + "  and NGUIRM = " + objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString + "")
                If drSelect.Length > 0 Then
                    strLugar = drSelect(0).Item("TCMPAL").ToString
                Else
                    strLugar = ""
                End If
                workRow = objCabereca.NewRow()
                workRow("CCLNT") = objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString
                workRow("CTRMNC") = objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString
                workRow("NGUIRM") = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString
                workRow("TITULO") = objDataSet.Tables(0).Rows(i).Item("TIPO_VEHICULO").ToString.Trim & "  -  " & "ALMACEN : " & strLugar.Trim
                workRow("FECHA") = "FECHA : " & objDataSet.Tables(0).Rows(i).Item("FECHA").ToString
                workRow("CHOFER") = "CHOFER :  " & objDataSet.Tables(0).Rows(i).Item("CONDUCTOR").ToString
                workRow("MARCA") = "MARCA :  " & objDataSet.Tables(0).Rows(i).Item("MARCA").ToString
                workRow("BREVETE") = "BREVETE :  " & objDataSet.Tables(0).Rows(i).Item("BREVETE").ToString
                workRow("PLACAS") = "PLACAS :  " & objDataSet.Tables(0).Rows(i).Item("TRACTO").ToString & " / " & objDataSet.Tables(0).Rows(i).Item("ACOPLADO").ToString
                workRow("ORIGEN") = "ORIGEN :  " & objDataSet.Tables(0).Rows(i).Item("ORIGEN").ToString
                workRow("DESTINO") = "DESTINO :  " & objDataSet.Tables(0).Rows(i).Item("DESTINO").ToString
                workRow("OPERACION") = "NRO. OPERACION :  " & objDataSet.Tables(0).Rows(i).Item("OPERACION").ToString
                workRow("TRANSPORTISTA") = "TRANSPORTISTA :  " & objDataSet.Tables(0).Rows(i).Item("TCMTRT").ToString
                workRow("TARIFA_MONEDA") = objDataSet.Tables(0).Rows(i).Item("CMNDGU")
                workRow("TARIFA_MONTO") = objDataSet.Tables(0).Rows(i).Item("ISRVGU")
                strNroCargoPlan = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString.PadLeft(10, "0").Substring(0, 3) & "-" & objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString.PadLeft(10, "0").Substring(3)
                workRow("CARGO_PLAN") = "NRO. CARGO PLAN :  " & strNroCargoPlan
                objCabereca.Rows.Add(workRow)
            Next
            '''' Creamos el Resumen por Transportista
            Dim objResTransp As New DataTable
            Dim TotCostoTrans As Double = 0D
            objResTransp.Columns.Add("CTRMNC", Type.GetType("System.Double"))
            objResTransp.Columns.Add("TRANSPORTISTA", Type.GetType("System.String"))
            objResTransp.Columns.Add("TARIFA_MONTO", Type.GetType("System.Double"))
            Dim oDvRes As DataView = New DataView(objCabereca.Copy)
            oDvRes.Sort = "CTRMNC DESC"
            Dim oTabRes As New DataTable
            oTabRes = oDvRes.ToTable
            For iii As Integer = 0 To oTabRes.Rows.Count - 1
                Dim dt As New DataTable
                dt = oTabRes.Copy
                dt.DefaultView.RowFilter = "CTRMNC =" & oTabRes.Rows(iii).Item("CTRMNC").ToString.Trim
                TotCostoTrans = 0
                dt = dt.DefaultView.ToTable
                For dr As Integer = 0 To dt.Rows.Count - 1
                    TotCostoTrans += Convert.ToDouble(dt.Rows(dr).Item("TARIFA_MONTO"))
                Next
                If dt.Rows.Count > 0 Then
                    workRow = objResTransp.NewRow
                    workRow("CTRMNC") = oTabRes.Rows(iii).Item("CTRMNC")
                    workRow("TRANSPORTISTA") = oTabRes.Rows(iii).Item("TRANSPORTISTA")
                    workRow("TARIFA_MONTO") = TotCostoTrans
                    objResTransp.Rows.Add(workRow)
                End If
                iii = iii + dt.Rows.Count - 1
            Next
            '''' Llaves Principales
            Dim strCCLNT As String = ""
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""

            ''''Crea la tabla para los Totales
            ObjTotales.Columns.Add("CCLNT", Type.GetType("System.String"))
            ObjTotales.Columns.Add("CTRMNC", Type.GetType("System.String"))
            ObjTotales.Columns.Add("NGUIRM", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TBULTOS", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TPESO", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TM3", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TVOL", Type.GetType("System.String"))
            ObjTotales.Columns.Add("TPORCE", Type.GetType("System.String"))
            '================================================
            '''' Crea Los Totales
            '================================================
            Dim TotalKG As Double = 0D
            Dim TotalM3 As Double = 0D
            Dim TotalBUL As Double = 0D
            Dim TotalVOL As Double = 0D
            Dim TotalPORCE As Double = 0D
            '''' limpia llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            Dim objDataRow As DataRow

            For m As Integer = 0 To ObjDetalle.Rows.Count - 1
                If (strCCLNT = "" AndAlso strCTRMNC = "" AndAlso strNGUIRM = "") OrElse (ObjDetalle.Rows(m)("CCLNT").ToString = strCCLNT AndAlso ObjDetalle.Rows(m)("CTRMNC").ToString = strCTRMNC AndAlso ObjDetalle.Rows(m)("NGUIRM").ToString = strNGUIRM) Then
                    TotalKG += Convert.ToDouble(ObjDetalle.Rows(m)("PESO"))
                    TotalM3 += Convert.ToDouble(ObjDetalle.Rows(m)("M3"))
                    TotalBUL += Convert.ToDouble(ObjDetalle.Rows(m)("BULTOS"))
                    TotalVOL += Convert.ToDouble(ObjDetalle.Rows(m)("PESO_VOL"))
                    TotalPORCE += Convert.ToDouble(ObjDetalle.Rows(m)("POR"))
                Else
                    objDataRow = ObjTotales.NewRow

                    objDataRow("CCLNT") = strCCLNT
                    objDataRow("CTRMNC") = strCTRMNC
                    objDataRow("NGUIRM") = strNGUIRM
                    objDataRow("TBULTOS") = TotalBUL
                    objDataRow("TPESO") = TotalKG
                    objDataRow("TM3") = TotalM3
                    objDataRow("TVOL") = TotalVOL 'Para el peso volumen
                    objDataRow("TPORCE") = TotalPORCE 'Para el porcentaje
                    ObjTotales.Rows.Add(objDataRow)

                    TotalKG = Convert.ToDouble(ObjDetalle.Rows(m)("PESO"))
                    TotalM3 = Convert.ToDouble(ObjDetalle.Rows(m)("M3"))
                    TotalBUL = Convert.ToDouble(ObjDetalle.Rows(m)("BULTOS"))
                    TotalVOL = Convert.ToDouble(ObjDetalle.Rows(m)("PESO_VOL"))
                    TotalPORCE = Convert.ToDouble(ObjDetalle.Rows(m)("POR"))
                End If
                strCCLNT = ObjDetalle.Rows(m)("CCLNT").ToString
                strCTRMNC = ObjDetalle.Rows(m)("CTRMNC").ToString
                strNGUIRM = ObjDetalle.Rows(m)("NGUIRM").ToString
            Next m
            ''''Para El Ultimo siempre que Exista Data
            If ObjDetalle.Rows.Count > 0 Then
                objDataRow = ObjTotales.NewRow
                objDataRow("CCLNT") = strCCLNT
                objDataRow("CTRMNC") = strCTRMNC
                objDataRow("NGUIRM") = strNGUIRM
                objDataRow("TBULTOS") = TotalBUL
                objDataRow("TPESO") = TotalKG
                objDataRow("TM3") = TotalM3
                objDataRow("TVOL") = TotalVOL 'Para el peso volumen
                objDataRow("TPORCE") = TotalPORCE 'Para el porcentaje
                ObjTotales.Rows.Add(objDataRow)
            End If
            '''' Se cambia el nombre de la columna de Guia Remision
            ObjDetalle.Columns("GUIA_REMISION").ColumnName = "GUIA_PROV"
            'Se da nombre a tablas principales usadas
            Dim DsReturn As New Data.DataSet 'DataSet principal a enviar al NPOI
            objCabereca.TableName = "DT_Filtros"
            ObjDetalle.TableName = "DT_Detalle"
            ObjTotales.TableName = "DT_Totales"
            '''' Se insertan al dataset para NPOI
            DsReturn.Tables.Add(objCabereca)
            DsReturn.Tables.Add(ObjTotales)
            '''' Hacemos los cambios en la tabla de Detalle antes de insertarlo
            ObjDetalle.Columns.Add("POR_CI", GetType(System.Double))
            ObjDetalle.Columns.Add("FLAG_DIST", GetType(System.String))
            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = ObjDetalle.Clone
            For Each dr As DataRow In ObjDetalle.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM
                Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM & " AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" ' CREAMOS UN FLAG QUE IDENTIFICA QUE ES EL PRIMER REGISTRO (CAB) DE UNA DISTRIBUCION  ====================== '& dr("OC").ToString.Trim  
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("POR") = dr("POR")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCST")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next
            '================================================
            ''''Struct Reporte General
            '================================================
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy 'objDataSet.Tables(1).Copy()

            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""
            Dim dblTVOL As Double = 0D

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA_CI", GetType(System.Double)))
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA", GetType(System.Double)))
            ObjGeneralReport.Columns.Remove("FLAG_DIST")
            'Llena las Cabeceras en el Detalle
            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                dblTVOL = 0
                'Busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objDataSet.Tables(0), strPk0, strPk1, strPk2)
                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = RowFiltro.Item("ORIGEN")
                    RowTemp.Item("DESTINO") = RowFiltro.Item("DESTINO")
                    RowTemp.Item("MEDIO") = RowFiltro.Item("TCMTRT") + Chr(10) + RowFiltro.Item("MARCA")
                    RowTemp.Item("OPERACION") = RowFiltro.Item("OPERACION")
                    'dblTVOL = SearchDataTable(ObjTotales, strPk0, strPk1, strPk2).Rows(0).Item("TVOL")

                    If IsDBNull(RowTemp.Item("POR_CI")) Then
                        RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01, 2)
                    Else
                        RowTemp.Item("TARIFA_CI") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01 * RowTemp.Item("POR_CI") * 0.01, 2)
                    End If
                    'If IsDBNull(RowTemp.Item("POR_CI")) Then
                    '  RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01, 2)
                    'Else
                    '  RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("ISRVGU") * RowTemp.Item("POR") * 0.01 * RowTemp.Item("POR_CI") * 0.01, 2)
                    'End If
                    RowTemp.AcceptChanges()
                Next
            Next
            ObjGeneralReport.Columns.Remove("CLIENTE")
            ObjGeneralReport.Columns.Remove("POR")
            ObjGeneralReport.Columns.Remove("CREFFW")
            ObjGeneralReport.Columns.Remove("TCMPAL")
            ObjGeneralReport.Columns.Remove("CCLNT1")
            '=======================================================
            '==RESUMEN COSTOS - CUENTA DE IMPUTACION X CARGO PLAN===
            '=======================================================
            Dim oDtCtaImput As New DataTable
            Dim oDrCtaImput As DataRow
            Dim TotPor As Double = 0D
            oDtCtaImput.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImput.Columns.Add("CTRMNC", GetType(System.String))
            oDtCtaImput.Columns.Add("NGUIRM", GetType(System.String))
            oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImput.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtv As DataView = New DataView(oDtTempCopy.Copy) 'DataView(ObjDetalle.Copy)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM, CUENTA_IMPUTACION DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count
            For ii As Integer = 0 To OriginalCount - 1
                drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim + "' AND CCLNT = " + oTabla.Rows(ii)("CCLNT").ToString.Trim + " AND CTRMNC = " + _
                                                    oTabla.Rows(ii)("CTRMNC").ToString.Trim + " AND NGUIRM =" + oTabla.Rows(ii)("NGUIRM").ToString.Trim + " AND FLAG_DIST <> 'CI_SG' ")
                TotPor = 0
                For Each dr As DataRow In drSelect
                    If IsDBNull(dr("POR_CI")) Then
                        TotPor += Convert.ToDouble(dr("POR"))
                    Else
                        TotPor += Convert.ToDouble(dr("POR")) * Convert.ToDouble(dr("POR_CI")) * 0.01
                    End If
                    'TotPor += Convert.ToDouble(dr("PESO_VOL"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImput = oDtCtaImput.NewRow
                    oDrCtaImput.Item("CCLNT") = oTabla.Rows(ii)("CCLNT").ToString.Trim
                    oDrCtaImput.Item("CTRMNC") = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                    oDrCtaImput.Item("NGUIRM") = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                    oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim)
                    Dim tmpTrfMonto As Double = SearchDataTable(objCabereca, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TARIFA_MONTO")
                    Dim tmpPsoVol As Double = SearchDataTable(ObjTotales, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TVOL")
                    where = "CCLNT = " + oDrCtaImput.Item("CCLNT") + " AND CTRMNC = " + oDrCtaImput.Item("CTRMNC") + " AND NGUIRM =" + oDrCtaImput.Item("NGUIRM")
                    Dim tmpTarifa As Double = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("ISRVGU")
                    oDrCtaImput.Item("Tarifa") = TotPor * tmpTarifa * 0.01 '      Math.Round(IIf(tmpPsoVol = 0, 0, TotPor * tmpTrfMonto / tmpPsoVol), 2)
                    oDtCtaImput.Rows.Add(oDrCtaImput)
                    ii = ii + drSelect.Length - 1
                End If
            Next
            '================================================
            '============RESUMEN COSTOS-LOTES===============
            '================================================
            Dim oDtLote As New DataTable
            Dim oDrLote As DataRow
            Dim dtSelect As New DataTable
            Dim TotPesoLote As Double = 0D
            Dim TotM3Lote As Double = 0D
            Dim TotCostoLote As Double = 0D
            oDtLote.Columns.Add("CCLNT", GetType(System.String))
            oDtLote.Columns.Add("Lote", GetType(System.String))
            oDtLote.Columns.Add("Tns.", GetType(System.String))
            oDtLote.Columns.Add("M3", GetType(System.String))
            oDtLote.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvLote As DataView = New DataView(ObjGeneralReport.Copy)
            oDtvLote.Sort = "CCLNT, LOTE, TARIFA DESC"
            oDtvLote.RowFilter = " POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaLote As New DataTable
            oTablaLote = oDtvLote.ToTable
            Dim OriginalCountLote As Integer = oTablaLote.Rows.Count
            For ii As Integer = 0 To OriginalCountLote - 1
                dtSelect = SearchGenericoDataTable(oTablaLote, "LOTE = '" + oTablaLote.Rows(ii)("LOTE").ToString.Trim + "' AND CCLNT = " + oTablaLote.Rows(ii)("CCLNT").ToString.Trim)
                TotPesoLote = 0D
                TotM3Lote = 0D
                TotCostoLote = 0D
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoLote += Convert.ToDouble(dr("PESO"))
                    TotM3Lote += Convert.ToDouble(dr("M3"))
                    TotCostoLote += Convert.ToDouble(dr("TARIFA"))
                Next
                If dtSelect.Rows.Count > 0 Then
                    oDrLote = oDtLote.NewRow
                    oDrLote.Item("CCLNT") = oTablaLote.Rows(ii)("CCLNT").ToString.Trim
                    oDrLote.Item("Lote") = IIf(oTablaLote.Rows(ii)("LOTE").ToString.Trim = "", "SIN LOTE", oTablaLote.Rows(ii)("LOTE").ToString.Trim)
                    oDrLote.Item("Tns.") = TotPesoLote / 1000 'Convertimos Kilos a Toneladas
                    oDrLote.Item("M3") = TotM3Lote
                    oDrLote.Item("Tarifa") = TotCostoLote
                    oDtLote.Rows.Add(oDrLote)
                    ii = ii + dtSelect.Rows.Count - 1
                End If
            Next
            '=============================================================
            '===========RESUMEN COSTOS - CUENTA DE IMPUTACION GENERAL=====
            '=============================================================
            Dim TotPesoGralCI As Double = 0D
            Dim oDtCtaImputGral As New DataTable
            Dim oDrCtaImputGral As DataRow
            oDtCtaImputGral.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvCIGral As DataView = New DataView(oDtCtaImput.Copy)
            oDtvCIGral.Sort = "CCLNT, Cuenta, Tarifa DESC"
            Dim oTablaCIGral As New DataTable
            oTablaCIGral = oDtvCIGral.ToTable
            Dim CountTablaCIGral As Integer = oTablaCIGral.Rows.Count
            For iCIGral As Integer = 0 To CountTablaCIGral - 1
                dtSelect = SearchGenericoDataTable(oTablaCIGral, "Cuenta = '" + oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim + "' AND CCLNT = " + oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim)
                TotPesoGralCI = 0
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoGralCI += Convert.ToDouble(dr("Tarifa"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImputGral = oDtCtaImputGral.NewRow
                    oDrCtaImputGral.Item("CCLNT") = oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim
                    oDrCtaImputGral.Item("Cuenta") = oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim
                    oDrCtaImputGral.Item("Tarifa") = TotPesoGralCI
                    oDtCtaImputGral.Rows.Add(oDrCtaImputGral)
                    iCIGral = iCIGral + dtSelect.Rows.Count - 1 ''iCIGral = iCIGral + drSelect.Length - 1
                End If
            Next
            '================================================
            '================================================
            Dim oDtvClientes As DataView = New DataView(ObjDetalle)
            Dim oTablaClientes As New DataTable
            oTablaClientes = oDtvClientes.ToTable(True, "CCLNT", "TCMPCL")
            oTablaClientes.TableName = "DT_Clientes"
            ObjGeneralReport.TableName = "DT_General"
            oDtCtaImput.TableName = "DT_ResCntImputacion"
            objResTransp.TableName = "DT_ResCosto_Trans"
            oDtCtaImputGral.TableName = "DT_ResCntImputacionGral"
            oDtLote.TableName = "DT_ResLoteGral"

            'Se agrega el DataSet
            oDtTempCopy.Columns.Remove("FLAG_DIST")
            DsReturn.Tables.Add(oDtTempCopy) 'ObjDetalle 'CAMBIO EL DETALLE POR EL DETALLE AMPLIADO

            DsReturn.Tables.Add(oTablaClientes.Copy)
            DsReturn.Tables.Add(ObjGeneralReport)
            DsReturn.Tables.Add(oDtCtaImput)
            DsReturn.Tables.Add(objResTransp)
            DsReturn.Tables.Add(oDtCtaImputGral)
            DsReturn.Tables.Add(oDtLote)


            'Nueva columna SinCuenta para 11731

            DsReturn.Tables("DT_Detalle").Columns.Add("SIN_CUENTA").SetOrdinal(28)


            Dim grafo, orden, elementopep, centro_coste, cuenta_mayor As String



            For Each dr As DataRow In DsReturn.Tables("DT_Detalle").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()

                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next


            DsReturn.Tables("DT_General").Columns.Add("SIN_CUENTA").SetOrdinal(28)


            For Each dr As DataRow In DsReturn.Tables("DT_General").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()
                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next




            Return DsReturn
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return Nothing
            'End Try
        End Function


        Public Function Exportar_Reporte_Cargo_Plan_Aereo_ALL(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim dsReturn As New DataSet
            Dim objDataSet As New DataSet
            Dim objFiltros As New DataTable
            Dim objDato_Default As DataTable
            Dim objResumen As New DataTable
            Dim objTotales As New DataTable
            Dim objResumMedio As New DataTable
            Dim drSelect As DataRow() = Nothing
            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""
            Dim strNroCargoPlan As String = ""

            'Struct Filtros
            objFiltros.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TITULO_1", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TITULO_2", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TARIFA_MONEDA", GetType(System.Double)))
            objFiltros.Columns.Add(New DataColumn("TARIFA_MONTO", GetType(System.Double)))
            objFiltros.Columns.Add(New DataColumn("CARGO_PLAN", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("ESTADO_ENTREGA", GetType(System.String)))

            'Struct Resumenes
            objResumen.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Int64)))

            'Struct Totales
            objTotales.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("T_BULTO", GetType(System.Int64)))
            objTotales.Columns.Add(New DataColumn("T_KILO", GetType(System.Double)))
            objTotales.Columns.Add(New DataColumn("T_M3", GetType(System.Double)))
            Dim objDataRow As DataRow

            'Struct Para el Resumen Final X Medio
            objResumMedio.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("AVION", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("Nro VUELO", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("PESO KG", GetType(System.String)))

            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))
            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            '----------
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_ALL_LMZ", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_ALL_LMZ_ST", objParam)

            objDato_Default = New DataTable
            '------------------------------
            'Crea el Nuevo Formato Para los Filtros
            Dim workRow As DataRow

            For i As Integer = 0 To objDataSet.Tables(0).Rows.Count - 1
                workRow = objFiltros.NewRow()
                workRow("CCLNT") = objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString
                workRow("CTRMNC") = objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString
                workRow("NGUIRM") = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString
                workRow("TITULO_1") = "REPORTE DE VUELO : " & objDataSet.Tables(0).Rows(i).Item("TRANSPORTISTA").ToString
                workRow("TITULO_2") = "AVION : " & objDataSet.Tables(0).Rows(i).Item("TRACTO").ToString
                workRow("FECHA") = objDataSet.Tables(0).Rows(i).Item("FECHA").ToString
                workRow("ORIGEN") = objDataSet.Tables(0).Rows(i).Item("ORIGEN").ToString
                workRow("DESTINO") = objDataSet.Tables(0).Rows(i).Item("DESTINO").ToString
                workRow("MEDIO") = objDataSet.Tables(0).Rows(i).Item("TRANSPORTISTA").ToString.Trim & Chr(10) & objDataSet.Tables(0).Rows(i).Item("MODELO").ToString.Trim '& " " & objDataSet.Tables(0).Rows(i).Item("HORA").ToString.Trim & " HRS."
                workRow("OPERACION") = "NRO. OPERACION : " & objDataSet.Tables(0).Rows(i).Item("OPERACION").ToString
                workRow("TARIFA_MONEDA") = objDataSet.Tables(0).Rows(i).Item("CMNTRN").ToString
                workRow("TARIFA_MONTO") = objDataSet.Tables(0).Rows(i).Item("ITRSRT").ToString
                strNroCargoPlan = workRow("NGUIRM").ToString.PadLeft(10, "0").Substring(0, 3) & "-" & workRow("NGUIRM").ToString.PadLeft(10, "0").Substring(3)
                workRow("CARGO_PLAN") = "NRO. CARGO PLAN : " & strNroCargoPlan
                workRow("ESTADO_ENTREGA") = "ESTADO DE ENTREGA : " & objDataSet.Tables(0).Rows(i).Item("ESTADO_ENTREGA").ToString


                objFiltros.Rows.Add(workRow)
            Next

            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            Dim TotalBUL As Double = 0
            Dim POR As Double = 0D
            ''''================================================
            '''' ===== Crea Los Totales =====
            ''''================================================
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""
            Dim strCCLNT As String = ""
            Dim OriginalCount As Integer = objDataSet.Tables(1).Copy.Rows.Count
            For i As Integer = 0 To OriginalCount - 1
                'strPk0 = 
                'strPk1 = 
                'strPk2 = 
                If (strCCLNT = "" AndAlso strNGUIRM = "" AndAlso strCTRMNC = "") OrElse (objDataSet.Tables(1).Rows(i)("CTRMNC").ToString = strCTRMNC AndAlso objDataSet.Tables(1).Rows(i)("NGUIRM").ToString = strNGUIRM) Then
                    TotalKG += Convert.ToDouble(objDataSet.Tables(1).Rows(i)("KG"))
                    TotalM3 += Convert.ToDouble(objDataSet.Tables(1).Rows(i)("M3"))
                    TotalBUL += Convert.ToInt64(objDataSet.Tables(1).Rows(i)("BUL"))
                Else
                    objDataRow = objTotales.NewRow
                    objDataRow.Item("CCLNT") = strCCLNT
                    objDataRow.Item("CTRMNC") = strCTRMNC
                    objDataRow.Item("NGUIRM") = strNGUIRM
                    objDataRow.Item("T_BULTO") = TotalBUL
                    objDataRow.Item("T_KILO") = TotalKG
                    objDataRow.Item("T_M3") = TotalM3
                    objTotales.Rows.Add(objDataRow)

                    TotalKG = Convert.ToDouble(objDataSet.Tables(1).Rows(i)("KG"))
                    TotalM3 = Convert.ToDouble(objDataSet.Tables(1).Rows(i)("M3"))
                    TotalBUL = Convert.ToInt64(objDataSet.Tables(1).Rows(i)("BUL"))
                End If
                strCCLNT = objDataSet.Tables(1).Rows(i)("CCLNT").ToString
                strCTRMNC = objDataSet.Tables(1).Rows(i)("CTRMNC").ToString
                strNGUIRM = objDataSet.Tables(1).Rows(i)("NGUIRM").ToString
            Next i

            'Para El Ultimo siempre que Exista Data
            If OriginalCount > 0 Then
                objDataRow = objTotales.NewRow
                objDataRow.Item("CCLNT") = strCCLNT
                objDataRow.Item("CTRMNC") = strCTRMNC    'NCSOTR
                objDataRow.Item("NGUIRM") = strNGUIRM    'NCRRSR
                objDataRow.Item("T_BULTO") = TotalBUL
                objDataRow.Item("T_KILO") = TotalKG
                objDataRow.Item("T_M3") = TotalM3
                objTotales.Rows.Add(objDataRow)
            End If

            ''''================================================
            ''''================ Obtiene el Detalle ============
            ''''================================================
            objDato_Default = objDataSet.Tables(1).Copy
            ''''================================================

            '''' Hacemos los cambios en la tabla de Detalle antes de insertaRLE DATA
            objDato_Default.Columns.Add("POR_CI", GetType(System.Double))
            objDato_Default.Columns.Add("FLAG_DIST", GetType(System.String))

            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = objDato_Default.Clone
            For Each dr As DataRow In objDato_Default.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM
                Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM & " AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" '"" & dr("OC").ToString.Trim
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCSA")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next
            ''''================================================
            ''''===========Struct Reporte General===============
            ''''================================================
            'objDato_Default.Columns.Remove("ITEM")
            'objDato_Default.Columns.Remove("GUIA_PROV")
            'objDato_Default.Columns.Remove("PROVEEDOR")
            'objDato_Default.Columns.Remove("DESCRIPCION")
            'objDato_Default.Columns.Remove("F_DE_INGRESO")
            'objDato_Default.Columns.Remove("GUIA_PLUS")
            'objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            ''''================================================
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Remove("FLAG_DIST")
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA_CI", GetType(System.Double))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA", GetType(System.Double))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns.Add(New DataColumn("ESTADO_ENTREGA", GetType(System.String))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns("ESTADO_ENTREGA").SetOrdinal(5)



            'Llena las Cabeceras en el Detalle del Rep. General
            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                'busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objFiltros, strPk0, strPk1, strPk2)

                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = RowFiltro.Item("ORIGEN")
                    RowTemp.Item("DESTINO") = RowFiltro.Item("DESTINO")
                    RowTemp.Item("MEDIO") = RowFiltro.Item("MEDIO")
                    RowTemp.Item("OPERACION") = Split(RowFiltro.Item("OPERACION"), ":")(1)
                    RowTemp.Item("ESTADO_ENTREGA") = Split(RowFiltro.Item("ESTADO_ENTREGA"), ":")(1)
                    '========Agregamos las tarifas==========
                    Dim PesoTotal As Double = SearchDataTable(objTotales, strPk0, strPk1, strPk2).Rows(0).Item("T_KILO")
                    If PesoTotal = 0 Then
                        POR = 0
                    Else
                        POR = (RowTemp.Item("KG") / PesoTotal)
                    End If
                    If IsDBNull(RowTemp.Item("POR_CI")) Then
                        RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("TARIFA_MONTO") * POR, 2)
                    Else
                        RowTemp.Item("TARIFA_CI") = Math.Round(RowFiltro.Item("TARIFA_MONTO") * POR * RowTemp.Item("POR_CI") * 0.01, 2)
                    End If
                    RowTemp.AcceptChanges()
                Next
            Next

            '---------------------------------------------------
            OriginalCount = objDato_Default.Rows.Count
            ''''================================================
            '''' ==== Crea Los resumenes POR LOTES ====
            ''''================================================
            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("LOTE = '" & objDato_Default.Rows(i)("LOTE").ToString.Trim & "' and CCLNT = " + objDato_Default.Rows(i)("CCLNT").ToString & "   and LOTE <> ''  and CTRMNC = " & objDato_Default.Rows(i)("CTRMNC").ToString & "  and NGUIRM = " & objDato_Default.Rows(i)("NGUIRM").ToString + "")
                TotalKG = 0
                TotalM3 = 0
                TotalBUL = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                    TotalBUL += Convert.ToInt64(dr("BUL"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = objResumen.NewRow
                    objDataRow.Item("CCLNT") = objDato_Default.Rows(i)("CCLNT").ToString
                    objDataRow.Item("CTRMNC") = objDato_Default.Rows(i)("CTRMNC").ToString
                    objDataRow.Item("NGUIRM") = objDato_Default.Rows(i)("NGUIRM").ToString
                    objDataRow.Item("LOTE") = objDato_Default.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("KG") = TotalKG
                    objDataRow.Item("M3") = TotalM3
                    objDataRow.Item("BUL") = TotalBUL
                    objResumen.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i

            '=======================================================
            '==RESUMEN COSTOS - CUENTA DE IMPUTACION X CARGO PLAN===
            '=======================================================
            Dim oDtCtaImput As New DataTable
            Dim oDrCtaImput As DataRow
            Dim TotPor As Double = 0D
            oDtCtaImput.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImput.Columns.Add("CTRMNC", GetType(System.String))
            oDtCtaImput.Columns.Add("NGUIRM", GetType(System.String))
            oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImput.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtv As DataView = New DataView(oDtTempCopy.Copy) 'DataView(ObjDetalle.Copy)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM, CUENTA_IMPUTACION DESC" 'Mandatorio para la busqueda es la CUENTA_IMPUTACION
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            OriginalCount = oTabla.Rows.Count
            For ii As Integer = 0 To OriginalCount - 1
                strPk0 = oTabla.Rows(ii)("CCLNT").ToString.Trim
                strPk1 = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                strPk2 = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim + "' AND CCLNT = " + strPk0 + " AND CTRMNC = " + _
                                                    strPk1 + " AND NGUIRM =" + strPk2 + " AND  FLAG_DIST <> 'CI_SG' ") 'AND CUENTA_IMPUTACION <> 'SEGUN DISTRIBUCION' 
                'oTabla.Rows(ii)("CCLNT").ToString.Trim
                'oTabla.Rows(ii)("CTRMNC").ToString.Trim
                'oTabla.Rows(ii)("NGUIRM").ToString.Trim
                Dim PesoTotal As Double = SearchDataTable(objTotales, strPk0, strPk1, strPk2).Rows(0).Item("T_KILO")
                TotPor = 0
                For Each dr As DataRow In drSelect
                    If PesoTotal = 0 Then
                        POR = 0
                    Else
                        POR = (dr.Item("KG") / PesoTotal)
                    End If
                    If IsDBNull(dr("POR_CI")) Then
                        TotPor += POR
                    Else
                        TotPor += POR * Convert.ToDouble(dr("POR_CI")) * 0.01
                    End If
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImput = oDtCtaImput.NewRow
                    oDrCtaImput.Item("CCLNT") = oTabla.Rows(ii)("CCLNT").ToString.Trim
                    oDrCtaImput.Item("CTRMNC") = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                    oDrCtaImput.Item("NGUIRM") = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                    oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim)
                    Dim tmpTrfMonto As Double = SearchDataTable(objFiltros, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TARIFA_MONTO")
                    Dim tmpPsoVol As Double = SearchDataTable(objTotales, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("T_M3")
                    where = "CCLNT = " + oDrCtaImput.Item("CCLNT") + " AND CTRMNC = " + oDrCtaImput.Item("CTRMNC") + " AND NGUIRM =" + oDrCtaImput.Item("NGUIRM")
                    Dim tmpTarifa As Double = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("ITRSRT")
                    oDrCtaImput.Item("Tarifa") = TotPor * tmpTarifa '* 0.01 '      Math.Round(IIf(tmpPsoVol = 0, 0, TotPor * tmpTrfMonto / tmpPsoVol), 2)
                    oDtCtaImput.Rows.Add(oDrCtaImput)
                    ii = ii + drSelect.Length - 1
                End If
            Next

            '================================================
            '============RESUMEN COSTOS-LOTES===============
            '================================================
            Dim oDtLote As New DataTable
            Dim oDrLote As DataRow
            Dim dtSelect As New DataTable
            Dim TotPesoLote As Double = 0D
            Dim TotM3Lote As Double = 0D
            Dim TotCostoLote As Double = 0D
            oDtLote.Columns.Add("CCLNT", GetType(System.String))
            oDtLote.Columns.Add("Lote", GetType(System.String))
            oDtLote.Columns.Add("Tns.", GetType(System.String))
            oDtLote.Columns.Add("M3", GetType(System.String))
            oDtLote.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvLote As DataView = New DataView(ObjGeneralReport.Copy)
            oDtvLote.Sort = "CCLNT, LOTE, TARIFA DESC"
            oDtvLote.RowFilter = " POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaLote As New DataTable
            oTablaLote = oDtvLote.ToTable
            Dim OriginalCountLote As Integer = oTablaLote.Rows.Count
            For ii As Integer = 0 To OriginalCountLote - 1
                dtSelect = SearchGenericoDataTable(oTablaLote, "LOTE = '" + oTablaLote.Rows(ii)("LOTE").ToString.Trim + "' AND CCLNT = " + oTablaLote.Rows(ii)("CCLNT").ToString.Trim)
                TotPesoLote = 0D
                TotM3Lote = 0D
                TotCostoLote = 0D
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoLote += Convert.ToDouble(dr("KG"))
                    TotM3Lote += Convert.ToDouble(dr("M3"))
                    TotCostoLote += Convert.ToDouble(dr("TARIFA"))
                Next
                If dtSelect.Rows.Count > 0 Then
                    oDrLote = oDtLote.NewRow
                    oDrLote.Item("CCLNT") = oTablaLote.Rows(ii)("CCLNT").ToString.Trim
                    oDrLote.Item("Lote") = IIf(oTablaLote.Rows(ii)("LOTE").ToString.Trim = "", "SIN LOTE", oTablaLote.Rows(ii)("LOTE").ToString.Trim)
                    oDrLote.Item("Tns.") = TotPesoLote / 1000 'Convertimos Kilos a Toneladas
                    oDrLote.Item("M3") = TotM3Lote
                    oDrLote.Item("Tarifa") = TotCostoLote
                    oDtLote.Rows.Add(oDrLote)
                    ii = ii + dtSelect.Rows.Count - 1
                End If
            Next

            '=============================================================
            '===========RESUMEN COSTOS - CUENTA DE IMPUTACION GENERAL=====
            '=============================================================
            Dim TotPesoGralCI As Double = 0D
            Dim oDtCtaImputGral As New DataTable
            Dim oDrCtaImputGral As DataRow
            oDtCtaImputGral.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvCIGral As DataView = New DataView(oDtCtaImput.Copy)
            oDtvCIGral.Sort = "CCLNT, Cuenta, Tarifa DESC"
            Dim oTablaCIGral As New DataTable
            oTablaCIGral = oDtvCIGral.ToTable
            Dim CountTablaCIGral As Integer = oTablaCIGral.Rows.Count
            For iCIGral As Integer = 0 To CountTablaCIGral - 1
                dtSelect = SearchGenericoDataTable(oTablaCIGral, "Cuenta = '" + oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim + "' AND CCLNT = " + oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim)
                TotPesoGralCI = 0
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoGralCI += Convert.ToDouble(dr("Tarifa"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImputGral = oDtCtaImputGral.NewRow
                    oDrCtaImputGral.Item("CCLNT") = oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim
                    oDrCtaImputGral.Item("Cuenta") = oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim
                    oDrCtaImputGral.Item("Tarifa") = TotPesoGralCI
                    oDtCtaImputGral.Rows.Add(oDrCtaImputGral)
                    iCIGral = iCIGral + dtSelect.Rows.Count - 1 ''iCIGral = iCIGral + drSelect.Length - 1
                End If
            Next
            '================================================

            ''''================================================
            ''''=======Crea Los resumenes para los Medios=======
            ''''================================================
            Dim ResumenTemp As DataTable = objTotales.Copy
            ResumenTemp.Columns.Add("MEDIO", GetType(System.String))
            Dim dtTempFiltro As DataTable = objDataSet.Tables(0)

            For Each row As Data.DataRow In ResumenTemp.Rows()
                drSelect = dtTempFiltro.Select("CCLNT = " + row.Item("CCLNT").ToString + " and CTRMNC = " + row.Item("CTRMNC").ToString + "  and NGUIRM = " + row.Item("NGUIRM").ToString + "")
                row.Item("MEDIO") = drSelect(0).Item("TRANSPORTISTA").ToString.Trim & " " & drSelect(0).Item("MODELO").ToString.Trim
                ResumenTemp.AcceptChanges()
            Next

            'Ordena por Cliente Y Medio
            Dim dvR As New DataView(ResumenTemp)
            dvR.Sort = "CCLNT,MEDIO"
            ResumenTemp = dvR.ToTable()
            ''''================================================
            ''''====== Crea El Resumen Por Cliente Y Medio =====
            ''''================================================
            For i As Integer = 0 To ResumenTemp.Rows.Count - 1
                drSelect = ResumenTemp.Select("MEDIO = '" + ResumenTemp.Rows(i)("MEDIO").ToString.Trim + "'   and MEDIO <> '' " + " and CCLNT = " + ResumenTemp.Rows(i)("CCLNT").ToString + "")
                objDataRow = objResumMedio.NewRow
                objDataRow.Item("CCLNT") = drSelect(0).Item("CCLNT")
                objDataRow.Item("AVION") = drSelect(0).Item("MEDIO")
                objDataRow.Item("Nro VUELO") = drSelect.Length
                TotalKG = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr.Item("T_KILO"))
                Next
                objDataRow.Item("PESO KG") = TotalKG.ToString
                objResumMedio.Rows.Add(objDataRow)
            Next i

            oDtTempCopy.Columns.Remove("FLAG_DIST")
            objFiltros.TableName = "DT_Filtros"
            oDtTempCopy.TableName = "DT_Detalle"
            objResumen.TableName = "DT_Resumen"
            objTotales.TableName = "DT_Totales"

            oDtCtaImput.TableName = "DT_CtaImput"
            oDtLote.TableName = "DT_LoteResumen"
            oDtCtaImputGral.TableName = "DT_CtaImputGral"

            dsReturn.Tables.Add(objFiltros)
            dsReturn.Tables.Add(oDtTempCopy) ' TABLA DETALLE AMPLIADA
            dsReturn.Tables.Add(objResumen)
            dsReturn.Tables.Add(objTotales)

            dsReturn.Tables.Add(oDtCtaImput)
            dsReturn.Tables.Add(oDtLote)
            dsReturn.Tables.Add(oDtCtaImputGral)

            'Añade el Table de Clientes Distinct
            Dim oDtvTemp As DataView = New DataView(objDato_Default)
            Dim oTdtTemp As New DataTable
            oTdtTemp = oDtvTemp.ToTable(True, "CCLNT", "TCMPCL")
            oTdtTemp.TableName = "DT_Clientes"
            dsReturn.Tables.Add(oTdtTemp.Copy)

            oDtvTemp = New DataView(objResumMedio)
            'Añade el Resum Medio Distintc
            oTdtTemp = oDtvTemp.ToTable(True, "CCLNT", "AVION", "Nro VUELO", "PESO KG")
            oTdtTemp.TableName = "Dt_ResumenAvion"
            dsReturn.Tables.Add(oTdtTemp.Copy)

            ObjGeneralReport.TableName = "DT_General"
            dsReturn.Tables.Add(ObjGeneralReport)
            Return dsReturn
        End Function

        'Private Function DatosAdicionalesGuia(ByVal NGUIRM As String, ByVal CCLNT As String) As ENTIDADES.DatosAdiionalGuiaRemision
        '    Dim objDalDatosGuia As New GuiaRemision_DAL
        '    objDalDatosGuia.ObtieneDatosAdicionalesGuia(NGUIRM, CCLNT)
        'End Function


        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Aereo_ALL_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            Dim dsReturn As New DataSet
            Dim objDataSet As New DataSet
            Dim objFiltros As New DataTable
            Dim objDato_Default As DataTable
            Dim objResumen As New DataTable
            Dim objTotales As New DataTable
            Dim objResumMedio As New DataTable
            Dim drSelect As DataRow() = Nothing
            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""
            Dim strNroCargoPlan As String = ""

            'Struct Filtros
            objFiltros.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TITULO_1", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TITULO_2", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("TARIFA_MONEDA", GetType(System.Double)))
            objFiltros.Columns.Add(New DataColumn("TARIFA_MONTO", GetType(System.Double)))
            objFiltros.Columns.Add(New DataColumn("CARGO_PLAN", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("ESTADO_ENTREGA", GetType(System.String)))
            objFiltros.Columns.Add(New DataColumn("RUTA", GetType(System.String)))


            'Struct Resumenes
            objResumen.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("LOTE", GetType(System.String)))
            objResumen.Columns.Add(New DataColumn("KG", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("M3", GetType(System.Double)))
            objResumen.Columns.Add(New DataColumn("BUL", GetType(System.Int64)))

            'Struct Totales
            objTotales.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("CTRMNC", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("NGUIRM", GetType(System.String)))
            objTotales.Columns.Add(New DataColumn("T_BULTO", GetType(System.Int64)))
            objTotales.Columns.Add(New DataColumn("T_KILO", GetType(System.Double)))
            objTotales.Columns.Add(New DataColumn("T_M3", GetType(System.Double)))
            Dim objDataRow As DataRow

            'Struct Para el Resumen Final X Medio
            objResumMedio.Columns.Add(New DataColumn("CCLNT", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("AVION", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("Nro VUELO", GetType(System.String)))
            objResumMedio.Columns.Add(New DataColumn("PESO KG", GetType(System.String)))

            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))
            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            '----------
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_ALL_LMZ", objParam)

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_AEREO_ALL_LMZ_ST_PPC", objParam)


            objDato_Default = New DataTable
            '------------------------------
            'Crea el Nuevo Formato Para los Filtros
            Dim workRow As DataRow

            Dim tipo_guia As String = ""
            Dim GuiaT As String = ""
            For i As Integer = 0 To objDataSet.Tables(0).Rows.Count - 1
                workRow = objFiltros.NewRow()



                workRow("CCLNT") = objDataSet.Tables(0).Rows(i).Item("CCLNT").ToString
                workRow("CTRMNC") = objDataSet.Tables(0).Rows(i).Item("CTRMNC").ToString
                workRow("NGUIRM") = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString
                workRow("TITULO_1") = "REPORTE DE VUELO : " & objDataSet.Tables(0).Rows(i).Item("TRANSPORTISTA").ToString
                workRow("TITULO_2") = "AVION : " & objDataSet.Tables(0).Rows(i).Item("TRACTO").ToString
                workRow("FECHA") = objDataSet.Tables(0).Rows(i).Item("FECHA").ToString
                workRow("ORIGEN") = objDataSet.Tables(0).Rows(i).Item("ORIGEN").ToString
                workRow("DESTINO") = objDataSet.Tables(0).Rows(i).Item("DESTINO").ToString
                workRow("MEDIO") = objDataSet.Tables(0).Rows(i).Item("TRANSPORTISTA").ToString.Trim & Chr(10) & objDataSet.Tables(0).Rows(i).Item("MODELO").ToString.Trim '& " " & objDataSet.Tables(0).Rows(i).Item("HORA").ToString.Trim & " HRS."
                workRow("OPERACION") = "NRO. OPERACION : " & objDataSet.Tables(0).Rows(i).Item("OPERACION").ToString
                workRow("TARIFA_MONEDA") = objDataSet.Tables(0).Rows(i).Item("CMNTRN").ToString
                workRow("TARIFA_MONTO") = objDataSet.Tables(0).Rows(i).Item("ITRSRT").ToString

                tipo_guia = objDataSet.Tables(0).Rows(i).Item("CTDGRT").ToString
                GuiaT = objDataSet.Tables(0).Rows(i).Item("NGUIRM").ToString
                Select Case tipo_guia
                    Case "F"
                        GuiaT = GuiaT.Substring(0, 3) & "-" & GuiaT.Substring(3)
                    Case "E"
                        GuiaT = GuiaT.Substring(0, 4) & "-" & GuiaT.Substring(4)
                End Select

                'strNroCargoPlan = workRow("NGUIRM").ToString.PadLeft(10, "0").Substring(0, 3) & "-" & workRow("NGUIRM").ToString.PadLeft(10, "0").Substring(3)
                strNroCargoPlan = GuiaT

                workRow("CARGO_PLAN") = "NRO. CARGO PLAN : " & strNroCargoPlan
                workRow("ESTADO_ENTREGA") = "ESTADO DE ENTREGA : " & objDataSet.Tables(0).Rows(i).Item("ESTADO_ENTREGA").ToString

                workRow("RUTA") = objDataSet.Tables(0).Rows(i).Item("RUTA").ToString

                objFiltros.Rows.Add(workRow)
            Next

            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            Dim TotalBUL As Double = 0
            Dim POR As Double = 0D
            ''''================================================
            '''' ===== Crea Los Totales =====
            ''''================================================
            TotalKG = 0
            TotalM3 = 0
            TotalBUL = 0
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""
            Dim strCCLNT As String = ""
            Dim OriginalCount As Integer = objDataSet.Tables(1).Copy.Rows.Count
            For i As Integer = 0 To OriginalCount - 1
                'strPk0 = 
                'strPk1 = 
                'strPk2 = 
                If (strCCLNT = "" AndAlso strNGUIRM = "" AndAlso strCTRMNC = "") OrElse (objDataSet.Tables(1).Rows(i)("CTRMNC").ToString = strCTRMNC AndAlso objDataSet.Tables(1).Rows(i)("NGUIRM").ToString = strNGUIRM) Then
                    TotalKG += Convert.ToDouble(objDataSet.Tables(1).Rows(i)("KG"))
                    TotalM3 += Convert.ToDouble(objDataSet.Tables(1).Rows(i)("M3"))
                    TotalBUL += Convert.ToInt64(objDataSet.Tables(1).Rows(i)("BUL"))
                Else
                    objDataRow = objTotales.NewRow
                    objDataRow.Item("CCLNT") = strCCLNT
                    objDataRow.Item("CTRMNC") = strCTRMNC
                    objDataRow.Item("NGUIRM") = strNGUIRM
                    objDataRow.Item("T_BULTO") = TotalBUL
                    objDataRow.Item("T_KILO") = TotalKG
                    objDataRow.Item("T_M3") = TotalM3
                    objTotales.Rows.Add(objDataRow)

                    TotalKG = Convert.ToDouble(objDataSet.Tables(1).Rows(i)("KG"))
                    TotalM3 = Convert.ToDouble(objDataSet.Tables(1).Rows(i)("M3"))
                    TotalBUL = Convert.ToInt64(objDataSet.Tables(1).Rows(i)("BUL"))
                End If
                strCCLNT = objDataSet.Tables(1).Rows(i)("CCLNT").ToString
                strCTRMNC = objDataSet.Tables(1).Rows(i)("CTRMNC").ToString
                strNGUIRM = objDataSet.Tables(1).Rows(i)("NGUIRM").ToString
            Next i

            'Para El Ultimo siempre que Exista Data
            If OriginalCount > 0 Then
                objDataRow = objTotales.NewRow
                objDataRow.Item("CCLNT") = strCCLNT
                objDataRow.Item("CTRMNC") = strCTRMNC    'NCSOTR
                objDataRow.Item("NGUIRM") = strNGUIRM    'NCRRSR
                objDataRow.Item("T_BULTO") = TotalBUL
                objDataRow.Item("T_KILO") = TotalKG
                objDataRow.Item("T_M3") = TotalM3
                objTotales.Rows.Add(objDataRow)
            End If

            ''''================================================
            ''''================ Obtiene el Detalle ============
            ''''================================================
            objDato_Default = objDataSet.Tables(1).Copy
            ''''================================================

            '''' Hacemos los cambios en la tabla de Detalle antes de insertaRLE DATA
            objDato_Default.Columns.Add("POR_CI", GetType(System.Double))
            objDato_Default.Columns.Add("FLAG_DIST", GetType(System.String))

            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = objDato_Default.Clone
            For Each dr As DataRow In objDato_Default.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM ='" + strNGUIRM + "'"
                Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM ='" + strNGUIRM & "' AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG" '"" & dr("OC").ToString.Trim
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCSA")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next
            ''''================================================
            ''''===========Struct Reporte General===============
            ''''================================================
            'objDato_Default.Columns.Remove("ITEM")
            'objDato_Default.Columns.Remove("GUIA_PROV")
            'objDato_Default.Columns.Remove("PROVEEDOR")
            'objDato_Default.Columns.Remove("DESCRIPCION")
            'objDato_Default.Columns.Remove("F_DE_INGRESO")
            'objDato_Default.Columns.Remove("GUIA_PLUS")
            'objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            ''''================================================
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Remove("FLAG_DIST")
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            ObjGeneralReport.Columns.Add(New DataColumn("RUTA", GetType(System.String)))
            ObjGeneralReport.Columns("RUTA").SetOrdinal(5)
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA_CI", GetType(System.Double))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns.Add(New DataColumn("TARIFA", GetType(System.Double))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns.Add(New DataColumn("ESTADO_ENTREGA", GetType(System.String))) 'NO TIENE ORDINAL PUES IRA AL FINAL
            ObjGeneralReport.Columns("ESTADO_ENTREGA").SetOrdinal(5)



            'Llena las Cabeceras en el Detalle del Rep. General
            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                'busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objFiltros, strPk0, strPk1, strPk2)

                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = RowFiltro.Item("ORIGEN")
                    RowTemp.Item("DESTINO") = RowFiltro.Item("DESTINO")
                    RowTemp.Item("MEDIO") = RowFiltro.Item("MEDIO")
                    RowTemp.Item("OPERACION") = Split(RowFiltro.Item("OPERACION"), ":")(1)
                    RowTemp.Item("RUTA") = RowFiltro.Item("RUTA")
                    RowTemp.Item("ESTADO_ENTREGA") = Split(RowFiltro.Item("ESTADO_ENTREGA"), ":")(1)
                    '========Agregamos las tarifas==========
                    Dim PesoTotal As Double = SearchDataTable(objTotales, strPk0, strPk1, strPk2).Rows(0).Item("T_KILO")
                    If PesoTotal = 0 Then
                        POR = 0
                    Else
                        POR = (RowTemp.Item("KG") / PesoTotal)
                    End If
                    If IsDBNull(RowTemp.Item("POR_CI")) Then
                        RowTemp.Item("TARIFA") = Math.Round(RowFiltro.Item("TARIFA_MONTO") * POR, 2)
                    Else
                        RowTemp.Item("TARIFA_CI") = Math.Round(RowFiltro.Item("TARIFA_MONTO") * POR * RowTemp.Item("POR_CI") * 0.01, 2)
                    End If
                    RowTemp.AcceptChanges()
                Next
            Next

            '---------------------------------------------------
            OriginalCount = objDato_Default.Rows.Count
            ''''================================================
            '''' ==== Crea Los resumenes POR LOTES ====
            ''''================================================
            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("LOTE = '" & objDato_Default.Rows(i)("LOTE").ToString.Trim & "' and CCLNT = " + objDato_Default.Rows(i)("CCLNT").ToString & "   and LOTE <> ''  and CTRMNC = " & objDato_Default.Rows(i)("CTRMNC").ToString & "  and NGUIRM = " & objDato_Default.Rows(i)("NGUIRM").ToString + "")
                TotalKG = 0
                TotalM3 = 0
                TotalBUL = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                    TotalBUL += Convert.ToInt64(dr("BUL"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = objResumen.NewRow
                    objDataRow.Item("CCLNT") = objDato_Default.Rows(i)("CCLNT").ToString
                    objDataRow.Item("CTRMNC") = objDato_Default.Rows(i)("CTRMNC").ToString
                    objDataRow.Item("NGUIRM") = objDato_Default.Rows(i)("NGUIRM").ToString
                    objDataRow.Item("LOTE") = objDato_Default.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("KG") = TotalKG
                    objDataRow.Item("M3") = TotalM3
                    objDataRow.Item("BUL") = TotalBUL
                    objResumen.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i

            '=======================================================
            '==RESUMEN COSTOS - CUENTA DE IMPUTACION X CARGO PLAN===
            '=======================================================
            Dim oDtCtaImput As New DataTable
            Dim oDrCtaImput As DataRow
            Dim TotPor As Double = 0D
            oDtCtaImput.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImput.Columns.Add("CTRMNC", GetType(System.String))
            oDtCtaImput.Columns.Add("NGUIRM", GetType(System.String))
            oDtCtaImput.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImput.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtv As DataView = New DataView(oDtTempCopy.Copy) 'DataView(ObjDetalle.Copy)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM, CUENTA_IMPUTACION DESC" 'Mandatorio para la busqueda es la CUENTA_IMPUTACION
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            OriginalCount = oTabla.Rows.Count
            For ii As Integer = 0 To OriginalCount - 1
                strPk0 = oTabla.Rows(ii)("CCLNT").ToString.Trim
                strPk1 = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                strPk2 = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                drSelect = oDtTempCopy.Copy.Select("CUENTA_IMPUTACION = '" + oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim + "' AND CCLNT = " + strPk0 + " AND CTRMNC = " + _
                                                    strPk1 + " AND NGUIRM ='" + strPk2 + "' AND  FLAG_DIST <> 'CI_SG' ") 'AND CUENTA_IMPUTACION <> 'SEGUN DISTRIBUCION' 
                'oTabla.Rows(ii)("CCLNT").ToString.Trim
                'oTabla.Rows(ii)("CTRMNC").ToString.Trim
                'oTabla.Rows(ii)("NGUIRM").ToString.Trim
                Dim PesoTotal As Double = SearchDataTable(objTotales, strPk0, strPk1, strPk2).Rows(0).Item("T_KILO")
                TotPor = 0
                For Each dr As DataRow In drSelect
                    If PesoTotal = 0 Then
                        POR = 0
                    Else
                        POR = (dr.Item("KG") / PesoTotal)
                    End If
                    If IsDBNull(dr("POR_CI")) Then
                        TotPor += POR
                    Else
                        TotPor += POR * Convert.ToDouble(dr("POR_CI")) * 0.01
                    End If
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImput = oDtCtaImput.NewRow
                    oDrCtaImput.Item("CCLNT") = oTabla.Rows(ii)("CCLNT").ToString.Trim
                    oDrCtaImput.Item("CTRMNC") = oTabla.Rows(ii)("CTRMNC").ToString.Trim
                    oDrCtaImput.Item("NGUIRM") = oTabla.Rows(ii)("NGUIRM").ToString.Trim
                    oDrCtaImput.Item("Cuenta") = IIf(oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim = "", "SIN CUENTA IMPUTACION", oTabla.Rows(ii)("CUENTA_IMPUTACION").ToString.Trim)
                    Dim tmpTrfMonto As Double = SearchDataTable(objFiltros, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("TARIFA_MONTO")
                    Dim tmpPsoVol As Double = SearchDataTable(objTotales, oTabla.Rows(ii)("CCLNT").ToString.Trim, oTabla.Rows(ii)("CTRMNC").ToString.Trim, oTabla.Rows(ii)("NGUIRM").ToString.Trim).Rows(0).Item("T_M3")
                    where = "CCLNT = " + oDrCtaImput.Item("CCLNT") + " AND CTRMNC = " + oDrCtaImput.Item("CTRMNC") + " AND NGUIRM ='" + oDrCtaImput.Item("NGUIRM") + "'"
                    Dim tmpTarifa As Double = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("ITRSRT")
                    oDrCtaImput.Item("Tarifa") = TotPor * tmpTarifa '* 0.01 '      Math.Round(IIf(tmpPsoVol = 0, 0, TotPor * tmpTrfMonto / tmpPsoVol), 2)
                    oDtCtaImput.Rows.Add(oDrCtaImput)
                    ii = ii + drSelect.Length - 1
                End If
            Next

            '================================================
            '============RESUMEN COSTOS-LOTES===============
            '================================================
            Dim oDtLote As New DataTable
            Dim oDrLote As DataRow
            Dim dtSelect As New DataTable
            Dim TotPesoLote As Double = 0D
            Dim TotM3Lote As Double = 0D
            Dim TotCostoLote As Double = 0D
            oDtLote.Columns.Add("CCLNT", GetType(System.String))
            oDtLote.Columns.Add("Lote", GetType(System.String))
            oDtLote.Columns.Add("Tns.", GetType(System.String))
            oDtLote.Columns.Add("M3", GetType(System.String))
            oDtLote.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvLote As DataView = New DataView(ObjGeneralReport.Copy)
            oDtvLote.Sort = "CCLNT, LOTE, TARIFA DESC"
            oDtvLote.RowFilter = " POR_CI = 0 OR POR_CI IS NULL"
            Dim oTablaLote As New DataTable
            oTablaLote = oDtvLote.ToTable
            Dim OriginalCountLote As Integer = oTablaLote.Rows.Count
            For ii As Integer = 0 To OriginalCountLote - 1
                dtSelect = SearchGenericoDataTable(oTablaLote, "LOTE = '" + oTablaLote.Rows(ii)("LOTE").ToString.Trim + "' AND CCLNT = " + oTablaLote.Rows(ii)("CCLNT").ToString.Trim)
                TotPesoLote = 0D
                TotM3Lote = 0D
                TotCostoLote = 0D
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoLote += Convert.ToDouble(dr("KG"))
                    TotM3Lote += Convert.ToDouble(dr("M3"))
                    TotCostoLote += Convert.ToDouble(dr("TARIFA"))
                Next
                If dtSelect.Rows.Count > 0 Then
                    oDrLote = oDtLote.NewRow
                    oDrLote.Item("CCLNT") = oTablaLote.Rows(ii)("CCLNT").ToString.Trim
                    oDrLote.Item("Lote") = IIf(oTablaLote.Rows(ii)("LOTE").ToString.Trim = "", "SIN LOTE", oTablaLote.Rows(ii)("LOTE").ToString.Trim)
                    oDrLote.Item("Tns.") = TotPesoLote / 1000 'Convertimos Kilos a Toneladas
                    oDrLote.Item("M3") = TotM3Lote
                    oDrLote.Item("Tarifa") = TotCostoLote
                    oDtLote.Rows.Add(oDrLote)
                    ii = ii + dtSelect.Rows.Count - 1
                End If
            Next

            '=============================================================
            '===========RESUMEN COSTOS - CUENTA DE IMPUTACION GENERAL=====
            '=============================================================
            Dim TotPesoGralCI As Double = 0D
            Dim oDtCtaImputGral As New DataTable
            Dim oDrCtaImputGral As DataRow
            oDtCtaImputGral.Columns.Add("CCLNT", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Cuenta", GetType(System.String))
            oDtCtaImputGral.Columns.Add("Tarifa", GetType(System.Double))
            Dim oDtvCIGral As DataView = New DataView(oDtCtaImput.Copy)
            oDtvCIGral.Sort = "CCLNT, Cuenta, Tarifa DESC"
            Dim oTablaCIGral As New DataTable
            oTablaCIGral = oDtvCIGral.ToTable
            Dim CountTablaCIGral As Integer = oTablaCIGral.Rows.Count
            For iCIGral As Integer = 0 To CountTablaCIGral - 1
                dtSelect = SearchGenericoDataTable(oTablaCIGral, "Cuenta = '" + oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim + "' AND CCLNT = " + oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim)
                TotPesoGralCI = 0
                For Each dr As DataRow In dtSelect.Rows
                    TotPesoGralCI += Convert.ToDouble(dr("Tarifa"))
                Next
                If drSelect.Length > 0 Then
                    oDrCtaImputGral = oDtCtaImputGral.NewRow
                    oDrCtaImputGral.Item("CCLNT") = oTablaCIGral.Rows(iCIGral)("CCLNT").ToString.Trim
                    oDrCtaImputGral.Item("Cuenta") = oTablaCIGral.Rows(iCIGral)("Cuenta").ToString.Trim
                    oDrCtaImputGral.Item("Tarifa") = TotPesoGralCI
                    oDtCtaImputGral.Rows.Add(oDrCtaImputGral)
                    iCIGral = iCIGral + dtSelect.Rows.Count - 1 ''iCIGral = iCIGral + drSelect.Length - 1
                End If
            Next
            '================================================

            ''''================================================
            ''''=======Crea Los resumenes para los Medios=======
            ''''================================================
            Dim ResumenTemp As DataTable = objTotales.Copy
            ResumenTemp.Columns.Add("MEDIO", GetType(System.String))
            Dim dtTempFiltro As DataTable = objDataSet.Tables(0)

            For Each row As Data.DataRow In ResumenTemp.Rows()
                drSelect = dtTempFiltro.Select("CCLNT = " + row.Item("CCLNT").ToString + " and CTRMNC = " + row.Item("CTRMNC").ToString + "  and NGUIRM = '" + row.Item("NGUIRM").ToString + "'")
                row.Item("MEDIO") = drSelect(0).Item("TRANSPORTISTA").ToString.Trim & " " & drSelect(0).Item("MODELO").ToString.Trim
                ResumenTemp.AcceptChanges()
            Next

            'Ordena por Cliente Y Medio
            Dim dvR As New DataView(ResumenTemp)
            dvR.Sort = "CCLNT,MEDIO"
            ResumenTemp = dvR.ToTable()
            ''''================================================
            ''''====== Crea El Resumen Por Cliente Y Medio =====
            ''''================================================
            For i As Integer = 0 To ResumenTemp.Rows.Count - 1
                drSelect = ResumenTemp.Select("MEDIO = '" + ResumenTemp.Rows(i)("MEDIO").ToString.Trim + "'   and MEDIO <> '' " + " and CCLNT = " + ResumenTemp.Rows(i)("CCLNT").ToString + "")
                objDataRow = objResumMedio.NewRow
                objDataRow.Item("CCLNT") = drSelect(0).Item("CCLNT")
                objDataRow.Item("AVION") = drSelect(0).Item("MEDIO")
                objDataRow.Item("Nro VUELO") = drSelect.Length
                TotalKG = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr.Item("T_KILO"))
                Next
                objDataRow.Item("PESO KG") = TotalKG.ToString
                objResumMedio.Rows.Add(objDataRow)
            Next i

            oDtTempCopy.Columns.Remove("FLAG_DIST")
            objFiltros.TableName = "DT_Filtros"
            oDtTempCopy.TableName = "DT_Detalle"
            objResumen.TableName = "DT_Resumen"
            objTotales.TableName = "DT_Totales"

            oDtCtaImput.TableName = "DT_CtaImput"
            oDtLote.TableName = "DT_LoteResumen"
            oDtCtaImputGral.TableName = "DT_CtaImputGral"

            dsReturn.Tables.Add(objFiltros)
            dsReturn.Tables.Add(oDtTempCopy) ' TABLA DETALLE AMPLIADA
            dsReturn.Tables.Add(objResumen)
            dsReturn.Tables.Add(objTotales)

            dsReturn.Tables.Add(oDtCtaImput)
            dsReturn.Tables.Add(oDtLote)
            dsReturn.Tables.Add(oDtCtaImputGral)

            'Añade el Table de Clientes Distinct
            Dim oDtvTemp As DataView = New DataView(objDato_Default)
            Dim oTdtTemp As New DataTable
            oTdtTemp = oDtvTemp.ToTable(True, "CCLNT", "TCMPCL")
            oTdtTemp.TableName = "DT_Clientes"
            dsReturn.Tables.Add(oTdtTemp.Copy)

            oDtvTemp = New DataView(objResumMedio)
            'Añade el Resum Medio Distintc
            oTdtTemp = oDtvTemp.ToTable(True, "CCLNT", "AVION", "Nro VUELO", "PESO KG")
            oTdtTemp.TableName = "Dt_ResumenAvion"
            dsReturn.Tables.Add(oTdtTemp.Copy)

            ObjGeneralReport.TableName = "DT_General"
            dsReturn.Tables.Add(ObjGeneralReport)

            'Nueva columna SinCuenta para 11731

            dsReturn.Tables("DT_Detalle").Columns.Add("SIN_CUENTA").SetOrdinal(22)

            Dim grafo, orden, elementopep, centro_coste, cuenta_mayor As String



            For Each dr As DataRow In dsReturn.Tables("DT_Detalle").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()

                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next



            dsReturn.Tables("DT_General").Columns.Add("SIN_CUENTA").SetOrdinal(28)




            For Each dr As DataRow In dsReturn.Tables("DT_General").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()
                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next


            Return dsReturn
        End Function


        Private Function SearchDataTable(ByVal tbl2 As DataTable, ByVal Cliente As String, ByVal strPk1 As String, ByVal strPk2 As String) As DataTable
            Dim dt As New DataTable
            dt = tbl2.Copy
            dt.DefaultView.RowFilter = "CCLNT = '" & Cliente.Trim & "' and  CTRMNC = '" & strPk1.Trim & "' AND NGUIRM = '" & strPk2.Trim & "'"
            Return dt.DefaultView.ToTable
        End Function

        Private Function SearchGenericoDataTable(ByVal tbl As DataTable, ByVal where As String) As DataTable
            Dim dt As New DataTable
            dt = tbl.Copy
            dt.DefaultView.RowFilter = where
            Return dt.DefaultView.ToTable
        End Function


        Public Function Exportar_Reporte_Cargo_Plan_Fluvial_ALL(ByVal objEntidad As Solicitud_Transporte) As DataSet
            'Try
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""
            Dim strCCLNT As String = ""

            Dim objDato_Default As DataTable
            Dim objDataSet As New DataSet
            '=====================================
            Dim oDtMaterial As New DataTable
            Dim oDtResLote As New DataTable
            Dim oDtResCuenta As New DataTable
            TablaFluvialResumenLote_All(oDtResLote)
            TablaFluvialDetalleMaterial_All(oDtMaterial)
            TablaFluvialResumenCuenta_All(oDtResCuenta)
            '======================================

            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))

            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_1", objParam)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_LM", objParam)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_IMG", objParam)
            Dim objDataRow As DataRow

            '''' Hacemos los cambios en la tabla de Detalle antes de insertarle DATA
            objDato_Default = New DataTable
            objDato_Default = objDataSet.Tables(1).Copy

            objDato_Default.Columns.Add("POR_CI", GetType(System.Double))
            objDato_Default.Columns.Add("FLAG_DIST", GetType(System.String))

            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = objDato_Default.Clone

            Dim dtTempFecha As New DataTable
            'Dim dtTempM As New DataTable
            'Dim dtTempD As New DataTable
            For Each dr As DataRow In objDato_Default.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM

                'Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                'Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                'Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)

                dtTempFecha = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where)

                Dim y As String = "0000"
                Dim m As String = "00"
                Dim d As String = "00"
                If dtTempFecha.Rows.Count > 0 Then
                    y = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(6, 4)
                    m = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(3, 2)
                    d = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(0, 2)
                End If
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM & " AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG"
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCSF")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next

            '==================RESUMEN DE LOTES=====================
            Dim drSelect As DataRow() = Nothing
            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")

            Dim oDtv As DataView = New DataView(objDato_Default)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM,LOTE DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count

            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("CCLNT = " + oTabla.Rows(i)("CCLNT").ToString.Trim + " AND CTRMNC = " + oTabla.Rows(i)("CTRMNC").ToString.Trim + " AND NGUIRM = " + oTabla.Rows(i)("NGUIRM").ToString + " AND LOTE = '" + oTabla.Rows(i)("LOTE").ToString + "' ")
                TotalKG = 0
                TotalM3 = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = oDtResLote.NewRow
                    objDataRow.Item("CCLNT") = oTabla.Rows(i)("CCLNT").ToString.Trim
                    objDataRow.Item("CTRMNC") = oTabla.Rows(i)("CTRMNC").ToString.Trim
                    objDataRow.Item("NGUIRM") = oTabla.Rows(i)("NGUIRM").ToString.Trim
                    objDataRow.Item("LOTE") = oTabla.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("PESO") = TotalKG
                    objDataRow.Item("VOLUMEN") = TotalM3
                    oDtResLote.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i

            '========================================================================
            '================RESUMEN DE CUENTAS=================
            ' Dim drSelectCuentas As DataRow() = Nothing
            objDato_Default = New DataTable
            objDato_Default = oDtTempCopy.Copy 'objDataSet.Tables(1).Copy
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            objDato_Default.Columns.Remove("KG")
            objDato_Default.Columns.Remove("M3")
            objDato_Default.Columns.Remove("LOTE")
            objDato_Default.Columns.Remove("BULTOS")

            Dim oDtvCuentas As DataView = New DataView(objDato_Default)
            oDtvCuentas.RowFilter = "FLAG_DIST <> 'CI_SG' "
            Dim oTablaCuentas As New DataTable
            oTablaCuentas = oDtvCuentas.ToTable(True, "CCLNT", "CTRMNC", "NGUIRM", "CUENTA_IMPUTACION")
            For i As Integer = 0 To oTablaCuentas.Rows.Count - 1
                objDataRow = oDtResCuenta.NewRow
                objDataRow.Item("CCLNT") = oTablaCuentas.Rows(i)("CCLNT").ToString.Trim
                objDataRow.Item("CTRMNC") = oTablaCuentas.Rows(i)("CTRMNC").ToString.Trim
                objDataRow.Item("NGUIRM") = oTablaCuentas.Rows(i)("NGUIRM").ToString.Trim
                objDataRow.Item("CUENTA") = oTablaCuentas.Rows(i)("CUENTA_IMPUTACION").ToString.Trim
                objDataRow.Item("PORCENTAJE") = 0
                objDataRow.Item("MONTO") = 0
                oDtResCuenta.Rows.Add(objDataRow)
            Next
            '===================================================
            'Struct Reporte General
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy
            ObjGeneralReport.TableName = "DT_General"
            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            'Llena las Cabeceras en el Detalle

            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                'busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objDataSet.Tables(0), strPk0, strPk1, strPk2)
                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = Split(RowFiltro.Item("RUTA"), "-")(0)
                    RowTemp.Item("DESTINO") = Split(RowFiltro.Item("RUTA"), "-")(1)
                    RowTemp.Item("MEDIO") = RowFiltro.Item("TRANSPORTISTA") + Chr(10) + RowFiltro.Item("MARCA")
                    RowTemp.Item("OPERACION") = RowFiltro.Item("OPERACION")
                    RowTemp.AcceptChanges()
                Next
            Next
            ObjGeneralReport.Columns.Remove("OR")
            ObjGeneralReport.Columns.Remove("POR_CARGA")
            ObjGeneralReport.Columns.Remove("MONTO_SOLES")
            '==================================================================
            '===================SE CREA EL REPOSITORIO=========================
            '==================================================================
            oDtTempCopy.Columns.Remove("FLAG_DIST")
            Dim oDsCPFluvial As New DataSet
            Dim oDtvClientes As DataView = New DataView(objDato_Default)
            oDtvClientes.RowFilter = "TCMPCL IS NOT NULL"
            Dim oTablaClientes As New DataTable
            oTablaClientes = oDtvClientes.ToTable(True, "CCLNT", "TCMPCL")
            oTablaClientes.TableName = "Cliente"
            oDsCPFluvial.Tables.Add(objDataSet.Tables(0).Copy)
            oDsCPFluvial.Tables.Add(oDtTempCopy.Copy)
            'oDsCPFluvial.Tables.Add(objDataSet.Tables(2).Copy)
            oDsCPFluvial.Tables.Add(oDtMaterial.Copy)
            oDsCPFluvial.Tables.Add(oDtResLote.Copy)
            oDsCPFluvial.Tables.Add(oDtResCuenta.Copy)
            oDsCPFluvial.Tables.Add(oTablaClientes.Copy)
            oDsCPFluvial.Tables.Add(ObjGeneralReport)

            oDsCPFluvial.Tables(0).TableName = "DT_Filtros"
            oDsCPFluvial.Tables(1).TableName = "DT_Detalle"
            'oDsCPFluvial.Tables(2).TableName = "DT_Link"
            oDsCPFluvial.Tables(2).TableName = "DT_Material"
            oDsCPFluvial.Tables(3).TableName = "DT_Lote"
            oDsCPFluvial.Tables(4).TableName = "DT_Cuenta"
            oDsCPFluvial.Tables(5).TableName = "DT_Clientes"

            Return oDsCPFluvial
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return Nothing
            'End Try
        End Function
        ''GASTON
        Public Function Exportar_Reporte_Cargo_Plan_Fluvial_ALL_plus(ByVal objEntidad As Solicitud_Transporte) As DataSet
            'Try
            Dim strCTRMNC As String = ""
            Dim strNGUIRM As String = ""
            Dim strCCLNT As String = ""

            Dim objDato_Default As DataTable
            Dim objDataSet As New DataSet
            '=====================================
            Dim oDtMaterial As New DataTable
            Dim oDtResLote As New DataTable
            Dim oDtResCuenta As New DataTable
            TablaFluvialResumenLote_All(oDtResLote)
            TablaFluvialDetalleMaterial_All(oDtMaterial)
            TablaFluvialResumenCuenta_All(oDtResCuenta)
            '======================================

            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PNFECINI", objEntidad.FE_INI)
            objParam.Add("PNFECFIN", objEntidad.FE_FIN)
            objParam.Add("PSCLCLOR", IIf(objEntidad.CLCLOR.Equals("TODOS"), "", objEntidad.CLCLOR))
            objParam.Add("PSCLCLDS", IIf(objEntidad.CLCLDS.Equals("TODOS"), "", objEntidad.CLCLDS))

            objParam.Add("PNCCMPN", objEntidad.CCMPN)
            objParam.Add("PNCDVSN", objEntidad.CDVSN)
            objParam.Add("PSCPLNDV", objEntidad.CPLNDV_S)
            objParam.Add("PNNDCMFC", objEntidad.NDCMFC)
            '-------
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
            objParam.Add("PNNGUITR", objEntidad.NGUITR)
            objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)

            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_1", objParam)
            'objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_LM", objParam)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_EXPORTAR_CARGO_PLAN_FLUVIAL_ALL_IMG_PPC", objParam)
            Dim objDataRow As DataRow

            '''' Hacemos los cambios en la tabla de Detalle antes de insertarle DATA
            objDato_Default = New DataTable
            objDato_Default = objDataSet.Tables(1).Copy

            objDato_Default.Columns.Add("POR_CI", GetType(System.Double))
            objDato_Default.Columns.Add("FLAG_DIST", GetType(System.String))

            '================ADICiONAMOS LOS REGISTROS DE C.I. CON O/S================
            Dim oDtCI_x_OS As New DataTable
            Dim oDtTempCopy As New DataTable
            Dim oDtDetAdicional As New DataTable
            Dim drw As DataRow
            Dim fechaRng As Integer = 0
            Dim where As String = ""

            oDtCI_x_OS.TableName = "CI_x_OS"
            oDtCI_x_OS = objDataSet.Tables(2).Copy
            '================================================
            'Limpiamos  llaves principales
            strCCLNT = ""
            strCTRMNC = ""
            strNGUIRM = ""
            oDtTempCopy = objDato_Default.Clone

            Dim dtTempFecha As New DataTable
            'Dim dtTempM As New DataTable
            'Dim dtTempD As New DataTable
            For Each dr As DataRow In objDato_Default.Rows
                strCCLNT = dr("CCLNT").ToString.Trim
                strCTRMNC = dr("CTRMNC").ToString.Trim
                strNGUIRM = dr("NGUIRM").ToString.Trim
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM

                'Dim y As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(6, 4)
                'Dim m As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(3, 2)
                'Dim d As String = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where).Rows(0).Item("FECHA").ToString.Substring(0, 2)

                dtTempFecha = SearchGenericoDataTable(objDataSet.Tables(0).Copy, where)

                Dim y As String = "0000"
                Dim m As String = "00"
                Dim d As String = "00"
                If dtTempFecha.Rows.Count > 0 Then
                    y = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(6, 4)
                    m = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(3, 2)
                    d = dtTempFecha.Rows(0).Item("FECHA").ToString.Substring(0, 2)
                End If
                fechaRng = y & m & d
                where = "CCLNT = " + strCCLNT + " AND CTRMNC = " + strCTRMNC + " AND NGUIRM =" + strNGUIRM & " AND NORCML = '" & dr("OC").ToString.Trim & "' AND FINCVG <= " & fechaRng & " AND FFINVG >= " & fechaRng & " AND SESTRG = 'A'"
                oDtDetAdicional = SearchGenericoDataTable(oDtCI_x_OS.Copy, where)
                '===CARGAMOS DATA ADICIONAL==='
                If oDtDetAdicional.Rows.Count > 0 Then
                    dr("CUENTA_IMPUTACION") = "SEGUN DISTRIBUCION"
                    dr("FLAG_DIST") = "CI_SG"
                Else
                    dr("FLAG_DIST") = "0"
                End If
                oDtTempCopy.ImportRow(dr)
                For ii As Integer = 0 To oDtDetAdicional.Rows.Count - 1
                    drw = oDtTempCopy.NewRow
                    drw("CCLNT") = dr("CCLNT")
                    drw("CTRMNC") = dr("CTRMNC")
                    drw("NGUIRM") = dr("NGUIRM")

                    drw("KG") = dr("KG")
                    drw("POR_CI") = oDtDetAdicional.Rows(ii).Item("IPRCTJ")
                    drw("CUENTA_IMPUTACION") = oDtDetAdicional.Rows(ii).Item("TCTCSF")
                    drw("FLAG_DIST") = "" & dr("OC").ToString.Trim
                    oDtTempCopy.Rows.Add(drw)
                Next
            Next

            '==================RESUMEN DE LOTES=====================
            Dim drSelect As DataRow() = Nothing
            Dim TotalKG As Double = 0
            Dim TotalM3 As Double = 0
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("CUENTA_IMPUTACION")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")

            Dim oDtv As DataView = New DataView(objDato_Default)
            oDtv.Sort = "CCLNT, CTRMNC, NGUIRM,LOTE DESC"
            Dim oTabla As New DataTable
            oTabla = oDtv.ToTable
            Dim OriginalCount As Integer = oTabla.Rows.Count

            For i As Integer = 0 To OriginalCount - 1
                drSelect = objDato_Default.Select("CCLNT = " + oTabla.Rows(i)("CCLNT").ToString.Trim + " AND CTRMNC = " + oTabla.Rows(i)("CTRMNC").ToString.Trim + " AND NGUIRM = " + oTabla.Rows(i)("NGUIRM").ToString + " AND LOTE = '" + oTabla.Rows(i)("LOTE").ToString + "' ")
                TotalKG = 0
                TotalM3 = 0
                For Each dr As DataRow In drSelect
                    TotalKG += Convert.ToDouble(dr("KG"))
                    TotalM3 += Convert.ToDouble(dr("M3"))
                Next
                If drSelect.Length > 0 Then
                    objDataRow = oDtResLote.NewRow
                    objDataRow.Item("CCLNT") = oTabla.Rows(i)("CCLNT").ToString.Trim
                    objDataRow.Item("CTRMNC") = oTabla.Rows(i)("CTRMNC").ToString.Trim
                    objDataRow.Item("NGUIRM") = oTabla.Rows(i)("NGUIRM").ToString.Trim
                    objDataRow.Item("LOTE") = oTabla.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("PESO") = TotalKG
                    objDataRow.Item("VOLUMEN") = TotalM3
                    oDtResLote.Rows.Add(objDataRow)
                    i = i + drSelect.Length - 1
                End If
            Next i

            '========================================================================
            '================RESUMEN DE CUENTAS=================
            ' Dim drSelectCuentas As DataRow() = Nothing
            objDato_Default = New DataTable
            objDato_Default = oDtTempCopy.Copy 'objDataSet.Tables(1).Copy
            objDato_Default.Columns.Remove("ITEM")
            objDato_Default.Columns.Remove("OC")
            objDato_Default.Columns.Remove("GUIA_PROV")
            objDato_Default.Columns.Remove("PROVEEDOR")
            objDato_Default.Columns.Remove("DESCRIPCION")
            objDato_Default.Columns.Remove("GUIA_REMISION")
            objDato_Default.Columns.Remove("OR")
            objDato_Default.Columns.Remove("POR_CARGA")
            objDato_Default.Columns.Remove("MONTO_SOLES")
            objDato_Default.Columns.Remove("KG")
            objDato_Default.Columns.Remove("M3")
            objDato_Default.Columns.Remove("LOTE")
            objDato_Default.Columns.Remove("BULTOS")

            Dim oDtvCuentas As DataView = New DataView(objDato_Default)
            oDtvCuentas.RowFilter = "FLAG_DIST <> 'CI_SG' "
            Dim oTablaCuentas As New DataTable
            oTablaCuentas = oDtvCuentas.ToTable(True, "CCLNT", "CTRMNC", "NGUIRM", "CUENTA_IMPUTACION")
            For i As Integer = 0 To oTablaCuentas.Rows.Count - 1
                objDataRow = oDtResCuenta.NewRow
                objDataRow.Item("CCLNT") = oTablaCuentas.Rows(i)("CCLNT").ToString.Trim
                objDataRow.Item("CTRMNC") = oTablaCuentas.Rows(i)("CTRMNC").ToString.Trim
                objDataRow.Item("NGUIRM") = oTablaCuentas.Rows(i)("NGUIRM").ToString.Trim
                objDataRow.Item("CUENTA") = oTablaCuentas.Rows(i)("CUENTA_IMPUTACION").ToString.Trim
                objDataRow.Item("PORCENTAJE") = 0
                objDataRow.Item("MONTO") = 0
                oDtResCuenta.Rows.Add(objDataRow)
            Next
            '===================================================
            'Struct Reporte General
            Dim dtTempTotal As DataTable
            Dim ObjGeneralReport As New DataTable
            ObjGeneralReport = oDtTempCopy.Copy
            ObjGeneralReport.TableName = "DT_General"
            Dim strPk0 As String = ""
            Dim strPk1 As String = ""
            Dim strPk2 As String = ""

            'Crea las Columnas de la Cabecera
            ObjGeneralReport.Columns.Add(New DataColumn("FECHA", GetType(System.String)))
            ObjGeneralReport.Columns("FECHA").SetOrdinal(0)
            ObjGeneralReport.Columns.Add(New DataColumn("ORIGEN", GetType(System.String)))
            ObjGeneralReport.Columns("ORIGEN").SetOrdinal(1)
            ObjGeneralReport.Columns.Add(New DataColumn("DESTINO", GetType(System.String)))
            ObjGeneralReport.Columns("DESTINO").SetOrdinal(2)
            ObjGeneralReport.Columns.Add(New DataColumn("MEDIO", GetType(System.String)))
            ObjGeneralReport.Columns("MEDIO").SetOrdinal(3)
            ObjGeneralReport.Columns.Add(New DataColumn("OPERACION", GetType(System.String)))
            ObjGeneralReport.Columns("OPERACION").SetOrdinal(4)
            'Llena las Cabeceras en el Detalle

            For Each RowTemp As DataRow In ObjGeneralReport.Rows
                strPk0 = RowTemp.Item("CCLNT").ToString
                strPk1 = RowTemp.Item("CTRMNC").ToString
                strPk2 = RowTemp.Item("NGUIRM").ToString
                'busca El Detalle en el filtro
                dtTempTotal = SearchDataTable(objDataSet.Tables(0), strPk0, strPk1, strPk2)
                'Llena las Cabeceras en el Detalle
                For Each RowFiltro As DataRow In dtTempTotal.Rows
                    RowTemp.Item("FECHA") = RowFiltro.Item("FECHA")
                    RowTemp.Item("ORIGEN") = Split(RowFiltro.Item("RUTA"), "-")(0)
                    RowTemp.Item("DESTINO") = Split(RowFiltro.Item("RUTA"), "-")(1)
                    RowTemp.Item("MEDIO") = RowFiltro.Item("TRANSPORTISTA") + Chr(10) + RowFiltro.Item("MARCA")
                    RowTemp.Item("OPERACION") = RowFiltro.Item("OPERACION")
                    RowTemp.AcceptChanges()
                Next
            Next
            ObjGeneralReport.Columns.Remove("OR")
            ObjGeneralReport.Columns.Remove("POR_CARGA")
            ObjGeneralReport.Columns.Remove("MONTO_SOLES")
            '==================================================================
            '===================SE CREA EL REPOSITORIO=========================
            '==================================================================
            oDtTempCopy.Columns.Remove("FLAG_DIST")
            Dim oDsCPFluvial As New DataSet
            Dim oDtvClientes As DataView = New DataView(objDato_Default)
            oDtvClientes.RowFilter = "TCMPCL IS NOT NULL"
            Dim oTablaClientes As New DataTable
            oTablaClientes = oDtvClientes.ToTable(True, "CCLNT", "TCMPCL")
            oTablaClientes.TableName = "Cliente"
            oDsCPFluvial.Tables.Add(objDataSet.Tables(0).Copy)
            oDsCPFluvial.Tables.Add(oDtTempCopy.Copy)
            'oDsCPFluvial.Tables.Add(objDataSet.Tables(2).Copy)
            oDsCPFluvial.Tables.Add(oDtMaterial.Copy)
            oDsCPFluvial.Tables.Add(oDtResLote.Copy)
            oDsCPFluvial.Tables.Add(oDtResCuenta.Copy)
            oDsCPFluvial.Tables.Add(oTablaClientes.Copy)
            oDsCPFluvial.Tables.Add(ObjGeneralReport)

            oDsCPFluvial.Tables(0).TableName = "DT_Filtros"
            oDsCPFluvial.Tables(1).TableName = "DT_Detalle"
            'oDsCPFluvial.Tables(2).TableName = "DT_Link"
            oDsCPFluvial.Tables(2).TableName = "DT_Material"
            oDsCPFluvial.Tables(3).TableName = "DT_Lote"
            oDsCPFluvial.Tables(4).TableName = "DT_Cuenta"
            oDsCPFluvial.Tables(5).TableName = "DT_Clientes"


            'Nueva columna SinCuenta para 11731

            oDsCPFluvial.Tables("DT_Detalle").Columns.Add("SIN_CUENTA").SetOrdinal(25)


            Dim grafo, orden, elementopep, centro_coste, cuenta_mayor As String



            For Each dr As DataRow In oDsCPFluvial.Tables("DT_Detalle").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()

                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next


            oDsCPFluvial.Tables("DT_General").Columns.Add("SIN_CUENTA").SetOrdinal(27)


            For Each dr As DataRow In oDsCPFluvial.Tables("DT_General").Rows

                If (dr("GRAFO") Is DBNull.Value) Then
                    grafo = ""
                Else
                    grafo = dr("GRAFO").ToString().Trim()
                End If

                If (dr("ORDEN") Is DBNull.Value) Then
                    orden = ""
                Else
                    orden = dr("ORDEN").ToString().Trim()
                End If

                If (dr("ELEMENTO_PEP") Is DBNull.Value) Then
                    elementopep = ""
                Else
                    elementopep = dr("ELEMENTO_PEP").ToString().Trim()
                End If

                If (dr("CENTRO_COSTE") Is DBNull.Value) Then
                    centro_coste = ""
                Else
                    centro_coste = dr("CENTRO_COSTE").ToString().Trim()
                End If

                If (dr("CUENTA_MAYOR") Is DBNull.Value) Then
                    cuenta_mayor = ""
                Else
                    cuenta_mayor = dr("CUENTA_MAYOR").ToString().Trim()
                End If


                If (grafo = "" And orden = "" And elementopep = "" And centro_coste = "" And cuenta_mayor = "") Then
                    dr("SIN_CUENTA") = "MATERIAL SIN STOCK"
                Else
                    dr("SIN_CUENTA") = ""
                End If

            Next


            Return oDsCPFluvial
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return Nothing
            'End Try
        End Function


        Public Function Actualizar_Bulto(ByVal objParametros As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0
            'Try
            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objParam.Add("PNFLGCNL", objParametros("FLGCNL"))
            objParam.Add("PNFCNFCL", objParametros("FCNFCL"))
            objParam.Add("PNHCNFCL", objParametros("HCNFCL"))
            objParam.Add("PSTOBSEN", objParametros("TOBSEN"))
            objParam.Add("PSCULUSA", objParametros("CULUSA"))
            objParam.Add("PNNCSOTR", objParametros("NCSOTR"))
            objParam.Add("PNNCRRSR", objParametros("NCRRSR"))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CONFIRMAR_LLEGADA_X_GUIA_REMISION", objParam)
            lintResult = 1
            'Catch ex As Exception
            '    lintResult = 0
            'End Try
            Return lintResult
        End Function


        Public Function Reporte_SolicitudesProgramadas(ByVal objBE As Solicitud_Transporte, ByVal FECOST_INI As Decimal, ByVal FECOST_FIN As Decimal, ByVal HRAOTR_INI As Decimal, ByVal HRAOTR_FIN As Decimal) As DataTable

            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", "")
            objParam.Add("PSCDVSN", "")
            objParam.Add("PNCPLNDV", "")
            objParam.Add("PNCCLNT", "")
            objParam.Add("PNFECOST_INI", "")
            objParam.Add("PNFECOST_FIN", "")
            objParam.Add("PNHRAOTR_INI", "")
            objParam.Add("PNHRAOTR_FIN", "")
            objParam.Add("PNCMEDTR", "")
            objParam.Add("PSSPRSTR", "")
            objParam.Add("PSSESTOP", "")

            'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_CARGO_PLAN", objParam)
            '        Dim strNRGUCL As String = ""
            For intContador As Int64 = 0 To objDataTable.Rows.Count - 1
                objDataTable.Rows(intContador).Item("NRGUCL") = objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(0, 3) & "-" & objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(3, 7)
            Next

            'Catch : End Try
            Return objDataTable




        End Function


        Public Function Listar_Guia_Remision_Cliente_CargoPlan(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUITR", objParametros("NGUITR"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_CARGO_PLAN_LA", objParam)

            objDataTable.Columns.Add("FCGUCL_1", System.Type.GetType("System.String"))


            Dim tipoGuia As String = ""
            Dim GR_cliente As String = ""
            For Each dr As DataRow In objDataTable.Rows
                dr("FCGUCL_1") = HelpClass.CFecha_de_8_a_10(dr("FCGUCL").ToString.Trim)

                tipoGuia = ("" & dr("CTDGRM"))
                GR_cliente = ("" & dr("NGUIRS")).ToString.Trim

                If GR_cliente.Length = 10 Then
                    GR_cliente = GR_cliente.Substring(0, 3) & "-" & GR_cliente.Substring(3, 7)
                End If
                'If GR_cliente.Length = 12 Then
                '    GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4, 8)
                'End If
                If tipoGuia = "E" Then
                    GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4)
                End If


                'Select Case tipoGuia
                '    Case "F"
                '        GR_cliente = GR_cliente.Substring(0, 3) & "-" & GR_cliente.Substring(3, 7)
                '    Case "E"
                '        GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4, 8)
                'End Select
                dr("NGUIRS") = GR_cliente
                'dr("NRGUCL") = dr("NRGUCL").ToString.Substring(0, 3) & "-" & dr("NRGUCL").ToString.Substring(3, 7)
            Next

            objDataTable.Columns.Remove("FCGUCL")
            objDataTable.Columns("FCGUCL_1").ColumnName = "FCGUCL"

            '        Dim strNRGUCL As String = ""
            'For intContador As Int64 = 0 To objDataTable.Rows.Count - 1
            '    objDataTable.Rows(intContador).Item("NRGUCL") = objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(0, 3) & "-" & objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(3, 7)
            'Next

            'Catch : End Try
            Return objDataTable
        End Function

        Public Function Listar_Guia_Anexa_CargoPlan(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUITR", objParametros("NGUITR"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_TRANSPORTE_ANEXA_CARGO_PLAN", objParam)

            objDataTable.Columns.Add("FGUIRM_1", System.Type.GetType("System.String"))

            Dim tipoGuia As String = ""
            Dim GR_Transportista As String = ""
            For Each dr As DataRow In objDataTable.Rows
                dr("FGUIRM_1") = HelpClass.CFecha_de_8_a_10(dr("FGUIRM").ToString.Trim)
 
            Next

            objDataTable.Columns.Remove("FGUIRM")
            objDataTable.Columns("FGUIRM_1").ColumnName = "FGUIRM"

            'Catch : End Try
            Return objDataTable
        End Function

        Public Function Listar_Guia_Orden_Compra_CargoPlan(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUITR", objParametros("NGUITR"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ORDENES_COMPRA_CARGO_PLAN", objParam)

            Dim tipoGuia As String = ""
            Dim GR_cliente As String = ""
            For intContador As Int64 = 0 To objDataTable.Rows.Count - 1
                'objDataTable.Rows(intContador).Item("NRGUCL") = objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(0, 3) & "-" & objDataTable.Rows(intContador).Item("NRGUCL").ToString.Substring(3, 7)
                tipoGuia = ("" & objDataTable.Rows(intContador)("CTDGRM"))
                GR_cliente = ("" & objDataTable.Rows(intContador)("NGUIRS")).ToString.Trim

                If GR_cliente.Length = 10 Then
                    GR_cliente = GR_cliente.Substring(0, 3) & "-" & GR_cliente.Substring(3, 7)
                End If
                'If GR_cliente.Length = 12 Then
                '    GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4, 8)
                'End If
                If tipoGuia = "E" Then
                    GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4)
                End If

                'Select Case tipoGuia
                '    Case "F"
                '        GR_cliente = GR_cliente.Substring(0, 3) & "-" & GR_cliente.Substring(3, 7)
                '    Case "E"
                '        GR_cliente = GR_cliente.Substring(0, 4) & "-" & GR_cliente.Substring(4, 8)
                'End Select
                objDataTable.Rows(intContador)("NGUIRS") = GR_cliente

            Next

            'Catch : End Try
            Return objDataTable
        End Function

        Public Function Verificar_Pesos_Volumen_Por_Solicitud(ByVal objEntidad As Solicitud_Transporte) As DataTable
            'Try
            Dim oDt As New DataTable
            Dim objParam As New Parameter
            'objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSCTRMNC", objEntidad.PSCTRMNC)
            objParam.Add("PSNGUITR", objEntidad.PSNGUIRM)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_PESO", objParam)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_PESO_1", objParam)
            Return oDt
            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function

        Public Function Verificar_Pesos_Volumen_Por_Solicitud_Det(ByVal objEntidad As Solicitud_Transporte) As DataTable
            'Try
            Dim oDt As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_PESO_DET", objParam)
            Return oDt
            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function

        Public Function Actualizar_Peso_Volumen__CargoPlan(ByVal objParametros As Hashtable) As Int32
            Dim intResultado As Int32 = 0
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUITR", objParametros("NGUITR"))
            objParam.Add("PNCCLNT", objParametros("CCLNT"))
            objParam.Add("PNNGUIRM", objParametros("NGUIRM"))
            objParam.Add("PSCREFFW", objParametros("CREFFW"))
            objParam.Add("PNPSOVOL", objParametros("PSOVOL"))
            objParam.Add("PNPRCRMT", objParametros("PRCRMT"))
            objParam.Add("PSCUSCRT", objParametros("CUSCRT"))
            objParam.Add("PNFCHCRT", objParametros("FCHCRT"))
            objParam.Add("PNHRACRT", objParametros("HRACRT"))
            objParam.Add("PSNTRMCR", objParametros("NTRMCR"))
            objParam.Add("PSCULUSA", objParametros("CULUSA"))
            objParam.Add("PNFULTAC", objParametros("FULTAC"))
            objParam.Add("PNHULTAC", objParametros("HULTAC"))
            objParam.Add("PNNTRMNL", objParametros("NTRMNL"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PESO_VOLUMEN_CARGO_PLAN", objParam)
            intResultado = 1
            'Catch : End Try
            Return intResultado
        End Function

        Public Function Actualizar_Fecha_Guia_Transportista(ByVal objParametros As Hashtable) As Int16
            Dim intResultado As Int16 = 0
            'Try
            Dim objParam As New Parameter

            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUIRM", objParametros("NGUIRM"))
            objParam.Add("PNFECETD", objParametros("FECETD"))
            objParam.Add("PNFECETA", objParametros("FECETA"))
            objParam.Add("PNFEMVLH", objParametros("FEMVLH"))
            objParam.Add("PNFCHFTR", objParametros("FCHFTR"))

            objParam.Add("PSCULUSA", objParametros("CULUSA"))
            objParam.Add("PSTERMINAL", objParametros("TERMINAL"))


            objParam.Add("PNHRAINI", objParametros("HORAINI"))
            objParam.Add("PNHRAFTR", objParametros("HORAFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_FECHA_GUIA_TRANSPORTISTA", objParam)
            intResultado = 1
            'Catch : End Try
            Return intResultado
        End Function

        Public Function Obtener_Datos_Exclusivos(ByVal objEntidad As Solicitud_Transporte) As Solicitud_Transporte
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNORSRT", objEntidad.NORSRT)
            objParam.Add("PSCRGVTA", "", ParameterDirection.Output)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_DATOS_EXCLUSIVOS", objParam)

            objEntidad.TOBS = objSql.ParameterCollection("PSCRGVTA").ToString()
            'Catch ex As Exception
            '    objEntidad.NCSOTR = 0
            'End Try
            Return objEntidad
        End Function



        Public Function Obtener_Validacion_Homologacion_Proveedor(ByVal objParametros As Hashtable) As Hashtable
            Dim hashResultado As New Hashtable
            Try
                Dim objParam As New Parameter

                objParam.Add("PARAM_LIFNR", objParametros("LIFNR"))
                objParam.Add("PARAM_FECVRF", objParametros("FECVRF"))
                objParam.Add("PARAM_TRAMA", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP056C", objParam)
                hashResultado.Add("ZCALI", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(0, 2))
                hashResultado.Add("BEGDA", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(2, 8))
                hashResultado.Add("ENDDA", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(10, 8))
                hashResultado.Add("AGDES", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(18, 1))
                hashResultado.Add("ZBPED", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(19, 1))
                hashResultado.Add("ZCAST", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(20, 1))
                hashResultado.Add("FECASI", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(21, 8))
                hashResultado.Add("FECASF", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(29, 8))
                hashResultado.Add("STSASF", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(37, 1))
                hashResultado.Add("STSERR", objSql.ParameterCollection("PARAM_TRAMA").ToString.Substring(38, 90))
            Catch : End Try
            Return hashResultado
        End Function

        Public Function Obtener_Codigo_SAP_Proveedor(ByVal objParametros As Hashtable) As String
            Dim strResultado As String = ""
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSNRUCTR", objParametros("NRUCTR"))
            objParam.Add("PSRUCPR2", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CODIGO_SAP_PROVEEDOR", objParam)

            strResultado = objSql.ParameterCollection("PSRUCPR2").ToString.Trim

            'Catch : End Try
            Return strResultado
        End Function

        Public Function Validar_Unidades_Atendidas(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
            Dim intResult As Integer = -1
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", lintNroSolicitud)
            objParam.Add("PSCCMPN", lstrCompania)
            objParam.Add("PNSTATUS", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lstrCompania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_UNIDADES_ATENDIDAS", objParam)
            intResult = objSql.ParameterCollection("PNSTATUS")
            'Catch ex As Exception
            '    intResult = -1
            'End Try
            Return intResult
        End Function

        Public Function Validar_Unidades_Asignadas(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
            Dim intResult As Integer
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            intResult = -1
            'Try
            objParam.Add("PNCCLNT", lintNroSolicitud)
            objParam.Add("PSCCMPN", lstrCompania)
            objParam.Add("PNSTATUS", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lstrCompania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_UNIDADES_ASIGNADAS", objParam)
            intResult = objSql.ParameterCollection("PNSTATUS")
            'Catch ex As Exception
            '    intResult = -1
            'End Try
            Return intResult
        End Function

        Public Function Actualizar_Peso_Volumen_Viaje_Consolidado(ByVal objParametros As Hashtable) As Int32
            Dim intResultado As Int32 = 0
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUITR", objParametros("NGUITR"))
            objParam.Add("PSCULUSA", objParametros("CULUSA"))
            objParam.Add("PNFULTAC", objParametros("FULTAC"))
            objParam.Add("PNHULTAC", objParametros("HULTAC"))
            objParam.Add("PNNTRMNL", objParametros("NTRMNL"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PESO_VOLUMEN_VIAJE_CONSOLIDADO", objParam)
            intResultado = 1
            'Catch : End Try
            Return intResultado
        End Function

        Public Function Cerrar_Solicitud_Transporte(ByVal objEntidad As Solicitud_Transporte)

            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PSSESSLC", objEntidad.SESSLC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
         
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_SOLC_TRANSP", objParam)
         
            Return objEntidad
        End Function

        Public Function Validar_Solicitud_Transporte(ByVal lintNroSolicitud As Int64, ByVal lstrCompania As String) As Integer
            Dim intResult As Integer
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            intResult = -3

            objParam.Add("PNNCSOTR", lintNroSolicitud)
            objParam.Add("PSCCMPN", lstrCompania)
            objParam.Add("PNANULADO", 0, ParameterDirection.Output)
            objParam.Add("PNCERRADO", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lstrCompania)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_SOLICITUD_TRANSPORTE", objParam)
            If objSql.ParameterCollection("PNANULADO") = -1 Then
                intResult = objSql.ParameterCollection("PNANULADO")
            ElseIf objSql.ParameterCollection("PNCERRADO") = -2 Then
                intResult = objSql.ParameterCollection("PNCERRADO")
            Else
                intResult = 0
            End If
           
            Return intResult
        End Function


        Public Function Valida_OrdenInterna_CentroCosto(ByVal NOPRCN As Decimal) As String

            'Dim Tabla As New Hashtable
            Dim objParam As New Parameter
            objParam.Add("PARAM_NOPRCN", NOPRCN)
            objParam.Add("PARAM_MSG", "", ParameterDirection.Output)
            Dim msgValidacion As String = ""
            Dim allmsg As String = ""
            Dim drmsg() As String
          
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDA_ORDEN_INTERNA_CENTRO_COSTO", objParam)

            msgValidacion = objSql.ParameterCollection("PARAM_MSG")
            drmsg = msgValidacion.Split("|")
            For Each item As String In drmsg
                item = item.Trim
                If item.Length > 0 Then
                    allmsg = allmsg & Chr(10) & item
                End If
            Next
 


            Return allmsg
        End Function

        Public Function Listar_Solicitudes_Transporte_X_Requerimiento(ByVal NUMREQT) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            objParam.Add("PNNUMREQT", NUMREQT)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSP_REQUERIMIENTO", objParam)
            Return objDataTable
        End Function

        Public Function Listar_Solicitudes_Transporte_Requerimiento(ByVal objParametros As Solicitud_Transporte) As List(Of Solicitud_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            Dim objDatos As Solicitud_Transporte
            'Try
            objParam.Add("PNNCSOTR", objParametros.NCSOTR) 'objParametros(0)
            objParam.Add("PNCCLNT", objParametros.CCLNT) 'objParametros(1)
            objParam.Add("PSSESSLC", objParametros.SESSLC) 'objParametros(2)
            objParam.Add("PSSESTRG", objParametros.SESTRG)
            'If objParametros.FE_INI <> 0 And objParametros.FE_FIN <> 0 Then
            objParam.Add("PNFECINI", objParametros.FE_INI) 'objParametros(3)
            objParam.Add("PNFECFIN", objParametros.FE_FIN) 'objParametros(4)
            'End If

            objParam.Add("PNHRAOTR_INI", objParametros.HR_INI) 'objParametros(3)
            objParam.Add("PNHRAOTR_FIN", objParametros.HR_FIN) 'objParametros(4)

            objParam.Add("PNCMEDTR", objParametros.CMEDTR)  'objParametros(5)
            objParam.Add("PSCCMPN", objParametros.CCMPN)  'objParametros(6)
            objParam.Add("PSCDVSN", objParametros.CDVSN)  'objParametros(7)
            objParam.Add("PSCPLNDV", objParametros.CPLNDV) 'objParametros(8)
            objParam.Add("PNNOPRCN", objParametros.NOPRCN) 'objParametros(8)
            objParam.Add("PSCURSCRT", objParametros.CUSCRT)
            objParam.Add("PSTRFRN", objParametros.TRFRN)
            objParam.Add("PSSPRSTR", objParametros.SPRSTR)
            objParam.Add("PNNUMREQT", objParametros.NUMREQT)

            '===========================================
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros.CCMPN) 'objParametros(5)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_TRANSPORTE_REQUERIMIENTO", objParam)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                objDatos = New Solicitud_Transporte
                objDatos.NCSOTR = objData("NCSOTR").ToString.Trim
                objDatos.CCLNT = objData("CCLNT").ToString.Trim
                objDatos.CCLNT_COD = objData("CCLNT_COD").ToString.Trim
                objDatos.FECOST = HelpClass.CFecha_de_8_a_10(objData("FECOST").ToString).ToString.Trim
              
                objDatos.CLCLOR = objData("CLCLOR").ToString.Trim
                objDatos.TDRCOR = objData("TDRCOR").ToString.Trim
                objDatos.CLCLDS = objData("CLCLDS").ToString.Trim
                objDatos.TDRENT = objData("TDRENT").ToString.Trim
                objDatos.CMRCDR = objData("CMRCDR").ToString.Trim
                objDatos.CUNDMD = objData("CUNDMD").ToString.Trim
                objDatos.QSLCIT = CType(objData("QSLCIT"), Integer).ToString
                objDatos.QATNAN = CType(objData("QATNAN"), Integer).ToString
                objDatos.QANPRG = objData("QANPRG")
                objDatos.QMRCDR = objData("QMRCDR").ToString.Trim
                objDatos.SESSLC = objData("SESSLC").ToString.Trim
                objDatos.NORSRT = objData("NORSRT").ToString.Trim
                objDatos.CTPOSR = objData("CTPOSR").ToString.Trim
                If objData("TOBS").ToString.Trim.Length > 50 Then
                    objDatos.TOBS = objData("TOBS").ToString.Trim.Substring(0, 50) & "..."
                Else
                    objDatos.TOBS = objData("TOBS").ToString.Trim
                End If
                objDatos.CANTOP = objData("CANTOP").ToString.Trim
                objDatos.CCMPN = objData("CCMPN").ToString.Trim
                objDatos.CDVSN = objData("CDVSN").ToString.Trim
                objDatos.CPLNDV = objData("CPLNDV")
                objDatos.SFCRTV = objData("SFCRTV").ToString.Trim
                objDatos.CCTCSC = objData("CCTCSC").ToString.Trim
                objDatos.CMEDTR = objData("CMEDTR").ToString.Trim
                objDatos.TNMMDT = objData("TNMMDT").ToString.Trim
                objDatos.CLCLOR_C = objData("CLCLOR_C")
                objDatos.CLCLDS_C = objData("CLCLDS_C")
                objDatos.CUSCRT = objData("CUSCRT")
                objDatos.TRFRN = objData("TRFRN")
                objDatos.SESTRG = objData("SESTRG")
                objDatos.FULTAC = objData("CULUSA").ToString & " - " & HelpClass.CNumero8Digitos_a_Fecha(objData("FULTAC")).ToString & " - " & HelpClass.HoraNum_a_Hora(objData("HULTAC")).ToString
                objDatos.SPRSTR = objData("SPRSTR")
                'objDatos.NCTZCN = objData("NCTZCN").ToString.Trim

                objDatos.CUBORI = objData("CUBORI")

                objDatos.CUBDES = objData("CUBDES")


                objDatos.NUMREQT = objData("NUMREQT")

                REM ECM-HUNDRED-20150821-INICIO
                objDatos.TDSCSP = objData("TDSCSP").ToString().Trim
                objDatos.CDDRSP = objData("CDDRSP").ToString().Trim
                REM ECM-HUNDRED-20150821-FIN
                objDatos.FTRTSG = objData("FTRTSG").ToString().Trim

                objDatos.NMRGIM = objData("NMRGIM")
                objDatos.NMRGIM_IMG = objData("NMRGIM_IMG").ToString().Trim

 
                objDatos.TPSOTR = objData("TPSOTR")
                objDatos.TPSOTR_DESC = objData("TPSOTR_DESC")


                objGenericCollection.Add(objDatos)
            Next
 
            Return objGenericCollection
        End Function

 

        Public Function Listar_Estado_Solicitud_Requerimiento(ByVal objEntidad As Solicitud_Transporte) As List(Of Solicitud_Transporte)
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Dim Lista As New List(Of Solicitud_Transporte)
            Dim Entidad As Solicitud_Transporte

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNUMREQT", objEntidad.NUMREQT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ESTADO_SOLIC_REQ", objParam)

            For Each Item As DataRow In dt.Rows
                Entidad = New Solicitud_Transporte

                Entidad.CCMPN = Item("CCMPN")
                Entidad.NUMREQT = Item("NUMREQT")
                Entidad.SESREQ = Item("SESREQ")
                Entidad.SJTTR = Item("SJTTR").ToString.Trim
                Entidad.ESTADO_REQ = Item("ESTADO_REQ")
                Entidad.NCSOTR = Item("NCSOTR")
                Entidad.SESSLC = Item("SESSLC")
                Entidad.SESTRG = Item("SESTRG")

                Lista.Add(Entidad)

            Next

            Return Lista
        End Function

 

        Public Function Validacion_Placa_Propietario_Placa(ByVal objEntidad As Solicitud_Transporte) As DataSet

            'Dim objDataTable As New DataTable
            Dim objDataSet As New DataSet
            Dim objGenericCollection As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSSTPRCS", objEntidad.STPRCS)
            objParam.Add("PSNPLRCS", objEntidad.NPLRCS)

            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_PLACA_PROPIETARIO_PLACA", objParam)

            

            Return objDataSet

        End Function


        Public Function Mostar_Alquiler_VIGENTE(ByVal CCMPN As String, ByVal CDVSN As String, ByVal RUC_PROV As String, ByVal TIPO_RECURSO As String, ByVal PLACA_RECURSO As String, ByVal FECHA_SERVICIO As Decimal) As DataTable
            Dim ResultDatatable As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", CCMPN)  'compañia
            objParam.Add("PSCDVSN", CDVSN)  'division
            objParam.Add("PSNRUCTR", RUC_PROV) 'Ruc del Transportista
            objParam.Add("PSSTPRCS", TIPO_RECURSO) 'flag tipo de recurso
            objParam.Add("PSNPLRCS", PLACA_RECURSO) 'Nro Placa Recurso
            objParam.Add("PNFATNSR", FECHA_SERVICIO) 'Nro Placa Recurso

            'IN PARAM_FATNSR NUMERIC(8, 0) , 

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            ResultDatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_MOSTRAR_MAXIMO_ALQUILER_VIGENTE", objParam)
            Return ResultDatatable
        End Function

        Public Function Lista_Validacion_Placa(ByVal CCMPN As String) As DataTable
            Dim ResultDatatable As New DataTable
            Dim objParam As New Parameter
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            ResultDatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALIDACION_ASIG_PLACA", objParam)
            Return ResultDatatable
        End Function

        Public Function Lista_Placa_Asignacion(ByVal CCMPN As String, ByVal CDVSN As String, ByVal TIPO_RECURSO As String, ByVal PLACA As String) As DataTable
            Dim ResultDatatable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCDVSN", CDVSN)
            objParam.Add("PSSTPRCS", TIPO_RECURSO)
            objParam.Add("PSNPLRCS", PLACA)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            ResultDatatable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PROVEEDORES_ASIGNADOS_OPERACIONES", objParam)
            Return ResultDatatable
        End Function

        'JM  13/11/2014
        Public Function LISTAR_OPERACIONES_ASIGNACION(ByVal objEntidad As Solicitud_Transporte) As List(Of Solicitud_Transporte)
            Dim dt As New DataTable
            Dim Entidad As Solicitud_Transporte
            Dim Lista As New List(Of Solicitud_Transporte)
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCCLNT ", objEntidad.CCLNT)
            objParam.Add("PNNOPRCN ", objEntidad.NOPRCN)
            objParam.Add("PNFECHAINI  ", objEntidad.FE_INI)
            objParam.Add("PNFECHAFIN   ", objEntidad.FE_FIN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_ASIGNACION", objParam)


            For Each Item As DataRow In dt.Rows
                Entidad = New Solicitud_Transporte

                Entidad.NRUCTR = Item("NRUCTR")
                Entidad.TCMTRT = Item("TCMTRT")
                Entidad.NOPRCN = Item("NOPRCN")
                Entidad.TPLNTA = Item("TPLNTA")
                Entidad.FINCOP = Item("FINCOP")
                Entidad.FINCOP_S = HelpClass.CFecha_de_8_a_10(Item("FINCOP").ToString).Trim
                Entidad.FATNSR = Item("FATNSR")
                Entidad.FATNSR_S = HelpClass.CFecha_de_8_a_10(Item("FATNSR").ToString).Trim
                Entidad.NORSRT = Item("NORSRT")
                Entidad.CCLNT = Item("CCLNT")
                Entidad.CCLNT_S = Item("CCLNT_S")
                Entidad.CLCLOR = Item("CLCLOR")
                Entidad.CLCLOR_D = Item("CLCLOR_S")
                Entidad.CLCLDS = Item("CLCLDS")
                Entidad.CLCLDS_D = Item("CLCLDS_S")
                Entidad.RUTA = Item("CLCLOR_S").ToString.Trim & " - " & Item("CLCLDS_S").ToString.Trim
                Entidad.NPLCUN = Item("NPLCUN")
                Entidad.NPLCAC = Item("NPLCAC")
                Entidad.CBRCNT = Item("CBRCNT")
                Entidad.CBRCND = Item("CBRCND")
                Entidad.SESTOP = Item("SESTOP")

                Lista.Add(Entidad)
            Next
            Return Lista

        End Function

        Public Function SP_SOLMIN_ST_LISTAR_OPERACION_ENVIO_ANULACION(ByVal CCMPN As String, ByVal NOPRCN As Decimal) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNNOPRCN ", NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_ENVIO_ANULACION", objParam)
            Return objDataTable
        End Function



        REM ECM-HUNDRED-INICIO
        Public Function Validar_Cliente_Facturacion_Centro_Beneficio_OS(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSRT As Decimal) As Solicitud_Transporte
            Dim dt As New DataTable
            Dim oParametro As New Parameter
            Dim oEntidad As New Solicitud_Transporte

            'Try
            oParametro.Add("PSCCMPN", PSCCMPN)
            oParametro.Add("PSCDVSN", PSCDVSN)
            oParametro.Add("PNNORSRT", PNNORSRT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_SECTOR_CLIENTE_CEBE", oParametro)

            For Each Item As DataRow In dt.Rows
                oEntidad.CCLNFC = Item("CCLNFC").ToString().Trim()
                oEntidad.CDSCSP = Item("CDSCSP").ToString().Trim()
                oEntidad.TDSCSP = Item("TDSCSP").ToString().Trim()
                oEntidad.CDSCSP_CEBE = Item("CDSCSP_CEBE").ToString().Trim()
                oEntidad.TDSCSP_CEBE = Item("TDSCSP_CEBE").ToString().Trim()
            Next
            'Catch ex As Exception
            'End Try
            Return oEntidad
        End Function

        Public Function ObtenerParametrosValidacionServicio(ByVal CCMPN As String, ByVal IN_NOPRCN As Integer, ByVal IN_CSRVNV As Integer) As DataTable
            Dim dt As New DataTable
            Dim oParametro As New Parameter
            Dim oEntidad As New Solicitud_Transporte

            'Try
            oParametro.Add("IN_NOPRCN", IN_NOPRCN)
            oParametro.Add("IN_CSRVNV", IN_CSRVNV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_PARAMETROS_VALIDACION_SERVICIO", oParametro)

            'Catch ex As Exception
            'End Try
            Return dt
        End Function

        Public Function ValidarServicioSAP(ByVal Compania As String, ByVal RegionVenta As String, ByVal CodServicio As String) As String
            Dim resultado As String = ""
            Dim parametro As New Parameter

            'Try
            parametro.Add("PARAM_CCMPN", Compania)
            'parametro.Add("PARAM_CDVSN", Division)
            parametro.Add("PARAM_CRGVTA", RegionVenta)
            parametro.Add("PARAM_ CSRVNV", CodServicio)
            parametro.Add("PARAM_VTWEG", "95")


            parametro.Add("PARAM_FLGSTS", "", ParameterDirection.Output)
            parametro.Add("PARAM_TOBS", "", ParameterDirection.Output)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Compania)
            objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP101", parametro)

            Dim FlgEstado As String = objSql.ParameterCollection("PARAM_FLGSTS")

            If FlgEstado = "E" Then
                resultado = objSql.ParameterCollection("PARAM_TOBS")
            ElseIf FlgEstado = "0" Then
                resultado = " Error conexión SAP."
            End If

            'Catch ex As Exception
            '    resultado = ex.Message
            'End Try
            Return resultado
        End Function
        REM ECM-HUNDRED-FIN

        'INI-ECM-ActualizacionTarifario[RF002]-160516
        Public Function ListarDatoOperacionPT(ByVal CCMPN As String, ByVal IN_NOPRCN As Decimal) As DataTable
            Dim dt As New DataTable
            Dim oParametro As New Parameter
            Dim oEntidad As New Solicitud_Transporte
            oParametro.Add("IN_NOPRCN", IN_NOPRCN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DATOS_OPERACION_PT", oParametro)
            Return dt
        End Function
        'FIN-ECM-ActualizacionTarifario[RF002]-160516

        Public Function Anulacion_Operacion_Transporte_Salm(ByVal objEntidad As Solicitud_Transporte, ByRef anulado_sin_op As String) As String

            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0
            Dim dt As New DataTable
            Dim msg As String = ""
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
          
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            'Agregar campos nuevos

            objParam.Add("PSANULAR", objEntidad.ANULAR)

            objParam.Add("PSFLGAPG", objEntidad.FLGAPG)
            objParam.Add("PNNOPRCR", objEntidad.NOPRCR)
            objParam.Add("PSUSLAOP", objEntidad.USLAOP)
            objParam.Add("PSUATAOP", objEntidad.UATAOP)
            objParam.Add("PSMOTAOP", objEntidad.MOTAOP)
            objParam.Add("PSOBSAOP", objEntidad.OBSAOP)
            objParam.Add("PSTRFSRC", objEntidad.TRFSRC)

            objParam.Add("PSCARERS", objEntidad.CARERS)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ANULAR_OPERACION_TRANSPORTE_SALM", objParam)
            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "E" Then
                    msg = msg & Item("OBSRESULT") & Chr(13)
                End If
             
            Next


            anulado_sin_op = ""
            If msg = "" Then
                If dt.Rows.Count > 0 Then
                    anulado_sin_op = ("" & dt.Rows(0)("ANULADO_SIN_OP")).ToString.Trim
                End If
            End If

            Return msg
        End Function

        Public Function Valida_Transportista(ByVal PSCCMPN As String, ByVal PSNRUCTR As String, ByVal PNSTSASF As String, ByVal PSSTSERR As String) As String

            Dim dt As New DataTable
            Dim oParametro As New Parameter
            oParametro.Add("PSCCMPN", PSCCMPN)
            oParametro.Add("PSNRUCTR", PSNRUCTR)
            oParametro.Add("PNSTSASF", PNSTSASF)
            oParametro.Add("PSSTSERR", PSSTSERR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_TRANSPORTISTA", oParametro)
            Dim msg As String = ""
            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "N" Then
                    msg = msg & Item("OBSRESULT") & Chr(13)
                End If
            Next
            Return msg.Trim
        End Function


        Public Function Valida_Homologacion_GeneralTransportista(ByVal PSCCMPN As String, ByVal PSNRUCTR As String) As String

            Dim dt As New DataTable
            Dim oParametro As New Parameter
            oParametro.Add("PSCCMPN", PSCCMPN)
            oParametro.Add("PSNRUCTR", PSNRUCTR)            
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_HOMOLOGACION_TRANSPORTISTA", oParametro)
            Dim msg As String = ""
            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "N" Then
                    msg = msg & Item("OBSRESULT") & Chr(13)
                End If
            Next
            Return msg.Trim
        End Function



        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        Public Function Valida_Moneda_Sollicitud(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objParam As New Parameter
            Dim dt As New DataTable

            objParam.Add("IN_CCMPN", objEntidad.CCMPN)
            objParam.Add("IN_CDVSN", objEntidad.CDVSN)
            objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("IN_CCLNT", objEntidad.CCLNT)
            objParam.Add("IN_CTPOVJ", objEntidad.CTPOVJ)
            objParam.Add("IN_NMVJCS", objEntidad.NOPRCN)
            objParam.Add("IN_NORSRT", objEntidad.NORSRT)

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            objParam.Add("IN_CLCLOR", objEntidad.CLCLOR)
            objParam.Add("IN_CLCLDS", objEntidad.CLCLDS)
            '----- Fin -----

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDA_MONEDA_ORDEN_SERVICIO", objParam)
            Return dt
        End Function
        '----- Fin -----


        Public Function Listar_Seguimiento_Traslado_Hito(ByVal objEntidad As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCDVSN", objEntidad("CDVSN"))
            objParam.Add("PSCPLNDV", objEntidad("CPLNDV"))
            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNCMEDTR", objEntidad("CMEDTR"))
            objParam.Add("PSTIPOBUSQ", objEntidad("TIPOBUSQ"))
            objParam.Add("PSDOCBUSQ", objEntidad("DOCBUSQ"))
            objParam.Add("PNCTRSPT", objEntidad("CTRSPT"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PSSDSNVJ", objEntidad("SDSNVJ"))
            objParam.Add("PSESTENTREGA", objEntidad("ESTENTREGA"))

            objParam.Add("PSCLCLOR", objEntidad("CLCLOR"))
            objParam.Add("PSCLCLDS", objEntidad("CLCLDS"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SEGUIMIENTO_TRASLADO_HITO", objParam)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SEGUIMIENTO_TRASLADO_HITOV2", objParam)




            Dim listChkFecha As New List(Of String)
            Dim listChkHora As New List(Of String)
            For Each Item As DataColumn In objDataTable.Columns
                If Item.ColumnName.Contains("F_CHK_") Then
                    listChkFecha.Add(Item.ColumnName)
                End If
            Next
            For Each Item As DataColumn In objDataTable.Columns
                If Item.ColumnName.Contains("H_CHK_") Then
                    listChkHora.Add(Item.ColumnName)
                End If
            Next

            For Each Item As DataRow In objDataTable.Rows
                
                Item("FGUIRM") = HelpClass.FechaNum_a_Fecha(Item("FGUIRM"))
                Item("FECETD") = HelpClass.FechaNum_a_Fecha(Item("FECETD"))
                Item("FECETA") = HelpClass.FechaNum_a_Fecha(Item("FECETA"))
                Item("F_INI_TRASL") = HelpClass.FechaNum_a_Fecha(Item("F_INI_TRASL"))
                Item("F_LLEGD_TRASL") = HelpClass.FechaNum_a_Fecha(Item("F_LLEGD_TRASL"))
                Item("H_INI_TRASL") = HelpClass.HoraNum_a_Hora_Cadena(Item("H_INI_TRASL"))
                Item("H_LLEGD_TRASL") = HelpClass.HoraNum_a_Hora_Cadena(Item("H_LLEGD_TRASL"))
                Item("FINCOP") = HelpClass.FechaNum_a_Fecha(Item("FINCOP"))
                For Each ItemChk As String In listChkFecha
                    Item(ItemChk) = HelpClass.FechaNum_a_Fecha(Item(ItemChk))
                Next
                For Each ItemChk As String In listChkHora
                    Item(ItemChk) = HelpClass.HoraNum_a_Hora_Cadena(Item(ItemChk))
                Next


            Next

            Return objDataTable
        End Function



        Public Sub Actualizar_Fecha_ETA(ByVal objParametros As Hashtable)
            Dim objParam As New Parameter
            objParam.Add("PNCTRMNC", objParametros("CTRMNC"))
            objParam.Add("PNNGUIRM", objParametros("NGUIRM"))
            objParam.Add("PNFECETA", objParametros("FECETA"))
            objParam.Add("PSCULUSA", objParametros("CULUSA"))
            objParam.Add("PSTERMINAL", objParametros("TERMINAL"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ETA", objParam)
        End Sub


        Public Function Listar_GuiasPendientesCierre(ByVal objEntidad As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCDVSN", objEntidad("CDVSN"))
            objParam.Add("PSCPLNDV", objEntidad("CPLNDV"))
            objParam.Add("PNCCLNT", objEntidad("CCLNT"))
            objParam.Add("PNCMEDTR", objEntidad("CMEDTR"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PNFECINI_GT", objEntidad("FECINI_GT"))
            objParam.Add("PNFECFIN_GT", objEntidad("FECFIN_GT"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_SEGUIMIENTO_LISTAR_GUIAS_PENDIENTES_CIERRE", objParam)


            For Each Item As DataRow In objDataTable.Rows
                Item("FGUIRM") = HelpClass.FechaNum_a_Fecha(Item("FGUIRM"))
                Item("FECETD") = HelpClass.FechaNum_a_Fecha(Item("FECETD"))
                Item("FECETA") = HelpClass.FechaNum_a_Fecha(Item("FECETA"))
                Item("F_INI_TRASL") = HelpClass.FechaNum_a_Fecha(Item("F_INI_TRASL"))
                Item("F_LLEGD_TRASL") = HelpClass.FechaNum_a_Fecha(Item("F_LLEGD_TRASL"))
                Item("H_INI_TRASL") = HelpClass.HoraNum_a_Hora_Cadena(Item("H_INI_TRASL"))
                Item("H_LLEGD_TRASL") = HelpClass.HoraNum_a_Hora_Cadena(Item("H_LLEGD_TRASL"))
                Item("FINCOP") = HelpClass.FechaNum_a_Fecha(Item("FINCOP"))


            Next

            Return objDataTable
        End Function


        Public Function Anulacion_Detalle_Solicitud_Transporte_SALM(ByVal objEntidad As Solicitud_Transporte) As String
            Dim objParam As New Parameter
            Dim lintResult As Int16 = 0
            Dim dt As New DataTable
            Dim msg As String = ""
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ANULAR_DETALLE_ASIGNACION_SOLICITUD_TRANSPORTES", objParam)
            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "E" Then
                    msg = msg & Item("OBSRESULT") & Chr(13)
                End If

            Next
            msg = msg.Trim

            Return msg
        End Function

    End Class
End Namespace

