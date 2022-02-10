Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos


Namespace mantenimientos
  Public Class Grifos_DAL
    Private objSql As New SqlManager

        Public Function Registrar_Grifo(ByVal objEntidad As Grifo, ByRef IdGrifo As Decimal) As String
            ''Try
            'Dim IdGrifo As Decimal = 0
            Dim objParam As New Parameter
            Dim dt As New DataTable
            ' objParam.Add("PON_CGRFO", objEntidad.CGRFO, ParameterDirection.Output)
            objParam.Add("PSTGRFO", objEntidad.TGRFO)
            objParam.Add("PSTAGRFO", objEntidad.TAGRFO)
            'objParam.Add("PNNRUCGR", objEntidad.NRUCGR)
            objParam.Add("PNCUBGEO", objEntidad.CUBGEO)
            objParam.Add("PSTLCLGR", objEntidad.TLCLGR)

            objParam.Add("PSREFCNT", objEntidad.REFCNT)
            objParam.Add("PSDREGRF", objEntidad.DREGRF)
            objParam.Add("PNCPRVGR", objEntidad.CPRVGR)

            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)

            '.REFCNT = txtRefCarga.Text.Trim
            '.DREGRF = txtDireccion.Text.Trim
            '.CPRVGR = CType(cboGrifoProveedor.Resultado, Grifo).CPRVGR

            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_GRIFO", objParam)
            Dim msg As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim
            If msg = "" Then
                If dt.Rows.Count > 0 Then
                    IdGrifo = dt.Rows(0)("CGRFO")
                End If

            End If
            'objEntidad.CGRFO = objSql.ParameterCollection("PON_CGRFO")
            'Catch ex As Exception
            '          objEntidad.CGRFO = 0
            '      End Try
            '      Return objEntidad
            Return msg
        End Function

        Public Function Modificar_Grifo(ByVal objEntidad As Grifo) As String
            'Try
            Dim objParam As New Parameter
            Dim dt As New DataTable
            objParam.Add("PNCGRFO", objEntidad.CGRFO)
            objParam.Add("PSTGRFO", objEntidad.TGRFO)
            objParam.Add("PSTAGRFO", objEntidad.TAGRFO)
            objParam.Add("PNNRUCGR", objEntidad.NRUCGR)
            objParam.Add("PNCUBGEO", objEntidad.CUBGEO)
            objParam.Add("PSTLCLGR", objEntidad.TLCLGR)

            objParam.Add("PSREFCNT", objEntidad.REFCNT)
            objParam.Add("PSDREGRF", objEntidad.DREGRF)
            objParam.Add("PNCPRVGR", objEntidad.CPRVGR)

            'objParam.Add("PNFULTAC", objEntidad.FULTAC)
            'objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objSql.ExecuteDataTable("SP_SOLMIN_ST_MODIFICAR_GRIFO", objParam)

            Dim msg As String = ""
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim

            'Catch ex As Exception
            '          objEntidad.CGRFO = 0
            '      End Try
            '      Return objEntidad
            Return msg
        End Function

        Public Sub Eliminar_Grifo(ByVal objEntidad As Grifo)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCGRFO", objEntidad.CGRFO)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GRIFO", objParam)
            'Catch ex As Exception
            '          objEntidad.CGRFO = 0
            '      End Try
            '      Return objEntidad
        End Sub

        Public Function Listar_Grifos() As List(Of Grifo)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Grifo)
            Dim objDatos As Grifo

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GRIFOS", Nothing)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Grifo
                objDatos.CGRFO = objDataRow("CGRFO").ToString.Trim
                objDatos.TGRFO = objDataRow("TGRFO").ToString.Trim
                objDatos.TAGRFO = objDataRow("TAGRFO").ToString.Trim
                objDatos.NRUCGR = objDataRow("NRUCGR")
                objDatos.CUBGEO = objDataRow("CUBGEO")
                objDatos.TLCLGR = objDataRow("TLCLGR").ToString.Trim

                'objDatos.REFCNT = objDataRow("REFCNT").ToString.Trim
                'objDatos.DREGRF = objDataRow("DREGRF").ToString.Trim
                'objDatos.CPRVGR = objDataRow("CPRVGR").ToString.Trim
                'objDatos.DCMPPR = objDataRow("DCMPPR").ToString.Trim

                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection

        End Function


        Public Function Listar_Grifos_Todos(TGRFO As String) As List(Of Grifo)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Grifo)
            Dim objDatos As Grifo

            Dim objParam As New Parameter
            'Try
            objParam.Add("PSTGRFO", TGRFO)
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GRIFOS_V2", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Grifo
                objDatos.CGRFO = objDataRow("CGRFO").ToString.Trim
                objDatos.TGRFO = objDataRow("TGRFO").ToString.Trim
                objDatos.TAGRFO = objDataRow("TAGRFO").ToString.Trim
                objDatos.NRUCGR = objDataRow("NRUCGR")
                objDatos.CUBGEO = objDataRow("CUBGEO")
                objDatos.TLCLGR = objDataRow("TLCLGR").ToString.Trim

                objDatos.REFCNT = objDataRow("REFCNT").ToString.Trim
                objDatos.DREGRF = objDataRow("DREGRF").ToString.Trim
                objDatos.CPRVGR = objDataRow("CPRVGR").ToString.Trim
                objDatos.DCMPPR = objDataRow("DCMPPR").ToString.Trim
                objDatos.NRUCPR = objDataRow("NRUCPR").ToString.Trim


                objGenericCollection.Add(objDatos)
            Next

            Return objGenericCollection

        End Function


        Public Sub Registrar_Tarifa_Grifo(ByVal objEntidad As Grifo)
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCGRFO", objEntidad.CGRFO)
            objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            objParam.Add("PNNCRRTR", objEntidad.NCRRTR)
            objParam.Add("PNFCMBUS", objEntidad.FCMBUS)
            objParam.Add("PNIPRCMS", objEntidad.IPRCMS)
            objParam.Add("PNIPRCMD", objEntidad.IPRCMD)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSUSRCRT", objEntidad.USRCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_TARIFA_GRIFO", objParam)
            'Catch ex As Exception
            '          objEntidad.CGRFO = 0
            '      End Try
            '      Return objEntidad
        End Sub

        Public Sub Eliminar_Tarifa_Grifo(ByVal objEntidad As Grifo)
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCGRFO", objEntidad.CGRFO)
            objParam.Add("PSCTPCMB", objEntidad.CTPCMB)
            objParam.Add("PNNCRRTR", objEntidad.NCRRTR)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TARIFA_GRIFO", objParam)

            'Catch ex As Exception
            '          objEntidad.CGRFO = 0
            '      End Try
            '      Return objEntidad
        End Sub

    Public Function Listar_Tarifa_Grifo(ByVal objEntidad As Grifo) As List(Of Grifo)
      Dim oDt As New DataTable
      Dim obj_Entidad As Grifo
      Dim objGenericCollection As New List(Of Grifo)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNCGRFO", objEntidad.CGRFO)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TARIFA_GRIFO", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                obj_Entidad = New Grifo
                obj_Entidad.CGRFO = objDataRow("CGRFO")
                obj_Entidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                obj_Entidad.NCRRTR = objDataRow("NCRRTR")
                obj_Entidad.FCMBUS_S = objDataRow("FCMBUS_S").ToString.Trim
                obj_Entidad.IPRCMS = objDataRow("IPRCMS")
                obj_Entidad.IPRCMD = objDataRow("IPRCMD")
                obj_Entidad.SESTVG = objDataRow("SESTVG").ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Tarifa_Actual(ByVal objParametro As Hashtable) As List(Of Grifo)
      Dim oDt As New DataTable
      Dim obj_Entidad As Grifo
      Dim objGenericCollection As New List(Of Grifo)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSCGRFO", objParametro("PSCGRFO"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TARIFA_ACTUAL", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                obj_Entidad = New Grifo
                obj_Entidad.CGRFO = objDataRow("CGRFO")
                obj_Entidad.TGRFO = objDataRow("TGRFO").ToString.Trim
                obj_Entidad.NRUCGR = objDataRow("NRUCGR")
                obj_Entidad.TLCLGR = objDataRow("TLCLGR").ToString.Trim
                obj_Entidad.CTPCMB = objDataRow("CTPCMB").ToString.Trim
                obj_Entidad.NCRRTR = objDataRow("NCRRTR")
                obj_Entidad.FCMBUS_S = objDataRow("FCMBUS_S").ToString.Trim
                obj_Entidad.IPRCMS = objDataRow("IPRCMS")
                obj_Entidad.IPRCMD = objDataRow("IPRCMD")
                obj_Entidad.SESTVG = objDataRow("SESTVG").ToString.Trim
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function


        Public Function Listar_Grifo_Proveedor() As List(Of Grifo)
            Dim oDt As New DataTable
            Dim obj_Entidad As Grifo
            Dim objGenericCollection As New List(Of Grifo)
            Dim objParam As New Parameter
            'Try
            'objParam.Add("PSCGRFO", objParametro("PSCGRFO"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GRIFO_PROVEEDOR", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                obj_Entidad = New Grifo
                obj_Entidad.CPRVGR = objDataRow("CPRVGR")
                obj_Entidad.DCMPPR = objDataRow("DCMPPR").ToString.Trim
                obj_Entidad.NRUCPR = objDataRow("NRUCPR")
                objGenericCollection.Add(obj_Entidad)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
        End Function


        Public Function Listar_Grifo_Validacion_Carga() As DataTable
            Dim oDt As New DataTable

            Dim objParam As New Parameter
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GRIFO_VALIDACION_CARGA", objParam)
          
            Return oDt
        End Function

        Public Function Listar_Grifo_Validacion_Edicion(CGRFO As Decimal) As Decimal
            Dim oDt As New DataTable
            Dim CantReg As Decimal = 0
            Dim objParam As New Parameter
            objParam.Add("PNCGRFO", CGRFO)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_REGISTRO_GRIFO", objParam)
            If oDt.Rows.Count > 0 Then
                CantReg = oDt.Rows(0)("CANT_REG")
            End If
            Return CantReg
        End Function

        'SP_SOLMIN_ST_VALIDAR_REGISTRO_GRIFO

  End Class
End Namespace