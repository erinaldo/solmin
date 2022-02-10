Imports Ransa.Utilitario
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones


Public Class frmConfirmarLlegada
  Private intNCSOTR As Long = 0
  Private intNCRRSR As Int32 = 0
  Private strCompania As String = ""
  Private strPlanta As Int32 = 0

  Public WriteOnly Property pNCSOTR() As Long
    Set(ByVal value As Long)
      intNCSOTR = value
    End Set
  End Property

  Public WriteOnly Property pNCRRSR() As Int32
    Set(ByVal value As Int32)
      intNCRRSR = value
    End Set
  End Property

  Public WriteOnly Property pCompania() As String
    Set(ByVal value As String)
      strCompania = value
    End Set
  End Property


  Public WriteOnly Property pPlanta() As Int32
    Set(ByVal value As Int32)
      strPlanta = value
    End Set
  End Property


  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
    Dim objHashtable As New Hashtable
    If Not IsDate(Me.dtpHoraConfirmacion.Text) Then
      HelpClass.MsgBox("Ingrese hora valida")
      Exit Sub
    End If

    With objHashtable
      .Add("CCMPN", strCompania)
      .Add("CDVSN", "R")
      .Add("CPLNDV", strPlanta)
      .Add("FLGCNL", "X")
      .Add("TOBSEN", Me.txtObservaciones.Text)
      .Add("FCNFCL", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaConfirmacion.Value))
      .Add("HCNFCL", HelpClass.ConvertHoraNumeric(dtpHoraConfirmacion.Text))
      .Add("NCSOTR", intNCSOTR)
      .Add("NCRRSR", intNCRRSR)
      .Add("CULUSA", USUARIO)
    End With

    If objSolicitudTransporte.Actualizar_Bulto(objHashtable) = 0 Then
      HelpClass.MsgBox("Error: Comuniquese con departamento de sistemas", MessageBoxIcon.Error)
      Exit Sub
    Else
      HelpClass.MsgBox("Se Actualizó Satisfactoriamente", MessageBoxIcon.Information)
    End If

    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
End Class
