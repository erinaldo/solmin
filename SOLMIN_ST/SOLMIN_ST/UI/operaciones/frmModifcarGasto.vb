Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Public Class frmModifcarGasto


    Private _pLiquidacionGastos As New LiquidacionGastos
    Public Property pLiquidacionGastos() As LiquidacionGastos
        Get
            Return _pLiquidacionGastos
        End Get
        Set(ByVal value As LiquidacionGastos)
            _pLiquidacionGastos = value
        End Set
    End Property


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim obj_Logica As New LiquidacionGastos_BLL

            Dim oLiquidacionGastos As New LiquidacionGastos
            If CheckBox1.Checked = True Then
                oLiquidacionGastos.FECINI = DateTimePicker1.Value.ToString("yyyyMMdd")
            Else
                oLiquidacionGastos.FECINI = 0
            End If
            If CheckBox2.Checked = True Then
                oLiquidacionGastos.FECFIN = DateTimePicker2.Value.ToString("yyyyMMdd")
            Else
                oLiquidacionGastos.FECFIN = 0
            End If
            If oLiquidacionGastos.FECFIN > 0 AndAlso oLiquidacionGastos.FECINI > 0 Then
                If oLiquidacionGastos.FECFIN < oLiquidacionGastos.FECINI Then
                    MessageBox.Show("Fecha fin no puede ser menor que fecha inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            oLiquidacionGastos.NLQGST = _pLiquidacionGastos.NLQGST
            oLiquidacionGastos.NOPRCN = _pLiquidacionGastos.NOPRCN
            oLiquidacionGastos.NCRRRT = _pLiquidacionGastos.NCRRRT
            oLiquidacionGastos.CGSTOS = _pLiquidacionGastos.CGSTOS
            oLiquidacionGastos.IGSTOS_COD = _pLiquidacionGastos.IGSTOS_COD
            oLiquidacionGastos.IGSTOS = Val(TextBox1.Text)
            oLiquidacionGastos.TOBDCT = KryptonTextBox4.Text.Trim



            oLiquidacionGastos.CULUSA = MainModule.USUARIO
            oLiquidacionGastos.FULTAC = HelpClass.TodayNumeric
            oLiquidacionGastos.HULTAC = HelpClass.NowNumeric
            oLiquidacionGastos.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            oLiquidacionGastos.NCRRGT = _pLiquidacionGastos.NCRRGT 'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)
            obj_Logica.Actualizar_Gasto_Ruta_Operacion_X_Gasto(oLiquidacionGastos)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmModifcarGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ToolStripLabel1.Text = "LIQ: " & _pLiquidacionGastos.NLQGST & " OP:" & _pLiquidacionGastos.NOPRCN
            KryptonTextBox1.Text = _pLiquidacionGastos.TIPO & " - " & _pLiquidacionGastos.GASTO_DESC
            KryptonTextBox1.Enabled = False
            KryptonTextBox2.Text = _pLiquidacionGastos.MONEDA
            KryptonTextBox2.Enabled = False
            TextBox1.Text = Val(_pLiquidacionGastos.IGSTOS)
            KryptonTextBox4.Text = _pLiquidacionGastos.TOBDCT
            If _pLiquidacionGastos.FECINI_S.Length > 0 Then
                DateTimePicker1.Value = Date.Parse(_pLiquidacionGastos.FECINI_S)
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If

            If _pLiquidacionGastos.FECFIN_S.Length > 0 Then
                DateTimePicker2.Value = Date.Parse(pLiquidacionGastos.FECFIN_S)
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            CheckBox1_CheckedChanged(CheckBox1, Nothing)
            CheckBox2_CheckedChanged(CheckBox2, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        DateTimePicker1.Enabled = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        DateTimePicker2.Enabled = CheckBox2.Checked
    End Sub
End Class
