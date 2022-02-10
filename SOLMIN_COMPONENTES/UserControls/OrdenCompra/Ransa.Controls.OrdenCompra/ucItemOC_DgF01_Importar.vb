Imports Ransa.NEGO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.SubItemOC

Public Class ucItemOC_DgF01_Importar
#Region " Definición Eventos "
    Public Event DataLoadCompleted(ByVal Item As TD_ItemOCPK)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Item As TD_ItemOCPK)
    'Public Event CurrentRowChanged(ByVal OrdenCompra As TD_OrdenCompraPK)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event DeleteHeadOC()
    Public Event Cerrar()
    Public Event GenerarBulto(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal ItemSelec As List(Of TD_ItemOCForWayBill))
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
    Private TD_OrdenCompraActual As TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""
    Private blnCargando As Boolean = False
    Private strUsuario As String = ""

    Private sDefault_Peso As String = ""
    Private sDefault_Volumen As String = ""

    Private iNroChkSelecc As Double = 0
    Private oMItem As ucItemOC_MItem

    'Varibles Temporales
    Private opdtUnidad As DataTable
    Private opdtLugarEntrega As DataTable
    Private bolvalido As Boolean = False

    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "

    Private TD_ItemPK As TD_ItemOCPK

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

    Private __ActivarBotonSalir As Boolean = False

    Public Property ActivarBotonSalir() As Boolean
        Get
            Return __ActivarBotonSalir
        End Get
        Set(ByVal value As Boolean)
            __ActivarBotonSalir = value
            tssSep_02.Visible = value
            btnSalir.Visible = value
        End Set
    End Property


#End Region

#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacionABB()
        Try
            dgItemOC.AutoGenerateColumns = False
            Me.dgItemOC.Columns("ITEMYRC").Visible = False
            Me.dgItemOC.Columns("SUBITEM").Visible = False
            Me.dgItemOC.Columns("ESSUBITEM").Visible = False
            If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
                strMensajeError = ""
                blnCargando = True
                Dim oImportasOC As New TypeDef.OrdenCompra.ImportarOC.ImportarOcYRC

                Dim oDtOCItem As DataTable
                oDtOCItem = TD_OrdenCompraActual.pdtImportacionOCABB
                Dim oDrItem As DataRow
                For Each oDr As DataRow In oDtOCItem.Rows
                    oDrItem = dstItemOC.Tables(0).NewRow
                    oDrItem.Item("CCLNT") = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                    oDrItem.Item("NORCML") = oDr.Item("vc_PurchaseOrder").ToString.Trim
                    If IsNumeric(oDr.Item("vc_PurchaseOrderLine")) Then
                        oDrItem.Item("NRITOC") = oDr.Item("vc_PurchaseOrderLine")
                    End If
                    oDrItem.Item("TDITES") = ("" & oDr.Item("vc_LineDescriptionLine1")).ToString.Trim & ("" & oDr.Item("vc_LineDescriptionLine2")).ToString.Trim
                    If IsNumeric(oDr.Item("fl_QuantityOrdered")) Then
                        oDrItem.Item("QCNTIT") = oDr.Item("fl_QuantityOrdered")
                    End If
                    'Dim oUnidad As cUnidad = New cUnidad
                    Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
                    Dim strResultado = oUnidad.fsBuscarAbreviatura(oDr.Item("vc_unidad_medida"), sDefault_Peso)
                    If Not strResultado.ToString.Trim.Equals("") Then
                        oDrItem.Item("TUNDIT") = strResultado
                    End If
                    oDrItem.Item("TDITIN") = ("" & oDr.Item("vc_LineDescriptionLine2")).ToString.Trim
                    oDrItem.Item("TCITCL") = ("" & oDr.Item("vc_StockCode")).ToString.Trim
                    If Not (oDr.Item("dt_EstimatedDate") Is DBNull.Value) Then
                        oDrItem.Item("FMPDME") = ("" & oDr.Item("dt_EstimatedDate")).ToString.Trim
                    End If
                    oDrItem.Item("TLUGEN") = ("" & oDr.Item("vc_SupplierAddressLine1") & oDr.Item("vc_SupplierAddressLine2") & oDr.Item("vc_SupplierAddressLine3")).ToString.Trim
                    oDrItem.Item("TUNDIT") = ("" & oDr.Item("vc_unidad_medida")).ToString.Trim
                    oDrItem.Item("TCTCST") = ("" & oDr.Item("vc_CentroCosto")).ToString.Trim
                    oDrItem.Item("IVUNIT") = ("" & oDr.Item("fl_UnitPrice")).ToString.Trim
                    oDrItem.Item("IVTOIT") = ("" & oDr.Item("fl_TotalPrice")).ToString.Trim
                    dstItemOC.Tables(0).Rows.Add(oDrItem)
                Next

                dgItemOC.DataSource = dstItemOC
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
            blnCargando = True
        Catch ex As Exception

        End Try

    End Sub

    


    'Private Sub pCargarInformacion()
    '    ' Iniciamos la carga de la información
    '    Dim oListItems As New Hashtable
    '    If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
    '        strMensajeError = ""
    '        blnCargando = True
    '        Dim oImportasOC As New TypeDef.OrdenCompra.ImportarOC.ImportarOcYRC
    '        Dim numEntero As Int64
    '        Dim numDecimal As Int64
    '        Dim oDtOCItem As DataTable
    '        oDtOCItem = oImportasOC.GetItems(TD_OrdenCompraActual.pCCLIENT_CodigoClinteYRC, TD_OrdenCompraActual.pNORCML_NroOrdenCompra)
    '        Dim oDrItem As DataRow
    '        For Each oDr As DataRow In oDtOCItem.Rows
    '            oDrItem = dstItemOC.Tables(0).NewRow
    '            oDrItem.Item("CCLNT") = TD_OrdenCompraActual.pCCLNT_CodigoCliente
    '            oDrItem.Item("NORCML") = oDr.Item(1)
    '            oDrItem.Item("ITEMYRC") = oDr.Item(2)

    '            If IsNumeric(oDr.Item(2)) Then
    '                numEntero = Convert.ToInt64(Math.Truncate(Math.Abs(CType(oDr.Item(2), Decimal))))
    '                numDecimal = CType((CType(oDr.Item(2), Decimal) - numEntero).ToString.Replace(".", ""), Int64)
    '                oDrItem.Item("NRITOC") = numEntero
    '                oDrItem.Item("SUBITEM") = numDecimal
    '                If numDecimal <> 0 Then
    '                    oDrItem.Item("ESSUBITEM") = True
    '                Else
    '                    oDrItem.Item("CHECK1") = True
    '                End If


    '            End If



    '            oDrItem.Item("TDITES") = oDr.Item(7)
    '            oDrItem.Item("QCNTIT") = oDr.Item(3)

    '            'objSqlManager = New SqlManager()
    '            '-- Información Unidad Peso y Volumen
    '            Dim oUnidad As cUnidad = New cUnidad
    '            '-- Peso
    '            Dim strResultado = oUnidad.fsBuscarAbreviatura(oDr.Item(4), sDefault_Peso)
    '            If Not strResultado.ToString.Trim.Equals("") Then
    '                oDrItem.Item("TUNDIT") = strResultado
    '            End If
    '            oDrItem.Item("IVUNIT") = oDr.Item(6)
    '            oDrItem.Item("TLUGEN") = oDr.Item(9)
    '            oDrItem.Item("IVTOIT") = oDrItem.Item("QCNTIT") * oDrItem.Item("IVUNIT")
    '            dstItemOC.Tables(0).Rows.Add(oDrItem)
    '        Next

    '        dgItemOC.DataSource = dstItemOC ' oImportasOC.GetItem(29, "P31062") 'cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError)
    '        iNroChkSelecc = 0
    '        blnCargando = False
    '        If strMensajeError <> "" Then
    '            TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
    '            TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
    '            TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
    '            RaiseEvent ErrorMessage(strMensajeError)
    '        Else
    '            If dgItemOC.RowCount > 0 Then
    '                pCargarImagenSubItems()
    '                TD_ItemOC_Actual.pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
    '                TD_ItemOC_Actual.pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
    '                TD_ItemOC_Actual.pNRITOC_NroItemOC = dgItemOC.CurrentRow.Cells("M_NRITOC").Value
    '                intFilaActual = 0
    '            Else
    '                TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
    '                TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
    '                TD_ItemOC_Actual.pNRITOC_NroItemOC = 0
    '                intFilaActual = -1
    '            End If
    '            RaiseEvent DataLoadCompleted(TD_ItemOC_Actual)
    '        End If
    '    Else
    '        Call pLimpiarContenido()
    '    End If
    '    blnCargando = True
    'End Sub

    Private Function FormatearItemYRC(ByVal s As String) As String
        Dim NumFormat As String = ""
        Dim NumEntero As String = ""
        Dim NumPrimero As String = ""
        Dim NumResto As String = ""
        Dim NumS As String = ""
        Dim NumElem As Int32 = 0
        Dim Array() As Char = s.ToCharArray
        Dim UltimaPos As Int32 = 0
        NumElem = Array.Length - 1
        For index As Integer = 0 To NumElem
            If index <= NumElem AndAlso Char.IsDigit(Array(index)) Then
                NumEntero = NumEntero & Array(index)
                UltimaPos = index + 1
            Else
                UltimaPos = index + 1
                Exit For
            End If
        Next
        For index As Integer = UltimaPos To NumElem
            If index <= NumElem AndAlso Char.IsDigit(Array(index)) Then
                NumPrimero = NumPrimero & Array(index)
                UltimaPos = index + 1
            Else
                UltimaPos = index + 1
                Exit For
            End If
        Next
        For index As Integer = UltimaPos To NumElem
            If index <= NumElem AndAlso Char.IsDigit(Array(index)) Then
                NumResto = NumResto & Array(index)
            End If
        Next
        If NumEntero = "" Then
            NumEntero = "0"
        End If
        If NumPrimero = "" Then
            NumPrimero = "0"
        End If
        If NumResto = "" Then
            NumResto = "0"
        End If
        NumFormat = NumEntero & "-" & NumPrimero & "-" & NumResto
        Return NumFormat
    End Function

    Private Function MaxHabilitado(ByVal oListSubItem As List(Of Int64)) As Int64
        Dim Max As Int64 = 0
        For Each Item As Int64 In oListSubItem
            If Item > Max Then
                Max = Item
            End If
        Next
        Return Max
    End Function

    Private Sub pCargarInformacion()
        dgItemOC.AutoGenerateColumns = False
        ' Iniciamos la carga de la información
        Dim PartItem As Int64 = 0
        Dim PartSubPrimero As Int64 = 0
        Dim PartSubSegundo As Int64 = 0

        Dim NRITOC As String = ""
        Dim SBITOC As String = ""

        Dim oListItems As New Hashtable
        Dim oListSubItems As List(Of Int64)
        Dim NumItemYRC As String = ""
        Dim NumItem() As String
        Dim formado As String = ""
        Dim MaxSubItem As Decimal = 0
        If TD_OrdenCompraActual.pCCLNT_CodigoCliente <> 0 Then
            strMensajeError = ""
            blnCargando = True
            Dim oImportasOC As New TypeDef.OrdenCompra.ImportarOC.ImportarOcYRC
            Dim oDtOCItem As DataTable
            oDtOCItem = oImportasOC.GetItems(TD_OrdenCompraActual.pCCLIENT_CodigoClinteYRC, TD_OrdenCompraActual.pNORCML_NroOrdenCompra)
            Dim oDrItem As DataRow
            For Each oDr As DataRow In oDtOCItem.Rows

                oDrItem = dstItemOC.Tables(0).NewRow
                oDrItem.Item("CCLNT") = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                oDrItem.Item("NORCML") = ("" & oDr.Item(1)).ToString.Trim
                oDrItem.Item("ITEMYRC") = ("" & oDr.Item(2)).ToString.Trim

                'If IsNumeric(oDr.Item(2)) Then
                '    numEntero = Convert.ToInt64(Math.Truncate(Math.Abs(CType(oDr.Item(2), Decimal))))
                '    numDecimal = CType((CType(oDr.Item(2), Decimal) - numEntero).ToString.Replace(".", ""), Int64)
                '    oDrItem.Item("NRITOC") = numEntero
                '    oDrItem.Item("SUBITEM") = numDecimal
                '    If numDecimal <> 0 Then
                '        oDrItem.Item("ESSUBITEM") = True
                '    Else
                '        oDrItem.Item("CHECK1") = True
                '    End If
                'End If

                '**ASIGNACION DE ITEM - SUBITEM***********************************
                NumItemYRC = FormatearItemYRC(("" & oDr.Item(2)).ToString.Trim)
                NumItem = NumItemYRC.Split("-")
                PartItem = NumItem(0)
                PartSubPrimero = NumItem(1)
                PartSubSegundo = NumItem(2)

                If PartItem <> 0 Then
                    If Not oListItems.Contains(PartItem) Then
                        oListSubItems = New List(Of Int64)
                        oListSubItems.Add(0)
                        oListItems.Add(PartItem, oListSubItems)
                        NRITOC = PartItem
                        oDrItem.Item("NRITOC") = NRITOC
                        oDrItem.Item("CHECK1") = True
                    Else
                        oListSubItems = New List(Of Int64)
                        oListSubItems = oListItems(PartItem)
                        oListItems.Remove(PartItem)
                        If PartSubPrimero <> 0 Then
                            If Not oListSubItems.Contains(PartSubPrimero) Then
                                oListSubItems.Add(PartSubPrimero)
                            Else
                                PartSubPrimero = MaxHabilitado(oListSubItems) + 1
                                oListSubItems.Add(PartSubPrimero)
                            End If
                        Else
                            PartSubPrimero = MaxHabilitado(oListSubItems) + 1
                            oListSubItems.Add(PartSubPrimero)
                        End If
                        NRITOC = PartItem
                        SBITOC = PartSubPrimero
                        oListItems.Add(PartItem, oListSubItems)

                        oDrItem.Item("NRITOC") = NRITOC
                        oDrItem.Item("SUBITEM") = SBITOC.Trim
                        oDrItem.Item("ESSUBITEM") = True
                    End If
                End If
                '*************************************************************************

                oDrItem.Item("TDITES") = ("" & oDr.Item(7)).ToString.Trim
                oDrItem.Item("QCNTIT") = oDr.Item(3)

                '-- Información Unidad Peso y Volumen
                'Dim oUnidad As cUnidad = New cUnidad
                Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
                '-- Peso
                Dim strResultado = oUnidad.fsBuscarAbreviatura(oDr.Item(4), sDefault_Peso)
                If Not strResultado.ToString.Trim.Equals("") Then
                    oDrItem.Item("TUNDIT") = strResultado
                End If
                oDrItem.Item("IVUNIT") = oDr.Item(6)
                oDrItem.Item("TLUGEN") = ("" & oDr.Item(9)).ToString.Trim
                oDrItem.Item("IVTOIT") = oDrItem.Item("QCNTIT") * oDrItem.Item("IVUNIT")
                dstItemOC.Tables(0).Rows.Add(oDrItem)
            Next

            dgItemOC.DataSource = dstItemOC ' oImportasOC.GetItem(29, "P31062") 'cItemOrdenCompra.fdtListar_ItemsOC_L01(objSqlManager, TD_OrdenCompraActual, strMensajeError)
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
        blnCargando = True
    End Sub


    Private Sub pCargarImagenSubItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucItemOC_DgF01))
        For Each oDgvrItemOC As DataGridViewRow In dgItemOC.Rows
            If Not oDgvrItemOC.Cells("ESSUBITEM").Value Then oDgvrItemOC.Cells("BTN_SUBITEM").Value = My.Resources.button_ok1 'CType(resources.GetObject("btnSubItem.Image"), System.Drawing.Image)
            'Else
            '    oDgvrItemOC.Cells("BTN_SUBITEM").Value = CType(resources.GetObject("btnSubItem.Image"), System.Drawing.Image)
        Next
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgItemOC.DataSource = Nothing
        blnCargando = False
        ' Limpiamos la Orden de Compra
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = ""
        ' Limpiamos el Item Seleccionado
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = 0
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = ""
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos las opciones de Gestión
        btnGuardar.Enabled = True
        btnSalir.Enabled = True
        RemoveHandler oMItem.pDisposeForm, AddressOf pDisposeFormServF01
        oMItem.Dispose()
        oMItem = Nothing
        If StatusProceso And Not objSqlManager Is Nothing And dgItemOC.RowCount > 0 Then Call pRefrescar()
    End Sub
#End Region

#Region " Eventos "

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar() Then
            Guardar()
        End If
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        RaiseEvent Cerrar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnGenerarBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgItemOC.RowCount > 0 Then
            Dim intCont As Int32 = 0
            Dim lstItemsSelec As List(Of TD_ItemOCForWayBill) = New List(Of TD_ItemOCForWayBill)
            Dim objTemp As TD_ItemOCForWayBill = Nothing
            dgItemOC.CommitEdit(DataGridViewDataErrorContexts.Commit)
            While intCont < dgItemOC.RowCount
                If dgItemOC.Rows(intCont).Cells("M_QCNPEN").Value > 0 Then
                    If dgItemOC.Rows(intCont).Cells("M_CHK").Value Then
                        objTemp = New TD_ItemOCForWayBill
                        objTemp.pNRITOC_NroItemOC = dgItemOC.Rows(intCont).Cells("M_NRITOC").Value
                        objTemp.pQCNREC_QtaRecibida = dgItemOC.Rows(intCont).Cells("M_QCNREC").Value
                        objTemp.pTDAITM_Observaciones = ("" & dgItemOC.Rows(intCont).Cells("M_TDAITM").Value).ToString.Trim
                        objTemp.pQPEPQT_QtaPeso = dgItemOC.Rows(intCont).Cells("M_QPEPQT").Value
                        objTemp.pTUNPSO_UnidadPeso = ("" & dgItemOC.Rows(intCont).Cells("M_TUNPSO").Value).ToString.Trim
                        objTemp.pQVOPQT_QtaVolumen = dgItemOC.Rows(intCont).Cells("M_QVOPQT").Value()
                        objTemp.pTUNVOL_UnidadVolumen = ("" & dgItemOC.Rows(intCont).Cells("M_TUNVOL").Value).ToString.Trim
                        lstItemsSelec.Add(objTemp)
                    End If
                End If
                intCont += 1
            End While
            If lstItemsSelec.Count > 0 Then
                RaiseEvent GenerarBulto(TD_OrdenCompraActual, lstItemsSelec)
            Else
                strMensajeError = "No se ha procesado ningún Item. Validar la Información."
                RaiseEvent ErrorMessage(strMensajeError)
            End If
        End If
    End Sub


    Private Sub ucOrdenCompra_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
        cMemory.ClearMemory()
    End Sub

    Private Sub ucOrdenCompra_DgF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        cMemory.ClearMemory()
    End Sub


    Private Sub pCargarCbxLugarEntrega()
        opdtLugarEntrega = cItemOrdenCompra.fdtListar_LugarEntrega(objSqlManager, TD_OrdenCompraActual.pCCLNT_CodigoCliente, strMensajeError)
    End Sub

    Private Sub dgItemOC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellEndEdit
        ' If blnCargando Then Exit Sub
        With dgItemOC

            Select Case .Columns(e.ColumnIndex).Name
                Case "M_NRITOC"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QCNTIT"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        If .CurrentCell.Value < 0 Then
                            strMensajeError = "El monto debe ser mayor a cero."
                            RaiseEvent ErrorMessage(strMensajeError)
                            .CurrentCell.Value = 0D
                        End If
                    End If
                Case "M_IVUNIT"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_IVTOIT"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMIN"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        strMensajeError = "Debe ingresar una Tolerancia Mín. mayor a cero."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMAX"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        strMensajeError = "Debe ingresar una Tolerancia Máx. mayor a cero."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    End If

                Case "M_TUNDIT"
                    Dim descripcionUnidadMedida As String = ""
                    Dim strMensajeError As String = ""
                    Dim blUnidadMedida As New blUnidadMedida()
                    descripcionUnidadMedida = .CurrentCell.Value.ToString
                    descripcionUnidadMedida = descripcionUnidadMedida.ToUpper()
                    Dim dt As New DataTable()
                    Dim strResultado As String = ""
                    dt = blUnidadMedida.Obtener_Obtener_UnidadMedida_x_Descripcion(descripcionUnidadMedida)
                    If (dt.Rows.Count > 0) Then
                        strResultado = dt.Rows(0).Item("CUNDMD").ToString
                    End If
                    If (strResultado = "" And descripcionUnidadMedida.Length > 3) Then
                        .CurrentCell.Value = descripcionUnidadMedida.Substring(0, 3)
                    End If
                    If Not strResultado.ToString.Trim.Equals("") Then
                        .CurrentCell.Value = strResultado
                    End If

            

            End Select
        End With
    End Sub


    Private Sub dgItemOC_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgItemOC.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            If dgItemOC.CurrentCell.ColumnIndex = 8 Then ' Checking Whether the Editing Control Column Index is 1 or not if 1 Then Enabling Auto Complete Extender
                With DirectCast(e.Control, TextBox)
                    If opdtUnidad.Rows.Count > 0 Then
                        Dim rwTemp As DataRow
                        For Each rwTemp In opdtUnidad.Rows
                            .AutoCompleteCustomSource.Add(("" & rwTemp.Item(0)).ToString.Trim)
                        Next
                    End If
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With

            ElseIf dgItemOC.CurrentCell.ColumnIndex = 16 Then ' Checking Whether the Editing Control Column Index is 1 or not if 1 Then Enabling Auto Complete Extender
                With DirectCast(e.Control, TextBox)
                    If opdtLugarEntrega.Rows.Count > 0 Then
                        Dim rwTemp As DataRow
                        For Each rwTemp In opdtLugarEntrega.Rows
                            .AutoCompleteCustomSource.Add(("" & rwTemp.Item(1)).ToString.Trim)
                        Next
                    End If
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                End With
            Else
                With DirectCast(e.Control, TextBox)
                    .AutoCompleteMode = AutoCompleteMode.None
                End With
            End If

        Else
        End If

    End Sub

    Private Sub dgItemOC_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgItemOC.DataError
        With dgItemOC
            Select Case .Columns(e.ColumnIndex).Name
                Case "M_NRITOC"
                    If .CurrentCell.Value.ToString.Trim = "" OrElse .CurrentCell.Value.ToString.Trim.Equals("0") Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QCNTIT"
                    If .CurrentCell.Value.ToString.Trim = "" OrElse .CurrentCell.Value.ToString.Trim.Equals("0") Then
                        .CurrentCell.Value = 0D
                    Else
                        If .CurrentCell.Value < 0 Then
                            strMensajeError = "El monto debe ser mayor a cero."
                            RaiseEvent ErrorMessage(strMensajeError)
                            .CurrentCell.Value = 0D
                        End If
                    End If
                Case "M_IVUNIT"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_IVTOIT"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMIN"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        strMensajeError = "Debe ingresar una Tolerancia Mín. mayor a cero."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMAX"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
                        strMensajeError = "Debe ingresar una Tolerancia Máx. mayor a cero."
                        RaiseEvent ErrorMessage(strMensajeError)
                        .CurrentCell.Value = 0D
                    End If

                Case "M_TUNDIT"
                    Dim descripcionUnidadMedida As String = ""
                    Dim strMensajeError As String = ""
                    Dim blUnidadMedida As New blUnidadMedida()
                    descripcionUnidadMedida = .CurrentCell.Value.ToString
                    descripcionUnidadMedida = descripcionUnidadMedida.ToUpper()
                    Dim dt As New DataTable()
                    Dim strResultado As String = ""
                    dt = blUnidadMedida.Obtener_Obtener_UnidadMedida_x_Descripcion(descripcionUnidadMedida)
                    If (dt.Rows.Count > 0) Then
                        strResultado = dt.Rows(0).Item("CUNDMD").ToString
                    End If
                    If (strResultado = "" And descripcionUnidadMedida.Length > 3) Then
                        .CurrentCell.Value = descripcionUnidadMedida.Substring(0, 3)
                    End If
                    If Not strResultado.ToString.Trim.Equals("") Then
                        .CurrentCell.Value = strResultado
                    End If
            End Select
            e.Cancel = False
        End With
    End Sub

    Private Sub dgItemOC_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgItemOC.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.dgItemOC.CurrentCell.ColumnIndex = 13 OrElse Me.dgItemOC.CurrentCell.ColumnIndex = 14 Then
                tsmiLimpiar.Visible = True
            Else
                tsmiLimpiar.Visible = False
            End If

        End If
    End Sub

    Private Sub tsmiLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLimpiar.Click
        dgItemOC.CurrentCell.Value = DBNull.Value
    End Sub

    Private Sub dgItemOC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellContentClick
        If Me.dgItemOC.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dgItemOC.EndEdit()
        If Me.dgItemOC.Columns(e.ColumnIndex).Name = "ESSUBITEM" Then
            If Me.dgItemOC.CurrentRow.Cells("ESSUBITEM").Value Then
                If Me.dgItemOC.CurrentRow.Cells("M_NRITOC").Value.ToString.Trim.Equals("") Or Me.dgItemOC.CurrentRow.Cells("M_NRITOC").Value.ToString.Trim.Equals("0") Then
                    Me.dgItemOC.CurrentCell = Me.dgItemOC.CurrentRow.Cells("M_NRITOC")
                Else
                    Me.dgItemOC.CurrentCell = Me.dgItemOC.CurrentRow.Cells("SUBITEM")
                End If
                Me.dgItemOC.CurrentRow.Cells("SUBITEM").ReadOnly = False
                Me.dgItemOC.EditMode = DataGridViewEditMode.EditOnEnter
                Me.dgItemOC.CurrentRow.Cells("CHECK1").Value = False
            Else
                'Me.dgItemOC.CurrentRow.Cells("SUBITEM").Value = 0D
                Me.dgItemOC.CurrentRow.Cells("SUBITEM").Value = ""
            End If

        End If

        If Me.dgItemOC.CurrentRow.Cells("CHECK1").Value IsNot DBNull.Value Then
            If Me.dgItemOC.CurrentRow.Cells("CHECK1").Value Then
                Me.dgItemOC.CurrentRow.Cells("ESSUBITEM").Value = False
            End If
        End If
       




    End Sub

#End Region

#Region " Métodos "
    Public Sub pActualizar(ByVal OrdenCompra As TD_OrdenCompraPK)
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = OrdenCompra.pCCLNT_CodigoCliente
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
        TD_OrdenCompraActual.pCCLIENT_CodigoClinteYRC = OrdenCompra.pCCLIENT_CodigoClinteYRC
        TD_OrdenCompraActual.pbolImportadoOCABB = OrdenCompra.pbolImportadoOCABB
        TD_OrdenCompraActual.pdtImportacionOCABB = OrdenCompra.pdtImportacionOCABB
        ' Llamada al procedimiento de carga de información
        pCargarCbxLugarEntrega()
        CargarUnidad()
        If (TD_OrdenCompraActual.pbolImportadoOCABB = True) Then
            Call pCargarInformacionABB()
        Else
            Call pCargarInformacion()
        End If
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub

    'Private Function Validar() As Double
    '    Dim strMensajeError As String = ""
    '    Dim blnEstado As Boolean = True
    '    Dim intNumRow As Integer = 0
    '    For Each oDr As DataRow In Me.dtItemOC.Rows

    '        ''CHECK
    '        'If oDr.Item("ESSUBITEM") Then

    '        'End If

    '        If oDr.Item("NRITOC").ToString.Equals("") OrElse oDr.Item("NRITOC").ToString.Equals("0") Then
    '            strMensajeError &= "Debe ingresar Nro. de Item Valido." & Convert.ToChar(10) & Convert.ToChar(13)
    '        End If
    '        If oDr.Item("ESSUBITEM") Then
    '            If oDr.Item("SUBITEM").ToString.Equals("") OrElse oDr.Item("SUBITEM").ToString.Equals("0") Then
    '                strMensajeError &= "Debe ingresar Nro. de Sub Item Valido." & Convert.ToChar(10) & Convert.ToChar(13)
    '            End If
    '        End If
    '        'If oDr.Item("TCITCL").ToString.Trim.Equals("") OrElse oDr.Item("TCITCL").ToString.Trim.Equals("0") Then
    '        '    strMensajeError &= "Debe ingresar Nro. de Item Cliente." & Convert.ToChar(10) & Convert.ToChar(13)
    '        'End If
    '        If oDr.Item("TDITES").Equals("") Then
    '            strMensajeError &= "Debe ingresar la descripción del Item." & Convert.ToChar(10) & Convert.ToChar(13)
    '        End If
    '        'If oDr.Item("QCNTIT") <= 0 Then
    '        '    strMensajeError &= "Debe ingresar alguna cantidad mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
    '        'End If
    '        If oDr.Item("QTOLMAX") < 0 Then
    '            strMensajeError &= "Debe ingresar una Tolerancia Máx. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
    '        End If
    '        If oDr.Item("QTOLMIN") < 0 Then
    '            strMensajeError &= "Debe ingresar una Tolerancia Mín. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
    '        End If
    '        If Decimal.Parse(oDr.Item("QTOLMIN")) > Decimal.Parse(oDr.Item("QTOLMAX")) Then
    '            strMensajeError &= "Tolerancia Mín. debe ser menor a la Tolerancia Máx." & Convert.ToChar(10) & Convert.ToChar(13)
    '        End If
    '        'If oDr.Item("TLUGEN").Equals("") Then
    '        '    strMensajeError &= "Debe ingresar el Lugar de Entrega." & Convert.ToChar(10) & Convert.ToChar(13)
    '        'End If
    '        If strMensajeError <> "" Then
    '            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            dgItemOC.Rows(intNumRow).ErrorText = strMensajeError
    '            blnEstado = False
    '            Exit Function
    '        Else
    '            dgItemOC.Rows(intNumRow).ErrorText = ""
    '        End If
    '        intNumRow += 1
    '    Next
    '    Return blnEstado
    'End Function

    Private Function Validar() As Double
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True
        Dim intNumRow As Integer = 0
        For Each oDr As DataRow In Me.dtItemOC.Rows
            ''CHECK
            If oDr.Item("CHECK") IsNot DBNull.Value Then
                If oDr.Item("CHECK") Then

                    If oDr.Item("NRITOC").ToString.Equals("") OrElse oDr.Item("NRITOC").ToString.Equals("0") Then
                        strMensajeError &= "Debe ingresar Nro. de Item Válido." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If oDr.Item("ESSUBITEM") Then
                        If oDr.Item("SUBITEM").ToString.Equals("") OrElse oDr.Item("SUBITEM").ToString.Equals("0") Then
                            strMensajeError &= "Debe ingresar Nro. de Sub Item Válido." & Convert.ToChar(10) & Convert.ToChar(13)
                        End If
                    End If
                    'If oDr.Item("TCITCL").ToString.Trim.Equals("") OrElse oDr.Item("TCITCL").ToString.Trim.Equals("0") Then
                    '    strMensajeError &= "Debe ingresar Nro. de Item Cliente." & Convert.ToChar(10) & Convert.ToChar(13)
                    'End If
                    If oDr.Item("TDITES").Equals("") Then
                        strMensajeError &= "Debe ingresar la descripción del Item." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    'If oDr.Item("QCNTIT") <= 0 Then
                    '    strMensajeError &= "Debe ingresar alguna cantidad mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
                    'End If
                    If oDr.Item("QTOLMAX") < 0 Then
                        strMensajeError &= "Debe ingresar una Tolerancia Máx. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If oDr.Item("QTOLMIN") < 0 Then
                        strMensajeError &= "Debe ingresar una Tolerancia Mín. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If Decimal.Parse(oDr.Item("QTOLMIN")) > Decimal.Parse(oDr.Item("QTOLMAX")) Then
                        strMensajeError &= "Tolerancia Mín. debe ser menor a la Tolerancia Máx." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    'If oDr.Item("TLUGEN").Equals("") Then
                    '    strMensajeError &= "Debe ingresar el Lugar de Entrega." & Convert.ToChar(10) & Convert.ToChar(13)
                    'End If
                    If strMensajeError <> "" Then
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dgItemOC.Rows(intNumRow).ErrorText = strMensajeError
                        blnEstado = False
                        Exit Function
                    Else
                        dgItemOC.Rows(intNumRow).ErrorText = ""
                    End If
                    intNumRow += 1

                End If


            End If
          
        Next
        Return blnEstado
    End Function

    Private Sub Guardar()
        Dim TD_Item As TD_ItemOC = New TD_ItemOC
        'Dim ErrorCadena As String = ""
        ' ErrorCadena = ValidarCaracter.validaCaracter("t", ErrorCadena)
        For Each oDr As DataRow In Me.dtItemOC.Rows
            If oDr.Item("CHECK") IsNot DBNull.Value Then
                If oDr.Item("CHECK") Then
                    If Not oDr.Item("ESSUBITEM") Then
                        'Insertamos Item
                        TD_Item = New TD_ItemOC
                        With TD_Item
                            .pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                            .pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                            Int32.TryParse(oDr.Item("NRITOC"), .pNRITOC_NroItemOC)
                            .pTCITCL_CodigoCliente = ("" & oDr.Item("TCITCL")).ToString.Trim
                            .pTCITPR_CodigoProveedor = oDr.Item("TCITPR")
                            .pTDITES_DescripcionES = oDr.Item("TDITES")
                            .pTDITIN_DescripcionIN = oDr.Item("TDITIN")
                            Decimal.TryParse(oDr.Item("QCNTIT"), .pQCNTIT_Cantidad)
                            .pTUNDIT_Unidad = oDr.Item("TUNDIT")
                            Decimal.TryParse(oDr.Item("IVUNIT"), .pIVUNIT_ImporteUnitario)
                            Decimal.TryParse(oDr.Item("IVTOIT"), .pIVTOIT_ImporteTotal)
                            Decimal.TryParse(oDr.Item("QTOLMAX"), .pQTOLMAX_ToleranciaMax)
                            Decimal.TryParse(oDr.Item("QTOLMIN"), .pQTOLMIN_ToleranciaMin)
                            If Not oDr.Item("FMPDME") Is DBNull.Value Then .pFMPDME_FechaEstEntregaDte = oDr.Item("FMPDME")
                            If Not oDr.Item("FMPIME") Is DBNull.Value Then .pFMPIME_FechaReqPlantaDte = oDr.Item("FMPIME")
                            .pTLUGOR_LugarOrigen = oDr.Item("TLUGOR")
                            .pTLUGEN_LugarEntrega = ("" & oDr.Item("TLUGEN")).ToString.Trim
                            .pTCTCST_CentroDeCosto = ("" & oDr.Item("TCTCST")).ToString.Trim
                        End With
                        ' Limpio los controles de entrada de información
                        If Not cItemOrdenCompra.Grabar(objSqlManager, TD_Item, strUsuario, strMensajeError) Then
                            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else
                        'Insertamos sub Items
                        Dim TD_subItem As TD_SubItemOC = New TD_SubItemOC
                        With TD_subItem
                            .pCCLNT_CodigoCliente = TD_OrdenCompraActual.pCCLNT_CodigoCliente
                            .pNORCML_NroOrdenCompra = TD_OrdenCompraActual.pNORCML_NroOrdenCompra
                            Int32.TryParse(oDr.Item("NRITOC"), .pNRITOC_NroItemOC)
                            .pSBITOC_NroSubItemOC = oDr.Item("SUBITEM")
                            .pTCITCL_CodigoCliente = ("" & oDr.Item("TCITCL")).ToString.Trim
                            .pTCITPR_CodigoProveedor = oDr.Item("TCITPR")
                            .pTDITES_DescripcionES = oDr.Item("TDITES")
                            Decimal.TryParse(oDr.Item("QCNTIT"), .pQCNTIT_Cantidad)
                            .pTUNDIT_Unidad = oDr.Item("TUNDIT")
                            Decimal.TryParse(oDr.Item("IVUNIT"), .pIVUNIT_ImporteUnitario)
                            Decimal.TryParse(oDr.Item("IVTOIT"), .pIVTOIT_ImporteTotal)
                        End With
                        ' Limpio los controles de entrada de información
                        If Not CSubItemOrdenCompra.Grabar(objSqlManager, TD_subItem, strUsuario, strMensajeError) Then
                            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                End If
            End If          
        Next
        MessageBox.Show("Se guardó de manera satisfactoria", "Lista de Items Importados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RaiseEvent Cerrar()
    End Sub

    Private Sub CargarUnidad()
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        opdtUnidad = oUnidad.fdtListar("", sDefault_Peso)
    End Sub

#End Region

    
    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Dim img As Image = btnMarcarItems.Image
        btnMarcarItems.Image = btnMarcarItems.BackgroundImage
        btnMarcarItems.BackgroundImage = img
        MarcarTodos()
    End Sub

    Private Sub MarcarTodos()
        For i As Integer = 0 To Me.dtItemOC.Rows.Count - 1
            dtItemOC.Rows(i).Item("CHECK") = btnMarcarItems.Checked
        Next
    End Sub
End Class