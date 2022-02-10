
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Negocio.Operaciones
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO
Public Class frmAsignarCarga_GR
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



    Dim dtPaquetes As New DataTable
    Dim dtItems As New DataTable
    Private Function ExtraeDetallexBulto(ByVal tDatos As DataTable, ByVal Bulto As String) As DataTable
        Dim dtDetalle_x_Bulto As New DataTable
        dtDetalle_x_Bulto = tDatos.Copy
        dtDetalle_x_Bulto.Rows.Clear()
        Dim dr() As DataRow
        dr = tDatos.Select("CREFFW='" & Bulto & "'")
        For index As Integer = 0 To dr.Length - 1
            dtDetalle_x_Bulto.ImportRow(dr(index))
        Next
        Return dtDetalle_x_Bulto
    End Function


    Private Sub frmAsignarCarga_GR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbCliente.pAccesoPorUsuario = True
            cmbCliente.pRequerido = True
            cmbCliente.pUsuario = HelpUtil.UserName
            cmbCliente.pCargar(_pCCLNT)
            cmbCliente.Enabled = False

            'Dim oclsDespachoNacional As New clsDespachoNacional
            Dim oTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
            cmbTipDoc.DataSource = oTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo("CTPDNA")
            cmbTipDoc.ValueMember = "CCMPRN"
            cmbTipDoc.DisplayMember = "TDSDES"
            cmbTipDoc.SelectedValue = "GR"
            cmbTipDoc.ComboBox.Enabled = False

            gvOrdEmbCarga.AutoGenerateColumns = False
            gvOrdEmbCargaDet.AutoGenerateColumns = False
            KryptonDataGridView1.AutoGenerateColumns = False
            'txtDscDoc.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnCancelarGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarGR.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBuscarGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGR.Click
        Try

            gvOrdEmbCargaDet.Rows.Clear()
            KryptonDataGridView1.Rows.Clear()
            gvOrdEmbCarga.DataSource = Nothing


            dtPaquetes.Rows.Clear()
            dtItems.Rows.Clear()
 
            'If gvOrdEmbCarga.Rows.Count = 0 Then
            '    gvOrdEmbCargaDet.DataSource = Nothing
            '    KryptonDataGridView1.DataSource = Nothing
            'End If
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
           
            Dim oclsDespachoNacional As New clsDespachoNacional
            Dim numdoc As String = txtDscDoc.Text.Trim
            Dim cclnt As Decimal = cmbCliente.pCodigo
            Dim GuiaProv As String = txtguiaprov.Text.Trim
            Dim OC As String = txtoc.Text.Trim

            If numdoc & GuiaProv & OC = "" Then
                MessageBox.Show("Ingrese nro documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim ds As New DataSet
            Dim dtBultos As New DataTable
            ds = oclsDespachoNacional.Lista_Despacho_Bulto_Guia_Remision(numdoc, _pCCMPN, _pCPLNDV, _pCCLNT, 0, GuiaProv, OC, _pNORSCI)
            dtBultos = ds.Tables(0).Copy
            dtPaquetes = ds.Tables(1).Copy
            dtItems = ds.Tables(2).Copy
 
            gvOrdEmbCarga.DataSource = dtBultos
            gvOrdEmbCarga.EndEdit()
            'For Each Item As DataGridViewRow In gvOrdEmbCarga.Rows
            '    Item.Cells("CHK").Value = True
            'Next
            'gvOrdEmbCarga.EndEdit()
            'If gvOrdEmbCarga.Rows.Count = 0 Then
            '    gvOrdEmbCargaDet.DataSource = Nothing
            '    KryptonDataGridView1.DataSource = Nothing
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function HaySeleccion() As Boolean
        Dim seleccion As Boolean = False
        gvOrdEmbCarga.EndEdit()
        For Each Item As DataGridViewRow In gvOrdEmbCarga.Rows
            If Item.Cells("CHK").Value = True Then
                seleccion = True
                Exit For
            End If
        Next
        Return seleccion
    End Function
    Private Sub btnAceptarGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarGR.Click

        Try
            Dim obj_Table As New DataTable
            Dim oclsDespachoNacional As New clsDespachoNacional
            If HaySeleccion() = False Then
                MessageBox.Show("No ha seleccionado el(los) bultos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            gvOrdEmbCarga.EndEdit()
            Dim obeCarga As beOrdenEmbarqueCarga
            For Each Item As DataGridViewRow In gvOrdEmbCarga.Rows
                If Item.Cells("CHK").Value = True Then
                    obeCarga = New beOrdenEmbarqueCarga
                    obeCarga.PNNORSCI = _pNORSCI
                    obeCarga.PSCCMPN = ("" & Item.Cells("CCMPN").Value).ToString.Trim
                    obeCarga.PNCPLNDV = Item.Cells("CPLNDV").Value
                    obeCarga.PSCTPCRG = ("" & cmbTipDoc.SelectedValue).ToString.Trim
                    obeCarga.PNCCLNT = _pCCLNT
                    obeCarga.PSNORCML = ("" & Item.Cells("NORCML").Value).ToString.Trim
                    obeCarga.PSCREFFW = ("" & Item.Cells("CREFFW").Value).ToString.Trim
                    obeCarga.PNNSEQIN = Item.Cells("NSEQIN").Value
                    obeCarga.PNQRLCSC = Item.Cells("QREFFW").Value
                    obeCarga.PSTIPBTO = ("" & Item.Cells("TIPBTO").Value).ToString.Trim
                    obeCarga.PNQPSOMR = Item.Cells("QPSOBL").Value
                    obeCarga.PNQVOLMR = Item.Cells("QVLBTO").Value
                    oclsDespachoNacional.Registrar_Bulto_Guia_Remision(obeCarga)

                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    

    'gvOrdEmbCargaDet
    '    KryptonDataGridView1.Rows(Fila).Cells("CREFFW_ITEM").Value = Item("CREFFW")
    ' gvOrdEmbCargaDet.Rows(Fila).Cells("CREFFW_D").Value = Item("CREFFW")
    '    gvOrdEmbCargaDet.Rows(Fila).Cells("NSEQIN_D").Value = Item("NSEQIN")
    '     KryptonDataGridView1.Rows(Fila).Cells("NSEQIN_ITEM").Value = Item("NSEQIN")

    'Private Sub gvOrdEmbCarga_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvOrdEmbCarga.SelectionChanged
    '    Try
    '        gvOrdEmbCargaDet.DataSource = Nothing
    '        KryptonDataGridView1.DataSource = Nothing
    '        If gvOrdEmbCarga.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        Dim dtDimension As New DataTable
    '        Dim oclsDespachoNacional As New clsDespachoNacional
    '        Dim cclnt As Decimal = gvOrdEmbCarga.CurrentRow.Cells("CCLNT").Value
    '        Dim cod_bulto As String = ("" & gvOrdEmbCarga.CurrentRow.Cells("CREFFW").Value).ToString.Trim
    '        Dim nsqin As Decimal = gvOrdEmbCarga.CurrentRow.Cells("NSEQIN").Value
    '        'Dim pNUMDCR As String = ("" & gvOrdEmbCarga.CurrentRow.Cells("NUMDCR").Value).ToString.Trim
    '        'If pNUMDCR = "" Then
    '        '    pNUMDCR = "0"
    '        'End If
    '        gvOrdEmbCargaDet.DataSource = oclsDespachoNacional.Lista_Despacho_Bulto_Detalle_Dimension(_pCCMPN, _pCPLNDV, cclnt, cod_bulto, nsqin)

    '        KryptonDataGridView1.DataSource = oclsDespachoNacional.Lista_Despacho_Bulto_Detalle_Items(_pCCMPN, _pCPLNDV, cclnt, cod_bulto, nsqin)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try





    'End Sub

    Private Sub gvOrdEmbCarga_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvOrdEmbCarga.CellContentClick, gvOrdEmbCarga.CellContentDoubleClick
        Try
            If (e.RowIndex < 0) Then Exit Sub
            Dim colName As String = gvOrdEmbCarga.Columns(e.ColumnIndex).Name

            If (colName = "CHK") Then
                gvOrdEmbCarga.EndEdit()
                Dim Bulto As String = ("" & gvOrdEmbCarga.CurrentRow.Cells("CREFFW").Value).ToString.Trim
                If gvOrdEmbCarga.CurrentRow.Cells("CHK").Value = False Then
                    Eliminar_Paquetes_X_Bulto(Bulto)
                    Eliminar_Items_X_Bulto(Bulto)
                ElseIf gvOrdEmbCarga.CurrentRow.Cells("CHK").Value = True Then
                    Ingresar_Paquetes_X_Bulto(Bulto)
                    Ingresar_Items_X_Bulto(Bulto)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Ingresar_Paquetes_X_Bulto(ByVal Bulto As String)
        Dim Paquetes As New DataTable
        Paquetes = ExtraeDetallexBulto(dtPaquetes, Bulto)
        Dim dwvrow As DataGridViewRow
        Dim Fila As Integer = 0
        For Each Item As DataRow In Paquetes.Rows
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(gvOrdEmbCargaDet)
            gvOrdEmbCargaDet.Rows.Add(dwvrow)
            Fila = gvOrdEmbCargaDet.Rows.Count - 1
            gvOrdEmbCargaDet.Rows(Fila).Cells("NSEQIN_D").Value = Item("NSEQIN")
            gvOrdEmbCargaDet.Rows(Fila).Cells("CREFFW_D").Value = Item("CREFFW")
            gvOrdEmbCargaDet.Rows(Fila).Cells("NORCML_D").Value = Item("NORCML")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QCTPQT_D").Value = Item("QCTPQT")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QMTLRG_D").Value = Item("QMTLRG")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QMTANC_D").Value = Item("QMTANC")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QMTALT_D").Value = Item("QMTALT")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QPSOMR_D").Value = Item("QPSOMR")
            gvOrdEmbCargaDet.Rows(Fila).Cells("QVOLMR_D").Value = Item("QVOLMR")
            gvOrdEmbCargaDet.Rows(Fila).Cells("NRPEMB_D").Value = 0
        Next

    End Sub
    Private Sub Ingresar_Items_X_Bulto(ByVal Bulto As String)
        Dim Paquetes As New DataTable
        Paquetes = ExtraeDetallexBulto(dtItems, Bulto)
        Dim dwvrow As DataGridViewRow
        Dim Fila As Integer = 0
        For Each Item As DataRow In Paquetes.Rows
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(KryptonDataGridView1)
            KryptonDataGridView1.Rows.Add(dwvrow)
            Fila = KryptonDataGridView1.Rows.Count - 1
            KryptonDataGridView1.Rows(Fila).Cells("NSEQIN_ITEM").Value = Item("NSEQIN")
            KryptonDataGridView1.Rows(Fila).Cells("CREFFW_ITEM").Value = Item("CREFFW")
            KryptonDataGridView1.Rows(Fila).Cells("NORCML_ITEM").Value = Item("NORCML")
            KryptonDataGridView1.Rows(Fila).Cells("NRITOC_ITEM").Value = Item("NRITOC")
            KryptonDataGridView1.Rows(Fila).Cells("TDITES_ITEM").Value = Item("TDITES")
            KryptonDataGridView1.Rows(Fila).Cells("QSEG_ITEM").Value = Item("QSEG")
            KryptonDataGridView1.Rows(Fila).Cells("TUNDIT_ITEM").Value = Item("TUNDIT")
            KryptonDataGridView1.Rows(Fila).Cells("NUMDCR_ITEM").Value = Item("NUMDCR")
            KryptonDataGridView1.Rows(Fila).Cells("NGRPRV_ITEM").Value = Item("NGRPRV")
            KryptonDataGridView1.Rows(Fila).Cells("CCLNT1_ITEM").Value = Item("CCLNT1")
            KryptonDataGridView1.Rows(Fila).Cells("NRPEMB_ITEM").Value = 0

        Next
    End Sub

    'Dim dtBultos As New DataTable
    'Dim dtPaquetes As New DataTable
    'Dim dtItems As New DataTable
    'Private Function ExtraeDetallexBulto(ByVal tDatos As DataTable, ByVal Bulto As String) As DataTable

    'End Function
    Private Sub Eliminar_Paquetes_X_Bulto(ByVal Bulto As String)
        If gvOrdEmbCargaDet.RowCount = 0 Then Exit Sub
        Dim lint_contador As Int32 = 0
        Dim BultoActual As String = ""
        While lint_contador <= Me.gvOrdEmbCargaDet.RowCount - 1
            BultoActual = ("" & gvOrdEmbCargaDet.Item("CREFFW_D", lint_contador).Value).ToString.Trim
            If BultoActual = Bulto Then
                gvOrdEmbCargaDet.Rows.RemoveAt(lint_contador)
                lint_contador -= 1
            End If
            lint_contador += 1
        End While
    End Sub

    Private Sub Eliminar_Items_X_Bulto(ByVal Bulto As String)
        If KryptonDataGridView1.RowCount = 0 Then Exit Sub
        Dim lint_contador As Int32 = 0
        Dim BultoActual As String = ""
        While lint_contador <= Me.KryptonDataGridView1.RowCount - 1
            BultoActual = ("" & KryptonDataGridView1.Item("CREFFW_ITEM", lint_contador).Value).ToString.Trim
            If BultoActual = Bulto Then
                KryptonDataGridView1.Rows.RemoveAt(lint_contador)
                lint_contador -= 1
            End If
            lint_contador += 1
        End While
    End Sub


End Class
