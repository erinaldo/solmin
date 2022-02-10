Public Class clsUsuario
    Private strCompania As String = "EZ"
    Private strNomCompania As String = "RANSA COMERCIAL S.A."
    Private strDivision As String = "S"
    Private strNomDivision As String = "SIL IMPORTACION"

    Property Compania()
        Get
            Return Me.strCompania
        End Get
        Set(ByVal value)
            Me.strCompania = value
        End Set
    End Property

    Property NomCompania()
        Get
            Return Me.strNomCompania
        End Get
        Set(ByVal value)
            Me.strNomCompania = value
        End Set
    End Property

    Property Division()
        Get
            Return Me.strDivision
        End Get
        Set(ByVal value)
            Me.strDivision = value
        End Set
    End Property

    Property NomDivision()
        Get
            Return Me.strNomDivision
        End Get
        Set(ByVal value)
            Me.strNomDivision = value
        End Set
    End Property
End Class

