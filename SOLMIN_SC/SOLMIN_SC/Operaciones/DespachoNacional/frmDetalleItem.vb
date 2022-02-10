
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Negocio.Operaciones
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO
Public Class frmDetalleItem

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

    Private _pNORMCL As String = ""
    Public Property pNORMCL() As String
        Get
            Return _pNORMCL
        End Get
        Set(ByVal value As String)
            _pNORMCL = value
        End Set
    End Property

    Private _pNRITEM As Decimal = 0
    Public Property pNRITEM() As Decimal
        Get
            Return _pNRITEM
        End Get
        Set(ByVal value As Decimal)
            _pNRITEM = value
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


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmDetalleItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtDimension As New DataTable
            gvOrdEmbCargaDet.AutoGenerateColumns = False
            KryptonDataGridView1.AutoGenerateColumns = False
            txtxemb.Text = Val(_pNORSCI)
            txtxemb.Enabled = False
            txtitem.Text = Val(_pNRPEMB)
            txtitem.Enabled = False
            Dim oclsDespachoNacional As New clsDespachoNacional
            Dim dt As New DataTable
            dt = oclsDespachoNacional.Listar_Dimnesiones_x_Carga_Item(_pNORSCI, _pCCLNT, _pNORMCL, _pNRITEM, _pNRPEMB)
            gvOrdEmbCargaDet.DataSource = dt

            Dim dtItem As New DataTable
            dtItem = oclsDespachoNacional.Listar_ItemsOC_x_Carga_Item(_pNORSCI, _pCCLNT, _pNORMCL, _pNRPEMB)
            KryptonDataGridView1.DataSource = dtItem
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
