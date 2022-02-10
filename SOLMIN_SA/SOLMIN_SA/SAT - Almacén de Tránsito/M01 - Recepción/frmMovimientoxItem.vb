Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Public Class frmMovimientoxItem
    Public obeBulto As New beBulto


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
    Public Property pCDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property pCPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property
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
        Try
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNCCLNT = pCCLNT
                .PSCCMPN = pCCMPN
                .PSCDVSN = pCDVSN
                .PNCPLNDV = pCPLNDV
                .PSNORCML = pNORCML
                .PNNRITOC = pNRITOC
            End With
            dgMovimientoItem.DataSource = obrBulto.ListarMovimientoDetalle_X_ItemOrdenCompra(obeBulto)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgMovimientoItem_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgMovimientoItem.DataBindingComplete
        For Each oDgvrItemOC As DataGridViewRow In dgMovimientoItem.Rows
            Dim NRSITEM As Integer = Val(oDgvrItemOC.Cells("NRSITEM").Value)
            If NRSITEM > 0 Then
                oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.retencion
            End If
        Next
    End Sub


    Private Sub dgMovimientoItem_CellMouseDobleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgMovimientoItem.CellMouseDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If Me.dgMovimientoItem.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
            If Me.dgMovimientoItem.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
            Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
            Item.pCCMPN_Compania = pCCMPN
            Item.pCDVSN_Division = pCDVSN
            Item.pCPLNDV_Planta = pCPLNDV
            Item.pCCLNT_CodigoCliente = pCCLNT
            Item.pCREFFW_FrdForw = Me.dgMovimientoItem.CurrentRow.Cells("D_CREFFW").Value
            Item.pCIDPAQ_CodIndentificacionPaquete = Me.dgMovimientoItem.CurrentRow.Cells("D_CIDPAQ").Value
            Item.pNORCML_NroOrdenCompra = pNORCML
            Item.pNRITOC_NroItemOC = pNRITOC
            Dim ofrmSubItemEnAlmacen As New frmSubItemEnAlmacen
            With ofrmSubItemEnAlmacen
                .Items = Item
                .UcSubItemOcEnAlmacen_DgF011.Agregar = False
                .UcSubItemOcEnAlmacen_DgF011.Eliminar = False
                .ShowDialog()
            End With
        End If
    End Sub

End Class
