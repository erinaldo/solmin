Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Waybill
Imports RANSA.DAO.WayBill

Public Class ucItemsWaybill_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirmar(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Agregar()
    Public Event Eliminar(ByVal ItemBulto As TD_Sel_ItemBulto_L01)
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal ItemBulto As TD_Sel_ItemBulto_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal ItemBulto As TD_Sel_ItemBulto_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_Filtro As TD_BultoPK = New Ransa.TypeDef.WayBill.TD_BultoPK
    Private TD_ItemBultoActual As TD_Sel_ItemBulto_L01 = New Ransa.TypeDef.WayBill.TD_Sel_ItemBulto_L01
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "
    Public Property pCCLNT_CodigoCliente() As Int64
        Get
            Return TD_Filtro.pCCLNT_CodigoCliente
        End Get
        Set(ByVal value As Int64)
            If TD_Filtro.pCCLNT_CodigoCliente <> value Then pLimpiarContenido()
            TD_Filtro.pCCLNT_CodigoCliente = value
        End Set
    End Property

    Public ReadOnly Property pItemBultoSeleccionado() As TD_Sel_ItemBulto_L01
        Get
            Return TD_ItemBultoActual
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public Property MostrarBtnAgregar() As Boolean
        Get
            Return btnAgregar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnAgregar.Visible = value
            tssSep_01.Visible = value
        End Set
    End Property

    Public Property MostrarBtnEliminar() As Boolean
        Get
            Return btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnEliminar.Visible = value
            tssSep_01.Visible = value
        End Set
    End Property

    Public Property BackGround() As Color
        Get
            Return dgItemsBulto.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgItemsBulto.StateCommon.Background.Color1 = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgItemsBulto.DataSource = cWayBill.fdtListar_ItemsBultos_L01(objSqlManager, TD_Filtro, strMensajeError)
            blnCargando = False
            If strMensajeError <> "" Then
                TD_ItemBultoActual.pClear()
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                If dgItemsBulto.RowCount > 0 Then
                    With TD_ItemBultoActual
                        .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                        .pCREFFW_CodigoBulto = TD_Filtro.pCREFFW_CodigoBulto
                        .pCIDPAQ_CodigoIdentificacion = dgItemsBulto.CurrentRow.Cells("M_CIDPAQ").Value.ToString.Trim
                        .pNORCML_NroOrdenCompra = dgItemsBulto.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
                        .pNRITOC_NroItemOrdenCompra = dgItemsBulto.CurrentRow.Cells("M_NRITOC").Value
                        .pQBLTSR_pCantidadRecibida = dgItemsBulto.CurrentRow.Cells("M_QBLTSR").Value

                        .pQPEPQT_QtaPeso = dgItemsBulto.CurrentRow.Cells("M_QPEPQT").Value
                        .pTUNPSO_UnidadPeso = dgItemsBulto.CurrentRow.Cells("M_TUNPSO").Value.ToString.Trim
                        .pQVOPQT_QtaVolumen = dgItemsBulto.CurrentRow.Cells("M_QVOPQT").Value
                        .pTUNVOL_UnidadVolumen = dgItemsBulto.CurrentRow.Cells("M_TUNVOL").Value.ToString.Trim

                        .pTDITES_DescripcionES = ("" & dgItemsBulto.CurrentRow.Cells("M_TDITES").Value).ToString.Trim
                        .pTLUGEN_LugarEntrega = ("" & dgItemsBulto.CurrentRow.Cells("M_TLUGEN").Value).ToString.Trim
                    End With
                    intFilaActual = 0
                Else
                    TD_ItemBultoActual.pClear()
                    intFilaActual = -1
                End If
                RaiseEvent DataLoadCompleted(TD_ItemBultoActual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgItemsBulto.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        TD_ItemBultoActual.pClear()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub ucWaybill_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucWaybill_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
    End Sub

    Private Sub dgItemsBulto_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemsBulto.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgItemsBulto.CurrentCell Is Nothing Then
            intFilaActual = -1
            TD_ItemBultoActual.pClear()
        Else
            If dgItemsBulto.CurrentCell.RowIndex <> intFilaActual Then
                intFilaActual = dgItemsBulto.CurrentCell.RowIndex
                With TD_ItemBultoActual
                    .pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
                    .pCREFFW_CodigoBulto = TD_Filtro.pCREFFW_CodigoBulto
                    .pCIDPAQ_CodigoIdentificacion = dgItemsBulto.CurrentRow.Cells("M_CIDPAQ").Value.ToString.Trim
                    .pNORCML_NroOrdenCompra = dgItemsBulto.CurrentRow.Cells("M_NORCML").Value.ToString.Trim
                    .pNRITOC_NroItemOrdenCompra = dgItemsBulto.CurrentRow.Cells("M_NRITOC").Value
                    .pQBLTSR_pCantidadRecibida = dgItemsBulto.CurrentRow.Cells("M_QBLTSR").Value

                    .pQPEPQT_QtaPeso = dgItemsBulto.CurrentRow.Cells("M_QPEPQT").Value
                    .pTUNPSO_UnidadPeso = dgItemsBulto.CurrentRow.Cells("M_TUNPSO").Value.ToString.Trim
                    .pQVOPQT_QtaVolumen = dgItemsBulto.CurrentRow.Cells("M_QVOPQT").Value
                    .pTUNVOL_UnidadVolumen = dgItemsBulto.CurrentRow.Cells("M_TUNVOL").Value.ToString.Trim

                    .pTDITES_DescripcionES = ("" & dgItemsBulto.CurrentRow.Cells("M_TDITES").Value).ToString.Trim
                    .pTLUGEN_LugarEntrega = ("" & dgItemsBulto.CurrentRow.Cells("M_TLUGEN").Value).ToString.Trim
                End With
                RaiseEvent CurrentRowChanged(TD_ItemBultoActual)
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_BultoPK)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_Filtro
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pCREFFW_CodigoBulto = Filtro.pCREFFW_CodigoBulto
            .pCCMPN_Compania = Filtro.pCCMPN_Compania
            .pCDVSN_Division = Filtro.pCDVSN_Division
            .pCPLNDV_Planta = Filtro.pCPLNDV_Planta
        End With
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


End Class