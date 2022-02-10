Imports RANSA.TypeDef
Imports RANSA.NEGO
Public Class frmMantenimientoRutas

#Region "Atrinutos"
    Private oEntidad As beMaestroRuta
    Public BuscarDatosDefault As Boolean = False
    Private _ACCION As String
    Private _CRUTAT As String
    Private _TABRUT As String
    Public Property CRUTAT() As String
        Get
            Return _CRUTAT
        End Get
        Set(ByVal value As String)
            _CRUTAT = value
        End Set
    End Property

    Public Property TABRUT() As String
        Get
            Return _TABRUT
        End Get
        Set(ByVal value As String)
            _TABRUT = value
        End Set
    End Property


#End Region

#Region "Metodos y Funciones"

    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtCodigoRuta.Enabled = bValor
        txtdescripcionRuta.Enabled = bValor
    End Sub

    Private Function ValidarIngreso() As String
        Dim str As String = ""
        If (txtCodigoRuta.Text.Trim = "") Then
            str = " Debe ingresar el Codigo de Zona" & Chr(13)
        End If
        If (txtdescripcionRuta.Text.Trim = "") Then
            str = " Debe ingresar la descripción de la Zona" & Chr(13)
        End If
        Return str
    End Function

    Private Sub fnBuscarRutas()
        If Me.txtCodigoRuta.Text.Trim <> String.Empty Then
            Dim CRUTAT As String = Me.txtCodigoRuta.Text.Trim
            Dim objbeMaestroRutas As beMaestroRuta = (New brMaestroRuta).ListarxCodigoRuta(CRUTAT)
            If objbeMaestroRutas Is Nothing Then
                Me.txtdescripcionRuta.Text = String.Empty
                Me.txtCodigoRuta.Enabled = True
                _ACCION = "Insert"
            Else
                oEntidad = New beMaestroRuta
                oEntidad = objbeMaestroRutas
                Me.txtCodigoRuta.Text = oEntidad.PSCRUTAT.ToString.Trim
                Me.txtdescripcionRuta.Text = oEntidad.PSTABRUT.ToString.Trim
                Me.txtCodigoRuta.Enabled = False
                _ACCION = "Update"
            End If
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMantenimientoRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            Me.txtCodigoRuta.Text = CRUTAT
            fnBuscarRutas()
        End If
    End Sub

    Private Sub txtCodigoRuta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoRuta.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            fnBuscarRutas()
        ElseIf e.KeyCode = Keys.Tab Then
            e.Handled = True
            fnBuscarRutas()
        End If
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If ValidarIngreso() <> "" Then Return
            If _ACCION = "Update" Then
                With oEntidad
                    .PSCRUTAT = Me.txtCodigoRuta.Text.Trim
                    .PSTABRUT = Me.txtdescripcionRuta.Text.Trim
                    .PNFULTAC = 0
                    .PNHULTAC = 0
                    .PSCULUSA = objSeguridadBN.pUsuario
                    .PSSESTRG = "A"
                    .PNUPDATE_IDENT = .PNUPDATE_IDENT + 1
                End With
                If (New brMaestroRuta).Actualizar(oEntidad) Then
                    MessageBox.Show("Registro modificado.")
                    _CRUTAT = oEntidad.PSCRUTAT
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error al modificar registro.")
                End If
            ElseIf _ACCION = "Insert" Then
                oEntidad = New beMaestroRuta
                With oEntidad

                    .PSCRUTAT = Me.txtCodigoRuta.Text.Trim
                    .PSTABRUT = Me.txtdescripcionRuta.Text.Trim
                    .PNFULTAC = 0
                    .PNHULTAC = 0
                    .PSCULUSA = objSeguridadBN.pUsuario
                    .PSSESTRG = "A"
                    .PNUPDATE_IDENT = 1
                End With
                If (New brMaestroRuta).Insertar(oEntidad) > 0 Then
                    MessageBox.Show("Registro agregado.")
                    _CRUTAT = oEntidad.PSCRUTAT
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    _ACCION = "Update"
                Else
                    MessageBox.Show("Error al agregar registro.")
                End If
            Else
                MessageBox.Show("Este Camion ya existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub txtCodigoRuta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoRuta.Validating
        If (Me.txtCodigoRuta.Text = "") Then
            Me.txtdescripcionRuta.Clear()
        End If
        fnBuscarRutas()
    End Sub

    Private Sub txtCodigoRuta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoRuta.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescripcionRuta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcionRuta.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescripcionRuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcionRuta.TextChanged
        If (Me.txtdescripcionRuta.Text = "") Then
            Me.txtCodigoRuta.Enabled = True
            Me.txtCodigoRuta.Text = ""
            Me.txtCodigoRuta.Focus()
        End If


    End Sub

#End Region

End Class
