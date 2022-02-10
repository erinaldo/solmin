Imports System.Reflection
Public Class Almacen_Info_BE
    Public Sub New()
        Inicilizar()
    End Sub
    Private Sub Inicilizar()
        Dim Propiedades() As PropertyInfo = Me.GetType.GetProperties()
        For Each Propiedad As PropertyInfo In Propiedades
            Dim Valor As Object = Propiedad.PropertyType.ToString
            Select Case Valor
                Case "System.String"
                    Propiedad.SetValue(Me, "", Nothing)
                Case "System.Int8", "System.Int16", "System.Int32", "System.Int64"
                    Propiedad.SetValue(Me, 0, Nothing)
                Case "System.Decimal", "System.Double"
                    Propiedad.SetValue(Me, 0D, Nothing)
                Case "System.DateTime"
                    Propiedad.SetValue(Me, #12:00:00 AM#, Nothing)
            End Select
        Next
    End Sub

    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCTPALM_CALMC As String
    Private _PSTCMPAL As String
    Private _PSBUSQUEDA As String

    Private _PageSize As Integer
    Private _PageCount As Integer
    Private _PageNumber As Integer
    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property
    Public Property PSCTPALM_CALMC() As String
        Get
            Return (_PSCTPALM_CALMC)
        End Get
        Set(ByVal value As String)
            _PSCTPALM_CALMC = value
        End Set
    End Property
    Public Property PSTCMPAL() As String
        Get
            Return (_PSTCMPAL)
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property

    Public Property PSBUSQUEDA() As String
        Get
            Return (_PSBUSQUEDA)
        End Get
        Set(ByVal value As String)
            _PSBUSQUEDA = value
        End Set
    End Property



    Public Property PageSize() As Integer
        Get
            Return _PageSize
        End Get
        Set(ByVal value As Integer)
            _PageSize = value
        End Set
    End Property



    Public Property PageCount() As Integer
        Get
            Return _PageCount
        End Get
        Set(ByVal value As Integer)
            _PageCount = value
        End Set
    End Property



    Public Property PageNumber() As Integer
        Get
            Return _PageNumber
        End Get
        Set(ByVal value As Integer)
            _PageNumber = value
        End Set
    End Property


    Public Sub pClear()
        Inicilizar()
    End Sub

End Class
