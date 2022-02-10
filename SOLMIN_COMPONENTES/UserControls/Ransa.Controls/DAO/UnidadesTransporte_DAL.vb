Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class UnidadesTransporte_DAL

        Dim objSql As New SqlManager

        Public Function Listar_Unidad_Transporte_DropDownList() As DataTable
            Dim objResultado As New DataTable
            Try
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES_TRANSPORTE", Nothing)

                Dim dr As DataRow = objResultado.NewRow
                dr("CTPUNV") = "0"
                dr("TUNDVH") = "--- Escoja Elemento ---"

                objResultado.Rows.InsertAt(dr, 0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Listar_Unidad_Transporte_Combo(ByVal strCompania As String) As DataTable
            Dim objResultado As New DataTable
            Try
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES_TRANSPORTE", Nothing)
               
            Catch ex As Exception
            End Try
            Return objResultado
        End Function

    End Class

End Namespace