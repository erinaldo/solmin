Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.Negocio
Imports Ransa.Utilitario

Public Class frmOpcionCalendario
    Public oInfoEntidad As New beCalendario
    Public myDialogResultOk As Boolean = False
    Private Sub frmOpcionCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ci As Globalization.CultureInfo
        Dim Fecha As String = ""
        Dim str_Lab_NoLab As String = ""
        Dim myDate As Date
        ci = New Globalization.CultureInfo("es-ES")
        myDate = Convert.ToDateTime(HelpClass.CNumero8Digitos_a_FechaDefault(oInfoEntidad.PNFFRDO))
        Fecha = StrConv(myDate.ToString("dddd", ci), VbStrConv.ProperCase) & " , "
        Fecha = Fecha & oInfoEntidad.PNANIO & " - " & StrConv(myDate.ToString("MMMM", ci), VbStrConv.ProperCase)
        Fecha = Fecha & " - " & Ransa.Utilitario.HelpClass.StringRight(oInfoEntidad.PNFFRDO.ToString, 2)
        lblFecha.Text = Fecha
        chkl.Checked = False
        chknl.Checked = False
        If (oInfoEntidad.PSFERIADO = "F") Then
            lblFecha.ForeColor = Color.Red
            lbl_l_nl.ForeColor = Color.Red
            str_Lab_NoLab = "(NO LABORABLE)"
            chknl.Checked = True
        End If
        If (oInfoEntidad.PSFERIADO <> "F") Then
            lblFecha.ForeColor = Color.Blue
            lbl_l_nl.ForeColor = Color.Blue
            chkl.Checked = True
            str_Lab_NoLab = "(LABORABLE)"
        End If
        lbl_l_nl.Text = str_Lab_NoLab
        txtDescripcion.Text = oInfoEntidad.PSTFRDO
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim obrCalendario As New clsCalendario
        Dim retorno As Int32 = 0
        oInfoEntidad.PSFERIADO = "NF"
        If (chknl.Checked = True) Then
            oInfoEntidad.PSFERIADO = "F"
        End If
        oInfoEntidad.PSTFRDO = txtDescripcion.Text.Trim
        retorno = obrCalendario.ActualizarCalendario(oInfoEntidad)
        If (retorno = 1) Then
            MessageBox.Show("La operaci�n se realiz� satisfactoriamente.", "Calendario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myDialogResultOk = True
            Me.Close()
        Else
            'Antes: No se actualiz� el dia
            MessageBox.Show("Error de conexi�n.", "Calendario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class