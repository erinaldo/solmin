Imports RANSA.Utilitario
Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports Ransa.TypeDef.Cliente


Public Class frmListaCuentaOC


#Region "Declaracion de variables"

    Private nTotalPorcetajeGrilla As Decimal = 0
    Private boolpanel As Boolean = False

#End Region


#Region "Metodos y funciones"
    Private Function fnValidarInformacion() As String
        Dim Mensaje As String = String.Empty
        If txtCliente.pCodigo = 0 Then
            Mensaje &= "Falta Seleccionar un Cliente. "
        End If
        Return Mensaje
    End Function

    Private Sub MostrarCampos()
        If chkDistribucion.Checked Then
            Me.dgCuentasOC.Columns("TCTCST").Visible = False
            Me.dgCuentasOC.Columns("TCTCSA").Visible = False
            Me.dgCuentasOC.Columns("TCTCSF").Visible = False
            Me.dgCuentasOC.Columns("TCTAFE").Visible = False

            Me.dgCuentasOC.Columns("FINCVG").Visible = True
            Me.dgCuentasOC.Columns("FFINVG").Visible = True

        Else
            Me.dgCuentasOC.Columns("TCTCST").Visible = True
            Me.dgCuentasOC.Columns("TCTCSA").Visible = True
            Me.dgCuentasOC.Columns("TCTCSF").Visible = True
            Me.dgCuentasOC.Columns("TCTAFE").Visible = True

            Me.dgCuentasOC.Columns("FINCVG").Visible = False
            Me.dgCuentasOC.Columns("FFINVG").Visible = False

        End If
    End Sub

    Private Sub fnSelCuentasOC()
        Try
            If txtCliente.pCodigo > 0 Then

                Dim obeOrdenCompraFiltro As New beOrdenCompra
                Dim mlistOrden As New List(Of beOrdenCompra)
                Dim obrOrdeCompra As New brOrdenDeCompra
                With obeOrdenCompraFiltro
                    .PNCCLNT = txtCliente.pCodigo
                    .PSNORCML = IIf(txtOc.Text.Length = 0, "*", txtOc.Text.Trim)
                    .PSTLUGEN = IIf(cbxLugarEntrega.Text = "" Or cbxLugarEntrega.Text = "--Todos--", "*", cbxLugarEntrega.Text.ToUpper)
                    .PNDISTR = IIf(chkDistribucion.Checked = True, 1, 0)
                    If chkDistribucion.Checked And chkFechas.Checked Then
                        .PNFECHAINI = HelpClass.CDate_a_Numero8Digitos(DtFechaIni.Value)
                        .PNFECHAFIN = HelpClass.CDate_a_Numero8Digitos(DtFechaFin.Value)
                    Else
                        .PNFECHAINI = 0
                        .PNFECHAFIN = 0
                    End If
                    .PageNumber = UcPaginacion.PageNumber
                    .PageSize = UcPaginacion.PageSize
                End With
                Me.dgCuentasOC.AutoGenerateColumns = False
                mlistOrden = obrOrdeCompra.flistListCuentaImputacionOrdenDeCompra(obeOrdenCompraFiltro)
                dgCuentasOC.DataSource = mlistOrden
                If mlistOrden.Count = 0 Then
                    dgCuentasDetalle.DataSource = mlistOrden
                End If
                MostrarCampos()
                If dgCuentasOC.Rows.Count > 0 Then
                    UcPaginacion.PageCount = CType(dgCuentasOC.DataSource.Item(0), beOrdenCompra).PageCount
                    UcPaginacion.Enabled = True
                Else
                    UcPaginacion.PageCount = 0
                    UcPaginacion.Enabled = False
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub pCargarCbxLugarEntrega()
        Dim obrLugarEntrega As New brGeneral
        Dim obeLugarentrega As New beGeneral
        Dim mList As New List(Of beGeneral)
        Dim mListResult As New List(Of beGeneral)
        With obeLugarentrega
            .PNCCLNT = txtCliente.pCodigo
        End With

        mList = obrLugarEntrega.ListaLotesDeEntrega(obeLugarentrega)
        obeLugarentrega = New beGeneral
        obeLugarentrega.PSTLTECL = "--Todos--"
        obeLugarentrega.PSTLTECL = "--Todos--"
        mListResult.Add(obeLugarentrega)
        For Each o As beGeneral In mList
            mListResult.Add(o)
        Next



        cbxLugarEntrega.DataSource = mListResult

        cbxLugarEntrega.ValueMember = "PSTLTECL"
        cbxLugarEntrega.DisplayMember = "PSTLTECL"

        If Me.txtCliente.pCodigo = 11731 Then
            tssSep_02.Visible = True
            Me.btnExcel.Visible = True
        Else
            tssSep_02.Visible = False
            Me.btnExcel.Visible = False
        End If

    End Sub

    Private Sub fnSelCuentasDetalle()
        Try


            If txtCliente.pCodigo > 0 Then
                Dim obeOrdenCompra As beOrdenCompra
                Dim obeOrdenCompraFiltro As New beOrdenCompra
                Dim mlistOrdenDetalle As New List(Of beOrdenCompra)
                Dim obrOrdeCompra As New brOrdenDeCompra

                obeOrdenCompra = dgCuentasOC.CurrentRow.DataBoundItem

                With obeOrdenCompraFiltro
                    .PNCCLNT = obeOrdenCompra.PNCCLNT
                    .PNNSEQIN = obeOrdenCompra.PNNSEQIN
                    .PSNORCML = obeOrdenCompra.PSNORCML

                    .PageNumber = UcPaginacionDetalle.PageNumber
                    .PageSize = UcPaginacionDetalle.PageSize
                End With



                Me.dgCuentasDetalle.AutoGenerateColumns = False
                mlistOrdenDetalle = obrOrdeCompra.flistListCuentaImputacionDistribucion(obeOrdenCompraFiltro)
                dgCuentasDetalle.DataSource = mlistOrdenDetalle

                nTotalPorcetajeGrilla = 0
                For Each o As beOrdenCompra In mlistOrdenDetalle
                    nTotalPorcetajeGrilla = nTotalPorcetajeGrilla + o.PNIPRCTJ
                Next


                If dgCuentasDetalle.Rows.Count > 0 Then
                    UcPaginacionDetalle.PageCount = CType(dgCuentasDetalle.DataSource.Item(0), beOrdenCompra).PageCount
                    UcPaginacionDetalle.Enabled = True
                Else
                    UcPaginacionDetalle.PageCount = 0
                    UcPaginacionDetalle.Enabled = False
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Eventos de Control"
    Private Sub frmMantenimientoCuentaOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            boolpanel = True
            chkDistribucion_CheckedChanged(Nothing, Nothing)

        Catch : End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            dgCuentasOC.DataSource = Nothing
            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If
            fnSelCuentasOC()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            If (dgCuentasOC.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If

            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ofrmMantenimientoOC = New frmMantenimientoCuentaOC
            Dim obeOrdenCompra As New beOrdenCompra

            obeOrdenCompra = dgCuentasOC.CurrentRow.DataBoundItem


            ofrmMantenimientoOC.obeOrdenCompra = obeOrdenCompra
            ofrmMantenimientoOC.ActualizarDatos = True
            ofrmMantenimientoOC.PsDesCliente = txtCliente.pRazonSocial
            ofrmMantenimientoOC.PNCCLNT = txtCliente.pCodigo
            ofrmMantenimientoOC.Distribucion = chkDistribucion.Checked
            ofrmMantenimientoOC.ShowDialog()
            If ofrmMantenimientoOC.Grabar = True Then fnSelCuentasOC()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim Mensaje As String = fnValidarInformacion()
        If Mensaje <> String.Empty Then
            MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ofrmMantenimientoOC = New frmMantenimientoCuentaOC

        ofrmMantenimientoOC.ActualizarDatos = False
        ofrmMantenimientoOC.PsDesCliente = txtCliente.pRazonSocial
        ofrmMantenimientoOC.PNCCLNT = txtCliente.pCodigo

        ofrmMantenimientoOC.Distribucion = chkDistribucion.Checked

        ofrmMantenimientoOC.ShowDialog()
        If ofrmMantenimientoOC.Grabar = True Then fnSelCuentasOC()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim resultado As Int32 = 0
        Dim obeOrdenCompra As New beOrdenCompra
        Dim obrOrdeCompra As New brOrdenDeCompra

        If dgCuentasOC.Rows.Count = 0 Then
            MessageBox.Show("No existen registero que eliminar", "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If (MessageBox.Show("Esta seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            obeOrdenCompra = dgCuentasOC.CurrentRow.DataBoundItem

            obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
            obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario
            obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
            obeOrdenCompra.PSNTRMCR = objSeguridadBN.pstrPCName


            resultado = obrOrdeCompra.fintEliminaCuentaImputacionOrdenDeCompra(obeOrdenCompra)

            MessageBox.Show("Se eliminó el registro corractamente", "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fnSelCuentasOC()
        End If


    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        pCargarCbxLugarEntrega()
    End Sub

    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked Then
            DtFechaIni.Enabled = True
            DtFechaFin.Enabled = True
        Else
            DtFechaIni.Enabled = False
            DtFechaFin.Enabled = False
        End If
    End Sub

    Private Sub chkDistribucion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDistribucion.CheckedChanged
        If boolpanel = True Then
            If chkDistribucion.Checked Then
                lblFechaFin.Visible = True
                DtFechaIni.Visible = True
                DtFechaFin.Visible = True
                cbxLugarEntrega.Visible = True
                chkFechas.Visible = True
                lblLote.Visible = True
                KryptonSplitContainer1.Panel1MinSize = 25
                KryptonSplitContainer1.SplitterDistance = 450

                KryptonSplitContainer1.IsSplitterFixed = False
                UcPaginacion.PageNumber = 1
                fnSelCuentasOC()
                boolpanel = True
            Else

                lblFechaFin.Visible = False
                DtFechaIni.Visible = False
                DtFechaFin.Visible = False
                cbxLugarEntrega.Visible = False
                chkFechas.Visible = False
                lblLote.Visible = False

                KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
                KryptonSplitContainer1.Panel2MinSize = 25
                KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height

                fnSelCuentasOC()
            End If

        Else

            boolpanel = True
        End If
    End Sub

    Private Sub btnAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Dim Mensaje As String = fnValidarInformacion()
        Dim obeOrdenCompra As New beOrdenCompra
        If Mensaje <> String.Empty Then
            MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ofrmMantenimientoPD = New frmMantenimientoCuentaPD
        obeOrdenCompra = dgCuentasOC.CurrentRow.DataBoundItem

        ofrmMantenimientoPD.ActualizarDatos = False

        ofrmMantenimientoPD.PNCCLNT = obeOrdenCompra.PNCCLNT
        ofrmMantenimientoPD.PNNSEQIN = obeOrdenCompra.PNNSEQIN
        ofrmMantenimientoPD.PSNORCML = obeOrdenCompra.PSNORCML
        ofrmMantenimientoPD.Porcentaje = nTotalPorcetajeGrilla
        ofrmMantenimientoPD.ShowDialog()

        If ofrmMantenimientoPD.Grabar = True Then fnSelCuentasDetalle()
    End Sub

    Private Sub dgCuentasOC_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuentasOC.CurrentCellChanged
        fnSelCuentasDetalle()
    End Sub

    Private Sub btnModificarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            If (dgCuentasDetalle.Rows.Count = 0) Then
                MessageBox.Show("No hay información")
                Exit Sub
            End If

            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ofrmMantenimientoPD = New frmMantenimientoCuentaPD
            Dim obeOrdenCompra As New beOrdenCompra

            obeOrdenCompra = dgCuentasDetalle.CurrentRow.DataBoundItem
            ofrmMantenimientoPD.obeOrdenCompra = obeOrdenCompra
            ofrmMantenimientoPD.ActualizarDatos = True
            ofrmMantenimientoPD.Porcentaje = nTotalPorcetajeGrilla

            ofrmMantenimientoPD.ShowDialog()
            If ofrmMantenimientoPD.Grabar = True Then fnSelCuentasDetalle()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim resultado As Int32 = 0
        Dim obeOrdenCompra As New beOrdenCompra
        Dim obrOrdeCompra As New brOrdenDeCompra

        If dgCuentasDetalle.Rows.Count = 0 Then
            MessageBox.Show("No existen registero que eliminar", "Cuentas por Distribución", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If (MessageBox.Show("Esta seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            obeOrdenCompra = dgCuentasDetalle.CurrentRow.DataBoundItem

            obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
            obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario
            obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
            obeOrdenCompra.PSNTRMCR = objSeguridadBN.pstrPCName


            resultado = obrOrdeCompra.fintEliminaCuentaImputacionDistribucion(obeOrdenCompra)

            MessageBox.Show("Se eliminó el registro corractamente", "Cuentas Detalle", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fnSelCuentasDetalle()
        End If

    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        If dgCuentasOC.Rows.Count > 0 Then
            fnSelCuentasOC()
        End If

    End Sub

    Private Sub UcPaginacionDetalle_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacionDetalle.PageChanged

        If dgCuentasDetalle.Rows.Count > 0 Then
            fnSelCuentasDetalle()
        End If
    End Sub

#End Region

    Private Sub txtOc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOc.KeyPress
        If e.KeyChar = Chr(13) Then
            btnActualizar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim ofrmImportarCIExcel_PPC As New frmImportarCIExcel_PPC
        ofrmImportarCIExcel_PPC.dblCodCliente = Me.txtCliente.pCodigo
        ofrmImportarCIExcel_PPC.strUsuario = objSeguridadBN.pUsuario
        ofrmImportarCIExcel_PPC.pTerminal = objSeguridadBN.pstrPCName
        ofrmImportarCIExcel_PPC.ShowDialog()

        If ofrmImportarCIExcel_PPC.DialogResult = Windows.Forms.DialogResult.OK Then
            dgCuentasOC.DataSource = Nothing
            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Cuentas OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            fnSelCuentasOC()
        End If

    End Sub

End Class
