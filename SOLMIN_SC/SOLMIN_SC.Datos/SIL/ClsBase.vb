Imports System.Reflection
Public Class ClsBase
    Private Shared propertyinfo As Dictionary(Of String, PropertyInfo)
    Public Shared Function TableToObject(Of T)(ByVal table As DataTable) As List(Of T)
        Dim tipo As String = ""
        Dim oLista As List(Of T) = New List(Of T)
        For Each row As DataRow In table.Rows
            Dim obj As T = Activator.CreateInstance(Of T)()
            propertyinfo = New Dictionary(Of String, PropertyInfo)
            For Each info As PropertyInfo In GetType(T).GetProperties()
                propertyinfo.Add(info.Name.ToString.ToUpper, info)
            Next
            For Each col As DataColumn In table.Columns
                Dim val As Object = row(col)
                If val IsNot System.DBNull.Value Then
                    If propertyinfo.ContainsKey(col.ColumnName.ToUpper()) Then
                        'Tipo de dato de la propiedad
                        tipo = propertyinfo(col.ColumnName).PropertyType.FullName.ToString()
                        Select Case tipo
                            Case "System.String"
                                propertyinfo(col.ColumnName).SetValue(obj, val.ToString.Trim, Nothing)
                            Case "System.Decimal"
                                propertyinfo(col.ColumnName).SetValue(obj, Convert.ToDecimal(val), Nothing)
                            Case "System.Int8", "System.Int16", "System.Int32"
                                propertyinfo(col.ColumnName).SetValue(obj, Convert.ToInt32(val), Nothing)
                            Case "System.DateTime"
                                propertyinfo(col.ColumnName).SetValue(obj, DirectCast(val, System.DateTime), Nothing)
                        End Select
                    End If
                End If
            Next
            oLista.Add(obj)
        Next
        Return oLista
    End Function
   
End Class
