Imports SOLMIN_ST.DATOS
Imports System.Data
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Public Class Localidad_BLL

    Private objDatos As New Localidad_DAL

    Public Function Listar_Localidades_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Localidades_Combo(strCompania)
    End Function


    Public Function Listar_Localidades(ByVal strCompania As String) As List(Of LocalidadRuta)
        Return objDatos.Listar_Localidades(strCompania)
    End Function




    Public Function Listar_Localidades_Combo_Todos(ByVal strCompania As String) As DataTable
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDt = objDatos.Listar_Localidades_Combo(strCompania)
        If oDt.Rows.Count > 0 Then
            oDr = oDt.NewRow
            oDr(0) = "0"
            oDr(1) = "TODOS"
            oDt.Rows.InsertAt(oDr, 0)
        End If
        Return oDt
    End Function
End Class
