Imports Ransa.Utilitario

Public Class frmAdjuntarDocumento

    Private _oServicio_BE As New Servicio_BE

    Public Property oServicio_BE() As Servicio_BE
        Get
            Return _oServicio_BE
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio_BE = value
        End Set
    End Property

    Private _pUsuario As String
    ''' <summary>
    ''' Usuario 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


    Private Sub frmAdjuntarDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaDocumentos()
    End Sub



    Private Sub ListaDocumentos()
        Dim oDocumento_BL As New clsDocumento_BL
        Dim oDocumento_BE As New Documento_BE
        Dim olbeDoc As New List(Of Documento_BE)
        With oDocumento_BE
            .PNCCLNT = _oServicio_BE.CCLNT
            .NOPRCN = _oServicio_BE.NOPRCN
            .PSCTIIMG = "DOC"
        End With
        dtgDocumentos.AutoGenerateColumns = False
        dtgDocumentos.DataSource = oDocumento_BL.fdtListarDocumentoServicio(oDocumento_BE)
        oDocumento_BE.PSCTIIMG = "IMG"
        Me.dtgImagenes.AutoGenerateColumns = False
        Dim oDtDocumentoImg As New DataTable
        oDtDocumentoImg = oDocumento_BL.fdtListarDocumentoServicio(oDocumento_BE)
  
        oDtDocumentoImg.Columns.Add("IMG", Type.GetType("System.Byte[]"))
        For Each odr As DataRow In oDtDocumentoImg.Rows
            odr.Item("IMG") = HelpClass.ImageToByte(HelpClass.LoadImageFromUrl(odr.Item("URLARC").ToString.Trim & "/" & odr.Item("TNMBAR").ToString.Trim))
        Next
        Me.dtgImagenes.DataSource = oDtDocumentoImg
    End Sub

    Private Function GrabarDocumento(ByVal oDocumento_BE As Documento_BE) As Integer
        Dim oDocumento_BL As New clsDocumento_BL
        Dim intResultado As Integer = 0
        intResultado = oDocumento_BL.fintActualizarDocumentoServicio(oDocumento_BE)
        If intResultado = 0 Then
            HelpClass.ErrorMsgBox()
            Return intResultado
        End If
        Return intResultado
    End Function



    Private Sub tsAdjuntarImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdjuntarDocumentos("IMG")
    End Sub

    Private Sub btnAdjuntarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdjuntarDocumentos("DOC")
    End Sub


    Private Sub AdjuntarDocumentos(ByVal strTipoDocumento As String)
        If _oServicio_BE.NOPRCN = 0 Then Exit Sub
        Dim strNombreDocumento As String = oServicio_BE.NOPRCN.ToString 
        Dim strDireccion As String = "SOLMIN_SA/" & Me._oServicio_BE.CCLNT.ToString.Trim & "/SERVICIOS/" & strTipoDocumento

        Dim obrCargarImagen As New clsCargarImagen_BL
        Dim oDocumento_BE As New Documento_BE
        Dim oDocumento_BL As New clsDocumento_BL
        With oDocumento_BE
            .PNCCLNT = _oServicio_BE.CCLNT
            .NOPRCN = strNombreDocumento
            .PSCTIIMG = strTipoDocumento
            .PSCUSCRT = pUsuario
            .PNNCRRDC = oDocumento_BL.fintObtenerCorrelativo(oDocumento_BE)
            If .PNNCRRDC = -1 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
            .PSSESTRG = "A"
        End With
        strNombreDocumento = strNombreDocumento & "_" & oDocumento_BE.PNNCRRDC.ToString
        Dim objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
        objfrmSACE.VerObservacion = True
        If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
            oDocumento_BE.PSTOBSMD = objfrmSACE.PSTOBS
            oDocumento_BE.EXTENCION = obrCargarImagen.GetFileExtencion(strDireccion, strNombreDocumento)
            strNombreDocumento = strNombreDocumento & oDocumento_BE.EXTENCION
            If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then

                With oDocumento_BE
                    .PSTNMBAR = strNombreDocumento
                    .PSURLARC = HelpClass.getURLDocLinksSolAlmacen() & strDireccion
                    .PSCULUSA = _pUsuario
                End With
                If oDocumento_BL.fintInsertarDocumentoServicio(oDocumento_BE) <> 0 Then
                    ListaDocumentos()
                End If
            End If
        End If
    End Sub

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick
        If Me.dtgDocumentos.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 1 Then Exit Sub
        HelpClass.AbrirDocumento(Me.dtgDocumentos.CurrentRow.DataBoundItem.Item("URLARC").ToString.Trim & "/" & Me.dtgDocumentos.CurrentRow.DataBoundItem.Item("TNMBAR"))
    End Sub

    Private Sub dtgImagenes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgImagenes.CellDoubleClick
        If Me.dtgImagenes.CurrentCellAddress.Y = -1 OrElse e.ColumnIndex <> 1 Then Exit Sub
        HelpClass.AbrirDocumento(Me.dtgImagenes.CurrentRow.DataBoundItem.Item("URLARC").ToString.Trim & "/" & Me.dtgImagenes.CurrentRow.DataBoundItem.Item("TNMBAR"))
    End Sub


    Private Sub tsbEliminarIMG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtgImagenes.CurrentCellAddress.Y = -1 Then Exit Sub
        EliminerDocumentos(Me.dtgImagenes.CurrentRow.DataBoundItem)
    End Sub

    Private Sub btnEliminarDOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtgDocumentos.CurrentCellAddress.Y = -1 Then Exit Sub
        EliminerDocumentos(Me.dtgDocumentos.CurrentRow.DataBoundItem)
    End Sub
    Private Sub EliminerDocumentos(ByVal oDrDocumento As DataRowView)
        If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim oDocumento_BL As New clsDocumento_BL
            Dim oDocumento_BE As New Documento_BE

            oDocumento_BE.PSSESTRG = "*"
            oDocumento_BE.PSCULUSA = _pUsuario
            oDocumento_BE.NOPRCN = oDrDocumento.Item("NOPRCN")
            oDocumento_BE.PNNCRRDC = oDrDocumento.Item("NCRRDC")
            oDocumento_BE.PNCCLNT = oDrDocumento.Item("CCLNT")

            If oDocumento_BL.fintActualizarDocumentoServicio(oDocumento_BE) Then
                ListaDocumentos()
            Else
                HelpClass.ErrorMsgBox()
            End If
        End If

    End Sub

    Private Sub dtgImagenes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgImagenes.DataError

    End Sub

    Private Sub btnAdjuntarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumento.Click
        If Me.TabDocumentos.SelectedTab.Name = "TabPagDoc" Then
            AdjuntarDocumentos("DOC")
        Else
            AdjuntarDocumentos("IMG")
        End If

    End Sub

    Private Sub btnEliminarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDocumento.Click
        If Me.TabDocumentos.SelectedTab.Name = "TabPagDoc" Then
            If Me.dtgDocumentos.CurrentCellAddress.Y = -1 Then Exit Sub
            EliminerDocumentos(Me.dtgDocumentos.CurrentRow.DataBoundItem)
        Else
            If Me.dtgImagenes.CurrentCellAddress.Y = -1 Then Exit Sub
            EliminerDocumentos(Me.dtgImagenes.CurrentRow.DataBoundItem)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
