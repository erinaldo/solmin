Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class FrmConsultaDetalleEmbarque

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Private _pCDVSN As String = ""
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
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

    Private _pNORSCI As Decimal = 0
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property

    Private Sub FrmConsultaEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcSeguimiento1.pLoad()
            UcSeguimiento1.pLimpiar()
            UcSeguimiento1.pActualizarInfoEmbarque(_pCCMPN, _pCDVSN, _pCCLNT, _pNORSCI)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
