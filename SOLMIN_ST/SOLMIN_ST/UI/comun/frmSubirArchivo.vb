Imports SOLMIN_ST.NEGOCIO
Imports System.IO

Public Class frmSubirArchivo
    Private strTipoGuardado As String = ""
    Private strNombreImg As String = ""
    Private objCargarImagen As New mantenimientos.clsImageWebUpload
    Private ws As SolminWeb
    Private obj As Archivo

    Public Sub New(ByVal tipoGuardado As String, ByVal lpFileName As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        strTipoGuardado = tipoGuardado
        strNombreImg = lpFileName
        'Dim lstr_ruta As String = My.Settings.ST_URL + "upload_solmin_st.aspx?tipo_archivo=" & tipoGuardado & "&nombre_archivo=" & lpFileName
        'Me.UploadBrowser.Navigate(lstr_ruta)
    End Sub

    Private Sub frmSubirArchivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        _PSTOBS = txtObservaciones.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.ShowDialog(Me)

            'Obteniendo los datos del archivo seleccionado
            If ofd.FileName IsNot Nothing Then
                If ofd.FileName <> "" Then

                    Dim ofilename As String = ofd.FileName
                    Dim oFileInfo As New IO.FileInfo(ofilename)

                    If oFileInfo.Name.Length > 50 Then
                        MsgBox("El nombre del archivo a guardar excede al máximo permitido (50 caracteres)")
                        Exit Sub
                    End If

                    obj = New Archivo
                    Dim fs As New FileStream(ofilename, FileMode.Open, FileAccess.Read)
                    Dim ofileData(fs.Length) As Byte
                    fs.Read(ofileData, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()
                    fs.Dispose()
                    obj.FileData = ofileData
                    obj.FileName = oFileInfo.Name
                    txtArchivo.Text = ofilename
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCargarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarArchivo.Click
        'MsgBox(ws.SaveFile(obj, "prueba", nombrealias() & oFileInfo.Extension))
        ws = New SolminWeb
        If ws.SaveFile(obj, strTipoGuardado, strNombreImg) = True Then
            lblMensaje.Text = "Guardado en Base de Datos."
            lblMensaje.ForeColor = Color.Blue
            txtObservaciones.Text = obj.FileName
        Else
            lblMensaje.Text = "No se puede guardar el Archivo."
            lblMensaje.ForeColor = Color.Red
        End If
        lblMensaje.Visible = True
    End Sub
End Class
