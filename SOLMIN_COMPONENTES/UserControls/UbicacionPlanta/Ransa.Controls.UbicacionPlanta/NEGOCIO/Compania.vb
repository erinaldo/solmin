'Imports Ransa.TypeDef.UbicacionPlanta.Compania
'Imports Ransa.DAO.UbicacionPlanta.Compania
Imports System.ComponentModel

Namespace Compania


    ''' <summary>
    ''' Regla de Negocios de Compania
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Class brCompania

        Private odaoCompania As New daoCompania

        ''' <summary>
        ''' Lista de Compañias por Usuario
        ''' </summary>
        ''' 
        ''' <remarks></remarks>
        Public Function Lista_Compania_X_Usuario(ByVal strUsuario As String) As List(Of beCompania)
            Return odaoCompania.Lista_Compania_X_Usuario(strUsuario)
        End Function

    End Class
End Namespace
