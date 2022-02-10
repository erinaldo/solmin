Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
'Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes.Generador
Imports System.Text
Imports System.Reflection
Imports Ransa.Utilitario.Helpclass_txt
Imports System.IO

Public Class frmGuiaRemision

#Region "variables"
    Private DtExportarGuia As New DataTable
    Private dtColumName As New DataTable
#End Region

#Region "Metodos"
    Private Function fnValidarInformacion() As String
        Dim Mensaje As String = String.Empty
        If txtCliente.pCodigo = 0 Then
            Mensaje &= "Falta Seleccionar un Cliente. "
        End If
        Return Mensaje
    End Function

    ''' <summary>
    ''' Limpia Todas las Grillas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LimpiarGrillas()
        dgGuiasRemision.AutoGenerateColumns = False
        dgGuiasRemision.DataSource = Nothing
        dgDetalleGR.DataSource = Nothing
        dgObservacionGR.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Listas Las guias de Remision segun filtro
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fnSelGuiasRemision()
        'Try

        LimpiarGrillas()
        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            If Me.chkfecha.Checked Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
            End If
            'If IsNumeric(txtNroGuia.Text) Then
            '    .PSNGUIRM = txtNroGuia.Text
            'End If
            .PSNGUIRM = txtNroGuia.Text.Trim.ToUpper

            .PSTLUGEN = IIf(cmbLote.SelectedIndex = 0, "", cmbLote.SelectedValue)

            .PSSESDCM = IIf("" & cboEstadoGuia.SelectedValue & "" = "", "", cboEstadoGuia.SelectedValue)
            .PageNumber = UcPaginacionGuia.PageNumber
            .PageSize = UcPaginacionGuia.PageSize
        End With
        Dim PageCount As Decimal = 0
        dgGuiasRemision.DataSource = New DespachoSAT.brGuiasRemision().fnListGuiasRemision(obeFiltroGuia, PageCount)
        If dgGuiasRemision.Rows.Count > 0 Then
            'UcPaginacionGuia.PageCount = CType(dgGuiasRemision.DataSource.Item(0), beGuiaRemision).PageCount
            UcPaginacionGuia.PageCount = PageCount
        Else
            UcPaginacionGuia.PageCount = 0
        End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub fnSelDetalleGuia()
        'Try

        Dim obefiltroGuiaRemision As New beGuiaRemision
        With obefiltroGuiaRemision
            .PSCCMPN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCCMPN
            .PSCDVSN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCDVSN
            .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
            .PNCPLNDV = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCPLNDV
            .PSNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
            If .PNNGUIRO <> 0 Then
                .PSNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNNGUIRO
            End If
            .PNTIPO = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNTIPO
        End With
        dgDetalleGR.AutoGenerateColumns = False
        dgDetalleGR.DataSource = Nothing
        If obefiltroGuiaRemision.PNTIPO = 0 Then
            dgDetalleGR.DataSource = New DespachoSDS.brGuiasRemision().fnSelDetalleGuiaDS(obefiltroGuiaRemision)
        Else
            dgDetalleGR.DataSource = New DespachoSAT.brGuiasRemision().fnSelDetalleGuiaAT(obefiltroGuiaRemision)
        End If
        VisualizarColumnaDetalleGuia(obefiltroGuiaRemision.PNTIPO)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub VisualizarColumnaDetalleGuia(ByVal pintTipo As Integer)
        If pintTipo = 0 Then
            'DS

            Me.dgDetalleGR.Columns("Planta").Visible = False
            Me.dgDetalleGR.Columns("CMRCLR").Visible = True
            Me.dgDetalleGR.Columns("DMRCLR").Visible = True
            Me.dgDetalleGR.Columns("QTRMC").Visible = True
            Me.dgDetalleGR.Columns("CUNCN6").Visible = True
            Me.dgDetalleGR.Columns("QTRMP").Visible = True
            Me.dgDetalleGR.Columns("CUNPS6").Visible = True

            Me.dgDetalleGR.Columns("CREFFW").Visible = False
            Me.dgDetalleGR.Columns("FREFFW").Visible = False
            Me.dgDetalleGR.Columns("DESCWB").Visible = False
            Me.dgDetalleGR.Columns("QREFFW").Visible = False
            Me.dgDetalleGR.Columns("TIPBTO").Visible = False
            Me.dgDetalleGR.Columns("QPSOBL").Visible = False
            Me.dgDetalleGR.Columns("TUNPSO").Visible = False
            Me.dgDetalleGR.Columns("QVLBTO").Visible = False
            Me.dgDetalleGR.Columns("TUNVOL").Visible = False
            Me.dgDetalleGR.Columns("QAROCP").Visible = False
            Me.dgDetalleGR.Columns("NORCML").Visible = False
            Me.dgDetalleGR.Columns("NRITOC").Visible = False
            Me.dgDetalleGR.Columns("TCITCL").Visible = False
            Me.dgDetalleGR.Columns("TDITES").Visible = False
            Me.dgDetalleGR.Columns("PNQBLTSR").Visible = False
            Me.dgDetalleGR.Columns("TUNDIT").Visible = False
            Me.dgDetalleGR.Columns("NGRPRV").Visible = False
            Me.dgDetalleGR.Columns("DESPROV").Visible = False
            Me.dgDetalleGR.Columns("TLUGEN").Visible = False

            'If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSSSTVAL = "M" Then
            '    Me.dgDetalleGR.Columns("CSRECL").Visible = True
            'Else
            '    Me.dgDetalleGR.Columns("CSRECL").Visible = False
            'End If
            If dgGuiasRemision.CurrentRow IsNot Nothing Then
                If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSSSTVAL = "M" Then
                    Me.dgDetalleGR.Columns("CSRECL").Visible = True
                Else
                    Me.dgDetalleGR.Columns("CSRECL").Visible = False
                End If
            End If

        Else
            'AT
            Me.dgDetalleGR.Columns("Planta").Visible = True
            Me.dgDetalleGR.Columns("CMRCLR").Visible = False
            Me.dgDetalleGR.Columns("DMRCLR").Visible = False
            Me.dgDetalleGR.Columns("QTRMC").Visible = False
            Me.dgDetalleGR.Columns("CUNCN6").Visible = False
            Me.dgDetalleGR.Columns("QTRMP").Visible = False
            Me.dgDetalleGR.Columns("CUNPS6").Visible = False

            Me.dgDetalleGR.Columns("CREFFW").Visible = True
            Me.dgDetalleGR.Columns("FREFFW").Visible = True
            Me.dgDetalleGR.Columns("DESCWB").Visible = True
            Me.dgDetalleGR.Columns("QREFFW").Visible = True
            Me.dgDetalleGR.Columns("TIPBTO").Visible = True
            Me.dgDetalleGR.Columns("QPSOBL").Visible = True
            Me.dgDetalleGR.Columns("TUNPSO").Visible = True
            Me.dgDetalleGR.Columns("QVLBTO").Visible = True
            Me.dgDetalleGR.Columns("TUNVOL").Visible = True
            Me.dgDetalleGR.Columns("QAROCP").Visible = True
            Me.dgDetalleGR.Columns("NORCML").Visible = True
            Me.dgDetalleGR.Columns("NRITOC").Visible = True
            Me.dgDetalleGR.Columns("TCITCL").Visible = True
            Me.dgDetalleGR.Columns("TDITES").Visible = True
            Me.dgDetalleGR.Columns("PNQBLTSR").Visible = True
            Me.dgDetalleGR.Columns("TUNDIT").Visible = True
            Me.dgDetalleGR.Columns("NGRPRV").Visible = True
            Me.dgDetalleGR.Columns("DESPROV").Visible = True
            Me.dgDetalleGR.Columns("TLUGEN").Visible = True
            'If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSSSTVAL = "M" Then
            '    Me.dgDetalleGR.Columns("CSRECL").Visible = True
            'Else
            '    Me.dgDetalleGR.Columns("CSRECL").Visible = False
            'End If
            If dgGuiasRemision.CurrentRow IsNot Nothing Then
                If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSSSTVAL = "M" Then
                    Me.dgDetalleGR.Columns("CSRECL").Visible = True
                Else
                    Me.dgDetalleGR.Columns("CSRECL").Visible = False
                End If
            End If

        End If

    End Sub

    Private Sub fnSelObservacionesGR()
        'Try
        dgObservacionGR.AutoGenerateColumns = False
        dgObservacionGR.DataSource = Nothing
        Dim ht As Hashtable = New Hashtable()
        ht.Add("CCLNT", Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT)
        ht.Add("NGUIRM", Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM)
        dgObservacionGR.DataSource = New DespachoSDS.brGuiasRemision().fnSelObservacionGR(ht)
        'Catch ex As Exception

        'End Try
    End Sub

    ''' <summary>
    ''' Suprime Guia de remision
    ''' </summary>
    ''' <param name="pbeGuiaDeRemision"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub DeleteGuia(ByVal pbeGuiaDeRemision As beGuiaRemision)
        Me.dgGuiasRemision.DataSource.Remove(pbeGuiaDeRemision)
        Dim olbeGuia As New List(Of beGuiaRemision)
        olbeGuia = Me.dgGuiasRemision.DataSource
        dgGuiasRemision.DataSource = Nothing
        dgGuiasRemision.DataSource = olbeGuia
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExportarExcel()



        If Me.dgGuiasRemision.Rows.Count = 0 Then Exit Sub
        '=========================
        'cresmos un data grid similar al dela grilla
        'Dim oDtg As New DataGridView
        'oDtg = Me.dgGuiasRemision

        '==========================

        Dim olbeGuiaDeRemision As New List(Of beGuiaRemision)
        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            If Me.chkfecha.Checked Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
            End If
            'If IsNumeric(txtNroGuia.Text) Then
            '    .PSNGUIRM = txtNroGuia.Text
            'End If
            .PSNGUIRM = txtNroGuia.Text.Trim.ToUpper
            .PageNumber = 1
            .PageSize = UcPaginacionGuia.PageSize * UcPaginacionGuia.PageCount
        End With
        'OBTIENE LISTA DE GUIA DE REMISION
        Dim PageCount As Decimal = 0
        olbeGuiaDeRemision = New DespachoSAT.brGuiasRemision().fnListGuiasRemision(obeFiltroGuia, PageCount)
        'olbeGuiaDeRemision = New DespachoSAT.brGuiasRemision().fnListGuiasRemision(obeFiltroGuia)
        dtgExportarExcel.DataSource = olbeGuiaDeRemision

        'Exportar Nuevo
        DtExportarGuia = New DataTable
        dtColumName = New DataTable

        Dim drColumName As DataRow
        Dim olbeGuiaReporteRemision As List(Of beGuiaRemision) = DirectCast(dtgExportarExcel.DataSource, List(Of beGuiaRemision))
        DtExportarGuia = GenericListToDataTable(olbeGuiaReporteRemision)
        dtColumName.Columns.Add(New DataColumn("ColumName", GetType(String)))

        '''''''''


        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        Dim olbeCheckpoint As New List(Of beCheckPoint)
        Dim olbeCheckpointExportarExcel As New List(Of beCheckPoint)
        With obeCheckpoint
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCCMPN = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .PSCDVSN = "R"
            .PSCEMB = "N"
            If Me.chkfecha.Checked Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
            End If
            'If IsNumeric(txtNroGuia.Text) Then
            '    .PNNGUIRM = Val(txtNroGuia.Text)
            'End If
            .PSNGUIRM = txtNroGuia.Text.Trim.ToUpper
        End With

        '=============ELIMINAR COLUMNAS QUE NO VALES ============

        For intCol As Integer = dtgExportarExcel.Columns.Count - 1 To 0 Step -1

            Select Case dtgExportarExcel.Columns(intCol).DataPropertyName
                Case "PSDNGUIRM", "PSFECGUIA", "PSORIGEN", "PSDESTINO", "PNCDPEPL", "PSTCMPTR", "PSNPLCCM", "PSNBRVCH", "PSTNMBCH", "PSSESTRG"
                Case Else
                    Me.dtgExportarExcel.Columns.RemoveAt(intCol)
            End Select

        Next

        '==================================================
        'LISTA DE  CHECKPOINTS
        olbeCheckpoint = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)
        Dim oDtgColums As DataGridViewTextBoxColumn
        For Each obeCheck As beCheckPoint In olbeCheckpoint
            oDtgColums = New DataGridViewTextBoxColumn
            oDtgColums.Name = obeCheck.PNNESTDO & "_DFECREA"
            oDtgColums.HeaderText = obeCheck.PSTDESES
            dtgExportarExcel.Columns.Add(oDtgColums)

            oDtgColums = New DataGridViewTextBoxColumn
            oDtgColums.Name = obeCheck.PNNESTDO & "_DFECEST"
            oDtgColums.HeaderText = obeCheck.PSTDESES
            dtgExportarExcel.Columns.Add(oDtgColums)


            DtExportarGuia.Columns.Add(New DataColumn("DFECREA_" & obeCheck.PSTDESES, GetType(String)))
            DtExportarGuia.Columns.Add(New DataColumn("DFECEST_" & obeCheck.PSTDESES, GetType(String)))

            drColumName = dtColumName.NewRow()
            drColumName("ColumName") = obeCheck.PSTDESES
            dtColumName.Rows.Add(drColumName)
        Next


        'Lista de Checkpoinst para exportar excel
        olbeCheckpointExportarExcel = obrCheckpoint.ListaCheckpointExportarExcel(obeCheckpoint)
        Dim obeBusqueda As beCheckPoint
        For intCont As Integer = 0 To Me.dtgExportarExcel.RowCount - 1
            Me.dtgExportarExcel.Rows(intCont).DataBoundItem.PSNGUIRM()
            For Each obeCheck As beCheckPoint In olbeCheckpoint
                obeBusqueda = New beCheckPoint
                NrGuia = dtgExportarExcel.Rows(intCont).DataBoundItem.PSNGUIRM
                codCheckpoint = obeCheck.PNNESTDO
                obeBusqueda = olbeCheckpointExportarExcel.Find(MatchCheckpoinGuia)
                If Not obeBusqueda Is Nothing Then
                    Me.dtgExportarExcel.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECREA").Value = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFRETES)
                    Me.dtgExportarExcel.Rows(intCont).Cells(obeCheck.PNNESTDO & "_DFECEST").Value = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFESEST)

                    For Each dr As DataRow In dtColumName.Rows
                        If dr("ColumName").ToString = obeCheck.PSTDESES Then
                            DtExportarGuia.Rows(intCont).Item("DFECREA_" & obeCheck.PSTDESES) = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFRETES)
                            DtExportarGuia.Rows(intCont).Item("DFECEST_" & obeCheck.PSTDESES) = HelpClass.CNumero8Digitos_a_FechaDefault(obeBusqueda.PNFESEST)
                            DtExportarGuia.AcceptChanges()
                        End If
                    Next

                End If
            Next
        Next

        'Exportar_Excel_ba2()
        Me.MtoExportarexcel()
    End Sub


    Private Sub DeleteColReport(ByVal dtDataTable As DataTable)

        dtDataTable.Columns.Remove("PSPLANTA")
        dtDataTable.Columns.Remove("PSTCMPCL")
        dtDataTable.Columns.Remove("PSTNMMDT")
        dtDataTable.Columns.Remove("PNCCLNGR")

        dtDataTable.Columns.Remove("PSERROR")
        dtDataTable.Columns.Remove("pageNumber")
        dtDataTable.Columns.Remove("pageCount")
        dtDataTable.Columns.Remove("pageSize")
        dtDataTable.Columns.Remove("PSLINK")
        dtDataTable.Columns.Remove("PSMOTTRA")
        dtDataTable.Columns.Remove("PSSMTGRM")
        dtDataTable.Columns.Remove("PSTOBORM")
        dtDataTable.Columns.Remove("PSFGUIRM_S")
        dtDataTable.Columns.Remove("PSNMNFTF")
        dtDataTable.Columns.Remove("PSFSLDAL")
        dtDataTable.Columns.Remove("PSSMTRCP")
        dtDataTable.Columns.Remove("PSMOTREC")
        dtDataTable.Columns.Remove("PSSTPDSP")
        dtDataTable.Columns.Remove("PSTIPDES")
        dtDataTable.Columns.Remove("PSSITUAC")
        dtDataTable.Columns.Remove("PNCTRSPT")
        dtDataTable.Columns.Remove("PNCPLCLP")
        dtDataTable.Columns.Remove("PSNPLCUN")
        dtDataTable.Columns.Remove("PSNPLCAC")
        dtDataTable.Columns.Remove("PSCBRCNT")
        dtDataTable.Columns.Remove("PSCULUSA")
        dtDataTable.Columns.Remove("PSSTGUSA")
        dtDataTable.Columns.Remove("PNFSLDAL_INICIAL")
        dtDataTable.Columns.Remove("PNFSLDAL_FINAL")
        dtDataTable.Columns.Remove("PSCHECK")
        dtDataTable.Columns.Remove("PSCCMPN")
        dtDataTable.Columns.Remove("PSCDVSN")
        dtDataTable.Columns.Remove("PNCPLNDV")
        dtDataTable.Columns.Remove("PNNCRRGR")
        dtDataTable.Columns.Remove("PSCUNPS")
        dtDataTable.Columns.Remove("PNQPSGU")
        dtDataTable.Columns.Remove("PSCUNCN")
        dtDataTable.Columns.Remove("PNQCNGU")
        dtDataTable.Columns.Remove("PSCREFFW")
        dtDataTable.Columns.Remove("PNNRITOC")
        dtDataTable.Columns.Remove("PSCIDPAQ")
        dtDataTable.Columns.Remove("PSFREFFW")
        dtDataTable.Columns.Remove("PNQBLTSR")
        dtDataTable.Columns.Remove("PSTUNDIT")
        dtDataTable.Columns.Remove("PNQPEPQT")
        dtDataTable.Columns.Remove("PSTUNPSO")
        dtDataTable.Columns.Remove("PSTCITCL")
        dtDataTable.Columns.Remove("PSTDITES")
        dtDataTable.Columns.Remove("PSTLUGEN")
        dtDataTable.Columns.Remove("PSNGRPRV")
        dtDataTable.Columns.Remove("PSNFCPRT")
        dtDataTable.Columns.Remove("PSNORCML")
        dtDataTable.Columns.Remove("PNQCNRCP")
        dtDataTable.Columns.Remove("PSSTOCK")
        dtDataTable.Columns.Remove("PSFSLFFW")
        dtDataTable.Columns.Remove("PNTIPO")
        dtDataTable.Columns.Remove("PNFECINI")
        dtDataTable.Columns.Remove("PNFECFIN")
        dtDataTable.Columns.Remove("PNCCLNT")
        dtDataTable.Columns.Remove("PSNGUIRM")
        dtDataTable.Columns.Remove("PNCPLNOR")
        dtDataTable.Columns.Remove("PNCPLNCL")
        dtDataTable.Columns.Remove("PNFGUIRM")
        dtDataTable.Columns.Remove("PNFINTRA")
        dtDataTable.Columns.Remove("PSNPLACP")
        dtDataTable.Columns.Remove("PNNDCMRF")
        dtDataTable.Columns.Remove("PNCMEDTR")
        dtDataTable.Columns.Remove("PNCPRVCO")
        dtDataTable.Columns.Remove("PNCPLCLO")
        dtDataTable.Columns.Remove("PSTOBSRM")
        dtDataTable.Columns.Remove("PSCMRCLR")
        dtDataTable.Columns.Remove("PSDMRCLR")
        dtDataTable.Columns.Remove("PNQTRMC")
        dtDataTable.Columns.Remove("PSCUNCN6")
        dtDataTable.Columns.Remove("PNQTRMP")
        dtDataTable.Columns.Remove("PSCUNPS6")
        dtDataTable.Columns.Remove("PSTOBSGS")
        dtDataTable.Columns.Remove("PNCPRVCL")
        dtDataTable.Columns.Remove("PSCUSCRT")
        dtDataTable.Columns.Remove("PNNROCTL")
        dtDataTable.Columns.Remove("PNNRGUSA")
        dtDataTable.Columns.Remove("PSUSUARIO")
        dtDataTable.Columns.Remove("PNNLINGR")
        dtDataTable.Columns.Remove("PSMODELO")
        dtDataTable.Columns.Remove("PSDECONC")
        dtDataTable.Columns.Remove("PSMGUIFA")
        dtDataTable.Columns.Remove("PSMGFFIN")
        dtDataTable.Columns.Remove("PSMOBSER")
        dtDataTable.Columns.Remove("PSTOXBUL")

        dtDataTable.Columns.Remove("PSTIPBTO")
        dtDataTable.Columns.Remove("PNQPSOBL")
        dtDataTable.Columns.Remove("PNQREFFW")
        dtDataTable.Columns.Remove("PSDESCWB")
        dtDataTable.Columns.Remove("PNQVLBTO")
        dtDataTable.Columns.Remove("PSTUNVOL")
        dtDataTable.Columns.Remove("PNQAROCP")
        dtDataTable.Columns.Remove("PSDESPROV")


        dtDataTable.Columns.Remove("PSTPLNTA")
        dtDataTable.Columns.Remove("strAplicacion")
        dtDataTable.Columns.Remove("PSSESDCM")
        dtDataTable.Columns.Remove("PSCPRCN1")
        dtDataTable.Columns.Remove("PSNSRCN1")
        dtDataTable.Columns.Remove("PNNGUIRO")
        dtDataTable.Columns.Remove("PSSTRNSM")
        dtDataTable.Columns.Remove("PNNGUIRN")




    End Sub


    Private Sub Exportar_Excel_ba2()

        If dtgExportarExcel.Rows.Count = 0 Then Exit Sub



        '/////////////////////////////
        '// Creamos el Objeto StreamWriter
        '/////////////////////////////
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"
        If IO.Directory.Exists(path) = False Then
            IO.Directory.CreateDirectory(path)
        End If
        Dim archivo As String = path & "reporte" & NowNumeric() & ".xls" 'xml
        Dim xls As New IO.StreamWriter(archivo, True, Encoding.Default)

        '/////////////////////////////////////////////////
        '// Iniciamos Tabla html
        '/////////////////////////////////////////////////

        xls.WriteLine("<TABLE>")
        xls.WriteLine("<tr><td colspan='" + (Me.dtgExportarExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (dtgExportarExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (dtgExportarExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (dtgExportarExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr>")
        '/////////////////////////////////////////////////
        '// Armamos la linea con los títulos de columnas
        '/////////////////////////////////////////////////
        xls.WriteLine("<td colspan='2' rowspan='2'> </td>")
        For Each dc As DataGridViewColumn In dtgExportarExcel.Columns
            Dim Value As String = String.Empty
            Value = dc.Name
            Value = Replace(Value, """", String.Empty)
            If Value.EndsWith("_DFECEST") Or Value.EndsWith("_DFECREA") Then
                If Value.EndsWith("_DFECEST") Then
                    xls.Write("<td colspan='2'  style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold; border:1px solid black ' >")
                    xls.Write(dc.HeaderText)
                    xls.Write("</td>")
                End If
            Else
                xls.Write("<td rowspan='2' style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold(); border:1px solid black ' >")
                xls.Write(dc.HeaderText)
                xls.Write("</td>")
            End If
        Next

        xls.WriteLine("</tr>")
        xls.WriteLine("<tr>")
        For Each dc As DataGridViewColumn In dtgExportarExcel.Columns
            Dim Value As String = String.Empty
            Value = dc.Name
            Value = Replace(Value, """", String.Empty)
            If Value.EndsWith("_DFECEST") Or Value.EndsWith("_DFECREA") Then
                xls.Write("<td style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold(); border:1px solid black ' >")
                xls.Write(IIf(Value.EndsWith("_DFECEST"), "FECHA ESTIMADA", "FECHA REAL"))
                xls.Write("</td>")
            End If
        Next
        xls.WriteLine("</tr>")
        'How to Left, Right, Center 
        '/////////////////////////////////////////////////
        '// Armamos filas
        '/////////////////////////////////////////////////
        For Each dr As DataGridViewRow In dtgExportarExcel.Rows
            xls.WriteLine("<tr>")
            xls.WriteLine("<td colspan='2'> </td>")
            For Each dc As DataGridViewColumn In dtgExportarExcel.Columns
                Dim Value As String = String.Empty
                Value = Replace(("" & dr.Cells(dc.Name).Value & "").ToString().Trim(), ";", "<br>")
                xls.Write("<td style='text-align:" + AlignText(Value) + "; border:1px solid black ' >")
                xls.Write(Value)
                xls.Write("</td>")
            Next
            xls.WriteLine("</tr>")
        Next

        xls.WriteLine("</TABLE>")
        xls.Flush()
        xls.Close()
        xls.Dispose()
        HelpClass.AbrirDocumento(archivo)
    End Sub

    Private Sub MtoExportarexcel()

        Dim dtExcel As New DataTable
        Dim objDsExcel As New DataSet

        If dtgExportarExcel.Rows.Count = 0 Then Exit Sub

        Me.DeleteColReport(DtExportarGuia)

        dtExcel = DtExportarGuia.Copy

        dtExcel.Columns("PSDNGUIRM").ColumnName = "Guía"
        dtExcel.Columns("PSSESDCM_DES").ColumnName = "Estado Guía"
        dtExcel.Columns("PSORIGEN").ColumnName = "Origen"
        dtExcel.Columns("PSDESTINO").ColumnName = "Destino"
        dtExcel.Columns("PNCDPEPL").ColumnName = "Pedido"
        dtExcel.Columns("PSTCMPTR").ColumnName = "Transporte"
        dtExcel.Columns("PSNPLCCM").ColumnName = "Placa"
        dtExcel.Columns("PSNBRVCH").ColumnName = "Brevete"
        dtExcel.Columns("PSTNMBCH").ColumnName = "Conductor"
        dtExcel.Columns("PSSESTRG").ColumnName = "Estado"
        dtExcel.Columns("PSFECGUIA").ColumnName = "Fecha"
        dtExcel.Columns("GUIASALIDA").ColumnName = "Guía de Salida"



        dtExcel.Columns("PSNGUIATR").ColumnName = "Guía Transporte"
        dtExcel.Columns("PNNOPRCN").ColumnName = "Número Operación"
        dtExcel.Columns("PSESTADOOPERACION").ColumnName = "Estado Operación"
        dtExcel.Columns("PSTIPODOC").ColumnName = "Tipo Documento"
        dtExcel.Columns("PSNDCMFC").ColumnName = "Número Documento"

        For Each dr As DataRow In dtColumName.Rows
            dtExcel.Columns("DFECREA_" & dr("ColumName").ToString).ColumnName = dr("ColumName").ToString.Trim & "\n FECHA REAL "
            dtExcel.Columns("DFECEST_" & dr("ColumName").ToString).ColumnName = dr("ColumName").ToString.Trim & "\n FECHA ESTIMADA "
        Next

        objDsExcel.Tables.Add(dtExcel)
        dtExcel.TableName = "GuiaRemision"
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente:   \n " & txtCliente.pRazonSocial)
        HelpClass.ExportExcelConTitulos(objDsExcel, Me.Text, strlTitulo)
    End Sub

    Public Shared Function GenericListToDataTable(ByVal list As Object) As DataTable
        Dim dt As DataTable = Nothing
        Dim listType As Type = list.[GetType]()
        If listType.IsGenericType Then
            'determine the underlying type the List<> contains 
            Dim elementType As Type = listType.GetGenericArguments()(0)

            'create empty table -- give it a name in case 
            'it needs to be serialized 
            dt = New DataTable(elementType.Name + "List")

            'define the table -- add a column for each public 
            'property or field 
            Dim miArray As Reflection.MemberInfo() = elementType.GetMembers(BindingFlags.[Public] Or BindingFlags.Instance)
            For Each mi As Reflection.MemberInfo In miArray
                If mi.MemberType = MemberTypes.[Property] Then
                    Dim pi As Reflection.PropertyInfo = TryCast(mi, Reflection.PropertyInfo)
                    dt.Columns.Add(pi.Name, pi.PropertyType)
                ElseIf mi.MemberType = MemberTypes.Field Then
                    Dim fi As Reflection.FieldInfo = TryCast(mi, Reflection.FieldInfo)
                    dt.Columns.Add(fi.Name, fi.FieldType)
                End If
            Next

            'populate the table 
            Dim il As IList = TryCast(list, IList)
            For Each record As Object In il
                Dim i As Integer = 0
                Dim fieldValues As Object() = New Object(dt.Columns.Count - 1) {}
                For Each c As DataColumn In dt.Columns
                    Dim mi As MemberInfo = elementType.GetMember(c.ColumnName)(0)
                    If mi.MemberType = MemberTypes.[Property] Then
                        Dim pi As PropertyInfo = TryCast(mi, PropertyInfo)
                        fieldValues(i) = pi.GetValue(record, Nothing)
                    ElseIf mi.MemberType = MemberTypes.Field Then
                        Dim fi As Reflection.FieldInfo = TryCast(mi, Reflection.FieldInfo)
                        fieldValues(i) = fi.GetValue(record)
                    End If
                    i += 1
                Next
                dt.Rows.Add(fieldValues)
            Next
        End If
        Return dt
    End Function

    Private Function AlignText(ByVal Text As Object) As String
        Dim Align As String = "Center"
        Select Case True
            Case IsNumeric(Text) : Align = "Right"
            Case IsDate(Text) : Align = "Center"
            Case Else : Align = "Left"
        End Select
        Return Align
    End Function

    Private Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function



    Private Function GrabarDocumento(ByVal obeDocumento As BeDocumento) As Integer
        Dim obrDocumento As New brDocumento
        Dim intResultado As Integer = 0
        intResultado = obrDocumento.DocumentoAlmacenInsertar(obeDocumento)
        If intResultado = 0 Then
            HelpClass.ErrorMsgBox()
            Return intResultado
        End If
        fnSelGuiasRemision()
        Return intResultado
    End Function

    Private Sub VisualizarenviarGuia()
        If Me.txtCliente.pCodigo = 16168 Or Me.txtCliente.pCodigo = 20337 Or Me.txtCliente.pCodigo = 21625 Or Me.txtCliente.pCodigo = 37498 Or Me.txtCliente.pCodigo = 38554 Or Me.txtCliente.pCodigo = 11496 Or Me.txtCliente.pCodigo = 53306 Or Me.txtCliente.pCodigo = 53307 Or Me.txtCliente.pCodigo = 41171 Or Me.txtCliente.pCodigo = 40582 Or Me.txtCliente.pCodigo = 20337 Or Me.txtCliente.pCodigo = 56720 Or Me.txtCliente.pCodigo = 48035 Or Me.txtCliente.pCodigo = 58342 Then
            tsbEnviarGuia.Visible = True
            'tssSeparadorEnviarguia.Visible = True
        Else
            tsbEnviarGuia.Visible = False
            'tssSeparadorEnviarguia.Visible = False
        End If
        Dim obrGeneral As New brGeneral

        'Validamos que el clientes sea Outotec
        If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
            tsbEnviarGuia.Visible = True
            'tssSeparadorEnviarguia.Visible = True
        End If
    End Sub
#End Region



#Region "Eventos"


    Private Sub Lote_ActivarAyuda(ByRef objData As Object)
        'dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strData)
        Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
        Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral
        With obeMedioTransporte
            .PNCCLNT = txtCliente.pCodigo
        End With
        objData = obrMedioTransporte.ListaLotesDeEntrega(obeMedioTransporte)
    End Sub

    Private Sub Lote_CambioDeTexto(ByVal strData As String, ByRef objData As Object)
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
            Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral
            With obeMedioTransporte
                .PNCCLNT = txtCliente.pCodigo
            End With
            objData = obrMedioTransporte.ListaLotesDeEntrega(obeMedioTransporte)
        End If

    End Sub

    Private Sub frmConsultaGuiaRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If objSeguridadBN.pstrTipoSistema = "01" Then
                Me.tsbImprimirGuia.Visible = False
                'tssImprimirGuia.Visible = False
            End If
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            dtpFechaFin.Value = Now
            dtpFechaInicio.Value = Now
            LlenaEstadoGuia()
            VisualizarColumnaDetalleGuia(1)
            VisualizarenviarGuia()
           Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenaEstadoGuia()
        Dim oDtEstado As New DataTable
        Dim oDtAux As New DataTable
        oDtEstado = New DespachoSAT.brGuiasRemision().finListaEstadoGuiaRemision()

        oDtAux.Columns.Add("CCMPRN", GetType(String))
        oDtAux.Columns.Add("TDSDES", GetType(String))
        Dim dr As DataRow
        dr = oDtAux.NewRow()
        dr("CCMPRN") = "O"
        dr("TDSDES") = "-------TODOS-------"
        oDtAux.Rows.Add(dr)

        For Each dr0 As DataRow In oDtEstado.Rows
            oDtAux.ImportRow(dr0)
        Next

        Me.cboEstadoGuia.DataSource = oDtAux
        Me.cboEstadoGuia.ValueMember = "CCMPRN"
        Me.cboEstadoGuia.DisplayMember = "TDSDES"
        Me.cboEstadoGuia.SelectedValue = "O"

    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            UcPaginacionGuia.PageNumber = 1
            dgGuiasRemision.DataSource = Nothing
            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            fnSelGuiasRemision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        VistaPreviaGuiaRemision()
    End Sub

    Private Sub UcPaginacionGuia_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacionGuia.PageChanged
        Try
            dgGuiasRemision.DataSource = Nothing
            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Guía de remisión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            fnSelGuiasRemision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfecha.CheckedChanged
        Me.dtpFechaFin.Enabled = chkfecha.Checked
        Me.dtpFechaInicio.Enabled = chkfecha.Checked
    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Try
            If Me.txtCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Seleccione Cliente")
            Else
                Dim ofrmGuiaManual As New frmGenerarGuiaRemisionManual
                ofrmGuiaManual.PNCCLNT = Me.txtCliente.pCodigo
                ofrmGuiaManual.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     


    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click

        Try
            If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
            If MessageBox.Show("Esta seguro de Eliminar la Guía ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Dim obeGuiaRemision As New beGuiaRemision
                obeGuiaRemision = Me.dgGuiasRemision.CurrentRow.DataBoundItem
                With obeGuiaRemision
                    .PSCUSCRT = objSeguridadBN.pUsuario
                End With
                If obeGuiaRemision.PNTIPO = 0 Then
                    Dim obrGuiaRemision As New DespachoSDS.brGuiasRemision
                    If obrGuiaRemision.EliminarGuiaDeRemisionDSD(obeGuiaRemision) = 1 Then
                        DeleteGuia(Me.dgGuiasRemision.CurrentRow.DataBoundItem)
                    Else
                        HelpClass.ErrorMsgBox()
                    End If
                Else
                    Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
                    If obrGuiaRemision.EliminarGuiaDeRemisionAT(obeGuiaRemision) = 1 Then
                        DeleteGuia(Me.dgGuiasRemision.CurrentRow.DataBoundItem)
                    Else
                        HelpClass.ErrorMsgBox()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        
    End Sub

    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Try
            If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
            If MessageBox.Show("Esta seguro de Anular la Guía ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Dim obeGuiaRemision As New beGuiaRemision
                obeGuiaRemision = Me.dgGuiasRemision.CurrentRow.DataBoundItem
                With obeGuiaRemision
                    .PSCUSCRT = objSeguridadBN.pUsuario
                End With
                If obeGuiaRemision.PNTIPO = 0 Then
                    Dim obrGuiaRemision As New DespachoSDS.brGuiasRemision
                    If obrGuiaRemision.AnularGuiaDeRemisionDSD(obeGuiaRemision) = 1 Then
                        btnConsultar_Click(Nothing, Nothing)
                    Else
                        HelpClass.ErrorMsgBox()
                    End If

                Else
                    Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
                    If obrGuiaRemision.AnularGuiaDeRemisionAT(obeGuiaRemision) = 1 Then
                        btnConsultar_Click(Nothing, Nothing)
                    Else
                        HelpClass.ErrorMsgBox()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


      
    End Sub

    'Private Sub dgGuiasRemision_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGuiasRemision.CellDoubleClick

    '    Try
    '        If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
    '        If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNNMRGIM <> 0 Then
    '            If dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub


    '            Dim colName As String = dgGuiasRemision.Columns(e.ColumnIndex).Name
    '            Select Case colName
    '                Case "STRNEG"
    '                    '  visualización de envíos
    '                Case Else
    '                    Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Guia
    '                    With ofrmAdjuntarDocumento
    '                        .pTABLE_NAME = "RZIM36"
    '                        .pUSER_NAME = objSeguridadBN.pUsuario
    '                        .PSCCMPN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCCMPN
    '                        .PSCDVSN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCDVSN
    '                        .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
    '                        .PNCPLNDV = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCPLNDV
    '                        .PNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
    '                        .pNMRGIM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNNMRGIM
    '                        .ShowDialog()
    '                        btnConsultar_Click(Nothing, Nothing)
    '                    End With
    '            End Select


    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub dgGuiasRemision_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgGuiasRemision.DataBindingComplete
        Try
            If Me.dgGuiasRemision.Rows.Count = 0 Then Exit Sub
            Dim cod_envio_emision As String = ""
            Dim cod_anulacion_emision As String = ""
            For Each oDr As DataGridViewRow In Me.dgGuiasRemision.Rows
                If ("" & oDr.DataBoundItem.PSSTRNSM & "").ToString.Equals("E") Then
                    oDr.Cells("TRANSMISION").Value = My.Resources.icono_verdetalle1

                ElseIf ("" & oDr.DataBoundItem.PSSTRNSM & "").ToString.Equals("T") Then
                    oDr.Cells("TRANSMISION").Value = My.Resources.Enviado
                Else
                    oDr.Cells("TRANSMISION").Value = My.Resources.EnBlanco
                End If

                If (oDr.DataBoundItem.PNNMRGIM) <> 0 Then
                    oDr.Cells("PSLINK").Value = My.Resources.text_block
                Else
                    oDr.Cells("PSLINK").Value = My.Resources.EnBlanco
                End If
                If ("" & oDr.DataBoundItem.PSSSTVAL & "").ToString.Equals("M") Then
                    oDr.Cells("TIPGUIA").Value = "X"
                End If

                'Envios Emision Electronico
                cod_envio_emision = oDr.Cells("STRNEG").Value
                cod_anulacion_emision = oDr.Cells("STRNAG").Value
                Select Case cod_envio_emision
                    Case "S"
                        oDr.Cells("STRNEG_IMG").Value = My.Resources.verde
                    Case "E"
                        oDr.Cells("STRNEG_IMG").Value = My.Resources.Rojo
                    Case ""
                        oDr.Cells("STRNEG_IMG").Value = My.Resources.EnBlanco
                End Select

                Select Case cod_anulacion_emision
                    Case "S"
                        oDr.Cells("STRNAG_IMG").Value = My.Resources.verde
                    Case "E"
                        oDr.Cells("STRNAG_IMG").Value = My.Resources.Rojo
                    Case ""
                        oDr.Cells("STRNAG_IMG").Value = My.Resources.EnBlanco
                End Select



            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub dgGuiasRemision_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgGuiasRemision.DataError

    End Sub

    Private Sub dgGuiasRemision_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGuiasRemision.SelectionChanged
        Try
            fnSelDetalleGuia()
            fnLimpiarCheckpoint()
            fnSelPuntoDeControlXGuia()
            fnSelObservacionesGR()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub txtNroGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnConsultar_Click(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' Muestra visible solo si se encuentra en el tab de checkpoints 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 

    Private Sub TabDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabDetalle.SelectedIndexChanged
        Select Case Me.TabDetalle.SelectedIndex
            Case 2
                tsbEliminarCheckpoint.Visible = True
                Me.tssElimininarCheckpoint.Visible = True

            Case Else
                tsbEliminarCheckpoint.Visible = False
                Me.tssElimininarCheckpoint.Visible = False
        End Select
    End Sub

    ''' <summary>
    ''' Imprime Guia de Remisión
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 

    Private Sub tsbImprimirGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimirGuia.Click
        If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        VistaPreviaGuiaRemision()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Me.dtgCheckpointCliente.DataSource = Nothing
        CargarCheckpoint()
        Me.dgGuiasRemision.DataSource = Nothing
        Me.dtgExportarExcel.DataSource = Nothing
        Me.dgObservacionGR.DataSource = Nothing
        VisualizarenviarGuia()
        CargarLotes()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAdjuntarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarGuia.Click
        If dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
     


        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
        'With ofrmAdjuntarDocumento
        '    '.obeBulto.PSCCMPN = Bulto.pCCMPN_Compania
        '    '.obeBulto.PSCDVSN = Bulto.pCDVSN_Division
        '    '.obeBulto.PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .oBeDocumento.PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
        '    .oBeDocumento.PSNDOCUM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        '    .oBeDocumento.PSTIPODC = "GUIA REMISION"
        'End With
        'If ofrmAdjuntarDocumento.ShowDialog() Then
        'End If
        'If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        'Dim obeDocumento As New BeDocumento
        'If Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM.ToString.Trim.Equals("") Then Exit Sub
        'Dim strTipo As String = "GUIA REMISION"
        'Dim strNombreDocumento As String = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        'Dim strDireccion As String = "SOLMIN_SA/" & Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT.ToString.Trim & "/" & strTipo

        'Dim obrCargarImagen As New brCargarImagen
        'With obeDocumento
        '    .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
        '    .PSNDOCUM = strNombreDocumento
        '    .PSTIPODC = strTipo
        '    .PSCUSCRT = objSeguridadBN.pUsuario
        '    .PSSESTRG = "A"
        'End With
        'strNombreDocumento = strNombreDocumento & "_" & obeDocumento.PNNCRRDC.ToString
        'Dim objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
        'If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    obeDocumento.EXTENCION = obrCargarImagen.GetFileExtencion(strDireccion, strNombreDocumento)
        '    strNombreDocumento = strNombreDocumento & obeDocumento.EXTENCION
        '    If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then
        '        With obeDocumento
        '            .PSTOBSMD = "Guía de Remision"
        '            .PSTNMBAR = strNombreDocumento
        '            .PSURLARC = HelpClass.getURLDocLinksSolAlmacen() & strDireccion
        '            .PSCULUSA = objSeguridadBN.pUsuario
        '        End With
        '        GrabarDocumento(obeDocumento)
        '    End If
        'End If


        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Guia
        'With ofrmAdjuntarDocumento
        '    .pTABLE_NAME = "RZIM36"
        '    .pUSER_NAME = objSeguridadBN.pUsuario

        '    .PSCCMPN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCCMPN
        '    .PSCDVSN = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSCDVSN
        '    .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
        '    .PNCPLNDV = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCPLNDV
        '    .PNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        '    .pNMRGIM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNNMRGIM
        '    .ShowDialog()
        '    btnConsultar_Click(Nothing, Nothing)
        'End With




        Try

            Dim pCCLNT As String = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
            Dim pCCMPN As String = ("" & Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            Dim pNGUIRM As String = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
           


            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = pCCMPN
            ofrmCargaAdjuntos.pNroImagen = dgGuiasRemision.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZIM36
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZIM36(pCCMPN, pCCLNT, pNGUIRM)
            ofrmCargaAdjuntos.ShowDialog()
            If ofrmCargaAdjuntos.pDialog = True Then
                dgGuiasRemision.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dgGuiasRemision.CurrentRow.Cells("NMRGIM_S").Value = "X"
                Else
                    dgGuiasRemision.CurrentRow.Cells("NMRGIM_S").Value = ""
                End If

                'dgBultos.ActualizarFlag_Adjunto(ofrmCargaAdjuntos.pNroImagen)
                ''pActualizarInformacion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Impresión de Guia de remisión"

    Private Sub VistaPreviaGuiaRemision()
        If dgGuiasRemision.RowCount = 0 Then Exit Sub

        Dim oDs As DataSet
        Me.dgGuiasRemision.CurrentRow.DataBoundItem.strAplicacion = Application.StartupPath
        oDs = New RANSA.NEGO.DespachoSAT.brGuiasRemision().fdsImprimirGuiaRemision(Me.dgGuiasRemision.CurrentRow.DataBoundItem, objSeguridadBN.pstrTipoSistema, Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSSSTVAL)
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                VistraPreviaGuiaRemisionAT(oDs, Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSMODELO)
            Case "03", "04"
                VistraPreviaGuiaRemisionDS(oDs, Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSMODELO)
        End Select
    End Sub



    Private Sub VistraPreviaGuiaRemisionAT(ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case strModeloGuia
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionM01
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionM02
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionM03
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionM04
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionM05
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M5A"
                rdocGuiaRemision = New rptGuiaRemisionM05A
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5B"
                rdocGuiaRemision = New rptGuiaRemisionM05B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionM06
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M7"
                rdocGuiaRemision = New rptGuiaRemisionM07
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M9"
                rdocGuiaRemision = New rptGuiaRemisionM09
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M9B"
                rdocGuiaRemision = New rptGuiaRemisionM09B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M10"
                rdocGuiaRemision = New rptGuiaRemisionM10
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M12"
                rdocGuiaRemision = New rptGuiaRemisionM012
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M13"
                rdocGuiaRemision = New rptGuiaRemisionM013
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M14"
                rdocGuiaRemision = New rptGuiaRemisionM14
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionM01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub


    Private Sub VistraPreviaGuiaRemisionDS(ByVal oDs As DataSet, ByVal strModeloGuia As String)
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case strModeloGuia
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M02
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M03
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M04
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M05
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionSDS_M06
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionSDS_M01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub


    'Private Sub pVisualizarGuiaRemisionDS()
    '    If dgGuiasRemision.RowCount = 0 Then Exit Sub

    '    ' Filtros
    '    Dim objFiltro As slnSOLMIN_SDS.DespachoSDS.Reportes.clsFiltros_ReporteGuiaRemision = New slnSOLMIN_SDS.DespachoSDS.Reportes.clsFiltros_ReporteGuiaRemision()
    '    With objFiltro
    '        .pintCodigoCliente_CCLNT = txtCliente.pCodigo
    '        Int64.TryParse(Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM, .pintNroGuiaRemision_NGUIRM)
    '    End With
    '    ''muestra la guia de remision
    '    Dim strMensajeError As String = String.Empty
    '    With frmVisorRPT
    '        .WindowState = FormWindowState.Maximized
    '        .Dock = DockStyle.Fill
    '        .pReportDocument = mfrptReporteGuiaRemisionDS(objFiltro)
    '        If strMensajeError <> "" Then
    '            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            .ShowDialog()
    '        End If
    '    End With
    'End Sub

    'Private Sub pVisualizarGuiaRemisionAT()
    '    'Dim rptTemp As ReportDocument
    '    'If dgGuiasRemision.RowCount = 0 Then Exit Sub
    '    'Dim objReportes As slnSOLMIN_SAT.Despacho.Reportes.clsReportesDespacho = New slnSOLMIN_SAT.Despacho.Reportes.clsReportesDespacho(objSeguridadBN.pUsuario)
    '    'Dim strMensajeError As String = ""
    '    'rptTemp = objReportes.frptImprimirGuiaRemision(Me.txtCliente.pCodigo, Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM, strMensajeError)
    '    'If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    'With frmVisorRPT
    '    '    .WindowState = FormWindowState.Maximized
    '    '    .Dock = DockStyle.Fill
    '    '    .pReportDocument = rptTemp
    '    '    If strMensajeError <> "" Then
    '    '        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    Else
    '    '        .ShowDialog()
    '    '    End If
    '    'End With
    'End Sub


#End Region

#Region "Punto de Control"

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCheckpoint()
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        Me.dtgCheckpointCliente.AutoGenerateColumns = False
        Me.dtgCheckpointCliente.DataSource = Nothing
        With obeCheckpoint
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSCCMPN = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .PSCDVSN = "R"
            .PSCEMB = "N"
        End With
        Me.dtgCheckpointCliente.DataSource = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)
    End Sub

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fnSelPuntoDeControlXGuia()
        If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obeCheckpoint As New beCheckPoint
        Dim obrCheckpoint As New brCheckPoint
        Dim obeBusqueda As beCheckPoint
        Dim olbeCheckpoint As New List(Of beCheckPoint)
        Dim olbeCheckpointPorGuia As New List(Of beCheckPoint)
        With obeCheckpoint
            .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
            .PNNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        End With
        olbeCheckpointPorGuia = obrCheckpoint.ListaCheckPointXItemsDeOC(obeCheckpoint)
        If Me.dtgCheckpointCliente.DataSource Is Nothing Then Exit Sub
        For Each obeCheck As beCheckPoint In Me.dtgCheckpointCliente.DataSource
            obeBusqueda = New beCheckPoint
            NrGuia = obeCheckpoint.PNNGUIRM
            codCheckpoint = obeCheck.PNNESTDO
            olbeCheckpoint = olbeCheckpointPorGuia.FindAll(MatchCheckpoinGuia)
            If olbeCheckpoint.Count > 0 Then
                CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PNFRETES = 0
                CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PNFESEST = 0
                CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PSTOBEST = ""

                'dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNMESTDO = olbeCheckpoint.Item(0).PNMESTDO
                'dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNDFECREA = olbeCheckpoint.Item(0).PNFRETES
                'dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNDFECEST = olbeCheckpoint.Item(0).PNFESEST
                'dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PSTOBS = olbeCheckpoint.Item(0).PSTOBEST
            End If
        Next
        Me.dtgCheckpointCliente.Refresh()
    End Sub

    ''' <summary>
    ''' Limpia el COntenido de los Checkpoint o Punto de Control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fnLimpiarCheckpoint()
        If Me.dtgCheckpointCliente.DataSource Is Nothing Then Exit Sub
        For Each obeCheck As beCheckPoint In Me.dtgCheckpointCliente.DataSource
            dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNMESTDO = 0
            CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PNFRETES = 0
            CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PNFESEST = 0
            CType(dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)), beCheckPoint).PSTOBEST = ""
        Next
    End Sub

    ''' <summary>
    ''' Eliminar Checkpoint 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbEliminarCheckpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarCheckpoint.Click
        If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        obeCheckpoint = Me.dtgCheckpointCliente.CurrentRow.DataBoundItem
        With obeCheckpoint
            .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
            .PNNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PNFCHCRT = HelpClass.CtypeDate(Now)
            .PNHRACRT = HelpClass.NowNumeric
            .PSSESTRG = "*"
        End With
        If obrCheckpoint.ActualizarCheckPointXGuiaDeRemision(obeCheckpoint) = 1 Then
            fnLimpiarCheckpoint()
            fnSelPuntoDeControlXGuia()
        End If
    End Sub

#Region "Búsqueda de Checkpoint"

    Private codCheckpoint As Decimal = 0
    Private NrGuia As Decimal = 0

    Private MatchCheckpoinGuia As New Predicate(Of beCheckPoint)(AddressOf BuscarCheckpoints)

    Public Function BuscarCheckpoints(ByVal pbeCheckPoint As beCheckPoint) As Boolean
        If (pbeCheckPoint.PNNESTDO = codCheckpoint) And (pbeCheckPoint.PNNGUIRM = NrGuia) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private MatchSelectGuia As New Predicate(Of beGuiaRemision)(AddressOf BuscarGuiaSelecciondos)

    Public Function BuscarGuiaSelecciondos(ByVal pbeGuiaRemision As beGuiaRemision) As Boolean
        If (pbeGuiaRemision.PSCHECK) Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region

#End Region



    Private Sub tsbEnviarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarGuia.Click
        Try 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
            If dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
            Me.dgGuiasRemision.EndEdit()
            Dim olbeGuia As New List(Of beGuiaRemision)
            olbeGuia = Me.dgGuiasRemision.DataSource.FindAll(MatchSelectGuia)
            Dim obrGuia As New DespachoSAT.brGuiasRemision
            Dim dttemporal As New DataTable
            Dim ListaGuias As String = String.Empty
            If olbeGuia.Count = 0 Then Exit Sub
            If Me.txtCliente.pCodigo = 16168 Or Me.txtCliente.pCodigo = 20337 Or Me.txtCliente.pCodigo = 21625 Or Me.txtCliente.pCodigo = 37498 Or Me.txtCliente.pCodigo = 56720 Or Me.txtCliente.pCodigo = 48035 Or Me.txtCliente.pCodigo = 58342 Then
                'Dim lstrGuia As New List(Of String)
                Dim lstrGuia As New Hashtable
                Dim wsIntegracios As New NetPacasmayoService.IntegracionPacasmayo
                wsIntegracios.CCLNT = Me.txtCliente.pCodigo
                wsIntegracios.LocalDirectory = Application.StartupPath
                For Each obeGui As beGuiaRemision In olbeGuia
                    NrGuia = obeGui.PSNGUIRM
                    obeGui.PNCCLNT = Me.txtCliente.pCodigo
                    'Dar Formato Guia
                    Dim nroGuia As String = NrGuia
                    'Dim formatGuia1 As String = Microsoft.VisualBasic.Left(nroGuia, 3)
                    'Dim formatGuia2 As String = Microsoft.VisualBasic.Right(nroGuia, 7)
                    'nroGuia = formatGuia1 + "-" + formatGuia2
                    'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
                    If CType(dgGuiasRemision.DataSource, List(Of beGuiaRemision)).FindAll(MatchCGuiaOrigen).Count = 0 Then
                        If Not ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("T") Then
                            If ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("E") Then
                                If MessageBox.Show("La guía de remisión: " & nroGuia & " ya ha sido enviado, desea volver a enviar", "Precaución", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                                    'lstrGuia.Add(obeGui.PSNGUIRM)
                                    lstrGuia(obeGui.PSNGUIRM) = obeGui.PSNGUIRS
                                End If
                            Else
                                'lstrGuia.Add(obeGui.PSNGUIRM)
                                lstrGuia(obeGui.PSNGUIRM) = obeGui.PSNGUIRS
                            End If
                        End If
                    End If
                    obeGui.PSCHECK = False
                Next

                If lstrGuia.Count > 0 Then
                    Dim ListadoGuias As New List(Of String)
                    For Each item As DictionaryEntry In lstrGuia
                        ListadoGuias.Add(item.Key)
                    Next
                    'dttemporal = fnValidarGuiasRemision(lstrGuia)
                    dttemporal = fnValidarGuiasRemision(ListadoGuias)
                    If dttemporal.Rows.Count > 0 Then
                        For Each rowGuias As DataRow In dttemporal.Rows
                            ListaGuias = ListaGuias & rowGuias("NGUIRM") & ","
                        Next
                        ListaGuias = Mid(ListaGuias, 1, ListaGuias.Length - 1)

                        If MessageBox.Show("Las guias " + ListaGuias + " tienen ordenes de compra que fueron ingresadas de forma manual, ¿Desea hacer el envío?", "Precaución", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                            ' If lstrGuia.Count > 0 Then
                            wsIntegracios.ListaGuias = lstrGuia
                            ' wsIntegracios.EnviarGuia()
                            wsIntegracios.EnviarGuiaNet()  'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN
                        End If

                    Else
                        wsIntegracios.ListaGuias = lstrGuia
                        wsIntegracios.EnviarGuiaNet()  'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN

                    End If
                End If

            End If

            'Envio de GR para Ares
            If Me.txtCliente.pCodigo = 11496 Or Me.txtCliente.pCodigo = 53306 Or Me.txtCliente.pCodigo = 53307 Or Me.txtCliente.pCodigo = 40582 Or Me.txtCliente.pCodigo = 41171 Or Me.txtCliente.pCodigo = 38554 Then
                Dim lstrGuia As New List(Of String)
                'declaracion del web service de hoschild
                Dim WSAres As New ws_hoc_output_gr
                For Each obeGui As beGuiaRemision In olbeGuia
                    NrGuia = obeGui.PSNGUIRM
                    obeGui.PNCCLNT = Me.txtCliente.pCodigo
                    If CType(dgGuiasRemision.DataSource, List(Of beGuiaRemision)).FindAll(MatchCGuiaOrigen).Count = 0 Then
                        If Not ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("T") Then
                            If ("" & obeGui.PSSTRNSM & "").Trim.ToString.Equals("E") Then
                                If MessageBox.Show("ARES: La guía de remisión: " & obeGui.PSNGUIRM & " ya ha sido enviado, desea volver a enviar", "Precaución", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                                    lstrGuia.Add(obeGui.PSNGUIRM)
                                End If
                            Else
                                lstrGuia.Add(obeGui.PSNGUIRM)
                            End If
                        End If
                    End If
                    obeGui.PSCHECK = False
                Next

                If lstrGuia.Count > 0 Then
                    For Each objGR As String In lstrGuia
                        'Leyendo el resultado y evaluando si fue satisfactorio o no
                        Dim lstr_result As String = ""
                        Try

                            Dim dtb As New DataTable
                            lstr_result = WSAres.consulta_guia_traslado("HOC", "RANSA2012", Me.txtCliente.pCodigo, objGR, 2)
                            If lstr_result <> "" Then
                                dtb = (XmltoDataTable(lstr_result))
                                If dtb.Rows(0).Item("CODIGO").ToString().Trim() = "WSR04" Then
                                    Dim objGuiTemp As New beGuiaRemision
                                    objGuiTemp.PNCCLNT = Me.txtCliente.pCodigo
                                    objGuiTemp.PSNGUIRM = objGR
                                    objGuiTemp.PSCUSCRT = "SOLMINWEB"

                                    obrGuia.fintActualizarEnvioGuias(objGuiTemp)
                                End If
                            Else
                                MsgBox("No hubo respuesta de Minera Ares")
                            End If
                        Catch ex As Exception
                            MsgBox("Error al registrar el resultado de la trama " & lstr_result & " " & ex.ToString())
                        End Try
                    Next

                End If

            End If

            Dim obrGeneral As New brGeneral
            'Validamos que el clientes sea Outotec
            If obrGeneral.bolElClienteEsOutotec(Me.txtCliente.pCodigo) Then
                For Each obeGuas As beGuiaRemision In olbeGuia
                    If obeGuas.PSSTRNSM <> "E" Then 'LA GUIA SE ENVIO
                        EnviarGuiaRemisionOutotec(obeGuas)
                    End If
                Next
            End If
            dgGuiasRemision.EndEdit()
            dgGuiasRemision.Refresh()
            btnConsultar_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(String.Format("No se pudo realizar conexión con el servicio web.{0}{1}", vbNewLine, ex.Message))
        End Try
    End Sub

    Private Function XmltoDataTable(ByVal objxmlData As String) As DataTable
        Dim dst As New DataSet
        Dim objxml As New Xml.XmlTextReader(New IO.StringReader(objxmlData))
        dst.ReadXml(objxml)
        If dst.Tables.Count = 0 Then
            dst.Tables.Add(New DataTable)
        End If
        Return dst.Tables(0).Copy

    End Function


    Private Sub EnviarGuiaRemisionOutotec(ByVal obeGuia As beGuiaRemision)
        Dim obrDespacho As New Ransa.NEGO.brDespacho
        Dim obeDespacho As New Ransa.TypeDef.beDespacho
        Dim olbeDespacho As New List(Of Ransa.TypeDef.beDespacho)
        obeDespacho.PNCCLNT = obeGuia.PNCCLNT
        obeDespacho.PNNGUIRM = obeGuia.PSNGUIRM

        If obeGuia.PSSSTVAL.ToString.Trim.Equals("M") Then
            olbeDespacho = obrDespacho.flistListaExportarGuiaManualOutotec(obeDespacho)
        Else
            olbeDespacho = obrDespacho.flistListaExportarGuiaOutotec(obeDespacho)
        End If

        If olbeDespacho.Count > 0 Then

            ''Proyecto Outotec
            Dim obrInterfaz As New Ransa.NEGO.brInterfazOutoTec
            '================registro de cabecera========================
            Dim obeCabGuiaInfzOutotec As New Ransa.TypeDef.beCabGuiaInfzOutotec
            With obeCabGuiaInfzOutotec
                .nguias = olbeDespacho.Item(0).PNNGUIRM
                .codcli = obeDespacho.PNCCLNT
                .ctpdoc = "PS"
                .nserof = olbeDespacho.Item(0).PSSERIE
                .ndocof = olbeDespacho.Item(0).PSNROFIC
                .npensa = olbeDespacho.Item(0).PNNGUIRN
                .ctpgui = olbeDespacho.Item(0).PSCTPGUI

                If Not olbeDespacho.Item(0).FechaEmisionGuia Is Nothing Then
                    .femisi = olbeDespacho.Item(0).FechaEmisionGuia
                Else
                    .femisi = Nothing
                End If
                If Not olbeDespacho.Item(0).FechaInicioTraslado Is Nothing Then
                    .finitr = olbeDespacho.Item(0).FechaInicioTraslado
                Else
                    .finitr = Nothing
                End If
                .dtpgui = olbeDespacho.Item(0).PSTDSDES

                .ctpope = olbeDespacho.Item(0).PSNRFTPD
                .nordpr = olbeDespacho.Item(0).PSNRFRPD

                .nordcl = olbeDespacho.Item(0).PSTOBSMD.Trim
                .ddiori = olbeDespacho.Item(0).PSORIGEN
                .ctpode = olbeDespacho.Item(0).PSCLADES
                .coride = olbeDespacho.Item(0).PSTIPCLI
                .ddirec01 = olbeDespacho.Item(0).PSDESTINO
                .nconst = olbeDespacho.Item(0).PSNRGMT1
                .nplaca01 = olbeDespacho.Item(0).PSNPLCCM
                .dobser = olbeDespacho.Item(0).PSTOBSRM
                Select Case olbeDespacho.Item(0).PNTDCFCC
                    Case 1
                        .ctpfac = "FA" 'POR MIENTRAS
                    Case 7
                        .ctpfac = "BO" 'POR MIENTRAS
                End Select
                If Not olbeDespacho.Item(0).FechaContrato Is Nothing AndAlso olbeDespacho.Item(0).FechaContrato <> "" Then
                    .fecdoc = olbeDespacho.Item(0).FechaContrato
                    .nfactu01 = olbeDespacho.Item(0).PNNDCFCC
                Else
                    .fecdoc = Nothing
                    .nfactu01 = ""
                End If
                .senlac = "N"
                .sguias = "E"
                .sgepes = "S"
                .clcori = "11" 'temporal
                .cciatr = "22" 'temporal
                .cchofe = "000041" 'tempolar
                .drztra = olbeDespacho.Item(0).PSTCMPTR.Trim
                .cructr = olbeDespacho.Item(0).PNNRUCT
                .dchofe = olbeDespacho.Item(0).PSTNMBCH.Trim
                .nbreve = olbeDespacho.Item(0).PSNBRVCH.Trim
                .qtotpe = olbeDespacho.Item(0).PNQPSGU
                If objSeguridadBN.pUsuario.Length > 6 Then
                    .cusuar = objSeguridadBN.pUsuario.Trim.Substring(1, 6)
                Else
                    .cusuar = objSeguridadBN.pUsuario
                End If
            End With
            If obrInterfaz.fintInsertarCabeceraGuia(obeCabGuiaInfzOutotec) <> -1 Then
                '  ================registro de detalle=========================
                Dim olbeDetGuiaInfzOutotec As New List(Of Ransa.TypeDef.beDetGuiaInfzOutotec)
                Dim intNRow As Integer = 1
                Dim olBeSerie As List(Of Ransa.TypeDef.beDespacho)
                Dim obeDetInterfazOutotec As Ransa.TypeDef.beDetGuiaInfzOutotec

                For Each obeDesp As Ransa.TypeDef.beDespacho In olbeDespacho
                    olBeSerie = New List(Of Ransa.TypeDef.beDespacho)
                    olBeSerie = obrDespacho.ListaSerieExportarABB(obeDesp)

                    If olBeSerie.Count > 0 Then
                        If olBeSerie.Count = obeDesp.PNQTRMC Then
                            For Each obeSerie As Ransa.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        Else
                            obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                            With obeDetInterfazOutotec
                                .nguias = obeDesp.PNNGUIRM
                                .codcli = obeDespacho.PNCCLNT
                                .norden = intNRow
                                .citems = obeDesp.PSCMRCLR.Trim
                                .ditems = obeDesp.PSDEMERCA.Trim
                                .cunmed = obeDesp.PSCUNCN6.Trim
                                .qitems = obeDesp.PNQTRMC - olBeSerie.Count
                                .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                .qsaldo = 0
                            End With
                            olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                            intNRow = intNRow + 1

                            For Each obeSerie As Ransa.TypeDef.beDespacho In olBeSerie
                                obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                                With obeDetInterfazOutotec
                                    .nguias = obeDesp.PNNGUIRM
                                    .codcli = obeDespacho.PNCCLNT
                                    .norden = intNRow
                                    .citems = obeDesp.PSCMRCLR.Trim
                                    .ditems = obeDesp.PSDEMERCA.Trim
                                    .cunmed = obeDesp.PSCUNCN6.Trim
                                    .qitems = 1
                                    .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                                    .qsaldo = 0
                                    .nserie = obeSerie.PSCSRECL.Trim
                                End With
                                olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                                intNRow = intNRow + 1
                            Next
                        End If
                    Else
                        obeDetInterfazOutotec = New Ransa.TypeDef.beDetGuiaInfzOutotec
                        With obeDetInterfazOutotec
                            .nguias = obeDesp.PNNGUIRM
                            .codcli = obeDespacho.PNCCLNT
                            .norden = intNRow
                            .citems = obeDesp.PSCMRCLR
                            .ditems = obeDesp.PSDEMERCA
                            .cunmed = obeDesp.PSCUNCN6
                            .qitems = obeDesp.PNQTRMC
                            .qunida = IIf(obeDesp.PSNRFTPD.Trim.Equals("P"), 0, Val(obeDesp.PSNLTECL.Trim))
                            .qsaldo = 0
                            .nserie = obeDesp.PSCSRECL 'Solo para el Manual, si es automatico nunca va tener serie en este caso
                        End With
                        olbeDetGuiaInfzOutotec.Add(obeDetInterfazOutotec)
                        intNRow = intNRow + 1
                    End If
                Next

                Dim oucOrdena As UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec)

                oucOrdena = New UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec)("qunida", UCOrdena(Of Ransa.TypeDef.beDetGuiaInfzOutotec).TipoOrdenacion.Ascendente)
                olbeDetGuiaInfzOutotec.Sort(oucOrdena)

                For intRow As Integer = 0 To olbeDetGuiaInfzOutotec.Count - 1
                    olbeDetGuiaInfzOutotec.Item(intRow).norden = intRow
                Next


                If obrInterfaz.fintInsertarDetalleGuia(olbeDetGuiaInfzOutotec) = -1 Then
                    MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Error en el envio a Outotec", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obrGuia As New DespachoSAT.brGuiasRemision
            With obeGuia
                .PSUSUARIO = objSeguridadBN.pUsuario
            End With
            If Not obrGuia.fintActualizarEnvioGuias(obeGuia) Then
                HelpClass.ErrorMsgBox()
            End If

        End If
    End Sub

#Region "Búsqueda de Guìa"

    Private MatchCGuiaOrigen As New Predicate(Of beGuiaRemision)(AddressOf BuscarGuiaOrigen)

    Public Function BuscarGuiaOrigen(ByVal pbeGuiaRemision As beGuiaRemision) As Boolean
        If (pbeGuiaRemision.PNNGUIRO = NrGuia) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Private Sub btnModificaEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaEstado.Click

        If Me.dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub

        Dim obeGuiaRemision As New beGuiaRemision
        obeGuiaRemision = Me.dgGuiasRemision.CurrentRow.DataBoundItem

        Dim ofrmModificaEstadoGuia As New frmModificaEstadoGuia
        ofrmModificaEstadoGuia._obeGuiaRemision = obeGuiaRemision
        ofrmModificaEstadoGuia.lblEstado.Text = obeGuiaRemision.PSSESDCM_DES
        ofrmModificaEstadoGuia.lblCliente.Text = txtCliente.pRazonSocial
        If ofrmModificaEstadoGuia.ShowDialog = Windows.Forms.DialogResult.OK Then

            For intCont As Integer = 0 To Me.dgGuiasRemision.Rows.Count - 1

                If obeGuiaRemision.PSDNGUIRM.Trim = Me.dgGuiasRemision.Rows(intCont).Cells("DNGUIRM").Value.ToString.Trim Then
                    Me.dgGuiasRemision.Rows(intCont).Cells("SESDCM_DES").Value = ofrmModificaEstadoGuia.cboEstado.Text.ToString
                End If

            Next
            dgGuiasRemision.EndEdit()
            dgGuiasRemision.Refresh()
        End If
    End Sub

    Private Sub ExportarExcel01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarExcel01ToolStripMenuItem.Click
        Try
            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente:   \n " & txtCliente.pRazonSocial)

            HelpClass.ExportExcelConTitulos(fdtListaGuiaRemision, Me.Text, strlTitulo)
       Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportarExcel02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarExcel02ToolStripMenuItem.Click

        If Me.dgGuiasRemision.Rows.Count = 0 Then
            btnConsultar_Click(Nothing, Nothing)
        End If
        ExportarExcel()
    End Sub



    ''' <summary>
    ''' Listas Las guias de Remision segun filtro
    ''' </summary>
    ''' <remarks></remarks>
    Private Function fdtListaGuiaRemision() As DataSet
        'Try

        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            If Me.chkfecha.Checked Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
            End If
            If IsNumeric(txtNroGuia.Text) Then
                .PSNGUIRM = txtNroGuia.Text
            End If
            .PSTLUGEN = IIf(cmbLote.SelectedIndex = 0, "", cmbLote.SelectedValue)
            .PSSESDCM = IIf("" & cboEstadoGuia.SelectedValue & "" = "", "", cboEstadoGuia.SelectedValue)
            .PageNumber = UcPaginacionGuia.PageNumber
            .PageSize = UcPaginacionGuia.PageSize
        End With
        Return New DespachoSAT.brGuiasRemision().fdsListGuiasRemision(obeFiltroGuia)

        'Catch ex As Exception
        '    Return New DataSet
        'End Try
    End Function

    Private Sub FormatoDetalleDeGuiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatoDetalleDeGuiaToolStripMenuItem.Click
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente:   \n " & txtCliente.pRazonSocial)
        HelpClass.ExportExcelConTitulos(fdtListaGuiaRemision_Detalle, Me.Text, strlTitulo)
    End Sub

    Private Function fdtListaGuiaRemision_Detalle() As DataSet
        'Try

        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            If Me.chkfecha.Checked Then
                .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
            End If
            If IsNumeric(txtNroGuia.Text) Then
                .PSNGUIRM = txtNroGuia.Text
            End If
            .PSTLUGEN = IIf(cmbLote.SelectedIndex = 0, "", cmbLote.SelectedValue)
            .PSSESDCM = IIf("" & cboEstadoGuia.SelectedValue & "" = "", "", cboEstadoGuia.SelectedValue)
            .PageNumber = UcPaginacionGuia.PageNumber
            .PageSize = UcPaginacionGuia.PageSize
        End With
        Return New DespachoSAT.brGuiasRemision().fdsListGuiasRemision_Detalle(obeFiltroGuia)

        'Catch ex As Exception
        '    Return New DataSet
        'End Try
    End Function

    Private Sub CargarLotes()
        If txtCliente.pCodigo > 0 Then
            Dim objGuiaBL As New DespachoSAT.brGuiasRemision()
            Me.cmbLote.DataSource = objGuiaBL.ListarLotes(txtCliente.pCodigo)
            Me.cmbLote.ValueMember = "TLTECL"
            Me.cmbLote.DisplayMember = "TLTECL"
            cmbLote.ComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub tsbExportarTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarTxt.Click
        If dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgGuiasRemision.EndEdit()
        Dim olbeGuia As New List(Of beGuiaRemision)
        olbeGuia = Me.dgGuiasRemision.DataSource.FindAll(MatchSelectGuia)
        Dim obrGuia As New DespachoSAT.brGuiasRemision
        If olbeGuia.Count = 0 Then Exit Sub


        Dim intNroGuia As Integer = 0
        Dim intNroGuiaLineas As Integer = 0
        Dim path As String = Application.StartupPath.ToString
        Dim strNombreArchivo As String = ""
        Dim strHora As String = Now.Hour.ToString().PadLeft(2, "0") + Now.Minute.ToString().PadLeft(2, "0") + Now.Second.ToString().PadLeft(2, "0")

        strNombreArchivo = "DERN" & Me.txtCliente.pCodigo.ToString & HelpClass.CDate_a_Numero8Digitos(Now.Date).ToString '& strHora
        Dim archivo As String = path & "\" & strNombreArchivo & ".txt" 'xml

        Using fl As New StreamWriter(archivo, False)
            Dim lstr_textfile As New System.Text.StringBuilder
            'Creamos la cabecera
            Dim strCodCliente As String = Me.txtCliente.pCodigo.ToString.PadLeft(6, "0")
            lstr_textfile.Append("AA")
            lstr_textfile.Append(HelpClass.CDate_a_Numero8Digitos(Now.Date))


            lstr_textfile.Append(strHora)
            lstr_textfile.Append(strCodCliente)
            fl.WriteLine(lstr_textfile.ToString())

            For Each obeGui As beGuiaRemision In olbeGuia
                Dim oDs As DataSet
                obeGui.PSCCMPN = "EZ"
                obeGui.PSCDVSN = "R"
                obeGui.PSNGUIRM = obeGui.PSNGUIRM
                obeGui.PNCCLNT = Me.txtCliente.pCodigo
                Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
                oDs = obrGuiaRemision.fdtGuiaRemisionParaExportarTxt(obeGui)
                intNroGuiaLineas += oDs.Tables(1).Rows.Count
                'Crean la estructura H1
                Dim objListaColumnas As New List(Of Ransa.Utilitario.Helpclass_txt.DataFormat)
                objListaColumnas.Add(New DataFormat("NGUIRM", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("FGUIRM", 8, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("ORIGEN", 80, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("DESTINO", 80, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NRUCTR", 15, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TCMTRT", 40, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NPLCCM", 6, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NPLACP", 6, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NBRVCH", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("SMTGRM", 1, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TOBORM", 30, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("CPRCN1", 4, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NSRCN1", 7, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TTMNCN", 2, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("CPRCN2", 4, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("NSRCN2", 7, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TTMNCN1", 2, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("QPSOBL_E", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("QPSOBL_D", 5, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas.Add(New DataFormat("TNMBCH", 40, AutoCompleteType.White_Space, CharDirection.Left))
                'Generando el archivo

                For i As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                    If lstr_textfile.Length > 0 Then
                        lstr_textfile.Remove(0, lstr_textfile.Length)
                    End If
                    lstr_textfile.Append("H1")
                    For Each objTemp As DataFormat In objListaColumnas
                        For x As Integer = 0 To oDs.Tables(0).Columns.Count - 1
                            'si la columna es la adecuada
                            If objTemp._columnname = "NSRCN2" Then
                                x = x
                            End If
                            If String.Compare(oDs.Tables(0).Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDs.Tables(0).Rows(i).Item(x).ToString(), objTemp._columnlenght))
                            End If
                        Next
                    Next

                    fl.WriteLine(lstr_textfile.ToString())
                Next

                'Limpiamos la variable
                If lstr_textfile.Length > 0 Then
                    lstr_textfile.Remove(0, lstr_textfile.Length)
                End If

                'Crean la estructura H1
                Dim objListaColumnas_L2 As New List(Of Ransa.Utilitario.Helpclass_txt.DataFormat)

                objListaColumnas_L2.Add(New DataFormat("NGUIRM", 10, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CREFFW", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CIDPAQ", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NORCML", 35, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NRITOC", 6, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("NFCPRT", 15, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NITPRT", 18, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("FFCPRT", 8, AutoCompleteType.Numeric, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("QCNTDC_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QCNTDC_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QBLTSR_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QBLTSR_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QPSOBL_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QPSOBL_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("TUNPSO", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("QVLBTO_E", 10, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("QVLBTO_D", 5, AutoCompleteType.Numeric, CharDirection.Right))
                objListaColumnas_L2.Add(New DataFormat("TUNVOL", 10, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("CREEMB", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("FREFFW", 8, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("NGRPRV", 20, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("TLUGEN", 50, AutoCompleteType.White_Space, CharDirection.Left))
                objListaColumnas_L2.Add(New DataFormat("STRNSM", 1, AutoCompleteType.White_Space, CharDirection.Left))

                'Generando el archivo

                For i As Integer = 0 To oDs.Tables(1).Rows.Count - 1
                    If lstr_textfile.Length > 0 Then
                        lstr_textfile.Remove(0, lstr_textfile.Length)
                    End If
                    lstr_textfile.Append("L1")
                    For Each objTemp As DataFormat In objListaColumnas_L2
                        For x As Integer = 0 To oDs.Tables(1).Columns.Count - 1
                            'si la columna es la adecuada
                            If String.Compare(oDs.Tables(1).Columns(x).ColumnName, objTemp._columnname, True) = 0 Then
                                lstr_textfile.Append(HelpClass_Txt.FormatString(objTemp._columnchardirection, objTemp._columncharautocomplete, oDs.Tables(1).Rows(i).Item(x).ToString(), objTemp._columnlenght))
                            End If
                        Next
                    Next

                    fl.WriteLine(lstr_textfile.ToString())
                Next


                obeGui.PSCHECK = False
            Next


            'Creamos el pie de txt
            'Limpiamos la variable
            If lstr_textfile.Length > 0 Then
                lstr_textfile.Remove(0, lstr_textfile.Length)
            End If
            intNroGuia = olbeGuia.Count
            intNroGuiaLineas += intNroGuia

            lstr_textfile.Append("ZZ")
            lstr_textfile.Append(intNroGuia.ToString.PadLeft(6, "0"))
            lstr_textfile.Append(intNroGuiaLineas.ToString.PadLeft(9, "0"))
            fl.WriteLine(lstr_textfile)
            fl.Flush()
            fl.Close()
        End Using

        HelpClass.AbrirDocumento(archivo)


    End Sub

    'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
    Private Function fnValidarGuiasRemision(ByVal lstrGuia As List(Of String)) As DataTable
        Dim validaGuia As DataTable
        Dim SumaGuia As String = String.Empty

        'Try
        Dim obeFiltroGuia As New beGuiaRemision
        With obeFiltroGuia
            .PNCCLNT = txtCliente.pCodigo
            For Each guias As String In lstrGuia
                SumaGuia = SumaGuia & guias & ","
            Next
            SumaGuia = Mid(SumaGuia, 1, SumaGuia.Length - 1)
            .PSNGUIRM = SumaGuia.ToString 'ListGuia 'NumeroGuia 'Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        End With
        validaGuia = New DespachoSAT.brGuiasRemision().fnListValidadGuiasRemision(obeFiltroGuia)
        'Catch ex As Exception

        'End Try
        Return validaGuia
    End Function
    'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN

   

    Private Sub tsm_enviar_gr_e_Click(sender As Object, e As EventArgs) Handles tsm_enviar_gr_e.Click
        Try
            Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision

            Dim obrRestGuiaRemision As New br_Rest_Remision_Pacasmayo

            Dim dt_envio_gr As New DataTable
            Dim obeGuiaRemision As New beGuiaRemision
            Dim pCCLnt As Decimal = dgGuiasRemision.CurrentRow.Cells("CCLNT").Value
            obeGuiaRemision.PNCCLNT = pCCLnt
            dt_envio_gr = obrGuiaRemision.fnValidarCLienteEnvioGuia(obeGuiaRemision)

            Dim msg_validacion As String = ""
            Dim grupo_envio As String = ""
            Dim enviar_guia_electronica As String = ""

            For Each item As DataRow In dt_envio_gr.Rows
                If item("STATUS") = "E" Then
                    msg_validacion = msg_validacion & item("OBSRESULT") & Chr(10)
                End If
            Next
            If dt_envio_gr.Rows.Count > 0 Then
                grupo_envio = dt_envio_gr.Rows(0)("GRUPO_ENVIO")
                enviar_guia_electronica = dt_envio_gr.Rows(0)("STATUS")
            End If

            If msg_validacion.Length > 0 Then
                MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim msg_envio As String = ""
            If enviar_guia_electronica = "S" Then

                If MessageBox.Show("Se procederá con el envío de la Guía seleccionada" & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                'STRNEG
                'Dim CodEnvio As String = ("" & dgGuiasRemision.CurrentRow.Cells("COD_ES_ENV_GRE").Value).ToString.Trim
                Dim CodEnvioEmision As String = ("" & dgGuiasRemision.CurrentRow.Cells("STRNEG").Value).ToString.Trim
                'If CodEnvio = "S" Or CodEnvio = "R" Then
                If CodEnvioEmision = "S" Then
                    If MessageBox.Show("La Guía ya se encuentra enviada o regularizada." & Chr(13) & "Desea enviar nuevamente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
                Dim nGuirm As Decimal = dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value
                Dim nGuirs As String = ("" & dgGuiasRemision.CurrentRow.Cells("NGUIRS").Value).ToString.Trim
                Dim trama As String = ""
                Dim CodRespuestaEmision As String = ""
                msg_envio = msg_envio & obrRestGuiaRemision.Enviar_Guia_Remision_Electronica_Pacasmayo_Rest(pCCLnt, nGuirm, nGuirs, grupo_envio, False, trama, CodRespuestaEmision)

                If CodRespuestaEmision <> "" Then
                    Select Case CodRespuestaEmision
                        Case "S"
                            dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.verde
                            dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
                        Case "E"
                            dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.Rojo
                            dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
                        Case ""
                            dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.EnBlanco
                            dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
                    End Select
                End If
                If msg_envio.Length > 0 Then
                    MessageBox.Show("Inconvenientes de envía Guía : " & msg_envio, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Las Guías fueron enviada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

               


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsm_gr_trama_Click(sender As Object, e As EventArgs) Handles tsm_gr_trama.Click
        Try
            Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
            Dim obrRestGuiaRemision As New br_Rest_Remision_Pacasmayo
            Dim dt_envio_gr As New DataTable
            Dim obeGuiaRemision As New beGuiaRemision
            Dim pCCLnt As Decimal = dgGuiasRemision.CurrentRow.Cells("CCLNT").Value
            obeGuiaRemision.PNCCLNT = pCCLnt
            dt_envio_gr = obrGuiaRemision.fnValidarCLienteEnvioGuia(obeGuiaRemision)

            Dim msg_validacion As String = ""
            Dim grupo_envio As String = ""
            Dim enviar_guia_electronica As String = ""

            For Each item As DataRow In dt_envio_gr.Rows
                If item("STATUS") = "E" Then
                    msg_validacion = msg_validacion & item("OBSRESULT") & Chr(10)
                End If
            Next
            If dt_envio_gr.Rows.Count > 0 Then
                grupo_envio = dt_envio_gr.Rows(0)("GRUPO_ENVIO")
                enviar_guia_electronica = dt_envio_gr.Rows(0)("STATUS")
            End If

            If msg_validacion.Length > 0 Then
                MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim msg_envio As String = ""
            Dim Trama As String = ""
            If enviar_guia_electronica = "S" Then

                Dim nGuirm As Decimal = dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value
                Dim nGuirs As String = ("" & dgGuiasRemision.CurrentRow.Cells("NGUIRS").Value).ToString.Trim
                Dim CodTipo As String = ("" & dgGuiasRemision.CurrentRow.Cells("CTDGRM").Value).ToString.Trim
                Dim CodRespuestaEmision As String = ""
                msg_envio = obrRestGuiaRemision.Enviar_Guia_Remision_Electronica_Pacasmayo_Rest(pCCLnt, nGuirm, nGuirs, grupo_envio, True, Trama, CodRespuestaEmision)

                If msg_envio.Length > 0 Then
                    MessageBox.Show(msg_envio, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Trama.Length > 0 Then
                    Dim path As String = Application.StartupPath.ToString
                    Dim strNombreArchivo As String = ""

                    Dim tipo As String = "GR_" & CodTipo & "_" & nGuirs & "_" & Me.txtCliente.pCodigo.ToString & "_"
                    Dim strHora As String = Now.Hour.ToString().PadLeft(2, "0") + Now.Minute.ToString().PadLeft(2, "0") + Now.Second.ToString().PadLeft(2, "0")
                    strNombreArchivo = tipo & HelpClass.CDate_a_Numero8Digitos(Now.Date).ToString '& strHora
                    Dim archivo As String = path & "\" & strNombreArchivo & ".txt" 'xml
                    Using fl As New StreamWriter(archivo, False)
                        Dim lstr_textfile As New System.Text.StringBuilder
                        'Creamos la cabecera
                        lstr_textfile.Append(Trama)
                        fl.WriteLine(lstr_textfile.ToString())
                        fl.Flush()
                        fl.Close()
                    End Using
                    HelpClass.AbrirDocumento(archivo)
                End If
               
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsm_txt_felect_Click(sender As Object, e As EventArgs) Handles tsm_txt_felect.Click
        Try

            If dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
            Me.dgGuiasRemision.EndEdit()
            Dim Separador As String = "|"

            Dim msg_validacion As String = ""
            Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
            Dim pCCLnt As Decimal = dgGuiasRemision.CurrentRow.Cells("CCLNT").Value
            Dim nGuirm As Decimal = dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value
            Dim nGuirs As String = ("" & dgGuiasRemision.CurrentRow.Cells("NGUIRS").Value).ToString.Trim

            Dim ds_Datos_GR As New DataSet
            Dim dt_cab As New DataTable
            Dim dt_det As New DataTable

            ds_Datos_GR = obrGuiaRemision.Listar_Datos_GuiaTransito_Pacasmayo(pCCLnt, nGuirm, nGuirs)

            dt_cab = ds_Datos_GR.Tables(0).Copy
            dt_det = ds_Datos_GR.Tables(1).Copy

            If dt_cab.Rows.Count = 0 Then
                msg_validacion = msg_validacion & " Datos de cabecera no encontrado." & Chr(13)
            End If
            If dt_det.Rows.Count = 0 Then
                msg_validacion = msg_validacion & " Datos de detalle no encontrado." & Chr(13)
            End If

            If msg_validacion.Length > 0 Then
                msg_validacion = "GUIA: " & nGuirm & Chr(10) & msg_validacion
            End If

            If msg_validacion.Length > 0 Then
                MessageBox.Show(msg_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If msg_validacion = "" Then

                Dim Tipo As String = "GR" & "_" & dt_cab.Rows(0).Item("CTDGRM") & "_" & Me.txtCliente.pCodigo.ToString & "_"


                Dim intNroGuia As Integer = 0
                Dim intNroGuiaLineas As Integer = 0
                Dim path As String = Application.StartupPath.ToString
                Dim strNombreArchivo As String = ""
                Dim strHora As String = Now.Hour.ToString().PadLeft(2, "0") + Now.Minute.ToString().PadLeft(2, "0") + Now.Second.ToString().PadLeft(2, "0")

                strNombreArchivo = Tipo & nGuirs & "_" & HelpClass.CDate_a_Numero8Digitos(Now.Date).ToString '& strHora
                Dim archivo As String = path & "\" & strNombreArchivo & ".txt" 'xml

                Using fl As New StreamWriter(archivo, False)
                    Dim lstr_textfile As New System.Text.StringBuilder

                    For Each item As DataRow In dt_det.Rows
                        lstr_textfile.Length = 0
                        lstr_textfile.Append(dt_cab.Rows(0).Item("TIPO") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("NGUIRS_FORMATO") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("FECHA_GR") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("DIRECC_CLIENTE") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("FECHA_TRASL") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("UBIGEO_O") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("DIREC_O") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("UBIGEO_D") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("DIREC_D") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("RUC_TRANSP") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("RUC_CLIENTE") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("RSOCIAL_TRANSP") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("COND_BREVETE") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("COND_NOMBRE") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("VEH_PLACA") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("ACOP_PLACA") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("VEH_MTC") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("VEH_MARCA") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("PESO_GR") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("OBS_GR") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("MOT_TRAS") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("MOT_DESC") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("MOD_TRANSP") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("CORREO_EMISOR") & Separador)
                        lstr_textfile.Append(dt_cab.Rows(0).Item("CANT_BULTOS_GR") & Separador)
                        lstr_textfile.Append(item("NRO_OC") & Separador)
                        lstr_textfile.Append(item("NRO_ITEM") & Separador)
                        lstr_textfile.Append(item("DESC_OC") & Separador)
                        lstr_textfile.Append(item("DESC_PROV") & Separador)
                        lstr_textfile.Append(item("NRO_BULTO") & Separador)
                        lstr_textfile.Append(item("DESC_BULTO") & Separador)
                        lstr_textfile.Append(item("UM_ITEM") & Separador)
                        '
                        lstr_textfile.Append(item("CANT_ENTREGA") & Separador)
                        lstr_textfile.Append(item("CANT_BULTOS") & Separador) ' se envía cantidad de bultos

                        lstr_textfile.Append(item("NRO_GPROV") & Separador)
                        lstr_textfile.Append(item("COD_MATERIAL") & Separador)
                        lstr_textfile.Append(item("DESC_ITEM") & Separador)
                        lstr_textfile.Append(item("COND_IQBF") & Separador)
                        lstr_textfile.Append(item("CLASE_MATERIAL") & Separador)
                        lstr_textfile.Append(item("COD_SUNAT_UN") & Separador)
                        lstr_textfile.Append(item("PESO_BULTO") & Separador)
                        lstr_textfile.Append(item("PESO_ITEM") & Separador)

                        fl.WriteLine(lstr_textfile.ToString())
                    Next
                    fl.Flush()
                    fl.Close()
                End Using

                HelpClass.AbrirDocumento(archivo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsm_cerrar_reg_envio_Click(sender As Object, e As EventArgs) Handles tsm_cerrar_reg_envio.Click
        Try

            Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision
            If MessageBox.Show("La Guía será regularizada como enviada." & Chr(13) & "Está seguro de continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim pCCLnt As Decimal = dgGuiasRemision.CurrentRow.Cells("CCLNT").Value
            Dim nGuirm As Decimal = dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value
            Dim nGuirs As String = ("" & dgGuiasRemision.CurrentRow.Cells("NGUIRS").Value).ToString.Trim
            Dim obeGR As New beGuiaRemision
            obeGR.PNCCLNT = pCCLnt
            obeGR.PNNGUIRN = nGuirm
            obeGR.PSNGUIRS = nGuirs
            obrGuiaRemision.fintRegularizarEstadoEnvioGuias(obeGR, objSeguridadBN.pUsuario)
            Dim CodRespuestaEmision As String = "S"
            Select Case CodRespuestaEmision
                Case "S"
                    dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.verde
                    dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
                Case "E"
                    dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.Rojo
                    dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
                Case ""
                    dgGuiasRemision.CurrentRow.Cells("STRNEG_IMG").Value = My.Resources.EnBlanco
                    dgGuiasRemision.CurrentRow.Cells("STRNEG").Value = CodRespuestaEmision
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

