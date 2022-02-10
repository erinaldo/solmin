Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Public Class frmNuevoSeguimientoGPS
    Public obeInfoSeguimientoGPS As New SeguimientoGPS
    Public modificar As Boolean = False
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim oblSeguimientoGPS As New SeguimientoGPS_BLL
        Dim existencia As Int32 = 0
        Dim insertar As Boolean = False
        Dim retorno As Int32 = 0
        Dim mensaje As String = ""
        Try
            mensaje = Validar()
            If (mensaje <> "") Then
                MessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                ObtenerDatos()
                existencia = oblSeguimientoGPS.VerificarExistenciaSeguimientoRZTR11S(obeInfoSeguimientoGPS)
                If (existencia > 0) Then
                    If (MessageBox.Show("El registro ya existe. " & Chr(13) & "¿ Desea actualizar el registro? ", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                        insertar = True
                    End If
                Else
                    insertar = True
                End If
                If (insertar = True) Then
                    retorno = oblSeguimientoGPS.Insertar_Seguimiento_GPS(obeInfoSeguimientoGPS)
                    If (retorno = 0) Then
                        MessageBox.Show("No se pudo realizar la operación", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Se registró satisfactoriamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                  
                End If
            End If
        Catch ex As Exception
        End Try
        End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub ObtenerDatos()
        obeInfoSeguimientoGPS.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obeInfoSeguimientoGPS.CULUSA = MainModule.USUARIO
        obeInfoSeguimientoGPS.GPSLAT = txtLatitud.Text.Trim
        obeInfoSeguimientoGPS.GPSLON = txtLongitud.Text.Trim
        obeInfoSeguimientoGPS.KMSVEL = txtVelocidad.Text.Trim
        obeInfoSeguimientoGPS.FECGPS = dtFechaGPS.Value.ToString("yyyyMMdd")
        obeInfoSeguimientoGPS.HORA = HelpClass.ConvertHoraNumeric(Me.txtHoraRegistro.Text)
    End Sub
    Private Function Validar() As String
        Dim str As String = ""
        Dim mensajeVelocidad As String = ""
        mensajeVelocidad = "* Ingrese Velocidad válida." & Chr(13)
        mensajeVelocidad += "  (############.###)" & Chr(13)

        If (txtLatitud.Text.Trim = "") Then
            str = str & "* Ingrese Latitud." & Chr(13)
        Else
            If (Not IsNumeric(txtLatitud.Text.Trim)) Then
                str = str & "* Ingrese Latitud válida." & Chr(13)
            End If
        End If
        If (txtLongitud.Text.Trim = "") Then
            str = str & "* Ingrese Longitud." & Chr(13)
        Else
            If (Not IsNumeric(txtLongitud.Text.Trim)) Then
                str = str & "* Ingrese Longitud válida." & Chr(13)
            End If
        End If
        If (txtVelocidad.Text.Trim = "") Then
            str = str & "* Ingrese Velocidad." & Chr(13)
        Else
            If (Not IsNumeric(txtVelocidad.Text.Trim)) Then
                str = str & mensajeVelocidad             
            Else
                Dim numero As String = ""
                numero = txtVelocidad.Text.Trim
                Dim ArrayNumero() As String = numero.Split(".")
                If (ArrayNumero(0).Length > 12) Then                    
                    str = str & mensajeVelocidad
                Else
                    If (ArrayNumero.Length > 1) Then
                        If (ArrayNumero(1).Length > 3) Then
                          str = str & mensajeVelocidad
                        End If
                    End If
                End If
            End If
        End If
        If Not IsDate(Me.txtHoraRegistro.Text) OrElse Me.txtHoraRegistro.Text = "00:00:00" Then
            str += "* Ingrese Hora válida " & Chr(13)
        End If
        Return str
    End Function

    Private Sub frmNuevoSeguimientoGPS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (modificar = False) Then
                txtLatitud.Text = ""
                txtLongitud.Text = ""
                txtVelocidad.Text = ""
                dtFechaGPS.Enabled = True
                txtHoraRegistro.Enabled = True
            Else
                dtFechaGPS.Value = HelpClass.CNumero8Digitos_a_Fecha(obeInfoSeguimientoGPS.FECGPS)
                txtLatitud.Text = obeInfoSeguimientoGPS.GPSLAT.Trim
                txtLongitud.Text = obeInfoSeguimientoGPS.GPSLON.Trim
                txtVelocidad.Text = obeInfoSeguimientoGPS.KMSVEL
                txtHoraRegistro.Text = HelpClass.ConvertHoraNumeric(obeInfoSeguimientoGPS.HORA_S)
                dtFechaGPS.Enabled = False
                txtHoraRegistro.Enabled = False
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtLatitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLatitud.KeyPress
      
        If e.KeyChar = "-" Then
            e.Handled = False
        Else
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        End If

    End Sub

    Private Sub txtLongitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLongitud.KeyPress

        If e.KeyChar = "-" Then
            e.Handled = False
        Else
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        End If
        '  If HelpClass.Numero(txtLongitud.Text.Trim, True, 12, 3, CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtVelocidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVelocidad.KeyPress

        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class
