Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmMantValorizacion


    Private Enum_Mantenimiento As MANTENIMIENTO_OPC
    Private bs As New BindingSource
    Private tabSeleccionado As String = ""
    Private _pUsuario As String = ""
    Private checkallPendiente As Boolean = False
    Private oValorizacionFiltro As New beMantValorizacion
    Private obrConfValorizacionFiltro As New clsMantValorizacion
    Private cOrgVenta As String = ""


    Enum MANTENIMIENTO_OPC
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

    Private Sub estado_Boton(oAccion As MANTENIMIENTO_OPC)

        Dim tab As String = TabItemVal.SelectedTab.Name

        If tab = "tabDatoVal" Then
            btnCheck.Visible = False
            btnCheckPend.Visible = False
            btnGenerarPL.Visible = False
            btnNuevo.Visible = True
            btnModificar.Visible = True

            Select Case oAccion
                Case MANTENIMIENTO_OPC.NUEVO

                    btnNuevo.Enabled = False
                    btnGuardar.Visible = True
                    btnCancelar.Visible = True
                    btnAgregar.Enabled = False
                    btnEliminar.Enabled = False
                    btnModifica.Enabled = False
                    EstadoControl(True)
                    txtFechaCorte.Text = ""
                    txtAprobDias.Text = ""

                    cboTipoValorizacion.ComboBox.SelectedValue = ""

                    cboTipoValorizacion.ComboBox.Enabled = True

                Case MANTENIMIENTO_OPC.NEUTRAL

                    btnNuevo.Enabled = True
                    btnGuardar.Visible = False
                    btnCancelar.Visible = False
                    btnAgregar.Enabled = False
                    btnEliminar.Enabled = False
                    btnModifica.Enabled = True
                    EstadoControl(False)
                    txtFechaCorte.Text = ""
                    txtAprobDias.Text = ""



                    cboTipoValorizacion.ComboBox.Enabled = False

                Case MANTENIMIENTO_OPC.MODIFICAR

                    btnNuevo.Enabled = False
                    btnGuardar.Visible = True
                    btnCancelar.Visible = True
                    btnAgregar.Enabled = False
                    btnEliminar.Enabled = False
                    btnModifica.Enabled = False
                    EstadoControl(True)

                    cboTipoValorizacion.ComboBox.Enabled = False

            End Select

        End If

        If tab = "tabOpValorizacion" Then
            btnNuevo.Visible = False
            btnModificar.Visible = False

            btnCheck.Visible = True

            ' VALIDACION DE TIPO VALORIZACION: RANGO VIAJE

            If (dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim = "RV" Then
                btnGenerarPL.Visible = False
            Else
                btnGenerarPL.Visible = True
            End If

            btnCheckPend.Visible = True
            btnNuevo.Enabled = False
            btnGuardar.Visible = False
            btnCancelar.Visible = False
            btnAgregar.Enabled = True
            btnEliminar.Enabled = True
            btnModifica.Enabled = False

            EstadoControl(False)

        End If


    End Sub


    Private Sub EstadoControl(estado As Boolean)

        txtnumdocumento.Enabled = estado
        txtFechaCorte.Enabled = False
        txtAprobDias.Enabled = False
        btnConfigCierre.Enabled = estado

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            dtgValorizacion.AutoGenerateColumns = False
            dtgOpValorizacion.AutoGenerateColumns = False

            dtgOpValorizacion.DataSource = Nothing
            dtgValorizacion.DataSource = Nothing

            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL

            txt_SOLES.Text = ""
            txt_DOLAR.Text = ""
            ListarValorizaciones()



            checkall = False
            checkallPendiente = False


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMantValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            dtpFechaInicio.Value = Now.AddMonths(-1)
            dtpFechaFin.Value = Now

            dtgOpValorizacion.AutoGenerateColumns = False
            dtgValorizacion.AutoGenerateColumns = False

            Cargar_Compania()
            CargarCombos()
            Limpiar_Control()
            CargarComboTipoValorización()

            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            estado_Boton(Enum_Mantenimiento)

            chkvalorizacion_CheckedChanged(chkvalorizacion, Nothing)
            CargarComboDivision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboTipoValorización()

        Dim oListbeAyudaGeneral As New List(Of beAyudaGeneral)
        Dim blclsAyudaGeneral As New SOLMIN_CTZ.NEGOCIO.clsAyudaGeneral
        oListbeAyudaGeneral = blclsAyudaGeneral.ListaTablaAyudaGeneral("TPOVLR", "")
        Dim obeAyudaGeneral As New beAyudaGeneral

 

        cboTipoValorizacion.DataSource = oListbeAyudaGeneral
        cboTipoValorizacion.ValueMember = "PSCODIGO"
        cboTipoValorizacion.DisplayMember = "PSDESCRIPCION"
        'cboTipoValorizacion.SelectedValue = ""
        cboTipoValorizacion.ComboBox.SelectedValue = ""

    End Sub

    Private Sub CargarComboDivision()
        Dim oDivision As New DataTable
        Dim obrDivision As New Ransa.Controls.UbicacionPlanta.Division.brDivision
        Dim _Usuario As String
        Dim _CodCompania As String
        _Usuario = ConfigurationWizard.UserName
        _CodCompania = Me.cboCompania.CCMPN_CodigoCompania
        oDivision = obrDivision.Lista_Division_X_Usuario_Y_Compania(_Usuario, _CodCompania)

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add(New DataColumn("CDVSN", GetType(String)))
        dt.Columns.Add(New DataColumn("TCMPDV", GetType(String)))

        For Each row As DataRow In oDivision.Rows
            dr = dt.NewRow()
            dr("CDVSN") = row("CDVSN").ToString.Trim
            dr("TCMPDV") = row("TCMPDV").ToString.Trim
            dt.Rows.Add(dr)
        Next

        dr = dt.NewRow()
        dr("CDVSN") = ""
        dr("TCMPDV") = "Todos"
        dt.Rows.InsertAt(dr, 0)

        cboDivision.DisplayMember = "TCMPDV"
        cboDivision.ValueMember = "CDVSN"
        cboDivision.DataSource = dt
        cboDivision.SelectedValue = ""

    End Sub

    Private Sub Cargar_Compania()
        cboCompania.Usuario = ConfigurationWizard.UserName
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarCombos()


        Dim oclsGeneral As New clsAyudaGeneral
        Dim oListbeGeneral As New List(Of beAyudaGeneral)
        oListbeGeneral = oclsGeneral.ListaTablaAyudaGeneral("SDEVLR", "")
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")
        For Each item As beAyudaGeneral In oListbeGeneral
            oDr = oDt.NewRow
            oDr.Item("COD") = item.PSCODIGO
            oDr.Item("DES") = item.PSDESCRIPCION
            oDt.Rows.Add(oDr)
        Next
        oDr = oDt.NewRow
        oDr.Item("COD") = "T"
        oDr.Item("DES") = "Todos"
        oDt.Rows.InsertAt(oDr, 0)


        'G - Generado: Estado al crearse la valorización.
        'E – Pendinte: Estado al enviarse la valorización( Pendiente aprobación)
        'A – Aprobado: Estado al aprobarse la valorizarse.

        With Me.cmbestado
            .DataSource = oDt
            .ValueMember = "COD"
            .DisplayMember = "DES"
        End With

        For i As Integer = 0 To cmbestado.Items.Count - 1
            If cmbestado.Items(i).Value = "G" Or cmbestado.Items(i).Value = "E" Then
                cmbestado.SetItemChecked(i, True)
            End If
        Next


    End Sub
    Private Sub Limpiar_Control()

        txtNroDocumento.Clear()
        txtNroValorizacion.Clear()

    End Sub




    Private Sub ListarValorizaciones()

        dtgOpValorizacion.DataSource = Nothing
        dtgValorizacion.DataSource = Nothing

        If Me.Validar_Datos_Filtro = True Then Exit Sub

        Dim oValorizacion As New beMantValorizacion
        Dim obrConfValorizacion As New clsMantValorizacion
        With oValorizacion
            .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            .CCLNT = Me.UcCliente.pCodigo

            .NROVLR = Val(txtNroValorizacion.Text.Trim)
            .DOCVLR = txtNroDocumento.Text.Trim
            If chkvalorizacion.Checked = True Then
                .NROVLR = Val(txtNroValorizacion.Text.Trim)
                .DOCVLR = txtNroDocumento.Text.Trim
                .FCHINI = 0
                .FCHFIN = 0
                .SEGVLR = "T"
            Else
                .NROVLR = 0
                .DOCVLR = ""
                .FCHINI = Me.dtpFechaInicio.Value.ToString("yyyyMMdd")
                .FCHFIN = Me.dtpFechaFin.Value.ToString("yyyyMMdd")
                .SEGVLR = DevuelveDivisionSeleccionadas(Me.cmbestado)
            End If


        End With

        Dim dt As New DataTable
        dt = obrConfValorizacion.Listar_MantValorizacion(oValorizacion)
        dtgValorizacion.DataSource = dt

        Dim qatraso As Decimal = 0

        Dim bmpImage As New Bitmap(16, 16)


        For Each item As DataGridViewRow In dtgValorizacion.Rows
            If ("" & item.Cells("QDATRASADOS").Value) <> "" Then
                qatraso = Val("" & item.Cells("QDATRASADOS").Value)
                Select Case qatraso
                    Case Is > 0
                        bmpImage = My.Resources.Resources._Red
                    Case Is <= 0
                        bmpImage = My.Resources.Resources._Green
                End Select
            Else
                bmpImage = My.Resources.Resources.CuadradoBlanco
            End If
            item.Cells("RPTA_A_TIEMPO").Value = bmpImage
        Next




    End Sub


    Private Function DevuelveDivisionSeleccionadas(MiCombo As Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral) As String
        Dim strCodigo As String
        strCodigo = ""
        For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
            If MiCombo.CheckedItems(i).Value = "T" Then
                strCodigo = "T"
                Exit For
            Else
                strCodigo &= MiCombo.CheckedItems(i).Value & ","
            End If
        Next
        If strCodigo <> "T" Then
            strCodigo = strCodigo.Trim.Substring(0, strCodigo.Trim.Length - 1)
        End If

        Return strCodigo

    End Function




    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If cboCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* Compañía " & Chr(13)
        End If

        Dim lstr_estado As String = ""
        For i As Integer = 0 To cmbestado.CheckedItems.Count - 1
            lstr_estado &= cmbestado.CheckedItems(i).Value & ","
        Next
        If lstr_estado = "" Then
            lstr_validacion += "* Estado " & Chr(13)
        End If


        If chkvalorizacion.Checked = True Then
            If txtNroDocumento.Text.Trim = "" And txtNroValorizacion.Text = "" Then
                lstr_validacion = "Número o Documento valorización"
                lbool_existe_error = True
            End If
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If






        Return lbool_existe_error
    End Function



    Private Sub btnEliminarDet_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If dtgOpValorizacion.Rows.Count = 0 Then
                Exit Sub
            End If

            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "X" Then
                MessageBox.Show("No puede eliminar. El documento ya se encuentra generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim obrValorizacion As New clsMantValorizacion

            If MessageBox.Show("Está seguro de eliminar la operación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            dtgOpValorizacion.EndEdit()
            Dim ListMsg As New Hashtable
            Dim oValorizacion As New beMantValorizacion
            Dim sErrorMesage As String = ""
            Dim sStatus As String = ""
            Dim strmsg As String = ""
            Dim dtOperaciones As New DataTable
            Dim List_Op As String = ""

            ''++++++inicio actualizacion detalle administrativo ( generalmente primer registro)
            Dim TieneServAlmacenSinDetalle As Boolean = False
            For Each item As DataGridViewRow In dtgOpValorizacion.Rows
                If item.Tag Is Nothing And item.Cells("TPOPER").Value = "A" Then
                    TieneServAlmacenSinDetalle = True
                    Exit For
                End If
            Next
            If TieneServAlmacenSinDetalle = True Then
                ActualizarDetalleTag_Operaciones()
            End If
            ''++++++fin actualizacion detalle administrativo

 
            For Each item As DataGridViewRow In dtgOpValorizacion.Rows
                If item.Cells("CHK").Value = True Then
                    oValorizacion.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
                    oValorizacion.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                    oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                    oValorizacion.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
                    If item.Cells("TPOPER").Value = "A" Then
                        List_Op = ""

                        If item.Tag IsNot Nothing Then
                            dtOperaciones = CType(item.Tag, DataTable)
                            For Each itemreg As DataRow In dtOperaciones.Rows
                                List_Op = List_Op & itemreg("NOPRCN") & ","
                            Next
                        End If


                        oValorizacion.NOPRCN_LIST = List_Op

                    Else
                        List_Op = item.Cells("NOPRCN").Value

                        oValorizacion.NOPRCN_LIST = List_Op
                    End If
                    oValorizacion.NSECFC = item.Cells("NSECFC").Value
                    oValorizacion.TPOPER = item.Cells("TPOPER").Value
                    oValorizacion.CULUSA = ConfigurationWizard.UserName
                    oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

                    If List_Op = "" Or List_Op = "0" Then
                        MessageBox.Show("Sin listado de operaciones", "Aviso", MessageBoxButtons.OK)
                        Exit Sub
                    End If
                    strmsg = obrValorizacion.EliminarOper_MantValorizacion_Op_List(oValorizacion)

                    If strmsg.Length > 0 And Not ListMsg.Contains(strmsg) Then
                        ListMsg(strmsg) = strmsg
                        sErrorMesage = sErrorMesage & strmsg & Chr(13)
                    End If
                End If
            Next


          




            sErrorMesage = sErrorMesage.Trim

            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                ListarOperacionesValorizadas()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "X" Then
                MessageBox.Show("No puede adicionar. El documento ya se encuentra generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim TipoValorizacion As String = ""
            TipoValorizacion = (dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim


            Select Case TipoValorizacion
                Case ""
                    Dim ofrmValorizacion As New frmNewValorizacion
                    ofrmValorizacion.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
                    ofrmValorizacion.pCCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                    ofrmValorizacion.pNROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                    ofrmValorizacion.pNROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
                    ofrmValorizacion.ShowDialog()
                    If ofrmValorizacion.myDialogResult = True Then
                        ListarOperacionesValorizadas()
                    End If


                Case "RV"

                    If dtgOpValorizacion.Rows.Count > 0 Then
                        MessageBox.Show("No puede adicionar. La valorización ya cuenta con servicio adicionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim pfrmAgregarServicioValorizacion As New frmAgregarServicioValorizacion

                    pfrmAgregarServicioValorizacion.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
                    pfrmAgregarServicioValorizacion.pCCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                    pfrmAgregarServicioValorizacion.pNROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value

                   

                    If pfrmAgregarServicioValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ListarOperacionesValorizadas()
                    End If


            End Select


          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnExportar1_Click(sender As Object, e As EventArgs)
        Try
            If Me.dtgValorizacion.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.dtgValorizacion
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Listado Valorizacion"
            strlFiltros.Add("Compañia : \n" & cboCompania.CCMPN_Descripcion)
            strlFiltros.Add("Cliente : \n" & UcCliente.pCodigo + " " + UcCliente.pRazonSocial)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If dtgOpValorizacion.Rows.Count = 0 Then
                MessageBox.Show("La valorización no tiene detalle para generar el envío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "X" Then
                MessageBox.Show("La valorización ya tiene documento de envío generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' VALIDACION DE TIPO VALORIZACION: RANGO VIAJE

            If (dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim = "RV" Then

                Dim Entidad As New beMantValorizacion
                Dim Negocio As New clsMantValorizacion
                Dim msg As String = ""

                With Entidad
                    .CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value.ToString
                    .NROVLR = CDec(dtgValorizacion.CurrentRow.Cells("NROVLR").Value)
                End With

                msg = Negocio.Calcular_Validar_Sustento_Viajes(Entidad)

                If msg.Trim.Length > 0 Then
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

            End If



            Dim obrValorizacion As New clsMantValorizacion

            Dim sStatus As String = ""
            Dim sErrorMesage As String = ""
            Dim dtTransaccion As New DataTable
            Dim strmsg As String = ""
            Dim sNro_ValorizEnvio As Decimal = 0
            Dim sNro_Valoriz As Decimal = 0
            Dim oValorizacion As New beMantValorizacion
            oValorizacion.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            oValorizacion.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            sNro_Valoriz = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.NROVLR = sNro_Valoriz
            oValorizacion.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina


            dtTransaccion = obrValorizacion.GenerarDocValorizacion(oValorizacion)


            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If dtTransaccion.Rows.Count > 0 Then

                    MessageBox.Show("Documento envío generado: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarValorizaciones()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEnviar1_Click(sender As Object, e As EventArgs) Handles btnEnviar1.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If


            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "" Then
                MessageBox.Show("Documento no generado aún.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim ofrmEnviarValorizacion As New frmEnviarValorizacion
            Dim oValorizacion As New beMantValorizacion
            Dim obrConfValorizacion As New clsMantValorizacion
            With oValorizacion
                .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
                .CCLNT = Me.UcCliente.pCodigo
                .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                .DOCVLR = dtgValorizacion.CurrentRow.Cells("DOCVLR").Value
                .NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
                .NCRRDE = dtgValorizacion.CurrentRow.Cells("NCRRDE").Value
            End With
            ofrmEnviarValorizacion.pbeValorizacion = oValorizacion
            If ofrmEnviarValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then

                ListarValorizaciones()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnAnulacion_Click(sender As Object, e As EventArgs) Handles btnAnulacion.Click

    '    Try

    '        If dtgValorizacion.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If

    '        Dim oValorizacion As New beMantValorizacion
    '        Dim obrValorizacion As New clsMantValorizacion

    '        Dim sErrorMesage As String = ""
    '        Dim sMesageAlerta As String = ""
    '        Dim sStatus As String = ""
    '        oValorizacion.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
    '        oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
    '        oValorizacion.OBSAVL = ""
    '        oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '        oValorizacion.CULUSA = ConfigurationWizard.UserName

    '        If MessageBox.Show("¿Está seguro de anular la valorización?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
    '            Exit Sub
    '        End If
    '        sErrorMesage = obrValorizacion.Anular_MantValorizacion(oValorizacion)
    '        If sErrorMesage.Length > 0 Then
    '            MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Else
    '            MessageBox.Show("La valorización fue anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            ListarValorizaciones()
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub
    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "" Then
                MessageBox.Show("Documento no generado aún.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dtgValorizacion.CurrentRow.Cells("NCRRDE").Value = 0 Then
                MessageBox.Show("Documento aún no enviado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim ofrmEnviarValorizacion As New frmAprobarNroValorizacion
            Dim oValorizacion As New beMantValorizacion
            Dim obrConfValorizacion As New clsMantValorizacion
            oValorizacion.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            oValorizacion.CCLNT = Me.UcCliente.pCodigo
            oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
            oValorizacion.NCRRDE = dtgValorizacion.CurrentRow.Cells("NCRRDE").Value

            ofrmEnviarValorizacion.pbeValorizacion = oValorizacion
            If ofrmEnviarValorizacion.ShowDialog() Then
                If ofrmEnviarValorizacion.pDialogResult = True Then
                    ListarValorizaciones()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub






    Private Sub dtgValorizacion_SelectionChanged(sender As Object, e As EventArgs) Handles dtgValorizacion.SelectionChanged
        Try
            checkall = False

            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            estado_Boton(Enum_Mantenimiento)

            If Me.dtgValorizacion.RowCount = 0 Then Exit Sub






            txtnumvalorizacion.Text = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            txtnumdocumento.Text = ("" & dtgValorizacion.CurrentRow.Cells("DOCVLR").Value).ToString.Trim
            txtFechaCorte.Text = ("" & dtgValorizacion.CurrentRow.Cells("REFCNT").Value).ToString.Trim
            txtFechaCorte.Tag = Val("" & dtgValorizacion.CurrentRow.Cells("CNFCVL").Value)
            txtAprobDias.Text = dtgValorizacion.CurrentRow.Cells("QDAPVL").Value
            txtestado.Text = ("" & dtgValorizacion.CurrentRow.Cells("ESTADO_VLR").Value).ToString.Trim
            cboDivision.SelectedValue = ""

            cboTipoValorizacion.ComboBox.SelectedValue = ("" & dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim 'N
            ListarOperacionesValorizadas()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarOperacionesValorizadas()
        Dim dtOP As New DataTable
        Dim dtVistaConsistencia As New DataTable
        Dim dsresult As New DataSet
        Dim obrFiltroValorizacion As New clsMantValorizacion
        oValorizacionFiltro = New beMantValorizacion
        oValorizacionFiltro.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
        oValorizacionFiltro.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
        oValorizacionFiltro.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
        oValorizacionFiltro.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
        oValorizacionFiltro.DOCGENERADO = ("" & dtgValorizacion.CurrentRow.Cells("FLGDSG").Value)
        oValorizacionFiltro.CDVSN = ("" & cboDivision.SelectedValue).ToString.Trim

        Dim pTipoValoriz As String = ("" & dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim

       
        dsresult = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)
        dtOP = dsresult.Tables(0)
        dtVistaConsistencia = dsresult.Tables(1)

        txt_SOLES.Text = 0
        txt_DOLAR.Text = 0
        If dtOP.Rows.Count > 0 Then
            txt_SOLES.Text = "S/: " & Val("" & dtOP.Compute("SUM(IMPORTE_S)", ""))
            txt_DOLAR.Text = "$: " & Val("" & dtOP.Compute("SUM(IMPORTE_D)", ""))
        End If


        dtVistaConsistencia.Columns.Add("SUSTENTO")
        For Each item As DataRow In dtVistaConsistencia.Rows

            If pTipoValoriz = "RV" Then
                item("SUSTENTO") = "Ver Sustento"
            End If
        Next

        dtgOpValorizacion.DataSource = dtVistaConsistencia
        dtgOpValorizacion.EndEdit()

 
        Dim drOperaciones() As DataRow
        For Each item As DataGridViewRow In dtgOpValorizacion.Rows
            If item.Cells("TPOPER").Value = "A" Then
                item.Cells("NOPRCN").Value = "Listado"
                drOperaciones = dtOP.Select("NSECFC='" & item.Cells("NSECFC").Value & "'")
                item.Tag = HelpClass.RowToDatatable(drOperaciones, dtOP)
            End If

          


        Next


      
    End Sub


 

    Private Sub TabGrupoClientes_Selected(sender As Object, e As TabControlEventArgs) Handles TabItemVal.Selected


        Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
        estado_Boton(Enum_Mantenimiento)

    End Sub

    Private Sub dtgValorizacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgValorizacion.CellDoubleClick
        Try
            Dim colName As String = ""
            colName = dtgValorizacion.Columns(e.ColumnIndex).Name

            If colName = "ENVIOS" Then
                Dim ofrmEnvios As New frmEnvios2

                ofrmEnvios.pCCMPN = Me.dtgValorizacion.CurrentRow.Cells("CCMPN").Value
                ofrmEnvios.pNROVLR = Me.dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                ofrmEnvios.pNROSGV = Me.dtgValorizacion.CurrentRow.Cells("NROSGV").Value
                ofrmEnvios.pNCRRDE_EnvioActivo = Me.dtgValorizacion.CurrentRow.Cells("NCRRDE").Value
                '
                ofrmEnvios.ShowDialog()
                If ofrmEnvios.pDialogResult = True Then
                    ListarValorizaciones()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tstExportarGeneral_Click(sender As Object, e As EventArgs) Handles tstExportarGeneral.Click

        Try
            Dim ODs As New DataSet
            Dim objDt As DataTable
            objDt = TransformarGrilla(Me.dtgValorizacion)
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "COMPAÑIA : " & " " & cboCompania.CCMPN_Descripcion))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "CLIENTE : " & IIf(UcCliente.pCodigo = 0, "TODOS", UcCliente.pCodigo & " - " & UcCliente.pRazonSocial)))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "VALORIZACION"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "CONSULTA VALORIZACION"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "CONSULTA VALORIZACION"))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "0.00"))
            If objDt.Columns("N° DOCUMENTO") IsNot Nothing Then
                objDt.Columns("N° DOCUMENTO").Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            End If
            ODs.Tables.Add(objDt.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub tstExportar_Detalle_Click(sender As Object, e As EventArgs) Handles tstExportar_Detalle.Click
        Try
            Dim dtOC As New DataTable
            Dim lstrPeriodo As String = ""
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim NPOI_AD As New Ransa.Utilitario.HelpClass_NPOI_AD

            Dim obrFiltroValorizacion As New clsMantValorizacion
            oValorizacionFiltro = New beMantValorizacion
            oValorizacionFiltro.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            oValorizacionFiltro.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            oValorizacionFiltro.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacionFiltro.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
            Dim dsresult As New DataSet
            Dim dtResult As New DataTable
            Dim dtserviciosTransportes As New DataTable
            Dim dtvalorizacion As New DataTable
            Dim dtServicios As New DataTable
            Dim dtOpAlmacenes As New DataTable
            Dim dtGuiaAlmacenes As New DataTable
            Dim dtLiquidaciones As New DataTable
            Dim dtGuiasOCTransporte As New DataTable

            dsresult = obrFiltroValorizacion.ListarServicioDetalleValorizacionExport(oValorizacionFiltro)
            dtvalorizacion = dsresult.Tables(0).Copy
            dtserviciosTransportes = dsresult.Tables(1).Copy
            dtGuiasOCTransporte = dsresult.Tables(2).Copy
            dtLiquidaciones = dsresult.Tables(3).Copy

            dtOpAlmacenes = dsresult.Tables(4).Copy
            dtGuiaAlmacenes = dsresult.Tables(5).Copy

            Dim dtExportTransporte As New DataTable
            dtExportTransporte = ExtraeDatoExportarTransporte(dtvalorizacion, dtserviciosTransportes, dtGuiasOCTransporte, dtLiquidaciones)
            dtExportTransporte.TableName = "TRANSPORTES"

            Dim dtExportAlmacen As New DataTable
            Dim TienenMismaMonedaAdmin As Boolean = False
            dtExportAlmacen = ExtraeDatoExportarAlmacen(dtvalorizacion, dtOpAlmacenes, dtGuiaAlmacenes, TienenMismaMonedaAdmin)
            dtExportAlmacen.TableName = "ADMINISTRACION"

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExportTransporte.Copy)
            ListaDatatable.Add(dtExportAlmacen.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            Dim tituloTexto As String = ""
            itemSortedList = New SortedList
            If dtvalorizacion.Rows.Count > 0 Then
                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & dtvalorizacion.Rows(0)("TCMPCL"))
                tituloTexto = dtvalorizacion.Rows(0)("NROVLR").ToString.PadLeft(10, "0") ' & "-" & dtvalorizacion.Rows(0)("NROSGV")
                tituloTexto = tituloTexto & " Doc Ref:" & dtvalorizacion.Rows(0)("DOCVLR")
                itemSortedList.Add(itemSortedList.Count, "Número Valorización:|" & tituloTexto)
                itemSortedList.Add(itemSortedList.Count, "Estado:|" & dtvalorizacion.Rows(0)("SEGVLR"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Valorización:|" & dtvalorizacion.Rows(0)("FCH_VAL"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Envío:|" & dtvalorizacion.Rows(0)("FCH_ENVIO") & " " & dtvalorizacion.Rows(0)("HRA_ENVIO"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Aprobación:|" & dtvalorizacion.Rows(0)("FCH_APROB") & " " & dtvalorizacion.Rows(0)("HRA_APROB"))
                itemSortedList.Add(itemSortedList.Count, "Usuario Valorizador:|" & dtvalorizacion.Rows(0)("USU_REG_VALORIZ"))
            Else
                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & UcCliente.pRazonSocial)
            End If
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            If dtvalorizacion.Rows.Count > 0 Then
                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & dtvalorizacion.Rows(0)("TCMPCL"))
                tituloTexto = dtvalorizacion.Rows(0)("NROVLR").ToString.PadLeft(10, "0") & "-" & dtvalorizacion.Rows(0)("NROSGV")
                tituloTexto = tituloTexto & " Doc Ref:" & dtvalorizacion.Rows(0)("DOCVLR")
                itemSortedList.Add(itemSortedList.Count, "Número Valorización:|" & tituloTexto)
                itemSortedList.Add(itemSortedList.Count, "Estado:|" & dtvalorizacion.Rows(0)("SEGVLR"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Valorización:|" & dtvalorizacion.Rows(0)("FCH_VAL"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Envío:|" & dtvalorizacion.Rows(0)("FCH_ENVIO") & " " & dtvalorizacion.Rows(0)("HRA_ENVIO"))
                itemSortedList.Add(itemSortedList.Count, "Fecha Aprobación:|" & dtvalorizacion.Rows(0)("FCH_APROB") & " " & dtvalorizacion.Rows(0)("HRA_APROB"))
                itemSortedList.Add(itemSortedList.Count, "Usuario Valorizador:|" & dtvalorizacion.Rows(0)("USU_REG_VALORIZ"))
            Else
                itemSortedList.Add(itemSortedList.Count, "Cliente:|" & UcCliente.pRazonSocial)
            End If
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("REPORTE DE VALORIZACIONES-GESTION TRANSPORTES")
            ListTitulo.Add("REPORTE DE VALORIZACIONES - GESTION ADMINISTRACION")

            Dim ListNCelda As New List(Of String)

            NPOI_AD.ExportExcelGeneralMultipleValorizacion(ListaDatatable, ListTitulo, ListNCelda, LisFiltros, Nothing, TienenMismaMonedaAdmin)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Function ExtraeDatoExportarAlmacen(dtValorizacion As DataTable, dtOPServicios As DataTable, dtGuiasOC As DataTable, ByRef TienenMismaMoneda As Boolean) As DataTable
        Dim dtservicios As New DataTable
        dtservicios = dtOPServicios.Copy

        Dim NPOI_SD As New Ransa.Utilitario.HelpClass_NPOI_AD
        Dim dtExport As New DataTable


        dtExport.Columns.Add("NSECFC").Caption = NPOI_SD.FormatDato("Nro Revisión", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NOPRCN").Caption = NPOI_SD.FormatDato("Operación", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("FOPRCN").Caption = NPOI_SD.FormatDato("Fecha Operación", HelpClass_NPOI_ST.keyDatoFecha)
        dtExport.Columns.Add("TIPRO").Caption = NPOI_SD.FormatDato("Tipo servicio", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NGUIRM").Caption = NPOI_SD.FormatDato("Guía Remisión", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NBRVCH").Caption = NPOI_SD.FormatDato("Brevete", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("TNMBCH").Caption = NPOI_SD.FormatDato("Conductor", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NPLCCM").Caption = NPOI_SD.FormatDato("Placa Tracto", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NPLACP").Caption = NPOI_SD.FormatDato("Placa Acoplado", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("CREFFW").Caption = NPOI_SD.FormatDato("Bulto", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("FREFFW").Caption = NPOI_SD.FormatDato("Fecha Ingreso", HelpClass_NPOI_ST.keyDatoFecha)
        dtExport.Columns.Add("FSLFFW").Caption = NPOI_SD.FormatDato("Fecha salida", HelpClass_NPOI_ST.keyDatoFecha)
        dtExport.Columns.Add("TIPBTO").Caption = NPOI_SD.FormatDato("Tipo Bulto", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("CANT_BULTO").Caption = NPOI_SD.FormatDato("Cantidad Bulto", HelpClass_NPOI_ST.keyDatoNumero)
        dtExport.Columns.Add("PESO_BULTO").Caption = NPOI_SD.FormatDato("Peso Bulto", HelpClass_NPOI_ST.keyDatoNumero)
        dtExport.Columns.Add("DESCRIP_BULTO").Caption = NPOI_SD.FormatDato("Referencia mercadería", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("AREA_BULTO").Caption = NPOI_SD.FormatDato("MT2", HelpClass_NPOI_ST.keyDatoNumero)

        dtExport.Columns.Add("OC").Caption = NPOI_SD.FormatDato("Órdenes de Compra", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("NRITOC").Caption = NPOI_SD.FormatDato("Item", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("CANT_ITEM").Caption = NPOI_SD.FormatDato("Cantidad Item", HelpClass_NPOI_ST.keyDatoNumero)
        dtExport.Columns.Add("TDITES").Caption = NPOI_SD.FormatDato("Descripción", HelpClass_NPOI_ST.keyDatoTexto)

        dtExport.Columns.Add("TMNDA").Caption = NPOI_SD.FormatDato("Moneda", HelpClass_NPOI_ST.keyDatoTexto)

        Dim distinctDT As DataTable = dtOPServicios.DefaultView.ToTable(True, "CSRVC", "IVLSRV", "SERVICIO")
        Dim titulocolumna As String = ""
        For Each item As DataRow In distinctDT.Rows
            titulocolumna = "SERV_" & item("CSRVC").ToString.Trim & "_" & item("IVLSRV").ToString.Trim
            dtExport.Columns.Add(titulocolumna).Caption = NPOI_SD.FormatDato(item("SERVICIO"), HelpClass_NPOI_ST.keyDatoNumero)
        Next

        dtExport.Columns.Add("IMPVLR_SOL").Caption = NPOI_SD.FormatDato("Importe Valorizado (S/.)", HelpClass_NPOI_ST.keyDatoNumero)
        dtExport.Columns.Add("IMPVLR_DOL").Caption = NPOI_SD.FormatDato("Importe Valorizado ($.)", HelpClass_NPOI_ST.keyDatoNumero)
        dtExport.Columns.Add("IMPOVLR_CALC").Caption = NPOI_SD.FormatDato("Importe Valorizado Calculado", HelpClass_NPOI_ST.keyDatoNumero)


        dtExport.Columns.Add("PLANTA").Caption = NPOI_SD.FormatDato("Planta", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("CCLNFC").Caption = NPOI_SD.FormatDato("Cod. Cliente Fact.", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("TCMPCL_FACT").Caption = NPOI_SD.FormatDato("Cliente Fact.", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("ESTADO_NOPRCN").Caption = NPOI_SD.FormatDato("Estado Operación", HelpClass_NPOI_ST.keyDatoTexto)

        dtExport.Columns.Add("COD_CEBE_SAP").Caption = NPOI_SD.FormatDato("Ce.Be. SAP ", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("CEBE_DESC").Caption = NPOI_SD.FormatDato("Centro Beneficio", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("MESPROV").Caption = NPOI_SD.FormatDato("Mes Año-Provision", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NRO_FACTURA").Caption = NPOI_SD.FormatDato("Nro Factura", HelpClass_NPOI_ST.keyDatoTexto)
        dtExport.Columns.Add("FCH_FACTURA").Caption = NPOI_SD.FormatDato("Fecha Factura", HelpClass_NPOI_ST.keyDatoTexto)


        Dim dr As DataRow
        dr = dtExport.NewRow
        Dim list() As String
        Dim FilaRecorridos As Boolean = False
        For Each item As DataColumn In dtExport.Columns
            titulocolumna = item.ColumnName
            If titulocolumna.StartsWith("SERV_") Then
                list = titulocolumna.Split("_")
                dr(titulocolumna) = list(2)
                FilaRecorridos = True
            End If
        Next
        If FilaRecorridos = True Then
            dr("NSECFC") = "X"
            dtExport.Rows.Add(dr)
        End If

        Dim FilaREg As Integer = 0
        Dim FilaREg2 As Integer = 0
        Dim FilaCol As Integer = 0

        Dim strlistado As String = ""

        Dim ListaVisitado As New Hashtable
        Dim drFiltro() As DataRow
        Dim pnoprcn As String = ""
        Dim ColMoneda As String = ""
        Dim ColImporte As String = ""
        Dim ColName As String = ""
        Dim drGuias() As DataRow
        Dim dtServ_x_OP As New DataTable




        Dim distinctMoneda As DataTable = dtOPServicios.DefaultView.ToTable(True, "CMNDA1")
        If distinctMoneda.Rows.Count = 1 Then
            TienenMismaMoneda = True
        End If



        For FilaREg = 0 To dtservicios.Rows.Count - 1
            pnoprcn = dtservicios.Rows(FilaREg)("NOPRCN").ToString.Trim
            If Not ListaVisitado.Contains(pnoprcn) Then

                ListaVisitado(pnoprcn.ToString.Trim) = pnoprcn.ToString.Trim


                dr = dtExport.NewRow
                For FilaCol = 0 To dtservicios.Columns.Count - 1
                    ColName = dtservicios.Columns(FilaCol).ColumnName
                    If dtExport.Columns(ColName) IsNot Nothing Then
                        dr(ColName) = dtservicios.Rows(FilaREg)(ColName)
                    End If
                Next
                drFiltro = dtservicios.Select("NOPRCN='" & pnoprcn & "'")
                dtServ_x_OP = HelpClass.RowToDatatable(drFiltro, dtservicios)

                Dim CodServ As String = ""
                Dim Tarifa As Decimal = 0
                Dim strTarifa As String = ""
                Dim Cantidad As Decimal = 0
                Dim ListVisitadoTarifa As New Hashtable
                Dim drsubserv() As DataRow

                Dim pSubTotalRecalculo As Decimal = 0
                Dim pSubTotalSol As Decimal = 0
                Dim pSubTotalDOL As Decimal = 0
                Dim pSubTotalRecalculoSOL As Decimal = 0
                Dim pSubTotalRecalculoDOL As Decimal = 0
                For Index As Integer = 0 To dtServ_x_OP.Rows.Count - 1
                    CodServ = dtServ_x_OP.Rows(Index)("CSRVC").ToString.Trim
                    Tarifa = dtServ_x_OP.Rows(Index)("IVLSRV")
                    strTarifa = dtServ_x_OP.Rows(Index)("IVLSRV").ToString.Trim
                    ColImporte = "SERV_" & CodServ & "_" & Tarifa
                    Cantidad = 0

                    If Not ListVisitadoTarifa.Contains(ColImporte) Then
                        drsubserv = dtServ_x_OP.Select("CSRVC='" & CodServ & "' AND IVLSRV='" & strTarifa & "'")
                        For Each item As DataRow In drsubserv
                            Cantidad = Cantidad + item("QATNAN")

                            pSubTotalSol = pSubTotalSol + dtServ_x_OP.Rows(Index)("IMP_SOL")
                            pSubTotalDOL = pSubTotalDOL + dtServ_x_OP.Rows(Index)("IMP_DOL")
                        Next
                        If dtExport.Columns(ColImporte) IsNot Nothing Then
                            dr(ColImporte) = Cantidad
                        End If
                        ListVisitadoTarifa(ColImporte) = ColImporte
                    End If

                    pSubTotalRecalculo = pSubTotalRecalculo + Math.Round(Cantidad * Tarifa, 2, MidpointRounding.AwayFromZero)
                Next
               
                dr("IMPVLR_SOL") = pSubTotalSol
                dr("IMPVLR_DOL") = pSubTotalDOL
                dr("IMPOVLR_CALC") = pSubTotalRecalculo

                strlistado = GetListadoCampo(dtServ_x_OP, "CCNBNS")
                dr("COD_CEBE_SAP") = strlistado
                strlistado = GetListadoCampo(dtServ_x_OP, "TCNTCS")
                dr("CEBE_DESC") = strlistado
                strlistado = GetListadoCampo(dtServ_x_OP, "NDCFCC")
                dr("NRO_FACTURA") = strlistado
                strlistado = GetListadoCampo(dtServ_x_OP, "FDCFCC")
                dr("FCH_FACTURA") = strlistado

                dtExport.Rows.Add(dr)



                drGuias = dtGuiasOC.Select("NOPRCN='" & pnoprcn & "'")
                If drGuias.Length > 0 Then
                    For FilaREg2 = 0 To drGuias.Length - 1
                        If FilaREg2 = 0 Then ' SI ES PRIMERA FILA COMPLETA CON LAS GR
                            For FilaCol = 0 To dtGuiasOC.Columns.Count - 1
                                ColName = dtGuiasOC.Columns(FilaCol).ColumnName
                                If dtExport.Columns(ColName) IsNot Nothing Then
                                    dtExport.Rows(dtExport.Rows.Count - 1)(ColName) = drGuias(FilaREg2)(ColName)
                                End If
                            Next

                        Else ' CASO CONTRARIO SE ADICIONAN FILAS Y SE COMPLETAN LAS GUÍAS
                            dr = dtExport.NewRow
                            For FilaCol = 0 To dtGuiasOC.Columns.Count - 1
                                ColName = dtGuiasOC.Columns(FilaCol).ColumnName
                                If dtExport.Columns(ColName) IsNot Nothing Then
                                    dr(ColName) = drGuias(FilaREg2)(ColName)
                                End If
                            Next
                            dtExport.Rows.Add(dr)
                        End If
                    Next
                End If

            End If
        Next

        Dim ListaRepetidos As New Hashtable
        Dim ColBulto As String = ""
        Dim Operacion As String = ""
        For Each item As DataRow In dtExport.Rows
            Operacion = ("" & item("NOPRCN").ToString.Trim)

            If Operacion.Trim <> "" Then


                ColBulto = item("NOPRCN") & "_" & item("NGUIRM") & "_" & item("CREFFW").ToString.Trim
                If Not ListaRepetidos.Contains(ColBulto) Then
                    ListaRepetidos(ColBulto) = ColBulto
                Else
                    item("CREFFW") = ""
                    item("FREFFW") = DBNull.Value
                    item("FSLFFW") = DBNull.Value
                    item("NPLCCM") = ""
                    item("NPLACP") = ""
                    item("NBRVCH") = ""
                    item("TNMBCH") = ""
                    item("TIPBTO") = ""
                    item("CANT_BULTO") = DBNull.Value
                    item("PESO_BULTO") = DBNull.Value
                    item("CANT_BULTO") = DBNull.Value
                    item("AREA_BULTO") = DBNull.Value
                    item("DESCRIP_BULTO") = ""
                End If

                If Not ListaRepetidos.Contains(Operacion) Then
                    ListaRepetidos(Operacion) = Operacion
                Else
                    item("NOPRCN") = DBNull.Value
                    item("FOPRCN") = DBNull.Value
                    item("NSECFC") = DBNull.Value
                    item("TIPRO") = ""
                    item("TIPRO") = ""
                    item("PLANTA") = ""
                    item("CCLNFC") = ""
                    item("TCMPCL_FACT") = ""
                    item("ESTADO_NOPRCN") = ""
                    item("COD_CEBE_SAP") = ""
                    item("CEBE_DESC") = ""
                    item("MESPROV") = ""
                    item("NRO_FACTURA") = ""
                    item("FCH_FACTURA") = ""

                End If

            End If


        Next

        Return dtExport
    End Function


    Private Function ExtraeDatoExportarTransporte_Rango(dtValorizacion As DataTable, dtOperaciones As DataTable, dtGuiasOCTransporte As DataTable, dtLiquidaciones As DataTable) As DataTable
        Dim dtservicios As New DataTable
        dtservicios = dtOperaciones.Copy

        Dim NPOI_SD As New Ransa.Utilitario.HelpClass_NPOI_AD

        Dim dtExport As New DataTable


        dtExport.Columns.Add("PLANTA").Caption = NPOI_SD.FormatDato("Planta", HelpClass_NPOI_AD.keyDatoTexto)
        'dtExport.Columns.Add("NGUITR").Caption = NPOI_SD.FormatDato("Guía Transporte", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NGUITS").Caption = NPOI_SD.FormatDato("Guía Transporte", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NGUIRM").Caption = NPOI_SD.FormatDato("Guía Remisión", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("ORDE_COMPRA").Caption = NPOI_SD.FormatDato("Orden Compra", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("ORIGEN").Caption = NPOI_SD.FormatDato("Punto Partida", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("DESTINO").Caption = NPOI_SD.FormatDato("Punto Llegada", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("TCMTRT").Caption = NPOI_SD.FormatDato("Transportista", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NPLCTR").Caption = NPOI_SD.FormatDato("Placa Tracto", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NPLCAC").Caption = NPOI_SD.FormatDato("Placa Acoplado", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CONDUCTOR").Caption = NPOI_SD.FormatDato("Conductor", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CBRCNT").Caption = NPOI_SD.FormatDato("Brevete", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("TIPO_VEHICULO").Caption = NPOI_SD.FormatDato("Tipo Vehículo", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FSLDCM").Caption = NPOI_SD.FormatDato("Fecha Salida", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("FLLGCM").Caption = NPOI_SD.FormatDato("Fecha Llegada", HelpClass_NPOI_AD.keyDatoFecha)
        'dtExport.Columns.Add("PBRTOR").Caption = NPOI_SD.FormatDato("Peso Remisión", HelpClass_NPOI_AD.keyDatoNumero)
        'dtExport.Columns.Add("PBRDST").Caption = NPOI_SD.FormatDato("Peso Recepción", HelpClass_NPOI_AD.keyDatoNumero)
        dtExport.Columns.Add("PBRDST").Caption = NPOI_SD.FormatDato("Peso Recepción", HelpClass_NPOI_AD.keyDatoNumero)
        dtExport.Columns.Add("PESO_ALM").Caption = NPOI_SD.FormatDato("Peso Almacén o Remisión", HelpClass_NPOI_AD.keyDatoNumero)

        dtExport.Columns.Add("ORIGEN_PESO").Caption = NPOI_SD.FormatDato("Origen peso", HelpClass_NPOI_AD.keyDatoTexto)



        dtExport.Columns.Add("ORIGEN_IMPO").Caption = NPOI_SD.FormatDato("Origen Impo.", HelpClass_NPOI_AD.keyDatoTexto)


        Dim distinctDT As DataTable = dtservicios.DefaultView.ToTable(True, "CSRVC", "SERVICIO")
        For Each item As DataRow In distinctDT.Rows
            dtExport.Columns.Add(item("CSRVC") & "_" & "MONSERV").Caption = NPOI_SD.FormatDato("Mon. Cobrar", HelpClass_NPOI_AD.keyDatoTexto)
            dtExport.Columns.Add(item("CSRVC") & "_" & item("SERVICIO").ToString.Trim).Caption = NPOI_SD.FormatDato(item("SERVICIO"), HelpClass_NPOI_AD.keyDatoNumero)
        Next


        dtExport.Columns.Add("IMP_FLET_DOL").Caption = NPOI_SD.FormatDato("Pago Flete($)", HelpClass_NPOI_AD.keyDatoNumero)



        'dtExport.Columns.Add("IMPVLR_SOL").Caption = NPOI_SD.FormatDato("Importe Valorizado(S/.)", HelpClass_NPOI_AD.keyDatoNumero)
        'dtExport.Columns.Add("IMPVLR_DOL").Caption = NPOI_SD.FormatDato("Importe Valorizado($)", HelpClass_NPOI_AD.keyDatoNumero)

        dtExport.Columns.Add("FGUIRM").Caption = NPOI_SD.FormatDato("Fecha Guía Transporte", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("NOPRCN").Caption = NPOI_SD.FormatDato("Operación", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("DOCVLR").Caption = NPOI_SD.FormatDato("Doc. Valoriz.", HelpClass_NPOI_AD.keyDatoTexto)



        dtExport.Columns.Add("FINCOP").Caption = NPOI_SD.FormatDato("Fecha Operación", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("ESTADO_NOPRCN").Caption = NPOI_SD.FormatDato("Estado Operación", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NDCPRF").Caption = NPOI_SD.FormatDato("Pre Factura", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FDCPRF").Caption = NPOI_SD.FormatDato("Fecha Pre-Factura", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("NPRLQD").Caption = NPOI_SD.FormatDato("Número PreLiquidación", HelpClass_NPOI_AD.keyDatoTexto)



        dtExport.Columns.Add("NUM_LIQ").Caption = NPOI_SD.FormatDato("N° Liquidación Flete", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FCH_LIQ").Caption = NPOI_SD.FormatDato("Fecha Liquidación Flete", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("MESPROV").Caption = NPOI_SD.FormatDato("Mes Año-Provision", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NRO_FACT").Caption = NPOI_SD.FormatDato("N° Factura", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FCH_FACT").Caption = NPOI_SD.FormatDato("Fecha Factura", HelpClass_NPOI_AD.keyDatoFecha)



        dtExport.Columns.Add("TCRVTA").Caption = NPOI_SD.FormatDato("Negocio/Sector", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CCNCST").Caption = NPOI_SD.FormatDato("CeBe Sector", HelpClass_NPOI_AD.keyDatoTexto)


        Dim FilaREg As Integer = 0
        Dim FilaCol As Integer = 0
        Dim dr As DataRow
        Dim ListaVisitado As New Hashtable
        Dim drFiltro() As DataRow
        Dim noprcn As String = ""
        Dim ColMoneda As String = ""
        Dim ColImporte As String = ""
        Dim ColName As String = ""
        Dim drOC() As DataRow
        Dim drLiq() As DataRow
        Dim dtOC As New DataTable
        Dim dtLiq As New DataTable

        Dim strlistado As String = ""
        'Dim pSoles As Decimal = 0
        'Dim pDolar As Decimal = 0

        Dim pPagoFletDol As Decimal = 0
        For FilaREg = 0 To dtservicios.Rows.Count - 1
            noprcn = dtservicios.Rows(FilaREg)("NOPRCN").ToString.Trim
            If Not ListaVisitado.Contains(noprcn) Then
                dr = dtExport.NewRow
                For FilaCol = 0 To dtservicios.Columns.Count - 1
                    ColName = dtservicios.Columns(FilaCol).ColumnName
                    If dtExport.Columns(ColName) IsNot Nothing Then
                        dr(ColName) = dtservicios.Rows(FilaREg)(ColName)
                    End If
                Next
                drFiltro = dtservicios.Select("NOPRCN='" & noprcn & "'")
                ListaVisitado(noprcn.ToString.Trim) = noprcn.ToString.Trim

                'pSoles = 0
                'pDolar = 0

                pPagoFletDol = 0
                For Index As Integer = 0 To drFiltro.Length - 1
                    ColMoneda = drFiltro(Index)("CSRVC") & "_" & "MONSERV"
                    ColImporte = drFiltro(Index)("CSRVC") & "_" & drFiltro(Index)("SERVICIO").ToString.Trim

                    If dtExport.Columns(ColMoneda) IsNot Nothing AndAlso dtExport.Columns(ColImporte) IsNot Nothing Then
                        dr(ColMoneda) = drFiltro(Index)("ABR_MONEDA")
                        dr(ColImporte) = drFiltro(Index)("IMPORTE")
                    End If

                    pPagoFletDol = pPagoFletDol + drFiltro(Index)("PAGO_FLETE_DOL")
                    'pSoles = pSoles + drFiltro(Index)("IMP_SOL")
                    'pDolar = pDolar + drFiltro(Index)("IMP_DOL")
                Next

                'dr("IMPVLR_SOL") = pSoles
                'dr("IMPVLR_DOL") = pDolar

                dr("IMP_FLET_DOL") = pPagoFletDol


                drOC = dtGuiasOCTransporte.Select("NOPRCN='" & noprcn & "'")
                dtOC = HelpClass.RowToDatatable(drOC, dtGuiasOCTransporte)
                strlistado = GetListadoCampo(dtOC, "NORCMC")
                dr("ORDE_COMPRA") = strlistado

                drLiq = dtLiquidaciones.Select("NOPRCN='" & noprcn & "'")
                dtLiq = HelpClass.RowToDatatable(drLiq, dtLiquidaciones)
                strlistado = GetListadoCampo(dtLiq, "NLQDCN")
                dr("NUM_LIQ") = strlistado
                strlistado = GetListadoCampo(dtLiq, "FLQDCN")
                dr("FCH_LIQ") = strlistado
                strlistado = GetListadoCampo(dtLiq, "NDCMFC")
                dr("NRO_FACT") = strlistado
                strlistado = GetListadoCampo(dtLiq, "FECFAC")
                dr("FCH_FACT") = strlistado



                dtExport.Rows.Add(dr)
            End If
        Next
        Return dtExport
    End Function

    Private Function ExtraeDatoExportarTransporte(dtValorizacion As DataTable, dtOperaciones As DataTable, dtGuiasOCTransporte As DataTable, dtLiquidaciones As DataTable) As DataTable
        Dim dtservicios As New DataTable
        dtservicios = dtOperaciones.Copy

        Dim NPOI_SD As New Ransa.Utilitario.HelpClass_NPOI_AD

        Dim dtExport As New DataTable


        dtExport.Columns.Add("PLANTA").Caption = NPOI_SD.FormatDato("Planta", HelpClass_NPOI_AD.keyDatoTexto)
        'dtExport.Columns.Add("NGUITR").Caption = NPOI_SD.FormatDato("Guía Transporte", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NGUITS").Caption = NPOI_SD.FormatDato("Guía Transporte", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NGUIRM").Caption = NPOI_SD.FormatDato("Guía Remisión", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("ORDE_COMPRA").Caption = NPOI_SD.FormatDato("Orden Compra", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("ORIGEN").Caption = NPOI_SD.FormatDato("Punto Partida", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("DESTINO").Caption = NPOI_SD.FormatDato("Punto Llegada", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("TCMTRT").Caption = NPOI_SD.FormatDato("Transportista", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NPLCTR").Caption = NPOI_SD.FormatDato("Placa Tracto", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NPLCAC").Caption = NPOI_SD.FormatDato("Placa Acoplado", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CONDUCTOR").Caption = NPOI_SD.FormatDato("Conductor", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CBRCNT").Caption = NPOI_SD.FormatDato("Brevete", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("TIPO_VEHICULO").Caption = NPOI_SD.FormatDato("Tipo Vehículo", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FSLDCM").Caption = NPOI_SD.FormatDato("Fecha Salida", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("FLLGCM").Caption = NPOI_SD.FormatDato("Fecha Llegada", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("PBRTOR").Caption = NPOI_SD.FormatDato("Peso Remisión", HelpClass_NPOI_AD.keyDatoNumero)
        'dtExport.Columns.Add("PBRDST").Caption = NPOI_SD.FormatDato("Peso Recepción", HelpClass_NPOI_AD.keyDatoNumero)
        dtExport.Columns.Add("PESO_ALM").Caption = NPOI_SD.FormatDato("Peso Almacén o Remisión", HelpClass_NPOI_AD.keyDatoNumero)
        dtExport.Columns.Add("ORIGEN_PESO").Caption = NPOI_SD.FormatDato("Origen peso", HelpClass_NPOI_AD.keyDatoTexto)


        Dim distinctDT As DataTable = dtservicios.DefaultView.ToTable(True, "CSRVC", "SERVICIO")
        For Each item As DataRow In distinctDT.Rows
            dtExport.Columns.Add(item("CSRVC") & "_" & "MONSERV").Caption = NPOI_SD.FormatDato("Mon. Cobrar", HelpClass_NPOI_AD.keyDatoTexto)
            dtExport.Columns.Add(item("CSRVC") & "_" & item("SERVICIO").ToString.Trim).Caption = NPOI_SD.FormatDato(item("SERVICIO"), HelpClass_NPOI_AD.keyDatoNumero)
        Next

        dtExport.Columns.Add("IMPVLR_SOL").Caption = NPOI_SD.FormatDato("Importe Valorizado(S/.)", HelpClass_NPOI_AD.keyDatoNumero)
        dtExport.Columns.Add("IMPVLR_DOL").Caption = NPOI_SD.FormatDato("Importe Valorizado($)", HelpClass_NPOI_AD.keyDatoNumero)

        dtExport.Columns.Add("FGUIRM").Caption = NPOI_SD.FormatDato("Fecha Guía Transporte", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("NOPRCN").Caption = NPOI_SD.FormatDato("Operación", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FINCOP").Caption = NPOI_SD.FormatDato("Fecha Operación", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("ESTADO_NOPRCN").Caption = NPOI_SD.FormatDato("Estado Operación", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NDCPRF").Caption = NPOI_SD.FormatDato("Pre Factura", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FDCPRF").Caption = NPOI_SD.FormatDato("Fecha Pre-Factura", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("NPRLQD").Caption = NPOI_SD.FormatDato("Número PreLiquidación", HelpClass_NPOI_AD.keyDatoTexto)



        dtExport.Columns.Add("NUM_LIQ").Caption = NPOI_SD.FormatDato("N° Liquidación Flete", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FCH_LIQ").Caption = NPOI_SD.FormatDato("Fecha Liquidación Flete", HelpClass_NPOI_AD.keyDatoFecha)
        dtExport.Columns.Add("MESPROV").Caption = NPOI_SD.FormatDato("Mes Año-Provision", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("NRO_FACT").Caption = NPOI_SD.FormatDato("N° Factura", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("FCH_FACT").Caption = NPOI_SD.FormatDato("Fecha Factura", HelpClass_NPOI_AD.keyDatoFecha)



        dtExport.Columns.Add("TCRVTA").Caption = NPOI_SD.FormatDato("Negocio/Sector", HelpClass_NPOI_AD.keyDatoTexto)
        dtExport.Columns.Add("CCNCST").Caption = NPOI_SD.FormatDato("CeBe Sector", HelpClass_NPOI_AD.keyDatoTexto)


        Dim FilaREg As Integer = 0
        Dim FilaCol As Integer = 0
        Dim dr As DataRow
        Dim ListaVisitado As New Hashtable
        Dim drFiltro() As DataRow
        Dim noprcn As String = ""
        Dim ColMoneda As String = ""
        Dim ColImporte As String = ""
        Dim ColName As String = ""
        Dim drOC() As DataRow
        Dim drLiq() As DataRow
        Dim dtOC As New DataTable
        Dim dtLiq As New DataTable

        Dim strlistado As String = ""
        Dim pSoles As Decimal = 0
        Dim pDolar As Decimal = 0
        For FilaREg = 0 To dtservicios.Rows.Count - 1
            noprcn = dtservicios.Rows(FilaREg)("NOPRCN").ToString.Trim
            If Not ListaVisitado.Contains(noprcn) Then
                dr = dtExport.NewRow
                For FilaCol = 0 To dtservicios.Columns.Count - 1
                    ColName = dtservicios.Columns(FilaCol).ColumnName
                    If dtExport.Columns(ColName) IsNot Nothing Then
                        dr(ColName) = dtservicios.Rows(FilaREg)(ColName)
                    End If
                Next
                drFiltro = dtservicios.Select("NOPRCN='" & noprcn & "'")
                ListaVisitado(noprcn.ToString.Trim) = noprcn.ToString.Trim

                pSoles = 0
                pDolar = 0

                For Index As Integer = 0 To drFiltro.Length - 1
                    ColMoneda = drFiltro(Index)("CSRVC") & "_" & "MONSERV"
                    ColImporte = drFiltro(Index)("CSRVC") & "_" & drFiltro(Index)("SERVICIO").ToString.Trim

                    If dtExport.Columns(ColMoneda) IsNot Nothing AndAlso dtExport.Columns(ColImporte) IsNot Nothing Then
                        dr(ColMoneda) = drFiltro(Index)("ABR_MONEDA")
                        dr(ColImporte) = drFiltro(Index)("IMPORTE")
                    End If

                    pSoles = pSoles + drFiltro(Index)("IMP_SOL")
                    pDolar = pDolar + drFiltro(Index)("IMP_DOL")
                Next

                dr("IMPVLR_SOL") = pSoles
                dr("IMPVLR_DOL") = pDolar

                drOC = dtGuiasOCTransporte.Select("NOPRCN='" & noprcn & "'")
                dtOC = HelpClass.RowToDatatable(drOC, dtGuiasOCTransporte)
                strlistado = GetListadoCampo(dtOC, "NORCMC")
                dr("ORDE_COMPRA") = strlistado

                drLiq = dtLiquidaciones.Select("NOPRCN='" & noprcn & "'")
                dtLiq = HelpClass.RowToDatatable(drLiq, dtLiquidaciones)
                strlistado = GetListadoCampo(dtLiq, "NLQDCN")
                dr("NUM_LIQ") = strlistado
                strlistado = GetListadoCampo(dtLiq, "FLQDCN")
                dr("FCH_LIQ") = strlistado
                strlistado = GetListadoCampo(dtLiq, "NDCMFC")
                dr("NRO_FACT") = strlistado
                strlistado = GetListadoCampo(dtLiq, "FECFAC")
                dr("FCH_FACT") = strlistado



                dtExport.Rows.Add(dr)
            End If
        Next
        Return dtExport
    End Function

    Private Function GetListadoCampo(dt As DataTable, ColumnaListado As String) As String
        Dim ListDuplicado As New Hashtable
        Dim CeldaValor As String = ""
        Dim strCeldaValor As String = ""
        For Each item As DataRow In dt.Rows
            CeldaValor = ("" & item(ColumnaListado)).ToString.Trim
            If CeldaValor <> "" And CeldaValor <> "0" And Not ListDuplicado.Contains(CeldaValor) Then
                strCeldaValor = strCeldaValor & CeldaValor & "," & Chr(10)
                ListDuplicado(CeldaValor) = CeldaValor
            End If
        Next
        If strCeldaValor.Length > 0 Then
            strCeldaValor = strCeldaValor.Trim
            strCeldaValor = strCeldaValor.Substring(0, strCeldaValor.Length - 1)
        End If

        Return strCeldaValor
    End Function


    Private Sub tstExportar_X_NroDocSeg_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click


        Try

            If Me.UcCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            txtnumvalorizacion.Text = ""
            txtnumdocumento.Text = ""
            txtFechaCorte.Text = ""
            txtAprobDias.Text = ""
            txtestado.Text = ""



            Enum_Mantenimiento = MANTENIMIENTO_OPC.NUEVO
            estado_Boton(Enum_Mantenimiento)
            BuscarFechaCorteyDiasCorte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BuscarFechaCorteyDiasCorte()
        Dim oValorizacion As New Valorizacion
        Dim obrConfValorizacion As New clsConfValorizacion
        Dim dt As New DataTable
        With oValorizacion
            .CCMPN = cboCompania.CCMPN_CodigoCompania
            .CCLNT = UcCliente.pCodigo
            .SESTRG = "A"
        End With
        dt = obrConfValorizacion.ListarConfCierreValorizacion(oValorizacion)
        If dt.Rows.Count = 1 Then
            txtFechaCorte.Text = dt.Rows(0)("REFCNT").ToString.Trim
            txtAprobDias.Text = dt.Rows(0)("QDAPVL").ToString.Trim
            txtFechaCorte.Tag = dt.Rows(0)("CNFCVL").ToString.Trim   '  oListConfig.pCNFCVL

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim msgValidacion As String = ""
            msgValidacion = ValidarIngreso()
            If msgValidacion.Length > 0 Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oValorizacionCab As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

            oValorizacionCab.CCMPN = cboCompania.CCMPN_CodigoCompania
            oValorizacionCab.CCLNT = UcCliente.pCodigo
            oValorizacionCab.DOCVLR = txtnumdocumento.Text.Trim
            oValorizacionCab.REFCNT = txtFechaCorte.Text.Trim

            oValorizacionCab.QDAPVL = Val(txtAprobDias.Text)
            oValorizacionCab.CULUSA = ConfigurationWizard.UserName
            oValorizacionCab.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            oValorizacionCab.CNFCVL = Val("" & txtFechaCorte.Tag)

            oValorizacionCab.TPOVLR = cboTipoValorizacion.SelectedValue


            Dim msg As String = ""
            Dim NroValorizacion As Decimal = 0
            If Enum_Mantenimiento = MANTENIMIENTO_OPC.NUEVO Then
                msg = obrValorizacion.RegistrarValorizacionCabecera(NroValorizacion, oValorizacionCab)
                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Se creó la valorización " & NroValorizacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            If Enum_Mantenimiento = MANTENIMIENTO_OPC.MODIFICAR Then
                oValorizacionCab.NROVLR = Me.dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                msg = obrValorizacion.ActualizarValorizacionCabecera(oValorizacionCab)
                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                MessageBox.Show("Valorización actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            ListarValorizaciones()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
    Private Function ValidarIngreso() As String
        Dim msg As String = ""
        txtnumdocumento.Text = txtnumdocumento.Text.Trim
        If txtFechaCorte.Text.Trim = "" Then
            msg = " * Fecha corte."
        End If
        If txtAprobDias.Text.Trim = "" Then
            msg = msg & " * Días aprobación."
        End If
        If txtnumdocumento.Text.Trim().Length = 0 Then
            msg = msg & " * Ingrese N° Doc Valorización "
        End If
        If UcCliente.pCodigo = 0 Then
            msg = msg & " * Seleccione cliente "
        End If

        Return msg
    End Function

    Private Sub btnAnularDocSeg_Click(sender As Object, e As EventArgs) Handles btnAnularDocSeg.Click
        Try

            Dim obrValorizacion As New clsMantValorizacion
            Dim strmsg As String = ""
            Dim oValorizacion As New beMantValorizacion
            oValorizacion.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            oValorizacion.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value

            If dtgValorizacion.CurrentRow.Cells("FLGDSG").Value = "" Then
                MessageBox.Show("No tiene documento generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If MessageBox.Show("¿Está seguro de anular documento generado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            strmsg = obrValorizacion.LiberarDocumentoGenerado(oValorizacion)
            If strmsg.Length > 0 Then
                MessageBox.Show(strmsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                txtNroValorizacion.Text = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                ListarValorizaciones()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        If dtgValorizacion.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Enum_Mantenimiento = MANTENIMIENTO_OPC.MODIFICAR
        estado_Boton(Enum_Mantenimiento)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            estado_Boton(Enum_Mantenimiento)
            dtgValorizacion_SelectionChanged(dtgValorizacion, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function TransformarGrilla(ByVal gv As DataGridView) As DataTable
        Dim dtData As New DataTable
        For Each Item As DataGridViewColumn In gv.Columns
            If Item.Visible = True And (Item.Name <> "ENVIOS" And Item.Name <> "RPTA_A_TIEMPO") Then
                dtData.Columns.Add(Item.Name)
            End If
        Next


        Dim dr As DataRow
        Dim NameColumna As String = ""
        For Each Item As DataGridViewRow In gv.Rows
            dr = dtData.NewRow
            For Each dcColumna As DataColumn In dtData.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = Item.Cells(NameColumna).Value
            Next
            dtData.Rows.Add(dr)
        Next

        For Each Item As DataColumn In dtData.Columns
            Item.ColumnName = gv.Columns(Item.ColumnName).HeaderText
        Next

        Return dtData

    End Function

    Private checkall As Boolean = False
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Try
            For Each item As DataGridViewRow In dtgOpValorizacion.Rows
                item.Cells("CHK").Value = Not checkall
            Next
            dtgOpValorizacion.EndEdit()
            checkall = Not checkall
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConfigCierre_Click(sender As Object, e As EventArgs) Handles btnConfigCierre.Click
        Try

            If UcCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oListConfig As New frmListaConfigValorizacion
            oListConfig.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
            oListConfig.pCCLNT = Me.UcCliente.pCodigo
            If oListConfig.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFechaCorte.Text = oListConfig.pREFCNT
                txtAprobDias.Text = oListConfig.pQDAPVL
                txtFechaCorte.Tag = oListConfig.pCNFCVL
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
        For lint_Contador As Integer = 0 To Sender.RowCount - 1
            If Sender.Item("chk", lint_Contador).Value = True Then
                If intIndice = 0 Then
                    cOrgVenta = Sender.Item("CRGVTA", lint_Contador).Value
                    'dOrgVenta = Sender.Item("TCRVTA_D", lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Sender.Item("CRGVTA", lint_Contador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If

        Next
        Return lstr_Estado
    End Function

    Private Sub btnGenerarPL_Click(sender As Object, e As EventArgs) Handles btnGenerarPL.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If cboDivision.SelectedValue = "" Then
                MessageBox.Show("Seleccione negocio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim smgValidacion As String = ValidarOperacionesPendientePL()
            If smgValidacion.Length > 0 Then
                MessageBox.Show(smgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dtgOpValorizacion.RowCount = 0 Then Exit Sub
            Dim objEntidad As New beFactura_Transporte
            Dim objGenericCollection As New List(Of beFactura_Transporte)
            Dim objfrmListaPreFactura As New frmListaPreFacturaPl


            Me.dtgOpValorizacion.EndEdit()



            If Consistencia_Organizacion_Venta(Me.dtgOpValorizacion) = False Then
                HelpClass.MsgBox("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim VLR_CANT As Decimal = 0
            Dim CompSoles As Boolean = False
            Dim CompDolar As Boolean = False
            Dim msgComparacion As String = ""
            Dim pCodDivision As String = ""
            Dim TipoOpIni As String = ""
            Dim TipoOp As String = ""
            Dim fila As Int32 = 0
            Dim bTodosIgualTipo As Boolean = True
           
          


            For Each row As DataGridViewRow In dtgOpValorizacion.Rows
                If row.Cells("CHK").Value = True Then
                    objEntidad = New beFactura_Transporte
                    objEntidad.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                    objEntidad.NSECFC = row.Cells("NSECFC").Value
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.IMPOCOS = row.Cells("IMPORTE_S").Value
                    objEntidad.IMPOCOD = row.Cells("IMPORTE_D").Value
                    objEntidad.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
                    objEntidad.CDVSN = row.Cells("CDVSN").Value
                    pCodDivision = row.Cells("CDVSN").Value
                    objGenericCollection.Add(objEntidad)

                    TipoOp = ("" & row.Cells("TPOPER").Value).ToString.Trim
                    If fila = 0 Then
                        TipoOpIni = ("" & row.Cells("TPOPER").Value).ToString.Trim
                    End If
                    If TipoOp <> TipoOpIni Then
                        bTodosIgualTipo = False
                    End If

                    fila = fila + 1
                End If
            Next

            If bTodosIgualTipo = False Then
                MessageBox.Show("Operaciones pertenecen a distintos tipos de operación. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If objGenericCollection.Count = 0 Then Exit Sub
            With objfrmListaPreFactura
                .CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                .CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
                .CDVSN = pCodDivision
 
                .pNROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                .ListFactura_Transporte = objGenericCollection
                .pTipoOP = TipoOpIni
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListarOperacionesValorizadas()
                End If

            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarOperacionesPendientePL() As String
        Dim strvalidacion As String = ""
        dtgOpValorizacion.EndEdit()
        Dim CantOp As Int32 = 0
        For Each item As DataGridViewRow In dtgOpValorizacion.Rows
            If item.Cells("CHK").Value = True Then
                If item.Cells("TPOPER").Value = "T" Then
                    If (item.Cells("NDCPRF").Value <> 0 And item.Cells("NPRLQD").Value = 0) = False Then
                        strvalidacion = "Debe seleccionar solo operaciones Pendientes PL(PreFacturados)."
                        Exit For
                    End If
                End If
                If item.Cells("TPOPER").Value = "A" Then

                    If (item.Cells("NSECFC").Value <> 0 And item.Cells("NPRLQD").Value = 0) = False Then
                        strvalidacion = "Debe seleccionar solo operaciones Pendientes PL(Consistencia)."
                        Exit For
                    End If
                End If

                CantOp = CantOp + 1
            End If
        Next
        If CantOp = 0 Then
            strvalidacion = "No ha seleccionado operaciones válidas."
        End If
        Return strvalidacion
    End Function
    Private Sub btnCheckPend_Click(sender As Object, e As EventArgs) Handles btnCheckPend.Click

        Try
            If cboDivision.SelectedValue = "" Then
                MessageBox.Show("Seleccione negocio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            For Each item As DataGridViewRow In dtgOpValorizacion.Rows
                If ((item.Cells("TPOPER").Value = "T" And item.Cells("NDCPRF").Value <> 0) Or
                    (item.Cells("TPOPER").Value = "A" And item.Cells("NSECFC").Value <> 0)) And item.Cells("NPRLQD").Value = 0 Then
                    item.Cells("CHK").Value = Not checkallPendiente
                Else
                    item.Cells("CHK").Value = False
                End If
            Next
            dtgOpValorizacion.EndEdit()
            checkallPendiente = Not checkallPendiente
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkvalorizacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkvalorizacion.CheckedChanged
        Try
            dtpFechaInicio.Enabled = Not chkvalorizacion.Checked
            dtpFechaFin.Enabled = Not chkvalorizacion.Checked
            cmbestado.Enabled = Not chkvalorizacion.Checked

            txtNroValorizacion.Enabled = chkvalorizacion.Checked
            txtNroDocumento.Enabled = chkvalorizacion.Checked



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub dtgOpValorizacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOpValorizacion.CellContentClick
        Try

            If dtgOpValorizacion.Columns(e.ColumnIndex).Name = "NOPRCN" Then
                Dim dtOperaciones As New DataTable
                If dtgOpValorizacion.CurrentRow IsNot Nothing Then
                    If dtgOpValorizacion.CurrentRow.Tag IsNot Nothing Then
                        dtOperaciones = CType(dtgOpValorizacion.CurrentRow.Tag, DataTable)
                        Dim ofrmListOperaciones As New frmListOperaciones
                        ofrmListOperaciones.dtListOperaciones = dtOperaciones
                        ofrmListOperaciones.ShowDialog()
                    Else
                        ActualizarDetalleTag_Operaciones()
                        If dtgOpValorizacion.CurrentRow.Tag IsNot Nothing Then
                            dtOperaciones = CType(dtgOpValorizacion.CurrentRow.Tag, DataTable)
                            Dim ofrmListOperaciones As New frmListOperaciones
                            ofrmListOperaciones.dtListOperaciones = dtOperaciones
                            ofrmListOperaciones.ShowDialog()
                        End If

                    End If
                End If
            End If

            If dtgOpValorizacion.Columns(e.ColumnIndex).Name = "SUSTENTO" Then

                Dim ofrmOperacionesSustento As New frmOperacionesSustento
                Dim dtTemporal As New DataTable

                ofrmOperacionesSustento.pCCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
                ofrmOperacionesSustento.pCCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
                ofrmOperacionesSustento.pValorizConDocGenerado = ("" & dtgValorizacion.CurrentRow.Cells("FLGDSG").Value).ToString.Trim

                Dim dtOperacion As New DataTable
                Dim pOperacionAdmin As Decimal = 0

                If dtgOpValorizacion.CurrentRow.Tag IsNot Nothing Then
                    dtOperacion = CType(dtgOpValorizacion.CurrentRow.Tag, DataTable)
                Else
                    ActualizarDetalleTag_Operaciones()
                    If dtgOpValorizacion.CurrentRow.Tag IsNot Nothing Then
                        dtOperacion = CType(dtgOpValorizacion.CurrentRow.Tag, DataTable)
                    End If
                End If
                pOperacionAdmin = dtOperacion.Rows(0)("NOPRCN")
                If pOperacionAdmin = 0 Then
                    MessageBox.Show("Operación rango no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                 
                ofrmOperacionesSustento.pNROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
                ofrmOperacionesSustento.pOperacionAdmin = pOperacionAdmin


                ofrmOperacionesSustento.ShowDialog()

                If ofrmOperacionesSustento.pDialog = True Then
                    ListarOperacionesValorizadas()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ActualizarDetalleTag_Operaciones()
        Dim dtOP As New DataTable
        Dim dtVistaConsistencia As New DataTable
        Dim dsresult As New DataSet
        Dim obrFiltroValorizacion As New clsMantValorizacion
        oValorizacionFiltro = New beMantValorizacion
        oValorizacionFiltro.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
        oValorizacionFiltro.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
        oValorizacionFiltro.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
        oValorizacionFiltro.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
        oValorizacionFiltro.DOCGENERADO = ("" & dtgValorizacion.CurrentRow.Cells("FLGDSG").Value)
        oValorizacionFiltro.CDVSN = ("" & cboDivision.SelectedValue).ToString.Trim
        dsresult = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)
        dtOP = dsresult.Tables(0)
        Dim drOperaciones() As DataRow
        For Each item As DataGridViewRow In dtgOpValorizacion.Rows
            If item.Cells("TPOPER").Value = "A" Then
                item.Cells("NOPRCN").Value = "Listado"
                drOperaciones = dtOP.Select("NSECFC='" & item.Cells("NSECFC").Value & "'")
                item.Tag = HelpClass.RowToDatatable(drOperaciones, dtOP)
            End If
        Next


    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        Try
            ListarOperacionesValorizadas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsm_anul_valoriz_Click(sender As Object, e As EventArgs) Handles tsm_anul_valoriz.Click
        Try

            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion

            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""
            oValorizacion.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.OBSAVL = ""
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            oValorizacion.CULUSA = ConfigurationWizard.UserName

            If MessageBox.Show("¿Está seguro de anular la valorización?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            sErrorMesage = obrValorizacion.Anular_MantValorizacion(oValorizacion)
            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("La valorización fue anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarValorizaciones()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsm_anul_aprob_cliente_Click(sender As Object, e As EventArgs) Handles tsm_anul_aprob_cliente.Click
        Try

            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim msg As String = ""
            oValorizacion.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            oValorizacion.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            If MessageBox.Show("¿Está seguro de anular la aprobación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            msg = obrValorizacion.AnularAprobacionCliente(oValorizacion)
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Se ha anulado la aprobación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarValorizaciones()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try

    End Sub

    Private Sub ExportarExcelRangoViaje(sender As Object, e As EventArgs) Handles RangoViajeToolStripMenuItem.Click

        Try
            If dtgValorizacion.Rows.Count = 0 Then Exit Sub

            ' VALIDACION DE TIPO VALORIZACION: RANGO VIAJE

            If (dtgValorizacion.CurrentRow.Cells("TPOVLR").Value).ToString.Trim = "RV" Then

                Dim dtOC As New DataTable
                Dim lstrPeriodo As String = ""
                Dim ColName As String = ""
                Dim ColCaption As String = ""
                Dim MdataColumna As String = ""

                Dim TableName As String = ""
                Dim ColTitle As String = ""
                Dim TipoDato As String = ""

                Dim NPOI_AD As New Ransa.Utilitario.HelpClass_NPOI_AD

                Dim obrFiltroValorizacion As New clsMantValorizacion
                oValorizacionFiltro = New beMantValorizacion
                oValorizacionFiltro.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value

                oValorizacionFiltro.NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value

                Dim dsresult As New DataSet
                Dim dtResult As New DataTable
                Dim dtserviciosTransportes As New DataTable
                Dim dtvalorizacion As New DataTable
                Dim dtFiltroAdicional As New DataTable
                Dim dtServicios As New DataTable
                Dim dtOpAlmacenes As New DataTable
                Dim dtGuiaAlmacenes As New DataTable
                Dim dtLiquidaciones As New DataTable
                Dim dtGuiasOCTransporte As New DataTable

                dsresult = obrFiltroValorizacion.ListarServicioDetalleTipoRangoValorizacionExport(oValorizacionFiltro)

                dtvalorizacion = dsresult.Tables(0).Copy
                dtFiltroAdicional = dsresult.Tables(1).Copy
                dtserviciosTransportes = dsresult.Tables(2).Copy
                dtGuiasOCTransporte = dsresult.Tables(3).Copy
                dtLiquidaciones = dsresult.Tables(4).Copy



                Dim dtExportTransporte As New DataTable
                dtExportTransporte = ExtraeDatoExportarTransporte_Rango(dtvalorizacion, dtserviciosTransportes, dtGuiasOCTransporte, dtLiquidaciones)
                dtExportTransporte.TableName = "TRANSPORTES"


                Dim TienenMismaMonedaAdmin As Boolean = False


                Dim ListaDatatable As New List(Of DataTable)
                ListaDatatable.Add(dtExportTransporte.Copy)


                Dim LisFiltros As New List(Of SortedList)
                Dim itemSortedList As SortedList
                Dim tituloTexto As String = ""
                itemSortedList = New SortedList
                If dtvalorizacion.Rows.Count > 0 Then
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & dtvalorizacion.Rows(0)("TCMPCL"))
                    tituloTexto = dtvalorizacion.Rows(0)("NROVLR").ToString.PadLeft(10, "0") ' & "-" & dtvalorizacion.Rows(0)("NROSGV")
                    tituloTexto = tituloTexto & " Doc Ref:" & dtvalorizacion.Rows(0)("DOCVLR").ToString.Trim
                    itemSortedList.Add(itemSortedList.Count, "Número Valorización:|" & tituloTexto)
                    itemSortedList.Add(itemSortedList.Count, "Estado:|" & dtvalorizacion.Rows(0)("SEGVLR"))
                    itemSortedList.Add(itemSortedList.Count, "Fecha Valorización:|" & dtvalorizacion.Rows(0)("FCH_VAL"))
                    itemSortedList.Add(itemSortedList.Count, "Fecha Envío:|" & dtvalorizacion.Rows(0)("FCH_ENVIO") & " " & dtvalorizacion.Rows(0)("HRA_ENVIO"))
                    itemSortedList.Add(itemSortedList.Count, "Fecha Aprobación:|" & dtvalorizacion.Rows(0)("FCH_APROB") & " " & dtvalorizacion.Rows(0)("HRA_APROB"))
                    itemSortedList.Add(itemSortedList.Count, "Usuario Valorizador:|" & dtvalorizacion.Rows(0)("USU_REG_VALORIZ"))

                    itemSortedList.Add(itemSortedList.Count, " ")
                    itemSortedList.Add(itemSortedList.Count, " ----- SERVICIO ---------------------------|")
                    itemSortedList.Add(itemSortedList.Count, "Servicio:|" & dtFiltroAdicional.Rows(0)("NOM_SERVICIO"))
                    itemSortedList.Add(itemSortedList.Count, "Cantidad Viajes:|" & dtFiltroAdicional.Rows(0)("VALCTE"))
                    itemSortedList.Add(itemSortedList.Count, "Importe:|" & dtFiltroAdicional.Rows(0)("TSGNMN") & " " & dtFiltroAdicional.Rows(0)("IVLSRV"))



                Else
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & UcCliente.pRazonSocial)
                End If
                LisFiltros.Add(itemSortedList)



                Dim ListTitulo As New List(Of String)
                ListTitulo.Add("REPORTE DE VALORIZACIONES TIPO RANGO VIAJE")


                Dim ListNCelda As New List(Of String)

                NPOI_AD.ExportExcelGeneralMultipleValorizacion(ListaDatatable, ListTitulo, ListNCelda, LisFiltros, Nothing, TienenMismaMonedaAdmin)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try

            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If


            Dim pCCMPN As String = Me.cboCompania.CCMPN_CodigoCompania
            Dim pNROVLR As Decimal = dtgValorizacion.CurrentRow.Cells("NROVLR").Value

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = pCCMPN
            ofrmCargaAdjuntos.pNroImagen = dtgValorizacion.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            'ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZSC53

            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZSC53(pCCMPN, pNROVLR)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then

                dtgValorizacion.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dtgValorizacion.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    dtgValorizacion.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class


