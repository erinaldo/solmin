'Imports Ransa.TypeDef.UbicacionPlanta.TipoMaterial
'Imports Ransa.DAO.UbicacionPlanta.TipoMaterial
Imports System.ComponentModel

Namespace TipoMaterial
    Public Class brTipoMaterial
        Private odaoTipoMaterial As New daoTipoMaterial

        Public Function Lista_TipoMaterial(ByVal Valor As String) As List(Of beTipoMaterial)
            Return odaoTipoMaterial.Lista_TipoMaterial(Valor)
        End Function
    End Class
End Namespace
