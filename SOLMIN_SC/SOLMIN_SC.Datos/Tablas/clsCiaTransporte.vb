Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsCiaTransporte
  Private objSql As New SqlManager

  Public Function Lista_Cia_Transporte(ByVal oCiaTransporte As beCiaTransporte) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PNCAGNCR_INI", oCiaTransporte.PNCAGNCR_INI)
    lobjParams.Add("PNCAGNCR_FIN", oCiaTransporte.PNCAGNCR_FIN)
    lobjParams.Add("PSTNMCIN", oCiaTransporte.PSTNMCIN)
    lobjParams.Add("PSSESTRG", oCiaTransporte.PSSESTRG)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCAR_CIATRANSPORTE", lobjParams)
    Return dt
  End Function

  Public Function Registrar_CiaTransporte(ByVal TNMCIN As String, ByVal TDIRCN As String, ByVal SMETRA As Int32, ByVal CPAIS As Int32) As Integer

    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCCIANV", 2)
    objParam.Add("PSTNMCIN", TNMCIN)
    objParam.Add("PSTDIRCN", TDIRCN)
    objParam.Add("PSSMETRA", SMETRA)
    objParam.Add("PNCPAIS", CPAIS)
    objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
    objParam.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    objParam.Add("PNHORA", Format(Now, "HHmmss"))
    objParam.Add("PSSESTRG", "A")
        objSql.ExecuteNonQuery("SP_SOLSC_INSERTA_CIATRANSPORTE", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Eliminar_CiaTransporte(ByVal CCIANV As Int32) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCCIANV", CCIANV)
        objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_CIATRANSPORTE", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Restablecer_CiaTransporte(ByVal CCIANV As Int32) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCCIANV", CCIANV)
        objSql.ExecuteNonQuery("SP_SOLSC_RESTABLECER_CIATRANSPORTE", objParam)
    retorno = 1
    Return retorno
  End Function

  Public Function Actualizar_CiaTransporte(ByVal CCIANV As Int32, ByVal TNMCIN As String, ByVal TDIRCN As String, ByVal SMETRA As Int32, ByVal CPAIS As Int32) As Integer
    Dim retorno As Int32 = 0
    Dim objParam As New Parameter
    objParam.Add("PSCCIANV", CCIANV)
    objParam.Add("PSTNMCIN", TNMCIN)
    objParam.Add("PSTDIRCN", TDIRCN)
    objParam.Add("PSSMETRA", SMETRA)
    objParam.Add("PNCPAIS", CPAIS)
    objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
    objParam.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    objParam.Add("PNHORA", Format(Now, "HHmmss"))

    objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_CIATRANSPORTE", objParam)
    retorno = 1
    Return retorno
    End Function

    Public Function Lista_Cia_Transporte_Todos() As List(Of beCiaTransporte)
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        'Dim lobjParams As New Parameter
        Dim oLisCiaTras As New List(Of beCiaTransporte)
        Dim obeCiaTransporte As beCiaTransporte
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_CIATRANSPORTE", Nothing)
        For Each dr As DataRow In dt.Rows
            obeCiaTransporte = New beCiaTransporte
            obeCiaTransporte.PNCCIANV = dr("CCIANV")
            obeCiaTransporte.PSTNMCIN = dr("TNMCIN").ToString.Trim
            obeCiaTransporte.PNCPAIS = dr("CPAIS")
            obeCiaTransporte.PNSMETRA = dr("SMETRA").ToString.Trim
            oLisCiaTras.Add(obeCiaTransporte)
        Next
        Return oLisCiaTras
    End Function
End Class
