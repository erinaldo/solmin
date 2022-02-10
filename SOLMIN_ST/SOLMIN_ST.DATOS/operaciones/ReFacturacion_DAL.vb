Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace Operaciones
  Public Class ReFacturacion_DAL

    Public Function Listar_Operaciones_Liquidadas(ByVal param As Hashtable) As DataTable
      Dim objSql As New SqlManager
      Dim objParamtero As New Parameter
      Dim dtQuery As New DataTable
      Try
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PSCPLNDV", param("PNCPLNDV"))
        objParamtero.Add("PNCCLNT", param("PNCCLNT"))
        objParamtero.Add("PNCTPDCF", param("PNCTPDCF"))
        objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
        objParamtero.Add("PNFECINI", param("PNFECINI"))
        objParamtero.Add("PNFECFIN", param("PNFECFIN"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_OS_FACTURADAS", objParamtero)
      Catch ex As Exception
      End Try
      Return dtQuery
        End Function
        Public Sub Insertar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable)
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter

            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))
                objParamtero.Add("PNCMNDA", param("PNCMNDA"))
                objParamtero.Add("PNIVNTA", param("PNIVNTA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_IMPORTES_X_OPERACIONES_FACTURADAS", objParamtero)
            Catch ex As Exception
            End Try

        End Sub
        Public Sub Eliminar_Servicios_A_ReFacturar(ByVal param As Hashtable)
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter

            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_SERVICIOS_A_REFACTURAR", objParamtero)
            Catch ex As Exception
            End Try

        End Sub
        Public Function Listar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            Try
                objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objParamtero.Add("PNCTPDFC", param("PNCTPDFC"))
                objParamtero.Add("PNCMNDA1", param("PNCMNDA1"))
                objParamtero.Add("PNFECFAC", param("PNFECFAC"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_IMPORTES_X_OPERACIONES_FACTURADAS", objParamtero)
            Catch ex As Exception
            End Try
            Return dtQuery
        End Function
    Public Function Listar_Guias_X_Operaciones(ByVal param As Hashtable) As DataTable
      Dim objSql As New SqlManager
      Dim objParamtero As New Parameter
      Dim dtQuery As New DataTable
      Try
                ' objParamtero.Add("PNNOPRCN", param("PNNOPRCN"))
        objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNCPLNDV", param("PNCPLNDV"))


        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_REMISION_X_OPERACION_FACTURADAS", objParamtero)
      Catch ex As Exception

      End Try
      Return dtQuery
    End Function
    Public Function Listar_Documentos_Emitidos_x_Operacion(ByVal param As Hashtable) As DataTable
      Dim objSql As New SqlManager
      Dim objParamtero As New Parameter
      Dim dtQuery As New DataTable
      Try
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNOPRCN", param("PNNOPRCN"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DOCUMENTOS_EMITIDOS_X_OPERACION", objParamtero)
      Catch ex As Exception
      End Try
      Return dtQuery
        End Function


    Public Function Traer_Importe_Refactura(ByVal param As Hashtable) As DataTable
      Dim objSql As New SqlManager
      Dim objParamtero As New Parameter
      Dim dtImporte As New DataTable
      Try
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                'objParamtero.Add("PNCTPODC_FC", param("PNCTPODC_FC"))
                'objParamtero.Add("PNCTPODC_RF", param("PNCTPODC_RF"))
        ' objParamtero.Add("PNITCALC", param("PNITCALC"), ParameterDirection.Output)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        dtImporte = objSql.ExecuteDataTable("SP_SOLMIN_ST_TRAER_IMPORTE_REFACTURA", objParamtero)
        'dblImporte = objSql.ParameterCollection("PNITCALC")
      Catch ex As Exception
      End Try
      Return dtImporte
    End Function

    Public Function Listar_Operaciones_Nota_Credito(ByVal param As Hashtable) As DataTable
      Dim objSql As New SqlManager
      Dim objParamtero As New Parameter
      Dim dtQuery As New DataTable
      Try
        objParamtero.Add("PSNOPRCN", param("PSNOPRCN"))
        objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        objParamtero.Add("PNCTPDCF", param("PNCTPDCF"))
        objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_NOTA_CREDITO", objParamtero)
      Catch ex As Exception
      End Try
      Return dtQuery
        End Function


#Region "RefacturacionElectronica"

        Public Function Lista_Cuenta_Corriente_Refactura(ByVal param As Hashtable, ByRef Num_pag As Integer) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtQuery As New DataTable
            'Try
            'objParamtero.Add("PNCCLNT_OP", param("PNCCLNT_OP"))
            objParamtero.Add("PNCCLNT_FAC", param("PNCCLNT_FAC"))
            objParamtero.Add("PSCCMPN", param("PSCCMPN"))
            objParamtero.Add("PSCDVSN", param("PSCDVSN"))
            'objParamtero.Add("PNTIPO_PLANTA", param("PNTIPO_PLANTA"))
            objParamtero.Add("PNCTPODC", param("PNCTPODC"))
            objParamtero.Add("PNNDCCTC", param("PNNDCCTC"))
            objParamtero.Add("PNFECINI", param("PNFECINI"))
            objParamtero.Add("PNFECFIN", param("PNFECFIN"))

            objParamtero.Add("PAGESIZE", param("PAGESIZE"))
            objParamtero.Add("PAGENUMBER", param("PAGENUMBER"))
            objParamtero.Add("PAGECOUNT", 0, ParameterDirection.Output)

            objParamtero.Add("PSESTSUN", IIf(param("PSESTSUN") = "S", "", param("PSESTSUN")))
            objParamtero.Add("PSSESTRG", param("PSSESTRG"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CUENTACORRIENTE_REFACTURA", objParamtero)

            Num_pag = objSql.ParameterCollection("PAGECOUNT")

            Return dtQuery
        End Function


        'Public Function Listar_Operaciones_Servicio_X_Documento(ByVal param As Hashtable) As DataTable
        '    Dim objSql As New SqlManager
        '    Dim objParamtero As New Parameter
        '    Dim dtQuery As New DataTable
        '    'Try
        '    objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        '    objParamtero.Add("PSCDVSN", param("PSCDVSN"))
        '    objParamtero.Add("PNCTPODC", param("PNCTPODC"))
        '    objParamtero.Add("PNNDCCTC", param("PNNDCCTC"))
        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        '    dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_SERVICIO_FACTURADAS", objParamtero)
        '    'Catch ex As Exception
        '    'End Try
        '    Return dtQuery
        'End Function


        Public Function Listar_SegHistorial_Documento_Refactura(ByVal param As Hashtable) As DataSet
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dsQuery As New DataSet
            'Try
            objParamtero.Add("PSCCMPN", param("PSCCMPN"))
            objParamtero.Add("PSCDVSN", param("PSCDVSN"))
            objParamtero.Add("PNCTPODC", param("PNCTPODC"))
            objParamtero.Add("PNNDCCTC", param("PNNDCCTC"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            dsQuery = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_SEGHISTORIAL_DOCUMENTO", objParamtero)
            'Catch ex As Exception
            'End Try

            For Each Item As DataRow In dsQuery.Tables(0).Rows
                Item("FECFAC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(Item("FECFAC"))
            Next
            For Each Item As DataRow In dsQuery.Tables(2).Rows
                Item("FE_CNTA_CNTE") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(Item("FE_CNTA_CNTE"))
                Item("FDCMOR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(Item("FDCMOR"))
                Item("FDCMOR_OP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(Item("FDCMOR_OP"))
            Next

            Return dsQuery
        End Function



        'Public Function Lista_Cuenta_Corriente_Refactura_Referencia(ByVal param As Hashtable) As DataTable
        '    Dim objSql As New SqlManager
        '    Dim objParamtero As New Parameter
        '    Dim dtQuery As New DataTable
        '    'Try
        '    objParamtero.Add("PNCTPODC", param("PNCTPODC"))
        '    objParamtero.Add("PNNDCCTC", param("PNNDCCTC"))

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        '    dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CUENTACORRIENTE_REFACTURA_REFERENCIA", objParamtero)
        '    'Catch ex As Exception
        '    'End Try
        '    Return dtQuery
        'End Function



        'Public Function Lista_CtaCte_Venta(ByVal param As Hashtable) As DataTable
        '    Dim objSql As New SqlManager
        '    Dim objParamtero As New Parameter
        '    Dim dtQuery As New DataTable
        '    'Try
        '    objParamtero.Add("PSCCMPN", param("PSCCMPN"))
        '    objParamtero.Add("PNCTPODC", param("PNCTPODC"))
        '    objParamtero.Add("PNNDCCTC", param("PNNDCCTC"))

        '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
        '    dtQuery = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CTACTE_VENTAS", objParamtero)
        '    'Catch ex As Exception
        '    'End Try
        '    Return dtQuery
        'End Function


        Public Function Lista_Dato_General_Documento(ByVal param As Hashtable) As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Dim dt As New DataTable
            lobjParams.Add("PSCCMPN", param("PSCCMPN"))
            lobjParams.Add("PNCTPODC", param("PNCTPODC"))
            lobjParams.Add("PNNDCCTC", param("PNNDCCTC"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_DATO_CUENTA_CORRIENTE_GENERAL", lobjParams)
            Return dt
        End Function



        Public Function Verifica_Doc_Historial_Refactura(ByVal PNCTPODC As Decimal, ByVal PNNDCFCC As Decimal) As DataTable
            Dim dt As New DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCTPODC", PNCTPODC)
            lobjParams.Add("PNNDCFCC", PNNDCFCC)
            'lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VERIFICA_DOC_HISTORIAL_REFACTURA", lobjParams)
            Return dt
        End Function


        Public Function Grabar_Historial_Documento_Cabecera(ByVal param As Object) As Decimal
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", param.PSCCMPN)
            lobjParams.Add("PNCCLNT", param.PNCCLNT)
            lobjParams.Add("PNNOPRCN", param.PNNOPRCN)
            lobjParams.Add("PNCTPODC", param.PNCTPODC)
            lobjParams.Add("PNNDCFCC", param.PNNDCFCC)
            lobjParams.Add("PNFDCFCC", param.PNFDCFCC)
            lobjParams.Add("PNCMNDA1", param.PNCMNDA1)
            lobjParams.Add("PNIVLSRV", param.PNIVLSRV)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
            lobjParams.Add("PNNCRRFC", 0, ParameterDirection.Output)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_CABECERA", lobjParams)
            Return lobjSql.ParameterCollection("PNNCRRFC")
        End Function

        Public Sub Grabar_Historial_Documento_Detalle(ByVal param As Object)
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", param.PSCCMPN)
            lobjParams.Add("PNCCLNT", param.PNCCLNT)
            lobjParams.Add("PNNOPRCN", param.PNNOPRCN)
            lobjParams.Add("PNNCRRFC", param.PNNCRRFC)
            lobjParams.Add("PNNCRROP", param.PNNCRROP)
            lobjParams.Add("PNNRTFSV", param.PNNRTFSV)
            lobjParams.Add("PNQATNAN", param.PNQATNAN)
            lobjParams.Add("PSCUNDMD", param.PSCUNDMD)
            lobjParams.Add("PNIVLSRV", param.PNIVLSRV)
            lobjParams.Add("PNNCRDCC", param.PNNCRDCC)
            lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHRACRT", Format(Now, "HHmmss"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_GRABAR_HISTORIAL_REFACTURA_DETALLE", lobjParams)
        End Sub

        Public Function Lista_Operacion_Refactura(ByVal oServicio As Hashtable) As DataTable
            Dim dt As New DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio("PSCCMPN"))
            lobjParams.Add("PSCDVSN", oServicio("PSCDVSN"))
            lobjParams.Add("PNCCLNT", oServicio("PNCCLNT"))
            lobjParams.Add("PNNOPRCN", oServicio("PNNOPRCN"))
            lobjParams.Add("PNCTPODC", oServicio("PNCTPODC"))
            lobjParams.Add("PNNDCFCC", oServicio("PNNDCFCC"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oServicio("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_REFACTURA_V2", lobjParams)
            Return dt
        End Function

        Public Function Lista_Operacion_Servicio_Refactura(ByVal oServicio As Hashtable) As DataTable
            Dim dt As New DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", oServicio("PSCCMPN"))
            lobjParams.Add("PSCDVSN", oServicio("PSCDVSN"))
            lobjParams.Add("PNCTPODC", oServicio("PNCTPODC"))
            lobjParams.Add("PNNDCFCC", oServicio("PNNDCCTC"))
            lobjParams.Add("PSCMNDA1", oServicio("TIPMONE"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oServicio("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS_NOTAS_GENERAL", lobjParams)
            Return dt
        End Function

        Public Function Lista_Motivos_Notas(ByVal param As Hashtable) As DataTable
            Dim dt As New DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSCCMPN", param("PSCCMPN"))
            lobjParams.Add("PNCTPODC", param("PNCTPODC"))
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_MOTIVOS_NOTAS", lobjParams)
            Return dt
        End Function


        Public Function Traer_Importe_Refactura_E(ByVal param As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim objParamtero As New Parameter
            Dim dtImporte As New DataTable
            Try
                objParamtero.Add("PSCCMPN", param("PSCCMPN"))
                objParamtero.Add("PSCDVSN", param("PSCDVSN"))
                objParamtero.Add("PNNDCMFC", param("PNNDCMFC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(param("PSCCMPN"))
                dtImporte = objSql.ExecuteDataTable("SP_SOLMIN_ST_TRAER_IMPORTE_REFACTURA_GENERAL", objParamtero)
                'dblImporte = objSql.ParameterCollection("PNITCALC")
            Catch ex As Exception
            End Try
            Return dtImporte
        End Function

        Public Function Lista_Detalle_Servicios_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                lobjParams.Add("PNNDCMFC", objParametro("PNNDCMFC"))
                lobjParams.Add("PSCMNDA1", objParametro("PSCMNDA"))
                lobjParams.Add("PNFECFAC", objParametro("PNFECFAC"))
                lobjParams.Add("PNFATNSR", objParametro("PNFATNSR"))
                lobjParams.Add("PNCTPODC", objParametro("PNCTPODC"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                'dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_FACTURA_DETALLE_SERVICIOS_PRUEBA", lobjParams)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REFACTURA_DETALLE_SERVICIOS_NOTAS", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try

            Return dt
        End Function


        Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
            Dim objSql As New SqlManager
            Dim dt As DataTable
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PNCMNDA1", objParametro("PNCMNDA1"))
                lobjParams.Add("PNFCMBO", objParametro("PNFCMBO"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_TIPO_CAMBIO", lobjParams)
            Catch ex As Exception
                dt = Nothing
            End Try
            Return dt
        End Function


        Public Function Lista_Region_Venta_X_Operacion(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PNNOPRCN", objParametro("PNNOPRCN"))
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REGION_VENTA_X_OPERACION", lobjParams)
            Return dt
        End Function

        Public Function Lista_Giro_Negocio(ByVal objParametro As Hashtable) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", objParametro("PSCCMPN"))
            lobjParams.Add("PSCDVSN", objParametro("PSCDVSN"))
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_FACTURA_GIRO_NEGOCIO", lobjParams)
            Return dt
        End Function

#End Region


  End Class

End Namespace


