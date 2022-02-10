Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Public Class clsServicioOperacion
    'Public Function Lista_Operaciones_Facturadas(ByVal oServicio As ServicioOperacion) As DataTable
    '    Dim oServicioDat As New DATOS.clsServicioOperacion
    '    Return oServicioDat.Lista_Operaciones_Facturadas(oServicio)
    'End Function
    'Public Function Lista_ServiciosRefactura_x_Operacion(ByVal oServicio As ServicioOperacion) As DataTable
    '    Dim oServicioDat As New DATOS.clsServicioOperacion
    '    Return oServicioDat.Lista_ServiciosRefactura_x_Operacion(oServicio)
    'End Function
    Public Function Lista_Servicios_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Lista_Servicios_Documento(oServicio)
    End Function

    'Public Function Lista_Operacion_Refactura(ByVal oLisServicio As List(Of ServicioOperacion)) As DataTable
    Public Function Lista_Operacion_Refactura(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Dim dt As New DataTable
        Dim dtResult As New DataTable
        'dt = oServicioDat.Lista_Operacion_Refactura(oLisServicio(0))
        dt = oServicioDat.Lista_Operacion_Refactura(oServicio)
        dtResult = dt.Copy

        Return dtResult.Copy
    End Function

    Public Function Lista_Operacion_Servicio_Refactura(ByVal oLisServicio As List(Of ServicioOperacion)) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Dim dt As New DataTable
        Dim dtResult As New DataTable
        dt = oServicioDat.Lista_Operacion_Servicio_Refactura(oLisServicio(0))

        dtResult = dt.Copy
        'dtResult.Clear()
        If oLisServicio.Count > 1 Then
            For FilaIndex As Integer = 1 To oLisServicio.Count - 1
                dt = oServicioDat.Lista_Operacion_Servicio_Refactura(oLisServicio(FilaIndex))
                For Fila As Integer = 0 To dt.Rows.Count - 1
                    dtResult.ImportRow(dt.Rows(Fila))
                Next
            Next
        End If
        Return dtResult.Copy
    End Function

    Public Function Lista_Servicios_Operacion_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Lista_Servicios_Operacion_Documento(oServicio)
    End Function

    Public Function Lista_Cuenta_Corriente_Refactura(ByVal oServicio As ServicioOperacion, ByRef Num_pag As Integer) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Lista_Cuenta_Corriente_Refactura(oServicio, Num_pag)
    End Function

    Public Function Lista_Servicios_X_Documento(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Lista_Servicios_X_Documento(oServicio)
    End Function
    Public Function Lista_Cuenta_Corriente_Refactura_Referencia(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Lista_Cuenta_Corriente_Refactura_Referencia(oServicio)
    End Function

    Public Function fdtLista_Consistencia_Facturacion_Tarifia_Fija(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Dim oDt As New DataTable
        oDt = oServicioDat.fdtLista_Consistencia_Facturacion_Tarifia_Fija(oServicio)
        If oDt.Rows.Count > 0 Then
            oDt.Columns.Add("chk")
        End If
        Return oDt
    End Function
    Public Function Verifica_Doc_Historial_Refactura(ByVal PNCTPODC As Decimal, ByVal PNNDCFCC As Decimal) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.Verifica_Doc_Historial_Refactura(PNCTPODC, PNNDCFCC)
    End Function

    Public Function fdtLista_Operaciones_Revisada(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.fdtLista_Operaciones_Revisada(oServicio)
    End Function

    Public Function fdsLista_Operaciones_Revisada_Exportar(ByVal oServicio As ServicioOperacion) As DataSet
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.fdsLista_Operaciones_Revisada_Exportar(oServicio)
    End Function

    Public Function fdtLista_Operaciones_Facturadas_FM(ByVal oServicio As ServicioOperacion) As DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Return oServicioDat.fdtLista_Operaciones_Facturadas_FM(oServicio)
    End Function
    Public Function fdsLista_Operaciones_Facturadas_FM_Exportar(ByVal oServicio As ServicioOperacion) As DataSet
        Dim oServicioDat As New DATOS.clsServicioOperacion
        Dim dsResult As New DataSet
        Dim ds As DataSet = oServicioDat.fdsLista_Operaciones_Facturadas_FM_Exportar(oServicio)
        Dim dt As DataTable
        dt = CrearTablaResumenMensual(ds.Tables(1))
        dsResult.Tables.Add(ds.Tables(0).Copy)
        dsResult.Tables.Add(dt)
        Return dsResult
    End Function
    Private Function CrearTablaResumenMensual(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        Dim dtnew As DataTable = dt.Copy
        dtnew.Columns(0).ColumnName = "CodCliente"
        dtnew.Columns(1).ColumnName = "RazónSocial"
        dtnew.Columns(2).ColumnName = "CodCeBe"
        dtnew.Columns(3).ColumnName = "CeBeSAP"
        dtnew.Columns(4).ColumnName = "CentroBeneficio"
        dtnew.Columns(5).ColumnName = "Anio"
        dtnew.Columns(6).ColumnName = "Mes"
        'dtnew.Columns(5).ColumnName = "Moneda"
        dtnew.Columns(7).ColumnName = "MontoSoles"


        Dim lstMeses As New List(Of String)
        lstMeses.Add("Todos")
        lstMeses.Add("Enero")
        lstMeses.Add("Febrero")
        lstMeses.Add("Marzo")
        lstMeses.Add("Abril")
        lstMeses.Add("Mayo")
        lstMeses.Add("Junio")
        lstMeses.Add("Julio")
        lstMeses.Add("Agosto")
        lstMeses.Add("Setiembre")
        lstMeses.Add("Octubre")
        lstMeses.Add("Noviembre")
        lstMeses.Add("Diciembre")

        Dim dtv As New DataView(dtnew)
        dtv.Sort = "Anio,Mes asc"
        Dim dataV As DataTable = dtv.ToTable(True, "Anio", "Mes")

        'creandp el datatable dinamico de acuerdo a los meses
        dtTemp.Columns.Add("Cod. Cliente", GetType(Integer))
        dtTemp.Columns.Add("Razón Social", GetType(String))
        dtTemp.Columns.Add("Cod. CeBe", GetType(Integer))
        dtTemp.Columns.Add("CeBe SAP", GetType(String))
        dtTemp.Columns.Add("Centro de Beneficio", GetType(String))

        For i As Integer = 0 To dataV.Rows.Count - 1
            dtTemp.Columns.Add(String.Format("{0} \n {1} ", dataV.Rows(i)("Anio"), lstMeses(CType(dataV.Rows(i)("Mes"), Integer)).ToUpper), GetType(Decimal))
            ''dtTemp.Columns.Add(String.Format("{0} \n {1} \n S/.", dataV.Rows(i)("Anio"), lstMeses(CType(dataV.Rows(i)("Mes"), Integer)).ToUpper), GetType(Decimal))
        Next
        'dtTemp.Columns.Add("TOTAL \n USD", GetType(Double))
        dtTemp.Columns.Add("TOTAL \n S/.", GetType(Double))
        Dim dv As New DataView(dtnew)
        Dim data As DataTable = dv.ToTable(True, "CodCeBe")
        Dim datar() As DataRow
        Dim datRowNew As DataRow
        For x As Integer = 0 To data.Rows.Count - 1
            datRowNew = dtTemp.NewRow

            Dim dvPorMeses As New DataView(dtnew)
            dv.RowFilter = String.Format("CodCeBe={0}", data.Rows(x).Item("CodCeBe"))
            Dim dataPorMeses As DataTable = dv.ToTable(True, "CodCliente", "CodCeBe", "Anio", "Mes")

            For c As Integer = 0 To dataPorMeses.Rows.Count - 1
                datar = dtnew.Select(String.Format("CodCeBe={0} and Anio={1} AND Mes={2} AND CodCliente={3}", data.Rows(x).Item("CodCeBe"), dataPorMeses.Rows(c).Item("Anio"), dataPorMeses.Rows(c).Item("Mes"), dataPorMeses.Rows(c).Item("CodCliente")))
                datRowNew("Cod. Cliente") = datar(0).Item("CodCliente")
                datRowNew("Razón Social") = datar(0).Item("RazónSocial")
                datRowNew("Cod. CeBe") = datar(0).Item("CodCeBe")
                datRowNew("CeBe SAP") = datar(0).Item("CeBeSAP")
                datRowNew("Centro de Beneficio") = datar(0).Item("CentroBeneficio").ToString.Trim
                'datRowNew("Mes") = datar(0).Item("MES")
                If datar.Length = 1 Then
                    'If datar(0).Item("Moneda").ToString.Trim.Equals("USD") Then
                    '    datRowNew(String.Format("{0} \n {1} \n USD", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(0).Item("Monto")
                    'Else
                    datRowNew(String.Format("{0} \n {1} ", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(0).Item("MontoSoles")
                    'End If
                    'ElseIf datar.Length = 2 Then
                    'If datar(0).Item("Moneda").ToString.Trim.Equals("USD") Then
                    '    datRowNew(String.Format("{0} \n {1} \n USD", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(0).Item("Monto")
                    'Else
                    '    datRowNew(String.Format("{0} \n {1} \n S/.", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(0).Item("Monto")
                    'End If
                    'If datar(1).Item("Moneda").ToString.Trim.Equals("USD") Then
                    '    datRowNew(String.Format("{0} \n {1} \n USD", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(1).Item("Monto")
                    'Else
                    '    datRowNew(String.Format("{0} \n {1} \n S/.", datar(0).Item("Anio"), lstMeses(CType(datar(0).Item("Mes").ToString.Trim, Integer)).ToUpper.Trim)) = datar(1).Item("Monto")
                    'End If
                End If

            Next
            dtTemp.Rows.Add(datRowNew)
        Next
        'calculamos los total horizontalmente
        Dim totalHDOL As Decimal = 0
        Dim totalHSOL As Decimal = 0
        For f As Integer = 0 To dtTemp.Rows.Count - 1
            For c As Integer = 5 To dtTemp.Columns.Count - 1
                'If dtTemp.Columns(c).ColumnName.Contains("USD") Then
                '    totalHDOL += IIf(IsDBNull(dtTemp.Rows(f)(c)), 0, dtTemp.Rows(f)(c))
                'Else
                totalHSOL += IIf(IsDBNull(dtTemp.Rows(f)(c)), 0, dtTemp.Rows(f)(c))
                'End If
            Next
            'dtTemp.Rows(f)("TOTAL \n USD") = totalHDOL
            dtTemp.Rows(f)("TOTAL \n S/.") = totalHSOL
            totalHDOL = 0
            totalHSOL = 0
        Next
        'datRowNew = dtTemp.NewRow
        'datRowNew("Centro de Beneficio") = "TOTAL"
        'dtTemp.Rows.Add(datRowNew)
        ''calculamos los total verticalmente
        'Dim totalV As Decimal
        'Dim fila As Integer = dtTemp.Rows.Count - 1
        'For c As Integer = 3 To dtTemp.Columns.Count - 1
        '    For f As Integer = 0 To dtTemp.Rows.Count - 2
        '        totalV += IIf(IsDBNull(dtTemp.Rows(f)(c)), 0, dtTemp.Rows(f)(c))
        '    Next
        '    dtTemp.Rows(fila)(c) = totalV
        '    totalV = 0
        'Next

        Return dtTemp
    End Function


    'JM
    'Public Function Lista_Operacion_Servicio_Refactura_FE(ByVal oLisServicio As List(Of ServicioOperacion)) As DataTable
    '    Dim oServicioDat As New DATOS.clsServicioOperacion
    '    Dim dt As New DataTable
    '    Dim dtResult As New DataTable
    '    dt = oServicioDat.Lista_Operacion_Servicio_Refactura(oLisServicio(0))
    '    dtResult = dt.Copy
    '    'dtResult.Clear()
    '    If oLisServicio.Count > 1 Then
    '        For FilaIndex As Integer = 1 To oLisServicio.Count - 1
    '            dt = oServicioDat.Lista_Operacion_Servicio_Refactura(oLisServicio(FilaIndex))
    '            For Fila As Integer = 0 To dt.Rows.Count - 1
    '                dtResult.ImportRow(dt.Rows(Fila))
    '            Next
    '        Next
    '    End If
    '    Return dtResult.Copy
    'End Function

    Public Function Lista_Operacion_Servicio_Refactura_FE(ByVal oServ As ServicioOperacion) As DataTable
        Dim dt As New DataTable
        Dim oServicioDat As New DATOS.clsServicioOperacion
        dt = oServicioDat.Lista_Operacion_Servicio_Refactura(oServ)
        Return dt.Copy
    End Function


End Class
