Imports SOLMIN_CTZ.NEGOCIO.operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class frmOperacionesXLoteFactura


#Region "Variables"
    Private _odtListLote As DataTable
    Private _strLote As String
#End Region

#Region "Properties"

    Public Property odtListLote() As DataTable
        Set(ByVal value As DataTable)
            _odtListLote = value
        End Set
        Get
            Return _odtListLote
        End Get
    End Property


    Public Property strLote() As String
        Set(ByVal value As String)
            _strLote = value
        End Set
        Get
            Return _strLote
        End Get
    End Property

#End Region
    Private Function RowToDatatable(ByVal drSelect As DataRow(), ByVal tbl As DataTable) As DataTable
        Dim dt As New DataTable
        dt = tbl.Clone
        For Each row As DataRow In drSelect
            dt.ImportRow(row)
        Next
        Return dt
    End Function

    Private Sub frmlotefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Dim fact As New Factura_Transporte_BLL
        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.DataSource = fact.SelectDistinct(RowToDatatable(odtListLote.Select("Trim(LOTE) = '" + strLote + "'"), odtListLote).Copy, "NOPRCN").Copy
        Me.lblLote.Text = strLote
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class