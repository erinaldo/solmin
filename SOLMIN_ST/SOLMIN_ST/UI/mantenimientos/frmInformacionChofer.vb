Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Collections.Generic
Imports System.Configuration
Public Class frmInformacionChofer
  Private vBrevete As String = ""
  Private vCCMPN As String
  Friend WithEvents picBox As MyPictureBox
  Dim _NCOIMG As Integer = -1
  Dim NombrePictueSel As String = ""
  Public Property CCMPN() As String
    Get
      Return vCCMPN
    End Get
    Set(ByVal value As String)
      vCCMPN = value
    End Set
  End Property



  Public Sub ShowForm(ByVal owner As IWin32Window)
    'Forzando destruccion de memoria
    ClearMemory()
    'Mostrando el formulario
    Me.ShowDialog(owner)
  End Sub

  Private Sub frmInformacionChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      gwdHistorial.AutoGenerateColumns = False
      CargarComboTipoLicenciaConducir()
      Dim obj As New Chofer_BLL
      Dim objEntidad As New Chofer
      objEntidad.CBRCNT = vBrevete
      objEntidad.CCMPN = vCCMPN
      objEntidad.ESTADO = obj.Obtener_Estado_Chofer(objEntidad)

      Dim objGenericCollection As List(Of Chofer)
      objGenericCollection = obj.Listar_Chofer(objEntidad)

      If objGenericCollection.Count > 0 Then
        txtCodigoBrevete.Text = objGenericCollection.Item(0).CBRCNT
        txtNombres.Text = objGenericCollection.Item(0).TNMCMC
        txtApellidoPaterno.Text = objGenericCollection.Item(0).TAPPAC
        txtApellidoMaterno.Text = objGenericCollection.Item(0).TAPMAC
        CboTipoLicenciaConducir.Codigo = objGenericCollection.Item(0).NCLICO
        txtDni.Text = objGenericCollection.Item(0).NLELCH
        txtSeguroSocial.Text = objGenericCollection.Item(0).CSGRSC
        txtGrupoSanguineo.Text = objGenericCollection.Item(0).TGRPSN
        dtpDatFecVencDNI.Value = objGenericCollection.Item(0).FVEDNI
        dtpDatFecEmLic.Value = objGenericCollection.Item(0).FEMLIC
        dtpDatFecVencLic.Text = objGenericCollection.Item(0).FVELIC
        txtDatCodSAP.Text = objGenericCollection.Item(0).CODSAP
        dtpDatFecIng.Value = objGenericCollection.Item(0).FCHING
        txtDatDireccion.Text = objGenericCollection.Item(0).TDRCC
        txtDatRPM.Text = objGenericCollection.Item(0).NRORPM
        txtDatObservaciones.Text = objGenericCollection.Item(0).TOBS

        'tratando de cargar la foto del conductor 
        Dim objImage As Image
        Dim lbool_existe As Boolean = MainModule.ExistImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/" & vBrevete.Trim & ".jpg")

        If lbool_existe = True Then
          objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/" & vBrevete.Trim & ".jpg", True)
        Else
          objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/truck.jpg", True)
        End If

        Me.imgConductor.Image = objImage

        'llena los grids de los tabs

        '================================
        txtCodigoBrevete.Text = objGenericCollection.Item(0).CBRCNT
        txtNombres.Text = objGenericCollection.Item(0).TNMCMC
        txtApellidoPaterno.Text = objGenericCollection.Item(0).TAPPAC
        txtApellidoMaterno.Text = objGenericCollection.Item(0).TAPMAC
        CboTipoLicenciaConducir.Codigo = objGenericCollection.Item(0).NCLICO
        txtDni.Text = objGenericCollection.Item(0).NLELCH
        txtSeguroSocial.Text = objGenericCollection.Item(0).CSGRSC
        txtGrupoSanguineo.Text = objGenericCollection.Item(0).TGRPSN


        chkTercero.Checked = objGenericCollection.Item(0).SINDRC.Trim.ToString.Equals("T")

        'fecha vencimiento dni
        If objGenericCollection.Item(0).FVEDNI = "" Then
          Me.dtpDatFecVencDNI.Value = Today
        Else
          'La conversión de la cadena "0" en el tipo 'Date' no es válida.
          Me.dtpDatFecVencDNI.Value = objGenericCollection.Item(0).FVEDNI
        End If

        If objGenericCollection.Item(0).FEMLIC = "" Then
          Me.dtpDatFecEmLic.Value = Today
        Else
          Me.dtpDatFecEmLic.Value = objGenericCollection.Item(0).FEMLIC
        End If

        If objGenericCollection.Item(0).FVELIC = "" Then
          Me.dtpDatFecVencLic.Value = Today
        Else
          Me.dtpDatFecVencLic.Value = objGenericCollection.Item(0).FVELIC
        End If

        Me.txtDatCodSAP.Text = objGenericCollection.Item(0).CODSAP

        If objGenericCollection.Item(0).FCHING = "" Then
          Me.dtpDatFecIng.Value = Today
        Else
          Me.dtpDatFecIng.Value = objGenericCollection.Item(0).FCHING
        End If

        Me.txtDatDireccion.Text = objGenericCollection.Item(0).TDRCC
        Me.txtDatRPM.Text = objGenericCollection.Item(0).NRORPM
        Me.txtDatObservaciones.Text = objGenericCollection.Item(0).TOBS
        'tratando de cargar la foto del conductor 
        Try
          objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/" & objGenericCollection.Item(0).CBRCNT & ".jpg", True)
        Catch ex As Exception
          objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/truck.jpg", True)
        End Try

        Me.imgConductor.Image = objImage
        '=================================
        Listar_Capacitacion()
        Listar_Pase()
        ListarRecordMedico()
        ListarRecordGeneral()
        Cargar_Datos_Historial()
        cargarDocLinks()

        TabControl1.Controls.Remove(TabPageImg)
      End If

    Catch ex As Exception
    End Try
  End Sub

  Private Sub CargarComboTipoLicenciaConducir()
    Try
      Dim obj As New TipoLicenciaConducir_BLL
      Dim objEntidad As New TipoLicenciaConducir
      objEntidad.CCATLI = ""
      objEntidad.CCMPN = CCMPN
      CboTipoLicenciaConducir.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tipo_Licencia_Conducir(objEntidad))

      CboTipoLicenciaConducir.ValueField = "CCATLI"
      CboTipoLicenciaConducir.KeyField = "NCLICO"
      CboTipoLicenciaConducir.DataBind()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Listar_Capacitacion()
    Dim obj As New CapacitacionConductor_BLL
    Dim objEntidad As New CapacitacionConductor
    objEntidad.CBRCNT = vBrevete
    objEntidad.CCMPN = vCCMPN
    Me.gwdCapacitacionDatosCapt.AutoGenerateColumns = False
    Me.gwdCapacitacionDatosCapt.DataSource = obj.Listar_CapacitacionConductor(objEntidad)
  End Sub

  Private Sub Listar_Pase()
    Dim PaseBL As New PaseConductor_BLL
    Dim PaseBE As New PaseConductor
    PaseBE.CBRCNT = vBrevete
    PaseBE.CCMPN = vCCMPN
    gwdPase_TipoPase.AutoGenerateColumns = False
    Me.gwdPase_TipoPase.DataSource = PaseBL.Lista_Pases(PaseBE)
  End Sub

  Private Sub ListarRecordMedico()
    Dim obj As New RecordMedico_BLL
    Dim objEntidad As New RecordMedico
    objEntidad.CBRCNT = vBrevete
    objEntidad.CCMPN = vCCMPN
    Me.gwdRecordMedico.AutoGenerateColumns = False
    Me.gwdRecordMedico.DataSource = obj.Listar_Record_Medico(objEntidad)
  End Sub

  Private Sub ListarRecordGeneral()
    Dim obj As New RecordGeneral_BLL
    Dim objEntidad As New RecordGeneral

    objEntidad.CBRCNT = vBrevete
    objEntidad.CCMPN = vCCMPN
    Me.gwdRecordGeneral.AutoGenerateColumns = False
    Me.gwdRecordGeneral.DataSource = obj.Listar_Record_General(objEntidad)
  End Sub
  Private Sub Cargar_Datos_Historial()
    Try
      Dim obj As New TransportistaConductor()
      Dim objBll As New TransportistaConductor_BLL()
      Dim dt As New DataTable()
      obj.CBRCNT = vBrevete
      obj.CCMPN = vCCMPN
      gwdHistorial.DataSource = objBll.Listar_TransportistaConductor_Historial(obj)
    Catch ex As Exception
      gwdHistorial.DataSource = Nothing
    End Try
  End Sub

  Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.Close()
  End Sub

  Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub
  Private Sub cargarDocLinks()
    _NCOIMG = -1
    Dim objLogica As New DocAdjuntoConductor_BLL
    Dim dtb As New DataTable
    Dim NomCarpetaConductor As String = ""
    NomCarpetaConductor = ConfigurationManager.AppSettings("RUTA_CONDUCTOR").ToString()
    Dim miHash As New Hashtable()
    Dim objParamentro As New Hashtable
    If txtCodigoBrevete.Text.Trim <> vbNullString Then
      miHash.Add("CBRCNT", vBrevete)
      miHash.Add("NCRRDC", 0)
      miHash.Add("CCMPN", vCCMPN)
    Else
      Exit Sub
    End If

    NomCarpetaConductor = (NomCarpetaConductor & miHash("CBRCNT").ToString()).Trim()

    'lee los doclinks de la BD
    dtb = objLogica.Listar_Documentos_Adjuntos(miHash)

    PnlDocs.Controls.Clear()
    PnlImg.Controls.Clear()

    Dim imgPanelDocs As New TableLayoutPanel
    imgPanelDocs.AutoScroll = True
    imgPanelDocs.ColumnCount = 9
    imgPanelDocs.Dock = DockStyle.Fill

    Dim imgPanelImg As New TableLayoutPanel
    imgPanelImg.AutoScroll = True
    imgPanelImg.ColumnCount = 3
    imgPanelImg.Dock = DockStyle.Fill

    'crear componentes con sus imagenes
    If dtb.Rows.Count > 0 Then
      For i As Integer = 0 To dtb.Rows.Count - 1

        Dim doclinks As New DocAdjuntoConductor
        doclinks.CBRCNT = dtb.Rows(i).Item("CBRCNT").ToString.Trim
        doclinks.NCRRDC = dtb.Rows(i).Item("NCRRDC").ToString.Trim
        doclinks.NCOIMG = dtb.Rows(i).Item("NCOIMG").ToString.Trim
        doclinks.CTIIMG = dtb.Rows(i).Item("CTIIMG").ToString.Trim
        doclinks.CLINK = dtb.Rows(i).Item("CLINK").ToString.Trim
        doclinks.TOBS = dtb.Rows(i).Item("TOBS").ToString.Trim

        picBox = New MyPictureBox
        picBox.Name = doclinks.NCOIMG
        picBox.BackColor = System.Drawing.Color.White

        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        picBox.Cursor = Cursors.Hand

        picBox.setImage(doclinks.CLINK, NomCarpetaConductor)
        AddHandler picBox.ImagenDoubleClick, AddressOf metalDobleClick
        AddHandler picBox.ImagenClick, AddressOf metalClick
        If doclinks.CTIIMG = "DOC" Then
          picBox.Size = New System.Drawing.Size(50, 50)
          imgPanelDocs.Controls.Add(picBox)
        ElseIf doclinks.CTIIMG = "IMG" Then
          picBox.Size = New System.Drawing.Size(50, 50)
          imgPanelImg.Controls.Add(picBox)
        End If
      Next
      PnlDocs.Controls.Add(imgPanelDocs)
      PnlImg.Controls.Add(imgPanelImg)
    End If
  End Sub
  Private Sub metalDobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Try
      If TypeOf sender Is PictureBox Then
        Dim pb As New MyPictureBox
        pb = sender
        Process.Start(pb.URL)
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub metalClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Try
      If TypeOf sender Is PictureBox Then
        For Each oControldoc As Control In Me.PnlDocs.Controls()
          For Each oControldoc1 As Control In oControldoc.Controls()
            Dim opbx As New PictureBox()
            opbx = CType(oControldoc1, PictureBox)
            opbx.Size = New System.Drawing.Size(50, 50)
          Next
        Next
        Dim pb As New MyPictureBox
        pb = sender
        pb.Size = New System.Drawing.Size(100, 100)
        pb.BackColor = Color.Blue
        _NCOIMG = pb.Name
      End If
    Catch ex As Exception
    End Try
  End Sub

End Class
