Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsDetalleTarifaTipoFlete

    Inherits clsBase(Of DetalleTarifaTipoFlete)


    Public Function Listar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As List(Of DetalleTarifaTipoFlete)
        'Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objDetTarTipFlete As New DetalleTarifaTipoFlete
        Dim lobjDetTarTipFlete As New List(Of DetalleTarifaTipoFlete)
        Try
            lobjParams.Add("PSCCMPN", objEntidad.CCMPN)
            lobjParams.Add("PNNRCTSL", objEntidad.NRCTSL)
            lobjParams.Add("PNNRTFSV", objEntidad.NRTFSV)
            lobjParams.Add("PSSESTRG", objEntidad.SESTRG)
            Return Listar("SP_SOLMIN_CT_LISTA_SERVICIO_MERCADERIA", lobjParams)
        Catch ex As Exception
            Return New List(Of DetalleTarifaTipoFlete)
        End Try


        'For Each objDataRow As DataRow In dt.Rows
        '    objDetTarTipFlete = New DetalleTarifaTipoFlete
        '    objDetTarTipFlete.CCMPN = objDataRow("CCMPN")
        '    objDetTarTipFlete.NRCTSL = objDataRow("NRCTSL")
        '    objDetTarTipFlete.NRTFSV = objDataRow("NRTFSV")
        '    objDetTarTipFlete.NCRRSR = objDataRow("NCRRSR")
        '    objDetTarTipFlete.TOBSSR = objDataRow("TOBSSR").ToString.Trim
        '    objDetTarTipFlete.CLCLOR = objDataRow("CLCLOR")
        '    objDetTarTipFlete.CLCLDS = objDataRow("CLCLDS")
        '    objDetTarTipFlete.ITRSRT = objDataRow("ITRSRT")
        '    objDetTarTipFlete.CMNTRN = objDataRow("CMNTRN")
        '    objDetTarTipFlete.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
        '    objDetTarTipFlete.CMNLQT = objDataRow("CMNLQT")
        '    objDetTarTipFlete.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")
        '    objDetTarTipFlete.ILSFTR = objDataRow("ILSFTR")
        '    objDetTarTipFlete.ILCFTR = objDataRow("ILCFTR")
        '    objDetTarTipFlete.ILQFMX = objDataRow("ILQFMX")
        '    objDetTarTipFlete.ILQSMT = objDataRow("ILQSMT")
        '    objDetTarTipFlete.CUNSRA = objDataRow("CUNSRA")
        '    objDetTarTipFlete.QDSTVR = objDataRow("QDSTVR")
        '    objDetTarTipFlete.SFCRTV = objDataRow("SFCRTV")
        '    objDetTarTipFlete.SSRVCB = objDataRow("SSRVCB")
        '    objDetTarTipFlete.SSRVPG = objDataRow("SSRVPG")
        '    objDetTarTipFlete.SSRVFE = objDataRow("SSRVFE")
        '    objDetTarTipFlete.CSTNDT = objDataRow("CSTNDT")
        '    objDetTarTipFlete.ORIGEN = objDataRow("ORIGEN")
        '    objDetTarTipFlete.DESTINO = objDataRow("DESTINO")
        '    objDetTarTipFlete.MONEDA = objDataRow("MONEDA")
        '    objDetTarTipFlete.CUBORI = objDataRow("CUBORI")
        '    objDetTarTipFlete.UBIGEO_O = objDataRow("UBIGEO_O")
        '    objDetTarTipFlete.CUBDES = objDataRow("CUBDES")
        '    objDetTarTipFlete.UBIGEO_D = objDataRow("UBIGEO_D")

        '    lobjDetTarTipFlete.Add(objDetTarTipFlete)
        'Next
        'Return lobjDetTarTipFlete
    End Function

    Public Function Existe_Flete_Ruta(ByVal objEntidad As DetalleTarifaTipoFlete) As Integer
        Dim intResultado As Int32 = 0
        Dim lobjSql As New SqlManager
        Try

            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
            objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
            objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
            objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
            objParam.Add("PNRESPON", 0, ParameterDirection.Output)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_EXISTE_FLETE_RUTA", objParam)
            intResultado = lobjSql.ParameterCollection("PNRESPON")

        Catch ex As Exception
            intResultado = 0
        End Try
        Return intResultado

    End Function

    Public Function Eliminar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Integer
        Dim intResultado As Int32 = 0
        Dim lobjSql As New SqlManager
        Try

            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
            objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
            objParam.Add("PNNCRRSR", objEntidad.NCRRSR)

            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_ELIMINAR_FLETE_RUTA", objParam)

            intResultado = 1
        Catch ex As Exception
            intResultado = 0
        End Try
        Return intResultado
    End Function

    Public Function Registrar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Double
        Dim dblResultado As Double = 0
        Dim lobjSql As New SqlManager
        'Try

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
        objParam.Add("PNNCRRSR", objEntidad.NCRRSR, ParameterDirection.Output)
        objParam.Add("PSTOBSSR", objEntidad.TOBSSR)
        objParam.Add("PNCUBORI", objEntidad.CUBORI)
        objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
        objParam.Add("PNCUBDES", objEntidad.CUBDES)
        objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
        objParam.Add("PNITRSRT", objEntidad.ITRSRT)
        objParam.Add("PNCMNTRN", objEntidad.CMNTRN)
        objParam.Add("PNCMNLQT", objEntidad.CMNLQT)
        objParam.Add("PNILSFTR", objEntidad.ILSFTR)
        objParam.Add("PNILCFTR", objEntidad.ILCFTR)
        objParam.Add("PNILQFMX", objEntidad.ILQFMX)
        objParam.Add("PNILQSMT", objEntidad.ILQSMT)
        objParam.Add("PSCUNSRA", objEntidad.CUNSRA)
        objParam.Add("PNQDSTVR", objEntidad.QDSTVR)
        objParam.Add("PSSFCRTV", objEntidad.SFCRTV)
        objParam.Add("PSSSRVPG", objEntidad.SSRVPG)
        objParam.Add("PSSSRVCB", objEntidad.SSRVCB)
        objParam.Add("PSSSRVFE", objEntidad.SSRVFE)
        objParam.Add("PNCSTNDT", objEntidad.CSTNDT)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)
        objParam.Add("PNCSRCTZ", objEntidad.CSRCTZ)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
        objParam.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        'RCS-HUNDRED-INICIO
        objParam.Add("PNCMNDTI", objEntidad.CMNDTI)
        objParam.Add("PNISRVTI", objEntidad.ISRVTI)
        'RCS-HUNDRED-FIN
        objParam.Add("PSSNTVJE", objEntidad.SNTVJE)
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_REGISTRAR_FLETE_RUTA", objParam)
        dblResultado = lobjSql.ParameterCollection("PNNCRRSR")

        'Catch ex As Exception
        '    Return -1
        'End Try
        Return dblResultado
    End Function

    Public Function Actualizar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Int32
        Dim intResultado As Int32 = 0
        Dim lobjSql As New SqlManager
        'Try

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNNRCTSL", objEntidad.NRCTSL)
        objParam.Add("PNNRTFSV", objEntidad.NRTFSV)
        objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
        objParam.Add("PSTOBSSR", objEntidad.TOBSSR)
        objParam.Add("PNCUBORI", objEntidad.CUBORI)
        objParam.Add("PNCLCLOR", objEntidad.CLCLOR)
        objParam.Add("PNCUBDES", objEntidad.CUBDES)
        objParam.Add("PNCLCLDS", objEntidad.CLCLDS)
        objParam.Add("PNITRSRT", objEntidad.ITRSRT)
        objParam.Add("PNCMNTRN", objEntidad.CMNTRN)
        objParam.Add("PNCMNLQT", objEntidad.CMNLQT)
        objParam.Add("PNILSFTR", objEntidad.ILSFTR)
        objParam.Add("PNILCFTR", objEntidad.ILCFTR)
        objParam.Add("PNILQFMX", objEntidad.ILQFMX)
        objParam.Add("PNILQSMT", objEntidad.ILQSMT)
        objParam.Add("PSCUNSRA", objEntidad.CUNSRA)
        objParam.Add("PNQDSTVR", objEntidad.QDSTVR)
        objParam.Add("PSSFCRTV", objEntidad.SFCRTV)
        objParam.Add("PSSSRVPG", objEntidad.SSRVPG)
        objParam.Add("PSSSRVCB", objEntidad.SSRVCB)
        objParam.Add("PSSSRVFE", objEntidad.SSRVFE)
        objParam.Add("PNCSTNDT", objEntidad.CSTNDT)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)
        objParam.Add("PNCSRCTZ", objEntidad.CSRCTZ)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)
        objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        objParam.Add("PSCUSCRT", ConfigurationWizard.UserName)
        objParam.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
        'RCS-HUNDRED-INICIO
        objParam.Add("PNCMNDTI", objEntidad.CMNDTI)
        objParam.Add("PNISRVTI", objEntidad.ISRVTI)
        'RCS-HUNDRED-FIN
        objParam.Add("PSSNTVJE", objEntidad.SNTVJE)
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        lobjSql.ExecuteNoQuery("SP_SOLMIN_SC_ACTUALIZAR_FLETE_RUTA", objParam)

        'Catch ex As Exception
        '    intResultado = -1
        'End Try
        Return intResultado
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidades.DetalleTarifaTipoFlete)

    End Sub
End Class

