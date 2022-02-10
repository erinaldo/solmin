Imports SOLMIN_CTZ.NEGOCIO

Public Class frmAdjuntarDocumentos
    Private _pNMRGIM As String = ""
    Private _pTABLE_NAME As String = ""
    Private _pCCMPN As String = ""
    Private _PIMAGE_LIST As New List(Of String)
    Private _ModeEdition As Boolean = True
    Private _PNCCLNT As String = ""
    Private _PNNOPRCN As String = ""
    Private _PSUSUARIO As String

    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property

    Public Property PNCCLNT() As String
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As String)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNNOPRCN() As String
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As String)
            _PNNOPRCN = value
        End Set
    End Property

    Public Property pNMRGIM() As String
        Get
            Return _pNMRGIM
        End Get
        Set(ByVal value As String)
            _pNMRGIM = value
        End Set
    End Property

    Private _NRCTSL As Decimal
    Public Property pNRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            _NRCTSL = value
        End Set
    End Property


    Public Property pTABLE_NAME() As String
        Get
            Return _pTABLE_NAME
        End Get
        Set(ByVal value As String)
            _pTABLE_NAME = value
        End Set
    End Property



    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Public Property PIMAGE_LIST() As List(Of String)
        Get
            Return _PIMAGE_LIST
        End Get
        Set(ByVal value As List(Of String))
            _PIMAGE_LIST = value
        End Set
    End Property

    Public Property ModeEdition() As Boolean
        Get
            Return _ModeEdition
        End Get
        Set(ByVal value As Boolean)
            _ModeEdition = value
        End Set
    End Property

    Private Sub frmDocAdujuntoPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filestorage1 As New StorageFileManager.FileStorage
        filestorage1.NMRGIM = Me._pNMRGIM
        filestorage1.ImageListNumbers = _PIMAGE_LIST
        filestorage1.CCLNT = _PNCCLNT
        filestorage1.TableName = _pTABLE_NAME
        filestorage1.CCMPN = _pCCMPN
        filestorage1.SystemName = "SD"
        filestorage1.UserName = _PSUSUARIO
        filestorage1.ModeEdition = ModeEdition
        filestorage1.InitComponentProperties()
        filestorage1.Dock = DockStyle.Fill
        KryptonPanel.Controls.Add(filestorage1)
        AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.onSaveCampoNegocioUpload
        AddHandler filestorage1.EliminaImagen, AddressOf Me.onEliminaImagen
    End Sub

    Private Sub onEliminaImagen(ByVal sender As String)
        Me._pNMRGIM = sender
        Dim obj As New UploadImagen
        Dim objhash As New Hashtable
        If Me._NRCTSL <> 0 Then
            objhash = New Hashtable
            objhash.Add("PARAM_NMRGIM", Me._pNMRGIM)
            If obj.EliminaRelacion(objhash) Then
                Me._pNMRGIM = 0
                CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage).NMRGIM = 0
                MessageBox.Show("Se eliminó con éxito")
            Else
                MessageBox.Show("Ocurrió un Error al Eliminar")
            End If
        End If
    End Sub

    Private Sub onSaveCampoNegocioUpload(ByVal sender As Object)
        Dim objSave As New UploadImagen
        Dim objhash As New Hashtable
        objhash.Add("PARAM_NMRGIM", CType(sender, String))
        objhash.Add("PARAM_NRCTSL", Me._NRCTSL)
        objhash.Add("PARAM_CCLNT", Me._PNCCLNT)
        objhash.Add("PARAM_USUARIO", Me._PSUSUARIO)
        If Not objSave.GuardarEnTabla(objhash) Then
            '    MessageBox.Show("Se guardó con exito")
            'Else
            MessageBox.Show("Ocurrió un error al Guardar")
        End If
    End Sub

End Class