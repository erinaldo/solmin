'Isaias
Imports System.Windows.Forms
Imports System.Reflection

Public Class beBase(Of T)

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
                        Case "System.Double"
                            Propiedad.SetValue(obj, 0, Nothing)
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




    Private _PSNTRMNL As String
    'Eloy
    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property


    Private _PSCUSCRT As String
    Public Property PSCUSCRT() As String
        Get
            Return _PSCUSCRT
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property

    Private _PSCULUSA As String
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property


    Private _PSSESTRG As String
    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property

    Private _PSNTRMCR As String
    Public Property PSNTRMCR() As String
        Get
            Return _PSNTRMCR
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
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
        If ("" & obj & "").Equals("") = True Then
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

    Public Function NumeroAHora(ByVal oHora As Object) As String
        If oHora = 0 Then Return ""

        Dim h As String = ""
        Dim m As String = ""
        Dim s As String = ""

        'h = oHora.ToString.Substring(0, 2)

        'If CInt(h) < 24 Then
        '    If CInt(oHora.ToString.Substring(2, 2)) = 0 Then
        '        m = oHora.ToString.Substring(2, 2)
        '    End If 
        'End If

        h = Left(oHora.ToString(), 2)
        m = Right(Left(oHora.ToString(), 4), 2)
        s = Right(oHora.ToString(), 2)
        If h <= 24 Then
            Return h & ":" & m & ":" & s
        Else
            Return "00" & ":" & "00" & ":" & "00"
        End If

    End Function

    Public Function Decimal_Hora(ByVal oHora As Decimal) As String
        Dim Resultado As String = ""
        Dim s As Int32
        Dim h As Int32
        Dim m As Int32
        Select Case (oHora.ToString.Length)
            Case 6
                h = Int32.Parse(oHora.ToString.Substring(0, 2))
                m = Int32.Parse(oHora.ToString.Substring(2, 2))
                s = Int32.Parse(oHora.ToString.Substring(4, 2))
                If (m.ToString.Length > 1) Then
                    If (s.ToString.Length > 1) Then
                        Resultado = String.Format("{0}:{1}:{2}", h, m, s)
                    Else
                        Resultado = String.Format("{0}:{1}:0{2}", h, m, s)
                    End If
                ElseIf (s.ToString.Length > 1) Then
                    Resultado = String.Format("{0}:0{1}:{2}", h, m, s)
                Else
                    Resultado = String.Format("{0}:0{1}:0{2}", h, m, s)
                End If
            Case 5
                h = Int32.Parse(oHora.ToString.Substring(0, 1))
                m = Int32.Parse(oHora.ToString.Substring(1, 2))
                s = Int32.Parse(oHora.ToString.Substring(3, 2))
                If (m.ToString.Length > 1) Then
                    If (s.ToString.Length > 1) Then
                        Resultado = String.Format("0{0}:{1}:{2}", h, m, s)
                    Else
                        Resultado = String.Format("0{0}:{1}:0{2}", h, m, s)
                    End If
                ElseIf (s.ToString.Length > 1) Then
                    Resultado = String.Format("0{0}:0{1}:{2}", h, m, s)
                Else
                    Resultado = String.Format("0{0}:0{1}:0{2}", h, m, s)
                End If
            Case 4
                h = Int32.Parse(oHora.ToString.Substring(0, 2))
                Resultado = String.Format("{0}:00:00", h)
            Case 3
                h = Int32.Parse(oHora.ToString.Substring(0, 1))
                Resultado = String.Format("0{0}:00:00", h)
        End Select
        Return Resultado
    End Function

    Public Function Hora_Decimal(ByVal oHora As String) As Decimal

        Dim resultado As Decimal = 0
        Dim texto As String = ""

        If CInt((oHora.Substring(0, 2)) > 24) Then
            Return 0
            Exit Function
        End If
        If CInt((oHora.Substring(3, 2)) > 59) Then
            Return 0
            Exit Function
        End If
        If CInt((oHora.Substring(6, 2)) > 59) Then
            Return 0
            Exit Function
        End If

        texto = String.Format("{0}{1}{2}", oHora.Substring(0, 2), oHora.Substring(3, 2), oHora.Substring(6, 2))
        resultado = CDec(texto.ToString())

        Return resultado

    End Function



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CtypeHour(ByVal obj As Object) As Decimal
        Dim objHour As New Date
        If ("" & obj & "").Equals("") = True OrElse Not IsDate(obj) Then
            Return 0
        Else
            Dim h As String = ""
            h = Left(obj.ToString(), 2)
            If h <= 24 Then
                objHour = obj

                Return objHour.Hour & objHour.Minute & objHour.Second
            Else
                Return 0
            End If

        End If

        'Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)
    End Function

End Class

Public Class beList(Of T As beBase(Of T))
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