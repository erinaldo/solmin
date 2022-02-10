Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario

Namespace Operaciones
    Public Class Junta_Transporte_DAL
        Private objSql As New SqlManager

        Public Function Existe_Junta_Pendiente_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PON_EXISTE", 0, ParameterDirection.Output)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_EXISTE_PENDIENTE_JUNTA_TRANSPORTISTA", objParam)
            objEntidad.NPLNJT = objSql.ParameterCollection("PON_EXISTE").ToString()
            'Catch ex As Exception
            '    objEntidad.NPLNJT = "0"
            'End Try
            Return objEntidad
        End Function

    Public Function Registrar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PON_NPLNJT", 0, ParameterDirection.Output)
            objParam.Add("PON_NCRRPL", 0, ParameterDirection.Output)
            objParam.Add("PNFPLNJT", objEntidad.FPLNJT)
            objParam.Add("PNHPLNJT", objEntidad.HPLNJT)
            objParam.Add("PSTDSCPL", objEntidad.TDSCPL)
            objParam.Add("PSTRSPAT", objEntidad.TRSPAT)
            objParam.Add("PNQCNASI", objEntidad.QCNASI)
            objParam.Add("PSSESPLN", objEntidad.SESPLN)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_JUNTA_TRANSPORTISTA", objParam)
            objEntidad.NPLNJT = objSql.ParameterCollection("PON_NPLNJT").ToString()
            objEntidad.NCRRPL = objSql.ParameterCollection("PON_NCRRPL").ToString()
            'Catch ex As Exception
            '    objEntidad.NPLNJT = "0"
            '    objEntidad.NCRRPL = "0"
            'End Try
            Return objEntidad
    End Function

        'Public Function Registrar_Junta_Transporte_Manual(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
        '        'Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PON_NPLNJT", 0, ParameterDirection.Output)
        '        objParam.Add("PON_NCRRSR", 0, ParameterDirection.Output)
        '        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        '        objParam.Add("PNFASGTR", objEntidad.FCHCRT)
        '        objParam.Add("PNHASGTR", objEntidad.HRACRT)
        '        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        '        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        '        objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
        '        objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
        '        objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
        '        objParam.Add("PSCBRCN2", objEntidad.CBRCN2)
        '        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        '        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        '        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        '        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
        '        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        '        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        '        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_JUNTA_TRANSPORTISTA_MANUAL", objParam)
        '        objEntidad.NPLNJT = objSql.ParameterCollection("PON_NPLNJT").ToString()
        '        objEntidad.NCRRSR = objSql.ParameterCollection("PON_NCRRSR").ToString()
        '        'Catch ex As Exception
        '        '  objEntidad.NPLNJT = "0"
        '        'End Try
        '        Return objEntidad
        '    End Function


        Public Function Registrar_Detalle_Solicitud_Transporte(ByVal objEntidad As Detalle_Solicitud_Transporte, ByRef msg As String) As beRespuestaOperacion
            'Try
            Dim objParam As New Parameter

            Dim rpta As New beRespuestaOperacion
            objParam.Add("PNNCSOTR", objEntidad.NCSOTR)           
            'objParam.Add("PNCCLNT", objEntidad.CCLNT)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSNPLCUN", objEntidad.NPLCUN)
            objParam.Add("PSNPLCAC", objEntidad.NPLCAC)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCBRCN2", objEntidad.CBRCN2)

            objParam.Add("PSTLFNO", "") ' CAMPO ADICIONADO 2022 POR HUBSMART

            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)


            'objParam.Add("PSCCMPN", objEntidad.CCMPN)
            'objParam.Add("PSCDVSN", objEntidad.CDVSN)
            'objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            Dim dt As New DataTable
            msg = ""
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_DETALLE_SOLICITUD_TRANSPORTE", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT")
                End If
            Next
            If msg.Length = 0 Then
                If dt.Rows.Count > 0 Then
                    rpta.NCRRSR = dt.Rows(0)("NCRRSR")
                End If
            End If


            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_SOLICITUD_TRANSPORTE", objParam)

            Return rpta
        End Function


        Public Function Modificar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PNFPLNJT", objEntidad.FPLNJT)
            objParam.Add("PNHPLNJT", objEntidad.HPLNJT)
            objParam.Add("PSTDSCPL", objEntidad.TDSCPL)
            objParam.Add("PSTRSPAT", objEntidad.TRSPAT)
            objParam.Add("PNQCNASI", objEntidad.QCNASI)
            objParam.Add("PSSESPLN", objEntidad.SESPLN)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_JUNTA_TRANSPORTISTA", objParam)
            'Catch ex As Exception
            '    objEntidad.NPLNJT = "0"
            '    objEntidad.NCRRPL = "0"
            'End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_JUNTA_TRANSPORTISTA", objParam)
            'Catch ex As Exception
            '    objEntidad.NPLNJT = "0"
            'End Try
            Return objEntidad
        End Function

        Public Function Actualizar_Detalle_Solicitud(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_DETALLE_SOLICITUD", objParam)
            Catch ex As Exception
                objEntidad.NPLNJT = "0"
                objEntidad.NCRRPL = "0"
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of Junta_Transporte)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Junta_Transporte)
            Dim objDatos As Junta_Transporte
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNNPLNJT", objParamList(0))
            objParam.Add("PSSESPLN", objParamList(1))
            If objParamList(2) <> "" And objParamList(3) <> "" Then
                objParam.Add("PNFECINI", objParamList(2))
                objParam.Add("PNFECFIN", objParamList(3))
            Else
                objParam.Add("PNFECINI", 0)
                objParam.Add("PNFECFIN", 0)
            End If
            objParam.Add("PSCCMPN", objParamList(4))
            objParam.Add("PSCDVSN", objParamList(5))
            objParam.Add("PNCPLNDV", objParamList(6))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(4))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_JUNTA_TRANSPORTISTA_LA", objParam)
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Junta_Transporte
                objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
                objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
                objDatos.FPLNJT = HelpClass.CFecha_de_8_a_10(objDataRow("FPLNJT").ToString.Trim)
                objDatos.HPLNJT = objDataRow("HPLNJT").ToString.Trim
                objDatos.TDSCPL = objDataRow("TDSCPL").ToString.Trim
                objDatos.TRSPAT = objDataRow("TRSPAT").ToString.Trim
                objDatos.QCNASI = objDataRow("QCNASI").ToString.Trim
                objDatos.SESPLN = objDataRow("SESPLN").ToString.Trim
                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.CPLNDV = objDataRow("CPLNDV")
                objDatos.QPROGRAMADOS = objDataRow("QPROGRAMADOS")
                objDatos.QSOLICITUD = objDataRow("QSOLICITUD")
                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            'End Try
            Return objGenericCollection
        End Function

        Public Function Actualizar_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As Junta_Transporte
            'Try
            Dim objParam As New Parameter
            objParam.Add("PON_NPLNJT", objEntidad.NPLNJT, ParameterDirection.Output)
            objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
            objParam.Add("PSSESPLN", objEntidad.SESPLN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_JUNTA_TRANSPORTISTA", objParam)
            objEntidad.NPLNJT = objSql.ParameterCollection("PON_NPLNJT").ToString
            'Catch ex As Exception
            '    objEntidad.NPLNJT = "0"
            'End Try
            Return objEntidad
        End Function

        Public Function Listar_Junta_Transporte_Detalle(ByVal objParamList As List(Of String)) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objDatos As ClaseGeneral
            Dim objParam As New Parameter
            Dim dblTpropios As Double = 0
            Dim dblTterceros As Double = 0
            Try
                objParam.Add("PNNPLNJT", objParamList(0))
                objParam.Add("PNNCRRPL", objParamList(1))
                objParam.Add("PSCCMPN", objParamList(2))
                objParam.Add("PSCDVSN", objParamList(3))
                objParam.Add("PSPLNDV", objParamList(4))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(2))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_RPTJUNTATRANSPORTISTA", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objDatos = New ClaseGeneral
                    objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
                    objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
                    objDatos.FPLNJT = objDataRow("FPLNJT").ToString.Trim
                    objDatos.HPLNJT = objDataRow("HPLNJT").ToString.Trim
                    objDatos.FASGTR = objDataRow("FASGTR").ToString.Trim
                    objDatos.HASGTR = objDataRow("HASGTR").ToString.Trim
                    objDatos.TDSCPL = objDataRow("TDSCPL").ToString.Trim
                    objDatos.TRSPAT = objDataRow("TRSPAT").ToString.Trim
                    objDatos.QCNASI = objDataRow("QCNASI").ToString.Trim
                    objDatos.SESPLN = objDataRow("SESPLN").ToString.Trim
                    objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim
                    objDatos.FECOST = objDataRow("FECOST").ToString.Trim
                    objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
                    objDatos.CUNDVH = objDataRow("CUNDVH").ToString.Trim
                    objDatos.QSLCIT = CType(objDataRow("QSLCIT"), Integer).ToString
                    objDatos.QATNAN = CType(objDataRow("QATNAN"), Integer).ToString
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                    objDatos.NOMCHOFER = objDataRow("NOMCHOFER").ToString.Trim
                    objDatos.QATNDR = CType(objDataRow("QATNDR"), Integer).ToString
                    objDatos.RUTA = objDataRow("RUTA").ToString.Trim
                    objDatos.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                    objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                    objGenericCollection.Add(objDatos)
                Next
            Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_Asignadas(ByVal objEntidad As Junta_Transporte) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objDatos As ClaseGeneral
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OPERACIONES_ASIGNADAS_RPT", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objDatos = New ClaseGeneral
                    objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim
                    objDatos.NCRRSR = objDataRow("NCRRSR").ToString.Trim
                    objDatos.NOPRCN = objDataRow("NOPRCN").ToString.Trim
                    objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim
                    objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim
                    objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
                    objDatos.QSLCIT = CType(objDataRow("QSLCIT"), Integer).ToString
                    objDatos.QATNAN = CType(objDataRow("QATNAN"), Integer).ToString
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim
                    objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                    objGenericCollection.Add(objDatos)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Sub RollBack_Junta_Transportista(ByVal objEntidad As Junta_Transporte)
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PSSESPLN", objEntidad.SESPLN)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ROLLBACK_JUNTA_TRANSPORTISTA", objParam)
            Catch ex As Exception
            End Try
        End Sub

        Public Sub RollBack_Detalle_Solicitud(ByVal objEntidad As Junta_Transporte)
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPLNJT", objEntidad.NPLNJT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ROLLBACK_DETALLE_SOLICITUD", objParam)
            Catch ex As Exception
            End Try
        End Sub

        Public Function Listar_Solicitudes_x_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As List(Of Object)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Object)
            'Dim lstr_datos(5) As String
            Dim objParam As New Parameter
            Try
                objParam.Add("PN_NPLNJT", objEntidad.NPLNJT)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUDES_X_JUNTA", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    'lstr_datos.Initialize()
                    Dim lstr_datos(5) As String
                    lstr_datos(0) = objDataRow("NCSOTR").ToString.Trim
                    lstr_datos(1) = objDataRow("CCLNT").ToString.Trim
                    lstr_datos(2) = objDataRow("RECURSOS").ToString.Trim
                    lstr_datos(3) = objDataRow("NOPRCN").ToString.Trim
                    lstr_datos(4) = objDataRow("CODCLI").ToString.Trim

                    objGenericCollection.Add(lstr_datos)

                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_x_Junta_Transporte(ByVal objEntidad As Junta_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Try

                objParam.Add("PN_NPLNJT", objEntidad.NPLNJT)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_JUNTA", objParam)

            Catch ex As Exception
            End Try
            Return objDataTable
        End Function

        Public Function Lista_Reporte_Junta_Transporte(ByVal objParamList As List(Of String)) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objDatos As ClaseGeneral
            Dim objParam As New Parameter
            Try
                objParam.Add("PSSESPLN", objParamList(0))
                objParam.Add("PNNPLNJT", objParamList(1))
                objParam.Add("PNFECINI", objParamList(2))
                objParam.Add("PNFECFIN", objParamList(3))
                objParam.Add("PSCCMPN", objParamList(4))
                objParam.Add("PSCDVSN", objParamList(5))
                objParam.Add("PNCPLNDV", objParamList(6))
                objParam.Add("PSFECINI", "0", ParameterDirection.Output)
                objParam.Add("PSFECFIN", "0", ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(4))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_LISTA_JUNTA", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objDatos = New ClaseGeneral
                    objDatos.NPLNJT = objDataRow("NPLNJT").ToString.Trim() & " - " & objDataRow("NCRRPL").ToString.Trim()
                    objDatos.NCRRPL = objDataRow("NCRRPL").ToString.Trim()
                    objDatos.FPLNJT = objDataRow("FPLNJT").ToString.Trim()
                    objDatos.SESPLN = objDataRow("SESPLN").ToString.Trim
                    objDatos.HPLNJT = objDataRow("HPLNJT").ToString.Trim()
                    objDatos.FASGTR = objDataRow("FASGTR").ToString.Trim()
                    objDatos.HASGTR = objDataRow("HASGTR").ToString.Trim()
                    objDatos.TRSPAT = objDataRow("TRSPAT").ToString.Trim
                    objDatos.TDSCPL = objDataRow("TDSCPL").ToString.Trim()
                    objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim()
                    objDatos.NCRRSR = objDataRow("NCRRSR").ToString.Trim()
                    objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim()
                    objDatos.FECOST = objDataRow("FECOST").ToString.Trim()
                    objDatos.CUNDVH = objDataRow("CUNDVH").ToString.Trim()
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim()
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim()
                    objDatos.NOMCHOFER = objDataRow("NOMCHOFER").ToString.Trim() & IIf(objDataRow("NOMCHOFER2").ToString.Trim.Length = 0, "", Chr(10) & objDataRow("NOMCHOFER2").ToString.Trim())
                    objDatos.RUTA = objDataRow("RUTA").ToString.Trim()
                    objDatos.TCMRCD = objDataRow("TCMRCD").ToString.Trim()
                    objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim()
                    objDatos.NOPRCN = objDataRow("NOPRCN").ToString.Trim()
                    objDatos.QSLCIT = objDataRow("QSLCIT").ToString.Trim()
                    objDatos.PSFECINI = objSql.ParameterCollection("PSFECINI").ToString.Trim()
                    objDatos.PSFECFIN = objSql.ParameterCollection("PSFECFIN").ToString.Trim()
                    objGenericCollection.Add(objDatos)
                Next
            Catch ex As Exception
            End Try
            Return objGenericCollection
        End Function

        Public Function Lista_Viajes_Realizados(ByVal objParamList As Hashtable) As List(Of ClaseGeneral)
            Dim objDataTable As New DataTable
            Dim objDatos As ClaseGeneral
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCCLNT", objParamList("CCLNT"))
                objParam.Add("PNFECINI", objParamList("FECINI"))
                objParam.Add("PNFECFIN", objParamList("FECFIN"))
                objParam.Add("PSCCMPN", objParamList("CCMPN"))
                objParam.Add("PSCDVSN", objParamList("CDVSN"))
                objParam.Add("PNCPLNDV", objParamList("CPLNDV"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList("CCMPN"))
                'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VIAJES_REALIZADOS", objParam)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VIAJES_REALIZADOS_PRD", objParam)
                For Each objDataRow As DataRow In objDataTable.Rows
                    objDatos = New ClaseGeneral
                    objDatos.NCSOTR = objDataRow("NCSOTR").ToString.Trim()
                    objDatos.FASGTR = objDataRow("FASGTR").ToString.Trim()
                    objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim()
                    objDatos.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim()
                    objDatos.NPLCUN = objDataRow("NPLCUN").ToString.Trim()
                    objDatos.NPLCAC = objDataRow("NPLCAC").ToString.Trim()
                    objDatos.CBRCND = objDataRow("CBRCND").ToString.Trim
                    objDatos.NOPRCN = objDataRow("NOPRCN").ToString.Trim()
                    objDatos.NGUITR = objDataRow("NGUITR").ToString.Trim()
                    objDatos.FGUIRM = ("" & objDataRow("FGUIRM").ToString.Trim())
                    objDatos.QKMREC = Val("" & objDataRow("QKMREC").ToString.Trim())
                    objDatos.SINDRC = ("" & objDataRow("SINDRC").ToString.Trim())
                    objDatos.RUTA = ("" & objDataRow("RUTA").ToString.Trim())
                    objGenericCollection.Add(objDatos)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of ClaseGeneral)
            End Try
            Return objGenericCollection
        End Function


        Public Function Lista_Solicitud_Programas_x_Junta(ByVal obj As Junta_Transporte) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obj.NPLNJT)
            objParam.Add("PNNCRRPL", obj.NCRRPL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_PROGRAMADAS_X_JUNTA", objParam)
            For Each Item As DataRow In objDataTable.Rows
                Item("TCMPCL") = HelpClass.ToStringCvr(Item("TCMPCL"))
                Item("CTPOSR") = HelpClass.ToStringCvr(Item("CTPOSR"))
                Item("CUNDVH") = HelpClass.ToStringCvr(Item("CUNDVH"))
                Item("CMRCDR") = HelpClass.ToStringCvr(Item("CMRCDR"))
                Item("SESSLC") = HelpClass.ToStringCvr(Item("SESSLC"))
                Item("CLCLOR") = HelpClass.ToStringCvr(Item("CLCLOR"))
                Item("CLCLDS") = HelpClass.ToStringCvr(Item("CLCLDS"))
            Next
            Return objDataTable
        End Function

        Public Sub Guardar_Junta_Solicitud_Programado(ByVal obj As Detalle_Junta_Transporte)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obj.NPLNJT)
            objParam.Add("PNNCRRPL", obj.NCRRPL)
            objParam.Add("PNNCSOTR", obj.NCSOTR)
            objParam.Add("PNQANPRG", obj.QANPRG)
            objParam.Add("PSCULUSA", obj.CULUSA)
            objParam.Add("PSNTRMNL", obj.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_GUARDAR_JUNTA_SOLICITUD_PROGRAMADO", objParam)
        End Sub
        Public Sub Eliminar_Junta_Solicitud_Programado(ByVal obj As Detalle_Junta_Transporte)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obj.NPLNJT)
            objParam.Add("PNNCRRPL", obj.NCRRPL)
            objParam.Add("PNNCSOTR", obj.NCSOTR)
            objParam.Add("PSCULUSA", obj.CULUSA)
            objParam.Add("PSNTRMNL", obj.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obj.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_JUNTA_SOLICITUD_PROGRAMADO", objParam)
        End Sub


    End Class

End Namespace