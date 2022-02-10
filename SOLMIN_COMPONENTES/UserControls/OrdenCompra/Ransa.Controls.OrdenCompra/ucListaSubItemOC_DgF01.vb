Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef.OrdenCompra.SubItemOC
Public Class ucListaSubItemOC_DgF01
    Private ItemPK As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK

    Private _objListTempSubItem As List(Of TD_SubItemOC)
    Private _pHabilitarBulto As Boolean
    Public oHasSubItems As New Hashtable()
    Public oHashItemVisitado As New Hashtable()

    Private _pEstado As String = ""

    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property

    Public Property objListTempSubItem() As List(Of TD_SubItemOC)
        Get
            Return _objListTempSubItem
        End Get
        Set(ByVal value As List(Of TD_SubItemOC))
            _objListTempSubItem = value
        End Set
    End Property
    Public Property pHabilitarBulto() As Boolean
        Get
            Return _pHabilitarBulto
        End Get
        Set(ByVal value As Boolean)
            _pHabilitarBulto = value
        End Set
    End Property

    Public Sub New(ByVal Item As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after
        ItemPK = Item
    End Sub

    Private Sub dgItemsOC_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgSubItemsOC.Confirm
        If MessageBox.Show(strPregunta, "Recepceción:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub ucListaSubItemOC_DgF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgSubItemsOC.pHabilitarBulto = _pHabilitarBulto
        'dgSubItemsOC.oHashItemVisitado = oHashItemVisitado
        dgSubItemsOC.ohasSubItems = oHasSubItems

        If (Me.pEstado <> "Devolucion") Then
            dgSubItemsOC.pEstado = ""
        Else
            dgSubItemsOC.pEstado = "Devolucion"
        End If
        dgSubItemsOC.pActualizar(ItemPK)

    End Sub

    Private Sub dgItemsOC_DeleteHeadOC() Handles dgSubItemsOC.DeleteHeadOC
        dgSubItemsOC.pRefrescar()
    End Sub

    Private Sub dgItemsOC_ErrorMessage(ByVal strMensaje As String) Handles dgSubItemsOC.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgItemsOC_Message(ByVal strMensaje As String) Handles dgSubItemsOC.Message
        MessageBox.Show(strMensaje, "Orden Compra:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ucListaSubItemOC_DgF01_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        dgSubItemsOC_DialogResult()
    End Sub

    Private Sub dgSubItemsOC_DialogResult() Handles dgSubItemsOC.DialogResult
        oHasSubItems = dgSubItemsOC.ohasSubItems
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class
