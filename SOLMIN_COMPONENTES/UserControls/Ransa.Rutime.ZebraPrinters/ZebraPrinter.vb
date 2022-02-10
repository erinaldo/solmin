Imports System.IO
Imports System.Runtime.InteropServices

''' <summary>
''' This class can print zebra labels to either a network share, LPT, or COM port.
''' </summary>
''' <remarks>Only tested for network share, but in theory works for LPT and COM.</remarks>
Public Class ZebraPrinter
#Region " Tipos de Datos "
    Private Structure PRINTER_DEFAULTS
        Public pDatatype As IntPtr
        Public pDevMode As IntPtr
        Public DesiredAccess As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure PRINTER_INFO_2
        <MarshalAs(UnmanagedType.LPTStr)> Public pServerName As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pPrinterName As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pShareName As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pPortName As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pDriverName As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pComment As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pLocation As String
        Public pDevMode As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public pSepFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pPrintProcessor As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pDatatype As String
        <MarshalAs(UnmanagedType.LPTStr)> Public pParameters As String
        Public pSecurityDescriptor As IntPtr
        Public Attributes As Integer
        Public Priority As Integer
        Public DefaultPriority As Integer
        Public StartTime As Integer
        Public UntilTime As Integer
        Public Status As Integer
        Public cJobs As Integer
        Public AveragePPM As Integer
    End Structure

    ''' <summary>
    ''' Structure for CreateFile.  Used only to fill requirement
    ''' </summary>
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SECURITY_ATTRIBUTES
        Private nLength As Integer
        Private lpSecurityDescriptor As Integer
        Private bInheritHandle As Integer
    End Structure
#End Region
#Region " Constantes "
    Private Const GENERIC_WRITE As Integer = &H40000000
    Private Const OPEN_EXISTING As Integer = 3
#End Region
#Region " Atributos "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private _SafeFileHandle As Microsoft.Win32.SafeHandles.SafeFileHandle

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private _fileWriter As StreamWriter

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private _outFile As FileStream

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private sErrorMessage As String
#End Region
#Region " Propiedades "
    Public ReadOnly Property ErrorMessage() As String
        Get
            Return sErrorMessage
        End Get
    End Property
#End Region
#Region " API's "
    <DllImport("winspool.drv", EntryPoint:="OpenPrinterA", ExactSpelling:=True, _
    SetLastError:=True, CallingConvention:=CallingConvention.StdCall, _
    CharSet:=CharSet.Ansi)> _
    Private Shared Function OpenPrinter(ByVal pPrinterName As String, ByRef hPrinter As IntPtr, ByRef pDefault As PRINTER_DEFAULTS) As Boolean
    End Function

    Private Declare Function GetPrinter Lib "winspool.drv" Alias "GetPrinterW" (ByVal hPrinter As IntPtr, ByVal Level As Integer, ByVal pPrinter As IntPtr, _
                                                                                ByVal cbBuf As Integer, ByRef pcbNeeded As Integer) As Integer

    <DllImport("winspool.drv", EntryPoint:="ClosePrinter", _
    SetLastError:=True, _
    ExactSpelling:=True, _
    CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function ClosePrinter(ByVal hPrinter As Int32) As Boolean
    End Function

    Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, _
                                                                            ByVal dwShareMode As Integer, <MarshalAs(UnmanagedType.Struct)> _
                                                                            ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, ByVal dwCreationDisposition As Integer, _
                                                                            ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Microsoft.Win32.SafeHandles.SafeFileHandle
#End Region
#Region " Métodos "
    Public Function pGetPrinterPath(ByVal sPrinterName As String) As String
        Dim sPrinterPath As String = ""
        If sPrinterName <> "" Then
            Dim PI2 As New PRINTER_INFO_2
            Dim pBuf As IntPtr
            Dim hPrinter As Integer
            Dim cbNeeded As Integer
            Dim rc As Integer
            Dim ts As PRINTER_DEFAULTS

            rc = OpenPrinter(sPrinterName, hPrinter, ts)
            If rc = 0 Then Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())

            'The first call will fail, but it will return the length of the buffer we need to allocate
            rc = GetPrinter(hPrinter, 2, Nothing, 0, cbNeeded)

            'Allocate a memory buffer and fill the buffer with the printer info
            pBuf = Marshal.AllocHGlobal(cbNeeded)

            rc = GetPrinter(hPrinter, 2, pBuf, cbNeeded, cbNeeded)
            If rc = 0 Then Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())

            'Convert the memory pointer to the printer info structre and free the pointer
            PI2 = Marshal.PtrToStructure(pBuf, GetType(PRINTER_INFO_2))
            Marshal.FreeHGlobal(pBuf)
            ClosePrinter(hPrinter)

            If PI2.pServerName <> "" And PI2.pShareName <> "" Then sPrinterPath = PI2.pServerName & "\" & PI2.pShareName
        End If
        Return sPrinterPath
    End Function

    ''' <summary>
    ''' Esta función debe ser llamado inicialmente - This function must be called first.  
    ''' El Path de la impresora debe ser un puerto COM o una ruta UNC - Printer path must be a COM Port or a UNC path.
    ''' </summary>
    Public Function StartWrite(ByVal printerPath As String) As Boolean
        Dim bResultado As Boolean = False
        Dim SA As SECURITY_ATTRIBUTES
        'Si la Ruta de la Impresora es "", se imprime en el LPT1 por Defecto
        If printerPath.Trim = "" Then printerPath = "LPT1"
        'Crear conexión - Create connection
        _SafeFileHandle = CreateFile(printerPath, GENERIC_WRITE, 0, SA, OPEN_EXISTING, 0, 0)
        'Crear el espacio para el archivo - Create file stream
        Try
            _outFile = New FileStream(_SafeFileHandle, FileAccess.Write)
            _fileWriter = New StreamWriter(_outFile)
            bResultado = True
        Catch ex As Exception
            sErrorMessage = "No se puede encontrar la impresora."
        End Try
        Return bResultado
    End Function

    ''' <summary>
    ''' Esto escribiría un comando en la impresora - This will write a command to the printer.
    ''' </summary>
    Public Sub Write(ByVal rawLine As String)
        If _fileWriter IsNot Nothing Then
            _fileWriter.WriteLine(rawLine)
        End If
    End Sub

    ''' <summary>
    ''' Esta función debería ser llamada despues de escribir en la impresora zebra - This function must be called after writing to the zebra printer.
    ''' </summary>
    Public Sub EndWrite()
        ' Limpiamos - Clean up
        If _fileWriter IsNot Nothing Then
            _fileWriter.Flush()
            _fileWriter.Close()
            _outFile.Close()
        End If
        _SafeFileHandle.Close()
        _SafeFileHandle.Dispose()
    End Sub
#End Region
End Class