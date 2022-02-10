Imports Ransa.TypeDef
Public Class brGeneral_BL


    Public Function ListaLotesDeEntrega(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New brGeneral_DAL().ListaLotesDeEntrega(obeGeneral)
    End Function

    Public Function bolElClienteEsOutotec(ByVal intCCLNT As Integer) As Boolean
        Dim obeParam As New beGeneral
        Dim odaGeneral As New brGeneral_DAL
        obeParam.PSCODVAR = "CLIOUT"
        obeParam.PSCCMPRN = intCCLNT.ToString
        If odaGeneral.ListaTablaAyuda(obeParam).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function olLugarOrigen(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "FLGPEN"
        obeParam.PSCCMPRN = strTipoMov
        Return New brGeneral_DAL().ListaTablaAyuda(obeParam)
    End Function


    Public Function ListaMedioTransporte(ByVal opbeGeneral As beGeneral) As List(Of beGeneral)
        Return New brGeneral_DAL().ListaMedioTransporte(opbeGeneral)
    End Function

    Public Function LotesDeEntregaXCliente(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New brGeneral_DAL().LotesDeEntregaXCliente(obeGeneral)
    End Function

    Public Function olTipoOrigen(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TIPORG"
        Return New brGeneral_DAL().ListaTablaAyuda(obeParam)
    End Function

End Class
