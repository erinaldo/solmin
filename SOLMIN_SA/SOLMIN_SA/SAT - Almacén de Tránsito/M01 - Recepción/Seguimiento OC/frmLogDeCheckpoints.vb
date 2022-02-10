Imports Ransa.Utilitario
Imports Ransa.NEGO
Imports Ransa.TypeDef

Public Class frmLogDeCheckpoints
    Private opbeCheckpoint As beCheckPoint

    Public Sub New(ByVal obeCheckpoint As beCheckPoint)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarCheckpoint(obeCheckpoint)
        UCDataGridView.Alinear_Columnas_Grilla(Me.dtgCheckpointCliente)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <remarks></remarks>
    Private Sub CargarCheckpoint(ByVal obeCheckpoint As beCheckPoint)
        Dim obrCheckpoint As New brCheckPoint
        Me.dtgCheckpointCliente.AutoGenerateColumns = False
        Me.dtgCheckpointCliente.DataSource = obrCheckpoint.ListaLogDeCheckPointXItemsDeOC(obeCheckpoint)
        Me.txtCheckoints.Text = "Checkpoint : " & obeCheckpoint.PSTDESES
    End Sub


End Class
