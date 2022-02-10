Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsBitacora
    Private oCheckPoint As SOLMIN_SC.Datos.clsBitacora
    Sub New()
        oCheckPoint = New SOLMIN_SC.Datos.clsBitacora
    End Sub
#Region "Bitacoras"
    Public Function listar_bitacora_itemOC(ByVal obeCheckPoint As beBitacora) As List(Of beBitacora)
        Return oCheckPoint.listar_bitacoras_itemOC(obeCheckPoint)
    End Function
    Public Function insertar_bitacora_itemOC(ByVal obeCheckPoint As beBitacora) As Boolean
        Return oCheckPoint.insertar_bitacora_intemOC(obeCheckPoint)
    End Function
    Public Function eliminar_bitacora_itemOC(ByVal obeCheckPoint As beBitacora) As Boolean
        Return oCheckPoint.eliminar_bitacora_intemOC(obeCheckPoint)
    End Function
    Public Function InsertarCheckPointXItemDeOc(ByVal obeCheckpoint As beBitacora) As Integer
        Return oCheckPoint.InsertarCheckPointXItemDeOc(obeCheckpoint)
    End Function
    Public Function ListaLogDeCheckPointXItemsDeOC(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Return oCheckPoint.ListaLogDeCheckPointXItemsDeOC(obeCheckpoint)
    End Function
    Public Function ListaCheckPointXItemsDeOC(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Return oCheckPoint.ListaCheckPointXItemsDeOC(obeCheckpoint)
    End Function
    Public Function Lista_CheckPoint_X_Cliente(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Return oCheckPoint.ListaCheckPointXCliente(obeCheckpoint)
    End Function
#End Region
End Class
