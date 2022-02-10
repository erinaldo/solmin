Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.MANTENIMIENTO


Public Class frmNuevoContratistaCliente
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

    Private _objContratistaBE As New Contratista_Cliente
    Public Property objContratistaBE() As Contratista_Cliente
        Get
            Return _objContratistaBE
        End Get
        Set(ByVal value As Contratista_Cliente)
            _objContratistaBE = value
        End Set
    End Property


    Private Sub Limpiar_Controles_Contratista()
        Me.txtContratista.pClear()
        txtNroRotacion.Text = ""
        Me.txtClienteMnto.pClear()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Function ValidarContratista() As Boolean
        Dim msgError As String = ""
        If Me.txtContratista.pCodigo = 0 Then
            msgError += "* Contratista" & Chr(13)
        End If

        If Me.txtClienteMnto.pCodigo = 0 Then
            msgError += "* Cliente" & Chr(13)
        End If

        If Me.txtNroRotacion.Text.Trim = "" Then
            msgError += "* Nro Guía Rotación " & Chr(13)
        End If

        If Not msgError.Equals("") Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & msgError)
            Return True
        End If
        Return False
    End Function

    Private Sub Nuevo_Registro_Contratista()
        If Not IsNumeric(Me.txtNroRotacion.Text) Then Exit Sub

        Dim objEntidad As New Contratista_Cliente
        Dim objContratistaBL As New Contratista_Cliente_BL
        objEntidad.PNCCLNT = Me.txtClienteMnto.pCodigo
        objEntidad.PNCPRVCL = Me.txtContratista.pCodigo

        objEntidad.PSCCMPN = objContratistaBE.PSCCMPN
        objEntidad.PNNDIART = Me.txtNroRotacion.Text

        objEntidad.PSSESTRG = "A"
        objEntidad.PSCUSCRT = MainModule.USUARIO
        objEntidad.PNFCHCRT = HelpClass.TodayNumeric
        objEntidad.PNHRACRT = HelpClass.NowNumeric
        objEntidad.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        If objContratistaBL.Insertar_Contratista_Cliente(objEntidad) = "0" Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Registró Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


    End Sub

    Private Sub Modificar_Registro_Contratista()
        Dim objEntidad As New Contratista_Cliente
        Dim objContratistaBL As New Contratista_Cliente_BL

        Try
            objEntidad.PNCCLNT = Me.txtClienteMnto.pCodigo
            objEntidad.PNCPRVCL = Me.txtContratista.pCodigo
            objEntidad.PSCCMPN = objContratistaBE.PSCCMPN
            objEntidad.PNNDIART = Me.txtNroRotacion.Text
            objEntidad.PSCULUSA = MainModule.USUARIO
            objEntidad.PNFULTAC = HelpClass.TodayNumeric
            objEntidad.PNHULTAC = HelpClass.NowNumeric
            objEntidad.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            If objContratistaBL.Actualizar_Contratista_Cliente(objEntidad) = "0" Then
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                HelpClass.MsgBox("Se Modificó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarContratista() = True Then Exit Sub
        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.Nuevo_Registro_Contratista()
        Else
            Me.Modificar_Registro_Contratista()
        End If
    End Sub

    Private Sub ObtieneValores()
        Me.txtContratista.ActualizarBusqueda(objContratistaBE.PNCPRVCL)
        Me.txtClienteMnto.pCargar(objContratistaBE.PNCCLNT)
        txtNroRotacion.Text = objContratistaBE.PNNDIART
    End Sub

    Private Sub frmNuevoContratistaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtClienteMnto.pAccesoPorUsuario = True
        Me.txtClienteMnto.pRequerido = True
        Me.txtClienteMnto.pUsuario = USUARIO
        Me.txtClienteMnto.CCMPN = objContratistaBE.PSCCMPN


        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.Limpiar_Controles_Contratista()
        Else
            Me.ObtieneValores()
        End If


    End Sub
End Class
