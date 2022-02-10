'/*------------------------------------------------------------------------------*/
'/*----- Empresa          	: RANSA S.A.                                    -----*/
'/*----- Sistema          	: Solmin                  	                    -----*/
'/*----- Módulo          	: SD-SA-SC                  	     	        -----*/
'/*----- Nombre Programa    : UcServicioAtendido			                -----*/
'/*----- Desarrollado por	: Alann Crispin	                                -----*/
'/*----- Fecha Creación     : 23/05/2011                      	            -----*/
'/*----- Descripción        : Consistencia de SIL y ALMACEN               	-----*/
'/*-----                      servicios por operación                     	-----*/
'/*------------------------------------------------------------------------------*/ 
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsConsistencia_DAL
    Public Function Lista_Reporte_SIL(ByVal pobjServicioSIL As Servicio_BE) As DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As New DataTable

        'lobjParams.Add("PSCCLNT", pobjServicioSIL.CCLNT)
        'lobjParams.Add("PNNSECFC", pobjServicioSIL.NSECFC)
        'lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)

        lobjParams.Add("PNCCLNT", pobjServicioSIL.CCLNT)
        lobjParams.Add("PSCCMPN", pobjServicioSIL.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicioSIL.CDVSN)
        'lobjParams.Add("PNCPLNDV", pobjServicioSIL.CPLNDV)
        lobjParams.Add("PNTIPO_PLANTA", pobjServicioSIL.TIPO_PLANTA)
        lobjParams.Add("PNNSECFC", pobjServicioSIL.NSECFC)
        lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)
        lobjParams.Add("PSFLGPEN", pobjServicioSIL.FLGPEN)

        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_RPT_CONSISTENCIA_OPERACION_SIL", lobjParams)
        Return oDt
       
    End Function
    Public Function Lista_Reporte_Almacen(ByVal pobjServicioSIL As Servicio_BE) As DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As New DataTable

        lobjParams.Add("PNCCLNT", pobjServicioSIL.CCLNT)
        lobjParams.Add("PSCCMPN", pobjServicioSIL.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicioSIL.CDVSN)
        'lobjParams.Add("PNCPLNDV", pobjServicioSIL.CPLNDV)
        lobjParams.Add("PNTIPO_PLANTA", pobjServicioSIL.TIPO_PLANTA)
        lobjParams.Add("PNNSECFC", pobjServicioSIL.NSECFC)
        lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)

        lobjParams.Add("PNFECINI", pobjServicioSIL.FECINI)
        lobjParams.Add("PNFECFIN", pobjServicioSIL.FECFIN)


        lobjParams.Add("PSFLGPEN", pobjServicioSIL.FLGPEN)
        lobjParams.Add("PSFLGFAC", pobjServicioSIL.FLGFAC)

        lobjParams.Add("PSSTPODP", pobjServicioSIL.STPODP)
        lobjParams.Add("PSCTPALJ", pobjServicioSIL.CTPALJ)
        lobjParams.Add("PSTIPO", pobjServicioSIL.TIPO)

        oDt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DATOS_RPT_CONSISTENCIA_OPERACION_ALMACEN_FIN_XD", lobjParams)
        If pobjServicioSIL.FLGPEN <> "N" Then
            oDt.Columns.Remove("QATNRL")
        End If

        Return oDt
       
    End Function
    Public Function Lista_Detalle_Servicios_Almacen_All(ByVal pobjServicioSIL As Servicio_BE) As DataSet

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDs As New DataSet

        lobjParams.Add("PNCCLNT", pobjServicioSIL.CCLNT)
        lobjParams.Add("PSCCMPN", pobjServicioSIL.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicioSIL.CDVSN)
        'lobjParams.Add("PNCPLNDV", pobjServicioSIL.CPLNDV)
        lobjParams.Add("PNTIPO_PLANTA", pobjServicioSIL.TIPO_PLANTA)
        lobjParams.Add("PNNSECFC", pobjServicioSIL.NSECFC)
        lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)

        lobjParams.Add("PNFECINI", pobjServicioSIL.FECINI)
        lobjParams.Add("PNFECFIN", pobjServicioSIL.FECFIN)


        lobjParams.Add("PSFLGPEN", pobjServicioSIL.FLGPEN)
        lobjParams.Add("PSFLGFAC", pobjServicioSIL.FLGFAC)

        lobjParams.Add("PSSTPODP", pobjServicioSIL.STPODP)
        lobjParams.Add("PSCTPALJ", pobjServicioSIL.CTPALJ)
        lobjParams.Add("PSTIPO", pobjServicioSIL.TIPO)

        oDs = lobjSql.ExecuteDataSet("SP_SOLCT_LISTA_DATOS_RPT_CONSISTENCIA_OPERACION_ALMACEN_FIN_XD", lobjParams)
        For Each dtt As DataTable In oDs.Tables
            If pobjServicioSIL.FLGPEN <> "N" Then
                dtt.Columns.Remove("QATNRL")
            End If
        Next


        Return oDs
      
    End Function
    Public Function Obtener_Tipo_Cambio(ByVal pobjServicioSIL As Servicio_BE) As Double

        Dim cambio As Double = 0D
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNTIPCAM", 1, ParameterDirection.Output)
        lobjParams.Add("PNFULTAC", pobjServicioSIL.FULTAC)
        lobjParams.Add("PNCMNDA1", pobjServicioSIL.CMNDA1)
        lobjSql.ExecuteNoQuery("SP_SOLMIN_ST_TIPO_CAMBIO", lobjParams)
        cambio = lobjSql.ParameterCollection("PNTIPCAM")
        Return cambio
      
    End Function
    Public Function Obtener_igv_actual(ByVal pobjServicioSIL As Servicio_BE) As Double

        Dim igv As Double = 0D
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As New DataTable
        lobjParams.Add("PNFULTAC", pobjServicioSIL.FULTAC)
        oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OBTIENE_IGV", lobjParams)
        If oDt.Rows.Count > 0 Then
            igv = oDt.Rows(0).Item("PIGVA")
        Else : igv = 0
        End If
        Return igv
     
    End Function
End Class
