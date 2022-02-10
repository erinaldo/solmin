Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class brCheckPoint

#Region "Mantenimiento"
    Dim oDatos As New daCheckPoint


    Public Function InsertarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As Integer
        Return oDatos.InsertarCheckPoint(obeCheckPoint)
    End Function

    Public Function ActualizarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As Integer
        Return oDatos.ActualizarCheckPoint(obeCheckPoint)
    End Function

    Public Function ListarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.ListarCheckPoint(obeCheckPoint)
    End Function

#End Region

#Region "Operaciones"

    ''' <summary>
    ''' Lista de Checkpoints por Cliente
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Lista_CheckPoint_X_Cliente(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.ListaCheckPointXCliente(obeCheckpoint)
    End Function

    ''' <summary>
    ''' Inserta Checkpoinst por guia de remision a la tabla RZOT01  Transaccional Checkpoint
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns>1 si se efectuo con exito y 0 si hubo algun tipo de error</returns>
    ''' <remarks></remarks>
    Public Function InsertarCheckPointXItemDeOc(ByVal obeCheckpoint As beCheckPoint) As Integer
        Return oDatos.InsertarCheckPointXItemDeOc(obeCheckpoint)
    End Function

    ''' <summary>
    ''' Actualiza Checkpoinst por guia de remision a la tabla RZOT01  Transaccional Checkpoint
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns>1 si se efectuo con exito y 0 si hubo algun tipo de error</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCheckPointXGuiaDeRemision(ByVal obeCheckpoint As beCheckPoint) As Integer
        Return oDatos.ActualizarCheckPointXGuiaDeRemision(obeCheckpoint)
    End Function


    ''' <summary>
    ''' Lista de Checkpoint por OC
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaCheckPointXItemsDeOC(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.ListaCheckPointXItemsDeOC(obeCheckpoint)
    End Function


    ''' <summary>
    ''' Lista de log de Checkpoint por item de OC
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaLogDeCheckPointXItemsDeOC(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.ListaLogDeCheckPointXItemsDeOC(obeCheckpoint)
    End Function



    ''' <summary>
    ''' Lista Checkpoint para exportar excel
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaCheckpointExportarExcel(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.ListaCheckpointExportarExcel(obeCheckpoint)
    End Function
#End Region

#Region "Bitacoras"
    Public Function listar_bitacora_itemOC(ByVal obeCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Return oDatos.listar_bitacoras_itemOC(obeCheckPoint)
    End Function
    Public Function insertar_bitacora_itemOC(ByVal obeCheckPoint As beCheckPoint) As Boolean
        Return oDatos.insertar_bitacora_intemOC(obeCheckPoint)
    End Function
    Public Function eliminar_bitacora_itemOC(ByVal obeCheckPoint As beCheckPoint) As Boolean
        Return oDatos.eliminar_bitacora_intemOC(obeCheckPoint)
    End Function
#End Region
End Class
