

Public Class Planta_BLL
    Private oPlantaDato As Planta_DAL
    Private oDt As List(Of mantenimientos.ClaseGeneral)
    Private ldblCodCompania As String
    Private ldblCodDivision As String

    Sub New()
        oPlantaDato = New Planta_DAL
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Planta(ByVal pdblCodCompania As String, ByVal pdblCodDivision As String) As List(Of mantenimientos.ClaseGeneral)
        ldblCodCompania = pdblCodCompania
        ldblCodDivision = pdblCodDivision
        'oDt.FindAll(match_Total)
        Return oDt.FindAll(match_Total)
    End Function

    Private match_Total As New Predicate(Of mantenimientos.ClaseGeneral)(AddressOf Busca_Total)

    Public Function Busca_Total(ByVal RolOpcionBE As mantenimientos.ClaseGeneral) As Boolean
        If (RolOpcionBE.CCMPN = ldblCodCompania) And (RolOpcionBE.CDVSN = ldblCodDivision) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Crea_Lista(Optional ByVal strCompania As String = "EZ")
        oDt = oPlantaDato.Lista_Planta_X_Usuario(strCompania)
    End Sub

    Private Function Validar(ByVal pstrPlanta As String, ByVal poDt As DataTable) As Boolean
        Dim intCont As Integer

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("CPLNDV").ToString = pstrPlanta Then
                Return False
            End If
        Next intCont
        Return True
    End Function
End Class
