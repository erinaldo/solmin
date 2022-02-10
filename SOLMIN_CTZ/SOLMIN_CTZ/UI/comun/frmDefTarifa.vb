Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
  
Public Class frmDefTarifa

    Private oCompania As clsCompania
    Private oServicioNeg As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oPlantaNeg As SOLMIN_CTZ.NEGOCIO.clsPlanta
  
    Private oMoneda As SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private oServicio As SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oUM As SOLMIN_CTZ.NEGOCIO.clsUM
    Private oCentroCosto As SOLMIN_CTZ.NEGOCIO.clsCentroCosto

    Private oTarifa As New SOLMIN_CTZ.Entidades.Tarifa
    Private oRango As New SOLMIN_CTZ.Entidades.Rango
    Private frmContrato As frmNewContrato
    Private oTarifaDescripciones As New SOLMIN_CTZ.Entidades.Tarifa
    Private bolGenera As Boolean
    Private bolCarga As Boolean

    Private _ListaRango As New List(Of Tarifa)
    Private obj_tarifa As Tarifa
    Private _isnew As Boolean = False

    Sub New(ByVal pobjfrm As frmNewContrato, ByVal objTarifa As Object, ByVal objRango As Object)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frmContrato = pobjfrm
        bolCarga = False
        oTarifa = CType(objTarifa, Tarifa)
        If Not IsNothing(objRango) Then
            oRango = CType(objRango, Rango)
            bolCarga = True
        Else
            _isnew = True
        End If
    End Sub

    Public ReadOnly Property TipoTarifa() As Integer
        Get
            Return Me.cboTipoTarifa.SelectedIndex
        End Get
    End Property

    Public ReadOnly Property GetTarifa() As Tarifa
        Get
            Return obj_tarifa
        End Get
    End Property

    Private Sub frmDefTarifa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oFiltroPlanta As New SOLMIN_CTZ.Entidades.Filtro
        Dim dtPlanta As New DataTable()
        oMoneda = New SOLMIN_CTZ.NEGOCIO.clsMoneda
        oServicioNeg = New SOLMIN_CTZ.NEGOCIO.clsServicio
        oPlantaNeg = New SOLMIN_CTZ.NEGOCIO.clsPlanta
        oUM = New SOLMIN_CTZ.NEGOCIO.clsUM
        oCentroCosto = New SOLMIN_CTZ.NEGOCIO.clsCentroCosto
        oMoneda.Crea_Moneda()
        oUM.Crear_UM()
        oCentroCosto.Crear_CentroCosto()
        oPlantaNeg.Crea_Lista()
        Llenar_Combos()
        If bolCarga Then
            Cargar_Tarifa()
        End If
    End Sub

    Private Sub Llenar_Combos()
        bolGenera = False
        '====================Cargar Servicio====================
        'Carga Moneda
        Me.cmbMoneda.DataSource = oMoneda.Lista
        Me.cmbMoneda.ValueMember = "CMNDA1"
        Me.cmbMoneda.DisplayMember = "TSGNMN"
        'Carga Unidad de Medida
        Me.cmbUnidadMedida.DataSource = oUM.Lista
        Me.cmbUnidadMedida.ValueMember = "CUNDMD"
        Me.cmbUnidadMedida.DisplayMember = "TCMPUN"
        'Carga Centro Costo
        Me.cmbCentroCosto.DataSource = oCentroCosto.Lista
        Me.cmbCentroCosto.ValueMember = "CCNTCS"
        Me.cmbCentroCosto.DisplayMember = "CCNBNS"
        'Carga Servicios
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        oFiltro.Parametro1 = HelpClass.getSetting("Compania")
        cboServicio.DataSource = oServicioNeg.Lista_Servicio_X_Compania(oFiltro)
        cboServicio.DisplayMember = "NOMSER"
        cboServicio.ValueMember = "NRSRRB"
        'Carga Plantas
        Dim oDtPlntDif As New DataTable
        oDtPlntDif = oPlantaNeg.Lista.Copy
        oDtPlntDif.Columns.Remove("CDVSN")
        Dim oDv As New DataView(oDtPlntDif)
        oDtPlntDif = oDv.ToTable(True)
        cboPlanta.DataSource = oDtPlntDif 'oPlantaNeg.Lista
        cboPlanta.DisplayMember = "TPLNTA"
        cboPlanta.ValueMember = "CPLNDV"
        bolGenera = True

        Me.cboTipoTarifa.SelectedIndex = 0
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        Generar_Tarifa()
    End Sub

    Private Sub cmbUnidadMedida_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUnidadMedida.SelectedIndexChanged
        Generar_Tarifa()
    End Sub

    Private Sub cmbTipoTarifa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoTarifa.SelectedIndexChanged
        txtCantidad.Text = 1
        If cboTipoTarifa.SelectedIndex = 2 Then
            txtCantidad.Enabled = False
            txtMonto.Enabled = False
            HGRango.Visible = True
            Me.Height = Me.MaximumSize.Height
        Else
            txtMonto.Enabled = True
            txtCantidad.Enabled = False
            If cboTipoTarifa.SelectedIndex = 1 Then
                txtCantidad.Enabled = True
            End If
            HGRango.Visible = False
            Me.Height = Me.MinimumSize.Height
        End If
    End Sub

    Private Sub txtCantidad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyUp
        Generar_Tarifa()
    End Sub

    Private Sub txtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        Generar_Tarifa()
    End Sub
  
    Private Sub txtMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyUp
        Generar_Tarifa()
    End Sub

    Private Sub txtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.LostFocus
        Generar_Tarifa()
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Generar_Tarifa()
    End Sub
  
    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Generar_Tarifa()
    End Sub

    Private Sub Cargar_Tarifa()
        Dim oTarifaNeg As New clsTarifa
        Me.cmbMoneda.SelectedValue = oTarifa.CMNDA1
        If IsNothing(oTarifa.CUNDMD) Then
            Me.cmbUnidadMedida.SelectedValue = "NADA"
        Else
            If oTarifa.CUNDMD.Trim = "" Then
                Me.cmbUnidadMedida.SelectedValue = "NADA"
            Else
                Me.cmbUnidadMedida.SelectedValue = oTarifa.CUNDMD
            End If
        End If
        Me.cmbCentroCosto.SelectedValue = oTarifa.CCNTCS
        Me.cboPlanta.SelectedValue = oTarifa.CPLNDV
        Me.cboServicio.SelectedValue = oTarifa.NRSRRB
        Select Case oTarifa.STPTRA
            Case "F"
                txtDescripcion.Text = oTarifa.TOBS
                Me.cboTipoTarifa.SelectedIndex = 0
            Case "C"
                txtDescripcion.Text = oTarifa.TOBS
                Me.cboTipoTarifa.SelectedIndex = 1
            Case "R"
                txtDescripcion.Text = oRango.DESRNG.Trim
                Me.cboTipoTarifa.SelectedIndex = 2
                '=========Cargamos Grilla Rango==========
                Dim dt As DataTable = oTarifaNeg.Lista_Rango_RZSC03A(oTarifa)
                Dim iRow As Integer = 0
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As New DataGridViewRow
                    dr.CreateCells(dtgRangoTarifa)
                    dtgRangoTarifa.Rows.Add(dr)
                    'iRow = dtgRangoTarifa.Rows.Count - 1
                    dtgRangoTarifa.Rows(i).Cells("CodTarifa").Value = dt.Rows(i).Item("NRTFSV")
                    dtgRangoTarifa.Rows(i).Cells("CodRango").Value = dt.Rows(i).Item("NRRNGO")
                    dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value = dt.Rows(i).Item("VALMIN")
                    dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value = dt.Rows(i).Item("VALMAX")
                    dtgRangoTarifa.Rows(i).Cells("Tarifa").Value = dt.Rows(i).Item("IVLSRV")
                Next
        End Select
        txtMonto.Text = oTarifa.IVLSRV
        txtCantidad.Text = oTarifa.VALCTE
        Generar_Tarifa()
    End Sub

    Private Sub Generar_Tarifa()
        Try
            If bolGenera Then
                Dim strTarifa As String = ""
                strTarifa = Me.cmbMoneda.Text.Trim
                If Me.txtMonto.Text.Trim <> vbNullString Then
                    strTarifa = strTarifa & " " & Format(CType(Me.txtMonto.Text.Trim, Double), "###,###,###,##0.000")
                End If
                Generar_Concepto()
                oTarifaDescripciones.MntTarifa = strTarifa
                If cboTipoTarifa.SelectedIndex = 2 Then
                    Me.txtTarifa.Text = oTarifaDescripciones.DesConcepto
                Else
                    Me.txtTarifa.Text = oTarifaDescripciones.MntTarifa & " " & oTarifaDescripciones.DesConcepto
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub Generar_Concepto()
        If bolGenera Then
            Dim strConcepto As String = ""
            If Me.cboTipoTarifa.SelectedIndex < 2 Then
                If Me.txtCantidad.Text.Trim = "1" Then
                    strConcepto = strConcepto & " por"
                Else
                    strConcepto = strConcepto & " por " & Format(CType(Me.txtCantidad.Text.Trim, Double), "###,###,###,##0")
                End If
            Else
                Dim rango_text As String = ""

                For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                    If Not (CDbl(obj.Cells("RangoInicial").Value.ToString()) = 0 And CDbl(obj.Cells("RangoFinal").Value.ToString()) = 0) Then
                        rango_text = rango_text & " de " & obj.Cells("RangoInicial").Value.ToString() & " a " & obj.Cells("RangoFinal").Value.ToString() & " por " & cmbMoneda.Text & obj.Cells("Tarifa").Value.ToString() & vbNewLine
                    End If
                Next
                strConcepto = strConcepto & rango_text
            End If
            If Me.cmbUnidadMedida.SelectedValue <> "NADA" Then
                strConcepto = strConcepto & " " & Me.cmbUnidadMedida.Text.Trim
            End If
            If Me.txtDescripcion.Text <> vbNullString Then
                strConcepto = strConcepto & " " & Me.txtDescripcion.Text.Trim
            End If
            oTarifaDescripciones.DesConcepto = strConcepto
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function Genera_Descripcion() As String
        Dim strTarifa As String = ""
        If Me.cboTipoTarifa.SelectedIndex = 0 Then
            If Me.txtCantidad.Text.Trim = "1" Then
                strTarifa = "por"
            Else
                strTarifa = "por " & Format(CType(Me.txtCantidad.Text.Trim, Double), "###,###,###,##0")
            End If
        Else
            Dim rango_text As String = ""
            For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                If Not (CInt(obj.Cells("RangoInicial").Value.ToString()) = 0 And CInt(obj.Cells("RangoFinal").Value.ToString()) = 0) Then
                    rango_text = rango_text & " de " & obj.Cells("RangoInicial").Value.ToString() & " a " & obj.Cells("RangoFinal").Value.ToString() & " por " & obj.Cells("Tarifa").Value.ToString() & vbNewLine
                End If
            Next
            strTarifa = strTarifa & rango_text
        End If
        If Me.cmbUnidadMedida.SelectedValue <> "NADA" Then
            strTarifa = strTarifa & " " & Me.cmbUnidadMedida.Text.Trim
        End If
        If Me.txtDescripcion.Text <> vbNullString Then
            strTarifa = strTarifa & " " & Me.txtDescripcion.Text.Trim
        End If
        Return strTarifa
    End Function

    Private Function Validar() As Boolean
        Dim dblNum As Double
        If Me.txtMonto.Text.Trim = vbNullString And Me.cboTipoTarifa.SelectedIndex = 0 Then
            HelpClass.MsgBox("Debe ingresar un monto", MessageBoxIcon.Information)
            Return False
        End If
        If Me.txtMonto.Text.Trim <> "0" And Me.cboTipoTarifa.SelectedIndex = 0 Then
            Double.TryParse(Me.txtMonto.Text.Trim, dblNum)
            If dblNum = 0 Then
                HelpClass.MsgBox("Debe ingresar un monto válido", MessageBoxIcon.Information)
                Return False
            End If
        End If
        If Me.cboTipoTarifa.SelectedIndex = 2 Then
            For Each obj As DataGridViewRow In Me.dtgRangoTarifa.Rows
                If obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" OrElse obj.Cells("RangoInicial").Value.ToString().Trim() <> "0" Then
                    If CDbl(obj.Cells("RangoInicial").Value.ToString()) > CDbl(obj.Cells("RangoFinal").Value.ToString()) Then
                        Return False
                    End If
                    If CInt(obj.Cells("Tarifa").Value.ToString()) = 0 Then
                        Return False
                    End If
                End If
            Next
        End If
        If Me.cmbCentroCosto.SelectedValue = 0 Then
            HelpClass.MsgBox("Debe Seleccionar un Centro de Costo", MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub btnGrabar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar1.Click
        If Validar() Then
            Dim objTarifa As New Tarifa
            Dim oTrfTemp As New Tarifa
            Dim objProcesoTarifa As New clsTarifa
            Generar_Tarifa()
            objTarifa.NRCTSL = oTarifa.NRCTSL
            objTarifa.CCMPN = HelpClass.getSetting("Compania")
            objTarifa.NRSRRB = cboServicio.SelectedValue
            oTrfTemp = objProcesoTarifa.ObtenerDivTarifa_RZSC08(objTarifa)
            objTarifa.CDVSN = oTrfTemp.CDVSN
            objTarifa.NRRUBR = oTrfTemp.NRRUBR
            objTarifa.CPLNDV = cboPlanta.SelectedValue
            objTarifa.CMNDA1 = cmbMoneda.SelectedValue
            objTarifa.CUNDMD = cmbUnidadMedida.SelectedValue
            objTarifa.CCNTCS = cmbCentroCosto.SelectedValue
            objTarifa.MntTarifa = oTarifaDescripciones.MntTarifa
            objTarifa.IVLSRV = IIf(txtMonto.Text.Trim = "", 0, txtMonto.Text.Trim)
            objTarifa.VALCTE = CDbl(Me.txtCantidad.Text)
            objTarifa.TOBS = txtDescripcion.Text
            objTarifa.PRLBPG = Val(Me.txtPeriodoLibre.Text)
            objTarifa.NRTFSV = oTarifa.NRTFSV
            Select Case Me.cboTipoTarifa.SelectedIndex
                Case 0
                    objTarifa.STPTRA = "F"
                    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                Case 1
                    objTarifa.STPTRA = "C"
                    objTarifa.DESTAR = oTarifaDescripciones.DesConcepto.Trim
                Case 2
                    objTarifa.STPTRA = "R"
                    If dtgRangoTarifa.RowCount = 0 Then Exit Sub
                    objTarifa.DESTAR = "Por Rango"
            End Select
            '-----------------------------------------------
            If objTarifa.NRTFSV <> 0 Then
                objProcesoTarifa.Modificar_Tarifa_RZSC03(objTarifa)
            Else
                objTarifa.NRTFSV = objProcesoTarifa.Crear_Tarifa_RZSC03(objTarifa)
            End If
            If cboTipoTarifa.SelectedIndex = 2 Then
                For i As Integer = 0 To dtgRangoTarifa.Rows.Count - 1
                    Dim objRango As New Rango
                    objRango.VALMIN = dtgRangoTarifa.Rows(i).Cells("RangoInicial").Value.ToString()
                    objRango.VALMAX = dtgRangoTarifa.Rows(i).Cells("RangoFinal").Value.ToString()
                    objRango.IVLSRV = dtgRangoTarifa.Rows(i).Cells("Tarifa").Value.ToString()
                    objRango.NRRNGO = dtgRangoTarifa.Rows(i).Cells("CodRango").Value.ToString()
                    objRango.DESRNG = txtDescripcion.Text.Trim & " (Rango)"
                    objProcesoTarifa.Crear_Rango_RZSC03A(objRango, objTarifa)
                Next
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Hay datos no consistentes, por favor verifique la informacion a registrar", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar1.Click
        Me.Close()
    End Sub

#Region "Validacion de Campos Numericos"
    '-----------------------------------
    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtMonto.Text <> "" And Not txtMonto.Text.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtCantidad.Text <> "" And Not txtCantidad.Text.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub txtIniRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIniRango.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtIniRango.Text <> "" And Not txtIniRango.Text.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub txtFinRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFinRango.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtFinRango.Text <> "" And Not txtFinRango.Text.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
#End Region

    Private Sub btnAgregaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaRango.Click
        If txtIniRango.Text = "" Then Exit Sub
        If txtFinRango.Text = "" Then Exit Sub
        If txtMontoRango.Text = "" Or txtMontoRango.Text = "0" Then Exit Sub
        If CDbl(txtIniRango.Text) > CDbl(txtFinRango.Text) Then
            MsgBox("El Valor Maximo debe ser Mayor a Valor Minimo", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim dr As New DataGridViewRow
        Dim iRow As Integer = 0
        dr.CreateCells(dtgRangoTarifa)
        dtgRangoTarifa.Rows.Add(dr)
        iRow = dtgRangoTarifa.Rows.Count - 1
        dtgRangoTarifa.Rows(iRow).Cells("CodTarifa").Value = oTarifa.NRTFSV
        dtgRangoTarifa.Rows(iRow).Cells("CodRango").Value = 0
        dtgRangoTarifa.Rows(iRow).Cells("RangoInicial").Value = txtIniRango.Text
        dtgRangoTarifa.Rows(iRow).Cells("RangoFinal").Value = txtFinRango.Text
        dtgRangoTarifa.Rows(iRow).Cells("Tarifa").Value = txtMontoRango.Text
        txtIniRango.Text = ""
        txtFinRango.Text = ""
        txtMontoRango.Text = ""
        txtIniRango.Focus()
    End Sub

    Private Sub btnQuitaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitaRango.Click
        If dtgRangoTarifa.Rows.Count = 0 Then Exit Sub
        If dtgRangoTarifa.Rows(dtgRangoTarifa.CurrentRow.Index).Cells("CodRango").Value = 0 Then
            dtgRangoTarifa.Rows.RemoveAt(dtgRangoTarifa.CurrentRow.Index)
        Else
            MsgBox("No es posible eliminar el rango, debido a que ya tiene un código asignado", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtMontoRango_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoRango.KeyUp
        If (e.KeyValue = 13) Then
            btnAgregaRango_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtMontoRango_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoRango.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtMontoRango.Text <> "" And Not txtMontoRango.Text.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub txtMontoRango_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoRango.Leave
        If txtMontoRango.Text.EndsWith(".") Then
            txtMontoRango.Text = txtMontoRango.Text.Replace(".", "")
        End If
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        If txtMonto.Text.EndsWith(".") Then
            txtMonto.Text = txtMonto.Text.Replace(".", "")
        End If
    End Sub
    Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        If txtCantidad.Text.EndsWith(".") Then
            txtCantidad.Text = txtCantidad.Text.Replace(".", "")
        End If
    End Sub

End Class
