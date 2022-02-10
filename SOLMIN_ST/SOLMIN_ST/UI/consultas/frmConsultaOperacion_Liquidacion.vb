Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Text

Public Class frmConsultaOperacion_Liquidacion

#Region "Atributos"
  Private mCCMPN As String = ""
  Private mCDVSN As String = ""
  Private mCPLNDV As Int32 = 0
  Private mNLQDCN As Int64 = 0
  'Private obj_lista As New List(Of LiquidacionOperacion)
  Private Const HTMLInicio As String = "<HTML><BODY>"
  Private Const HTMLFin As String = "</BODY></HTML>"
  Private Const HTMLSalto As String = "<br/>"
  Private Const HTMLEspacio As String = "&nbsp;"
#End Region

#Region "Properties"

  Public WriteOnly Property Compania() As String
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property Division() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property Planta() As Int32
    Set(ByVal value As Int32)
      mCPLNDV = value
    End Set
  End Property

  Public WriteOnly Property NroLiquidacion() As Int64
    Set(ByVal value As Int64)
      mNLQDCN = value
    End Set
  End Property

  'Public WriteOnly Property Lista() As List(Of LiquidacionOperacion)
  '  Set(ByVal value As List(Of LiquidacionOperacion))
  '    obj_lista = value
  '  End Set
  'End Property

#End Region

#Region "Eventos"

  Private Sub frmConsultaOperacion_Liquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.lblTitulo.Text = Me.Tag.ToString
    Me.dtgLiquidacionSAP.AutoGenerateColumns = False
    Me.Lista_Liquidacion_SAP()
    Dim objDataTable As New DataTable
    If Me.dtgLiquidacionSAP.RowCount = 0 Then
      Dim Objeto_Logica As New GuiaTransportista_BLL
      Dim objetoParametro As Hashtable
      Dim intResultado As Int32 = 0
      objetoParametro = New Hashtable
      objetoParametro.Add("PNNLQDCN", mNLQDCN)
      objetoParametro.Add("PSCCMPN", mCCMPN)
      objetoParametro.Add("PSCDVSN", mCDVSN)

      objDataTable = Objeto_Logica.Listar_Operaciones_Liquidacion_Correo(objetoParametro)

      objetoParametro = New Hashtable
      objetoParametro.Add("PSCCMPN", mCCMPN)
      objetoParametro.Add("PSCDVSN", mCDVSN)
      objetoParametro.Add("PNNLQDCN", mNLQDCN)
      objetoParametro.Add("PSMMCUSR", USUARIO)
            objetoParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
      objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
      objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)

            Select Case Objeto_Logica.Anular_Liquidacion_Flete_Propio_Prov_Varios(objetoParametro)
                Case 0
                    HelpClass.MsgBox("Error al anular la Liquidación de Flete", MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Case 1
                    Me.Enviar_Correo_Anulacion_Liquidacion(objDataTable)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
            End Select
    End If
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    If Me.dtgLiquidacionSAP.RowCount <= 0 Then Exit Sub
    Dim objDataTable As New DataTable
    Dim Objeto_Logica As New GuiaTransportista_BLL
    Dim objetoParametro As Hashtable
    Dim hasResultado As New Hashtable

    objetoParametro = New Hashtable
    objetoParametro.Add("PNNLQDCN", mNLQDCN)
    objetoParametro.Add("PSCCMPN", mCCMPN)
    objetoParametro.Add("PSCDVSN", mCDVSN)

    objDataTable = Objeto_Logica.Listar_Operaciones_Liquidacion_Correo(objetoParametro)

    objetoParametro = New Hashtable
    objetoParametro.Add("PSCCMPN", mCCMPN)
    objetoParametro.Add("PSCDVSN", mCDVSN)
    objetoParametro.Add("PNNLQDCN", mNLQDCN)
    objetoParametro.Add("PSCULUSA", MainModule.USUARIO)
    objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
    objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
        objetoParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

        hasResultado = Objeto_Logica.Eliminar_Liquidacion_Flete_SAP_Prov_Varios(Me.dtgLiquidacionSAP.DataSource, objetoParametro, "")
    Select Case hasResultado("INTRESULT")
      Case 0
        HelpClass.MsgBox("Error al anular la Liquidación de Flete", MessageBoxIcon.Error)
      Case 1
        HelpClass.MsgBox("No se puede anular la Liquidación de Flete : " & mNLQDCN & " - " & hasResultado("STRRESULT"), MessageBoxIcon.Error)
        Me.Lista_Liquidacion_SAP()
      Case 2
        Me.Enviar_Correo_Anulacion_Liquidacion(objDataTable)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Select
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

#End Region

#Region "Métodos"

  Private Sub Lista_Liquidacion_SAP()
    Dim Objeto_Logica As New GuiaTransportista_BLL
    Dim objetoParametro As New Hashtable
    Dim lintResult As Int32 = 0

    objetoParametro.Add("PNNLQDCN", mNLQDCN)
    objetoParametro.Add("PSCCMPN", mCCMPN)
    objetoParametro.Add("PSCDVSN", mCDVSN)
    objetoParametro.Add("PNCPLNDV", mCPLNDV)
    Me.dtgLiquidacionSAP.DataSource = Objeto_Logica.Lista_Liquidacion_Flete_SAP(objetoParametro)
    'End Select

  End Sub

  Private Sub Enviar_Correo_Anulacion_Liquidacion(ByVal objDataTable As DataTable)
    Dim oclsEmailManager As New clsEmailManager
    oclsEmailManager.MailAccount = HelpClass.MailAccount
    oclsEmailManager.Mailpassword = HelpClass.Mailpassword
    oclsEmailManager.MailBody = Me.CrearDatosCuerpoAnulacionLiquidacion(objDataTable)
    oclsEmailManager.MainNotification = "mravellod@ransa.net; jalbans@ransa.net"
    oclsEmailManager.mailnotificationBCC = "ajuandediosl@gromero.com.pe; warteagaj@gromero.com.pe"
    oclsEmailManager.MailSubject = "Anulación de Liquidación de Flete"
    oclsEmailManager.SendMail()

  End Sub

  Private Function CrearDatosCuerpoAnulacionLiquidacion(ByVal objDataTable As DataTable) As String
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
    bodyemail.Append("El usuario <b> " & USUARIO & " </b>, ha ANULADO la Liquidación de Flete N° <b> " & Me.mNLQDCN & " </b> .")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append(HTMLSalto)

    bodyemail.Append("<tr>")
    bodyemail.Append("<td font-weight: bold>")
    bodyemail.Append("<b> Compañia </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("<td>")
    bodyemail.Append(Me.btnProcesar.Tag.ToString.Trim)
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
    bodyemail.Append(HelpClass.Now_Hora)
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    bodyemail.Append("<tr>")
    bodyemail.Append("<td colspan='5'>")
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

    bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
    bodyemail.Append("<b> Importe a Pagar </b>")
    bodyemail.Append("</td>")
    bodyemail.Append("</tr>")

    For Count As Int32 = 0 To objDataTable.Rows.Count - 1

      bodyemail.Append("<tr>")
      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(objDataTable.Rows(Count).Item("NOPRCN").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(objDataTable.Rows(Count).Item("FINCOP").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(objDataTable.Rows(Count).Item("TCMPCL").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(objDataTable.Rows(Count).Item("NGUITR").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("<td style='text-align:center'>")
      bodyemail.Append(objDataTable.Rows(Count).Item("IMPORTE").ToString)
      bodyemail.Append("</td>")

      bodyemail.Append("</tr>")

    Next

    bodyemail.Append("</table>")
    bodyemail.Append(HTMLFin)

    Return bodyemail.ToString.Trim
  End Function

#End Region

End Class
