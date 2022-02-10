Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmOpRptLiquidacionGasto

#Region "Variables"

  Private mFECFIN As Double
  Private mFECINI As Double
  Private mNPLCUN As String
  Private mCBRCNT As String
  Private mCCLNT As Double

#End Region

#Region "Properties"

  Public Property CCLNT() As Double
    Get
      Return mCCLNT
    End Get
    Set(ByVal value As Double)
      mCCLNT = value
    End Set
  End Property

  Public Property CBRCNT() As String
    Get
      Return mCBRCNT
    End Get
    Set(ByVal value As String)
      mCBRCNT = value
    End Set
  End Property

  Public Property NPLCUN() As String
    Get
      Return mNPLCUN
    End Get
    Set(ByVal value As String)
      mNPLCUN = value
    End Set
  End Property

  Public Property FECINI() As Double
    Get
      Return mFECINI
    End Get
    Set(ByVal value As Double)
      mFECINI = value
    End Set
  End Property

  Public Property FECFIN() As Double
    Get
      Return mFECFIN
    End Get
    Set(ByVal value As Double)
      mFECFIN = value
    End Set
  End Property

    Private _CCMPN As String

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


#End Region

#Region "Metodos"

    Private Sub CargarTracto()
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoPK
        obeTracto.pCCMPN_Compania = "EZ" '_CCMPN
        ctbVehiculo.pCargar(obeTracto)
    End Sub

    Private Sub CargarConductor()
        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        obeConductor.pCCMPN_Compania = "EZ" '_CCMPN
        ctbConductor.pCargar(obeConductor)
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.rbtnTodos.Checked = True Then
            mNPLCUN = ""
            mCBRCNT = ""
            Me.Tag = 0
        ElseIf Me.rbtnCliente.Checked = True Then
            If Me.txtClienteFiltro.pCodigo = 0 Then
                HelpClass.MsgBox("Seleccione un Cliente", MessageBoxIcon.Information)
                Exit Sub
            End If
            mCCLNT = Me.txtClienteFiltro.pCodigo
            Me.Tag = 1
        ElseIf Me.rbtnConductor.Checked = True Then
            If Me.ctbConductor.pNombreChofer.Trim.Equals("") Then
                HelpClass.MsgBox("Seleccione un Conductor", MessageBoxIcon.Information)
                Exit Sub
            End If
            mCBRCNT = Me.ctbConductor.pBrevete
            mNPLCUN = ""
            Me.Tag = 2
        ElseIf Me.rbtnTracto.Checked = True Then
            If Me.ctbVehiculo.pNroPlacaUnidad.Trim.Equals("") Then
                HelpClass.MsgBox("Seleccione un Tracto", MessageBoxIcon.Information)
                Exit Sub
            End If
            mNPLCUN = Me.ctbVehiculo.pNroPlacaUnidad
            mCBRCNT = ""
            Me.Tag = 3
        End If
        If mCCLNT = 0 And mNPLCUN Is Nothing And mCBRCNT Is Nothing Then
            HelpClass.MsgBox("Seleccione un Opción", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.mFECINI = HelpClass.CDate_a_Numero8Digitos(Me.dtpLimiteInicial.Value)
        Me.mFECFIN = HelpClass.CDate_a_Numero8Digitos(Me.dtpLimiteFinal.Value)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmOpRptLiquidacionGasto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.txtClienteFiltro.Enabled = False
    Me.ctbConductor.Enabled = False
    Me.ctbVehiculo.Enabled = False
        CargarTracto()
        CargarConductor()
  End Sub

  Private Sub rbtnCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCliente.CheckedChanged, rbtnConductor.CheckedChanged, rbtnTracto.CheckedChanged
    If Me.rbtnTodos.Checked = True Then
      Me.txtClienteFiltro.Enabled = False
      Me.ctbVehiculo.Enabled = False
      Me.ctbConductor.Enabled = False
    ElseIf Me.rbtnCliente.Checked = True Then
      Me.txtClienteFiltro.Enabled = True
      Me.ctbVehiculo.Enabled = False
      Me.ctbConductor.Enabled = False
    ElseIf Me.rbtnTracto.Checked = True Then
      Me.ctbVehiculo.Enabled = True
      Me.txtClienteFiltro.Enabled = False
      Me.ctbConductor.Enabled = False
    ElseIf Me.rbtnConductor.Checked = True Then
      Me.ctbConductor.Enabled = True
      Me.txtClienteFiltro.Enabled = False
      Me.ctbVehiculo.Enabled = False
    End If
  End Sub
#End Region
 
   
  
End Class
