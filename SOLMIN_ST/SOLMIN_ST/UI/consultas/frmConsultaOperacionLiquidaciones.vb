Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Text

Public Class frmConsultaOperacionLiquidaciones
#Region "Atributos"
    Private mCCMPN As String = ""
    Private mCDVSN As String = ""
    Private mCPLNDV As Int32 = 0
    Private mNLQDCN As Int64 = 0
    Private Objeto_Logica As New GuiaTransportista_BLL
    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    'Private dtNumerosCO As DataTable
    Private oListDestinatario As List(Of ENTIDADES.beDestinatario)

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
#End Region

#Region "Eventos"
    Private Sub frmConsultaOperacionLiquidaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.lblTitulo.Text = Me.Tag.ToString
            Me.lblTitulo.Text = Me.Tag.ToString
            Me.gwdDatos.AutoGenerateColumns = False
            Me.Lista_Liquidaciones_X_Operacion_SAP()

           

            txtperiodoAnul.Text = "Fecha Liquidación"
            txtperiodoAnul.Tag = "01"


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function validarAnulacionSAP() As String
        Dim objetoParametro As Hashtable
        Dim strMensajeError As String = ""
        For Each row As DataGridViewRow In gwdDatos.Rows
            '**********************************Validaciones****************************************
            If row.Cells("C_NUMOPG").Value > 0 Then
                strMensajeError = strMensajeError & " - No se puede Anular, Liquidacion " & row.Cells("C_NLQDCN").Value & " Tiene Documento de Pago" & vbNewLine
            End If
            objetoParametro = New Hashtable
            objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
            objetoParametro.Add("PSCCMPN", mCCMPN)
            objetoParametro.Add("PSCDVSN", mCDVSN)
            Dim dtDatoOperacion As New DataTable
            dtDatoOperacion = Objeto_Logica.Listar_Datos_Operacion_Flete(objetoParametro)

            If dtDatoOperacion.Rows.Count = 0 Then
                strMensajeError = strMensajeError & "- Liquidación " & row.Cells("C_NLQDCN").Value & " no tiene operación" & vbNewLine
            Else
                If ("" & dtDatoOperacion.Rows(0)("SESTOP")).ToString.Trim = "F" Then
                    strMensajeError = strMensajeError & " - No se puede Anular, Liquidación " & row.Cells("C_NLQDCN").Value & " está PreFacturada y/o Facturada" & vbNewLine
                End If
            End If
        Next
        Return strMensajeError
    End Function


    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            'Dim msgAnulacioTarifa As String = ""
            If Me.gwdDatos.RowCount <= 0 Then Exit Sub
            Dim objetoParametro As Hashtable
            Dim strMensajeError As String = ""
            If Me.gwdDatos.RowCount = 0 Then Exit Sub

            Dim msgValidar As String = ""
            msgValidar = validarAnulacionSAP()
            If msgValidar.Length > 0 Then
                MessageBox.Show(msgValidar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim intResultado As Integer = 0
            Dim obrOrdenServicio As New SOLMIN_ST.NEGOCIO.Operaciones.OrdenServicio_BLL

            'Dim msgErr1 As String = ""
            Dim msgErr2 As String = ""
            Dim msgErr3 As String = ""
            For Each row As DataGridViewRow In gwdDatos.Rows

                Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
                With obeOrdenServicioTransporte
                    .CCMPN = mCCMPN
                    .CDVSN = mCDVSN
                    .NLQDCN = row.Cells("C_NLQDCN").Value
                    .NOPRCN = 0
                    .TIPO = 1
                End With
                intResultado = obrOrdenServicio.intTieneProvision(obeOrdenServicioTransporte)
                If intResultado = 2 Then
                    If obrOrdenServicio.fblnUsuarioPermitidoRevertirProvision(MainModule.USUARIO) Then
                        msgErr2 = msgErr2 & "La liquidación " & obeOrdenServicioTransporte.NLQDCN & " está provisionada" & vbNewLine
                    Else
                        msgErr3 = msgErr3 & " - Sin autorización para anulación de liq. " & obeOrdenServicioTransporte.NLQDCN & " .La operación se encuentra provisionada." & vbNewLine
                    End If
                End If


               
            Next


            msgErr3 = msgErr3.Trim
            msgErr2 = msgErr2.Trim

            If msgErr3.Length > 0 Then
                MessageBox.Show(msgErr3, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If msgErr2.Length > 0 Then
                If MessageBox.Show("Está seguro de eliminar la liquidación " & Chr(13) & msgErr2, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If


           

            For Each row As DataGridViewRow In gwdDatos.Rows


                Dim olstLiqOperacion As New List(Of LiquidacionOperacion)
                objetoParametro = New Hashtable
                objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
                objetoParametro.Add("PSCCMPN", mCCMPN)
                objetoParametro.Add("PSCDVSN", mCDVSN)
                objetoParametro.Add("PNCPLNDV", mCPLNDV)
                olstLiqOperacion = Objeto_Logica.Lista_Liquidacion_Flete_SAP(objetoParametro)

                If olstLiqOperacion.Count = 0 Then
                    'Envio de Correo y Anulacion de Propio
                    Dim objDataTable As New DataTable
                    objetoParametro = New Hashtable
                    objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
                    objetoParametro.Add("PSCCMPN", mCCMPN)
                    objetoParametro.Add("PSCDVSN", mCDVSN)
                    objDataTable = Objeto_Logica.Listar_Operaciones_Liquidacion_Correo(objetoParametro)

                    objetoParametro = New Hashtable
                    objetoParametro.Add("PSCCMPN", mCCMPN)
                    objetoParametro.Add("PSCDVSN", mCDVSN)
                    objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
                    objetoParametro.Add("PSMMCUSR", USUARIO)
                    objetoParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                    objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
                    objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)


                    Objeto_Logica.Anular_Liquidacion_Flete_Propio_Prov_Varios(objetoParametro)

                    Dim lobjParams As New Hashtable
                    lobjParams.Add("PSCCMPN", mCCMPN) 'Compañía
                    lobjParams.Add("PSCDVSN", mCDVSN) 'Cód. División
                    lobjParams.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value) ' Nro. Liquidación
                    Objeto_Logica.freversion_provision_sap(lobjParams)
                    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
                    Me.Enviar_Correo_Anulacion_Liquidacion(objDataTable, row.Cells("C_NLQDCN").Value)

                    'Select Case Objeto_Logica.Anular_Liquidacion_Flete_Propio_Prov_Varios(objetoParametro)
                    '    'Case 0

                    '    '    strMensajeError &= " - Error al anular la Liquidación de Flete " & row.Cells("C_NLQDCN").Value & vbNewLine

                    '    Case 1
                    '        'msgAnulacioTarifa = AnularTransferenciaCosto(txtperiodoAnul.Tag) 'INI-ECM-ActualizacionTarifario[RF002]-160516
                    '        'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
                    '        Dim lobjParams As New Hashtable
                    '        lobjParams.Add("PSCCMPN", mCCMPN) 'Compañía
                    '        lobjParams.Add("PSCDVSN", mCDVSN) 'Cód. División
                    '        lobjParams.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value) ' Nro. Liquidación
                    '        Objeto_Logica.freversion_provision_sap(lobjParams)
                    '        'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
                    '        Me.Enviar_Correo_Anulacion_Liquidacion(objDataTable, row.Cells("C_NLQDCN").Value)

                    'End Select
                Else
                    'Proceso de Envio de Correo y Anulacion de Tercero
                    Dim hasResultado As New Hashtable
                    Dim objDataTable As New DataTable
                    objetoParametro = New Hashtable
                    objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
                    objetoParametro.Add("PSCCMPN", mCCMPN)
                    objetoParametro.Add("PSCDVSN", mCDVSN)

                    objDataTable = Objeto_Logica.Listar_Operaciones_Liquidacion_Correo(objetoParametro)

                    objetoParametro = New Hashtable
                    objetoParametro.Add("PSCCMPN", mCCMPN)
                    objetoParametro.Add("PSCDVSN", mCDVSN)
                    objetoParametro.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value)
                    objetoParametro.Add("PSCULUSA", MainModule.USUARIO)
                    objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
                    objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
                    objetoParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

                    hasResultado = Objeto_Logica.Eliminar_Liquidacion_Flete_SAP_Prov_Varios(olstLiqOperacion, objetoParametro, txtperiodoAnul.Tag)
                    Select Case hasResultado("INTRESULT")
                        'Case 0
                        '    strMensajeError &= "Error al anular la Liquidación de Flete " & row.Cells("C_NLQDCN").Value & vbNewLine & hasResultado("STRRESULT")
                        Case 1
                            strMensajeError &= "No se puede anular la Liquidación de Flete : " & row.Cells("C_NLQDCN").Value & vbNewLine & hasResultado("STRRESULT")
                        Case 2
                            'msgAnulacioTarifa = AnularTransferenciaCosto(txtperiodoAnul.Tag)
                            'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
                            Dim lobjParams As New Hashtable
                            lobjParams.Add("PSCCMPN", mCCMPN) 'Compañía
                            lobjParams.Add("PSCDVSN", mCDVSN) 'Cód. División
                            lobjParams.Add("PNNLQDCN", row.Cells("C_NLQDCN").Value) ' Nro. Liquidación
                            Objeto_Logica.freversion_provision_sap(lobjParams)
                            'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
                            Me.Enviar_Correo_Anulacion_Liquidacion(objDataTable, row.Cells("C_NLQDCN").Value)

                    End Select
                End If
            Next


            strMensajeError = strMensajeError.Trim
        

            If strMensajeError.Length > 0 Then
                'MessageBox.Show(strMensajeError & Chr(13) & msgAnulacioTarifa, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()
    End Sub

#End Region


#Region "Metodos"
    Private Sub Lista_Liquidacion_SAP(ByVal pNLQDCN As Double)
        'Try

        Dim objetoParametro As New Hashtable
        Dim lintResult As Int32 = 0

        objetoParametro.Add("PNNLQDCN", pNLQDCN)
        objetoParametro.Add("PSCCMPN", mCCMPN)
        objetoParametro.Add("PSCDVSN", mCDVSN)
        objetoParametro.Add("PNCPLNDV", mCPLNDV)
        Me.dtgLiquidacionSAP.AutoGenerateColumns = False
        Me.dtgLiquidacionSAP.DataSource = Objeto_Logica.Lista_Liquidacion_Flete_SAP(objetoParametro)

        'dtNumerosCO = Objeto_Logica.Listar_NumerosCO(objetoParametro)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'End Try

    End Sub

    'Private Function AnularTransferenciaCosto(ByVal TipoPeriodoAnulacion As String) As String
    '    Dim sbMensajesAnulacion As String = ""
    '    Try
    '        'If dtNumerosCO Is Nothing Then Return
    '        Dim mensaje As String = ""
    '        For Each fila As DataRow In dtNumerosCO.Rows
    '            mensaje = Objeto_Logica.Procesar_Anulacion_CO_Tarifa_Interna(fila("NCRDCO"), mCCMPN, TipoPeriodoAnulacion)
    '            If mensaje.Length > 0 Then
    '                sbMensajesAnulacion = sbMensajesAnulacion & Chr(13) & mensaje
    '            End If
    '        Next
    '        sbMensajesAnulacion = sbMensajesAnulacion.Trim
    '    Catch ex As Exception
    '        sbMensajesAnulacion = ex.Message
    '    End Try
    '    Return sbMensajesAnulacion
    'End Function

    Private Sub Lista_Liquidaciones_X_Operacion_SAP()
        
        Dim objetoParametro As New Hashtable
      
        objetoParametro.Add("PNNLQDCN", mNLQDCN)
        objetoParametro.Add("PSCCMPN", mCCMPN)
        objetoParametro.Add("PSCDVSN", mCDVSN)
        objetoParametro.Add("PNCPLNDV", mCPLNDV)
        gwdDatos.DataSource = Nothing

        Dim oListLiq As New List(Of LiquidacionOperacion)
        oListLiq = Objeto_Logica.Listar_Liquidaciones_Flete_X_Liquidacion(objetoParametro)
        gwdDatos.DataSource = oListLiq
        
        'dtNumerosCO = Objeto_Logica.Listar_NumerosCO(objetoParametro)

    End Sub

    Private Sub Enviar_Correo_Anulacion_Liquidacion(ByVal objDataTable As DataTable, ByVal NLQDCN As Double)
        Try
            Dim oclsEmailManager As New clsEmailManager
            oclsEmailManager.MailAccount = HelpClass.MailAccount
            oclsEmailManager.Mailpassword = HelpClass.Mailpassword
            oclsEmailManager.MailBody = Me.CrearDatosCuerpoAnulacionLiquidacion(objDataTable, NLQDCN)
            'oclsEmailManager.MainNotification = "jcachom@gromero.com.pe"
            'oclsEmailManager.mailnotificationBCC = "karin_1586@hotmail.com"
            'oclsEmailManager.MainNotification = "mravellod@ransa.net; jalbans@ransa.net"
            'oclsEmailManager.mailnotificationBCC = "jcachom@gromero.com.pe; warteagaj@gromero.com.pe"

            Dim entidad As ENTIDADES.beDestinatario = BuscarDestinatarios(999999)

            oclsEmailManager.MainNotification = entidad.PSEMAILTO
            oclsEmailManager.mailnotificationBCC = entidad.PSEMAILBC

            oclsEmailManager.MailSubject = "Anulacion de Liquidacion de Flete"
            oclsEmailManager.SendMail()
        Catch ex As Exception

        End Try
     

    End Sub

    Private Function ListaEmailDistintos(ByVal oList As List(Of ENTIDADES.beDestinatario)) As String
        Dim Tot_Destinatarios As Int32 = 0
        Dim STR_LISTA_EMAIL As String = ""
        Dim sbDestinatarios As New StringBuilder
        Dim CharSeparacion As String = ";"
        Dim ListTempEMAIL As New List(Of String)
        Dim FILA As Int32 = 0
        Dim EMAIL As String = ""
        Tot_Destinatarios = oList.Count
        ListTempEMAIL.Clear()
        For FILA = 0 To Tot_Destinatarios - 1
            EMAIL = oList(FILA).PSEMAILTO.Trim.ToLower
            If (EMAIL.Length <> 0) Then
                If (Not ListTempEMAIL.Contains(EMAIL)) Then
                    ListTempEMAIL.Add(EMAIL)
                    sbDestinatarios.Append(EMAIL)
                    sbDestinatarios.Append(CharSeparacion)
                End If
            End If
        Next
        STR_LISTA_EMAIL = sbDestinatarios.ToString.Trim
        If (STR_LISTA_EMAIL.Length > 0) Then
            STR_LISTA_EMAIL = STR_LISTA_EMAIL.Substring(0, STR_LISTA_EMAIL.LastIndexOf(CharSeparacion))
        End If
        Return STR_LISTA_EMAIL
    End Function


    Private Function FindDestinatarioCopia(ByVal obeDestinatario As ENTIDADES.beDestinatario) As Boolean

        Return obeDestinatario.PSTIP_MAIL_DEST = "COPIA"

    End Function

    Private Function FindDestinatarioCliente(ByVal obeDestinatario As ENTIDADES.beDestinatario) As Boolean

        Return obeDestinatario.PSTIPO_ENVIO = "ST_ANULIQ" AndAlso obeDestinatario.PSTIP_MAIL_DEST = "CLIENTE"

    End Function


    Public Function BuscarDestinatarios(ByVal CCLNT As Decimal) As ENTIDADES.beDestinatario

        Dim obeDestinatariosEnvio As New ENTIDADES.beDestinatario
        Dim oListBU As New List(Of String)
        Dim oListDestinatarioBusqueda As New List(Of ENTIDADES.beDestinatario)
        Dim oListDestinatarioReplicacion As New List(Of ENTIDADES.beDestinatario)
        oListDestinatario = Objeto_Logica.olisListarResponsables(999999, "ST_ANULIQ")
        oListDestinatarioBusqueda = oListDestinatario.FindAll(AddressOf FindDestinatarioCliente)
        oListDestinatarioReplicacion = oListDestinatario.FindAll(AddressOf FindDestinatarioCopia)
        obeDestinatariosEnvio.PSEMAILTO = ListaEmailDistintos(oListDestinatarioBusqueda)
        obeDestinatariosEnvio.PSEMAILBC = ListaEmailDistintos(oListDestinatarioReplicacion)
        Return obeDestinatariosEnvio

    End Function

    Private Function CrearDatosCuerpoAnulacionLiquidacion(ByVal objDataTable As DataTable, ByVal NLQDCN As Double) As String
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
    bodyemail.Append("El usuario <b> " & USUARIO & " </b>, ha ANULADO la Liquidacion de Flete N° <b> " & NLQDCN & " </b> .")
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


    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            Me.dtgLiquidacionSAP.DataSource = Nothing
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Me.Lista_Liquidacion_SAP(Me.gwdDatos.Item("C_NLQDCN", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try

       
            Dim dt As DataTable
            dt = Objeto_Logica.Lista_Acceso_Usuario_Periodo_Anulacion(MainModule.USUARIO, mCCMPN)

            If dt.Rows.Count = 0 Then

                MessageBox.Show("No tiene permisos para modificar periodo de anulación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Dim frm As New FrmAnulaLiquidacion
                frm.compañia = mCCMPN
                frm.ShowDialog()

                If frm.Codigo <> "" Then
                    txtperiodoAnul.Text = frm.Descrip
                    txtperiodoAnul.Tag = frm.Codigo
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
