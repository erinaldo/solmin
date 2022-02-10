Imports System.Windows.Forms

Public Class frmAdjuntarDocumentos

    Private _myDialogResult As Boolean = False
    Public Property myDialogResult() As Boolean
        Get
            Return _myDialogResult
        End Get
        Set(ByVal value As Boolean)
            _myDialogResult = value
        End Set
    End Property

    Private _NINCSI As Decimal
    Public Property NINCSI() As Decimal
        Get
            Return _NINCSI
        End Get
        Set(ByVal value As Decimal)
            _NINCSI = value
        End Set
    End Property


    Enum EnumAdjunto
        Neutro
        Incidencias
        Seguimiento

        'PreEmbarque
        'EmbarqueDocEmb
        'EmbarqueDocCosto
    End Enum
    Enum EnumModo
        Neutro
        Edicion
    End Enum

    Private _TipoModo As EnumModo = EnumModo.Neutro
    Public Property TipoModo() As EnumModo
        Get
            Return _TipoModo
        End Get
        Set(ByVal value As EnumModo)
            _TipoModo = value
        End Set
    End Property

    Private _TipoAdjunto As EnumAdjunto = EnumAdjunto.Neutro
    Private _pNMRGIM As String = ""
    Private _pCCLNT As String = ""
    Private _pTABLE_NAME As String = ""
    Private _pUSER_NAME As String = ""
    Private _pCCMPN As String = ""
    Private _PIMAGE_LIST As New List(Of String)
    Private _pNMRGIM_LIST As New List(Of String)

    Private _ModeEdition As Boolean = True


    'Private _pPNRPEMB As Decimal = 0
    'Private _pPNORSCI As Decimal = 0
    'Private _pNDOCIN As Decimal = 0
    'Private _pNCRRDC As Decimal = 0


    'Public Property pPNRPEMB() As String
    '    Get
    '        Return _pPNRPEMB
    '    End Get
    '    Set(ByVal value As String)
    '        _pPNRPEMB = value
    '    End Set
    'End Property

    'Public Property pPNORSCI() As Decimal
    '    Get
    '        Return _pPNORSCI
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _pPNORSCI = value
    '    End Set
    'End Property

    'Public Property pNDOCIN() As Decimal
    '    Get
    '        Return _pNDOCIN
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _pNDOCIN = value
    '    End Set
    'End Property

    'Public Property pNCRRDC() As Decimal
    '    Get
    '        Return _pNCRRDC
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _pNCRRDC = value
    '    End Set
    'End Property

    Private _pNameSystem As String = ""

    Sub New(ByVal NMRGIM As String, ByVal NMRGIM_LIST As List(Of String), ByVal CCLNT As String, ByVal TABLE_NAME As String, ByVal CCMPN As String, ByVal USER_NAME As String, ByVal TipoAdjunto As EnumAdjunto, ByVal _pNameSystem1 As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        _pNMRGIM = NMRGIM
        _pCCLNT = CCLNT
        _pTABLE_NAME = TABLE_NAME
        _pUSER_NAME = USER_NAME
        _pCCMPN = CCMPN
        _pNameSystem = _pNameSystem1
        If NMRGIM_LIST Is Nothing OrElse NMRGIM_LIST.Count = 0 Then
            _pNMRGIM_LIST = New List(Of String)
        Else
            _pNMRGIM_LIST = NMRGIM_LIST
        End If

        _TipoAdjunto = TipoAdjunto
    End Sub


    Private Sub frmDocAdujuntoPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        If _TipoAdjunto = EnumAdjunto.Neutro Then
            MessageBox.Show("Asigne Tipo Adjunto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim filestorage1 As New StorageFileManager.FileStorage
        filestorage1.NMRGIM = Me._pNMRGIM
        filestorage1.ImageListNumbers = _pNMRGIM_LIST
        filestorage1.CCLNT = _pCCLNT
        filestorage1.TableName = _pTABLE_NAME
        filestorage1.CCMPN = _pCCMPN
        filestorage1.SystemName = _pNameSystem
        filestorage1.UserName = _pUSER_NAME
        Select Case _TipoModo
            Case EnumModo.Neutro
                filestorage1.ModeEdition = False
            Case EnumModo.Edicion
                filestorage1.ModeEdition = True
        End Select
        filestorage1.InitComponentProperties()
        filestorage1.Dock = DockStyle.Fill

        KryptonPanel.Controls.Add(filestorage1)

        Select Case _TipoAdjunto

            Case EnumAdjunto.Incidencias
                AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.GuardarRelacionImagenRZSC39_Incidencias
                AddHandler filestorage1.EliminaImagen, AddressOf Me.EliminaRelacionImagenRZSC39_Incidencias

            Case EnumAdjunto.Seguimiento
                AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.GuardarRelacionImagenRZSC39_Seguimiento
                AddHandler filestorage1.EliminaImagen, AddressOf Me.EliminaRelacionImagenRZSC39_Seguimiento


        End Select

    End Sub

    Private Sub GuardarRelacionImagenRZSC39_Incidencias(ByVal sender As Object)
        Try
            Dim objSave As New brIncidencias
            Me._pNMRGIM = sender
            If _NINCSI <> 0D Then
                objSave.intGuardarImagenIncidencias(_NINCSI, CDec(_pNMRGIM), _pUSER_NAME, Environment.MachineName)
                MessageBox.Show("Se guardó con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _myDialogResult = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminaRelacionImagenRZSC39_Incidencias(ByVal sender As String)
        Try
            Me._pNMRGIM = sender
            Dim objSave As New brIncidencias
            If _NINCSI <> 0D Then
                objSave.intEliminarImagenIncidencias(_NINCSI, CDec(_pNMRGIM), _pUSER_NAME, Environment.MachineName)
                Dim filestorage1 As New StorageFileManager.FileStorage
                filestorage1 = CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage)
                filestorage1.NMRGIM = "0"
                _myDialogResult = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub GuardarRelacionImagenRZSC39_Seguimiento(ByVal sender As Object)
        Try
            Dim objSave As New brSeguimiento
            Me._pNMRGIM = sender
            If _NINCSI <> 0D Then
                objSave.intGuardarImagenSeguimiento(_NINCSI, CDec(_pNMRGIM), _pUSER_NAME, Environment.MachineName)
                MessageBox.Show("Se guardó con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _myDialogResult = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminaRelacionImagenRZSC39_Seguimiento(ByVal sender As String)
        Try
            Me._pNMRGIM = sender
            Dim objSave As New brSeguimiento
            If _NINCSI <> 0D Then
                objSave.intEliminarImagenSeguimiento(_NINCSI, CDec(_pNMRGIM), _pUSER_NAME, Environment.MachineName)
                Dim filestorage1 As New StorageFileManager.FileStorage
                filestorage1 = CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage)
                filestorage1.NMRGIM = "0"
                _myDialogResult = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
