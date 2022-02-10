Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsTipoDato
    '*************************************************
    Public Function Lista_TipoDato_Todos() As List(Of beTipoDato)
        Dim dt As DataTable
        Dim oListoBE_TipoDato As New List(Of beTipoDato)
        Dim oBE_TipoDato As beTipoDato
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPO_DATOS_DETALLE_ALL", Nothing)
        For Each Item As DataRow In dt.Rows
            oBE_TipoDato = New beTipoDato
            oBE_TipoDato.PNNTPODT = Item("NTPODT")
            oBE_TipoDato.PNNCODRG = Item("NCODRG")
            oBE_TipoDato.PSTDSCRG = HelpClass.ToStringCvr(Item("TDSCRG"))
            oBE_TipoDato.PNCCLNT = Item("CCLNT1")
            oBE_TipoDato.PNQCNTN = Item("QCNTN")
            oListoBE_TipoDato.Add(oBE_TipoDato)
        Next
        Return oListoBE_TipoDato
    End Function


    Public Function Lista_TipoDato_X_Codigo(ByVal pBE_TipoDato As beTipoDato) As List(Of beTipoDato)
        Dim dt As DataTable
        Dim oListoBE_TipoDato As New List(Of beTipoDato)
        Dim oBE_TipoDato As beTipoDato
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNTPODT", pBE_TipoDato.PNNTPODT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPO_DATOS_DETALLE", lobjParams)
        For Each Item As DataRow In dt.Rows
            oBE_TipoDato = New beTipoDato
            oBE_TipoDato.PNNTPODT = Item("NTPODT")
            oBE_TipoDato.PNNCODRG = Item("NCODRG")
            oBE_TipoDato.PSTDSCRG = HelpClass.ToStringCvr(Item("TDSCRG"))
            oBE_TipoDato.PNCCLNT = Item("CCLNT1")
            oBE_TipoDato.PNQCNTN = Item("QCNTN")
            oListoBE_TipoDato.Add(oBE_TipoDato)
        Next
        Return oListoBE_TipoDato
    End Function
    '*******************************************
    Public Function Lista_TipoDato(ByVal objTipoDato As Entidad.beTipoDato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSTDSTPD", objTipoDato.PSTDSTPD)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPO_DATOS", lobjParams)
        Return dt
    End Function
    Public Function Lista_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPO_DATOS_DETALLE", lobjParams)
        Return dt
    End Function
    Public Sub Actualiza_TipoDato(ByVal objTipoDato As Entidad.beTipoDato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)
        lobjParams.Add("PSTDSTPD", objTipoDato.PSTDSTPD.Trim.ToUpper)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZA_TIPO_DATOS", lobjParams)
      
    End Sub
    Public Sub Actualiza_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)
        lobjParams.Add("PNNCODRG", objTipoDato.PNNCODRG)
        lobjParams.Add("PNCCLNT", objTipoDato.PNCCLNT)
        lobjParams.Add("PSTDSCRG", objTipoDato.PSTDSCRG)
        lobjParams.Add("PNQCNTN", objTipoDato.PNQCNTN)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZA_TIPO_DATOS_DETALLE", lobjParams)
       
    End Sub
    Public Function Eliminar_TipoDato(ByVal objTipoDato As Entidad.beTipoDato) As Integer
        Try
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager

            lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNVALIDA", 0, ParameterDirection.Output)
            lobjSql.ExecuteNonQuery("SP_SOLSC_ANULA_TIPO_DATOS", lobjParams)

            Return lobjSql.ParameterCollection("PNVALIDA")
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return -1
        End Try
    End Function
    Public Function Eliminar_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato) As Integer
        Try
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)
            lobjParams.Add("PNNCODRG", objTipoDato.PNNCODRG)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNVALIDA", 0, ParameterDirection.Output)
            lobjSql.ExecuteNonQuery("SP_SOLSC_ANULA_TIPO_DATOS_DETALLE", lobjParams)
            Return lobjSql.ParameterCollection("PNVALIDA")
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return -1
        End Try
    End Function
    Public Sub Inserta_TipoDato(ByVal objTipoDato As Entidad.beTipoDato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTDSTPD", objTipoDato.PSTDSTPD.ToUpper)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTA_TIPO_DATOS", lobjParams)
       
    End Sub
    Public Sub Inserta_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNTPODT", objTipoDato.PNNTPODT)
        lobjParams.Add("PNCCLNT", objTipoDato.PNCCLNT)
        lobjParams.Add("PSTDSCRG", objTipoDato.PSTDSCRG.Trim)
        lobjParams.Add("PNQCNTN", objTipoDato.PNQCNTN)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTA_TIPO_DATOS_DETALLE", lobjParams)
      
    End Sub
End Class
