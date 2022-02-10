Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario
Public Class frmDuracionDias

    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean = False

    Private Sub frmDuracionDias_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            CargarCombos()
            EstadoBotones(Estado.Neutral)
            Me.gwdDatos.AutoGenerateColumns = False
            Me.txtCliente.pRequerido = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub CargarCombos()



        Carga_MedioTransporte()
        Me.gwdDatos.AutoGenerateColumns = False
        Cargar_Compania()

        Me.Limpiar_Controles()

        Dim objDt As List(Of LocalidadRuta)
        Dim obj_Logica_Localidad As New Localidad_BLL
        objDt = obj_Logica_Localidad.Listar_Localidades(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarOrigen.DataSource = objDt
        Me.cboLugarOrigen.ListColumnas = oListColum
        Me.cboLugarOrigen.Cargas()
        Me.cboLugarOrigen.DispleyMember = "TCMLCL"
        Me.cboLugarOrigen.ValueMember = "CLCLD"

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"
    End Sub
    

    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        
    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboMedioTransporte.DataSource = objTabla.Copy
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"

    End Sub

    Enum Estado
        Neutral
        Editar
        Nuevo
    End Enum
    Sub EstadoBotones(ByVal oEstado As Estado)
        Select Case oEstado
            Case Estado.Neutral
                btnGuardar.Visible = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True
                btnNuevo.Enabled = True
                btnEditar.Visible = True

                txtCliente.Enabled = False
                cboMedioTransporte.Enabled = False
                txtCantidadDias.Enabled = False
                cboLugarDestino.Enabled = False
                cboLugarOrigen.Enabled = False

                gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL


            Case Estado.Editar
                btnGuardar.Visible = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnNuevo.Enabled = False
                btnEditar.Visible = False


                txtCliente.Enabled = False
                cboMedioTransporte.Enabled = False
                txtCantidadDias.Enabled = True
                cboLugarDestino.Enabled = False
                cboLugarOrigen.Enabled = False

            Case Estado.Nuevo
                btnGuardar.Visible = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnNuevo.Enabled = False
                btnEditar.Visible = False


                txtCliente.Enabled = True
                cboMedioTransporte.Enabled = True
                txtCantidadDias.Enabled = True
                cboLugarDestino.Enabled = True
                cboLugarOrigen.Enabled = True
        End Select



    

    End Sub



    Private Sub Listar()
        If txtClienteFiltro.pCodigo = 0 Then
            MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Limpiar_Controles()

        Dim objLogica As New DuracionDias_BLL
        Dim objEntidad As New DuracionDias
        objEntidad.CCLNT = Me.txtClienteFiltro.pCodigo
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Me.gwdDatos.DataSource = objLogica.Listar(objEntidad)
    End Sub


    Private Sub Limpiar_Controles()
        Me.txtCliente.pClear()
        'Me.cboMedioTransporte.SelectedIndex = 0
        Me.txtCantidadDias.Text = String.Empty
        Me.cboLugarDestino.Limpiar()
        Me.cboLugarOrigen.Limpiar()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim objEntidad As New DuracionDias
            Dim lstr_validacion As String = ""
            Dim objLogica As New DuracionDias_BLL
            Dim msgerror As String = ""

            If txtCliente.pCodigo = 0 Then
                lstr_validacion += "* Cliente" & Chr(13)
            End If

            If Me.txtCantidadDias.Text.Trim = String.Empty Then
                lstr_validacion += "* cantidad de días" & Chr(13)
            Else
                If Not IsNumeric(Me.txtCantidadDias.Text.Trim) Then
                    lstr_validacion += "* cantidad de días numérico" & Chr(13)
                End If
            End If

            If cboLugarOrigen.Resultado Is Nothing Then
                lstr_validacion += "* lugar origen" & Chr(13)
            End If

            If cboLugarDestino.Resultado Is Nothing Then
                lstr_validacion += "* lugar destino " & Chr(13)
            End If

            If lstr_validacion <> "" Then
                HelpClass.MsgBox("Debe ingresar :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
                Exit Sub
            End If

            With objEntidad
                .CCMPN = cmbCompania.CCMPN_CodigoCompania
                .CCLNT = txtCliente.pCodigo
                .NCRRDT = Me.txtCorrelativo.Text
                .CLCLOR = CType(Me.cboLugarOrigen.Resultado, LocalidadRuta).CLCLD
                .CLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
                .CMEDTR = Me.cboMedioTransporte.SelectedValue
                .QDSEST = Me.txtCantidadDias.Text
               
                .CUSCRT = MainModule.USUARIO
                .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

            End With

            Dim exito As Boolean = False
            Select Case gEnum_Mantenimiento
                Case MANTENIMIENTO.NUEVO
                    msgerror = objLogica.Nuevo(objEntidad)
                    If msgerror.Length > 0 Then
                        MessageBox.Show(msgerror, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        exito = True
                        MessageBox.Show("Se registró correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case MANTENIMIENTO.EDITAR
                    objLogica.Editar(objEntidad)
                    MessageBox.Show("Se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    exito = True
            End Select
           
            If exito = True Then
                EstadoBotones(Estado.Neutral)
                Limpiar_Controles()
                Listar()
              
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            EstadoBotones(Estado.Nuevo)
            txtCantidadDias.Text = ""
            txtCorrelativo.Text = "0"
            Limpiar_Controles()
            txtCliente.pCargar(txtClienteFiltro.pCodigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        gwdDatos_SelectionChanged(Nothing, Nothing)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If HelpClass.RspMsgBox("Desea eliminar el registro seleccionado?") = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If


            Dim objEntidad As New DuracionDias
            Dim lstr_validacion As String = ""
            Dim objLogica As New DuracionDias_BLL

            With objEntidad
                .CCMPN = cmbCompania.CCMPN_CodigoCompania
                .CCLNT = txtCliente.pCodigo
                .NCRRDT = Me.txtCorrelativo.Text
                .CUSCRT = MainModule.USUARIO
                .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

            End With
            objLogica.Eliminar(objEntidad)
            MessageBox.Show("El registro fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Listar()
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

   

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Try
            If gwdDatos.CurrentRow IsNot Nothing Then
                gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                EstadoBotones(Estado.Editar)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
     

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Días Estimado Llegada"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Días Estimado Llegada"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Reporte Días Estimado Llegada"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy


            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

          
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            EstadoBotones(Estado.Neutral)
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim objEntidad As New DuracionDias
            Dim objLogica As New DuracionDias_BLL

            With objEntidad
                txtCliente.pCargar(Me.gwdDatos.Item("CCLNT", gwdDatos.CurrentRow.Index).Value)
                Me.txtCorrelativo.Text = Me.gwdDatos.Item("NCRRDT", gwdDatos.CurrentRow.Index).Value
                Me.cboLugarOrigen.Valor = Me.gwdDatos.Item("CLCLOR", gwdDatos.CurrentRow.Index).Value
                Me.cboLugarDestino.Valor = Me.gwdDatos.Item("CLCLDS", gwdDatos.CurrentRow.Index).Value
                Me.cboMedioTransporte.SelectedValue = Me.gwdDatos.Item("CMEDTR", gwdDatos.CurrentRow.Index).Value
                Me.txtCantidadDias.Text = Val(Me.gwdDatos.Item("QDSEST", gwdDatos.CurrentRow.Index).Value)
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class