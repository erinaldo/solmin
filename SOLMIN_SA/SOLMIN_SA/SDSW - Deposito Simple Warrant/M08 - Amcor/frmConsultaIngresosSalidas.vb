Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN_SDS.ReporteIngresosAmcor.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_SDS.ReportesIngresosAmcor.FiltrosIngresosAmcor
Imports RANSA.NEGO.slnSOLMIN_SDS.ReporteSalidasAmcor.Reportes.Generador


Public Class frmConsultaIngresosSalidas
    Dim MyNumber(2) As String
    Dim Flag As String

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

    Private Sub pVisualizar()
        Dim Compania As String
        If Compania_Usuario = "AM" Then
            Compania = "Almacenera del Perú"
        Else
            Compania = "Compañía Almacenera S.A"
        End If

        'If dgvGuia.RowCount = 0 Then Exit Sub
        'If txtNroOrdServicio.Text = "" Then Exit Sub
        Dim objReporte As ReporteIngresosAmcor = New ReporteIngresosAmcor(objSeguridadBN.pUsuario)
        Dim objParametros As ReportesIngresosAmcor.FiltrosIngresosAmcor = New ReportesIngresosAmcor.FiltrosIngresosAmcor
        With objParametros
            objParametros.pdteFechaInicio = Me.dtpFechaIngreso.Text
            Date.TryParse(objParametros.pdteFechaInicio, objParametros.pstrFechaInicio)
            Int64.TryParse(objParametros.pdteFechaInicio, .pintFechaInicio)
        End With
        '   If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
        If Flag = 0 Then
            rptTemp = objReporte.frptReporteIngresosAmcor(objParametros, strMensajeError)
        Else
            rptTemp = objReporte.frptReporteSalidasAmcor(objParametros, strMensajeError)
        End If
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pVisualizar()
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

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pInicioVistaPrevia()
        Flag = (cbxTipo.Items.IndexOf(cbxTipo.Text))
    End Sub

    Private Sub frmConsultaIngresosSalidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbxTipo.Items.Add("Ingreso") : MyNumber(0) = "I"
        Me.cbxTipo.Items.Add("Salida") : MyNumber(1) = "S"
    End Sub
End Class
