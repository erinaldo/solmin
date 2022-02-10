Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
'Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports System.ComponentModel
Imports System.Text 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)
Public Class ucItemOC_DgF01

#Region "Declaracion de varialbes"
    Private dtView As New DataView
    Private dtItems As New DataTable
    Public strItem As String = String.Empty
#End Region

    Private _pCCMPN_CodCompania As String = ""
    Public Property pCCMPN_CodCompania() As String
        Get
            Return _pCCMPN_CodCompania
        End Get
        Set(ByVal value As String)
            _pCCMPN_CodCompania = value
        End Set
    End Property
 

#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Item As TD_ItemOCPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Item As TD_ItemOCPK)
    'Public Event CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event DeleteHeadOC()
    Public Event GenerarBulto(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As List(Of TD_ItemOCForWayBill), ByVal TotalItem As List(Of TD_ItemOCForWayBill), ByVal oHsSubItems As Hashtable)
    Public Event GenerarRecepcion(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As List(Of TD_ItemOCForWayBill), ByVal TotalItem As List(Of TD_ItemOCForWayBill))
    Public Event InsertarMercaderia(ByVal objInformacion As Hashtable)
    Public Event InsertarOrdenServicio(ByVal objInformacion As Hashtable)
    Public oHasSubItems As New Hashtable()

    Public Event GenerarRecojo(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As List(Of TD_ItemOCForWayBill), ByVal TotalItem As List(Of TD_ItemOCForWayBill), ByVal oHsSubItems As Hashtable)

    Public Event VerMovimiento_X_Item(ByVal TD_ItemOC_Actual As TD_ItemOCPK)
#End Region

#Region " Tipo "

#End Region

#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_OrdenCompraActual As TD_OrdenCompraPK = New Ransa.TYPEDEF.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""

    Private sDefault_Peso As String = ""
    Private sDefault_Volumen As String = ""
    Private _pEstado As String = ""

    Private iNroChkSelecc As Int32 = 0
    Private oMItem As ucItemOC_MItem

    Private _GenerarTipo As eGenerarTipo
    Private objHashtable As New Hashtable

#End Region

#Region " Propiedades "


    Private _pMostrarSegCarga As Boolean = True
    <Browsable(True)> _
    Public Property pMostrarSegCarga() As Boolean
        Get
            Return _pMostrarSegCarga
        End Get
        Set(ByVal value As Boolean)
            _pMostrarSegCarga = value
            If dgItemOC.Columns("IMGSEGCARGA") IsNot Nothing Then
                dgItemOC.Columns("IMGSEGCARGA").Visible = value
            End If
        End Set
    End Property
    Private _pMostrarSegAlmacen As Boolean = True
    <Browsable(True)> _
    Public Property pMostrarSegAlmacen() As Boolean
        Get
            Return _pMostrarSegCarga
        End Get
        Set(ByVal value As Boolean)
            _pMostrarSegCarga = value
            If dgItemOC.Columns("IMGSEGALM") IsNot Nothing Then
                dgItemOC.Columns("IMGSEGALM").Visible = value
            End If
        End Set
    End Property
  

    <Browsable(True)> _
  Public Property pMostrarGenerarRecojo() As Boolean
        Get
            Return Me.btnGenerarRecojo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnGenerarRecojo.Visible = value
            'tssSep_05.Visible = value
            If (value = True) Then
                If _GenerarTipo <> eGenerarTipo.GenerarBulto Then
                    btnMarcarItems.Visible = True
                    dgItemOC.Columns("M_CHK").Visible = True
                    dgItemOC.Columns("M_IMCMR").Visible = False
                    dgItemOC.Columns("M_IMNORS").Visible = False
                    dgItemOC.Columns("M_NORDSR").Visible = False
                    dgItemOC.Columns("M_IVUNIT").Visible = True
                    dgItemOC.Columns("M_IVTOIT").Visible = True
                    dgItemOC.Columns("M_FMPIME").Visible = True
                    dgItemOC.Columns("BTN_SUBITEM").Visible = True
                End If
            End If


        End Set
    End Property

    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property


    <Browsable(True)> _
    Public Property Agregar() As Boolean
        Get
            Return Me.btnAgregar.Visible

        End Get
        Set(ByVal value As Boolean)
            Me.btnAgregar.Visible = value
            'tssSep_01.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property Modificar() As Boolean
        Get
            Return Me.btnEditar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnEditar.Visible = value
            'tssSep_02.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property Eliminar() As Boolean
        Get
            Return Me.btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnEliminar.Visible = value
            'tssSep_03.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property pMostrarGenerar() As eGenerarTipo
        Get
            If _GenerarTipo = Nothing Then _GenerarTipo = eGenerarTipo.Ninguno
            Return _GenerarTipo
        End Get
        Set(ByVal value As eGenerarTipo)
            _GenerarTipo = value
            If value = eGenerarTipo.GenerarBulto Then
                btnGenerarRecepcion.Visible = False
                btnGenerarBulto.Visible = True
                'tssSep_01.Visible = True
                'tssSep_04.Visible = False
                btnMarcarItems.Visible = True
                dgItemOC.Columns("M_CHK").Visible = True
                dgItemOC.Columns("M_IMCMR").Visible = False
                dgItemOC.Columns("M_IMNORS").Visible = False
                dgItemOC.Columns("M_NORDSR").Visible = False

                dgItemOC.Columns("M_IVUNIT").Visible = True
                dgItemOC.Columns("M_IVTOIT").Visible = True
                dgItemOC.Columns("M_FMPIME").Visible = True
                dgItemOC.Columns("BTN_SUBITEM").Visible = True

            ElseIf value = eGenerarTipo.GenerarRecepcion Then
                btnGenerarRecepcion.Visible = True
                'tssSep_04.Visible = True
                'tssSep_01.Visible = False
                btnMarcarItems.Visible = True
                btnGenerarBulto.Visible = False
                dgItemOC.Columns("M_CHK").Visible = True
                dgItemOC.Columns("M_IMCMR").Visible = True
                dgItemOC.Columns("M_IMNORS").Visible = True
                dgItemOC.Columns("M_NORDSR").Visible = True

                dgItemOC.Columns("M_IVUNIT").Visible = False
                dgItemOC.Columns("M_IVTOIT").Visible = False
                dgItemOC.Columns("M_FMPIME").Visible = False
                dgItemOC.Columns("BTN_SUBITEM").Visible = False

            Else
                btnGenerarBulto.Visible = False
                btnGenerarRecepcion.Visible = False
                'tssSep_01.Visible = False
                'tssSep_04.Visible = False
                btnMarcarItems.Visible = False
                dgItemOC.Columns("M_CHK").Visible = False
                dgItemOC.Columns("M_IMCMR").Visible = False
                dgItemOC.Columns("M_IMNORS").Visible = False
                dgItemOC.Columns("M_NORDSR").Visible = False

                dgItemOC.Columns("M_IVUNIT").Visible = False
                dgItemOC.Columns("M_IVTOIT").Visible = False
                dgItemOC.Columns("M_FMPIME").Visible = False
                'dgItemOC.Columns("BTN_SUBITEM").Visible = False
                dgItemOC.Columns("BTN_SUBITEM").Visible = True
            End If
        End Set
    End Property

    Public ReadOnly Property pItemSeleccionada() As TD_ItemOCPK
        Get
            Return TD_ItemOC_Actual
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public WriteOnly Property oHashTable() As Hashtable
        Set(ByVal value As Hashtable)
            objHashtable = value
        End Set
    End Property

#End Region

#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        dgItemOC.AutoGenerateColumns = False
        Dim intCont As Integer = 0
        If btnMarcarItems.Checked Then
            btnMarcarItems.Checked = False
            Dim img As Image = btnMarcarItems.Image
            btnMarcarItems.Image = btnMarcarItems.BackgroundImage
            btnMarcarItems.BackgroundImage = img
        End If
        ' Iniciamos la carga de la información
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            TD_OrdenCompraActual.PAGESIZE = UcPaginacion1.PageSize
            TD_OrdenCompraActual.PAGENUMBER = UcPaginacion1.PageNumber

            dtView = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError).DefaultView
            'dgItemOC.DataSource = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError)
            dtItems = dtView.Table

            dtItems.Columns.Add(New DataColumn("QCNREC", GetType(Decimal)))
            dtItems.Columns.Add(New DataColumn("QPEPQT", GetType(Decimal)))
            dtItems.Columns.Add(New DataColumn("QVOPQT", GetType(Decimal)))
            dtItems.Columns.Add(New DataColumn("TDAITM", GetType(String)))
            dtItems.Columns.Add(New DataColumn("TUNPSO", GetType(String)))
            dtItems.Columns.Add(New DataColumn("TUNVOL", GetType(String)))



            'dtItems.Columns.Add(New DataColumn("TRFRNB", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN1", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN2", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN3", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN4", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN5", GetType(String)))
            'dtItems.Columns.Add(New DataColumn("TRFRN6", GetType(String)))



            For Each dr As DataRow In dtItems.Rows
                dtItems.Rows(intCont).Item("QCNREC") = 0
                dtItems.Rows(intCont).Item("QPEPQT") = 0
                dtItems.Rows(intCont).Item("QVOPQT") = 0
                dtItems.Rows(intCont).Item("TDAITM") = ""
                dtItems.Rows(intCont).Item("TUNPSO") = ""
                dtItems.Rows(intCont).Item("TUNVOL") = ""

                dtItems.Rows(intCont).Item("TRFRNB") = dtView.Table.Rows(intCont)("TRFRNB")
                dtItems.Rows(intCont).Item("TRFRN1") = dtView.Table.Rows(intCont)("TRFRN1")
                dtItems.Rows(intCont).Item("TRFRN2") = dtView.Table.Rows(intCont)("TRFRN2")
                dtItems.Rows(intCont).Item("TRFRN3") = dtView.Table.Rows(intCont)("TRFRN3")
                dtItems.Rows(intCont).Item("TRFRN4") = dtView.Table.Rows(intCont)("TRFRN4")
                dtItems.Rows(intCont).Item("TRFRN5") = dtView.Table.Rows(intCont)("TRFRN5")
                dtItems.Rows(intCont).Item("TRFRN6") = dtView.Table.Rows(intCont)("TRFRN6")


                dtItems.AcceptChanges()
                intCont = intCont + 1

            Next

            dgItemOC.DataSource = dtView.Table

            UcPaginacion1.PageCount = TD_OrdenCompraActual.PAGECOUNT
            iNroChkSelecc = 0
            blnCargando = False
            If strMensajeError <> "" Then
                TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgItemOC.RowCount > 0 Then
                    pCargarImagenSubItems()
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                    intFilaActual = 0
                    dgItemOC.Columns("M_QCNREC").ReadOnly = True
                    dgItemOC.Columns("M_TDAITM").ReadOnly = True
                    dgItemOC.Columns("M_QPEPQT").ReadOnly = True
                    dgItemOC.Columns("M_TUNPSO").ReadOnly = True
                    dgItemOC.Columns("M_QVOPQT").ReadOnly = True
                    dgItemOC.Columns("M_TUNVOL").ReadOnly = True

                    dgItemOC.Columns("M_QCNREC").Visible = False
                    dgItemOC.Columns("M_TDAITM").Visible = False
                    dgItemOC.Columns("M_QPEPQT").Visible = False
                    dgItemOC.Columns("M_TUNPSO").Visible = False
                    dgItemOC.Columns("M_QVOPQT").Visible = False
                    dgItemOC.Columns("M_TUNVOL").Visible = False
                Else
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                    intFilaActual = -1
                End If
                RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    ''' <summary>
    ''' Buscar informaciòn
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pBuscarInformacion()
        dgItemOC.AutoGenerateColumns = False
        If btnMarcarItems.Checked Then
            btnMarcarItems.Checked = False
            Dim img As Image = btnMarcarItems.Image
            btnMarcarItems.Image = btnMarcarItems.BackgroundImage
            btnMarcarItems.BackgroundImage = img
        End If
        ' Iniciamos la carga de la información
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            TD_OrdenCompraActual.PAGESIZE = UcPaginacion1.PageSize
            'TD_OrdenCompraActual.pTDITES_DescripcionItems = txtBuscar.Text.Trim
            TD_OrdenCompraActual.PAGENUMBER = UcPaginacion1.PageNumber
            dgItemOC.DataSource = cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError)
            UcPaginacion1.PageCount = TD_OrdenCompraActual.PAGECOUNT
            iNroChkSelecc = 0
            blnCargando = False
            If strMensajeError <> "" Then
                TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgItemOC.RowCount > 0 Then
                    pCargarImagenSubItems()
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                    intFilaActual = 0
                    dgItemOC.Columns("M_QCNREC").ReadOnly = True
                    dgItemOC.Columns("M_TDAITM").ReadOnly = True
                    dgItemOC.Columns("M_QPEPQT").ReadOnly = True
                    dgItemOC.Columns("M_TUNPSO").ReadOnly = True
                    dgItemOC.Columns("M_QVOPQT").ReadOnly = True
                    dgItemOC.Columns("M_TUNVOL").ReadOnly = True

                    dgItemOC.Columns("M_QCNREC").Visible = False
                    dgItemOC.Columns("M_TDAITM").Visible = False
                    dgItemOC.Columns("M_QPEPQT").Visible = False
                    dgItemOC.Columns("M_TUNPSO").Visible = False
                    dgItemOC.Columns("M_QVOPQT").Visible = False
                    dgItemOC.Columns("M_TUNVOL").Visible = False
                Else
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
                    intFilaActual = -1
                End If
                RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub


    Private Sub pCargarImagenSubItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucItemOC_DgF01))
        For Each oDgvrItemOC As DataGridViewRow In dgItemOC.Rows
      If Not ("" & oDgvrItemOC.Cells("ESSUBITEM").Value & "").ToString.Equals("0") Then oDgvrItemOC.Cells("BTN_SUBITEM").Value = My.Resources.text_block 'CType(resources.GetObject("btnSubItem.Image"), System.Drawing.Image)
            If Not ("" & oDgvrItemOC.Cells("M_NORDSR").Value & "").ToString.Equals("0") Then oDgvrItemOC.Cells("M_IMNORS").Value = My.Resources.button_ok1
            'If Not ("" & oDgvrItemOC.Cells("M_CMRCD").Value & "").ToString.Trim.Equals("") Then oDgvrItemOC.Cells("M_IMCMR").Value = My.Resources.button_ok1
            If Not ("" & oDgvrItemOC.Cells("CMRCLR").Value & "").ToString.Trim.Equals("") Then oDgvrItemOC.Cells("M_IMCMR").Value = My.Resources.button_ok1
        Next
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgItemOC.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = ""
        TD_OrdenCompraActual.pNRUCPR_NroRucProveedor = ""
        ' Limpiamos el Item Seleccionado
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pMarcarFila(ByVal Indice As Int32, ByVal Status As Boolean)
        If Indice = -1 Then Exit Sub
        If Status Then
            dgItemOC.Rows(Indice).Cells("M_QCNREC").Value = dgItemOC.Rows(Indice).Cells("M_QCNPEN").Value
            dgItemOC.Rows(Indice).Cells("M_QCNREC").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_TDAITM").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_QPEPQT").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_TUNPSO").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_TUNPSO").Value = sDefault_Peso
            dgItemOC.Rows(Indice).Cells("M_QVOPQT").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_TUNVOL").ReadOnly = False
            dgItemOC.Rows(Indice).Cells("M_TUNVOL").Value = sDefault_Volumen
            iNroChkSelecc += 1
            If iNroChkSelecc = 1 Then
                dgItemOC.Columns("M_QCNREC").Visible = True
                dgItemOC.Columns("M_TDAITM").Visible = True
                dgItemOC.Columns("M_QPEPQT").Visible = True
                dgItemOC.Columns("M_TUNPSO").Visible = True
                If Me.btnGenerarRecepcion.Visible = False Then
                    dgItemOC.Columns("M_QVOPQT").Visible = True
                    dgItemOC.Columns("M_TUNVOL").Visible = True
                End If
            End If
        Else
            dgItemOC.Rows(Indice).Cells("M_QCNREC").Value = 0
            dgItemOC.Rows(Indice).Cells("M_QPEPQT").Value = 0
            dgItemOC.Rows(Indice).Cells("M_TUNPSO").Value = Nothing
            dgItemOC.Rows(Indice).Cells("M_QVOPQT").Value = 0
            dgItemOC.Rows(Indice).Cells("M_TUNVOL").Value = Nothing
            dgItemOC.Rows(Indice).Cells("M_TDAITM").Value = ""
            dgItemOC.Rows(Indice).Cells("M_QCNREC").ReadOnly = True
            dgItemOC.Rows(Indice).Cells("M_TDAITM").ReadOnly = True
            dgItemOC.Rows(Indice).Cells("M_QPEPQT").ReadOnly = True
            dgItemOC.Rows(Indice).Cells("M_TUNPSO").ReadOnly = True
            dgItemOC.Rows(Indice).Cells("M_QVOPQT").ReadOnly = True
            dgItemOC.Rows(Indice).Cells("M_TUNVOL").ReadOnly = True
            iNroChkSelecc -= 1
            If iNroChkSelecc = 0 Then
                dgItemOC.Columns("M_QCNREC").Visible = False
                dgItemOC.Columns("M_TDAITM").Visible = False
                dgItemOC.Columns("M_QPEPQT").Visible = False
                dgItemOC.Columns("M_TUNPSO").Visible = False
                dgItemOC.Columns("M_QVOPQT").Visible = False
                dgItemOC.Columns("M_TUNVOL").Visible = False
            End If
        End If
    End Sub

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos las opciones de Gestión
        btnGenerarBulto.Enabled = True
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        RemoveHandler oMItem.pDisposeForm, AddressOf pDisposeFormServF01
        oMItem.Dispose()
        oMItem = Nothing
        If StatusProceso And Not objSqlManager Is Nothing And dgItemOC.RowCount > 0 Then Call pRefrescar()
    End Sub

    Private Sub Tabular_Columnas_Recepcion()
        Me.dgItemOC.Columns.Item("M_CHK").DisplayIndex = 0
        Me.dgItemOC.Columns.Item("M_NRITOC").DisplayIndex = 1
        Me.dgItemOC.Columns.Item("M_TCITCL").DisplayIndex = 2
        Me.dgItemOC.Columns.Item("M_TDITES").DisplayIndex = 3
        Me.dgItemOC.Columns.Item("M_QCNTIT").DisplayIndex = 4
        Me.dgItemOC.Columns.Item("M_TUNDIT").DisplayIndex = 5
        Me.dgItemOC.Columns.Item("M_QCNPEN").DisplayIndex = 6
        Me.dgItemOC.Columns.Item("M_QCNREC").DisplayIndex = 7
        Me.dgItemOC.Columns.Item("M_QPEPQT").DisplayIndex = 8
        Me.dgItemOC.Columns.Item("M_TUNPSO").DisplayIndex = 9
        Me.dgItemOC.Columns.Item("M_TDAITM").DisplayIndex = 10
        Me.dgItemOC.Columns.Item("M_IMCMR").DisplayIndex = 11
        Me.dgItemOC.Columns.Item("M_IMNORS").DisplayIndex = 12
        Me.dgItemOC.Columns.Item("M_NORDSR").DisplayIndex = 13
    End Sub

#End Region

#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ' Validamos de que haya un cliente seleccionado
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        oMItem = New ucItemOC_MItem(TD_OrdenCompraActual, strUsuario)
        AddHandler oMItem.pDisposeForm, AddressOf pDisposeFormServF01
        'btnGenerarBulto.Enabled = False
        'btnAgregar.Enabled = False
        'btnEditar.Enabled = False
        'btnEliminar.Enabled = False
        oMItem.pHabilitarNroItem = True
        oMItem.phabilitarBulto = btnGenerarBulto.Visible
        'oMItem.Show()
        oMItem.ShowDialog()
        'pCargarInformacion()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        ' Validamos de que haya un item seleccionado
        If TD_ItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub
        ' Creamos la variables de trabajo
        Dim objItemOC As TD_ItemOC = New TD_ItemOC
        Dim dteTemp As Date
        With objItemOC
            .pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            .pNRITOC_NroItemOC = TD_ItemOC_Actual.pNRITOC_NroItemOC
            .pTCITCL_CodigoCliente = ("" & dgItemOC.CurrentRow.Cells("M_TCITCL").Value).ToString.Trim
            .pTCITPR_CodigoProveedor = ("" & dgItemOC.CurrentRow.Cells("M_TCITPR").Value).ToString.Trim
            .pTDITES_DescripcionES = ("" & dgItemOC.CurrentRow.Cells("M_TDITES").Value).ToString.Trim
            .pTDITIN_DescripcionIN = ("" & dgItemOC.CurrentRow.Cells("M_TDITIN").Value).ToString.Trim
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QCNTIT").Value, .pQCNTIT_Cantidad)
            .pTUNDIT_Unidad = ("" & dgItemOC.CurrentRow.Cells("M_TUNDIT").Value).ToString.Trim
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_IVUNIT").Value, .pIVUNIT_ImporteUnitario)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_IVTOIT").Value, .pIVTOIT_ImporteTotal)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QTOLMAX").Value, .pQTOLMAX_ToleranciaMax)
            Decimal.TryParse("" & dgItemOC.CurrentRow.Cells("M_QTOLMIN").Value, .pQTOLMIN_ToleranciaMin)
            Date.TryParse("" & dgItemOC.CurrentRow.Cells("M_FMPDME").Value, dteTemp)
            .pFMPDME_FechaEstEntregaDte = dteTemp
            Date.TryParse("" & dgItemOC.CurrentRow.Cells("M_FMPIME").Value, dteTemp)
            .pFMPIME_FechaReqPlantaDte = dteTemp
            .pTLUGOR_LugarOrigen = ("" & dgItemOC.CurrentRow.Cells("M_TLUGOR").Value).ToString.Trim
            .pTLUGEN_LugarEntrega = ("" & dgItemOC.CurrentRow.Cells("M_TLUGEN").Value).ToString.Trim
            .pTCTCST_CentroDeCosto = ("" & dgItemOC.CurrentRow.Cells("M_TCTCST").Value).ToString.Trim
            .pTRFRN_RefSolicitante = ("" & dgItemOC.CurrentRow.Cells("M_TRFRN").Value).ToString.Trim
            .pFLGPEN_FlagSeguimiento = ("" & dgItemOC.CurrentRow.Cells("M_FLGPEN").Value).ToString.Trim

            .PTRFRNB_RefB = ("" & dgItemOC.CurrentRow.Cells("TRFRNB").Value).ToString.Trim

            .PTRFRN1_CentroDestino = ("" & dgItemOC.CurrentRow.Cells("TRFRN1").Value).ToString.Trim
            .PTRFRN2_AlmDestino = ("" & dgItemOC.CurrentRow.Cells("TRFRN2").Value).ToString.Trim
            .PTRFRN3_Ref3 = ("" & dgItemOC.CurrentRow.Cells("TRFRN3").Value).ToString.Trim
            .PTRFRN4_AlmProcedencia = ("" & dgItemOC.CurrentRow.Cells("TRFRN4").Value).ToString.Trim
            .PTRFRN5_Direccion5 = ("" & dgItemOC.CurrentRow.Cells("TRFRN5").Value).ToString.Trim
            .PTRFRN6_ClaseValoracion = ("" & dgItemOC.CurrentRow.Cells("TRFRN6").Value).ToString.Trim
            'agregando el campo sunat

            .pUNSPSC_Sunat = ("" & dgItemOC.CurrentRow.Cells("UNSPSC").Value).ToString.Trim
        End With
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        oMItem = New ucItemOC_MItem(objItemOC, strUsuario)
        AddHandler oMItem.pDisposeForm, AddressOf pDisposeFormServF01
        'btnGenerarBulto.Enabled = False
        'btnAgregar.Enabled = False
        'btnEditar.Enabled = False
        'btnEliminar.Enabled = False
        oMItem.pHabilitarNroItem = False
        oMItem.phabilitarBulto = btnGenerarBulto.Visible
        'oMItem.Show()
        oMItem.ShowDialog()
        'pCargarInformacion()
    End Sub



    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_ItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub

        Dim blnCancelar As Boolean = False
        RaiseEvent Confirm("¿Desea eliminar el registro actual?", blnCancelar)
        If blnCancelar Then Exit Sub

        Dim strStatusUltReg As String = "N"
        Dim strMensaje As String = ""
        If cItemOrdenCompra.Delete(objSqlManager, TD_ItemOC_Actual, strUsuario, strStatusUltReg, strMensajeError) Then
            If strStatusUltReg = "S" Then
                strMensaje = "NOTA : Se eliminó la O/C por no poseer Items Activos."
                RaiseEvent DeleteHeadOC()
            Else
                dgItemOC.Rows.Remove(dgItemOC.CurrentRow)
            End If
            RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & vbNewLine & strMensaje)
        Else
            RaiseEvent ErrorMessage(strMensajeError)
        End If
    End Sub

    Private Sub btnGenerarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarBulto.Click
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            Dim lstItemsSelec As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim lstTotalItems As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim objTemp As TD_ItemOCForWayBill = Nothing
            dgItemOC.CommitEdit(DataGridViewDataErrorContexts.Commit)
            While intCont < dgItemOC.RowCount
                If (Me.pEstado <> "Devolucion") Then
                    If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                        If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                            If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value <= 0 Then
                                strMensajeError = "No se Puede Generar Bulto. Cantidades Recibidas no validas."
                                RaiseEvent ErrorMessage(strMensajeError)
                                Exit Sub
                            Else
                                objTemp = New TD_ItemOCForWayBill
                                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                                objTemp.pTDITES_DescripcionItem = dgItemOC.Rows(intCont).Cells("M_TDITES").Value
                                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                                objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                                objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                                objTemp.pQCNTIT_CantidadSolicitada = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                                objTemp.pQCNPEN_CantidadPendiente = dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value
                                objTemp.pTLUGEN_LugarDeEntrega = ("" & dgItemOC.Rows(intCont).Cells("M_TLUGEN").Value).ToString.Trim
                                objTemp.pTLUGOR_LugarDeOrigen = ("" & dgItemOC.Rows(intCont).Cells("M_TLUGOR").Value).ToString.Trim
                                objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                                objTemp.pQPEPQT_Peso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                                lstItemsSelec.Add(objTemp)

                            End If

                        End If
                    End If
                    intCont += 1
                Else
                    If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                        If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value <= 0 Then
                            strMensajeError = "No se Puede Generar Bulto. Cantidades Recibidas no validas."
                            RaiseEvent ErrorMessage(strMensajeError)
                            Exit Sub
                        Else
                            objTemp = New TD_ItemOCForWayBill
                            objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                            objTemp.pTDITES_DescripcionItem = dgItemOC.Rows(intCont).Cells("M_TDITES").Value
                            objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                            objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                            objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                            objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                            objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                            objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                            objTemp.pQCNTIT_CantidadSolicitada = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                            objTemp.pQCNPEN_CantidadPendiente = dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value
                            objTemp.pTLUGEN_LugarDeEntrega = ("" & dgItemOC.Rows(intCont).Cells("M_TLUGEN").Value).ToString.Trim
                            objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                            objTemp.pQPEPQT_Peso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                            objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                            lstItemsSelec.Add(objTemp)
                        End If
                    End If
                    intCont += 1
                End If
            End While
            intCont = 0
            While intCont < dgItemOC.RowCount
                objTemp = New TD_ItemOCForWayBill
                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                lstTotalItems.Add(objTemp)
                intCont += 1
            End While
            If lstItemsSelec.Count > 0 Then
                RaiseEvent GenerarBulto(TD_OrdenCompraActual, lstItemsSelec, lstTotalItems, oHasSubItems)
            Else
                strMensajeError = "No se ha procesado ningún Item. Validar la Información."
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub

    Private Sub btnGenerarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRecepcion.Click
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            Dim lstItemsSelec As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim lstTotalItems As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim objTemp As TD_ItemOCForWayBill = Nothing
            dgItemOC.CommitEdit(DataGridViewDataErrorContexts.Commit)
            'Me.dgItemOC.RowsDefaultCellStyle.BackColor = Control.DefaultBackColor
            While intCont < dgItemOC.RowCount
                If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                    If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                        If dgItemOC.Rows(intCont).Cells("M_CMRCD").Value.ToString.Equals("") OrElse dgItemOC.Rows(intCont).Cells("M_NORDSR").Value = 0 OrElse dgItemOC.Rows(intCont).Cells("M_NCNTR").Value = 0 Then
                            MessageBox.Show("Item no Tiene O/S o  Mercadería no existe", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Me.dgItemOC.Rows(intCont).DefaultCellStyle.BackColor = Color.Yellow
                            Exit Sub
                        End If
                        'If (dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value.ToString.Trim <> dgItemOC.Rows(intCont).Cells("M_CUNCN5").Value.ToString.Trim) Then
                        '  MessageBox.Show("Unidad C. Item diferente Unidad C. O/S", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '  Me.dgItemOC.Rows(intCont).DefaultCellStyle.BackColor = Color.YellowGreen
                        '  Exit Sub
                        'End If
                    End If
                End If
                intCont += 1
            End While
            intCont = 0
            While intCont < dgItemOC.RowCount
                If (Me.pEstado <> "Devolucion") Then
                    If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                        If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                            objTemp = New TD_ItemOCForWayBill
                            objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                            objTemp.pTCITCL_CodigoCliente = ("" & dgItemOC.Rows(intCont).Cells("M_TCITCL").Value).ToString.Trim
                            objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                            objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                            objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                            objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                            objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                            objTemp.pCMRCD_CodigoRANSA = ("" & dgItemOC.Rows(intCont).Cells("M_CMRCD").Value).ToString.Trim
                            objTemp.pTMRCD2_MercaDescripcion = ("" & dgItemOC.Rows(intCont).Cells("M_TMRCD2").Value).ToString.Trim
                            objTemp.pNORDSR_OrdenServicio = dgItemOC.Rows(intCont).Cells("M_NORDSR").Value
                            objTemp.pNCNTR_NroContrato = dgItemOC.Rows(intCont).Cells("M_NCNTR").Value
                            objTemp.pNCRCTC_NroCorrelativoContrato = dgItemOC.Rows(intCont).Cells("M_NCRCTC").Value
                            objTemp.pNAUTR_NroAutorizacionContrato = dgItemOC.Rows(intCont).Cells("M_NAUTR").Value
                            objTemp.pCTPDPS_TipoDeposito = ("" & dgItemOC.Rows(intCont).Cells("M_CTPDPS").Value).ToString.Trim
                            objTemp.pFUNDS2_Status = ("" & dgItemOC.Rows(intCont).Cells("M_FUNDS2").Value).ToString.Trim
                            objTemp.pCUNCN5_UnidadCantidad = dgItemOC.Rows(intCont).Cells("M_CUNCN5").Value
                            objTemp.pCUNPS5_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_CUNPS5").Value).ToString.Trim
                            objTemp.pCUNVL5_UnidadValor = ("" & dgItemOC.Rows(intCont).Cells("M_CUNVL5").Value).ToString.Trim
                            objTemp.pFMPDME_FechaMaxDespacho = ("" & dgItemOC.Rows(intCont).Cells("M_FMPDME").Value).ToString.Trim
                            objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim

                            objTemp.pFlagControlUbicacion = ("" & dgItemOC.Rows(intCont).Cells("FUBICAC").Value).ToString.Trim
                            objTemp.pCantOS_X_SKU = ("" & dgItemOC.Rows(intCont).Cells("CANT_OS").Value).ToString.Trim
                            objTemp.pFUNCTL_FlagControlDeLotes = ("" & dgItemOC.Rows(intCont).Cells("FUNCTL").Value).ToString.Trim
                            objTemp.pFlagControlSerie = ("" & dgItemOC.Rows(intCont).Cells("FSERIE").Value).ToString.Trim

                            lstItemsSelec.Add(objTemp)
                        End If
                    End If
                Else
                    If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value > 0 Then
                        If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                            If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value <= 0 Then
                                strMensajeError = "No se Puede Generar Bulto. Cantidades Recibidas no validas."
                                RaiseEvent ErrorMessage(strMensajeError)
                                Exit Sub
                            Else
                                objTemp = New TD_ItemOCForWayBill
                                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                                objTemp.pTCITCL_CodigoCliente = ("" & dgItemOC.Rows(intCont).Cells("M_TCITCL").Value).ToString.Trim
                                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                                objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                                objTemp.pCMRCD_CodigoRANSA = ("" & dgItemOC.Rows(intCont).Cells("M_CMRCD").Value).ToString.Trim
                                objTemp.pTMRCD2_MercaDescripcion = ("" & dgItemOC.Rows(intCont).Cells("M_TMRCD2").Value).ToString.Trim
                                objTemp.pNORDSR_OrdenServicio = dgItemOC.Rows(intCont).Cells("M_NORDSR").Value
                                objTemp.pNCNTR_NroContrato = dgItemOC.Rows(intCont).Cells("M_NCNTR").Value
                                objTemp.pNCRCTC_NroCorrelativoContrato = dgItemOC.Rows(intCont).Cells("M_NCRCTC").Value
                                objTemp.pNAUTR_NroAutorizacionContrato = dgItemOC.Rows(intCont).Cells("M_NAUTR").Value
                                objTemp.pCTPDPS_TipoDeposito = ("" & dgItemOC.Rows(intCont).Cells("M_CTPDPS").Value).ToString.Trim
                                objTemp.pFUNDS2_Status = ("" & dgItemOC.Rows(intCont).Cells("M_FUNDS2").Value).ToString.Trim
                                objTemp.pCUNCN5_UnidadCantidad = dgItemOC.Rows(intCont).Cells("M_CUNCN5").Value
                                objTemp.pCUNPS5_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_CUNPS5").Value).ToString.Trim
                                objTemp.pCUNVL5_UnidadValor = ("" & dgItemOC.Rows(intCont).Cells("M_CUNVL5").Value).ToString.Trim
                                objTemp.pFMPDME_FechaMaxDespacho = ("" & dgItemOC.Rows(intCont).Cells("M_FMPDME").Value).ToString.Trim
                                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim

                                objTemp.pFlagControlUbicacion = ("" & dgItemOC.Rows(intCont).Cells("FUBICAC").Value).ToString.Trim
                                objTemp.pCantOS_X_SKU = ("" & dgItemOC.Rows(intCont).Cells("CANT_OS").Value).ToString.Trim
                                objTemp.pFUNCTL_FlagControlDeLotes = ("" & dgItemOC.Rows(intCont).Cells("FUNCTL").Value).ToString.Trim
                                objTemp.pFlagControlSerie = ("" & dgItemOC.Rows(intCont).Cells("FSERIE").Value).ToString.Trim


                                lstItemsSelec.Add(objTemp)

                            End If

                        End If
                    End If
                End If
                
                intCont += 1
            End While
            intCont = 0
            While intCont < dgItemOC.RowCount
                objTemp = New TD_ItemOCForWayBill
                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                objTemp.pTCITCL_CodigoCliente = ("" & dgItemOC.Rows(intCont).Cells("M_TCITCL").Value).ToString.Trim
                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                'objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                'objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                objTemp.pCMRCD_CodigoRANSA = ("" & dgItemOC.Rows(intCont).Cells("M_CMRCD").Value).ToString.Trim
                objTemp.pTMRCD2_MercaDescripcion = ("" & dgItemOC.Rows(intCont).Cells("M_TMRCD2").Value).ToString.Trim
                objTemp.pNORDSR_OrdenServicio = dgItemOC.Rows(intCont).Cells("M_NORDSR").Value
                objTemp.pNCNTR_NroContrato = dgItemOC.Rows(intCont).Cells("M_NCNTR").Value
                objTemp.pNCRCTC_NroCorrelativoContrato = dgItemOC.Rows(intCont).Cells("M_NCRCTC").Value
                objTemp.pNAUTR_NroAutorizacionContrato = dgItemOC.Rows(intCont).Cells("M_NAUTR").Value
                objTemp.pCTPDPS_TipoDeposito = ("" & dgItemOC.Rows(intCont).Cells("M_CTPDPS").Value).ToString.Trim
                objTemp.pFUNDS2_Status = ("" & dgItemOC.Rows(intCont).Cells("M_FUNDS2").Value).ToString.Trim
                objTemp.pCUNCN5_UnidadCantidad = dgItemOC.Rows(intCont).Cells("M_CUNCN5").Value
                objTemp.pCUNPS5_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_CUNPS5").Value).ToString.Trim
                objTemp.pCUNVL5_UnidadValor = ("" & dgItemOC.Rows(intCont).Cells("M_CUNVL5").Value).ToString.Trim
                objTemp.pFMPDME_FechaMaxDespacho = ("" & dgItemOC.Rows(intCont).Cells("M_FMPDME").Value).ToString.Trim
                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim

                objTemp.pFlagControlUbicacion = ("" & dgItemOC.Rows(intCont).Cells("FUBICAC").Value).ToString.Trim
                objTemp.pCantOS_X_SKU = ("" & dgItemOC.Rows(intCont).Cells("CANT_OS").Value).ToString.Trim
                objTemp.pFUNCTL_FlagControlDeLotes = ("" & dgItemOC.Rows(intCont).Cells("FUNCTL").Value).ToString.Trim
                objTemp.pFlagControlSerie = ("" & dgItemOC.Rows(intCont).Cells("FSERIE").Value).ToString.Trim


                lstTotalItems.Add(objTemp)
                intCont += 1
            End While
            If lstItemsSelec.Count > 0 Then
                RaiseEvent GenerarRecepcion(TD_OrdenCompraActual, lstItemsSelec, lstTotalItems)
            Else
                strMensajeError = "No se ha procesado ningún Item. Validar la Información."
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub

    Public Sub UpdateCell_Mercaderia(ByVal strMercaderia_CMRCD As String, ByVal strDescripcion_TMRCD2 As String)
        If strMercaderia_CMRCD = "" Then Exit Sub
        Me.dgItemOC.CurrentRow.Cells("M_CMRCD").Value = strMercaderia_CMRCD
        Me.dgItemOC.CurrentRow.Cells("M_TMRCD2").Value = strDescripcion_TMRCD2
        Me.dgItemOC.CurrentRow.Cells("M_IMCMR").Value = My.Resources.button_ok1
        Me.dgItemOC.EndEdit()
    End Sub

    Public Sub UpdateCell_OrdenServicio(ByVal objHashtable As Hashtable) 'ByVal intOrdenServicio_NORDSR As Int64, ByVal intNroContrato As Int64, ByVal intNroCorrelativoContrato As Int64, ByVal intNroAutorizacionContrato As Int64, ByVal strTipoDeposito As String, ByVal strEstado As String)
        If objHashtable("M_NORDSR") = 0 OrElse objHashtable("M_NCNTR") = 0 Then Exit Sub 'intOrdenServicio_NORDSR = 0 OrElse intNroContrato = 0 Then Exit Sub
        Me.dgItemOC.CurrentRow.Cells("M_NORDSR").Value = objHashtable("M_NORDSR") 'intOrdenServicio_NORDSR
        Me.dgItemOC.CurrentRow.Cells("M_NCNTR").Value = objHashtable("M_NCNTR") 'intNroContrato
        Me.dgItemOC.CurrentRow.Cells("M_NCRCTC").Value = objHashtable("M_NCRCTC") 'intNroCorrelativoContrato
        Me.dgItemOC.CurrentRow.Cells("M_NAUTR").Value = objHashtable("M_NAUTR") 'intNroAutorizacionContrato
        Me.dgItemOC.CurrentRow.Cells("M_CTPDPS").Value = objHashtable("M_CTPDPS") 'strTipoDeposito
        Me.dgItemOC.CurrentRow.Cells("M_FUNDS2").Value = objHashtable("M_FUNDS2") 'strEstado
        Me.dgItemOC.CurrentRow.Cells("M_CUNCN5").Value = objHashtable("M_CUNCN5") 'strUnidadCantidad
        Me.dgItemOC.CurrentRow.Cells("M_CUNPS5").Value = objHashtable("M_CUNPS5") 'strUnidadPeso
        Me.dgItemOC.CurrentRow.Cells("M_CUNVL5").Value = objHashtable("M_CUNVL5") 'strUnidadValor

        Me.dgItemOC.CurrentRow.Cells("M_IMNORS").Value = My.Resources.button_ok1
        Me.dgItemOC.EndEdit()
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        strItem = String.Empty
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            iNroChkSelecc = 0
            While intCont < dgItemOC.RowCount
                If (Me.pEstado <> "Devolucion") Then
                    If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                        dgItemOC.Rows(intCont).Cells("M_CHK").Value = btnMarcarItems.Checked
                        If btnMarcarItems.Checked Then
                            strItem = strItem & "|" & dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                            Call pMarcarFila(intCont, True)
                        Else
                            iNroChkSelecc += 1
                            Call pMarcarFila(intCont, False)
                        End If
                    End If
                    intCont += 1
                Else
                    dgItemOC.Rows(intCont).Cells("M_CHK").Value = btnMarcarItems.Checked
                    If btnMarcarItems.Checked Then
                        strItem = strItem & "|" & dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                        Call pMarcarFila(intCont, True)
                    Else
                        iNroChkSelecc += 1
                        Call pMarcarFila(intCont, False)
                    End If
                    intCont += 1
                End If

            End While
        End If
    End Sub

    Private Sub ucOrdenCompra_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing

        ' Limpiamos la Memoria
        cMemory.ClearMemory()
    End Sub

    Private Sub ucOrdenCompra_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()

        '-- Información Unidad Peso y Volumen
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        '-- Peso
        M_TUNPSO.DataSource = oUnidad.fdtListar("P", sDefault_Peso)
        M_TUNPSO.DisplayMember = "TABRUN"
        M_TUNPSO.ValueMember = "TABRUN"
        '-- Volumen
        M_TUNVOL.DataSource = oUnidad.fdtListar("V", sDefault_Volumen)
        M_TUNVOL.DisplayMember = "TABRUN"
        M_TUNVOL.ValueMember = "TABRUN"

        If Me.btnGenerarRecepcion.Visible = True Then Tabular_Columnas_Recepcion()

        ' Limpiamos la Memoria
        cMemory.ClearMemory()
    End Sub

    Private Sub dgItemOC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellEndEdit
        Dim intCont As Integer = 0
        Dim ColumName As String
        If blnCargando Then Exit Sub
        With dgItemOC
            Select Case .Columns(e.ColumnIndex).Name


                Case "M_TDAITM"
                    intCont = 0
                    .CurrentCell.Value = ("" & .CurrentCell.Value).ToString.ToUpper.Trim
                    For Each dr As DataRow In dtItems.Rows

                        If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                            dtItems.Rows(intCont).Item("TDAITM") = .CurrentCell.Value
                            dtItems.AcceptChanges()
                            Exit For
                        End If


                        intCont = intCont + 1
                    Next
                    dtView = dtItems.DefaultView

                    txtDescripcion_TextChanged(Nothing, Nothing)


                Case "M_QCNREC"
                    intCont = 0
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        Dim decTemp As Decimal = 0D
                        Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                        .CurrentCell.Value = decTemp
                    End If
                    If .CurrentCell.Value < 0 Then
                        strMensajeError = "El monto debe ser mayor a cero o igual."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    Else
                        If (Me.pEstado <> "Devolucion") Then
                            If .CurrentCell.Value > .CurrentRow.Cells("M_QCNPEN").Value Then
                                strMensajeError = "La cantida a recibir no puede ser mayor a la cantidad pendiente."
                                RaiseEvent ErrorMessage(strMensajeError)
                                .CurrentCell.Value = .CurrentRow.Cells("M_QCNPEN").Value

                            Else



                                For Each dr As DataRow In dtItems.Rows

                                    If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                                        dtItems.Rows(intCont).Item("QCNREC") = .CurrentCell.Value
                                        dtItems.AcceptChanges()
                                        Exit For
                                    End If


                                    intCont = intCont + 1
                                Next
                                dtView = dtItems.DefaultView
                                txtDescripcion_TextChanged(Nothing, Nothing)

                            End If

                        End If
                    End If
                Case "M_QPEPQT"
                    intCont = 0
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        Dim decTemp As Decimal = 0D
                        Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                        .CurrentCell.Value = decTemp
                    End If
                    If .CurrentCell.Value < 0 Then
                        strMensajeError = "El monto debe ser mayor a cero o igual."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    Else
                        For Each dr As DataRow In dtItems.Rows

                            If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                                dtItems.Rows(intCont).Item("QPEPQT") = .CurrentCell.Value
                                dtItems.AcceptChanges()
                                Exit For
                            End If


                            intCont = intCont + 1
                        Next
                        dtView = dtItems.DefaultView
                        txtDescripcion_TextChanged(Nothing, Nothing)

                    End If
                Case "M_QVOPQT"
                    intCont = 0
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        Dim decTemp As Decimal = 0D
                        Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                        .CurrentCell.Value = decTemp
                    End If
                    If .CurrentCell.Value < 0 Then
                        strMensajeError = "El monto debe ser mayor a cero o igual."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D

                    Else
                        For Each dr As DataRow In dtItems.Rows

                            If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                                dtItems.Rows(intCont).Item("QVOPQT") = .CurrentCell.Value
                                dtItems.AcceptChanges()
                                Exit For
                            End If


                            intCont = intCont + 1
                        Next
                        dtView = dtItems.DefaultView
                        txtDescripcion_TextChanged(Nothing, Nothing)
                    End If
                    'If .CurrentRow.Cells("M_QTOMAX").Value > .CurrentRow.Cells("M_QCNTIT").Value Then
                    '    If .CurrentRow.Cells("M_QTOMAX").Value - .CurrentRow.Cells("M_QCNTIT").Value + .CurrentRow.Cells("M_QCNPEN").Value - _
                    '       .CurrentRow.Cells("M_QCNREC").Value < 0 And .CurrentRow.Cells("M_QCNREC").Value > 0 Then
                    '        If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    '            If .CurrentRow.Cells("M_QCNPEN").Value > 0 Then
                    '                .CurrentRow.Cells("M_QCNREC").Value = .CurrentRow.Cells("M_QCNPEN").Value
                    '            Else
                    '                .CurrentRow.Cells("M_QCNREC").Value = 0
                    '            End If
                    '        End If
                    '    End If
                    'Else
                    '    If .CurrentRow.Cells("M_QCNPEN").Value - .CurrentRow.Cells("M_QCNREC").Value < 0 And .CurrentRow.Cells("M_QCNREC").Value > 0 Then
                    '        If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    '            If .CurrentRow.Cells("M_QCNPEN").Value > 0 Then
                    '                .CurrentRow.Cells("M_QCNREC").Value = .CurrentRow.Cells("D_QCNPEN").Value
                    '            Else
                    '                .CurrentRow.Cells("M_QCNREC").Value = 0
                    '            End If
                    '        End If
                    '    End If
                    'End If
                Case "M_TUNPSO"
                    intCont = 0
                    For Each dr As DataRow In dtItems.Rows

                        If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                            dtItems.Rows(intCont).Item("TUNPSO") = .CurrentCell.Value
                            dtItems.AcceptChanges()
                            Exit For
                        End If


                        intCont = intCont + 1
                    Next
                    dtView = dtItems.DefaultView
                    txtDescripcion_TextChanged(Nothing, Nothing)


                Case "M_TUNVOL"
                    intCont = 0
                    For Each dr As DataRow In dtItems.Rows

                        If .CurrentRow.Cells("M_NRITOC").Value = dr("NRITOC") Then
                            dtItems.Rows(intCont).Item("TUNVOL") = .CurrentCell.Value
                            dtItems.AcceptChanges()
                            Exit For
                        End If


                        intCont = intCont + 1
                    Next
                    dtView = dtItems.DefaultView
                    txtDescripcion_TextChanged(Nothing, Nothing)

            End Select
            ColumName = .Columns(e.ColumnIndex).Name
        End With
    End Sub

    Private Sub dgItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellContentClick
        If blnCargando Then Exit Sub
        With dgItemOC
            If .RowCount > 0 Then
                pCargarImagenSubItems()
                If e.ColumnIndex = 0 Then
                    If .CurrentCellAddress.Y < 0 Then Exit Sub
                    If .CurrentCell.Value Then
                        .CurrentCell.Value = False
                        Call pMarcarFila(e.RowIndex, False)
                    Else
                        If (Me.pEstado <> "Devolucion") Then
                            If .CurrentRow.Cells("M_QCNPEN").Value <= 0 Then Exit Sub
                            .CurrentCell.Value = True
                            Call pMarcarFila(e.RowIndex, True)
                        Else
                            .CurrentCell.Value = True
                            Call pMarcarFila(e.RowIndex, True)
                        End If
                    End If
                End If

                Select Case .Columns(e.ColumnIndex).Name
                    Case "BTN_SUBITEM"
                        If .CurrentRow.Cells("ESSUBITEM").Value.ToString.Equals("0") Then Exit Sub
                        Dim Item As New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
                        With Item
                            .pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                            .pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                            .pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                        End With
                        Dim oucListaSubItemOC As New ucListaSubItemOC_DgF01(Item)
                        If (Me.pEstado <> "Devolucion") Then
                            oucListaSubItemOC.pEstado = ""
                        Else
                            oucListaSubItemOC.pEstado = "Devolucion"
                        End If

                        oucListaSubItemOC.pHabilitarBulto = Me.dgItemOC.CurrentRow.Cells("M_CHK").Value 'btnGenerarBulto.Visible
                        oucListaSubItemOC.oHasSubItems = oHasSubItems
                        If oucListaSubItemOC.ShowDialog() = DialogResult.OK Then
                            oHasSubItems = oucListaSubItemOC.oHasSubItems
                        End If
                    Case "M_IMNORS"
                        If .CurrentRow.Cells("M_CMRCD").Value.ToString.Equals("") Then Exit Sub
                        Dim oHashtable As New Hashtable
                        oHashtable.Add("M_CMRCLR", Me.dgItemOC.CurrentRow.Cells("M_TCITCL").Value)
                        RaiseEvent InsertarOrdenServicio(oHashtable)
                    Case "M_IMCMR"
                        If Not .CurrentRow.Cells("M_CMRCD").Value.ToString.Equals("") Then Exit Sub
                        Dim oHashtable As New Hashtable
                        oHashtable.Add("M_CMRCLR", Me.dgItemOC.CurrentRow.Cells("M_TCITCL").Value)
                        oHashtable.Add("M_TMRCD2", Me.dgItemOC.CurrentRow.Cells("M_TDITES").Value)
                        'oHashtable.Add("M_CPRVCL", Me.dgItemOC.CurrentRow.Cells("D_CPRVCL").Value)
                        'oHashtable.Add("M_TCITPR", IIf(Me.dgItemOC.CurrentRow.Cells("M_TCITPR").Value.ToString.Trim.Equals(""), 0, Me.dgItemOC.CurrentRow.Cells("M_TCITPR").Value))
                        RaiseEvent InsertarMercaderia(oHashtable)


                End Select

            End If
            If dgItemOC.CurrentRow.Cells("M_CHK").Value = False Then
                Dim strNroItem As String() = strItem.Split("|")
                strItem = ""
                For Each strVal As String In strNroItem

                    If strVal <> dgItemOC.CurrentRow.Cells("M_NRITOC").Value.ToString Then
                        strItem = strItem & "|" & strVal
                    End If
                Next
            Else
                strItem = strItem & "|" & .CurrentRow.Cells("M_NRITOC").Value.ToString
            End If

        End With
    End Sub

    Private Sub dgItemOC_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemOC.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgItemOC.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
        If dgItemOC.CurrentCell.RowIndex <> intFilaActual Then
            intFilaActual = dgItemOC.CurrentCell.RowIndex
            pCargarImagenSubItems()
            TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
            TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
            TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
            RaiseEvent CurrentRowChanged(TD_ItemOC_Actual)
        End If
    End Sub

#End Region

#Region " Métodos "
    Public Sub pActualizar(ByVal OrdenCompra As TD_OrdenCompraPK)
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = OrdenCompra.pCCLNT_CodigoCliente
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
        TD_OrdenCompraActual.pNRUCPR_NroRucProveedor = OrdenCompra.pNRUCPR_NroRucProveedor
        TD_OrdenCompraActual.pCCMPN_CodCompania = OrdenCompra.pCCMPN_CodCompania
        TD_OrdenCompraActual.pCDVSN_CodDivision = OrdenCompra.pCDVSN_CodDivision
        TD_OrdenCompraActual.pCPLNDV_CodPlanta = OrdenCompra.pCPLNDV_CodPlanta
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub
#End Region

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        pCargarInformacion()
    End Sub

    Private Sub btnGenerarRecojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarRecojo.Click
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            Dim lstItemsSelec As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim lstTotalItems As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim objTemp As TD_ItemOCForWayBill = Nothing
            dgItemOC.CommitEdit(DataGridViewDataErrorContexts.Commit)
            While intCont < dgItemOC.RowCount
                If (Me.pEstado <> "Devolucion") Then
                    If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                        If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                            If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value <= 0 Then
                                strMensajeError = "No se Puede Generar Bulto. Cantidades Recibidas no validas."
                                RaiseEvent ErrorMessage(strMensajeError)
                                Exit Sub
                            Else
                                objTemp = New TD_ItemOCForWayBill
                                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                                objTemp.pTDITES_DescripcionItem = dgItemOC.Rows(intCont).Cells("M_TDITES").Value
                                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                                objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                                objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                                objTemp.pQCNTIT_CantidadSolicitada = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                                objTemp.pQCNPEN_CantidadPendiente = dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value
                                objTemp.pTLUGEN_LugarDeEntrega = ("" & dgItemOC.Rows(intCont).Cells("M_TLUGEN").Value).ToString.Trim
                                objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                                objTemp.pQPEPQT_Peso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                                lstItemsSelec.Add(objTemp)

                            End If

                        End If
                    End If
                    intCont += 1
                Else
                    If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                        If dgItemOC.Rows(intCont).Cells("M_QCNREC").Value <= 0 Then
                            strMensajeError = "No se Puede Generar Bulto. Cantidades Recibidas no validas."
                            RaiseEvent ErrorMessage(strMensajeError)
                            Exit Sub
                        Else
                            objTemp = New TD_ItemOCForWayBill
                            objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                            objTemp.pTDITES_DescripcionItem = dgItemOC.Rows(intCont).Cells("M_TDITES").Value
                            objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                            objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                            objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                            objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                            objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                            objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                            objTemp.pQCNTIT_CantidadSolicitada = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                            objTemp.pQCNPEN_CantidadPendiente = dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value
                            objTemp.pTLUGEN_LugarDeEntrega = ("" & dgItemOC.Rows(intCont).Cells("M_TLUGEN").Value).ToString.Trim
                            objTemp.pTUNDIT_UnidadQta = ("" & dgItemOC.Rows(intCont).Cells("M_TUNDIT").Value).ToString.Trim
                            objTemp.pQPEPQT_Peso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                            objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                            lstItemsSelec.Add(objTemp)
                        End If
                    End If
                    intCont += 1
                End If
            End While
            intCont = 0
            While intCont < dgItemOC.RowCount
                objTemp = New TD_ItemOCForWayBill
                objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNTIT").Value
                objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                objTemp.pUNSPSC_CodUn = ("" & dgItemOC.Rows(intCont).Cells("UNSPSC").Value).ToString.Trim
                lstTotalItems.Add(objTemp)
                intCont += 1
            End While
            If lstItemsSelec.Count > 0 Then
                RaiseEvent GenerarRecojo(TD_OrdenCompraActual, lstItemsSelec, lstTotalItems, oHasSubItems)
            Else
                strMensajeError = "No se ha procesado ningún Item. Validar la Información."
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub

    Private Sub dgItemOC_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellContentDoubleClick
        Try
            Dim oFrmSeguimientoCarga As New Ransa.Controls.Seguimiento.FrmSeguimientoCarga
            Dim ColName As String = ""
            Select Case dgItemOC.Columns(e.ColumnIndex).Name
                Case "MOVITEM"
                    TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                    TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                    TD_ItemOC_Actual.pCCMPN_Compania = TD_OrdenCompraActual.pCCMPN_CodCompania
                    TD_ItemOC_Actual.pCDVSN_Division = TD_OrdenCompraActual.pCDVSN_CodDivision
                    TD_ItemOC_Actual.pCPLNDV_Planta = TD_OrdenCompraActual.pCPLNDV_CodPlanta
                    TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                    RaiseEvent VerMovimiento_X_Item(TD_ItemOC_Actual)

                Case "IMGSEGALM"
                    If Val(dgItemOC.Item("SEGALM", e.RowIndex).Value) > 0 Then
                        If Val(dgItemOC.Item("ESDS", e.RowIndex).Value) > 0 Then
                            Dim oFrmMovimientoOC As New frmMovimientoOcSDS
                            oFrmMovimientoOC.pCCLNT = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                            oFrmMovimientoOC.pNORCML = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                            oFrmMovimientoOC.pNRITOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                            oFrmMovimientoOC.ShowDialog()
                        Else
                            Dim ofrmMovimientoxItem As New frmMovimientoxItem
                            ofrmMovimientoxItem.pCCLNT = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                            ofrmMovimientoxItem.pCCMPN = _pCCMPN_CodCompania
                            ofrmMovimientoxItem.pNORCML = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                            ofrmMovimientoxItem.pNRITOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                            ofrmMovimientoxItem.ShowDialog()
                        End If
                    End If
                Case "IMGSEGCARGA"
                    If Val(dgItemOC.Item("SEGCARGA", e.RowIndex).Value) > 0 Then
                        oFrmSeguimientoCarga.PNCCLNT = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                        oFrmSeguimientoCarga.PSCCMPN = _pCCMPN_CodCompania
                        oFrmSeguimientoCarga.PSCDVSN = "S"
                        oFrmSeguimientoCarga.PSNORCML = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                        oFrmSeguimientoCarga.PNNRITEM_INI = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                        oFrmSeguimientoCarga.PNNRITEM_FIN = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
                        oFrmSeguimientoCarga.CASO = Val(dgItemOC.Item("SEGCARGA", e.RowIndex).Value)
                        oFrmSeguimientoCarga.ShowDialog()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub dgItemOC_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgItemOC.DataBindingComplete
    ' Pintar si es >0 SEGALM y SEGCARGA
    Dim SEGALM As Integer = 0
    Dim SEGCARGA As Integer = 0
    For Each oDgvrItemOC As DataGridViewRow In dgItemOC.Rows
      SEGALM = Val(oDgvrItemOC.Cells("SEGALM").Value)
      SEGCARGA = Val(oDgvrItemOC.Cells("SEGCARGA").Value)
      If SEGALM > 0 Then
        oDgvrItemOC.Cells("IMGSEGALM").Value = My.Resources.text_block
      Else
        oDgvrItemOC.Cells("IMGSEGALM").Value = My.Resources.EnBlanco
      End If
      If SEGCARGA > 0 Then
        oDgvrItemOC.Cells("IMGSEGCARGA").Value = My.Resources.text_block
      Else
        oDgvrItemOC.Cells("IMGSEGCARGA").Value = My.Resources.EnBlanco
      End If
    Next
  End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            UcPaginacion1.PageNumber = 1
            pBuscarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

        dtView.RowFilter = "TDITES like '%" & txtDescripcion.Text & "%'"

        If Not strItem Is Nothing Then
            If strItem.Length > 0 Then
                Dim strItemAll As String() = strItem.Split("|")
                If strItemAll.Length > 0 Then
                    If dgItemOC.RowCount > 0 Then
                        Dim intCont As Int32 = 0

                        For Each oDgvrItemOC As DataGridViewRow In dgItemOC.Rows

                            For Each strVal As String In strItemAll
                                If strVal = oDgvrItemOC.Cells("M_NRITOC").Value.ToString Then
                                    dgItemOC.Rows(intCont).Cells("M_CHK").Value = True
                                    Exit For
                                End If
                            Next
                            intCont = intCont + 1

                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgItemOC_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemOC.Sorted
        txtDescripcion_TextChanged(Nothing, Nothing)
    End Sub

    Public Function ItemChecked() As String 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)
        Dim item As New StringBuilder
        For Each row As DataGridViewRow In dgItemOC.Rows
            If (CBool(row.Cells.Item("M_CHK").Value)) Then
                item.Append(String.Format("{0},", Trim(row.Cells.Item("M_NRITOC").Value)))
            End If
        Next row

        If item.Length > 0 Then
            Return Mid(Trim(item.ToString), 1, Len(Trim(item.ToString)) - 1)
        End If

        Return String.Empty
    End Function
End Class

Public Enum eGenerarTipo As Integer
  Ninguno = -1
  GenerarRecepcion = 1
  GenerarBulto = 2
End Enum
