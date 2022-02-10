'CSR-HUNDRED-feature/151116_Combustibles-INICIO

Imports SOLMIN_ST.DATOS

Public Class Combustible_BLL


    Public Function ListaReporteCombustible(ByVal objCombustible As ENTIDADES.Combustible_BE) As DataTable
        Dim CombustibleDA As New Combustible_DAL
        Return CombustibleDA.ListaReporteCombustible(objCombustible)
    End Function


    Public Function ListaReporteCombustible_V2(ByVal objParametro As ENTIDADES.Combustible_BE) As DataSet
        Dim ds As New DataSet
        Dim dtLiq As New DataTable
        Dim dtVale As New DataTable
        Dim dtOp As New DataTable
        Dim CombustibleDA As New Combustible_DAL
        ds = CombustibleDA.ListaReporteCombustible_V2(objParametro)
        Return ds
        'dtLiq = ds.Tables(0).Copy
        'dtVale = ds.Tables(1).Copy
        'dtOp = ds.Tables(2).Copy


    End Function
End Class

'CSR-HUNDRED-feature/151116_Combustibles-FIN