Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES

Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Imports System.Text

Imports System.Threading
Public Class frmEditarFechaHoraAtencionServicio

    Public pNOPRCN As Decimal = 0
    Public pFATNSR As String = ""  
    Public pHATNSR As String = ""
    Public pCCMPN As String = ""
    Public pNGUITR As Decimal = 0
    Public pCTRMNC As Decimal = 0
 


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim hora_inicio As Decimal = (txtHoraInicio.Text.Replace(":", "").Trim & "00").PadLeft(6, "0")

           
            If hora_inicio = 0 Then
                MessageBox.Show("Aviso", "Ingresar una Hora", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim hrainicio As Date
            If hora_inicio > 0 Then
                If DateTime.TryParse(Me.txtHoraInicio.Text, hrainicio) = False Then
                    MessageBox.Show("Ingrese hora atención correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If


            ' Actualizar FATNSR y HATNSR en RZTR05 (Operación)

            Dim objOperacionTransporte As New OperacionTransporte_BLL
           

            Dim msg As String = ""
            Dim beOp As New ENTIDADES.Operaciones.OperacionTransporte
            beOp.NOPRCN = pNOPRCN
            beOp.FATNSR = HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
            beOp.HATNSR = hora_inicio
            beOp.CULUSA = MainModule.USUARIO
            beOp.CCMPN = pCCMPN
            msg = objOperacionTransporte.Actualizar_Fecha_Hora_Atencion_Servicio_Operacion(beOp)
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            If hora_inicio > 0 Then
                Dim objHito As New HitoOperacion
                Dim objLogicaHito As New ControlHitos_BLL

                With objHito
                    .NOPRCN = pNOPRCN
                    .NGUIRM = pNGUITR
                    .CTRMNC = pCTRMNC
                    .FRETES = HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
                    .HRAREA = hora_inicio
                    .CUSCRT = MainModule.USUARIO
                    .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                End With
                msg = objLogicaHito.RegistrarHito_Actualizacion(objHito)
                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmEditarFechaHoraAtencionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ListaUsuarios As New List(Of ENTIDADES.Operaciones.TipoDatoGeneral)
            Dim obj As New TipoDatoGeneral_BLL
            Dim User As String = MainModule.USUARIO
            ListaUsuarios = obj.Lista_Tipo_Dato_General(pCCMPN, "USATSR")

            For Each Usuario As ENTIDADES.Operaciones.TipoDatoGeneral In ListaUsuarios
                If Usuario.CODIGO_TIPO.Trim() = User Then
                    btnAceptar.Enabled = True
                End If
            Next

            'Me.dtpFechaAtencionServicio.Text = HelpClass.CNumero_a_Fecha(FATNSR)
            Me.dtpFechaAtencionServicio.Text = pFATNSR
            Me.txtHoraInicio.Text = pHATNSR

            'If pHATNSR.Trim = "" Then
            '    Me.txtHoraAtencionServicio.Text = "00:00"
            'Else
            '    Me.txtHoraAtencionServicio.Text = pHATNSR
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

      
    End Sub
End Class
