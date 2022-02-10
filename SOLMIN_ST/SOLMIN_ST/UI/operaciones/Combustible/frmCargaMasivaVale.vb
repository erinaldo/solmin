
Imports System.IO
Imports RANSA.Utilitario
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports NPOI.HSSF.UserModel
Imports NPOI.SS.UserModel
Public Class frmCargaMasivaVale
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private UltimaRuta As String = ""
    Private dtCarga As New DataTable
    Public gdtGrifos As New DataTable

    Public pAsignarValeLiq As Boolean = False
    Public pDialog As Boolean = False
    Public pNumLiq As Decimal = 0
    Public PlacaLiq As String = ""
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Private Sub frmCargaMasivaVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dtgVales.AutoGenerateColumns = False
            Cargar_Compania()
            CargaGrifos()

            If pAsignarValeLiq = True Then
                btnGenLiq.Visible = False
                btnEliminar.Visible = False
                btnImport.Visible = False
                cboCompania.SelectedValue = pCCMPN
                cboCompania_SelectionChangeCommitted(Nothing, Nothing)
                cboDivision.SelectedValue = pCDVSN
                cboCompania.ComboBox.Enabled = False
                cboDivision.ComboBox.Enabled = False
                txtVehiculo.Text = PlacaLiq
                txtVehiculo.Enabled = False
                btnAsignar.Visible = True
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()

        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        cboCompania.SelectedValue = "EZ"

        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectionChangeCommitted(Nothing, Nothing)
    End Sub

   
    Private Sub CargaGrifos()
        Dim obrGrifo As New SOLMIN_ST.NEGOCIO.mantenimientos.Grifo_BLL
        gdtGrifos = obrGrifo.Listar_Grifo_Validacion_Carga
    End Sub
    

   



    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel

                Case "tpValesPendiente"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Resultado"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resultado"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Resultado"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dtgVales.DataSource, DataTable).Copy
                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dtgVales, objDt))
                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim drError() As DataRow
    '        If dtCarga.Rows.Count = 0 Then
    '            MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        drError = dtCarga.Select("OBS_CARGA <> 'OK'")
    '        If drError.Length > 0 Then
    '            MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        drError = dtCarga.Select("OBS_REGISTRO = 'OK'")
    '        If drError.Length > 0 Then
    '            MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        Dim USUARIO As String = MainModule.USUARIO
    '        Dim TERMINAL As String = Ransa.Utilitario.HelpClass.NombreMaquina
    '        Dim msgresult As String = ""


    '        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
    '        Dim objParametro As New LiquidacionCombustible

    '        For Each item As DataRow In dtCarga.Rows
    '            objParametro = New LiquidacionCombustible
    '            objParametro.CCMPN = cboCompania.SelectedValue
    '            objParametro.CDVSN = cboDivision.SelectedValue
    '            objParametro.PLACA = item("PLACA")
    '            objParametro.GRIFO = item("GRIFO")
    '            objParametro.NRUCPR = item("RUC_RAZON_SOCIAL")
    '            objParametro.NVLGRS = item("NRO_VALE")
    '            objParametro.FCRCMB = item("FECHA_VALE")
    '            objParametro.CTPCMB = item("TIPO_COMB")
    '            objParametro.QGLNCM = item("CANT_GAL")
    '            objParametro.CSTGLN = item("COSTO_GAL")
    '            objParametro.NPRCN1 = item("PRECINTO1")
    '            objParametro.NPRCN2 = item("PRECINTO2")
    '            objParametro.NPRCN3 = item("PRECINTO3")
    '            objParametro.CULUSA = MainModule.USUARIO
    '            objParametro.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '            msgresult = obj_LogicaLiquidacion.Registrar_Vale_Masivo_Desde_Excel(objParametro)
    '            If msgresult = "" Then
    '                item("OBS_REGISTRO") = "OK"
    '            Else
    '                item("OBS_REGISTRO") = msgresult
    '            End If
    '        Next
    '        'dgvCargaVale.DataSource = dtCarga
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    'Private Sub btnGenLiq_Click(sender As Object, e As EventArgs) Handles btnGenLiq.Click
    '    Try
    '        'CHK
    '        dtgVales.EndEdit()
    '        Dim pLacaFila As String = ""
    '        Dim primerPlaca As String = ""
    '        Dim Fila As Int32 = 0
    '        Dim pListValeCombustible As New List(Of ValeCombustible)
    '        Dim oValeCombustible As New ValeCombustible
    '        For Each item As DataGridViewRow In dtgVales.Rows
    '            If item.Cells("CHK").Value = True Then
    '                If Fila = 0 Then
    '                    primerPlaca = ("" & item.Cells("NPLCUN_V").Value).ToString.Trim
    '                End If
    '                pLacaFila = ("" & item.Cells("NPLCUN_V").Value).ToString.Trim
    '                If primerPlaca <> pLacaFila Then
    '                    MessageBox.Show("Seleccione vales de la misma unidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Exit Sub
    '                End If
    '                Fila = Fila + 1

    '                oValeCombustible = New ValeCombustible

    '                oValeCombustible.NLQCMB = 0
    '                oValeCombustible.NRITEM = 0
    '                oValeCombustible.CCMPN = cboCompania.SelectedValue
    '                oValeCombustible.CDVSN = cboDivision.SelectedValue
    '                oValeCombustible.NVLGRS = ("" & item.Cells("NVLGRF_A").Value).ToString.Trim
    '                oValeCombustible.CTPCMB = ("" & item.Cells("CTPCMB_A").Value).ToString.Trim
    '                oValeCombustible.CGRFO = ("" & item.Cells("CGRFO_A").Value).ToString.Trim
    '                oValeCombustible.FCRCMB = item.Cells("FCRCMB_A").Value
    '                oValeCombustible.CSTGLN = item.Cells("CSTGLN").Value
    '                oValeCombustible.NDCCTS = ""
    '                oValeCombustible.CTPOD1 = 0
    '                oValeCombustible.FDCCT1 = 0
    '                oValeCombustible.QGLNCM = item.Cells("QGLCNM_1").Value
    '                oValeCombustible.NPRCN1 = ("" & item.Cells("NPRCN1_A").Value).ToString.Trim
    '                oValeCombustible.NPRCN2 = ("" & item.Cells("NPRCN2_A").Value).ToString.Trim
    '                oValeCombustible.NPRCN3 = ("" & item.Cells("NPRCN3_A").Value).ToString.Trim
    '                oValeCombustible.CULUSA = MainModule.USUARIO
    '                oValeCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '                oValeCombustible.CMNDA1 = 1
    '                pListValeCombustible.Add(oValeCombustible)


    '            End If

    '        Next

    '        If Fila = 0 Then
    '            MessageBox.Show("Seleecione registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '        If Fila > 0 Then
    '            Dim ofrmAgregarLiquidaciones As New frmAgregarLiquidaciones
    '            ofrmAgregarLiquidaciones.pRegistroMasivo = True
    '            ofrmAgregarLiquidaciones.pPlaca = primerPlaca
    '            ofrmAgregarLiquidaciones.pListValeCombustible = pListValeCombustible
    '            ofrmAgregarLiquidaciones.ShowDialog()
    '            If ofrmAgregarLiquidaciones.pDialog = True Then
    '                ListarValesPendAsig()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dtgVales.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim msg As String = ""
            Dim strmsg As String = ""
            Dim obrValeCombustible As New ValeCombustible_BLL
            Dim obeValeCombustible As ValeCombustible
            dtgVales.EndEdit()
            For Each item As DataGridViewRow In dtgVales.Rows
                If item.Cells("CHK").Value = True Then
                    obeValeCombustible = New ValeCombustible
                    With obeValeCombustible
                        .NLQCMB = -1
                        .CCMPN = cboCompania.SelectedValue
                        .NRITEM = item.Cells("NRITEM").Value
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With
                    msg = obrValeCombustible.Eliminar_Vale_Liquidacion_Combustible(obeValeCombustible)
                    If msg <> "" Then
                        strmsg = strmsg & msg & Chr(10)
                    End If
                End If
            Next
            strmsg = strmsg.Trim
            If strmsg <> "" Then
                MessageBox.Show(strmsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ListarValesPendAsig()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
        
            ListarValesPendAsig()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarValesPendAsig()
        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim dt As New DataTable
        dt = obj_LogicaLiquidacion.Listar_Vales_Pendiente_Asignacion(cboCompania.SelectedValue, cboDivision.SelectedValue, txtVehiculo.Text.Trim)
        dtgVales.DataSource = dt
    End Sub
    Private Sub Cargar_Division()

        objDivision.Crea_Lista()
        Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
        Me.cboDivision.ValueMember = "CDVSN"
        Me.cboDivision.DisplayMember = "TCMPDV"
        If Me.cboCompania.SelectedValue = "EZ" Then
            Me.cboDivision.SelectedValue = "T"
        End If

        If Me.cboDivision.SelectedIndex = -1 Then
            Me.cboDivision.SelectedIndex = 0
        End If
    End Sub
  

    Private Sub cboCompania_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCompania.SelectionChangeCommitted
        Try
            Me.Cargar_Division()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   

   

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try

            Dim ofrmImportarVale As New frmImportarVale
            ofrmImportarVale.pCCMPN = cboCompania.SelectedValue
            ofrmImportarVale.pCDVSN = cboDivision.SelectedValue
            ofrmImportarVale.ShowDialog()
            If ofrmImportarVale.pDialog = True Then
                ListarValesPendAsig()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try
            'CHK
            dtgVales.EndEdit()

            Dim pLacaFila As String = ""
            Dim primerPlaca As String = PlacaLiq

            Dim pListValeCombustible As New List(Of ValeCombustible)
            Dim oValeCombustible As New ValeCombustible
            For Each item As DataGridViewRow In dtgVales.Rows
                If item.Cells("CHK").Value = True Then
                    pLacaFila = ("" & item.Cells("NPLCUN_V").Value).ToString.Trim
                    If primerPlaca <> pLacaFila Then
                        MessageBox.Show("Seleccione vales de la misma unidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    oValeCombustible = New ValeCombustible
                    oValeCombustible.NLQCMB = 0
                    oValeCombustible.NRITEM = 0
                    oValeCombustible.NRITEMO = item.Cells("NRITEM").Value
                    oValeCombustible.CCMPN = cboCompania.SelectedValue
                    oValeCombustible.CDVSN = cboDivision.SelectedValue
                    oValeCombustible.NVLGRS = ("" & item.Cells("NVLGRF_A").Value).ToString.Trim
                    oValeCombustible.CTPCMB = ("" & item.Cells("CTPCMB_A").Value).ToString.Trim
                    oValeCombustible.CGRFO = ("" & item.Cells("CGRFO_A").Value).ToString.Trim
                    oValeCombustible.FCRCMB = item.Cells("FCRCMB_A").Value
                    oValeCombustible.CSTGLN = item.Cells("CSTGLN").Value
                    oValeCombustible.NDCCTS = ""
                    oValeCombustible.CTPOD1 = 0
                    oValeCombustible.FDCCT1 = 0
                    oValeCombustible.QGLNCM = item.Cells("QGLCNM_1").Value
                    oValeCombustible.NPRCN1 = ("" & item.Cells("NPRCN1_A").Value).ToString.Trim
                    oValeCombustible.NPRCN2 = ("" & item.Cells("NPRCN2_A").Value).ToString.Trim
                    oValeCombustible.NPRCN3 = ("" & item.Cells("NPRCN3_A").Value).ToString.Trim
                    oValeCombustible.CULUSA = MainModule.USUARIO
                    oValeCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    oValeCombustible.CMNDA1 = 1
                    pListValeCombustible.Add(oValeCombustible)
                End If

            Next

            If pListValeCombustible.Count = 0 Then
                MessageBox.Show("Seleecione registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Dim obrValeCombustible As New ValeCombustible_BLL
            Dim msg As String = ""
            For Each item As ValeCombustible In pListValeCombustible
                item.NLQCMB = pNumLiq
                item.NRITEM = 0
                msg = obrValeCombustible.Registrar_Vale_CombustibleV2(item)
                pDialog = True
                If msg = "" Then
                    Dim obeValeCombustible As New ValeCombustible
                    With obeValeCombustible
                        .NLQCMB = -1
                        .CCMPN = pCCMPN
                        .NRITEM = item.NRITEMO
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With
                    msg = obrValeCombustible.Eliminar_Vale_Liquidacion_Combustible(obeValeCombustible)
                End If
            Next
            ListarValesPendAsig()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class