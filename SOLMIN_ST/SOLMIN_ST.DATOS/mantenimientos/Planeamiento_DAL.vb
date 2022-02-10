Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports System.Data

Namespace mantenimientos

    Public Class Planeamiento_DAL

        Dim objSql As SqlManager

        Sub New()
            objSql = New SqlManager()
        End Sub

        Public Function Listar_Vehiculos_x_Planeamiento(ByVal objentidad As RecursoPlaneamiento) As DataTable
            Dim objResultado As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objentidad.NPLNMT)
                objParam.Add("PARAM_CTRSPT", objentidad.CTRSPT)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTADO_RELACION_VEH_PLANEAMIENTO", objParam)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Listar_Localidad_x_Planeamiento(ByVal objentidad As RecursoPlaneamiento) As DataTable
            Dim objResultado As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objentidad.NPLNMT)
                objParam.Add("PARAM_CTRSPT", objentidad.CTRSPT)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_TR_OBTENER_LOCALIDAD_PLANEAMIENTO", objParam)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Listar_Transportista_x_Planeamiento(ByVal objentidad As RecursoPlaneamiento) As DataTable
            Dim objResultado As New DataTable
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objentidad.NPLNMT)
                objParam.Add("PARAM_CTRSPT", objentidad.CTRSPT)
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_TR_OBTENER_TRANSPORTISTA_X_PLANEAMIENTO", objParam)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Registrar_Cabecera_Planeamiento(ByVal objEntidad As RecursoPlaneamiento) As Integer
            Dim objResultado As String = ""
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
                objParam.Add("PARAM_QPLNPL", objEntidad.QPLNPL)
                objParam.Add("PARAM_NCRRSR", objEntidad.NCRRSR)
                objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
                objParam.Add("PARAM_FCHCRT", objEntidad.FCHCRT)
                objParam.Add("PARAM_HRACRT", objEntidad.HRACRT)
                objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
                objResultado = objSql.ExecuteNoQuery("SP_SOLMIN_TR_REGISTRAR_RECURSO_CABECERA_PLANEAMIENTO", objParam)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If objResultado.Equals("") = True Then
                Return -1
            Else
                Return CInt(objResultado)
            End If

        End Function

        Public Function Registrar_Detalle_Planeamiento(ByVal objEntidad As RecursoPlaneamiento) As Integer
            Dim objResultado As String = ""
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
                objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
                objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
                objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
                objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
                objParam.Add("PARAM_TNMBCH", objEntidad.TNMBCH)
                objParam.Add("PARAM_QPLNPL", objEntidad.QPLNPL)
                objParam.Add("PARAM_NCRRSR", objEntidad.NCRRSR)
                objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
                objParam.Add("PARAM_FCHCRT", objEntidad.FCHCRT)
                objParam.Add("PARAM_HRACRT", objEntidad.HRACRT)
                objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
                objParam.Add("PARAM_CTPMD2", objEntidad.CTPMD2)
                objParam.Add("PARAM_CBRCN2", objEntidad.CBRCN2)
                objParam.Add("PARAM_TNMCH2", objEntidad.TNMCH2)
                objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
                objResultado = objSql.ExecuteNoQuery("SP_SOLMIN_TR_REGISTRAR_RECURSO_DETALLE_PLANEAMIENTO", objParam)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If objResultado.Equals("") = True Then
                Return -1
            Else
                Return CInt(objResultado)
            End If

        End Function

        Public Function Listado_Planeamiento(ByVal objEntidad As Planeamiento, ByVal Fecha_Inicio As String, ByVal Fecha_fin As String) As DataSet
            Dim objResultado As New DataSet
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
                objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
                objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("PARAM_SESPLN", objEntidad.SESPLN)
                objParam.Add("PARAM_FEC_INI", Fecha_Inicio)
                objParam.Add("PARAM_FEC_FIN", Fecha_fin)


                Dim dtb1 As New DataTable
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                dtb1 = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTADO_PLANEAMIENTO", objParam)
                dtb1.TableName = "planeamiento"
                objResultado.Tables.Add(dtb1)

                Dim dtb2 As New DataTable
                dtb2 = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTADO_RECURSO_PLANEAMIENTO", objParam)
                dtb2.TableName = "recurso_planeamiento"
                objResultado.Tables.Add(dtb2)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Listado_Planeamiento_Filtro(ByVal objEntidad As Planeamiento) As DataSet
            Dim objResultado As New DataSet
            Try
                Dim objParam As New Parameter
                objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)

                Dim dtb1 As New DataTable
                dtb1 = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTADO_PLANEAMIENTO_FILTRO", objParam)
                dtb1.TableName = "planeamiento"
                objResultado.Tables.Add(dtb1)

                Dim dtb2 As New DataTable
                dtb2 = objSql.ExecuteDataTable("SP_SOLMIN_TR_LISTADO_RECURSO_PLANEAMIENTO_FILTRO", objParam)
                dtb2.TableName = "recurso_planeamiento"
                objResultado.Tables.Add(dtb2)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objResultado
        End Function

        Public Function Obtener_Servicio_Cotizacion_X_Planeamiento(ByVal objEntidad As RecursoPlaneamiento) As RecursoPlaneamiento
            Try
                Dim objParam As New Parameter
                Dim objDataTable As New DataTable
                objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_TR_SERVICIO_COTIZACION_X_PLANEAMIENTO", objParam)
                If objDataTable.Rows.Count > 0 Then
                    With objDataTable.Rows(0)
                        objEntidad.NCTZCN = .Item("NCTZCN").ToString()
                        objEntidad.NCRRCT = .Item("NCRRCT").ToString()
                        objEntidad.NCRRSR = .Item("NCRRSR").ToString()
                    End With
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return objEntidad
        End Function

        'Inserta un item de recurso a la tabla
        Public Function Registrar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Dim intResultado As Int32 = 0
            Dim ExisteRegistro As String = "FALSE"
            Try
                Dim objParam As New Parameter
                objParam.Add("PSNPLNMT", objEntidad.NPLNMT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PNNSBCRP", objEntidad.NSBCRP)
                objParam.Add("PSTOBSRC", objEntidad.TOBSRC_S)
                objParam.Add("PSSESTRC", objEntidad.SESTRC_S)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
                objParam.Add("PSNPLCTR", objEntidad.NPLCTR)
                objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
                objParam.Add("PSSRCRSO", objEntidad.CRCRSO_S)
                objParam.Add("PSCMNTRN", objEntidad.CMNTRN)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PSCURSCRT", objEntidad.CUSCRT)
                objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
                objParam.Add("PNHRACRT", objEntidad.HRACRT)
                objParam.Add("PSCUlUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
                objParam.Add("PNCLCLOR", Convert.ToDouble(objEntidad.CLCLOR))
                objParam.Add("PNCLCLDS", Convert.ToDouble(objEntidad.CLCLDS))
                objParam.Add("PNNCTZCN", Convert.ToDouble(objEntidad.NCTZCN))
                objParam.Add("PNNCRRCT", Convert.ToDouble(objEntidad.NCRRCT))
                objParam.Add("PNNCRRSR", Convert.ToDouble(objEntidad.NCRRSR))
                objParam.Add("PNNORINS", Convert.ToDouble(objEntidad.NORINS))
                objParam.Add("PNTCNFVH", objEntidad.TCNFVH)
                objParam.Add("POS_EXISTE", "FALSE", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_PLANEAMIENTO_RECURSOT2", objParam)

                ExisteRegistro = objSql.ParameterCollection("POS_EXISTE").ToString()
                intResultado = 1
                If (ExisteRegistro.ToUpper() = "TRUE") Then
                    intResultado = 2 'YA EXISTE EL REGISTRO
                End If
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function
        'Modifica un item de planeamiento 
        Public Function Modificar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Dim ExisteRegistro As String = "FALSE"
            Dim intResultado As Int32 = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PSNPLNMT", objEntidad.NPLNMT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PNNSBCRP", objEntidad.NSBCRP)
                objParam.Add("PSTOBSRC", objEntidad.TOBSRC_S)
                objParam.Add("PSNRUCTR", objEntidad.NRUCTR.Trim())
                objParam.Add("PSNPLCTR", objEntidad.NPLCTR)
                objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCUlUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("POS_EXISTE", "FALSE", ParameterDirection.Output)
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ACTUALIZAR_PLANEAMIENTO_RECURSOT2", objParam)
                ExisteRegistro = objSql.ParameterCollection("POS_EXISTE").ToString()
                intResultado = 1
                If (ExisteRegistro.ToUpper() = "TRUE") Then
                    intResultado = 2 'YA EXISTE EL REGISTRO
                End If
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function
        'Elimina un item del planeamiento
        Public Function Eliminar_Planeamiento_Item(ByVal objEntidad As Planeamiento) As Integer
            Dim intResultado As Int32 = 0
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPLNMT", objEntidad.NPLNMT)
                objParam.Add("PNNCRRPL", objEntidad.NCRRPL)
                objParam.Add("PNNSBCRP", objEntidad.NSBCRP)
                objParam.Add("PSSESTRC", objEntidad.SESTRC_S)
                objParam.Add("PNFULTAC", objEntidad.FCHCRT)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_PLANEAMIENTO_RECURSO", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

    End Class

End Namespace