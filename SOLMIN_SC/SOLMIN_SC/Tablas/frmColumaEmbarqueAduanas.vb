Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Public Class frmColumaEmbarqueAduanas
    Private isCheck As Boolean = False
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Sub frmColumaEmbarqueAduanas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            dtgColumna.AutoGenerateColumns = False
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  'Private Sub cmbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBuscar.Click
  '    Try
  '        LlenarDatos()
  '    Catch ex As Exception
  '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    End Try
  'End Sub
    Private Sub LlenarDatos()
        dtgColumna.DataSource = Nothing
        Dim oDt As New DataTable
        Dim oTableroDatos As New clsTableroDatos
        oDt = oTableroDatos.Llenar_Tabla_X_Opcion(cmbCompania.CCMPN_CodigoCompania, cmbCliente.pCodigo, "A", 1, "")
        dtgColumna.DataSource = oDt
      
    End Sub

    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Sub dtgColumna_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgColumna.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgColumna.Columns(dtgColumna.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "TCOLUM", "TDITIN"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 60
                Case "STPCRE"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 1
                Case "NSEPRE"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "3-0"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub dtgColumna_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgColumna.CellEndEdit
        Try
            Dim Valor As String = ""
            For Fila As Integer = 0 To dtgColumna.Rows.Count - 1
                Valor = ("" & dtgColumna.Rows(Fila).Cells("NSEPRE").Value)
                If String.IsNullOrEmpty(Valor) Then
                    dtgColumna.Rows(Fila).Cells("NSEPRE").Value = 0
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarIngresoVisibilidad() As Boolean
        Dim esValido As Boolean = True
        Dim PSSTPCRE_VISIBLE As String = ""
        For Each Item As DataGridViewRow In dtgColumna.Rows
            PSSTPCRE_VISIBLE = ("" & Item.Cells("STPCRE").Value).ToString.Trim.ToUpper
            If PSSTPCRE_VISIBLE <> "S" AndAlso PSSTPCRE_VISIBLE <> "N" Then
                esValido = False
                Exit For
            End If
        Next
        Return esValido
    End Function


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            Dim obeCampoReporte As beTrableroDatos
            Dim oTableroDatos As New clsTableroDatos
            If ValidarIngresoVisibilidad() = False Then
                MessageBox.Show("Verifique ingreso columna Visible.Sólo debe ingreasar S(Visible) | N (No Visible)", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            If MessageBox.Show("La columna Embarque (NORSCI)" & Chr(13) & " debe ser primero en el orden" & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                For Each Item As DataGridViewRow In dtgColumna.Rows
                    obeCampoReporte = New beTrableroDatos
                    obeCampoReporte.PNNMRCRL = Item.Cells("NMRCRL").Value
                    obeCampoReporte.PSTCOLUM = ("" & Item.Cells("TCOLUM").Value).ToString.Trim
                    obeCampoReporte.PSTDITIN = ("" & Item.Cells("TDITIN").Value).ToString.Trim
                    If ("" & Item.Cells("NSEPRE").Value).ToString.Trim = "" Then
                        obeCampoReporte.PNNSEPRE = 0
                    Else
                        obeCampoReporte.PNNSEPRE = Item.Cells("NSEPRE").Value
                    End If
                    obeCampoReporte.PSSTPCRE = Item.Cells("STPCRE").Value.ToString.Trim.ToUpper
                    If ("" & Item.Cells("QANCOL").Value).ToString.Trim = "" Then
                        obeCampoReporte.PNQANCOL = 100
                    Else
                        obeCampoReporte.PNQANCOL = Item.Cells("QANCOL").Value
                    End If

                    oTableroDatos.Actualizar_Columna_Embarque(obeCampoReporte)
                Next
                LlenarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub tsbEliminarCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarCheck.Click
    '    Try
    '        If dtgColumna.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        Dim oTableroDatos As New clsTableroDatos
    '        If MessageBox.Show("Está seguro de eliminar todas las columnas", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '            Dim PNNMRCRL As Decimal = 0
    '            For Each Item As DataGridViewRow In dtgColumna.Rows
    '                PNNMRCRL = Item.Cells("NMRCRL").Value
    '                oTableroDatos.Eliminar_Columna_Embarque(PNNMRCRL)
    '            Next
    '            LlenarDatos()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


  
    Private Sub tsbAgregarCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarCheck.Click
        Try
            Dim ofrmListaColumna As New frmListaColumna
            ofrmListaColumna.pCCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmListaColumna.pCCLNT = cmbCliente.pCodigo
            ofrmListaColumna.pTipoCopia = frmListaColumna.TipoCopia.ColumnaTodos
            If ofrmListaColumna.ShowDialog() = Windows.Forms.DialogResult.OK Then
                LlenarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCopiaPerfil_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiaPerfil.Click
        Try
            Dim ofrmListaColumna As New frmListaColumna
            ofrmListaColumna.pCCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmListaColumna.pCCLNT = cmbCliente.pCodigo
            ofrmListaColumna.pTipoCopia = frmListaColumna.TipoCopia.ColumnaCliente
            If ofrmListaColumna.ShowDialog() = Windows.Forms.DialogResult.OK Then
                LlenarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Function HaySeleccion() As Boolean
        Dim intCont As Integer
        Dim HaySeleccionados As Boolean = False
        For intCont = 0 To dtgColumna.RowCount - 1
            If dtgColumna.Rows(intCont).Cells("CHK_COLUMNA").Value = True Then
                HaySeleccionados = True
                Exit For
            End If
        Next
        Return HaySeleccionados
    End Function
    Private Sub btnEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarItem.Click
        dtgColumna.EndEdit()
        Try
            If HaySeleccion() = True Then

                If dtgColumna.CurrentRow IsNot Nothing Then
                    If MessageBox.Show("Está seguro de eliminar " & Chr(13) & "las columnas seleccionadas", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim PNNMRCRL As Decimal = 0
                        Dim oTableroDatos As New clsTableroDatos
                        Dim Fila As Int32 = 0
                        For Fila = 0 To dtgColumna.RowCount - 1
                            If dtgColumna.Rows(Fila).Cells("CHK_COLUMNA").Value = True Then
                                PNNMRCRL = dtgColumna.Rows(Fila).Cells("NMRCRL").Value
                                oTableroDatos.Eliminar_Columna_Embarque(PNNMRCRL)
                            End If
                        Next
                        LlenarDatos()
                    End If
                End If
            Else
                MessageBox.Show("Debe seleccionar al menos una columna", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            'If dtgColumna.CurrentRow IsNot Nothing Then

            '    If MessageBox.Show("Está seguro de eliminar la columna", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            '        Dim PNNMRCRL As Decimal = 0
            '        Dim oTableroDatos As New clsTableroDatos
            '        PNNMRCRL = dtgColumna.CurrentRow.Cells("NMRCRL").Value
            '        oTableroDatos.Eliminar_Columna_Embarque(PNNMRCRL)
            '        'dtgColumna.Rows.RemoveAt(dtgColumna.CurrentRow.Index)

            '        Dim Fila As Int32 = 0
            '        For Fila = 0 To dtgColumna.RowCount - 1

            '        Next

            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
    Try
      LlenarDatos()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            dtgColumna.EndEdit()
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
        For intCont = 0 To dtgColumna.RowCount - 1
            dtgColumna.Rows(intCont).Cells("CHK_COLUMNA").Value = blnEstado
        Next
    End Sub

    Private Sub btnRenumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenumerar.Click
        Try
            txtNumeracionAvance.Text = txtNumeracionAvance.Text.Trim
            Dim Valor As Decimal = 0
            Dim RECUENTO As Decimal = 0
            If Decimal.TryParse(txtNumeracionAvance.Text, Valor) Then
                If Valor > 0 Then
                    Dim Fila As Int32 = 0
                    For Fila = 0 To dtgColumna.Rows.Count - 1
                        If ("" & dtgColumna.Rows(Fila).Cells("TNMBCM").Value).ToString.Trim = "NORSCI" Then
                            dtgColumna.Rows(Fila).Cells("NSEPRE").Value = 0
                        Else
                            RECUENTO = RECUENTO + Valor
                            If RECUENTO > 1000 Then
                                RECUENTO = 999
                            End If
                            dtgColumna.Rows(Fila).Cells("NSEPRE").Value = RECUENTO
                        End If
                    Next
                End If
            Else
                MessageBox.Show("Ingrese valor de incremento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
