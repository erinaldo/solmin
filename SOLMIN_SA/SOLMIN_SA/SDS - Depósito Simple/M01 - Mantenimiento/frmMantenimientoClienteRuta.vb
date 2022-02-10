Imports RANSA.TypeDef.Cliente
Imports Ransa.NEGO
Imports ransa.TypeDef
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario
Imports System.Text

Public Class frmMantenimientoClienteRuta

#Region "Atributos"

    Public oEntidad As beRutaTienda
    Public BuscarDatosDefault As Boolean = False
    Private _ACCION As String
    Private _CodRuta As String
    Private _CodCliente As String

    Public Property CodRuta() As String
        Get
            Return _CodRuta
        End Get
        Set(ByVal value As String)
            _CodRuta = value
        End Set
    End Property

#End Region

#Region "Metodos Y Funciones"

    Private Function fnGetFecha() As Integer
        Dim y As String = Now.Year
        Dim m As String = IIf(Now.Month > 9, Now.Month.ToString, "0" & Now.Month.ToString)
        Dim d As String = IIf(Now.Day > 9, Now.Day.ToString, "0" & Now.Day.ToString)
        Dim fecha As Integer = Convert.ToInt32(y & "" & m & "" & d)
        Return fecha
    End Function

    Private Function fnGetHora() As Integer
        Dim h As String = IIf(Now.Hour > 9, Now.Hour.ToString, "0" & Now.Hour.ToString)
        Dim m As String = IIf(Now.Minute > 9, Now.Minute.ToString, "0" & Now.Minute.ToString)
        Dim s As String = IIf(Now.Second > 9, Now.Second.ToString, "0" & Now.Second.ToString)
        Dim hora As Integer = Convert.ToInt32(h & "" & m & "" & s)
        Return hora
    End Function

    Private Function GuardarClientexZona() As Integer

        Dim objbeRutaTienda As New beRutaTienda
        Dim objbrRutaTienda As New brRutaTienda
        With objbeRutaTienda
            .PNCCLNT = Me.txtCliente.pCodigo
            If Me.rbtPropio.Checked Then
                .PNCPLNCL = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                .PNCPRVCL = 0
                .PNCPLCLP = 0
            Else
                .PNCPLNCL = 0
                .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
                .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
            End If
            .PSCRUTAT = Me.CodRuta
            .PNHRAINI = Decimal.Parse(HelpClass.ConvertHoraNumeric(Me.dtpHoraInicio.Value.ToString("HH:mm:ss")))
            .PNHRAFIN = Decimal.Parse(HelpClass.ConvertHoraNumeric(Me.dtpHoraFin.Value.ToString("HH:mm:ss")))
            .PSGPSLAT = Me.txtLatitud.Text.Trim()
            .PSGPSLON = Me.txtLongitud.Text.Trim()
            .PNNCRRRT = Decimal.Parse(Me.txtNumCorrelativo.Text.Trim())
            .PSSESTRG = "A"
            .PNFULTAC = fnGetFecha()
            .PNHULTAC = fnGetHora()
            .PSCULUSA = objSeguridadBN.pUsuario
            .PSNTRMNL = objSeguridadBN.pstrPCName
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PNFCHCRT = HelpClass.CDate_a_Numero8Digitos(Now)
            .PNHRACRT = HelpClass.NowNumeric
            .PSNTRMCR = objSeguridadBN.pstrPCName
            .PNUPDATE_IDENT = 1
        End With
        Return objbrRutaTienda.Insertar(objbeRutaTienda)
    End Function

    Private Function ActualizarClientexZona() As Integer

        Dim objbeRutaTienda As New beRutaTienda
        Dim objbrRutaTienda As New brRutaTienda
        With objbeRutaTienda
            .PNCCLNT = Me.txtCliente.pCodigo
            If Me.rbtPropio.Checked Then
                .PNCPLNCL = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
                .PNCPRVCL = 0
                .PNCPLCLP = 0
            Else
                .PNCPLNCL = 0
                .PNCPRVCL = UcClienteTercero_xtF011.ItemActual.PNCCLNT
                .PNCPLCLP = Me.UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL
            End If
            ' .PSTCMPPL = Me.txtDescripcionPlanta.Text.Trim()
            ' .PSTDRCPL = Me.txtDireccionPlanta.Text.Trim()
            .PSCRUTAT = oEntidad.PSCRUTAT
            .PNHRAINI = Decimal.Parse(HelpClass.ConvertHoraNumeric(Me.dtpHoraInicio.Value.ToString("HH:mm:ss")))
            .PNHRAFIN = Decimal.Parse(HelpClass.ConvertHoraNumeric(Me.dtpHoraFin.Value.ToString("HH:mm:ss")))
            .PSGPSLAT = Me.txtLatitud.Text.Trim()
            .PSGPSLON = Me.txtLongitud.Text.Trim()
            .PNNCRRRT = Decimal.Parse(Me.txtNumCorrelativo.Text.Trim())
            .PSSESTRG = "A"

            .PNFULTAC = oEntidad.PNFULTAC
            .PNHULTAC = oEntidad.PNHULTAC
            .PSCULUSA = objSeguridadBN.pUsuario
            .PSNTRMNL = oEntidad.PSNTRMNL
            .PSCUSCRT = oEntidad.PSCUSCRT
            .PNFCHCRT = oEntidad.PNFCHCRT
            .PNHRACRT = oEntidad.PNHRACRT
            .PSNTRMCR = oEntidad.PSNTRMCR
            .PNUPDATE_IDENT = oEntidad.PNUPDATE_IDENT + 1
        End With
        Return objbrRutaTienda.Actualizar(objbeRutaTienda)
    End Function

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub LimpiarControl()
        UcPlantaDeEntrega_TxtF011.CodCliente = txtCliente.pCodigo
        UcClienteTercero_xtF011.CodCliente = txtCliente.pCodigo
        UcPlantaDeEntrega_TxtF011.pClear()
        UcClienteTercero_xtF011.pClear()
    End Sub

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If Me.txtCliente.pCodigo = 0 Then strMensajeError &= "Falta - Cliente." & vbNewLine
        If Me.rbtPropio.Checked And UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine
        If _ACCION = "Update" Then
            If Me.rbtTercero.Checked And UcClienteTercero_xtF011.ItemActual.PNCCLNT = 0 Then strMensajeError &= "Falta - Cliente Tercero." & vbNewLine
        Else
            If Me.rbtTercero.Checked And UcClienteTercero_xtF011.ItemActual.PNCPRVCL = 0 Then strMensajeError &= "Falta - Cliente Tercero." & vbNewLine
        End If
        If Me.rbtTercero.Checked And UcPlantaDeEntrega_TxtF011.ItemActual.PNCPLNCL = 0 Then strMensajeError &= "Falta - Planta de Entrega." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Public Sub CargarDatosModificar()
        Try
            LimpiarControl()
            txtCliente.pCargar(oEntidad.PNCCLNT)
            txtNumCorrelativo.Text = oEntidad.PNNCRRRT
            dtpHoraInicio.Value = Date.Now.Date & " " & oEntidad.PNHRAINI_D
            dtpHoraFin.Value = Date.Now.Date & " " & oEntidad.PNHRAFIN_D
            txtLatitud.Text = oEntidad.PSGPSLAT
            txtLongitud.Text = oEntidad.PSGPSLON
            ' Me.txtDescripcionPlanta.Text = oEntidad.PSTCMPPL
            ' Me.txtDireccionPlanta.Text = oEntidad.PSTDRCPL
            If (oEntidad.PNCPLNCL <> 0) Then
                rbtPropio.Checked = True
                ' SE LLENA LA PLANTA PARA CLIENTE PROPIO
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = True  'propio o tercero
                    .PNCCLNT = oEntidad.PNCCLNT 'cliente 
                    .PNCPRVCL = 0 'cliente tercero
                    .PNCPLNCL = oEntidad.PNCPLNCL 'planta codigo
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
            Else
                Me.rbtTercero.Checked = True
                ' SE LLENA EL CLIENTE TERCERO
                Dim obePlantaDeEntregaC As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntregaC
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = oEntidad.PNCCLNT
                    .PNCPRVCL = oEntidad.PNCPRVCL
                    .PSTPRVCL = oEntidad.PSTPRVCL
                End With
                UcClienteTercero_xtF011.pCargar(obePlantaDeEntregaC)
                Dim dato As String = UcClienteTercero_xtF011.ItemActual.PNCCLNT

                ' SE LLENA LA PLANTA DE ENTREGA PARA EL CLIENTE TERCERO
                Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
                With obePlantaDeEntrega
                    .TIPOCLIENTE = False  'propio o tercero
                    .PNCCLNT = oEntidad.PNCCLNT 'cliente 
                    .PNCPRVCL = oEntidad.PNCPRVCL 'cliente tercero
                    .PNCPLNCL = oEntidad.PNCPLCLP 'planta codigo
                    .PSTCMPPL = "" ' descripcion opciona
                End With
                UcPlantaDeEntrega_TxtF011.pCargar(obePlantaDeEntrega)
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMantenimientoClienteRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 20)
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 20)
        CargarClientes()
        UcPlantaDeEntrega_TxtF011.CodCliente = txtCliente.pCodigo
        UcClienteTercero_xtF011.CodCliente = txtCliente.pCodigo
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            Me.CargarDatosModificar()
            _ACCION = "Update"
        End If
    End Sub

    Private Sub rbtPropio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPropio.CheckedChanged
        If Me.rbtPropio.Checked Then
            UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
            UcClienteTercero_xtF011.Visible = False
            lblClienteTercero.Visible = False
            Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 18)
            Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 18)
            LimpiarControl()
        End If
    End Sub

    Private Sub rbtTercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtTercero.CheckedChanged
        If Me.rbtTercero.Checked Then
            UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = False
            UcClienteTercero_xtF011.Visible = True
            lblClienteTercero.Visible = True
            Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 42)
            Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 42)
            LimpiarControl()
        End If
    End Sub

    Private Sub UcClienteTercero_xtF011_TextChanged() Handles UcClienteTercero_xtF011.TextChanged
        UcPlantaDeEntrega_TxtF011.pClear()
        UcPlantaDeEntrega_TxtF011.CodClienteTercero = UcClienteTercero_xtF011.ItemActual.PNCPRVCL
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If fblnValidar() = False Then Return
            If _ACCION = "Update" Then
                If Me.ActualizarClientexZona() > 0 Then
                    MessageBox.Show("Registro Actualizado.")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error al Actualizado registro.")
                End If
            ElseIf _ACCION = "Insert" Then

                If Me.GuardarClientexZona() > 0 Then
                    MessageBox.Show("Registro agregado.")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    _ACCION = "Update"
                Else
                    MessageBox.Show("Ya Existe un Registro Con estos Datos : Notifique al Area de Sistemas ")
                    Me.LimpiarControl()
                End If
            Else
                MessageBox.Show("Este Camion ya existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Try
            UcPlantaDeEntrega_TxtF011.pClear()
            Me.LimpiarControl()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click

        If Me.txtLatitud.Text = "" Or Me.txtLongitud.Text = "" Then Exit Sub
        Dim objGpsBrowser As New frmMapa
        With objGpsBrowser
            .F5()
            .Latitud = txtLatitud.Text.Trim()
            .Longitud = txtLongitud.Text.Trim()
            .Cliente = Me.txtCliente.pRazonSocial
            .Fecha = Date.Now.ToString("dd/MM/yyyy")
            .Hora = Me.dtpHoraInicio.Value.ToString("HH:mm:ss")
            .WindowState = FormWindowState.Maximized
            .ShowForm(.Latitud, .Longitud, Me)
        End With

        'If txtLatitud.Text = String.Empty Or txtLongitud.Text = String.Empty Then
        '    MessageBox.Show("Ingrese Latitud y Longitud.", "Datos")
        'End If

        'Try
        '    Dim lat As String = String.Empty
        '    Dim lon As String = String.Empty

        '    Dim queryAddress As New StringBuilder()
        '    queryAddress.Append("http://maps.google.com/maps?q=")

        '    ' build latitude part of query string
        '    If txtLatitud.Text <> String.Empty Then
        '        lat = txtLatitud.Text
        '        queryAddress.Append(lat + "%2C")
        '    End If

        '    ' build longitude part of query string
        '    If txtLongitud.Text <> String.Empty Then
        '        lon = txtLongitud.Text
        '        queryAddress.Append(lon)
        '    End If

        '    webBrowser1.Navigate(queryAddress.ToString())

        'Catch ex As Exception

        '    MessageBox.Show(ex.Message.ToString(), "Error")

        'End Try
    End Sub

    Private Sub txtNumCorrelativo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCorrelativo.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

#End Region

End Class
