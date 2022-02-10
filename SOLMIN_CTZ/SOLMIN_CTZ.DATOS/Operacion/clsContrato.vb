Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsContrato
    Inherits clsBase(Of Contrato)

    Public Function floListaContrato(ByVal pobjContrato As Contrato, ByRef dtContrato_Clientes As DataTable) As List(Of Contrato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        'Try
        lobjParams.Add("PNNRCTCL", pobjContrato.NRCTCL)
        lobjParams.Add("PSCCMPN", pobjContrato.CCMPN)
        lobjParams.Add("PSSESTRG", pobjContrato.SESTRG)

        Dim ds As New DataSet
        'Dim dt As New DataTable
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_LISTA_CONTRATO_RZSC01", lobjParams)


        Dim dtContratos As New DataTable
        dtContratos = ds.Tables(0).Copy
        dtContrato_Clientes = ds.Tables(1).Copy

        Dim oList As New List(Of Contrato)
        Dim oContrato As Contrato
        For Each item As DataRow In dtContratos.Rows
            oContrato = New Contrato
            oContrato.NRCTSL = item("NRCTSL")
            oContrato.NCNTRT = ("" & item("NCNTRT")).ToString.Trim
            oContrato.DESCTR = ("" & item("DESCTR")).ToString.Trim
            oContrato.TCNCTO = ("" & item("TCNCTO")).ToString.Trim
            oContrato.TMACTO = ("" & item("TMACTO")).ToString.Trim
            oContrato.NTLCTO = ("" & item("NTLCTO")).ToString.Trim
            oContrato.NMRGIM = item("NMRGIM")
            oContrato.FECINI = item("FECINI")
            oContrato.FECFIN = item("FECFIN")
            oContrato.SESTRG = ("" & item("SESTRG")).ToString.Trim
            oContrato.ESTADO_CONT = ("" & item("ESTADO_CONT")).ToString.Trim


            oContrato.CCMPN = ("" & item("CCMPN")).ToString.Trim



            oList.Add(oContrato)
        Next



        '        CONT . NRCTSL NRCTSL ,
        'CONT . NCNTRT NCNTRT ,
        'CONT . DESCTR DESCTR ,
        'CONT . TCNCTO TCNCTO ,
        'CONT . TMACTO TMACTO ,
        'CONT . NTLCTO NTLCTO ,
        'CONT . NMRGIM ,
        'CONT . FECINI ,
        'CONT . FECFIN ,
        'CONT . SESTRG ,
        'CONT . CCMPN

        'oList = Listar("SP_SOLCT_LISTA_CONTRATO_RZSC01", lobjParams)
        Return oList
        'Catch ex As Exception
        '    Return New List(Of Contrato)
        'End Try
        'SSSSS()
    End Function

    Public Function Cargar_Datos_Contrato(ByVal pobjContrato As Contrato) As Contrato
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
        Return Listar("SP_SOLCT_CARGAR_DATOS_CONTRATO", lobjParams).Item(0)
        'Catch ex As Exception
        '    Return New Contrato
        'End Try

    End Function

    Public Function flisCargarClienteXContrato(ByVal pobjContrato As Contrato) As List(Of Contrato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", pobjContrato.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
        Return Listar("SP_SOLMIN_CT_CARGAR_CLIENTES_X_CONTRATO", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of Contrato)
        'End Try

    End Function



    Public Sub EliminarClienteXContrato(ByVal pobjContrato As Contrato)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjContrato.CCMPN)
        lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
        lobjParams.Add("PNCCLNT", pobjContrato.CCLNT)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_ELIMINAR_CLIENTE_X_CONTRATO", lobjParams)


    End Sub


    Public Function fIntInsertarClienteXContrato(ByVal pobjContrato As Contrato) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", pobjContrato.CCMPN)
            lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
            lobjParams.Add("PNCCLNT", pobjContrato.CCLNT)
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_INSERTAR_CLIENTES_X_CONTRATO", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Public Function fIntCrearContrato(ByVal pobjContrato As Contrato) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSNCNTRT", pobjContrato.NCNTRT)
            lobjParams.Add("PNNRCTCL", pobjContrato.NRCTCL)
            lobjParams.Add("PSCCMPN", pobjContrato.CCMPN)
            lobjParams.Add("PSTCNCTO", pobjContrato.TCNCTO)
            lobjParams.Add("PSTMACTO", pobjContrato.TMACTO)
            lobjParams.Add("PSNTLCTO", pobjContrato.NTLCTO)
            lobjParams.Add("PNFECINI", pobjContrato.FECINI)
            lobjParams.Add("PNFECFIN", pobjContrato.FECFIN)
            lobjParams.Add("PSDESCTR", pobjContrato.DESCTR)
            lobjParams.Add("PSTOBS", pobjContrato.TOBS)
            lobjParams.Add("PSSESTRG", pobjContrato.SESTRG)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("OUT_NRCTSL", 0, ParameterDirection.Output)
            'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_CREAR_CONTRATO", lobjParams)

            Return lobjSql.ParameterCollection.Item("OUT_NRCTSL")
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Sub Actualizar_Datos_Contrato(ByVal pobjContrato As Contrato)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
            lobjParams.Add("PSNCNTRT", pobjContrato.NCNTRT)
            lobjParams.Add("PSTCNCTO", pobjContrato.TCNCTO)
            lobjParams.Add("PSTMACTO", pobjContrato.TMACTO)
            lobjParams.Add("PSNTLCTO", pobjContrato.NTLCTO)
            lobjParams.Add("PNFECINI", pobjContrato.FECINI)
            lobjParams.Add("PNFECFIN", pobjContrato.FECFIN)
            lobjParams.Add("PSDESCTR", pobjContrato.DESCTR)
            lobjParams.Add("PSTOBS", pobjContrato.TOBS)
            lobjParams.Add("PSSESTRG", pobjContrato.SESTRG)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_DATOS_CONTRATO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function fintEliminarContrato(ByVal pobjContrato As Contrato) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
            lobjParams.Add("PSSESTRG", pobjContrato.SESTRG)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjParams.Add("PNERROR", 0, ParameterDirection.Output)

            lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_ESTADO_CONTRATO", lobjParams)
            Return lobjSql.ParameterCollection.Item("PNERROR")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Grabar_Observacion(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Contrato As Bitacora_Contrato)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjBitacora_Contrato.NRCTSL)
            lobjParams.Add("PNNRITOC", pobjBitacora_Contrato.NRITOC)
            lobjParams.Add("PNTFCOBS", pobjBitacora_Contrato.TFCOBS)
            lobjParams.Add("PSTOBS", pobjBitacora_Contrato.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            oSqlMan.ExecuteNonQuery("SP_SOLCT_GRABAR_OBSERVACION", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_Observaciones(ByRef oSqlMan As SqlManager, ByVal pobjContrato As Contrato)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
            oSqlMan.ExecuteNonQuery("SP_SOLCT_BORRAR_OBSERVACIONES", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Observacion_Cliente(ByVal pobjContrato As Contrato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
        lobjParams.Add("PSSESTRG", pobjContrato.SESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_OBSERVACION_CLIENTE", lobjParams)
        Return dt
    End Function


    Public Function Lista_IndicadorVentaMensual(ByVal pobjFiltro As Contrato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjFiltro.CCMPN)
        lobjParams.Add("PSSESTRG", pobjFiltro.NRCTCL)
        lobjParams.Add("PNFECINI", pobjFiltro.FECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.FECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_INDICADOR_VENTA_MENSUAL", lobjParams)
        Return dt
    End Function

    Public Function fdtListaIndicadorVentaMensualGeneral(ByVal pobjFiltro As Contrato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        'Try
        lobjParams.Add("PNNRCTSL", pobjFiltro.CCMPN)
        lobjParams.Add("PNFECINI", pobjFiltro.FECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.FECFIN)
        Return lobjSql.ExecuteDataTable("SP_SOLMIN_CT_INDICADOR_VENTA_MENSUAL_GENERAL", lobjParams)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try

    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub

   

    Public Overloads Overrides Sub ToParameters(ByVal obj As Entidades.Contrato)

    End Sub
End Class
