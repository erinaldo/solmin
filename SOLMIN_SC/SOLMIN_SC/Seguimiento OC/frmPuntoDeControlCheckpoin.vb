Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmPuntoDeControlCheckpoin

#Region "Atributos y propedades"
    Private opbeCheckpoint As beBitacora
#End Region

#Region "Eventos"
    Public Sub New(ByVal obeCheckpoint As beBitacora) ', ByVal poPreEmbarque As Negocio.clsPreEmbarque)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarCheckpoint(obeCheckpoint)
        Ransa.Utilitario.UCDataGridView.Alinear_Columnas_Grilla(Me.dtgCheckpointCliente)
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        'If Me.dgGuiasRemision.CurrentCellAddress.Y = -1 Then Exit Sub
        'Dim obrCheckpoint As New brCheckPoint
        'Dim obeCheckpoint As New beCheckPoint
        'obeCheckpoint = Me.dtgCheckpointCliente.CurrentRow.DataBoundItem
        'With obeCheckpoint
        '    .PNCCLNT = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PNCCLNT
        '    .PNNGUIRM = Me.dgGuiasRemision.CurrentRow.DataBoundItem.PSNGUIRM
        '    .PSCUSCRT = objSeguridadBN.pUsuario
        '    .PNFCHCRT = HelpClass.CtypeDate(Now)
        '    .PNHRACRT = HelpClass.NowNumeric
        '    .PSSESTRG = "*"
        'End With
        'If obrCheckpoint.ActualizarCheckPointXGuiaDeRemision(obeCheckpoint) = 1 Then
        '    fnLimpiarCheckpoint()
        '    fnSelPuntoDeControlXGuia()
        'End If
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If Me.dtgCheckpointCliente.Rows.Count = 0 Then Exit Sub
        GuardarCheckpointPorOC()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgCheckpointCliente_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCheckpointCliente.CellDoubleClick
        If Me.dtgCheckpointCliente.CurrentCellAddress.Y = -1 Then Exit Sub
        If Me.dtgCheckpointCliente.Columns(e.ColumnIndex).Name = "LOG" Then
            opbeCheckpoint.PSTDESES = Me.dtgCheckpointCliente.CurrentRow.DataBoundItem.PSTDESES
            Dim ofrmLogCheckpoint As New frmLogDeCheckpoints(opbeCheckpoint)
            ofrmLogCheckpoint.ShowDialog()
        End If
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <remarks></remarks>
    Private Sub CargarCheckpoint(ByVal obeCheckpoint As beBitacora)
        Dim obrCheckpoint As New clsBitacora
        Dim obeBusqueda As beBitacora
        Dim olbeCheckpoint As New List(Of beBitacora)
        Dim olbeCheckpointPorGuia As New List(Of beBitacora)
        Me.dtgCheckpointCliente.AutoGenerateColumns = False
        opbeCheckpoint = obeCheckpoint
        Me.dtgCheckpointCliente.DataSource = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)
        olbeCheckpointPorGuia = obrCheckpoint.ListaCheckPointXItemsDeOC(obeCheckpoint)

        For Each obeCheck As beBitacora In Me.dtgCheckpointCliente.DataSource
            obeBusqueda = New beBitacora
            NrOc = obeCheckpoint.PSNORCML
            NrItem = obeCheckpoint.PNNRITOC
            codCheckpoint = obeCheck.PNNESTDO
            olbeCheckpoint = olbeCheckpointPorGuia.FindAll(MatchCheckpoinOC)
            If olbeCheckpoint.Count > 0 Then
                dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNMESTDO = olbeCheckpoint.Item(0).PNMESTDO
                dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNFRETES = olbeCheckpoint.Item(0).PNFRETES
                dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PNFESEST = olbeCheckpoint.Item(0).PNFESEST
                dtgCheckpointCliente.DataSource.Item(dtgCheckpointCliente.DataSource.IndexOf(obeCheck)).PSTOBEST = olbeCheckpoint.Item(0).PSTOBEST
            End If
        Next
    End Sub


#Region "Búsqueda de Checkpoint"

    Private codCheckpoint As Decimal = 0
    Private NrOc As String = ""
    Private NrItem As Decimal = 0
    Private MatchCheckpoinOC As New Predicate(Of beBitacora)(AddressOf BuscarCheckpoints)

    Public Function BuscarCheckpoints(ByVal pbeCheckPoint As beBitacora) As Boolean
        If (pbeCheckPoint.PNNESTDO = codCheckpoint) And (pbeCheckPoint.PSNORCML = NrOc) And (pbeCheckPoint.PNNRITOC = NrItem) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region



    ''' <summary>
    ''' Guardar Checkpoint de Guia Remision
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarCheckpointPorOC()
        Me.dtgCheckpointCliente.EndEdit()
        Dim obrCheckpoint As New clsBitacora
        For Each obeCheckpoint As beBitacora In Me.dtgCheckpointCliente.DataSource
            With obeCheckpoint
                .PNCCLNT = opbeCheckpoint.PNCCLNT
                .PSNORCML = opbeCheckpoint.PSNORCML
                .PNNRITOC = opbeCheckpoint.PNNRITOC
                .PSCUSCRT = HelpUtil.UserName
                .PSSESTRG = "A"
            End With
            If obeCheckpoint.PNFRETES <> 0 Or obeCheckpoint.PNFESEST <> 0 Or Not obeCheckpoint.PSTOBEST.Trim.Equals("") Then
                If obrCheckpoint.InsertarCheckPointXItemDeOc(obeCheckpoint) = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

  
End Class
