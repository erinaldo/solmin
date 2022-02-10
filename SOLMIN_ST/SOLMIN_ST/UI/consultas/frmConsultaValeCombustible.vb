Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmConsultaValeCombustible

#Region "Atributos"
  Private mobjLista As New List(Of ValeCombustible)
  Private mobjEntidad As New ValeCombustible
#End Region

#Region "Properties"
  Public Property objLista()
    Get
      Return mobjLista
    End Get
    Set(ByVal value)
      mobjLista = value
    End Set
  End Property

  Public ReadOnly Property objEntidad() As ValeCombustible
    Get
      Return mobjEntidad
    End Get
  End Property
#End Region

#Region "Eventos"

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click, gwDatos.DoubleClick
    If Me.gwDatos.RowCount = 0 OrElse Me.gwDatos.CurrentRow.Selected = False Then Exit Sub
    mobjEntidad.NRSCVL = Me.gwDatos.Item("NRSCVL_A", Me.gwDatos.CurrentCellAddress.Y).Value
    mobjEntidad.QGLNSL = Me.gwDatos.Item("QGLNSL_A", Me.gwDatos.CurrentCellAddress.Y).Value
    mobjEntidad.CTPCMB = Me.gwDatos.Item("CTPCMB_A", Me.gwDatos.CurrentCellAddress.Y).Value
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub frmConsultaValeCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Alinear_Columnas_Grilla()
    Me.gwDatos.DataSource = HelpClass.GetDataSetNative(objLista)
  End Sub

#End Region

#Region "Métodos y Funciones"
  Private Sub Alinear_Columnas_Grilla()
    Me.gwDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwDatos.ColumnCount - 1
      Me.gwDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub
#End Region

End Class
