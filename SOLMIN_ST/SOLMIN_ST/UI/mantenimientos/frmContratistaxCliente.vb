Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Imports System
Imports System.Collections.Generic
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmContratistaxCliente
    Dim IndiceGrilla As Integer = 0
    Private bolEstado As Boolean
    Private obj_Personal_Find As Personal_Contratista

#Region "FUNCIONES"
    Private Sub Listar_Contratista()
        Dim objBL As New Contratista_Cliente_BL
        Dim objEntidad As New Contratista_Cliente
        objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.PNCCLNT = Me.txtClienteFiltro.pCodigo
        Me.gwdDatos.DataSource = objBL.Listar_Contratista_Cliente(objEntidad)
    End Sub

    Private Sub Realizar_Busqueda()
        TabContratista.SelectedIndex = 0
        Me.Listar_Contratista()
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnImprimir.Enabled = False
        'End If
    End Sub

    Private Sub SinAsignacionGrillas()
        Try
            If (gwdPersonal.Rows.Count > 0) Then gwdPersonal.Rows.Clear()
            'If (gwdPersonal.Rows.Count > 0) Then gwdPersonal.DataSource = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AccionCancelarPersonal()
        Me.Cargar_Datos_Personal()
        Me.btnAsignarPersonal.Enabled = True
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.Enabled = False
        Me.btnEliminar.Enabled = False
    End Sub

    Private Sub Cargar_Datos_Personal()
        Dim ObjPersonal_BL As New Personal_Contratista_BL
        Dim objEntidad As New Personal_Contratista
        objEntidad.PNCPRVCL = Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim
        objEntidad.PNCCLNT = Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim
        objEntidad.PSCCMPN = Me.gwdDatos.Item("PSCCMPN", IndiceGrilla).Value.ToString().Trim
        gwdPersonal.AutoGenerateColumns = False
        Me.gwdPersonal.DataSource = ObjPersonal_BL.Listar_Personal_Contratista(objEntidad)

    End Sub

#End Region

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        gwdDatos.Visible = Not gwdDatos.Visible
        Select Case HeaderDatos.Dock
            Case DockStyle.Fill
                HeaderDatos.Dock = DockStyle.Bottom
            Case DockStyle.Bottom
                HeaderDatos.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub frmContratistaxCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim lint_contador As Integer = 1
        For lint_contador = 1 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador = 1 To Me.gwdPersonal.ColumnCount - 1
            Me.gwdPersonal.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
 
        Me.btnGuardar.Enabled = False
        Me.btnEliminar.Enabled = False
      
        'bloquea los controles de los tabs
        Me.gwdDatos.AutoGenerateColumns = False

        cmbCompania.Usuario = USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        Me.txtClienteFiltro.pAccesoPorUsuario = True
        Me.txtClienteFiltro.pRequerido = True
        Me.txtClienteFiltro.pUsuario = USUARIO
        Me.txtClienteFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Select Case Me.TabContratista.SelectedIndex
                Case 0
                    Dim frm As New frmAsignarPersonal()
                    frm.ObjPersonal = Me.obj_Personal_Find
                    frm.ObjPersonal.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    frm.TipoOperacion = frmAsignarPersonal.TIPO.MODIFICAR
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Cargar_Datos_Personal()
                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                gwdDatos_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.gwdPersonal.RowCount = 0 OrElse Me.gwdPersonal.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdPersonal.CurrentRow.Selected = False Then Exit Sub
        If MsgBox("Desea eliminar el Personal", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        EliminarPersonalContratista(Me.obj_Personal_Find, "*")
        Me.RecalcularTotales()
    End Sub

    Private Sub EliminarContratista(ByVal lstr_Estado As String)
        Dim objEntidad As New Contratista_Cliente
        Dim objContratistaBL As New Contratista_Cliente_BL
        Try
            objEntidad.PNCCLNT = Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim
            objEntidad.PNCPRVCL = Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim
        
            objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objEntidad.PSSESTRG = lstr_Estado
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            If objContratistaBL.Eliminar_Contratista_Cliente(objEntidad) = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If
            Me.Realizar_Busqueda()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub EliminarPersonalContratista(ByVal objEntidad As Personal_Contratista, ByVal lstr_Estado As String)

        Dim objPersonalBL As New Personal_Contratista_BL
        Try
            objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objEntidad.PSSESTRG = lstr_Estado
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            Select Case objPersonalBL.Eliminar_Personal_Contratista(objEntidad)
                Case 0
                    HelpClass.MsgBox("No se Eliminó por que existen pasajeros asignados")
                    Exit Sub
                Case 1
                    HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
                Case Else
                    HelpClass.ErrorMsgBox()
                    Exit Sub
            End Select
            Me.Cargar_Datos_Personal()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAsignarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarPersonal.Click
        If Me.gwdDatos.RowCount > 0 AndAlso gwdDatos.CurrentRow.Selected = True Then
            Dim objEntidad As New Contratista_Cliente
            objEntidad.PNCCLNT = Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim
            objEntidad.PNCPRVCL = Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim
            objEntidad.PSCCMPN = Me.gwdDatos.Item("PSCCMPN", IndiceGrilla).Value.ToString().Trim
            objEntidad.PNNDIART = Me.gwdDatos.Item("PNNDIART", IndiceGrilla).Value.ToString().Trim()

            Dim frm As New frmAsignarPersonal()
            frm.TipoOperacion = frmAsignarPersonal.TIPO.ASIGNAR
            frm.ObjContratista = objEntidad
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cargar_Datos_Personal()
                Me.RecalcularTotales()
            End If

            
        End If
    End Sub
    Private Sub RecalcularTotales()
        If gwdDatos.RowCount > 0 AndAlso gwdDatos.CurrentRow.Selected = True Then
            gwdDatos.CurrentRow.Cells("PNCANTPERSONAL").Value = Me.gwdPersonal.Rows.Count
        End If
    End Sub

    Private Function BuscarPersonal(ByVal obePersonal As Personal_Contratista) As Boolean
        Dim blResult As Boolean
        blResult = obePersonal.PNCCLNT = obj_Personal_Find.PNCCLNT AndAlso _
        obePersonal.PNCPRVCL = obj_Personal_Find.PNCPRVCL AndAlso _
        obePersonal.PSTPDCPE = obj_Personal_Find.PSTPDCPE AndAlso _
        obePersonal.PSNMDCPE = obj_Personal_Find.PSNMDCPE
        Return blResult
    End Function

    Private Sub gwdPersonal_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdPersonal.DataBindingComplete
        Try
            If Me.gwdPersonal.Rows.Count > 0 Then
                Me.gwdPersonal.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gwdPersonal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdPersonal.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                gwdPersonal_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub txtNroRotacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ImprimirContratista(True)
    End Sub

  Private Sub ImprimirContratista(ByVal Tipo As Boolean)
        Dim objPersonal_Contratista_BL As New Personal_Contratista_BL
        Dim objparametros As New Personal_Contratista
        Dim objReporte As New rptReporteContratistaPersonal

        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm

        objparametros.PNCCLNT = Me.txtClienteFiltro.pCodigo
        objparametros.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania

        If Tipo Then
            objparametros.PNCPRVCL = Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim
            objparametros.PNCCLNT = Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim
        End If

        objDt = objPersonal_Contratista_BL.RptListar_Contratista_Personal(objparametros)
        objDt.TableName = "Contratista_Cliente"
        objDs.Tables.Add(objDt.Copy)

        HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporte, "lblUsuario", USUARIO)

        objReporte.SetDataSource(objDs)
        objPrintForm.ShowForm(objReporte, Me)

  End Sub
  
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarDetalle.Click
        ExportarContratista(True)
    End Sub

    Private Sub ExportarContratista(ByVal Tipo As Boolean)
        If Not Me.gwdDatos.RowCount > 0 Then Exit Sub
        Dim objDt As New DataTable
        Dim objPersonal_Contratista_BL As New Personal_Contratista_BL

        Dim objparametros As New Personal_Contratista
        objparametros.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        If Tipo AndAlso gwdDatos.RowCount > 0 AndAlso gwdDatos.CurrentRow.Selected = True Then
            objparametros.PNCPRVCL = Val(Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim)
            objparametros.PNCCLNT = Val(Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim)
        End If
        objDt = objPersonal_Contratista_BL.RptListar_Contratista_Personal(objparametros)

        objDt.Columns.Remove("NRUC")
        objDt.Columns.Remove("PDCNAT")
        objDt.Columns("TCMPCL").ColumnName = "Cliente"
        objDt.Columns("TPRVCL").ColumnName = "Contratista"
        objDt.Columns("NRUCPR").ColumnName = "RUC - Contratista"
        objDt.Columns("NDIART_C").ColumnName = "Rotación Contratista"
        objDt.Columns("NMBPER").ColumnName = "Personal"
        objDt.Columns("TNCION").ColumnName = "Nacionalidad"
        objDt.Columns("FNCMTO").ColumnName = "Fecha Nacimiento"
        objDt.Columns("TPDCPE").ColumnName = "Tipo Documento"
        objDt.Columns("NMDCPE").ColumnName = "N° Documento"
        objDt.Columns("TDSDES").ColumnName = "Dirección"
        objDt.Columns("CCTPPE").ColumnName = "Puesto"
        objDt.Columns("FINGEM").ColumnName = "Fecha Ingreso"
        objDt.Columns("NMCNAP").ColumnName = "Nombre Comunidad Nativa"
        objDt.Columns("NDIART_P").ColumnName = "Rotación Personal"

        Dim ObjTemp As DataRow = Nothing
        For Each dr As DataRow In objDt.Rows
            If (Not ObjTemp Is Nothing) AndAlso dr("Cliente") = ObjTemp("Cliente") AndAlso _
             dr("Contratista") = ObjTemp("Contratista") Then
                dr("Cliente") = ""
                dr("Contratista") = ""
                dr("RUC - Contratista") = ""
                dr("Rotación Contratista") = ""
            Else
                ObjTemp = dr
            End If
        Next

        Dim loEncabezados As New Generic.List(Of Encabezados)
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "COMPAÑIA : " & " " & Me.cmbCompania.CCMPN_Descripcion))
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CLIENTE : " & IIf(txtClienteFiltro.pCodigo = 0, "TODOS", txtClienteFiltro.pCodigo & " - " & txtClienteFiltro.pRazonSocial)))

        'Envia los Parametros para la exportacion
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.FILENAME, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.HOJA, "Programacion Viaje"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.TITULO, "PERSONAL POR CONTRATISTA - CLIENTE"))
        loEncabezados.Add(New Encabezados("", Encabezados.TipoEncabezado.DECIMALES, "0.00"))

        Dim intCantPersonal As Integer
        If Tipo AndAlso gwdDatos.RowCount > 0 AndAlso gwdDatos.CurrentRow.Selected = True Then
            intCantPersonal = Val(Me.gwdDatos.Item("PNCANTPERSONAL", IndiceGrilla).Value.ToString().Trim)
        Else
            For Each drow As DataGridViewRow In gwdDatos.Rows
                intCantPersonal += Val(drow.Cells("PNCANTPERSONAL").Value)
            Next
        End If
        loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PERSONAL : " & intCantPersonal.ToString))

        Dim ODs As New DataSet
        ODs.Tables.Add(objDt.Copy)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    End Sub

    Private Sub btnImprimirHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirHeader.Click
        ImprimirContratista(False)
    End Sub

    Private Sub btnExportarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarHeader.Click
        ExportarContratista(False)
    End Sub

    Private Sub btnBuscarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarHeader.Click
        If Me.cmbCompania.CCMPN_CodigoCompania = "0" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.Realizar_Busqueda()
        Me.gwdPersonal.DataSource = Nothing
        Me.Cursor = Cursors.Default
        Me.btnAsignarPersonal.Enabled = False
        Me.btnExportarDetalle.Enabled = False
    End Sub

    Private Sub btnNuevoHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoHeader.Click
        Dim frm As New frmNuevoContratistaCliente
        Dim objEntidad As New Contratista_Cliente
        frm.TipoOperacion = frmAsignarRutas.TIPO.ASIGNAR
        objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        frm.objContratistaBE = objEntidad
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnBuscarHeader_Click(Nothing, Nothing)
            IndiceGrilla = 0
            Me.btnEliminar.Enabled = False
            Me.gwdPersonal.DataSource = Nothing
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        End If
    End Sub

    Private Sub btnModificarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarHeader.Click
        If Not Me.gwdDatos.RowCount > 0 Then Exit Sub
        If Me.gwdPersonal.RowCount > 0 Then
            HelpClass.MsgBox("No se Puede Modificar, ya tiene personal Asignado", MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim frm As New frmNuevoContratistaCliente
        Dim objEntidad As New Contratista_Cliente
        objEntidad.PNCCLNT = Me.gwdDatos.Item("PNCCLNT", IndiceGrilla).Value.ToString().Trim
        objEntidad.PNCPRVCL = Me.gwdDatos.Item("CPRVCL", IndiceGrilla).Value.ToString().Trim
        objEntidad.PSCCMPN = Me.gwdDatos.Item("PSCCMPN", IndiceGrilla).Value.ToString().Trim
        objEntidad.PNNDIART = Me.gwdDatos.Item("PNNDIART", IndiceGrilla).Value.ToString().Trim()
        frm.TipoOperacion = frmAsignarRutas.TIPO.MODIFICAR
        frm.objContratistaBE = objEntidad
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnBuscarHeader_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btneliminarHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarHeader.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If Me.gwdPersonal.RowCount <> 0 Then
            HelpClass.MsgBox("El contratista tiene asignado  personal si quiere eliminar comuniquese al Dpto. de Sistemas")
            Exit Sub
        End If
        If MsgBox("Desea eliminar el Contratista", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        EliminarContratista("*")
    End Sub


    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse e.RowIndex < 0 Then Exit Sub
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = True
        End If
        IndiceGrilla = Me.gwdDatos.CurrentCellAddress.Y
        Me.Cargar_Datos_Personal()
        If gwdPersonal.RowCount > 0 Then
            Me.gwdPersonal.CurrentRow.Selected = False
        End If
        Me.btnEliminar.Enabled = False
        Me.btnGuardar.Enabled = False

        Me.btnModificarHeader.Enabled = True
        Me.btneliminarHeader.Enabled = True
        Me.btnAsignarPersonal.Enabled = True
        Me.btnImprimir.Enabled = True
        Me.btnExportarDetalle.Enabled = True
    End Sub

    Private Sub gwdPersonal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdPersonal.CellClick
        If Me.gwdPersonal.RowCount = 0 OrElse Me.gwdPersonal.CurrentCellAddress.Y < 0 OrElse e.RowIndex < 0 Then Exit Sub
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True

        If gwdPersonal.RowCount > 0 Then
            Dim lobj_Entidad As List(Of Personal_Contratista)
            lobj_Entidad = DirectCast(Me.gwdPersonal.DataSource, List(Of Personal_Contratista))
            Dim obj_Personal_BL As New Personal_Contratista_BL
            obj_Personal_Find = New Personal_Contratista
            Dim lint_indice As Integer = Me.gwdPersonal.CurrentCellAddress.Y
            obj_Personal_Find.PNCCLNT = Me.gwdPersonal.Item("CCLNT_P", lint_indice).Value
            obj_Personal_Find.PNCPRVCL = Me.gwdPersonal.Item("PNCPRVCL", lint_indice).Value
            obj_Personal_Find.PSTPDCPE = Me.gwdPersonal.Item("PSTPDCPE_P", lint_indice).Value
            obj_Personal_Find.PSNMDCPE = Me.gwdPersonal.Item("PSNMDCPE", lint_indice).Value

            Dim pred As New Predicate(Of Personal_Contratista)(AddressOf BuscarPersonal)
            obj_Personal_Find = lobj_Entidad.FindAll(pred)(0)
        End If
    End Sub

    Private Sub gwdPersonal_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdPersonal.CellContentDoubleClick
        If (gwdPersonal.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim Columna As String = gwdPersonal.Columns(e.ColumnIndex).Name
        Try
            If Columna.ToUpper = "Historial".ToUpper Then
                Dim frm As New frmHistorialPersonal
                Dim objEntidad As New Personal_Contratista
                objEntidad.PSCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                objEntidad.PNCCLNT = gwdPersonal.CurrentRow.Cells("CCLNT_P").Value
                objEntidad.PNCPRVCL = gwdPersonal.CurrentRow.Cells("PNCPRVCL").Value
                objEntidad.PSTPDCPE = gwdPersonal.CurrentRow.Cells("PSTPDCPE_P").Value
                objEntidad.PSNMDCPE = gwdPersonal.CurrentRow.Cells("PSNMDCPE").Value
                frm.objContratistaBE = objEntidad
                frm.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class