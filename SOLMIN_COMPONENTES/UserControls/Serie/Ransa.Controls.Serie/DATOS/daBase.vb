Imports System.Reflection
Imports Ransa.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario

Public MustInherit Class daBase(Of T As beBase(Of T))

    Private propertyinfo As Dictionary(Of String, PropertyInfo)

    Protected SPListar As String
    Protected SPInsert As String
    Protected SPUpdate As String
    Protected SPDelete As String

    Private PageCount As Integer

    Private oPaginador As UCPaginacion

    Public Sub New()
        Try
            propertyinfo = New Dictionary(Of String, PropertyInfo)
            For Each info As PropertyInfo In GetType(T).GetProperties()
                propertyinfo.Add(info.Name.Substring(2).ToUpper(), info)
            Next
            SetStoredprocedures()
        Catch ex As Exception

        End Try
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
                    If params.Item(params.Count).ParameterName = "PAGECOUNT" Then
                        PageCount = Convert.ToInt32(params.Item(params.Count).Value)
                        If oPaginador IsNot Nothing Then oPaginador.PageCount = PageCount
                    End If
                End If
            Catch ex As Exception
                dt = Nothing
                strMensajeError = "Error producido en la funcion : <<  >> de la clase <<  >> " & Environment.NewLine & _
                                  "Proceso : <<  >> " & Environment.NewLine & _
                                  "Motivo del Error : " & ex.Message
                Throw New Exception(strMensajeError)
            End Try
        End Using
        Return dt
    End Function

    Private Function CreateObjectsFromDataTable(ByVal table As DataTable) As beList(Of T)

        Dim oLista As beList(Of T) = New beList(Of T)
        Dim strMensajeError As String = String.Empty
        'If Not String.IsNullOrEmpty(Me.PageCount) Then oLista.PageCount = Me.PageCount
        Try
            For Each row As DataRow In table.Rows
                Dim obj As T = Activator.CreateInstance(Of T)()

                For Each col As DataColumn In table.Columns
                    Dim val As Object = row(col)
                    If val IsNot System.DBNull.Value Then
                        'Propiedad.PropertyType.ToString()

                        If propertyinfo.ContainsKey(col.ColumnName.ToUpper()) Then
                            If propertyinfo(col.ColumnName).PropertyType.FullName = "System.String" Then
                                propertyinfo(col.ColumnName).SetValue(obj, val.ToString.Trim, Nothing)
                            Else
                                propertyinfo(col.ColumnName).SetValue(obj, val, Nothing)
                            End If

                        End If
                    End If
                Next
                obj.PageCount = Me.PageCount
                oLista.Add(obj)
            Next
        Catch ex As Exception
            oLista.Clear()
            strMensajeError = "Error producido en la funcion : <<  >> de la clase <<  >> " & Environment.NewLine & _
                              "Proceso : <<  >> " & Environment.NewLine & _
                              "Motivo del Error : " & ex.Message
            Throw New Exception(strMensajeError)
        End Try

        Return oLista
    End Function
    Private Function CreateParameters(ByVal ParamArray params As Object()) As Parameter
        objParametros = New Parameter
        oPaginador = Nothing
        If params IsNot Nothing Then
            Dim j As Integer
            For i As Integer = 0 To params.GetUpperBound(0)
                Dim objValor As Object
                objValor = params.GetValue(i)

                If TypeOf objValor Is Parameter Then
                    objParametros = objValor
                    Exit For
                End If

                If TypeOf objValor Is UCPaginacion Then
                    objParametros.Add("PAGESIZE", CType(objValor, UCPaginacion).PageSize)
                    objParametros.Add("PAGENUMBER", CType(objValor, UCPaginacion).PageNumber)
                    objParametros.Add("PAGECOUNT", 0, ParameterDirection.Output)
                    oPaginador = objValor
                Else
                    objParametros.Add("@P" & (i + 1).ToString(), objValor)
                    j = i
                End If
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

    Public Function ListarColeccion(ByVal SQL As String, ByVal ParamArray params As Object()) As beList(Of T)
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
