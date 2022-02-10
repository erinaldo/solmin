Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO

Public Class frmPreFactura

#Region "Atributos"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    Private dgwPreFacturacionChk As Boolean = False
    Private dgwLiquidacionChk As Boolean = False
    Private cOrgVenta As String = ""
    'Private dOrgVenta As String = ""
#End Region

#Region "Eventos"

    Private Sub frmPreLiquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
          

            Me.Cargar_Compania()
            Me.Alinear_Columnas_Grilla()
            Me.Validar_Acceso_Opciones_Usuario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

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
            Dim objEntidad As New Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objfrmListaPreFactura As New frmListaPreFactura
            Me.dgwPreFacturacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwPreFacturacion) = False Then
                HelpClass.MsgBox("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim VLR_CANT As Decimal = 0
            Dim CompSoles As Boolean = False
            Dim CompDolar As Boolean = False
            Dim msgComparacion As String = ""
            For Each row As DataGridViewRow In dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New Factura_Transporte
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

                .CPLNDV = 0
                .CCMPN_1 = Me.cboCompania.Text
                .CDVSN_1 = Me.cboDivision.Text

                .CPLNDV_1 = "TODOS"
                .ListFactura_Transporte = objGenericCollection
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.Listar_PreFactura()

                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

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
                'Try
                Dim objfrmOperacion As New frmOperacionesXPreFactura
                With objfrmOperacion
                    .PNCCLNT = Me.gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value
                    .PNNDCPRF = Me.dgwPreFacturacion.CurrentRow.Cells("NDCPRF").Value()
                    .PSCCMPN = Me.cboCompania.SelectedValue
                    .PSCDVSN = Me.cboDivision.SelectedValue
                End With
                objfrmOperacion.ShowDialog()
              
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgwPreFacturacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwPreFacturacion.ColumnHeaderMouseClick ', dgwPreFacturacion.ColumnHeaderMouseDoubleClick
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
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objEntidad As New Factura_Transporte
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of Factura_Transporte)

            Me.dgwPreFacturacion.EndEdit()
            For Each row As DataGridViewRow In Me.dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New Factura_Transporte
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    objEntidad.CPLNCL = 0
                    objEntidad.FDCPRF = HelpClass.CFecha_de_10_a_8(row.Cells("FDCPRF").Value.ToString)
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            obj_Logica.Anular_Pre_Factura(objGenericCollection)
            HelpClass.MsgBox("Se anuló la Pre - Factura Satisfactoriamente")
            Me.Listar_PreFactura()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#Region "Métodos"

    Private Sub Cargar_Compania()

        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        bolBuscar = True
        cboCompania.SelectedIndex = 0
       
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        'cboCompania_SelectedIndexChanged(Nothing, Nothing)
        cboCompania_SelectionChangeCommitted(Nothing, Nothing)
      
    End Sub

    Private Sub Cargar_Division()
       
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
        Dim obj_Logica As New PreLiquidacion_BLL
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
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCCLNT", gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objetoParametro.Add("PNCCLNFC", gwdDatos.Item("CCLNFC", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objetoParametro.Add("PSCCMPN", cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", cboDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", 0)
        
        dgwPreFacturacion.DataSource = obj_Logica.Listar_PreFactura(objetoParametro) 'dt
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral
        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        'If objEntidad.STSADI = "" Then
        '    Me.btnPreLiquidacion.Visible = False
        '    Me.Separator1.Visible = False
        'End If
        'If objEntidad.STSELI = "" Then
        '    Me.btnAnularPreFactura.Visible = False
        'End If
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
            'chk
           
            If Sender.Item("chk", lint_Contador).Value = "S" Then
                If intIndice = 0 Then
                    cOrgVenta = Sender.Item("CRGVTA_D", lint_Contador).Value
                    'dOrgVenta = Sender.Item("TCRVTA_D", lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Sender.Item("CRGVTA_D", lint_Contador).Value.ToString.Trim <> cOrgVenta.Trim Then
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

            Cargar_Division()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
           
        End Try
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectionChangeCommitted
        LimpiarDatos()
    End Sub
    Private Sub LimpiarDatos()

        gwdDatos.DataSource = Nothing
        dgwPreFacturacion.DataSource = Nothing
    End Sub

    

   
End Class