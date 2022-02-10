Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.ItemGR
Imports Ransa.TypeDef.GuiaRemision
Imports Ransa.DAO.OrdenCompra
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.DATA
Imports Ransa.TypeDef.slnSOLMIN_SDS_SIMPLE

Public Class frmrecepciongrsds


#Region "Region Atributos"




#End Region
    Private _pEstado As String = ""
    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property


#Region " Procedimientos y Funciones "
    Sub pActualizarInformacion()
        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If chkfecha.Checked = False Then
            If Val(txtGuiaRemision.Text.Trim) = 0 AndAlso Val(txtGuiaSalida.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese Guía Remisión/Salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        Dim objAppConfig As cAppConfig = New cAppConfig

        Dim dt As New DataTable
        Dim oFILTRO As New TD_QRY_GuiaRemision_L01
        oFILTRO.PNCCLNT = txtCliente.pCodigo
        oFILTRO.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        oFILTRO.PSCDVSN = UcDivision_Cmb011.Division
        oFILTRO.PNCPLNDV = UcPLanta_Cmb011.Planta
        oFILTRO.NGUIRM = Val(txtGuiaRemision.Text.Trim)
        oFILTRO.GUIASALIDA = Val(txtGuiaSalida.Text.Trim)
        If chkfecha.Checked = True Then
            oFILTRO.pFGUIRM_FechaGR_Inicio = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date)
            oFILTRO.pFGUIRM_FechaGR_Fin = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date)
        Else
            oFILTRO.pFGUIRM_FechaGR_Inicio = 0
            oFILTRO.pFGUIRM_FechaGR_Fin = 0
        End If
        'oFILTRO.PAGESIZE = UcPaginacion1.PageSize
        'oFILTRO.PAGENUMBER = UcPaginacion1.PageNumber
        Dim intNroTotalPaginas As Int64 = 0
        dt = cGuiaRemision.fdtListar_GuiaRemision_L01(oFILTRO, intNroTotalPaginas)
        dgGR.DataSource = dt
        'UcPaginacion1.PageCount = intNroTotalPaginas

        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RecepcionGR_CodigoCliente", txtCliente.pCodigo)
        objAppConfig.SetValue("RecepcionGR_DetalleCliente", txtCliente.pRazonSocial)
        objAppConfig = Nothing

    End Sub

    Sub pActualizarInformacionDetalle()
        Dim dt As DataTable
        Dim strMensajeError As String = ""

        dgItGr.AutoGenerateColumns = False
        Dim intCont As Integer = 0
        If btnMarcarItems.Checked Then
            btnMarcarItems.Checked = False
            Dim img As Image = btnMarcarItems.Image
            btnMarcarItems.Image = btnMarcarItems.BackgroundImage
            btnMarcarItems.BackgroundImage = img
        End If


        Dim TD_GuiaRemisionPK As New TD_GuiaRemisionPK
        TD_GuiaRemisionPK._PSCCMPN = dgGR.CurrentRow.Cells("M_CCMPN").Value
        TD_GuiaRemisionPK._PNCCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value
        TD_GuiaRemisionPK._NGUIRM = dgGR.CurrentRow.Cells("M_NGUIRM").Value
        TD_GuiaRemisionPK._PSCDVSN = dgGR.CurrentRow.Cells("M_CDVSN").Value
        TD_GuiaRemisionPK._PNCPLNDV = dgGR.CurrentRow.Cells("M_CPLNDV").Value


        dt = cItemGuiaRemision.fdtListar_ItemsGR_L01(TD_GuiaRemisionPK)


        dgItGr.DataSource = dt

        Dim i As Integer
        For i = 0 To dgItGr.RowCount - 1
            dgItGr.Rows(i).Cells("M_QCNREC").Value = 0
            dgItGr.Rows(i).Cells("M_PESOREC").Value = 0
        Next



        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataGrid))
        For Each oDgvrItemGR As DataGridViewRow In dgItGr.Rows

            If Not ("" & oDgvrItemGR.Cells("M_NORDSR").Value & "").ToString.Equals("0") Then oDgvrItemGR.Cells("M_IMNORS").Value = My.Resources.button_ok
            If Not ("" & oDgvrItemGR.Cells("M_CMRCD").Value & "").ToString.Trim.Equals("") Then oDgvrItemGR.Cells("M_IMCMR").Value = My.Resources.button_ok
        Next


    End Sub




#End Region



#Region "Métodos"

#End Region

    'Llenar el combo de Division
    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()



    End Sub

    'Llenar el combo de Planta
    Private Sub UcDivision_Cmb011_Seleccionar(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub


    Private Sub FrmRecepcionGR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Compania()
            'Siempre 20
            'txtNroRegPorPagina.Text = total_por_pag
            '-- Inicializando las variables status por control con F4
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)), intTemp)
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            dgGR.AutoGenerateColumns = False
            chkfecha.Checked = True

            tbcDetalle.TabPages.Remove(tbpMovimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Llena el combo Compañia
    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub






    Private Sub chkfecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkfecha.CheckedChanged
        Me.lblFechaFinal.Enabled = chkfecha.Checked
        Me.lblFechaInicial.Enabled = chkfecha.Checked
        Me.GrpBoxFechas.Enabled = chkfecha.Checked
        Me.dteFechaFinal.Enabled = chkfecha.Checked
        Me.dteFechaInicial.Enabled = chkfecha.Checked
    End Sub


    Public Function ListarServicio(ByVal cclnt As Decimal, ByVal norcml As String, ByVal nguirm As Decimal) As DataTable
        Dim gr As New cGuiaRemision
        Return gr.ListarServicio(cclnt, norcml, 0, 0, nguirm)
    End Function


    Private Sub SelectTabPage()


        pActualizarInformacionDetalle()
        dgvMovimiento.AutoGenerateColumns = False


    End Sub


    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click

        Try
            dgItGr.EndEdit()
            Dim img As Image = btnMarcarItems.Image

            btnMarcarItems.Image = btnMarcarItems.BackgroundImage
            btnMarcarItems.BackgroundImage = img

            If dgItGr.RowCount > 0 Then
                Dim intcont As Int32 = 0

                While intcont < dgItGr.RowCount

                    If dgItGr.Rows(intcont).Cells("M_QCNPEN").Value > 0 Then
                        dgItGr.Rows(intcont).Cells("M_CHK").Value = btnMarcarItems.Checked
                        If btnMarcarItems.Checked Then

                            If ("" & dgItGr.Rows(intcont).Cells("CMRCLR_RZOL11").Value).ToString.Trim = "" Or Val("" & dgItGr.Rows(intcont).Cells("M_NORDSR").Value) = 0 Then
                                dgItGr.Rows(intcont).Cells("M_CHK").Value = False

                                dgItGr.Rows(intcont).Cells("M_QCNREC").Value = 0
                                dgItGr.Rows(intcont).Cells("M_PESOREC").Value = 0
                            Else
                                dgItGr.Rows(intcont).Cells("M_QCNREC").Value = dgItGr.Rows(intcont).Cells("M_QCNPEN").Value

                                dgItGr.Rows(intcont).Cells("M_QCNREC").ReadOnly = False
                                dgItGr.Rows(intcont).Cells("M_PESOREC").ReadOnly = False


                            End If



                        Else
                            dgItGr.Rows(intcont).Cells("M_CHK").Value = False

                            dgItGr.Rows(intcont).Cells("M_QCNREC").Value = 0
                            dgItGr.Rows(intcont).Cells("M_PESOREC").Value = 0

                        End If
                    End If


                    intcont += 1
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub dgGR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItGr.CellContentClick, dgItGr.CellContentDoubleClick

        Try
            If e.RowIndex = -1 Then Exit Sub


            If dgItGr.RowCount > 0 Then
                If dgItGr.Columns(e.ColumnIndex).Name = "M_CHK" Then

                    If ("" & dgItGr.Rows(e.RowIndex).Cells("CMRCLR_RZOL11").Value).ToString.Trim = "" Or Val("" & dgItGr.Rows(e.RowIndex).Cells("M_NORDSR").Value) = 0 Then
                        dgItGr.EndEdit()
                        dgItGr.Rows(e.RowIndex).Cells("M_CHK").Value = False
                        Exit Sub
                    End If
                    If dgItGr.CurrentCellAddress.Y < 0 Then Exit Sub

                    dgItGr.Rows(e.RowIndex).Cells("M_QCNREC").ReadOnly = True
                    dgItGr.Rows(e.RowIndex).Cells("M_PESOREC").ReadOnly = True


                    If dgItGr.Rows(e.RowIndex).Cells("M_QCNPEN").Value > 0 Then
                        If dgItGr.Rows(e.RowIndex).Cells("M_CHK").Value Then
                            dgItGr.Rows(e.RowIndex).Cells("M_CHK").Value = False


                            dgItGr.Rows(e.RowIndex).Cells("M_QCNREC").Value = 0
                            dgItGr.Rows(e.RowIndex).Cells("M_PESOREC").Value = 0



                        Else
                            dgItGr.Rows(e.RowIndex).Cells("M_CHK").Value = True

                            dgItGr.Rows(e.RowIndex).Cells("M_QCNREC").Value = dgItGr.Rows(e.RowIndex).Cells("M_QCNPEN").Value
                            dgItGr.Rows(e.RowIndex).Cells("M_PESOREC").Value = 0
                            dgItGr.Rows(e.RowIndex).Cells("M_QCNREC").ReadOnly = False
                            dgItGr.Rows(e.RowIndex).Cells("M_PESOREC").ReadOnly = False



                        End If
                    Else
                        dgItGr.EndEdit()
                        dgItGr.Rows(e.RowIndex).Cells("M_CHK").Value = False

                        dgItGr.Rows(e.RowIndex).Cells("M_QCNREC").Value = 0
                        dgItGr.Rows(e.RowIndex).Cells("M_PESOREC").Value = 0
                    End If
                End If

            End If

            Select Case dgItGr.Columns(e.ColumnIndex).Name
                Case "M_IMNORS"

                    If dgItGr.CurrentRow.Cells("CMRCLR_RZOL11").Value.ToString.Trim.Equals("") Then
                        MessageBox.Show("Sin código de mercadería", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub

                    End If

                    If Not dgItGr.CurrentRow.Cells("M_NORDSR").Value.ToString.Equals("0") Then
                        Exit Sub
                    End If


                    Dim frmOrdenServicio As New frmOrdenServicioSDS
                    Dim objHashtable As New Hashtable
                    With frmOrdenServicio
                        .Cliente_CCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value
                        .pintTipoInvoke = 1

                        .Mercaderia_CMRCLR = dgItGr.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        dgGR_SelectionChanged(Nothing, Nothing)


                    End With


                Case "M_IMCMR"

                    'If Not dgItGr.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim.Equals("") Then Exit Sub
                    If dgItGr.CurrentRow.Cells("CMRCLR_RZOL11").Value.ToString.Trim <> "" Then Exit Sub



                    Dim frmMercaderia As New frmMercaderiaSDS
                    With frmMercaderia
                        .pintTipoInvoke = 1
                        .pintCodigoCliente_CCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value
                        .txtDescMerca01.Text = dgItGr.CurrentRow.Cells("M_TMRCD2").Value.ToString.Trim
                        .txtCodigoMercaderia.Text = dgItGr.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        dgGR_SelectionChanged(Nothing, Nothing)

                    End With




            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub


    Private Sub btnGenerarRecepcion_Click(sender As Object, e As EventArgs) Handles btnGenerarRecepcion.Click
        Dim strMensajeError As String = ""
        Try
            If dgItGr.RowCount > 0 Then
                Dim intCont As Int32 = 0
                Dim lstItemsSelec As New List(Of Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill)
                Dim lstTotalItems As List(Of TD_ItemGRForWayBill) = New List(Of TD_ItemGRForWayBill)
                Dim objTemp As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill = Nothing
                Dim cant_pend As Decimal = 0
                Dim cant_rec As Decimal = 0
                Dim peso_rec As Decimal = 0

                dgItGr.CommitEdit(DataGridViewDataErrorContexts.Commit)




                Dim oHasOC As New Hashtable
                Dim pOrdenCompra As String = ""
                While intCont < dgItGr.RowCount

                    If dgItGr.Rows(intCont).Cells("M_CHK").Value Then

                        Dim strsku As String = ("" & dgItGr.Rows(intCont).Cells("M_CMRCLR").Value)

                        'If dgItGr.Rows(intCont).Cells("CANT_OS").Value > 1 Then
                        '    MessageBox.Show("El sku " & strsku & " tiene más de 1 O/S relacionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Sub
                        'End If

                        If dgItGr.Rows(intCont).Cells("M_FUNDS2").Value = "C" Then

                            If dgItGr.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then

                                If dgItGr.Rows(intCont).Cells("CMRCLR_RZOL11").Value.ToString.Equals("") OrElse dgItGr.Rows(intCont).Cells("M_NORDSR").Value = 0 Then
                                    MessageBox.Show("Item no Tiene O/S o Mercadería no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Exit Sub
                                End If
                                cant_pend = dgItGr.Rows(intCont).Cells("M_QCNPEN").Value
                                cant_rec = dgItGr.Rows(intCont).Cells("M_QCNREC").Value
                                If cant_rec > cant_pend Then
                                    strMensajeError = "La cantidad a recepcionar tiene que ser menor o igual a la cantidad pendiente."
                                    MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                                End If
                                pOrdenCompra = ("" & dgItGr.Rows(intCont).Cells("M_NORCML").Value).ToString.Trim
                                If Not oHasOC.Contains(pOrdenCompra) Then
                                    oHasOC(pOrdenCompra) = pOrdenCompra
                                    If oHasOC.Count > 1 Then
                                        MessageBox.Show("Seleccionar items de una misma Orden de Compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Exit Sub
                                    End If
                                End If

                            Else
                                MessageBox.Show("La cantidad de recepción debe ser mayor a 0. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                        End If
                        If dgItGr.Rows(intCont).Cells("M_FUNDS2").Value = "P" Then
                            peso_rec = Val("" & dgItGr.Rows(intCont).Cells("M_PESOREC").Value)
                            If peso_rec = 0 Then
                                MessageBox.Show("Ingrese Peso,La U. Despacho es Peso(P).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End If


                    End If
                    intCont += 1
                End While


                intCont = 0



                intCont = 0
                While intCont < dgItGr.RowCount

                    If dgItGr.Rows(intCont).Cells("M_CHK").Value = True Then
                        objTemp = New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill
                        objTemp.pNORCML_OrdenCompra = dgItGr.Rows(intCont).Cells("M_NORCML").Value
                        objTemp.pTCITCL_CodigoCliente = dgItGr.Rows(intCont).Cells("M_CMRCLR").Value
                        objTemp.pQCNREC_QtaRecibida = dgItGr.Rows(intCont).Cells("M_QCNREC").Value
                        objTemp.pTUNDIT_UnidadQta = ("" & dgItGr.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                        objTemp.pCMRCD_CodigoRANSA = ("" & dgItGr.Rows(intCont).Cells("M_CMRCD").Value)
                        objTemp.pTMRCD2_MercaDescripcion = dgItGr.Rows(intCont).Cells("M_TMRCD2").Value
                        objTemp.pQPEPQT_QtaPeso = dgItGr.Rows(intCont).Cells("M_PESOREC").Value
                        objTemp.pTUNPSO_UnidadPeso = ""
                        objTemp.pNORDSR_OrdenServicio = dgItGr.Rows(intCont).Cells("M_NORDSR").Value
                        objTemp.pNCNTR_NroContrato = dgItGr.Rows(intCont).Cells("M_NCNTR").Value
                        objTemp.pNCRCTC_NroCorrelativoContrato = dgItGr.Rows(intCont).Cells("M_NCRCTC").Value
                        objTemp.pNAUTR_NroAutorizacionContrato = dgItGr.Rows(intCont).Cells("M_NAUTR").Value
                        objTemp.pFUNDS2_Status = ("" & dgItGr.Rows(intCont).Cells("M_FUNDS2").Value)
                        objTemp.pCTPDPS_TipoDeposito = ("" & dgItGr.Rows(intCont).Cells("M_CTPDPS").Value)
                        objTemp.pCUNCN5_UnidadCantidad = ("" & dgItGr.Rows(intCont).Cells("M_CUNCN5").Value)
                        objTemp.pCUNPS5_UnidadPeso = ("" & dgItGr.Rows(intCont).Cells("M_CUNPS5").Value)
                        objTemp.pCUNVL5_UnidadValor = ("" & dgItGr.Rows(intCont).Cells("M_CUNVL5").Value)

                        objTemp.pCPRVCL_IdProveedor = dgItGr.Rows(intCont).Cells("CPRVCL").Value
                        objTemp.pTPRVCL_DescProveedor = ("" & dgItGr.Rows(intCont).Cells("TPRVCL").Value)
                        objTemp.pFlagControlUbicacion = ("" & dgItGr.Rows(intCont).Cells("FUBICAC").Value)

                        objTemp.pCantOS_X_SKU = Val("" & dgItGr.Rows(intCont).Cells("CANT_OS").Value)


                        lstItemsSelec.Add(objTemp)




                    End If


                    intCont += 1
                End While
                If lstItemsSelec.Count > 0 Then
                    Dim oTD_GR_Actual As New Ransa.TypeDef.GuiaRemision.TD_GuiaRemisionPK

                    oTD_GR_Actual._PNCCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value
                    oTD_GR_Actual._NGUIRM = dgGR.CurrentRow.Cells("M_NGUIRM").Value
                    oTD_GR_Actual._FGUIRM = dgGR.CurrentRow.Cells("M_FGUIRM").Value 'RANSA.Utilitario.HelpClass.CDate_a_Numero8Digitos(dgGR.CurrentRow.Cells("M_FGUIRM").Value)
                    oTD_GR_Actual._MOTTRA = dgGR.CurrentRow.Cells("M_MOTTRA").Value.ToString.Trim
                    oTD_GR_Actual._TNMMDT = dgGR.CurrentRow.Cells("M_TNMMDT").Value.ToString.Trim
                    oTD_GR_Actual._SITUAC = dgGR.CurrentRow.Cells("M_SITUAC").Value.ToString.Trim
                    oTD_GR_Actual._NPLACP = dgGR.CurrentRow.Cells("M_NPLACP").Value.ToString.Trim
                    oTD_GR_Actual._NPLCCM = dgGR.CurrentRow.Cells("M_NPLCCM").Value.ToString.Trim
                    oTD_GR_Actual._NBRVCH = dgGR.CurrentRow.Cells("M_NBRVCH").Value.ToString.Trim
                    oTD_GR_Actual._TCMPTR = dgGR.CurrentRow.Cells("M_TCMPTR").Value.ToString.Trim
                    oTD_GR_Actual._PSCCMPN = dgGR.CurrentRow.Cells("M_CCMPN").Value.ToString.Trim
                    oTD_GR_Actual._PSCDVSN = dgGR.CurrentRow.Cells("M_CDVSN").Value.ToString.Trim
                    oTD_GR_Actual._PNCPLNDV = dgGR.CurrentRow.Cells("M_CPLNDV").Value

                    Call GenerarRecepcion(oTD_GR_Actual, lstItemsSelec, lstTotalItems)
                Else
                    strMensajeError = "No ha seleccionado ningún Item."
                    MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub GenerarRecepcion(ByVal GuiaRemision As TD_GuiaRemisionPK, ByVal ItemSelec As System.Collections.Generic.List(Of Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill), ByVal TotalItem As System.Collections.Generic.List(Of TD_ItemGRForWayBill))


        Try
            '==============Validar que el cliente tenga contrato
            Dim obrGeneral As New brGeneral
            Dim obeGeneral As New beGeneral
            Dim strError As String = String.Empty

            obeGeneral.PSCCMPN = dgGR.CurrentRow.Cells("M_CCMPN").Value.ToString.Trim
            obeGeneral.PNCCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value

            If Not obrGeneral.fbolValidarClienteContrato(obeGeneral, strError) Then
                HelpClass.MsgBox(strError)
                Exit Sub
            End If
            Dim strGRemision As String = GuiaRemision._NGUIRM.ToString.Trim.PadLeft(10, "0")

            Dim fSolicInforRecOCAlmacen As frmSolicInforRecOCAlmacen = New frmSolicInforRecOCAlmacen
            Dim fGenerarRecepcion As frmGenerarRecepcion = New frmGenerarRecepcion
            Dim objMovimientoMercaderia As clsMovimientoMercaderia = Nothing

            fSolicInforRecOCAlmacen.txtNroGuiaCliente.Enabled = False
            fSolicInforRecOCAlmacen.txtNroGuiaCliente.Text = strGRemision
            fSolicInforRecOCAlmacen.txtNroOrdenCompra.Text = ItemSelec(0).pNORCML_OrdenCompra
            fSolicInforRecOCAlmacen.pintCliente = dgGR.CurrentRow.Cells("M_CCLNT").Value
            fSolicInforRecOCAlmacen.pstrRazonSocialCliente = Me.txtCliente.pRazonSocial
            fSolicInforRecOCAlmacen.pstrCodProveedor = ItemSelec(0).pCPRVCL_IdProveedor.ToString.Trim

            Dim strProv As String = ItemSelec(0).pTPRVCL_DescProveedor

            If fSolicInforRecOCAlmacen.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim objHashTable As Hashtable
            objHashTable = New Hashtable
            'objHashTable.Add("TPOOCM", CurrentGuiaRemision.pTPOOCM_TipoOC)
            objHashTable.Add("NORCCL", fSolicInforRecOCAlmacen.pstrNroOrdenCompra)
            objHashTable.Add("NGUICL", fSolicInforRecOCAlmacen.pstrNroGuiaCliente)
            objHashTable.Add("NRUCLL", fSolicInforRecOCAlmacen.pstrNroRUCCliente)
            objHashTable.Add("STPING", fSolicInforRecOCAlmacen.pstrTipoRecepcion)
            objHashTable.Add("CTPALM", fSolicInforRecOCAlmacen.pstrTipoAlmacen)
            objHashTable.Add("TALMC", fSolicInforRecOCAlmacen.pstrDetalleAlmacen)
            objHashTable.Add("CALMC", fSolicInforRecOCAlmacen.pstrAlmacen)
            objHashTable.Add("TCMPAL", fSolicInforRecOCAlmacen.pstrDetalleTipoAlmacen)
            objHashTable.Add("CZNALM", fSolicInforRecOCAlmacen.pstrZonaAlmacen)
            objHashTable.Add("TCMZNA", fSolicInforRecOCAlmacen.pstrDetalleZonaAlmacen)
            objHashTable.Add("CCNTD", fSolicInforRecOCAlmacen.pstrContenedor)
            objHashTable.Add("CTPOCN", fSolicInforRecOCAlmacen.pblnDesglose)
            objHashTable.Add("NORSCI", fSolicInforRecOCAlmacen.pdecEmbarque)
            objHashTable.Add("TIPORG", fSolicInforRecOCAlmacen.pstrTipoOrigen_TIPORG)
            objHashTable.Add("TIPORI", fSolicInforRecOCAlmacen.pstrTipoDocumentoOrigen_TIPORI)
            objHashTable.Add("CPRVCL", fSolicInforRecOCAlmacen.pstrCodProvCliente)
            objHashTable.Add("SCNEMB", fSolicInforRecOCAlmacen.pstrEmbalajaOC)

            objHashTable.Add("NOMBPR", strProv)

            fGenerarRecepcion.objInformacionIngresada = fSolicInforRecOCAlmacen.pobjInformacionIngresada
            fGenerarRecepcion.pHashTable = objHashTable
            fGenerarRecepcion.ItemSelec_List = ItemSelec
            fGenerarRecepcion.Cliente_CCLNT = dgGR.CurrentRow.Cells("M_CCLNT").Value
            fGenerarRecepcion.RazonSocial = Me.txtCliente.pRazonSocial


            If fGenerarRecepcion.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

            Call pActualizarInformacionDetalle()
            fSolicInforRecOCAlmacen.Dispose()
            fSolicInforRecOCAlmacen = Nothing
            fGenerarRecepcion = Nothing
            'End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dgItGr_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgItGr.CellEndEdit
        Dim intCont As Integer = 0
        Dim ColumName As String
        Dim pendiente As Decimal
        Dim strMensajeError As String = ""
        Try

            With dgItGr
                pendiente = .CurrentRow.Cells("M_QCNPEN").Value
                Select Case .Columns(e.ColumnIndex).Name
                    Case "M_QCNREC"

                        intCont = 0
                        If .CurrentCell.Value = 0 Then
                            .CurrentCell.Value = 0D
                        Else
                            Dim decTemp As Decimal = 0D
                            Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                            .CurrentCell.Value = decTemp
                        End If
                        If .CurrentCell.Value < 0 Then
                            strMensajeError = "Cant. a recepcionar debe ser mayor a cero o igual."
                            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            .CurrentCell.Value = 0D
                        ElseIf .CurrentCell.Value > pendiente Then

                            strMensajeError = "Cant. a recepcionar debe ser menor a la cantidad pendiente."
                            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            .CurrentCell.Value = 0D
                        End If
                End Select

                ColumName = .Columns(e.ColumnIndex).Name
            End With
        Catch ex As Exception
            dgItGr.CurrentCell.Value = 0
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dgItGr_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgItGr.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            colName = dgItGr.Columns(dgItGr.CurrentCell.ColumnIndex).Name
            Select Case colName

                Case "M_QCNREC"


                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "15-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "M_PESOREC"


                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "15-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Ransa.Controls.HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If

    End Sub


    Private Sub dgGR_SelectionChanged(sender As Object, e As EventArgs) Handles dgGR.SelectionChanged
        Try

            If dgGR.CurrentRow Is Nothing Then
                'intFilaActual = -1
                Exit Sub
            End If


            SelectTabPage()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
    '    Try
    '        pActualizarInformacion()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            pActualizarInformacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
