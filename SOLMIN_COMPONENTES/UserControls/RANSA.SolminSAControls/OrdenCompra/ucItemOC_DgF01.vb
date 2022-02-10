Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.OrdenCompra
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra

Public Class ucItemOC_DgF01
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Item As TD_ItemOCPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Item As TD_ItemOCPK)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event DeleteHeadOC()
    Public Event GenerarBulto(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As List(Of TD_ItemOCForWayBill))
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_OrdenCompraActual As TD_OrdenCompraPK = New TD_OrdenCompraPK
    Private TD_ItemOC_Actual As TD_ItemOCPK = New TD_ItemOCPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public ReadOnly Property pItemSeleccionada() As TD_ItemOCPK
        Get
            Return TD_ItemOC_Actual
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If btnMarcarItems.Checked Then
            btnMarcarItems.Checked = False
            Dim img As Image = btnMarcarItems.Image
            btnMarcarItems.Image = btnMarcarItems.BackgroundImage
            btnMarcarItems.BackgroundImage = img
        End If
        ' Iniciamos la carga de la información
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgItemOC.DataSource = daoItemOC.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgItemOC.RowCount > 0 Then
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                    intFilaActual = 0
                    dgItemOC.Columns("M_QCNREC").ReadOnly = True
                    dgItemOC.Columns("M_TDAITM").ReadOnly = True
                Else
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                    intFilaActual = -1
                End If
                RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgItemOC.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = ""
        ' Limpiamos el Item Seleccionado
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ' Validamos de que haya un cliente seleccionado
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        Dim fItem As ucItemOC_MItem = New ucItemOC_MItem
        With fItem
            .pHabilitarNroItem = True
            .pOrdenCompra = TD_OrdenCompraActual
            .pUsuario = strUsuario
            .ShowDialog()
            Call pRefrescar()
        End With
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ' Validamos de que haya un item seleccionado
        If TD_ItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub
        ' Creamos la variables de trabajo
        Dim objItemOC As TD_ItemOC = New TD_ItemOC
        Dim dteTemp As Date
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        Dim fItem As ucItemOC_MItem = New ucItemOC_MItem
        With objItemOC
            .pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            .pNRITOC_NroItemOC = TD_ItemOC_Actual.pNRITOC_NroItemOC
            .pTCITCL_CodigoCliente = ("" & dgItemOC.CurrentRow.Cells("M_TCITCL").Value).ToString.Trim
            .pTCITPR_CodigoProveedor = ("" & dgItemOC.CurrentRow.Cells("M_TCITPR").Value).ToString.Trim
            .pTDITES_DescripcionES = ("" & dgItemOC.CurrentRow.Cells("M_TDITES").Value).ToString.Trim
            .pTDITIN_DescripcionIN = ("" & dgItemOC.CurrentRow.Cells("M_TDITIN").Value).ToString.Trim
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QCNTIT").Value, .pQCNTIT_Cantidad)
            .pTUNDIT_Unidad = ("" & dgItemOC.CurrentRow.Cells("M_TUNDIT").Value).ToString.Trim
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_IVUNIT").Value, .pIVUNIT_ImporteUnitario)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_IVTOIT").Value, .pIVTOIT_ImporteTotal)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QTOLMAX").Value, .pQTOLMAX_ToleranciaMax)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QTOLMIN").Value, .pQTOLMIN_ToleranciaMin)
            Date.TryParse("" & dgItemOC.CurrentRow.Cells("M_FMPDME").Value, dteTemp)
            .pFMPDME_FechaEstEntregaDte = dteTemp
            Date.TryParse("" & dgItemOC.CurrentRow.Cells("M_FMPIME").Value, dteTemp)
            .pFMPIME_FechaReqPlantaDte = dteTemp
            .pTLUGOR_LugarOrigen = ("" & dgItemOC.CurrentRow.Cells("M_TLUGOR").Value).ToString.Trim
            .pTLUGEN_LugarEntrega = ("" & dgItemOC.CurrentRow.Cells("M_TLUGEN").Value).ToString.Trim
        End With
        With fItem
            .pHabilitarNroItem = False
            .pUsuario = strUsuario
            .pItemOC = objItemOC
            If .ShowDialog() = DialogResult.OK Then pRefrescar()
        End With
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_ItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub

        Dim blnCancelar As Boolean = False
        RaiseEvent Confirm("¿Desea eliminar el registro actual?", blnCancelar)
        If blnCancelar Then Exit Sub

        Dim strStatusUltReg As String = "N"
        Dim strMensaje As String = ""
        If daoItemOC.Delete(objSqlManager, TD_ItemOC_Actual, strUsuario, strStatusUltReg, strMensajeError) Then
            If strStatusUltReg = "S" Then
                strMensaje = "NOTA : Se eliminó la O/C por no poseer Items Activos."
                RaiseEvent DeleteHeadOC()
            Else
                dgItemOC.Rows.Remove(dgItemOC.CurrentRow)
            End If
            RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & vbNewLine & strMensaje)
        Else
            RaiseEvent ErrorMessage(strMensajeError)
        End If
    End Sub

    Private Sub btnGenerarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarBulto.Click
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            Dim lstItemsSelec As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim objTemp As TD_ItemOCForWayBill = Nothing
            While intCont < dgItemOC.RowCount
                If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                    If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                        objTemp = New TD_ItemOCForWayBill
                        objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                        objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                        objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                        lstItemsSelec.Add(objTemp)
                    End If
                End If
                intCont += 1
            End While
            If lstItemsSelec.Count > 0 Then
                RaiseEvent GenerarBulto(TD_OrdenCompraActual, lstItemsSelec)
            Else
                strMensajeError = "No se ha procesado ningún Item. Validar la Información."
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            While intCont < dgItemOC.RowCount
                If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                    dgItemOC.Rows(intCont).Cells("M_CHK").Value = btnMarcarItems.Checked
                    If btnMarcarItems.Checked Then
                        dgItemOC.Rows(intCont).Cells("M_QCNREC").Value = dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value
                        dgItemOC.Rows(intCont).Cells("M_QCNREC").ReadOnly = False
                        dgItemOC.Rows(intCont).Cells("M_TDAITM").ReadOnly = False
                    Else
                        dgItemOC.Rows(intCont).Cells("M_QCNREC").Value = 0
                        dgItemOC.Rows(intCont).Cells("M_TDAITM").Value = ""
                        dgItemOC.Rows(intCont).Cells("M_QCNREC").ReadOnly = True
                        dgItemOC.Rows(intCont).Cells("M_TDAITM").ReadOnly = True
                    End If
                End If
                intCont += 1
            End While
        End If
    End Sub

    Private Sub ucOrdenCompra_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucOrdenCompra_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
    End Sub

    Private Sub dgItemOC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellEndEdit
        If blnCargando Then Exit Sub
        With dgItemOC
            Select Case .Columns(e.ColumnIndex).Name
                Case "M_TDAITM"
                    .CurrentCell.Value = ("" & .CurrentCell.Value).ToString.ToUpper.Trim
                Case "M_QCNREC"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        Dim decTemp As Decimal = 0D
                        Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                        .CurrentCell.Value = decTemp
                    End If
                    If .CurrentCell.Value < 0 Then
                        strMensajeError = "El monto debe ser mayor a cero o igual."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    Else
                        If .CurrentCell.Value > .CurrentRow.Cells("M_QCNPEN").Value Then
                            strMensajeError = "La cantida a recibir no puede ser mayor a la cantidad pendiente."
                            RaiseEvent ErrorMessage(strMensajeError)
                            .CurrentCell.Value = .CurrentRow.Cells("M_QCNPEN").Value
                        End If
                    End If
                    'If .CurrentRow.Cells("M_QTOMAX").Value > .CurrentRow.Cells("M_QCNTIT").Value Then
                    '    If .CurrentRow.Cells("M_QTOMAX").Value - .CurrentRow.Cells("M_QCNTIT").Value + .CurrentRow.Cells("M_QCNPEN").Value - _
                    '       .CurrentRow.Cells("M_QCNREC").Value < 0 And .CurrentRow.Cells("M_QCNREC").Value > 0 Then
                    '        If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    '            If .CurrentRow.Cells("M_QCNPEN").Value > 0 Then
                    '                .CurrentRow.Cells("M_QCNREC").Value = .CurrentRow.Cells("M_QCNPEN").Value
                    '            Else
                    '                .CurrentRow.Cells("M_QCNREC").Value = 0
                    '            End If
                    '        End If
                    '    End If
                    'Else
                    '    If .CurrentRow.Cells("M_QCNPEN").Value - .CurrentRow.Cells("M_QCNREC").Value < 0 And .CurrentRow.Cells("M_QCNREC").Value > 0 Then
                    '        If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    '            If .CurrentRow.Cells("M_QCNPEN").Value > 0 Then
                    '                .CurrentRow.Cells("M_QCNREC").Value = .CurrentRow.Cells("D_QCNPEN").Value
                    '            Else
                    '                .CurrentRow.Cells("M_QCNREC").Value = 0
                    '            End If
                    '        End If
                    '    End If
                    'End If
            End Select
        End With
    End Sub

    Private Sub dgItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellContentClick
        If blnCargando Then Exit Sub
        With dgItemOC
            If .RowCount > 0 Then
                If e.ColumnIndex = 0 Then
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                        .CurrentRow.Cells("M_QCNREC").Value = 0
                        .CurrentRow.Cells("M_TDAITM").Value = ""
                        .CurrentRow.Cells("M_QCNREC").ReadOnly = True
                        .CurrentRow.Cells("M_TDAITM").ReadOnly = True
                    Else
                        If .CurrentRow.Cells("M_QCNPEN").Value <= 0 Then Exit Sub
                        .CurrentCell.Value = True
                        .CurrentRow.Cells("M_QCNREC").Value = .CurrentRow.Cells("M_QCNPEN").Value
                        .CurrentRow.Cells("M_QCNREC").ReadOnly = False
                        .CurrentRow.Cells("M_TDAITM").ReadOnly = False
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub dgItemOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemOC.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgItemOC.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgItemOC.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgItemOC.CurrentCell.RowIndex
            TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
            TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
            TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
            RaiseEvent CurrentRowChanged(TD_ItemOC_Actual)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal OrdenCompra As TD_OrdenCompraPK)
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = OrdenCompra.pCCLNT_CodigoCliente
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub
#End Region
End Class