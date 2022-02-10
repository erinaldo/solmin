Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.ENTIDADES.mantenimientos


Namespace mantenimientos

    Public Class ServicioCotizacion_DAL

        Private objSql As New SqlManager

        Public Function Listar_Servicio_Cotizacion_DropDownList(ByVal objentidad As ServicioCotizacion) As DataTable
            Dim objResultado As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_CCMPN", objentidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objentidad.CDVSN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objentidad.CCMPN)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_SERVICIOS_COTIZACION", objParam)
                'Agrega Fila de Display Neutral
                Dim dr As DataRow = objResultado.NewRow
                dr("CSRVNV") = "0"
                dr("TCMTRF") = "--- Escoja Elemento ---"
                'Agrega la fila al datatable
                objResultado.Rows.InsertAt(dr, 0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Listar_Servicio_Cotizacion(ByVal objentidad As ServicioCotizacion) As DataTable
            Dim objResultado As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_CCMPN", objentidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objentidad.CDVSN)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objentidad.CCMPN)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_COTIZACION", objParam)
            Catch ex As Exception
            End Try
            Return objResultado
        End Function

    End Class

End Namespace