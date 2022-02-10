Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Namespace mantenimientos
    Public Class Viajes_Cliente_BL
 
        Public Function Insertar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Dim oDatos As New Viajes_Cliente_DAL
            Return oDatos.Insertar_Viaje_Cliente(obe_Viajes_Cliente)
        End Function


        Public Function Listar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As List(Of Viajes_Cliente)
            Dim oDatos As New Viajes_Cliente_DAL
            Return oDatos.Listar_Viaje_Cliente(obe_Viajes_Cliente)
        End Function


        Public Function Listar_MedioTransporte(ByVal strTipo As String, ByVal strCompañia As String) As DataTable
            Dim oDatos As New Viajes_Cliente_DAL
            Dim oDt As New DataTable
            Dim oDr As DataRow
            oDr = oDt.NewRow
            oDt = oDatos.Listar_MedioTransporte(strCompañia)
            If oDt.Rows.Count > 0 Then
                oDr = oDt.NewRow
                oDr(0) = "0"
                oDr(1) = strTipo
                oDt.Rows.InsertAt(oDr, 0)
            End If
            Return oDt
        End Function


        Public Function Eliminar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Dim oDatos As New Viajes_Cliente_DAL
            Return oDatos.Eliminar_Viaje_Cliente(obe_Viajes_Cliente)
        End Function

        Public Function Actualizar_Viaje_Cliente(ByVal obe_Viajes_Cliente As Viajes_Cliente) As Integer
            Dim oDatos As New Viajes_Cliente_DAL
            Return oDatos.Actualizar_Viaje_Cliente(obe_Viajes_Cliente)
        End Function
    End Class
End Namespace