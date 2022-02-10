Imports System.Text
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO

Public Class frmAgregarUnidProg_JuntaReq

    Private _pEntidad As Programacion_Unidad
    Public Property pEntidad() As Programacion_Unidad
        Get
            Return _pEntidad
        End Get
        Set(ByVal value As Programacion_Unidad)
            _pEntidad = value
        End Set
    End Property

    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _pCDVSN As String
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    Private _pCPLNDV As Decimal
    Public Property pCPLNDV() As Decimal
        Get
            Return _pCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _pCPLNDV = value
        End Set
    End Property

    Private Sub frmAgregarUnidProg_JuntaReq_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    End Sub

    Private Sub frmAgregarUnidProg_JuntaReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        CargarTransportista()
        Cargar_Conductores()

    End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = _pCCMPN
        Me.txtTransportista.pCargar(obeTransportista)
    End Sub

    Sub Cargar_Conductores(Optional ByVal conductor1 As String = "", Optional ByVal conductor2 As String = "")

        Me.cmbConductor.pClear()
        Me.cmbSegundoConductor.pClear()

        'Cargar Conductores
        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        obeConductor.pCCMPN_Compania = _pCCMPN
        obeConductor.pCBRCNT_Brevete = conductor1.ToString.Trim
        'obeConductor.pNRUCTR_RucTransportista = txtTransportista.pRucTransportista
        Me.cmbConductor.pCargar(obeConductor)
        obeConductor.pCBRCNT_Brevete = conductor2.ToString.Trim
        Me.cmbSegundoConductor.pCargar(obeConductor)

    End Sub

    Private Sub txtTransportista_InformationChanged() Handles txtTransportista.InformationChanged
        Try
            Cargar_Tracto_Acoplado(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cargar_Tracto_Acoplado(Optional ByVal tracto As String = "", Optional ByVal acoplado As String = "")

        Me.txtTracto.pClear()
        Me.txtAcoplado.pClear()

        'Cargar Tracto
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = _pCCMPN
        obeTracto.pCDVSN_Division = _pCDVSN
        obeTracto.pCPLNDV_Planta = _pCPLNDV
        obeTracto.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        obeTracto.pNPLCUN_NroPlacaUnidad = tracto
        Me.txtTracto.pCargar(obeTracto)

        'Cargar Acoplado
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        obeAcoplado.pCCMPN_Compania = _pCCMPN
        obeAcoplado.pCDVSN_Division = _pCDVSN
        obeAcoplado.pCPLNDV_Planta = _pCPLNDV
        obeAcoplado.pNRUCTR_RucTransportista = Me.txtTransportista.pRucTransportista
        obeAcoplado.pNPLCAC_NroAcoplado = acoplado
        Me.txtAcoplado.pCargar(obeAcoplado)

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try

            Dim msgValidacion As String = Valida_Campos()
            If msgValidacion.Length > 0 Then
                MessageBox.Show("Seleccionar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else

                Dim ObjEntidad As New Programacion_Unidad
                Dim ObjNegocio As New Programacion_Unid_Junta_BLL

                With ObjEntidad

                    .NPLNJT = _pEntidad.NPLNJT
                    .NCRRPL = _pEntidad.NCRRPL
                    .NUMREQT = _pEntidad.NUMREQT
                    '.NCRRPA = se genera
                    .FPRASG = CDec(String.Format("{0:yyyyMMdd}", dtpFecha.Value))
                    .NRUCTR = txtTransportista.pRucTransportista
                    .NPLCUN = txtTracto.pNroPlacaUnidad
                    .NPLCAC = txtAcoplado.pNroAcoplado
                    .CBRCNT = cmbConductor.pBrevete
                    .CBRCN2 = cmbSegundoConductor.pBrevete
                    .TOBS = txtObservaciones.Text
                    .CUSCRT = MainModule.USUARIO
                    .NTRMCR = Environment.MachineName

                End With

                ObjNegocio.Insertar_Unidades_RequerimientosJunta(ObjEntidad)

                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Valida_Campos() As String

        Dim sbMensaje As New StringBuilder

        If txtTransportista.pRucTransportista.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Transportista")
        End If

        If txtTracto.pNroPlacaUnidad.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Tracto")
        End If

        If cmbConductor.pBrevete.ToString.Trim.Length = 0 Then
            sbMensaje.AppendLine("* Conductor 1")
        End If

        Return sbMensaje.ToString
    End Function

    Private Sub btnSalir_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
