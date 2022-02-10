Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario


Public Class frmMantenimientoCuentaOC



#Region "Declaracion de variables"
    Public obeOrdenCompra As New beOrdenCompra
    Private obrOrdeCompra As New brOrdenDeCompra
    Public ActualizarDatos As Boolean = False
    Public Grabar As Boolean = False
    Public PNCCLNT As Decimal
    Private PNNSEQIN As Decimal = 0
    Public PsDesCliente As String = String.Empty
    Public Distribucion As Boolean = False
    Private Agregar As Boolean = False
    Private mlistOrdenDetalle As New List(Of beOrdenCompra)
    Private mlistAgregarOrdenDetalle As New List(Of beOrdenCompra)
    Private mlistOrdenEliminaDetalle As New List(Of beOrdenCompra)
#End Region

#Region "Procedimientos y Funciones"

    Private Sub VisualizarDatosOC()
        InicializarControles()
        txtOC.Text = obeOrdenCompra.PSNORCML.Trim
        cbxLugarEntrega.SelectedValue = obeOrdenCompra.PSTLUGEN.Trim
        txtCentroCosto.Text = obeOrdenCompra.PSTCTCST.Trim
        txtCostoAereo.Text = obeOrdenCompra.PSTCTCSA.Trim
        txtCostoFluvial.Text = obeOrdenCompra.PSTCTCSF.Trim
        txtCuentaAfectacion.Text = obeOrdenCompra.PSTCTAFE.Trim


        txtCeCoSAP.Text = obeOrdenCompra.PSCCNCOS
        txtOrdenSAP.Text = obeOrdenCompra.PSNORSAP
        txtNroGrafo.Text = obeOrdenCompra.PSNGFSAP
        txtCuentaMayor.Text = obeOrdenCompra.PSNCTAMA
        txtElementoPEP.Text = obeOrdenCompra.PSNELPEP



        DtFechaIni.Value = IIf(obeOrdenCompra.PSFINCVG.Trim.Length > 0, obeOrdenCompra.PSFINCVG, Date.Now)
        DtFechaFin.Value = IIf(obeOrdenCompra.PSFFINVG.Trim.Length > 0, obeOrdenCompra.PSFFINVG, Date.Now)
        PNNSEQIN = obeOrdenCompra.PNNSEQIN
        fnSelCuentasDetalle()

    End Sub

    Private Sub InicializarControles()
        txtCliente.Text = PsDesCliente
        txtOC.Text = ""
        cbxLugarEntrega.Text = ""
        txtCentroCosto.Text = ""
        txtCuentaAfectacion.Text = ""
        txtCostoAereo.Text = ""
        txtCostoFluvial.Text = ""


    End Sub

    Private Sub frmMantenimientoCuentaOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgCuentasDetalle.AutoGenerateColumns = False
        InicializarControles()
        pCargarCbxLugarEntrega()
        If (ActualizarDatos = True) Then
            VisualizarDatosOC()

            txtOC.Enabled = False
        Else
            txtOC.Enabled = True

        End If

        VisualizarCampos()
        txtOC.Focus()
    End Sub

    Private Function ValidaOrdenCompra() As String
        Dim obeOrdenCompra As New beOrdenCompra
        Dim mlistOrden As New List(Of beOrdenCompra)
        obrOrdeCompra = New brOrdenDeCompra
        Dim strMensaje As String = String.Empty
        obeOrdenCompra.PNCCLNT = PNCCLNT
        obeOrdenCompra.PSNORCML = txtOC.Text
        mlistOrden.Clear()
        mlistOrden = obrOrdeCompra.ObtenerOrdenDeCompra(obeOrdenCompra)
        If mlistOrden.Count = 0 Then
            strMensaje = "* Número de Orden de Compra no Existe"
        End If

        Return strMensaje
    End Function

    Private Function Validar() As String
        Dim strMensaje As String = String.Empty
        Dim intCont As Integer = 0
        If (txtOC.Text.Trim = "") Then
            strMensaje = "* Ingrese Orden de Compra"
            txtOC.Focus()
            Return strMensaje
        End If

        If Distribucion Then


            If DtFechaIni.Visible < DtFechaFin.Visible Then
                strMensaje = "* La fecha fin no puede ser menor que la fecha inicio"
                Return strMensaje
            End If
            If ActualizarDatos = True Then

                If dgCuentasDetalle.Rows.Count = 0 Then
                    strMensaje = "Debe ingresar detalle"
                    Return strMensaje
                End If
            End If
            strMensaje = ValidaPorcentaje()
            If strMensaje <> String.Empty Then
                Return strMensaje
            End If
            For Each oDgvrItem As DataGridViewRow In dgCuentasDetalle.Rows

                If Not dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value Is Nothing Then
                    If (dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value = String.Empty) And _
                                     (dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value = String.Empty) And _
                                     (dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value = String.Empty) And _
                                     (dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value = String.Empty) Then

                        If dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value = String.Empty Then
                            strMensaje = "* Ingrese C.I Terrestre"
                            Return strMensaje
                        End If

                        If dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value = String.Empty Then
                            strMensaje = "* Ingrese C.I Aereo"
                            Return strMensaje
                        End If

                        If dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value = String.Empty Then
                            strMensaje = "* Ingrese C.I Fluvial"
                            Return strMensaje
                        End If

                        If dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value Is Nothing Or dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value = String.Empty Then
                            strMensaje = "* Ingrese C.I Afectación"
                            Return strMensaje
                        End If
                    End If

                End If
                intCont = intCont + 1
            Next

            If ActualizarDatos = False Then
                If dgCuentasDetalle.RowCount = 1 Then
                    strMensaje = "* Ingrese Detalle"
                    Return strMensaje
                End If
            End If

            'Else
            '    If (txtCentroCosto.Text.Trim = "" And txtCuentaAfectacion.Text.Trim = "" And txtCostoAereo.Text.Trim = "" And txtCostoFluvial.Text.Trim = "") Then
            '        If (txtCentroCosto.Text.Trim = "") Then
            '            strMensaje = "* Ingrese C.I de Costo"
            '            txtCentroCosto.Focus()
            '            Return strMensaje
            '        End If

            '        If (txtCostoAereo.Text.Trim = "") Then
            '            strMensaje = "* Ingrese C.I Aereo"
            '            txtCostoAereo.Focus()
            '            Return strMensaje
            '        End If
            '        If (txtCostoFluvial.Text.Trim = "") Then
            '            strMensaje = "* Ingrese C.I Fluvial"
            '            txtCostoFluvial.Focus()
            '            Return strMensaje
            '        End If


            '        If (txtCuentaAfectacion.Text.Trim = "") Then
            '            strMensaje = "* Ingrese C.I Afectación"
            '            txtCuentaAfectacion.Focus()
            '            Return strMensaje
            '        End If
            '    End If
        End If

        strMensaje = ValidaOrdenCompra()
        If strMensaje <> String.Empty Then
            Return strMensaje
        End If
        Return strMensaje
    End Function

    Private Function ObtenerDatos() As beOrdenCompra
        Dim obeOrdenCompra = New beOrdenCompra

        obeOrdenCompra.PNCCLNT = PNCCLNT
        obeOrdenCompra.PSNORCML = txtOC.Text.Trim
        obeOrdenCompra.PSTLUGEN = cbxLugarEntrega.Text
        If Distribucion Then
            obeOrdenCompra.PNFECHAINI = HelpClass.CDate_a_Numero8Digitos(DtFechaIni.Value)
            obeOrdenCompra.PNFECHAFIN = HelpClass.CDate_a_Numero8Digitos(DtFechaFin.Value)
            obeOrdenCompra.PSTCTCST = "POR DISTRIBUCION"
            obeOrdenCompra.PSTCTCSA = "POR DISTRIBUCION"
            obeOrdenCompra.PSTCTCSF = "POR DISTRIBUCION"
            obeOrdenCompra.PSTCTAFE = ""
        Else
            obeOrdenCompra.PNFECHAINI = 0
            obeOrdenCompra.PNFECHAFIN = 0
            obeOrdenCompra.PSTCTCST = txtCentroCosto.Text
            obeOrdenCompra.PSTCTCSA = txtCostoAereo.Text
            obeOrdenCompra.PSTCTCSF = txtCostoFluvial.Text
            obeOrdenCompra.PSTCTAFE = txtCuentaAfectacion.Text

            obeOrdenCompra.PSCCNCOS = txtCeCoSAP.Text
            obeOrdenCompra.PSNORSAP = txtOrdenSAP.Text
            obeOrdenCompra.PSNGFSAP = txtNroGrafo.Text
            obeOrdenCompra.PSNCTAMA = txtCuentaMayor.Text
            obeOrdenCompra.PSNELPEP = txtElementoPEP.Text

        End If

        obeOrdenCompra.PNDISTR = IIf(Distribucion = True, 1, 0)
        obeOrdenCompra.PNNSEQIN = PNNSEQIN

        obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
        obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario
        obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
        obeOrdenCompra.PSNTRMCR = objSeguridadBN.pstrPCName

        Return obeOrdenCompra
    End Function

    Private Sub fnSelCuentasOC()
        Try


            Dim obeOrdenCompraFiltro As New beOrdenCompra
            Dim mlistOrden As New List(Of beOrdenCompra)
            obrOrdeCompra = New brOrdenDeCompra
            With obeOrdenCompraFiltro
                .PNCCLNT = PNCCLNT
                .PSNORCML = txtOC.Text.Trim
                .PageNumber = 1
                .PageSize = 20
            End With

            mlistOrden = obrOrdeCompra.flistListarCuentaImputacionOrdenDeCompra(obeOrdenCompraFiltro)


            If mlistOrden.Count > 0 Then
                cbxLugarEntrega.Text = ""
                txtCentroCosto.Text = ""
                txtCuentaAfectacion.Text = ""
                txtCostoAereo.Text = ""
                txtCostoFluvial.Text = ""
                For Each h As beOrdenCompra In mlistOrden

                    cbxLugarEntrega.Text = h.PSTLUGEN.Trim

                    txtCentroCosto.Text = h.PSTCTCST.Trim
                    txtCostoAereo.Text = h.PSTCTCSA.Trim
                    txtCostoFluvial.Text = h.PSTCTCSF.Trim
                    txtCuentaAfectacion.Text = h.PSTCTAFE.Trim
                Next
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub fnSelCuentasDetalle()
        Try




            Dim obeOrdenCompraFiltro As New beOrdenCompra
            mlistOrdenDetalle = New List(Of beOrdenCompra)
            Dim obrOrdeCompra As New brOrdenDeCompra


            With obeOrdenCompraFiltro
                .PNCCLNT = PNCCLNT
                .PNNSEQIN = PNNSEQIN
                .PSNORCML = txtOC.Text
            End With



            dgCuentasDetalle.AllowUserToAddRows = True
            mlistOrdenDetalle = obrOrdeCompra.flistListCuentaImputacionDistribucion(obeOrdenCompraFiltro)
            dgCuentasDetalle.DataSource = mlistOrdenDetalle

        Catch ex As Exception

        End Try
    End Sub


    Private Sub pCargarCbxLugarEntrega()
        Dim obrLugarEntrega As New brGeneral
        Dim obeLugarentrega As New beGeneral
        Dim mListaLugarEntrega As List(Of beGeneral)
        With obeLugarentrega
            .PNCCLNT = PNCCLNT
        End With
        mListaLugarEntrega = obrLugarEntrega.ListaLotesDeEntrega(obeLugarentrega)
        cbxLugarEntrega.DataSource = mListaLugarEntrega
        cbxLugarEntrega.ValueMember = "PSTLTECL"
        cbxLugarEntrega.DisplayMember = "PSTLTECL"

    End Sub

    Private Sub VisualizarCampos()
        KryptonSplitContainer1.SuspendLayout()

        If Distribucion Then
            '    Me.Size = New System.Drawing.Size(632, 600)
            lblTerrestre.Visible = False
            txtCentroCosto.Visible = False
            lblAereo.Visible = False
            txtCostoAereo.Visible = False
            lblFluvial.Visible = False
            txtCostoFluvial.Visible = False
            lblAfectacion.Visible = False
            txtCuentaAfectacion.Visible = False

            DtFechaIni.Visible = True
            DtFechaFin.Visible = True
            lblFechaFin.Visible = True
            lblFechaIni.Visible = True

            lblCuentaMayor.Visible = False
            txtCuentaMayor.Visible = False

            lblCentroCostoSAP.Visible = False
            txtCeCoSAP.Visible = False

            lblElementoPEP.Visible = False
            txtElementoPEP.Visible = False

            lblOrden.Visible = False
            txtOrdenSAP.Visible = False

            lblNroGrafo.Visible = False
            txtNroGrafo.Visible = False

            KryptonSplitContainer1.Panel1MinSize = 450
            KryptonSplitContainer1.SplitterDistance = 450
            KryptonSplitContainer1.FixedPanel = FixedPanel.None


        Else

            If KryptonSplitContainer1.FixedPanel = FixedPanel.None Then
                KryptonSplitContainer1.FixedPanel = FixedPanel.Panel2
                KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
                KryptonSplitContainer1.Panel2MinSize = 0
                KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height
            End If

            DtFechaIni.Visible = False
            DtFechaFin.Visible = False
            lblFechaFin.Visible = False
            lblFechaIni.Visible = False

            txtCentroCosto.Top = 90
            lblTerrestre.Top = 90

            txtCostoAereo.Top = 115
            lblAereo.Top = 115

            txtCostoFluvial.Top = 140
            lblFluvial.Top = 140

            txtCuentaAfectacion.Top = 165
            lblAfectacion.Top = 165

            lblCuentaMayor.Top = 190
            txtCuentaMayor.Top = 190

            lblCentroCostoSAP.Top = 215
            txtCeCoSAP.Top = 215

            lblElementoPEP.Top = 240
            txtElementoPEP.Top = 240

            lblOrden.Top = 190
            txtOrdenSAP.Top = 190

            lblNroGrafo.Top = 215
            txtNroGrafo.Top = 215

            Me.Size = New System.Drawing.Size(632, 380) '531

            KryptonSplitContainer1.ResumeLayout()
        End If
    End Sub

    Private Function ObtenerDatosDetalle() As List(Of beOrdenCompra)
        Dim intCont As Int32 = 0
        Dim obeOrdenCompraDetalle As New beOrdenCompra
        mlistOrdenDetalle = New List(Of beOrdenCompra)
        If Distribucion Then
            If dgCuentasDetalle.RowCount > 0 Then

                For Each oDgvrItem As DataGridViewRow In dgCuentasDetalle.Rows

                    obeOrdenCompraDetalle = New beOrdenCompra
                    obeOrdenCompraDetalle.PNNSEQIN = PNNSEQIN
                    obeOrdenCompraDetalle.PNCCLNT = PNCCLNT
                    obeOrdenCompraDetalle.PSNORCML = txtOC.Text.Trim

                    obeOrdenCompraDetalle.PNNCRRDT = dgCuentasDetalle.Rows(intCont).Cells("NCRRDT").Value


                    obeOrdenCompraDetalle.PSTCTCST = IIf(dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value Is Nothing, "", dgCuentasDetalle.Rows(intCont).Cells("TCTCST").Value)
                    obeOrdenCompraDetalle.PSTCTCSA = IIf(dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value Is Nothing, "", dgCuentasDetalle.Rows(intCont).Cells("TCTCSA").Value)
                    obeOrdenCompraDetalle.PSTCTCSF = IIf(dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value Is Nothing, "", dgCuentasDetalle.Rows(intCont).Cells("TCTCSF").Value)
                    obeOrdenCompraDetalle.PSTCTAFE = IIf(dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value Is Nothing, "", dgCuentasDetalle.Rows(intCont).Cells("TCTAFE").Value)

                    obeOrdenCompraDetalle.PNIPRCTJ = IIf(dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value Is Nothing, 0, dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value)

                    obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
                    obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario
                    obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
                    obeOrdenCompra.PSNTRMCR = objSeguridadBN.pstrPCName

                    If (Not dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value Is Nothing) Or dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value > 0 Then
                        mlistOrdenDetalle.Add(obeOrdenCompraDetalle)

                        intCont = intCont + 1
                    End If

                Next
            End If


        End If



        Return mlistOrdenDetalle
    End Function

    Private Function ValidaPorcentaje() As String
        Dim strmensaje As String = String.Empty
        Dim nPorcentaje As Decimal = 0
        Dim intCont As Integer = 0
        If dgCuentasDetalle.RowCount > 0 Then

            For Each oDgvrItem As DataGridViewRow In dgCuentasDetalle.Rows
                nPorcentaje = nPorcentaje + dgCuentasDetalle.Rows(intCont).Cells("IPRCTJ").Value
                intCont = intCont + 1
            Next
            If nPorcentaje > 100 Or nPorcentaje < 100 Then
                strmensaje = "El porcentaje tiene que ser igual a 100"
            End If

        End If

        Return strmensaje
    End Function

#End Region

#Region "Eventos de Control"
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try


            Dim resultado As Int32 = 0
            Dim intCont As Int32 = 0
            Dim obeOrdenCompra As New beOrdenCompra
            Dim obeOrdenCompraDetalle As New beOrdenCompra
            obrOrdeCompra = New brOrdenDeCompra
            Dim strmensajeValidacion As String = Validar()

            If (strmensajeValidacion <> "") Then
                MessageBox.Show(strmensajeValidacion, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If (ActualizarDatos = True) Then

                resultado = obrOrdeCompra.fintInsertarCuentaImputacionOrdenDeCompraCabDet(ObtenerDatos(), ObtenerDatosDetalle(), mlistOrdenEliminaDetalle)
                If (resultado = 1) Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente ", "Actualización Cuenta Imputación")
                    Grabar = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Actualización Cuenta Imputación")
                End If
            Else

                resultado = obrOrdeCompra.fintInsertarCuentaImputacionOrdenDeCompraCabDet(ObtenerDatos(), ObtenerDatosDetalle(), mlistOrdenEliminaDetalle)
                If (resultado = 1) Then
                    MessageBox.Show("Se ha grabado satisfactoriamente  ", "Registro Cuenta Imputación")
                    Grabar = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Registro Cuenta Imputación")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub txtOC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            fnSelCuentasOC()
        ElseIf e.KeyCode = Keys.Tab Then
            e.Handled = True
            fnSelCuentasOC()
        End If
    End Sub

    Private Sub txtOC_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOC.Validating
        If txtOC.Text.Length > 0 Then
            fnSelCuentasOC()
        End If

    End Sub

    Private Sub dgCuentasDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCuentasDetalle.DataError
        If (e.Context = 768) Then
            'MessageBox.Show("Dato ingresado no es válido", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            e.Cancel = True
        Else
            Agregar = False
        End If

    End Sub

    Private Sub UcPaginacionDetalle_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgCuentasDetalle.Rows.Count > 0 Then
            fnSelCuentasDetalle()
        End If
    End Sub

    Private Sub tsMenuOpcionesDetalle_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsMenuOpcionesDetalle.ItemClicked

        If e.ClickedItem.Name.ToString = "btnAgregarDetalle" Then
            Dim obeAgregar As New beOrdenCompra
            Dim PNNCRRDTNUEVO As Decimal = 0
            If Agregar = False Then

                Dim MlistbeOrdenCompra As New List(Of beOrdenCompra)
                If dgCuentasDetalle.RowCount > 0 Then
                    mlistOrdenDetalle = CType(Me.dgCuentasDetalle.DataSource, List(Of beOrdenCompra))

                    For lnIndice As Integer = 0 To dgCuentasDetalle.Rows.Count - 1
                        PNNCRRDTNUEVO = Convert.ToDecimal(dgCuentasDetalle.Rows(lnIndice).Cells("NCRRDTNUEVO").Value)
                    Next

                    'dgCuentasDetalle.DataSource = Nothing

                End If



                obeAgregar.PNNCRRDTNUEVO = PNNCRRDTNUEVO + 1

                mlistOrdenDetalle.Add(obeAgregar)
                'MlistbeOrdenCompra.Add(obeAgregar)
                dgCuentasDetalle.DataSource = Nothing
                dgCuentasDetalle.DataSource = mlistOrdenDetalle


                Agregar = True
            End If
        End If


    End Sub

    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDetalle.Click

        Try
            Dim lnFila As Integer = 0

            Dim _NCRRDT As Integer = 0
            Dim _PNNCRRDTNUEVO As Integer = 0
            Dim obeNuevalista As New List(Of beOrdenCompra)

            Agregar = False



            If dgCuentasDetalle.RowCount > 0 Then

                lnFila = dgCuentasDetalle.CurrentCell.RowIndex

                _NCRRDT = Convert.ToInt32(dgCuentasDetalle("NCRRDT", lnFila).Value.ToString())
                _PNNCRRDTNUEVO = Convert.ToInt32(dgCuentasDetalle("NCRRDTNUEVO", lnFila).Value.ToString())


                For Each obe As beOrdenCompra In mlistOrdenDetalle

                    If _PNNCRRDTNUEVO > 0 Then

                        If obe.PNNCRRDTNUEVO <> _PNNCRRDTNUEVO Then
                            obeNuevalista.Add(obe)
                        Else
                            mlistOrdenEliminaDetalle.Add(obe)
                        End If

                    Else
                        If obe.PNNCRRDT <> _NCRRDT And obe.PNNCRRDT > 0 Then
                            obeNuevalista.Add(obe)
                        Else
                            mlistOrdenEliminaDetalle.Add(obe)
                        End If
                    End If

                Next
                mlistOrdenDetalle = obeNuevalista
                dgCuentasDetalle.DataSource = Nothing
                dgCuentasDetalle.DataSource = mlistOrdenDetalle
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgCuentasDetalle_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgCuentasDetalle.CellValidating
        Dim IPRCTJ As Decimal = 0
        With dgCuentasDetalle
            Select Case .Columns(e.ColumnIndex).Name

                Case "IPRCTJ"
                    If IsNumeric(e.FormattedValue) Then
                        If e.FormattedValue = 0 Then
                            MessageBox.Show("Porcenaje no puede ser igual a 0", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            e.Cancel = True
                        End If
                        IPRCTJ = e.FormattedValue
                        For lnIndice As Integer = 0 To dgCuentasDetalle.Rows.Count - 1
                            If lnIndice <> e.RowIndex Then
                                IPRCTJ = IPRCTJ + .Rows(lnIndice).Cells("IPRCTJ").Value
                            End If

                        Next
                        If IPRCTJ > 100 Or IPRCTJ = 0 Then
                            MessageBox.Show("Porcenaje no puede ser mayo a 100", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            e.Cancel = True
                        Else
                            Agregar = False
                        End If
                    Else
                        e.Cancel = True
                    End If
                    
            End Select

        End With
    End Sub

#End Region


    Private Sub dgCuentasDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgCuentasDetalle.EditingControlShowing
        Select Case dgCuentasDetalle.CurrentCell.ColumnIndex
            Case 8
                Dim txt As DataGridViewTextBoxEditingControl = e.Control
                AddHandler txt.KeyPress, AddressOf ValidarColum
        End Select
    End Sub

    Private Sub ValidarColum(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub
End Class
