Public Class frmMapa 

    Private _hora As String = ""
    Private _fecha As String = ""
    Private _latitud As String = ""
    Private _longitud As String = ""
    Private _Flag As Double = 0

    Public Sub ShowForm(ByVal Latitud As String, ByVal Longitud As String, ByVal owner As IWin32Window)
        Try
            Dim GpsBrowser As New WebBrowser
            Dim link As String = My.Settings.URL_GPS + "tracking/frmGpsBrowserWideSize.aspx?tipo=WideScreen&txt=Pantalla%20Completa&ancho=800&alto=700&lon=" & Longitud & "&lat=" & Latitud
            KryptonHeaderGroup2.Panel.Controls.Add(GpsBrowser)
            GpsBrowser.Dock = DockStyle.Fill
            GpsBrowser.Navigate(link)

            'Imprimiendo los datos de posicion gps
            Me.txtLatitud.Text = _latitud
            Me.txtLongitud.Text = _longitud
            Me.txtHora.Text = _hora
            Me.txtFecha.Text = _fecha
            If _Flag = 1 Then
                btnRegresar.Visible = True
            Else
                btnRegresar.Visible = False
            End If
            Me.ShowDialog(owner)

        Catch : End Try

    End Sub

    Public Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property Latitud() As String
        Get
            Return _latitud
        End Get
        Set(ByVal value As String)
            _latitud = value
        End Set
    End Property

    Public Property Longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal value As String)
            _longitud = value
        End Set
    End Property

    Public WriteOnly Property Flag() As Double
        Set(ByVal value As Double)
            _Flag = value
        End Set
    End Property

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

End Class
