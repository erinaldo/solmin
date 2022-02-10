Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmDetalleLiquidacionCombustible

#Region "Atributos"
  Private mNLQCMB As Int64
  Private mNPLCUN As String
  Private mCCMPN As String
  Private mCDVSN As String
  Private mCPLNDV As Double
#End Region

#Region "Properties"
  Public WriteOnly Property NLQCMB_1() As Int64
    Set(ByVal value As Int64)
      mNLQCMB = value
    End Set
  End Property

  Public WriteOnly Property NPLCUN_1() As String
    Set(ByVal value As String)
      mNPLCUN = value
    End Set
  End Property

  Public WriteOnly Property CCMPN_1() As String
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN_1() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV_1() As Double
    Set(ByVal value As Double)
      mCPLNDV = value
    End Set
  End Property
#End Region

#Region "Eventos"

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
  Private Sub frmDetalleLiquidacionCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Alinear_Columnas_Grilla()
    Me.Lista_Detalle_Liquidacion()
  End Sub
#End Region

#Region "Métodos"

  Private Sub Alinear_Columnas_Grilla()

    Me.dtgVales.AutoGenerateColumns = False
    Me.dtgOperacion.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgVales.ColumnCount - 1
      Me.dtgVales.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dtgOperacion.ColumnCount - 1
      Me.dtgOperacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next

  End Sub

  Private Sub Lista_Detalle_Liquidacion()

    Dim obj_Logica As New LiquidacionCombustible_BLL
    Dim objParametro As New Hashtable
    objParametro.Add("PNNLQCMB", Me.mNLQCMB)
    objParametro.Add("PSNPLCUN", Me.mNPLCUN)
    objParametro.Add("PSCCMPN", Me.mCCMPN)
    objParametro.Add("PSCDVSN", Me.mCDVSN)
    objParametro.Add("PNCPLNDV", Me.mCPLNDV)
    objParametro.Add("PSSESSLC", "L")
    Me.dtgVales.DataSource = obj_Logica.Listar_Detalle_Liquidacion_Vales_x_Tractos(objParametro)
    Me.dtgOperacion.DataSource = obj_Logica.Listar_Detalle_Liquidacion_Combustible_x_Tractos(objParametro)

  End Sub

#End Region


End Class
