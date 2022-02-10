Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsClaseOrden
    Private oClaseOrdenDato As SOLMIN_CTZ.DATOS.clsClaseOrden
    Private oDt As DataTable

    Sub New()
        oClaseOrdenDato = New SOLMIN_CTZ.DATOS.clsClaseOrden
    End Sub

    ReadOnly Property Lista_ClaseOrden() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    Public Function ListaClaseOrden(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oClaseOrdenDato.Lista_ClaseOrden(pobjOrdenesInternas)
    End Function

    Public Function Datos_ClaseOrden(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oClaseOrdenDato.Datos_ClaseOrden(pobjOrdenesInternas)
    End Function

End Class
