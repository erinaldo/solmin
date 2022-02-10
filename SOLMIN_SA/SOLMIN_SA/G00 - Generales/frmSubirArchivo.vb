Public Class frmSubirArchivo
    Private strNombreImg


    Private _PSTOBS As String
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property


    <System.ComponentModel.Browsable(False)> _
    Public WriteOnly Property VerObservacion() As Boolean
        Set(ByVal value As Boolean)
            txtObservaciones.Visible = value
            lblObservaciones.Visible = value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strCadena">Direccion del documento</param>
    ''' <param name="strNobre">Nombre del documento</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal strCadena As String, ByVal strNobre As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' strNombreImg = strCadena
        Dim lstr_ruta As String = "https://secure.ransa.net/imagenessolmin/upload_solmin_st.aspx?nombre_archivo=" & strNobre & "&tipo_archivo=" & strCadena
        Me.UploadBrowser.Navigate(lstr_ruta)
    End Sub

    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        _PSTOBS = txtObservaciones.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
