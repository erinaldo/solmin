Imports RANSA.TYPEDEF
Imports RANSA.DATA
Imports System.Text

Public Class CentroOrigen 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-001)
    Private _pValidarCentroOrigen As beInputValidarCentroOrigen

    ''' <summary>
    ''' Parametro pedido traslado por bulto
    ''' </summary>
    Public Property pCentroOrigen() As beInputValidarCentroOrigen
        Get
            Return _pValidarCentroOrigen
        End Get
        Set(ByVal value As beInputValidarCentroOrigen)
            _pValidarCentroOrigen = value
        End Set
    End Property

    Public Function ValidarIngreso() As String
        Dim output As New StringBuilder
        Try
            Dim centroOrigen As New daCentroOrigen
            centroOrigen.pCentroOrigen = pCentroOrigen

            For Each row As DataRow In centroOrigen.ValidarIngresoCentroOrigen().Rows
                If row("STATUS").ToString.Trim = "N" Then
                    output.AppendLine(row("OBSRESULT").ToString.Trim)
                End If
            Next row
        Catch ex As Exception
            output.AppendLine(String.Format("Ha ocurrido un error inesperado, {0}, por favor comuníquese con el administrador del sistema.", ex.Message))
        End Try

        Return output.ToString

    End Function

End Class
