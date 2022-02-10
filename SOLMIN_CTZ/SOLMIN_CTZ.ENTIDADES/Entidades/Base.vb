Imports System.Reflection

Public Class Base(Of T)

    ''' <summary>
    ''' Inicializa Propiedades 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Sub InicializeProperty(ByVal obj As T)
        Try
            Dim Propiedad As PropertyInfo
            Dim Propiedades() As PropertyInfo = obj.GetType.GetProperties()
            For Each Propiedad In Propiedades
                If Propiedad.CanWrite Then
                    Dim Valor As Object = Propiedad.PropertyType.ToString
                    Select Case Valor
                        Case "System.String"
                            Propiedad.SetValue(obj, "", Nothing)
                        Case "System.Int8", "System.Int16", "System.Int64", "System.Int32"
                            Propiedad.SetValue(obj, 0, Nothing)
                        Case "System.Decimal"
                            Propiedad.SetValue(obj, 0D, Nothing)
                        Case "System.DateTime"
                            Propiedad.SetValue(obj, #12:00:00 AM#, Nothing)
                        Case "System.Boolean" '
                            Propiedad.SetValue(obj, False, Nothing)
                        Case Else
                            Propiedad.SetValue(obj, "", Nothing)
                    End Select
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private _PageSize As Integer
    Public Property PageSize() As Integer
        Get
            Return _PageSize
        End Get
        Set(ByVal value As Integer)
            _PageSize = value
        End Set
    End Property


    Private _PageCount As Integer
    Public Property PageCount() As Integer
        Get
            Return _PageCount
        End Get
        Set(ByVal value As Integer)
            _PageCount = value
        End Set
    End Property


    Private _PageNumber As Integer
    Public Property PageNumber() As Integer
        Get
            Return _PageNumber
        End Get
        Set(ByVal value As Integer)
            _PageNumber = value
        End Set
    End Property


    Private _PSERROR As String
    Public Property PSERROR() As String
        Get
            Return _PSERROR
        End Get
        Set(ByVal value As String)
            _PSERROR = value
        End Set
    End Property


    Private _PSUSUARIO As String
    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property


    Private _PNNGUIRN As Decimal
    Public Property PNNGUIRN() As Decimal
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property

    Public Sub New()
        Me._PageSize = 0
        Me.PageCount = 0
        Me.PageNumber = 0

        'Dim Propiedad As PropertyInfo
        'Dim Propiedades() As PropertyInfo = T.GetType.GetProperties()
        'For Each Propiedad In Propiedades
        '    Dim Valor As Object = Propiedad.PropertyType.ToString
        '    Select Case Valor
        '        Case "System.String"
        '            Propiedad.SetValue(T, "", Nothing)
        '        Case "System.Int8", "System.Int16", "System.Int32", "System.Decimal"
        '            Propiedad.SetValue(T, 0, Nothing)
        '        Case "System.DateTime"
        '            Propiedad.SetValue(T, #12:00:00 AM#, Nothing)
        '    End Select
        'Next

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CtypeDate(ByVal obj As Object) As Decimal
        Dim objDate As New Date
        If obj.Equals("") = True Then
            Return 0
        Else
            objDate = obj
        End If
        Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)
    End Function

    ''' <summary>
    ''' Convierte número de ocho yyyymmdd digitos a cadena en formato (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="oFecha">Número en formato yyyymmdd</param>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    Public Function NumeroAFecha(ByVal oFecha As Object) As String
        If oFecha = 0 Then Return ""

        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""

        y = Left(oFecha.ToString(), 4)
        m = Right(Left(oFecha.ToString(), 6), 2)
        d = Right(oFecha.ToString(), 2)
        Return d & "/" & m & "/" & y
    End Function




End Class

Public Class beList(Of T As Base(Of T))
    Inherits List(Of T)

    Private _PageCount As Int32
    Public Property PageCount() As Int32
        Get
            Return _PageCount
        End Get
        Set(ByVal value As Int32)
            _PageCount = value
        End Set
    End Property

End Class