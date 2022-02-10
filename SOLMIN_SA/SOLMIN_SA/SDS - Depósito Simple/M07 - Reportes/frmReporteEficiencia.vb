Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF

Public Class frmReporteEficiencia
#Region "Variables"
    Private dtMeses As New DataTable
    Private odata As DataTable
#End Region

#Region "Metodos y Funciones"

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por lo siguiente : {0}", Environment.NewLine)
        If UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            strMensajeError += String.Format("- Debe de seleccionar Campaña. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcDivision_Cmb011.Division = Nothing Or UcDivision_Cmb011.Division.Trim() = String.Empty Then
            strMensajeError += String.Format("- Debe de seleccionar División. {0}", Environment.NewLine)
            booOk = False
        End If
        If txtCliente.pCodigo = 0 Then
            strMensajeError += String.Format("- Debe de seleccionar Cliente. {0}", Environment.NewLine)
            booOk = False
        End If
        If txtAnio.Text = String.Empty Then
            strMensajeError += String.Format("- Debe de Ingresar el Año. {0}", Environment.NewLine)
            booOk = False
        End If
        If cmbMes.CheckedItems.Count = 0 Then
            strMensajeError += String.Format("- Debe de Seleccionar el Mes. {0}", Environment.NewLine)
            booOk = False
        End If
        If Not booOk Then
            MessageBox.Show(strMensajeError, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function

    Private Function ObtenerEficiencia(ByRef strAnioMesReporte As String) As beProductoxRegularizar
        Dim objbeProductoxRegularizar As New beProductoxRegularizar
        strAnioMesReporte = String.Empty
        objbeProductoxRegularizar.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeProductoxRegularizar.PSCDVSN = UcDivision_Cmb011.Division
        objbeProductoxRegularizar.PNCCLNT = txtCliente.pCodigo
        objbeProductoxRegularizar.PSANIOMES = ObtenerAnioMes(strAnioMesReporte)
        Return objbeProductoxRegularizar
    End Function

    Private Sub ListarEficienciadeRecepcionDespacho()
        Dim objblRegistroInventario As New blRegistroInventario
        Dim dt As New DataTable
        Dim strAnioMesReporte As String = String.Empty
        dt = objblRegistroInventario.EficienciadeRecepcionDespacho(ObtenerEficiencia(strAnioMesReporte)).Tables(0)
        odata = dt.Copy()
        dgDisInventario.DataSource = dt
        If dgDisInventario.RowCount > 0 Then
            tsbExportarXLS.Enabled = True
        End If
        For Each column As DataGridViewColumn In dgDisInventario.Columns
            If column.Name <> "CONCEPTO" Then
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    ''' <summary>
    ''' Funciones para obtener meses
    ''' </summary>
    Private Function ObtenerAnioMes(ByRef strAnioMesReporte As String) As String
        Dim strAnioMes As String = String.Empty
        Dim valida As Boolean = False
        For j As Integer = 1 To dtMeses.Rows.Count - 1
            If cmbMes.CheckedItems(0).Value <> "13" Then
                For i As Integer = 0 To cmbMes.CheckedItems.Count - 1
                    If (dtMeses.Rows(j).Item("CODMES") = cmbMes.CheckedItems(i).Value) Then
                        valida = True
                        If strAnioMes.Trim().Length = 0 Then
                            strAnioMes = txtAnio.Text.Trim() & cmbMes.CheckedItems(i).Value
                        Else
                            strAnioMes = strAnioMes & "," & txtAnio.Text.Trim() & cmbMes.CheckedItems(i).Value
                        End If
                        If strAnioMesReporte.Trim().Length = 0 Then
                            strAnioMesReporte = txtAnio.Text.Trim() & " - " & cmbMes.CheckedItems(i).Name
                        Else
                            strAnioMesReporte = strAnioMesReporte & ", " & cmbMes.CheckedItems(i).Name
                        End If
                        Exit For
                    End If
                Next
                If Not valida = True Then
                    If strAnioMes.Trim().Length = 0 Then
                        strAnioMes = "000000"
                    Else
                        strAnioMes = strAnioMes & "," & "000000"
                    End If
                End If
                valida = False
            Else
                If dtMeses.Rows(j).Item("CODMES") <> "13" Then
                    If strAnioMes.Trim().Length = 0 Then
                        strAnioMes = txtAnio.Text.Trim() & dtMeses.Rows(j).Item("CODMES")
                    Else
                        strAnioMes = strAnioMes & "," & txtAnio.Text.Trim() & dtMeses.Rows(j).Item("CODMES")
                    End If
                    strAnioMesReporte = txtAnio.Text.Trim() & " - " & "TODOS"
                End If
            End If
        Next
        Return strAnioMes
    End Function

    ''' <summary>
    ''' Funciones para obtener meses
    ''' </summary>
    Private Sub Lista_Meses()
        Dim dr As DataRow
        Dim Mes As String = String.Empty
        Dim NumMes As String = String.Empty
        dtMeses.Columns.Add("CODMES")
        dtMeses.Columns.Add("DESMES")
        dr = dtMeses.NewRow()
        dr.Item("CODMES") = "13"
        dr.Item("DESMES") = "TODOS"
        dtMeses.Rows.Add(dr)
        Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture
        Dim Culture = New System.Globalization.CultureInfo("es-PE")
        For index As Integer = 1 To 12
            dr = dtMeses.NewRow()
            NumMes = StringRight("0" & index, 2)
            Mes = MonthName(index).ToUpper(Culture)
            dr.Item("CODMES") = NumMes
            dr.Item("DESMES") = Mes
            dtMeses.Rows.Add(dr)
        Next
        cmbMes.DataSource = dtMeses
        cmbMes.DisplayMember = "DESMES"
        cmbMes.ValueMember = "CODMES"
        For i As Integer = 0 To cmbMes.Items.Count - 1
            If cmbMes.Items.Item(i).Value = "13" Then
                cmbMes.SetItemChecked(i, True)
            End If
        Next
        If cmbMes.Text = String.Empty Then
            cmbMes.SetItemChecked(0, True)
        End If
        System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI
    End Sub

    ''' <summary>
    ''' Funciones para obtener meses
    ''' </summary>
    Public Function StringRight(ByVal cadena As String, ByVal numCaracteres As Int32) As String
        cadena = cadena.Trim
        If (cadena <> "") Then
            If (numCaracteres > cadena.Length) Then
                numCaracteres = 0
            End If
            cadena = cadena.Substring(cadena.Length - numCaracteres, numCaracteres)
        End If
        Return cadena
    End Function

#End Region

#Region "Eventos de Formulario"

    Private Sub frmReporteEficiencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lista_Meses()
        Listar_Compania()
        CargarClientes()
        dgDisInventario.AutoGenerateColumns = True
        txtAnio.Text = Now.Year.ToString().Trim()
    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        Try
            If Not e.KeyChar = ChrW(Keys.Back) Then
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub tsbExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarXLS.Click
        Try
            Dim oDt As New DataTable
            Dim oDs As New DataSet
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim strAnioMesReporte As String = String.Empty
            If dgDisInventario.RowCount > 0 Then
                Dim odtNew As New DataTable
                Dim intConta As Integer = 0
                ObtenerAnioMes(strAnioMesReporte)
                'oDt = oblInventarioMercaderia.EficienciadeRecepcionDespacho(ObtenerEficiencia(strAnioMesReporte)).Tables(0)
                oDt = odata.Copy()

                If Not oDt Is Nothing Then
                    oDt.TableName = "Eficiencia"
                End If

                odtNew = oDt.Copy()
                For Each column As DataColumn In oDt.Columns
                    odtNew.Columns(intConta).ColumnName = column.ColumnName
                    intConta += 1
                Next
                oDs.Tables.Add(odtNew)
                Dim strTitulo As New List(Of String)
                strTitulo.Add("Compañia : \n" & UcCompania_Cmb011.CCMPN_Descripcion)
                strTitulo.Add("División : \n" & UcDivision_Cmb011.DivisionDescripcion)
                strTitulo.Add("Cliente : \n" & txtCliente.pRazonSocial)
                strTitulo.Add("Año Mes : \n" & strAnioMesReporte)

                '==========================Exportamos==========================
                'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-INICIO
                'HelpClass.ExportarEficienciaDespachoSinGraficos(oDs, Me.Text, strTitulo)
                HelpClass.ExportarEficienciaDespachoConGraficos(oDs, Me.Text, strTitulo)
                'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-FIN
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al exportar: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As RANSA.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If Not AsValidarFiltro() Then
                Return
            End If
            ListarEficienciadeRecepcionDespacho()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region
End Class