Imports System.Text
Imports System.Xml
Public Class clsAscinsa
    Public Function ExtraerCabeceraAscinsa(ByVal PNNMOS As String, ByVal PSCMDTR As String) As DataTable
        Dim obrAscinsa As New ascinsa.ransa.asp.WsSolminSil
        Dim ds As New DataSet
        Dim odt As New DataTable
        Dim xml_data As String
        xml_data = obrAscinsa.ConsultaOrdenServicioCabecera(PNNMOS, PSCMDTR)
        Dim sr As New System.IO.StringReader(xml_data)
        ds.ReadXml(sr)
        If ds.Tables.Count > 0 Then
            odt = ds.Tables(0).Copy
        End If
        Return odt
    End Function
    Public Function ExtraerDetalleItemAscinsa(ByVal PNNMOS As String, ByVal PSCMDTR As String) As DataTable
        Dim obrAscinsa As New ascinsa.ransa.asp.WsSolminSil
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim xml_data As String
        xml_data = obrAscinsa.ConsultaOrdenServicioDetalle(PNNMOS, PSCMDTR)
        Dim sr As New System.IO.StringReader(xml_data)
        ds.ReadXml(sr)
        If ds.Tables.Count > 0 Then
            dt = ds.Tables(0).Copy
        End If
        Return dt
    End Function

End Class
