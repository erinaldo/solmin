Imports Ransa.DAO.Servicios
Imports Ransa.TypeDef.Servicios
Imports Ransa.TypeDef.Moneda
Imports Ransa.TypeDef.Servicios.Almacenaje

Public Class ucAlmacenaje_FAlmF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oServicios As cServicios = New Ransa.DAO.Servicios.cServicios
    Private oInf_AddAlmacenaje_L01 As TD_Inf_AddAlmacenaje_L01 = New Ransa.TypeDef.Servicios.Almacenaje.TD_Inf_AddAlmacenaje_L01
    Private pCCMPN_Compania As String = ""
    Private pCDVSN_Division As String = ""
    Private pCPLNDV_Planta As Int32 = 0
    Private pCCLNT_CodigoCliente As Int64 = 0
    Private pSTPODP_TipoSistAlm As String = ""
    Private dtResultado As DataTable
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnConfirm As Boolean = True
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pDatos() As TD_Inf_AddAlmacenaje_L01
        Get
            Return oInf_AddAlmacenaje_L01
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function bValidar() As Boolean
        Dim bResultado As Boolean = True
        Dim sErrorMessage As String = ""
        If txtAnio.Text = "" Then sErrorMessage &= "- Debe Ingresar el Año de Proceso."
        If txtAnio.Text < 0 Then sErrorMessage &= "- El Año de Proceso debe ser mayor a cero."
        If txtMes.Text = "" Then sErrorMessage &= "- Debe Ingresar el Mes de Proceso."
        If txtMes.Text < 0 Then sErrorMessage &= "- El Mes de Proceso debe ser mayor a cero."
        If txtDiaLibres.Text < 0 Then sErrorMessage &= "- El Nro de Días Libres debe ser mayor a Cero."
        If dtpFechaInicial.Value > dtpFechaFinal.Value Then sErrorMessage &= "- La Fecha Inicial debe ser menor a la Fecha Final."
        If cbxServicio.Text = "" Then sErrorMessage &= "- Debe seleccionar un servicio disponible."
        If sErrorMessage <> "" Then
            MessageBox.Show(sErrorMessage, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bResultado = False
        End If
        Return bResultado
    End Function

    Private Function fblnBuscarServicioDisponible(ByVal strDetalle As String, ByRef oTemp As TD_Inf_Servicio_Disponible_F01) As Boolean
        Dim intIndice As Integer = 0
        Dim blnResultado As Boolean = False
        While intIndice < dtResultado.Rows.Count
            If strDetalle.Trim = ("" & dtResultado.Rows(intIndice).Item("DETALLE")).ToString.Trim Then
                With oTemp
                    Int64.TryParse("" & dtResultado.Rows(intIndice).Item("CODIGO"), .pNRTFSV_Tarifa_Servicio)
                    .pNOMSER_Descripcion_Servicio = ("" & dtResultado.Rows(intIndice).Item("DETALLE")).ToString.Trim
                    .pQCNESP_Cantidad_Base = dtResultado.Rows(intIndice).Item("QTBASE")
                    .pTUNDIT_Unidad = ("" & dtResultado.Rows(intIndice).Item("UNIDAD")).ToString.Trim
                End With
                blnResultado = True
                Exit While
            End If
            intIndice += 1
        End While
        Return blnResultado
    End Function

    Private Sub pCargarComboServicios()
        cbxServicio.Items.Clear()
        ' Cargamos la información
        Dim oTemp As TD_Qry_Servicio_Disponible_L01 = New TD_Qry_Servicio_Disponible_L01
        oTemp.pCCMPN_Compania = pCCMPN_Compania
        oTemp.pCDVSN_Division = pCDVSN_Division
        oTemp.pCPLNDV_Planta = pCPLNDV_Planta
        oTemp.pCCLNT_CodigoCliente = pCCLNT_CodigoCliente
        oTemp.pFOPRCN_FechaOperacion = dteFechaOperacion.Value
        dtResultado = oServicios.fdtListar_ServiciosDisponibles_L01(oTemp)
        oTemp = Nothing
        If oServicios.ErrorMessage <> "" Then
            RaiseEvent ErrorMessage(oServicios.ErrorMessage)
        Else
            ' Llenamos el combox
            If dtResultado.Rows.Count > 0 Then
                Dim intFila As Int32 = 0
                For intFila = 0 To dtResultado.Rows.Count - 1
                    cbxServicio.Items.Add(dtResultado.Rows(intFila).Item("DETALLE").ToString.Trim)
                Next
            End If
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        oInf_AddAlmacenaje_L01.pClear()
        Me.Close()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim oTemp As TD_Inf_Servicio_Disponible_F01 = New TD_Inf_Servicio_Disponible_F01
        If Not fblnBuscarServicioDisponible(cbxServicio.Text, oTemp) Then
            MessageBox.Show("Error en el Servicio Seleccionado.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If bValidar() Then
            With oInf_AddAlmacenaje_L01
                .pCCLNT_CodigoCliente = pCCLNT_CodigoCliente
                .pCCMPN_Compania = pCCMPN_Compania
                .pCDVSN_Division = pCDVSN_Division
                .pCPLNDV_Planta = pCPLNDV_Planta
                .pSTPODP_TipoSistAlm = pSTPODP_TipoSistAlm
                .pNANPRC_Ano = txtAnio.Text
                .pNMES_Mes = txtMes.Text
                .pFECINI_FechaInicial = dtpFechaInicial.Value
                .pFECFIN_FechaFinal = dtpFechaFinal.Value
                .pOBSERV_Observacion = txtObservacion.Text
                .pNDIALI_NroDiaLibres = txtDiaLibres.Text
                .pNRTFSV_Tarifa_Servicio = oTemp.pNRTFSV_Tarifa_Servicio
                .pQCNESP_Cantidad_Base = oTemp.pQCNESP_Cantidad_Base
                .pTUNDIT_Unidad = oTemp.pTUNDIT_Unidad
                .pSTPOUN_TipoUnidad = cbxValorizarPor.Text.Substring(0, 1)
                .pCMNDA1_Moneda = cbxMoneda.pInformacionSelec.pCMNDA1_Codigo
                .pVALUNI_ValorUnitario = txtValorRef.Text
                If chkFiltro.Checked Then
                    .pSTPFLT_ConsiderarFiltros = "S"
                Else
                    .pSTPFLT_ConsiderarFiltros = "N"
                End If
                .pCREFFW_CodigoBulto = txtCodigoRecepcion.Text.Trim
                .pNROPLT_NroPaleta = txtPaleta.Text.Trim
                .pTTINTC_TermInterCarga = cmbTermInter.pInformacionSelec.pCCMPRN_Codigo
                .pTUBRFR_Ubicacion = txtUbicacion.Text
                '.pSTPING_TipoMovimiento = ""
                '.pCRTLTE_CriterioLote = ""
                '.pUSUARI = ""
            End With
            Me.Close()
        End If
    End Sub

    Private Sub chkFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged
        grpFiltro.Enabled = chkFiltro.Checked
    End Sub

    Private Sub dteFechaOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaOperacion.ValueChanged
        Call pCargarComboServicios()
    End Sub

    Private Sub ucAlmacenaje_FAlmF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oServicios.Dispose()
        oServicios = Nothing
    End Sub

    Private Sub ucAlmacenaje_FAlmF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call pCargarComboServicios()
    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal Planta As Int32, ByVal Cliente As Int64, ByVal TipoAlmacen As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pCCMPN_Compania = Compania
        pCDVSN_Division = Division
        pCPLNDV_Planta = Planta
        pCCLNT_CodigoCliente = Cliente
        pSTPODP_TipoSistAlm = TipoAlmacen
        txtUbicacion.pCargarInformacion(pCCLNT_CodigoCliente)
    End Sub
#End Region
End Class