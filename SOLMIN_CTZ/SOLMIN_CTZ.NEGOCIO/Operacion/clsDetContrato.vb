Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsDetContrato
    Private oDetContratoDato As SOLMIN_CTZ.DATOS.clsDetContrato
    Private oDt As DataTable

    Sub New()
        oDetContratoDato = New SOLMIN_CTZ.DATOS.clsDetContrato
    End Sub

    ReadOnly Property Lista_Detalle_Contrato() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    'Public Sub Busca_Detalle_Contrato(ByVal pobjContrato As Contrato)
    '    oDt = oDetContratoDato.Lista_Detalle_Contrato(pobjContrato)
    'End Sub

    Public Sub Grabar_Observacion(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Detalle As SOLMIN_CTZ.DATOS.Bitacora_Detalle)
        Try
            oDetContratoDato.Grabar_Observacion(oSqlMan, pobjBitacora_Detalle)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_Observaciones(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Detalle As SOLMIN_CTZ.DATOS.Bitacora_Detalle)
        Try
            oDetContratoDato.Eliminar_Observaciones(oSqlMan, pobjBitacora_Detalle)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Observacion_Det_Contrato(ByVal pobjContrato As Contrato) As DataTable
        Return oDetContratoDato.Lista_Observacion_Det_Contrato(pobjContrato)
    End Function

    'Public Sub Agregar_Detalle_Contrato(ByRef oSqlMan As SqlManager, ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        oDetContratoDato.Agregar_Detalle_Contrato(oSqlMan, pobjDetContrato)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub Quitar_Detalle_Contrato(ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        oDetContratoDato.Quitar_Detalle_Contrato(pobjDetContrato)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub Actualizar_Vigencia_Detalle_Contrato(ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        oDetContratoDato.Actualizar_Vigencia_Detalle_Contrato(pobjDetContrato)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Function Lista_Detalle_Contrato_AS400_ALM(ByVal pobjFiltro As Filtro) As DataTable
        Return oDetContratoDato.Lista_Detalle_Contrato_AS400_ALM(pobjFiltro)
    End Function

    Public Function Lista_Detalle_Contrato_AS400_SIL(ByVal pobjFiltro As Filtro) As DataTable
        Return oDetContratoDato.Lista_Detalle_Contrato_AS400_SIL(pobjFiltro)
    End Function

    Public Function Lista_Detalle_Contrato_AS400_TRP(ByVal pobjFiltro As Filtro) As DataTable
        Return oDetContratoDato.Lista_Detalle_Contrato_AS400_TRP(pobjFiltro)
    End Function

End Class
