Public Class frmVisor
    Private rptTemp As New rptAlcanceServicioMensual

    Private _DataTable As DataTable
    Public Property DataTable() As DataTable
        Get
            Return _DataTable
        End Get
        Set(ByVal value As DataTable)
            _DataTable = value
        End Set
    End Property

    Private _TCMPCL As String
    Public Property TCMPCL() As String
        Get
            Return _TCMPCL
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
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


    Private _MES As String
    Public Property MES() As String
        Get
            Return _MES
        End Get
        Set(ByVal value As String)
            _MES = value
        End Set
    End Property

    Private _TCMPDV As String
    Public Property TCMPDV() As String
        Get
            Return _TCMPDV
        End Get
        Set(ByVal value As String)
            _TCMPDV = value
        End Set
    End Property


    Private Sub frmVisor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        DataTable.TableName = "dtMensual"
        rptTemp.SetDataSource(DataTable.Copy)

        rptTemp.SetParameterValue("pDivision", TCMPDV)
        rptTemp.SetParameterValue("pCliente", TCMPCL)
        rptTemp.SetParameterValue("pAnio", ANIO)
        rptTemp.SetParameterValue("pMes", MES)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        pcxEspera.Visible = False
        crvReporte.ReportSource = rptTemp

    End Sub
End Class
