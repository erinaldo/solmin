Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmOIControlCierreV2
    Private oOIControlNeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenInternaControl
    Private oOIControlV2 As SOLMIN_CTZ.Entidades.OrdenInternaControl
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
  
#Region "Comun"
    Public Sub New(ByVal oOIC As SOLMIN_CTZ.Entidades.OrdenInternaControl)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oOIControlV2 = oOIC

        'CARGAMOS EL DATAGRID
        cargaDtgOICierre(oOIControlV2)
        txtTotal.Text = dtgCierreOI.Rows.Count
        txtAnulados.Text = tAnulados
        txtFacturados.Text = tFacturados
    End Sub
    Private Sub frmOIControlCierreV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oEstadoNeg = New clsEstado
        cargaEstado()
        lblMensaje.Visible = False
        btnImportSAP.Visible = False
    End Sub
    Public Sub IniciaLoader()
        'Cuadro de espera iniciado
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub
    Private Function validaDigitos(ByVal cadena As String) As String
        Dim cadena10 As String = ""
        If cadena.Length > 10 Then
            cadena10 = cadena.Substring(2, 10)
        ElseIf cadena.Length > 0 And cadena.Length < 10 Then
            If cadena.Length = 9 Then
                cadena10 = "0" & cadena
            ElseIf cadena.Length = 8 Then
                cadena10 = "00" & cadena
            ElseIf cadena.Length = 7 Then
                cadena10 = "000" & cadena
            ElseIf cadena.Length = 6 Then
                cadena10 = "0000" & cadena
            End If
        Else
            cadena10 = "0000000000"
        End If

        Return cadena10
    End Function
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
            dtSeleccion = oOIControlNeg.Lista_OI_Control_Cierre_SeleccionV2(sEstado, oDtOI)
            llenaGrillaOICierre(dtSeleccion)
        End If
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region
#Region "Carga Datos"
    Private Sub cargaDtgOICierre(ByVal oOIControl As OrdenInternaControl)
        Dim dtOI_Cierre As DataTable
        Dim oOIControlFiltro As New OrdenInternaControl
        oOIControlFiltro = oOIControlNeg.Lista_OI_Control_CierreV2(oOIControl)
        dtOI_Cierre = oOIControlFiltro.oDtOI
        tAnulados = oOIControlFiltro.PNANULADOS
        tFacturados = oOIControlFiltro.PNFACTURADOS
        f_inicio = oOIControl.F_INICIO
        f_fin = oOIControl.F_FINAL
        compania = oOIControl.PSCCMPN
        division = oOIControl.PSCDVSN
        planta = oOIControl.PNCPLNDV
        llenaGrillaOICierre(dtOI_Cierre)
    End Sub
    Private Sub llenaGrillaOICierre(ByVal dtOI_Cierre As DataTable)
        If bolIniciaCarga = True Then
            oDtOI.Rows.Clear()
            oDtOI = dtOI_Cierre.Copy
        End If
        dtgCierreOI.AutoGenerateColumns = False
        dtgCierreOI.DataSource = dtOI_Cierre

        bolIniciaCarga = False
    End Sub
#End Region
#Region "Reporte"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        odtReporte = oDtOI.Copy

        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns(0).ColumnName = "NRO OPERACION"
        odtReporte.Columns(1).ColumnName = "FECHA"
        odtReporte.Columns(2).ColumnName = "NRO PLANEAMIENTO"
        odtReporte.Columns(3).ColumnName = "ESTADO"
        odtReporte.Columns(4).ColumnName = "NRO DOCUMENTO"
        odtReporte.Columns(5).ColumnName = "TIPO"
        odtReporte.Columns(6).ColumnName = "NRO ORDEN INTERNA"
        odtReporte.Columns(7).ColumnName = "FASE LIBERADO"

        ListDt.Add(odtReporte)
        Ransa.Utilitario.HelpClass_NPOI.ExportExcel(ListDt, "Control de ordenes Internas")

        odtReporte.Dispose()
        odtReporte.Clear()
        ListDt.Clear()
    End Sub
#End Region
#Region "Actualizar Informacion2"
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim cantidadProcesados As Integer = 0
        Dim oOIControlEnt As New OrdenInternaControl
        If MsgBox("Desea Actualizar documentos SAP?", MsgBoxStyle.YesNo, "Mensaje de Información") = MsgBoxResult.Yes Then
            Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
            proceso_espera.Start()
            For i As Integer = 0 To oDtOI.Rows.Count - 1
                If Not IsDBNull(oDtOI.Rows(i).Item("CCLORI")) Then
                    oOIControlEnt.CCLORI = oDtOI.Rows(i).Item("CCLORI")

                    oOIControlEnt.NORDIN = validaDigitos(oDtOI.Rows(i).Item("NORINS"))

                    If oDtOI.Rows(i).Item("SESTOP") = "F" Then 'Facturado
                        oOIControlEnt.SACORI = "M"
                        oOIControlNeg.Cierre_OI_CL_SAP119A(oOIControlEnt)
                        cantidadProcesados = cantidadProcesados + 1
                        Console.WriteLine("Registro: " & CStr(cantidadProcesados))
                    End If
                    If oDtOI.Rows(i).Item("SESTOP") = "*" Then 'Anulado
                        oOIControlEnt.SACORI = "Z"
                        oOIControlNeg.Anulacion_OI_CL_SAP119B(oOIControlEnt)
                        cantidadProcesados = cantidadProcesados + 1
                        Console.WriteLine("Registro: " & CStr(cantidadProcesados))
                    End If
                End If
            Next
            proceso_espera.Abort()
            lblMensaje.Visible = True
            lblMensaje.Text = "Cantidad Procesados:  " & CStr(cantidadProcesados)
            btnImportSAP.Visible = True
            '=====Recargamos Grilla=======
            oOIControlEnt.PSCCMPN = compania
            oOIControlEnt.PSCDVSN = division
            oOIControlEnt.PNCPLNDV = planta
            oOIControlEnt.F_INICIO = f_inicio
            oOIControlEnt.F_FINAL = f_fin
            oOIControlEnt.oDtOI = oDtOI
            cargaDtgOICierre(oOIControlEnt)
        End If
    End Sub
#End Region

#Region "Actualiza RSAP22"
    Private Sub btnImportSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportSAP.Click
        Dim oOI As New SOLMIN_CTZ.Entidades.OrdenesInternas
        oOI.PSCCMPN = compania
        oOI.PSCDVSN = division
        oOI.PNCPLNDV = planta
        oOI.INI_FECHA = f_inicio
        oOI.FIN_FECHA = f_fin
        Dim frm As frmOIActualizaSAP
        frm = New frmOIActualizaSAP(oOI)
        frm.ShowDialog()
    End Sub
#End Region

End Class
