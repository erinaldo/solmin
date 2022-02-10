Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
'Imports Ransa.TypeDef.UbicacionPlanta.Division
'Imports Ransa.Negocio.UbicacionPlanta.Division
'Imports Ransa.DAO.UbicacionPlanta.Division

Public Class frmAprobarNroValorizacion
    Private oValorizacion As beMantValorizacion
    Public pbeValorizacion As New beMantValorizacion
    Public pDialogResult As Boolean = False

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub CargarDatos()
        txtFechaEnvio.Text = pbeValorizacion.FCHASG
        txtHoraEnvio.Text = pbeValorizacion.HRAASG
        txtDestino.Text = pbeValorizacion.DESTAP
        txtAprobador.Text = pbeValorizacion.ARADST
        Dim Habilitar As Boolean = False

        dtpFechaAprobacion.Value = DateTime.Now.ToString("dd/MM/yyyy")
        txtHoraAprobacion.Text = Now.ToString("HH:mm")



        Dim oListbeAyudaGeneral As New List(Of beAyudaGeneral)
        Dim blclsAyudaGeneral As New SOLMIN_CTZ.NEGOCIO.clsAyudaGeneral
        oListbeAyudaGeneral = blclsAyudaGeneral.ListaTablaAyudaGeneral("SDAPEN", "")
        Dim obeAyudaGeneral As New beAyudaGeneral
        obeAyudaGeneral.PSCODIGO = "0"
        obeAyudaGeneral.PSDESCRIPCION = "::Seleccione::"
        oListbeAyudaGeneral.Insert(0, obeAyudaGeneral)

        cboEstado.DataSource = oListbeAyudaGeneral
        cboEstado.ValueMember = "PSCODIGO"
        cboEstado.DisplayMember = "PSDESCRIPCION"
        cboEstado.SelectedValue = "0"


        Dim obrValorizacion As New clsMantValorizacion
        Dim dtEnvio As New DataTable
        Dim obeMantValorizacion As New beMantValorizacion
        obeMantValorizacion.CCMPN = pbeValorizacion.CCMPN
        obeMantValorizacion.NROVLR = pbeValorizacion.NROVLR
        obeMantValorizacion.CCLNT = pbeValorizacion.CCLNT
        obeMantValorizacion.NROSGV = pbeValorizacion.NROSGV
        obeMantValorizacion.NCRRDE = pbeValorizacion.NCRRDE
        dtEnvio = obrValorizacion.ListarEnvioValorizacion(obeMantValorizacion)
        If dtEnvio.Rows.Count > 0 Then
            txtFechaEnvio.Text = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(dtEnvio.Rows(0)("FCHASG"))
            txtHoraEnvio.Text = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(dtEnvio.Rows(0)("HRAASG"))
            txtDestino.Text = dtEnvio.Rows(0)("DESC_DST").ToString.Trim
            txtAprobador.Text = dtEnvio.Rows(0)("DESTAP").ToString.Trim
            If dtEnvio.Rows(0)("FLGAPR").ToString.Trim <> "" Then
                cboEstado.SelectedValue = dtEnvio.Rows(0)("FLGAPR").ToString.Trim
            End If
            If dtEnvio.Rows(0)("FCHAPR") > 0 Then
                dtpFechaAprobacion.Value = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(dtEnvio.Rows(0)("FCHAPR"))
            End If
            If dtEnvio.Rows(0)("HRAAPR") > 0 Then
                txtHoraAprobacion.Text = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(dtEnvio.Rows(0)("HRAAPR"))
            End If
            txtObservacionAprobacion.Text = dtEnvio.Rows(0)("TOBSER").ToString.Trim

            If dtEnvio.Rows(0)("FLGAPR") = "A" Then
                Habilitar = False
                btnGuardar.Enabled = False
            Else
                Habilitar = True
                btnGuardar.Enabled = True
            End If

            cboEstado.ComboBox.Enabled = Habilitar
            dtpFechaAprobacion.Enabled = Habilitar
            txtHoraAprobacion.Enabled = Habilitar
            txtObservacionAprobacion.Enabled = Habilitar


        End If
    End Sub

    Private Sub frmAprobarNroValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CargarDatos()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
      

    End Sub
 

    
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
          
            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion

            Dim sErrorMesage As String = ""

            Dim sStatus As String = ""

            Dim lstr_validacion As String = ""
            If txtHoraAprobacion.Text.Trim = "00:00" Then
                lstr_validacion += "* Ingresar hora" & Chr(13)
            End If
            Dim hraAprob As Date
            If DateTime.TryParse(txtHoraAprobacion.Text.Trim, hraAprob) = False Then
                lstr_validacion += "* Validar una hora correcta" & Chr(13)
            End If
            If cboEstado.SelectedValue = "0" Then
                lstr_validacion += "* Seleccione estado." & Chr(13)
            End If
            If lstr_validacion.Length > 0 Then
                MessageBox.Show(lstr_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cboEstado.SelectedValue = "R" Then
                If MessageBox.Show("El envío será rechazado , ¿ está seguro de la acción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            Dim HoraAprobacion As String = txtHoraAprobacion.Text
            HoraAprobacion = HoraAprobacion & ":00"

            oValorizacion.CCMPN = pbeValorizacion.CCMPN
            oValorizacion.NROVLR = pbeValorizacion.NROVLR
            oValorizacion.NROSGV = Val(pbeValorizacion.NROSGV)
            oValorizacion.NCRRDE = pbeValorizacion.NCRRDE

            oValorizacion.FCHAPR = dtpFechaAprobacion.Value.ToString("yyyyMMdd")
            oValorizacion.HRAAPR = Ransa.Utilitario.HelpClass.ConvertHoraNumeric(HoraAprobacion)
            oValorizacion.TOBSER = txtObservacionAprobacion.Text.Trim

            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            oValorizacion.FLGAPR = cboEstado.SelectedValue

            sErrorMesage = obrValorizacion.RegistrarAprobacionValorizacion(oValorizacion)
         
            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Envío " & cboEstado.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pDialogResult = True
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
      
    End Sub


    'Private Sub btnAnularAprob_Click(sender As Object, e As EventArgs) Handles btnAnularAprob.Click
    '    Try
    '        Dim RequiereAutorizacion As Boolean = False
    '        Dim oValorizacion As New beMantValorizacion
    '        Dim obrValorizacion As New clsMantValorizacion
    '        Dim msg As String = ""
    '        oValorizacion.CCMPN = pbeValorizacion.CCMPN
    '        oValorizacion.NROVLR = pbeValorizacion.NROVLR
    '        oValorizacion.NROSGV = Val(pbeValorizacion.NROSGV)
    '        oValorizacion.NCRRDE = pbeValorizacion.NCRRDE
    '        oValorizacion.CULUSA = ConfigurationWizard.UserName
    '        oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '        oValorizacion.AUTORIZADO = ""
    '        msg = obrValorizacion.AnularAprobacionValorizacion(oValorizacion, RequiereAutorizacion)

    '        If RequiereAutorizacion = True Then
    '            Dim dtUsuarioAutorizado As New DataTable
    '            dtUsuarioAutorizado = obrValorizacion.ListarUsuarioValorizacionAnulacion
    '            If dtUsuarioAutorizado.Rows.Count > 0 Then
    '                oValorizacion.CCMPN = pbeValorizacion.CCMPN
    '                oValorizacion.NROVLR = pbeValorizacion.NROVLR
    '                oValorizacion.NROSGV = Val(pbeValorizacion.NROSGV)
    '                oValorizacion.NCRRDE = pbeValorizacion.NCRRDE
    '                oValorizacion.CULUSA = ConfigurationWizard.UserName
    '                oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '                oValorizacion.AUTORIZADO = "S"
    '                msg = obrValorizacion.AnularAprobacionValorizacion(oValorizacion, RequiereAutorizacion)
    '            Else
    '                msg = "No cuenta con autorización para anular envíos aprobados cliente."
    '            End If
    '        End If

    '        If msg.Length > 0 Then
    '            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'RCS-HUNDRED
    '        Else
    '            pDialogResult = True
    '            CargarDatos()
    '            MessageBox.Show("Aprobación anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'RCS-HUNDRED
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
    '    End Try
    'End Sub
End Class
