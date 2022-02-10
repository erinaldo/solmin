Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Cliente
Imports Ransa.DAO.Cliente

Public Class frmNewContrato

#Region "Declaracion de Variables"

    Private oCliente As SOLMIN_CTZ.NEGOCIO.clsCliente
    Private oContratoNeg As SOLMIN_CTZ.NEGOCIO.clsContrato
    Private oContrato As SOLMIN_CTZ.Entidades.Contrato
    Private oDetContratoNeg As SOLMIN_CTZ.NEGOCIO.clsDetContrato
    Private oDetContrato As SOLMIN_CTZ.Entidades.Detalle_Contrato
    Private oEstado As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private oBitacora_Contrato As SOLMIN_CTZ.Entidades.Bitacora_Contrato
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oFiltro As SOLMIN_CTZ.Entidades.Filtro
    Private oRango As SOLMIN_CTZ.Entidades.Rango
    Private oTarifaNeg As SOLMIN_CTZ.NEGOCIO.clsTarifa
    Private oCompania As clsCompania
    Private oPlanta As clsPlanta
    Private intRow As Integer
    Private bolCambiar As Boolean
    Private oDivision As clsDivision
    Private oQry_Cliente As TD_Qry_Cliente_L01 = New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
    Private oClienteGrupo As cCliente

#End Region

#Region "Enums"
    Enum Rango
        NRRNGO
        RANGO
    End Enum
#End Region

    Private Sub frmNewContrato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oEstado = New clsEstado
        oContratoNeg = New SOLMIN_CTZ.NEGOCIO.clsContrato
        oContrato = New SOLMIN_CTZ.Entidades.Contrato
        oDetContrato = New SOLMIN_CTZ.Entidades.Detalle_Contrato
        oBitacora_Contrato = New SOLMIN_CTZ.Entidades.Bitacora_Contrato
        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        oFiltro = New SOLMIN_CTZ.Entidades.Filtro
        oRango = New SOLMIN_CTZ.Entidades.Rango
        oTarifaNeg = New SOLMIN_CTZ.NEGOCIO.clsTarifa
        KryptonHeaderGroup2.Enabled = False
        Llenar_Combos()
        InicializaBotonesCRUD()
    End Sub

    Private Sub Llenar_Combos()
        'Lista Cliente por Grupo
        'UcClienteGrupo.pUsuario = ConfigurationWizard.UserName
        UcClienteGrupo.CCMPN = "EZ"
        oEstado.Estado_Contrato()
        cmbEstado.DataSource = oEstado.Tabla
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "0"
    End Sub


#Region "Actualizar Información del contrato"

    Private Sub Grabar_Datos_Contrato()
        If Not dtgContratos.CurrentRow Is Nothing Then
            Actualizar_Informacion_Contrato()
            Actualizar_Grilla(2) '2 - Datos del Contrato
        Else
            HelpClass.MsgBox("Debe seleccionar un contrato")
        End If
    End Sub

    Private Sub Actualizar_Informacion_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oContrato.NCNTRT = Me.txtDatNumContrato.Text.Trim
            oContrato.TCNCTO = Me.txtDatContContrato.Text.Trim
            oContrato.TMACTO = Me.txtDatCorreoContrato.Text.Trim
            oContrato.NTLCTO = Me.txtDatTelContrato.Text.Trim
            If Me.mskDatIniContrato.Text.Trim = "/  /" Then
                oContrato.FECINI = 0
            Else
                oContrato.FECINI = Format(CType(Me.mskDatIniContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            If Me.mskDatFinContrato.Text.Trim = "/  /" Then
                oContrato.FECFIN = 0
            Else
                oContrato.FECFIN = Format(CType(Me.mskDatFinContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            oContrato.DESCTR = Me.txtDatDescContrato.Text.Trim
            oContrato.TOBS = Me.txtDatObsContrato.Text.Trim
            oContratoNeg.Actualizar_Datos_Contrato(oContrato)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Agregar Contrato"

    Private Sub Grabar_Nuevo_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If oCompania.Lista.Rows.Count = 0 Then
                MsgBox("El usuario no tiene permiso para ninguna empresa", MsgBoxStyle.Information)
                Exit Sub
            End If
            oContrato.CCMPN = oCompania.Lista.Rows(0).Item("CCMPN").ToString.Trim 'oUsuario.Compania
            oContrato.NRCTCL = UcClienteGrupo.pCodigoGrupo 'Me.cmbCliente.SelectedValue
            oContrato.NCNTRT = Me.txtDatNumContrato.Text.Trim
            oContrato.DESCTR = Me.txtDatDescContrato.Text.Trim
            oContrato.TCNCTO = Me.txtDatContContrato.Text.Trim
            oContrato.TMACTO = Me.txtDatCorreoContrato.Text.Trim
            oContrato.NTLCTO = Me.txtDatTelContrato.Text.Trim
            If Me.mskDatIniContrato.Text.Trim = "/  /" Then
                oContrato.FECINI = 0
            Else
                oContrato.FECINI = Format(CType(Me.mskDatIniContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            If Me.mskDatFinContrato.Text.Trim = "/  /" Then
                oContrato.FECFIN = 0
            Else
                oContrato.FECFIN = Format(CType(Me.mskDatFinContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            oContratoNeg.Crear_Contrato(oContrato)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox("Se agregó un nuevo contrato correctamente")
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Crear_nuevo_Contrato()
        Grabar_Nuevo_Contrato()
        Buscar_Contrato()
    End Sub

#End Region

#Region "Datos de Contrato"

    'Private Sub Cargar_Datos_Contrato(ByVal pstrEstado As String)
    '    Try
    '        Dim oDt As DataTable

    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        oDt = oContratoNeg.Cargar_Datos_Contrato(oContrato)
    '        Me.txtDatNumContrato.Text = oDt.Rows(0).Item("NCNTRT").ToString.Trim
    '        Me.mskDatFechaContrato.Text = oDt.Rows(0).Item("FCHCRT").ToString.Trim
    '        Me.txtDatDescContrato.Text = oDt.Rows(0).Item("DESCTR").ToString.Trim
    '        Me.txtDatObsContrato.Text = oDt.Rows(0).Item("TOBS").ToString.Trim
    '        Me.txtDatContContrato.Text = oDt.Rows(0).Item("TCNCTO").ToString.Trim
    '        Me.txtDatCorreoContrato.Text = oDt.Rows(0).Item("TMACTO").ToString.Trim
    '        Me.txtDatTelContrato.Text = oDt.Rows(0).Item("NTLCTO").ToString.Trim
    '        Me.mskDatIniContrato.Text = oDt.Rows(0).Item("FECINI").ToString.Trim
    '        Me.mskDatFinContrato.Text = oDt.Rows(0).Item("FECFIN").ToString.Trim

    '        Me.cmbEstadoCont.DataSource = oEstado.Estado_Contrato(pstrEstado)
    '        Me.cmbEstadoCont.ValueMember = "COD"
    '        Me.cmbEstadoCont.DisplayMember = "TEX"

    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        HelpClass.MsgBox(ex.Message)
    '    End Try
    'End Sub

#End Region

#Region "Observaciones de Contrato"

    Private Sub Agrega_Row_Observacion()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgObservaciones)
        Me.dtgObservaciones.Rows.Add(oDrVw)
    End Sub

    Private Sub dtgObservaciones_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is TextBox Then
            CType(e.Control, TextBox).MaxLength = 250
        End If
    End Sub

    Private Sub Grabar_Bitacora_Contrato()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()
            oContratoNeg.Eliminar_Observaciones(oSqlMan, oContrato)
            oBitacora_Contrato.NRCTSL = oContrato.NRCTSL
            With Me.dtgObservaciones
                For intCont = 0 To .Rows.Count - 1
                    If (Not .Rows(intCont).Cells("TFCOBS").Value = Nothing) And (Not .Rows(intCont).Cells("TOBS_B").Value = Nothing) Then
                        oBitacora_Contrato.NRITOC = intCont + 1
                        oBitacora_Contrato.TFCOBS = Format(CType(.Rows(intCont).Cells("TFCOBS").Value, Date), "yyyyMMdd")
                        oBitacora_Contrato.TOBS = .Rows(intCont).Cells("TOBS_B").Value.ToString.Trim
                        oContratoNeg.Grabar_Observacion(oSqlMan, oBitacora_Contrato)
                    End If
                Next intCont
            End With
            oSqlMan.CommitGlobalTransaction()
            'Actualizar_Grilla(1) '1 - Observaciones del Contrato
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
        End Try
    End Sub

    Private Sub Actualizar_Grilla(ByVal pintTipo As Integer)
        Dim intCont As Integer

        Select Case pintTipo
            Case 1
                'Dim strObs As String = vbNullString
                'For intCont = 0 To Me.dtgContratos.Rows.Count - 1
                '    If Double.Parse(Me.dtgContratos.Rows(intCont).Cells("NRCTSL").Value.ToString.Trim) = oContrato.NRCTSL Then
                '        With Me.dtgContratos.Rows(intCont)
                '            For intIndice = 0 To Me.dtgObservaciones.Rows.Count - 1
                '                If intIndice > 0 Then
                '                    strObs = strObs & Chr(10)
                '                End If
                '                'strObs = strObs & Me.dtgObservaciones.Rows(intIndice).Cells(1).Value & "  " & Me.dtgObservaciones.Rows(intIndice).Cells(2).Value.ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                '            Next intIndice
                '            '.Cells("TOBS").Value = strObs
                '        End With
                '        Exit For
                '    End If
                'Next intCont
            Case 2
                For intCont = 0 To Me.dtgContratos.Rows.Count - 1
                    If Double.Parse(Me.dtgContratos.Rows(intCont).Cells("NRCTSL").Value.ToString.Trim) = oContrato.NRCTSL Then
                        With Me.dtgContratos.Rows(intCont)
                            .Cells("NCNTRT").Value = txtDatNumContrato.Text.Trim
                            'strContacto = Me.txtDatContContrato.Text.Trim & Chr(10) & Me.txtDatCorreoContrato.Text.Trim & Chr(10) & Me.txtDatTelContrato.Text.Trim
                            .Cells("TCNCTO").Value = Me.txtDatContContrato.Text.Trim
                            .Cells("NTLCTO").Value = Me.txtDatTelContrato.Text.Trim
                            .Cells("TMACTO").Value = Me.txtDatCorreoContrato.Text.Trim
                            If mskDatIniContrato.Text.Trim <> "/  /" Then
                                .Cells("FECINI").Value = mskDatIniContrato.Text
                            Else
                                .Cells("FECINI").Value = ""
                            End If
                            If mskDatFinContrato.Text.Trim <> "/  /" Then
                                .Cells("FECFIN").Value = mskDatFinContrato.Text
                            Else
                                .Cells("FECFIN").Value = ""
                            End If
                        End With
                        Exit For
                    End If
                Next intCont
        End Select
    End Sub

    Private Sub Llenar_Observaciones_Contrato()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim oDr() As DataRow
        Dim intCont As Integer

        oDt = oContratoNeg.Lista_Observacion_Cliente(oContrato)
        oDr = oDt.Select("NRCTSL=" & oContrato.NRCTSL)

        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgObservaciones)
                    oDrVw.Cells(0).Value = oDr(intCont).Item("NRITOC").ToString.Trim
                    oDrVw.Cells(1).Value = oDr(intCont).Item("TFCOBS").ToString.Trim
                    oDrVw.Cells(2).Value = oDr(intCont).Item("TOBS").ToString.Trim
                    Me.dtgObservaciones.Rows.Add(oDrVw)
                End If
            Next intCont
        End If
    End Sub

    Private Sub tsmDelObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quitar_Observacion()
    End Sub

    Private Sub Quitar_Observacion()
        If Me.dtgObservaciones.SelectedRows.Count > 0 Then
            Me.dtgObservaciones.Rows.RemoveAt(Me.dtgObservaciones.SelectedRows(0).Index)
        End If
    End Sub

#End Region

#Region "Buscar Contrato"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Ocultar_Datos_Contrato()
        If UcClienteGrupo.pCodigoGrupo = 0 Then
            HelpClass.MsgBox("Debe Seleccionar un Cliente")
            Exit Sub
        End If
        KryptonHeaderGroup2.Enabled = True
        Limpiar_Paneles()
        Buscar_Contrato()
        Llenar_Observaciones()
        InicializaBotonesCRUD()
    End Sub
    Private Sub Llenar_Observaciones()
        Try
            Dim oDtObs As DataTable
            Dim intCont As Integer
            Dim strDato As String

            Me.Cursor = Cursors.WaitCursor
            oDtObs = oContratoNeg.Lista_Observacion_Cliente(oContrato)
            For intCont = 0 To Me.dtgContratos.Rows.Count - 1
                strDato = Buscar_Observaciones(oDtObs, Me.dtgContratos.Rows(intCont).Cells(0).Value)
                dtgContratos.Rows(intCont).Cells(7).Value = strDato
            Next intCont
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Buscar_Observaciones(ByVal poDt As DataTable, ByVal pdblContrato As Double) As String
        Dim strCadena As String = ""
        Dim intCont As Integer
        Dim oDr() As DataRow

        oDr = poDt.Select("NRCTSL=" & pdblContrato)
        If oDr.Length > 0 Then
            For intCont = 0 To oDr.Length - 1
                If oDr(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                    strCadena = strCadena & oDr(intCont).Item("TFCOBS").ToString.Trim & "  " & oDr(intCont).Item("TOBS").ToString.Trim.Replace(Chr(10), Chr(10) & "                 ")
                    If intCont < oDr.Length - 1 Then
                        strCadena = strCadena & Chr(10)
                    End If
                End If
            Next intCont
        End If
        Return strCadena
    End Function

    Private Sub Buscar_Contrato()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            oContrato.NRCTCL = UcClienteGrupo.pCodigoGrupo 'cmbCliente.SelectedValue
            oContrato.NCNTRT = txtContrato.Text.Trim
            oContrato.CCMPN = HelpClass.getSetting("Compania")
            If Me.cmbEstado.Text = "TODOS" Then
                oContrato.SESTRG = ""
            Else
                oContrato.SESTRG = cmbEstado.SelectedValue
            End If
            'oContratoNeg.Buscar_Contrato(oContrato)
            Limpiar_Controles()
            Llenar_Grilla_Contrato()
            If Me.dtgContratos.Rows.Count > 0 Then
                Cargar_Informacion_Contrato(Me.dtgContratos.Rows(0).Cells("NRCTSL").Value, Me.dtgContratos.Rows(0).Cells("SESTRG").Value)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Controles()
        Me.dtgContratos.DataSource = Nothing
    End Sub

    Private Sub Limpiar_Paneles()
        Limpiar_Datos_Contrato()
        Limpiar_Observaciones()
        Limpiar_Tarifas()
    End Sub

    Private Sub Limpiar_Tarifas()
        Me.dtgTarifaContrato.DataSource = Nothing
    End Sub

    Private Sub Limpiar_Observaciones()
        Me.dtgObservaciones.Rows.Clear()
    End Sub

    Private Sub Limpiar_Datos_Contrato()
        Me.txtDatNumContrato.Text = ""
        Me.mskDatFechaContrato.Text = ""
        Me.txtDatDescContrato.Text = ""
        Me.txtDatObsContrato.Text = ""
        Me.txtDatContContrato.Text = ""
        Me.txtDatCorreoContrato.Text = ""
        Me.txtDatTelContrato.Text = ""
        Me.mskDatIniContrato.Text = ""
        Me.mskDatFinContrato.Text = ""
    End Sub
    Private Sub Llenar_Grilla_Contrato()
        dtgContratos.AutoGenerateColumns = False
        dtgContratos.DataSource = oContratoNeg.Lista_Contratos
    End Sub
    Private Sub dtgContratos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgContratos.DataBindingComplete
        For i As Integer = 0 To dtgContratos.Rows.Count - 1
            Select Case dtgContratos.Rows(i).Cells("SESTRG").Value.ToString.Trim
                Case "P"
                    dtgContratos.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                Case "A"
                    dtgContratos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
                Case "C"
                    dtgContratos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                Case "R"
                    dtgContratos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192)
            End Select
        Next
    End Sub
#End Region

#Region "Estado de Contrato"

    'Private Sub tsmAceptarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAceptarContrato.Click
    '    Actualizar_Estado_Contrato("A")
    'End Sub

    'Private Sub tsmCerrarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCerrarContrato.Click
    '    Actualizar_Estado_Contrato("C")
    'End Sub

    'Private Sub tsmAnularContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAnularContrato.Click
    '    Actualizar_Estado_Contrato("R")
    'End Sub

    Private Sub Actualizar_Estado_Contrato(ByVal pstrEstado As String)
        Try
            Dim strCadena As String = ""

            'oContrato.NRCTSL = Me.tvwContrato.SelectedNode.Tag(0)
            Select Case pstrEstado
                Case "A"
                    strCadena = "Esta seguro de cambiar a estado Activo el contrato ?"
                    oContrato.SESTRG = "A"
                Case "C"
                    strCadena = "Esta seguro de cambiar a estado Vencido el contrato ?"
                    oContrato.SESTRG = "C"
                Case "R"
                    strCadena = "Esta seguro de cambiar a estado Anulado el contrato ?"
                    oContrato.SESTRG = "R"
            End Select
            If HelpClass.RspMsgBox(strCadena) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContratoNeg.fintEliminarContrato(oContrato)
                'Ocultar_Datos_Contrato()
                Limpiar_Paneles()
                Buscar_Contrato()
                Llenar_Observaciones()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            Else
                bolCambiar = False
                Me.cmbEstadoCont.SelectedIndex = 0
                bolCambiar = True
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Ocultar Botones"

    Private Sub Ocultar_Botones_Datos_Contrato()
        Me.KryptonHeaderGroup2.ButtonSpecs(0).Visible = False
        Me.KryptonHeaderGroup2.ButtonSpecs(1).Visible = False
        Me.KryptonHeaderGroup2.ButtonSpecs(2).Visible = False
        Me.KryptonHeaderGroup2.ButtonSpecs(3).Visible = False
        Me.KryptonHeaderGroup2.ButtonSpecs(4).Visible = False
        Me.KryptonHeaderGroup2.ButtonSpecs(5).Visible = False
    End Sub

    Private Sub Mostrar_Botones_Datos_Contrato()
        Me.KryptonHeaderGroup2.ButtonSpecs(0).Visible = True
        Me.KryptonHeaderGroup2.ButtonSpecs(1).Visible = True

        Me.KryptonHeaderGroup2.ButtonSpecs(5).Visible = True

    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        If Me.KryptonHeaderGroup2.Collapsed Then
            Mostrar_Botones_Datos_Contrato()
        Else
            Ocultar_Botones_Datos_Contrato()
        End If
    End Sub

#End Region

#Region "Tarifas"
    Private Sub Crear_Nuevo_tarifa()
        If dtgContratos.RowCount = 0 Then Exit Sub
        Dim objTarifa As New Tarifa

        objTarifa.NRCTSL = Me.dtgContratos.CurrentRow.Cells("NRCTSL").Value
        Dim frm As New frmDefTarifa(Me, objTarifa, Nothing)
        frm.StartPosition = FormStartPosition.CenterParent
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cargar_Tarifas()
        End If
    End Sub
    Private Sub Modificar_Tarifa()
        If dtgTarifaContrato.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim objTarifa As Tarifa
        Dim objRango As SOLMIN_CTZ.Entidades.Rango
        Dim frm As frmDefTarifa
        Dim rowActual As Integer = 0
        rowActual = dtgTarifaContrato.CurrentCellAddress.Y
        objTarifa = New Tarifa
        objRango = New SOLMIN_CTZ.Entidades.Rango
        objTarifa.NRCTSL = Me.dtgContratos.CurrentRow.Cells("NRCTSL").Value
        objTarifa.CPLNDV = Me.dtgTarifaContrato.Rows(rowActual).Cells("PLANTA").Value
        objTarifa.NRTFSV = Me.dtgTarifaContrato.Rows(rowActual).Cells("NRTFSV").Value
        objTarifa.NRSRRB = Me.dtgTarifaContrato.Rows(rowActual).Cells("SERVICIO").Value
        objTarifa.CMNDA1 = Me.dtgTarifaContrato.Rows(rowActual).Cells("CMNDA1").Value
        objTarifa.IVLSRV = Me.dtgTarifaContrato.Rows(rowActual).Cells("IVLSRV").Value
        objTarifa.CUNDMD = Me.dtgTarifaContrato.Rows(rowActual).Cells("CUNDMD").Value
        objTarifa.CCNTCS = Me.dtgTarifaContrato.Rows(rowActual).Cells("CCNTCS").Value
        objRango.DESRNG = Me.dtgTarifaContrato.Rows(rowActual).Cells("CONCEPTO").Value.ToString.Trim
        objTarifa.STPTRA = Me.dtgTarifaContrato.Rows(rowActual).Cells("STPTRA").Value
        objTarifa.VALCTE = Me.dtgTarifaContrato.Rows(rowActual).Cells("VALCTE").Value
        objRango.VALMIN = Me.dtgTarifaContrato.Rows(rowActual).Cells("VALMIN").Value
        objRango.VALMAX = Me.dtgTarifaContrato.Rows(rowActual).Cells("VALMAX").Value
        objTarifa.TOBS = Me.dtgTarifaContrato.Rows(rowActual).Cells("TOBS_S").Value
        frm = New frmDefTarifa(Me, objTarifa, objRango)
        intRow = rowActual
        frm.StartPosition = FormStartPosition.CenterParent
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Cargar_Tarifas()
        End If
    End Sub

    Private Sub Grabar_Tarifas_Contrato()
        'Grabar_Tarifas()
        Limpiar_Tarifas()
        Cargar_Tarifas()
    End Sub

    Private Sub Cargar_Tarifas()
        Dim objTarifa As New Tarifa
        Dim oDt As DataTable
        objTarifa.NRCTSL = oContrato.NRCTSL
        oDt = oTarifaNeg.Lista_Tarifa_X_Contrato(objTarifa)
        dtgTarifaContrato.AutoGenerateColumns = False
        dtgTarifaContrato.DataSource = oDt
    End Sub

#End Region

    Private Sub Mostrar_Controles()
        Me.dtgTarifaContrato.Visible = True
        Me.dtgObservaciones.Visible = True
    End Sub

    Private Sub dtgContratos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgContratos.CellClick
        If dtgContratos.RowCount = 0 Then Exit Sub
        Cargar_Informacion_Contrato(Me.dtgContratos.CurrentRow.Cells("NRCTSL").Value, Me.dtgContratos.CurrentRow.Cells("SESTRG").Value) 'Me.dtgContratos.Rows(e.RowIndex).Cells("NRCTSL").Value -- Me.dtgContratos.Rows(e.RowIndex).Cells("SESTRG").Value
    End Sub

    Private Sub Cargar_Informacion_Contrato(ByVal pdblContrato As Double, ByVal pstrEstado As String)
        bolCambiar = False
        Me.GroupBox4.Visible = True
        Mostrar_Controles()
        Limpiar_Paneles()
        oContrato.NRCTSL = pdblContrato
        oContrato.SESTRG = pstrEstado
        'Cargar_Datos_Contrato(pstrEstado)
        Llenar_Observaciones_Contrato()
        Cargar_Tarifas()
        bolCambiar = True
    End Sub

    Private Sub tsmAddObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Agrega_Row_Observacion()
    End Sub

    Private Sub cmbEstadoCont_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstadoCont.SelectedIndexChanged
        If bolCambiar Then
            Actualizar_Estado_Contrato(Me.cmbEstadoCont.SelectedValue)
        End If
    End Sub

    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    Dim frm As frmVisor
    '    Dim objDt As DataTable
    '    Dim objContrato As rptContrato
    '    Dim objDs As New DataSet

    '    objContrato = New rptContrato
    '    objDt = oContratoNeg.Cargar_Datos_Contrato(oContrato)
    '    objDt.TableName = "Det_Contrato"
    '    objDs.Tables.Add(objDt.Copy)
    '    objContrato.SetDataSource(objDs)

    '    frm = New frmVisor(objContrato)
    '    frm.Show()

    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub

#Region "CRUD del detalle"
    Private Sub InicializaBotonesCRUD()
        btnGrabar.Visible = False
        btnCancelar.Visible = False
        btnModificar.Visible = True
        btnNuevo.Visible = True
        btnExportar.Visible = True
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                btnModificar.Visible = False
                btnNuevo.Visible = False
                btnExportar.Visible = False
        End Select
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        InicializaBotonesCRUD()
    End Sub
    Private Sub CambiarBotonesCRUD()
        btnGrabar.Visible = True
        btnCancelar.Visible = True
        btnModificar.Visible = False
        btnNuevo.Visible = False
        btnExportar.Visible = True
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Guardar_Informacion()
    End Sub
    Private Sub Guardar_Informacion()
        Select Case Me.TabControl1.SelectedIndex
            Case 1
                Grabar_Tarifas_Contrato()
            Case 2
                Grabar_Bitacora_Contrato()
        End Select
        InicializaBotonesCRUD()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo_Informacion()
    End Sub

    Private Sub Nuevo_Informacion()
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                'CambiarBotonesCRUD()
                'Crear_Contrato()
            Case 1
                Crear_Nuevo_tarifa()
            Case 2
                CambiarBotonesCRUD()
                Agrega_Row_Observacion()
        End Select
    End Sub

    Private Sub Crear_Contrato()
        Limpiar_Datos_Contrato()
        Me.GroupBox4.Visible = False
        Me.oContrato.NRCTSL = 0
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 2
                CambiarBotonesCRUD()
            Case 1
                Modificar_Tarifa()
        End Select
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        InicializaBotonesCRUD()
        Me.Limpiar_Tarifas()
        Me.Limpiar_Observaciones()
        Me.Limpiar_Controles()
    End Sub
#End Region

#Region "Contrato"
    Private Sub btnNuevoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContrato.Click
        TabControl1.SelectedIndex = 0
        btnGuardarContrato.Visible = True
        btnCancelarContrato.Visible = True
        btnModificarContrato.Visible = False
        btnNuevoContrato.Visible = False
        Crear_Contrato()
    End Sub

    Private Sub btnModificarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarContrato.Click
        TabControl1.SelectedIndex = 0
        dtgContratos_CellClick(Nothing, Nothing)
        btnGuardarContrato.Visible = True
        btnCancelarContrato.Visible = True
        btnModificarContrato.Visible = False
        btnNuevoContrato.Visible = False
    End Sub

    Private Sub btnGuardarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarContrato.Click
        If Me.mskDatFinContrato.Text.Trim = "/  /" Then
            HelpClass.MsgBox("Debe Ingresar la Fecha Fin del Contrato")
            Exit Sub
        End If
        If oContrato.NRCTSL = 0 Then
            Crear_nuevo_Contrato()
        Else
            Grabar_Datos_Contrato()
        End If

        btnGuardarContrato.Visible = False
        btnCancelarContrato.Visible = False
        btnModificarContrato.Visible = True
        btnNuevoContrato.Visible = True

    End Sub
    Private Sub btnCancelarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarContrato.Click
        Limpiar_Datos_Contrato()
        btnGuardarContrato.Visible = False
        btnCancelarContrato.Visible = False
        btnModificarContrato.Visible = True
        btnNuevoContrato.Visible = True
    End Sub
#End Region

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        '----------------------------------------------------------
        Dim dtNuevo As DataTable = New DataTable
        Dim dtCopia As DataTable = New DataTable
        dtNuevo = dtgTarifaContrato.DataSource
        dtCopia = dtNuevo.Copy
        dtCopia.DefaultView.Sort = "TPLNTA"
        dtCopia = dtCopia.DefaultView.ToTable
        Dim nCount As Integer = 0
        Dim sPlanta As String = String.Empty
        '----------------------------------------------------------
        dtCopia.Columns.Remove("NRTFSV")

        dtCopia.Columns.Remove("CPLNDV")
        dtCopia.Columns.Remove("NRSRRB")
        dtCopia.Columns.Remove("CMNDA1")

        dtCopia.Columns.Remove("CUNDMD")
        dtCopia.Columns.Remove("VALCTE")
        dtCopia.Columns.Remove("STPTRA")
        dtCopia.Columns.Remove("NRSRRB1")
        dtCopia.Columns.Remove("NRCTSL")
        dtCopia.Columns.Remove("MEDIDA")
        dtCopia.Columns.Remove("DESTAR")

        For Each dr As DataRow In dtCopia.Rows


            If sPlanta.Trim <> dr("TPLNTA").ToString.Trim Then
                dtCopia.Rows(nCount).Item("TPLNTA") = dr("TPLNTA")
                sPlanta = dr("TPLNTA")
            Else
                sPlanta = dr("TPLNTA")
                dtCopia.Rows(nCount).Item("TPLNTA") = ""
            End If

            dtCopia.Rows(nCount).Item("TARIFA") = " " & dr("TARIFA")

            dtCopia.AcceptChanges()

            nCount += 1
        Next




        dtCopia.Columns("TPLNTA").SetOrdinal(0)
        dtCopia.Columns("CCNTCS").SetOrdinal(1)
        dtCopia.Columns("TCNTCS").SetOrdinal(2)
        dtCopia.Columns("NOMSER").SetOrdinal(3)
        dtCopia.Columns("TARIFA").SetOrdinal(4)
        dtCopia.Columns("TSGNMN").SetOrdinal(5)
        dtCopia.Columns("IVLSRV").SetOrdinal(6)
        dtCopia.Columns("TOBS").SetOrdinal(7)

        dtCopia.Columns("TPLNTA").ColumnName = "PLANTA"
        dtCopia.Columns("CCNTCS").ColumnName = "Cod. CC"
        dtCopia.Columns("TCNTCS").ColumnName = "Centro de Costo"
        dtCopia.Columns("NOMSER").ColumnName = "SERVICIO"
        dtCopia.Columns("TARIFA").ColumnName = "TARIFA"
        dtCopia.Columns("TSGNMN").ColumnName = "MONEDA"
        dtCopia.Columns("IVLSRV").ColumnName = "MONTO"
        dtCopia.Columns("TOBS").ColumnName = "DESCRIPCION"




        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        Dim oDs As New DataSet
        Dim mTitulos As New List(Of String)
        nCount = 0
        mTitulos.Add("\n REPORTE DE TARIFAS POR GRUPO")
        mTitulos.Add("\n ")
        mTitulos.Add("\n Grupo     : " & UcClienteGrupo.pRazonSocial)
        Dim dtTemp As New DataTable
        oClienteGrupo = New cCliente
        oQry_Cliente = New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
        oQry_Cliente.pCCLNT_ClienteGrupo = UcClienteGrupo.pCodigoGrupo
        oQry_Cliente.pNROPAG_NroPagina = 1
        oQry_Cliente.pREGPAG_NroRegPorPagina = 50

        dtTemp = oClienteGrupo.ListarGrupo(oQry_Cliente, "N", 0)

        For Each dr As DataRow In dtTemp.Rows
            If nCount = 0 Then
                mTitulos.Add("\n Cliente    : " & dr("TCMPCL"))
            Else
                mTitulos.Add("\n                  " & dr("TCMPCL"))
            End If
            nCount += 1

        Next

        mTitulos.Add("\n Contrato : " & Me.dtgContratos.CurrentRow.Cells("NCNTRT").Value)


        If dtCopia.Rows.Count > 0 Then

            dtCopia.TableName = "Tarifario"

            oDs.Tables.Add(dtCopia.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelConTitulos(oDs, mTitulos)
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

End Class
