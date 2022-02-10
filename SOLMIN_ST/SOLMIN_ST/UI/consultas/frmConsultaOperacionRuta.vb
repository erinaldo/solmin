Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmConsultaOperacionRuta

#Region "Atributo"
  Private mNLQGST As Double
  Private mNOPRCN As Double
  Private mNCRRRT As Double
#End Region

#Region "Properties"

  Public WriteOnly Property NLQGST() As Double
    Set(ByVal value As Double)
      mNLQGST = value
    End Set
  End Property

  Public WriteOnly Property NOPRCN() As Double
    Set(ByVal value As Double)
      mNOPRCN = value
    End Set
  End Property

  Public WriteOnly Property NCRRRT() As Double
    Set(ByVal value As Double)
      mNCRRRT = value
    End Set
  End Property

#End Region

#Region "Eventos"
  Private Sub frmConsultaOperacionRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Alinear_Columnas_Grilla()
            Me.Listar_Gasto_x_Ruta()
            Me.Listar_Gasto_Combustible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

#End Region

#Region "Metodos y Funciones"

  Private Sub Alinear_Columnas_Grilla()
    Me.dtgGastoRuta.AutoGenerateColumns = False
    Me.dtgGastoCombustible.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgGastoRuta.ColumnCount - 1
      Me.dtgGastoRuta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dtgGastoCombustible.ColumnCount - 1
      Me.dtgGastoCombustible.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Listar_Gasto_x_Ruta()
    Dim objLogica As New LiquidacionGastos_BLL
    Dim objParametro As New Hashtable
    objParametro.Add("PNNLQGST", Me.mNLQGST)
    objParametro.Add("PNNOPRCN", Me.mNOPRCN)
    objParametro.Add("PNNCRRRT", Me.mNCRRRT)
        Me.dtgGastoRuta.DataSource = objLogica.Listar_Gasto_Ruta_Operacion(objParametro)
        ' Se formatean las fechas
        'For Each Row As DataGridViewRow In dtgGastoRuta.Rows
        '    Row.Cells(dtgGastoRuta.Columns("FECINI_G").Index).Value = HelpClass.FechaNum_a_Fecha(Row.Cells(dtgGastoRuta.Columns("FECINI").Index).Value)
        '    Row.Cells(dtgGastoRuta.Columns("FECFIN_G").Index).Value = HelpClass.FechaNum_a_Fecha(Row.Cells(dtgGastoRuta.Columns("FECFIN").Index).Value)
        'Next
  End Sub

  Private Sub Listar_Gasto_Combustible()
    Dim objLogica As New LiquidacionGastos_BLL
    Dim objParametro As New Hashtable
    objParametro.Add("PNNLQGST", Me.mNLQGST)
    objParametro.Add("PNNOPRCN", Me.mNOPRCN)
    Me.dtgGastoCombustible.DataSource = objLogica.Listar_Gasto_Combustible(objParametro)
  End Sub
#End Region

 
End Class
