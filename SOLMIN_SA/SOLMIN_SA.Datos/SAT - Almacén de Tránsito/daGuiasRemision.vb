Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace DespachoSAT
    Public Class daGuiasRemision
        Inherits daBase(Of beGuiaRemision)

        Dim objSql As New SqlManager

        Public Function fnListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision, ByRef PageCount As Decimal) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim obeGuiaRemision As beGuiaRemision
            Dim objParam As New Parameter

            objParam.Add("PSCCLNT", obeFiltroGuia.PNCCLNT)
           
            objParam.Add("PSNGUIRM", obeFiltroGuia.PSNGUIRM)

            objParam.Add("PNFECINI", obeFiltroGuia.PNFECINI)
            objParam.Add("PNFECFIN", obeFiltroGuia.PNFECFIN)
            objParam.Add("PSTLUGEN", obeFiltroGuia.PSTLUGEN)
            objParam.Add("PSESTADO", obeFiltroGuia.PSSESDCM)
            objParam.Add("PAGESIZE", obeFiltroGuia.PageSize)
            objParam.Add("PAGENUMBER", obeFiltroGuia.PageNumber)


            Dim ds As New DataSet
            Dim dtListado As New DataTable
            Dim dtpages As New DataTable
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_GUIA_REMISION_LIST", objParam)
            dtListado = ds.Tables(0).Copy
            dtpages = ds.Tables(1).Copy
            PageCount = dtpages.Rows(0)("PAGECOUNT")

            For Each item As DataRow In dtListado.Rows
                obeGuiaRemision = New beGuiaRemision

                'NGUIRM


                obeGuiaRemision.PSNGUIRM = item("NGUIRM")
                'obeGuiaRemision.PNNGUIRM = item("NGUIRM")
                obeGuiaRemision.PSNGUIRS = item("NGUIRS")
                obeGuiaRemision.PSDNGUIRS = item("DNGUIRS")
                obeGuiaRemision.PSCTDGRM = ("" & item("CTDGRM")).ToString.Trim
                obeGuiaRemision.PNNGUIRO = item("NGUIRO")
                obeGuiaRemision.PSSSTVAL = ("" & item("SSTVAL")).ToString.Trim
                obeGuiaRemision.PSSTRNSM = ("" & item("STRNSM")).ToString.Trim
                obeGuiaRemision.PNCCLNT = item("CCLNT")
                obeGuiaRemision.PSDNGUIRM = item("DNGUIRM")
                obeGuiaRemision.PNFGUIRM = item("FGUIRM")
                obeGuiaRemision.PSPLTORIGEN = ("" & item("PLTORIGEN")).ToString.Trim
                obeGuiaRemision.PSORIGEN = ("" & item("ORIGEN")).ToString.Trim
                obeGuiaRemision.PSPLTDESTINO = item("PLTDESTINO")
                obeGuiaRemision.PNCPLNCL = item("CPLNCL")
                obeGuiaRemision.PSDESTINO = ("" & item("DESTINO")).ToString.Trim
                obeGuiaRemision.PNCDPEPL = Val("" & item("CDPEPL"))
                obeGuiaRemision.PSTCMPTR = ("" & item("TCMPTR")).ToString.Trim
                obeGuiaRemision.PSNPLCCM = ("" & item("NPLCCM")).ToString.Trim
                obeGuiaRemision.PSNBRVCH = ("" & item("NBRVCH")).ToString.Trim
                obeGuiaRemision.PSTOBORM = ("" & item("TOBORM")).ToString.Trim
                obeGuiaRemision.PSNPLACP = ("" & item("NPLACP")).ToString.Trim
                obeGuiaRemision.PSTNMBCH = ("" & item("TNMBCH")).ToString.Trim
                obeGuiaRemision.PNTIPO = item("TIPO")
                obeGuiaRemision.PSSESTRG = ("" & item("SESTRG")).ToString.Trim
              
                obeGuiaRemision.PSTCMPCL = ("" & item("TCMPCL")).ToString.Trim
                obeGuiaRemision.PSLINK = ("" & item("LINK")).ToString.Trim
                obeGuiaRemision.PSESTADOOPERACION = item("ESTADOOPERACION")
                obeGuiaRemision.PNNOPRCN = Val("" & item("NOPRCN"))
                obeGuiaRemision.PSNDCMFC = ("" & item("NDCMFC")).ToString.Trim
                obeGuiaRemision.PSTIPODOC = ("" & item("TIPODOC")).ToString.Trim
                obeGuiaRemision.PSNGUIATR = ("" & item("NGUIATR")).ToString.Trim
                obeGuiaRemision.PSSESDCM_DES = ("" & item("SESDCM_DES")).ToString.Trim
                obeGuiaRemision.PNNMRGIM = Val("" & item("NMRGIM"))

                obeGuiaRemision.PSNGUISO = ("" & item("NGUISO")).ToString.Trim
                obeGuiaRemision.PSSTRNEG = ("" & item("STRNEG")).ToString.Trim
                obeGuiaRemision.PSSTRNAG = ("" & item("STRNAG")).ToString.Trim

                obeGuiaRemision.PSNMRGIM_S = ("" & item("NMRGIM_S")).ToString.Trim

                olbeGuiaRemision.Add(obeGuiaRemision)
            Next

     
            Return olbeGuiaRemision
        End Function

        Public Function fnSelDetalleGuiaAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
          
            objParam.Add("PNNGUIRM", obeFiltroGuia.PSNGUIRM)
            Return Listar("SP_SOLMIN_SA_AT_DETALLE_GUIA", objParam)
           
        End Function

        ''' <summary>
        ''' Anular guia de remision  de Almacen de transito
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AnularGuiaDeRemisionAT(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_AT_ANULAR_GUIA_REMISION", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        ''' <summary>
        ''' Elimina guia de remision  de Almacen de transito
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function EliminarGuiaDeRemisionAT(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                objParam.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_AT_ELIMINAR_GUIA_REMISION", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function


        Public Function ListarGuiasSalidaSAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
            objParam.Add("IN_FECINI", obeFiltroGuia.PNFECINI)
            objParam.Add("IN_FECFIN", obeFiltroGuia.PNFECFIN)
            objParam.Add("PAGESIZE", obeFiltroGuia.PageSize)
            objParam.Add("PAGENUMBER", obeFiltroGuia.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

            Return Listar("SP_SOLMIN_SA_GUIA_REMISION_LIST", objParam)
          

        End Function



        Public Function fnListGuiasRemisionSAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("PNCCLNGR", obeFiltroGuia.PNCCLNGR)
            objParam.Add("PNNRGUSA", obeFiltroGuia.GUIASALIDA)
            objParam.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParam.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParam.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)

            Return Listar("SP_SOLMIN_SA_AT_LISTAR_GUIA_REMISION", objParam)
          
        End Function

        Public Function fnListGuiasRemision_SalidaSAT(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            
            objParam.Add("PNNRGUSA", obeFiltroGuia.PNNRGUSA)
            objParam.Add("PSNGUIRM", obeFiltroGuia.PSNGUIRM)

            objParam.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParam.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParam.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParam.Add("PNFSLDAL_INICIAL", obeFiltroGuia.PNFSLDAL_INICIAL)
            objParam.Add("PNFSLDAL_FINAL", obeFiltroGuia.PNFSLDAL_FINAL)
            objParam.Add("PSSTGUSA", obeFiltroGuia.PSSTGUSA)

            'Return Listar("SP_SOLMIN_SA_AT_LISTAR_GUIA_REMISION_SALIDA", objParam)
            Return Listar("SP_SOLMIN_SA_AT_LISTAR_GUIA_REMISION_SALIDA_SAT", objParam)


           
        End Function


        Public Function fblnExisteInformacion(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("PNNRGUSA", obeFiltroGuia.PNNRGUSA)
            objParametros.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParametros.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            Try
                strMensajeError = ""
                If Integer.TryParse(objSqlManager.ExecuteScalar("SP_SOLMIN_SA_AT_VALIDAR_GUIA_SALIDA_AND_GUIA_REMISION", objParametros), intCount) Then
                    If intCount = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnExisteInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                                  "Tipo de Consulta EXISTS : << " & "SP_SOLMIN_SA_AT_VALIDAR_GUIA_SALIDA_AND_GUIA_REMISION" & " >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function





        Public Function fblnRestaurarGuiaSalidaSAT(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("PNCCLNGR", obeFiltroGuia.PNCCLNGR)
            objParametros.Add("IN_NRGUSA", obeFiltroGuia.PNNRGUSA)
            objParametros.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParametros.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParametros.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)

            strMensajeError = ""

            Dim dt As New DataTable
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_RESTAURAR_GUIA_SALIDA", objParametros)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    strMensajeError = strMensajeError & item("OBSRESULT") & Chr(13)
                End If
            Next
            Return strMensajeError

           
        End Function



        Public Function fblnAnularGuiaSalidaSAT(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("IN_NRGUSA", obeFiltroGuia.PNNRGUSA)
            objParametros.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParametros.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParametros.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_GUIA_SALIDA", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAnularGuiaSalida >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function


        'Public Function fblnAnularGuiaRemisionSAT(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
        Public Function fblnAnularGuiaRemisionSAT(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("IN_CCLNGR", obeFiltroGuia.PNCCLNGR)
            objParametros.Add("IN_NRGUSA", obeFiltroGuia.PNNRGUSA)
            objParametros.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParametros.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParametros.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)

            strMensajeError = ""
            Dim dt As New DataTable

            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_ANULAR_GUIA_REMISION", objParametros)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    strMensajeError = strMensajeError & item("OBSRESULT") & Chr(13)
                End If
            Next
            Return strMensajeError


          
        End Function

        Public Function fdstGuiaSalidaMercaderia(ByVal has As Hashtable) As DataSet
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", has("CCLNT"))
            objParametros.Add("IN_FECHA_INI", has("FECHA_INI"))
            objParametros.Add("IN_FECHA_FIN", has("FECHA_FIN"))
            objParametros.Add("IN_NPLCUN", has("NPLCUN"))

            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_GUIA_SALIDA_MERCADERIA", objParametros)
          
        End Function


        ''' <summary>
        ''' Copia Nr Guia de Salida de Planta X a Planta Y
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CopyGuiaSalida(ByVal obeFiltroGuia As beGuiaRemision) As Decimal
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParam As New Parameter
            Try

                objParam.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
                objParam.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
                objParam.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
                objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("PNNROCTL", obeFiltroGuia.PNNROCTL)
                objParam.Add("PNNRGUSA", obeFiltroGuia.PNNRGUSA)

                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_AT_LISTAR_GUIA_REMISION_SALIDA")

            Catch ex As Exception
                Return -1
            End Try

        End Function

        Public Function fnSelObservacionGR(ByVal ht As Hashtable) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("IN_CCLNT", ht("CCLNT"))
            objParam.Add("IN_NGUIRM", ht("NGUIRM"))
            Return Listar("SP_SOLMIN_SA_OBSERVACION_GR", objParam)
          
        End Function

        Public Function GenerarGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision, ByRef dtGREMISION As DataTable) As DataSet

            'Dim objData As New EstructuraDespachos
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim objData As New DataSet

            With obeFiltroGuia

                ' Ingresamos los parametros del Procedure
                objParametros.Add("IN_CCLNT", .PNCCLNT)
                objParametros.Add("IN_CCLNGR", .PNCCLNGR)

                If .PNNROCTL <> 0 Then
                    objParametros.Add("IN_NROCTL", .PNNROCTL)
                Else
                    objParametros.Add("IN_NRGUSA", .PNNRGUSA)
                End If



                objParametros.Add("IN_NGUIRS", .PSNGUIRS)

                objParametros.Add("IN_FGUIRM", .PNFGUIRM)
                objParametros.Add("IN_FINTRA", .PNFINTRA)

                objParametros.Add("IN_SMTGRM", .PSSMTGRM)
                objParametros.Add("IN_TOBORM", .PSTOBORM)

                objParametros.Add("IN_CPLNOR", .PNCPLNOR)
                objParametros.Add("IN_CPLNCL", .PNCPLNCL)
                objParametros.Add("IN_CPRVCL", .PNCPRVCL)
                objParametros.Add("IN_CPLCLP", .PNCPLCLP)

                objParametros.Add("IN_CPRVCO", .PNCPRVCO)
                objParametros.Add("IN_CPLCLO", .PNCPLCLO)

                objParametros.Add("IN_CTRSPT", .PNCTRSPT)
                objParametros.Add("IN_NDCMRF", .PNNDCMRF)

                objParametros.Add("IN_NPLCCM", .PSNPLCCM)
                objParametros.Add("IN_NPLACP", .PSNPLACP)
                objParametros.Add("IN_NBRVCH", .PSNBRVCH)
                objParametros.Add("IN_TOBSRM", .PSTOBSRM)

                objParametros.Add("IN_TOBCLI", .PSTOBCLI)

                objParametros.Add("IN_CMEDTR", .PNCMEDTR) 'Código Medio Transporte Agregado

                

                objParametros.Add("IN_CPRCN1", .PSCPRCN1)
                objParametros.Add("IN_NSRCN1", .PSNSRCN1)
                objParametros.Add("IN_USUARI", obeFiltroGuia.PSUSUARIO)

                'Agregando los datos de referencia de proceso
                objParametros.Add("IN_CLCRGA", .CLCRGA)
                objParametros.Add("IN_UPROGM", .UPROGM)
                objParametros.Add("IN_EMAPRB", .EMAPRB)
                objParametros.Add("IN_USLCNT", .USLCNT)
                objParametros.Add("IN_APRBDO", .APRBDO)
                objParametros.Add("IN_GRENCI", .GRENCI)
                objParametros.Add("IN_AREASL", .AREASL)

                objParametros.Add("IN_SERIEGR", .SERIEGR)
                objParametros.Add("IN_CCMPN", .PSCCMPN)
                objParametros.Add("IN_CDVSN", .PSCDVSN)

                objParametros.Add("IN_CTDGRM", .PSCTDGRM)

                objParametros.Add("IN_CUBGET", .PNCUBGET)


            End With

            'ANTES DEL CAMBIO
            'If obeFiltroGuia.PNNROCTL <> 0 Then
            '    objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_PREDESPACHO", objParametros)
            'Else
            '    objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION", objParametros)
            'End If

            'Nuevo Stored
            If obeFiltroGuia.PNNROCTL <> 0 Then
                objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_PREDESPACHO_2", objParametros)
            Else
                'objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_3", objParametros)
                'objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_4", objParametros)
                objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_V5", objParametros)
            End If

            Dim oDtvTemp As DataView = New DataView(objData.Tables(0))
            Dim oTdtGR As New DataTable
            oTdtGR = oDtvTemp.ToTable(True, "NGUIRM", "NGUIRS")
            oTdtGR.TableName = "DT_GR"
            dtGREMISION = oTdtGR.Copy

            objData.Tables(0).TableName = "dtGuiaRemision"
            'Catch ex As Exception
            'End Try
            Return objData
        End Function



        Public Function fdstDataGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim objData As New DataSet
            Dim objParametros As Parameter = New Parameter

            ' Ingresamos los parametros del Procedure

            With obeFiltroGuia
                objParametros.Add("IN_CCLNT", .PNCCLNT)
                objParametros.Add("IN_CCLNGR", .PNCCLNGR)
                objParametros.Add("PSCCMPN", .PSCCMPN)
                objParametros.Add("PSCDVSN", .PSCDVSN)
                objParametros.Add("PNCPLNDV", .PNCPLNDV)
                objParametros.Add("PNNRGUSA", .PNNRGUSA)
                objParametros.Add("IN_NGUIRM", .PSNGUIRM)
                objParametros.Add("IN_NLINGR", .PNNLINGR)
                objParametros.Add("IN_DECONC", .PSDECONC)
                objParametros.Add("IN_MGUIFA", .PSMGUIFA)
                objParametros.Add("IN_MGFFIN", .PSMGFFIN)
                objParametros.Add("IN_MOBSER", .PSMOBSER)
                objParametros.Add("IN_TOXBUL", .PSTOXBUL)

            End With
            objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_IMPRIMIR_GUIA_REMISION", objParametros)
            objData.Tables(0).TableName = "dtGuiaRemision"
          
            Return objData
        End Function

        Public Function fdstDataGuiaRemisionManual(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim objData As New DataSet
            Dim objParametros As Parameter = New Parameter

            ' Ingresamos los parametros del Procedure

            With obeFiltroGuia
                objParametros.Add("IN_CCLNT", .PNCCLNT)
                objParametros.Add("IN_NGUIRM", .PSNGUIRM)
            End With
            objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_IMPRIMIR_GUIA_REMISION_MANUAL", objParametros)
            objData.Tables(0).TableName = "dtGuiaRemision"

       
            Return objData
        End Function


        Public Function fnListGuiasRemisionSAT_PredesPacho(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParam.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParam.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("PNNROCTL", obeFiltroGuia.PNNROCTL)
            Return Listar("SP_SOLMIN_SA_AT_LISTAR_GUIA_REMISION_PREDESPACHO", objParam)
          
        End Function

        Public Function fblnAnularGuiaRemisionSAT_PreDespacho(ByVal obeFiltroGuia As beGuiaRemision) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("IN_NROCTL", obeFiltroGuia.PNNROCTL)
            objParametros.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParametros.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeFiltroGuia.PNCPLNDV)
            objParametros.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_GUIA_REMISION_PREDESPACHO", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAnularGuiaRemisionSAT_PreDespacho >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        Public Function fintActualizarEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = ""
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("IN_NRGUSA", obeFiltroGuia.PSNGUIRM)
            objParametros.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_ESTADO_ENVIO_GUIA", objParametros)
                Return 1
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRestaurarGuiaSalida >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return 0
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function


        Public Function finListaEstadoGuiaRemision() As DataTable

            Dim objSqlManager As SqlManager = New SqlManager

            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim objData As New DataTable


            objData = objSql.ExecuteDataTable("SP_SOLMIN_WEB_ST_LISTA_ESTADO_GR", Nothing)

        
            Return objData
        End Function

        Public Function fstrValidarGuaiRemision(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("PNNRGUSA", obeFiltroGuia.PNNRGUSA)
            objParametros.Add("PSERROR", "", ParameterDirection.Output)

            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_VALIDAR_GUIA_REMISION_EN_TRANSPORTE", objParametros)
            Return objSqlManager.ParameterCollection("PSERROR")
          
        End Function


        Public Function fintActualizarEstadoGuias(ByVal obeFiltroGuia As beGuiaRemision) As Integer

            Dim objSqlManager As SqlManager = New SqlManager

            objSqlManager.TransactionController(TransactionType.Automatic)

            Try

                Dim objParametros As Parameter = New Parameter

                objParametros.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParametros.Add("PNNGUIRM", obeFiltroGuia.PSNGUIRM)
                objParametros.Add("PSSESDCM", obeFiltroGuia.PSSESDCM)

                objSql.ExecuteNonQuery("SP_SOLMIN_SAT_CONFIRMAR_ESTADO_GUIA", objParametros)

            Catch ex As Exception
                Return 0
            End Try
            Return 1
        End Function


        Public Function fdsListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter
            Dim str As String = "SP_SOLMIN_SA_GUIA_REMISION_LIST_EXPORTAR_EXCEL"

            objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            If obeFiltroGuia.PSNGUIRM.Trim.Equals("") Then
                objParam.Add("IN_NGUIRM", 0)
            Else
                objParam.Add("IN_NGUIRM", Val(obeFiltroGuia.PSNGUIRM))
            End If
            objParam.Add("IN_FECINI", obeFiltroGuia.PNFECINI)
            objParam.Add("IN_FECFIN", obeFiltroGuia.PNFECFIN)

            If Not obeFiltroGuia.PSTLUGEN.Trim.Equals("") Then
                objParam.Add("PSTLUGEN", obeFiltroGuia.PSTLUGEN)
                str = "SP_SOLMIN_SA_GUIA_REMISION_LIST_EXPORTAR_EXCEL_LOTE"
            End If

            objParam.Add("PSESTADO", obeFiltroGuia.PSSESDCM)
            Return objSql.ExecuteDataSet(str, objParam)
          
        End Function


        Public Function fdsListGuiasRemision_Detalle(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            If obeFiltroGuia.PSNGUIRM.Trim.Equals("") Then
                objParam.Add("PNNGUIRM", 0)
            Else
                objParam.Add("PNNGUIRM", Val(obeFiltroGuia.PSNGUIRM))
            End If
            objParam.Add("PNFECINI", obeFiltroGuia.PNFECINI)
            objParam.Add("PNFECFIN", obeFiltroGuia.PNFECFIN)
            objParam.Add("PSTLUGEN", obeFiltroGuia.PSTLUGEN)
            objParam.Add("PSESTADO", obeFiltroGuia.PSSESDCM)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_GUIA_REMISION_REPORTE", objParam)
          
        End Function

        Public Function ListarLotes(ByVal intCliente As Integer) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", intCliente)

            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REEMBOLSO_LOTES", lobjParams)
          
            Return dt
        End Function

        Public Function fstrUltimoGuiaRemision(ByVal intCCLNT As Integer) As String
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("IN_CCLNT", intCCLNT)
            objParam.Add("OU_NGUIRM", 0, ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ULTIMO_GUIA_X_CLIENTE", objParam)
            Return objSql.ParameterCollection("OU_NGUIRM")
          
        End Function


        ''' <summary>
        ''' Retorna datos para imprimir guia remision DS
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdsImprimirGuiaRemisionDS(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim objParam As New Parameter
            Dim objData As New DataSet

            objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)

            objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_GUIA_REMISION_IMPRIMIR", objParam)
            objData.Tables(0).TableName = "dtGuiaRemision"
            Return objData
         
        End Function

        Public Function fdstGenerarGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Dim objData As New DataSet
            Dim objParametros As Parameter = New Parameter
            Try
                With obeFiltroGuia
                    objParametros.Add("IN_CCLNT", .PNCCLNT)
                    objParametros.Add("IN_NGUIRN", .PNNGUIRN)
                    objParametros.Add("IN_NGUIRM", .PSNGUIRM)
                    objParametros.Add("IN_FGUIRM", .pstrFechaEmision_FGUIRM)
                    objParametros.Add("IN_FINTRA", .pstrFechaTraslado_FINTRA)
                    objParametros.Add("IN_SMTGRM", .PSSMTGRM)
                    objParametros.Add("IN_TOBORM", .PSTOBORM)
                    objParametros.Add("IN_CPLNOR", .PNCPLNOR)
                    objParametros.Add("IN_CPLNCL", .PNCPLNCL)
                    objParametros.Add("IN_CPRVCL", .PNCPRVCL)
                    objParametros.Add("IN_CPLCLP", .PNCPLCLP)
                    objParametros.Add("IN_CTRSPT", .PNCTRSPT)
                    objParametros.Add("IN_NDCMRF", .PNNDCMRF)
                    objParametros.Add("IN_NPLCCM", .PSNPLCCM)
                    objParametros.Add("IN_NBRVCH", .PSNBRVCH)
                    objParametros.Add("IN_TOBSRM", .PSTOBSRM)
                    objParametros.Add("IN_TOBCLI", .PSTOBCLI)
                    objParametros.Add("IN_TDCFCC", .PNTDCFCC)
                    objParametros.Add("IN_NDCFCC", .PNNDCFCC)
                    objParametros.Add("IN_FDCFCC", .pstrFechaEmisionDocumento_FDCFCC)
                    objParametros.Add("IN_CMEDTR", .PNCMEDTR)
                    objParametros.Add("IN_NLINGR", .PNNLINGR)
                    objParametros.Add("IN_USUARI", .PSUSUARIO)
                    objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_GUIA_REMISION_GENERAR", objParametros)
                End With
                Return 1
            Catch ex As Exception
                'Throw New Exception(ex.ToString())
                Return 0
            End Try
        End Function

        ''' <summary>
        ''' Guardar Guia remisión Manual
        ''' </summary>
        ''' <param name="obeListObservacion"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fintInsertarObsebacionGuiaRemision(ByVal obeListObservacion As List(Of beGuiaRemision)) As Integer
            'Dim objData As New EstructuraDespachos
            Dim objSqlManager As SqlManager = New SqlManager
            Dim retorno As Integer = -1
            'Try
            For Each obeObservacion As beGuiaRemision In obeListObservacion
                Dim objParametros As Parameter = New Parameter
                With obeObservacion
                    ' Ingresamos los parametros del Procedure
                    objParametros.Add("IN_CCLNGR", .PNCCLNGR)
                    objParametros.Add("IN_NGUIRM", .PSNGUIRM)

                    objParametros.Add("IN_NGUIRS", .PSNGUIRS)

                    objParametros.Add("IN_TOBSGS", .PSTOBDGS)
                    objParametros.Add("IN_USUARIO", .PSUSUARIO)
                    objParametros.Add("IN_NTRMNL", .PSNTRMNL)
                End With
                'objSql.ExecuteNonQuery("SP_SOLMIN_SA_INSERTAR_OBSERVACION_GUIA_REMISION", objParametros)
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_INSERTAR_OBSERVACION_GUIA_REMISION_V2", objParametros)
            Next
            retorno = 1
            Return retorno
            '    Return 1
            'Catch ex As Exception
            '    Return -1
            'End Try

        End Function



#Region "Guia Manual"

        ''' <summary>
        ''' Generar Guia remision manual
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdsGenerarGuiaRemisionManual(ByVal obeFiltroGuia As beGuiaRemision) As Integer

            'Dim objData As New EstructuraDespachos
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                With obeFiltroGuia
                    ' Ingresamos los parametros del Procedure
                    'objParametros.Add("IN_CCLNT", .PNCCLNT)
                    objParametros.Add("IN_CCLNGR", .PNCCLNGR)
                    objParametros.Add("IN_NGUIRM", .PSNGUIRM)
                    objParametros.Add("IN_FGUIRM", .PNFGUIRM)
                    objParametros.Add("IN_FINTRA", .PNFINTRA)
                    objParametros.Add("IN_SMTGRM", .PSSMTGRM)
                    objParametros.Add("IN_TOBORM", .PSTOBORM)
                    objParametros.Add("IN_CPLNOR", .PNCPLNOR)
                    objParametros.Add("IN_CPLNCL", .PNCPLNCL)
                    objParametros.Add("IN_CPRVCL", .PNCPRVCL)
                    objParametros.Add("IN_CPLCLP", .PNCPLCLP)
                    objParametros.Add("IN_CPRVCO", .PNCPRVCO)
                    objParametros.Add("IN_CPLCLO", .PNCPLCLO)
                    objParametros.Add("IN_CTRSPT", .PNCTRSPT)
                    objParametros.Add("IN_NDCMRF", .PNNDCMRF)
                    objParametros.Add("IN_NPLCCM", .PSNPLCCM)
                    objParametros.Add("IN_NPLACP", .PSNPLACP)
                    objParametros.Add("IN_NBRVCH", .PSNBRVCH)
                    objParametros.Add("IN_TOBSRM", .PSTOBSRM)
                    objParametros.Add("IN_TOBCLI", .PSTOBCLI)

                    objParametros.Add("IN_CMEDTR", .PNCMEDTR) 'Código Medio Transporte Agregado
                    objParametros.Add("IN_NLINGR", .PNNLINGR)
                    objParametros.Add("IN_DECONC", .PSDECONC)
                    objParametros.Add("IN_MGUIFA", .PSMGUIFA)
                    objParametros.Add("IN_MGFFIN", .PSMGFFIN)
                    objParametros.Add("IN_MOBSER", .PSMOBSER)
                    objParametros.Add("IN_TOXBUL", .PSTOXBUL)
                    objParametros.Add("IN_CPRCN1", .PSCPRCN1)
                    objParametros.Add("IN_NSRCN1", .PSNSRCN1)
                    objParametros.Add("IN_NRFTPD", .PSNRFTPD)
                    objParametros.Add("IN_NRFRPD", .PSNRFRPD)

                    objParametros.Add("IN_TDCFCC", .PNTDCFCC)
                    objParametros.Add("IN_NDCFCC", .PNNDCFCC)
                    objParametros.Add("IN_FDCFCC", .PNFDCFCC)
                    objParametros.Add("IN_USUARI", .PSUSUARIO)
                End With
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_MANUAL", objParametros)
                Return 1
            Catch ex As Exception
                Return -1
            End Try

        End Function

        Public Function fdsGenerarGuiaRemisionManualDetalle(ByVal obeFiltroGuia As beGuiaRemision) As Decimal
            Dim objParametros As Parameter = New Parameter
            Try
                With obeFiltroGuia
                    ' Ingresamos los parametros del Procedure
                    objParametros.Add("IN_CCLNT", .PNCCLNT)
                    objParametros.Add("IN_NGUIRM", .PSNGUIRM)
                    'objParametros.Add("NCRRGR", .PNNCRRGR)
                    objParametros.Add("IN_NSLCSR", .PNNSLCSR)
                    objParametros.Add("IN_TDITEM", .PSTDITEM)
                    objParametros.Add("IN_QCNGU", .PNQCNGU)
                    objParametros.Add("IN_CUNCN", .PSCUNCN)
                    objParametros.Add("IN_QPSGU", .PNQPSGU)
                    objParametros.Add("IN_CUNPS ", .PSCUNPS)
                    objParametros.Add("IN_TOBDGS ", .PSTOBDGS)
                    objParametros.Add("IN_NORCML ", .PSNORCML)
                    objParametros.Add("IN_CMRCLR ", .PSCMRCLR)
                    objParametros.Add("IN_CSRECL ", .PSCSRECL)
                    objParametros.Add("IN_USUARI", .PSUSUARIO)
                End With
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_GENERAR_GUIA_REMISION_MANUAL_DETALLE", objParametros)
                Return 1
            Catch ex As Exception
                Return -1
            End Try

        End Function

        Public Function fintRollbackGuiaRemisionManual(ByVal obeGuiaRemisionCab As beGuiaRemision) As Integer
            Dim strError As String = String.Empty
            'Dim objData As New EstructuraDespachos
            Dim objParametros As Parameter = New Parameter
            Try
                With obeGuiaRemisionCab
                    ' Ingresamos los parametros del Procedure
                    objParametros.Add("IN_CCLNGR", .PNCCLNGR)
                    objParametros.Add("IN_NGUIRM", .PSNGUIRM)
                End With
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_Rollback_GUIA_REMISION_manual", objParametros)

            Catch ex As Exception
                Return -1
            End Try
            Return 1
        End Function

#End Region
        Public Overrides Sub SetStoredprocedures()

        End Sub

        Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beGuiaRemision)

        End Sub

        'Public Function cambiarNumeroGuia(ByVal obeFiltroGuia As beGuiaRemision) As String
        '    Dim objParam As New Parameter
        '    Dim srtMessage As String = "Error"
        '    'Try
        '    objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
        '    objParam.Add("PNNGUIRM", obeFiltroGuia.PSNGUIRM)
        '    objParam.Add("PNNGUIRO", obeFiltroGuia.PNNGUIRO)
        '    objParam.Add("PSMESSAGE", "", ParameterDirection.Output)
        '    objSql.ExecuteDataSet("SP_SOLMIN_SA_SAT_CAMBIAR_NGUIA", objParam)
        '    srtMessage = objSql.ParameterCollection("PSMESSAGE")
        '    Return srtMessage
        '    'Catch ex As Exception
        '    '    Return srtMessage
        '    'End Try
        'End Function

        Public Function cambiarNumeroGuia_s(ByVal obeFiltroGuia As beGuiaRemision) As String
            Dim objParam As New Parameter
            'Dim srtMessage As String = "Error"
            Dim dt As New DataTable
            Dim msg As String = ""

            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("PSCTDGRM", obeFiltroGuia.PSCTDGRM)
            objParam.Add("PSNGUIRM", obeFiltroGuia.PSNGUIRM)
            objParam.Add("PNNGUIRO", obeFiltroGuia.PNNGUIRO)
            objParam.Add("PSCULUSA", obeFiltroGuia.PSCULUSA)


            dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_CAMBIAR_NGUIA_S", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim

            Return msg
           
        End Function



        Public Function fdtGuiaRemisionParaExportarTxt(ByVal obeFiltroGuia As beGuiaRemision) As DataSet
            Dim objParam As New Parameter


            objParam.Add("PSCCMPN", obeFiltroGuia.PSCCMPN)
            objParam.Add("PSCDVSN", obeFiltroGuia.PSCDVSN)
            objParam.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParam.Add("PNNGUIRM", obeFiltroGuia.PSNGUIRM)

            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_GUIA_REMISION_PARA_EXPORTAR_TXT", objParam)
           
        End Function

        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-INICIO
        Public Function fnListValidarGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PSCCLNT", obeFiltroGuia.PNCCLNT)
            objParam.AddString("PSNGUIRM", obeFiltroGuia.PSNGUIRM)

            ' Return TraerDataTable("SP_SOLMIN_SA_VALIDA_GUIA_PACASMAYO", objParam)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDA_GUIA_PACASMAYO_LIST", objParam)
          
        End Function

        'CSR-HUNDRED-SGR-DAS-DMA-PMO-001-FIN

        Public Function fdstListaParametroGuiaRemision(ByVal CCMPN As String, ByVal CCLNT As Decimal, ByVal TIPO_ALMACEN As String) As DataTable
            Dim objData As New DataTable
            Dim objParam As Parameter = New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PNCCLNT", CCLNT)
            objParam.Add("PSTIPO_ALM", TIPO_ALMACEN)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_PARAM_FORMATO_GUIA_REMISION", objParam)
            Return objData
        End Function


        Public Function fdstListaSerieGR_x_Cliente(ByVal CCMPN As String, CDVSN As String, ByVal CCLNT As Decimal) As DataTable
            Dim objData As New DataTable
            Dim objParam As Parameter = New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCDVSN", CDVSN)
            objParam.Add("PNCCLNT", CCLNT)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_TIPO_SERIE_GR", objParam)
            Return objData
        End Function


        Public Function Validar_Registro_GR_Cliente_Electronico(ByVal CCMPN As String, CDVSN As String, ByVal CCLNT As Decimal) As String
            Dim objData As New DataTable
            Dim objParam As Parameter = New Parameter
            objParam.Add("PSCCMPN", CCMPN)
            objParam.Add("PSCDVSN", CDVSN)
            objParam.Add("PNCCLNT", CCLNT)
            Dim msg As String = ""
            objData = objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_VALIDAR_EMISION_GR", objParam)
            For Each item As DataRow In objData.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(10)
                End If
            Next
            msg = msg.Trim
            Return msg
        End Function


        Public Function Listar_Ubigeo() As DataTable
            Dim objData As New DataTable
            Dim objParam As Parameter = New Parameter          
            Dim msg As String = ""
            objData = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_UBIGEO", objParam)
            Return objData
        End Function


        ' JOSE LOAYZA
        Public Sub fintActualizarEstadoEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision, estado As String, mensaje As String, usuario As String, TipoEnvio As String)

            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter

            objParametros.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("PNNGUIRM", obeFiltroGuia.PSNGUIRM)
            objParametros.Add("PSNGUIRS", obeFiltroGuia.PSNGUIRS)
            objParametros.Add("PSESTADO", estado)
            objParametros.Add("PSMSGENVIO", mensaje)
            objParametros.Add("PSUSUARIO", usuario)
            objParametros.Add("PSTIPOENVIO", TipoEnvio)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_ESTADO_ENVIO_EMISION_GUIA_CLIENTE", objParametros)

        End Sub

        Public Sub fintRegularizarEstadoEnvioGuias(ByVal obeFiltroGuia As beGuiaRemision, usuario As String)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objParametros.Add("PNCCLNT", obeFiltroGuia.PNCCLNT)
            objParametros.Add("PNNGUIRM", obeFiltroGuia.PNNGUIRN)
            objParametros.Add("PSNGUIRS", obeFiltroGuia.PSNGUIRS)
            objParametros.Add("PSUSUARIO", usuario)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGULARIZAR_ESTADO_ENVIO_EMISION_GR", objParametros)

        End Sub

        Public Function Listar_Datos_GuiaTransito_Pacasmayo(ByVal intCliente As Decimal, ByVal NGUIRM As Decimal, ByVal NGUIRS As String) As DataSet

            Dim objData As New DataSet
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", intCliente)
            lobjParams.Add("PNGUIRM", NGUIRM)
            lobjParams.Add("PNGUIRS", NGUIRS)
            objData = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_DATOS_GUIA_TRANSITO_PACASMAYO", lobjParams)
            Return objData

        End Function

        Public Function Listar_GuiaTransito_Pacasmayo_Anulacion(ByVal intCliente As Decimal, ByVal NGUIRM As Decimal, ByVal NGUIRS As String) As DataTable

            Dim objData As New DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", intCliente)
            lobjParams.Add("PNGUIRM", NGUIRM)
            lobjParams.Add("PNGUIRS", NGUIRS)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_DATOS_ANULACION_GUIA_TRANSITO_PACASMAYO", lobjParams)
            Return objData

        End Function

        Public Function Listar_Url_Envio_Guia(ByVal CCLNT As Decimal, pProceso As String, pSubProceso As String) As DataTable
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PNCCLNT", CCLNT)
            lobjParams.Add("PSTIPPROC", pProceso)
            lobjParams.Add("PSSUBPROC", pSubProceso)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_URL_ENVIO_GUIA_REMISION", lobjParams)

            Return dt
        End Function
        Public Function fnValidarCLienteEnvioGuia(ByVal obeFiltroGuia As beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter

            objParam.Add("PSCCLNT", obeFiltroGuia.PNCCLNT)
            Dim dt As New DataTable
            dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_CLIENTE_ENVIO_GUIA_CLIENTE", objParam)
            Return dt
         
        End Function





    End Class
End Namespace

