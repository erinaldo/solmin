Imports System.Windows.Forms
Public Class FrmMenuMain
    Private _pMMCAPL_CodApl As String = ""
    Public Property pMMCAPL_CodApl() As String
        Get
            Return _pMMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _pMMCAPL_CodApl = value
        End Set
    End Property

    Private Sub FrmMenuMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcMenuMain.pCargar(_pMMCAPL_CodApl)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
