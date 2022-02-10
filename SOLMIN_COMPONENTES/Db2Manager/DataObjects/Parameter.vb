Imports System.Collections
Imports IBM.Data.DB2.iSeries

Namespace RansaData.iSeries.DataObjects

    Public Class Parameter

        Dim obj As New Collection

''' <summary>
'''  Pocedimiento que agrega a la colecci�n de parametros el nombre de un parametro
'''  y el valor asociado, no es necesario indicar el tipo de dato a ingresar.
''' </summary>
   


        Public Sub Add(ByVal ParameterName As String, ByVal ParameterValue As Object)
            obj.Add(New iDB2Parameter(ParameterName, ParameterValue), ParameterName)
        End Sub

        Public Sub Add(ByVal ParameterName As String, ByVal ParameterValue As Object, ByVal Orientation As ParameterDirection)
            Dim objParam As New iDB2Parameter(ParameterName, ParameterValue)
            objParam.Direction = Orientation
            obj.Add(objParam)
        End Sub

        Public Sub ParameterOrientation(ByVal ParameterName As String, ByVal Orientation As ParameterDirection)
            CType(obj.Item(ParameterName), iDB2Parameter).Direction = Orientation
        End Sub

''' <summary>
'''  Pocedimiento que elimina un objeto de la colecci�n de parametros en base a su posici�n
''' en dicha colecci�n de objetos
''' </summary>

        Public Sub Remove(ByVal Indice As Integer)
            obj.Remove(Indice)
        End Sub

''' <summary>
'''  Pocedimiento que elimina un objeto de la colecci�n de parametros en base al nombre del parametro
''' en dicha colecci�n de objetos
''' </summary>

        Public Sub Remove(ByVal ParameterName As String)
            obj.Remove(ParameterName)
        End Sub

''' <summary>
'''  Funci�n que devuelve el elementos IDb2Parameter de la colecci�n en base a su posici�n
''' </summary>

        Public ReadOnly Property Item(ByVal Indice As Integer) As iDB2Parameter
            Get
                Return obj.Item(Indice)
            End Get
        End Property


''' <summary>
'''  Funci�n que devuelve el elementos IDb2Parameter de la colecci�n en base a su nombre de parametro
''' </summary>


        Public ReadOnly Property Item(ByVal KeyValue As String) As iDB2Parameter
            Get
                Return obj.Item(KeyValue)
            End Get
        End Property

        Public ReadOnly Property ItemValue(ByVal KeyValue As String) As Object
            Get
                Return CType(obj.Item(KeyValue), IBM.Data.DB2.iSeries.iDB2Parameter).Value
            End Get
        End Property

        Public Function ParameterExist(ByVal KeyValue As String) As Boolean

            Dim lbool_exist As Boolean = False

            For i As Integer = 1 To obj.Count

                If CType(obj.Item(i), IBM.Data.DB2.iSeries.iDB2Parameter).ParameterName = KeyValue Then
                    lbool_exist = True
                End If

            Next

            Return lbool_exist

        End Function

''' <summary>
'''  Propiedad que devuelve el n�mero de elementos de la colecci�n
''' </summary>


        Public ReadOnly Property Count()
            Get
                Return obj.Count
            End Get

        End Property

        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
        Public Sub AddString(ByVal ParameterName As String, ByVal ParameterValue As String)
            obj.Add(New iDB2Parameter(ParameterName, ParameterValue), ParameterName)
        End Sub
        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN

    End Class
End Namespace
