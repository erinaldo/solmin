Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TypeDef
Imports Ransa.Utilitario

Public Class frmChofer

#Region "Variables"
    Private _ObjbeChofer As beChofer
    Private _ACCION As String
#End Region

#Region "Propiedades"
    Public BuscarDatosDefault As Boolean = False
    Private _Brevete As String
    Public Property Brevete() As String
        Get
            Return _Brevete
        End Get
        Set(ByVal value As String)
            _Brevete = value
        End Set
    End Property

    Private _CTRSP As Integer
    Public Property CTRSP() As Integer
        Get
            Return _CTRSP
        End Get
        Set(ByVal value As Integer)
            _CTRSP = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"

    Private Function fnValidarDatos() As Boolean
        If Me.txtNBRVCH.Text.Trim = String.Empty Then
            MessageBox.Show("Faltan ingresar el numero de brevete.")
            Return False
        End If
        If Me.txtNBRVCH.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese correctamente el numero de brevete.")
            Return False
        End If
        If Not (IsNumeric(IIf(Me.txtNLELCH.Text.Trim = String.Empty, "0", Me.txtNLELCH.Text.Trim))) Then
            MessageBox.Show("Ingrese correctamente el numero de libreta electoral.")
            Return False
        End If
        Return True
    End Function

    Private Sub fnBuscarChofer()
        If Me.txtNBRVCH.Text.Trim <> String.Empty Then
            Dim NBRVCH As String = Me.txtNBRVCH.Text.Trim
            Dim objbeChofer As beChofer = (New brChofer).SeleccionarChoferDS(NBRVCH, CTRSP)
            If objbeChofer Is Nothing Then
                Me.txtNLELCH.Text = String.Empty
                Me.txtTNMBCH.Text = String.Empty
                _ACCION = "Insert"
            Else
                _ObjbeChofer = New beChofer
                _ObjbeChofer = objbeChofer
                Me.txtNBRVCH.Text = _ObjbeChofer.PSNBRVCH.ToString.Trim
                Me.txtNLELCH.Text = IIf(_ObjbeChofer.PNNLELCH.ToString.Trim = "0", "", _ObjbeChofer.PNNLELCH.ToString.Trim)
                Me.txtTNMBCH.Text = _ObjbeChofer.PSTNMBCH.ToString.Trim
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
                With _ObjbeChofer
                    .PSSESTRG = "A"
                    '.PNCTRSP = CTRSP
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSNBRVCH = Me.txtNBRVCH.Text.Trim
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PNNLELCH = IIf(Me.txtNLELCH.Text.Trim = String.Empty, "0", Me.txtNLELCH.Text.Trim)
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSTNMBCH = Me.txtTNMBCH.Text.Trim
                    .PSSESTCH = "A" 'auditoria
                    .PSUPID = .PSUPID + 1
                End With
                If (New brChofer).ActualizarChoferDS(_ObjbeChofer) Then
                    MessageBox.Show("Registro modificado.")
                    _Brevete = _ObjbeChofer.PSNBRVCH
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error al modificar registro.")
                End If

            ElseIf _ACCION = "Insert" Then
                _ObjbeChofer = New beChofer
                With _ObjbeChofer
                    .PSSESTRG = "A"
                    .PNCTRSP = CTRSP
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSNBRVCH = Me.txtNBRVCH.Text.Trim
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PNNLELCH = IIf(Me.txtNLELCH.Text.Trim = String.Empty, "0", Me.txtNLELCH.Text.Trim)
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSTNMBCH = Me.txtTNMBCH.Text.Trim
                    .PSSESTCH = "A" 'auditoria
                    .PSUPID = 1
                End With
                If (New brChofer).InsertarChoferDS(_ObjbeChofer) > 0 Then
                    MessageBox.Show("Registro agregado.")
                    _Brevete = _ObjbeChofer.PSNBRVCH
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
                With _ObjbeChofer
                    .PSSESTRG = "*" 'auditoria
                    '.PNCTRSP = CTRSP
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSNBRVCH = Me.txtNBRVCH.Text.Trim
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PNNLELCH = Me.txtNLELCH.Text.Trim
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSTNMBCH = Me.txtTNMBCH.Text.Trim
                    '.PSSESTCH = "A"
                    .PSUPID = .PSUPID + 1
                End With
                If (New brChofer).ActualizarChoferDS(_ObjbeChofer) Then
                    MessageBox.Show("Registro eliminado.")
                    Me.txtNBRVCH.Text = String.Empty
                    Me.txtNLELCH.Text = String.Empty
                    Me.txtTNMBCH.Text = String.Empty
                Else
                    MessageBox.Show("Error al eliminar registro.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
    End Sub

    Private Sub frmChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            txtNBRVCH.Text = Me.Brevete
            fnBuscarChofer()
        End If
    End Sub

    Private Sub txtNBRVCH_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNBRVCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            fnBuscarChofer()
        ElseIf e.KeyCode = Keys.Escape Then
            e.Handled = True
            fnBuscarChofer()
        End If
    End Sub

    Private Sub txtNBRVCH_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNBRVCH.Validating
        fnBuscarChofer()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub txtNLELCH_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNLELCH.KeyUp
        HelpClass.SoloNumeros(e.KeyCode)
    End Sub

#End Region

End Class
