Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Imports RANSA.NEGO
Public Class frmMantenimientoAcoplado


#Region "Variables"
    Private _ObjbeAcoplado As beAcoplado
    Private _ACCION As String
#End Region

#Region "Propiedades"
    Public BuscarDatosDefault As Boolean = False
    Private _CTRSPT As Integer
    Public Property CTRSPT() As Integer
        Get
            Return _CTRSPT
        End Get
        Set(ByVal value As Integer)
            _CTRSPT = value
        End Set
    End Property

    Private _Placa As String
    Public Property Placa() As String
        Get
            Return _Placa
        End Get
        Set(ByVal value As String)
            _Placa = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"


    Private Function fnGetFecha() As Integer
        Dim y As String = Now.Year
        Dim m As String = IIf(Now.Month > 9, Now.Month.ToString, "0" & Now.Month.ToString)
        Dim d As String = IIf(Now.Day > 9, Now.Day.ToString, "0" & Now.Day.ToString)
        Dim fecha As Integer = Convert.ToInt32(y & "" & m & "" & d)
        Return fecha
    End Function

    Private Function fnGetHora() As Integer
        Dim h As String = IIf(Now.Hour > 9, Now.Hour.ToString, "0" & Now.Hour.ToString)
        Dim m As String = IIf(Now.Minute > 9, Now.Minute.ToString, "0" & Now.Minute.ToString)
        Dim s As String = IIf(Now.Second > 9, Now.Second.ToString, "0" & Now.Second.ToString)
        Dim hora As Integer = Convert.ToInt32(h & "" & m & "" & s)
        Return hora
    End Function

    Private Function fnValidarDatos() As Boolean
        If Me.txtNPLCCM.Text.Trim = String.Empty Then
            MessageBox.Show("Faltan ingresar el numero de placa.")
            Return False
        End If
        If Me.txtNPLCCM.Text.Trim.Length < 6 Then
            MessageBox.Show("Ingrese correctamente el numero de placa.")
            Return False
        End If
        If Not (IsNumeric(IIf(Me.txtA�o.Text.Trim = String.Empty, "0", Me.txtA�o.Text.Trim))) Then
            MessageBox.Show("Ingrese correctamente el numero de a�o.")
            Return False
        End If
        Return True
    End Function

    Private Sub fnBuscarCamion()
        If Me.txtNPLCCM.Text.Trim <> String.Empty Then
            Dim NPLCAC As String = Me.txtNPLCCM.Text.Trim
            Dim objbeAcoplado As beAcoplado = (New brAcoplado).SP_SOLMIN_SA_SEL_ACOPLADO_AT(NPLCAC, CTRSPT)
            If objbeAcoplado Is Nothing Then
                Me.txtA�o.Text = String.Empty
                Me.txtChacis.Text = String.Empty
                Me.txtEjes.Text = String.Empty
                Me.txtColor.Text = String.Empty
                Me.txtCapacidad.Text = String.Empty
                Me.txtNumMTC.Text = String.Empty
                Me.txtConfEjes.Text = String.Empty
                txtNPLCCM.ReadOnly = False
                _ACCION = "Insert"
            Else
                _ObjbeAcoplado = New beAcoplado
                _ObjbeAcoplado = objbeAcoplado
                Me.txtNPLCCM.Text = _ObjbeAcoplado.PSNPLCAC.ToString.Trim
                Me.txtA�o.Text = IIf(_ObjbeAcoplado.PNFFBRUN.ToString.Trim = "0", "", _ObjbeAcoplado.PNFFBRUN.ToString.Trim)
                Me.txtChacis.Text = _ObjbeAcoplado.PSNSRCHU.ToString.Trim
                Me.txtEjes.Text = _ObjbeAcoplado.PNNEJSUN.ToString.Trim
                Me.txtColor.Text = _ObjbeAcoplado.PSTCLRUN.ToString.Trim
                Me.txtCapacidad.Text = _ObjbeAcoplado.PNNCPCRU.ToString.Trim
                Me.txtNumMTC.Text = _ObjbeAcoplado.PSNRGMT2.ToString.Trim
                Me.txtConfEjes.Text = _ObjbeAcoplado.PSTCNFG2.ToString.Trim
                txtNPLCCM.ReadOnly = True
                _ACCION = "Update"
            End If
        End If
    End Sub


#End Region

#Region "Eventos"

    Private Sub frmMantenimientoAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            Me.txtNPLCCM.Text = Placa
            fnBuscarCamion()
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub txtNPLCCM_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNPLCCM.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            fnBuscarCamion()
        ElseIf e.KeyCode = Keys.Tab Then
            e.Handled = True
            fnBuscarCamion()
        End If
    End Sub

    Private Sub txtNPLCCM_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNPLCCM.Validating
        fnBuscarCamion()
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If Not fnValidarDatos() Then Return
            If _ACCION = "Update" Then
                With _ObjbeAcoplado
                    .PNCTRSPT = CTRSPT
                    .PSNPLCAC = Me.txtNPLCCM.Text.Trim
                    .PNFFBRUN = IIf(Me.txtA�o.Text.Trim = String.Empty, "0", Me.txtA�o.Text.Trim)
                    .PSNSRCHU = Me.txtChacis.Text.Trim
                    .PNNEJSUN = Me.txtEjes.Text.Trim
                    .PSTCLRUN = Me.txtColor.Text.Trim
                    .PNNCPCRU = Me.txtCapacidad.Text.Trim
                    .PSNRGMT2 = Me.txtNumMTC.Text.Trim
                    .PSTCNFG2 = Me.txtConfEjes.Text
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSSESTUN = "A" 'auditoria
                    .PNUPDATE_IDENT = .PNUPDATE_IDENT + 1
                End With
                If (New brAcoplado).SP_SOLMIN_SA_UPD_ACOPLADO_AT(_ObjbeAcoplado) Then
                    MessageBox.Show("Registro modificado.")
                    _Placa = _ObjbeAcoplado.PSNPLCAC
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error al modificar registro.")
                End If
            ElseIf _ACCION = "Insert" Then
                _ObjbeAcoplado = New beAcoplado
                With _ObjbeAcoplado
                    .PNCTRSPT = CTRSPT
                    .PSNPLCAC = Me.txtNPLCCM.Text.Trim
                    .PNFFBRUN = IIf(Me.txtA�o.Text.Trim = String.Empty, "0", Me.txtA�o.Text.Trim)
                    .PSNSRCHU = Me.txtChacis.Text.Trim
                    .PNNEJSUN = IIf(Me.txtEjes.Text.Trim = String.Empty, "0", Me.txtEjes.Text.Trim)
                    .PSTCLRUN = Me.txtColor.Text.Trim
                    .PNNCPCRU = IIf(Me.txtCapacidad.Text.Trim = String.Empty, "0", Me.txtCapacidad.Text.Trim)
                    .PSNRGMT2 = Me.txtNumMTC.Text.Trim
                    .PSTCNFG2 = Me.txtConfEjes.Text
                    .PNFULTAC = 0
                    .PNHULTAC = 0
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSSESTUN = "A" 'auditoria
                    .PNUPDATE_IDENT = 1
                End With
                If (New brAcoplado).SP_SOLMIN_SA_INS_ACOPLADO_AT(_ObjbeAcoplado) > 0 Then
                    MessageBox.Show("Registro agregado.")
                    _Placa = _ObjbeAcoplado.PSNPLCAC
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    _ACCION = "Update"
                Else
                    MessageBox.Show("Error al agregar registro.")
                End If
            Else
                MessageBox.Show("Este Acoplado ya existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
    End Sub

    Private Sub txtA�o_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA�o.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtEjes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEjes.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtConfEjes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfEjes.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

#End Region

End Class
