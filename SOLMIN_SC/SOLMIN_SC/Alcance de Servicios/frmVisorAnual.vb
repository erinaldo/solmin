Public Class frmVisorAnual

    Private _dtAnual As DataTable
    Public Property dtAnual() As DataTable
        Get
            Return _dtAnual
        End Get
        Set(ByVal value As DataTable)
            _dtAnual = value
        End Set
    End Property

    Private _CCLNT As String
    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    Private _ANIO As String
    Public Property ANIO() As String
        Get
            Return _ANIO
        End Get
        Set(ByVal value As String)
            _ANIO = value
        End Set
    End Property

    Dim rptTemp As rptAlcanceServicioAnual
    Dim rptTemp_General As New rptAlcanceServicioAnual

    Private Sub frmVisorAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        rptTemp = New rptAlcanceServicioAnual
        _dtAnual.TableName = "dtAnual"
        rptTemp.SetDataSource(_dtAnual.Copy)

        rptTemp.SetParameterValue("pCliente", _CCLNT)
        rptTemp.SetParameterValue("pAnio", _ANIO)

        rptTemp_General = rptTemp

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        pcxEspera.Visible = False
        crvReporteAnual.ReportSource = rptTemp_General

    End Sub
End Class
