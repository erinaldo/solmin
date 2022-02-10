Imports Ransa.Utilitario
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad

Public Class frmLogDeCheckpoints
    Private opbeCheckpoint As beBitacora

    Public Sub New(ByVal obeCheckpoint As beBitacora)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarCheckpoint(obeCheckpoint)
        Ransa.Utilitario.UCDataGridView.Alinear_Columnas_Grilla(Me.dtgCheckpointCliente)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <remarks></remarks>
    Private Sub CargarCheckpoint(ByVal obeCheckpoint As beBitacora)
        Dim obrCheckpoint As New clsBitacora
        Me.dtgCheckpointCliente.AutoGenerateColumns = False
        Me.dtgCheckpointCliente.DataSource = obrCheckpoint.ListaLogDeCheckPointXItemsDeOC(obeCheckpoint)
        Me.txtCheckoints.Text = "Checkpoint : " & obeCheckpoint.PSTDESES
    End Sub


    Private Sub frmLogDeCheckpoints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
