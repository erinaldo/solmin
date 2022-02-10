Imports SOLMIN_SC.Negocio
Imports System.Web
Imports SOLMIN_SC.Utilitario
Imports System.Text
Imports SOLMIN_SC.Entidad
Imports NPOI.HPSF
Imports NPOI.POIFS.FileSystem
Imports NPOI.SS.UserModel
Imports Ransa.Utilitario
Public Class frmCargaInternacional
    Private oPais As clsPais
    Private NroDocEmbarque As String
    Private NroFacComercial As String
    Private oDtExcelOrigen As New DataTable
    Private oDtExcelExportar As New DataTable

    Private odtListaCheckPointxCliente As New DataTable

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Sub frmCargaInternacional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            kgvItemOC.AutoGenerateColumns = False
            dtgSeguimiento_OC.AutoGenerateColumns = False
            dtgOC_X_Item.AutoGenerateColumns = False
            dtgOC_X_Item.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            kgvItemOC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            oPais = New clsPais
            oPais.Crea_Lista()
            Llenar_Cliente()
            Llenar_TipoFecha()
            chkCheckPoint.Checked = False
            gbCheckPoint.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#Region "Metodos"
    Private Function Buscar_Maximo_Parcial_X_OC(ByVal oDt As DataTable, ByVal strOc As String) As Integer
        Dim intCont As Integer
        Dim objListaDr As DataRow()
        Dim intRetornar As Integer = 0
        objListaDr = oDt.Select("NORCML ='" & strOc.Trim & "'")
        For intCont = 0 To objListaDr.Length - 1
            If objListaDr(intCont).Item("NRPARC") > intRetornar Then
                intRetornar = objListaDr(intCont).Item("NRPARC").ToString.Trim
            End If
        Next intCont
        Return intRetornar
    End Function

    Private Function Filtrar_Datos_x_CheckPoint_x_OC_Parcial(ByVal odtDatosOCParcial As DataTable) As DataTable
        Dim FechaCHK() As String
        Dim NomColumnaCHK As String = ""
        Dim FECHA As Decimal = 0
        Dim FECHA_VAL As Date
        Dim FECHA_INI_CHK As Decimal = dtpCHKInicio.Value.ToString("yyyyMMdd")
        Dim FECHA_FIN_CHK As Decimal = dtpCHKFin.Value.ToString("yyyyMMdd")
        Dim EXISTE_ALGUN_RANGO As Boolean = False
        NomColumnaCHK = cboCheckPoint.SelectedValue & cboTipoFecha.SelectedValue
        Dim ExisteColumnaCHK As Boolean = False
        ExisteColumnaCHK = odtDatosOCParcial.Columns(NomColumnaCHK) IsNot Nothing
        Dim TOTAL_REG As Int32 = odtDatosOCParcial.Rows.Count - 1
        If (ExisteColumnaCHK = True) Then
            For FILA As Integer = 0 To TOTAL_REG
                If (FILA <= TOTAL_REG) Then
                    EXISTE_ALGUN_RANGO = False
                    FechaCHK = odtDatosOCParcial.Rows(FILA)(NomColumnaCHK).ToString.Split(Chr(10))
                    For Each Item As String In FechaCHK
                        If (Date.TryParse(Item, FECHA_VAL)) Then
                            FECHA = FECHA_VAL.ToString("yyyyMMdd")
                            If (FECHA <= FECHA_FIN_CHK AndAlso FECHA >= FECHA_INI_CHK) Then
                                EXISTE_ALGUN_RANGO = True
                                Exit For
                            End If
                        End If
                    Next
                    If (EXISTE_ALGUN_RANGO = False) Then
                        odtDatosOCParcial.Rows.RemoveAt(FILA)
                        FILA = FILA - 1
                        TOTAL_REG = TOTAL_REG - 1
                    End If
                End If
            Next
        End If
        odtDatosOCParcial.AcceptChanges()
        Return odtDatosOCParcial
    End Function



    Private Sub Listar_Orden_Compra()
        Dim obeFiltro As New beSeguimientoCargaFiltro
        dtgOC_X_Item.DataSource = Nothing
        kgvItemOC.DataSource = Nothing
        If Me.cmbCliente.pCodigo > 0 Then
            obeFiltro.PNCCLNT = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If
        If Me.chxFecha.Checked Then
            obeFiltro.PNFECINI = Me.dtpInicio.Value.ToString("yyyyMMdd")
            obeFiltro.PNFECFIN = Me.dtpFin.Value.ToString("yyyyMMdd")
        Else
            obeFiltro.PNFECINI = 0
            'obeFiltro.PNFECFIN = Now.ToString("yyyyMMdd")
            obeFiltro.PNFECFIN = 99999999
        End If
        obeFiltro.PSNORCML = Me.txtOC.Text.Trim
        obeFiltro.PSNREFCL = Me.txtReq.Text.Trim

        If cmbProveedor.SelectedValue = 0 Then
            obeFiltro.PSCPRVCL = ""
        Else
            obeFiltro.PSCPRVCL = cmbProveedor.SelectedValue
        End If

        obeFiltro.PSCCMPN = GetCompania()
        ' obeFiltro.PSCDVSN = GetDivision(obeFiltro.PSCCMPN)
        obeFiltro.PSCDVSN = cmbPlanta.CodigoDivision
        obeFiltro.PNCPLNDV = cmbPlanta.Planta


        Dim oPreEmbarque As New clsPreEmbarque
        odtListaCheckPointxCliente = oPreEmbarque.ListaCheckPointDistinctxCliente(obeFiltro.PNCCLNT, obeFiltro.PSCCMPN, obeFiltro.PSCDVSN)
        oDtExcelOrigen = oPreEmbarque.Listar_Seguimiento_Internacional_x_OrdenCompra(odtListaCheckPointxCliente, obeFiltro)

        If (chkCheckPoint.Checked) Then
            oDtExcelOrigen = Filtrar_Datos_x_CheckPoint_x_OC_Parcial(oDtExcelOrigen)
        End If

        Dim NameColumna As String = ""
        Dim NameCaption As String = ""
        Dim Columna As String = ""
        Dim COLUMNAS_CHK As New List(Of String)

        For Each COLUMNAS As DataGridViewColumn In dtgOC_X_Item.Columns
            NameColumna = COLUMNAS.Name
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                COLUMNAS_CHK.Add(NameColumna)
            End If
        Next
        For Each Item As String In COLUMNAS_CHK
            If (dtgOC_X_Item.Columns(Item) IsNot Nothing) Then
                dtgOC_X_Item.Columns.Remove(Item)
            End If
        Next

        For Each dc As DataColumn In oDtExcelOrigen.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                If (dtgOC_X_Item.Columns(NameColumna) IsNot Nothing) Then
                    dtgOC_X_Item.Columns.Remove(NameColumna)
                End If
            End If
        Next
        Dim oDcTx As DataGridViewColumn
        Dim ColName() As String

        For Each dc As DataColumn In oDtExcelOrigen.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                ColName = NameCaption.Split("|")
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = NameColumna
                oDcTx.HeaderText = ColName(0).Trim & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " & ColName(1).Trim
                oDcTx.Resizable = DataGridViewTriState.True
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DataPropertyName = NameColumna
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.ReadOnly = True
                dtgOC_X_Item.Columns.Add(oDcTx)
            End If
        Next
        oDtExcelExportar = oDtExcelOrigen.Copy
        dtgOC_X_Item.DataSource = oDtExcelOrigen
        For Each Item As DataGridViewRow In dtgOC_X_Item.Rows
            If (Item.Cells("IMAGEN_UNICO").Value > 0) Then
                Item.Cells("NMRGIM_DOC").Value = My.Resources.ark_selectall
            Else
                Item.Cells("NMRGIM_DOC").Value = My.Resources.EnBlanco
            End If
        Next

    End Sub

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgOC_X_Item.RowCount - 1
            dtgOC_X_Item.Rows(intCont).Cells("VALIDAR").Value = blnEstado
        Next intCont
    End Sub

    Private Function Existe_Check() As Integer
        Dim Cont As Integer = 0
        For intCont As Integer = 0 To Me.dtgOC_X_Item.Rows.Count - 1
            If dtgOC_X_Item.Rows(intCont).Cells("VALIDAR").Value = True Then
                Cont += 1
            End If
        Next
        Return Cont
    End Function

    Private Sub llenar_Tab()
        ListarItemPorOrdenCompraPracial()
    End Sub

    Private Sub ListarItemPorOrdenCompraPracial()
        kgvItemOC.DataSource = Nothing
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim obeOrdenPreEmbarcadaFiltro As New beOrdenPreEmbarcadaFiltro
        obeOrdenPreEmbarcadaFiltro.PNCCLNT = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
        obeOrdenPreEmbarcadaFiltro.PSNORCML = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value.ToString.Trim
        obeOrdenPreEmbarcadaFiltro.PNNRPARC = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
        obeOrdenPreEmbarcadaFiltro.PSCCMPN = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
        'obeOrdenPreEmbarcadaFiltro.PSCDVSN = GetDivision(obeOrdenPreEmbarcadaFiltro.PSCCMPN)
        obeOrdenPreEmbarcadaFiltro.PSCDVSN = dtgOC_X_Item.CurrentRow.Cells("CDVSN").Value
        obeOrdenPreEmbarcadaFiltro.PNCPLNDV = dtgOC_X_Item.CurrentRow.Cells("CPLNDV").Value

        Dim obrPreEmbarque As New Negocio.clsPreEmbarque
        Dim odtItems_x_OCParcial As New DataTable
        odtItems_x_OCParcial = obrPreEmbarque.ListarItemsXOrdenCompraParcial(odtListaCheckPointxCliente, obeOrdenPreEmbarcadaFiltro)

        Dim NameColumna As String = ""
        Dim NameCaption As String = ""
        Dim Columna As String = ""
        Dim COLUMNAS_CHK As New List(Of String)

        For Each COLUMNAS As DataGridViewColumn In kgvItemOC.Columns
            NameColumna = COLUMNAS.Name
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                COLUMNAS_CHK.Add(NameColumna)
            End If
        Next
        For Each Item As String In COLUMNAS_CHK
            If (kgvItemOC.Columns(Item) IsNot Nothing) Then
                kgvItemOC.Columns.Remove(Item)
            End If
        Next

        For Each dc As DataColumn In odtItems_x_OCParcial.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                If (kgvItemOC.Columns(NameColumna) IsNot Nothing) Then
                    kgvItemOC.Columns.Remove(NameColumna)
                End If
            End If
        Next
        Dim oDcTx As DataGridViewColumn
        Dim ColName() As String

        For Each dc As DataColumn In odtItems_x_OCParcial.Columns
            NameColumna = dc.ColumnName
            NameCaption = dc.Caption
            If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
                ColName = NameCaption.Split("-")
                oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
                oDcTx.Name = NameColumna
                oDcTx.HeaderText = ColName(0) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " & ColName(1)
                oDcTx.Resizable = DataGridViewTriState.True
                oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
                oDcTx.DataPropertyName = NameColumna
                oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                oDcTx.ReadOnly = True
                kgvItemOC.Columns.Add(oDcTx)
            End If
        Next
        kgvItemOC.DataSource = odtItems_x_OCParcial

        For Each Item As DataGridViewRow In kgvItemOC.Rows
            If (Item.Cells("NMRGIM_IMAGEN").Value > 0) Then
                Item.Cells("IMG_NMRGIM").Value = My.Resources.ark_selectall
            Else
                Item.Cells("IMG_NMRGIM").Value = My.Resources.EnBlanco
            End If
        Next

    End Sub



#End Region

    Private Sub Llenar_TipoFecha()
        Dim obllTipoFecha As New Estado_BLL
        Dim oListTipoFecha As New List(Of beEstadoEmb)
        oListTipoFecha = obllTipoFecha.ListarTipoFecha
        cboTipoFecha.DataSource = oListTipoFecha
        cboTipoFecha.DisplayMember = "TEX"
        cboTipoFecha.ValueMember = "COD"
    End Sub

    Private Sub Llenar_Cliente()
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpUtil.UserName
    End Sub

    Private Sub fnBuscar()
        dtgOC_X_Item.DataSource = Nothing
        kgvItemOC.DataSource = Nothing
        If Me.cmbCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Listar_Orden_Compra()
        ListarItemPorOrdenCompraPracial()
    End Sub


    Private Sub cmbCliente_TextChanged() Handles cmbCliente.TextChanged
        cboCheckPoint.DataSource = Nothing
        Dim PNCCLNT As Decimal = 0
        If Me.cmbCliente.pCodigo > 0 Then
            PNCCLNT = Me.cmbCliente.pCodigo     
        Else
            Exit Sub
        End If
        Try
            Dim oProveedor As New clsProveedor  
            Dim dtProveedor As New DataTable
            dtProveedor = oProveedor.Lista_Relacion_Proveedor_X_Cliente(PNCCLNT)
            cmbProveedor.DataSource = dtProveedor
            cmbProveedor.ValueMember = "CPRVCL"
            cmbProveedor.DisplayMember = "TPRVCL"

            Dim CCMPN As String = GetCompania()
            Dim CDVSN As String = GetDivision(CCMPN)

            Dim oPreEmbarque As New clsPreEmbarque
            odtListaCheckPointxCliente = oPreEmbarque.ListaCheckPointDistinctxCliente(PNCCLNT, CCMPN, CDVSN)
            cboCheckPoint.DataSource = odtListaCheckPointxCliente
            cboCheckPoint.DisplayMember = "TDESES"
            cboCheckPoint.ValueMember = "NESTDO"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        End Sub



    Private Sub dtgOC_X_Item_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOC_X_Item.CellClick
        Dim SELECCION As Boolean = False
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                llenar_Tab()
            End If
            If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
                SELECCION = dtgOC_X_Item.Rows(e.RowIndex).Cells("VALIDAR").Value
                dtgOC_X_Item.Rows(e.RowIndex).Cells("VALIDAR").Value = Not SELECCION
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbAgregarParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarParcial.Click
        Dim frm As frmBuscar
        Dim PSCCMPN As String = GetCompania()
        Dim PSCCMPN_DESC As String = cmbCompania.CCMPN_Descripcion
        Dim PSCDVSN As String = cmbPlanta.CodigoDivision
        Dim PNCPLNDV As Decimal = cmbPlanta.Planta
        If Me.cmbCliente.pCodigo > 0 Then
            frm = New frmBuscar(Me.cmbCliente.pCodigo, PSCCMPN, PSCCMPN_DESC, PSCDVSN, PNCPLNDV)
        Else
            Exit Sub
        End If
        Try
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Listar_Orden_Compra()
                ListarItemPorOrdenCompraPracial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbEliminarSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarSeguimiento.Click
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Try
            Dim numEliminados As Int32 = 0
            Dim oPreEmbarque As New clsPreEmbarque
            Dim CCLNT As Decimal = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
            Dim intCont As Integer = 0
            Dim intRep As Integer = 0
            Dim NRPEMB As Decimal = 0
            Dim NORCML As String = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value
            Dim NRPARC As Decimal = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
            Dim MSG As String = String.Format("Está seguro de eliminar la [OC :{0} - Parcial: {1}] con todos sus datos ?", NORCML, NRPARC)
            If MessageBox.Show(MSG, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                intRep = kgvItemOC.Rows.Count - 1
                For intCont = 0 To intRep
                    NRPEMB = kgvItemOC.Rows(intCont).Cells("COLNRPEMB").Value
                    numEliminados += 1
                    oPreEmbarque.Elimina_PreEmbarque(NRPEMB, CCLNT)
                Next intCont
                If (numEliminados = kgvItemOC.Rows.Count) Then
                    MessageBox.Show("Se ha eliminado todos los ítems asociados a la OC-Parcial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf numEliminados < kgvItemOC.Rows.Count AndAlso numEliminados > 0 Then
                    MessageBox.Show("Solo se ha eliminado algunos de los ítems asociados a la OC-Parcial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf numEliminados = 0 Then
                    MessageBox.Show("No se pudo eliminar ningún ítem asociado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                If (numEliminados > 0) Then
                    fnBuscar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbEmbarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEmbarcar.Click
        If (dtgOC_X_Item.Rows.Count = 0) Then
            Exit Sub
        End If
        Dim oListOrdenPreEmbarcada As New List(Of beOrdenPreEmbarcadaFiltro)
        Dim obeOrdenPreEmbarcadas As beOrdenPreEmbarcadaFiltro
        Try
            For intCont As Integer = 0 To Me.dtgOC_X_Item.Rows.Count - 1
                If dtgOC_X_Item.Rows(intCont).Cells("VALIDAR").Value = True Then
                    obeOrdenPreEmbarcadas = New beOrdenPreEmbarcadaFiltro
                    obeOrdenPreEmbarcadas.PSNORCML = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value.ToString.Trim
                    obeOrdenPreEmbarcadas.PNCCLNT = dtgOC_X_Item.Rows(intCont).Cells("CCLNT").Value
                    obeOrdenPreEmbarcadas.PNNRPARC = dtgOC_X_Item.Rows(intCont).Cells("NRPARC").Value
                    obeOrdenPreEmbarcadas.PSTCMPL = ("" & dtgOC_X_Item.Rows(intCont).Cells("TCMPL").Value).ToString.Trim
                    obeOrdenPreEmbarcadas.PSCCMPN = ("" & dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                    obeOrdenPreEmbarcadas.PSCDVSN = dtgOC_X_Item.Rows(intCont).Cells("CDVSN").Value
                    obeOrdenPreEmbarcadas.PNCPLNDV = dtgOC_X_Item.Rows(intCont).Cells("CPLNDV").Value
                    oListOrdenPreEmbarcada.Add(obeOrdenPreEmbarcadas)
                End If
            Next
            If (oListOrdenPreEmbarcada.Count = 0) Then
                MessageBox.Show("Debe de checkear por lo menos una de las OC y Parcial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ofrmEmbarcarPreEmbarque As New frmEmbarcarPreEmbarque
            ofrmEmbarcarPreEmbarque.pCCLNT = oListOrdenPreEmbarcada(0).PNCCLNT
            ofrmEmbarcarPreEmbarque.pTCMPL = oListOrdenPreEmbarcada(0).PNCCLNT & " - " & oListOrdenPreEmbarcada(0).PSTCMPL
            ofrmEmbarcarPreEmbarque.pCCMPN = oListOrdenPreEmbarcada(0).PSCCMPN
            ' ofrmEmbarcarPreEmbarque.pCDVSN = GetDivision(oListOrdenPreEmbarcada(0).PSCCMPN)
            ofrmEmbarcarPreEmbarque.pCDVSN = dtgOC_X_Item.CurrentRow.Cells("CDVSN").Value
            ofrmEmbarcarPreEmbarque.PNCPLNDV = dtgOC_X_Item.CurrentRow.Cells("CPLNDV").Value
            ofrmEmbarcarPreEmbarque.pCCMPN_DESC = cmbCompania.CCMPN_Descripcion
            ofrmEmbarcarPreEmbarque.pListOrdPreEmbarcada = oListOrdenPreEmbarcada
            If (ofrmEmbarcarPreEmbarque.ShowDialog = Windows.Forms.DialogResult.OK) Then
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnDatosGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosGen.Click
        If (kgvItemOC.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Try
            Dim ofrm As New frmManCargInterDatosGen
            ofrm.pCCLNT = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
            ofrm.pNRPEMB = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
            ofrm.pNORCML = kgvItemOC.CurrentRow.Cells("COLNORCML").Value.ToString.Trim
            ofrm.pNRPARC = kgvItemOC.CurrentRow.Cells("COLNRPARC").Value
            ofrm.pNRITOC = kgvItemOC.CurrentRow.Cells("COLNRITOC").Value
            ofrm.pSBITOC = kgvItemOC.CurrentRow.Cells("COLSBITOC").Value.ToString.Trim
            ofrm.pCCMPN = ("" & dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value).ToString.Trim
            ofrm.pCDVSN = GetDivision(ofrm.pCCMPN)
            ofrm.ShowDialog()
            If (ofrm.meDialogResult = True) Then
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dtgOC_X_Item_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOC_X_Item.CellContentDoubleClick
        If (e.RowIndex < 0) Then
            Exit Sub
        End If
        Try
            Dim Columna As String = dtgOC_X_Item.Columns(e.ColumnIndex).Name
            Dim intCont As Int32 = 0
            Dim oDtItemParcial As DataTable
            Dim oDr As DataRow
            Select Case Columna
                Case "TOBS_1"
                    oDtItemParcial = New DataTable
                    oDtItemParcial.Columns.Add("NRPEMB")
                    oDtItemParcial.Columns.Add("NORCML")
                    oDtItemParcial.Columns.Add("NRPARC")
                    oDtItemParcial.Columns.Add("NRITOC")
                    oDtItemParcial.Columns.Add("SBITOC")
                    oDtItemParcial.Columns.Add("TDITES")
                    oDtItemParcial.Columns.Add("QRLCSC")
                    For intCont = 0 To kgvItemOC.Rows.Count - 1
                        oDr = oDtItemParcial.NewRow
                        oDr.Item("NRPEMB") = kgvItemOC.Rows(intCont).Cells("COLNRPEMB").Value
                        oDr.Item("NORCML") = kgvItemOC.Rows(intCont).Cells("COLNORCML").Value.ToString.Trim
                        oDr.Item("NRPARC") = kgvItemOC.Rows(intCont).Cells("COLNRPARC").Value
                        oDr.Item("NRITOC") = kgvItemOC.Rows(intCont).Cells("COLNRITOC").Value
                        oDr.Item("SBITOC") = kgvItemOC.Rows(intCont).Cells("COLSBITOC").Value.ToString.Trim
                        oDr.Item("TDITES") = kgvItemOC.Rows(intCont).Cells("COLTDITES").Value.ToString.Trim
                        oDr.Item("QRLCSC") = kgvItemOC.Rows(intCont).Cells("COLQRLCSC").Value
                        oDtItemParcial.Rows.Add(oDr)
                    Next intCont

                    Dim ofrmObsOCParcial As New frmObsOCParcial
                    ofrmObsOCParcial.pdItemParcial = oDtItemParcial
                    ofrmObsOCParcial.pCCLNT = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
                    ofrmObsOCParcial.pNORCML = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value.ToString.Trim
                    ofrmObsOCParcial.pNRPARC = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
                    ofrmObsOCParcial.pCCMPN = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
                    ofrmObsOCParcial.ShowDialog()
                    If (ofrmObsOCParcial.pDialogResult = True) Then
                        fnBuscar()
                    End If
                Case "CHECKPOINT"
                    Dim odtItemOCParcial As New DataTable
                    Dim ofrmEditarCHKMasivo As New frmEditarCHKMasivo
                    ofrmEditarCHKMasivo.pCCLNT = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
                    ofrmEditarCHKMasivo.pNORCML = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value.ToString.Trim
                    ofrmEditarCHKMasivo.pNRPARC = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
                    ofrmEditarCHKMasivo.pCCMPN = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
                    ofrmEditarCHKMasivo.pCDVSN = GetDivision(ofrmEditarCHKMasivo.pCCMPN)
                    odtItemOCParcial = CType(kgvItemOC.DataSource, DataTable)
                    ofrmEditarCHKMasivo.pDtItemOCParcial = odtItemOCParcial
                    ofrmEditarCHKMasivo.ShowDialog()
                    If (ofrmEditarCHKMasivo.meDialogResult = True) Then
                        fnBuscar()
                    End If

                Case "NMRGIM_DOC"
                    If (dtgOC_X_Item.CurrentRow.Cells("IMAGEN_UNICO").Value > 0) Then
                        Dim NMRGIM_LIST As New List(Of String)
                        For Each Item As DataGridViewRow In kgvItemOC.Rows
                            If Item.Cells("NMRGIM").Value > 0 Then
                                NMRGIM_LIST.Add(Item.Cells("NMRGIM").Value)
                            End If
                        Next

                        Dim CCLNT As Decimal = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
                        Dim CCMPN As String = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
                        Dim NMRGIM As Decimal = kgvItemOC.CurrentRow.Cells("NMRGIM").Value
                        Dim NRPEMB As Decimal = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
                        Dim TABLE_NAME As String = "RZOL39P"
                        Dim USER_NAME As String = HelpUtil.UserName
                        Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos("", NMRGIM_LIST, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.PreEmbarque)
                        ofrmAdjuntarDocumentos.pPNRPEMB = NRPEMB
                        ofrmAdjuntarDocumentos.ShowDialog()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxFecha.CheckedChanged
        If chxFecha.Checked Then
            Me.dtpInicio.Enabled = True
            Me.dtpFin.Enabled = True
        Else
            Me.dtpInicio.Enabled = False
            Me.dtpFin.Enabled = False
        End If
    End Sub

    Private Sub btnObservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObservacion.Click
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        If (kgvItemOC.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Try
            Dim ofrmObsOCItem As New frmObsOCItem
            ofrmObsOCItem.pNRPEMB = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value

            ofrmObsOCItem.pCCLNT = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
            ofrmObsOCItem.pNORCML = kgvItemOC.CurrentRow.Cells("COLNORCML").Value.ToString.Trim
            ofrmObsOCItem.pNRITOC = kgvItemOC.CurrentRow.Cells("COLNRITOC").Value
            ofrmObsOCItem.pSBITOC = kgvItemOC.CurrentRow.Cells("COLSBITOC").Value.ToString.Trim()
            ofrmObsOCItem.pNRPEMB = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
            ofrmObsOCItem.pNRPARC = kgvItemOC.CurrentRow.Cells("COLNRPARC").Value
            ofrmObsOCItem.pTDITES = kgvItemOC.CurrentRow.Cells("COLTDITES").Value.ToString.Trim

            ofrmObsOCItem.ShowDialog()
            If (ofrmObsOCItem.meDialogResult = True) Then
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminarSegItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarSegItem.Click
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        If (kgvItemOC.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim oPreEmbarque As New clsPreEmbarque
        Try
            Dim CCLNT As Decimal = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
            Dim intCont As Integer = 0
            Dim intRep As Integer = 0
            Dim NORCML As String = kgvItemOC.CurrentRow.Cells("COLNORCML").Value.ToString.Trim
            Dim NRPARC As Decimal = kgvItemOC.CurrentRow.Cells("COLNRPARC").Value
            Dim NRITOC As Decimal = kgvItemOC.CurrentRow.Cells("COLNRITOC").Value
            Dim NRPEMB As Decimal = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
            Dim MSG As String = String.Format("Está seguro de eliminar la OC:{0} - Parcial:{1} - Item :{2} con todos sus datos ?", NORCML, NRPARC, NRITOC)
            If MessageBox.Show(MSG, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oPreEmbarque.Elimina_PreEmbarque(NRPEMB, CCLNT)
                MessageBox.Show("El ítem seguimiento se ha eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportarOCParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarOCParcial.Click
        If (dtgOC_X_Item.Rows.Count = 0) Then
            Exit Sub
        End If

        If (oDtExcelExportar.Rows.Count = 0) Then
            MessageBox.Show("No existen datos a exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim odtExpOCParcial As New DataTable
            odtExpOCParcial.Columns.Add("NORCML")
            odtExpOCParcial.Columns("NORCML").Caption = "OC"

            odtExpOCParcial.Columns.Add("NRPARC")
            odtExpOCParcial.Columns("NRPARC").Caption = "PARCIAL"

            odtExpOCParcial.Columns.Add("FROCMP")
            odtExpOCParcial.Columns("FROCMP").Caption = "FECHA OC"

            odtExpOCParcial.Columns.Add("FORCML")
            odtExpOCParcial.Columns("FORCML").Caption = "FECHA CONFIRMACION"

            odtExpOCParcial.Columns.Add("TTINTC")
            odtExpOCParcial.Columns("TTINTC").Caption = "ICOTERM"

            odtExpOCParcial.Columns.Add("TPRVCL")
            odtExpOCParcial.Columns("TPRVCL").Caption = "PROVEEDOR"

            odtExpOCParcial.Columns.Add("TNOMCOM")
            odtExpOCParcial.Columns("TNOMCOM").Caption = "COMPRADOR"
            'TNOMCOM


            odtExpOCParcial.Columns.Add("NMONOC")
            odtExpOCParcial.Columns("NMONOC").Caption = "MONEDA"

            odtExpOCParcial.Columns.Add("TNMMDT")
            odtExpOCParcial.Columns("TNMMDT").Caption = "TRANSPORTE OC"

            odtExpOCParcial.Columns.Add("TNMAGC")
            odtExpOCParcial.Columns("TNMAGC").Caption = "AGENTE EMBARCADOR"


            odtExpOCParcial.Columns.Add("NREFCL")
            odtExpOCParcial.Columns("NREFCL").Caption = "NRO REQUERIMIENTO"


            Dim NameColumna As String = ""
            For Each dc As DataColumn In oDtExcelExportar.Columns
                NameColumna = dc.ColumnName
                If ((NameColumna.EndsWith("_DFECEST")) OrElse (NameColumna.EndsWith("_DFECREA"))) Then
                    odtExpOCParcial.Columns.Add(NameColumna)
                    odtExpOCParcial.Columns(NameColumna).Caption = dc.Caption.Trim
                End If
            Next

            odtExpOCParcial.Columns.Add("TOBS")
            odtExpOCParcial.Columns("TOBS").Caption = "OBSERVACION"


            Dim oclsPreEmbarque As New clsPreEmbarque
            Dim PSCCMPN As String = ""
            If dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value IsNot Nothing Then
                PSCCMPN = ("" & dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value).ToString.Trim
            End If
            If PSCCMPN.Length = 0 Then
                Exit Sub
            End If
            oDtExcelExportar = oclsPreEmbarque.LLenarObservacionPorOrdenCompraParcial(PSCCMPN, cmbCliente.pCodigo, oDtExcelExportar)
            Dim dr As DataRow
            For Each drDatos As DataRow In oDtExcelExportar.Rows
                dr = odtExpOCParcial.NewRow
                For Each dcColumna As DataColumn In odtExpOCParcial.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos(NameColumna)
                Next
                odtExpOCParcial.Rows.Add(dr)
            Next

            Ransa.Utilitario.HelpClass_NPOI_SC.ExportExcelSeguimientoPreEmbarquexOCParcial(odtExpOCParcial, "SEGUIMIENTO CARGA")



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function Filtrar_Datos_x_CheckPoint_x_OC_Items(ByVal odtDatosOCParcial As DataTable) As DataTable
        'LOS ITEMS DEBEN DE ORDENARSE POR ORDEN COMPRA Y PARCIAL
        Dim NomColumnaCHK As String = ""
        Dim FECHA As Decimal = 0
        Dim FECHA_VAL As Date
        Dim FECHA_INI_CHK As Decimal = dtpCHKInicio.Value.ToString("yyyyMMdd")
        Dim FECHA_FIN_CHK As Decimal = dtpCHKFin.Value.ToString("yyyyMMdd")
        Dim EXISTE_ALGUN_RANGO As Boolean = False
        NomColumnaCHK = cboCheckPoint.SelectedValue.ToString.Trim & cboTipoFecha.SelectedValue.ToString.Trim
        Dim ExisteColumnaCHK As Boolean = False
        ExisteColumnaCHK = odtDatosOCParcial.Columns(NomColumnaCHK) IsNot Nothing
        Dim drCHK() As DataRow
        Dim TOTAL_REG As Int32 = odtDatosOCParcial.Rows.Count - 1
        Dim PSNORCML_UNICO As String = ""
        Dim PSNORCML As String = ""
        Dim PNNRPARC As Decimal = 0
        Dim PNCCLNT As Decimal = cmbCliente.pCodigo
        Dim oHasListaOCParcial As New Hashtable
        Dim oListPreEmbEliminar As New List(Of Decimal)
        Dim PNNRPEMB As Decimal = 0
        Dim ListaPreEmb As List(Of Decimal)
        If (ExisteColumnaCHK = True) Then
            For FILA As Integer = 0 To TOTAL_REG
                If (FILA <= TOTAL_REG) Then
                    EXISTE_ALGUN_RANGO = False
                    PSNORCML = odtDatosOCParcial.Rows(FILA)("NORCML")
                    PNNRPARC = odtDatosOCParcial.Rows(FILA)("NRPARC")
                    PSNORCML_UNICO = PNCCLNT.ToString & "_" & PSNORCML & "_" & PNNRPARC.ToString
                    If (Not oHasListaOCParcial.Contains(PSNORCML_UNICO)) Then
                        oListPreEmbEliminar = New List(Of Decimal)
                        drCHK = odtDatosOCParcial.Select("CCLNT=" & PNCCLNT & " AND NORCML='" & PSNORCML & "'" & " AND NRPARC=" & PNNRPARC)
                        For Each Item As DataRow In drCHK
                            If (Date.TryParse(Item(NomColumnaCHK).ToString.Trim, FECHA_VAL)) Then
                                FECHA = FECHA_VAL.ToString("yyyyMMdd")
                                If (FECHA <= FECHA_FIN_CHK AndAlso FECHA >= FECHA_INI_CHK) Then
                                    EXISTE_ALGUN_RANGO = True
                                End If
                            End If
                            oListPreEmbEliminar.Add(Item("NRPEMB"))
                        Next
                        If (EXISTE_ALGUN_RANGO = True) Then
                            oListPreEmbEliminar.Clear()
                        End If
                        oHasListaOCParcial(PSNORCML_UNICO) = oListPreEmbEliminar
                        PNNRPEMB = odtDatosOCParcial.Rows(FILA)("NRPEMB")
                        ListaPreEmb = CType(oHasListaOCParcial(PSNORCML_UNICO), List(Of Decimal))
                        If (ListaPreEmb.Contains(PNNRPEMB)) Then
                            odtDatosOCParcial.Rows.RemoveAt(FILA)
                            FILA = FILA - 1
                            TOTAL_REG = TOTAL_REG - 1
                        End If
                    ElseIf oHasListaOCParcial.Contains(PSNORCML_UNICO) Then
                        PNNRPEMB = odtDatosOCParcial.Rows(FILA)("NRPEMB")
                        ListaPreEmb = CType(oHasListaOCParcial(PSNORCML_UNICO), List(Of Decimal))
                        If (ListaPreEmb.Contains(PNNRPEMB)) Then
                            odtDatosOCParcial.Rows.RemoveAt(FILA)
                            FILA = FILA - 1
                            TOTAL_REG = TOTAL_REG - 1
                        End If
                    End If
                End If
            Next
        End If
        odtDatosOCParcial.AcceptChanges()
        Return odtDatosOCParcial
    End Function



    Private Sub btnExportarOCItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarOCItem.Click
        Dim oFiltro As New beSeguimientoCargaFiltro
        Try
            If Me.chxFecha.Checked Then
                oFiltro.PNFECINI = Format(CType(Me.dtpInicio.Text, Date), "yyyyMMdd")
                oFiltro.PNFECFIN = Format(CType(Me.dtpFin.Text, Date), "yyyyMMdd")
            Else
                oFiltro.PNFECINI = 0
                oFiltro.PNFECFIN = Format(CType(Now, Date), "yyyyMMdd")
            End If
            oFiltro.PSNORCML = Me.txtOC.Text.Trim
            oFiltro.PSNREFCL = Me.txtReq.Text.Trim
            If cmbProveedor.SelectedValue = 0 Then
                oFiltro.PSCPRVCL = ""
            Else
                oFiltro.PSCPRVCL = cmbProveedor.SelectedValue
            End If
            oFiltro.PSCMEDTR = ""
            oFiltro.PSCPAIS = ""
            Dim CCMPN As String = GetCompania()
            Dim CDVSN As String = GetDivision(CCMPN)
            Dim oPreEmbarque As New clsPreEmbarque
            Dim odtExpOCParcial As New DataTable
            Dim odtExpoOCItem As New DataTable
            oFiltro.PNCCLNT = cmbCliente.pCodigo
            oFiltro.PSCCMPN = GetCompania()
            oFiltro.PSCDVSN = GetDivision(oFiltro.PSCCMPN)
            odtExpOCParcial = oPreEmbarque.Listar_Seguimiento_Internacional_Rpt_OC_Items(oFiltro)
            If (chkCheckPoint.Checked) Then
                odtExpOCParcial = Filtrar_Datos_x_CheckPoint_x_OC_Items(odtExpOCParcial)
            End If

            If (odtExpOCParcial.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim MdataColumna As String = ""
            Dim NPOI_SC As New HelpClass_NPOI_SC
            'MdataColumna = NPOI.FormatDato("REFERENCIA O/C", HelpClass_NPOI_SC.keyDatoTexto)


            odtExpoOCItem.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato("OC", NPOI_SC.keyDatoTexto)
            'odtExpoOCItem.Columns("NORCML").Caption = "OC"

            odtExpoOCItem.Columns.Add("NRPARC").Caption = NPOI_SC.FormatDato("PARCIAL", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("NRPARC").Caption = "PARCIAL"

            ' odtExpoOCItem.Columns.Add("FROCMP").Caption = NPOI.FormatDato("FECHA OC", HelpClass_NPOI_SC.keyDatoFecha)
            odtExpoOCItem.Columns.Add("FROCMP").Caption = NPOI_SC.FormatDato("FECHA OC", NPOI_SC.keyDatoFecha)
            ' odtExpoOCItem.Columns("FROCMP").Caption = "FECHA OC"

            odtExpoOCItem.Columns.Add("FORCML").Caption = NPOI_SC.FormatDato("FECHA CONFIRMACION", NPOI_SC.keyDatoFecha)
            ' odtExpoOCItem.Columns("FORCML").Caption = "FECHA CONFIRMACION"

            odtExpoOCItem.Columns.Add("TTINTC").Caption = NPOI_SC.FormatDato("ICOTERM", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("TTINTC").Caption = "ICOTERM"

            odtExpoOCItem.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)
            '  odtExpoOCItem.Columns("TPRVCL").Caption = "PROVEEDOR"

            odtExpoOCItem.Columns.Add("TNOMCOM").Caption = NPOI_SC.FormatDato("COMPRADOR", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("TNOMCOM").Caption = "COMPRADOR"

            odtExpoOCItem.Columns.Add("NMONOC").Caption = NPOI_SC.FormatDato("MONEDA", NPOI_SC.keyDatoTexto)
            '  odtExpoOCItem.Columns("NMONOC").Caption = "MONEDA"

            odtExpoOCItem.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("TRANSPORTE", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("TNMMDT").Caption = "TRANSPORTE"


            odtExpoOCItem.Columns.Add("NREFCL").Caption = NPOI_SC.FormatDato("NRO REQUERIMIENTO", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("NREFCL").Caption = "NRO REQUERIMIENTO"



            odtExpoOCItem.Columns.Add("NRITOC").Caption = NPOI_SC.FormatDato("NRO ITEM", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("NRITOC").Caption = "NRO ITEM"

            odtExpoOCItem.Columns.Add("SBITOC").Caption = NPOI_SC.FormatDato("SUB ITEM", NPOI_SC.keyDatoTexto)
            '  odtExpoOCItem.Columns("SBITOC").Caption = "SUB ITEM"

            odtExpoOCItem.Columns.Add("TCITCL").Caption = NPOI_SC.FormatDato("CODIGO ITEM", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("TCITCL").Caption = "CODIGO ITEM"

            odtExpoOCItem.Columns.Add("TDITES").Caption = NPOI_SC.FormatDato("DESCRIPCION ITEM", NPOI_SC.keyDatoTexto)
            ' odtExpoOCItem.Columns("TDITES").Caption = "DESCRIPCION ITEM"


            odtExpoOCItem.Columns.Add("TNMAGC").Caption = NPOI_SC.FormatDato("AGENTE EMBARCADOR", NPOI_SC.keyDatoTexto)
            '   odtExpoOCItem.Columns("TNMAGC").Caption = "AGENTE EMBARCADOR"

            odtExpoOCItem.Columns.Add("FMPDME").Caption = NPOI_SC.FormatDato("FECHA ENTREGA PROMETIDA (1)", NPOI_SC.keyDatoFecha)
            ' odtExpoOCItem.Columns("FMPDME").Caption = "FECHA ENTREGA PROMETIDA (1)"

            odtExpoOCItem.Columns.Add("FMPIME").Caption = NPOI_SC.FormatDato("FECHA REQUERIDA EN PLANTA", NPOI_SC.keyDatoFecha)
            ' odtExpoOCItem.Columns("FMPIME").Caption = "FECHA REQUERIDA EN PLANTA"

            odtExpoOCItem.Columns.Add("QCNTIT").Caption = NPOI_SC.FormatDato("CANTIDAD SOLICITADA", NPOI_SC.keyDatoNumero)
            'odtExpoOCItem.Columns("QCNTIT").Caption = "CANTIDAD SOLICITADA"


            odtExpoOCItem.Columns.Add("QRLCSC").Caption = NPOI_SC.FormatDato("CANTIDAD PREEMBARCADA", NPOI_SC.keyDatoNumero)
            'odtExpoOCItem.Columns("QRLCSC").Caption = "CANTIDAD PREEMBARCADA"

            odtExpoOCItem.Columns.Add("TUNDIT").Caption = NPOI_SC.FormatDato("UNIDAD", NPOI_SC.keyDatoTexto)
            '  odtExpoOCItem.Columns("TUNDIT").Caption = "UNIDAD"



            odtExpoOCItem.Columns.Add("IVUNIT").Caption = NPOI_SC.FormatDato("VALOR UNITARIO", NPOI_SC.keyDatoNumero)
            'odtExpoOCItem.Columns("IVUNIT").Caption = "VALOR UNITARIO"

            odtExpoOCItem.Columns.Add("IVTOIT").Caption = NPOI_SC.FormatDato("VALOR TOTAL", NPOI_SC.keyDatoNumero)
            'odtExpoOCItem.Columns("IVTOIT").Caption = "VALOR TOTAL"

            odtExpoOCItem.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("NRO DOCUMENTO", NPOI_SC.keyDatoTexto)
            'odtExpoOCItem.Columns("NDOCEM").Caption = "NRO DOCUMENTO"

            odtExpoOCItem.Columns.Add("NFCTCM").Caption = NPOI_SC.FormatDato("NRO FACTURA", NPOI_SC.keyDatoTexto)
            'odtExpoOCItem.Columns("NFCTCM").Caption = "NRO FACTURA"


            Dim NameColumna As String = ""
            'ADD COLUMNAS CHECKPOINT
            For Each dc As DataColumn In odtExpOCParcial.Columns
                NameColumna = dc.ColumnName
                If (NameColumna.EndsWith("_DFECEST") OrElse NameColumna.EndsWith("_DFECREA")) Then
                    odtExpoOCItem.Columns.Add(NameColumna)
                    'odtExpoOCItem.Columns(NameColumna).Caption = dc.Caption.Trim
                    odtExpoOCItem.Columns(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoFecha)
                End If
            Next
            'ADD COLUMNAS DE DIFERENCIA FECHA
            For Each dc As DataColumn In odtExpOCParcial.Columns
                NameColumna = dc.ColumnName
                If (NameColumna.EndsWith("_DIF")) Then
                    odtExpoOCItem.Columns.Add(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoFecha)
                    ' odtExpoOCItem.Columns(NameColumna).Caption = dc.Caption.Trim
                End If
            Next

            odtExpoOCItem.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("OBSERVACION", NPOI_SC.keyDatoTexto)
            'odtExpoOCItem.Columns("TOBS").Caption = "OBSERVACION"

            Dim dr As DataRow
            For Each drDatos As DataRow In odtExpOCParcial.Rows
                dr = odtExpoOCItem.NewRow
                For Each dcColumna As DataColumn In odtExpoOCItem.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos(NameColumna)
                Next
                odtExpoOCItem.Rows.Add(dr)
            Next

            odtExpoOCItem = Observaciones_OC_Parcial_Report(odtExpoOCItem)

            odtExpoOCItem.TableName = "Carga Internacional"
            Dim Listdt As New List(Of DataTable)
            Listdt.Add(odtExpoOCItem.Copy)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("SEGUIMIENTO CARGA ITEM")

            Dim LisColNFilas As New List(Of String)
            LisColNFilas.Add("TOBS")
            ' '    Case "NORCML", "NRPARC", "TTINTC", "NMONOC", "TNMMDT", "NRITOC", "SBITOC", "TCITCL", "TUNDIT", "NDOCEM", "NFCTCM"
            Dim FiltroSort As New List(Of SortedList)
            Dim ItemSort As New SortedList
            ItemSort.Add(0, "Cliente:|" & cmbCliente.pCodigo & " - " & cmbCliente.pRazonSocial)
            FiltroSort.Add(ItemSort)
            Ransa.Utilitario.HelpClass_NPOI_SC.ExportExcelSeguimientoPreEmbarquexOCParcialxItem(Listdt, ListTitulo, LisColNFilas, FiltroSort, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Function Observaciones_OC_Parcial_Report(ByVal dt As DataTable) As DataTable
        Dim CodFila As String = ""
        Dim oListVisitados As New Hashtable
        Dim dr() As DataRow
        Dim NORCML As String = ""
        Dim NRPARC As String = ""
        Dim sbText As New StringBuilder
        Dim ListVisitObs As New Hashtable
        Dim oBS As String = ""
        For Fila As Integer = 0 To dt.Rows.Count - 1
            NORCML = dt.Rows(Fila)("NORCML").ToString.Trim
            NRPARC = dt.Rows(Fila)("NRPARC").ToString.Trim
            CodFila = NORCML & "_" & NRPARC
            sbText.Length = 0
            ListVisitObs = New Hashtable
            If Not oListVisitados.Contains(CodFila) Then
                oListVisitados.Add(CodFila, CodFila)
                dr = dt.Select("NORCML='" & NORCML & "' AND NRPARC='" & NRPARC & "'")
                For FilaObs As Integer = 0 To dr.Length - 1
                    oBS = ("" & dr(FilaObs)("TOBS")).ToString.Trim
                    If oBS.Length > 0 AndAlso Not ListVisitObs.Contains(oBS) Then
                        ListVisitObs.Add(oBS, oBS)
                        sbText.Append(oBS)
                        sbText.Append(Chr(10))
                    End If
                Next
                dt.Rows(Fila)("TOBS") = sbText.ToString.Trim
            Else
                dt.Rows(Fila)("TOBS") = ""
            End If
        Next
        Return dt
    End Function


    Private Sub btnAdicionarItemParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarItemParcial.Click
     
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Try
            Dim _pCCMPN As String = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
            Dim _pCCMPN_DESC As String = cmbCompania.CCMPN_Descripcion
            Dim frm As New frmBuscarOC
            Dim PSNORCML As String = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value.ToString.Trim
            Dim PNCCLNT As Decimal = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
            Dim NRPARC As Decimal = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
            Dim PSTCMPL As String = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value & "-" & dtgOC_X_Item.CurrentRow.Cells("TCMPL").Value.ToString.Trim
            Dim PSCDVSN As String = dtgOC_X_Item.CurrentRow.Cells("CDVSN").Value
            Dim PNCPLNDV As String = dtgOC_X_Item.CurrentRow.Cells("CPLNDV").Value
            frm = New frmBuscarOC(_pCCMPN, _pCCMPN_DESC, PSTCMPL, PNCCLNT, PSNORCML, NRPARC, PSCDVSN, PNCPLNDV)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgOC_X_Item_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgOC_X_Item.KeyUp
        If dtgOC_X_Item.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
            Try
                llenar_Tab()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function NameTabSeleccionado() As String
        Return Me.TabOpciones.SelectedTab.Name.ToUpper
    End Function


    Private Sub chkCheckPoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckPoint.CheckedChanged
        If (chkCheckPoint.Checked = True AndAlso cmbCliente.pCodigo = 0) Then
            MessageBox.Show("Debe de Ingresar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chkCheckPoint.Checked = False
            Exit Sub
        End If
        gbCheckPoint.Enabled = chkCheckPoint.Checked
    End Sub

    Private Sub btnDocAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocAdjunto.Click
        If dtgOC_X_Item.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If (dtgOC_X_Item.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Try
            Dim CCLNT As Decimal = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
            Dim CCMPN As String = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
            Dim NMRGIM As Decimal = kgvItemOC.CurrentRow.Cells("NMRGIM").Value
            Dim TABLE_NAME As String = "RZOL39P"
            Dim USER_NAME As String = HelpUtil.UserName
            Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.PreEmbarque)
            ofrmAdjuntarDocumentos.pPNRPEMB = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
            ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
            ofrmAdjuntarDocumentos.ShowDialog()
            ListarItemPorOrdenCompraPracial()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kgvItemOC_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles kgvItemOC.CellContentDoubleClick
        If (kgvItemOC.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim Columna As String = kgvItemOC.Columns(e.ColumnIndex).Name
        Try
            If Columna = "IMG_NMRGIM" AndAlso kgvItemOC.CurrentRow.Cells("NMRGIM_IMAGEN").Value > 0 Then
                Dim CCLNT As Decimal = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
                Dim CCMPN As String = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
                Dim NMRGIM As Decimal = kgvItemOC.CurrentRow.Cells("NMRGIM").Value
                Dim NRPEMB As Decimal = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
                Dim TABLE_NAME As String = "RZOL39P"
                Dim USER_NAME As String = HelpUtil.UserName
                Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.PreEmbarque)
                ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
                ofrmAdjuntarDocumentos.ShowDialog()
                ListarItemPorOrdenCompraPracial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpUtil.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then

            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "S"
                cmbDivision.pHabilitado = False
            End If
            cmbDivision.pActualizar()
            cmbDivision_Seleccionar(Nothing)

            kgvItemOC.DataSource = Nothing
            dtgOC_X_Item.DataSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If


        'Try
        '    cmbDivision.Usuario = HelpUtil.UserName
        '    cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        '    If obeCompania.CCMPN_CodigoCompania = "EZ" Then
        '        cmbDivision.DivisionDefault = "S"
        '        cmbDivision.pHabilitado = False
        '    End If
        '    cmbDivision.pActualizar()
        '    cmbDivision_Seleccionar(Nothing)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub


    Private Sub btnActParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActParcial.Click
        Try
            If dtgOC_X_Item.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim oDtItemParcial As New DataTable
            Dim intCont As Int32 = 0
            oDtItemParcial.Columns.Add("NRPEMB")
            oDtItemParcial.Columns.Add("NORCML")
            oDtItemParcial.Columns.Add("NRPARC")
            oDtItemParcial.Columns.Add("NRITOC")
            oDtItemParcial.Columns.Add("SBITOC")
            oDtItemParcial.Columns.Add("TDITES")
            oDtItemParcial.Columns.Add("QRLCSC")
            Dim oDr As DataRow
            For intCont = 0 To kgvItemOC.Rows.Count - 1
                oDr = oDtItemParcial.NewRow
                oDr.Item("NRPEMB") = kgvItemOC.Rows(intCont).Cells("COLNRPEMB").Value
                oDr.Item("NORCML") = kgvItemOC.Rows(intCont).Cells("COLNORCML").Value.ToString.Trim
                oDr.Item("NRPARC") = kgvItemOC.Rows(intCont).Cells("COLNRPARC").Value
                oDr.Item("NRITOC") = kgvItemOC.Rows(intCont).Cells("COLNRITOC").Value
                oDr.Item("SBITOC") = kgvItemOC.Rows(intCont).Cells("COLSBITOC").Value.ToString.Trim
                oDr.Item("TDITES") = kgvItemOC.Rows(intCont).Cells("COLTDITES").Value.ToString.Trim
                oDr.Item("QRLCSC") = kgvItemOC.Rows(intCont).Cells("COLQRLCSC").Value
                oDtItemParcial.Rows.Add(oDr)
            Next intCont

            Dim ofrmModificarParcial As New frmModificarParcial
            ofrmModificarParcial.pdItemParcial = oDtItemParcial
            ofrmModificarParcial.pCCLNT = dtgOC_X_Item.CurrentRow.Cells("CCLNT").Value
            ofrmModificarParcial.pNORCML = dtgOC_X_Item.CurrentRow.Cells("NORCML_1").Value.ToString.Trim
            ofrmModificarParcial.pNRPARC = dtgOC_X_Item.CurrentRow.Cells("NRPARC").Value
            ofrmModificarParcial.pCCMPN = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
            ofrmModificarParcial.ShowDialog()
            If (ofrmModificarParcial.pDialogResult = True) Then
                fnBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            fnBuscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModifParcialItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifParcialItem.Click
        Try
            If kgvItemOC.CurrentRow IsNot Nothing Then

                Dim ofrmModificarlParcialItem As New frmModificarlParcialItem
                ofrmModificarlParcialItem.pNORCML = kgvItemOC.CurrentRow.Cells("COLNORCML").Value.ToString.Trim
                ofrmModificarlParcialItem.pNRITOC = kgvItemOC.CurrentRow.Cells("COLNRITOC").Value
                ofrmModificarlParcialItem.pNRPARC = kgvItemOC.CurrentRow.Cells("COLNRPARC").Value
                ofrmModificarlParcialItem.pNRPEMB = kgvItemOC.CurrentRow.Cells("COLNRPEMB").Value
                ofrmModificarlParcialItem.pSBITOC = kgvItemOC.CurrentRow.Cells("COLSBITOC").Value.ToString.Trim
                ofrmModificarlParcialItem.pCCLNT = kgvItemOC.CurrentRow.Cells("COLCCLNT").Value
                ofrmModificarlParcialItem.pCCMPN = dtgOC_X_Item.CurrentRow.Cells("CCMPN").Value
                ofrmModificarlParcialItem.ShowDialog()
                If ofrmModificarlParcialItem.pDialogResult = True Then
                    fnBuscar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCargaInternacional_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            dtgOC_X_Item.DataSource = Nothing
            kgvItemOC.DataSource = Nothing
            Listar_Orden_Compra()
            ListarItemPorOrdenCompraPracial()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
    '    Try
    '        cmbDivision.Usuario = HelpUtil.UserName
    '        cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
    '        If obeCompania.CCMPN_CodigoCompania = "EZ" Then
    '            cmbDivision.DivisionDefault = "S"
    '            cmbDivision.pHabilitado = False
    '        End If
    '        cmbDivision.pActualizar()
    '        cmbDivision_Seleccionar(Nothing)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            cmbPlanta.Usuario = HelpUtil.UserName
            cmbPlanta.CodigoCompania = cmbDivision.Compania
            cmbPlanta.CodigoDivision = cmbDivision.Division
            cmbPlanta.PlantaDefault = 1
            cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
  
End Class
