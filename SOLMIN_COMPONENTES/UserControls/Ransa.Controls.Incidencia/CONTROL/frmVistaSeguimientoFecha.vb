
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmVistaSeguimientoFecha

    Dim rptTemp As rptSeguimientoPorFecha
    Dim rptTemp_General As New rptSeguimientoPorFecha

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

    Private _FechaInicial As String
    Public Property FechaInicial() As String
        Get
            Return _FechaInicial
        End Get
        Set(ByVal value As String)
            _FechaInicial = value
        End Set
    End Property

    Private _FechaFinal As String
    Public Property FechaFinal() As String
        Get
            Return _FechaFinal
        End Get
        Set(ByVal value As String)
            _FechaFinal = value
        End Set
    End Property

    Private _Areas As String
    Public Property Areas() As String
        Get
            Return _Areas
        End Get
        Set(ByVal value As String)
            _Areas = value
        End Set
    End Property

    Private _IncPara As String
    Public Property IncPara() As String
        Get
            Return _IncPara
        End Get
        Set(ByVal value As String)
            _IncPara = value
        End Set
    End Property


    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)


#End Region

    Private Sub frmVisorIncidenciasPorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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


        rptTemp = New rptSeguimientoPorFecha
        _dsReporte.Tables(0).TableName = "dtSeguimiento"
        _dsReporte.Tables(1).TableName = "dtIncidencia"
        _dsReporte.Tables(1).Columns.Remove("CODIGO")
        _dsReporte.Tables(2).TableName = "dtResumen"

        rptTemp.SetDataSource(_dsReporte.Tables(0).Copy)
        rptTemp.Subreports.Item(0).SetDataSource(_dsReporte.Tables(1).Copy)
        rptTemp.Subreports.Item(1).SetDataSource(_dsReporte.Tables(2).Copy)

        rptTemp.SetParameterValue("pFechaIni", _FechaInicial)
        rptTemp.SetParameterValue("pFechaFin", _FechaFinal)
        rptTemp.SetParameterValue("pIncPara", _IncPara)
        rptTemp_General = rptTemp

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        pcxEspera.Visible = False

        CrystalReportViewer1.ReportSource = rptTemp_General

    End Sub
End Class
