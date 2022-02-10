Imports SOLMIN_ST.NEGOCIO.Operaciones


Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmDetalleLiq

    Private oFiltro As New TD_obj_Detalle_Liquidacion
    Private dtUnidadesProductiva As New DataTable
    Private Sub frmDetalleLiq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'bolBuscar = False
            ' gwdDatos.AutoGenerateColumns = False
            'Me.Validar_Acceso_Opciones_Usuario()
            Dim oUnidadProductiva As New NEGOCIO.UnidadProductiva_BLL
            dtUnidadesProductiva = oUnidadProductiva.Listar_Unidad_Productiva

            Me.Cargar_Compania()
            Me.cmbCompania.Enabled = True
            Cargar_VizualizarOp()



            'Me.Cargar_Tipo()
            'Dim oTransPK As TD_TransportistaPK = New TD_TransportistaPK(Me.cmbCompania.CCMPN_CodigoCompania, "", "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

            cmbDivision_SelectionChangeCommitted(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_VizualizarOp()

        Dim dtTipo As New DataTable
        dtTipo.Columns.Add("VALUE")
        dtTipo.Columns.Add("DISPLAY")
        Dim dr As DataRow

        dr = dtTipo.NewRow
        dr("VALUE") = "0"
        dr("DISPLAY") = "Todos"
        dtTipo.Rows.Add(dr)

        dr = dtTipo.NewRow
        dr("VALUE") = "1"
        dr("DISPLAY") = "Con Servicios adicionales"
        dtTipo.Rows.Add(dr)

        dr = dtTipo.NewRow
        dr("VALUE") = "2"
        dr("DISPLAY") = "Solo adicionales"
        dtTipo.Rows.Add(dr)

        dr = dtTipo.NewRow
        dr("VALUE") = "3"
        dr("DISPLAY") = "Con Margen Negativo"
        dtTipo.Rows.Add(dr)

        cboVisualizarOp.DataSource = dtTipo
        cboVisualizarOp.ValueMember = "VALUE"
        cboVisualizarOp.DisplayMember = "DISPLAY"
        cboVisualizarOp.SelectedValue = "0"

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'Dim oFiltro As New TD_obj_Detalle_Liquidacion
        'Dim oGuiaTransportista As New GuiaTransportista_BLL
        'Dim dt As DataTable




        oFiltro = New TD_obj_Detalle_Liquidacion
        With oFiltro
            .pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            .pCDVSN = Me.cmbDivision.Division
            .pNOPRCN = IIf(Me.txtNroOperacion.Text = "", "0", Me.txtNroOperacion.Text)
            .pFECHA_INI = IIf(Me.txtNroOperacion.Text <> "", "0", Format(CDate(Me.dtpFechaInicio.Text), "yyyyMMdd"))
            .pFECHA_FIN = IIf(Me.txtNroOperacion.Text <> "", "0", Format(CDate(Me.dtpFechaFin.Text), "yyyyMMdd"))
            .pCPLNDV = cmbPlanta.SelectedValue
            .pCDUPSP = cboUnidadProductiva.SelectedValue
            .pCCLNT = ctlCliente.pCodigo
        End With

        

        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."

        bgwProceso.RunWorkerAsync()
        'dt = oGuiaTransportista.Lista_Detalle_Liquidacion(oFiltro)


        'Dim filterDT As DataTable = dt.Clone()
        'Dim rows As DataRow() = Nothing
        'Dim pNOPRCN As String = ""
        'Dim pImportar As Boolean = False

        'If Me.cboVisualizarOp.SelectedValue = "0" Then 'Todos
        '    rows = dt.[Select]("")
        '    pImportar = True
        'ElseIf Me.cboVisualizarOp.SelectedValue = "1" Then 'Con Servicios adicionales
        '    'rows = dt.[Select]("ES_FLETE in ('X','') and CSRVC >=1")
        '    Dim oVisitado As New Hashtable
        '    Dim CantServFleteX As Decimal = 0
        '    Dim CantServFleteVacio As Decimal = 0
        '    For Each item As DataRow In dt.Rows
        '        pNOPRCN = item("NOPRCN").ToString.Trim
        '        CantServFleteX = 0
        '        CantServFleteVacio = 0
        '        If Not oVisitado.Contains(pNOPRCN) Then

        '            rows = dt.[Select]("NOPRCN='" & pNOPRCN & "'")
        '            oVisitado(pNOPRCN) = pNOPRCN

        '            For Each itemServ As DataRow In rows
        '                If itemServ("ES_FLETE") = "X" Then
        '                    CantServFleteX = CantServFleteX + 1
        '                End If
        '                If itemServ("ES_FLETE") = "" Then
        '                    CantServFleteVacio = CantServFleteVacio + 1
        '                End If
        '            Next
        '            If CantServFleteX >= 1 And CantServFleteVacio >= 1 Then
        '                For Each itemServ As DataRow In rows
        '                    filterDT.ImportRow(itemServ)
        '                Next
        '            End If

        '        End If
        '    Next




        'ElseIf Me.cboVisualizarOp.SelectedValue = "2" Then 'Solo adicionales
        '    rows = dt.[Select]("ES_FLETE=''")
        '    pImportar = True
        'ElseIf Me.cboVisualizarOp.SelectedValue = "3" Then 'Con Margen Negativo
        '    rows = dt.[Select]("MARGEN_P < 0")
        '    pImportar = True
        'End If

        'If pImportar = True Then
        '    For Each row As DataRow In rows
        '        filterDT.ImportRow(row)
        '    Next
        'End If

        'Me.gwdDatos.AutoGenerateColumns = False
        'Me.gwdDatos.DataSource = filterDT

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.gwdDatos
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Lista Detalle Historial Liquidación"
            'strlFiltros.Add("Compañia : \n" & cboCompania.CCMPN_Descripcion)
            'strlFiltros.Add("División : \n" & cboDivision.DivisionDescripcion)
            'strlFiltros.Add("Planta : \n" & cboPlanta.DescripcionPlanta)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Cargar_Planta()
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


    Private Sub Cargar_Planta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            Dim objPlanta As New NEGOCIO.Planta_BLL
                objPlanta.Crea_Lista()
            objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim ob As New ENTIDADES.mantenimientos.ClaseGeneral
            ob.CPLNDV = 0
            ob.TPLNTA = "Todos"
            objLisEntidad.Insert(0, ob)
            cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
            Me.cmbPlanta.SelectedIndex = 0

            'cmbPlanta_SelectedIndexChanged(Nothing, Nothing)

        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub bgwProceso_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted

        Try
            Dim dt As DataTable
            dt = CType(e.Result, DataTable)

            Dim filterDT As DataTable = dt.Clone()
            Dim rows As DataRow() = Nothing
            Dim pNOPRCN As String = ""
            Dim pImportar As Boolean = False

            If Me.cboVisualizarOp.SelectedValue = "0" Then 'Todos
                rows = dt.[Select]("")
                pImportar = True
            ElseIf Me.cboVisualizarOp.SelectedValue = "1" Then 'Con Servicios adicionales
                'rows = dt.[Select]("ES_FLETE in ('X','') and CSRVC >=1")
                Dim oVisitado As New Hashtable
                Dim CantServFleteX As Decimal = 0
                Dim CantServFleteVacio As Decimal = 0
                For Each item As DataRow In dt.Rows
                    pNOPRCN = item("NOPRCN").ToString.Trim
                    CantServFleteX = 0
                    CantServFleteVacio = 0
                    If Not oVisitado.Contains(pNOPRCN) Then

                        rows = dt.[Select]("NOPRCN='" & pNOPRCN & "'")
                        oVisitado(pNOPRCN) = pNOPRCN

                        For Each itemServ As DataRow In rows
                            If itemServ("ES_FLETE") = "X" Then
                                CantServFleteX = CantServFleteX + 1
                            End If
                            If itemServ("ES_FLETE") = "" Then
                                CantServFleteVacio = CantServFleteVacio + 1
                            End If
                        Next
                        If CantServFleteX >= 1 And CantServFleteVacio >= 1 Then
                            For Each itemServ As DataRow In rows
                                filterDT.ImportRow(itemServ)
                            Next
                        End If

                    End If
                Next


            ElseIf Me.cboVisualizarOp.SelectedValue = "2" Then 'Solo adicionales
                rows = dt.[Select]("ES_FLETE=''")
                pImportar = True
            ElseIf Me.cboVisualizarOp.SelectedValue = "3" Then 'Con Margen Negativo
                rows = dt.[Select]("MARGEN_P < 0")
                pImportar = True
            End If

            If pImportar = True Then
                For Each row As DataRow In rows
                    filterDT.ImportRow(row)
                Next
            End If

            Me.gwdDatos.AutoGenerateColumns = False
            Me.gwdDatos.DataSource = filterDT

            Me.lblProceso.Text = "Finalizado..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

        Catch ex As Exception

            Me.lblProceso.Text = "..."
            Me.pbxProceso.Visible = False
            Me.lblProceso.Visible = False

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub bgwProceso_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Try
            Dim oGuiaTransportista As New GuiaTransportista_BLL
            e.Result = oGuiaTransportista.Lista_Detalle_Liquidacion(oFiltro)

        Catch ex As Exception
         
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
