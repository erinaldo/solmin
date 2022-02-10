Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmFacturacionSIL
    Private frmInformacion As New dialogoInformacion
    Private oFacturacionSIL As New SOLMIN_CTZ.Entidades.FacturaSIL
    Private oFacturacionSIL_Detalle As New SOLMIN_CTZ.Entidades.FacturaSIL
    Private oFacturacionSILNeg As New SOLMIN_CTZ.NEGOCIO.clsFacturaSIL
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private bolBuscar As Boolean
    Private bolPaginar As Boolean = False
    Private bolIniciaCarga As Boolean = True
    Private oDtGlobal As New DataTable

    Private Sub frmFacturacionSIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        Cargar_Compania()
        Cargar_Division()
        Cargar_Cliente()
        Carga_Mes_Actual()
        Ocultar_Controles()
    End Sub
#Region "Comun"
    Private Sub Cargar_Compania()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbCompania.DataSource = oCompania.Lista
            cmbCompania.ValueMember = "CCMPN"
            bolBuscar = True
            cmbCompania.DisplayMember = "TCMPCM"
            ' cmbCompania.SelectedIndex = 0
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar Then
                Cargar_Division()
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            cmbDivision.SelectedIndex = 0
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Carga_Mes_Actual()
        dtFechaInicio.Value = Now.AddDays(-1 * CDbl(Now.Day) + 1)
        dtFechaFin.Value = Now
    End Sub
    Private Sub Cargar_Cliente()
        'UcCliente.pUsuario = ConfigurationWizard.UserName
        UcCliente.CCMPN = Me.cmbCompania.SelectedValue
    End Sub
    Private Sub cbRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRango.CheckedChanged
        If cbRango.Checked Then
            dtFechaFin.Enabled = True
            dtFechaInicio.Enabled = True
        Else
            dtFechaFin.Value = Date.Now
            dtFechaInicio.Value = Now.AddDays(-1 * CDbl(Now.Day) + 1)
            dtFechaFin.Enabled = False
            dtFechaInicio.Enabled = False
        End If
    End Sub

    Private Sub Limpiar_Controles(Optional ByVal tipo As Integer = 1)
        If tipo = 1 Then
            Me.dtgFactSILDet.DataSource = Nothing
            Me.dtgFacturacionSIL.Rows.Clear()
        Else
            Me.dtgFactSILDet.DataSource = Nothing
        End If

    End Sub
    Private Sub Ocultar_Controles(Optional ByVal tipo As Integer = 1)
        If tipo = 1 Then
            UcPaginacion1.Visible = False
            btnReporte.Enabled = ButtonEnabled.False
        End If
        If tipo = 2 Then
            dtgFactSILDet.DataSource = Nothing
        End If
    End Sub
    Private Sub Mostrar_Controles(Optional ByVal tipo As Integer = 1)
        If tipo = 1 Then
            UcPaginacion1.Visible = True
            btnReporte.Enabled = ButtonEnabled.True
        Else
            Me.dtgFactSILDet.Visible = True
        End If
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub
#End Region

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        bolPaginar = False
        UcPaginacion1.PageCount = 0
        bolIniciaCarga = True
        Buscar_FacturacionSIL()
    End Sub
    Private Sub Buscar_FacturacionSIL()
        Try
            If bolPaginar = False Then
                UcPaginacion1.PageNumber = 1
            End If
            oFacturacionSIL.PSCCMPN = cmbCompania.SelectedValue
            oFacturacionSIL.PSCDVSN = cmbDivision.SelectedValue
            oFacturacionSIL.CCLNT = UcCliente.pCodigo
            If cbRango.Checked Then
                oFacturacionSIL.F_INICIO = HelpClass.FormatoFechaAS400(dtFechaInicio.Text)
                oFacturacionSIL.F_FINAL = HelpClass.FormatoFechaAS400(dtFechaFin.Text)
            Else
                oFacturacionSIL.F_INICIO = 0
                oFacturacionSIL.F_FINAL = 21001231
            End If
            
            Me.Cursor = Cursors.WaitCursor
            cargar_grilla()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub cargar_grilla()
        Dim intCont As Integer
        Dim oDt As New DataTable

        If UcPaginacion1.PageCount = 0 Then
            '------------Usando Hilos Thread------------
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            oDt = oFacturacionSILNeg.Lista_Facturacion_SIL(oFacturacionSIL)
            proceso_espera.Abort()
            '----------------------------------
        End If
        If bolIniciaCarga = True Then
            oDtGlobal = HelpClass.paginarDataDridView(oDt, 0, oDt.Rows.Count - 1)
            UcPaginacion1.PageCount = HelpClass.num_paginas(oDt, UcPaginacion1.PageSize)
            oFacturacionSIL.PageSize = UcPaginacion1.PageSize
            bolIniciaCarga = False
        End If
        If UcPaginacion1.PageSize <> oFacturacionSIL.PageSize Then
            UcPaginacion1.PageCount = HelpClass.num_paginas(oDtGlobal, UcPaginacion1.PageSize)
            oFacturacionSIL.PageSize = UcPaginacion1.PageSize
        End If
        '-------------------------------------------------------------------------------------
        Dim oDt2 As New DataTable
        oDt2.Rows.Clear()
        Dim pagIni As Integer = 0
        Dim pagFin As Integer = 0
        pagIni = (UcPaginacion1.PageNumber - 1) * (UcPaginacion1.PageSize)
        pagFin = UcPaginacion1.PageNumber * UcPaginacion1.PageSize
        oDt2 = HelpClass.paginarDataDridView(oDtGlobal, pagIni, pagFin - 1)

        If oDt2.Rows.Count > 0 Then
            Limpiar_Controles()
            Mostrar_Controles()
            For intCont = 0 To oDt2.Rows.Count - 1
                Agrega_Row_Fact_SIL()
                With Me.dtgFacturacionSIL
                    .Rows(intCont).Cells("CCMPN").Value = oDt2.Rows(intCont).Item("CCMPN")
                    .Rows(intCont).Cells("CDVSN").Value = oDt2.Rows(intCont).Item("CDVSN")
                    .Rows(intCont).Cells("CCLNT").Value = oDt2.Rows(intCont).Item("CCLNT")
                    .Rows(intCont).Cells("DESC_CLIE").Value = oDt2.Rows(intCont).Item("DESC_CLIE")
                    .Rows(intCont).Cells("NOPRCN").Value = oDt2.Rows(intCont).Item("NOPRCN")
                    .Rows(intCont).Cells("NORSCI").Value = oDt2.Rows(intCont).Item("NORSCI")  'O/S Carga Internacional
                    .Rows(intCont).Cells("CTPODC").Value = oDt2.Rows(intCont).Item("CTPODC")
                    .Rows(intCont).Cells("NDCFCC").Value = oDt2.Rows(intCont).Item("NDCFCC")
                    .Rows(intCont).Cells("PNNMOS").Value = oDt2.Rows(intCont).Item("PNNMOS") 'O/S Agencias

                    '-----------------------------------------------------------------------
                    If Not IsDBNull(oDt2.Rows(intCont).Item("FECHA_EMBARQUE")) Then
                        .Rows(intCont).Cells("FORSCI").Value = HelpClass.FormatoFecha(oDt2.Rows(intCont).Item("FECHA_EMBARQUE"))
                    Else
                        .Rows(intCont).Cells("FORSCI").Value = ""
                    End If
                    '-----------------------------------------------------------------------
                    If Not IsDBNull(oDt2.Rows(intCont).Item("FECHA_FACTURA")) Then
                        .Rows(intCont).Cells("FDCCTC").Value = HelpClass.FormatoFecha(oDt2.Rows(intCont).Item("FECHA_FACTURA"))
                    Else
                        .Rows(intCont).Cells("FDCCTC").Value = ""
                    End If
                    '-----------------------------------------------------------------------
                    If Not IsDBNull(oDt2.Rows(intCont).Item("ESTADO_EMBARCACION")) Then
                        If oDt2.Rows(intCont).Item("ESTADO_EMBARCACION") = "C" Then
                            .Rows(intCont).Cells("SESTRG1").Value = "Cerrado"
                        ElseIf oDt2.Rows(intCont).Item("ESTADO_EMBARCACION") = "A" Then
                            .Rows(intCont).Cells("SESTRG1").Value = "Pendiente"
                        ElseIf oDt2.Rows(intCont).Item("ESTADO_EMBARCACION") = "*" Then
                            .Rows(intCont).Cells("SESTRG1").Value = "Anulado"
                        Else
                            .Rows(intCont).Cells("SESTRG1").Value = oDt2.Rows(intCont).Item("ESTADO_EMBARCACION")
                        End If
                    Else
                        .Rows(intCont).Cells("SESTRG1").Value = "" 'Estado Embarcacion
                    End If
                    '-----------------------------------------------------------------------
                    If Not IsDBNull(oDt2.Rows(intCont).Item("FLGFAC")) Then
                        If oDt2.Rows(intCont).Item("FLGFAC") = "S" Then
                            .Rows(intCont).Cells("FLGFAC").Value = "Facturado"
                        Else
                            .Rows(intCont).Cells("FLGFAC").Value = "Pendiente"
                        End If
                    Else
                        .Rows(intCont).Cells("FLGFAC").Value = "Pendiente"
                    End If
                    If Not IsDBNull(oDt2.Rows(intCont).Item("QATNAN")) Then
                        .Rows(intCont).Cells("QATNAN").Value = Format(CType(oDt2.Rows(intCont).Item("QATNAN").ToString.Trim, Double), "###,###,###,##0")
                    Else
                        .Rows(intCont).Cells("QATNAN").Value = ""
                    End If
                    If Not IsDBNull(oDt2.Rows(intCont).Item("IVLSRV")) Then
                        .Rows(intCont).Cells("IVLSRV").Value = Format(CType(oDt2.Rows(intCont).Item("IVLSRV").ToString.Trim, Double), "###,###,###,##0.00")
                    Else
                        .Rows(intCont).Cells("IVLSRV").Value = ""
                    End If
                    .Rows(intCont).Cells("DESTAR").Value = oDt2.Rows(intCont).Item("DESTAR").ToString.Trim
                    If Not IsDBNull(oDt2.Rows(intCont).Item("CMNDA1")) Then
                        If oDt2.Rows(intCont).Item("CMNDA1") = 100 Then
                            .Rows(intCont).Cells("CMNDA1").Value = "USD"
                        ElseIf oDt2.Rows(intCont).Item("CMNDA1") = 1 Then
                            .Rows(intCont).Cells("CMNDA1").Value = "S/"
                        Else
                            .Rows(intCont).Cells("CMNDA1").Value = oDt2.Rows(intCont).Item("CMNDA1").ToString.Trim
                        End If
                    Else
                        .Rows(intCont).Cells("CMNDA1").Value = ""
                    End If
                    If Not IsDBNull(oDt2.Rows(intCont).Item("MONTO")) Then
                        .Rows(intCont).Cells("MONTO").Value = Format(CType(oDt2.Rows(intCont).Item("MONTO").ToString.Trim, Double), "###,###,###,##0.00")
                    Else
                        .Rows(intCont).Cells("MONTO").Value = ""
                    End If
                End With
            Next intCont
        Else
            Ocultar_Controles()
            frmInformacion.lblMensaje.Text = "No hay registros por mostrar para esta consulta"
            frmInformacion.StartPosition = FormStartPosition.CenterScreen
            frmInformacion.ShowDialog()
            bolIniciaCarga = True
        End If
    End Sub
    Private Sub Agrega_Row_Fact_SIL()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgFacturacionSIL)
        Me.dtgFacturacionSIL.Rows.Add(oDrVw)
    End Sub
    Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        bolPaginar = True
        Buscar_FacturacionSIL()
    End Sub
    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Dim frm As frmVisorFacturacionSIL
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objFacturaSIL As rptFacturaSIL
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            objFacturaSIL = New rptFacturaSIL
            objDt = oDtGlobal.Clone
            objDt = oDtGlobal.Copy

            objDt.TableName = "FacturaSIL"
            objDs.Tables.Add(objDt.Copy)
            objFacturaSIL.SetDataSource(objDs)
            '------------------------------------
            frm = New frmVisorFacturacionSIL(objFacturaSIL)
            frm.ShowDialog()

            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub dtgFacturacionSIL_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacionSIL.CellContentClick
        If e.RowIndex > -1 Then
            oFacturacionSIL_Detalle.PSCCMPN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("CCMPN").Value
            oFacturacionSIL_Detalle.PSCDVSN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("CDVSN").Value
            If IsDBNull(Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("NOPRCN").Value) Then
                oFacturacionSIL_Detalle.NOPRCN = ""
            Else
                oFacturacionSIL_Detalle.NOPRCN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("NOPRCN").Value
            End If
            Cargar_Detalle_FacturacionSIL(oFacturacionSIL)
        End If
    End Sub
    Private Sub dtgFacturacionSIL_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFacturacionSIL.CellEnter
        If e.RowIndex > -1 Then
            oFacturacionSIL_Detalle.PSCCMPN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("CCMPN").Value
            oFacturacionSIL_Detalle.PSCDVSN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("CDVSN").Value
            If IsDBNull(Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("NOPRCN").Value) Then
                oFacturacionSIL_Detalle.NOPRCN = ""
            Else
                oFacturacionSIL_Detalle.NOPRCN = Me.dtgFacturacionSIL.Rows(e.RowIndex).Cells("NOPRCN").Value
            End If
            Cargar_Detalle_FacturacionSIL(oFacturacionSIL)
        End If
    End Sub
    Private Sub Cargar_Detalle_FacturacionSIL(ByVal oFacturacionSil As SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oDt_Det As New DataTable
        If oFacturacionSIL_Detalle.NOPRCN = "" Then
            Ocultar_Controles(2)
            Exit Sub
        End If
        oDt_Det = oFacturacionSILNeg.Lista_Facturacion_SIL_Detalle(oFacturacionSIL_Detalle)
        If oDt_Det.Rows.Count > 0 Then
            Limpiar_Controles(2)
            Mostrar_Controles(2)
            dtgFactSILDet.AutoGenerateColumns = False
            dtgFactSILDet.DataSource = oDt_Det
        Else
            Ocultar_Controles(2)
            frmInformacion.lblMensaje.Text = "No hay registros por mostrar para esta consulta"
            frmInformacion.ShowDialog()
            bolIniciaCarga = True
        End If
    End Sub
End Class
