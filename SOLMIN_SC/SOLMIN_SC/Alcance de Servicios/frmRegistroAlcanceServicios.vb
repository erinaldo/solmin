Imports Ransa.TypeDef.Cliente
Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmRegistroAlcanceServicios
    Private obeAlcanceServicio As beAlcanceServicio
    Private obrAlcanceServicio As clsAlcanceServicio
#Region "PROPIEDADES"


    Private _PSACTION As String
    Public Property PSACTION() As String
        Get
            Return _PSACTION
        End Get
        Set(ByVal value As String)
            _PSACTION = value
        End Set
    End Property

    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCDVSN As String = ""
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCCLNT As Integer
    Public Property PNCCLNT() As Integer
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Integer)
            _PNCCLNT = value
        End Set
    End Property

    Private _obeAlcanceServicio As beAlcanceServicio
    Public Property BeAlcanceServicio() As beAlcanceServicio
        Get
            Return _obeAlcanceServicio
        End Get
        Set(ByVal value As beAlcanceServicio)
            _obeAlcanceServicio = value
        End Set
    End Property
#End Region

#Region "EVENTOS"

    Private Sub frmRegistroAlcanceServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTitulo.Text = ""
            If PSACTION.Equals("ADD") Then
                UcDivision_Cmb011.Compania = _PSCCMPN
                UcDivision_Cmb011.Usuario = HelpUtil.UserName
                UcDivision_Cmb011.DivisionDefault = _PSCDVSN
                UcDivision_Cmb011.pActualizar()
                CargarUnidadMedida()
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
                txtCliente.pCargar(ClientePK)
                txtCliente.pCargar(_PNCCLNT)
                Me.txtDescripcion.Text = ""
                Me.txtIndicadorMedicion.Text = ""
                Me.txtCantidad.txtDecimales.Text = ""
                Me.txtUnidadCantidad.Valor = ""
                Me.txtReferenciaMedida.Text = ""
                Me.txtFormaMedicion.Text = ""
            ElseIf PSACTION.Equals("EDIT") Then
                If BeAlcanceServicio IsNot Nothing Then
                    UcDivision_Cmb011.Compania = BeAlcanceServicio.PSCCMPN
                    UcDivision_Cmb011.Usuario = HelpUtil.UserName
                    UcDivision_Cmb011.DivisionDefault = BeAlcanceServicio.PSCDVSN
                    UcDivision_Cmb011.pActualizar()
                    UcDivision_Cmb011.pHabilitado = False
                    CargarUnidadMedida()
                    Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
                    txtCliente.pCargar(ClientePK)
                    txtCliente.pCargar(BeAlcanceServicio.PNCCLNT)
                    txtCliente.Enabled = False
                    Me.txtDescripcion.Text = BeAlcanceServicio.PSTDALSR
                    Me.txtIndicadorMedicion.Text = BeAlcanceServicio.PSTINDMD
                    Me.txtCantidad.txtDecimales.Text = BeAlcanceServicio.PNQMDALS
                    Me.txtUnidadCantidad.Valor = BeAlcanceServicio.PSCUNDSR
                    Me.txtReferenciaMedida.Text = BeAlcanceServicio.PSTRFMED
                    Me.txtFormaMedicion.Text = BeAlcanceServicio.PSTFRMMD
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If validarCampos() Then
                Dim intResult As Integer
                obrAlcanceServicio = New clsAlcanceServicio
                obeAlcanceServicio = New beAlcanceServicio
                If PSACTION.Equals("ADD") Then
                    obeAlcanceServicio.PSCCMPN = _PSCCMPN
                    obeAlcanceServicio.PSCDVSN = Me.UcDivision_Cmb011.Division
                    obeAlcanceServicio.PNCCLNT = Me.txtCliente.pCodigo
                ElseIf PSACTION.Equals("EDIT") Then
                    obeAlcanceServicio = BeAlcanceServicio
                End If
                obeAlcanceServicio.PSTDALSR = Me.txtDescripcion.Text
                obeAlcanceServicio.PSTINDMD = Me.txtIndicadorMedicion.Text
                obeAlcanceServicio.PNQMDALS = Me.txtCantidad.txtDecimales.Text
                obeAlcanceServicio.PSCUNDSR = CType(Me.txtUnidadCantidad.Resultado, Ransa.Controls.Incidencia.beGeneral).PSCUNDMD
                obeAlcanceServicio.PSTRFMED = Me.txtReferenciaMedida.Text
                obeAlcanceServicio.PSTFRMMD = Me.txtFormaMedicion.Text
                obeAlcanceServicio.PSSESTRG = "A"
                obeAlcanceServicio.PSUSUARIO = HelpUtil.UserName
                obeAlcanceServicio.PSNTRMNL = Environment.MachineName
                If PSACTION.Equals("ADD") Then
                    intResult = obrAlcanceServicio.fintInsertarAlcanceServicioXCliente(obeAlcanceServicio)
                ElseIf PSACTION.Equals("EDIT") Then
                    intResult = obrAlcanceServicio.fintActualizarAlcanceServicioXCliente(obeAlcanceServicio)
                End If

                If intResult = 1 Then
                    MessageBox.Show("Se registró correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Ocurrió un error al registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"

    Private Function validarCampos() As Boolean
        Dim strError As String = ""

        If UcDivision_Cmb011.Division = String.Empty Then
            strError = strError & "* Ingrese Divisón" & Chr(13)
        End If
        If txtCliente.pCodigo = 0 Then
            strError = strError & "* Ingrese Cliente" & Chr(13)
        End If
        If txtDescripcion.Text = String.Empty Then
            strError = strError & "* Ingrese Descripción" & Chr(13)
        End If
        If txtCantidad.txtDecimales.Text = String.Empty Then
            strError = strError & "* Ingrese Cantidad" & Chr(13)
        End If
        If txtUnidadCantidad.Resultado Is Nothing Then
            strError = strError & "* Ingrese Unidad"
        End If
        If strError.Trim.Length > 0 Then
            MessageBox.Show("Verifique: " & Chr(13) & strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function
    Private Sub CargarUnidadMedida()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrGeneral As New Ransa.Controls.Incidencia.brGeneral
        Dim obeGeneral As New Ransa.Controls.Incidencia.beGeneral
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCUNDMD"
        oColumnas.DataPropertyName = "PSCUNDMD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTCMPUN"
        oColumnas.DataPropertyName = "PSTCMPUN"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        'With obeGeneral
        '    .PSSTPOUN = "C"
        'End With
        Me.txtUnidadCantidad.DataSource = obrGeneral.ListaUnidadDeMedida(obeGeneral)
        Me.txtUnidadCantidad.ListColumnas = oListColum
        Me.txtUnidadCantidad.Cargas()
        Me.txtUnidadCantidad.DispleyMember = "PSTCMPUN"
        Me.txtUnidadCantidad.ValueMember = "PSCUNDMD"
    End Sub
#End Region


End Class
