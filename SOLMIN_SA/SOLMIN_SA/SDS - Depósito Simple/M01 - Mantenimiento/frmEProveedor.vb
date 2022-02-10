
Imports RANSA.TypeDef
Imports RANSA.NEGO

Public Class frmEProveedor

#Region "Atributos"

    Public Property IsNuevo() As Boolean
        Get
            Return _IsNuevo
        End Get
        Set(ByVal value As Boolean)
            _IsNuevo = value
        End Set
    End Property

#End Region

#Region "Variables"

    Private oEntidad As beProveedor
    Private _IsNuevo As Boolean

#End Region

#Region "Metodos y Funciones"

    Private Sub SetDataSource(ByVal obj As beProveedor)
        If Not IsNuevo Then
            With obj
                txtPNCPAIS.Text = .PNCPAIS
                txtPNCPRVCL.Text = .PNCPRVCL
                txtPNNDSDMP.Text = .PNNDSDMP
                txtPNNRUCPR.Text = .PNNRUCPR
                txtPSTDRPRC.Text = .PSTDRPRC
                txtPSTEMAI2.Text = .PSTEMAI2
                txtPSTEMAI3.Text = .PSTEMAI3
                txtPSTLFNO1.Text = .PSTLFNO1
                txtPSTLFNO2.Text = .PSTLFNO2
                txtPSTNACPR.Text = .PSTNACPR
                txtPSTNROFX.Text = .PSTNROFX
                txtPSTPRCL1.Text = .PSTPRCL1
                txtPSTPRSCN.Text = .PSTPRSCN
                txtPSTPRVCL.Text = .PSTPRVCL
            End With
        End If
    End Sub

    Private Sub GetDataSource()
        With oEntidad
            .PNCPAIS = Val(txtPNCPAIS.Text.Trim)
            .PNNDSDMP = IIf(String.IsNullOrEmpty(txtPNNDSDMP.Text.Trim), 0, Val(txtPNNDSDMP.Text.Trim))
            .PNNRUCPR = Val(txtPNNRUCPR.Text.Trim)
            .PSTDRPRC = txtPSTDRPRC.Text.Trim
            .PSTEMAI2 = txtPSTEMAI2.Text.Trim
            .PSTEMAI3 = txtPSTEMAI3.Text.Trim
            .PSTLFNO1 = txtPSTLFNO1.Text.Trim
            .PSTLFNO2 = txtPSTLFNO2.Text.Trim
            .PSTNACPR = txtPSTNACPR.Text.Trim
            .PSTNROFX = txtPSTNROFX.Text.Trim
            .PSTPRCL1 = txtPSTPRCL1.Text.Trim
            .PSTPRSCN = txtPSTPRSCN.Text.Trim
            .PSTPRVCL = txtPSTPRVCL.Text.Trim
        End With
    End Sub

    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtPNCPRVCL.Enabled = False
        txtPNNDSDMP.Enabled = True
        txtPNNRUCPR.Enabled = True
        txtPSTDRPRC.Enabled = True
        txtPSTEMAI2.Enabled = True
        txtPSTEMAI3.Enabled = True
        txtPSTLFNO1.Enabled = True
        txtPSTLFNO2.Enabled = True
        txtPSTNACPR.Enabled = True
        txtPSTNROFX.Enabled = True
        txtPSTPRCL1.Enabled = True
        txtPSTPRSCN.Enabled = True
    End Sub

    Private Function ValidarIngreso() As String
        Dim str As String = ""
        If (txtPSTPRVCL.Text.Trim = "") Then
            str = " Debe ingresar la descripción del Proveedor" & Chr(13)
        End If
        Return str
    End Function

#End Region

#Region "Eventos"

    Private Sub frmEProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oEntidad = TryCast(Me.Tag, beProveedor)
        SetDataSource(oEntidad)
        If IsNuevo Then
            SetEnabled(True)
        Else
            SetEnabled(False)
        End If
    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            Dim obrEntidad As New Ransa.NEGO.brProveedor
            Dim strValidar As String = ""
            Dim retorno As Boolean = False
            Dim strText As String
            strText = "No se pudo realizar la operación."
            strValidar = ValidarIngreso()
            If (strValidar.Trim <> "") Then
                MessageBox.Show(strValidar, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            GetDataSource()
            If IsNuevo Then
                oEntidad.PSCUSCRT = objSeguridadBN.pUsuario
                oEntidad.PNFCHCRT = Now.Date.ToString("yyyyMMdd")
                oEntidad.PNHRACRT = Now.Date.ToString("hhmmss")
                oEntidad.PNUPDATE_IDENT = 1
                retorno = obrEntidad.Insertar(oEntidad)
                If (retorno = True) Then
                    strText = "El registro se insertó satisfactorimente."
                    MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                oEntidad.PSCULUSA = objSeguridadBN.pUsuario
                oEntidad.PNFULTAC = Now.Date.ToString("yyyyMMdd")
                oEntidad.PNHULTAC = Now.Date.ToString("hhmmss")
                oEntidad.PNUPDATE_IDENT += 1
                retorno = obrEntidad.Update(oEntidad)
                If (retorno = True) Then
                    strText = "El registro se actualizó satisfactorimente"
                    MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtPNNDSDMP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNNDSDMP.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPNCPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNCPAIS.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPNNRUCPR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNNRUCPR.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class
