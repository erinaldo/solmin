Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Controls.ServicioOperacion
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Threading

Public Class frmPLFacElectronicoSD



#Region "Atributos"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean
    Private objCompania As New clsFacturaPreDoc_BL

    Private objDivision As New clsFacturaPreDoc_BL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    Private dgwPreFacturacionChk As Boolean = False
    Private dgwLiquidacionChk As Boolean = False
    Private cOrgVenta As String = ""
    Private dOrgVenta As String = ""
    Private Aprobador As String = "" ''CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    'Private oHebraEnvioEmailReq As Thread

    Private checkAll As Boolean = False
    Enum TipoCliente
        Interno = 0
        Externo = 1
    End Enum
#End Region

    
    Private Sub frmPreLiquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dtgPreDocumentos.AutoGenerateColumns = False
            dgwLiquidacion.AutoGenerateColumns = False
            CargarTipo()
            Me.Cargar_Compania()
            cmbTipo_SelectionChangeCommitted(cmbTipo, Nothing)
            lblAvance.Text = ""

            PictureBox1.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub CargarTipo()
        Dim dt As New DataTable
        dt.Columns.Add("COD")
        dt.Columns.Add("DESC")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("COD") = "G"
        dr("DESC") = "General"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COD") = "R"
        dr("DESC") = "Recupero Seguro"
        dt.Rows.Add(dr)

        cmbTipo.DataSource = dt
        cmbTipo.DisplayMember = "DESC"
        cmbTipo.ValueMember = "COD"
        cmbTipo.SelectedValue = "G"

    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim tiposelec As String = cmbTipo.SelectedValue
            If (tiposelec = "G" And Me.txtClienteFiltro.pCodigo = 0) Then
                MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            lblAvance.Text = ""
            Me.Listar_Liquidacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub InicializarFormulario()

        Me.dgwLiquidacion.DataSource = Nothing
        Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
    End Sub
    '    '-------------------------------------------------------------------------------------------------------------------------------------
    Private Sub dgwLiquidacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellContentClick

        Try

            If e.RowIndex >= 0 Then
                If dgwLiquidacion.Columns(e.ColumnIndex).Name = "btnDetalleLiquidacion" Then
                    Me.Cursor = Cursors.WaitCursor
                    If Me.dgwLiquidacion.CurrentCellAddress.Y < 0 Then Exit Sub
                    If Existe_Ventana(frmConsultaPreFac.Name) Then Exit Sub
                    Dim objfrmConsultaPreFac As New frmConsultaPreFac()

                    With objfrmConsultaPreFac
                        .mNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                        .mCompania = Me.cboCompania.SelectedValue
                        .pCDVSN = Me.cboDivision.SelectedValue
                        .ORGVENTA = Me.dgwLiquidacion.CurrentRow.Cells("TCRVTA_L").Value()
                        '--------------------------------------------------------------------
                        .pCCLNT = txtClienteFiltro.pCodigo
                        .pCCLNFC = txtClienteFiltro.pCodigo
                     
                        .ShowDialog()
                        Me.Listar_Liquidacion()
                    End With
                    Me.Cursor = Cursors.Default

                ElseIf dgwLiquidacion.Columns(e.ColumnIndex).Name = "NOPRCN" Then

                    Dim objfrmOperacion As New frmOpeXPreLiquidacion
                    With objfrmOperacion
                        '--------------------------------------------------------------------
                        .PNCCLNT = txtClienteFiltro.pCodigo
                       
                        .PNNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                        .PSCCMPN = Me.cboCompania.SelectedValue
                        .PSCDVSN = Me.cboDivision.SelectedValue
                    End With
                    objfrmOperacion.ShowDialog()

                End If
            End If


            MostrarTotalSeleccionados()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub MostrarTotalSeleccionados()
        dgwLiquidacion.EndEdit()
        Dim Escheck As Boolean = False
        Dim cantSel As Integer = 0

        Dim totSol As Decimal = 0
        Dim totDol As Decimal = 0
        Dim idMoneda As Decimal = 0
        Dim importeFact As Decimal = 0


        For Each item As DataGridViewRow In dgwLiquidacion.Rows
            Escheck = item.Cells("chk2").Value

            idMoneda = item.Cells("CMNDA1").Value
            importeFact = item.Cells("IVLSRV_PL").Value

            If Escheck Then
                cantSel = cantSel + 1

                idMoneda = item.Cells("CMNDA1").Value
                importeFact = item.Cells("IVLSRV_PL").Value

                If idMoneda = 1 Then
                    totSol = totSol + importeFact
                End If
                If idMoneda = 100 Then
                    totDol = totDol + importeFact
                End If



            End If
        Next
        totSol = Math.Round(totSol, 2)
        totDol = Math.Round(totDol, 2)
        'lblseleccionados.Text = "Seleccionados:" & cantSel
        lblseleccionados.Text = "[Seleccionados :" & cantSel & "]   SOLES: " & totSol & " + DOLAR: " & totDol
    End Sub
    '' -----------------------------------------------------------------------------------------------------------------------------------------
    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.ParentForm.MdiChildren.Length - 1
            If Me.ParentForm.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.ParentForm.MdiChildren(intCont).WindowState = FormWindowState.Maximized
                Me.ParentForm.MdiChildren(intCont).Show()
                Return True
            End If
        Next intCont
        Return False
    End Function

    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
       
        For intContador As Integer = 0 To Sender.RowCount - 1
            If Sender.Item("chk2", intContador).Value = True Then
                If intIndice = 0 Then
                    
                    cOrgVenta = Sender.Item("CRGVTA_L", intContador).Value
                    dOrgVenta = Sender.Item("TCRVTA_L", intContador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                  
                    If Sender.Item("CRGVTA_L", intContador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If
        Next
        Return lstr_Estado
    End Function


    Private Sub btnAnularPreliquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularPreliquidacion.Click

        Try

            If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
            If dtgPreDocumentos.Rows.Count > 0 Then
                MessageBox.Show("No puede anular PL con Pre-Documentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea anular la Pre-Liquidación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Dim obj_Logica As New clsFacturaPreDoc_BL
            Dim objEntidad As New FacturaPreDoc_BE
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
            Dim lintResultado As Integer = 0
            dgwLiquidacion.EndEdit()

            Dim numDoc As Decimal = Val("" & dgwLiquidacion.CurrentRow.Cells("NUMDOC").Value)

            If numDoc > 0 Then
                MessageBox.Show("PL con documento asignado.No puede anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

          
            objEntidad = New FacturaPreDoc_BE
            objEntidad.NPRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            objEntidad.CCMPN = Me.cboCompania.SelectedValue
            objEntidad.CDVSN = Me.cboDivision.SelectedValue

            objEntidad.CPLNCL = 0
            objEntidad.CULUSA = ConfigurationWizard.UserName
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objGenericCollection.Add(objEntidad)
          
            If objGenericCollection.Count = 0 Then Exit Sub

            obj_Logica.Anular_Liquidacion_ADMIN(objGenericCollection)
            HelpClass.MsgBox("Se anuló la Pre - Liquidación Satisfactoriamente")
            Me.Listar_Liquidacion()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub



    Private Sub cboCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectionChangeCommitted
        Try
            If bolBuscar Then
                Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    

    Private Sub dgwLiquidacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellDoubleClick
        'If e.RowIndex = -1 And e.ColumnIndex = 0 Then
        '    If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
        '    Dim lintEstado As Boolean = Me.dgwLiquidacion.Item(0, 0).Value
        '    For lint_Contador As Integer = 0 To Me.dgwLiquidacion.RowCount - 1
        '        Me.dgwLiquidacion.Item(0, lint_Contador).Value = Not lintEstado
        '        Me.dgwLiquidacion.EndEdit()
        '    Next
        'End If

        MostrarTotalSeleccionados()
    End Sub

    

    Private Sub Cargar_Compania()

        objCompania.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompania.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        bolBuscar = True

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        cboCompania_SelectionChangeCommitted(Nothing, Nothing)
       
    End Sub

    Private Sub Cargar_Division()

        If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
            bolBuscar = False
            objDivision.Crea_ListaD()
            Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
            Me.cboDivision.ValueMember = "CDVSN"
            bolBuscar = True
            Me.cboDivision.DisplayMember = "TCMPDV"
            Me.cboDivision.SelectedValue = "R"
            If Me.cboDivision.SelectedIndex = -1 Then
                Me.cboDivision.SelectedIndex = 0
            End If

        End If
      
    End Sub
    
    Private Sub Listar_Liquidacion()
        Dim dtResult As New DataTable

        Dim obrFiltroPreDoc As New clsFacturaPreDoc_BL
        Dim oPreDocFiltro As New FacturaPreDoc_BE
        oPreDocFiltro = New FacturaPreDoc_BE
        oPreDocFiltro.CCLNT = txtClienteFiltro.pCodigo
        oPreDocFiltro.CCMPN = cboCompania.SelectedValue
        oPreDocFiltro.CDVSN = cboDivision.SelectedValue
        Dim codTipoVista As String = cmbTipo.SelectedValue
        dtResult = obrFiltroPreDoc.Listar_Liquidacion_ADMIN(oPreDocFiltro, codTipoVista)
        dgwLiquidacion.DataSource = dtResult
        
    End Sub

   

    Private Function ObtenerTipoCambio() As Double
        Dim oDt As DataTable
        Dim oFiltro As New Hashtable
        Dim ldtpFechaFactura As Date = Now
        Dim dblTipoCambio As Double = 0
        Dim oFacturaNeg As New clsFacturaPreDoc_BL
        oFiltro.Add("PNCMNDA1", "100")
        oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PSCCMPN", Me.cboCompania.SelectedValue)

        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count > 0 Then
            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
        End If
        Return dblTipoCambio
    End Function

    
    Private Sub btnEditPL_Click(sender As Object, e As EventArgs) Handles btnEditPL.Click
        Try
            If dgwLiquidacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmEditPLDOC As New frmEditLiquidacionSD
            ofrmEditPLDOC.pCCMPN = Me.cboCompania.SelectedValue
            ofrmEditPLDOC.pCDVSN = Me.cboDivision.SelectedValue
            ofrmEditPLDOC.pNPRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            If ofrmEditPLDOC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Listar_Liquidacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnPreDoc_Click(sender As Object, e As EventArgs) Handles btnPreDoc.Click
        Try

            Dim ofrmGenerarPreDoc As New Ransa.Controls.ServicioOperacion.frmGenerarPreDoc
            If dgwLiquidacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            ofrmGenerarPreDoc.pNRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            ofrmGenerarPreDoc.pCCMPN = cboCompania.SelectedValue
            ofrmGenerarPreDoc.pCCNLT = txtClienteFiltro.pCodigo
           
            ofrmGenerarPreDoc.pTIPOPL = "A"
            ofrmGenerarPreDoc.ShowDialog()
            If ofrmGenerarPreDoc.pDialog = True Then
                Me.Listar_Liquidacion()
            End If
          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dtgPreDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPreDocumentos.CellContentClick
        If e.RowIndex >= 0 Then
            If dtgPreDocumentos.Columns(e.ColumnIndex).Name = "OPERACION" Then

                Dim objfrmOperacion As New frmOperacionesXPreDoc

                objfrmOperacion.PSCCMPN = cboCompania.SelectedValue
                objfrmOperacion.PNNRCTRL = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value

                objfrmOperacion.PSTPCTRL = Me.dtgPreDocumentos.CurrentRow.Cells("TPCTRL").Value
                objfrmOperacion.PNNCRRPD = Me.dtgPreDocumentos.CurrentRow.Cells("NCRRPD").Value

                objfrmOperacion.ShowDialog()
            End If
        End If
    End Sub



    Private Sub dgwLiquidacion_SelectionChanged(sender As Object, e As EventArgs) Handles dgwLiquidacion.SelectionChanged

        Try
 
            If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
 
            Dim dtResult As New DataTable

            Dim obrFiltroPreDoc As New clsFacturaPreDoc_BL
            Dim oPreDocFiltro As New FacturaPreDoc_BE
            oPreDocFiltro = New FacturaPreDoc_BE
            oPreDocFiltro.PSCCMPN = cboCompania.SelectedValue
            oPreDocFiltro.PNNRCTRL = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            oPreDocFiltro.PSTIPOPL = "A"
            dtResult = obrFiltroPreDoc.ListarPLDocumentos_ADMIN(oPreDocFiltro)
            dtgPreDocumentos.DataSource = dtResult
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

   

    Function Lista_NROPD() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dtgPreDocumentos.Rows
            strCadDocumentos = strCadDocumentos & ("" & row.Cells("NCRRPD").Value).ToString.Trim & ","

        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    

    Private Sub btnFacturaPreLiquidacion_Click(sender As Object, e As EventArgs) Handles btnFacturaPreLiquidacion.Click


        Dim ofrmOpcionFactura As New frmOpcionFactura
        Dim strRegionVenta As String = String.Empty
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

        Dim objfrmVFactura As frmGenararFacturaElectronica
        
        '-------------------------------------------------
        Dim TipoVista As Integer = 0
        Try

            If dtgPreDocumentos.Rows.Count > 0 Then
                'MessageBox.Show("No puede Facturar PL con Pre-Documentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show("PL con Pre-Documentos.Para facturar seleccione opción :> Facturar Pre-Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim tipo As String = cmbTipo.SelectedValue

            If tipo = "R" Then
                TipoVista = "1"
            Else


                If ofrmOpcionFactura.ShowDialog = Windows.Forms.DialogResult.OK Then
                    TipoVista = ofrmOpcionFactura.CodTipoOpcion
                Else
                    Exit Sub
                End If

            End If



            Dim strCadDocumentos As String = ""
            If dgwLiquidacion.RowCount = 0 Then Exit Sub
            Dim objFiltro As New clsFacturaPreDoc_BL
            Dim pCCMPN As String = ""
            Dim pCDVSN As String = ""
            Dim pCCLNT As Decimal = 0
            Dim Pl As String = ""
            Dim pIdMoneda As Decimal = 0
            Dim pCCLNFC As Decimal = 0
            Dim pCCLNOP As Decimal = 0
            Dim Region As String = ""

            Dim TipoLista As String = "PRL"
            Dim oFiltro As New Hashtable
            Dim HabilitarBotonFactura As Boolean = True


            Select Case tipo
                Case "G"

                    pCCMPN = dgwLiquidacion.CurrentRow.Cells("CCMPN").Value
                    pCDVSN = dgwLiquidacion.CurrentRow.Cells("CDVSN").Value
                    pCCLNT = dgwLiquidacion.CurrentRow.Cells("CCLNT").Value
                    Pl = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
                    pIdMoneda = dgwLiquidacion.CurrentRow.Cells("CMNDA1").Value
                    pCCLNFC = dgwLiquidacion.CurrentRow.Cells("CCLNFC").Value
                    pCCLNOP = dgwLiquidacion.CurrentRow.Cells("CCLNT").Value
                    Region = dgwLiquidacion.CurrentRow.Cells("CRGVTA_L").Value

                    Dim mensajeValidOpConsistencia As String = oFacturaNeg.Validar_Listado_Facturacion(pCCMPN, pCDVSN, pCCLNT, Pl, TipoLista)
                    If mensajeValidOpConsistencia <> String.Empty Or mensajeValidOpConsistencia <> "" Then
                        MessageBox.Show(mensajeValidOpConsistencia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        HabilitarBotonFactura = False

                    End If

                    objfrmVFactura = New frmGenararFacturaElectronica(Pl, TipoLista) 'csr-hotfix/031116_Visualizacion_Formato_Factura
                    objfrmVFactura.pCCMPN = pCCMPN
                    objfrmVFactura.pCDVSN = pCDVSN
                    objfrmVFactura.pIdMoneda = pIdMoneda
                    objfrmVFactura.pCCLNFC = pCCLNFC
                    objfrmVFactura.pTIPOFACTURA = TipoVista
                    objfrmVFactura.pCCLNOP = pCCLNOP

                    objfrmVFactura.ShowDialog()
                    If objfrmVFactura.pDialog = True Then
                        Me.Listar_Liquidacion()
                    End If

                Case "R"


                    Dim CantCheckSelec As Integer = 0
                    Dim numeroDocFact As Decimal = 0

                    dgwLiquidacion.EndEdit()
                    lblAvance.Text = ""
                    For Each item As DataGridViewRow In dgwLiquidacion.Rows
                        numeroDocFact = Val("" & item.Cells("NUMDOC").Value)
                        If item.Cells("chk2").Value = True And numeroDocFact = 0 Then
                            CantCheckSelec = CantCheckSelec + 1
                        End If
                    Next
                    If CantCheckSelec = 0 Then
                        MessageBox.Show("Seleccione PL( sin asignación de documento).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                   

                    PictureBox1.Visible = True
                    Dim FilaAvanceFact As Integer = 0
                    lblAvance.Text = "EN PROCESO " & FilaAvanceFact & " DE " & CantCheckSelec
                    For Each item As DataGridViewRow In dgwLiquidacion.Rows
                        numeroDocFact = Val("" & item.Cells("NUMDOC").Value)
                        If item.Cells("chk2").Value = True And numeroDocFact = 0 Then

                            FilaAvanceFact = FilaAvanceFact + 1

                            pCCMPN = item.Cells("CCMPN").Value
                            pCDVSN = item.Cells("CDVSN").Value
                            pCCLNT = item.Cells("CCLNT").Value
                            Pl = item.Cells("NPRLQD").Value
                            pIdMoneda = item.Cells("CMNDA1").Value
                            pCCLNFC = item.Cells("CCLNFC").Value
                            pCCLNOP = item.Cells("CCLNT").Value
                            Region = item.Cells("CRGVTA_L").Value

                            Dim mensajeValidOpConsistencia As String = oFacturaNeg.Validar_Listado_Facturacion(pCCMPN, pCDVSN, pCCLNT, Pl, TipoLista)
                            If mensajeValidOpConsistencia <> String.Empty Or mensajeValidOpConsistencia <> "" Then
                                MessageBox.Show(mensajeValidOpConsistencia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                HabilitarBotonFactura = False
                            End If

                            objfrmVFactura = New frmGenararFacturaElectronica(Pl, TipoLista) 'csr-hotfix/031116_Visualizacion_Formato_Factura
                            objfrmVFactura.pCCMPN = pCCMPN
                            objfrmVFactura.pCDVSN = pCDVSN
                            objfrmVFactura.pIdMoneda = pIdMoneda
                            objfrmVFactura.pCCLNFC = pCCLNFC
                            objfrmVFactura.pTIPOFACTURA = TipoVista
                            objfrmVFactura.pCCLNOP = pCCLNOP
                            objfrmVFactura.InicioCierrAutomaticoPostFactOK = (chkAvance.Checked = True)
                            objfrmVFactura.esRecuperoCarga = True


                            objfrmVFactura.ShowDialog()
                            If objfrmVFactura.pDialog = True Then
                                item.Cells("NUMDOC").Value = objfrmVFactura.ret_NumeroDocumento

                                If FilaAvanceFact < CantCheckSelec Then
                                    lblAvance.Text = "EN PROCESO " & FilaAvanceFact & " DE " & CantCheckSelec
                                Else
                                    lblAvance.Text = "FINALIZADO " & FilaAvanceFact & " DE " & CantCheckSelec
                                End If

                            Else
                                Exit For
                            End If


                        End If

                    Next
                    PictureBox1.Visible = False

            End Select

          
           
           
            
        Catch ex As Exception
            PictureBox1.Visible = False

            MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Private Sub EjecutarMasivoFactura()

    '    Dim tipo As String = cmbTipo.SelectedValue
    '    Dim TipoVista As Integer = 0


    '    Dim ofrmOpcionFactura As New frmOpcionFactura
    '    Dim strRegionVenta As String = String.Empty
    '    Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
    '    Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

    '    Dim objfrmVFactura As frmGenararFacturaElectronica

    '    Dim strCadDocumentos As String = ""
    '    If dgwLiquidacion.RowCount = 0 Then Exit Sub
    '    Dim objFiltro As New clsFacturaPreDoc_BL
    '    Dim pCCMPN As String = ""
    '    Dim pCDVSN As String = ""
    '    Dim pCCLNT As Decimal = 0
    '    Dim Pl As String = ""
    '    Dim pIdMoneda As Decimal = 0
    '    Dim pCCLNFC As Decimal = 0
    '    Dim pCCLNOP As Decimal = 0
    '    Dim Region As String = ""

    '    Dim TipoLista As String = "PRL"
    '    Dim oFiltro As New Hashtable
    '    Dim HabilitarBotonFactura As Boolean = True

    '    Dim CantCheckSelec As Integer = 0
    '    Dim numeroDocFact As Decimal = 0

    '    If tipo = "R" Then
    '        TipoVista = "1"
    '    Else


    '        If ofrmOpcionFactura.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            TipoVista = ofrmOpcionFactura.CodTipoOpcion
    '        Else
    '            Exit Sub
    '        End If

    '    End If


    '    Dim FilaAvanceFact As Integer = 0
    '    PictureBox1.Visible = True
    '    lblAvance.Text = "AVANCE " & FilaAvanceFact & " DE " & CantCheckSelec
    '    For Each item As DataGridViewRow In dgwLiquidacion.Rows
    '        numeroDocFact = Val("" & item.Cells("NUMDOC").Value)
    '        If item.Cells("chk2").Value = True And numeroDocFact = 0 Then

    '            FilaAvanceFact = FilaAvanceFact + 1

    '            pCCMPN = item.Cells("CCMPN").Value
    '            pCDVSN = item.Cells("CDVSN").Value
    '            pCCLNT = item.Cells("CCLNT").Value
    '            Pl = item.Cells("NPRLQD").Value
    '            pIdMoneda = item.Cells("CMNDA1").Value
    '            pCCLNFC = item.Cells("CCLNFC").Value
    '            pCCLNOP = item.Cells("CCLNT").Value
    '            Region = item.Cells("CRGVTA_L").Value

    '            Dim mensajeValidOpConsistencia As String = oFacturaNeg.Validar_Listado_Facturacion(pCCMPN, pCDVSN, pCCLNT, Pl, TipoLista)
    '            If mensajeValidOpConsistencia <> String.Empty Or mensajeValidOpConsistencia <> "" Then
    '                MessageBox.Show(mensajeValidOpConsistencia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                HabilitarBotonFactura = False
    '            End If

    '            objfrmVFactura = New frmGenararFacturaElectronica(Pl, TipoLista) 'csr-hotfix/031116_Visualizacion_Formato_Factura
    '            objfrmVFactura.pCCMPN = pCCMPN
    '            objfrmVFactura.pCDVSN = pCDVSN
    '            objfrmVFactura.pIdMoneda = pIdMoneda
    '            objfrmVFactura.pCCLNFC = pCCLNFC
    '            objfrmVFactura.pTIPOFACTURA = TipoVista
    '            objfrmVFactura.pCCLNOP = pCCLNOP
    '            objfrmVFactura.InicioCierrAutomaticoPostFactOK = (chkAvance.Checked = True)
    '            objfrmVFactura.esRecuperoCarga = True


    '            objfrmVFactura.ShowDialog()
    '            If objfrmVFactura.pDialog = True Then
    '                item.Cells("NUMDOC").Value = objfrmVFactura.ret_NumeroDocumento

    '                lblAvance.Text = "AVANCE " & FilaAvanceFact & " DE " & CantCheckSelec
    '            Else
    '                Exit For
    '            End If


    '        End If

    '    Next
    '    PictureBox1.Visible = False

    'End Sub
    '---------- '----------------FIXSUMMIT-----------------'
    Private Sub btnFacturaPreDoc_Click(sender As Object, e As EventArgs) Handles btnFacturaPreDoc.Click

        Dim TipoLista As String = "PRL"
        Dim ofrmOpcionFactura As New frmOpcionFactura
        Dim oTipoVista As String = "0"
      

        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

        Dim objfrmVFactura As frmGenararFacturaElectronica
        
        Dim intTipo As Integer = oTipoVista


        If dgwLiquidacion.CurrentRow Is Nothing Then
            Exit Sub
        End If
        '-------------------------------------------------
        Try


            If dtgPreDocumentos.Rows.Count = 0 Then
                MessageBox.Show("No puede Facturar PL sin Pre-Documentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dgwLiquidacion.CurrentRow.Cells("ESTADO_PL").Value = "B" Then
                MessageBox.Show("No puede Facturar PL en Pre-Documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ofrmOpcionFactura.ShowDialog = Windows.Forms.DialogResult.OK Then
                oTipoVista = ofrmOpcionFactura.CodTipoOpcion
            Else
                Exit Sub
            End If

            Dim pCCMPN As String = ""
            Dim pCDVSN As String = ""
            Dim pIdMoneda As Decimal = 0
            Dim pCCLNFC As Decimal = 0
            Dim pCRGVTA As String = ""

            Dim pCCLNOP As Decimal = 0
            Dim Pl As String
            Dim pNCRRPD As String = ""


            pCCMPN = dgwLiquidacion.CurrentRow.Cells("CCMPN").Value
            pCDVSN = dgwLiquidacion.CurrentRow.Cells("CDVSN").Value
            pIdMoneda = dgwLiquidacion.CurrentRow.Cells("CMNDA1").Value
            pCCLNFC = dgwLiquidacion.CurrentRow.Cells("CCLNFC").Value
            pCRGVTA = dgwLiquidacion.CurrentRow.Cells("CRGVTA_L").Value
            pCCLNOP = dgwLiquidacion.CurrentRow.Cells("CCLNT").Value
            Pl = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            pNCRRPD = Lista_NROPD()



            Dim strCadDocumentos As String = ""
            If dgwLiquidacion.RowCount = 0 Then Exit Sub
           
 

            Dim HabilitarBotonFactura As Boolean = True


            Dim mensajeValidOpConsistencia As String = oFacturaNeg.Validar_Listado_Facturacion(pCCMPN, pCDVSN, pCCLNOP, Pl, TipoLista)
            If mensajeValidOpConsistencia <> String.Empty Or mensajeValidOpConsistencia <> "" Then
                MessageBox.Show(mensajeValidOpConsistencia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                HabilitarBotonFactura = False
                'Exit Sub
            End If

             
            objfrmVFactura = New frmGenararFacturaElectronica(Pl, TipoLista) 'csr-hotfix/031116_Visualizacion_Formato_Factura
            objfrmVFactura.pCCMPN = pCCMPN
            objfrmVFactura.pCDVSN = pCDVSN
            objfrmVFactura.pIdMoneda = pIdMoneda
            objfrmVFactura.pCCLNFC = pCCLNFC

            objfrmVFactura.pTIPOFACTURA = oTipoVista
            objfrmVFactura.pCCLNOP = pCCLNOP
            objfrmVFactura.pNROPL = Pl
            objfrmVFactura.EsXPreDocumento = True
            objfrmVFactura.pPreDocumentoList = pNCRRPD



            objfrmVFactura.ShowDialog()
            If objfrmVFactura.pDialog = True Then
                Me.Listar_Liquidacion()
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVerPreDoc_Click(sender As Object, e As EventArgs) Handles btnVerPreDoc.Click

        Try

            Dim ofrmNroPL As New Ransa.Controls.ServicioOperacion.frmNroPL
            Dim ofrmGenerarPreDoc As New Ransa.Controls.ServicioOperacion.frmGenerarPreDoc

            If txtClienteFiltro.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ofrmNroPL.ShowDialog = Windows.Forms.DialogResult.OK Then
                ofrmGenerarPreDoc.pNRLQD = ofrmNroPL.NRO_PL
                ofrmGenerarPreDoc.pCCMPN = cboCompania.SelectedValue
                ofrmGenerarPreDoc.pCCNLT = txtClienteFiltro.pCodigo
                ofrmGenerarPreDoc.pTIPOPL = "A"
                ofrmGenerarPreDoc.pSoloLectura = True
                ofrmGenerarPreDoc.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTipo.SelectionChangeCommitted

        Try
            Dim tipo As String = cmbTipo.SelectedValue
            dgwLiquidacion.Columns("chk2").Visible = (tipo = "R")
            chkAvance.Visible = (tipo = "R")
            chkAvance.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Try
            dgwLiquidacion.EndEdit()
            checkAll = Not checkAll
            'Dim cantSel As Integer = 0          
            For Each item As DataGridViewRow In dgwLiquidacion.Rows
                item.Cells("chk2").Value = checkAll               
                'If (checkAll = True) Then
                '    cantSel = cantSel + 1
                'End If
            Next
            dgwLiquidacion.EndEdit()
            'lblseleccionados.Text = "Seleccionados:" & cantSel & " Soles:" & totSol & " Dol:" & totDol
            MostrarTotalSeleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Try
    '        EjecutarMasivoFactura()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If dgwLiquidacion.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Ransa.Utilitario.Encabezados)

            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Ransa.Utilitario.Encabezados("", Ransa.Utilitario.Encabezados.TIPOENCABEZADO.FILENAME, "Reporte PL"))
            loEncabezados.Add(New Ransa.Utilitario.Encabezados("", Ransa.Utilitario.Encabezados.TIPOENCABEZADO.HOJA, "Reporte PL"))
            loEncabezados.Add(New Ransa.Utilitario.Encabezados("", Ransa.Utilitario.Encabezados.TIPOENCABEZADO.TITULO, "REPORTE PLS"))
            loEncabezados.Add(New Ransa.Utilitario.Encabezados("", Ransa.Utilitario.Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.dgwLiquidacion.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


            'For Each dr As DataRow In objDt.Rows
            '    dr("NORCML") = dr("NORCML").ToString.Replace(",", "," + Chr(10)).ToString
            '    dr("NGUIRM") = dr("NGUIRM").ToString.Replace(",", "," + Chr(10)).ToString
            '    dr.AcceptChanges()
            'Next
            ODs.Tables.Add(Ransa.Utilitario.HelpClass_NPOI.TransformarGrilla(Me.dgwLiquidacion, objDt))

            'For Each dc As DataColumn In ODs.Tables(0).Columns
            '    Select Case dc.Caption
            '        Case "NORCML", "NGUIRM", "NOPRCN", "NPLVHT", "NPLCAC", "NMNFCR", "NGUITR", "CCNCST", "CCNBNS", "NLQDCN"
            '            dc.Caption = Ransa.Utilitario.HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            '        Case "PBRTOR", "PTRAOR", "PNETO", "IMPCO", "IMPCO_SOLES", "IMPPA", _
            '             "IMPPA_SOLES", "GASTOS", "GASTOAVC", "QGLNCM", "COSTO", "IMPORTE_NETO", "MARGEN", "GASTOAVC"
            '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
            '        Case "TC_COBRAR", "TC_PAGAR"
            '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
            '    End Select
            'Next
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgwLiquidacion_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwLiquidacion.CellContentDoubleClick
        MostrarTotalSeleccionados()
    End Sub
End Class