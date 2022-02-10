'------(RZTR96P con RZTR96L) y join con RZOL65 ------
Public Class frmBuscarCargoPlan
    Private _result As String
    Private _oServicio As Servicio_BE
    Public Property result() As String
        Get
            Return _result
        End Get
        Set(ByVal value As String)
            _result = value
        End Set
    End Property
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property
    Private Sub frmBuscarCargoPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UcTransportista.pUsuario = _oServicio.PSUSUARIO
        Dim sRucTrans As String = ""
        If _oServicio.CTRMNC <> 0 Then
            Dim oServicioNeg As New clsServicio_BL
            sRucTrans = oServicioNeg.ObtieneRUCTransportista(_oServicio.CTRMNC)
        End If

        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = _oServicio.CCMPN
        obeTransportista.pNRUCTR_RucTransportista = sRucTrans.Trim
        UcTransportista.pCargar(obeTransportista)

        If _oServicio.NGUITR <> 0 Then
            txtGuiaTrans.Text = _oServicio.NGUITR
            btnImportar_Click(Nothing, Nothing)
            btnCancelar.Visible = False
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dtgCuentaImputacion.Rows.Count = 0 Then Exit Sub
        _result = "IMP_CARGO_PLAN"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        _result = ""
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim oServicioNeg As New clsServicio_BL
        Dim oDs As New DataSet
        Dim oDtCI As New DataTable
        Dim oDtOC_Dist As New DataTable

        Dim oDtCIFiltro As New DataTable
        Dim where As String = ""
        Dim sumaCI As Double = 0D

        Dim oDtTemp As New DataTable
        Dim oDtOCTemp As New DataTable

        ' === Creamos Structura Tabla Distribución === 
        oDtOCTemp.Columns.Add("FLG")
        oDtOCTemp.Columns.Add("CI")
        oDtOCTemp.Columns.Add("POR")
        ' ========== ========== ========== ============
        _oServicio.CTRMNC = UcTransportista.pCodigoRNS
        _oServicio.NGUITR = IIf(txtGuiaTrans.Text = "", 0, txtGuiaTrans.Text)

        dtgCuentaImputacion.Rows.Clear()

        oDs = oServicioNeg.Importa_CI_CargoPlan(_oServicio)
        oDtCI = oDs.Tables(0)
        oDtOC_Dist = oDs.Tables(1)

        If oDtOC_Dist.Rows.Count = 0 Then
            '============Distribución Simple================
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                where = "CI = '" & oDtCI.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtCI, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("PRCRMT")
                Next
                Dim oDrvW As DataGridViewRow
                oDrvW = New DataGridViewRow
                oDrvW.CreateCells(Me.dtgCuentaImputacion)
                Me.dtgCuentaImputacion.Rows.Add(oDrvW)
                With dtgCuentaImputacion.Rows(dtgCuentaImputacion.Rows.Count - 1)
                    .Cells("CORR").Value = dtgCuentaImputacion.Rows.Count
                    .Cells("CI").Value = oDtCI.Rows(i)("CI").ToString.Trim
                    .Cells("PRCRMT").Value = Math.Round(sumaCI, 4)
                End With
                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Exit Sub
        Else
            '============Hacemos distribucion adicional por OC============
            Dim iRow As DataRow
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                '=========================Buscamos OC=========================
                where = "NORCML = '" & oDtCI.Rows(i).Item("NORCML").ToString.Trim & "' "
                oDtTemp = BuscarDatatable(oDtOC_Dist, where)
                If oDtTemp.Rows.Count > 0 Then
                    For Each oDrOC As DataRow In oDtTemp.Rows
                        iRow = oDtOCTemp.NewRow
                        iRow("FLG") = "DISTRIBUIDOS"
                        Select Case oDtCI.Rows(i).Item("CMEDTR")
                            Case "4" 'TERRESTRE
                                iRow("CI") = oDrOC("TCTCST")
                            Case "1" 'AEREO
                                iRow("CI") = oDrOC("TCTCSA")
                            Case "5" ' FLUVIAL
                                iRow("CI") = oDrOC("TCTCSF")
                        End Select
                        iRow("POR") = oDtCI.Rows(i).Item("PRCRMT") * oDrOC("IPRCTJ") * 0.01 ' VALOR DEL PORCENTAJE DISTRIBUIDO
                        oDtOCTemp.Rows.Add(iRow)
                    Next
                Else
                    iRow = oDtOCTemp.NewRow
                    iRow("FLG") = "NORMAL"
                    iRow("CI") = oDtCI.Rows(i).Item("CI")
                    iRow("POR") = oDtCI.Rows(i).Item("PRCRMT")
                    oDtOCTemp.Rows.Add(iRow)
                End If
            Next
            oDtOCTemp.DefaultView.Sort = "CI"
            oDtOCTemp = oDtOCTemp.DefaultView.ToTable()
            For i As Integer = 0 To oDtOCTemp.Rows.Count - 1
                where = "CI = '" & oDtOCTemp.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtOCTemp, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("POR")
                Next
                Dim oDrvW As DataGridViewRow
                oDrvW = New DataGridViewRow
                oDrvW.CreateCells(Me.dtgCuentaImputacion)
                Me.dtgCuentaImputacion.Rows.Add(oDrvW)
                With dtgCuentaImputacion.Rows(dtgCuentaImputacion.Rows.Count - 1)
                    .Cells("CORR").Value = dtgCuentaImputacion.Rows.Count
                    .Cells("CI").Value = oDtOCTemp.Rows(i)("CI").ToString.Trim
                    .Cells("PRCRMT").Value = Math.Round(sumaCI, 4)
                End With
                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Exit Sub
        End If
    End Sub
    Private Function BuscarDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function
End Class