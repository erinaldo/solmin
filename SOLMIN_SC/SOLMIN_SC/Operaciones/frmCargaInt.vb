Imports SOLMIN_SC.Negocio
Imports System.Web
Imports SOLMIN_SC.Utilitario
Imports System.Text
'Imports Microsoft.Office.Interop

Public Class frmCargaInt
    'Private oCliente As Negocio.clsCliente
    Private oProveedor As clsProveedor
    Private bolBuscar As Boolean
    Private oPais As clsPais
    Private oEnvio As clsEnvio
    Private oCheckPoint As clsCheckPoint
    Private oPreEmbarque As clsPreEmbarque
    Private Cantida_Item As Integer
    Private NroDocEmbarque As String
    Private NroFacComercial As String
    Private oDtExcelOrigen As DataTable
    Dim oPreEmbarqueEntidad As New SOLMIN_SC.Entidad.OrdenCompra_BE


#Region "Atributos"
    Private _STSCHG1 As Boolean
    Private _STSOP11 As Boolean
    Private _STSOP22 As Boolean

    Public Property STSCHG1() As Boolean
        Get
            Return _STSCHG1
        End Get
        Set(ByVal value As Boolean)
            _STSCHG1 = value
        End Set
    End Property
    Public Property STSOP11() As Boolean
        Get
            Return _STSOP11
        End Get
        Set(ByVal value As Boolean)
            _STSOP11 = value
        End Set
    End Property
    Public Property STSOP22() As Boolean
        Get
            Return _STSOP22
        End Get
        Set(ByVal value As Boolean)
            _STSOP22 = value
        End Set
    End Property

#End Region
#Region "Metodos"
    Private Function Buscar_Maximo_Parcial_X_OC(ByVal oDt As DataTable, ByVal strOc As String) As Integer
        Dim intCont As Integer
        Dim objListaDr As DataRow()
        Dim intRetornar As Integer = 0

        objListaDr = oDt.Select("NORCML ='" & strOc.Trim & "'")
        For intCont = 0 To objListaDr.Length - 1
            If objListaDr(intCont).Item("NRPARC") > intRetornar Then
                intRetornar = objListaDr(intCont).Item("NRPARC").ToString.Trim
            End If
        Next intCont
        Return intRetornar
    End Function

    Private Sub Listar_Orden_Compra()

        Dim dblFechaOC_Final, dblFechaOC_Inicio As Double
        Dim strCliente, strProv, strTrans, strPais, strRef, strSeguimiento, strEstado, strEmbarque As String

        If Me.cmbCliente.pCodigo > 0 Then
            strCliente = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If
        If Me.chxFecha.Checked Then
            dblFechaOC_Inicio = Format(CType(Me.dtpInicio.Text, Date), "yyyyMMdd")
            dblFechaOC_Final = Format(CType(Me.dtpFin.Text, Date), "yyyyMMdd")
        Else
            dblFechaOC_Inicio = 20000101
            dblFechaOC_Final = Format(CType(Now, Date), "yyyyMMdd")
        End If
        If Me.chxOC.Checked Then
            txtOC.Text = Me.txtOC.Text.Trim
        Else
            txtOC.Text = ""
        End If
        If Me.chxReq.Checked Then
            strRef = Me.txtReq.Text.Trim
        Else
            strRef = ""
        End If
        If cmbProveedor.SelectedValue = 0 Then
            strProv = ""
        Else
            strProv = cmbProveedor.SelectedValue
        End If
        If cmbTransporte.SelectedValue = 0 Then
            strTrans = ""
        Else
            strTrans = cmbTransporte.SelectedValue
        End If
        If cmbPaisOrg.SelectedValue = 0 Then
            strPais = ""
        Else
            strPais = cmbPaisOrg.SelectedValue
        End If
        If cmbSeguimiento.SelectedValue = "P" Then
            strSeguimiento = 0
        ElseIf cmbSeguimiento.SelectedValue = "E" Then
            strSeguimiento = -1
        Else
            strSeguimiento = ""
        End If
        If IsNothing(cmbEstadoEmbarcado.SelectedValue) Then
            strEstado = ""
        Else
            strEstado = cmbEstadoEmbarcado.SelectedValue
        End If
        If chxEmb.Checked Then
            strEmbarque = txtEmbarqueBusqueda.Text
        Else
            strEmbarque = ""
        End If
        oPreEmbarque.Lista_Checkpoint_Item_OC_X_Cliente(strCliente)
        If Me.rbOC.Checked Then
            If strSeguimiento.Equals("0") Or strSeguimiento.Equals("") Then
                oDtExcelOrigen = oPreEmbarque.Listar_Seguimiento_Internacional_Excel("O", strCliente, strProv, dblFechaOC_Inicio, dblFechaOC_Final, txtOC.Text, strTrans, strPais, strRef, strSeguimiento, strEmbarque, strEstado)
            Else
                oDtExcelOrigen = oPreEmbarque.Listar_Seguimiento_Internacional_Excel("E", strCliente, strProv, dblFechaOC_Inicio, dblFechaOC_Final, txtOC.Text, strTrans, strPais, strRef, strSeguimiento, strEmbarque, strEstado)
            End If
        Else
            oDtExcelOrigen = oPreEmbarque.Listar_Seguimiento_Internacional_Excel("E", strCliente, strProv, dblFechaOC_Inicio, dblFechaOC_Final, txtOC.Text, strTrans, strPais, strRef, strSeguimiento, strEmbarque, strEstado)
        End If
        dtgOC_X_Item.AutoGenerateColumns = False
        dtgOC_X_Item.DataSource = oDtExcelOrigen


    End Sub

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer

        chxOC.Focus()
        For intCont = 0 To dtgOC_X_Item.RowCount - 1
            dtgOC_X_Item.Rows(intCont).Cells("VALIDAR").Value = blnEstado
        Next intCont
        dtgOC_X_Item.Focus()
    End Sub

    Private Function Existe_Check() As Integer
        Dim Cont As Integer = 0

        For intCont As Integer = 0 To Me.dtgOC_X_Item.Rows.Count - 1
            If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                Cont += 1
            End If
        Next
        Return Cont
    End Function


    Private Sub Cargar_Checkpoint_X_Preembarque(ByVal dblPreembarque As Double)
        Dim oDt As DataTable
        Dim intCont, intReg, intConts As Integer
        Llenar_CheckPoint_X_Cliente()
        oDt = oPreEmbarque.Buscar_OC_Item_x_Preembarque(dblPreembarque)
        If oDt.Rows.Count > 0 Then
            intReg = 0
            For intCont = 0 To dtgSeguimiento_OC.RowCount - 1
                With oDt
                    intReg = oDt.Rows.Count
                    For intConts = intReg - 1 To 0 Step -1
                        If Me.dtgSeguimiento_OC.Rows(intCont).Cells(3).Value.ToString.Trim = oDt.Rows(intConts).Item("NESTDO").ToString.Trim Then
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(0).Value = .Rows(intConts).Item("NRPEMB").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(1).Value = .Rows(intConts).Item("NORCML").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(2).Value = .Rows(intConts).Item("NRITOC").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(3).Value = .Rows(intConts).Item("NESTDO").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(8).Value = .Rows(intConts).Item("DFECEST").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(9).Value = .Rows(intConts).Item("DFECREA").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(10).Value = .Rows(intConts).Item("TOBS").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(11).Value = .Rows(intConts).Item("NSEPRE").ToString.Trim
                            Me.dtgSeguimiento_OC.Rows(intCont).Cells(12).Value = .Rows(intConts).Item("MESTDO").ToString.Trim
                            oDt.Rows.RemoveAt(intConts)
                            Exit For
                        End If
                    Next
                End With
            Next intCont
        End If
    End Sub

    Private Sub Eliminar_OC_Item()
        Dim intCont As Integer
        Dim intRep As Integer
        Dim lobjSql As New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
        If Existe_Check() > 0 Then
            If Me.cmbCliente.pCodigo = 0 Then
                Exit Sub
            End If
            If HelpClass.RspMsgBox("Está seguro de eliminar el PreEmbarque y todos sus datos?") = Windows.Forms.DialogResult.Yes Then
                intRep = dtgOC_X_Item.Rows.Count
                For intCont = intRep - 1 To 0 Step -1
                    If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                        oPreEmbarque.Ultimo_Checkpoint(dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value)
                        If oPreEmbarque.Tipo_CheckPoint = "P" Or oPreEmbarque.Tipo_CheckPoint = "" Then
                            oPreEmbarque.Preembarque = dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value
                            oPreEmbarque.Cliente = Me.cmbCliente.pCodigo
                            oPreEmbarque.Elimina_PreEmbarque()
                            dtgOC_X_Item.Rows.RemoveAt(intCont)
                        End If
                    End If
                Next intCont
            End If
        Else
            HelpClass.MsgBox("Tiene que seleccionar al menos un Item para que pueda usar esta opción")
        End If

    End Sub

    Private Sub llenar_Tab(ByVal intRow As Integer)
        oPreEmbarque.Preembarque = dtgOC_X_Item.Rows(intRow).Cells("NRPEMB_1").Value

        '-------------------------------------------------------------------------------------
        oPreEmbarqueEntidad.PSNORCML = dtgOC_X_Item.Rows(intRow).Cells("NORCML_1").Value.ToString.Trim
        oPreEmbarqueEntidad.PNNRITOC = dtgOC_X_Item.Rows(intRow).Cells("NRITOC_1").Value.ToString.Trim
        oPreEmbarqueEntidad.PNNRPEMB = dtgOC_X_Item.Rows(intRow).Cells("NRPEMB_1").Value.ToString.Trim
        If dtgOC_X_Item.Rows(intRow).Cells("FMPIME").Value <> "" Then
            oPreEmbarqueEntidad.PNFMPIME = HelpClassUtility.CFecha_a_Numero8Digitos(dtgOC_X_Item.Rows(intRow).Cells("FMPIME").Value)
        Else
            oPreEmbarqueEntidad.PNFMPIME = 0
        End If
        If dtgOC_X_Item.Rows(intRow).Cells("FMPDME").Value <> "" Then
            oPreEmbarqueEntidad.PNFMPDME = HelpClassUtility.CFecha_a_Numero8Digitos(dtgOC_X_Item.Rows(intRow).Cells("FMPDME").Value)
        Else
            oPreEmbarqueEntidad.PNFMPDME = 0
        End If
        '-------------------------------------------------------------------------------------

        'Limpiar_Fechas()
        Cargar_Checkpoint_X_Preembarque(oPreEmbarque.Preembarque)
        Llenar_Observaciones()

        Listar_Item(intRow)
        Llenar_Fechas_Estimadas()
        HabilitarTabs()

    End Sub

    Private Sub llenar_Tab()
        'Limpiar_Fechas()
        Cargar_Checkpoint_X_Preembarque(oPreEmbarque.Preembarque)
        Llenar_Observaciones()
        Llenar_Fechas_Estimadas()
        HabilitarTabs()
    End Sub

    Private Sub Listar_Item(ByVal intRow As Integer)

        txtOrdenCompra.Text = dtgOC_X_Item.Rows(intRow).Cells("NORCML_1").Value.ToString.Trim
        txtSubItem.Text = dtgOC_X_Item.Rows(intRow).Cells("SBITOC").Value.ToString.Trim


        txtItem.Text = dtgOC_X_Item.Rows(intRow).Cells("NRITOC_1").Value.ToString.Trim
        Dim NORSCI As String = dtgOC_X_Item.Rows(intRow).Cells("NORSCI").Value.ToString.Trim
        If NORSCI <> "0" Then
            txtEmbarque.Text = dtgOC_X_Item.Rows(intRow).Cells("NORSCI").Value.ToString.Trim
        Else
            txtEmbarque.Text = ""
        End If

        txtMoneda.Text = dtgOC_X_Item.Rows(intRow).Cells("NMONOC").Value.ToString.Trim
        txtDescripcion.Text = dtgOC_X_Item.Rows(intRow).Cells("TDITES").Value.ToString.Trim
        txtFecha_OC.Text = dtgOC_X_Item.Rows(intRow).Cells("FORCML").Value.ToString.Trim
        txtParcial.Text = dtgOC_X_Item.Rows(intRow).Cells("NRPARC").Value.ToString.Trim
        txtIncoterm.Text = dtgOC_X_Item.Rows(intRow).Cells("TTINTC").Value.ToString.Trim
        txtCantidad_Total.Text = dtgOC_X_Item.Rows(intRow).Cells("QCNTIT").Value.ToString.Trim
        txtCantidad_Pendiente.Text = dtgOC_X_Item.Rows(intRow).Cells("QCNPED").Value.ToString.Trim

        txtCantidad.Text = dtgOC_X_Item.Rows(intRow).Cells("QRLCSC").Value.ToString.Trim
        Cantida_Item = dtgOC_X_Item.Rows(intRow).Cells("QRLCSC").Value
        txtNroDocEmbarque.Text = dtgOC_X_Item.Rows(intRow).Cells("NDOCEM").Value.ToString().Trim()
        NroDocEmbarque = dtgOC_X_Item.Rows(intRow).Cells("NDOCEM").Value.ToString().Trim()
        txtNroFacComercial.Text = dtgOC_X_Item.Rows(intRow).Cells("NFCTCM").Value.ToString().Trim()
        NroFacComercial = dtgOC_X_Item.Rows(intRow).Cells("NFCTCM").Value.ToString().Trim()
    End Sub

    Private Sub Llenar_Observaciones()
        dtgObservaciones.AutoGenerateColumns = False
        dtgObservaciones.DataSource = oPreEmbarque.Lista_Observacion_PreEmbarque()
    End Sub
    Public Sub Llenar_Fechas_Estimadas(Optional ByVal ofilter As SOLMIN_SC.Entidad.OrdenCompra_BE = Nothing)
            Dim oPreEmbarqueNeg As New clsPreEmbarque

        dtgFechasEstimadas.AutoGenerateColumns = False
        If ofilter Is Nothing Then
            Dim ofiltro As New SOLMIN_SC.Entidad.OrdenCompra_BE
            ofiltro.PNCCLNT = cmbCliente.pCodigo
            ofiltro.PSNORCML = oPreEmbarqueEntidad.PSNORCML
            ofiltro.PNNRITOC = oPreEmbarqueEntidad.PNNRITOC
            ofiltro.PNNRPEMB = oPreEmbarqueEntidad.PNNRPEMB
            dtgFechasEstimadas.DataSource = oPreEmbarqueNeg.Listar_FechasEntrega(ofiltro)
        End If
    End Sub
    Private Sub dtgFechasEstimadas_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgFechasEstimadas.DataBindingComplete
        For i As Integer = 0 To dtgFechasEstimadas.Rows.Count - 1
            If CStr(dtgFechasEstimadas.Rows(i).Cells("USRAPR").Value).Trim = "" Then
                dtgFechasEstimadas.Rows(i).Cells("Aprobacion").Value = Global.SOLMIN_SC.My.Resources.AprobarOk
                dtgFechasEstimadas.Rows(i).Cells("Aprobacion").ToolTipText = "Aprobacion"
            Else
                dtgFechasEstimadas.Rows(i).Cells("Aprobacion").Value = Global.SOLMIN_SC.My.Resources.CuadradoBlanco
            End If
        Next
    End Sub

#End Region

#Region "Carga de datos"

    Private Sub frmCargaInt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpClassUtility.Alinear_Columnas_Grilla(dtgFechasEstimadas)
        Me.Validar_Usuario_Autoridado()
        'oCliente = New clsCliente
        'oCliente.Lista = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente).Lista.Copy
        oEnvio = New clsEnvio
        oEnvio.Lista = DirectCast(HttpRuntime.Cache.Get("Envio"), clsEnvio).Lista.Copy
        oProveedor = New clsProveedor
        oProveedor.Lista = DirectCast(HttpRuntime.Cache.Get("Proveedor"), clsProveedor).Lista.Copy
        oPais = New clsPais
        oPais.Crea_Lista()
        oCheckPoint = New clsCheckPoint
        oPreEmbarque = New clsPreEmbarque
        oCheckPoint.Compania = HelpClass.getSetting("Compania")
        oCheckPoint.Division = HelpClass.getSetting("Division")
        oCheckPoint.Crea_Lista()
        bolBuscar = True
        Crear_Grillas()
        Cargar_combo()
        Me.dtpFin.Value = Now
        Me.dtpInicio.Value = Now
        Acceso_InformacionOrdenCompra_Adicionar(False)

    End Sub

#Region "Crear Grilla "

    Private Sub Crear_Grillas()
        'Crear_Grilla_OC_X_Item()
        'Crear_Grilla_Seguimiento_OC()
        'Crear_Grilla_dtgExportarExcel()
        'Crear_Grilla_Observaciones()

        If (Me.STSCHG1) Then
            dtgOC_X_Item.Columns("VALIDAR").Visible = False
        Else
            dtgOC_X_Item.Columns("VALIDAR").Visible = True
        End If
    End Sub
#End Region

#Region "Cargar Combo"

    Private Sub Cargar_combo()
        Llenar_Cliente()
        Llenar_Paises()
        llenar_Medio_Transporte()
        Llenar_Seguimiento()
        Llenar_Estado_Embarque()
    End Sub

    Private Sub Llenar_Cliente()
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpClass.UserName
        bolBuscar = True
    End Sub

    Private Sub Llenar_Proveedor()
        Dim strCliente As String
        If Me.cmbCliente.pCodigo > 0 Then
            strCliente = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If

        cmbProveedor.DataSource = oProveedor.Lista_Proveedor(strCliente, 0)
        cmbProveedor.ValueMember = "CPRVCL"
        cmbProveedor.DisplayMember = "TPRVCL"
    End Sub

    Private Sub Llenar_Paises()
        Me.cmbPaisOrg.DataSource = oPais.Lista_Pais()
        Me.cmbPaisOrg.ValueMember = "CPAIS"
        Me.cmbPaisOrg.DisplayMember = "TCMPPS"
    End Sub

    Private Sub llenar_Medio_Transporte()
        cmbTransporte.DataSource = oEnvio.Lista_Envio
        cmbTransporte.ValueMember = "CMEDTR"
        cmbTransporte.DisplayMember = "TNMMDT"
    End Sub

    Private Sub Llenar_Seguimiento()
        oPreEmbarque.Crear_Tabla_Seguimiento()
        bolBuscar = False
        cmbSeguimiento.DataSource = oPreEmbarque.Lista_Seguimiento
        oPreEmbarque.Crear_Tabla_Estado_Embarque()
        cmbSeguimiento.ValueMember = "COD"
        cmbSeguimiento.DisplayMember = "DES"
        cmbSeguimiento.SelectedValue = "P"
        bolBuscar = True
    End Sub

    Private Sub Llenar_Estado_Embarque()
        If cmbSeguimiento.SelectedIndex >= 0 Then
            If cmbSeguimiento.SelectedValue = "E" Then
                cmbEstadoEmbarcado.Visible = True
                lEstadoEmbarcado.Visible = True
                bolBuscar = False
                cmbEstadoEmbarcado.DataSource = oPreEmbarque.Lista_EstadoEmbarque
                cmbEstadoEmbarcado.ValueMember = "COD"
                cmbEstadoEmbarcado.DisplayMember = "DES"
                bolBuscar = True
                cmbEstadoEmbarcado.SelectedValue = "A"
            Else
                cmbEstadoEmbarcado.Visible = False
                lEstadoEmbarcado.Visible = False
            End If
        End If

    End Sub

#End Region

#Region "Cargar grillas"

    Private Sub Llenar_CheckPoint_X_Cliente()
        Dim oDt As DataTable
        'Dim oDrVw As DataGridViewRow
        'Dim intCont As Integer
        Dim strCliente As String

        If Me.cmbCliente.pCodigo > 0 Then
            strCliente = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If
        oDt = oCheckPoint.Lista_CheckPoint_X_Cliente(strCliente, "", "A")
        dtgSeguimiento_OC.AutoGenerateColumns = False
        dtgSeguimiento_OC.DataSource = oDt
        'With oDt
        '    If oDt.Rows.Count > 0 Then
        '        For intCont = 0 To .Rows.Count - 1
        '                oDrVw = New DataGridViewRow
        '            oDrVw.CreateCells(Me.dtgSeguimiento_OC)
        '            oDrVw.Cells(3).Value = .Rows(intCont).Item("NESTDO").ToString.Trim
        '            oDrVw.Cells(4).Value = .Rows(intCont).Item("CEMB").ToString.Trim
        '            oDrVw.Cells(5).Value = .Rows(intCont).Item("NOMVAR").ToString.Trim
        '            oDrVw.Cells(6).Value = .Rows(intCont).Item("TCOLUM").ToString.Trim
        '            dtgSeguimiento_OC.Rows.Add(oDrVw)
        '        Next intCont
        '    End If
        'End With
    End Sub

#End Region


#End Region

#Region "Filtros de Cabecera"
    Private Sub rbOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOC.CheckedChanged
        tsbEliminarSeguimiento.Visible = True
        tsbSeparadorEliminarSegui.Visible = True
        tsbAgregarItems.Visible = True
        tsbSeparadorAgregarItem.Visible = True
        tsbEmbarcar.Visible = True
        tsbSeparadorEmbarcar.Visible = True
        If bolBuscar Then
            chxFecha.Visible = False
            chxFecha.Checked = False
            dtpInicio.Visible = False
            dtpFin.Visible = False
            dtgOC_X_Item.Columns(1).Visible = False
            LimpiarGrillas()
            cmbSeguimiento.SelectedValue = "P"
            cmbSeguimiento.Enabled = True
        End If
    End Sub
    Private Sub rbEmbarque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmbarque.CheckedChanged
        tsbEliminarSeguimiento.Visible = False
        tsbSeparadorEliminarSegui.Visible = False
        tsbAgregarItems.Visible = False
        tsbSeparadorAgregarItem.Visible = False
        tsbEmbarcar.Visible = False
        tsbSeparadorEmbarcar.Visible = False
        If bolBuscar Then
            chxFecha.Visible = True
            dtpInicio.Visible = True
            dtpFin.Visible = True
            chxFecha.Checked = True
            dtgOC_X_Item.Columns(1).Visible = True
            LimpiarGrillas()
            cmbSeguimiento.SelectedValue = "E"
            'cmbSeguimiento.Enabled = False ' ACD - Verificar
        End If
    End Sub

    Private Sub LimpiarGrillas()
        Me.dtgOC_X_Item.DataSource = Nothing
        Llenar_CheckPoint_X_Cliente()
        Me.dtgObservaciones.DataSource = Nothing
    End Sub

    Private Sub chxOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxOC.CheckedChanged
        If chxOC.Checked Then
            Me.txtOC.Enabled = True
        Else
            Me.txtOC.Enabled = False
            txtOC.Text = ""
        End If
    End Sub

    Private Sub chxReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxReq.CheckedChanged
        If chxReq.Checked Then
            Me.txtReq.Enabled = True
        Else
            Me.txtReq.Enabled = False
            txtReq.Text = ""
        End If
    End Sub

    Private Sub chxEmb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxEmb.CheckedChanged
        If chxEmb.Checked Then
            Me.txtEmbarqueBusqueda.Enabled = True
        Else
            Me.txtEmbarqueBusqueda.Enabled = False
            txtEmbarqueBusqueda.Text = ""
        End If
    End Sub

    Private Sub chxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxFecha.CheckedChanged

        If chxFecha.Checked Then
            Me.dtpInicio.Enabled = True
            Me.dtpFin.Enabled = True
        Else
            Me.dtpInicio.Enabled = False
            Me.dtpFin.Enabled = False
        End If
    End Sub

    Private Sub cmbSeguimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSeguimiento.SelectedIndexChanged
        If bolBuscar Then
            Llenar_Estado_Embarque()
            If cmbSeguimiento.SelectedValue = "" Then
                HelpClass.MsgBox("Al seleccionar esta opción puede ser que la consulta demore algunos minutos")
            End If
            If cmbSeguimiento.SelectedValue = "P" Then
                If (Me.STSCHG1) Then
                    tsbEmbarcar.Visible = False
                Else
                    tsbEmbarcar.Visible = True

                End If
            Else
                tsbEmbarcar.Visible = False

            End If
            If cmbSeguimiento.SelectedValue = "E" Then
                tsbEliminarSeguimiento.Visible = False
                tsbAgregarItems.Visible = False
                txtEmbarqueBusqueda.Visible = True
                chxEmb.Visible = True
            Else
                If (Me.STSCHG1) Then
                    tsbEliminarSeguimiento.Visible = False
                    tsbAgregarItems.Visible = False
                Else
                    tsbEliminarSeguimiento.Visible = True
                    tsbAgregarItems.Visible = True
                End If

                chxEmb.Visible = False
                txtEmbarqueBusqueda.Visible = False
            End If
        End If
    End Sub

    Private Sub cmbEstadoEmbarcado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoEmbarcado.SelectedIndexChanged
        If bolBuscar Then
            If cmbEstadoEmbarcado.SelectedValue = "" Or cmbEstadoEmbarcado.SelectedValue = "C" Then
                HelpClass.MsgBox("Al seleccionar esta opción puede ser que la consulta demore algunos minutos")
            End If
        End If
    End Sub

    Private Sub fnBuscar()
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Listar_Orden_Compra()
        If dtgOC_X_Item.RowCount > 0 Then
            llenar_Tab(0)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        fnBuscar()

    End Sub

#End Region

#Region "Mantenimiento Checkpoint Carga Internacional"

    Private Sub Grabar_Oc_Item()
        Try
            Dim strCliente As String

            If Me.cmbCliente.pCodigo > 0 Then
                strCliente = Me.cmbCliente.pCodigo
            Else
                Exit Sub
            End If

            Grabar_Checkpoint_X_Preembarque(oPreEmbarque.Preembarque)
            oPreEmbarque.Lista_Checkpoint_Item_OC_X_Cliente(strCliente)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Grabar_Checkpoint_X_Preembarque(ByVal dblNumPreembarque As Integer)
        Dim dblFecEst As Double
        Dim dblFecReal, dblTransac As Double
        Dim intCont As Integer

        For intCont = 0 To dtgSeguimiento_OC.RowCount - 1
            If dtgSeguimiento_OC.Rows(intCont).Cells("DFECEST").Value = vbNullString Then
                dblFecEst = 0
            Else
                dblFecEst = Format(CType(dtgSeguimiento_OC.Rows(intCont).Cells("DFECEST").Value, Date), "yyyyMMdd")
            End If
            If dtgSeguimiento_OC.Rows(intCont).Cells("DFECREA").Value = vbNullString Then
                dblFecReal = 0
            Else
                dblFecReal = Format(CType(dtgSeguimiento_OC.Rows(intCont).Cells("DFECREA").Value, Date), "yyyyMMdd")
            End If
            If dtgSeguimiento_OC.Rows(intCont).Cells("TOBS").Value = vbNullString Then
                dtgSeguimiento_OC.Rows(intCont).Cells("TOBS").Value = ""
            End If
            dblTransac = oPreEmbarque.Obtener_Num_PreEmbarque_X_OC(dblNumPreembarque, dtgSeguimiento_OC.Rows(intCont).Cells("NESTDO").Value)
            If dblTransac = vbNullString Then
                oCheckPoint.Grabar_Checkpoint_X_Preembarque("I", dblNumPreembarque, 0, dtgSeguimiento_OC.Rows(intCont).Cells("NESTDO").Value, dblFecEst, dblFecReal, "A", dtgSeguimiento_OC.Rows(intCont).Cells("TOBS").Value)
            Else
                oCheckPoint.Grabar_Checkpoint_X_Preembarque("A", dblNumPreembarque, dblTransac, dtgSeguimiento_OC.Rows(intCont).Cells("NESTDO").Value, dblFecEst, dblFecReal, "A", dtgSeguimiento_OC.Rows(intCont).Cells("TOBS").Value)
            End If

        Next intCont
    End Sub

#End Region

    Private Sub Actualizar_Grilla()
        Dim intCont As Integer

        For intCont = 0 To Me.dtgOC_X_Item.Rows.Count - 1
            If Double.Parse(Me.dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value.ToString.Trim) = oPreEmbarque.Preembarque Then
                With Me.dtgOC_X_Item.Rows(intCont)
                    .Cells("QRLCSC").Value = txtCantidad.Text
                    .Cells("QCNTIT").Value = txtCantidad_Total.Text
                    .Cells("DIFER").Value = txtCantidad_Pendiente.Text
                    .Cells("MONTO").Value = Format(CType(.Cells("QRLCSC").Value, Double) * CType(.Cells("IVUNIT").Value, Double), "###,###,##0.00")
                End With
                Exit For
            End If
        Next intCont
    End Sub


    Private Sub HabilitarTabs()
        Me.Acceso_InformacionOrdenCompra_Adicionar(False)
        tslLeyenda.Visible = False
        tsbAgregar.Visible = False
        tsbSeparadorAgregar.Visible = False
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If Not Me.STSOP22 Then
                    tsbSeparadorModificar.Visible = True
                    tsbModificar.Visible = True
                    tsbCancelar.Visible = True
                    tsbSeparadorCancelar.Visible = True
                End If
            Case 1
                If Not Me.STSOP22 Then
                    ' btnEditarChk.Visible = True
                    tsbSeparadorEliminar.Visible = True
                    tsbEliminar.Visible = True
                    tsbSeparadorEditarCheck.Visible = True
                End If
            Case 2
                If Not Me.STSOP22 Then
                    tsbEliminar.Visible = True
                    tsbSeparadorEliminar.Visible = True
                    tsbModificar.Visible = True
                    tsbSeparadorModificar.Visible = True
                End If
            Case 3
                tslLeyenda.Visible = True
                tsbSeparadorAgregar.Visible = True
                tsbAgregar.Visible = True
                tsbSeparadorEliminar.Visible = True
                tsbEliminar.Visible = True
                tsbSeparadorCancelar.Visible = True
        End Select
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        HabilitarTabs()
    End Sub

    Private Sub Embarcar()
        Dim dblEmbarque As Double
        Dim intCont, intRep As Integer
        Dim oFiltroEmbarcar As New SOLMIN_SC.Entidad.OrdenCompra_BE
        oFiltroEmbarcar.PNCCLNT = Me.cmbCliente.pCodigo

        Try

            If Me.cmbCliente.pCodigo = 0 Then
                Exit Sub
            End If

            If Existe_Check() Then
                If HelpClass.RspMsgBox("Está seguro que quiere embarcar la OC?") = Windows.Forms.DialogResult.Yes Then
                    intRep = dtgOC_X_Item.Rows.Count
                    oPreEmbarque.Cliente = Me.cmbCliente.pCodigo
                    dblEmbarque = Double.Parse(oPreEmbarque.Crear_Embarque().Rows(0).Item("NORSCI").ToString)

                    If dtgFechasEstimadas.Rows.Count > 0 Then 'Solo Si tiene Fechas Estimadas Para Aprobar
                        Dim OdtFiltroEmbarcar As DataTable = oPreEmbarque.VerificaFechasEntregaAprobado(oFiltroEmbarcar)
                        For intCont = intRep - 1 To 0 Step -1
                            If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                                oFiltroEmbarcar.PSNORCML = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value()
                                oFiltroEmbarcar.PNNRITOC = dtgOC_X_Item.Rows(intCont).Cells("NRITOC_1").Value()
                                If fFechaAprobado(oFiltroEmbarcar, OdtFiltroEmbarcar) = False Then
                                    HelpClass.MsgBox("Necesita Aprobar Fechas Estimadas para poder generar Embarque")
                                    Exit Sub
                                End If
                            End If
                        Next
                    End If

                    For intCont = intRep - 1 To 0 Step -1
                        If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                            oPreEmbarque.OC = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value
                            oPreEmbarque.Parcial = dtgOC_X_Item.Rows(intCont).Cells("NRPARC").Value
                            oPreEmbarque.Embarcar_PreEmbarque(dblEmbarque, dtgOC_X_Item.Rows(intCont).Cells("NRITOC_1").Value, dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value, dtgOC_X_Item.Rows(intCont).Cells("QRLCSC").Value, dtgOC_X_Item.Rows(intCont).Cells("SBITOC").Value)
                            dtgOC_X_Item.Rows.RemoveAt(intCont)
                        End If
                    Next intCont

                    oPreEmbarque.Act_Datos_Embarque(dblEmbarque)
                End If
            Else
                HelpClass.MsgBox("Debe seleccionar algún PreEmbarque a Embarcar")
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub cmbCliente_TextChanged() Handles cmbCliente.TextChanged

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Llenar_Proveedor()
        Llenar_CheckPoint_X_Cliente()
        fnBuscar()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New Negocio.clsAcceso
        Dim objUsuario As New Negocio.clsUsuario
        Dim objEntidadAcceso As New Entidad.beAcceso
        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objUsuario.GetUserName)
        objParametro.Add("MMNPVB", Me.Name.Trim)

        objEntidadAcceso = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidadAcceso.STSOP1 = "" Then
            Acceso_SeguientoOrdenCompra_Adicionar(False)
            Acceso_SeguientoOrdenCompra_Cambiar(False)
            Acceso_SeguientoOrdenCompra_Eliminar(False)
            Me.STSOP11 = True
        Else
            Me.STSOP11 = False
        End If

        If objEntidadAcceso.STSOP2 = "" Then
            Acceso_InformacionOrdenCompra_Adicionar(False)
            Me.STSOP22 = True
        Else
            Me.STSOP22 = False
        End If
        tsbAgregar.Visible = False

    End Sub

    Private Sub Acceso_SeguientoOrdenCompra_Adicionar(ByVal Estado As Boolean)
        tsbEmbarcar.Visible = Estado
        tsbSeparadorEmbarcar.Visible = Estado
        tsbAgregarItems.Visible = Estado
        tsbSeparadorAgregarItem.Visible = Estado
        tsbAgregarObservaciones.Visible = Estado
        tsbSeparadorAgregarObs.Visible = Estado
    End Sub

    Private Sub Acceso_SeguientoOrdenCompra_Cambiar(ByVal Estado As Boolean)
        tsbEditarCheckpoints.Visible = Estado
        tsbSeparadorEditarCheck.Visible = Estado
    End Sub

    Private Sub Acceso_SeguientoOrdenCompra_Eliminar(ByVal Estado As Boolean)
        tsbEliminarSeguimiento.Visible = Estado
        tsbSeparadorEliminarSegui.Visible = Estado
    End Sub

    Private Sub Acceso_InformacionOrdenCompra_Adicionar(ByVal Estado As Boolean)
        ' tsbEditar.Visible = Estado
        tsbCancelar.Visible = Estado
        tsbSeparadorCancelar.Visible = Estado
        tsbEliminar.Visible = Estado
        tsbSeparadorEliminar.Visible = Estado
        tsbModificar.Visible = Estado
        tsbSeparadorModificar.Visible = Estado
    End Sub

#Region "Exportar Excel "

    Private Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function
    Private Sub AbrirDocumento(ByVal Path As String)
        Try
            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
            Dim Proceso As New System.Diagnostics.Process
            With InfoProceso
                .FileName = Path
                .CreateNoWindow = True
                .ErrorDialog = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With
            Proceso.StartInfo = InfoProceso
            Proceso.Start()
            Proceso.Dispose()
        Catch
        End Try
    End Sub
    Private Sub Exportar_Excel_Pendientes()
        If oDtExcelOrigen.Rows.Count = 0 Then Return

        Dim mpGenerarXLS As New ExportarExcel
        Dim bPendiente As Boolean = True
        Dim oRowExcel As New SOLMIN_SC.Entidad.OrdenCompra_BE
        Dim oDtExcelFiltrado As DataTable
        oDtExcelFiltrado = oDtExcelOrigen.Clone
        oRowExcel.PNCCLNT = cmbCliente.pCodigo

        Dim oDtVerifica As DataTable = oPreEmbarque.VerificaFechasEntregaAprobado(oRowExcel)
        For i As Integer = 0 To oDtExcelOrigen.Rows.Count - 1
            oRowExcel.PSNORCML = oDtExcelOrigen.Rows(i).Item("NORCML")
            oRowExcel.PNNRITOC = oDtExcelOrigen.Rows(i).Item("NRITOC")
            oRowExcel.PNNRPEMB = oDtExcelOrigen.Rows(i).Item("NRPEMB")
            bPendiente = fFechaPendiente(oRowExcel, oDtVerifica) 'devuelve true SI encuentra registros Pendientes, false NO encuentra devuelve 
            If bPendiente = True Then
                oDtExcelFiltrado.ImportRow(oDtExcelOrigen.Rows(i)) 'Solo mostraran los pendientes                
            End If
        Next
        '///////////////////////////////////////
        '// Quitamos columnas que no se usaran//
        '///////////////////////////////////////
        oDtExcelFiltrado.Columns.Remove("CCLNT")
        oDtExcelFiltrado.Columns.Remove("NORSCI")
        oDtExcelFiltrado.Columns.Remove("TOBS")
        oDtExcelFiltrado.Columns.Remove("FECHA DE EMBARQUE_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE EMBARQUE_DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE LLEGADA_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE LLEGADA_DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE DUA_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE DUA_DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE LLEGADA DE CONTENEDOR_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE LLEGADA DE CONTENEDOR_DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE Vo.Bo._DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE Vo.Bo._DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE DOCUMENTOS COMPLETOS_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE DOCUMENTOS COMPLETOS_DFECREA")
        oDtExcelFiltrado.Columns.Remove("FECHA DE ENTREGA EN ALMACEN DEL CLIENTE_DFECEST")
        oDtExcelFiltrado.Columns.Remove("FECHA DE ENTREGA EN ALMACEN DEL CLIENTE_DFECREA")

        oDtExcelFiltrado.Columns.Add(New DataColumn("FECHA1"))
        oDtExcelFiltrado.Columns.Add(New DataColumn("FECHA2"))
        For j As Integer = 0 To oDtExcelFiltrado.Rows.Count - 1
            oRowExcel.PSNORCML = oDtExcelFiltrado.Rows(j).Item("NORCML")
            oRowExcel.PNNRITOC = oDtExcelFiltrado.Rows(j).Item("NRITOC")
            oRowExcel.PNNRPEMB = oDtExcelFiltrado.Rows(j).Item("NRPEMB")

            oDtExcelFiltrado.Rows(j).Item("FECHA1") = fTraeFechaAprobacion(oRowExcel, oDtVerifica, 1)
            oDtExcelFiltrado.Rows(j).Item("FECHA2") = fTraeFechaAprobacion(oRowExcel, oDtVerifica, 2)
        Next
        oDtExcelFiltrado.Columns.Remove("NRPEMB")

        mpGenerarXLS.mpGenerarXLS("Pendientes", oDtExcelFiltrado)
    End Sub
    Private Function fTraeFechaAprobacion(ByVal oRowExcel As SOLMIN_SC.Entidad.OrdenCompra_BE, ByVal oDtVerifica As DataTable, ByVal flg As Int16) As String
        Dim rowsVerifica As DataRow()
        rowsVerifica = oDtVerifica.Select("CCLNT =" & oRowExcel.PNCCLNT & " AND NORCML='" & oRowExcel.PSNORCML & "' AND NRITOC=" & oRowExcel.PNNRITOC & " AND NRPEMB =" & oRowExcel.PNNRPEMB & " AND SESTAT='P'")
        If rowsVerifica.Length > 0 Then
            If flg = 1 Then
                Return HelpClassUtility.CNumero8Digitos_a_FechaDefault(rowsVerifica(0).Item(7))
            Else
                Return HelpClassUtility.CNumero8Digitos_a_FechaDefault(rowsVerifica(0).Item(8))
            End If
            Exit Function
        End If
        Return ""
    End Function
    Private Function fFechaAprobado(ByVal oRowExcel As SOLMIN_SC.Entidad.OrdenCompra_BE, ByVal oDtVerifica As DataTable) As Boolean
        Dim rowsVerifica As DataRow()
        rowsVerifica = oDtVerifica.Select("CCLNT =" & oRowExcel.PNCCLNT & " AND NORCML='" & oRowExcel.PSNORCML & "' AND NRITOC=" & oRowExcel.PNNRITOC & " AND NRPEMB =" & oRowExcel.PNNRPEMB & " AND SESTAT='A'")
        If rowsVerifica.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function fFechaPendiente(ByVal oRowExcel As SOLMIN_SC.Entidad.OrdenCompra_BE, ByVal oDtVerifica As DataTable) As Boolean
        Dim rowsVerifica As DataRow()
        rowsVerifica = oDtVerifica.Select("CCLNT =" & oRowExcel.PNCCLNT & " AND NORCML='" & oRowExcel.PSNORCML & "' AND NRITOC=" & oRowExcel.PNNRITOC & " AND NRPEMB =" & oRowExcel.PNNRPEMB & " AND SESTAT='P'")
        If rowsVerifica.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Exportar_Excel_ba2()

        If oDtExcelOrigen.Rows.Count = 0 Then Return
        '/////////////////////////////////////////////////
        '// Quitamos columnas que no se usaran
        '/////////////////////////////////////////////////
        Dim oDtExcel As DataTable
        oDtExcel = oDtExcelOrigen.Copy()
        oDtExcel.Columns.Remove("NRPEMB")
        oDtExcel.Columns.Remove("CCLNT")
        oDtExcel.Columns.Remove("NORSCI")

        '/////////////////////////////
        '// Creamos el Objeto StreamWriter
        '/////////////////////////////
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"
        If IO.Directory.Exists(path) = False Then
            IO.Directory.CreateDirectory(path)
        End If
        Dim archivo As String = path & "reporte" & NowNumeric() & ".xls" 'xml
        Dim xls As New IO.StreamWriter(archivo, True, Encoding.Default)

        '/////////////////////////////////////////////////
        '// Iniciamos Tabla html
        '/////////////////////////////////////////////////
        xls.WriteLine("<TABLE>")
        xls.WriteLine("<tr><td colspan='" + (oDtExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (oDtExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (oDtExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr><td colspan='" + (oDtExcel.Columns.Count + 2).ToString + "'> </td></tr>")
        xls.WriteLine("<tr>")
        '/////////////////////////////////////////////////
        '// Armamos la linea con los títulos de columnas
        '/////////////////////////////////////////////////
        xls.WriteLine("<td colspan='2' rowspan='2'> </td>")
        For Each dc As DataColumn In oDtExcel.Columns
            Dim Value As String = String.Empty
            Value = NameFormat(dc.ColumnName)
            Value = Replace(Value, """", String.Empty)
            If Value.EndsWith("_DFECEST") Or Value.EndsWith("_DFECREA") Then
                If Value.EndsWith("_DFECEST") Then
                    Value = Value.Substring(0, Value.Length - "_DFECEST".Length)
                    xls.Write("<td colspan='2'  style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold; border:1px solid black ' >")
                    xls.Write(Value)
                    xls.Write("</td>")
                End If
            Else
                xls.Write("<td rowspan='2' style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold(); border:1px solid black ' >")
                xls.Write(Value)
                xls.Write("</td>")
            End If
        Next
        xls.WriteLine("</tr>")
        xls.WriteLine("<tr>")
        For Each dc As DataColumn In oDtExcel.Columns
            Dim Value As String = String.Empty
            Value = NameFormat(dc.ColumnName)
            Value = Replace(Value, """", String.Empty)
            If Value.EndsWith("_DFECEST") Or Value.EndsWith("_DFECREA") Then
                xls.Write("<td style='background:yellow; text-align:center; line-height:18px; Font(-weight): bold(); border:1px solid black ' >")
                xls.Write(IIf(Value.EndsWith("_DFECEST"), "FECHA ESTIMADA", "FECHA REAL"))
                xls.Write("</td>")
            End If
        Next
        xls.WriteLine("</tr>")
        'How to Left, Right, Center 
        '/////////////////////////////////////////////////
        '// Armamos filas
        '/////////////////////////////////////////////////
        For Each dr As DataRow In oDtExcel.Rows
            xls.WriteLine("<tr>")
            xls.WriteLine("<td colspan='2'> </td>")
            For Each dc As DataColumn In oDtExcel.Columns
                Dim Value As String = String.Empty
                Value = Replace(dr(dc.ColumnName).ToString().Trim(), ";", "<br>")
                xls.Write("<td style='text-align:" + AlignText(Value) + "; border:1px solid black ' >")
                xls.Write(Value)
                xls.Write("</td>")
            Next
            xls.WriteLine("</tr>")
        Next

        xls.WriteLine("</TABLE>")
        xls.Flush()
        xls.Close()
        xls.Dispose()
        AbrirDocumento(archivo)
    End Sub
    Private Function AlignText(ByVal Text As Object) As String
        Dim Align As String = "Center"
        Select Case True
            Case fnIsNumeric(Text) : Align = "Right"
            Case fnIsDate(Text) : Align = "Center"
            Case Else : Align = "Left"
        End Select
        Return Align
    End Function
    Private Function fnIsNumeric(ByVal Text As Object) As Boolean
        Try
            Dim obj As Double
            obj = Convert.ToDouble(Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function fnIsDate(ByVal Text As Object) As Boolean
        Try
            Dim obj As DateTime
            obj = Convert.ToDateTime(Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function NameFormat(ByVal ColumnName) As String
        Dim Name As String = ColumnName
        Select Case ColumnName
            Case "NORSCI" : Name = "NORSCI"
            Case "NRPEM" : Name = "NRPEM"
            Case "CCLNT" : Name = "CCLNT"
            Case "NORCML" : Name = "O/C"
            Case "FORCML" : Name = "FECHA DE O/C"
            Case "FROCMP" : Name = "FECHA DE<br>CONFIRMACION DE O/C"
            Case "TTINTC" : Name = "INCOTERM"
            Case "TCTCST" : Name = "C/C"
            Case "NRPARC" : Name = "NRO PARCIAL<br>DE O/C"
            Case "TPRVCL" : Name = "NOMBRE DEL PROVEEDOR"
            Case "NRITOC" : Name = "ITEM"
            Case "SBITOC" : Name = "SUB ITEM"
            Case "TDITES" : Name = "DESCRIPCION DEL PRODUCTO"
            Case "QCNTIT" : Name = "CANTIDAD<br>SOLICITUD"
            Case "QCNEMB" : Name = "CANTIDAD<br>ATENDIDA"
            Case "QCNPED" : Name = "CANTIDAD<br>PENDIENTE"
            Case "QRLCSC" : Name = "CANTIDAD<br>PRE EMBARCADA"
            Case "TUNDIT" : Name = "UNIDAD<br>COMERCIAL"
            Case "IVUNIT" : Name = "VALOR<br>UNITARIO"
            Case "IVTOIT" : Name = "VALOR TOTAL"
            Case "NMONOC" : Name = "MONEDA<br>DE COMPRA"
            Case "FMPDME" : Name = "FECHA DE ENTREGA<br>PROMETIDA"
            Case "FMPIME" : Name = "FECHA REQUERIDA<br>EN PLANTA"
            Case "TOBS" : Name = "OBSERVACIONES"
        End Select
        Return Name
    End Function

#End Region


#Region "Grid Seguimiento"

    Private Sub dtgOC_X_Item_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOC_X_Item.CellClick
        Try
            If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
                llenar_Tab(e.RowIndex)
            End If
            If e.ColumnIndex = 0 Then
                If dtgOC_X_Item.Rows(e.RowIndex).Cells(0).Value = True Then
                    dtgOC_X_Item.Rows(e.RowIndex).Cells(0).Value = False
                Else
                    dtgOC_X_Item.Rows(e.RowIndex).Cells(0).Value = True
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtgOC_X_Item_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOC_X_Item.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.WaitCursor
            If dtgOC_X_Item.RowCount > 0 Then
                If Existe_Check() Then
                    Poner_Check_Todo_OC(False)
                Else
                    Poner_Check_Todo_OC(True)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dtgOC_X_Item_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOC_X_Item.RowEnter
        If dtgOC_X_Item.CurrentCellAddress.Y > -1 Then
            Me.Cursor = Cursors.WaitCursor
            llenar_Tab(Me.dtgOC_X_Item.CurrentCellAddress.Y)
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Tool Item CO"

#End Region



    Private Sub tsbEditarCheckpoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditarCheckpoints.Click
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oDr As DataRow

        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.dtgOC_X_Item.EndEdit()
        Dim Check As Integer = Existe_Check()
        If Check = 0 Then
            HelpClass.MsgBox("Tiene que seleccionar al menos un Item para que pueda usar esta opción")
        Else
            If Check = 1 Then
                EditarCheckpoint()
                Exit Sub
            End If
            oDt = New DataTable
            oDt.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NRPARC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NRITOC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("SBITOC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TDITES", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("QRLCSC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("TTINTC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NMONOC", GetType(System.String)))
            oDt.Columns.Add(New DataColumn("NRPEMB", GetType(System.String)))

            For intCont = 0 To dtgOC_X_Item.Rows.Count - 1
                If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                    oDr = oDt.NewRow
                    oDr.Item("NORCML") = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value
                    oDr.Item("NRPARC") = dtgOC_X_Item.Rows(intCont).Cells("NRPARC").Value
                    oDr.Item("NRITOC") = dtgOC_X_Item.Rows(intCont).Cells("NRITOC_1").Value
                    oDr.Item("SBITOC") = dtgOC_X_Item.Rows(intCont).Cells("SBITOC").Value
                    oDr.Item("TDITES") = dtgOC_X_Item.Rows(intCont).Cells("TDITES").Value
                    oDr.Item("QRLCSC") = dtgOC_X_Item.Rows(intCont).Cells("QRLCSC").Value
                    oDr.Item("TTINTC") = dtgOC_X_Item.Rows(intCont).Cells("TTINTC").Value
                    oDr.Item("NMONOC") = dtgOC_X_Item.Rows(intCont).Cells("NMONOC").Value
                    oDr.Item("NRPEMB") = dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value
                    oDt.Rows.Add(oDr)
                End If
            Next intCont
            Dim frm As New frmEditarCheckpoinMasivo(Me.cmbCliente.pCodigo, oDt, oCheckPoint.Compania, oCheckPoint.Division, oPreEmbarque)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                llenar_Tab()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub EditarCheckpoint()
        Dim oDt As DataTable
        Dim oDr As DataRow

        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        oDt = New DataTable
        oDt.Columns.Add(New DataColumn("NRPEMB", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("DFECEST", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("DFECREA", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOBS", GetType(System.String)))

        For intCont As Integer = 0 To dtgSeguimiento_OC.Rows.Count - 1
            oDr = oDt.NewRow
            oDr.Item("NRPEMB") = oPreEmbarque.Preembarque '  dtgSeguimiento_OC.Rows(intCont).Cells("NRPEMB").Value
            oDr.Item("DFECEST") = dtgSeguimiento_OC.Rows(intCont).Cells("DFECEST").Value
            oDr.Item("DFECREA") = dtgSeguimiento_OC.Rows(intCont).Cells("DFECREA").Value
            oDr.Item("TOBS") = dtgSeguimiento_OC.Rows(intCont).Cells("TOBS").Value
            oDt.Rows.Add(oDr)
        Next intCont

        Dim frm As New frmEditarCheckpoin(Me.cmbCliente.pCodigo, oDt, oCheckPoint.Compania, oCheckPoint.Division, oPreEmbarque)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            llenar_Tab()
        End If

        Me.Cursor = Cursors.Default
        llenar_Tab()
    End Sub

    Private Sub tsbAgregarObservaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarObservaciones.Click
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oDr As DataRow

        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.dtgOC_X_Item.EndEdit()

        Dim Check As Integer = Existe_Check()
        If Check = 0 Then
            HelpClass.MsgBox("Tiene que seleccionar al menos un Item para que pueda usar esta opción")
        Else
            If Check = 1 Then
                AgregarObservaciones()
                Exit Sub
            End If
            oDt = New DataTable
            oDt.Columns.Add("NRPEMB")
            oDt.Columns.Add("NORCML")
            oDt.Columns.Add("NRPARC")
            oDt.Columns.Add("NRITOC")
            oDt.Columns.Add("SBITOC")
            oDt.Columns.Add("TDITES")
            oDt.Columns.Add("QRLCSC")
            oDt.Columns.Add("TTINTC")
            oDt.Columns.Add("NMONOC")

            For intCont = 0 To dtgOC_X_Item.Rows.Count - 1
                If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                    oDr = oDt.NewRow
                    oDr.Item("NRPEMB") = dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value
                    oDr.Item("NORCML") = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value
                    oDr.Item("NRPARC") = dtgOC_X_Item.Rows(intCont).Cells("NRPARC").Value
                    oDr.Item("NRITOC") = dtgOC_X_Item.Rows(intCont).Cells("NRITOC_1").Value
                    oDr.Item("SBITOC") = dtgOC_X_Item.Rows(intCont).Cells("SBITOC").Value
                    oDr.Item("TDITES") = dtgOC_X_Item.Rows(intCont).Cells("TDITES").Value
                    oDr.Item("QRLCSC") = dtgOC_X_Item.Rows(intCont).Cells("QRLCSC").Value
                    oDr.Item("TTINTC") = dtgOC_X_Item.Rows(intCont).Cells("TTINTC").Value
                    oDr.Item("NMONOC") = dtgOC_X_Item.Rows(intCont).Cells("NMONOC").Value
                    oDt.Rows.Add(oDr)
                    'End If
                End If
            Next intCont
            Dim frm As New frmObservacionesMasivo(Me.cmbCliente.pCodigo, oDt)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                llenar_Tab()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AgregarObservaciones()
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim strNRPEMB As String = String.Empty
        strNRPEMB = oPreEmbarque.Preembarque
        Dim frm As New frmObservaciones(Me.cmbCliente.pCodigo, strNRPEMB)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        End If

        Me.Cursor = Cursors.Default

        llenar_Tab()
    End Sub

    Private Sub tsbAgregarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarItems.Click
        Dim frm As frmBuscar
        If Me.cmbCliente.pCodigo > 0 Then
            frm = New frmBuscar(Me.cmbCliente.pCodigo)
        Else
            Exit Sub
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Listar_Orden_Compra()
            'Limpiar_Fechas()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub tsbEliminarSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarSeguimiento.Click

        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If

        chxOC.Focus()
        Me.Cursor = Cursors.WaitCursor
        Eliminar_OC_Item()
        Me.Cursor = Cursors.Default
        dtgOC_X_Item.Focus()
    End Sub

    Private Sub tsbEmbarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEmbarcar.Click
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        'Verificar Que el PreEmbarcado Se encuentre Aprobado
        Me.Cursor = Cursors.WaitCursor
        Me.dtgOC_X_Item.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Embarcar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbExportarAExcelTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarAExcelTodo.Click
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Exportar_Excel_ba2()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub tsbExportarPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarPendientes.Click
        If Me.cmbCliente.pCodigo = 0 Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Exportar_Excel_Pendientes()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Me.txtCantidad.ReadOnly = True
        Me.txtNroDocEmbarque.ReadOnly = True
        Me.txtNroFacComercial.ReadOnly = True

        Me.tsbModificar.Text = "Modificar"
        tsbModificar.Image = My.Resources.db_comit
        Me.tsbCancelar.Visible = False

        Me.txtCantidad.BackColor = Color.FromArgb(222, 222, 222)
        Me.txtNroDocEmbarque.BackColor = Color.FromArgb(222, 222, 222)
        Me.txtNroFacComercial.BackColor = Color.FromArgb(222, 222, 222)

        txtCantidad.Text = Cantida_Item
        txtNroDocEmbarque.Text = NroDocEmbarque
        txtNroFacComercial.Text = NroFacComercial
    End Sub

    Private Sub Eliminar_Observacion()
        If dtgObservaciones.Rows.Count = 0 Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        chxOC.Focus()
        Try
            Dim strNRITEM As String = dtgObservaciones.Rows(dtgObservaciones.SelectedCells.Item(0).RowIndex).Cells("NRITEM").Value
            oPreEmbarque.Eliminar_Observacion(strNRITEM)
        Catch ex As Exception
        End Try
        dtgSeguimiento_OC.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        llenar_Tab()
    End Sub
    Private Sub Eliminar_FechaEstimada()
        If dtgFechasEstimadas.Rows.Count = 0 Then Exit Sub
        If dtgFechasEstimadas.CurrentRow.Cells(6).Value = "A" Then Exit Sub
        Dim oCargaInternacional As New SOLMIN_SC.Entidad.OrdenCompra_BE
        oCargaInternacional.PNCCLNT = cmbCliente.pCodigo
        oCargaInternacional.PSNORCML = oPreEmbarqueEntidad.PSNORCML
        oCargaInternacional.PNNRITOC = oPreEmbarqueEntidad.PNNRITOC
        oCargaInternacional.PNNRPEMB = oPreEmbarqueEntidad.PNNRPEMB
        oCargaInternacional.PNNCRRLT = dtgFechasEstimadas.CurrentRow.Cells(1).Value
        Dim y As Int16 = MsgBox("Desea Eliminar el  Registro con Correlativo '" & oCargaInternacional.PNNCRRLT & "'?", MsgBoxStyle.YesNo, "Mensaje de informacion")
        If y = 6 Then
            Dim x As Integer = oPreEmbarque.Anular_FechasEntrega_PreEmbarque(oCargaInternacional)
            If x = 1 Then
                HelpClass.MsgBox("El registro se anulo con exito")
                Llenar_Fechas_Estimadas()
            Else
                HelpClass.MsgBox("Hubo un error al intentar anular el registro")
            End If
        End If

    End Sub
    Private Sub Eliminar_CheckPoints()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        chxOC.Focus()
        Try
            Dim strMESTDO As String = dtgSeguimiento_OC.CurrentRow.Cells("MESTDO").Value
            oPreEmbarque.Borrar_Checkpoint_Item_OC(strMESTDO)
            oPreEmbarque.Lista_Checkpoint_Item_OC_X_Cliente(Me.cmbCliente.pCodigo)
            llenar_Tab()
        Catch ex As Exception
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
            Case 1
                Eliminar_CheckPoints()
            Case 2
                Eliminar_Observacion()
            Case 3
                Eliminar_FechaEstimada()
        End Select
    End Sub

    Private Sub Modificar_Datos_generales()
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        Me.tsbModificar.Visible = True
        If Me.txtCantidad.ReadOnly Then
            Me.txtCantidad.ReadOnly = False
            Me.txtNroDocEmbarque.ReadOnly = False
            Me.txtNroFacComercial.ReadOnly = False

            Me.tsbModificar.Text = "Grabar"
            tsbModificar.Image = My.Resources.fileexport
            Me.tsbCancelar.Visible = True

            Me.txtCantidad.BackColor = Color.White
            Me.txtNroDocEmbarque.BackColor = Color.White
            Me.txtNroFacComercial.BackColor = Color.White

            cmbIndicador.Enabled = True
            cmbIndicador.BackColor = Color.White
            txtCantidad.Focus()
        Else
            Me.tsbModificar.Visible = False
            Me.txtCantidad.ReadOnly = True
            Me.txtNroDocEmbarque.ReadOnly = True
            Me.txtNroFacComercial.ReadOnly = True

            cmbIndicador.Enabled = False
            Me.tsbModificar.Text = "Modificar"
            tsbModificar.Image = My.Resources.db_comit
            Me.tsbCancelar.Visible = False

            Me.txtCantidad.BackColor = Color.FromArgb(222, 222, 222)
            Me.txtNroDocEmbarque.BackColor = Color.FromArgb(222, 222, 222)
            Me.txtNroFacComercial.BackColor = Color.FromArgb(222, 222, 222)
            cmbIndicador.BackColor = Color.FromArgb(222, 222, 222)

            If IsNumeric(txtCantidad.Text) Then
                If (CType(txtCantidad_Pendiente.Text, Double) + Cantida_Item) >= CType(txtCantidad.Text, Double) Then
                    oPreEmbarque.Act_Cantidad_Item(oPreEmbarque.Preembarque, txtOrdenCompra.Text, txtItem.Text, txtCantidad.Text, txtSubItem.Text, txtNroDocEmbarque.Text, txtNroFacComercial.Text)
                    Listar_Orden_Compra()
                Else
                    HelpClass.MsgBox("La cantidad no puede ser mayor  " & txtCantidad_Pendiente.Text + Cantida_Item)
                    txtCantidad.Text = Cantida_Item
                    txtNroDocEmbarque.Text = NroDocEmbarque
                    txtNroFacComercial.Text = NroFacComercial
                End If
            Else
                txtCantidad.Text = Cantida_Item
                txtNroDocEmbarque.Text = NroDocEmbarque
                txtNroFacComercial.Text = NroFacComercial
            End If
        End If
        llenar_Tab()
    End Sub
    Private Sub Modificar_Observacion()
        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If
        If dtgObservaciones.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Dim strNRPEMB As String = oPreEmbarque.Preembarque
            Dim strNRITEM As String = dtgObservaciones.Rows(dtgObservaciones.SelectedCells.Item(0).RowIndex).Cells("NRITEM").Value
            Dim frm As New frmObservaciones(Me.cmbCliente.pCodigo, strNRPEMB, strNRITEM)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                llenar_Tab()
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Modificar_Datos_generales()
            Case 1
            Case 2
                Modificar_Observacion()
            Case 3
        End Select
    End Sub

    Private Function Valida_Aprobaciones_Pendientes() As Boolean
        Dim bAgregar As Boolean = True
        For i As Integer = 0 To dtgFechasEstimadas.Rows.Count - 1
            If dtgFechasEstimadas.Rows(i).Cells("USRAPR").Value.ToString.Trim = "" Then
                bAgregar = False
                Exit For
            End If
        Next
        Return bAgregar
    End Function
    Private Sub Agregar_Observaciones()
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim oDr As DataRow

        If Me.cmbCliente.pCodigo = 0 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.dtgOC_X_Item.EndEdit()

        Dim Check As Integer = Existe_Check()
        If Check = 0 Then
            HelpClass.MsgBox("Tiene que seleccionar al menos un Item para que pueda usar esta opción")
        Else
            If Check = 1 Then
                AgregarObservaciones()
                Exit Sub
            End If
            oDt = New DataTable
            oDt.Columns.Add("NRPEMB")
            oDt.Columns.Add("NORCML")
            oDt.Columns.Add("NRPARC")
            oDt.Columns.Add("NRITOC")
            oDt.Columns.Add("SBITOC")
            oDt.Columns.Add("TDITES")
            oDt.Columns.Add("QRLCSC")
            oDt.Columns.Add("TTINTC")
            oDt.Columns.Add("NMONOC")

            For intCont = 0 To dtgOC_X_Item.Rows.Count - 1
                If dtgOC_X_Item.Rows(intCont).Cells(0).Value = True Then
                    oDr = oDt.NewRow
                    oDr.Item("NRPEMB") = dtgOC_X_Item.Rows(intCont).Cells("NRPEMB_1").Value
                    oDr.Item("NORCML") = dtgOC_X_Item.Rows(intCont).Cells("NORCML_1").Value
                    oDr.Item("NRPARC") = dtgOC_X_Item.Rows(intCont).Cells("NRPARC").Value
                    oDr.Item("NRITOC") = dtgOC_X_Item.Rows(intCont).Cells("NRITOC_1").Value
                    oDr.Item("SBITOC") = dtgOC_X_Item.Rows(intCont).Cells("SBITOC").Value
                    oDr.Item("TDITES") = dtgOC_X_Item.Rows(intCont).Cells("TDITES").Value
                    oDr.Item("QRLCSC") = dtgOC_X_Item.Rows(intCont).Cells("QRLCSC").Value
                    oDr.Item("TTINTC") = dtgOC_X_Item.Rows(intCont).Cells("TTINTC").Value
                    oDr.Item("NMONOC") = dtgOC_X_Item.Rows(intCont).Cells("NMONOC").Value
                    oDt.Rows.Add(oDr)
                    'End If
                End If
            Next intCont
            Dim frm As New frmObservacionesMasivo(Me.cmbCliente.pCodigo, oDt)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                llenar_Tab()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Agregar_FechasEstimadas()
        If dtgOC_X_Item.Rows.Count = 0 Then Exit Sub
        If dtgFechasEstimadas.Rows.Count = 1 Then Exit Sub
        Dim bAgregar As Boolean = Valida_Aprobaciones_Pendientes()
        If bAgregar = False Then Exit Sub
        Dim oCargaInternacional As New SOLMIN_SC.Entidad.OrdenCompra_BE
        oCargaInternacional.PNCCLNT = cmbCliente.pCodigo
        oCargaInternacional.PSTCMPCL = cmbCliente.pRazonSocial
        oCargaInternacional.PSNORCML = oPreEmbarqueEntidad.PSNORCML 'txtOrdenCompra.Text
        oCargaInternacional.PNNRITOC = oPreEmbarqueEntidad.PNNRITOC 'txtItem.Text
        oCargaInternacional.PNFMPDME = oPreEmbarqueEntidad.PNFMPDME
        oCargaInternacional.PNFMPIME = oPreEmbarqueEntidad.PNFMPIME
        oCargaInternacional.PNNRPEMB = oPreEmbarqueEntidad.PNNRPEMB
        Dim frmMantFecha As frmMantFechaEstimada
        frmMantFecha = New frmMantFechaEstimada(oCargaInternacional)
        frmMantFecha.StartPosition = FormStartPosition.CenterScreen
        frmMantFecha.ShowInTaskbar = False

        If (frmMantFecha.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Llenar_Fechas_Estimadas()
        End If
    End Sub
    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
            Case 1
            Case 2
                Agregar_Observaciones()
            Case 3
                Agregar_FechasEstimadas()
        End Select
    End Sub

    Private Sub dtgFechasEstimadas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgFechasEstimadas.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 7 Then
                Dim oCargaInternacional As New SOLMIN_SC.Entidad.OrdenCompra_BE
                oCargaInternacional.PNCCLNT = cmbCliente.pCodigo
                oCargaInternacional.PSTCMPCL = cmbCliente.pRazonSocial
                oCargaInternacional.PSNORCML = oPreEmbarqueEntidad.PSNORCML
                oCargaInternacional.PNNRITOC = oPreEmbarqueEntidad.PNNRITOC
                oCargaInternacional.PNNRPEMB = oPreEmbarqueEntidad.PNNRPEMB
                oCargaInternacional.PNNCRRLT = dtgFechasEstimadas.Rows(e.RowIndex).Cells("NCRRLT").Value
                Dim frmAprobacion As frmMantenimientoFechaEstimadaAprobar
                frmAprobacion = New frmMantenimientoFechaEstimadaAprobar(oCargaInternacional)
                frmAprobacion.ShowInTaskbar = False
                frmAprobacion.StartPosition = FormStartPosition.CenterScreen
                If dtgFechasEstimadas.Rows(e.RowIndex).Cells("Aprobacion").ToolTipText = "Aprobacion" Then
                    If (frmAprobacion.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        Llenar_Fechas_Estimadas()
                    End If
                End If
            End If
        End If
    End Sub

End Class
