Imports SOLMIN_CTZ.NEGOCIO
Public Class frmEstadoDocumento

#Region "Declaracion de variables"
    Public PNNDCCTC As Decimal = 0
    Private oSeguimiento As New clsSeguimientoDocumentos
#End Region

#Region "Eventos de Control"

    Private Sub frmEstadoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oDt As New DataTable
        Dim oDtAux As New DataTable
        oDt = oSeguimiento.ListaSeguimientoPorDocumento(PNNDCCTC)
        oDtAux = oDt.Clone
        For Each dr As DataRow In oDt.Rows
            If dr("HCNFCL") = "00:00:00" Then dr("HCNFCL") = ""
            If dr("HULTAC") = "00:00:00" Then dr("HULTAC") = ""
            oDtAux.ImportRow(dr)
        Next


        dtgDocumentos.AutoGenerateColumns = False
        dtgDocumentos.DataSource = oDt.DefaultView.ToTable
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Procedimientos y funciones"

#End Region

  
End Class
