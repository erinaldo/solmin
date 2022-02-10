Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Rpt.Mercaderia

Public Class ucMovMercaderias_F03
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal ErrorMsg As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirm(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event ImprimirReporte(ByVal Reporte As ReportDocument)
    ' Eventos a Informar
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_Resultado As TD_Rpt_Resultado = New Ransa.Rpt.Mercaderia.TD_Rpt_Resultado
    Private strMensajeError As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pReporte() As ReportDocument
        Get
            If TD_Resultado.pNroTablas <= 0 Then Exit Property
            Return TD_Resultado.pReport
        End Get
    End Property

    Public ReadOnly Property pTables() As DataTableCollection
        Get
            If TD_Resultado.pNroTablas <= 0 Then Exit Property
            Return TD_Resultado.Tables
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    'Private Sub pCargarInformacion()
    '    If TD_Filtro.pCCLNT_CodigoCliente <> 0 Then
    '        strMensajeError = ""
    '        blnCargando = True
    '        dgMercaderia.DataSource = cMercaderia.fdtListar_Mercaderias_L01(objSqlManager, TD_Filtro, intNroTotalPaginas, strMensajeError)
    '        blnCargando = False
    '        If strMensajeError <> "" Then
    '            TD_Filtro.pNROPAG_NroPagina = 1
    '            intNroTotalPaginas = 0
    '            Call pMostrarDetallePosicion()
    '            RaiseEvent ErrorMessage(strMensajeError)
    '        Else
    '            If dgMercaderia.RowCount > 0 Then
    '                TD_MercaderiaActual.pCCLNT_CodigoCliente = TD_Filtro.pCCLNT_CodigoCliente
    '                TD_MercaderiaActual.pCFMCLR_Familia = dgMercaderia.CurrentRow.Cells("M_CFMCLR").Value.ToString.Trim
    '                TD_MercaderiaActual.pCGRCLR_Grupo = dgMercaderia.CurrentRow.Cells("M_CGRCLR").Value.ToString.Trim
    '                TD_MercaderiaActual.pCMRCLR_Mercaderia = dgMercaderia.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
    '                TD_MercaderiaActual.pCMRCD_CodigoRansa = dgMercaderia.CurrentRow.Cells("M_CMRCD").Value.ToString.Trim
    '                intFilaActual = 0
    '            Else
    '                TD_MercaderiaActual.pClear()
    '                intFilaActual = -1
    '            End If
    '            Call pMostrarDetallePosicion()
    '            RaiseEvent DataLoadCompleted(TD_MercaderiaActual)
    '        End If
    '    Else
    '        Call pLimpiarContenido()
    '    End If
    'End Sub

    'Private Sub pLimpiarContenido()
    '    blnCargando = True
    '    lblMercadería.Text = lblMercadería.Tag
    '    dgMercaderia.DataSource = Nothing
    '    blnCargando = False
    '    ' Limpiamos el bulto Seleccionada
    '    TD_MercaderiaActual.pClear()
    '    intFilaActual = -1
    '    TD_Filtro.pNROPAG_NroPagina = 1
    '    intNroTotalPaginas = 0
    '    Call pMostrarDetallePosicion()
    '    RaiseEvent TableWithOutData()
    'End Sub
#End Region
#Region " Eventos "
    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        Dim oFiltro As TD_Rpt_RepMovProductos_R03 = New TD_Rpt_RepMovProductos_R03

        With oFiltro
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pFMOVI_FechaMovIniDte = dteFechaInicial.Value
            .pFMOVF_FechaMovFinDte = dteFechaFinal.Value
            .pSTPODP_TipoDeposito = "1"
            .pUsuario = .pUsuario
        End With

        strMensajeError = ""
        Dim rdocTemp As ReportDocument = Nothing
        Dim oResultado As TD_Rpt_Resultado = rMercaderia.frptListar_MovMercaderias_R03(objSqlManager, oFiltro, strMensajeError)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            RaiseEvent ImprimirReporte(oResultado.pReport)
        End If
    End Sub

    Private Sub ucMercaderia_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub
#End Region
#Region " Métodos "
    'Public Sub pClear()
    '    Call pLimpiarContenido()
    'End Sub
#End Region
End Class
