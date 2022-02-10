Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.SubItemOC
Imports System.Collections.Generic
Imports System.Collections.Specialized
Public Class ucSubItemOC_DgF01

#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Item As TD_ItemOCPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Item As TD_ItemOCPK)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event DeleteHeadOC()
    Public Event DialogResult()

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
    Private TD_SubItemOC_Actual As TD_SubItemOCPK = New Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOCPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""

    Private sDefault_Peso As String = ""
    Private sDefault_Volumen As String = ""
    Private _pEstado As String = ""

    Private iNroChkSelecc As Int32 = 0
    Private oMSubItemOC As ucSubItemOC_MItem
    Public objListTempSubItem As New List(Of TD_SubItemOC)
    Public ohasSubItems As New Hashtable()
    Public oHashItemVisitado As New Hashtable()
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------


#End Region
#Region " Propiedades "

    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property

    Public ReadOnly Property pItemSeleccionada() As TD_SubItemOCPK
        Get
            Return TD_SubItemOC_Actual
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Private _pHabilitarBulto As Boolean
    Public Property pHabilitarBulto() As Boolean
        Get
            Return _pHabilitarBulto
        End Get
        Set(ByVal value As Boolean)
            _pHabilitarBulto = value
            btnMarcarItems.Visible = value
            btnGenerarBulto.Visible = value
            dgSubItemOC.Columns("M_CHK").Visible = value
        End Set
    End Property
    Private _pNRITOC As Int32

#End Region
#Region " Funciones y Procedimientos "
    Private Sub HabilitarBotonesChekeadoGenerarBultos()
        btnMarcarItems.Visible = pHabilitarBulto
        btnGenerarBulto.Visible = pHabilitarBulto
        tssSep_05.Visible = pHabilitarBulto
        dgSubItemOC.Columns("M_CHK").Visible = pHabilitarBulto
    End Sub

    Private Sub pCargarInformacion()
        HabilitarBotonesChekeadoGenerarBultos()
        ' Iniciamos la carga de la información
        If TD_ItemOC_Actual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            'If (oHashItemVisitado.ContainsKey(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString())) Then
            '    If (oHashItemVisitado(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString()) = 0) Then
            '        dgSubItemOC.DataSource = CSubItemOrdenCompra.fdtListar_SubItemsOC_L01(objSqlManager, TD_ItemOC_Actual, strMensajeError)
            '    Else
            '      dgSubItemOC.DataSource =ohasSubItems(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString())
            '    End If
            'End If
            dgSubItemOC.DataSource = CSubItemOrdenCompra.fdtListar_SubItemsOC_L01(objSqlManager, TD_ItemOC_Actual, strMensajeError)
            iNroChkSelecc = 0
            blnCargando = False
            If strMensajeError <> "" Then
                TD_SubItemOC_Actual.pCCLNT_CodigoCliente = 0
                TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = ""
                TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgSubItemOC.RowCount > 0 Then
                    'foeach dgItemOC.Rows  to 
                    TD_SubItemOC_Actual.pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
                    TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
                    TD_SubItemOC_Actual.pNRITOC_NroItemOC = dgSubItemOC.CurrentRow.Cells("M_NRITOC").Value
                    TD_SubItemOC_Actual.pSBITOC_NroSubItemOC = dgSubItemOC.CurrentRow.Cells("M_SBITOC").Value

                    intFilaActual = 0
                    dgSubItemOC.Columns("M_QCNREC").ReadOnly = True
                    dgSubItemOC.Columns("M_TDAITM").ReadOnly = True
                    dgSubItemOC.Columns("M_QPEPQT").ReadOnly = True
                    dgSubItemOC.Columns("M_TUNPSO").ReadOnly = True
                    dgSubItemOC.Columns("M_QVOPQT").ReadOnly = True
                    dgSubItemOC.Columns("M_TUNVOL").ReadOnly = True
                    dgSubItemOC.Columns("M_QCNREC").Visible = False
                    dgSubItemOC.Columns("M_TDAITM").Visible = False
                    dgSubItemOC.Columns("M_QPEPQT").Visible = False
                    dgSubItemOC.Columns("M_TUNPSO").Visible = False
                    dgSubItemOC.Columns("M_QVOPQT").Visible = False
                    dgSubItemOC.Columns("M_TUNVOL").Visible = False
                Else
                    TD_SubItemOC_Actual.pCCLNT_CodigoCliente = 0
                    TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = ""
                    TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0
                    intFilaActual = -1
                End If

                'Si se ha modificado antes
                Dim olistTD_SubItemOC As New List(Of TD_SubItemOC)
                olistTD_SubItemOC = ohasSubItems(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString())
                If Not olistTD_SubItemOC Is Nothing Then
                    For intCont As Integer = 0 To dgSubItemOC.RowCount - 1
                        For Each obeSubItemOC As TD_SubItemOC In olistTD_SubItemOC
                            If dgSubItemOC.Rows(intCont).Cells("M_NRITOC").Value = obeSubItemOC.pNRITOC_NroItemOC AndAlso obeSubItemOC.pSBITOC_NroSubItemOC = dgSubItemOC.Rows(intCont).Cells("M_SBITOC").Value.ToString.Trim Then
                                dgSubItemOC.Rows(intCont).Cells("M_CHK").Value = True
                                ' Dim e As New System.Windows.Forms.DataGridViewCellEventArgs(0, intCont)
                                pMarcarFila(intCont, True)
                                '  dgItemOC_CellContentClick(dgSubItemOC.Rows(intCont), e)
                                dgSubItemOC.Rows(intCont).Cells("CCLNT").Value = obeSubItemOC.pCCLNT_CodigoCliente
                                dgSubItemOC.Rows(intCont).Cells("NORCML").Value = obeSubItemOC.pNORCML_NroOrdenCompra
                                dgSubItemOC.Rows(intCont).Cells("M_NRITOC").Value = obeSubItemOC.pNRITOC_NroItemOC
                                dgSubItemOC.Rows(intCont).Cells("M_SBITOC").Value = obeSubItemOC.pSBITOC_NroSubItemOC
                                dgSubItemOC.Rows(intCont).Cells("M_QCNREC").Value = obeSubItemOC.pQCNREC_QtaRecibida
                                dgSubItemOC.Rows(intCont).Cells("M_TDAITM").Value = obeSubItemOC.pTDAITM_Observaciones
                                dgSubItemOC.Rows(intCont).Cells("M_QPEPQT").Value = obeSubItemOC.pQPEPQT_QtaPeso
                                dgSubItemOC.Rows(intCont).Cells("M_TUNPSO").Value = obeSubItemOC.pTUNPSO_UnidadPeso
                                dgSubItemOC.Rows(intCont).Cells("M_QVOPQT").Value = obeSubItemOC.pQVOPQT_QtaVolumen
                                dgSubItemOC.Rows(intCont).Cells("M_TUNVOL").Value = obeSubItemOC.pTUNVOL_UnidadVolumen
                            End If

                        Next
                    Next
                End If
                RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgSubItemOC.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
        ' Limpiamos el Item Seleccionado
        TD_SubItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = ""
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMarcarFila(ByVal Indice As Int32, ByVal Status As Boolean)
        If Indice = -1 Then Exit Sub
        If Status Then
            dgSubItemOC.Rows(Indice).Cells("M_QCNREC").Value = dgSubItemOC.Rows(Indice).Cells("M_QCNPEN").Value
            dgSubItemOC.Rows(Indice).Cells("M_QCNREC").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_TDAITM").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_QPEPQT").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_TUNPSO").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_TUNPSO").Value = sDefault_Peso
            dgSubItemOC.Rows(Indice).Cells("M_QVOPQT").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_TUNVOL").ReadOnly = False
            dgSubItemOC.Rows(Indice).Cells("M_TUNVOL").Value = sDefault_Volumen
            iNroChkSelecc += 1
            If iNroChkSelecc = 1 Then
                dgSubItemOC.Columns("M_QCNREC").Visible = True
                'dgSubItemOC.Columns("M_TDAITM").Visible = True
                'dgSubItemOC.Columns("M_QPEPQT").Visible = True
                'dgSubItemOC.Columns("M_TUNPSO").Visible = True
                'dgSubItemOC.Columns("M_QVOPQT").Visible = True
                'dgSubItemOC.Columns("M_TUNVOL").Visible = True
            End If
        Else
            dgSubItemOC.Rows(Indice).Cells("M_QCNREC").Value = 0
            dgSubItemOC.Rows(Indice).Cells("M_QPEPQT").Value = 0
            dgSubItemOC.Rows(Indice).Cells("M_TUNPSO").Value = Nothing
            dgSubItemOC.Rows(Indice).Cells("M_QVOPQT").Value = 0
            dgSubItemOC.Rows(Indice).Cells("M_TUNVOL").Value = Nothing
            dgSubItemOC.Rows(Indice).Cells("M_TDAITM").Value = ""
            dgSubItemOC.Rows(Indice).Cells("M_QCNREC").ReadOnly = True
            dgSubItemOC.Rows(Indice).Cells("M_TDAITM").ReadOnly = True
            dgSubItemOC.Rows(Indice).Cells("M_QPEPQT").ReadOnly = True
            dgSubItemOC.Rows(Indice).Cells("M_TUNPSO").ReadOnly = True
            dgSubItemOC.Rows(Indice).Cells("M_QVOPQT").ReadOnly = True
            dgSubItemOC.Rows(Indice).Cells("M_TUNVOL").ReadOnly = True
            iNroChkSelecc -= 1
            If iNroChkSelecc = 0 Then
                dgSubItemOC.Columns("M_QCNREC").Visible = False
                'dgSubItemOC.Columns("M_TDAITM").Visible = False
                'dgSubItemOC.Columns("M_QPEPQT").Visible = False
                'dgSubItemOC.Columns("M_TUNPSO").Visible = False
                'dgSubItemOC.Columns("M_QVOPQT").Visible = False
                'dgSubItemOC.Columns("M_TUNVOL").Visible = False
            End If
        End If
    End Sub

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos las opciones de Gestión
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        RemoveHandler oMSubItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        oMSubItemOC.Dispose()
        oMSubItemOC = Nothing
        If StatusProceso And Not objSqlManager Is Nothing Then Call pRefrescar()
    End Sub
#End Region
#Region " Eventos "

    Private Sub btnMarcarItems_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dgSubItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            iNroChkSelecc = 0
            Dim intContFilas = dgSubItemOC.RowCount
            While intCont < intContFilas
                If (Me.pEstado <> "Devolucion") Then
                    If dgSubItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                        dgSubItemOC.Rows(intCont).Cells("M_CHK").Value = btnMarcarItems.Checked
                        If btnMarcarItems.Checked Then
                            Call pMarcarFila(intCont, True)
                        Else
                            iNroChkSelecc += 1
                            Call pMarcarFila(intCont, False)
                        End If
                    End If
                    intCont += 1
                Else
                    dgSubItemOC.Rows(intCont).Cells("M_CHK").Value = btnMarcarItems.Checked
                    If btnMarcarItems.Checked Then
                        Call pMarcarFila(intCont, True)
                    Else
                        iNroChkSelecc += 1
                        Call pMarcarFila(intCont, False)
                    End If
                    intCont += 1
                End If
          
            End While
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ' Validamos de que haya un cliente seleccionado
        If TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        oMSubItemOC = New ucSubItemOC_MItem(TD_ItemOC_Actual, strUsuario)
        AddHandler oMSubItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        oMSubItemOC.pHabilitarNroSubItem = True
        oMSubItemOC.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ' Validamos de que haya un item seleccionado
        If TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub
        ' Creamos la variables de trabajo
        Dim objItemOC As TD_SubItemOC = New TD_SubItemOC
        Dim dteTemp As Date
        With objItemOC
            .pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            .pNRITOC_NroItemOC = TD_ItemOC_Actual.pNRITOC_NroItemOC
            .pSBITOC_NroSubItemOC = dgSubItemOC.CurrentRow.Cells("M_SBITOC").Value
            .pTCITCL_CodigoCliente = ("" & dgSubItemOC.CurrentRow.Cells("M_TCITCL").Value).ToString.Trim
            .pTCITPR_CodigoProveedor = ("" & dgSubItemOC.CurrentRow.Cells("M_TCITPR").Value).ToString.Trim
            .pTDITES_DescripcionES = ("" & dgSubItemOC.CurrentRow.Cells("M_TDITES").Value).ToString.Trim
            Decimal.TryParse("" & dgSubItemOC.CurrentRow.Cells("M_QCNTIT").Value, .pQCNTIT_Cantidad)
            .pTUNDIT_Unidad = ("" & dgSubItemOC.CurrentRow.Cells("M_TUNDIT").Value).ToString.Trim
            Decimal.TryParse("" & dgSubItemOC.CurrentRow.Cells("M_IVUNIT").Value, .pIVUNIT_ImporteUnitario)
            Decimal.TryParse("" & dgSubItemOC.CurrentRow.Cells("M_IVTOIT").Value, .pIVTOIT_ImporteTotal)

        End With
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        oMSubItemOC = New ucSubItemOC_MItem(objItemOC, strUsuario)
        AddHandler oMSubItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

        oMSubItemOC.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub

        Dim blnCancelar As Boolean = False
        RaiseEvent Confirm("¿Desea eliminar el registro actual?", blnCancelar)
        If blnCancelar Then Exit Sub

        Dim strStatusUltReg As String = "N"
        Dim strMensaje As String = ""
        If CSubItemOrdenCompra.Delete(objSqlManager, TD_SubItemOC_Actual, strUsuario, strStatusUltReg, strMensajeError) Then
            If strStatusUltReg = "S" Then
                strMensaje = "NOTA : Se eliminó la O/C por no poseer Items Activos."
                RaiseEvent DeleteHeadOC()
            Else
                dgSubItemOC.Rows.Remove(dgSubItemOC.CurrentRow)
            End If
            RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & vbNewLine & strMensaje)
        Else
            RaiseEvent ErrorMessage(strMensajeError)
        End If
    End Sub
    Private Sub EliminarSubItemAsociadosItem()

        Try

            If (ohasSubItems.ContainsKey(TD_SubItemOC_Actual.pNRITOC_NroItemOC.ToString())) Then
                ohasSubItems.Remove(TD_SubItemOC_Actual.pNRITOC_NroItemOC.ToString())
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnGenerarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarBulto.Click
        GenerarBulto()
        RaiseEvent DialogResult()
    End Sub

    Private Sub GenerarBulto()
        Try
            EliminarSubItemAsociadosItem()
            If dgSubItemOC.RowCount > 0 Then
                Dim olistTD_SubItemOC As New List(Of TD_SubItemOC)
                Dim objTempSubItem As TD_SubItemOC
                dgSubItemOC.CommitEdit(DataGridViewDataErrorContexts.Commit)
                For intCont As Integer = 0 To dgSubItemOC.RowCount - 1
                    If dgSubItemOC.Rows(intCont).Cells("M_QCNREC").Value > 0 Then
                        objTempSubItem = New TD_SubItemOC
                        objTempSubItem.pTDITES_DescripcionES = ("" & dgSubItemOC.Rows(intCont).Cells("M_TDITES").Value).ToString.Trim

                        objTempSubItem.pTCITCL_CodigoCliente = ("" & dgSubItemOC.Rows(intCont).Cells("M_TCITCL").Value).ToString.Trim

                        objTempSubItem.pTUNDIT_Unidad = ("" & dgSubItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim

                        objTempSubItem.pCCLNT_CodigoCliente = dgSubItemOC.Rows(intCont).Cells("CCLNT").Value


                        objTempSubItem.pNORCML_NroOrdenCompra = dgSubItemOC.Rows(intCont).Cells("NORCML").Value.ToString().Trim()
                        objTempSubItem.pNRITOC_NroItemOC = dgSubItemOC.Rows(intCont).Cells("M_NRITOC").Value
                        objTempSubItem.pSBITOC_NroSubItemOC = dgSubItemOC.Rows(intCont).Cells("M_SBITOC").Value.ToString().Trim()

                        objTempSubItem.pQCNREC_QtaRecibida = dgSubItemOC.Rows(intCont).Cells("M_QCNREC").Value
                        objTempSubItem.pTDAITM_Observaciones = ("" & dgSubItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                        objTempSubItem.pQPEPQT_QtaPeso = dgSubItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                        objTempSubItem.pTUNPSO_UnidadPeso = ("" & dgSubItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                        objTempSubItem.pQVOPQT_QtaVolumen = dgSubItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                        objTempSubItem.pTUNVOL_UnidadVolumen = ("" & dgSubItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim

                        If dgSubItemOC.Rows(intCont).Cells("M_CHK").Value Then
                            objTempSubItem.pCHK = True
                        Else
                            objTempSubItem.pCHK = False
                        End If
                        olistTD_SubItemOC.Add(objTempSubItem)
                    End If
                Next
                ohasSubItems.Add(TD_SubItemOC_Actual.pNRITOC_NroItemOC.ToString(), olistTD_SubItemOC)
            End If
        Catch : End Try
    End Sub

    Private Sub ucOrdenCompra_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing

        ' Limpiamos la Memoria
        cMemory.ClearMemory()
    End Sub

    Private Sub ucOrdenCompra_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()

        '-- Información Unidad Peso y Volumen
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        '-- Peso
        M_TUNPSO.DataSource = oUnidad.fdtListar("P", sDefault_Peso)
        M_TUNPSO.DisplayMember = "TABRUN"
        M_TUNPSO.ValueMember = "TABRUN"
        '-- Volumen
        M_TUNVOL.DataSource = oUnidad.fdtListar("V", sDefault_Volumen)
        M_TUNVOL.DisplayMember = "TABRUN"
        M_TUNVOL.ValueMember = "TABRUN"
        ' Limpiamos la Memoria
        cMemory.ClearMemory()
    End Sub

    Private Sub dgItemOC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubItemOC.CellEndEdit
        If blnCargando Then Exit Sub
        With dgSubItemOC
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

                        If (Me.pEstado <> "Devolucion") Then
                            If .CurrentCell.Value > .CurrentRow.Cells("M_QCNPEN").Value Then
                                strMensajeError = "La cantida a recibir no puede ser mayor a la cantidad pendiente."
                                RaiseEvent ErrorMessage(strMensajeError)
                                .CurrentCell.Value = .CurrentRow.Cells("M_QCNPEN").Value
                            End If

                        End If
                   



                    End If
                Case "M_QPEPQT"
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
                    End If
                Case "M_QVOPQT"
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
            GenerarBulto()
        End With
    End Sub

    Private Sub dgItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubItemOC.CellContentClick
        If blnCargando Then Exit Sub
        With dgSubItemOC
            If .RowCount > 0 Then
                If e.ColumnIndex = 0 Then
                    If .CurrentCellAddress.Y < 0 Then Exit Sub
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                        Call pMarcarFila(e.RowIndex, False)
                    Else
                        If (Me.pEstado <> "Devolucion") Then

                            If .CurrentRow.Cells("M_QCNPEN").Value <= 0 Then Exit Sub
                            .CurrentCell.Value = True
                            Call pMarcarFila(e.RowIndex, True)
                        Else
                            .CurrentCell.Value = True
                            Call pMarcarFila(e.RowIndex, True)
                        End If
                 
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub dgItemOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubItemOC.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgSubItemOC.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgSubItemOC.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgSubItemOC.CurrentCell.RowIndex
            TD_SubItemOC_Actual.pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            TD_SubItemOC_Actual.pNRITOC_NroItemOC = dgSubItemOC.CurrentRow.Cells("M_NRITOC").Value
            TD_SubItemOC_Actual.pSBITOC_NroSubItemOC = dgSubItemOC.CurrentRow.Cells("M_SBITOC").Value
            RaiseEvent CurrentRowChanged(TD_ItemOC_Actual)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Items As TD_ItemOCPK)
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = Items.pCCLNT_CodigoCliente
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = Items.pNORCML_NroOrdenCompra
        TD_ItemOC_Actual.pNRITOC_NroItemOC = Items.pNRITOC_NroItemOC
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