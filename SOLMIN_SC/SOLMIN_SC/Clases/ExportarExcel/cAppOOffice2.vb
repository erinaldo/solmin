
' Espacio de Nombres IDE
Imports System.Runtime.InteropServices

Namespace OOffice2
    Public Class cAppOOffice2
        Implements IDisposable
#Region " Definición Eventos "

#End Region
#Region " Atributos "
        '-------------------------------------------------
        ' Manejador de la Conexion
        '-------------------------------------------------
        Private Shared OpenOffice As Object
        Private Shared StarDesktop As Object
        Private Shared OOoIntrospection As Object
        Private Shared OOoDisp As Object
        Private Shared nInstances As Int32 = 0
        '-------------------------------------------------
        ' Almacenamiento de Información
        '-------------------------------------------------
        Private sErrorMessage As String = ""
        '-------------------------------------------------
        ' Información del Estado
        '-------------------------------------------------
        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
        Private Const OOoErrorN = 2000
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
        Private Function ConvertToUrl(ByVal strFile) As String
            strFile = Replace(strFile, "\", "/")
            strFile = Replace(strFile, ":", "|")
            strFile = Replace(strFile, " ", "%20")
            strFile = "file:///" + strFile
            ConvertToUrl = strFile
        End Function

        Private Function CreateUnoService(ByVal serviceName As String) As Object
            ' équivalent de la fonction OOoBasic  
            ' equivalent to OOoBasic function
            Dim Result As Object

            Result = OpenOffice.createInstance(serviceName)
            If isNullEmpty(Result) Then
                Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_serviceKO & serviceName)
            End If
            CreateUnoService = Result
        End Function

        Private Sub CloseReferenceOOpenOffice()
            ' release method inspired from http://www.xtremevbtalk.com/showthread.php?t=160433 
            ' this sequence tries to avoid error message R6025 from Visual C++ runtime
            OOoIntrospection = Nothing
            OOoDisp = Nothing
            StarDesktop = Nothing
            OpenOffice = Nothing
            GC.Collect() ' force garbage collection
            GC.WaitForPendingFinalizers() ' Wait for end of garbage collection before continuing
            GC.Collect() ' second pass of cleaning
            GC.WaitForPendingFinalizers()
            ' here no variable should be pointing at an OpenOffice object
            nInstances = 0
        End Sub

        Private Function dummyArray() As Object
            ' creates an empty array for an empty list
            Dim Result(-1) As Object
            dummyArray = Result
        End Function
#End Region
#Region " Métodos "
        Sub New()
            If Not IsOpenOfficeConnected() Then
                Try
                    OpenOffice = CreateObject("com.sun.star.ServiceManager")
                Catch
                    OpenOffice = Nothing
                End Try
            End If
        End Sub

        Public Sub CloseAllOpenOffice(Optional ByVal closeOpenOffice As Boolean = False)
            Call CloseReferenceOOpenOffice()
            ' reopen a connection only to close OpenOffice !
            Dim ooo As Object, dtp As Object
            ooo = CreateObject("com.sun.star.ServiceManager")
            dtp = ooo.createInstance("com.sun.star.frame.Desktop")
            ' this code may trigger error R6025 from C++ runtime
            ' this is avoided if you run the released code, not the debug code
            dtp.terminate()
            dtp = Nothing
            ooo = Nothing
        End Sub

        Public Function ExistApp() As Boolean
            Dim bResultado As Boolean = False
            If Not isNullEmpty(OpenOffice) Then bResultado = True
            Return bResultado
        End Function

        Public Sub pExportarToXLS(ByVal strFileXLS As String, ByVal iXref As Integer, ByVal iYref As Integer, ByVal dtTemp As DataTable, _
                                  Optional ByVal NroLineaGrupoInf As Int32 = 0, Optional ByVal NroLineasBlancas As Int32 = 0)
            Dim myDoc As Object, firstSheet As Object

            Try
                If isNullEmpty(OpenOffice) Then
                    Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_connectKO)
                Else
                    If isNullEmpty(StarDesktop) Then StarDesktop = CreateUnoService("com.sun.star.frame.Desktop")
                    If isNullEmpty(OOoIntrospection) Then OOoIntrospection = CreateUnoService("com.sun.star.beans.Introspection")
                    If isNullEmpty(OOoDisp) Then OOoDisp = CreateUnoService("com.sun.star.frame.DispatchHelper")
                    nInstances += 1
                End If

                Dim i As Int16 = 0
                Dim j As Int16 = 0
                Dim z As Int16 = 0

                Dim nNroLineasTemp As Int32 = 0
                'Modificado para que soporte la carga del Doc Excel
                'myDoc = StarDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, dummyArray)
                strFileXLS = ConvertToUrl(strFileXLS)
                myDoc = StarDesktop.loadComponentFromURL(strFileXLS, "_blank", 0, dummyArray)
                firstSheet = myDoc.Sheets.getByIndex(0)
                ' Agregar las Filas de Datos
                For j = 0 To dtTemp.Rows.Count - 1 'intHeaders - 1
                    ' Cargar la data
                    nNroLineasTemp += 1
                    For i = 0 To dtTemp.Columns.Count - 1
                        Select Case dtTemp.Rows(j).Item(i).GetType.Name
                            Case GetType(String).Name
                                firstSheet.getCellByPosition(i + iXref - 1, iYref + j - 1).String = ("" & dtTemp.Rows(z).Item(i)).ToString
                            Case Else
                                If Trim("" & dtTemp.Rows(j).Item(i)) <> "" Then _
                                firstSheet.getCellByPosition(i + iXref - 1, iYref + j - 1).Value = dtTemp.Rows(z).Item(i)
                        End Select

                    Next i
                    If nNroLineasTemp = NroLineaGrupoInf Then
                        nNroLineasTemp = 0
                        j += NroLineasBlancas
                    End If
                    z += 1
                Next j
            Catch ex As Exception
                sErrorMessage = "Error en el proceso de escritura. " & vbNewLine & "DETALLE : " & ex.Message
            Finally
                firstSheet = Nothing
                myDoc = Nothing
                'myDoc.close(True)
            End Try
        End Sub

        Public Function IsOpenOfficeConnected() As Boolean
            Dim DeskTopbis As Object

            IsOpenOfficeConnected = False
            If Not isNullEmpty(OpenOffice) Then
                Try
                    DeskTopbis = OpenOffice.createInstance("com.sun.star.frame.Desktop")
                    DeskTopbis = Nothing
                    IsOpenOfficeConnected = True
                Catch
                    OpenOffice = Nothing
                    IsOpenOfficeConnected = False
                End Try
            Else
                IsOpenOfficeConnected = False
            End If
        End Function

        Public Function isNullEmpty(ByVal thisVariant As Object) As Boolean
            isNullEmpty = IsNothing(thisVariant) Or IsDBNull(thisVariant)
        End Function
#End Region
#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                End If
                nInstances = nInstances - 1
                If nInstances = 0 Then Call CloseReferenceOOpenOffice()
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
End Namespace