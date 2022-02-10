Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS
'Imports RANSA.NEGO.slnSOLMIN_SDS.ReportesGeneralAmcor
Imports RANSA.NEGO.slnSOLMIN_SDS.ReportesGeneralAmcor.FiltrosIngresosAmcor
Imports RANSA.NEGO.slnSOLMIN_SDS.ReporteGeneralAmcor.Reportes.Generador
'slnSOLMIN_SDS.ReportesGeneralAmcor
'slnSOLMIN_SDS.ReporteGeneralAmcor.Reportes.Generador

Public Class frmConsultaGeneral
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
  
        Dim OBJ As ReporteGeneralAmcor = New ReporteGeneralAmcor(objSeguridadBN.pUsuario)

        Dim objParametros As ReportesGeneralAmcor.FiltrosIngresosAmcor = New ReportesGeneralAmcor.FiltrosIngresosAmcor
        With objParametros
           
        End With

        Dim objParam As ReportesGeneralAmcor.FiltrosIngresosAmcor = New ReportesGeneralAmcor.FiltrosIngresosAmcor
        With objParam
        
        End With

        '   If MyNumber(cbxTipo.Items.IndexOf(cbxTipo.Text)) = "I" Then
        ' If Flag = 0 Then
        rptTemp = OBJ.frptReporteIngresosGeneralAmcor(objParam, strMensajeError)
        'Else
        '    rptTemp = OBJ.frptReporteSalidasGeneralAmcor(objParam, strMensajeError)
        'End If
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

    Private Sub frmConsultaGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Call pInicioVistaPrevia()

    End Sub
End Class
