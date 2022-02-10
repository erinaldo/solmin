Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO

Public Class frmAsigRecursoGT
#Region "Atributos"
    Private _obj_Entidad As New AsigRecursoGT_BE
    Private lintMedioTransporte As Int32 = 1
#End Region
#Region "Properties"
    Public Property obj_Entidad() As AsigRecursoGT_BE
        Get
            Return _obj_Entidad
        End Get
        Set(ByVal value As AsigRecursoGT_BE)
            _obj_Entidad = value
        End Set
    End Property


#End Region

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub frmAsigRecursoGT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarComboBox()
    End Sub

#Region "Metodos"
    Private Sub CargarComboBox()
        Me.CargarComboMedio()
        Me.CargarComboMotivo()
        Me.CargarCombos(lintMedioTransporte)
        Me.CargarComboOrigen()
        Me.CargarComboDestino()

    End Sub
    Private Sub CargarComboMotivo()
        Dim olistEstado As New List(Of TipoDatoGeneral)
        Dim obj_Logica As New TipoDatoGeneral_BLL
        Dim oEntidad As New TipoDatoGeneral

        olistEstado = obj_Logica.Lista_Tipo_Dato_General(_obj_Entidad.CCMPN, _obj_Entidad.CODVAR)

        oEntidad.CODIGO_TIPO = "0"
        oEntidad.DESC_TIPO = "[Seleccione]"
        olistEstado.Insert(0, oEntidad)

        CboMotivo.DataSource = olistEstado
        CboMotivo.DisplayMember = "DESC_TIPO"
        CboMotivo.ValueMember = "CODIGO_TIPO"
        CboMotivo.SelectedValue = "0"
    End Sub
    Private Sub CargarComboMedio()

        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me._obj_Entidad.CCMPN)
        Me.CboMedio.DataSource = objTabla.Copy
        Me.CboMedio.ValueMember = "CMEDTR"
        Me.CboMedio.DisplayMember = "TNMMDT"
        Me.CboMedio.SelectedValue = _obj_Entidad.CMEDTR

    End Sub
    Private Sub CargarCombos(ByVal medio As Integer)
        ' Tracto/Acoplado/Conductor1/Conductor2
        Try
            Select Case medio
                Case 1, 4, 5
                    Me.cboTracto.pClear()
                    Me.cboAcoplado.pClear()
                    Me.cboPrimerConductor.pClear()
                    Me.cboSegundoConductor.pClear()

                    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
                    obeTracto.pCCMPN_Compania = _obj_Entidad.CCMPN
                    obeTracto.pCDVSN_Division = _obj_Entidad.CDVSN
                    obeTracto.pCPLNDV_Planta = _obj_Entidad.CPLNDV
                    obeTracto.pNRUCTR_RucTransportista = _obj_Entidad.RucTransportista
                    cboTracto.pCargar(obeTracto)

                    Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
                    obeAcoplado.pCCMPN_Compania = _obj_Entidad.CCMPN
                    obeAcoplado.pCDVSN_Division = _obj_Entidad.CDVSN
                    obeAcoplado.pCPLNDV_Planta = _obj_Entidad.CPLNDV
                    obeAcoplado.pNRUCTR_RucTransportista = _obj_Entidad.RucTransportista
                    Me.cboAcoplado.pCargar(obeAcoplado)


                    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
                    obeConductor.pCCMPN_Compania = _obj_Entidad.CCMPN
                    obeConductor.pPlanta = _obj_Entidad.CPLNDV
                    obeConductor.pCDVSN = _obj_Entidad.CDVSN
                    obeConductor.pNRUCTR_RucTransportista = _obj_Entidad.RucTransportista
                    cboPrimerConductor.pCargar(obeConductor)


                    Dim obeConductor2 As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
                    obeConductor2.pCCMPN_Compania = _obj_Entidad.CCMPN
                    obeConductor2.pPlanta = _obj_Entidad.CPLNDV
                    obeConductor2.pCDVSN = _obj_Entidad.CDVSN
                    obeConductor2.pNRUCTR_RucTransportista = _obj_Entidad.RucTransportista
                    cboSegundoConductor.pCargar(obeConductor2)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarComboOrigen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New Localidad_BLL
        Dim lista As New List(Of LocalidadRuta)
        lista = obj.Listar_Localidades(_obj_Entidad.CCMPN)
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.CboOrigen.Etiquetas_Form = Etiquetas
        Me.CboOrigen.DataSource = lista
        Me.CboOrigen.ListColumnas = oListColum
        Me.CboOrigen.Cargas()
        Me.CboOrigen.DispleyMember = "TCMLCL"
        Me.CboOrigen.ValueMember = "CLCLD"






    End Sub
    Private Sub CargarComboDestino()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New Localidad_BLL
        Dim lista As New List(Of LocalidadRuta)
        lista = obj.Listar_Localidades(_obj_Entidad.CCMPN)
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.CboDestino.Etiquetas_Form = Etiquetas
        Me.CboDestino.DataSource = lista
        Me.CboDestino.ListColumnas = oListColum
        Me.CboDestino.Cargas()
        Me.CboDestino.DispleyMember = "TCMLCL"
        Me.CboDestino.ValueMember = "CLCLD"


    End Sub
    Private Function CargarObjectoAsigRecursoGT() As AsigRecursoGT_BE
        Dim oBE As New AsigRecursoGT_BE

        oBE.CCMPN = _obj_Entidad.CCMPN 'Codigo de Compañía
        oBE.FECHAINICIO = CType(HelpClass.CtypeDate(Me.DateTimePicker1.Value), Double)
        oBE.CTRMNC = _obj_Entidad.CTRMNC 'Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
        oBE.NGUITR = _obj_Entidad.NGUITR 'Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value
        oBE.MOTIVO = CboMotivo.SelectedValue 'Código combo motivo
        oBE.CMEDTR = CType(CboMedio.SelectedValue, Double) 'Código combo medio
        'pCTRSPT_CodTransportista
        oBE.TRACTO = cboTracto.pNroPlacaUnidad 'cboTracto.pNroPlacaUnidad
        oBE.ACOPLADO = cboAcoplado.pNroAcoplado 'cboAcoplado.pNroAcoplado
        oBE.CULUSA = MainModule.USUARIO 'MainModule.USUARIO

        
        oBE.TERMINAL = Ransa.Utilitario.HelpClass.NombreMaquina

        If Not Me.CboOrigen.Resultado Is Nothing Then
            oBE.COD_LOCALIDAD_ORIGEN = CType(Me.CboOrigen.Resultado, SOLMIN_ST.ENTIDADES.mantenimientos.LocalidadRuta).CLCLD
        Else
            oBE.COD_LOCALIDAD_ORIGEN = 0
        End If

        If Not Me.CboDestino.Resultado Is Nothing Then
            oBE.COD_LOCALIDAD_DESTINO = CType(Me.CboDestino.Resultado, SOLMIN_ST.ENTIDADES.mantenimientos.LocalidadRuta).CLCLD
        Else
            oBE.COD_LOCALIDAD_DESTINO = 0
        End If


        oBE.OBS = txtObservacion.Text 'Texto control observación
        oBE.CONDUCTOR1 = cboPrimerConductor.pBrevete 'Me.cmbConductor.pBrevete
        oBE.CONDUCTOR2 = cboSegundoConductor.pBrevete 'Me.cmbSegundoConductor.pBrevete


        Return oBE

    End Function

    Private Function Validar() As Boolean
        Dim bResultado As Boolean = True

        If CboMotivo.SelectedValue = 0 Then
            bResultado = False
            HelpClass.MsgBox("Seleccione Motivo")
        End If
        Return bResultado
    End Function
#End Region



    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim oBE As New AsigRecursoGT_BE()
        Dim oBL As New RecursosReasignado_BLL()
        Try
            If Validar() Then
                oBE = CargarObjectoAsigRecursoGT()
                Dim MenssaggeInfo As String = oBL.Insertar_Asignacion_Recurso(oBE)

                If MenssaggeInfo <> "" Then
                    MessageBox.Show(MenssaggeInfo, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class

