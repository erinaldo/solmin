Imports SOLMIN_ST.ENTIDADES.Consultas
Imports SOLMIN_ST.DATOS.Consultas

Namespace Consultas
    Public Class AtributosOI_BLL

        Public Function DevolverTipoSap(ByVal tipoSAP As String) As List(Of AtributosOI)

            Dim dal As New AtributosOI_DAL

            Return dal.DevolverTipoSap(tipoSAP)

        End Function

    End Class
End Namespace

