Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmCentroCostoCliente

#Region "Atributo"
  Private pobjEntidad As Solicitud_Transporte
#End Region

#Region "Properties"

  Public Property Entidad_Solicitud() As Solicitud_Transporte
    Get
      Return pobjEntidad
    End Get
    Set(ByVal value As Solicitud_Transporte)
      pobjEntidad = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub frmCentroCostoCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.txtNroSolicitud.Text = pobjEntidad.NCSOTR
    Me.txtCliente.Text = pobjEntidad.TCMPCL
    Me.txtCentroCosto.Text = pobjEntidad.CCTCSC
  End Sub

  Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
    pobjEntidad.CCTCSC = Me.txtCentroCosto.Text.Trim
    pobjEntidad.CULUSA = MainModule.USUARIO
    pobjEntidad.FULTAC = HelpClass.TodayNumeric
    pobjEntidad.HULTAC = HelpClass.NowNumeric
        pobjEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'pobjEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte_Centro_Costo(pobjEntidad)
    If pobjEntidad.NCSOTR = "0" Then
      pobjEntidad.NCSOTR = Me.txtNroSolicitud.Text.Trim
      HelpClass.ErrorMsgBox()
      Exit Sub
    Else
      HelpClass.MsgBox("Se Modificó Satisfactoriamente")
    End If
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

#End Region

#Region "Métodos"

#End Region

End Class
