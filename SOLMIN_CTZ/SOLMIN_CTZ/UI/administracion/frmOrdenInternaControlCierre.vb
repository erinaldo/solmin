Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmOrdenInternaControlCierre
    Private oOIControlNeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oOIControlEnt As New SOLMIN_CTZ.Entidades.OrdenInternaControl
    Private oEstadoNeg As SOLMIN_CTZ.NEGOCIO.clsEstado
    Private bolBuscar As Boolean
    Private bolIniciaCarga As Boolean = True
    Private oDtOI As New DataTable
    Private tAnulados As Integer = 0
    Private tFacturados As Integer = 0
    Private compania As String
    Private division As String
    Private planta As String
    Private f_inicio As String
    Private f_fin As String
    Public Sub New(ByVal oOIControl As OrdenInternaControl)
        InitializeComponent()
        'CARGAMOS EL DATAGRID
        cargaDtgOICierre(oOIControl)
        oOIControlEnt = oOIControl
        txtTotal.Text = dtgCierreOI.Rows.Count
        txtAnulados.Text = tAnulados
        txtFacturados.Text = tFacturados
    End Sub

    Private Sub frmOrdenInternaControlCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oEstadoNeg = New clsEstado
        cargaEstado()
        lblMensaje.Visible = False
        ' cargaCajas()
    End Sub
    Private Sub cargaEstado()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            oEstadoNeg.Estado_OI_Cierre()
            cmbEstado.DataSource = oEstadoNeg.Tabla
            cmbEstado.ValueMember = "COD"
            bolBuscar = True
            cmbEstado.DisplayMember = "TEX"
            cmbEstado.SelectedValue = "-1"
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        If bolBuscar Then
            Dim sEstado As String = cmbEstado.SelectedValue
            Dim dtSeleccion As DataTable
            dtSeleccion = oOIControlNeg.Lista_OI_Control_Cierre_Seleccion(sEstado, oDtOI)
            llenaGrillaOICierre(dtSeleccion)
        End If
    End Sub

    Private Sub cargaDtgOICierre(ByVal oOIControl As OrdenInternaControl)
        'Dim oDt As DataTable
        Dim dtOI_Cierre As DataTable
        dtOI_Cierre = oOIControlNeg.Lista_OI_Control_Cierre(oOIControl)
        f_inicio = oOIControl.F_INICIO
        f_fin = oOIControl.F_FINAL
        compania = oOIControl.PSCCMPN
        division = oOIControl.PSCDVSN
        planta = oOIControl.PNCPLNDV
        llenaGrillaOICierre(dtOI_Cierre)
    End Sub
    Private Sub llenaGrillaOICierre(ByVal dtOI_Cierre As DataTable)
        Me.dtgCierreOI.Rows.Clear()
        Dim intCont As Integer
        If bolIniciaCarga = True Then
            oDtOI.Rows.Clear()
            oDtOI = dtOI_Cierre.Clone
        End If
        For intCont = 0 To dtOI_Cierre.Rows.Count - 1
            Agrega_Row_OICierre()
            With Me.dtgCierreOI
                'Indicar los nombres de las columnas
                .Rows(intCont).Cells("CCMPN").Value = dtOI_Cierre.Rows(intCont).Item("CCMPN")
                .Rows(intCont).Cells("CDVSN").Value = dtOI_Cierre.Rows(intCont).Item("CDVSN")
                .Rows(intCont).Cells("CPLNDV").Value = dtOI_Cierre.Rows(intCont).Item("CPLNDV")
                .Rows(intCont).Cells("NOPRCN").Value = dtOI_Cierre.Rows(intCont).Item("NOPRCN")
                .Rows(intCont).Cells("FINCOP").Value = HelpClass.FormatoFecha(dtOI_Cierre.Rows(intCont).Item("FINCOP"))
                .Rows(intCont).Cells("NPLNMT").Value = dtOI_Cierre.Rows(intCont).Item("NPLNMT")
                .Rows(intCont).Cells("SESTOP").Value = dtOI_Cierre.Rows(intCont).Item("SESTOP")
                .Rows(intCont).Cells("NORSAP").Value = dtOI_Cierre.Rows(intCont).Item("NORSAP")
                '.Rows(intCont).Cells("VENTA").Value = Format(CType(oDt.Rows(intCont).Item("VENTA"), Double), "###,###,###,##0.00")
                .Rows(intCont).Cells("CCLORI").Value = dtOI_Cierre.Rows(intCont).Item("CCLORI")
                .Rows(intCont).Cells("CFAOLI").Value = IIf(IsDBNull(dtOI_Cierre.Rows(intCont).Item("CFAOLI")), "", dtOI_Cierre.Rows(intCont).Item("CFAOLI"))
                .Rows(intCont).Cells("NDCMFC").Value = dtOI_Cierre.Rows(intCont).Item("NDCMFC")
                'Importa
                If bolIniciaCarga = True Then
                    oDtOI.ImportRow(dtOI_Cierre.Rows(intCont))
                End If
                If dtOI_Cierre.Rows(intCont).Item("SESTOP") = "*" Then
                    tAnulados = tAnulados + 1
                End If
                If dtOI_Cierre.Rows(intCont).Item("SESTOP") = "F" Then
                    tFacturados = tFacturados + 1
                End If
            End With
        Next intCont
        bolIniciaCarga = False
    End Sub
    Private Sub Agrega_Row_OICierre()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgCierreOI)
        Me.dtgCierreOI.Rows.Add(oDrVw)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim x As Integer
        Dim cantidadProcesados As Integer = 0
        x = MsgBox("Desea Actualizar documentos SAP?", MsgBoxStyle.YesNo, "Mensaje de Información")
        If x = 6 Then
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            For i As Integer = 0 To oDtOI.Rows.Count - 1
                If Not IsDBNull(oDtOI.Rows(i).Item("CCLORI")) Then
                    oOIControlEnt.CCLORI = oDtOI.Rows(i).Item("CCLORI")

                    oOIControlEnt.NORDIN = validaDigitos(oDtOI.Rows(i).Item("NORSAP"))

                    If oDtOI.Rows(i).Item("SESTOP") = "F" Then 'Facturado
                        oOIControlEnt.SACORI = "M"
                        oOIControlNeg.Cierre_OI_CL_SAP119A(oOIControlEnt)
                        cantidadProcesados = cantidadProcesados + 1
                    End If
                    If oDtOI.Rows(i).Item("SESTOP") = "*" Then 'Anulado
                        oOIControlEnt.SACORI = "Z"
                        oOIControlNeg.Anulacion_OI_CL_SAP119B(oOIControlEnt)
                        cantidadProcesados = cantidadProcesados + 1
                    End If
                End If
            Next
            proceso_espera.Abort()
            lblMensaje.Visible = True
            lblMensaje.Text = "Cantidad Procesados:  " & CStr(cantidadProcesados)
            'LUEGO DE PROCESAR RECARGAMOS GRILLA
            oOIControlEnt.PSCCMPN = compania
            oOIControlEnt.PSCDVSN = division
            oOIControlEnt.PNCPLNDV = planta
            oOIControlEnt.F_INICIO = f_inicio
            oOIControlEnt.F_FINAL = f_fin
            cargaDtgOICierre(oOIControlEnt)
        End If
    End Sub
    Private Function validaDigitos(ByVal cadena As String) As String
        Dim cadena10 As String = ""
        If cadena.Length > 10 Then
            cadena10 = cadena.Substring(2, 10)
        Else
            cadena10 = "0000000000"
        End If

        Return cadena10
    End Function
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'Dim mpGenerarXLS As New ExportarExcel
        Dim strReporteseleccionado As String = "005"

        Dim dtNuevo As New DataTable
        dtNuevo = oDtOI.Clone
        'Eliminamos Columnas que no se usaran
        dtNuevo.Columns.Remove("CCMPN")
        dtNuevo.Columns.Remove("CDVSN")
        dtNuevo.Columns.Remove("CPLNDV")
        dtNuevo.Columns.Remove("CFAOAB")
        dtNuevo.Columns.Remove("CFAOCT")
        dtNuevo.Columns.Remove("CFAOCE")
        dtNuevo.Columns.Remove("CTPDCF")
        dtNuevo.Columns.Remove("FDCPRF")
        dtNuevo.Columns.Remove("NDCMFC")
        dtNuevo.Columns.Remove("NORSRT")
        dtNuevo.Columns.Remove("SFCTOP")

        'Cambiamos de tipo de dato a las Fechas
        dtNuevo.Columns(0).DataType = GetType(String)
        dtNuevo.Columns(1).DataType = GetType(String)
        dtNuevo.Columns(2).DataType = GetType(String)
        dtNuevo.Columns(3).DataType = GetType(String)
        dtNuevo.Columns(4).DataType = GetType(String)
        dtNuevo.Columns(5).DataType = GetType(String)
        dtNuevo.Columns(6).DataType = GetType(String)
        dtNuevo.Columns(7).DataType = GetType(String)


        'Agegamos datos Filtro
        Dim filaNueva As DataRow
        '----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Compania:"
        filaNueva(1) = oOIControlEnt.CCMPN_DESC
        dtNuevo.Rows.Add(filaNueva)
        '-----------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Division:"
        filaNueva(1) = oOIControlEnt.CDVSN_DESC
        dtNuevo.Rows.Add(filaNueva)
        '------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Planta:"
        filaNueva(1) = oOIControlEnt.CPLNDV_DESC
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "Desde: " & HelpClass.FormatoFecha(oOIControlEnt.F_INICIO)
        filaNueva(1) = "Hasta: " & HelpClass.FormatoFecha(oOIControlEnt.F_FINAL)
        dtNuevo.Rows.Add(filaNueva)
        '-------------
        filaNueva = dtNuevo.NewRow()
        filaNueva(0) = "NRO OPERACION"
        filaNueva(1) = "FECHA"
        filaNueva(2) = "NRO PLANEAMIENTO"
        filaNueva(3) = "ESTADO"
        filaNueva(4) = "NRO DOCUMENTO"
        filaNueva(5) = "TIPO"
        filaNueva(6) = "NRO ORDEN INTERNA"
        filaNueva(7) = "FASE LIBERADO"

        dtNuevo.Rows.Add(filaNueva)

        For i As Integer = 0 To oDtOI.Rows.Count - 1
            If Not (i > (oDtOI.Rows.Count - 1)) Then
                dtNuevo.ImportRow(oDtOI.Rows(i))
                dtNuevo.Rows(i + 5).Item("FINCOP") = HelpClass.FormatoFecha(dtNuevo.Rows(i + 5).Item("FINCOP").ToString.Trim)
            End If
        Next


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dtNuevo.Rows.Count > 1 Then
            Dim list As New List(Of DataTable)
            list.Add(dtNuevo)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcel(list, strReporteseleccionado)
        Else
            HelpClass.MsgBox("No hay Registros para exportar")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
