Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Public Class frmActLiGastos
    Private _pNLQGST As Decimal = 0
    Public Property pNLQGST() As Decimal
        Get
            Return _pNLQGST
        End Get
        Set(ByVal value As Decimal)
            _pNLQGST = value
        End Set
    End Property
    Private _pConductor As String = ""
    Public Property pConductor() As String
        Get
            Return _pConductor
        End Get
        Set(ByVal value As String)
            _pConductor = value
        End Set
    End Property
    Private _pFECIDE As String = ""
    Public Property pFECIDE() As String
        Get
            Return _pFECIDE
        End Get
        Set(ByVal value As String)
            _pFECIDE = value
        End Set
    End Property
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim obj_Entidad As LiquidacionGastos
            Dim obj_Logica As New LiquidacionGastos_BLL
            obj_Entidad = New LiquidacionGastos
            obj_Entidad.NLQGST = NLiquidacionKryptonTextBox.Text
            If FecideCheckBox.Checked = True Then
                obj_Entidad.FECIDE = FecideDateTimePicker.Value.ToString("yyyyMMdd")
            Else
                obj_Entidad.FECIDE = 0
            End If
            obj_Entidad.CULUSA = MainModule.USUARIO
            obj_Entidad.FULTAC = HelpClass.TodayNumeric
            obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            obj_Logica.Registrar_FechaRecepcion_Gasto_Ruta_Operacion(obj_Entidad)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmActLiGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            NLiquidacionKryptonTextBox.Text = _pNLQGST
            KryptonTextBox3.Text = _pConductor
            If _pFECIDE.Length > 0 Then
                FecideCheckBox.Checked = True
                FecideDateTimePicker.Value = Date.Parse(_pFECIDE)
            Else
                FecideCheckBox.Checked = False
            End If
            FecideCheckBox_CheckedChanged(FecideCheckBox, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FecideCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecideCheckBox.CheckedChanged
        FecideDateTimePicker.Enabled = FecideCheckBox.Checked
    End Sub
End Class
