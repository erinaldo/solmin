Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Negocio.Operaciones
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO
Public Class frmAsignaCargaManual


    Private oclsDespachoNacional As clsDespachoNacional
    Private obeDespachoNacional As New beDespachoNacional

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Private _pCPLNDV As Decimal = 0
    Public Property pCPLNDV() As Decimal
        Get
            Return _pCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _pCPLNDV = value
        End Set
    End Property
    Private _pNORSCI As Decimal = 0
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property

    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pNORMCL As String = ""
    Public Property pNORMCL() As String
        Get
            Return _pNORMCL
        End Get
        Set(ByVal value As String)
            _pNORMCL = value
        End Set
    End Property

    Private _pNRITEM As Decimal = 0
    Public Property pNRITEM() As Decimal
        Get
            Return _pNRITEM
        End Get
        Set(ByVal value As Decimal)
            _pNRITEM = value
        End Set
    End Property

    Private _pNRPEMB As Decimal = 0
    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
        End Set
    End Property

    Public Sub New(ByVal _obeDespachoNacional As beDespachoNacional)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        obeDespachoNacional = _obeDespachoNacional
    End Sub

    
    Private Sub Habilitar_Control(ByVal Habilitar As Boolean)
        'txtNumDoc.Enabled = Habilitar
        txtBulto.Enabled = Habilitar
        txtDescC.Enabled = Habilitar
        txtCant.Enabled = Habilitar
        cmbUndMed.ComboBox.Enabled = Habilitar
        txtPeso.Enabled = Habilitar
        txtVolumen.Enabled = Habilitar
    End Sub

    Private Sub frmAsignaCargaManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cargamos el combo unidad de medida
            oclsDespachoNacional = New clsDespachoNacional
            Dim oTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
            Dim dtUnidadMedida As New DataTable
            dtUnidadMedida = oclsDespachoNacional.Listar_Unidades_Medida_Carga()
            cmbUndMed.DataSource = dtUnidadMedida
            cmbUndMed.DisplayMember = "DETALLE"
            cmbUndMed.ValueMember = "UNIDAD"
            cmbUndMed.SelectedValue = "UNIDADES"

            'Cargamos el numero de embarque
            txtEmbarque.Text = pNORSCI.ToString
            txtEmbarque.Enabled = False

            'Cargar Combo tipo documento
            cmbTipDoc.Enabled = False
            cmbTipDoc.DataSource = oTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo("CTPDNA")
            cmbTipDoc.ValueMember = "CCMPRN"
            cmbTipDoc.DisplayMember = "TDSDES"
            cmbTipDoc.SelectedValue = "MA"

            gvOrdEmbCargaDet.AutoGenerateColumns = False

            txtEmbarque.Text = pNORSCI
            txtCorr.Text = _pNRPEMB

            If _pNRPEMB > 0 Then
                Dim dt As DataTable = oclsDespachoNacional.Listar_Datos_Item_Carga(_pNORSCI, _pCCLNT, _pNORMCL, _pNRITEM, _pNRPEMB)
                If dt.Rows.Count > 0 Then
                    cmbTipDoc.SelectedValue = dt.Rows(0)("CTPCRG").ToString.Trim
                    'txtNumDoc.Text = dt.Rows(0)("NUMDCR").ToString.Trim
                    txtBulto.Text = dt.Rows(0)("CREFFW").ToString.Trim
                    txtDescC.Text = dt.Rows(0)("TDSCIT").ToString.Trim
                    txtCant.Text = Val(dt.Rows(0)("QRLCSC"))
                    cmbUndMed.SelectedValue = dt.Rows(0)("TIPBTO").ToString.Trim
                    txtPeso.Text = Val(dt.Rows(0)("QPSOMR"))
                    txtVolumen.Text = Val(dt.Rows(0)("QVOLMR"))
                End If
                If cmbTipDoc.SelectedValue.ToString.Trim = "GR" Then
                    'txtNumDoc.Enabled = False
                    txtBulto.Enabled = False
                    txtDescC.Enabled = False
                    txtCant.Enabled = False
                    cmbUndMed.ComboBox.Enabled = False

                End If
                CargarDetalle()
            End If
            TabControl1_SelectedIndexChanged(TabControl1, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarDetalle()
        gvOrdEmbCargaDet.Rows.Clear()
        gvitem.Rows.Clear()
        Dim dtDimension As New DataTable
        dtDimension = oclsDespachoNacional.Listar_Dimnesiones_x_Carga_Item(_pNORSCI, _pCCLNT, _pNORMCL, _pNRITEM, _pNRPEMB)

        Dim dtItem As New DataTable
        dtItem = oclsDespachoNacional.Listar_Items_OC_X_Bulto(_pNORSCI, _pCCLNT, _pNORMCL, _pNRPEMB)

        Dim FilaUltima As Int32 = 0
        Dim oDrVw As New DataGridViewRow

        For Each Item As DataRow In dtDimension.Rows
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(gvOrdEmbCargaDet)
            gvOrdEmbCargaDet.Rows.Add(oDrVw)
            FilaUltima = gvOrdEmbCargaDet.Rows.Count - 1
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("NCRRIN").Value = Item("NCRRIN")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QCTPQT").Value = Item("QCTPQT")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QMTLRG").Value = Item("QMTLRG")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QMTANC").Value = Item("QMTANC")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QMTALT").Value = Item("QMTALT")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QPSOMR").Value = Item("QPSOMR")
            gvOrdEmbCargaDet.Rows(FilaUltima).Cells("QVOLMR").Value = Item("QVOLMR")
        Next

        For Each Item As DataRow In dtItem.Rows
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(gvitem)
            gvitem.Rows.Add(oDrVw)
            FilaUltima = gvitem.Rows.Count - 1
            gvitem.Rows(FilaUltima).Cells("NRITEM_ITEM").Value = Item("NRITEM")
            gvitem.Rows(FilaUltima).Cells("TDITES_ITEM").Value = Item("TDITES")
            gvitem.Rows(FilaUltima).Cells("QRLCSC_ITEM").Value = Item("QSEG")
            gvitem.Rows(FilaUltima).Cells("NRITEM_ITEM").Value = Item("NRITEM")
            gvitem.Rows(FilaUltima).Cells("NUMDCR_ITEM").Value = Item("NUMDCR")
            gvitem.Rows(FilaUltima).Cells("NRITEM_CORR").Value = Item("NRITEM")
            gvitem.Rows(FilaUltima).Cells("NGRPRV_ITEM").Value = Item("NGRPRV")

            gvitem.Rows(FilaUltima).Cells("IVUNIT_ITEM").Value = Item("IVUNIT")
            gvitem.Rows(FilaUltima).Cells("MONEDA_ITEM").Value = Item("MONEDA")
            gvitem.Rows(FilaUltima).Cells("CMNDA1_ITEM").Value = Item("CMNDA1")
            gvitem.Rows(FilaUltima).Cells("TUNDIT_ITEM").Value = Item("TUNDIT")

            gvitem.Rows(FilaUltima).Cells("CPRVCL_ITEM").Value = Item("CPRVCL")
            gvitem.Rows(FilaUltima).Cells("TPRVCL_ITEM").Value = Item("TPRVCL")

           
            gvitem.Rows(FilaUltima).ReadOnly = True
        Next

    End Sub

    Private Sub HabilitarControles(ByVal bol As Boolean)
        'txtNumDoc.Enabled = bol
        txtBulto.Enabled = bol
        txtDescC.Enabled = bol
        txtCant.Enabled = bol
        cmbUndMed.Enabled = bol
        txtPeso.Enabled = bol
        txtVolumen.Enabled = bol
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim cadena As String = ValidaControlesAgregarCarga()
            If cadena.Length > 0 Then
                MessageBox.Show(cadena, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            gvOrdEmbCargaDet.CommitEdit(DataGridViewDataErrorContexts.Commit)
            gvitem.CommitEdit(DataGridViewDataErrorContexts.Commit)

            Dim msg As String = ""
            Dim Cantidad As Decimal = 0
            Dim largo As Decimal = 0
            Dim ancho As Decimal = 0
            Dim alto As Decimal = 0
            Dim peso As Decimal = 0
            Dim Evalua_Tiene_Dimension_Cero As Boolean = False

            For Each item As DataGridViewRow In gvOrdEmbCargaDet.Rows
                Cantidad = Val("" & item.Cells("QCTPQT").Value)
                largo = Val("" & item.Cells("QMTLRG").Value)
                ancho = Val("" & item.Cells("QMTANC").Value)
                alto = Val("" & item.Cells("QMTALT").Value)
                peso = Val("" & item.Cells("QPSOMR").Value)
                Evalua_Tiene_Dimension_Cero = (Cantidad = 0 OrElse largo = 0 OrElse ancho = 0 OrElse alto = 0 OrElse peso = 0)
                If Evalua_Tiene_Dimension_Cero = True Then
                    msg = "Las cantidades y/o dimensiones deben ser mayor a 0."
                    Exit For
                End If
            Next

            Dim sum_cant As Decimal = 0

            For Each item As DataGridViewRow In gvOrdEmbCargaDet.Rows
                sum_cant = sum_cant + Val("" & item.Cells("QCTPQT").Value)
            Next


  
            Dim NroItem As Decimal = 0
            Dim DescItem As String = ""
            Dim cantidadItem As Decimal = 0
            Dim LisNroItem As New Hashtable

            Dim ItemRepetido As Boolean = False
          
            Dim EsIngresoCompleto As Boolean = True
            For Each item As DataGridViewRow In gvitem.Rows
                NroItem = Val("" & item.Cells("NRITEM_ITEM").Value)
                DescItem = ("" & item.Cells("TDITES_ITEM").Value).ToString.Trim
                cantidadItem = Val("" & item.Cells("QRLCSC_ITEM").Value)

                EsIngresoCompleto = (DescItem <> "") AndAlso (NroItem <> 0) AndAlso (cantidadItem <> 0)
           
                If NroItem <> 0 Then
                    If Not LisNroItem.Contains(NroItem) Then
                        LisNroItem.Add(NroItem, NroItem)
                    Else
                        ItemRepetido = True
                    End If
                End If
            Next

            If EsIngresoCompleto = False Then
                msg = msg & Chr(13) & "Ingrese Nro Item/Descripción/Nro item/cantidad"
            End If
            If ItemRepetido = True Then
                msg = msg & Chr(13) & "Vericar,El número de item asignado se repite."
            End If

            If sum_cant > Val(txtCant.Text.Trim) Then
                msg = msg & Chr(13) & "La cantidad total de las dimensiones " & Chr(13) & "no debe superar la cantidad del bulto"
            End If

            msg = msg.Trim
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim obeOrdenCarga As New beOrdenEmbarqueCarga

            obeOrdenCarga.PNNORSCI = _pNORSCI
            obeOrdenCarga.PNCCLNT = _pCCLNT
            obeOrdenCarga.PNNRITEM = _pNRITEM
            obeOrdenCarga.PNNRPEMB = _pNRPEMB
            obeOrdenCarga.PSCTPCRG = cmbTipDoc.SelectedValue.ToString.Trim
            'obeOrdenCarga.PSNUMDCR = txtNumDoc.Text.Trim
            obeOrdenCarga.PSCREFFW = txtBulto.Text.Trim
            obeOrdenCarga.PSTDSCIT = txtDescC.Text.Trim
            obeOrdenCarga.PNQRLCSC = Val(txtCant.Text.Trim)
            obeOrdenCarga.PSTIPBTO = cmbUndMed.SelectedValue.ToString.Trim
            obeOrdenCarga.PNQPSOMR = Val(txtPeso.Text.Trim)
            obeOrdenCarga.PNQVOLMR = Val(txtVolumen.Text.Trim)

            If _pNRPEMB = 0 Then
                Dim NroPreEmb As Decimal = oclsDespachoNacional.Registrar_Item_Carga_Manual(obeOrdenCarga)
                _pNRPEMB = NroPreEmb
                txtCorr.Text = _pNRPEMB
            Else
                Dim TipoCarga As String = ("" & cmbTipDoc.SelectedValue).ToString.Trim
                If TipoCarga = "GR" Then
                    oclsDespachoNacional.Actualizar_Datos_Item(obeOrdenCarga)
                Else
                    oclsDespachoNacional.Actualizar_Item_Carga(obeOrdenCarga)
                End If
            End If

            If _pNRPEMB > 0 Then
                For Each item As DataGridViewRow In gvOrdEmbCargaDet.Rows
                    obeOrdenCarga = New beOrdenEmbarqueCarga
                    With obeOrdenCarga
                        .PNNORSCI = _pNORSCI
                        .PNCCLNT = _pCCLNT
                        .PSNORCML = _pNORMCL
                        .PNNRITEM = _pNRITEM
                        .PNNRPEMB = _pNRPEMB
                        .PNNCRRIN = item.Cells("NCRRIN").Value
                        .PNQCTPQT = item.Cells("QCTPQT").Value
                        .PNQPSOMR = item.Cells("QPSOMR").Value
                        .PNQMTLRG = item.Cells("QMTLRG").Value
                        .PNQMTANC = item.Cells("QMTANC").Value
                        .PNQMTALT = item.Cells("QMTALT").Value
                        .PNQVOLMR = Math.Round((Val(item.Cells("QMTLRG").Value) * Val(item.Cells("QMTANC").Value) * Val(item.Cells("QMTALT").Value)) / 1000000, 5)
                    End With
                    oclsDespachoNacional.Registrar_Dimension_Item_Carga(obeOrdenCarga)
                Next
            End If


            If cmbTipDoc.SelectedValue.ToString.Trim = "MA" Then
                For Each item As DataGridViewRow In gvitem.Rows
                    'If item.Cells("NRITEM_CORR").Value = 0 Then
                    obeOrdenCarga = New beOrdenEmbarqueCarga
                    With obeOrdenCarga
                        .PNNORSCI = _pNORSCI
                        .PNCCLNT = _pCCLNT
                        .PSNORCML = _pNORMCL
                        .PNNRITEM = item.Cells("NRITEM_ITEM").Value
                        .PNNRPEMB = _pNRPEMB
                        .PSCTPCRG = cmbTipDoc.SelectedValue.ToString.Trim
                        .PSTDSCIT = ("" & item.Cells("TDITES_ITEM").Value).ToString.Trim
                        .PNQRLCSC = item.Cells("QRLCSC_ITEM").Value
                        .PSTUNDIT = item.Cells("TUNDIT_ITEM").Value
                        .PNIVUNIT = item.Cells("IVUNIT_ITEM").Value
                        .PNCMNDA1 = item.Cells("CMNDA1_ITEM").Value
                        .PSNUMDCR = ("" & item.Cells("NUMDCR_ITEM").Value).ToString.Trim
                        .PSNGRPRV = item.Cells("NGRPRV_ITEM").Value
                        .PNCPRVCL = item.Cells("CPRVCL_ITEM").Value
                    End With
                    oclsDespachoNacional.Registrar_Item_OC_Manual(obeOrdenCarga)
                    'End If

                Next
            End If




            'gvitem.Rows(FilaUltima).Cells("NRITEM_ITEM").Value = Item("NRITEM")
            'gvitem.Rows(FilaUltima).Cells("TDITES_ITEM").Value = Item("TDITES")
            'gvitem.Rows(FilaUltima).Cells("QRLCSC_ITEM").Value = Item("QSEG")
            'gvitem.Rows(FilaUltima).Cells("NRITEM_ITEM").Value = Item("NRITEM")
            'gvitem.Rows(FilaUltima).Cells("NUMDCR_ITEM").Value = Item("NUMDCR")
            'gvitem.Rows(FilaUltima).Cells("NRITEM_CORR").Value = Item("NRITEM")
            'gvitem.Rows(FilaUltima).Cells("NGRPRV_ITEM").Value = Item("NGRPRV")

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidaControlesAgregarCarga() As String
        Dim cadena As String = String.Empty

        If txtDescC.Text.Trim = String.Empty Then
            cadena = cadena & Chr(13) & "Ingrese descripción."
        End If
        If txtCant.Text.Trim = String.Empty Then
            cadena = cadena & Chr(13) & "Ingrese cantidad."
        End If
        If txtBulto.Text.Trim = String.Empty Then
            cadena = cadena & Chr(13) & "Ingrese Bulto."
        End If
        'NGRPRV_ITEM
        'If txtNumDoc.Text.Trim = String.Empty Then
        '    cadena = cadena & Chr(13) & "Ingrese ref. documento."
        'End If
        If cmbUndMed.SelectedValue.ToString.Trim = String.Empty Then
            cadena = cadena & Chr(13) & "Seleccione unidad de medida"
        End If

        Return cadena
    End Function

    Private Sub LimpiarCarga()
        cmbUndMed.SelectedValue = "UNIDADES"
        cmbTipDoc.SelectedValue = "MA"
        txtDescC.Clear()
        txtCant.Clear()
        txtPeso.Clear()
        txtBulto.Clear()
        'txtNumDoc.Clear()
        txtVolumen.Clear()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
 
            Dim TabSel As String = TabControl1.SelectedTab.Name

            Select Case TabSel
                Case "TabDetCarga"
                  
                    Dim ofrmAdicionItem As New frmAdicionItem
                    ofrmAdicionItem.pAccion = frmAdicionItem.Accion.Nuevo
                    Dim oItemActuales As New Hashtable
                    Dim NumItem As String = ""
                    For Each Item As DataGridViewRow In gvitem.Rows
                        NumItem = ("" & Item.Cells("NRITEM_ITEM").Value).ToString.Trim
                        oItemActuales.Add(NumItem, NumItem)
                    Next
                    ofrmAdicionItem.oHasListaItem = oItemActuales
                    ofrmAdicionItem.ShowDialog()
                    If ofrmAdicionItem.DialogResult = Windows.Forms.DialogResult.OK Then
                        Dim oItem As New beItemOC
                        oItem = ofrmAdicionItem.obeItem
                        Dim oDrVw As New DataGridViewRow
                        Dim FilaUltima As Int32 = 0
                        oDrVw.CreateCells(gvitem)
                        gvitem.Rows.Add(oDrVw)
                        FilaUltima = gvitem.Rows.Count - 1
                        gvitem.Rows(FilaUltima).Cells("NRITEM_CORR").Value = 0
                        gvitem.Rows(FilaUltima).Cells("NRITEM_ITEM").Value = oItem.PNNRITOC
                        gvitem.Rows(FilaUltima).Cells("TDITES_ITEM").Value = oItem.PSTDITES
                        gvitem.Rows(FilaUltima).Cells("QRLCSC_ITEM").Value = oItem.PNQCNTIT
                        gvitem.Rows(FilaUltima).Cells("TUNDIT_ITEM").Value = oItem.PSTUNDIT
                        gvitem.Rows(FilaUltima).Cells("IVUNIT_ITEM").Value = oItem.PNIVUNIT
                        gvitem.Rows(FilaUltima).Cells("NUMDCR_ITEM").Value = oItem.PSNUMDCR
                        gvitem.Rows(FilaUltima).Cells("NGRPRV_ITEM").Value = oItem.PSNGRPRV
                        gvitem.Rows(FilaUltima).Cells("MONEDA_ITEM").Value = oItem.PSMONEDA
                        gvitem.Rows(FilaUltima).Cells("CMNDA1_ITEM").Value = oItem.PNCMNDA1

                        gvitem.Rows(FilaUltima).Cells("CPRVCL_ITEM").Value = oItem.PNCPRVCL
                        gvitem.Rows(FilaUltima).Cells("TPRVCL_ITEM").Value = oItem.PSTPRVCL
                     
                    End If

                Case "TabDimension"
                    Dim oDrVw As New DataGridViewRow
                    Dim FilaUltima As Int32 = 0
                    oDrVw.CreateCells(gvOrdEmbCargaDet)
                    gvOrdEmbCargaDet.Rows.Add(oDrVw)
                    FilaUltima = gvOrdEmbCargaDet.Rows.Count - 1
                    gvOrdEmbCargaDet.Rows(FilaUltima).Cells("NCRRIN").Value = 0
            End Select
        


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub gvOrdEmbCargaDet_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvOrdEmbCargaDet.CellValueChanged
        Try
            If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                Exit Sub
            End If

            Dim largo As Decimal = Val("" & gvOrdEmbCargaDet.Rows.Item(e.RowIndex).Cells("QMTLRG").Value)
            Dim ancho As Decimal = Val("" & gvOrdEmbCargaDet.Rows.Item(e.RowIndex).Cells("QMTANC").Value)
            Dim alto As Decimal = Val("" & gvOrdEmbCargaDet.Rows.Item(e.RowIndex).Cells("QMTALT").Value)

            Dim volumen As Decimal = Math.Round((alto * ancho * largo) / 1000000, 5)
            gvOrdEmbCargaDet.Rows.Item(e.RowIndex).Cells("QVOLMR").Value = volumen

            'Dim sum_peso As Decimal = 0
            'Dim sum_vol As Decimal = 0

            'For Each item As DataGridViewRow In gvOrdEmbCargaDet.Rows
            '    sum_peso = sum_peso + Val("" & item.Cells("QPSOMR").Value)
            '    sum_vol = sum_vol + Val("" & item.Cells("QVOLMR").Value)
            'Next

            'txtPeso.Text = sum_peso
            'txtVolumen.Text = sum_vol

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub Cajas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBulto.KeyPress
        Try
            If Char.IsLower(e.KeyChar) Then
                Dim caja = sender
                caja.SelectedText = Char.ToUpper(e.KeyChar)
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gvOrdEmbCargaDet_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvOrdEmbCargaDet.CellClick
        Try
            If gvOrdEmbCargaDet.Rows.Count > 0 Then

                If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                    Exit Sub
                End If

                gvOrdEmbCargaDet.EndEdit()
                Dim ColName As String = gvOrdEmbCargaDet.Columns(e.ColumnIndex).Name
                If (ColName = "DEL") Then
                    Dim Correlativo As Decimal = Val(gvOrdEmbCargaDet.Rows(e.RowIndex).Cells("NCRRIN").Value)
                    If Correlativo > 0 Then
                        If MessageBox.Show("¿ Está seguro de eliminar el item ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Dim obeItemEliminar As New beOrdenEmbarqueCarga
                            With obeItemEliminar
                                .PNNORSCI = _pNORSCI
                                .PSNORCML = _pNORMCL
                                .PNNRITEM = _pNRITEM
                                .PNCCLNT = _pCCLNT
                                .PNNRPEMB = _pNRPEMB
                                .PNNCRRIN = Val(gvOrdEmbCargaDet.Rows(e.RowIndex).Cells("NCRRIN").Value)
                            End With
                            oclsDespachoNacional.Eliminar_Dimension_Item_Carga(obeItemEliminar)
                            gvOrdEmbCargaDet.Rows.RemoveAt(e.RowIndex)
                        End If
                    ElseIf Correlativo = 0 Then
                        gvOrdEmbCargaDet.Rows.RemoveAt(e.RowIndex)
                    End If

                    'Dim sum_peso As Decimal = 0
                    'Dim sum_vol As Decimal = 0
                    'For Each item As DataGridViewRow In gvOrdEmbCargaDet.Rows
                    '    sum_peso = sum_peso + Val("" & item.Cells("QPSOMR").Value)
                    '    sum_vol = sum_vol + Val("" & item.Cells("QVOLMR").Value)
                    'Next
                    'txtPeso.Text = sum_peso
                    'txtVolumen.Text = sum_vol
                End If
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gvOrdEmbCargaDet_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gvOrdEmbCargaDet.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim colName As String = ""
            colName = gvOrdEmbCargaDet.Columns(gvOrdEmbCargaDet.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "QCTPQT"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "7-0"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "QMTLRG"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "5-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "QMTALT"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "5-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "QMTANC"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "5-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "QPSOMR"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub gvitem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvitem.CellClick
        Try
            If gvitem.Rows.Count > 0 Then

                If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                    Exit Sub
                End If

                gvitem.EndEdit()
                Dim ColName As String = gvitem.Columns(e.ColumnIndex).Name

                Select Case ColName
                    Case "DEL_ITEM"
                        Dim Correlativo As Decimal = Val(gvitem.Rows(e.RowIndex).Cells("NRITEM_CORR").Value)
                        If Correlativo > 0 Then
                            If MessageBox.Show("¿ Está seguro de eliminar el item ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                Dim obeItemEliminar As New beOrdenEmbarqueCarga
                                With obeItemEliminar
                                    .PNNORSCI = _pNORSCI
                                    .PSNORCML = _pNORMCL
                                    .PNNRITEM = gvitem.Rows(e.RowIndex).Cells("NRITEM_ITEM").Value
                                    .PNCCLNT = _pCCLNT
                                    .PNNRPEMB = _pNRPEMB

                                End With
                                oclsDespachoNacional.Eliminar_Item_OC_Carga(obeItemEliminar)
                                gvitem.Rows.RemoveAt(e.RowIndex)
                            End If
                        ElseIf Correlativo = 0 Then
                            gvitem.Rows.RemoveAt(e.RowIndex)
                        End If

                    Case "NRITEM_ITEM"
                        Dim ofrmAdicionItem As New frmAdicionItem
                        Dim oItem As New beItemOC
                        Dim oItemResult As New beItemOC
                        oItem.PNNRITOC = gvitem.CurrentRow.Cells("NRITEM_ITEM").Value
                        oItem.PSTDITES = ("" & gvitem.CurrentRow.Cells("TDITES_ITEM").Value).ToString.Trim
                        oItem.PNQCNTIT = gvitem.CurrentRow.Cells("QRLCSC_ITEM").Value
                        oItem.PSTUNDIT = ("" & gvitem.CurrentRow.Cells("TUNDIT_ITEM").Value).ToString.Trim
                        oItem.PNIVUNIT = gvitem.CurrentRow.Cells("IVUNIT_ITEM").Value
                        oItem.PSNUMDCR = ("" & gvitem.CurrentRow.Cells("NUMDCR_ITEM").Value).ToString.Trim
                        oItem.PSNGRPRV = ("" & gvitem.CurrentRow.Cells("NGRPRV_ITEM").Value).ToString.Trim
                        oItem.PNCMNDA1 = ("" & gvitem.CurrentRow.Cells("CMNDA1_ITEM").Value).ToString.Trim
                        oItem.PSMONEDA = ("" & gvitem.CurrentRow.Cells("MONEDA_ITEM").Value).ToString.Trim
                        oItem.PNCPRVCL = gvitem.CurrentRow.Cells("CPRVCL_ITEM").Value
                        oItem.PSTPRVCL = ("" & gvitem.CurrentRow.Cells("TPRVCL_ITEM").Value).ToString.Trim

                        ofrmAdicionItem.obeItem = oItem
                        If cmbTipDoc.SelectedValue.ToString.Trim = "GR" Then
                            ofrmAdicionItem.pAccion = frmAdicionItem.Accion.Visual
                        Else
                            ofrmAdicionItem.pAccion = frmAdicionItem.Accion.Modificar
                        End If
                        ofrmAdicionItem.ShowDialog()
                        If ofrmAdicionItem.DialogResult = Windows.Forms.DialogResult.OK Then
                            oItemResult = ofrmAdicionItem.obeItem
                            gvitem.CurrentRow.Cells("TDITES_ITEM").Value = oItemResult.PSTDITES
                            gvitem.CurrentRow.Cells("QRLCSC_ITEM").Value = oItemResult.PNQCNTIT
                            gvitem.CurrentRow.Cells("TUNDIT_ITEM").Value = oItemResult.PSTUNDIT
                            gvitem.CurrentRow.Cells("IVUNIT_ITEM").Value = oItemResult.PNIVUNIT
                            gvitem.CurrentRow.Cells("NUMDCR_ITEM").Value = oItemResult.PSNUMDCR
                            gvitem.CurrentRow.Cells("NGRPRV_ITEM").Value = oItemResult.PSNGRPRV
                            gvitem.CurrentRow.Cells("CMNDA1_ITEM").Value = oItemResult.PNCMNDA1
                            gvitem.CurrentRow.Cells("MONEDA_ITEM").Value = oItemResult.PSMONEDA
                            gvitem.CurrentRow.Cells("CPRVCL_ITEM").Value = oItemResult.PNCPRVCL
                            gvitem.CurrentRow.Cells("TPRVCL_ITEM").Value = oItemResult.PSTPRVCL

                        End If
                End Select
               
            End If

 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim tABSelect As String = TabControl1.SelectedTab.Name
        Select Case tABSelect
            Case "TabDetCarga"
                btnAgregar.Visible = True
                If cmbTipDoc.SelectedValue.ToString.Trim = "GR" Then
                    btnAgregar.Visible = False
                End If

            Case "TabDimension"
                btnAgregar.Visible = True
        End Select


    End Sub
End Class
