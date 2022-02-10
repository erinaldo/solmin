Imports RANSA.TypeDef
Imports RANSA.DATA.DespachoDSD
Namespace DespachoSDS

    Public Class brGuiasRemision
        Public Function fnListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision, ByRef PageCount As Decimal) As List(Of beGuiaRemision)
            Return New DATA.DespachoSAT.daGuiasRemision().fnListGuiasRemision(obeFiltroGuia, PageCount)
        End Function

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
        ''' 
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

        Public Function fboolExisteGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Return New daGuiasRemision().fboolExisteGuiaRemision(obeFiltroGuia)
        End Function

        Public Function fboolExisteGuiaRemision_S(ByVal obeFiltroGuia As beGuiaRemision) As Int64
            Return New daGuiasRemision().fboolExisteGuiaRemision_S(obeFiltroGuia)
        End Function


        Public Function fObtenerMaxInferiorGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As beGuiaRemision
            Return New daGuiasRemision().fObtenerMaxInferiorGuiaRemision(obeFiltroGuia)
        End Function

      

    End Class
End Namespace

