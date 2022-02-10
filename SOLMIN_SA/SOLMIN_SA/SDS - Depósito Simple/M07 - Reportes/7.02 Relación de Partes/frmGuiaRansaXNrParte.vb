Imports RANSA.TYPEDEF
Imports RANSA.NEGO
Imports Ransa.Utilitario

Public Class frmGuiaRansaXNrParte


    Private _PNCCLNT As Integer
    Public Property PNCCLNT() As Integer
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Integer)
            _PNCCLNT = value
        End Set
    End Property


    Private _PNNPRTIN As Decimal
    Public Property PNNPRTIN() As Decimal
        Get
            Return _PNNPRTIN
        End Get
        Set(ByVal value As Decimal)
            _PNNPRTIN = value
        End Set
    End Property


    Private _PSTCMPCL As String
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Private Sub frmGuiaRansaXNrParte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        pListarGuiasRansa()

    End Sub

    Private Sub pListarGuiasRansa()

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim objFiltro As New beDespacho
            Dim objDespacho As New brDespacho
            Dim oLista As New List(Of beDespacho)
            With objFiltro
                .PNCCLNT = _PNCCLNT
                .PNNPRTIN = _PNNPRTIN
            End With
            dgGuiasRansa.AutoGenerateColumns = False
            dgGuiasRansa.DataSource = objDespacho.olistGuiaRansaXNroParte(objFiltro)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub tsbVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVistaPrevia.Click
        Dim objFiltro As New beDespacho
        Dim objDespacho As New brDespacho
        With objFiltro
            .PNCCLNT = dgGuiasRansa.CurrentRow.DataBoundItem.PNCCLNT
            .PNNGUIRN = dgGuiasRansa.CurrentRow.DataBoundItem.PNNGUIRN
            .pRazonSocial = _PSTCMPCL
        End With
        mReporteIngSalRansa(objFiltro)
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            Dim olstFiltro As New List(Of String)
            olstFiltro.Add("Cliente :\n" & _PSTCMPCL)
            olstFiltro.Add("Nro. Parte :\n" & _PNNPRTIN)
            HelpClass.ExportExcelConTitulos(Me.dgGuiasRansa, Me.Text, olstFiltro)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub


    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub
End Class
