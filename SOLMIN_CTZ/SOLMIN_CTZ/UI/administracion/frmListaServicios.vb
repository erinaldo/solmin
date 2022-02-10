Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmListaServicios
    Private oServicioAtendidoNeg As New clsServicioAtendido
    Private oServicioAtendido As New Servicio_Atendido
    Private _pNOPRCN As Decimal = 0
    Public Property pNOPRCN() As Decimal
        Get
            Return _pNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _pNOPRCN = value
        End Set
    End Property
    Private _pCCLNT As Decimal
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Private Sub frmListaServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oServicioAtendido.NOPRCN = _pNOPRCN
        oServicioAtendido.CCLNT = _pCCLNT
        dtgServicio.DataSource = Nothing
        dtgServicio.AutoGenerateColumns = False
        dtgServicio.DataSource = oServicioAtendidoNeg.Cargar_Servicios(oServicioAtendido)

        dtgBulto.DataSource = Nothing
        dtgBulto.AutoGenerateColumns = False
        dtgBulto.DataSource = oServicioAtendidoNeg.Cargar_Bultos(oServicioAtendido)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
