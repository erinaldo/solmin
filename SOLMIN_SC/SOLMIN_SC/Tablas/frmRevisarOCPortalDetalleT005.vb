Public Class frmRevisarOCPortalDetalleT005
    Private objPortalDetalle As New SOLMIN_SC.Entidad.bePortalDetalle
    Private objPortalDetalleNeg As New SOLMIN_SC.Negocio.clsImpInfEmbarcador
    Public Sub New(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objPortalDetalle = objPD
        CargarDetallesT005()
    End Sub
    Private Sub CargarDetallesT005()
        Dim oDtT005 As New DataTable
        oDtT005 = objPortalDetalleNeg.Obtener_Informacion_T005(objPortalDetalle)
        If Not oDtT005 Is Nothing Then
            If oDtT005.Rows.Count = 1 Then
                txtSIDYRC.Text = oDtT005.Rows(0).Item("SIDYRC")
                txtSYDRNS.Text = oDtT005.Rows(0).Item("SIDRNS")
                txtSVIAJE.Text = oDtT005.Rows(0).Item("SVIAJE")
                txtSNROEMB.Text = oDtT005.Rows(0).Item("SNROEMB")
                txtCTIPTRA.Text = objPortalDetalleNeg.Obtener_Info_M011_TipoTransporte(oDtT005.Rows(0).Item("CTIPTRA").ToString.Trim)
                txtSTRANS.Text = oDtT005.Rows(0).Item("STRANS")
                txtCCLIENT.Text = oDtT005.Rows(0).Item("CCLIENT")
                txtCPAIORI.Text = objPortalDetalleNeg.Obtener_Info_M008_Pais(oDtT005.Rows(0).Item("CPAIORI").ToString.Trim)
                txtCPTOORI.Text = objPortalDetalleNeg.Obtener_Info_M009_Puerto(oDtT005.Rows(0).Item("CPAIORI").ToString.Trim, oDtT005.Rows(0).Item("CPTOORI").ToString.Trim)
                txtCPAIDEST.Text = objPortalDetalleNeg.Obtener_Info_M008_Pais(oDtT005.Rows(0).Item("CPAIDEST").ToString.Trim)
                txtCPTODEST.Text = objPortalDetalleNeg.Obtener_Info_M009_Puerto(oDtT005.Rows(0).Item("CPAIDEST").ToString.Trim, oDtT005.Rows(0).Item("CPTODEST").ToString.Trim)
                txtDZARPE.Text = oDtT005.Rows(0).Item("DZARPE")
                txtDARRIBO.Text = oDtT005.Rows(0).Item("DARRIBO")
                txtNORDAGE.Text = oDtT005.Rows(0).Item("NORDAGE")
                txtDORDAGE.Text = IIf(IsDBNull(oDtT005.Rows(0).Item("DORDAGE")), 0, oDtT005.Rows(0).Item("DORDAGE"))
                txtSTIPREG.Text = oDtT005.Rows(0).Item("STIPREG")
                txtSNOMTER.Text = oDtT005.Rows(0).Item("SNOMTER")
                txtSDIALIB.Text = oDtT005.Rows(0).Item("SDIALIB")
                txtSSOBEST.Text = oDtT005.Rows(0).Item("SSOBEST")
                txtSCANAL.Text = oDtT005.Rows(0).Item("SCANAL")
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
