Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.Utilitario
Public Class frmEmbarqueAsociadosOC

#Region "Propiedades"

    Private _PNCCLNT As Decimal
    Public Property Cliente() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Private _NORCML As String
    Public Property OrdeDeCompra() As String
        Get
            Return _NORCML
        End Get
        Set(ByVal value As String)
            _NORCML = value
        End Set
    End Property


    Private _PNNORSCI As Decimal
    Public Property Embarque() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property


#End Region

    Private Sub frmEmbarqueAsociadosOC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UCDataGridView.Alinear_Columnas_Grilla(Me.dtgEmbarque)
        dtgEmbarque.AutoGenerateColumns = False
        ListaEmbarquePorOC()
    End Sub

    Private Sub ListaEmbarquePorOC()
        Dim obeOrdenCompra As New beOrdenCompra
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        With obeOrdenCompra
            .PNCCLNT = _PNCCLNT
            .PSNORCML = _NORCML
        End With
        With obrOrdenDeCompra
            Me.dtgEmbarque.DataSource = .ListaEmbarquePorOC(obeOrdenCompra)
        End With
    End Sub

    Private Sub dtgEmbarque_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgEmbarque.CellDoubleClick
        If Me.dtgEmbarque.CurrentCellAddress.Y = -1 Then Exit Sub
        _PNNORSCI = dtgEmbarque.CurrentRow.DataBoundItem.PNNORSCI()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        dtgEmbarque_CellDoubleClick(Nothing, Nothing)
    End Sub
End Class
