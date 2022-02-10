
Public Class frmClientesSolmin

    Private _oContrato As New SOLMIN_CTZ.Entidades.Contrato
    Public Property oContrato() As SOLMIN_CTZ.Entidades.Contrato
        Get
            Return _oContrato
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.Contrato)
            _oContrato = value
        End Set
    End Property

    Private Sub frmClientesSolmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UCclienteSolmin1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UCclienteSolmin1.pCargaInicial()
    End Sub

    Private Sub ListaTarifario(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UCclienteSolmin1.pListaTarifario

        Dim ofrmListaTarifa As New frmListaTarifas

        With oContrato
            .CCMPN = dtg.CurrentRow.Cells("CCMPN").Value
            .NRCTCL = dtg.CurrentRow.Cells("NRCTCL").Value
            .NCNTRT = dtg.CurrentRow.Cells("NCNTRT").Value
            .DESCAR = dtg.CurrentRow.Cells("DESCAR").Value
            .FechaInicio = dtg.CurrentRow.Cells("FECINI").Value
            .FechaFin = dtg.CurrentRow.Cells("FECFIN").Value
            .NRCTSL = dtg.CurrentRow.Cells("NRCTSL").Value
        End With
        ofrmListaTarifa.oContrato = oContrato
        'ofrmListaTarifa.btnAgregar.Visible = False
        'ofrmListaTarifa.btnModificar.Visible = False
        'ofrmListaTarifa.btnEliminar.Visible = False

        'ofrmListaTarifa.tssSep_02.Visible = False
        'ofrmListaTarifa.tssSep_04.Visible = False
        'ofrmListaTarifa.tssSep_03.Visible = False
        'ofrmListaTarifa.tssSep_05.Visible = False

        ofrmListaTarifa.pTipoEnumForm = frmListaTarifas.EnumTIPO_FORM.CONSULTA

        ofrmListaTarifa.oContrato = oContrato
        ofrmListaTarifa.MdiParent = Me.Parent.Parent
        ofrmListaTarifa.WindowState = FormWindowState.Maximized
        ofrmListaTarifa.Show()
    End Sub

End Class
