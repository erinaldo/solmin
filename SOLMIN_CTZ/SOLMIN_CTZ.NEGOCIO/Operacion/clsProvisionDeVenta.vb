Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports System.Data
 
Public Class clsProvisionDeVenta

    Public Function fdtListaOperacionesParaProvionar(ByVal oFiltro As ProvisionVenta) As List(Of ProvisionVenta)
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fdtListaOperacionesParaProvionar(oFiltro)
       
    End Function

    Public Function fintGenerProvision(ByVal ocabProvision As ProvisionVenta, ByVal olstDetProvision As List(Of ProvisionVenta)) As Integer
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fintGenerProvision(ocabProvision, olstDetProvision)
    End Function

    Public Function fdtListaProviones(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Dim oDtFiltro As DataTable
        oDtFiltro = oServicioDat.fdtListaProviones(oFiltro)
        For Each oDr As DataRow In oDtFiltro.Rows
            oDr.Item("MES") = fstrMes(oDr.Item("MES"))
        Next

        Return oDtFiltro
    End Function

    Private Function fstrMes(ByVal strCodmes As String) As String
        Dim oDtMes As DataTable
        oDtMes = odtMeses()
        For Each oDr As DataRow In oDtMes.Rows
            If oDr.Item("Codigo") = strCodmes Then
                Return oDr.Item("Descripcion")
            End If
        Next
        Return ""
    End Function

    ''' <summary>
    ''' Meses del año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function odtMeses() As DataTable
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dtMes.Rows.Add(dr)

        Return dtMes
    End Function


    Public Function fdtDetalleProviones(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fdtDetalleProviones(oFiltro)
    End Function
    ''' <summary>
    ''' Lista de Operaciones por Centro de Beneficio y Cliente
    ''' </summary>
    ''' <param name="oFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaOperacionesProvionadas_CeBe(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fdtListaOperacionesProvionadas_CeBe(oFiltro)
    End Function

    ''' <summary>
    ''' Lista de Reversion de la privision
    ''' </summary>
    ''' <param name="oFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaReversionProvision(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Dim oDtFiltro As DataTable
        oDtFiltro = oServicioDat.fdtListaReversionProvision(oFiltro)
        For Each oDr As DataRow In oDtFiltro.Rows
            oDr.Item("MES") = fstrMes(oDr.Item("MES"))
        Next

        Return oDtFiltro
    End Function

    Public Function fdtDetalleReversionProvion(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Dim lstr_CCMPN As String = ""
        Dim lstr_NMRVVT As String = ""
        Dim lstr_CCNTCS As String = ""
        Dim lstr_TCNTCS As String = ""
        Dim lstr_CCLNFC As String = ""
        Dim lstr_TCMPCL As String = ""
        Dim lstr_CCNBNS As String = ""

        Dim dtProv As New DataTable
        dtProv.Columns.Add("CCMPN", GetType(String))
        dtProv.Columns.Add("NMRVVT", GetType(String))
        dtProv.Columns.Add("CCNTCS", GetType(String))
        dtProv.Columns.Add("TCNTCS", GetType(String))
        dtProv.Columns.Add("CCLNFC", GetType(String))
        dtProv.Columns.Add("TCMPCL", GetType(String))
        dtProv.Columns.Add("CCNBNS", GetType(String))
        Dim oDt As New DataTable
        Dim oDtDistinct As New DataTable
        Dim oDtDatCli As New DataTable
        Dim newRow As DataRow
        oDt = oServicioDat.fdtDetalleReversionProvion(oFiltro)
        oDtDistinct = oDt.DefaultView.ToTable(True, "ANOMES")
        oDtDatCli = oDt.DefaultView.ToTable(True, "CCMPN", "NMRVVT", "CCNTCS", "TCNTCS", "CCLNFC", "TCMPCL", "CCNBNS")
        Dim dView As New DataView(oDtDistinct)
        dView.Sort = "ANOMES ASC"
        Dim dtMes As DataTable = dView.ToTable(True, "ANOMES")
        For i As Integer = 0 To dtMes.Rows.Count - 1
            dtProv.Columns.Add(MonthName(Convert.ToInt32(dtMes.Rows(i).Item(0).ToString.Substring(4, 2)), False).ToUpper & " " & dtMes.Rows(i).Item(0).ToString().Substring(0, 4), GetType(Decimal))
        Next

        'For e As Integer = 7 To dtProv.Columns.Count - 1
        'dtProv.Columns(e) = 
        'Next
        For x As Integer = 0 To oDtDatCli.Rows.Count - 1
            newRow = dtProv.NewRow
            newRow("CCMPN") = oDtDatCli.Rows(x)("CCMPN")
            newRow("NMRVVT") = oDtDatCli.Rows(x)("NMRVVT")
            newRow("CCNTCS") = oDtDatCli.Rows(x)("CCNTCS")
            newRow("TCNTCS") = oDtDatCli.Rows(x)("TCNTCS")
            newRow("CCLNFC") = oDtDatCli.Rows(x)("CCLNFC")
            newRow("TCMPCL") = oDtDatCli.Rows(x)("TCMPCL")
            newRow("CCNBNS") = oDtDatCli.Rows(x)("CCNBNS")
            dtProv.Rows.Add(newRow)
        Next

        For x As Integer = 0 To dtProv.Rows.Count - 1
            For y As Integer = 0 To oDt.Rows.Count - 1
                If dtProv.Rows(x).Item("CCMPN") = oDt.Rows(y).Item("CCMPN") And dtProv.Rows(x).Item("NMRVVT") = oDt.Rows(y).Item("NMRVVT").ToString() And dtProv.Rows(x).Item("CCNTCS") = oDt.Rows(y).Item("CCNTCS").ToString() And dtProv.Rows(x).Item("TCNTCS").ToString.Trim = oDt.Rows(y).Item("TCNTCS").ToString.Trim And _
                dtProv.Rows(x).Item("CCLNFC") = oDt.Rows(y).Item("CCLNFC").ToString And dtProv.Rows(x).Item("TCMPCL").ToString.Trim = oDt.Rows(y).Item("TCMPCL").ToString.Trim And dtProv.Rows(x).Item("CCNBNS") = oDt.Rows(y).Item("CCNBNS") Then
                    dtProv.Rows(x)(String.Format("{0}", MonthName(Convert.ToInt32(oDt.Rows(y)("ANOMES").ToString.Substring(4, 2)), False).ToUpper & " " & oDt.Rows(y)("ANOMES").ToString().Substring(0, 4))) = oDt.Rows(y)("MONTO_PROVISION")
                End If
            Next
        Next

        Return dtProv

    End Function


    Public Function fdtListaOperacionesRevertidas_CeBe(ByVal oFiltro As ProvisionVenta) As DataTable
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fdtListaOperacionesRevertidas_CeBe(oFiltro)
    End Function

    Public Function fdsListaProvisionesExportar(ByVal oFiltro As ProvisionVenta, ByVal intFormato As Integer) As DataSet
        Dim dsRes As DataSet
        Try
            Dim oServicioDat As New DATOS.clsProvisionDeVenta
            Dim ds As DataSet = oServicioDat.fdsListaProvisionesExportar(oFiltro)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)(1) = MonthName(Convert.ToInt32(ds.Tables(0).Rows(i)(1).ToString.Substring(4, 2)), False).ToUpper & " " & Convert.ToInt32(ds.Tables(0).Rows(i)(1).ToString.Substring(0, 4))
                ds.Tables(0).AcceptChanges()
            Next

            'Primer Datable
            ds.Tables(0).Columns("""Nro. Provisión""").Caption = "Numero"
            ds.Tables(0).Columns("""Mes Año""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Negocio""").Caption = "Texto"
            ds.Tables(0).Columns("""Negocio""").Caption = "Texto"
            ds.Tables(0).Columns("""Fecha de Provisión""").Caption = "Fecha"
            ds.Tables(0).Columns("""División""").Caption = "Texto"
            ds.Tables(0).Columns("""Planta""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Cliente Facturar""").Caption = "Numero"
            ds.Tables(0).Columns("""Cliente a Facturar""").Caption = "Texto"
            ds.Tables(0).Columns("""Nr. Revisión""").Caption = "Numero"
            ds.Tables(0).Columns("""Fecha Revisión""").Caption = "Fecha"
            ds.Tables(0).Columns("""Nr. Operación""").Caption = "Numero"
            ds.Tables(0).Columns("""Estado Op. al Provisinar""").Caption = "Texto"
            ds.Tables(0).Columns("""Estado Op. Actual""").Caption = "Texto"
            ds.Tables(0).Columns("""Rubro Especifico""").Caption = "Texto"

            'ds.Tables(0).Columns("""Cod. CeBe""").Caption = "Numero"
            'ds.Tables(0).Columns("""CeBe SAP""").Caption = "Texto"
            'ds.Tables(0).Columns("""Centro de Beneficio""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Ce.Be. Destino""").Caption = "Numero"
            ds.Tables(0).Columns("""Ce.Be. SAP Destino""").Caption = "Texto"
            ds.Tables(0).Columns("""Centro de Beneficio Destino""").Caption = "Texto"



            ds.Tables(0).Columns("""Material""").Caption = "Texto"
            ds.Tables(0).Columns("""Importe Provisión S/.""").Caption = "Decimal"
            ds.Tables(0).Columns("""Estado Reversión""").Caption = "Texto"
            ds.Tables(0).Columns("""Nro. Reversión""").Caption = "Numero"
            ds.Tables(0).Columns("""Fecha Reversión""").Caption = "Fecha"
            ds.Tables(0).Columns("""Tipo Documento""").Caption = "Texto"
            ds.Tables(0).Columns("""Nro. Documento""").Caption = "Numero"
            ds.Tables(0).Columns("""Fecha Documento""").Caption = "Texto"
            ds.Tables(0).Columns("""Importe Reversión S/.""").Caption = "Decimal"
            ds.Tables(0).Columns("""Saldo Provisión S/.""").Caption = "Decimal"

            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                ds.Tables(1).Rows(i)(1) = MonthName(Convert.ToInt32(ds.Tables(1).Rows(i)(1).ToString.Substring(4, 2)), False).ToUpper & " " & Convert.ToInt32(ds.Tables(1).Rows(i)(1).ToString.Substring(0, 4))

            Next
            ds.Tables(1).AcceptChanges()

            ds.Tables(1).Columns("""Nro. Provisión""").Caption = "Numero"
            ds.Tables(1).Columns("""Mes Año""").Caption = "Texto"
            ds.Tables(1).Columns("""Cod. Negocio""").Caption = "Texto"
            ds.Tables(1).Columns("""Negocio""").Caption = "Texto"
            ds.Tables(1).Columns("""Fecha de Provisión""").Caption = "Fecha"
            ds.Tables(1).Columns("""División""").Caption = "Texto"
            ds.Tables(1).Columns("""Nr. Operación""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Op.""").Caption = "Fecha"
            ds.Tables(1).Columns("""Estado Op. al Provisinar""").Caption = "Texto"
            ds.Tables(1).Columns("""Estado Op. Actual""").Caption = "Texto"
            ds.Tables(1).Columns("""Planta""").Caption = "Texto"
            ds.Tables(1).Columns("""Transportista""").Caption = "Texto"
            ds.Tables(1).Columns("""P / T""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Guía Transporte""").Caption = "Texto"
            ds.Tables(1).Columns("""Fecha Guía Transporte""").Caption = "Fecha"
            ds.Tables(1).Columns("""Nro. Liquidación""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Liquidación""").Caption = "Fecha"
            ds.Tables(1).Columns("""N° Referencia SAP""").Caption = "Numero"
            ds.Tables(1).Columns("""Cod. Cliente Facturar""").Caption = "Numero"
            ds.Tables(1).Columns("""Cliente a Facturar""").Caption = "Texto"
            ds.Tables(1).Columns("""Tipo Vehículo""").Caption = "Texto"
            ds.Tables(1).Columns("""Localidad Origen""").Caption = "Texto"
            ds.Tables(1).Columns("""Localidad Destino""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Pre Factura""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Pre Factura""").Caption = "Fecha"
            ds.Tables(1).Columns("""Nro. Pre Liquidación""").Caption = "Numero"
            ds.Tables(1).Columns("""Importe Provisión S/.""").Caption = "Decimal"
            ds.Tables(1).Columns("""Importe a Pagar S/.""").Caption = "Decimal"
            ds.Tables(1).Columns("""N° Orden Interna""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Inicio OI""").Caption = "Fecha"

            'ds.Tables(1).Columns("""Cod. CeBe""").Caption = "Numero"
            'ds.Tables(1).Columns("""Centro de Beneficio""").Caption = "Texto"
            'ds.Tables(1).Columns("""CeBe SAP""").Caption = "Texto"
            ds.Tables(1).Columns("""Cod. Ce.Be. Destino""").Caption = "Numero"
            ds.Tables(1).Columns("""Ce.Be. SAP Destino""").Caption = "Texto"
            ds.Tables(1).Columns("""Centro de Beneficio Destino""").Caption = "Texto"



            ds.Tables(1).Columns("""Estado Reversión""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Reversión""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Reversión""").Caption = "Fecha"
            ds.Tables(1).Columns("""Tipo Documento""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Documento""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Documento""").Caption = "Fecha"
            ds.Tables(1).Columns("""Importe Reversión S/.""").Caption = "Decimal"
            ds.Tables(1).Columns("""Saldo Provisión S/.""").Caption = "Decimal"




            If intFormato = 1 Then
                dsRes = CrearTablaResumenProvision_Formato01(ds)

            Else
                dsRes = CrearTablaResumenProvision_Formato02(ds)
            End If

        Catch ex As Exception
        End Try

        Return dsRes
    End Function

    Public Function fdsListaProvisionExportarCAT(ByVal oFiltro As ProvisionVenta) As DataSet
        Dim ds As DataSet 'dsRes As DataSet
        Try
            Dim oServicioDat As New DATOS.clsProvisionDeVenta
            ds = oServicioDat.fdsListaProvisionesExportarCAT(oFiltro)
            'ds.Tables(0).Columns("""ITM_NUMBER1""").Caption = "Texto"

        Catch ex As Exception
        End Try

        Return ds 'dsRes
    End Function


    Private Function CrearTablaResumenProvision_Formato01(ByVal ds As DataSet) As DataSet
        Dim oDtMeses As New DataTable
        Dim oDsProv As New DataSet
        Dim dtProv As New DataTable
        Dim oDtDatCli As New DataTable
        Dim oDtRegion As New DataTable

        oDsProv.Tables.Add(ds.Tables(0).Copy)
        oDsProv.Tables(0).TableName = "OPERACIONES ADMINISTRACIÓN"

        oDsProv.Tables.Add(ds.Tables(1).Copy)
        oDsProv.Tables(1).TableName = "OPERACIONES TRANSPORTE"

        dtProv.Columns.Add("Cod. Negocio", GetType(String))
        dtProv.Columns.Add("Negocio", GetType(String))
        dtProv.Columns.Add("Cod. CeBe", GetType(Integer))
        dtProv.Columns.Add("Centro de Beneficio", GetType(String))
        dtProv.Columns.Add("CeBe SAP", GetType(String))
        dtProv.Columns.Add("Cod. Cliente", GetType(Integer))
        dtProv.Columns.Add("Razón Social", GetType(String))

        oDtDatCli = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA", "CCLNFC", "TCMPCL", "TCMTRF", "CCNTCS", "TCNTCS", "CCNBNS")
        oDtRegion = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA")
        oDtMeses = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "ANOMES")

        Dim dView As New DataView(oDtMeses)
        dView.Sort = "CRGVTA,ANOMES ASC"
        Dim dtMes As DataTable = dView.ToTable(True, "CRGVTA", "ANOMES")

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            Dim dt1 As New DataTable
            dt1.Columns.Add("Cod. Cliente", GetType(Integer))
            dt1.Columns.Add("Razón Social", GetType(String))
            dt1.Columns.Add("Rubro", GetType(String))
            dt1.Columns.Add("Cod. CeBe", GetType(Integer))
            dt1.Columns.Add("Centro de Beneficio", GetType(String))
            dt1.Columns.Add("CeBe SAP", GetType(String))


            dt1.TableName = oDtRegion.Rows(x)("CRGVTA").ToString.Trim
            Dim dr As DataRow = Nothing
            For w As Integer = 0 To oDtDatCli.Rows.Count - 1
                If oDtRegion.Rows(x)("CRGVTA") = oDtDatCli.Rows(w)("CRGVTA") Then
                    dr = dt1.NewRow
                    'dr(0) = oDtDatCli.Rows(w)("CRGVTA")
                    'dr(1) = oDtDatCli.Rows(w)("TCRVTA")
                    dr(0) = oDtDatCli.Rows(w)("CCLNFC")
                    dr(1) = oDtDatCli.Rows(w)("TCMPCL")
                    dr(2) = oDtDatCli.Rows(w)("TCMTRF")
                    dr(3) = oDtDatCli.Rows(w)("CCNTCS")
                    dr(4) = oDtDatCli.Rows(w)("TCNTCS")
                    dr(5) = oDtDatCli.Rows(w)("CCNBNS")
                    dt1.Rows.Add(dr)
                End If
            Next
            oDsProv.Tables.Add(dt1)
        Next

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsProv.Tables.Count - 1
                If oDsProv.Tables(intTable).TableName = oDtRegion.Rows(x)(0) Then
                    For i As Integer = 0 To dtMes.Rows.Count - 1
                        If dtMes.Rows(i).Item("CRGVTA") = oDsProv.Tables(intTable).TableName Then
                            oDsProv.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto"), GetType(Double))

                            oDsProv.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo"), GetType(Double))
                        End If
                    Next
                End If
            Next
        Next


        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            For x As Integer = 0 To oDsProv.Tables(intTable).Rows.Count - 1
                For i As Integer = 0 To ds.Tables(2).Rows.Count - 1
                    If oDsProv.Tables(intTable).TableName = ds.Tables(2).Rows(i)("CRGVTA") Then
                        If oDsProv.Tables(intTable).Rows(x).Item(0).ToString.Trim = ds.Tables(2).Rows(i).Item("CCLNFC").ToString.Trim And oDsProv.Tables(intTable).Rows(x).Item(2).ToString.Trim = ds.Tables(2).Rows(i).Item("TCMTRF").ToString.Trim And oDsProv.Tables(intTable).Rows(x).Item(3).ToString = ds.Tables(2).Rows(i).Item("CCNTCS").ToString And oDsProv.Tables(intTable).Rows(x).Item(4).ToString.Trim = ds.Tables(2).Rows(i).Item("TCNTCS").ToString().Trim And oDsProv.Tables(intTable).Rows(x).Item(5).ToString.Trim = ds.Tables(2).Rows(i).Item("CCNBNS").ToString().Trim Then
                            oDsProv.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto")) = ds.Tables(2).Rows(i)("MONTO")
                            oDsProv.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo")) = ds.Tables(2).Rows(i)("SALDO")
                        End If
                    End If
                Next
            Next

        Next

        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            oDsProv.Tables(intTable).Columns.Add("TOTAL \n MONTO S/.", GetType(Double))
            oDsProv.Tables(intTable).Columns.Add("TOTAL \n SALDO S/.", GetType(Double))
        Next

        Dim totalMONTO As Decimal = 0
        Dim totalSALDO As Decimal = 0
        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            For f As Integer = 0 To oDsProv.Tables(intTable).Rows.Count - 1
                For c As Integer = 5 To oDsProv.Tables(intTable).Columns.Count - 1
                    If oDsProv.Tables(intTable).Columns.Item(c).ColumnName.Contains("Monto") = True Then
                        totalMONTO += IIf(IsDBNull(oDsProv.Tables(intTable).Rows(f)(c)), 0, oDsProv.Tables(intTable).Rows(f)(c))
                    ElseIf oDsProv.Tables(intTable).Columns.Item(c).ColumnName.Contains("Saldo") = True Then
                        totalSALDO += IIf(IsDBNull(oDsProv.Tables(intTable).Rows(f)(c)), 0, oDsProv.Tables(intTable).Rows(f)(c))
                    End If

                Next
                oDsProv.Tables(intTable).Rows(f)("TOTAL \n MONTO S/.") = totalMONTO
                oDsProv.Tables(intTable).Rows(f)("TOTAL \n SALDO S/.") = totalSALDO
                totalMONTO = 0
                totalSALDO = 0
            Next
        Next



        For k As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsProv.Tables.Count - 1
                If oDtRegion.Rows(k)("CRGVTA") = oDsProv.Tables(intTable).TableName Then
                    oDsProv.Tables(intTable).TableName = oDtRegion.Rows(k)("TCRVTA").ToString.Trim
                End If
            Next
        Next

        Return oDsProv
    End Function


    Private Function CrearTablaResumenProvision_Formato02(ByVal ds As DataSet) As DataSet
        Dim oDtMeses As New DataTable
        Dim oDsProv As New DataSet
        'Dim dtProv As New DataTable
        Dim oDtDatCli As New DataTable
        Dim oDtRegion As New DataTable

        oDsProv.Tables.Add(ds.Tables(0).Copy)
        oDsProv.Tables(0).TableName = "OPERACIONES ADMINISTRACIÓN"

        oDsProv.Tables.Add(ds.Tables(1).Copy)
        oDsProv.Tables(1).TableName = "OPERACIONES TRANSPORTE"

        'dtProv.Columns.Add("Cod. Negocio", GetType(String))
        'dtProv.Columns.Add("Negocio", GetType(String))
        'dtProv.Columns.Add("Cod. CeBe", GetType(Integer))
        'dtProv.Columns.Add("Centro de Beneficio", GetType(String))
        'dtProv.Columns.Add("CeBe SAP", GetType(String))
        'dtProv.Columns.Add("Cod. Cliente", GetType(Integer))
        'dtProv.Columns.Add("Razón Social", GetType(String))

        oDtDatCli = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA", "CCLNFC", "TCMPCL", "TCMTRF", "CCNTCS", "TCNTCS", "CCNBNS")
        oDtRegion = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA")
        oDtMeses = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "ANOMES")

        Dim dView As New DataView(oDtMeses)
        dView.Sort = "CRGVTA,ANOMES ASC"
        Dim dtMes As DataTable = dView.ToTable(True, "CRGVTA", "ANOMES")

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            Dim dt1 As New DataTable
            dt1.Columns.Add("Cuenta Mayor", GetType(Integer))
            dt1.Columns.Add("Nro. Doc.", GetType(String))
            dt1.Columns.Add("Cod. Cliente", GetType(Integer))
            dt1.Columns.Add("Razón Social", GetType(String))
            dt1.Columns.Add("Rubro", GetType(String))
            dt1.Columns.Add("Cod. CeBe", GetType(Integer))
            dt1.Columns.Add("Centro de Beneficio", GetType(String))
            dt1.Columns.Add("CeBe SAP", GetType(String))


            dt1.TableName = oDtRegion.Rows(x)("CRGVTA").ToString.Trim
            Dim dr As DataRow = Nothing
            For w As Integer = 0 To oDtDatCli.Rows.Count - 1
                If oDtRegion.Rows(x)("CRGVTA") = oDtDatCli.Rows(w)("CRGVTA") Then
                    dr = dt1.NewRow
                    'dr(0) = oDtDatCli.Rows(w)("CRGVTA")
                    'dr(1) = oDtDatCli.Rows(w)("TCRVTA")
                    dr(2) = oDtDatCli.Rows(w)("CCLNFC")
                    dr(3) = oDtDatCli.Rows(w)("TCMPCL")
                    dr(4) = oDtDatCli.Rows(w)("TCMTRF")
                    dr(5) = oDtDatCli.Rows(w)("CCNTCS")
                    dr(6) = oDtDatCli.Rows(w)("TCNTCS")
                    dr(7) = oDtDatCli.Rows(w)("CCNBNS")
                    dt1.Rows.Add(dr)
                End If
            Next
            oDsProv.Tables.Add(dt1)
        Next

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsProv.Tables.Count - 1
                If oDsProv.Tables(intTable).TableName = oDtRegion.Rows(x)(0) Then
                    For i As Integer = 0 To dtMes.Rows.Count - 1
                        If dtMes.Rows(i).Item("CRGVTA") = oDsProv.Tables(intTable).TableName Then
                            oDsProv.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto"), GetType(Double))

                            oDsProv.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo"), GetType(Double))
                        End If
                    Next
                End If
            Next
        Next


        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            For x As Integer = 0 To oDsProv.Tables(intTable).Rows.Count - 1
                For i As Integer = 0 To ds.Tables(2).Rows.Count - 1
                    If oDsProv.Tables(intTable).TableName = ds.Tables(2).Rows(i)("CRGVTA") Then
                        If oDsProv.Tables(intTable).Rows(x).Item(2).ToString.Trim = ds.Tables(2).Rows(i).Item("CCLNFC").ToString.Trim And oDsProv.Tables(intTable).Rows(x).Item(4).ToString.Trim = ds.Tables(2).Rows(i).Item("TCMTRF").ToString.Trim And oDsProv.Tables(intTable).Rows(x).Item(5).ToString = ds.Tables(2).Rows(i).Item("CCNTCS").ToString And oDsProv.Tables(intTable).Rows(x).Item(6).ToString.Trim = ds.Tables(2).Rows(i).Item("TCNTCS").ToString().Trim And oDsProv.Tables(intTable).Rows(x).Item(7).ToString.Trim = ds.Tables(2).Rows(i).Item("CCNBNS").ToString().Trim Then
                            oDsProv.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto")) = ds.Tables(2).Rows(i)("MONTO")
                            oDsProv.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo")) = ds.Tables(2).Rows(i)("SALDO")
                        End If
                    End If
                Next
            Next

        Next

        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            oDsProv.Tables(intTable).Columns.Add("TOTAL \n MONTO S/.", GetType(Double))
            oDsProv.Tables(intTable).Columns.Add("TOTAL \n SALDO S/.", GetType(Double))
        Next

        Dim totalMONTO As Decimal = 0
        Dim totalSALDO As Decimal = 0
        For intTable As Integer = 2 To oDsProv.Tables.Count - 1
            For f As Integer = 0 To oDsProv.Tables(intTable).Rows.Count - 1
                For c As Integer = 7 To oDsProv.Tables(intTable).Columns.Count - 1
                    If oDsProv.Tables(intTable).Columns.Item(c).ColumnName.Contains("Monto") = True Then
                        totalMONTO += IIf(IsDBNull(oDsProv.Tables(intTable).Rows(f)(c)), 0, oDsProv.Tables(intTable).Rows(f)(c))
                    ElseIf oDsProv.Tables(intTable).Columns.Item(c).ColumnName.Contains("Saldo") = True Then
                        totalSALDO += IIf(IsDBNull(oDsProv.Tables(intTable).Rows(f)(c)), 0, oDsProv.Tables(intTable).Rows(f)(c))
                    End If

                Next
                oDsProv.Tables(intTable).Rows(f)("TOTAL \n MONTO S/.") = totalMONTO
                oDsProv.Tables(intTable).Rows(f)("TOTAL \n SALDO S/.") = totalSALDO
                totalMONTO = 0
                totalSALDO = 0
            Next
        Next



        For k As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsProv.Tables.Count - 1
                If oDtRegion.Rows(k)("CRGVTA") = oDsProv.Tables(intTable).TableName Then
                    oDsProv.Tables(intTable).TableName = oDtRegion.Rows(k)("TCRVTA").ToString.Trim
                End If
            Next
        Next

        Return oDsProv
    End Function


    Public Function fdsListaReversionesExportar(ByVal oFiltro As ProvisionVenta, ByVal intFormato As Integer) As DataSet
        Dim dsResult As New DataSet
        Try
            Dim oServicioDat As New DATOS.clsProvisionDeVenta

            Dim ds As DataSet = oServicioDat.fdsListaReversionesExportar(oFiltro)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)(1) = MonthName(Convert.ToInt32(ds.Tables(0).Rows(i)(1).ToString.Substring(4, 2)), False).ToUpper & " " & Convert.ToInt32(ds.Tables(0).Rows(i)(1).ToString.Substring(0, 4))
                ds.Tables(0).AcceptChanges()
            Next

            ds.Tables(0).Columns("""Nro. Reversión""").Caption = "Numero"
            ds.Tables(0).Columns("""Mes Año""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Negocio""").Caption = "Texto"
            ds.Tables(0).Columns("""Negocio""").Caption = "Texto"
            ds.Tables(0).Columns("""Fecha de Reversión""").Caption = "Fecha"
            ds.Tables(0).Columns("""División""").Caption = "Texto"
            ds.Tables(0).Columns("""Planta""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Cliente Facturar""").Caption = "Numero"
            ds.Tables(0).Columns("""Cliente a Facturar""").Caption = "Texto"
            ds.Tables(0).Columns("""Nr. Revisión""").Caption = "Numero"
            ds.Tables(0).Columns("""Fecha Revisión""").Caption = "Fecha"
            ds.Tables(0).Columns("""Nr. Operación""").Caption = "Numero"
            ds.Tables(0).Columns("""Estado Op. al Provisinar""").Caption = "Texto"
            ds.Tables(0).Columns("""Estado Op. Actual""").Caption = "Texto"
            ds.Tables(0).Columns("""Rubro Especifico""").Caption = "Texto"
            ds.Tables(0).Columns("""Tipo Documento""").Caption = "Texto"
            ds.Tables(0).Columns("""Nro. Documento""").Caption = "Numero"
            ds.Tables(0).Columns("""Fecha Documento""").Caption = "Fecha"

            'ds.Tables(0).Columns("""Cod. CeBe""").Caption = "Numero"
            'ds.Tables(0).Columns("""CeBe SAP""").Caption = "Texto"
            'ds.Tables(0).Columns("""Centro de Beneficio""").Caption = "Texto"
            ds.Tables(0).Columns("""Cod. Ce.Be. Destino""").Caption = "Numero"
            ds.Tables(0).Columns("""Ce.Be. SAP Destino""").Caption = "Texto"
            ds.Tables(0).Columns("""Centro de Beneficio Destino""").Caption = "Texto"


            ds.Tables(0).Columns("""Importe Provisionado S/.""").Caption = "Decimal"



            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                ds.Tables(1).Rows(i)(1) = MonthName(Convert.ToInt32(ds.Tables(1).Rows(i)(1).ToString.Substring(4, 2)), False).ToUpper & " " & Convert.ToInt32(ds.Tables(1).Rows(i)(1).ToString.Substring(0, 4))
            Next
            ds.Tables(1).AcceptChanges()
            ds.Tables(1).Columns("""Nro. Reversión""").Caption = "Numero"
            ds.Tables(1).Columns("""Mes Año""").Caption = "Texto"
            ds.Tables(1).Columns("""Cod. Negocio""").Caption = "Texto"
            ds.Tables(1).Columns("""Negocio""").Caption = "Texto"
            ds.Tables(1).Columns("""Fecha de Reversión""").Caption = "Fecha"
            ds.Tables(1).Columns("""División""").Caption = "Texto"
            ds.Tables(1).Columns("""Nr. Operación""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Op.""").Caption = "Fecha"
            ds.Tables(1).Columns("""Estado Op. al Provisinar""").Caption = "Texto"
            ds.Tables(1).Columns("""Estado Op. Actual""").Caption = "Texto"
            ds.Tables(1).Columns("""Transportista""").Caption = "Texto"
            ds.Tables(1).Columns("""P / T""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Guía Transporte""").Caption = "Texto"
            ds.Tables(1).Columns("""Fecha Guía Transporte""").Caption = "Fecha"
            ds.Tables(1).Columns("""Nro. Liquidación""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Liquidación""").Caption = "Fecha"
            ds.Tables(1).Columns("""N° Referencia SAP""").Caption = "Numero"
            ds.Tables(1).Columns("""Cod. Cliente Facturar""").Caption = "Numero"
            ds.Tables(1).Columns("""Cliente a Facturar""").Caption = "Texto"
            ds.Tables(1).Columns("""Tipo Vehículo""").Caption = "Texto"
            ds.Tables(1).Columns("""Localidad Origen""").Caption = "Texto"
            ds.Tables(1).Columns("""Localidad Destino""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Pre Factura""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Pre Factura""").Caption = "Fecha"
            ds.Tables(1).Columns("""Nro. Pre Liquidación""").Caption = "Numero"
            ds.Tables(1).Columns("""Nro. Provisión""").Caption = "Numero"
            ds.Tables(1).Columns("""Año / Mes""").Caption = "Texto"
            ds.Tables(1).Columns("""N° Orden Interna""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Inicio OI""").Caption = "Fecha"

            'ds.Tables(1).Columns("""Cod. CeBe""").Caption = "Numero"
            'ds.Tables(1).Columns("""Centro de Beneficio""").Caption = "Texto"
            'ds.Tables(1).Columns("""CeBe SAP""").Caption = "Texto"

            ds.Tables(1).Columns("""Cod. Ce.Be. Destino""").Caption = "Numero"
            ds.Tables(1).Columns("""Centro de Beneficio Destino""").Caption = "Texto"
            ds.Tables(1).Columns("""Ce.Be. SAP Destino""").Caption = "Texto"


            ds.Tables(1).Columns("""Tipo Documento""").Caption = "Texto"
            ds.Tables(1).Columns("""Nro. Documento""").Caption = "Numero"
            ds.Tables(1).Columns("""Fecha Documento""").Caption = "Fecha"
            ds.Tables(1).Columns("""Importe Provisionado S/.""").Caption = "Decimal"

            If intFormato = 1 Then
                dsResult = CrearTablaResumenReversion_Formato01(ds)
            Else
                dsResult = CrearTablaResumenReversion_Formato02(ds)
            End If

        Catch ex As Exception
        End Try

        Return dsResult
    End Function

    Private Function CrearTablaResumenReversion_Formato01(ByVal ds As DataSet) As DataSet
        Dim oDtMeses As New DataTable
        Dim oDsRev As New DataSet

        Dim oDtDatCli As New DataTable
        Dim oDtRegion As New DataTable

        oDsRev.Tables.Add(ds.Tables(0).Copy)
        oDsRev.Tables(0).TableName = "OPERACIONES DE ADMINISTRACIÓN"

        oDsRev.Tables.Add(ds.Tables(1).Copy)
        oDsRev.Tables(1).TableName = "OPERACIONES DE TRANSPORTES"

        oDtDatCli = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA", "CCLNFC", "TCMPCL", "TCMTRF", "CCNTCS", "TCNTCS", "CCNBNS")
        oDtRegion = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA")
        oDtMeses = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "ANOMES")

        Dim dView As New DataView(oDtMeses)
        dView.Sort = "CRGVTA,ANOMES ASC"
        Dim dtMes As DataTable = dView.ToTable(True, "CRGVTA", "ANOMES")

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            Dim dt1 As New DataTable


            dt1.Columns.Add("Cod. Cliente", GetType(Integer))
            dt1.Columns.Add("Razón Social", GetType(String))
            dt1.Columns.Add("Rubro", GetType(String))
            dt1.Columns.Add("Cod. CeBe", GetType(Integer))
            dt1.Columns.Add("Centro de Beneficio", GetType(String))
            dt1.Columns.Add("CeBe SAP", GetType(String))

            dt1.TableName = oDtRegion.Rows(x)("CRGVTA").ToString.Trim
            Dim dr As DataRow = Nothing
            For w As Integer = 0 To oDtDatCli.Rows.Count - 1
                If oDtRegion.Rows(x)("CRGVTA") = oDtDatCli.Rows(w)("CRGVTA") Then
                    dr = dt1.NewRow
                    dr(0) = oDtDatCli.Rows(w)("CCLNFC")
                    dr(1) = oDtDatCli.Rows(w)("TCMPCL")
                    dr(2) = oDtDatCli.Rows(w)("TCMTRF")
                    dr(3) = oDtDatCli.Rows(w)("CCNTCS")
                    dr(4) = oDtDatCli.Rows(w)("TCNTCS")
                    dr(5) = oDtDatCli.Rows(w)("CCNBNS")
                    dt1.Rows.Add(dr)
                End If
            Next
            oDsRev.Tables.Add(dt1)
        Next

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsRev.Tables.Count - 1
                If oDsRev.Tables(intTable).TableName = oDtRegion.Rows(x)(0) Then
                    For i As Integer = 0 To dtMes.Rows.Count - 1
                        If dtMes.Rows(i).Item("CRGVTA") = oDsRev.Tables(intTable).TableName Then
                            oDsRev.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto"), GetType(Double))
                            'oDsRev.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo"), GetType(Double))
                        End If
                    Next
                End If
            Next
        Next


        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            For x As Integer = 0 To oDsRev.Tables(intTable).Rows.Count - 1
                For i As Integer = 0 To ds.Tables(2).Rows.Count - 1
                    If oDsRev.Tables(intTable).TableName = ds.Tables(2).Rows(i)("CRGVTA") Then
                        If oDsRev.Tables(intTable).Rows(x).Item(0).ToString.Trim = ds.Tables(2).Rows(i).Item("CCLNFC").ToString.Trim And oDsRev.Tables(intTable).Rows(x).Item(2).ToString.Trim = ds.Tables(2).Rows(i).Item("TCMTRF").ToString.Trim And oDsRev.Tables(intTable).Rows(x).Item(3).ToString = ds.Tables(2).Rows(i).Item("CCNTCS").ToString And oDsRev.Tables(intTable).Rows(x).Item(4).ToString.Trim = ds.Tables(2).Rows(i).Item("TCNTCS").ToString().Trim And oDsRev.Tables(intTable).Rows(x).Item(5).ToString.Trim = ds.Tables(2).Rows(i).Item("CCNBNS").ToString().Trim Then
                            oDsRev.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto")) = ds.Tables(2).Rows(i)("MONTO")
                            'oDsRev.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(1).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(1).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo")) = ds.Tables(1).Rows(i)("SALDO")
                        End If
                    End If
                Next
            Next

        Next

        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            oDsRev.Tables(intTable).Columns.Add("TOTAL \n MONTO S/.", GetType(Double))
            'oDsRev.Tables(intTable).Columns.Add("TOTAL \n SALDO S/.", GetType(Double))
        Next

        Dim totalMONTO As Decimal = 0
        'Dim totalSALDO As Decimal = 0
        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            For f As Integer = 0 To oDsRev.Tables(intTable).Rows.Count - 1
                For c As Integer = 5 To oDsRev.Tables(intTable).Columns.Count - 1
                    If oDsRev.Tables(intTable).Columns.Item(c).ColumnName.Contains("Monto") = True Then
                        totalMONTO += IIf(IsDBNull(oDsRev.Tables(intTable).Rows(f)(c)), 0, oDsRev.Tables(intTable).Rows(f)(c))
                        'ElseIf oDsRev.Tables(intTable).Columns.Item(c).ColumnName.Contains("Saldo") = True Then
                        'totalSALDO += IIf(IsDBNull(oDsRev.Tables(intTable).Rows(f)(c)), 0, oDsRev.Tables(intTable).Rows(f)(c))
                    End If

                Next
                oDsRev.Tables(intTable).Rows(f)("TOTAL \n MONTO S/.") = totalMONTO
                'oDsRev.Tables(intTable).Rows(f)("TOTAL \n SALDO S/.") = totalSALDO
                totalMONTO = 0
                'totalSALDO = 0
            Next
        Next

        For k As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsRev.Tables.Count - 1
                If oDtRegion.Rows(k)("CRGVTA") = oDsRev.Tables(intTable).TableName Then
                    oDsRev.Tables(intTable).TableName = oDtRegion.Rows(k)("TCRVTA").ToString.Trim
                End If
            Next
        Next

        Return oDsRev

    End Function


    Private Function CrearTablaResumenReversion_Formato02(ByVal ds As DataSet) As DataSet
        Dim oDtMeses As New DataTable
        Dim oDsRev As New DataSet

        Dim oDtDatCli As New DataTable
        Dim oDtRegion As New DataTable

        oDsRev.Tables.Add(ds.Tables(0).Copy)
        oDsRev.Tables(0).TableName = "OPERACIONES DE ADMINISTRACIÓN"

        oDsRev.Tables.Add(ds.Tables(1).Copy)
        oDsRev.Tables(1).TableName = "OPERACIONES DE TRANSPORTES"

        oDtDatCli = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA", "CCLNFC", "TCMPCL", "TCMTRF", "CCNTCS", "TCNTCS", "CCNBNS")
        oDtRegion = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "TCRVTA")
        oDtMeses = ds.Tables(2).DefaultView.ToTable(True, "CRGVTA", "ANOMES")

        Dim dView As New DataView(oDtMeses)
        dView.Sort = "CRGVTA,ANOMES ASC"
        Dim dtMes As DataTable = dView.ToTable(True, "CRGVTA", "ANOMES")

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            Dim dt1 As New DataTable

            dt1.Columns.Add("Cuenta Mayor", GetType(Integer))
            dt1.Columns.Add("Nro. Doc.", GetType(String))
            dt1.Columns.Add("Cod. Cliente", GetType(Integer))
            dt1.Columns.Add("Razón Social", GetType(String))
            dt1.Columns.Add("Rubro", GetType(String))
            dt1.Columns.Add("Cod. CeBe", GetType(Integer))
            dt1.Columns.Add("Centro de Beneficio", GetType(String))
            dt1.Columns.Add("CeBe SAP", GetType(String))

            dt1.TableName = oDtRegion.Rows(x)("CRGVTA").ToString.Trim
            Dim dr As DataRow = Nothing
            For w As Integer = 0 To oDtDatCli.Rows.Count - 1
                If oDtRegion.Rows(x)("CRGVTA") = oDtDatCli.Rows(w)("CRGVTA") Then
                    dr = dt1.NewRow
                    dr(2) = oDtDatCli.Rows(w)("CCLNFC")
                    dr(3) = oDtDatCli.Rows(w)("TCMPCL")
                    dr(4) = oDtDatCli.Rows(w)("TCMTRF")
                    dr(5) = oDtDatCli.Rows(w)("CCNTCS")
                    dr(6) = oDtDatCli.Rows(w)("TCNTCS")
                    dr(7) = oDtDatCli.Rows(w)("CCNBNS")
                    dt1.Rows.Add(dr)
                End If
            Next
            oDsRev.Tables.Add(dt1)
        Next

        For x As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsRev.Tables.Count - 1
                If oDsRev.Tables(intTable).TableName = oDtRegion.Rows(x)(0) Then
                    For i As Integer = 0 To dtMes.Rows.Count - 1
                        If dtMes.Rows(i).Item("CRGVTA") = oDsRev.Tables(intTable).TableName Then
                            oDsRev.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto"), GetType(Double))
                            'oDsRev.Tables(intTable).Columns.Add(String.Format("{0} \n {1} \n {2}", dtMes.Rows(i).Item("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(dtMes.Rows(i).Item("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo"), GetType(Double))
                        End If
                    Next
                End If
            Next
        Next


        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            For x As Integer = 0 To oDsRev.Tables(intTable).Rows.Count - 1
                For i As Integer = 0 To ds.Tables(2).Rows.Count - 1
                    If oDsRev.Tables(intTable).TableName = ds.Tables(2).Rows(i)("CRGVTA") Then
                        If oDsRev.Tables(intTable).Rows(x).Item(2).ToString.Trim = ds.Tables(2).Rows(i).Item("CCLNFC").ToString.Trim And oDsRev.Tables(intTable).Rows(x).Item(4).ToString.Trim = ds.Tables(2).Rows(i).Item("TCMTRF").ToString.Trim And oDsRev.Tables(intTable).Rows(x).Item(5).ToString = ds.Tables(2).Rows(i).Item("CCNTCS").ToString And oDsRev.Tables(intTable).Rows(x).Item(6).ToString.Trim = ds.Tables(2).Rows(i).Item("TCNTCS").ToString().Trim And oDsRev.Tables(intTable).Rows(x).Item(7).ToString.Trim = ds.Tables(2).Rows(i).Item("CCNBNS").ToString().Trim Then
                            oDsRev.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(2).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(2).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Monto")) = ds.Tables(2).Rows(i)("MONTO")
                            'oDsRev.Tables(intTable).Rows(x)(String.Format("{0} \n {1} \n {2}", ds.Tables(1).Rows(i)("ANOMES").ToString().Substring(0, 4), MonthName(Convert.ToInt32(ds.Tables(1).Rows(i)("ANOMES").ToString.Substring(4, 2)), False).ToUpper, "Saldo")) = ds.Tables(1).Rows(i)("SALDO")
                        End If
                    End If
                Next
            Next

        Next

        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            oDsRev.Tables(intTable).Columns.Add("TOTAL \n MONTO S/.", GetType(Double))
            'oDsRev.Tables(intTable).Columns.Add("TOTAL \n SALDO S/.", GetType(Double))
        Next

        Dim totalMONTO As Decimal = 0
        'Dim totalSALDO As Decimal = 0
        For intTable As Integer = 2 To oDsRev.Tables.Count - 1
            For f As Integer = 0 To oDsRev.Tables(intTable).Rows.Count - 1
                For c As Integer = 7 To oDsRev.Tables(intTable).Columns.Count - 1
                    If oDsRev.Tables(intTable).Columns.Item(c).ColumnName.Contains("Monto") = True Then
                        totalMONTO += IIf(IsDBNull(oDsRev.Tables(intTable).Rows(f)(c)), 0, oDsRev.Tables(intTable).Rows(f)(c))
                        'ElseIf oDsRev.Tables(intTable).Columns.Item(c).ColumnName.Contains("Saldo") = True Then
                        'totalSALDO += IIf(IsDBNull(oDsRev.Tables(intTable).Rows(f)(c)), 0, oDsRev.Tables(intTable).Rows(f)(c))
                    End If

                Next
                oDsRev.Tables(intTable).Rows(f)("TOTAL \n MONTO S/.") = totalMONTO
                'oDsRev.Tables(intTable).Rows(f)("TOTAL \n SALDO S/.") = totalSALDO
                totalMONTO = 0
                'totalSALDO = 0
            Next
        Next

        For k As Integer = 0 To oDtRegion.Rows.Count - 1
            For intTable As Integer = 2 To oDsRev.Tables.Count - 1
                If oDtRegion.Rows(k)("CRGVTA") = oDsRev.Tables(intTable).TableName Then
                    oDsRev.Tables(intTable).TableName = oDtRegion.Rows(k)("TCRVTA").ToString.Trim
                End If
            Next
        Next

        Return oDsRev

    End Function
    Public Function fIntObtenerUltimoControl() As Decimal
        Dim oServicioDat As New DATOS.clsProvisionDeVenta
        Return oServicioDat.fIntObtenerUltimoControl()
    End Function

    'INI-ECM-Estimación-de-Ingreso-Anulación[RF001]
    ''' <summary>
    ''' Valida que las estimaciones no cuenten con ninguna reversión de provisión
    ''' </summary>
    ''' <param name="filtro">CCMPN, NMPRV</param>
    Public Function ValidarAnulacionProvision(ByVal parametros As ProvisionVenta) As Integer
        Dim datos As New DATOS.clsProvisionDeVenta
        Return datos.ValidarAnulacionProvision(parametros)
    End Function

    ''' <summary>
    ''' Realiza la anulación de provisiones
    ''' </summary>
    ''' <param name="filtro">CCMPN, NMPRVT, USUARIO, NTRMCR</param>
    Public Sub AnularProvision(ByVal parametros As ProvisionVenta)
        Dim datos As New DATOS.clsProvisionDeVenta
        datos.AnularProvision(parametros)
    End Sub

    ''' <summary>
    ''' Obtiene la lista de provisiones
    ''' </summary>
    ''' <param name="parametros">CCMPN, NMRVVT</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerListaProvisiones(ByVal parametros As ProvisionVenta) As List(Of RequestDataReversion)
        Dim datos As New DATOS.clsProvisionDeVenta
        Return datos.ObtenerListaProvisiones(parametros)
    End Function
    'FIN-ECM-Estimación-de-Ingreso-Anulación[RF001]
End Class