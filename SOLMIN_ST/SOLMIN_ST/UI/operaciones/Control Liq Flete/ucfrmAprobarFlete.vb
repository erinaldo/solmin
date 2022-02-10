Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Public Class ucfrmAprobarFlete
    Public AprobSugerido As String = ""
    'Private _MrgAprobacion As Double = 0
    Public MrgAprobacion As Double = 0
    'Private _CodCompanía As String = ""
    Public CodCompania As String = ""
    'Private _CodDivision As String = ""
    Public CodDivision As String = ""
    'Private _IdTransportista As String = ""
    Public CodTransportista As Decimal = 0
    'Private _GuiaTransporte As String = ""
    Public GuiaTransporte As Decimal = 0
    'Private _TipoViaje As String = ""
    Public TipoViaje As String = ""
    'Private _NroViaje As String = ""
    Public NroViaje As Decimal = 0
    'Private _oFrmPadre As Form

    'Public Property AprobSugerido() As String
    '    Get
    '        Return _AprobSugerido
    '    End Get
    '    Set(ByVal value As String)
    '        _AprobSugerido = value
    '    End Set
    'End Property
    'Public Property MrgAprobacion() As Double
    '    Get
    '        Return _MrgAprobacion
    '    End Get
    '    Set(ByVal value As Double)
    '        _MrgAprobacion = value
    '    End Set
    'End Property
    'Public Property CodCompanía() As String
    '    Get
    '        Return _CodCompanía
    '    End Get
    '    Set(ByVal value As String)
    '        _CodCompanía = value
    '    End Set
    'End Property
    'Public Property CodDivision() As String
    '    Get
    '        Return _CodDivision
    '    End Get
    '    Set(ByVal value As String)
    '        _CodDivision = value
    '    End Set
    'End Property
    'Public Property IdTransportista() As String
    '    Get
    '        Return _IdTransportista
    '    End Get
    '    Set(ByVal value As String)
    '        _IdTransportista = value
    '    End Set
    'End Property
    'Public Property GuiaTransporte() As String
    '    Get
    '        Return _GuiaTransporte
    '    End Get
    '    Set(ByVal value As String)
    '        _GuiaTransporte = value
    '    End Set
    'End Property
    'Public Property TipoViaje() As String
    '    Get
    '        Return _TipoViaje
    '    End Get
    '    Set(ByVal value As String)
    '        _TipoViaje = value
    '    End Set
    'End Property
    'Public Property NroViaje() As String
    '    Get
    '        Return _NroViaje
    '    End Get
    '    Set(ByVal value As String)
    '        _NroViaje = value
    '    End Set
    'End Property

    Private Sub ucfrmAprobarFlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            Me.txtAprobSugerido.Text = ""
            Me.txtMrgAprobacion.Text = ""
            Me.txtAprobadorPor.Text = ""
            Me.txtAprobSugerido.Text = AprobSugerido
            Me.txtMrgAprobacion.Text = Format(Val(CDec(MrgAprobacion)), "##0.00")
            Me.txtObs.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
    'Public Sub InicializarFormulario(oFrmPadre As Form)
    '    _oFrmPadre = oFrmPadre
    'End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim oFiltro As New TD_obj_ActualizarStatusSeguinientoAprobacion
            Dim oGuiaTransportista As New GuiaTransportista_BLL
            If txtAprobadorPor.Text = "" Then
                MessageBox.Show("Ingresar Aprobador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
                'ElseIf dtFeInicial.Text = "" Then
                '    MessageBox.Show("Ingresar Fecha de Aprobación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Sub
            End If
            'oFiltro.pClear()
            With oFiltro
                .pCCMPN = CodCompania
                .pCDVSN = CodDivision
                .pCTRMNC = CodTransportista
                .pNGUITR = GuiaTransporte
                .pTIPVIAJ = TipoViaje
                .pNROVIAJ = NroViaje
                .pAPRBOP = Me.txtAprobadorPor.Text
                .pFCHAPR = Format(CDate(Me.dtFeInicial.Text), "yyyyMMdd")
                .pOBSAPR = Me.txtObs.Text
            End With


            'Aceptar_Envio_Aprobacion_Viaje
            oGuiaTransportista.Aceptar_Envio_Aprobacion_Viaje(oFiltro)
            'If (oGuiaTransportista.Actualizar_Status_Seguiniento_Aprobacion(oFiltro) = 1) Then
            MessageBox.Show("Viaje aprobado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = Windows.Forms.DialogResult.OK
            'Dim oFrmPadre As New frmLiqFleteAprobMargen_Pre()
            'oFrmPadre = _oFrmPadre
            'oFrmPadre.Buscar()
            'Me.Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class