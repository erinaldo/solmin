Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class TipoOperacion_DAL

        Private objSql As New SqlManager

        Public Function Listar_Tipos_Operacion() As DataTable
            Dim objResultado As New DataTable
            Try
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_TR_TIPO_OPERACION", Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function


        Public Function InsertaSeguimientoOperacion(ByVal ht As Hashtable) As Integer
            Try
                Dim lobjSql As New SqlManager
                Dim lobjParams As New Parameter

                lobjParams.Add("PNNOPRCN", ht.Item("PNNOPRCN"))
                lobjParams.Add("PSSESTTP", ht.Item("PSSESTTP"))
                lobjParams.Add("PNFDSGDC", ht.Item("PNFDSGDC"))
                lobjParams.Add("PNHDSGDC", ht.Item("PNHDSGDC"))
                lobjParams.Add("PSURSPDC", ht.Item("PSURSPDC"))
                lobjParams.Add("PSTOBSSG", ht.Item("PSTOBSSG"))
                lobjParams.Add("PSCUSCRT", ht.Item("PSCUSCRT"))
                lobjParams.Add("PSNTRMCR", ht.Item("PSNTRMCR"))
                lobjParams.Add("PNNRSGDC", ht.Item("PNNRSGDC"))

                lobjSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTA_CONTROL_OPERACIONES", lobjParams)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

    End Class


End Namespace