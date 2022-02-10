Imports RANSA.DATA
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario
Public Class brIndicador
    Public Shared Sub MaxDiasAbrevMes(ByVal Anio As Int32, ByVal Mes As Int32, ByRef MaxDiaMes As Int32, ByRef AbrevMes As String)
        Dim odtMeses As New DataTable()
        Dim keymes As String = ""
        Dim filtro As String = ""
        odtMeses = HelpClass.Meses(Anio)
        keymes = Mes.ToString
        If (keymes.Length <= 1) Then
            keymes = "0" & keymes
        End If
        filtro = "key='" & keymes & "'"
        MaxDiaMes = odtMeses.Select(filtro)(0).Item("max")
        AbrevMes = odtMeses.Select(filtro)(0).Item("value2").ToString.Trim
    End Sub
    Public Function CalcularListarIndicador(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet
        Dim MaxDiaMes As Int32 = 0
        Dim AbrevMes As String = ""
        Dim odaIndicador As New daIndicador()
        MaxDiasAbrevMes(obeIndicador.PNANIOEMI, obeIndicador.PNMESEMI, MaxDiaMes, AbrevMes)
        obeIndicador.PNMAXDIAS = MaxDiaMes
        ods = odaIndicador.CalcularListarIndicadorDiarioMensual(obeIndicador)

        Return ods
    End Function
    Public Function ListarDatosIndicador(ByVal obeIndicador As beIndicador) As beIndicador
        Dim odaindicador As New daIndicador()
        Return odaindicador.ListarDatosIndicador(obeIndicador)
    End Function


    Private objDAo As New daIndicador

    Public Function ListarTipoIndicador() As DataTable
        Return objDAo.ListarTipoIndicador()
    End Function

    Public Function Listar_Indicador_x_Tipo(ByVal Tipo As String) As DataTable
        Return objDAo.Listar_Indicadores_x_Tipo(Tipo)
    End Function

    Public Function ActualizarResumenIndicadorMensual(ByVal obeListIndicador As List(Of beIndicador), ByVal MaxDias As Int32) As Int32
        Dim odaindicador As New daIndicador()
        Dim retorno As Int32 = 0
        Try
            For Each oIndicador As beIndicador In obeListIndicador
                retorno = odaindicador.ActualizarResumenIndicadorMensual(oIndicador, MaxDias)
            Next
        Catch ex As Exception
        End Try
        Return retorno
    End Function

    Public Function ActualizarResumenIndicadorMensual2(ByVal obeListIndicador As List(Of beIndicador), ByVal MaxDias As Int32) As Int32
        Dim odaindicador As New daIndicador()
        Dim retorno As Int32 = 0
        Try
            For Each oIndicador As beIndicador In obeListIndicador
                retorno = odaindicador.ActualizarResumenIndicadorMensual2(oIndicador, MaxDias)
            Next
        Catch ex As Exception
        End Try
        Return retorno
    End Function

    Public Function ActualizarDatosIndicador(ByVal obeIndicador As beIndicador) As Int32
        Dim odaindicador As New daIndicador()
        Return odaindicador.ActualizarDatosIndicador(obeIndicador)
    End Function

    Public Function ListarIndicadorPivot(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet
        Dim MaxDiaMes As Int32 = 0
        Dim AbrevMes As String = ""
        Dim odaIndicador As New daIndicador()
        Try
            MaxDiasAbrevMes(obeIndicador.PNANIOEMI, obeIndicador.PNMESEMI, MaxDiaMes, AbrevMes)
            obeIndicador.PNMAXDIAS = MaxDiaMes
            ods = odaIndicador.ListarIndicadorDiarioMensualPivot(obeIndicador)
        Catch ex As Exception
        End Try
        Return ods
    End Function

    Public Function ListarIndicadorResumenMensual(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet
        Dim dt As New DataTable
        Dim Monto As Decimal = 0
        dt.Columns.Add("Item", Type.GetType("System.String"))
        dt.Columns.Add("Total", Type.GetType("System.Decimal"))

        Dim CTPOIN As Int32 = 0
        Dim odtDatos As New DataTable()
        Dim odtGraficos As New DataTable
        Dim odsGraficoResumen As New DataSet

        Dim odtSKU As New DataTable
        Dim odtERISKU As New DataTable

        Dim odtUBICACION As New DataTable
        Dim odtERIUBICACION As New DataTable

        Dim odtOCUPACION As New DataTable
        Dim odtNIVELOCUPACION As New DataTable

        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim dr3 As DataRow


        Dim MaxDiaMes As Int32 = 0
        Dim AbrevMes As String = ""
        Dim odaIndicador As New daIndicador()
        Try
            MaxDiasAbrevMes(obeIndicador.PNANIOEMI, obeIndicador.PNMESEMI, MaxDiaMes, AbrevMes)
            obeIndicador.PNMAXDIAS = MaxDiaMes
            odtDatos = odaIndicador.ListarIndicadorDiarioMensualRpt(obeIndicador).Tables(0).Copy
            odtDatos.TableName = "dtDatos"
            ods.Tables.Add(odtDatos)

            odtGraficos = odaIndicador.ListarIndicadorDiarioMensualUnPivot(obeIndicador).Tables(0).Copy
            odtGraficos.TableName = "dtGrafico"
            ods.Tables.Add(odtGraficos)

            'SKU------------------------------------
            odsGraficoResumen = odaIndicador.ListarIndicadorDiarioMensualRptGraficos(obeIndicador).Copy
            odtSKU = odsGraficoResumen.Tables(0).Copy
            odtSKU.TableName = "dtGraficoSKU"
            ods.Tables.Add(odtSKU)

            odtERISKU = dt.Clone()
            odtERISKU.TableName = "dtGraficoERISKU"
           
            If (odtSKU.Select("CTPOIN=11").Length > 0) Then
                dr1 = odtERISKU.NewRow()
                dr1("Item") = "ERI SKU"
                Monto = IIf(odtSKU.Select("CTPOIN=12")(0).Item("QAINSM") = 0, 0, Math.Round((odtSKU.Select("CTPOIN=11")(0).Item("QAINSM") / odtSKU.Select("CTPOIN=12")(0).Item("QAINSM")) * 100, 2))
                dr1("Total") = Monto
                odtERISKU.Rows.Add(dr1)
                odtERISKU.Rows.Add("Total", 100 - Monto)
            End If
          
            ods.Tables.Add(odtERISKU)
            '--------------------------------------------

            'Ubicacion----------------------------------

            odtUBICACION.TableName = "dtGraficoUbicacion"
            odtUBICACION = odsGraficoResumen.Tables(1).Copy
            ods.Tables.Add(odtUBICACION)


            odtERIUBICACION = dt.Clone()
            odtERIUBICACION.TableName = "dtGraficoERIUbicacion"
          
            If (odtUBICACION.Select("CTPOIN=21").Length > 0) Then
                dr2 = odtERIUBICACION.NewRow()
                dr2("Item") = "ERI UBICACION"
                Monto = IIf(odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM") = 0, 0, Math.Round((odtUBICACION.Select("CTPOIN=21")(0).Item("QAINSM") / odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM")) * 100, 2))
                dr2("Total") = Monto
                odtERIUBICACION.Rows.Add(dr2)
                odtERIUBICACION.Rows.Add("Total", 100 - Monto)
            End If
            ods.Tables.Add(odtERIUBICACION)

            'Ocupacion-------------------------------------------

            odtOCUPACION = odsGraficoResumen.Tables(2).Copy
            odtOCUPACION.TableName = "dtGraficoOcupacion"
            ods.Tables.Add(odtOCUPACION)


            odtNIVELOCUPACION = dt.Clone()
            odtNIVELOCUPACION.TableName = "dtGraficoNivelOcupacion"
          
            If (odtOCUPACION.Select("CTPOIN=31").Length > 0) Then
                dr3 = odtNIVELOCUPACION.NewRow()
                dr3("Item") = "POSICIONES OCUPADAS"
                Monto = IIf(odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM") = 0, 0, Math.Round((odtOCUPACION.Select("CTPOIN=31")(0).Item("QAINSM") / odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM")) * 100, 2))
                dr3("Total") = Monto
                odtNIVELOCUPACION.Rows.Add(dr3)
                odtNIVELOCUPACION.Rows.Add("Total", 100 - Monto)
            End If
            ods.Tables.Add(odtNIVELOCUPACION)

        Catch ex As Exception
        End Try
        Return ods
    End Function


    Public Function ListarIndicadorUnPivot(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet
        Dim odaIndicador As New daIndicador()
        Try
            ods = odaIndicador.ListarIndicadorDiarioMensualUnPivot(obeIndicador)
        Catch ex As Exception
        End Try
        Return ods
    End Function

    Public Function ListarIndicadorAnual(ByVal obeIndicador As beIndicador) As DataTable
        Dim odtAnual As New DataTable
        Dim nomColumnaMes As String = ""
        Dim odaIndicador As New daIndicador()
        Dim CTPOIN As Int32 = 0
        Dim FLAG_PORCENTUAL As Boolean = False
        Try
            odtAnual = odaIndicador.ListarIndicadorAnual(obeIndicador).Tables(0)
            For Each dr As DataRow In odtAnual.Rows
                CTPOIN = HelpClass.ObjectToInt32(dr.Item("CTPOIN"))
                FLAG_PORCENTUAL = False
                Select Case CTPOIN
                    Case 10 Or 20 Or 30
                        FLAG_PORCENTUAL = True
                    Case 11, 12, 21, 22
                        dr.Item("TTPOIN") = "    " & HelpClass.ObjectToString(dr.Item("TTPOIN"))
                        FLAG_PORCENTUAL = False
                    Case Else
                        FLAG_PORCENTUAL = False
                End Select
                If (FLAG_PORCENTUAL = True) Then
                    For index As Integer = 1 To 12
                        nomColumnaMes = FormatoNombreColumnaMes(index)
                        If (dr.Item(nomColumnaMes) IsNot Nothing And dr.Item(nomColumnaMes) IsNot DBNull.Value) Then
                            dr.Item(nomColumnaMes) = dr.Item(nomColumnaMes) & "%"
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
        End Try
        Return odtAnual
    End Function
   
    Private Function FormatoNombreColumnaMes(ByVal numeroMes As Int32) As String
        Dim retorno As String = "MES"
        Dim strDia As String = ""
        strDia = numeroMes.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function
End Class
