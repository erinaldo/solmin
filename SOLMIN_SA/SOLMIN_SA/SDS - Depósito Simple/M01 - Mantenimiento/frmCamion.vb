Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmCamion

#Region "Variables"
    Private _ObjbeCamion As beCamion
    Private _ACCION As String
#End Region

#Region "Propiedades"
    Public BuscarDatosDefault As Boolean = False
    Private _CTRSP As Integer
    Public Property CTRSP() As Integer
        Get
            Return _CTRSP
        End Get
        Set(ByVal value As Integer)
            _CTRSP = value
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

    Private Function fnValidarDatos() As Boolean
        If Me.txtNPLCCM.Text.Trim = String.Empty Then
            MessageBox.Show("Faltan ingresar el numero de placa.")
            Return False
        End If
        If Me.txtNPLCCM.Text.Trim.Length < 6 Then
            MessageBox.Show("Ingrese correctamente el numero de placa.")
            Return False
        End If
        If Not (IsNumeric(IIf(Me.txtNANOCM.Text.Trim = String.Empty, "0", Me.txtNANOCM.Text.Trim))) Then
            MessageBox.Show("Ingrese correctamente el numero de año.")
            Return False
        End If
        Return True
    End Function

    Private Sub fnBuscarCamion()
        If Me.txtNPLCCM.Text.Trim <> String.Empty Then
            Dim NPLCCM As String = Me.txtNPLCCM.Text.Trim
            Dim objbeCamion As beCamion = (New brCamion).SP_SOLMIN_SA_SEL_CAMION(NPLCCM, CTRSP)
            If objbeCamion Is Nothing Then
                Me.txtNANOCM.Text = String.Empty
                Me.txtTMRCCM.Text = String.Empty
                _ACCION = "Insert"
            Else
                _ObjbeCamion = New beCamion
                _ObjbeCamion = objbeCamion
                Me.txtNPLCCM.Text = _ObjbeCamion.PSNPLCCM.ToString.Trim
                Me.txtNANOCM.Text = IIf(_ObjbeCamion.PNNANOCM.ToString.Trim = "0", "", _ObjbeCamion.PNNANOCM.ToString.Trim)
                Me.txtTMRCCM.Text = _ObjbeCamion.PSTMRCCM.ToString.Trim
                _ACCION = "Update"
            End If
        End If
    End Sub

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

#End Region

#Region "Eventos"

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If Not fnValidarDatos() Then Return
            If _ACCION = "Update" Then
                With _ObjbeCamion
                    .PSNPLCCM = Me.txtNPLCCM.Text.Trim
                    .PNNANOCM = IIf(Me.txtNANOCM.Text.Trim = String.Empty, "0", Me.txtNANOCM.Text.Trim)
                    .PSTMRCCM = Me.txtTMRCCM.Text.Trim
                    .PNFASGTR = fnGetFecha() 'auditoria
                    .PNHASGTR = fnGetHora() 'auditoria
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PNSESTRG = "A" 'auditoria
                    .PNUPID = .PNUPID + 1
                    .PSNRGMT1 = txtMTC.text
                End With
                If (New brCamion).SP_SOLMIN_SA_UPD_CAMION(_ObjbeCamion) Then
                    MessageBox.Show("Registro modificado.")
                    _Placa = _ObjbeCamion.PSNPLCCM
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error al modificar registro.")
                End If
            ElseIf _ACCION = "Insert" Then
                _ObjbeCamion = New beCamion
                With _ObjbeCamion
                    .PNCTRSP = CTRSP
                    .PSNPLCCM = Me.txtNPLCCM.Text.Trim
                    .PNPTRCM = 0
                    .PNNANOCM = IIf(Me.txtNANOCM.Text.Trim = String.Empty, "0", Me.txtNANOCM.Text.Trim)
                    .PSTMRCCM = Me.txtTMRCCM.Text.Trim
                    .PSNMTRCM = ""
                    .PSSESTCM = ""
                    .PSNROPLA = ""
                    .PSNBRVC1 = ""
                    .PSNPLCAC = ""
                    .PNNTRNLL = 0
                    .PNHULTAC = 0
                    .PNFULTAC = 0
                    .PSNRGMT1 = txtMTC.text
                    .PNFASGTR = fnGetFecha() 'auditoria
                    .PNHASGTR = fnGetHora() 'auditoria
                    .PSCULUSA = objSeguridadBN.pUsuario
                    .PSNTRMNL = objSeguridadBN.pstrPCName
                    .PNSESTRG = "A" 'auditoria
                    .PNUPID = 1
                End With
                If (New brCamion).SP_SOLMIN_SA_INS_CAMION(_ObjbeCamion) > 0 Then
                    MessageBox.Show("Registro agregado.")
                    _Placa = _ObjbeCamion.PSNPLCCM
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

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If Not fnValidarDatos() Then Return
            If _ACCION = "Update" Then
                With _ObjbeCamion
                    .PNFASGTR = fnGetFecha() 'auditoria
                    .PNHASGTR = fnGetHora() 'auditoria
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PNSESTRG = "*" 'auditoria
                    .PNUPID = .PNUPID + 1
                End With
                If (New brCamion).SP_SOLMIN_SA_UPD_CAMION(_ObjbeCamion) Then
                    MessageBox.Show("Registro eliminado.")
                    Me.txtNPLCCM.Text = String.Empty
                    Me.txtNANOCM.Text = String.Empty
                    Me.txtTMRCCM.Text = String.Empty
                Else
                    MessageBox.Show("Error al eliminar registro.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
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

    Private Sub frmCamion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            Me.txtNPLCCM.Text = Placa
            fnBuscarCamion()
        End If
    End Sub

    Private Sub txtNPLCCM_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNPLCCM.Validating
        fnBuscarCamion()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

#End Region

End Class
