Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Public Class frmMantenimientoChofer

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

    Private _CTRSPT As Integer
    Public Property CTRSPT() As Integer
        Get
            Return _CTRSPT
        End Get
        Set(ByVal value As Integer)
            _CTRSPT = value
        End Set
    End Property


    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property


    Private _Nacionalidad As String
    Public Property Nacionalidad() As String
        Get
            Return _Nacionalidad
        End Get
        Set(ByVal value As String)
            _Nacionalidad = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"

    Private Function fnValidarDatos() As Boolean
        If Me.txtCBRCNT.Text.Trim = String.Empty Then
            MessageBox.Show("Faltan ingresar el numero de brevete.")
            Return False
        End If
        If Me.txtCBRCNT.Text.Trim.Length = 0 Then
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
        If Me.txtCBRCNT.Text.Trim <> String.Empty Then
            Dim CBRCNT As String = Me.txtCBRCNT.Text.Trim
            Dim objbeChofer As beChofer = (New brChofer).SP_SOLMIN_SA_SEL_CHOFER_AT(CBRCNT, CTRSPT)
            If objbeChofer Is Nothing Then
                Me.txtNLELCH.Text = String.Empty
                Me.txtTNMBCH.Text = String.Empty
                Me.txtDireccion.Text = String.Empty
                Me.txtNacionalidad.Text = String.Empty
                txtCBRCNT.ReadOnly = False

                _ACCION = "Insert"
            Else
                _ObjbeChofer = New beChofer
                _ObjbeChofer = objbeChofer
                Me.txtCBRCNT.Text = _ObjbeChofer.PSCBRCNT.ToString.Trim
                Me.txtNLELCH.Text = IIf(_ObjbeChofer.PNNLELCH.ToString.Trim = "0", "", _ObjbeChofer.PNNLELCH.ToString.Trim)
                Me.txtTNMBCH.Text = _ObjbeChofer.PSTNMBCH.ToString.Trim
                Me.txtDireccion.Text = _ObjbeChofer.PSTDRCC.ToString.Trim
                Me.txtNacionalidad.Text = _ObjbeChofer.PSTNCION.ToString.Trim
                txtCBRCNT.ReadOnly = True

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

    Private Sub frmMantenimientoChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ACCION = "Insert"
        If (BuscarDatosDefault = True) Then
            txtCBRCNT.Text = Me.Brevete
            fnBuscarChofer()
        End If
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If Not fnValidarDatos() Then Return
            If _ACCION = "Update" Then
                With _ObjbeChofer
                    .PSSESTUN = "A"
                    .PNCTRSPT = CTRSPT
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSCBRCNT = Me.txtCBRCNT.Text.Trim
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PNNLELCH = IIf(Me.txtNLELCH.Text.Trim = String.Empty, "0", Me.txtNLELCH.Text.Trim)
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSTNMBCH = Me.txtTNMBCH.Text.Trim
                    .PSTDRCC = Me.txtDireccion.Text.Trim
                    .PSTNCION = Me.txtNacionalidad.Text.Trim
                    .PSUPID = .PSUPID + 1
                End With
                If (New brChofer).SP_SOLMIN_SA_UPD_CHOFER_AT(_ObjbeChofer) Then
                    MessageBox.Show("Registro modificado.")
                    _Brevete = _ObjbeChofer.PSCBRCNT
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Else
                    MessageBox.Show("Error al modificar registro.")
                End If

            ElseIf _ACCION = "Insert" Then
                _ObjbeChofer = New beChofer
                With _ObjbeChofer
                    .PSSESTUN = "A"
                    .PNCTRSPT = CTRSPT
                    .PNFULTAC = fnGetFecha() 'auditoria
                    .PNHULTAC = fnGetHora() 'auditoria
                    .PSCBRCNT = Me.txtCBRCNT.Text.Trim
                    .PSCULUSA = objSeguridadBN.pUsuario 'auditoria
                    .PNNLELCH = IIf(Me.txtNLELCH.Text.Trim = String.Empty, "0", Me.txtNLELCH.Text.Trim)
                    .PSNTRMNL = objSeguridadBN.pstrPCName 'auditoria
                    .PSTNMBCH = Me.txtTNMBCH.Text.Trim
                    .PSTDRCC = Me.txtDireccion.Text.Trim
                    .PSTNCION = Me.txtNacionalidad.Text.Trim
                    .PSSESTCH = "A" 'auditoria
                    .PSUPID = 1
                End With
                If (New brChofer).SP_SOLMIN_SA_INS_CHOFER_AT(_ObjbeChofer) > 0 Then
                    MessageBox.Show("Registro agregado.")
                    _Brevete = _ObjbeChofer.PSCBRCNT
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    _ACCION = "Update"
                Else
                    MessageBox.Show("Error al agregar registro.")
                End If
            Else
                MessageBox.Show("Este Chofer ya existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar registro.")
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub txtNLELCH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNLELCH.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCBRCNT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCBRCNT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            fnBuscarChofer()
        ElseIf e.KeyCode = Keys.Escape Then
            e.Handled = True
            fnBuscarChofer()
        End If
    End Sub

    Private Sub txtCBRCNT_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCBRCNT.Validating
        fnBuscarChofer()
    End Sub

#End Region

End Class
