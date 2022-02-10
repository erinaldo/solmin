Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmLiquidacionChofer

#Region "Atributos"
  Private mobj_Entidad As New LiquidacionGastos
#End Region

#Region "Properties"
 
  Public Property obj_Entidad() As LiquidacionGastos
    Get
      Return mobj_Entidad
    End Get
    Set(ByVal value As LiquidacionGastos)
      mobj_Entidad = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnCerrarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarLiquidacion.Click
        Try
            Dim obj_Logica As New LiquidacionGastos_BLL
            Dim obj_Entidad As New LiquidacionGastos
            Dim retorno As Decimal = 0
            obj_Entidad.NLQGST = CType(Me.txtNroLiquidacion.Text.Trim, Double)
            obj_Entidad.USRCRR = MainModule.USUARIO
            obj_Entidad.FCHCRR = HelpClass.TodayNumeric
            obj_Entidad.HRACRR = HelpClass.NowNumeric
            obj_Entidad.CULUSA = MainModule.USUARIO
            obj_Entidad.FULTAC = HelpClass.TodayNumeric
            obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            'obj_Entidad.NLQGST = obj_Logica.Cerrar_Lquidacion(obj_Entidad).NLQGST
            retorno = obj_Logica.Cerrar_Lquidacion(obj_Entidad)
            'If obj_Entidad.NLQGST = 0 Then
            '  HelpClass.ErrorMsgBox()
            'ElseIf obj_Entidad.NLQGST = -1 Then
            '  HelpClass.MsgBox("No se puede Cerrar, no tiene Gastos Asignados", MessageBoxIcon.Information)
            'Else
            '  HelpClass.MsgBox("Liquidación Cerrada", MessageBoxIcon.Information)
            'End If
            If retorno = 0 Then
                HelpClass.ErrorMsgBox()
            ElseIf retorno = -1 Then
                HelpClass.MsgBox("No se puede Cerrar, no tiene Gastos Asignados", MessageBoxIcon.Information)
            Else
                HelpClass.MsgBox("Liquidación Cerrada", MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub frmLiquidacionChofer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.txtNroLiquidacion.Text = Me.mobj_Entidad.NLQGST
            Me.txtTracto.Text = Me.mobj_Entidad.NPLCUN
            Me.txtAcoplado.Text = Me.mobj_Entidad.NPLCAC
            Me.txtConductor.Text = Me.mobj_Entidad.CBRCNT + " -> " + Me.mobj_Entidad.CBRCND
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

  End Sub
#End Region

#Region "Metodos y Funciones"

#End Region

End Class
