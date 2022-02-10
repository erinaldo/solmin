Imports SOLMIN_ST.NEGOCIO

Public Class frmUploadImagen

    Private _Carpeta As String = ""
    Private _Archivo As String = ""

    Public Sub ShowForm(ByVal TipoGuardado As String, ByVal NombreArchivo As String, ByVal owner As IWin32Window)

        Me._Carpeta = TipoGuardado
        Me._Archivo = NombreArchivo
    Me.WebBrowser1.Navigate(My.Settings.ST_URL + "upload_solmin_st.aspx?tipo_archivo=" & TipoGuardado & "&nombre_archivo=" & NombreArchivo)
        Me.ShowDialog(owner)

    End Sub
  
End Class
