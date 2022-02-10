Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsRangoTarifaXTarifaFlete

    Inherits clsBase(Of RangoTarifaXTarifaFlete)



    Public Function Listar_Rango_Tarifa_X_Tarifa_Flete(ByVal objEntidad As RangoTarifaXTarifaFlete) As List(Of RangoTarifaXTarifaFlete)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objRangoTarifaXTarifaFlete As New RangoTarifaXTarifaFlete
        Dim lobjRangoTarifaXTarifaFlete As New List(Of RangoTarifaXTarifaFlete)
        Try
            lobjParams.Add("PSCCMPN", objEntidad.CCMPN)
            lobjParams.Add("PNNRCTSL", objEntidad.NRCTSL)
            lobjParams.Add("PNNRTFSV", objEntidad.NRTFSV)
            lobjParams.Add("PNNCRRSR", objEntidad.NCRRSR)
            lobjParams.Add("PSSESTRG", objEntidad.SESTRG)

            Return Listar("SP_SOLMIN_CT_LISTA_RANGO_TARIFA_X_TARIFA_FLETE", lobjParams)
        Catch ex As Exception
            Return New List(Of RangoTarifaXTarifaFlete)
        End Try


        'For Each objDataRow As DataRow In dt.Rows
        '    objRangoTarifaXTarifaFlete = New RangoTarifaXTarifaFlete

        '    objRangoTarifaXTarifaFlete.CCMPN = objDataRow("CCMPN")
        '    objRangoTarifaXTarifaFlete.NRCTSL = objDataRow("NRCTSL")
        '    objRangoTarifaXTarifaFlete.NRTFSV = objDataRow("NRTFSV")
        '    objRangoTarifaXTarifaFlete.NCRRSR = objDataRow("NCRRSR")
        '    objRangoTarifaXTarifaFlete.NSEQIN = objDataRow("NSEQIN")
        '    objRangoTarifaXTarifaFlete.QIMPIN = objDataRow("QIMPIN")
        '    objRangoTarifaXTarifaFlete.QIMPFN = objDataRow("QIMPFN")
        '    objRangoTarifaXTarifaFlete.ITRSRT = objDataRow("ITRSRT")
        '    objRangoTarifaXTarifaFlete.ITRAPG = objDataRow("ITRAPG")
        '    objRangoTarifaXTarifaFlete.FULTAC = objDataRow("FULTAC")
        '    objRangoTarifaXTarifaFlete.HULTAC = objDataRow("HULTAC")
        '    objRangoTarifaXTarifaFlete.CULUSA = objDataRow("CULUSA")
        '    objRangoTarifaXTarifaFlete.NTRMNL = objDataRow("NTRMNL")
        '    objRangoTarifaXTarifaFlete.FCHCRT = objDataRow("FCHCRT")
        '    objRangoTarifaXTarifaFlete.HRACRT = objDataRow("HRACRT")
        '    objRangoTarifaXTarifaFlete.CUSCRT = objDataRow("CUSCRT")
        '    objRangoTarifaXTarifaFlete.NTRMNC = objDataRow("NTRMCR")


        '    lobjRangoTarifaXTarifaFlete.Add(objRangoTarifaXTarifaFlete)
        'Next
        'Return lobjRangoTarifaXTarifaFlete
    End Function

    Public Function Actualizar_Rango_X_Tarifa_Flete(ByVal lista As List(Of RangoTarifaXTarifaFlete)) As Int32
        Dim intResultado As Int32 = 0
        'Try
        For Each objEntidad As RangoTarifaXTarifaFlete In lista
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
            objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PNNSEQIN", objEntidad.NSEQIN)
            objParam.Add("PNQIMPIN", objEntidad.QIMPIN)
            objParam.Add("PNQIMPFN", objEntidad.QIMPFN)
            objParam.Add("PNITRSRT", objEntidad.ITRSRT)
            objParam.Add("PNITRAPG", objEntidad.ITRAPG)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
            'RCS-HUNDRED-INICIO
            objParam.Add("PNISRVTI", objEntidad.ISRVTI)


            objParam.Add("PNQRNGBS", objEntidad.QRNGBS)
            objParam.Add("PNITRCAD", objEntidad.ITRCAD)
            objParam.Add("PNITRPAD", objEntidad.ITRPAD)
            'RCS-HUNDRED-FIN
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_ACTUALIZAR_RANGO_TARIFA_X_TARIFA_FLETE", objParam)
        Next
        intResultado = 0
        'Catch ex As Exception
        '    intResultado = 1
        'End Try

        Return intResultado
    End Function

    Public Function Eliminar_Rango_X_Tarifa_Flete(ByVal objEntidad As RangoTarifaXTarifaFlete) As Boolean
        Try
            Dim lobjSql As New SqlManager
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
            objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
            objParam.Add("PNNSEQIN", objEntidad.NSEQIN)
            objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_ELIMINAR_RANGO_TARIFA_X_TARIFA_FLETE", objParam)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidades.RangoTarifaXTarifaFlete)

    End Sub
End Class



