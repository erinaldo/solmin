Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports Microsoft.Win32
Imports System.Diagnostics

Public Class frmConsultarSeguimientoGPS

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private Sub carga_datos_grilla(Optional ByVal PlacaTracto As String = "")
        Dim objSeguimientoWap As New SeguimientoWAP_BLL
        Dim objParametros As New Hashtable

        objParametros.Add("NPLCTR", IIf(PlacaTracto = "", Me.txtPlaca.Text, PlacaTracto))
        objParametros.Add("FECINI", HelpClass.CtypeDate(Me.dtpFechaInicio.Value).ToString.Trim)
        objParametros.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFechaFin.Value).ToString.Trim)
        objParametros.Add("CCMPN", CCMPN)

        Me.gwdDatosGPS.DataSource = objSeguimientoWap.Listar_Posiciones_GPS(objParametros)

        Me.gwdDatosGPS.Columns(0).Visible = False
        Me.gwdDatosGPS.Columns(1).Width = 90
        Me.gwdDatosGPS.Columns(1).HeaderText = "Fecha"
        Me.gwdDatosGPS.Columns(2).Width = 60
        Me.gwdDatosGPS.Columns(2).HeaderText = "Hora"
        Me.gwdDatosGPS.Columns(3).Width = 100
        Me.gwdDatosGPS.Columns(3).HeaderText = "Latitud GPS"
        Me.gwdDatosGPS.Columns(4).Width = 100
        Me.gwdDatosGPS.Columns(4).HeaderText = "Longitud GPS"
        Me.gwdDatosGPS.Columns(5).Width = 120
        Me.gwdDatosGPS.Columns(5).HeaderText = "Velocidad en KM/H"

        HeaderGroupTabs.ValuesPrimary.Heading = "Vehiculo " & Me.txtPlaca.Text

        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub Listar_Seguimiento_Flota()

        'Solo para flota Propia
        Dim objEntidad As New ENTIDADES.mantenimientos.TransportistaTracto
        Dim objTracto As New NEGOCIO.mantenimientos.Tracto_BLL
        Dim dtbDatos As New DataTable

        dtbDatos = objTracto.Listar_Tractos_Transportista_Propio(_CCMPN)

        Me.gwdDatosGPS.DataSource = dtbDatos
        Me.gwdDatosGPS.Columns(0).HeaderText = "PLACA"
        Me.gwdDatosGPS.Columns(1).HeaderText = "LATITUD"
        Me.gwdDatosGPS.Columns(2).HeaderText = "LONGITUD"


    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click

        Me.HeaderBrowser.Panel.Controls.Clear()

        'si el seguimiento es de toda la flota o es de un tracto en particular
        If Me.rdConsultaSeguimientoFlota.Checked = True Then

            Me.Listar_Seguimiento_Flota()

        Else

            If Me.txtPlaca.Text.Trim = "" Then
                HelpClass.MsgBox("Debe ingresar un vehículo para hacer el seguimiento.", MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                carga_datos_grilla(txtPlaca.Text.Trim)
            End If

        End If

    End Sub

    Private Sub btnMaximizarMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizarMapa.Click
        If Me.gwdDatosGPS.Rows.Count > 0 Then
            Dim longitud As String = Me.gwdDatosGPS.Item(4, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            Dim latitud As String = Me.gwdDatosGPS.Item(3, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            Dim objGpsBrowser As New frmMapa
            objGpsBrowser.Hora = Me.gwdDatosGPS.Item(2, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            objGpsBrowser.Fecha = Me.gwdDatosGPS.Item(1, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            objGpsBrowser.WindowState = FormWindowState.Maximized
            objGpsBrowser.ShowForm(latitud, longitud, Me)
        End If
    End Sub

    Private Sub ButtonSpecAny1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecAny1.Click

        'Creando la cadena de longitud y de latitud para
        Dim lstr_posicion_gps As String = ""
        Dim lstr_documento_xml As String = ""
        Dim archivo As String = ""
        Dim pStart As New System.Diagnostics.Process
        Dim str_localizacion As String = ""
        Dim lint_indice As Integer = 0

        lstr_documento_xml += "<?xml version=""1.0"" encoding=""UTF-8""?>"
        lstr_documento_xml += "<kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"" xmlns:kml=""http://www.opengis.net/kml/2.2"" xmlns:atom=""http://www.w3.org/2005/Atom"">"
        lstr_documento_xml += "<Document>"
        lstr_documento_xml += "	<name>SeguimientoWap.kml</name>"
        lstr_documento_xml += "	<open>1</open>"

        lstr_documento_xml += "	<StyleMap id=""msn_truck"">                                                   "
        lstr_documento_xml += "		<Pair>                                                                    "
        lstr_documento_xml += "			<key>normal</key>                                                     "
        lstr_documento_xml += "			<styleUrl>#sn_truck</styleUrl>                                        "
        lstr_documento_xml += "		</Pair>                                                                   "
        lstr_documento_xml += "		<Pair>                                                                    "
        lstr_documento_xml += "			<key>highlight</key>                                                  "
        lstr_documento_xml += "			<styleUrl>#sh_truck</styleUrl>                                        "
        lstr_documento_xml += "		</Pair>                                                                   "
        lstr_documento_xml += "	</StyleMap>                                                                   "
        lstr_documento_xml += "	<Style id=""sh_truck"">                                                       "
        lstr_documento_xml += "		<IconStyle>                                                               "
        lstr_documento_xml += "			<color>ff00aa55</color>                                               "
        lstr_documento_xml += "			<scale>1.4</scale>                                                    "
        lstr_documento_xml += "			<Icon>                                                                "
        lstr_documento_xml += "				<href>http://maps.google.com/mapfiles/kml/shapes/truck.png</href> "
        lstr_documento_xml += "			</Icon>                                                               "
        lstr_documento_xml += "			<hotSpot x=""0.5"" y=""0"" xunits=""fraction"" yunits=""fraction""/>  "
        lstr_documento_xml += "		</IconStyle>                                                              "
        lstr_documento_xml += "		<ListStyle>                                                               "
        lstr_documento_xml += "		</ListStyle>                                                              "
        lstr_documento_xml += "	</Style>                                                                      "
        lstr_documento_xml += "	<Style id=""sn_truck"">                                                       "
        lstr_documento_xml += "		<IconStyle>                                                               "
        lstr_documento_xml += "			<color>ff00aa55</color>                                               "
        lstr_documento_xml += "			<scale>1.2</scale>                                                    "
        lstr_documento_xml += "			<Icon>                                                                "
        lstr_documento_xml += "				<href>http://maps.google.com/mapfiles/kml/shapes/truck.png</href> "
        lstr_documento_xml += "			</Icon>                                                               "
        lstr_documento_xml += "			<hotSpot x=""0.5"" y=""0"" xunits=""fraction"" yunits=""fraction""/>  "
        lstr_documento_xml += "		</IconStyle>                                                              "
        lstr_documento_xml += "		<ListStyle>                                                               "
        lstr_documento_xml += "		</ListStyle>                                                              "
        lstr_documento_xml += "	</Style>       

        lstr_documento_xml += "	<Folder>"
        lstr_documento_xml += "		<name>Seguimiento Wap</name>"
        lstr_documento_xml += "		<open>1</open>"
        lstr_documento_xml += "		<Placemark>"
        lstr_documento_xml += "			<name>ruta001</name>"
        lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
        lstr_documento_xml += "			<LineString>"
        lstr_documento_xml += "				<tessellate>1</tessellate>"
        lstr_documento_xml += "				<coordinates>"
        lstr_documento_xml += "				</coordinates>"
        lstr_documento_xml += "			</LineString>"
        lstr_documento_xml += "		</Placemark>"
 
        If Me.rdConsultaSeguimientoFlota.Checked = True Then
            
            For i As Integer = 0 To Me.gwdDatosGPS.Rows.Count - 2

                If Me.gwdDatosGPS.Rows(i).Cells(2).Value.ToString.Trim = "" And Me.gwdDatosGPS.Rows(i).Cells(1).Value.ToString.Trim = "" Then
                    GoTo NextElement1
                End If

                lstr_documento_xml += "		<Placemark>"
                lstr_documento_xml += "			<name> " & Me.gwdDatosGPS.Rows(i).Cells(0).Value.ToString.Trim & "</name>"
                lstr_documento_xml += "<description>" & "Latitud : " & Me.gwdDatosGPS.Rows(i).Cells(1).Value.ToString.Trim & Chr(13) & "Longitud : " & Me.gwdDatosGPS.Rows(i).Cells(2).Value.ToString.Trim & "</description>"
                lstr_documento_xml += "			<open>1</open>"
                lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
                lstr_documento_xml += "			<Point>"
                lstr_documento_xml += "				<coordinates>" & Me.gwdDatosGPS.Rows(i).Cells(2).Value.ToString.Trim & "," & Me.gwdDatosGPS.Rows(i).Cells(1).Value.ToString.Trim & ",0</coordinates>"
                lstr_documento_xml += "			</Point>"
                lstr_documento_xml += "		</Placemark>"

                str_localizacion += Me.gwdDatosGPS.Rows(i).Cells(2).Value.ToString.Trim & "," & Me.gwdDatosGPS.Rows(i).Cells(1).Value.ToString.Trim & ", 0 "

                lint_indice += 1
Nextelement1:
            Next

        Else

            For Each objRow As DataGridViewRow In Me.gwdDatosGPS.SelectedRows

                If Me.rdConsultaSeguimientoFlota.Checked = False Then
                    If objRow.Cells(4).Value.ToString.Trim = "" And objRow.Cells(3).Value.ToString.Trim = "" Then
                        GoTo NextElement
                    End If
                Else
                    If objRow.Cells(2).Value.ToString.Trim = "" And objRow.Cells(1).Value.ToString.Trim = "" Then
                        GoTo NextElement
                    End If
                End If

                lstr_documento_xml += "		<Placemark>" 
                lstr_documento_xml += "			<name> " & lint_indice & " :" & objRow.Cells(1).Value.ToString.Trim & " | " & objRow.Cells(2).Value.ToString.Trim & "</name>"
                lstr_documento_xml += "<description>" & "Latitud : " & objRow.Cells(3).Value.ToString.Trim & Chr(13) & "Longitud : " & objRow.Cells(4).Value.ToString.Trim & Chr(13) & "Velocidad : " & objRow.Cells(5).Value.ToString.Trim & "</description>"
                lstr_documento_xml += "			<open>1</open>"
                lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
                lstr_documento_xml += "			<Point>"
                lstr_documento_xml += "				<coordinates>" & objRow.Cells(4).Value.ToString.Trim & "," & objRow.Cells(3).Value.ToString.Trim & ",0</coordinates>"
                lstr_documento_xml += "			</Point>"
                lstr_documento_xml += "		</Placemark>"

                If Me.rdConsultaSeguimientoFlota.Checked = False Then
                    str_localizacion += objRow.Cells(4).Value.ToString.Trim & "," & objRow.Cells(3).Value.ToString.Trim & ", 0 "
                Else
                    str_localizacion += objRow.Cells(2).Value.ToString.Trim & "," & objRow.Cells(1).Value.ToString.Trim & ", 0 "
                End If

                lint_indice += 1

NextElement:
            Next
        End If

        If Me.rdConsultaSeguimientoFlota.Checked = False Then
            lstr_documento_xml += "	<Placemark>"
            lstr_documento_xml += "			<name>Seguimiento Vehicular</name>"
            lstr_documento_xml += "			<description>Seguimiento de Vehiculo</description>"
            lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
            lstr_documento_xml += "			<LineString>"
            lstr_documento_xml += "				<tessellate>1</tessellate>"
            lstr_documento_xml += "				<coordinates>" 
            lstr_documento_xml += str_localizacion 
            lstr_documento_xml += "</coordinates>"
            lstr_documento_xml += "			</LineString>"
            lstr_documento_xml += "	</Placemark>"
        End If

        lstr_documento_xml += "	</Folder>"
        lstr_documento_xml += "</Document>"
        lstr_documento_xml += "</kml>"


        Try
            archivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Ruta_" & HelpClass.TodayNumeric & "" & HelpClass.NowNumeric & ".kml"
            Dim oFile As New IO.StreamWriter(archivo, False, Encoding.ASCII)
            oFile.WriteLine(lstr_documento_xml)
            oFile.Close()
            Process.Start(archivo)
        Catch : End Try

    End Sub

    Private Sub ButtonSpecAny2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecAny2.Click

        If Me.rdConsultaSeguimientoFlota.Checked = True Then
            Exit Sub
        End If

        Try
            If Me.gwdDatosGPS.Rows.Count > 0 Then
                'Creando la cadena de longitud y de latitud para
                Dim lstr_posicion_gps As String = ""
                Dim lstr_documento_xml As String = ""
                Dim archivo As String = ""
                Dim pStart As New System.Diagnostics.Process
                Dim str_localizacion As String = ""
                Dim lint_indice As Integer = 0


                For Each objRow As DataGridViewRow In Me.gwdDatosGPS.SelectedRows

                    If objRow.Cells(4).Value.ToString.Trim <> "" And objRow.Cells(3).Value.ToString.Trim <> "" Then
                        str_localizacion += "" & objRow.Cells(3).Value.ToString.Trim & "," & objRow.Cells(4).Value.ToString.Trim & "|"
                    End If

                Next

                str_localizacion = (Me.gwdDatosGPS.SelectedRows.Count) & "|" & str_localizacion.Substring(0, str_localizacion.Length - 2)

                Dim GpsBrowser As New WebBrowser
                Me.HeaderBrowser.Panel.Controls.Clear()
                Me.HeaderBrowser.Panel.Controls.Add(GpsBrowser)

                GpsBrowser.Dock = DockStyle.Fill
                'Cargando en el browser

                GpsBrowser.Navigate("https://secure.ransa.net/wapsolmin/tracking/webgpssolmin.asp?txt=x1&ancho=400&alto=300&lon=" & 0 & "&lat=" & 0 & "&mappath=" & str_localizacion)

            End If

        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub btnCerrarPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarPantalla.Click
        Me.Close()
    End Sub

    Private Sub txtPlaca_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlaca.KeyUp
        If e.KeyCode = Keys.Enter Then
            carga_datos_grilla()
        End If
    End Sub

    Private Sub btnPantallaAncha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPantallaAncha.Click
        HeaderGroupFiltro.Visible = Not HeaderGroupFiltro.Visible
        If HeaderGroupFiltro.Visible Then
            btnPantallaAncha.Text = "Maximizar"
            btnPantallaAncha.Image = My.Resources.window_fullscreen
        Else
            btnPantallaAncha.Text = "Minimizar"
            btnPantallaAncha.Image = My.Resources.window_nofullscreen
        End If
    End Sub

    Private Sub cargar_datos_wap(Optional ByVal ShowExterno As Boolean = False)

        Dim longitud As String = ""
        Dim latitud As String = ""

        If Me.rdConsultaSeguimientoFlota.Checked = False Then
            longitud = Me.gwdDatosGPS.Item(4, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            latitud = Me.gwdDatosGPS.Item(3, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
        Else
            longitud = Me.gwdDatosGPS.Item(2, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
            latitud = Me.gwdDatosGPS.Item(1, gwdDatosGPS.CurrentCellAddress.Y).Value.ToString.Trim
        End If

        If Me.HeaderBrowser.Panel.Controls.Count > 0 Then
            Me.HeaderBrowser.Panel.Controls.Clear()
        End If

        Dim GpsBrowser As New WebBrowser

        Try
            ' If (Not IExplorer.IsBrowserEmulationSet()) Then
            IExplorer.SetBrowserEmulationVersion()
            '   End If
        Catch ex As Exception

        End Try

        Dim lstr_gps As String = "https://secure.ransa.net/wapsolmin/tracking/webgpssolmin.asp?txt=x1&ancho=400&alto=300&lon=" & longitud & "&lat=" & latitud & ""

        If ShowExterno = True Then
            Help.ShowHelp(Me, lstr_gps)
        End If

        Me.HeaderBrowser.Panel.Controls.Clear()
        Me.HeaderBrowser.Panel.Controls.Add(GpsBrowser)
        GpsBrowser.Dock = DockStyle.Fill

        'Cargando en el browser   
        GpsBrowser.Navigate(lstr_gps)

    End Sub

    Private Sub gwdDatosGPS_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatosGPS.CellClick


        If e.RowIndex < 0 Or Me.gwdDatosGPS.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        cargar_datos_wap()

    End Sub

    Private Sub gwdDatosGPS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatosGPS.CellContentClick

    End Sub

    Private Sub OnCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdConsultaSeguimientoFlota.CheckedChanged, rdConsultaTractoInvividual.CheckedChanged

        Me.gwdDatosGPS.DataSource = Nothing
        Me.HeaderBrowser.Panel.Controls.Clear()
        Me.txtPlaca.Text = ""

    End Sub

    Private Sub gwdDatosGPS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatosGPS.CellDoubleClick
        cargar_datos_wap(True)
    End Sub
End Class
