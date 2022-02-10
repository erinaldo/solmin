Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Namespace mantenimientos
    Public Class TransportistaAS400_DAL
        Private objSql As New SqlManager

        Public Function Registrar_TransportistaAS400(ByVal objEntidad As Transportista) As Transportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSTCMTRT", objEntidad.TCMTRT)
                objParam.Add("PSTABTRT", objEntidad.TABTRT)
                objParam.Add("PSTDRCTR", objEntidad.TDRCTR)
                objParam.Add("PSTLFTRP", objEntidad.TLFTRP)
                objParam.Add("PON_CTRSPT", objEntidad.CTRSPT, ParameterDirection.Output)
                objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
                objParam.Add("PSFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

                'ejecuta el procedimiento almacenado
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA_AS400", objParam)

                objEntidad.CTRSPT = objSql.ParameterCollection("PON_CTRSPT")

                If objEntidad.CTRSPT = "-1" Then
                    MsgBox("Ya existe un transportista AS400 con el RUC " & objEntidad.NRUCTR & ". Selecciónelo de la lista.", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                objEntidad.CTRSPT = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_TransportistaAS400(ByVal strCompania As String) As List(Of Transportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter

            'Try
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTAR_TRANSPORTISTAS", Nothing)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Transportista

                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function



        Public Function Listar_TransportistaAS400_RZTR10(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable
            Dim objDataTable As New DataTable
            Dim ds As New DataSet
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter



            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("OU_TOTPAG", 0)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_TR_LISTAR_TRANSPORTISTAS_RZTR10", objParam)
            objDataTable = ds.Tables(0)
            TOTPAG = 0
            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If



            Return objDataTable
        End Function


        Public Function Listar_TransportistaAS400_LIST_RZTR10(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As DataTable
            Dim objDataTable As New DataTable
            Dim ds As New DataSet
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter



            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("OU_TOTPAG", 0)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_TR_LISTAR_TRANSPORTISTAS_LIST_RZTR10", objParam)
            objDataTable = ds.Tables(0)
            TOTPAG = 0
            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If



            Return objDataTable
        End Function



    End Class

End Namespace