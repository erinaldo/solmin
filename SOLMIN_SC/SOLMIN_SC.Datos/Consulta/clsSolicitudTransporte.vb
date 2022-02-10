Imports SOLMIN_SC.Entidad
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class clsSolicitudTransporte

    Public Function Obtener_Lista_Solicitud_Transporte(ByVal PNNORSCI As Decimal) As List(Of beSolicitudTransporte)
        Dim objDataTable As New DataTable
        Dim obeSolictudTransporte As beSolicitudTransporte
        Dim oListSolictudTransporte As New List(Of beSolicitudTransporte)
        Dim objParam As New Parameter
        Dim lobjSql As New SqlManager
        objParam.Add("PNNORSCI", PNNORSCI)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_SOLICITUD_TRANSPORTE_X_EMBARQUE", objParam)
        For Each Item As DataRow In objDataTable.Rows
            obeSolictudTransporte = New beSolicitudTransporte
            obeSolictudTransporte.PNNORSRT = Item("NORSRT")
            obeSolictudTransporte.PNNCSOTR = Item("NCSOTR")
            obeSolictudTransporte.PSFECOST = HelpClass.FechaNum_a_Fecha(Item("FECOST"))
            obeSolictudTransporte.PNCCLNT = Item("CCLNT")
            obeSolictudTransporte.PNNORSRT = Item("NORSRT")
            obeSolictudTransporte.PSTCMCRA = HelpClass.ToStringCvr(Item("TCMCRA"))
            obeSolictudTransporte.PSTCMTPS = HelpClass.ToStringCvr(Item("TCMTPS"))
            obeSolictudTransporte.PSTCMPUN = HelpClass.ToStringCvr(Item("TCMPUN"))
            obeSolictudTransporte.PSTCMRCD = HelpClass.ToStringCvr(Item("TCMRCD"))
            obeSolictudTransporte.PSTIPO_SOLICITUD = HelpClass.ToStringCvr(Item("TIPO_SOLICITUD"))
            obeSolictudTransporte.PSTNMMDT = HelpClass.ToStringCvr(Item("TNMMDT"))
            obeSolictudTransporte.PSTCMLCL_ORIGEN = HelpClass.ToStringCvr(Item("TCMLCL_ORIGEN"))
            obeSolictudTransporte.PSTCMLCL_DESTINO = HelpClass.ToStringCvr(Item("TCMLCL_DESTINO"))
            obeSolictudTransporte.PSSESTRG = HelpClass.ToStringCvr(Item("SESTRG"))
            obeSolictudTransporte.PSCCMPN = HelpClass.ToStringCvr(Item("CCMPN"))
            obeSolictudTransporte.PSCDVSN = HelpClass.ToStringCvr(Item("CDVSN"))
            obeSolictudTransporte.PNCPLNDV = Item("CPLNDV")
            obeSolictudTransporte.PNCCLNT = Item("CCLNT")
            obeSolictudTransporte.PNQSLCIT = Item("QSLCIT")
            obeSolictudTransporte.PNQATNAN = Item("QATNAN")
            obeSolictudTransporte.PSCTPOSR = HelpClass.ToStringCvr(Item("CTPOSR"))
            obeSolictudTransporte.PNCUNDVH = Item("CUNDVH")
            obeSolictudTransporte.PNCMRCDR = Item("CMRCDR")
            obeSolictudTransporte.PNQMRCDR = Item("QMRCDR")
            obeSolictudTransporte.PSCUNDMD = HelpClass.ToStringCvr(Item("CUNDMD"))
            obeSolictudTransporte.PSFINCRG = HelpClass.FechaNum_a_Fecha(Item("FINCRG"))
            obeSolictudTransporte.PSHINCIN = HelpClass.HoraNum_a_Hora(Item("HINCIN"))
            obeSolictudTransporte.PSFENTCL = HelpClass.FechaNum_a_Fecha(Item("FENTCL"))
            obeSolictudTransporte.PSHRAENT = HelpClass.HoraNum_a_Hora(Item("HRAENT"))
            obeSolictudTransporte.PSTDRCOR = HelpClass.ToStringCvr(Item("TDRCOR"))
            obeSolictudTransporte.PSTDRENT = HelpClass.ToStringCvr(Item("TDRENT"))
            obeSolictudTransporte.PSTOBS = HelpClass.ToStringCvr(Item("TOBS"))
            obeSolictudTransporte.PNCMEDTR = Item("CMEDTR")
            obeSolictudTransporte.PSCCTCSC = HelpClass.ToStringCvr(Item("CCTCSC"))
            oListSolictudTransporte.Add(obeSolictudTransporte)
        Next
        Return oListSolictudTransporte
    End Function

    Public Function Obtener_Datos_Solicitud_Transporte(ByVal PNNCSOTR As Decimal) As beSolicitudTransporte
        Dim objDataTable As New DataTable
        Dim obeSolictudTransporte As New beSolicitudTransporte
        Dim objParam As New Parameter
        Dim lobjSql As New SqlManager
        objParam.Add("PNNCSOTR", PNNCSOTR)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLSC_OBTENER_SOLICITUD_TRANSPORTE", objParam)
        With objDataTable.Rows(0)
            obeSolictudTransporte.PNNORSRT = .Item("NORSRT")
            obeSolictudTransporte.PNNCSOTR = .Item("NCSOTR")
            obeSolictudTransporte.PSFECOST = HelpClass.FechaNum_a_Fecha(.Item("FECOST"))
            obeSolictudTransporte.PNCCLNT = .Item("CCLNT")
            obeSolictudTransporte.PNNORSRT = .Item("NORSRT")
            obeSolictudTransporte.PSTCMCRA = HelpClass.ToStringCvr(.Item("TCMCRA"))
            obeSolictudTransporte.PSTCMTPS = HelpClass.ToStringCvr(.Item("TCMTPS"))
            obeSolictudTransporte.PSTCMPUN = HelpClass.ToStringCvr(.Item("TCMPUN"))
            obeSolictudTransporte.PSTCMRCD = HelpClass.ToStringCvr(.Item("TCMRCD"))
            obeSolictudTransporte.PSTIPO_SOLICITUD = HelpClass.ToStringCvr(.Item("TIPO_SOLICITUD"))
            obeSolictudTransporte.PSTNMMDT = HelpClass.ToStringCvr(.Item("TNMMDT"))
            obeSolictudTransporte.PSTCMLCL_ORIGEN = HelpClass.ToStringCvr(.Item("TCMLCL_ORIGEN"))
            obeSolictudTransporte.PSTCMLCL_DESTINO = HelpClass.ToStringCvr(.Item("TCMLCL_DESTINO"))
            obeSolictudTransporte.PSSESTRG = HelpClass.ToStringCvr(.Item("SESTRG"))
            obeSolictudTransporte.PSCCMPN = HelpClass.ToStringCvr(.Item("CCMPN"))
            obeSolictudTransporte.PSCDVSN = HelpClass.ToStringCvr(.Item("CDVSN"))
            obeSolictudTransporte.PNCPLNDV = .Item("CPLNDV")
            obeSolictudTransporte.PNCCLNT = .Item("CCLNT")
            obeSolictudTransporte.PNQSLCIT = .Item("QSLCIT")
            obeSolictudTransporte.PNQATNAN = .Item("QATNAN")
            obeSolictudTransporte.PSCTPOSR = HelpClass.ToStringCvr(.Item("CTPOSR"))
            obeSolictudTransporte.PNCUNDVH = .Item("CUNDVH")
            obeSolictudTransporte.PNCMRCDR = .Item("CMRCDR")
            obeSolictudTransporte.PNQMRCDR = .Item("QMRCDR")
            obeSolictudTransporte.PSCUNDMD = HelpClass.ToStringCvr(.Item("CUNDMD"))
            obeSolictudTransporte.PSFINCRG = HelpClass.FechaNum_a_Fecha(.Item("FINCRG"))
            obeSolictudTransporte.PSHINCIN = HelpClass.HoraNum_a_Hora(.Item("HINCIN"))
            obeSolictudTransporte.PSFENTCL = HelpClass.FechaNum_a_Fecha(.Item("FENTCL"))
            obeSolictudTransporte.PSHRAENT = HelpClass.HoraNum_a_Hora(.Item("HRAENT"))
            obeSolictudTransporte.PSTDRCOR = HelpClass.ToStringCvr(.Item("TDRCOR"))
            obeSolictudTransporte.PSTDRENT = HelpClass.ToStringCvr(.Item("TDRENT"))
            obeSolictudTransporte.PSTOBS = HelpClass.ToStringCvr(.Item("TOBS"))
            obeSolictudTransporte.PNCMEDTR = .Item("CMEDTR")
            obeSolictudTransporte.PSCCTCSC = HelpClass.ToStringCvr(.Item("CCTCSC"))
        End With
        Return obeSolictudTransporte
    End Function

    Public Function Obtener_Detalle_Solicitud_Asignada(ByVal PNNCSOTR As Decimal) As List(Of beDetalleSolTransporte)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of beDetalleSolTransporte)
        Dim objParam As New Parameter
        Dim objDatos As beDetalleSolTransporte
        objParam.Add("PNNCSOTR", PNNCSOTR)
        Dim lobjSql As New SqlManager
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLSC_SOLICITUD_ASIGNADA_TRANSPORTE_AJUSTE", objParam)
        For Each objData As DataRow In objDataTable.Rows
            objDatos = New beDetalleSolTransporte
            objDatos.PSTCMTRT = HelpClass.ToStringCvr(objData("TCMTRT"))
            objDatos.PSNPLCUN = HelpClass.ToStringCvr(objData("NPLCUN"))
            objDatos.PSNPLCAC = HelpClass.ToStringCvr(objData("NPLCAC"))
            objDatos.PSCBRCND = HelpClass.ToStringCvr(objData("CBRCNT"))
            objDatos.PSCBRCNT = HelpClass.ToStringCvr(objData("CBRCND"))
            If objData("CBRCND2").ToString.Trim.Length = 0 Then
                objDatos.PSCBRCND2 = HelpClass.ToStringCvr(objData("CBRCND"))
            Else
                objDatos.PSCBRCND2 = HelpClass.ToStringCvr(objData("CBRCND")) & Chr(10) & HelpClass.ToStringCvr(objData("CBRCND2"))
            End If
            objDatos.PSCBRCN2 = HelpClass.ToStringCvr(objData("CBRCN2"))
            objDatos.PSFASGTR = HelpClass.ToStringCvr(objData("FASGTR"))
            objDatos.PSHASGTR = HelpClass.ToStringCvr(objData("HASGTR"))
            objDatos.PSNGUITR = HelpClass.ToStringCvr(objData("NGUITR"))
            objDatos.PSNOPRCN = HelpClass.ToStringCvr(objData("NOPRCN"))
            objDatos.PSNORINS = HelpClass.ToStringCvr(objData("NORINS"))
            objDatos.PSNPLNMT = HelpClass.ToStringCvr(objData("NPLNMT"))
            If objData("NDCMFC") = 0 Then
                objDatos.PSNDCMFC = ""
            Else
                objDatos.PSNDCMFC = HelpClass.ToStringCvr(objData("NDCMFC"))
            End If
            objGenericCollection.Add(objDatos)
        Next

        Return objGenericCollection
    End Function

    Public Function Obtener_Numero_Solicitud_Transporte(ByVal PNNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PNNORSCI", PNNORSCI)
        Dim odt As New DataTable
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_OBTENER_NUMERO_SOLCITUD_TRANSPORTE", objParam)
        Return odt
    End Function
    '
End Class
