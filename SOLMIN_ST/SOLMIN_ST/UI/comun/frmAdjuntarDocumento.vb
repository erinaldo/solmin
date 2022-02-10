Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Public Class frmAdjuntarDocumento

  Private _docsAdjunto As New DocsAdjuntos_SolTransporte
  Private oDtImagen As New DataTable

  Public Property docsAdjunto() As DocsAdjuntos_SolTransporte
    Get
      Return _docsAdjunto
    End Get
    Set(ByVal value As DocsAdjuntos_SolTransporte)
      _docsAdjunto = value
    End Set
  End Property

  Private Sub frmAdjuntarDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    ListaDocumentos()
  End Sub

  Private Sub ListaDocumentos()
    Dim obrDocumento As New SOLMIN_ST.NEGOCIO.mantenimientos.DocsAdjuntos_SolTransporte_BLL
    Dim obeDocumento As New SOLMIN_ST.ENTIDADES.mantenimientos.DocsAdjuntos_SolTransporte
    Dim olbeDoc As New DataTable 'New List(Of BeDocumento)
    With obeDocumento
      .CTRSPT = docsAdjunto.CTRSPT
      .NGUITR = docsAdjunto.NGUITR
      .TIIMG = "DOC"
    End With
    dtgDocumentos.AutoGenerateColumns = False
    dtgDocumentos.DataSource = obrDocumento.DocumentoTransporteListar(obeDocumento)
    obeDocumento.TIIMG = "IMG"
    Me.dtgImagenes.AutoGenerateColumns = False
    olbeDoc = obrDocumento.DocumentoTransporteListar(obeDocumento)
    oDtImagen = olbeDoc.Copy
    Me.dtgImagenes.DataSource = olbeDoc
  End Sub

  Private Sub dtgImagenes_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgImagenes.DataBindingComplete
    'If boolEstado = True Then
    For i As Integer = 0 To oDtImagen.Rows.Count - 1 'Each obeDoc As BeDocumento In olbeDoc
      dtgImagenes.Rows(i).Cells("Column4").Value = Ransa.Utilitario.HelpClass.ImageToByte(Ransa.Utilitario.HelpClass.LoadImageFromUrl(oDtImagen.Rows(i).Item("URLARC").ToString.Trim & "/" & oDtImagen.Rows(i).Item("TNMBAR")))
    Next
    'boolEstado = False
    'End If
  End Sub

  Private Function GrabarDocumento(ByVal obeDocumento As DocsAdjuntos_SolTransporte) As Integer
    Dim obrDocumento As New SOLMIN_ST.NEGOCIO.mantenimientos.DocsAdjuntos_SolTransporte_BLL
    Dim intResultado As Integer = 0
    intResultado = obrDocumento.DocumentoTransporteInsertar(obeDocumento)
    If intResultado = 0 Then
      HelpClass.ErrorMsgBox()
      Return intResultado
    End If
    Return intResultado
  End Function

  Private Sub tsAdjuntarImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntarImages.Click
    AdjuntarDocumentos("IMG")
    dtgImagenes_DataBindingComplete(Nothing, Nothing)
  End Sub

  Private Sub btnAdjuntarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarGuia.Click
    AdjuntarDocumentos("DOC")
  End Sub

  Private Sub AdjuntarDocumentos(ByVal strTipoDocumento As String)
    If Me.docsAdjunto.CTRSPT.Equals(0) Then Exit Sub
    If Me.docsAdjunto.NGUITR.Trim.Equals("") Then Exit Sub
    Dim strTipo As String = Me.docsAdjunto.NGUITR.ToString.Trim 'SubCarpeta
    Dim strNombreDocumento As String = Me.docsAdjunto.CTRSPT 'Carpeta
    Dim strDireccion As String = "SOLMIN_ST/" & Me.docsAdjunto.CTRSPT.ToString.Trim & "/" & strTipo & "/" & strTipoDocumento

    Dim obrCargarImagen As New SOLMIN_ST.NEGOCIO.mantenimientos.clsImageWebUpload
    Dim obeDocumento As New SOLMIN_ST.ENTIDADES.mantenimientos.DocsAdjuntos_SolTransporte
    With obeDocumento
      .CTRSPT = strNombreDocumento
      .NGUITR = strTipo
      .TIIMG = strTipoDocumento
      .CUSCRT = USUARIO
      .SESTRG = "A"
    End With
    If strTipoDocumento = "IMG" Then
      obeDocumento.NCRRDC = dtgImagenes.Rows.Count
    Else
      obeDocumento.NCRRDC = dtgDocumentos.Rows.Count
    End If

    strNombreDocumento = strNombreDocumento & "_" & strTipo & "_" & obeDocumento.NCRRDC.ToString
    Dim objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
    Dim extension As String = ""
    objfrmSACE.VerObservacion = True
    If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
      obeDocumento.TOBS = objfrmSACE.PSTOBS
      extension = obrCargarImagen.GetFileExtension(strDireccion, strNombreDocumento)
      strNombreDocumento = strNombreDocumento & extension
      If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then
        Dim obrDocumento As New SOLMIN_ST.NEGOCIO.mantenimientos.DocsAdjuntos_SolTransporte_BLL
        With obeDocumento
          .URLARC = strNombreDocumento
          .CLINK = "https://secure.ransa.net/imagenessolmin/imagenes/solmin/" & strDireccion
          .CULUSA = USUARIO
        End With
        If obrDocumento.DocumentoTransporteInsertar(obeDocumento) <> 0 Then
          ListaDocumentos()
        End If
      End If
    End If
  End Sub

  Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick
    If Me.dtgDocumentos.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 3 Then Exit Sub
    HelpClass.AbrirDocumento(Me.dtgDocumentos.CurrentRow.Cells("URLARC").Value.ToString.Trim & "/" & Me.dtgDocumentos.CurrentRow.Cells("TNMBAR").Value.ToString.Trim)
  End Sub

  Private Sub dtgImagenes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgImagenes.CellDoubleClick
    If Me.dtgImagenes.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 1 Then Exit Sub
    HelpClass.AbrirDocumento(Me.dtgImagenes.CurrentRow.Cells("URLARC_I").Value.ToString.Trim & "/" & Me.dtgImagenes.CurrentRow.Cells("TNMBAR_I").Value.ToString.Trim)
  End Sub

  Private Sub btnAnularImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularImg.Click
    If Me.dtgImagenes.Rows.Count = 0 OrElse Me.dtgImagenes.CurrentCellAddress.Y < 0 Then Exit Sub
    Dim obrDocumento As New SOLMIN_ST.NEGOCIO.mantenimientos.DocsAdjuntos_SolTransporte_BLL
    Dim obeDocumento As New SOLMIN_ST.ENTIDADES.mantenimientos.DocsAdjuntos_SolTransporte
    With obeDocumento
      .CTRSPT = docsAdjunto.CTRSPT
      .NGUITR = docsAdjunto.NGUITR
      .NCRRDC = docsAdjunto.NCRRDC
      .TIIMG = "IMG"
      .URLARC = dtgImagenes.CurrentRow.Cells("URLARC_I").Value.ToString.Trim
      .CLINK = dtgImagenes.CurrentRow.Cells("TNMBAR_I").Value.ToString.Trim
    End With
    obrDocumento.Eliminar_Documento_Adjunto(obeDocumento)
    ListaDocumentos()
  End Sub

  Private Sub btnAnularDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularDoc.Click
    If dtgDocumentos.Rows.Count = 0 OrElse Me.dtgDocumentos.CurrentCellAddress.Y < 0 Then Exit Sub
    Dim obrDocumento As New SOLMIN_ST.NEGOCIO.mantenimientos.DocsAdjuntos_SolTransporte_BLL
    Dim obeDocumento As New SOLMIN_ST.ENTIDADES.mantenimientos.DocsAdjuntos_SolTransporte
    With obeDocumento
      .CTRSPT = docsAdjunto.CTRSPT 'dtgDocumentos.CurrentRow.Cells("CTRSPT") '
      .NGUITR = docsAdjunto.NGUITR 'dtgDocumentos.CurrentRow.Cells("NGUITR") '
      .TIIMG = "DOC"
      .URLARC = dtgDocumentos.CurrentRow.Cells("URLARC").Value.ToString.Trim
      .CLINK = dtgDocumentos.CurrentRow.Cells("TNMBAR").Value.ToString.Trim
    End With
    obrDocumento.Eliminar_Documento_Adjunto(obeDocumento)
    ListaDocumentos()
  End Sub

End Class
