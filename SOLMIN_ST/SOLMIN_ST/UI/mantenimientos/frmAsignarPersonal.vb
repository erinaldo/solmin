Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic

Imports System.Text
Imports System.IO.Ports
Public Class frmAsignarPersonal
    
    Enum TIPO
        MODIFICAR
        ASIGNAR
    End Enum

    Private _TipoOperacion As TIPO
    Private _ObjContratista As Contratista_Cliente
    Private _ObjPersonal As Personal_Contratista

    Public Property TipoOperacion() As TIPO
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As TIPO)
            _TipoOperacion = value
        End Set

    End Property

    Public Property ObjContratista() As Contratista_Cliente
        Get
            Return _ObjContratista
        End Get
        Set(ByVal value As Contratista_Cliente)
            _ObjContratista = value
        End Set
    End Property

    Public Property ObjPersonal() As Personal_Contratista
        Get
            Return _ObjPersonal
        End Get
        Set(ByVal value As Personal_Contratista)
            _ObjPersonal = value
        End Set
    End Property


    Dim ObjPersonal_BL As New Personal_Contratista_BL
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ActualizaPersonal()
        ObtieneInformacion(_ObjPersonal)
        _ObjPersonal.PSCULUSA = MainModule.USUARIO
        _ObjPersonal.PNFULTAC = HelpClass.TodayNumeric
        _ObjPersonal.PNHULTAC = HelpClass.NowNumeric
        _ObjPersonal.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If ObjPersonal_BL.Actualizar_Personal_Contratista(Me._ObjPersonal) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub ObtieneInformacion(ByVal objTemp As Personal_Contratista)
        
        objTemp.PSNMBPER = Me.txtNombre.Text.Trim
        objTemp.PSAPEPER = Me.txtApellido.Text.Trim
        objTemp.PNFNCMTO = HelpClass.CtypeDate(Me.dtpFechaNac.Value)
        objTemp.PSTNCION = Me.txtNacionalidad.Text.Trim
        objTemp.PSTDRCPE = Me.txtDireccion.Text.Trim
        objTemp.PSGRDACA = Me.cboGradoAcademico.SelectedValue.ToString.Trim
        objTemp.PSCCTPPE = Me.txtPuesto.Text.Trim
        objTemp.PNFINGEM = HelpClass.CtypeDate(Me.dtpFechaIng.Value)
        objTemp.PSPDCNAT = IIf(Me.rbComunidadSI.Checked, "1", "0")
        objTemp.PSNMCNAP = IIf(Me.rbComunidadSI.Checked, Me.txtComunidad.Text, "")
        objTemp.PNNDIART = txtNroDiaRotacion.Text '_ObjContratista.PNNDIART
    End Sub

    Private Sub NuevoPersonal()
        Dim objPersonal As New Personal_Contratista
        'Obtiene la Informacion del Formulario
        objPersonal.PNCCLNT = _ObjContratista.PNCCLNT
        objPersonal.PNCPRVCL = _ObjContratista.PNCPRVCL
        objPersonal.PSTPDCPE = Me.cboTipoDocumento.SelectedValue.ToString.Trim
        objPersonal.PSNMDCPE = Me.txtNroDocumento.Text
        Me.ObtieneInformacion(objPersonal)

        objPersonal.PSSESTRG = "A"
        objPersonal.PSCUSCRT = MainModule.USUARIO
        objPersonal.PNFCHCRT = HelpClass.TodayNumeric
        objPersonal.PNHRACRT = HelpClass.NowNumeric
        objPersonal.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        If ObjPersonal_BL.Insertar_Personal_Contratista(objPersonal) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else

            HelpClass.MsgBox("Se Asignó Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub


    Private Sub frmAsignarPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Lista los tipos de Documentos.

        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.cboTipoDocumento.DataSource = ObjPersonal_BL.ListarTipoDocumento(_ObjContratista.PSCCMPN)
            Me.cboTipoDocumento.ValueMember = "CCMPRN"
            Me.cboTipoDocumento.DisplayMember = "TDSDES"
            Me.cboGradoAcademico.DataSource = ObjPersonal_BL.ListarGradoAcademico(_ObjContratista.PSCCMPN)
            Me.cboGradoAcademico.ValueMember = "CCMPRN"
            Me.cboGradoAcademico.DisplayMember = "TDSDES"
            Me.txtClienteMnto.pCargar(_ObjContratista.PNCCLNT)
            Me.txtContratista.ActualizarBusqueda(_ObjContratista.PNCPRVCL)

        Else
            Me.cboTipoDocumento.DataSource = ObjPersonal_BL.ListarTipoDocumento(_ObjPersonal.PSCCMPN)
            Me.cboTipoDocumento.ValueMember = "CCMPRN"
            Me.cboTipoDocumento.DisplayMember = "TDSDES"
            Me.cboGradoAcademico.DataSource = ObjPersonal_BL.ListarGradoAcademico(_ObjPersonal.PSCCMPN)
            Me.cboGradoAcademico.ValueMember = "CCMPRN"
            Me.cboGradoAcademico.DisplayMember = "TDSDES"

            'Muestra los valores de la Entidad
            Me.txtNroDocumento.Enabled = False
            Me.cboTipoDocumento.Enabled = False
            Me.txtClienteMnto.pCargar(_ObjPersonal.PNCCLNT)
            Me.txtContratista.ActualizarBusqueda(_ObjPersonal.PNCPRVCL)

            Me.cboTipoDocumento.SelectedValue = _ObjPersonal.PSTPDCPE
            Me.txtNroDocumento.Text = _ObjPersonal.PSNMDCPE
            Me.txtNombre.Text = _ObjPersonal.PSNMBPER
            Me.txtApellido.Text = _ObjPersonal.PSAPEPER
            Me.dtpFechaNac.Value = HelpClass.CNumero_a_Fecha(_ObjPersonal.PNFNCMTO)
            Me.txtNacionalidad.Text = _ObjPersonal.PSTNCION
            Me.txtDireccion.Text = _ObjPersonal.PSTDRCPE
            Me.cboGradoAcademico.SelectedValue = _ObjPersonal.PSGRDACA
            Me.txtPuesto.Text = _ObjPersonal.PSCCTPPE
            Me.dtpFechaIng.Value = HelpClass.CNumero_a_Fecha(_ObjPersonal.PNFINGEM)

            If _ObjPersonal.PSPDCNAT = "1" Then
                Me.rbComunidadSI.Checked = True
                Me.txtComunidad.Text = _ObjPersonal.PSNMCNAP
            Else
                Me.rbComunidadNo.Checked = True
                Me.txtComunidad.Enabled = False
                Me.txtComunidad.Text = ""
            End If
            Me.txtNroDiaRotacion.Text = _ObjPersonal.PNNDIART
        End If
    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Me.txtClienteMnto.pCodigo = 0 Then
            lstr_validacion += "* CLIENTE " & Chr(13)
        End If

        If Me.txtContratista.pCodigo = 0 Then
            lstr_validacion += "* CONTRATISTA " & Chr(13)
        End If

        If Me.txtNroDocumento.Text = "" OrElse Not IsNumeric(txtNroDocumento.Text) Then
            lstr_validacion += "* NRO DOCUMENTO " & Chr(13)
        End If

        If Me.txtApellido.Text.Trim = "" Then
            lstr_validacion += "* APELLIDOS" & Chr(13)
        End If

        If Me.txtNombre.Text.Trim = "" Then
            lstr_validacion += "* NOMBRES " & Chr(13)
        End If

        If Not IsDate(dtpFechaNac.Value) Then
            lstr_validacion += "* FECHA NACIMIENTO " & Chr(13)
        End If

        If Not IsDate(dtpFechaIng.Value) Then
            lstr_validacion += "* FECHA INGRESO " & Chr(13)
        End If

        If Me.txtNroDiaRotacion.Text = "" OrElse Not IsNumeric(txtNroDiaRotacion.Text) Then
            lstr_validacion += "* DÍAS ROTACIÓN " & Chr(13)
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
            Me.NuevoPersonal()
        Else
            Me.ActualizaPersonal()
        End If
    End Sub

    Private Sub rbComunidadSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbComunidadSI.CheckedChanged
        Me.txtComunidad.Enabled = True
        If Me.TipoOperacion = TIPO.MODIFICAR Then
            Me.txtComunidad.Text = _ObjPersonal.PSNMCNAP
        End If
    End Sub

    Private Sub KryptonRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbComunidadNo.CheckedChanged
        Me.txtComunidad.Enabled = False
        Me.txtComunidad.Text = ""
    End Sub

    Private Sub txtNroDiaRotacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDiaRotacion.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class