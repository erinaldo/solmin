Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra

Public Class frmListaOC
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Propiedades"

    Private _pCCLNT_CodigoCliente As Double

    Public Property pCCLNT_CodigoCliente() As Double
        Get
            Return _pCCLNT_CodigoCliente
        End Get
        Set(ByVal value As Double)
            _pCCLNT_CodigoCliente = value
        End Set
    End Property

    Private _pNORCML_NroOrdenCompra As String

    Public Property pNORCML_NroOrdenCompra() As String
        Get
            Return _pNORCML_NroOrdenCompra
        End Get
        Set(ByVal value As String)
            _pNORCML_NroOrdenCompra = value
        End Set
    End Property

    Private _pCCLIENT_CodigoClinteYRC As Double
    Public Property pCCLIENT_CodigoClinteYRC() As Double
        Get
            Return _pCCLIENT_CodigoClinteYRC
        End Get
        Set(ByVal value As Double)
            _pCCLIENT_CodigoClinteYRC = value
        End Set
    End Property
    Private _dtImportacionOCABB As DataTable
    Public Property pdtImportacionOCABB() As DataTable
        Get
            Return _dtImportacionOCABB
        End Get
        Set(ByVal value As DataTable)
            _dtImportacionOCABB = value
        End Set
    End Property

    Private _pbolImportadoOCABB As Boolean
    Public Property pbolImportadoOCABB() As Boolean
        Get
            Return _pbolImportadoOCABB
        End Get
        Set(ByVal value As Boolean)
            _pbolImportadoOCABB = value
        End Set
    End Property

#End Region

#Region "Eventos"
    Private Sub frmListaOC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim OrdenCompra As New TD_OrdenCompraPK
        With OrdenCompra
            .pCCLNT_CodigoCliente = _pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = _pNORCML_NroOrdenCompra
            .pCCLIENT_CodigoClinteYRC = _pCCLIENT_CodigoClinteYRC
            .pdtImportacionOCABB = pdtImportacionOCABB
            .pbolImportadoOCABB = pbolImportadoOCABB
        End With
        UcItemOC_DgF01_Importar1.pActualizar(OrdenCompra)
    End Sub

    Private Sub UcItemOC_DgF01_Importar1_ErrorMessage(ByVal strMensaje As System.String) Handles UcItemOC_DgF01_Importar1.ErrorMessage
        MessageBox.Show(strMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub UcItemOC_DgF01_Importar1_Cerrar() Handles UcItemOC_DgF01_Importar1.Cerrar
        Me.Close()
    End Sub
#End Region
    
End Class

