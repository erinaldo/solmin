'Imports Ransa.DATA
Imports Ransa.TypeDef


Public Class daSerie

    Inherits daBase(Of beSerie)


    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_SDS_LISTAR_SERIES"
        SPUpdate = "SP_SOLMIN_SA_SDS_UPDATE_SERIES"
        SPInsert = "SP_SOLMIN_SA_SDS_INSERT_SERIES"
        SPDelete = ""
    End Sub

    'Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beSerie)
    Public Overrides Sub ToParameters(ByVal obj As beSerie)

        SetParameter(obj.PNNORDSR)
        SetParameter(obj.PSCSRECL)
        SetParameter(obj.PNNCRPLL)
        SetParameter(obj.PNCCLNT)
        SetParameter(obj.PSTDSMDL)
        SetParameter(obj.PNFINGAL)
        SetParameter(obj.PNHINGAL)
        SetParameter(obj.PNFSLDAL)
        SetParameter(obj.PNHSLDAL)
        SetParameter(obj.PSTOBSRV)
        SetParameter(obj.PNNGUIIN)
        SetParameter(obj.PNNGUISL)
        SetParameter(obj.PNNGUIRM)
        SetParameter(obj.PSSTPING)
        SetParameter(obj.PSSSTINV)
        SetParameter(obj.PNFCHCRT)
        SetParameter(obj.PNHRACRT)
        SetParameter(obj.PSCUSCRT)
        SetParameter(obj.PSCULUSA)
        SetParameter(obj.PNFULTAC)
        SetParameter(obj.PNHULTAC)
        SetParameter(obj.PSSESTRG)
        SetParameter(obj.PNUPDATE_IDENT)
        SetParameter(obj.PNNRITOC)
    End Sub
End Class
