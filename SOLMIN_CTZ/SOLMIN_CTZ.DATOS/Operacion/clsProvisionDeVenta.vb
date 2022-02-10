Imports SOLMIN_CTZ.Entidades
Imports Db2Manager.RansaData.iSeries.DataObjects
''' <summary>
''' Modified: Miguel Dagnino 19/10/2015
''' </summary>
''' <remarks></remarks>
Public Class clsProvisionDeVenta

    Inherits clsBase(Of ProvisionVenta)

    ''' <summary>
    ''' Lista de operaciones para provisionar
    ''' </summary>
    ''' <param name="oFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaOperacionesParaProvionar(ByVal oFiltro As ProvisionVenta) As List(Of ProvisionVenta)
        'Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
        lobjParams.Add("PNANIOMES", oFiltro.ANOMES)
        lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
        Dim oList As New List(Of ProvisionVenta)
        oList = Listar("SP_SOLMIN_CT_LISTA_OPERACION_REVISADAS_PARA_PROVISION", lobjParams)
        Return oList
        'Catch ex As Exception
        '    Return New List(Of ProvisionVenta)
        'End Try
    End Function



    Public Function fintGenerProvision(ByVal ocabProvision As ProvisionVenta, ByVal olstDetProvision As List(Of ProvisionVenta)) As Integer

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", ocabProvision.CCMPN)
            lobjParams.Add("PNANIOMES", ocabProvision.ANOMES)
            lobjParams.Add("PSCRGVTA", ocabProvision.CRGVTA)

            lobjParams.Add("PNCPLNDV", ocabProvision.CPLNDV)
            lobjParams.Add("PNCZNFCC", ocabProvision.CZNFCC)
            lobjParams.Add("PSCGRONG", ocabProvision.CGRONG)


            lobjParams.Add("PSUSUARIO", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
            lobjParams.Add("PNNMPRVT", 0, ParameterDirection.InputOutput)
            lobjParams.Add("PNRESULT", 0, ParameterDirection.InputOutput)


            Dim intNroProvision As Integer
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_GENERAR_PROVISION", lobjParams)
            ocabProvision.NMPRVT = lobjParams.Item(9).Value
            intNroProvision = ocabProvision.NMPRVT
            If lobjParams.Item(10).Value < 1 Then
                Return lobjParams.Item(10).Value
            End If


            'Guardamos el detalle
            Try
                For Each odetProvision As ProvisionVenta In olstDetProvision
                    lobjParams = New Parameter
                    lobjParams.Add("PSCCMPN", odetProvision.CCMPN)
                    lobjParams.Add("PNNMPRVT", ocabProvision.NMPRVT)
                    lobjParams.Add("PSTPOPER", odetProvision.TPOPER)
                    lobjParams.Add("PNNOPRCN", odetProvision.NOPRCN)
                    lobjParams.Add("PNNCRROP", odetProvision.NCRROP)
                    lobjParams.Add("PNNGUITR", odetProvision.NGUITR)
                    lobjParams.Add("PNNCRRGU", odetProvision.NCRRGU)
                    lobjParams.Add("PNNSECFC", odetProvision.NSECFC)
                    lobjParams.Add("PNFSECFC", odetProvision.FSECFC)
                    lobjParams.Add("PNCMNDA1", odetProvision.CMNDA1)
                    lobjParams.Add("PNIVLSRV", odetProvision.IVLSRV)
                    lobjParams.Add("PNITTPRS", odetProvision.ITTPRS)
                    lobjParams.Add("PNITPCMT", odetProvision.ITPCMT)


                    lobjParams.Add("PNNLQDCN", odetProvision.NLQDCN)
                    lobjParams.Add("PNCMNDPG", odetProvision.CMNDPG)
                    lobjParams.Add("PNIMPPGO", odetProvision.IMPPGO)
                    lobjParams.Add("PNITPGSL", odetProvision.ITPGSL)

                    lobjParams.Add("PSSESTOP", odetProvision.SESTOP)
                    lobjParams.Add("PNCSRVC", odetProvision.CSRVC)


                    lobjParams.Add("PNCCLNFC", odetProvision.CCLNFC)
                    lobjParams.Add("PSCDVSN", odetProvision.CDVSN)
                    lobjParams.Add("PNCPLNDV", odetProvision.CPLNDV)
                    lobjParams.Add("PNCCNTCS", odetProvision.CCNTCS)
              

                    lobjParams.Add("PNCMNDTI", odetProvision.CMNDTI)
                    lobjParams.Add("PNISRVTI", odetProvision.ISRVTI)
                    lobjParams.Add("PNITTISL", odetProvision.ITTISL)
                    lobjParams.Add("PNCCNTBN", odetProvision.CCNTBN)
                    lobjParams.Add("PNCENCO2", odetProvision.CENCO2)
                    lobjParams.Add("PNCENCOS", odetProvision.CENCOS)
                    lobjParams.Add("PNCTPODC", odetProvision.CTPODC)
                    lobjParams.Add("PNNDCFCC", odetProvision.NDCFCC)
                    lobjParams.Add("PNFDCFCC", odetProvision.FDCFCC)
                    lobjParams.Add("PNNCRDCC", odetProvision.NCRDCC)
                    lobjParams.Add("PNNORINS", odetProvision.NORINS) 'CSR-HUNDRED-hotfix/281016_Proceso_De_Venta
                    
                    If odetProvision.CHK Then
                        lobjParams.Add("PSSESTRG", "A")
                    Else
                        lobjParams.Add("PSSESTRG", "*")
                    End If
                    lobjParams.Add("PSUSUARIO", ConfigurationWizard.UserName)
                    lobjParams.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)

                    lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_GENERAR_DETALLE_PROVISION", lobjParams)
                Next
            Catch ex As Exception
                fintGeneRollbackProvision(ocabProvision)
                Return -1
            End Try
            Return intNroProvision
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Public Function fintGeneRollbackProvision(ByVal ocabProvision As ProvisionVenta) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try

            lobjParams.Add("PSCCMPN", ocabProvision.CCMPN)
            lobjParams.Add("PNNMPRVT", ocabProvision.NMPRVT)
            lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_GENERAR_ROLLBACK_PROVISION", lobjParams)
            Return 1
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Public Function fdtListaProviones(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
        lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
        lobjParams.Add("PNANIOMES", oFiltro.ANIOMES)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_PROVISION", lobjParams)
        Return dt
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    Public Function fdtDetalleProviones(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
        lobjParams.Add("PNNMPRVT", oFiltro.NMPRVT)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DETALLE_PROVISION", lobjParams)
        Return dt
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function


    Public Function fdtListaOperacionesProvionadas_CeBe(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
        lobjParams.Add("PNNMPRVT", oFiltro.NMPRVT)
        lobjParams.Add("PNCCNTCS", oFiltro.CCNTCS)
        lobjParams.Add("PNCCLNFC", oFiltro.CCLNFC)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_PROVISION_CB", lobjParams)
        Return dt
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function


    Public Function fIntObtenerUltimoControl() As Decimal
        Dim ultimoControl As Decimal = 0
        Dim tipoControl As String
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim coleccionParametros As New Hashtable
        'Try
        tipoControl = "EZPRV1"
        lobjParams.Add("PSCTPCTR", tipoControl)
        lobjParams.Add("PNNULCTR", 0, ParameterDirection.InputOutput)

        lobjSql.ExecuteNoQuery("SP_SOLMIN_CT_OBTENER_ULTIMO_CONTROL", lobjParams)

        coleccionParametros = lobjSql.ParameterCollection()

        ultimoControl = Convert.ToDecimal(coleccionParametros.Item("PNNULCTR"))

        Return ultimoControl
        'Catch ex As Exception
        '    Return ultimoControl
        'End Try
    End Function

#Region "Reversión Provisión"
    Public Function fdtListaReversionProvision(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
            lobjParams.Add("PNANIOMES", oFiltro.ANIOMES)

            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_REVERSION_PROVISION", lobjParams)
            Return dt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function


    Public Function fdtDetalleReversionProvion(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PNNMPRVT", oFiltro.NMRVVT)

            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_DETALLE_REVERSION_PROVISION", lobjParams)
            Return dt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function



    Public Function fdtListaOperacionesRevertidas_CeBe(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PNNMRVVT", oFiltro.NMRVVT)
            lobjParams.Add("PNCCNTCS", oFiltro.CCNTCS)
            lobjParams.Add("PNCCLNFC", oFiltro.CCLNFC)
            lobjParams.Add("PNANIOMES", oFiltro.ANIOMES)

            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_REVERTIDAS_CB", lobjParams)
            Return dt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function fdsListaProvisionesExportar(ByVal oFiltro As ProvisionVenta) As DataSet
        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
            lobjParams.Add("PNANIOMES", oFiltro.ANIOMES)

            dt = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_PROVISIONES_PARA_EXPORTAR", lobjParams)


            Return dt
        Catch ex As Exception
            Return New DataSet
        End Try
    End Function


    Public Function fdsListaProvisionesExportarCAT(ByVal oFiltro As ProvisionVenta) As DataSet
        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
            lobjParams.Add("PNANOMES", oFiltro.ANIOMES)

            dt = lobjSql.ExecuteDataSet("SP_SOLMIN_LISTA_PROVISION_CAT_EXPORTAR", lobjParams)


            Return dt
        Catch ex As Exception
            Return New DataSet
        End Try
    End Function

    Public Function fdsListaReversionesExportar(ByVal oFiltro As ProvisionVenta) As DataSet
        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", oFiltro.CCMPN)
            lobjParams.Add("PSCRGVTA", oFiltro.CRGVTA)
            lobjParams.Add("PNANIOMES", oFiltro.ANIOMES)

            dt = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_REVERSIONES_PARA_EXPORTAR", lobjParams)
            Return dt
        Catch ex As Exception
            Return New DataSet
        End Try
    End Function
#End Region

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidades.ProvisionVenta)

    End Sub

    'INI-ECM-Estimación-de-Ingreso-Anulación[RF001]
    Public Function ValidarAnulacionProvision(ByVal parametros As ProvisionVenta) As Integer
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        Dim hashtable As New Hashtable

        parameter.Add("PSCCMPN", parametros.CCMPN)
        parameter.Add("PNNMPRVT ", parametros.NMPRVT)
        parameter.Add("PNRESULT", 0, ParameterDirection.InputOutput)

        sqlManager.ExecuteNoQuery("SP_SOLMIN_CT_VALIDAR_ANULACION_PROVISION", parameter)
        hashtable = sqlManager.ParameterCollection()

        Return hashtable.Item("PNRESULT")
    End Function

    Public Sub AnularProvision(ByVal parametros As ProvisionVenta)
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PSCCMPN", parametros.CCMPN)
        parameter.Add("PNNMPRVT", parametros.NMPRVT)
        parameter.Add("PSUSUARIO", parametros.PSUSUARIO)
        parameter.Add("PSNTRMCR", parametros.NTRMCR)

        sqlManager.ExecuteNoQuery("SP_SOLMIN_CT_ANULAR_PROVISION", parameter)
    End Sub

    Public Function ObtenerListaProvisiones(ByVal parametros As ProvisionVenta) As List(Of RequestDataReversion)
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        Dim dataTable As New DataTable
        Dim request As New List(Of RequestDataReversion)

        parameter.Add("PSCCMPN", parametros.CCMPN)
        parameter.Add("PNNMRVVT", parametros.NMRVVT)

        dataTable = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_REVERSION_PENDIENTE_ENVIO_SAP", parameter)

        For Each row As DataRow In dataTable.Rows
            Dim itemRequest As New RequestDataReversion

            With itemRequest
                .IDESTM = Decimal.Parse(row("IDESTM"))
                .NDESAP = row("NDESAP")
                .CSCDSP = ("" & row("CSCDSP")).ToString.Trim
                .ACNTSP = Decimal.Parse(row("ACNTSP"))
                .NDCCTE = row("NDCCTE")
                .FDCFCC = Decimal.Parse(row("FDCFCC"))
            End With

            request.Add(itemRequest)
        Next

        Return request
    End Function



    'FIN-ECM-Estimación-de-Ingreso-Anulación[RF001]
End Class
