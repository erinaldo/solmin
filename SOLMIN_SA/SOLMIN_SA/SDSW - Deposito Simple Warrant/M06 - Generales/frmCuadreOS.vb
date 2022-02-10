Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Public Class frmCuadreOS
    Public Shared Function sumarcolumna(ByVal columna As Integer, ByVal grid As DataGridView) As Decimal
        Try
            Dim total As Decimal = 0
            For Each fila As DataGridViewRow In grid.Rows
                total += Convert.ToDecimal(fila.Cells(columna).Value)
            Next
            Return total
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub bsaabriring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaabriring.Click
        Me.hgIngreso.Height = 367
        bsaabrirsal.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

    End Sub

    Private Sub bsacerraring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsacerraring.Click
        Me.hgIngreso.Height = 24
        bsaabrirsal.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub bsaabrirsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaabrirsal.Click
        Me.hgSalida.Height = 365
        bsaabriring.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    End Sub

    Private Sub bsacerrarsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsacerrarsal.Click
        Me.hgSalida.Height = 24
        bsaabriring.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub frmCuadreOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.hgSalida.Height = 24
        Me.hgIngreso.Height = 24
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim objFiltro As clsFiltros_SDSWConsultaOrden = New clsFiltros_SDSWConsultaOrden
        With objFiltro
            Date.TryParse(dtpfecha.Text, .pdteFechaSolicitud_FSLCSR)
        End With
        dgvingreso.DataSource = mfdtLista_SDSWIngresos(objFiltro)
        dgvsalida.DataSource = mfdtLista_SDSWSalidas(objFiltro)
        Me.dgvdolares.DataSource = mfdtLista_SDSWIngSalDol(objFiltro)
        Me.dgvsoles.DataSource = mfdtLista_SDSWIngSalSol(objFiltro)
        'fdt_Listar_IngSalSol()
        lblcantidading.Text = sumarcolumna(5, dgvingreso)
        lblpesoing.Text = sumarcolumna(6, dgvingreso)
        lblvaloring.Text = sumarcolumna(7, dgvingreso)
        lblcantaut.Text = sumarcolumna(5, dgvsalida)
        lblpesoaut.Text = sumarcolumna(6, dgvsalida)
        lblvaloraut.Text = sumarcolumna(7, dgvsalida)
        lblcantdesp.Text = sumarcolumna(8, dgvsalida)
        lblpesodesp.Text = sumarcolumna(9, dgvsalida)
        lblvalordesp.Text = sumarcolumna(10, dgvsalida)

    End Sub

    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged

    End Sub
    Private Sub KryptonPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonPanel1.Paint

    End Sub

    Private Sub hgConsulta_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hgConsulta.Panel.Paint

    End Sub
End Class
