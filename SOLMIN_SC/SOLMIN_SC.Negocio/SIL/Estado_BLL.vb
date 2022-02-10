Imports SOLMIN_SC.Entidad
Public Class Estado_BLL
    Public Function Estado_Aduanero() As List(Of beEstadoEmb)
        Dim oListEstado As New List(Of beEstadoEmb)
        Dim oEstado As beEstadoEmb


        oEstado = New beEstadoEmb
        oEstado.COD = "0"
        oEstado.TEX = "TODOS"
        oListEstado.Add(oEstado)

        oEstado = New beEstadoEmb
        oEstado.COD = "A"
        oEstado.TEX = "EN ATENCION"
        oListEstado.Add(oEstado)

        oEstado = New beEstadoEmb
        oEstado.COD = "C"
        oEstado.TEX = "CERRADA"
        oListEstado.Add(oEstado)

        Return oListEstado
    End Function

    Public Function ListarTipoFecha() As List(Of beEstadoEmb)
        Dim oListTipoFecha As New List(Of beEstadoEmb)
        Dim obeTipoFecha As beEstadoEmb
        obeTipoFecha = New beEstadoEmb
        obeTipoFecha.COD = "_DFECREA"
        obeTipoFecha.TEX = "Fecha Real"
        oListTipoFecha.Add(obeTipoFecha)

        obeTipoFecha = New beEstadoEmb
        obeTipoFecha.COD = "_DFECEST"
        obeTipoFecha.TEX = "Fecha Estimada"
        oListTipoFecha.Add(obeTipoFecha)

        Return oListTipoFecha
    End Function
End Class
