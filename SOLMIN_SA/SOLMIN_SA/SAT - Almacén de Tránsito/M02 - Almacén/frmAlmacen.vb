
' Librerías del Framework  
Imports System.IO
' Librerías del Proyecto
'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.Waybill
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Procesos
Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho.Procesos
Imports Ransa.DAO.WayBill
'Imports Ransa.TypeDef.UbicacionPlanta
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
Imports StorageFileManager
''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class frmAlmacen
    Public Const ProcesoExitoso As String = "S"
    Public Const ErrorProceso As String = "E"
    Public Const ErrorComunicacion As String = "F"
    Public Const ErrorConexion As String = "C"

#Region " Atributos "
    Private blnDetalleItemChanged As Boolean = False
    Private dblCodCliente As Decimal = 0

#End Region
#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim objFiltro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
        With objFiltro
            .pCCLNT_CodigoCliente = txtClient.pCodigo
            dblCodCliente = txtClient.pCodigo
            .pCREFFW_CodigoBulto = txtCodigoRecepcion.Text
            .pNROPLT_NroPaletizado = txtNroPaletizado.Text
            .pCRTLTE_CriterioLote = txtCriterioLote.Text
            .pFREFFW_FechaRecep_Ini = dteFechaInicial.Value
            .pFREFFW_FechaRecep_Fin = dteFechaFinal.Value
            .pSSTINV_StatusAlmacen = "0"  ' Predefinimos el código de Stock en almacén
            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .pTUBRFR_Ubicacion = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .pTUBRFR_Ubicacion = ""
            End If
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCDVSN_CodigoDivision = UcDivision_Cmb011.Division
            .pCPLNDV_CodigoPlanta = UcPLanta_Cmb011.Planta
            .pSSNCRG_Sentido_Carga = "" & Me.txtSentidoCarga.Tag & ""
            .pPlanta = UcPLanta_Cmb011.DescripcionPlanta
        End With
        dgBultos.pActualizar(objFiltro)
        '-- Registro los nuevos valores de los campos de los clientes
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RecepcionClienteCodigo", txtClient.pCodigo)
        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing
    End Sub

    'Private Sub pAgregarBulto()
    '    MessageBox.Show("Es necesario ingresar el sustento de la Recepción" & vbCrLf & _
    '                    "a través de una Orden de Compra.", "Mensaje : ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Dim fRecepcionOCGestionEspecial As frmGestionOCES = New frmGestionOCES
    '    Dim dtOrdenesCompras As DataTable
    '    With fRecepcionOCGestionEspecial
    '        .pCodigoCliente_CCLNT = txtClient.pCodigo
    '        .Text &= "Recepción Especial"
    '        .ShowDialog()
    '        dtOrdenesCompras = .pListarItemsOrdenCompra
    '        .Dispose()
    '        fRecepcionOCGestionEspecial = Nothing
    '    End With
    '    If dtOrdenesCompras IsNot Nothing Then
    '        If dtOrdenesCompras.Rows.Count > 0 Then
    '            Dim fRecepcionOCGenerarBulto As frmGenerarBulto = New frmGenerarBulto
    '            With fRecepcionOCGenerarBulto
    '                .pCodigoCliente_CCLNT = txtClient.pCodigo
    '                .pOrdenComprasSeleccionados = dtOrdenesCompras
    '                .pStatusBultoNormal = False
    '                .pSoloLectura_QCNREC = True
    '                .pSoloLectura_TDAITM = False
    '                .pVisualizarCantidades = True
    '                .pCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
    '                .pDivision = Me.UcDivision_Cmb011.Division
    '                .pPlanta = Me.UcPLanta_Cmb011.Planta
    '                .Text &= " - Recepción Especial"
    '                .ShowDialog()
    '                .Dispose()
    '                fRecepcionOCGenerarBulto = Nothing
    '            End With
    '            pActualizarInformacion()
    '        Else
    '            MessageBox.Show("No ha ingresado la Orden de Compra con sus respectivos Items.", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Else
    '        MessageBox.Show("No existe alguna Orden de Compra con sus Items.", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub pAgregarItemsBulto()
        If dgBultos.pBultoSeleccionado.pCREFFW_CodigoBulto <> "" Then
            If dgBultos.pBultoSeleccionado.pNSEQIN_NrSecuencia > 1 Or dgBultos.pBultoSeleccionado.pNSEQIO_NrSecuenciaOrigen > 1 Then Exit Sub
            Dim obeOrdenDeCompra As New beOrdenCompra
            With obeOrdenDeCompra
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PNCCLNT = dgBultos.pBultoSeleccionado.pCCLNT_CodigoCliente
                .PSCREFFW = dgBultos.pBultoSeleccionado.pCREFFW_CodigoBulto
                .PNNSEQIN = dgBultos.pBultoSeleccionado.pNSEQIN_NrSecuencia
                If Me.dgBultosDetalle.Rows.Count > 0 Then
                    .PSNORCML = CType(dgBultosDetalle.CurrentRow.DataBoundItem, beBulto).PSNORCML
                    .PSNFACPR = CType(dgBultosDetalle.CurrentRow.DataBoundItem, beBulto).PSNFACPR
                    .PNFFACPR = CType(dgBultosDetalle.CurrentRow.DataBoundItem, beBulto).PNFFACPR
                    .PSNGRPRV = CType(dgBultosDetalle.CurrentRow.DataBoundItem, beBulto).PSNGRPRV
                End If
            End With
            If obeOrdenDeCompra.PSNORCML.Trim.Equals("") Then
                Dim ofrmAgregarItemsBulto As frmAgregarItemsBulto = New frmAgregarItemsBulto
                With ofrmAgregarItemsBulto
                    .pobeOrdeDeCompra = obeOrdenDeCompra
                    .Text &= "Modificar"
                    .pEstado = ""
                    .pTipoMaterial = dgBultos.pBultoSeleccionado.pCODMAT_CodigoMaterial 'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        .Dispose()
                        frmAgregarItemsBulto = Nothing
                        Call pListarItemsBultos(dgBultos.pBultoSeleccionado)
                    End If

                End With
            Else
                Dim ofrmModificarItemsBulto As frmModificarItemsBulto = New frmModificarItemsBulto
                With ofrmModificarItemsBulto
                    .pobeOrdeDeCompra = obeOrdenDeCompra
                    .Text &= "Agregar"
                    .pEstado = ""
                    .pTipoMaterial = dgBultos.pBultoSeleccionado.pCODMAT_CodigoMaterial 'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        .Dispose()
                        frmAgregarItemsBulto = Nothing
                        Call pListarItemsBultos(dgBultos.pBultoSeleccionado)
                    End If

                End With
            End If

        End If
    End Sub

    Private Sub pElimnarItemBulto()
        If Me.dgBultosDetalle.CurrentCellAddress.Y = -1 Then Exit Sub
        'If dgBultos.pBultoSeleccionado.pNSEQIN_NrSecuencia > 1 Or dgBultos.pBultoSeleccionado.pNSEQIO_NrSecuenciaOrigen > 1 Then Exit Sub
        If MessageBox.Show("Desea eliminar el Bulto.", "Desea eliminar el Bulto.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim obrBulto As New brBulto
            Dim strError As String = ""
            With Me.dgBultosDetalle.CurrentRow.DataBoundItem
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PNCCLNT = Me.txtClient.pCodigo
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta

            End With
            If obrBulto.EliminarDetalleBulto(Me.dgBultosDetalle.CurrentRow.DataBoundItem, strError) = 0 Then
                HelpClass.ErrorMsgBox()
            Else
                If Not strError.Trim.Equals("") Then
                    HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
                Else
                    DeleteItemBulto(dgBultosDetalle.CurrentRow.DataBoundItem)
                End If
            End If
            If Me.dgBultosDetalle.Rows.Count = 0 Then
                Me.dgBultos.btnEliminar_Click(Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub DeleteItemBulto(ByVal pbeBulto As beBulto)
        Me.dgBultosDetalle.DataSource.Remove(pbeBulto)
        Dim olbeBulto As New List(Of beBulto)
        olbeBulto = Me.dgBultosDetalle.DataSource
        dgBultosDetalle.DataSource = Nothing
        dgBultosDetalle.DataSource = olbeBulto
    End Sub

    Private Sub pListarItemsBultos(ByVal TD_BultoSeleccionado As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        '----------frmObservacionItemOC-------------
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .PNCCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .PNNSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
        End With
        dgBultosDetalle.AutoGenerateColumns = False
        dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
        ' QUEDA COMENTADA LA INTERFAZ ANTERIOR
        ' dgBultosDetalle.DataSource = mfdtListar_ItemsBultos(TD_BultoSeleccionado.pCCLNT_CodigoCliente, TD_BultoSeleccionado.pCREFFW_CodigoBulto, UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division, UcPLanta_Cmb011.Planta)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
        For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
            Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
            If NRSITEM > 0 Then
                oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.retencion
            End If
            'CSR-HUNDRED-041016-MATERIALES-PELIGROSOS
            oDgvrItemOC.Cells("PSFCHCAD").Value = HelpClass.FechaNum_a_Fecha(oDgvrItemOC.Cells("PSFCHCAD").Value.ToString())
        Next

    End Sub

    Private Sub pListarPaqueteBultos(ByVal TD_BultoSeleccionado As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        '----------frmObservacionItemOC-------------
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .PNCCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .PNNSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
        End With
        dtgPaquetesDeBulto.AutoGenerateColumns = False
        dtgPaquetesDeBulto.DataSource = obrBulto.flistListarBultoDetalleCarga(obeBulto)
    End Sub


    '-----------------ACD----------------
    Private Sub dgBultosDetalle_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgBultosDetalle.DataBindingComplete
        Dim imagen As Bitmap
        imagen = New Bitmap(Global.SOLMIN_SA.My.Resources.text_block)
        For i As Integer = 0 To dgBultosDetalle.Rows.Count - 1
            dgBultosDetalle.Rows(i).Cells("Obs").Value = imagen
        Next
    End Sub

    Private Sub pModificarBulto(ByVal TD_BultoSeleccionado As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        Dim fModificarBulto As frmModificarBulto = New frmModificarBulto
        With fModificarBulto
            .pCodigoCliente_CCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = TD_BultoSeleccionado.pCCMPN_Compania
            .pCodigoDivision_CDVSN = TD_BultoSeleccionado.pCDVSN_Division
            .pCodigoPlanta_CPLNDV = TD_BultoSeleccionado.pCPLNDV_Planta
            .pNrCorrelativo_NSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
            .Text &= "Modificar"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                .Dispose()
                fModificarBulto = Nothing
                dgBultos.pRefrescar()
            End If
        End With

    End Sub

    Private Sub pMostrarInformacionItemBulto()
        If dgBultosDetalle.CurrentRow Is Nothing Then
            txtInformacionItemBulto.Text = ""
            Exit Sub
        End If
        Dim obrBulto As New brBulto
        txtInformacionItemBulto.Text = obrBulto.fstrInformacionItemBulto(dgBultosDetalle.CurrentRow.DataBoundItem)
    End Sub

    Private Sub pInterfaseCliente()
        Dim strCodigoRecepcion As String = ""
        If txtClient.pCodigo <> 0 Then
            Dim fInterfase As frmInterfase = New frmInterfase
            With fInterfase
                .pCodigoCliente_CCLNT = txtClient.pCodigo
                .pCodigoCompania_CCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .pCodigoDivision_CDVSN = Me.UcDivision_Cmb011.Division
                .pCodigoPlanta_CPLNDV = Me.UcPLanta_Cmb011.Planta
                .ShowDialog()
                strCodigoRecepcion = .pCodigoRecepcion_CREFFW
                .Dispose()
                fInterfase = Nothing
            End With
        End If
        If strCodigoRecepcion <> "" Then
            Dim fModificarBulto As frmModificarBulto = New frmModificarBulto
            With fModificarBulto
                .pCodigoCliente_CCLNT = txtClient.pCodigo
                .pCodigoCompania_CCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .pCodigoDivision_CDVSN = Me.UcDivision_Cmb011.Division
                .pCodigoPlanta_CPLNDV = Me.UcPLanta_Cmb011.Planta
                .pCodigoRecepcion_CREFFW = strCodigoRecepcion
                .pNrCorrelativo_NSEQIN = 1
                .Text &= "Modificar"
                .ShowDialog()
                .Dispose()
                fModificarBulto = Nothing
            End With
        End If
        Me.dgBultos.pRefrescar()
    End Sub

    Private Sub pEliminar_BultoPaleta()
        With dgBultos
            If .pBultoSeleccionado.pCREFFW_CodigoBulto <> "" And .pBultoSeleccionado.pNROPLT_NroPaletizado > 0 Then
                If mfblnEliminar_BultoPaleta(.pBultoSeleccionado.pCCLNT_CodigoCliente, .pBultoSeleccionado.pNROPLT_NroPaletizado, _
                                             .pBultoSeleccionado.pCREFFW_CodigoBulto.Trim) Then
                    MessageBox.Show("Se quitó bulto del Paletizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dgBultos.pRefrescar()

                    ' corregir
                    ' dgBultosCabecera.CurrentRow.Cells("M_NROPLT").Value = 0
                    'Beep()
                End If
            Else
                MessageBox.Show("Bulto no seleccionado o sin Paletizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Function fblnValidaFiltros() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        End If
        Return blnResultado
    End Function

#End Region

#Region " Métodos "
    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    'Private Sub dgBultos_Add_Bulto() Handles dgBultos.Add_Bulto
    '    Call pAgregarBulto()
    'End Sub

    Private Sub dgBultos_Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean) Handles dgBultos.Confirm
        If MessageBox.Show(strPregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then blnCancelar = True
    End Sub

    Private Sub dgBultos_CurrentRowChanged(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.CurrentRowChanged
        Call pListarItemsBultos(Bulto)
        Call pListarPaqueteBultos(Bulto)
    End Sub

    Private Sub dgBultos_DataLoadCompleted(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.DataLoadCompleted
        Call pListarItemsBultos(Bulto)
        Call pListarPaqueteBultos(Bulto)
    End Sub

    Private Sub dgBultos_Edit_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Edit_Bulto
        Call pModificarBulto(Bulto)
    End Sub

    Private Sub dgBultos_ErrorMessage(ByVal strMensaje As String) Handles dgBultos.ErrorMessage
        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgBultos_Etiqueta_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto
        Dim obeBulto As New beBulto
        obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeBulto.PSCDVSN = UcDivision_Cmb011.Division
        obeBulto.PNCPLNDV = UcPLanta_Cmb011.Planta
        obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
        obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
        Call mpImprimir_EtiquetaBulto(obeBulto)
    End Sub

    Private Sub dgBultos_Etiqueta_Bulto_Mineria(Bulto As TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto_Mineria
        Dim obeBulto As New beBulto
        obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeBulto.PSCDVSN = UcDivision_Cmb011.Division
        obeBulto.PNCPLNDV = UcPLanta_Cmb011.Planta
        obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
        obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
        obeBulto.PNQREFFW = Bulto.pQREFFW_CantidadRecibida
        Call mpImprimir_EtiquetaBulto_Mineria(obeBulto)
    End Sub

    Private Sub dgBultos_Etiqueta_Paleta(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Paleta
        Call mpImprimir_EtiquetaPaleta(Bulto.pCCLNT_CodigoCliente, Bulto.pNROPLT_NroPaletizado)
    End Sub

    Private Sub dgBultos_Etiqueta_SecuenciaBulto() Handles dgBultos.Etiqueta_SecuenciaBulto
        If txtClient.pCodigo = 0 Then Exit Sub
        Dim fGenerarSecuencia As frmGenerarSecuencia = New frmGenerarSecuencia
        With fGenerarSecuencia
            .pintCliente = txtClient.pCodigo
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Beep()
            End If
            fGenerarSecuencia = Nothing
        End With
    End Sub

    Private Sub dgBultos_ExportExcel() Handles dgBultos.ExportExcel
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PNCCLNT = Me.txtClient.pCodigo
            .PSCREFFW = txtCodigoRecepcion.Text
            .PNNROPLT = Val(txtNroPaletizado.Text)
            .PSCRTLTE = txtCriterioLote.Text
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
            .PSSSTINV = "0"  ' Predefinimos el código de Stock en almacén
            .PSTUBRFR = txtUbicacionReferencial.Text
            .PSFLGCNL = "0"
            'Modificado por ABraham Zorrilla
            .PSNGRPRV = ""
            .PSNORCML = ""
        End With
        Dim dstTemp As New DataSet
        Dim odt As New DataTable
        'dstTemp = HelpClass.GetDataSetNative(Me.dtgCentroCostoREcepcion.DataSource)
        odt = obrBulto.ListarBultoALL(obeBulto)
        dstTemp.Tables.Add(odt.Copy)
        For i As Integer = dstTemp.Tables(0).Columns.Count - 1 To 1 Step -1
            'Select Case dstTemp.Tables(0).Columns(i).ColumnName
            '    Case "PSFREFFW", "PSNORCML", "PSNREFCL", "PSTPRVCL", "PSCREFFW", "PSNGRPRV", "PSDESCWB", "PNQREFFW", "PNQPSOBL", "PNQVLBTO", "PSMEDSUG", "PSMEDCONF", "PSTCTCST", "PSTCTCSA", "PSTCTCSF", "PSLOTE"
            '    Case Else
            '        dstTemp.Tables(0).Columns.RemoveAt(i)
            'End Select
        Next
        Call mpGenerarXLS("BULTO", dstTemp.Tables(0), Me.txtClient.pCodigo.ToString & " - " & Me.txtClient.pRazonSocial.ToString)
    End Sub


    Private Sub dgBultos_Interfase_Bulto_Generico() Handles dgBultos.Interfase_Bulto
        Call pInterfaseCliente()
    End Sub
    'Private Sub pInterfaceFecha() Handles dgBultos.InterfaceFecha
    '    Dim ofrmInterfazCorpesa = New frmInterfaseCorpesaXFecha()
    '    ofrmInterfazCorpesa.pCliente = Me.txtClient.pCodigo
    '    ofrmInterfazCorpesa.pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
    '    ofrmInterfazCorpesa.pDivision = UcDivision_Cmb011.Division
    '    ofrmInterfazCorpesa.pPlanta = UcPLanta_Cmb011.Planta
    '    ofrmInterfazCorpesa.ShowDialog()
    'End Sub

    'Private Sub pInterfaceBulto() Handles dgBultos.InterfaceBulto
    '    Dim ofrmInterfazCorpesa = New frmInterfazCorpesa()
    '    ofrmInterfazCorpesa.pCodigoCliente_CCLNT = Me.txtClient.pCodigo
    '    ofrmInterfazCorpesa.pCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
    '    ofrmInterfazCorpesa.pDivision = UcDivision_Cmb011.Division
    '    ofrmInterfazCorpesa.pPlanta = UcPLanta_Cmb011.Planta
    '    ofrmInterfazCorpesa.ShowDialog()
    'End Sub

    Private Sub dgBultos_RePacking_Bulto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.RePacking_Bulto
        Dim fRePacking As frmRePacking = New frmRePacking
        With fRePacking
            .pCodigoCliente_CCLNT = Bulto.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = Bulto.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCodigoDivision_CDVSN = UcDivision_Cmb011.Division
            .pCodigoPlanta_CPLNDV = UcPLanta_Cmb011.Planta
            .pNrCorrelativo_NSEQIN = Bulto.pNSEQIN_NrSecuencia
            .ShowDialog()
            .Dispose()
            fRePacking = Nothing
        End With
        dgBultos.pRefrescar()
    End Sub

    Private Sub dgBultos_TableWithOutData() Handles dgBultos.TableWithOutData
        dgBultosDetalle.DataSource = Nothing
    End Sub

    Private Sub dgBultosDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBultosDetalle.CurrentCellChanged
        hgDetalleItem.Width = 21
        blnDetalleItemChanged = True
    End Sub

    Private Sub frmRecepciónBultos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'dteFechaInicial.Value = Now.AddYears(-1)
        dteFechaInicial.Value = Now
        dteFechaFinal.Value = Now
        ' ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Informamos a los controles el Usuario actual
        dgBultos.pUsuario = objSeguridadBN.pUsuario
        dgBultos.pNameForm = Me.Name
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtClient.pCargar(ClientePK)

        If txtClient.pCodigo <> 0 Then dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Call pActualizarInformacion()
        Call CargarUbicacion()
        '--Valida si el cliente es Pluspetrol
        If Me.txtClient.pCodigo = 30507 Or Me.txtClient.pCodigo = 11731 Then
            dgBultos.btnInterfase.Visible = False
            dgBultos.ddbInterfaz.Visible = True
        Else
            dgBultos.btnInterfase.Visible = True
            dgBultos.ddbInterfaz.Visible = False
        End If

        dgBultos.pShowBtnEliminar = True
        btnActualizar.Visible = True
    End Sub

    Private Sub hgDetalleItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles hgDetalleItem.Click
        If hgDetalleItem.Width = 21 Then
            hgDetalleItem.Width = 400
            If blnDetalleItemChanged Then Call pMostrarInformacionItemBulto()
        Else
            hgDetalleItem.Width = 21
        End If
    End Sub

    Private Sub tsbAgregarItemBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarItemBulto.Click
        Call pAgregarItemsBulto()
    End Sub

    Private Sub tsbEliminarItemBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarItemBulto.Click
        Call pElimnarItemBulto()
    End Sub

    Private Sub tsmiAgregarItemsBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregarItemsBulto.Click
        Call pAgregarItemsBulto()
    End Sub

    Private Sub tsmiEliminarBultoPaleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminarBultoPaleta.Click
        Try
            Call pEliminar_BultoPaleta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub tsmiEliminarItemBulto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminarItemBulto.Click
        Try
            Call pElimnarItemBulto()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub txtClient_ExitFocusWithOutData() Handles txtClient.ExitFocusWithOutData
        dgBultos.pClear()
    End Sub

    Private Sub txtClient_InformationChanged() Handles txtClient.InformationChanged
        dgBultos.pClear()
        dgBultos.pCCLNT_CodigoCliente = Me.txtClient.pCodigo
       

        CargarUbicacion()
    End Sub

    Private Sub txtClient_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClient.Validating
        dgBultos.pCCLNT_CodigoCliente = txtClient.pCodigo
        'dgBultos.pShowBtnImprimir = ValidarImpresion(txtClient.pCodigo)
        'se valida que el cliente temnga permiso para enviar por ws
        Dim obrBulto As New brBulto
        dgBultos.pShowBtnEnviarConfirmacion() = obrBulto.ValidarClienteParaConfirmacion(Me.txtClient.pCodigo)

    End Sub

#End Region

    Private Sub dgBultosDetalle_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgBultosDetalle.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("X_MARRET") Then
            If MessageBox.Show("¿ Desea marcar como custodia o retención al Item : " & Me.dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value & Chr(13) & "" & Me.dgBultosDetalle.CurrentRow.Cells("D_TDITES").Value.ToString.Trim & " ?", "Custodia Retención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                RealizarRetencion("X")
            Else
                RealizarRetencion("")
            End If
        End If
        '------------------------------------------------ACD------------------------------------------------
        If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("Obs") Then
            Dim obeItemOC As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
            obeItemOC.pCCMPN_Compania = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCCMPN
            obeItemOC.pCDVSN_Division = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCDVSN
            obeItemOC.pCPLNDV_Planta = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNCPLNDV
            obeItemOC.pCCLNT_CodigoCliente = dblCodCliente
            obeItemOC.pCREFFW_FrdForw = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCREFFW
            obeItemOC.pCIDPAQ_CodIndentificacionPaquete = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCIDPAQ
            obeItemOC.pNORCML_NroOrdenCompra = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSNORCML
            obeItemOC.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNNRITOC

            Dim frmObs As New frmObservacionItemOC(obeItemOC)
            frmObs.ShowInTaskbar = False
            frmObs.StartPosition = FormStartPosition.CenterScreen
            frmObs.ShowDialog()
        End If
        '---------------------------------------------------------------------------------------------------
        If Me.dgBultosDetalle.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
            If Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNNRSITEM = 0 Then Exit Sub
            Dim obeItemBulto As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
            obeItemBulto.pCCLNT_CodigoCliente = dblCodCliente
            obeItemBulto.pCCMPN_Compania = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCCMPN
            obeItemBulto.pCDVSN_Division = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCDVSN
            obeItemBulto.pCPLNDV_Planta = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNCPLNDV
            obeItemBulto.pCREFFW_FrdForw = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCREFFW ' Me.dgBultosDetalle.CurrentRow.Cells("D_CREFFW").Value
            obeItemBulto.pCIDPAQ_CodIndentificacionPaquete = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSCIDPAQ ' Me.dgBultosDetalle.CurrentRow.Cells("D_CIDPAQ").Value
            obeItemBulto.pNORCML_NroOrdenCompra = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PSNORCML 'Me.dgBultosDetalle.CurrentRow.Cells("D_NORCML").Value
            obeItemBulto.pNRITOC_NroItemOC = Me.dgBultosDetalle.CurrentRow.DataBoundItem.PNNRITOC 'Me.dgBultosDetalle.CurrentRow.Cells("D_NRITOC").Value

            Dim ofrmSubItemEnAlmacen As New frmSubItemEnAlmacen
            With ofrmSubItemEnAlmacen
                .Items = obeItemBulto
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub RealizarRetencion(ByVal pstrRetencion As String)
        Dim obrBulto As New brBulto
        With Me.dgBultosDetalle.CurrentRow.DataBoundItem
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PSMARRET = pstrRetencion
            .PNCCLNT = Me.txtClient.pCodigo
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
        End With
        If obrBulto.ActualizarCustodia(Me.dgBultosDetalle.CurrentRow.DataBoundItem) = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Call pListarItemsBultos(dgBultos.pBultoSeleccionado)
    End Sub


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()

        Dim objFiltro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
        objFiltro.pCCMPN_CodigoCompania = ("" & UcCompania_Cmb011.CCMPN_CodigoCompania).Trim
        objFiltro.pCDVSN_CodigoDivision = ("" & UcDivision_Cmb011.Division).Trim
        objFiltro.pCPLNDV_CodigoPlanta = ("" & UcPLanta_Cmb011.Planta).Trim
        objFiltro.pCCLNT_CodigoCliente = txtClient.pCodigo
        objFiltro.pPlanta = ("" & UcPLanta_Cmb011.DescripcionPlanta).Trim
        dgBultos.pActualizarFiltroInicial(objFiltro)

    End Sub

    Private Sub frmAlmacen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Call mpMostrarClienteMDI(String.Empty)
    End Sub

    Private Sub dgBultos_TrasladoOC(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.TrasladoOC
        Try
            Dim ofrmConsultaOCTraslado As New frmConsultaOCTraslado
            Dim olistBulto As New List(Of beBulto)
            olistBulto = Me.dgBultosDetalle.DataSource
            ofrmConsultaOCTraslado.oListBulto = olistBulto
            ofrmConsultaOCTraslado.Bulto = Bulto
            ofrmConsultaOCTraslado.ShowDialog()
            If (ofrmConsultaOCTraslado.myDialogResult) Then
                Call pActualizarInformacion()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Function pReporteInventarioAlmacenOc() As DataTable
        Try
            Dim dtTemp As DataTable = Nothing
            Dim obeFiltro As New Ransa.TypeDef.Reportes.beFiltrosDespachoPorAlmacen
            Dim obrReporteAT As New brReporteAT
            With obeFiltro
                .PSCCLNT = txtClient.pCodigo
                .PSTCMPCL = txtClient.pRazonSocial
                .PNFPROCE = dteFechaFinal.Value
                .PSTUBRFR = txtUbicacionReferencial.Text()
                .PSSTPING = ""
                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
                .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
            End With
            'Return obrReporteAT.frptInventarioAlmacen(obeFiltro)
            Dim ds As New DataSet
            ds = obrReporteAT.frptInventarioAlmacen(obeFiltro)
            Return ds.Tables(0).Copy
            'Return obrReporteAT.frptInventarioAlmacen(obeFiltro)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable

        Dim dblValor As Decimal = Decimal.Zero
        dtTemp.Select("", "TUBRFR, CREFFW  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows.RemoveAt(i)
            Else
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows(i).Item("IMPORTE") = dblValor
                dblValor = 0
            End If

            If i = 1 Then
                dblValor = dblValor + dtTemp.Rows(i - 1).Item("IMPORTE")
                dtTemp.Rows(i - 1).Item("IMPORTE") = dblValor
                dblValor = 0
            End If
        Next
        Return dtTemp
    End Function

    Private Sub dgBultos_ExportInventarioExcel() Handles dgBultos.ExportInventarioExcel
        Dim oDtExcel As DataTable
        Dim strTitulo As String = ""
        strTitulo = Me.txtClient.pCodigo & " - " & Me.txtClient.pRazonSocial
        oDtExcel = pReporteInventarioAlmacenOc.Copy
        oDtExcel = EliminarRepetido(oDtExcel)
        ExportarExcelOC1(oDtExcel, strTitulo)
    End Sub


    Private Sub ExportarExcelOC1(ByVal oDtExcel As DataTable, ByVal strTitulo As String)
        Dim oDt As New DataTable
        Dim oDtFiltro As New DataTable
        Dim oDt2 As DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        oDt.Columns.Remove("TIPO_ALMACEN")
        oDt.Columns.Remove("ALMACEN")
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        Dim oDs As New DataSet
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QMTALT").ColumnName = "ALTURA"
        oDt.Columns("QMTANC").ColumnName = "ANCHO"
        oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"

        Dim oDtv1 As DataView = New DataView(oDt)
        oDt2 = oDtv1.ToTable(True, "LUGAR DE ENTREGA")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(oDt, "[LUGAR DE ENTREGA] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim) & " "
            oDs.Tables.Add(oDtFiltro)
        Next
        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente:\n" & Me.txtClient.pCodigo & " - " & Me.txtClient.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If

        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaFinal.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 8)
        listSuma.Add("Suma02", 10)
        listSuma.Add("Suma03", 14)
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click
        Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
    End Sub

    Private Function NombreTabla(ByVal strNombreTabla As String) As String
        strNombreTabla = strNombreTabla.Replace(":", "-")
        strNombreTabla = strNombreTabla.Replace("?", "")
        strNombreTabla = strNombreTabla.Replace("/", "-")
        Return strNombreTabla
    End Function

    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable
        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        Return dtNew
    End Function


    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
        End If
    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating
        If txtSentidoCarga.Text = "" Then
            txtSentidoCarga.Tag = ""
        Else
            If txtSentidoCarga.Text <> "" And "" & txtSentidoCarga.Tag = "" Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                If txtSentidoCarga.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub



    'Private Sub dgBultos_AdjuntarDocumnto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.AdjuntarDocumnto
    '    Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
    '    With ofrmAdjuntarDocumento
    '        .pTABLE_NAME = "RZOL65"
    '        .pUSER_NAME = objSeguridadBN.pUsuario
    '        .PSCCMPN = Bulto.pCCMPN_Compania
    '        .PSCDVSN = Bulto.pCDVSN_Division
    '        .PNCPLNDV = Bulto.pCPLNDV_Planta
    '        .PNCCLNT = Bulto.pCCLNT_CodigoCliente
    '        .PSCREFFW = Bulto.pCREFFW_CodigoBulto
    '        .pNMRGIM = Bulto.pNMRGIM_NrImagen
    '        .ShowDialog()
    '    End With
    'End Sub

    Private Sub dgBultos_Etiqueta_Bulto_Detalle(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Etiqueta_Bulto_Detalle
        Dim obeBulto As New beBulto
        obeBulto.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeBulto.PSCDVSN = UcDivision_Cmb011.Division
        obeBulto.PNCPLNDV = UcPLanta_Cmb011.Planta
        obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
        obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
        Call mpImprimir_EtiquetaBulto_Detalle(obeBulto)
    End Sub

    Private Sub dgBultos_ClickImagen(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.ClickImagen
        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Bulto
        'With ofrmAdjuntarDocumento
        '    .pTABLE_NAME = "RZOL65"
        '    .pUSER_NAME = objSeguridadBN.pUsuario
        '    .PSCCMPN = Bulto.pCCMPN_Compania
        '    .PSCDVSN = Bulto.pCDVSN_Division
        '    .PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .PSCREFFW = Bulto.pCREFFW_CodigoBulto
        '    .pNMRGIM = Bulto.pNMRGIM_NrImagen
        '    .ShowDialog()
        '    pActualizarInformacion()
        'End With
    End Sub

    Private Sub dgBultos_AdjuntarDocumnto(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.AdjuntarDocumnto
        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
        'With ofrmAdjuntarDocumento
        '    '.obeBulto.PSCCMPN = Bulto.pCCMPN_Compania
        '    '.obeBulto.PSCDVSN = Bulto.pCDVSN_Division
        '    '.obeBulto.PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .oBeDocumento.PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .oBeDocumento.PSNDOCUM = Bulto.pCREFFW_CodigoBulto
        '    .oBeDocumento.PSTIPODC = "RECEPCION"
        'End With
        'If ofrmAdjuntarDocumento.ShowDialog() Then
        '    Call pActualizarInformacion()
        'End If


        'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos_Bulto
        'With ofrmAdjuntarDocumento
        '    .pTABLE_NAME = "RZOL65"
        '    .pUSER_NAME = objSeguridadBN.pUsuario
        '    .PSCCMPN = Bulto.pCCMPN_Compania
        '    .PSCDVSN = Bulto.pCDVSN_Division
        '    .PNCPLNDV = Bulto.pCPLNDV_Planta
        '    .PNCCLNT = Bulto.pCCLNT_CodigoCliente
        '    .PSCREFFW = Bulto.pCREFFW_CodigoBulto
        '    .pNMRGIM = Bulto.pNMRGIM_NrImagen
        '    .ShowDialog()
        '    pActualizarInformacion()
        'End With


        Try

            Dim pCCLNT As String = Bulto.pCCLNT_CodigoCliente
            Dim pNSEQIN As String = Bulto.pNSEQIN_NrSecuencia
            Dim pCCMPN As String = Bulto.pCCMPN_Compania
            Dim pCDVSN As String = Bulto.pCDVSN_Division
            Dim pCREFFW As String = Bulto.pCREFFW_CodigoBulto
            Dim pCPLNDV As String = Bulto.pCPLNDV_Planta


            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaAdjuntos.pNroImagen = Bulto.pNMRGIM_NrImagen
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ' ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65(pCCMPN, pCDVSN, pCPLNDV, pCCLNT, pCREFFW, pNSEQIN)
            ofrmCargaAdjuntos.ShowDialog()
            If ofrmCargaAdjuntos.pDialog = True Then
                
                dgBultos.ActualizarFlag_Adjunto(ofrmCargaAdjuntos.pNroImagen)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    

    End Sub

    Private Sub CargarUbicacion()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        Dim objNegocio As New brUbicacionesXCliente

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR_1"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación "
        oColumnas.Visible = False
        oListColum.Add(2, oColumnas)
        txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(Me.txtClient.pCodigo)
        txtUbicacionReferencial.ListColumnas = oListColum
        txtUbicacionReferencial.Cargas()
        txtUbicacionReferencial.Limpiar()
        txtUbicacionReferencial.ValueMember = "PSTUBRFR"
        txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
    End Sub

    Public Sub dgBultos_Enviar_Email(ByVal Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01) Handles dgBultos.Enviar_Email
        Call pEnviarEmail(Bulto)
    End Sub

    Private Sub pEnviarEmail(ByVal TD_BultoSeleccionado As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)
        Dim fModificarBulto As frmEnviarMailBulto = New frmEnviarMailBulto
        With fModificarBulto
            .pCodigoCliente_CCLNT = TD_BultoSeleccionado.pCCLNT_CodigoCliente
            .pCodigoRecepcion_CREFFW = TD_BultoSeleccionado.pCREFFW_CodigoBulto
            .pCodigoCompania_CCMPN = TD_BultoSeleccionado.pCCMPN_Compania
            .pCodigoDivision_CDVSN = TD_BultoSeleccionado.pCDVSN_Division
            .pCodigoPlanta_CPLNDV = TD_BultoSeleccionado.pCPLNDV_Planta
            .pNrCorrelativo_NSEQIN = TD_BultoSeleccionado.pNSEQIN_NrSecuencia
            .Text &= "Enviar Correo"
        End With

        If fModificarBulto.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fModificarBulto.Dispose()
            fModificarBulto = Nothing
            dgBultos.pRefrescar()
        End If
    End Sub
    Public Sub dgBultos_EnviarConfirmacion(ByVal lstBultosEnviados As List(Of String), ByVal lstBultosSeleccionados As List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)) Handles dgBultos.EnviarConfirmacion

        Dim msjCodEnviados As String
        Dim codigosEnviados As String
        Dim msjResult As Integer
        If lstBultosEnviados.Count > 0 Then
            codigosEnviados = String.Join(",", lstBultosEnviados.ToArray())
            msjCodEnviados = String.Format("Los  bultos {0} ya fueron enviados satisfactoriamente. ¿Desea volver a enviar?", codigosEnviados)

            msjResult = MessageBox.Show(msjCodEnviados, "Enviar Confirmación", MessageBoxButtons.YesNo)

            If msjResult = DialogResult.Yes Then
                Call pEnviarConfirmacion(lstBultosSeleccionados)
            ElseIf msjResult = DialogResult.No Then

                Dim cloneLstBultosSeleccionados = lstBultosSeleccionados

                For Each bultoSel As TD_Sel_Bulto_L01 In cloneLstBultosSeleccionados
                    For Each codBultoEnv As String In lstBultosEnviados
                        If bultoSel.pCREFFW_CodigoBulto = codBultoEnv Then
                            cloneLstBultosSeleccionados.Remove(bultoSel)
                        End If
                    Next
                Next

                Call pEnviarConfirmacion(cloneLstBultosSeleccionados)

            Else
                Exit Sub
            End If
        Else
            Call pEnviarConfirmacion(lstBultosSeleccionados)
        End If
    End Sub

    Private Sub pEnviarConfirmacion(ByVal lstBultosSeleccionados As List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01))

        Dim oBulto As beBulto
        Dim obrBulto As New brBulto
        Dim estEnvioConfirmacion As String
        Dim lstCodBultoErrorProceso As New List(Of String)
        Dim lstMessagesErrorProceso As New List(Of String)
        Dim lstCodBultoErrorComunicacion As New List(Of String)
        Dim lstCodBultoErrorConexion As New List(Of String)
        Dim ProcesosExitosos As Integer = 0
        Dim mensaje As String
        Dim strMensajeError As String = String.Empty

        For Each bultoSel As TD_Sel_Bulto_L01 In lstBultosSeleccionados

            oBulto = New beBulto
            oBulto.PSCCMPN = bultoSel.pCCMPN_Compania
            oBulto.PSCDVSN = bultoSel.pCDVSN_Division
            oBulto.PNCPLNDV = bultoSel.pCPLNDV_Planta
            oBulto.PNCCLNT = bultoSel.pCCLNT_CodigoCliente
            oBulto.PSCREFFW = bultoSel.pCREFFW_CodigoBulto
            oBulto.PNNSEQIN = bultoSel.pNSEQIN_NrSecuencia

            estEnvioConfirmacion = obrBulto.EnviarInfoBulto(oBulto, strMensajeError)

            If estEnvioConfirmacion = ErrorProceso Then
                mensaje = String.Format("Error en el proceso de envío para el bulto: {0}, Detalle del error: {1}" & Chr(10), bultoSel.pCREFFW_CodigoBulto.Trim(), strMensajeError)
                lstCodBultoErrorProceso.Add(mensaje)
            End If

            If estEnvioConfirmacion = ErrorComunicacion Then
                mensaje = String.Format("Error de comunicación en el proceso de envío para el bulto: {0}" & Chr(10), bultoSel.pCREFFW_CodigoBulto.Trim())
                lstCodBultoErrorComunicacion.Add(mensaje)
            End If

            If estEnvioConfirmacion = ErrorConexion Then
                mensaje = String.Format("Error al actualizar el estado de envío del bulto: {0}" & Chr(10), bultoSel.pCREFFW_CodigoBulto.Trim())
                lstCodBultoErrorConexion.Add(mensaje)
            End If

            If estEnvioConfirmacion = ProcesoExitoso Then
                ProcesosExitosos = ProcesosExitosos + 1
            End If
        Next

        If (lstCodBultoErrorProceso.Count > 0) Then

            MessageBox.Show(String.Join(",", lstCodBultoErrorProceso.ToArray()), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (lstCodBultoErrorComunicacion.Count > 0) Then

            MessageBox.Show(String.Join(",", lstCodBultoErrorComunicacion.ToArray()), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (lstCodBultoErrorConexion.Count > 0) Then

            MessageBox.Show(String.Join(",", lstCodBultoErrorConexion.ToArray()), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If ProcesosExitosos = lstBultosSeleccionados.Count Then
            MessageBox.Show("Se realizó el envío correctamente.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lstCodBultoErrorProceso.Clear()
        lstCodBultoErrorComunicacion.Clear()
        lstCodBultoErrorConexion.Clear()

        pActualizarInformacion()
    End Sub

    Private Sub dgBultos_AnularConfirmacion(ByVal oTempBulto As Ransa.TypeDef.WayBill.TD_BultoPK, ByRef blnCancelar As Boolean) Handles dgBultos.AnularConfirmacion
        blnCancelar = pAnularConfirmacion(oTempBulto)
    End Sub

    Private Sub dgBultos_ActualizarFiltrosIniciales() Handles dgBultos.ActualizarFiltrosIniciales
        Dim objFiltro As TD_Qry_Bulto_L01 = New TD_Qry_Bulto_L01
        With objFiltro
            .pCCLNT_CodigoCliente = txtClient.pCodigo
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCDVSN_CodigoDivision = UcDivision_Cmb011.Division
            .pCPLNDV_CodigoPlanta = UcPLanta_Cmb011.Planta
            .pPlanta = UcPLanta_Cmb011.DescripcionPlanta
        End With
        dgBultos.pActualizarFiltroInicial(objFiltro)
     

    End Sub



    Private Function pAnularConfirmacion(ByVal oTempBulto As Ransa.TypeDef.WayBill.TD_BultoPK) As Boolean

        Dim oBulto As beBulto
        Dim obrBulto As New brBulto
        Dim estEnvioConfirmacion As String
        Dim mensaje As String
        Dim strMessageError As String = String.Empty

        oBulto = New beBulto
        oBulto.PSCCMPN = oTempBulto.pCCMPN_Compania
        oBulto.PSCDVSN = oTempBulto.pCDVSN_Division
        oBulto.PNCPLNDV = oTempBulto.pCPLNDV_Planta
        oBulto.PNCCLNT = oTempBulto.pCCLNT_CodigoCliente
        oBulto.PSCREFFW = oTempBulto.pCREFFW_CodigoBulto
        oBulto.PNNSEQIN = oTempBulto.pNSEQIN_NrSecuencia


        If obrBulto.ValidarClienteParaConfirmacion(oTempBulto.pCCLNT_CodigoCliente) Then

            estEnvioConfirmacion = obrBulto.EnviarAnulacionInfoBulto(oBulto, strMessageError)

            If estEnvioConfirmacion = ErrorProceso Then
                mensaje = String.Format("Error en el proceso de envío para el bulto: {0}, Detalle Error: {1}", oBulto.PSCREFFW.ToString().Trim(), strMessageError)
                MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            ElseIf estEnvioConfirmacion = ErrorComunicacion Then
                mensaje = String.Format("Error de comunicación en el proceso de envío para el bulto: {0}", oBulto.PSCREFFW.ToString().Trim())
                MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If
        Return False

    End Function
End Class