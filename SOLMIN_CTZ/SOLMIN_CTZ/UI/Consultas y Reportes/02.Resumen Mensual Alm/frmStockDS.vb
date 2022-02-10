Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmStockDS


    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property


    Private _pCodClientes As String
    Public Property pCodClientes() As String
        Get
            Return _pCodClientes
        End Get
        Set(ByVal value As String)
            _pCodClientes = value
        End Set
    End Property

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        pcxEspera.Visible = True
        bgwGifAnimado.RunWorkerAsync()
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteStockProductoR01()
    End Sub

    Private Sub pReporteStockProductoR01()
        Dim obrResumenMensualAlm As New clsResumenMensualAlmacenes
        Dim obeFiltro As New ResumenMensualAlmacenes

        Dim intIsInventarioActual As Integer = 1
        Dim strMensaje As String = String.Empty
        Dim DtReporte As New DataTable
        Try
            With obeFiltro

                .PSCCLNT = pCodClientes
                .PSCTPDP6 = "1"
                .PNFECINV = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInventario.Value)
            End With

            DtReporte = obrResumenMensualAlm.fodtInventarioDSResumenMensual(obeFiltro)
        Catch ex As Exception
        End Try
        Try

     
            Dim oDt As DataTable
            Dim oDs As New DataSet
            oDt = DtReporte.Copy
            For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
                If oDt.Rows(i).Item("NORDSR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORDSR").ToString.Trim) Then
                    'oDt.Rows(i).Item(0) = DBNull.Value
                    'oDt.Rows(i).Item(1) = ""
                    oDt.Rows(i).Item(2) = ""
                    oDt.Rows(i).Item(3) = DBNull.Value
                    oDt.Rows(i).Item(4) = ""
                    oDt.Rows(i).Item(5) = ""
                    oDt.Rows(i).Item(6) = DBNull.Value
                    oDt.Rows(i).Item(7) = DBNull.Value
                    oDt.Rows(i).Item(8) = ""
                    oDt.Rows(i).Item(9) = DBNull.Value
                    oDt.Rows(i).Item(10) = ""
                    oDt.Rows(i).Item(11) = DBNull.Value
                    oDt.Rows(i).Item(12) = ""
                End If
            Next

            oDt.TableName = "Inventario de Productos"
            oDt.Columns(0).ColumnName = "CLIENTE \n CÓDIGO"
            oDt.Columns(1).ColumnName = "CLIENTE \n RAZON SOCIAL"
            oDt.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
            oDt.Columns(3).ColumnName = "ORDEN \n SERVICIO"
            oDt.Columns(4).ColumnName = "CODIGO \n RANSA"
            oDt.Columns(5).ColumnName = "DETALLE \n MERCADERIA"
            oDt.Columns(6).ColumnName = "FECHA ULT MOV \n INGRESO"
            oDt.Columns(7).ColumnName = "FECHA ULT MOV \n SALIDA"
            oDt.Columns(8).ColumnName = "REF. UBICACIÓN"
            oDt.Columns(9).ColumnName = "SALDO \n CANTIDAD"
            oDt.Columns(10).ColumnName = "SALDO \n UNIDAD"
            oDt.Columns(11).ColumnName = "SALDO \n PESO"
            oDt.Columns(12).ColumnName = "SALDO \n UNIDAD "

            'Dim oDtClientes As DataTable = oDt.Copy
            'Dim oDtResultado As DataTable
            'oDtResultado = oDt.Clone
            'Dim oDv As New DataView(oDtClientes)
            ''oDv.Sort = "NRTFSV ASC"
            'Dim oDrs As DataRow()
            'Dim oDrResultado As DataRow
            'oDtClientes = oDv.ToTable(True, "CCLNT")
            'For intCont As Integer = 0 To oDtClientes.Rows.Count - 1
            '    oDtResultado = New DataTable
            '    oDtResultado = oDt.Clone
            '    oDtResultado.TableName = oDtClientes.Rows(intCont).Item("CCLNT").ToString
            '    oDrs = oDt.Select("CCLNT = " & oDtClientes.Rows(intCont).Item("CCLNT"))
            '    For Each oDr As DataRow In oDrs
            '        oDrResultado = oDtResultado.NewRow
            '        For intColumns As Integer = 0 To oDtResultado.Columns.Count - 1
            '            oDrResultado(intColumns) = oDr(intColumns)
            '        Next
            '        oDtResultado.Rows.Add(oDrResultado)
            '    Next
            '    oDtResultado.Columns(0).ColumnName = "CLIENTE \n CÓDIGO"
            oDs.Tables.Add(oDt)
            'Next
            Dim strTitulo As New List(Of String)
            'strTitulo.Add("Cliente: \n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
            strTitulo.Add("Fecha Inventario : \n" & Date.Now.ToShortDateString)

            '==========================Exportamos==========================
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
        Catch ex As Exception

        End Try

    End Sub

End Class
