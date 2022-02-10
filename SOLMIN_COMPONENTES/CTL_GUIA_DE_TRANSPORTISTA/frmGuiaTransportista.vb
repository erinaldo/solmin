Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO

Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES

Public Class frmGuiaTransportista

#Region "Atributos"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Objeto_Entidad_Guia As New GuiaTransportista
    Private _GUIATRANS As Double = 0
    Private _ListaConfiguracion As List(Of ClaseGeneral)
    Private match_Normal As New Predicate(Of ClaseGeneral)(AddressOf Busca_Configuracion)
    Private objGuiaTransporte As New GuiaTransportista
    Private _strEstadoGuiaRemision As Boolean = False

    Private _MedioTransporte As Int32 = 0
    '
    Private _objTable As DataTable
    Private _intTipoViaje As Int16 = 0

    Private DiasEstimados_ETA As Decimal = 0




#End Region

#Region "Propiedades"
 
    Public WriteOnly Property TipoViaje() As Int16
        Set(ByVal value As Int16)
            _intTipoViaje = value
        End Set
    End Property

     

    Public ESTADO As Boolean = False
 

     

    Public pNCSOTR As Decimal = 0
    Public pNCRRSR As Decimal = 0
    Public pUSUARIO As String = ""
    Public pPLANTA As String = ""
    Public pDIVISION As String = ""
    Public pCOMPANIA As String = ""
    Public pPLANTA_DESC As String = ""
    

    Public pCTRMNC As Decimal = 0
    Public pNGUITR As Decimal = 0
    Public pNOPRCN As Decimal = 0
    Public pEstadoRegistro As Decimal = 0
    Public pNMOPRP As Decimal = 0
    Public pCTPOVJ As String = ""
    Public pNMVJCS As Decimal = 0
    Public pNMOPMM As Decimal = 0

    Public pDialogOK As Boolean = False

    



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


#End Region

#Region "Metodos y Funciones"

    Public Sub ChargeForm()

        Objeto_Entidad_Guia.NGUIRM = pNGUITR
        Objeto_Entidad_Guia.CTRMNC = pCTRMNC
        Objeto_Entidad_Guia.NOPRCN = pNOPRCN
        Objeto_Entidad_Guia.CTPOVJ = pCTPOVJ
        Objeto_Entidad_Guia.NMOPRP = pNMOPRP
        Objeto_Entidad_Guia.NMVJCS = pNMVJCS
        Objeto_Entidad_Guia.NMOPMM = pNMOPMM
        Objeto_Entidad_Guia.NCSOTR = pNCSOTR
        Objeto_Entidad_Guia.NCRRSR = pNCRRSR
        Objeto_Entidad_Guia.CCMPN = pCOMPANIA
        Objeto_Entidad_Guia.CDVSN = pDIVISION
        Objeto_Entidad_Guia.CULUSA = pUSUARIO


       
        Try
            dtgGuiasSeleccionadas.AutoGenerateColumns = False
            dtgOrdenCompra.AutoGenerateColumns = False
            dtgGuiasTransportistaAnexa.AutoGenerateColumns = False

         



            Dim dt_tipoGR As New DataTable
            Dim dt_TipoGRAnexo As New DataTable
            'Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL
            'dt_tipoGR = objAyuda.fdtListar_TablaAyuda_L01("TPOGRT", "")
            dt_tipoGR.Columns.Add("CCMPRN")
            dt_tipoGR.Columns.Add("TDSDES")
            cboTipoGR.DataSource = dt_tipoGR
            Dim dr As DataRow
            dr = dt_tipoGR.NewRow
            dr("CCMPRN") = "F"
            dr("TDSDES") = "FISICO"
            dt_tipoGR.Rows.Add(dr)

            dr = dt_tipoGR.NewRow
            dr("CCMPRN") = "E"
            dr("TDSDES") = "ELECTRONICO"
            dt_tipoGR.Rows.Add(dr)

            cboTipoGR.DisplayMember = "TDSDES"
            cboTipoGR.ValueMember = "CCMPRN"
            cboTipoGR.SelectedValue = "F"

            cboTipoGR_SelectionChangeCommitted(cboTipoGR, Nothing)


            dt_TipoGRAnexo = dt_tipoGR.Copy

            cboTipoGTAnexo.DataSource = dt_TipoGRAnexo
            cboTipoGTAnexo.DisplayMember = "TDSDES"
            cboTipoGTAnexo.ValueMember = "CCMPRN"
            cboTipoGTAnexo.SelectedValue = "F"

            cboTipoGTAnexo_SelectionChangeCommitted(cboTipoGTAnexo, Nothing)


            Me.lblDiasEstimados.Text = "..."
            lblmsg.Text = ""
            DiasEstimados_ETA = CalcularDiasEstimados()
            If DiasEstimados_ETA >= 0 Then
                lblDiasEstimados.Text = Val(DiasEstimados_ETA)
            End If

            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            btnGuardar.Enabled = False

            If Objeto_Entidad_Guia.NGUIRM = 0 Then Objeto_Entidad_Guia.NGUIRM = -1

            'Cargar_Combos()
            'Seleccionando los valores por defecto
          
            'Obteniendo el numero de Guia de Transportista
            Dim objeto_Logica As New GuiaTransportista_BLL
            Dim objeto_Entidad As New OperacionTransporte
            objeto_Entidad.NOPRCN = pNOPRCN
          
            objeto_Entidad.CCMPN = pCOMPANIA
            objeto_Entidad.CDVSN = pDIVISION
            objeto_Entidad.CPLNDV = pPLANTA

            txtPlanta.Text = pPLANTA_DESC

          

            If ESTADO = True Then

                gEnum_Mantenimiento = MANTENIMIENTO.EDITAR

                btnGuardar.Enabled = ESTADO

                Dim objetoParametro As New Hashtable
                Dim obeGuiaTransporte As New GuiaTransportista
                objetoParametro.Add("PNCTRMNC", Objeto_Entidad_Guia.CTRMNC)
                objetoParametro.Add("PNNGUITR", Objeto_Entidad_Guia.NGUIRM)
                objetoParametro.Add("PNNOPRCN", Objeto_Entidad_Guia.NOPRCN)
                objetoParametro.Add("PSCCMPN", pCOMPANIA)
                objetoParametro.Add("PSCDVSN", pDIVISION)
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
                Objeto_Entidad_Guia.NGUITS = obeGuiaTransporte.NGUITS
                Objeto_Entidad_Guia.CTDGRT = obeGuiaTransporte.CTDGRT



                Objeto_Entidad_Guia.TCMLCO = obeGuiaTransporte.TCMLCO
                Objeto_Entidad_Guia.TCMLCD = obeGuiaTransporte.TCMLCD
                'Objeto_Entidad_Guia.UBIGEO_O = obeGuiaTransporte.UBIGEO_O
                'Objeto_Entidad_Guia.UBIGEO_D = obeGuiaTransporte.UBIGEO_D

                Objeto_Entidad_Guia.FLGAPA = obeGuiaTransporte.FLGAPA




                txtTransportista.Text = Objeto_Entidad_Guia.NRUCTR & " - " & Objeto_Entidad_Guia.TCMTRT


                txtNroRemision.Text = Objeto_Entidad_Guia.NGUITS
                txtNroRemision.Tag = Objeto_Entidad_Guia.NGUIRM

                Estado_Controles(ESTADO)

                TabMantenimiento.Enabled = ESTADO

                checkGenerar.Enabled = False

                'Listar_Guias_Cliente_Registradas()
                'Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
                'Listar_Guias_Transportista_Registradas()
                Listar_Guias_x_GuiaTRansportista()
                cboTipoGR.Enabled = False

            Else


                gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

                Dim objetoEntidad As New GuiaTransportista
                objetoEntidad.CCMPN = pCOMPANIA
                objetoEntidad.CDVSN = pDIVISION
                objetoEntidad.CPLNDV = pPLANTA
                objetoEntidad.NGUIRM = 0

                Me._GUIATRANS = objeto_Logica.Obtener_Numero_Guia_Transporte(objetoEntidad).NGUIRM

                Dim objGTAdicional As New GuiaTransportista
                Dim objGTFiltro As New GuiaTransportista
                objGTFiltro.NOPRCN = Me.pNOPRCN
                objGTFiltro.CCMPN = pCOMPANIA
                'objGTAdicional = objeto_Logica.Obtener_Informacion_OS(objGTFiltro)
                objGTAdicional = objeto_Logica.Obtener_Informacion_Recurso_Guia_Transporte(pCOMPANIA, pNOPRCN, pNCSOTR, pNCRRSR)


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


                Objeto_Entidad_Guia.NPLCTR = objGTAdicional.NPLCTR
                Objeto_Entidad_Guia.NPLCAC = objGTAdicional.NPLCAC
                Objeto_Entidad_Guia.CBRCNT = objGTAdicional.CBRCNT
                Objeto_Entidad_Guia.CBRCND = objGTAdicional.CBRCND
                Objeto_Entidad_Guia.NRUCTR = objGTAdicional.NRUCTR

                Objeto_Entidad_Guia.TCMLCO = objGTAdicional.TCMLCO
                Objeto_Entidad_Guia.TCMLCD = objGTAdicional.TCMLCD
                Objeto_Entidad_Guia.UBIGEO_O = objGTAdicional.UBIGEO_O
                Objeto_Entidad_Guia.UBIGEO_D = objGTAdicional.UBIGEO_D

                checkGenerar.Checked = False
                'Objeto_Entidad_Guia.CTRMNC = objeto_Logica.Obtener_Codigo_Transportista(Objeto_Entidad_Guia.NRUCTR, Me.COMPANIA)
                txtTransportista.Text = Objeto_Entidad_Guia.NRUCTR & " - " & Objeto_Entidad_Guia.TCMTRT

                btnGuardar.Enabled = Not ESTADO
                TabMantenimiento.Enabled = ESTADO

                btnImprimir.Enabled = ESTADO


            End If


            Asignar_Valores()
            Cargar_Lista_Configuracion_Vehicular()

            txtNroRemision.Select(0, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub

    

    Private Sub Asignar_Valores()

        _MedioTransporte = Objeto_Entidad_Guia.CMEDTR

        txtNroPlaneamiento.Text = Objeto_Entidad_Guia.NPLNMT
        txtNroOperacion.Text = pNOPRCN

        If ESTADO = False Then
            dtpFecGuia.Value = Date.Today
            dtpFecGuiaETD.Value = Date.Today
            dtpFecGuiaETA.Value = Date.Today
            dtpFecIniTrans.Value = Date.Today
            txtHoraInicio.Text = Now.ToString("HH:mm")
            dtpFecGuiaETA.Checked = False

            AsignarETA()
        Else
            dtpFecGuia.Value = CType(Objeto_Entidad_Guia.FGUIRM_S, Date)
            dtpFecIniTrans.Value = HelpClass.CNumero_a_Fecha(Objeto_Entidad_Guia.FEMVLH)
            dtpFecGuiaETD.Value = CType(Objeto_Entidad_Guia.FECETD_S, Date)
            If Objeto_Entidad_Guia.FECETA_S = "00/00/0000" OrElse Objeto_Entidad_Guia.FECETA_S = "" Then
                dtpFecGuiaETA.Checked = False
            Else
                dtpFecGuiaETA.Checked = True
                dtpFecGuiaETA.Value = CType(Objeto_Entidad_Guia.FECETA_S, Date)
            End If
            cboTipoGR.SelectedValue = Objeto_Entidad_Guia.CTDGRT
            cboTipoGR_SelectionChangeCommitted(cboTipoGR, Nothing)
            'txtNroRemision.Text = Objeto_Entidad_Guia.NGUIRM

            txtNroRemision.Text = Objeto_Entidad_Guia.NGUITS
            txtNroRemision.Tag = Objeto_Entidad_Guia.NGUIRM

            txtHoraInicio.Text = Objeto_Entidad_Guia.HRAINI

           

        End If



        txtLugarOrigen.Tag = Objeto_Entidad_Guia.CLCLOR
        txtLugarOrigen.Text = Objeto_Entidad_Guia.TCMLCO


        txtLugar.Text = Objeto_Entidad_Guia.TCMLCO



        txtLugarDestino.Tag = Objeto_Entidad_Guia.CLCLDS
        txtLugarDestino.Text = Objeto_Entidad_Guia.TCMLCD



        If Objeto_Entidad_Guia.TDIROR.Length > Me.txtDirOrigen.MaxLength Then
            txtDirOrigen.Text = Objeto_Entidad_Guia.TDIROR.Substring(0, Me.txtDirOrigen.MaxLength)
        Else
            txtDirOrigen.Text = Objeto_Entidad_Guia.TDIROR
        End If
        If Objeto_Entidad_Guia.TDIRDS.Length > Me.txtDirDestino.MaxLength Then
            txtDirDestino.Text = Objeto_Entidad_Guia.TDIRDS.Substring(0, Me.txtDirDestino.MaxLength)
        Else
            txtDirDestino.Text = Objeto_Entidad_Guia.TDIRDS
        End If
       
        'txtUbigeoOrigen.Text = Objeto_Entidad_Guia.UBIGEO_O
        'txtUbigeoOrigen.Tag = Objeto_Entidad_Guia.CUBORI
        'txtUbigeoDestino.Text = Objeto_Entidad_Guia.UBIGEO_D
        'txtUbigeoDestino.Tag = Objeto_Entidad_Guia.CUBDES

        txtCantMercaderia.Text = Objeto_Entidad_Guia.QMRCMC

        txtUnidadMed.Text = Objeto_Entidad_Guia.CUNDMD_DESC

        txtGalsGasolina.Text = Objeto_Entidad_Guia.QGLGSL
        txtGalsDiesel.Text = Objeto_Entidad_Guia.QGLDSL
        txtNroHojaGuia.Text = Objeto_Entidad_Guia.NRHJCR
        txtPesoMercaderia.Text = Objeto_Entidad_Guia.PMRCMC
        txtPesoBruto.Text = Objeto_Entidad_Guia.QPSOBR

        txtTracto.Text = Objeto_Entidad_Guia.NPLCTR
        txtAcoplado.Text = Objeto_Entidad_Guia.NPLCAC
        txtConductor.Text = Objeto_Entidad_Guia.CBRCNT + " - " + Objeto_Entidad_Guia.CBRCND
        txtConfigTracto.Text = Objeto_Entidad_Guia.TCNFVH

        rbtnRemitente.Checked = IIf(Objeto_Entidad_Guia.SACRGO = "R", True, False)
        rbtnDestinatario.Checked = IIf(Objeto_Entidad_Guia.SACRGO = "R", False, True)

        rbtnIda.Checked = IIf(Objeto_Entidad_Guia.SIDAVL = "I", True, False)
        rbtnIdaVuelta.Checked = IIf(Objeto_Entidad_Guia.SIDAVL = "I", False, True)
        chkMercPerecible.Checked = IIf(Objeto_Entidad_Guia.SMRPRC = "X", True, False)
        chkMercPeligrosa.Checked = IIf(Objeto_Entidad_Guia.SMRPLG = "X", True, False)
        txtVolumenRemision.Text = Objeto_Entidad_Guia.QVLMOR
        'txtValorPatrimonio.Text = Objeto_Entidad_Guia.IVLPRT

        txtKmPorRecorrer.Text = Objeto_Entidad_Guia.QKMREC

        chkFlagPeso.Checked = IIf(Objeto_Entidad_Guia.FLGAPA = "X", True, False)

       
 


        UcCNomRemitente.CCMPN = Me.pCOMPANIA
        UcCNomRemitente.pCargar(Objeto_Entidad_Guia.CCLNT)
        '-----------------------------------------------------------
        If Objeto_Entidad_Guia.TDRCRM.Length > Me.txtDirRemitente.MaxLength Then
            txtDirRemitente.Text = Objeto_Entidad_Guia.TDRCRM.Substring(0, Me.txtDirRemitente.MaxLength)
        Else
            txtDirRemitente.Text = Objeto_Entidad_Guia.TDRCRM
        End If
        rbtnDNIRemit.Checked = IIf(Objeto_Entidad_Guia.TPDCIR = "R", False, True)
        rbtnRUCRemit.Checked = IIf(Objeto_Entidad_Guia.TPDCIR = "R", True, False)
        txtNroDocRemitente.Text = Objeto_Entidad_Guia.NRUCRM

        If ESTADO = True Then

            chkCliente.Checked = True
            chkCliente.Visible = False
            UcCNomConsignatario.Visible = False
            txtNomConsignatario.Visible = True
            txtNomConsignatario.Text = Objeto_Entidad_Guia.TNMBCN
            txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS
            rbtnDNIConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", False, True)
            rbtnRUCConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", True, False)
            txtNroDocConsignatario.Text = Objeto_Entidad_Guia.NRUCCN
        Else


            UcCNomConsignatario.CCMPN = Me.pCOMPANIA
            UcCNomConsignatario.pCargar(Objeto_Entidad_Guia.CCLNT)
            If Objeto_Entidad_Guia.TDRCNS.Length > Me.txtDirConsignatario.MaxLength Then
                txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS.Substring(0, Me.txtDirConsignatario.MaxLength)
            Else
                txtDirConsignatario.Text = Objeto_Entidad_Guia.TDRCNS
            End If
            rbtnDNIConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", False, True)
            rbtnRUCConsignatario.Checked = IIf(Objeto_Entidad_Guia.TPDCIC = "R", True, False)
            txtNroDocConsignatario.Text = Objeto_Entidad_Guia.NRUCCN

        End If

       
        txtObservación.Text = Objeto_Entidad_Guia.TOBS
        txtOrdenEmbarcador.Text = Objeto_Entidad_Guia.NOREMB
        objGuiaTransporte = Objeto_Entidad_Guia
        '-----------------------------------------------------------


    End Sub

    'Private Sub Cargar_Combos()

    '    Dim obj_Logica_Unidad As New UnidadMedida_BLL
    '    Dim obj_Logica_Localidad As New Localidad_BLL
    '    Dim obj_Logica_Ubigeo As New LocalidadRuta_BLL


    'End Sub

    Private Sub Estado_Controles(ByVal lbol_Estado As Boolean)

        If ESTADO = True Then

            Me.txtNroRemision.Enabled = False
            cboTipoGR.Enabled = False

            checkGenerar.Checked = False
            checkGenerar.Enabled = False

        Else
            Me.dtpFecGuia.Enabled = lbol_Estado
            Me.txtNroRemision.Enabled = lbol_Estado
        End If


        Me.txtCantMercaderia.Enabled = lbol_Estado

        Me.txtGalsGasolina.Enabled = lbol_Estado
        Me.txtGalsDiesel.Enabled = lbol_Estado
        Me.txtNroHojaGuia.Enabled = lbol_Estado
        Me.txtPesoMercaderia.Enabled = lbol_Estado
        Me.txtPesoBruto.Enabled = lbol_Estado
        Me.rbtnRemitente.Enabled = lbol_Estado
        Me.rbtnDestinatario.Enabled = lbol_Estado

        Me.rbtnIda.Enabled = lbol_Estado
        Me.rbtnIdaVuelta.Enabled = lbol_Estado
        Me.chkMercPerecible.Enabled = lbol_Estado
        Me.chkMercPeligrosa.Enabled = lbol_Estado
        Me.txtVolumenRemision.Enabled = lbol_Estado
        'Me.txtValorPatrimonio.Enabled = lbol_Estado

        Me.txtKmPorRecorrer.Enabled = lbol_Estado

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
        Me.dtpFecGuiaETA.Enabled = lbol_Estado
        Me.dtpFecGuiaETD.Enabled = lbol_Estado
        Me.dtpFecIniTrans.Enabled = lbol_Estado
        txtHoraInicio.Enabled = lbol_Estado

        'btnUbigeoOrigen.Enabled = lbol_Estado
        'btnUbigeoDestino.Enabled = lbol_Estado
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

        'If Val(txtNroRemision.Text.Trim) = 0 OrElse Me.txtNroRemision.TextLength < 7 Then
        '    Dim strLonCad As Int64 = CLng(Me.txtNroRemision.Text).ToString.Length
        '    If strLonCad < 8 Then lstr_validacion += "* GUIA TRANSPORTISTA " & Chr(13)
        'End If


        Dim tipoGuia As String = ("" & cboTipoGR.SelectedValue).ToString.Trim

        Dim GuiaTrans As String = txtNroRemision.Text.Trim.ToUpper

        If GuiaTrans.Contains(" ") Then
            lstr_validacion += "* NGuía no puede tener espacios en blanco " & Chr(13)
        End If


        Select Case tipoGuia
            Case "F"

                If Val(txtNroRemision.Text.Trim) = 0 OrElse Me.txtNroRemision.TextLength < 7 Then
                    Dim strLonCad As Int64 = CLng(Me.txtNroRemision.Text).ToString.Length
                    If strLonCad < 8 Then lstr_validacion += "* GUIA TRANSPORTISTA " & Chr(13)
                End If

            Case "E"

                'If txtNroRemision.Text.Trim.Length < 12 Then
                '    lstr_validacion += "* GUIA TRANSPORTISTA E" & Chr(13)
                'End If
                If txtNroRemision.Text.Trim.Length < 5 Then
                    lstr_validacion += "* GUIA TRANSPORTISTA  (mínimo 5 caracteres)" & Chr(13)
                End If

                'If GuiaTAnexa.Contains(" ") Then
                '    strError += "- Guía no puede tener espacios en blanco." & Chr(13)
                'End If


        End Select


        'End If


        If Val("" & txtLugarOrigen.Tag) = 0 Then
            lstr_validacion += "* LUGAR ORIGEN " & Chr(13)
        End If


        If Val("" & txtLugarDestino.Tag) = 0 Then
            lstr_validacion += "* LUGAR DESTINO " & Chr(13)
        End If

        If Me.txtDirOrigen.TextLength = 0 Then
            lstr_validacion += "* DIRECCION ORIGEN " & Chr(13)
        End If

        If Me.txtDirDestino.TextLength = 0 Then
            lstr_validacion += "* DIRECCION DESTINO " & Chr(13)
        End If


        'If Val("" & txtUbigeoOrigen.Tag) = 0 Then
        '    lstr_validacion += "* ORIGEN UBIGEO " & Chr(13)
        'End If


        'If Val("" & txtUbigeoDestino.Tag) = 0 Then
        '    lstr_validacion += "* DESTINO UBIGEO " & Chr(13)
        'End If

        If Me.txtCantMercaderia.TextLength = 0 OrElse Me.txtCantMercaderia.Text = "0" Then
            lstr_validacion += "* CANTIDAD MERCADERIA " & Chr(13)
        End If

        If chkFlagPeso.Checked = False Then
            If Me.txtPesoMercaderia.TextLength = 0 OrElse Me.txtPesoMercaderia.Text = "0" Then
                lstr_validacion += "* PESO NETO " & Chr(13)
            End If
        Else
            If Me.txtPesoMercaderia.TextLength = 0 Then
                lstr_validacion += "* PESO NETO " & Chr(13)
            End If
        End If
   

        If Objeto_Entidad_Guia.CTRMNC = 0 Then
            lstr_validacion += "* TRANSPORTISTA " & Chr(13)
        End If

        If Objeto_Entidad_Guia.NPLCTR = "" Then
            lstr_validacion += "* TRACTO " & Chr(13)
        End If
        Select Case _MedioTransporte
            Case 4
                If Objeto_Entidad_Guia.CBRCNT = "" Then
                    lstr_validacion += "* BREVETE " & Chr(13)
                End If
        End Select

        If Me._ListaConfiguracion.FindAll(match_Normal).Count = 0 Then
            lstr_validacion += "* NO EXISTE CONFIGURACION" & Chr(13)
        End If
 

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

        If dtpFecGuiaETA.Checked = False Then
            lstr_validacion += "* Ingresa fecha ETA." & Chr(13)
        End If

        If Me.dtpFecGuiaETA.Checked = True Then

            If HelpClass.CtypeDate(Me.dtpFecGuiaETD.Value) > HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value) Then
                lstr_validacion += "* FECHA ESTIMADA DE SALIDA MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
            End If

            If HelpClass.CtypeDate(Me.dtpFecIniTrans.Value) > HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value) Then
                lstr_validacion += "* FECHA TRASLADO MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
            End If
        End If

        If Me.txtHoraInicio.Text = "00:00" Then
            lstr_validacion += "* DEBE INGRESAR HORA DE INICIO DE TRASLADO" & Chr(13)
        End If
        Dim hrainicio As Date
        If DateTime.TryParse(Me.txtHoraInicio.Text, hrainicio) = False Then
            lstr_validacion += "* FORMATO DE HORA DE INICIO DEBE SER CORRECTO" & Chr(13)
        End If


        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
            lbool_existe_error = True
        End If



        Return lbool_existe_error
    End Function

    Private Sub Nuevo_Registro()

        pDialogOK = True

        Dim obj_Entidad As New GuiaTransportista
        Dim obj_Logica As New GuiaTransportista_BLL
 

        obj_Entidad.NCSOTR = pNCSOTR
        obj_Entidad.NCRRSR = pNCRRSR

        obj_Entidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
        obj_Entidad.FGUIRM = HelpClass.CtypeDate(Me.dtpFecGuia.Value)
        obj_Entidad.NPLNMT = Objeto_Entidad_Guia.NPLNMT
        obj_Entidad.CLCLOR = Objeto_Entidad_Guia.CLCLOR
        obj_Entidad.CLCLDS = Objeto_Entidad_Guia.CLCLDS
       
        obj_Entidad.TRFRGU = Me.txtLugar.Text
        obj_Entidad.TDIROR = Me.txtDirOrigen.Text
        obj_Entidad.TDIRDS = Me.txtDirDestino.Text
        obj_Entidad.NOPRCN = CType(Me.txtNroOperacion.Text, Double)
        obj_Entidad.QMRCMC = Me.txtCantMercaderia.Text
        obj_Entidad.PMRCMC = Me.txtPesoMercaderia.Text

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
        'If Me.txtCostoTramo.Text.Trim <> "" Then obj_Entidad.ICSTRM = CType(Me.txtCostoTramo.Text, Double)
        obj_Entidad.ICSTRM = 0
        If Me.txtPesoBruto.Text.Trim <> "" Then obj_Entidad.QPSOBR = CType(Me.txtPesoBruto.Text, Double)
        If Me.txtVolumenRemision.Text.Trim <> "" Then obj_Entidad.QVLMOR = CType(Me.txtVolumenRemision.Text, Double)
        obj_Entidad.SMRPLG = IIf(Me.chkMercPeligrosa.Checked = True, "X", "")
        obj_Entidad.SMRPRC = IIf(Me.chkMercPerecible.Checked = True, "X", "")
        'If Me.txtValorPatrimonio.Text.Trim <> "" Then obj_Entidad.IVLPRT = CType(Me.txtValorPatrimonio.Text, Double)

        obj_Entidad.CMNVLP = 0
       
        obj_Entidad.CCMPN = pCOMPANIA
        obj_Entidad.CDVSN = pDIVISION
        obj_Entidad.CPLNDV = pPLANTA
        obj_Entidad.CULUSA = pUSUARIO
        
        'obj_Entidad.CUBORI = Val("" & txtUbigeoOrigen.Tag)
        'obj_Entidad.CUBDES = Val("" & txtUbigeoDestino.Tag)

        obj_Entidad.FEMVLH = HelpClass.CtypeDate(Me.dtpFecIniTrans.Value)
        obj_Entidad.FECETD = HelpClass.CtypeDate(Me.dtpFecGuiaETD.Value)

        'calculando la fecha de llegada aproximada
  
        obj_Entidad.FECETA = IIf(Me.dtpFecGuiaETA.Checked = True, HelpClass.CtypeDate(Me.dtpFecGuiaETA.Value), 0)

        obj_Entidad.TOBS = Me.txtObservación.Text
        obj_Entidad.TCNFVH = Me.txtConfigTracto.Text.Trim
        obj_Entidad.NOREMB = Me.txtOrdenEmbarcador.Text.Trim
        obj_Entidad.CTPOVJ = Objeto_Entidad_Guia.CTPOVJ
        obj_Entidad.NMVJCS = Objeto_Entidad_Guia.NMVJCS
        obj_Entidad.NMOPMM = Objeto_Entidad_Guia.NMOPMM
        obj_Entidad.NMOPRP = Objeto_Entidad_Guia.NMOPRP

        obj_Entidad.HRAINI = Me.txtHoraInicio.Text.Trim

 
        obj_Entidad.NGUIRM = Val("" & txtNroRemision.Tag)
        obj_Entidad.NGUITS = txtNroRemision.Text.Trim.ToUpper
        obj_Entidad.CTDGRT = cboTipoGR.SelectedValue


        obj_Entidad.FLGAPA = IIf(Me.chkFlagPeso.Checked = True, "X", "")



        Dim msgError As String = ""
        objGuiaTransporte = obj_Entidad

        If ESTADO = False Then

            If Me.checkGenerar.Checked = False Then
                obj_Entidad.GENERAR_GT = ""
            Else
                obj_Entidad.GENERAR_GT = "S"
            End If

            'Objeto_Entidad_Guia.NGUIRM = obj_Logica.Registrar_Guia_Transportista_General(obj_Entidad, msgError).NGUIRM
            Dim RegGuia As New GuiaTransportista
            RegGuia = obj_Logica.Registrar_Guia_Transportista_General(obj_Entidad, msgError)

            If msgError.Length > 0 Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            pNGUITR = RegGuia.NGUIRM


            Objeto_Entidad_Guia.NGUIRM = RegGuia.NGUIRM
            Objeto_Entidad_Guia.NGUITS = RegGuia.NGUITS

            txtNroRemision.Tag = Objeto_Entidad_Guia.NGUIRM ' adicionado 2020
            Me.txtNroRemision.Text = Objeto_Entidad_Guia.NGUITS

           
            If Objeto_Entidad_Guia.NGUIRM <> 0 Then
                

                HelpClass.MsgBox("Se Registró Satisfactoriamente")
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Me.Estado_Controles(False)
                Me.btnGuardar.Enabled = False

                Me.TabMantenimiento.Enabled = True
                Me.checkGenerar.Enabled = False
                Me.btnImprimir.Enabled = True

                cboTipoGR.Enabled = False


                If Me.Tag = 2 Then
                    Me.Agregar_Guia_Transportista_Adicional()
                End If
                
            End If
        Else

            'obj_Logica.Modificar_Guia_Transportista_General(obj_Entidad)

            Dim RegGuia As New GuiaTransportista
            RegGuia = obj_Logica.Registrar_Guia_Transportista_General(obj_Entidad, msgError)

 
            HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
           
        End If
       
    End Sub

 

    Private Sub Agregar_Guia_Transportista_Adicional()

        Dim obj_Entidad As New Detalle_Solicitud_Transporte
        Dim obj_Logica As New GuiaTransportista_BLL
        obj_Entidad.NCSOTR = pNCSOTR
        obj_Entidad.NCRRSR = pNCRRSR
        obj_Entidad.NGUITR = Objeto_Entidad_Guia.NGUIRM
        obj_Entidad.CUSCRT = pUSUARIO
        obj_Entidad.FCHCRT = HelpClass.TodayNumeric
        obj_Entidad.HRACRT = HelpClass.NowNumeric
        obj_Entidad.NTRMCR = ""

        obj_Entidad.CCMPN = Me.pCOMPANIA
        obj_Logica.Agregar_Guia_Transportista_Adicional(obj_Entidad)
       

    End Sub

    

    Private Sub Registro_Ordenes_Compra(ByVal objEntidad As SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga)
        Dim objGuiaOCManifiestoCarga As New GuiaTransportista_BLL
        objGuiaOCManifiestoCarga.Registrar_ManifiestoCarga(objEntidad)

    End Sub

    'Listar_Guias_X_GuiaTransportista
    Private Sub Listar_Guias_x_GuiaTRansportista()

        Dim objEntidad As New GuiaTransportista

        objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
        objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM

        Dim listGRCliente As New List(Of GuiaTransportista)
        Dim listGTAnexo As New List(Of GuiaTransportista)
        Dim listOC As New List(Of SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga)

        Dim dtPesos As New DataTable

        Dim objGuiasTransporte As New GuiaTransportista_BLL
        objGuiasTransporte.Listar_Guias_X_GuiaTransportista(objEntidad, listGRCliente, listGTAnexo, listOC, dtPesos)

        dtgGuiasSeleccionadas.DataSource = listGRCliente
        'LLENANDO EL dtgGuiasSeleccionadas
        If Me.dtgGuiasSeleccionadas.RowCount > 0 Then
            Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : " & Me.dtgGuiasSeleccionadas.RowCount
        Else
            Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : 0"
        End If


        dtgOrdenCompra.DataSource = listOC

        dtgGuiasTransportistaAnexa.DataSource = listGTAnexo

        Lista_ActualizaVistaPeso(dtPesos)
    End Sub

    'Private Sub Listar_Guias_Cliente_Registradas()

    '    Dim objEntidadAnexoGuiaCliente As New GuiaTransportista
    '    Dim objanexoGuiaCliente As New GuiaTransportista_BLL



    '    objEntidadAnexoGuiaCliente.CTRMNC = Objeto_Entidad_Guia.CTRMNC
    '    objEntidadAnexoGuiaCliente.NGUIRM = Objeto_Entidad_Guia.NGUIRM

    '    objEntidadAnexoGuiaCliente.CCMPN = Me.pCOMPANIA


    '    Dim oList As New List(Of GuiaTransportista)
    '    oList = objanexoGuiaCliente.Listar_Guias_Anexas_Cliente(objEntidadAnexoGuiaCliente)

    '    dtgGuiasSeleccionadas.DataSource = oList
    '    'LLENANDO EL dtgGuiasSeleccionadas


    '    If Me.dtgGuiasSeleccionadas.RowCount > 0 Then
    '        Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : " & Me.dtgGuiasSeleccionadas.RowCount
    '    Else
    '        Me.lblNumeroGuias.Text = "Total Guía Remisión Asignada : 0"
    '    End If

    'End Sub

    'Private Sub Listar_Ordenes_Compra(ByVal lstr_Guia_Transporte As Double)
    '    'Para cada guia de remision, traemos las ordenes de compra
    '    Dim objEntidadDetalleCargaRecepcionada As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
    '    Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL


    '    'LIMPIANDO EL dtgOrdenCompra


    '    objEntidadDetalleCargaRecepcionada.CTRMNC = Objeto_Entidad_Guia.CTRMNC
    '    objEntidadDetalleCargaRecepcionada.NGUIRM = Objeto_Entidad_Guia.NGUIRM
    '    objEntidadDetalleCargaRecepcionada.CCLNT = Objeto_Entidad_Guia.CCLNT

    '    objEntidadDetalleCargaRecepcionada.CCMPN = Me.pCOMPANIA

    '    Dim oList As New List(Of SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga)
    '    oList = objDetalleCargaRecepcionada.Listar_Ordenes_Compra_x_MC(objEntidadDetalleCargaRecepcionada)
    '    dtgOrdenCompra.DataSource = oList


    'End Sub

    'Private Sub Listar_Guias_Transportista_Registradas()
    '    Dim objEntidad As New GuiaTransportista
    '    Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL

    '    'LIMPIANDO EL dtgOrdenCompra

    '    objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
    '    objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM

    '    objEntidad.CCMPN = Me.pCOMPANIA

    '    Dim oList As New List(Of GuiaTransportista)
    '    oList = objGuiaTransportistaAdicional.Listar_Guias_Anexas_Transportista(objEntidad)
    '    dtgGuiasTransportistaAnexa.DataSource = oList




    'End Sub

    

    Private Function Validar_Existencia_Orden_Compra() As Boolean
        Dim lbool_Estado As Boolean = False
        For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.RowCount - 1
            If Me.dtgOrdenCompra.Item("NGUICL", lint_Contador).Value.ToString.Trim = Me.cboGuiaRemisionCliente.SelectedItem.ToString.Trim And Me.dtgOrdenCompra.Item("NORCMC", lint_Contador).Value.ToString.Trim = Me.txtOrdenCompra.Text.Trim Then
                HelpClass.MsgBox("Ya existe esta Orden de Compra")
                lbool_Estado = True
                Exit For
            End If
        Next
        Return lbool_Estado
    End Function

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

    Private Sub Cargar_Combo_Guia_Cliente()
        Me.cboGuiaRemisionCliente.Items.Clear()
        For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1
            Me.cboGuiaRemisionCliente.Items.Add(Me.dtgGuiasSeleccionadas.Item("NRGUCL", lint_Contador).Value)
        Next
    End Sub

    Private Sub Cargar_Lista_Configuracion_Vehicular()
        Dim obj_Logica As New GuiaTransportista_BLL
        'Me._ListaConfiguracion = obj_Logica.Listar_Configuracion_Vehicular(Me._COMPANIA)
        Me._ListaConfiguracion = obj_Logica.Listar_Configuracion_Vehicular(Me.pCOMPANIA)
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


        Me.Limpiar_Contenido_Reporte(objReporte)
        Try

            Dim lguia_Transporte As String = objEntidad.NGUIRM
            Dim GuiaTransportistaTxt As String = FormatearDocGuiaRemision(objEntidad.CTDGRT, objEntidad.NGUITS)


            'CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = lguia_Transporte.Substring(0, 3) + " - " + lguia_Transporte.Substring(3)
            CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = GuiaTransportistaTxt
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
        Catch
            HelpClass.ErrorMsgBox()
        End Try

        'retornando el reporte
        'objPrintForm.ShowForm(objReporte, Me)

    End Sub

    Private Function FormatearDocGuiaRemision(Tipo As String, Documento As String) As String
        Dim tamanio As String = Documento.Length
        Select Case Tipo
            Case "F"
                If tamanio <= 10 Then
                    Documento = Documento.PadLeft(10, "0")
                    Documento = Documento.Substring(0, 3) & "-" & Documento.Substring(3, 7)
                End If

            Case "E"
                'If tamanio = 12 Then
                '    Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4, 8)
                'End If
                Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4)
        End Select
        Return Documento
    End Function


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

    Private Sub txtNumeros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantMercaderia.KeyPress, txtKmPorRecorrer.KeyPress, txtNroHojaGuia.KeyPress, txtNroDocConsignatario.KeyPress, txtNroDocRemitente.KeyPress, txtItem.KeyPress, txtCantidad.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtGalsGasolina_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGalsGasolina.KeyPress, txtGalsDiesel.KeyPress, txtPesoMercaderia.KeyPress, txtPesoBruto.KeyPress, txtVolumenRemision.KeyPress
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

 

    Private Sub btnQuitarElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarElemento.Click

        Try
            If Me.dtgGuiasSeleccionadas.RowCount = 0 Then Exit Sub
            Me.dtgGuiasSeleccionadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If Me.Validar_Check_Grilla(Me.dtgGuiasSeleccionadas) = False Then Exit Sub
            If MessageBox.Show("Quitar la Guía de Remision con su Orden de Compra", "Quitar", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub

            Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
            Dim obj_Logica As New GuiaTransportista_BLL
            Dim obj_EntidadGuia As New GuiaTransportista
            Dim lstr_Guia As String = ""
            pDialogOK = True

            

            For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.Rows.Count - 1
                If CBool(Me.dtgGuiasSeleccionadas.Item(0, lint_Contador).FormattedValue) = True Then
                    lstr_Guia = Me.dtgGuiasSeleccionadas.Item("NRGUCL", lint_Contador).Value
                    'Por cada elemento retirado tambien se tienen que 
                    'marcar para eliminar sus correspondientes ordenes de compra
                    obj_EntidadGuia.CTRMNC = Objeto_Entidad_Guia.CTRMNC
                    obj_EntidadGuia.NGUIRM = Objeto_Entidad_Guia.NGUIRM
                    obj_EntidadGuia.NRGUCL = CType(lstr_Guia, Double)
                    obj_EntidadGuia.CCLNT = Me.dtgGuiasSeleccionadas.Item("CCLNT", lint_Contador).Value
                    obj_EntidadGuia.NOPRCN = Me.dtgGuiasSeleccionadas.Item("NOPRCN_D", lint_Contador).Value

                    obj_EntidadGuia.CCMPN = Me.pCOMPANIA
                    obj_EntidadGuia.CULUSA = Me.pUSUARIO
                    obj_Logica.Eliminar_GuiasCliente(obj_EntidadGuia)

                     

                End If
            Next
          
            'Me.Listar_Guias_Cliente_Registradas()
            'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
            Listar_Guias_x_GuiaTRansportista()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAgregarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarOrdenCompra.Click
        Try
            Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
            If Me.cboGuiaRemisionCliente.Text.Equals("") = True Then
                strError += "* GUIA REMISION" & Chr(13)
            End If
            If Me.txtOrdenCompra.Text.Equals("") = True Then
                strError += "* ORDEN DE COMPRA" & Chr(13)
            End If
            If Me.txtItem.Text.Equals("") = True Then
                strError += "* ITEM" & Chr(13)
            End If
            If Me.txtCantidad.Text.Equals("") = True Then
                strError += "* CANTIDAD" & Chr(13)
            End If
            If strError.Trim.Length > 17 Then
                HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If Me.Validar_Existencia_Orden_Compra = True Then Exit Sub

            Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
            objEntidadManifiestoCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidadManifiestoCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
            objEntidadManifiestoCarga.NRGUCL = Me.cboGuiaRemisionCliente.Text.Trim
            objEntidadManifiestoCarga.CCLNT = Objeto_Entidad_Guia.CCLNT
            objEntidadManifiestoCarga.NORCMC = Me.txtOrdenCompra.Text.Trim
            objEntidadManifiestoCarga.NRITOC = CType(Me.txtItem.Text, Int32)
            objEntidadManifiestoCarga.QCNTIT = CType(Me.txtCantidad.Text, Double)
           
            objEntidadManifiestoCarga.CULUSA = USUARIO
            objEntidadManifiestoCarga.NTRMNL = ""

            objEntidadManifiestoCarga.CCMPN = Me.pCOMPANIA
            objEntidadManifiestoCarga.CREFFW = Me.txtBulto.Text.Trim.ToUpper
            objEntidadManifiestoCarga.NSEQIN = 1

            Me.Registro_Ordenes_Compra(objEntidadManifiestoCarga)

            'Limpiando elementos
            Me.cboGuiaRemisionCliente.Text = ""
            Me.txtOrdenCompra.Text = ""
            Me.txtItem.Text = ""
            Me.txtCantidad.Text = ""
            Me.txtBulto.Text = ""

            'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
            Listar_Guias_x_GuiaTRansportista()

            chkOC_CheckedChanged(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

    Private Sub btnEliminarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOrdenCompra.Click
        Try
            If Me.dtgOrdenCompra.RowCount = 0 Then Exit Sub
            Me.dtgOrdenCompra.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If Me.Validar_Check_Grilla(Me.dtgOrdenCompra) = False Then Exit Sub
            If MessageBox.Show("Desea Eliminar esta Orden de Compra", "Eliminar", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub
            Dim objEntidadManifiestoCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
            Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL


            For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.Rows.Count - 1
                If CBool(Me.dtgOrdenCompra.Item(0, lint_Contador).FormattedValue) = True Then
                    objEntidadManifiestoCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
                    objEntidadManifiestoCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
                    objEntidadManifiestoCarga.NRGUCL = Me.dtgOrdenCompra.Item("NGUICL", lint_Contador).Value
                    objEntidadManifiestoCarga.NORCMC = Me.dtgOrdenCompra.Item("NORCMC", lint_Contador).Value
                    objEntidadManifiestoCarga.CCLNT = Objeto_Entidad_Guia.CCLNT
                    objEntidadManifiestoCarga.NRITOC = Me.dtgOrdenCompra.Item("NRITOC", lint_Contador).Value
                    objEntidadManifiestoCarga.NCRRGR = Me.dtgOrdenCompra.Item("NCRRGR", lint_Contador).Value

                    objEntidadManifiestoCarga.CCMPN = Me.pCOMPANIA
                    objEntidadManifiestoCarga.CULUSA = Me.pUSUARIO
                    objEntidadManifiestoCarga.NTRMNL = ""
 
                    objDetalleCargaRecepcionada.Eliminar_Orden_Compra(objEntidadManifiestoCarga)
                End If
            Next


            'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
            Listar_Guias_x_GuiaTRansportista()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub btnAgregarGuiaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGuiaTransportista.Click
        Try
            Dim strError As String = "" ' "DEBE DE INGRESAR: " & Chr(13)
            If Me.txtNroGuiaAnexa.Text.Equals("") = True Then
                strError += "* GUIA TRANSPORTISTA ANEXA" & Chr(13)
            End If
            Dim GuiaTAnexa As String = txtNroGuiaAnexa.Text.Trim.ToUpper

            If GuiaTAnexa.Contains(" ") Then             
                strError += "- Guía no puede tener espacios en blanco." & Chr(13)
            End If


           
            If strError.Length > 0 Then
                MessageBox.Show("Ingresar:" & Chr(13) & strError)
            End If
            Dim guia_anexa As String = Me.txtNroGuiaAnexa.Text.Trim
            Dim fecha As String = Me.dtpFechaGuiaTransportista.Value

            'Averiguando si es que en la lista de elementos seleccionados
            'esta el elemento ingresado
            For i As Integer = 0 To Me.dtgGuiasTransportistaAnexa.RowCount - 1
                
                If (dtgGuiasTransportistaAnexa.Rows(i).Cells("NGTSAD").Value).ToString.Trim = guia_anexa Then
                    HelpClass.MsgBox("Ya esta registrado esta Guia de Transporte Anexa")
                    Exit Sub
                End If
            Next



            Dim objEntidad As New GuiaTransportista
            Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL

            objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidad.SESTRG = "A"
            objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM

            objEntidad.CTDGRT = cboTipoGTAnexo.SelectedValue
            objEntidad.NGTSAD = guia_anexa
            objEntidad.FGUIRM = CType(HelpClass.CtypeDate(Me.dtpFechaGuiaTransportista.Value), Double)
           
            objEntidad.CULUSA = pUSUARIO
            objEntidad.NTRMNL = ""

            objEntidad.CCMPN = Me.pCOMPANIA

            objGuiaTransportistaAdicional.Registrar_GuiaTransportistaAdicional(objEntidad)
            Me.txtNroGuiaAnexa.Text = ""

            'Me.Listar_Guias_Transportista_Registradas()
            Listar_Guias_x_GuiaTRansportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

    Private Sub btnEliminarGuiaTransportista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarGuiaTransportista.Click
        Try
            If Me.dtgGuiasTransportistaAnexa.RowCount = 0 Then Exit Sub
            If MessageBox.Show("Desea Eliminar esta de Guia Transportista Anexa", "Eliminar G. Adicional", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub
            Dim objEntidad As New GuiaTransportista
            Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL

            objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidad.SESTRG = "A"
            objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
            objEntidad.NGUIAD = Me.dtgGuiasTransportistaAnexa.Item("NGUIAD", Me.dtgGuiasTransportistaAnexa.CurrentCellAddress.Y).Value

            objEntidad.CCMPN = Me.pCOMPANIA
            objEntidad.CULUSA = pUSUARIO
            objGuiaTransportistaAdicional.Eliminar_GuiaTransportistaAdicional(objEntidad)
            'Me.Listar_Guias_Transportista_Registradas()
            Listar_Guias_x_GuiaTRansportista()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

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

    Private Sub dtgOrdenCompra_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOrdenCompra.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            Me.dtgOrdenCompra.EndEdit()
            Dim lintEstado As Boolean = Me.dtgOrdenCompra.Item(0, 0).Value
            For lint_Contador As Integer = 0 To Me.dtgOrdenCompra.RowCount - 1

                Me.dtgOrdenCompra.Rows(lint_Contador).Cells("SELECCIONAR_O").Value = Not lintEstado
                Me.dtgOrdenCompra.EndEdit()
            Next

        End If
    End Sub

    Private Sub TabMantenimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabMantenimiento.SelectedIndexChanged
        If Me.TabMantenimiento.SelectedIndex = 1 Then Me.Cargar_Combo_Guia_Cliente()
    End Sub

    Private Sub checkGenerar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGenerar.CheckedChanged

        If ESTADO = True Then Exit Sub
        Select Case Me.checkGenerar.Checked
            Case True
                Me.txtNroRemision.Text = Me._GUIATRANS.ToString
                Me.txtNroRemision.Enabled = False

                Me.dtpFecIniTrans.Enabled = True
            Case False
                Me.txtNroRemision.Enabled = True
                Me.dtpFecIniTrans.Enabled = True
                Me.txtNroRemision.Text = ""

        End Select
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim objEntidad As New GuiaTransportista
        Dim objGuiaTransporte As New GuiaTransportista_BLL
        objEntidad.CTRMNC = Objeto_Entidad_Guia.CTRMNC
        objEntidad.NGUIRM = Objeto_Entidad_Guia.NGUIRM
       
        objEntidad.CCMPN = pCOMPANIA
        objEntidad.CDVSN = pDIVISION
        objEntidad.CPLNDV = pPLANTA
        objEntidad = objGuiaTransporte.Obtener_Guia_Transportista_RPT(objEntidad)
        Me.Reporte_Guia_Transportista(objEntidad)
    End Sub

    Private Sub UcCNomRemitente_InformationChanged() Handles UcCNomRemitente.InformationChanged

        Me.txtDirRemitente.Text = UcCNomRemitente.pDireccionOrigen
        Me.txtNroDocRemitente.Text = UcCNomRemitente.pNroRuc
    End Sub

    Private Sub UcCNomConsignatario_InformationChanged() Handles UcCNomConsignatario.InformationChanged

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

    Private Sub btnVerDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalles.Click
        Try
            If Me.cboGuiaRemisionCliente.Text.Trim = "" Then
                HelpClass.MsgBox("Seleccionar Guía Remisión Cliente", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim objEntidadCarga As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
            objEntidadCarga.CTRMNC = Objeto_Entidad_Guia.CTRMNC
            objEntidadCarga.NGUIRM = Objeto_Entidad_Guia.NGUIRM
            objEntidadCarga.NRGUCL = CType(Me.cboGuiaRemisionCliente.Text.Trim, Int64)
            objEntidadCarga.CCLNT = Buscar_Cliente_Guia_Remision(CType(Me.cboGuiaRemisionCliente.Text.Trim, Int64))
            objEntidadCarga.TCMPCL = lstrCliente
           
            objEntidadCarga.CCMPN = Me.pCOMPANIA
            objEntidadCarga.CDVSN = Me.pDIVISION
            objEntidadCarga.CPLNDV = Me.pPLANTA

            Dim frmDetalleBulto As frmDetalleBultoDia
            frmDetalleBulto = New frmDetalleBultoDia(objEntidadCarga)
            frmDetalleBulto.ShowInTaskbar = False
            frmDetalleBulto.StartPosition = FormStartPosition.CenterScreen
            'frmDetalleBulto.Tag = _USUARIO
            frmDetalleBulto.Tag = USUARIO
            If frmDetalleBulto.ShowDialog() = DialogResult.OK Then
                'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
                Listar_Guias_x_GuiaTRansportista()
            End If
            lstrCliente = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

   

   

    Private Sub dtgGuiasSeleccionadas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGuiasSeleccionadas.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            If Me.dtgGuiasSeleccionadas.RowCount = 0 Then Exit Sub
            Dim lintEstado As Boolean = Me.dtgGuiasSeleccionadas.Item(0, 0).Value
            For lint_Contador As Integer = 0 To Me.dtgGuiasSeleccionadas.RowCount - 1

                Me.dtgGuiasSeleccionadas.Rows(lint_Contador).Cells("SELECCIONA").Value = Not lintEstado
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

    Private Sub btnAsignarGuiaRemAutomatica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarGuiaRemAutomatica.Click
        Try

            Dim objfrmConsultaGuia As New frmConsultaGuia
            With objfrmConsultaGuia
                .Text = "CONSULTA GUIA REMISION CLIENTE"




                .COMPANIA = Me.pCOMPANIA
                .PLANTA = Me.pPLANTA
                .TIPO_GUIA = 0
                .USUARIO = Me.pUSUARIO

                .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
                .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
                .CLIENTE = Objeto_Entidad_Guia.CCLNT
                .TIPO_VIAJE = Me._intTipoViaje
                '.objTable = Me._objTable.Copy
                .Operacion = Me.txtNroOperacion.Text
                .Guia_Transporte = Me.objGuiaTransporte
                .DIVISION = pDIVISION
                .ShowDialog()

                If .pDialogOK = True Then
                    'Me.Listar_Guias_Cliente_Registradas()
                    'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
                    Listar_Guias_x_GuiaTRansportista()


                    pDialogOK = True
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
    End Sub

    Private Sub btnAsignarGuiaRemManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarGuiaRemManual.Click
        Try
            Dim objfrmAsignarGuia As New frmAsignarGuia
            With objfrmAsignarGuia
                
                .COMPANIA = Me.pCOMPANIA
                .PLANTA = Me.pPLANTA

                .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
                .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
                .CLIENTE = Objeto_Entidad_Guia.CCLNT

                .USUARIO = Me.pUSUARIO
                .TIPO_VIAJE = Me._intTipoViaje
                '.objTable = Me._objTable.Copy
                .Operacion = Me.txtNroOperacion.Text
                .Guia_Transporte = Me.objGuiaTransporte
                .ShowDialog()
                If .pDialogOK = True Then
                    'Me.Listar_Guias_Cliente_Registradas()
                    Listar_Guias_x_GuiaTRansportista()
                    pDialogOK = True
                    'Lista_ActualizaVistaPeso()
                End If


            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub


    Sub Lista_ActualizaVistaPeso(dtPesos As DataTable)

      
        Dim totPesoAlmacen As Decimal = dtPesos.Rows(0)("PESO_ALM")
        Dim pesoGT As Decimal = dtPesos.Rows(0)("PESO_GT")
        txtPesoMercaderia.Text = Math.Round(pesoGT, 2)
        pbimage.Image = My.Resources.text_block1
        If pesoGT = totPesoAlmacen Then
            pbimage.Image = My.Resources.verde
            lbldiferencia.Text = ""
        Else
            pbimage.Image = My.Resources.Rojo
            lbldiferencia.ForeColor = Color.Red        
            lbldiferencia.Text = "Diferencia: " & (pesoGT - totPesoAlmacen)
        End If
      
    End Sub


    Private Sub btnAsignarGuiaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarGuiaProveedor.Click
        Try
            Dim objfrmConsultaGuia As New frmConsultaGuia
            With objfrmConsultaGuia
                .Text = "CONSULTA GUIA REMISION PROVEEDOR"
                '.COMPANIA = Me._COMPANIA
                '.PLANTA = Me._PLANTA
                '.TIPO_GUIA = 1
                '.USUARIO = Me._USUARIO
                .COMPANIA = Me.pCOMPANIA
                .PLANTA = Me.pPLANTA
                .TIPO_GUIA = 1
                .USUARIO = Me.pUSUARIO

                .COD_TRANSPORTISTA = Objeto_Entidad_Guia.CTRMNC
                .GUIA_TRANSPORTISTA = Objeto_Entidad_Guia.NGUIRM
                .CLIENTE = Objeto_Entidad_Guia.CCLNT
                .TIPO_VIAJE = Me._intTipoViaje
                '.objTable = Me._objTable.Copy
                .Operacion = Me.txtNroOperacion.Text
                .Guia_Transporte = Me.objGuiaTransporte
                .DIVISION = pDIVISION
                .ShowDialog()
                'If .ShowDialog = DialogResult.Cancel Then
                If .pDialogOK = True Then
                    'Me.Listar_Guias_Cliente_Registradas()
                    'Me.Listar_Ordenes_Compra(Objeto_Entidad_Guia.NGUIRM)
                    Listar_Guias_x_GuiaTRansportista()

                    pDialogOK = True

                End If
            

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub

  

    Private Sub btnCalcularFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularFecha.Click
        Try

            AsignarETA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AsignarETA()

        lblmsg.Text = ""

        If DiasEstimados_ETA = -1 Then
            lblmsg.ForeColor = Color.Red
            lblmsg.Text = "Sin config. para calc. ETA"

        Else
            Dim fecha As Date = Me.dtpFecIniTrans.Value
            Dim qdias As Decimal = DiasEstimados_ETA
            If qdias > 0 Then
                qdias = qdias - 1
            End If
            fecha = fecha.AddDays(qdias)

            dtpFecGuiaETA.Checked = True
            Me.dtpFecGuiaETA.Value = fecha
            lblmsg.Text = "ETA recalculado"
            lblmsg.ForeColor = Color.Blue


        End If
    End Sub


    Private Function CalcularDiasEstimados() As Decimal
        Dim diasEstimados As Decimal = -1
        Dim dt As New DataTable
        Dim objDistancias As New DuracionDias_BLL
        Dim objEntidad As New DuracionDias
        Dim objGuiaTransportista As New GuiaTransportista_BLL
        Dim objEntidadGuiaTransportista As New GuiaTransportista
        objEntidad.CCLNT = Objeto_Entidad_Guia.CCLNT

        objEntidad.CCMPN = Me.pCOMPANIA
        objEntidad.CLCLOR = Objeto_Entidad_Guia.CLCLOR
        objEntidad.CLCLDS = Objeto_Entidad_Guia.CLCLDS
        objEntidad.CMEDTR = Objeto_Entidad_Guia.CMEDTR
        dt = objDistancias.ListarDuracionDias_x_Cliente(objEntidad)
        If dt.Rows.Count > 0 Then
            diasEstimados = dt.Rows(0)("QDSEST")
            'If diasEstimados > 0 Then
            '    'diasEstimados = diasEstimados - 1
            'End If
        End If
        Return diasEstimados
    End Function

    'Private Sub dtpFecGuiaETD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecGuiaETD.ValueChanged
    '    Try
    '        If dtpFecGuiaETD.Focused = False Then
    '            Exit Sub
    '        End If
    '        AsignarETA()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dtpFecIniTrans_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecIniTrans.ValueChanged
        Try
            If dtpFecIniTrans.Focused = False Then
                Exit Sub
            End If
            AsignarETA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOC.CheckedChanged
        Try
            If chkOC.Checked = True Then

                txtBulto.Enabled = False
                txtBulto.Text = ""
                txtItem.Enabled = False
                txtItem.Text = 0
                txtCantidad.Enabled = False
                txtCantidad.Text = 0

            Else
                txtBulto.Enabled = True
                txtItem.Enabled = True
                txtCantidad.Enabled = True
                txtItem.Text = ""
                txtCantidad.Text = ""
            End If
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

     

    Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted
        Try

            txtNroRemision.Text = ""
            checkGenerar.Checked = False

            Dim TipoGuia As String = ("" & cboTipoGR.SelectedValue).ToString.Trim

            Select Case TipoGuia
                Case "F"
                    txtNroRemision.Mask = "000-0000000"
                    If ESTADO = True Then
                        checkGenerar.Checked = False
                        checkGenerar.Enabled = False
                    Else
                        checkGenerar.Checked = False
                        checkGenerar.Enabled = True
                    End If
                

                Case "E"
                    'txtNroRemision.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
                    txtNroRemision.Mask = "LAAA-99999999"
                    checkGenerar.Checked = False
                    checkGenerar.Enabled = False

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cboTipoGTAnexo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGTAnexo.SelectionChangeCommitted
        Try
            txtNroGuiaAnexa.Text = ""
            Dim TipoGuia As String = ("" & cboTipoGTAnexo.SelectedValue).ToString.Trim
            Select Case TipoGuia
                Case "F"
                    txtNroGuiaAnexa.Mask = "000-0000000"
                Case "E"
                    'txtNroGuiaAnexa.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
                    txtNroGuiaAnexa.Mask = "LAAA-99999999"


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub btnUbigeoOrigen_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim ofrmUbigeo As New frmListaUbigeo
    '        If ofrmUbigeo.ShowDialog = DialogResult.OK Then
    '            txtUbigeoOrigen.Tag = ofrmUbigeo.cod_ubigeo
    '            txtUbigeoOrigen.Text = ofrmUbigeo.desc_ubigeo

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub btnUbigeoDestino_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim ofrmUbigeo As New frmListaUbigeo
    '        If ofrmUbigeo.ShowDialog = DialogResult.OK Then
    '            txtUbigeoDestino.Tag = ofrmUbigeo.cod_ubigeo
    '            txtUbigeoDestino.Text = ofrmUbigeo.desc_ubigeo
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub txtNroRemision_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNroRemision.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub btnActualizarPesoGT_Click(sender As Object, e As EventArgs) Handles btnActualizarPesoGT.Click
        Try


            Dim pfrmActualizarPesoNetoGuiaTransportes As New frmActualizarPesoNetoGuiaTransportes

            pfrmActualizarPesoNetoGuiaTransportes.COD_TRANSPORTISTA = Me.pCTRMNC
            pfrmActualizarPesoNetoGuiaTransportes.GUIA_TRANSPORTISTA = txtNroRemision.Tag
            pfrmActualizarPesoNetoGuiaTransportes.pNoprcn = txtNroOperacion.Text.Trim
            'pfrmActualizarPesoNetoGuiaTransportes.USUARIO = Me.pUSUARIO
            'If pfrmActualizarPesoNetoGuiaTransportes.ShowDialog() = DialogResult.OK Then
            pfrmActualizarPesoNetoGuiaTransportes.ShowDialog()
            If pfrmActualizarPesoNetoGuiaTransportes.pDialogOK = True Then
                'Me.Listar_Guias_Cliente_Registradas()
                Dim pesoGuiaT As Decimal = Math.Round(pfrmActualizarPesoNetoGuiaTransportes.pPesoGuiaT, 2)
                Dim pesoAlmacen As Decimal = Math.Round(pfrmActualizarPesoNetoGuiaTransportes.pPesoAlmacen, 2)
                Dim difPeso As Decimal = pesoGuiaT - pesoAlmacen
                lbldiferencia.Text = ""
                If difPeso > 0 Then
                    lbldiferencia.Text = difPeso
                End If
                'lbldiferencia.Text = Math.Round(pesoGuiaT - pesoAlmacen, 2)
                pbimage.Image = My.Resources.text_block1
                If pesoGuiaT = pesoAlmacen Then
                    pbimage.Image = My.Resources.verde
                Else
                    pbimage.Image = My.Resources.Rojo
                End If
                txtPesoMercaderia.Text = pesoGuiaT

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
