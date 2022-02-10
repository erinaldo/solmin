Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsZonasEmbarque
    Public Function Lista_Zonas(ByVal PNCCLNT As Decimal, ByVal PSTZNAEM As String) As List(Of ZonaEmbarque_BE)
        Dim dt As DataTable
        Dim oListZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeZonaEmbarque As ZonaEmbarque_BE

        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSTZNAEM", PSTZNAEM)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_ZONAS_EMBARQUE_X_CLIENTE", lobjParams)

        For Each dr As DataRow In dt.Rows
            obeZonaEmbarque = New ZonaEmbarque_BE
            obeZonaEmbarque.PNCCLNT = dr("CCLNT")
            obeZonaEmbarque.PSCZNAEM = dr("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = dr("TZNAEM").ToString.Trim
            obeZonaEmbarque.PSSESTRG = dr("SESTRG").ToString.Trim
            oListZonaEmbarque.Add(obeZonaEmbarque)
        Next
        Return oListZonaEmbarque
    End Function

    Public Function Lista_Paises_Zonas(ByVal PNCCLNT As Decimal, ByVal PSCZNAEM As String) As List(Of ZonaEmbarque_BE)
        Dim dt As DataTable
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeZonaEmbarque As ZonaEmbarque_BE

        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCZNAEM", PSCZNAEM)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PAISES_X_ZONAS_EMBARQUE", lobjParams)
        For Each dr As DataRow In dt.Rows
            obeZonaEmbarque = New ZonaEmbarque_BE
            obeZonaEmbarque.PNCCLNT = dr("CCLNT")
            obeZonaEmbarque.PSCZNAEM = dr("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = dr("TZNAEM").ToString.Trim
            obeZonaEmbarque.PNCPAIS = dr("CPAIS")
            obeZonaEmbarque.PSTCMPPS = dr("TCMPPS").ToString.Trim
            obeZonaEmbarque.PSSESTRG = dr("SESTRG").ToString.Trim
            obeZonaEmbarque.PSCPRTOE = dr("CPRTOE").ToString.Trim
            obeZonaEmbarque.PSTCMPR1 = dr("TCMPR1").ToString.Trim
            oListPais__X_ZonaEmbarque.Add(obeZonaEmbarque)
        Next
        Return oListPais__X_ZonaEmbarque
    End Function


    Public Function Insertar_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("PSCZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PSTZNAEM", obeZonaEmbarque.PSTZNAEM)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTA_ZONA_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function
    Public Function Actualiza_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("PSCZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PSTZNAEM", obeZonaEmbarque.PSTZNAEM)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZA_ZONA_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Elimina_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("CZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINA_ZONA_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Existe_Codigo_X_Zona_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCZNAEM As String) As ZonaEmbarque_BE
        Dim retorno As Int32 = 0
        Dim odt As New DataTable
        Dim obeZonaEmbarque As New ZonaEmbarque_BE
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCZNAEM", PSCZNAEM)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_VALIDA_CODIGO_ZONA_EMBARQUE", lobjParams)
        If (odt.Rows.Count > 0) Then
            obeZonaEmbarque.PNCCLNT = odt.Rows(0)("CCLNT")
            obeZonaEmbarque.PSCZNAEM = odt.Rows(0)("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = odt.Rows(0)("TZNAEM").ToString.Trim
        Else
            obeZonaEmbarque = Nothing
        End If
        Return obeZonaEmbarque
    End Function


    Public Function Insertar_Zona_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("PSCZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PNCPAIS", obeZonaEmbarque.PNCPAIS)
        lobjParams.Add("PSCPRTOE", obeZonaEmbarque.PSCPRTOE)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTA_ZONA_PAIS_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Actualizar_Zona_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("PSCZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PNCPAIS", obeZonaEmbarque.PNCPAIS)
        lobjParams.Add("PSCPRTOE", obeZonaEmbarque.PSCPRTOE)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZA_ZONA_PAIS_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Elimina_Zonas_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim retorno As Int32 = 0
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeZonaEmbarque.PNCCLNT)
        lobjParams.Add("CZNAEM", obeZonaEmbarque.PSCZNAEM)
        lobjParams.Add("PNCPAIS", obeZonaEmbarque.PNCPAIS)
        lobjParams.Add("PSCPRTOE", obeZonaEmbarque.PSCPRTOE)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Environment.MachineName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINA_ZONA_PAIS_EMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function


    Public Function Existe_X_Pais_En_Otra_Zona_D_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCZNAEM As String, ByVal PNCPAIS As Decimal) As ZonaEmbarque_BE
        Dim retorno As Int32 = 0
        Dim odt As New DataTable
        Dim obeZonaEmbarque As New ZonaEmbarque_BE
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCZNAEM", PSCZNAEM)
        lobjParams.Add("PNCPAIS", PNCPAIS)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_EXISTE_PAIS_ZONA_EMBARQUE", lobjParams)
        If (odt.Rows.Count > 0) Then
            obeZonaEmbarque.PNCCLNT = odt.Rows(0)("CCLNT")
            obeZonaEmbarque.PSCZNAEM = odt.Rows(0)("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = odt.Rows(0)("TZNAEM").ToString.Trim
            obeZonaEmbarque.PNCPAIS = odt.Rows(0)("CPAIS")
        Else
            obeZonaEmbarque = Nothing
        End If
        Return obeZonaEmbarque
    End Function

    Public Function Existe_X_Zona_Pais_Puerto_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCZNAEM As String, ByVal PNCPAIS As Decimal, ByVal PSCPRTOE As String) As ZonaEmbarque_BE
        Dim retorno As Int32 = 0
        Dim odt As New DataTable
        Dim obeZonaEmbarque As New ZonaEmbarque_BE
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCZNAEM", PSCZNAEM)
        lobjParams.Add("PNCPAIS", PNCPAIS)
        lobjParams.Add("PSCPRTOE", PSCPRTOE)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_EXISTE_PAIS_ZONA_PUERTO_EMBARQUE", lobjParams)
        If (odt.Rows.Count > 0) Then
            obeZonaEmbarque.PNCCLNT = odt.Rows(0)("CCLNT")
            obeZonaEmbarque.PSCZNAEM = odt.Rows(0)("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = odt.Rows(0)("TZNAEM").ToString.Trim
            obeZonaEmbarque.PNCPAIS = odt.Rows(0)("CPAIS")
        Else
            obeZonaEmbarque = Nothing
        End If
        Return obeZonaEmbarque
    End Function

    Public Function Lista_Zonas_X_Cliente(ByVal PNCCLNT As Decimal) As List(Of ZonaEmbarque_BE)
        Dim retorno As Int32 = 0
        Dim odt As New DataTable
        Dim oListPaisZonaEmbarque As New List(Of ZonaEmbarque_BE)
        Dim obeZonaEmbarque As ZonaEmbarque_BE
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DETALLE_ZONAS_LANDEST_COST_EMBARQUE_X_CLIENTE", lobjParams)
        For Each dr As DataRow In odt.Rows
            obeZonaEmbarque = New ZonaEmbarque_BE
            obeZonaEmbarque.PNCCLNT = dr("CCLNT")
            obeZonaEmbarque.PSCZNAEM = dr("CZNAEM").ToString.Trim
            obeZonaEmbarque.PSTZNAEM = dr("TZNAEM").ToString.Trim
            obeZonaEmbarque.PNCPAIS = dr("CPAIS")
            obeZonaEmbarque.PSTCMPPS = dr("TCMPPS").ToString.Trim
            obeZonaEmbarque.PSCPRTOE = dr("CPRTOE").ToString.Trim
            obeZonaEmbarque.PSCPRTOE = dr("TCMPR1").ToString.Trim
            oListPaisZonaEmbarque.Add(obeZonaEmbarque)
        Next
        Return oListPaisZonaEmbarque
    End Function

End Class
