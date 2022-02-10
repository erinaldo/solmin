Imports RANSA.Utilitario
Imports Ransa.TypeDef
'Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports Ransa.NEGO
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmConsultaPosicion
    Public CCLNT As Int64 = 0
    Private ods As New DataSet()
    Private Sub frmConsultaPosicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
           
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(CCLNT, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            txtCliente.Enabled = False
            rbMercaderia.Checked = True
            rbPosicion.Checked = False
            'Me.crvReporte.DisplayGroupTree = False
            ' Me.crvReporte.Zoom(90)
            ods = Nothing
            dgDatos.AutoGenerateColumns = False
        Catch ex As Exception
        End Try
    End Sub

    Private Function ValidarFiltros() As String
        Dim strmensaje As String = ""
        If (txtTipoAlmacen.Text.Trim = "") Then
            strmensaje = strmensaje & " Debe seleccionar el Tipo Almacen " & Chr(13)
        End If
        If (txtAlmacen.Text.Trim = "") Then
            strmensaje = strmensaje & " Debe seleccionar el Almacen " & Chr(13)
        End If
        Return strmensaje
    End Function
#Region "EventosAlmacen"
    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub
    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub
    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        ' Si modificamos el Almacén - debe limpiarse la Zona
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
            Case Keys.Delete
                txtZonaAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


#End Region

   
    Private Sub VisualizarReporte()
        Try
            ods = Nothing
            crvReporte.ReportSource = Nothing
            dgDatos.DataSource = Nothing
            Dim strmensaje As String = ValidarFiltros()
            If (strmensaje <> "") Then
                MessageBox.Show(strmensaje, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            Dim orptInventarioPosicion As New rptInventarioPosicion()
            Dim obeAlmacen As New beAlmacen()
            obeAlmacen.PNNCLNT = Me.CCLNT
            If (rbMercaderia.Checked = True) Then
                obeAlmacen.PNORDENACION = 1
            Else
                obeAlmacen.PNORDENACION = 2
            End If
            obeAlmacen.PSCTPALM = ("" & txtTipoAlmacen.Tag).ToString.Trim
            obeAlmacen.PSCALMC = ("" & txtAlmacen.Tag).ToString.Trim
            obeAlmacen.PSCZNALM = ("" & txtZonaAlmacen.Tag).ToString.Trim
            ods = oblInventarioMercaderia.Lista_Inventario_por_Posicion(obeAlmacen)
            CType(orptInventarioPosicion.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario
            CType(orptInventarioPosicion.ReportDefinition.ReportObjects("txtCliente"), TextObject).Text = txtCliente.pCodigo & " - " & txtCliente.pRazonSocial
            CType(orptInventarioPosicion.ReportDefinition.ReportObjects("txtTipoAlmacen"), TextObject).Text = obeAlmacen.PSCTPALM
            CType(orptInventarioPosicion.ReportDefinition.ReportObjects("txtAlmacen"), TextObject).Text = obeAlmacen.PSCALMC
            orptInventarioPosicion.SetDataSource(ods.Tables(0))
            crvReporte.ReportSource = orptInventarioPosicion
            dgDatos.DataSource = ods.Tables(0).Copy()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        VisualizarReporte()
    End Sub

   

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'If (ods Is Nothing) Then
            '    MessageBox.Show("No hay datos a exportar ", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'If (ods IsNot Nothing) Then
            '    If (ods.Tables(0).Rows.Count = 0) Then
            '        MessageBox.Show("No hay datos a exportar ", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Exit Sub
            '    End If
            'End If
            ''Dim oDatagridview As New DataGridView()
            ''oDatagridview.AutoGenerateColumns = False
            ''oDatagridview.DataSource = ods.Tables(0).Copy()
            ''Dim objListDtg As New List(Of DataGridView)
            ''objListDtg.Add(oDatagridview)
            ''HelpClass.ExportarExcel_HTML(objListDtg)


            'Dim objListDt As New List(Of DataTable)
            'objListDt.Add(ods.Tables(0).Copy())
            'HelpClass.ExportarExcel_Table(objListDt)

            If (dgDatos.Rows.Count = 0) Then
                MessageBox.Show("No hay datos a exportar ", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim objListDtg As New List(Of DataGridView)
            objListDtg.Add(Me.dgDatos)
            HelpClass.ExportarExcel_HTML(objListDtg)

        Catch ex As Exception

        End Try
       
    End Sub

    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
