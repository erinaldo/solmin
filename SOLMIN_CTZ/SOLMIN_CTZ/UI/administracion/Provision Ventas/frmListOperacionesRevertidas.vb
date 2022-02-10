Imports SOLMIN_CTZ.NEGOCIO
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades
Public Class frmListOperacionesRevertidas
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
        dtgOperaciones.DataSource = obrProvisionVentas.fdtListaOperacionesRevertidas_CeBe(obeProvisionVenta)
    End Sub

    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Try
            Dim decTotalImporteProv As Decimal
            Dim decTotalImporteRev As Decimal
            For Each odr As DataRow In Me.dtgOperaciones.DataSource.Rows
                decTotalImporteProv += CType(odr.Item("ITTPRS_PROV"), Decimal)
                decTotalImporteRev += CType(odr.Item("ITTPRS_REV"), Decimal)
            Next

            hgProvision.ValuesSecondary.Heading = "Monto provisionado : S/. " & Format(decTotalImporteProv, "###,###,###,###.00") & _
                "  Monto revertido : S/. " & Format(decTotalImporteRev, "###,###,###,###.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
