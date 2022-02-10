 
Public Class frmListaServicios
    Private oServicioOpeNeg As New clsServicio_BL
    Private _ServicioBE As New Servicio_BE


    Public Property ServicioBE() As Servicio_BE
        Get
            Return _ServicioBE
        End Get
        Set(ByVal value As Servicio_BE)
            _ServicioBE = value
        End Set
    End Property

    Private Sub frmListaServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        dtgServicio.DataSource = Nothing
        dtgServicio.AutoGenerateColumns = False
        dtgServicio.DataSource = oServicioOpeNeg.Cargar_Servicios(ServicioBE)

        If Val("" & ServicioBE.STPODP & "") = Comun.eTipoAlmacen.AlmTransito Or Val("" & ServicioBE.STPODP & "") = Comun.eTipoAlmacen.NoAplica Then

            If ServicioBE.CDVSN = "R" Then

                dtgMercaderia.Visible = False
                dtgDetalleServicioSil.Visible = False

                dtgBulto.Visible = True
                dtgBulto.Dock = DockStyle.Fill
                dtgBulto.DataSource = Nothing
                dtgBulto.AutoGenerateColumns = False

                If ServicioBE.CTPALJ = "RE" Then
                    KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
                    KryptonSplitContainer1.Panel2MinSize = 0
                    KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height
                    KryptonSplitContainer1.IsSplitterFixed = True
                Else
                    '==================Detalle de Bultos=========================
                    dtgBulto.DataSource = oServicioOpeNeg.Cargar_Bultos(ServicioBE)
                End If
            Else

                '=============Detalle de SIL======================
                dtgMercaderia.Visible = False
                dtgBulto.Visible = False

                dtgDetalleServicioSil.Visible = True
                dtgDetalleServicioSil.Dock = DockStyle.Fill
                dtgDetalleServicioSil.DataSource = Nothing
                dtgDetalleServicioSil.AutoGenerateColumns = False


                Dim oclsServicioSC_DAL As New clsServicioSC_DAL
                dtgDetalleServicioSil.DataSource = oclsServicioSC_DAL.Lista_Detalle_Servicios_SC(ServicioBE)


            End If

        Else
            '=========================Detalle de Deposito Simple================

            dtgDetalleServicioSil.Visible = False
            dtgBulto.Visible = False

            dtgMercaderia.Visible = True
            dtgMercaderia.Dock = DockStyle.Fill
            dtgMercaderia.DataSource = Nothing
            dtgMercaderia.AutoGenerateColumns = False
            dtgMercaderia.DataSource = oServicioOpeNeg.fdtListaDetalleServiciosFacturacionSA(ServicioBE)

        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dtgDetalleServicioSil_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleServicioSil.CellDoubleClick
        If Me.dtgDetalleServicioSil.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgDetalleServicioSil.Columns(e.ColumnIndex).Name = "DETALLE" Then
            Dim oUcFrmEmbarqueDetalle As New UcFrmEmbarqueDetalle
            oUcFrmEmbarqueDetalle.pCCLNT = ServicioBE.CCLNT
            oUcFrmEmbarqueDetalle.pNORSCI = Me.dtgDetalleServicioSil.Rows(e.RowIndex).Cells("NORSCI").Value
            oUcFrmEmbarqueDetalle.ShowDialog()
        End If
    End Sub
End Class
