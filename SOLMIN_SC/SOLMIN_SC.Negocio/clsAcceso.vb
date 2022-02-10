Imports SOLMIN_SC.Datos

Public Class clsAcceso
    Private objAcceso As SOLMIN_SC.Datos.clsAcceso

    Sub New()
        objAcceso = New SOLMIN_SC.Datos.clsAcceso
    End Sub

    Public Function Verifica_Archivo() As Boolean
        Return objAcceso.Verifica_Archivo
    End Function

    Public Function Valida_Acceso(ByVal pstrUser As String, ByVal pstrPass As String) As Boolean
        Return objAcceso.Valida_Acceso(pstrUser, pstrPass)
    End Function

    Public Sub Destruir()
        objAcceso.Destruir()
    End Sub


    Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As Entidad.beAcceso
        Return objAcceso.Validar_Acceso_Opciones_Usuario(objetoParametro)
    End Function

    Public Function getAppSetting(ByVal Nombre As String) As String
        Return objAcceso.getAppSetting(Nombre)
    End Function



#Region " Bloqueo de Clientes "
    Public Function fblnIsLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As Int64, _
                                 ByVal FnVerificacion As String, ByRef strMensaje As String) As Boolean
        Return objAcceso.fblnIsLocked(Compania, Division, Cliente, FnVerificacion, strMensaje)
    End Function
#End Region
End Class
