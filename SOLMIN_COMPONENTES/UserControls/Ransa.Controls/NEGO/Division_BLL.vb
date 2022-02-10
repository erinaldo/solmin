

Public Class Division_BLL
    Private oDivisionDato As Division_DAL
    Private ldblCodCompania As String
    Private oDt As List(Of ClaseGeneral)

    Sub New()
        oDivisionDato = New Division_DAL
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Division(ByVal pdblCodCompania As String) As List(Of ClaseGeneral)
        ldblCodCompania = pdblCodCompania
        'oDt.FindAll(match_Total)

        Return oDt.FindAll(match_Total)
    End Function

    Private match_Total As New Predicate(Of ClaseGeneral)(AddressOf Busca_Total)

    Public Function Busca_Total(ByVal RolOpcionBE As ClaseGeneral) As Boolean
        If (RolOpcionBE.CCMPN = ldblCodCompania) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub Crea_Lista(Optional ByVal strCompania As String = "EZ")
        oDt = oDivisionDato.Lista_Division_X_Usuario(strCompania)
    End Sub
End Class
