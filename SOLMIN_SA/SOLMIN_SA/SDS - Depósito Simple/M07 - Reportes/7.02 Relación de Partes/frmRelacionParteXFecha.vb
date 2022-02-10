Imports Ransa.TypeDef.Reportes
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.TYPEDEF.Mercaderia
Imports RANSA.Utilitario

Public Class frmRelacionParteXFecha
#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private DtReporteIngreso As New DataTable
    Private DtReporteSalida As New DataTable
    Private obeFiltroActual As New beFiltrosDespachoPorAlmacen
    Private obeFiltro As New beFiltrosDespachoPorAlmacen
    Private rptTemp1 = New rptRelacionParteXFecha01
    Private rptTemp2 = New rptRelacionParteXFecha02
    Private oPrintRelCliXFechaForm As New PrintForm


#End Region
#Region "Propiedades"

#End Region
#Region "Eventos de Control"
    Private Sub frmRelacionParteXFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarCompania()
        CargarDeposito()
        CargarClientes()
    End Sub


    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        Dim objDtRep As New DataTable
        Dim oReporte As New brReporteDS
        Try
            If TabDetalle.SelectedIndex = 0 Then
                With obeFiltroActual
                    .PNNPRTIN = dgIngreso.CurrentRow.Cells("NPRTIN").Value()
                    .PNCCLNT = dgIngreso.CurrentRow.Cells("cclnt").Value()
                End With
                objDtRep = oReporte.dtRepDetalleNroParte(obeFiltroActual)

                If objDtRep.Rows.Count > 0 Then

                    objDtRep.TableName = "RelacionPartesXFecha"
                    rptTemp1.SetDataSource(objDtRep)
                    rptTemp1.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                    objTemp = New TipoDato_ResultaReporte
                    objTemp.pReporte = rptTemp1
                End If
            Else
                With obeFiltroActual
                    .PNNPRTIN = dgSalida.CurrentRow.Cells("NPRTIN2").Value()
                    .PNCCLNT = dgSalida.CurrentRow.Cells("cclnt2").Value()
                End With
                objDtRep = oReporte.dtRepDetalleNroParte(obeFiltroActual)
                If objDtRep.Rows.Count > 0 Then

                    objDtRep.TableName = "RelacionPartesXFecha"
                    rptTemp2.SetDataSource(objDtRep)
                    rptTemp2.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                    objTemp = New TipoDato_ResultaReporte
                    objTemp.pReporte = rptTemp2
                End If
            End If
            With frmVisorRPT
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill
                .pReportDocument = objTemp.pReporte
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Dim strMensaje As String = String.Empty
        Dim oDsReporteExcel As New DataSet
        Dim objReporte As New DataTable
        Dim oReporte As New brReporteDS
        Dim obeFiltros As New beFiltrosDespachoPorAlmacen
        Try
            With obeFiltros

                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PNCCLNT = txtCliente.pCodigo
                .PSSTPODP = cmbDeposito.SelectedValue()
                .PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Me.dteFecha.Value)
                If (txtNroParte.Text.Trim() = "") Then
                    .PNNPRTIN = 0
                Else
                    .PNNPRTIN = txtNroParte.Text.Trim
                End If

            End With

            Dim DtReporteIng As New DataTable
            Dim DtReporteSal As New DataTable

            Dim DtReporteIngDetallado As New DataTable
            Dim DtReporteSalDetallado As New DataTable

            oDsReporteExcel = oReporte.dtRepPartesPorFecha(obeFiltros)


            DtReporteIng.Columns.Add("PNCCLNT", GetType(Integer))
            DtReporteIng.Columns.Add("PSTCMPCL", GetType(String))
            DtReporteIng.Columns.Add("PSSTPODP", GetType(String))
            DtReporteIng.Columns.Add("PSCSRVC", GetType(String))
            DtReporteIng.Columns.Add("PNNPRTIN", GetType(Integer))
            DtReporteIng.Columns.Add("PNNPRTIN2", GetType(Integer))

            DtReporteSal.Columns.Add("PNCCLNT", GetType(Integer))
            DtReporteSal.Columns.Add("PSTCMPCL", GetType(String))
            DtReporteSal.Columns.Add("PSSTPODP", GetType(String))
            DtReporteSal.Columns.Add("PSCSRVC", GetType(String))
            DtReporteSal.Columns.Add("PNNPRTIN", GetType(Integer))
            DtReporteSal.Columns.Add("PNNPRTIN2", GetType(Integer))


            Dim index As Integer = 0
            For Each row As DataRow In oDsReporteExcel.Tables(0).Rows
                If (row.ItemArray(3) = "ING") Then
                    DtReporteIng.LoadDataRow(row.ItemArray, True)
                End If
                If (row.ItemArray(3) = "SAL") Then
                    DtReporteSal.LoadDataRow(row.ItemArray, True)
                End If
            Next

            DtReporteIngDetallado = oDsReporteExcel.Tables(1).Clone
            Dim odr As DataRow()
            odr = oDsReporteExcel.Tables(1).Select("Tipo = 'ING'")
            For intX As Integer = 0 To odr.Length - 1
                DtReporteIngDetallado.LoadDataRow(odr(intX).ItemArray, True)
            Next
            DtReporteIngDetallado.TableName = "Detalle de Partes de Ingreso"
            For intY As Integer = 0 To DtReporteIngDetallado.Columns.Count - 1
                DtReporteIngDetallado.Columns(intY).ColumnName.Replace("""", "")
            Next
            For intX As Integer = DtReporteIngDetallado.Rows.Count - 1 To 1 Step -1
                If DtReporteIngDetallado.Rows(intX).Item("CCLNT") = DtReporteIngDetallado.Rows(intX - 1).Item("CCLNT") And DtReporteIngDetallado.Rows(intX).Item("NPRTIN") = DtReporteIngDetallado.Rows(intX - 1).Item("NPRTIN") Then
                    DtReporteIngDetallado.Rows(intX).Item("CCLNT") = DBNull.Value
                    DtReporteIngDetallado.Rows(intX).Item("TCMPCL") = DBNull.Value
                    DtReporteIngDetallado.Rows(intX).Item("NPRTIN") = DBNull.Value
                    DtReporteIngDetallado.Rows(intX).Item("Tipo") = DBNull.Value
                End If
            Next



            DtReporteSalDetallado = oDsReporteExcel.Tables(1).Clone
            odr = oDsReporteExcel.Tables(1).Select("Tipo = 'SAL'")
            For intX As Integer = 0 To odr.Length - 1
                DtReporteSalDetallado.LoadDataRow(odr(intX).ItemArray, True)
            Next
            DtReporteSalDetallado.TableName = "Detalle de Partes de Salida"
            For intX As Integer = DtReporteSalDetallado.Rows.Count - 1 To 1 Step -1
                If DtReporteSalDetallado.Rows(intX).Item("CCLNT") = DtReporteSalDetallado.Rows(intX - 1).Item("CCLNT") And DtReporteSalDetallado.Rows(intX).Item("NPRTIN") = DtReporteSalDetallado.Rows(intX - 1).Item("NPRTIN") Then
                    DtReporteSalDetallado.Rows(intX).Item("CCLNT") = DBNull.Value
                    DtReporteSalDetallado.Rows(intX).Item("TCMPCL") = DBNull.Value
                    DtReporteSalDetallado.Rows(intX).Item("NPRTIN") = DBNull.Value
                    DtReporteSalDetallado.Rows(intX).Item("Tipo") = DBNull.Value
                End If
            Next


            DtReporteIng.Columns.Remove("PSSTPODP")
            DtReporteIng.Columns.Remove("PNCCLNT")
            DtReporteSal.Columns.Remove("PSSTPODP")
            DtReporteSal.Columns.Remove("PNCCLNT")

            DtReporteIng.Columns(0).ColumnName = "\n CLIENTE"
            DtReporteIng.Columns(1).ColumnName = "\n TIPO"
            DtReporteIng.Columns(2).ColumnName = " \n NRO. PARTE"
            DtReporteIng.Columns(3).ColumnName = "# \n GUÍAS"


            DtReporteSal.Columns(0).ColumnName = "\n CLIENTE"
            DtReporteSal.Columns(1).ColumnName = "\n TIPO"
            DtReporteSal.Columns(2).ColumnName = " \n NRO. PARTE"
            DtReporteSal.Columns(3).ColumnName = "# \n GUÍAS"

            DtReporteIngDetallado.Columns("CCLNT").ColumnName = "Cod. Cliente"
            DtReporteIngDetallado.Columns("TCMPCL").ColumnName = "Cliente"
            DtReporteIngDetallado.Columns("Tipo").ColumnName = "Tipo"
            DtReporteIngDetallado.Columns("NPRTIN").ColumnName = "Nr. Parte"
            DtReporteIngDetallado.Columns("NGUIRN").ColumnName = "Nr. Guía Ransa"
            DtReporteIngDetallado.Columns("QITEMS").ColumnName = "Cant. Items"

            DtReporteIngDetallado.Columns("CUSRAL").ColumnName = "Usuario"

            DtReporteSalDetallado.Columns("CCLNT").ColumnName = "Cod. Cliente"
            DtReporteSalDetallado.Columns("TCMPCL").ColumnName = "Cliente"
            DtReporteSalDetallado.Columns("Tipo").ColumnName = "Tipo"
            DtReporteSalDetallado.Columns("NPRTIN").ColumnName = "Nr. Parte"
            DtReporteSalDetallado.Columns("NGUIRN").ColumnName = "Nr. Guía Ransa"
            DtReporteSalDetallado.Columns("QITEMS").ColumnName = "Cant. Items"
            DtReporteSalDetallado.Columns("CUSRAL").ColumnName = "Usuario"

            DtReporteIng.TableName = "Nr. de Partes de Ingreso"
            DtReporteSal.TableName = "Nr. de Partes de Salida"
            'If TabDetalle.SelectedIndex = 0 Then

            Dim dsTemp As New DataSet

            dsTemp.Tables.Add(DtReporteIng.Copy)
            dsTemp.Tables.Add(DtReporteIngDetallado.Copy)
            dsTemp.Tables.Add(DtReporteSal.Copy)
            dsTemp.Tables.Add(DtReporteSalDetallado.Copy)

            Dim strlTitulo As New List(Of String)

            strlTitulo.Add("Compañia :\n" & Me.UcCompania_Cmb011.CCMPN_CodigoCompania & " - " & Me.UcCompania_Cmb011.CCMPN_Descripcion)
            strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
            strlTitulo.Add("Deposito :\n" & Me.cmbDeposito.Text)
            strlTitulo.Add("Fecha :\n" & dteFecha.Value)

            HelpClass.ExportExcelConTitulos(dsTemp, Me.Text, strlTitulo)
        Catch ex As Exception
        End Try
       

    End Sub
#End Region

#Region "Procedimientos y funciones"
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0 Then
            tsbExportarExcel.Enabled = False
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub CargarCompania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub CargarDeposito()
        Dim obrTipoDeDeposito As New brTipoDeDeposito
        cmbDeposito.DataSource = obrTipoDeDeposito.ListarTipoDeDeposito()
        cmbDeposito.DisplayMember = "PSTABDPS"
        cmbDeposito.ValueMember = "PSCTPDPS"
        cmbDeposito.SelectedValue = "1"
    End Sub

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub CargarColumnasIngreso()
        DtReporteIngreso.Columns.Add("PNCCLNT", GetType(String))
        DtReporteIngreso.Columns.Add("PSTCMPCL", GetType(String))
        DtReporteIngreso.Columns.Add("PSSTPODP", GetType(String))
        DtReporteIngreso.Columns.Add("PSCSRVC", GetType(String))
        DtReporteIngreso.Columns.Add("PNNPRTIN", GetType(String))
        DtReporteIngreso.Columns.Add("PNNPRTIN2", GetType(String))
    End Sub

    Private Sub CargarColumnasSalida()
        DtReporteSalida.Columns.Add("PNCCLNT", GetType(String))
        DtReporteSalida.Columns.Add("PSTCMPCL", GetType(String))
        DtReporteSalida.Columns.Add("PSSTPODP", GetType(String))
        DtReporteSalida.Columns.Add("PSCSRVC", GetType(String))
        DtReporteSalida.Columns.Add("PNNPRTIN", GetType(String))
        DtReporteSalida.Columns.Add("PNNPRTIN2", GetType(String))
    End Sub

    Private Sub HabilitarBotones()
        tsbGenerarReporte.Enabled = True
        tsbImprimir.Enabled = True
        tsbExportarExcel.Enabled = True
    End Sub
#End Region

    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            Dim objDt As DataTable
            Dim oReporte As New brReporteDS
            Dim obeFiltros As New beFiltrosDespachoPorAlmacen
            With obeFiltros

                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PNCCLNT = txtCliente.pCodigo
                .PSSTPODP = cmbDeposito.SelectedValue()
                .PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Me.dteFecha.Value)
                If (txtNroParte.Text.Trim() = "") Then
                    .PNNPRTIN = 0
                Else
                    .PNNPRTIN = txtNroParte.Text.Trim
                End If

            End With
            objDt = oReporte.dtRepPartesPorFecha(obeFiltros).Tables(0)
            If (objDt.Rows.Count > 0) Then
                If DtReporteIngreso.Rows.Count > 0 Then
                    DtReporteIngreso.Rows.Clear()
                Else
                    DtReporteIngreso.Rows.Clear()
                    If (DtReporteIngreso.Columns.Count = 0) Then
                        CargarColumnasIngreso()
                    End If

                End If

                If DtReporteSalida.Rows.Count > 0 Then
                    DtReporteSalida.Rows.Clear()
                Else
                    DtReporteSalida.Rows.Clear()
                    If (DtReporteSalida.Columns.Count = 0) Then
                        CargarColumnasSalida()
                    End If
                End If

                Dim index As Integer = 0
                For Each row As DataRow In objDt.Rows
                    If (row.ItemArray(3) = "ING") Then
                        DtReporteIngreso.LoadDataRow(row.ItemArray, True)
                    End If
                    If (row.ItemArray(3) = "SAL") Then
                        DtReporteSalida.LoadDataRow(row.ItemArray, True)
                    End If
                Next
                dgIngreso.AutoGenerateColumns = False
                dgSalida.AutoGenerateColumns = False
                dgIngreso.DataSource = DtReporteIngreso
                dgSalida.DataSource = DtReporteSalida
                HabilitarBotones()
            Else
                HabilitarBotones()
                If (dgIngreso.RowCount > 0) Then
                    dgIngreso.DataSource = ""
                End If
                If (dgSalida.RowCount > 0) Then
                    dgSalida.DataSource = ""
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgSalida_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSalida.CellDoubleClick, dgIngreso.CellDoubleClick
        If e.ColumnIndex <> 6 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim ofrmGuiaRansaXNrParte As New frmGuiaRansaXNrParte
        If Me.TabDetalle.SelectedIndex = 0 Then

            ofrmGuiaRansaXNrParte.PNCCLNT = Me.dgIngreso.CurrentRow.DataBoundItem.Item("PNCCLNT")
            ofrmGuiaRansaXNrParte.PNNPRTIN = Me.dgIngreso.CurrentRow.DataBoundItem.Item("PNNPRTIN")
            ofrmGuiaRansaXNrParte.PSTCMPCL = Me.dgIngreso.CurrentRow.DataBoundItem.Item("PSTCMPCL")
            ofrmGuiaRansaXNrParte.ShowDialog()
        Else

            ofrmGuiaRansaXNrParte.PNCCLNT = Me.dgSalida.CurrentRow.DataBoundItem.Item("PNCCLNT")
            ofrmGuiaRansaXNrParte.PNNPRTIN = Me.dgSalida.CurrentRow.DataBoundItem.Item("PNNPRTIN")
            ofrmGuiaRansaXNrParte.PSTCMPCL = Me.dgSalida.CurrentRow.DataBoundItem.Item("PSTCMPCL")
            ofrmGuiaRansaXNrParte.ShowDialog()
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
End Class
