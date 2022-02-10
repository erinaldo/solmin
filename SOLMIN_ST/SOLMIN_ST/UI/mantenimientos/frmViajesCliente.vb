Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Imports System
Imports System.Collections.Generic
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmViajesCliente
    Dim IndiceGrilla As Integer = 0
    Private bolEstado As Boolean
    Private obj_ViajeRuta_Find As Viaje_Ruta
    Private obj_Pasajero_Find As Viaje_Pasajero

#Region "FUNCIONES"

    Private Sub Listar_Viajes()
        Dim objBL As New Viajes_Cliente_BL
        Dim objEntidad As New Viajes_Cliente
        objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.PNCCLNT = Me.txtClienteFiltro.pCodigo

        If Me.chkFecha.Checked Then
            objEntidad.PNFINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value)
            objEntidad.PNFFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value)
        Else
            objEntidad.PNFINI = 0
            objEntidad.PNFFIN = 0
        End If

        objEntidad.PNCMEDTR = Me.cboMedioTransFiltro.SelectedValue
        Me.dtgDatos.DataSource = objBL.Listar_Viaje_Cliente(objEntidad)
    End Sub

    Private Sub Realizar_Busqueda()
        TabViajes.SelectedIndex = 0
        Me.Listar_Viajes()
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnImprimir.Enabled = False
        btnExportarDetalle.Enabled = False
        btnAsignarRuta.Enabled = False
        Me.btnAsignarPasajero.Enabled = False
    End Sub

    Private Sub Cargar_Datos_Rutas()
        Dim ObjViajes_Ruta_BL As New Viajes_Ruta_BL
        Dim objEntidad As New Viaje_Ruta
        objEntidad.PNNPRGVJ = Me.dtgDatos.Item("PNNPRGVJ", IndiceGrilla).Value.ToString().Trim
        dtgViajesXRuta.AutoGenerateColumns = False
        Me.dtgViajesXRuta.DataSource = ObjViajes_Ruta_BL.Listar_Viaje_Ruta(objEntidad)
    End Sub

    Private Sub Cargar_Datos_Pasajeros()
        Dim ObjViajes_Ruta_BL As New Viaje_Pasajero_BLL
        Dim objEntidad As New Viaje_Pasajero
        objEntidad.PNNPRGVJ = Me.dtgDatos.Item("PNNPRGVJ", IndiceGrilla).Value.ToString().Trim
        objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania

        'objEntidad.PNNCRRRT = obj_ViajeRuta_Find.PNNCRRRT
        dtgPasajeros.AutoGenerateColumns = False
        Me.dtgPasajeros.DataSource = ObjViajes_Ruta_BL.Listar_Viaje_Pasajero(objEntidad)
    End Sub

#End Region
    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        dtgDatos.Visible = Not dtgDatos.Visible
        Select Case HeaderDatos.Dock
            Case DockStyle.Fill
                HeaderDatos.Dock = DockStyle.Bottom
            Case DockStyle.Bottom
                HeaderDatos.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub frmContratistaxCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lint_contador As Integer = 1
        For lint_contador = 1 To Me.dtgDatos.ColumnCount - 1
            Me.dtgDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador = 1 To Me.dtgViajesXRuta.ColumnCount - 1
            Me.dtgViajesXRuta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador = 1 To Me.dtgPasajeros.ColumnCount - 1
            Me.dtgPasajeros.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        'Pone el flag en neutral
        Me.btnGuardar.Enabled = False
        Me.btnEliminar.Enabled = False

        'bloquea los controles de los tabs
        Me.dtgDatos.AutoGenerateColumns = False
        cmbCompania.Usuario = USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        Me.txtClienteFiltro.pAccesoPorUsuario = True
        Me.txtClienteFiltro.pRequerido = True
        Me.txtClienteFiltro.pUsuario = USUARIO
        Me.txtClienteFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

        Dim ObjPersonal_BL As New Viajes_Cliente_BL
        Me.cboMedioTransFiltro.DataSource = ObjPersonal_BL.Listar_MedioTransporte("TODOS", Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboMedioTransFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransFiltro.DisplayMember = "TNMMDT"
        chkFecha_CheckedChanged(Nothing, Nothing)
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Select Case Me.TabViajes.SelectedIndex
                Case 0
                    Dim frm As New frmAsignarRutas()
                    Dim objEntidad As New Viajes_Cliente
                    objEntidad.PSCCMPN = Me.dtgDatos.Item("PSCCMPN", IndiceGrilla).Value.ToString().Trim()
                    frm.ObjViajes_Cliente = objEntidad
                    frm.ObjViaje_Ruta = Me.obj_ViajeRuta_Find
                    frm.TipoOperacion = frmAsignarPersonal.TIPO.MODIFICAR
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Cargar_Datos_Rutas()
                    End If


                Case 1
                    Dim frm As New frmAsignarPasajeros()
                    frm.ObjPasajero = Me.obj_Pasajero_Find
                    frm.TipoOperacion = frmAsignarPasajeros.TIPO.MODIFICAR
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Cargar_Datos_Pasajeros()
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtgDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgDatos.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                dtgDatos_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dtgDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgDatos.DataBindingComplete
        Try
            If Me.dtgDatos.Rows.Count > 0 Then
                Me.dtgDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Select Case Me.TabViajes.SelectedIndex

            Case 0
                If Me.dtgViajesXRuta.RowCount = 0 OrElse Me.dtgViajesXRuta.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.dtgViajesXRuta.CurrentRow.Selected = False Then Exit Sub
                If Me.dtgPasajeros.RowCount <> 0 Then
                    HelpClass.MsgBox("La ruta tiene pasajeros asignadas")
                    Exit Sub
                End If

                If MsgBox("Desea eliminar la Ruta Programada", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                EliminarViajeRuta(Me.obj_ViajeRuta_Find, "*")
                Me.RecalcularTotalesRutas()
            Case 1
                If Me.dtgPasajeros.RowCount = 0 OrElse Me.dtgPasajeros.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.dtgPasajeros.CurrentRow.Selected = False Then Exit Sub
                If MsgBox("Desea eliminar el Pasajero", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                EliminarViajePasajero(Me.obj_Pasajero_Find, "*")
                Me.RecalcularTotalesPasajero()

        End Select
    End Sub

    Private Sub EliminarViajes(ByVal lstr_Estado As String)
        Dim objEntidad As New Viajes_Cliente
        Dim objViajes_ClienteBL As New Viajes_Cliente_BL
        Try
            objEntidad.PNNPRGVJ = Me.dtgDatos.Item("PNNPRGVJ", IndiceGrilla).Value.ToString().Trim()
            objEntidad.PSSESTRG = lstr_Estado
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            If objViajes_ClienteBL.Eliminar_Viaje_Cliente(objEntidad) = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If
            Me.Realizar_Busqueda()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarViajeRuta(ByVal objEntidad As Viaje_Ruta, ByVal lstr_Estado As String)
        Dim ObjViajes_Ruta_BL As New Viajes_Ruta_BL
        Try
            objEntidad.PSSESTRG = lstr_Estado
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            If ObjViajes_Ruta_BL.Eliminar_Viaje_Ruta(objEntidad) = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If

            Me.Cargar_Datos_Rutas()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarViajePasajero(ByVal objEntidad As Viaje_Pasajero, ByVal lstr_Estado As String)

        Dim ObjViaje_Pasajero_BLL As New Viaje_Pasajero_BLL
        Try
            objEntidad.PSSESTRG = lstr_Estado
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            If ObjViaje_Pasajero_BLL.Eliminar_Viaje_Pasajero(objEntidad) = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If
            Me.Cargar_Datos_Rutas()
            Me.Cargar_Datos_Pasajeros()

        Catch ex As Exception
        End Try
    End Sub


    Private Sub TabViajes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabViajes.SelectedIndexChanged
        Select Case Me.TabViajes.SelectedIndex
            Case 0
                If dtgViajesXRuta.RowCount > 0 Then
                    Me.dtgViajesXRuta.CurrentRow.Selected = False
                End If
                If dtgPasajeros.RowCount > 0 Then
                    Me.dtgPasajeros.CurrentRow.Selected = False
                End If
                If Me.dtgDatos.RowCount > 0 AndAlso Me.dtgDatos.CurrentRow.Selected Then Me.btnAsignarRuta.Enabled = True
                Me.btnAsignarPasajero.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.btnGuardar.Enabled = False


            Case 1

                If dtgPasajeros.RowCount > 0 Then
                    Me.dtgPasajeros.CurrentRow.Selected = False
                End If

                Me.btnEliminar.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnAsignarPasajero.Enabled = False
        End Select

    End Sub

    Private Sub btnAsignarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarRuta.Click
        If Me.dtgDatos.RowCount > 0 Then
            Dim objEntidad As New Viajes_Cliente
            objEntidad.PNNPRGVJ = Me.dtgDatos.Item("PNNPRGVJ", IndiceGrilla).Value.ToString().Trim()
            objEntidad.PSCCMPN = Me.dtgDatos.Item("PSCCMPN", IndiceGrilla).Value.ToString().Trim()
            Dim frm As New frmAsignarRutas()
            frm.TipoOperacion = frmAsignarRutas.TIPO.ASIGNAR
            frm.ObjViajes_Cliente = objEntidad
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cargar_Datos_Rutas()
                Me.RecalcularTotalesRutas()
            End If
        End If
    End Sub

    Private Sub RecalcularTotalesRutas()
        If dtgDatos.RowCount > 0 AndAlso dtgDatos.CurrentRow.Selected = True Then
            dtgDatos.CurrentRow.Cells("PNCANTRUTA").Value = Me.dtgViajesXRuta.Rows.Count
        End If
    End Sub

    Private Sub RecalcularTotalesPasajero()
        If dtgDatos.RowCount > 0 AndAlso dtgDatos.CurrentRow.Selected = True Then
            dtgDatos.CurrentRow.Cells("PNCANTPASAJERO").Value = Me.dtgPasajeros.Rows.Count
        End If
    End Sub


    Private Function BuscarViajeRuta(ByVal obeEntidad As Viaje_Ruta) As Boolean
        Dim blResult As Boolean
        blResult = obeEntidad.PNNPRGVJ = obj_ViajeRuta_Find.PNNPRGVJ AndAlso _
                     obeEntidad.PNNCRRRT = obj_ViajeRuta_Find.PNNCRRRT

        Return blResult
    End Function

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Me.dtpFechaInicio.Enabled = chkFecha.Checked
        Me.dtpFechaFin.Enabled = chkFecha.Checked

    End Sub

    Private Sub btnAsignarPasajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarPasajero.Click
        If Me.dtgViajesXRuta.RowCount > 0 AndAlso Me.dtgViajesXRuta.CurrentRow.Selected = True Then
            Me.btnGuardar.Enabled = True
            'Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = True
            Me.btnAsignarPasajero.Enabled = True

            Dim objViajeRuta As New Viaje_Ruta
            Dim objPersonal As New Personal_Contratista

            Dim lint_indice As Integer = Me.dtgViajesXRuta.CurrentCellAddress.Y
            objViajeRuta.PNNPRGVJ = Me.dtgViajesXRuta.Item("PNNPRGVJ_1", lint_indice).Value.ToString().Trim()
            objViajeRuta.PNNCRRRT = Me.dtgViajesXRuta.Item("PNNCRRRT_1", lint_indice).Value.ToString().Trim()
            objPersonal.PNCCLNT = Me.dtgDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim()

            Dim frm As New frmAsignarPasajeros()
            frm.TipoOperacion = frmAsignarRutas.TIPO.ASIGNAR
            frm.ObjViaje_Ruta = objViajeRuta
            frm.ObjPersonal = objPersonal

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cargar_Datos_Rutas()
                Me.Cargar_Datos_Pasajeros()
                Me.RecalcularTotalesPasajero()
            End If
        End If
    End Sub

    Private Function BuscarViajePasajero(ByVal obeEntidad As Viaje_Pasajero) As Boolean
        Dim blResult As Boolean
        blResult = obeEntidad.PNNPRGVJ = obj_Pasajero_Find.PNNPRGVJ AndAlso _
                     obeEntidad.PNNCRRRT = obj_Pasajero_Find.PNNCRRRT AndAlso _
                     obeEntidad.PNNCRRIN = obj_Pasajero_Find.PNNCRRIN
        Return blResult
    End Function

    Private Sub dtgViajesXRuta_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgViajesXRuta.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                dtgViajesXRuta_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dtgPasajeros_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPasajeros.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                dtgPasajeros_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub dtgViajesXRuta_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgViajesXRuta.DataBindingComplete
        Try
            If Me.dtgViajesXRuta.Rows.Count > 0 Then
                Me.dtgViajesXRuta.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtgPasajeros_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgPasajeros.DataBindingComplete
        Try
            If Me.dtgPasajeros.Rows.Count > 0 Then
                Me.dtgPasajeros.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Imprimir(ByVal tipo As Boolean)
        Dim ObjViaje_Pasajero_BLL As New Viaje_Pasajero_BLL
        Dim objparametros As New Viaje_Pasajero
        Dim objReporte As New rptReporteProgramacionViaje
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        objparametros.PNCCLNT = Me.txtClienteFiltro.pCodigo
        objparametros.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania

        If Me.chkFecha.Checked Then
            objparametros.PNFECINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value)
            objparametros.PNFECFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value)
        Else
            objparametros.PNFECINI = 0
            objparametros.PNFECFIN = 0
        End If

        If tipo Then
            If dtgDatos.RowCount > 0 AndAlso dtgDatos.CurrentRow.Selected = True Then
                objparametros.PNCCLNT = Me.dtgDatos.Item(0, IndiceGrilla).Value.ToString().Trim
            End If

            If dtgViajesXRuta.RowCount > 0 Then
                objparametros.PNNPRGVJ = Me.dtgViajesXRuta.Item(0, Me.dtgViajesXRuta.CurrentCellAddress.Y).Value.ToString().Trim
            End If
        End If

        objDt = ObjViaje_Pasajero_BLL.RptListar_Programacion_Viaje(objparametros)
        objDt.TableName = "ProgramacionViaje"
        objDs.Tables.Add(objDt.Copy)

        HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporte, "lblUsuario", USUARIO)

        objReporte.SetDataSource(objDs)
        objPrintForm.ShowForm(objReporte, Me)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Imprimir(True)
    End Sub

    Private Sub btnExportarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarDetalle.Click
        If Not Me.dtgDatos.RowCount > 0 Then Exit Sub
        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim objparametros As New Viaje_Pasajero
        Dim ObjViaje_Pasajero_BLL As New Viaje_Pasajero_BLL

        If Me.chkFecha.Checked Then
            objparametros.PNFECINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value)
            objparametros.PNFECFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value)
        Else
            objparametros.PNFECINI = 0
            objparametros.PNFECFIN = 0
        End If
        objparametros.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objparametros.PNCMEDTR = Me.cboMedioTransFiltro.SelectedValue

        If dtgDatos.RowCount > 0 AndAlso dtgDatos.CurrentRow.Selected = True Then
            objparametros.PNCCLNT = Me.dtgDatos.Item(0, IndiceGrilla).Value.ToString().Trim
        End If

        If dtgViajesXRuta.RowCount > 0 Then
            objparametros.PNNPRGVJ = Me.dtgViajesXRuta.Item(0, Me.dtgViajesXRuta.CurrentCellAddress.Y).Value.ToString().Trim
        End If

        objDt = ObjViaje_Pasajero_BLL.RptListar_Programacion_Viaje(objparametros)
        objDt.Columns.Remove("NRUC")
        objDt.Columns("TCMPCL").ColumnName = "Cliente"
        objDt.Columns("NPRGVJ").ColumnName = "N° Programación Viaje"
        objDt.Columns("FCHPSA").ColumnName = "Fecha Programación"
        objDt.Columns("HRAPSA").ColumnName = "Hora Programación"
        objDt.Columns("TNMMDT").ColumnName = "Medio Transporte"
        objDt.Columns("RUTA").ColumnName = "Ruta"
        objDt.Columns("FSLDRT").ColumnName = "Fecha Viaje"
        objDt.Columns("HSLDRT").ColumnName = "Hora Viaje"
        objDt.Columns("QCPSDS").ColumnName = "Pasajeros Disponible"
        objDt.Columns("QCPSUT").ColumnName = "Pasajeros Asignados"
        objDt.Columns("TPRVCL").ColumnName = "Contratista"
        objDt.Columns("NMBPER").ColumnName = "Pasajero"
        objDt.Columns("NCREMB").ColumnName = "N° Embarque"
        objDt.Columns("NPSPER").ColumnName = "N° Pase"
        objDt.Columns("FVCPSP").ColumnName = "Fecha Vencimiento Pase"

        Dim ObjTemp As DataRow = Nothing
        For Each dr As DataRow In objDt.Rows
            If (Not ObjTemp Is Nothing) AndAlso dr("Cliente") = ObjTemp("Cliente") AndAlso _
                dr("N° Programación Viaje") = ObjTemp("N° Programación Viaje") AndAlso _
                dr("Fecha Programación") = ObjTemp("Fecha Programación") Then
                dr("Cliente") = ""
                dr("N° Programación Viaje") = ""
                dr("Fecha Programación") = ""
                dr("Hora Programación") = ""
                dr("Medio Transporte") = ""
            Else
                ObjTemp = dr
            End If
        Next
        Dim loEncabezados As New Generic.List(Of Encabezados)
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "COMPAÑIA : " & " " & Me.cmbCompania.CCMPN_Descripcion))
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CLIENTE : " & IIf(txtClienteFiltro.pCodigo = 0, "TODOS", txtClienteFiltro.pCodigo & " - " & txtClienteFiltro.pRazonSocial)))
        If Me.chkFecha.Checked Then
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "F. INICIO : " & " " & Me.dtpFechaInicio.Value.Date))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "F. FIN : " & " " & Me.dtpFechaFin.Value.Date))
        End If
        If Me.cboMedioTransFiltro.SelectedValue = 0 Then
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "MEDIO TRANSPORTE : " & " " & Me.cboMedioTransFiltro.Text))
        End If

        If dtgDatos.RowCount > 0 AndAlso dtgDatos.CurrentRow.Selected = True Then
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & Me.dtgDatos.Item("PNCANTRUTA", IndiceGrilla).Value.ToString().Trim))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & Me.dtgDatos.Item("PNCANTPASAJERO", IndiceGrilla).Value.ToString().Trim))
        Else
            Dim intCantRuta As Integer
            Dim intCantPasajero As Integer
            For Each drow As DataGridViewRow In dtgDatos.Rows
                intCantRuta += drow.Cells("PNCANTRUTA").Value
                intCantPasajero += drow.Cells("PNCANTPASAJERO").Value
            Next
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & intCantRuta.ToString))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & intCantPasajero.ToString))
        End If

        'Envía los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.FILENAME, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.HOJA, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.TITULO, "PROGRAMACION DE VIAJE - CLIENTE"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.DECIMALES, "0.00"))
        ODs.Tables.Add(objDt.Copy)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    End Sub

    Private Sub btnImprimirHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirHeader.Click
        Imprimir(False)
    End Sub

    Private Sub btnExportarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarHeader.Click
        If Not Me.dtgDatos.RowCount > 0 Then Exit Sub
        Dim ODs As New DataSet
        Dim objDt As New DataTable
        Dim objparametros As New Viaje_Pasajero
        Dim ObjViaje_Pasajero_BLL As New Viaje_Pasajero_BLL
        objparametros.PNCCLNT = Me.txtClienteFiltro.pCodigo
        objparametros.PNNPRGVJ = 0
        If Me.chkFecha.Checked Then
            objparametros.PNFECINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value)
            objparametros.PNFECFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value)
        Else
            objparametros.PNFECINI = 0
            objparametros.PNFECFIN = 0
        End If
        objparametros.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objparametros.PNCMEDTR = Me.cboMedioTransFiltro.SelectedValue
        objDt = ObjViaje_Pasajero_BLL.RptListar_Programacion_Viaje(objparametros)
        objDt.Columns.Remove("NRUC")
        objDt.Columns("TCMPCL").ColumnName = "Cliente"
        objDt.Columns("NPRGVJ").ColumnName = "N° Programación Viaje"
        objDt.Columns("FCHPSA").ColumnName = "Fecha Programación"
        objDt.Columns("HRAPSA").ColumnName = "Hora Programación"
        objDt.Columns("TNMMDT").ColumnName = "Medio Transporte"
        objDt.Columns("RUTA").ColumnName = "Ruta"
        objDt.Columns("FSLDRT").ColumnName = "Fecha Viaje"
        objDt.Columns("HSLDRT").ColumnName = "Hora Viaje"
        objDt.Columns("QCPSDS").ColumnName = "Pasajeros Disponible"
        objDt.Columns("QCPSUT").ColumnName = "Pasajeros Asignados"
        objDt.Columns("TPRVCL").ColumnName = "Contratista"
        objDt.Columns("NMBPER").ColumnName = "Pasajero"
        objDt.Columns("NCREMB").ColumnName = "N° Embarque"
        objDt.Columns("NPSPER").ColumnName = "N° Pase"
        objDt.Columns("FVCPSP").ColumnName = "Fecha Vencimiento Pase"

        Dim ObjTemp As DataRow = Nothing
        For Each dr As DataRow In objDt.Rows
            If (Not ObjTemp Is Nothing) AndAlso dr("Cliente") = ObjTemp("Cliente") AndAlso _
                dr("N° Programación Viaje") = ObjTemp("N° Programación Viaje") AndAlso _
                dr("Fecha Programación") = ObjTemp("Fecha Programación") Then
                dr("Cliente") = ""
                dr("N° Programación Viaje") = ""
                dr("Fecha Programación") = ""
                dr("Hora Programación") = ""
                dr("Medio Transporte") = ""

            Else
                ObjTemp = dr
            End If
        Next
        Dim loEncabezados As New Generic.List(Of Encabezados)
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "COMPAÑIA : " & " " & Me.cmbCompania.CCMPN_Descripcion))
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CLIENTE : " & IIf(txtClienteFiltro.pCodigo = 0, "TODOS", txtClienteFiltro.pCodigo & " - " & txtClienteFiltro.pRazonSocial)))
        If Me.chkFecha.Checked Then
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "F. INICIO : " & " " & Me.dtpFechaInicio.Value.Date))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "F. FIN : " & " " & Me.dtpFechaFin.Value.Date))
        End If
        If Me.cboMedioTransFiltro.SelectedValue = 0 Then
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "MEDIO TRANSPORTE : " & " " & Me.cboMedioTransFiltro.Text))
        End If

        Dim intCantRuta As Integer
        Dim intCantPasajero As Integer
        For Each drow As DataGridViewRow In dtgDatos.Rows
            intCantRuta += drow.Cells("PNCANTRUTA").Value
            intCantPasajero += drow.Cells("PNCANTPASAJERO").Value
        Next

        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & intCantRuta.ToString))
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & intCantPasajero.ToString))
        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.FILENAME, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.HOJA, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.TITULO, "PROGRAMACION DE VIAJE - CLIENTE"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.DECIMALES, "0.00"))
        ODs.Tables.Add(objDt.Copy)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    End Sub

    Private Sub btnBuscarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarHeader.Click
        If Me.cmbCompania.CCMPN_CodigoCompania = "0" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.Realizar_Busqueda()
        Me.dtgViajesXRuta.DataSource = Nothing
        Me.dtgPasajeros.DataSource = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnNuevoHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoHeader.Click

    Dim frm As New frmNuevoViajeCliente
    Dim objEntidad As New Viajes_Cliente
    frm.TipoOperacion = frmAsignarRutas.TIPO.ASIGNAR
    objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    frm.objEntidad = objEntidad

    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
      btnBuscarHeader_Click(Nothing, Nothing)
      IndiceGrilla = 0
      Me.btnAsignarRuta.Enabled = False
      Me.btnEliminar.Enabled = False
      Me.dtgViajesXRuta.DataSource = Nothing
      Me.dtgPasajeros.DataSource = Nothing
      If Me.dtgDatos.Rows.Count > 0 Then
        Me.dtgDatos.CurrentRow.Selected = False
      End If
    End If
    End Sub

    Private Sub btnSaveHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveHeader.Click
        If Not Me.dtgDatos.RowCount > 0 Then Exit Sub
        Dim frm As New frmNuevoViajeCliente
        Dim objEntidad As New Viajes_Cliente
        objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.PNNPRGVJ = Val(Me.dtgDatos.Item("PNNPRGVJ", IndiceGrilla).Value.ToString().Trim())
        objEntidad.PNCCLNT = Val(Me.dtgDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim)
        objEntidad.PNCMEDTR = Val(Me.dtgDatos.Item("PNCMEDTR", IndiceGrilla).Value.ToString().Trim)
        objEntidad.PNFCHPSA_1 = Val(Me.dtgDatos.Item("PNFCHPSA_1", IndiceGrilla).Value.ToString())
        objEntidad.PNHRAPSA_1 = Val(Me.dtgDatos.Item("PNHRAPSA_1", IndiceGrilla).Value.ToString())

        frm.TipoOperacion = frmAsignarRutas.TIPO.MODIFICAR
        frm.objEntidad = objEntidad

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnBuscarHeader_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnEliminarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarHeader.Click
        If Me.dtgDatos.RowCount = 0 OrElse Me.dtgDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.dtgDatos.CurrentRow.Selected = False Then Exit Sub
        If Me.dtgViajesXRuta.RowCount <> 0 Then
            HelpClass.MsgBox("El viaje tiene rutas asignadas")
            Exit Sub
        End If
        If MsgBox("Desea eliminar el Viaje Programado", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        EliminarViajes("*")
    End Sub

    Private Sub dtgDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellClick
        If Me.dtgDatos.RowCount = 0 OrElse Me.dtgDatos.CurrentCellAddress.Y < 0 OrElse e.RowIndex < 0 Then Exit Sub
        'Marcando el estado de Edicion Header
        Me.btnSaveHeader.Enabled = True
        Me.btnEliminarHeader.Enabled = True
        '''''''''''''''''''''''''''''''''''''''''''''''
        IndiceGrilla = Me.dtgDatos.CurrentCellAddress.Y
        If Me.dtgDatos.Rows.Count > 0 Then
            Me.dtgDatos.CurrentRow.Selected = True
        End If

        Me.Cargar_Datos_Rutas()
        Me.Cargar_Datos_Pasajeros()
        Me.btnImprimir.Enabled = True
        Me.btnExportarDetalle.Enabled = True
        Me.btnAsignarRuta.Enabled = True
        Me.btnAsignarPasajero.Enabled = False

        If TabViajes.SelectedIndex = 0 Then
            If dtgViajesXRuta.RowCount > 0 Then
                Me.dtgViajesXRuta.CurrentRow.Selected = False
            End If
            Me.btnEliminar.Enabled = False
            Me.btnGuardar.Enabled = False
            btnExportarExcel.Enabled = False
        ElseIf TabViajes.SelectedIndex = 1 Then
            If Me.dtgPasajeros.RowCount > 0 Then
                Me.dtgPasajeros.CurrentRow.Selected = False
            End If

            Me.btnEliminar.Enabled = False
            Me.btnGuardar.Enabled = False
            btnExportarExcel.Enabled = False
        End If
    End Sub

    Private Sub dtgViajesXRuta_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgViajesXRuta.CellClick
        If Me.dtgViajesXRuta.RowCount = 0 OrElse Me.dtgViajesXRuta.CurrentCellAddress.Y < 0 OrElse e.RowIndex < 0 Then Exit Sub
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnAsignarPasajero.Enabled = True
        Dim lobj_Entidad As List(Of Viaje_Ruta)
        lobj_Entidad = DirectCast(Me.dtgViajesXRuta.DataSource, List(Of Viaje_Ruta))
        obj_ViajeRuta_Find = New Viaje_Ruta
        Dim lint_indice As Integer = Me.dtgViajesXRuta.CurrentCellAddress.Y
        obj_ViajeRuta_Find.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        obj_ViajeRuta_Find.PNNPRGVJ = Me.dtgViajesXRuta.Item("PNNPRGVJ_1", lint_indice).Value
        obj_ViajeRuta_Find.PNNCRRRT = Me.dtgViajesXRuta.Item("PNNCRRRT_1", lint_indice).Value

        Dim pred As New Predicate(Of Viaje_Ruta)(AddressOf BuscarViajeRuta)
        obj_ViajeRuta_Find = lobj_Entidad.FindAll(pred)(0)

    End Sub

    Private Sub dtgPasajeros_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPasajeros.CellClick
        If Me.dtgPasajeros.RowCount = 0 OrElse Me.dtgPasajeros.CurrentCellAddress.Y < 0 OrElse e.RowIndex < 0 Then Exit Sub
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True
        ' Me.btnAsignarPasajero.Enabled = True
        If dtgPasajeros.RowCount > 0 Then
            Dim lobj_pasajero As List(Of Viaje_Pasajero)
            lobj_pasajero = Me.dtgPasajeros.DataSource
            obj_Pasajero_Find = New Viaje_Pasajero
            Dim lint_indice As Integer = Me.dtgPasajeros.CurrentCellAddress.Y
            obj_Pasajero_Find.PNNPRGVJ = Me.dtgPasajeros.Item("PNNPRGVJ_2", lint_indice).Value
            obj_Pasajero_Find.PNNCRRRT = Me.dtgPasajeros.Item("PNNCRRRT_2", lint_indice).Value
            obj_Pasajero_Find.PNNCRRIN = Me.dtgPasajeros.Item("PNNCRRIN", lint_indice).Value
            obj_Pasajero_Find.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            Dim pred As New Predicate(Of Viaje_Pasajero)(AddressOf BuscarViajePasajero)
            obj_Pasajero_Find = lobj_pasajero.FindAll(pred)(0)
        End If
    End Sub


End Class

