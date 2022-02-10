Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmMantDirecServ
    Dim blUbigeo As New clsUbigeo
    Dim blDirecServ As New clsDirecServ
    Enum estado
        neutro
        editar
        nuevo
    End Enum

    Private p_estadoActual As estado
    Private Sub EstadoControl(ByVal p_estado As estado)
        Select Case TabControl1.SelectedTab.Name
            Case "TabDireccion"
                Select Case p_estado
                    Case estado.neutro
                        btnNuevoDet.Enabled = True
                        btnModificarDet.Enabled = True
                        btnModificarDet.Visible = True
                        btnGrabarDet.Visible = False
                        tsS03.Visible = False
                        btnCancelarDet.Enabled = False
                        btnEliminarDet.Enabled = True
                        btnCancelarDet.Visible = False

                        txtReferencia.Enabled = False
                        txtDireccion.Enabled = False
                        cboUbigeo.Enabled = False
                        txtCodigo.Enabled = False
                    Case estado.editar

                        btnNuevoDet.Enabled = False
                        btnModificarDet.Visible = True
                        btnModificarDet.Enabled = False
                        btnGrabarDet.Visible = True
                        tsS03.Visible = True
                        btnCancelarDet.Enabled = True
                        btnCancelarDet.Visible = True
                        btnEliminarDet.Enabled = False

                        txtReferencia.Enabled = True
                        txtDireccion.Enabled = False
                        cboUbigeo.Enabled = False
                        txtCodigo.Enabled = False
                    Case estado.nuevo
                        btnNuevoDet.Enabled = False
                        btnModificarDet.Enabled = False
                        btnGrabarDet.Enabled = True
                        btnGrabarDet.Visible = True
                        tsS03.Visible = True
                        btnCancelarDet.Enabled = True
                        btnCancelarDet.Visible = True

                        btnEliminarDet.Enabled = False
                        btnModificarDet.Visible = True


                        txtReferencia.Enabled = True
                        txtDireccion.Enabled = True
                        cboUbigeo.Enabled = True
                End Select
            Case "TabClientexDireccion"
                Select Case p_estado
                    Case estado.neutro
                        btnModificarDet.Visible = False
                        btnGrabarDet.Visible = False
                        btnCancelarDet.Visible = False
                        tsS07.Visible = False
                        tsS03.Visible = False

                        tsS05.Visible = False


                        btnNuevoDet.Enabled = True
                        btnEliminarDet.Enabled = True
                End Select
        End Select
    End Sub
    Private Sub frmMantDirecServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgvClienteXDireccion.AutoGenerateColumns = False
        Try
            p_estadoActual = estado.neutro
            EstadoControl(p_estadoActual)
            txtCodigo.Enabled = False
            CargarComboUbigeo()
            Cargar_Planta()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarComboUbigeo()
        cboUbigeo.DataSource = blUbigeo.ListarUbigeo()
        cboUbigeo.ListColumnas = blUbigeo.ColumnaUbigeo()
        cboUbigeo.Cargas()
        cboUbigeo.Limpiar()
        cboUbigeo.ValueMember = "Codigo"
        cboUbigeo.DispleyMember = "Ubigeo"

    End Sub

    Private Sub LimpiarControles()
        txtCodigo.Clear()
        txtDireccion.Clear()
        cboUbigeo.Limpiar()
        txtReferencia.Clear()
    End Sub

    Private Function ValidarDatos() As Boolean

        Dim mensaje As String = String.Empty
        Dim cant As Integer = 0

        If txtDireccion.Text.Trim() = String.Empty Or txtDireccion.Text.Trim() = "" Then
            mensaje = mensaje & "Debe ingresar Dirección" & vbNewLine
            cant = cant + 1
        End If

        If cboUbigeo.Resultado Is Nothing Then
            mensaje = mensaje & "Debe seleccionar Ubigeo" & vbNewLine
            cant = cant + 1
        End If

        If cant > 0 Then
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If


        Return True

    End Function

    Private Sub btnNuevoDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoDet.Click
        Try
            If TabControl1.SelectedTab.Name = "TabClientexDireccion" Then
                If dtgDirecServ.CurrentRow Is Nothing Then
                    Return
                End If

                Dim CodDireccion As Decimal = dtgDirecServ.CurrentRow.Cells("CDIRSE").Value.ToString().Trim()
                Dim frm As New frmMantClienteDir
                frm.PNCDIRSE = CodDireccion
                frm.ShowDialog()
                If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                    Listar_DatosClienteXDireccion()
                End If
                frm.Close()
                frm = Nothing
            Else
                LimpiarControles()
                EstadoControl(estado.nuevo)
                p_estadoActual = estado.nuevo
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Listar_Datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Listar_Datos()


        Dim codigo As Decimal
        Dim codigoCliente As Decimal = UcCliente.pCodigo

        codigo = Val(txtCodigoBuscar.Text.Trim())
        dtgDirecServ.AutoGenerateColumns = False
        Dim planta As Decimal = 0
        If CType(cboPlanta.Resultado, SOLMIN_CTZ.Entidades.bePlanta) Is Nothing Then
            planta = 0
        Else

            planta = CType(cboPlanta.Resultado, SOLMIN_CTZ.Entidades.bePlanta).Cplndv
        End If
        dtgDirecServ.DataSource = blDirecServ.Lista_Direccion_Servicio(codigo, txtDireccionBuscar.Text.Trim(), codigoCliente, planta)


    End Sub

    Private Sub Listar_DatosClienteXDireccion()


        If dtgDirecServ.CurrentRow Is Nothing Then
            Return
        End If

        Dim CodDireccion As Decimal = dtgDirecServ.CurrentRow.Cells("CDIRSE").Value.ToString().Trim()

        dgvClienteXDireccion.DataSource = blDirecServ.Lista_ClienteXDireccion(CodDireccion)


    End Sub


    Private Sub btnGrabarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarDet.Click
        Try
            If TabControl1.SelectedTab.Name = "TabDireccion" Then
                If ValidarDatos() Then

                    Dim mensaje As String = String.Empty

                    Dim beDirecServ As New beDirecServ

                    With beDirecServ

                        .Direccion = txtDireccion.Text.Trim()
                        .Referencia = txtReferencia.Text.Trim()
                        .Ubigeo = Integer.Parse(CType(cboUbigeo.Resultado, beUbigeo).Codigo)
                        .MachineName = Environment.MachineName
                        .Usuario_creador = ConfigurationWizard.UserName
                        .Codigo = txtCodigo.Text.Trim()
                        .Usuario_act = ConfigurationWizard.UserName

                    End With

                    If p_estadoActual = estado.nuevo Then
                        Dim dtValida As New DataTable
                        dtValida = blDirecServ.BuscarDireccion_ServicioxDescripcion(beDirecServ.Direccion)
                        If dtValida.Rows.Count > 0 Then
                            Dim varCDIRSE As Decimal
                            varCDIRSE = dtValida.Rows.Item(0)("CDIRSE")
                            If MessageBox.Show("La dirección del servicio ya se encuentra registrada (Cod. Dirección:" & varCDIRSE & "). ¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                mensaje = blDirecServ.Insertar_Direccion_Servicio(beDirecServ)
                            Else
                                Return
                            End If
                        Else
                            mensaje = blDirecServ.Insertar_Direccion_Servicio(beDirecServ)
                        End If


                    End If
                    If p_estadoActual = estado.editar Then
                        mensaje = blDirecServ.Modificar_Direccion_Servicio(beDirecServ)
                    End If

                    MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarControles()
                    EstadoControl(estado.neutro)
                    p_estadoActual = estado.neutro
                    Listar_Datos()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Planta()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Cplndv"
        oColumnas.DataPropertyName = "Cplndv"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Tplnta"
        oColumnas.DataPropertyName = "Tplnta"
        oColumnas.HeaderText = "Planta"
        oListColum.Add(2, oColumnas)
        Dim blPlanta As New clsPlanta
        Dim listPlanta As New List(Of bePlanta)
        listPlanta = blPlanta.Lista_Planta()
        If listPlanta.Count > 0 Then
            cboPlanta.DataSource = listPlanta
        Else
            cboPlanta.DataSource = Nothing
        End If
        cboPlanta.ListColumnas = oListColum
        cboPlanta.Cargas()
        cboPlanta.Limpiar()
        cboPlanta.ValueMember = "Cplndv"
        cboPlanta.DispleyMember = "Tplnta"


    End Sub

    Private Sub btnModificarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDet.Click
        Try
            If dtgDirecServ.CurrentRow Is Nothing Then
                Return
            End If
            EstadoControl(estado.editar)
            cboUbigeo.Enabled = False
            txtDireccion.Enabled = False
            p_estadoActual = estado.editar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDet.Click
        Try
            If TabControl1.SelectedTab.Name = "TabClientexDireccion" Then
                If dtgDirecServ.CurrentRow Is Nothing Then
                    Return
                End If
                If dgvClienteXDireccion.CurrentRow Is Nothing Then
                    MessageBox.Show("Debe seleccionar un registro para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                If MessageBox.Show("¿Está seguro de eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then


                    Dim CodCliente As Decimal = dgvClienteXDireccion.CurrentRow.Cells("CCLNT5").Value.ToString().Trim()
                    Dim CodDireccion As Decimal = dtgDirecServ.CurrentRow.Cells("CDIRSE").Value.ToString().Trim()
                    Dim CodItem As Decimal = dgvClienteXDireccion.CurrentRow.Cells("ITEM").Value.ToString().Trim()
                    Dim objbeClienteDireccion As New beClienteDireccion
                    objbeClienteDireccion.PNCCLNT = CodCliente
                    objbeClienteDireccion.PNCDIRSE = CodDireccion
                    objbeClienteDireccion.PNITEM = CodItem
                    Dim strMensaje As String = String.Empty
                    strMensaje = blDirecServ.EliminarAsignacionClienteDirServicio(objbeClienteDireccion)
                    MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Listar_DatosClienteXDireccion()
                    p_estadoActual = estado.neutro
                    EstadoControl(p_estadoActual)
                End If
            Else
                Dim beDirecServ As New beDirecServ
                Dim mensaje As String
                If txtCodigo.Text.Trim() = String.Empty Or txtCodigo.Text = "" Then
                    MessageBox.Show("Debe seleccionar un registro para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                If MessageBox.Show("¿Está seguro de eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    If txtCodigo.Text.Trim() = String.Empty Or txtCodigo.Text = "" Then
                        MessageBox.Show("Debe seleccionar un registro para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    Else
                        With beDirecServ

                            .MachineName = Environment.MachineName
                            .Codigo = txtCodigo.Text.Trim()
                            .Usuario_act = ConfigurationWizard.UserName

                        End With

                        mensaje = blDirecServ.Eliminar_Direccion_Servicio(beDirecServ)
                        MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        p_estadoActual = estado.neutro
                        EstadoControl(p_estadoActual)
                        LimpiarControles()
                        Listar_Datos()
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ExportarExcel()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExportarExcel()
        Dim dt As New DataTable
        Dim ds As New DataSet

        Dim countrows As Integer = dtgDirecServ.Rows.Count()

        dt.Columns.Add("Código")
        dt.Columns.Add("Dirección")
        dt.Columns.Add("Ubigeo")
        dt.Columns.Add("Referencia")
        dt.Columns.Add("Usuario Creador")
        dt.Columns.Add("Usuario Act")

        For index As Integer = 0 To countrows - 1
            Dim dr As DataRow = dt.NewRow
            dr("Código") = dtgDirecServ.Item("CDIRSE", index).Value
            dr("Dirección") = dtgDirecServ.Item("DEDISE", index).Value
            dr("Ubigeo") = dtgDirecServ.Item("UBIGEO", index).Value
            dr("Referencia") = dtgDirecServ.Item("DREFSE", index).Value
            dr("Usuario Creador") = dtgDirecServ.Item("USU_CREADOR", index).Value
            dr("Usuario Act") = dtgDirecServ.Item("USU_ACT", index).Value
            dt.Rows.Add(dr)
        Next

        ds.Tables.Add(dt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Listado de Dirección Servicios \n ")

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(ds, strlTitulo)
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBuscar.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDet.Click
        Try
            LimpiarControles()
            dtgDirecServ_SelectionChanged(Nothing, Nothing)
            p_estadoActual = estado.neutro
            EstadoControl(estado.neutro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dtgDirecServ_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDirecServ.SelectionChanged
        Try
            If Not dtgDirecServ.CurrentRow Is Nothing Then
                txtCodigo.Text = dtgDirecServ.CurrentRow.Cells("CDIRSE").Value.ToString().Trim()
                txtDireccion.Text = dtgDirecServ.CurrentRow.Cells("DEDISE").Value.ToString().Trim()
                txtReferencia.Text = dtgDirecServ.CurrentRow.Cells("DREFSE").Value.ToString().Trim()
                cboUbigeo.Valor = dtgDirecServ.CurrentRow.Cells("UBIGEO").Value.ToString().Trim()
                Listar_DatosClienteXDireccion()
                p_estadoActual = estado.neutro
                EstadoControl(p_estadoActual)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            p_estadoActual = estado.neutro
            EstadoControl(p_estadoActual)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
