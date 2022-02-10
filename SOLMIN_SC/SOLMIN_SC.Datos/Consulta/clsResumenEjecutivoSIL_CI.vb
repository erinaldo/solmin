Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsResumenEjecutivoSIL_CI
    Private _dtCIProveedor As New DataTable
    Private _dtCIPais As New DataTable
    Private _dtCIIncoterms As New DataTable
    Private _dtCIAgenteCarga As New DataTable
    Private _dlbTotalOC As Double

    Public Property dlbTotalOC() As Double
        Get
            Return _dlbTotalOC
        End Get
        Set(ByVal value As Double)
            _dlbTotalOC = value
        End Set
    End Property

    Public Property dtCIProveedor() As DataTable
        Get
            Return _dtCIProveedor
        End Get
        Set(ByVal value As DataTable)
            _dtCIProveedor = value
        End Set
    End Property

    Public Property dtCIPais() As DataTable
        Get
            Return _dtCIPais
        End Get
        Set(ByVal value As DataTable)
            _dtCIPais = value
        End Set
    End Property
    Public Property dtCIIncoterms() As DataTable
        Get
            Return _dtCIIncoterms
        End Get
        Set(ByVal value As DataTable)
            _dtCIIncoterms = value
        End Set
    End Property

    Public Property dtCIAgenteCarga() As DataTable
        Get
            Return _dtCIAgenteCarga
        End Get
        Set(ByVal value As DataTable)
            _dtCIAgenteCarga = value
        End Set
    End Property

    Private Function ConvertTotable(ByVal drr() As DataRow, ByVal odtDato As DataTable)
        Dim dt As New DataTable
        dt = odtDato.Clone
        For Each dr As DataRow In drr
            dt.ImportRow(dr)
        Next
        dt.AcceptChanges()
        Return dt
    End Function

    Public Sub New()
        'Crea la Structura de los DataTables
        _dtCIPais.Columns.Add("PAIS", System.Type.GetType("System.String"))
        _dtCIPais.Columns.Add("NRO OC", System.Type.GetType("System.Int32"))

        _dtCIIncoterms.Columns.Add("INCOTERMS", System.Type.GetType("System.String"))
        _dtCIIncoterms.Columns.Add("NRO OC", System.Type.GetType("System.Int32"))

        _dtCIAgenteCarga.Columns.Add("AGENTE DE CARGA", System.Type.GetType("System.String"))
        _dtCIAgenteCarga.Columns.Add("NRO OC", System.Type.GetType("System.Int32"))


    End Sub

    Private Sub GetProveedor_OC_DiasPromedio(ByVal dt As DataTable)

        _dtCIProveedor.Columns.Add("PROVEEDOR", System.Type.GetType("System.String"))
        _dtCIProveedor.Columns.Add("DIA", System.Type.GetType("System.Decimal"))
        _dtCIProveedor.Columns.Add("OC", System.Type.GetType("System.Int32"))


        dt.Columns.Add("ESTADO", System.Type.GetType("System.String"))
        dt.Columns.Add("DIA", System.Type.GetType("System.Decimal"))

        For Each dr As DataRow In dt.Rows
            If (dr("CHK_CI_100_REAL") <> 0 AndAlso dr("CHK_CI_102_REAL") <> 0) Then
                Dim intDiferencia As Integer = 0
                Dim strFechaOC As String = FechaNum_a_Fecha(dr("CHK_CI_100_REAL"))
                Dim strFechaProv As String = FechaNum_a_Fecha(dr("CHK_CI_102_REAL"))

                If IsDate(strFechaOC) AndAlso IsDate(strFechaOC) Then
                    intDiferencia = DateDiff(DateInterval.Day, CDate(strFechaProv), _
                                                   CDate(strFechaOC))
                Else
                    intDiferencia = 0
                End If

                If intDiferencia > 0 Then
                    dr("DIA") = intDiferencia
                Else
                    dr("DIA") = 0
                End If
                dr("ESTADO") = "A"
            Else

                dr("DIA") = 0
                dr("ESTADO") = "*"
            End If
        Next

        'Recorrido
        Dim drResumen As DataRow = Nothing
        Dim dtProv As DataTable
        Dim SumDias As Decimal = 0
        Dim Promedio As Decimal = 0
        Dim TotalPre As Integer = 0
        Dim TotalOC As Integer = 0
        Dim dtOC As DataTable
        Dim drProv As DataRow = Nothing
        Dim drOC As DataRow = Nothing

        'Ordenado por Proveedor, OrdenCompra, NroPreEmbarque
        Dim dw As New DataView(dt.Copy)
        dw.Sort = "TPRVCL , NORCML , NRPEMB ASC"
        dt = dw.ToTable()

        For i As Integer = 0 To dt.Rows.Count - 1
            ' For Each drProv As DataRow In dt.Rows
            drProv = dt.Rows(i)
            dtProv = New DataTable
            dtProv = ConvertTotable(dt.Select("TPRVCL = '" & drProv("TPRVCL").ToString.Trim & "'"), dt)

            If dtProv.Rows.Count > 0 Then
                drResumen = _dtCIProveedor.NewRow()
                drResumen("PROVEEDOR") = drProv("TPRVCL")
                _dtCIProveedor.Rows.Add(drResumen)
            End If

            For j As Integer = 0 To dtProv.Rows.Count - 1
                'For Each drOC As DataRow In dtProv.Rows
                drOC = dtProv.Rows(j)
                dtOC = New DataTable
                SumDias = 0
                TotalOC = 0
                dtOC = ConvertTotable(dtProv.Select("NORCML = '" & drOC("NORCML").ToString.Trim & "'"), dtProv)

                If dtOC.Rows.Count > 0 Then
                    SumDias = Val("" & dtOC.Compute("SUM(DIA)", "ESTADO = 'A'"))
                    TotalPre = Val("" & dtOC.Compute("COUNT(NRPEMB)", "ESTADO = 'A'"))

                    If TotalPre > 0 Then
                        Promedio = SumDias / TotalPre
                    Else
                        Promedio = 0
                    End If

                    drResumen("OC") = Val("" & drResumen("OC")) + 1
                    drResumen("DIA") = Math.Round( _
                              Val("" & drResumen("DIA")) + Promedio, 2, MidpointRounding.AwayFromZero)

                    _dtCIProveedor.AcceptChanges()

                Else
                    _dtCIProveedor.Rows.Remove(drResumen)
                    _dtCIProveedor.AcceptChanges()
                End If

                j = j + dtOC.Rows.Count - 1
            Next

            If drResumen("OC") > 0 Then
                drResumen("DIA") = drResumen("DIA") / drResumen("OC")
                _dtCIProveedor.AcceptChanges()
            Else
                drResumen("DIA") = 0
                _dtCIProveedor.AcceptChanges()
            End If
            i = i + dtProv.Rows.Count - 1

        Next


    End Sub


    Private Sub GetGrupo_OC(ByVal dt As DataTable, ByVal dtResult As DataTable, ByVal strGrupo As String)
        'Ordenado por Incoterms
        Dim drGrupo, drResumen As DataRow
        Dim dtGrupo As DataTable
        Dim dw As New DataView(dt.Copy)
        dw.Sort = strGrupo & " , NORCML ASC"
        dt = dw.ToTable(True, strGrupo, "NORCML")
        For i As Integer = 0 To dt.Rows.Count - 1
            drGrupo = dt.Rows(i)
            dtGrupo = New DataTable
            dtGrupo = ConvertTotable(dt.Select(strGrupo & " = '" & drGrupo(strGrupo).ToString & "'"), dt)
            drResumen = dtResult.NewRow()
            drResumen(0) = drGrupo(strGrupo)
            drResumen(1) = dtGrupo.Rows.Count
            dtResult.Rows.Add(drResumen)
            i = i + dtGrupo.Rows.Count - 1
        Next

    End Sub

    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function

    Public Sub Calculardatos(ByVal pobjFiltro As beResumenEjecutivo)
        Dim dt As New DataTable
        dt = Lista_Datos_Carga_Internacional(pobjFiltro)
        'Total de Ordenes de Compra
        Me.SetTotalOC(dt.Copy)
        Me.GetProveedor_OC_DiasPromedio(dt.Copy)
        'Pais
        Me.GetGrupo_OC(dt.Copy, Me._dtCIPais, "TCMPPS")
        'Incoterms
        Me.GetGrupo_OC(dt.Copy, Me._dtCIIncoterms, "TTINTC")
        'Agente de Carga
        Me.GetGrupo_OC(dt.Copy, Me._dtCIAgenteCarga, "TNMAGC_EMB")

    End Sub

    Private Sub SetTotalOC(ByVal dt As DataTable)
        Dim dw As New DataView(dt)
        _dlbTotalOC = dw.ToTable(True, "NORCML").Rows.Count
    End Sub

    Private Function Lista_Datos_Carga_Internacional(ByVal pobjFiltro As beResumenEjecutivo) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.PSCCMPN)
        lobjParams.Add("PNCCLNT", pobjFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI", pobjFiltro.PNFECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_ITEMS_X_ORDEN_COMPRA_PARCIAL_INDICADOR", lobjParams)
        dt.TableName = "dtCargaInternacional"
        lobjSql.Dispose()
        lobjSql = Nothing
        Return dt.Copy
    End Function
End Class
