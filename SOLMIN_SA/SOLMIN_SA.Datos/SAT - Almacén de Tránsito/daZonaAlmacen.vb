Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daZonaAlmacen
    Inherits daBase(Of beZonaAlmacen)

    Private objSql As New SqlManager

    Public Function listar_Zona_Almacen(ByVal obeZonaAlmacen As beZonaAlmacen) As List(Of beZonaAlmacen)
        Dim lstbeZonaAlmacen As New List(Of beZonaAlmacen)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCTPALM", obeZonaAlmacen.PSCTPALM)
            objParam.Add("PSCALMC", obeZonaAlmacen.PSCALMC)
            Return Listar("SP_SOLMIN_SA_SAT_LISTAR_ZONA_ALMACEN", objParam)
        Catch ex As Exception
        End Try
        Return lstbeZonaAlmacen
    End Function
    Public Function mantenimiento_zona_almacem(ByVal obeZonaAlmacen As beZonaAlmacen, ByVal tipo As Integer) As Short
        Dim objParam As New Parameter
        Dim result As Short = 1
        Try
            objParam.Add("PSCTPALM", obeZonaAlmacen.PSCTPALM)
            objParam.Add("PSCALMC", obeZonaAlmacen.PSCALMC)
            objParam.Add("PSCZNALM", obeZonaAlmacen.PSCZNALM)
            objParam.Add("PSTCMZNA", obeZonaAlmacen.PSTCMZNA)
            objParam.Add("PSTABZNA", obeZonaAlmacen.PSTABZNA)
            objParam.Add("PNQARMTS", obeZonaAlmacen.PNQARMTS)
            objParam.Add("PSSDISAT", obeZonaAlmacen.PSSDISAT)
            objParam.Add("PSUSUARIO", obeZonaAlmacen.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeZonaAlmacen.PSNTRMNL)
            objParam.Add("PNTIPO", tipo)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_MANT_ZONA_ALMACEN", objParam)
        Catch ex As Exception
            result = 0
        End Try
        Return result
    End Function
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beZonaAlmacen)

    End Sub
End Class
