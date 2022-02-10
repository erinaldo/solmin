Imports SOLMIN_ST.ENTIDADES.mantenimientos
'Imports Ransa.TypeDef.Unidad
'Imports Ransa.TypeDef.Moneda


Public Class frmLiquidacionFlete_DlgLiquServicio
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInfLiquServ As TD_Obj_GRemLiquServCargadasGTranspLiq = New TD_Obj_GRemLiquServCargadasGTranspLiq
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strCompania As String = ""
    Public pbeAutorizacionLiq As New beAutorizacionLiquidacion
    Public pFlagTarifaOS As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pInformacionServicio() As TD_Obj_GRemLiquServCargadasGTranspLiq
        Get
            Return oInfLiquServ
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "
    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If cboMoneda_2_tmp.SelectedValue Is Nothing Then strMensajeError &= "* Seleccione Moneda" & vbNewLine
        If cboUnidad.Resultado Is Nothing Then strMensajeError &= "* Seleccione Unidad" & vbNewLine

        If chkLiquTransporte.Checked = True Then
            If txtTarifa.Text.Trim <> "" Then
                If IsNumeric(txtTarifa.Text.Trim) Then
                    If txtTarifa.Text.Trim = 0 Then
                        strMensajeError &= "* Ingrese Tarifa" & vbNewLine
                    End If
                ElseIf Not IsNumeric(txtTarifa.Text.Trim) Then
                    txtTarifa.Text = "0.0000"
                    strMensajeError &= "* Ingrese Tarifa" & vbNewLine
                End If
            Else
                strMensajeError &= "* Ingrese Tarifa" & vbNewLine
            End If

            If txtImporte.Text.Trim <> "" Then
                If IsNumeric(txtImporte.Text.Trim) Then
                    If txtImporte.Text.Trim = 0 Then
                        strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                    End If
                ElseIf Not IsNumeric(txtImporte.Text.Trim) Then
                    txtImporte.Text = "0.000"
                    strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                Else
                    strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                End If

            End If
        End If


        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then Exit Sub
            If cboUnidad.Resultado Is Nothing Then Exit Sub
            If cboMoneda_2_tmp.SelectedValue Is Nothing Then Exit Sub

            With oInfLiquServ
                .pCMNLQT_Moneda = cboMoneda_2_tmp.SelectedValue
                .pILQDTR_ImporteLiquidacionTransp = txtTarifa.Text
                .pQCNDLG_CantidadServicioLiquidacion = txtImporte.Text
                '.pCUNDTR_Unidad = CType(cboUnidad.Resultado, TD_Inf_Unidad_L02).pCUNDMD_Unidad
                .pCUNDTR_Unidad = CType(cboUnidad.Resultado, Ransa.Controls.Unidad.TD_Inf_Unidad_L02).pCUNDMD_Unidad
                If chkLiquTransporte.CheckState = CheckState.Checked Then
                    .pSLQDTR_StatusLiquTransporte = "X"
                Else
                    .pSLQDTR_StatusLiquTransporte = ""
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        oInfLiquServ.pClear()
        Me.Close()
    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal oTemp As TD_Obj_GRemLiquServCargadasGTranspLiq)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oInfLiquServ = oTemp
        strCompania = oTemp.pCCMPN_Compania
    End Sub

    Private Sub frmLiquidacionFlete_DlgLiquServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With oInfLiquServ
            lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
            lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
            lblServicio.Text &= "   " & .pCSRVC_Servicio & " - " & .pTCMTRF_DetalleServicio
            lblCorrelativoServ.Text &= "   " & .pNCRRGU_CorrServ
            txtTarifa.Text = Val(.pILQDTR_ImporteLiquidacionTransp)
            txtImporte.Text = Val(.pQCNDLG_CantidadServicioLiquidacion)
            If .pSLQDTR_StatusLiquTransporte = "" Then
                chkLiquTransporte.CheckState = CheckState.Unchecked
            Else
                chkLiquTransporte.CheckState = CheckState.Checked
            End If

            ' Moneda
            Dim obr2 As New NEGOCIO.ServicioMercaderia_BLL
            'cboMoneda_2_tmp.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Moneda)(obr2.fdtListar_Moneda_L01())
            cboMoneda_2_tmp.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Moneda.TD_Moneda)(obr2.fdtListar_Moneda_L01())
            cboMoneda_2_tmp.ValueMember = "pCMNDA1_Codigo"
            cboMoneda_2_tmp.DisplayMember = "pTMNDA_Detalle"
            'cboMoneda_2.SelectedValue = .pCMNLQT_Moneda.ToString

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            If .pCMNLQT_Moneda.ToString = 0 Or .pCMNLQT_Moneda.ToString = "" Then
                cboMoneda_2_tmp.SelectedValue = .pMONEDA_OS.ToString
            Else
                cboMoneda_2_tmp.SelectedValue = .pCMNLQT_Moneda.ToString
            End If

            cboMoneda_2_tmp.Enabled = False

            'If .pBLQ_MONEDA = "X" Then
            '    cboMoneda_2_tmp.Enabled = False
            'Else
            '    cboMoneda_2_tmp.Enabled = True
            'End If
            '----- Fin -----

            'Unidad
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "pCUNDMD_Unidad"
            oColumnas.DataPropertyName = "pCUNDMD_Unidad"
            oColumnas.HeaderText = "Abreviatura"
            oListColum.Add(1, oColumnas)
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "pTABRUN_Descripcion"
            oColumnas.DataPropertyName = "pTABRUN_Descripcion"
            oColumnas.HeaderText = "Unidad"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(2, oColumnas)
            cboUnidad.DataSource = Nothing

            Dim ref As String = ""
            'Dim obr3 As New Ransa.DAO.Unidad.cUnidad
            Dim obr3 As New Ransa.Controls.Unidad.cUnidad
            'cboUnidad.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
            cboUnidad.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
            Me.cboUnidad.ListColumnas = oListColum
            Me.cboUnidad.Cargas()
            Me.cboUnidad.Limpiar()
            Me.cboUnidad.ValueMember = "pCUNDMD_Unidad"
            Me.cboUnidad.DispleyMember = "pTABRUN_Descripcion"
            Me.cboUnidad.Valor = .pCUNDTR_Unidad.ToString.Trim

            lblmensaje.Text = ""
            If pFlagTarifaOS = "X" Then
                If pbeAutorizacionLiq.ModifTarifaOS = "X" Then
                    txtTarifa.Enabled = True
                Else
                    txtTarifa.Enabled = False
                    lblmensaje.Text = "[No autorizado a modificar tarifa]"
                End If

            End If

            Me.btnAceptar.Select()

        End With
    End Sub
#End Region

    Private Sub txtTarifa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarifa.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtTarifa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTarifa.Leave
        If txtTarifa.Text.EndsWith(".") Then
            txtTarifa.Text = txtImporte.Text.Replace(".", "")
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        CType(sender, TextBox).Tag = "8-3"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtImporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.Leave
        If txtImporte.Text.EndsWith(".") Then
            txtImporte.Text = txtImporte.Text.Replace(".", "")
        End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class