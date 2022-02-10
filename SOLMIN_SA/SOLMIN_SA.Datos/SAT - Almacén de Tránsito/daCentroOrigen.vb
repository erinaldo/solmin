Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daCentroOrigen 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)
    Private sqlManager As New SqlManager

    Private _pValidarCentroOrigen As beInputValidarCentroOrigen

    ''' <summary>
    ''' Parametro pedido traslado por bulto
    ''' </summary>
    Public Property pCentroOrigen() As beInputValidarCentroOrigen
        Get
            Return _pValidarCentroOrigen
        End Get
        Set(ByVal value As beInputValidarCentroOrigen)
            _pValidarCentroOrigen = value
        End Set
    End Property

    Public Function ValidarIngresoCentroOrigen() As DataTable
        Dim output As New DataTable("output")
        Try
            Dim parameter As New Parameter
            parameter.Add("PARAM_CCLNT", pCentroOrigen.Cclnt)
            parameter.Add("PARAM_NORCML", pCentroOrigen.Norcml)
            parameter.Add("PARAM_ITEM", pCentroOrigen.Item)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_SA_VALIDA_INGRESO_CENTRO_ORIGEN", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output

    End Function

End Class
