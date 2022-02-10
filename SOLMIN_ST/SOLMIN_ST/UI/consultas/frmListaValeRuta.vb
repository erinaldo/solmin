Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmListaValeRuta

#Region "Variables"

  Private _NPLCUN As String = ""
  Private _CCMPN As String = ""
  Private _objEntidad As LiquidacionCombustible

#End Region

#Region "Properties"

  Public WriteOnly Property NPLCUN() As String
    Set(ByVal value As String)
      _NPLCUN = value
    End Set
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public ReadOnly Property objEntidad() As LiquidacionCombustible
    Get
      Return _objEntidad
    End Get
  End Property

#End Region

#Region "Eventos"

  Private Sub frmListaValeRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Dim objLogica As New LiquidacionCombustible_BLL
      Dim objHashTable As New Hashtable
      Me.Alinear_Columnas_Grilla()
      objHashTable.Add("PSNPLCUN", Me._NPLCUN)
      objHashTable.Add("PSCCMPN", Me._CCMPN)
      Me.gwListaValesRuta.DataSource = objLogica.Lista_Vales_Ruta_x_Tracto(objHashTable)
    Catch : End Try
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim lintIndice As Integer = Me.gwListaValesRuta.CurrentCellAddress.Y
    If Me.gwListaValesRuta.RowCount = 0 OrElse lintIndice < 0 Then Exit Sub
    _objEntidad = New LiquidacionCombustible
    _objEntidad.NRUCTR = Me.gwListaValesRuta.Item("C_NRUCTR", lintIndice).Value
    _objEntidad.CBRCNT = Me.gwListaValesRuta.Item("C_CBRCND", lintIndice).Value
    _objEntidad.CGRFO = Me.gwListaValesRuta.Item("C_CGRFO", lintIndice).Value
    _objEntidad.CTPCMB = Me.gwListaValesRuta.Item("C_CTPCMB", lintIndice).Value
    _objEntidad.FCRCMB_S = Me.gwListaValesRuta.Item("C_FCRCMB_S", lintIndice).Value
    objEntidad.NVLGRF = Me.gwListaValesRuta.Item("C_NVLGRF", lintIndice).Value
    objEntidad.QGLNCM = Me.gwListaValesRuta.Item("C_QGLNCM", lintIndice).Value
    objEntidad.CSTGLN = Me.gwListaValesRuta.Item("C_CSTGLN", lintIndice).Value
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

#End Region

#Region "Metodos"
  Private Sub Alinear_Columnas_Grilla()
    Me.gwListaValesRuta.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwListaValesRuta.ColumnCount - 1
      Me.gwListaValesRuta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub
#End Region

End Class
