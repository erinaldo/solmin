Public Class frmOIControlResumenV2
    Private oOIControl As SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private frmInformacion As New dialogoInformacion
    Public Sub New(ByVal oOIC As SOLMIN_CTZ.Entidades.OrdenInternaControl, ByVal htValores As Hashtable)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oOIControl = oOIC
        'Cargamos campos con el Hashtable
        '*************MONTOS****************
        txtAnuladoGasto.Text = Format(htValores.Item("ANTO"), "###,###,###,##0.00")
        txtPendienteGasto.Text =Format(htValores.Item("PETO"), "###,###,###,##0.00") 
        txtFacturadoGasto.Text = Format(htValores.Item("FATO"), "###,###,###,##0.00")

        txtTotPendienteCE.Text = Format(htValores.Item("PECI"), "###,###,###,##0.00")
        txtTotPendienteCT.Text = Format(htValores.Item("PECT"), "###,###,###,##0.00")
        txtTotPendienteLI.Text = Format(htValores.Item("PELI"), "###,###,###,##0.00")
        txtTotPendienteSE.Text = Format(htValores.Item("PESE"), "###,###,###,##0.00")

        txtTotFacturadoCE.Text = Format(htValores.Item("FACI"), "###,###,###,##0.00")
        txtTotFacturadoCT.Text = Format(htValores.Item("FACT"), "###,###,###,##0.00")
        txtTotFacturadoLI.Text = Format(htValores.Item("FALI"), "###,###,###,##0.00")
        txtTotFacturadoSE.Text = Format(htValores.Item("FASE"), "###,###,###,##0.00")

        txtTotAnuladoCE.Text = Format(htValores.Item("ANCI"), "###,###,###,##0.00")
        txtTotAnuladoCT.Text = Format(htValores.Item("ANCT"), "###,###,###,##0.00")
        txtTotAnuladoLI.Text = Format(htValores.Item("ANLI"), "###,###,###,##0.00")
        txtTotAnuladoSE.Text = Format(htValores.Item("ANSE"), "###,###,###,##0.00")
        '*************************************************
        '*******************CANTIDADES********************
        lblANTO.Text = htValores.Item("ANTOcnt")
        lblPETO.Text = htValores.Item("PETOcnt")
        lblFATO.Text = htValores.Item("FATOcnt")

        linkPECI.Text = htValores.Item("PECIcnt")
        linkPECT.Text = htValores.Item("PECTcnt")
        linkPELI.Text = htValores.Item("PELIcnt")
        linkPESE.Text = htValores.Item("PESEcnt")

        linkFACI.Text = htValores.Item("FACIcnt")
        linkFACT.Text = htValores.Item("FACTcnt")
        linkFALI.Text = htValores.Item("FALIcnt")
        linkFASE.Text = htValores.Item("FASEcnt")

        linkANCI.Text = htValores.Item("ANCIcnt")
        linkANCT.Text = htValores.Item("ANCTcnt")
        linkANLI.Text = htValores.Item("ANLIcnt")
        linkANSE.Text = htValores.Item("ANSEcnt")
        '*************************************************
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub abreDetalles(ByVal estado As String, Optional ByVal titulo As String = "[]")
        oOIControl.PageCount = 0
        oOIControl.PageNumber = 1
        oOIControl.PageSize = 20
        oOIControl.ESTADO_DETALLE = estado

        Dim frmDetalleResumen As New frmOIControlDetalleV2(oOIControl)
        frmDetalleResumen.HeaderGroupDetalleResumen.ValuesPrimary.Heading = titulo
        frmDetalleResumen.txtCompania.Text = oOIControl.CCMPN_DESC
        frmDetalleResumen.txtDivision.Text = oOIControl.CDVSN_DESC
        frmDetalleResumen.txtPlanta.Text = oOIControl.CPLNDV_DESC
        frmDetalleResumen.txtFechaInicio.Text = HelpClass.FormatoFecha(oOIControl.F_INICIO)
        frmDetalleResumen.txtFechaFin.Text = HelpClass.FormatoFecha(oOIControl.F_FINAL)
        frmDetalleResumen.ShowInTaskbar = False
        frmDetalleResumen.StartPosition = FormStartPosition.CenterScreen
        frmDetalleResumen.ShowDialog()
    End Sub
    Private Sub mensajeInformacion(ByVal mensaje As String)
        frmInformacion.lblMensaje.Text = mensaje
        frmInformacion.ShowDialog()
    End Sub

#Region "LinkCliked"
    Private Sub linkPELI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPELI.LinkClicked
        If CInt(linkPELI.Text) > 0 Then
            abreDetalles("PELI", "Pendientes Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkFALI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFALI.LinkClicked
        If CInt(linkFALI.Text) > 0 Then
            abreDetalles("FALI", "Facturados Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkANLI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkANLI.LinkClicked
        If CInt(linkANLI.Text) > 0 Then
            abreDetalles("ANLI", "Anulados Liberados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkPECT_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPECT.LinkClicked
        If CInt(linkPECT.Text) > 0 Then
            abreDetalles("PECT", "Pendientes Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkFACT_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFACT.LinkClicked
        If CInt(linkFACT.Text) > 0 Then
            abreDetalles("FACT", "Facturados Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkANCT_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkANCT.LinkClicked
        If CInt(linkANCT.Text) > 0 Then
            abreDetalles("ANCT", "Anulados Cierre Tecnico")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkPECI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPECI.LinkClicked
        If CInt(linkPECI.Text) > 0 Then
            abreDetalles("PECI", "Pendientes Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkFACI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFACI.LinkClicked
        If CInt(linkFACI.Text) > 0 Then
            abreDetalles("FACI", "Facturados Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkANCI_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkANCI.LinkClicked
        If CInt(linkANCI.Text) > 0 Then
            abreDetalles("ANCI", "Anulados Cerrados")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkPESE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPESE.LinkClicked
        If CInt(linkPESE.Text) > 0 Then
            abreDetalles("PESE", "Pendientes Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkFASE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFASE.LinkClicked
        If CInt(linkFASE.Text) > 0 Then
            abreDetalles("FASE", "Facturados Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub

    Private Sub linkANSE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkANSE.LinkClicked
        If CInt(linkANSE.Text) > 0 Then
            abreDetalles("ANSE", "Anulados Sin Estado")
        Else
            mensajeInformacion("No hay registros por mostrar para esta consulta")
        End If
    End Sub
#End Region
End Class
