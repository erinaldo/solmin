Imports System.Reflection

Public Class Base_BE(Of T)

    ''' <summary>
    ''' Inicializa Propiedades 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Sub InicializeProperty(ByVal obj As T)
        Dim Propiedad As PropertyInfo
        Dim Propiedades() As PropertyInfo = obj.GetType.GetProperties()
        For Each Propiedad In Propiedades
            Dim Valor As Object = Propiedad.PropertyType.ToString
            Select Case Valor
                Case "System.String"
                    Propiedad.SetValue(obj, "", Nothing)
                Case "System.Int8", "System.Int16", "System.Int32"
                    Propiedad.SetValue(obj, 0, Nothing)
                Case "System.Decimal"
                    Propiedad.SetValue(obj, 0D, Nothing)
                Case "System.DateTime"
                    Propiedad.SetValue(obj, #12:00:00 AM#, Nothing)
            End Select
        Next
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


    Private _PSUSUARIO As String
    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
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


    Public Sub New()
        Me._PageSize = 0
        Me.PageCount = 0
        Me.PageNumber = 0
    End Sub

    Public Function HoraNum_a_Hora(ByVal oHora As Object) As String
        Dim Hora As String = ("" & oHora).ToString.Trim
        Dim h As String = ""
        Dim m As String = ""
        Dim s As String = ""
        If Hora.ToString.Trim.Length < 6 Then
            Hora = "0" & Hora
        End If
        h = Left(Hora, 2).PadLeft(2, "0")
        m = Right(Left(Hora, 4), 2).PadLeft(2, "0")
        s = Right(Hora, 2).PadLeft(2, "0")
        Return h + ":" + m + ":" + s
    End Function


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
    Public Function CtypeDate(ByVal obj As Object) As Decimal
        Dim objDate As New Date
        If ("" & obj & "").Equals("") = True Then
            Return 0
        Else
            objDate = obj
        End If
        Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)
    End Function

    Public Function ConvertHoraNumeric(ByVal Hora As String) As String
        If Hora.Length < 6 Then
            Return "0"
        End If
        Dim lstr_hora As String = Hora.Trim.Substring(0, 2) & Hora.Trim.Substring(3, 2) & Hora.Trim.Substring(6, 2)
        If IsNumeric(lstr_hora) Then
            Return lstr_hora
        Else
            Return "0"
        End If
    End Function

End Class

Public Class beList(Of T As Base_BE(Of T))
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