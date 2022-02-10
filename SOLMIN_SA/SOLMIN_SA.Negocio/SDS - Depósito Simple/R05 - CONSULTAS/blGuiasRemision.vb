Imports RANSA.TypeDef
Imports RANSA.DATA
Public Class brGuiasRemision

    Public Function fnListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
        Return New daGuiasRemision().fnListGuiasRemision(obeFiltroGuia)
    End Function

#Region "AT"

    Public Function fnSelDetalleGuiaAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
        Return New daGuiasRemision().fnSelDetalleGuiaAT(obeFiltroGuia)
    End Function

    'Public Function fnSelObservacionGR(ByVal ht As Hashtable) As List(Of beGuiaRemision)
    '    Return New daGuiasRemision().fnSelObservacionGR(ht)
    'End Function
#End Region

#Region "DS"
    Public Function fnSelDetalleGuiaDS(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
        Return New daGuiasRemision().fnSelDetalleGuiaDS(obeFiltroGuia)
    End Function

    Public Function fnSelObservacionGR(ByVal ht As Hashtable) As List(Of beGuiaRemision)
        Return New daGuiasRemision().fnSelObservacionGR(ht)
    End Function

    ''' <summary>
    ''' Anula Guia de Remision de Depósito simple
    ''' </summary>
    ''' <param name="obeFiltroGuia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AnularGuiaDeRemisionDSD(ByVal obeFiltroGuia As beGuiaRemision) As Integer
        Return New daGuiasRemision().AnularGuiaDeRemisionDSD(obeFiltroGuia)
    End Function

    ''' <summary>
    ''' Elimina fisicamente  la Guia de Remision de Depósito simple
    ''' </summary>
    ''' <param name="obeFiltroGuia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EliminarGuiaDeRemisionDSD(ByVal obeFiltroGuia As beGuiaRemision) As Integer
        Return New daGuiasRemision().EliminarGuiaDeRemisionDSD(obeFiltroGuia)
    End Function

#End Region
End Class
