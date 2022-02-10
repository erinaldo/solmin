Public Class FrmMovimientoOC

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
    '  Get
    '    Return _CDVSN
    '  End Get
    '  Set(ByVal value As String)
    '    _CDVSN = value
    '  End Set
    'End Property
    'Public Property pCPLNDV() As Decimal
    '  Get
    '    Return _CPLNDV
    '  End Get
    '  Set(ByVal value As Decimal)
    '    _CPLNDV = value
    '  End Set
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

    Private Sub FrmMovimientoOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgMovimientoItemOC.AutoGenerateColumns = False
            dgBultosDetalle.AutoGenerateColumns = False
            dgvOCPlanta.AutoGenerateColumns = False
            txtOC.Text = _NORCML
            Dim oOrdenCompra_DAL As New OrdenCompra_DAL
            dgvOCPlanta.DataSource = oOrdenCompra_DAL.ListarOCPlantas(_CCMPN, pCCLNT, pNORCML)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    ' Public Function ListarOCPlantas(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataTable


  'Sub Cargar_DetalleBultos()

  '  'If dgMovimientoItemOC.Columns(dgMovimientoItemOC.CurrentCellAddress.Y) Is M_IMBULTO Then

  '  '----------frmObservacionItemOC-------------
  '  Dim obrBulto As New brBultoSegAlmacen
  '  Dim obeBulto As New beBultoSegAlmacen
  '  With obeBulto
  '    .PSCCMPN = pCCMPN
  '    .PSCDVSN = pCDVSN
  '    .PNCPLNDV = pCPLNDV
  '    .PSCREFFW = ("" & dgMovimientoItemOC.Rows(dgMovimientoItemOC.CurrentCellAddress.X).Cells("M_CREFFW").Value).ToString.Trim
  '    .PNNSEQIN = dgMovimientoItemOC.Rows(dgMovimientoItemOC.CurrentCellAddress.X).Cells("M_NSEQIN").Value
  '    .PNCCLNT = pCCLNT
  '  End With
  '  dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
  '  ' End If
  'End Sub
  'Private Sub dgMovimientoItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientoItemOC.CellContentDoubleClick
  '  If dgMovimientoItemOC.Columns(e.ColumnIndex) Is M_IMBULTO Then

  '    '----------frmObservacionItemOC-------------
  '    Dim obrBulto As New brBultoSegAlmacen
  '    Dim obeBulto As New beBultoSegAlmacen
  '    With obeBulto
  '      .PSCCMPN = pCCMPN
  '      .PSCDVSN = pCDVSN
  '      .PNCPLNDV = pCPLNDV
  '      .PSCREFFW = dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_CREFFW").Value
  '      .PNNSEQIN = dgMovimientoItemOC.Rows(e.RowIndex).Cells("M_NSEQIN").Value
  '      .PNCCLNT = pCCLNT
  '    End With
  '    dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
  '    'Dim frmDetalle As New frmDetalleBulto
  '    'frmDetalle.obeBulto = obeBulto
  '    'frmDetalle.ShowDialog()
  '    'frmDetalle.Dispose()
  '  End If
  'End Sub
    Private Sub dgBultosDetalle_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgBultosDetalle.DataBindingComplete
        Try
            For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
                Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
                If NRSITEM > 0 Then
                    oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.text_block
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    'Private Sub Mostrar_DetalleBultos(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If dgMovimientoItemOC.CurrentCellAddress.Y < 0 Then Exit Sub
    '        Dim obrBulto As New brBultoSegAlmacen
    '        Dim obeBulto As New beBultoSegAlmacen
    '        With obeBulto
    '            .PSCCMPN = _CCMPN
    '            .PSCDVSN = _CDVSN
    '            .PNCPLNDV = _CPLNDV
    '            .PSCREFFW = ("" & dgMovimientoItemOC.Rows(dgMovimientoItemOC.CurrentCellAddress.Y).Cells("M_CREFFW").Value).ToString.Trim
    '            .PNNSEQIN = dgMovimientoItemOC.Rows(dgMovimientoItemOC.CurrentCellAddress.Y).Cells("M_NSEQIN").Value
    '            .PNCCLNT = pCCLNT
    '        End With
    '        dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub Mostrar_SubItems(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgBultosDetalle.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
                If Me.dgBultosDetalle.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
                Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
                Item.pCCMPN_Compania = _CCMPN
                Item.pCDVSN_Division = _CDVSN
                Item.pCPLNDV_Planta = _CPLNDV
                Item.pCCLNT_CodigoCliente = pCCLNT
                Item.pCREFFW_FrdForw = ("" & Me.dgBultosDetalle.CurrentRow.Cells("D_CREFFW").Value).ToString.Trim
                Item.pCIDPAQ_CodIndentificacionPaquete = ("" & Me.dgBultosDetalle.CurrentRow.Cells("D_CIDPAQ").Value).ToString.Trim
                Item.pNORCML_NroOrdenCompra = ("" & Me.dgBultosDetalle.CurrentRow.Cells("D_NORCML").Value).ToString.Trim
                Item.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value
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

    Private Sub dgvOCPlanta_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOCPlanta.SelectionChanged
        Try
            If dgvOCPlanta.CurrentCellAddress.X < 0 OrElse dgvOCPlanta.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            dgMovimientoItemOC.DataSource = Nothing
            If dgvOCPlanta.CurrentRow IsNot Nothing Then
                Dim obrBulto As New brBultoSegAlmacen
                Dim obeBulto As New beBultoSegAlmacen
                With obeBulto
                    _CCMPN = ("" & dgvOCPlanta.CurrentRow.Cells("CCMPN_PL").Value).ToString.Trim
                    _CDVSN = ("" & dgvOCPlanta.CurrentRow.Cells("CDVSN_PL").Value).ToString.Trim
                    _CPLNDV = dgvOCPlanta.CurrentRow.Cells("CPLNDV_PL").Value
                    .PNCCLNT = pCCLNT
                    .PSCCMPN = _CCMPN
                    .PSCDVSN = _CDVSN
                    .PNCPLNDV = _CPLNDV
                    .PSNORCML = pNORCML
                End With
                dgMovimientoItemOC.DataSource = obrBulto.ListarMovimientoItemOrdenCompra(obeBulto)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgMovimientoItemOC_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMovimientoItemOC.SelectionChanged
        If dgMovimientoItemOC.CurrentCellAddress.X < 0 OrElse dgMovimientoItemOC.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        dgBultosDetalle.DataSource = Nothing
        Try
            If dgMovimientoItemOC.CurrentRow IsNot Nothing Then
                Dim obrBulto As New brBultoSegAlmacen
                Dim obeBulto As New beBultoSegAlmacen
                With obeBulto
                    .PSCCMPN = _CCMPN
                    .PSCDVSN = _CDVSN
                    .PNCPLNDV = _CPLNDV
                    .PSCREFFW = ("" & dgMovimientoItemOC.CurrentRow.Cells("M_CREFFW").Value).ToString.Trim
                    .PNNSEQIN = dgMovimientoItemOC.CurrentRow.Cells("M_NSEQIN").Value
                    .PNCCLNT = pCCLNT
                End With
                dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
End Class
