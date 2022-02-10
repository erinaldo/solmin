
Imports Ransa.Utilitario
Imports System.Windows.Forms

Public Class frmConsultaIncidenciaPorMes

    Private rptTemp As rptIncidenciaMes1
    Public objCliente As beCliente
    Public Lista As List(Of beCliente)
    Dim DSGENERAL As DataSet

#Region "PROPIEDADES"

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pCompania As String
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Private _pArea As String
    Public Property pArea() As String
        Get
            Return _pArea
        End Get
        Set(ByVal value As String)
            _pArea = value
        End Set
    End Property

    Private _pIncPara As Decimal
    Public Property pIncPara() As Decimal
        Get
            Return _pIncPara
        End Get
        Set(ByVal value As Decimal)
            _pIncPara = value
        End Set
    End Property


#End Region

#Region "EVENTOS"

    Private Sub frmListaRegistroIncidencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, _pUsuario)
            txtCliente.pCargar(ClientePK)
            'Cargar_Divisiones()
            Cargar_Areas()
            Cargar_Plantas()
            txtAnio.Text = Now.Year
            Cargar_Mes()
            Cargar_Reportado()
            Lista_Inc_Negocio()
            Lista_Inc_Para()
            cmbIncPara.SelectedValue = _pIncPara
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub Reporte(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        Try
            If fblnValidaInformacion() = True Then
                pcxEspera.Visible = True
                tsbCancelar.Enabled = False
                tsbGenerarReporte.Enabled = False
                bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception
            pcxEspera.Visible = False
            tsbCancelar.Enabled = True
            tsbGenerarReporte.Enabled = True
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try

            Dim objVisor As New Ransa.Controls.Incidencia.frmVisorIncidenciasPorMes

            If DSGENERAL IsNot Nothing AndAlso DSGENERAL.Tables(0).Rows.Count > 0 Then

                objVisor.dsReporte = DSGENERAL
                objVisor.pCliente = txtCliente.pRazonSocial
                objVisor.pAnio = txtAnio.Text.Trim
                If cmbArea.EditValue.ToString.Trim.Length > 5 Then
                    objVisor.pAreas = "VARIOS"
                Else
                    objVisor.pAreas = cmbArea.Text
                End If
                If cmbPlanta.EditValue.ToString.Trim.Length > 5 Then
                    objVisor.pPlantas = "VARIOS"
                Else
                    objVisor.pPlantas = cmbPlanta.Text
                End If

                If cmbReportado.EditValue.ToString.Trim.Length > 3 Then
                    objVisor.pReportado = "VARIOS"
                Else
                    objVisor.pReportado = cmbReportado.Text
                End If

                objVisor.pIncPara = cmbIncPara.Text.Trim
                cmbNegocio.EditValue.ToString.Trim.Replace(" ", "")
                If cmbNegocio.EditValue.ToString.Trim.Length > 14 Then
                    objVisor.pNegocio = "VARIOS"
                Else
                    objVisor.pNegocio = cmbNegocio.Text
                End If

                pcxEspera.Visible = False
                tsbCancelar.Enabled = True
                tsbGenerarReporte.Enabled = True
                objVisor.ShowDialog()

            Else
                MessageBox.Show("No hay información a mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pcxEspera.Visible = False
                tsbCancelar.Enabled = True
                tsbGenerarReporte.Enabled = True
            End If

        Catch ex As Exception
            pcxEspera.Visible = False
            tsbCancelar.Enabled = True
            tsbGenerarReporte.Enabled = True
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Try
            pReporteConsultaIncidenciaPorMes()
        Catch ex As Exception
            pcxEspera.Visible = False
            tsbCancelar.Enabled = True
            tsbGenerarReporte.Enabled = True
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"

    'Private Sub Cargar_Divisiones()
    '    Dim objDAL As New RANSA.DAO.UbicacionPlanta.Division.daoDivision
    '    Dim dt As DataTable = Nothing
    '    dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, _pCompania)
    '    cmbArea.Properties.DataSource = dt
    '    cmbArea.Properties.ValueMember = "CDVSN"
    '    cmbArea.Properties.DisplayMember = "TCMPDV"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    cmbArea.EditValue = _pArea
    '    cmbArea.RefreshEditValue()
    'End Sub

    Private Sub Cargar_Areas()

        Dim dt As DataTable = Nothing
        Dim objBLL As New brIncidencias
        dt = objBLL.Lista_Areas

        cmbArea.Properties.DataSource = dt
        cmbArea.Properties.Tag = dt.Copy
        cmbArea.Properties.ValueMember = "CARINC"
        cmbArea.Properties.DisplayMember = "TDARINC"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbArea.EditValue = _pArea
        cmbArea.RefreshEditValue()

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

        cmbMes.Properties.DataSource = dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbArea.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos una división. " & vbNewLine
        End If

        If cmbPlanta.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos una planta. " & vbNewLine
        End If

        If cmbReportado.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos un Reportado por:. " & vbNewLine
        End If

        If cmbNegocio.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos un negocio. " & vbNewLine
        End If

        If txtAnio.Text.Trim = "" Then
            strMensajeError &= "Debe Ingresar un año. " & vbNewLine
        ElseIf CInt(txtAnio.Text) < 2000 Then
            strMensajeError &= "Debe Ingresar un año valido. " & vbNewLine
        End If

        If cmbMes.Properties.GetCheckedItems = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function


    Private Sub pReporteConsultaIncidenciaPorMes()

        Dim obeIncidencias As New beIncidencias
        Dim obrIncidencias As New brIncidencias

        With obeIncidencias
            .PSCCMPN = _pCompania
            .PSCARINC = ListaCodigoAreas()
            .PSCPLNDV_DES = cmbPlanta.EditValue.ToString.Trim.Replace(" ", "")
            If txtCliente.pCodigo.ToString.Trim = "0" Then
                .PSCCLNT1 = "-1"
            Else
                .PSCCLNT1 = txtCliente.pCodigo.ToString
            End If
            .PSFRGTRO1 = ListaCodigoMeses()
            .ANIO = CInt(Val(txtAnio.Text))
            .PNCTPINC = cmbIncPara.SelectedValue
            .PSCRGVTA = cmbNegocio.EditValue.ToString.Trim.Replace(" ", "")
            .PSSORINC = cmbReportado.EditValue.ToString.Trim.Replace(" ", "")
        End With

        Dim dsReporte As New DataSet
        Dim dtMes As New DataTable
        Dim Lista As New List(Of String)
        Lista = Lista_Meses()

        DSGENERAL = New DataSet

        dsReporte = obrIncidencias.ConsultaIncidenciaPorMes_V1(obeIncidencias, Lista)
        DSGENERAL = Nothing

        If dsReporte IsNot Nothing Then

            Dim dt1 As DataTable = dsReporte.Tables(0)

            Dim dv As New DataView(dt1)
            dv.Sort = "TINCSI ASC"
            dt1 = dv.ToTable

            Dim dsReporteOrdenado As New DataSet
            dsReporteOrdenado.Tables.Add(dt1.Copy)

            DSGENERAL = dsReporteOrdenado

        End If
    End Sub

    Function ListaCodigoAreas() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbArea.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbArea.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Function ListaCodigoMeses() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbMes.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Function Lista_Meses() As List(Of String)
        Dim Lista As New List(Of String)
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items.Item(i).CheckState = 1 Then
                Lista.Add(cmbMes.Properties.Items.Item(i).Description.ToString())
            End If
        Next
        Return Lista
    End Function

#End Region

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.EditValueChanged
        Cargar_Plantas()
    End Sub

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias

        cmbIncPara.DataSource = objBLL.Lista_Inc_Para
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 1

    End Sub


    Sub Lista_Inc_Negocio()

        Dim objBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim dtNegocio As New DataTable
        Dim dr As DataRow

        objBE.PSCCMPN = _pCompania

        cmbNegocio.Properties.DataSource = objBLL.Lista_Inc_Negocio(objBE)
        cmbNegocio.Properties.DisplayMember = "TCRVTA"
        cmbNegocio.Properties.ValueMember = "CRGVTA"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbNegocio.EditValue = "0"
        cmbNegocio.RefreshEditValue()


    End Sub

    Private Sub Cargar_Reportado()

        Dim objBLL As New brIncidencias
        Dim dtReportado_data As New DataTable
        dtReportado_data = objBLL.Lista_Nivel_y_Reportado().Tables(1)

        cmbReportado.Properties.DataSource = dtReportado_data
        cmbReportado.Properties.ValueMember = "SORINC"
        cmbReportado.Properties.DisplayMember = "DESCRIPCION"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbReportado.EditValue = _pArea
        cmbReportado.RefreshEditValue()

    End Sub

    Function Codigo_Division_X_Area(ByVal dt As DataTable, ByVal CCMPN As String, ByVal codigo_area As String) As String
        Dim resultado As String = ""
        Dim dr() As DataRow
        dr = dt.Select("CCMPN = '" & CCMPN & "' AND CARINC = '" & codigo_area & "'")
        If dr.Length > 0 Then
            resultado = ("" & dr(0)("CDVSN")).ToString.Trim
        End If
        Return resultado
    End Function


    Private Sub Cargar_Plantas()

        'Dim objBLL As Negocio.UbicacionPlanta.Planta.brPlanta
        'Dim objBE As New TypeDef.UbicacionPlanta.Planta.bePlanta
        'Dim objLisEntidad As List(Of TypeDef.UbicacionPlanta.Planta.bePlanta)
        Dim objBLL As UbicacionPlanta.Planta.brPlanta
        Dim objBE As New UbicacionPlanta.Planta.bePlanta
        Dim objLisEntidad As List(Of UbicacionPlanta.Planta.bePlanta)
        Dim Codigo_Division As String = ""

        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add("CPLNDV")
        dt.Columns.Add("TPLNTA")

        cmbPlanta.Properties.DataSource = Nothing
        cmbPlanta.EditValue = 0

        If cmbArea.Properties.Items.Count = 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To cmbArea.Properties.Items.Count - 1
            If cmbArea.Properties.Items.Item(i).CheckState = 1 Then

                'objLisEntidad = New List(Of TypeDef.UbicacionPlanta.Planta.bePlanta)
                'objBLL = New Negocio.UbicacionPlanta.Planta.brPlanta
                objLisEntidad = New List(Of UbicacionPlanta.Planta.bePlanta)
                objBLL = New UbicacionPlanta.Planta.brPlanta


                Codigo_Division = Codigo_Division_X_Area(cmbArea.Properties.Tag, _pCompania, cmbArea.Properties.Items.Item(i).Value.ToString.Trim)

                objBLL.Crea_Lista(_pUsuario)
                objLisEntidad = objBLL.Lista_Planta_X_Usuario(_pCompania, Codigo_Division)

                For Each objBE In objLisEntidad
                    dr = dt.NewRow

                    Dim dr1 As DataRow()
                    dr1 = dt.Select("CPLNDV = '" & objBE.CPLNDV_CodigoPlanta.ToString.Trim & "'")

                    If dr1.Length = 0 Then
                        dr("CPLNDV") = objBE.CPLNDV_CodigoPlanta
                        dr("TPLNTA") = objBE.TPLNTA_DescripcionPlanta
                        dt.Rows.Add(dr)
                    End If

                Next

            End If
        Next

        cmbPlanta.Properties.DataSource = dt
        cmbPlanta.Properties.ValueMember = "CPLNDV"
        cmbPlanta.Properties.DisplayMember = "TPLNTA"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbPlanta.CheckAll()

    End Sub


    Private Sub txtAnio_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
