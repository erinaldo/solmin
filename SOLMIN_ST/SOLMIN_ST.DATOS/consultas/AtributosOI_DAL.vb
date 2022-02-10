Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Consultas

Namespace Consultas

    Public Class AtributosOI_DAL
        Private objSql As New SqlManager

        Public Function DevolverTipoSap(ByVal tipoSAP As String) As List(Of AtributosOI)

            Dim objParam As New Parameter
            Dim Lista As New List(Of AtributosOI)

            Try
                Dim tabla As New DataTable
                tabla = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_DATOS_ADIC_ATRIBUTOS_OI", objParam)
                For Each Fila As DataRow In tabla.Rows

                    Dim Entidad As New AtributosOI()
                    Entidad.Codigo = Fila("CODIGO").ToString().Trim
                    Entidad.Descripcion = Fila("DESCIPCION").ToString().Trim
                    Entidad.Tipo = Fila("TIPO").ToString().Trim()

                    If Entidad.Tipo = tipoSAP Then
                        Lista.Add(Entidad)
                    End If
                Next

            Catch ex As Exception
                Throw
            End Try

            Return Lista

        End Function

    End Class


End Namespace
