Public Class frmMovimientoOcSDS

    Public obeBulto As New beBultoSegAlmacen
    Private _pNRITOC As Decimal = 0
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

    Public Property pNRITOC() As Decimal
        Get
            Return _pNRITOC
        End Get
        Set(ByVal value As Decimal)
            _pNRITOC = value
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

    Private _pGUIARANSA As Double = 0
    Public Property pGUIARANSA() As Double
        Get
            Return _pGUIARANSA
        End Get
        Set(ByVal value As Double)
            _pGUIARANSA = value
        End Set
    End Property

    Private Sub FrmMovimientoOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvOCPlanta.AutoGenerateColumns = False
            dgItemDetalle.AutoGenerateColumns = False
            txtOC.Text = _NORCML
            Dim oOrdenCompra_DAL As New OrdenCompra_DAL
            dgvOCPlanta.DataSource = oOrdenCompra_DAL.ListarServicio(pCCLNT, pNORCML, pNRITOC, pGUIARANSA)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvOCPlanta_SelectionChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOCPlanta.SelectionChanged
        Try
            If dgvOCPlanta.CurrentCellAddress.X < 0 OrElse dgvOCPlanta.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            If dgvOCPlanta.CurrentRow IsNot Nothing Then
                Dim oOrdenCompra_DAL As New OrdenCompra_DAL
                Me.dgItemDetalle.DataSource = oOrdenCompra_DAL.ListarDetalleServicio(pCCLNT, pNORCML, dgvOCPlanta.CurrentRow.Cells("NGUIRN").Value, 0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgItemDetalle_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgItemDetalle.DataBindingComplete
        Try
            If Me.dgItemDetalle.Rows.Count > 0 Then Me.dgItemDetalle.CurrentRow.Selected = False
            For i As Integer = 0 To dgItemDetalle.Rows.Count - 1
                If dgItemDetalle.Rows(i).Cells("NRITOC").Value = _pNRITOC Then
                    dgItemDetalle.Rows(i).DefaultCellStyle.BackColor = Color.MistyRose
                End If
            Next
        Catch
        End Try
    End Sub
End Class
