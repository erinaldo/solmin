Imports SOLMIN_ST.NEGOCIO.Operaciones

Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmHistLiquidacion

    Private oFiltro As New TD_obj_Historial_Liquidacion
    Private dtUnidadesProductiva As New DataTable
    Private Sub frmHistLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim oUnidadProductiva As New NEGOCIO.UnidadProductiva_BLL
            dtUnidadesProductiva = oUnidadProductiva.Listar_Unidad_Productiva

            Me.gwdDatos2.AutoGenerateColumns = False
            Me.gwdDatos.AutoGenerateColumns = False
            Me.Cargar_Compania()
            Cargar_TipoListado()
            cboTipoListado_SelectionChangeCommitted(cboTipoListado, Nothing)

            ListaUnidadProductiva_X_Division(cmbDivision.Division)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaUnidadProductiva_X_Division(pCdvsn As String)


        Dim dr() As DataRow
        dr = dtUnidadesProductiva.Select("CDVSN='" & pCdvsn & "'", "CDVSN ")
        Dim dtUnidProdDivision As New DataTable
        dtUnidProdDivision = dr.CopyToDataTable()

        Dim oDr As DataRow
        oDr = dtUnidProdDivision.NewRow
        oDr.Item("CDUPSP") = ""
        oDr.Item("TDUPSP") = "TODOS"
        dtUnidProdDivision.Rows.InsertAt(oDr, 0)

        cboUnidadProductiva.DataSource = dtUnidProdDivision
        cboUnidadProductiva.ValueMember = "CDUPSP"
        cboUnidadProductiva.DisplayMember = "TDUPSP"
        cboUnidadProductiva.SelectedValue = ""
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cmbCompania_Seleccionar(obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_TipoListado()

        Dim dtTipo As New DataTable
        dtTipo.Columns.Add("VALUE")
        dtTipo.Columns.Add("DISPLAY")
        Dim dr As DataRow

        dr = dtTipo.NewRow
        dr("VALUE") = "HSV"
        dr("DISPLAY") = "Historial Modif.Servicios"
        dtTipo.Rows.Add(dr)

        dr = dtTipo.NewRow
        dr("VALUE") = "HMR"
        dr("DISPLAY") = "Historial Aprobación Margen"
        dtTipo.Rows.Add(dr)

        cboTipoListado.DataSource = dtTipo
        cboTipoListado.ValueMember = "VALUE"
        cboTipoListado.DisplayMember = "DISPLAY"
        cboTipoListado.SelectedValue = "HSV"

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try

            If Me.cboTipoListado.SelectedValue = "HSV" Then 'Historial Modif.Servicios
                If Me.gwdDatos.RowCount = 0 Then Exit Sub
                Dim dtGrid As New DataGridView
                dtGrid = Me.gwdDatos
                Dim strlTitulo As String
                Dim strlFiltros As New List(Of String)
                strlTitulo = "Lista Historial Modif.Servicios"
                Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)

            ElseIf Me.cboTipoListado.SelectedValue = "HMR" Then 'Historial Aprobación Margen
                If Me.gwdDatos2.RowCount = 0 Then Exit Sub
                Dim dtGrid As New DataGridView
                dtGrid = Me.gwdDatos2
                Dim strlTitulo As String
                Dim strlFiltros As New List(Of String)
                strlTitulo = "Lista Historial Aprobación Margen"
                Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        Try

            oFiltro = New TD_obj_Historial_Liquidacion

            'Dim oFiltro As New TD_obj_Historial_Liquidacion
            Dim oGuiaTransportista As New GuiaTransportista_BLL
            'Dim dt As DataTable
            'oFiltro.pClear()
            With oFiltro
                .pTIPO_LISTADO = Me.cboTipoListado.SelectedValue
                .pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                .pCDVSN = Me.cmbDivision.Division
                .pNOPRCN = IIf(Me.txtNroOperacion.Text = "", "0", Me.txtNroOperacion.Text)
                .pFINCOP_INI = IIf(Me.txtNroOperacion.Text <> "", "0", Format(CDate(Me.dtpFechaInicio.Text), "yyyyMMdd"))
                .pFINCOP_FIN = IIf(Me.txtNroOperacion.Text <> "", "0", Format(CDate(Me.dtpFechaFin.Text), "yyyyMMdd"))

                .pCDUPSP = cboUnidadProductiva.SelectedValue
                .pCCLNT = ctlCliente.pCodigo

            End With

            Me.pbxProceso.Visible = True
            Me.lblProceso.Visible = True
            Me.lblProceso.Text = "Procesando..."

            bgwProceso.RunWorkerAsync()

            'dt = oGuiaTransportista.Lista_Historial_Liquidacion(oFiltro)


            'If Me.cboTipoListado.SelectedValue = "HSV" Then 'Historial Modif.Servicios

            '    Me.gwdDatos.DataSource = dt
            'ElseIf Me.cboTipoListado.SelectedValue = "HMR" Then 'Historial Aprobación Margen

            '    Me.gwdDatos2.DataSource = dt
            'End If

        Catch ex As Exception
            Me.lblProceso.Text = "..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      

    End Sub




    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

 



    Private Sub cboTipoListado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoListado.SelectionChangeCommitted
        Try
            'If (cboTipoListado.SelectedValue).ToString = "System.Data.DataRowView" Then Exit Sub
            If Me.cboTipoListado.SelectedValue = "HSV" Then 'Historial Modif.Servicios
                'Me.TabControl1.SelectedTab = TabPage1
                TabControl1.TabPages.Clear()
                TabControl1.TabPages.Add(TabPage1)
            ElseIf Me.cboTipoListado.SelectedValue = "HMR" Then 'Historial Aprobación Margen
                'Me.TabControl1.SelectedTab = TabPage2
                TabControl1.TabPages.Clear()
                TabControl1.TabPages.Add(TabPage2)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgwProceso_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Try
            Dim oGuiaTransportista As New GuiaTransportista_BLL
            e.Result = oGuiaTransportista.Lista_Historial_Liquidacion(oFiltro)

        Catch ex As Exception

            Me.lblProceso.Text = "..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted

        Try
            Dim dt As DataTable
            dt = CType(e.Result, DataTable)


            If Me.cboTipoListado.SelectedValue = "HSV" Then 'Historial Modif.Servicios

                Me.gwdDatos.DataSource = dt
            ElseIf Me.cboTipoListado.SelectedValue = "HMR" Then 'Historial Aprobación Margen

                Me.gwdDatos2.DataSource = dt
            End If

            Me.lblProceso.Text = "..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

        Catch ex As Exception

            Me.lblProceso.Text = "..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     

    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            ListaUnidadProductiva_X_Division(cmbDivision.Division)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
