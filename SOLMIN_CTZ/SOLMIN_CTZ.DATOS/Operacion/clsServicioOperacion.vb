Imports SOLMIN_CTZ.Entidades
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsServicioOperacion
    Public Function Lista_Servicios_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        lobjParams.Add("PNCCLNFC", oServicio.CCLNFC)
        lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
        lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        lobjParams.Add("FDCFCC_INI", oServicio.FDCFCC_INI)
        lobjParams.Add("FDCFCC_FIN", oServicio.FDCFCC_FIN)
        lobjParams.Add("FOPRCN_INI", oServicio.FOPRCN_INI)
        lobjParams.Add("FOPRCN_FIN", oServicio.FOPRCN_FIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_SERVICIO_DOCUMENTO", lobjParams)
        Return dt
    End Function

    Public Function Lista_Operacion_Servicio_Refactura(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        'lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        'lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        'lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
        'lobjParams.Add("PNFECFAC", Now.ToString("yyyyMMdd"))


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_SERVICIO_REFACTURA_V2", lobjParams)
        Return dt
    End Function

    Public Function Lista_Operacion_Refactura(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        'lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        'lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        'lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_REFACTURA_V2", lobjParams)
        Return dt
    End Function

    Public Function Lista_Servicios_Operacion_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
        lobjParams.Add("PNNCRRFC", oServicio.NCRRFC)
        lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_DOCUMENTO_REFACTURA", lobjParams)
        Return dt
    End Function

    Public Function Lista_Cuenta_Corriente_Refactura(ByVal oServicio As ServicioOperacion, ByRef Num_pag As Integer) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT_OP", oServicio.CCLNT)
        lobjParams.Add("PNCCLNT_FAC", oServicio.CCLNFC)
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNTIPO_PLANTA", oServicio.TIPO_PLANTA)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        lobjParams.Add("PNNDCCTC", oServicio.NDCFCC)
        lobjParams.Add("FDCFCC_INI", oServicio.FDCFCC_INI)
        lobjParams.Add("FDCFCC_FIN", oServicio.FDCFCC_FIN)
        lobjParams.Add("PAGESIZE", oServicio.PageSize)
        lobjParams.Add("PAGENUMBER", oServicio.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTACORRIENTE_REFACTURA_V3", lobjParams)


        Num_pag = lobjSql.ParameterCollection("PAGECOUNT")

        Return dt
    End Function

    Public Function Lista_Servicios_X_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNCCLNT", oServicio.CCLNT)
        'lobjParams.Add("PNNOPRCN", oServicio.NOPRCN)
        'lobjParams.Add("PNNCRRFC", oServicio.NCRRFC)
        lobjParams.Add("PNNDCFCC", oServicio.NDCFCC)
        lobjParams.Add("PNCTPODC", oServicio.CTPODC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIOS_X_DOCUMENTO_REFACTURA_V2", lobjParams)
        Return dt
    End Function


    Public Function Lista_Cuenta_Corriente_Refactura_Referencia(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCTPDCO", oServicio.CTPODC)
        lobjParams.Add("PNNDCMOR", oServicio.NDCFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTACORRIENTE_REFACTURA_REFERENCIA", lobjParams)
        Return dt
    End Function

    Public Function Verifica_Doc_Historial_Refactura(ByVal PNCTPODC As Decimal, ByVal PNNDCFCC As Decimal) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCTPODC", PNCTPODC)
        lobjParams.Add("PNNDCFCC", PNNDCFCC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VERIFICA_DOC_HISTORIAL_REFACTURA", lobjParams)
        Return dt
    End Function

    Public Function fdtLista_Consistencia_Facturacion_Tarifia_Fija(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("CCMPN", oServicio.CCMPN)
        lobjParams.Add("CDVSN", oServicio.CDVSN)
        lobjParams.Add("CPLNDV", oServicio.CPLNDV_STR)
        lobjParams.Add("CRGVTA", oServicio.CRGVTA)
        lobjParams.Add("CCLNT", oServicio.CCLNT)
        lobjParams.Add("FATNSR_D", oServicio.FATNSR_D)
        lobjParams.Add("FATNSR_A", oServicio.FATNSR_A)
        lobjParams.Add("IN_NRSRRB", oServicio.NRSRRB)
        lobjParams.Add("IN_NRRUBR", oServicio.NRRUBR)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_CONSISTENCIA_FACTURACION_TARIFA_FIJA", lobjParams)
        Return dt
    End Function

    Public Function fdtLista_Operaciones_Revisada(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNFECINI", oServicio.FOPRCN_INI)
        lobjParams.Add("PNFECFIN", oServicio.FOPRCN_FIN)
        lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_REVISADO", lobjParams)
        Return dt
    End Function
    Public Function fdsLista_Operaciones_Revisada_Exportar(ByVal oServicio As ServicioOperacion) As DataSet
        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNFECINI", oServicio.FOPRCN_INI)
        lobjParams.Add("PNFECFIN", oServicio.FOPRCN_FIN)
        lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
        dt = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_OPERACIONES_REVISADAS_PARA_EXPORTAR", lobjParams)
        Return dt
    End Function
    Public Function fdtLista_Operaciones_Facturadas_FM(ByVal oServicio As ServicioOperacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNFECINI", oServicio.FOPRCN_INI)
        lobjParams.Add("PNFECFIN", oServicio.FOPRCN_FIN)
        lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_FACTURADAS_FUERA_DEL_MES", lobjParams)
        Return dt
    End Function
    Public Function fdsLista_Operaciones_Facturadas_FM_Exportar(ByVal oServicio As ServicioOperacion) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicio.CCMPN)
        lobjParams.Add("PSCDVSN", oServicio.CDVSN)
        lobjParams.Add("PNFECINI", oServicio.FOPRCN_INI)
        lobjParams.Add("PNFECFIN", oServicio.FOPRCN_FIN)
        lobjParams.Add("PSCRGVTA", oServicio.CRGVTA)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_OPERACIONES_FACTURADAS_FUERA_MES_PARA_EXPORTAR", lobjParams)
        Return ds
    End Function
End Class
