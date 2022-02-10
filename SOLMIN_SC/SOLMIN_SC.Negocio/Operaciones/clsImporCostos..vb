Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad

Public Class clsImporCostos
    Public Function ListarCabeceraDUAA(ByVal oDUAA As beDUAA) As beDUAA
        Dim oda As New Datos.clsImporCostos()
        Return oda.ListarCabeceraDUAA(oDUAA)
    End Function
    Public Function ListarDetalleDUAA(ByVal oDUAA As beDUAA) As List(Of beDUAA1)
        Dim oda As New Datos.clsImporCostos()
        Dim ods As New DataSet
        Dim oListbeDUAA1 As New List(Of beDUAA1)
        oListbeDUAA1 = oda.ListarDetalleDUAA(oDUAA)
        Return oListbeDUAA1
    End Function
    Public Function ListarCheckPointAgencia(ByVal NORDSR As String, ByVal ZONA As String) As DataTable
        Dim oda As New Datos.clsImporCostos()
        Return oda.ListarCheckPointAgencia(NORDSR, ZONA)
    End Function

End Class
