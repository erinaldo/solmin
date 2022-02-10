'/*------------------------------------------------------------------------------*/
'/*----- Empresa          	: RANSA S.A.                                    -----*/
'/*----- Sistema          	: Solmin                  	                    -----*/
'/*----- Módulo          	: SD-SA-SC                  	     	        -----*/
'/*----- Nombre Programa    : UcServicioAtendido			                -----*/
'/*----- Desarrollado por	: Alann Crispin	                                -----*/
'/*----- Fecha Creación     : 23/05/2011                      	            -----*/
'/*----- Descripción        : Control que contiene los                    	-----*/
'/*-----                      servicios por operación                     	-----*/
'/*------------------------------------------------------------------------------*/
'/*----- Modificado por	    : Alann Crispin	                                -----*/
'/*----- Fecha Modificación : 25/05/2011                      	            -----*/
'/*----- Descripción        : Se agrega parametro CCLNFC y FLGPEN a Funcion -----*/ 
'/*-----                        Lista_Servicios_x_Cliente                   -----*/  	
'/*------------------------------------------------------------------------------*/
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data.Odbc


Namespace DATOS

    Public Class clsServicio_DAL
        Public Sub Quitar_Servicio(ByVal pobjServicioSIL As Servicio_BE)
            'Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

            'lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_QUITAR_SERVICIO_SIL", lobjParams)
            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SC_QUITAR_SERVICIO_SIL_RZSC19", lobjParams)

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Sub

        Public Sub AnularConsistencia(ByVal oServicio As Servicio_BE)
            'Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSNSECFC", oServicio.NSECFC)
            lobjParams.Add("PSCUSCRT", oServicio.PSUSUARIO)          
            lobjParams.Add("PSNTRMCR", oServicio.NTRMNC)
            lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_REVISION_RZSC20", lobjParams)
          
        End Sub

        Public Sub AnularConsistenciaMasivo(ByVal oServicio As Servicio_BE)
            'Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim ret As Integer = 0
            Dim dt As New DataTable

            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSLISTJSON", oServicio.LISTJSON)
            lobjParams.Add("PSCUSCRT", oServicio.PSUSUARIO)
            lobjParams.Add("PSNTRMCR", oServicio.NTRMNC)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_ANULAR_REVISIONMASIVO_RZSC20", lobjParams)
            ret = 1
        End Sub


        Public Function Lista_Servicios_x_Cliente(ByVal oServicioSIL As Servicio_BE) As DataTable
            'Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNTIPO_PLANTA", oServicioSIL.TIPO_PLANTA)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicioSIL.CCLNFC)
            lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)
            lobjParams.Add("PNFECINI", oServicioSIL.FECINI)
            lobjParams.Add("PNFECFIN", oServicioSIL.FECFIN)
            lobjParams.Add("PSFLGFAC", oServicioSIL.FLGFAC)
            lobjParams.Add("PSFLGPEN", oServicioSIL.FLGPEN)
            lobjParams.Add("PNTIPO_PROC", oServicioSIL.TIPO_PROCESO)
            lobjParams.Add("PSSTPODP", oServicioSIL.STPODP)
            lobjParams.Add("PSCTPALJ", oServicioSIL.CTPALJ)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicioSIL.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicioSIL.FECSERV_FIN)
            lobjParams.Add("PSTLUGEN", oServicioSIL.TLUGEN)
            lobjParams.Add("PSNORCML", oServicioSIL.NORCML)


            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_SERVICIO_CLIENTE", lobjParams)

            For Each item As DataRow In dt.Rows
                item("FOPRCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FOPRCN"))
                item("FCHCRT") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHCRT"))
                item("HRACRT") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(item("HRACRT"))
                item("FULTAC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FULTAC"))
                item("HULTAC") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(item("HULTAC"))
            Next
      

            Return dt

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function Lista_Servicios_Consolidado(ByVal oServicio As Servicio_BE) As DataTable

            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNNRTFSV", oServicio.NRTFSV)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)
            lobjParams.Add("PSFLGFAC", oServicio.FLGFAC)
            lobjParams.Add("PSFLGPEN", oServicio.FLGPEN)
            lobjParams.Add("PNTIPO_PROC", oServicio.TIPO_PROCESO)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PSCTPALJ", oServicio.CTPALJ)
            lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicio.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicio.FECSERV_FIN)
            lobjParams.Add("PNNSECFC", oServicio.NSECFC)
            lobjParams.Add("PSTLUGEN", oServicio.TLUGEN)
            lobjParams.Add("PSNORCML", oServicio.NORCML)

            lobjParams.Add("PNNROVLR ", oServicio.NROVLR)
            lobjParams.Add("PSDOCVLR", oServicio.DOCVLR)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_LISTA_OPERACION_SERVICIO_CONSOLIDADO", lobjParams)

            Return dt
          
        End Function

        Public Function Lista_OperacionesRevisadas(ByVal oServicio As Servicio_BE) As DataTable
            'Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)

            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNNSECFC", oServicio.NSECFC)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)

            lobjParams.Add("PSFLGFAC", oServicio.FLGFAC)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PSTLUGEN", oServicio.TLUGEN)
            'dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_OPERACIONES_REVISADAS", lobjParams)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_OPERACIONES_REVISADAS_V2", lobjParams)

            Return dt
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function


        Public Function fdtListaServicioOperacion(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_LISTA_SERVICIOS_X_OPERACION_RZSC20", lobjParams)
            Return dt
        End Function

        Public Function Lista_Detalle_Servicios_SIL(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_DETALLE_SERVICIOS_SIL", lobjParams)
            Return dt
        End Function

        Public Function Lista_Detalle_Servicios_Almacen(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_DETALLE_SERVICIOS_ALMACEN", lobjParams)
            Return dt
        End Function

        Public Function Verificar_Servicios_Atendidos(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_VERIFICA_SERVICIO_FACTURADO", lobjParams)
            Return dt
        End Function

        Public Function Lista_Tarifa_Servicios_Cliente(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicioSIL.CPLNDV)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNFECSER", oServicioSIL.FOPRCN)
            'If oServicioSIL.CDVSN = "R" Then
            lobjParams.Add("PNNRRUBR", oServicioSIL.NRRUBR)
            'End If
            'dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION", lobjParams)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION_V2", lobjParams)
            Return dt
        End Function

        Public Function Lista_Tarifa_Servicios_Cliente_Permanencia(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicioSIL.CPLNDV)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNFECSER", oServicioSIL.FOPRCN)
            lobjParams.Add("PNNRRUBR", oServicioSIL.NRRUBR)
            lobjParams.Add("PSSTPTRA", oServicioSIL.STPTRA)
            lobjParams.Add("PSTTPOMR", oServicioSIL.TTPOMR)
            lobjParams.Add("PSCTPALM", oServicioSIL.CTPALM)

            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION_X_MEDIDA", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function



        Public Function Listar_TablaAyuda_L01(ByVal strCategoria As String) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CODVAR", strCategoria)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_TBLAYU_RZO103_L01", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function

        Public Function Listar_TablaAyuda_L02(ByVal strCategoria As String) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CODVAR", strCategoria)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_TBLAYU_RZO103_L02", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function

        ''' <summary>
        ''' Lista de Rubros pro compania División
        ''' </summary>
        ''' <param name="oServicio"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdtListaRubroXCompaniaDivision(ByVal oServicio As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CCMPN", oServicio.CCMPN)
            lobjParams.Add("IN_CDVSN", oServicio.CDVSN)
            lobjParams.Add("IN_CPLNDV", oServicio.CPLNDV)
            lobjParams.Add("IN_CCLNT", oServicio.CCLNT)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_RUBRO_LIST_V2", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function


#Region "SERVICIOS DE FACTURACION ALMACEN"

        Public Function fdecInsertarOperacionFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
            Dim lobjSql As New SqlManager
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oServicios.CCLNT)
            objParam.Add("PNFOPRCN", oServicios.FOPRCN)
            objParam.Add("PNCCLNFC", oServicios.CCLNFC)
            objParam.Add("PSCCMPN", oServicios.CCMPN)
            objParam.Add("PSCDVSN", oServicios.CDVSN)
            objParam.Add("PNCPLNDV", oServicios.CPLNDV)
            objParam.Add("PSSTIPPR", oServicios.STIPPR)
            objParam.Add("PSSTPODP", oServicios.STPODP)
            objParam.Add("PSCTPALJ", oServicios.CTPALJ)
            objParam.Add("PSTRDCCL", oServicios.TRDCCL)
            objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
            objParam.Add("PNNOPRCN", 0, ParameterDirection.Output)
            objParam.Add("PARAM_CDIRSE", oServicios.CDIRSE)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_OPERACION_FACTURAR_INSERT", objParam)
            Return lobjSql.ParameterCollection("PNNOPRCN")
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function


        Public Function fdecActualizarOperacionFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
            Dim lobjSql As New SqlManager
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oServicios.CCLNT)
            objParam.Add("PNNOPRCN", oServicios.NOPRCN)
            objParam.Add("PNFOPRCN", oServicios.FOPRCN)
            objParam.Add("PNCCLNFC", oServicios.CCLNFC)
            objParam.Add("PSSTIPPR", oServicios.STIPPR)
            objParam.Add("PSTRDCCL", oServicios.TRDCCL)
            objParam.Add("PSSESTRG", oServicios.SESTRG)
            objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objParam.Add("MSGERR", "", ParameterDirection.Output)
            objParam.Add("PARAM_CDIRSE", oServicios.CDIRSE)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_OPERACION_FACTURAR_UPDATE", objParam)
            'Return lobjSql.ParameterCollection("MSGERR")
            Return 1
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function

        ' Public Function fdecInsertarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
        Public Function fdecInsertarServiciosFacturacionSA(ByVal oServicios As Servicio_BE, ByRef NCRROP As Decimal) As String
            Dim lobjSql As New SqlManager
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oServicios.CCLNT)
            objParam.Add("PNFOPRCN", oServicios.FOPRCN)
            objParam.Add("PNCCLNFC", oServicios.CCLNFC)
            objParam.Add("PNNRTFSV", oServicios.NRTFSV)
            objParam.Add("PSCCMPN", oServicios.CCMPN)
            objParam.Add("PSCDVSN", oServicios.CDVSN)
            objParam.Add("PNQATNAN", oServicios.QATNAN)
            objParam.Add("PNQATNRL", oServicios.QATNRL)
            objParam.Add("PSSTIPPR", oServicios.STIPPR)
            objParam.Add("PSSTPODP", oServicios.STPODP)
            objParam.Add("PSCTPALJ", oServicios.CTPALJ)
            objParam.Add("PNFINPRF", oServicios.FINPRF)
            objParam.Add("PNFFNPRF", oServicios.FFNPRF)
            objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
            objParam.Add("PNNOPRCN", oServicios.NOPRCN)
            objParam.Add("PSTCTCST", oServicios.TCTCST)
            objParam.Add("PSNORCML", oServicios.NORCML)
            objParam.Add("PSTLUGEN", oServicios.TLUGEN)
            objParam.Add("PSTSRVC", oServicios.TSRVC)
            objParam.Add("PNFATNSR", oServicios.FATNSR)

            objParam.Add("PSTRFSRC", oServicios.TRFSRC)

            objParam.Add("PNCCNTCS", oServicios.CCNTCS)

            objParam.Add("PNCENCOS", oServicios.CENCOS)
            objParam.Add("PNCENCO2", oServicios.CENCO2)

            objParam.Add("PNNCRROP", oServicios.NCRROP)

            'objParam.Add("PNNCRROP", 0, ParameterDirection.Output)            
            'lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_FACTURAR_INSERT_V1", objParam)
            Dim dt As New DataTable
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_FACTURAR_INSERT_V2", objParam)
            Dim msg As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim
            If msg.Length = 0 Then
                NCRROP = dt.Rows(0)("NCRROP")
            End If

            Return msg

            'Return lobjSql.ParameterCollection("PNNCRROP")
            'Return 1
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function

        Public Function fintActualizarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As String
            Dim lobjSql As New SqlManager
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oServicios.CCLNT)
            objParam.Add("PNNOPRCN", oServicios.NOPRCN)
            objParam.Add("PNNCRROP", oServicios.NCRROP)
            objParam.Add("PNFOPRCN", oServicios.FOPRCN)
            objParam.Add("PNCCLNFC", oServicios.CCLNFC)
            objParam.Add("PNNRTFSV", oServicios.NRTFSV)
            objParam.Add("PSCCMPN", oServicios.CCMPN)
            objParam.Add("PSCDVSN", oServicios.CDVSN)
            objParam.Add("PNQATNAN", oServicios.QATNAN)
            objParam.Add("PNQATNRL", oServicios.QATNRL)
            objParam.Add("PSSTIPPR", oServicios.STIPPR)
            objParam.Add("PSFLGFAC", oServicios.FLGFAC)
            objParam.Add("PSSESTRG", oServicios.SESTRG)
            objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
            objParam.Add("PNFINPRF", oServicios.FINPRF)
            objParam.Add("PNFFNPRF", oServicios.FFNPRF)
            objParam.Add("PSTCTCST", oServicios.TCTCST)
            objParam.Add("PSNORCML", oServicios.NORCML)
            objParam.Add("PSTLUGEN", oServicios.TLUGEN)
            objParam.Add("PSTSRVC", oServicios.TSRVC)
            objParam.Add("PNFATNSR", oServicios.FATNSR)

            objParam.Add("PSTRFSRC", oServicios.TRFSRC)

            objParam.Add("PNCCNTCS", oServicios.CCNTCS)

            objParam.Add("PNCENCOS", oServicios.CENCOS)
            objParam.Add("PNCENCO2", oServicios.CENCO2)

            objParam.Add("PNTIPO", Val("" & oServicios.TIPO_PROCESO & ""))

            'lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_FACTURAR_UPDATE_V1", objParam)
            Dim dt As New DataTable
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_FACTURAR_UPDATE_V2", objParam)
            Dim msg As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim

            Return msg

            'Return 1
            'Catch ex As Exception

            '    Return 0
            'End Try
        End Function

        'Public Function fdecInsertarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
        '    Dim lobjSql As New SqlManager
        '    Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PNCCLNT", oServicios.CCLNT)
        '        objParam.Add("PNNOPRCN", oServicios.NOPRCN)
        '        objParam.Add("PNCCLNFC", oServicios.CCLNFC)
        '        objParam.Add("PNNRTFSV", oServicios.NRTFSV)
        '        objParam.Add("PSCCMPN", oServicios.CCMPN)
        '        objParam.Add("PSCDVSN", oServicios.CDVSN)
        '        objParam.Add("PNQATNAN", oServicios.QATNAN)
        '        objParam.Add("PNFINPRF", oServicios.FINPRF)
        '        objParam.Add("PNFFNPRF", oServicios.FFNPRF)
        '        objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
        '        objParam.Add("PNNCRROP", 0, ParameterDirection.InputOutput)
        '        lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_FACTURAR_INSERT", objParam)
        '        Return lobjSql.ParameterCollection("PNNCRROP")
        '    Catch ex As Exception
        '        ''retornamos -1 por que 
        '        Return 0
        '    End Try
        '    Return 1
        'End Function

        'Public Function fintActualizarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Integer
        '    Dim lobjSql As New SqlManager
        '    Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PNCCLNT", oServicios.CCLNT)
        '        objParam.Add("PNNOPRCN", oServicios.NOPRCN)
        '        objParam.Add("PNNCRROP", oServicios.NCRROP)
        '        objParam.Add("PNQATNAN", oServicios.QATNAN)
        '        objParam.Add("PSSESTRG", oServicios.SESTRG)
        '        objParam.Add("PSUSUARI", oServicios.PSUSUARIO)
        '        lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_FACTURAR_UPDATE", objParam)
        '    Catch ex As Exception
        '        Return 0
        '    End Try
        '    Return 1
        'End Function

        Public Function fdtObtenerServiciosFacturacionSA(ByVal oServicioSIL As Servicio_BE) As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("IN_CDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("IN_CCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("IN_NOPRCN", oServicioSIL.NOPRCN)
            'Try
            Return lobjSql.ExecuteDataSet("SP_SOLMIN_SA_SERVICIOS_FACTURAR_LIST", lobjParams)
            'Catch ex As Exception
            '    Return New DataSet
            'End Try
        End Function
        Public Function fdtObtenerServiciosFacturacionReembolso(ByVal oServicioSIL As Servicio_BE) As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("IN_CDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("IN_CCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("IN_NOPRCN", oServicioSIL.NOPRCN)
            'Try
            Return lobjSql.ExecuteDataSet("SP_SOLMIN_SA_SERVICIOS_FACTURAR_REMBOLSO_LIST", lobjParams)
            'Catch ex As Exception
            '    Return New DataSet
            'End Try
        End Function


        Public Function fstrInsertarDetalleServiciosFacturacionSA_SAT(ByVal oDetalleServicio As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams
                .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                .Add("IN_CREFFW", oDetalleServicio.CREFFW)
                .Add("IN_CPRCN1", oDetalleServicio.CPRCN1)
                .Add("IN_NSRCN1", oDetalleServicio.NSRCN1)
                .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                .Add("IN_CCMPN", oDetalleServicio.CCMPN)
                .Add("IN_CDVSN", oDetalleServicio.CDVSN)
                .Add("IN_CPLNDV", oDetalleServicio.CPLNDV)
                .Add("PSCTPALM", oDetalleServicio.CTPALM)
                .Add("PSCALMC", oDetalleServicio.CALMC)
                .Add("PSCZNALM", oDetalleServicio.CZNALM)
                .Add("PNNSEQIN", oDetalleServicio.NSEQIN)
                .Add("PNCMEDTR", oDetalleServicio.MEDIOENVIO)
                .Add("PNNCRROP", oDetalleServicio.NCRROP)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
                Dim strMensajeError As String = ""
                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_DETALLE_SERVICIOS_FACTURAR_INSERT", lobjParams)
                Return lobjSql.ParameterCollection("OU_MSGERR").ToString.Replace("%", Chr(10))
            End With
            'Catch ex As Exception
            '    Return "Error"
            'End Try
        End Function

        Public Function fstrInsertarDetalleServiciosPromediosSA_RZSC25(ByVal oDetalleServicio As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("PNCCLNT", oDetalleServicio.CCLNT)
                    .Add("PNNOPRCN", oDetalleServicio.NOPRCN)
                    .Add("PNNCRRDC", oDetalleServicio.NCRRDC)

                    .Add("PNFPRCSO", oDetalleServicio.FPRCSO)

                    .Add("PNQPSOTT", oDetalleServicio.QPSOTT)
                    .Add("PNQVOLMR", oDetalleServicio.QVOLMR)
                    .Add("PNQARMTS", oDetalleServicio.QARMTS)

                    .Add("PSCUSCRT", oDetalleServicio.PSUSUARIO)

                    Dim strMensajeError As String = ""
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_DETALLE_BULTO_PROMEDIO_INSERT_RZSC25", lobjParams)
                    Return ""
                End With
            Catch ex As Exception
                Return "Error"
            End Try
        End Function



        Public Function fstrInsertarDetalleServiciosFacturacionSA_SDS(ByVal oDetalleServicio As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams
                .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                .Add("IN_NORDSR", oDetalleServicio.NORDSR)
                .Add("IN_NSLCSR", oDetalleServicio.NSLCSR)
                .Add("IN_CPRCN1", oDetalleServicio.CPRCN1)
                .Add("IN_NSRCN1", oDetalleServicio.NSRCN1)
                .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                .Add("PNNCRROP", oDetalleServicio.NCRROP)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
                Dim strMensajeError As String = ""
                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_DETALLE_SERVICIOS_FACTURAR_INSERT", lobjParams)
                Return lobjSql.ParameterCollection("OU_MSGERR").ToString.Replace("%", Chr(10))
            End With
            'Catch ex As Exception
            '    Return "Error"
            'End Try
        End Function

        Public Function fintEliminarDetalleServiciosFacturacionSA(ByVal oDetalleServicio As Servicio_BE) As Integer
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                    .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                    .Add("IN_NCRRDC", oDetalleServicio.NCRRDC)
                    .Add("IN_STPODP", oDetalleServicio.STPODP)
                    .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_SERVICIOS_FACTURAR_DELETE", lobjParams)
                    Return 1
                End With
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function fintActualizarDetalleServiciosFacturacionSA(ByVal oDetalleServicio As Servicio_BE) As Integer
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams
                .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                .Add("IN_NCRRDC", oDetalleServicio.NCRRDC)
                .Add("IN_CPRCN1", oDetalleServicio.CPRCN1)
                .Add("IN_NSRCN1", oDetalleServicio.NSRCN1)
                .Add("IN_STPODP", oDetalleServicio.STPODP)
                .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_SERVICIOS_FACTURAR_UPDATE", lobjParams)
                Return 1
            End With
            'Catch ex As Exception
            '    Return 0
            'End Try
        End Function

        Public Function fdtListaDetalleServiciosFacturacionSA(ByVal oServicioSIL As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("IN_CCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("IN_NOPRCN", oServicioSIL.NOPRCN)
            If oServicioSIL.STPODP = "7" Then
                lobjParams.Add("IN_CCMPN", oServicioSIL.CCMPN)
                lobjParams.Add("IN_CDVSN", oServicioSIL.CDVSN)
                lobjParams.Add("IN_CPLNDV", oServicioSIL.CPLNDV)
                'lobjParams.Add("IN_NCRROP", oServicioSIL.NCRROP)
            End If
            Try
                dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_SERVICIOS_FACTURAR_LIST", lobjParams)
            Catch ex As Exception
                dt = New DataTable
            End Try
            Return dt
        End Function

        Public Function fdtListaBultoFacturarSA(ByRef oServicios As Servicio_BE) As DataTable
            Dim dtTemp As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            ' Ingresamos los parametros del Procedure
            With lobjParams
                .Add("IN_CCLNT", oServicios.CCLNT)
                .Add("IN_CREFFW", oServicios.CREFFW)
                .Add("IN_NROPLT", oServicios.NROPLT)
                .Add("IN_NROCTL", oServicios.NROCTL)
                .Add("IN_NRGUSA", oServicios.NRGUSA)
                '.Add("IN_NGUIRM", oServicios.NGUIRM)
                .Add("IN_NGUIRS", oServicios.NGUIRS)
                .Add("IN_CCMPN", oServicios.CCMPN)
                .Add("IN_CDVSN", oServicios.CDVSN)
                .Add("IN_CPLNDV", oServicios.CPLNDV)
                .Add("IN_NOPRCN", oServicios.NOPRCN)
                .Add("IN_NGRPRV", oServicios.NGRPRV)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With

            Try
                dtTemp = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_BULTO_FACTURAR_LIST", lobjParams)
                oServicios.PSERROR = lobjSql.ParameterCollection("OU_MSGERR").ToString.Replace("%", Chr(10))
            Catch ex As Exception
                dtTemp = New DataTable
            End Try
            Return dtTemp
        End Function

        Public Function Eliminar_Item_Detalle_Servicio_Sil(ByVal oServicioSIL As Servicio_BE) As Int32
            Dim retorno As Int32 = 0
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNNORSCI", oServicioSIL.PNNORSCI)
            lobjParams.Add("PSCUSCRT", oServicioSIL.PSUSUARIO)
            lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_ITEM_DETALLE_SERVICIOS_SIL", lobjParams)
            retorno = 1
            Return retorno
        End Function

        Public Function fintInsertarServiciosFacturacionAlmacenajeSA(ByVal oDetalleServicio As Servicio_BE) As Integer
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                    .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                    .Add("IN_CCMPN", oDetalleServicio.CCMPN)
                    .Add("IN_CDVSN", oDetalleServicio.CDVSN)
                    .Add("IN_CPLNDV", oDetalleServicio.CPLNDV)
                    .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                    '  .Add("OU_MSGERR", "", ParameterDirection.Output)
                    Dim strMensajeError As String = ""
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_DETALLE_SERVICIOS_FACTURAR_INSERT_ALMACENAJE", lobjParams)
                    '  Return lobjSql.ParameterCollection("OU_MSGERR")
                    Return 1
                End With
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function fintActulizarServiciosFacturacionAlmacenajeSA(ByVal oDetalleServicio As Servicio_BE) As Integer
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                    .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                    .Add("IN_CCMPN", oDetalleServicio.CCMPN)
                    .Add("IN_CDVSN", oDetalleServicio.CDVSN)
                    .Add("IN_CPLNDV", oDetalleServicio.CPLNDV)
                    .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)
                    '  .Add("OU_MSGERR", "", ParameterDirection.Output)
                    Dim strMensajeError As String = ""
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_DETALLE_SERVICIOS_FACTURAR_UPDATE_ALMACENAJE", lobjParams)
                    '  Return lobjSql.ParameterCollection("OU_MSGERR")
                    Return 1
                End With
            Catch ex As Exception
                Return 0
            End Try
        End Function

        ''' <summary>
        ''' Lista detalle del Bulto
        ''' </summary>
        ''' <param name="oDetalleServicio"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdtListarDetalleBulto(ByVal oDetalleServicio As Servicio_BE) As DataTable
            Dim oDt As New DataTable
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", oDetalleServicio.CCMPN)
            objParam.Add("PSCDVSN", oDetalleServicio.CDVSN)
            objParam.Add("PNCPLNDV", oDetalleServicio.CPLNDV)
            objParam.Add("PNCCLNT", oDetalleServicio.CCLNT)
            objParam.Add("PSCREFFW", oDetalleServicio.CREFFW)
            objParam.Add("PNNSEQIN", oDetalleServicio.NSEQIN)
            objParam.Add("PSSTIPPR", oDetalleServicio.STIPPR)

            Return lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DETALLE_BULTO_LISTAR", objParam)
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        'FUNCION PARA LISTAR EL REPORTE DE SERVICIOS
        Public Function RptOS_Almacen_RZSC22(ByVal oDetalleServicio As Servicio_BE) As DataTable
            Dim oDt As New DataTable
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            'Try
            objParam.Add("CCLNT", oDetalleServicio.CCLNT)
            objParam.Add("CPLNDV", oDetalleServicio.CPLNDV)
            objParam.Add("NOPRCN", oDetalleServicio.NOPRCN)
            Return lobjSql.ExecuteDataTable("SP_SOLMIN_SA_REPORTE_SERVICIOS", objParam)
            'Catch ex As Exception
            '    Return New DataTable
            'End Try
        End Function

        Public Function fdtListaSolicitudDeServicioSDS(ByRef oServicios As Servicio_BE) As DataTable
            Dim dtTemp As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            ' Ingresamos los parametros del Procedure
            With lobjParams
                .Add("IN_CCLNT", oServicios.CCLNT)
                .Add("IN_NGUICL", oServicios.NGUICL)
                .Add("IN_NORCCL", oServicios.NORCCL)
                .Add("IN_NGUIRN", oServicios.NGUIRN)
                .Add("IN_CSRVC", oServicios.CSRVC)
                .Add("IN_NOPRCN", oServicios.NOPRCN)
            End With
            'Try
            dtTemp = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_CONSULTA_SOLICITUD_SERVICIO", lobjParams)
            'Catch ex As Exception
            '    dtTemp = New DataTable
            'End Try
            Return dtTemp
        End Function

        '==========SERVICIO POR REEMBOLSO==========
        Public Function fstrInsertarDetalleServiciosFactReembolsoSA(ByVal oServReembolso As ServicioReembolso_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams

                .Add("PNCCLNT", oServReembolso.CCLNT)
                .Add("PNNOPRCN", oServReembolso.NOPRCN)
                .Add("PNNCRRDC", oServReembolso.NCRRDC)
                .Add("PSTOBSSR", oServReembolso.TOBSSR)
                If oServReembolso.TPRVD.Trim.Length > 25 Then
                    .Add("PSTPRVD", oServReembolso.TPRVD.Trim.Substring(0, 24))
                Else
                    .Add("PSTPRVD", oServReembolso.TPRVD.Trim)
                End If
                .Add("PNNRUCPR", oServReembolso.NRUCPR)
                .Add("PNTPODOC", oServReembolso.TPODOC)
                .Add("PNNUMDOC", oServReembolso.NUMDOC)
                .Add("PNIMPFAC", oServReembolso.IMPFAC)

                .Add("PNCTRMNC", CDbl(oServReembolso.CTRMNC))
                .Add("PNNGUITR", CDbl(oServReembolso.NGUITR))
                .Add("PNFCHDOC", oServReembolso.FCHDOC)
                .Add("PNITPCMT", oServReembolso.ITPCMT)

                .Add("PSSESTRG", oServReembolso.SESTRG)
                .Add("PSCUSCRT", oServReembolso.PSUSUARIO)

                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_REEMBOLSO_INSERT", lobjParams)


            End With
            'Catch ex As Exception
            '    Return "Error"
            'End Try
            Return ""
        End Function
        Public Function fintActualizarDetalleServiciosFactReembolsoSA(ByVal oServReembolso As ServicioReembolso_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams
                .Add("PNCCLNT", oServReembolso.CCLNT)
                .Add("PNNOPRCN", oServReembolso.NOPRCN)
                .Add("PNNCRRDC", oServReembolso.NCRRDC)
                .Add("PSTOBSSR", oServReembolso.TOBSSR)
                If oServReembolso.TPRVD.Trim.Length > 25 Then
                    .Add("PSTPRVD", oServReembolso.TPRVD.Trim.Substring(0, 24))
                Else
                    .Add("PSTPRVD", oServReembolso.TPRVD.Trim)
                End If
                .Add("PNNRUCPR", oServReembolso.NRUCPR)
                .Add("PNTPODOC", oServReembolso.TPODOC)
                .Add("PNNUMDOC", oServReembolso.NUMDOC)
                .Add("PNIMPFAC", oServReembolso.IMPFAC)
                .Add("PNCTRMNC", CDbl(oServReembolso.CTRMNC))
                .Add("PNNGUITR", CDbl(oServReembolso.NGUITR))
                .Add("PNFCHDOC", oServReembolso.FCHDOC)
                .Add("PNITPCMT", oServReembolso.ITPCMT)
                .Add("PSSESTRG", oServReembolso.SESTRG)
                .Add("PSCUSCRT", oServReembolso.PSUSUARIO)

                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_REEMBOLSO_UPDATE", lobjParams)

                Return ""
            End With
            'Catch ex As Exception
            '    Return "0"
            'End Try
        End Function
        Public Function AnularOperacionReembolsoSA(ByVal oServ As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("PNCCLNT", oServ.CCLNT)
                    .Add("PNNOPRCN", oServ.NOPRCN)
                    .Add("PNNCRROP", oServ.NCRROP)
                    .Add("PSSESTRG", oServ.SESTRG)
                    .Add("PSCUSCRT", oServ.PSUSUARIO)
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_OPERACION_REEMBOLSO_DELETE", lobjParams)
                    Return ""
                End With
            Catch ex As Exception
                Return "0"
            End Try
        End Function
        Public Function AnularOperacionReembolsoSA_ALL(ByVal oServ As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("PNCCLNT", oServ.CCLNT)
                    .Add("PNNOPRCN", oServ.NOPRCN)
                    .Add("PSSESTRG", oServ.SESTRG)
                    .Add("PSCUSCRT", oServ.PSUSUARIO)
                    .Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_OPERACION_REEMBOLSO_DELETE_ALL", lobjParams)
                    Return ""
                End With
            Catch ex As Exception
                Return "0"
            End Try
        End Function

        Public Function AnularOperacionPromediosSA(ByVal oServ As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams
                    .Add("PNCCLNT", oServ.CCLNT)
                    .Add("PNNOPRCN", oServ.NOPRCN)
                    .Add("PSSESTRG", oServ.SESTRG)
                    .Add("PSCUSCRT", oServ.PSUSUARIO)
                    .Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_OPERACION_PROMEDIOS_DELETE", lobjParams)
                    Return ""
                End With
            Catch ex As Exception
                Return "0"
            End Try
        End Function
        Public Function fdtListaDetalleServiciosReembolso(ByVal oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicios.NOPRCN)
            Try
                dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_REEMBOLSO_LIST", lobjParams)
            Catch ex As Exception
                dt = New DataTable
            End Try
            Return dt
        End Function

        '==========ALMACENAJE SEGUN PESOS==========
        Public Function ListarBultosAlmacenaje_RangoFecha(ByVal oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PSCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicios.CPLNDV)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PNFSLFFW", oServicios.FSLFFW)
            lobjParams.Add("PSCTPALM", oServicios.CTPALM)
            lobjParams.Add("PSCALMC", oServicios.CALMC)
            lobjParams.Add("PSCZNALM", oServicios.CZNALM)
            'Try
            'dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_PESOS_LIST", lobjParams)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_PESOS_LIST_01SET", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function


        Public Function ListarBultosAlmacenaje_RangoFecha_MP(ByVal oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PSCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicios.CPLNDV)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PSSSTINV", oServicios.SSTINV)
            lobjParams.Add("PNMEDIOENVIO", oServicios.MEDIOENVIO)
            lobjParams.Add("PNFECNIN", oServicios.FREFFW)
            lobjParams.Add("PNFECFIN", oServicios.FSLFFW)

            'Try
            'dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_PESOS_LIST_MP", lobjParams)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_PESOS_LIST_MP", lobjParams)


            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function


        '==========ALMACENAJE PROMEDIO==========
        Public Function ListarBultosAlmacenaje_Promedio(ByVal oServicios As Servicio_BE) As DataSet
            Dim dts As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PSCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicios.CPLNDV)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PNFECINI", oServicios.FREFFW)
            lobjParams.Add("PNFECFIN", oServicios.FSLFFW)
            lobjParams.Add("PNDIAS", oServicios.TOTALDIAS)

            lobjParams.Add("PSCTPALM", oServicios.CTPALM)
            lobjParams.Add("PSCALMC", oServicios.CALMC)
            lobjParams.Add("PSCZNALM", oServicios.CZNALM)
            'Try
            dts = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_ALMACENAJE_PROMEDIO_Q01", lobjParams)
            'Catch ex As Exception
            '    dts = New DataSet
            'End Try
            Return dts
        End Function

        Public Function ListarBultosAlmacenaje_Promedio_RZSC25(ByVal oServicios As Servicio_BE) As DataSet
            Dim dts As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicios.NOPRCN)
            'Try
            dts = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_ALMACENAJE_PROMEDIO_RZSC25", lobjParams)
            'Catch ex As Exception
            '    dts = New DataSet
            'End Try
            Return dts
        End Function

#End Region

#Region "CONSISTENCIAR"

        Public Function intTieneProvision(ByVal poServiciosAtendidos As Servicio_BE) As Integer
            Try
                Dim lobjSql As New SqlManager
                Dim lobjParams As New Parameter

                lobjParams.Add("PSCCMPN", poServiciosAtendidos.CCMPN)
                lobjParams.Add("PNNOPRCN", poServiciosAtendidos.NOPRCN)
                lobjParams.Add("PNNSECFC", poServiciosAtendidos.NSECFC)
                lobjParams.Add("PSTIPO", poServiciosAtendidos.TIPO_REV)
                lobjParams.Add("PNPROVISION", 0, ParameterDirection.InputOutput)
                lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_VERIFICA_EXISTENCIA_PROVISION", lobjParams)
                Return lobjParams.Item(5).Value
            Catch ex As Exception
                Return 0
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ActualizarServicio_Atendido(ByVal poServiciosAtendidos As Servicio_BE) As Integer
            'Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", poServiciosAtendidos.CCMPN)
            lobjParams.Add("PSCDVSN", poServiciosAtendidos.CDVSN)
            lobjParams.Add("PNCPLNDV", poServiciosAtendidos.CPLNDV)
            lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)
            lobjParams.Add("PNNOPRCN", poServiciosAtendidos.NOPRCN)
            lobjParams.Add("PNNSECFC", poServiciosAtendidos.NSECFC)
            lobjParams.Add("PNNSECFC_UPD", poServiciosAtendidos.NSECFC_UPD)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PSTIPO", poServiciosAtendidos.TIPO_REV)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ACTUALIZAR_SERVICIO_ATENDIDO_RZSC19", lobjParams)

            'Catch ex As Exception
            '    Return 0
            '    Throw New Exception(ex.Message)
            'End Try
            Return 1
        End Function


        Public Function GenerarConsistenciaMasivo(ByVal poServiciosAtendidos As Servicio_BE) As Decimal

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            Dim retorno As Integer = 0
            Dim nroConsistencia As Decimal = 0

            lobjParams.Add("PSCCMPN", poServiciosAtendidos.CCMPN)
            lobjParams.Add("PSCDVSN", poServiciosAtendidos.CDVSN)
            lobjParams.Add("PNCCLNT", poServiciosAtendidos.CCLNT)            
            lobjParams.Add("PSLISTJSON", poServiciosAtendidos.LISTJSON)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", ConfigurationWizard.NombreMaquina)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_GENERAR_CONSISTENCIA_RZSC19", lobjParams)
            If dt.Rows.Count > 0 Then
                nroConsistencia = dt.Rows(0)("NSECFC")
            End If

            retorno = 1
            Return nroConsistencia
        End Function


        Public Function ObtenerCodigoConsistencia() As DataTable
            Dim lobjSql As New SqlManager
            'Try
            Return lobjSql.ExecuteDataTable("SP_SOLCT_OBTENER_CODIGO_CONSISTENCIA", Nothing)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function
#End Region

        Public Function Lista_Tipo_Cambio(ByVal oLis As List(Of String)) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCMNDA1", oLis.Item(0))
            lobjParams.Add("PNFCMBO", oLis.Item(1))
            dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_CAMBIO", lobjParams)
            Return dt
        End Function

        Public Function Lista_Servicios_Activos(ByRef oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PSCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_VIGENTES", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function

        Public Function fdtListaServicioPermanencia(ByRef oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNFINGAL", oServicios.FINGAL)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PNCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicios.CPLNDV)

            lobjParams.Add("PSTTPOMR", oServicios.TTPOMR)
            lobjParams.Add("PSCTPALM", oServicios.CTPALM)
            lobjParams.Add("PSCALMC", oServicios.CALMC)
            lobjParams.Add("PSCZNALM", oServicios.CZNALM)

            'Try
            'dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIO_PERMANENCIA_LIST", lobjParams)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIO_PERMANENCIA_LIST_Q01", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt

        End Function
        Public Function fdtListaServicioPermanenciaMod(ByRef oServicios As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNFINGAL", oServicios.FINGAL)
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PSCCMPN", oServicios.CCMPN)
            lobjParams.Add("PNCDVSN", oServicios.CDVSN)
            lobjParams.Add("PNCPLNDV", oServicios.CPLNDV)

            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIO_PERMANENCIA_LIST", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt

        End Function
        Public Function EliminarServiciosFacturacionAlmacenaje(ByRef oServicios As Servicio_BE) As Integer

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicios.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicios.NOPRCN)
            lobjParams.Add("PNNCRROP", oServicios.NCRROP)
            lobjParams.Add("PSUSUARIO", oServicios.PSUSUARIO)
            lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            Try
                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_ALMACENAJE_FACTURAR_DELETE", lobjParams)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(ByVal oDetalleServicio As Servicio_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            With lobjParams
                .Add("IN_CCLNT", oDetalleServicio.CCLNT)
                .Add("IN_NOPRCN", oDetalleServicio.NOPRCN)
                .Add("IN_CCMPN", oDetalleServicio.CCMPN)
                .Add("IN_CREFFW", oDetalleServicio.CREFFW)
                .Add("IN_QPRDFC", oDetalleServicio.QPRDFC)
                .Add("IN_TOTALDIAS", oDetalleServicio.TOTALDIAS)

                .Add("PSCTPALM", oDetalleServicio.CTPALM)
                .Add("PSCALMC", oDetalleServicio.CALMC)
                .Add("PSCZNALM", oDetalleServicio.CZNALM)

                .Add("IN_USUARI", oDetalleServicio.PSUSUARIO)

                .Add("IN_NCRROP", oDetalleServicio.NCRROP)
                .Add("IN_NSEQIN", oDetalleServicio.NSEQIN)


                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_DETALLE_SERVICIOS_FACTURAR_PERMANENCIA_INSERT_V2", lobjParams)
                'lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_DETALLE_SERVICIOS_FACTURAR_PERMANENCIA_INSERT", lobjParams)
                Return ""
            End With
            'Catch ex As Exception
            '    Return "Error"
            'End Try
        End Function
        Public Function fstrEliminaServicioOperacionSA_SDS_Permanencia(ByVal oServicios As Servicio_BE) As String
            Dim lobjSql As New SqlManager
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", oServicios.CCLNT)
                objParam.Add("PNNOPRCN", oServicios.NOPRCN)
                objParam.Add("PNNCRROP", oServicios.NCRROP)
                objParam.Add("PNFOPRCN", oServicios.FOPRCN)
                objParam.Add("PNCCLNFC", oServicios.CCLNFC)
                objParam.Add("PNNRTFSV", oServicios.NRTFSV)
                objParam.Add("PSCCMPN", oServicios.CCMPN)
                objParam.Add("PSCDVSN", oServicios.CDVSN)
                objParam.Add("PNQATNAN", oServicios.QATNAN)
                objParam.Add("PSSTIPPR", oServicios.STIPPR)
                objParam.Add("PSFLGFAC", oServicios.FLGFAC)
                objParam.Add("PSSESTRG", oServicios.SESTRG)
                objParam.Add("PSUSUARIO", oServicios.PSUSUARIO)
                objParam.Add("PNFINPRF", oServicios.FINPRF)
                objParam.Add("PNFFNPRF", oServicios.FFNPRF)
                objParam.Add("MSGERR", "", ParameterDirection.Output)
                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_OPERACION_SERVICIO_DELETE", objParam)

                Return 1
            Catch ex As Exception

                Return 0
            End Try
        End Function
        Public Function ObtieneCodigoProveedor(ByVal strRUC As String) As String
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNRUCPR", strRUC)
            Try
                dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OBTIENE_PROVEEDOR", lobjParams)
            Catch ex As Exception
                dt = New DataTable
            End Try
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        End Function
        Public Function ObtieneRUCTransportista(ByVal strCodigo As String) As String
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCTRSPT", strCodigo)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OBTIENE_RUC_TRANSPORTISTA", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        End Function

        Public Function ListarLotes(ByVal intCliente As Integer) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", intCliente)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REEMBOLSO_LOTES", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function
        Public Function ListarLotesManipuleo(ByVal intCliente As Integer) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", intCliente)
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REEMBOLSO_LOTES", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function
        Public Function ListarSentidoCargaManipuleo() As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_MANIPULEO_SENTIDO_CARGA", Nothing) 'lobjParams
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function


        Public Function Listar_TipoMaterial() As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSCODVAR", "TIPMAT")
                lobjParams.Add("PSTTPOMR", "")
                dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)
            Catch ex As Exception
                dt = New DataTable
            End Try
            Return dt
        End Function


        Public Function Listar_TipoAlmacen(ByVal intCliente As Integer) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", intCliente)
            lobjParams.Add("PSSESTRG", "*")
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIST_TIP_ALM_RZIK01", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function
        Public Function Listar_TipoDeAlmacen() As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TIPO_ALMACEN", Nothing)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function


        Public Function Listar_Almacenes(ByVal oServ As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", oServ.CCLNT)
            lobjParams.Add("PSCTPALM", oServ.CTPALM)
            lobjParams.Add("PSSESTRG", "*")
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIST_ALMA_RZIM01", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function
        Public Function Listar_Zonas(ByVal oServ As Servicio_BE) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCCLNT", oServ.CCLNT)
            lobjParams.Add("PSCTPALM", oServ.CTPALM)
            lobjParams.Add("PSCALMC", oServ.CALMC)
            lobjParams.Add("PSSESTRG", "*")
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIST_ZONA_RZIM02", lobjParams)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function
        Public Function Importa_CI_CargoPlan(ByVal oServ As Servicio_BE) As DataSet
            Dim ds As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            'Try
            lobjParams.Add("PNCTRMNC", oServ.CTRMNC)
            lobjParams.Add("PNNGUITR", oServ.NGUITR)
            ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_CARGO_PLAN_CI_Q01", lobjParams)
            'Catch ex As Exception
            '    ds = New DataSet
            'End Try
            Return ds
        End Function

        Public Function fdtListaMedioEnvio() As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager


            'Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTAR_MEDIO_TRANSPORTE", Nothing)
            'Catch ex As Exception
            '    dt = New DataTable
            'End Try
            Return dt
        End Function

        Public Function Lista_CentroCosto(ByVal sCompania As String) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", sCompania)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CENTRO_COSTO", lobjParams)
            Return dt
        End Function

        Public Function DetalleFactura(ByVal oServicio As Servicio_BE) As DataTable
            Dim oDt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjSql.TimeOutCommand = 1000000
            lobjParams.Add("PSNSECFC", oServicio.NSECFC)
            lobjParams.Add("PSCTPALJ", oServicio.CTPALJ)
            lobjParams.Add("PSFLGFAC", oServicio.FLGFAC)
            lobjParams.Add("PSSTPODP", oServicio.STPODP)

            oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_POR_REVISION_FIN_1", lobjParams)

            Return oDt
        End Function


        Public Function fstrValidaDocumentoReembolosSA(ByVal oServReembolso As ServicioReembolso_BE) As String
            Dim blnResultado As Boolean = True
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                With lobjParams

                    .Add("PNCCLNT", oServReembolso.CCLNT)
                    .Add("PNNOPRCN", oServReembolso.NOPRCN)
                    .Add("PNNCRRDC", oServReembolso.NCRRDC)


                    .Add("PNNRUCPR", oServReembolso.NRUCPR)
                    .Add("PNTPODOC", oServReembolso.TPODOC)
                    .Add("PNNUMDOC", oServReembolso.NUMDOC)

                    .Add("PSFLGTIPO", oServReembolso.FLGTIPO)

                    .Add("OU_MSGERR", "", ParameterDirection.Output)

                    lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_REEMBOLSO_VALIDA_DOCUMENTO", lobjParams)
                    Return lobjSql.ParameterCollection("OU_MSGERR").ToString.Replace("%", Chr(10))

                End With
            Catch ex As Exception
                Return "Error"
            End Try
            Return ""
        End Function

        Public Function Cargar_Servicios(ByVal oServ As Servicio_BE) As DataTable
            Dim oDt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNCCLNT", oServ.CCLNT)
            lobjParams.Add("PNNOPRCN", oServ.NOPRCN)
            oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_FACTURAR_Q01", lobjParams)
            Return oDt
        End Function
        Public Function Cargar_Bultos(ByVal oServ As Servicio_BE) As DataTable
            Dim oDt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNCCLNT", oServ.CCLNT)
            lobjParams.Add("PNNOPRCN", oServ.NOPRCN)
            lobjParams.Add("PNCPLNDV", oServ.CPLNDV)
            oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_BULTOS_FACTURAR_Q02", lobjParams)
            Return oDt
        End Function


        Public Function fintActualizaClienteFacturarPorRevision(ByVal oServicios As Servicio_BE) As Integer
            Dim lobjSql As New SqlManager
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNSECFC", oServicios.NSECFC)
                objParam.Add("PNCCLNFC", oServicios.CCLNFC)

                lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZA_CLIENTE_FAC_POR_REVISION", objParam)

                Return 1
            Catch ex As Exception

                Return 0
            End Try
        End Function


#Region "Datos de Clientes SOLMIN"

        Public Function ListaClienteSolmin(ByVal pobjCliente As Servicio_BE) As DataTable
            Dim dt As DataTable = Nothing
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            'Try
            lobjParams.Add("PNCCLNT", pobjCliente.CCLNT)
            lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
            lobjParams.Add("PNNRCTCL", pobjCliente.NRCTCL)
            lobjParams.Add("PSLIST_CRGVTA", pobjCliente.CRGVTA)
            'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_CLIENTE_SOMIN", lobjParams)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_CLIENTE_SOMIN_V1", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

            Return dt
        End Function

        Public Function ListarRegionVenta(ByVal pobjCliente As Servicio_BE) As DataTable
            Dim dt As DataTable = Nothing
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            'Try
            lobjParams.Add("PSMMCUSR", pobjCliente.PSUSUARIO)
            lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
            lobjParams.Add("PSCDVSN", pobjCliente.CDVSN)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REGION_VENTA_X_USUARIO", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

            Return dt
        End Function

        Public Function fdtGetInfLocked(ByVal Cliente As String, ByVal FnVerificacion As String, ByVal RefServ As String, _
                                     ByVal NroOpe As String, ByRef sPARAM_SFLGB1 As String, ByRef sPARAM_SFLGB2 As String, _
                                     ByRef sPARAM_MSGBLQ As String, ByVal strCompania As String, _
                                     ByVal strDivision As String, ByVal strReg As String) As Boolean

            Dim strTipoOper As String = "DM"  ' Tipo de Operación
            Dim bResultado As Boolean = True
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)


            Cliente = Right("000000" & Cliente, 6)
            ' Ingresamos los parametros del Procedure

            objParametros.Add("PARAM_CCMPN", strCompania)
            objParametros.Add("PARAM_CDVSN", strDivision)
            objParametros.Add("PARAM_CRGVTA", strReg)
            objParametros.Add("PARAM_CCLNT", Cliente)
            objParametros.Add("PARAM_TPOOPE", strTipoOper)
            objParametros.Add("PARAM_TFNCVR", FnVerificacion)
            objParametros.Add("PARAM_REFSRV", RefServ)
            objParametros.Add("PARAM_NROOPE", NroOpe)
            objParametros.Add("PARAM_SFLGB1", "", ParameterDirection.Output)
            objParametros.Add("PARAM_SFLGB2", "", ParameterDirection.Output)
            objParametros.Add("PARAM_MSGBLQ", "", ParameterDirection.Output)
            Try

                objSqlManager.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RCC575", objParametros)
                Dim htResultado As Hashtable
                htResultado = objSqlManager.ParameterCollection
                sPARAM_SFLGB1 = ("" & htResultado("PARAM_SFLGB1")).ToString.Trim
                sPARAM_SFLGB2 = ("" & htResultado("PARAM_SFLGB2")).ToString.Trim
                sPARAM_MSGBLQ = ("" & htResultado("PARAM_MSGBLQ")).ToString.Trim
            Catch ex As Exception
                sPARAM_SFLGB1 = ""
                sPARAM_SFLGB2 = ""
                sPARAM_MSGBLQ = ""
                bResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return bResultado
        End Function

#End Region


        Public Function fdtListaOperaciones(ByVal oServicio As Servicio_BE) As DataTable
            'Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)
            lobjParams.Add("PSFLGPEN", oServicio.FLGPEN)
            lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicio.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicio.FECSERV_FIN)
            lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_LISTA_OPERACION_SERVICIO", lobjParams)

            Return dt
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function Lista_Detalle_Servicios_Por_Revision(ByVal oServicio As Servicio_BE) As DataSet
            'Try
            Dim ds As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNNSECFC_LISTA", oServicio.NROS_REVISION)
            ds = lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_DATOS_RPT_CONSISTENCIA_OPERACION_ALMACEN_REVISION_XD_1", lobjParams)
            Return ds
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function fdsReporteDeOperacionesResumido(ByVal oServicio As Servicio_BE) As DataSet
            'Try
            Dim ds As DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)
            lobjParams.Add("PSFLGPEN", oServicio.FLGPEN)
            lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicio.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicio.FECSERV_FIN)
            lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
            ds = lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_REPORTE_OPERACION_SERVICIO_MODELO1", lobjParams)
            Return ds
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function

        Public Function fdsReporteDeOperacionesDetallado(ByVal oServicio As Servicio_BE) As DataSet
            'Try

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)
            lobjParams.Add("PSFLGPEN", oServicio.FLGPEN)
            lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicio.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicio.FECSERV_FIN)
            lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
            Return lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_CT_REPORTE_OPERACION_SERVICIO_MODELO2", lobjParams)

            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try
        End Function
        Public Function ListaTarifaClienteSolmin(ByVal pobjCliente As Servicio_BE) As DataTable
            Dim dt As DataTable = Nothing
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            'Try
            lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_CLIENTE_SOMIN", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            'End Try

            Return dt
        End Function


        ''' <summary>
        ''' Lista de usuarios permitidos para revertir la provision
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdtUsuarioPermitidoRevertirProvision(ByVal strUsuario As String) As DataTable
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            'Try
            lobjParams.Add("PSCCMPRN", strUsuario)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_USUARIO_PROVISION", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            '    Return New DataTable
            'End Try
            Return dt
        End Function

        Public Function Validar_Direccion_Servicio(ByVal compania As String, ByVal division As String, ByVal listaoperaciones As String, ByVal listaconsistencias As String) As DataTable

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As DataTable
            'Try

            lobjParams.Add("PARAM_CCMPN", compania)
            lobjParams.Add("PARAM_CDVSN", division)
            lobjParams.Add("PARAM_NOPRCN", listaoperaciones)
            lobjParams.Add("PARAM_NSECFC", listaconsistencias)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDA_OPERACIONES_FACTURA_SERV", lobjParams)

            'Catch ex As Exception
            '    dt = Nothing
            'End Try
            Return dt

        End Function

        Public Function Validar_Dirección_Servicio(ByVal CCMPN As String) As DataTable 'ECM-HUNDRED-SOPORTE[180716]
            Dim datatable As New DataTable

            Dim sqlManager As New SqlManager
            Dim parametro As New Parameter

            parametro.Add("PARAM_CCMPN", CCMPN)
            datatable = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_DATOS_VALIDACION_COMPANIA_DIRSERVICIO", parametro)

            Return datatable
        End Function

        Public Function fdtListaDirServicxDefecto(ByVal PSCCMPN As String, _
                                               ByVal PSCDVSN As String, _
                                               ByVal PNCCLNTOP As Decimal, _
                                               ByVal PNCCLNTFC As Decimal, _
                                               ByVal PNCPLNDVOP As Decimal, _
                                               ByVal PNCPLNDVFC As Decimal) As DataTable
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            'Try
            lobjParams.Add("PSCCMPN", PSCCMPN)
            lobjParams.Add("PSCDVSN", PSCDVSN)
            lobjParams.Add("PNCCLNTOP", PNCCLNTOP)
            lobjParams.Add("PNCCLNTFC", PNCCLNTFC)
            lobjParams.Add("PNCPLNDVOP", PNCPLNDVOP)
            lobjParams.Add("PNCPLNDVFC", PNCPLNDVFC)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DIRECCION_SERVICIO_X_DEFECTO", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            '    Return New DataTable
            'End Try
            Return dt
        End Function



        Public Function ListarTipoDocAprobacionCliente() As DataTable
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DOC_APROBACION_CLIENTE", lobjParams)
            Return dt
        End Function

        Public Function AsignarDocumentoAprobacionCliente(CCMPN As String, CCLNT As Decimal, strConsistencia As String, TIPODOC As String, DCCLNT As String, SBCLNT As String, CULUSA As String, NTRMNL As String) As String
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PNCCLNT", CCLNT)
            objParam.Add("PSCONSISTENCIA", strConsistencia)
            objParam.Add("PSTIPODOC", TIPODOC)
            objParam.Add("PSDCCLNT", DCCLNT)
            objParam.Add("PSSBCLNT", SBCLNT)
            objParam.Add("PSCULUSA", CULUSA)
            objParam.Add("PSNTRMNL", NTRMNL)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ACTUALIZAR_DOC_SUBDOC_CLIENTE", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
                End If
            Next
            msg = msg.Trim
            Return msg
        End Function
        Public Sub QuitarDocumentoAprobacionCliente(CCMPN As String, CCLNT As Decimal, strConsistencia As String, CULUSA As String, NTRMNL As String)
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PNCCLNT", CCLNT)
            objParam.Add("PSCONSISTENCIA", strConsistencia)
            objParam.Add("PSCULUSA", CULUSA)
            objParam.Add("PSNTRMNL", NTRMNL)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_QUITAR_DOC_SUBDOC_CLIENTE", objParam)

        End Sub

        Public Function ValidarAccesoModificarOpValorizada(CCMPN As String, CULUSA As String) As Boolean
            Dim lobjSql As New SqlManager
            Dim conAcceso As Boolean = False
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCULUSA", CULUSA)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_ACCESO_MODIFICAR_OPERACION_VALORIZADA", objParam)
            If dt.Rows.Count > 0 Then
                conAcceso = True
            Else
                conAcceso = False
            End If
            Return conAcceso
        End Function

        Public Function ListarValorizacionOperacion(CCMPN As String, CDVSN As String, CCLNT As Decimal, strOperaciones As String, strConsistencia As String) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCDVSN", CDVSN)
            objParam.Add("PNCCLNT", CCLNT)
            objParam.Add("PSNOPRCN", strOperaciones)
            objParam.Add("PSNSECFC", strConsistencia)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_OPERACION_VALORIZACION", objParam)
            Return dt
        End Function



        Public Function fdtListaOpListadoServicios(ByVal oServicio As Servicio_BE) As DataTable
            'Try
            Dim dt As DataTable
            Dim dtEmbarques As New DataTable
            Dim ds As New DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio.CCMPN)
            lobjParams.Add("PSCDVSN", oServicio.CDVSN)
            lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
            lobjParams.Add("PNCCLNT", oServicio.CCLNT)
            lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
            lobjParams.Add("PNFECINI", oServicio.FECINI)
            lobjParams.Add("PNFECFIN", oServicio.FECFIN)
            lobjParams.Add("PSFLGPEN", oServicio.FLGPEN)
            lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
            lobjParams.Add("PNFECSERV_INI", oServicio.FECSERV_INI)
            lobjParams.Add("PNFECSERV_FIN", oServicio.FECSERV_FIN)



            lobjParams.Add("PNFECREV_INI", oServicio.FECREV_INI)
            lobjParams.Add("PNFECREV_FIN", oServicio.FECREV_FIN)


            lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)


            lobjParams.Add("PNNSECFC", oServicio.NSECFC)

            lobjParams.Add("PSTIPORECCARGA", oServicio.ESRECCARGA)


            ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_OPERACION_LISTADO_SERVICIOS", lobjParams)


            dt = ds.Tables(0).Copy
            dtEmbarques = ds.Tables(1).Copy
 
            dt.Columns.Add("MES_PROV")
            dt.Columns.Add("FECHA_PROV")

            dt.Columns.Add("IMPORTE_OP_S")
            dt.Columns.Add("IMPORTE_OP_D")
            dt.Columns.Add("NROEMB")
            dt.Columns.Add("NDOCEM")


            Dim dtmeses As New DataTable
            Dim nroEmb As String = ""
            Dim DocEmb As String = ""
            dtmeses = Ransa.Utilitario.HelpClass.Meses(Today.Year)
            For Each item As DataRow In dt.Rows
                item("FSECFC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FSECFC"))
                item("FOPRCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FOPRCN"))
                item("FATNSR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FATNSR"))
                item("FDCFCC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FDCFCC"))


                item("FECHA_ACT") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FECHA_ACT"))
                item("F_ENVIO") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("F_ENVIO"))
                item("F_APROBACION") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("F_APROBACION"))
            

                item("MES_PROV") = FormatMesprovision(item("ANOMES"), dtmeses)
                item("FECHA_PROV") = FormatFechaprovision(item("FCHPRV"), dtmeses)
                item("IMPORTE_OP_S") = dt.Compute("SUM(IMPORTE_S)", "NOPRCN='" & item("NOPRCN") & "'")
                item("IMPORTE_OP_D") = dt.Compute("SUM(IMPORTE_D)", "NOPRCN='" & item("NOPRCN") & "'")

                nroEmb = ""
                DocEmb = ""
                GetDatosEmbarque(dtEmbarques, item("NOPRCN"), nroEmb, DocEmb)
                item("NROEMB") = nroEmb
                item("NDOCEM") = DocEmb
                
            Next



 
            Return dt
         
        End Function

        Private Sub GetDatosEmbarque(dt As DataTable, Nop As String, ByRef nroEmb As String, ByRef DocEmb As String)
            Dim dtResumen As DataTable
            Dim dtResEmb As DataTable
            Dim dtResDoc As DataTable
            Dim drlist() As DataRow

            nroEmb = ""
            DocEmb = ""
            drlist = dt.Select("NOPRCN='" & Nop & "'")
            If drlist.Length > 0 Then
                dtResumen = drlist.CopyToDataTable
                dtResEmb = dtResumen.DefaultView.ToTable(True, "NORSCI")
                dtResDoc = dtResumen.DefaultView.ToTable(True, "NDOCEM")
                nroEmb = GetResumen(dtResEmb, "NORSCI")
                DocEmb = GetResumen(dtResDoc, "NDOCEM")
            End If
            'dtResumen = dt.Select("NOPRCN='" & Nop & "'").CopyToDataTable
          
        End Sub
        Private Function GetResumen(dt As DataTable, columna As String) As String
            Dim strresult As String = ""
            For Each item As DataRow In dt.Rows
                strresult = strresult & item(columna) & ","
            Next
            If strresult.Length > 0 Then
                strresult = strresult.Substring(0, strresult.Length - 1)
            End If
            Return strresult
        End Function

 
        Private Function FormatMesprovision(anioMes As String, dtMeses As DataTable) As String
            Dim format As String = ""
            Dim mes As String = ""
            Dim dr() As DataRow
            If anioMes.Length >= 6 Then
                format = anioMes.Substring(0, 4)
                mes = anioMes.Substring(4, 2).PadLeft(2, "0")
                dr = dtMeses.Select("key='" & mes & "'")
                If dr.Length > 0 Then
                    format = format & "-" & dr(0)("value2").ToString.ToUpper
                End If
            End If
            Return format
        End Function

        Private Function FormatFechaprovision(fecha As String, dtMeses As DataTable) As String
            Dim format As String = ""
            Dim mes As String = ""
            Dim dr() As DataRow
            If fecha.Length >= 8 Then
                mes = fecha.Substring(4, 2).PadLeft(2, "0")
                dr = dtMeses.Select("key='" & mes & "'")
                If dr.Length > 0 Then
                    format = dr(0)("value2").ToString.ToUpper & "-" & fecha.Substring(6, 2)
                End If
            End If
            Return format
        End Function


        Public Sub validar_anulacion_consistencia(ByVal poServiciosAtendidos As Servicio_BE, ByRef estado As String, ByRef msgvalidacion As String)

            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PARAM_CCMPN", poServiciosAtendidos.CCMPN)
            lobjParams.Add("PARAM_CDVSN", poServiciosAtendidos.CDVSN)
            lobjParams.Add("PARAM_CCLNT", poServiciosAtendidos.CCLNT)
            lobjParams.Add("PARAM_LIST", poServiciosAtendidos.LISTJSON)
            lobjParams.Add("PARAM_USUARIO", ConfigurationWizard.UserName)
            Dim dt As New DataTable
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_ANULACION_CONSISTENCIA", lobjParams)

            Dim msgAlerta As String = ""
            Dim msgError As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "A" Then
                    msgAlerta = msgAlerta & item("OBSRESULT").ToString.Trim() & Chr(13)
                End If
                If item("STATUS") = "E" Then
                    msgError = msgError & item("OBSRESULT").ToString.Trim() & Chr(13)
                End If
            Next
            msgAlerta = msgAlerta.Trim
            msgError = msgError.Trim
            estado = "A"
            msgvalidacion = (msgAlerta & Chr(13) & msgError).Trim
            If msgError.Length > 0 Then
                estado = "E"
            End If
        End Sub



    End Class
End Namespace


