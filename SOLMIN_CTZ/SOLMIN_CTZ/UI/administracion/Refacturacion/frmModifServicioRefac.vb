Imports System.Text
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Ransa.Controls.ServicioOperacion
Public Class frmModifServicioRefac
    Private _pbeServicio As New ServicioOperacion
    Public Property pbeServicio() As ServicioOperacion
        Get
            Return _pbeServicio
        End Get
        Set(ByVal value As ServicioOperacion)
            _pbeServicio = value
        End Set
    End Property

    Private Function ValidarIngreso()
        Dim sbmsg As New StringBuilder
        txtCantidad.Text = txtCantidad.Text.Trim
        txtImporte.Text = txtImporte.Text.Trim
        If txtCantidad.Text.Length = 0 OrElse Val(txtCantidad.Text) = 0 Then
            sbmsg.Append("Ingrese cantidad mayor a cero")
        End If
        If txtImporte.Text.Length = 0 OrElse Val(txtImporte.Text) = 0 Then
            If sbmsg.ToString.Length > 0 Then
                sbmsg.AppendLine()
            End If
            sbmsg.Append("Ingrese Monto mayor a cero")
        End If
        Return sbmsg.ToString
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim msg As String = ""
            msg = ValidarIngreso()
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            _pbeServicio.QATNAN = txtCantidad.Text
            _pbeServicio.IVLSRV = txtImporte.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub cargarRubro()
        Dim oServicioBL As New DATOS.clsServicio_DAL
        Dim oDt As New DataTable
        Dim bolBuscar As Boolean = False
        Dim _oServicio As New Servicio_BE
        _oServicio.CCMPN = _pbeServicio.CCMPN
        _oServicio.CDVSN = _pbeServicio.CDVSN
        _oServicio.CCLNT = _pbeServicio.CCLNT
        oDt = oServicioBL.fdtListaRubroXCompaniaDivision(_oServicio)
        oDt = oDt.DefaultView.ToTable
        cmbRubro.DataSource = oDt
        cmbRubro.ValueMember = "NRRUBR"
        bolBuscar = True
        cmbRubro.DisplayMember = "NOMRUB"
        cmbRubro.SelectedValue = _pbeServicio.NRRUBR
    End Sub

    'Private Sub cargarServicio()
    '    Dim oServicioBL As New clsServicio_BL
    '    Dim oDtServicio As New DataTable
    '    Dim _oServicio As New Servicio_BE
    '    _oServicio.CCMPN = _pbeServicio.CCMPN
    '    _oServicio.CDVSN = _pbeServicio.CDVSN
    '    _oServicio.CCLNT = _pbeServicio.CCLNT
    '    _oServicio.CPLNDV = _pbeServicio.CPLNDV
    '    _oServicio.FOPRCN = _pbeServicio.FATNSR
    '    _oServicio.NRRUBR = _pbeServicio.NRRUBR
    '    oDtServicio = oServicioBL.Cargar_Servicios_Tarifa_Cliente(_oServicio)
    '    cmbServicio.DataSource = oDtServicio
    '    cmbServicio.ValueMember = "NRTFSV"
    '    cmbServicio.DisplayMember = "DESTAR"
    '    cmbServicio.SelectedValue = _pbeServicio.NRTFSV
    'End Sub

    Private Sub frmModifServicioRefac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargarRubro()
            'cargarServicio()
            txtOperacion.Text = _pbeServicio.NOPRCN
            txtCorrServicio.Text = _pbeServicio.NCRROP
            txtMoneda.Text = _pbeServicio.TSGNMN
            txtUnidad.Text = _pbeServicio.CUNDMD
            txtServicio.Text = _pbeServicio.DESTAR
            txtImporte.Text = Val(_pbeServicio.IVLSRV)
            txtCantidad.Text = Val(_pbeServicio.QATNAN)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


End Class
