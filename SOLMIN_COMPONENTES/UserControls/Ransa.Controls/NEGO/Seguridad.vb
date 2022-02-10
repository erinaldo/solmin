
Public Class Seguridad
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private oOptionAccess As OptionAccess
#End Region
#Region " Propiedades "
    Public ReadOnly Property pUsuario() As String
        Get
            Dim strUsuario As String = ""
            If Not oOptionAccess Is Nothing Then
                strUsuario = oOptionAccess.pUsuario
            End If
            Return strUsuario
        End Get
    End Property

    Public ReadOnly Property pMensajeError() As String
        Get
            Dim strMensajeError As String = ""
            If Not oOptionAccess Is Nothing Then
                strMensajeError = oOptionAccess.pMensajeError
            End If
            Return strMensajeError
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Metodos "
    Sub New(ByVal Usuario As String)
        oOptionAccess = New OptionAccess(Usuario)
    End Sub

    Public Function fblnIsLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As Int64, ByVal FnVerificacion As String, _
                                 ByRef Mensaje As String, ByVal lstrRegionVenta As String) As Boolean
        Return oOptionAccess.fblnIsLocked(Compania, Division, Cliente, FnVerificacion, Mensaje, lstrRegionVenta)
    End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If
            ' TODO: Liberar recursos no administrados compartidos
            If Not oOptionAccess Is Nothing Then oOptionAccess.Dispose()
            oOptionAccess = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class