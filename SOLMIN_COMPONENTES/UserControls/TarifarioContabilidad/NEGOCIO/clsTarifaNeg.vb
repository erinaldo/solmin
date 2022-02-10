Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class clsTarifaNeg
    Private oTarifaDato As clsTarifa
    Private oDt As DataTable

    Sub New()
        oTarifaDato = New clsTarifa
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Lista_Tarifa_X_Contrato(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Tarifa_X_Contrato(pobjTarifa)
    End Function

    Public Sub Eliminar_Tarifa(ByVal pobjTarifa As Tarifa)
        Try
            oTarifaDato.Eliminar_Tarifa(pobjTarifa)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Crear_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)
        Try
            oTarifaDato.Crear_Tarifa(oSqlMan, pobjTarifa, pobjRango)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)
        Try
            oTarifaDato.Actualizar_Tarifa(oSqlMan, pobjTarifa, pobjRango)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Tarifa_Servicio(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Tarifa_Servicio(pobjTarifa)
    End Function
End Class
