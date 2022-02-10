Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System
Imports System.Text

Public Class frmConsultarVehiculo
  Private TractoTemporal As New List(Of Tracto)
  Private EventoTemporal As New List(Of AccionWap)
    Private lbool_PreCargaData As Boolean = False
    'Private _lista As New List(Of ConsultaVehicular)
    Private bolBuscar As Boolean = False
  Public Property LoadPreviuosData() As Boolean
    Get
      Return lbool_PreCargaData
    End Get
    Set(ByVal value As Boolean)
      lbool_PreCargaData = value
    End Set
  End Property

  Public Sub ShowForm(ByVal CodigoTrasportista As String, ByVal CodigoUnidad As String, ByVal owner As IWin32Window)

    Carga_Data_Inicial()
    'Establece el trasportista
        CargarTransportista(CodigoTrasportista)
    Me.ctbTransportista.Enabled = False
    Me.Lista()

    'Establece el nuevo flag para la ventana
    lbool_PreCargaData = True
    Me.Show(owner)

    End Sub

    Private Sub CargarTransportista(ByVal CodigoTrasportista As String)
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pNRUCTR_RucTransportista = CodigoTrasportista
        obeTransportista.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        ctbTransportista.pCargar(obeTransportista)
    End Sub


#Region "COMPAÑIA DIVISION Y PLANTA"

    Private Sub Cargar_Compania()
        Try
            Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
            bolBuscar = False
            objCompaniaBLL.Crea_Lista()
            cmbCompania.DataSource = objCompaniaBLL.Lista
            cmbCompania.ValueMember = "CCMPN"
            cmbCompania.DisplayMember = "TCMPCM"
            'cmbCompania.SelectedIndex = 0
            cmbCompania.SelectedValue = "EZ"
            If cmbCompania.SelectedIndex = -1 Then
                cmbCompania.SelectedIndex = 0
            End If
            bolBuscar = True
            cmbCompania_SelectedIndexChanged(Nothing, Nothing)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objDivision.Crea_Lista()
                cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
                cmbDivision.ValueMember = "CDVSN"
                cmbDivision.DisplayMember = "TCMPDV"
                cmbDivision.SelectedValue = "T"
                If cmbDivision.SelectedIndex = -1 Then
                    cmbDivision.SelectedIndex = 0
                End If
                bolBuscar = True
                cmbDivision_SelectedIndexChanged(Nothing, Nothing)
            End If

        Catch ex As Exception

            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objPlanta As New NEGOCIO.Planta_BLL
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
                bolBuscar = True
                cmbPlanta.SelectedIndex = 0
                cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Division()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar = True Then
            Cargar_Planta()
        End If
    End Sub
    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar = True Then
            InicializarFormulario()
        End If
    End Sub
    Private Sub InicializarFormulario()
        'gwdDatos.DataSource = Nothing
        If (gwdDatos.Rows.Count > 0) Then
            gwdDatos.Rows.Clear()
        End If
        Me.ctbVehiculo.pClearAll()
        Cargar_Combo_Vehiculo()
        ctbTransportista.pClear()
        CargarTransportista("")
    End Sub
#End Region

  Private Sub Carga_Data_Inicial()
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next

        If (cmbCompania.SelectedValue.ToString().Trim() = "EZ") Then
            CargarTransportista("20100039207")
        Else
            CargarTransportista("")
        End If

    Me.Cargar_Combo_Vehiculo()
        Cargar_Combo_Vehiculo()
        Lista_Eventos_WAP()
  End Sub

  Private Sub frmConsultarVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lbool_PreCargaData = False Then
            Cargar_Compania()
            Carga_Data_Inicial()
        End If
  End Sub

  Private Sub dgwDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
    If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    Try
      If e.ColumnIndex = 8 Then
        If Me.gwdDatos.Item("GPSLAT", e.RowIndex).Value.ToString <> "" Then
          Dim objGpsBrowser As New frmMapa
          With objGpsBrowser
            .Latitud = Me.gwdDatos.Item("GPSLAT", e.RowIndex).Value
            .Longitud = Me.gwdDatos.Item("GPSLON", e.RowIndex).Value
            .Fecha = Me.gwdDatos.Item("FECGPS", e.RowIndex).Value
                        .Hora = Me.gwdDatos.Item("HORGPS", e.RowIndex).Value.ToString.Trim
            .WindowState = FormWindowState.Maximized
            .ShowForm(.Latitud, .Longitud, Me)
          End With
        End If
      End If
        Catch : End Try
        Dim hash As New Hashtable()
        hash("CCMPN") = cmbCompania.SelectedValue.ToString()

        If e.ColumnIndex = 1 Then Informacion_Detallada_Transportista(1, Me.gwdDatos.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim, hash)
        If e.ColumnIndex = 6 Then Informacion_Detallada_Transportista(2, Me.gwdDatos.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim, hash)
        If e.ColumnIndex = 7 Then Informacion_Detallada_Transportista(3, Me.gwdDatos.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim, hash)

  End Sub

  'sub original
  Private Sub Lista()
    Dim objSeguimientoWap As New SeguimientoWAP_BLL
    Dim objParametros As New Hashtable
    Dim ldgrow As DataGridViewRow
    Try
      Me.gwdDatos.Rows.Clear()
            objParametros.Add("NRUCTR", IIf(Me.ctbTransportista.pRucTransportista.Trim.Equals(""), "", Me.ctbTransportista.pRucTransportista))
            objParametros.Add("NPLCUN", IIf(Me.ctbVehiculo.pNroPlacaUnidad.Trim.Equals(""), "0", Me.ctbVehiculo.pNroPlacaUnidad))

            objParametros.Add("CCMPN", Me.cmbCompania.SelectedValue)
            objParametros.Add("CDVSN", Me.cmbDivision.SelectedValue)
            objParametros.Add("CPLNDV", Me.cmbPlanta.SelectedValue)

      objParametros.Add("NCOEVT", IIf(Me.ctbEvento.Texto.TextLength = 0, "0", Me.ctbEvento.Codigo.Trim))
      For Each objDataRow As DataRow In objSeguimientoWap.Listar_Ultima_Ubicacion(objParametros).Rows
        ldgrow = New DataGridViewRow
        ldgrow.CreateCells(Me.gwdDatos)
        ldgrow.Cells(0).Value = objDataRow.Item("NRUCTR").ToString
        ldgrow.Cells(1).Value = objDataRow.Item("NPLCUN").ToString
        ldgrow.Cells(2).Value = objDataRow.Item("TCLRUN").ToString
        ldgrow.Cells(3).Value = objDataRow.Item("TMRCTR").ToString
        ldgrow.Cells(4).Value = objDataRow.Item("CTPCRA").ToString
        ldgrow.Cells(5).Value = objDataRow.Item("TCMCRA").ToString
        ldgrow.Cells(6).Value = objDataRow.Item("NPLACP").ToString
        ldgrow.Cells(7).Value = objDataRow.Item("CBRCNT").ToString
        ldgrow.Cells(9).Value = objDataRow.Item("SEGUIMIENTO").ToString.Trim
        ldgrow.Cells(10).Value = objDataRow.Item("GPSLAT").ToString
        ldgrow.Cells(11).Value = objDataRow.Item("GPSLON").ToString
        ldgrow.Cells(12).Value = objDataRow.Item("FECGPS").ToString
        ldgrow.Cells(13).Value = objDataRow.Item("HORGPS").ToString
        ldgrow.Cells(14).Value = objDataRow.Item("ULT_CHECKPOINT").ToString
        If ldgrow.Cells(13).Value <> "" Then
          ldgrow.Cells(8).Value = My.Resources.button_ok1
        Else
          ldgrow.Cells(8).Value = My.Resources.Nada_1
        End If
        Me.gwdDatos.Rows.Add(ldgrow)
      Next
    Catch ex As Exception
    End Try
  End Sub

 

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("") OrElse Not Me.ctbVehiculo.pNroPlacaUnidad.Trim.Equals("") OrElse Me.ctbEvento.Texto.TextLength > 0 Then
            Me.Lista()
        Else
            Me.gwdDatos.Rows.Clear()
        End If
  End Sub

    
    Private Sub Cargar_Combo_Vehiculo()
        Dim obj_Logica_Vehiculo As New SOLMIN_ST.NEGOCIO.mantenimientos.TransportistaTracto_BLL
        

        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCDVSN_Division = Me.cmbDivision.SelectedValue
        obeTracto.pCPLNDV_Planta = Me.cmbPlanta.SelectedValue
        obeTracto.pNRUCTR_RucTransportista = Me.ctbTransportista.pRucTransportista
        ctbVehiculo.pCargar(obeTracto)
    End Sub

    Private Sub Lista_Eventos_WAP()
        Dim obrSeguimientoWAP_BLL As New SeguimientoWAP_BLL
        With ctbEvento
            .DataSource = HelpClass.GetDataSetNative(obrSeguimientoWAP_BLL.Lista_Eventos_Wap(Me.cmbCompania.SelectedValue))
            .KeyField = "NCOEVT"
            .ValueField = "TNMEV"
            .DataBind()
        End With
    End Sub


    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("20100039207") Then
            Exit Sub
        End If

        btnBuscar_Click(sender, e)

        Threading.Thread.Sleep(2000)

        'Solo para flota Propia
        Dim objEntidad As New ENTIDADES.mantenimientos.TransportistaTracto
        Dim objTracto As New NEGOCIO.mantenimientos.Tracto_BLL
        Dim dtbDatos As New DataTable

        dtbDatos = objTracto.Listar_Tractos_Transportista_Propio(Me.cmbCompania.SelectedValue)
 
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
        lstr_documento_xml += "	</Style>       "

        lstr_documento_xml += "	<Folder>"
        lstr_documento_xml += "		<name>Seguimiento de Flota</name>"
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
  
        For i As Integer = 0 To dtbDatos.Rows.Count - 2

            If dtbDatos.Rows(i).Item(2).ToString.Trim = "" And dtbDatos.Rows(i).Item(1).ToString.Trim = "" Then
                GoTo NextElement1
            End If

            lstr_documento_xml += "		<Placemark>"
            lstr_documento_xml += "			<name> " & dtbDatos.Rows(i).Item(0).ToString.Trim & "</name>"
            lstr_documento_xml += "<description>" & "Latitud : " & dtbDatos.Rows(i).Item(1).ToString.Trim & Chr(13) & "Longitud : " & dtbDatos.Rows(i).Item(2).ToString.Trim & "</description>"
            lstr_documento_xml += "			<open>1</open>"
            lstr_documento_xml += "			<styleUrl>#msn_truck</styleUrl>"
            lstr_documento_xml += "			<Point>"
            lstr_documento_xml += "				<coordinates>" & dtbDatos.Rows(i).Item(2).ToString.Trim & "," & dtbDatos.Rows(i).Item(1).ToString.Trim & ",0</coordinates>"
            lstr_documento_xml += "			</Point>"
            lstr_documento_xml += "		</Placemark>"

            str_localizacion += dtbDatos.Rows(i).Item(2).ToString.Trim & "," & dtbDatos.Rows(i).Item(1).ToString.Trim & ", 0 "

            lint_indice += 1
Nextelement1:
        Next
 
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

    Private Sub ctbTransportista_InformationChanged() Handles ctbTransportista.InformationChanged
        Me.ctbVehiculo.pClearAll()
            Cargar_Combo_Vehiculo()
    End Sub

  
End Class