Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsContrato
    Private oContratoDato As SOLMIN_CTZ.DATOS.clsContrato
    Private oDt As DataTable

    Sub New()
        oContratoDato = New SOLMIN_CTZ.DATOS.clsContrato
    End Sub

    ReadOnly Property Lista_Contratos() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    Public Function floListaContrato(ByVal pobjContrato As Contrato, ByRef dtContrato_Clientes As DataTable) As List(Of Contrato)
        Return oContratoDato.floListaContrato(pobjContrato, dtContrato_Clientes)
    End Function

    ''' <summary>
    ''' Lista de Clientes por contrato
    ''' </summary>
    ''' <param name="pobjContrato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flisCargarClienteXContrato(ByVal pobjContrato As Contrato) As List(Of Contrato)
        Return oContratoDato.flisCargarClienteXContrato(pobjContrato)
    End Function

    Public Sub EliminarClienteXContrato(ByVal pobjContrato As Contrato)
        oContratoDato.EliminarClienteXContrato(pobjContrato)
    End Sub

    ''' <summary>
    ''' Insertar Cliente x Contrato
    ''' </summary>
    ''' <param name="pobjlisContrato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fIntInsertarClienteXContrato(ByVal pobjlisContrato As List(Of Contrato)) As Integer
        For Each objContrato As Contrato In pobjlisContrato
            If oContratoDato.fIntInsertarClienteXContrato(objContrato) = -1 Then
                Return -1
            End If
        Next
        Return 1
    End Function

    Public Function Cargar_Datos_Contrato(ByVal pobjContrato As Contrato) As Contrato
        Return oContratoDato.Cargar_Datos_Contrato(pobjContrato)
    End Function

    Public Function fIntCrearContrato(ByVal pobjContrato As Contrato) As Integer

        Return oContratoDato.fIntCrearContrato(pobjContrato)

    End Function

    Public Sub Actualizar_Datos_Contrato(ByVal pobjContrato As Contrato)
        Try
            oContratoDato.Actualizar_Datos_Contrato(pobjContrato)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function fintEliminarContrato(ByVal pobjContrato As Contrato) As Integer
        Try
            Return oContratoDato.fintEliminarContrato(pobjContrato)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Grabar_Observacion(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Contrato As Bitacora_Contrato)
        Try
            oContratoDato.Grabar_Observacion(oSqlMan, pobjBitacora_Contrato)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_Observaciones(ByRef oSqlMan As SqlManager, ByVal pobjContrato As Contrato)
        Try
            oContratoDato.Eliminar_Observaciones(oSqlMan, pobjContrato)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Observacion_Cliente(ByVal pobjContrato As Contrato) As DataTable
        Return oContratoDato.Lista_Observacion_Cliente(pobjContrato)
    End Function

    Public Function Lista_IndicadorVentaMensual(ByVal pobjFiltro As Contrato) As DataTable
        Return oContratoDato.Lista_IndicadorVentaMensual(pobjFiltro)
    End Function
    Public Function fdtListaIndicadorVentaMensualGeneral(ByVal pobjFiltro As Contrato) As DataTable
        Return oContratoDato.fdtListaIndicadorVentaMensualGeneral(pobjFiltro)
    End Function


End Class
