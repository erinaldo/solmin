Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOIActualizaSAP
    Private oOrdenesinternas As New SOLMIN_CTZ.Entidades.OrdenesInternas
    Private oOrdenesinternasNeg As New SOLMIN_CTZ.NEGOCIO.clsOrdenesInternas
    Private oClaseOrdenNeg As New SOLMIN_CTZ.NEGOCIO.clsClaseOrden
    Private bolBuscar As Boolean
    Public Sub New(ByVal oOI As OrdenesInternas)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oOrdenesinternas.PSCCMPN = oOI.PSCCMPN
        oOrdenesinternas.PSCDVSN = oOI.PSCDVSN
        oOrdenesinternas.PNCPLNDV = oOI.PNCPLNDV
        dtFechaFin.Enabled = False
        dtFechaInicio.Enabled = False
    End Sub
    Public Sub IniciaLoader()
        Dim frmWait = New GenerandoSap
        frmWait.ShowDialog()
    End Sub
    Private Sub cbRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRango.CheckedChanged
        If cbRango.Checked Then
            dtFechaFin.Enabled = True
            dtFechaInicio.Enabled = True
        Else
            dtFechaFin.Value = Date.Now
            dtFechaInicio.Value = Date.Now
            dtFechaFin.Enabled = False
            dtFechaInicio.Enabled = False
        End If
    End Sub
    Private Sub frmOIActualizaSAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_ClaseOrden()
        Cargar_DatosClaseOrden()
    End Sub
    Private Sub Cargar_ClaseOrden()
        Dim dtTemp As New DataTable
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            dtTemp = oClaseOrdenNeg.ListaClaseOrden(oOrdenesinternas)
            If dtTemp.Rows.Count < 1 Then
                cmbClaseOrden.DataSource = Nothing
                cmbClaseOrden.Items.Clear()
                LimpiaDatosClaseOrden()
            Else
                cmbClaseOrden.DataSource = dtTemp
                cmbClaseOrden.ValueMember = "CCLORI"
                cmbClaseOrden.DisplayMember = "CCLORI"
                '-------Recuperamos el codigo de sociedad--------
                Dim dtSociedad As New DataTable
                dtSociedad = oOrdenesinternasNeg.ObtieneSociedad(oOrdenesinternas)
                Dim drSociedad As DataRow = dtSociedad.Rows(0)
                oOrdenesinternas.CSCDSP = CStr(drSociedad("CSCDSP"))
            End If
            bolBuscar = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbClaseOrden_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClaseOrden.SelectedIndexChanged
        If bolBuscar Then
            Cargar_DatosClaseOrden()
        End If
    End Sub
    Private Sub Cargar_DatosClaseOrden()
        Dim dtTempClaseOrden As New DataTable
        If Not (Me.cmbClaseOrden.SelectedValue Is Nothing) Then
            oOrdenesinternas.CCLORI = Me.cmbClaseOrden.SelectedValue
        Else
            oOrdenesinternas.CCLORI = ""
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            dtTempClaseOrden = oClaseOrdenNeg.Datos_ClaseOrden(oOrdenesinternas)
            If dtTempClaseOrden.Rows.Count < 1 Then
                LimpiaDatosClaseOrden()
            Else
                Dim drTempClaseOrden As DataRow = dtTempClaseOrden.Rows(0)
                txtClaseOrden.Text = CStr(drTempClaseOrden("TCLORS"))
                Dim Dif1, Dif2 As Integer
                Dif1 = 12 - Len(CStr(drTempClaseOrden("NRNINS")))
                Dif2 = 12 - Len(CStr(drTempClaseOrden("NULCTR")))
                txtInicio.Text = HelpClass.Replicar("0", Dif1) & CStr(drTempClaseOrden("NRNINS"))
                txtFin.Text = HelpClass.Replicar("0", Dif2) & CStr(drTempClaseOrden("NULCTR"))
            End If
            bolBuscar = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtInicio_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInicio.Validated
        Dim LonInicio As Integer = 0
        Dim MaxLongitud As Integer = 12
        Dim Dif1 As Integer
        LonInicio = Len(txtInicio.Text)
        Dif1 = MaxLongitud - LonInicio
        txtInicio.Text = HelpClass.Replicar("0", Dif1) & txtInicio.Text
    End Sub
    Private Sub txtFin_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFin.Validated
        Dim LonFinal As Integer = 0
        Dim MaxLongitud As Integer = 12
        Dim Dif2 As Integer
        LonFinal = Len(txtFin.Text)
        Dif2 = MaxLongitud - LonFinal
        txtFin.Text = HelpClass.Replicar("0", Dif2) & txtFin.Text
    End Sub
    Private Sub LimpiaDatosClaseOrden()
        txtClaseOrden.Text = ""
        txtInicio.Text = ""
        txtFin.Text = ""
    End Sub
    Private Sub btnActualizaSap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizaSap.Click
        If MsgBox("Desea Generar Ordenes SAP?", MsgBoxStyle.YesNo, "Mensaje de Información") = MsgBoxResult.Yes Then
            oOrdenesinternas.CCLORI = cmbClaseOrden.SelectedValue
            oOrdenesinternas.INI_ORDEN = txtInicio.Text
            oOrdenesinternas.FIN_ORDEN = txtFin.Text
            oOrdenesinternas.INI_FECHA = HelpClass.FormatoFechaAS400(Me.dtFechaInicio.Text)
            oOrdenesinternas.FIN_FECHA = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Text)
            If Not (oOrdenesinternas.CSCDSP Is Nothing) Then
                If Not (oOrdenesinternas.CCLORI Is Nothing) Then
                    Dim proceso_espera As New Threading.Thread(AddressOf Me.IniciaLoader)
                    proceso_espera.Start()
                    oOrdenesinternasNeg.Actualiza_SAP_OrdenInterna_RSAP22(oOrdenesinternas)
                    proceso_espera.Abort()
                End If
            End If
            MsgBox("Se Actualizo las O/I desde el SAP", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
