Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.MANTENIMIENTO


Public Class frmAsignarRutas


    Enum TIPO
        MODIFICAR
        ASIGNAR
    End Enum

    Private _TipoOperacion As TIPO
    Private _ObjViaje_Ruta As Viaje_Ruta
    Private _ObjViajes_Cliente As Viajes_Cliente

    Public Property TipoOperacion() As TIPO
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As TIPO)
            _TipoOperacion = value
        End Set

    End Property

    Public Property ObjViaje_Ruta() As Viaje_Ruta
        Get
            Return _ObjViaje_Ruta
        End Get
        Set(ByVal value As Viaje_Ruta)
            _ObjViaje_Ruta = value
        End Set
    End Property

    Public Property ObjViajes_Cliente() As Viajes_Cliente
        Get
            Return _ObjViajes_Cliente
        End Get
        Set(ByVal value As Viajes_Cliente)
            _ObjViajes_Cliente = value
        End Set
    End Property


    Dim ObjViajes_Ruta_BL As New Viajes_Ruta_BL


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar_Inputs() = True Then Exit Sub

        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.NuevoViajeRuta()
        Else
            Me.ActualizaViajeRuta()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub NuevoViajeRuta()

        Dim ObjViajes_Ruta_BL As New Viajes_Ruta_BL
        Dim ObjEntidad As New Viaje_Ruta


        ObtieneInformacion(ObjEntidad)
        ObjEntidad.PNNPRGVJ = Me.ObjViajes_Cliente.PNNPRGVJ
        ObjEntidad.PNQCPSUT = 0

        ObjEntidad.PSSESTRG = "A"
        ObjEntidad.PSCUSCRT = MainModule.USUARIO
        ObjEntidad.PNFCHCRT = HelpClass.TodayNumeric
        ObjEntidad.PNHRACRT = HelpClass.NowNumeric
        ObjEntidad.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        If ObjViajes_Ruta_BL.Insertar_Viaje_Ruta(ObjEntidad) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Asignó Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub ObtieneInformacion(ByVal ObjEntidad As Viaje_Ruta)

        ObjEntidad.PNCLCLOR = CType(Me.cboLugarorigen.Resultado, LocalidadRuta).CLCLD
        ObjEntidad.PNCLCLDS = CType(Me.cboLugarDestino.Resultado, LocalidadRuta).CLCLD
    ObjEntidad.PNFSLDRT = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFecha.Value)
    ObjEntidad.PNHSLDRT = HelpClass.ConvertHoraNumeric(txtHoraRegistro.Text)
        ObjEntidad.PNQCPSDS = Me.txtCuposDisponibles.Text

    End Sub

    Private Sub ActualizaViajeRuta()
        Me.ObtieneInformacion(_ObjViaje_Ruta)
        _ObjViaje_Ruta.PSCULUSA = MainModule.USUARIO
        _ObjViaje_Ruta.PNFULTAC = HelpClass.TodayNumeric
        _ObjViaje_Ruta.PNHULTAC = HelpClass.NowNumeric
        _ObjViaje_Ruta.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If ObjViajes_Ruta_BL.Actualizar_Viaje_Ruta(_ObjViaje_Ruta) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub


    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If cboLugarorigen.Resultado Is Nothing Then
            lstr_validacion += "* LUGAR ORIGEN " & Chr(13)
        End If

        If cboLugarDestino.Resultado Is Nothing Then
            lstr_validacion += "* LUGAR DESTINO " & Chr(13)
        End If

        If Not IsDate(Me.txtHoraRegistro.Text) OrElse Me.txtHoraRegistro.Text = "00:00:00" Then
            lstr_validacion += "* HORA " & Chr(13)
        End If

        If Me.txtCuposDisponibles.Text = "" OrElse Not IsNumeric(Me.txtCuposDisponibles.Text) Then
            lstr_validacion += "* CUPOS DISPONIBLES " & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub frmAsignarRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objDt As List(Of LocalidadRuta)
        Dim obj_Logica_Localidad As New Localidad_BLL
        objDt = obj_Logica_Localidad.Listar_Localidades(ObjViajes_Cliente.PSCCMPN)
 
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarorigen.DataSource = objDt
        Me.cboLugarorigen.ListColumnas = oListColum
        Me.cboLugarorigen.Cargas()
        Me.cboLugarorigen.DispleyMember = "TCMLCL"
        Me.cboLugarorigen.ValueMember = "CLCLD"

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"

        If Me.TipoOperacion = TIPO.MODIFICAR Then
            Me.cboLugarorigen.Valor = _ObjViaje_Ruta.PNCLCLOR
            Me.cboLugarDestino.Valor = _ObjViaje_Ruta.PNCLCLDS
            Me.dtpFecha.Value = HelpClass.CNumero_a_Fecha(_ObjViaje_Ruta.PNFSLDRT).ToString
            txtHoraRegistro.Text = HelpClass.CNumero_a_Hora_string(_ObjViaje_Ruta.PNHSLDRT).ToString
            Me.txtCuposDisponibles.Text = _ObjViaje_Ruta.PNQCPSDS
        End If

    End Sub

  
    Private Sub txtCuposDisponibles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuposDisponibles.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class
