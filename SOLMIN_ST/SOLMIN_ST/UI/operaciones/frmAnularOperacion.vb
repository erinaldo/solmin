Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Imports System.Text
Imports SOLMIN_ST.ENTIDADES
Imports System.Threading
Public Class frmAnularOperacion

    Private oHebraEnvioEmailReq As Thread
   
#Region "Propiedades Propias"

    Private _Operacion As String
    Public Property Operacion() As String
        Get
            Return _Operacion
        End Get
        Set(ByVal value As String)
            If _Operacion = value Then
                Return
            End If
            _Operacion = value
        End Set
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            If _CCMPN = value Then
                Return
            End If
            _CCMPN = value
        End Set
    End Property


    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            If _CDVSN = value Then
                Return
            End If
            _CDVSN = value
        End Set
    End Property

    Private _NCRRSR As String
    Public Property NCRRSR() As String
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As String)
            If _NCRRSR = value Then
                Return
            End If
            _NCRRSR = value
        End Set
    End Property

    Private _NCSOTR As String
    Public Property NCSOTR() As String
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As String)
            If _NCSOTR = value Then
                Return
            End If
            _NCSOTR = value
        End Set
    End Property

    Private _CCLINT As String = ""
    Public Property CCLINT() As String
        Get
            Return _CCLINT
        End Get
        Set(ByVal value As String)
            _CCLINT = value
        End Set
    End Property

#End Region

    Private Sub frmAnularOperacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtfecha.Text = HelpClass.CNumero_a_Fecha(HelpClass.TodayNumeric())
            txtoperacion.Text = Operacion
            cargarMotivo()
            Cargar_Autorizado_Por()
            Cargar_Area_Responsabilidad()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try

            Dim objLogica As New Solicitud_Transporte_BLL
            Dim msj As String = ""
          
            If UcAutorizadoPor.Resultado Is Nothing Then
                msj = msj & Chr(13) & "  Seleccione autorizado por"
            End If
            If txtUsuarioSolicitante.Text.Trim.Equals("") Then
                msj = msj & Chr(13) & " Seleccione solicitante"
            End If
          
            If Me.UcArea.Resultado Is Nothing Then
                msj = msj & Chr(13) & " Seleccione área de responsabilidad"
            End If
            If cboMotivoAnulacion.SelectedValue.Equals("0") Then
                msj = msj & Chr(13) & " Seleccione motivo de anulación"
            End If
            If msj.Length > 0 Then
                MessageBox.Show(msj, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If txtOpReemplazo.Text.Trim.Equals("") Then
                    If MessageBox.Show("No ha seleccionado la operación de reemplazo. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                    End If
                End If
            End If
            Dim objEntidad As New Solicitud_Transporte
            objEntidad.NCSOTR = NCSOTR
            objEntidad.NCRRSR = NCRRSR
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = CCMPN

            objEntidad.ANULAR = "SI"
            objEntidad.FLGAPG = "X"
            objEntidad.NOPRCR = Val("" & txtOpReemplazo.Text)
            objEntidad.UATAOP = CType(Me.UcAutorizadoPor.Resultado, SOLMIN_ST.ENTIDADES.Operaciones.TipoDatoGeneral).DESC_TIPO
            objEntidad.USLAOP = txtUsuarioSolicitante.Text.Trim
            objEntidad.CARERS = CType(Me.UcArea.Resultado, SOLMIN_ST.ENTIDADES.Operaciones.TipoDatoGeneral).CODIGO_TIPO
            objEntidad.MOTAOP = cboMotivoAnulacion.SelectedValue
            objEntidad.OBSAOP = txtObservacion.Text.Trim
            objEntidad.TRFSRC = txtReemplazo.Text.Trim
          

            Dim msgAlerta As String = ""
            Dim msgError As String = ""


            msgError = objLogica.Anulacion_Operacion_Transporte_Salm(objEntidad, msgAlerta)
           
            If msgError.Length = 0 Then
                oHebraEnvioEmailReq = New Thread(AddressOf Enviar_Anulacion_operacion_con_gastos)
                oHebraEnvioEmailReq.Start()
                HelpClass.MsgBox("LA OPERACION SE ANULO SATISFACTORIAMENTE", MessageBoxIcon.Information)
               
                DialogResult = Windows.Forms.DialogResult.OK

            End If

            

        Catch ex As Exception
            DialogResult = Windows.Forms.DialogResult.Cancel
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim Operacion As String
            Dim frm As New frmAsignaOperacion
            frm.CCMPN = CCMPN
            frm.CDVSN = CDVSN
            frm.CCLINT = CCLINT
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Operacion = frm.OrdenReemplazo
                If Operacion.Trim.Equals("") Or Operacion.Trim.Equals(txtoperacion.Text.Trim) Then
                    MessageBox.Show("La operación  de reemplazo no debe ser igual a la operación que se va a anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    txtOpReemplazo.Text = Operacion
                    txtReemplazo.Text = String.Format("Se reemplazó con la Operación {0}", Operacion)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub cargarMotivo()
        Dim obj As New TipoDatoGeneral_BLL
        Dim Entidad As New TipoDatoGeneral
        Dim Entidad2 As TipoDatoGeneral
        Dim lista As New List(Of TipoDatoGeneral)
        Dim lista2 As New List(Of TipoDatoGeneral)
        Entidad.CODIGO_TIPO = "0"
        Entidad.DESC_TIPO = "[Seleccione]"
        lista = obj.Lista_Tipo_Dato_General(CCMPN, "STMOAN")
        lista2.Add(Entidad)
        For Each Item As TipoDatoGeneral In lista
            Entidad2 = New TipoDatoGeneral
            Entidad2.CODIGO_TIPO = Item.CODIGO_TIPO
            Entidad2.DESC_TIPO = Item.DESC_TIPO
            lista2.Add(Entidad2)
        Next
        cboMotivoAnulacion.DataSource = lista2
        cboMotivoAnulacion.DisplayMember = "DESC_TIPO"
        cboMotivoAnulacion.ValueMember = "CODIGO_TIPO"
        cboMotivoAnulacion.SelectedValue = "0"
    End Sub

    Private Sub Enviar_Anulacion_operacion_con_gastos()
        Try
            Dim Entidad As New Solicitud_Transporte
            Dim dt As New DataTable
            Entidad.NOPRCN = CDec(txtoperacion.Text)   'numero de la operacion
            Control.CheckForIllegalCrossThreadCalls = False
            Dim Envio As New EnvioEmailAnulacionOperacion
            Envio.CULUSA = MainModule.USUARIO
            Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
            Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")
            Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
            Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
            Envio.Mailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            If Envio.Enviar_Email_Anulacion_operacion_gastos(Entidad) = 1 Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Autorizado_Por()
        Dim oListColum As New Hashtable
        Dim Etiquetas As New List(Of String)
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New SOLMIN_ST.NEGOCIO.Consultas.AtributosOI_BLL()

        Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL
        Dim dtb As New List(Of TipoDatoGeneral)
        dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(CCMPN, "UATAOP")

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO_TIPO"
        oColumnas.DataPropertyName = "CODIGO_TIPO"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_TIPO"
        oColumnas.DataPropertyName = "DESC_TIPO"
        oColumnas.HeaderText = "Nombre"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Nombre")

        Me.UcAutorizadoPor.Etiquetas_Form = Etiquetas
        Me.UcAutorizadoPor.DataSource = dtb
        Me.UcAutorizadoPor.ListColumnas = oListColum
        Me.UcAutorizadoPor.Cargas()
        Me.UcAutorizadoPor.DispleyMember = "DESC_TIPO"
        Me.UcAutorizadoPor.ValueMember = "CODIGO_TIPO"
    End Sub

    Private Sub Cargar_Area_Responsabilidad()
        Dim oListColum As New Hashtable
        Dim Etiquetas As New List(Of String)
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New SOLMIN_ST.NEGOCIO.Consultas.AtributosOI_BLL()

        Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL
        Dim dtb As New List(Of TipoDatoGeneral)
        dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(CCMPN, "AREADM")

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO_TIPO"
        oColumnas.DataPropertyName = "CODIGO_TIPO"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_TIPO"
        oColumnas.DataPropertyName = "DESC_TIPO"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.UcArea.Etiquetas_Form = Etiquetas
        Me.UcArea.DataSource = dtb
        Me.UcArea.ListColumnas = oListColum
        Me.UcArea.Cargas()
        Me.UcArea.DispleyMember = "DESC_TIPO"
        Me.UcArea.ValueMember = "CODIGO_TIPO"
    End Sub

#End Region

    Private Sub cmbUsuarioSolicitante_InformationChanged() Handles cmbUsuarioSolicitante.InformationChanged
        txtUsuarioSolicitante.Text = cmbUsuarioSolicitante.pPSMMNUSR.ToString.Trim
    End Sub
    Private Sub cmbUsuarioSolicitante_Load(sender As Object, e As EventArgs) Handles cmbUsuarioSolicitante.Load

    End Sub
End Class
