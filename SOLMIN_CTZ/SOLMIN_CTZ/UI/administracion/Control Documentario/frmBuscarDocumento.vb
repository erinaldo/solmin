Imports SOLMIN_CTZ.NEGOCIO

Public Class frmBuscarDocumento

    Private Marcar As Image
    Private Desmarcar As Image
    Private _beCuentaCorriente As SOLMIN_CTZ.Entidades.CuentaCorriente
    Public Property beCuentaCorriente() As SOLMIN_CTZ.Entidades.CuentaCorriente
        Get
            Return _beCuentaCorriente
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.CuentaCorriente)
            _beCuentaCorriente = value
        End Set
    End Property


    Private _oDtResultado As DataTable
    Public Property oDtResultado() As DataTable
        Get
            Return _oDtResultado
        End Get
        Set(ByVal value As DataTable)
            _oDtResultado = value
        End Set
    End Property


    Private Sub frmBuscarDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarSeguimiento()
        Marcar = btnMarcarItems.BackgroundImage
        Desmarcar = btnMarcarItems.Image
        'BuscarDocumentos()
    End Sub

    Private Sub BuscarDocumentos()
        With _beCuentaCorriente
            .FechaInicio = HelpClass.CtypeDate(Me.dtpFechaIni.Value)
            .FechaFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            .PNCDSGDC = cmbSeguimiento.SelectedValue
            .CCLNT = IIf(Me.UcCliente.pCodigo.ToString = "0", "-1", Me.UcCliente.pCodigo)
            .PSURSPDC = Me.txtResponsable.Text
        End With
        Dim oCuentaCorrienteNeg As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        dtgDocumentos.AutoGenerateColumns = False
        Me.dtgDocumentos.DataSource = oCuentaCorrienteNeg.Buscar_Documento_Masivo(_beCuentaCorriente)
    End Sub

    Private Sub CargarSeguimiento()
        Dim oSeguimiento As New clsSeguimientoDocumentos
        Dim oDt As New DataTable
        Dim oDtAux As New DataTable
        Dim dr As DataRow
        oDt.Columns.Add("CDSGDC", GetType(Decimal))
        oDt.Columns.Add("TDSGDC", GetType(String))
        dr = oDt.NewRow
        dr(0) = 0
        dr(1) = "TODOS"
        oDt.Rows.Add(dr)
        oDtAux = oSeguimiento.ListaSeguimientoDocumentos("EZ")
        For Each oDr As DataRow In oDtAux.Rows
            oDt.ImportRow(oDr)
        Next
        cmbSeguimiento.DataSource = oDt
        cmbSeguimiento.ValueMember = "CDSGDC"
        cmbSeguimiento.DisplayMember = "TDSGDC"
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            dtgDocumentos.EndEdit()
            If Me.dtgDocumentos.Rows.Count = 0 Then Exit Sub
            Dim odt As New DataTable
            Dim odr As DataRow
            odt = Me.dtgDocumentos.DataSource.Copy
            odt.Clear()
            For intCount As Integer = 0 To Me.dtgDocumentos.RowCount - 1
                If dtgDocumentos.Rows(intCount).Cells("Seleccione").Value Then
                    odr = odt.NewRow
                    For i As Integer = 0 To Me.dtgDocumentos.DataSource.Columns.Count - 1
                        odr.Item(i) = dtgDocumentos.Rows(intCount).DataBoundItem.Item(i)
                    Next
                    odt.Rows.Add(odr)
                End If
            Next

            _oDtResultado = odt.Copy
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarDocumentos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        If dtgDocumentos.RowCount > 0 Then
            If Existe_Check() Then
                Poner_Check_Todo_OC(False)
                btnMarcarItems.Image = Desmarcar
            Else
                Poner_Check_Todo_OC(True)
                btnMarcarItems.Image = Marcar
            End If
        End If
        Me.dtgDocumentos.EndEdit()
    End Sub


    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgDocumentos.Rows.Count - 1
            If dtgDocumentos.Rows(intCont).Cells("Seleccione").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgDocumentos.RowCount - 1
            dtgDocumentos.Rows(intCont).Cells("Seleccione").Value = blnEstado
        Next intCont

    End Sub

End Class
