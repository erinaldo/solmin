Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class clsPreDocum_BLL
    Private oPreDoc As New clsPreDocum_DAL
    Public Function ListarPLDocumentosCh(ByVal obePreDocum As PreDocum_BE) As DataTable
        Dim objtemporal As New PreDocum_BE
        objtemporal = obePreDocum
        Return oPreDoc.ListarPLDocumentosS(objtemporal)

    End Function

    

End Class
