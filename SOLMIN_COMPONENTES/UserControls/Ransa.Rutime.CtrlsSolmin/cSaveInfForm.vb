Imports System.IO

Public Class cSaveInfForm
    Implements IDisposable
#Region " Definición Eventos "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private sNameFile As String = ""
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property ErrorMessage() As String
        Get
            Return sErrorMessage
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New(ByVal ApplicationName As String, ByVal NameFile As String)
        ApplicationName = ApplicationName.Replace(" ", "_")
        Dim sDirectorio As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\XML_" & ApplicationName
        If Not Directory.Exists(sDirectorio) Then
            Directory.CreateDirectory(sDirectorio)
        End If
        sNameFile = sDirectorio & "\" & NameFile
    End Sub

    Public Function pSetParametros(ByVal dtParametros As DataTable) As Boolean
        Dim bResultado As Boolean = False
        Try
            dtParametros.WriteXml(sNameFile)
            bResultado = True
        Catch ex As Exception
            sErrorMessage = ex.Message
        End Try
        Return bResultado
    End Function

    Public Function pGetParametros(ByRef dtParametros As DataTable) As Boolean
        Dim bResultado As Boolean = False
        Try
            If File.Exists(sNameFile) Then
                dtParametros.ReadXml(sNameFile)
                bResultado = True
            End If
        Catch ex As Exception
            sErrorMessage = ex.Message
        End Try
        Return bResultado
    End Function

    Public Function pGetParametros(ByRef dtParametros As DataTable, ByVal nLapsoTopeMinuto As Integer) As Boolean
        Dim bResultado As Boolean = False
        Try
            If File.Exists(sNameFile) Then
                Dim dFechaHoraCreacion As Date = File.GetCreationTime(sNameFile)
                Dim iMinutos As Integer = DateDiff(DateInterval.Minute, Now, dFechaHoraCreacion)
                If nLapsoTopeMinuto >= iMinutos Then
                    dtParametros.ReadXml(sNameFile)
                    bResultado = True
                End If
            End If
        Catch ex As Exception
            sErrorMessage = ex.Message
        End Try
        Return bResultado
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