Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN
Public Class frmSAWConsultaVehiculo
    Dim MyNumber(2) As String
    Dim Fecha As String

    Public Sub ActualizaInfo()
        Dim objFiltro As clsFiltros_SDSWConsultaVehiculos = New clsFiltros_SDSWConsultaVehiculos
        With objFiltro
            If cboEstado.Text <> "" Then
                .pstrEstado = MyNumber(cboEstado.Items.IndexOf(cboEstado.Text))
            End If
            .pstrNCHSVH = txtvin.Text
            Date.TryParse(dtpInicio.Text, .pdteFechaInicio)
            Date.TryParse(dtpFinal.Text, .pdteFechaFin)
        End With
        dgvVehiculos.DataSource = mfdtListar_SDSWVehiculo(objFiltro)
    End Sub
    Public Sub Carga_Informacion()
        dgvVehiculos.DataSource = mfdtListar_SDSWTotalVehiculos()
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        ActualizaInfo()
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsnCerrar.Click

        If MessageBox.Show(" ¿ Desea Cerrar el Registro ? ", "Cerrar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Genera Operacion y Liberacion
            mfdtGenera_SDSWOperacion()
            'Genera Orden de Despacho
            ' mfdtGenera_Orden()
            mfblnCierre_SDSWVehiculo()
            MessageBox.Show("Proceso CREAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizaInfo()
        End If
    End Sub
    'Public Sub Graba()
    '    Dim objMovimiento As clsSDSWInformacionVehiculo = New clsSDSWInformacionVehiculo
    '    With objMovimiento
    '        .pstrCCLNT = txtCliente.Tag
    '        .pstrCALMCM = txtAlmacen.Tag
    '        .pstrCTPOAL = MyNumber(cboTipo.Items.IndexOf(cboTipo.Text))
    '        Date.TryParse(dtpInicio.Text, .pdteEntrega)
    '    End With
    '    mfblnProceso_PreFactVehiculo(objMovimiento, Compania_Usuario, Division_Usuario)
    'End Sub

    Private Sub frmConsultaVehiculo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cboEstado.Items.Add("Ingreso") : MyNumber(0) = "I"
        Me.cboEstado.Items.Add("Salida") : MyNumber(1) = "S"
        Carga_Informacion()
    End Sub

    Private Sub bsnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsnReporte.Click
        With frmSDSWReporteCierre
            .Show()
        End With
    End Sub
End Class
