Imports RANSA.TypeDef
Imports RANSA.NEGO
'Imports Ransa.TypeDef.Cliente
Public Class frmMantenimientoSerie

#Region "Atributos"

#End Region

#Region "Variables"
    Public ActualizarDatos As Boolean = False
    Public obeInfoserie As New Ransa.Controls.Serie.beSerie
#End Region

#Region "Metodos y Funciones"

    Private Sub VisualizarDatosSerie()
        LimpiarControles()
        txtOS.Text = obeInfoserie.PNNORDSR
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(obeInfoserie.PNCCLNT, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        If (ActualizarDatos = True) Then
            txtModelo.Text = obeInfoserie.PSTDSMDL.Trim
            txtObservacion.Text = obeInfoserie.PSTOBSRV.Trim
            txtSerie.Text = obeInfoserie.PSCSRECL.Trim
        End If
    End Sub

    Private Sub LimpiarControles()
        txtOS.Text = ""
        txtCliente.pClear()
        txtModelo.Text = ""
        txtObservacion.Text = ""
        txtSerie.Text = ""
    End Sub

    Private Function ValidarDatos() As String
        Dim strmensaje As String = ""
        txtSerie.Text = txtSerie.Text.Trim
        If (txtSerie.Text = "") Then
            strmensaje = " Debe de ingresar la serie"
        End If
        Return strmensaje
    End Function

    Private Function ObtenerDatosSerie() As Ransa.Controls.Serie.beSerie
        Dim obeSerie As New Ransa.Controls.Serie.beSerie
        obeSerie.PNNORDSR = obeInfoserie.PNNORDSR
        obeSerie.PSCSRECL = txtSerie.Text.Trim
        obeSerie.PSCSRECL_ANT = obeInfoserie.PSCSRECL_ANT.Trim
        obeSerie.PNCCLNT = obeInfoserie.PNCCLNT
        obeSerie.PSTDSMDL = txtModelo.Text.Trim
        obeSerie.PSTOBSRV = txtObservacion.Text.Trim
        obeSerie.PSCUSCRT = objSeguridadBN.pUsuario
        obeSerie.PSCULUSA = objSeguridadBN.pUsuario
        obeSerie.PNNCRPLL = obeInfoserie.PNNCRPLL
        Return obeSerie
    End Function

#End Region

#Region "Eventos"

    Private Sub frmMantenimientoSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOS.Enabled = False
        txtCliente.Enabled = False
        dteFecha.Enabled = False
        VisualizarDatosSerie()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim mensaje As String = ""
        Dim obrSerie As New brSerieMercaderia()
        Dim obeSerie As New Ransa.Controls.Serie.beSerie
        mensaje = ValidarDatos()
        If (mensaje <> "") Then
            MessageBox.Show(mensaje, "Validación Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mensaje = ""
        mensaje = "No se puede realizar la operación." & Chr(13)
        mensaje = mensaje & "La serie ingresada se encuentra en inventario. " & Chr(13)
        mensaje = mensaje & "Verifique la serie."
        If (ActualizarDatos = True) Then
            obeSerie = obrSerie.ActualizarSerie(ObtenerDatosSerie())
            If (obeSerie.CREACION.ToUpper = "EXIST") Then
                MessageBox.Show(mensaje, "Actualización Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (obeSerie.CREACION.ToUpper = "UPD") Then
                MessageBox.Show("La operación se relizó con éxito.", "Actualización Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("No se pudo realizar la operación.", "Actualización Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            obeSerie = obrSerie.RegistrarSerie(ObtenerDatosSerie())
            If (obeSerie.CREACION.ToUpper = "EXIST") Then
                MessageBox.Show(mensaje, "Registro Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (obeSerie.CREACION.ToUpper = "INS") Then
                MessageBox.Show("La operación se relizó con éxito.", "Registro Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("No se pudo realizar la operación.", "Registro Serie", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class
