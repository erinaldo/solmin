Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmInformSolicitudTransporte
    Private _PNNORSCI As Decimal = 0

    Sub New(ByVal PNNORSCI As Decimal)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _PNNORSCI = PNNORSCI
    End Sub

    Private Sub frmInformSolicitudTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgRecursosAsignados.AutoGenerateColumns = False
            dtgSolicitudTransporte.AutoGenerateColumns = False

            Dim oListSolicitudTransporte As New List(Of beSolicitudTransporte)
            Dim oblSolicitudTransporte As New clsSolicitudTransporte
            oListSolicitudTransporte = oblSolicitudTransporte.Obtener_Lista_Solicitud_Transporte(_PNNORSCI)
            dtgSolicitudTransporte.DataSource = oListSolicitudTransporte

            Cargar_Detalle_Solicitud_Transporte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Cargar_Detalle_Solicitud_Transporte()
        dtgRecursosAsignados.DataSource = Nothing
        If dtgSolicitudTransporte.CurrentRow IsNot Nothing Then
            Dim NCSOTR As Decimal = dtgSolicitudTransporte.CurrentRow.Cells("PNNCSOTR_CAB").Value
            Dim oListDetSolicitudTransporte As New List(Of beDetalleSolTransporte)
            Dim oblSolicitudTransporte As New clsSolicitudTransporte
            oListDetSolicitudTransporte = oblSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(NCSOTR)
            dtgRecursosAsignados.DataSource = oListDetSolicitudTransporte
        End If

    End Sub

    Private Sub dtgSolicitudTransporte_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitudTransporte.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim ColName As String = ""
                Dim PSURLARC As String = ""
                ColName = dtgSolicitudTransporte.Columns(e.ColumnIndex).Name
                Select Case ColName
                    Case "PSDETALLE"
                        Dim NCSOTR As Decimal = dtgSolicitudTransporte.CurrentRow.Cells("PNNCSOTR_CAB").Value
                        Dim ofrmCabSolicitudTransporte As New frmCabSolicitudTransporte(NCSOTR)
                        ofrmCabSolicitudTransporte.ShowDialog()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSolicitudTransporte_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitudTransporte.CellClick
        Try
            Dim oclsCierreEmbarque As New clsCierreEmbarque
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Cargar_Detalle_Solicitud_Transporte()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSolicitudTransporte_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If dtgSolicitudTransporte.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
                Cargar_Detalle_Solicitud_Transporte()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
