Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmConsultaLineaCredito
    Private brRegionVenta As clsRegionVenta_BL
    Private oCliente As New clsServicio_BL
    Private _pCompania As String = ""
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Private _CRGVTA As String
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Private _CCLNT As Double
    Public Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property


    Private Sub frmConsultaLineaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtRegionVenta As New DataTable
        brRegionVenta = New clsRegionVenta_BL

        brRegionVenta.Crea_Lista()
        dtRegionVenta = brRegionVenta.Lista_Region_Venta(pCompania)
        If dtRegionVenta.Rows.Count > 0 Then
            dtRegionVenta.Rows.RemoveAt(0)
        End If
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = dtRegionVenta
        Me.cmbRegionVenta.SelectedValue = CRGVTA
        UcDivision_Cmb011.Compania = pCompania
        UcDivision_Cmb011.Usuario = ConfigurationWizard.UserName
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim strMensaje As String = String.Empty
        Dim FnVerificacion As String = String.Empty
        Select Case UcDivision_Cmb011.Division
            Case "T"
                FnVerificacion = "SOLMIN_ST"
            Case "R"
                FnVerificacion = "SOLMIN_SA"
            Case "S"
                FnVerificacion = ""
        End Select
        oCliente.fblnIsLocked(CCLNT, FnVerificacion, strMensaje, pCompania, UcDivision_Cmb011.Division, cmbRegionVenta.SelectedValue)
        MessageBox.Show(strMensaje, "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
