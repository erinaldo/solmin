Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmNewTarifario
    Private oCliente As clsCliente
    Private oPlanta As clsPlanta
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oFiltro As SOLMIN_CTZ.Entidades.Filtro
    Private oTarifarioNeg As SOLMIN_CTZ.NEGOCIO.clsTarifario
    Private oTarifario As SOLMIN_CTZ.Entidades.Tarifario
    Private bolBuscar As Boolean

    Private Sub frmNewTarifario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oFiltro = New SOLMIN_CTZ.Entidades.Filtro
        oTarifario = New SOLMIN_CTZ.Entidades.Tarifario
        oTarifarioNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifario

        bolBuscar = False
        Cargar_Compania()
        Cargar_Moneda()
        Cargar_Division()
        bolBuscar = True
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        'cmbCompania.SelectedIndex = 0
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub Cargar_Moneda()
        oMoneda.Crea_Moneda()
        cmbMoneda.DataSource = oMoneda.Lista_Moneda_x_All(0)
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DisplayMember = "TMNDA"
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division_x_All(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
        End If
    End Sub

    Private Sub Cargar_Planta()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbPlanta.DataSource = oPlanta.Lista_Planta_Division(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
            cmbPlanta.ValueMember = "CPLNDV"
            bolBuscar = True
            cmbPlanta.DisplayMember = "TPLNTA"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If UcClienteGrupo.pCodigoGrupo = 0 Then
            HelpClass.MsgBox("Debe Seleccionar un Cliente")
            Exit Sub
        End If
        Crear_Tarifario()
    End Sub

    Private Sub Crear_Tarifario()
        Limpiar_Tarifario()
        Listar_Tarifas()
    End Sub

    Private Sub Listar_Tarifas()
        Try
            Dim oDt As DataTable
            Dim oDtTarifaFormato As New DataTable
            Dim oDr As DataRow
            Dim intCont As Integer
            Dim valorServicio As Double = 0D

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oFiltro.Parametro1 = Me.cmbCompania.SelectedValue.ToString.Trim
            oFiltro.Parametro2 = IIf(Me.cmbDivision.SelectedValue.ToString.Trim = "-1", "%", Me.cmbDivision.SelectedValue.ToString.Trim)
            oFiltro.Parametro3 = UcClienteGrupo.pCodigoGrupo
            oFiltro.Parametro4 = Me.cmbMoneda.SelectedValue.ToString.Trim
            oFiltro.Parametro5 = Me.cmbPlanta.SelectedValue.ToString.Trim

            oDt = oTarifarioNeg.Lista_Tarifario(oFiltro)

            oDtTarifaFormato.Columns.Add("NCNTRT")
            oDtTarifaFormato.Columns.Add("SERVICIO")
            oDtTarifaFormato.Columns.Add("TPLNTA")
            oDtTarifaFormato.Columns.Add("TARIFA")
            oDtTarifaFormato.Columns.Add("MONEDA")
            oDtTarifaFormato.Columns.Add("MONTO")
            oDtTarifaFormato.Columns.Add("DESTAR")
            oDtTarifaFormato.Columns.Add("TOBS")

            For intCont = 0 To oDt.Rows.Count - 1
                oDr = oDtTarifaFormato.NewRow
                valorServicio = oDt.Rows(intCont).Item("IVLSRV")
                oDr("NCNTRT") = oDt.Rows(intCont).Item("NCNTRT").ToString.Trim
                oDr("SERVICIO") = oDt.Rows(intCont).Item("SERVICIO").ToString.Trim
                oDr("TPLNTA") = oDt.Rows(intCont).Item("TPLNTA").ToString.Trim
                oDr("TARIFA") = Generar_Tarifa(oDt.Rows(intCont))
                oDr("MONEDA") = oDt.Rows(intCont).Item("TSGNMN").ToString.Trim
                oDr("MONTO") = Format(CType(valorServicio.ToString.Trim, Double), "###,###,###,##0.000")
                oDr("DESTAR") = Generar_Descripcion(oDt.Rows(intCont))
                oDr("TOBS") = oDt.Rows(intCont).Item("TOBS").ToString.Trim
                oDtTarifaFormato.Rows.Add(oDr)
            Next intCont
            dtgTarifario.AutoGenerateColumns = False
            dtgTarifario.DataSource = oDtTarifaFormato
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
        'Cargamos el Detalle
        ListarClienteGrupo()
    End Sub

    Private Sub ListarClienteGrupo()
        Dim oCliente As New SOLMIN_CTZ.NEGOCIO.clsCliente
        Dim dt As DataTable
        Try
            dt = oCliente.Busca_Cliente_Grupo(UcClienteGrupo.pCodigoGrupo)
            dtgClienteGrupo.AutoGenerateColumns = False
            dtgClienteGrupo.DataSource = dt
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Tarifario()
        Me.dtgTarifario.DataSource = Nothing
        Me.dtgClienteGrupo.Rows.Clear()
    End Sub

    Private Function Generar_Tarifa(ByVal poRow As DataRow) As String
        Dim strTarifa As String = ""
        Dim nValMin As Double = 0D
        Dim nValMax As Double = 0D
        Dim nValCte As Double = 0D
        With poRow
            nValCte = IIf(IsDBNull(.Item("VALCTE")), 0, .Item("VALCTE"))
            nValMin = IIf(IsDBNull(.Item("VALMIN")), 0, .Item("VALMIN"))
            nValMax = IIf(IsDBNull(.Item("VALMAX")), 0, .Item("VALMAX"))
            strTarifa = .Item("TSGNMN").ToString.Trim
            strTarifa = strTarifa & " " & Format(CType(.Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.000")
            If nValCte.ToString.Trim > 1 Then
                strTarifa = strTarifa & " por " & Format(CType(nValCte.ToString.Trim, Double), "###,###,###,##0")
            Else
                If nValCte.ToString.Trim = 1 And nValMin.ToString.Trim = 0 And nValMax.ToString.Trim = 0 Then
                    strTarifa = strTarifa & " por"
                End If
            End If
            If nValMin.ToString.Trim > 0 Then
                strTarifa = strTarifa & " de " & Format(CType(nValMin.ToString.Trim, Double), "###,###,###,##0")
            End If
            If nValMax.ToString.Trim > 0 Then
                strTarifa = strTarifa & " a " & Format(CType(nValMax.ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("MEDIDA").ToString.Trim <> "" Then
                strTarifa = strTarifa & " " & .Item("MEDIDA").ToString.Trim
            End If
            strTarifa = strTarifa & " " & .Item("DESRNG").ToString.Trim
            If .Item("STPTRA").ToString.Trim = "F" Then
                strTarifa = strTarifa & " (Fijo)"
            End If
        End With
        Return strTarifa
    End Function

    Private Function Generar_Descripcion(ByVal poRow As DataRow) As String
        Dim strConcepto As String = ""
        Dim nValMin As Double = 0D
        Dim nValMax As Double = 0D
        Dim nValCte As Double = 0D
        With poRow
            nValMin = IIf(IsDBNull(.Item("VALMIN")), 0, .Item("VALMIN"))
            nValMax = IIf(IsDBNull(.Item("VALMAX")), 0, .Item("VALMAX"))
            nValCte = IIf(IsDBNull(.Item("VALCTE")), 0, .Item("VALCTE"))
            If nValMin.ToString.Trim > 1 Then
                strConcepto = strConcepto & " por " & Format(CType(nValCte.ToString.Trim, Double), "###,###,###,##0")
            Else
                If nValCte.ToString.Trim = 1 And nValMin.ToString.Trim = 0 And nValMax.ToString.Trim = 0 Then
                    strConcepto = strConcepto & " por"
                End If
            End If
            If nValMin.ToString.Trim > 0 Then
                strConcepto = strConcepto & " de " & Format(CType(nValMin.ToString.Trim, Double), "###,###,###,##0")
            End If
            If nValMax.ToString.Trim > 0 Then
                strConcepto = strConcepto & " a " & Format(CType(nValMax.ToString.Trim, Double), "###,###,###,##0")
            End If
            If .Item("MEDIDA").ToString.Trim <> "" Then
                strConcepto = strConcepto & " " & .Item("MEDIDA").ToString.Trim
            End If
            strConcepto = strConcepto & " " & .Item("DESRNG").ToString.Trim
            If .Item("STPTRA").ToString.Trim = "F" Then
                strConcepto = strConcepto & " (Fijo)"
            End If
        End With
        Return strConcepto
    End Function

    Private Sub btnExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXLS.Click
        '----------------------------------------------------------
        Dim dtNuevo As DataTable = New DataTable
        Dim dtCopia As DataTable = New DataTable
        dtNuevo = dtgTarifario.DataSource
        dtCopia = dtNuevo.Copy
        '----------------------------------------------------------
        dtCopia.Columns("NCNTRT").ColumnName = "CONTRATO"
        dtCopia.Columns("TPLNTA").ColumnName = "PLANTA"
        dtCopia.Columns("DESTAR").ColumnName = "CONCEPTO"
        dtCopia.Columns("TOBS").ColumnName = "DESCRIPCION"
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dtCopia.Rows.Count > 1 Then
            Dim oDs As New DataSet
            dtCopia.TableName = "Tarifario"
            oDs.Tables.Add(dtCopia.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel_Generico(oDs, "TARIFARIO POR CLIENTES")
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class