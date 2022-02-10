Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes


Public Class frmSDSWImpresionOS

#Region "Atributos"
    Private intCCLNT As Int64 = 0
    Private strTCMPCL As String = ""
    Private rptTemp As ReportDocument
    Private strMensajeError As String
#End Region
#Region "Propiedades"
    ' Se proporciona el Codigo del Cliente 
    Public WriteOnly Property pintCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property
    ' Se proporciona la Razón Social del Cliente
    Public WriteOnly Property pstrRazonSocial_TCMPCL() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property
#End Region

#Region "Tipos"
    Enum eTipoValidacion
        PROCESAR
        '  ANULAR     
    End Enum
#End Region

#Region "Metodos"

    Private Function fblValidaInformacion(ByVal evalidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If evalidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
            If txtNroOrdServicio.Text = "" Then strMensajeError &= "No ha ingresado O/S" & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado

    End Function

    Private Sub frmImpresionOS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not mfblnSalirOpcion() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmImpresionOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If intCCLNT <> 0 Then
            txtCliente.Text = strTCMPCL
            txtCliente.Tag = intCCLNT
            lblcodcliente.Text = intCCLNT
        End If
    End Sub
    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
            lblcodcliente.Text = txtCliente.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub
    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        txtCliente.Tag = ""
    End Sub
    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            txtCliente.Tag = ""
        Else
            If txtCliente.Text <> "" And "" & txtCliente.Tag = "" Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                lblcodcliente.Text = txtCliente.Tag
                Cursor = System.Windows.Forms.Cursors.Arrow
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If fblValidaInformacion(eTipoValidacion.PROCESAR) Then
            dgvGuia.DataSource = mfdtLista_SDSWGuiOS(txtCliente.Tag, txtNroOrdServicio.Text)
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVisualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If fblValidaInformacion(eTipoValidacion.PROCESAR) Then
            If dgvGuia.RowCount = 0 Then
                MessageBox.Show("No hay ningun dato en Guia", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Call pInicioVistaPrevia()
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub pVisualizarGuia()
        Dim Compania As String

        If Compania_Usuario = "AM" Then
            Compania = "Almacenera del Perú"
        Else
            Compania = "Compañía Almacenera S.A"
        End If

        If dgvGuia.RowCount = 0 Then Exit Sub
        If txtNroOrdServicio.Text = "" Then Exit Sub
        Dim objReporte As clsSDSWReportesRecepcion = New clsSDSWReportesRecepcion(objSeguridadBN.pUsuario)
        Dim objParametros As clsFiltros_SDSWReporteGuiaRecepcion = New clsFiltros_SDSWReporteGuiaRecepcion
        With objParametros

            Int64.TryParse(txtCliente.Tag, .pintCodigoCliente_CCLNT)
            .pstrRazonSocialCliente_TCMPCL = "" & txtCliente.Text
            Int64.TryParse(txtNroOrdServicio.Text, .pintNroOrdenServicio_NORDSR)
            Int64.TryParse(dgvGuia.CurrentRow.Cells("NGUIRN").Value, .pintNroGuiaRansa_NGUIRN)
            .pstrRazonSocialEmpresa = compania

        End With
        rptTemp = objReporte.frptObtenerGuiaRecepcionSDSW(objParametros, strMensajeError)

    End Sub
    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pVisualizarGuia()
    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        VisorReportesCrystal.ReportSource = rptTemp
        VisorReportesCrystal.Visible = True
    End Sub
    Private Sub pInicioVistaPrevia()
        pcxEspera.Visible = True
        VisorReportesCrystal.Visible = False
        bgwGifAnimado.RunWorkerAsync()
    End Sub

#End Region

End Class
