Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.TypeDef.UbicacionPlanta.Division
Imports Ransa.Negocio.UbicacionPlanta.Division
Imports Ransa.DAO.UbicacionPlanta.Division

Public Class frmAnularValorizacion
    Private oValorizacion As beMantValorizacion
    Public _pbeValorizacion As New beMantValorizacion
    Public Property pbeValorizacion() As beMantValorizacion
        Get
            Return _pbeValorizacion
        End Get
        Set(ByVal value As beMantValorizacion)
            _pbeValorizacion = value
        End Set
    End Property

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion

            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

            oValorizacion.CCMPN = pbeValorizacion.CCMPN
            oValorizacion.NROVLR = pbeValorizacion.NROVLR
            oValorizacion.OBSAVL = txtObservacionAnulacion.Text.Trim
            oValorizacion.NTRMNL = HelpClass.NombreMaquina
            oValorizacion.CULUSA = ConfigurationWizard.UserName

            sErrorMesage = obrValorizacion.Anular_MantValorizacion(oValorizacion)

        

            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("La valorización fue anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
           

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


End Class
