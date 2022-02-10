Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario
Public Class daLote

    Inherits daBase(Of beLote)
    Dim objSqlManager As New SqlManager

    Public Function ListarLotesPorCliente(ByVal obeLote As beLote) As DataTable
        Dim objParam As New Parameter
        Dim oDt As New DataTable("LOTES")
        'Try
        With objParam
            .Add("PSCCLNT", obeLote.CCLNT)
            .Add("PSCRTLTE", obeLote.CRTLTE)
            .Add("PSCMRCLR", obeLote.CMRCLR)
        End With
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_LOTES_POR_CLIENTE", objParam)
        oDt.Columns.Add("FechIngreso", Type.GetType("System.String"))
        oDt.Columns.Add("FechProduccion", Type.GetType("System.String"))
        oDt.Columns.Add("FechVencimiento", Type.GetType("System.String"))
        For Each row As DataRow In oDt.Rows
            row("FechIngreso") = IIf(row("FINGAL") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FINGAL")))
            row("FechProduccion") = IIf(row("FPRDMR") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FPRDMR")))
            row("FechVencimiento") = IIf(row("FVNLTE") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FVNLTE")))
        Next
        'Catch ex As Exception
        '    oDt = Nothing
        'End Try
        Return oDt
    End Function

    Public Function ListarLotesPorOS(ByVal obeLote As beLote) As DataTable
        Dim objParam As New Parameter
        Dim oDt As New DataTable("LOTES")
        'Try
        With objParam
            .Add("PSCRTLTE", obeLote.NORDSR)

        End With
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_LOTES_POR_OS", objParam)
        oDt.Columns.Add("FechIngreso", Type.GetType("System.String"))
        oDt.Columns.Add("FechProduccion", Type.GetType("System.String"))
        oDt.Columns.Add("FechVencimiento", Type.GetType("System.String"))
        For Each row As DataRow In oDt.Rows
            row("FechIngreso") = IIf(row("FINGAL") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FINGAL")))
            row("FechProduccion") = IIf(row("FPRDMR") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FPRDMR")))
            row("FechVencimiento") = IIf(row("FVNLTE") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FVNLTE")))
        Next
        'Catch ex As Exception
        '    oDt = Nothing
        'End Try
        Return oDt
    End Function



  
    Public Function ListarUbicacionesPorLoteCLiente(ByVal obeLote As beLote) As List(Of BeUbicacionesLotes)
        Dim objParam As New Parameter
        Dim Lista As New List(Of BeUbicacionesLotes)

        Dim objUbicacionLote As BeUbicacionesLotes
        Dim oDt As New DataTable
        'Try
        With objParam
            .Add("PNNORDSR", obeLote.NORDSR)
            .Add("PNNCRRIN", obeLote.NCRRIN)
        End With
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_UBICACIONES_LOTES_POR_CLIENTE", objParam)
        If oDt.Rows.Count > 0 Then
            For Each Item As DataRow In oDt.Rows
                objUbicacionLote = New BeUbicacionesLotes
                With objUbicacionLote
                    .TALMC = Item("TALMC").ToString.Trim
                    .TCMPAL = Item("TCMPAL").ToString.Trim
                    .CTPALM = Item("CTPALM").ToString.Trim
                    .CALMC = Item("CALMC").ToString.Trim
                    .CSECTR = Item("CSECTR").ToString.Trim
                    .CPSCN = Item("CPSCN").ToString.Trim
                    .QSLETQ = Item("QSLETQ").ToString.Trim
                    .QINETQ = Item("QINETQ").ToString.Trim
                    .NETQCB = Item("NETQCB").ToString.Trim
                End With
                Lista.Add(objUbicacionLote)
            Next
        End If
        'Catch ex As Exception
        'End Try
        Return Lista

    End Function

    Public Function RegistrarDespachoLote(ByVal lista As List(Of beLote)) As Boolean
        Dim resultado As Boolean = False
        Dim objParam As Parameter
        Try
            For Each obeLote As beLote In lista
                objParam = New Parameter
                With objParam
                    .Add("PNNORDSR", obeLote.NORDSR)
                    .Add("PNNCRRIN", obeLote.NCRRIN)
                    .Add("PNQTRMC", obeLote.QCMMC1)
                    .Add("PNQTRMP", obeLote.QCMMP1)
                    .Add("PSCTPOAT", obeLote.CTPOAT)
                    .Add("PNNGUIRN", obeLote.NGUIRN)
                    .Add("PNNSLCS1", obeLote.NSLCS1)
                    .Add("PSCTPALM", obeLote.CTPALM)
                    .Add("PSCALMC", obeLote.CALMC)
                    .Add("PSCZNALM", obeLote.CZNALM)
                    .Add("PSCULUSA", obeLote.CULUSA)
                End With
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_DESPACHO_LOTE_MERCADERIA", objParam)
            Next

            resultado = True
        Catch ex As Exception
            resultado = False
        End Try


        Return resultado
    End Function

    Public Function InsertarActualizarLotes(ByVal obeLote As beLote) As Boolean
        Dim objParam As New Parameter
        Dim Lista As New List(Of BeUbicacionesLotes)
        Dim correcto As Boolean
        Dim oDt As New DataTable
        Try
            With objParam
                .Add("PNNORDSR", obeLote.NORDSR)
                .Add("PNNCRRIN", obeLote.NCRRIN)
                .Add("PSCRTLTE", obeLote.CRTLTE)
                .Add("PNCCLNT", obeLote.CCLNT)
                .Add("PNCPRVCL", obeLote.CPRVCL)
                .Add("PSNDCMPV", obeLote.NDCMPV)
                .Add("PNCMNCT", obeLote.CMNCT)
                .Add("PNIMPTTL", obeLote.IMPTTL)
                .Add("PNCMNVTA", obeLote.CMNVTA)
                .Add("PNIMPVTA", obeLote.IMPVTA)
                .Add("PNFINGAL", obeLote.FINGAL)
                .Add("PNFPRDMR", obeLote.FPRDMR)
                .Add("PNFVNLTE", obeLote.FVNLTE)
                .Add("PNNTRNO", obeLote.NTRNO)
                .Add("PSTOBSCR", obeLote.TOBSCR)
                .Add("PSUSUARI", obeLote.PSCULUSA)
            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INSERTAR_LOTES", objParam)
            correcto = True
        Catch ex As Exception
            correcto = False
        End Try
        Return correcto

    End Function

    Public Function AnularLotes(ByVal obeLote As beLote) As Boolean
        Dim objParam As New Parameter
        Dim Lista As New List(Of BeUbicacionesLotes)
        Dim correcto As Boolean
        Dim oDt As New DataTable
        Try
            With objParam
                .Add("PNNORDSR", obeLote.NORDSR)
                .Add("PNNCRRIN", obeLote.NCRRIN)
                .Add("PSUSUARI", obeLote.CULUSA)
            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_LOTES", objParam)
            correcto = True
        Catch ex As Exception
            correcto = False
        End Try
        Return correcto

    End Function

    Public Function InsertarUbicacionLotes(ByVal obeUbLote As BeUbicacionesLotes) As Boolean
        Dim objParam As New Parameter
        Dim Lista As New List(Of BeUbicacionesLotes)
        Dim correcto As Boolean
        Dim oDt As New DataTable
        Try
            With objParam
                .Add("PNNORDSR", obeUbLote.NORDSR)
                .Add("PNNCRRIN", obeUbLote.NCRRIN)
                .Add("PSCTPALM", obeUbLote.CTPALM)
                .Add("PSCALMC", obeUbLote.CALMC)
                .Add("PSCSECTR", obeUbLote.CSECTR)
                .Add("PSCPSCN", obeUbLote.CPSCN)
                .Add("PSUSUARI", obeUbLote.PSCULUSA)
            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_AGREGAR_UBICACION_LOTE", objParam)
            correcto = True
        Catch ex As Exception
            correcto = False
        End Try
        Return correcto

    End Function

    Public Function AnularUbicacionLotes(ByVal obeUbLote As BeUbicacionesLotes) As Boolean
        Dim objParam As New Parameter
        Dim Lista As New List(Of BeUbicacionesLotes)
        Dim correcto As Boolean
        Dim oDt As New DataTable
        Try
            With objParam
                .Add("NETQCB", obeUbLote.NETQCB)
                .Add("PSUSUARI", obeUbLote.PSCULUSA)
            End With
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ANULAR_UBICACION_LOTES", objParam)
            correcto = True
        Catch ex As Exception
            correcto = False
        End Try
        Return correcto

    End Function


    Public Function ListaDeLotesPorOC(ByVal obeLote As beLote) As DataTable
        Dim objParam As New Parameter
        Dim oDt As New DataTable("LOTES")
        'Try
        With objParam
            .Add("PNNORDSR", obeLote.NORDSR)
        End With
        oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_LISTA_LOTES_OS", objParam)
        oDt.Columns.Add("CANTIDAD", Type.GetType("System.Decimal"))
        oDt.Columns.Add("SF_FINGAL", Type.GetType("System.String"))
        oDt.Columns.Add("SF_FPRDMR", Type.GetType("System.String"))
        oDt.Columns.Add("SF_FVNLTE", Type.GetType("System.String"))

        For Each row As DataRow In oDt.Rows
            row("CANTIDAD") = 0
            row("SF_FINGAL") = IIf(row("FINGAL") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FINGAL")))
            row("SF_FPRDMR") = IIf(row("FPRDMR") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FPRDMR")))
            row("SF_FVNLTE") = IIf(row("FVNLTE") = 0, "", HelpClass.CNumero8Digitos_a_Fecha(row("FVNLTE")))

        Next
        'Catch ex As Exception
        '    oDt = Nothing
        'End Try
        Return oDt
    End Function

 
    Public Function RegistrarRecepcionLote(ByVal obeLote As beLote) As Boolean
        Dim resultado As Boolean = False
        Dim objParam As New Parameter
        'Try
        With objParam
            .Add("PNNORDSR", obeLote.NORDSR)
            .Add("PNNCRRIN", obeLote.NCRRIN)
            .Add("PNFINGAL", obeLote.FINGAL)
            .Add("PSCULUSA", obeLote.CULUSA)
            .Add("PNQTRMC", obeLote.QTRMC)
            .Add("PNQTRMP", obeLote.QTRMP)
            .Add("PSCTPOAT", obeLote.CTPOAT)
            .Add("PNNGUIRN", obeLote.NGUIRN)
            .Add("PNNSLCS1", obeLote.NSLCS1)
            .Add("PSCTPALM", obeLote.CTPALM)
            .Add("PSCALMC", obeLote.CALMC)
            .Add("PSCZNALM ", obeLote.CZNALM)
        End With
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_INSERTAR_LOTE_MERCADERIA", objParam)
        resultado = True
        'Catch ex As Exception
        '    resultado = False
        'End Try


        Return resultado
    End Function

    Public Function ValidarExistenciaCriterioLote(ByVal obeLote As beLote) As Integer

        Dim Respuesta As Integer
        Try
            Dim objSql As New SqlManager()
            Dim objParam As New Parameter
            objParam.Add("PNNORDSR", obeLote.NORDSR)
            objParam.Add("PNCCLNT", obeLote.CCLNT)
            objParam.Add("PSCRTLTE", obeLote.CRTLTE)
            Dim resp As Integer = objSqlManager.ExecuteScalar("SP_SOLMIN_SA_VALIDAR_CRITERIO_LOTES", objParam)

            Respuesta = resp
        Catch ex As Exception
            Respuesta = -1
        End Try
        Return Respuesta
    End Function

#Region ""

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beLote)

    End Sub

#End Region
End Class
