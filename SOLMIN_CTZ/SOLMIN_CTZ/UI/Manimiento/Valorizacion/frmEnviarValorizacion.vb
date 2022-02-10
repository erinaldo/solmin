Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
'Imports Ransa.TypeDef.UbicacionPlanta.Division
'Imports Ransa.Negocio.UbicacionPlanta.Division
'Imports Ransa.DAO.UbicacionPlanta.Division

Public Class frmEnviarValorizacion
    Private oValorizacion As beMantValorizacion
    Public pbeValorizacion As New beMantValorizacion
    

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmEnviarValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Habilitar As Boolean = False
        Try
            txtdocseg.Text = pbeValorizacion.NROSGV
            dtpFechaEnvio.Text = DateTime.Now 'DateTime.Now.ToString("dd/MM/yyyy")
            txtHoraEnvio.Text = Now.ToString("HH:mm") ' String.Format("{0:HH:mm:ss}", DateTime.Now)
            txtEnvio.Text = pbeValorizacion.NCRRDE
            CargarAreaDestino()
            CargarAprobador()

            If pbeValorizacion.NCRRDE > 0 Then
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
                    dtpFechaEnvio.Value = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(dtEnvio.Rows(0)("FCHASG"))
                    txtHoraEnvio.Text = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(dtEnvio.Rows(0)("HRAASG"))
                    cboAreaDestino.SelectedValue = dtEnvio.Rows(0)("ARADST").ToString.Trim
                    txtaprobador.Text = dtEnvio.Rows(0)("DESTAP").ToString.Trim
                    txtObservacion.Text = dtEnvio.Rows(0)("TOBS").ToString.Trim
                    If dtEnvio.Rows(0)("FLGAPR") = "A" Then
                        Habilitar = False
                    Else
                        Habilitar = True
                    End If
                    dtpFechaEnvio.Enabled = Habilitar
                    txtHoraEnvio.Enabled = Habilitar
                    cboAreaDestino.ComboBox.Enabled = Habilitar
                    txtaprobador.Enabled = Habilitar
                    txtObservacion.Enabled = Habilitar
                    btnGuardar.Enabled = Habilitar

                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub CargarAreaDestino()
        'Dim oListColum As New Hashtable
        Dim oListbeAyudaGeneral As New List(Of beAyudaGeneral)
        Dim blclsAyudaGeneral As New SOLMIN_CTZ.NEGOCIO.clsAyudaGeneral
        oListbeAyudaGeneral = blclsAyudaGeneral.ListaTablaAyudaGeneral("ARADST", "")
        Dim obeAyudaGeneral As New beAyudaGeneral

        obeAyudaGeneral.PSCODIGO = "0"
        obeAyudaGeneral.PSDESCRIPCION = "::Seleccione::"
        oListbeAyudaGeneral.Insert(0, obeAyudaGeneral)
        cboAreaDestino.DataSource = oListbeAyudaGeneral
        cboAreaDestino.ValueMember = "PSCODIGO"
        cboAreaDestino.DisplayMember = "PSDESCRIPCION"
        cboAreaDestino.SelectedValue = "0"

      
    End Sub

    Public Sub CargarAprobador()
        Dim dt As New DataTable
        Dim oCorreoValoriz As New beCorreoValorizacion
        Dim oListbeCorreoValorizacion As New List(Of beCorreoValorizacion)
        Dim obrCorreoValoriz As New clsDestiCorreoValorizacion
        'Dim dt As New DataTable
        oCorreoValoriz.CCLNT = pbeValorizacion.CCLNT
        oCorreoValoriz.NLTECL = "CT_VALORIZ"
        dt = obrCorreoValoriz.ListarConfCierreValorizacion(oCorreoValoriz)
        For Each item As DataRow In dt.Rows
            oCorreoValoriz = New beCorreoValorizacion
            oCorreoValoriz.NCRRIT = item("NCRRIT")
            oCorreoValoriz.TNMYAP = item("NOMBRE")
            oListbeCorreoValorizacion.Add(oCorreoValoriz)
        Next


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "NCRRIT"
        oColumnas.DataPropertyName = "NCRRIT"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TNMYAP"
        oColumnas.DataPropertyName = "TNMYAP"
        oColumnas.HeaderText = "Nombre"
        oListColum.Add(2, oColumnas)

        If oListbeCorreoValorizacion.Count > 0 Then
            cboAprobadores.DataSource = oListbeCorreoValorizacion
        Else
            cboAprobadores.DataSource = Nothing
        End If
        cboAprobadores.ListColumnas = oListColum
        cboAprobadores.Cargas()
        cboAprobadores.Limpiar()
        cboAprobadores.ValueMember = "NCRRIT"
        cboAprobadores.DispleyMember = "TNMYAP"

    End Sub
 
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""

            Dim sStatus As String = ""
            Dim HoraFormat As String = ""
            Dim obeAyudaGeneral As New beAyudaGeneral
            'If cboAreaDestino.SelectedValue = "R" Then

            '    If txtaprobador.Text = "" Then
            '        MessageBox.Show("Seleccione aprobador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'End If
            If txtaprobador.Text = "" Then
                MessageBox.Show("Seleccione aprobador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim lstr_validacion As String = ""
            If txtHoraEnvio.Text.Trim = "00:00" Then
                lstr_validacion += "* Ingresar hora" & Chr(13)
            End If

            If cboAreaDestino.SelectedValue = "0" Then
                lstr_validacion += "* Seleccione destino envío" & Chr(13)
            End If


            Dim Hora As Date
            If DateTime.TryParse(txtHoraEnvio.Text.Trim, Hora) = False Then
                lstr_validacion += "* Validar una hora correcta" & Chr(13)
            End If
            If lstr_validacion.Length > 0 Then
                MessageBox.Show(lstr_validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            HoraFormat = txtHoraEnvio.Text.Trim & ":00"

          

            oValorizacion.CCMPN = pbeValorizacion.CCMPN
            oValorizacion.NROVLR = pbeValorizacion.NROVLR
            oValorizacion.NROSGV = Val(pbeValorizacion.NROSGV)
            oValorizacion.NCRRDE = Val(txtEnvio.Text)

            oValorizacion.FCHASG = dtpFechaEnvio.Value.ToString("yyyyMMdd")
            oValorizacion.HRAASG = Ransa.Utilitario.HelpClass.ConvertHoraNumeric(HoraFormat)

            oValorizacion.DESTAP = txtaprobador.Text.Trim
            oValorizacion.ARADST = cboAreaDestino.SelectedValue
            oValorizacion.TOBS = txtObservacion.Text.Trim

            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            dtTransaccion = obrValorizacion.RegistrarEnvioValorizacion(oValorizacion)

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
              
            Next
            sErrorMesage = sErrorMesage.Trim

            If sErrorMesage.Length > 0 Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Valorización con envío asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
          
            Dim obrValorizacion As New clsMantValorizacion
            Dim strValidacion As String = ""
            Dim obeMantValorizacion As New beMantValorizacion
            obeMantValorizacion.CCMPN = pbeValorizacion.CCMPN
            obeMantValorizacion.NROVLR = pbeValorizacion.NROVLR
            obeMantValorizacion.CCLNT = pbeValorizacion.CCLNT
            obeMantValorizacion.NROSGV = pbeValorizacion.NROSGV
            obeMantValorizacion.NCRRDE = pbeValorizacion.NCRRDE
            strValidacion = obrValorizacion.ValidarGeneracionEnvio(obeMantValorizacion)
            If strValidacion.Length > 0 Then
                MessageBox.Show(strValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            txtObservacion.Text = ""
            txtEnvio.Text = "0"
            txtaprobador.Text = ""
            btnGuardar.Enabled = True
            dtpFechaEnvio.Enabled = True
            txtHoraEnvio.Enabled = True
            cboAreaDestino.ComboBox.Enabled = True
            cboAreaDestino.SelectedValue = "0"
            txtObservacion.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try
    End Sub

    Private Sub cboAprobadores_CambioDeTexto(objData As Object) Handles cboAprobadores.CambioDeTexto
        Try
            Dim oCorreoValoriz As New beCorreoValorizacion
            If cboAprobadores.Resultado IsNot Nothing Then
                oCorreoValoriz = CType(cboAprobadores.Resultado, beCorreoValorizacion)
                txtaprobador.Text = oCorreoValoriz.TNMYAP
            End If
        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
        End Try

    End Sub

    'Private Sub cboAreaDestino_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboAreaDestino.SelectionChangeCommitted
    '    Try
    '        If cboAreaDestino.SelectedValue = "C" Then
    '            cboAprobadores.Enabled = False
    '            txtaprobador.Text = ""
    '        Else
    '            cboAprobadores.Enabled = True
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error) 'RCS-HUNDRED
    '    End Try
    'End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
