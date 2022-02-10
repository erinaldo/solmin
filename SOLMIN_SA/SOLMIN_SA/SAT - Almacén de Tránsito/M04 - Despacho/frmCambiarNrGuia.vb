Imports Ransa.TYPEDEF
Imports Ransa.NEGO.DespachoSAT
Public Class frmCambiarNrGuia

    Public PNNGUIRM As Decimal = 0

    'Private _PNNGUIRM As Decimal
    'Public Property PNNGUIRM() As Decimal
    '    Get
    '        Return _PNNGUIRM
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNNGUIRM = value
    '    End Set
    'End Property

    Public PNCCLNT As Decimal = 0

    'Private _PNCCLNT As Decimal
    'Public Property PNCCLNT() As Decimal
    '    Get
    '        Return _PNCCLNT
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNCCLNT = value
    '    End Set
    'End Property
    Public pCTDGRM As String = ""

    Private Sub frmCambiarNrGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.txtNroGuiaRemision.Focus()

            Dim dt_tipoGR As New DataTable
            Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL
            dt_tipoGR = objAyuda.fdtListar_TablaAyuda_L01("TPOGRM", "")
            cboTipoGR.DataSource = dt_tipoGR
            cboTipoGR.DisplayMember = "TDSDES"
            cboTipoGR.ValueMember = "CCMPRN"
            cboTipoGR.SelectedValue = pCTDGRM
            cboTipoGR.Enabled = False

            cboTipoGR_SelectionChangeCommitted(cboTipoGR, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.txtNroGuiaRemision.Text.ToString.Equals("") Then
                MessageBox.Show("Ingrese el numero de guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
                'ElseIf txtNroGuiaRemision.Text <> "" And txtNroGuiaRemision.Text.Length <> 10 Then
                '    MessageBox.Show(" El Nro. de la Guía de Remisión es de 10 dígitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
            End If

            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Dim msg_val_guia As String = ""
            Select Case tipo
                Case "F"
                    If txtNroGuiaRemision.Text.Length <> 10 Then _
                      msg_val_guia &= "- El Nro. de la Guía de Remisión es de 10 dígitos" & vbNewLine
                Case "E"
                    If txtNroGuiaRemision.Text.Length <> 12 Then _
                        msg_val_guia &= "- El Nro. de la Guía de Remisión es de 12 dígitos" & vbNewLine
            End Select
            If msg_val_guia.Length > 0 Then
                MessageBox.Show(msg_val_guia, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Select Case tipo
                Case "F"
                    Dim GuiaFinal As Decimal = Me.txtNroGuiaRemision.Text.Trim
                    Dim GuiaInicial As Decimal = PNNGUIRM
                    If GuiaInicial = GuiaFinal Then
                        MessageBox.Show("La Guía final debe ser diferente a la Guía Inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                Case "E"

            End Select


            Dim obeFiltroGuia As New beGuiaRemision
            Dim obrGuia As New brGuiasRemision
            Dim message As String
            obeFiltroGuia.PNCCLNT = PNCCLNT
            obeFiltroGuia.PSNGUIRM = Me.txtNroGuiaRemision.Text.Trim
            obeFiltroGuia.PNNGUIRO = PNNGUIRM
            obeFiltroGuia.PSCULUSA = objSeguridadBN.pUsuario

            obeFiltroGuia.PSCTDGRM = pCTDGRM

            'message = obrGuia.cambiarNumeroGuia(obeFiltroGuia)
            message = obrGuia.cambiarNumeroGuia_s(obeFiltroGuia)

            If message.Equals("") Then
                MessageBox.Show("Se cambió el numero de guia correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else 'If message.Equals("Error") Then
                '    MessageBox.Show("ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Else
                '    MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
     
    End Sub
    'Private Sub txtNroGuiaRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuiaRemision.KeyPress
    '    If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
    '        e.KeyChar = ""
    '    End If
    'End Sub

    Private Sub cboTipoGR_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoGR.SelectionChangeCommitted
        Try
            Dim tipo As String = ("" & cboTipoGR.SelectedValue).ToString.Trim
            Select Case tipo
                Case "F"
                    txtNroGuiaRemision.Mask = "000-0000000"
                Case "E"
                    txtNroGuiaRemision.Mask = "LAAA-00000000" ' Primera caracter : Letra / 3 caracteres alfanumerico/ 8 numericos
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub
End Class
