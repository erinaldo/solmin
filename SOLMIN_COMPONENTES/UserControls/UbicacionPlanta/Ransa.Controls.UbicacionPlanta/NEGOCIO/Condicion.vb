'Imports Ransa.TypeDef.UbicacionPlanta.Condicion
'Imports Ransa.DAO.UbicacionPlanta.Condicion
Imports System.ComponentModel

Namespace Condicion
    Public Class brCondicion
        Private odaoCondicion As New daoCondicion

        Public Function Lista_Condicion(ByVal Valor As String) As List(Of beCondicion)
            Return odaoCondicion.Lista_Condicion(Valor)
        End Function
    End Class
End Namespace
