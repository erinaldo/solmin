Imports Ransa.TypeDef
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DATA

Public Class brBase(Of T As beBase(Of T), D As {daBase(Of T), New})
    Protected oData As D

    Public Sub New()
        oData = New D
    End Sub

    Public Function Listar() As List(Of T)
        Return oData.Listar()
    End Function

    Public Function Listar(ByVal ParamArray params As Object()) As List(Of T)
        Return oData.Listar(params)
    End Function

    Public Function ListarReporte(ByVal ParamArray params As Object()) As DataTable
        Return oData.ListarReporte(params)
    End Function



    Public Function Insertar(ByVal obj As T) As Boolean
        Return oData.Insertar(obj)
    End Function

    Public Function Update(ByVal obj As T) As Boolean
        Return oData.Update(obj)
    End Function

    Public Function Delete(ByVal obj As T) As Boolean
        Return oData.Delete(obj)
    End Function

    Public Function Delete(ByVal ParamArray parameters As Object())
        Return oData.Delete(parameters)
    End Function




End Class
