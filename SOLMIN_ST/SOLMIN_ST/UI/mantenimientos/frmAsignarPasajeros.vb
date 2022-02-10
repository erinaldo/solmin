Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Imports System
Imports System.Collections.Generic

Public Class frmAsignarPasajeros
    Enum TIPO
        MODIFICAR
        ASIGNAR
    End Enum
    Private bolCambioPasajero As Boolean = False
    Private _TipoOperacion As TIPO

    Public Property TipoOperacion() As TIPO
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As TIPO)
            _TipoOperacion = value
        End Set

    End Property


    Private _ObjPasajero As Viaje_Pasajero
    Public Property ObjPasajero() As Viaje_Pasajero
        Get
            Return _ObjPasajero
        End Get
        Set(ByVal value As Viaje_Pasajero)
            _ObjPasajero = value
        End Set
    End Property


    Private _ObjPersonal As Personal_Contratista
    Public Property ObjPersonal() As Personal_Contratista
        Get
            Return _ObjPersonal
        End Get
        Set(ByVal value As Personal_Contratista)
            _ObjPersonal = value
        End Set
    End Property

    Private _ObjViaje_Ruta As Viaje_Ruta
    Public Property ObjViaje_Ruta() As Viaje_Ruta
        Get
            Return _ObjViaje_Ruta
        End Get
        Set(ByVal value As Viaje_Ruta)
            _ObjViaje_Ruta = value
        End Set
    End Property

    Private Sub CargarFiltroPasajeros()

        'Filtro de Pasajeros
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTIPODOC"
        oColumnas.DataPropertyName = "PSTIPODOC"
        oColumnas.HeaderText = "Tipo Documento"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSNMDCPE"
        oColumnas.DataPropertyName = "PSNMDCPE"
        oColumnas.HeaderText = "Nro Documento"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSAPENOM"
        oColumnas.DataPropertyName = "PSAPENOM"
        oColumnas.HeaderText = "Nombre"
        oListColum.Add(3, oColumnas)

        Dim ObjPersonal_BL As New Personal_Contratista_BL
        Dim ObjList As New List(Of Personal_Contratista)
        ObjList = ObjPersonal_BL.ListarPersonalFiltro(_ObjPersonal)

        If ObjList.Count > 0 Then
            Me.txtPasajero.DataSource = ObjPersonal_BL.ListarPersonalFiltro(_ObjPersonal)
        Else
            Me.txtPasajero.DataSource = Nothing

        End If

        Me.txtPasajero.ListColumnas = oListColum
        Me.txtPasajero.Cargas()
        Me.txtPasajero.Limpiar()
        Me.txtPasajero.DispleyMember = "PSAPENOM"
        Me.txtPasajero.ValueMember = "PSNMDCPE"
    End Sub

    Private Sub CargarFiltroContratista(ByVal PNCCLNT As Double)
        'Filtro de Contratistas
        Dim oListColum As New Hashtable
        oListColum = New Hashtable

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCPRVCL"
        oColumnas.DataPropertyName = "PNCPRVCL"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTPRVCL"
        oColumnas.DataPropertyName = "PSTPRVCL"
        oColumnas.HeaderText = "Contratista "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Dim ObjContratista_BL As New Contratista_Cliente_BL
        Dim ObjContratista As New Contratista_Cliente
        Dim ObjList As New List(Of Contratista_Cliente)
        ObjContratista.PNCCLNT = PNCCLNT
        ObjList = ObjContratista_BL.ListarContratistaFiltro(ObjContratista)

        If ObjList.Count > 0 Then
            Me.txtContratista.DataSource = ObjContratista_BL.ListarContratistaFiltro(ObjContratista)
        Else
            Me.txtContratista.DataSource = Nothing
        End If

        Me.txtContratista.ListColumnas = oListColum
        Me.txtContratista.Cargas()
        Me.txtContratista.DispleyMember = "PSTPRVCL"
        Me.txtContratista.ValueMember = "PNCPRVCL"
    End Sub

    Private Sub frmAsignarPasajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.TipoOperacion = TIPO.ASIGNAR Then
                CargarFiltroContratista(_ObjPersonal.PNCCLNT)
                Me.txtClienteFiltro.pCargar(_ObjPersonal.PNCCLNT)
            Else
                'Muestra los valores de la Entidad
                Me.txtEmbarque.Text = ObjPasajero.PNNCREMB
                txtClienteFiltro.pCargar(ObjPasajero.PNCCLNT)
                Me.CargarFiltroContratista(ObjPasajero.PNCCLNT)

                txtContratista.Valor = ObjPasajero.PNCPRVCL.ToString
                txtPasajero.Valor = ObjPasajero.PSNMDCPE

                Me.txtLugarDestino.Text = ObjPasajero.PSTCMLGD
                If ObjPasajero.PSSSGRSD = "X" Then
                    Me.dtpSeguroSocial.Checked = True
                    Me.dtpSeguroSocial.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCVNSS)
                End If
                If ObjPasajero.PSSSGRSP = "X" Then
                    Me.dtpSeguroPension.Checked = True
                    Me.dtpSeguroPension.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCVNSP)
                End If

                If ObjPasajero.PSSSGRSV = "X" Then
                    Me.dtpSeguroVida.Checked = True
                    Me.dtpSeguroVida.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCVNSV)
                End If

                If ObjPasajero.PSSSGRAP = "X" Then
                    Me.dtpSeguroAccidente.Checked = True
                    Me.dtpSeguroAccidente.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCVNSA)
                End If

                If ObjPasajero.PSSSGRAP = "X" Then
                    Me.dtpSeguroAccidente.Checked = True
                    Me.dtpSeguroAccidente.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCVNSA)
                End If

                If ObjPasajero.PNFCEXMD <> 0 Then
                    Me.dtpExamenMedico.Checked = True
                    Me.dtpExamenMedico.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCEXMD)
                End If

                If ObjPasajero.PSSSDCSL = "X" Then
                    Me.chkDeclaracionSalud.Checked = True
                End If

                If ObjPasajero.PSSSVCNR = "X" Then
                    Me.chkVacunasRequeridas.Checked = True
                End If

                If ObjPasajero.PNFCRSSG <> 0 Then
                    Me.dtpCursoSeguridad.Checked = True
                    Me.dtpCursoSeguridad.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFCRSSG)
                End If

                Me.txtMotivoIngreso.Text = ObjPasajero.PSTMTVIN
                Me.txtOrdenCompra.Text = ObjPasajero.PSNORCMC

                If ObjPasajero.PSNPSPER <> "" Then
                    Me.dtpVencimientoPase.Checked = True
                    Me.dtpVencimientoPase.Value = HelpClass.CNumero_a_Fecha(ObjPasajero.PNFVCPSP)
                    Me.txtPasePersonal.Text = ObjPasajero.PSNPSPER
                End If

            End If

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ObtenerInformacion(ByVal ObjPasajero As Viaje_Pasajero)
        ObjPasajero.PNNCREMB = Me.txtEmbarque.Text
        ObjPasajero.PSTCMLGD = Me.txtLugarDestino.Text
        ObjPasajero.PSSSGRSD = IIf(Me.dtpSeguroSocial.Checked, "X", "")
        ObjPasajero.PNFCVNSS = IIf(Me.dtpSeguroSocial.Checked, HelpClass.CtypeDate(Me.dtpSeguroSocial.Value), 0)
        ObjPasajero.PSSSGRSP = IIf(Me.dtpSeguroPension.Checked, "X", "")
        ObjPasajero.PNFCVNSP = IIf(Me.dtpSeguroPension.Checked, HelpClass.CtypeDate(Me.dtpSeguroPension.Value), 0)
        ObjPasajero.PSSSGRSV = IIf(Me.dtpSeguroVida.Checked, "X", "")
        ObjPasajero.PNFCVNSV = IIf(Me.dtpSeguroVida.Checked, HelpClass.CtypeDate(Me.dtpSeguroVida.Value), 0)
        ObjPasajero.PSSSGRAP = IIf(Me.dtpSeguroAccidente.Checked, "X", "")
        ObjPasajero.PNFCVNSA = IIf(Me.dtpSeguroAccidente.Checked, HelpClass.CtypeDate(Me.dtpSeguroAccidente.Value), 0)
        ObjPasajero.PNFCEXMD = IIf(Me.dtpExamenMedico.Checked, HelpClass.CtypeDate(Me.dtpExamenMedico.Value), 0)
        ObjPasajero.PSSSDCSL = IIf(Me.chkDeclaracionSalud.Checked, "X", "")
        ObjPasajero.PSSSVCNR = IIf(Me.chkVacunasRequeridas.Checked, "X", "")
        ObjPasajero.PNFCRSSG = IIf(Me.dtpCursoSeguridad.Checked, HelpClass.CtypeDate(Me.dtpCursoSeguridad.Value), 0)
        ObjPasajero.PSTMTVIN = Me.txtMotivoIngreso.Text
        ObjPasajero.PSNORCMC = Me.txtOrdenCompra.Text
        ObjPasajero.PSNPSPER = IIf(Me.dtpVencimientoPase.Checked, Me.txtPasePersonal.Text, "")
        ObjPasajero.PNFVCPSP = IIf(Me.dtpVencimientoPase.Checked, HelpClass.CtypeDate(Me.dtpVencimientoPase.Value), 0)
    End Sub


    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Me.txtClienteFiltro.pCodigo = 0 Then
            lstr_validacion += "* CLIENTE " & Chr(13)
        End If

        If txtContratista.Resultado Is Nothing Then
            lstr_validacion += "* CONTRATISTA " & Chr(13)
        End If

        If txtPasajero.Resultado Is Nothing Then
            lstr_validacion += "* PASAJERO " & Chr(13)
        End If

        If txtEmbarque.Text = "" OrElse Not IsNumeric(txtEmbarque.Text) Then
            lstr_validacion += "* NRO EMBARQUE " & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar_Inputs() Then Exit Sub
        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.NuevoPasajero()
        Else
            Me.Modificar()
        End If
    End Sub

    Private Sub NuevoPasajero()
        Dim ObjPasajero As New Viaje_Pasajero
        Dim ObjPasajero_BL As New Viaje_Pasajero_BLL

        Me.ObtenerInformacion(ObjPasajero)

        ObjPasajero.PNNPRGVJ = _ObjViaje_Ruta.PNNPRGVJ
        ObjPasajero.PNNCRRRT = _ObjViaje_Ruta.PNNCRRRT
        ObjPasajero.PNCCLNT = _ObjPersonal.PNCCLNT
        ObjPasajero.PNCPRVCL = _ObjPersonal.PNCPRVCL
        ObjPasajero.PSTPDCPE = _ObjPersonal.PSTPDCPE
        ObjPasajero.PSNMDCPE = _ObjPersonal.PSNMDCPE
        ObjPasajero.PSSESTRG = "A"
        ObjPasajero.PSCUSCRT = MainModule.USUARIO
        ObjPasajero.PNFCHCRT = HelpClass.TodayNumeric
        ObjPasajero.PNHRACRT = HelpClass.NowNumeric
        ObjPasajero.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        Dim intResult As Integer = ObjPasajero_BL.Insertar_Viaje_Pasajero(ObjPasajero)
        Select Case intResult
            Case 0
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Case 2
                HelpClass.MsgBox("No se puede Exceder el Límite de Cupos")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

            Case 3
                HelpClass.MsgBox("El Pasajero ya se encuentra Asignado en esta Programación")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

            Case Else
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
        End Select

    End Sub
    Private Sub Modificar()
        Dim ObjPasajeroTemp As New Viaje_Pasajero
        Dim ObjPasajero_BL As New Viaje_Pasajero_BLL

        Me.ObtenerInformacion(ObjPasajeroTemp)

        ObjPasajeroTemp.PNNPRGVJ = _ObjPasajero.PNNPRGVJ
        ObjPasajeroTemp.PNNCRRRT = _ObjPasajero.PNNCRRRT
        ObjPasajeroTemp.PNNCRRIN = _ObjPasajero.PNNCRRIN
        ObjPasajeroTemp.PNCCLNT = _ObjPasajero.PNCCLNT
        ObjPasajeroTemp.PNCPRVCL = _ObjPasajero.PNCPRVCL
        If bolCambioPasajero Then
            ObjPasajeroTemp.PSTPDCPE = _ObjPersonal.PSTPDCPE
            ObjPasajeroTemp.PSNMDCPE = _ObjPersonal.PSNMDCPE

        Else
            ObjPasajeroTemp.PSTPDCPE = _ObjPasajero.PSTPDCPE
            ObjPasajeroTemp.PSNMDCPE = _ObjPasajero.PSNMDCPE
        End If
    
        ObjPasajeroTemp.PSCULUSA = MainModule.USUARIO
        ObjPasajeroTemp.PNFULTAC = HelpClass.TodayNumeric
        ObjPasajeroTemp.PNHULTAC = HelpClass.NowNumeric
        ObjPasajeroTemp.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        Dim intResult As Integer = ObjPasajero_BL.Actualizar_Viaje_Pasajero(ObjPasajeroTemp)
        Select Case intResult
            Case 0
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Case 2
                HelpClass.MsgBox("El Pasajero ya se encuentra Asignado en esta Programación")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

            Case Else
                HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
        End Select

       
    End Sub

    Private Sub dtpVencimientoPase_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpVencimientoPase.ValueChanged
        Me.txtPasePersonal.Enabled = Me.dtpVencimientoPase.Checked
    End Sub

    Private Sub txtPasajero_CambioDeTexto(ByVal objData As System.Object) Handles txtPasajero.CambioDeTexto
        If Not Me.txtPasajero.Resultado Is Nothing Then
            Dim ObjTemp As New Personal_Contratista
            ObjTemp = CType(Me.txtPasajero.Resultado, Personal_Contratista)
            _ObjPersonal.PSTPDCPE = ObjTemp.PSTPDCPE
            _ObjPersonal.PSNMDCPE = ObjTemp.PSNMDCPE
            bolCambioPasajero = True

        End If
    End Sub

    Private Sub txtContratista_CambioDeTexto(ByVal objData As System.Object) Handles txtContratista.CambioDeTexto
        Dim ObjTemp As New Contratista_Cliente '
        If Not Me.txtContratista.Resultado Is Nothing Then
            ObjTemp = CType(Me.txtContratista.Resultado, Contratista_Cliente)
            If _ObjPersonal Is Nothing Then
                _ObjPersonal = New Personal_Contratista
                _ObjPersonal.PNCCLNT = ObjPasajero.PNCCLNT
            End If
           _ObjPersonal.PNCPRVCL = ObjTemp.PNCPRVCL
            CargarFiltroPasajeros()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class
