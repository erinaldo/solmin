Public Class frmSubirArchivo
    Private strNombreImg
    Private objCargarImagen As New Negocio.clsImageWebUpload

    Public Sub New(ByVal strCadena As String, Optional ByVal strCarpeta As String = "")
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        strNombreImg = strCadena
        Dim lstr_ruta As String = ""
        If (strCarpeta = "") Then
            'lstr_ruta = "http://asp.ransa.com.pe/wapmineria/mantenimiento/upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC"
            lstr_ruta = HelpUtil.getSetting("URL_ADJ_RAIZ") & "upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC"
        Else
            'lstr_ruta = "http://asp.ransa.com.pe/wapmineria/mantenimiento/upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC\" & strCarpeta
            lstr_ruta = HelpUtil.getSetting("URL_ADJ_RAIZ") & "upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC\" & strCarpeta

        End If
        Me.UploadBrowser.Navigate(lstr_ruta)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
