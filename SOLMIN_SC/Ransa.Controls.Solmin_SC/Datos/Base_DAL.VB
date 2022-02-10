Imports System.Reflection
Imports Db2Manager.RansaData.iSeries.DataObjects
Public MustInherit Class Base_DAL(Of T As Base_BE)

    Private propertyinfo As Dictionary(Of String, PropertyInfo)

    Protected SPListar As String
    Protected SPInsert As String
    Protected SPUpdate As String
    Protected SPDelete As String

    Private PageCount As Integer


    Public Sub New()
        propertyinfo = New Dictionary(Of String, PropertyInfo)
        For Each info As PropertyInfo In GetType(T).GetProperties()
            propertyinfo.Add(info.Name.Substring(2).ToUpper(), info)
        Next
        SetStoredprocedures()
    End Sub

    Private Function GetLista(ByVal sql As String, ByVal params As Parameter) As beList(Of T)
        Return CreateObjectsFromDataTable(CreateDataTable(sql, params))
    End Function

    Private Function CreateDataTable(ByVal sql As String, Optional ByVal params As Parameter = Nothing) As DataTable

        Dim dt As New DataTable
        Dim strMensajeError As String

        Using objsqlmanager As SqlManager = New SqlManager
            Try
                dt = objsqlmanager.ExecuteDataTable(sql, params)
                PageCount = -1
                If params.Count > 0 Then
                    If params.Item(params.Count).ParameterName.ToString.ToUpper = "PAGECOUNT" Then
                        PageCount = Convert.ToInt32(params.Item(params.Count).Value)
                    End If
                End If
            Catch ex As Exception
                dt = Nothing
                strMensajeError = "Error producido en la funcion : <<  >> de la clase <<  >> " & Environment.NewLine & _
                                  "Proceso : <<  >> " & Environment.NewLine & _
                                  "Motivo del Error : " & ex.Message
            End Try
        End Using
        Return dt
    End Function

    Private Function CreateObjectsFromDataTable(ByVal table As DataTable) As beList(Of T)
        Dim tipo As String = ""
        Dim oLista As beList(Of T) = New beList(Of T)
        'If Not String.IsNullOrEmpty(Me.PageCount) Then oLista.PageCount = Me.PageCount
        Try
            For Each row As DataRow In table.Rows
                Dim obj As T = Activator.CreateInstance(Of T)()

                For Each col As DataColumn In table.Columns
                    Dim val As Object = row(col)
                    If val IsNot System.DBNull.Value Then
                        tipo = val.GetType.FullName.ToString
                        Select Case tipo
                            Case "System.String"
                                val = val.ToString.Trim
                        End Select
                        If propertyinfo.ContainsKey(col.ColumnName.ToUpper()) Then
                            propertyinfo(col.ColumnName).SetValue(obj, val, Nothing)
                        End If
                    End If
                Next
                obj.PageCount = Me.PageCount
                oLista.Add(obj)
            Next
        Catch ex As Exception
        End Try
        Return oLista
    End Function
    Private Function CreateParameters(ByVal ParamArray params As Object()) As Parameter
        objParametros = New Parameter
        If params IsNot Nothing Then
            Dim j As Integer
            For i As Integer = 0 To params.GetUpperBound(0)
                Dim objValor As Object
                objValor = params.GetValue(i)

                If TypeOf objValor Is Parameter Then
                    objParametros = objValor
                    Exit For
                End If
                objParametros.Add("@P" & (i + 1).ToString(), objValor)
                j = i
            Next
        End If
        Return objParametros
    End Function
    Private nParameter As Int32
    Private objParametros As Parameter
    Private Sub InicializarParametros()
        nParameter = 0
        objParametros = New Parameter
    End Sub

    Protected Sub SetParameter(ByVal value As Object, ByVal orientation As ParameterDirection)
        nParameter += 1
        objParametros.Add("@P" & nParameter.ToString, value, orientation)
    End Sub

    Protected Sub SetParameter(ByVal value As Object)
        If value Is Nothing Then value = ""
        SetParameter(value, ParameterDirection.Input)
    End Sub

    Public Function Listar() As List(Of T)
        Return GetLista(SPListar, Nothing)
    End Function

    Public Function TraerDataTable(ByVal SQL As String, ByVal ParamArray params As Object()) As DataTable
        Return CreateDataTable(SQL, CreateParameters(params))
    End Function

    Public Function Listar(ByVal ParamArray params As Object()) As List(Of T)
        Return GetLista(SPListar, CreateParameters(params))
    End Function

    Public Function Listar(ByVal SQL As String, ByVal ParamArray params As Object()) As beList(Of T)
        Return GetLista(SQL, CreateParameters(params))
    End Function

    Public Function ListarReporte(ByVal ParamArray params As Object()) As DataTable
        Return CreateDataTable(SPListar, CreateParameters(params))
    End Function

    Public Function Insertar(ByVal obj As T) As Boolean
        InicializarParametros()
        Return ExecuteNonQuery(SPInsert, GetParameters(obj))
    End Function

    Public Function Update(ByVal obj As T)
        InicializarParametros()
        Return ExecuteNonQuery(SPUpdate, GetParameters(obj))
    End Function

    Public Function Delete(ByVal obj As T) As Boolean
        InicializarParametros()
        Return ExecuteNonQuery(SPDelete, GetParameters(obj))
    End Function

    Public Function Delete(ByVal ParamArray Parameters As Object()) As Boolean
        InicializarParametros()

        Return ExecuteNonQuery(SPDelete, CreateParameters(Parameters))
    End Function


    Public Function ExecuteNonQuery(ByVal sql As String, ByVal parameters As Parameter) As Boolean
        Dim bRetorno As Boolean = False
        Dim strMensajeError As String
        Using objsqlmanager As SqlManager = New SqlManager
            Try
                objsqlmanager.ExecuteNonQuery(sql, parameters)
                bRetorno = True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : <<  >> de la clase <<  >> " & Environment.NewLine & _
                                  "Proceso : <<  >> " & Environment.NewLine & _
                                  "Motivo del Error : " & ex.Message
            End Try
        End Using
        Return bRetorno
    End Function

    Private Function GetParameters(ByVal obj As T) As Parameter
        ToParameters(obj)
        Return objParametros
    End Function

    Public MustOverride Sub ToParameters(ByVal obj As T)

    Public MustOverride Sub SetStoredprocedures()

End Class