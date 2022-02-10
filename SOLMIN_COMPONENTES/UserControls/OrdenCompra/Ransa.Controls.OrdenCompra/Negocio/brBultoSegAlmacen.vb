Imports RANSA.DATA
Imports RANSA.TypeDef

Public Class brBultoSegAlmacen
  Dim oDatos As New daBultoSegAlmacen

  Public Function ListarMovimientoItemOrdenCompra(ByVal obeBulto As beBultoSegAlmacen) As DataTable

    Dim dtResultado As DataTable = Nothing
    Dim strMensajeError As String = ""
    dtResultado = oDatos.ListarMovimientoItemOrdenCompra(obeBulto)
    If dtResultado.Rows.Count = 0 Then Return dtResultado
    Dim dtIngresos As DataTable = dtResultado.Copy
    Dim dtSalidas As DataTable = dtResultado.Copy
    dtIngresos.AcceptChanges()
    dtSalidas.AcceptChanges()

    Dim drs() As DataRow
    drs = dtIngresos.Select("INGSDA = 'SDA'")
    For Each dr As DataRow In drs
      dtIngresos.Rows.Remove(dr)
    Next
    drs = dtSalidas.Select("INGSDA = 'ING'")
    For Each dr As DataRow In drs
      dtSalidas.Rows.Remove(dr)
    Next
    dtIngresos.AcceptChanges()
    dtSalidas.AcceptChanges()
    'dtSalidas.LoadDataRow(dtResultado.Select("INGSDA" = "SAL"), True)
    Dim cols(20) As DataColumn
    dtSalidas.Columns.CopyTo(cols, 0)
    For Each col As DataColumn In cols
      If dtSalidas.Columns.CanRemove(col) Then
        dtSalidas.Columns.Remove(col)
      End If
      col.ColumnName = col.ColumnName & "1"
      dtIngresos.Columns.Add(col)
    Next
    dtIngresos.AcceptChanges()
    dtSalidas = dtResultado.Copy
    drs = dtSalidas.Select("INGSDA = 'ING'")
    For Each dr As DataRow In drs
      dtSalidas.Rows.Remove(dr)
    Next
    For Each dr As DataRow In dtIngresos.Rows
      drs = dtSalidas.Select(String.Format("CREFFW = '{0}' AND NSEQIN ='{1}' ", dr("CREFFW"), dr("NSEQIN")))
      If drs.Length > 0 Then
        Dim d As DataRow = drs(0)
        For Each col As DataColumn In dtSalidas.Columns
          dr(col.ColumnName + "1") = d(col.ColumnName)
        Next
      End If
    Next
    'Dim dv As New DataView(dtIngresos)
    'dv.ToTable(True, Columnas)
    Return dtIngresos
  End Function


  ' ITEMS

  Public Function ListarMovimientoDetalle_X_ItemOrdenCompra(ByVal obeBulto As beBultoSegAlmacen) As DataTable

    Dim dtResultado As DataTable = Nothing
    Dim strMensajeError As String = ""
    dtResultado = oDatos.ListarMovimientoDetalle_X_ItemOrdenCompra(obeBulto)
    If dtResultado.Rows.Count = 0 Then Return dtResultado
    Dim dtIngresos As DataTable = dtResultado.Copy
    Dim dtSalidas As DataTable = dtResultado.Copy
    dtIngresos.AcceptChanges()
    dtSalidas.AcceptChanges()

    Dim drs() As DataRow
    drs = dtIngresos.Select("INGSDA = 'SDA'")
    For Each dr As DataRow In drs
      dtIngresos.Rows.Remove(dr)
    Next
    drs = dtSalidas.Select("INGSDA = 'ING'")
    For Each dr As DataRow In drs
      dtSalidas.Rows.Remove(dr)
    Next
    dtIngresos.AcceptChanges()
    dtSalidas.AcceptChanges()
    'dtSalidas.LoadDataRow(dtResultado.Select("INGSDA" = "SAL"), True)
    Dim cols(21) As DataColumn
    dtSalidas.Columns.CopyTo(cols, 0)
    For Each col As DataColumn In cols
      If dtSalidas.Columns.CanRemove(col) Then
        dtSalidas.Columns.Remove(col)
      End If
      col.ColumnName = col.ColumnName & "1"
      dtIngresos.Columns.Add(col)
    Next
    dtIngresos.AcceptChanges()
    dtSalidas = dtResultado.Copy
    drs = dtSalidas.Select("INGSDA = 'ING'")
    For Each dr As DataRow In drs
      dtSalidas.Rows.Remove(dr)
    Next
    For Each dr As DataRow In dtIngresos.Rows
      drs = dtSalidas.Select(String.Format("CREFFW = '{0}' AND NSEQIN ='{1}' ", dr("CREFFW"), dr("NSEQIN")))
      If drs.Length > 0 Then
        Dim d As DataRow = drs(0)
        For Each col As DataColumn In dtSalidas.Columns
          dr(col.ColumnName + "1") = d(col.ColumnName)
        Next
      End If
    Next
    'Dim dv As New DataView(dtIngresos)
    'dv.ToTable(True, Columnas)
    Return dtIngresos
  End Function

  Public Function ListarDetalleBulto(ByVal obeBultoPK As beBultoSegAlmacen) As DataTable
    Return oDatos.ListarDetalleBulto(obeBultoPK)
  End Function

End Class
