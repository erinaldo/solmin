'Imports Ransa.TypeDef.UbicacionPlanta.Division
'Imports Ransa.DAO.UbicacionPlanta.Division

Namespace Division

    Public Class brDivision

        Private odaoDivision As daoDivision
        Private ldblCodCompania As String
        Private oldaoDivision As List(Of beDivision) = Nothing

        Sub New()
            odaoDivision = New daoDivision
        End Sub

        Property Lista()
            Get
                Return oldaoDivision
            End Get
            Set(ByVal value)
                oldaoDivision = value
            End Set
        End Property

        Public Function Lista_Division_X_Usuario_X_Planta(ByVal pdblCodCompania As String) As List(Of Ransa.Controls.UbicacionPlanta.Division.beDivision)
            ldblCodCompania = pdblCodCompania
            ' oldaoDivision.FindAll(match_Total)
            Return oldaoDivision.FindAll(match_Total)
        End Function

        Private match_Total As New Predicate(Of beDivision)(AddressOf Busca_Total)

        Public Function Busca_Total(ByVal pbeDivision As beDivision) As Boolean
            If (pbeDivision.CCMPN_CodigoCompania = ldblCodCompania) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Lista_Division_X_Usuario(ByVal strUsuario As String)
            oldaoDivision = odaoDivision.Lista_Division_X_Usuario(strUsuario)
        End Sub

        Public Function Lista_Division_X_Usuario_Y_Compania(ByVal strUsuario As String, ByVal pdblCodCompania As String) As DataTable
            Dim dt As DataTable
            dt = odaoDivision.Lista_Division_X_Usuario_Y_Compania(strUsuario, pdblCodCompania)
            Return dt
        End Function








    End Class

End Namespace

