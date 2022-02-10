Imports Ransa.Utilitario

Public Class frmOperacionesXPreDoc

    Public PSCCMPN As String = ""
    Public PNNRCTRL As Decimal = 0
    Public PSTPCTRL As String = ""
    Public PNNCRRPD As Decimal = 0

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmOperacionesXPreDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.dtgOpPendientes.AutoGenerateColumns = False
            Dim dtResult As New DataTable

            Dim obrFiltroPreDoc As New clsPreDoc_BL
            Dim oPreDocFiltro As New PreDoc_BE
            oPreDocFiltro = New PreDoc_BE
            oPreDocFiltro.PSCCMPN = PSCCMPN
            oPreDocFiltro.PNNRCTRL = PNNRCTRL
            oPreDocFiltro.PSTPCTRL = PSTPCTRL
            oPreDocFiltro.PNNCRRPD = PNNCRRPD

            dtResult = obrFiltroPreDoc.ListarOperacionesXPreDoc(oPreDocFiltro)

            dtgOpPendientes.DataSource = dtResult
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
         

            Dim titulo As String = ""

            If PNNCRRPD > 0 Then
                titulo = " Pre-Documento : " & PNNCRRPD
            End If


            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "OPERACIONES " & titulo))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.dtgOpPendientes.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

           
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgOpPendientes, objDt))

         
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class