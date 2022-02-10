Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmOpcionAgregarGuia

#Region "Atributo"
  Private _OPCION As Integer = 0
  Private _NOPRCN As Double = 0
  Private _NPLNMT As Double = 0
  Private _TCMPCL As String = ""
  Private _NPLCTR As String = ""
  Private mCCMPN As String = ""
  Private mCDVSN As String = ""
  Private mCPLNDV As Int32 = 0
#End Region

#Region "Propiedades"

  Public Property CCMPN() As String
    Get
      Return mCCMPN
    End Get
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int32
    Set(ByVal value As Int32)
      mCPLNDV = value
    End Set
  End Property

  Public Property OPCION() As Integer
    Get
      Return _OPCION
    End Get
    Set(ByVal value As Integer)
      _OPCION = value
    End Set
  End Property

  Public ReadOnly Property NOPRCN() As Double
    Get
      Return Me.txtOperacion.Text
    End Get
  End Property

  Public ReadOnly Property NPLNMT() As Double
    Get
      Return _NPLNMT
    End Get
  End Property

  Public ReadOnly Property TCMPCL() As String
    Get
      Return _TCMPCL
    End Get
  End Property

  Public WriteOnly Property NPLCTR() As String
    Set(ByVal value As String)
      _NPLCTR = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub btnOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperacion.Click
    Dim BuscarOperacion As New frmBuscarOperacion

    With BuscarOperacion
      .txtTracto.Text = Me._NPLCTR
      .CCMPN = mCCMPN
      .CDVSN = mCDVSN
      .CPLNDV = mCPLNDV
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.txtOperacion.Text = .NOPRCN_1
        Me._NPLNMT = .NPLNMT_1
        Me._TCMPCL = .TCMPCL_2
      End If
    End With

  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Try
      If Me.rbtnSolicitud.Checked = True Then
        Me._OPCION = 1
      Else
        If Me.txtOperacion.TextLength = 0 Then
          HelpClass.MsgBox("Falta elegir una Operación")
          Exit Sub
        Else
          Dim obj_Logica As New OperacionTransporte_BLL
          Dim ldob_NPLNMT As Double = obj_Logica.Validar_Existe_Operacion(Me.txtOperacion.Text, mCCMPN)
          If ldob_NPLNMT = -1 Then
            HelpClass.MsgBox("No existe esta Operación")
            Exit Sub
          Else
            Me._NPLNMT = ldob_NPLNMT
          End If
        End If
        Me._OPCION = 2
      End If
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Catch : End Try

  End Sub

  Private Sub rbtnOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOperacion.CheckedChanged
    If Me.rbtnSolicitud.Checked = False Then
      Me.btnOperacion.Enabled = True
      Me.txtOperacion.Enabled = True
    Else
      Me.btnOperacion.Enabled = False
      Me.txtOperacion.Enabled = False
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If CShort(HelpClass.SoloNumeros(CShort(Asc(e.KeyChar)))) = 0 Then e.Handled = True
  End Sub

#End Region

  Private Sub txtOperacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacion.TextChanged

  End Sub
End Class
