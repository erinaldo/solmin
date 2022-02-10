Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data

Public Class frmBuscarAcoplado_Conductor
    Public _NumeroRuc As String
    Public strAcoplado As String
    Public strConductor As String
    Private _CCMPN As String
    Private _CDVSN As String
    Private _CPLNDV As Double

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property
    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property


    Private Sub frmBuscarAcoplado_Conductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Acoplado(_NumeroRuc, strConductor)
    End Sub

    Private Sub Cargar_Acoplado(ByVal RucTransportista As String, ByVal Brevete As String)
        Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
        Try
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
            obeAcoplado.pCCMPN_Compania = _CCMPN
            obeAcoplado.pCDVSN_Division = _CDVSN
            obeAcoplado.pCPLNDV_Planta = _CPLNDV
            obeAcoplado.pNRUCTR_RucTransportista = RucTransportista
            If Not strAcoplado.Trim.Equals("") Then
                obeAcoplado.pNPLCAC_NroAcoplado = strAcoplado
            End If
            Me.ctbAcoplado.pCargar(obeAcoplado)

            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            obeConductor.pCCMPN_Compania = CCMPN
            obeConductor.pNRUCTR_RucTransportista = RucTransportista
            obeConductor.pCBRCNT_Brevete = Brevete
            Me.cmbConductor.pCargar(obeConductor)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
