Imports System.Drawing
Imports System.Windows.Forms

Public Class frmVisorIncidenciasPorMes

    Dim rptTemp As rptIncidenciaMes1
    Dim rptTemp_General As New rptIncidenciaMes1

#Region "PROPIEDADES"

    Private _dsReporte As DataSet
    Public Property dsReporte() As DataSet
        Get
            Return _dsReporte
        End Get
        Set(ByVal value As DataSet)
            _dsReporte = value
        End Set
    End Property

    Private _pCliente As String
    Public Property pCliente() As String
        Get
            Return _pCliente
        End Get
        Set(ByVal value As String)
            _pCliente = value
        End Set
    End Property

    Private _pIncPara As String
    Public Property pIncPara() As String
        Get
            Return _pIncPara
        End Get
        Set(ByVal value As String)
            _pIncPara = value
        End Set
    End Property

    Private _pNegocio As String
    Public Property pNegocio() As String
        Get
            Return _pNegocio
        End Get
        Set(ByVal value As String)
            _pNegocio = value
        End Set
    End Property

    Private _pAreas As String
    Public Property pAreas() As String
        Get
            Return _pAreas
        End Get
        Set(ByVal value As String)
            _pAreas = value
        End Set
    End Property

    Private _pPlantas As String
    Public Property pPlantas() As String
        Get
            Return _pPlantas
        End Get
        Set(ByVal value As String)
            _pPlantas = value
        End Set

    End Property

    Private _pAnio As String
    Public Property pAnio() As String
        Get
            Return _pAnio
        End Get
        Set(ByVal value As String)
            _pAnio = value
        End Set
    End Property

    Private _pReportado As String
    Public Property pReportado() As String
        Get
            Return _pReportado
        End Get
        Set(ByVal value As String)
            _pReportado = value
        End Set
    End Property

#End Region

    Private Sub frmVisorIncidenciasPorMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim p As New Point

            p.X = (Me.Width / 2) - (pcxEspera.Width / 2)
            p.Y = (Me.Height / 2) - (pcxEspera.Height / 2)

            pcxEspera.Location = p

            pcxEspera.Visible = True
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            pcxEspera.Visible = False
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        _dsReporte.Tables(0).Columns.Remove("CODIGO")
        rptTemp = New rptIncidenciaMes1
        _dsReporte.Tables(0).TableName = "MESES"
        rptTemp.SetDataSource(_dsReporte.Tables(0).Copy)

        rptTemp.SetParameterValue("pCliente", _pCliente)
        rptTemp.SetParameterValue("pAnio", _pAnio)
        rptTemp.SetParameterValue("pAreas", _pAreas)
        rptTemp.SetParameterValue("pPlantas", _pPlantas)
        rptTemp.SetParameterValue("pNegocio", _pNegocio)
        rptTemp.SetParameterValue("pIncPara", _pIncPara)
        rptTemp.SetParameterValue("pReportado", _pReportado)

        rptTemp_General = rptTemp

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        pcxEspera.Visible = False
        CrystalReportViewer1.ReportSource = rptTemp_General

    End Sub
End Class