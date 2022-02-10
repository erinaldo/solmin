
Public Class frmMapa

#Region "Atributos"
    Private _hora As String = ""
    Private _fecha As String = ""
    Private _latitud As String = ""
    Private _longitud As String = ""
    Private _Cliente As String = ""
    Private _localiza As String = ""

    Public Property localiza() As String
        Get
            Return _localiza
        End Get
        Set(ByVal value As String)
            _localiza = value
        End Set
    End Property

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

    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

#End Region

#Region "Metodos y Funciones"

    Public Sub F5()
        SendKeys.Send("{F5}")
    End Sub



    Public Sub ShowForm(ByVal Latitud As String, ByVal Longitud As String, ByVal owner As IWin32Window)
        Try
            Dim GpsBrowser As New WebBrowser
            GpsBrowser.Refresh()
            'My.Settings.Reload()
            'SendKeys.Send("{F5}")
            Me.KryptonHeaderGroup2.Panel.Controls.Clear()
            Me.KryptonHeaderGroup2.Panel.Controls.Add(GpsBrowser)
            GpsBrowser.Dock = DockStyle.Fill
            Dim link As String = My.Settings.SA_URL + "tracking/frmGpsBrowserWideSize.aspx?tipo=WideScreen&txt=Pantalla%20Completa&ancho=800&alto=700&lon=" & Longitud & "&lat=" & Latitud
            GpsBrowser.Navigate(link)
            Me.txtLatitud.Text = _latitud
            Me.txtLongitud.Text = _longitud
            Me.txtHora.Text = _hora
            Me.txtFecha.Text = _fecha
            Me.ShowDialog(owner)
        Catch : End Try
    End Sub


    Public Sub ShowForm_1(ByVal str_localizacion As String, ByVal owner As IWin32Window)
        Try
            Dim GpsBrowser As New WebBrowser
            Me.KryptonHeaderGroup2.Panel.Controls.Clear()
            Me.KryptonHeaderGroup2.Panel.Controls.Add(GpsBrowser)
            GpsBrowser.Dock = DockStyle.Fill
            GpsBrowser.Navigate("http://asp.ransa.com.pe/wapmineria/tracking/frmGpsBrowserWideSize.aspx?tipo=WideScreen&txt=Pantalla%20Completa&ancho=800&alto=700&lon=" & 0 & "&lat=" & 0 & "&mappath=" & str_localizacion)
            Me.txtLatitud.Text = _latitud
            Me.txtLongitud.Text = _longitud
            Me.txtHora.Text = _hora
            Me.txtFecha.Text = _fecha
            Me.ShowDialog(owner)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub BorrarTemp()

        Dim ruta_temp As String = System.IO.Path.GetTempPath()
        'Creamos la clase DirectoryInfo
        Dim Directorios As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(ruta_temp)
        'Obtenemos los directorios y los vamos almacenando de la variable Dir
        For Each Dir As System.IO.DirectoryInfo In Directorios.GetDirectories()
            Try
                'Eliminamos el directorio y todos los subdirectorios y ficheros que contiene
                System.IO.Directory.Delete(ruta_temp & "" & Dir.ToString(), True)
            Catch ex As Exception
            End Try
        Next
        'Obtenemos los ficheros del directorio temporal y los almacenamos en Fich
        For Each Fich As System.IO.FileInfo In Directorios.GetFiles()
            'Usamos try por si se genera algún error o por si el fichero está siendo abierto por otro programa
            Try
                'Eliminamos el fichero temporal
                System.IO.File.Delete(ruta_temp & "" & Fich.ToString())
            Catch ex As Exception
            End Try
        Next
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

#End Region

End Class
