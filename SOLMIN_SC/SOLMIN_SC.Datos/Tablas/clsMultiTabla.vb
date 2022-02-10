Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsMultiTabla

    Public Function Lista_Tabla(ByVal pstrTabla As String) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTABLA", pstrTabla)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DET_TABLA", lobjParams)

        Return dt
    End Function

    Public Sub Mantenimiento_Vapor(ByVal pstrTipo As String, ByVal pstrCod As String, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pstrTerminal As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PSCVPRCN", pstrCod)
        lobjParams.Add("PSTCMPVP", pstrDes)
        lobjParams.Add("PSNTRMNL", pstrTerminal)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEstado)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_VAPOR", lobjParams)
     
    End Sub

    Public Sub Mantenimiento_CiaTransporte(ByVal pstrTipo As String, ByVal pdblCod As Double, ByVal pstrMedio As String, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pdblPais As Double)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PSCCIANV", pdblCod)
        lobjParams.Add("PSTNMCIN", pstrDes)
        lobjParams.Add("PSSMETRA", pstrMedio)
        lobjParams.Add("PNCPAIS", pdblPais)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEstado)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_CIATRANS", lobjParams)
      
    End Sub

    Public Sub Mantenimiento_Embarcador(ByVal pstrTipo As String, ByVal pdblCod As Double, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pdblPais As Double)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PSCAGNCR", pdblCod)
        lobjParams.Add("PSTNMAGC", pstrDes)
        lobjParams.Add("PNCPAIS", pdblPais)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEstado)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_EMBARCADOR", lobjParams)
       
    End Sub

End Class
