'Imports Ransa.TypeDef.UbicacionPlanta.Planta
'Imports Ransa.DAO.UbicacionPlanta.Planta

Namespace Planta

    Public Class brPlanta
        Private odaoPlanta As daoPlanta
        Private olbePlanta As List(Of bePlanta)
        Private ldblCodCompania As String
        Private ldblCodDivision As String

        Sub New()
            odaoPlanta = New daoPlanta
        End Sub

        Property Lista()
            Get
                Return olbePlanta
            End Get
            Set(ByVal value)
                olbePlanta = value
            End Set
        End Property

        Public Function Lista_Planta_X_Usuario(ByVal pdblCodCompania As String, ByVal pdblCodDivision As String) As List(Of bePlanta)
            ldblCodCompania = pdblCodCompania
            ldblCodDivision = pdblCodDivision
            'olbePlanta.FindAll(match_Compania_Division)
            Return olbePlanta.FindAll(match_Compania_Division)
        End Function

        Public Function Lista_Planta_X_Usuario_All(ByVal pdblCodCompania As String) As List(Of bePlanta)
            ldblCodCompania = pdblCodCompania
            Return olbePlanta.FindAll(match_Compania_Division)
        End Function


        Private match_Compania_Division As New Predicate(Of bePlanta)(AddressOf Buscar_Compania_Division)
        Private match_Compania As New Predicate(Of bePlanta)(AddressOf Buscar_Compania)

        Public Function Buscar_Compania_Division(ByVal pbePlanta As bePlanta) As Boolean
            If (pbePlanta.CCMPN_CodigoCompania = ldblCodCompania) And (pbePlanta.CDVSN_CodigoDivision = ldblCodDivision) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Buscar_Compania(ByVal pbePlanta As bePlanta) As Boolean
            If (pbePlanta.CCMPN_CodigoCompania = ldblCodCompania) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Crea_Lista(ByVal strUsuario As String)
            olbePlanta = odaoPlanta.Lista_Planta_X_Usuario(strUsuario)
        End Sub

        Public Sub Crea_Lista_All(ByVal strUsuario As String)
            olbePlanta = odaoPlanta.Lista_Planta_X_Usuario_All(strUsuario)
        End Sub

        Public Function Lista_Planta_X_Nombre(ByVal strPlanta As String) As Integer
            Return odaoPlanta.Lista_Planta_X_Nombre(strPlanta)
        End Function

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

End Namespace
