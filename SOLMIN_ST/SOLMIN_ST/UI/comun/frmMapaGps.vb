Public Class frmMapaGps

    Private _nroSolicitud As String = ""
    Private _nroCorrelativo As String = ""

    Public Sub ShowForm(ByVal owner As IWin32Window)

        Try
            Dim GpsBrowser As New WebBrowser
            Dim link As String = My.Settings.ST_WEB + "popups/frmConsultaGPS.aspx?x_win=true&nro=" & nroSolicitud & "&correlativo=" & _nroCorrelativo
            KryptonHeaderGroup2.Panel.Controls.Add(GpsBrowser)
            GpsBrowser.Dock = DockStyle.Fill
            GpsBrowser.Navigate(link)
            Me.ShowDialog(owner)
        Catch : End Try
    End Sub

    Public Property nroSolicitud() As String
        Get
            Return _nroSolicitud
        End Get
        Set(ByVal value As String)
            _nroSolicitud = value
        End Set
    End Property

    Public Property nroCorrelativo() As String
        Get
            Return _nroCorrelativo
        End Get
        Set(ByVal value As String)
            _nroCorrelativo = value
        End Set
    End Property


End Class
