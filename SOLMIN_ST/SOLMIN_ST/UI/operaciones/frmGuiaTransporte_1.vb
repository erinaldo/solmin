
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmGuiaTransporte_1

#Region "Variables"
    Private _NOPRCN_1 As Double = 0

    Private bolBuscar As Boolean
    Private _NCSOTR As Double = 0
    Private _NCRRSR As Double = 0
    Private bolCargar_Combos As Boolean = True
    Private lintEstadoOperacion As Int16 = 0
    Private lintEstadoGuiaTrans As Int16 = 0
#End Region

#Region "Propiedades"
    Public Property NCSOTR_1() As Double
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As Double)
            _NCSOTR = value
        End Set
    End Property

    Public Property NCRRSR_1() As Double
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Double)
            _NCRRSR = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmGuiaTransporte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bolBuscar = False
            gwdDatos.AutoGenerateColumns = False
            dtgGuiasSeleccionadas.AutoGenerateColumns = False
            dtgOrdenCompra.AutoGenerateColumns = False
            dtgGuiasTransportistaAnexa.AutoGenerateColumns = False


            Validar_Acceso_Opciones_Usuario()
            Cargar_Compania()
            gwdDatos.DataSource = Nothing
            Cargar_Combos()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

       

    End Sub
    

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""

        If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = 0
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)


            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DataSource = objLisEntidad


            If objLisEntidad.Count > 0 Then
                cboPlanta.SetItemChecked(0, True)
            End If

        End If

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Validar_Datos_Filtro() = True Then Exit Sub
            Limpiar_Controles()
            dtgGuiasSeleccionadas.DataSource = Nothing
            dtgOrdenCompra.DataSource = Nothing
            dtgGuiasTransportistaAnexa.DataSource = Nothing
            Listar_Guias_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
     
    End Sub

  
    ''' <summary>
    ''' Lista de evaluación Operativa
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar_EvaluacionOperativa()
        Dim Entidad As New ENTIDADES.EvaluacionOperativa
        Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
       
        Entidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
        Entidad.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value

        dgvIncidecias_EVO.AutoGenerateColumns = False
        Dim oList As New List(Of ENTIDADES.EvaluacionOperativa)
        oList = ObjNegocioEvalOperativa.Listar_Evaluacion_Operativa(Entidad)       
        dgvIncidecias_EVO.DataSource = oList
        If dgvIncidecias_EVO.RowCount = 0 Then
        End If
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim CodPlantaSel As Decimal = 0
            Dim DescPlantaSel As String = ""
            If cboPlanta.CheckedItems.Count > 1 Or cboPlanta.CheckedItems.Count = 0 Then
                MessageBox.Show("Seleccione una planta específica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                CodPlantaSel = cboPlanta.CheckedItems(i).Value
                DescPlantaSel = cboPlanta.CheckedItems(i).Name

                If CodPlantaSel = 0 Then
                    MessageBox.Show("Seleccione planta específica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
            Dim TabName As String
            TabName = TabGuiaTransportista.SelectedTab.Name

            Select Case TabName 'Me.TabGuiaTransportista.SelectedIndex
                Case "TabInfoGuia" ' 0
                    Dim frm_BuscarSolicitud As New frmBuscarSolicitudGuia
                    Dim obj_Entidad_Guia As New GuiaTransportista
                    Dim lint_Estado As Integer = 0
                    Dim lNPLNMT As Double = 0
                    Dim strNGSGWP As String = ""
                    Dim intNCOREG As Double = 0
                    Dim obj_Logica_Guia As New GuiaTransportista_BLL
                    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
                    With frm_BuscarSolicitud
                        .CCMPN_1 = cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue.ToString.Trim
                        .CDVSN_1 = cmbDivision.Division 'Me.cboDivision.SelectedValue
                       
                        .PlantaDesc = DescPlantaSel
                        .CPLNDV_1 = CodPlantaSel
                        .CTPOCR = 0
                        .ShowDialog()
                        If .pDialogOK = True Then
                            Limpiar_Controles()
                            dtgGuiasSeleccionadas.DataSource = Nothing
                            dtgOrdenCompra.DataSource = Nothing
                            dtgGuiasTransportistaAnexa.DataSource = Nothing
                            Listar_Guias_Transportista()
                        End If
                      

                    End With

                Case "TabPlanRuta" ' 4

                    Dim frm As New frmAsignarPlanRuta()
                    Dim objPlanRuta As New PlanRuta
                    objPlanRuta.PSCCMPN = gwdDatos.Item("CCMPN", gwdDatos.CurrentCellAddress.Y).Value
                    objPlanRuta.PNNGUITR = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                    objPlanRuta.PNCTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                    objPlanRuta.PSSIDAVL = "I" 'Me.gwdDatos.Item("SIDAVL", Me.gwdDatos.CurrentCellAddress.Y).Value
                    objPlanRuta.PSTPOREG = "R"
                    frm.ObjPlanRuta = objPlanRuta
                    frm.TipoOperacion = frmAsignarPlanRuta.TIPO.ASIGNAR
                    frm.TipoPlanRuta = frmAsignarPlanRuta.TIPO_PLAN.VIAJE
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ListaPlanRuta()
                    End If


                Case "TabReasigRecurso" '6

                    Dim SESGRP As String = gwdDatos.Item("SESGRP", gwdDatos.CurrentCellAddress.Y).Value

                    If SESGRP <> "" Then
                        HelpClass.MsgBox("No se puede Modificar Guía Cargada Y/O Liquidada Y el sistema no permitirá conitnuar con la asignación")
                        Return
                    End If
                    Dim ofrmAsigRecursoGT As New frmAsigRecursoGT()
                    Dim ObjAsigRecursos As New AsigRecursoGT_BE

                    ObjAsigRecursos.CCMPN = gwdDatos.Item("CCMPN", gwdDatos.CurrentCellAddress.Y).Value

                    ObjAsigRecursos.NGUITR = gwdDatos.CurrentRow.Cells("NGUIRM").Value
                    ObjAsigRecursos.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                    ObjAsigRecursos.CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                    'Me.cmbPlanta.Planta
                    ObjAsigRecursos.CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value

                    ObjAsigRecursos.CODVAR = "STMTRR"
                    ObjAsigRecursos.RucTransportista = gwdDatos.CurrentRow.Cells("NRUCTR").Value
                    ObjAsigRecursos.CMEDTR = gwdDatos.CurrentRow.Cells("CMEDTR").Value

                    ofrmAsigRecursoGT.obj_Entidad = ObjAsigRecursos
                    If ofrmAsigRecursoGT.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Listar_Recursos_Asignados()
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ListaPlanRuta()
        Dim objPlanRuta As New PlanRuta_BLL
        Dim objEntidad As New PlanRuta
        Dim lint_Indice As Integer = gwdDatos.CurrentCellAddress.Y
        objEntidad.PNCTRMNC = gwdDatos.Item("CTRMNC", lint_Indice).Value
        objEntidad.PNNGUITR = gwdDatos.Item("NGUIRM", lint_Indice).Value
        objEntidad.PSCCMPN = gwdDatos.Item("CCMPN", lint_Indice).Value
        dtgPlanruta.AutoGenerateColumns = False

        Dim dt As DataTable
        dt = objPlanRuta.Listar_PlanRutaViaje(objEntidad)
        dtgPlanruta.DataSource = dt
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim TabName As String
        TabName = TabGuiaTransportista.SelectedTab.Name
        Try

            Select Case TabName 'Me.TabGuiaTransportista.SelectedIndex

                Case "TabInfoGuia"  ' 0
                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
                    If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim <> "" Then
                        HelpClass.MsgBox("No se puede Modificar Guia Cargada Y/O Liquidada", MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    'JM
                    If Me.gwdDatos.Item("FSTENV", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "S" Then
                        If MessageBox.Show("Los datos se encuentran migrados. Desea continuar con la modificación.", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If

                    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
                    Dim Objeto_Logica As New GuiaTransportista_BLL
                    Dim objetoParametro As New Hashtable
                    Dim objDataTable As DataTable
                    Dim intTipoViaje As Int16 = 0
                    objetoParametro.Add("CTRMNC", Me.gwdDatos.Item("CTRMNC", lint_Indice).Value)
                    objetoParametro.Add("NGUITR", Me.gwdDatos.Item("NGUIRM", lint_Indice).Value)
                    objetoParametro.Add("CCMPN", Me.gwdDatos.Item("CCMPN", lint_Indice).Value)
                    objDataTable = Objeto_Logica.Listar_Operaciones_Guia_Transporte(objetoParametro, intTipoViaje)


                 

                    Dim frm_GuiaTransportista As New frmGuiaTransportista
                    Dim lint_CCLNT As Double = 0

                    With frm_GuiaTransportista
                        .IsMdiContainer = True
                        .AutoSize = True
                        Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
                        With Comp_Guia
                            .ESTADO = True
                            .Dock = DockStyle.Fill
                            .pCOMPANIA = Me.gwdDatos.Item("CCMPN", lint_Indice).Value 'EZ
                            .pDIVISION = Me.gwdDatos.Item("CDVSN", lint_Indice).Value 'T
                            .pPLANTA = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value '1
                            .pPLANTA_DESC = Me.gwdDatos.Item("PLANTA", lint_Indice).Value '1

                            .pNOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                            .pUSUARIO = MainModule.USUARIO
                           
                            .TipoViaje = intTipoViaje 'IIf(Me.objTable.Rows.Count = 0, 0, 1)
                            .pCTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                            .pNGUITR = gwdDatos.CurrentRow.Cells("NGUIRM").Value

                            .ChargeForm()
                        End With
                        .panelGuia.Controls.Add(Comp_Guia)
                        .ShowDialog()
                        If Comp_Guia.pDialogOK = True Then

                            Me.Limpiar_Controles()
                            Me.dtgGuiasSeleccionadas.DataSource = Nothing
                            Me.dtgOrdenCompra.DataSource = Nothing
                            Me.dtgGuiasTransportistaAnexa.DataSource = Nothing
                            Me.Listar_Guias_Transportista()
                        End If
                        

                    End With
                    'Me.Cursor = System.Windows.Forms.Cursors.Default
                Case "TabPlanRuta " ' 4

                    If Not Me.dtgPlanruta.RowCount > 0 Then
                        Exit Sub
                    End If

                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
                    If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim <> "" Then
                        HelpClass.MsgBox("No se puede Modificar Guia Cargada Y/O Liquidada", MessageBoxIcon.Warning)
                        Exit Sub
                    End If


                    Dim frm As New frmAsignarPlanRuta()
                    Dim ObjPlanruta As New PlanRuta
                    With Me.dtgPlanruta.CurrentRow
                        ObjPlanruta.PSCCMPN = Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value
                        ObjPlanruta.PNNGUITR = Me.dtgPlanruta.CurrentRow.Cells("NGUITR_D").Value
                        ObjPlanruta.PNCTRMNC = Me.dtgPlanruta.CurrentRow.Cells("CTRMNC_D").Value
                        ObjPlanruta.PNNCRRIT = .Cells("NCRRIT").Value
                        ObjPlanruta.PNCLCLD = .Cells("CLCLD").Value
                        ObjPlanruta.PNFECSEG = .Cells("_FECSEG").Value
                        ObjPlanruta.PNHRASEG = .Cells("_HRASEG").Value
                        ObjPlanruta.PNQDSTVR = .Cells("QDSTVR_D").Value
                        ObjPlanruta.PSTOBS = .Cells("TOBS_D").Value.ToString.Trim
                        ObjPlanruta.PSSIDAVL = "I"
                        ObjPlanruta.PSTPOREG = Me.dtgPlanruta.CurrentRow.Cells("TPOREG_VAL").Value
                    End With

                    frm.ObjPlanRuta = ObjPlanruta
                    frm.TipoOperacion = frmAsignarPlanRuta.TIPO.MODIFICAR
                    frm.TipoPlanRuta = frmAsignarPlanRuta.TIPO_PLAN.VIAJE
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.ListaPlanRuta()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim TabName As String
        TabName = TabGuiaTransportista.SelectedTab.Name
        Try
            Select Case TabName 'Me.TabGuiaTransportista.SelectedIndex
                Case "TabInfoGuia" ' 0

                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub

                    Dim lstr_Mensaje As String = ""
                    If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim.Equals("") Then
                        If Me.dtgGuiasSeleccionadas.RowCount > 0 Then lstr_Mensaje += " GUIA DE REMISION" + Chr(13)
                        If Me.dtgOrdenCompra.RowCount > 0 Then lstr_Mensaje += " ORDEN DE COMPRA" + Chr(13)
                        If Me.dtgGuiasTransportistaAnexa.RowCount > 0 Then lstr_Mensaje += " GUIA TRANSPORTISTA ANEXA" + Chr(13)
                        If lstr_Mensaje <> "" Then
                            HelpClass.MsgBox("TIENE ASIGNADA : " + Chr(13) + lstr_Mensaje, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Else
                        HelpClass.MsgBox("GUIA DE TRANSPORTE : PROCESADA / LIQUIDADA ", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    'JM
                    If Me.gwdDatos.Item("FSTENV", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "S" Then
                        If MessageBox.Show("Los datos se encuentran migrados. Desea continuar con la eliminación.", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If
                    End If


                    Dim objeto_Entidad As New GuiaTransportista
                    Dim objeto_Logica As New GuiaTransportista_BLL
                    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
                    Dim frm_OpcionGuia As New frmOpcionGuia
                    If frm_OpcionGuia.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    objeto_Entidad.CTRMNC = Me.gwdDatos.Item("CTRMNC", lint_Indice).Value
                    objeto_Entidad.NGUIRM = Me.gwdDatos.Item("NGUIRM", lint_Indice).Value
                    objeto_Entidad.NOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value 'CType(Me.txtNroOperacion.Text.Trim, Double)
                    objeto_Entidad.CULUSA = MainModule.USUARIO
                   
                    objeto_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objeto_Entidad.SESTRG = frm_OpcionGuia.OPCION
                    objeto_Entidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'cboCompania.SelectedValue


                    objeto_Logica.Eliminar_Guia_Transportista(objeto_Entidad)
                    MessageBox.Show("Se Eliminó Satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Listar_Guias_Transportista()

                    

                Case "TabPlanRuta"  '4
                    If Not Me.dtgPlanruta.RowCount > 0 Then Exit Sub
                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
                    If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim <> "" Then
                        HelpClass.MsgBox("No se puede Modificar Guia Cargada Y/O Liquidada", MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Dim ObjPlanruta As New PlanRuta
                    With Me.dtgPlanruta.CurrentRow
                        ObjPlanruta.PSCCMPN = Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value
                        ObjPlanruta.PNNGUITR = Me.dtgPlanruta.CurrentRow.Cells("NGUITR_D").Value
                        ObjPlanruta.PNCTRMNC = Me.dtgPlanruta.CurrentRow.Cells("CTRMNC_D").Value
                        ObjPlanruta.PSTPOREG = Me.dtgPlanruta.Item("TPOREG_VAL", Me.dtgPlanruta.CurrentCellAddress.Y).Value
                        ObjPlanruta.PNNCRRIT = .Cells("NCRRIT").Value
                        ObjPlanruta.PSUSRCRT = MainModule.USUARIO
                        ObjPlanruta.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With

                    Dim ObjPlanRuta_BLL As New NEGOCIO.PlanRuta_BLL
                    If ObjPlanRuta_BLL.Eliminar_PlanRutaViaje(ObjPlanruta) = 0 Then
                        HelpClass.ErrorMsgBox()
                    Else
                        HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
                    End If
                    Me.ListaPlanRuta()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                Case "TabReasigRecurso" '6
                    'Eliminar Reasignacion de Recursos
                    If Me.dtgReasigRecurso.RowCount = 0 Then Exit Sub
                    If Me.dtgReasigRecurso.CurrentRow.Selected = False Then Exit Sub

                    If MessageBox.Show("Está seguro de eliminar la asignación.", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If


                    Dim ObjAsigRecursos As New AsigRecursoGT_BE
                    Dim oBL As New RecursosReasignado_BLL()

                    ObjAsigRecursos.CCMPN = Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value

                    ObjAsigRecursos.CTRMNC = Me.dtgReasigRecurso.CurrentRow.Cells("PCTRMNC").Value
                    ObjAsigRecursos.NGUITR = Me.dtgReasigRecurso.CurrentRow.Cells("NGUITR").Value
                    ObjAsigRecursos.CORR = Me.dtgReasigRecurso.CurrentRow.Cells("CORR").Value
                    ObjAsigRecursos.CULUSA = MainModule.USUARIO 'MainModule.USUARIO
                    ObjAsigRecursos.TERMINAL = Ransa.Utilitario.HelpClass.NombreMaquina

                    Dim MenssaggeInfo As String = oBL.Eliminar_Asignacion_Recurso(ObjAsigRecursos)

                    If MenssaggeInfo <> "" Then
                        MessageBox.Show(MenssaggeInfo, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else
                        HelpClass.MsgBox("Se eliminó satisfactoriamente")
                        Me.Listar_Recursos_Asignados()

                    End If


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TabGuiaTransportista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabGuiaTransportista.SelectedIndexChanged

        Dim TabName As String
        TabName = TabGuiaTransportista.SelectedTab.Name

        Select Case TabName 'Me.TabGuiaTransportista.SelectedIndex
            Case "TabInfoGuia" ' 0
                Me.MenuBar.Enabled = True
                Me.btnPrioridadCarga.Visible = False
                Me.btnExportarPlanRuta.Visible = False
                Me.btnAdjuntarDocumento.Visible = True
                Me.btnNuevo.Text = "Nuevo"
                Me.btnModificar.Visible = True
                Me.btnImprimir.Visible = True
                Me.tsbIncidenciaEvalOp.Visible = True
            Case "TabPlanRuta" ' 4
                Me.btnPrioridadCarga.Visible = True
                Me.btnExportarPlanRuta.Visible = True
                Me.MenuBar.Enabled = True
                Me.btnAdjuntarDocumento.Visible = False
                Me.btnNuevo.Text = "Nuevo"
                Me.btnModificar.Visible = True
                Me.btnImprimir.Visible = True
                Me.tsbIncidenciaEvalOp.Visible = True

            Case "TabGuiaRemision", "TabGuiaOrdenCompra", "TabGuiaTransportistaAnexa" ' 1, 2, 3
                Me.MenuBar.Enabled = False
                Me.btnExportarPlanRuta.Visible = False
                Me.btnPrioridadCarga.Visible = False
                Me.btnAdjuntarDocumento.Visible = True

                Me.btnModificar.Visible = True
                Me.btnImprimir.Visible = True
                Me.tsbIncidenciaEvalOp.Visible = True

                Me.btnNuevo.Text = "Nuevo"
            Case "TabReasigRecurso" '6

                Me.MenuBar.Enabled = True
                Me.btnModificar.Visible = False
                Me.btnImprimir.Visible = False
                Me.tsbIncidenciaEvalOp.Visible = False
                Me.btnExportarPlanRuta.Visible = False
                Me.btnPrioridadCarga.Visible = False
                Me.btnAdjuntarDocumento.Visible = False
                Me.btnNuevo.Text = "Asignar"

            Case Else

                Me.MenuBar.Enabled = False
                Me.btnPrioridadCarga.Visible = False
                Me.btnExportarPlanRuta.Visible = False
                Me.btnAdjuntarDocumento.Visible = True
                Me.btnNuevo.Text = "Nuevo"
                Me.btnModificar.Visible = True
                Me.btnImprimir.Visible = True
                Me.tsbIncidenciaEvalOp.Visible = True

        End Select
    End Sub

   

    Private Sub InicializarFormulario()
        Me.Limpiar_Controles()
        gwdDatos.DataSource = Nothing
        cboTransportista.pClearAll()
        If (bolCargar_Combos = True) Then
            Me.Cargar_Combos()
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim TabName As String
        TabName = TabGuiaTransportista.SelectedTab.Name
      

        Try
            Select Case TabName
                Case "TabInfoGuia" ' 0
                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
                    Dim objEntidad As New GuiaTransportista
                    Dim objGuiaTransporte As New GuiaTransportista_BLL
                   
                    objEntidad.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
                    objEntidad.NGUIRM = gwdDatos.CurrentRow.Cells("NGUIRM").Value

                    objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    objEntidad.CDVSN = Me.cmbDivision.Division

                    objEntidad.CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value

                    objEntidad = objGuiaTransporte.Obtener_Guia_Transportista_RPT(objEntidad)
                    Me.Reporte_Guia_Transportista(objEntidad)
                Case "TabPlanRuta" '4
                    If Me.gwdDatos.RowCount = 0 Then Exit Sub
                    If Me.dtgPlanruta.RowCount = 0 Then Exit Sub

                    Dim objRep As New rptPlanRuta_Viaje
                    Dim odtPlanRuta As New DataTable
                    Dim Objeto_Logica As New PlanRuta_BLL
                    Dim objEntidad As New PlanRuta
                    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
                    objEntidad.PNCTRMNC = Me.gwdDatos.Item("CTRMNC", lint_Indice).Value
                    objEntidad.PNNGUITR = Me.gwdDatos.Item("NGUIRM", lint_Indice).Value
                    objEntidad.PSCCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
                    odtPlanRuta = Objeto_Logica.Reporte_PlanRutaViaje(objEntidad)

                    Dim objPrintForm = New PrintForm

                    objRep.SetDataSource(odtPlanRuta)
                    objPrintForm.ShowForm(objRep, Me)

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

   

    Private Sub checkGuiaTransporte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGuiaTransporte.CheckedChanged
        If lintEstadoGuiaTrans = 0 Then
            Select Case checkGuiaTransporte.Checked
                Case True
                    Me.dtpFechaFin.Enabled = False
                    Me.dtpFechaInicio.Enabled = False
                    Me.txtGuiaTransporteFiltro.Enabled = True
                    Me.cboTransportista.Enabled = True
                    lintEstadoOperacion = 1
                    Me.checkOperacion.Checked = False
                    lintEstadoOperacion = 0
                Case False
                    Me.dtpFechaFin.Enabled = True
                    Me.dtpFechaInicio.Enabled = True
                    Me.txtGuiaTransporteFiltro.Enabled = False
            End Select
        End If
    End Sub

    Private Sub checkOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOperacion.CheckedChanged
        If lintEstadoOperacion = 0 Then
            Select Case checkOperacion.Checked
                Case True
                    Me.dtpFechaFin.Enabled = False
                    Me.dtpFechaInicio.Enabled = False
                    Me.txtGuiaTransporteFiltro.Enabled = True
                    Me.cboTransportista.Enabled = False
                    lintEstadoGuiaTrans = 1
                    Me.checkGuiaTransporte.Checked = False
                    lintEstadoGuiaTrans = 0
                Case False
                    Me.dtpFechaFin.Enabled = True
                    Me.dtpFechaInicio.Enabled = True
                    Me.txtGuiaTransporteFiltro.Enabled = False
                    Me.cboTransportista.Enabled = True
            End Select
        End If
    End Sub

    Private Sub txtGuiaTransporteFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransporteFiltro.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Cargar_Combos()
      

        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue
        obeTransportista.pNRUCTR_RucTransportista = ""
        cboTransportista.pCargar(obeTransportista)



    End Sub

    Private Sub Listar_Guias_x_GuiaTRansportista()

        Dim objEntidad As New GuiaTransportista

        objEntidad.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
        objEntidad.NGUIRM = gwdDatos.CurrentRow.Cells("NGUIRM").Value

        Dim listGRCliente As New List(Of GuiaTransportista)
        Dim listGTAnexo As New List(Of GuiaTransportista)
        Dim listOC As New List(Of SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga)

        Dim dtPesos As New DataTable

        Dim objGuiasTransporte As New GuiaTransportista_BLL
        objGuiasTransporte.Listar_Guias_X_GuiaTransportista(objEntidad, listGRCliente, listGTAnexo, listOC, dtPesos)

        dtgGuiasSeleccionadas.DataSource = listGRCliente
      

        dtgOrdenCompra.DataSource = listOC

        dtgGuiasTransportistaAnexa.DataSource = listGTAnexo


    End Sub



    'Private Sub Listar_Guias_Cliente_Registradas()

    '    Dim objEntidadAnexoGuiaCliente As New GuiaTransportista
    '    Dim objanexoGuiaCliente As New GuiaTransportista_BLL

    '    dtgGuiasSeleccionadas.DataSource = Nothing


    '    objEntidadAnexoGuiaCliente.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
    '    objEntidadAnexoGuiaCliente.NGUIRM = gwdDatos.CurrentRow.Cells("NGUIRM").Value
    '    objEntidadAnexoGuiaCliente.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value

    '    objEntidadAnexoGuiaCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'Me.cboCompania.SelectedValue

    '    Dim oListGuias As New List(Of GuiaTransportista)
    '    oListGuias = objanexoGuiaCliente.Listar_Guias_Anexas_Cliente(objEntidadAnexoGuiaCliente)
    '    dtgGuiasSeleccionadas.DataSource = oListGuias


    'End Sub

    'Private Sub Listar_Ordenes_Compra()
    '    'Para cada guia de remision, traemos las ordenes de compra
    '    Dim objEntidadDetalleCargaRecepcionada As New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
    '    Dim objDetalleCargaRecepcionada As New GuiaTransportista_BLL


    '    'LIMPIANDO EL dtgOrdenCompra

    '    Me.dtgOrdenCompra.DataSource = Nothing


    '    objEntidadDetalleCargaRecepcionada.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
    '    objEntidadDetalleCargaRecepcionada.NGUIRM = gwdDatos.CurrentRow.Cells("NGUIRM").Value
    '    objEntidadDetalleCargaRecepcionada.CCLNT = gwdDatos.CurrentRow.Cells("CCLNT2").Value
    '    objEntidadDetalleCargaRecepcionada.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value

    '    objEntidadDetalleCargaRecepcionada.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '    Dim oListManifiesto As New List(Of GuiaOCManifiestoCarga)
    '    oListManifiesto = objDetalleCargaRecepcionada.Listar_Ordenes_Compra_x_MC(objEntidadDetalleCargaRecepcionada)
    '    dtgOrdenCompra.DataSource = oListManifiesto

    'End Sub

    'Private Sub Listar_Guias_Transportista_Registradas()

    '    Dim objEntidad As New GuiaTransportista
    '    Dim objGuiaTransportistaAdicional As New GuiaTransportista_BLL


    '    'LIMPIANDO EL dtgOrdenCompra

    '    Me.dtgGuiasTransportistaAnexa.DataSource = Nothing


    '    objEntidad.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value
    '    objEntidad.NGUIRM = gwdDatos.CurrentRow.Cells("NGUIRM").Value

    '    objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania 'cboCompania.SelectedValue
    '    Dim oLitsGAnexo As New List(Of GuiaTransportista)
    '    oLitsGAnexo = objGuiaTransportistaAdicional.Listar_Guias_Anexas_Transportista(objEntidad)
    '    dtgGuiasTransportistaAnexa.DataSource = oLitsGAnexo


    'End Sub

    Private Sub Listar_Recursos_Asignados()

        Dim objEntidadAsigRecursoGT_BE As New AsigRecursoGT_BE
        Dim objNegocio As New RecursosReasignado_BLL


        'LIMPIANDO EL dtgOrdenCompra
        Me.dtgReasigRecurso.DataSource = Nothing

        objEntidadAsigRecursoGT_BE.CTRMNC = gwdDatos.CurrentRow.Cells("CTRMNC").Value()
        objEntidadAsigRecursoGT_BE.NGUITR = gwdDatos.CurrentRow.Cells("NGUIRM").Value()
        objEntidadAsigRecursoGT_BE.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value()
        dtgReasigRecurso.AutoGenerateColumns = False
        Me.dtgReasigRecurso.DataSource = objNegocio.Listar_Recursos_Asignados(objEntidadAsigRecursoGT_BE)


       


    End Sub

    Private Sub Asignacion_Datos()

        

       
       
        
      



        Me.txtNroRemision.Text = gwdDatos.CurrentRow.Cells("NGUITS").Value

     
        dtpFecGuia.Text = gwdDatos.CurrentRow.Cells("FGUIRM_S").Value

        Me.txtlugar.Text = gwdDatos.CurrentRow.Cells("TRFRGU").Value
        Me.txtNroOperacion.Text = gwdDatos.CurrentRow.Cells("NOPRCN").Value
        Me.txtNroPlaneamiento.Text = gwdDatos.CurrentRow.Cells("NPLNMT").Value
        txtLugarOrigen.Text = gwdDatos.CurrentRow.Cells("TCMLCO").Value
        txtLugarDestino.Text = gwdDatos.CurrentRow.Cells("TCMLCD").Value
        Me.txtDirOrigen.Text = gwdDatos.CurrentRow.Cells("TDIROR").Value
        Me.txtDirDestino.Text = gwdDatos.CurrentRow.Cells("TDIRDS").Value

        Me.txtCantMercaderia.Text = gwdDatos.CurrentRow.Cells("QMRCMC").Value
        Me.txtPesoMercaderia.Text = gwdDatos.CurrentRow.Cells("PMRCMC").Value
        txtunid_medida.Text = gwdDatos.CurrentRow.Cells("CUNDMD").Value
        Me.txtGalsGasolina.Text = gwdDatos.CurrentRow.Cells("QGLGSL").Value
        Me.txtGalsDiesel.Text = gwdDatos.CurrentRow.Cells("QGLDSL").Value
        Me.txtNroHojaGuia.Text = gwdDatos.CurrentRow.Cells("NRHJCR").Value
        Me.txtTracto.Text = gwdDatos.CurrentRow.Cells("NPLCTR").Value
        Me.txtAcoplado.Text = gwdDatos.CurrentRow.Cells("NPLCAC").Value
        Me.txtConfigTracto.Text = gwdDatos.CurrentRow.Cells("TCNFVH").Value
        Me.txtConductor.Text = gwdDatos.CurrentRow.Cells("CBRCNT").Value & " - " & gwdDatos.CurrentRow.Cells("CBRCND").Value  ' Objeto_Entidad_Guia.CBRCNT + " - " + Objeto_Entidad_Guia.CBRCND
        Me.txtNomRemitente.Text = gwdDatos.CurrentRow.Cells("TNMBRM").Value
        Me.txtDirRemitente.Text = gwdDatos.CurrentRow.Cells("TDRCRM").Value


        If ("" & gwdDatos.CurrentRow.Cells("TPDCIR").Value).ToString.Trim = "D" Then
            Me.rbtnDNIRemit.Checked = True
            Me.rbtnRUCRemit.Checked = False
        Else
            Me.rbtnDNIRemit.Checked = False
            Me.rbtnRUCRemit.Checked = True
        End If
        Me.txtNroDocRemitente.Text = gwdDatos.CurrentRow.Cells("NRUCRM").Value
        Me.txtNomConsignatario.Text = gwdDatos.CurrentRow.Cells("TNMBCN").Value
        Me.txtDirConsignatario.Text = gwdDatos.CurrentRow.Cells("TDRCNS").Value

        If ("" & gwdDatos.CurrentRow.Cells("TPDCIC").Value).ToString.Trim = "D" Then

            Me.rbtnDNIConsignatario.Checked = True
            Me.rbtnRUCConsignatario.Checked = False
        Else
            Me.rbtnDNIConsignatario.Checked = False
            Me.rbtnRUCConsignatario.Checked = True
        End If
        Me.txtNroDocConsignatario.Text = gwdDatos.CurrentRow.Cells("NRUCCN").Value

        If ("" & gwdDatos.CurrentRow.Cells("SACRGO").Value).ToString.Trim = "R" Then
            Me.rbtnRemitente.Checked = True
            Me.rbtnDestinatario.Checked = False
        Else
            Me.rbtnRemitente.Checked = False
            Me.rbtnDestinatario.Checked = True
        End If


        If ("" & gwdDatos.CurrentRow.Cells("SIDAVL").Value).ToString.Trim = "I" Then

            Me.rbtnIda.Checked = True
            Me.rbtnIdaVuelta.Checked = False
        Else
            Me.rbtnIda.Checked = False
            Me.rbtnIdaVuelta.Checked = True
        End If
        Me.txtKmPorRecorrer.Text = gwdDatos.CurrentRow.Cells("QKMREC").Value

        Me.txtPesoBruto.Text = gwdDatos.CurrentRow.Cells("QPSOBR").Value
        Me.txtVolumenRemision.Text = gwdDatos.CurrentRow.Cells("QVLMOR").Value
      

        If ("" & gwdDatos.CurrentRow.Cells("SMRPLG").Value).ToString.Trim = "X" Then Me.chkMercPeligrosa.Checked = True
        If ("" & gwdDatos.CurrentRow.Cells("SMRPRC").Value).ToString.Trim = "X" Then Me.chkMercPerecible.Checked = True


      

        dtpFecIniTrans.Text = gwdDatos.CurrentRow.Cells("FEMVLH_S").Value

        Me.txtObservacion.Text = gwdDatos.CurrentRow.Cells("TOBS").Value
        Me.txtConfiguracionTracto.Text = gwdDatos.CurrentRow.Cells("TCNFG1").Value
        Me.txtConfiguracionAcoplado.Text = gwdDatos.CurrentRow.Cells("TCNFG2").Value
        Me.txtOrdenEmbarcador.Text = gwdDatos.CurrentRow.Cells("NOREMB").Value


    End Sub

    Private Sub Limpiar_Controles()

       


        Me.txtNroRemision.Text = ""
        Me.txtLugar.Text = ""
        txtLugarOrigen.Text = ""
        Me.txtDirOrigen.Text = ""
        'txtUbigeoOrigen.Text = ""
        txtLugarDestino.Text = ""
        Me.txtDirDestino.Text = ""
        'txtUbigeoDestino.Text = ""
        Me.txtCantMercaderia.Text = ""
        'Me.cboUnidadMedida.Limpiar()
        txtunid_medida.Text = ""
        Me.txtGalsGasolina.Text = ""
        Me.txtGalsDiesel.Text = ""
        Me.txtNroHojaGuia.Text = ""
        Me.txtPesoMercaderia.Text = ""
        Me.txtPesoBruto.Text = ""
        Me.txtTracto.Text = ""
        Me.txtAcoplado.Text = ""
        Me.txtConductor.Text = ""
        Me.rbtnRemitente.Checked = True
        Me.rbtnDestinatario.Checked = False
        'txtmonedaFlete.Text = ""
        Me.rbtnIda.Checked = True
        Me.rbtnIdaVuelta.Checked = False
        Me.chkMercPerecible.Checked = False
        Me.chkMercPeligrosa.Checked = False
        Me.txtVolumenRemision.Text = ""
        'Me.txtValorPatrimonio.Text = ""
        'Me.cboMonedaValorPatr.Limpiar()
        Me.txtKmPorRecorrer.Text = ""
        'Me.txtCostoTramo.Text = ""
        Me.txtNomRemitente.Text = ""
        Me.txtDirRemitente.Text = ""
        Me.rbtnDNIRemit.Checked = False
        Me.rbtnRUCRemit.Checked = True
        Me.txtNroDocRemitente.Text = ""
        Me.txtNomConsignatario.Text = ""
        Me.txtDirConsignatario.Text = ""
        Me.rbtnDNIConsignatario.Checked = False
        Me.rbtnRUCConsignatario.Checked = True
        Me.txtNroDocConsignatario.Text = ""
        Me.txtObservacion.Text = ""
        Me.txtConfigTracto.Text = ""
        Me.txtConfiguracionTracto.Text = ""
        Me.txtConfiguracionAcoplado.Text = ""
        Me.txtOrdenEmbarcador.Text = ""
       
    End Sub

    Private Sub Listar_Guias_Transportista()
        Dim PlantaSel As String = ""
        If Me.Validar_Datos_Filtro = True Then Exit Sub
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
        objetoParametro.Add("PNNGUITR", IIf(Me.checkGuiaTransporte.Checked = False, 0, Me.txtGuiaTransporteFiltro.Text.Trim))
        objetoParametro.Add("PNNOPRCN", IIf(Me.checkOperacion.Checked = False, 0, Me.txtGuiaTransporteFiltro.Text.Trim))
        objetoParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.Division)
      
        PlantaSel = DevuelvePlantaSeleccionadas()
        objetoParametro.Add("PSCPLNDV", PlantaSel)
        objetoParametro.Add("PNFECINI", IIf(Me.dtpFechaInicio.Enabled = False, 0, CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double)))
        objetoParametro.Add("PNFECFIN", IIf(Me.dtpFechaFin.Enabled = False, 0, CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double)))
        objetoParametro.Add("ESTADO", 0)
        

        objetoParametro.Add("PSFSTENV", "0")
        Me.gwdDatos.DataSource = Objeto_Logica.Listar_Guia_Transportista_Mercaderia(objetoParametro)


    End Sub

    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Me.cmbCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* COMPAÑIA " & Chr(13)
        End If
        If Me.cmbDivision.Division = "" Then
            lstr_validacion += "* DIVISION" & Chr(13)
        End If
      
        If cboPlanta.CheckedItems.Count = 0 Then
            lstr_validacion += "* Seleccionar planta." & Chr(13)
        End If

        

        If Me.checkGuiaTransporte.Checked = True Then
            If Me.txtGuiaTransporteFiltro.Text.Trim.Equals("") OrElse CType(Me.txtGuiaTransporteFiltro.Text.Trim, Int64) = 0 Then
                lstr_validacion += "* GUÍA TRANSPORTE" & Chr(13)
            End If
        End If
        If Me.checkOperacion.Checked = True Then
            If Me.txtGuiaTransporteFiltro.Text.Trim.Equals("") OrElse CType(Me.txtGuiaTransporteFiltro.Text.Trim, Int64) = 0 Then
                lstr_validacion += "* OPERACION" & Chr(13)
            End If
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    
 

    Private Sub Cargar_Compania()

        Me.cmbCompania.Usuario = MainModule.USUARIO
        Me.cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
     

    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar

        Me.cmbDivision.Usuario = MainModule.USUARIO
        Me.cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        Me.cmbDivision.DivisionDefault = "T"
        Me.cmbDivision.pActualizar()
        cmbDivision_SelectionChangeCommitted(cmbDivision.obeDivision)
      



    End Sub

   
    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            Me.btnModificar.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnImprimir.Visible = False
        End If

    End Sub

    Private Function FormatearDocGuiaRemision(Tipo As String, Documento As String) As String
        Dim tamanio As String = Documento.Length
        Select Case Tipo
            Case "F"
                If tamanio <= 10 Then
                    Documento = Documento.PadLeft(10, "0")
                    Documento = Documento.Substring(0, 3) & "-" & Documento.Substring(3, 7)
                End If

            Case "E"
                If tamanio = 12 Then
                    Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4, 8)
                End If
        End Select
        Return Documento
    End Function


    Private Sub Reporte_Guia_Transportista(ByVal objEntidad As GuiaTransportista)
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptGuiaTransportista
        Dim ci As Globalization.CultureInfo
        ci = New Globalization.CultureInfo("es-ES")

        Me.Limpiar_Contenido_Reporte(objReporte)
        Try
            Dim lguia_Transporte As String = objEntidad.NGUIRM

            Dim GuiaTransportistaTxt As String = FormatearDocGuiaRemision(objEntidad.CTDGRT, objEntidad.NGUITS)

            CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = GuiaTransportistaTxt

            'CType(objReporte.ReportDefinition.ReportObjects("lblGuiaTransportista"), TextObject).Text = lguia_Transporte.Substring(0, 3) + " - " + lguia_Transporte.Substring(3)

            CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = objEntidad.TRFRGU + ", " + HelpClass.CNumero_a_Fecha(objEntidad.FGUIRM).ToString("D", ci)
            If objEntidad.TCNFVH.Substring(0, 1) <> "T" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)

                If objEntidad.NPLCAC <> "" Then
                    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                    CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
                End If

            Else
                If objEntidad.NPLCTR <> "" Then
                    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(0, objEntidad.NPLCTR.IndexOf("-"))
                    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.IndexOf("-") + 1, objEntidad.NPLCTR.LastIndexOf("-") - objEntidad.NPLCTR.IndexOf("-") - 1)
                    CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = objEntidad.NPLCTR.Substring(objEntidad.NPLCTR.LastIndexOf("-") + 1, objEntidad.NPLCTR.Length - objEntidad.NPLCTR.LastIndexOf("-") - 1)
                End If
                If objEntidad.NPLCAC <> "" Then
                    CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(0, objEntidad.NPLCAC.IndexOf("-"))
                    CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.IndexOf("-") + 1, objEntidad.NPLCAC.LastIndexOf("-") - objEntidad.NPLCAC.IndexOf("-") - 1)
                    CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = objEntidad.NPLCAC.Substring(objEntidad.NPLCAC.LastIndexOf("-") + 1, objEntidad.NPLCAC.Length - objEntidad.NPLCAC.LastIndexOf("-") - 1)
                End If
            End If
            CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = objEntidad.TCNFG1
            CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
            If objEntidad.CBRCNT <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(0, objEntidad.CBRCNT.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.IndexOf("-") + 1, objEntidad.CBRCNT.LastIndexOf("-") - objEntidad.CBRCNT.IndexOf("-") - 1)
                CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = objEntidad.CBRCNT.Substring(objEntidad.CBRCNT.LastIndexOf("-") + 1, objEntidad.CBRCNT.Length - objEntidad.CBRCNT.LastIndexOf("-") - 1)
            End If
            CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = objEntidad.TNMBRM
            CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = objEntidad.TDRCRM
            CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = objEntidad.TPDCIR + "  " + objEntidad.NRUCRM.ToString
            CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = objEntidad.TNMBCN
            CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = objEntidad.TDRCNS
            CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = objEntidad.TPDCIC & "  " & objEntidad.NRUCCN
            If objEntidad.NORSRT <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = objEntidad.NORSRT.Substring(0, objEntidad.NORSRT.IndexOf("-"))
                CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = objEntidad.NORSRT.Substring(objEntidad.NORSRT.IndexOf("-") + 1, objEntidad.NORSRT.Length - objEntidad.NORSRT.IndexOf("-") - 1)
            End If
            CType(objReporte.ReportDefinition.ReportObjects("lblOperacion"), TextObject).Text = objEntidad.NOPRCN.ToString + "           Planmt:   " + objEntidad.NPLNMT.ToString
            If objEntidad.NRGUCL_S <> "" Then
                CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = objEntidad.NRGUCL_S.Remove(0, 1)
            End If
            CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = objEntidad.TOBS
            CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = objEntidad.CUBORI_S
            CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = objEntidad.CUBDES_S
            CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = objEntidad.QMRCMC
            CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
            CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = Format(objEntidad.QPSOBR, "#,###,###,###.##")
            CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = Format(objEntidad.PMRCMC, "#,###,###,###.##")
            CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = objEntidad.SMRPLG
            CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = objEntidad.SMRPRC
            CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = objEntidad.QVLMOR
            CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = objEntidad.IVLPRT
            CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = objEntidad.QKMREC
            CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = objEntidad.TDIRDS
            CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = objEntidad.TDIROR
            CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = HelpClass.CNumero_a_Fecha(objEntidad.FEMVLH).ToString.Substring(0, 10)

            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            'MsgBox("ERROR: CONSULTE AL AREA DE SISTEMAS", MsgBoxStyle.Information, "SOLIMN")
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub Limpiar_Contenido_Reporte(ByVal objReporte As ReportClass)

        CType(objReporte.ReportDefinition.ReportObjects("lblLugarFecha"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcCamion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcTracto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcSemiremolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcRemolque"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMarcaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPlacaConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblMtcConfiguracion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoConductor"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNombreSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblLicenciaSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRegistroMtcSubContratado"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblRazonSocialDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoRemitente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDireccionDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDocumentoDestinatario"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblOrdenServicio"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMarca"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDescripcionMercaderia"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartOrigen"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDistritoDepartDestino"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblOperacion"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblGuiasCliente"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblCantidadBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblNumeroBultos"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoBruto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPesoNeto"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPeligroso"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPerecible"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblVolumen"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblValorPatrimonial"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblDistanciaVirtual"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoLlegada"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblPuntoPartida"), TextObject).Text = ""
        CType(objReporte.ReportDefinition.ReportObjects("lblFechaTranslado"), TextObject).Text = ""

    End Sub
#End Region

    Private Sub btnAdjuntarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumento.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

            '============NUEVO =============
            Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
            Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            With ofrmAdjuntarDocumento
                .pTABLE_NAME = "RZTR96"
                .pUSER_NAME = USUARIO
                .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
                .PSCDVSN = cmbDivision.Division

                .PNCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
               
                .PNCCLNT = gwdDatos.Item("CCLNT2", lint_indice).Value
                .pNGUIRM = gwdDatos.Item("NGUIRM", lint_indice).Value
                .pNMRGIM = gwdDatos.Item("NMRGIM", lint_indice).Value

                .ShowDialog()
            End With
            btnBuscar_Click(btnBuscar, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
      

        '============NUEVO =============
      

    End Sub

    Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim CodTransportista As Int32 = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
        Dim GuiaTransportista As Int64 = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value

        Auditoria(CodTransportista, GuiaTransportista)
    End Sub

    Private Sub Auditoria(ByVal CodTransportista As Int32, ByVal GuiaTransportista As Int64)
        If CodTransportista = 0 OrElse GuiaTransportista = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Dim objLogica As New GuiaTransportista_BLL
        Dim objEntidad As New GuiaTransportista
        objEntidad.CTRMNC = CodTransportista
        objEntidad.NGUIRM = GuiaTransportista
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        objEntidad = objLogica.Auditoria(objEntidad)
        Dim objfrmAuditoria As New frmAuditoria
        objfrmAuditoria.USUARIO_CREACION = objEntidad.USRCRT
        objfrmAuditoria.FECHA_CREACION = objEntidad.FCHCRT_S
        objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT_S
        objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMCR
        objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
        objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC_S
        objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC_S
        objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
        objfrmAuditoria.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgPlanruta_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dtgPlanruta.CellPainting
        'el e.columnindex son las columnas que checara para ver si se pueden combinar las celdas iguales
        ' en este caso checara las 4
        If e.ColumnIndex = 0 AndAlso e.RowIndex <> -1 Then
            Using gridBrush As Brush = New SolidBrush(Me.dtgPlanruta.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
                Using gridLinePen As Pen = New Pen(gridBrush)
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
                    If e.RowIndex < dtgPlanruta.Rows.Count() - 2 AndAlso dtgPlanruta.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1) 'e.CellBounds.Left, e.CellBounds.Bottom – 1, e.CellBounds.Right – 1, e.CellBounds.Bottom – 1)
                    End If

                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)

                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso dtgPlanruta.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If
                    e.Handled = True
                End Using
            End Using
        End If
    End Sub

    Private Sub btnExportarPlanRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPlanRuta.Click
        Try
            If dtgPlanruta.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "PLAN DE RUTA VIAJE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "PLAN DE RUTA VIAJE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "PLAN DE RUTA - VIAJE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.dtgPlanruta.DataSource, DataTable).Copy
            objDt.Columns("ORD").ColumnName = "ORD2"
            objDt.Columns.Add("ORD", Type.GetType("System.String"))

            Dim ORD As String = ""
            Dim blExiste As Boolean = False
            For i As Integer = 0 To objDt.Rows.Count - 1
                objDt.Rows(i).Item("ORD") = objDt.Rows(i).Item("ORD2")
                blExiste = False
                If i = 0 Then
                    ORD = objDt.Rows(i).Item("ORD2")
                End If

                If ORD = objDt.Rows(i).Item("ORD2") Then
                    blExiste = True
                End If
                ORD = objDt.Rows(i).Item("ORD2")
                If blExiste And i > 0 Then
                    objDt.Rows(i).Item("ORD") = ""
                End If
                objDt.AcceptChanges()
            Next
            objDt.Columns.Remove("ORD2")
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgPlanruta, objDt))
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "TCMLCL", "TOBS", "TPOREG", "CTRMNC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                    Case "ORD", "QDSTVR_STRG"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrioridadCarga.Click
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If Me.gwdDatos.Item("SESGRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim <> "" Then
            HelpClass.MsgBox("No se puede Modificar Guia Cargada Y/O Liquidada", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim objfrm As New frmAsignarPrioridadCarga
        objfrm.PSCCMPN = Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value
        objfrm.PNNGUITR = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value
        objfrm.PNCTRMNC = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
        objfrm.ShowDialog()

    End Sub

    Private Sub tsbIncidenciaEvalOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbIncidenciaEvalOp.Click
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        MostrarIncidencias()
    End Sub

    Private Sub MostrarIncidencias()
        ' Agregando el FrmRegistroIncidencias
        Dim objEntidad As New GuiaTransportista
      
        objEntidad.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value
        objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad.TCMTRT = gwdDatos.CurrentRow.Cells("TCMTRT").Value


        Dim fRegistroIncidencias As frmRegistroIncidencias = New frmRegistroIncidencias()
      
        fRegistroIncidencias._CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
        fRegistroIncidencias._NRUCTR = gwdDatos.CurrentRow.Cells("NRUCTR").Value
        fRegistroIncidencias._NGUITR = gwdDatos.CurrentRow.Cells("NGUIRM").Value


        fRegistroIncidencias.cargarIncidencia(objEntidad)
        fRegistroIncidencias.ShowDialog()
        Listar_EvaluacionOperativa()
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        Try
            'BOTON ENVIO DE GUIA CLIENTE
            If gwdDatos.RowCount = 0 Then
                Exit Sub
            End If
            If gwdDatos.CurrentRow Is Nothing Then
                MessageBox.Show("Seleccione una Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim StatusEnvio As String = gwdDatos.Item("FSTENV", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            Select Case StatusEnvio
                Case "E"
                    If MessageBox.Show("El proceso ya fue enviado sin éxito anteriormente.Debe validar su reenvío" & Chr(13) & "Está seguro de continuar con el reenvío?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                Case "S"
                    MessageBox.Show("La Guía ya se encuentra enviada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select

         

            Dim obj As New TipoDatoGeneral_BLL
            Dim lista As New List(Of TipoDatoGeneral)
            lista = obj.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "CLTENV")
            Dim ClienteValido As Boolean = False
            Dim Cliente As String = Me.gwdDatos.Item("CCLNT2", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim

            For Each Item As TipoDatoGeneral In lista
                If Item.CODIGO_TIPO = Cliente Then
                    ClienteValido = True
                    Exit For
                End If
            Next
            If Not ClienteValido Then
                MessageBox.Show("Cliente no habilitado para envío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim frm As New frmGuiaTransporteEnvioInt
            frm.PNCTRMNC = Me.gwdDatos.Item("CTRMNC", Me.gwdDatos.CurrentCellAddress.Y).Value
            frm.PNNGUITR = Me.gwdDatos.Item("NGUIRM", Me.gwdDatos.CurrentCellAddress.Y).Value
            frm.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ActualizarStusEnvioSWMilpo()
               
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ActualizarStusEnvioSWMilpo()
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        Dim Lista As List(Of GuiaTransportista)
        objetoParametro.Add("PNCTRMNC", Me.gwdDatos.Item("CTRMNC", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objetoParametro.Add("PNNGUITR", Me.gwdDatos.Item("NGUIRM", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Lista = Objeto_Logica.OBTENER_INFO_GUIA_ENVIO_CLIENTE(objetoParametro)


        If Lista.Count > 0 Then
            gwdDatos.CurrentRow.Cells("STATUS_ENVIO").Value = Lista(0).STATUS_ENVIO
            gwdDatos.CurrentRow.Cells("USUARIO_ENVIO").Value = Lista(0).USUARIO_ENVIO
            gwdDatos.CurrentRow.Cells("FSTENV").Value = Lista(0).FSTENV
            gwdDatos.CurrentRow.Cells("MSTENV").Value = Lista(0).MSTENV
            gwdDatos.CurrentRow.Cells("MSTEN2").Value = Lista(0).MSTEN2
        End If

     
    End Sub

    Private Sub ButtonSpecHeaderGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
        Try
            If gwdDatos.RowCount = 0 Then
                Exit Sub
            End If

            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_ST

            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("CTRMNC").Caption = NPOI.FormatDato("Cod. Transportista", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCMTRT").Caption = NPOI.FormatDato("Transportista", HelpClass_NPOI_ST.keyDatoTexto)


            dtResumen.Columns.Add("NGUITS").Caption = NPOI.FormatDato("Guía de Transporte", HelpClass_NPOI_ST.keyDatoTexto)

            dtResumen.Columns.Add("FGUIRM_S").Caption = NPOI.FormatDato("Fecha Guía de Transporte", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("NOPRCN").Caption = NPOI.FormatDato("Operación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLCTR").Caption = NPOI.FormatDato("Placa Tracto", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLCAC").Caption = NPOI.FormatDato("Placa Acoplado", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCNFVH").Caption = NPOI.FormatDato("Configuaración", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CBRCNT").Caption = NPOI.FormatDato("Brevete", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CBRCND").Caption = NPOI.FormatDato("Conductor", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("RUTA").Caption = NPOI.FormatDato("Origen - Destino", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("SESGRP").Caption = NPOI.FormatDato("Status Liquidación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("STATUS_ENVIO").Caption = NPOI.FormatDato("Status Envío", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("USUARIO_ENVIO").Caption = NPOI.FormatDato("Usuario Envío", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CTPOV2").Caption = NPOI.FormatDato("Tipo de Viaje", HelpClass_NPOI_ST.keyDatoTexto)

            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).Value
                Next
                dtResumen.Rows.Add(dr)
            Next

            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "Guía trasnportista carga"
            oListDtReport.Add(dtResumen.Copy)

            Dim lstrPeriodo As String = ""
            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            'Dim itemSortedList As SortedList
            ListTitulo.Add("SEGUIMIENTO GUÍA TRANSPORTISTA CARGA" & lstrPeriodo)

            NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub gwdDatos_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentDoubleClick
        If gwdDatos.Columns(e.ColumnIndex).Name = "STATUS_ENVIO" Then
            Dim Mensaje As String = "Usuario Envío:" & gwdDatos.CurrentRow.Cells("USUARIO_ENVIO").Value.ToString.Trim & Environment.NewLine()
            Mensaje = Mensaje & Environment.NewLine() & "Observaciones:" & Environment.NewLine() & ("" & gwdDatos.CurrentRow.Cells("MSTENV").Value).ToString.Trim & Environment.NewLine() & ("" & gwdDatos.CurrentRow.Cells("MSTEN2").Value).ToString.Trim
            MessageBox.Show(Mensaje, "Observaciones Envío", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try

            Me.Limpiar_Controles()

            Me.Asignacion_Datos()
            'Me.Listar_Guias_Cliente_Registradas()
            'Me.Listar_Ordenes_Compra()
            'Me.Listar_Guias_Transportista_Registradas()

            Listar_Guias_x_GuiaTRansportista()


            'Me.Listar_Recursos_Asignados()
            'Me.ListaPlanRuta()
            'Listar_EvaluacionOperativa()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function DevuelvePlantaSeleccionadas() As String
        Dim CodPlanta As String = ""
        Dim strCodPlanta As String = ""
        Dim PlantaTodos As Boolean = False
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CodPlanta = cboPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","
        Next
        If PlantaTodos = True Then
            strCodPlanta = ""
            For i As Integer = 1 To cboPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If

        Return strCodPlanta
    End Function
    

    Private Sub cmbDivision_SelectionChangeCommitted(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Me.cargarComboPlanta()
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
