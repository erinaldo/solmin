Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.MANTENIMIENTO

Public Class frmNuevoViajeCliente
    Enum TIPO
        MODIFICAR
        ASIGNAR
    End Enum

    Private _TipoOperacion As TIPO
    Public Property TipoOperacion() As TIPO
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As TIPO)
            _TipoOperacion = value
        End Set

    End Property


    Dim _objEntidad As New Viajes_Cliente
    Public Property objEntidad() As Viajes_Cliente
        Get
            Return _objEntidad
        End Get
        Set(ByVal value As Viajes_Cliente)
            _objEntidad = value
        End Set
    End Property

    Private Sub frmNuevoViajeCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtClienteMnto.pAccesoPorUsuario = True
        Me.txtClienteMnto.pRequerido = True
        Me.txtClienteMnto.pUsuario = USUARIO
        Me.txtClienteMnto.CCMPN = objEntidad.PSCCMPN
        Dim ObjPersonal_BL As New Viajes_Cliente_BL
        Me.cboMedioTransporte.DataSource = ObjPersonal_BL.Listar_MedioTransporte("SELECCIONE", objEntidad.PSCCMPN)
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"
        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.Limpiar_Controles_Viajes()
        Else
            Me.ObtieneValores()
        End If
    End Sub

    Private Sub ObtieneValores()
        Me.txtClienteMnto.pCargar(objEntidad.PNCCLNT)
        Me.cboMedioTransporte.SelectedValue = objEntidad.PNCMEDTR
        Me.dtpFecha.Value = HelpClass.CNumero_a_Fecha(objEntidad.PNFCHPSA_1)
        Me.txtHoraRegistro.Text = HelpClass.CNumero_a_Hora_string(objEntidad.PNHRAPSA_1)
    End Sub

    Private Function Validar() As Integer
        Dim msgError As String = ""
        If Me.txtClienteMnto.pCodigo = 0 Then
            msgError += "* CLIENTE" & Chr(13)
        End If

        If Me.cboMedioTransporte.SelectedValue = 0 Then
            msgError += "* MEDIO TRANSPORTE" & Chr(13)
        End If

        If Not IsDate(Me.txtHoraRegistro.Text) OrElse Me.txtHoraRegistro.Text = "00:00:00" Then
            msgError += "* HORA " & Chr(13)
        End If

        If Not msgError.Equals("") Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & msgError)
            Return True
        End If
        Return False
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar() = True Then Exit Sub
        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.Nuevo_Registro_Contratista()
        Else
            Me.Modificar_Registro_Contratista()
        End If

    End Sub

    Private Sub Modificar_Registro_Contratista()
        Try
            Dim objEntidad As New Viajes_Cliente
            Dim objViajes_ClienteBL As New Viajes_Cliente_BL
            objEntidad.PNNPRGVJ = _objEntidad.PNNPRGVJ
            objEntidad.PNFCHPSA_1 = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFecha.Value)
            objEntidad.PNHRAPSA_1 = HelpClass.ConvertHoraNumeric(txtHoraRegistro.Text)
            objEntidad.PSCCMPN = _objEntidad.PSCCMPN
            objEntidad.PNCMEDTR = Me.cboMedioTransporte.SelectedValue
            objEntidad.PNCCLNT = Me.txtClienteMnto.pCodigo
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            Select Case objViajes_ClienteBL.Actualizar_Viaje_Cliente(objEntidad)
                Case 0
                    HelpClass.MsgBox("No se Actualizó por que existen pasajeros asignados")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Case 1
                    HelpClass.MsgBox("Se Modificó Satisfactoriamente")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Case Else
                    HelpClass.ErrorMsgBox()
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End Select


        Catch ex As Exception
        End Try
    End Sub

    Private Sub Nuevo_Registro_Contratista()
        Dim objEntidad As New Viajes_Cliente
        Dim objViajes_ClienteBL As New Viajes_Cliente_BL
        'Asumiendo que la Programacion del Viaje es Autogenerada.
        objEntidad.PNFCHPSA_1 = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFecha.Value)
        objEntidad.PNHRAPSA_1 = HelpClass.ConvertHoraNumeric(txtHoraRegistro.Text)
        objEntidad.PSCCMPN = _objEntidad.PSCCMPN
        objEntidad.PNCMEDTR = Me.cboMedioTransporte.SelectedValue
        objEntidad.PNCCLNT = Me.txtClienteMnto.pCodigo
        objEntidad.PSSESTRG = "A"
        objEntidad.PSCUSCRT = MainModule.USUARIO
        objEntidad.PNFCHCRT = HelpClass.TodayNumeric
        objEntidad.PNHRACRT = HelpClass.NowNumeric
        objEntidad.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        If objViajes_ClienteBL.Insertar_Viaje_Cliente(objEntidad) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Registró Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Limpiar_Controles_Viajes()
        Me.txtClienteMnto.pClear()
        Me.cboMedioTransporte.SelectedValue = 0
        Me.dtpFecha.Value = Date.Now
        Me.txtHoraRegistro.Text = Date.Now.TimeOfDay.ToString
    End Sub
End Class
