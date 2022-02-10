Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Public Class frmMovimientoxItem
  Public obeBulto As New beBultoSegAlmacen
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Decimal = 0
    Private NRITOC As Decimal = 0
    Private _NORCML As String = ""
    Private _CCLNT As Decimal = 0

    Public Property pCCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property
    Public Property pCCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    'Public Property pCDVSN() As String
    '    Get
    '        Return _CDVSN
    '    End Get
    '    Set(ByVal value As String)
    '        _CDVSN = value
    '    End Set
    'End Property
    'Public Property pCPLNDV() As Decimal
    '    Get
    '        Return _CPLNDV
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _CPLNDV = value
    '    End Set
    'End Property
    Public Property pNRITOC() As Decimal
        Get
            Return NRITOC
        End Get
        Set(ByVal value As Decimal)
            NRITOC = value
        End Set
    End Property
    Public Property pNORCML() As String
        Get
            Return _NORCML
        End Get
        Set(ByVal value As String)
            _NORCML = value
        End Set
    End Property

    Private Sub frmMovimientoxItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgMovimientoItem.AutoGenerateColumns = False
        dgvOCPlanta.AutoGenerateColumns = False
        Try
            txtOC.Text = _NORCML
            Dim oOrdenCompra_DAL As New OrdenCompra_DAL
            dgvOCPlanta.DataSource = oOrdenCompra_DAL.ListarOCPlantas(_CCMPN, pCCLNT, pNORCML)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub dgvOCPlanta_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOCPlanta.SelectionChanged
        Try
            Dim obrBulto As New brBultoSegAlmacen
            Dim obeBulto As New beBultoSegAlmacen
            dgMovimientoItem.DataSource = Nothing
            _CCMPN = ("" & dgvOCPlanta.CurrentRow.Cells("CCMPN_PL").Value).ToString.Trim
            _CDVSN = ("" & dgvOCPlanta.CurrentRow.Cells("CDVSN_PL").Value).ToString.Trim
            _CPLNDV = dgvOCPlanta.CurrentRow.Cells("CPLNDV_PL").Value
            With obeBulto
                .PNCCLNT = pCCLNT
                .PSCCMPN = _CCMPN
                .PSCDVSN = _CDVSN
                .PNCPLNDV = _CPLNDV
                .PSNORCML = pNORCML
                .PNNRITOC = pNRITOC
            End With
            dgMovimientoItem.DataSource = obrBulto.ListarMovimientoDetalle_X_ItemOrdenCompra(obeBulto)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgMovimientoItem_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgMovimientoItem.DataBindingComplete
        Try
            For Each oDgvrItemOC As DataGridViewRow In dgMovimientoItem.Rows
                Dim NRSITEM As Integer = Val("" & oDgvrItemOC.Cells("NRSITEM").Value)
                If NRSITEM > 0 Then
                    oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.button_ok1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgMovimientoItem_CellMouseDobleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgMovimientoItem.CellMouseDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If Me.dgMovimientoItem.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
                If Me.dgMovimientoItem.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
                Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
                Item.pCCMPN_Compania = _CCMPN
                Item.pCDVSN_Division = _CDVSN
                Item.pCPLNDV_Planta = _CPLNDV
                Item.pCCLNT_CodigoCliente = pCCLNT
                Item.pCREFFW_FrdForw = ("" & Me.dgMovimientoItem.CurrentRow.Cells("D_CREFFW").Value).ToString.Trim
                Item.pCIDPAQ_CodIndentificacionPaquete = ("" & Me.dgMovimientoItem.CurrentRow.Cells("D_CIDPAQ").Value).ToString.Trim
                Item.pNORCML_NroOrdenCompra = pNORCML
                Item.pNRITOC_NroItemOC = pNRITOC
                Dim ofrmSubItemEnAlmacen As New frmSubItemEnAlmacen
                With ofrmSubItemEnAlmacen
                    .Items = Item
                    .UcSubItemOcEnAlmacen_DgF.Agregar = False
                    .UcSubItemOcEnAlmacen_DgF.Eliminar = False
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
