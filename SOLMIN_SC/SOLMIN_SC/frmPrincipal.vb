Imports SOLMIN_SC.Negocio

Public Class frmPrincipal
    Private oCliente As clsCliente
    Private oProveedor As clsProveedor
    Private oEnvio As clsEnvio
    Private oPrioridad As clsPrioridad
    Private oUsuario As clsUsuario

    Sub New(ByVal pobjUsuario As Object)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oCliente = New clsCliente
        oCliente.Crea_Lista()
        oProveedor = New clsProveedor
        oProveedor.Crea_Lista()
        oEnvio = New clsEnvio
        oEnvio.Crea_Lista()
        oPrioridad = New clsPrioridad
        oPrioridad.Crea_Lista()
        oUsuario = pobjUsuario
        HelpClass.ClearMemory()
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        Me.tlbMenu.Visible = False
        Me.splDivisor.Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tlbMenu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlbMenu.DoubleClick
        Me.tlbMenu.Hide()
        Me.splDivisor.Visible = True
    End Sub

    Private Sub splDivisor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles splDivisor.Click
        Me.tlbMenu.Visible = True
        Me.splDivisor.Visible = False
    End Sub

    Private Sub mnu_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Salir.Click
        Salir()
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Salir()
    End Sub

    Private Sub Salir()
        If HelpClass.RspMsgBox("Está seguro que desea salir del Sistema?") = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Reportes_Mensuales()
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmVisorReporte") Then
            Dim frm As New frmVisorReporte(CType(oCliente.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_OC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OC.Click
        Orden_Compra()
    End Sub

    Private Sub Orden_Compra()
        Me.Cursor = Cursors.WaitCursor
        'If Not Existe_Ventana("frmOC") Then
        If Not Existe_Ventana("frmOCDet") Then
            'Dim frm As New frmOC(CType(oCliente.Lista, DataTable).Copy, CType(oProveedor.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy, CType(oPrioridad.Lista, DataTable).Copy)
            Dim frm As New frmOCDet(CType(oCliente.Lista, DataTable).Copy, CType(oProveedor.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ocultar_Menu()
        Me.tlbMenu.Visible = False
        Me.splDivisor.Visible = True
    End Sub

    Private Sub MnuCheckPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCheckPoint.Click
        Me.Cursor = Cursors.WaitCursor
        'If Not Existe_Ventana("frmCheckPoint") Then
        If Not Existe_Ventana("frmAsignarCheckpoint") Then
            'Dim frm As New frmCheckPoint(CType(oCliente.Lista, DataTable).Copy, oUsuario.Compania, oUsuario.NomCompania, oUsuario.Division, oUsuario.NomDivision)
            Dim frm As New frmAsignarCheckpoint(CType(oCliente.Lista, DataTable).Copy, oUsuario.Compania, oUsuario.Division)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MnuMultiTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMultiTabla.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmMultiTabla") Then
            Dim frm As New frmMultiTabla(CType(oEnvio.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub ReportesMensualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesMensualesToolStripMenuItem.Click
    '    Reportes_Mensuales()
    'End Sub

    Private Sub OrdenDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeCompraToolStripMenuItem.Click
        Orden_Compra()
    End Sub

    Private Sub btn_Preembarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Preembarque.Click
        'Me.Cursor = Cursors.WaitCursor
        'If Not Existe_Ventana("frmPreembarque") Then
        '    Dim frm As New frmPreembarque(CType(oProveedor.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, oUsuario.Compania, oUsuario.Division, CType(oPrioridad.Lista, DataTable).Copy)

        '    Ocultar_Menu()
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        'End If
        'Me.Cursor = Cursors.Default
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCargaInt") Then
            Dim frm As New frmCargaInt(oUsuario.Compania, oUsuario.Division)
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_SeguimientoAdu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SeguimientoAdu.Click
        Me.Cursor = Cursors.WaitCursor
        'If Not Existe_Ventana("frmSegAduanero") Then
        '    Dim frm As New frmSegAduanero(oUsuario.Compania, oUsuario.Division, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, CType(oPrioridad.Lista, DataTable).Copy)

        '    Ocultar_Menu()
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        'End If
        If Not Existe_Ventana("frmSegEmbarque") Then
            Dim frm As New frmSegEmbarque(oUsuario.Compania, oUsuario.Division, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, CType(oPrioridad.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reporte.Click
        Reportes_Mensuales()
    End Sub

    Private Sub PreEmbarqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreEmbarqueToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmPreembarque") Then
            Dim frm As New frmPreembarque(CType(oProveedor.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, oUsuario.Compania, oUsuario.Division, CType(oPrioridad.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SeguimientoAduaneroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAduaneroToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        'If Not Existe_Ventana("frmSegAduanero") Then
        '    Dim frm As New frmSegAduanero(oUsuario.Compania, oUsuario.Division, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, CType(oPrioridad.Lista, DataTable).Copy)

        '    Ocultar_Menu()
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        'End If
        If Not Existe_Ventana("frmSegEmbarque") Then
            Dim frm As New frmSegEmbarque(oUsuario.Compania, oUsuario.Division, CType(oEnvio.Lista, DataTable).Copy, CType(oCliente.Lista, DataTable).Copy, CType(oPrioridad.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ReportesMensualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesMensualesToolStripMenuItem.Click
        Reportes_Mensuales()
    End Sub

    Private Sub CalculoCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculoCosto.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCalculoCosto") Then
            Dim frm As New frmCalculoCosto(CType(oCliente.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CalculoDeCostoDeOperaciónMensualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculoDeCostoDeOperaciónMensualToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCalculoMensualTotal") Then
            'Dim frm As New frmCalculoMensual(CType(oCliente.Lista, DataTable).Copy)
            Dim frm As New frmCalculoMensualTotal(CType(oCliente.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.MdiChildren(intCont).Activate()
                Return True
            End If
        Next intCont

        Return False
    End Function

    Private Sub MnuProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProveedor.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmProveedor") Then
            Dim frm As New frmProveedor(CType(oCliente.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OrdenDeCompraDetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeCompraDetToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmOCDet") Then
            Dim frm As New frmOCDet(CType(oCliente.Lista, DataTable).Copy, CType(oProveedor.Lista, DataTable).Copy, CType(oEnvio.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MnuMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMercaderia.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmMercaderia") Then
            Dim frm As New frmMercaderia(CType(oCliente.Lista, DataTable).Copy)

            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FrmCargaIntToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaInternacionalToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCargaInt") Then
            Dim frm As New frmCargaInt(oUsuario.Compania, oUsuario.Division)
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SolicitudDeFletesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeFletesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmSolicitudDeFletes") Then
            Dim frm As New frmSolicitudDeFletes()
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmServicio") Then
            Dim frm As New frmServicio(oUsuario.Compania, oUsuario.Division)
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CostoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoItem.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCostoItem") Then
            Dim frm As New frmCostoItem(CType(oCliente.Lista, DataTable).Copy)
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CostoItemOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostoItemOC.Click
        Me.Cursor = Cursors.WaitCursor
        If Not Existe_Ventana("frmCostoItemOC") Then
            Dim frm As New frmCostoItemOC(CType(oCliente.Lista, DataTable).Copy)
            Ocultar_Menu()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class
