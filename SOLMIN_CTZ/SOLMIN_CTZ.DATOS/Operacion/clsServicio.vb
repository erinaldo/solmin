Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsServicio
    Inherits clsBase(Of Servicio_X_Rubro)


    'Public Function Lista_Servicio(ByVal pobjServicio As Servicio, ByVal pobjFiltro As Filtro) As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter

    '    lobjParams.Add("PNNRRBDV", pobjFiltro.Parametro1)
    '    lobjParams.Add("PSNOMSER", pobjServicio.NOMSER)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO", lobjParams)
    '    Return dt
    'End Function

    Public Sub Crear_Servicio(ByVal pobjServicio As Servicio_X_Rubro)
        'Try
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRRUBR", pobjServicio.NRRUBR)
        'lobjParams.Add("PSCSCDSP", pobjServicio.CSCDSP)
        'lobjParams.Add("PSCRGVTA", pobjServicio.CRGVTA)
        lobjParams.Add("PSCCMPN", pobjServicio.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicio.CDVSN)
        lobjParams.Add("PNCSRVNV", pobjServicio.CSRVNV)
        lobjParams.Add("PSNOMSER", pobjServicio.NOMSER)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        'lobjSql.ExecuteNonQuery("SP_SOLCT_CREAR_SERVICIO", lobjParams)
        lobjSql.ExecuteNonQuery("SP_SOLCT_CREAR_SERVICIO_RZSC08", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    Public Sub Actualizar_Servicio(ByVal pobjServicio As Servicio_X_Rubro)
        'Try
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRSRRB", pobjServicio.NRSRRB)
        lobjParams.Add("PSCCMPN", pobjServicio.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicio.CDVSN)
        lobjParams.Add("PNCSRVNV", pobjServicio.CSRVNV)
        lobjParams.Add("PSNOMSER", pobjServicio.NOMSER)
        lobjParams.Add("PSCLUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_SERVICIO", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Sub Eliminar_Servicio(ByVal pobjServicio As Servicio_X_Rubro)
        'Try
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRSRRB", pobjServicio.NRSRRB)
        lobjParams.Add("PCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLCT_BORRAR_SERVICIO", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Function Verificar_Servicio(ByVal pobjServicio As Servicio_X_Rubro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRSRRB", pobjServicio.NRSRRB)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_VERIFICA_SERVICIO", lobjParams)
        Return dt
    End Function

    Public Function Lista_Servicio_X_Compania(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA", lobjParams)
        Return dt
    End Function

    Public Function Lista_Servicio_General(ByVal pobjServicioGral As Servicio_X_Rubro) As List(Of Servicio_X_Rubro)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjServicioGral.CCMPN)
        lobjParams.Add("PSCDVSN", pobjServicioGral.CDVSN)
        Return Listar("SP_SOLCT_LISTA_SERVICIO_GENERAL", lobjParams)
    End Function

    Public Function Lista_Servicio_X_Compania_Division(ByVal pobjFiltro As Filtro) As List(Of Servicio_X_Rubro) 'As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION", lobjParams)
        'Return dt

        Dim objEntidad As Servicio_X_Rubro
        Dim lbeServicio_X_Rubro As New List(Of Servicio_X_Rubro)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New Servicio_X_Rubro
            objEntidad.NRSRRB = objDataRow("NRSRRB").ToString.Trim()
            objEntidad.NOMSER = objDataRow("NOMSER").ToString.Trim()
            objEntidad.NRRUBR = objDataRow("NRRUBR").ToString.Trim()
            'objEntidad.NRRUBR_NRSRRB = objDataRow("NRRUBR").ToString.Trim() & "_" & objDataRow("NRSRRB").ToString.Trim() & "_" & objDataRow("CSRVC").ToString.Trim()
            objEntidad.CSRVC = objDataRow("CSRVC").ToString.Trim()
            objEntidad.CSRVNV = objDataRow("CSRVNV").ToString.Trim()
            '<[AHM]>'
            objEntidad.CDSRSP = objDataRow("CDSRSP").ToString.Trim()
            objEntidad.TSRVIN = objDataRow("TSRVIN").ToString.Trim()
            '</[AHM]>'
            lbeServicio_X_Rubro.Add(objEntidad)
        Next
        Return lbeServicio_X_Rubro
        'Return Listar("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION", lobjParams)
    End Function


    Public Function Lista_Servicio_X_Compania_Division_OS(ByVal pobjFiltro As Filtro) As List(Of Servicio_X_Rubro) 'As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION_ORDENSERVICIO", lobjParams)
        'Return dt

        Dim objEntidad As Servicio_X_Rubro
        Dim lbeServicio_X_Rubro As New List(Of Servicio_X_Rubro)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New Servicio_X_Rubro
            objEntidad.NRSRRB = objDataRow("NRSRRB").ToString.Trim()
            objEntidad.NOMSER = objDataRow("NOMSER").ToString.Trim()
            objEntidad.NRRUBR = objDataRow("NRRUBR").ToString.Trim()
            objEntidad.CSRVC = objDataRow("CSRVC").ToString.Trim()
            objEntidad.CSRVNV = objDataRow("CSRVNV").ToString.Trim()
            '<[AHM]>'
            objEntidad.CDSRSP = objDataRow("CDSRSP").ToString.Trim()
            objEntidad.TSRVIN = objDataRow("TSRVIN").ToString.Trim()
            '</[AHM]>'
            lbeServicio_X_Rubro.Add(objEntidad)
        Next
        Return lbeServicio_X_Rubro

    End Function


    Public Function Lista_Servicio_X_Compania_Division_X_Rubro(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION_X_RUBRO", lobjParams)
        Return dt
    End Function

    Public Function Lista_Servicio_X_Compania_Division_X_Rubro_Servicio(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNNRRUBR", pobjFiltro.Parametro3)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION_X_RUBRO_SERVICIO", lobjParams)
        Return dt

    End Function

    Public Function Lista_Servicio_X_Rubro_X_Compania_Division(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PNNRRUBR", pobjFiltro.Parametro3)
        lobjParams.Add("PNNRSRRB", pobjFiltro.Parametro4)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_COMPANIA_DIVISION_SERV_RUB", lobjParams)
        Return dt
    End Function

    Public Function VerificarConfiguracionOrdenServicio(ByVal pobjFiltro As Filtro) As String 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim lobjSql As New SqlManager
        Dim objParam1 As New Parameter
        Dim dt As New DataTable()
        Dim msje As String = String.Empty
        objParam1.Add("PSCCMPN", pobjFiltro.Parametro1)
        objParam1.Add("PSCDVSN", pobjFiltro.Parametro2)
        objParam1.Add("PNCPLNDV", pobjFiltro.Parametro3)
        objParam1.Add("PNCPLNFC", pobjFiltro.Parametro7)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDA_CONFIGURACION_NUMERACION_PLANTA_SALM", objParam1)
        For Each row As DataRow In dt.Rows
            If row("STATUS").ToString.Trim = "N" Then
                msje = msje & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        msje = msje.Trim
        If msje.Trim.Length = 0 Then
            Dim objParam2 As New Parameter
            Dim dt2 As New DataTable()
            objParam2.Add("PSCCMPN", pobjFiltro.Parametro1)
            objParam2.Add("PSCDVSN", pobjFiltro.Parametro2)
            objParam2.Add("PNCPLNDV", pobjFiltro.Parametro3)
            objParam2.Add("PNCPLNFC", pobjFiltro.Parametro7)
            objParam2.Add("PSTIPOVAL", "I")
            objParam2.Add("PNCCNCST", pobjFiltro.Parametro4)
            objParam2.Add("PNCCNCS1", pobjFiltro.Parametro5)
            objParam2.Add("PSTIPOCCLNT", pobjFiltro.Parametro8)
            objParam2.Add("PNCODSERV", pobjFiltro.Parametro6)

            objParam2.Add("PSTARIFASEG", pobjFiltro.Parametro9)

            dt2 = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDA_CONFIGURACION_CEBE_X_PLANTA_SALM", objParam2)
            For Each row As DataRow In dt2.Rows
                If row("STATUS").ToString.Trim = "N" Then
                    msje = msje & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
        End If
        msje = msje.Trim
        Return msje
    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As Entidades.Servicio_X_Rubro)

    End Sub


End Class
