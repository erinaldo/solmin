Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Imports Ransa.Utilitario

Public Class frmMIncidencias


    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String = ""
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCINCID As String = ""
    Public Property PNCINCID() As String
        Get
            Return _PNCINCID
        End Get
        Set(ByVal value As String)
            _PNCINCID = value
        End Set
    End Property


    Private _PSTINCSI As String
    Public Property PSTINCSI() As String
        Get
            Return _PSTINCSI
        End Get
        Set(ByVal value As String)
            _PSTINCSI = value
        End Set
    End Property

    Private _PSTCMPDV As String
    Public Property PSTCMPDV() As String
        Get
            Return _PSTCMPDV
        End Get
        Set(ByVal value As String)
            _PSTCMPDV = value
        End Set
    End Property



    Private Sub frmMIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtCodigo.Text = _PNCINCID
        Me.txtDesIncidencia.Text = _PSTINCSI
        If _PSCDVSN.Length > 0 Then
            'Me.UcDivision_Cmb011.Division = _PSCDVSN
            'Me.UcDivision_Cmb011.DivisionDescripcion = _PSTCMPDV
            'Me.UcDivision_Cmb011.Refresh()
            Me.UcDivision_Cmb011.Visible = False
            Me.txtDivision.Text = _PSTCMPDV
            Me.txtDivision.Visible = True
            Me.txtDivision.Enabled = False
        Else
            Cargar_Division()
        End If
    End Sub

    Sub Cargar_Division()
        UcDivision_Cmb011.Compania = _PSCCMPN
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub


    Private Function Validar() As Boolean
        Dim strError As String = ""
        If Me.txtDesIncidencia.Text.Trim.Length = 0 Then
            strError = "Debe de Ingresar la descripción"
        End If
        If strError.Length > 0 Then
            MessageBox.Show(strError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If Validar() Then Exit Sub
        Dim obr As New brIncidencias
        Dim obe As New beIncidencias

        With obe
            .PSCCMPN = _PSCCMPN
            If _PSCDVSN.Length <> 0 Then
                .PSCDVSN = _PSCDVSN
            Else
                .PSCDVSN = Me.UcDivision_Cmb011.Division '_PSCDVSN
            End If

            If _PNCINCID.Length <> 0 Then
                .PNCINCID = _PNCINCID
            End If
            .PSTINCSI = Me.txtDesIncidencia.Text
            .PSNTRMNL = objSeguridadBN.pstrPCName
            .PSUSUARIO = objSeguridadBN.pUsuario
            .PSSESTRG = "A"
        End With

        If _PNCINCID.Length = 0 Then
            If obr.intInsertarMaestroIncidencias(obe) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.ErrorMsgBox()
            End If
        Else
            If obr.intActualizarMaestroIncidencias(obe) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.ErrorMsgBox()
            End If
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
