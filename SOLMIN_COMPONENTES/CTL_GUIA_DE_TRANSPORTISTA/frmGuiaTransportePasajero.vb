Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
'Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmGuiaTransportePasajero

#Region "Atributos"
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private Objeto_Entidad_Guia As New GuiaTransportista
  Private _ESTADO As Boolean = False
  Private _PLANTA As String = ""
  Private _DIVISION As String = ""
  Private _COMPANIA As String = ""
  Private _TRANSPORTISTA As String = ""
  Private _NOPRCN As Double = 0
  Private _USUARIO As String
  Private _NCSOTR As Double = 0
  Private _NCRRSR As Double = 0
  Private _GUIATRANS As Double = 0
  Private _EstadoRegistro As Integer = 0
  Private _ListaConfiguracion As List(Of ClaseGeneral)
  Private match_Normal As New Predicate(Of ClaseGeneral)(AddressOf Busca_Configuracion)
  Private objGuiaTransporte As New GuiaTransportista
  Private _strEstadoGuiaRemision As Boolean = False
  Private _lintEstado As Int32 = 0
#End Region

#Region "Propiedades"

  'Private Objeto_Entidad_Guia As GuiaTransportista
  Public Property Guia_Transporte() As GuiaTransportista
    Get
      Return Objeto_Entidad_Guia
    End Get
    Set(ByVal value As GuiaTransportista)
      Objeto_Entidad_Guia = value
    End Set
  End Property

  'Private _ESTADO As Boolean
  Public Property ESTADO() As Boolean
    Get
      Return _ESTADO
    End Get
    Set(ByVal value As Boolean)
      _ESTADO = value
    End Set
  End Property

  Public Property MedioTransporte() As Int32
    Get
      Return _lintEstado
    End Get
    Set(ByVal value As Int32)
      _lintEstado = value
    End Set
  End Property


  Public Property NCSOTR() As Double
    Get
      Return _NCSOTR
    End Get
    Set(ByVal value As Double)
      _NCSOTR = value
    End Set
  End Property

  Public Property NCRRSR() As Double
    Get
      Return _NCRRSR
    End Get
    Set(ByVal value As Double)
      _NCRRSR = value
    End Set
  End Property

  Public Property USUARIO() As String
    Get
      Return _USUARIO
    End Get
    Set(ByVal value As String)
      _USUARIO = value
    End Set
  End Property

  Public Property PLANTA() As String
    Get
      Return _PLANTA
    End Get
    Set(ByVal value As String)
      _PLANTA = value
    End Set
  End Property

  Public Property DIVISION() As String
    Get
      Return _DIVISION
    End Get
    Set(ByVal value As String)
      _DIVISION = value
    End Set
  End Property

  Public Property COMPANIA() As String
    Get
      Return _COMPANIA
    End Get
    Set(ByVal value As String)
      _COMPANIA = value
    End Set
  End Property

  Public Property TRANSPORTISTA() As String
    Get
      Return _TRANSPORTISTA
    End Get
    Set(ByVal value As String)
      _TRANSPORTISTA = value
    End Set
  End Property

  Public Property NOPRCN() As Double
    Get
      Return _NOPRCN
    End Get
    Set(ByVal value As Double)
      _NOPRCN = value
    End Set
  End Property

  Public Property EstadoRegistro() As Double
    Get
      Return _EstadoRegistro
    End Get
    Set(ByVal value As Double)
      _EstadoRegistro = value
    End Set
  End Property

  Public ReadOnly Property pGuiaTransporte() As GuiaTransportista
    Get
      Return objGuiaTransporte
    End Get
  End Property

  Public WriteOnly Property EstadoGuiaRemisión() As Boolean
    Set(ByVal value As Boolean)
      _strEstadoGuiaRemision = value
    End Set
    End Property

    Private _PLANTA_DESC As String = ""
    Public Property PLANTA_DESC() As String
        Get
            Return _PLANTA_DESC
        End Get
        Set(ByVal value As String)
            _PLANTA_DESC = value
        End Set
    End Property

#End Region

#Region "Metodos y Funciones"

    Public Sub ChargeForm()
        Try

            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.btnGuardar.Enabled = False
            'Me.dtgGuiaRemision.AutoGenerateColumns = False
            If Objeto_Entidad_Guia.NGUIRM = 0 Then Objeto_Entidad_Guia.NGUIRM = -1
            'MainModule.CargarTablasGlobales(COMPANIA, DIVISION)
            txtPlanta.Text = _PLANTA_DESC
            Me.Cargar_Combos()

            'Seleccionando los valores por defecto
            'Me.cboCompania.Codigo = COMPANIA
            'Me.cboDivision.Codigo = DIVISION
            'Me.cboCodPlanta.Codigo = PLANTA

            'Obteniendo el numero de Guia de Transportista
            Dim objeto_Logica As New GuiaTransportista_BLL

            Dim objeto_Entidad As New OperacionTransporte
            objeto_Entidad.NOPRCN = NOPRCN
            objeto_Entidad.NPLNMT = Objeto_Entidad_Guia.NPLNMT
            objeto_Entidad.CCMPN = COMPANIA ' Me.cboCompania.Codigo
            objeto_Entidad.CDVSN = DIVISION 'Me.cboDivision.Codigo
            objeto_Entidad.CPLNDV = PLANTA 'CType(Me.cboCodPlanta.Codigo, Double)
            'Objeto_Entidad_Guia.NPLNMT = objeto_Logica.Verificacion_Existencia_Operacion_Transporte(objeto_Entidad).NPLNMT


            If _ESTADO = True Then
                gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                Me.btnGuardar.Enabled = _ESTADO
                'Me.txtTransportista.Text = objeto_Logica.Obtener_RUC_Transportista(Objeto_Entidad_Guia.CTRMNC, COMPANIA)
                'Me.txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM

                Dim objetoParametro As New Hashtable
                Dim obeGuiaTransporte As New GuiaTransportista
                objetoParametro.Add("PNCTRMNC", Objeto_Entidad_Guia.CTRMNC)
                objetoParametro.Add("PNNGUITR", Objeto_Entidad_Guia.NGUIRM)
                objetoParametro.Add("PNNOPRCN", Objeto_Entidad_Guia.NOPRCN)
                objetoParametro.Add("PSCCMPN", COMPANIA)
                objetoParametro.Add("PSCDVSN", DIVISION)
                obeGuiaTransporte = objeto_Logica.Get_Guia_Transportista(objetoParametro)
                Objeto_Entidad_Guia.CCLNT = obeGuiaTransporte.CCLNT
                Objeto_Entidad_Guia.FGUIRM_S = obeGuiaTransporte.FGUIRM_S
                Objeto_Entidad_Guia.NPLNMT = obeGuiaTransporte.NPLNMT
                Objeto_Entidad_Guia.CLCLOR = obeGuiaTransporte.CLCLOR
                Objeto_Entidad_Guia.CLCLDS = obeGuiaTransporte.CLCLDS
                Objeto_Entidad_Guia.TDIROR = obeGuiaTransporte.TDIROR
                Objeto_Entidad_Guia.TDIRDS = obeGuiaTransporte.TDIRDS
                Objeto_Entidad_Guia.NOPRCN = obeGuiaTransporte.NOPRCN
                Objeto_Entidad_Guia.CUBORI = obeGuiaTransporte.CUBORI
                Objeto_Entidad_Guia.CUBDES = obeGuiaTransporte.CUBDES
                Objeto_Entidad_Guia.QMRCMC = obeGuiaTransporte.QMRCMC
                Objeto_Entidad_Guia.PMRCMC = obeGuiaTransporte.PMRCMC
                Objeto_Entidad_Guia.CUNDMD = obeGuiaTransporte.CUNDMD
                Objeto_Entidad_Guia.QGLGSL = obeGuiaTransporte.QGLGSL
                Objeto_Entidad_Guia.QGLDSL = obeGuiaTransporte.QGLDSL
                Objeto_Entidad_Guia.NRHJCR = obeGuiaTransporte.NRHJCR
                Objeto_Entidad_Guia.CTRSPT = obeGuiaTransporte.CTRSPT
                Objeto_Entidad_Guia.NPLCTR = obeGuiaTransporte.NPLCTR
                Objeto_Entidad_Guia.NPLCAC = obeGuiaTransporte.NPLCAC
                Objeto_Entidad_Guia.CBRCNT = obeGuiaTransporte.CBRCNT
                Objeto_Entidad_Guia.TNMBRM = obeGuiaTransporte.TNMBRM
                Objeto_Entidad_Guia.TDRCRM = obeGuiaTransporte.TDRCRM
                Objeto_Entidad_Guia.TPDCIR = obeGuiaTransporte.TPDCIR
                Objeto_Entidad_Guia.NRUCRM = obeGuiaTransporte.NRUCRM
                Objeto_Entidad_Guia.TNMBCN = obeGuiaTransporte.TNMBCN
                Objeto_Entidad_Guia.TDRCNS = obeGuiaTransporte.TDRCNS
                Objeto_Entidad_Guia.TPDCIC = obeGuiaTransporte.TPDCIC
                Objeto_Entidad_Guia.NRUCCN = obeGuiaTransporte.NRUCCN
                Objeto_Entidad_Guia.SACRGO = obeGuiaTransporte.SACRGO
                Objeto_Entidad_Guia.CMNFLT = obeGuiaTransporte.CMNFLT
                Objeto_Entidad_Guia.FLGADC = obeGuiaTransporte.FLGADC
                Objeto_Entidad_Guia.SIDAVL = obeGuiaTransporte.SIDAVL
                Objeto_Entidad_Guia.QKMREC = obeGuiaTransporte.QKMREC
                Objeto_Entidad_Guia.ICSTRM = obeGuiaTransporte.ICSTRM
                Objeto_Entidad_Guia.QPSOBR = obeGuiaTransporte.QPSOBR
                Objeto_Entidad_Guia.QVLMOR = obeGuiaTransporte.QVLMOR
                Objeto_Entidad_Guia.SMRPLG = obeGuiaTransporte.SMRPLG
                Objeto_Entidad_Guia.SMRPRC = obeGuiaTransporte.SMRPRC
                Objeto_Entidad_Guia.IVLPRT = obeGuiaTransporte.IVLPRT
                Objeto_Entidad_Guia.CMNVLP = obeGuiaTransporte.CMNVLP
                Objeto_Entidad_Guia.CCMPN = obeGuiaTransporte.CCMPN
                Objeto_Entidad_Guia.CDVSN = obeGuiaTransporte.CDVSN
                Objeto_Entidad_Guia.CPLNDV = obeGuiaTransporte.CPLNDV
                Objeto_Entidad_Guia.FEMVLH = obeGuiaTransporte.FEMVLH
                Objeto_Entidad_Guia.FEMVLH_S = obeGuiaTransporte.FEMVLH_S
                Objeto_Entidad_Guia.FECETD_S = obeGuiaTransporte.FECETD_S
                Objeto_Entidad_Guia.FECETA_S = obeGuiaTransporte.FECETA_S
                Objeto_Entidad_Guia.CBRCND = obeGuiaTransporte.CBRCND
                Objeto_Entidad_Guia.TOBS = obeGuiaTransporte.TOBS
                Objeto_Entidad_Guia.TRFRGU = obeGuiaTransporte.TRFRGU
                Objeto_Entidad_Guia.TCNFVH = obeGuiaTransporte.TCNFVH
                Objeto_Entidad_Guia.NOREMB = obeGuiaTransporte.NOREMB
                Objeto_Entidad_Guia.NMOPRP = obeGuiaTransporte.NMOPRP
                Objeto_Entidad_Guia.NMOPMM = obeGuiaTransporte.NMOPMM
                Objeto_Entidad_Guia.NMVJCS = obeGuiaTransporte.NMVJCS
                Objeto_Entidad_Guia.TCMTRT = obeGuiaTransporte.TCMTRT
                Objeto_Entidad_Guia.NRUCTR = obeGuiaTransporte.NRUCTR
                Objeto_Entidad_Guia.HRAINI = obeGuiaTransporte.HRAINI
                Objeto_Entidad_Guia.HRAFIN = obeGuiaTransporte.HRAFIN
                Objeto_Entidad_Guia.CMEDTR = obeGuiaTransporte.CMEDTR
                Objeto_Entidad_Guia.TCMLCO = obeGuiaTransporte.TCMLCO
                Objeto_Entidad_Guia.TCMLCD = obeGuiaTransporte.TCMLCD
                Objeto_Entidad_Guia.CMNFLTDESC = obeGuiaTransporte.CMNFLTDESC
                Objeto_Entidad_Guia.CUNDMD_DESC = obeGuiaTransporte.CUNDMD_DESC
                Objeto_Entidad_Guia.HRAINI = obeGuiaTransporte.HRAINI.PadLeft(6, "0")
                'recordando los 4 primeros
                Objeto_Entidad_Guia.HRAINI = Objeto_Entidad_Guia.HRAINI.Substring(0, 4)
                txtTransportista.Text = Objeto_Entidad_Guia.NRUCTR & " - " & Objeto_Entidad_Guia.TCMTRT
                txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM


                Me.Estado_Controles(_ESTADO)
                Me.TabMantenimiento.Enabled = _ESTADO
                'Me.HGGuiaRemision.Enabled = _ESTADO
                Me.checkGenerar.Enabled = False
                Me.Listar_Pasajeros_Registrados()
                ' Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
                'Me.Listar_Guias_Transportista_Registradas()
            Else
                gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
                Dim objetoEntidad As New GuiaTransportista
                objetoEntidad.CCMPN = COMPANIA 'Me.cboCompania.Codigo
                objetoEntidad.CDVSN = DIVISION ' Me.cboDivision.Codigo
                objetoEntidad.CPLNDV = PLANTA
                objetoEntidad.NGUIRM = 0
                Me._GUIATRANS = objeto_Logica.Obtener_Numero_Guia_Transporte(objetoEntidad).NGUIRM
                'Me.txtNroRemision.Text = 175
                'If CType(Me.txtNroRemision.Text.Trim.Substring(0, 3), Integer) = 139 Then
                '    Me.checkGenerar.Checked = True
                'Else
                '    Me.checkGenerar.Checked = False
                'End If
                'Objeto_Entidad_Guia.CTRMNC = objeto_Logica.Obtener_Codigo_Transportista(Objeto_Entidad_Guia.NRUCTR, Me.COMPANIA)
                'Me.txtTransportista.Text = objeto_Logica.Obtener_RUC_Transportista(Objeto_Entidad_Guia.CTRMNC, _COMPANIA)


                Dim objGTAdicional As New GuiaTransportista
                Dim objGTFiltro As New GuiaTransportista
                objGTFiltro.NOPRCN = Me.NOPRCN
                objGTFiltro.CCMPN = COMPANIA
                objGTAdicional = objeto_Logica.Obtener_Informacion_OS(objGTFiltro)
                Objeto_Entidad_Guia.NPLNMT = objGTAdicional.NPLNMT
                Objeto_Entidad_Guia.CMNFLT = objGTAdicional.CMNFLT
                Objeto_Entidad_Guia.QKMREC = objGTAdicional.QKMREC
                Objeto_Entidad_Guia.TNMBRM = objGTAdicional.TNMBRM
                Objeto_Entidad_Guia.TDRCRM = objGTAdicional.TDRCRM
                Objeto_Entidad_Guia.TPDCIR = objGTAdicional.TPDCIR
                Objeto_Entidad_Guia.NRUCRM = objGTAdicional.NRUCRM
                Objeto_Entidad_Guia.TNMBCN = objGTAdicional.TNMBCN
                Objeto_Entidad_Guia.TPDCIC = objGTAdicional.TPDCIR
                Objeto_Entidad_Guia.NRUCCN = objGTAdicional.NRUCCN
                Objeto_Entidad_Guia.TCNFVH = objGTAdicional.TCNFVH
                Objeto_Entidad_Guia.CUBORI = objGTAdicional.CUBORI
                Objeto_Entidad_Guia.CUBDES = objGTAdicional.CUBDES
                Objeto_Entidad_Guia.CMNFLTDESC = objGTAdicional.CMNFLTDESC
                Objeto_Entidad_Guia.CUNDMD = objGTAdicional.CUNDMD
                Objeto_Entidad_Guia.CUNDMD_DESC = objGTAdicional.CUNDMD_DESC
                Objeto_Entidad_Guia.TCMTRT = objGTAdicional.TCMTRT
                Objeto_Entidad_Guia.CTRMNC = objGTAdicional.CTRMNC
                Objeto_Entidad_Guia.CCLNT = objGTAdicional.CCLNT
                Objeto_Entidad_Guia.CLCLOR = objGTAdicional.CLCLOR
                Objeto_Entidad_Guia.CLCLDS = objGTAdicional.CLCLDS
                Objeto_Entidad_Guia.TDIROR = objGTAdicional.TDIROR
                Objeto_Entidad_Guia.TDIRDS = objGTAdicional.TDIRDS
                Objeto_Entidad_Guia.CMEDTR = objGTAdicional.CMEDTR
                Objeto_Entidad_Guia.TDRCNS = Objeto_Entidad_Guia.TDIRDS
                Objeto_Entidad_Guia.QMRCMC = objGTAdicional.QMRCMC
                Objeto_Entidad_Guia.CTPOVJ = objGTAdicional.CTPOVJ

                txtTransportista.Text = Objeto_Entidad_Guia.NRUCTR & " - " & Objeto_Entidad_Guia.TCMTRT

                Me.btnGuardar.Enabled = Not _ESTADO
                Me.TabMantenimiento.Enabled = _ESTADO
                'Me.HGGuiaRemision.Enabled = _ESTADO
                Me.btnImprimir.Enabled = _ESTADO
            End If

            Me.Asignar_Valores()
            Me.Cargar_Lista_Configuracion_Vehicular()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Me.Actualizar_Informacion(Me._strEstadoGuiaRemision)
        'Asignando valores



    End Sub

  'Private Sub Actualizar_Informacion(ByVal bolEstado As Boolean)
  '  Select Case bolEstado
  '    Case True
  '      Me.lblGuiaRemision.Text = "Guía Remisión"
  '      Me.checkGenerar.Visible = False
  '      Me.lblGuiaTransporte.Visible = True
  '      Me.txtGuiaTransporte.Visible = True
  '  End Select
  'End Sub

  Private Sub Asignar_Valores()
        'Try
        Me.txtNroPlaneamiento.Text = Objeto_Entidad_Guia.NPLNMT
        Me.txtNroOperacion.Text = NOPRCN
        If _ESTADO = False Then
            Me.dtpFecGuia.Value = Date.Today
            Me.dtpFecGuiaETD.Value = Date.Today
            Me.dtpFecGuiaETA.Value = Date.Today
            Me.dtpFecIniTrans.Value = Date.Today
            Me.dtpFecGuiaETA.Checked = False
        Else
            Me.dtpFecGuia.Value = CType(Objeto_Entidad_Guia.FGUIRM_S, Date)
            Me.dtpFecIniTrans.Value = HelpClass.CNumero_a_Fecha(Objeto_Entidad_Guia.FEMVLH)
            Me.dtpFecGuiaETD.Value = CType(Objeto_Entidad_Guia.FECETD_S, Date)
            If Objeto_Entidad_Guia.FECETA_S = "00/00/0000" OrElse Objeto_Entidad_Guia.FECETA_S = "" Then
                Me.dtpFecGuiaETA.Checked = False
            Else
                Me.dtpFecGuiaETA.Checked = True
                Me.dtpFecGuiaETA.Value = CType(Objeto_Entidad_Guia.FECETA_S, Date)
            End If
            Me.txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM
        End If
        Me.cboLugarOrigen.Codigo = Objeto_Entidad_Guia.CLCLOR
        Me.txtLugar.Text = Me.cboLugarOrigen.Descripcion
        Me.cboLugarDestino.Codigo = Objeto_Entidad_Guia.CLCLDS
        If Objeto_Entidad_Guia.TDIROR.Length > Me.txtDirOrigen.MaxLength Then
            Me.txtDirOrigen.Text = Objeto_Entidad_Guia.TDIROR.Substring(0, Me.txtDirOrigen.MaxLength)
        Else
            Me.txtDirOrigen.Text = Objeto_Entidad_Guia.TDIROR
        End If
        If Objeto_Entidad_Guia.TDIRDS.Length > Me.txtDirDestino.MaxLength Then
            Me.txtDirDestino.Text = Objeto_Entidad_Guia.TDIRDS.Substring(0, Me.txtDirDestino.MaxLength)
        Else
            Me.txtDirDestino.Text = Objeto_Entidad_Guia.TDIRDS
        End If
        Me.cboOrigenUbigeo.Codigo = Objeto_Entidad_Guia.CUBORI
        Me.cboDestinoUbigeo.Codigo = Objeto_Entidad_Guia.CUBDES
        Me.txtCantMercaderia.Text = Objeto_Entidad_Guia.QMRCMC
        'Me.cboUnidadMedida.Codigo = Objeto_Entidad_Guia.CUNDMD
        txtUnidadMed.Text = Objeto_Entidad_Guia.CUNDMD_DESC

        Me.txtGalsGasolina.Text = Objeto_Entidad_Guia.QGLGSL
        Me.txtGalsDiesel.Text = Objeto_Entidad_Guia.QGLDSL
        Me.txtNroHojaGuia.Text = Objeto_Entidad_Guia.NRHJCR
        Me.txtPesoMercaderia.Text = Objeto_Entidad_Guia.PMRCMC
        Me.txtPesoBruto.Text = Objeto_Entidad_Guia.QPSOBR

        Me.txtTracto.Text = Objeto_Entidad_Guia.NPLCTR
        Me.txtAcoplado.Text = Objeto_Entidad_Guia.NPLCAC
        Me.txtConductor.Text = Objeto_Entidad_Guia.CBRCNT + " - " + Objeto_Entidad_Guia.CBRCND
        Me.txtConfigTracto.Text = Objeto_Entidad_Guia.TCNFVH

        Me.rbtnRemitente.Checked = IIf(Objeto_Entidad_Guia.SACRGO = "R", True, False)
        Me.rbtnDestinatario.Checked = IIf(Objeto_Entidad_Guia.SACRGO = "R", False, True)
        'Me.cboMonedaFlete.Codigo = Objeto_Entidad_Guia.CMNFLT
        Me.rbtnIda.Checked = IIf(Objeto_Entidad_Guia.SIDAVL = "I", True, False)
        Me.rbtnIdaVuelta.Checked = IIf(Objeto_Entidad_Guia.SIDAVL = "I", False, True)
        Me.chkMercPerecible.Checked = IIf(Objeto_Entidad_Guia.SMRPRC = "X", True, False)
        Me.chkMercPeligrosa.Checked = IIf(Objeto_Entidad_Guia.SMRPLG = "X", True, False)
        Me.txtVolumenRemision.Text = Objeto_Entidad_Guia.QVLMOR
        Me.txtValorPatrimonio.Text = Objeto_Entidad_Guia.IVLPRT
        Me.cboMonedaValorPatr.Codigo = Objeto_Entidad_Guia.CMNVLP
        Me.txtKmPorRecorrer.Text = Objeto_Entidad_Guia.QKMREC
        Me.txtCostoTramo.Text = Objeto_Entidad_Guia.ICSTRM

        'Me.UcCNomRemitente.pUsuario = USUARIO
        Me.UcCNomRemitente.CCMPN = _COMPANIA
        Me.UcCNomRemitente.pCargar(Objeto_Entidad_Guia.CCLNT)
        '-----------------------------------------------------------
        If Objeto_Entidad_Guia.TDRCRM.Length > Me.txtDirRemitente.MaxLength Then
            Me.txtDirRemitente.Text = Objeto_Entidad_Guia.TDRCRM.Substring(0, Me.txtDirRemitente.MaxLength)
        Else
            Me.txtDirRemitente.Text = Objeto_Entidad_Guia.TDRCRM
        End If
        Me.rbtnDNIRemit.Checked = IIf(Objeto_Entidad_Guia.TPDCIR = "R", False, True)
        Me.rbtnRUCRemit.Checked = IIf(Objeto_Entidad_Guia.TPDCIR = "R", True, False)
        Me.txtNroDocRemitente.Text = Objeto_Entidad_Guia.NRUCRM

        If _ESTADO = True Then
            Me.chkCliente.Checked = True
            Me.chkCliente.Visible = False
            Me.UcCNomConsignatario.Visible = False
            Me.txtNomConsignatario.Visible = True
            Me.txtNomConsignatario.Text = Objeto_Entidad_Guia.TNMBCN
            Me.txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS
            Me.rbtnDNIConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", False, True)
            Me.rbtnRUCConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", True, False)
            Me.txtNroDocConsignatario.Text = Objeto_Entidad_Guia.NRUCCN
        Else
            'Me.UcCNomConsignatario.pUsuario = USUARIO
            Me.UcCNomConsignatario.CCMPN = _COMPANIA
            Me.UcCNomConsignatario.pCargar(Objeto_Entidad_Guia.CCLNT)
            If Objeto_Entidad_Guia.TDRCNS.Length > Me.txtDirConsignatario.MaxLength Then
                Me.txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS.Substring(0, Me.txtDirConsignatario.MaxLength)
            Else
                Me.txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS
            End If
            Me.rbtnDNIConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", False, True)
            Me.rbtnRUCConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", True, False)
            Me.txtNroDocConsignatario.Text = Objeto_Entidad_Guia.NRUCCN

        End If

        'If _ESTADO = False Then
        '  Me.dtpFecGuia.Value = Date.Today
        'Else
        '   Me.dtpFecIniTrans.Value = HelpClass.CNumero_a_Fecha(Objeto_Entidad_Guia.FEMVLH)
        'End If
        Me.txtObservación.Text = Objeto_Entidad_Guia.TOBS
        Me.txtOrdenEmbarcador.Text = Objeto_Entidad_Guia.NOREMB

        txtMonFlete.Text = Objeto_Entidad_Guia.CMNFLTDESC

        '-----------------------------------------------------------
        'Me.UcCliente.CCMPN = _COMPANIA
        'Me.UcCliente.pCargar(Objeto_Entidad_Guia.CCLNT)
        'Me.UcCliente_GuiaRemision.CCMPN = _COMPANIA
        'Me.UcCliente_GuiaRemision.pCargar(Objeto_Entidad_Guia.CCLNT)
        'Catch : End Try

  End Sub

  Private Sub Cargar_Combos()
        'Try
        Dim obj_Logica_Unidad As New UnidadMedida_BLL
        Dim obj_Logica_Localidad As New Localidad_BLL
        Dim obj_Logica_Ubigeo As New LocalidadRuta_BLL

        'With Me.cboCompania
        '    .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("COMPANIA"), DataTable).Copy()
        '    .KeyField = "CCMPN"
        '    .ValueField = "TCMPCM"
        '    .DataBind()
        'End With

        'With Me.cboDivision
        '    .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("DIVISION"), DataTable).Copy()
        '    .KeyField = "CDVSN"
        '    .ValueField = "TCMPDV"
        '    .DataBind()
        'End With

        'With Me.cboCodPlanta
        '    .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("PLANTA"), DataTable).Copy()
        '    .KeyField = "CPLNDV"
        '    .ValueField = "TPLNTA"
        '    .DataBind()
        'End With
        Dim objDt As DataTable
        objDt = obj_Logica_Localidad.Listar_Localidades_Combo(COMPANIA)
        With Me.cboLugarOrigen
            .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With

        With Me.cboLugarDestino
            .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        objDt = New DataTable
        objDt = obj_Logica_Ubigeo.Listar_Ubigeo(COMPANIA)
        With Me.cboOrigenUbigeo
            .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("UBIGEO"), DataTable).Copy()
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With

        With Me.cboDestinoUbigeo
            .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("UBIGEO"), DataTable).Copy()
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With

        'With Me.cboUnidadMedida
        '    .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(COMPANIA) 'CType(MainModule.gobj_TablasGeneralesdelSistema("UNIDAD"), DataTable)
        '    .KeyField = "CUNDMD"
        '    .ValueField = "TCMPUN"
        '    .DataBind()
        'End With

        'Dim objLogicaGuia As New GuiaTransportista_BLL
        'With Me.cboMonedaFlete
        '    .DataSource = objLogicaGuia.Listar_Moneda(COMPANIA)
        '    .KeyField = "CMNDA1"
        '    .ValueField = "TMNDA"
        '    .DataBind()
        'End With

        'With Me.cboMonedaValorPatr
        '    .DataSource = objLogicaGuia.Listar_Moneda(COMPANIA)
        '    .KeyField = "CMNDA1"
        '    .ValueField = "TMNDA"
        '    .DataBind()
        'End With

        'Catch ex As Exception
        '    End Try
  End Sub

    Private Sub Estado_Controles(ByVal lbol_Estado As Boolean)
        If _ESTADO = True Then
            'Me.dtpFecGuia.Enabled = False
            Me.txtNroRemision.Enabled = False
        Else
            Me.dtpFecGuia.Enabled = lbol_Estado
            Me.txtNroRemision.Enabled = lbol_Estado
        End If
        Me.cboOrigenUbigeo.Enabled = lbol_Estado
        Me.cboDestinoUbigeo.Enabled = lbol_Estado
        Me.txtCantMercaderia.Enabled = lbol_Estado
        'Me.cboUnidadMedida.Enabled = lbol_Estado
        Me.txtGalsGasolina.Enabled = lbol_Estado
        Me.txtGalsDiesel.Enabled = lbol_Estado
        Me.txtNroHojaGuia.Enabled = lbol_Estado
        Me.txtPesoMercaderia.Enabled = lbol_Estado
        Me.txtPesoBruto.Enabled = lbol_Estado
        Me.rbtnRemitente.Enabled = lbol_Estado
        Me.rbtnDestinatario.Enabled = lbol_Estado
        'Me.cboMonedaFlete.Enabled = lbol_Estado
        Me.rbtnIda.Enabled = lbol_Estado
        Me.rbtnIdaVuelta.Enabled = lbol_Estado
        Me.chkMercPerecible.Enabled = lbol_Estado
        Me.chkMercPeligrosa.Enabled = lbol_Estado
        Me.txtVolumenRemision.Enabled = lbol_Estado
        Me.txtValorPatrimonio.Enabled = lbol_Estado
        Me.cboMonedaValorPatr.Enabled = lbol_Estado
        Me.txtKmPorRecorrer.Enabled = lbol_Estado
        Me.txtCostoTramo.Enabled = lbol_Estado
        Me.UcCNomRemitente.Enabled = lbol_Estado
        Me.txtDirRemitente.Enabled = lbol_Estado
        Me.rbtnDNIRemit.Enabled = lbol_Estado
        Me.rbtnRUCRemit.Enabled = lbol_Estado
        Me.txtNroDocRemitente.Enabled = lbol_Estado
        Me.UcCNomConsignatario.Enabled = lbol_Estado
        Me.txtDirConsignatario.Enabled = lbol_Estado
        Me.rbtnDNIConsignatario.Enabled = lbol_Estado
        Me.rbtnRUCConsignatario.Enabled = lbol_Estado
        Me.txtNroDocConsignatario.Enabled = lbol_Estado
        Me.txtObservación.Enabled = lbol_Estado
        Me.txtDirOrigen.Enabled = lbol_Estado
        Me.txtDirDestino.Enabled = lbol_Estado
        Me.txtConfigTracto.Enabled = lbol_Estado
        Me.btnConfigTracto.Enabled = lbol_Estado
        Me.txtOrdenEmbarcador.Enabled = lbol_Estado
    End Sub

  Private Function Validar_Inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    If Me.txtNroPlaneamiento.Text = 0 Then
      lstr_validacion += "* NRO PLANEAMIENTO " & Chr(13)
    End If

    'If Me._strEstadoGuiaRemision = True Then
    '  If Me.txtNroRemision.TextLength = 0 OrElse Me.txtNroRemision.TextLength < 10 Then
    '    lstr_validacion += "* GUIA REMISION " & Chr(13)
    '  End If
    '  If Me.txtGuiaTransporte.TextLength = 0 OrElse Me.txtGuiaTransporte.TextLength < 10 Then
    '    lstr_validacion += "* GUIA TRANSPORTISTA " & Chr(13)
    '  End If
    'Else
        If Val(txtNroRemision.Text.Trim) = 0 OrElse Me.txtNroRemision.TextLength < 8 Then
            Dim strLonCad As Int64 = CLng(Me.txtNroRemision.Text).ToString.Length
            If strLonCad < 8 Then lstr_validacion += "* GUIA TRANSPORTISTA " & Chr(13)
        End If
    'End If

    If Me.cboLugarOrigen.Codigo = "0" OrElse Me.cboLugarOrigen.Codigo = "" Then
      lstr_validacion += "* LUGAR ORIGEN " & Chr(13)
    End If

    If Me.cboLugarDestino.Codigo = "0" OrElse Me.cboLugarDestino.Codigo = "" Then
      lstr_validacion += "* LUGAR DESTINO " & Chr(13)
    End If

    If Me.txtDirOrigen.TextLength = 0 Then
      lstr_validacion += "* DIRECCION ORIGEN " & Chr(13)
    End If

    If Me.txtDirDestino.TextLength = 0 Then
      lstr_validacion += "* DIRECCION DESTINO " & Chr(13)
    End If

    If Me.cboOrigenUbigeo.Codigo = "0" OrElse Me.cboOrigenUbigeo.Codigo = "" Then
      lstr_validacion += "* ORIGEN UBIGEO " & Chr(13)
    End If

    If Me.cboDestinoUbigeo.Codigo = "0" OrElse Me.cboDestinoUbigeo.Codigo = "" Then
      lstr_validacion += "* DESTINO UBIGEO " & Chr(13)
    End If

    If Me.txtCantMercaderia.TextLength = 0 OrElse Me.txtCantMercaderia.Text = "0" Then
      lstr_validacion += "* CANTIDAD MERCADERIA " & Chr(13)
    End If

    If Me.txtPesoMercaderia.TextLength = 0 OrElse Me.txtPesoMercaderia.Text = "0" Then
      lstr_validacion += "* PESO NETO " & Chr(13)
    End If

    If Objeto_Entidad_Guia.CTRMNC = 0 Then
      lstr_validacion += "* TRANSPORTISTA " & Chr(13)
    End If

    If Objeto_Entidad_Guia.NPLCTR = "" Then
      lstr_validacion += "* TRACTO " & Chr(13)
    End If
    Select Case MedioTransporte
      Case 4
        If Objeto_Entidad_Guia.CBRCNT = "" Then
          lstr_validacion += "* BREVETE " & Chr(13)
        End If
    End Select

    If Me._ListaConfiguracion.FindAll(match_Normal).Count = 0 Then
      lstr_validacion += "* NO EXISTE CONFIGURACION" & Chr(13)
    End If

        'If Me.cboMonedaFlete.NoHayCodigo = True Then
        '  lstr_validacion += "* TIPO MONEDA " & Chr(13)
        'End If

    If Me.txtKmPorRecorrer.TextLength = 0 OrElse Me.txtKmPorRecorrer.Text = "0" Then
      lstr_validacion += "* KM x RECORRER " & Chr(13)
    End If

    If Me.UcCNomRemitente.pCodigo = 0 Then
      lstr_validacion += "* NOMBRE REMITENTE" & Chr(13)
    End If

    If Me.txtDirRemitente.TextLength = 0 Then
      lstr_validacion += "* DIRECCIÓN REMITENTE" & Chr(13)
    End If

    If Me.txtNroDocRemitente.TextLength = 0 OrElse Me.txtNroDocRemitente.Text = "0" Then
      lstr_validacion += "* N° DOCUMENTO REMITENTE" & Chr(13)
    End If

    If Me.chkCliente.Checked = False Then
      If Me.UcCNomConsignatario.pCodigo = 0 Then
        lstr_validacion += "* NOMBRE CONSIGNATARIO" & Chr(13)
      End If
    Else
      If Me.txtNomConsignatario.Text.Trim.Length = 0 Then
        lstr_validacion += "* NOMBRE CONSIGNATARIO" & Chr(13)
      End If
    End If

    If Me.txtDirConsignatario.TextLength = 0 Then
      lstr_validacion += "* DIRECCIÓN CONSIGNATARIO" & Chr(13)
    End If

    If Me.txtNroDocConsignatario.TextLength = 0 OrElse Me.txtNroDocConsignatario.Text = 0 Then
      lstr_validacion += "* N° DOCUMENTO CONSIGNATARIO" & Chr(13)
    End If

    If Me.dtpFecGuiaETA.Checked = True Then

      If HelpClass.CtypeDate(Me.dtpFecGuiaETD.Value) > HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value) Then
        lstr_validacion += "* FECHA ESTIMADA DE SALIDA MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
      End If

      If HelpClass.CtypeDate(Me.dtpFecIniTrans.Value) > HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value) Then
        lstr_validacion += "* FECHA TRASLADO MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
      End If
    End If

    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
      lbool_existe_error = True
    End If

    Return lbool_existe_error
  End Function

  Private Sub Nuevo_Registro()
    Dim obj_Entidad As New GuiaTransportista
    Dim obj_Logica As New GuiaTransportista_BLL
        'Try
        obj_Entidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
        obj_Entidad.FGUIRM = HelpClass.CtypeDate(Me.dtpFecGuia.Value)
        obj_Entidad.NPLNMT = Objeto_Entidad_Guia.NPLNMT
        obj_Entidad.CLCLOR = Objeto_Entidad_Guia.CLCLOR
        obj_Entidad.CLCLDS = Objeto_Entidad_Guia.CLCLDS
        obj_Entidad.TCMLCO = Me.cboLugarOrigen.Descripcion
        obj_Entidad.TCMLCD = Me.cboLugarDestino.Descripcion
        obj_Entidad.TRFRGU = Me.txtLugar.Text
        obj_Entidad.TDIROR = Me.txtDirOrigen.Text
        obj_Entidad.TDIRDS = Me.txtDirDestino.Text
        obj_Entidad.NOPRCN = CType(Me.txtNroOperacion.Text, Double)
        obj_Entidad.QMRCMC = Me.txtCantMercaderia.Text
        obj_Entidad.PMRCMC = Me.txtPesoMercaderia.Text
        'obj_Entidad.CUNDMD = Me.cboUnidadMedida.Codigo
        obj_Entidad.CUNDMD = Objeto_Entidad_Guia.CUNDMD
        If Me.txtGalsGasolina.Text.Trim <> "" Then obj_Entidad.QGLGSL = Me.txtGalsGasolina.Text
        If Me.txtGalsDiesel.Text.Trim <> "" Then obj_Entidad.QGLDSL = Me.txtGalsDiesel.Text
        If Me.txtNroHojaGuia.Text.Trim <> "" Then obj_Entidad.NRHJCR = Me.txtNroHojaGuia.Text.Trim
        obj_Entidad.CTRSPT = Objeto_Entidad_Guia.CTRMNC
        obj_Entidad.NPLCTR = Objeto_Entidad_Guia.NPLCTR
        obj_Entidad.NPLCAC = Objeto_Entidad_Guia.NPLCAC
        obj_Entidad.CBRCNT = Objeto_Entidad_Guia.CBRCNT
        obj_Entidad.TNMBRM = Me.UcCNomRemitente.pRazonSocial
        obj_Entidad.TDRCRM = Me.txtDirRemitente.Text
        obj_Entidad.TPDCIR = IIf(Me.rbtnDNIRemit.Checked = True, "D", "R")
        'obj_Entidad.NRUCRM = CType(Me.txtNroDocRemitente.Text, Double)
        If Me.txtNroDocRemitente.Text.Trim <> "" Then obj_Entidad.NRUCRM = CType(Me.txtNroDocRemitente.Text, Double)
        obj_Entidad.TNMBCN = IIf(Me.chkCliente.Checked = True, Me.txtNomConsignatario.Text, Me.UcCNomConsignatario.pRazonSocial)
        obj_Entidad.TDRCNS = Me.txtDirConsignatario.Text
        obj_Entidad.TPDCIC = IIf(Me.rbtnDNIConsignatario.Checked = True, "D", "R")
        If Me.txtNroDocConsignatario.Text.Trim <> "" Then obj_Entidad.NRUCCN = CType(Me.txtNroDocConsignatario.Text, Double)
        obj_Entidad.SACRGO = IIf(Me.rbtnRemitente.Checked = True, "R", "D")
        'If Me.cboMonedaFlete.NoHayCodigo = False Then obj_Entidad.CMNFLT = CType(Me.cboMonedaFlete.Codigo, Double)
        obj_Entidad.CMNFLT = Objeto_Entidad_Guia.CMNFLT
        obj_Entidad.SESTRG = "A"
        obj_Entidad.SIDAVL = IIf(Me.rbtnIda.Checked = True, "I", "V")
        If Me.txtKmPorRecorrer.Text.Trim <> "" Then obj_Entidad.QKMREC = CType(Me.txtKmPorRecorrer.Text, Double)
        If Me.txtCostoTramo.Text.Trim <> "" Then obj_Entidad.ICSTRM = CType(Me.txtCostoTramo.Text, Double)
        If Me.txtPesoBruto.Text.Trim <> "" Then obj_Entidad.QPSOBR = CType(Me.txtPesoBruto.Text, Double)
        If Me.txtVolumenRemision.Text.Trim <> "" Then obj_Entidad.QVLMOR = CType(Me.txtVolumenRemision.Text, Double)
        obj_Entidad.SMRPLG = IIf(Me.chkMercPeligrosa.Checked = True, "X", "")
        obj_Entidad.SMRPRC = IIf(Me.chkMercPerecible.Checked = True, "X", "")
        If Me.txtValorPatrimonio.Text.Trim <> "" Then obj_Entidad.IVLPRT = CType(Me.txtValorPatrimonio.Text, Double)
        If Me.cboMonedaValorPatr.NoHayCodigo = False Then obj_Entidad.CMNVLP = CType(Me.cboMonedaValorPatr.Codigo, Double)
        obj_Entidad.CCMPN = COMPANIA 'Me.cboCompania.Codigo
        obj_Entidad.CDVSN = DIVISION  ' Me.cboDivision.Codigo
        obj_Entidad.CPLNDV = PLANTA  ' CType(Me.cboCodPlanta.Codigo, Double)
        obj_Entidad.CULUSA = USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = ""
        obj_Entidad.CUBORI = CType(Me.cboOrigenUbigeo.Codigo, Double)
        obj_Entidad.CUBDES = CType(Me.cboDestinoUbigeo.Codigo, Double)
        obj_Entidad.FEMVLH = HelpClass.CtypeDate(Me.dtpFecIniTrans.Value)
        obj_Entidad.FECETD = HelpClass.CtypeDate(Me.dtpFecGuiaETD.Value)
        obj_Entidad.FECETA = IIf(Me.dtpFecGuiaETA.Checked = True, HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value), 0)
        obj_Entidad.TOBS = Me.txtObservación.Text
        obj_Entidad.TCNFVH = Me.txtConfigTracto.Text.Trim
        obj_Entidad.NOREMB = Me.txtOrdenEmbarcador.Text.Trim
        obj_Entidad.CTPOVJ = "P"
        'If Me._strEstadoGuiaRemision = True Then
        '  obj_Entidad.NGUIRM = Me.txtGuiaTransporte.Text
        '  obj_Entidad.NMGUIR = Me.txtNroRemision.Text
        'Else
        obj_Entidad.NGUIRM = Me.txtNroRemision.Text
        'End If
        objGuiaTransporte = obj_Entidad

        If _ESTADO = False Then
            If Me.checkGenerar.Checked = False Then
                Objeto_Entidad_Guia.NGUIRM = obj_Logica.Registrar_Guia_Transportista_Manual(obj_Entidad).NGUIRM
                If Objeto_Entidad_Guia.NGUIRM = -1 Then
                    HelpClass.MsgBox("Ya está registrada esta Guía de Transportista", MessageBoxIcon.Warning)
                    objGuiaTransporte = New GuiaTransportista
                    Exit Sub
                End If
            Else
                Objeto_Entidad_Guia.NGUIRM = obj_Logica.Registrar_Guia_Transportista_Atugenerada(obj_Entidad).NGUIRM
            End If
            If Objeto_Entidad_Guia.NGUIRM <> 0 Then
                HelpClass.MsgBox("Se Registró Satisfactoriamente")
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Me.Estado_Controles(False)
                Me.btnGuardar.Enabled = False
                'Me.HGGuiaRemision.Enabled = True
                Me.TabMantenimiento.Enabled = True
                Me.checkGenerar.Enabled = False
                Me.btnImprimir.Enabled = True
                Me.txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM
                If Me.Tag = 2 Then
                    Me.Agregar_Guia_Transportista_Adicional()
                End If
            Else
                HelpClass.ErrorMsgBox()
                objGuiaTransporte = New GuiaTransportista
            End If
        Else
            Objeto_Entidad_Guia.NGUIRM = obj_Logica.Modificar_Guia_Transportista_Atugenerada(obj_Entidad).NGUIRM
            If Objeto_Entidad_Guia.NGUIRM <> 0 Then
                HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
                Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            Else
                HelpClass.ErrorMsgBox()
                objGuiaTransporte = New GuiaTransportista
            End If
        End If
        'Catch ex As Exception
        '        objGuiaTransporte = New GuiaTransportista
        '    End Try
  End Sub

  Private Sub Agregar_Guia_Transportista_Adicional()
        'Try
        Dim obj_Entidad As New Detalle_Solicitud_Transporte
        Dim obj_Logica As New GuiaTransportista_BLL
        obj_Entidad.NCSOTR = NCSOTR
        obj_Entidad.NCRRSR = NCRRSR
        obj_Entidad.NGUITR = Objeto_Entidad_Guia.NGUIRM
        obj_Entidad.CUSCRT = USUARIO
        obj_Entidad.FCHCRT = HelpClass.TodayNumeric
        obj_Entidad.HRACRT = HelpClass.NowNumeric
        obj_Entidad.NTRMCR = ""
        obj_Entidad.CCMPN = _COMPANIA
        If obj_Logica.Agregar_Guia_Transportista_Adicional(obj_Entidad).NGUITR = 0 Then
            HelpClass.ErrorMsgBox()
        End If
        'Catch : End Try

  End Sub

  'Private Sub Registro_Guias_Cliente()
  '  Me.dtgGuiaRemision.CommitEdit(DataGridViewDataErrorContexts.Commit)
  '  If Me.Validar_Check_Grilla(Me.dtgGuiaRemision) = False Then Exit Sub
  'Dim obj_Logica As New GuiaTransportista_BLL
  'Dim obj_EntidadGuia As New GuiaTransportista
  'Dim lstr_Guia As String = ""
  '  Try
  '    For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
  '      If CBool(Me.dtgGuiaRemision.Item(0, lint_Contador).FormattedValue) = True Then
  '        lstr_Guia = Me.dtgGuiaRemision.Item("NGUIRM_0", lint_Contador).Value

  ''Llenando los datos de la guia de Anexo
  '        obj_EntidadGuia.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '        obj_EntidadGuia.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '        obj_EntidadGuia.NRGUCL = Me.dtgGuiaRemision.Item("NGUIRM_0", lint_Contador).Value
  '        obj_EntidadGuia.FCGUCL = CType(HelpClass.CtypeDate(Me.dtgGuiaRemision.Item("FGUIRM_0", lint_Contador).Value), Double)
  '        obj_EntidadGuia.CCLNT = Me.dtgGuiaRemision.Item("CCLNT_0", lint_Contador).Value
  '        obj_EntidadGuia.FULTAC = HelpClass.TodayNumeric
  '        obj_EntidadGuia.HULTAC = HelpClass.NowNumeric
  '        obj_EntidadGuia.CULUSA = USUARIO
  '        obj_EntidadGuia.NTRMNL = HelpClass.NombreMaquina
  '        obj_EntidadGuia.NRSERI = 0
  '        obj_EntidadGuia.NPRGUI = 0
  '        obj_EntidadGuia.CCMPN = _COMPANIA

  ''Proceso de registro
  '        obj_Logica.Registrar_GuiasCliente_Automatico(obj_EntidadGuia)
  '      End If
  '    Next
  '  Catch : End Try

  ''Lista las guias ya registradas
  '  Me.Listar_Guias_Cliente_Registradas()
  ''Lista las guias de cliente pendiente
  '  ´'Me.Listar_Guias_Cliente()
  '  Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)

  'End Sub

  Private Sub Registro_Ordenes_Compra(ByVal objEntidad As SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga)
    Dim objGuiaOCManifiestoCarga As New GuiaTransportista_BLL
    objGuiaOCManifiestoCarga.Registrar_ManifiestoCarga(objEntidad)

  End Sub

  'Private Sub Listar_Guias_Cliente()
  '  Dim obj_Logica As New GuiaTransportista_BLL
  '  Dim obj_Entidad As New GuiaTransportista
  '  Dim dwvrow As DataGridViewRow
  '  Try
  '    If Me.lblGuiaRemi.Checked Then
  '      If Me.txtFiltroGuiaRemision.Text.Trim = "" Then
  '        HelpClass.MsgBox("Ingrese Guía Remisión", MessageBoxIcon.Information)
  '        Exit Sub
  '      End If
  '    End If
  '    obj_Entidad.CCMPN = Me._COMPANIA
  '    obj_Entidad.CPLNDV = Me._PLANTA
  '    obj_Entidad.CCLNT = Me.UcCliente_GuiaRemision.pCodigo
  '    obj_Entidad.FGUIRM = IIf(Me.dtpFechaFiltro.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltro.Value), Double), 0)
  '    obj_Entidad.NGUIRM = IIf(Me.lblGuiaRemi.Checked = True, Me.txtFiltroGuiaRemision.Text, 0)
  '    Me.dtgGuiaRemision.Rows.Clear()
  '    For Each objEntidad As GuiaTransportista In obj_Logica.Listar_Guias_x_Transportista(obj_Entidad)
  '      dwvrow = New DataGridViewRow
  '      dwvrow.CreateCells(Me.dtgGuiaRemision)
  '      dwvrow.Cells(0).Value = False
  '      dwvrow.Cells(1).Value = objEntidad.NGUIRM_S
  '      dwvrow.Cells(2).Value = objEntidad.TCMPCL
  '      dwvrow.Cells(3).Value = objEntidad.CCLNT
  '      dwvrow.Cells(4).Value = objEntidad.FGUIRM_S
  '      Me.dtgGuiaRemision.Rows.Add(dwvrow)
  '    Next
  '  Catch ex As Exception
  '  End Try
  'End Sub

  Private Sub Listar_Pasajeros_Registrados()

    Dim obj_Entidad As New Hashtable
    Dim objanexoGuiaCliente As New GuiaTransportista_BLL
    Dim dwvrow As DataGridViewRow

    'LIMPIANDO EL dtgGuiasSeleccionadas
    Me.dtgGuiasSeleccionadas.Rows.Clear()
    obj_Entidad.Add("CTRMNC", Objeto_Entidad_Guia.CTRMNC)
    obj_Entidad.Add("NGUITR", Objeto_Entidad_Guia.NGUIRM)
    obj_Entidad.Add("CCMPN", Me._COMPANIA)
    obj_Entidad.Add("CPLNDV", Me._PLANTA)

    'LLENANDO EL dtgGuiasSeleccionadas
    For Each objEntidad As Viaje_Ruta In objanexoGuiaCliente.Listar_Pasajeros_Guia_Transporte(obj_Entidad)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.dtgGuiasSeleccionadas)
      dwvrow.Cells(0).Value = False
      dwvrow.Cells(1).Value = objEntidad.PSNMBPER
      dwvrow.Cells(2).Value = objEntidad.PNNPRGVJ
      dwvrow.Cells(3).Value = objEntidad.RUTA
      dwvrow.Cells(4).Value = objEntidad.PSFSLDRT
      dwvrow.Cells(5).Value = objEntidad.PSHSLDRT
      dwvrow.Cells(6).Value = objEntidad.PNNGUITR
      dwvrow.Cells(7).Value = objEntidad.PNNCRRRT
      dwvrow.Cells(8).Value = objEntidad.PNNCRRIN
      Me.dtgGuiasSeleccionadas.Rows.Add(dwvrow)
    Next

    If Me.dtgGuiasSeleccionadas.RowCount > 0 Then
      Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : " & Me.dtgGuiasSeleccionadas.RowCount
    Else
      Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : 0"
    End If

  End Sub

  'Private Sub Listar_Ordenes_Compra(ByVal lstr_Guia_Transporte As Double)
  '  'Para cada guia de remision, traemos las ordenes de compra
  '  Dim objEntidadDetalleCargaRecepcionada As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
  '  Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL
  '  Dim dwvrow As DataGridViewRow

  '  'LIMPIANDO EL dtgOrdenCompra
  '  Me.dtgOrdenCompra.Rows.Clear()

  '  objEntidadDetalleCargaRecepcionada.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidadDetalleCargaRecepcionada.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidadDetalleCargaRecepcionada.CCLNT = Objeto_Entidad_Guia.CCLNT
  '  objEntidadDetalleCargaRecepcionada.CCMPN = Me._COMPANIA
  '  For Each objEntidadOrdenCompra As SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga In objDetalleCargaRecepcionada.Listar_Ordenes_Compra_x_MC(objEntidadDetalleCargaRecepcionada)
  '    dwvrow = New DataGridViewRow
  '    dwvrow.CreateCells(Me.dtgOrdenCompra)
  '    dwvrow.Cells(0).Value = False
  '    dwvrow.Cells(1).Value = objEntidadOrdenCompra.NGUIRM
  '    dwvrow.Cells(2).Value = objEntidadOrdenCompra.NRGUCL
  '    dwvrow.Cells(3).Value = objEntidadOrdenCompra.CREFFW
  '    dwvrow.Cells(4).Value = objEntidadOrdenCompra.NORCMC
  '    dwvrow.Cells(5).Value = objEntidadOrdenCompra.NRITOC
  '    dwvrow.Cells(6).Value = objEntidadOrdenCompra.TDITES
  '    dwvrow.Cells(7).Value = objEntidadOrdenCompra.QCNTIT
  '    dwvrow.Cells(8).Value = objEntidadOrdenCompra.TUNDIT
  '    dwvrow.Cells(9).Value = objEntidadOrdenCompra.NSEQIN
  '    dwvrow.Cells(10).Value = objEntidadOrdenCompra.NCRRGR
  '    Me.dtgOrdenCompra.Rows.Add(dwvrow)
  '  Next
  'End Sub

  'Private Sub Listar_Guias_Transportista_Registradas()
  '  Dim objEntidad As New GuiaTransportista
  '  Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL
  '  Dim dwvrow As DataGridViewRow

  '  'LIMPIANDO EL dtgOrdenCompra
  '  Me.dtgGuiasTransportistaAnexa.Rows.Clear()
  '  objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidad.CCMPN = _COMPANIA

  '  For Each obj_Entidad As GuiaTransportista In objGuiaTransportistaAdicional.Listar_Guias_Anexas_Transportista(objEntidad)
  '    dwvrow = New DataGridViewRow
  '    dwvrow.CreateCells(Me.dtgGuiasTransportistaAnexa)
  '    dwvrow.Cells(0).Value = obj_Entidad.NGUIRM
  '    dwvrow.Cells(1).Value = obj_Entidad.NGUIAD
  '    dwvrow.Cells(2).Value = obj_Entidad.FGUIRM_S
  '    Me.dtgGuiasTransportistaAnexa.Rows.Add(dwvrow)
  '  Next

  'End Sub

  'Private Function Validar_Existencia_Guia_Remision_Cliente() As Boolean
  '  Dim lbool_Estado As Boolean = False
  '  For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1
  '    If Me.dtgGuiasSeleccionadas.Item("CCLNT", lint_Contador).Value = Me.UcCliente.pCodigo And Me.dtgGuiasSeleccionadas.Item("NRGUCL", lint_Contador).Value.ToString.Trim = Me.txtGuiaCliente.Text.Trim Then
  '      HelpClass.MsgBox("Ya existe esta Guía Cliente")
  '      lbool_Estado = True
  '      Exit For
  '    End If
  '  Next
  '  Return lbool_Estado
  'End Function

  'Private Function Validar_Existencia_Orden_Compra() As Boolean
  '  Dim lbool_Estado As Boolean = False
  '  For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.RowCount - 1
  '    If Me.dtgOrdenCompra.Item("NGUICL", lint_Contador).Value.ToString.Trim = Me.cboGuiaRemisionCliente.SelectedItem.ToString.Trim And Me.dtgOrdenCompra.Item("NORCMC", lint_Contador).Value.ToString.Trim = Me.txtOrdenCompra.Text.Trim Then
  '      HelpClass.MsgBox("Ya existe esta Orden de Compra")
  '      lbool_Estado = True
  '      Exit For
  '    End If
  '  Next
  '  Return lbool_Estado
  'End Function

  'Validar_Check_Agregar_Guia_Remision
  Private Function Validar_Check_Grilla(ByVal dtgGrilla As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) As Boolean
    Dim lbool_Estado As Boolean = False
    For lint_Contador As Integer = 0 To dtgGrilla.RowCount - 1
      If dtgGrilla.Item(0, lint_Contador).Value = True Then
        lbool_Estado = True
        Exit For
      End If
    Next
    Return lbool_Estado
  End Function

  'Private Sub Cargar_Combo_Guia_Cliente()
  '  Me.cboGuiaRemisionCliente.Items.Clear()
  '  For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1
  '    Me.cboGuiaRemisionCliente.Items.Add(Me.dtgGuiasSeleccionadas.Item("NRGUCL", lint_Contador).Value)
  '  Next
  'End Sub

  Private Sub Cargar_Lista_Configuracion_Vehicular()
    Dim obj_Logica As New GuiaTransportista_BLL
    Me._ListaConfiguracion = obj_Logica.Listar_Configuracion_Vehicular(Me._COMPANIA)
  End Sub

  Public Function Busca_Configuracion(ByVal obj_Configuracion As ClaseGeneral) As Boolean
    If obj_Configuracion.TCNFVH.Trim = Me.txtConfigTracto.Text.Trim Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub Reporte_Guia_Transportista(ByVal objEntidad As GuiaTransportista)
    Dim objPrintForm As New PrintForm
    Dim objReporte As New rptGuiaTransportista
    Dim ci As Globalization.CultureInfo
    ci = New Globalization.CultureInfo("es-ES")

    'Limpiando todos los ITextObject del Reporte
    Me.Limpiar_Contenido_Reporte(objReporte)
        'Try
        Dim lguia_Transporte As String = objEntidad.NGUIRM
        CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = lguia_Transporte.Substring(0, 3) + " - " + lguia_Transporte.Substring(3)
        CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = objEntidad.TRFRGU & ", " & HelpClass.CNumero_a_Fecha(objEntidad.FGUIRM).ToString("D", ci)

        If objEntidad.TCNFG1.Substring(0, 1) = "C" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
            CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)

            If objEntidad.NPLCAC <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
            End If
        Else
            If objEntidad.NPLCTR <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)
            End If
            If objEntidad.NPLCAC <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
            End If
        End If

        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = objEntidad.TCNFG1
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""

        If objEntidad.CBRCNT <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(0, objEntidad.CBRCNT.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.IndexOf("-") + 1, objEntidad.CBRCNT.LastIndexOf("-") - objEntidad.CBRCNT.IndexOf("-") - 1)
            CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.LastIndexOf("-") + 1, objEntidad.CBRCNT.Length - objEntidad.CBRCNT.LastIndexOf("-") - 1)
        End If

        CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = objEntidad.TNMBRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = objEntidad.TDRCRM
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = objEntidad.TPDCIR & "  " & objEntidad.NRUCRM
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = objEntidad.TNMBCN
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = objEntidad.TDRCNS
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = objEntidad.TPDCIC & "  " & objEntidad.NRUCCN
        If objEntidad.NORSRT <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = objEntidad.NORSRT.Substring(0, objEntidad.NORSRT.IndexOf("-"))
            CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = objEntidad.NORSRT.Substring(objEntidad.NORSRT.IndexOf("-") + 1, objEntidad.NORSRT.Length - objEntidad.NORSRT.IndexOf("-") - 1)
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblOperacion"), TextObject).Text = objEntidad.NOPRCN.ToString + "           Planmt:   " + objEntidad.NPLNMT.ToString
        If objEntidad.NRGUCL_S <> "" Then
            CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = objEntidad.NRGUCL_S.Remove(0, 1)
        End If
        CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = objEntidad.TOBS
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = objEntidad.CUBORI_S
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = objEntidad.CUBDES_S
        CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = objEntidad.QMRCMC
        CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = Format(objEntidad.QPSOBR, "#,###,###,###.###")
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = Format(objEntidad.PMRCMC, "#,###,###,###.###")
        CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = objEntidad.SMRPLG
        CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = objEntidad.SMRPRC
        CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = objEntidad.QVLMOR
        CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = objEntidad.IVLPRT
        CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = objEntidad.QKMREC
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = objEntidad.TDIRDS
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = objEntidad.TDIROR
        CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = HelpClass.CNumero_a_Fecha(objEntidad.FEMVLH).ToString.Substring(0, 10)
        'objReporte.PrintToPrinter(1, False, 1, 1)
        objPrintForm.ShowForm(objReporte, Me)
        'Catch
        '        HelpClass.ErrorMsgBox()
        '    End Try

        'retornando el reporte
        'objPrintForm.ShowForm(objReporte, Me)

  End Sub

  Private Sub Limpiar_Contenido_Reporte(ByVal objReporte As ReportClass)

    CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = ""
    CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = ""

  End Sub

#End Region

#Region "Eventos"

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Select Case Me.gEnum_Mantenimiento
                Case MANTENIMIENTO.NUEVO, MANTENIMIENTO.EDITAR
                    If Validar_Inputs() = True Then Exit Sub
                    Me.Nuevo_Registro()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub txtNroRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRemision.KeyPress, txtCantMercaderia.KeyPress, txtKmPorRecorrer.KeyPress, txtNroHojaGuia.KeyPress, txtNroDocConsignatario.KeyPress, txtNroDocRemitente.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtGalsGasolina_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGalsGasolina.KeyPress, txtGalsDiesel.KeyPress, txtPesoMercaderia.KeyPress, txtPesoBruto.KeyPress, txtVolumenRemision.KeyPress, txtValorPatrimonio.KeyPress, txtCostoTramo.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
      e.Handled = True
      If (e.KeyChar = ".") And (0 = InStr(sender.Text, ".", CompareMethod.Binary)) Then e.Handled = False
    End If
  End Sub

  Private Sub rbtnDNIRemit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDNIRemit.CheckedChanged
    If Me.rbtnDNIRemit.Checked = True Then
      Me.txtNroDocRemitente.MaxLength = 8
      Me.txtNroDocRemitente.Text = ""
    End If
  End Sub

  Private Sub rbtnRUCRemit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnRUCRemit.CheckedChanged
    If Me.rbtnRUCRemit.Checked = True Then Me.txtNroDocRemitente.MaxLength = 11
  End Sub

  Private Sub rbtnDNIConsignatario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDNIConsignatario.CheckedChanged
    If Me.rbtnDNIConsignatario.Checked = True Then
      Me.txtNroDocConsignatario.MaxLength = 8
      Me.txtNroDocConsignatario.Text = ""
    End If
  End Sub

  Private Sub rbtnRUCConsignatario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnRUCConsignatario.CheckedChanged
    If Me.rbtnRUCConsignatario.Checked = True Then Me.txtNroDocConsignatario.MaxLength = 11
  End Sub

  'Private Sub btnPasarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.dtgGuiaRemision.RowCount = 0 Then Exit Sub
  '  Me.Registro_Guias_Cliente()
  'End Sub

  Private Sub btnQuitarElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarElemento.Click
    If Me.dtgGuiasSeleccionadas.RowCount = 0 Then Exit Sub
    Me.dtgGuiasSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
    If Me.Validar_Check_Grilla(Me.dtgGuiasSeleccionadas) = False Then Exit Sub
    If MessageBox.Show("Quitar al Pasajero de la Guía de Transporte", "Quitar", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub

    'Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
    Dim obj_Logica As New GuiaTransportista_BLL
    Dim obj_Entidad As Viaje_Ruta
    Dim lstr_Guia As String = ""

    Try
      'Procedimiento para eliminar un elemento

      For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.Rows.Count - 1
        If CBool(Me.dtgGuiasSeleccionadas.Item(0, lint_Contador).FormattedValue) = True Then
          obj_Entidad = New Viaje_Ruta
          'Por cada elemento retirado tambien se tienen que 
          'marcar para eliminar sus correspondientes ordenes de compra

          obj_Entidad.PNNPRGVJ = Me.dtgGuiasSeleccionadas.Item("NPRGVJ", lint_Contador).Value
          obj_Entidad.PNNCRRRT = Me.dtgGuiasSeleccionadas.Item("NCRRRT", lint_Contador).Value
          obj_Entidad.PNNCRRIN = Me.dtgGuiasSeleccionadas.Item("NCRRIN", lint_Contador).Value
          obj_Entidad.PNCTRMNC = Objeto_Entidad_Guia.CTRMNC
          obj_Entidad.PNNGUITR = Objeto_Entidad_Guia.NGUIRM
          obj_Entidad.PNFULTAC = HelpClass.TodayNumeric
          obj_Entidad.PNHULTAC = HelpClass.NowNumeric
          obj_Entidad.PSCULUSA = Me._USUARIO
                    obj_Entidad.PSNTRMNL = ""
          obj_Entidad.PSCCMPN = Me._COMPANIA
         
          obj_Logica.Eliminar_Pasajero_Guia_Transporte(obj_Entidad)

          'objEntidadManifiestoCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
          'objEntidadManifiestoCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
          'objEntidadManifiestoCarga.NRGUCL = lstr_Guia
          'objEntidadManifiestoCarga.CCLNT = Me.dtgGuiasSeleccionadas.Item("CCLNT", lint_Contador).Value
          'objEntidadManifiestoCarga.CCMPN = _COMPANIA
          'obj_Logica.Eliminar_ManifiestoCarga(objEntidadManifiestoCarga)

        End If
            Next
            Me.Listar_Pasajeros_Registrados()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    'Me.Listar_Guias_Cliente()
        'Me.Listar_Pasajeros_Registrados()
    'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
  End Sub

  'Private Sub btnAgregarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
  '  If Me.cboGuiaRemisionCliente.Text.Equals("") = True Then
  '    strError += "* GUIA REMISION" & Chr(13)
  '  End If
  '  If Me.txtOrdenCompra.Text.Equals("") = True Then
  '    strError += "* ORDEN DE COMPRA" & Chr(13)
  '  End If
  '  If Me.txtItem.Text.Equals("") = True Then
  '    strError += "* ITEM" & Chr(13)
  '  End If
  '  If Me.txtCantidad.Text.Equals("") = True Then
  '    strError += "* CANTIDAD" & Chr(13)
  '  End If
  '  If strError.Trim.Length > 17 Then
  '    HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
  '    Exit Sub
  '  End If
  '  Try

  '    If Me.Validar_Existencia_Orden_Compra = True Then Exit Sub

  '    Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
  '    objEntidadManifiestoCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '    objEntidadManifiestoCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '    objEntidadManifiestoCarga.NRGUCL = Me.cboGuiaRemisionCliente.Text.Trim
  '    objEntidadManifiestoCarga.CCLNT = Objeto_Entidad_Guia.CCLNT
  '    objEntidadManifiestoCarga.NORCMC = Me.txtOrdenCompra.Text.Trim
  '    objEntidadManifiestoCarga.NRITOC = CType(Me.txtItem.Text, Int32)
  '    objEntidadManifiestoCarga.QCNTIT = CType(Me.txtCantidad.Text, Double)
  '    objEntidadManifiestoCarga.FULTAC = HelpClass.TodayNumeric
  '    objEntidadManifiestoCarga.HULTAC = HelpClass.NowNumeric
  '    objEntidadManifiestoCarga.CULUSA = USUARIO
  '    objEntidadManifiestoCarga.NTRMNL = HelpClass.NombreMaquina
  '    objEntidadManifiestoCarga.CCMPN = _COMPANIA
  '    objEntidadManifiestoCarga.CREFFW = Me.txtBulto.Text
  '    objEntidadManifiestoCarga.NSEQIN = 1

  '    Me.Registro_Ordenes_Compra(objEntidadManifiestoCarga)

  '    'Limpiando elementos
  '    Me.cboGuiaRemisionCliente.Text = ""
  '    Me.txtOrdenCompra.Text = ""
  '    Me.txtItem.Text = ""
  '    Me.txtCantidad.Text = ""
  '    Me.txtBulto.Text = ""
  '  Catch : End Try
  '  Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
  'End Sub

  'Private Sub btnEliminarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.dtgOrdenCompra.RowCount = 0 Then Exit Sub
  '  Me.dtgOrdenCompra.CommitEdit(DataGridViewDataErrorContexts.Commit)
  '  If Me.Validar_Check_Grilla(Me.dtgOrdenCompra) = False Then Exit Sub
  '  If MessageBox.Show("Desea Eliminar esta Orden de Compra", "Eliminar", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub
  '  Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
  '  Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL

  '  Try
  '    For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.Rows.Count - 1
  '      If CBool(Me.dtgOrdenCompra.Item(0, lint_Contador).FormattedValue) = True Then
  '        objEntidadManifiestoCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '        objEntidadManifiestoCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '        objEntidadManifiestoCarga.NRGUCL = Me.dtgOrdenCompra.Item("NGUICL", lint_Contador).Value
  '        objEntidadManifiestoCarga.NORCMC = Me.dtgOrdenCompra.Item("NORCMC", lint_Contador).Value
  '        objEntidadManifiestoCarga.CCLNT = Objeto_Entidad_Guia.CCLNT
  '        objEntidadManifiestoCarga.NRITOC = Me.dtgOrdenCompra.Item("NRITOC", lint_Contador).Value
  '        objEntidadManifiestoCarga.NCRRGR = Me.dtgOrdenCompra.Item("NCRRGR", lint_Contador).Value
  '        objEntidadManifiestoCarga.CCMPN = _COMPANIA
  '        objDetalleCargaRecepcionada.Eliminar_Orden_Compra(objEntidadManifiestoCarga)
  '      End If
  '    Next
  '  Catch : End Try

  '  Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
  'End Sub

  'Private Sub btnAgregarGuiaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
  '  If Me.txtNroGuiaAnexa.Text.Equals("") = True Then
  '    strError += "* GUIA TRANSPORTISTA ANEXA" & Chr(13)
  '  End If
  '  If strError.Trim.Length > 17 Then
  '    HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
  '    Exit Sub
  '  End If
  '  Dim guia_anexa As String = Me.txtNroGuiaAnexa.Text
  '  Dim fecha As String = Me.dtpFechaGuiaTransportista.Value

  '  'Averiguando si es que en la lista de elementos seleccionados
  '  'esta el elemento ingresado
  '  For i As Integer = 0 To Me.dtgGuiasTransportistaAnexa.RowCount - 1
  '    If Me.dtgGuiasTransportistaAnexa.Item("NGUIRM_T", i).ToString().Equals(guia_anexa) = True Then
  '      HelpClass.MsgBox("Ya esta registrado esta Guia de Transporte Anexa")
  '      Exit Sub
  '    End If
  '  Next

  '  Dim objEntidad As New GuiaTransportista
  '  Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL

  '  objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidad.SESTRG = "A"
  '  objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidad.NGUIAD = CType(guia_anexa, Double)
  '  objEntidad.FGUIRM = CType(HelpClass.CtypeDate(Me.dtpFechaGuiaTransportista.Value), Double)
  '  objEntidad.FULTAC = HelpClass.TodayNumeric
  '  objEntidad.HULTAC = HelpClass.NowNumeric
  '  objEntidad.CULUSA = USUARIO
  '  objEntidad.NTRMNL = HelpClass.NombreMaquina
  '  objEntidad.CCMPN = _COMPANIA

  '  objGuiaTransportistaAdicional.Registrar_GuiaTransportistaAdicional(objEntidad)
  '  Me.txtNroGuiaAnexa.Text = ""

  '  Me.Listar_Guias_Transportista_Registradas()
  'End Sub

  'Private Sub btnEliminarGuiaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.dtgGuiasTransportistaAnexa.RowCount = 0 Then Exit Sub
  '  If MessageBox.Show("Desea Eliminar esta de Guia Transportista Anexa", "Eliminar G. Adicional", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub
  '  Dim objEntidad As New GuiaTransportista
  '  Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL

  '  objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidad.SESTRG = "A"
  '  objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidad.NGUIAD = Me.dtgGuiasTransportistaAnexa.Item("NGUIAD", Me.dtgGuiasTransportistaAnexa.CurrentCellAddress.Y).Value
  '  objEntidad.CCMPN = _COMPANIA

  '  objGuiaTransportistaAdicional.Eliminar_GuiaTransportistaAdicional(objEntidad)
  '  Me.Listar_Guias_Transportista_Registradas()
  'End Sub

  'Private Sub btnAgregarGuiaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
  '  If Me.UcCliente.pCodigo = 0 Then
  '    strError += "* CLIENTE" & Chr(13)
  '  End If
  '  If Me.txtGuiaCliente.Text.Equals("") = True Then
  '    strError += "* GUIA REMISION CLIENTE" & Chr(13)
  '  End If
  '  If strError.Trim.Length > 17 Then
  '    HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
  '    Exit Sub
  '  End If
  '  Try
  '    If Me.Validar_Existencia_Guia_Remision_Cliente = True Then Exit Sub
  '    Dim obj_Logica As New GuiaTransportista_BLL
  '    Dim obj_EntidadGuia As New GuiaTransportista
  '    'Llenando los datos de la guia de Anexo
  '    obj_EntidadGuia.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '    obj_EntidadGuia.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '    obj_EntidadGuia.NRGUCL = Me.txtGuiaCliente.Text.Trim
  '    obj_EntidadGuia.FCGUCL = CType(HelpClass.CtypeDate(Me.dtpFechaGuiaCliente.Value), Double)
  '    obj_EntidadGuia.CCLNT = Me.UcCliente.pCodigo
  '    obj_EntidadGuia.FULTAC = HelpClass.TodayNumeric
  '    obj_EntidadGuia.HULTAC = HelpClass.NowNumeric
  '    obj_EntidadGuia.CULUSA = USUARIO
  '    obj_EntidadGuia.NTRMNL = HelpClass.NombreMaquina
  '    obj_EntidadGuia.NRSERI = 0
  '    obj_EntidadGuia.NPRGUI = 0
  '    obj_EntidadGuia.CCMPN = _COMPANIA
  '    'Proceso de registro
  '    Dim objEntidad As GuiaTransportista = obj_Logica.Registrar_GuiasCliente_Manual(obj_EntidadGuia)
  '    If objEntidad.NRGUCL = -1 Then
  '      HelpClass.MsgBox("Guía Remisión registrada en otra Guía de Transporte" & Chr(13) & Chr(13) & "Código Transportista : " & objEntidad.CTRMNC & Chr(13) & "Guía Transporte: " & objEntidad.NGUIRM, MessageBoxIcon.Information)
  '      Exit Sub
  '    End If
  '    Me.Listar_Guias_Cliente_Registradas()
  '    'LIMPIANDO CONTROLES
  '    'Me.UcCliente.pClear()
  '    Me.txtGuiaCliente.Text = ""
  '  Catch : End Try
  'End Sub

  Private Sub btnConfigTracto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigTracto.Click
    Dim frm_ConfiguracionVehicular As New frmConfiguracionVehicular
    With frm_ConfiguracionVehicular
      .ListaConfiguracion = Me._ListaConfiguracion
      If .ShowDialog = DialogResult.Cancel Then Exit Sub
      Me.txtConfigTracto.Text = .TCNFVH_1
    End With
  End Sub

  'Private Sub dtgOrdenCompra_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  '  If e.RowIndex = -1 And e.ColumnIndex = 0 Then
  '    Me.dtgOrdenCompra.EndEdit()
  '    Dim lintEstado As Boolean = Me.dtgOrdenCompra.Item(0, 0).Value
  '    For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.RowCount - 1
  '      Me.dtgOrdenCompra.Item(0, lint_Contador).Value = Not lintEstado 'Me.dtgOrdenCompra.Item(0, lint_Contador).Value
  '      Me.dtgOrdenCompra.EndEdit()
  '    Next

  '  End If
  'End Sub

  Private Sub TabMantenimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMantenimiento.SelectedIndexChanged
    'If Me.TabMantenimiento.SelectedIndex = 1 Then Me.Cargar_Combo_Guia_Cliente()
  End Sub

  Private Sub checkGenerar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGenerar.CheckedChanged
    If _ESTADO = True Then Exit Sub
    Select Case Me.checkGenerar.Checked
      Case True
        Me.txtNroRemision.Text = Me._GUIATRANS.ToString
        Me.txtNroRemision.Enabled = False
                'Me.dtpFecIniTrans.Enabled = False
                Me.dtpFecIniTrans.Enabled = True
      Case False
        Me.txtNroRemision.Enabled = True
        Me.dtpFecIniTrans.Enabled = True
        Me.txtNroRemision.Text = ""
                'Me.txtNroRemision.AppendText("175")
    End Select
  End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim objEntidad As New GuiaTransportista
            Dim objGuiaTransporte As New GuiaTransportista_BLL
            objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
            objEntidad.CCMPN = COMPANIA ' Me.cboCompania.Codigo
            objEntidad.CDVSN = DIVISION ' Me.cboDivision.Codigo
            objEntidad.CPLNDV = PLANTA ' CType(Me.cboCodPlanta.Codigo, Double)
            objEntidad = objGuiaTransporte.Obtener_Guia_Transportista_RPT(objEntidad)
            Me.Reporte_Guia_Transportista(objEntidad)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub UcCNomRemitente_InformationChanged() Handles UcCNomRemitente.InformationChanged
    'If Me._ESTADO = True Then Exit Sub
    Me.txtDirRemitente.Text = UcCNomRemitente.pDireccionOrigen
    Me.txtNroDocRemitente.Text = UcCNomRemitente.pNroRuc
  End Sub

  Private Sub UcCNomConsignatario_InformationChanged() Handles UcCNomConsignatario.InformationChanged
    'If Me._ESTADO = True Then Exit Sub
    Me.txtDirConsignatario.Text = Me.UcCNomConsignatario.pDireccionOrigen
    Me.txtNroDocConsignatario.Text = Me.UcCNomConsignatario.pNroRuc
  End Sub

  Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged
    Me.UcCNomConsignatario.Visible = Not Me.chkCliente.Checked
    Me.txtNomConsignatario.Visible = Me.chkCliente.Checked
    Me.txtNomConsignatario.Text = ""
    Me.UcCNomConsignatario.pClear()
    Me.txtDirConsignatario.Text = ""
    Me.txtNroDocConsignatario.Text = ""
  End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  'If Objeto_Entidad_Guia.CCLNT <> 0 Then Me.Listar_Guias_Cliente()
  '  If Me.UcCliente_GuiaRemision.pCodigo = 0 Then
  '    HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Information)
  '    Exit Sub
  '  End If

  '  Me.Listar_Guias_Cliente()
  'End Sub

#End Region
  Private lstrCliente As String = ""

  Private Function Buscar_Cliente_Guia_Remision(ByVal lintGuiaRemision As Int64) As Int64
    Dim lintCliente As Int64 = 0

    For lintCount As Int32 = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1
      If Me.dtgGuiasSeleccionadas.Item("NRGUCL", lintCount).Value = lintGuiaRemision Then
        lintCliente = Me.dtgGuiasSeleccionadas.Item("CCLNT", lintCount).Value
        lstrCliente = Me.dtgGuiasSeleccionadas.Item("CCLNT", lintCount).Value & " - " & Me.dtgGuiasSeleccionadas.Item("TCMPCL", lintCount).Value
        Exit For
      End If
    Next

    Return lintCliente
  End Function

  'Private Sub btnVerDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.cboGuiaRemisionCliente.Text.Trim = "" Then
  '    HelpClass.MsgBox("Seleccionar Guía Remisión Cliente", MessageBoxIcon.Information)
  '    Exit Sub
  '  End If
  '  Dim objEntidadCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
  '  objEntidadCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
  '  objEntidadCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
  '  objEntidadCarga.NRGUCL = CType(Me.cboGuiaRemisionCliente.Text.Trim, Int64)
  '  objEntidadCarga.CCLNT = Buscar_Cliente_Guia_Remision(CType(Me.cboGuiaRemisionCliente.Text.Trim, Int64))
  '  objEntidadCarga.TCMPCL = lstrCliente
  '  objEntidadCarga.CCMPN = Me._COMPANIA
  '  objEntidadCarga.CDVSN = Me._DIVISION
  '  objEntidadCarga.CPLNDV = Me._PLANTA
  '  Dim frmDetalleBulto As frmDetalleBultoDia
  '  frmDetalleBulto = New frmDetalleBultoDia(objEntidadCarga)
  '  frmDetalleBulto.ShowInTaskbar = False
  '  frmDetalleBulto.StartPosition = FormStartPosition.CenterScreen
  '  frmDetalleBulto.Tag = _USUARIO
  '  If frmDetalleBulto.ShowDialog() = DialogResult.OK Then
  '    Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
  '  End If
  '  lstrCliente = ""
  'End Sub

  'Private Sub lblGuiaRemi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.lblGuiaRemi.Checked = True Then
  '    Me.txtFiltroGuiaRemision.Enabled = True
  '    Me.dtpFechaFiltro.Enabled = False
  '  Else
  '    Me.txtFiltroGuiaRemision.Enabled = False
  '    Me.dtpFechaFiltro.Enabled = True
  '  End If
  'End Sub

  'Private Sub dtgGuiaRemision_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  '  If e.RowIndex = -1 And e.ColumnIndex = 0 Then
  '    If Me.dtgGuiaRemision.RowCount = 0 Then Exit Sub
  '    Dim lintEstado As Boolean = Me.dtgGuiaRemision.Item(0, 0).Value
  '    For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
  '      Me.dtgGuiaRemision.Item(0, lint_Contador).Value = Not lintEstado
  '      Me.dtgGuiaRemision.EndEdit()
  '    Next

  '  End If
  'End Sub

  Private Sub dtgGuiasSeleccionadas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGuiasSeleccionadas.CellDoubleClick
    If e.RowIndex = -1 And e.ColumnIndex = 0 Then
      If Me.dtgGuiasSeleccionadas.RowCount = 0 Then Exit Sub
      Dim lintEstado As Boolean = Me.dtgGuiasSeleccionadas.Item(0, 0).Value
      For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1
        Me.dtgGuiasSeleccionadas.Item(0, lint_Contador).Value = Not lintEstado
        Me.dtgGuiasSeleccionadas.EndEdit()
      Next
    End If
  End Sub

  'Private Sub txtFiltroGuiaRemision_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  '  Try
  '    If e.KeyCode = Keys.Enter Then
  '      If Me.txtFiltroGuiaRemision.Text.Trim.Equals("") Then Exit Sub
  '      Me.btnBuscar_Click(Nothing, Nothing)
  '      If Me.dtgGuiaRemision.RowCount = 1 Then
  '        Me.dtgGuiaRemision.Item("SELECCIONAR", 0).Value = True
  '      End If
  '    End If
  '  Catch : End Try
  'End Sub

    Private Sub btnAsignarPasajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarPasajero.Click

        Try
            Dim objfrmConsultaPasajero As New frmConsultaPasajero
            With objfrmConsultaPasajero
                .Text = "CONSULTA GUIA REMISION CLIENTE"
                .COMPANIA = Me._COMPANIA
                .PLANTA = Me._PLANTA
                .TIPO_GUIA = 0
                .USUARIO = Me._USUARIO
                .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
                .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
                .CLIENTE = Objeto_Entidad_Guia.CCLNT
                .ORIGEN = Objeto_Entidad_Guia.CLCLOR
                .DESTINO = Objeto_Entidad_Guia.CLCLDS
                .RUTA_PASAJERO = Me.cboLugarOrigen.Descripcion.Trim & " - " & Me.cboLugarDestino.Descripcion.Trim
                .MEDIO_TRANSPORTE = Objeto_Entidad_Guia.CMEDTR
                .ShowDialog()
                'If .ShowDialog = DialogResult.Cancel Then Exit Sub
                Me.Listar_Pasajeros_Registrados()
                'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

  'Private Sub btnAsignarGuiaRemManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim objfrmAsignarGuia As New frmAsignarGuia
  '  With objfrmAsignarGuia
  '    .COMPANIA = Me._COMPANIA
  '    .PLANTA = Me._PLANTA
  '    .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
  '    .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
  '    .CLIENTE = Objeto_Entidad_Guia.CCLNT
  '    .USUARIO = Me._USUARIO
  '    .ShowDialog()
  '    'If .ShowDialog = DialogResult.Cancel Then Exit Sub
  '    Me.Listar_Pasajeros_Registrados()
  '  End With
  'End Sub

  'Private Sub btnAsignarGuiaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim objfrmConsultaGuia As New frmConsultaGuia
  '  With objfrmConsultaGuia
  '    .Text = "CONSULTA GUIA REMISION PROVEEDOR"
  '    .COMPANIA = Me._COMPANIA
  '    .PLANTA = Me._PLANTA
  '    .TIPO_GUIA = 1
  '    .USUARIO = Me._USUARIO
  '    .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
  '    .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
  '    .CLIENTE = Objeto_Entidad_Guia.CCLNT
  '    .ShowDialog()
  '    'If .ShowDialog = DialogResult.Cancel Then
  '    Me.Listar_Pasajeros_Registrados()
  '    'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
  '  End With
  'End Sub
End Class
