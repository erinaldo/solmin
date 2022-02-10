Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text


Enum ModoVisualTarifa
    Almacen = 0
    Flete = 1
End Enum


Public Class frmDefTarifa

    Private oCompania As clsCompania
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oPlantaNeg As SOLMIN_CTZ.NEGOCIO.clsPlanta

    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oServicio As New SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oUM As SOLMIN_CTZ.NEGOCIO.clsUM
    Private oCentroCosto As SOLMIN_CTZ.NEGOCIO.clsCentroCosto
    Private oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
    Private oDetTarTipFlete As New SOLMIN_CTZ.NEGOCIO.clsDetalleTarifaTipoFlete
    Private oRangoTarifaFlete As New SOLMIN_CTZ.NEGOCIO.clsRangoTarifaXTarifaFlete
    Private oNegTarifa As New SOLMIN_CTZ.NEGOCIO.clsTarifa

    Private oTarifa As New SOLMIN_CTZ.Entidades.Tarifa
    Private oContrato As New SOLMIN_CTZ.Entidades.Contrato
    Private oRango As New SOLMIN_CTZ.Entidades.Rango
    Private frmContrato As frmListaTarifas
    Private oTarifaDescripciones As New SOLMIN_CTZ.Entidades.Tarifa
    Private bolGenera As Boolean
    Private bolCarga As Boolean
    Dim lbooEstado As Boolean = True
    Private _ListaRango As New List(Of Tarifa)
    Private obj_tarifa As Tarifa
    Private obj_contrato As Contrato
    Private _isnew As Boolean = False
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private oDsImporteTarifa As New DataSet
    Private intImpInicial As Double = 0
    'RCS-HUNDRED-INICIO
    Private bolClienteInterno As Boolean
    Private intPosY As Integer = 0
    Private intAjusteAltoForm As Integer = 0

    Dim dsMelsap As DataSet
    Private imputCeBe As New beImputCeBe 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private imputCeCo As New beImputCeCo 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    'RCS-HUNDRED-FIN

    Private lbeCeCoTarifario As New List(Of CentroCostoTarifa)

    Private _pCodigoCompania As String = ""

    Private EsRangoTarifaExceso As Boolean = False
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property
    Private _modoVisualTarifa As ModoVisualTarifa

    Enum EnumTipo
        Neutro
        Edicion
        Nuevo
    End Enum
    Private _Tipo As EnumTipo = EnumTipo.Neutro

    Sub New(ByVal pobjfrm As frmListaTarifas, ByVal objTarifa As Object, ByVal objContrato As Object, ByVal objRango As Object, ByVal pEnumTipo As EnumTipo)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frmContrato = pobjfrm
        bolCarga = False
        oTarifa = CType(objTarifa, Tarifa)
        If Not IsNothing(objRango) Then
            oRango = CType(objRango, Rango)
            bolCarga = True
        Else
            _isnew = True
        End If

        oContrato = CType(objContrato, SOLMIN_CTZ.Entidades.Contrato)

        _Tipo = pEnumTipo
    End Sub

 

    Public ReadOnly Property GetTarifa() As Tarifa
        Get
            Return obj_tarifa
        End Get
    End Property

    Private Sub frmDefTarifa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtDescripcion.Width = 925
            'RCS-HUNDRED-INICIO
            Validar_Cliente_Interno()
            Cargar_Datos_Generales_Tarifa_Transporte() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            'RCS-HUNDRED-FIN

            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            cboTipo.DataSource = dsMelsap.Tables("Table6")
            cboTipo.ValueMember = "CODTIPO"
            cboTipo.DisplayMember = "DESCTIPO"
            cboTipo.ComboBox.Enabled = False

            Dim listaSector As New List(Of beSector)
            Dim listaColumnas As New Hashtable

            For Each row As DataRow In dsMelsap.Tables("Table5").Rows
                Dim sector As New beSector
                sector.Cdscsp = row.Item("Cdscsp")
                sector.Tdscsp = row.Item("Tdscsp")
                listaSector.Add(sector)
            Next row

            Dim columna As New DataGridViewTextBoxColumn
            columna.Name = "Cdscsp"
            columna.DataPropertyName = "Cdscsp"
            columna.HeaderText = "Código "
            listaColumnas.Add(1, columna)

            columna = New DataGridViewTextBoxColumn
            columna.Name = "Tdscsp"
            columna.DataPropertyName = "Tdscsp"
            columna.HeaderText = "Sector"
            listaColumnas.Add(2, columna)

           


            txtCeBeDestinoP.TextBox.Enabled = False
            txtCebeDestinoT.TextBox.Enabled = False
            txtCeCoDestinoP.TextBox.Enabled = False
            txtCeCoDestinoT.TextBox.Enabled = False
            txtOrigenP.TextBox.Enabled = False
            txtTerceroP.TextBox.Enabled = False
            txtCeCoOrigenP.TextBox.Enabled = False
            txtCeCoOrigenT.TextBox.Enabled = False
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            'JM


            Dim oFiltroPlanta As New SOLMIN_CTZ.Entidades.Filtro
            ListarTipoTarifa()
            cboTipoTarifa.SelectedValue = "C"
            cboTipoTarifa_SelectionChangeCommitted(cboTipoTarifa, Nothing)

            txtCodTarifa.Text = oTarifa.NRTFSV
            Dim dtPlanta As New DataTable()
            oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
            Crea_Division()
            oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
            oPlantaNeg = New SOLMIN_CTZ.NEGOCIO.clsPlanta
            oUM = New SOLMIN_CTZ.NEGOCIO.clsUM
            oCentroCosto = New SOLMIN_CTZ.NEGOCIO.clsCentroCosto

            oMoneda.Crea_Moneda()
            oUM.Crear_UM()

            oPlantaNeg.Crea_Lista()


            Llenar_Combos()
            Visualizar_Registro_Rango()
            Validar_Servicio()
            Habilitar_Controles_Tarifa(True)

            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
                ListarPlantaXCompania()
                Cargar_CentroBeneficio()
            End If

            If bolCarga Then
                Dim objFiltro As New Filtro
                Dim oDt As New DataTable
                objFiltro.Parametro1 = oTarifa.CCMPN
                objFiltro.Parametro2 = oTarifa.CDVSN
                objFiltro.Parametro3 = oTarifa.NRRUBR
                objFiltro.Parametro4 = oTarifa.NRSRRB
                oDt = oServicio.Lista_Servicio_X_Rubro_X_Compania_Division(objFiltro)
                If oDt.Rows(0).Item("CSRVC").ToString.Trim = "" Then
                    Cargar_Tarifa()
                    If oTarifa.SESTRG = "P" Then
                        Habilitar_Controles_Cabecera_Tarifa_Flete(False)
                        Habilitar_Controles_Tarifa(True)
                    Else
                        Habilitar_Controles_Cabecera_Tarifa_Flete(False)
                        Habilitar_Controles_Tarifa(False)
                    End If

                Else

                    Cargar_Tarifa_Flete()
                    If oTarifa.SESTRG = "P" Then
                        Habilitar_Controles_Cabecera_Tarifa_Flete(False)
                        Habilitar_Controles_Tarifa_Flete(True)

                        If cboTipo.ValueMember <> String.Empty Then
                            Select Case cboTipo.SelectedValue
                                Case "I"
                                    btnCeBeDestinoP.Enabled = False
                                    btnCeBeDestinoT.Enabled = False
                                    btnCeCoDestinoP.Enabled = True
                                    btnCeCoDestinoT.Enabled = True

                                Case "S"
                                    btnCeBeDestinoP.Enabled = True
                                    btnCeBeDestinoT.Enabled = True
                                    btnCeCoDestinoP.Enabled = True
                                    btnCeCoDestinoT.Enabled = True
                            End Select
                        End If

                    Else
                        Habilitar_Controles_Cabecera_Tarifa_Flete(False)
                        Habilitar_Controles_Tarifa_Flete(False)
                    End If

                    End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Habilitar_Controles_Tarifa(ByVal bolEstado As Boolean)

        cboTipoTarifa.ComboBox.Enabled = bolEstado
        txtCantidad.Enabled = bolEstado
        txtMonto.Enabled = bolEstado
        txtDescripcion.Enabled = bolEstado
        txtTarifa.Enabled = bolEstado
        txtPeriodoLibre.Enabled = bolEstado


        txtDiasFacturar.Enabled = bolEstado


        chkPeriodoLibre.Enabled = bolEstado
        cmbUnidadMedida.Enabled = bolEstado
        cmbMoneda.Enabled = bolEstado

        btnGrabarTarifa.Enabled = bolEstado
        ToolStrip1.Enabled = bolEstado
        dtgRangoTarifa.Enabled = bolEstado
        cboLogicaFacturacion.Enabled = bolEstado

        TxtTipoMaterial.Enabled = bolEstado
        txtTipoAlmacen.Enabled = bolEstado
        txtCodTarifaRef.Enabled = bolEstado
        txtDiasdeCorte.Enabled = bolEstado

        cboPlantaFact.Enabled = bolEstado 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        If cboTipoTarifa.SelectedValue = "R" Then
            txtCantidad.Enabled = False
            txtMonto.Enabled = False
            txtMonto.Text = ""
        End If

        '<[AHM]>
        txtTipoServicio.Enabled = bolEstado
        txtUnidadProductiva.Enabled = bolEstado
        cboTipoActivo.Enabled = bolEstado
        cmbCentroBeneficio.Enabled = bolEstado
        '</[AHM]>
        Habilitar_CentCosto_Cliente_Interno(bolEstado) 'RCS-HUNDRED
    End Sub

    Private Sub Habilitar_Controles_Cabecera_Tarifa_Flete(ByVal bolEstado As Boolean)
        UcDivision.pHabilitado = bolEstado
        UcPLanta_Cmb011.pHabilitado = bolEstado
        cboServicio.Enabled = bolEstado
        cboClienteOp.Enabled = bolEstado
        UcCliente.Enabled = bolEstado
    End Sub

    Private Sub Habilitar_Controles_Tarifa_Flete(ByVal bolEstado As Boolean)
       
        cboLogicaFacturacion.Enabled = bolEstado

        cboParametroFacturar.Enabled = bolEstado
        cboTipoServicioTransp.Enabled = bolEstado

        cboParametroPagar.Enabled = bolEstado
        cboTipoSubServicio.Enabled = bolEstado
        cboSectorxGasto.Enabled = bolEstado
        cboSeguroCotizacion.Enabled = bolEstado
        txtCantidadMercaderia.Enabled = bolEstado
        cboUnidadMedida.Enabled = bolEstado
        cboMercaderia.Enabled = bolEstado
        txtPolizaSeguro.Enabled = bolEstado
        txtPesoMercaderia.Enabled = bolEstado
        cboUnidadVehicular.Enabled = bolEstado
        cboCompaniaSeguro.Enabled = bolEstado
        txtValorMercaderia.Enabled = bolEstado
        txtRecargoSeguro.Enabled = bolEstado
        txtVolumen.Enabled = bolEstado
        txtReferenciaMerc.Enabled = bolEstado
        btnGrabarTarifa.Enabled = bolEstado
        ToolStrip2.Enabled = bolEstado
        chkFleteZonaPrimaria.Enabled = bolEstado
        chkServicioAfecto.Enabled = bolEstado


        '<[AHM]>
        txtTipoServicioTransporte.Enabled = bolEstado
        txtUnidadProductivaTransporte.Enabled = bolEstado
        
        '</[AHM]>
        'RCS-HUNDRED-INICIO
        cboNivelServ.Enabled = bolEstado
        cboParametroTarifaInterna.Enabled = bolEstado
        cboTipoCargaTransporte.Enabled = bolEstado
        
        txtOrigenP.Enabled = bolEstado

        txtCeCoOrigenP.Enabled = bolEstado
        btnCeCoOrigenP.Enabled = bolEstado
        txtTerceroP.Enabled = bolEstado

        txtCeCoOrigenT.Enabled = bolEstado
        BtnCeCoOrigenT.Enabled = bolEstado
        'RCS-HUNDRED-FIN

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        cboPlantaFact.Enabled = bolEstado
        btnCeBeDestinoP.Enabled = bolEstado
        btnCeBeDestinoT.Enabled = bolEstado
        btnCeCoDestinoP.Enabled = bolEstado
        btnCeCoDestinoT.Enabled = bolEstado
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

    End Sub

    Private Sub Cargar_Tarifa_Flete()
        'Cargar Tarifa
        Dim objTarifa As New Tarifa
        objTarifa.CCMPN = oTarifa.CCMPN
        objTarifa.NRCTSL = oTarifa.NRCTSL
        objTarifa.NRTFSV = oTarifa.NRTFSV
        objTarifa = oNegTarifa.Obtener_Tarifa_Flete_RZSC03(objTarifa)
        txtCodTarifa.Text = objTarifa.NRTFSV
        UcDivision.DivisionDefault = objTarifa.CDVSN
        UcDivision.pActualizar()
        UcPLanta_Cmb011.CodigoCompania = objTarifa.CCMPN
        UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
        UcPLanta_Cmb011.PlantaDefault = objTarifa.CPLNDV
        UcPLanta_Cmb011.pActualizar()

        cboClienteOp.Valor = objTarifa.CCLNT
        cboServicio.Valor = objTarifa.COD_SERV

        Me.cboLogicaFacturacion.Valor = oTarifa.NRRELF
        UcCliente.pCargar(objTarifa.CCLNFC)

        cboSectorxGasto.Valor = objTarifa.SSCGST
        cboMercaderia.Valor = objTarifa.CMRCDR
        cboUnidadVehicular.Valor = objTarifa.CTPUNV
        cboParametroFacturar.Valor = objTarifa.CFRMPG
        cboParametroPagar.Valor = objTarifa.CFRAPG
        cboSeguroCotizacion.Valor = objTarifa.SSGRCT
        txtPolizaSeguro.Text = IIf(objTarifa.NPLSGC = "0", "0", objTarifa.NPLSGC)
        cboCompaniaSeguro.Valor = objTarifa.CCMPSG
        txtRecargoSeguro.Text = IIf(objTarifa.QPRCS1 = 0, "0", objTarifa.QPRCS1.ToString.Trim)
        cboTipoServicioTransp.Valor = objTarifa.CTPOSR
        txtCantidadMercaderia.Text = IIf(objTarifa.QMRCDR = 0, "0", objTarifa.QMRCDR.ToString.Trim)
        cboUnidadMedida.Valor = objTarifa.CUNDMD
        txtValorMercaderia.Text = IIf(objTarifa.VMRCDR = 0, "0", objTarifa.VMRCDR.ToString.Trim)
        txtVolumen.Text = IIf(objTarifa.LMRCDR = 0, "0", objTarifa.VMRCDR.ToString.Trim)
        txtReferenciaMerc.Text = objTarifa.TRFMRC
        txtPesoMercaderia.Text = IIf(objTarifa.PMRCDR = 0, "0", objTarifa.PMRCDR.ToString.Trim)
        cboTipoSubServicio.Valor = objTarifa.CTPSBS
        Me.chkFleteZonaPrimaria.Checked = IIf(objTarifa.SFLZNP.ToString.Equals("X"), True, False)
        Me.chkServicioAfecto.Checked = IIf(objTarifa.SFSANF.ToString.Equals("1"), True, False)
        '<[AHM]>

        cboPlantaFact.Valor = objTarifa.CPLNFC 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        txtTipoServicioTransporte.Valor = objTarifa.CDTSSP
        txtUnidadProductivaTransporte.Valor = objTarifa.CDUPSP
   

        cboTipo.SelectedValue = objTarifa.FTCLNT.Trim


        txtCeCoOrigenP.Tag = objTarifa.CENCO2.ToString.Trim
        txtCeCoOrigenP.Text = objTarifa.CECO_OR_P_DESC.ToString.Trim
        txtOrigenP.Tag = objTarifa.CCNTBN.ToString.Trim
        txtOrigenP.Text = objTarifa.CEBE_OR_P_DESC.ToString.Trim

        txtCeCoOrigenT.Tag = objTarifa.CENCO3.ToString.Trim
        txtCeCoOrigenT.Text = objTarifa.CECO_OR_T_DESC.ToString.Trim
        txtTerceroP.Tag = objTarifa.CCNTB1.ToString.Trim
        txtTerceroP.Text = objTarifa.CEBE_OR_T_DESC.ToString.Trim


        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        cboTipoCargaTransporte.Valor = objTarifa.CTIPCG.ToString.Trim
        txtCeBeDestinoP.Tag = Trim(objTarifa.CCNTCS)
        txtCeBeDestinoP.Text = Trim(objTarifa.CEBEP_D)
        txtCebeDestinoT.Tag = trim(objTarifa.CCNCS1)
        txtCebeDestinoT.Text = Trim(objTarifa.CEBET_D)

        txtCeCoDestinoP.Tag = trim(objTarifa.CENCOS)
        txtCeCoDestinoP.Text = Trim(objTarifa.CECOP_D)
        txtCeCoDestinoT.Tag = trim(objTarifa.CENCO1)
        txtCeCoDestinoT.Text = Trim(objTarifa.CECOT_D)
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        


        cboParametroTarifaInterna.Valor = objTarifa.CPATIN
        cboNivelServ.Valor = objTarifa.CTTRAN.ToString.Trim

        'RCS-HUNDRED-FIN
        Listar_Detalle_Tarifa_Tipo_Flete()
    End Sub

    Private Sub Listar_Detalle_Tarifa_Tipo_Flete()
        Dim objDetTarTipFlete As New DetalleTarifaTipoFlete
        objDetTarTipFlete.CCMPN = oTarifa.CCMPN
        objDetTarTipFlete.NRCTSL = oTarifa.NRCTSL
        objDetTarTipFlete.NRTFSV = oTarifa.NRTFSV
        objDetTarTipFlete.SESTRG = oTarifa.SESTRG

        dtgTarifaFleteRuta.AutoGenerateColumns = False
        Dim olDetTarTipFlete As New List(Of DetalleTarifaTipoFlete)

        olDetTarTipFlete = oDetTarTipFlete.Listar_Detalle_Tarifa_Tipo_Flete(objDetTarTipFlete)
        Me.dtgTarifaFleteRuta.AutoGenerateColumns = False
        For Each obeDeralleTarifa As DetalleTarifaTipoFlete In olDetTarTipFlete
            Dim objEntidad As New RangoTarifaXTarifaFlete
            Dim lobjRangoTarifaXTarifaFlete As New List(Of RangoTarifaXTarifaFlete)
            objEntidad.CCMPN = oTarifa.CCMPN
            objEntidad.NRCTSL = oTarifa.NRCTSL
            objEntidad.NRTFSV = oTarifa.NRTFSV
            objEntidad.NCRRSR = obeDeralleTarifa.NCRRSR
            objEntidad.SESTRG = oTarifa.SESTRG
            obeDeralleTarifa.RangoTarifa = oRangoTarifaFlete.Listar_Rango_Tarifa_X_Tarifa_Flete(objEntidad)
        Next
        Me.dtgTarifaFleteRuta.DataSource = olDetTarTipFlete
    End Sub


    Private Function EsParametroRangosExceso() As Boolean
        Dim validacion As Boolean = False
        Dim param_Cobro As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim param_Pago As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim param_TarifaInt As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        If cboParametroFacturar.Resultado IsNot Nothing Then
            param_Cobro = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            param_Cobro = 0
        End If

        If cboParametroPagar.Resultado IsNot Nothing Then
            param_Pago = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            param_Pago = 0
        End If

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        Dim drRangoAdic() As DataRow
        drRangoAdic = dsMelsap.Tables("Table8").Select("DESCTIPO='" & param_Cobro & "' OR DESCTIPO='" & param_Pago & "' OR DESCTIPO='" & param_TarifaInt & "'")

        If drRangoAdic.Length > 0 Then
            validacion = True
        Else
            validacion = False
        End If
        Return validacion
    End Function

    Private Function EsParametroRangos() As Boolean
        Dim validacion As Boolean = False
        Dim param_Cobro As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim param_Pago As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim param_TarifaInt As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        If cboParametroFacturar.Resultado IsNot Nothing Then
            param_Cobro = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            param_Cobro = 0
        End If

        If cboParametroPagar.Resultado IsNot Nothing Then
            param_Pago = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            param_Pago = 0
        End If

        'RCS-HUNDRED-INICIO
        If cboParametroTarifaInterna.Resultado IsNot Nothing Then
            param_TarifaInt = CType(cboParametroTarifaInterna.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            param_TarifaInt = 0
        End If
        'RCS-HUNDRED-FIN

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim drReg() As DataRow
        drReg = dsMelsap.Tables("Table7").Select("DESCTIPO='" & param_Cobro & "' OR DESCTIPO='" & param_Pago & "' OR DESCTIPO='" & param_TarifaInt & "'")

        If drReg.Length > 0 Then
            validacion = True
        Else
            validacion = False
        End If

        Return validacion
    End Function
    Private Sub Visualizar_Registro_Rango() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
       
        EsRangoTarifaExceso = EsParametroRangosExceso()
        Dim EsTarifaRango As Boolean = EsParametroRangos()

        If EsRangoTarifaExceso = True Or EsTarifaRango = True Then
            dtgImporte.Visible = True
            Split0003.Panel2Collapsed = False
        Else
            Split0003.Panel2Collapsed = True
        End If



    
    End Sub

    Private Sub ListarTipoTarifa()

        Dim dt As New DataTable
        dt.Columns.Add("DISPLAY")
        dt.Columns.Add("VALUE")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("DISPLAY") = "Fija"
        dr("VALUE") = "F"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Cantidad"
        dr("VALUE") = "C"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Rango"
        dr("VALUE") = "R"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Días Permanencia"
        dr("VALUE") = "D"
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "Día/Semana de permanencia"
        dr("VALUE") = "S"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "Día/Quincena de permanencia"
        dr("VALUE") = "Q"
        dt.Rows.Add(dr)


        dr = dt.NewRow
        dr("DISPLAY") = "Día/Mes de permanencia"
        dr("VALUE") = "M"
        dt.Rows.Add(dr)


        For Each Item As DataRow In dt.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next

        cboTipoTarifa.DataSource = dt
        cboTipoTarifa.DisplayMember = "DISPLAY"
        cboTipoTarifa.ValueMember = "VALUE"

    End Sub

    Private Sub Crea_Division()

        UcDivision.Compania = oTarifa.CCMPN
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

    End Sub

  

    Private Sub ListarLogicaFacturacion()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO_LF"
        oColumnas.DataPropertyName = "CODIGO_LF"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "FORMULA_LF"
        oColumnas.DataPropertyName = "FORMULA_LF"
        oColumnas.HeaderText = "Fórmula"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMBRE_LF"
        oColumnas.DataPropertyName = "NOMBRE_LF"
        oColumnas.HeaderText = "Nombre"
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESCRIPCION_LF"
        oColumnas.DataPropertyName = "DESCRIPCION_LF"
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(4, oColumnas)


        Dim olLogFac As New List(Of mantenimientos.ClaseGeneral)
        olLogFac = oClaseGeneral.Listar_Logica_Facturacion(oContrato.CRGVTA)

        If olLogFac.Count > 0 Then
            cboLogicaFacturacion.DataSource = olLogFac
        Else
            cboLogicaFacturacion.DataSource = Nothing
        End If
        cboLogicaFacturacion.ListColumnas = oListColum
        cboLogicaFacturacion.Cargas()
        cboLogicaFacturacion.Limpiar()
        cboLogicaFacturacion.ValueMember = "CODIGO_LF"
        cboLogicaFacturacion.DispleyMember = "NOMBRE_LF"

        
    End Sub

    Private Sub ListarServicio()


        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        oFiltro.Parametro1 = oTarifa.CCMPN
        oFiltro.Parametro2 = UcDivision.Division

        cboServicio.ListColumnas = Nothing

        cboServicio.DataSource = Nothing

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn



        oColumnas.Name = "COD_SERV"
        oColumnas.DataPropertyName = "COD_SERV"
        oColumnas.HeaderText = "CÓDIGO"
        oColumnas.Visible = False
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NRSRRB"
        oColumnas.DataPropertyName = "NRSRRB"
        oColumnas.HeaderText = "Cod. Servicio"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMSER"
        oColumnas.DataPropertyName = "NOMSER"
        oColumnas.HeaderText = "Servicio"
        oListColum.Add(3, oColumnas)


        Dim olRubxServ As New List(Of Servicio_X_Rubro)
        olRubxServ = oServicioNeg.Lista_Servicio_X_Compania_Division(oFiltro)

        'Se esta cargando la planta por defecto 1 (CAllao)
        If olRubxServ.Count > 0 Then
            cboServicio.DataSource = olRubxServ
        Else
            cboServicio.DataSource = Nothing
        End If
        cboServicio.ListColumnas = oListColum
        cboServicio.Cargas()
        cboServicio.Limpiar()
        cboServicio.ValueMember = "COD_SERV"
        cboServicio.DispleyMember = "NOMSER"
       
    End Sub

     


    Private Sub Llenar_Combos()
        Me.UcDivision.pHabilitado = True
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.pRequerido = True
        Me.UcDivision.pRequerido = True
        bolGenera = False
        '====================Cargar Servicio====================
       
        Cargar_ClienteOp()
        Cargar_Moneda()

        Cargar_UnidadMedida()
         
        ListarServicio()
        ListarLogicaFacturacion()
        Cargar_Mercaderia()
        Cargar_UnidadVehicular()
        Cargar_ParametroFacturarPagar()
        Cargar_Seguro_Cotizacion()
        Cargar_Compania_Seguro()
        Cargar_Tipo_Servicio_Transp()
        Cargar_Tipo_SubServicio()

        CargarTipoMaterial()
        CargarTipoAlmacen()

 
        Cargar_SectorXGastos()


        bolGenera = True
        
        '<[AHM]>
        Me.Listar_TipoActivo_SAP()
        '</[AHM]>
        Cargar_CentroCosto_Origen() 'RCS-HUNDRED
    End Sub

    Private Sub Cargar_Tipo_Servicio_Transp()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CTPOSR"
        oColumnas.DataPropertyName = "CTPOSR"
        oColumnas.HeaderText = "Codigo"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMTPS"
        oColumnas.DataPropertyName = "TCMTPS"
        oColumnas.HeaderText = "Tipo Servicio Transp."
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TABTPS"
        oColumnas.DataPropertyName = "TABTPS"
        oColumnas.HeaderText = "Abrev. Tipo Servicio Trnsp."
        oListColum.Add(3, oColumnas)

        'RCS-HUNDRED-INICIO
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CDUPSP"
        oColumnas.DataPropertyName = "CDUPSP"
        oColumnas.HeaderText = "CDUPSP"
        oColumnas.Visible = False
        oListColum.Add(4, oColumnas)
        'RCS-HUNDRED-FIN
        Dim olTipSerTrsp As New List(Of mantenimientos.ClaseGeneral)

        olTipSerTrsp = oClaseGeneral.Listar_Tipo_Servicio_Transp()
        If olTipSerTrsp.Count > 0 Then
            cboTipoServicioTransp.DataSource = olTipSerTrsp
        Else
            cboTipoServicioTransp.DataSource = Nothing
        End If
        cboTipoServicioTransp.ListColumnas = oListColum
        cboTipoServicioTransp.Cargas()
        cboTipoServicioTransp.Limpiar()
        cboTipoServicioTransp.ValueMember = "CTPOSR"
        cboTipoServicioTransp.DispleyMember = "TCMTPS"
        
    End Sub

    Private Sub Cargar_ClienteOp()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCLNT"
        oColumnas.DataPropertyName = "CCLNT"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPCL"
        oColumnas.DataPropertyName = "TCMPCL"
        oColumnas.HeaderText = "Razón social"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMTVBJ"
        oColumnas.DataPropertyName = "TMTVBJ"
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(3, oColumnas)


        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        Dim obrContrato As New clsContrato

        oContrato.CCMPN = oTarifa.CCMPN
        oContrato.NRCTSL = oTarifa.NRCTSL
        cboClienteOp.DataSource = obrContrato.flisCargarClienteXContrato(oContrato)
        cboClienteOp.ListColumnas = oListColum
        cboClienteOp.Cargas()
        cboClienteOp.Limpiar()
        cboClienteOp.ValueMember = "CCLNT"
        cboClienteOp.DispleyMember = "TCMPCL"
      
    End Sub

    Private Sub Cargar_Moneda()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CMNDA1"
        oColumnas.DataPropertyName = "CMNDA1"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMNDA"
        oColumnas.DataPropertyName = "TMNDA"
        oColumnas.HeaderText = "Moneda"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TSGNMN"
        oColumnas.DataPropertyName = "TSGNMN"
        oColumnas.HeaderText = "Símbolo"
        oListColum.Add(3, oColumnas)

        Dim olMoneda As New List(Of Moneda)
        olMoneda = oMoneda.Listar_Moneda()

        If olMoneda.Count > 0 Then
            cmbMoneda.DataSource = olMoneda
        Else
            cmbMoneda.DataSource = Nothing
        End If
        cmbMoneda.ListColumnas = oListColum
        cmbMoneda.Cargas()
        cmbMoneda.Limpiar()
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DispleyMember = "TSGNMN"
        
    End Sub

    Private Sub Cargar_UnidadMedida()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CUNDMD"
        oColumnas.DataPropertyName = "CUNDMD"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPUN"
        oColumnas.DataPropertyName = "TCMPUN"
        oColumnas.HeaderText = "Unidad de Medida"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "CUNDMD"
        oColumnas2.DataPropertyName = "CUNDMD"
        oColumnas2.HeaderText = "Código"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "TCMPUN"
        oColumnas2.DataPropertyName = "TCMPUN"
        oColumnas2.HeaderText = "Unidad de Medida"
        oListColum2.Add(2, oColumnas2)

        

        Dim olUM As New List(Of mantenimientos.ClaseGeneral)
        olUM = oUM.Listar_UnidadMedida()


        If olUM.Count > 0 Then
            cboUnidadMedida.DataSource = olUM
        Else
            cboUnidadMedida.DataSource = Nothing
        End If
        cboUnidadMedida.ListColumnas = oListColum
        cboUnidadMedida.Cargas()
        cboUnidadMedida.Limpiar()
        cboUnidadMedida.ValueMember = "CUNDMD"
        cboUnidadMedida.DispleyMember = "TCMPUN"
        ' Else
        If olUM.Count > 0 Then
            cmbUnidadMedida.DataSource = olUM
        Else
            cmbUnidadMedida.DataSource = Nothing
        End If
        cmbUnidadMedida.ListColumnas = oListColum2
        cmbUnidadMedida.Cargas()
        cmbUnidadMedida.Limpiar()
        cmbUnidadMedida.ValueMember = "CUNDMD"
        cmbUnidadMedida.DispleyMember = "TCMPUN"

         
    End Sub

    Private Sub Cargar_CentroBeneficio()
        Dim oListColum, oListColum2, oListColum3 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone()) 'RCS-HUNDRED
        oListColum3.Add(1, oColumnas.Clone()) 'RCS-HUNDRED

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Beneficio"
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone()) 'RCS-HUNDRED
        oListColum3.Add(2, oColumnas.Clone()) 'RCS-HUNDRED


        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCNBNS"
        oColumnas.DataPropertyName = "PSCCNBNS"
        oColumnas.HeaderText = "Ce.Be SAP"
        oListColum.Add(3, oColumnas)
        oListColum2.Add(3, oColumnas.Clone())
        oListColum3.Add(3, oColumnas.Clone())


        Dim olCentroCosto As New List(Of CentroCosto)
        Dim olCentroCostoTercero As New List(Of CentroCosto)

        Dim tarifa As Tarifa = oTarifa
        Dim macroServicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
        Dim TipoServicio As ClaseGeneral = CType(txtTipoServicio.Resultado, ClaseGeneral)
        Dim TipoActivo As ClaseGeneral = CType(cboTipoActivo.SelectedItem, ClaseGeneral)
        Dim UnidadProductiva As ClaseGeneral = CType(txtUnidadProductiva.Resultado, ClaseGeneral)

        Dim tipoServicioTransporte As ClaseGeneral = CType(txtTipoServicioTransporte.Resultado, ClaseGeneral)
        Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral)

        Dim codTipoServicioSAP As String = ""
        Dim codUnidadProdcutivaSAP As String = ""
        Dim codRegionVentaSAP As String = oContrato.CRGVTA

        If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
            olCentroCosto = oCentroCosto.Lista_CentroBeneficio(tarifa.CCMPN, "", "", "", "", "", "", "")  'JM
            cmbCentroBeneficio.DataSource = olCentroCosto
        Else

            Dim codSedeSAP As String = "" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            If (_modoVisualTarifa <> ModoVisualTarifa.Flete) Then
                If (TipoServicio Is Nothing) Then Exit Sub
                If (UnidadProductiva Is Nothing) Then Exit Sub

                codTipoServicioSAP = TipoServicio.CDTSSP
                codUnidadProdcutivaSAP = UnidadProductiva.CDUPSP
                codRegionVentaSAP = oContrato.CRGVTA
                codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Else 'IGUAL A FLETE
                If (tipoServicioTransporte Is Nothing OrElse tipoServicioTransporte.CDTSSP = "") Then Exit Sub 'RCS-HUNDRED
                If (unidadProductivaTransporte Is Nothing OrElse unidadProductivaTransporte.CDUPSP = "") Then Exit Sub 'RCS-HUNDRED
                If (UcCliente.pNegocio = "") Then Exit Sub 'RCS-HUNDRED
                If cboPlantaFact.Resultado Is Nothing Then Exit Sub

                codTipoServicioSAP = tipoServicioTransporte.CDTSSP
                codUnidadProdcutivaSAP = unidadProductivaTransporte.CDUPSP
                codRegionVentaSAP = UcCliente.pNegocio
                codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            End If

            Dim codCompania = tarifa.CCMPN
            Dim codMacroServicioSAP As String = macroServicio.CDSRSP
            Dim codTipoActivoSAP As String = TipoActivo.PRCODI
            'Dim codSedeSAP As String = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim tipoCentroSAP As String = Obtener_Dato_General("TIPOCENTROSAP", "CB").CODREL 'RCS-HUNDRED

            If (_modoVisualTarifa <> ModoVisualTarifa.Flete) Then
                olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
            Else 'IGUAL A FLETE

                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                codSedeSAP = CType(cboPlantaFact.Resultado, bePlanta).Cdspsp
                With imputCeBe
                    .CodCompania = codCompania
                    .CodRegionVentaSAP = codRegionVentaSAP
                    .CodMacroServicioSAP = codMacroServicioSAP
                    .CodTipoServicioSAP = codTipoServicioSAP
                    .CodSedeSAP = codSedeSAP
                    .CodUnidadProdcutivaSAP = codUnidadProdcutivaSAP
                    .TipoCentroSAP = tipoCentroSAP
                End With
                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                codTipoActivoSAP = Obtener_Dato_General("TIPOACTIVOSAP", "1").CODREL 'RCS-HUNDRED
                imputCeBe.CodTipoActivoSAP = codTipoActivoSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                If cboTipo.SelectedValue = "S" And olCentroCosto.Count > 0 Then
                    txtCeBeDestinoP.Tag = olCentroCosto.Item(0).PNCCNTCS
                    txtCeBeDestinoP.Text = olCentroCosto.Item(0).CEBE
                End If


                codTipoActivoSAP = Obtener_Dato_General("TIPOACTIVOSAP", "2").CODREL 'RCS-HUNDRED
                imputCeBe.CodTipoActivoSAP_T = codTipoActivoSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                olCentroCostoTercero = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
                If cboTipo.SelectedValue = "S" And olCentroCosto.Count > 0 Then
                    txtCebeDestinoT.Tag = olCentroCostoTercero.Item(0).PNCCNTCS
                    txtCebeDestinoT.Text = olCentroCostoTercero.Item(0).CEBE
                End If
                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            End If

            If olCentroCosto.Count > 0 Then
                
                cmbCentroBeneficio.DataSource = olCentroCosto 'RCS-HUNDRED
            Else
               
                cmbCentroBeneficio.DataSource = Nothing 'RCS-HUNDRED
            End If
            
        End If

        'RCS-HUNDRED-INICIO
        cmbCentroBeneficio.ListColumnas = oListColum3
        cmbCentroBeneficio.Cargas()
        cmbCentroBeneficio.ValueMember = "PNCCNTCS"
        cmbCentroBeneficio.DispleyMember = "PSTCNTCS"
        'RCS-HUNDRED-FIN

    End Sub


    Private Sub Cargar_Mercaderia()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CMRCDR"
        oColumnas.DataPropertyName = "CMRCDR"
        oColumnas.HeaderText = "Cod. Mercadería"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMRCD"
        oColumnas.DataPropertyName = "TCMRCD"
        oColumnas.HeaderText = "Mercadería"
        oListColum.Add(2, oColumnas)

        Dim olMercaderia As New List(Of mantenimientos.ClaseGeneral)


        olMercaderia = oClaseGeneral.Listar_Mercaderia()

        If olMercaderia.Count > 0 Then
            cboMercaderia.DataSource = olMercaderia
        Else
            cboMercaderia.DataSource = Nothing
        End If
        cboMercaderia.ListColumnas = oListColum
        cboMercaderia.Cargas()
        cboMercaderia.Limpiar()
        cboMercaderia.ValueMember = "CMRCDR"
        cboMercaderia.DispleyMember = "TCMRCD"

      

    End Sub



    Private Sub CargarTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "CTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "TALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)

        txtTipoAlmacen.DataSource = oClaseGeneral.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "CTPALM"
        txtTipoAlmacen.DispleyMember = "TALMC"
    End Sub

    Private Sub CargarTipoMaterial()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "CCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "TDSDES"
        oColumnas.HeaderText = "Tipo Movimiento "
        oListColum.Add(2, oColumnas)



        TxtTipoMaterial.DataSource = oClaseGeneral.ListaTipoDeMaterial()
        TxtTipoMaterial.ListColumnas = oListColum
        TxtTipoMaterial.Cargas()
        TxtTipoMaterial.ValueMember = "CCMPRN"
        TxtTipoMaterial.DispleyMember = "TDSDES"

    End Sub
    Private Sub Cargar_UnidadVehicular()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPUNV"
        oColumnas.DataPropertyName = "CTPUNV"
        oColumnas.HeaderText = "Codigo"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TUNDVH"
        oColumnas.DataPropertyName = "TUNDVH"
        oColumnas.HeaderText = "Unidad Vehicular"
        oListColum.Add(2, oColumnas)

        Dim olUniVeh As New List(Of mantenimientos.ClaseGeneral)
        olUniVeh = oClaseGeneral.Listar_Unidad_Transporte()

        If olUniVeh.Count > 0 Then
            cboUnidadVehicular.DataSource = olUniVeh
        Else
            cboUnidadVehicular.DataSource = Nothing
        End If
        cboUnidadVehicular.ListColumnas = oListColum
        cboUnidadVehicular.Cargas()
        cboUnidadVehicular.Limpiar()
        cboUnidadVehicular.ValueMember = "CTPUNV"
        cboUnidadVehicular.DispleyMember = "TUNDVH"

       
    End Sub

    Private Sub Cargar_ParametroFacturarPagar()

        'RCS-HUNDRED-INICIO
        Dim oListColum, oListColum2, oListColum3 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CFRMPG"
        oColumnas.DataPropertyName = "CFRMPG"
        oColumnas.HeaderText = "Codigo"
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone())
        oListColum3.Add(1, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMFRP"
        oColumnas.DataPropertyName = "TCMFRP"
        oColumnas.HeaderText = "Parametro Facturar"
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone())
        oListColum3.Add(2, oColumnas.Clone())
        'RCS-HUNDRED-FIN

        Dim olParFac As New List(Of mantenimientos.ClaseGeneral)
        olParFac = oClaseGeneral.Listar_Parametros_Facturacion()

        If olParFac.Count > 0 Then
            cboParametroFacturar.DataSource = olParFac
            cboParametroPagar.DataSource = olParFac
            cboParametroTarifaInterna.DataSource = olParFac 'RCS-HUNDRED
        Else
            cboParametroFacturar.DataSource = Nothing
            cboParametroPagar.DataSource = Nothing
            cboParametroTarifaInterna.DataSource = Nothing 'RCS-HUNDRED
        End If
        cboParametroFacturar.ListColumnas = oListColum
        cboParametroFacturar.Cargas()
        cboParametroFacturar.ValueMember = "CFRMPG"
        cboParametroFacturar.DispleyMember = "TCMFRP"

        cboParametroPagar.ListColumnas = oListColum2
        cboParametroPagar.Cargas()
        cboParametroPagar.ValueMember = "CFRMPG"
        cboParametroPagar.DispleyMember = "TCMFRP"

        'RCS-HUNDRED-INICIO
        cboParametroTarifaInterna.ListColumnas = oListColum3
        cboParametroTarifaInterna.Cargas()
        cboParametroTarifaInterna.ValueMember = "CFRMPG"
        cboParametroTarifaInterna.DispleyMember = "TCMFRP"
        'RCS-HUNDRED-FIN
         
    End Sub

    Private Sub Cargar_Seguro_Cotizacion()
        Dim dt As New DataTable
        dt.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt.Columns.Add("VALOR", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dt.NewRow
        dr("CODIGO") = "C"
        dr("VALOR") = "CLIENTE"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("CODIGO") = "T"
        dr("VALOR") = "RANSA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("CODIGO") = "P"
        dr("VALOR") = "TERCERO"
        dt.Rows.Add(dr)
        Dim objEntidad As mantenimientos.ClaseGeneral
        Dim lbeSegCot As New List(Of mantenimientos.ClaseGeneral)
        For Each objDataRow As DataRow In dt.Rows
            objEntidad = New mantenimientos.ClaseGeneral
            objEntidad.CODIGO = objDataRow("CODIGO")
            objEntidad.VALOR = objDataRow("VALOR").ToString.Trim()
            lbeSegCot.Add(objEntidad)
        Next


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO"
        oColumnas.DataPropertyName = "CODIGO"
        oColumnas.HeaderText = "Codigo"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "VALOR"
        oColumnas.DataPropertyName = "VALOR"
        oColumnas.HeaderText = "Seg. Cot."
        oListColum.Add(2, oColumnas)


        If lbeSegCot.Count > 0 Then
            cboSeguroCotizacion.DataSource = lbeSegCot

        Else
            cboSeguroCotizacion.DataSource = Nothing

        End If
        cboSeguroCotizacion.ListColumnas = oListColum
        cboSeguroCotizacion.Cargas()
        cboSeguroCotizacion.Limpiar()
        cboSeguroCotizacion.ValueMember = "CODIGO"
        cboSeguroCotizacion.DispleyMember = "VALOR"

       

    End Sub

    Private Sub Cargar_Compania_Seguro()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPSG"
        oColumnas.DataPropertyName = "CCMPSG"
        oColumnas.HeaderText = "Codigo"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPSG"
        oColumnas.DataPropertyName = "TCMPSG"
        oColumnas.HeaderText = "Cia Seguro"
        oListColum.Add(2, oColumnas)

        Dim olCiaSeg As New List(Of mantenimientos.ClaseGeneral)
        olCiaSeg = oClaseGeneral.Listar_Compania_Seguro()

        If olCiaSeg.Count > 0 Then
            cboCompaniaSeguro.DataSource = olCiaSeg
        Else
            cboCompaniaSeguro.DataSource = Nothing
        End If
        cboCompaniaSeguro.ListColumnas = oListColum
        cboCompaniaSeguro.Cargas()
        cboCompaniaSeguro.Limpiar()
        cboCompaniaSeguro.ValueMember = "CCMPSG"
        cboCompaniaSeguro.DispleyMember = "TCMPSG"

       
    End Sub

    Private Sub Cargar_Tipo_SubServicio()

        If cboTipoServicioTransp.Resultado IsNot Nothing Then
            Dim objEntidad As New mantenimientos.ClaseGeneral
            objEntidad.CTPOSR = CType(cboTipoServicioTransp.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPOSR
            objEntidad.CDUPSP = CType(cboTipoServicioTransp.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CDUPSP 'RCS-HUNDRED

            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas.Name = "CTPSBS"
            oColumnas.DataPropertyName = "CTPSBS"
            oColumnas.HeaderText = "Codigo"
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TCMSBS"
            oColumnas.DataPropertyName = "TCMSBS"
            oColumnas.HeaderText = "Tipo Sub Servicio"
            oListColum.Add(2, oColumnas)


            Dim olTipSubSer As New List(Of mantenimientos.ClaseGeneral)
            olTipSubSer = oClaseGeneral.Listar_Tipo_SubServicio(objEntidad)

            If olTipSubSer.Count > 0 Then
                cboTipoSubServicio.DataSource = olTipSubSer
            Else
                cboTipoSubServicio.DataSource = Nothing
            End If
            cboTipoSubServicio.ListColumnas = oListColum
            cboTipoSubServicio.Cargas()
            cboTipoSubServicio.Limpiar()
            cboTipoSubServicio.ValueMember = "CTPSBS"
            cboTipoSubServicio.DispleyMember = "TCMSBS"
            Seleccionar_Nivel_Servicio_x_Tipo_Servicio(objEntidad.CDUPSP) 'RCS-HUNDRED
        Else
            cboTipoSubServicio.DataSource = Nothing
        End If

      
    End Sub



     

    Private Sub CargarTarifaReferencial()

        Dim objTarifa As New Tarifa
        Dim BLTarifa As New clsTarifa
        Dim lista As New List(Of Tarifa)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
       
        oColumnas.Name = "CDTREF"
        oColumnas.DataPropertyName = "CDTREF"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMSER"
        oColumnas.DataPropertyName = "NOMSER"
        oColumnas.HeaderText = "Servicio "
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "VALCTE"
        oColumnas.DataPropertyName = "VALCTE"
        oColumnas.HeaderText = "Cantidad "
        oListColum.Add(3, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CUNDMD"
        oColumnas.DataPropertyName = "CUNDMD"
        oColumnas.HeaderText = "Unidad medida "
        oListColum.Add(4, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "IVLSRV"
        oColumnas.DataPropertyName = "IVLSRV"
        oColumnas.HeaderText = "Valor "
        oListColum.Add(5, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TSGNMN"
        oColumnas.DataPropertyName = "TSGNMN"
        oColumnas.HeaderText = "Moneda "
        oListColum.Add(6, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "TALMC"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(7, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TIPMER"
        oColumnas.DataPropertyName = "TIPMER"
        oColumnas.HeaderText = "Tipo Material "
        oListColum.Add(8, oColumnas)
        '======================================

        If cboServicio.Resultado IsNot Nothing And cmbMoneda.Resultado IsNot Nothing Then

            objTarifa.CCMPN = oTarifa.CCMPN
            objTarifa.CDVSN = UcDivision.Division
            objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
            objTarifa.NRCTSL = oTarifa.NRCTSL
            objTarifa.NRRUBR = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR
            objTarifa.NRSRRB = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB
            objTarifa.CMNDA1 = CType(cmbMoneda.Resultado, Moneda).CMNDA1
            objTarifa.CUNDMD = CType(cmbUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD
            If (Not cmbCentroBeneficio.Resultado Is Nothing) Then
                objTarifa.CCNTCS = CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS
            End If
            lista = BLTarifa.ListarTarifaFija(objTarifa)
            If lista.Count > 0 Then
                txtCodTarifaRef.DataSource = lista
            Else
                txtCodTarifaRef.DataSource = Nothing
            End If
        End If
        txtCodTarifaRef.ListColumnas = oListColum
        txtCodTarifaRef.Cargas()
        txtCodTarifaRef.Limpiar()

        txtCodTarifaRef.ValueMember = "CDTREF"
        txtCodTarifaRef.DispleyMember = "NOMSER"
       
    End Sub



   

    Private Sub Cargar_SectorXGastos()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO"
        oColumnas.DataPropertyName = "CODIGO"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "VALOR"
        oColumnas.DataPropertyName = "VALOR"
        oColumnas.HeaderText = "Sector por Gasto"
        oListColum.Add(2, oColumnas)

        Dim olSecXGas As New List(Of mantenimientos.ClaseGeneral)
        olSecXGas = oClaseGeneral.Lista_SectorXGastos()

        If olSecXGas.Count > 0 Then
            cboSectorxGasto.DataSource = olSecXGas
        Else
            cboSectorxGasto.DataSource = Nothing
        End If
        cboSectorxGasto.ListColumnas = oListColum
        cboSectorxGasto.Cargas()
        cboSectorxGasto.Limpiar()
        cboSectorxGasto.ValueMember = "CODIGO"
        cboSectorxGasto.DispleyMember = "VALOR"

 
    End Sub

    Private Sub cboTipoTarifa_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTarifa.SelectionChangeCommitted
        'Try
        txtCantidad.Text = 1
        Const intPosCampos As Int16 = 28 'RCS-HUNDRED
        If Not bolClienteInterno Then 'RCS-HUNDRED
            lblDescripcion.Location() = New Point(44, 142)
            txtDescripcion.Location() = New Point(128, 142)
            txtDescripcion.Width = 925
        End If

        If cboTipoTarifa.SelectedValue = "R" Then
            txtCantidad.Enabled = False
            lblPeriodo.Visible = False
            txtPeriodoLibre.Visible = False
            chkPeriodoLibre.Visible = False
            lblDiasFacturar.Visible = False
            txtDiasFacturar.Visible = False

            lblTipoAlmacen.Visible = False
            lbltipoMercaderia.Visible = False

            TxtTipoMaterial.Visible = False
            txtTipoAlmacen.Visible = False

            TxtTipoMaterial.Limpiar()
            txtTipoAlmacen.Limpiar()

            'JM
            lblCodTarifaRef.Visible = False
            txtCodTarifaRef.Visible = False
            txtCodTarifaRef.Limpiar()
            lblDiadeCorte.Visible = False
            txtDiasdeCorte.Visible = False
            txtDiasdeCorte.Text = ""


            txtMonto.Enabled = False
            'HGRango.Visible = True
            txtMonto.Text = ""
            SplitC001.Panel2Collapsed = True
            SplitC002.Panel2Collapsed = False
            Me.Height = 406 + intAjusteAltoForm
            ToolStrip1.Visible = True
            dtgRangoTarifa.Visible = True
            ' Me.Height = Me.MaximumSize.Height
            'Me.Height = Me.MinimumSize.Height + HGRango.Height
            Posicionar_Vista_General_Tarifa(0) 'RCS-HUNDRED
        ElseIf (cboTipoTarifa.SelectedValue = "C" Or cboTipoTarifa.SelectedValue = "F") Then
            txtCantidad.Enabled = True
            txtMonto.Enabled = True
            'HGRango.Visible = False
            'Me.Height = Me.MinimumSize.Height
            lblPeriodo.Visible = False
            txtPeriodoLibre.Visible = False
            chkPeriodoLibre.Visible = False

            lblDiasFacturar.Visible = False
            txtDiasFacturar.Visible = False

            SplitC001.Panel2Collapsed = True
            SplitC002.Panel2Collapsed = True

            lblTipoAlmacen.Visible = False
            lbltipoMercaderia.Visible = False

            TxtTipoMaterial.Visible = False
            txtTipoAlmacen.Visible = False

            TxtTipoMaterial.Limpiar()
            txtTipoAlmacen.Limpiar()


            If cboTipoTarifa.SelectedValue = "F" Then
                txtCodTarifaRef.Width = 248
                lblCodTarifaRef.Visible = True
                txtCodTarifaRef.Visible = True

                lblDiadeCorte.Visible = True
                txtDiasdeCorte.Visible = True
                lblDiadeCorte.Location() = New Point(359, 64)
                txtDiasdeCorte.Location() = New Point(446, 64)
                'RCS-HUNDRED-INICIO
                If Posicionar_Vista_General_Tarifa(intPosCampos) Then
                    lblCodTarifaRef.Location() = New Point(29, 170)
                    txtCodTarifaRef.Location() = New Point(128, 170)
                Else
                    lblCodTarifaRef.Location() = New Point(29, 142)
                    txtCodTarifaRef.Location() = New Point(128, 142)
                End If
                'RCS-HUNDRED-FIN
            Else
                lblCodTarifaRef.Visible = False
                txtCodTarifaRef.Visible = False
                txtCodTarifaRef.Limpiar()

                lblDiadeCorte.Visible = False
                txtDiasdeCorte.Visible = False
                txtDiasdeCorte.Text = ""
                Posicionar_Vista_General_Tarifa(0) 'RCS-HUNDRED
            End If

            Me.Height = 306 + intAjusteAltoForm

            ToolStrip1.Visible = False
            dtgRangoTarifa.Visible = False

        ElseIf (cboTipoTarifa.SelectedValue = "S" Or cboTipoTarifa.SelectedValue = "Q" Or cboTipoTarifa.SelectedValue = "M" Or cboTipoTarifa.SelectedValue = "D") Then
            lblPeriodo.Visible = True
            txtPeriodoLibre.Visible = True
            chkPeriodoLibre.Visible = True
            cmbUnidadMedida.Valor = "MT2"

            lblDiasFacturar.Visible = True
            txtDiasFacturar.Visible = True

            'cmbUnidadMedida.SelectedValue = "MT2"
            txtMonto.Enabled = True
            txtCantidad.Enabled = True

            lblTipoAlmacen.Visible = True
            lbltipoMercaderia.Visible = True
            TxtTipoMaterial.Visible = True
            txtTipoAlmacen.Visible = True

            'JM
            'comentado .... 05/05/2015
            'lblCodTarifaFijaRef.Visible = True
            'txtCodTarifaRef.Visible = True
            lblDiadeCorte.Visible = False
            txtDiasdeCorte.Visible = False
            lblCodTarifaRef.Visible = False
            txtCodTarifaRef.Visible = False
            txtCodTarifaRef.Limpiar()

            txtDiasdeCorte.Text = ""


            If cboTipoTarifa.SelectedValue = "F" Then
                txtCantidad.Enabled = False
            End If
            SplitC001.Panel2Collapsed = True
            SplitC002.Panel2Collapsed = True
            Me.Height = 306 + intAjusteAltoForm
            ToolStrip1.Visible = False
            dtgRangoTarifa.Visible = False
            'HGRango.Visible = False
            'Me.Height = Me.MinimumSize.Height
            'RCS-HUNDRED-INICIO
            If Not Posicionar_Vista_General_Tarifa(intPosCampos) Then
                lblDescripcion.Location() = New Point(44, 170) 'RCS-HUNDRED
                txtDescripcion.Location() = New Point(128, 170) 'RCS-HUNDRED
            End If
            'RCS-HUNDRED-FIN
            txtDescripcion.Width = 607
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        'End Try
    End Sub


    Private Sub Cargar_Tarifa()

        Dim oTarifaNeg As New clsTarifa
        Me.cmbMoneda.Valor = oTarifa.CMNDA1
        If IsNothing(oTarifa.CUNDMD) Then
            Me.cmbUnidadMedida.Valor = "NADA"
        Else
            If oTarifa.CUNDMD.Trim = "" Then
                Me.cmbUnidadMedida.Valor = "NADA"
            Else
                Me.cmbUnidadMedida.Valor = oTarifa.CUNDMD
            End If
        End If
        Me.cmbCentroBeneficio.Valor = oTarifa.CCNTCS
        UcDivision.DivisionDefault = oTarifa.CDVSN
        UcDivision.pActualizar()
        UcPLanta_Cmb011.CodigoCompania = oTarifa.CCMPN
        UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
        UcPLanta_Cmb011.PlantaDefault = oTarifa.CPLNDV
        UcPLanta_Cmb011.pActualizar()

        'ListarServicio()
        ' objTarifa.NRRUBR

        'Me.cboServicio.SelectedValue = oTarifa.NRSRRB
        Me.cboServicio.Valor = oTarifa.COD_SERV
        Me.cboLogicaFacturacion.Valor = oTarifa.NRRELF

        Me.UcDivision.pHabilitado = False
        Me.UcPLanta_Cmb011.pHabilitado = False
        Me.cboServicio.Enabled = False
        'Me.cboServicio.ComboBox.Enabled = False

        Select Case oTarifa.STPTRA
            Case "F"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedIndex = 0
                Me.cboTipoTarifa.SelectedValue = "F"
            Case "C"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedIndex = 1
                Me.cboTipoTarifa.SelectedValue = "C"
            Case "R"
                txtDescripcion.Text = oRango.DESRNG.Trim
                'Me.cboTipoTarifa.SelectedIndex = 2
                Me.cboTipoTarifa.SelectedValue = "R"
                '=========Cargamos Grilla Rango==========
                Dim dt As DataTable = oTarifaNeg.Lista_Rango_RZSC03A(oTarifa)
                Dim iRow As Integer = 0
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As New DataGridViewRow
                    dr.CreateCells(dtgRangoTarifa)
                    dtgRangoTarifa.Rows.Add(dr)
                    'iRow = dtgRangoTarifa.Rows.Count - 1
                    dtgRangoTarifa.Rows(i).Cells("CodTarifa").Value = dt.Rows(i).Item("NRTFSV")
                    dtgRangoTarifa.Rows(i).Cells("CodRango").Value = dt.Rows(i).Item("NRRNGO")
                    dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value = dt.Rows(i).Item("VALMIN")
                    dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value = dt.Rows(i).Item("VALMAX")
                    dtgRangoTarifa.Rows(i).Cells("Tarifa").Value = dt.Rows(i).Item("IVLSRV")
                Next
            Case "D"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedIndex = 3
                Me.cboTipoTarifa.SelectedValue = "D"

                lblTipoAlmacen.Visible = True
                lbltipoMercaderia.Visible = True
                TxtTipoMaterial.Visible = True
                txtTipoAlmacen.Visible = True

                lblDescripcion.Location() = New Point(365, 142)
                txtDescripcion.Location() = New Point(446, 142)
                txtDescripcion.Width = 607

            Case "S"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedIndex = 4
                Me.cboTipoTarifa.SelectedValue = "S"
            Case "Q"
                txtDescripcion.Text = oTarifa.TOBS
                'Me.cboTipoTarifa.SelectedIndex = 5
                Me.cboTipoTarifa.SelectedValue = "Q"
            Case "M"
                txtDescripcion.Text = oTarifa.TOBS
                ' Me.cboTipoTarifa.SelectedIndex = 6
                Me.cboTipoTarifa.SelectedValue = "M"

        End Select
        cboTipoTarifa_SelectionChangeCommitted(cboTipoTarifa, Nothing)

        txtMonto.Text = oTarifa.IVLSRV
        txtCantidad.Text = oTarifa.VALCTE
        Me.txtPeriodoLibre.Text = oTarifa.PRLBPG

        'Falta mapear
        txtDiasFacturar.Text = oTarifa.NDIAPL


        txtTipoAlmacen.Valor = oTarifa.CTPALM
        TxtTipoMaterial.Valor = oTarifa.TTPOMR


        txtDiasdeCorte.Text = oTarifa.DIACOR

        txtTipoServicio.Valor = oTarifa.CDTSSP
        txtUnidadProductiva.Valor = oTarifa.CDUPSP
        cboTipoActivo.SelectedValue = oTarifa.CDTASP
        cmbCentroBeneficio.Valor = oTarifa.CCNTCS
        txtCodTarifaRef.Valor = oTarifa.CDTREF

        Me.chkPeriodoLibre.Checked = IIf(oTarifa.FAPLBR.Trim.Equals("X"), True, False)
        Cargar_Cliente_Interno(oTarifa) 'RCS-HUNDRED
        Generar_Tarifa()
    End Sub

    '<[AHM]>'
    Private Sub Cargar_TipoServicio_SAP(ByVal PSCDSRSP As String)
        Dim oListColum, oListColum2 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CDTSSP"
        oColumnas.DataPropertyName = "CDTSSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone())
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDTSSP"
        oColumnas.DataPropertyName = "TDTSSP"
        oColumnas.HeaderText = "Tipo Servicio "
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone())

        Dim claseGeneralList As List(Of ClaseGeneral) = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)

        txtTipoServicio.DataSource = claseGeneralList
        txtTipoServicio.ListColumnas = oListColum
        txtTipoServicio.Cargas()
        txtTipoServicio.ValueMember = "CDTSSP"
        txtTipoServicio.DispleyMember = "TDTSSP"
        txtTipoServicioTransporte.DataSource = claseGeneralList
        txtTipoServicioTransporte.ListColumnas = oListColum2
        txtTipoServicioTransporte.Cargas()
        txtTipoServicioTransporte.ValueMember = "CDTSSP"
        txtTipoServicioTransporte.DispleyMember = "TDTSSP"
        'RCS-HUNDRED-INICIO
        If claseGeneralList.Count > 0 AndAlso claseGeneralList(0).CDTSSP = "T" Then
            txtTipoServicioTransporte.Valor = claseGeneralList(0).CDTSSP
        End If
        'RCS-HUNDRED-FIN
    End Sub

    Private Sub Listar_TipoActivo_SAP()
        Dim tipoActivoList As New List(Of mantenimientos.ClaseGeneral)
        tipoActivoList = oClaseGeneral.Listar_Tipo_Activo_SAP()

        cboTipoActivo.DataSource = tipoActivoList
        cboTipoActivo.DisplayMember = "PRDESC"
        cboTipoActivo.ValueMember = "PRCODI"
    End Sub

    Private Sub Cargar_UnidadProductiva_SAP(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String)
        'RCS-HUNDRED-INICIO
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CDUPSP"
        oColumnas.DataPropertyName = "CDUPSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDUPSP"
        oColumnas.DataPropertyName = "TDUPSP"
        oColumnas.HeaderText = "Unidad Productiva "
        oListColum.Add(2, oColumnas)

        Dim claseGeneralList As List(Of ClaseGeneral)
        'claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)
        claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(PSCDSRSP, PSCDSPSP)
        '

        txtUnidadProductiva.DataSource = claseGeneralList
        txtUnidadProductiva.ListColumnas = oListColum
        txtUnidadProductiva.Cargas()
        txtUnidadProductiva.ValueMember = "CDUPSP"
        txtUnidadProductiva.DispleyMember = "TDUPSP"
        'RCS-HUNDRED-FIN
    End Sub
    '</[AHM]>'

    
    Private Sub Generar_Tarifa()
        'Try
        If bolGenera Then
            Dim strTarifa As String = ""
            strTarifa = CType(cmbMoneda.Resultado, Moneda).TSGNMN 'Me.cmbMoneda.Text.Trim
            If Me.txtMonto.Text.Trim <> vbNullString Then
                strTarifa = strTarifa & " " & Format(CType(Me.txtMonto.Text.Trim, Double), "###,###,###,##0.000")
            End If
            Generar_Concepto()
            oTarifaDescripciones.MntTarifa = strTarifa
            ' If cboTipoTarifa.SelectedIndex = 2 Then
            If cboTipoTarifa.SelectedValue = "R" Then
                Me.txtTarifa.Text = oTarifaDescripciones.DesConcepto
            Else
                Me.txtTarifa.Text = oTarifaDescripciones.MntTarifa & " " & oTarifaDescripciones.DesConcepto
            End If
            ' If (cboTipoTarifa.SelectedIndex = 4 Or cboTipoTarifa.SelectedIndex = 5 Or cboTipoTarifa.SelectedIndex = 6 Or cboTipoTarifa.SelectedIndex = 3) Then
            If (cboTipoTarifa.SelectedValue = "S" Or cboTipoTarifa.SelectedValue = "Q" Or cboTipoTarifa.SelectedValue = "M" Or cboTipoTarifa.SelectedValue = "D") Then

                lblPeriodo.Visible = True
                txtPeriodoLibre.Visible = True
                chkPeriodoLibre.Visible = True

                lblDiasFacturar.Visible = True
                txtDiasFacturar.Visible = True

                lblTipoAlmacen.Visible = True
                lbltipoMercaderia.Visible = True

                TxtTipoMaterial.Visible = True
                txtTipoAlmacen.Visible = True

            End If
        End If
        'Catch : End Try
    End Sub


    


    Private Sub Generar_Concepto()
        If bolGenera Then
            Dim strConcepto As String = ""
            ' If Me.cboTipoTarifa.SelectedIndex < 2 Then
            If Me.cboTipoTarifa.SelectedValue = "F" OrElse Me.cboTipoTarifa.SelectedValue = "C" Then
                If Me.txtCantidad.Text.Trim = "1" Then
                    strConcepto = strConcepto & " por"
                Else
                    strConcepto = strConcepto & " por " & Format(CType(Me.txtCantidad.Text.Trim, Double), "###,###,###,##0")
                End If
            Else
                Dim rango_text As String = ""

                For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                    If Not (CDbl(obj.Cells("RangoInicial").Value.ToString()) = 0 And CDbl(obj.Cells("RangoFinal").Value.ToString()) = 0) Then
                        rango_text = rango_text & " de " & obj.Cells("RangoInicial").Value.ToString() & " a " & obj.Cells("RangoFinal").Value.ToString() & " por " & CType(cmbMoneda.Resultado, Moneda).TSGNMN & obj.Cells("Tarifa").Value.ToString() & vbNewLine
                    End If
                Next
                strConcepto = strConcepto & rango_text
            End If
            If cmbUnidadMedida.Resultado IsNot Nothing Then
                If CType(cmbUnidadMedida.Resultado, mantenimientos.ClaseGeneral).CUNDMD <> "NADA" Then
                    strConcepto = strConcepto & " " & CType(cmbUnidadMedida.Resultado, mantenimientos.ClaseGeneral).CUNDMD 'Me.cmbUnidadMedida.Text.Trim
                End If
            End If

            If Me.txtDescripcion.Text <> vbNullString Then
                strConcepto = strConcepto & " " & Me.txtDescripcion.Text.Trim
            End If
            oTarifaDescripciones.DesConcepto = strConcepto
        End If
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

   

    Private Function Genera_Descripcion() As String
        Dim strTarifa As String = ""

        If Me.cboTipoTarifa.SelectedValue = "F" Then
            If Me.txtCantidad.Text.Trim = "1" Then
                strTarifa = "por"
            Else
                strTarifa = "por " & Format(CType(Me.txtCantidad.Text.Trim, Double), "###,###,###,##0")
            End If
        Else
            Dim rango_text As String = ""
            For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                If Not (CInt(obj.Cells("RangoInicial").Value.ToString()) = 0 And CInt(obj.Cells("RangoFinal").Value.ToString()) = 0) Then
                    rango_text = rango_text & " de " & obj.Cells("RangoInicial").Value.ToString() & " a " & obj.Cells("RangoFinal").Value.ToString() & " por " & obj.Cells("Tarifa").Value.ToString() & vbNewLine
                End If
            Next
            strTarifa = strTarifa & rango_text
        End If
        If CType(cmbUnidadMedida.Resultado, mantenimientos.ClaseGeneral).CUNDMD <> "NADA" Then
            strTarifa = strTarifa & " " & Me.cmbUnidadMedida.Text.Trim
        End If
        If Me.txtDescripcion.Text <> vbNullString Then
            strTarifa = strTarifa & " " & Me.txtDescripcion.Text.Trim
        End If
        Return strTarifa
    End Function



#Region "Validacion de Campos Numericos"
    '-----------------------------------
    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Try
            CType(sender, TextBox).Tag = "10-3"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            CType(sender, TextBox).Tag = "10-5"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtPeriodoLibre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeriodoLibre.KeyPress
        Try
            CType(sender, TextBox).Tag = "3-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        Try
            If txtMonto.Text.EndsWith(".") Then
                txtMonto.Text = txtMonto.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        Try
            If txtCantidad.Text.EndsWith(".") Then
                txtCantidad.Text = txtCantidad.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub




#End Region

    Private Sub btnAgregaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaRango.Click
        Try
            If txtIniRango.Text = "" Then Exit Sub
            If txtFinRango.Text = "" Then Exit Sub
            If txtMontoRango.Text = "" Or txtMontoRango.Text = "0" Then Exit Sub
            If CDbl(txtIniRango.Text) > CDbl(txtFinRango.Text) Then
                MsgBox("El Valor Maximo debe ser Mayor a Valor Minimo", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dr As New DataGridViewRow
            Dim iRow As Integer = 0
            dr.CreateCells(dtgRangoTarifa)
            dtgRangoTarifa.Rows.Add(dr)
            iRow = dtgRangoTarifa.Rows.Count - 1
            dtgRangoTarifa.Rows(iRow).Cells("CodTarifa").Value = oTarifa.NRTFSV
            dtgRangoTarifa.Rows(iRow).Cells("CodRango").Value = 0
            dtgRangoTarifa.Rows(iRow).Cells("RangoInicial").Value = txtIniRango.Text
            dtgRangoTarifa.Rows(iRow).Cells("RangoFinal").Value = txtFinRango.Text
            dtgRangoTarifa.Rows(iRow).Cells("Tarifa").Value = txtMontoRango.Text
            txtIniRango.Text = ""
            txtFinRango.Text = ""
            txtMontoRango.Text = ""
            txtIniRango.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub btnQuitaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaRango.Click
        Try
            If dtgRangoTarifa.Rows.Count = 0 Then Exit Sub
            If dtgRangoTarifa.Rows(dtgRangoTarifa.CurrentRow.Index).Cells("CodRango").Value = 0 Then
                dtgRangoTarifa.Rows.RemoveAt(dtgRangoTarifa.CurrentRow.Index)
            Else
                MsgBox("No es posible eliminar el rango, debido a que ya tiene un código asignado", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboServicio_CambioDeTexto(ByVal objData As System.Object) Handles cboServicio.CambioDeTexto
        Try
            Validar_Servicio()
            '<[AHM]>
            txtTipoServicio.Limpiar()
            txtTipoServicio.DataSource = Nothing

            If (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                cmbCentroBeneficio.Limpiar()
                cmbCentroBeneficio.DataSource = Nothing
            End If
            '---
            txtTipoServicioTransporte.Limpiar()
            txtTipoServicioTransporte.DataSource = Nothing

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED
            '---

            '</[AHM]>
            If cboServicio.Resultado IsNot Nothing Then
                'CargarTarifaFija()
                CargarTarifaReferencial()
                Dim servicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
                '<[AHM]>
                Me.Cargar_TipoServicio_SAP(servicio.CDSRSP)
                Cargar_UnidadProductivaTransporte(servicio.CDSRSP) 'RCS-HUNDRED

                If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                    Exit Sub
                End If
                Me.Cargar_CentroBeneficio()
                '</[AHM]>
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Function Validar_Controles_Visibles() As Boolean
        If cboServicio.Resultado Is Nothing Then
            Return True
        Else
            Dim PNNRRUBR As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR 'PNNRRUBR_PNNRSRRB.Split("_")(0)
            Dim PNNRSRRB As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB 'PNNRRUBR_PNNRSRRB.Split("_")(1)
            Dim PSCSRVC As String = CType(cboServicio.Resultado, Servicio_X_Rubro).CSRVC 'PNNRRUBR_PNNRSRRB.Split("_")(2)
            If PSCSRVC <> "" Then
                Return False
            Else
                Return True
            End If
        End If
    End Function

    'RCS-HUNDRED-INICIO

    Private Sub Validar_Cliente_Interno()
        Dim oCliente As New clsCliente

        bolClienteInterno = oCliente.Validar_Cliente_Interno(oTarifa.CCMPN, oTarifa.NRCTSL).Count > 0
        ' valores para posicionamiento de campos de cliente interno
        If bolClienteInterno Then
            intPosY = 28
            intAjusteAltoForm = 56
        End If
    End Sub

    Private Sub Cargar_CentroCosto_Origen()
        If bolClienteInterno Then
            Dim oListColumns As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            Dim olCentroCosto As List(Of CentroCosto) = oCentroCosto.Listar_CentroCosto_Origen_Tarifa(oTarifa.CCMPN)

            oColumnas.Name = "PNCCNTCS"
            oColumnas.DataPropertyName = "PNCCNTCS"
            oColumnas.HeaderText = "Código"
            oListColumns.Add(1, oColumnas)
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTCNTCS"
            oColumnas.DataPropertyName = "PSTCNTCS"
            oColumnas.HeaderText = "Centro de Costo"
            oListColumns.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "CCNCOS"
            oColumnas.DataPropertyName = "PSCCNCOS"
            oColumnas.HeaderText = "Ce.Co. SAP"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColumns.Add(3, oColumnas)

            If olCentroCosto.Count > 0 Then
                cmbCentCostoOrigen.DataSource = olCentroCosto
            Else
                cmbCentCostoOrigen.DataSource = Nothing
            End If
            cmbCentCostoOrigen.ListColumnas = oListColumns
            cmbCentCostoOrigen.Cargas()
            cmbCentCostoOrigen.ValueMember = "PNCCNTCS"
            cmbCentCostoOrigen.DispleyMember = "PSTCNTCS"
        End If
    End Sub

    Private Sub Mostrar_CentCosto_Cliente_Interno(ByVal pbolMostrar)
        ' muestra campos de cliente interno
        lblTarifaInterna.Visible = pbolMostrar
        txtTarifaInterna.Visible = pbolMostrar
        lblCentCostoOrigen.Visible = pbolMostrar
        cmbCentCostoOrigen.Visible = pbolMostrar
        lblCentCostoDestino.Visible = pbolMostrar
        cmbCentCostoDestino.Visible = pbolMostrar
        ' valores por defecto
        txtTarifaInterna.Text = 0
    End Sub

    Private Sub Cargar_CentroCosto_Destino()
        If bolClienteInterno Then
            Dim oListColumns As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            Dim olCentroCosto As List(Of CentroCosto) = oCentroCosto.Listar_CentroCosto_Destino_Tarifa(oTarifa.CCMPN, CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS)

            oColumnas.Name = "PNCCNTCS"
            oColumnas.DataPropertyName = "PNCCNTCS"
            oColumnas.HeaderText = "Código"
            oListColumns.Add(1, oColumnas)
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTCNTCS"
            oColumnas.DataPropertyName = "PSTCNTCS"
            oColumnas.HeaderText = "Centro de Costo"
            oListColumns.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "CCNCOS"
            oColumnas.DataPropertyName = "PSCCNCOS"
            oColumnas.HeaderText = "Ce.Co. SAP"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oListColumns.Add(3, oColumnas)


            If olCentroCosto.Count > 0 Then
                cmbCentCostoDestino.DataSource = olCentroCosto
            Else
                cmbCentCostoDestino.DataSource = Nothing
            End If
            cmbCentCostoDestino.ListColumnas = oListColumns
            cmbCentCostoDestino.Cargas()
            cmbCentCostoDestino.ValueMember = "PNCCNTCS"
            cmbCentCostoDestino.DispleyMember = "PSTCNTCS"
        End If
    End Sub

    Private Function Validar_Controles_Cliente_Interno() As Boolean
        If Not bolClienteInterno Then Return True
       
        If cmbCentCostoOrigen.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar Centro de Costo Origen.", MessageBoxIcon.Information)
            Return False
        End If
        If cmbCentCostoDestino.Resultado Is Nothing Then
            HelpClass.MsgBox("Debe de seleccionar Centro de Costo Destino.", MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub Guardar_Cliente_Interno(ByRef objTarifa As Tarifa)
        If Not bolClienteInterno Then Return
        objTarifa.ISRVTI = CDbl(IIf(txtTarifaInterna.Text.Trim = "", 0, txtTarifaInterna.Text.Trim))
        objTarifa.CENCO2 = CType(cmbCentCostoOrigen.Resultado, CentroCosto).PNCCNTCS
        objTarifa.CENCOS = CType(cmbCentCostoDestino.Resultado, CentroCosto).PNCCNTCS
    End Sub

    Private Sub Cargar_Cliente_Interno(ByRef objTarifa As Tarifa)
        If Not bolClienteInterno Then Return
        txtTarifaInterna.Text = objTarifa.ISRVTI
        cmbCentCostoOrigen.Valor = objTarifa.CENCO2
        cmbCentCostoDestino.Valor = objTarifa.CENCOS
    End Sub

    Private Sub Habilitar_CentCosto_Cliente_Interno(ByVal bolEstado As Boolean)
        txtTarifaInterna.Enabled = bolEstado
        cmbCentCostoOrigen.Enabled = bolEstado
        cmbCentCostoDestino.Enabled = bolEstado
    End Sub

    Private Function Posicionar_Vista_General_Tarifa(ByVal pintPosCampos As Integer) As Boolean
        Dim intPosY1 As Integer = 114
        Dim intPosY2 As Integer = 142
        Dim intPosY3 As Integer = 142
        Dim intPosY4 As Integer = 198
        If bolClienteInterno Then
            Dim intPosY5 As Integer = 142 + intPosY + pintPosCampos

            intPosY1 += intPosY
            intPosY2 += intPosY
            intPosY3 = 170 + intPosY
            intPosY4 = 198 + intPosY
            lblCentCostoDestino.Location = New System.Drawing.Point(3, intPosY5) ' centro costo destino
            cmbCentCostoDestino.Location = New System.Drawing.Point(128, intPosY5) ' centro costo destino
        End If
        intPosY3 += pintPosCampos
        intPosY4 += pintPosCampos
        KryptonLabel3.Location = New System.Drawing.Point(23, intPosY1) ' tipo de servicio
        txtTipoServicio.Location = New System.Drawing.Point(129, intPosY1) ' tipo de servicio
        KryptonLabel17.Location = New System.Drawing.Point(328, intPosY1) ' unidad productiva
        txtUnidadProductiva.Location = New System.Drawing.Point(446, intPosY1) ' unidad productiva
        KryptonLabel18.Location = New System.Drawing.Point(725, intPosY1) ' tipo de activo
        cboTipoActivo.Location = New System.Drawing.Point(806, intPosY1) ' tipo de activo
        'KryptonLabel6.Location = New System.Drawing.Point(922, intPosY1) ' centro de beneficio
        'cmbCentroBeneficio.Location = New System.Drawing.Point(1018, intPosY1) ' centro de beneficio
        KryptonLabel6.Location = New System.Drawing.Point(905, intPosY1) ' centro de beneficio
        cmbCentroBeneficio.Location = New System.Drawing.Point(955, intPosY1) ' centro de beneficio
      

        lblTipoAlmacen.Location = New System.Drawing.Point(35, intPosY2) ' tipo de almacen
        txtTipoAlmacen.Location = New System.Drawing.Point(128, intPosY2) ' tipo de almacen
        lblCodTarifaRef.Location = New System.Drawing.Point(346, intPosY2) ' codigo de tarifa ref.
        txtCodTarifaRef.Location = New System.Drawing.Point(446, intPosY2) ' codigo de tarifa ref.
        lbltipoMercaderia.Location = New System.Drawing.Point(700, intPosY2) ' tipo de mercaderia
        TxtTipoMaterial.Location = New System.Drawing.Point(805, intPosY2) ' tipo de mercaderia

        lblDescripcion.Location = New System.Drawing.Point(47, intPosY3) ' descripcion
        txtDescripcion.Location = New System.Drawing.Point(128, intPosY3) ' descripcion
        GroupBox2.Location = New System.Drawing.Point(129, intPosY4) ' desc. tarifa

        Return bolClienteInterno
    End Function

    Private Sub Cargar_Datos_Generales_Tarifa_Transporte() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        dsMelsap = (New clsTarifa).Cargar_Datos_Generales_Tarifa_Transporte(oTarifa)
        Cargar_Nivel_Servicio()
        Cargar_Tipo_Carga_Transporte()
        'Cargar_Centro_Costo_Propio_Tercero() 'JM
    End Sub

    Private Sub Cargar_Nivel_Servicio()
        Dim oListColumns As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CODIGO"
        oColumnas.DataPropertyName = "CODIGO"
        oColumnas.HeaderText = "Código"
        oListColumns.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESCRIPCION"
        oColumnas.DataPropertyName = "DESCRIPCION"
        oColumnas.HeaderText = "Descripción"
        oListColumns.Add(2, oColumnas)
        If Not dsMelsap.Tables("Table3") Is Nothing AndAlso dsMelsap.Tables("Table3").Rows.Count > 0 Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dvNivelServicio As DataView = dsMelsap.Tables("Table3").DefaultView

            dvNivelServicio.RowFilter = "TIPO = 'TIPOTRANSPSAP'"
            cboNivelServ.DataSource = Listar_Datos_Generales(dvNivelServicio.ToTable()) ' datos generales > nivel de servicio
        Else
            cboNivelServ.DataSource = Nothing
        End If
        cboNivelServ.ListColumnas = oListColumns
        cboNivelServ.Cargas()
        cboNivelServ.Limpiar()
        cboNivelServ.ValueMember = "CODIGO"
        cboNivelServ.DispleyMember = "DESCRIPCION"
    End Sub

    Public Function Listar_Datos_Generales(ByRef pdtDatosGenerales As DataTable) As List(Of DatosGenerales)
        Dim objDatosGenerales As DatosGenerales
        Dim lbeDatosGenerales As New List(Of DatosGenerales)
        For Each objDataRow As DataRow In pdtDatosGenerales.Rows
            objDatosGenerales = New DatosGenerales()
            objDatosGenerales.CODIGO = objDataRow("CODIGO")
            objDatosGenerales.DESCRIPCION = objDataRow("DESCRIPCION").ToString.Trim()
            objDatosGenerales.CODREL = objDataRow("CODREL").ToString.Trim()
            lbeDatosGenerales.Add(objDatosGenerales)
        Next
        Return lbeDatosGenerales
    End Function

    Private Sub Seleccionar_Nivel_Servicio_x_Tipo_Servicio(ByVal pstrCdupsp As String)
        If Not dsMelsap.Tables("Table3") Is Nothing AndAlso dsMelsap.Tables("Table3").Rows.Count > 0 Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dvNivelServicio As DataView = dsMelsap.Tables("Table3").DefaultView 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dtNivelServicio As DataTable

            dvNivelServicio.RowFilter = "TIPO = 'TIPOTRANSPSAP'" & String.Format(" AND CODREL = '{0}'", pstrCdupsp)
            dtNivelServicio = dvNivelServicio.ToTable()
            If dtNivelServicio.Rows.Count > 0 Then
                cboNivelServ.Valor = dtNivelServicio.Rows(0)("CODIGO").ToString().Trim()
            End If
        End If
    End Sub

    Private Sub cboParametroTarifaInterna_CambioDeTexto(ByVal objData As System.Object) Handles cboParametroTarifaInterna.CambioDeTexto
        Try
            Visualizar_Registro_Rango()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Cargar_Tipo_Carga_Transporte()
        Dim oListColumns As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "CODIGO"
        oColumnas.DataPropertyName = "CODIGO"
        oColumnas.HeaderText = "Código"
        oListColumns.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESCRIPCION"
        oColumnas.DataPropertyName = "DESCRIPCION"
        oColumnas.HeaderText = "Descripción"
        oListColumns.Add(2, oColumnas)
        If Not dsMelsap.Tables("Table2") Is Nothing AndAlso dsMelsap.Tables("Table2").Rows.Count > 0 Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dvTipoCargaTransporte As DataView = dsMelsap.Tables("Table2").DefaultView 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            dvTipoCargaTransporte.RowFilter = "TIPO = 'TIPOCARGASAP'"
            cboTipoCargaTransporte.DataSource = Listar_Datos_Generales(dvTipoCargaTransporte.ToTable()) ' datos generales > tipo de carga
        Else
            cboTipoCargaTransporte.DataSource = Nothing
        End If
        cboTipoCargaTransporte.ListColumnas = oListColumns
        cboTipoCargaTransporte.Cargas()
        cboTipoCargaTransporte.Limpiar()
        cboTipoCargaTransporte.ValueMember = "CODIGO"
        cboTipoCargaTransporte.DispleyMember = "DESCRIPCION"
    End Sub

    Private Sub Cargar_Centro_Costo_Propio_Tercero()
        Dim oListColumns, oListColumns2 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas.Name = "COD_CECO"
        oColumnas.DataPropertyName = "COD_CECO"
        oColumnas.HeaderText = "Cod CeCo"
        oListColumns.Add(1, oColumnas)
        oListColumns2.Add(1, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_CECO"
        oColumnas.DataPropertyName = "DESC_CECO"
        oColumnas.HeaderText = "Desc Ceco"
        oListColumns.Add(2, oColumnas)
        oListColumns2.Add(2, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CODSAP_CECO"
        oColumnas.DataPropertyName = "CODSAP_CECO"
        oColumnas.HeaderText = "Cod  CeCo SAP"
        oListColumns.Add(3, oColumnas)
        oListColumns2.Add(3, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "COD_CEBE"
        oColumnas.DataPropertyName = "COD_CEBE"
        oColumnas.HeaderText = "Cod CeBe"
        oListColumns.Add(4, oColumnas)
        oListColumns2.Add(4, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_CEBE"
        oColumnas.DataPropertyName = "DESC_CEBE"
        oColumnas.HeaderText = "Desc CeBe"
        oListColumns.Add(5, oColumnas)
        oListColumns2.Add(5, oColumnas.Clone())

       
    End Sub

    Private Function Listar_CeCo_Tarifario(ByRef pdtCeCoTarifario As DataTable) As List(Of CentroCostoTarifa)
        Dim objCeCoTarifario As CentroCostoTarifa
        Dim lbeCeCoTarifario As New List(Of CentroCostoTarifa)
        For Each objDataRow As DataRow In pdtCeCoTarifario.Rows
            objCeCoTarifario = New CentroCostoTarifa()
            objCeCoTarifario.COD_CECO = objDataRow("COD_CECO").ToString.Trim()
            objCeCoTarifario.DESC_CECO = objDataRow("DESC_CECO").ToString.Trim()
            objCeCoTarifario.CODSAP_CECO = objDataRow("CODSAP_CECO").ToString.Trim()
            objCeCoTarifario.COD_CEBE = objDataRow("COD_CEBE").ToString.Trim()
            objCeCoTarifario.CODSAP_CEBE = objDataRow("CODSAP_CEBE").ToString.Trim()
            objCeCoTarifario.DESC_CEBE = objDataRow("DESC_CEBE").ToString.Trim()
            lbeCeCoTarifario.Add(objCeCoTarifario)
        Next
        Return lbeCeCoTarifario
    End Function

    Public Function Obtener_Dato_General(ByVal pstrTipo As String, ByVal pstrCodigo As String) As DatosGenerales 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Select Case pstrTipo
            Case "TIPOCENTROSAP" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                If Not dsMelsap.Tables("Table1") Is Nothing AndAlso dsMelsap.Tables("Table1").Rows.Count > 0 Then
                    Dim dvDatosGenerales As DataView = dsMelsap.Tables("Table1").DefaultView
                    Dim lbeDatosGenerales As List(Of DatosGenerales)

                    dvDatosGenerales.RowFilter = String.Format("TIPO = '{0}' AND CODIGO = '{1}'", pstrTipo, pstrCodigo)
                    lbeDatosGenerales = Listar_Datos_Generales(dvDatosGenerales.ToTable()) ' datos generales
                    If lbeDatosGenerales.Count > 0 Then
                        Return lbeDatosGenerales(0)
                    End If
                End If
            Case "TIPOACTIVOSAP" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                If Not dsMelsap.Tables("Table") Is Nothing AndAlso dsMelsap.Tables("Table").Rows.Count > 0 Then
                    Dim dvDatosGenerales As DataView = dsMelsap.Tables("Table").DefaultView
                    Dim lbeDatosGenerales As List(Of DatosGenerales)

                    dvDatosGenerales.RowFilter = String.Format("TIPO = '{0}' AND CODIGO = '{1}'", pstrTipo, pstrCodigo)
                    lbeDatosGenerales = Listar_Datos_Generales(dvDatosGenerales.ToTable()) ' datos generales
                    If lbeDatosGenerales.Count > 0 Then
                        Return lbeDatosGenerales(0)
                    End If
                End If
        End Select

        Return Nothing
    End Function

    Private Sub Cargar_UnidadProductivaTransporte(ByVal pstrCdsrsp As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim claseGeneralList As List(Of ClaseGeneral)

        oColumnas.Name = "CDUPSP"
        oColumnas.DataPropertyName = "CDUPSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDUPSP"
        oColumnas.DataPropertyName = "TDUPSP"
        oColumnas.HeaderText = "Unidad Productiva "
        oListColum.Add(2, oColumnas)

        If Not dsMelsap.Tables("Table4") Is Nothing AndAlso dsMelsap.Tables("Table4").Rows.Count > 0 Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dvNivelServicio As DataView = dsMelsap.Tables("Table4").DefaultView 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            dvNivelServicio.RowFilter = String.Format("CDSRSP = '{0}'", pstrCdsrsp)
            claseGeneralList = Listar_UnidadProductivaTransporte(dvNivelServicio.ToTable()) ' datos generales > unidad productiva
        Else
            claseGeneralList = Nothing
        End If
        txtUnidadProductivaTransporte.DataSource = claseGeneralList
        txtUnidadProductivaTransporte.ListColumnas = oListColum
        txtUnidadProductivaTransporte.Cargas()
        txtUnidadProductivaTransporte.ValueMember = "CDUPSP"
        txtUnidadProductivaTransporte.DispleyMember = "TDUPSP"
        If claseGeneralList.Count = 1 Then
            txtUnidadProductivaTransporte.Valor = claseGeneralList(0).CDUPSP
        End If
    End Sub

    Public Function Listar_UnidadProductivaTransporte(ByRef pdtUnidadProductivaTransporte As DataTable) As List(Of ClaseGeneral)
        Dim objClaseGeneral As ClaseGeneral
        Dim lbeClaseGeneral As New List(Of ClaseGeneral)
        For Each objDataRow As DataRow In pdtUnidadProductivaTransporte.Rows
            objClaseGeneral = New ClaseGeneral()
            objClaseGeneral.CDUPSP = objDataRow("CDUPSP").ToString.Trim()
            objClaseGeneral.TDUPSP = objDataRow("TDUPSP").ToString.Trim()
            lbeClaseGeneral.Add(objClaseGeneral)
        Next
        Return lbeClaseGeneral
    End Function

    Private Sub Cargar_CeBe_x_Tipo(ByVal pstrTipo As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim olCentroCosto As List(Of CentroCosto)
        Dim strCeBe As String

        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Costo"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        If pstrTipo = "P" Then

            
            If strCeBe = "" Then Return ' si no hay valor de centro beneficio sale
            olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, strCeBe)

            
        Else

           
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            If strCeBe = "" Then Return ' si no hay valor de centro beneficio sale
            olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, strCeBe)
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
          
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        End If
    End Sub

    Private Sub cboCentroCostoPropio_CambioDeTexto(ByVal objData As System.Object)
        Try
            Cargar_CeBe_x_Tipo("P")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCentroCostoTercero_CambioDeTexto(ByVal objData As System.Object)
        Try
            Cargar_CeBe_x_Tipo("T")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Validar_Cliente_Interno_Factura(ByVal pstrCclnt As String)
        Dim oCliente As New clsCliente
        ' se muestra origen solo si cliente para factura es interno 
        gbOrigen.Visible = oCliente.Validar_Cliente_Interno_Factura(oTarifa.CCMPN, pstrCclnt).Count > 0
    End Sub

    Private Sub Seleccionar_CeBe_Origen_Flete(ByRef objCeCo As Object, ByVal strTipoCeBe As String)
        Dim beCeCo As CentroCostoTarifa = CType(objCeCo, CentroCostoTarifa)
        Dim strCodCeBeDestino As String = String.Empty
        Dim strCeBeDestino As String = String.Empty

        If Not beCeCo Is Nothing Then
            strCodCeBeDestino = beCeCo.COD_CEBE
            strCeBeDestino = String.Format("{0}  {1}", beCeCo.COD_CEBE, beCeCo.DESC_CEBE)
        End If
        If strTipoCeBe = "P" Then
            txtOrigenP.Tag = strCodCeBeDestino
            txtOrigenP.Text = strCeBeDestino
        Else
            txtTerceroP.Tag = strCodCeBeDestino
            txtTerceroP.Text = strCeBeDestino
        End If
    End Sub

    'Private Sub cboCeCoOrigenP_CambioDeTexto(ByVal objData As System.Object)
    '    Try
    '        'Seleccionar_CeBe_Origen_Flete(cboCeCoOrigenP.Resultado, "P")   'JM
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub cboCeCoOrigenT_CambioDeTexto(ByVal objData As System.Object)
    '    Try
    '        'Seleccionar_CeBe_Origen_Flete(cboCeCoOrigenT.Resultado, "T")   'JM
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Limpiar_CeBe_CeCo_Transporte()

        txtCeBeDestinoP.Text = ""
        txtCeBeDestinoP.Tag = ""
        txtCebeDestinoT.Text = ""
        txtCebeDestinoT.Tag = ""
        txtCeCoDestinoP.Text = ""
        txtCeCoDestinoP.Tag = ""
        txtCeCoDestinoT.Text = ""
        txtCeCoDestinoT.Tag = ""
    End Sub

    'RCS-HUNDRED-FIN

    Private Sub Validar_Servicio()
        If cboServicio.Resultado Is Nothing Then
            SplitC001.Panel2Collapsed = True
            If cboTipoTarifa.SelectedValue = "R" Then
                Me.Height = 474 + intAjusteAltoForm
            Else
                Me.Height = 306 + intAjusteAltoForm
            End If
            pnlFlete.Visible = False
            SplitC001.SplitterDistance = 320
            lblCliOpe.Visible = False
            lblCliFac.Visible = False
            cboClienteOp.Visible = False
            UcCliente.Visible = False
            Mostrar_CentCosto_Cliente_Interno(bolClienteInterno) 'RCS-HUNDRED
        Else
            Dim PNNRRUBR As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR
            Dim PNNRSRRB As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB
            Dim PSCSRVC As String = CType(cboServicio.Resultado, Servicio_X_Rubro).CSRVC
            If PSCSRVC <> "" Then
                Mostrar_CentCosto_Cliente_Interno(False) 'RCS-HUNDRED
                SplitC001.Panel2Collapsed = False
                Me.Height = 780 + intAjusteAltoForm
                pnlFlete.Visible = True
                SplitC002.Panel2Collapsed = True
                SplitC001.SplitterDistance = 408 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                lblCliOpe.Visible = True
                lblCliFac.Visible = True
                cboClienteOp.Visible = True
                UcCliente.Visible = True
                '<[AHM]>
                _modoVisualTarifa = ModoVisualTarifa.Flete
                '</[AHM]>
            Else
                SplitC001.Panel2Collapsed = True
                pnlFlete.Visible = False
                If cboTipoTarifa.SelectedValue = "R" Then
                    Me.Height = 406 + intAjusteAltoForm
                Else
                    Me.Height = 306 + intAjusteAltoForm
                End If
                lblCliOpe.Visible = False
                lblCliFac.Visible = False
                cboClienteOp.Visible = False
                UcCliente.Visible = False
                '<[AHM]>
                _modoVisualTarifa = ModoVisualTarifa.Almacen
                '</[AHM]>
                Mostrar_CentCosto_Cliente_Interno(bolClienteInterno) 'RCS-HUNDRED
            End If
        End If
    End Sub

    Private Sub cboParametroFacturar_CambioDeTexto(ByVal objData As System.Object) Handles cboParametroFacturar.CambioDeTexto
        Try
            Visualizar_Registro_Rango()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboParametroPagar_CambioDeTexto(ByVal objData As System.Object) Handles cboParametroPagar.CambioDeTexto
        Try
            Visualizar_Registro_Rango()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Try
            Dim ofrmDetalleTarifa As New frmTarifaFleteRuta
            If Me.dtgTarifaFleteRuta.RowCount > 0 Then
                ofrmDetalleTarifa.DetalleTarifaFlete = dtgTarifaFleteRuta.DataSource
            End If
            'ofrmDetalleTarifa.Tarifa_Tipo_Rango = Not Split0003.Panel2Collapsed
            'ofrmDetalleTarifa.EsRangoTarifaExceso = EsRangoTarifaExceso
           
            If ofrmDetalleTarifa.ShowDialog Then
                dtgTarifaFleteRuta.DataSource = Nothing
                dtgTarifaFleteRuta.AutoGenerateColumns = False
                dtgTarifaFleteRuta.DataSource = ofrmDetalleTarifa.DetalleTarifaFlete
                dtgTarifaFleteRuta.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If Me.dtgTarifaFleteRuta.CurrentCellAddress.Y = -1 Then Exit Sub
            If Me.dtgTarifaFleteRuta.CurrentRow.Cells("ILCFTR").Value = "0" Then 'RCS-HUNDRED

                If EsParametroRangosExceso() = True Or EsParametroRangos() = True Then
                    'If Validar_Parametro_Rango() = True Then
                    For intTable As Integer = 0 To oDsImporteTarifa.Tables.Count - 1
                        If oDsImporteTarifa.Tables(intTable).TableName = dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value.ToString.Trim Then
                            oDsImporteTarifa.Tables.Remove(oDsImporteTarifa.Tables(intTable).TableName)
                        End If
                    Next
                End If
                Me.dtgTarifaFleteRuta.Rows.Remove(Me.dtgTarifaFleteRuta.Rows(Me.dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value - 1))
                dtgTarifaFleteRuta.EndEdit()
            Else
                If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
                    Eliminar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub Listar_Rango_Tarifa_TFlete()
        dtgImporte.Rows.Clear()
        Dim objEntidad As New RangoTarifaXTarifaFlete
        Dim lobjRangoTarifaXTarifaFlete As New List(Of RangoTarifaXTarifaFlete)
        objEntidad.CCMPN = oTarifa.CCMPN
        objEntidad.NRCTSL = oTarifa.NRCTSL
        objEntidad.NRTFSV = oTarifa.NRTFSV
        objEntidad.NCRRSR = dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value

        lobjRangoTarifaXTarifaFlete = oRangoTarifaFlete.Listar_Rango_Tarifa_X_Tarifa_Flete(objEntidad)


       
      
    End Sub

  

  

    Private Function Validar_Grilla_Importe() As Boolean
        Dim bolRspta As Boolean = True
        For i As Integer = 0 To dtgImporte.Rows.Count - 2
            If dtgImporte.Rows(i).Cells("QIMPIN").Value Is Nothing Then
                MessageBox.Show("El Importe Inicial debe ser mayor a cero.")
                bolRspta = False
                Exit For
            End If
            If dtgImporte.Rows(i).Cells("QIMPFN").Value Is Nothing Then
                MessageBox.Show("El Importe Final debe ser mayor a cero.")
                bolRspta = False
                Exit For
            End If
        Next
        Return bolRspta
    End Function

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try

            If Me.dtgTarifaFleteRuta.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim ofrmDetalleTarifa As New frmTarifaFleteRuta
            'ofrmDetalleTarifa.Tarifa_Tipo_Rango = Not Split0003.Panel2Collapsed
            If Me.dtgTarifaFleteRuta.RowCount > 0 Then
                ofrmDetalleTarifa.DetalleTarifaFlete = dtgTarifaFleteRuta.DataSource
            End If
            ofrmDetalleTarifa.DetalleTarifaFleteMod = dtgTarifaFleteRuta.CurrentRow.DataBoundItem
            If ofrmDetalleTarifa.ShowDialog Then
                dtgTarifaFleteRuta.DataSource = Nothing
                dtgTarifaFleteRuta.AutoGenerateColumns = False
                dtgTarifaFleteRuta.DataSource = ofrmDetalleTarifa.DetalleTarifaFlete
                dtgTarifaFleteRuta.Refresh()
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    

   

    Private Function Validar_Tarifa_Flete_Ruta() As Boolean
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
        Dim _dblCFRMPG1 As Double = 0
        Dim _dblCFRMPG2 As Double = 0
        If cboParametroFacturar.Resultado IsNot Nothing Then
            _dblCFRMPG1 = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            _dblCFRMPG1 = 0
        End If
        If cboParametroPagar.Resultado IsNot Nothing Then
            _dblCFRMPG2 = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        Else
            _dblCFRMPG2 = 0
        End If
        If _dblCFRMPG1 = 8 Or _dblCFRMPG1 = 15 Or _dblCFRMPG2 = 8 Or _dblCFRMPG2 = 15 Then
            If dtgImporte.Rows.Count = 1 Then
                strError += "* Rango(s) de Tarifa" & Chr(13)
            End If
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

   

    Private Sub Eliminar()
        Dim obeTarifaFleteRuta As New SOLMIN_CTZ.Entidades.DetalleTarifaTipoFlete

        obeTarifaFleteRuta.CCMPN = oTarifa.CCMPN
        obeTarifaFleteRuta.NRCTSL = oTarifa.NRCTSL
        obeTarifaFleteRuta.NRTFSV = oTarifa.NRTFSV
        obeTarifaFleteRuta.NCRRSR = Me.dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value
        obeTarifaFleteRuta.CULUSA = ConfigurationWizard.UserName
        obeTarifaFleteRuta.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        If oDetTarTipFlete.Eliminar_Detalle_Tarifa_Tipo_Flete(obeTarifaFleteRuta) = 1 Then
            Dim olistRutaFlete As New List(Of DetalleTarifaTipoFlete)
            Dim oRutaFlete As New DetalleTarifaTipoFlete
            oRutaFlete = Me.dtgTarifaFleteRuta.CurrentRow.DataBoundItem
            olistRutaFlete = dtgTarifaFleteRuta.DataSource
            olistRutaFlete.Remove(oRutaFlete)
            dtgTarifaFleteRuta.CurrentCell = Nothing
            dtgTarifaFleteRuta.DataSource = Nothing
            dtgTarifaFleteRuta.AutoGenerateColumns = False
            dtgTarifaFleteRuta.DataSource = olistRutaFlete
        End If
    End Sub


    Private Sub btnCancelarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTarifa.Click
        Me.Close()
    End Sub

    Private Sub cmbMoneda_CambioDeTexto(ByVal objData As Object) Handles cmbMoneda.CambioDeTexto
        Try
            Generar_Tarifa()
            If cmbMoneda.Resultado IsNot Nothing Then

                CargarTarifaReferencial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub cmbUnidadMedida_CambioDeTexto(ByVal objData As System.Object) Handles cmbUnidadMedida.CambioDeTexto
        Try
            Generar_Tarifa()
            If cmbUnidadMedida.Resultado IsNot Nothing Then

                CargarTarifaReferencial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtCantidad_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Try
            Generar_Tarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Function Validar_Tarifa() As Boolean
        If Validar_Controles_Visibles() = True Then
            If cboServicio.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe Seleccionar el Servicio", MessageBoxIcon.Information)
                Return False
            End If
            If cboLogicaFacturacion.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe Seleccionar Lógica de Facturación", MessageBoxIcon.Information)
                Return False
            End If
            Dim dblNum As Double
            Decimal.TryParse(Me.txtMonto.Text.Trim, dblNum)
            If dblNum = 0 AndAlso cboTipoTarifa.SelectedValue <> "R" Then
                MessageBox.Show("Debe ingresar importe válido mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If Me.cboTipoTarifa.SelectedValue = "R" Then
                For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                    If obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" Then
                        If CDbl(obj.Cells("RangoInicial").Value.ToString()) > CDbl(obj.Cells("RangoFinal").Value.ToString()) Then
                            Return False
                        End If
                        If CInt(obj.Cells("Tarifa").Value.ToString()) = 0 Then
                            Return False
                        End If
                    End If
                Next
            End If
            If cmbUnidadMedida.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe Seleccionar la Unidad de Medida", MessageBoxIcon.Information)
                Return False
            End If

            If Me.cmbCentroBeneficio.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe Seleccionar un Centro de Costo", MessageBoxIcon.Information)
                Return False
            End If

            If cmbMoneda.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe Seleccionar la Moneda", MessageBoxIcon.Information)
                Return False
            End If

            If TxtTipoMaterial.Resultado Is Nothing AndAlso cboTipoTarifa.SelectedValue = "D" Then
                HelpClass.MsgBox("Debe de seleccionar el Tipo de Mercadería", MessageBoxIcon.Information)
                Return False
            End If

            If txtTipoAlmacen.Resultado Is Nothing AndAlso cboTipoTarifa.SelectedValue = "D" Then
                HelpClass.MsgBox("Debe de seleccionar el Tipo de Almacén", MessageBoxIcon.Information)
                Return False
            End If

            '<[AHM]>
            'SI LA COMPAÑIA PERTENECE A SALMON SE CONTINUA CON LAS SIGUIENTES VALIDACIONES
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
                'Exit Function
                Return True
            End If

            'VALIDACION DE TARIFA EN SAP
            Dim servicioXRubro As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)


            Dim objTarifa As New Tarifa
            objTarifa.CCMPN = oTarifa.CCMPN
            objTarifa.CRGVTA = oContrato.CRGVTA
            objTarifa.TSRVIN = servicioXRubro.TSRVIN
            Dim tarifaSAP As TarifaSAP = (New clsTarifa).ValidarMaterialSAP(objTarifa)
            If (Not tarifaSAP.EsValida) Then
                HelpClass.MsgBox(String.Format("'El Material: {0} no está configurado para el negocio: {1}.{2}", servicioXRubro.NOMSER, oContrato.CRGVTA, Environment.NewLine), _
                                 MessageBoxIcon.Information)
                Return False
            End If


            If txtTipoServicio.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe de seleccionar el Tipo de Servicio", MessageBoxIcon.Information)
                Return False
            End If

            If txtUnidadProductiva.Resultado Is Nothing Then
                HelpClass.MsgBox("Debe de seleccionar  la  Unidad Productiva", MessageBoxIcon.Information)
                Return False
            End If

            If cboTipoActivo.SelectedValue = "" Then
                HelpClass.MsgBox("Debe de seleccionar el Tipo Activo", MessageBoxIcon.Information)
                Return False
            End If
            '</[AHM]>
            Return True 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        Else
            Dim strError As String = String.Empty '"DEBE DE INGRESAR: " & Chr(13)'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            If cboServicio.Resultado Is Nothing Then
                strError += "* Servicio" & Chr(13)
            End If
            If cboLogicaFacturacion.Resultado Is Nothing Then
                strError += "* Lógica de Facturación" & Chr(13)
            End If
            If cboClienteOp.Resultado Is Nothing Then
                strError += "* Cliente Operación" & Chr(13)
            End If
            If UcCliente.pCodigo = 0 Then
                strError += "* Cliente a Facturar" & Chr(13)
            End If

            'SI LA COMPAÑIA PERTENECE A SALMON SE APLICA CON LAS SIGUIENTES VALIDACIONES
         
            '</[AHM]>


            If txtCeBeDestinoP.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                strError += "* Centro de Costo Propio" & Chr(13)
            End If


            If txtCebeDestinoT.Tag = "" Then 'ECM-HUNDRED - SGR - DEF - SALMON - ST - FASE2 - VENTA - INTERNA - PT)
                strError += "* Centro de Costo Tercero" & Chr(13)
            End If

            If cboSectorxGasto.Resultado Is Nothing Then
                strError += "* Sector por Gasto" & Chr(13)
            End If
            If cboMercaderia.Resultado Is Nothing Then
                strError += "* Tipo de Mercadería" & Chr(13)
            End If
            If cboUnidadVehicular.Resultado Is Nothing Then
                strError += "* Unidad Vehicular" & Chr(13)
            End If

            If cboParametroFacturar.Resultado Is Nothing Then
                strError += "* Parámetro a Facturar" & Chr(13)
            End If

            If cboParametroPagar.Resultado Is Nothing Then
                strError += "* Parámetro a Pagar" & Chr(13)
            End If
            If cboSeguroCotizacion.Resultado Is Nothing Then
                strError += "* Seguro de Cotización" & Chr(13)
            ElseIf CType(cboSeguroCotizacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO = "C" Then
                If (txtPolizaSeguro.Text.Length = 0 OrElse Not IsNumeric(Me.txtPolizaSeguro.Text) OrElse Me.txtPolizaSeguro.Text = 0) Then
                    strError += "* Póliza de Seguro" & Chr(13)
                End If
                If cboCompaniaSeguro.Resultado Is Nothing Then
                    strError += "* Compañía de Seguro" & Chr(13)
                End If
            End If
            If cboTipoServicioTransp.Resultado Is Nothing Then
                strError += "* Tipo de Servicio Transporte" & Chr(13)
            End If
            If cboTipoSubServicio.Resultado Is Nothing Then
                strError += "* Tipo de Sub Servicio" & Chr(13)
            End If

            If txtCantidadMercaderia.Text = "" Then
                strError += "* Cantidad de Mercadería" & Chr(13)
            End If

            If cboUnidadMedida.Resultado Is Nothing Then
                strError += "* Unidad de Medida" & Chr(13)
            End If

            If dtgTarifaFleteRuta.Rows.Count <= 0 Then
                strError += "* Por lo menos un Detalle de Tarifa" & Chr(13)
            End If

            If Not Split0003.Panel2Collapsed AndAlso Not dtgTarifaFleteRuta.DataSource Is Nothing Then
                For Each obeDetalleRarifaFlete As DetalleTarifaTipoFlete In dtgTarifaFleteRuta.DataSource

                    If obeDetalleRarifaFlete.RangoTarifa Is Nothing OrElse obeDetalleRarifaFlete.RangoTarifa.Count = 0 Then
                        strError += "* El detalle de la Tarifa no contiene Rango de tarifa" & Chr(13)
                    End If

                Next
            End If

            'RCS-HUNDRED-INICIO

            '<[AHM]>
            'SI LA COMPAÑIA PERTENECE A SALMON SE CONTINUA CON LAS SIGUIENTES VALIDACIONES
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
                Return True
            End If

            'VALIDACION DE TARIFA EN SAP
            Dim servicioXRubro As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)


            Dim objTarifa As New Tarifa
            objTarifa.CCMPN = oTarifa.CCMPN
            objTarifa.CRGVTA = oContrato.CRGVTA
            objTarifa.TSRVIN = servicioXRubro.TSRVIN
            Dim tarifaSAP As TarifaSAP = (New clsTarifa).ValidarMaterialSAP(objTarifa)

            If (Not tarifaSAP.EsValida) Then
                HelpClass.MsgBox(String.Format("'El Material: {0} no está configurado para el negocio: {1}.{2}", servicioXRubro.NOMSER, oContrato.CRGVTA, Environment.NewLine), _
                                 MessageBoxIcon.Information)
                Return False
            End If

            '<[AHM]>
            If txtTipoServicioTransporte.Resultado Is Nothing Then
                strError += "* Tipo de Servicio SAP  " & Chr(13) 'RCS-HUNDRED
            End If

            If txtUnidadProductivaTransporte.Resultado Is Nothing Then
                strError += "* Unidad Productiva " & Chr(13) 'RCS-HUNDRED
            End If

            If cboNivelServ.Resultado Is Nothing Then
                strError += "* Nivel Serv." & Chr(13)
            End If
            If cboParametroTarifaInterna.Resultado Is Nothing Then
                strError += "* Parámetro Tarifa Interna" & Chr(13)
            End If
            If cboTipoCargaTransporte.Resultado Is Nothing Then
                strError += "* Tipo Carga" & Chr(13)
            End If

            If txtCeCoDestinoP.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                strError += "* CeCo Propio (Destino)" & Chr(13)
            End If


            If txtCeCoDestinoT.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                strError += "* CeCo Tercero (Destino)" & Chr(13)
            End If
            If txtOrigenP.Tag = "" Then
                strError += "* CeBe Propio (Origen)" & Chr(13)
            End If

            If String.IsNullOrEmpty(txtCeCoOrigenP.Tag) Then
                strError += "* CeCo Propio (Origen)" & Chr(13)
            End If
          
            If txtTerceroP.Tag = "" Then
                strError += "* CeBe Tercero (Origen)" & Chr(13)
            End If

            If String.IsNullOrEmpty(txtCeCoOrigenT.Tag) Then
                strError += "* CeCo Tercero (Origen)" & Chr(13)
            End If
          


            If strError.Trim.Length > 17 Then
                HelpClass.MsgBox("DEBE DE INGRESAR: " & Chr(13) & strError, MessageBoxIcon.Warning) 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                Return False
            Else
                Return True

            End If
        End If
    End Function

    Private Sub btnGrabarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarTarifa.Click
        Try
            If Validar_Tarifa() = True Then
                If Validar_Controles_Visibles() = True Then
                    Dim objTarifa As New Tarifa
                    Dim oTrfTemp As New Tarifa
                    Dim objProcesoTarifa As New clsTarifa
                    Generar_Tarifa()
                    objTarifa.NRCTSL = oTarifa.NRCTSL
                    objTarifa.CCMPN = oTarifa.CCMPN

                    Dim PNNRRUBR As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR
                    Dim PNNRSRRB As Decimal = CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB
                  
                    objTarifa.NRRUBR = PNNRRUBR
                    objTarifa.NRSRRB = PNNRSRRB
                    oTrfTemp = objProcesoTarifa.ObtenerDivTarifa_RZSC08(objTarifa)
                    objTarifa.CDVSN = oTrfTemp.CDVSN
                    objTarifa.NRRUBR = oTrfTemp.NRRUBR
                    objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
                    objTarifa.CMNDA1 = CType(cmbMoneda.Resultado, Moneda).CMNDA1 'cmbMoneda.SelectedValue
                    objTarifa.CUNDMD = CType(cmbUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD 'cmbUnidadMedida.SelectedValue
                    objTarifa.CCNTCS = CType(cmbCentroBeneficio.Resultado, CentroCosto).PNCCNTCS 'cmbCentroCosto.SelectedValue
                    objTarifa.MntTarifa = oTarifaDescripciones.MntTarifa
                    objTarifa.IVLSRV = IIf(txtMonto.Text.Trim = "", 0, txtMonto.Text.Trim)
                    objTarifa.VALCTE = CDbl(Me.txtCantidad.Text)
                    objTarifa.TOBS = txtDescripcion.Text
                    objTarifa.PRLBPG = Val(Me.txtPeriodoLibre.Text)

                    'Falta
                    objTarifa.NDIAPL = txtDiasFacturar.Text

                    objTarifa.NRTFSV = oTarifa.NRTFSV
                    objTarifa.FAPLBR = IIf(chkPeriodoLibre.Checked, "X", "")
                    objTarifa.NRRELF = CType(cboLogicaFacturacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO_LF

                    If Not TxtTipoMaterial.Resultado Is Nothing Then
                        objTarifa.TTPOMR = CType(TxtTipoMaterial.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CCMPRN
                    End If

                    If Not txtTipoAlmacen.Resultado Is Nothing Then
                        objTarifa.CTPALM = CType(txtTipoAlmacen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPALM
                    End If

                    'Tarifa fija referencial   ...jm   +
                    If Not txtCodTarifaRef.Resultado Is Nothing Then
                        objTarifa.CDTREF = CType(txtCodTarifaRef.Resultado, Tarifa).CDTREF
                    End If
                    If Not String.IsNullOrEmpty(txtDiasdeCorte.Text.Trim) Then
                        objTarifa.DIACOR = Double.Parse(txtDiasdeCorte.Text.Trim)
                    End If

                    '<[AHM]>
                    objTarifa.CDSDSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSDSP
                    objTarifa.CDSRSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSRSP
                    objTarifa.CDTSSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDTSSP
                    objTarifa.CDTASP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDTASP
                    objTarifa.CDSPSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSPSP
                    objTarifa.CDUPSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDUPSP
                    objTarifa.CDSCSP = CType(cmbCentroBeneficio.Resultado, CentroCosto).PSCDSCSP
                    '</[AHM]>

                    Select Case Me.cboTipoTarifa.SelectedValue
                        Case "F"
                            objTarifa.STPTRA = "F"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        Case "C"
                            objTarifa.STPTRA = "C"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        Case "R"
                            objTarifa.STPTRA = "R"
                            If dtgRangoTarifa.RowCount = 0 Then Exit Sub
                            objTarifa.DESTAR = "Por Rango"
                        Case "D"
                            objTarifa.STPTRA = "D"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        Case "S"
                            objTarifa.STPTRA = "S"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        Case "Q"
                            objTarifa.STPTRA = "Q"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                        Case "M"
                            objTarifa.STPTRA = "M"
                            objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                    End Select
                    '-----------------------------------------------
                    Guardar_Cliente_Interno(objTarifa) 'RCS-HUNDRED

                    If objTarifa.NRTFSV <> 0 Then
                        objProcesoTarifa.Modificar_Tarifa_RZSC03(objTarifa)
                    Else
                        objTarifa.NRTFSV = objProcesoTarifa.Crear_Tarifa_RZSC03(objTarifa)
                    End If

                    ' If cboTipoTarifa.SelectedIndex = 2 Then
                    If cboTipoTarifa.SelectedValue = "R" Then
                        For i As Integer = 0 To dtgRangoTarifa.Rows.Count - 1
                            Dim objRango As New Rango
                            objRango.VALMIN = dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value.ToString()
                            objRango.VALMAX = dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value.ToString()
                            objRango.IVLSRV = dtgRangoTarifa.Rows(i).Cells("Tarifa").Value.ToString()
                            objRango.NRRNGO = dtgRangoTarifa.Rows(i).Cells("CodRango").Value.ToString()
                            objRango.DESRNG = txtDescripcion.Text.Trim & " (Rango)"
                            objProcesoTarifa.Crear_Rango_RZSC03A(objRango, objTarifa)
                        Next
                    End If

                    Select Case _Tipo
                        Case EnumTipo.Nuevo
                            If objTarifa.NRTFSV <> 0 Then
                                MessageBox.Show("Se ha creado la Tarifa:" & objTarifa.NRTFSV, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                    End Select

                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Else
                    If _Tipo = EnumTipo.Nuevo Then
                        Dim msgVerificacion As String = ""
                        Dim pobjFiltro As New Filtro
                        Dim msgError As String = ""
                        pobjFiltro.Parametro1 = oTarifa.CCMPN
                        pobjFiltro.Parametro2 = UcDivision.Division
                        pobjFiltro.Parametro3 = UcPLanta_Cmb011.Planta
                       
                        pobjFiltro.Parametro4 = txtCeBeDestinoP.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                        pobjFiltro.Parametro5 = txtCebeDestinoT.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

                        pobjFiltro.Parametro7 = CType(cboPlantaFact.Resultado, bePlanta).Cplndv 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                        pobjFiltro.Parametro8 = ("" & cboTipo.ComboBox.SelectedValue).ToString.Trim 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

                        pobjFiltro.Parametro6 = IIf(cboServicio.Resultado IsNot Nothing, CType(cboServicio.Resultado, SOLMIN_CTZ.Entidades.Servicio_X_Rubro).CSRVC, 0)
                        Try
                            msgVerificacion = oServicio.VerificarConfiguracionOrdenServicio(pobjFiltro)
                        Catch ex As Exception
                            msgVerificacion = ""
                            msgError = msgError & Chr(13) & ex.Message
                        End Try

                        If msgVerificacion.Length > 0 Then
                            MessageBox.Show("No se puede Generar OS.Verificar:" & Chr(13) & msgVerificacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If

                    Grabar_Tarifa_Flete()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboTipoServicioTransp_CambioDeTexto(ByVal objData As System.Object) Handles cboTipoServicioTransp.CambioDeTexto
        Try
            Cargar_Tipo_SubServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Grabar_Tarifa_Flete()

        Dim objTarifa As New Tarifa
        Dim objProcesoTarifa As New clsTarifa
        Dim oTrfTemp As New Tarifa
        Dim PNNRRUBR As Decimal = IIf(cboServicio.Resultado IsNot Nothing, CType(cboServicio.Resultado, Servicio_X_Rubro).NRRUBR, 0)
        Dim PNNRSRRB As Decimal = IIf(cboServicio.Resultado IsNot Nothing, CType(cboServicio.Resultado, Servicio_X_Rubro).NRSRRB, 0)

        objTarifa.NRTFSV = oTarifa.NRTFSV
        objTarifa.NRCTSL = oTarifa.NRCTSL
        objTarifa.CCMPN = oTarifa.CCMPN
        objTarifa.NRRUBR = PNNRRUBR
        objTarifa.NRSRRB = PNNRSRRB
        objTarifa.CDVSN = UcDivision.Division 'oTrfTemp.CDVSN
        objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
        objTarifa.CMNDA1 = 1 'CType(cmbMoneda.Resultado, Moneda).CMNDA1
        objTarifa.CCLNT = CType(cboClienteOp.Resultado, SOLMIN_CTZ.Entidades.Contrato).CCLNT  ' cboClienteOp.pCodigo
        objTarifa.CCLNFC = UcCliente.pCodigo

        objTarifa.CCNTCS = txtCeBeDestinoP.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        objTarifa.CCNCS1 = txtCebeDestinoT.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        objTarifa.SSCGST = CType(cboSectorxGasto.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO
        objTarifa.CMRCDR = CType(cboMercaderia.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMRCDR
        objTarifa.CTPUNV = CType(cboUnidadVehicular.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPUNV
        objTarifa.CFRMPG = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        objTarifa.CFRAPG = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        objTarifa.SSGRCT = CType(cboSeguroCotizacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO
        objTarifa.NPLSGC = IIf(Me.txtPolizaSeguro.Text.Trim.Equals("") = True, "0", Me.txtPolizaSeguro.Text)
        If cboCompaniaSeguro.Resultado IsNot Nothing Then
            objTarifa.CCMPSG = CType(cboCompaniaSeguro.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CCMPSG
        Else
            objTarifa.CCMPSG = "0"
        End If
        objTarifa.QPRCS1 = IIf(Me.txtRecargoSeguro.Text = "", "0", Me.txtRecargoSeguro.Text)
        objTarifa.CTPOSR = CType(cboTipoServicioTransp.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPOSR
        objTarifa.QMRCDR = IIf(Me.txtCantidadMercaderia.Text.Equals("") = True, "0", txtCantidadMercaderia.Text)
        objTarifa.CUNDMD = CType(cboUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD
        objTarifa.VMRCDR = IIf(Me.txtValorMercaderia.Text.Trim.Equals("") = True, "0", Me.txtValorMercaderia.Text)
        objTarifa.LMRCDR = IIf(Me.txtVolumen.Text.Trim.Equals("") = True, "0", Me.txtVolumen.Text)
        objTarifa.TRFMRC = IIf(Me.txtReferenciaMerc.Text.Trim.Length <= 40, Me.txtReferenciaMerc.Text.Trim, "")
        objTarifa.PMRCDR = IIf(Me.txtPesoMercaderia.Text.Equals("") = True, "0", Me.txtPesoMercaderia.Text)
        objTarifa.STPTRA = "T"
        objTarifa.DESTAR = "TARIFA FLETE"
        objTarifa.VALCTE = "0"
        objTarifa.IVLSRV = "0"
        objTarifa.CTPSBS = CType(cboTipoSubServicio.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPSBS
        objTarifa.PRLBPG = 0
        objTarifa.FAPLBR = ""
        objTarifa.TOBS = ""
        objTarifa.SFLZNP = IIf(Me.chkFleteZonaPrimaria.Checked = True, "X", " ")
        objTarifa.SFSANF = IIf(Me.chkServicioAfecto.Checked = True, "1", "3")
        objTarifa.STSTRF = 0
        objTarifa.NORSRT = 0
        objTarifa.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objTarifa.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objTarifa.NRRELF = CType(cboLogicaFacturacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO_LF

        '<[AHM]>
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
   
        Dim tipoServicioTransporte As ClaseGeneral = CType(txtTipoServicioTransporte.Resultado, ClaseGeneral) 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        objTarifa.CDTSSP = tipoServicioTransporte.CDTSSP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    
        Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral) ''ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        objTarifa.CDUPSP = unidadProductivaTransporte.CDUPSP ''ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        '</[AHM]>

        'RCS-HUNDRED-INICIO
        objTarifa.CTTRAN = CType(cboNivelServ.Resultado, DatosGenerales).CODIGO
        objTarifa.CPATIN = CType(cboParametroTarifaInterna.Resultado, ClaseGeneral).CFRMPG
        objTarifa.CTIPCG = CType(cboTipoCargaTransporte.Resultado, DatosGenerales).CODIGO

        objTarifa.CENCOS = txtCeCoDestinoP.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        objTarifa.CENCO1 = txtCeCoDestinoT.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        objTarifa.CCNTBN = IIf(txtOrigenP.Tag.ToString() = "", "0", txtOrigenP.Tag.ToString())

        objTarifa.CENCO2 = IIf(txtCeCoOrigenP.Tag.ToString() = "", "0", txtCeCoOrigenP.Tag) 'JM
        objTarifa.CCNTB1 = IIf(txtTerceroP.Tag.ToString() = "", "0", txtTerceroP.Tag)

        objTarifa.CENCO3 = IIf(txtCeCoOrigenT.Tag.ToString() = "", "0", txtCeCoOrigenT.Tag) 'JM

        objTarifa.CPLNFC = CType(cboPlantaFact.Resultado, bePlanta).Cplndv 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        objTarifa.FTCLNT = cboTipo.SelectedValue 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        'RCS-HUNDRED-FIN
        If objTarifa.NRTFSV = 0 Then
            objTarifa.NRTFSV = objProcesoTarifa.Crear_Tarifa_Flete_RZSC03(objTarifa)
            'Tarifa Flete Ruta
            Dim olDetTarTipFlete As New List(Of DetalleTarifaTipoFlete)
            Dim obeDetTarTipFlete As New DetalleTarifaTipoFlete
            For i As Integer = 0 To dtgTarifaFleteRuta.Rows.Count - 1
                obeDetTarTipFlete.CCMPN = oTarifa.CCMPN
                obeDetTarTipFlete.NRCTSL = oTarifa.NRCTSL
                obeDetTarTipFlete.NRTFSV = objTarifa.NRTFSV
                obeDetTarTipFlete.CUBORI = dtgTarifaFleteRuta.Rows(i).Cells("CUBORI").Value
                obeDetTarTipFlete.CLCLOR = dtgTarifaFleteRuta.Rows(i).Cells("CLCLOR").Value
                obeDetTarTipFlete.CUBDES = dtgTarifaFleteRuta.Rows(i).Cells("CUBDES").Value
                obeDetTarTipFlete.CLCLDS = dtgTarifaFleteRuta.Rows(i).Cells("CLCLDS").Value
                obeDetTarTipFlete.CMNTRN = dtgTarifaFleteRuta.Rows(i).Cells("CMNTRN").Value
                obeDetTarTipFlete.TOBSSR = dtgTarifaFleteRuta.Rows(i).Cells("TOBSSR").Value
                If obeDetTarTipFlete.TOBSSR Is Nothing Then
                    obeDetTarTipFlete.TOBSSR = " "
                End If
                obeDetTarTipFlete.QDSTVR = dtgTarifaFleteRuta.Rows(i).Cells("QDSTVR").Value
                obeDetTarTipFlete.CSTNDT = dtgTarifaFleteRuta.Rows(i).Cells("CSTNDT").Value
                obeDetTarTipFlete.ITRSRT = dtgTarifaFleteRuta.Rows(i).Cells("ITRSRT").Value
                obeDetTarTipFlete.CMNTRN = dtgTarifaFleteRuta.Rows(i).Cells("CMNTRN").Value
                obeDetTarTipFlete.ILSFTR = dtgTarifaFleteRuta.Rows(i).Cells("ILSFTR").Value
                obeDetTarTipFlete.CMNLQT = dtgTarifaFleteRuta.Rows(i).Cells("CMNLQT").Value
                obeDetTarTipFlete.SFCRTV = dtgTarifaFleteRuta.Rows(i).Cells("SFCRTV").Value
                obeDetTarTipFlete.SSRVFE = dtgTarifaFleteRuta.Rows(i).Cells("SSRVFE").Value
                obeDetTarTipFlete.ILCFTR = dtgTarifaFleteRuta.Rows(i).Cells("ILCFTR").Value
                obeDetTarTipFlete.CUNSRA = dtgTarifaFleteRuta.Rows(i).Cells("CUNSRA").Value
                obeDetTarTipFlete.CSRCTZ = CType(cboServicio.Resultado, SOLMIN_CTZ.Entidades.Servicio_X_Rubro).CSRVNV
                obeDetTarTipFlete.SESTRG = "A"
                'obeDetTarTipFlete.FLAG = dtgTarifaFleteRuta.Rows(i).Cells(30).Value
                obeDetTarTipFlete.FLAG = dtgTarifaFleteRuta.Rows(i).Cells("existe").Value
                obeDetTarTipFlete.SSRVPG = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SSRVPG
                obeDetTarTipFlete.SSRVCB = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SSRVCB
                obeDetTarTipFlete.RangoTarifa = dtgTarifaFleteRuta.Rows(i).DataBoundItem.RangoTarifa
                obeDetTarTipFlete.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                'RCS-HUNDRED-INICIO
                obeDetTarTipFlete.CMNDTI = dtgTarifaFleteRuta.Rows(i).DataBoundItem.CMNDTI
                obeDetTarTipFlete.ISRVTI = dtgTarifaFleteRuta.Rows(i).DataBoundItem.ISRVTI
                obeDetTarTipFlete.SNTVJE = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SNTVJE

                'RCS-HUNDRED-FIN
                obeDetTarTipFlete.NCRRSR = oDetTarTipFlete.Registrar_Detalle_Tarifa_Tipo_Flete(obeDetTarTipFlete)
                If _Tipo = EnumTipo.Nuevo Then
                    If obeDetTarTipFlete.RangoTarifa IsNot Nothing Then
                        For Each obeRangoTarifaXTFlete As RangoTarifaXTarifaFlete In obeDetTarTipFlete.RangoTarifa
                            Dim olRangoTarifaXTFlete As New List(Of RangoTarifaXTarifaFlete)
                            obeRangoTarifaXTFlete.CCMPN = oTarifa.CCMPN
                            obeRangoTarifaXTFlete.NRCTSL = oTarifa.NRCTSL
                            obeRangoTarifaXTFlete.NRTFSV = objTarifa.NRTFSV
                            obeRangoTarifaXTFlete.NCRRSR = obeDetTarTipFlete.NCRRSR
                        Next
                        oRangoTarifaFlete.Actualizar_Rango_X_Tarifa_Flete(obeDetTarTipFlete.RangoTarifa)
                    End If
                End If
            Next
            Select Case _Tipo
                Case EnumTipo.Nuevo
                    If objTarifa.NRTFSV <> 0 Then
                        MessageBox.Show("Se ha creado la Tarifa:" & objTarifa.NRTFSV, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                   
            End Select

     
        Else
            objProcesoTarifa.Modificar_Tarifa_Flete_RZSC03(objTarifa)

            Dim olDetTarTipFlete As New List(Of DetalleTarifaTipoFlete)
            Dim obeDetTarTipFlete As New DetalleTarifaTipoFlete
            For i As Integer = 0 To dtgTarifaFleteRuta.Rows.Count - 1
                obeDetTarTipFlete.CCMPN = oTarifa.CCMPN
                obeDetTarTipFlete.NRCTSL = oTarifa.NRCTSL
                obeDetTarTipFlete.NRTFSV = objTarifa.NRTFSV

                obeDetTarTipFlete.CUBORI = dtgTarifaFleteRuta.Rows(i).Cells("CUBORI").Value
                obeDetTarTipFlete.CLCLOR = dtgTarifaFleteRuta.Rows(i).Cells("CLCLOR").Value
                obeDetTarTipFlete.CUBDES = dtgTarifaFleteRuta.Rows(i).Cells("CUBDES").Value
                obeDetTarTipFlete.CLCLDS = dtgTarifaFleteRuta.Rows(i).Cells("CLCLDS").Value
                obeDetTarTipFlete.CMNTRN = dtgTarifaFleteRuta.Rows(i).Cells("CMNTRN").Value
                obeDetTarTipFlete.TOBSSR = dtgTarifaFleteRuta.Rows(i).Cells("TOBSSR").Value
                If obeDetTarTipFlete.TOBSSR Is Nothing Then
                    obeDetTarTipFlete.TOBSSR = " "
                End If

                obeDetTarTipFlete.QDSTVR = dtgTarifaFleteRuta.Rows(i).Cells("QDSTVR").Value
                obeDetTarTipFlete.CSTNDT = dtgTarifaFleteRuta.Rows(i).Cells("CSTNDT").Value
                obeDetTarTipFlete.ITRSRT = dtgTarifaFleteRuta.Rows(i).Cells("ITRSRT").Value
                obeDetTarTipFlete.CMNTRN = dtgTarifaFleteRuta.Rows(i).Cells("CMNTRN").Value
                obeDetTarTipFlete.ILSFTR = dtgTarifaFleteRuta.Rows(i).Cells("ILSFTR").Value
                obeDetTarTipFlete.CMNLQT = dtgTarifaFleteRuta.Rows(i).Cells("CMNLQT").Value
                obeDetTarTipFlete.SFCRTV = dtgTarifaFleteRuta.Rows(i).Cells("SFCRTV").Value
                obeDetTarTipFlete.SSRVFE = dtgTarifaFleteRuta.Rows(i).Cells("SSRVFE").Value
                obeDetTarTipFlete.ILCFTR = dtgTarifaFleteRuta.Rows(i).Cells("ILCFTR").Value
                obeDetTarTipFlete.CUNSRA = dtgTarifaFleteRuta.Rows(i).Cells("CUNSRA").Value
                obeDetTarTipFlete.CSRCTZ = CType(cboServicio.Resultado, SOLMIN_CTZ.Entidades.Servicio_X_Rubro).CSRVNV
                obeDetTarTipFlete.SESTRG = "A"
                obeDetTarTipFlete.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                obeDetTarTipFlete.SSRVPG = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SSRVPG
                obeDetTarTipFlete.SSRVCB = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SSRVCB
                'RCS-HUNDRED-INICIO
                obeDetTarTipFlete.CMNDTI = dtgTarifaFleteRuta.Rows(i).DataBoundItem.CMNDTI
                obeDetTarTipFlete.ISRVTI = dtgTarifaFleteRuta.Rows(i).DataBoundItem.ISRVTI
                'RCS-HUNDRED-FIN
                obeDetTarTipFlete.SNTVJE = dtgTarifaFleteRuta.Rows(i).DataBoundItem.SNTVJE

                If dtgTarifaFleteRuta.Rows(i).DataBoundItem.NCRRSR = 0 Then
                    obeDetTarTipFlete.NCRRSR = oDetTarTipFlete.Registrar_Detalle_Tarifa_Tipo_Flete(obeDetTarTipFlete)
                    If obeDetTarTipFlete.NCRRSR = -1 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                Else
                    obeDetTarTipFlete.NCRRSR = dtgTarifaFleteRuta.Rows(i).DataBoundItem.NCRRSR
                    If oDetTarTipFlete.Actualizar_Detalle_Tarifa_Tipo_Flete(obeDetTarTipFlete) = -1 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                End If
                obeDetTarTipFlete.RangoTarifa = dtgTarifaFleteRuta.Rows(i).DataBoundItem.RangoTarifa
                If obeDetTarTipFlete.RangoTarifa IsNot Nothing Then
                    For Each obeRangoTarifaXTFlete As RangoTarifaXTarifaFlete In obeDetTarTipFlete.RangoTarifa
                        Dim olRangoTarifaXTFlete As New List(Of RangoTarifaXTarifaFlete)
                        obeRangoTarifaXTFlete.CCMPN = oTarifa.CCMPN
                        obeRangoTarifaXTFlete.NRCTSL = oTarifa.NRCTSL
                        obeRangoTarifaXTFlete.NRTFSV = objTarifa.NRTFSV
                        obeRangoTarifaXTFlete.NCRRSR = obeDetTarTipFlete.NCRRSR
                    Next
                    oRangoTarifaFlete.Actualizar_Rango_X_Tarifa_Flete(obeDetTarTipFlete.RangoTarifa)
                End If

              
            Next

            Select Case _Tipo
                Case EnumTipo.Edicion
                    If objTarifa.NRTFSV <> 0 Then
                        MessageBox.Show("Se ha modificado la Tarifa:" & objTarifa.NRTFSV, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
            End Select
        End If
    End Sub

    Private Sub txtPolizaSeguro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPolizaSeguro.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPolizaSeguro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPolizaSeguro.Leave
        Try
            If txtPolizaSeguro.Text.EndsWith(".") Then
                txtPolizaSeguro.Text = txtPolizaSeguro.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub txtRecargoSeguro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecargoSeguro.KeyPress
        Try
            CType(sender, TextBox).Tag = "3-2"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtRecargoSeguro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecargoSeguro.Leave
        Try
            If txtRecargoSeguro.Text.EndsWith(".") Then
                txtRecargoSeguro.Text = txtRecargoSeguro.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtCantidadMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadMercaderia.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPesoMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoMercaderia.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtVolumen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumen.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function SoloNumerosConDecimal(ByVal sender As TextBox, ByVal Keyascii As Short) As Short
        Dim TextBox As TextBox
        Dim NumeroTexto As String
        TextBox = CType(sender, TextBox)
        Dim ArrayEnteroDecimal() As String
        Dim NEnteros As Int32 = 0
        Dim NDecimales As Int32 = 0
        If TextBox.Tag IsNot Nothing Then
            ArrayEnteroDecimal = TextBox.Tag.ToString.Split("-")
            If ArrayEnteroDecimal.Length = 2 Then
                NEnteros = Convert.ToInt32(ArrayEnteroDecimal(0))
                NDecimales = Convert.ToInt32(ArrayEnteroDecimal(1))
            End If
        End If
        Dim InicioEnteros As String = IIf(NEnteros = 0, "0", 1)
        Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NEnteros & "}(\.[0-9]{0," & NDecimales & "})?$"
        NumeroTexto = TextBox.Text.Trim
        Dim NumeroOriginal As String = NumeroTexto
        NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
        If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
            NumeroTexto = NumeroOriginal
            SoloNumerosConDecimal = 0
        Else
            SoloNumerosConDecimal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimal = Keyascii
            Case 13
                SoloNumerosConDecimal = Keyascii
            Case 32
                SoloNumerosConDecimal = Keyascii
        End Select
    End Function

    Private Sub dtgTarifaFleteRuta_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgTarifaFleteRuta.SelectionChanged
        Try
            If Me.dtgTarifaFleteRuta.CurrentCellAddress.Y = -1 Then Exit Sub
            dtgImporte.AutoGenerateColumns = False
            dtgImporte.DataSource = CType(Me.dtgTarifaFleteRuta.CurrentRow.DataBoundItem, DetalleTarifaTipoFlete).RangoTarifa
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try 'RCS-HUNDRED
            If clsComun.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboClienteOp_CambioDeTexto(ByVal objData As System.Object) Handles cboClienteOp.CambioDeTexto
        Try

            If cboClienteOp.Resultado IsNot Nothing Then
                'RCS-HUNDRED-INICIO
                Dim strCclnt As Decimal = CType(cboClienteOp.Resultado, SOLMIN_CTZ.Entidades.Contrato).CCLNT
                UcCliente.pCargar(strCclnt)
                UcCliente_InformationChanged() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
               
            Else
                UcCliente.pClear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasFacturar.KeyPress
        Try
            CType(sender, TextBox).Tag = "3-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub txtDiasdeCorte_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasdeCorte.KeyPress
        Try
            CType(sender, TextBox).Tag = "2-0"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    '<[AHM]>
    Private Sub cmbCentroCosto_CambioDeTexto(ByVal objData As System.Object) Handles cmbCentroBeneficio.CambioDeTexto
        Try
            If cmbCentroBeneficio.Resultado IsNot Nothing Then
                CargarTarifaReferencial()
                Cargar_CentroCosto_Destino()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing

            If (txtTipoServicio.Resultado Is Nothing) Then
                Exit Sub
            End If
            Me.Cargar_CentroBeneficio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing

            If (txtUnidadProductiva.Resultado Is Nothing) Then
                Exit Sub
            End If
            Me.Cargar_CentroBeneficio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            cmbCentroBeneficio.Limpiar()
            cmbCentroBeneficio.DataSource = Nothing
            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

  

  

    Private Sub txtTipoServicioTransporte_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicioTransporte.CambioDeTexto
        Try

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED

            If (txtTipoServicioTransporte.Resultado Is Nothing) Then
                Exit Sub
            End If
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtUnidadProductivaTransporte_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductivaTransporte.CambioDeTexto
        Try
            Limpiar_CeBe_CeCo_Transporte()
            If (txtUnidadProductivaTransporte.Resultado Is Nothing) Then
                Exit Sub
            End If
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub


    Private Sub cmbCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles cmbCentroBeneficio.ClickOnArrow
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If

            If (cmbCentroBeneficio.DataSource Is Nothing) Then
                MessageBox.Show("Parámetros insuficiente para listar el centro de beneficio, debe de seleccionar el Tipo de servicio, Unidad Productiva.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try

    End Sub

    Private Sub cboCentroCostoTercero_ClickOnArrow(ByVal objData As System.Object)
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub
    '</[AHM]>



    Private Sub UcCliente_TextChanged() Handles UcCliente.TextChanged
        Try

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
            UcPLanta_Cmb011.pActualizar()
            ListarPlantaXCompania() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            ListarServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub UcPLanta_Cmb011_Seleccionar(ByVal obePlanta As Ransa.Controls.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.Seleccionar
        Try

            txtUnidadProductiva.Limpiar()
            txtUnidadProductiva.DataSource = Nothing
            Dim PSCDSRSP As String = ""
            If cboServicio.Resultado IsNot Nothing Then
                PSCDSRSP = CType(cboServicio.Resultado, Servicio_X_Rubro).CDSRSP
            End If


            Me.Cargar_UnidadProductiva_SAP(PSCDSRSP, UcPLanta_Cmb011.CodSedeSAP)
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
                Exit Sub
            End If
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            If cboServicio.Resultado Is Nothing Then
                Me.Cargar_CentroBeneficio()
            End If
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboCeCoOrigenP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCeCoOrigenP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeCoOrigenP.Click
        BuscarCentroCosto(txtCeCoOrigenP, txtOrigenP, "ORIGEN-PROPIO")
    End Sub

    Private Sub BtnCeCoOrigenT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCeCoOrigenT.Click
        BuscarCentroCosto(txtCeCoOrigenT, txtTerceroP, "ORIGEN-TERCERO")
    End Sub

    Private Sub BuscarCentroCosto(ByRef Contenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByRef Contenedor2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByVal invocador As String)
        Dim frm As New frmBuscarCentroCosto
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Dim macroServicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
        Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral)
        'frm.Lista = lbeCeCoTarifario 
        frm.CCMPN = oTarifa.CCMPN
        frm.iniMacroServicio = macroServicio.CDSRSP
        Select Case invocador
            Case "DESTINO-PROPIO"
                frm.iniUnidadProductiva = unidadProductivaTransporte.CDUPSP
                frm.iniTipoActivo = Obtener_Dato_General("TIPOACTIVOSAP", "1").CODREL
                frm.iniSector = String.Empty
            Case "DESTINO-TERCERO"
                frm.iniUnidadProductiva = unidadProductivaTransporte.CDUPSP
                frm.iniTipoActivo = Obtener_Dato_General("TIPOACTIVOSAP", "2").CODREL
                frm.iniSector = String.Empty
            Case "ORIGEN-PROPIO"
                'INI-ECM-ActualizacionTarifario[RF001]-160516
                'frm.iniSector = 9
                'frm.iniTipoActivo = Obtener_Dato_General("TIPOACTIVOSAP", "1").CODREL
                'FIN-ECM-ActualizacionTarifario[RF001]-160516
            Case "ORIGEN-TERCERO"
                'INI-ECM-ActualizacionTarifario[RF001]-160516
                'frm.iniSector = 9
                'frm.iniTipoActivo = Obtener_Dato_General("TIPOACTIVOSAP", "2").CODREL
                'FIN-ECM-ActualizacionTarifario[RF001]-160516
        End Select



        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Contenedor.Text = frm.DescCeCo
            Contenedor.Tag = frm.codCeCo
            Contenedor2.Text = frm.DescCeBe
            Contenedor2.Tag = frm.codCeBe
        End If

    End Sub

    Private Sub ListarPlantaXCompania()

        Dim negocio As New clsPlanta
        Dim plantas As DataTable = negocio.Listar_Planta_X_Compania(oTarifa.CCMPN, UcDivision.Division)

        Dim listaPlanta As New List(Of bePlanta)
        Dim listaColumnas As New Hashtable

        For Each row As DataRow In plantas.Rows
            Dim planta As New bePlanta
            planta.Cplndv = row.Item("Cplndv")
            planta.Tplnta = row.Item("Tplnta")
            planta.Cdspsp = row.Item("Cdspsp")
            listaPlanta.Add(planta)
        Next row

        Dim columna As New DataGridViewTextBoxColumn
        columna.Name = "Cplndv"
        columna.DataPropertyName = "Cplndv"
        columna.HeaderText = "Código "
        listaColumnas.Add(1, columna)

        columna = New DataGridViewTextBoxColumn
        columna.Name = "Tplnta"
        columna.DataPropertyName = "Tplnta"
        columna.HeaderText = "Descripción "
        listaColumnas.Add(2, columna)

        columna = New DataGridViewTextBoxColumn
        columna.Name = "Cdspsp"
        columna.DataPropertyName = "Cdspsp"
        columna.HeaderText = "Sede "
        listaColumnas.Add(3, columna)

        cboPlantaFact.DataSource = listaPlanta
        cboPlantaFact.ListColumnas = listaColumnas
        cboPlantaFact.Cargas()
        cboPlantaFact.Limpiar()
        cboPlantaFact.ValueMember = "Cplndv"
        cboPlantaFact.DispleyMember = "Tplnta"


    End Sub

    Private Sub cboPlantaFact_CambioDeTexto(ByVal objData As System.Object) Handles cboPlantaFact.CambioDeTexto 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

      
        Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED

        'RCS-HUNDRED-INICIO
        'RCS-HUNDRED-FIN
        If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then 'JM
            Exit Sub
        End If
        Me.Cargar_CentroBeneficio()

    End Sub

    Private Sub cboTipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedValueChanged
        If cboTipo.ValueMember <> String.Empty Then
            Select Case cboTipo.SelectedValue
                Case "I"
                    btnCeBeDestinoP.Enabled = False
                    btnCeBeDestinoT.Enabled = False
                    btnCeCoDestinoP.Enabled = True
                    btnCeCoDestinoT.Enabled = True
                    btnCeCoDestinoP.TabIndex = 25
                    btnCeCoDestinoT.TabIndex = 27

                Case "S"
                    btnCeBeDestinoP.Enabled = True
                    btnCeBeDestinoT.Enabled = True
                    btnCeCoDestinoP.Enabled = True
                    btnCeCoDestinoT.Enabled = True
            End Select

            LimpiarCtrl(txtCeBeDestinoP)
            LimpiarCtrl(txtCeCoDestinoP)
            LimpiarCtrl(txtCebeDestinoT)
            LimpiarCtrl(txtCeCoDestinoT)
        End If
    End Sub

    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Private Sub btnCeBeDestinoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeBeDestinoP.Click
        With frmBusquedaCebe
            imputCeBe.TipoOrigen = "P"
            .imputCebe = imputCeBe
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtCeBeDestinoP.Tag = .codCeBe
                txtCeBeDestinoP.Text = .DescCeBe
            End If
            .Dispose()
        End With
    End Sub

    Private Sub btnCeBeDestinoT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeBeDestinoT.Click
        With frmBusquedaCebe
            imputCeBe.TipoOrigen = "T"
            .imputCebe = imputCeBe
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtCebeDestinoT.Tag = .codCeBe
                txtCebeDestinoT.Text = .DescCeBe
            End If
            .Dispose()
        End With
    End Sub

    Private Sub btnCeCoDestinoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeCoDestinoP.Click
        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
        If txtUnidadProductivaTransporte.Resultado Is Nothing Then
            MessageBox.Show("Seleccione una Unidad Productiva", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN

        If cboTipo.ValueMember <> String.Empty Then

            Select Case cboTipo.SelectedValue
                Case "I"
                    BuscarCentroCosto(txtCeCoDestinoP, txtCeBeDestinoP, "DESTINO-PROPIO")
                Case "S"
                    With frmBusquedaCeCo
                        imputCeCo.CCMPN = oTarifa.CCMPN
                        imputCeCo.CODCEBE = Val("" & txtCeBeDestinoP.Tag)
                        .imputCeCo = imputCeCo
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            txtCeCoDestinoP.Tag = .codCeCo
                            txtCeCoDestinoP.Text = .DescCeCo
                        End If
                        .Dispose()
                    End With
            End Select
        End If
    End Sub

    Private Sub btnCeCoDestinoT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeCoDestinoT.Click

        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
        If txtUnidadProductivaTransporte.Resultado Is Nothing Then
            MessageBox.Show("Seleccione una Unidad Productiva", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN


        If cboTipo.ValueMember <> String.Empty Then
            Select Case cboTipo.SelectedValue
                Case "I"
                    BuscarCentroCosto(txtCeCoDestinoT, txtCebeDestinoT, "DESTINO-TERCERO")
                Case "S"
                    With frmBusquedaCeCo
                        imputCeCo.CCMPN = oTarifa.CCMPN
                        imputCeCo.CODCEBE = Val("" & txtCebeDestinoT.Tag)
                        .imputCeCo = imputCeCo
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            txtCeCoDestinoT.Tag = .codCeCo
                            txtCeCoDestinoT.Text = .DescCeCo
                        End If
                        .Dispose()
                    End With
            End Select
        End If
    End Sub

    Private Sub LimpiarCtrl(ByVal textBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox) 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        textBox.Text = String.Empty
        textBox.Tag = String.Empty
    End Sub

    Private Sub UcCliente_InformationChanged() Handles UcCliente.InformationChanged
        Try
            If Not (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then Exit Sub

            Dim tarifa As New clsTarifa 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            For Each row As DataRow In tarifa.Listar_datos_Cliente(oTarifa.CCMPN, UcCliente.pCodigo).Rows
                cboTipo.SelectedValue = Trim(row.Item("COD_TIPO"))
                txtSector.Text = Trim(row.Item("TCRVTA"))
                txtSector.Tag = Trim(row.Item("CDSCSP"))
            Next row

   
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private Sub txtCeBeDestinoP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCeBeDestinoP.TextChanged
        If txtCeBeDestinoP.Tag = String.Empty Then Exit Sub
        Dim olCentroCosto As New List(Of CentroCosto)
        olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, txtCeBeDestinoP.Tag)
        If olCentroCosto.Count = 1 Then
            txtCeCoDestinoP.Text = olCentroCosto.Item(0).CECO
            txtCeCoDestinoP.Tag = olCentroCosto.Item(0).PNCCNTCS
        Else
            txtCeCoDestinoP.Text = String.Empty
            txtCeCoDestinoP.Tag = String.Empty
        End If
    End Sub

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private Sub txtCebeDestinoT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCebeDestinoT.TextChanged
        If txtCebeDestinoT.Tag = String.Empty Then Exit Sub
        Dim olCentroCosto As New List(Of CentroCosto)
        olCentroCosto = oCentroCosto.Listar_CentroCosto_CeBe(oTarifa.CCMPN, txtCebeDestinoT.Tag)
        If olCentroCosto.Count = 1 Then
            txtCeCoDestinoT.Text = olCentroCosto.Item(0).CECO
            txtCeCoDestinoT.Tag = olCentroCosto.Item(0).PNCCNTCS
        Else
            txtCeCoDestinoT.Text = String.Empty
            txtCeCoDestinoT.Tag = String.Empty
        End If
    End Sub
    'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO

    'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
End Class

 
