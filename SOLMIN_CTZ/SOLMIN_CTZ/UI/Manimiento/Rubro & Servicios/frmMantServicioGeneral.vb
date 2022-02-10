Imports SOLMIN_CTZ.Entidades

Public Class frmMantServicioGeneral


    Private _obeServicios As New Servicio_X_Rubro

    Public Property obeServicios() As Servicio_X_Rubro
        Get
            Return _obeServicios
        End Get
        Set(ByVal value As Servicio_X_Rubro)
            _obeServicios = value
        End Set
    End Property


    Private Sub frmMantRubro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If _obeServicios.NRRUBR <> 0 Then
            Me.txtRubro.Text = _obeServicios.NOMRUB
        End If
    End Sub


    Private Sub Guardar()
        If Not fbolValidar() Then Exit Sub
        Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
        If _obeServicios.NRRUBR = 0 Then
            With _obeServicios
                _obeServicios.NOMRUB = Me.txtRubro.Text
            End With
        Else
            With _obeServicios
                _obeServicios.NOMRUB = Me.txtRubro.Text
            End With
        End If
        If oServicioXDivisionNeg.fintGuardarServicioGeneral(_obeServicios) = -1 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        HelpClass.MsgBox("Se guardó correctamente")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



    Private Function fbolValidar() As Boolean
        Dim strError As String = ""

        If Me.txtRubro.Text.Trim.Equals("") Then
            strError = "* Digite descripción del Servicio general" & Chr(10)
        End If
        If strError.Trim.Length > 0 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Guardar()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
