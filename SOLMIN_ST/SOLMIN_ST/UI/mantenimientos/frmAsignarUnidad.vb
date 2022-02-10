Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Public Class frmAsignarUnidad

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String = ""
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNDV As Decimal = 0
    Public Property CPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property


    Private _RUC_TRANS As Decimal = 0
    Public Property RUC_TRANS() As Decimal
        Get
            Return _RUC_TRANS
        End Get
        Set(ByVal value As Decimal)
            _RUC_TRANS = value
        End Set
    End Property
    Private _DES_TRANS As String = ""
    Public Property DES_TRANS() As String
        Get
            Return _DES_TRANS
        End Get
        Set(ByVal value As String)
            _DES_TRANS = value
        End Set
    End Property


    Private _PLACA_TRACTO As String = ""
    Public Property PLACA_TRACTO() As String
        Get
            Return _PLACA_TRACTO
        End Get
        Set(ByVal value As String)
            _PLACA_TRACTO = value
        End Set
    End Property

    Private _DESC_TRACTO As String = ""
    Public Property DESC_TRACTO() As String
        Get
            Return _DESC_TRACTO
        End Get
        Set(ByVal value As String)
            _DESC_TRACTO = value
        End Set
    End Property


    Private _BREVTE_CONDUCTOR As String = ""
    Public Property BREVTE_CONDUCTOR() As String
        Get
            Return _BREVTE_CONDUCTOR
        End Get
        Set(ByVal value As String)
            _BREVTE_CONDUCTOR = value
        End Set
    End Property
    Private _DESC_CONDUCTOR As String = ""
    Public Property DESC_CONDUCTOR() As String
        Get
            Return _DESC_CONDUCTOR
        End Get
        Set(ByVal value As String)
            _DESC_CONDUCTOR = value
        End Set
    End Property



    Private Sub frmAsignarUnidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            ctbTransportista_1.Enabled = False
            ctbTracto_1.Enabled = True
            cmbConductor_1.Enabled = True
            If _CCMPN = "EZ" Then

                Me.ctbTransportista_1.pClear()
                obeTransportista.pCCMPN_Compania = _CCMPN
                obeTransportista.pNRUCTR_RucTransportista = "20100039207"
                Me.ctbTransportista_1.pCargar(obeTransportista)

                'obeTransportista = New Ransa.TypeDef.Transportista.TD_TransportistaPK
                'obeTransportista.pCCMPN_Compania = _CCMPN
                'Me.ctbTransportista_1.pCargar(obeTransportista)
                ctbTransportista_1_ExitFocusWithOutData_InformationChanged()

            Else

                Me.ctbTransportista_1.pClear()
                obeTransportista = New Ransa.TypeDef.Transportista.TD_TransportistaPK
                obeTransportista.pCCMPN_Compania = _CCMPN
                Me.ctbTransportista_1.pCargar(obeTransportista)
                ctbTransportista_1_ExitFocusWithOutData_InformationChanged()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ctbTransportista_1_ExitFocusWithOutData_InformationChanged()
        Try
          
            ctbTracto_1.pClear()
            cmbConductor_1.pClear()
            'Dim ruc
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            obeTracto.pCCMPN_Compania = _CCMPN
            obeTracto.pCDVSN_Division = _CDVSN
            obeTracto.pCPLNDV_Planta = _CPLNDV
            obeTracto.pNRUCTR_RucTransportista = ("" & ctbTransportista_1.pRucTransportista).Trim

            If _PLACA_TRACTO <> "" Then
                obeTracto.pNPLCUN_NroPlacaUnidad = _PLACA_TRACTO
            End If
            ctbTracto_1.pCargar(obeTracto)
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK


            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            obeConductor.pCCMPN_Compania = _CCMPN
            obeConductor.pCBRCNT_Brevete = ""
            If _BREVTE_CONDUCTOR <> "" Then
                obeConductor.pCBRCNT_Brevete = _BREVTE_CONDUCTOR
            End If
            obeConductor.pNRUCTR_RucTransportista = ("" & ctbTransportista_1.pRucTransportista).Trim
            cmbConductor_1.pCargar(obeConductor)

         
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'ctbTracto_1
            Dim msg As String = ""

            _RUC_TRANS = ("" & ctbTransportista_1.pRucTransportista).Trim
            _DES_TRANS = ("" & ctbTransportista_1.pRazonSocial).Trim

            _PLACA_TRACTO = ctbTracto_1.pNroPlacaUnidad
            _DESC_TRACTO = ctbTracto_1.pMarca_Modelo


            If _RUC_TRANS = 0 Then
                msg = "Seleccione Transportista"
            End If
            If _PLACA_TRACTO = "" Then
                msg = msg & Chr(13) & "Seleccione Tracto"
            End If

            If msg.Length > 0 Then
                MessageBox.Show(msg, "Verificar ingreso de valores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            _BREVTE_CONDUCTOR = cmbConductor_1.pBrevete
            _DESC_CONDUCTOR = cmbConductor_1.pNombreChofer
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
