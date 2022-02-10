Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmOrdenInternaControlResumen
    Private oOIControlNeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oOIControlEnt As New SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private oEstadoNeg As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private bolBuscar As Boolean
    Private bolIniciaCarga As Boolean = True
    Private frmInformacion As New dialogoInformacion
    Public Sub New(ByVal oOIControl As OrdenInternaControl)
        InitializeComponent()
        'CARGAMOS EL DATAGRID
        oOIControlEnt = oOIControl
        'oOIControlEnt.CCMPN = oOIControl.CCMPN
        'oOIControlEnt.CDVSN = oOIControl.CDVSN
        'oOIControlEnt.CPLNDV = oOIControl.CPLNDV
        'oOIControlEnt.F_INICIO = oOIControl.F_INICIO
        'oOIControlEnt.F_FINAL = oOIControl.F_FINAL
        'oOIControlEnt.CCMPN_DESC = oOIControl.CCMPN_DESC
        'oOIControlEnt.CDVSN_DESC = oOIControl.CDVSN_DESC
        'oOIControlEnt.CPLNDV_DESC = oOIControl.CPLNDV_DESC

        'txtTotal.Text = dtgCierreOI.Rows.Count
        'txtAnulados.Text = tAnulados
        'txtFacturados.Text = tFacturados
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmOrdenInternaControlResumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MENSAJE DE INFORMACION
        frmInformacion.ShowInTaskbar = False
        frmInformacion.StartPosition = FormStartPosition.CenterScreen
        '-------------------------------------------------------------
        Dim a As Double = CDbl(linkLiberadoFacturado.Text) + CDbl(linkCTFacturado.Text) + CDbl(linkCerradoFacturado.Text) + CDbl(linkSEFacturado.Text)
        Dim b As Double = CDbl(linkLiberadoPendiente.Text) + CDbl(linkCTPendiente.Text) + CDbl(linkCerradoPendiente.Text) + CDbl(linkSEPendiente.Text)
        Dim c As Double = CDbl(linkLiberadoAnulado.Text) + CDbl(linkCTAnulado.Text) + CDbl(linkCerradoAnulado.Text) + CDbl(linkSEAnulado.Text)

        lblTotalFacturada.Text = a
        lblTotalPendiente.Text = b
        lblTotalAnulado.Text = c
        'linkLiberadoPendiente.Text
    End Sub
    Private Sub abreDetalles(ByVal estado As String, Optional ByVal titulo As String = "[]")
        oOIControlEnt.PageCount = 0
        oOIControlEnt.PageNumber = 1
        oOIControlEnt.PageSize = 20
        oOIControlEnt.ESTADO_DETALLE = estado
        
        Dim frmDetalleResumen As New frmOrdenInternaControlDetalles(oOIControlEnt)
        frmDetalleResumen.HeaderGroupDetalleResumen.ValuesPrimary.Heading = titulo
        frmDetalleResumen.txtCompania.Text = oOIControlEnt.CCMPN_DESC
        frmDetalleResumen.txtDivision.Text = oOIControlEnt.CDVSN_DESC
        frmDetalleResumen.txtPlanta.Text = oOIControlEnt.CPLNDV_DESC
        frmDetalleResumen.txtFechaInicio.Text = HelpClass.FormatoFecha(oOIControlEnt.F_INICIO)
        frmDetalleResumen.txtFechaFin.Text = HelpClass.FormatoFecha(oOIControlEnt.F_FINAL)
        frmDetalleResumen.ShowInTaskbar = False
        frmDetalleResumen.StartPosition = FormStartPosition.CenterScreen
        frmDetalleResumen.ShowDialog()
    End Sub
    Private Sub mensajeInformacion(ByVal mensaje As String)
        frmInformacion.lblMensaje.Text = mensaje
        frmInformacion.ShowDialog()
    End Sub

#Region "LinkCliked"
    Private Sub linkLiberadoPendiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLiberadoPendiente.LinkClicked
        If CInt(linkLiberadoPendiente.Text) > 0 Then
            abreDetalles("PELI", "Pendientes Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkLiberadoFacturado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLiberadoFacturado.LinkClicked
        If CInt(linkLiberadoFacturado.Text) > 0 Then
            abreDetalles("FALI", "Facturados Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkLiberadoAnulado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLiberadoAnulado.LinkClicked
        If CInt(linkLiberadoAnulado.Text) > 0 Then
            abreDetalles("ANLI", "Anulados Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCTPendiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCTPendiente.LinkClicked
        If CInt(linkCTPendiente.Text) > 0 Then
            abreDetalles("PECT", "Pendientes Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCTFacturado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCTFacturado.LinkClicked
        If CInt(linkCTFacturado.Text) > 0 Then
            abreDetalles("FACT", "Facturados Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCTAnulado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCTAnulado.LinkClicked
        If CInt(linkCTAnulado.Text) > 0 Then
            abreDetalles("ANCT", "Anulados Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCerradoPendiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCerradoPendiente.LinkClicked
        If CInt(linkCerradoPendiente.Text) > 0 Then
            abreDetalles("PECI", "Pendientes Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCerradoFacturado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCerradoFacturado.LinkClicked
        If CInt(linkCerradoFacturado.Text) > 0 Then
            abreDetalles("FACI", "Facturados Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkCerradoAnulado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCerradoAnulado.LinkClicked
        If CInt(linkCerradoAnulado.Text) > 0 Then
            abreDetalles("ANCI", "Anulados Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkSEPendiente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSEPendiente.LinkClicked
        If CInt(linkSEPendiente.Text) > 0 Then
            abreDetalles("PESE", "Pendientes Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkSEFacturado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSEFacturado.LinkClicked
        If CInt(linkSEFacturado.Text) > 0 Then
            abreDetalles("FASE", "Facturados Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkSEAnulado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSEAnulado.LinkClicked
        If CInt(linkSEAnulado.Text) > 0 Then
            abreDetalles("ANSE", "Anulados Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub
#End Region

End Class
