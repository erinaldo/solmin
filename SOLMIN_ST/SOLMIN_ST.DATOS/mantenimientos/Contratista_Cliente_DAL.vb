Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Namespace mantenimientos

    Public Class Contratista_Cliente_DAL
        Private objSql As New SqlManager
        Public Function Insertar_Contratista_Cliente(ByVal obe_Contratista_Cliente As Contratista_Cliente) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Contratista_Cliente.PNCPRVCL)
                objParam.Add("PSCCMPN", obe_Contratista_Cliente.PSCCMPN)
                objParam.Add("PNNDIART", obe_Contratista_Cliente.PNNDIART)
                objParam.Add("PSSESTRG", obe_Contratista_Cliente.PSSESTRG)
                objParam.Add("PSCUSCRT", obe_Contratista_Cliente.PSCUSCRT)
                objParam.Add("PNFCHCRT", obe_Contratista_Cliente.PNFCHCRT)
                objParam.Add("PNHRACRT", obe_Contratista_Cliente.PNHRACRT)
                objParam.Add("PSNTRMCR", obe_Contratista_Cliente.PSNTRMCR)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONTRATISTA_CLIENTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Actualizar_Contratista_Cliente(ByVal obe_Contratista_Cliente As Contratista_Cliente) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Contratista_Cliente.PNCPRVCL)
                objParam.Add("PSCCMPN", obe_Contratista_Cliente.PSCCMPN)
                objParam.Add("PNNDIART", obe_Contratista_Cliente.PNNDIART)
                objParam.Add("PSCULUSA", obe_Contratista_Cliente.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Contratista_Cliente.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Contratista_Cliente.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Contratista_Cliente.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_CONTRATISTA_CLIENTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function ListarContratistaFiltro(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
            Dim oDt As New DataTable
            Dim olbeContratista_Cliente As New List(Of Contratista_Cliente)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONTRATISTA_FILTRO", objParam)
                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Contratista_Cliente
                    objEntidad.PSTPRVCL = objDataRow("TPRVCL").ToString.Trim
                    objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                    olbeContratista_Cliente.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbeContratista_Cliente
        End Function
      
        Public Function Listar_Contratista_Cliente(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
            Dim oDt As New DataTable
            Dim olbeContratista_Cliente As New List(Of Contratista_Cliente)
            Dim objParam As New Parameter
            Try

                objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)
                objParam.Add("PSCCMPN", obe_Contratista_Cliente.PSCCMPN)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONTRATISTA_CLIENTE", objParam)
                For Each objDataRow As DataRow In oDt.Rows
                    Dim objEntidad As New Contratista_Cliente

                    objEntidad.PNCCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.PSTCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
                    objEntidad.PSCCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.PNNDIART = objDataRow("NDIART").ToString.Trim
                    objEntidad.PSSESTRG = objDataRow("SESTRG").ToString.Trim
                    objEntidad.PSTPRVCL = objDataRow("TPRVCL").ToString.Trim
                    objEntidad.PNNRUCPR = objDataRow("NRUCPR").ToString.Trim
                    objEntidad.PSTDRPRC = objDataRow("TDRPRC").ToString.Trim
                    objEntidad.PSTNROFX = objDataRow("TNROFX").ToString.Trim
                    objEntidad.PSTLFNO1 = objDataRow("TLFNO1").ToString.Trim
                    objEntidad.PSTEMAI2 = objDataRow("TEMAI2").ToString.Trim
                    objEntidad.PNCANTPERSONAL = objDataRow("CANTPERSONAL").ToString.Trim
                    olbeContratista_Cliente.Add(objEntidad)
                Next
            Catch ex As Exception
            End Try
            Return olbeContratista_Cliente
        End Function

        Public Function Eliminar_Contratista_Cliente(ByVal obe_Contratista_Cliente As Contratista_Cliente) As Integer
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)
                objParam.Add("PNCPRVCL", obe_Contratista_Cliente.PNCPRVCL)
                objParam.Add("PSSESTRG", obe_Contratista_Cliente.PSSESTRG)
                objParam.Add("PSCULUSA", obe_Contratista_Cliente.PSCULUSA)
                objParam.Add("PNFULTAC", obe_Contratista_Cliente.PNFULTAC)
                objParam.Add("PNHULTAC", obe_Contratista_Cliente.PNHULTAC)
                objParam.Add("PSNTRMNL", obe_Contratista_Cliente.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CONTRATISTA_CLIENTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

    Public Function Listar_Contratista_Cliente_Pasajero(ByVal obe_Contratista_Cliente As Contratista_Cliente) As List(Of Contratista_Cliente)
      Dim oDt As New DataTable
      Dim olbeContratista_Cliente As New List(Of Contratista_Cliente)
      Dim objParam As New Parameter
      Try
        objParam.Add("PNCCLNT", obe_Contratista_Cliente.PNCCLNT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obe_Contratista_Cliente.PSCCMPN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CONTRATISTA_CLIENTE_PASAJERO", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          Dim objEntidad As New Contratista_Cliente
          objEntidad.PSTPRVCL = objDataRow("TPRVCL").ToString.Trim
          objEntidad.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
          olbeContratista_Cliente.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return olbeContratista_Cliente
    End Function

    End Class
End Namespace