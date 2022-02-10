Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Text

Public Class frmAsignarArea

  Private Const HTMLInicio As String = "<HTML><BODY>"
  Private Const HTMLFin As String = "</BODY></HTML>"
  Private Const HTMLSalto As String = "<br/>"
  Private Const HTMLEspacio As String = "&nbsp;"

  Private _NOPRCN As String
  Private _CCMPN As String
  Private _STSACT As String
  Private _OBJDAT As DataTable

  Public WriteOnly Property Table() As DataTable
    Set(ByVal value As DataTable)
      _OBJDAT = value
    End Set
  End Property

  Public WriteOnly Property STSACT() As String
    Set(ByVal value As String)
      _STSACT = value
    End Set
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public WriteOnly Property NOPRCN() As String
    Set(ByVal value As String)
      _NOPRCN = value
    End Set
  End Property

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Dim objNegocio As New OperacionTransporte_BLL
    Dim objHash As New Hashtable
    Dim intHora As Int32 = HelpClass.NowNumeric
    Dim strHora As String = HelpClass.Now_Hora

    objHash.Add("NOPRCN", Me._NOPRCN)
    objHash.Add("SESDCM", Me.cboAreaResponsable.SelectedValue)
    objHash.Add("MMCUSR", USUARIO)
    objHash.Add("FCHCRT", HelpClass.TodayNumeric)
    objHash.Add("HRACRT", intHora)
        objHash.Add("NTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
    objHash.Add("CCMPN", Me._CCMPN)
    Dim lintResult As Int16
    'lintResult = objNegocio.Registrar_Pase_Administrativo_Operacion(objHash)
    If lintResult = 1 Then
      Me.Enviar_Correo_Pase_Operacion(strHora)
      HelpClass.MsgBox("El pase se realizó exitosamente", MessageBoxIcon.Information)
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End If
  End Sub

  Private Function ObtenerEstadosOperacion() As DataTable
    Dim oDt As New DataTable
    oDt.TableName = "dtResumenEstado"
    Dim oDr As DataRow
    oDt.Columns.Add("VALUE", Type.GetType("System.String"))
    oDt.Columns.Add("ESTADO_NOPRCN", Type.GetType("System.String"))

    oDr = oDt.NewRow
    oDr.Item(0) = "O"
    oDr.Item(1) = "OPERACIONES"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "S"
    oDr.Item(1) = "SUPERVISOR"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "A"
    oDr.Item(1) = "ADMINISTRACION"
    oDt.Rows.Add(oDr)

    Return oDt

  End Function

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmAsignarArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Mostrar_Usuario()
    Dim objDataTable As DataTable = ObtenerEstadosOperacion()
    Me.cboAreaResponsable.DataSource = objDataTable
    Me.cboAreaResponsable.DisplayMember = "ESTADO_NOPRCN"
    Me.cboAreaResponsable.ValueMember = "VALUE"
    Me.dtpFecha.Value = Date.Today
    Me.txtHora.Text = HelpClass.Now_Hora
    Me.cboAreaResponsable.SelectedIndex = 1
  End Sub

  Private Sub Mostrar_Usuario()
    Try
      Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
      Dim objhash As New Hashtable
      objhash.Add("MMCUSR", USUARIO)
      objhash.Add("CCMPN", Me._CCMPN)
      Me.txtUsuario.Text = objLogica.Nombre_Usuario(objhash)
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub Enviar_Correo_Pase_Operacion(ByVal strHora As String)
    Dim oclsEmailManager As New clsEmailManager
    oclsEmailManager.MailAccount = HelpClass.MailAccount
    oclsEmailManager.Mailpassword = HelpClass.Mailpassword
    oclsEmailManager.MailBody = Me.CrearDatosCuerpoOperacion(strHora)
    oclsEmailManager.MainNotification = "ajuandediosl@gromero.com.pe" '"mravellod@ransa.net; jalbans@ransa.net"
    oclsEmailManager.mailnotificationBCC = "ajuandediosl@gromero.com.pe" '; warteagaj@gromero.com.pe"
    oclsEmailManager.MailSubject = "Pase de Operaciones"
    oclsEmailManager.SendMail()

  End Sub

  Private Function CrearDatosCuerpoOperacion(ByVal strHora As String) As String
    Dim bodyemail As New StringBuilder
    bodyemail.Append(HTMLInicio)
    bodyemail.Append("<table border='0px'style='font-size:12px' >")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td colspan='5'; font-weight: bold>")
    bodyemail.Append("<b> Sres. </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td colspan='5' ; font-weight: bold>")
    bodyemail.Append("El usuario <b> " & USUARIO & " </b>, ha realizado el pase de las  Operaciones al <b> " & Me.cboAreaResponsable.Text & " </b> .")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append(HTMLSalto)

    bodyemail.Append("<tr>")
    bodyemail.Append("<td font-weight: bold>")
    bodyemail.Append("<b> Compañia </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("<td>")
    bodyemail.Append(Me.Tag.ToString.Trim)
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td font-weight: bold>")
    bodyemail.Append("<b> Fecha </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("<td>")
    bodyemail.Append(Now.ToString("dd/MM/yyyy"))
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td font-weight: bold>")
    bodyemail.Append("<b> Hora </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("<td>")
    bodyemail.Append(strHora)
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td colspan='4'>")
    bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=50%' />")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
    bodyemail.Append("<b> Operaci&oacute;n </b>")
    bodyemail.Append("</td>")

    bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
    bodyemail.Append("<b> Fecha Operaci&oacute;n </b>")
    bodyemail.Append("</td>")

    bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
    bodyemail.Append("<b> Cliente Operaci&oacute;n </b>")
    bodyemail.Append("</td>")

    bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
    bodyemail.Append("<b> Gu&iacute;a Transporte </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    For Count As Int32 = 0 To Me._OBJDAT.Rows.Count - 1

      bodyemail.Append("<tr>")
      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(Me._OBJDAT.Rows(Count).Item("NOPRCN").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(Me._OBJDAT.Rows(Count).Item("FINCOP").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(Me._OBJDAT.Rows(Count).Item("TCMPCL").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(Me._OBJDAT.Rows(Count).Item("NGUITR").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("</tr>")

    Next

    bodyemail.Append("</table>")
    bodyemail.Append(HTMLFin)

    Return bodyemail.ToString.Trim
  End Function

End Class
