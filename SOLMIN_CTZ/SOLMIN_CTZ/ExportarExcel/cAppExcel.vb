Public Class cAppExcel
    Implements IDisposable
#Region " Definición Eventos "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private Shared oType As Type
    Private Shared oExcel As Object
    Private Shared oBooks As Object
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
    Private Sub CloseReferenceExcel()
        ' release method inspired from http://www.xtremevbtalk.com/showthread.php?t=160433 
        ' this sequence tries to avoid error message R6025 from Visual C++ runtime
        oType = Nothing
        If Not isNullEmpty(oBooks) Then System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
        oBooks = Nothing
        If Not isNullEmpty(oExcel) Then System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
        oExcel = Nothing
        GC.Collect() ' force garbage collection
        GC.WaitForPendingFinalizers() ' Wait for end of garbage collection before continuing
        GC.Collect() ' second pass of cleaning
        GC.WaitForPendingFinalizers()
        ' here no variable should be pointing at an OpenOffice object
        nInstances = 0
    End Sub

    Private Function isNullEmpty(ByVal thisVariant As Object) As Boolean
        isNullEmpty = IsNothing(thisVariant) Or IsDBNull(thisVariant)
    End Function
#End Region
#Region " Métodos "
    Sub New()
        If isNullEmpty(oExcel) Then
            Try
                ' Iniciamos Excel y abrimos un libro
                oType = Type.GetTypeFromProgID("Excel.Application")
                nInstances += 1
            Catch ex As Exception
                oExcel = Nothing
                Err.Raise(vbObjectError + OOoErrorN, "Excel", "Excel connection is impossible")
            End Try
        End If
    End Sub

    Public Function ExistApp() As Boolean
        Dim objType As Type = Type.GetTypeFromProgID("Excel.Application")
        Dim bResultado As Boolean = False
        If Not isNullEmpty(objType) Then bResultado = True
        Return bResultado
    End Function

    Public Sub pExportarToXLS(ByVal strFileXLS As String, ByVal iXref As Integer, ByVal iYref As Integer, ByVal dtTemp As DataTable, _
                              Optional ByVal NroLineaGrupoInf As Int32 = 0, Optional ByVal NroLineasBlancas As Int32 = 0)
        Dim oBook As Object = Nothing
        Dim oWorksheet As Object
        sErrorMessage = ""

        Try
            ' Si no existe una referencia al objeto EXCEL, no se debe procesar alguna operación de generación
            If isNullEmpty(oExcel) Then
                oExcel = Activator.CreateInstance(oType)
                oExcel.Visible = True
                If Not isNullEmpty(oExcel) Then oBooks = oExcel.Workbooks
            End If

            Dim i As Int16 = 0
            Dim j As Int16 = 0
            Dim Z As Int16 = 0
            Dim nNroLineasTemp As Int32 = 0

            ' Validamos que la coleccion de filas no sea nothing
            If Not dtTemp Is Nothing Then
                oBook = oBooks.Open(strFileXLS)
                ' Asignamos el objeto Sheet
                oWorksheet = oBook.ActiveSheet
                nNroLineasTemp = 0
                ' Agregar las Filas de Datos
                For j = 0 To dtTemp.Rows.Count - 1 'intHeaders - 1
                    nNroLineasTemp += 1
                    ' Cargar la data
                    For i = 0 To dtTemp.Columns.Count - 1
                        If dtTemp.Rows(Z).Item(i).GetType.FullName.ToString.Equals("System.String") Then
                            oWorksheet.Cells(iYref + j, i + iXref).NumberFormat = "@"
                            oWorksheet.Cells(iYref + j, i + iXref).Value = "" & dtTemp.Rows(Z).Item(i)
                        Else
                            oWorksheet.Cells(iYref + j, i + iXref).Value = "" & dtTemp.Rows(Z).Item(i)
                        End If
                    Next i

                    If nNroLineasTemp = NroLineaGrupoInf Then
                        nNroLineasTemp = 0
                        j += NroLineasBlancas
                    End If
                    Z += 1
                Next j
                'If strFileSaveAs <> "" Then
                '    oBook.SaveAs(strFileSaveAs)
                'End If
            End If
        Catch ex As Exception
            sErrorMessage = "Error en el proceso de escritura. " & vbNewLine & "DETALLE : " & ex.Message
        Finally
            ' Eliminamos los objetos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
            oBook = Nothing
            oWorksheet = Nothing
        End Try
    End Sub
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If
            nInstances = nInstances - 1
            If nInstances = 0 Then Call CloseReferenceExcel()
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

