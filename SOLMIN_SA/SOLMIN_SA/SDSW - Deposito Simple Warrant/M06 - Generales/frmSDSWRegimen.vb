Public Class frmSDSWRegimen
    Private blnStatusValidacion As Boolean = False
    Private Function fblnValidar() As Boolean

        Dim strResultado As String = ""
        blnStatusValidacion = True

        If lblregimen.Text = "A" Then
            If txtaduana.Text = "" Then strResultado &= "Debe proporcionar el N° de Aduana. " & vbNewLine
            If txtdua.Text = "" Then strResultado &= "Debe proporcionar el N° de Dua. " & vbNewLine
            If txtanioaduana.Text = "" Then strResultado &= "Debe proporcionar el Año de Aduana." & vbNewLine
        ElseIf lblregimen.Text = "S" Then
            txtaduana.Text = 0
            txtdua.Text = 0
            txtanioaduana.Text = 0
        End If
        If rbAduanero.Checked = False And rbSimple.Checked = False Then strResultado &= "Seleccione un Tipo de Regimen." & vbNewLine

        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnStatusValidacion = False
        End If
        Return blnStatusValidacion
    End Function
    Public Sub Habilitar()
        Me.txtaduana.Enabled = True
        Me.txtanioaduana.Enabled = True
        Me.txtdua.Enabled = True
        lblregimen.Text = "A"
    End Sub
    Public Sub desHabilitar()
        Me.txtaduana.Enabled = False
        Me.txtanioaduana.Enabled = False
        Me.txtdua.Enabled = False
    End Sub
    Private Sub bsaAduana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAduana.Click
        Call mfblnBuscar_TipoAduanaSDSW(txtaduana.Tag, txtaduana.Text)
    End Sub
    Private Sub rbAduanero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAduanero.CheckedChanged
        If rbAduanero.Checked = True Then
            Habilitar()
        Else
            desHabilitar()
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If fblnValidar() Then Me.Close()
    End Sub
    Private Sub rbSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSimple.CheckedChanged
        lblregimen.Text = "S"
    End Sub

    Private Sub frmRegimen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnStatusValidacion Then e.Cancel = True

    End Sub
    Private Sub frmRegimen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        desHabilitar()
    End Sub

End Class
