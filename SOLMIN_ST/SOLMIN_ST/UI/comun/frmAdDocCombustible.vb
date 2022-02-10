Imports SOLMIN_ST.NEGOCIO

Public Class frmAdDocCombustible

    Public pTABLE_NAME As String = ""
    Public pUSER_NAME As String = ""
    Public pCCMPN As String = ""
    Public pSCDVSN As String = ""
    Public pNCPLNDV As String = ""
    Public pNCCLNT As String = ""
    Public pNMRGIM As String = ""
    Public pNLQCMB As Decimal = 0
    Public pDialog As Boolean = False
    Private Sub frmDocAdujuntoPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim filestorage1 As New StorageFileManager.FileStorage
        'filestorage1.NMRGIM = pNMRGIM
        'filestorage1.CCLNT = pNCCLNT
        'filestorage1.TableName = pTABLE_NAME
        'filestorage1.CCMPN = pCCMPN
        'filestorage1.SystemName = "WB"
        'filestorage1.UserName = pUSER_NAME
        'filestorage1.InitComponentProperties()
        'filestorage1.Dock = DockStyle.Fill
        'KryptonPanel.Controls.Add(filestorage1)
        'AddHandler filestorage1.onSaveCampoNegocio, AddressOf Me.onSaveCampoNegocioUpload
        'AddHandler filestorage1.EliminaImagen, AddressOf Me.onEliminaImagen
    End Sub

    Private Sub onEliminaImagen(ByVal sender As String)
        pDialog = True
        Me.pNMRGIM = sender
        Dim objNegocio As New AdjuntarImagen_BLL
        Dim objhash As New Hashtable
        objhash.Add("PNNMRGIM", pNMRGIM)
        objhash.Add("PSCCMPN", pCCMPN)
        If objNegocio.Eliminar_Correlativo_Imagen_Liq_Combustible(objhash) Then

            Me.pNMRGIM = 0
            'CType(KryptonPanel.Controls(0), StorageFileManager.FileStorage).NMRGIM = 0
            'filestorage1.NMRGIM = _pNMRGIM
            MessageBox.Show("Documento eliminado con éxito", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al eliminar el Documento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub onSaveCampoNegocioUpload(ByVal sender As Object)
        pDialog = True
        Dim objNegocio As New AdjuntarImagen_BLL
        Dim objhash As New Hashtable
        objhash.Add("PSCCMPN", pCCMPN)
        objhash.Add("PNNLQCMB", pNLQCMB)
        objhash.Add("PNNMRGIM", sender)
        objhash.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        objhash.Add("PSCULUSA", pUSER_NAME)
        objNegocio.Actualizar_Numero_Imagen_Liq_Combustible(objhash)

        'If Not objNegocio.Actualizar_Numero_Imagen_Liq_Combustible(objhash) Then
        '    '    MessageBox.Show("Documento guardado con exito", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'Else
        '    MessageBox.Show("Error al guardar el documento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub
End Class
