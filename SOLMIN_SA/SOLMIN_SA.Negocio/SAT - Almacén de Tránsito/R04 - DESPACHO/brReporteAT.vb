Imports RANSA.DATA
Imports RANSA.TypeDef.Reportes
Imports System.Text

Public Class brReporteAT
    Dim oDatos As New daReporteAT
    ''' <summary>
    ''' Lista para reporte de ingresos por Almacen
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstIngresoPorAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return oDatos.fdstIngresoPorAlmacen(obeFiltro)
    End Function

    Public Function fdstIngresoPorAlmacen_x_lote_x_solicitante(ByVal obeFiltro As beFiltrosDespachoPorAlmacen, Optional ByVal solicitante As String = "", Optional ByVal lote As String = "") As DataSet
        Return oDatos.fdstIngresoPorAlmacen_x_lote_x_solicitante(obeFiltro, solicitante, lote)
    End Function


    ''' <summary>
    ''' Reporte de Despacho por almacen
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstDespachoPorAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return oDatos.fdstDespachoPorAlmacen(obeFiltro)
    End Function

    '------------------------'
    '-- Inventario Almacen --'
    '------------------------'
    'Public Function frptInventarioAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
    '    Dim dtTemp As DataTable
    '    dtTemp = oDatos.frptInventarioAlmacen(obeFiltro)
    '    Return dtTemp
    'End Function
    Public Function frptInventarioAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim dtTemp As DataSet
        dtTemp = oDatos.frptInventarioAlmacen(obeFiltro)
        Return dtTemp
    End Function

    Public Function fdstGuiaSalidaMercaderia(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return oDatos.fdstGuiaSalidaMercaderia(obeFiltro)
    End Function

    'CSR-HUNDRED-INICIO
    Public Function ObtenerBultoInventarioXPedido(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Return oDatos.ObtenerBultoInventarioXPedido(obeFiltro)
    End Function
    'CSR-HUNDRED-FIN




    ''' <summary>
    ''' Reporte creado para el cliente PLUSPETROL
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstReporteIngresos(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return oDatos.fdstReporteIngresos(obeFiltro)
    End Function

    ''' <summary>
    ''' Lista de lotes 
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstListaDeLotesDeAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return oDatos.fdstListaDeLotesDeAlmacen(obeFiltro)
    End Function

    Public Function fdstReporteMovimientoValorizado(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Return oDatos.fdstReporteMovimientoValorizado(obeFiltro)
    End Function

    ''' <summary>
    ''' Consulta de Ing. y Des. por embarque solo para CONGA
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstReporteIngDesPorEmbarque(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Return oDatos.fdstReporteIngDesPorEmbarque(obeFiltro)
    End Function
    Public Function fdtListarSalidaUnidades(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Return FormaTablaResumenSalidaUnidad(oDatos.fdtListarSalidaUnidades(obeFiltro))
    End Function
     

    Public Function FormaTablaResumenSalidaUnidad(ByVal ds As DataSet) As DataSet
        Dim dsResult As DataSet
        Dim dsFiltro As DataSet
        dsResult = ds.Copy
        dsFiltro = ds.Copy
        For i As Integer = dsFiltro.Tables(0).Rows.Count - 1 To 1 Step -1
            If dsFiltro.Tables(0).Rows(i).Item("FSLDAL") = dsFiltro.Tables(0).Rows(i - 1).Item("FSLDAL") And dsFiltro.Tables(0).Rows(i).Item("NPLCUN") = dsFiltro.Tables(0).Rows(i - 1).Item("NPLCUN") Then
                dsResult.Tables(0).Rows(i).Item("FSLDAL") = DBNull.Value
            End If
            If dsFiltro.Tables(0).Rows(i).Item("FSLDAL") = dsFiltro.Tables(0).Rows(i - 1).Item("FSLDAL") And dsFiltro.Tables(0).Rows(i).Item("NPLCUN") = dsFiltro.Tables(0).Rows(i - 1).Item("NPLCUN") And dsFiltro.Tables(0).Rows(i).Item("NGUIRM") = dsFiltro.Tables(0).Rows(i - 1).Item("NGUIRM") Then
                dsResult.Tables(0).Rows(i).Item("FSLDAL") = DBNull.Value
                dsResult.Tables(0).Rows(i).Item("NPLCUN") = ""
                dsResult.Tables(0).Rows(i).Item("TCMPCL") = ""
                dsResult.Tables(0).Rows(i).Item("NGUIRM") = ""
                dsResult.Tables(0).Rows(i).Item("TNMBCH") = ""
            End If

            If dsFiltro.Tables(0).Rows(i).Item("FSLDAL") = dsFiltro.Tables(0).Rows(i - 1).Item("FSLDAL") And dsFiltro.Tables(0).Rows(i).Item("NPLCUN") = dsFiltro.Tables(0).Rows(i - 1).Item("NPLCUN") And dsFiltro.Tables(0).Rows(i).Item("CREFFW") = dsFiltro.Tables(0).Rows(i - 1).Item("CREFFW") And dsFiltro.Tables(0).Rows(i).Item("TCMPCL") = dsFiltro.Tables(0).Rows(i - 1).Item("TCMPCL") Then
                dsResult.Tables(0).Rows(i).Item("CREFFW") = ""
                dsResult.Tables(0).Rows(i).Item("FREFFW") = DBNull.Value
                dsResult.Tables(0).Rows(i).Item("DIAS") = DBNull.Value
                dsResult.Tables(0).Rows(i).Item("TIPBTO") = ""
                dsResult.Tables(0).Rows(i).Item("QREFFW") = DBNull.Value
                dsResult.Tables(0).Rows(i).Item("TPRVCL") = ""
                dsResult.Tables(0).Rows(i).Item("NORCML") = ""
                dsResult.Tables(0).Rows(i).Item("QPSOBL") = DBNull.Value
            End If
            dsResult.Tables(0).Rows(i).Item("PETOTA") = DBNull.Value
            dsResult.Tables(0).Rows(i).Item("QDPROM") = DBNull.Value
        Next
        'CALCULAMOS TOTAL DE PESOS Y PROMEDIO DE DIAS
        Dim PromedioDias As Decimal = 0
        Dim NumeroBultos As Integer = 0
        Dim SumaPesos As Decimal = 0
        For i As Integer = dsResult.Tables(0).Rows.Count - 1 To 0 Step -1

            If "" & dsResult.Tables(0).Rows(i).Item("FSLDAL") & "" <> "" And dsResult.Tables(0).Rows(i).Item("NPLCUN") <> "" Then
                dsResult.Tables(0).Rows(i).Item("PETOTA") = SumaPesos + Val("" & dsResult.Tables(0).Rows(i).Item("QPSOBL" & ""))
                dsResult.Tables(0).Rows(i).Item("QDPROM") = (PromedioDias + Val("" & dsResult.Tables(0).Rows(i).Item("DIAS") & "")) / (NumeroBultos + 1)
                SumaPesos = 0
                PromedioDias = 0
                NumeroBultos = 0

            Else

                If IsDBNull(dsResult.Tables(0).Rows(i).Item("QPSOBL")) = False And dsResult.Tables(0).Rows(i).Item("MARRET").ToString.ToUpper <> "X" Then
                    SumaPesos = SumaPesos + Decimal.Parse(dsResult.Tables(0).Rows(i).Item("QPSOBL"))
                End If
                If IsDBNull(dsResult.Tables(0).Rows(i).Item("DIAS")) = False And dsResult.Tables(0).Rows(i).Item("MARRET").ToString.ToUpper <> "X" Then
                    PromedioDias = PromedioDias + Decimal.Parse(dsResult.Tables(0).Rows(i).Item("DIAS"))
                End If
                If dsResult.Tables(0).Rows(i).Item("CREFFW") <> "" And dsResult.Tables(0).Rows(i).Item("MARRET").ToString.ToUpper <> "X" Then
                    NumeroBultos += 1
                End If

                'If dsFiltro.Tables(0).Rows(i).Item("TCMPCL") = dsFiltro.Tables(0).Rows(i - 1).Item("TCMPCL") AndAlso dsFiltro.Tables(0).Rows(i).Item("CREFFW") <> dsFiltro.Tables(0).Rows(i - 1).Item("CREFFW") AndAlso dsFiltro.Tables(0).Rows(i).Item("MARRET").ToString.Trim.Equals("") Then
                '    SumaPesos = SumaPesos + Decimal.Parse(dsResult.Tables(0).Rows(i).Item("QPSOBL"))
                '    PromedioDias = PromedioDias + Decimal.Parse(dsResult.Tables(0).Rows(i).Item("DIAS"))
                'End If
                'If dsResult.Tables(0).Rows(i).Item("CREFFW") <> "" And dsResult.Tables(0).Rows(i).Item("MARRET").ToString.ToUpper <> "X" Then
                '    NumeroBultos += 1
                'End If
            End If


        Next

        Return dsResult

    End Function

#Region "Modelo Perenco"
    Public Function frptInventarioAlmacenModeloPerenco(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Return oDatos.frptInventarioAlmacenModeloPerenco(obeFiltro)
    End Function
    Public Function fdtDespachoPorAlmacenModeloPerenco(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Return oDatos.fdtDespachoPorAlmacenModeloPerenco(obeFiltro)
    End Function
#End Region
End Class
