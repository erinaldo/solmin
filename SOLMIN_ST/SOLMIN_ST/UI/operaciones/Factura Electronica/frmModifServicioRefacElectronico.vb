Imports System.Text
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Unidad
Imports Ransa.TypeDef.Moneda


Public Class frmModifServicioRefacElectronico

    Private _pbeServicio As New ENTIDADES.Servicio
    Public Property pbeServicio() As ENTIDADES.Servicio
        Get
            Return _pbeServicio
        End Get
        Set(ByVal value As ENTIDADES.Servicio)
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
            _pbeServicio.ISRVGU = txtImporte.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmModifServicioRefac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtOperacion.Text = _pbeServicio.NOPRCN
            txtCorrServicio.Text = _pbeServicio.NCRRGU
            txtMoneda.Text = _pbeServicio.TSGNMN
            txtUnidad.Text = _pbeServicio.CUNDMD
            txtNroGuia.Text = _pbeServicio.NGUITR
            txtImporte.Text = Val(_pbeServicio.ISRVGU)
            txtCantidad.Text = Val(_pbeServicio.QATNAN)
            txtDescSrv.Text = _pbeServicio.DESCSRV.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


End Class
