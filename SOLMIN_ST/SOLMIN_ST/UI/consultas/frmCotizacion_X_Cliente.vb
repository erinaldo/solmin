Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES

Public Class frmCotizacion_X_Cliente
    Public obeCotizacion As New Cotizacion
    Private bs As New BindingSource
    Private olbeCotizaciones As List(Of Cotizacion)

    Private Sub frmCotizacion_X_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaCotizaciones()
    End Sub

    Private Sub ListaCotizaciones()
        Me.Cursor = Cursors.WaitCursor

        Dim objEntidad As New Hashtable
        Dim strEstado As String = ""
        Dim objLogical As New Cotizacion_BLL
        dtgCotizacion.AutoGenerateColumns = False

        objEntidad.Add("CCMPN", obeCotizacion.CCMPN)
        objEntidad.Add("CDVSN", obeCotizacion.CDVSN)
        objEntidad.Add("CPLNDV", obeCotizacion.CPLNDV)
        objEntidad.Add("SESTCT", "")
        objEntidad.Add("FECINI", 20000101)
        objEntidad.Add("FECFIN", HelpClass.CDate_a_Numero8Digitos(Now))
        objEntidad.Add("CCLNT", obeCotizacion.CCLNT)
        olbeCotizaciones = objLogical.Listar_Cotizaciones(objEntidad)
        Me.dtgCotizacion.DataSource = olbeCotizaciones
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgCotizacion_CelloubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCotizacion.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        Ok()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Ok()
    End Sub

    Private Sub Ok()
        If dtgCotizacion.CurrentCellAddress.Y = -1 Then Exit Sub
        With Me.dtgCotizacion.CurrentRow
            obeCotizacion.CMNDA = .Cells("CMNDA").Value
            obeCotizacion.NCTZCN = .Cells("NCTZCN").Value
            obeCotizacion.NCNTRT = .Cells("NCNTRT").Value
            obeCotizacion.TCNCLC = .Cells("TCNCLC").Value
            obeCotizacion.CPLNFC = .Cells("CPLNFC").Value
            obeCotizacion.SCBRMD = .Cells("SCBRMD").Value
        End With

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtBuscarCotizacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCotizacion.TextChanged
        Me.dtgCotizacion.DataSource = olbeCotizaciones.FindAll(match)
    End Sub

    Private match As New Predicate(Of Cotizacion)(AddressOf Busca_NrCotizacion)

    Public Function Busca_NrCotizacion(ByVal obeCotizacion As Cotizacion) As Boolean
        If (obeCotizacion.NCTZCN.Trim.IndexOf(Me.txtBuscarCotizacion.Text) <> -1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub dtgCotizacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgCotizacion.ColumnHeaderMouseClick
        Dim oucOrdena As UCOrdena(Of Cotizacion)
        oucOrdena = New UCOrdena(Of Cotizacion)(Me.dtgCotizacion.Columns(e.ColumnIndex).Name, UCOrdena(Of Cotizacion).TipoOrdenacion.Ascendente)
        olbeCotizaciones.Sort(oucOrdena)
        Me.dtgCotizacion.DataSource = olbeCotizaciones
        Me.dtgCotizacion.Refresh()
    End Sub

    Private Sub dtgCotizacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgCotizacion.KeyDown
        If e.KeyValue = 113 Then
            Ok()
        End If
    End Sub
End Class
