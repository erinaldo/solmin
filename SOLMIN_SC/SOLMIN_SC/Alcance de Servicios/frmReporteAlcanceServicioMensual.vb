Imports Ransa.TypeDef.Cliente
Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmReporteAlcanceServicioMensual
    Private dtGeneral As DataTable
    Dim obeAlcanceServicio As New beAlcanceServicio
    Dim obrAlcanceServicio As New clsAlcanceServicio
    Private _PSCCMPN As String = ""
    Private strTipoReporte As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Private _PSCDVSN As String = ""
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCCLNT As Integer = 0
    Public Property PNCCLNT() As Integer
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Integer)
            _PNCCLNT = value
        End Set
    End Property

    Private Sub frmReporteAlcanceServicioMensual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcDivision_Cmb011.Compania = _PSCCMPN
        UcDivision_Cmb011.Usuario = HelpUtil.UserName
        UcDivision_Cmb011.DivisionDefault = _PSCDVSN
        UcDivision_Cmb011.pActualizar()
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
        txtCliente.pCargar(ClientePK)
        txtCliente.pCargar(_PNCCLNT)
        txtAnio.Text = Now.Year
        Cargar_Mes()
        cmbMes.SelectedValue = IIf((Now.Month < 10), "0" & Now.Month, Now.Month.ToString)
    End Sub
    Sub Cargar_Mes()
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dtMes.Rows.Add(dr)

        cmbMes.DataSource = dtMes
        cmbMes.ValueMember = "Codigo"
        cmbMes.DisplayMember = "Descripcion"

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

 

    Private Sub ButtonSpecHeaderGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bgwReporte_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwReporte.DoWork


        dtGeneral = obrAlcanceServicio.fdtAlcanceServicioXClientexMes(obeAlcanceServicio)
    End Sub

    Private Sub bgwReporte_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReporte.RunWorkerCompleted

        pcxEspera.Visible = False
        btnGenerarReporte.Enabled = True
        btnExcel.Enabled = True
        If dtGeneral.Rows.Count > 0 Or dtGeneral Is Nothing Then
            If strTipoReporte = "C" Then
                Dim oFrm As New frmVisor
                oFrm.TCMPDV = Me.UcDivision_Cmb011.DivisionDescripcion
                oFrm.TCMPCL = Me.txtCliente.pRazonSocial
                oFrm.ANIO = Me.txtAnio.Text
                oFrm.MES = Me.cmbMes.Text
                oFrm.DataTable = dtGeneral
                oFrm.ShowDialog()
            ElseIf strTipoReporte = "E" Then
                Dim lstFlistros As New List(Of String)
                Dim dsReporte As New DataSet
                dtGeneral.Columns.Remove("CCMPN")
                dtGeneral.Columns.Remove("CDVSN")
                dtGeneral.Columns("TCMPDV").ColumnName = "DIVISIÓN"
                dtGeneral.Columns("TDALSR").ColumnName = "DESCRIPCIÓN ALCANCE DE SERVICIO"
                dtGeneral.Columns("TINDMD").ColumnName = "INDICADOR DE MEDICIÓN"
                dtGeneral.Columns("KPIS").ColumnName = "KPI´S"
                dtGeneral.Columns("TFRMMD").ColumnName = "FORMA DE MEDICIÓN"
                dtGeneral.Columns("UNIDAD").ColumnName = "MEDIDA"
                dtGeneral.Columns("TSRVC").ColumnName = "DESCRIPCIÓN DEL SERVICIO"
                dtGeneral.TableName = "Reporte"
                dsReporte.Tables.Add(dtGeneral.Copy)
                lstFlistros.Add("Cliente: \n" & txtCliente.pRazonSocial)
                lstFlistros.Add("Año: \n" & txtAnio.Text)
                lstFlistros.Add("Mes: \n" & cmbMes.Text)
                Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dsReporte, "Alcance de Servicios Mensual", lstFlistros)
            End If
        Else
            MessageBox.Show("No hay información a mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub Consultar()
        If validarCampos() Then
            obeAlcanceServicio.PSCCMPN = PSCCMPN
            obeAlcanceServicio.PSCDVSN = IIf(Me.UcDivision_Cmb011.Division = "-1", "", Me.UcDivision_Cmb011.Division)
            obeAlcanceServicio.PNCCLNT = Me.txtCliente.pCodigo
            obeAlcanceServicio.PNNANASR = Me.txtAnio.Text
            obeAlcanceServicio.PNNMSASR = Me.cmbMes.SelectedValue
            pcxEspera.Visible = True
            bgwReporte.RunWorkerAsync()
        End If
    End Sub
    Private Function validarCampos() As Boolean
        Dim strError As String = ""
        If txtCliente.pCodigo = 0D Then
            strError = strError & "* Ingrese Cliente" & Chr(13)
        End If
        If txtAnio.Text = String.Empty Or Val(txtAnio.Text) < 2000 Then
            strError = strError & "* Ingrese un Año válido"
        End If
        If cmbMes.SelectedValue = String.Empty Then
            strError = strError & "* Seleccione Mes"
        End If
        If strError.Trim.Length > 0 Then
            MessageBox.Show("Verifique: " & Chr(13) & strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click

        btnGenerarReporte.Enabled = False
        btnExcel.Enabled = False
        strTipoReporte = "C" 'cristal report
        Consultar()
        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        btnGenerarReporte.Enabled = False
        btnExcel.Enabled = False
        strTipoReporte = "E" 'cristal excel
        Consultar()
    End Sub
End Class
