Imports System.Windows.Forms

Public Class frmListaNotificacion
    Private _beSegEnvioReq As New SegEnvioRequerimiento

    Sub New(ByVal beSegEnvioReq As SegEnvioRequerimiento)
        _beSegEnvioReq = beSegEnvioReq
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmListaNotificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Envio As New RequerimientoServicioEnvio_BLL
        dgvDatos.AutoGenerateColumns = False
        dgvDatos.DataSource = Envio.Listar_Seg_Envio_Requerimiento(_beSegEnvioReq)

    End Sub
End Class
