Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Public Class frmObsOCParcial
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


    Private _pdItemParcial As New DataTable
    Public Property pdItemParcial() As DataTable
        Get
            Return _pdItemParcial
        End Get
        Set(ByVal value As DataTable)
            _pdItemParcial = value
        End Set
    End Property


    Private _pDialogResult As Boolean = False
    Public ReadOnly Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private oListaPreEmbarques As New List(Of Decimal)

    Private Sub frmObsOCParcial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtvObservacion.AutoGenerateColumns = False
        gvItemParcial.AutoGenerateColumns = False
        gvItemParcial.DataSource = Nothing
        Dim NRPEMB As Decimal = 0
        txtOC.Text = _pNORCML
        txtParcial.Text = _pNRPARC
        gvItemParcial.DataSource = pdItemParcial
        For Each Item As DataGridViewRow In gvItemParcial.Rows
            NRPEMB = Item.Cells("NRPEMB").Value
            If (Not oListaPreEmbarques.Contains(NRPEMB)) Then
                oListaPreEmbarques.Add(NRPEMB)
            End If
        Next
        ListarObservaciones()

    End Sub
    Private Sub ListarObservaciones()
        dtvObservacion.DataSource = Nothing
        Dim oPreEmbarque As New clsPreEmbarque
        Dim obeOrdenPreEmbarcadaFiltro As New beOrdenPreEmbarcadaFiltro
        obeOrdenPreEmbarcadaFiltro.PNCCLNT = _pCCLNT
        obeOrdenPreEmbarcadaFiltro.PSNORCML = _pNORCML
        obeOrdenPreEmbarcadaFiltro.PNNRPARC = _pNRPARC
        obeOrdenPreEmbarcadaFiltro.PSCCMPN = _pCCMPN
        Dim obrPreEmbarque As New Negocio.clsPreEmbarque
        Dim odtObs_x_OCParcial As New DataTable
        odtObs_x_OCParcial = obrPreEmbarque.Lista_Obs_OC_Parcial(obeOrdenPreEmbarcadaFiltro)
        dtvObservacion.DataSource = odtObs_x_OCParcial
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Try
            Dim ofrmObservacionesParcial As New frmObservacionesParcial
            ofrmObservacionesParcial.pListaPreEmbarques = oListaPreEmbarques
            If (ofrmObservacionesParcial.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                _pDialogResult = True
                ListarObservaciones()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try       
    End Sub
End Class
