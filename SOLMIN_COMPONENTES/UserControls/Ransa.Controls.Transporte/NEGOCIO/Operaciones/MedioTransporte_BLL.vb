Public Class MedioTransporte_BLL
    Private objMedioTrasporte As New MedioTransporte_DAL

    Public Function Lista_Medio_Transporte(Optional ByVal intTipo As Integer = 0) As List(Of MedioTransporte)
        Dim objListaMedioTransporte As New List(Of MedioTransporte)
        Dim objListaMedio As New List(Of MedioTransporte)
        objListaMedioTransporte = objMedioTrasporte.Lista_Medio_Transporte()
        If intTipo = 0 Then
            Return objListaMedioTransporte
        Else
            Dim objEntidad As New MedioTransporte
            objEntidad.CTPMDT = 0
            objEntidad.TTPMDT = "Todos"
            objListaMedio.Add(objEntidad)
            objListaMedio.AddRange(objListaMedioTransporte)
            Return objListaMedio
        End If
    End Function

    Public Function Lista_MedioTrasnporteTabla(ByVal strCompania As String) As DataTable
        Return objMedioTrasporte.Lista_MedioTrasnporteTabla(strCompania)
    End Function


End Class
