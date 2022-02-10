Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap

Public Class frmInformacionRegistroWAP

#Region "Atributos"

    Private objRegistroWAP As New RegistroWAP

#End Region
   
    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Private Sub frmInformacionRegistroWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objLogica1 As New SeguimientoWAP_BLL
            Me.txtCiclo.Text = objRegistroWAP.CICLO
            Me.dtpFechaRegistro.Value = CType(objRegistroWAP.FRGTRO, Date)
            Me.txtHoraRegistro.Text = objRegistroWAP.HRGTRO

            objRegistroWAP = objLogica1.Obtener_Info_RegistroWAP(objRegistroWAP)
            Me.txtObservacion.Text = objRegistroWAP.TOBS

            Dim objLogica2 As New SeguimientoWAP_BLL
            Me.txtNombre.Text = objLogica2.Obtener_Informacion_Registro_Wap(objRegistroWAP).USUARI

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
