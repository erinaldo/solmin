Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsServicioXDivision


    Public Function Lista_Servicio_X_Division(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro, ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.Parametro1)
        lobjParams.Add("PSCDVSN", pobjFiltro.Parametro2)
        lobjParams.Add("PSSESTRG", pobjServicio_X_Rubro.SESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_DIVISION_RZSC08", lobjParams)
        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SERVICIO_DIVISION", lobjParams)
        Return dt
    End Function

    Public Sub Quitar_Servicio_X_Division(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRSRRB", pobjServicio_X_Rubro.NRSRRB)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_QUITAR_SERVICIO_DIVISION", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Lista de rubros
    ''' </summary>
    ''' <param name="pobjFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaServiciosGenerales(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN)
            lobjParams.Add("PSCDVSN", pobjFiltro.CDVSN)
            lobjParams.Add("PSSESTRG", pobjFiltro.SESTRG)
            Return lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_GENERALES_SOLMIN", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function


    Public Function fdtListaServiciosEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN)
            lobjParams.Add("PNNRRUBR", pobjFiltro.NRRUBR)
            Return lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_X_RUBRO_SOLMIN", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function fintGuardarServicioGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNRRUBR", pobjFiltro.NRRUBR)
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN)
            lobjParams.Add("PSCDVSN", pobjFiltro.CDVSN)
            lobjParams.Add("PSNOMRUB", pobjFiltro.NOMRUB)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_GUARDAR_SERVICIOS_GENERALES", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function fintGuardarServicioEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNNRRUBR", pobjFiltro.NRRUBR)
            lobjParams.Add("PNNRSRRB", pobjFiltro.NRSRRB)
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN)
            lobjParams.Add("PSCDVSN", pobjFiltro.CDVSN)
            lobjParams.Add("PNCSRVNV", pobjFiltro.CSRVNV)
            lobjParams.Add("PSNOMSER", pobjFiltro.NOMSER)
            lobjParams.Add("PSUSUARIO", ConfigurationWizard.UserName)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_GUARDAR_SERVICIOS_ESPECIFICOS", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Verifica si el servicio General contien servicios especificos
    ''' </summary>
    ''' <param name="pobjFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fbolVerificarServicoGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Boolean
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As New DataTable
        Try
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN) 'CSR-HUNDRED
            lobjParams.Add("PNNRRUBR", pobjFiltro.NRRUBR)
            oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VERIFICA_SERVICIO_GENERAL", lobjParams)

            If oDt.Rows(0).Item("CANTIDAD") > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Function fintQuitarServicoGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN) 'CSR-HUNDRED
            lobjParams.Add("PNNRRUBR", pobjFiltro.NRRUBR)
            lobjParams.Add("PSUSUARIO", ConfigurationWizard.UserName)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_BORRAR_SEVICIO_GENERAL", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Verifica si esque cuenta con servicios
    ''' </summary>
    ''' <param name="pobjServicio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fbolVerificarServicioEspecificos(ByVal pobjServicio As Servicio_X_Rubro) As Boolean
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PSCCMPN", pobjServicio.CCMPN) 'CSR-HUNDRED
            lobjParams.Add("PNNRRUBR", pobjServicio.NRRUBR)
            lobjParams.Add("PNNRSRRB", pobjServicio.NRSRRB)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VERIFICA_SERVICIO_ESPECIFICOS", lobjParams)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function fintEliminarServicioEspecificos(ByVal pobjServicio As Servicio_X_Rubro) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", pobjServicio.CCMPN) 'CSR-HUNDRED
            lobjParams.Add("PNNRRUBR", pobjServicio.NRRUBR)
            lobjParams.Add("PNNRSRRB", pobjServicio.NRSRRB)
            lobjParams.Add("PCULUSA", ConfigurationWizard.UserName)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_BORRAR_SERVICIO", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function



    Public Function fdtListaParaExportarExcel(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", pobjFiltro.CCMPN)
            lobjParams.Add("PSCDVSN", pobjFiltro.CDVSN)

            Return lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIO_PARA_EXPORTAR_EXCEL", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

 
End Class
