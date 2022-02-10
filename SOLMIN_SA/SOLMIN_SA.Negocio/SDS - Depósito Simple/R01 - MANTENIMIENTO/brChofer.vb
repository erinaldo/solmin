Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA

Namespace slnSOLMIN_SDS
    
    Public Class brChofer
        Dim objDAChofer As New daChofer
#Region "AT"

        Public Function InsertarChoferAT(ByVal obeChofer As beChofer) As Integer
            Return objDAChofer.InsertarChoferAT(obeChofer)
        End Function
        Public Function ActualizarChoferAT(ByVal obeChofer As beChofer) As Integer
            Return objDAChofer.ActualizarChoferAT(obeChofer)
        End Function
        'Public Function ListarChoferAT(ByVal obeChofer As beChofer) As List(Of beChofer)
        '    Return objDAChofer.ListarChoferAT(obeChofer)
        'End Function
        'Public Function EliminarChoferAT(ByVal obeChofer As beChofer) As Integer
        '    Return objDAChofer.EliminarChoferAT(obeChofer)
        'End Function

#End Region

#Region "DS"
        Public Function SeleccionarChoferDS(ByVal strPlaca As String, ByVal dblCodTransportista As String) As beChofer
            Return objDAChofer.SeleccionarChoferDS(strPlaca, dblCodTransportista)
        End Function

        Public Function InsertarChoferDS(ByVal objBEChofer As beChofer) As Integer
            Return objDAChofer.SP_SOLMIN_SA_INS_CHOFER(objBEChofer)
        End Function

        Public Function ActualizarChoferDS(ByVal objBEChofer As beChofer) As Boolean
            Return objDAChofer.SP_SOLMIN_SA_UPD_CHOFER(objBEChofer)
        End Function

        ''' <summary>
        ''' Lista todos los choferes paginado
        ''' </summary>
        ''' <param name="obeFiltroChofer"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListarChoferxTransportista(ByVal obeFiltroChofer As beChoferFiltro) As List(Of beChofer)
            Return objDAChofer.ListarChoferxTransportista(obeFiltroChofer)
        End Function
        ''' <summary>
        ''' Lista los choferes sin paginar
        ''' </summary>
        ''' <param name="obeFiltroChofer"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function flstListarChoferesxTransportista(ByVal obeFiltroChofer As beChoferFiltro) As List(Of beChofer)
            Return objDAChofer.flstListarChoferesxTransportista(obeFiltroChofer)
        End Function

#Region "Mantenimiento AT"

        Public Function ListarChoferxTransportista_AT(ByVal obeFiltroChofer As beChofer) As List(Of beChofer)
            Return objDAChofer.ListarChoferxTransportista_AT(obeFiltroChofer)
        End Function


        Public Function SP_SOLMIN_SA_SEL_CHOFER_AT(ByVal CBRCNT As String, ByVal CTRSPT As String) As beChofer
            Return objDAChofer.SP_SOLMIN_SA_SEL_CHOFER_AT(CBRCNT, CTRSPT)
        End Function


        Public Function SP_SOLMIN_SA_UPD_CHOFER_AT(ByVal objBEChofer As beChofer) As Boolean
            Return objDAChofer.SP_SOLMIN_SA_UPD_CHOFER_AT(objBEChofer)
        End Function


        Public Function SP_SOLMIN_SA_INS_CHOFER_AT(ByVal objBEChofer As beChofer) As Integer
            Return objDAChofer.SP_SOLMIN_SA_INS_CHOFER_AT(objBEChofer)
        End Function

        Public Function EliminarChoferAT(ByVal obeChofer As beChofer) As Integer
            Return objDAChofer.EliminarChoferAT(obeChofer)
        End Function

#End Region

        Public Function EliminarChofer(ByVal obeChofer As beChofer) As Integer
            Return objDAChofer.EliminarChofer(obeChofer)
        End Function
#End Region

    End Class
End Namespace