Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Utility

Public Class frmActivacionConductor

    Private _AccionRealizada As Boolean = False
    Public Property AccionRealizada() As Boolean
        Get
            Return _AccionRealizada
        End Get
        Set(ByVal value As Boolean)
            _AccionRealizada = True
        End Set
    End Property

    Private obeRecordGeneral As New RecordGeneral()
    Public Sub ShowForm(ByVal oRecordGeneral As RecordGeneral, ByVal owner As IWin32Window)

        Try
            obeRecordGeneral = oRecordGeneral
            If (obeRecordGeneral.ESTADOABR.ToUpper() = "A") Then
                txtEstado.Text = "A - Activación"
            Else
                txtEstado.Text = "I - Inactivación"
            End If
            txtFecha.Text = RetornaFecha()
            txtBrevete.Text = obeRecordGeneral.BRCNT
            txtApellidoPaterno.Text = obeRecordGeneral.TAPPAC
            txtApellidoMaterno.Text = obeRecordGeneral.TAPMAC
            txtNombres.Text = obeRecordGeneral.TNMCMC


            txtObservacion.Text = String.Empty
            Me.ShowDialog(owner)

        Catch : End Try

    End Sub
    Private Sub frmActivacionConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HabilitarEdicion(True)
        txtObservacion.Focus()
    End Sub
    Private Sub HabilitarEdicion(ByVal habilitar As Boolean)
        txtEstado.Enabled = False
        txtFecha.Enabled = False
        txtObservacion.Enabled = habilitar
        txtBrevete.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oRecordGeneralBLL As New RecordGeneral_BLL()
        Try
            Me.AccionRealizada = False
            obeRecordGeneral.TOBSMD = txtObservacion.Text.Trim().ToUpper()
            oRecordGeneralBLL.Registrar_Record_General_Inactivacion_Reactivacion(obeRecordGeneral)

            If (obeRecordGeneral.ESTADOABR.ToUpper() = "I") Then
                Dim objEntidad As New Chofer
                Dim objChofer As New Chofer_BLL
                objEntidad.CBRCNT = obeRecordGeneral.CBRCNT
                objEntidad.CULUSA = obeRecordGeneral.CULUSA
                objEntidad.FULTAC = obeRecordGeneral.FULTAC
                objEntidad.HULTAC = obeRecordGeneral.HULTAC
                objEntidad.NTRMNL = obeRecordGeneral.NTRMNL
                objEntidad.CCMPN = obeRecordGeneral.CCMPN
                objEntidad = objChofer.Eliminar_Chofer(objEntidad)
            End If
            Me.AccionRealizada = True
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
