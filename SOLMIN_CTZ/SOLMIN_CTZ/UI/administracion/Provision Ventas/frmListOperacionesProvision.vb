Imports SOLMIN_CTZ.NEGOCIO
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades
Public Class frmListOperacionesProvision
    Private _obeProvisionVenta As ProvisionVenta
    Public Property obeProvisionVenta() As ProvisionVenta
        Get
            Return _obeProvisionVenta
        End Get
        Set(ByVal value As ProvisionVenta)
            _obeProvisionVenta = value
        End Set
    End Property

    Private Sub frmGenerarProvision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        dtgOperaciones.AutoGenerateColumns = False
        dtgOperaciones.DataSource = obrProvisionVentas.fdtListaOperacionesProvionadas_CeBe(obeProvisionVenta)
    End Sub

    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Try
            Dim decTotalImporte As Decimal
            For Each odr As DataRow In Me.dtgOperaciones.DataSource.Rows
                decTotalImporte += CType(odr.Item("ITTPRS"), Decimal)
            Next
            hgProvision.ValuesSecondary.Heading = "Monto provisionado : S/. " & Format(decTotalImporte, "###,###,###,###.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
