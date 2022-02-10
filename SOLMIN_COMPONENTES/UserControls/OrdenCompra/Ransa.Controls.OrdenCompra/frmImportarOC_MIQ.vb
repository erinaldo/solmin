Imports Ransa.NEGO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.DAO.Unidad
Imports Ransa.TypeDef
Imports Ransa.TypeDef.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.SubItemOC

Public Class frmImportarOC_MIQ
    Private _pCCCLNT_YRC As Decimal = 0
    Private _pCCCLNT As Decimal = 0
    Private _pNORCML As String = ""
    Private _pUSER As String = ""
    Private _pFECHAOC As String = ""
    Private _pAREA_SOLICITANTE As String = ""
    Private _pINCOTERM As String = ""
    Private _pPRIORIDAD As String = ""
    Private _pMONEDA As String = ""

    Private opdtUnidad As DataTable
    Private opdtLugarEntrega As DataTable

    Public Property pCCCLNT() As Decimal
        Get
            Return _pCCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCCLNT = value
        End Set
    End Property

    Public Property pCCCLNT_YRC() As Decimal
        Get
            Return _pCCCLNT_YRC
        End Get
        Set(ByVal value As Decimal)
            _pCCCLNT_YRC = value
        End Set
    End Property

    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property

    Public Property pUSER() As String
        Get
            Return _pUSER
        End Get
        Set(ByVal value As String)
            _pUSER = value
        End Set
    End Property

    Public Property pFECHAOC() As String
        Get
            Return _pFECHAOC
        End Get
        Set(ByVal value As String)
            _pFECHAOC = value
        End Set
    End Property

    Public Property pAREA_SOLICITANTE() As String
        Get
            Return _pAREA_SOLICITANTE
        End Get
        Set(ByVal value As String)
            _pAREA_SOLICITANTE = value
        End Set
    End Property

    Public Property pINCOTERM() As String
        Get
            Return _pINCOTERM
        End Get
        Set(ByVal value As String)
            _pINCOTERM = value
        End Set
    End Property
    Public Property pPRIORIDAD() As String
        Get
            Return _pPRIORIDAD
        End Get
        Set(ByVal value As String)
            _pPRIORIDAD = value
        End Set
    End Property
    Public Property pMONEDA() As String
        Get
            Return _pMONEDA
        End Get
        Set(ByVal value As String)
            _pMONEDA = value
        End Set
    End Property

    Private sDefault_Peso As String = ""
    Private Sub frmImportarOCLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbMedioEmbarqueN.pCargarDatos("CMEDTR", "::Seleccione::")
            cmbPrioridadN.pCargarDatos("NTPDES", "::Seleccione::")
            cmbTermIternN.pCargarDatos("TERINT", "::Seleccione::")
            cmbMonedaN.pCargarDatos()

            txtOrdenCompra.ReadOnly = True
            dgItemOC.AutoGenerateColumns = False
            DatoCabecera()
            ImportarDesdeMIQDetalleItem()
            pCargarCbxLugarEntrega()
            CargarUnidad()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub pCargarCbxLugarEntrega()
        Dim objSqlManager As New SqlManager
        Dim strMensajeError As String = ""
        opdtLugarEntrega = cItemOrdenCompra.fdtListar_LugarEntrega(objSqlManager, _pCCCLNT, strMensajeError)
    End Sub

    Private Sub DatoCabecera()
        txtOrdenCompra.Text = _pNORCML
        txtFechaOrdenCompra.Value = _pFECHAOC
        txtAreaSolicitante.Text = _pAREA_SOLICITANTE
        cmbTermIternN.pCargarPorCodigo = _pINCOTERM
        Select Case _pPRIORIDAD
            Case 0
                cmbPrioridadN.pCargarPorCodigo = 1
            Case 1
                cmbPrioridadN.pCargarPorCodigo = 3
            Case 2
                cmbPrioridadN.pCargarPorCodigo = 4
        End Select
        cmbMonedaN.pCargarPorAbreviatura = pMONEDA

      

        Dim objSqlManager As New SqlManager
        Dim objOCPK As New TD_OrdenCompraPK
        Dim strMensajeError As String = ""
        objOCPK.pCCLNT_CodigoCliente = _pCCCLNT
        objOCPK.pNORCML_NroOrdenCompra = _pNORCML
        Dim objOC As TD_OrdenCompra = cOrdenCompra.Obtener(objSqlManager, objOCPK, strMensajeError)
        If strMensajeError <> "" Then
            Throw New Exception(strMensajeError)
        Else
            If objOC.pNORCML_NroOrdenCompra <> "" Then
                With objOC
                    txtFechaOrdenCompra.Value = .pFORCML_FechaOCDte
                    If .pFSOLIC_FechaSolicOCInt > 0 Then
                        txtFechaSolicitud.Checked = True
                        txtFechaSolicitud.Value = .pFSOLIC_FechaSolicOCDte
                    Else
                        txtFechaSolicitud.Checked = False
                    End If
                    txtDescripcion.Text = .pTDSCML_Descripcion
                    txtProveedor.pCodigo = .pCPRVCL_CodigoClienteTercero

                    If txtAreaSolicitante.Text.Trim.Length = 0 Then
                        txtAreaSolicitante.Text = .pTCMAEM_DescAreaEmpresa
                    End If
                    If cmbTermIternN.pInformacionSelec.pCCMPRN_Codigo = "" Then
                        cmbTermIternN.pCargarPorCodigo = .pTTINTC_TerminoIntern
                    End If
                    If cmbMonedaN.pInformacionSelec.pCMNDA1_Codigo = "" Then
                        cmbMonedaN.pCargarPorCodigo = .pCMNDA1_Moneda
                    End If
                    If cmbPrioridadN.pInformacionSelec.pCCMPRN_Codigo = "" Then
                        cmbPrioridadN.pCargarPorCodigo = .pNTPDES_Prioridad
                    End If
                    txtReferencia.Text = .pNREFCL_ReferenciaCliente
                    txtTerminoPago.Text = .pTPAGME_TerminoPago
                    txtRefDocumento.Text = .pREFDO1_ReferenciaDocumento
                    txtEmpresaFacturar.Text = .pTEMPFAC_EmpresaFacturar
                    txtComprador.Text = .pTNOMCOM_NombreComprador
                    txtCentroCosto.Text = .pTCTCST_CentroCosto
                    txtRegionEmbarque.Text = .pCREGEMB_RegEmbarque
                    cmbMedioEmbarqueN.pCargarPorCodigo = .pCMEDTR_MedioTransporte
                    txtDestinoFinal.Text = .pTDEFIN_DestinoFinal
                    txtObservaciones.Text = .pTDAITM_Observaciones
                    txtCostoTotal.Text = .pIVCOTO_ImporteCostoTotal
                    txtTotalImpuesto.Text = .pIVTOIM_ImporteTotalImpuesto
                    txtTotalCompra.Text = .pIVTOCO_ImporteTotalCompra
                    Me.txtTipoOC.Text = .pTPOOCM_TipoOC
                    txtCondPago.Text = .pTCNDPG_CondicionPago
                End With
                'txtFechaOrdenCompra.Value = _pFECHAOC
                'txtAreaSolicitante.Text = _pAREA_SOLICITANTE
                'cmbTermItern.pCargarPorCodigo = _pINCOTERM
                'Select Case _pPRIORIDAD
                '    Case 0
                '        cmbPrioridad.pCargarPorCodigo = 1
                '    Case 1
                '        cmbPrioridad.pCargarPorCodigo = 3
                '    Case 2
                '        cmbPrioridad.pCargarPorCodigo = 4
                'End Select
                'cmbMoneda.pCargarPorAbreviatura = pMONEDA
                'blnExiste = True
                'Else
                'Call pClear()
                'TD_OCPK.pNORCML_NroOrdenCompra = ""
            End If
        End If
        'Return blnExiste
    End Sub

    Private Sub ImportarDesdeMIQDetalleItem()

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

        If _pCCCLNT <> 0 Then

            Dim oImportasOC As New TypeDef.OrdenCompra.ImportarOC.ImportarOcYRC
            Dim oDtOCItem As DataTable

            oDtOCItem = oImportasOC.GetItems(_pCCCLNT_YRC, _pNORCML)
            Dim oDrItem As DataRow
            For Each oDr As DataRow In oDtOCItem.Rows

                oDrItem = dstItemOC.Tables(0).NewRow
                oDrItem.Item("CCLNT") = _pCCCLNT
                oDrItem.Item("NORCML") = ("" & oDr.Item(1)).ToString.Trim
                oDrItem.Item("ITEMYRC") = ("" & oDr.Item(2)).ToString.Trim
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

            dgItemOC.DataSource = dstItemOC
        End If
    End Sub

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



    Private Function Validar() As Double
        Dim strMensajeError As String = ""
        Dim blnEstado As Boolean = True
        Dim intNumRow As Integer = 0
        Dim ErrorVal As String = ""

        For Each oDr As DataRow In Me.dtItemOC.Rows
            If oDr.Item("CHECK") IsNot DBNull.Value Then
                If oDr.Item("CHECK") Then
                    '  Dim oOCUtil As New OCUtil
                    'ValidarCaracter.validaCaracter("" & obj_Worksheet.Cells(i + 1, 8).Value & "", obeOrdenCompra.PSERROR) 'DOC_DESCRIPCIONITEM'
                    If oDr.Item("NRITOC").ToString.Equals("") OrElse oDr.Item("NRITOC").ToString.Equals("0") Then
                        strMensajeError &= "Debe ingresar Nro. de Item Válido." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If oDr.Item("ESSUBITEM") Then
                        If oDr.Item("SUBITEM").ToString.Equals("") OrElse oDr.Item("SUBITEM").ToString.Equals("0") Then
                            strMensajeError &= "Debe ingresar Nro. de Sub Item Válido." & Convert.ToChar(10) & Convert.ToChar(13)
                        End If
                    End If
                    ' ErrorCadena = ValidarCaracter.validaCaracter(
                    If oDr.Item("TDITES").Equals("") Then
                        strMensajeError &= "Debe ingresar la descripción del Item." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If oDr.Item("QTOLMAX") < 0 Then
                        strMensajeError &= "Debe ingresar una Tolerancia Máx. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If oDr.Item("QTOLMIN") < 0 Then
                        strMensajeError &= "Debe ingresar una Tolerancia Mín. mayor a cero." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
                    If Decimal.Parse(oDr.Item("QTOLMIN")) > Decimal.Parse(oDr.Item("QTOLMAX")) Then
                        strMensajeError &= "Tolerancia Mín. debe ser menor a la Tolerancia Máx." & Convert.ToChar(10) & Convert.ToChar(13)
                    End If
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

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtProveedor.pCodigo = 0 Then strMensajeError &= "Falta : Proveedor..." & vbNewLine
        If txtDescripcion.Text.Trim = "" Then strMensajeError &= "Falta : Detalle de la Orden de Compra..." & vbNewLine
        If cmbTermIternN.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Termino Internacional." & vbNewLine
        If cmbMonedaN.pInformacionSelec.pCMNDA1_Codigo = "" Then strMensajeError &= "Falta : Moneda." & vbNewLine
        If cmbMedioEmbarqueN.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Medio de Transporte." & vbNewLine
        If cmbPrioridadN.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Prioridad." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub GuardarCebecera()
        If Not fblnValidar() Then Exit Sub
        Dim objOCTemp As beOrdenCompra = New beOrdenCompra
        With objOCTemp
            .PNCCLNT = _pCCCLNT
            .PSNORCML = _pNORCML
            .PSTPOOCM = Me.txtTipoOC.Text
            .FechaOrdenDeCompra = txtFechaOrdenCompra.Value
            If txtFechaSolicitud.Checked Then .FechaSolicitud = txtFechaSolicitud.Value
            .PNCPRVCL = txtProveedor.pCodigo
            .PSTDSCML = txtDescripcion.Text.Trim
            .PSTCMAEM = txtAreaSolicitante.Text.Trim
            .PSTTINTC = cmbTermIternN.pInformacionSelec.pCCMPRN_Codigo
            .PSNREFCL = txtReferencia.Text
            .PSTPAGME = txtTerminoPago.Text
            .PSREFDO1 = txtRefDocumento.Text
            .PNNTPDES = cmbPrioridadN.pInformacionSelec.pCCMPRN_Codigo
            .PNCMNDA1 = cmbMonedaN.pInformacionSelec.pCMNDA1_Codigo
            .PSTEMPFAC = txtEmpresaFacturar.Text.Trim
            .PSTNOMCOM = txtComprador.Text.Trim
            .PSTCTCST = txtCentroCosto.Text.Trim
            .PSCREGEMB = txtRegionEmbarque.Text.Trim
            .PNCMEDTR = cmbMedioEmbarqueN.pInformacionSelec.pCCMPRN_Codigo
            .PSTDEFIN = txtDestinoFinal.Text.Trim
            Decimal.TryParse(txtCostoTotal.Text, .PNIVCOTO)
            Decimal.TryParse(txtTotalCompra.Text, .PNIVTOCO)
            Decimal.TryParse(txtTotalImpuesto.Text, .PNIVTOIM)
            .PSTDAITM = txtObservaciones.Text.Trim
            .PSTCNDPG = txtCondPago.Text.Trim
        End With
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        If obrOrdenDeCompra.InsertarOrdenDeCompra(objOCTemp) Then
        Else
            Throw New Exception("Error al guardar la Orden de Compra.")
        End If

        GuardarDetalle()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            GuardarCebecera()        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarDetalle()
        Dim objSqlManager As New SqlManager
        Dim strMensajeError As String = ""
        Dim TDITES As String = ""
        Dim TDITIN As String = ""
        Const MaxLenTDITES As Int32 = 100
        Const MaxLenTDITIN As Int32 = 100
        Dim oHelpOC As New HelpOC
        Dim msError As String = ""
        If Validar() Then
            Dim TD_Item As TD_ItemOC = New TD_ItemOC
            ' ErrorCadena = ValidarCaracter.validaCaracter("t", ErrorCadena)
            'ValidarCaracter.validaCaracter("" & obj_Worksheet.Cells(i + 1, 8).Value & "", obeOrdenCompra.PSERROR) 'DOC_DESCRIPCIONITEM'
            For Each oDr As DataRow In Me.dtItemOC.Rows
                If oDr.Item("CHECK") IsNot DBNull.Value Then
                    If oDr.Item("CHECK") Then
                        If Not oDr.Item("ESSUBITEM") Then
                            'Insertamos Item
                            TD_Item = New TD_ItemOC
                            With TD_Item
                                .pCCLNT_CodigoCliente = _pCCCLNT
                                .pNORCML_NroOrdenCompra = _pNORCML
                                Int32.TryParse(oDr.Item("NRITOC"), .pNRITOC_NroItemOC)                                
                                .pTCITCL_CodigoCliente = ("" & oDr.Item("TCITCL")).ToString.Trim
                                .pTCITPR_CodigoProveedor = oDr.Item("TCITPR")
                                TDITES = ("" & oDr.Item("TDITES")).ToString.Trim
                                TDITES = oHelpOC.validaCaracter(TDITES, msError)
                                If TDITES.Length > MaxLenTDITES Then
                                    TDITES = TDITES.Substring(0, MaxLenTDITES)
                                End If
                                'TDITES = "CONEXIÓN EN T  RECTA, 1/2"
                                .pTDITES_DescripcionES = TDITES.Trim
                                TDITIN = ("" & oDr.Item("TDITIN")).ToString.Trim
                                TDITIN = oHelpOC.validaCaracter(TDITIN, msError)
                                If TDITIN.Length > MaxLenTDITIN Then
                                    TDITIN = TDITIN.Substring(0, MaxLenTDITIN)
                                End If
                                .pTDITIN_DescripcionIN = TDITIN.Trim
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
                            If Not cItemOrdenCompra.Grabar(objSqlManager, TD_Item, _pUSER, strMensajeError) Then
                                strMensajeError = strMensajeError & Chr(13)
                                strMensajeError = strMensajeError & "ITEM YRC:" & oDr("ITEMYRC") & Chr(13)
                                strMensajeError = strMensajeError & "NUMERO ITEM:" & oDr("NRITOC") & Chr(13)
                                strMensajeError = strMensajeError & "SUB ITEM:" & oDr("SUBITEM") & Chr(13)
                                Throw New Exception(strMensajeError)
                                Exit Sub
                            End If
                        Else
                            'Insertamos sub Items
                            Dim TD_subItem As TD_SubItemOC = New TD_SubItemOC
                            With TD_subItem
                                .pCCLNT_CodigoCliente = _pCCCLNT
                                .pNORCML_NroOrdenCompra = _pNORCML
                                Int32.TryParse(oDr.Item("NRITOC"), .pNRITOC_NroItemOC)
                                .pSBITOC_NroSubItemOC = oDr.Item("SUBITEM")
                                .pTCITCL_CodigoCliente = ("" & oDr.Item("TCITCL")).ToString.Trim
                                .pTCITPR_CodigoProveedor = oDr.Item("TCITPR")
                                TDITES = ("" & oDr.Item("TDITES")).ToString.Trim
                                TDITES = oHelpOC.validaCaracter(TDITES, msError)
                                If TDITES.Length > MaxLenTDITES Then
                                    TDITES = TDITES.Substring(0, MaxLenTDITES).Trim
                                End If
                                .pTDITES_DescripcionES = TDITES.Trim
                                Decimal.TryParse(oDr.Item("QCNTIT"), .pQCNTIT_Cantidad)
                                .pTUNDIT_Unidad = oDr.Item("TUNDIT")
                                Decimal.TryParse(oDr.Item("IVUNIT"), .pIVUNIT_ImporteUnitario)
                                Decimal.TryParse(oDr.Item("IVTOIT"), .pIVTOIT_ImporteTotal)
                            End With
                            ' Limpio los controles de entrada de información
                            If Not CSubItemOrdenCompra.Grabar(objSqlManager, TD_subItem, _pUSER, strMensajeError) Then
                                strMensajeError = strMensajeError & Chr(13)
                                strMensajeError = strMensajeError & "ITEM YRC:" & oDr("ITEMYRC") & Chr(13)
                                strMensajeError = strMensajeError & "NUMERO ITEM:" & oDr("NRITOC") & Chr(13)
                                strMensajeError = strMensajeError & "SUB ITEM:" & oDr("SUBITEM") & Chr(13)
                                Throw New Exception(strMensajeError)
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MessageBox.Show("Se guardó de manera satisfactoria", "Lista de Items Importados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
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
    Private Sub dgItemOC_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemOC.CellEndEdit
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
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMAX"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
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
                        .CurrentCell.Value = 0D
                    End If
                Case "M_QTOLMAX"
                    If .CurrentCell.Value.ToString.Trim = "" Then
                        .CurrentCell.Value = 0D
                    Else
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


    Private Sub dgItemOC_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgItemOC.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            Dim IndexColumna As Int32 = dgItemOC.CurrentCell.ColumnIndex
            Dim NameColumna As String = dgItemOC.Columns(IndexColumna).Name

            If NameColumna = "M_TUNDIT" Then ' Checking Whether the Editing Control Column Index is 1 or not if 1 Then Enabling Auto Complete Extender
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

            ElseIf NameColumna = "M_TLUGEN" Then ' Checking Whether the Editing Control Column Index is 1 or not if 1 Then Enabling Auto Complete Extender
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
  
    Private Sub txtCostoTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoTotal.KeyDown
        Dim decTemp1, decTemp2 As Decimal
        Decimal.TryParse(txtCostoTotal.Text, decTemp1)
        Decimal.TryParse(txtTotalImpuesto.Text, decTemp2)
        txtTotalCompra.Text = (decTemp1 * decTemp2).ToString("0.00")
    End Sub
    Private Sub txtTotalImpuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalImpuesto.KeyDown
        Dim decTemp1, decTemp2 As Decimal
        Decimal.TryParse(txtCostoTotal.Text, decTemp1)
        Decimal.TryParse(txtTotalImpuesto.Text, decTemp2)
        txtTotalCompra.Text = (decTemp1 * decTemp2).ToString("0.00")
    End Sub
    Private Sub CargarUnidad()
        'Dim oUnidad As cUnidad = New cUnidad
        Dim oUnidad As Ransa.Controls.Unidad.cUnidad = New Ransa.Controls.Unidad.cUnidad
        opdtUnidad = oUnidad.fdtListar("", sDefault_Peso)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

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
