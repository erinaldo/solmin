Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmAgregarNotificaciones



#Region "Propiedades"


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


#End Region


    Private Sub frmAgregarNotificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCliente.pAccesoPorUsuario = True
        txtCliente.pRequerido = True
        txtCliente.pUsuario = HelpUtil.UserName

        Cargar_Cargar_ProcNotificacion()
        'Cargar_Cargar_Formatos()
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim Mensaje As String = ""
            If ValidarControles(Mensaje) Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim brSegNotificacion As New Negocio.clsSegNotificacion
            Dim dt As New DataTable
            Dim beSegNotificacion As New beSegNotificacion
            With beSegNotificacion
                .PSCCMPN = CCMPN
                .PSCDVSN = CDVSN
                .PNCCLNT = txtCliente.pCodigo
                .PSNLTECL = CType(UcProcNotificacion.Resultado, beTipoDatoGeneral).PSCCMPRN
                .PSCULUSA = HelpUtil.UserName
                '.PSCODFMT = cbmFormato.SelectedValue
            End With
            Dim msg As String = ""
            msg = brSegNotificacion.RegistrarClienteProcesoNotificacion(beSegNotificacion)
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#Region "Metodos"


    Private Function ValidarControles(ByRef Mensaje As String) As Boolean
        Dim Respuesta As Boolean = False
        If txtCliente.pCodigo = 0 Then
            Mensaje = "Seleccione un cliente" & Environment.NewLine
        End If
        If UcProcNotificacion.Resultado Is Nothing Then
            Mensaje = Mensaje & "Seleccione un cliente" & Environment.NewLine
        End If

        If Mensaje.Length > 0 Then
            Respuesta = True
        End If

        Return Respuesta
    End Function


    Private Sub Cargar_Cargar_ProcNotificacion()
        Dim Lista As List(Of beTipoDatoGeneral)
        Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        Lista = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("SCCENV")


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        If Lista.Count > 0 Then
            UcProcNotificacion.DataSource = Lista
        Else
            UcProcNotificacion.DataSource = Nothing
        End If
        UcProcNotificacion.ListColumnas = oListColum
        UcProcNotificacion.Cargas()
        UcProcNotificacion.Limpiar()
        UcProcNotificacion.ValueMember = "PSCCMPRN"
        UcProcNotificacion.DispleyMember = "PSTDSDES"
    End Sub

    'Private Sub Cargar_Cargar_Formatos()
    '    Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
    '    Dim Lista As New List(Of beTipoDatoGeneral)
    '    Dim obtipoGeneral As New beTipoDatoGeneral
    '    Lista = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("SCFCHK")
    '    obtipoGeneral.PSCCMPRN = ""
    '    obtipoGeneral.PSTDSDES = "Seleccione"
    '    Lista.Insert(0, obtipoGeneral)
    '    cbmFormato.DataSource = Lista
    '    cbmFormato.ValueMember = "PSCCMPRN"
    '    cbmFormato.DisplayMember = "PSTDSDES"
    '    cbmFormato.SelectedValue = ""

    'End Sub
#End Region

End Class
