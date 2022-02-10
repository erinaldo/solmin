Imports SOLMIN_ST.NEGOCIO
Imports System.IO

Module MainModule

    'Declaración de la API (Para Liberar Memoria http://gdev.wordpress.com/2005/11/30/liberar-memoria-con-vb-net/)
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
    Public USUARIO As String
    Public gobj_TablasGeneralesdelSistema As New Hashtable

    Public Sub DeleteFiles(ByVal directorio As String)
        Dim filePath As String
        For Each filePath In Directory.GetFiles(directorio)
            Try
                File.Delete(filePath)
            Catch
                ' IGNORE EXCEPTION THROWN
            End Try
        Next
    End Sub

    'Public Sub CargarTablasGlobales()
    '    'Llamamos a los Storeds Procedures de uso General
    '    gobj_TablasGeneralesdelSistema.Clear()
    '    Dim objDbBridge As New DbBridge_BLL
    '    MainModule.gobj_TablasGeneralesdelSistema.Add("COMPANIA", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_COMPANIA", Nothing))
    '    MainModule.gobj_TablasGeneralesdelSistema.Add("DIVISION", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_DIVISION", Nothing))
    '    MainModule.gobj_TablasGeneralesdelSistema.Add("PLANTA", objDbBridge.GetTable("CALL SP_SOLMIN_TR_LISTAR_PLANTAS('" & "EZ" & "','" & "T" & "')"))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("MERCADERIA", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_MERCADERIA", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("UNIDAD", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_UNIDADES", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("SERVICIO", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_SERVICIOS", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("CLIENTE", objDbBridge.GetTable("SP_SOLMIN_ST_LISTAR_CLIENTES", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("UNIDAD_VEHICULAR", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_UNIDADES_TRANSPORTE", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("UBIGEO", objDbBridge.GetTable("SP_SOLMIN_ST_LISTAR_UBICACION_GEOGRAFICA", Nothing))
    '    'MainModule.gobj_TablasGeneralesdelSistema.Add("LOCALIDADES", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_LOCALIDADES", Nothing))
    '    ClearMemory()

    'End Sub

    Public Sub CargarTablasGlobales(ByVal COMPANIA As String, ByVal DIVISION As String)
        'Llamamos a los Storeds Procedures de uso General
        gobj_TablasGeneralesdelSistema.Clear()
        Dim objDbBridge As New DbBridge_BLL
        MainModule.gobj_TablasGeneralesdelSistema.Add("COMPANIA", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_COMPANIA", Nothing))
        MainModule.gobj_TablasGeneralesdelSistema.Add("DIVISION", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_DIVISION", Nothing))
        MainModule.gobj_TablasGeneralesdelSistema.Add("PLANTA", objDbBridge.GetTable("CALL SP_SOLMIN_TR_LISTAR_PLANTAS('" & COMPANIA & "','" & DIVISION & "')"))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("MERCADERIA", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_MERCADERIA", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("UNIDAD", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_UNIDADES", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("SERVICIO", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_SERVICIOS", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("CLIENTE", objDbBridge.GetTable("SP_SOLMIN_ST_LISTAR_CLIENTES", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("UNIDAD_VEHICULAR", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_UNIDADES_TRANSPORTE", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("UBIGEO", objDbBridge.GetTable("SP_SOLMIN_ST_LISTAR_UBICACION_GEOGRAFICA", Nothing))
        'MainModule.gobj_TablasGeneralesdelSistema.Add("LOCALIDADES", objDbBridge.GetTable("SP_SOLMIN_TR_LISTAR_LOCALIDADES", Nothing))
        ClearMemory()

    End Sub

    'Funcion de liberacion de memoria
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

    Public Function LoadImageFromUrl(ByRef url As String, Optional ByVal originalsize As Boolean = False, Optional ByVal height As Integer = 80, Optional ByVal width As Integer = 60) As Bitmap
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Image = Image.FromStream(response.GetResponseStream())
            Dim objbitmap As Bitmap
            If originalsize = False Then
                objbitmap = New Bitmap(img, height, width)
            Else
                objbitmap = img
            End If
            response.Close()
            Return objbitmap

        Catch ex As Exception
        End Try
    End Function

    Public Function ExistImageFromUrl(ByRef url As String) As Boolean
        Dim lbool_existe As Boolean = False
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Image = Image.FromStream(response.GetResponseStream())
            lbool_existe = True
        Catch ex As Exception
            lbool_existe = False
        End Try
        Return lbool_existe
    End Function
End Module

Enum MANTENIMIENTO
    NEUTRAL = 0
    NUEVO = 1
    EDITAR = 2
    ELIMINAR = 3
    MODIFICAR = 4
End Enum

Enum FOCO_MANTENIMIENTO
    MAN = 0
    SUB_MAN_ZERO = 1
    SUB_MAN_01 = 2
End Enum

Structure SYSTEMTIME
    Public wYear As UInt16
    Public wMonth As UInt16
    Public wDayOfWeek As UInt16
    Public wDay As UInt16
    Public wHour As UInt16
    Public wMinute As UInt16
    Public wSecond As UInt16
    Public wMilliseconds As UInt16
End Structure

