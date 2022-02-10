Imports System.Data.Common
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web

Module MainModule
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
    Public objdst_TablasGlobales As New DataSet

    Dim objLoadForm As CargarElementos

    Public Sub Preloader()
        objLoadForm = New CargarElementos
        objLoadForm.ShowDialog()
    End Sub

    Public Sub Closeloader()
        objLoadForm.Close()
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

    Enum MANTENIMIENTO
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum
    Public Sub Cargar_Tablas_Globales()
        Dim objCliente As New clsCliente
        Dim objCompania As New clsCompania
        Dim objDivision As New clsDivision
        Dim objPlanta As New clsPlanta
        'Dim objUsuario As New clsUsuario

        '   objCliente.Crea_Lista()
        'objCliente.Crea_Lista_Grupo_Cliente()
        '    HttpRuntime.Cache.Insert("Cliente", objCliente)

        objCompania.Crea_Lista()
        HttpRuntime.Cache.Insert("Compania", objCompania)

        objDivision.Crea_Lista()
        HttpRuntime.Cache.Insert("Division", objDivision)

        objPlanta.Crea_Lista()
        HttpRuntime.Cache.Insert("Planta", objPlanta)

        'HttpRuntime.Cache.Insert("Usuario", objUsuario)
    End Sub

    'Public Sub Cargar_Tablas_Globales()
    '    Dim objCliente As New clsCliente

    '    objCliente.Crea_Lista()
    '    HttpRuntime.Cache.Insert("clientes", objCliente)
    'End Sub

    'Public Sub Cargar_Tablas_Globales()

    '    Dim objSql As New SqlManager

    '    'Cargando la data de companias
    '    With objdst_TablasGlobales

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_COMPANIA", Nothing))
    '        .Tables(0).TableName = "COMPANIA"

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_DIVISION", Nothing))
    '        .Tables(1).TableName = "DIVISION"

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_CTZ_PLANTAS", Nothing))
    '        .Tables(2).TableName = "PLANTA"

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_CTZ_CLIENTES", Nothing))
    '        .Tables(3).TableName = "CLIENTES"

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_MONEDA", Nothing))
    '        .Tables(4).TableName = "MONEDAS"

    '        .Tables.Add(objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_UBIGEO", Nothing))
    '        .Tables(5).TableName = "UBIGEOS"


    '    End With 


    'End Sub

End Module

