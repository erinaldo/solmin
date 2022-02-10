Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario
Imports System.IO

Public Class frmDespNacional

#Region "Variables"
    Private oDocApertura As clsDocApertura
    Private oEmbarque As clsEmbarque
    Private oclsEstado As clsEstado
    Private oMoneda As clsMoneda
    Private oclsVapor As Negocio.clsVapor
    Private oclsDespachoNacional As Negocio.clsDespachoNacional
    Private oHebra As Thread
    Private oBL_MedioTransporte As New Negocio.clsMedioTransporte
    Private oclsCiaTransporte As New Negocio.clsCiaTransporte
    Private oListbeCiaTransporte As New List(Of beCiaTransporte)

    Private lstobeMoneda As List(Of beMoneda)
    Private oListGenMedioTransporte As New List(Of beMedioTransporte)

    'Private oclsCheckPointEnvioF4 As New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointEnvioLocal_F4
    Private oclsCheckPointEnvio As New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral


    Private opcMantenimiento As Mantenimiento_opcion = Mantenimiento_opcion.Neutral
    Private dtListaClienteEnvioxModCheckpoint As New DataTable
    Private intPosicion As Integer
    Private _STSCHG1 As Boolean
    Private dblEmbSelec As Double

    Public Property STSCHG1() As Boolean
        Get
            Return _STSCHG1
        End Get
        Set(ByVal value As Boolean)
            _STSCHG1 = value
        End Set
    End Property

    

#Region "Enums"
    Enum ACTUALIZACION_GRILLA
        DOCADJUNTO
    End Enum
#End Region



    'Private TabActivo As Double = 0
    'Private oTab As clsTab
    Dim oHasTabCargado As New Hashtable
#End Region




#Region "Delegados"
    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento_opcion)

        Dim TabSelect As String = TabControl1.SelectedTab.Name

        If opc = Mantenimiento_opcion.Bloquer Then
            btnModificar.Visible = False
            btnAsignarCargaDes.Visible = False
            btnServicio.Visible = False
            btnGrabar.Visible = False
            btnAgregar.Visible = False
            btnNuevo.Visible = False
            btnCancelar.Visible = False
            btnAgregarDocumento.Visible = False

            btnAnularEmbarque.Enabled = False
            btnCerrarEmb.Enabled = False
            btnReaperturar.Enabled = True
            btnExport.Enabled = True

            btnModificarItem.Visible = False
            btnEliminarItem.Visible = False
            btnAnularTarifa.Visible = False
            Exit Sub
        End If

        Select Case TabSelect
            Case "TabDatEmb"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = True
                        btnModificar.Enabled = True
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = False
                        btnAgregar.Visible = False
                        btnNuevo.Visible = True
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnCerrarEmb.Enabled = True
                        btnReaperturar.Enabled = True

                        btnExport.Enabled = True
                        btnAgregarDocumento.Visible = False
                        btnModificarItem.Visible = False
                        btnEliminarItem.Visible = False
                        btnImporDocGuia.Visible = False
                        btnAnularTarifa.Visible = True

                    Case Mantenimiento_opcion.Modificar
                        btnModificar.Visible = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = True

                        btnAnularEmbarque.Enabled = False
                        btnCerrarEmb.Enabled = False
                        btnReaperturar.Enabled = False

                        btnExport.Enabled = False

                        btnModificarItem.Visible = False
                        btnEliminarItem.Visible = False
                        btnImporDocGuia.Visible = False

                        btnAnularTarifa.Visible = False
                        btnAgregarDocumento.Visible = False
                    Case Mantenimiento_opcion.Nuevo
                        btnModificar.Enabled = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = True

                        btnAnularEmbarque.Enabled = False
                        btnCerrarEmb.Enabled = False
                        btnReaperturar.Enabled = False

                        btnExport.Enabled = False


                        btnModificarItem.Visible = False
                        btnEliminarItem.Visible = False
                        btnImporDocGuia.Visible = False
                        btnAgregarDocumento.Visible = False
                        btnAnularTarifa.Visible = False

                End Select

            Case "TabOEmb"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = False

                        btnAsignarCargaDes.Visible = True
                        btnServicio.Visible = False
                        'btnGrabar.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnCerrarEmb.Enabled = True

                        btnExport.Enabled = True
                        btnReaperturar.Enabled = True

                        btnAgregarDocumento.Visible = False
                        btnEliminarItem.Visible = True
                        btnModificarItem.Visible = True
                        btnImporDocGuia.Visible = True
                        btnAnularTarifa.Visible = False

                End Select

            Case "TabCostoSeg"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = False
                        btnAgregarDocumento.Visible = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnCerrarEmb.Enabled = True
                        btnReaperturar.Enabled = True

                        btnExport.Enabled = True


                        btnModificarItem.Visible = False
                        btnEliminarItem.Visible = False
                        btnImporDocGuia.Visible = False

                        btnAnularTarifa.Visible = False

                End Select
            Case "TabObs"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = False
                        btnAgregarDocumento.Visible = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = True
                        btnNuevo.Visible = False
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnReaperturar.Enabled = True
                        btnCerrarEmb.Enabled = True

                        btnExport.Enabled = True

                        btnEliminarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnImporDocGuia.Visible = False

                        btnAnularTarifa.Visible = False

                End Select
            Case "TabServ"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = False
                        btnAgregarDocumento.Visible = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = True
                        btnGrabar.Visible = False
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnCerrarEmb.Enabled = True
                        btnReaperturar.Enabled = True

                        btnExport.Enabled = True

                        btnEliminarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnImporDocGuia.Visible = False
                        btnAnularTarifa.Visible = False
                End Select
            Case "TabChk"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnModificar.Visible = False
                        btnAgregarDocumento.Visible = False

                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnGrabar.Visible = True
                        btnAgregar.Visible = False
                        btnNuevo.Visible = False
                        btnCancelar.Visible = False

                        btnAnularEmbarque.Enabled = True
                        btnCerrarEmb.Enabled = True
                        btnReaperturar.Enabled = True

                        btnExport.Enabled = True

                        btnEliminarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnImporDocGuia.Visible = False
                        btnAnularTarifa.Visible = False

                End Select

            Case "TabDocAdj"
                HabilitarDatosEmbarqueNacional(False)
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnGrabar.Visible = True
                        btnAgregarDocumento.Visible = True
                        btnCancelar.Visible = False
                        btnNuevo.Visible = False
                        btnAgregar.Visible = False
                        btnModificar.Visible = False
                        btnAsignarCargaDes.Visible = False
                        btnServicio.Visible = False
                        btnAnularEmbarque.Enabled = False
                        btnCerrarEmb.Enabled = False
                        btnReaperturar.Enabled = False
                        btnExport.Enabled = False
                        btnEliminarItem.Visible = False
                        btnModificarItem.Visible = False
                        btnImporDocGuia.Visible = False
                        btnAnularTarifa.Visible = False
                End Select
        End Select

    End Sub





    Private Sub frmDespNacional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim oAgenteCarga As New clsAgenteCarga
            Dim oTerminal As New clsTerminal


            'KryptonLabel14.Visible = False
            'txtNroTarifa.Visible = False
            'btnPreTarifa.Visible = False
            'btnCnTarifa.Visible = False


            txtNroTarifa.Enabled = False
            'gvOrdenesEmbDet.TabPages.Remove(TabPagDetCarga)
            oEmbarque = New clsEmbarque
            oDocApertura = New clsDocApertura

            dtgSegNacional.AutoGenerateColumns = False
            dtgServicios.AutoGenerateColumns = False
            dtgObservaciones.AutoGenerateColumns = False
            dgvCostoSegEmbNac.AutoGenerateColumns = False
            gvDetCarga.AutoGenerateColumns = False
            dtgCheckPoint.AutoGenerateColumns = False

            gvOrdEmbCarga.AutoGenerateColumns = False
            KryptonDataGridView1.AutoGenerateColumns = False
            gvDetCarga.AutoGenerateColumns = False


            Cargar_Compania()
            oListbeCiaTransporte = oclsCiaTransporte.Lista_Cia_Transporte_Todos()

            cmbCliente.pAccesoPorUsuario = True
            cmbCliente.pRequerido = True
            cmbCliente.pUsuario = HelpUtil.UserName

            CargarCombos()
            CargarLocalidadOD()
            CargarAgenteCarga()
            CargarTerminal()
            CargarCiaTran()
            CargarTipoTRansporte()
            CargarListaMoneda()
            Cargar_Tablas()
            ConfigurarDatosGrid()
            DateTimePicker1.Value = Now

            HabilitarDatosEmbarqueNacional(False)
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)

            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
            dtListaClienteEnvioxModCheckpoint = odaClienteEnvio.Listar_FomatosNotificacion_X_Cliente(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, odaClienteEnvio.Tipo_Envio_Chk_x_Local)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar_Tablas()
        oDocApertura.Crea_Lista()
        oDsSegAdu.Tables("oDtDocumento").Load(oDocApertura.Lista_Documento.CreateDataReader())
        oMoneda.Crea_Lista()
    End Sub


    Private Sub ConfigurarDatosGrid()
        Dim oDcBx As DataGridViewComboBoxColumn
        oDcBx = CType(dtgDocumentos.Columns("TDOCIN"), DataGridViewComboBoxColumn)
        oDcBx.DataSource = oDsSegAdu.Tables("oDtDocumento")
        oDcBx.DisplayMember = "TDOCIN"
        oDcBx.ValueMember = "NDOCIN"
        oDcBx.DataPropertyName = "NDOCIN"

    End Sub



    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "S"
                cmbDivision.pHabilitado = False
            End If
            cmbDivision.pActualizar()
            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            cmbPlanta.Usuario = HelpUtil.UserName
            cmbPlanta.CodigoCompania = cmbDivision.Compania
            cmbPlanta.CodigoDivision = cmbDivision.Division
            cmbPlanta.PlantaDefault = 1
            cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ctbMedioTransportes_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctbMedioTransportes.SelectionChangeCommitted
        Try
            CargarCiaTran()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim tabName As String = TabControl1.SelectedTab.Name.Trim

            Select Case tabName
                Case "TabDatEmb"
                    GrabarEmbarqueNacional()
                Case "TabCostoSeg"
                    GrabarCostoSeguimientoEmbarqueNacional()
                Case "TabObs"
                    Grabar_Observaciones()
                Case "TabServ"
                    MessageBox.Show(tabName)
                Case "TabChk"
                    Grabar_Checkpoint()
                Case "TabOEmb"
                    Grabar_Datos_Item()
                Case "TabDocAdj"
                    Grabar_DocAdj()

                Case Else

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grabar_Datos_Item()
        oclsDespachoNacional = New Negocio.clsDespachoNacional
        Dim oItem As beOrdenEmbarqueCarga
        For Each Item As DataGridViewRow In KryptonDataGridView1.Rows
            oItem = New beOrdenEmbarqueCarga
            oItem.PNNORSCI = Item.Cells("NORSCI_ITEM").Value
            oItem.PNCCLNT = Item.Cells("CCLNT_ITEM").Value
            oItem.PSNORCML = Item.Cells("NORCML_ITEM").Value
            oItem.PNNRITEM = Item.Cells("NRITOC_ITEM").Value
            oItem.PNNRPEMB = Item.Cells("NRPEMB_ITEM").Value
            oItem.PNQTPCM2 = Item.Cells("TIPO_CAMBIO").Value

            oItem.PSNUMDCR = ("" & Item.Cells("NUMDCR_ITEM").Value).ToString.Trim
            oItem.PSNGRPRV = ("" & Item.Cells("NGRPRV_ITEM").Value).ToString.Trim
            oclsDespachoNacional.Actualizar_Datos_Item_OC(oItem)
        Next
        CargarOrdenesEmbarque()
    End Sub

    Private Sub KryptonDataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles KryptonDataGridView1.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = KryptonDataGridView1.Columns(KryptonDataGridView1.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "TIPO_CAMBIO"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "NUMDCR_ITEM"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 20
                Case "NGRPRV_ITEM"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 20

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dtgSegNacional.DataSource = Nothing
            dtgServicios.DataSource = Nothing
            dtgObservaciones.Rows.Clear()
            dtgDocumentos.Rows.Clear()

            'BeOrdenEmbarqueCargaBindingSource.DataSource = Nothing

            gvOrdEmbCarga.DataSource = Nothing
            KryptonDataGridView1.DataSource = Nothing
            gvDetCarga.DataSource = Nothing


            BeCostoTotalEmbarqueNacionalBindingSource.DataSource = Nothing
            gvDetCarga.DataSource = Nothing
            dtgCheckPoint.DataSource = Nothing
            dtgCheckPoint.Rows.Clear()
            LimpiarDatosEmbarqueNacional()

            CargarGrillaBuscar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If dtgSegNacional.Rows.Count > 0 Then
                Dim oDrVw As New DataGridViewRow
                Dim FilaUltima As Int32 = 0
                oDrVw.CreateCells(dtgObservaciones)
                dtgObservaciones.Rows.Add(oDrVw)
                FilaUltima = dtgObservaciones.Rows.Count - 1
                dtgObservaciones.Rows(FilaUltima).Cells("EXISTS_OBS").Value = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If dtgSegNacional.Rows.Count > 0 Then
                opcMantenimiento = Mantenimiento_opcion.Modificar
                HabilitarBotonMantenimiento(Mantenimiento_opcion.Modificar)
                HabilitarDatosEmbarqueNacional(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnularEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularEmbarque.Click
        Try
            If dtgSegNacional.Rows.Count > 0 Then
                oclsDespachoNacional = New Negocio.clsDespachoNacional
                Dim pcclnt As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
                Dim pnorsci As Decimal = dtgSegNacional.CurrentRow.Cells("NORSCI").Value

                Dim objbeDespachoNacional As beDespachoNacional = oclsDespachoNacional.Datos_X_Embarque_Despacho(pnorsci, pcclnt)

                Select Case objbeDespachoNacional.PSSESTRG
                    Case "*"
                        MessageBox.Show("No se puede anular,el embarque se encuentra anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "C"
                        MessageBox.Show("No se puede anular,el embarque se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select

                Dim Operaciones As New StringBuilder
                Dim msg As String = ""
                If objbeDespachoNacional.PSSESTRG = "A" Then
                    Dim obrclsServicio As New clsServicio
                    Dim DatoOperacion As New DataTable
                    DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(pnorsci, pcclnt, "")
                    For index As Integer = 0 To DatoOperacion.Rows.Count - 1
                        Operaciones.Append(DatoOperacion.Rows(index)("NOPRCN"))
                        If (index < DatoOperacion.Rows.Count - 1) Then
                            Operaciones.Append(",")
                        End If
                    Next
                    If (Operaciones.ToString.Trim.Length <> 0) Then
                        msg = "No se puede eliminar,el embarque está asignado en las siguientes operaciones: " & Operaciones.ToString.Trim
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        If MessageBox.Show("Está seguro que desea anular el embarque " & pnorsci & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If oclsDespachoNacional.Anular_Despacho_Nacional(objbeDespachoNacional) Then
                                MessageBox.Show("El embarque " & pnorsci & ", se anuló correctamente.")

                                LimpiarDatosEmbarqueNacional()
                                CargarGrillaBuscar()
                                opcMantenimiento = Mantenimiento_opcion.Neutral
                                HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgObservaciones_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgObservaciones.EditingControlShowing
        Try
            Dim colName As String = dtgObservaciones.Columns(dtgObservaciones.CurrentCell.ColumnIndex).Name
            Dim Texto As New TextBox
            Select Case colName
                Case "OBSERV"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 250
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgObservaciones_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgObservaciones.CellClick
        Try
            If dtgSegNacional.Rows.Count > 0 Then

                If (e.ColumnIndex <= -1 OrElse e.RowIndex <= -1) Then
                    Exit Sub
                End If

                dtgObservaciones.EndEdit()
                Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                Dim ExisteCargaBD As Int32 = 0
                Dim ColName As String = dtgObservaciones.Columns(e.ColumnIndex).Name

                If (ColName = "DELETE_OBS") Then
                    Dim PNNORSCI As Decimal = 0
                    Dim NRITEM As Decimal = 0
                    ExisteCargaBD = dtgObservaciones.Rows(e.RowIndex).Cells("EXISTS_OBS").Value
                    If ExisteCargaBD = 1 Then
                        If MessageBox.Show("¿ Está seguro de eliminar la observación ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            PNNORSCI = obeDespachoNacional.PNNORSCI
                            NRITEM = dtgObservaciones.Rows(e.RowIndex).Cells("NRITEM_OBS").Value
                            oEmbarque.Eliminar_Observaciones_X_Item(PNNORSCI, NRITEM)
                            dtgObservaciones.Rows.RemoveAt(e.RowIndex)
                            'Actualizar_Grilla(ACTUALIZACION_GRILLA.OBSERVACION)
                        End If
                    ElseIf ExisteCargaBD = 0 Then
                        dtgObservaciones.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Carga_Informacion()
        Dim TabSelect As String = TabControl1.SelectedTab.Name

        If dtgSegNacional.Rows.Count > 0 AndAlso Not oHasTabCargado.Contains(TabSelect) Then
            Select Case TabSelect
                Case "TabDatEmb"
                    CargarDatosGrillaSeleccionada()
                Case "TabOEmb"
                    CargarOrdenesEmbarque()
                Case "TabCostoSeg"
                    CargarGrillaCostosDespachoNacional_X_Embarque()
                Case "TabObs"
                    Llenar_Observaciones()
                Case "TabServ"
                    Llenar_Servicios_X_Embarque()
                Case "TabChk"
                    Llenar_CheckPoint()
                Case "TabDocAdj"
                    Llenar_Documentos_Embarque()
            End Select
            oHasTabCargado.Add(TabSelect, TabSelect)
        End If





    End Sub

    Private Sub dtgSegNacional_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSegNacional.SelectionChanged
        Try
            If dtgSegNacional.Rows.Count > 0 Then

                Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                If obeDespachoNacional.PSSESTRG = "C" Then
                    opcMantenimiento = Mantenimiento_opcion.Bloquer
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Bloquer)
                Else
                    opcMantenimiento = Mantenimiento_opcion.Neutral
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                End If

                oHasTabCargado.Clear()
                Carga_Informacion()

                'CargarDatosGrillaSeleccionada()
                'Llenar_Observaciones()
                'Llenar_Servicios_X_Embarque()
                'Llenar_CheckPoint()
                'CargarGrillaCostosDespachoNacional_X_Embarque()
                'CargarOrdenesEmbarque()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCostoSegEmbNac_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCostoSegEmbNac.DataError
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicio.Click
        Try
            If dtgSegNacional.Rows.Count > 0 Then

                Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem

                Dim odtDatosOpAdicional As New DataTable
                Dim EstadoOperacion As String = ""
                Dim Titulo As String = ""
                Dim PNCCLNFC As Decimal = obeDespachoNacional.PNCCLNT
                Dim PNFOPRCN As Decimal = 0
                Dim PNNOPRCN As Decimal = 0
                Dim PSFLGFAC As String = ""
                Dim PNNSECFC As Decimal = 0
                Dim PNNDCFCC As Decimal = 0
                Dim PNCCLNT As Decimal = obeDespachoNacional.PNCCLNT
                Dim PNNORSCI As Decimal = obeDespachoNacional.PNNORSCI
                odtDatosOpAdicional = ObtenerDatosOperacionTipoAdicional(PNNORSCI, PNCCLNT)
                If (odtDatosOpAdicional.Rows.Count = 0) Then
                    Titulo = Ransa.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.SIL")
                    EstadoOperacion = Ransa.Controls.ServicioOperacion.Comun.ESTADO_Nuevo
                ElseIf odtDatosOpAdicional.Rows.Count > 0 Then
                    EstadoOperacion = Ransa.Controls.ServicioOperacion.Comun.ESTADO_Modificado
                    Titulo = Ransa.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO")
                    PNCCLNFC = odtDatosOpAdicional.Rows(0)("CCLNFC")
                    PNFOPRCN = odtDatosOpAdicional.Rows(0)("FOPRCN")
                    PNNOPRCN = odtDatosOpAdicional.Rows(0)("NOPRCN")
                    PSFLGFAC = odtDatosOpAdicional.Rows(0)("FLGFAC")
                    PNNSECFC = odtDatosOpAdicional.Rows(0)("NSECFC")
                    PNNDCFCC = odtDatosOpAdicional.Rows(0)("NDCFCC")
                End If

                Dim oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
                With oServicio
                    .TIPO = EstadoOperacion
                    .CCMPN = obeDespachoNacional.PSCCMPN
                    .CDVSN = obeDespachoNacional.PSCDVSN
                    .NOPRCN = PNNOPRCN
                    .NSECFC = PNNSECFC
                    .CCLNFC = PNCCLNFC
                    .CCLNT = PNCCLNT
                    .CPLNDV = obeDespachoNacional.PNCPLNDV
                    .FOPRCN = PNFOPRCN
                    .STIPPR = "O" 'otros
                    .CTPALJ = "AD" 'ADICIONAL
                    .STPODP = "0" 'NO APLICA
                    .PSUSUARIO = HelpUtil.UserName
                    .NORSCI = PNNORSCI
                    .FTIPOR = "NA"
                End With
                Dim frm As New Ransa.Controls.ServicioOperacion.UcFrmServicioAgregarSA_DS()
                frm.oServicio = oServicio
                frm.Text = Titulo
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Llenar_Servicios_X_Embarque()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If cmbCliente.pCodigo > 0 Then
                opcMantenimiento = Mantenimiento_opcion.Nuevo
                HabilitarBotonMantenimiento(Mantenimiento_opcion.Nuevo)
                LimpiarDatosEmbarqueNacional()
                ctbTipoTarifa.SelectedValue = "1"


                dtgServicios.DataSource = Nothing
                dtgObservaciones.Rows.Clear()

                gvOrdEmbCarga.DataSource = Nothing
                KryptonDataGridView1.DataSource = Nothing
                gvDetCarga.DataSource = Nothing


                BeCostoTotalEmbarqueNacionalBindingSource.DataSource = Nothing
                gvDetCarga.DataSource = Nothing
                dtgCheckPoint.DataSource = Nothing
                dtgCheckPoint.Rows.Clear()



                HabilitarDatosEmbarqueNacional(True)
                'mskEmbarque.Text = Now
                DateTimePicker1.Value = Now
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            CargarDatosGrillaSeleccionada()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmDelChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelChk.Click
        'Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        'If IsCerrado Then Exit Sub
        Try
            If dtgCheckPoint.CurrentCell Is Nothing Then
                Exit Sub
            End If
            Me.dtgCheckPoint.CurrentCell.Value = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#Region "Metodos"

#Region "Inicializar Datos"

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub CargarCiaTran()

        cboCiaTranporte.Limpiar()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCCIANV"
        oColumnas.DataPropertyName = "PNCCIANV"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMCIN"
        oColumnas.DataPropertyName = "PSTNMCIN"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        cboCiaTranporte.DataSource = FiltrarCiaTransporte()
        cboCiaTranporte.ListColumnas = oListColum
        cboCiaTranporte.Cargas()
        cboCiaTranporte.DispleyMember = "PSTNMCIN"
        cboCiaTranporte.ValueMember = "PNCCIANV"

    End Sub

    Private Sub CargarTipoTRansporte()
        Dim oListTipoTransporte As New List(Of beTipoDatoGeneral)
        'oclsDespachoNacional = New clsDespachoNacional
        Dim oTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        oListTipoTransporte = oTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("TIPOVH")

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.UcTipoTransporte.DataSource = oListTipoTransporte
        Me.UcTipoTransporte.ListColumnas = oListColum
        Me.UcTipoTransporte.Cargas()
        Me.UcTipoTransporte.DispleyMember = "PSTDSDES"
        Me.UcTipoTransporte.ValueMember = "PSCCMPRN"

    End Sub

    Private Sub CargarLocalidadOD()

        Dim objDt As List(Of beLocalidad)
        Dim obj_Logica_Localidad As New Negocio.clsLocalidad
        objDt = obj_Logica_Localidad.Listar_Localidades()


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarorigen.DataSource = objDt
        Me.cboLugarorigen.ListColumnas = oListColum
        Me.cboLugarorigen.Cargas()
        Me.cboLugarorigen.DispleyMember = "TCMLCL"
        Me.cboLugarorigen.ValueMember = "CLCLD"

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código"
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"

    End Sub


    Private Sub CargarTerminal()

        Dim objDt As List(Of beTerminal)
        Dim obj_Logica_Terminal As New Negocio.clsTerminal
        objDt = obj_Logica_Terminal.Lista_terminal_Todos


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PSCTRMAL"
        oColumnas.DataPropertyName = "PSCTRMAL"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTTRMAL"
        oColumnas.DataPropertyName = "PSTTRMAL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)



        UcTerminal.DataSource = objDt
        UcTerminal.ListColumnas = oListColum
        UcTerminal.Cargas()
        UcTerminal.DispleyMember = "PSTTRMAL"
        UcTerminal.ValueMember = "PSCTRMAL"



    End Sub


    Private Sub CargarAgenteCarga()

        Dim objDt As List(Of beAgenteCarga)
        Dim obj_Logica_AgenteCarga As New Negocio.clsAgenteCarga
        objDt = obj_Logica_AgenteCarga.Lista_AgenteCarga_Todos


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCAGNCR"
        oColumnas.DataPropertyName = "PNCAGNCR"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMAGC"
        oColumnas.DataPropertyName = "PSTNMAGC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)



        UcAgenteCarga.DataSource = objDt
        UcAgenteCarga.ListColumnas = oListColum
        UcAgenteCarga.Cargas()
        UcAgenteCarga.DispleyMember = "PSTNMAGC"
        UcAgenteCarga.ValueMember = "PNCAGNCR"


    End Sub
    Private Sub CargarCombos()

        'Cargar Combo Tipo operacion embarque
        Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        oclsEstado = New clsEstado()
        oclsDespachoNacional = New clsDespachoNacional

        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "0"
        dr("TEX") = "TODOS"

        dtTipoOperacion.Rows.InsertAt(dr, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        cboTipoOperacion.SelectedValue = "NA"
        cboTipoOperacion.Enabled = False

        'Cargar Combo Estado aduanero
        cmbEstado.DataSource = oclsEstado.Estado_Aduanero
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"


        'Cargar combo Tipo Tarifa
        ctbTipoTarifa.DataSource = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo("TIPTRF")
        ctbTipoTarifa.ValueMember = "CCMPRN"
        ctbTipoTarifa.DisplayMember = "TDSDES"
        ctbTipoTarifa.SelectedValue = "1"

        'Cargar combo medio de transporte oListGenMedioTransporte
        oListGenMedioTransporte = oBL_MedioTransporte.Lista_Medio_Transporte
        Dim oListMedioTransporte As New List(Of beMedioTransporte)
        Dim obeMedioTransporte As New beMedioTransporte
        Dim oCloneListMT As New CloneObject(Of beMedioTransporte)
        oListMedioTransporte = oCloneListMT.CloneListObject(oListGenMedioTransporte)

        'obeMedioTransporte.PNCMEDTR = -1
        'obeMedioTransporte.PSTNMMDT = "::Seleccione::"
        'oListMedioTransporte.Insert(0, obeMedioTransporte)

        ctbMedioTransportes.DataSource = oListMedioTransporte
        ctbMedioTransportes.DisplayMember = "PSTNMMDT"
        ctbMedioTransportes.ValueMember = "PNCMEDTR"
        ctbMedioTransportes.SelectedValue = CDec(1)





    End Sub

#End Region

    Private Sub CargarGrillaBuscar()
        oclsDespachoNacional = New Negocio.clsDespachoNacional
        Dim PNFECINI As Decimal = CDec(dtpInicio.Value.ToString("yyyyMMdd"))
        Dim PNFECFIN As Decimal = CDec(dtpFin.Value.ToString("yyyyMMdd"))
        Dim obeDespachoNacional As beDespachoNacional = CargarBusqueda()
        If obeDespachoNacional.PNCCLNT > 0 Then
            dtgSegNacional.DataSource = oclsDespachoNacional.Listar_Despacho_Nacional(obeDespachoNacional, PNFECINI, PNFECFIN)
            If dtgSegNacional.Rows.Count > 0 Then
                Dim objbeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                If objbeDespachoNacional.PSSESTRG.Trim = "C" Then
                    opcMantenimiento = Mantenimiento_opcion.Bloquer
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Bloquer)
                Else
                    opcMantenimiento = Mantenimiento_opcion.Neutral
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                End If
            Else
                opcMantenimiento = Mantenimiento_opcion.Neutral
                HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            End If
        Else
            MessageBox.Show("Seleccione Cliente.")
        End If
    End Sub

    Private Function ObtenerDatosOperacionTipoAdicional(ByVal NORSCI As Decimal, ByVal CCLNT As Decimal) As DataTable
        Dim odtDatosOpAdicional As New DataTable
        Dim obrServicio As New clsServicio
        odtDatosOpAdicional = obrServicio.Existe_Embarque_En_Operacion(NORSCI, CCLNT, "AD")
        Return odtDatosOpAdicional
    End Function

    Private Sub CargarOrdenesEmbarque()
        If dtgSegNacional.Rows.Count > 0 Then
            oclsDespachoNacional = New Negocio.clsDespachoNacional
            'gvDetCarga.DataSource = Nothing
            gvOrdEmbCarga.DataSource = Nothing
            KryptonDataGridView1.DataSource = Nothing
            gvDetCarga.DataSource = Nothing

            'Dim oListCarga As New List(Of beOrdenEmbarqueCarga)
            Dim pNORSCI As Decimal = dtgSegNacional.CurrentRow.Cells("NORSCI").Value
            Dim pCCLNT_R As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
            Dim dsCarga As New DataSet
            Dim dtCarga As New DataTable
            Dim dtItem As New DataTable
            Dim dtDimension As New DataTable
            dsCarga = oclsDespachoNacional.Listar_Carga_Asignada_x_Embarque(pNORSCI, pCCLNT_R)
            dtCarga = dsCarga.Tables(0).Copy
            dtItem = dsCarga.Tables(1).Copy
            dtDimension = dsCarga.Tables(2).Copy



            gvOrdEmbCarga.DataSource = dtCarga
            KryptonDataGridView1.DataSource = dtItem
            gvDetCarga.DataSource = dtDimension


            'BeOrdenEmbarqueCargaBindingSource.DataSource = oListCarga
            'BeOrdenEmbarqueCargaBindingSource.ResetBindings(False)

            'Dim dtDimension As New DataTable
            'dtDimension = oclsDespachoNacional.Listar_Dimension_Todos_x_Embarque(pNORSCI, pCCLNT_R)
            'gvDetCarga.DataSource = dtDimension


            'gvOrdEmbCarga()
            'KryptonDataGridView1()
            'gvDetCarga()

        End If
    End Sub

    Private Sub GrabarCostoSeguimientoEmbarqueNacional()

        If dtgSegNacional.Rows.Count > 0 Then

            oclsDespachoNacional = New Negocio.clsDespachoNacional
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim objbeCstTotEmbNac As beCostoTotalEmbarqueNacional

            txtEmbarque.Focus()
            BeCostoTotalEmbarqueNacionalBindingSource.EndEdit()
            For Each obeCostTotEmb As beCostoTotalEmbarqueNacional In BeCostoTotalEmbarqueNacionalBindingSource.DataSource
                If obeCostTotEmb.PNIVLORG.HasValue And obeCostTotEmb.PNCMNDA1.HasValue And obeCostTotEmb.PNIVLDOL.HasValue Then
                    For Each Item1 As beMoneda In lstobeMoneda
                        If Item1.PNCMNDA1 = obeCostTotEmb.PNCMNDA1 Then
                            objbeCstTotEmbNac = New beCostoTotalEmbarqueNacional

                            objbeCstTotEmbNac.PSNMONOC = Item1.PSTSGNMN.Trim
                            objbeCstTotEmbNac.PNNORSCI = obeDespachoNacional.PNNORSCI
                            objbeCstTotEmbNac.PNIVLORG = obeCostTotEmb.PNIVLORG.Value
                            objbeCstTotEmbNac.PNIVLDOL = obeCostTotEmb.PNIVLDOL.Value
                            objbeCstTotEmbNac.PSCODVAR = obeCostTotEmb.PSVALVAR.Trim
                            objbeCstTotEmbNac.PNCMNDA1 = obeCostTotEmb.PNCMNDA1.Value


                            oclsDespachoNacional.Guardar_Costos_Totales_Embarque("A", objbeCstTotEmbNac)
                            Exit For
                        End If
                    Next
                End If
            Next
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            CargarGrillaCostosDespachoNacional_X_Embarque()
        End If
    End Sub

    Private Sub Llenar_Observaciones()
        dtgObservaciones.Rows.Clear()
        Dim PNNORSCI As Decimal = 0
        If dtgSegNacional.Rows.Count > 0 Then
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            PNNORSCI = obeDespachoNacional.PNNORSCI
            Dim EsCerrado As Boolean = (obeDespachoNacional.PSSESTRG = "C")
            Dim oDrVw As DataGridViewRow
            Dim FILA As Int32 = 0
            Dim oListObservacion As New List(Of beObservacionCarga)
            oListObservacion = oEmbarque.Lista_Observacion_Embarque(PNNORSCI)
            'Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
            'dtgObservaciones.Columns("DELETE_OBS").Visible = Not IsCerrado
            For Each obeObservacion As beObservacionCarga In oListObservacion
                If (obeObservacion.PSTOBS.Length <> 0) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(dtgObservaciones)
                    'ADICION HABILITAR X ESTADO*************************************
                    oDrVw.ReadOnly = EsCerrado
                    '****************************************************************
                    dtgObservaciones.Rows.Add(oDrVw)
                    FILA = dtgObservaciones.Rows.Count - 1
                    dtgObservaciones.Rows(FILA).Cells("NRITEM_OBS").Value = obeObservacion.PNNRITEM
                    dtgObservaciones.Rows(FILA).Cells("FECOBS").Value = obeObservacion.PSFECOBS
                    dtgObservaciones.Rows(FILA).Cells("OBSERV").Value = obeObservacion.PSTOBS
                    dtgObservaciones.Rows(FILA).Cells("EXISTS_OBS").Value = obeObservacion.PNEXISTS
                    dtgObservaciones.Rows(FILA).Cells("DELETE_OBS").ToolTipText = "Elimina la observación seleccionada"
                End If
            Next
        End If
    End Sub

    Private Sub Grabar_Observaciones()

        If dtgSegNacional.Rows.Count > 0 Then
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim obeObservacion As beObservacionCarga
            Dim IsValido As Boolean = False
            Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            With Me.dtgObservaciones
                For intCont As Int32 = 0 To .Rows.Count - 1
                    IsValido = .Rows(intCont).Cells("FECOBS").Value IsNot Nothing
                    IsValido = IsValido AndAlso .Rows(intCont).Cells("OBSERV").Value IsNot Nothing
                    If IsValido = True Then
                        obeObservacion = New beObservacionCarga
                        obeObservacion.PNNORSCI = obeDespachoNacional.PNNORSCI
                        obeObservacion.PNTFCOBS = Format(CType(.Rows(intCont).Cells("FECOBS").Value, Date), "yyyyMMdd")
                        obeObservacion.PSTOBS = .Rows(intCont).Cells("OBSERV").Value.ToString.Trim
                        obeObservacion.PNNRITEM = .Rows(intCont).Cells("NRITEM_OBS").Value
                        oEmbarque.Actualiza_Observaciones(obeObservacion)
                    End If
                Next intCont
            End With
            Llenar_Observaciones()
        End If
    End Sub

    Private Sub GrabarEmbarqueNacional()
        oclsDespachoNacional = New Negocio.clsDespachoNacional
        Dim obeDespachoNacional As beDespachoNacional = CargarDatosDespachoNacional()
        Dim cadena As String = ValidaGrabarEmbarqueNacional(obeDespachoNacional)

        If cadena.Length > 0 Then
            MessageBox.Show(cadena.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If opcMantenimiento = Mantenimiento_opcion.Nuevo Then
            obeDespachoNacional.PNNORSCI = 0
            Dim Codigo As Integer = oclsDespachoNacional.Grabar_Despacho_Nacional(obeDespachoNacional)
            MessageBox.Show("Se creó el embarque : " + Codigo.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            CargarGrillaBuscar()

        End If

        If opcMantenimiento = Mantenimiento_opcion.Modificar Then
            If dtgSegNacional.Rows.Count > 0 Then
                Dim objbeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                obeDespachoNacional.PNNORSCI = objbeDespachoNacional.PNNORSCI

                If oclsDespachoNacional.Mant_Despacho_Nacional(obeDespachoNacional) Then
                    MessageBox.Show("Se actualizó el embarque correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarDatosEmbarqueNacional()
                    CargarDatosGrillaSeleccionada()
                    AsignarDatos_Grid()
                    opcMantenimiento = Mantenimiento_opcion.Neutral
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                End If
            End If
        End If

    End Sub

    Private Sub AsignarDatos_Grid()
        If dtgSegNacional.CurrentRow IsNot Nothing Then

            If dtgSegNacional.CurrentRow.Cells("NORSCI").Value = txtEmbarqueMan.Text.Trim Then

                If cboLugarorigen.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("ORIGEN").Value = CType(cboLugarorigen.Resultado, beLocalidad).TCMLCL
                Else
                    dtgSegNacional.CurrentRow.Cells("ORIGEN").Value = ""
                End If
                dtgSegNacional.CurrentRow.Cells("TDRCOR").Value = txtDirLocOrigen.Text.Trim
                If cboLugarDestino.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("DESTIN").Value = CType(cboLugarDestino.Resultado, beLocalidad).TCMLCL
                Else
                    dtgSegNacional.CurrentRow.Cells("DESTIN").Value = ""
                End If
                dtgSegNacional.CurrentRow.Cells("TDREN2").Value = txtDirLocDestino.Text.Trim
                dtgSegNacional.CurrentRow.Cells("NDOCEM").Value = txtNumDocEmb.Text.Trim
                dtgSegNacional.CurrentRow.Cells("REFDO1").Value = txtRefDoc.Text.Trim
                dtgSegNacional.CurrentRow.Cells("NREFCL").Value = txtRefCli.Text.Trim
                dtgSegNacional.CurrentRow.Cells("TOBERV").Value = txtMercaderia.Text.Trim
                'If UcProveedor_tab.pCodigo <> 0 Then
                '    dtgSegNacional.CurrentRow.Cells("TPRVCL").Value = UcProveedor_tab.pRazonSocial
                'Else
                '    dtgSegNacional.CurrentRow.Cells("TPRVCL").Value = ""
                'End If
                dtgSegNacional.CurrentRow.Cells("TNMMDT").Value = ctbMedioTransportes.Text.Trim
                If cboCiaTranporte.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("TNMCIN").Value = CType(cboCiaTranporte.Resultado, beCiaTransporte).PSTNMCIN
                Else
                    dtgSegNacional.CurrentRow.Cells("TNMCIN").Value = ""
                End If



                If UcTipoTransporte.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("REFNAV_DESC").Value = CType(UcTipoTransporte.Resultado, beTipoDatoGeneral).PSTDSDES
                Else
                    dtgSegNacional.CurrentRow.Cells("REFNAV_DESC").Value = ""
                End If

                'dtgSegNacional.CurrentRow.Cells("REFNAV").Value = txtNave.Text.Trim
                If UcAgenteCarga.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("PSTNMAGC_DESC").Value = CType(UcAgenteCarga.Resultado, beAgenteCarga).PSTNMAGC
                Else
                    dtgSegNacional.CurrentRow.Cells("PSTNMAGC_DESC").Value = ""
                End If
                If UcTerminal.Resultado IsNot Nothing Then
                    dtgSegNacional.CurrentRow.Cells("PSTTRMAL_DES").Value = CType(UcTerminal.Resultado, beTerminal).PSTTRMAL
                Else
                    dtgSegNacional.CurrentRow.Cells("PSTTRMAL_DES").Value = ""
                End If
                dtgSegNacional.CurrentRow.Cells("TDSDES").Value = ctbTipoTarifa.Text
                dtgSegNacional.CurrentRow.Cells("QVOLMR").Value = txtM3.Text
                dtgSegNacional.CurrentRow.Cells("QPSOAR").Value = txtKg.Text
                dtgSegNacional.CurrentRow.Cells("SESTRG").Value = txtEstado.Text
                dtgSegNacional.CurrentRow.Cells("TRECOR").Value = txtObs.Text.Trim
                dtgSegNacional.CurrentRow.Cells("PNNRTFSV").Value = txtNroTarifa.Text

                dtgSegNacional.CurrentRow.Cells("FTRTSG").Value = IIf(chkseguimiento.Checked, "X", "")

            End If
        End If

    End Sub


    Private Function ValidaGrabarEmbarqueNacional(ByVal obeDespachoNacional As beDespachoNacional) As String
        Dim cadena As String = String.Empty
        If obeDespachoNacional.PNCCLNT = 0 Then
            cadena = "Seleccione cliente "
        End If
        If obeDespachoNacional.PSTOBERV = String.Empty Then
            cadena = cadena & Chr(13) & "Ingrese mercadería"
        End If
        If obeDespachoNacional.PNCLCLOR = 0 Then
            cadena = cadena & Chr(13) & "Seleccione lugar origen"
        End If
        If obeDespachoNacional.PNCLCLDS = 0 Then
            cadena = cadena & Chr(13) & "Seleccione lugar destino"
        End If
        Return cadena
    End Function

    Private Sub CargarListaMoneda()

        oMoneda = New clsMoneda()
        oMoneda.Crea_Lista()

        lstobeMoneda = New List(Of beMoneda)
        Dim odt As DataTable = oMoneda.Lista

        Dim obeMoneda As beMoneda

        For Each dr As DataRow In odt.Rows
            obeMoneda = New beMoneda
            obeMoneda.PNCMNDA1 = dr("CMNDA1").ToString
            obeMoneda.PSTSGNMN = dr("TSGNMN").ToString
            lstobeMoneda.Add(obeMoneda)
        Next

    End Sub

    Private Sub CargarGrillaCostosDespachoNacional_X_Embarque()
        oclsDespachoNacional = New clsDespachoNacional()
        BeCostoTotalEmbarqueNacionalBindingSource.DataSource = Nothing

        If dtgSegNacional.Rows.Count > 0 Then
            Dim objbeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim EsCerrado As Boolean = (objbeDespachoNacional.PSSESTRG = "C")
            Dim lstEmbarqueNacionalConsulta As New List(Of beCostoTotalEmbarqueNacional)
            Dim PNNORSCI As Decimal = objbeDespachoNacional.PNNORSCI

            lstEmbarqueNacionalConsulta = oclsDespachoNacional.Listar_Costos_Despacho_Nacional_X_Embarque(PNNORSCI, "GASSEGN")

            BeMonedaBindingSource.DataSource = lstobeMoneda
            BeMonedaBindingSource.ResetBindings(False)

            BeCostoTotalEmbarqueNacionalBindingSource.DataSource = lstEmbarqueNacionalConsulta
            BeCostoTotalEmbarqueNacionalBindingSource.ResetBindings(False)

            HabilitarEdicionGrid(EsCerrado, dgvCostoSegEmbNac)


            For Each Item As DataGridViewRow In dgvCostoSegEmbNac.Rows
                Item.ReadOnly = EsCerrado
            Next



        End If
    End Sub

    Private Function FiltrarCiaTransporte() As List(Of beCiaTransporte)
        Dim result As New List(Of beCiaTransporte)
        For Each Item As beCiaTransporte In oListbeCiaTransporte
            If Item.PNSMETRA = ctbMedioTransportes.SelectedValue Then
                result.Add(Item)
            End If
        Next
        Return result
    End Function

    Private Function CargarDatosDespachoNacional() As beDespachoNacional
        Dim obeDespachoNacional As New Entidad.beDespachoNacional

        With obeDespachoNacional

            .PNNORSCI = Val(txtEmbarqueMan.Text.Trim)
            .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
            .PSCDVSN = cmbDivision.Division
            .PNCPLNDV = cmbPlanta.Planta
            .PSTPSRVA = cboTipoOperacion.SelectedValue.ToString.Trim

            .PSSESTRG = cmbEstado.SelectedValue.ToString.Trim

            .PNCCLNT = CDec(cmbCliente.pCodigo.ToString.Trim)
            '.PNFORSCI = CDec(Convert.ToDateTime(Me.mskEmbarque.Text.Trim).ToString("yyyyMMdd"))
            .PNFORSCI = DateTimePicker1.Value.ToString("yyyyMMdd")
            .PSNDOCEM = txtNumDocEmb.Text.Trim
            .PSTOBERV = txtMercaderia.Text.Trim
            .PSNREFCL = txtRefCli.Text.Trim
            .PSREFDO1 = txtRefDoc.Text.Trim
            '.PNCPRVCL = CDec(UcProveedor_tab.pCodigo.ToString.Trim)

            If cboCiaTranporte.Resultado IsNot Nothing Then
                .PNCCIANV = CDec(CType(cboCiaTranporte.Resultado, beCiaTransporte).PNCCIANV)
            Else
                .PNCCIANV = 0D
            End If

            'If UcNave.Resultado IsNot Nothing Then
            '    .PSCVPRCN = CType(UcNave.Resultado, beVapores).PSCVPRCN
            'Else
            '    .PSCVPRCN = String.Empty
            'End If

            If cboLugarorigen.Resultado IsNot Nothing Then
                .PNCLCLOR = CDec(CType(cboLugarorigen.Resultado, beLocalidad).CLCLD)
            Else
                .PNCLCLOR = 0D
            End If

            If cboLugarDestino.Resultado IsNot Nothing Then
                .PNCLCLDS = CDec(CType(cboLugarDestino.Resultado, beLocalidad).CLCLD)
            Else
                .PNCLCLDS = 0D
            End If


            If UcTerminal.Resultado IsNot Nothing Then
                .PSCTRMAL = CDec(CType(UcTerminal.Resultado, beTerminal).PSCTRMAL)
            Else
                .PSCTRMAL = ""
            End If

            If UcAgenteCarga.Resultado IsNot Nothing Then
                .PNCAGNCR = CDec(CType(UcAgenteCarga.Resultado, beAgenteCarga).PNCAGNCR)
            Else
                .PNCAGNCR = 0D
            End If


            .PSFLGTRF = ctbTipoTarifa.SelectedValue.ToString.Trim

            If ctbMedioTransportes.SelectedValue IsNot Nothing Then
                .PNCMEDTR = CDec(ctbMedioTransportes.SelectedValue)
            Else
                .PNCMEDTR = 0D
            End If

            .PSTDRCOR = txtDirLocOrigen.Text.Trim

            .PSTDREN2 = txtDirLocDestino.Text.Trim

            If txtM3.Text.Trim = String.Empty Then
                .PNQVOLMR = 0D
            Else
                .PNQVOLMR = CDec(txtM3.Text.Trim)
            End If

            If txtKg.Text.Trim = String.Empty Then
                .PNQPSOAR = 0D
            Else
                .PNQPSOAR = CDec(txtKg.Text.Trim)
            End If

            .PSTRECOR = txtObs.Text.Trim
            If UcTipoTransporte.Resultado IsNot Nothing Then
                .PSREFNAV = CDec(CType(UcTipoTransporte.Resultado, beTipoDatoGeneral).PSCCMPRN)
            Else
                .PSREFNAV = ""
            End If
            .PNNRTFSV = Val(txtNroTarifa.Text.Trim)
            .PSFTRTSG = IIf(chkseguimiento.Checked = True, "X", "")
        End With
        Return obeDespachoNacional
    End Function

    Private Function CargarBusqueda() As beDespachoNacional
        Dim obeDespachoNacional As New beDespachoNacional
        With obeDespachoNacional
            .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
            .PSCDVSN = cmbDivision.Division
            .PNCPLNDV = cmbPlanta.Planta
            .PNCCLNT = CDec(IIf(cmbCliente.pCodigo.ToString.Trim = String.Empty, "0", cmbCliente.pCodigo.ToString.Trim))
            .PSTPSRVA = IIf(cboTipoOperacion.SelectedValue.ToString.Trim = String.Empty, "", cboTipoOperacion.SelectedValue.ToString.Trim)
            .PSSESTRG = IIf(cmbEstado.SelectedValue.ToString.Trim = "0", "", cmbEstado.SelectedValue.ToString.Trim)
            .PNNORSCI = CDec(IIf(txtEmbarque.Text.Trim = String.Empty, "0", txtEmbarque.Text.Trim))
        End With
        Return obeDespachoNacional
    End Function

    Private Sub CargarDatosGrillaSeleccionada()
        LimpiarDatosEmbarqueNacional()

        Dim oclsDespachoNacional As New clsDespachoNacional()
        'Dim dtDespacho As New DataTable
        'Listar_Datos_Despacho_Nacional
        Dim pNorsci As Decimal = 0

        If dtgSegNacional.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim obeDespachoNacional As New beDespachoNacional
        pNorsci = dtgSegNacional.CurrentRow.Cells("NORSCI").Value
        obeDespachoNacional = oclsDespachoNacional.Listar_Datos_Despacho_Nacional(pNorsci)

        If obeDespachoNacional IsNot Nothing Then
            'Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            txtCliente.Text = obeDespachoNacional.PNCCLNT.ToString + " - " + obeDespachoNacional.PSTCMPCL
            txtEmbarqueMan.Text = obeDespachoNacional.PNNORSCI
            'DateTimePicker1.Value = HelpClass.FechaNum_a_Fecha(obeDespachoNacional.PNFORSCI)
            DateTimePicker1.Value = obeDespachoNacional.PSFORSCI
            txtEstado.Text = obeDespachoNacional.PSSESTRG
            txtNumDocEmb.Text = obeDespachoNacional.PSNDOCEM
            txtMercaderia.Text = obeDespachoNacional.PSTOBERV
            txtRefCli.Text = obeDespachoNacional.PSNREFCL
            txtRefDoc.Text = obeDespachoNacional.PSREFDO1
            txtDirLocOrigen.Text = obeDespachoNacional.PSTDRCOR
            txtDirLocDestino.Text = obeDespachoNacional.PSTDREN2
            txtM3.Text = obeDespachoNacional.PNQVOLMR.ToString
            txtKg.Text = obeDespachoNacional.PNQPSOAR.ToString
            txtObs.Text = obeDespachoNacional.PSTRECOR
            cboLugarorigen.Valor = obeDespachoNacional.PNCLCLOR
            cboLugarDestino.Valor = obeDespachoNacional.PNCLCLDS
            UcTerminal.Valor = obeDespachoNacional.PSCTRMAL
            UcAgenteCarga.Valor = obeDespachoNacional.PNCAGNCR
            ctbMedioTransportes.SelectedValue = CDec(obeDespachoNacional.PNCMEDTR)
            ctbTipoTarifa.SelectedValue = obeDespachoNacional.PSFLGTRF.Trim
            cboCiaTranporte.Valor = obeDespachoNacional.PNCCIANV
            'txtNave.Text = obeDespachoNacional.PSREFNAV
            UcTipoTransporte.Valor = obeDespachoNacional.PSREFNAV
            'UcProveedor_tab.pCodigo = obeDespachoNacional.PNCPRVCL
            txtNroTarifa.Text = obeDespachoNacional.PNNRTFSV
            chkseguimiento.Checked = False
            If obeDespachoNacional.PSFTRTSG = "X" Then
                chkseguimiento.Checked = True
            End If


        End If
    End Sub

    Private Sub LimpiarDatosEmbarqueNacional()
        txtEmbarqueMan.Clear()
        txtEstado.Clear()
        txtNumDocEmb.Clear()
        txtMercaderia.Clear()
        txtRefCli.Clear()
        txtRefDoc.Clear()
        txtDirLocOrigen.Clear()
        txtDirLocDestino.Clear()
        txtM3.Clear()
        txtKg.Clear()
        txtObs.Clear()
        'UcProveedor_tab.pClear()
        cboCiaTranporte.Limpiar()
        'UcNave.Limpiar()
        'txtNave.Clear()

        UcTipoTransporte.Limpiar()

        cboLugarorigen.Limpiar()
        cboLugarDestino.Limpiar()
        UcTerminal.Limpiar()
        UcAgenteCarga.Limpiar()
        txtCliente.Clear()
        txtNroTarifa.Clear()
    End Sub

    Private Sub Llenar_Servicios_X_Embarque()
        If dtgSegNacional.Rows.Count > 0 Then
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            If dtgServicios.Rows.Count > 0 Then
                'dtgServicios.Rows.Clear()
                dtgServicios.DataSource = Nothing
            End If
            dtgServicios.DataSource = ListaServiciosxEmbarque(obeDespachoNacional.PNCCLNT, obeDespachoNacional.PNNORSCI)
        End If
    End Sub

    Private Sub Llenar_CheckPoint()

        If dtgSegNacional.Rows.Count > 0 Then

            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            dtgCheckPoint.Rows.Clear()

            Dim oListCheckPoint As New List(Of beCheckPoint)
            Dim obrCheckPoint As New clsCheckPoint
            Dim obeParamCheckPoint As New beCheckPoint
            Dim FILA As Int32 = 0
            Dim oDrVw As DataGridViewRow
            obeParamCheckPoint.PNCCLNT = obeDespachoNacional.PNCCLNT
            obeParamCheckPoint.PNNORSCI = obeDespachoNacional.PNNORSCI
            obeParamCheckPoint.PSCCMPN = obeDespachoNacional.PSCCMPN
            obeParamCheckPoint.PSCDVSN = obeDespachoNacional.PSCDVSN
            obeParamCheckPoint.PSCEMB = "L"
            Dim EsCerrado As Boolean = (obeDespachoNacional.PSSESTRG = "C")

            oListCheckPoint = obrCheckPoint.Lista_CheckPoint_X_Embarque_X_Tipo(obeParamCheckPoint)

            For Each CheckPoint As beCheckPoint In oListCheckPoint
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(dtgCheckPoint)
                'ADICION HABILITAR X ESTADO*************************************
                oDrVw.ReadOnly = EsCerrado
                '****************************************************************
                dtgCheckPoint.Rows.Add(oDrVw)
                FILA = dtgCheckPoint.Rows.Count - 1
                dtgCheckPoint.Rows(FILA).Cells("NESTDO").Value = CheckPoint.PNNESTDO.ToString
                dtgCheckPoint.Rows(FILA).Cells("TTIPO").Value = CheckPoint.PSNOMVAR
                dtgCheckPoint.Rows(FILA).Cells("CHECKP").Value = CheckPoint.PSTDESES

                If (CheckPoint.PSFESEST.Length <> 0) Then
                    dtgCheckPoint.Rows(FILA).Cells("FESEST").Value = CheckPoint.PSFESEST
                End If
                If (CheckPoint.PSFRETES.Length <> 0) Then
                    dtgCheckPoint.Rows(FILA).Cells("FRETES").Value = CheckPoint.PSFRETES
                End If

                If CheckPoint.PSHRAEST.Length <> 0 Then
                    dtgCheckPoint.Rows(FILA).Cells("HRAEST").Value = CheckPoint.PSHRAEST
                    If CheckPoint.PSHRAEST = "00:00:00" Then
                        dtgCheckPoint.Rows(FILA).Cells("HRAEST").Value = ""
                    End If
                End If

                If CheckPoint.PSHRAEST.Length <> 0 Then
                    dtgCheckPoint.Rows(FILA).Cells("HRAREA").Value = CheckPoint.PSHRAREA
                    If CheckPoint.PSHRAREA = "00:00:00" Then
                        dtgCheckPoint.Rows(FILA).Cells("HRAREA").Value = ""
                    End If
                End If

                dtgCheckPoint.Rows(FILA).Cells("TOBS").Value = CheckPoint.PSTOBS
                dtgCheckPoint.Rows(FILA).Cells("CEMB").Value = CheckPoint.PSCEMB
                dtgCheckPoint.Rows(FILA).Cells("TABRST").Value = CheckPoint.PSTABRST
            Next
        End If
    End Sub

    Private Sub Grabar_Checkpoint()
        If dtgSegNacional.Rows.Count > 0 Then

            Dim EnviarCorreo As Boolean = False
            Dim PSREGIMEN As String = ""
            Dim CodFormato As String = ""
            '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
            oclsCheckPointEnvio = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPointNotifGeneral
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio



            odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
            CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(obeDespachoNacional.PNCCLNT)
            oclsCheckPointEnvio.CodFormato = CodFormato
            oclsCheckPointEnvio.Tipo_Envio = odaClienteEnvio.Tipo_Envio_Chk_x_Local
            If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(obeDespachoNacional.PNCCLNT) And CodFormato <> "") Then
                oclsCheckPointEnvio.ListaDatosCheckPointInicial(obeDespachoNacional.PNCCLNT, obeDespachoNacional.PNNORSCI)
                EnviarCorreo = True
            End If


            Dim obeCheckPoint As beCheckPoint

            Dim FECHA As Date
            Dim HORA As Int64 = 0
            Dim CadHora() As String
            For Each item As DataGridViewRow In dtgCheckPoint.Rows
                obeCheckPoint = New beCheckPoint
                obeCheckPoint.PNNORSCI = obeDespachoNacional.PNNORSCI
                obeCheckPoint.PNNESTDO = item.Cells("NESTDO").Value
                obeCheckPoint.PSCEMB = item.Cells("CEMB").Value.ToString.Trim
                Dim isValidTime As Boolean = False
                If Date.TryParse(item.Cells("FRETES").Value, FECHA) Then
                    obeCheckPoint.PNFRETES = FECHA.ToString("yyyyMMdd")
                    CadHora = ("" & item.Cells("HRAREA").Value).ToString.Trim.Split(":")
                    If CadHora.Length > 1 Then
                        CadHora(0) = CadHora(0).Replace("__", "00")
                        CadHora(1) = CadHora(1).Replace("__", "00")
                        CadHora(2) = CadHora(2).Replace("__", "00")
                    End If

                    If CadHora.Length > 1 AndAlso Val(CadHora(0)) <= 24 AndAlso Val(CadHora(0)) > 0 AndAlso Val(CadHora(1)) < 60 AndAlso Val(CadHora(2)) < 60 Then
                        HORA = Val(CadHora(0) & CadHora(1) & CadHora(2))
                        obeCheckPoint.PNHRAREA = HORA
                    Else
                        obeCheckPoint.PNHRAREA = 0
                    End If

                Else
                    obeCheckPoint.PNFRETES = 0
                End If

                If Date.TryParse(item.Cells("FESEST").Value, FECHA) Then
                    obeCheckPoint.PNFESEST = FECHA.ToString("yyyyMMdd")

                    CadHora = ("" & item.Cells("HRAEST").Value).ToString.Trim.Split(":")
                    If CadHora.Length > 1 Then
                        CadHora(0) = CadHora(0).Replace("__", "00")
                        CadHora(1) = CadHora(1).Replace("__", "00")
                        CadHora(2) = CadHora(2).Replace("__", "00")
                    End If

                    If CadHora.Length > 1 AndAlso Val(CadHora(0)) <= 24 AndAlso Val(CadHora(0)) > 0 AndAlso Val(CadHora(1)) < 60 AndAlso Val(CadHora(2)) < 60 Then
                        HORA = Val(CadHora(0) & CadHora(1) & CadHora(2))
                        obeCheckPoint.PNHRAEST = HORA
                    Else
                        obeCheckPoint.PNHRAEST = 0
                    End If

                Else
                    obeCheckPoint.PNFESEST = 0
                End If

                'If IsNothing(item.Cells("TOBS").Value) Then
                '    obeCheckPoint.PSTOBS = ""
                'Else
                obeCheckPoint.PSTOBS = ("" & item.Cells("TOBS").Value).ToString.Trim
                'End If

                oEmbarque.Actualiza_Checkpoint_Embarque_General(obeDespachoNacional.PSCCMPN, obeDespachoNacional.PSCDVSN, obeCheckPoint)

            Next
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            Llenar_CheckPoint()


            If (EnviarCorreo = True) Then
                'CodFormato = odaClienteEnvio.RetornaFormatoEnvio_X_Cliente(oEmbarque.pCCLNT)
                'oHasFormato.Clear()
                'oHasFormato("CODFORMATO") = CodFormato
                oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                oHebra.Start()
            End If
        End If

    End Sub

    'Private oHasFormato As New Hashtable
    Private Sub ProcesarEnvioEmail_x_Change_CHK()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim FECHA_FIN As Decimal = 0
            Dim Envio As Int32 = 0
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim obeListaCheckPointFinal As New List(Of Ransa.Servicio.EmailCheckPointAduana.beCheckPointFormato)
            oclsCheckPointEnvio.MailAccount = HelpClass.getSetting("email_account")
            oclsCheckPointEnvio.Mailpassword = HelpClass.getSetting("email_password")
            oclsCheckPointEnvio.MailAccount_Gmail = HelpClass.getSetting("email_account_gmail")
            oclsCheckPointEnvio.MailPassword_Gmail = HelpClass.getSetting("email_password_gmail")
            oclsCheckPointEnvio.Mailto_Error = HelpClass.getSetting("emailto_error")
            oclsCheckPointEnvio.CULUSA = HelpUtil.UserName
            Envio = oclsCheckPointEnvio.EnviarEmail_X_Modificacion_CheckPoint(obeDespachoNacional.PNCCLNT, obeDespachoNacional.PNNORSCI, cmbCliente.pRazonSocial)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dtgCheckPoint_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCheckPoint.CellContentDoubleClick
        If dtgSegNacional.Rows.Count > 0 Then
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            If (dtgCheckPoint.CurrentRow IsNot Nothing) Then
                Try
                    Dim columna As String = dtgCheckPoint.Columns(e.ColumnIndex).Name
                    If (columna = "CHKLOG") Then
                        Dim PSCEMB As String = dtgCheckPoint.Rows(e.RowIndex).Cells("CEMB").Value
                        Dim ofrmCheckPointLog As New frmCheckPointLog
                        If (PSCEMB = "P") Then
                            ofrmCheckPointLog.pTipoLog = frmCheckPointLog.TipoLog.EmbarquePreEmbarque
                        ElseIf PSCEMB = "A" Then
                            ofrmCheckPointLog.pTipoLog = frmCheckPointLog.TipoLog.Embarque
                        End If
                        ofrmCheckPointLog.pCCLNT = obeDespachoNacional.PNCCLNT
                        ofrmCheckPointLog.pNORSCI = obeDespachoNacional.PNNORSCI
                        ofrmCheckPointLog.pNESTDO = dtgCheckPoint.CurrentRow.Cells("NESTDO").Value
                        ofrmCheckPointLog.pCHK = dtgCheckPoint.Rows(e.RowIndex).Cells("CHECKP").Value
                        ofrmCheckPointLog.ShowDialog()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub HabilitarDatosEmbarqueNacional(ByVal op As Boolean)

        DateTimePicker1.Enabled = False
        'txtEstado.Enabled = op
        txtNumDocEmb.Enabled = op
        txtMercaderia.Enabled = op
        txtRefCli.Enabled = op
        txtRefDoc.Enabled = op
        txtDirLocOrigen.Enabled = op
        txtDirLocDestino.Enabled = op
        txtM3.Enabled = op
        txtKg.Enabled = op
        txtObs.Enabled = op
        'UcProveedor_tab.Enabled = op
        cboCiaTranporte.Enabled = op
        'UcNave.Enabled = op
        'txtNave.Enabled = op


        UcTipoTransporte.Enabled = op
        cboLugarorigen.Enabled = op
        UcAgenteCarga.Enabled = op
        UcTerminal.Enabled = op
        cboLugarDestino.Enabled = op
        ctbMedioTransportes.Enabled = op
        ctbTipoTarifa.Enabled = op
        btnPreTarifa.Enabled = op
        chkseguimiento.Enabled = op
    End Sub

#End Region

    Private Sub btnCerrarEmb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrarEmb.Click

        Try
            If dtgSegNacional.Rows.Count > 0 Then

                oclsDespachoNacional = New Negocio.clsDespachoNacional
                Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem

                Dim objbeDespachoNacional As New beDespachoNacional
                objbeDespachoNacional = oclsDespachoNacional.Datos_X_Embarque_Despacho(obeDespachoNacional.PNNORSCI, obeDespachoNacional.PNCCLNT)
                Select Case objbeDespachoNacional.PSSESTRG
                    Case "C"
                        MessageBox.Show("El embarque se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "*"
                        MessageBox.Show("El embarque se encuentra anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select

                Dim Exito As Boolean = False
                Dim PNNOPRCN As Decimal = 0
                Dim msgCierre As String = ""
                Dim msValidacion As String = ""
                Dim PSCCMPN As String = obeDespachoNacional.PSCCMPN.Trim
                Dim PSCDVSN As String = obeDespachoNacional.PSCDVSN.Trim
                Dim PNCPLNDV As Decimal = obeDespachoNacional.PNCPLNDV
                Dim CreacionOperacion As Boolean = False
                Dim DatoOperacion As New DataTable
                Dim obrclsServicio As New clsServicio
                Dim obeDatoEmbarque As New beDatosEmbarque
                Dim obrEmbarque As New clsEmbarque

                Dim ExitoOperacion As String = ""
                Dim MsgOperacion As String = ""
                Dim oCierreEmbarque As New clsCierreEmbarque
                Dim dtOperacionCierre As New DataTable


                Dim UserName As String = HelpUtil.UserName
                Dim CCLNT As Decimal = obeDespachoNacional.PNCCLNT
                Dim NORSCI As Decimal = obeDespachoNacional.PNNORSCI
                Dim TipoSeguimiento As String = obeDespachoNacional.PSFTRTSG

                Dim msg_alerta_cierre As String = "¿ Está seguro que desea cerrar el embarque ?"
                If TipoSeguimiento = "X" Then
                    msg_alerta_cierre = msg_alerta_cierre & Chr(13) & "Despacho solo seguimiento(No se generará operación)."
                End If
                'TipoSeguimiento

                If MessageBox.Show(msg_alerta_cierre, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(NORSCI, CCLNT, "GE")
                    If (DatoOperacion.Rows.Count > 0) Then
                        PNNOPRCN = DatoOperacion.Rows(0)("NOPRCN")
                    Else
                        PNNOPRCN = 0
                    End If
                    If (PNNOPRCN <> 0) Then
                        Exito = True
                        oEmbarque.Cerrar_Embarque(NORSCI)
                        msgCierre = "El embarque " & NORSCI & " fue Cerrado." & Chr(13)
                        msgCierre = msgCierre & "El embarque " & NORSCI & " está asignado a la OPERACIÓN " & PNNOPRCN
                        MessageBox.Show(msgCierre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                        Dim dblFecAlm As Double
                        dblFecAlm = Date.Now.ToString("yyyyMMdd")

                        Select Case TipoSeguimiento
                            Case ""
                                If dblFecAlm > 0 Then
                                    Dim Factor_Serv As Decimal = oclsDespachoNacional.Calcular_Factor_Servicio(NORSCI, CCLNT)
                                    Dim ofrm As New frmTarifasDeServiciosDesp
                                    ofrm.CodCompania = PSCCMPN
                                    ofrm.CodDivision = PSCDVSN
                                    ofrm.NRO_TARIFA = Val(txtNroTarifa.Text.Trim)
                                    ofrm.CodCliente = CCLNT
                                    ofrm.Embarque = NORSCI
                                    ofrm.CodClienteFacturacion = CCLNT
                                    ofrm.PlantaFacturacion = obeDespachoNacional.PNCPLNDV
                                    ofrm.FechaDeServicio = dblFecAlm
                                    ofrm.QFACTOR = Factor_Serv

                                    If ofrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                                        Dim dblTarifa As Double = ofrm.TarifaDeServicios.Cells("NRTFSV").Value
                                        Dim strTipo As String = ("" & ofrm.TarifaDeServicios.Cells("STPTRA").Value).ToString.Trim
                                        Dim strUnidad As String = ("" & ofrm.TarifaDeServicios.Cells("CUNDMD").Value).ToString.Trim
                                        Dim dblValor As Double = ofrm.TarifaDeServicios.Cells("VALCTE").Value
                                        Dim PNCCLNFC As Decimal = ofrm.CodClienteFacturacion
                                        Dim CPLNDV As Decimal = ofrm.PlantaFacturacion
                                        Dim QFACTOR As Decimal = ofrm.QFACTOR
                                        Dim CDIRSE As Decimal = ofrm.CDIRSE
                                        dtOperacionCierre = oclsDespachoNacional.Enviar_Operacion_Facturacion_Despacho(PSCCMPN, PSCDVSN, NORSCI, CCLNT, dblFecAlm, dblTarifa, strTipo, strUnidad, dblValor, PNCCLNFC, CPLNDV, QFACTOR, CDIRSE)

                                        ExitoOperacion = ("" & dtOperacionCierre.Rows(0)("WK_EXITO")).ToString.Trim
                                        MsgOperacion = ("" & dtOperacionCierre.Rows(0)("MSGIMP")).ToString.Trim

                                        If (ExitoOperacion = "1") Then
                                            Exito = True
                                            Dim mensajeCierre As String = ""
                                            oEmbarque.Cerrar_Embarque(NORSCI)
                                            Dim NumeroRevisionGenerada As String = ""
                                            NumeroRevisionGenerada = Consistenciar_Operacion_Embarque_Despacho(CCLNT, NORSCI, PSCCMPN, PSCDVSN, PNCPLNDV)
                                            mensajeCierre = "Embarque cerrado correctamente."

                                            MsgOperacion = mensajeCierre & Chr(13) & MsgOperacion
                                            MsgOperacion = MsgOperacion & Chr(13) & NumeroRevisionGenerada
                                            Llenar_Servicios_X_Embarque()

                                        End If
                                        'HelpClass.MsgBox(MsgOperacion)
                                        MessageBox.Show(MsgOperacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    Else
                                        'MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO DE MANAGEMENT FEE "
                                        MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO"
                                        MessageBox.Show(MsgOperacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        'HelpClass.MsgBox(MsgOperacion)
                                    End If
                                Else
                                    'Me.Cursor = System.Windows.Forms.Cursors.Default
                                    'HelpClass.MsgBox("No se puede enviar a facturación por no existir Fecha de servicio")
                                    MessageBox.Show("No se puede enviar a facturación por no existir Fecha de servicio".Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If

                            Case "X"

                                'Dim mensajeCierre As String = ""
                                'mensajeCierre = "Embarque cerrado correctamente."
                                oEmbarque.Cerrar_Embarque(NORSCI)
                                Llenar_Servicios_X_Embarque()
                                MessageBox.Show("Embarque cerrado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End Select

                        'If dblFecAlm > 0 Then
                        '    Dim Factor_Serv As Decimal = oclsDespachoNacional.Calcular_Factor_Servicio(NORSCI, CCLNT)
                        '    Dim ofrm As New frmTarifasDeServiciosDesp
                        '    ofrm.CodCompania = PSCCMPN
                        '    ofrm.CodDivision = PSCDVSN
                        '    ofrm.NRO_TARIFA = Val(txtNroTarifa.Text.Trim)
                        '    ofrm.CodCliente = CCLNT
                        '    ofrm.Embarque = NORSCI
                        '    ofrm.CodClienteFacturacion = CCLNT
                        '    ofrm.PlantaFacturacion = obeDespachoNacional.PNCPLNDV
                        '    ofrm.FechaDeServicio = dblFecAlm
                        '    ofrm.QFACTOR = Factor_Serv

                        '    If ofrm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                        '        Dim dblTarifa As Double = ofrm.TarifaDeServicios.Cells("NRTFSV").Value
                        '        Dim strTipo As String = ("" & ofrm.TarifaDeServicios.Cells("STPTRA").Value).ToString.Trim
                        '        Dim strUnidad As String = ("" & ofrm.TarifaDeServicios.Cells("CUNDMD").Value).ToString.Trim
                        '        Dim dblValor As Double = ofrm.TarifaDeServicios.Cells("VALCTE").Value
                        '        Dim PNCCLNFC As Decimal = ofrm.CodClienteFacturacion
                        '        Dim CPLNDV As Decimal = ofrm.PlantaFacturacion
                        '        Dim QFACTOR As Decimal = ofrm.QFACTOR
                        '        Dim CDIRSE As Decimal = ofrm.CDIRSE
                        '        dtOperacionCierre = oclsDespachoNacional.Enviar_Operacion_Facturacion_Despacho(PSCCMPN, PSCDVSN, NORSCI, CCLNT, dblFecAlm, dblTarifa, strTipo, strUnidad, dblValor, PNCCLNFC, CPLNDV, QFACTOR, CDIRSE)

                        '        ExitoOperacion = ("" & dtOperacionCierre.Rows(0)("WK_EXITO")).ToString.Trim
                        '        MsgOperacion = ("" & dtOperacionCierre.Rows(0)("MSGIMP")).ToString.Trim

                        '        If (ExitoOperacion = "1") Then
                        '            Exito = True
                        '            Dim mensajeCierre As String = ""
                        '            oEmbarque.Cerrar_Embarque(NORSCI)
                        '            Dim NumeroRevisionGenerada As String = ""
                        '            NumeroRevisionGenerada = Consistenciar_Operacion_Embarque_Despacho(CCLNT, NORSCI, PSCCMPN, PSCDVSN, PNCPLNDV)
                        '            mensajeCierre = "Embarque cerrado correctamente."


                        '            MsgOperacion = mensajeCierre & Chr(13) & MsgOperacion
                        '            MsgOperacion = MsgOperacion & Chr(13) & NumeroRevisionGenerada
                        '            Llenar_Servicios_X_Embarque()

                        '        End If
                        '        HelpClass.MsgBox(MsgOperacion)

                        '    Else
                        '        'MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO DE MANAGEMENT FEE "
                        '        MsgOperacion = "NO HA SELECCIONADO TARIFA PARA EL SERVICIO"
                        '        HelpClass.MsgBox(MsgOperacion)
                        '    End If
                        'Else
                        '    'Me.Cursor = System.Windows.Forms.Cursors.Default
                        '    HelpClass.MsgBox("No se puede enviar a facturación por no existir Fecha de servicio")
                        '    Exit Sub
                        'End If
                    End If
                End If
            End If
        Catch ex As Exception
            'Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function Consistenciar_Operacion_Embarque_Despacho(ByVal CCLNT_EMB As Decimal, ByVal NORSCI_EMB As Decimal, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCPLNDV As Decimal) As String
        Dim NumeroRevisionGenerada As String = ""
        Try
            Dim odtServiciosEmbarque As New DataTable
            odtServiciosEmbarque = ListaServiciosxEmbarque(CCLNT_EMB, NORSCI_EMB)

            Dim oServicio As New Ransa.Controls.ServicioOperacion.DATOS.clsServicio_DAL
            Dim oListOperacConsistencia As New Hashtable

            Dim PNNOPRCN As Decimal = 0
            Dim PNNSECFC As Decimal = 0
            Dim PNNSECFC_GENERAL As Decimal = 0
            Dim PNNSECFC_ADICIONAL As Decimal = 0
            Dim PNNRTFSV As Decimal = 0
            Dim PNCCLNT As Decimal = 0
            Dim Numero_Consistencia As Decimal = 0
            Dim poServiciosAtendidos As Ransa.Controls.ServicioOperacion.Servicio_BE
            Dim drServicioGeneral() As DataRow
            Dim drServicioAdicional() As DataRow
            drServicioGeneral = odtServiciosEmbarque.Select("CTPALJ='GE'")
            drServicioAdicional = odtServiciosEmbarque.Select("CTPALJ='AD'")

            If drServicioGeneral.Length > 0 Then
                PNNSECFC_GENERAL = drServicioGeneral(0)("NSECFC")
                If PNNSECFC_GENERAL = 0 Then
                    PNNSECFC_GENERAL = oServicio.ObtenerCodigoConsistencia().Rows(0)("NULCTR")
                End If
                If drServicioAdicional.Length > 0 Then
                    PNNSECFC_ADICIONAL = drServicioAdicional(0)("NSECFC")
                    If PNNSECFC_ADICIONAL = 0 Then
                        PNNSECFC_ADICIONAL = PNNSECFC_GENERAL
                    End If
                End If
            End If
            If PNNSECFC_GENERAL > 0 Then
                For Each Item As DataRow In drServicioGeneral
                    PNNOPRCN = Item("NOPRCN")
                    PNNSECFC = Item("NSECFC")
                    PNNRTFSV = Item("NRTFSV")
                    PNCCLNT = Item("CCLNT")
                    poServiciosAtendidos = New Ransa.Controls.ServicioOperacion.Servicio_BE
                    poServiciosAtendidos.CCMPN = PSCCMPN
                    poServiciosAtendidos.CDVSN = PSCDVSN

                    poServiciosAtendidos.CPLNDV = PNCPLNDV
                    poServiciosAtendidos.CCLNT = PNCCLNT
                    poServiciosAtendidos.NOPRCN = PNNOPRCN
                    poServiciosAtendidos.NRTFSV = PNNRTFSV
                    poServiciosAtendidos.NSECFC = PNNSECFC_GENERAL
                    oServicio.ActualizarServicio_Atendido(poServiciosAtendidos)
                Next
                For Each Item As DataRow In drServicioAdicional
                    PNNOPRCN = Item("NOPRCN")
                    PNNSECFC = Item("NSECFC")
                    PNNRTFSV = Item("NRTFSV")
                    PNCCLNT = Item("CCLNT")
                    poServiciosAtendidos = New Ransa.Controls.ServicioOperacion.Servicio_BE
                    poServiciosAtendidos.CCMPN = PSCCMPN
                    poServiciosAtendidos.CDVSN = PSCDVSN
                    poServiciosAtendidos.CPLNDV = PNCPLNDV
                    poServiciosAtendidos.CCLNT = PNCCLNT
                    poServiciosAtendidos.NOPRCN = PNNOPRCN
                    poServiciosAtendidos.NRTFSV = PNNRTFSV
                    poServiciosAtendidos.NSECFC = PNNSECFC_ADICIONAL
                    oServicio.ActualizarServicio_Atendido(poServiciosAtendidos)
                Next

            End If

            odtServiciosEmbarque = ListaServiciosxEmbarque(CCLNT_EMB, NORSCI_EMB)
            drServicioGeneral = odtServiciosEmbarque.Select("CTPALJ='GE'")
            drServicioAdicional = odtServiciosEmbarque.Select("CTPALJ='AD'")
            If drServicioGeneral.Length > 0 Then
                PNNSECFC_GENERAL = drServicioGeneral(0)("NSECFC")
            End If
            If drServicioAdicional.Length > 0 Then
                PNNSECFC_ADICIONAL = drServicioAdicional(0)("NSECFC")
            End If

            If PNNSECFC_GENERAL = PNNSECFC_ADICIONAL Then
                NumeroRevisionGenerada = String.Format("REVISION GENERADA N°:{0}", PNNSECFC_GENERAL)
            ElseIf PNNSECFC_GENERAL <> PNNSECFC_ADICIONAL Then
                NumeroRevisionGenerada = String.Format("REVISION GENERADA N°:{0}{1}{2}", PNNSECFC_GENERAL, ",", PNNSECFC_ADICIONAL)
            End If

        Catch ex As Exception
            NumeroRevisionGenerada = "Error en generación de n°de revisión."
        End Try
        Return NumeroRevisionGenerada
    End Function

    Private Function ListaServiciosxEmbarque(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Dim obrServicio As New clsServicio
        Dim odtServicios As New DataTable
        Dim obeServicioCns As New beServicioFacturar
        obeServicioCns.PNCCLNT = CCLNT
        obeServicioCns.PNNORSCI = NORSCI
        obeServicioCns.PSBUSQUEDA = "EMBARQUE"
        'OBTIENE EL SERVICIO GENERAL Y EL ESPECIFICO
        odtServicios = obrServicio.Lista_Servicios_X_Operacion(obeServicioCns)
        Return odtServicios
    End Function

    Enum Mantenimiento_opcion
        Neutral
        Nuevo
        Modificar
        Bloquer
    End Enum

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            If dtgSegNacional.Rows.Count > 0 Then
                Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                If obeDespachoNacional.PSSESTRG.Trim = "C" Then
                    opcMantenimiento = Mantenimiento_opcion.Bloquer
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Bloquer)
                Else
                    opcMantenimiento = Mantenimiento_opcion.Neutral
                    HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                End If
            Else
                opcMantenimiento = Mantenimiento_opcion.Neutral
                HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            End If
            Carga_Informacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCostoSegEmbNac_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCostoSegEmbNac.EditingControlShowing
        Try
            Dim colName As String = ""
            Dim Texto As New TextBox
            colName = dgvCostoSegEmbNac.Columns(dgvCostoSegEmbNac.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "PNIVLORG"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "PNIVLDOL"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-5"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuiaRemision.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmAsignarCarga_GR As New frmAsignarCarga_GR
            ofrmAsignarCarga_GR.pCCLNT = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
            ofrmAsignarCarga_GR.pCCMPN = ("" & dtgSegNacional.CurrentRow.Cells("PSCCMPN").Value).ToString.Trim
            ofrmAsignarCarga_GR.pCPLNDV = dtgSegNacional.CurrentRow.Cells("PNCPLNDV").Value
            ofrmAsignarCarga_GR.pNORSCI = dtgSegNacional.CurrentRow.Cells("NORSCI").Value

            If ofrmAsignarCarga_GR.ShowDialog = Windows.Forms.DialogResult.OK Then
                CargarOrdenesEmbarque()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportNormal.Click
        Try
            'If dtgSegNacional.Rows.Count > 0 Then
            '    Dim dr As DataRow
            '    Dim NPOI_SC As New HelpClass_NPOI_SC
            '    Dim odtExportar As New DataTable
            '    Dim MdataColumna As String = ""
            '    If dtgSegNacional.Rows.Count = 0 Then Exit Sub
            '    odtExportar.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoNumero)
            '    odtExportar.Columns.Add("FORSCI").Caption = NPOI_SC.FormatDato("Fecha", NPOI_SC.keyDatoFecha)
            '    odtExportar.Columns.Add("ORIGEN").Caption = NPOI_SC.FormatDato("Origen", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TDRCOR").Caption = NPOI_SC.FormatDato("Dir. Origen", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("DESTIN").Caption = NPOI_SC.FormatDato("Destino", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TDREN2").Caption = NPOI_SC.FormatDato("Dir. Destino", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("Doc. Embarque", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("REFDO1").Caption = NPOI_SC.FormatDato("Ref Documento", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("NREFCL").Caption = NPOI_SC.FormatDato("Ref. Cliente", NPOI_SC.keyDatoTexto)
            '    'odtExportar.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio Transporte", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TNMCIN").Caption = NPOI_SC.FormatDato("Cía. Transporte", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("REFNAV").Caption = NPOI_SC.FormatDato("Transporte", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("PSTTRMAL_DES").Caption = NPOI_SC.FormatDato("Terminal", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("PSTNMAGC_DESC").Caption = NPOI_SC.FormatDato("Agente embarcador", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TDSDES").Caption = NPOI_SC.FormatDato("Tarifa", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("QVOLMR").Caption = NPOI_SC.FormatDato("Volumen(m3)", NPOI_SC.keyDatoNumero)
            '    odtExportar.Columns.Add("QPSOAR").Caption = NPOI_SC.FormatDato("Peso(kg)", NPOI_SC.keyDatoNumero)
            '    odtExportar.Columns.Add("SESTRG").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
            '    odtExportar.Columns.Add("TRECOR").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)
            '    For Each item As DataGridViewRow In dtgSegNacional.Rows
            '        dr = odtExportar.NewRow
            '        For Each ItemCol As DataColumn In odtExportar.Columns
            '            dr(ItemCol.ColumnName) = item.Cells(ItemCol.ColumnName).Value
            '        Next
            '        odtExportar.Rows.Add(dr)
            '    Next
            '    Dim ListaDatatable As New List(Of DataTable)
            '    ListaDatatable.Add(odtExportar.Copy)
            '    Dim LisFiltros As New List(Of SortedList)
            '    Dim itemSortedList As SortedList
            '    itemSortedList = New SortedList

            '    itemSortedList.Add(itemSortedList.Count, "Compañia:|" & cmbCompania.oBeCompania.TCMPCM_DescripcionCompania)
            '    itemSortedList.Add(itemSortedList.Count, "División:|" & cmbDivision.DivisionDescripcion)
            '    itemSortedList.Add(itemSortedList.Count, "Planta:|" & cmbPlanta.DescripcionPlanta)

            '    If txtEmbarque.Text.Trim <> String.Empty Then
            '        itemSortedList.Add(itemSortedList.Count, "Embarque:|" & txtEmbarque.Text.Trim)
            '    End If

            '    LisFiltros.Add(itemSortedList)

            '    Dim ListTitulo As New List(Of String)
            '    ListTitulo.Add("Embarque Nacional")
            '    NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)
            'End If

            Dim ofrmExportar As New frmExportar
            ofrmExportar.pCCLNT = cmbCliente.pCodigo
            ofrmExportar.pCCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmExportar.pCCMPN_DESC = cmbCompania.CCMPN_Descripcion
            ofrmExportar.pTipoReporteExport = frmExportar.TipoReporte.Extendido
            ofrmExportar.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportDetalle.Click
        Try

            Dim ofrmExportar As New frmExportar
            ofrmExportar.pCCLNT = cmbCliente.pCodigo
            ofrmExportar.pCCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmExportar.pCCMPN_DESC = cmbCompania.CCMPN_Descripcion
            ofrmExportar.pTipoReporteExport = frmExportar.TipoReporte.Valorizado
            ofrmExportar.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnitemManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnitemManual.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmAsignarCarga_GR As New frmAsignaCargaManual
            ofrmAsignarCarga_GR.pCCLNT = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
            ofrmAsignarCarga_GR.pCCMPN = ("" & dtgSegNacional.CurrentRow.Cells("PSCCMPN").Value).ToString.Trim
            ofrmAsignarCarga_GR.pCPLNDV = dtgSegNacional.CurrentRow.Cells("PNCPLNDV").Value
            ofrmAsignarCarga_GR.pNORSCI = dtgSegNacional.CurrentRow.Cells("NORSCI").Value
            ofrmAsignarCarga_GR.pNRITEM = 0
            ofrmAsignarCarga_GR.pNRPEMB = 0
            ofrmAsignarCarga_GR.pNORMCL = ""


            If ofrmAsignarCarga_GR.ShowDialog = Windows.Forms.DialogResult.OK Then
                CargarOrdenesEmbarque()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarItem.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If gvOrdEmbCarga.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmAsignarCarga_GR As New frmAsignaCargaManual
            ofrmAsignarCarga_GR.pCCLNT = gvOrdEmbCarga.CurrentRow.Cells("CCLNT_OC").Value
            ofrmAsignarCarga_GR.pCCMPN = ("" & dtgSegNacional.CurrentRow.Cells("PSCCMPN").Value).ToString.Trim
            ofrmAsignarCarga_GR.pCPLNDV = dtgSegNacional.CurrentRow.Cells("PNCPLNDV").Value
            ofrmAsignarCarga_GR.pNORSCI = gvOrdEmbCarga.CurrentRow.Cells("NORSCI_OC").Value
            ofrmAsignarCarga_GR.pNRITEM = gvOrdEmbCarga.CurrentRow.Cells("NRITEM_OC").Value
            ofrmAsignarCarga_GR.pNRPEMB = gvOrdEmbCarga.CurrentRow.Cells("NRPEMB_OC").Value
            ofrmAsignarCarga_GR.pNORMCL = ("" & gvOrdEmbCarga.CurrentRow.Cells("NORCML_OC").Value).ToString.Trim



            If ofrmAsignarCarga_GR.ShowDialog = Windows.Forms.DialogResult.OK Then
                CargarOrdenesEmbarque()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub HabilitarEdicionGrid(ByVal Habilitar As Boolean, ByVal gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
        For Each Item As DataGridViewRow In gv.Rows

            Item.ReadOnly = Habilitar
        Next
    End Sub

    Private Sub btnCnTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCnTarifa.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Val(txtNroTarifa.Text.Trim) = 0 Then
                Exit Sub
            End If
            Dim ofrmDatosPreTarifa As New frmDatosPreTarifa
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            ofrmDatosPreTarifa.CodCompania = obeDespachoNacional.PSCCMPN
            ofrmDatosPreTarifa.CodDivision = obeDespachoNacional.PSCDVSN
            ofrmDatosPreTarifa.NRO_TARIFA = Val(txtNroTarifa.Text.Trim)
            ofrmDatosPreTarifa.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPreTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreTarifa.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Val(txtEmbarqueMan.Text.Trim) = 0 Then
                Exit Sub
            End If
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim DatoOperacion As New DataTable
            Dim obrclsServicio As New clsServicio
            DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(obeDespachoNacional.PNNORSCI, obeDespachoNacional.PNCCLNT, "GE")
            If (DatoOperacion.Rows.Count > 0) Then
                MessageBox.Show("No puede asignar" & Chr(13) & "El embarque ya tiene asignado una operación de cierre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim ofrm As New frmTarifasDeServiciosDesp
            ofrm.CodCompania = obeDespachoNacional.PSCCMPN
            ofrm.CodDivision = obeDespachoNacional.PSCDVSN
            ofrm.PlantaFacturacion = obeDespachoNacional.PNCPLNDV
            ofrm.CodCliente = obeDespachoNacional.PNCCLNT
            ofrm.CodClienteFacturacion = obeDespachoNacional.PNCCLNT
            ofrm.Embarque = obeDespachoNacional.PNNORSCI
            ofrm.FechaDeServicio = Now.ToString("yyyyMMdd")
            ofrm.TipoAsignacion = frmTarifasDeServiciosDesp.Tipo_Asignacion.PreTarifa
            ofrm.QFACTOR = 1


            If ofrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim dblTarifa As Double = ofrm.TarifaDeServicios.Cells("NRTFSV").Value
                txtNroTarifa.Text = dblTarifa
            Else
                txtNroTarifa.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgCheckPoint_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCheckPoint.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If dtgCheckPoint.CurrentCell Is Nothing Then
                Exit Sub
            End If
            cmtChk.Items(0).Visible = False
            cmtChk.Items(1).Visible = False

            Dim ColName As String = dtgCheckPoint.Columns(dtgCheckPoint.CurrentCell.ColumnIndex).Name
            Select Case ColName
                Case "FESEST", "FRETES"
                    cmtChk.Items(0).Visible = True
                    cmtChk.Items(1).Visible = False
                Case "HRAEST", "HRAREA"
                    cmtChk.Items(0).Visible = False
                    cmtChk.Items(1).Visible = True
                Case Else
                    cmtChk.Items(0).Visible = False
                    cmtChk.Items(1).Visible = False
            End Select
        End If
    End Sub

    Private Sub tsmDelHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelHora.Click
        Try
            If dtgCheckPoint.CurrentCell Is Nothing Then
                Exit Sub
            End If
            Me.dtgCheckPoint.CurrentCell.Value = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarItem.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim tabSeleccionado As String = gvOrdenesEmbDet.SelectedTab.Name
            If tabSeleccionado = "TabPagCarga" Then
                If gvOrdEmbCarga.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                If MessageBox.Show("Está seguro de eliminar el registro y su detalle?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    'Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
                    'oclsDespachoNacional = New Negocio.clsDespachoNacional

                    Dim pcclnt As Decimal = gvOrdEmbCarga.CurrentRow.Cells("CCLNT_OC").Value
                    Dim pnorsci As Decimal = gvOrdEmbCarga.CurrentRow.Cells("NORSCI_OC").Value
                    Dim pnritem As Decimal = gvOrdEmbCarga.CurrentRow.Cells("NRITEM_OC").Value
                    Dim pnrpemb As Decimal = gvOrdEmbCarga.CurrentRow.Cells("NRPEMB_OC").Value
                    Dim pnorcml As String = ("" & gvOrdEmbCarga.CurrentRow.Cells("NORCML_OC").Value).ToString.Trim
                    oclsDespachoNacional.Eliminar_Item_Carga_Asignada(pnorsci, pcclnt, pnorcml, pnritem, pnrpemb)

                    CargarOrdenesEmbarque()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReaperturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReaperturar.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim objbeDespachoNacional As beDespachoNacional = oclsDespachoNacional.Datos_X_Embarque_Despacho(obeDespachoNacional.PNNORSCI, obeDespachoNacional.PNCCLNT)

            Select Case objbeDespachoNacional.PSSESTRG
                Case "A"
                    MessageBox.Show("El embarque se encuentra en estado de atención.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case "*"
                    MessageBox.Show("El embarque se encuentra anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select
            Dim obrCierreEmbarque As New clsCierreEmbarque
            Dim msg As String = ""
            Dim retorno As Integer = 0
            If (MessageBox.Show("Está seguro de Reaperturar el Embarque " & obeDespachoNacional.PNNORSCI, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                retorno = obrCierreEmbarque.Reaperturar_Embarque(obeDespachoNacional.PNCCLNT, obeDespachoNacional.PNNORSCI)
                If (retorno = 1) Then
                    msg = "EMBARQUE REAPERTURADO." & Chr(13)
                    msg = msg & " Consulte nuevamente el Embarque " & obeDespachoNacional.PNNORSCI & " en el estado de Atención."
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtgSegNacional.DataSource = Nothing
                    dtgServicios.DataSource = Nothing
                    'dtgObservaciones.DataSource = Nothing
                    dtgObservaciones.Rows.Clear()
                    'BeOrdenEmbarqueCargaBindingSource.DataSource = Nothing
                    gvOrdEmbCarga.DataSource = Nothing
                    KryptonDataGridView1.DataSource = Nothing
                    gvDetCarga.DataSource = Nothing

                    BeCostoTotalEmbarqueNacionalBindingSource.DataSource = Nothing

                    dtgCheckPoint.DataSource = Nothing
                    dtgCheckPoint.Rows.Clear()
                    LimpiarDatosEmbarqueNacional()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub gvOrdEmbCarga_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvOrdEmbCarga.CellContentDoubleClick
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim colname As String = gvOrdEmbCarga.Columns(e.ColumnIndex).Name
            If colname = "DET_ITEM" Then
                Dim oFrmDetalleItem As New frmDetalleItem

                oFrmDetalleItem.pNORSCI = gvOrdEmbCarga.CurrentRow.Cells("NORSCI_OC").Value
                oFrmDetalleItem.pCCLNT = gvOrdEmbCarga.CurrentRow.Cells("CCLNT_OC").Value
                oFrmDetalleItem.pNORMCL = ("" & gvOrdEmbCarga.CurrentRow.Cells("NORCML_OC").Value).ToString.Trim
                oFrmDetalleItem.pNRITEM = gvOrdEmbCarga.CurrentRow.Cells("NRITEM_OC").Value
                oFrmDetalleItem.pNRPEMB = gvOrdEmbCarga.CurrentRow.Cells("NRPEMB_OC").Value
                oFrmDetalleItem.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImporDocGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporDocGuia.Click
        Try
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim tabSeleccionado As String = gvOrdenesEmbDet.SelectedTab.Name
            'If tabSeleccionado = "TabPagCarga" Then
            Dim pcclnt As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
            Dim pnorsci As Decimal = dtgSegNacional.CurrentRow.Cells("NORSCI").Value
            oclsDespachoNacional.Actualizar_Documento_Salida_Despacho(pnorsci, pcclnt)
            CargarOrdenesEmbarque()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnularTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularTarifa.Click
        Try
            If dtgSegNacional.Rows.Count > 0 Then
                oclsDespachoNacional = New Negocio.clsDespachoNacional
                Dim pcclnt As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
                Dim pnorsci As Decimal = dtgSegNacional.CurrentRow.Cells("NORSCI").Value


                Dim objbeDespachoNacional As beDespachoNacional = oclsDespachoNacional.Datos_X_Embarque_Despacho(pnorsci, pcclnt)

                If objbeDespachoNacional.PNNRTFSV = 0 Then
                    MessageBox.Show("No tiene tarifa asignada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Select Case objbeDespachoNacional.PSSESTRG
                    Case "*"
                        MessageBox.Show("No se puede anular tarifa,el embarque se encuentra anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case "C"
                        MessageBox.Show("No se puede anular tarifa,el embarque se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select

                Dim Operaciones As New StringBuilder
                Dim msg As String = ""
                If objbeDespachoNacional.PSSESTRG = "A" Then
                    Dim obrclsServicio As New clsServicio
                    Dim DatoOperacion As New DataTable
                    DatoOperacion = obrclsServicio.Existe_Embarque_En_Operacion(pnorsci, pcclnt, "GE")
                    For index As Integer = 0 To DatoOperacion.Rows.Count - 1
                        Operaciones.Append(DatoOperacion.Rows(index)("NOPRCN"))
                        If (index < DatoOperacion.Rows.Count - 1) Then
                            Operaciones.Append(",")
                        End If
                    Next
                    If (Operaciones.ToString.Trim.Length <> 0) Then
                        msg = "No se puede anular tarifa,el embarque está asignado en las siguientes operaciones: " & Operaciones.ToString.Trim
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        If MessageBox.Show("Está seguro que desea quitar la tarifa al embarque " & pnorsci & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            oclsDespachoNacional.Anular_Tarifa_Local(objbeDespachoNacional)
                            txtNroTarifa.Text = "0"
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DtgDocumentosCellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellClick
        Try
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then
                Exit Sub
            End If
            If dtgSegNacional.CurrentRow Is Nothing Then
                Exit Sub
            End If

            intPosicion = e.RowIndex
            Dim ColName As String = dtgDocumentos.Columns(e.ColumnIndex).Name
            Select Case ColName
                Case "UPLOAT"
                    If dtgDocumentos.Rows(e.RowIndex).Cells("NORSCI_ADJ").Value.ToString = 0 Then
                        HelpClass.MsgBox("Debe grabar antes la información para poder subir una imagen")
                        Exit Sub
                    End If
 

                    Dim CCLNT As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
                    Dim CCMPN As String = ("" & dtgSegNacional.CurrentRow.Cells("PSCCMPN").Value).ToString.Trim
                    Dim NMRGIM As Decimal = dtgDocumentos.CurrentRow.Cells("NMRGIM_DOC").Value
                    Dim TABLE_NAME As String = "RZOL53"
                    Dim USER_NAME As String = HelpUtil.UserName
                    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocEmb)
                    ofrmAdjuntarDocumentos.pPNORSCI = dtgDocumentos.CurrentRow.Cells("NORSCI_ADJ").Value
                    ofrmAdjuntarDocumentos.pNDOCIN = dtgDocumentos.CurrentRow.Cells("NDOCIN").Value
                    ofrmAdjuntarDocumentos.pNCRRDC = dtgDocumentos.CurrentRow.Cells("NCRRDC").Value
                    ofrmAdjuntarDocumentos.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
                    ofrmAdjuntarDocumentos.ShowDialog()
                    If ofrmAdjuntarDocumentos.myDialogResult = True Then
                        Llenar_Documentos_Embarque()
                    End If

                Case "DELETE_DOCADJ"

                    Dim ExisteDocBD As Int32 = 0
                    Dim obeCargaEmbarque As New beDocCargaInternacional
                    Dim obeDocAdjunto As New beDocCargaInternacional
                    ExisteDocBD = dtgDocumentos.Rows(e.RowIndex).Cells("EXISTS_DOCADJ").Value

                    If ExisteDocBD = 1 Then
                        If MessageBox.Show("¿ Está seguro de eliminar el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            obeCargaEmbarque.PNCCLNT = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
                            obeCargaEmbarque.PNNORSCI = dtgDocumentos.CurrentRow.Cells("NORSCI_ADJ").Value
                            obeCargaEmbarque.PNNDOCIN = dtgDocumentos.Rows(e.RowIndex).Cells("TDOCIN").Value
                            obeCargaEmbarque.PNNCRRDC = dtgDocumentos.Rows(e.RowIndex).Cells("NCRRDC").Value
                            oDocApertura.Borrar_Documentos_Adjunto_Item(obeCargaEmbarque)
                            dtgDocumentos.Rows.RemoveAt(e.RowIndex)
                            'Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO)
                        End If
                    ElseIf ExisteDocBD = 0 Then
                        dtgDocumentos.Rows.RemoveAt(e.RowIndex)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Llenar_Documentos_Embarque()
        dtgDocumentos.Rows.Clear()
        Dim Fila As Int32 = 0
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim oLitstbeDocCargaInternacional_BE As New List(Of beDocCargaInternacional)
        Dim obeItemDocCarga As beDocCargaInternacional
        Dim IsCerrado As Boolean = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
        oLitstbeDocCargaInternacional_BE = oDocApertura.Lista_Doc_Embarque(obeDespachoNacional.PNCCLNT, obeDespachoNacional.PNNORSCI)
        'oLitstbeDocCargaInternacional_BE = oDocApertura.Lista_Doc_Embarque(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        For intCont = 0 To oLitstbeDocCargaInternacional_BE.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(dtgDocumentos)
            'ADICION HABILITAR X ESTADO**************************************
            oDrVw.ReadOnly = IsCerrado
            '****************************************************************
            dtgDocumentos.Rows.Add(oDrVw)
            Fila = dtgDocumentos.Rows.Count - 1
            obeItemDocCarga = oLitstbeDocCargaInternacional_BE(intCont)
            dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value = obeItemDocCarga.PNNDOCIN.ToString
            dtgDocumentos.Rows(Fila).Cells("TDOCIN").ReadOnly = True
            dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value = obeItemDocCarga.PSNDOCLI
            dtgDocumentos.Rows(Fila).Cells("FECORG").Value = obeItemDocCarga.PSFCDCOR
            dtgDocumentos.Rows(Fila).Cells("FECCOP").Value = obeItemDocCarga.PSFCDCCP
            dtgDocumentos.Rows(Fila).Cells("UPLOAT").Value = "..."
            dtgDocumentos.Rows(Fila).Cells("NORSCI_ADJ").Value = obeItemDocCarga.PNNORSCI
            dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value = obeItemDocCarga.PNNCRRDC
            dtgDocumentos.Rows(Fila).Cells("NMRGIM_DOC").Value = obeItemDocCarga.PNNMRGIM
            dtgDocumentos.Rows(Fila).Cells("NDOCIN").Value = obeItemDocCarga.PNNDOCIN
            dtgDocumentos.Rows(Fila).Cells("EXISTS_DOCADJ").Value = obeItemDocCarga.PNEXISTS
            If obeItemDocCarga.PNNMRGIM > 0 Then
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.Archivo
            Else
                dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            End If
        Next
        dtgDocumentos.Columns("DELETE_DOCADJ").Visible = Not IsCerrado
        'ADICION HABILITAR X ESTADO*************************************
        Dim oDcBt As DataGridViewButtonColumn
        oDcBt = CType(dtgDocumentos.Columns("UPLOAT"), DataGridViewButtonColumn)
        If IsEmbarqueCerrado(oEmbarque.EmbarqueEstado) Then
            oDcBt.Visible = False
        Else
            oDcBt.Visible = Not Me.STSCHG1
        End If
        '****************************************************************
    End Sub

    Private Function IsEmbarqueCerrado(ByVal EstadoEmbarque As String) As Boolean
        Dim IsCerrado As Boolean = False
        IsCerrado = (EstadoEmbarque = "C")
        Return IsCerrado
    End Function

    Private Function BuscarFilaEmbarque(ByVal NORSCI As Decimal) As Int32
        Dim FilaEmb As Int32 = -1
        For Fila As Int32 = 0 To dtgSegAduanero.Rows.Count - 1
            If dtgSegAduanero.Rows(Fila).Cells("NORSCI").Value = NORSCI Then
                FilaEmb = Fila
                Exit For
            End If
        Next
        Return FilaEmb
    End Function

    Private Sub ActualizaDatoCeldaGridExt(ByVal Fila As Int32, ByVal NameColumna As String, ByVal Valor As String)
        If dtgSegAduanero.Columns(NameColumna) IsNot Nothing Then
            dtgSegAduanero.Rows(Fila).Cells(NameColumna).Value = Valor
        End If
    End Sub

    Private Sub dtgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDocumentos.CellDoubleClick

        Try
            Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            If (e.ColumnIndex < 0 Or e.RowIndex < 0) Then
                Exit Sub
            End If
            Select Case ColName
                Case "LINK"
                    Dim CCLNT As Decimal = dtgSegNacional.CurrentRow.Cells("CCLNT_R").Value
                    Dim CCMPN As String = ("" & dtgSegNacional.CurrentRow.Cells("PSCCMPN").Value).ToString.Trim
                    Dim NMRGIM As Decimal = dtgDocumentos.CurrentRow.Cells("NMRGIM_DOC").Value
                    If NMRGIM = 0 Then
                        Exit Sub
                    End If
                    Dim TABLE_NAME As String = "RZOL53"
                    Dim USER_NAME As String = HelpUtil.UserName
                    Dim ofrmAdjuntarDocumentos As New frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, frmAdjuntarDocumentos.EnumAdjunto.EmbarqueDocEmb)
                    ofrmAdjuntarDocumentos.ShowDialog()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDocumentos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDocumentos.MouseDown

        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                cmtDoc.Items(0).Visible = False
                If (dtgDocumentos.Rows.Count <= 0) Then Exit Sub
                Dim ColName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
                If ColName = "FECORG" Or ColName = "FECCOP" Then
                    cmtDoc.Items(0).Visible = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDocumentos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgDocumentos.EditingControlShowing
        Try
            Dim colName As String = dtgDocumentos.Columns(dtgDocumentos.CurrentCell.ColumnIndex).Name
            Dim Texto As New TextBox
            Select Case colName
                Case "NDOCLI"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 20
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Documentos Adjuntos"

    Private Sub btnAgregarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAgregarDocumento.Click

        Try
            Dim oDrVw As New DataGridViewRow
            Dim Fila As Int32 = 0
            oDrVw.CreateCells(dtgDocumentos)
            dtgDocumentos.Rows.Add(oDrVw)
            Fila = dtgDocumentos.Rows.Count - 1
            dtgDocumentos.Rows(Fila).Cells("TNMBAR").Value = ""
            dtgDocumentos.Rows(Fila).Cells("LINK").Value = SOLMIN_SC.My.Resources.Resources.EnBlanco
            dtgDocumentos.Rows(Fila).Cells("UPLOAT").Value = "..."
            dtgDocumentos.Rows(Fila).Cells("NORSCI_ADJ").Value = 0
            dtgDocumentos.Rows(Fila).Cells("URLARC").Value = ""
            dtgDocumentos.Rows(Fila).Cells("EXISTS_DOCADJ").Value = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Validar(ByVal pintIndice As Integer) As Boolean
        If dtgDocumentos.Rows(pintIndice).Cells("TDOCIN").Value <> Nothing Then
            Return True
        End If
        Return False
    End Function

    Private Function ValidarIngresoDocAdjunto() As String
        Dim isValido As Boolean = True
        Dim Fila As Int32 = 0
        Dim oListaDocAdjunt As New List(Of String)
        Dim DocAdjunt As String = ""
        Dim PSTDOCIN As String = ""
        Dim PSNDOCLI As String = ""
        For Fila = 0 To dtgDocumentos.Rows.Count - 1
            If Validar(Fila) Then
                PSTDOCIN = ("" & dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value).ToString.Trim
                PSNDOCLI = ("" & dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value).ToString.Trim.ToUpper
                DocAdjunt = PSTDOCIN & PSNDOCLI
                If Not oListaDocAdjunt.Contains(DocAdjunt) Then
                    oListaDocAdjunt.Add(DocAdjunt)
                Else
                    isValido = False
                    Exit For
                End If
            End If
        Next
        Return isValido
    End Function

    Private Sub GrabarFilaDocAdjunto(ByVal Fila As Int32)
        Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
        Dim Fecha As Date
        Dim IsFecha As Boolean = False
        Dim obeDocAdjuntoEmbarque As beDocCargaInternacional
        obeDocAdjuntoEmbarque = New beDocCargaInternacional
        obeDocAdjuntoEmbarque.PNNORSCI = obeDespachoNacional.PNNORSCI 'oEmbarque.pNORSCI
        obeDocAdjuntoEmbarque.PNCCLNT = obeDespachoNacional.PNCCLNT 'oEmbarque.pCCLNT
        obeDocAdjuntoEmbarque.PNNDOCIN = dtgDocumentos.Rows(Fila).Cells("TDOCIN").Value
        obeDocAdjuntoEmbarque.PSNDOCLI = ("" & dtgDocumentos.Rows(Fila).Cells("NDOCLI").Value).ToString.Trim
        obeDocAdjuntoEmbarque.PNNCRRDC = dtgDocumentos.Rows(Fila).Cells("NCRRDC").Value

        IsFecha = Date.TryParse(dtgDocumentos.Rows(Fila).Cells("FECORG").Value, Fecha)
        If IsFecha Then
            obeDocAdjuntoEmbarque.PNFECORG = Fecha.ToString("yyyyMMdd")
        Else
            obeDocAdjuntoEmbarque.PNFECORG = 0
        End If
        IsFecha = Date.TryParse(dtgDocumentos.Rows(Fila).Cells("FECCOP").Value, Fecha)
        If IsFecha Then
            obeDocAdjuntoEmbarque.PNFECCOP = Fecha.ToString("yyyyMMdd")
        Else
            obeDocAdjuntoEmbarque.PNFECCOP = 0
        End If
        oDocApertura.Actualizar_Documentos_Adjunto(obeDocAdjuntoEmbarque)


    End Sub

    Private Sub Grabar_DocAdj(Optional ByVal FilaUpdate As Int32 = -1)

        Dim Fila As Integer
        If FilaUpdate <> -1 Then
            If Validar(FilaUpdate) Then
                GrabarFilaDocAdjunto(FilaUpdate)
            End If
        Else
            For Fila = 0 To dtgDocumentos.Rows.Count - 1
                If Validar(Fila) Then
                    GrabarFilaDocAdjunto(Fila)
                End If
            Next
        End If

        If FilaUpdate = -1 Then
            dtgDocumentos.Rows.Clear()
            Llenar_Documentos_Embarque()
        End If
        'Limpiar_Informacion()
        'Cargar_Informacion_Embarque()
        'Actualizar_Grilla(ACTUALIZACION_GRILLA.DOCADJUNTO)

    End Sub

#End Region

    Private Sub Grabar_Observaciones2()
        If dtgSegNacional.Rows.Count > 0 Then
            Dim obeDespachoNacional As beDespachoNacional = dtgSegNacional.CurrentRow.DataBoundItem
            Dim obeObservacion As beObservacionCarga
            Dim IsValido As Boolean = False
            Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            With Me.dtgObservaciones
                For intCont As Int32 = 0 To .Rows.Count - 1
                    IsValido = .Rows(intCont).Cells("FECOBS").Value IsNot Nothing
                    IsValido = IsValido AndAlso .Rows(intCont).Cells("OBSERV").Value IsNot Nothing
                    If IsValido = True Then
                        obeObservacion = New beObservacionCarga
                        obeObservacion.PNNORSCI = obeDespachoNacional.PNNORSCI
                        obeObservacion.PNTFCOBS = Format(CType(.Rows(intCont).Cells("FECOBS").Value, Date), "yyyyMMdd")
                        obeObservacion.PSTOBS = .Rows(intCont).Cells("OBSERV").Value.ToString.Trim
                        obeObservacion.PNNRITEM = .Rows(intCont).Cells("NRITEM_OBS").Value
                        oEmbarque.Actualiza_Observaciones(obeObservacion)
                    End If
                Next intCont
            End With
            Llenar_Observaciones()
        End If
    End Sub





    Private Sub tsmLimpiarFechaDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLimpiarFechaDoc.Click
        Dim IsCerrado = IsEmbarqueCerrado(oEmbarque.EmbarqueEstado)
        If IsCerrado Then Exit Sub
        Me.dtgDocumentos.CurrentCell.Value = ""
    End Sub
End Class
