Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class Empleado_DAL
    Private objSql As New SqlManager


    Public Function Lista_Empleados(ByVal pobjEntidad As Hashtable) As List(Of Empleado)
        Dim oDt As DataTable
        Dim objLisEmpleado As New List(Of Empleado)
        Dim objEntidad As Empleado
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCEMPC", pobjEntidad("CEMPC"))
            objParam.Add("PSCCMPN1", pobjEntidad("CCMPN1"))
            objParam.Add("PSCTPOEM", pobjEntidad("CTPOEM"))

            'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjEntidad("PSCCMPN"))

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_EMPLEADO_X_CODIGO_COMPANIA", objParam)
            For Each objDr As DataRow In oDt.Rows
                objEntidad = New Empleado
                objEntidad.CTPOEM = objDr.Item("CTPOEM")
                objEntidad.CTPPTA = objDr.Item("CTPPTA")
                objEntidad.CEMPC = objDr.Item("CEMPC")
                objEntidad.TCMPEM = objDr.Item("TCMPEM")
                objEntidad.TABREM = objDr.Item("TABREM")
                objEntidad.TDRCEM = objDr.Item("TDRCEM")
                objEntidad.TLCLEM = objDr.Item("TLCLEM")
                objEntidad.TDPTEM = objDr.Item("TDPTEM")
                objEntidad.CCECOE = objDr.Item("CCECOE")
                objEntidad.CCMPN1 = objDr.Item("CCMPN1")
                objEntidad.CCLNT5 = objDr.Item("CCLNT5")
                objEntidad.CSCDSP = objDr.Item("CSCDSP")
                objEntidad.PERNR = objDr.Item("PERNR")
                objEntidad.CCENPL = objDr.Item("CCENPL")
                objEntidad.TDSCTR = objDr.Item("TDSCTR")
                objEntidad.SESTRG = objDr.Item("SESTRG")
                objLisEmpleado.Add(objEntidad)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return objLisEmpleado
    End Function

    Public Function Listar_TipoEmpleado(ByVal CCMP As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMP)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_TIPO_EMPLEADO", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function


    Public Function Modificar_Empleado(ByVal objEntidad As Empleado) As Empleado

        Try
            Dim objParam As New Parameter

            objParam.Add("PSCTPOEM", objEntidad.CTPOEM)
            objParam.Add("PNCTPPTA", objEntidad.CTPPTA)
            objParam.Add("PNCEMPC", objEntidad.CEMPC)
            objParam.Add("PSTCMPEM", objEntidad.TCMPEM)
            objParam.Add("PSTABREM", objEntidad.TABREM)
            objParam.Add("PSTDRCEM", objEntidad.TDRCEM)
            objParam.Add("PSTLCLEM", objEntidad.TLCLEM)
            objParam.Add("PSTDPTEM", objEntidad.TDPTEM)
            objParam.Add("PSCCMPN1", objEntidad.CCMPN1)
            objParam.Add("PSCSCDSP", objEntidad.CSCDSP)

            'ejecuta el procedimiento almacenado

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_EMPLEADO", objParam)

        Catch ex As Exception
        End Try
        Return objEntidad
    End Function


    Public Function Registrar_Empleado(ByVal objEntidad As Empleado) As Empleado

        Try
            Dim objParam As New Parameter

            objParam.Add("PSCTPOEM", objEntidad.CTPOEM)
            objParam.Add("PNCTPPTA", objEntidad.CTPPTA)
            objParam.Add("PNCEMPC", objEntidad.CEMPC)
            objParam.Add("PSTCMPEM", objEntidad.TCMPEM)
            objParam.Add("PSTABREM", objEntidad.TABREM)
            objParam.Add("PSTDRCEM", objEntidad.TDRCEM)
            objParam.Add("PSTLCLEM", objEntidad.TLCLEM)
            objParam.Add("PSTDPTEM", objEntidad.TDPTEM)
            objParam.Add("PNCCECOE", objEntidad.CCECOE)
            objParam.Add("PSCCMPN1", objEntidad.CCMPN1)
            objParam.Add("PNCCLNT5", objEntidad.CCLNT5)
            objParam.Add("PSCSCDSP", objEntidad.CSCDSP)

            objParam.Add("PSPERNR", objEntidad.PERNR)
            objParam.Add("PNCCENPL", objEntidad.CCENPL)
            objParam.Add("PSTDSCTR", objEntidad.TDSCTR)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)



            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_EMPLEADO", objParam)

        Catch ex As Exception
        End Try
        Return objEntidad
    End Function



    Public Function Cambiar_Estado_Empleado(ByVal objEntidad As Empleado)

        Try
            Dim objParam As New Parameter
            objParam.Add("PSCTPOEM", objEntidad.CTPOEM)
            objParam.Add("PNCTPPTA", objEntidad.CTPPTA)
            objParam.Add("PNCEMPC", objEntidad.CEMPC)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_EMPLEADO", objParam)

        Catch ex As Exception

        End Try

        Return objEntidad
    End Function
End Class
