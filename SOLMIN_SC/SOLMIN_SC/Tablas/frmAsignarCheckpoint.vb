Imports SOLMIN_SC.Negocio
Imports System.Web
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmAsignarCheckpoint

#Region "Atributos"
    Private strSeguimiento As String
    Private intPosicion As Integer
    Dim Estado As String = ""
    Dim Flag As String = ""
    Private isCheck As Boolean = False
    Private oDtDatosCheckPoint As New DataTable
#End Region

#Region "Metodos y Funciones"

    Private Sub Exportar_Grilla_Checkpoint()
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtCheckPointExportar As New DataTable
        Dim MdataColumna As String = ""

        odtCheckPointExportar.Columns.Add("NOMVAR").Caption = NPOI_SC.FormatDato("Tipo CheckPoint", NPOI_SC.keyDatoTexto)

        odtCheckPointExportar.Columns.Add("TDESES").Caption = NPOI_SC.FormatDato("CheckPoint", NPOI_SC.keyDatoTexto)

        odtCheckPointExportar.Columns.Add("TCOLUM").Caption = NPOI_SC.FormatDato("Nombre en el Seguimiento", NPOI_SC.keyDatoTexto)

        odtCheckPointExportar.Columns.Add("NSEPRE").Caption = NPOI_SC.FormatDato("Número de Presentación", NPOI_SC.keyDatoTexto)

        Dim dr As DataRow
        Dim NameColumna As String = ""
        For Each drDatos As DataRow In oDtDatosCheckPoint.Rows
            dr = odtCheckPointExportar.NewRow
            For Each dcColumna As DataColumn In odtCheckPointExportar.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = drDatos(NameColumna)
            Next
            odtCheckPointExportar.Rows.Add(dr)
        Next
     
        Dim oListDataTable As New List(Of DataTable)
        oListDataTable.Add(odtCheckPointExportar)

        Dim ListFiltro As New List(Of SortedList)
        Dim ItemFiltro As New SortedList
        ItemFiltro.Add(ItemFiltro.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
        ItemFiltro.Add(ItemFiltro.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
        ListFiltro.Add(ItemFiltro)

        Dim ListTitulo As New List(Of String)
        ListTitulo.Add("LISTA DE CHECKPOINT")

        'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTA DE CHECKPOINT", Nothing, oLisParametros)
        NPOI_SC.ExportExcelGeneralReleaseMultiple(oListDataTable, ListTitulo, Nothing, ListFiltro, 0, Nothing)


    End Sub


    Private Sub Cargar_Tipo_CheckPoint()
        Dim oCheckPoint As New clsCheckPoint
        Dim dtCheckPoint As New DataTable
        Dim dr As DataRow

        dtCheckPoint.Columns.Add("VALVAR")
        dtCheckPoint.Columns.Add("NOMVAR")

        dr = dtCheckPoint.NewRow

        dr("VALVAR") = ""
        dr("NOMVAR") = "TODOS"
        dtCheckPoint.Rows.Add(dr)


        'dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint

        'dtCheckPoint.Rows.RemoveAt(3)
        'dtCheckPoint.Rows.RemoveAt(3)
        'dtCheckPoint.Rows.RemoveAt(2)
        'dtCheckPoint.Rows.RemoveAt(1)

        cmbTipoCheck.DataSource = dtCheckPoint
        cmbTipoCheck.ValueMember = "VALVAR"
        cmbTipoCheck.DisplayMember = "NOMVAR"
        cmbTipoCheck.SelectedValue = ""
    End Sub

    Private Sub Cargar_Tipo_CheckPoint_SIL()
        Dim oCheckPoint As New clsCheckPoint
        Dim dtCheckPoint As New DataTable
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint

        dtCheckPoint.Rows.RemoveAt(3)
        dtCheckPoint.Rows.RemoveAt(3)
        cmbTipoCheck.DataSource = dtCheckPoint
        cmbTipoCheck.ValueMember = "VALVAR"
        cmbTipoCheck.DisplayMember = "NOMVAR"
        cmbTipoCheck.SelectedValue = ""
    End Sub

    Private Sub Buscar_CheckPoints()
        Me.dtgCheckpoint.Rows.Clear()
        If Me.cmbCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Llenar_Grilla_Checkpoints()
    End Sub

    Private Sub Llenar_Grilla_Checkpoints()
        Me.dtgCheckpoint.Rows.Clear()
        Dim oCheckPoint As New clsCheckPoint
        Dim dblCliente As Double
        Dim intCont As Integer
        Dim CCMPN As String = cmbCompania.CCMPN_CodigoCompania
        Dim CDVSN As String = cmbDivision.Division
        Dim oDrVw As DataGridViewRow
        dblCliente = Me.cmbCliente.pCodigo
        oDtDatosCheckPoint = oCheckPoint.Lista_CheckPoint_X_Cliente(dblCliente, cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, cmbTipoCheck.SelectedValue, "A")
        Dim Fila As Int32 = 0
        With oDtDatosCheckPoint
            If oDtDatosCheckPoint.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgCheckpoint)
                    dtgCheckpoint.Rows.Add(oDrVw)
                    Fila = dtgCheckpoint.Rows.Count - 1

                    dtgCheckpoint.Rows(Fila).Cells("CODIGO").Value = .Rows(intCont).Item("NESTDO").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("CEMB").Value = .Rows(intCont).Item("CEMB").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("TIPO").Value = .Rows(intCont).Item("NOMVAR").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("CHECPOINT").Value = .Rows(intCont).Item("TDESES").ToString.Trim

                    If .Rows(intCont).Item("ASIGNADO").ToString <> "A" Then
                        dtgCheckpoint.Rows(Fila).Cells("NPRESENTACION").ReadOnly = True
                    End If
                    dtgCheckpoint.Rows(Fila).Cells("SESTRG").Value = .Rows(intCont).Item("ASIGNADO").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("TCOLUM").Value = .Rows(intCont).Item("TCOLUM").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("SESTRG2").Value = .Rows(intCont).Item("SESTRG").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("NPRESENTACION").Value = .Rows(intCont).Item("NSEPRE").ToString.Trim

                    If .Rows(intCont).Item("SESTRG").ToString = "A" Then
                        dtgCheckpoint.Rows(Fila).Cells("IMSESTRG").Value = ImageList1.Images(0)
                    Else
                        dtgCheckpoint.Rows(Fila).Cells("IMSESTRG").Value = ImageList1.Images(1)
                    End If

                    dtgCheckpoint.Rows(Fila).Cells("CCMPN").Value = .Rows(intCont).Item("CCMPN").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("CDVSN").Value = .Rows(intCont).Item("CDVSN").ToString.Trim
                    dtgCheckpoint.Rows(Fila).Cells("CCLNT").Value = .Rows(intCont).Item("CCLNT").ToString.Trim

                Next intCont
            End If
        End With
        Colorear_Fila()
    End Sub

    Private Sub Colorear_Fila()
        For Each Fila As DataGridViewRow In Me.dtgCheckpoint.Rows
            Select Case Fila.Cells("CEMB").Value.ToString.Trim
                Case "A"
                    Fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    If Fila.Cells("TCOLUM").Value.ToString.Trim = "*" Then
                        Fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193)
                    End If
                Case "P"
                    Fila.DefaultCellStyle.BackColor = Color.FromArgb(251, 233, 187)
                    If Fila.Cells("TCOLUM").Value.ToString.Trim = "*" Then
                        Fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193)
                    End If
                Case "T"
                    Fila.DefaultCellStyle.BackColor = Color.FromArgb(236, 254, 214)
                    If Fila.Cells("TCOLUM").Value.ToString.Trim = "*" Then
                        Fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193)
                    End If
                Case "M"
                    Fila.DefaultCellStyle.BackColor = Color.FromArgb(251, 238, 252)
                    If Fila.Cells("TCOLUM").Value.ToString.Trim = "*" Then
                        Fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193)
                    End If
            End Select
        Next
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmAsignarCheckpoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            'cmbCompania_Seleccionar(Nothing)
            'Cargar_Tipo_CheckPoint()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        ' cmbCompania_Seleccionar(cmbCompania.data
    End Sub



    'Private Function GetCompania() As String
    '    'Return cmbCompania.CCMPN_CodigoCompania
    '    Return "EZ"
    'End Function
    'Private Function GetDivision(ByVal CCMPN As String) As String
    '    If CCMPN = "EZ" Then
    '        Return HelpClass.getSetting("DivisionEZ")
    '    Else
    '        Return ""
    '    End If
    'End Function

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
  '    Try
  '        Buscar_CheckPoints()
  '    Catch ex As Exception
  '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    End Try

  'End Sub

    Private Sub btnGuardarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardarOrdenCheck.Click
        Try
            If cmbCliente.pCodigo = 0 Then Exit Sub
            If Me.dtgCheckpoint.RowCount = 0 OrElse Me.dtgCheckpoint.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim oCheckPoint As New clsCheckPoint
            Dim intCont As Integer

            Dim obeParamCheckPoint As beCheckPoint
            For intCont = 0 To dtgCheckpoint.RowCount - 1
                obeParamCheckPoint = New beCheckPoint
                obeParamCheckPoint.PNCCLNT = cmbCliente.pCodigo
                obeParamCheckPoint.PNNESTDO = dtgCheckpoint.Rows(intCont).Cells("CODIGO").Value
                obeParamCheckPoint.PNNSEPRE = dtgCheckpoint.Rows(intCont).Cells("NPRESENTACION").Value
                oCheckPoint.Actualizar_Orden_Checkpoint(obeParamCheckPoint)
            Next intCont
            Buscar_CheckPoints()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        Try
            If Me.dtgCheckpoint.RowCount = 0 OrElse Me.dtgCheckpoint.CurrentCellAddress.Y < 0 Then Exit Sub
            If dtgCheckpoint.Rows.Count = 0 Then Exit Sub
            Exportar_Grilla_Checkpoint()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub tsbAgregarCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarCheck.Click
        If cmbCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim ofrmMantenimientoCheckpoint As New frmMantenimientoCheckpoint
            ofrmMantenimientoCheckpoint.BuscarDatosDefault = True
            ofrmMantenimientoCheckpoint.Compania = cmbCompania.CCMPN_CodigoCompania
            ofrmMantenimientoCheckpoint.Division = cmbDivision.Division
            ofrmMantenimientoCheckpoint.CodCliente = cmbCliente.pCodigo
            If (ofrmMantenimientoCheckpoint.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                Buscar_CheckPoints()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbModificarCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarCheck.Click
        Try
            If Me.dtgCheckpoint.RowCount = 0 OrElse Me.dtgCheckpoint.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim ofrmMantenimientoCheckpoint As New frmMantenimientoCheckpoint
            Dim Fila As Int32 = dtgCheckpoint.CurrentCellAddress.Y
            ofrmMantenimientoCheckpoint.Compania = dtgCheckpoint.Rows(Fila).Cells("CCMPN").Value
            ofrmMantenimientoCheckpoint.Division = dtgCheckpoint.Rows(Fila).Cells("CDVSN").Value
            ofrmMantenimientoCheckpoint.CodCliente = dtgCheckpoint.Rows(Fila).Cells("CCLNT").Value
            ofrmMantenimientoCheckpoint.Estado = dtgCheckpoint.Rows(Fila).Cells("SESTRG").Value
            ofrmMantenimientoCheckpoint.CodTipoCheckpoint = dtgCheckpoint.Rows(Fila).Cells("CEMB").Value
            ofrmMantenimientoCheckpoint.CodCheckpoint = dtgCheckpoint.Rows(Fila).Cells("CODIGO").Value
            ofrmMantenimientoCheckpoint.NomSeguimiento = dtgCheckpoint.Rows(Fila).Cells("TCOLUM").Value
            ofrmMantenimientoCheckpoint.SESTRG2 = dtgCheckpoint.Rows(Fila).Cells("SESTRG2").Value
            ofrmMantenimientoCheckpoint.SESTRG = dtgCheckpoint.Rows(Fila).Cells("SESTRG").Value
            ofrmMantenimientoCheckpoint.NroPresentacion = dtgCheckpoint.Rows(Fila).Cells("NPRESENTACION").Value
            ofrmMantenimientoCheckpoint.BuscarDatosDefault = False
            ofrmMantenimientoCheckpoint.cmbTipoCheckpoint.Enabled = False
            ofrmMantenimientoCheckpoint.UcCheckpoint.Enabled = False
            If ofrmMantenimientoCheckpoint.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Buscar_CheckPoints()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbEliminarCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarCheck.Click
        dtgCheckpoint.EndEdit()
        Try
            Dim Fila As Int32 = 0
            Dim PSCCMPN As String = cmbCompania.CCMPN_CodigoCompania
            Dim PSCDVSN As String = cmbDivision.Division
            Dim oCheckPoint As New clsCheckPoint
            If HaySeleccion() = True Then
                If MessageBox.Show("Está seguro de eliminar" & Chr(13) & "los checkpoint seleccionados ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    For Fila = 0 To dtgCheckpoint.RowCount - 1
                        If dtgCheckpoint.Rows(Fila).Cells("CHK_COLUMNA").Value = True Then
                            oCheckPoint.Mant_CheckPoint_X_Cliente(PSCCMPN, PSCDVSN, "E", Me.cmbCliente.pCodigo, Me.dtgCheckpoint.Rows(Fila).Cells("CODIGO").Value, "", "*", "*")
                        End If
                    Next
                    Buscar_CheckPoints()
                End If
            Else
                MessageBox.Show("Debe seleccionar al menos un checkpoint", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim PSCCMPN As String = GetCompania()
        'Dim PSCDVSN As String = GetDivision(PSCCMPN)
        'Try
        '    Dim oCheckPoint As New clsCheckPoint
        '    If Me.dtgCheckpoint.CurrentCellAddress.Y = -1 Then Exit Sub
        '    If Me.dtgCheckpoint.RowCount = 0 OrElse Me.dtgCheckpoint.CurrentCellAddress.Y < 0 Then Exit Sub
        '    If (MessageBox.Show("¿Desea Eliminar el registro ?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
        '        oCheckPoint.Mant_CheckPoint_X_Cliente(PSCCMPN, PSCDVSN, "E", Me.cmbCliente.pCodigo, Me.dtgCheckpoint.CurrentRow.Cells("CODIGO").Value, txtNomSeguimiento.Text, "*", "*")
        '        Buscar_CheckPoints()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

#End Region

    'Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania)
    '    Try
    '        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
    '            'oCheckPoint.Crea_Lista()
    '            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
    '            dtgCheckpoint.Rows.Clear()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Function HaySeleccion() As Boolean
        Dim intCont As Integer
        Dim HaySeleccionados As Boolean = False
        For intCont = 0 To dtgCheckpoint.RowCount - 1
            If dtgCheckpoint.Rows(intCont).Cells("CHK_COLUMNA").Value = True Then
                HaySeleccionados = True
                Exit For
            End If
        Next
        Return HaySeleccionados
    End Function



  Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
    Try
      Buscar_CheckPoints()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

    Private Sub btnCopiarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPerfil.Click
        If cmbCliente.pCodigo = 0 Then
            MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim oFrmAddCheckCliente As New FrmAddCheckCliente
        oFrmAddCheckCliente.pCCLNT = cmbCliente.pCodigo
        oFrmAddCheckCliente.pCCMPN = cmbCompania.CCMPN_CodigoCompania
        If oFrmAddCheckCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Buscar_CheckPoints()
        End If
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            dtgCheckpoint.EndEdit()
            isCheck = Not isCheck
            If isCheck = True Then
                btnCheck.Image = My.Resources.btnMarcarItems
            Else
                btnCheck.Image = My.Resources.btnNoMarcarItems
            End If
            Poner_Check_Todo(isCheck)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgCheckpoint.RowCount - 1
            dtgCheckpoint.Rows(intCont).Cells("CHK_COLUMNA").Value = blnEstado
        Next
    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.Usuario = HelpUtil.UserName
            If cmbDivision.Compania = "EZ" Then
                cmbDivision.DivisionDefault = "S"
                cmbDivision.pHabilitado = False
            End If
            cmbDivision.pActualizar()
            cmbDivision_SelectionChangeCommitted(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            If cmbDivision.Division = "S" Then
                Cargar_Tipo_CheckPoint_SIL()
            Else
                Cargar_Tipo_CheckPoint()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 
End Class
