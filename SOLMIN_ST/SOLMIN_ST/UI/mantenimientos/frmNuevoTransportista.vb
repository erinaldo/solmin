Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Public Class frmNuevoTransportista

#Region "Metodos"
    Private Sub cargarComboTransportistaAS400()
        Try

            Dim obrTransportistaAS400_BLL As New TransportistaAS400_BLL
            With Me.cboTranspAS400
                .DataSource = Nothing
                .DataSource = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(_CCMPN)) 'CType(MainModule.gobj_TablasGeneralesdelSistema("TRANSPORTISTAS_AS400"), DataTable).Copy()
                .KeyField = "CTRSPT"
                .ValueField = "TCMTRT"
                .DataBind()
            End With
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Propiedades"

    Private _NRUCTR As String
    Public ReadOnly Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
    End Property

  Private _CCMPN As String

  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property


  Private _CDVSN As String
  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Private _CPLNDV As Double

  Public Property CPLNDV() As Double
    Get
      Return _CPLNDV
    End Get
    Set(ByVal value As Double)
      _CPLNDV = value
    End Set
  End Property

#End Region

    Private Sub frmNuevoTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargarComboTransportistaAS400()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If validar() Then
                Registrar_Transportista()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Function validar() As Boolean
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
        If Me.txtNroRuc.Text = "" Then
            strError += "Ingrese el RUC" & Chr(13)
        End If
        If Me.txtNroRuc.Text.Length <> 11 Then
            strError += "El RUC debe tener 11 caracteres." & Chr(13)
        End If
        If Me.txtRazonSocial.Text = "" Then
            strError += "Ingrese la razón social." & Chr(13)
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Registrar_Transportista()
        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista

        objEntidad.NRUCTR = Me.txtNroRuc.Text
        If cboTranspAS400.Codigo.Equals("") Then
            objEntidad.CTRSPT = 0
        Else
            objEntidad.CTRSPT = Integer.Parse(cboTranspAS400.Codigo)
        End If
        objEntidad.TCMTRT = Me.txtRazonSocial.Text
        objEntidad.TABTRT = Me.txtDescripcion.Text
        objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
        objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
        objEntidad.SINDRC = "T"
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CCMPN = _CCMPN
    objEntidad.CDVSN = _CDVSN
    objEntidad.CPLNDV = CPLNDV


        objEntidad = obj.Registrar_Transportista(objEntidad)

        If objEntidad.CTRSPT = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        ElseIf objEntidad.CTRSPT > 0 Then
            _NRUCTR = objEntidad.NRUCTR
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BuscarTransportista()
        If txtNroRuc.Text.Equals("") Then Exit Sub
        Dim obrTransportista As New Transportista_BLL
        Dim obeTransportista As New Transportista
        Dim olbeTransportista As New List(Of Transportista)

        If Me.txtNroRuc.Text = "" Then Exit Sub
        obeTransportista.NRUCTR = Me.txtNroRuc.Text
        obeTransportista.CCMPN = _CCMPN
        obeTransportista.CDVSN = _CDVSN
        obeTransportista.CPLNDV = _CPLNDV

        olbeTransportista = obrTransportista.Listar_Transportista(obeTransportista)
        If olbeTransportista.Count = 0 Then
            Dim strPlaca As String
            strPlaca = Me.txtNroRuc.Text
            Limpiar_Controles_Transportista()
            Me.txtNroRuc.Text = strPlaca
            Exit Sub
        End If
        cboTranspAS400.Codigo = olbeTransportista.Item(0).CTRSPT
        txtNroRuc.Text = olbeTransportista.Item(0).NRUCTR
        txtRazonSocial.Text = olbeTransportista.Item(0).TCMTRT
        txtDescripcion.Text = olbeTransportista.Item(0).TABTRT
        txtDireccionTransportista.Text = olbeTransportista.Item(0).TDRCTR
        txtTelefonoTransportista.Text = olbeTransportista.Item(0).TLFTRP
    End Sub

    Private Sub Limpiar_Controles_Transportista()
        cboTranspAS400.Limpiar()
        txtNroRuc.Text = ""
        txtRazonSocial.Text = ""
        txtDescripcion.Text = ""
        txtDireccionTransportista.Text = ""
        txtTelefonoTransportista.Text = ""
    End Sub

    Private Sub txtNroRuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroRuc.TextChanged
        txtNroRuc.CausesValidation = True
    End Sub

    Private Sub txtNroRuc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroRuc.Validating
        Try
            BuscarTransportista()
            txtNroRuc.CausesValidation = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtNroRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRuc.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                BuscarTransportista()
                txtNroRuc.CausesValidation = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
End Class
