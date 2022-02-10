Imports Ransa.NEGO
Imports RANSA.Utilitario
Imports Ransa.DAO.OrdenCompra
Imports RANSA.TYPEDEF.OrdenCompra.ItemOC

Public Class frmInterfazCorpesa

    Private strCompania As String = ""
    Private strDivision As String = ""
    Private dblPlanta As Double = 0
    Private intCCLNT As Int64 = 0
    Private strNORCML As String

    Public WriteOnly Property pCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    Public WriteOnly Property pNORCML_NroOrdenCompra() As String
        Set(ByVal value As String)
            strNORCML = value
        End Set
    End Property

   
    Public WriteOnly Property pCompania() As String
        Set(ByVal value As String)
            strCompania = value
        End Set
    End Property
    Public WriteOnly Property pDivision() As String
        Set(ByVal value As String)
            strDivision = value
        End Set
    End Property
    Public WriteOnly Property pPlanta() As Double
        Set(ByVal value As Double)
            dblPlanta = value
        End Set
    End Property


    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim oblInterfaseCorpesa As New InterfaseCorpesa
        Dim oParametros As New Hashtable
        oParametros.Add("CodCliente", "3")
        oParametros.Add("NrDoc", Me.txtNroDocumentoES.Text)
        Dim obeInformacionCarga As New CorpesaWsLib.InformacionCarga
        Try
            obeInformacionCarga = oblInterfaseCorpesa.fdtObtenerCabeceraDocumento(oParametros).Item(0)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Exit Sub
        End Try
        Dim obrBulto As New brBulto
        Dim obeBulto As New Ransa.TYPEDEF.beBulto
        With obeBulto
            .PSCCMPN = strCompania
            .PSCDVSN = strDivision
            .PNCPLNDV = dblPlanta
            .PNCCLNT = intCCLNT
            .PSCREEMB = obeInformacionCarga.Codigocarga
            .PSCREFFW = obeInformacionCarga.Codigocarga
            .PNNSEQIN = 1
        End With

        If obrBulto.fbolProcesadoPorInterfaz(obeBulto) Then
            MessageBox.Show("El Nro. de Bulto :" & obeInformacionCarga.Codigocarga & " ya fue procesado", "Información", MessageBoxButtons.OK)
            Exit Sub
        End If
      

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
        Dim objOCTemp As New Ransa.TYPEDEF.beOrdenCompra
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
            Dim obeOrdenCompra As New Ransa.TYPEDEF.beOrdenCompra
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
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    'Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click

    '    Dim oblInterfaseCorpesa As New InterfaseCorpesa
    '    Dim oParametros As New Hashtable
    '    oParametros.Add("CodCliente", "3")
    '    oParametros.Add("FechaIni", Me.DateTimePicker1.Value.Date)
    '    oParametros.Add("FechaFin", Me.DateTimePicker2.Value.Date)
    '    dtgBultos.DataSource = oblInterfaseCorpesa.fdtListObtenerCabeceraDocumento(oParametros)
    'End Sub
 
   

    'Private Sub dtgBultos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    dtgDetalleBulto.DataSource = Nothing
    '    'dtgDetalleBulto.DataSource = Me.dtgBultos.CurrentRow.DataBoundItem.DespachoDetalleCollection
    '    dtgDetalleBulto.DataSource = Me.dtgBultos.CurrentRow.DataBoundItem.InformacionCargaDetalle()
    'End Sub
End Class
