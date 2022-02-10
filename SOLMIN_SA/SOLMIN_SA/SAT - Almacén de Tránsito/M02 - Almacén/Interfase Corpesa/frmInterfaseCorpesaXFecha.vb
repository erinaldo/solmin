
Imports Ransa.NEGO
Imports RANSA.Utilitario
Imports Ransa.DAO.OrdenCompra
Imports RANSA.TYPEDEF.OrdenCompra.ItemOC


Public Class frmInterfaseCorpesaXFecha


    Private strCompania As String
    Public Property pCompania() As String
        Get
            Return strCompania
        End Get
        Set(ByVal value As String)
            strCompania = value
        End Set
    End Property

    Private strDivision As String
    Public Property pDivision() As String
        Get
            Return strDivision
        End Get
        Set(ByVal value As String)
            strDivision = value
        End Set
    End Property



    Private dblPlanta As Integer
    Public Property pPlanta() As Integer
        Get
            Return dblPlanta
        End Get
        Set(ByVal value As Integer)
            dblPlanta = value
        End Set
    End Property


    Private intCCLNT As Decimal
    Public Property pCliente() As Decimal
        Get
            Return intCCLNT
        End Get
        Set(ByVal value As Decimal)
            intCCLNT = value
        End Set
    End Property
 
    Private Sub dtgBultos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgBultos.SelectionChanged
        dtgDetalleBulto.DataSource = Nothing
        dtgDetalleBulto.AutoGenerateColumns = False
        dtgDetalleBulto.DataSource = Me.dtgBultos.CurrentRow.DataBoundItem.DespachoDetalleCollection
        'dtgDetalleBulto.DataSource = Me.dtgBultos.CurrentRow.DataBoundItem.InformacionCargaDetalle()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim oblInterfaseCorpesa As New InterfaseCorpesa
        Dim oParametros As New Hashtable
        oParametros.Add("CodCliente", "3")
        oParametros.Add("FechaIni", Me.dtpFecIni.Value.Date)
        oParametros.Add("FechaFin", Me.dtpFecFin.Value.Date)
        dtgBultos.AutoGenerateColumns = False
        dtgBultos.DataSource = oblInterfaseCorpesa.fdtListObtenerCabeceraDocumento(oParametros)

    End Sub

    Private Sub dtgDetalleBulto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleBulto.CellContentClick
        If Me.dtgDetalleBulto.CurrentCellAddress.Y = -1 Then Exit Sub

        If Me.dtgDetalleBulto.Columns(e.ColumnIndex).Name = "Importar" Then

            If dtgDetalleBulto.CurrentRow.Cells("Estado").Value = 1 Then ' indica que el bulto ya fue procesado
                Exit Sub
            End If

            Dim oblInterfaseCorpesa As New InterfaseCorpesa
            Dim oParametros As New Hashtable
            oParametros.Add("CodCliente", "3")
            oParametros.Add("NrDoc", Me.dtgDetalleBulto.CurrentRow.Cells("CodBarra").Value)
            Dim obeInformacionCarga As New CorpesaWsLib.InformacionCarga
            Try
                obeInformacionCarga = oblInterfaseCorpesa.fdtObtenerCabeceraDocumento(oParametros).Item(0)
            Catch ex As Exception
                HelpClass.ErrorMsgBox()
                Exit Sub
            End Try
            Dim obrBulto As New brBulto
            Dim obeBulto As New Ransa.TypeDef.beBulto
            With obeBulto
                .PSCCMPN = strCompania
                .PSCDVSN = strDivision
                .PNCPLNDV = dblPlanta
                .PNCCLNT = intCCLNT
                .PSCREEMB = obeInformacionCarga.Codigocarga
                .PSCREFFW = obeInformacionCarga.Codigocarga
                .PNNSEQIN = 1
            End With

            'If obrBulto.fbolProcesadoPorInterfaz(obeBulto) Then
            '    MessageBox.Show("El Nro. de Bulto :" & obeInformacionCarga.Codigocarga & " ya fue procesado", "Información", MessageBoxButtons.OK)
            '    Exit Sub
            'End If



            Dim ofrm As New frmGenerarBultoN

            'Si es una devolución se genera nuevo bulto
            If obrBulto.floObjtenerBulto(obeBulto).PSCREFFW <> "" Then
                ofrm.txtCodigoRecepcion.Text = ""
            Else
                ofrm.txtCodigoRecepcion.Text = obeInformacionCarga.Codigocarga
            End If
            ofrm.txtCodigoEmbarcador.Text = obeInformacionCarga.Codigocarga
            ofrm.txtCodigoEmbarcador.Enabled = False
            If obeInformacionCarga.descripcion.ToString.Trim.Length > 40 Then
                ofrm.txtDescripcionWaybill.Text = obeInformacionCarga.descripcion.Trim.Substring(0, 40)
            Else
                ofrm.txtDescripcionWaybill.Text = obeInformacionCarga.descripcion
            End If
            ofrm.txtCantidadRecibida.Text = obeInformacionCarga.Cantidadrecibida
            ofrm.txtVolumenBulto.Text = obeInformacionCarga.volumenCarga
            ofrm.txtUnidadVolumen.Text = obeInformacionCarga.Unidadvolumen
            ofrm.txtPesoBulto.Text = obeInformacionCarga.Pesocarga
            ofrm.txtUnidadPeso.Text = obeInformacionCarga.Unidadpeso
            ofrm.txtNroGuiaProveedor.Text = obeInformacionCarga.GuiaPluspetrol
            ofrm.pNORCML_NroOrdenCompra = obeInformacionCarga.GuiaPluspetrol
            ofrm.txtTipoBulto.Text = obeInformacionCarga.Tipocarga
            ofrm.pCompania = strCompania
            ofrm.pEstado = "RETORNO"
            ofrm.pDivision = strDivision
            ofrm.pPlanta = dblPlanta
            ofrm.pCodigoCliente_CCLNT = intCCLNT
            ofrm.pNORCML_NroOrdenCompra = obeInformacionCarga.GuiaPluspetrol
            Dim lstItems As New List(Of TD_ItemOCForWayBill)
            '==========Informacion a Guardar
            Dim objOCTemp As New Ransa.TypeDef.beOrdenCompra
            With objOCTemp
                .PNCCLNT = intCCLNT
                .PSNORCML = obeInformacionCarga.GuiaPluspetrol
                .PSTPOOCM = "OC"
                .FechaOrdenDeCompra = Now.Date
                .PNCPRVCL = 67652 'Dato pendiente PLUSPETROL
                .PSTDSCML = obeInformacionCarga.descripcion
                If .PSTDSCML.ToString().Trim().Length > 50 Then
                    .PSTDSCML = .PSTDSCML.Substring(0, 50)
                End If
                .PSTCMAEM = ""
                .PSTTINTC = "LOC"
                .PSNREFCL = ""
                .PSTPAGME = ""
                .PSREFDO1 = ""
                .PNNTPDES = 0
                .PNCMNDA1 = 0
                .PSTEMPFAC = ""
                .PSTNOMCOM = ""
                .PSTCTCST = ""
                .PSCREGEMB = ""
                .PNCMEDTR = 0
                .PSTDEFIN = obeInformacionCarga.Llegadadestino
                Decimal.TryParse(0, .PNIVCOTO)
                Decimal.TryParse(0, .PNIVTOCO)
                Decimal.TryParse(0, .PNIVTOIM)
                .PSTDAITM = obeInformacionCarga.Codigocarga

            End With
            Dim obrOrdenDeCompra As New brOrdenDeCompra
            If obrOrdenDeCompra.InsertarOrdenDeCompra(objOCTemp) Then
                Dim obeOrdenCompra As New Ransa.TypeDef.beOrdenCompra
                obeOrdenCompra.PNCCLNT = Decimal.Parse(intCCLNT)
                obeOrdenCompra.PSNORCML = obeInformacionCarga.GuiaPluspetrol
                obeOrdenCompra.PSTDITES = obeInformacionCarga.descripcion.Trim
                If obeOrdenCompra.PSTDITES.ToString().Trim().Length > 100 Then
                    obeOrdenCompra.PSTDITES = obeOrdenCompra.PSTDITES.Substring(0, 100)
                End If
                obeOrdenCompra.PNQCNTIT = obeInformacionCarga.Cantidadrecibida
                obeOrdenCompra.PSTDITIN = obeInformacionCarga.descripcion
                If obeOrdenCompra.PSTDITIN.ToString().Trim().Length > 100 Then
                    obeOrdenCompra.PSTDITIN = obeOrdenCompra.PSTDITIN.Substring(0, 100)
                End If
                obeOrdenCompra.PSTCITCL = ""
                obeOrdenCompra.PSTLUGEN = obeInformacionCarga.Llegadadestino
                If obeOrdenCompra.PSTLUGEN.ToString().Trim().Length > 50 Then
                    obeOrdenCompra.PSTLUGEN = obeOrdenCompra.PSTLUGEN.Substring(0, 50)
                End If

                obeOrdenCompra.PSTUNDIT = obeInformacionCarga.Tipocarga
                If obeOrdenCompra.PSTUNDIT.ToString().Trim().Length > 10 Then
                    obeOrdenCompra.PSTUNDIT = obeOrdenCompra.PSTUNDIT.Substring(0, 10)
                End If
                obeOrdenCompra.PSTCTCST = ""
                obeOrdenCompra.PSTRFRN1 = ""
                obeOrdenCompra.PSTRFRN2 = ""
                obeOrdenCompra.PNIVUNIT = 0
                obeOrdenCompra.PNIVTOIT = 0
                obeOrdenCompra.PSTCITPR = ""
                obeOrdenCompra.PSCPTDAR = ""
                obeOrdenCompra.PNFMPIME = 0
                obeOrdenCompra.PSTLUGOR = ""
                obeOrdenCompra.PNQTOLMIN = 0
                obeOrdenCompra.PNQTOLMAX = 0
                obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
                obeOrdenCompra.PSCULUSA = objSeguridadBN.pUsuario
                Dim intNrItem As Integer = 0
                intNrItem = obrOrdenDeCompra.InsertarDetalleOrdenDeCompra(obeOrdenCompra)
                If intNrItem <> 0 Then
                    Dim obeItemOC As New TD_ItemOCForWayBill()
                    ' ==========Informacion a Mostrar
                    obeItemOC.pNRITOC_NroItemOC = intNrItem
                    obeItemOC.pTDITES_DescripcionItem = obeOrdenCompra.PSTDITES
                    obeItemOC.pQCNREC_QtaRecibida = obeOrdenCompra.PNQCNTIT
                    obeItemOC.pTUNDIT_UnidadQta = obeOrdenCompra.PSTUNDIT
                    obeItemOC.pQPEPQT_Peso = obeInformacionCarga.Pesocarga
                    obeItemOC.pTUNPSO_UnidadPeso = obeInformacionCarga.Unidadpeso
                    obeItemOC.pQVOPQT_QtaVolumen = obeInformacionCarga.volumenCarga
                    obeItemOC.pTUNVOL_UnidadVolumen = obeInformacionCarga.Unidadvolumen
                    obeItemOC.pTDAITM_Observaciones = obeInformacionCarga.descripcion
                    obeItemOC.pTLUGEN_LugarDeEntrega = obeInformacionCarga.Llegadadestino
                    lstItems.Add(obeItemOC)
                Else
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            Else
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            ofrm.pItemsSelec = lstItems
            ofrm.poHasSubItems = New Hashtable()
            ofrm.ShowDialog()
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub


    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgDetalleBulto_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgDetalleBulto.DataBindingComplete
        Dim obrBulto As New brBulto
        Dim obeBulto As Ransa.TypeDef.beBulto
        Dim intRow As Integer = 0
        For Each obe As Object In Me.dtgDetalleBulto.DataSource
            obeBulto = New Ransa.TypeDef.beBulto
            With obeBulto
                .PSCCMPN = strCompania
                .PSCDVSN = strDivision
                .PNCPLNDV = dblPlanta
                .PNCCLNT = intCCLNT
                .PSCREEMB = obe.CodBarra
            End With

            If obrBulto.fbolProcesadoPorInterfaz(obeBulto) Then
                dtgDetalleBulto.Rows(intRow).Cells("Importar").Value = My.Resources.Enviado
                dtgDetalleBulto.Rows(intRow).Cells("Estado").Value = 1
            Else
                dtgDetalleBulto.Rows(intRow).Cells("Estado").Value = 0
            End If

            intRow += 1
        Next

    End Sub

    
End Class

