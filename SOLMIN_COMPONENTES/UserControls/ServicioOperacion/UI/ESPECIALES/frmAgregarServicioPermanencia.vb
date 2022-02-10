Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Web
Imports RANSA.Utilitario
 

Public Class frmAgregarServicioPermanencia

#Region "Propiedades"
    Private bolBuscar As Boolean = False
    Private _oServicio As Servicio_BE
    Private olServicio As New List(Of Servicio_BE)
    Private nCantidadDias As Decimal = 0
    Private nCantidadServicios As Decimal = 0
    Private oDtAlmacenes As DataTable
    Private oDtZonas As DataTable

    Public oDtValidaDetraccion As New DataTable
    Public nCorr As Integer = 0
    Public mListaBultoServicio As List(Of Servicio_BE)
    Public oDtListaPorServicio As New DataTable
    Private Cambiar As Boolean = False
    Dim oDtTarifaFija As New DataTable
    Dim CantidadTarifas As Int32 = 0

    Public CantServicioVariable As Decimal = 0
    Public CantServicioFijo As Decimal = 0
    Dim CodTarifaFija As Decimal = 0
    Public Fija As Integer = 0
    Public Variable As Integer = 0
    Private estatico As New Estaticos

    Dim NRTFSV_ As Decimal = 0
    Dim CDTREF_ As Decimal = 0
    Dim DIASAFACTURAR As Decimal = 0

    '<[AHM]>
    Dim oClaseGeneral As New clsClaseGeneral_BL
    Dim oCentroCosto As New clsCentroCosto_BL

    'JM
    Private ClienteInterno As Boolean = True

    Dim _pCodigoCompania As String = ""
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property

    Private _pNegocio As String = ""
    Public Property pNegocio() As String
        Get
            Return _pNegocio
        End Get
        Set(ByVal value As String)
            _pNegocio = value
        End Set
    End Property
    '</[AHM]>

    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property

    Private _ConsistenciaFac As Boolean
    Public Property ConsistenciaFac() As Boolean
        Get
            Return _ConsistenciaFac
        End Get
        Set(ByVal value As Boolean)
            _ConsistenciaFac = value
        End Set
    End Property
#End Region

    Private Sub frmAgregarServicioPermanencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NRTFSV_ = _oServicio.NRTFSV
        CDTREF_ = _oServicio.CDTREF

        Dim Estado As String = _oServicio.TIPO.ToString
        DIASAFACTURAR = _oServicio.NDIAPL



        CargarTipoAlmacen()
        Cargar_TipoMaterial()
        cargarCentroCostoOrigen() 'JM
        Cambiar = False
        txtCantidadServicio.txtDecimales.ReadOnly = False
        Cambiar = True
        Dim CCosto As Integer = Val("" & _oServicio.CCNTCS & "")
        cargarServicio()
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then

            'Me.cmbTipoAlmacen.Enabled = False
            'Me.dteFechaOperacion.Enabled = False
            If _oServicio.CTPALM.Trim <> String.Empty Then
                Me.txtTipoAlmacen.Valor = _oServicio.CTPALM 'oDtListaPorServicio.Rows(0).Item("CTPALM")
            End If
            txtTipoAlmacen.Enabled = False

            If _oServicio.TTPOMR.Trim <> String.Empty Then
                Me.txtTipoMercaderia.Valor = _oServicio.TTPOMR
            End If
            txtTipoMercaderia.Enabled = False
            If _oServicio.FOPRCN <> 0 Then
                Me.dteFechaOperacion.Value = Comun.FormatoFecha(_oServicio.FOPRCN)
            End If

            CargarTarifaServicio()

            cmbServicio.ComboBox.Enabled = False

            If nCorr = 0 Then
                CargarBultosTemp_1()
            Else
                CargarBultosTemp_2()
            End If

            If CCosto > 0 Then txtCentroBeneficio.Text = CCosto.ToString
            If IsNumeric(txtCentroBeneficio.Text) Then
                oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
                For Each dr As DataRow In oDtCCosto.Select("CCNTCS =" & txtCentroBeneficio.Text)
                    txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                Next
            End If

            txtOrdenCompra.Text = _oServicio.NORCML.Trim
            txtCI.Text = _oServicio.TCTCST.Trim
            txtObservacion.Text = _oServicio.TSRVC.Trim
            txtReferencia.Text = _oServicio.TRFSRC.Trim
            'txtCantidadServicio.txtDecimales.Text = _oServicio.QATNAN.ToString  'val
            Cambiar = True

            '<[AHM]>'
            txtTipoServicio.Valor = _oServicio.CDTSSP
            txtUnidadProductiva.Valor = _oServicio.CDUPSP
            cboTipoActivo.SelectedValue = _oServicio.PRCODI
            txtCentroBeneficio.Valor = _oServicio.CCNTCS

            txtTipoServicio.Enabled = False
            txtUnidadProductiva.Enabled = False
            cboTipoActivo.Enabled = False
            txtCentroBeneficio.Enabled = False
            '</[AHM]>'

            'JM
            uCentroCostoOrig.Valor = _oServicio.CENCO2
            uCentroCostoDest.Valor = _oServicio.CENCOS

        End If


        'KryptonSplitContainer1.SplitterDistance = 300
        'KryptonSplitContainer1.Panel2MinSize = 25
        'KryptonSplitContainer1.Panel1MinSize = 25
        'Me.Size = New Size(880, 350)
        'Me.StartPosition = FormStartPosition.CenterScreen



        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
            Controles_ConsistenciaFac(True)  'JM

            If Estado = Comun.ESTADO_Nuevo Then
                _oServicio.NRTFSV = NRTFSV_
                _oServicio.CDTREF = CDTREF_ 'nuevo
                cargarDatosControlesConsistenciaFac(_oServicio)
            Else
                If _ConsistenciaFac = True Then 'tarifa fija _consistenciafacquitar para que funcione paa ambos
                    UCtxtCantiServFijo.txtDecimales.Text = _oServicio.QATNAN_F.ToString
                    txtCantServVariable.Text = IIf(_oServicio.QATNAN.ToString <> 0, _oServicio.QATNAN / DIASAFACTURAR, 0)
                    txtTotalServicioVariable.Text = IIf(CInt(txtCantServVariable.Text) <> 0, txtCantServVariable.Text * DIASAFACTURAR * txtValorServicio.Text, 0)
                    txtDiasFacturar.Text = DIASAFACTURAR
                Else
                    'UCtxtCantiServFijo.txtDecimales.Text = _oServicio.QATNAN_F.ToString
                    txtCantServVariable.Text = IIf(_oServicio.QATNAN.ToString <> 0, _oServicio.QATNAN / DIASAFACTURAR, 0)
                    txtTotalServicioVariable.Text = IIf(txtCantServVariable.Text <> 0, txtCantServVariable.Text * DIASAFACTURAR * txtValorServicio.Text, 0)
                    txtDiasFacturar.Text = DIASAFACTURAR
                End If
            End If
        Else
            txtCantidadServicio.txtDecimales.Text = _oServicio.QATNAN.ToString  'vale
            Me.GroupBox2.Height = 101
            GroupBox1.Location() = New Point(3, 133)
            GroupBox3.Location() = New Point(3, 277)
        End If

        'JM  
        'MostrarControlesClienteFacturar(_oServicio.CCMPN, _oServicio.CCLNFC)


    End Sub

    Private Sub CargarBultosTemp_1()
        dtgBultos.AutoGenerateColumns = False
        Me.dtgBultos.DataSource = oDtListaPorServicio
    End Sub

    Private Sub CargarBultosTemp_2()
        dtgBultos.AutoGenerateColumns = False
        oDtListaPorServicio.DefaultView.RowFilter = "NCRROP=" & nCorr.ToString
        oDtListaPorServicio = oDtListaPorServicio.DefaultView.ToTable
        dtgBultos.DataSource = oDtListaPorServicio
    End Sub

    Private Sub cargarServicio()
        'If cmbUnidadMedida.DataSource  isnot   Then 
        'End If

        Dim oServicioBL As New clsServicio_BL
        Dim oDtServicio As New DataTable

        'Dim dt As DataTable = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)
        '_oServicio.CCLNT = UcClienteOperacion.pCodigo
        '_oServicio.CPLNDV = Me.cmbPlanta.SelectedValue
        _oServicio.NRRUBR = 2 'por almacenaje

        If Not _oServicio.TIPO = Comun.ESTADO_Modificado Then
            _oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        End If

        '_oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        _oServicio.STPTRA = "D" '"D,S,Q,M" - Cambio Filtro Tipo Tarifa de Todos los tipos a solo Dias de Permanencia
        'Adicion de filtro Tipo de Almacen y Tipo de Material o Mercaderia
        If txtTipoAlmacen.Resultado IsNot Nothing Then
            Dim ta As TipoAlmacen_BE = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
            _oServicio.CTPALM = ta.CTPALM
        End If
        If txtTipoMercaderia.Resultado IsNot Nothing Then
            Dim tm As TipoMaterial_BE = CType(txtTipoMercaderia.Resultado, TipoMaterial_BE)
            _oServicio.TTPOMR = tm.CCMPRN
        End If

        bolBuscar = False
        oDtServicio = oServicioBL.Lista_Tarifa_Servicios_Cliente_Permanencia(_oServicio)
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then
            'oDtServicio.DefaultView.RowFilter = "NRTFSV = " & _oServicio.NRTFSV
            oDtServicio.DefaultView.RowFilter = "NRTFSV = " & _oServicio.CDTREF  'JM
        End If
        oDtTarifaFija = oDtServicio.Copy()


        cmbServicio.DataSource = oDtServicio
        cmbServicio.ComboBox.ValueMember = "NRTFSV"
        cmbServicio.ComboBox.DisplayMember = "DESTAR"
        bolBuscar = True

        If _ConsistenciaFac = True Then
            'cmbServicio.ComboBox.SelectedValue = NRTFSV_
            cmbServicio.ComboBox.SelectedValue = CDTREF_
        End If

    End Sub

    'Private Sub cargarTipoAlmacenOld()
    '    Dim oServicioBL As New clsServicio_BL
    '    Dim oDt As New DataTable
    '    bolBuscar = False
    '    oDt = oServicioBL.Listar_TipoAlmacen(_oServicio.CCLNT)
    '    cmbTipoAlmacen.DataSource = oDt
    '    cmbTipoAlmacen.ValueMember = "CTPALM"
    '    bolBuscar = True
    '    cmbTipoAlmacen.DisplayMember = "TALMC"
    '    cmbTipoAlmacen_SelectedIndexChanged(Nothing, Nothing)
    'End Sub

    'Private Sub cmbTipoAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAlmacen.SelectedIndexChanged
    '    If bolBuscar = True Then
    '        'Cargamos Almacen
    '        If cmbAlmacen.DataSource Is Nothing Then cargaAlmacen()
    '        If Cambiar Then CargarBultos(_oServicio)
    '    End If
    'End Sub

    Private Sub cargaAlmacen()
        Dim oServicioBL As New clsServicio_BL
        Dim oSer As New Servicio_BE
        Dim Ta As TipoAlmacen_BE

        oSer.CCLNT = _oServicio.CCLNT
        Ta = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
        oSer.CTPALM = Ta.CTPALM
        oDtAlmacenes = oServicioBL.Listar_Almacenes(oSer)

        '------------------------------------------------------------------

        cmbAlmacen.ValueMember = "CALMC"
        cmbAlmacen.DisplayMember = "TCMPAL"
        cmbAlmacen.DataSource = oDtAlmacenes
        For i As Integer = 0 To cmbAlmacen.Items.Count - 1
            If cmbAlmacen.Items.Item(i).Value = "0" Then
                cmbAlmacen.SetItemChecked(i, True)
                If cmbZona.DataSource Is Nothing Then cargaZona()
            End If
        Next
    End Sub
    Private Sub CargarCampos()
        If Cambiar Then CargarBultos(_oServicio)
    End Sub
    Private Sub cargaZona()
        Dim oServicioBL As New clsServicio_BL
        Dim oSer As New Servicio_BE
        Dim Ta As TipoAlmacen_BE
        Ta = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
        oSer.CCLNT = _oServicio.CCLNT
        oSer.CTPALM = Ta.CTPALM
        oSer.CALMC = Lista_Almacen()
        oDtZonas = oServicioBL.Listar_Zonas(oSer)
        '------------------------------------------------------------------
        cmbZona.ValueMember = "CZNALM"
        cmbZona.DisplayMember = "TCMCNA"
        cmbZona.DataSource = oDtZonas
        For i As Integer = 0 To cmbZona.Items.Count - 1
            If cmbZona.Items.Item(i).Value = "0" Then
                cmbZona.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Sub Cargar_TipoMaterial()
        Try
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas.Name = "CCMPRN"
            oColumnas.DataPropertyName = "CCMPRN"
            oColumnas.HeaderText = "Cod. Mercadería"
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TDSDES"
            oColumnas.DataPropertyName = "TDSDES"
            oColumnas.HeaderText = "Mercadería"
            oListColum.Add(2, oColumnas)

            Dim dtTipoMaterial As DataTable
            Dim ListTipoMaterial As List(Of TipoMaterial_BE)

            dtTipoMaterial = oServicioBL.Listar_TipoMaterial()
            ListTipoMaterial = ListaTipoMaterial(dtTipoMaterial)

            txtTipoMercaderia.DataSource = ListTipoMaterial
            txtTipoMercaderia.ListColumnas = oListColum
            txtTipoMercaderia.Cargas()
            txtTipoMercaderia.Limpiar()
            txtTipoMercaderia.ValueMember = "CCMPRN"
            txtTipoMercaderia.DispleyMember = "TDSDES"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarTipoAlmacen()
        Dim dtTipoAlmacen As DataTable
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

        Dim ListTipoAlmacen As List(Of TipoAlmacen_BE)
        dtTipoAlmacen = oServicioBL.Listar_TipoDeAlmacen()
        ListTipoAlmacen = ListaTipoAlmacen(dtTipoAlmacen)
        txtTipoAlmacen.DataSource = ListTipoAlmacen

        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "CTPALM"
        txtTipoAlmacen.DispleyMember = "TALMC"
    End Sub

    'Private Sub CargarControles()
    '    Dim oListColum As New Hashtable
    '    Dim oColumnas As New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CTPALM"
    '    oColumnas.DataPropertyName = "PSCTPALM"
    '    oColumnas.HeaderText = "Código "
    '    oListColum.Add(1, oColumnas)
    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TALMC"
    '    oColumnas.DataPropertyName = "PSTALMC"
    '    oColumnas.HeaderText = "Tipo Almacén "
    '    oListColum.Add(2, oColumnas)
    '    Dim obrAlmacen As New brAlmacen

    '    oServicioBL.Listar_TipoAlmacen(_oServicio.CCLNT)

    '    txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
    '    txtTipoAlmacen.ListColumnas = oListColum
    '    txtTipoAlmacen.Cargas()
    '    txtTipoAlmacen.ValueMember = "PSCTPALM"
    '    txtTipoAlmacen.DispleyMember = "PSTALMC"

    '    Dim obeAlmacen As New beAlmacen

    '    obeAlmacen.PSCODVAR = "TIPMAT"
    '    obeAlmacen.PSTTPOMR = ""
    '    TxtTipoMaterial.DataSource = obrAlmacen.ListaTipoDeMaterial(obeAlmacen)
    '    TxtTipoMaterial.ListColumnas = oListColum
    '    TxtTipoMaterial.Cargas()
    '    TxtTipoMaterial.ValueMember = "PSCCMPRN"
    '    TxtTipoMaterial.DispleyMember = "PSTDSDES"

    'End Sub


    Private Sub CargarBultos(ByVal oSerAlmacen As Servicio_BE)
        'If oSerAlmacen.TIPO = Comun.ESTADO_Modificado Then Exit Sub
        If cmbServicio.SelectedValue Is Nothing Then Exit Sub
        Dim oServicioBL As New clsServicio_BL
        Dim oSerBulto As New Servicio_BE
        Dim dtFinal As New DataTable
        Dim dtWayBill As DataTable
        Dim ntotal As Decimal = 0
        Dim Ta As TipoAlmacen_BE
        nCantidadDias = 0
        nCantidadServicios = 0
        dtgBultos.AutoGenerateColumns = False
        dtgBultos.DataSource = Nothing
        Dim dr As DataRow
        oSerBulto.FINGAL = HelpClass.CDate_a_Numero8Digitos(dteFechaOperacion.Value)
        oSerBulto.CCLNT = _oServicio.CCLNT
        oSerBulto.CPLNDV = _oServicio.CPLNDV
        oSerBulto.CCMPN = _oServicio.CCMPN
        oSerBulto.CDVSN = _oServicio.CDVSN

        If txtTipoAlmacen.Resultado IsNot Nothing Then
            Ta = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
            oSerBulto.CTPALM = Ta.CTPALM
        End If

        If txtTipoMercaderia.Resultado IsNot Nothing Then
            oSerBulto.TTPOMR = CType(txtTipoMercaderia.Resultado, TipoMaterial_BE).CCMPRN
        End If

        oSerBulto.CALMC = Lista_Almacen()
        oSerBulto.CZNALM = Lista_Zona()

        mtoDtFormater(dtFinal)
        If _oServicio.CCLNT = 0 Then Exit Sub
        Dim oSerV_BL As New clsServicio_BL
        _oServicio.CCLNT = _oServicio.CCLNT
        'If oSerAlmacen.TIPO = Comun.ESTADO_Modificado Then
        '    Dim oDt As New DataTable
        '    '_oServicio.CPLNDV = cmbPlanta.SelectedValue
        '    oDt = oSerV_BL.fdtListaDetalleServiciosFacturacionSA(_oServicio)
        '    dtgBultos.DataSource = oDt
        'Else
        Dim dtTemp As DataTable = oServicioBL.fdtListaServicioPermanencia(oSerBulto)

        If Not oSerBulto.PSERROR.Trim.Equals("") Then
            MsgBox(oSerBulto.PSERROR, MsgBoxStyle.Information, "Información")
        End If

        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        Dim intNroPeriodo As Integer = 0
        Dim intImporte As Decimal = 0D
        Dim decValor As Decimal = 0
        If dtTemp.Rows.Count > 0 Then
            dtTemp.Columns.Add("NRDIAS")
            dtgBultos.Rows.Clear()
            Dim dwFila As DataRow
            dtWayBill = dtTemp.Clone

            For Each dwFila In dtTemp.Rows
                With Me.dtgBultos
                    Dim pos As Integer = dtgBultos.Rows.Count - 1
                    dr = dtFinal.NewRow
                    dr("CREFFW") = dwFila.Item("CREFFW").ToString.Trim
                    dr("NCRRDC") = dwFila.Item("NCRRDC").ToString.Trim
                    dr("DESCWB") = dwFila.Item("DESCWB").ToString.Trim
                    dr("TUBRFR") = dwFila.Item("TUBRFR").ToString.Trim
                    dr("QREFFW") = dwFila.Item("QREFFW").ToString.Trim
                    dr("TIPBTO") = dwFila.Item("TIPBTO").ToString.Trim
                    dr("QPSOBL") = dwFila.Item("QPSOBL").ToString.Trim
                    dr("TUNPSO") = dwFila.Item("TUNPSO").ToString.Trim
                    dr("QVLBTO") = dwFila.Item("QVLBTO").ToString.Trim
                    dr("TUNVOL") = dwFila.Item("TUNVOL").ToString.Trim
                    dr("QAROCP") = dwFila.Item("QAROCP").ToString.Trim
                    dr("SESTRG") = dwFila.Item("SESTRG").ToString.Trim
                    dr("NSRCN1") = dwFila.Item("NSRCN1").ToString.Trim
                    dr("CPRCN1") = dwFila.Item("CPRCN1").ToString.Trim
                    dr("FINGAL") = dwFila.Item("FINGAL").ToString.Trim
                    dr("FSLDAL") = dwFila.Item("FSLDAL").ToString.Trim
                    dr("CTPALM") = dwFila.Item("CTPALM").ToString.Trim
                    dr("CALMC") = dwFila.Item("CALMC").ToString.Trim
                    dr("CZNALM") = dwFila.Item("CZNALM").ToString.Trim
                    dr("NDIAPL") = dwFila.Item("NDIAPL").ToString + 1
                    dr("TALMC") = dwFila.Item("TALMC").ToString.Trim
                    dr("TCMPAL") = dwFila.Item("TCMPAL").ToString.Trim
                    dr("TCMZNA") = dwFila.Item("TCMZNA").ToString.Trim

                    dr("DIAINV") = dwFila.Item("DIAINV") + 1

                    dr("PERINI") = dwFila.Item("PERINI")
                    dr("PERFIN") = dteFechaOperacion.Value  'Date.Parse(dwFila.Item("PERINI")).AddDays(30)


                    dr("Tarifa") = CDbl(cmbServicio.SelectedItem.Item("IVLSRV").ToString.Trim)
                    dr("MONEDA") = cmbServicio.SelectedItem.Item("TSGNMN").ToString.Trim

                    dr("NRDIAS") = dwFila.Item("NDIAPL") + 1
                    If dr("NDIAPL") < 0 Then
                        dr("NDIAPL") = 0
                    End If

                    Select Case Me.cmbServicio.SelectedItem.Item("CUNDMD")
                        Case "MT2"
                            decValor = dwFila.Item("QAROCP")
                        Case "KGS"
                            decValor = dwFila.Item("QPSOBL")
                        Case "VOL"
                            decValor = dwFila.Item("QVLBTO")
                        Case Else
                            decValor = 0
                    End Select


                    intNroPeriodo = 0
                    Select Case cmbServicio.SelectedItem.Item("STPTRA")
                        Case "D"
                            If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
                                If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
                                    'intNroPeriodo = dr("NRDIAS")
                                    'intImporte = dr("NRDIAS") * decValor
                                    nCantidadServicios = nCantidadServicios + decValor
                                Else
                                    'dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
                                    'intNroPeriodo = dr("NRDIAS")
                                    'intImporte = (dr("NRDIAS") * decValor)
                                    nCantidadServicios = nCantidadServicios + decValor
                                End If
                                dtFinal.Rows.Add(dr)
                            End If

                        Case "S"
                            If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
                                If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 7))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 7)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
                                Else
                                    dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 7))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 7)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
                                End If
                                dtFinal.Rows.Add(dr)
                            End If

                        Case "Q"
                            If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
                                If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 15))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 15)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
                                Else
                                    dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 15))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 15)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
                                End If
                                dtFinal.Rows.Add(dr)
                            End If
                        Case "M"
                            If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
                                If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 30))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 30)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
                                Else
                                    dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
                                    intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 30))
                                    intImporte = Math.Ceiling((dr("NRDIAS") / 30)) * decValor
                                    nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
                                End If
                                dtFinal.Rows.Add(dr)
                            End If

                    End Select

                    dr("QPRDFC") = intNroPeriodo
                    dr("IMPAPLICA") = intImporte
                End With
            Next
            dtgBultos.DataSource = dtFinal
            'txtCantidadServicio.txtDecimales.Text = nCantidadDias.ToString
            'txtTotalServicio.Text = nCantidadDias * CDbl(txtValorServicio.Text)


            'If _ConsistenciaFac = True Then 'TARIFA FIJA  quitar para que funcione para ambos _ConsistenciaFac
            If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                If Not String.IsNullOrEmpty(txtValorTariFija.Text.Trim) Then
                    If nCantidadServicios <= txtCantTariFija.Text Then
                        'Fijo
                        UCtxtCantiServFijo.txtDecimales.Text = txtCantTariFija.Text
                        txtTotalServicioFijo.Text = txtValorTariFija.Text
                        'Variable
                        txtCantServVariable.Text = "0.00"
                        txtTotalServicioVariable.Text = "0.00"
                    Else
                        'Fijo
                        UCtxtCantiServFijo.txtDecimales.Text = txtCantTariFija.Text
                        txtTotalServicioFijo.Text = txtValorTariFija.Text
                        'Variable
                        Dim decTarifaVariable As Decimal = 0
                        decTarifaVariable = nCantidadServicios - Decimal.Parse(txtCantTariFija.Text)
                        txtCantServVariable.Text = decTarifaVariable
                        txtTotalServicioVariable.Text = Math.Round(Decimal.Parse(decTarifaVariable * DIASAFACTURAR * txtValorServicio.Text), 3)
                    End If
                Else
                    txtCantServVariable.Text = nCantidadServicios.ToString
                    txtTotalServicioVariable.Text = Decimal.Parse(nCantidadServicios * DIASAFACTURAR * txtValorServicio.Text)
                End If

            Else
                txtCantidadServicio.txtDecimales.Text = nCantidadServicios.ToString
                txtTotalServicio.Text = Decimal.Parse(nCantidadServicios * DIASAFACTURAR * txtValorServicio.Text)
            End If

        End If

    End Sub

    'Private Sub CargarBultos(ByVal oSerAlmacen As Servicio_BE)
    '    'If oSerAlmacen.TIPO = Comun.ESTADO_Modificado Then Exit Sub
    '    If cmbServicio.SelectedValue Is Nothing Then Exit Sub
    '    Dim oServicioBL As New clsServicio_BL
    '    Dim oSerBulto As New Servicio_BE
    '    Dim dtFinal As New DataTable
    '    Dim dtWayBill As DataTable
    '    Dim ntotal As Decimal = 0
    '    Dim Ta As TipoAlmacen_BE
    '    nCantidadDias = 0
    '    dtgBultos.AutoGenerateColumns = False
    '    dtgBultos.DataSource = Nothing
    '    Dim dr As DataRow
    '    oSerBulto.FINGAL = HelpClass.CDate_a_Numero8Digitos(dteFechaOperacion.Value)
    '    oSerBulto.CCLNT = _oServicio.CCLNT
    '    oSerBulto.CPLNDV = _oServicio.CPLNDV
    '    oSerBulto.CCMPN = _oServicio.CCMPN
    '    oSerBulto.CDVSN = _oServicio.CDVSN

    '    If txtTipoAlmacen.Resultado IsNot Nothing Then
    '        Ta = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
    '        oSerBulto.CTPALM = Ta.CTPALM
    '    End If

    '    If txtTipoMercaderia.Resultado IsNot Nothing Then
    '        oSerBulto.TTPOMR = CType(txtTipoMercaderia.Resultado, TipoMaterial_BE).CCMPRN
    '    End If

    '    oSerBulto.CALMC = Lista_Almacen()
    '    oSerBulto.CZNALM = Lista_Zona()

    '    mtoDtFormater(dtFinal)
    '    If _oServicio.CCLNT = 0 Then Exit Sub
    '    Dim oSerV_BL As New clsServicio_BL
    '    _oServicio.CCLNT = _oServicio.CCLNT
    '    'If oSerAlmacen.TIPO = Comun.ESTADO_Modificado Then
    '    '    Dim oDt As New DataTable
    '    '    '_oServicio.CPLNDV = cmbPlanta.SelectedValue
    '    '    oDt = oSerV_BL.fdtListaDetalleServiciosFacturacionSA(_oServicio)
    '    '    dtgBultos.DataSource = oDt
    '    'Else
    '    Dim dtTemp As DataTable = oServicioBL.fdtListaServicioPermanencia(oSerBulto)

    '    If Not oSerBulto.PSERROR.Trim.Equals("") Then
    '        MsgBox(oSerBulto.PSERROR, MsgBoxStyle.Information, "Información")
    '    End If

    '    ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
    '    Dim intNroPeriodo As Integer = 0
    '    Dim intImporte As Decimal = 0D
    '    Dim decValor As Decimal = 0
    '    If dtTemp.Rows.Count > 0 Then
    '        dtTemp.Columns.Add("NRDIAS")
    '        dtgBultos.Rows.Clear()
    '        Dim dwFila As DataRow
    '        dtWayBill = dtTemp.Clone

    '        For Each dwFila In dtTemp.Rows
    '            With Me.dtgBultos
    '                Dim pos As Integer = dtgBultos.Rows.Count - 1
    '                dr = dtFinal.NewRow
    '                dr("CREFFW") = dwFila.Item("CREFFW").ToString.Trim
    '                dr("NCRRDC") = dwFila.Item("NCRRDC").ToString.Trim
    '                dr("DESCWB") = dwFila.Item("DESCWB").ToString.Trim
    '                dr("TUBRFR") = dwFila.Item("TUBRFR").ToString.Trim
    '                dr("QREFFW") = dwFila.Item("QREFFW").ToString.Trim
    '                dr("TIPBTO") = dwFila.Item("TIPBTO").ToString.Trim
    '                dr("QPSOBL") = dwFila.Item("QPSOBL").ToString.Trim
    '                dr("TUNPSO") = dwFila.Item("TUNPSO").ToString.Trim
    '                dr("QVLBTO") = dwFila.Item("QVLBTO").ToString.Trim
    '                dr("TUNVOL") = dwFila.Item("TUNVOL").ToString.Trim
    '                dr("QAROCP") = dwFila.Item("QAROCP").ToString.Trim
    '                dr("SESTRG") = dwFila.Item("SESTRG").ToString.Trim
    '                dr("NSRCN1") = dwFila.Item("NSRCN1").ToString.Trim
    '                dr("CPRCN1") = dwFila.Item("CPRCN1").ToString.Trim
    '                dr("FINGAL") = dwFila.Item("FINGAL").ToString.Trim
    '                dr("FSLDAL") = dwFila.Item("FSLDAL").ToString.Trim
    '                dr("CTPALM") = dwFila.Item("CTPALM").ToString.Trim
    '                dr("CALMC") = dwFila.Item("CALMC").ToString.Trim
    '                dr("CZNALM") = dwFila.Item("CZNALM").ToString.Trim
    '                dr("NDIAPL") = dwFila.Item("NDIAPL").ToString + 1
    '                dr("TALMC") = dwFila.Item("TALMC").ToString.Trim
    '                dr("TCMPAL") = dwFila.Item("TCMPAL").ToString.Trim
    '                dr("TCMZNA") = dwFila.Item("TCMZNA").ToString.Trim

    '                dr("DIAINV") = dwFila.Item("DIAINV") + 1

    '                dr("PERINI") = dwFila.Item("PERINI")
    '                dr("PERFIN") = dteFechaOperacion.Value  'Date.Parse(dwFila.Item("PERINI")).AddDays(30)


    '                dr("Tarifa") = CDbl(cmbServicio.SelectedItem.Item("IVLSRV").ToString.Trim)
    '                dr("MONEDA") = cmbServicio.SelectedItem.Item("TSGNMN").ToString.Trim

    '                dr("NRDIAS") = dwFila.Item("NDIAPL") + 1
    '                If dr("NDIAPL") < 0 Then
    '                    dr("NDIAPL") = 0
    '                End If

    '                Select Case Me.cmbServicio.SelectedItem.Item("CUNDMD")
    '                    Case "MT2"
    '                        decValor = dwFila.Item("QAROCP")
    '                    Case "KGS"
    '                        decValor = dwFila.Item("QPSOBL")
    '                    Case "VOL"
    '                        decValor = dwFila.Item("QVLBTO")
    '                    Case Else
    '                        decValor = 0
    '                End Select


    '                intNroPeriodo = 0
    '                Select Case cmbServicio.SelectedItem.Item("STPTRA")
    '                    Case "D"
    '                        If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
    '                            If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
    '                                intNroPeriodo = dr("NRDIAS")
    '                                intImporte = dr("NRDIAS") * decValor
    '                                nCantidadDias = nCantidadDias + intImporte
    '                            Else
    '                                dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
    '                                intNroPeriodo = dr("NRDIAS")
    '                                intImporte = (dr("NRDIAS") * decValor)
    '                                nCantidadDias = nCantidadDias + intImporte
    '                            End If
    '                            dtFinal.Rows.Add(dr)
    '                        End If

    '                    Case "S"
    '                        If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
    '                            If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 7))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 7)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
    '                            Else
    '                                dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 7))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 7)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
    '                            End If
    '                            dtFinal.Rows.Add(dr)
    '                        End If

    '                    Case "Q"
    '                        If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
    '                            If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 15))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 15)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
    '                            Else
    '                                dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 15))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 15)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
    '                            End If
    '                            dtFinal.Rows.Add(dr)
    '                        End If
    '                    Case "M"
    '                        If cmbServicio.SelectedItem.Item("PRLBPG") < dr("NRDIAS") Then
    '                            If cmbServicio.SelectedItem.Item("FAPLBR").ToString.Trim.Equals("X") Then
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 30))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 30)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte '* cmbServicio.SelectedItem.Item("VALCTE")
    '                            Else
    '                                dr("NRDIAS") = dr("NRDIAS") - cmbServicio.SelectedItem.Item("PRLBPG")
    '                                intNroPeriodo = Math.Ceiling((dr("NRDIAS") / 30))
    '                                intImporte = Math.Ceiling((dr("NRDIAS") / 30)) * decValor
    '                                nCantidadDias = nCantidadDias + intImporte ' * cmbServicio.SelectedItem.Item("VALCTE")
    '                            End If
    '                            dtFinal.Rows.Add(dr)
    '                        End If

    '                End Select
    '                dr("QPRDFC") = intNroPeriodo
    '                dr("IMPAPLICA") = intImporte
    '            End With
    '        Next
    '        dtgBultos.DataSource = dtFinal
    '        txtCantidadServicio.txtDecimales.Text = nCantidadDias.ToString
    '        txtTotalServicio.Text = nCantidadDias * CDbl(txtValorServicio.Text)

    '    End If
    'End Sub  ' bk  del metodo  


    Private Sub mtoDtFormater(ByVal cpoDataTable As DataTable)

        cpoDataTable.Columns.Add("CREFFW", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NCRRDC", System.Type.GetType("System.Int32"))
        cpoDataTable.Columns.Add("DESCWB", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TUBRFR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QREFFW", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TIPBTO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPSOBL", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNPSO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QVLBTO", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNVOL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QAROCP", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("SESTRG", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NSRCN1", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CPRCN1", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FINGAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FSLDAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NDIAPL", System.Type.GetType("System.Int32"))

        cpoDataTable.Columns.Add("CTPALM", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CALMC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CZNALM", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("TALMC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCMPAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCMZNA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NRDIAS", System.Type.GetType("System.Decimal"))

        cpoDataTable.Columns.Add("IMPAPLICA", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("Tarifa", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("MONEDA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("DIAINV", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("PERINI", System.Type.GetType("System.DateTime"))
        cpoDataTable.Columns.Add("PERFIN", System.Type.GetType("System.DateTime"))
        cpoDataTable.Columns.Add("NROPER", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QPRDFC", System.Type.GetType("System.Decimal"))


    End Sub

    Private Function Lista_Almacen() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbAlmacen.CheckedItems.Count - 1
            If cmbAlmacen.CheckedItems(i).Value = "0" Then
                For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                Next
                Exit For
            End If
            For j As Integer = 0 To oDtAlmacenes.Rows.Count - 1
                If (oDtAlmacenes.Rows(j).Item("CALMC") = cmbAlmacen.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtAlmacenes.Rows(j).Item("CALMC") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function


    Private Function Lista_Zona() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbZona.CheckedItems.Count - 1
            If cmbZona.CheckedItems(i).Value = "0" Then
                For j As Integer = 0 To oDtZonas.Rows.Count - 1
                    strCadDocumentos += oDtZonas.Rows(j).Item("CZNALM") & ","
                Next
                Exit For
            End If
            For j As Integer = 0 To oDtZonas.Rows.Count - 1
                If (oDtZonas.Rows(j).Item("CZNALM") = cmbZona.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtZonas.Rows(j).Item("CZNALM") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub CargarTarifaServicio()
        Try
            Dim oServicioBL As New clsServicio_BL
            Dim oDs As New DataSet
            Dim oDt As New DataTable
            oDs = oServicioBL.fdtObtenerServiciosFacturacionSA(_oServicio)
            If oDs.Tables.Count > 0 Then
                oDt = oDs.Tables(0).Copy

                If oDt.Rows.Count > 0 Then  '
                    oServicio.NOPRCN = oDt.Rows(0).Item("NOPRCN")
                Else
                    oServicio.NOPRCN = 0
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub tsbConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConfirmar.Click
        If Not valida() Then Exit Sub
        If Me.cmbServicio.DataSource IsNot Nothing Then
            _oServicio.NRTFSV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("NRTFSV")
            _oServicio.DESTAR = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("DESTAR")
            _oServicio.VALCTE = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("VALCTE")
            _oServicio.CUNDMD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CUNDMD")
            _oServicio.TSGNMN = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("TSGNMN")
            _oServicio.IVLSRV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("IVLSRV")
            _oServicio.SRBAFD = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("SRBAFD") 'DETRACCION
            _oServicio.TCTCST = txtCI.Text.Trim
            _oServicio.TARIFA_DESC = cmbServicio.Text
            _oServicio.NORCML = txtOrdenCompra.Text.Trim
            _oServicio.QATNRL = 0
            _oServicio.FINPRF = 0
            _oServicio.FFNPRF = 0
            _oServicio.FATNSR = Format(dteFechaOperacion.Value, "yyyyMMdd")
            _oServicio.FOPRCN = _oServicio.FATNSR
            _oServicio.TSRVC = txtObservacion.Text
            _oServicio.TRFSRC = txtReferencia.Text
            _oServicio.CTPALM = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE).CTPALM
            _oServicio.TTPOMR = CType(txtTipoMercaderia.Resultado, TipoMaterial_BE).CCMPRN

            'JM
            _oServicio.CCNBNS = CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PSCCNBNS
            If ClienteInterno Then
                _oServicio.CENCOS = CType(uCentroCostoDest.Resultado, CentroCosto_BE).PNCCNTCS
                _oServicio.CENCO2 = CType(uCentroCostoOrig.Resultado, CentroCosto_BE).PNCCNTCS
                _oServicio.ISRVTI = txtTIValServicio.Text 'CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI")
                _oServicio.ISRVTI_F = txtTITarifaFija.Text 'CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI_F")
            Else
                _oServicio.CENCOS = 0
                _oServicio.CENCO2 = 0
                _oServicio.ISRVTI = 0
                _oServicio.ISRVTI_F = 0
            End If


            If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                'TARIFA FIJA ----------------------------------------------
                '_oServicio.NRTFSV = NRTFSV_ 'Tarifa Original
                _oServicio.QATNAN = IIf(String.IsNullOrEmpty(txtCantServVariable.Text.Trim), 0, txtCantServVariable.Text.Trim) * txtDiasFacturar.Text
                _oServicio.NRTFSV_F = CodTarifaFija    ' Referencial
                _oServicio.QATNAN_F = UCtxtCantiServFijo.txtDecimales.Text
                _oServicio.NDIAPL = CInt(txtDiasFacturar.Text.Trim)
                _oServicio.IVLSRV_F = IIf(String.IsNullOrEmpty(txtValorTariFija.Text.Trim), 0, txtValorTariFija.Text.Trim)
                '-----------------------------------------------------------
                GrabarTarifaVariables()
            Else
                _oServicio.QATNAN = IIf(IsNumeric(txtCantidadServicio.txtDecimales.Text), txtCantidadServicio.txtDecimales.Text, 0)
                mListaBultoServicio = New List(Of Servicio_BE)
                Dim obeServicio As New Servicio_BE

                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos

                    obeServicio = New Servicio_BE

                    obeServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                    obeServicio.DESCWB = dtgBultos.Rows(i).Cells("DESCWB").Value
                    obeServicio.TUBRFR = Convert.ToString(dtgBultos.Rows(i).Cells("TUBRFR").Value)
                    obeServicio.QREFFW = dtgBultos.Rows(i).Cells("QREFFW").Value
                    obeServicio.TIPBTO = dtgBultos.Rows(i).Cells("TIPBTO").Value
                    obeServicio.QPSOBL = dtgBultos.Rows(i).Cells("QPSOBL").Value
                    obeServicio.TUNPSO = dtgBultos.Rows(i).Cells("TUNPSO").Value
                    obeServicio.QVLBTO = dtgBultos.Rows(i).Cells("QVLBTO").Value
                    obeServicio.TUNVOL = dtgBultos.Rows(i).Cells("TUNVOL").Value
                    obeServicio.QAROCP = dtgBultos.Rows(i).Cells("QAROCP").Value
                    obeServicio.SESTRG = dtgBultos.Rows(i).Cells("SESTRG").Value
                    obeServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                    obeServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                    obeServicio.CPLNDV = _oServicio.CPLNDV

                    obeServicio.NCRRDC = Val("" & dtgBultos.Rows(i).Cells("NCRRDC").Value & "")
                    obeServicio.QPRDFC = Val("" & dtgBultos.Rows(i).Cells("QPRDFC").Value & "")
                    obeServicio.TOTALDIAS = dtgBultos.Rows(i).Cells("NDIAPL").Value

                    obeServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value 'Tipo almacen

                    obeServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value  'Almacen
                    obeServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value 'Zona

                    obeServicio.FINGAL = dtgBultos.Rows(i).Cells("FINGAL").Value
                    obeServicio.FSLDAL = dtgBultos.Rows(i).Cells("FSLDAL").Value

                    obeServicio.TALMC = dtgBultos.Rows(i).Cells("TALMC").Value
                    obeServicio.TCMPAL = dtgBultos.Rows(i).Cells("TCMPAL").Value
                    obeServicio.TCMZNA = dtgBultos.Rows(i).Cells("TCMZNA").Value

                    If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
                        obeServicio.NCRROP = nCorr + 1
                    Else
                        obeServicio.NCRROP = IIf(dtgBultos.Rows(i).Cells("NCRROP").Value Is Nothing, IIf(nCorr > 0, nCorr, nCorr + 1), dtgBultos.Rows(i).Cells("NCRROP").Value)
                    End If
                    mListaBultoServicio.Add(obeServicio)
                Next
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub GrabarTarifaVariables() 'TARIFA FIJA
        Dim vueltas As Integer = 1
        Dim flag As Boolean = False
        If UCtxtCantiServFijo.txtDecimales.Text <> 0 AndAlso txtCantServVariable.Text <> 0 Then
            vueltas = 2
        End If
        mListaBultoServicio = New List(Of Servicio_BE)
        Dim obeServicio As New Servicio_BE
        For j As Integer = 1 To vueltas
            nCorr = (j - 1)
            For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                obeServicio = New Servicio_BE
                obeServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                obeServicio.DESCWB = dtgBultos.Rows(i).Cells("DESCWB").Value
                obeServicio.TUBRFR = Convert.ToString(dtgBultos.Rows(i).Cells("TUBRFR").Value)
                obeServicio.QREFFW = dtgBultos.Rows(i).Cells("QREFFW").Value
                obeServicio.TIPBTO = dtgBultos.Rows(i).Cells("TIPBTO").Value
                obeServicio.QPSOBL = dtgBultos.Rows(i).Cells("QPSOBL").Value
                obeServicio.TUNPSO = dtgBultos.Rows(i).Cells("TUNPSO").Value
                obeServicio.QVLBTO = dtgBultos.Rows(i).Cells("QVLBTO").Value
                obeServicio.TUNVOL = dtgBultos.Rows(i).Cells("TUNVOL").Value
                obeServicio.QAROCP = dtgBultos.Rows(i).Cells("QAROCP").Value
                obeServicio.SESTRG = dtgBultos.Rows(i).Cells("SESTRG").Value
                obeServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                obeServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                obeServicio.CPLNDV = _oServicio.CPLNDV

                obeServicio.NCRRDC = Val("" & dtgBultos.Rows(i).Cells("NCRRDC").Value & "")
                obeServicio.QPRDFC = Val("" & dtgBultos.Rows(i).Cells("QPRDFC").Value & "")
                obeServicio.TOTALDIAS = dtgBultos.Rows(i).Cells("NDIAPL").Value

                obeServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value 'Tipo almacen

                obeServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value  'Almacen
                obeServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value 'Zona

                obeServicio.FINGAL = dtgBultos.Rows(i).Cells("FINGAL").Value
                obeServicio.FSLDAL = dtgBultos.Rows(i).Cells("FSLDAL").Value

                obeServicio.TALMC = dtgBultos.Rows(i).Cells("TALMC").Value
                obeServicio.TCMPAL = dtgBultos.Rows(i).Cells("TCMPAL").Value
                obeServicio.TCMZNA = dtgBultos.Rows(i).Cells("TCMZNA").Value

                If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
                    obeServicio.NCRROP = nCorr + 1
                Else
                    If (Fija = 1 And Variable = 0) Or (Fija = 0 And Variable = 1) Then
                        If IIf(Not String.IsNullOrEmpty(txtCantServVariable.Text), txtCantServVariable.Text, 0) <> 0 Then
                            obeServicio.NCRROP = IIf(dtgBultos.Rows(i).Cells("NCRROP").Value Is Nothing, IIf(nCorr > 0, nCorr, nCorr + 1), dtgBultos.Rows(i).Cells("NCRROP").Value) + 1
                        End If
                    Else
                        obeServicio.NCRROP = IIf(dtgBultos.Rows(i).Cells("NCRROP").Value Is Nothing, IIf(nCorr > 0, nCorr, nCorr + 1), dtgBultos.Rows(i).Cells("NCRROP").Value)
                        'If Variable = 1 And IIf(Not String.IsNullOrEmpty(txtCantServVariable.Text), txtCantServVariable.Text, 0) = 0 Then
                        '    mListaBultoServicio.Remove(obeServicio)
                        'End If
                    End If
                End If
                mListaBultoServicio.Add(obeServicio)
            Next
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub





    Private Function valida() As Boolean

        If cmbServicio.DataSource Is Nothing Then
            MessageBox.Show("Se debe de seleccionar el Servicio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        'If _ConsistenciaFac = False Then   'TARIFA FIJA   quitas el if_ConsistenciaFac
        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
            'If txtCantidadServicio.txtDecimales.Text.Length <> 0 Then
            '    Dim cs As Double
            '    cs = CType(txtCantidadServicio.txtDecimales.Text, Double)
            '    If cs = 0 Then
            '        MessageBox.Show("Se debe digitar cantidad servicio  valida", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            'Else
            '    MessageBox.Show("Se debe digitar cantidad servicio  valida", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
        End If

        '<[AHM]>
        If (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
            Dim TipoServicio As ClaseGeneral_BE = CType(txtTipoServicio.Resultado, ClaseGeneral_BE)
            Dim TipoActivo As ClaseGeneral_BE = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE)
            Dim UnidadProductiva As ClaseGeneral_BE = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE)
            If (TipoServicio Is Nothing) Then
                MessageBox.Show("Debe de seleccionar el Tipo de Servicio  ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (UnidadProductiva Is Nothing) Then
                MessageBox.Show("Debe de seleccionar  la  Unidad Productiva ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (TipoActivo Is Nothing) Then
                MessageBox.Show("Debe de seleccionar el Tipo Activo ", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If (txtCentroBeneficio.Resultado Is Nothing) Then
                MessageBox.Show("Ingrese Centro de Beneficio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If
        'Dim cc() As String
        'If txtCentroCosto.Text.Trim.Length > 0 Then
        '    cc = txtCentroCosto.Text.Trim.Split("-")
        '    If cc.Length > 1 Then
        '        txtCentroCosto.Text = cc(0)
        '        'CargaCentroCosto()
        '    Else
        '        _oServicio.CCNTCS = "0"
        '    End If

        'End If
        'If txtCentroCosto.Text.Trim.Length = 0 Then
        '    MessageBox.Show("Ingrese Centro de Costo", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return False
        'End If
        'If Val(_oServicio.CCNTCS) = 0 Then
        '    MessageBox.Show("Ingrese Centro de Costo", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return False
        'End If
        '</[AHM]>

        If dtgBultos.RowCount = 0 Then
            MessageBox.Show("El servicio debe de tener sustento", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        'Centro de costo origen y centro de costo destino 
        'son obligatorios si el cliente es interno
        If (ClienteInterno) Then
            Dim msje As String = ""
            If (uCentroCostoOrig.Resultado Is Nothing) Then
                msje = "Seleccione Centro Costo Origen." & Environment.NewLine
            End If
            If (uCentroCostoDest.Resultado Is Nothing) Then
                msje = msje & "Seleccione Centro Costo Destino." & Environment.NewLine
            End If
            If msje.Trim.Length > 0 Then
                MessageBox.Show(msje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If


        Return True
    End Function

#Region "Centro de Costo"
    Private Codigo As String = ""
    Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarAllCC()
    End Sub

    Private oServicioBL As New clsServicio_BL
    Private oDtCCosto As New DataTable

    Private Sub CargarAllCC()
        Dim frmCCosto As New frmCentroCosto
        Dim dt As New DataTable
        dt = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        frmCCosto.oDtCentroCosto = dt
        If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
            _oServicio.CCNTCS = frmCCosto.nCodigo
            _oServicio.TSRVC = frmCCosto.sDescripcion
            Codigo = _oServicio.CCNTCS

        End If
    End Sub

    Private Sub CargaCentroCosto(ByVal nada As String)
        Dim frmCCosto As New frmCentroCosto
        Dim blEncontrado As Boolean = False
        Dim nCount As Integer = 0
        Dim sDes As String = txtCentroBeneficio.Text


        If IsNumeric(txtCentroBeneficio.Text.Trim) Then
            Codigo = txtCentroBeneficio.Text.Trim
        Else
            Dim nCod As String = txtCentroBeneficio.Text.Split("-")(0)
            If Not nCod Is Nothing Then
                If Codigo = nCod.Trim Then
                    Exit Sub
                End If
            End If
        End If


        _oServicio.CCNTCS = 0
        Dim oDtCCostoDes As New DataTable
        oDtCCosto = oServicioBL.ListaCentroCosto(_oServicio.CCMPN)
        If txtCentroBeneficio.Text.Trim.Length > 0 Then
            If IsNumeric(txtCentroBeneficio.Text) Then
                For Each dr As DataRow In oDtCCosto.Select("CCNTCS=" & txtCentroBeneficio.Text.Trim)
                    txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    blEncontrado = True
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    Exit For
                Next
            Else
                oDtCCosto.DefaultView.RowFilter = "    CCNBNS LIKE '%" & txtCentroBeneficio.Text.Trim & "%'"
                oDtCCostoDes = oDtCCosto.DefaultView.ToTable

                For Each dr As DataRow In oDtCCostoDes.Rows
                    txtCentroBeneficio.Text = dr("CCNTCS") & " - " & dr("CCNBNS")
                    _oServicio.CCNTCS = dr("CCNTCS")
                    _oServicio.TSRVC = dr("CCNBNS")
                    blEncontrado = True
                    nCount += 1
                    If nCount > 1 Then
                        blEncontrado = False
                        txtCentroBeneficio.Text = sDes

                        _oServicio.TSRVC = ""
                        Exit For
                    End If

                Next

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroBeneficio.Text = ""

            If oDtCCosto.Rows.Count > 1 And oDtCCostoDes.Rows.Count > 1 Then

                If blEncontrado = False And Not (nCount = 0 Or nCount = 1) Then
                    If oDtCCostoDes.Rows.Count > 1 Then
                        oDtCCosto = oDtCCosto.DefaultView.ToTable

                    End If
                    frmCCosto.oDtCentroCosto = oDtCCosto
                    frmCCosto.txtDescripcion.Text = "* " & txtCentroBeneficio.Text.Trim & " *"
                    If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                        txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                        _oServicio.CCNTCS = frmCCosto.nCodigo
                        _oServicio.TSRVC = frmCCosto.sDescripcion
                        Codigo = _oServicio.CCNTCS

                    End If
                Else
                    If blEncontrado = False And nCount = 0 And oDtCCosto.Rows.Count > 1 Then
                        If oDtCCostoDes.Rows.Count > 1 Then
                            oDtCCosto = oDtCCosto.DefaultView.ToTable
                        End If
                        frmCCosto.oDtCentroCosto = oDtCCosto
                        If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                            txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                            _oServicio.CCNTCS = frmCCosto.nCodigo
                            _oServicio.TSRVC = frmCCosto.sDescripcion
                            Codigo = _oServicio.CCNTCS

                        End If
                    End If
                End If

            End If
            If _oServicio.CCNTCS = "0" Then txtCentroBeneficio.Text = ""
        Else
            frmCCosto.oDtCentroCosto = oDtCCosto
            If frmCCosto.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCentroBeneficio.Text = frmCCosto.nCodigo & " - " & frmCCosto.sDescripcion
                _oServicio.CCNTCS = frmCCosto.nCodigo
                _oServicio.TSRVC = frmCCosto.sDescripcion

            End If
        End If


    End Sub

    '<[AHM]>
    Private Sub CargarCentroBeneficio()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Centro de Beneficio"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCNBNS"
        oColumnas.DataPropertyName = "PSCCNBNS"
        oColumnas.HeaderText = "Ce.Be SAP"
        oListColum.Add(3, oColumnas)

        Dim olCentroCosto As New List(Of CentroCosto_BE)

        Dim TipoServicio As ClaseGeneral_BE = CType(txtTipoServicio.Resultado, ClaseGeneral_BE)
        Dim TipoActivo As ClaseGeneral_BE = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE)
        Dim UnidadProductiva As ClaseGeneral_BE = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE)

        Dim codTipoServicioSAP As String = ""
        Dim codUnidadProdcutivaSAP As String = ""

        Dim codCompania = String.Empty
        Dim codRegionVentaSAP As String = String.Empty
        Dim codMacroServicioSAP As String = String.Empty

        Dim codTipoActivoSAP As String = String.Empty
        Dim codSedeSAP As String = String.Empty
        Dim tipoCentroSAP As String = String.Empty


        If (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then

            If (TipoServicio Is Nothing) Then Exit Sub
            If (UnidadProductiva Is Nothing) Then Exit Sub

            codTipoServicioSAP = TipoServicio.CDTSSP
            codUnidadProdcutivaSAP = UnidadProductiva.CDUPSP
            codCompania = _oServicio.CCMPN  'tarifa.CCMPN
            codRegionVentaSAP = Me.pNegocio 'CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CRGVTA")    'oContrato.CRGVTA
            codMacroServicioSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP")  'macroServicio.CDSRSP
            codTipoActivoSAP = TipoActivo.PRCODI
            codSedeSAP = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP")   'UcPLanta_Cmb011.CodSedeSAP
            tipoCentroSAP = "0"

        End If

        'olCentroCosto = oCentroCosto.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        olCentroCosto = oCentroCosto.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, codSedeSAP, codUnidadProdcutivaSAP, tipoCentroSAP)
        'Lista_CentroBeneficio_Tokio

        If olCentroCosto.Count > 0 Then
            txtCentroBeneficio.DataSource = olCentroCosto
        Else
            txtCentroBeneficio.DataSource = Nothing
        End If

        txtCentroBeneficio.ListColumnas = oListColum
        txtCentroBeneficio.Cargas()
        txtCentroBeneficio.Limpiar()
        txtCentroBeneficio.ValueMember = "PNCCNTCS"
        txtCentroBeneficio.DispleyMember = "PSTCNTCS"

        'ESTABLECEMOS EL VALOR DE SERVICIO
        If (_oServicio.TIPO <> Comun.ESTADO_Modificado) Then
            If (olCentroCosto.Count > 0) Then
                txtCentroBeneficio.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CCNTCS")
            End If
        End If
    End Sub
    '</[AHM]>
#End Region

    Private Sub cmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServicio.SelectedIndexChanged
        cargarDatosServicio()

    End Sub

    Private Sub cargarDatosServicio()
        Try
            Dim odtTarifa As New DataTable
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            If Me.cmbServicio.SelectedItem Is Nothing Then
                _oServicio.NRTFSV = 0
                txtCentroBeneficio.Text = String.Empty
                'txtTarifaAplicar.Text = String.Empty
                txtValorServicio.Text = String.Empty
                txtMoneda.Text = String.Empty
                lblExcluirPeriodo.Visible = False
                txtPeriodoLibre.Text = String.Empty
                Exit Sub
            End If

            If Not Me.cmbServicio.DataSource Is Nothing Then
                _oServicio.NRTFSV = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("NRTFSV")
            End If
            odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(_oServicio.NRTFSV)

            If (odtTarifa.Rows.Count > 0) Then

                '<[AHM]>
                'If txtCentroCosto.Text.Length = 0 Then
                '    txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim

                '    _oServicio.CCNTCS = odtTarifa.Rows(0)("CCNTCS").ToString.Trim
                'End If
                '</[AHM]>

                'txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
                txtValorServicio.Text = CDbl(odtTarifa.Rows(0)("IVLSRV").ToString.Trim)

                txtTIValServicio.Text = 0 'JM

                txtPeriodoLibre.Text = odtTarifa.Rows(0)("PRLBPG").ToString.Trim & " días"
                lblExcluirPeriodo.Visible = IIf(odtTarifa.Rows(0)("FAPLBR").ToString.Trim.Equals("X"), True, False)
                txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
                txtMoneda02.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
                txtValor.Text = CDbl(odtTarifa.Rows(0)("VALCTE")).ToString.Trim
                txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString
                txtCantidadServicio.txtDecimales.Text = 0D
                txtTotalServicio.Text = 0

                '*************************** CARGO DE LOS DATOS DE TARIFA FIJA *******************
                'If _ConsistenciaFac = True Then
                If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                    If oDtTarifaFija.Rows.Count > 0 Then
                        Dim RowTarifaFija() As DataRow

                        RowTarifaFija = oDtTarifaFija.Select("NRTFSV=" & _oServicio.CDTREF.ToString)
                        CodTarifaFija = NRTFSV_ 'RowTarifaFija(0)("NRTFSV").ToString.Trim

                        'RowTarifaFija = oDtTarifaFija.Select("NRTFSV=" & _oServicio.NRTFSV.ToString)
                        'CodTarifaFija = NRTFSV_ 'RowTarifaFija(0)("CDTREF").ToString.Trim

                        txtValorTariFija.Text = Math.Round(Val(RowTarifaFija(0)("IVLSRV_F").ToString.Trim), 3)
                        txtTITarifaFija.Text = Math.Round(Val(RowTarifaFija(0)("ISRVTI_F").ToString.Trim), 3)
                        txtMonedaTarifaFija.Text = RowTarifaFija(0)("TSGNMN").ToString.Trim
                        txtCantTariFija.Text = Math.Round(Val(RowTarifaFija(0)("VALCTE_F").ToString.Trim), 3)
                        txtUnidadMedidaTariFija.Text = RowTarifaFija(0)("CUNDMD_F").ToString.Trim
                        'txtCentroCosto.Text = RowTarifaFija(0)("CCNTCS_F").ToString.Trim
                        UCtxtCantiServFijo.txtDecimales.Text = 0D
                        txtTotalServicioFijo.Text = 0
                        txtMonedaServFijo.Text = txtMonedaTarifaFija.Text.Trim
                        txtCantServVariable.Text = 0
                        txtTotalServicioVariable.Text = 0
                        txtMonedaServVariable.Text = txtMonedaTarifaFija.Text.Trim

                    End If
                End If
                '*********************************************************************************
                '<[AHM]>
                Dim CDSRSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSRSP").ToString()
                Dim CDSPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDSPSP").ToString()
                Dim CDTASP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTASP").ToString()

                Dim CDTSSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDTSSP").ToString()
                Dim CDUPSP As String = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CDUPSP").ToString()

                Me.CargarTipoServicioSAP(CDSRSP)
                Me.CargarUnidadProductivaSAP(CDSPSP)
                Me.CargarTipoActivoSAP()

                txtTipoServicio.Valor = CDTSSP
                txtUnidadProductiva.Valor = CDUPSP
                cboTipoActivo.SelectedValue = CDTASP
                '</[AHM]>

                'JM
                uCentroCostoOrig.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCO2").ToString()
                uCentroCostoDest.Valor = CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("CENCOS").ToString()
                txtTIValServicio.Text = Math.Round(Val(CType(Me.cmbServicio.SelectedItem, DataRowView).Row.Item("ISRVTI")), 3)

                If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
                    CargarCentroBeneficio()
                End If

            Else

                txtCentroBeneficio.Text = String.Empty
                'txtTarifaAplicar.Text = String.Empty
                txtValorServicio.Text = String.Empty
                txtMoneda.Text = String.Empty
                lblExcluirPeriodo.Visible = False
                txtPeriodoLibre.Text = String.Empty
            End If
            Me.dtgBultos.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dteFechaOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaOperacion.ValueChanged
        If Cambiar Then CargarBultos(_oServicio)
    End Sub

    Private Sub cmbZona_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbZona.Leave
        If Cambiar Then CargarBultos(_oServicio)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        'KryptonSplitContainer1.Panel2MinSize = 25
        'KryptonSplitContainer1.Panel1MinSize = 25
        'KryptonSplitContainer1.SplitterDistance = 300
        'Me.Size = New Size(880, 570)
        'Me.StartPosition = FormStartPosition.CenterScreen
        If Cambiar Then CargarBultos(_oServicio)
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim strlTitulo As New List(Of String)
        Dim Ta As TipoAlmacen_BE
        Ta = CType(txtTipoAlmacen.Resultado, TipoAlmacen_BE)
        strlTitulo.Add("Tipo Almacen:   \n " & Ta.CTPALM)
        strlTitulo.Add("Almacen:   \n " & Me.cmbAlmacen.Text)
        strlTitulo.Add("Zona:   \n " & Me.cmbZona.Text)
        HelpClass.ExportExcelConTitulos(Me.dtgBultos, Me.Text, strlTitulo)
    End Sub

    Public Function ListaTipoAlmacen(ByVal table As DataTable) As List(Of TipoAlmacen_BE)
        Dim result As New List(Of TipoAlmacen_BE)
        For Each row As DataRow In table.Rows
            Dim values As New TipoAlmacen_BE
            values.CTPALM = row("CTPALM").ToString()
            values.TALMC = row("TALMC").ToString()
            result.Add(values)
        Next
        Return result
    End Function

    Public Function ListaTipoMaterial(ByVal table As DataTable) As List(Of TipoMaterial_BE)
        Dim result As New List(Of TipoMaterial_BE)
        For Each row As DataRow In table.Rows
            Dim values As New TipoMaterial_BE
            values.CCMPRN = row("CCMPRN").ToString()
            values.TDSDES = row("TDSDES").ToString()
            result.Add(values)
        Next
        Return result
    End Function
    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoAlmacen.CambioDeTexto
        If Not objData Is Nothing Then
            cargarServicio()
            cargaAlmacen()
        Else
            cmbServicio.DataSource = Nothing
        End If

    End Sub

    Private Sub txtTipoMercaderia_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoMercaderia.CambioDeTexto
        If Not objData Is Nothing Then
            cargarServicio()
        Else
            cmbServicio.DataSource = Nothing
        End If

    End Sub

    Public Sub Controles_ConsistenciaFac(ByVal estado As Boolean) 'TARIFA FIJA

        '********************* CONTROLES A VISUALIZAR *****************
        txtTipoAlmacen.Enabled = Not (estado) 'False
        txtTipoMercaderia.Enabled = Not (estado) ' False
        cmbServicio.ComboBox.Enabled = Not (estado) ' False
        lblDiasFacturar.Visible = (estado) 'True
        txtDiasFacturar.Visible = (estado) 'True
        lblTarifaFija.Visible = (estado) 'True
        txtValorTariFija.Visible = (estado) ' True
        txtMonedaTarifaFija.Visible = (estado) 'True
        lbPor2.Visible = (estado) 'True
        txtCantTariFija.Visible = (estado) 'True
        txtUnidadMedidaTariFija.Visible = (estado) 'True
        lblServFijo.Visible = (estado) 'True
        lblServVariable.Visible = (estado) 'True
        txtCantServVariable.Visible = (estado) 'True
        UCtxtCantiServFijo.Visible = (estado) 'True
        lblImporteServFijo.Visible = (estado) 'True
        lblImporteServVariable.Visible = (estado) 'True
        txtTotalServicioFijo.Visible = (estado) 'True
        txtTotalServicioVariable.Visible = (estado) ' True
        txtMonedaServFijo.Visible = (estado) 'True
        txtMonedaServVariable.Visible = (estado) 'True

        KryptonLabel6.Visible = Not (estado) ' False
        txtCantidadServicio.Visible = Not (estado)  'False
        KryptonLabel9.Visible = Not (estado) 'False
        txtTotalServicio.Visible = Not (estado) 'False
        txtMoneda02.Visible = Not (estado)  'False

        '******************* LOCALIZACION  DE LOS CONTROLES ************
        lblDiasFacturar.Location() = New Point(731, 76)
        txtDiasFacturar.Location() = New Point(825, 74)
        lblExcluirPeriodo.Location() = New Point(524, 105)

        lblOrdendeCompra.Location() = New Point(0, 66)
        txtOrdenCompra.Location() = New Point(121, 66)
        lblCI.Location() = New Point(81, 93)
        txtCI.Location() = New Point(121, 93)
        txtCI.Width = 273
        lblObservacion.Location() = New Point(490, 91)
        txtObservacion.Location() = New Point(576, 91)

        '***************************************************************
        'GroupBox2.Height = 136


    End Sub

    Public Sub cargarDatosControlesConsistenciaFac(ByVal _oServicio1 As Servicio_BE) 'TARIFA FIJA
        txtTipoAlmacen.Valor = _oServicio1.CTPALM
        txtTipoMercaderia.Valor = _oServicio1.TTPOMR.Trim
        txtDiasFacturar.Text = _oServicio1.NDIAPL
    End Sub

    Private Sub txtCantServVariable_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantServVariable.Leave
        Dim VariabledeCalculo As String = ""
        VariabledeCalculo = IIf(txtCantServVariable.Text.Trim = "", 0, txtCantServVariable.Text.Trim)
        txtTotalServicioVariable.Text = Decimal.Parse(VariabledeCalculo * DIASAFACTURAR * txtValorServicio.Text)
    End Sub

    Private Sub txtCantServVariable_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantServVariable.KeyUp
        Dim VariabledeCalculo As String = ""
        VariabledeCalculo = IIf(txtCantServVariable.Text.Trim = "", 0, txtCantServVariable.Text.Trim)
        txtTotalServicioVariable.Text = Decimal.Parse(VariabledeCalculo * DIASAFACTURAR * txtValorServicio.Text)
    End Sub

    Private Sub dtgBultos_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dtgBultos.RowsAdded
        Try
            If dtgBultos.Rows.Count > 0 Then
                Dim totalAreaOcupada As Decimal = 0
                For Each row As DataGridViewRow In dtgBultos.Rows
                    totalAreaOcupada = totalAreaOcupada + Val(row.Cells("QAROCP").Value)
                Next
                KryptonHeaderGroup1.ValuesSecondary.Heading = String.Format("Total :  {0} {1}", totalAreaOcupada, txtUnidadMedida.Text.Trim)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtCantServVariable_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantServVariable.KeyPress
        NumerosyDecimal(txtCantServVariable, e)
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '<[AHM]>
    Private Sub CargarTipoServicioSAP(ByVal PSCDSRSP As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CDTSSP"
        oColumnas.DataPropertyName = "CDTSSP"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDTSSP"
        oColumnas.DataPropertyName = "TDTSSP"
        oColumnas.HeaderText = "Tipo Servicio "
        oListColum.Add(2, oColumnas)

        Dim claseGeneralList As List(Of ClaseGeneral_BE)
        claseGeneralList = oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)

        txtTipoServicio.DataSource = claseGeneralList
        txtTipoServicio.ListColumnas = oListColum
        txtTipoServicio.Cargas()
        txtTipoServicio.ValueMember = "CDTSSP"
        txtTipoServicio.DispleyMember = "TDTSSP"

    End Sub

    Private Sub CargarTipoActivoSAP()
        Dim tipoActivoList As New List(Of ClaseGeneral_BE)
        tipoActivoList = oClaseGeneral.Listar_Tipo_Activo_SAP()

        cboTipoActivo.DataSource = tipoActivoList
        cboTipoActivo.DisplayMember = "PRDESC"
        cboTipoActivo.ValueMember = "PRCODI"
    End Sub

    Private Sub CargarUnidadProductivaSAP(ByVal PSCDSRSP As String)

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

        Dim claseGeneralList As List(Of ClaseGeneral_BE)
        claseGeneralList = oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)

        txtUnidadProductiva.DataSource = claseGeneralList
        txtUnidadProductiva.ListColumnas = oListColum
        txtUnidadProductiva.Cargas()
        txtUnidadProductiva.ValueMember = "CDUPSP"
        txtUnidadProductiva.DispleyMember = "TDUPSP"

    End Sub

    'JM
    Private Sub cargarCentroCostoOrigen()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(3, oColumnas)


        Dim olCentroCostoOrigen As New List(Of CentroCosto_BE)
        olCentroCostoOrigen = oCentroCosto.Listar_CentroCosto_Origen_Tarifa(_oServicio.CCMPN)

        uCentroCostoOrig.DataSource = olCentroCostoOrigen
        uCentroCostoOrig.ListColumnas = oListColum
        uCentroCostoOrig.Cargas()
        uCentroCostoOrig.ValueMember = "PNCCNTCS"
        uCentroCostoOrig.DispleyMember = "PSTCNTCS"

    End Sub

    Private Sub cargarCentroCostoDestino(ByVal ccosto As String)
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNTCS"
        oColumnas.DataPropertyName = "PNCCNTCS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCNTCS"
        oColumnas.DataPropertyName = "PSTCNTCS"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)


        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNCOS"
        oColumnas.DataPropertyName = "PSCCNCOS"
        oColumnas.HeaderText = "Ce.Co. SAP"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)


        Dim olCentroCostoDest As New List(Of CentroCosto_BE)
        olCentroCostoDest = oCentroCosto.Listar_CentroCosto_Destino_Tarifa(_oServicio.CCMPN, Convert.ToDouble(ccosto))
        uCentroCostoDest.DataSource = olCentroCostoDest
        uCentroCostoDest.ListColumnas = oListColum
        uCentroCostoDest.Cargas()
        uCentroCostoDest.ValueMember = "PNCCNTCS"
        uCentroCostoDest.DispleyMember = "PSTCNTCS"

    End Sub

    Private Sub txtTipoServicio_CambioDeTexto(ByVal objData As System.Object) Handles txtTipoServicio.CambioDeTexto
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
                Exit Sub
            End If
            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (txtTipoServicio.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDTSSP = CType(txtTipoServicio.Resultado, ClaseGeneral_BE).CDTSSP
            End If
            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtUnidadProductiva_CambioDeTexto(ByVal objData As System.Object) Handles txtUnidadProductiva.CambioDeTexto
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
                Exit Sub
            End If
            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (txtUnidadProductiva.Resultado Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.CDUPSP = CType(txtUnidadProductiva.Resultado, ClaseGeneral_BE).CDUPSP
            End If
            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub cboTipoActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoActivo.SelectedValueChanged
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(_oServicio.CCMPN) Then
                Exit Sub
            End If
            txtCentroBeneficio.Limpiar()
            txtCentroBeneficio.DataSource = Nothing

            If (CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE) Is Nothing) Then
                Exit Sub
            End If

            If (_oServicio.TIPO = Comun.ESTADO_Nuevo) Then
                _oServicio.PRCODI = CType(cboTipoActivo.SelectedItem, ClaseGeneral_BE).PRCODI
            End If

            Me.CargarCentroBeneficio()
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_CambioDeTexto(ByVal objData As System.Object) Handles txtCentroBeneficio.CambioDeTexto
        Try
            'JM
            uCentroCostoDest.DataSource = Nothing
            uCentroCostoDest.Limpiar()
            If (txtCentroBeneficio.Resultado Is Nothing) Then
                Exit Sub
            Else
                cargarCentroCostoDestino(CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS) 'JM
            End If

            _oServicio.CCNTCS = CType(txtCentroBeneficio.Resultado, CentroCosto_BE).PNCCNTCS
        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub

    Private Sub txtCentroCosto_ClickOnArrow(ByVal objData As System.Object) Handles txtCentroBeneficio.ClickOnArrow
        Try
            If Not (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania) Then
                Exit Sub
            End If

            If (txtCentroBeneficio.DataSource Is Nothing) Then
                MessageBox.Show("Parámetros insuficiente para listar el centro de beneficio, debe de seleccionar el Tipo de servicio, Unidad Productiva.")
            End If

        Catch ex As Exception
            Dim manejadorExcepciones As New ManejadorExcepciones()
            manejadorExcepciones.PublicarExcepcion(ex, Guid.NewGuid())
        End Try
    End Sub
    '</[AHM]>



    'JM
    Private Sub MostrarControlesClienteFacturar(ByVal CCMPN As String, ByVal pCodigoCliente As Integer)
        Dim objNcliente As New clsCliente_BL
        Dim ListaCliente As New List(Of Cliente_BE)
        ListaCliente = objNcliente.Validar_Cliente_Interno_v2(CCMPN, pCodigoCliente)
        If ListaCliente.Count = 0 Then
            ClienteInterno = False
            lblTarifInternValorServ.Visible = False
            txtTIValServicio.Visible = False
            lblTarifInternFija.Visible = False
            txtTITarifaFija.Visible = False
            lblCCOrigen.Visible = False
            uCentroCostoOrig.Visible = False
            lblCCDestino.Visible = False
            uCentroCostoDest.Visible = False

            '******************* LOCALIZACION  DE LOS CONTROLES ************

            txtMoneda.Location() = New Point(185, 72)
            txtMonedaTarifaFija.Location() = New Point(185, 103)
            lblpor1.Location() = New Point(240, 72)
            lbPor2.Location() = New Point(240, 103)

            txtValor.Location() = New Point(280, 72)
            txtCantTariFija.Location() = New Point(280, 103)
            txtUnidadMedida.Location() = New Point(353, 72)
            txtUnidadMedidaTariFija.Location() = New Point(353, 103)

            KryptonLabel7.Location() = New Point(451, 72)
            txtPeriodoLibre.Location() = New Point(583, 72)

            lblDiasFacturar.Location() = New Point(698, 72)
            txtDiasFacturar.Location() = New Point(792, 72)

            lblExcluirPeriodo.Location() = New Point(451, 103)

            lblObservacion.Location() = New Point(490, 37)
            txtObservacion.Location() = New Point(576, 37)


            '*******************************************************

        End If
    End Sub
End Class
