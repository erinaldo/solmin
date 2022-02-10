Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF

Public Class frmConsultaERI
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-INICIO
#Region "Variables"
    Private dtInventarioxFecha As New DataTable
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

    Private Sub CargarCompania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    'Private Sub CargarPlanta()
    '    If Not UcCompania_Cmb011.CCMPN_CodigoCompania <> Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
    '        Return
    '    End If
    '    UcPLanta_Cmb011.CodigoDivision = "R"
    '    UcPLanta_Cmb011.CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
    '    UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcPLanta_Cmb011.pActualizar()
    'End Sub

    Private Function ObjEnviar(ByRef strAnioMesReporte As String) As beConsultaEriMensual
        Dim objConsultaEri As New beConsultaEriMensual
        objConsultaEri.IN_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objConsultaEri.IN_CPLNDV = UcPLanta_Cmb011.Planta
        objConsultaEri.IN_CCLNT = txtCliente.pCodigo
        objConsultaEri.IN_ANIO = txtAnio.Text
        objConsultaEri.IN_MES = ObtenerAnioMes(strAnioMesReporte)
        Return objConsultaEri
    End Function

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por lo siguiente : {0}", Environment.NewLine)
        If UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            strMensajeError += String.Format("- Debe de seleccionar Campaña. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcPLanta_Cmb011.Planta = Nothing Or UcPLanta_Cmb011.Planta = 0 Then
            strMensajeError += String.Format("- Debe de seleccionar Planta. {0}", Environment.NewLine)
            booOk = False
        End If
        If txtCliente.pCodigo = 0 Or txtCliente.pCodigo.ToString().Trim() = Nothing Or txtCliente.pCodigo.ToString().Trim() = String.Empty Or txtCliente.pCodigo = 0 Then
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
            MessageBox.Show(strMensajeError, "Eficiencia de Recepción / Despacho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function

    Private Sub ListarConsultarEri()
        Dim objConsultaEriMensual As New blConsultaEriMensual
        Dim dt As New DataTable
        Dim strAnioMesReporte As String = String.Empty
        dt = objConsultaEriMensual.ListarCabeceraERI(ObjEnviar(strAnioMesReporte)).Tables(0)

        odata = dt.Copy()

        Dim dvOrdenar As New DataView
        dvOrdenar = odata.DefaultView
        dvOrdenar.Sort = "MES"

        odata = dvOrdenar.ToTable()

        Dim MES As Integer = 0
        Dim Culture = New System.Globalization.CultureInfo("es-PE")

        'odata.Columns.Add("DESMES", Type.GetType("System.String"))
        Dim Col As DataColumn = odata.Columns.Add("DESMES", System.Type.[GetType]("System.String"))
        Col.SetOrdinal(0)

        For i As Integer = 0 To odata.Rows.Count - 1
            MES = odata.Rows(i)("MES")
            If MES <= 12 Then
                odata.Rows(i)("DESMES") = MonthName(MES).ToUpper(Culture)
            End If
        Next

        odata.Columns.Remove("MES")
        odata.Columns("DESMES").ColumnName = "MES"

        dgConsultaEri.DataSource = odata
        If dgConsultaEri.RowCount > 0 Then
            tsbExportarXLS.Enabled = True
        End If
        For Each column As DataGridViewColumn In dgConsultaEri.Columns
            If column.Name <> "MES" Then
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
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

    ''' <summary>
    ''' Funciones para obtener meses
    ''' </summary>
    Private Sub Lista_Meses()
        Dim dr As DataRow
        Dim Mes As String = String.Empty
        Dim NumMes As String = String.Empty
        dtInventarioxFecha.Columns.Add("CODMES")
        dtInventarioxFecha.Columns.Add("DESMES")
        dr = dtInventarioxFecha.NewRow()
        dr.Item("CODMES") = "13"
        dr.Item("DESMES") = "TODOS"
        dtInventarioxFecha.Rows.Add(dr)
        Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture
        Dim Culture = New System.Globalization.CultureInfo("es-PE")
        For index As Integer = 1 To 12
            dr = dtInventarioxFecha.NewRow()
            NumMes = StringRight("0" & index, 2)
            Mes = MonthName(index).ToUpper(Culture)
            dr.Item("CODMES") = NumMes
            dr.Item("DESMES") = Mes
            dtInventarioxFecha.Rows.Add(dr)
        Next
        cmbMes.DataSource = dtInventarioxFecha
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
    Private Function ObtenerAnioMes(ByRef strAnioMesReporte As String) As String
        Dim strAnioMes As String = String.Empty
        Dim valida As Boolean = False
        For j As Integer = 1 To dtInventarioxFecha.Rows.Count - 1
            If cmbMes.CheckedItems(0).Value <> "13" Then
                For i As Integer = 0 To cmbMes.CheckedItems.Count - 1
                    If (dtInventarioxFecha.Rows(j).Item("CODMES") = cmbMes.CheckedItems(i).Value) Then
                        valida = True
                        If strAnioMes.Trim().Length = 0 Then
                            strAnioMes = cmbMes.CheckedItems(i).Value
                        Else
                            strAnioMes = strAnioMes & "," & cmbMes.CheckedItems(i).Value
                        End If
                        If strAnioMesReporte.Trim().Length = 0 Then
                            strAnioMesReporte = cmbMes.CheckedItems(i).Name
                        Else
                            strAnioMesReporte = strAnioMesReporte & ", " & cmbMes.CheckedItems(i).Name
                        End If
                        Exit For
                    End If
                Next
                If Not valida = True Then
                    If strAnioMes.Trim().Length = 0 Then
                        strAnioMes = "00"
                    Else
                        strAnioMes = strAnioMes & "," & "00"
                    End If
                End If
                valida = False
            Else
                If dtInventarioxFecha.Rows(j).Item("CODMES") <> "13" Then
                    If strAnioMes.Trim().Length = 0 Then
                        strAnioMes = dtInventarioxFecha.Rows(j).Item("CODMES")
                    Else
                        strAnioMes = strAnioMes & "," & dtInventarioxFecha.Rows(j).Item("CODMES")
                    End If
                    strAnioMesReporte = txtAnio.Text.Trim() & " - " & "TODOS"
                End If
            End If
        Next
        Return strAnioMes
    End Function

#End Region

#Region "Eventos de Formulario"

    Private Sub frmConsultaERI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Lista_Meses()
            CargarClientes()
            CargarCompania()
            '  CargarPlanta()
            txtAnio.Text = Now.Year.ToString().Trim()
        Catch ex As Exception
            MessageBox.Show("Error de Conexión", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As RANSA.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            If Not UcCompania_Cmb011.CCMPN_CodigoCompania <> Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
                Return
            End If
            UcPLanta_Cmb011.CodigoDivision = "R"
            UcPLanta_Cmb011.CodigoCompania = UcCompania_Cmb011.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcPLanta_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub bsaCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If Not AsValidarFiltro() Then
                Return
            End If
            ListarConsultarEri()
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
            If dgConsultaEri.RowCount > 0 Then
                Dim odtNew As New DataTable
                Dim intConta As Integer = 0
                ObtenerAnioMes(strAnioMesReporte)
                oDt = odata.Copy()
                If Not oDt Is Nothing Then
                    oDt.TableName = "Consulta de Exactitud de Registro de Inventarios (ERI)"
                End If
                odtNew = oDt.Copy()

                odtNew.Columns("MES").ColumnName = "CÓDIGO" & vbLf & "MES"
                odtNew.Columns("QSFMC").ColumnName = "STOCK" & vbLf & "FISICO"
                odtNew.Columns("QSLMC").ColumnName = "STOCK" & vbLf & "SISTEMAS"
                odtNew.Columns("PRCERI").ColumnName = "" & vbLf & "ERI (%)"
                oDs.Tables.Add(odtNew)

                Dim strTitulo As New List(Of String)
                strTitulo.Add("Compañia : \n" & UcCompania_Cmb011.CCMPN_Descripcion)
                strTitulo.Add("Planta : \n" & UcPLanta_Cmb011.DescripcionPlanta)
                strTitulo.Add("Cliente : \n" & txtCliente.pRazonSocial)
                strTitulo.Add("Año - Mes(es) : \n" & strAnioMesReporte)


                '==========================Exportamos==========================
                'HelpClass.ExportarConsultaEriSinGraficos(oDs, Me.Text, strTitulo)
                HelpClass.ExportarConsultaEriConGraficos(oDs, Me.Text, strTitulo)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al exportar: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-FIN
End Class
