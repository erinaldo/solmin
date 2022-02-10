
Public Class frmListaOperacionPeriodo

    Private oServicioOpeNeg As New Ransa.Controls.ServicioOperacion.clsServicio_BL

    Private _oServicio As Ransa.Controls.ServicioOperacion.Servicio_BE
    Public Property oServicio() As Ransa.Controls.ServicioOperacion.Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Ransa.Controls.ServicioOperacion.Servicio_BE)
            _oServicio = value
        End Set
    End Property

    Private Sub frmListaOperacionPeriodo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Lista de operaciones en el periodo de " & oServicio.FechaInicio & " hasta " & oServicio.FechaFin
        UcPorOperacion.OcultarBotones = False
        UcPorOperacion.InhabilitaTabs()
        UcPorOperacion.Refrescar()

    End Sub

    Private Sub Listar_Operaciones(ByVal oServicio As Ransa.Controls.ServicioOperacion.Servicio_BE, ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) Handles UcPorOperacion.Listar_Operaciones
        oServicio = New Ransa.Controls.ServicioOperacion.Servicio_BE

        'UcPorOperacion._pTipoAlmacen = _pTipoAlmacen
        oServicio.CCMPN = "EZ"
        oServicio.PSUSUARIO = oServicio.PSUSUARIO
     
        oServicio.FLGPEN = "0"
        oServicio.FLGFAC = "0"
        oServicio.STPODP = "0"
        oServicio.CTPALJ = "0"
        'oServicio.TCMPDV = UcDivision.DivisionDescripcion
        'oServicio.CCMPN_DESC = U""
        'oServicio.CDVSN_DESC = UcDivision.DivisionDescripcion
        'oServicio.CCLNT_DESC = UcCliente.pRazonSocial

        UcPorOperacion.oServicio = oServicio

        Llenar_ServiciosOperacion(dtg, True)


    End Sub

    Private Sub Llenar_ServiciosOperacion(ByVal dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView, ByVal bolTipo As Boolean)
        Try

            ObtenerFiltros(bolTipo)
             
            Dim oDtSerivcio As DataTable
            oServicio.FECINI = 0
            oServicio.FECFIN = 99999999.0
            oDtSerivcio = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)

            dtg.AutoGenerateColumns = False
            dtg.DataSource = oDtSerivcio
            oServicio.NSECFC = 0
            'If bolTipo Then
            '    HGDatos.ValuesSecondary.Heading = UcPorOperacion.sTotalDatosPorOperacion
            'Else
            '    HGDatos.ValuesSecondary.Heading = UcPorRevision.sTotalDatosPorRevision
            'End If
        Catch : End Try
    End Sub

    Private Sub ObtenerFiltros(ByVal bolTipo As Boolean)
        Dim oDtSerivcio = New DataTable

        'oServicio.TIPO_PROCESO = Lista_Tipo_Proceso()
        'oServicio.CCLNT = oServicio.CCLNT
        'oServicio.CCLNFC = UcClienteFact.pCodigo
        'oServicio.TLUGEN = IIf(cmbLugarEntrega.SelectedIndex > 0, cmbLugarEntrega.SelectedValue, "")

        'If bolTipo Then
        '    If Me.chkFecha.Checked Then
        '        oServicio.FECINI = Comun.FormatoFechaAS400(Me.dtFeInicial.Text)
        '        oServicio.FECFIN = Comun.FormatoFechaAS400(Me.dtFeFinal.Text)
        '    Else
        '        oServicio.FECINI = 0
        '        oServicio.FECFIN = 99999999
        '    End If

        '    If chkFechaOperacion.Checked Then
        '        oServicio.FECSERV_INI = Comun.FormatoFechaAS400(Me.dtpFechaOperacionIni.Text)
        '    Else
        '        oServicio.FECSERV_INI = 0
        '        oServicio.FECSERV_FIN = 0
        '    End If
        '    oServicio.NORCML = txtOrdenCompra.Text.Trim
        'Else
        '    oServicio.FECINI = 0
        '    oServicio.FECFIN = 99999999
        '    oServicio.FECSERV_INI = 0
        '    oServicio.FECSERV_FIN = 0
        '    oServicio.TLUGEN = ""
        '    oServicio.NORCML = ""
        'End If

        'oServicio.CCMPN = UcCompania.CCMPN_CodigoCompania
        'oServicio.CDVSN = UcDivision.Division
        'oServicio.TIPO_PLANTA = Lista_Tipo_Planta()



        oServicio.FLGFAC = "0"

        'oServicio.NRTFSV = Me.cmbServicio.SelectedValue

        oServicio.FLGPEN = "0"

        oServicio.CTPALJ = "0"
     




    End Sub



End Class
