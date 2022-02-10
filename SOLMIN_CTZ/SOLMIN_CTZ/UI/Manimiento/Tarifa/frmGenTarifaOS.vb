Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
'Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text

Public Class frmGenTarifaOS
   

    Private oCompania As clsCompania
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    'Private oPlantaNeg As SOLMIN_CTZ.NEGOCIO.clsPlanta
 
    Private oServicio As New SOLMIN_CTZ.NEGOCIO.clsServicio

    Private oCentroCosto As SOLMIN_CTZ.NEGOCIO.clsCentroCosto
    Private oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
    Private oDetTarTipFlete As New SOLMIN_CTZ.NEGOCIO.clsDetalleTarifaTipoFlete
    Private oRangoTarifaFlete As New SOLMIN_CTZ.NEGOCIO.clsRangoTarifaXTarifaFlete
    Private oNegTarifa As New SOLMIN_CTZ.NEGOCIO.clsTarifa

    Private oTarifa As New SOLMIN_CTZ.Entidades.Tarifa
    Private oContrato As New SOLMIN_CTZ.Entidades.Contrato
    Private oRango As New SOLMIN_CTZ.Entidades.Rango

 
    Private obj_tarifa As Tarifa
    Private obj_contrato As Contrato


    Private oDsImporteTarifa As New DataSet
    Private intImpInicial As Double = 0
    'RCS-HUNDRED-INICIO
    Private bolClienteInterno As Boolean
 

    Dim dsMelsap As DataSet
    Private imputCeBe As New beImputCeBe 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Private imputCeCo As New beImputCeCo 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    'RCS-HUNDRED-FIN

    Private lbeCeCoTarifario As New List(Of CentroCostoTarifa)

    Private _pCodigoCompania As String = ""

    'Private EsRangoTarifaExceso As Boolean = False
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property


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


        oTarifa = CType(objTarifa, Tarifa)
        If Not IsNothing(objRango) Then
            oRango = CType(objRango, Rango)
           
        End If

        oContrato = CType(objContrato, SOLMIN_CTZ.Entidades.Contrato)

        _Tipo = pEnumTipo
    End Sub


 

    Private Sub frmDefTarifa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'RCS-HUNDRED-INICIO
            Validar_Cliente_Interno()
            Cargar_Datos_Generales_Tarifa_Transporte() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            'RCS-HUNDRED-FIN

            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            cboTipo.DataSource = dsMelsap.Tables("Table6")
            cboTipo.ValueMember = "CODTIPO"
            cboTipo.DisplayMember = "DESCTIPO"
            cboTipo.SelectedValue = "S"
            cboTipo_SelectionChangeCommitted(cboTipo, Nothing)
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
            txtCeCoOrigenP.TextBox.Enabled = False
            txtCeCoOrigenT.TextBox.Enabled = False

            'txtOrigenP.TextBox.Enabled = False
            'txtTerceroP.TextBox.Enabled = False

            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
            'JM


            Dim oFiltroPlanta As New SOLMIN_CTZ.Entidades.Filtro
            
            chkFTRTSG.Checked = False
            If (oTarifa.FTRTSG = "X") Then
                chkFTRTSG.Checked = True
            End If

            txtCodTarifa.Text = oTarifa.NRTFSV
            Dim dtPlanta As New DataTable()

            Crea_Division()
            cboDivision_SelectionChangeCommitted(cboDivision, Nothing)

            oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
           
            oCentroCosto = New SOLMIN_CTZ.NEGOCIO.clsCentroCosto
 



            Llenar_Combos()
             

            Select Case _Tipo
                Case EnumTipo.Edicion
                    Cargar_Tarifa_Flete()
                    If oTarifa.SESTRG = "P" Then
                        Habilitar_Controles_Cabecera_Tarifa_Flete(False)
                        Habilitar_Controles_Tarifa_Flete(True)

                        tsbCerrar.Enabled = False

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
                        tsbCerrar.Enabled = True
                    End If

                Case EnumTipo.Nuevo
                    Habilitar_Controles_Cabecera_Tarifa_Flete(True)
                    Habilitar_Controles_Tarifa_Flete(True)
            End Select


             

        

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

  

    Private Sub Habilitar_Controles_Cabecera_Tarifa_Flete(ByVal bolEstado As Boolean)

        cboDivision.Enabled = bolEstado
        UcPLanta_Cmb011.pHabilitado = bolEstado
        cboServicio.Enabled = bolEstado
        'cboClienteOp.Enabled = bolEstado
        'UcCliente.Enabled = bolEstado
    End Sub

    Private Sub Habilitar_Controles_Tarifa_Flete(ByVal bolEstado As Boolean)

        cboClienteOp.Enabled = bolEstado
        UcCliente.Enabled = bolEstado

        cboParametroFacturar.Enabled = bolEstado
        cboTipoServicioTransp.Enabled = bolEstado

        cboParametroPagar.Enabled = bolEstado
        cboTipoSubServicio.Enabled = bolEstado
        'cboSectorxGasto.Enabled = bolEstado
        'cboSeguroCotizacion.Enabled = bolEstado
        txtCantidadMercaderia.Enabled = bolEstado
        cboUnidadMedida.Enabled = bolEstado
        cboMercaderia.Enabled = bolEstado
        'txtPolizaSeguro.Enabled = bolEstado
        'txtPesoMercaderia.Enabled = bolEstado
        cboUnidadVehicular.Enabled = bolEstado
        'cboCompaniaSeguro.Enabled = bolEstado
        'txtValorMercaderia.Enabled = bolEstado
        'txtRecargoSeguro.Enabled = bolEstado
        'txtVolumen.Enabled = bolEstado
        txtReferenciaMerc.Enabled = bolEstado
        btnGrabarTarifa.Enabled = bolEstado
        'ToolStrip2.Enabled = bolEstado
        tsbNuevo.Enabled = bolEstado
        tsbGuardar.Enabled = bolEstado
        tsbEliminar.Enabled = bolEstado




        'chkFleteZonaPrimaria.Enabled = bolEstado
        'chkServicioAfecto.Enabled = bolEstado


        '<[AHM]>
        txtTipoServicioTransporte.Enabled = bolEstado
        txtUnidadProductivaTransporte.Enabled = bolEstado

        '</[AHM]>
        'RCS-HUNDRED-INICIO
        cboNivelServ.Enabled = bolEstado
        'cboParametroTarifaInterna.Enabled = bolEstado
        cboTipoCargaTransporte.Enabled = bolEstado

        'txtOrigenP.Enabled = bolEstado

        txtCeCoOrigenP.Enabled = bolEstado
        btnCeCoOrigenP.Enabled = bolEstado
        'txtTerceroP.Enabled = bolEstado

        txtCeCoOrigenT.Enabled = bolEstado
        BtnCeCoOrigenT.Enabled = bolEstado
        'RCS-HUNDRED-FIN

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        cboPlantaFact.Enabled = bolEstado
        btnCeBeDestinoP.Enabled = bolEstado
        btnCeBeDestinoT.Enabled = bolEstado
        btnCeCoDestinoP.Enabled = bolEstado
        btnCeCoDestinoT.Enabled = bolEstado

        chkFTRTSG.Enabled = bolEstado
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
        

        cboDivision.SelectedValue = objTarifa.CDVSN
        cboDivision_SelectionChangeCommitted(cboDivision, Nothing)


        UcPLanta_Cmb011.CodigoCompania = objTarifa.CCMPN
        UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
        UcPLanta_Cmb011.PlantaDefault = objTarifa.CPLNDV
        UcPLanta_Cmb011.pActualizar()

        cboClienteOp.Valor = objTarifa.CCLNT
        cboServicio.Valor = objTarifa.COD_SERV


        UcCliente.pCargar(objTarifa.CCLNFC)

        'cboSectorxGasto.Valor = objTarifa.SSCGST
        cboMercaderia.Valor = objTarifa.CMRCDR
        If objTarifa.CTPUNV.Trim = "" Then
            objTarifa.CTPUNV = "NAPL"
        End If
        cboUnidadVehicular.Valor = objTarifa.CTPUNV.Trim
        cboParametroFacturar.Valor = objTarifa.CFRMPG
        cboParametroPagar.Valor = objTarifa.CFRAPG
        'cboSeguroCotizacion.Valor = objTarifa.SSGRCT
        'txtPolizaSeguro.Text = IIf(objTarifa.NPLSGC = "0", "0", objTarifa.NPLSGC)
        'cboCompaniaSeguro.Valor = objTarifa.CCMPSG
        'txtRecargoSeguro.Text = IIf(objTarifa.QPRCS1 = 0, "0", objTarifa.QPRCS1.ToString.Trim)
        cboTipoServicioTransp.Valor = objTarifa.CTPOSR
        txtCantidadMercaderia.Text = IIf(objTarifa.QMRCDR = 0, "0", objTarifa.QMRCDR.ToString.Trim)
        cboUnidadMedida.Valor = objTarifa.CUNDMD
        'txtValorMercaderia.Text = IIf(objTarifa.VMRCDR = 0, "0", objTarifa.VMRCDR.ToString.Trim)
        'txtVolumen.Text = IIf(objTarifa.LMRCDR = 0, "0", objTarifa.VMRCDR.ToString.Trim)
        txtReferenciaMerc.Text = objTarifa.TRFMRC
        'txtPesoMercaderia.Text = IIf(objTarifa.PMRCDR = 0, "0", objTarifa.PMRCDR.ToString.Trim)
        cboTipoSubServicio.Valor = objTarifa.CTPSBS
        'Me.chkFleteZonaPrimaria.Checked = IIf(objTarifa.SFLZNP.ToString.Equals("X"), True, False)
        'Me.chkServicioAfecto.Checked = IIf(objTarifa.SFSANF.ToString.Equals("1"), True, False)
        '<[AHM]>

        cboPlantaFact.Valor = objTarifa.CPLNFC 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        txtTipoServicioTransporte.Valor = objTarifa.CDTSSP
        txtUnidadProductivaTransporte.Valor = objTarifa.CDUPSP


        cboTipo.SelectedValue = objTarifa.FTCLNT.Trim
        cboTipo_SelectionChangeCommitted(cboTipo, Nothing)


        txtCeCoOrigenP.Tag = objTarifa.CENCO2.ToString.Trim
        txtCeCoOrigenP.Text = objTarifa.CECO_OR_P_DESC.ToString.Trim
        'txtOrigenP.Tag = objTarifa.CCNTBN.ToString.Trim
        'txtOrigenP.Text = objTarifa.CEBE_OR_P_DESC.ToString.Trim

        txtCeCoOrigenT.Tag = objTarifa.CENCO3.ToString.Trim
        txtCeCoOrigenT.Text = objTarifa.CECO_OR_T_DESC.ToString.Trim
        'txtTerceroP.Tag = objTarifa.CCNTB1.ToString.Trim
        'txtTerceroP.Text = objTarifa.CEBE_OR_T_DESC.ToString.Trim

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        cboTipoCargaTransporte.Valor = objTarifa.CTIPCG.ToString.Trim
        txtCeBeDestinoP.Tag = Trim(objTarifa.CCNTCS)
        txtCeBeDestinoP.Text = Trim(objTarifa.CEBEP_D)
        txtCebeDestinoT.Tag = Trim(objTarifa.CCNCS1)
        txtCebeDestinoT.Text = Trim(objTarifa.CEBET_D)

        txtCeCoDestinoP.Tag = Trim(objTarifa.CENCOS)
        txtCeCoDestinoP.Text = Trim(objTarifa.CECOP_D)
        txtCeCoDestinoT.Tag = Trim(objTarifa.CENCO1)
        txtCeCoDestinoT.Text = Trim(objTarifa.CECOT_D)
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        'cboParametroTarifaInterna.Valor = objTarifa.CPATIN
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


    Enum TipoParametro
        Cobro
        Pago
    End Enum
    Private Function EsParametroRangosExceso(oTipo As TipoParametro) As Boolean
        Dim validacion As Boolean = False
        Dim param As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT


        Select Case oTipo
            Case TipoParametro.Cobro
                If cboParametroFacturar.Resultado IsNot Nothing Then
                    param = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
                Else
                    param = 0
                End If
            Case TipoParametro.Pago
                If cboParametroPagar.Resultado IsNot Nothing Then
                    param = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
                Else
                    param = 0
                End If
        End Select

        Dim drRangoAdic() As DataRow
        drRangoAdic = dsMelsap.Tables("Table8").Select("DESCTIPO='" & param & "'")

        If drRangoAdic.Length > 0 Then
            validacion = True
        Else
            validacion = False
        End If
        Return validacion
    End Function

    Private Function EsParametroRangos(oTipo As TipoParametro) As Boolean
        Dim validacion As Boolean = False
        Dim param As Double = 0 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT


        Select Case oTipo
            Case TipoParametro.Cobro
                If cboParametroFacturar.Resultado IsNot Nothing Then
                    param = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
                Else
                    param = 0
                End If
            Case TipoParametro.Pago
                If cboParametroPagar.Resultado IsNot Nothing Then
                    param = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
                Else
                    param = 0
                End If
        End Select


        Dim drReg() As DataRow
        drReg = dsMelsap.Tables("Table7").Select("DESCTIPO='" & param & "'")

        If drReg.Length > 0 Then
            validacion = True
        Else
            validacion = False
        End If

        Return validacion
    End Function


   
   

    Private Sub Crea_Division()

 

        Dim oDivisionBL As New clsDivision
        Dim dt As New DataTable
        dt = oDivisionBL.Lista_Division_X_CompaniaUsuario_OS(oTarifa.CCMPN, ConfigurationWizard.UserName)
        cboDivision.DataSource = dt
        cboDivision.DisplayMember = "TCMPDV"
        cboDivision.ValueMember = "CDVSN"
        cboDivision.SelectedValue = "T"
    End Sub



    

    Private Sub ListarServicio()


        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        oFiltro.Parametro1 = oTarifa.CCMPN
        'oFiltro.Parametro2 = UcDivision.Division
        oFiltro.Parametro2 = cboDivision.SelectedValue

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

        olRubxServ = oServicioNeg.Lista_Servicio_X_Compania_Division_OS(oFiltro)

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
        'Me.UcDivision.pHabilitado = True
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.pRequerido = True
        'Me.UcDivision.pRequerido = True
        'bolGenera = False
        '====================Cargar Servicio====================

        Cargar_ClienteOp()


        Cargar_UnidadMedida()

        ListarServicio()

        Cargar_Mercaderia()
        Cargar_UnidadVehicular()
        Cargar_ParametroFacturarPagar()
        'Cargar_Seguro_Cotizacion()
        'Cargar_Compania_Seguro()
        Cargar_Tipo_Servicio_Transp()
        Cargar_Tipo_SubServicio()

        'Cargar_SectorXGastos()

 
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


        Dim oUM As New SOLMIN_CTZ.NEGOCIO.clsUM
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


        'Dim olCentroCosto As New List(Of CentroCosto)
        'Dim olCentroCostoTercero As New List(Of CentroCosto)

        Dim tarifa As Tarifa = oTarifa
        Dim macroServicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
       

        Dim tipoServicioTransporte As ClaseGeneral = CType(txtTipoServicioTransporte.Resultado, ClaseGeneral)
        Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral)

        Dim codTipoServicioSAP As String = ""
        Dim codUnidadProdcutivaSAP As String = ""
        Dim codRegionVentaSAP As String = oContrato.CRGVTA

      

        Dim codSedeSAP As String = "" 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
     
        If (tipoServicioTransporte Is Nothing OrElse tipoServicioTransporte.CDTSSP = "") Then Exit Sub 'RCS-HUNDRED
        If (unidadProductivaTransporte Is Nothing OrElse unidadProductivaTransporte.CDUPSP = "") Then Exit Sub 'RCS-HUNDRED
        If (UcCliente.pNegocio = "") Then Exit Sub 'RCS-HUNDRED
        If cboPlantaFact.Resultado Is Nothing Then Exit Sub

        codTipoServicioSAP = tipoServicioTransporte.CDTSSP
        codUnidadProdcutivaSAP = unidadProductivaTransporte.CDUPSP
        codRegionVentaSAP = UcCliente.pNegocio
        codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT


        Dim codCompania = tarifa.CCMPN
        Dim codMacroServicioSAP As String = macroServicio.CDSRSP

        Dim codTipoActivoSAP As String = "OS"

        codSedeSAP = UcPLanta_Cmb011.CodSedeSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim tipoCentroSAP As String = Obtener_Dato_General("TIPOCENTROSAP", "CB").CODREL 'RCS-HUNDRED


        Dim oCebePropio As New CentroCosto
        Dim oCebeTercero As New CentroCosto

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
        'codTipoActivoSAP = Obtener_Dato_General("TIPOACTIVOSAP", "1").CODREL 'RCS-HUNDRED
        'imputCeBe.CodTipoActivoSAP = codTipoActivoSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        'olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        oCentroCosto.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP, oCebePropio, oCebeTercero)
        'Lista_CentroBeneficio_Tokio
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        If cboTipo.SelectedValue = "S" And oCebePropio.PNCCNTCS > 0 Then
            'If cboTipo.SelectedValue = "S" And olCentroCosto.Count > 0 Then
            'txtCeBeDestinoP.Tag = olCentroCosto.Item(0).PNCCNTCS
            'txtCeBeDestinoP.Text = olCentroCosto.Item(0).CEBE
            txtCeBeDestinoP.Tag = oCebePropio.PNCCNTCS
            txtCeBeDestinoP.Text = oCebePropio.CEBE
        End If
        'PPPPPPPPPP()
        'codTipoActivoSAP = Obtener_Dato_General("TIPOACTIVOSAP", "2").CODREL 'RCS-HUNDRED
        'imputCeBe.CodTipoActivoSAP_T = codTipoActivoSAP 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        'olCentroCostoTercero = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        If cboTipo.SelectedValue = "S" And oCebeTercero.PNCCNTCS > 0 Then
            txtCebeDestinoT.Tag = oCebeTercero.PNCCNTCS
            txtCebeDestinoT.Text = oCebeTercero.CEBE
        End If

        'If cboTipo.SelectedValue = "S" And olCentroCosto.Count > 0 Then
        '    txtCebeDestinoT.Tag = olCentroCostoTercero.Item(0).PNCCNTCS
        '    txtCebeDestinoT.Text = olCentroCostoTercero.Item(0).CEBE
        'End If
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN




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


        Dim obeGeneral As New ClaseGeneral
        obeGeneral.CTPUNV = "NAPL"
        obeGeneral.TUNDVH = "NO APLICA"

        'Dim lbeUnidadMedida As New List(Of ClaseGeneral)

        olUniVeh = oClaseGeneral.Listar_Unidad_Transporte()
        olUniVeh.Insert(0, obeGeneral)

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
            'cboParametroTarifaInterna.DataSource = olParFac 'RCS-HUNDRED
        Else
            cboParametroFacturar.DataSource = Nothing
            cboParametroPagar.DataSource = Nothing
            'cboParametroTarifaInterna.DataSource = Nothing 'RCS-HUNDRED
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
        'cboParametroTarifaInterna.ListColumnas = oListColum3
        'cboParametroTarifaInterna.Cargas()
        'cboParametroTarifaInterna.ValueMember = "CFRMPG"
        'cboParametroTarifaInterna.DispleyMember = "TCMFRP"
        'RCS-HUNDRED-FIN

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

   


    '<[AHM]>'
    Dim oHasTipoServicioSAP As New Hashtable
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

        Dim claseGeneralList As New List(Of ClaseGeneral)
        If Not oHasTipoServicioSAP.Contains(PSCDSRSP) Then
            claseGeneralList = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)
            oHasTipoServicioSAP(PSCDSRSP) = claseGeneralList
        End If
        claseGeneralList = oHasTipoServicioSAP(PSCDSRSP)



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


 

    Private Sub cboServicio_CambioDeTexto(ByVal objData As System.Object) Handles cboServicio.CambioDeTexto
        Try
            
            txtTipoServicioTransporte.Limpiar()
            txtTipoServicioTransporte.DataSource = Nothing

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED


            '</[AHM]>
            If cboServicio.Resultado IsNot Nothing Then

                Dim servicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
                '<[AHM]>
                Me.Cargar_TipoServicio_SAP(servicio.CDSRSP)
                Cargar_UnidadProductivaTransporte(servicio.CDSRSP) 'RCS-HUNDRED
 
                Me.Cargar_CentroBeneficio()
                '</[AHM]>
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    

    'RCS-HUNDRED-INICIO

    Private Sub Validar_Cliente_Interno()
        Dim oCliente As New clsCliente

        bolClienteInterno = oCliente.Validar_Cliente_Interno(oTarifa.CCMPN, oTarifa.NRCTSL).Count > 0
        ' valores para posicionamiento de campos de cliente interno
        If bolClienteInterno Then
            
        End If
    End Sub

    Private Sub Cargar_Datos_Generales_Tarifa_Transporte() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        dsMelsap = (New clsTarifa).Cargar_Datos_Generales_Tarifa_Transporte(oTarifa)
        Cargar_Nivel_Servicio()
        Cargar_Tipo_Carga_Transporte()

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

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Try
            Dim xcheck As Boolean = chkFTRTSG.Checked

            Dim validacion As String = ""
            If cboParametroFacturar.Resultado Is Nothing Then
                validacion = validacion & "* Parámetro a Facturar" & Chr(13)
            End If

            If cboParametroPagar.Resultado Is Nothing Then
                validacion = validacion & "* Parámetro a Pagar" & Chr(13)
            End If
            If validacion.Length > 0 Then
                MessageBox.Show("Seleccionar" & Chr(10) & validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Public Es_Cobro_Rango As Boolean = False
            'Public Es_Pago_Rango As Boolean = False

            'Public Es_Cobro_Rango As Boolean = False
            'Public Es_Pago_Rango As Boolean = False
            'Public Es_Cobro_Rango_Exceso As Boolean = False
            'Public Es_Pago_Rango_Exceso As Boolean = False




            Dim ofrmDetalleTarifa As New frmTarifaFleteRuta
            If Me.dtgTarifaFleteRuta.RowCount > 0 Then
                ofrmDetalleTarifa.DetalleTarifaFlete = dtgTarifaFleteRuta.DataSource
            End If
            ofrmDetalleTarifa.EsOSSeguimiento = xcheck
            'ofrmDetalleTarifa.Tarifa_Tipo_Rango = Visualizar_Registro_Rango()
            'ofrmDetalleTarifa.EsRangoTarifaExceso = EsRangoTarifaExceso

            ofrmDetalleTarifa.Es_Cobro_Rango = EsParametroRangos(TipoParametro.Cobro)
            ofrmDetalleTarifa.Es_Pago_Rango = EsParametroRangos(TipoParametro.Pago)
            ofrmDetalleTarifa.Es_Cobro_Rango_Exceso = EsParametroRangosExceso(TipoParametro.Cobro)
            ofrmDetalleTarifa.Es_Pago_Rango_Exceso = EsParametroRangosExceso(TipoParametro.Pago)


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

    Private Function EsRangoGeneral() As Boolean
        Dim es_rango As Boolean = (EsParametroRangos(TipoParametro.Cobro) Or EsParametroRangos(TipoParametro.Pago) Or EsParametroRangosExceso(TipoParametro.Cobro) Or EsParametroRangosExceso(TipoParametro.Pago))
        Return es_rango
    End Function

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If Me.dtgTarifaFleteRuta.CurrentCellAddress.Y = -1 Then Exit Sub
            If Me.dtgTarifaFleteRuta.CurrentRow.Cells("ILCFTR").Value = "0" Then 'RCS-HUNDRED

                If EsRangoGeneral() = True Then
                    'If EsParametroRangosExceso() = True Or EsParametroRangos() = True Then
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
            Dim xcheck As Boolean = chkFTRTSG.Checked
            If Me.dtgTarifaFleteRuta.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim ofrmDetalleTarifa As New frmTarifaFleteRuta

            'ofrmDetalleTarifa.Tarifa_Tipo_Rango = Visualizar_Registro_Rango()
            'ofrmDetalleTarifa.EsRangoTarifaExceso = EsRangoTarifaExceso

            ofrmDetalleTarifa.Es_Cobro_Rango = EsParametroRangos(TipoParametro.Cobro)
            ofrmDetalleTarifa.Es_Pago_Rango = EsParametroRangos(TipoParametro.Pago)
            ofrmDetalleTarifa.Es_Cobro_Rango_Exceso = EsParametroRangosExceso(TipoParametro.Cobro)
            ofrmDetalleTarifa.Es_Pago_Rango_Exceso = EsParametroRangosExceso(TipoParametro.Pago)

            If Me.dtgTarifaFleteRuta.RowCount > 0 Then
                ofrmDetalleTarifa.DetalleTarifaFlete = dtgTarifaFleteRuta.DataSource
            End If
            ofrmDetalleTarifa.DetalleTarifaFleteMod = dtgTarifaFleteRuta.CurrentRow.DataBoundItem
            ofrmDetalleTarifa.EsOSSeguimiento = xcheck
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





    Private Function Validar_Tarifa() As Boolean

        Dim strError As String = String.Empty '"DEBE DE INGRESAR: " & Chr(13)'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        If cboServicio.Resultado Is Nothing Then
            strError += "* Servicio" & Chr(13)
        End If

        If cboClienteOp.Resultado Is Nothing Then
            strError += "* Cliente Operación" & Chr(13)
        End If
        If UcCliente.pCodigo = 0 Then
            strError += "* Cliente a Facturar" & Chr(13)
        End If



        'If cboSectorxGasto.Resultado Is Nothing Then
        '    strError += "* Sector por Gasto" & Chr(13)
        'End If
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
        'If cboSeguroCotizacion.Resultado Is Nothing Then
        '    strError += "* Seguro de Cotización" & Chr(13)
        'ElseIf CType(cboSeguroCotizacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO = "C" Then
        '    If (txtPolizaSeguro.Text.Length = 0 OrElse Not IsNumeric(Me.txtPolizaSeguro.Text) OrElse Me.txtPolizaSeguro.Text = 0) Then
        '        strError += "* Póliza de Seguro" & Chr(13)
        '    End If
        '    If cboCompaniaSeguro.Resultado Is Nothing Then
        '        strError += "* Compañía de Seguro" & Chr(13)
        '    End If
        'End If
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

        'Dim esRango As Boolean = Visualizar_Registro_Rango()
        
        If Not dtgTarifaFleteRuta.DataSource Is Nothing Then

            If EsRangoGeneral() = True Then
                For Each obeDetalleRarifaFlete As DetalleTarifaTipoFlete In dtgTarifaFleteRuta.DataSource
                    If obeDetalleRarifaFlete.RangoTarifa Is Nothing OrElse obeDetalleRarifaFlete.RangoTarifa.Count = 0 Then
                        strError += "* El detalle de la Tarifa no contiene Rango de tarifa" & Chr(13)
                    End If
                Next
            End If

        End If

        'RCS-HUNDRED-INICIO



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
        'If cboParametroTarifaInterna.Resultado Is Nothing Then
        '    strError += "* Parámetro Tarifa Interna" & Chr(13)
        'End If
        If cboTipoCargaTransporte.Resultado Is Nothing Then
            strError += "* Tipo Carga" & Chr(13)
        End If





        Select Case cboTipo.SelectedValue
            Case "S"
                If txtCeBeDestinoP.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                    strError += "* CeBe Propio" & Chr(13)
                End If
                If txtCebeDestinoT.Tag = "" Then 'ECM-HUNDRED - SGR - DEF - SALMON - ST - FASE2 - VENTA - INTERNA - PT)
                    strError += "* CeBe Tercero" & Chr(13)
                End If


                'If String.IsNullOrEmpty(txtCeCoOrigenP.Tag) Then
                '    strError += "* CeCo Propio (Origen)" & Chr(13)
                'End If
                'If String.IsNullOrEmpty(txtCeCoOrigenT.Tag) Then
                '    strError += "* CeCo Tercero (Origen)" & Chr(13)
                'End If

            Case "I"

                If txtCeBeDestinoP.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                    strError += "* CeBe Propio" & Chr(13)
                End If
                If txtCebeDestinoT.Tag = "" Then 'ECM-HUNDRED - SGR - DEF - SALMON - ST - FASE2 - VENTA - INTERNA - PT)
                    strError += "* CeBe Tercero" & Chr(13)
                End If

                If txtCeCoDestinoP.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                    strError += "* CeCo Propio (Destino)" & Chr(13)
                End If
                If txtCeCoDestinoT.Tag = "" Then 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                    strError += "* CeCo Tercero (Destino)" & Chr(13)
                End If


                If String.IsNullOrEmpty(txtCeCoOrigenP.Tag) Then
                    strError += "* CeCo Propio (Origen)" & Chr(13)
                End If
                If String.IsNullOrEmpty(txtCeCoOrigenT.Tag) Then
                    strError += "* CeCo Tercero (Origen)" & Chr(13)
                End If

        End Select

        If strError.Trim.Length > 0 Then
            HelpClass.MsgBox("DEBE DE INGRESAR: " & Chr(13) & strError, MessageBoxIcon.Warning) 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Return False
        Else
            Return True

        End If
        'End If
    End Function



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

        objTarifa.CDVSN = cboDivision.SelectedValue
        objTarifa.CPLNDV = UcPLanta_Cmb011.Planta

        objTarifa.CMNDA1 = 0
        objTarifa.CCLNT = CType(cboClienteOp.Resultado, SOLMIN_CTZ.Entidades.Contrato).CCLNT  ' cboClienteOp.pCodigo
        objTarifa.CCLNFC = UcCliente.pCodigo


        'objTarifa.SSCGST = CType(cboSectorxGasto.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO
        objTarifa.SSCGST = ""
        objTarifa.CMRCDR = CType(cboMercaderia.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMRCDR

        Dim tipo_unidad As String = CType(cboUnidadVehicular.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPUNV
        tipo_unidad = tipo_unidad.Trim
        If tipo_unidad = "NAPL" Then
            objTarifa.CTPUNV = ""
        Else
            objTarifa.CTPUNV = tipo_unidad
        End If
        objTarifa.CFRMPG = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        objTarifa.CFRAPG = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
        'objTarifa.SSGRCT = CType(cboSeguroCotizacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO
        objTarifa.SSGRCT = ""
        'objTarifa.NPLSGC = IIf(Me.txtPolizaSeguro.Text.Trim.Equals("") = True, "0", Me.txtPolizaSeguro.Text)
        objTarifa.NPLSGC = 0
        'If cboCompaniaSeguro.Resultado IsNot Nothing Then
        '    objTarifa.CCMPSG = CType(cboCompaniaSeguro.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CCMPSG
        'Else
        '    objTarifa.CCMPSG = "0"
        'End If
        objTarifa.CCMPSG = "0"

        'objTarifa.QPRCS1 = IIf(Me.txtRecargoSeguro.Text = "", "0", Me.txtRecargoSeguro.Text)
        objTarifa.QPRCS1 = "0"
        objTarifa.CTPOSR = CType(cboTipoServicioTransp.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPOSR
        objTarifa.QMRCDR = IIf(Me.txtCantidadMercaderia.Text.Equals("") = True, "0", txtCantidadMercaderia.Text)
        objTarifa.CUNDMD = CType(cboUnidadMedida.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD
        'objTarifa.VMRCDR = IIf(Me.txtValorMercaderia.Text.Trim.Equals("") = True, "0", Me.txtValorMercaderia.Text)
        objTarifa.VMRCDR = 0
        'objTarifa.LMRCDR = IIf(Me.txtVolumen.Text.Trim.Equals("") = True, "0", Me.txtVolumen.Text)
        objTarifa.LMRCDR = 0
        objTarifa.TRFMRC = IIf(Me.txtReferenciaMerc.Text.Trim.Length <= 40, Me.txtReferenciaMerc.Text.Trim, "")
        'objTarifa.PMRCDR = IIf(Me.txtPesoMercaderia.Text.Equals("") = True, "0", Me.txtPesoMercaderia.Text)
        objTarifa.PMRCDR = 0
        objTarifa.STPTRA = "T"
        objTarifa.DESTAR = "TARIFA FLETE"
        objTarifa.VALCTE = "0"
        objTarifa.IVLSRV = "0"
        objTarifa.CTPSBS = CType(cboTipoSubServicio.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CTPSBS
        objTarifa.PRLBPG = 0
        objTarifa.FAPLBR = ""
        objTarifa.TOBS = ""
        'objTarifa.SFLZNP = IIf(Me.chkFleteZonaPrimaria.Checked = True, "X", " ")
        objTarifa.SFLZNP = ""
        'objTarifa.SFSANF = IIf(Me.chkServicioAfecto.Checked = True, "1", "3")
        objTarifa.SFSANF = 0
        objTarifa.STSTRF = 0
        objTarifa.NORSRT = 0
        objTarifa.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objTarifa.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'objTarifa.NRRELF = CType(cboLogicaFacturacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CODIGO_LF
        objTarifa.NRRELF = 0

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
        'objTarifa.CPATIN = CType(cboParametroTarifaInterna.Resultado, ClaseGeneral).CFRMPG
        objTarifa.CPATIN = 0
        objTarifa.CTIPCG = CType(cboTipoCargaTransporte.Resultado, DatosGenerales).CODIGO




        Select Case cboTipo.SelectedValue
            Case "I"

                objTarifa.CCNTCS = txtCeBeDestinoP.Tag
                objTarifa.CCNCS1 = txtCebeDestinoT.Tag
                objTarifa.CENCOS = txtCeCoDestinoP.Tag
                objTarifa.CENCO1 = txtCeCoDestinoT.Tag

                objTarifa.CENCO2 = IIf(txtCeCoOrigenP.Tag.ToString() = "", "0", txtCeCoOrigenP.Tag) 'JM
                objTarifa.CENCO3 = IIf(txtCeCoOrigenT.Tag.ToString() = "", "0", txtCeCoOrigenT.Tag) 'JM


            Case "S"
                objTarifa.CCNTCS = txtCeBeDestinoP.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
                objTarifa.CCNCS1 = txtCebeDestinoT.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

                objTarifa.CENCOS = 0
                objTarifa.CENCO1 = 0

                objTarifa.CCNTBN = 0   ' cebe origen propio
                objTarifa.CCNTB1 = 0   ' cebe origen tercero
                'objTarifa.CENCO2 = IIf(txtCeCoOrigenP.Tag.ToString() = "", "0", txtCeCoOrigenP.Tag) 'JM
                'objTarifa.CENCO3 = IIf(txtCeCoOrigenT.Tag.ToString() = "", "0", txtCeCoOrigenT.Tag) 'JM
                objTarifa.CENCO2 = 0 'JM
                objTarifa.CENCO3 = 0 'JM

        End Select


        objTarifa.CPLNFC = CType(cboPlantaFact.Resultado, bePlanta).Cplndv 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        objTarifa.FTCLNT = cboTipo.SelectedValue 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

        objTarifa.FTRTSG = IIf(chkFTRTSG.Checked, "X", "")
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

                Else
                    obeDetTarTipFlete.NCRRSR = dtgTarifaFleteRuta.Rows(i).DataBoundItem.NCRRSR
                    oDetTarTipFlete.Actualizar_Detalle_Tarifa_Tipo_Flete(obeDetTarTipFlete)


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

   

    Private Sub txtCantidadMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadMercaderia.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPesoMercaderia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtVolumen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtTipoServicioTransporte_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicioTransporte.CambioDeTexto
        Try

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED



            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub txtUnidadProductivaTransporte_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductivaTransporte.CambioDeTexto
        Try


            Limpiar_CeBe_CeCo_Transporte()

            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub








    Private Sub UcCliente_TextChanged() Handles UcCliente.TextChanged
        Try

            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED

            Me.Cargar_CentroBeneficio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub





    Private Sub btnCeCoOrigenP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeCoOrigenP.Click

        BuscarCentroCosto(txtCeCoOrigenP, "ORIGEN-PROPIO")
    End Sub

    Private Sub BtnCeCoOrigenT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCeCoOrigenT.Click

        BuscarCentroCosto(txtCeCoOrigenT, "ORIGEN-TERCERO")
    End Sub
    Private Sub BuscarCentroCosto(ByRef Contenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByVal invocador As String)

        Dim frm As New frmBuscarCentroCosto
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Dim macroServicio As Servicio_X_Rubro = CType(cboServicio.Resultado, Servicio_X_Rubro)
        Dim unidadProductivaTransporte As ClaseGeneral = CType(txtUnidadProductivaTransporte.Resultado, ClaseGeneral)

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
            'Contenedor2.Text = frm.DescCeBe
            'Contenedor2.Tag = frm.codCeBe
        End If

    End Sub

    Private Sub ListarPlantaXCompania()

        Dim negocio As New clsPlanta

        Dim plantas As DataTable = negocio.Listar_Planta_X_Compania(oTarifa.CCMPN, cboDivision.SelectedValue)

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
        Try
            Limpiar_CeBe_CeCo_Transporte() 'RCS-HUNDRED


            Me.Cargar_CentroBeneficio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



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

                    BuscarCentroCosto(txtCeCoDestinoP, "DESTINO-PROPIO")
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

                    BuscarCentroCosto(txtCeCoDestinoT, "DESTINO-TERCERO")
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


            Dim tarifa As New clsTarifa 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            Dim dt As New DataTable
            dt = tarifa.Listar_datos_Cliente(oTarifa.CCMPN, UcCliente.pCodigo)
            If dt.Rows.Count > 0 Then
                cboTipo.SelectedValue = Trim(dt.Rows(0)("COD_TIPO"))
                txtSector.Text = Trim(dt.Rows(0)("TCRVTA"))
                txtSector.Tag = Trim(dt.Rows(0)("CDSCSP"))
            End If
            cboTipo_SelectionChangeCommitted(cboTipo, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub





    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        Try

            UcPLanta_Cmb011.CodigoDivision = cboDivision.SelectedValue
            UcPLanta_Cmb011.CodigoCompania = oTarifa.CCMPN
            UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
            UcPLanta_Cmb011.pActualizar()
            ListarPlantaXCompania() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            ListarServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub btnGrabarTarifa_Click(sender As Object, e As EventArgs) Handles btnGrabarTarifa.Click
        Try
            If Validar_Tarifa() = False Then
                Exit Sub
            End If
            Dim msgVerificacion As String = ""
            Dim pobjFiltro As New Filtro
            Dim msgError As String = ""
            pobjFiltro.Parametro1 = oTarifa.CCMPN

            pobjFiltro.Parametro2 = cboDivision.SelectedValue
            pobjFiltro.Parametro3 = UcPLanta_Cmb011.Planta

            pobjFiltro.Parametro4 = txtCeBeDestinoP.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            pobjFiltro.Parametro5 = txtCebeDestinoT.Tag 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            pobjFiltro.Parametro7 = CType(cboPlantaFact.Resultado, bePlanta).Cplndv 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            pobjFiltro.Parametro8 = ("" & cboTipo.ComboBox.SelectedValue).ToString.Trim 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

            pobjFiltro.Parametro6 = IIf(cboServicio.Resultado IsNot Nothing, CType(cboServicio.Resultado, SOLMIN_CTZ.Entidades.Servicio_X_Rubro).CSRVC, 0)

            pobjFiltro.Parametro9 = IIf(chkFTRTSG.Checked, "X", "")
           
            msgVerificacion = oServicio.VerificarConfiguracionOrdenServicio(pobjFiltro)


            If msgVerificacion.Length > 0 Then
                MessageBox.Show("No se puede Generar OS.Verificar:" & Chr(13) & msgVerificacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Grabar_Tarifa_Flete()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipo.SelectionChangeCommitted
        Try
            If cboTipo.ValueMember <> String.Empty Then
                Select Case cboTipo.SelectedValue
                    Case "I"
                        gbCeCoSector.Visible = True
                        btnCeBeDestinoP.Enabled = False
                        btnCeBeDestinoT.Enabled = False
                        gbOrigen.Visible = True


                    Case "S"
                        btnCeBeDestinoP.Enabled = True
                        btnCeBeDestinoT.Enabled = True

                        gbCeCoSector.Visible = False
                        gbOrigen.Visible = False
                End Select

                LimpiarCtrl(txtCeBeDestinoP)
                LimpiarCtrl(txtCeCoDestinoP)
                LimpiarCtrl(txtCebeDestinoT)
                LimpiarCtrl(txtCeCoDestinoT)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub tsbCerrar_Click(sender As Object, e As EventArgs) Handles tsbCerrar.Click
        Try
            Dim obrTarifa As New clsTarifa
            Dim msgerror As String = ""
            Dim CorrTarifa As Decimal = 0
            Dim CodEstado As String = ""

            Dim CantServActivos As Integer = 0


            If dtgTarifaFleteRuta.CurrentRow IsNot Nothing Then

                For i As Integer = 0 To dtgTarifaFleteRuta.Rows.Count - 1
                    CodEstado = ("" & dtgTarifaFleteRuta.Rows(i).Cells("COD_ESTADO").Value).ToString.Trim
                    If CodEstado = "A" Then
                        CantServActivos = CantServActivos + 1
                    End If
                Next


                CorrTarifa = Val("" & dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value)
                CodEstado = ("" & dtgTarifaFleteRuta.CurrentRow.Cells("COD_ESTADO").Value).ToString.Trim

                If CodEstado = "C" Then
                    MessageBox.Show("El servicio ya se encuentra cerrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If CorrTarifa > 0 Then

                    'NCRRSR
                    If CantServActivos > 1 Then
                        'proceso desactivación
                        Dim pobjTarifa As New Tarifa
                        pobjTarifa.CCMPN = dtgTarifaFleteRuta.CurrentRow.Cells("CCMPN").Value
                        pobjTarifa.NRCTSL = dtgTarifaFleteRuta.CurrentRow.Cells("NRCTSL").Value
                        pobjTarifa.NRTFSV = dtgTarifaFleteRuta.CurrentRow.Cells("NRTFSV").Value
                        pobjTarifa.NCRRSR = dtgTarifaFleteRuta.CurrentRow.Cells("NCRRSR").Value
                        msgerror = obrTarifa.Cerrar_Tarifa_Flete_X_Servicio_Item(pobjTarifa)
                        If msgerror.Length > 0 Then
                            MessageBox.Show(msgerror, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Listar_Detalle_Tarifa_Tipo_Flete()
                            MessageBox.Show("Servicio cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Solo tiene un servicio. Debe proceder cerrar a nivel de O/S.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class