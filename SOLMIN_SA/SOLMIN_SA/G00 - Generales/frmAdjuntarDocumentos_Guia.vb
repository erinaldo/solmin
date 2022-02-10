Imports Ransa.NEGO
Public Class frmAdjuntarDocumentos_Guia

    Private _pTABLE_NAME As String = ""
    Private _pUSER_NAME As String = ""
    Private _PSCCMPN As String = ""
    Private _PIMAGE_LIST As New List(Of String)
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As String = ""
    Private _PNCCLNT As String = ""
    Private _PSCREFFW As String = ""
    Private _pNMRGIM As String = ""


    Private _NGUIRM As Decimal
    Public Property PNGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Decimal)
            _NGUIRM = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            If _PSCDVSN = value Then
                Return
            End If
            _PSCDVSN = value
        End Set
    End Property

    Public Property PNCPLNDV() As String
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As String)
            If _PNCPLNDV = value Then
                Return
            End If
            _PNCPLNDV = value
        End Set
    End Property

    Public Property PSCREFFW() As String
        Get
            Return _PSCREFFW
        End Get
        Set(ByVal value As String)
            If _PSCREFFW = value Then
                Return
            End If
            _PSCREFFW = value
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

    Public Property PNCCLNT() As String
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As String)
            _PNCCLNT = value
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

    Public Property pUSER_NAME() As String
        Get
            Return _pUSER_NAME
        End Get
        Set(ByVal value As String)
            _pUSER_NAME = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
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


    Private Sub frmDocAdujuntoPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filestorage1 As New StorageFileManager.FileStorage
        filestorage1.NMRGIM = Me._pNMRGIM
        filestorage1.ImageListNumbers = _PIMAGE_LIST
        filestorage1.CCLNT = _PNCCLNT
        filestorage1.TableName = _pTABLE_NAME
        filestorage1.CCMPN = _PSCCMPN
        filestorage1.SystemName = "SA"
        filestorage1.UserName = _pUSER_NAME
        filestorage1.InitComponentProperties()
        filestorage1.Dock = DockStyle.Fill
        KryptonPanel.Controls.Add(filestorage1)
        AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.onSaveCampoNegocioUpload
        AddHandler filestorage1.EliminaImagen, AddressOf Me.onEliminaImagen
    End Sub

    Private Sub onEliminaImagen(ByVal sender As String)
        Me._pNMRGIM = sender
        If Me._NGUIRM <> 0 Then
            Dim obj As New UploadImagen
            Dim objhash As New Hashtable
            objhash.Add("PARAM_NMRGIM", Me._pNMRGIM)
            If obj.EliminaRelacionImagenGuia(objhash) Then
                Me._pNMRGIM = 0
                CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage).NMRGIM = 0
                MessageBox.Show("Se Eliminó con éxito")
                'Me.Close()
            Else
                MessageBox.Show("Ocurrió un Error al Eliminar")
            End If
        End If
    End Sub

    Private Sub onSaveCampoNegocioUpload(ByVal sender As Object)
        Dim objSave As New UploadImagen
        Dim objhash As New Hashtable

        objhash.Add("PARAM_CCLNT", Me._PNCCLNT)
        objhash.Add("PARAM_NGUIRM", Me._NGUIRM)
        objhash.Add("PARAM_NMRGIM", CType(sender, String))
        objhash.Add("PARAM_USUARIO", Me._pUSER_NAME)

        If Not objSave.GuardarEnTablaGuiaRemision(objhash) Then
            MessageBox.Show("Ocurrió un Error al Guardar")
        End If
    End Sub
End Class
