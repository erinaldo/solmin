Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimiento
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Public Class frmEnvioPedidoAlquiler
 

    Private _NumAlquiler As Decimal = 0
    Public Property NumAlquiler() As Decimal
        Get
            Return _NumAlquiler
        End Get
        Set(ByVal value As Decimal)
            _NumAlquiler = value
        End Set
    End Property

    Private _Compania As String = ""
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property

    Private _proveedor As String = ""
    Public Property proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property
    Private _Tipo_recurso As String = ""
    Public Property Tipo_recurso() As String
        Get
            Return _Tipo_recurso
        End Get
        Set(ByVal value As String)
            _Tipo_recurso = value
        End Set
    End Property
    Private _placa As String = ""
    Public Property placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property
    Private _servicio As String = ""
    Public Property servicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property


    Private _myDialogResult As Boolean = False
    Public Property myDialogResult() As Boolean
        Get
            Return _myDialogResult
        End Get
        Set(ByVal value As Boolean)
            _myDialogResult = value
        End Set
    End Property


    Enum Opcion_Mant
        Actualizar
        Neutro
    End Enum
    Private opc As Opcion_Mant = Opcion_Mant.Neutro

    Private Sub Accion(ByVal TipoAccion As Opcion_Mant)
        Select Case TipoAccion
            Case Opcion_Mant.Neutro
                ToolStripButton1.Enabled = True 'MODIFICAR
                btnAceptar.Enabled = False   'GUARDAR
                btnCancelar.Enabled = False   'CANCELAR
                ToolStripButton2.Enabled = True  'ENVIAR SAP
            Case Opcion_Mant.Actualizar
                ToolStripButton1.Enabled = False  'MODIFICAR
                btnAceptar.Enabled = True   'GUARDAR
                btnCancelar.Enabled = True  'CANCELAR
                ToolStripButton2.Enabled = False 'ENVIAR SAP
        End Select

    End Sub
    Private Sub Habilitar_Control(ByVal Habilitar As Boolean)
        KryptonTextBox7.Enabled = Habilitar
        cmbMoneda.ComboBox.Enabled = Habilitar
        TextBox1.Enabled = Habilitar
    End Sub
    Private Sub frmEnvioPedidoAlquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Moneda()

            Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
            Dim obeAlquiler As New AlquilerUnidad
            Dim obeDatosAlquiler As New AlquilerUnidad
            obeAlquiler.NRALQT = _NumAlquiler
            obeAlquiler.CCMPN = _Compania
            obeDatosAlquiler = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(obeAlquiler)
            If obeDatosAlquiler IsNot Nothing Then
                Compania = obeDatosAlquiler.CCMPN
                txtNroAlquiler1.Text = obeDatosAlquiler.NRALQT
                KryptonTextBox3.Text = HelpClass.FechaNum_a_Fecha(obeDatosAlquiler.FVALIN)
                KryptonTextBox1.Text = HelpClass.FechaNum_a_Fecha(obeDatosAlquiler.FVALFI)
                KryptonTextBox2.Text = proveedor
                KryptonTextBox4.Text = Tipo_recurso
                KryptonTextBox5.Text = placa
                KryptonTextBox8.Text = servicio
                KryptonTextBox7.Text = obeDatosAlquiler.TOBRE3.Trim

                If obeDatosAlquiler.IRVAL1 = 0 Then
                    
                    Accion(Opcion_Mant.Actualizar)
                    TextBox1.Text = Val(obeDatosAlquiler.IRVALQ)
                    cmbMoneda.SelectedValue = obeDatosAlquiler.CMNALQ.ToString
                    Habilitar_Control(True)
                Else
 
                    Accion(Opcion_Mant.Neutro)
                    TextBox1.Text = VAL(obeDatosAlquiler.IRVAL1)
                    cmbMoneda.SelectedValue = obeDatosAlquiler.CMNAL1.ToString
                    Habilitar_Control(False)
                End If
         
            End If
        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar_Moneda()
       
        Dim obMonedaBLL As New Moneda_BLL
        Dim dtMoneda As New DataTable
        dtMoneda = obMonedaBLL.Listar_Monedas_Basica
        cmbMoneda.DataSource = dtMoneda
        cmbMoneda.ValueMember = "pCMNDA1_Codigo"
        cmbMoneda.DisplayMember = "pTMNDA_Detalle"
        cmbMoneda.SelectedValue = "1"


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Val(TextBox1.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese monto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If cmbMoneda.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione moneda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim oAlquilerUnidad As New AlquilerUnidad_BLL
            Dim obeAlquiler As New AlquilerUnidad
            obeAlquiler.CCMPN = _Compania
            obeAlquiler.NRALQT = _NumAlquiler
            obeAlquiler.CMNAL1 = cmbMoneda.SelectedValue
            obeAlquiler.IRVAL1 = TextBox1.Text.Trim
            obeAlquiler.TOBRE3 = KryptonTextBox7.Text.Trim
            obeAlquiler.CULUSA = MainModule.USUARIO
            oAlquilerUnidad.Actualizar_Alquiler_Unidad_Liquidacion(obeAlquiler)
            Listar_datos_Para_envio_SAP()
            Accion(Opcion_Mant.Neutro)
            Habilitar_Control(False)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try

            Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
            Dim obeAlquiler As New AlquilerUnidad
            Dim obeDatosAlquiler As New AlquilerUnidad
            obeAlquiler.NRALQT = _NumAlquiler
            obeAlquiler.CCMPN = _Compania
            obeDatosAlquiler = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(obeAlquiler)
            If obeDatosAlquiler.IRVAL1 = 0 Then
                MessageBox.Show("Debe actualizar los montos a enviar a SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oAlquilerUnidad As New AlquilerUnidad_BLL
            Dim objEntidad As New AlquilerUnidad
            objEntidad.CCMPN = Compania

            Dim dtAlquiler As New DataTable
            Dim objEntidadOPAlq As New AlquilerUnidad
            objEntidadOPAlq.NRALQT = NumAlquiler
            Dim dtOpAlquiler As New DataTable
            objEntidadOPAlq.CCMPN = Compania
            dtAlquiler = oAlquilerUnidad.Listar_Datos_Liquidacion_Alquiler(objEntidadOPAlq)


            If dtAlquiler.Rows.Count = 0 Then
                Generar_OrdenInterna_Operacion_Liquidar()
            Else
                If dtAlquiler.Rows(0)("NLQDCN") = 0 Then
                    Generar_OrdenInterna_Operacion_Liquidar()
                Else
                    MessageBox.Show("El alquiler se encuentra enviado al SAP. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Listar_datos_Para_envio_SAP()
            Accion(Opcion_Mant.Neutro)
            Habilitar_Control(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Listar_datos_Para_envio_SAP()
        Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
        Dim obeAlquiler As New AlquilerUnidad
        Dim obeDatosAlquiler As New AlquilerUnidad
        obeAlquiler.NRALQT = _NumAlquiler
        obeAlquiler.CCMPN = _Compania
        obeDatosAlquiler = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(obeAlquiler)
        If obeDatosAlquiler IsNot Nothing Then
            Compania = obeDatosAlquiler.CCMPN
            txtNroAlquiler1.Text = obeDatosAlquiler.NRALQT
            KryptonTextBox3.Text = HelpClass.FechaNum_a_Fecha(obeDatosAlquiler.FVALIN)
            KryptonTextBox1.Text = HelpClass.FechaNum_a_Fecha(obeDatosAlquiler.FVALFI)
            KryptonTextBox2.Text = proveedor
            KryptonTextBox4.Text = Tipo_recurso
            KryptonTextBox5.Text = placa
            KryptonTextBox8.Text = servicio
            KryptonTextBox7.Text = obeDatosAlquiler.TOBRE3.Trim
            TextBox1.Text = Val(obeDatosAlquiler.IRVAL1)
            cmbMoneda.SelectedValue = obeDatosAlquiler.CMNAL1.ToString


        End If

    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim oAlquilerUnidad As New AlquilerUnidad_BLL
            Dim dtAlquiler As New DataTable
            Dim obeAlquiler As New AlquilerUnidad
            obeAlquiler.NOPRCN = 0
            obeAlquiler.NRALQT = _NumAlquiler
            dtAlquiler = oAlquilerUnidad.Listar_Datos_Liquidacion_Alquiler(obeAlquiler)
            If dtAlquiler.Rows.Count > 0 Then
                If dtAlquiler.Rows(0)("NLQDCN") > 0 Then
                    MessageBox.Show("No se puede modificar. El alquiler está enviado a SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            Accion(Opcion_Mant.Actualizar)
            Habilitar_Control(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Generar_OrdenInterna_Operacion_Liquidar()
        Dim objAlquilerUnidadBLL As New AlquilerUnidad_BLL
        Dim sMensajeError As String = ""
        Dim objEntidad As New AlquilerUnidad
        objEntidad.CCMPN = Compania
        objEntidad.NRALQT = _NumAlquiler
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        Dim dtOpAlquiler As New DataTable
        If objAlquilerUnidadBLL.Validar_Configuracion_Servicio_Alquiler(objEntidad, sMensajeError) = True Then
            If MsgBox("Está seguro de  enviar el pedido SAP?", MsgBoxStyle.OkCancel, "Envio pedido  SAP") = MsgBoxResult.Ok Then

                Dim OI As Decimal = 0
                Dim ClaseOI As String = ""
                Dim oAlquilerUnidad As New AlquilerUnidad

                Dim objEntidadOPAlq As New AlquilerUnidad
                objEntidadOPAlq.NRALQT = _NumAlquiler
                objEntidadOPAlq.CCMPN = Compania
                dtOpAlquiler = objAlquilerUnidadBLL.Obtener_Operacion_Alquiler_Unidad(objEntidadOPAlq)
                If dtOpAlquiler.Rows.Count > 0 Then

                    If dtOpAlquiler.Rows(0)("NORINS") = 0 Then
                        oAlquilerUnidad = objAlquilerUnidadBLL.Generar_Orden_Interna_Alquiler(objEntidad)
                        OI = oAlquilerUnidad.NORINS
                        ClaseOI = oAlquilerUnidad.CCLORI
                    Else
                        OI = dtOpAlquiler.Rows(0)("NORDIN")
                        ClaseOI = dtOpAlquiler.Rows(0)("CCLORI")
                    End If
                    If OI = 0 Then
                        MessageBox.Show("El proceso no se pudo completar.No se generó la Orden Interna", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If dtOpAlquiler.Rows(0)("NOPRCN") = 0 Then
                        Dim objEntidadOP As New AlquilerUnidad
                        objEntidadOP.CUSCRT = MainModule.USUARIO
                        objEntidadOP.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                        objEntidadOP.NRALQT = _NumAlquiler
                        objEntidadOP.NORINS = OI
                        objEntidadOP.CCLORI = ClaseOI
                        objAlquilerUnidadBLL.Registrar_Operacion_Transporte_Alquiler(objEntidadOP)
                    End If

                    objEntidadOPAlq = New AlquilerUnidad
                    objEntidadOPAlq.NRALQT = _NumAlquiler
                    objEntidadOPAlq.CCMPN = objEntidad.CCMPN
                    dtOpAlquiler = objAlquilerUnidadBLL.Obtener_Operacion_Alquiler_Unidad(objEntidadOPAlq)

                    If dtOpAlquiler.Rows.Count > 0 Then

                        If dtOpAlquiler.Rows(0)("NOPRCN") > 0 Then

                            Dim GuiaTranspo As New GuiaTransportista_BLL
                            Dim msgError As String = ""
                            GuiaTranspo.Validar_GuiaTransportista_ProvAlquiler(Compania, _NumAlquiler, 1, MainModule.USUARIO, Ransa.Utilitario.HelpClass.NombreMaquina, msgError)
                            If msgError.Length > 0 Then
                                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Dim objEntidadLiq As New AlquilerUnidad
                                objEntidadLiq.NRALQT = _NumAlquiler
                                objEntidadLiq.CUSCRT = MainModule.USUARIO
                                objEntidadLiq.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                objAlquilerUnidadBLL.Procesar_Liquidacion_Alquiler(objEntidadLiq)
                                msgError = ""
                                GuiaTranspo.Validar_GuiaTransportista_ProvAlquiler(objEntidad.CCMPN, _NumAlquiler, 2, MainModule.USUARIO, Ransa.Utilitario.HelpClass.NombreMaquina, msgError)
                                If msgError.Length > 0 Then
                                    MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    _myDialogResult = True
                                    MessageBox.Show("El alquiler se envió correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                End If
                            End If

                        Else
                            MessageBox.Show("No se pudo completar el proceso.No se ha generado la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If

                End If

            End If
        Else
            MessageBox.Show(sMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
 

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

End Class
