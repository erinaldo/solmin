Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.SubItemOC
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Public Class ucSubItemOcEnAlmacen_DgF01

#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Item As TD_ItemOCPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Item As TD_ItemOCPK)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event DeleteHeadOC()
    Public Event DialogResult()

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
    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
    Private TD_SubItemOC_Actual As TD_SubItemOCPK = New Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOCPK
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""

    Private strCompania As String = ""
    Private strDivision As String = ""
    Private dblPlanta As Double = 0

    Private sDefault_Peso As String = ""
    Private sDefault_Volumen As String = ""

    Private iNroChkSelecc As Int32 = 0
    Private oMSubItemOC As ucSubItemOC_MItem
    Public objListTempSubItem As New List(Of TD_SubItemOC)
    Public ohasSubItems As New Hashtable()
    Public oHashItemVisitado As New Hashtable()
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------


#End Region
#Region " Propiedades "

    <Browsable(True)> _
    Public Property Agregar() As Boolean
        Get
            Return Me.btnAgregar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnAgregar.Visible = value
        End Set
    End Property

    <Browsable(True)> _
    Public Property Eliminar() As Boolean
        Get
            Return Me.btnEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btnEliminar.Visible = value
            tssSep_03.Visible = value
        End Set
    End Property


    Public ReadOnly Property pItemSeleccionada() As TD_SubItemOCPK
        Get
            Return TD_SubItemOC_Actual
        End Get
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Private _pHabilitarBulto As Boolean
    Private _pNRITOC As Int32

#End Region
#Region " Funciones y Procedimientos "

    Private Sub pCargarInformacion()
        ' Iniciamos la carga de la información
        If TD_ItemOC_Actual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            dgSubItemOC.DataSource = CSubItemOrdenCompra.fdtListar_Bulto_SubItemsOC_L01(objSqlManager, TD_ItemOC_Actual, strMensajeError)
            iNroChkSelecc = 0
            blnCargando = False
            If strMensajeError <> "" Then
                TD_SubItemOC_Actual.pCCLNT_CodigoCliente = 0
                TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = ""
                TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0
                RaiseEvent ErrorMessage(strMensajeError)
            Else
                RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgSubItemOC.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
        ' Limpiamos el Item Seleccionado
        TD_SubItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = ""
        RaiseEvent TableWithOutData()
    End Sub


    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos las opciones de Gestión
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        RemoveHandler oMSubItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        oMSubItemOC.Dispose()
        oMSubItemOC = Nothing
        If StatusProceso And Not objSqlManager Is Nothing Then Call pRefrescar()
    End Sub
#End Region
#Region " Eventos "

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
        Dim olbeSubItemOC As New List(Of Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC)
        With Item
            .pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = TD_ItemOC_Actual.pNORCML_NroOrdenCompra
            .pNRITOC_NroItemOC = TD_ItemOC_Actual.pNRITOC_NroItemOC
        End With
        Dim frmListaSubItem As New ucListaSubItemOC_DgF01(Item)
        frmListaSubItem.oHasSubItems = ohasSubItems
        frmListaSubItem.pHabilitarBulto = True
        If frmListaSubItem.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ohasSubItems = frmListaSubItem.oHasSubItems
            If Not ohasSubItems(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString.Trim) Is Nothing Then
                For Each obeTD_SubItemOC As Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In ohasSubItems(TD_ItemOC_Actual.pNRITOC_NroItemOC.ToString.Trim)
                    obeTD_SubItemOC.pCCLNT_CodigoCliente = TD_ItemOC_Actual.pCCLNT_CodigoCliente
                    obeTD_SubItemOC.pCCMPN_Compania = TD_ItemOC_Actual.pCCMPN_Compania
                    obeTD_SubItemOC.pCDVSN_Division = TD_ItemOC_Actual.pCDVSN_Division
                    obeTD_SubItemOC.pCPLNDV_Planta = TD_ItemOC_Actual.pCPLNDV_Planta
                    obeTD_SubItemOC.pCIDPAQ_CodIndentificacionPaquete = TD_ItemOC_Actual.pCIDPAQ_CodIndentificacionPaquete

                    obeTD_SubItemOC.pCREFFW_FrdForw = TD_ItemOC_Actual.pCREFFW_FrdForw

                    olbeSubItemOC.Add(obeTD_SubItemOC)
                Next
            End If

            Dim strError As String = ""
            For Each obeTD_SubItemOC As Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In olbeSubItemOC
                CSubItemOrdenCompra.Generar_Bultos_SubItems_OC(Nothing, obeTD_SubItemOC, strError, strUsuario)
            Next
            pCargarInformacion()
            ohasSubItems = New Hashtable()
            RaiseEvent ErrorMessage(strError)
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If TD_SubItemOC_Actual.pNRITOC_NroItemOC = 0 Then Exit Sub

        Dim blnCancelar As Boolean = False
        RaiseEvent Confirm("¿Desea eliminar el registro actual?", blnCancelar)
        If blnCancelar Then Exit Sub

        Dim strStatusUltReg As String = "N"
        Dim strMensaje As String = ""
        Dim strMensajeError As String = ""
        If CSubItemOrdenCompra.Eliminar_Bultos_SubItems_OC(objSqlManager, TD_SubItemOC_Actual, strMensajeError, strUsuario) Then
            If strStatusUltReg = "S" Then
                strMensaje = "NOTA : Se eliminó la O/C por no poseer Items Activos."
                RaiseEvent DeleteHeadOC()
            Else
                dgSubItemOC.Rows.Remove(dgSubItemOC.CurrentRow)
            End If
            RaiseEvent Message("Proceso culminó satisfactoriamente." & vbNewLine & vbNewLine & strMensaje)
        Else
            RaiseEvent ErrorMessage(strMensajeError)
        End If

        'CSubItemOrdenCompra.Eliminar_Bultos_SubItems_OC(Nothing, obeTD_SubItemOC, strError, strUsuario)
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
        ' Limpiamos la Memoria
        cMemory.ClearMemory()
    End Sub

#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Items As TD_ItemOCPK)
        TD_ItemOC_Actual.pCCMPN_Compania = Items.pCCMPN_Compania
        TD_ItemOC_Actual.pCDVSN_Division = Items.pCDVSN_Division
        TD_ItemOC_Actual.pCPLNDV_Planta = Items.pCPLNDV_Planta

        TD_ItemOC_Actual.pCCLNT_CodigoCliente = Items.pCCLNT_CodigoCliente
        TD_ItemOC_Actual.pCREFFW_FrdForw = Items.pCREFFW_FrdForw
        TD_ItemOC_Actual.pCIDPAQ_CodIndentificacionPaquete = Items.pCIDPAQ_CodIndentificacionPaquete
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = Items.pNORCML_NroOrdenCompra
        TD_ItemOC_Actual.pNRITOC_NroItemOC = Items.pNRITOC_NroItemOC

        TD_SubItemOC_Actual.pCCLNT_CodigoCliente = Items.pCCLNT_CodigoCliente
        TD_SubItemOC_Actual.pCCMPN_Compania = Items.pCCMPN_Compania
        TD_SubItemOC_Actual.pCDVSN_Division = Items.pCDVSN_Division
        TD_SubItemOC_Actual.pCPLNDV_Planta = Items.pCPLNDV_Planta
        TD_SubItemOC_Actual.pCREFFW_FrdForw = Items.pCREFFW_FrdForw
        TD_SubItemOC_Actual.pNORCML_NroOrdenCompra = Items.pNORCML_NroOrdenCompra
        TD_SubItemOC_Actual.pNRITOC_NroItemOC = Items.pNRITOC_NroItemOC
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

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        RaiseEvent DialogResult()
    End Sub

    Private Sub dgSubItemOC_CellStateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles dgSubItemOC.CellStateChanged
        TD_SubItemOC_Actual.pCCMPN_Compania = TD_ItemOC_Actual.pCCMPN_Compania
        TD_SubItemOC_Actual.pCDVSN_Division = TD_ItemOC_Actual.pCDVSN_Division
        TD_SubItemOC_Actual.pCPLNDV_Planta = TD_ItemOC_Actual.pCPLNDV_Planta
        TD_SubItemOC_Actual.pCIDPAQ_CodIndentificacionPaquete = Me.dgSubItemOC.CurrentRow.Cells("CIDPAQ").Value
        TD_SubItemOC_Actual.pSBITOC_NroSubItemOC = Me.dgSubItemOC.CurrentRow.Cells("M_SBITOC").Value
        TD_SubItemOC_Actual.pQCNREC_QtaRecibida = Me.dgSubItemOC.CurrentRow.Cells("QCNRCP").Value
    End Sub
End Class