Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
''' <summary>
''' Dagnino 09/25/2015
''' </summary>
''' <remarks></remarks>
Public Class daDespacho
    Inherits daBase(Of beDespacho)

    Private objSql As New SqlManager

    Public Function ListarDespachoPorPedido(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim oDt As New DataTable
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
        objParam.Add("PSCTPDP6", opbeDespacho.PSCTPDP6)

        'If Not opbeDespacho.PSNRFRPD.Trim.Equals("") Or Not opbeDespacho.PSCMRCLR.Trim.Equals("") Or Not opbeDespacho.PSTMRCD2.Trim.Equals("") Then
        objParam.Add("PSNRFRPD", opbeDespacho.PSNRFRPD)
        objParam.Add("PSCMRCLR", opbeDespacho.PSCMRCLR)
        objParam.Add("PSTMRCD2", opbeDespacho.PSTMRCD2)
        'End If
        objParam.Add("PNCDPEPL", opbeDespacho.PNCDPEPL)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_DEPACHO_X_PEDIDO", objParam)


        For Each objDataRow As DataRow In oDt.Rows
            Dim obeDespacho As New beDespacho
            obeDespacho.CLIENTE = opbeDespacho.PNCCLNT
            obeDespacho.TIPODEPOSITO = opbeDespacho.PSCTPDP6
            obeDespacho.PNCCLNT = objDataRow("CCLNT").ToString.Trim
            obeDespacho.PNCPLNCL = objDataRow("CPLNCL").ToString.Trim
            obeDespacho.PSTCMPPL = objDataRow("TCMPPL").ToString.Trim
            obeDespacho.PSTDRCPL = objDataRow("TDRCPL").ToString.Trim
            obeDespacho.PNQPLANTA = objDataRow("QPLANTA").ToString.Trim
            obeDespacho.PSDESCLI = objDataRow("DESCLI").ToString.Trim
            obeDespacho.PSSTPORL = objDataRow("STPORL").ToString.Trim

            olbebeDespacho.Add(obeDespacho)
        Next
        'Catch ex As Exception
        '    olbebeDespacho.Clear()
        'End Try
        Return olbebeDespacho
    End Function

    Public Function ListaPedidoPendientePorCliente(ByVal pobeDespacho As beDespacho) As List(Of bePedidoPorPlanta)
        Dim oDt As New DataTable
        Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
        Dim objParam As New Parameter
        'Try
        'IN PNCCLNT  NUMERIC(6), --CLIENTE
        'IN PSCTPDP6 VARCHAR(2), --TIPO

        'IN PNCPLCLP NUMERIC(6), --PLANTA
        'IN PNCPRVCL NUMERIC(6) --CLIENTE TERCERO
        'PEDPLAN.CDPEPL,FCHSPE, FDSPAL,NRFRPD ,PEDPLAN.TOBSMD
        objParam.Add("PNCCLNT", pobeDespacho.PNCCLNT)
        objParam.Add("PSCTPDP6", pobeDespacho.PSCTPDP6)
        objParam.Add("PNCPLCLP", pobeDespacho.PNCPRVCL)
        objParam.Add("PNCPRVCL", IIf(pobeDespacho.PNCPLCLP = pobeDespacho.PNCCLNT, 0, pobeDespacho.PNCPLCLP))
        objParam.Add("PNCDPEPL", pobeDespacho.PNCDPEPL)
        objParam.Add("PNNRFRPD", pobeDespacho.PSNRFRPD)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_PEDIDOS_PENDIENTE_X_CLIENTE", objParam)
        For Each objDataRow As DataRow In oDt.Rows
            Dim obePedidoPorPlanta As New bePedidoPorPlanta
            obePedidoPorPlanta.PNCDPEPL = objDataRow("CDPEPL").ToString.Trim
            obePedidoPorPlanta.PNFCHSPE = objDataRow("FCHSPE").ToString.Trim
            obePedidoPorPlanta.PNFDSPAL = objDataRow("FDSPAL").ToString.Trim
            obePedidoPorPlanta.PSNRFRPD = objDataRow("NRFRPD").ToString.Trim.ToString.Trim.Replace("-", "")
            obePedidoPorPlanta.PSTOBSMD = objDataRow("TOBSMD").ToString.Trim
            obePedidoPorPlanta.CANTIDAD = objDataRow("CANTIDAD").ToString.Trim
            obePedidoPorPlanta.PSSESTRG = objDataRow("SESTRG").ToString.Trim
            obePedidoPorPlanta.PNNDCFCC = objDataRow("NDCFCC").ToString.Trim
            obePedidoPorPlanta.PSNRFTPD = objDataRow("NRFTPD").ToString.Trim
            obePedidoPorPlanta.PSNRFRPD1 = objDataRow("NRFRPD").ToString.Trim
            obePedidoPorPlanta.PSNORCML = objDataRow("NORCML").ToString.Trim
            olbePedidoPorPlanta.Add(obePedidoPorPlanta)
        Next
        'Catch ex As Exception
        '    olbePedidoPorPlanta.Clear()
        'End Try
        Return olbePedidoPorPlanta
    End Function

    Public Function ListaDespachoMercaderiaPorClientePorPlanta(ByVal pobeDespacho As bePedidoPorPlanta) As List(Of bePedidoPorPlanta)
        Dim oDt As New DataTable
        Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", pobeDespacho.PNCCLNT)
        objParam.Add("PSCTPDP6", pobeDespacho.PSCTPDP6)
        objParam.Add("PNCPLCLP", pobeDespacho.PNCPLCLP)
        objParam.Add("PNCPRVCL", IIf(pobeDespacho.PNCPRVCL = pobeDespacho.PNCCLNT, 0, pobeDespacho.PNCPRVCL))
        objParam.Add("PNCDPEPL", pobeDespacho.PNCDPEPL)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_DESPACHO_MERCADERIA", objParam)

        For Each objDataRow As DataRow In oDt.Rows
            Dim obePedidoPorPlanta As New bePedidoPorPlanta
            obePedidoPorPlanta.PNCDPEPL = pobeDespacho.PNCDPEPL
            obePedidoPorPlanta.PNCDREGP = objDataRow("CDREGP").ToString.Trim
            obePedidoPorPlanta.PSCMRCLR = objDataRow("CMRCLR").ToString.Trim
            obePedidoPorPlanta.PSTMRCD2 = objDataRow("TMRCD2").ToString.Trim
            obePedidoPorPlanta.PNFCHSPE = objDataRow("FCHSPE").ToString.Trim
            obePedidoPorPlanta.PNFDSPAL = objDataRow("FDSPAL").ToString.Trim
            obePedidoPorPlanta.PNQSRVC = objDataRow("QSRVC").ToString.Trim
            obePedidoPorPlanta.PSCUNCN6 = objDataRow("CUNCN6").ToString.Trim
            obePedidoPorPlanta.PSSBCKRD = objDataRow("SBCKRD").ToString.Trim
            obePedidoPorPlanta.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
            obePedidoPorPlanta.PSDESPROV = objDataRow("DESPROV").ToString.Trim
            obePedidoPorPlanta.PNPSRVC = objDataRow("PSRVC").ToString.Trim
            obePedidoPorPlanta.PSCUNPS6 = objDataRow("CUNPS6").ToString.Trim
            obePedidoPorPlanta.PNNORDSR = objDataRow("NORDSR").ToString.Trim
            obePedidoPorPlanta.PNQSLMC = objDataRow("QSLMC").ToString.Trim
            obePedidoPorPlanta.PNQSLMP = objDataRow("QSLMP").ToString.Trim
            obePedidoPorPlanta.PNQSLMV = objDataRow("QSLMV").ToString.Trim
            obePedidoPorPlanta.PNNCNTR = objDataRow("NCNTR").ToString.Trim
            obePedidoPorPlanta.PSCMRCD = objDataRow("CMRCD").ToString.Trim
            obePedidoPorPlanta.PSCUNCN5 = objDataRow("CUNCN5").ToString.Trim
            obePedidoPorPlanta.PSCUNPS5 = objDataRow("CUNPS5").ToString.Trim
            obePedidoPorPlanta.PSCUNVL5 = objDataRow("CUNVL5").ToString.Trim
            obePedidoPorPlanta.PNNCRCTC = objDataRow("NCRCTC").ToString.Trim
            obePedidoPorPlanta.PNNAUTR = objDataRow("NAUTR").ToString.Trim
            obePedidoPorPlanta.PSFUNDS2 = objDataRow("FUNDS2").ToString.Trim
            obePedidoPorPlanta.PSCTPDP6 = objDataRow("CTPDP6").ToString.Trim
            obePedidoPorPlanta.QPENDIN = objDataRow("QPENDIN").ToString.Trim
            obePedidoPorPlanta.PPENDIN = objDataRow("PPENDIN").ToString.Trim
            obePedidoPorPlanta.PNCANTIDAD = objDataRow("QPENDIN").ToString.Trim
            obePedidoPorPlanta.PNSALDO = objDataRow("SALDO").ToString.Trim
            obePedidoPorPlanta.PSSCNTSR = objDataRow("SCNTSR").ToString.Trim

            obePedidoPorPlanta.PSNORCML = objDataRow("NORCML").ToString.Trim
            obePedidoPorPlanta.PNNRITOC = objDataRow("NRITOC").ToString.Trim

            obePedidoPorPlanta.PSTOBSMD = objDataRow("TOBSMD").ToString.Trim
            obePedidoPorPlanta.PSNLTECL = objDataRow("NLTECL").ToString.Trim
            obePedidoPorPlanta.PSFUNCTL = objDataRow("FUNCTL").ToString.Trim
            obePedidoPorPlanta.PSNRFRPD = objDataRow("NRFTPD").ToString.Trim

            olbePedidoPorPlanta.Add(obePedidoPorPlanta)
        Next
        'Catch ex As Exception
        '    olbePedidoPorPlanta.Clear()
        'End Try
        Return olbePedidoPorPlanta
    End Function

    Public Function ListaDespachoMercaderiaPorClientePorPlanta_V2(ByVal pobeDespacho As bePedidoPorPlanta) As List(Of bePedidoPorPlanta)
        Dim oDt As New DataTable
        Dim olbePedidoPorPlanta As New List(Of bePedidoPorPlanta)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", pobeDespacho.PNCCLNT)
        objParam.Add("PSCTPDP6", pobeDespacho.PSCTPDP6)
        objParam.Add("PNCPLCLP", pobeDespacho.PNCPLCLP)
        objParam.Add("PNCPRVCL", IIf(pobeDespacho.PNCPRVCL = pobeDespacho.PNCCLNT, 0, pobeDespacho.PNCPRVCL))
        objParam.Add("PNCDPEPL", pobeDespacho.PNCDPEPL)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_DESPACHO_MERCADERIA_V2", objParam)

        For Each objDataRow As DataRow In oDt.Rows
            Dim obePedidoPorPlanta As New bePedidoPorPlanta
            obePedidoPorPlanta.PNCDPEPL = pobeDespacho.PNCDPEPL
            obePedidoPorPlanta.PNCDREGP = objDataRow("CDREGP").ToString.Trim
            obePedidoPorPlanta.PSCMRCLR = objDataRow("CMRCLR").ToString.Trim
            obePedidoPorPlanta.PSTMRCD2 = objDataRow("TMRCD2").ToString.Trim
            obePedidoPorPlanta.PNFCHSPE = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(objDataRow("FCHSPE").ToString.Trim)
            obePedidoPorPlanta.PNFDSPAL = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(objDataRow("FDSPAL").ToString.Trim)
            obePedidoPorPlanta.PNQSRVC = objDataRow("QSRVC").ToString.Trim
            obePedidoPorPlanta.PSCUNCN6 = objDataRow("CUNCN6").ToString.Trim
            obePedidoPorPlanta.PSSBCKRD = objDataRow("SBCKRD").ToString.Trim
            obePedidoPorPlanta.PNCPRVCL = objDataRow("CPRVCL").ToString.Trim
            obePedidoPorPlanta.PSDESPROV = objDataRow("DESPROV").ToString.Trim
            obePedidoPorPlanta.PNPSRVC = objDataRow("PSRVC").ToString.Trim
            obePedidoPorPlanta.PSCUNPS6 = objDataRow("CUNPS6").ToString.Trim
            obePedidoPorPlanta.PNNORDSR = objDataRow("NORDSR").ToString.Trim
            obePedidoPorPlanta.PNQSLMC = objDataRow("QSLMC").ToString.Trim
            obePedidoPorPlanta.PNQSLMP = objDataRow("QSLMP").ToString.Trim
            obePedidoPorPlanta.PNQSLMV = objDataRow("QSLMV").ToString.Trim
            obePedidoPorPlanta.PNNCNTR = objDataRow("NCNTR").ToString.Trim
            obePedidoPorPlanta.PSCMRCD = objDataRow("CMRCD").ToString.Trim
            obePedidoPorPlanta.PSCUNCN5 = objDataRow("CUNCN5").ToString.Trim
            obePedidoPorPlanta.PSCUNPS5 = objDataRow("CUNPS5").ToString.Trim
            obePedidoPorPlanta.PSCUNVL5 = objDataRow("CUNVL5").ToString.Trim
            obePedidoPorPlanta.PNNCRCTC = objDataRow("NCRCTC").ToString.Trim
            obePedidoPorPlanta.PNNAUTR = objDataRow("NAUTR").ToString.Trim
            obePedidoPorPlanta.PSFUNDS2 = objDataRow("FUNDS2").ToString.Trim
            obePedidoPorPlanta.PSCTPDP6 = objDataRow("CTPDP6").ToString.Trim
            obePedidoPorPlanta.QPENDIN = objDataRow("QPENDIN").ToString.Trim
            obePedidoPorPlanta.PPENDIN = objDataRow("PPENDIN").ToString.Trim
            obePedidoPorPlanta.PNCANTIDAD = objDataRow("QPENDIN").ToString.Trim
            obePedidoPorPlanta.PNSALDO = objDataRow("SALDO").ToString.Trim
            obePedidoPorPlanta.PSSCNTSR = objDataRow("SCNTSR").ToString.Trim

            obePedidoPorPlanta.PSNORCML = objDataRow("NORCML").ToString.Trim
            obePedidoPorPlanta.PNNRITOC = objDataRow("NRITOC").ToString.Trim

            obePedidoPorPlanta.PSTOBSMD = objDataRow("TOBSMD").ToString.Trim
            obePedidoPorPlanta.PSNLTECL = objDataRow("NLTECL").ToString.Trim
            obePedidoPorPlanta.PSFUNCTL = objDataRow("FUNCTL").ToString.Trim
            obePedidoPorPlanta.PSNRFRPD = objDataRow("NRFTPD").ToString.Trim
            obePedidoPorPlanta.PSFUBICAC = objDataRow("FUBICAC").ToString.Trim
            '
            olbePedidoPorPlanta.Add(obePedidoPorPlanta)
        Next
        'Catch ex As Exception
        '    olbePedidoPorPlanta.Clear()
        'End Try
        Return olbePedidoPorPlanta
    End Function


    Public Function AnularPedidoMercaderiaPorClientePorPlanta(ByVal pobeDespacho As bePedidoPorPlanta) As Integer
        Dim intResultado As Integer = 1
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", pobeDespacho.PNCCLNT)
        objParam.Add("PSCTPDP6", pobeDespacho.PSCTPDP6)
        objParam.Add("PNCPLCLP", pobeDespacho.PNCPLCLP)
        objParam.Add("PNCPRVCL", IIf(pobeDespacho.PNCPRVCL = pobeDespacho.PNCCLNT, 0, pobeDespacho.PNCPRVCL))
        objParam.Add("PNCDPEPL", pobeDespacho.PNCDPEPL)
        objParam.Add("PSCULUSA", pobeDespacho.PSCULUSA)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_PEDIDO_MERCADERIA", objParam)

        'Catch ex As Exception
        '    intResultado = 0
        'End Try
        Return intResultado
    End Function

    Public Function AnularDespachoMercaderiaPorClientePorPlanta(ByVal pobeDespacho As bePedidoPorPlanta) As Integer
        Dim objParam As New Parameter
        Dim intResultado As Integer = 1
        Try
            objParam.Add("PNCDPEPL", pobeDespacho.PNCDPEPL)
            objParam.Add("PNCDREGP", pobeDespacho.PNCDREGP)
            objParam.Add("PSCULUSA", pobeDespacho.PSCULUSA)
            objParam.Add("PNFULTAC", pobeDespacho.PNFULTAC_Con_Formato_AAAAMMDD)
            objParam.Add("PNHULTAC", pobeDespacho.PNHULTAC_Con_Formato_HHMMSS)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_DESPACHO_MERCADERIA", objParam)
        Catch ex As Exception
            intResultado = 0
        End Try
        Return intResultado
    End Function

    Public Function GuardarPedidoPlanta(ByVal polbePedidoPlanta As List(Of bePedidoPorPlanta)) As Double
        Dim objParam As New Parameter
        Dim intResultado As Double = 1
        Dim dblCodPedido As Double = 0
        Try
            objParam.Add("PNCCLNT", polbePedidoPlanta.Item(0).PNCCLNT)
            objParam.Add("PSNRFTPD", polbePedidoPlanta.Item(0).PSNRFTPD)
            objParam.Add("PSNRFRPD", polbePedidoPlanta.Item(0).PSNRFRPD)
            objParam.Add("PNCDPEPL", 0, ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_OBTENER_NUMERO_PEDIDO", objParam)
            dblCodPedido = objSql.ParameterCollection("PNCDPEPL")
            intResultado = dblCodPedido
            For Each obePedidoPlanta As bePedidoPorPlanta In polbePedidoPlanta
                objParam = New Parameter
                objParam.Add("PNCDPEPL", dblCodPedido)
                objParam.Add("PNNORDSR", obePedidoPlanta.PNNORDSR)
                objParam.Add("PSCMRCLR", obePedidoPlanta.PSCMRCLR)
                objParam.Add("PNFCHSPE,", Convert.ToDecimal(obePedidoPlanta.PNFCHSPE))
                objParam.Add("PNHRASPE", obePedidoPlanta.PNHRASPE)
                objParam.Add("PNCCLNT", obePedidoPlanta.PNCCLNT)
                objParam.Add("PNCPLNCL", obePedidoPlanta.PNCPLNCL)
                objParam.Add("PNCPRVCL", obePedidoPlanta.PNCPRVCL)
                objParam.Add("PNCPLCLP", obePedidoPlanta.PNCPLCLP)
                objParam.Add("PNQSRVC", obePedidoPlanta.PNQSRVC)
                objParam.Add("PSCUNCN6", obePedidoPlanta.PSCUNCN6)
                objParam.Add("PNPSRVC", obePedidoPlanta.PNPSRVC)
                objParam.Add("PSCUNPS6", obePedidoPlanta.PSCUNPS6)
                objParam.Add("PNNDCFCC", obePedidoPlanta.PNNDCFCC)
                objParam.Add("PSSATSLS", obePedidoPlanta.PSSATSLS)
                objParam.Add("PSSATNAL", obePedidoPlanta.PSSATNAL)
                objParam.Add("PSNRFTPD", obePedidoPlanta.PSNRFTPD)
                objParam.Add("PSNRFRPD", obePedidoPlanta.PSNRFRPD)
                objParam.Add("PSFLGAPR", obePedidoPlanta.PSFLGAPR)
                objParam.Add("PSFLGURG", obePedidoPlanta.PSFLGURG)
                objParam.Add("PSSBCKRD", obePedidoPlanta.PSSBCKRD)
                objParam.Add("PSNORCML", obePedidoPlanta.PSNORCML)
                objParam.Add("PNFDSPAL", obePedidoPlanta.PNFDSPAL)
                objParam.Add("PSTOBSMD", obePedidoPlanta.PSTOBSMD)
                objParam.Add("PNNRITOC", obePedidoPlanta.PNNRITOC)
                objParam.Add("PSNLTECL", obePedidoPlanta.PSNLTECL)
                objParam.Add("PNNROSEQ", obePedidoPlanta.PNNROSEQ)

                If obePedidoPlanta.PSTCTCST.Trim.Length > 6 Then
                    objParam.Add("PSTCTCST", obePedidoPlanta.PSTCTCST.Substring(0, 6))
                Else
                    objParam.Add("PSTCTCST", obePedidoPlanta.PSTCTCST)
                End If
                objParam.Add("PSARESOL", obePedidoPlanta.PSARESOL.Trim)
                objParam.Add("PSUSRAUT", obePedidoPlanta.PSUSRAUT)
                objParam.Add("FMPDME", obePedidoPlanta.PNFMPDME)

                objParam.Add("PNFULTAC", obePedidoPlanta.PNFULTAC)
                objParam.Add("PNHULTAC", obePedidoPlanta.PNHULTAC)
                objParam.Add("PSCULUSA", obePedidoPlanta.PSCULUSA)
                objParam.Add("PNFCHCRT", obePedidoPlanta.PNFCHCRT)
                objParam.Add("PNHRACRT", obePedidoPlanta.PNHRACRT)
                objParam.Add("PSCUSCRT", obePedidoPlanta.PSCUSCRT)
                objParam.Add("PSSESTRG", obePedidoPlanta.PSSESTRG)
                objParam.Add("PNUPDATE", 1)
                objParam.Add("OUTCDREGP", 0, ParameterDirection.Output)




                objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_INSERTAR_PEDIDO_POR_PLANTA", objParam)

                obePedidoPlanta.PNCDREGP = objSql.ParameterCollection("OUTCDREGP")
                Dim strObs As String = ""
                Dim intCant As Integer = Math.Ceiling(((" " & obePedidoPlanta.PSTOBSGS & "").Trim.Length / 60))

                Dim oObsbePedidoPorPlanta = New bePedidoPorPlanta
                For i As Integer = 0 To intCant - 1
                    oObsbePedidoPorPlanta = New bePedidoPorPlanta
                    oObsbePedidoPorPlanta.PNCDPEPL = dblCodPedido
                    oObsbePedidoPorPlanta.PNCDREGP = obePedidoPlanta.PNCDREGP
                    oObsbePedidoPorPlanta.PNNCRRLT = obePedidoPlanta.PNNCRRLT + 1
                    oObsbePedidoPorPlanta.PSTOBSGS = obePedidoPlanta.PSTOBSGS
                    If intCant = 1 Then
                        oObsbePedidoPorPlanta.PSTOBSGS = obePedidoPlanta.PSTOBSGS.Trim
                    ElseIf (intCant - 1 = i) Then
                        oObsbePedidoPorPlanta.PSTOBSGS = obePedidoPlanta.PSTOBSGS.Trim.Substring(i * 60, obePedidoPlanta.PSTOBSGS.Trim.Length - (i) * 60)
                    Else
                        oObsbePedidoPorPlanta.PSTOBSGS = obePedidoPlanta.PSTOBSGS.Trim.Substring(i * 60, 60)
                    End If

                    oObsbePedidoPorPlanta.PNFULTAC = obePedidoPlanta.PNFULTAC
                    oObsbePedidoPorPlanta.PNFULTAC = obePedidoPlanta.PNFULTAC
                    oObsbePedidoPorPlanta.PSCULUSA = obePedidoPlanta.PSCULUSA
                    If Registro_Observaciones(oObsbePedidoPorPlanta) = 0 Then
                        Return 0
                    End If
                Next
                '  ()
                'FOR EACH obeObsPedido as bePedidoPorPlanta  in 
            Next
        Catch ex As Exception
            intResultado = 0
        End Try
        Return intResultado
    End Function

    Public Function Registro_Observaciones(ByVal obePedidoPorPlanta As bePedidoPorPlanta) As Integer
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter
            objParameter.Add("IN_CDPEPL", obePedidoPorPlanta.PNCDPEPL)
            objParameter.Add("IN_CDREGP", obePedidoPorPlanta.PNCDREGP)
            objParameter.Add("IN_NCRRLT", obePedidoPorPlanta.PNNCRRLT)
            objParameter.Add("IN_TOBSGS", obePedidoPorPlanta.PSTOBSGS)
            objParameter.Add("IN_FULTAC", obePedidoPorPlanta.PNFULTAC)
            objParameter.Add("IN_HULTAC", obePedidoPorPlanta.PNHULTAC)
            objParameter.Add("IN_CULUSA", obePedidoPorPlanta.PSCULUSA)
            objParameter.Add("IN_SESTRG", "A")
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRAR_OBSERVACION_RECEPCION", objParameter)
        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function

    Public Function RestaurarGuiaDeRemisionDSD(ByVal opbeDespacho As beDespacho) As Integer
        Dim oDt As New DataTable
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("IN_USUARIO", opbeDespacho.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_RESTAURAR_GUIA_SALIDA", objParam)
        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function

    Public Function AnularGuiaDeRemisionDSD(ByVal opbeDespacho As beDespacho) As Integer
        Dim oDt As New DataTable
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("IN_USUARIO", opbeDespacho.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_GUIAS_REMISION", objParam)
        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function

    Public Function ListaSerieExportarABB(ByVal pobeSerie As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        Try

            objParam.Add("PNNGUISL", pobeSerie.PNNGUIRN)
            objParam.Add("PNNGUIRM", pobeSerie.PNNGUIRM)
            objParam.Add("PNNORDSR", pobeSerie.PNNORDSR)
            objParam.Add("PNNSLCSS", pobeSerie.PNNSLCSR)
            Return Listar("SP_SOLMIN_SDS_LISTA_SERIE", objParam)
        Catch ex As Exception
            Return olbeDespacho
        End Try

    End Function

    Public Function ListaParaExportarABB(ByVal pobeSerie As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        'Try
        objParam.Add("PNCCLNT", pobeSerie.PNCCLNT)
        objParam.Add("PNNGUIRN", pobeSerie.PNNGUIRN)
        Return Listar("SP_SOLMIN_SA_SDS_LISTADO_PEDIDO_PARA_EXPORTAR", objParam)

        'Catch ex As Exception
        '    Return olbeDespacho
        'End Try

    End Function

    ''' <summary>
    ''' LISTA GUIA REMISION PARA ENVIAR OUTOTEC
    ''' </summary>
    ''' <param name="pobeSerie"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flistListaExportarGuiaManualOutotec(ByVal pobeSerie As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        Try
            objParam.Add("PNCCLNT", pobeSerie.PNCCLNT)
            objParam.Add("PNNGUIRM", pobeSerie.PNNGUIRM)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_GUIA_MANUAL_EXPORTAR", objParam)

        Catch ex As Exception
            Return olbeDespacho
        End Try

    End Function

    Public Function flistListaExportarGuiaOutotec(ByVal pbeFiltro As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        Try
            objParam.Add("PNCCLNT", pbeFiltro.PNCCLNT)
            objParam.Add("PNNGUIRM", pbeFiltro.PNNGUIRM)
            Return Listar("SP_SOLMIN_SA_SDS_LISTADO_GUIA_EXPORTAR", objParam)

        Catch ex As Exception
            Return olbeDespacho
        End Try

    End Function





    Public Function ListaPedidoPendienteEntrega_x_Cliente(ByVal pobeDespacho As beDespacho) As DataSet
        Dim oDS As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", pobeDespacho.PNCCLNT)
            objParam.Add("IN_FECHA_IN", pobeDespacho.PNFECHA_IN)
            objParam.Add("IN_FECHA_FIN", pobeDespacho.PNFECHA_FIN)
            oDS = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTA_PEDIDOS_PENDIENTE_ENTREGA_X_CLIENTE", objParam)
        Catch ex As Exception
            oDS = Nothing
        End Try
        Return oDS
    End Function

    Public Function AnularGuiaDeSalida(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Dim IntEstadoAnulado As Integer = 0
        Try
            objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
            objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_GUIA_SALIDA", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function AnularGuiaDeIngreso(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Dim IntEstadoAnulado As Integer = 0
        Try
            objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
            objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)
            objParam.Add("PNANULADO", 0, ParameterDirection.Output)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_GUIA_INGRESO", objParam)
            IntEstadoAnulado = objSql.ParameterCollection("PNANULADO")
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return IntEstadoAnulado
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function ListaMovimientosPorGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
        objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
        Return Listar("SP_SOLMIN_SDS_LISTA_MOVIMIENTOS_POR_GUIA_RANSA", objParam)
        'Catch ex As Exception
        '    Return Nothing
        'End Try
    End Function



    Public Function flstListaItemsXGuiaRansaDespacho(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
            Return Listar("SP_SOLMIN_SDS_LISTA_MOVIMIENTOS_POR_GUIA_RANSA_DESPACHO", objParam)
        Catch ex As Exception
            Return New List(Of beDespacho)
        End Try
    End Function

    Public Function AnularMovimientoGuiaIngreso(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        'Dim IntEstadoAnulado As Integer = 0
        Dim IntEstadoAnulado As Integer = -1
        'Try
        objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
        objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
        objParam.Add("PNNORDSR", opbeDespacho.PNNORDSR)
        objParam.Add("PNNSLCSR", opbeDespacho.PNNSLCSR)
        objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
        objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)
        objParam.Add("PNANULADO", 0, ParameterDirection.Output)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_MOVIMIENTO_GUIA_INGRESO", objParam)
        IntEstadoAnulado = objSql.ParameterCollection("PNANULADO")
        'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
        Return IntEstadoAnulado
        'Catch ex As Exception
        '    Return -1
        'End Try
    End Function

    Public Function AnularMovimientoGuiaSalida(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Dim IntEstadoAnulado As Integer = 0
        Dim retorno As Integer = 0
        'Try
        objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
        objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
        objParam.Add("PNNORDSR", opbeDespacho.PNNORDSR)
        objParam.Add("PNNSLCSR", opbeDespacho.PNNSLCSR)
        objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
        objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_MOVIMIENTO_GUIA_SALIDA", objParam)
        retorno = 1
        Return retorno
        'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
        'Return 1
        'Catch ex As Exception
        '    Return -1
        'End Try
    End Function

    Public Function intRevertirMovimientoGuiaIngreso(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Dim IntEstadoAnulado As Integer = 0
        Try
            objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("PNNORDSR", opbeDespacho.PNNORDSR)
            objParam.Add("PNNSLCSR", opbeDespacho.PNNSLCSR)
            objParam.Add("PNQREMC", opbeDespacho.PNQREMC)
            objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
            objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)


            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_INGRESO", objParam)

            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intRevertirMovimientoGuiaIngresoKardex(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            objParam.Add("PSCZNALM", obeMercaderia.PSCZNALM)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PNNDTDTK", obeMercaderia.PNNDTDTK)
            objParam.Add("PNNSLCSR", obeMercaderia.PNNSLCSR)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
          
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_INGRESO_KARDEX", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intRevertirMovimientoGuiaIngresoSeriesIng(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSCSRECL", obeMercaderia.PSCSRECL)
            objParam.Add("PNNCRPLL", obeMercaderia.PNNCRPLL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_INGRESO_SERIES", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intRevertirMovimientoGuiaIngresoUbicacion(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try

            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSCSECTR", obeMercaderia.PSCSECTR)
            objParam.Add("PSCPSCN", obeMercaderia.PSCPSCN)
            objParam.Add("PNNCRRIN", obeMercaderia.PNNCRRIN)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_INGRESO_UBICACION", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intRevertirMovimientoGuiaIngresoLote(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try

            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PNNCRRIN", obeMercaderia.PNNCRRIN)
            objParam.Add("PNNCRRSL", obeMercaderia.PNNCRRSL)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_INGRESO_LOTE", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function intRevertirMovimientoGuiaSalidaLote(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try

            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PNNCRRIN", obeMercaderia.PNNCRRIN)
            objParam.Add("PNNCRRSL", obeMercaderia.PNNCRRSL)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_SALIDA_LOTE", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    '
    Public Function intRevertirMovimientoGuiaSalida(ByVal opbeDespacho As beDespacho) As Integer
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Dim IntEstadoAnulado As Integer = 0
        Try
            objParam.Add("PNCCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("PNNGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("PNNORDSR", opbeDespacho.PNNORDSR)
            objParam.Add("PNNSLCSR", opbeDespacho.PNNSLCSR)
            objParam.Add("PNQREMC", opbeDespacho.PNQREMC)
            objParam.Add("PSUSUARIO", opbeDespacho.PSUSUARIO)
            objParam.Add("PSNTRMNL", opbeDespacho.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_SALIDA", objParam)

            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function intRevertirMovimientoGuiaSalidaKardex(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeMercaderia.PNCCLNT)
            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            objParam.Add("PSCZNALM", obeMercaderia.PSCZNALM)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PNNDTDTK", obeMercaderia.PNNDTDTK)
            objParam.Add("PNNSLCSR", obeMercaderia.PNNSLCSR)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_SALIDA_KARDEX", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function intRevertirMovimientoGuiaSalidaSeries(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSCSRECL", obeMercaderia.PSCSRECL)
            objParam.Add("PNNCRPLL", obeMercaderia.PNNCRPLL)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_SALIDA_SERIES", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function intRevertirMovimientoGuiaSalidaUbicacion(ByVal obeMercaderia As beMercaderia) As Integer

        Dim objParam As New Parameter
        Try

            objParam.Add("PSCTPALM", obeMercaderia.PSCTPALM)
            objParam.Add("PSCALMC", obeMercaderia.PSCALMC)
            objParam.Add("PNNORDSR", obeMercaderia.PNNORDSR)
            objParam.Add("PSCSECTR", obeMercaderia.PSCSECTR)
            objParam.Add("PSCPSCN", obeMercaderia.PSCPSCN)
            objParam.Add("PNNCRRIN", obeMercaderia.PNNCRRIN)
            objParam.Add("PNQTRMC1", obeMercaderia.PNQTRMC1)
            objParam.Add("PNQREVTR", obeMercaderia.PNQREVTR)
            objParam.Add("PSUSUARIO", obeMercaderia.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeMercaderia.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_REVERTIR_MOVIMIENTO_GUIA_SALIDA_UBICACION", objParam)
            'RETORNA 0 SI SE PUEDE ELIMINAR Y UNO SI NO SE PUEDE ELIMINAR
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    'intRevertirMovimientoGuiaIngreso

    '===================GUIA RANSA=====================
    Public Function ListaGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_FECINI", opbeDespacho.PNFECINI)
            objParam.Add("IN_FECFIN", opbeDespacho.PNFECFIN)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("IN_NORDSR", opbeDespacho.PNNORDSR)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_GUIA_RANSA", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ListaDetalleGuiaRansa(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_DETALLE_GUIA_RANSA_ZP", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    '======================GUIA RANSA PENDIENTE APROBACION=====================
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beDespacho)

    End Sub

    Public Function ListaGuiaRansaDesp(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            objParam.Add("IN_CTPALM", opbeDespacho.PSCTPALM)
            objParam.Add("IN_CALMC", opbeDespacho.PSCALMC)
            objParam.Add("IN_CTPOAT", opbeDespacho.PSCTPOAT)
            objParam.Add("IN_FECINI", opbeDespacho.PNFECINI)
            objParam.Add("IN_FECFIN", opbeDespacho.PNFECFIN)

            Return Listar("SP_SOLMIN_SA_SDS_LISTA_GUIA_RANSA_DESP", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fdtReporteGuiaRansa(ByVal opbeDespacho As beDespacho) As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_REPORTE_GUIA_RANSA", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ListaGuiaRemisionDesp(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_GUIA_REMISION_DESP", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fdtListaParaExportarABBRecepcion(ByVal pobeSerie As beDespacho) As DataTable
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        Try
            objParam.Add("PNCCLNT", pobeSerie.PNCCLNT)
            objParam.Add("PNNGUIRN", pobeSerie.PNNGUIRN)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTADO_RECEPCION_PARA_EXPORTAR", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try

    End Function

    Public Function fdtListaParaExportarOutotecDespacho(ByVal pobeSerie As beDespacho) As DataSet
        Dim objParam As New Parameter
        Dim olbeDespacho As New List(Of beDespacho)
        Dim intResultado As Integer = 1
        Try
            objParam.Add("PNCCLNT", pobeSerie.PNCCLNT)
            objParam.Add("PNNGUIRN", pobeSerie.PNNGUIRN)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTADO_DESPACHO_PARA_EXPORTAR", objParam)
        Catch ex As Exception
            Return New DataSet
        End Try

    End Function

    Public Function fintRegistrarEnvioInterfaz(ByVal obeDespacho As beDespacho) As Integer
        'Try
        Dim objParameter As New Parameter
        objParameter.Add("IN_CTPIS", obeDespacho.PSCTPIS)
        objParameter.Add("IN_CCLNT", obeDespacho.PNCCLNT)
        objParameter.Add("IN_NGUIRN", obeDespacho.PNNGUIRN)
        objParameter.Add("IN_FRLZSR", obeDespacho.PNFRLZSR)
        objParameter.Add("IN_STPODP", obeDespacho.PSSTPODP)
        objParameter.Add("IN_NPRTIN", obeDespacho.PNNPRTIN)
        objParameter.Add("IN_STRNSM", obeDespacho.PSSTRNSM)
        objParameter.Add("IN_FTRNSM", obeDespacho.PNFTRNSM)
        objParameter.Add("IN_HTRNSM", obeDespacho.PNHTRNSM)

        objParameter.Add("IN_CUSCRT", obeDespacho.PSCUSCRT)
        objParameter.Add("IN_FCHCRT", obeDespacho.PNFCHCRT)
        objParameter.Add("IN_HRACRT", obeDespacho.PNHRACRT)
        objParameter.Add("IN_CULUSA", obeDespacho.PSCULUSA)
        objParameter.Add("IN_FULTAC", obeDespacho.PNFULTAC)
        objParameter.Add("IN_HULTAC", obeDespacho.PNHULTAC)
        objParameter.Add("IN_SESTRG", "A")
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INS_RELACION_GUIA_ING_SAL", objParameter)
        'Catch ex As Exception
        '    Return 0
        'End Try
        Return 1
    End Function


    Public Function flistaMercaderiImprimirCodigoBarra(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim olbebeDespacho As New List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNGUIRN)
            Return Listar("SP_SOLMIN_LISTA_PRODUCTOS_IMPRIMIR", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function olistGuiaRansaXNroParte(ByVal opbeDespacho As beDespacho) As List(Of beDespacho)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", opbeDespacho.PNCCLNT)
            objParam.Add("IN_NGUIRN", opbeDespacho.PNNPRTIN)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_GUIA_RANSA_X_NRO_PARTE", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function fdtListarStockMercaderiasPorAlmacen(ByVal intOrdenServicio As Int64) As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", intOrdenServicio)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_STOCK_MERCADERIA_X_ALMACEN", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try

    End Function

    Public Function strObtenerCodigoRegionVenta(ByVal objDatos As beInferfazSapPedido) As String
        Dim result As String = String.Empty
        Dim objParam As New Parameter

        Try
            objParam.Add("IN_CCMPN", objDatos.CCMPN)
            objParam.Add("IN_CCLNT", objDatos.CCLNT)
            result = objSql.ExecuteScalar("SP_SOLMIN_SA_OBTENER_REG_VENTA_CLIENTE", objParam)
        Catch ex As Exception
            result = String.Empty
        End Try

        Return result
    End Function

    Public Function fdtOntenerInformacionPedidoInterfazSAP(ByVal objDatos As beInferfazSapPedido, ByRef msgError As String) As DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCMPN", objDatos.CCMPN)
            objParam.Add("IN_CRGVTA", objDatos.CRGVTA)
            objParam.Add("IN_CCLNT", objDatos.CCLNT)
            objParam.Add("IN_DCENSA", objDatos.DCENSA.PadLeft(10, "0"))
            objParam.Add("OU_ERROR", String.Empty, ParameterDirection.Output)

            Dim ds As New DataSet
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_DOC_INTERFAZ_SAP_PEDIDO", objParam)
            msgError = objSql.ParameterCollection("OU_ERROR")
            Return ds

        Catch ex As Exception
            Return New DataSet
        End Try
    End Function

    Public Function fdtOntenerInformacionDespachoInterfazSAP(ByVal objDatos As beInferfazSapPedido, ByRef msgError As String) As DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCMPN", objDatos.CCMPN)
            objParam.Add("IN_CRGVTA", objDatos.CRGVTA)
            objParam.Add("IN_CCLNT", objDatos.CCLNT)
            objParam.Add("IN_DCENSA", objDatos.DCENSA.Trim)
            objParam.Add("IN_NUMDES", objDatos.PSNUMDES.Trim)
            objParam.Add("OU_ERROR", String.Empty, ParameterDirection.Output)

            Dim ds As New DataSet
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_OBTENER_DOC_INTERFAZ_SAP_DESPACHO", objParam)
            msgError = objSql.ParameterCollection("OU_ERROR")
            Return ds

        Catch ex As Exception
            Return New DataSet
        End Try
    End Function

    Public Sub ActualizarEstadoTransmisionDocumentoSapInterfaz(ByVal objDatos As beInferfazSapPedido)

        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", objDatos.CCMPN)
            objParam.Add("PSCTPALM", objDatos.CRGVTA)
            objParam.Add("PSCALMC", objDatos.CCLNT)
            objParam.Add("PSCZNALM", objDatos.DCENSA)
            objParam.Add("PNNORDSR", objDatos.PSCULUSA)
            objParam.Add("PSNTRMNL", objDatos.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_DOC_INTERFAZ_SAP_PEDIDO", objParam)

        Catch ex As Exception

        End Try
    End Sub

    Public Function fdtListaPedidoTraslado(ByVal pobePedido As beDespacho) As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", pobePedido.PNCCLNT)
            objParam.Add("IN_FECHAINI", pobePedido.PNFECINI)
            objParam.Add("IN_FECHAFIN", pobePedido.PNFECFIN)
            objParam.Add("IN_NRPDTS", pobePedido.PNNRPDTS)
            objParam.Add("IN_SESPRC", pobePedido.PSSESPRC)
            objParam.Add("IN_CCMPN", pobePedido.PSCCMPN)
            objParam.Add("IN_CDVSN", pobePedido.PSCDVSN)
            objParam.Add("IN_CPLNDV", pobePedido.PNCPLNDV)
            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_PEDIDO_TRASLADO_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function


    Public Function fdtListaDetallePedidoTraslado(ByVal pobePedido As beDespacho) As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", pobePedido.PNCCLNT)
            objParam.Add("IN_NRPDTS", pobePedido.PNNRPDTS)

            Return objSql.ExecuteDataTable("SP_SOLMIN_SA_DET_PEDIDO_TRASLADO_LIST", objParam)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function fdtListaDetallePedidoTrasladoAtender(ByVal pobePedido As beDespacho) As DataTable
        Dim oDt As DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", pobePedido.PNCCLNT)
            objParam.Add("IN_NRPDTS", pobePedido.PNNRPDTS)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_DET_PEDIDO_TRASLADO_ATENDER_LIST", objParam)
            oDt.TableName = pobePedido.PNNRPDTS.ToString()
            Return oDt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function
End Class
