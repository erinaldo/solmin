Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmObsOCItem
    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Private _pNORCML As String = ""
    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property
    Private _pNRPARC As Decimal = 0
    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property
    Private _pNRITOC As Decimal = 0
    Public Property pNRITOC() As Decimal
        Get
            Return _pNRITOC
        End Get
        Set(ByVal value As Decimal)
            _pNRITOC = value
        End Set
    End Property

    Private _pSBITOC As String = ""
    Public Property pSBITOC() As String
        Get
            Return _pSBITOC
        End Get
        Set(ByVal value As String)
            _pSBITOC = value
        End Set
    End Property

    Private _pTDITES As String = ""
    Public Property pTDITES() As String
        Get
            Return _pTDITES
        End Get
        Set(ByVal value As String)
            _pTDITES = value
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




    Private _meDialogResult As Boolean = False
    Public ReadOnly Property meDialogResult() As Boolean
        Get
            Return _meDialogResult
        End Get
    End Property

    Private Sub frmObsOCItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtgObservaciones.AutoGenerateColumns = False
        txtOC.Text = _pNORCML
        txtItem.Text = _pNRITOC
        txtSubItem.Text = _pSBITOC
        txtDescripcion.Text = _pTDITES
        txtParcial.Text = _pNRPARC
        ListarObservaciones()
    End Sub
    Private Sub ListarObservaciones()
        Dim oPreEmbarque As New clsPreEmbarque
        oPreEmbarque.Preembarque = _pNRPEMB
        dtgObservaciones.DataSource = oPreEmbarque.Lista_Observacion_PreEmbarque()
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Dim frm As New frmObservaciones(_pCCLNT, _pNRPEMB)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _meDialogResult = True
            ListarObservaciones()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If (dtgObservaciones.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim PNNRITEM As Decimal = dtgObservaciones.CurrentRow.Cells("NRITEM").Value
        Dim frm As New frmObservaciones(_pCCLNT, _pNRPEMB, PNNRITEM)
        If (frm.ShowDialog = Windows.Forms.DialogResult.OK) Then
            _meDialogResult = True
            ListarObservaciones()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (dtgObservaciones.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        If (MessageBox.Show("¿ Está seguro de eliminar la observación seleccionada ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes) Then
            _meDialogResult = True
            Dim oPreEmbarque As New clsPreEmbarque
            oPreEmbarque.Preembarque = _pNRPEMB
            Dim PNNRITEM As Decimal = dtgObservaciones.CurrentRow.Cells("NRITEM").Value
            oPreEmbarque.Eliminar_Observacion(PNNRITEM)
            ListarObservaciones()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
