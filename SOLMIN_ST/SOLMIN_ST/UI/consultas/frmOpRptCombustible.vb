Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmOpRptCombustible

#Region "Propiedades"

  Public ReadOnly Property FECINI() As Double
    Get
      Return CType(HelpClass.CtypeDate(Me.dtpLimiteInicial.Value), Double)
    End Get
  End Property

  Public ReadOnly Property FECFIN() As Double
    Get
      Return CType(HelpClass.CtypeDate(Me.dtpLimiteFinal.Value), Double)
    End Get
  End Property

  Public ReadOnly Property CCLNT() As Int64
    Get
      Return Me.txtClienteFiltro.pCodigo
    End Get
  End Property

  Public ReadOnly Property NPLCUN() As String
    Get
      Return Me.ctbVehiculo.pNroPlacaUnidad
    End Get
  End Property

  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Int32 = 0
  Private _NRUCTR As String = ""

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int32
    Set(ByVal value As Int32)
      _CPLNDV = value
    End Set
  End Property

  Public WriteOnly Property NRUCTR() As String
    Set(ByVal value As String)
      _NRUCTR = value
    End Set
  End Property

#End Region

  Private Sub CargarVehiculos()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    obeTracto.pCCMPN_Compania = Me._CCMPN
    obeTracto.pCDVSN_Division = Me._CDVSN
    obeTracto.pCPLNDV_Planta = Me._CPLNDV
    obeTracto.pNRUCTR_RucTransportista = Me._NRUCTR
    ctbVehiculo.pCargar(obeTracto)
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    If Me.rbtFechaLiquidacion.Checked = True Then
      Me.Tag = 2
    ElseIf Me.rbtFechaAsignacion.Checked = True Then
      Me.Tag = 1
    ElseIf Me.rbtFechaRendimiento.Checked = True Then
      Me.Tag = 3
    End If
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click, btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub Seleccion_Filtro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechaAsignacion.CheckedChanged, rbtFechaLiquidacion.CheckedChanged, rbtFechaRendimiento.CheckedChanged
    Select Case sender.Name
      Case "rbtFechaAsignacion", "rbtFechaRendimiento"
        If sender.Checked = True Then
          Me.txtClienteFiltro.Enabled = False
          Me.rbtnCliente.Enabled = False
          Me.rbtnTracto.Checked = True
        End If
      Case "rbtFechaLiquidacion"
        If sender.Checked = True Then
          Me.txtClienteFiltro.Enabled = True
          Me.rbtnCliente.Enabled = True
          Me.rbtnCliente.Checked = True
        End If
    End Select
  End Sub

  Private Sub frmOpRptCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CargarVehiculos()
  End Sub
End Class
