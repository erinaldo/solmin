Imports System.Runtime.InteropServices

Public Class cQProRansa
    Implements IDisposable
#Region " Definici�n Eventos "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private oAppExcel As cAppExcel
    Private oAppOOffice As OOffice2.cAppOOffice2
    '-------------------------------------------------
    ' Almacenamiento de Informaci�n
    '-------------------------------------------------
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Informaci�n del Estado
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
#Region " M�todos "
    Sub New()
        oAppExcel = New cAppExcel
        oAppOOffice = New OOffice2.cAppOOffice2
    End Sub

    Public Function pExportarToXLS(ByVal strFileXLS As String, ByVal iXref As Integer, ByVal iYref As Integer, ByVal dtTemp As DataTable, _
                                   Optional ByVal NroLineaGrupoInf As Int32 = 0, Optional ByVal NroLineasBlancas As Int32 = 0) As Boolean
        If oAppExcel.ExistApp Then
            oAppExcel.pExportarToXLS(strFileXLS, iXref, iYref, dtTemp, NroLineaGrupoInf, NroLineasBlancas)
        Else
            If oAppOOffice.ExistApp Then
                oAppOOffice.pExportarToXLS(strFileXLS, iXref, iYref, dtTemp, NroLineaGrupoInf, NroLineasBlancas)
            Else
                sErrorMessage = "No existe ning�n aplicativo para generar la Hoja de C�lculo."
            End If
        End If
    End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen expl�citamente
            End If
            ' TODO: Liberar recursos no administrados compartidos
            oAppExcel.Dispose()
            oAppExcel = Nothing
            oAppOOffice.Dispose()
            oAppOOffice = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' Visual Basic agreg� este c�digo para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este c�digo. Coloque el c�digo de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class