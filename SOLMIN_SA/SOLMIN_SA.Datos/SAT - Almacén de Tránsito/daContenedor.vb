Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF


Public Class daContenedor
    Inherits daBase(Of beContenedor)

    Private objSql As New SqlManager

#Region "Mantenimiento de Contenedores"

    Public Function InsertarContenedor(ByVal obeContenedor As beContenedor) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
            objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
            objParam.Add("PSCPRPCN", obeContenedor.PSCPRPCN)
            objParam.Add("PSNSRECN", obeContenedor.PSNSRECN)
            objParam.Add("PSCMTRCN", obeContenedor.PSCMTRCN)
            objParam.Add("PSCDMNCN", obeContenedor.PSCDMNCN)
            objParam.Add("PSCCLOR", obeContenedor.PSCCLOR)
            objParam.Add("PSCTPOC1", obeContenedor.PSCTPOC1)
            objParam.Add("PNQTRACN", obeContenedor.PNQTRACN)
            objParam.Add("PNQPSMXC", obeContenedor.PNQPSMXC)
            objParam.Add("PNQCPCBC", obeContenedor.PNQCPCBC)
            objParam.Add("PNFFACCN", obeContenedor.PNFFACCN)
            objParam.Add("PNFINCSC", obeContenedor.PNFINCSC)
            objParam.Add("PSTOBSCN", obeContenedor.PSTOBSCN)
            objParam.Add("PSSESCN1", obeContenedor.PSSESCN1)
            objParam.Add("PSCUSCRT", obeContenedor.PSCUSCRT)        
            objParam.Add("PSNTRMNL", obeContenedor.PSNTRMNL.ToUpper)


            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_CONTENEDOR_INSERT", objParam)

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ActualizarContenedor(ByVal obeContenedor As beContenedor) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
            objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
            objParam.Add("PSCPRPCN", obeContenedor.PSCPRPCN)
            objParam.Add("PSNSRECN", obeContenedor.PSNSRECN)
            objParam.Add("PSCMTRCN", obeContenedor.PSCMTRCN)
            objParam.Add("PSCDMNCN", obeContenedor.PSCDMNCN)
            objParam.Add("PSCCLOR", obeContenedor.PSCCLOR)
            objParam.Add("PSCTPOC1", obeContenedor.PSCTPOC1)
            objParam.Add("PNQTRACN", obeContenedor.PNQTRACN)
            objParam.Add("PNQPSMXC", obeContenedor.PNQPSMXC)
            objParam.Add("PNQCPCBC", obeContenedor.PNQCPCBC)
            objParam.Add("PNFFACCN", obeContenedor.PNFFACCN)
            objParam.Add("PNFINCSC", obeContenedor.PNFINCSC)
            objParam.Add("PSTOBSCN", obeContenedor.PSTOBSCN)
            objParam.Add("PSSESCN1", obeContenedor.PSSESCN1)

            objParam.Add("PSCULUSA", obeContenedor.PSCUSCRT)

            objParam.Add("PSSESTRG", obeContenedor.PSSESTRG)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_CONTENEDOR_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarContenedor(ByVal obeContenedor As beContenedor) As List(Of beContenedor)
        Dim oDt As New DataTable
        Dim olbebeContenedor As New List(Of beContenedor)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
        objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
        objParam.Add("PSCPRPCN", obeContenedor.PSCPRPCN)
        objParam.Add("PSNSRECN", obeContenedor.PSNSRECN)
        objParam.Add("PSSESCN1", obeContenedor.PSSESCN1)
        Return Listar("SP_SOLMIN_SA_SAT_CONTENEDOR_LIST", objParam)
        'Catch ex As Exception
        'End Try
        'Return olbebeContenedor
    End Function

    Public Function dtListarContenedor(ByVal obeContenedor As beContenedor) As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
            objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
            objParam.Add("PSCPRPCN", obeContenedor.PSCPRPCN)
            objParam.Add("PSNSRECN", obeContenedor.PSNSRECN)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_BUSCAR_CONTENEDOR_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function
#End Region

#Region "Datos Adicionales al Contenedor"
    Public Function dtListaColorContenedor() As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_COLOR_CNT_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function dtListaMaterialContenedor() As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_MATERIAL_CNT_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function dtListaTipoContenedor() As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_TIPO_CNT_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function


    Public Function ValidaMovimiento(ByVal obeContenedor As beContenedor) As Integer
        Try
            Dim objParam As New Parameter
            Dim nRetorno As Integer = 0
            objParam.Add("PNREG", 0, ParameterDirection.Output)
            objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
            objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
            objParam.Add("PSCPRPCN", obeContenedor.PSCPRPCN)
            objParam.Add("PSNSRECN", obeContenedor.PSNSRECN)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SAT_MOVIMIENTO_CNT_LIST", objParam)
            nRetorno = Convert.ToInt32(objParam.Item(1).Value)

            Return nRetorno
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function dtListaReporteContenedores(ByVal obeContenedor As beContenedor) As DataSet
        Dim oDt As New DataTable
        Dim olbebeContenedor As New List(Of beContenedor)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeContenedor.PSCCMPN)
            objParam.Add("PSCDVSN", obeContenedor.PSCDVSN)
            objParam.Add("PNCCLNT", obeContenedor.PNCCLNT)
            objParam.Add("PNFREFFW", obeContenedor.PNFREFFW)
            objParam.Add("PNFSLFFW", obeContenedor.PNFSLFFW)

            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_SAT_CONTENEDOR_REPORTE", objParam)

        Catch ex As Exception
            Return New DataSet
        End Try

    End Function

#End Region



    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beContenedor)

    End Sub

End Class