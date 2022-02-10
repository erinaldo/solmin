Public Class frmSubirArchivoCostoEmbarque
    Private strNombreImg
    Private objCargarImagen As New Negocio.clsImageWebUpload

    Public Sub New(ByVal strCadena As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        strNombreImg = strCadena
        'Dim lstr_ruta As String = "http://asp.ransa.com.pe/wapmineria/mantenimiento/upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC\COSTOS_EMBARQUE"
        Dim lstr_ruta As String = HelpUtil.getSetting("URL_ADJ_RAIZ") & "upload_solmin_st.aspx?nombre_archivo=" & strNombreImg & "&tipo_archivo=" & "SOLMIN_SC\COSTOS_EMBARQUE"
        'HelpUtil.getSetting("URL_ADJ_RAIZ")
        Me.UploadBrowser.Navigate(lstr_ruta)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
