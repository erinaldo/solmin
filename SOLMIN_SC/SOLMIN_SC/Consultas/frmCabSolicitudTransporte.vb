Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmCabSolicitudTransporte
    Private _PNNCSOTR As Decimal = 0
    Sub New(ByVal NCSOTR As Decimal)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _PNNCSOTR = NCSOTR
    End Sub

    Private Sub frmCabSolicitudTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Datos_Solicitados(_PNNCSOTR)
            ControlSoloLectura(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar_Datos_Solicitados(ByVal NCSOTR As Decimal)
        Dim obeSolicitudTransporte As New beSolicitudTransporte
        Dim oblSolicitudTransporte As New clsSolicitudTransporte
        obeSolicitudTransporte = oblSolicitudTransporte.Obtener_Datos_Solicitud_Transporte(NCSOTR)
        txtNroSolicitud.Text = obeSolicitudTransporte.PNNCSOTR
        txtOrdenServicio.Text = obeSolicitudTransporte.PNNORSRT
        txtsFechaSolicitud.Text = obeSolicitudTransporte.PSFECOST
        txtLocalidadOrigen.Text = obeSolicitudTransporte.PSTCMLCL_ORIGEN
        txtDireccionLocalidadCarga.Text = obeSolicitudTransporte.PSTDRCOR
        txtLocalidadDestino.Text = obeSolicitudTransporte.PSTCMLCL_DESTINO
        txtDireccionLocalidadEntrega.Text = obeSolicitudTransporte.PSTDRENT
        txtCantidadSolicitada.Text = obeSolicitudTransporte.PNQSLCIT
        txtTipoServicio.Text = obeSolicitudTransporte.PSTCMTPS
        txtTipoVehiculo.Text = obeSolicitudTransporte.PSTCMCRA
        txtMercaderias.Text = obeSolicitudTransporte.PSTCMRCD
        txtUnidadMedida.Text = obeSolicitudTransporte.PSTCMPUN
        txtCantidadMercaderia.Text = obeSolicitudTransporte.PNQMRCDR
        txtObservaciones.Text = obeSolicitudTransporte.PSTOBS
        txtFechaInicioCarga.Text = obeSolicitudTransporte.PSFINCRG
        txtFinCarga.Text = obeSolicitudTransporte.PSFENTCL
        txtHoraCarga.Text = obeSolicitudTransporte.PSHINCIN
        txtHoraEntrega.Text = obeSolicitudTransporte.PSHRAENT
        txtTipoSolicitud.Text = obeSolicitudTransporte.PSTIPO_SOLICITUD
        txtMedioTransporte.Text = obeSolicitudTransporte.PSTNMMDT
        Me.txtCentroCostoCliente.Text = obeSolicitudTransporte.PSCCTCSC

    End Sub

    Private Sub ControlSoloLectura(ByVal SoloLectura As Boolean)
        txtsFechaSolicitud.ReadOnly = SoloLectura
        txtCantidadMercaderia.ReadOnly = SoloLectura
        txtCantidadSolicitada.ReadOnly = SoloLectura
        txtCentroCostoCliente.ReadOnly = SoloLectura
        txtDireccionLocalidadCarga.ReadOnly = SoloLectura
        txtDireccionLocalidadEntrega.ReadOnly = SoloLectura
        txtFechaInicioCarga.ReadOnly = SoloLectura
        txtUnidadMedida.ReadOnly = SoloLectura
        txtTipoVehiculo.ReadOnly = SoloLectura
        txtTipoSolicitud.ReadOnly = SoloLectura
        txtTipoServicio.ReadOnly = SoloLectura
        txtsFechaSolicitud.ReadOnly = SoloLectura
        txtOrdenServicio.ReadOnly = SoloLectura
        txtObservaciones.ReadOnly = SoloLectura
        txtNroSolicitud.ReadOnly = SoloLectura
        txtMercaderias.ReadOnly = SoloLectura
        txtMedioTransporte.ReadOnly = SoloLectura
        txtLocalidadOrigen.ReadOnly = SoloLectura
        txtLocalidadDestino.ReadOnly = SoloLectura
        txtHoraEntrega.ReadOnly = SoloLectura
        txtHoraCarga.ReadOnly = SoloLectura
        txtFinCarga.ReadOnly = SoloLectura
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
