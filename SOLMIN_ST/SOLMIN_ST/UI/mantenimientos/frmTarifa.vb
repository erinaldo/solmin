Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmTarifa

#Region "Variable"
  Private _Cantidad As Integer
  Private _obeGrifo As New Grifo
#End Region

#Region "Properties"
  Public WriteOnly Property Cantidad() As Integer
    Set(ByVal value As Integer)
      _Cantidad = value
    End Set
  End Property

  Public Property obeGrifo() As Grifo
    Get
      Return _obeGrifo
    End Get
    Set(ByVal value As Grifo)
      _obeGrifo = value
    End Set

  End Property
#End Region

#Region "Eventos"
  Private Sub frmTarifa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CargarTipoCombustible()
    Me.txtNroCorrela.Text = _Cantidad + 1
    Me.txtGrifo.Text = _obeGrifo.TGRFO
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub IsNumeric_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioSoles.KeyPress, txtPrecioDolares.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
      e.Handled = True
    Else
      If 1 <= InStr(sender.Text, ".", CompareMethod.Binary) Then
        If e.KeyChar = "." Then
          e.Handled = True
        End If
      End If
    End If
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If Me.Validar = False Then Exit Sub
    Me.Guardar()
  End Sub
#End Region

#Region "Métodos y Funciones"
    Private Sub Guardar()
        Dim obeGrifo As New Grifo
        Dim obrGrifo As New Grifo_BLL
        With obeGrifo
            .CGRFO = _obeGrifo.CGRFO
            .CTPCMB = ctbTipoCombustible.Codigo
            .FCMBUS = HelpClass.TodayNumeric
            .IPRCMS = txtPrecioSoles.Text
            .IPRCMD = IIf(txtPrecioDolares.Text.Trim.Equals(""), 0, txtPrecioDolares.Text)
            .FCMBUS = HelpClass.TodayNumeric
            .FCHCRT = HelpClass.TodayNumeric
            .HRACRT = HelpClass.NowNumeric
            .USRCRT = MainModule.USUARIO
        End With
        obrGrifo.Registrar_Tarifa_Grifo(obeGrifo)
        Me.DialogResult = Windows.Forms.DialogResult.OK

        'If obrGrifo.Registrar_Tarifa_Grifo(obeGrifo).CGRFO = 0 Then
        '    HelpClass.ErrorMsgBox()
        'Else
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If

    End Sub

  Private Sub CargarTipoCombustible()
    Dim obrCombustible As New TipoCombustible_BLL
    With ctbTipoCombustible
      .DataSource = HelpClass.GetDataSetNative(obrCombustible.Listar_TipoCombustible)
      .KeyField = "CTPCMB"
      .ValueField = "TDSCMB"
      .DataBind()
    End With
  End Sub

  Private Function Validar() As Double
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
    If Me.ctbTipoCombustible.NoHayCodigo = True Then
      strError += "* Tipo Combustible" & Chr(13)
    End If
    If Me.txtPrecioSoles.Text.Trim = vbNullString Then
      strError += "* Precio Soles " & Chr(13)
    End If
   
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
      Return False
    Else
      Return True
    End If
  End Function
#End Region

End Class
