Imports System.Windows.Forms
Imports System.Text


Public Class frmEnviarNotificacion
    Private _pNUMREQT As String = ""
    Private _pCCMPN As String = ""
    Private _pEMAIL_RESP As String
    Private _beSegEnvioReq As New SegEnvioRequerimiento
    Public Property beSegEnvioReq() As SegEnvioRequerimiento
        Get
            Return _beSegEnvioReq
        End Get
        Set(ByVal value As SegEnvioRequerimiento)
            _beSegEnvioReq = value
        End Set
    End Property

    Public sHoraHtml As String = String.Empty


    Sub New(ByVal NUMREQT As String, ByVal CCMPN As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _pNUMREQT = NUMREQT
        _pCCMPN = CCMPN

    End Sub
    Private Sub frmEnviarNotificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Area()
            Cargar_Fecha_Hora()
            lblNroReq.Text = _pNUMREQT
            Cargar_Responsable()
            Cargar_Cuerpo_Notificacion(_pNUMREQT, _pCCMPN)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub Cargar_Responsable()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrIncidencias As New RequerimientoServicio_BLL
        Dim obeResponsable As New beDestinatario
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSNCRRIT"
        oColumnas.DataPropertyName = "PSNCRRIT"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.Visible = False
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMYAP"
        oColumnas.DataPropertyName = "PSTNMYAP"
        oColumnas.HeaderText = "Nombre"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSEMAILTO"
        oColumnas.DataPropertyName = "PSEMAILTO"
        oColumnas.HeaderText = "Correo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        With obeResponsable
            .PNCCLNT = 999999
            .PSTIPPROC = "ST_REQSERV"
        End With

        Etiquetas.Add("Nombre")
        Etiquetas.Add("Email")

        Me.ucResponsable.Etiquetas_Form = Etiquetas
        Me.ucResponsable.DataSource = obrIncidencias.olisListarResponsables(obeResponsable)
        Me.ucResponsable.ListColumnas = oListColum
        Me.ucResponsable.Cargas()
        Me.ucResponsable.DispleyMember = "PSEMAILTO"
        Me.ucResponsable.ValueMember = "PSTNMYAP"
    End Sub

    Sub Cargar_Area()

        Dim dtArea As New DataTable
        Dim dr As DataRow

        dtArea.Columns.Add("CODAREA", Type.GetType("System.String"))
        dtArea.Columns.Add("AREA", Type.GetType("System.String"))

        dr = dtArea.NewRow
        dr("CODAREA") = "O"
        dr("AREA") = "Operaciones"
        dtArea.Rows.Add(dr)


        cmbArea.DataSource = dtArea
        cmbArea.DisplayMember = "AREA"
        cmbArea.ValueMember = "CODAREA"
        cmbArea.SelectedValue = "O"

    End Sub

    Sub Cargar_Fecha_Hora()
        dtpFecha.Value = Now.Date
        dtpHora.Value = Date.Parse(String.Format("{0:HH:mm:ss}", Date.Now))
    End Sub

    Private Sub ucResponsable_CambioDeTexto(ByVal objData As System.Object) Handles ucResponsable.CambioDeTexto
        If ucResponsable.Resultado IsNot Nothing Then
            txtResponsable.Text = CType(ucResponsable.Resultado, beDestinatario).PSTNMYAP
            txtEmail.Text = CType(ucResponsable.Resultado, beDestinatario).PSEMAILTO
        End If
    End Sub

    Private Sub Cargar_Cuerpo_Notificacion(ByVal NUMREQ As String, ByVal CCMPN As String)
        Dim Envio As New RequerimientoServicioEnvio_BLL
        ObtenerFormatoHora(sHoraHtml)
        WebBrowser1.DocumentText = Envio.Cargar_Cuerpo_Email_Notificacion(NUMREQ, CCMPN)
    End Sub

    Private Function ObtenerFormatoHora(ByRef horahtml As String) As Decimal
        Dim Hora As String
        Hora = Now.Hour.ToString.ToString.PadLeft(2, "0") & Now.Minute.ToString.ToString.PadLeft(2, "0") & Now.Second.ToString.ToString.PadLeft(2, "0")
        horahtml = Now.Hour.ToString.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.ToString.PadLeft(2, "0")
        Return Hora
    End Function

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If txtResponsable.Text.ToString.Trim = "" Then strMensajeError &= "* Seleccione responsable destino" & vbNewLine
        If txtObservaciones.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese observación" & vbNewLine
        If txtAsunto.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese asunto" & vbNewLine
        'If IsValidEmail(txtEmail.Text.ToString.Trim) = False Then strMensajeError &= "* Ingrese Email Con Copia Válido" & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() Then Exit Sub
        beSegEnvioReq.NUMREQT = lblNroReq.Text
        beSegEnvioReq.CCMPN = _pCCMPN
        beSegEnvioReq.URSPDC = txtResponsable.Text
        beSegEnvioReq.SESREQT = cmbArea.SelectedValue
        beSegEnvioReq.TOBSSG = txtObservaciones.Text.Trim
        beSegEnvioReq.SUBJECT = txtAsunto.Text.Trim
        beSegEnvioReq.EMAIL = txtEmail.Text
        'beSegEnvioReq.EMAILCC = txtEmailCC.Text
        beSegEnvioReq.FDSGDC = CDec(String.Format("{0:yyyyMMdd}", dtpFecha.Value))
        beSegEnvioReq.HDSGDC = CDec(String.Format("{0:HHmmss}", dtpHora.Value))
        'beSegEnvioReq.CUERPONOTIF = WebBrowser1.DocumentText
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Private Sub txtEmailCC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmailCC.Validating
    '    IsValidEmail(txtEmailCC.Text.Trim)
    'End Sub

    Private Function IsValidEmail(ByVal strIn As String) As Boolean
        Dim ExpreReg As New StringBuilder
        ExpreReg.Append("^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))")
        ExpreReg.Append("(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
        Return RegularExpressions.Regex.IsMatch(strIn, ExpreReg.ToString.Trim)
    End Function


End Class
