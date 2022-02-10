Module MainModule

    Public USUARIO As String
    'Declaración de la API (Para Liberar Memoria http://gdev.wordpress.com/2005/11/30/liberar-memoria-con-vb-net/)
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub ClearMemory()
        Try
            ''Forzando al Garbage Collector
            GC.WaitForPendingFinalizers()
            GC.Collect()
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch : End Try
    End Sub

End Module


Enum MANTENIMIENTO
    NEUTRAL = 0
    NUEVO = 1
    EDITAR = 0
    ELIMINAR = 0
End Enum
