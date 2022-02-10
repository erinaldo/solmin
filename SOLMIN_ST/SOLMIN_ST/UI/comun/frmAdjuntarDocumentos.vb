Imports SOLMIN_ST.NEGOCIO

Public Class frmAdjuntarDocumentos

    Private _pTABLE_NAME As String = ""
    Private _pUSER_NAME As String = ""
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As String = ""
    Private _PNCCLNT As String = ""
    Private _PSNGUITR As String = ""
    Private _pNMRGIM As String = ""
    Private _pCTRSPT As String = ""
    Private _pNGUITR As String = ""
    Private _pCTRMNC As String = ""
    Private _pNGUIRM As String = ""
    Public Property pCTRMNC() As String
        Get
            Return _pCTRMNC
        End Get
        Set(ByVal value As String)
            _pCTRMNC = value
        End Set
    End Property
    Public Property pNGUIRM() As String
        Get
            Return _pNGUIRM
        End Get
        Set(ByVal value As String)
            _pNGUIRM = value
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

    Public Property PSNGUITR() As String
        Get
            Return _PSNGUITR
        End Get
        Set(ByVal value As String)
            If _PSNGUITR = value Then
                Return
            End If
            _PSNGUITR = value
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
    Public Property CTRSPT() As String
        Get
            Return _pCTRSPT
        End Get
        Set(ByVal value As String)
            _pCTRSPT = value
        End Set
    End Property
    Public Property NGUITR()
        Get
            Return _pNGUITR
        End Get
        Set(ByVal value)
            _pNGUITR = value
        End Set
    End Property


    Private Sub frmDocAdujuntoPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim filestorage1 As New StorageFileManager.FileStorage
        'filestorage1.NMRGIM = Me._pNMRGIM
        'filestorage1.CCLNT = _PNCCLNT
        'filestorage1.TableName = _pTABLE_NAME
        'filestorage1.CCMPN = _PSCCMPN
        'filestorage1.SystemName = "ST"
        'filestorage1.UserName = _pUSER_NAME
        'filestorage1.InitComponentProperties()
        'filestorage1.Dock = DockStyle.Fill
        'KryptonPanel.Controls.Add(filestorage1)
        'AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.onSaveCampoNegocioUpload
        'AddHandler filestorage1.EliminaImagen, AddressOf Me.onEliminaImagen
    End Sub

    Private Sub onEliminaImagen(ByVal sender As String)
        Me._pNMRGIM = sender
        Dim objNegocio As New mantenimientos.GuiaTransportista_BLL
        Dim objhash As New Hashtable
        objhash.Add("PARAM_NMRGIM", Me._pNMRGIM)
        objhash.Add("PARAM_CCMPN", Me.PSCCMPN)
        If objNegocio.Eliminar_Correlativo_Imagen(objhash) Then
            Me._pNMRGIM = 0
            'CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage).NMRGIM = 0
            'filestorage1.NMRGIM = _pNMRGIM
            MessageBox.Show("Documento eliminado con éxito", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al eliminar el Documento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub onSaveCampoNegocioUpload(ByVal sender As Object)
        Dim objNegocio As New mantenimientos.GuiaTransportista_BLL
        Dim objhash As New Hashtable
        objhash.Add("PARAM_CTRMNC", Me.PNCCLNT)
        objhash.Add("PARAM_NGUIRM", Me.pNGUIRM)
        objhash.Add("PARAM_NMRGIM", sender)
        objhash.Add("PARAM_CULUSA", Me.pUSER_NAME)
        objhash.Add("PARAM_CCMPN", Me.PSCCMPN)

        If Not objNegocio.Actualizar_Guia_Numero_Imagen(objhash) Then
            '    MessageBox.Show("Documento guardado con exito", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            MessageBox.Show("Error al guardar el documento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
