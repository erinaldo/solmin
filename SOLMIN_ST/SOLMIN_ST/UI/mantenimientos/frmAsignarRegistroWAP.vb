Imports SOLMIN_ST.NEGOCIO.seguimiento_wap
Imports SOLMIN_ST.ENTIDADES

Public Class frmAsignarRegistroWAP

#Region "Atributo"
  Private _FRGTRO As String
  Private _HRGTRO As String
  Private _TOBS As String
#End Region

#Region "Propiedades"

  Public Property FRGTRO() As String
    Get
      Return _FRGTRO
    End Get
    Set(ByVal value As String)
      _FRGTRO = value
    End Set
  End Property

  Public Property HRGTRO() As String
    Get
      Return _HRGTRO
    End Get
    Set(ByVal value As String)
      _HRGTRO = value
    End Set
  End Property

  Public Property TOBS() As String
    Get
      Return _TOBS
    End Get
    Set(ByVal value As String)
      _TOBS = value
    End Set
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property



#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.Validar_Inputs = True Then Exit Sub
        _FRGTRO = HelpClass.CtypeDate(Me.dtpFecRegistro.Value)
        _HRGTRO = Me.txtHoraRegistro.Text
        _TOBS = Me.txtObservacion.Text.Trim
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Not IsDate(Me.txtHoraRegistro.Text) OrElse Me.txtHoraRegistro.Text = "00:00:00" Then
            lstr_validacion += "* HORA " & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmAsignarRegistroWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtHoraRegistro.Text = HelpClass.Now_Hora
    End Sub

End Class


