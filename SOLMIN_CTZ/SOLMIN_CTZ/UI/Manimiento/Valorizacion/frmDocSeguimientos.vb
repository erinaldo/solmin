Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmDocSeguimientos


    Private Enum_Mantenimiento As MANTENIMIENTO_OPC
    Private bs As New BindingSource
    Private tabSeleccionado As String = ""
    Private _pUsuario As String = ""

    Dim oValorizacionFiltro As New beMantValorizacion
    Dim obrConfValorizacionFiltro As New clsMantValorizacion



    Enum MANTENIMIENTO_OPC
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Try

            dtgValorizacion.AutoGenerateColumns = False
            dtgEnvioValorizacion.AutoGenerateColumns = False
            dtgOpValorizacion.AutoGenerateColumns = False

            dtgValorizacion.DataSource = Nothing
            dtgOpValorizacion.DataSource = Nothing
            dtgEnvioValorizacion.DataSource = Nothing
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)

            ListarValorizaciones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMantValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            dtgOpValorizacion.AutoGenerateColumns = False
            dtgEnvioValorizacion.AutoGenerateColumns = False
            dtgValorizacion.AutoGenerateColumns = False

            Cargar_Compania()
            CargarCombos()
            Limpiar_Control()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Compania()
        cboCompania.Usuario = ConfigurationWizard.UserName
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarCombos()
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")

        'G - Generado: Estado al crearse la valorización.
        'E – Enviado: Estado al enviarse la valorización.
        'A – Aprobado: Estado al aprobarse la valorizarse.

        oDr = oDt.NewRow
        oDr.Item("COD") = "G"
        oDr.Item("DES") = "Generado"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item("COD") = "E"
        oDr.Item("DES") = "Enviado"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item("COD") = "A"
        oDr.Item("DES") = "Aprobado"
        oDt.Rows.Add(oDr)

        With Me.cmbEstado
            .DataSource = oDt
            .ValueMember = "COD"
            .DisplayMember = "DES"
        End With

        Me.cmbEstado.SelectedValue = "G"
    End Sub
    Private Sub Limpiar_Control()
        '  UcCliente.pClear()
        txtNroDocumento.Clear()
        txtNroValorizacion.Clear()
        dtpFechaInicio.Value = Now
        dtpFechaInicio.Value = Now
        ckbRangoFechas.Checked = False
    End Sub

    Private Sub HabilitarOpcion(ByVal opc As MANTENIMIENTO_OPC)

        Select Case opc
            Case MANTENIMIENTO_OPC.NEUTRAL

                btnNuevo.Enabled = True
                btnAprobar.Enabled = True
                btnAnulacion.Enabled = True
                btnExportar1.Enabled = True
                btnEnviar1.Enabled = True


                'Estado_Controles(False)

                If dtgValorizacion.Rows.Count > 0 Then
                    btnAgregarDet.Enabled = True
                    btnEliminarDet.Enabled = True
                End If

            Case MANTENIMIENTO_OPC.EDITAR

                btnNuevo.Enabled = True
                btnAprobar.Enabled = True
                btnAnulacion.Enabled = True
                btnExportar1.Enabled = True
                btnEnviar1.Enabled = True


                'Estado_Controles(True)
            Case MANTENIMIENTO_OPC.NUEVO

                btnNuevo.Enabled = True
                btnAprobar.Enabled = True
                btnAnulacion.Enabled = True
                btnExportar1.Enabled = True
                btnEnviar1.Enabled = True

                'Estado_Controles(True)
        End Select

    End Sub

    'Private Sub Estado_Controles(ByVal lbool_estado As Boolean)
    '    '  txtCliente.Enabled = lbool_estado
    '    '  txtNroContrato.Enabled = lbool_estado

    'End Sub


    Private Sub ListarValorizaciones()
        dtgEnvioValorizacion.DataSource = Nothing
        dtgOpValorizacion.DataSource = Nothing
        dtgValorizacion.DataSource = Nothing

        If Me.Validar_Datos_Filtro = True Then Exit Sub

        Dim oValorizacion As New beMantValorizacion
        Dim obrConfValorizacion As New clsMantValorizacion
        With oValorizacion
            .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            .CCLNT = Me.UcCliente.pCodigo
            .SEGVLR = Me.cmbEstado.SelectedValue
            .NROVLR = IIf(Len(Strings.Trim(Me.txtNroDocumento.Text)) = 0, "0", Strings.Trim(Me.txtNroDocumento.Text))
            .DOCVLR = IIf(Len(Strings.Trim(Me.txtNroDocumento.Text)) = 0, "0", Strings.Trim(Me.txtNroDocumento.Text))
            If Me.ckbRangoFechas.Checked Then
                .FCHINI = Me.dtpFechaInicio.Value.ToString("yyyyMMdd")
                .FCHFIN = Me.dtpFechaFin.Value.ToString("yyyyMMdd")
            Else
                .FCHINI = "0"
                .FCHFIN = "0"
            End If
        End With

        dtgValorizacion.DataSource = obrConfValorizacion.Listar_MantValorizacion(oValorizacion)
    End Sub

    Private Sub ListarOPxValorizacion()
        Dim oValorizacion As New beMantValorizacion
        Dim obrConfValorizacion As New clsMantValorizacion
        With oValorizacion
            .CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            .CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
        End With

        dtgOpValorizacion.DataSource = obrConfValorizacion.ListarOPxValorizacion(oValorizacion)
    End Sub

    Private Sub ListarOPxEnvioValorizacion()
        Dim oValorizacion As New beMantValorizacion
        Dim obrConfValorizacion As New clsMantValorizacion
        With oValorizacion
            .CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            .CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            .NROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
        End With

        dtgEnvioValorizacion.DataSource = obrConfValorizacion.ListarOPxEnvioValorizacion(oValorizacion)
    End Sub


    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If cboCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* COMPAÑIA " & Chr(13)
        End If
        If UcCliente.pRazonSocial = "" Then
            lstr_validacion += "* CLIENTE" & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    'Private Sub dtgOpValorizacion_SelectionChanged(sender As Object, e As EventArgs) Handles dtgOpValorizacion.SelectionChanged
    '    If Me.dtgValorizacion.RowCount = 0 OrElse Me.dtgValorizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '    dtgEnvioValorizacion.Rows.Clear()
    '    dtgOpValorizacion.Rows.Clear()

    '    ListarOPxValorizacion()
    '    ListarOPxEnvioValorizacion()
    'End Sub
    'Private Sub dtgValorizacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgValorizacion.CellClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        Dim obrFiltroValorizacion As New clsMantValorizacion
    '        dtgEnvioValorizacion.Rows.Clear()
    '        dtgOpValorizacion.Rows.Clear()
    '        Me.Asignacion_Datos_Objeto(e.RowIndex)
    '        dtgOpValorizacion.DataSource = obrFiltroValorizacion.ListarOPxValorizacion(oValorizacionFiltro)
    '        dtgEnvioValorizacion.DataSource = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        Try
            If Me.UcCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Dim obrConfValorizacion As New clsMantValorizacion
            'Dim Compania As String = cboCompania.CCMPN_CodigoCompania
            'Dim CodCliente As Decimal = UcCliente.pCodigo
            'Dim NroValorizacion As Decimal = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            'Dim strValidacion As String = ""
            'strValidacion = obrConfValorizacion.ValidarGeneracionEnvio(Compania, CodCliente, NroValorizacion)
            'If strValidacion.Length > 0 Then
            '    MessageBox.Show(strValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Dim ofrmValorizacion As New frmNewValorizacion
            Dim oValorizacion As New beMantValorizacion
            'Dim obrConfValorizacion As New clsMantValorizacion
            'With oValorizacion
            '    .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            '    .CCLNT = Me.UcCliente.pCodigo
            '    .NROVLR = "0"
            '    .DOCVLR = "0"
            '    If dtgValorizacion.RowCount > 0 Then
            '        .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            '        .DOCVLR = dtgValorizacion.CurrentRow.Cells("DOCVLR").Value
            '    End If
            'End With
            'ofrmValorizacion.pbeValorizacion = oValorizacion
            ofrmValorizacion.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
            ofrmValorizacion.pCCLNT = Me.UcCliente.pCodigo
            ofrmValorizacion.pNROVLR = 0
            ofrmValorizacion.oTipo = frmNewValorizacion.TipoMan.Nuevo
            If ofrmValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Volver()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminarDet_Click(sender As Object, e As EventArgs) Handles btnEliminarDet.Click

        Try

            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If dtgOpValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

            With oValorizacion
                .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
                .NROVLR = dtgOpValorizacion.CurrentRow.Cells("NROVLR").Value
                .NCRRDT = dtgOpValorizacion.CurrentRow.Cells("NCRRDT").Value
                .CULUSA = ConfigurationWizard.UserName
                .NTRMNL = HelpClass.NombreMaquina
            End With

            dtTransaccion = obrValorizacion.EliminarOper_MantValorizacion(oValorizacion)

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
                If sStatus = "S" Then
                    sMesageAlerta = sMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            sErrorMesage = sErrorMesage.Trim
            sMesageAlerta = sMesageAlerta.Trim

            If sStatus = "E" Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If sStatus = "S" Then
                MessageBox.Show(sMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregarDet_Click(sender As Object, e As EventArgs)
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmValorizacion As New frmNewValorizacion
            'Dim oValorizacion As New beMantValorizacion
            'Dim obrConfValorizacion As New clsMantValorizacion
            'With oValorizacion
            '    .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            '    .CCLNT = Me.UcCliente.pCodigo
            '    .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            '    .DOCVLR = dtgValorizacion.CurrentRow.Cells("DOCVLR").Value
            'End With
            'ofrmValorizacion.pbeValorizacion = oValorizacion
            ofrmValorizacion.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
            ofrmValorizacion.pCCLNT = Me.UcCliente.pCodigo
            ofrmValorizacion.pNROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            ofrmValorizacion.oTipo = frmNewValorizacion.TipoMan.Editar
            If ofrmValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Volver()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnExportar1_Click(sender As Object, e As EventArgs)
        Try
            If Me.dtgValorizacion.RowCount = 0 Then Exit Sub
            'Me.Exportar_Excel_Liquidacion_Flete()
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

    'Private Sub Asignacion_Datos_Objeto()
    '    oValorizacionFiltro = New beMantValorizacion
    '    oValorizacionFiltro.CCMPN = Me.dtgValorizacion.CurrentRow.Cells("CCMPN").Value '.Item("CCMPN", lint_Indice).Value
    '    oValorizacionFiltro.CCLNT = Me.dtgValorizacion.CurrentRow.Cells("CCLNT").Value
    '    oValorizacionFiltro.NROVLR = Me.dtgValorizacion.CurrentRow.Cells("NROVLR").Value
    '    oValorizacionFiltro.NROSGV = Me.dtgValorizacion.CurrentRow.Cells("NROSGV").Value

    '    'Para el detalle, utilizar proc: SP_SOLMIN_SD_LISTAR_DET_OP_X_VALORIZACION
    '    'Campo Mapeo
    '    'IN PSCCMPN VARCHAR(2) ,	CCMPN
    '    'IN PNCCLNT NUMERIC(6, 0),	CCLNT
    '    'IN PNNROVLR NUMERIC(10)	NROVLR

    '    'Para el detalle, utilizar proc: SP_SOLMIN_SD_LISTAR_DET_OP_X_VALORIZACION
    '    'Campo Mapeo
    '    'IN PSCCMPN VARCHAR(2) ,	CCMPN
    '    'IN PNCCLNT NUMERIC(6, 0),	CCLNT
    '    'IN PNNROVLR NUMERIC(10)	NROVLR
    '    'IN  PNNROSGV NUMERIC(10)	NROSGV
    'End Sub
    'Private Sub dtgValorizacion_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtgValorizacion.DataBindingComplete
    '    Try
    '        If Me.dtgValorizacion.Rows.Count > 0 Then Me.dtgValorizacion.CurrentRow.Selected = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    'Private Sub dtgValorizacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgValorizacion.CellDoubleClick
    '    Try
    '        Select Case dtgValorizacion.Columns(e.ColumnIndex).Name
    '            Case "ESTADO_VLR"
    '                '        Dim ofrmSegMargen As New frmSegMargen
    '                '        ofrmSegMargen.NOPRCN = dtgValorizacion.CurrentRow.Cells("NOPRCN").Value
    '                '        ofrmSegMargen.CCMPN = cmbCompania.CCMPN_CodigoCompania
    '                '        ofrmSegMargen.ShowDialog()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    'Private Sub dtgValorizacion_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgValorizacion.CellFormatting
    '    If Me.dtgValorizacion.Rows(e.RowIndex).Cells("ESTADO_VLR").Value = "G" Then e.CellStyle.BackColor = Color.Green
    '    If Me.dtgValorizacion.Rows(e.RowIndex).Cells("ESTADO_VLR").Value = "E" Then e.CellStyle.BackColor = Color.Crimson
    '    If Me.dtgValorizacion.Rows(e.RowIndex).Cells("ESTADO_VLR").Value = "A" Then e.CellStyle.BackColor = Color.BlueViolet
    'End Sub


    'Private Sub dtgValorizacion_KeyUp(sender As Object, e As KeyEventArgs) Handles dtgValorizacion.KeyUp
    '    Try
    '        If Me.dtgValorizacion.RowCount = 0 Then Exit Sub
    '        Dim obrFiltroValorizacion As New clsMantValorizacion
    '        Select Case e.KeyCode
    '            Case Keys.Enter, Keys.Up, Keys.Down
    '                dtgOpValorizacion.Rows.Clear()
    '                dtgEnvioValorizacion.Rows.Clear()
    '                Me.Asignacion_Datos_Objeto(Me.dtgValorizacion.CurrentCellAddress.Y)

    '                dtgOpValorizacion.DataSource = obrFiltroValorizacion.ListarOPxValorizacion(oValorizacionFiltro)
    '                dtgEnvioValorizacion.DataSource = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub




    Private Sub btnGenerar_Click(sender As Object, e As EventArgs)
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If dtgOpValorizacion.Rows.Count = 0 Then
                MessageBox.Show("La valorización no tiene detalle para generar el envío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim NroEnvio As Decimal = Val(dtgValorizacion.CurrentRow.Cells("NROSGV").Value)
            If NroEnvio <> 0 Then
                MessageBox.Show("La valorización ya tiene Número de Envío generado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("¿Se generará documento de envío , está seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Dim obrValorizacion As New clsMantValorizacion
            'Dim ofrmProcesValorizacion As New frmProcesValorizacion
            'Dim oValorizacion As New beMantValorizacion
            'Dim obrConfValorizacion As New clsMantValorizacion
            'With oValorizacion
            '    .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            '    .CCLNT = Me.UcCliente.pCodigo
            '    .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            '    .DOCVLR = dtgValorizacion.CurrentRow.Cells("DOCVLR").Value
            '    .TOTSOLES = SumaGrillaColumna("8")
            '    .TOTDOLARES = SumaGrillaColumna("9")
            'End With
            'ofrmProcesValorizacion.pbeValorizacion = oValorizacion
            'If ofrmProcesValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    Volver()
            'End If
            Dim sStatus As String = ""
            Dim sErrorMesage As String = ""
            Dim dtTransaccion As New DataTable
            Dim sNro_ValorizEnvio As Decimal = 0
            Dim sNro_Valoriz As Decimal = 0
            Dim oValorizacion As New beMantValorizacion
            oValorizacion.CCMPN = dtgValorizacion.CurrentRow.Cells("CCMPN").Value
            oValorizacion.CCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            sNro_Valoriz = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacion.NROVLR = sNro_Valoriz
            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = HelpClass.NombreMaquina
            dtTransaccion = obrValorizacion.GenerarDocValorizacion(oValorizacion)

            'Dim dr As DataRow
            'dtTransaccion.Columns.Add(New DataColumn("STATUS", GetType(String)))
            'dtTransaccion.Columns.Add(New DataColumn("OBSRESULT", GetType(String)))
            'dtTransaccion.Columns.Add(New DataColumn("NROSGV", GetType(String)))
            'For Each row As DataRow In dtTransaccion.Rows
            '    dr = dtTransaccion.NewRow()
            '    dr("STATUS") = "S"
            '    dr("OBSRESULT") = "Actualización Exitosa"
            '    dr("NROSGV") = row("NROSGV").ToString.Trim
            '    dtTransaccion.Rows.Add(dr)
            'Next

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                'sNro_Valorización = row("NROVLR").ToString.Trim
                'oValorizacion.NROSGV = row("NROVLR").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
                'If sStatus = "S" Then
                '    sMesageAlerta = sMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                'End If
            Next
            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If dtTransaccion.Rows.Count > 0 Then
                    sNro_ValorizEnvio = dtTransaccion.Rows(0)("NROSGV") ' row("NROVLR").ToString.Trim
                    dtgValorizacion.CurrentRow.Cells("NROSGV").Value = sNro_ValorizEnvio
                    MessageBox.Show("Documento envío generado: " & sNro_Valoriz & " - " & sNro_ValorizEnvio, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'If sNro_ValorizEnvio > 0 Then
            '    Dim dtDetalle As New DataTable
            '    Dim obrFiltroValorizacion As New clsMantValorizacion
            '    dtTransaccion = obrFiltroValorizacion.ListarOPxValorizacion(oValorizacion)
            '    For Each row As DataRow In dtTransaccion.Rows

            '        oValorizacion.CCMPN = row("CCMPN")
            '        oValorizacion.NROVLR = row("NROVLR")
            '        oValorizacion.NROSGV = row("NROSGV")
            '        oValorizacion.TPOPER = row("TPOPER")
            '        oValorizacion.NOPRCN = row("NOPRCN")

            '        oValorizacion.NCRROP = row("NCRROP")
            '        oValorizacion.NGUITR = row("NGUITR")
            '        oValorizacion.NCRRGU = row("NCRRGU")
            '        oValorizacion.SESTOP = row("SESTOP")
            '        oValorizacion.NLQDCN = row("NLQDCN")

            '        oValorizacion.NSECFC = row("NSECFC")
            '        oValorizacion.CDVSN = row("CDVSN")
            '        oValorizacion.CPLNDV = row("CPLNDV")
            '        oValorizacion.CSRVC = row("CSRVC")
            '        oValorizacion.CMNDA1 = row("CMNDA1")

            '        oValorizacion.QATNAN = row("QATNAN")
            '        oValorizacion.IVLSRV = row("IVLSRV")
            '        oValorizacion.ITPCMT = row("ITPCMT")

            '        oValorizacion.CULUSA = row("CULUSA")
            '        oValorizacion.NTRMNL = row("NTRMNL")

            '        obrValorizacion.RegistrarDocumentoEnvioDetalle(oValorizacion)
            '    Next
            'End If

            'sErrorMesage = sErrorMesage.Trim
            'sMesageAlerta = sMesageAlerta.Trim
            'If sStatus = "E" Then
            '    MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'If sStatus = "S" Then
            '    MessageBox.Show(sMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            'btnCancelar.Enabled = True
            'btnProcesar.Enabled = False
            'Me.DialogResult = Windows.Forms.DialogResult.OK



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEnviar1_Click(sender As Object, e As EventArgs)
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim NroEnvio As Decimal = Val(dtgValorizacion.CurrentRow.Cells("NROSGV").Value)
            If NroEnvio = 0 Then
                MessageBox.Show("Número envío no generado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                Volver()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnulacion_Click(sender As Object, e As EventArgs) Handles btnAnulacion.Click
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim ofrmAnularValorizacion As New frmAnularValorizacion
            Dim oValorizacion As New beMantValorizacion
            Dim obrConfValorizacion As New clsMantValorizacion
            With oValorizacion
                .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
                .NROVLR = dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            End With
            ofrmAnularValorizacion.pbeValorizacion = oValorizacion
            If ofrmAnularValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Volver()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub btnAprobar_Click(sender As Object, e As EventArgs)
        Try
            If dtgValorizacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            'Dim NroEnvio As Decimal = Val(dtgValorizacion.CurrentRow.Cells("NROSGV").Value)
            If Val(dtgValorizacion.CurrentRow.Cells("NROSGV").Value) = 0 Then
                MessageBox.Show("Número Doc. Seg no generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            '.TOBS = dtgValorizacion.CurrentRow.Cells("TOBS_ENVIO").Value
            '.FCHASG = dtgValorizacion.CurrentRow.Cells("FECHA_ENVIO").Value
            '.HRAASG = dtgValorizacion.CurrentRow.Cells("HORA_ENVIO").Value
            '.DESTAP = dtgValorizacion.CurrentRow.Cells("Aprobador").Value
            '.ARADST = dtgValorizacion.CurrentRow.Cells("Destino").Value
            ofrmEnviarValorizacion.pbeValorizacion = oValorizacion
            If ofrmEnviarValorizacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Volver()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub Volver()
        dtgValorizacion.DataSource = Nothing
        dtgOpValorizacion.DataSource = Nothing
        dtgEnvioValorizacion.DataSource = Nothing
        Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
        HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
        Limpiar_Control()
        ListarValorizaciones()
    End Sub

    Public Function SumaGrillaColumna(ByVal nroColumna As String) As String
        SumaGrillaColumna = ""
        If Me.dtgOpValorizacion.Rows.Count > 0 Then
            Dim total As Double = 0
            Dim iTotal As Integer = Me.dtgOpValorizacion.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            Dim i As Integer
            For i = 0 To iTotal - 1
                total = total + Double.Parse(Me.dtgOpValorizacion(nroColumna, i).Value)
            Next
            SumaGrillaColumna = Format(total, "##0.00").ToString
        End If
        Return SumaGrillaColumna
    End Function

    Private Sub dtgValorizacion_SelectionChanged(sender As Object, e As EventArgs) Handles dtgValorizacion.SelectionChanged
        Try
            If Me.dtgValorizacion.RowCount = 0 Then Exit Sub
            Dim obrFiltroValorizacion As New clsMantValorizacion

            dtgOpValorizacion.DataSource = Nothing
            dtgEnvioValorizacion.DataSource = Nothing
            'Me.Asignacion_Datos_Objeto(Me.dtgValorizacion.CurrentCellAddress.Y)
            oValorizacionFiltro = New beMantValorizacion
            oValorizacionFiltro.CCMPN = Me.dtgValorizacion.CurrentRow.Cells("CCMPN").Value '.Item("CCMPN", lint_Indice).Value
            oValorizacionFiltro.CCLNT = Me.dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            oValorizacionFiltro.NROVLR = Me.dtgValorizacion.CurrentRow.Cells("NROVLR").Value
            oValorizacionFiltro.NROSGV = Me.dtgValorizacion.CurrentRow.Cells("NROSGV").Value

            dtgOpValorizacion.DataSource = obrFiltroValorizacion.ListarOPxValorizacion(oValorizacionFiltro)
            dtgEnvioValorizacion.DataSource = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabGrupoClientes_Selected(sender As Object, e As TabControlEventArgs) Handles TabGrupoClientes.Selected
        Dim tab As String = TabGrupoClientes.SelectedTab.Name
        Select Case tab
            Case "tabOpValorizacion"
                btnAgregarDet.Enabled = True
                btnEliminarDet.Enabled = True

            Case "tabNroEnvio"
                btnAgregarDet.Enabled = False
                btnEliminarDet.Enabled = False
        End Select

    End Sub
End Class


