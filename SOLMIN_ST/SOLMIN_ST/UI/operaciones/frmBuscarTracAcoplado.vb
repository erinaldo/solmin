Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO


Public Class frmBuscarTracAcoplado

    'Public Sub New(ByVal VerControles As Boolean, ByVal FTRTSG As String)

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()
    '    ' Add any initialization after the InitializeComponent() call.
    '    If VerControles = False Then
    '        NoMostrar()
    '    End If


    'End Sub

#Region "Atributo"
    Private _obj_Entidad As New Detalle_Solicitud_Transporte
    Private _Registro_AgenciasRansa As Boolean = False
    Private lstr_codigo_cliente As String = ""
    Private lintMedioTransporte As Int32 = 0
    Private oSeguridad As NEGOCIO.Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private strResultado As String = ""
#End Region

#Region "Properties"
    'Public Property obj_Entidad() As Detalle_Solicitud_Transporte
    '    Get
    '        Return _obj_Entidad
    '    End Get
    '    Set(ByVal value As Detalle_Solicitud_Transporte)
    '        _obj_Entidad = value
    '    End Set
    'End Property

    'Private _CLCLOR As Decimal = 0
    'Public Property CLCLOR() As Decimal
    '    Get
    '        Return _CLCLOR
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _CLCLOR = value
    '    End Set
    'End Property

    'Private _CLCLDS As Decimal = 0
    'Public Property CLCLDS() As Decimal
    '    Get
    '        Return _CLCLDS
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _CLCLDS = value
    '    End Set
    'End Property

    'Private _NPRASG As Decimal = 0

    'Public Property NPRASG() As Decimal
    '    Get
    '        Return _NPRASG
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NPRASG = value
    '    End Set
    'End Property


    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _RucTransportista As String = ""
    Public Property RucTransportista() As String
        Get
            Return _RucTransportista
        End Get
        Set(ByVal value As String)
            _RucTransportista = value
        End Set
    End Property

    'Private RucTransportista As String

    Private _TRANSPORTISTA As String = ""
    Public Property TRANSPORTISTA() As String
        Get
            Return _TRANSPORTISTA
        End Get
        Set(ByVal value As String)
            _TRANSPORTISTA = value
        End Set
    End Property

    'Private _CODTRACTO As String = ""
    'Public Property CODTRACTO() As String
    '    Get
    '        Return _CODTRACTO
    '    End Get
    '    Set(ByVal value As String)
    '        _CODTRACTO = value
    '    End Set
    'End Property
    Private _TRACTO As String = ""
    Public Property TRACTO() As String
        Get
            Return _TRACTO
        End Get
        Set(ByVal value As String)
            _TRACTO = value
        End Set
    End Property

    'Private _CODACOPLADO As String = ""
    'Public Property CODACOPLADO() As String
    '    Get
    '        Return _CODACOPLADO
    '    End Get
    '    Set(ByVal value As String)
    '        _CODACOPLADO = value
    '    End Set
    'End Property
    Private _ACOPLADO As String = ""
    Public Property ACOPLADO() As String
        Get
            Return _ACOPLADO
        End Get
        Set(ByVal value As String)
            _ACOPLADO = value
        End Set
    End Property

    'Private _NUMREQT As Decimal = 0
    'Public Property NUMREQT() As Decimal
    '    Get
    '        Return _NUMREQT
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NUMREQT = value
    '    End Set
    'End Property

    'Private _Entidad_Unid_Prog As New ENTIDADES.Programacion_Unidad

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNDV As Double = 0

    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property


    'Private _NDCORM As Decimal = 0D
    'Public Property NDCORM() As Decimal
    '    Get
    '        Return _NDCORM
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NDCORM = value
    '    End Set
    'End Property


    'Private _PNCDTR As String = ""
    'Public Property PNCDTR() As String
    '    Get
    '        Return _PNCDTR
    '    End Get
    '    Set(ByVal value As String)
    '        _PNCDTR = value
    '    End Set
    'End Property

    REM ECM-HUNDRED-20150821-INICIO
    'Private _CDDRSP As String = ""
    'Public Property CDDRSP() As String
    '    Get
    '        Return _CDDRSP
    '    End Get
    '    Set(ByVal value As String)
    '        _CDDRSP = value
    '    End Set
    'End Property
    REM ECM-HUNDRED-20150821-FIN

    Public WriteOnly Property MedioTransporte() As Int32
        Set(ByVal value As Int32)
            lintMedioTransporte = value
        End Set
    End Property


#End Region

#Region "Eventos"

    Private Sub frmReasignarRecurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CargarTransportista()
            Me.lstr_codigo_cliente = Me._obj_Entidad.CCLNT
            'Asignacion_OS_Agencia_Ransa()

            'If _NDCORM > 0D Then
            '    _Registro_AgenciasRansa = True
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged, cboTransportista.ExitFocusWithOutData
    '    Try
    '        Select Case Me.lintMedioTransporte
    '            Case 1, 4, 5
    '                Me.cboTracto.pClear()
    '                Me.cboAcoplado.pClear()
    '                Me.cmbConductor.pClear()
    '                Me.cmbSegundoConductor.pClear()
    '                Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    '                obeTracto.pCCMPN_Compania = _CCMPN
    '                obeTracto.pCDVSN_Division = _CDVSN
    '                obeTracto.pCPLNDV_Planta = _CPLNDV
    '                obeTracto.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '                cboTracto.pCargar(obeTracto)
    '                Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    '                obeAcoplado.pCCMPN_Compania = _CCMPN
    '                obeAcoplado.pCDVSN_Division = _CDVSN
    '                obeAcoplado.pCPLNDV_Planta = _CPLNDV
    '                obeAcoplado.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '                Me.cboAcoplado.pCargar(obeAcoplado)









    '                Me.hgReasignarRecurso.ValuesSecondary.Heading = "   "


    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    'Private Sub Asignacion_OS_Agencia_Ransa()
    '    'FRAGMENTO DE CODIGO HARD-CODING, AGENCIAS RANSA : 22-04-2010
    '    _Registro_AgenciasRansa = True
    'End Sub

    'Private Sub Generar_Operacion_Agencias_Ransa()
    '    Try

    '        Dim objParametros As New Hashtable
    '        Dim objAgenciasRansa As New NEGOCIO.Operaciones.OrdenServicioAgenciaRansa_BLL
    '        objParametros.Add("HORA", HelpClass.NowNumeric)
    '        objParametros.Add("HOY", HelpClass.TodayNumeric)
    '        ' objParametros.Add("CCLNT", "000606")
    '        objParametros.Add("CCLNT", lstr_codigo_cliente)

    '        objAgenciasRansa.Registrar_Orden_Servicio(objParametros)

    '    Catch ex As Exception
    '        HelpClass.MsgBox(ex.ToString)
    '    End Try
    'End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = _CCMPN
        If _RucTransportista <> "" Then
            obeTransportista.pNRUCTR_RucTransportista = _RucTransportista
        End If
        cboTransportista.pCargar(obeTransportista)

        If RucTransportista <> "" Then
            cboTransportista_InformationChanged()
        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try
            RucTransportista = Me.cboTransportista.pRucTransportista
            TRANSPORTISTA = Me.cboTransportista.pRazonSocial
            'CODTRACTO = Me.cboTracto.pNroPlacaUnidad
            TRACTO = cboTracto.pNroPlacaUnidad
            'CODACOPLADO = Me.cboAcoplado.pNroAcoplado
            ACOPLADO = cboAcoplado.pNroAcoplado
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub



    'Private Function ValidarPlacasAsignacion(ByVal Tipo_Recurso As String, ByVal Placa As String) As String
    '    If Placa = "" Then Return ""
    '    Dim objEntidad As New Solicitud_Transporte
    '    Dim objNegocio As New Solicitud_Transporte_BLL
    '    Dim msgVal As String = ""
    '    Dim recurso As String = ""
    '    objEntidad.CCMPN = _CCMPN
    '    objEntidad.CDVSN = _CDVSN
    '    objEntidad.CPLNDV = _CPLNDV
    '    Select Case Tipo_Recurso
    '        Case "T"
    '            objEntidad.NPLRCS = Placa
    '            objEntidad.STPRCS = "T"
    '            recurso = "Tracto"
    '        Case "A"
    '            objEntidad.NPLRCS = Placa
    '            objEntidad.STPRCS = "A"
    '            recurso = "Acoplado"
    '    End Select

    '    objEntidad.NRUCTR = cboTransportista.pRucTransportista

    '    Dim dsDatosPlaca As New DataSet
    '    Dim dtPropPlaca As New DataTable
    '    Dim dtDatoPlacaAsigando As New DataTable
    '    If cboTransportista.pPropioTercero = "P" Then
    '        dsDatosPlaca = objNegocio.Validacion_Placa_Propietario_Placa(objEntidad)
    '        dtDatoPlacaAsigando = dsDatosPlaca.Tables(0).Copy
    '        dtPropPlaca = dsDatosPlaca.Tables(1).Copy



    '        If dtPropPlaca.Rows.Count > 0 Then

    '            Dim RucPropietarioRecurso As String = ("" & dtPropPlaca.Rows(0)("NRUCTR")).ToString.Trim
    '            Dim DesRucPropietarioRecurso As String = ("" & dtPropPlaca.Rows(0)("TCMTRT")).ToString.Trim
    '            If RucPropietarioRecurso <> cboTransportista.pRucTransportista Then
    '                Dim dtAlquilerVigente As New DataTable
    '                Dim ExisteAlquiler As Boolean = False
    '                Dim NRALQT As Decimal = 0
    '                ' dtAlquilerVigente = objNegocio.Mostar_Alquiler_VIGENTE(_CCMPN, _CDVSN, RucPropietarioRecurso, Tipo_Recurso, Placa, dtpFechaAtencionServicio.Value.ToString("yyyyMMdd"))
    '                For Each Item As DataRow In dtAlquilerVigente.Rows
    '                    If ("" & Item("FLGAPR")).ToString.Trim = "X" Then
    '                        ExisteAlquiler = True
    '                        Exit For
    '                    End If
    '                Next
    '                If dtAlquilerVigente.Rows.Count = 0 Then
    '                    msgVal = "El " & recurso & " " & Placa & " no cuenta con alquiler(vigente)."
    '                Else
    '                    If ExisteAlquiler = False Then
    '                        msgVal = "El alquiler en el " & recurso & " " & Placa & " requiere ser aprobado."
    '                    End If
    '                End If

    '            End If


    '        End If

    '    End If
    '    Return msgVal
    'End Function


    'Private Sub ctbTracto_Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If Me.cboTracto.pNroPlacaUnidad.Trim.Equals("") Then
    '            Me.cboTracto.pClear()
    '            Me.cboAcoplado.pClear()
    '            Exit Sub
    '        End If
    '        Dim obj_Entidad As New TransportistaTracto
    '        Dim obj_Logica As New TransportistaTracto_BLL
    '        obj_Entidad.NPLCUN = Me.cboTracto.pNroPlacaUnidad
    '        obj_Entidad.CCMPN = CCMPN
    '        obj_Entidad = obj_Logica.Obtener_Informacion_Tracto(obj_Entidad)
    '        If obj_Entidad.NPLCAC.Trim = "" Then Me.cboAcoplado.pClear()

    '        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    '        obeAcoplado.pCCMPN_Compania = _CCMPN
    '        Me.cboAcoplado.pCargar(obeAcoplado)

    '        'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
    '        'obeConductor.pCCMPN_Compania = _CCMPN
    '        'obeConductor.pPlanta = _CPLNDV
    '        'obeConductor.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '        'obeConductor.pCBRCNT_Brevete = obj_Entidad.CBRCNT.Trim
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

#End Region

#Region "Metodos y Funciones"

    

    Private Function Validar_Recursos_Asignados() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        'Evaluando la Asignación: Transportista, Tracto, Acoplado y Conductor
        If Me.cboTransportista.pRazonSocial.Trim.Equals("") Then
            lstr_validacion += "* TRANSPORTISTA" & Chr(13)
        End If

        'If Me.lintMedioTransporte = 5 Then
        '  If Me.cboEmpujador.SelectedValue Is Nothing Then
        '    lstr_validacion += "* TRACTO" & Chr(13)
        '  End If
        'Else
        If Me.cboTracto.pNroPlacaUnidad.Trim.Equals("") Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If
        'End If
        '

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

   
    

    

    

 

#End Region

    

    

     

   


    Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged, cboTransportista.ExitFocusWithOutData
        Try
         
            Me.cboTracto.pClear()
            Me.cboAcoplado.pClear()
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            obeTracto.pCCMPN_Compania = _CCMPN
            obeTracto.pCDVSN_Division = _CDVSN
            obeTracto.pCPLNDV_Planta = _CPLNDV
            obeTracto.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            cboTracto.pCargar(obeTracto)
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
            obeAcoplado.pCCMPN_Compania = _CCMPN
            obeAcoplado.pCDVSN_Division = _CDVSN
            obeAcoplado.pCPLNDV_Planta = _CPLNDV
            obeAcoplado.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            Me.cboAcoplado.pCargar(obeAcoplado)
            'Me.Cargar_Combo_Acoplado_Conductor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 

    'Private Sub Cargar_Combo_Acoplado_Conductor(Optional ByVal strConductor As String = "", Optional ByVal strSegundoConductor As String = "")
    '    Try
    '        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
    '        obeConductor.pCCMPN_Compania = _CCMPN
    '        obeConductor.pPlanta = _CPLNDV
    '        obeConductor.pCBRCNT_Brevete = strConductor
    '        obeConductor.pNRUCTR_RucTransportista = cboTransportista.pRucTransportista
    '        Me.cmbConductor.pCargar(obeConductor)

    '        obeConductor.pCBRCNT_Brevete = strSegundoConductor
    '        Me.cmbSegundoConductor.pCargar(obeConductor)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", Me._CCMPN)
        objHashTable.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

     

    'Sub cargar_Datos_PreAsignacion(Optional ByVal trans As Long = 0, Optional ByVal tracto As String = "", Optional ByVal acoplado As String = "", Optional ByVal conductor1 As String = "", Optional ByVal conductor2 As String = "")

    '    'Cargar transportista
    '    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    '    obeTransportista.pCCMPN_Compania = _CCMPN
    '    obeTransportista.pNRUCTR_RucTransportista = trans.ToString.Trim
    '    cboTransportista.pCargar(obeTransportista)

    '    'Cargar Tracto
    '    cboTracto.pClear()
    '    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    '    obeTracto.pCCMPN_Compania = _CCMPN
    '    obeTracto.pCDVSN_Division = _CDVSN
    '    obeTracto.pCPLNDV_Planta = _CPLNDV
    '    obeTracto.pNRUCTR_RucTransportista = trans.ToString.Trim
    '    obeTracto.pNPLCUN_NroPlacaUnidad = tracto.ToString.Trim
    '    Me.cboTracto.pCargar(obeTracto)

    '    'Cargar Acoplado
    '    cboAcoplado.pClear()
    '    Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    '    obeAcoplado.pCCMPN_Compania = _CCMPN
    '    obeAcoplado.pCDVSN_Division = _CDVSN
    '    obeAcoplado.pCPLNDV_Planta = _CPLNDV
    '    obeAcoplado.pNRUCTR_RucTransportista = trans.ToString.Trim
    '    obeAcoplado.pNPLCAC_NroAcoplado = acoplado.ToString.Trim
    '    Me.cboAcoplado.pCargar(obeAcoplado)

    '    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
    '    obeConductor.pCCMPN_Compania = _CCMPN
    '    obeConductor.pPlanta = _CPLNDV
    '    obeConductor.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '    obeConductor.pCBRCNT_Brevete = conductor1.ToString.Trim
    '    'obeConductor.pNRUCTR_RucTransportista = txtTransportista.pRucTransportista

    '    obeConductor.pCBRCNT_Brevete = conductor2.ToString.Trim

    'End Sub

    

   
End Class
