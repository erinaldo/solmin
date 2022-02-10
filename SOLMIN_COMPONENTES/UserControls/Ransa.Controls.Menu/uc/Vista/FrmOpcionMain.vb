Imports System.Windows.Forms
Public Class FrmOpcionMain
    Private _pMMCAPL_CodApl As String = ""
    Public Property pMMCAPL_CodApl() As String
        Get
            Return _pMMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _pMMCAPL_CodApl = value
        End Set
    End Property
    Private _pMMCMNU_CodMnu As String = ""
    Public Property pMMCMNU_CodMnu() As String
        Get
            Return _pMMCMNU_CodMnu
        End Get
        Set(ByVal value As String)
            _pMMCMNU_CodMnu = value
        End Set
    End Property

    Private Sub FrmOpcionMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcOpcionMain.pCargar(_pMMCAPL_CodApl, _pMMCMNU_CodMnu)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
