Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
'nBotonGuardar 1=Guardar, 2=Modificar, 3 = Anular Registro, 4=Guardar Relacion, 5= Anular Relacion
Enum eCRUD
    Guardar = 1
    Modificar = 2
    Anular_Registro = 3
    Guardar_Relacion = 4
    Anular_Relacion = 5
End Enum
Public Class frmCarteraCliente
    Private oCliente As SOLMIN_CTZ.NEGOCIO.clsCliente
    Private oClienteEnt As SOLMIN_CTZ.Entidades.Cliente
    Private nRowRelacion As Integer = -1
    Private nBotonGuardar As Integer = 0
    Private Sub frmCarteraCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCliente = New clsCliente
        oClienteEnt = New SOLMIN_CTZ.Entidades.Cliente
        oCliente.Lista_Cliente_Cartera()
        Me.btnGuardar1.Visible = False
        Me.btnCancelar1.Visible = False
        Me.txtDescripcionCli1.Enabled = False
        Me.txtDescripcionCli2.Enabled = False
    End Sub

    Private Sub txtCodigoCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

#Region "Carga Cliente Relacion"
    Private Sub Cargar_Cliente_Cartera_Relacion(ByVal codigoCliente As String)
        Llenar_Grilla_Cartera_Relacion(oCliente.Lista_Cliente_Cartera_Relacion(codigoCliente))
    End Sub
    Private Sub Llenar_Grilla_Cartera_Relacion(ByVal oDt As DataTable)
        dtgRelacion.AutoGenerateColumns = False
        dtgRelacion.DataSource = oDt
    End Sub
#End Region

#Region "Busqueda"
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Buscar_Cartera_Cliente()
    End Sub
    Public Sub Buscar_Cartera_Cliente()
        Dim dtTemp As DataTable
        If txtCodigoCliente.Text = "" And txtClienteBusca.Text = "" Then
            dtTemp = oCliente.Lista_Cliente_Cartera_Seleccion(0)
        Else
            dtTemp = oCliente.Lista_Cliente_Cartera_Seleccion(1, txtCodigoCliente.Text, txtClienteBusca.Text)
        End If

        If dtTemp.Rows.Count > 0 Then
            Llenar_Grilla_Cartera_Cliente(dtTemp)
        End If
    End Sub
    Private Sub Llenar_Grilla_Cartera_Cliente(ByVal oDt As DataTable)
        'Se hace el llenado de la grilla
        dtgClientes.AutoGenerateColumns = False
        dtgClientes.DataSource = oDt
    End Sub

    Private Sub txtClienteBusca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClienteBusca.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            Call Buscar_Cartera_Cliente()
        End If
    End Sub

    Private Sub txtCodigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCliente.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            Call Buscar_Cartera_Cliente()
        End If
    End Sub
#End Region
#Region "Imprimir"
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frm As frmVisorCarteraClientes
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objReporte As rptCarteraCliente

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            objReporte = New rptCarteraCliente
            objDt = oCliente.Lista_Cliente_Cartera_Relacion("-1")
            objDt.TableName = "dtCarteraCliente"
            objDs.Tables.Add(objDt.Copy)
            objReporte.SetDataSource(objDs)
            '------------------------------------
            frm = New frmVisorCarteraClientes(objReporte)
            frm.ShowDialog()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Excepcion: " & ex.Message, "Mostrando Reporte")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
#End Region
    Private Sub dtgClientes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgClientes.CellClick
        If e.RowIndex > -1 Then
            CargaCampos(Me.dtgClientes.Rows(e.RowIndex).Cells("NRCTCL").Value, Me.dtgClientes.Rows(e.RowIndex).Cells("DESCAR").Value, Me.dtgClientes.Rows(e.RowIndex).Cells("NOMCAR").Value)
        End If
    End Sub

    Private Sub dtgClientes_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgClientes.CellEnter
        If e.RowIndex > -1 Then
            CargaCampos(Me.dtgClientes.Rows(e.RowIndex).Cells("NRCTCL").Value, Me.dtgClientes.Rows(e.RowIndex).Cells("DESCAR").Value, Me.dtgClientes.Rows(e.RowIndex).Cells("NOMCAR").Value)
        End If
    End Sub
    Private Sub CargaCampos(ByVal coCliente As String, ByVal deCliente1 As String, ByVal deCliente2 As String)
        If Not (coCliente Is Nothing) Then
            Me.txtCodigoCli.Text = coCliente.Trim
            Me.txtDescripcionCli1.Text = deCliente1.Trim
            Me.txtDescripcionCli2.Text = deCliente2.Trim
            '------------------------------------------------------------------------------
            Cargar_Cliente_Cartera_Relacion(coCliente.Trim)
        Else
            Me.txtCodigoCli.Text = ""
            Me.txtDescripcionCli1.Text = ""
            Me.txtDescripcionCli2.Text = ""
        End If
    End Sub
#Region "CRUD CREA / ACTUALIZA / ELIMINA"
    '-------------AGREGAR NUEVO--------------
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                nBotonGuardar = eCRUD.Guardar
                Agregar_Cartera_Cliente()
            Case 1
                nBotonGuardar = eCRUD.Guardar_Relacion
                Agregar_Relacion_Cliente()
        End Select
    End Sub
    Private Sub Agregar_Cartera_Cliente()
        'Limpia Todo y espera que sea guardado
        DesHabilita_Opciones()
        'Limpia Todos Los Campos
        Me.txtCodigoCli.Text = ""
        Me.txtDescripcionCli1.Text = ""
        Me.txtDescripcionCli2.Text = ""
    End Sub

    Private Sub Habilita_Opciones()
        'Botones Actuales
        Me.btnModificar.Visible = True
        Me.btnAnular.Visible = True
        Me.btnAgregar.Visible = True
        'Botones Ocultos
        Me.btnGuardar1.Visible = False
        Me.btnCancelar1.Visible = False
        'Campos Detalle
        Me.txtDescripcionCli1.Enabled = False
        Me.txtDescripcionCli2.Enabled = False
    End Sub
    Private Sub DesHabilita_Opciones()
        'Botones Actuales
        Me.btnModificar.Visible = False
        Me.btnAnular.Visible = False
        Me.btnAgregar.Visible = False
        'Botones ocultos
        Me.btnGuardar1.Visible = True
        Me.btnCancelar1.Visible = True
        'Campos Detalle
        Me.txtDescripcionCli1.Enabled = True
        Me.txtDescripcionCli2.Enabled = True
        '-----
    End Sub
    Private Sub Agregar_Relacion_Cliente()
        Dim CoGru As String
        Dim NoGru As String
        If txtCodigoCli.Text <> "" Then
            Dim frmNuevaRelacion As New dlgCarteraClienteRelacion(Me)
            CoGru = txtCodigoCli.Text.Trim
            NoGru = txtDescripcionCli1.Text.Trim
            frmNuevaRelacion.txtCodGrupoCliente.Text = CoGru.Trim
            frmNuevaRelacion.txtGrupoCliente.Text = NoGru.Trim
            frmNuevaRelacion.ShowInTaskbar = False
            frmNuevaRelacion.StartPosition = FormStartPosition.CenterScreen
            frmNuevaRelacion.ShowDialog()
        Else
            MsgBox("Debe Seleccionar un Registro para agregar una Relación.", MsgBoxStyle.Information, "Mensaje De Información")
        End If
    End Sub
    Private Sub btnGuardar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar1.Click
        If nBotonGuardar = eCRUD.Guardar Then
            Guardar_Registro()
        End If
        If nBotonGuardar = eCRUD.Modificar Then
            Modificar_Cartera_Cliente()
        End If
    End Sub

    Private Sub Guardar_Registro()
        If Me.txtCodigoCli.Text.Trim <> "" Then
            MsgBox("Debe crear un registro nuevo (Presione el Botón Agregar).", MsgBoxStyle.Information, "Mensaje De Información")
            Habilita_Opciones()
        Else
            Dim x As Integer
            x = MsgBox("Esta seguro que desea GUARDAR este registro ?.", MsgBoxStyle.YesNo, "Mensaje De Información")
            If x = 6 Then
                oClienteEnt.DESCAR = Me.txtDescripcionCli1.Text.Trim.ToUpper
                oClienteEnt.NOMCAR = Me.txtDescripcionCli2.Text.Trim.ToUpper
                Try
                    oCliente.Agregar_Cliente_Cartera(oClienteEnt)
                    oCliente.Lista_Cliente_Cartera()
                    Call Buscar_Cartera_Cliente()
                    Habilita_Opciones()
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Else
                MsgBox("El registro no fue GUARDADO.", MsgBoxStyle.Information, "Mensaje De Información")
            End If
        End If
    End Sub
    Private Sub btnCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar1.Click
        Habilita_Opciones()
    End Sub

    '-------------MODIFICACION------------------
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                nBotonGuardar = eCRUD.Modificar
                DesHabilita_Opciones()
            Case 1
        End Select
    End Sub
    Private Sub Modificar_Cartera_Cliente()

        If Me.txtCodigoCli.Text.Trim = "" Then
            MsgBox("Debe Seleccionar un registro para MODIFICAR.", MsgBoxStyle.Information, "Mensaje De Información")
            Habilita_Opciones()
        Else
            oClienteEnt.NRCTCL = Me.txtCodigoCli.Text.Trim
            oClienteEnt.DESCAR = Me.txtDescripcionCli1.Text.Trim
            oClienteEnt.NOMCAR = Me.txtDescripcionCli2.Text.Trim
            Try
                oCliente.Actualizar_Cliente_Cartera(oClienteEnt)
                oCliente.Lista_Cliente_Cartera()
                Call Buscar_Cartera_Cliente()
                Habilita_Opciones()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End If
    End Sub
    '-------------ANULACION------------------
    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Anular_Cartera_Cliente()
            Case 1
                Anular_Relacion_Cliente()
        End Select
    End Sub
    Private Sub Anular_Cartera_Cliente()
        If Me.txtCodigoCli.Text.Trim = "" Then
            MsgBox("Debe Seleccionar un registro para ANULAR.", MsgBoxStyle.Information, "Mensaje De Información")
        Else
            If MsgBox("Esta seguro que desea ANULAR este registro ?.", MsgBoxStyle.YesNo, "Mensaje De Información") = MsgBoxResult.Yes Then
                oClienteEnt.NRCTCL = Me.txtCodigoCli.Text.Trim
                Try
                    oCliente.Eliminar_Cliente_Cartera(oClienteEnt)
                    oCliente.Lista_Cliente_Cartera()
                    Buscar_Cartera_Cliente()
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try
            Else
                MsgBox("El registro no fue ANULADO.", MsgBoxStyle.Information, "Mensaje De Información")
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Habilita_Opciones()
            Case 1
                btnModificar.Visible = False
        End Select
    End Sub
    Private Sub Anular_Relacion_Cliente()
        If nRowRelacion > -1 Then
            If Me.dtgRelacion.Rows(nRowRelacion).Cells("CCLNT_R").Value = -1 Then
                MsgBox("Debe Seleccionar un registro para ANULAR.", MsgBoxStyle.Information, "Mensaje De Información")
            Else
                Dim x As Integer
                Dim ClienteRelacion As Integer = Me.dtgRelacion.Rows(nRowRelacion).Cells("CCLNT_R").Value
                Dim GrupoRelacion As Integer = Me.dtgRelacion.Rows(nRowRelacion).Cells("NRCTCL_R").Value
                x = MsgBox("Esta seguro que desea ANULAR este relación ? " & Chr(10) & "Cliente: " & CStr(ClienteRelacion) & _
                            " - Grupo: " & CStr(GrupoRelacion), MsgBoxStyle.YesNo, "Mensaje De Información")
                If x = 6 Then
                    Try
                        oClienteEnt.CCLNT = ClienteRelacion
                        oClienteEnt.NRCTCL = GrupoRelacion
                        oCliente.Eliminar_Cliente_Cartera_Relacion(oClienteEnt)
                        oCliente.Lista_Cliente_Cartera()
                        Call Buscar_Cartera_Cliente()
                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    End Try
                Else
                    MsgBox("El registro no fue ANULADO.", MsgBoxStyle.Information, "Mensaje De Información")
                End If
            End If
        End If
    End Sub
    Private Sub dtgRelacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRelacion.CellClick
        If e.RowIndex > -1 Then
            nRowRelacion = e.RowIndex
        End If
    End Sub
#End Region

 
    Private Sub txtCodigoCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCliente.TextChanged

    End Sub
End Class
