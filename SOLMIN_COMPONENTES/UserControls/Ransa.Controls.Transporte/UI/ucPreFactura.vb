
Imports System.Windows.Forms

Public Class ucPreFactura


    Private _pUsuario As String = ""

    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pSystem_Prefix As String = ""
    Public Property pSystem_Prefix() As String
        Get
            Return _pSystem_Prefix
        End Get
        Set(ByVal value As String)
            _pSystem_Prefix = value
        End Set
    End Property

    Private _pNameFormulario As String = ""
    Public Property pNameFormulario() As String
        Get
            Return _pNameFormulario
        End Get
        Set(ByVal value As String)
            _pNameFormulario = value
        End Set
    End Property

    '

#Region "Atributos"

    Enum MANTENIMIENTO
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New Compania_BLL
    Private objPlanta As New Planta_BLL
    Private objDivision As New Division_BLL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    Private dgwPreFacturacionChk As Boolean = False
    Private dgwLiquidacionChk As Boolean = False
    Private cOrgVenta As String = ""
    Private dOrgVenta As String = ""
#End Region

#Region "Eventos"

    Sub pInicializar()

        Me.Cargar_Compania()
        Me.Alinear_Columnas_Grilla()
        Me.Validar_Acceso_Opciones_Usuario()

    End Sub

    'Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    '    Me.Close()
    'End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Me.Listar_PreFactura()
            Validar_Acceso_Tab()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If (Me.txtClienteFiltro.pCodigo = 0) Then
                MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Listar_PreLiquidacion()
            Me.gwdDatos.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreLiquidacion.Click
        Try
            If dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim objEntidad As New Operaciones.Factura_Transporte
            Dim objGenericCollection As New List(Of Operaciones.Factura_Transporte)
            Dim objfrmListaPreFactura As New frmListaPreFactura
            Me.dgwPreFacturacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwPreFacturacion) = False Then
                'HelpClassST.MsgBox("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", MessageBoxIcon.Information)
                MessageBox.Show("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            For Each row As DataGridViewRow In dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New Operaciones.Factura_Transporte
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.FDCPRF_S = row.Cells("FDCPRF").Value
                    objEntidad.IMPOCOS = row.Cells("IMPOCOS_D").Value
                    objEntidad.IMPOCOD = row.Cells("IMPOCOD_D").Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            With objfrmListaPreFactura
                .CCLNT = CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer)
                .CCMPN = Me.cboCompania.SelectedValue
                .CDVSN = Me.cboDivision.SelectedValue
                '.CPLNDV = Me.cboPlanta.SelectedValue
                .CPLNDV = 0
                .CCMPN_1 = Me.cboCompania.Text
                .CDVSN_1 = Me.cboDivision.Text
                '.CPLNDV_1 = Me.cboPlanta.Text
                .CPLNDV_1 = "TODOS"
                .pUsuario = _pUsuario
                .ListFactura_Transporte = objGenericCollection
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.Listar_PreFactura()
                    'Me.Listar_PreFactura(CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer))
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
    '    Try
    '        If bolBuscar Then
    '            Cargar_Division()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub InicializarFormulario()
        Me.gwdDatos.DataSource = Nothing
        Me.dgwPreFacturacion.DataSource = Nothing
        Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
    End Sub

    Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (bolBuscar = True) Then
                InicializarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabListaLiquidacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabListaLiquidacion.SelectedIndexChanged
        Validar_Acceso_Tab()
    End Sub

    Private Sub dgwPreFacturacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPreFacturacion.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            dgwPreFacturacion.EndEdit()
            If dgwPreFacturacion.Columns(e.ColumnIndex).Name = "chk" Then

                If Me.dgwPreFacturacion.Item(e.ColumnIndex, e.RowIndex).Value = "" Or Me.dgwPreFacturacion.Item(e.ColumnIndex, e.RowIndex).Value = "N" Then
                    Me.dgwPreFacturacion.Item(e.ColumnIndex, e.RowIndex).Value = "S"

                Else
                    Me.dgwPreFacturacion.Item(e.ColumnIndex, e.RowIndex).Value = "N"

                End If
                'Me.dgwPreFacturacion.Item(e.ColumnIndex, e.RowIndex).Value = IIf(dgwPreFacturacionChk, "N", "S")
                'dgwPreFacturacionChk = IIf(dgwPreFacturacionChk, False, True)
            ElseIf dgwPreFacturacion.Columns(e.ColumnIndex).Name = "NOPRCN" Then
                Try
                    Dim objfrmOperacion As New frmOperacionesXPreFactura
                    With objfrmOperacion
                        .PNCCLNT = Me.gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value
                        .PNNDCPRF = Me.dgwPreFacturacion.CurrentRow.Cells("NDCPRF").Value()
                        .PSCCMPN = Me.cboCompania.SelectedValue
                        .PSCDVSN = Me.cboDivision.SelectedValue
                    End With
                    objfrmOperacion.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgwPreFacturacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)  ', dgwPreFacturacion.ColumnHeaderMouseDoubleClick
        Try

            If Me.dgwPreFacturacion.RowCount = 0 Then Exit Sub
            dgwPreFacturacion.EndEdit()

            If dgwPreFacturacion.Columns(e.ColumnIndex).Name = "chk" Then
                For row As Integer = 0 To dgwPreFacturacion.Rows.Count - 1
                    dgwPreFacturacion.Item("chk", row).Value = IIf(dgwPreFacturacionChk, "N", "S")
                Next
                dgwPreFacturacionChk = IIf(dgwPreFacturacionChk, False, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAnularPreFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularPreFactura.Click
        Try
            If Me.dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim obj_Logica As New Operaciones.PreLiquidacion_BLL
            Dim objEntidad As New Operaciones.Factura_Transporte
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of Operaciones.Factura_Transporte)
            Dim lintResultado As Integer = 0
            Me.dgwPreFacturacion.EndEdit()
            For Each row As DataGridViewRow In Me.dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New Operaciones.Factura_Transporte
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    objEntidad.CPLNCL = 0
                    objEntidad.FDCPRF = HelpClassST.CFecha_de_10_a_8(row.Cells("FDCPRF").Value.ToString)
                    objEntidad.CULUSA = _pUsuario
                    objEntidad.FULTAC = HelpClassST.TodayNumeric
                    objEntidad.HULTAC = HelpClassST.NowNumeric
                    objEntidad.NTRMNL = HelpClassST.NombreMaquina
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            lintResultado = obj_Logica.Anular_Pre_Factura(objGenericCollection)
            If lintResultado = 1 Then
                'HelpClassST.MsgBox("Se anuló la Pre - Factura Satisfactoriamente")
                MessageBox.Show("Se anuló la Pre - Factura Satisfactoriamente", "Aviso", MessageBoxButtons.OK)
                'Me.Listar_PreFactura(CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer))
                Me.Listar_PreFactura()
            Else
                'HelpClassST.MsgBox("Ocurrió un Error, no se anuló la Pre - Factura", MessageBoxIcon.Error)
                MessageBox.Show("Ocurrió un Error, no se anuló la Pre - Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#Region "Métodos"

    Private Sub Cargar_Compania()
        Try
            objCompaniaBLL.Crea_Lista()
            bolBuscar = False
            Me.cboCompania.DataSource = objCompaniaBLL.Lista
            Me.cboCompania.ValueMember = "CCMPN"
            Me.cboCompania.DisplayMember = "TCMPCM"
            bolBuscar = True
            cboCompania.SelectedIndex = 0
            'cboCompania.SelectedValue = "EZ"
            'If cboCompania.SelectedIndex = -1 Then
            '    cboCompania.SelectedIndex = 0
            'End If
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            'cboCompania_SelectedIndexChanged(Nothing, Nothing)
            cboCompania_SelectionChangeCommitted(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Division()
        Try
            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objDivision.Crea_Lista()
                Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
                Me.cboDivision.ValueMember = "CDVSN"
                bolBuscar = True
                Me.cboDivision.DisplayMember = "TCMPDV"
                Me.cboDivision.SelectedValue = "T"
                If Me.cboDivision.SelectedIndex = -1 Then
                    Me.cboDivision.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        Me.dgwPreFacturacion.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_Contador As Integer = 0 To Me.dgwPreFacturacion.ColumnCount - 1
            Me.dgwPreFacturacion.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Listar_PreLiquidacion()
        Dim obj_Logica As New Operaciones.PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCCLNT", Me.txtClienteFiltro.pCodigo)
        objetoParametro.Add("PNFECINI", 0)
        objetoParametro.Add("PNFECFIN", 0)
        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", 0)
        Me.gwdDatos.DataSource = Nothing
        Me.dgwPreFacturacion.DataSource = Nothing
        Me.gwdDatos.DataSource = obj_Logica.Listar_PreFactura_Factura(objetoParametro)
        Validar_Acceso_Tab()

    End Sub

    Private Sub Listar_PreFactura()
        Dim obj_Logica As New Operaciones.PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCCLNT", Me.gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objetoParametro.Add("PNCCLNFC", Me.gwdDatos.Item("CCLNFC", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", 0)
        objetoParametro.Add("PNFECINI", 0)
        objetoParametro.Add("PNFECFIN", 0)
        Me.dgwPreFacturacion.DataSource = obj_Logica.Listar_PreFactura(objetoParametro) 'dt
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New mantenimientos.ClaseGeneral
        objParametro.Add("MMCAPL", _pSystem_Prefix) 'MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", _pUsuario)
        objParametro.Add("MMNPVB", _pNameFormulario)
        'objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        If objEntidad.STSADI = "" Then
            Me.btnPreLiquidacion.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnAnularPreFactura.Visible = False
        End If
        Validar_Acceso_Tab()
    End Sub

    Private Sub Validar_Acceso_Tab()
        Me.btnPreLiquidacion.Enabled = Not Convert.ToBoolean(Me.TabListaLiquidacion.SelectedIndex)
        Me.btnAnularPreFactura.Enabled = Not Convert.ToBoolean(Me.TabListaLiquidacion.SelectedIndex)
    End Sub

    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
        For lint_Contador As Integer = 0 To Sender.RowCount - 1
            If Sender.Item(0, lint_Contador).Value = "S" Then
                If intIndice = 0 Then
                    cOrgVenta = Sender.Item(6, lint_Contador).Value
                    dOrgVenta = Sender.Item(5, lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Sender.Item(6, lint_Contador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If
        Next
        Return lstr_Estado
    End Function

#End Region

    Private Sub cboCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectionChangeCommitted
        Try
            If bolBuscar Then
                Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectionChangeCommitted
        LimpiarDatos()
    End Sub
    Private Sub LimpiarDatos()
        txtClienteFiltro.pClear()
        gwdDatos.DataSource = Nothing
        dgwPreFacturacion.DataSource = Nothing
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick

    End Sub
End Class
