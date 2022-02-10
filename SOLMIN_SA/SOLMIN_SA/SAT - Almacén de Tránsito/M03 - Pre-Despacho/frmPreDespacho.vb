Imports Ransa.NEGO
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Imports Ransa.NEGO.DespachoSAT

Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmPreDespacho
#Region "Atributos"
    Private booStatus As Boolean = False
    Private _heightUpDown As Int32
    Private _heightDownUp As Int32
    Private _widthLeftRight As Int32
    '-- Crear status por control con F4
    Private booValidarCliente As Boolean = False
    Private detalleBultoXPedido As New DataTable 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
#End Region
#Region "Propiedades"
#End Region
    Enum eTipoValidacion
        PROCESAR
        ANULAR
        GENERAR
        RESTAURAR
    End Enum
#Region "Procedimientos y Funciones"
    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig
        'booStatus = False
        '-- Lleno la cabecera
        RemoveHandler dgPreDespachos.CurrentCellChanged, AddressOf dgPreDespachos_CurrentCellChanged
        Call pListarPreDespachos()
        AddHandler dgPreDespachos.CurrentCellChanged, AddressOf dgPreDespachos_CurrentCellChanged

        '-- Lleno el detalle
        RemoveHandler dgPreDespachoBultos.CurrentCellChanged, AddressOf dgPreDespachoBultos_CurrentCellChanged
        Call pListarPreDespachosBultos()
        AddHandler dgPreDespachoBultos.CurrentCellChanged, AddressOf dgPreDespachoBultos_CurrentCellChanged

        '-- Lleno el detalle Items
        RemoveHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
        Call pListarPreDespachoItemBultos()
        AddHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged

        '-- Lleno el detalle SubItems
        Call pListarPreDespachoSubItemBultos()

        '-- Registro los nuevos valores de los campos de los clientes
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("PredespachoClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pAgregarBultoPreDespacho()
        If Me.dgPreDespachos.RowCount > 0 Then
            Dim fPreDespachoAgregarBulto As frmPreDespachoAgregarBulto = New frmPreDespachoAgregarBulto
            With fPreDespachoAgregarBulto
                .pCodigoCliente_CCLNT = txtCliente.pCodigo
                .pCCMPN_Compania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .pCDVSN_CodDivision = Me.UcDivision_Cmb011.Division
                .pCPLNDV_CodigoPlanta = Me.UcPLanta_Cmb011.Planta
                .pNroControl_NROCTL = dgPreDespachos.CurrentRow.Cells("M_NROCTL").Value
                .pCriterioLote_CRTLTE = dgPreDespachos.CurrentRow.Cells("PSCRTLTE").Value.ToString.Trim
                .pSTPDES = dgPreDespachos.CurrentRow.Cells("PSCOD_STPDES").Value.ToString.Trim
                .ShowDialog()
                .Dispose()
                fPreDespachoAgregarBulto = Nothing
            End With
            pActualizarInformacion()
        End If
    End Sub

    Private Sub pDesmarcarBultoPreDespacho()

        If Me.dgPreDespachoBultos.RowCount > 0 Then
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNNRCTRL = dgPreDespachos.CurrentRow.Cells("M_NROCTL").Value
                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PNCCLNT = txtCliente.pCodigo
                .PSCREFFW = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCREFFW
                .PNNSEQIN = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNNSEQIN
            End With
            Dim strMensajeError As String = ""

            obrBulto.EliminarBultoPreDespachos(obeBulto, strMensajeError)
            MessageBox.Show("Proceso ELIMINAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

 

            pActualizarInformacion()
        End If
    End Sub

    Private Sub pListarPreDespachos()
        ' Cargamos la data
      


        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PNCCLNT = txtCliente.pCodigo
            .PNNROCTL = Val(txtCodigoPreDespacho.Text)
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
        End With
        dgPreDespachos.AutoGenerateColumns = False
        dgPreDespachos.DataSource = obrBulto.listaPreDespacho(obeBulto)
        MostrarGuiasRemision()
       

    End Sub

    Private Sub pListarPreDespachosBultos()
        dgPreDespachoBultos.DataSource = Nothing
        If dgPreDespachos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PNCCLNT = txtCliente.pCodigo
            .PNNROCTL = dgPreDespachos.CurrentRow.Cells("M_NROCTL").Value
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
        End With
        dgPreDespachoBultos.AutoGenerateColumns = False



        Dim oList As New List(Of beBulto)
        oList = obrBulto.listaContenidoPorCodPreDespacho(obeBulto)
        'dgPreDespachoBultos.DataSource = obrBulto.listaBultosPorCodPreDespacho(obeBulto)
        dgPreDespachoBultos.DataSource = oList

 
        For Each ITEM As DataGridViewRow In dgPreDespachoBultos.Rows
            If ("" & ITEM.Cells("FGLPRD").Value).ToString.Trim = "X" Then
                ITEM.Cells("LECTURA").Value = My.Resources.verde
            Else              
                ITEM.Cells("LECTURA").Value = My.Resources.CuadradoBlanco
            End If
          
        Next
      
       

    End Sub

    Private Sub pListarPreDespachoItemBultos()
        dgPreDespachoItemBulto.DataSource = Nothing
        If Me.dgPreDespachoBultos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        With obeBulto
            .PNCCLNT = txtCliente.pCodigo
            .PSCREFFW = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCREFFW
            .PNNSEQIN = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNNSEQIN
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
        End With
        dgPreDespachoItemBulto.AutoGenerateColumns = False
        dgPreDespachoItemBulto.DataSource = obrBulto.listaItemsDeBulto(obeBulto)
    End Sub

    Private Function fndt() As DataTable
        Dim dt As New DataTable

        'dt.Columns.Add("CREFFW") 'oculto
        dt.Columns.Add("CIDPAQ") 'Cód. Paquete
        'dt.Columns.Add("NORCML") 'oculto
        'dt.Columns.Add("NRITOC") 'Item
        dt.Columns.Add("SBITOC") 'SubItem
        dt.Columns.Add("TDITES") 'Descripcion
        dt.Columns.Add("QCNRCP", Type.GetType("System.Decimal")) 'Cant. en Bulto
        'dt.Columns.Add("QREPAC", Type.GetType("System.Decimal")) 'Cant. RePacking
        Return dt
    End Function
    Private Sub pListarPreDespachoSubItemBultos()
        If dgPreDespachoItemBulto.RowCount > 0 Then
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNCCLNT = txtCliente.pCodigo
                .PSCREFFW = dgPreDespachoBultos.CurrentRow.Cells("PSCREFFW").Value.ToString.Trim
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                .PSCIDPAQ = (" " & dgPreDespachoItemBulto.CurrentRow.Cells("D_CIDPAQ").Value & " ").ToString.Trim
                .PSNORCML = (" " & dgPreDespachoItemBulto.CurrentRow.Cells("D_NORCML").Value & " ").ToString.Trim
                .PNNRITOC = (" " & dgPreDespachoItemBulto.CurrentRow.Cells("D_NRITOC").Value & " ").ToString.Trim
            End With
            dgPreDespachoSubItemBulto.AutoGenerateColumns = False
            dgPreDespachoSubItemBulto.DataSource = obrBulto.ListarBultoSubItemsOC(obeBulto)
            If dgPreDespachoSubItemBulto.RowCount = 0 Then
                KryptonSplitContainer1.SuspendLayout()
                'hgSubItemsBulto.Visible = False
                If KryptonSplitContainer1.FixedPanel = FixedPanel.None Then
                    ' Make the bottom panel of the splitter fixed in size
                    KryptonSplitContainer1.FixedPanel = FixedPanel.Panel2
                    KryptonSplitContainer1.IsSplitterFixed = True
                    ' Remember the current height of the header group (to restore later)
                    _heightUpDown = hgSubItemsBulto.Height
                    ' Find the new height to use for the header group
                    Dim newHeight As Int32 = hgSubItemsBulto.PreferredSize.Height
                    ' Make the header group fixed to the new height
                    KryptonSplitContainer1.Panel2MinSize = newHeight
                    KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
                End If
            Else
                hgSubItemsBulto.Visible = True
                If KryptonSplitContainer1.FixedPanel = FixedPanel.None Then
                Else
                    ' Make the bottom panel not-fixed in size anymore
                    KryptonSplitContainer1.FixedPanel = FixedPanel.None
                    KryptonSplitContainer1.IsSplitterFixed = False

                    ' Put back the minimise size to the original
                    KryptonSplitContainer1.Panel2MinSize = 200

                    ' Calculate the correct splitter we want to put back
                    KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height '- _heightUpDown - kryptonSplitContainerVertical.SplitterWidth

                End If
            End If
            KryptonSplitContainer1.ResumeLayout()
        End If



        

    End Sub
#End Region
#Region "Métodos"
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Call pActualizarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGenerarPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarPreDespacho.Click

        Try
            If Me.dgPreDespachos.Rows.Count > 0 Then
                If txtCliente.pCodigo = 0 And dgPreDespachos.CurrentRow.Cells(1).Value = 0 Then
                    Me.Close()
                    Exit Sub
                End If

                'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)-INICIO
                Dim pedidoTraslado As New brPreDespacho
                Dim esClienteMilpo As Boolean = pedidoTraslado.ValidarDespachoMilpo(dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCCLNT)

                If esClienteMilpo Then

                    Dim parametroPedido As New bePedidoTrasladoxBulto
                    With parametroPedido
                        .Pncclnt = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCCLNT 'Cliente
                        .Psccmpn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCCMPN 'Compañía
                        .Pscdvsn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCDVSN 'División
                        .Pncplndv = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCPLNDV 'Planta
                        .pnnroctl = dgPreDespachos.CurrentRow.Cells("M_NROCTL").Value 'Número despacho
                    End With


                    'Valida que se haya asociado bulto al pedido de traslado
                    pedidoTraslado.parametroPedido = parametroPedido
                    Dim dataValidacion As DataTable = pedidoTraslado.ValidarDespacho
                    'QTOTAL/QSIN_DESPACHO

                    If dataValidacion.Rows.Count > 0 Then
                        If CDbl(dataValidacion.Rows(0).Item("QTOTAL")) = CDbl(dataValidacion.Rows(0).Item("QSIN_PEDIDO")) Then
                            If MsgBox("Los bultos no tienen Pedidos de Traslados asociados. ¿Desea generar el Despacho?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.No Then
                                Exit Sub
                            End If
                        Else
                            ' Valida que se haya seleccionado todos los bultos

                            If CDbl(dataValidacion.Rows(0).Item("QSIN_PEDIDO")) > 0 Then
                                MsgBox("Todos los bultos deben de tener Pedidos de Traslado", MsgBoxStyle.Information, "Advertencia")
                                Exit Sub


                            End If
                        End If

                    End If



                End If 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)-FIN

                If Me.txtCliente.pCodigo = 11731 Or Me.txtCliente.pCodigo = 30507 Or Me.txtCliente.pCodigo = 51991 Then
                    ' Si no se proporciona los campos correctos del cliente y codigo de predespacho se cierra la ventana
                    '===========================23-02-2011 azorrillap
                    Dim obrBulto As New brBulto
                    With dgPreDespachos.CurrentRow.DataBoundItem
                        .PNCCLNT = Me.txtCliente.pCodigo
                        .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                        .PSCDVSN = UcDivision_Cmb011.Division
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .PNCPLNDV = UcPLanta_Cmb011.Planta
                    End With
                    'BUSCAMOS SI EXISTE EL BULTO A DESPACHAR EN OTRAS PLANTAS
                    dgPreDespachos.CurrentRow.DataBoundItem.PNNRGUSA = obrBulto.ObtenerGuiaSalidaPorCodPreDespacho(dgPreDespachos.CurrentRow.DataBoundItem)
                    If dgPreDespachos.CurrentRow.DataBoundItem.PNNRGUSA = -1 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If

                    If dgPreDespachos.CurrentRow.DataBoundItem.PNNRGUSA <> 0 Then
                        MessageBox.Show("El Despacho se generó satisfactoriamente." & vbNewLine & "Nro. Guía : " & dgPreDespachos.CurrentRow.DataBoundItem.PNNRGUSA.ToString, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pActualizarInformacion()
                        Exit Sub
                    End If
                    '===========================23-02-2011 azorrillap
                End If

                'SI EXISTE NR DE GUIA DE SALIDA EN OTRAS PLANTA SE COPY SUS DATOS
              

                'COMENTADO ACTIVAR LUEGO
                '==============
                If Me.UcCompania_Cmb011.CCMPN_CodigoCompania = "EZ" Then
                    Dim strMensaje As String = ""

 

                    '<[AHM]>
                    Dim mensaje = ""
                    If (Not (New brBulto).ValidarLimiteCredito(Me.UcCompania_Cmb011.CCMPN_CodigoCompania, txtCliente.pCodigo, mensaje)) Then
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    '</[AHM]>
                End If

                '==============
                Dim pnFechaBulto As Decimal = 0
                Dim oDtFechaBulto As New DataTable
                Dim drBulto As DataRow
                oDtFechaBulto.Columns.Add("Fecha", GetType(Decimal))



                For Each obe As beBulto In dgPreDespachoBultos.DataSource
                    drBulto = oDtFechaBulto.NewRow()
                    drBulto(0) = obe.PNFREFFW
                    oDtFechaBulto.Rows.Add(drBulto)
                Next
                Dim Dtw As New DataView(oDtFechaBulto)
                Dtw.Sort = "Fecha Desc"

                pnFechaBulto = Dtw.Table.Rows(0).Item(0)

                Dim fCrearDespacho As frmCrearDespacho = New frmCrearDespacho
                With fCrearDespacho
                    .pCCMPN_Compania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    .pCDVSN_CodDivision = Me.UcDivision_Cmb011.Division
                    .pCPLNDV_CodigoPlanta = Me.UcPLanta_Cmb011.Planta
                    .pCodigoCliente_CCLNT = txtCliente.pCodigo
                    .pNroControl_NROCTL = dgPreDespachos.CurrentRow.DataBoundItem.PNNROCTL
                    .intFechaBultos = pnFechaBulto
                    .ShowDialog()
                    .Dispose()
                    fCrearDespacho = Nothing
                End With
            Else
                MessageBox.Show("Debe seleccionar por lo menos un Bulto", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            pActualizarInformacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub bshgCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub bshgAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgAgregar.Click
        Try
            Call pAgregarBultoPreDespacho()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bshgElimnar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgElimnar.Click
        Try
            Call pDesmarcarBultoPreDespacho()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bshgStatusOcultarPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Suspend layout changes until all splitter properties have been updated
        kryptonSplitContainerHorizontal.SuspendLayout()
        ' Is the left header group currently expanded?
        If kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.None Then
            ' Make the left panel of the splitter fixed in size
            kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.Panel1
            kryptonSplitContainerHorizontal.IsSplitterFixed = True
            ' Remember the current height of the header group
            _widthLeftRight = hgPreDespacho.Width
            ' We have not changed the orientation of the header yet, so the width of 
            ' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer = hgPreDespacho.PreferredSize.Height
            ' Make the header group fixed just as the new height
            kryptonSplitContainerHorizontal.Panel1MinSize = newWidth
            kryptonSplitContainerHorizontal.SplitterDistance = newWidth
            ' Change header to be vertical and button to near edge
            bshgStatusOcultarPreDespacho.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            bshgStatusOcultarPreDespacho.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight

            hgPreDespacho.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            hgPreDespacho.ButtonSpecs(0).Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Else
            ' Make the bottom panel not-fixed in size anymore
            kryptonSplitContainerHorizontal.FixedPanel = FixedPanel.None
            kryptonSplitContainerHorizontal.IsSplitterFixed = False
            ' Put back the minimise size to the original
            kryptonSplitContainerHorizontal.Panel1MinSize = 25
            ' Calculate the correct splitter we want to put back
            kryptonSplitContainerHorizontal.SplitterDistance = _widthLeftRight
            ' Change header to be horizontal and button to far edge
            bshgStatusOcultarPreDespacho.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            bshgStatusOcultarPreDespacho.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            hgPreDespacho.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            hgPreDespacho.ButtonSpecs(0).Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
        End If
        kryptonSplitContainerHorizontal.ResumeLayout()
    End Sub

    Private Sub bshgStatusOcultarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgStatusOcultarItems.Click
        ' Suspend layout changes until all splitter properties have been updated
        kryptonSplitContainerVertical.SuspendLayout()
        ' Is the bottom right header group currently expanded?
        If kryptonSplitContainerVertical.FixedPanel = FixedPanel.None Then
            ' Make the bottom panel of the splitter fixed in size
            kryptonSplitContainerVertical.FixedPanel = FixedPanel.Panel2
            kryptonSplitContainerVertical.IsSplitterFixed = True
            ' Remember the current height of the header group (to restore later)
            _heightUpDown = hgItemsBulto.Height
            ' Find the new height to use for the header group
            Dim newHeight As Int32 = hgItemsBulto.PreferredSize.Height
            ' Make the header group fixed to the new height
            kryptonSplitContainerVertical.Panel2MinSize = newHeight
            kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height
        Else
            ' Make the bottom panel not-fixed in size anymore
            kryptonSplitContainerVertical.FixedPanel = FixedPanel.None
            kryptonSplitContainerVertical.IsSplitterFixed = False

            ' Put back the minimise size to the original
            kryptonSplitContainerVertical.Panel2MinSize = 450

            ' Calculate the correct splitter we want to put back
            kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height '- _heightUpDown - kryptonSplitContainerVertical.SplitterWidth
        End If
        kryptonSplitContainerVertical.ResumeLayout()
    End Sub

    Private Sub bshgStatusOcultarSubItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgStatusOcultarSubItems.Click
        KryptonSplitContainer1.SuspendLayout()
        If KryptonSplitContainer1.FixedPanel = FixedPanel.None Then
            ' Make the bottom panel of the splitter fixed in size
            KryptonSplitContainer1.FixedPanel = FixedPanel.Panel2
            KryptonSplitContainer1.IsSplitterFixed = True
            ' Remember the current height of the header group (to restore later)
            _heightUpDown = hgSubItemsBulto.Height
            ' Find the new height to use for the header group
            Dim newHeight As Int32 = hgSubItemsBulto.PreferredSize.Height
            ' Make the header group fixed to the new height
            KryptonSplitContainer1.Panel2MinSize = newHeight
            KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
        Else
            ' Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer1.FixedPanel = FixedPanel.None
            KryptonSplitContainer1.IsSplitterFixed = False

            ' Put back the minimise size to the original
            KryptonSplitContainer1.Panel2MinSize = 200

            ' Calculate the correct splitter we want to put back
            KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height '- _heightUpDown - kryptonSplitContainerVertical.SplitterWidth
        End If
        KryptonSplitContainer1.ResumeLayout()
    End Sub

    

    Private Sub dgPreDespachoBultos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPreDespachoBultos.CurrentCellChanged

        Try
            'If booStatus Then
            '    booStatus = False
            '-- Lleno el detalle Items
            RemoveHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
            Call pListarPreDespachoItemBultos()
            AddHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
            '-- Lleno el detalle SubItems
            Call pListarPreDespachoSubItemBultos()
            'booStatus = True
            'End If
            ' AsignarTmpPreDespacho() 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub dgPreDespachoItemBulto_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPreDespachoItemBulto.CurrentCellChanged
        Try
           
            Call pListarPreDespachoSubItemBultos()
            'booStatus = True
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub frmPreDespacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("PreDespachoClienteCodigo", GetType(System.String)), intTemp)

            Dim ClientePK As RANSA.Controls.Cliente.TD_ClientePK = New RANSA.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)

            objAppConfig = Nothing

            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            dgGuiasRemision.AutoGenerateColumns = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tsmiAgregarBultoPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregarBultoPreDespacho.Click

        Try
            Call pAgregarBultoPreDespacho()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmiDesmarcarBultoPreDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDesmarcarBultoPreDespacho.Click
        Try
            Call pDesmarcarBultoPreDespacho()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
    End Sub
#End Region

    
    Private Sub bshgGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bshgGuiaRemision.Click

        Dim ofrmGenerarGuiaRemision As New frmGenerarGuiaRemisionSAT
        With ofrmGenerarGuiaRemision
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNROCTL = dgPreDespachos.CurrentRow.DataBoundItem.PNNROCTL()
            .EsPredespacho = True
            .EsRecojo = False
        End With
        If ofrmGenerarGuiaRemision.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Call pActualizarInformacion()
        End If

    End Sub

    Private Sub VistraPreviaGuiaRemision_X_Guia(ByVal oDs As DataSet)
        Dim obeGuiaRemision As beGuiaRemision = New beGuiaRemision
        Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Dim obrGuiaRemision As New DespachoSAT.brGuiasRemision

        With obeGuiaRemision
            .PNCCLNT = Me.txtCliente.pCodigo
            .PSNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        End With
        oDs = obrGuiaRemision.fdstDataGuiaRemision(obeGuiaRemision)

        If oDs Is Nothing OrElse oDs.Tables.Count = 0 OrElse oDs.Tables.Item(0).Rows.Count = 0 Then Exit Sub
        ' Cargamos los valores de los parametros de impresión de la Guia
        Select Case obeGuiaRemision.PSMODELO
            Case "M1"
                rdocGuiaRemision = New rptGuiaRemisionM01
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M2"
                rdocGuiaRemision = New rptGuiaRemisionM02
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M3"
                rdocGuiaRemision = New rptGuiaRemisionM03
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M4"
                rdocGuiaRemision = New rptGuiaRemisionM04
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5"
                rdocGuiaRemision = New rptGuiaRemisionM05
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case "M5A"
                rdocGuiaRemision = New rptGuiaRemisionM05A
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M5B"
                rdocGuiaRemision = New rptGuiaRemisionM05B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M6"
                rdocGuiaRemision = New rptGuiaRemisionM06
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M7"
                rdocGuiaRemision = New rptGuiaRemisionM07
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M9"
                rdocGuiaRemision = New rptGuiaRemisionM09
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M9B"
                rdocGuiaRemision = New rptGuiaRemisionM09B
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case "M10"
                rdocGuiaRemision = New rptGuiaRemisionM10
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Case "M12"
                rdocGuiaRemision = New rptGuiaRemisionM012
                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case Else
                rdocGuiaRemision = New rptGuiaRemisionM01
        End Select
        rdocGuiaRemision.SetDataSource(oDs)
        rdocGuiaRemision.Refresh()
        'Imprime la Guía de Remisión
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = rdocGuiaRemision
            .ShowDialog()
        End With
    End Sub

    Private Sub MostrarGuiasRemision()
        If (dgPreDespachos.CurrentRow IsNot Nothing) Then
            Dim obeGuiaFiltro As New beGuiaRemision
            Dim obrGuiaRemision As New brGuiasRemision
            Dim oListbeGuiaRemision As New List(Of beGuiaRemision)
            obeGuiaFiltro.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            obeGuiaFiltro.PSCDVSN = Me.UcDivision_Cmb011.Division
            obeGuiaFiltro.PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            obeGuiaFiltro.PNCCLNT = txtCliente.pCodigo
            obeGuiaFiltro.PNNROCTL = CType(dgPreDespachos.CurrentRow.DataBoundItem, beBulto).PNNROCTL
            oListbeGuiaRemision = obrGuiaRemision.fnListGuiasRemisionSAT_PredesPacho(obeGuiaFiltro)
            'KryptonSplitContainer2
            dgGuiasRemision.DataSource = oListbeGuiaRemision
            If oListbeGuiaRemision.Count = 0 Then
                KryptonSplitContainer2.SuspendLayout()
                'hgSubItemsBulto.Visible = False
                If KryptonSplitContainer2.FixedPanel = FixedPanel.None Then
                    ' Make the bottom panel of the splitter fixed in size
                    KryptonSplitContainer2.FixedPanel = FixedPanel.Panel2
                    KryptonSplitContainer2.IsSplitterFixed = True
                    ' Remember the current height of the header group (to restore later)
                    ' _heightUpDown = hgGuiaRemision.Height
                    ' Find the new height to use for the header group
                    Dim newHeight As Int32 = dgGuiasRemision.PreferredSize.Height / 2
                    ' Make the header group fixed to the new height
                    KryptonSplitContainer2.Panel2MinSize = newHeight
                    KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height
                End If
            Else
                hgSubItemsBulto.Visible = True
                dgGuiasRemision.Visible = True
                If KryptonSplitContainer2.FixedPanel = FixedPanel.None Then
                Else
                    ' Make the bottom panel not-fixed in size anymore
                    KryptonSplitContainer2.FixedPanel = FixedPanel.None
                    KryptonSplitContainer2.IsSplitterFixed = False

                    ' Put back the minimise size to the original
                    KryptonSplitContainer2.Panel2MinSize = 200

                    ' Calculate the correct splitter we want to put back
                    KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height '- _heightUpDown - kryptonSplitContainerVertical.SplitterWidth

                End If
            End If
            KryptonSplitContainer2.ResumeLayout()

        End If
    End Sub

    Private Sub bsaAnularGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularGR.Click
        Try
            Call pProceso_EliminarGuiaSalida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub pProceso_EliminarGuiaSalida()
        If dgGuiasRemision.CurrentCellAddress.Y < 0 Then Exit Sub
        If dgPreDespachos.RowCount <= 0 Then Exit Sub
        If Not mfblnPreguntas(enumPregVarios.GREMISION_EliminarGuiaRemision) Then Exit Sub
        Dim obrGuiasRemision As New brGuiasRemision
        Dim obeGuiaRemision As New beGuiaRemision
        With obeGuiaRemision
            .PNCCLNT = txtCliente.pCodigo
            .PNNROCTL = Me.dgPreDespachos.CurrentRow.Cells("M_NROCTL").Value
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            .PNCPLNDV = UcPLanta_Cmb011.Planta
            .PSCUSCRT = objSeguridadBN.pUsuario
        End With
        If obrGuiasRemision.fblnAnularGuiaRemisionSAT_PreDespacho(obeGuiaRemision) Then
            booStatus = False
            Call pListarPreDespachos()
            booStatus = True
        End If

    End Sub

 
    
    Private Sub bsaVistaPreviaGR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVistaPreviaGR.Click
        Try
            VistraPreviaGuiaRemision_X_Guia(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.Click

        ' Suspend layout changes until all splitter properties have been updated
        KryptonSplitContainer2.SuspendLayout()
        ' Is the bottom right header group currently expanded?
        If KryptonSplitContainer2.FixedPanel = FixedPanel.None Then
            ' Make the bottom panel of the splitter fixed in size
            KryptonSplitContainer2.FixedPanel = FixedPanel.Panel2
            KryptonSplitContainer2.IsSplitterFixed = True
            ' Remember the current height of the header group (to restore later)
            ' _heightUpDown = hgItemsBulto.Height
            ' Find the new height to use for the header group
            Dim newHeight As Int32 = hgPreDespacho.PreferredSize.Height
            ' Make the header group fixed to the new height
            KryptonSplitContainer2.Panel2MinSize = newHeight
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height
        Else
            ' Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer2.FixedPanel = FixedPanel.None
            KryptonSplitContainer2.IsSplitterFixed = False

            ' Put back the minimise size to the original
            KryptonSplitContainer2.Panel2MinSize = 450

            ' Calculate the correct splitter we want to put back
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height '- _heightUpDown - kryptonSplitContainerVertical.SplitterWidth
        End If
        KryptonSplitContainer2.ResumeLayout()

    End Sub

    Private Sub dgPreDespachos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPreDespachos.CurrentCellChanged

        Try
            'If booStatus Then
            '    booStatus = False
            RemoveHandler dgPreDespachoBultos.CurrentCellChanged, AddressOf dgPreDespachoBultos_CurrentCellChanged
            Call pListarPreDespachosBultos()
            AddHandler dgPreDespachoBultos.CurrentCellChanged, AddressOf dgPreDespachoBultos_CurrentCellChanged

            '-- Lleno el detalle Items
            RemoveHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
            Call pListarPreDespachoItemBultos()
            AddHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged

            '-- Lleno el detalle SubItems
            Call pListarPreDespachoSubItemBultos()

            Call MostrarGuiasRemision()

            'booStatus = True
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub txtCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.Load

    End Sub

    Private Sub btnAgregarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedido.Click
        Try
            Dim existePedido As Boolean = False
            For bulto As Integer = 0 To dgPreDespachoItemBulto.RowCount - 1
                If Trim(dgPreDespachoItemBulto.Rows(bulto).Cells("PSNRPDTS").Value()) <> String.Empty Then
                    existePedido = True
                    Exit For
                End If
            Next bulto

            If existePedido Then
                If MsgBox("El bulto seleccionado ya tiene asignados pedidos, ¿desea asignar nuevamente los pedidos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Consultas") = MsgBoxResult.Yes Then
                    EliminarBulto()
                Else
                    Exit Sub
                End If
            End If

            Dim pedidoTrasladoBulto As New frmPedidoTrasladoBulto
            Dim parametro As New bePedidoTrasladoxBulto
            With parametro
                .Pncclnt = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCCLNT 'Cliente
                .Psccmpn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCCMPN 'Compañía
                .Pscdvsn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCDVSN 'División
                .Pncplndv = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCPLNDV 'Planta
                .Pscreffw = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCREFFW 'Cód. Bulto
                .Pnnseqin = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNNSEQIN 'Nro. Secuencia
                .psnrpdts = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSNRPDTS 'Nro. Pedido
            End With

            Dim materialXPedido As New DataTable("materialXPedido")
            materialXPedido.Columns.Add("IN_ID", Type.GetType("System.String"))
            materialXPedido.Columns.Add("IN_QBLTSR", Type.GetType("System.Double"))

            If detalleBultoXPedido.Rows.Count > 0 Then
                Dim tmpPedido As DataTable = detalleBultoXPedido.DefaultView.ToTable(True, "IN_ID")
                For Each rowTmpPedido As DataRow In tmpPedido.Rows
                    Dim cantidad As Double = 0

                    For Each rowPedido As DataRow In detalleBultoXPedido.Rows
                        If rowTmpPedido("IN_ID") = rowPedido("IN_ID") Then
                            cantidad = cantidad + CDbl(rowPedido("IN_QBLTSR"))
                        End If
                    Next rowPedido

                    Dim dataRow As DataRow
                    dataRow = materialXPedido.NewRow()
                    dataRow.Item("IN_ID") = rowTmpPedido("IN_ID")
                    dataRow.Item("IN_QBLTSR") = cantidad
                    materialXPedido.Rows.Add(dataRow)

                Next rowTmpPedido
            End If

            With pedidoTrasladoBulto
                .parametro = parametro
                .materialXPedido = materialXPedido
                .ShowDialog()
                AdicionarBulto(.detalleBultoXPedido)
                .Dispose()
                pedidoTrasladoBulto = Nothing
            End With
        Catch ex As Exception
            MsgBox("Debe seleccionar un bulto.", MsgBoxStyle.Exclamation, "Advertencia")
        End Try

        RemoveHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
        Call pListarPreDespachoItemBultos()
        AddHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
        Call pListarPreDespachoSubItemBultos()
        ''AsignarTmpPreDespacho()
    End Sub

    Private Sub btnQuitarrPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarrPedido.Click
        Try
            If MsgBox("¿Esta seguro que desea quitar el Pedido T.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                EliminarBulto()
                RemoveHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
                Call pListarPreDespachoItemBultos()
                AddHandler dgPreDespachoItemBulto.CurrentCellChanged, AddressOf dgPreDespachoItemBulto_CurrentCellChanged
                Call pListarPreDespachoSubItemBultos()
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un bulto.", MsgBoxStyle.Exclamation, "Advertencia")
        End Try

    End Sub

    Private Sub EliminarBulto()
        Dim parametroPedido As New bePedidoTrasladoxBulto
        With parametroPedido
            .Pncclnt = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCCLNT 'Cliente
            .Psccmpn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCCMPN 'Compañía
            .Pscdvsn = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCDVSN 'División
            .Pncplndv = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNCPLNDV 'Planta
            .Pscreffw = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSCREFFW 'Cód. Bulto
            .Pnnseqin = dgPreDespachoBultos.CurrentRow.DataBoundItem.PNNSEQIN 'Nro. Secuencia
            .psnrpdts = dgPreDespachoBultos.CurrentRow.DataBoundItem.PSNRPDTS 'Nro. Pedido
        End With

        Dim parametroBulto As New beQuitarBulto
        For bulto As Integer = 0 To dgPreDespachoItemBulto.RowCount - 1
            With parametroBulto
                .cidpaq = dgPreDespachoItemBulto.Rows(bulto).Cells("PSCIDPAQ").Value() 'Cód. Identificación de paquete
                .norcml = dgPreDespachoItemBulto.Rows(bulto).Cells("D_NORCML").Value() 'Nro. OC
                .nritoc = dgPreDespachoItemBulto.Rows(bulto).Cells("D_NRITOC").Value() 'Nro. Ítem
                .nrosec = dgPreDespachoItemBulto.Rows(bulto).Cells("PSNROSEC").Value() 'Nro. Ítem del Pedido de traslado
                parametroPedido.psnrpdts = dgPreDespachoItemBulto.Rows(bulto).Cells("PSNRPDTS").Value() 'Nro. Pedido
                .qbltsr = dgPreDespachoItemBulto.Rows(bulto).Cells("D_QBLTSR").Value() 'Saldo cantidad bulto
                .usuari = objSeguridadBN.pUsuario 'Usuario del sistema
            End With

            Dim pedidoTraslado As New brPreDespacho
            pedidoTraslado.parametroPedido = parametroPedido
            pedidoTraslado.parametroBulto = parametroBulto
            pedidoTraslado.QuitarBulto()
        Next bulto
    End Sub

    Private Sub AdicionarBulto(ByVal bultoXPedido As DataTable)
        Dim obrBulto As New brBulto
        Dim obeBulto As New beBulto
        For Each despacho As DataRow In bultoXPedido.Rows
            obeBulto = New beBulto()
            obeBulto.PSCCMPN = despacho.Item("IN_CCMPN").ToString()
            obeBulto.PSCDVSN = despacho.Item("IN_CDVSN").ToString()
            obeBulto.PNCPLNDV = despacho.Item("IN_CPLNDV").ToString()
            obeBulto.PNCCLNT = despacho.Item("IN_CCLNT").ToString()
            obeBulto.PSCREFFW = despacho.Item("IN_CREFFW").ToString()
            obeBulto.PNNSEQIN = despacho.Item("IN_NSEQIN").ToString()
            obeBulto.PSCIDPAQ = despacho.Item("IN_CIDPAQ").ToString()
            obeBulto.PSNORCML = despacho.Item("IN_NORCML").ToString()
            obeBulto.PNNRITOC = despacho.Item("IN_NRITOC").ToString()
            obeBulto.PNQBLTSR = despacho.Item("IN_QBLTSR").ToString()
            obeBulto.PSNRPDTS = despacho.Item("IN_NRPDTS").ToString()
            obeBulto.PSNROSEC = despacho.Item("IN_NROSEC").ToString()
            obeBulto.PSUSUARIO = despacho.Item("IN_USUARI").ToString()
            obeBulto.CLARSG = despacho.Item("IN_CLARSG").ToString()
            obeBulto.NROONU = despacho.Item("IN_NROONU").ToString()
            obeBulto.TPOEMB = despacho.Item("IN_TPOEMB").ToString()
            obrBulto.ActualizarDetalleBultoPedidoTraslado(obeBulto)
        Next
    End Sub
End Class
