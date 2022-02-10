Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
Imports Ransa.NEGO
Public Class frmAdjuntarDocumento

    Private _oBeDocumento As New BeDocumento
    Public Property oBeDocumento() As BeDocumento
        Get
            Return _oBeDocumento
        End Get
        Set(ByVal value As BeDocumento)
            _oBeDocumento = value
        End Set
    End Property


    Private Sub frmAdjuntarDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaDocumentos()
    End Sub



    Private Sub ListaDocumentos()
        Dim obrDocumento As New brDocumento
        Dim obeDocumento As New BeDocumento
        Dim olbeDoc As New List(Of BeDocumento)
        With obeDocumento
            .PNCCLNT = _oBeDocumento.PNCCLNT
            .PSNDOCUM = _oBeDocumento.PSNDOCUM
            .PSTIPODC = _oBeDocumento.PSTIPODC '"RECEPCION"
            .PSCTIIMG = "DOC"
        End With
        dtgDocumentos.AutoGenerateColumns = False
        dtgDocumentos.DataSource = obrDocumento.DocumentoAlmacenListar(obeDocumento)
        obeDocumento.PSCTIIMG = "IMG"
        Me.dtgImagenes.AutoGenerateColumns = False
        olbeDoc = obrDocumento.DocumentoAlmacenListar(obeDocumento)
        For Each obeDoc As BeDocumento In olbeDoc
            obeDoc.IMG = HelpClass.ImageToByte(HelpClass.LoadImageFromUrl(obeDoc.PSURLARC.ToString.Trim & "/" & obeDoc.PSTNMBAR))
        Next
        Me.dtgImagenes.DataSource = olbeDoc
    End Sub

    Private Function GrabarDocumento(ByVal obeDocumento As BeDocumento) As Integer
        Dim obrDocumento As New brDocumento
        Dim intResultado As Integer = 0
        intResultado = obrDocumento.DocumentoAlmacenInsertar(obeDocumento)
        If intResultado = 0 Then
            HelpClass.ErrorMsgBox()
            Return intResultado
        End If
        Return intResultado
    End Function



    Private Sub tsAdjuntarImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntarImages.Click
        AdjuntarDocumentos("IMG")
    End Sub

    Private Sub btnAdjuntarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarGuia.Click
        AdjuntarDocumentos("DOC")
    End Sub


    Private Sub AdjuntarDocumentos(ByVal strTipoDocumento As String)
        If Me.oBeDocumento.PSNDOCUM.Trim.Equals("") Then Exit Sub
        Dim strTipo As String = _oBeDocumento.PSTIPODC
        Dim strNombreDocumento As String = Me.oBeDocumento.PSNDOCUM
        Dim strDireccion As String = "SOLMIN_SA/" & Me.oBeDocumento.PNCCLNT.ToString.Trim & "/" & strTipo & "/" & strTipoDocumento

        Dim obrCargarImagen As New brCargarImagen
        Dim obeDocumento As New BeDocumento
        Dim obrDocumento As New brDocumento
        With obeDocumento
            .PNCCLNT = _oBeDocumento.PNCCLNT
            .PSNDOCUM = strNombreDocumento
            .PSTIPODC = strTipo
            .PSCTIIMG = strTipoDocumento
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PNNCRRDC = obrDocumento.ObtenerCorrelativo(obeDocumento)
            If .PNNCRRDC = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            .PSSESTRG = "A"
        End With
        strNombreDocumento = strNombreDocumento & "_" & obeDocumento.PNNCRRDC.ToString
        Dim objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
        objfrmSACE.VerObservacion = True
        If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
            obeDocumento.PSTOBSMD = objfrmSACE.PSTOBS
            obeDocumento.EXTENCION = obrCargarImagen.GetFileExtencion(strDireccion, strNombreDocumento)
            strNombreDocumento = strNombreDocumento & obeDocumento.EXTENCION
            If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then

                With obeDocumento
                    .PSTNMBAR = strNombreDocumento
                    .PSURLARC = HelpClass.getURLDocLinksSolAlmacen() & strDireccion
                    .PSCULUSA = objSeguridadBN.pUsuario
                End With
                If obrDocumento.DocumentoAlmacenInsertar(obeDocumento) <> 0 Then
                    ListaDocumentos()
                End If
            End If
        End If
    End Sub

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick
        If Me.dtgDocumentos.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 1 Then Exit Sub
        HelpClass.AbrirDocumento(Me.dtgDocumentos.CurrentRow.DataBoundItem.PSURLARC.ToString.Trim & "/" & Me.dtgDocumentos.CurrentRow.DataBoundItem.PSTNMBAR)
    End Sub

    Private Sub dtgImagenes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgImagenes.CellDoubleClick
        If Me.dtgImagenes.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 1 Then Exit Sub
        HelpClass.AbrirDocumento(Me.dtgImagenes.CurrentRow.DataBoundItem.PSURLARC.ToString.Trim & "/" & Me.dtgImagenes.CurrentRow.DataBoundItem.PSTNMBAR)
    End Sub

   
    Private Sub tsbEliminarIMG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarIMG.Click
        If Me.dtgImagenes.CurrentCellAddress.Y = -1 Then Exit Sub
        EliminerDocumentos(Me.dtgImagenes.CurrentRow.DataBoundItem)
    End Sub

    Private Sub btnEliminarDOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDOC.Click
        If Me.dtgDocumentos.CurrentCellAddress.Y = -1 Then Exit Sub
        EliminerDocumentos(Me.dtgDocumentos.CurrentRow.DataBoundItem)
    End Sub
    Private Sub EliminerDocumentos(ByVal obeDocumento As BeDocumento)
        If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim obrDocumento As New brDocumento
            obeDocumento.PSSESTRG = "*"
            obeDocumento.PSCULUSA = objSeguridadBN.pUsuario
            If obrDocumento.DocumentoAlmacenActualizar(obeDocumento) Then
                ListaDocumentos()
            Else
                HelpClass.ErrorMsgBox()
            End If
        End If

    End Sub
End Class
