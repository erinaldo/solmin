Imports Ransa.Controls.ServicioOperacion
Public Class clsServicio_BL
    Private oServicioDat As DATOS.clsServicio_DAL
    Private bolTipoRevision As Boolean = False

    Sub New()
        oServicioDat = New DATOS.clsServicio_DAL
    End Sub

    Public Sub Quitar_Servicio(ByVal pobjServicioSIL As Servicio_BE)
        'Try
        oServicioDat.Quitar_Servicio(pobjServicioSIL)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    Public Sub AnularConsistencia(ByVal oServicio As Servicio_BE)
        'Try
        oServicioDat.AnularConsistencia(oServicio)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    Public Sub AnularConsistenciaMasivo(ByVal oServicio As Servicio_BE)
        oServicioDat.AnularConsistenciaMasivo(oServicio)
    End Sub

    Public Function Lista_Servicios_x_Cliente(ByVal oServicioSIL As Servicio_BE) As DataTable
        'Try
        Return oServicioDat.Lista_Servicios_x_Cliente(oServicioSIL)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Function

    Public Function Lista_Servicios_Consolidado(ByVal oServicio As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Servicios_Consolidado(oServicio)
    End Function
    Public Function Lista_OperacionesRevisadas(ByVal oServicio As Servicio_BE) As DataTable
        Return oServicioDat.Lista_OperacionesRevisadas(oServicio)
    End Function

    Public Function Lista_Detalle_Servicios_SIL(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Detalle_Servicios_SIL(oServicioSIL)
    End Function
    Public Function Lista_Detlle_Servicios_Almacen(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Detalle_Servicios_Almacen(oServicioSIL)
    End Function

    Public Function Verificar_Servicios_Atendidos(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Verificar_Servicios_Atendidos(oServicioSIL)
    End Function
    Public Function Cargar_Servicios_Tarifa_Cliente(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Tarifa_Servicios_Cliente(oServicioSIL)
    End Function
    Public Function Lista_Tarifa_Servicios_Cliente_Permanencia(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Tarifa_Servicios_Cliente_Permanencia(oServicioSIL)
    End Function
    Public Function fdtListaServicioOperacion(ByVal oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaServicioOperacion(oServicios)
    End Function

    'Tipo Proceso
    Public Function Listar_TablaAyuda_L01(ByVal strCategoria As String) As DataTable
        Return oServicioDat.Listar_TablaAyuda_L01(strCategoria)
    End Function

    Public Function Listar_TablaAyuda_L02(ByVal strCategoria As String) As DataTable
        Return oServicioDat.Listar_TablaAyuda_L02(strCategoria)
    End Function



    Public Function fdtListaRubroXCompaniaDivision(ByVal oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaRubroXCompaniaDivision(oServicios)
    End Function

    Public Function ListaServiciosEsp(ByVal strDivision As String, Optional ByVal strTodo As Integer = 0) As DataTable '1= Adicionar Todos
        Dim dtServiciosEsp As New DataTable
        Dim dtSer As New DataTable
        Dim drw As DataRow
        If strDivision = "R" Then
            dtServiciosEsp = Listar_TablaAyuda_L01("TIPSER") 'tipo servicio Almacen
        ElseIf strDivision = "S" OrElse strDivision = "T" Then
            dtServiciosEsp = Listar_TablaAyuda_L01("TIPSES") 'tipo servicio Sil
        Else
            dtServiciosEsp = Nothing
        End If
        If dtServiciosEsp Is Nothing Then
            Return Nothing
            Exit Function
        End If

        dtSer = dtServiciosEsp.Clone
        If strTodo = 1 Then 'AGREGAMOS EL TODOS PARA EL CASO DE CONSISTENCIAS
            drw = dtSer.NewRow
            drw("SMARCA") = -1
            drw("TDSDES") = "TODOS"
            drw("CCMPRN") = "0"
            dtSer.Rows.Add(drw)
        End If
        For Each dr As DataRow In dtServiciosEsp.Rows
            drw = dtSer.NewRow
            drw("SMARCA") = dr("SMARCA")
            drw("TDSDES") = dr("TDSDES")
            drw("CCMPRN") = dr("CCMPRN")
            dtSer.Rows.Add(drw)
        Next
        Return dtSer
    End Function
    Public Function ListaTipoAlmacenaje(ByVal strDivision As String) As DataTable
        Dim oTabla As New DataTable
        Dim oDr As DataRow
        oTabla.Columns.Add("COD")
        oTabla.Columns.Add("VAL")
        If strDivision = "R" Then
            oDr = oTabla.NewRow
            oDr("COD") = "7"
            oDr("VAL") = "Almacén de Transito"
            oTabla.Rows.Add(oDr) '----
            oDr = oTabla.NewRow
            oDr("COD") = "1"
            oDr("VAL") = "Depósito Simple"
            oTabla.Rows.Add(oDr) '----
        Else : strDivision = "S"
            oDr = oTabla.NewRow
            oDr("COD") = "0"
            oDr("VAL") = "No Aplica"
            oTabla.Rows.Add(oDr) '----
        End If
        Return oTabla
    End Function

#Region "SERVICIOS DE FACTURACION ALMACEN"
    ''' <summary>
    ''' Inserta Nr. Operacion 
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdecInsertarOperacionFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
        Return oServicioDat.fdecInsertarOperacionFacturacionSA(oServicios)
    End Function



    ''' <summary>
    ''' Actualiza la operaciòn
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdecActualizarOperacionFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
        Return oServicioDat.fdecActualizarOperacionFacturacionSA(oServicios)
    End Function
    ''' <summary>
    ''' Inserta Servicios a Facturar  
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns>Nr. de operación</returns>
    ''' <remarks></remarks>
    'Public Function fdecInsertarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Decimal
    '    Return oServicioDat.fdecInsertarServiciosFacturacionSA(oServicios)
    'End Function

    Public Function fdecInsertarServiciosFacturacionSA(ByVal oServicios As Servicio_BE, ByRef NCRROP As Decimal) As String
        Return oServicioDat.fdecInsertarServiciosFacturacionSA(oServicios, NCRROP)
    End Function


    ' ByRef NCRROP As Decimal
    ''' <summary>
    ''' Actualiza servicio a facturar
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function fintActualizarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Integer
    '    Return oServicioDat.fintActualizarServiciosFacturacionSA(oServicios)
    'End Function

    Public Function fintActualizarServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As String
        Return oServicioDat.fintActualizarServiciosFacturacionSA(oServicios)
    End Function




    ''' <summary>
    ''' Almacen Listar Para Modificar
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtObtenerServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As DataSet
        Return oServicioDat.fdtObtenerServiciosFacturacionSA(oServicios)
    End Function
    ''' <summary>
    ''' Insertar Detalle Servicio a facturar
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fstrInsertarDetalleServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As String

        Select Case oServicios.STPODP
            Case Comun.eTipoAlmacen.AlmTransito '"7"
                Return oServicioDat.fstrInsertarDetalleServiciosFacturacionSA_SAT(oServicios)
            Case Comun.eTipoAlmacen.DepSimple '"1"
                Return oServicioDat.fstrInsertarDetalleServiciosFacturacionSA_SDS(oServicios)
            Case Else
                Return "Tipo Almacen No disponible"
        End Select
    End Function

    ''' <summary>
    ''' Insertar Detalle Servicio a facturar
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fstrInsertarDetalleServiciosPromediosSA_RZSC25(ByVal oServicios As Servicio_BE) As String

        Select Case oServicios.STPODP
            Case Comun.eTipoAlmacen.AlmTransito '"7"
                Return oServicioDat.fstrInsertarDetalleServiciosPromediosSA_RZSC25(oServicios)
            Case Else
                Return "Tipo Almacen No disponible"
        End Select
    End Function


    ''' <summary>
    ''' Elimina logicamente la tabla RZSC22 
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintEliminarDetalleServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As Integer
        Return oServicioDat.fintEliminarDetalleServiciosFacturacionSA(oServicios)
    End Function


    ''' <summary>
    ''' Actualiza detalle de contrato tabla bd RZSC22
    ''' </summary>
    ''' <param name="oDetalleServicio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintActualizarDetalleServiciosFacturacionSA(ByVal oDetalleServicio As Servicio_BE) As Integer
        Return oServicioDat.fintActualizarDetalleServiciosFacturacionSA(oDetalleServicio)
    End Function

    'Almacen Listar Bultos de la operacion Para Modificar
    Public Function fdtListaDetalleServiciosFacturacionSA(ByVal oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaDetalleServiciosFacturacionSA(oServicios)
    End Function
    ''' <summary>
    ''' lista los servicios de reembolso
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtObtenerServiciosFacturacionReembolso(ByVal oServ As Servicio_BE) As DataSet
        Return oServicioDat.fdtObtenerServiciosFacturacionReembolso(oServ)
    End Function

    ''' <summary>
    ''' Obtine lista de Bultos a los que se va generar Operacion
    ''' </summary>
    ''' <param name="oServicios"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaBultoFacturarSA(ByRef oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaBultoFacturarSA(oServicios)
    End Function

    Public Function fintInsertarServiciosFacturacionAlmacenajeSA(ByVal oServicios As Servicio_BE) As Integer
        If oServicios.STPODP = "7" Then
            Return oServicioDat.fintInsertarServiciosFacturacionAlmacenajeSA(oServicios)
        Else : Return -1
        End If
    End Function

    Public Function fintActulizarServiciosFacturacionAlmacenajeSA(ByVal oServicios As Servicio_BE) As Integer
        If oServicios.STPODP = "7" Then
            Return oServicioDat.fintActulizarServiciosFacturacionAlmacenajeSA(oServicios)
        Else : Return -1
        End If
    End Function

    ''' <summary>
    ''' Lista detalle de bulto
    ''' </summary>
    ''' <param name="oDetalleServicio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListarDetalleBulto(ByVal oDetalleServicio As Servicio_BE) As DataTable

        Return oServicioDat.fdtListarDetalleBulto(oDetalleServicio)

    End Function
    Public Function RptOS_Almacen_RZSC22(ByVal oDetalleServicio As Servicio_BE) As DataTable
        Return oServicioDat.RptOS_Almacen_RZSC22(oDetalleServicio)
    End Function

    Public Function fdtListaSolicitudDeServicioSDS(ByRef oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaSolicitudDeServicioSDS(oServicios)
    End Function
    Public Function fstrEliminaServicioOperacionSA_SDS_Permanencia(ByVal oServ As Servicio_BE) As String
        Return oServicioDat.fstrEliminaServicioOperacionSA_SDS_Permanencia(oServ)
    End Function

    'Especiales
    ''' <summary>
    ''' Inserta Servicio Especial Reembolso
    ''' </summary>
    ''' <param name="oServReembolso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fstrInsertarDetalleServiciosFactReembolsoSA(ByVal oServReembolso As ServicioReembolso_BE) As String
        Return oServicioDat.fstrInsertarDetalleServiciosFactReembolsoSA(oServReembolso)
    End Function
    ''' <summary>
    ''' Actualiza Servicio Especial Reembolso
    ''' </summary>
    ''' <param name="oServReembolso"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fintActualizarDetalleServiciosFactReembolsoSA(ByVal oServReembolso As ServicioReembolso_BE) As String
        Return oServicioDat.fintActualizarDetalleServiciosFactReembolsoSA(oServReembolso)
    End Function
    ''' <summary>
    ''' Anula Operacion de Reembolso
    ''' </summary>
    ''' <param name="oServ "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AnularOperacionReembolsoSA(ByVal oServ As Servicio_BE) As String
        Return oServicioDat.AnularOperacionReembolsoSA(oServ)
    End Function
    ''' <summary>
    ''' ANULA OPERACION Y SUS DETALLES EN CASO DE SER REEMBOLSO
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AnularOperacionReembolsoSA_ALL(ByVal oServ As Servicio_BE) As String
        Return oServicioDat.AnularOperacionReembolsoSA_ALL(oServ)
    End Function
    ''' <summary>
    ''' Lista Servicio Especial Reembolso
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaDetalleServiciosReembolso(ByVal oServ As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaDetalleServiciosReembolso(oServ)
    End Function
    ''' <summary>
    ''' Anula Operacion de Segun Promedios
    ''' </summary>
    ''' <param name="oServ "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AnularOperacionPromediosSA(ByVal oServ As Servicio_BE) As String
        Return oServicioDat.AnularOperacionPromediosSA(oServ)
    End Function

    ''' <summary>
    ''' Listar Bultos Almacenaje
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarBultosAlmacenaje_RangoFecha(ByVal oServ As Servicio_BE) As DataTable
        Return oServicioDat.ListarBultosAlmacenaje_RangoFecha(oServ)
    End Function

    ''' <summary>
    ''' Listar Bultos Almacenaje Promedio
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarBultosAlmacenaje_Promedio(ByVal oServ As Servicio_BE) As DataSet
        Return oServicioDat.ListarBultosAlmacenaje_Promedio(oServ)
    End Function

    Public Function ListarBultosAlmacenaje_Promedio_RZSC25(ByVal oServ As Servicio_BE) As DataSet
        Return oServicioDat.ListarBultosAlmacenaje_Promedio_RZSC25(oServ)
    End Function

    Public Function ListarBultosAlmacenaje_RangoFecha_MP(ByVal oServ As Servicio_BE) As DataTable
        Return oServicioDat.ListarBultosAlmacenaje_RangoFecha_MP(oServ)
    End Function
#End Region
#Region "CONSISTENCIAR"
    Public Function ObtenerCodigoConsistencia() As DataTable
        Return oServicioDat.ObtenerCodigoConsistencia()
    End Function


    Public Function ActualizarServicio_Atendido(ByVal poServiciosAtendidos As Servicio_BE) As Integer
        'Try
        Return oServicioDat.ActualizarServicio_Atendido(poServiciosAtendidos)
        'Catch ex As Exception
        '    Return 0
        '    Throw New Exception(ex.Message)
        'End Try
    End Function

    Public Function GenerarConsistenciaMasivo(ByVal poServiciosAtendidos As Servicio_BE) As Decimal
        Return oServicioDat.GenerarConsistenciaMasivo(poServiciosAtendidos)
    End Function
#End Region
    Public Function intTieneProvision(ByVal poServiciosAtendidos As Servicio_BE) As Integer
        'Try
        Return oServicioDat.intTieneProvision(poServiciosAtendidos)
        'Catch ex As Exception
        '    Return 0
        '    Throw New Exception(ex.Message)
        'End Try
    End Function



    Public Function Lista_Tipo_Cambio(ByVal oLis As List(Of String)) As DataTable
        Return oServicioDat.Lista_Tipo_Cambio(oLis)
    End Function

    Public Function Lista_Servicios_Activos(ByRef oServicios As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.Lista_Servicios_Activos(oServicios)
        Dim dtSer As New DataTable
        dtSer = oDt.Clone
        Dim drw As DataRow
        drw = dtSer.NewRow
        drw("NRTFSV") = "0"
        drw("DESTAR") = "------TODOS------"
        dtSer.Rows.Add(drw)
        For Each dr As DataRow In oDt.Rows
            drw = dtSer.NewRow
            drw("NRTFSV") = dr("NRTFSV")
            drw("DESTAR") = dr("DESTAR")
            dtSer.Rows.Add(drw)
        Next
        Return dtSer

    End Function

    Public Function fdtListaMedioEnvio() As DataTable
        Dim oDt As DataTable = oServicioDat.fdtListaMedioEnvio()
        Return oDt
    End Function

    Public Function ListaCentroCosto(ByVal sCompania As String) As DataTable
        Dim oDt As DataTable = oServicioDat.Lista_CentroCosto(sCompania)
        Return oDt
    End Function
    Public Function DetalleFactura(ByVal oServicio As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.DetalleFactura(oServicio)
        Return oDt
    End Function

#Region "Servicio por permanencia"


    ''' <summary>
    ''' Lista Servicios Por Permanencia
    ''' </summary>
    ''' <param name="oServ"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListaServicioPermanencia(ByVal oServ As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaServicioPermanencia(oServ)
    End Function

    Public Function EliminarServiciosFacturacionAlmacenaje(ByVal oServ As Servicio_BE) As Integer
        Return oServicioDat.EliminarServiciosFacturacionAlmacenaje(oServ)
    End Function


    Public Function fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(ByVal oServ As Servicio_BE) As String
        Return oServicioDat.fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(oServ)
    End Function
    Public Function ListarLotes(ByVal intCliente As Integer) As DataTable
        Dim oDt As DataTable = oServicioDat.ListarLotes(intCliente)
        Dim dtSer As New DataTable
        dtSer = oDt.Clone
        Dim drw As DataRow
        drw = dtSer.NewRow
        drw(0) = "0"
        drw(1) = "------TODOS------"
        dtSer.Rows.Add(drw)
        For Each dr As DataRow In oDt.Rows
            drw = dtSer.NewRow
            drw(0) = dr(0)
            drw(1) = dr(1)
            dtSer.Rows.Add(drw)
        Next
        Return dtSer
    End Function

    Public Function ListarLotesMantenimiento(ByVal intCliente As Integer) As DataTable
        Dim oDt As DataTable = oServicioDat.ListarLotes(intCliente)
        Dim dtSer As New DataTable
        dtSer = oDt.Clone
        Dim drw As DataRow
        drw = dtSer.NewRow
        drw(0) = "0"
        drw(1) = ""
        dtSer.Rows.Add(drw)
        For Each dr As DataRow In oDt.Rows
            drw = dtSer.NewRow
            drw(0) = dr(0)
            drw(1) = dr(1)
            dtSer.Rows.Add(drw)
        Next
        Return dtSer
    End Function

    Public Function ListarLotesManipuleo(ByVal intCliente As Integer) As DataTable
        Dim oDt As DataTable = oServicioDat.ListarLotesManipuleo(intCliente)
        Dim dtSer As New DataTable
        dtSer = oDt.Clone
        Dim drw As DataRow
        drw = dtSer.NewRow
        drw(0) = "0"
        drw(1) = "------TODOS------"
        dtSer.Rows.Add(drw)
        For Each dr As DataRow In oDt.Rows
            drw = dtSer.NewRow
            drw(0) = dr(0)
            drw(1) = dr(1)
            dtSer.Rows.Add(drw)
        Next
        Return dtSer
    End Function

    Public Function ListarSentidoCargaManipuleo() As DataTable
        Dim oDt As DataTable = oServicioDat.ListarSentidoCargaManipuleo()
        Dim dtSer As New DataTable
        dtSer = oDt.Clone
        Dim drw As DataRow
        drw = dtSer.NewRow
        drw(0) = "0"
        drw(1) = "------TODOS------"
        dtSer.Rows.Add(drw)
        For Each dr As DataRow In oDt.Rows
            drw = dtSer.NewRow
            drw(0) = dr(0)
            drw(1) = dr(1).ToString.Trim
            dtSer.Rows.Add(drw)
        Next
        Return dtSer
    End Function

    Public Function ObtieneCodigoProveedor(ByVal strRuc As String) As String
        Return oServicioDat.ObtieneCodigoProveedor(strRuc)
    End Function
    Public Function ObtieneRUCTransportista(ByVal strCodigo As String) As String
        Return oServicioDat.ObtieneRUCTransportista(strCodigo)
    End Function

    ''' <summary>
    ''' Carga los Tipos de Mercaderia
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_TipoMaterial() As DataTable
        Return oServicioDat.Listar_TipoMaterial()
    End Function


    ''' <summary>
    ''' Carga los Tipos de Almacen
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_TipoAlmacen(ByVal intCliente As Integer) As DataTable
        Return oServicioDat.Listar_TipoAlmacen(intCliente)
    End Function
    Public Function Listar_TipoDeAlmacen() As DataTable
        Return oServicioDat.Listar_TipoDeAlmacen()
    End Function

    ''' <summary>
    ''' Carga los AlmacenES
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_Almacenes(ByVal oServ As Servicio_BE) As DataTable
        Dim oDtAlmacen As DataTable = oServicioDat.Listar_Almacenes(oServ)
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDtAlmacen.Copy
        If objDt.Rows.Count > 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function
    ''' <summary>
    ''' Carga los Zonas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_Zonas(ByVal oServ As Servicio_BE) As DataTable
        Dim oDtZona As DataTable = oServicioDat.Listar_Zonas(oServ)
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDtZona.Copy
        If objDt.Rows.Count > 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function
    Public Function Importa_CI_CargoPlan(ByVal oServ As Servicio_BE) As DataSet
        Return oServicioDat.Importa_CI_CargoPlan(oServ)
    End Function

    Public Function fstrValidaDocumentoReembolosSA(ByVal oServReembolso As ServicioReembolso_BE) As String
        Return oServicioDat.fstrValidaDocumentoReembolosSA(oServReembolso)
    End Function

#End Region

#Region "Reporte de Consistencia por Numero de Revision"

    Public Sub pExportarConsistenciaRevisionExcel(ByVal obj_Servicio As Servicio_BE, ByVal tipo_cambio As Decimal, ByVal valor_igv As Decimal, _
                                                ByVal strTipoRep As String, ByRef strMensaje As String, _
                                                Optional ByVal bolVarios As Boolean = False, Optional ByVal ListRevision As List(Of Servicio_BE) = Nothing)


        bolTipoRevision = bolVarios


        Dim oDs As New DataSet
        Dim oDtRep As New DataTable
        Dim oDtRepTarif As New DataTable
        Dim oDtRepServTarif As New DataTable
        Dim oDtRepFiltros As New DataTable
        Dim oDtTempFiltro As New DataTable
        Dim posFiltros As Integer = 0
        Dim oDr As DataRow
        Dim lastOrdinal As Integer = 0
        Dim nombreColmun As String = ""
        Dim tipoColumn As String = ""
        Dim cadenaWhere As String = ""
        Dim subTotalAcum As Double = 0D
        Dim z As Integer = 0
        Dim x As Integer = 0
        Dim oDsAdd As New DataSet
        Dim oDtReem As DataTable = Nothing
        Dim oServicioAtendido As New Servicio_BE
        Dim oDtAux As New DataTable
        Dim CantRevision As Integer = 0

        Dim objDt As New DataTable
        Dim oDsExcel As New DataSet
        Dim obj_Logica As New clsConsistencia_BL
        Dim bolTipoAlm_Simple As Boolean = False

        Try

            obj_Servicio.CMNDA1 = 100
            obj_Servicio.FULTAC = Format(Now, "yyyyMMdd")


            '===================
            If bolVarios Then

                For Each s As Servicio_BE In ListRevision

                    oServicioAtendido = New Servicio_BE
                    oServicioAtendido.NSECFC = s.NSECFC
                    oServicioAtendido.STPODP = s.STPODP
                    oServicioAtendido.CTPALJ = IIf(obj_Servicio.CDVSN = "S", "SL", s.CTPALJ)
                    oServicioAtendido.FLGFAC = obj_Servicio.FLGFAC
                    obj_Servicio.NSECFC = oServicioAtendido.NSECFC

                    obj_Servicio.TIPO_PLANTA = s.TIPO_PLANTA
                    'obj_Servicio.CPLNDV = s.CPLNDV
                    obj_Servicio.CTPALJ = s.CTPALJ
                    obj_Servicio.STPODP = s.STPODP

                    If CantRevision = 0 Then
                        'Reporte Horizontal
                        oDtRep = DetalleFactura(oServicioAtendido)

                        'Reporte Vertical

                        If obj_Servicio.CDVSN = "R" Then
                            objDt = obj_Logica.Lista_Detalle_Servicios_Almacen(obj_Servicio)
                        Else
                            objDt = obj_Logica.Lista_Detalle_Servicios_SIL(obj_Servicio)
                        End If


                    Else
                        'Reporte Horizontal
                        oDtAux = DetalleFactura(oServicioAtendido)
                        For Each dr As DataRow In oDtAux.Rows
                            oDtRep.ImportRow(dr)
                        Next

                        'Reporte Vertical
                        If obj_Servicio.CDVSN = "R" Then
                            oDtAux = obj_Logica.Lista_Detalle_Servicios_Almacen(obj_Servicio)
                        Else
                            oDtAux = obj_Logica.Lista_Detalle_Servicios_SIL(obj_Servicio)
                        End If

                        For Each dr As DataRow In oDtAux.Rows
                            objDt.ImportRow(dr)
                        Next

                    End If

                    CantRevision += 1
                Next

                If Not oServicioAtendido.CTPALJ = "RE" And obj_Servicio.CDVSN = "R" And Not oServicioAtendido.STPODP = "1" Then
                    oDtRep.DefaultView.Sort = "NSECFC,NOPRCN,TDSDES,NRTFSV,NORCML,FECHA,QBLTSR"
                    oDtRep = oDtRep.DefaultView.ToTable
                End If


            Else

                '==================Filtros para el reporte Horizontal========================
                oServicioAtendido.NSECFC = obj_Servicio.NSECFC
                oServicioAtendido.CTPALJ = IIf(obj_Servicio.CDVSN = "S", "SL", obj_Servicio.CTPALJ)
                oServicioAtendido.FLGFAC = obj_Servicio.FLGFAC
                oServicioAtendido.STPODP = ("" & obj_Servicio.STPODP & "")

                oDtRep = DetalleFactura(oServicioAtendido)


                '==================Filtros para el reporte Vertical==========================
                If obj_Servicio.CDVSN = "R" Then
                    objDt = obj_Logica.Lista_Detalle_Servicios_Almacen(obj_Servicio)
                Else
                    objDt = obj_Logica.Lista_Detalle_Servicios_SIL(obj_Servicio)
                End If



            End If

            If oDtRep.Rows.Count = 0 Then
                strMensaje = "No se Encuentran Registros "
                Exit Sub
            End If

            '=============================



            Dim guia As String = ""
            Dim nCountGuia As Integer = 0
            Dim dtGuia As New DataTable
            Dim drAux As DataRow
            dtGuia = oDtRep.Clone

            '===============Se Elimina los pesos de los bultos repetidos=========================
            If obj_Servicio.CTPALJ <> "RE" And obj_Servicio.CDVSN = "R" And Not oServicioAtendido.STPODP = "1" Then

                For i As Integer = 0 To oDtRep.Rows.Count - 1
                    nCountGuia = 0
                    drAux = dtGuia.NewRow()
                    drAux("CREFFW") = oDtRep.Rows(i).Item("CREFFW")
                    drAux("NSEQIN") = oDtRep.Rows(i).Item("NSEQIN")

                    drAux("QPSOBL") = oDtRep.Rows(i).Item("QPSOBL")
                    dtGuia.Rows.Add(drAux)

                    For Each drGuia As DataRow In dtGuia.Select("CREFFW='" & oDtRep.Rows(i).Item("CREFFW") & "'AND QPSOBL > 0 AND NSEQIN=" & oDtRep.Rows(i).Item("NSEQIN"))
                        nCountGuia += 1
                        If nCountGuia > 1 Then Exit For
                    Next

                    If nCountGuia > 1 Then oDtRep.Rows(i).Item("QPSOBL") = 0.0
                    oDtRep.AcceptChanges()
                Next

            End If


            If objDt.Rows.Count > 0 Then

                oDsExcel.Tables.Add(objDt.Copy)

                oDsAdd = GenerarSustentoExcel(oDsExcel, obj_Servicio, strTipoRep, tipo_cambio, valor_igv, oDtReem)
            End If
            '===================


            '' ''Buscamos Las tarifas existentes en la consistencia
            Dim oDtv As New DataView(oDtRep.Copy)
            oDtv.Sort = "NSECFC ASC, TDSDES DESC"
            oDtRepServTarif = oDtv.ToTable(True, "NRTFSV", "IVLSRV", "NRSRRB", "NRRUBR", "NOMSER", "TDSDES")
            '' ''Le damos el nombre de columna a los captions'' ''
            For i As Integer = 0 To oDtRep.Columns.Count - 1
                oDtRep.Columns(i).Caption = oDtRep.Columns(i).ColumnName.ToString
            Next

            Dim rowsDinamic As Integer = oDtRep.Rows.Count

            Select Case obj_Servicio.STPODP

                Case "", "7", "0"

                    If obj_Servicio.CTPALJ <> "RE" Then

                        If obj_Servicio.CDVSN = "S" Then

                            lastOrdinal = 28

                            'Creamos La cantidad de Columnas Como Servicios Existan
                            For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                                nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                                tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                                oDtRep.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                                oDtRep.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                                oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                                oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                            Next
                            lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                            oDtRep.Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

                            With oDtRep
                                '===Ordenamos las Columnas y Seteamos sus nombres===

                                .Columns("FOPRCN").ColumnName = "Fecha Operación"
                                .Columns("FECINI").ColumnName = "Fecha Inicio Servicio"
                                .Columns("FECFIN").ColumnName = "Fecha Fin Servicio"
                                .Columns("TMNDA").ColumnName = "Moneda"
                                .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                                .Columns("NOMSER").ColumnName = "Tipo Servicio"
                                .Columns("TCMTRF").ColumnName = "Servicio"
                                .Columns("NORSCI").ColumnName = "Embarque"
                                .Columns("NDOCEM").ColumnName = "Doc. Embarque"
                                .Columns("CZNFCC").ColumnName = "Cod. Zona"
                                .Columns("TZNFCC").ColumnName = "Zona"
                                .Columns("PNNMOS").ColumnName = "O/S"
                                .Columns("TNRODU").ColumnName = "DUA"
                                .Columns("TCANAL").ColumnName = "Canal"
                                .Columns("CMEDTR").ColumnName = "Medio Transporte"
                                .Columns("CPAIS").ColumnName = "Cod. Pais"
                                .Columns("TCMPPS").ColumnName = "Pais"
                                .Columns("TCMPVP").ColumnName = "Nave"
                                .Columns("FAPREV").ColumnName = "ETD"
                                .Columns("FAPRAR").ColumnName = "ETA"
                                .Columns("FORSCI").ColumnName = "Fec. Apertura"
                                .Columns("REGIMEN").ColumnName = "REGIMEN"
                                .Columns("DESPACHO").ColumnName = "DESPACHO"
                                .Columns("TRANSPORTE").ColumnName = "TRANSPORTE"
                            End With

                        Else
                            With oDtRep
                                '=====================Detalle de bultos===============
                                '===Ordenamos las Columnas y Seteamos sus nombres===
                                Dim intX As Integer = 0
                                .Columns("NSECFC").SetOrdinal(intX)
                                intX += 1
                                .Columns("NOPRCN").SetOrdinal(intX)
                                intX += 1
                                .Columns("FOPRCN").SetOrdinal(intX)
                                .Columns("FOPRCN").ColumnName = "Fecha Operación"
                                intX += 1
                                .Columns("TDSDES").SetOrdinal(intX)
                                intX += 1

                                .Columns("TRDCCL").SetOrdinal(intX)
                                .Columns("TRDCCL").ColumnName = "Referencia Operación"
                                intX += 1

                                .Columns("FECINI").SetOrdinal(intX)
                                .Columns("FECINI").ColumnName = "Fecha Servicio"
                                intX += 1
                                .Columns("CREFFW").SetOrdinal(intX)
                                intX += 1
                                .Columns("DESCWB").SetOrdinal(intX)
                                .Columns("DESCWB").ColumnName = "Referencia de Mercaderia"
                                intX += 1
                                .Columns("FREFFW").SetOrdinal(intX)
                                .Columns("FREFFW").ColumnName = "Fecha de Ingreso"
                                intX += 1
                                .Columns("FSLFFW").SetOrdinal(intX)
                                .Columns("FSLFFW").ColumnName = "Fecha de Salida"
                                intX += 1
                                .Columns("QREFFW").SetOrdinal(intX)
                                .Columns("QREFFW").ColumnName = "Cantidad de Bulto"
                                intX += 1
                                .Columns("TIPBTO").SetOrdinal(intX)
                                .Columns("TIPBTO").ColumnName = "Tipo de Bulto"
                                intX += 1
                                .Columns("QPSOBL").SetOrdinal(intX)
                                .Columns("QPSOBL").ColumnName = "Peso (Kgs). Bulto"
                                intX += 1
                                .Columns("QAROCP").SetOrdinal(intX)
                                .Columns("QAROCP").ColumnName = "MT2"
                                intX += 1

                                .Columns("PERINI").SetOrdinal(intX)
                                .Columns("PERINI").ColumnName = "Periodo Inicial"
                                intX += 1

                                .Columns("PERFIN").SetOrdinal(intX)
                                .Columns("PERFIN").ColumnName = "Periodo Final"
                                intX += 1

                                .Columns("QPRDFC").SetOrdinal(intX)
                                .Columns("QPRDFC").ColumnName = "Periodos x Aplicar"
                                intX += 1

                                .Columns("ALMACEN").SetOrdinal(intX)
                                .Columns("ALMACEN").ColumnName = "Tipo de almacen"
                                intX += 1

                                .Columns("TCTCST").SetOrdinal(intX)
                                .Columns("TCTCST").ColumnName = "C.I Terrestre"
                                intX += 1
                                .Columns("TCTCSA").SetOrdinal(intX)
                                .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                                intX += 1
                                .Columns("TCTCSF").SetOrdinal(intX)
                                .Columns("TCTCSF").ColumnName = "C.I Aereo"
                                intX += 1
                                .Columns("NORAGN").SetOrdinal(intX)
                                .Columns("NORAGN").ColumnName = "N°Orden Servicio - Agencia"
                                intX += 1
                                .Columns("NORCML").SetOrdinal(intX) 'orden de compra
                                intX += 1

                                If strTipoRep = "I" Then

                                    '=======================================================
                                    .Columns("NRITOC").SetOrdinal(intX) 'item
                                    intX += 1
                                    .Columns("TDITES").SetOrdinal(intX)
                                    .Columns("TDITES").ColumnName = "Descripción"
                                    intX += 1
                                    .Columns("TLUGEN").SetOrdinal(intX)
                                    .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                                    intX += 1
                                    .Columns("QBLTSR").SetOrdinal(intX)
                                    .Columns("QBLTSR").ColumnName = "Cantidad Item"
                                    intX += 1
                                    '========================================================

                                    .Columns("GUIA").SetOrdinal(intX)
                                    .Columns("GUIA").ColumnName = "Guía"
                                    intX += 1

                                    .Columns("CHOFER").SetOrdinal(intX)
                                    .Columns("CHOFER").ColumnName = "Chofer / Proveedor"
                                    intX += 1
                                    .Columns("PLACA").SetOrdinal(intX)
                                    .Columns("PLACA").ColumnName = "Placa"
                                    intX += 1
                                    .Columns("UNIDAD").SetOrdinal(intX)
                                    .Columns("UNIDAD").ColumnName = "Unidad"
                                    intX += 1

                                    lastOrdinal = intX

                                Else
                                    .Columns("GUIA").SetOrdinal(intX)
                                    .Columns("GUIA").ColumnName = "Guía"
                                    intX += 1
                                    .Columns("CHOFER").SetOrdinal(intX)
                                    .Columns("CHOFER").ColumnName = "Chofer / Proveedor"
                                    intX += 1
                                    .Columns("PLACA").SetOrdinal(intX)
                                    .Columns("PLACA").ColumnName = "Placa"
                                    intX += 1
                                    .Columns("UNIDAD").SetOrdinal(intX)
                                    .Columns("UNIDAD").ColumnName = "Unidad"
                                    'intX += 1

                                    lastOrdinal = intX
                                End If


                                'Creamos La cantidad de Columnas Como Servicios Existan
                                For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                                    nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                                    tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                                    .Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                                    .Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                                    oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                                    oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                                Next
                                lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                                .Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

                                .Columns("TMNDA").SetOrdinal(lastOrdinal + 2)
                                .Columns("CCLNT").SetOrdinal(lastOrdinal + 3)
                                .Columns("NRTFSV").SetOrdinal(lastOrdinal + 4)
                                .Columns("FECHA").SetOrdinal(lastOrdinal + 5)
                                .Columns("QATNAN").SetOrdinal(lastOrdinal + 6)
                                .Columns("TOTAL").SetOrdinal(lastOrdinal + 7)
                                .Columns("NRSRRB").SetOrdinal(lastOrdinal + 8)
                                .Columns("SERVICIO").SetOrdinal(lastOrdinal + 9)
                                .Columns("IVLSRV").SetOrdinal(lastOrdinal + 10)

                            End With
                        End If

                    Else

                        'Creamos La cantidad de Columnas Como Servicios Existan
                        lastOrdinal = 16
                        For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                            nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                            tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                            oDtRep.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                            oDtRep.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                            oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                            oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                        Next
                        lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                        oDtRep.Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

                    End If
                    '' '' Cargamos las tarifas '' ''
                    oDr = oDtRepTarif.NewRow
                    For i As Integer = 0 To oDtRepTarif.Columns.Count - 1
                        cadenaWhere = "NRTFSV = " & oDtRepTarif.Columns(i).Caption.ToString.Split("-")(0)
                        oDr(i) = filtraDatatable(oDtRepServTarif, cadenaWhere).Rows(0).Item("IVLSRV")
                        cadenaWhere = ""
                    Next
                    oDtRepTarif.Rows.Add(oDr)
                    '' '' Buscamos las cantidades y pintamos en columnas correspondientes'' ''
                    For i As Integer = 0 To oDtRep.Rows.Count - 1
                        cadenaWhere = "NSECFC= " & oDtRep.Rows(i).Item("NSECFC") & " AND NOPRCN = " & oDtRep.Rows(i).Item("NOPRCN") '& " AND NRTFSV = " & oDtRep.Rows(i).Item("NRTFSV")
                        oDtRepFiltros = oDtRep.Copy
                        oDtRepFiltros.DefaultView.RowFilter = cadenaWhere
                        oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable()
                        posFiltros = oDtRepFiltros.Rows.Count
                        oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable(True, "NSECFC", "NOPRCN", "NRTFSV", "IVLSRV", "QATNAN", "TDSDES", "NCRROP") 'Encontramos las tarifas asociadas ala operacion
                        If oDtRepFiltros.Rows.Count > 0 Then 'Pintamos en caso sea mayor a 0 
                            For j As Integer = 0 To oDtRepFiltros.Rows.Count - 1 'Empezamos la busqueda de su columna segun cantidad de tarifas encontradas
                                For k As Integer = (lastOrdinal - oDtRepServTarif.Rows.Count) To lastOrdinal 'Buscamos dentro de las columnas creadas dinamicamente
                                    If CInt(oDtRep.Columns(k).Caption.ToString.Split("-")(0)) = oDtRepFiltros.Rows(j).Item("NRTFSV") And _
                                        oDtRep.Columns(k).Caption.ToString.Split("-")(1).Trim = oDtRepFiltros.Rows(j).Item("TDSDES").ToString.Trim Then 'Lo encuentra comparando con el caption

                                        If Val("" & oDtRep.Rows(i).Item(k) & "") = 0 Then ' si el registro no tiene ningun valor, se asigna el valor y se acumula el subtotal
                                            oDtRep.Rows(i).Item(k) = oDtRepFiltros.Rows(j).Item("QATNAN")
                                            subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                        Else ' si registro ya tiene un valor, es pq son del mismo servicio asi es q al sub total se le quita el valor anterior y se suma el nuevo valor acumulado
                                            subTotalAcum = subTotalAcum - (oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV"))
                                            oDtRep.Rows(i).Item(k) = Val("" & oDtRep.Rows(i).Item(k) & "") + oDtRepFiltros.Rows(j).Item("QATNAN")
                                            subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                        End If

                                        Exit For
                                    End If
                                Next
                            Next
                            oDtRep.Rows(i).Item("SubTotal") = subTotalAcum
                            subTotalAcum = 0
                        End If
                        i = i + posFiltros - 1 'Nos ubicamos en la siguiente operacion
                    Next



                    '' '' ---------------------------------------------------------------------
                    '' '' ---------------------QUITAMOS LOS ROWS REPETIDOS---------------------

                    cadenaWhere = ""
                    If obj_Servicio.CDVSN <> "S" Then

                        With oDtRep

                            If obj_Servicio.CTPALJ <> "RE" Then


                                ''============Registros eliminados por item===========================
                                If strTipoRep = "I" Then
                                    While z < rowsDinamic
                                        x = rowsDinamic - 1
                                        cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & " AND CREFFW ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & "' AND NSEQIN = " & oDtRep.Rows(x).Item("NSEQIN").ToString.Trim & " And NORCML='" & oDtRep.Rows(x).Item("NORCML").ToString.Trim & "' AND NRITOC = '" & oDtRep.Rows(x).Item("NRITOC").ToString.Trim & "'"
                                        oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
                                        If oDtTempFiltro.Rows.Count > 1 Then
                                            oDtRep.Rows.RemoveAt(x)
                                        End If
                                        rowsDinamic -= 1
                                    End While
                                Else
                                    '=============Registros por orden de compra=======================
                                    While z < rowsDinamic
                                        x = rowsDinamic - 1
                                        cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & _
                                        " AND TRIM(CREFFW) ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & _
                                        "' AND NSEQIN = " & oDtRep.Rows(x).Item("NSEQIN").ToString.Trim & _
                                        " And NORCML='" & oDtRep.Rows(x).Item("NORCML").ToString.Trim & "'"



                                        oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
                                        If oDtTempFiltro.Rows.Count > 1 Then
                                            oDtRep.Rows.RemoveAt(x)
                                        End If
                                        rowsDinamic -= 1
                                    End While
                                End If


                            Else

                                '===Ordenamos las Columnas y Seteamos sus nombres===


                                .Columns("FECINI").ColumnName = "Fecha Servicio"
                                .Columns("FECFIN").ColumnName = "Fecha Fin Servicio"
                                .Columns("TDSDES").ColumnName = "Tipo Proceso"
                                .Columns("TLUGEN").ColumnName = "LOTE"



                            End If

                        End With
                    End If


                    With oDtRep
                        '    '===Seteamos sus nombres a las columnas que usan llaves===
                        If Not .Columns("TDSDES") Is Nothing Then .Columns("TDSDES").ColumnName = "Tipo de Servicio"
                        If Not .Columns("NORCML") Is Nothing Then .Columns("NORCML").ColumnName = "Orden de Compra"
                        If Not .Columns("NRITOC") Is Nothing Then .Columns("NRITOC").ColumnName = "Item"


                        .Columns("NOPRCN").ColumnName = "Operación"
                        If Not .Columns("CREFFW") Is Nothing Then .Columns("CREFFW").ColumnName = "Bulto"
                        .Columns("NRTFSV").ColumnName = "Código de Tarifa"
                        .Columns("IVLSRV").ColumnName = "Importe tarifa"
                        .Columns("QATNAN").ColumnName = "Cantidad"

                        If bolTipoRevision = False Then
                            .Columns.Remove("NSECFC")
                        Else
                            .Columns("NSECFC").ColumnName = "Nro Revisión"
                        End If

                        .Columns.Remove("NCRROP")
                        If Not .Columns("NSEQIN") Is Nothing Then .Columns.Remove("NSEQIN")


                    End With

                Case "1"
                    bolTipoAlm_Simple = True
                    'Creamos La cantidad de Columnas Como Servicios Existan
                    lastOrdinal = 17
                    For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                        nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                        tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                        oDtRep.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                        oDtRep.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                        oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                        oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                    Next
                    lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                    oDtRep.Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)


                    oDr = oDtRepTarif.NewRow
                    For i As Integer = 0 To oDtRepTarif.Columns.Count - 1
                        cadenaWhere = "NRTFSV = " & oDtRepTarif.Columns(i).Caption.ToString.Split("-")(0)
                        oDr(i) = filtraDatatable(oDtRepServTarif, cadenaWhere).Rows(0).Item("IVLSRV")
                        cadenaWhere = ""
                    Next
                    oDtRepTarif.Rows.Add(oDr)
                    '' '' Buscamos las cantidades y pintamos en columnas correspondientes'' ''
                    For i As Integer = 0 To oDtRep.Rows.Count - 1
                        cadenaWhere = "NSECFC= " & oDtRep.Rows(i).Item("NSECFC") & " AND NOPRCN = " & oDtRep.Rows(i).Item("NOPRCN") '& " AND NRTFSV = " & oDtRep.Rows(i).Item("NRTFSV")
                        oDtRepFiltros = oDtRep.Copy
                        oDtRepFiltros.DefaultView.RowFilter = cadenaWhere
                        oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable()
                        posFiltros = oDtRepFiltros.Rows.Count
                        oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable(True, "NSECFC", "NOPRCN", "NRTFSV", "IVLSRV", "QATNAN", "TDSDES", "NCRROP") 'Encontramos las tarifas asociadas ala operacion
                        If oDtRepFiltros.Rows.Count > 0 Then 'Pintamos en caso sea mayor a 0 
                            For j As Integer = 0 To oDtRepFiltros.Rows.Count - 1 'Empezamos la busqueda de su columna segun cantidad de tarifas encontradas
                                For k As Integer = (lastOrdinal - oDtRepServTarif.Rows.Count) To lastOrdinal 'Buscamos dentro de las columnas creadas dinamicamente
                                    If CInt(oDtRep.Columns(k).Caption.ToString.Split("-")(0)) = oDtRepFiltros.Rows(j).Item("NRTFSV") And _
                                        oDtRep.Columns(k).Caption.ToString.Split("-")(1).Trim = oDtRepFiltros.Rows(j).Item("TDSDES").ToString.Trim Then 'Lo encuentra comparando con el caption

                                        If Val("" & oDtRep.Rows(i).Item(k) & "") = 0 Then ' si el registro no tiene ningun valor, se asigna el valor y se acumula el subtotal
                                            oDtRep.Rows(i).Item(k) = oDtRepFiltros.Rows(j).Item("QATNAN")
                                            subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                        Else ' si registro ya tiene un valor, es pq son del mismo servicio asi es q al sub total se le quita el valor anterior y se suma el nuevo valor acumulado
                                            subTotalAcum = subTotalAcum - (oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV"))
                                            oDtRep.Rows(i).Item(k) = Val("" & oDtRep.Rows(i).Item(k) & "") + oDtRepFiltros.Rows(j).Item("QATNAN")
                                            subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                        End If

                                        Exit For
                                    End If
                                Next
                            Next
                            oDtRep.Rows(i).Item("SubTotal") = subTotalAcum
                            subTotalAcum = 0
                        End If
                        i = i + posFiltros - 1 'Nos ubicamos en la siguiente operacion
                    Next

                    If bolTipoRevision = False Then
                        oDtRep.Columns.Remove("NSECFC")
                    Else
                        oDtRep.Columns("NSECFC").ColumnName = "Nro Revisión"
                    End If
                    oDtRep.Columns.Remove("CCLNT")
                    oDtRep.Columns.Remove("TMNDA")


                    oDtRep.Columns("NOPRCN").ColumnName = "Operación"
                    oDtRep.Columns("FOPRCN").ColumnName = "Fecha Operación"
                    oDtRep.Columns("TDSDES").ColumnName = "Tipo Servicio"
                    oDtRep.Columns("FECINI").ColumnName = "Fecha Servicio"
                    oDtRep.Columns("NRTFSV").ColumnName = "Código Tarifa"

                    oDtRep.Columns("CMRCLR").ColumnName = "Mercadería"
                    oDtRep.Columns("TMRCD2").ColumnName = "Descripción"
                    oDtRep.Columns("CUNCN6").ColumnName = "Unidad"
                    oDtRep.Columns("NGUICL").ColumnName = "Guía Proveedor"
                    oDtRep.Columns("NGUIRN").ColumnName = "Guía Ransa"
                    oDtRep.Columns("TPRVCL").ColumnName = "Proveedor"
                    oDtRep.Columns("NORCCL").ColumnName = "Orden de Compra"

                    oDtRep.Columns("QTRMC").ColumnName = "Cantidad"
                    oDtRep.Columns("QTRMP").ColumnName = "Peso"
                    oDtRep.Columns("NSRCN1").ColumnName = "Serie"
                    oDtRep.Columns("CPRCN1").ColumnName = "Número"
            End Select
            If Not oDtRep.Columns("FOPRCN") Is Nothing Then oDtRep.Columns("FOPRCN").ColumnName = "Fecha Operación"
            If Not oDtRep.Columns("NGUITR") Is Nothing Then oDtRep.Columns("NGUITR").ColumnName = "Guía de Transporte"
            If Not oDtRep.Columns("TCMTRT") Is Nothing Then oDtRep.Columns("TCMTRT").ColumnName = "Empresa de Transporte"
            If Not oDtRep.Columns("FEMVLH") Is Nothing Then oDtRep.Columns("FEMVLH").ColumnName = "Fecha de Zarpe"
            If Not oDtRep.Columns("EMBARCACION") Is Nothing Then oDtRep.Columns("EMBARCACION").ColumnName = "Embarcación"
            'oDtRep.Columns("FOPRCN").ColumnName = "Fecha Operación"
            oDtRep.TableName = "Detalles"

            oDs.Tables.Add(ResumenTableDetalle(oDtRep, obj_Servicio).Copy)


            oDtRepTarif.TableName = "Tarifas"

            oDs.Tables.Add(oDtRepTarif)
            If oDsAdd IsNot Nothing Then
                If oDsAdd.Tables.Count > 0 Then
                    oDs.Tables.Add(oDsAdd.Tables(0).Copy)
                    oDs.Tables.Add(oDsAdd.Tables(1).Copy)
                    oDs.Tables.Add(oDsAdd.Tables(2).Copy)
                End If

                If obj_Servicio.CDVSN = "R" Then oDs.Tables.Add(oDsAdd.Tables(3).Copy)
                If obj_Servicio.CTPALJ = "RE" Then oDs.Tables.Add(oDsAdd.Tables(4).Copy)
            End If





            Ransa.Utilitario.HelpClass_NPOI.ExportExcel_Consistencia(oDs, "", oServicioAtendido.CTPALJ, True, strTipoRep, IIf(oDtReem Is Nothing, 1, 2), oDtReem, bolTipoRevision, bolTipoAlm_Simple)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerarSustentoExcel(ByVal objDsSustentos As DataSet, ByVal obj_Servicio As Servicio_BE, ByVal strTipoRep As String, _
                                        ByVal tipo_cambio As Decimal, ByVal valor_igv As Decimal, Optional ByRef oDtReem As DataTable = Nothing)

        Dim oDtResLotePrint As New DataTable
        Dim dtFiltro As New DataTable
        Dim odsExcel As New DataSet


        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")




        For Each dt As DataTable In objDsSustentos.Tables
            Dim objDt As New DataTable
            Dim objDs As New DataSet
            objDt = dt

            If objDt.Rows.Count = 0 Then Continue For


            objDt.Columns.Add("TIPO_CAMBIO")
            For i As Integer = 0 To objDt.Rows.Count - 1
                objDt.Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next
            '========================TABLA APOYO======================
            Dim oDtUtil As New DataTable
            oDtUtil.TableName = "UTILES"
            oDtUtil.Columns.Add("IGV")
            oDtUtil.Columns.Add("TIPO_CAMBIO")
            Dim rowUtil As DataRow
            rowUtil = oDtUtil.NewRow
            rowUtil(0) = valor_igv
            rowUtil(1) = tipo_cambio
            oDtUtil.Rows.Add(rowUtil)
            oDtUtil.TableName = "UTILES"
            '====================================DANDO FORMATO A TABLAS============================
            '======================================================================================
            Dim oDtFiltro As New DataTable
            Dim oDtDetalle As New DataTable
            oDtDetalle = objDt.Copy
            '===PARA EL FILTRO===
            oDtFiltro.TableName = "Filtro"
            oDtFiltro.Columns.Add("Filtro")
            oDtFiltro.Columns.Add("Valor")
            Dim row As DataRow

            row = oDtFiltro.NewRow
            row(0) = "Compañia :"
            row(1) = obj_Servicio.CCMPN_DESC
            oDtFiltro.Rows.Add(row)

            row = oDtFiltro.NewRow
            row(0) = "División :"
            row(1) = obj_Servicio.CDVSN_DESC
            oDtFiltro.Rows.Add(row)

            If obj_Servicio.CCLNT Then
                row = oDtFiltro.NewRow
                row(0) = "Cliente :"
                row(1) = obj_Servicio.CCLNT & " - " & obj_Servicio.CCLNT_DESC
                oDtFiltro.Rows.Add(row)
            End If

            If Not bolTipoRevision Then
                row = oDtFiltro.NewRow
                row(0) = "Nro. Consistencia :"
                row(1) = obj_Servicio.NSECFC.ToString
                oDtFiltro.Rows.Add(row)

            End If

            '==== PARA EL RESUMEN =====
            Dim oDtResumen As DataTable = oDtDetalle.Copy
            Dim colResumen As Integer = oDtResumen.Columns.Count - 1
            Dim tarifa1 As Integer = 0
            Dim tarifa2 As Integer = 0
            Dim bTrfInicia As Boolean = True
            Dim ldblSub_total As Double = 0D
            Dim iPosIni As Integer = 0
            Dim oDv As New DataView(oDtResumen)
            oDv.Sort = "NRTFSV ASC"
            oDtResumen = oDv.ToTable(True, "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")

            'Dim dtRes As DataTable = oDv.ToTable(True, "NRTFSV", "TCMTRF")

            For i As Integer = 0 To oDtResumen.Rows.Count - 1
                If i = 0 Then
                    tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                    iPosIni = i
                Else
                    tarifa2 = oDtResumen.Rows(i).Item("NRTFSV")
                    If tarifa1 = tarifa2 Then
                        oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") = oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") + oDtResumen.Rows(i).Item("SUB_TOTAL")
                        oDtResumen.Rows(iPosIni).Item("QATNAN") = oDtResumen.Rows(iPosIni).Item("QATNAN") + oDtResumen.Rows(i).Item("QATNAN")
                        oDtResumen.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                        iPosIni = i
                    End If
                End If
            Next
            oDtResumen.Columns.RemoveAt(0) 'QUITO LA OPERACION USADA COMO FLAG
            Dim objListaDr As DataRow() = oDtResumen.Select("QATNAN > 0")
            Dim objDr As DataRow
            Dim lintCont As Integer
            Dim objDtDet As New DataTable
            objDtDet.Columns.Add("NRTFSV")
            objDtDet.Columns.Add("TCMTRF")
            objDtDet.Columns.Add("MONEDA")
            objDtDet.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDet.Columns.Add("QATNAN", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_DOLARES", GetType(System.Double))
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDtDet.NewRow
                objDr(0) = objListaDr(lintCont).Item("NRTFSV") 'TARIFA
                objDr(1) = objListaDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDr(2) = objListaDr(lintCont).Item("TMNDA")  'MONEDA
                objDr(3) = objListaDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDr(4) = objListaDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_total = objListaDr(lintCont).Item("SUB_TOTAL")
                If objDr(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDr(5) = ldblSub_total 'Math.Round(ldblSub_total, 2)  'IMPORTE SOLES
                    objDr(6) = ldblSub_total / tipo_cambio 'Math.Round(ldblSub_total / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDr(5) = ldblSub_total * tipo_cambio 'Math.Round(ldblSub_total * tipo_cambio, 2) 'IMPORTE SOLES
                    objDr(6) = ldblSub_total 'Math.Round(ldblSub_total, 2) 'IMPORTE DOLARES
                End If
                objDtDet.Rows.Add(objDr)
            Next lintCont




            Dim oDtCiPrint As New DataTable

            If obj_Servicio.CDVSN = "R" Then

                '=======================================
                '====== PARA EL RESUMEN DE LOTES =======
                '=======================================
                oDtResLotePrint = GenerarLote(obj_Servicio.CTPALJ, oDtDetalle, tipo_cambio)

                '==================RESUMEN PARA LA CUENTA DE IMPUTACION===========================

                If obj_Servicio.CTPALJ = "RE" Then
                    oDtCiPrint = GeneraCI(oDtDetalle, tipo_cambio)
                End If

            End If
            '======================================================================================    
            objDs.Tables.Add(objDt.Copy) 'Detallle
            objDs.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDs.Tables.Add(objDtDet.Copy) 'Resumen
            objDs.Tables.Add(oDtResLotePrint.Copy) 'Resumen Lotes

            '==============================FORMATEANDO EL EXCEL======================================

            ''''Reset la tabla ''''
            Dim otblAlm As New DataTable
            otblAlm = objDs.Tables(0).Copy
            '==========ALMACEN============  

            odsExcel.Tables.Add(GeneraDtHorizontal(otblAlm, obj_Servicio, strTipoRep, tipo_cambio, oDtReem).Copy)
            odsExcel.Tables.Add(objDs.Tables(1).Copy)
            odsExcel.Tables.Add(objDs.Tables(2).Copy)
            odsExcel.Tables.Add(oDtResLotePrint.Copy)
            odsExcel.Tables.Add(oDtCiPrint.Copy) 'CI

        Next

        Return odsExcel
    End Function

    Private Function GenerarLote(ByVal TipoSev As String, ByVal oDtDetalle As DataTable, ByVal tipo_cambio As Decimal) As DataTable
        Dim dtFiltro As New DataTable
        Dim oDtResLotePrint As New DataTable


        Dim oDtResLote As DataTable = oDtDetalle.Copy

        Dim oDvLote As New DataView(oDtResLote)
        Dim objDataRow As DataRow
        Dim TotMntSoles As Double = 0D
        Dim TotMntDolares As Double = 0D
        oDvLote.Sort = "LOTE ASC"
        oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP", "QATNAN", "VALCTE")
        Dim OriginalCount As Integer = oDtResLote.Rows.Count

        oDtResLote.Columns.Remove("NOPRCN")

        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0
            dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")

            If TipoSev = "RE" Then
                For Each dr As DataRow In dtFiltro.Rows '
                    If dr("TMNDA").ToString.Trim = "USD" Then

                        If Val(dr("VALCTE")) > 0 Then
                            TotMntSoles += dr("SUB_TOTAL") * tipo_cambio 'dr("QATNAN") * tipo_cambio + (dr("QATNAN") * tipo_cambio * dr("VALCTE") / 100)
                            TotMntDolares += dr("SUB_TOTAL") 'dr("QATNAN") + (dr("QATNAN") * dr("VALCTE") / 100)
                        Else
                            TotMntSoles += Convert.ToDouble(dr("QATNAN")) * tipo_cambio
                            TotMntDolares += Convert.ToDouble(dr("QATNAN"))
                        End If

                    Else
                        If Val(dr("VALCTE")) > 0 Then
                            TotMntSoles += dr("QATNAN") + (dr("QATNAN") * dr("VALCTE") / 100)
                        Else
                            TotMntSoles += dr("QATNAN")
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            If Val(dr("VALCTE")) > 0 Then
                                TotMntDolares += dr("QATNAN") / tipo_cambio + (dr("QATNAN") / tipo_cambio * dr("VALCTE") / 100)
                            Else
                                TotMntDolares += dr("QATNAN") / tipo_cambio
                            End If


                        End If
                    End If
                Next
            Else
                For Each dr As DataRow In dtFiltro.Rows '
                    If dr("TMNDA").ToString.Trim = "USD" Then
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If
                Next
            End If



            If dtFiltro.Rows.Count > 0 Then
                objDataRow = oDtResLotePrint.NewRow
                objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                objDataRow.Item("SOLES") = TotMntSoles.ToString("N2")
                objDataRow.Item("DOLARES") = TotMntDolares.ToString("N2")
                oDtResLotePrint.Rows.Add(objDataRow)
                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        Return oDtResLotePrint
    End Function

    Private Function filtraDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function

    Private Function DeleteRowsRepits(ByVal oDtRep As DataTable) As DataTable
        Dim cadenaWhere As String = ""
        Dim z As Integer = 0
        Dim x As Integer = 0
        Dim oDtTempFiltro As New DataTable

        Dim rowsDinamic As Integer = oDtRep.Rows.Count


        While z < rowsDinamic
            x = rowsDinamic - 1
            Try
                cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & _
                                          " AND TRIM(CREFFW) ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & _
                                          "' AND NSEQIN = " & Val("" & oDtRep.Rows(x).Item("NSEQIN") & "") & _
                                          "  AND OC = '" & oDtRep.Rows(x).Item("OC").ToString.Trim & _
                                          "' AND NRTFSV = " & oDtRep.Rows(x).Item("NRTFSV").ToString

                oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
                If oDtTempFiltro.Rows.Count > 1 Then
                    oDtRep.Rows.RemoveAt(x)
                End If
            Catch ex As Exception

            End Try

            rowsDinamic -= 1
        End While


        Return oDtRep
    End Function

    Private Function GeneraDtHorizontal(ByVal oDt As DataTable, ByVal obj_Servicio As Servicio_BE, ByVal strTipoRep As String, ByVal tipo_cambio As Decimal, Optional ByRef oDtReemb As DataTable = Nothing)

        Dim oDtDetalle As DataTable = oDt

        Dim blExisteAlmacen As Boolean = False


        '===PARA EL DETALLE===
        Select Case obj_Servicio.CDVSN
            Case "R"

                Select Case obj_Servicio.STPODP
                    Case "7" 'almacen de transito
                        With oDtDetalle

                            If Not obj_Servicio.CTPALJ = "RE" Then
                                If strTipoRep = "O" Then oDtDetalle = DeleteRowsRepits(oDtDetalle)
                            Else
                                oDtReemb = oDt.Copy
                                oDtReemb = EmitirReporteExcelReembolso(oDtReemb, tipo_cambio)
                            End If


                            Dim otblAlm As New DataTable
                            otblAlm = oDtDetalle

                            Dim NSECFC As String = ""
                            Dim TCMPCL As String = ""
                            Dim NOPRCN As String = ""
                            Dim TMNDA As String = ""
                            Dim NRTFSV As String = ""
                            Dim SERVICIO As String = ""
                            Dim TCMTRF As String = ""
                            Dim IVLSRV As String = "" 'tarida
                            Dim QATNAN As Decimal = 0 'cantidad
                            Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                            Dim sQATNAN As String = "" 'cantidad
                            Dim sSUB_TOTAL As String = "" 'monto a cobrar
                            Dim SESTRG_SERV As String = ""
                            Dim NCRROP As String = ""
                            Dim CREFFW As String = ""

                            Dim blExiste As Boolean = False
                            Dim blExisteOper As Boolean = False
                            Dim blExisteRev As Boolean = False
                            Dim blExisteBulto As Boolean = False

                            For i As Integer = 0 To otblAlm.Rows.Count - 1


                                blExiste = False
                                blExisteOper = False
                                blExisteBulto = False
                                blExisteRev = False

                                If i = 0 Then
                                    NSECFC = otblAlm.Rows(i).Item("NSECFC")
                                    TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                                    NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                                    TMNDA = otblAlm.Rows(i).Item("TMNDA")
                                    NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                                    SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                                    TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                                    IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                                    sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                                    sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                                    SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                                    NCRROP = otblAlm.Rows(i).Item("NCRROP")
                                    If obj_Servicio.CTPALJ <> "RE" Then CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim

                                End If

                                If Not obj_Servicio.CTPALJ = "RE" Then
                                    If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                          NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                          TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                          NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                                          SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                          TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                          IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                          SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") And _
                                                          sQATNAN = otblAlm.Rows(i).Item("QATNAN") And _
                                                          NCRROP = otblAlm.Rows(i).Item("NCRROP") And _
                                                          sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL") Then
                                        blExiste = True
                                    End If
                                Else
                                    If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                                              NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                                              TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                                              NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                                                              SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                                              TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                                              IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                                              SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") Then
                                        blExiste = True
                                    End If
                                End If


                                If NSECFC = otblAlm.Rows(i).Item("NSECFC") Then
                                    blExisteRev = True
                                End If


                                If NOPRCN = otblAlm.Rows(i).Item("NOPRCN") Then
                                    blExisteOper = True
                                End If
                                If obj_Servicio.CTPALJ <> "RE" Then

                                    If CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim Then
                                        blExisteBulto = True
                                    End If

                                End If


                                NSECFC = otblAlm.Rows(i).Item("NSECFC")
                                TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                                NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                                TMNDA = otblAlm.Rows(i).Item("TMNDA")
                                NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                                SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                                TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                                IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                                sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                                sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                                SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                                NCRROP = otblAlm.Rows(i).Item("NCRROP")

                                If obj_Servicio.CTPALJ <> "RE" Then CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim

                                If blExisteRev And i > 0 Then
                                    otblAlm.Rows(i).Item("NSECFC") = 0
                                End If

                                If blExisteOper And i > 0 Then
                                    otblAlm.Rows(i).Item("NOPRCN") = 0
                                    otblAlm.Rows(i).Item("FOPRCN") = ""
                                    otblAlm.Rows(i).Item("TIPRO") = ""
                                    otblAlm.Rows(i).Item("FOPRCN") = ""
                                    otblAlm.Rows(i).Item("TRDCCL") = ""
                                End If


                                '======Se limpia los los datos del bulto y sus items cuando no es de tipo reembolso=======
                                If obj_Servicio.CTPALJ <> "RE" Then
                                    If blExisteOper And blExisteBulto And i > 0 Then
                                        otblAlm.Rows(i).Item("CREFFW") = "" 'bulto
                                        'otblAlm.Rows(i).Item("OC") = "" ' orden de compra
                                        otblAlm.Rows(i).Item("NCRRDC") = 0 ' corrida
                                        otblAlm.Rows(i).Item("NDIAPL") = 0 ' dias
                                        otblAlm.Rows(i).Item("DESCWB") = "" 'des bulto
                                        otblAlm.Rows(i).Item("QREFFW") = 0 'cantidad de bulto
                                        otblAlm.Rows(i).Item("TIPBTO") = "" 'tipo bulto
                                        otblAlm.Rows(i).Item("QPSOBL") = 0 'cantidad peso
                                        otblAlm.Rows(i).Item("TUNPSO") = "" 'unidad peso
                                        otblAlm.Rows(i).Item("QAROCP") = DBNull.Value
                                        otblAlm.Rows(i).Item("ALMACEN") = ""

                                        otblAlm.Rows(i).Item("QVLBTO") = 0
                                        otblAlm.Rows(i).Item("TUNVOL") = ""
                                        otblAlm.Rows(i).Item("PERINI") = DBNull.Value
                                        otblAlm.Rows(i).Item("PERFIN") = DBNull.Value
                                        otblAlm.Rows(i).Item("QPRDFC") = 0
                                        otblAlm.Rows(i).Item("FREFFW") = DBNull.Value
                                        otblAlm.Rows(i).Item("FSLFFW") = DBNull.Value
                                        otblAlm.Rows(i).Item("NORAGN") = DBNull.Value

                                        otblAlm.Rows(i).Item("TCTCST") = DBNull.Value
                                        otblAlm.Rows(i).Item("TCTCSA") = DBNull.Value
                                        otblAlm.Rows(i).Item("TCTCSF") = DBNull.Value

                                    End If
                                End If



                                If blExiste And i > 0 Then
                                    If Not obj_Servicio.CTPALJ = "RE" Then
                                        otblAlm.Rows(i).Item("TCMPCL") = ""
                                        otblAlm.Rows(i).Item("TMNDA") = ""
                                        otblAlm.Rows(i).Item("NRTFSV") = 0
                                        otblAlm.Rows(i).Item("SERVICIO") = ""
                                        otblAlm.Rows(i).Item("FATNSR") = ""
                                        otblAlm.Rows(i).Item("TCMTRF") = ""
                                        otblAlm.Rows(i).Item("IVLSRV") = 0
                                        otblAlm.Rows(i).Item("QATNAN") = 0
                                        otblAlm.Rows(i).Item("SUB_TOTAL") = 0
                                        otblAlm.Rows(i).Item("SESTRG_SERV") = ""
                                        otblAlm.Rows(i).Item("TRFSRC") = ""
                                        otblAlm.AcceptChanges()
                                    Else
                                        otblAlm.Rows(i).Item("TCMPCL") = ""
                                        otblAlm.Rows(i).Item("SERVICIO") = ""
                                        otblAlm.Rows(i).Item("FATNSR") = ""
                                        otblAlm.Rows(i).Item("TCMTRF") = ""
                                        'otblAlm.Rows(i).Item("TRFSRC") = ""
                                        otblAlm.Rows(i).Item("NRTFSV") = 0

                                        otblAlm.AcceptChanges()
                                    End If


                                End If

                            Next
                            oDtDetalle = otblAlm
                            '================================================


                            If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")
                            Dim intIndice As Integer = 0

                            .Columns("NSECFC").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("NOPRCN").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("FOPRCN").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("TIPRO").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("TRDCCL").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("NRTFSV").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("SERVICIO").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("TCMTRF").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("FATNSR").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("QATNAN").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("IVLSRV").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("TMNDA").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("SUB_TOTAL").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("SESTRG_SERV").SetOrdinal(intIndice)
                            intIndice += 1
                            .Columns("TCMPCL").ColumnName = "Cliente"
                            .Columns("NOPRCN").ColumnName = "Operacion"
                            .Columns("FOPRCN").ColumnName = "Fecha Operación"
                            .Columns("TIPRO").ColumnName = "Proceso"
                            .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                            .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                            .Columns("FATNSR").ColumnName = "Fecha Servicio"
                            .Columns("TCMTRF").ColumnName = "Servicio"
                            .Columns("QATNAN").ColumnName = "Cantidad"
                            .Columns("IVLSRV").ColumnName = "Importe tarifa"
                            .Columns("TMNDA").ColumnName = "Moneda"
                            .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                            .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                            .Columns("TRDCCL").ColumnName = "Referencia Operación"

                            '==========si es diferente de reembolso ya que no trae la data de bultos=============
                            If obj_Servicio.CTPALJ <> "RE" Then
                                intIndice = 13

                                .Columns("NCRRDC").SetOrdinal(intIndice)
                                .Columns("NCRRDC").ColumnName = "Corr"
                                intIndice += 1

                                .Columns("CREFFW").SetOrdinal(intIndice)
                                .Columns("CREFFW").ColumnName = "Bulto"
                                intIndice += 1


                                .Columns("DESCWB").SetOrdinal(intIndice)
                                .Columns("DESCWB").ColumnName = "Descripcion Bulto"
                                intIndice += 1

                                .Columns("FREFFW").SetOrdinal(intIndice)
                                .Columns("FREFFW").ColumnName = "Fecha de Ingreso"
                                intIndice += 1

                                .Columns("FSLFFW").SetOrdinal(intIndice)
                                .Columns("FSLFFW").ColumnName = "Fecha de Salida"
                                intIndice += 1

                                .Columns("NDIAPL").SetOrdinal(intIndice)
                                .Columns("NDIAPL").ColumnName = "Días"
                                intIndice += 1

                                .Columns("QREFFW").SetOrdinal(intIndice)
                                .Columns("QREFFW").ColumnName = "Cantidad Bulto"
                                intIndice += 1

                                .Columns("TIPBTO").SetOrdinal(intIndice)
                                .Columns("TIPBTO").ColumnName = "Tipo Bulto"
                                intIndice += 1

                                .Columns("QPSOBL").SetOrdinal(intIndice)
                                .Columns("QPSOBL").ColumnName = "Peso"
                                intIndice += 1

                                .Columns("TUNPSO").SetOrdinal(intIndice)
                                .Columns("TUNPSO").ColumnName = "Unidad  Peso"
                                intIndice += 1

                                .Columns("QAROCP").SetOrdinal(intIndice)
                                .Columns("QAROCP").ColumnName = "MT2"
                                intIndice += 1

                                .Columns("QVLBTO").SetOrdinal(intIndice)
                                .Columns("QVLBTO").ColumnName = "Volumen "
                                intIndice += 1

                                .Columns("TUNVOL").SetOrdinal(intIndice)
                                .Columns("TUNVOL").ColumnName = "Unidad de Volumen"
                                intIndice += 1


                                .Columns("PERINI").SetOrdinal(intIndice)
                                .Columns("PERINI").ColumnName = "Periodo Inicial"
                                intIndice += 1

                                .Columns("PERFIN").SetOrdinal(intIndice)
                                .Columns("PERFIN").ColumnName = "Periodo Final"
                                intIndice += 1

                                .Columns("QPRDFC").SetOrdinal(intIndice)
                                .Columns("QPRDFC").ColumnName = "Periodos x Aplicar"
                                intIndice += 1

                                .Columns("ALMACEN").SetOrdinal(intIndice)
                                .Columns("ALMACEN").ColumnName = "Tipo de almacen "
                                intIndice += 1

                                .Columns("TCTCST").SetOrdinal(intIndice)
                                .Columns("TCTCST").ColumnName = "C.I Terrestre"
                                intIndice += 1

                                .Columns("TCTCSA").SetOrdinal(intIndice)
                                .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                                intIndice += 1

                                .Columns("TCTCSF").SetOrdinal(intIndice)
                                .Columns("TCTCSF").ColumnName = "C.I Aereo"
                                intIndice += 1

                                .Columns("NORAGN").SetOrdinal(intIndice)
                                .Columns("NORAGN").ColumnName = "N°Orden Servicio - Agencia"
                                intIndice += 1

                                .Columns("OC").SetOrdinal(intIndice)
                                .Columns("OC").ColumnName = "O/C"
                                intIndice += 1

                                .Columns("NRITOC").SetOrdinal(intIndice)
                                .Columns("NRITOC").ColumnName = "Item"
                                intIndice += 1

                                .Columns("TDITES").SetOrdinal(intIndice)
                                .Columns("TDITES").ColumnName = "Descripción"
                                intIndice += 1

                                .Columns("TLUGEN").SetOrdinal(intIndice)
                                .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                                intIndice += 1

                                .Columns("QBLTSR").SetOrdinal(intIndice)
                                .Columns("QBLTSR").ColumnName = "Cantidad Item"
                                intIndice += 1

                                .Columns("TUBRFR").SetOrdinal(intIndice)
                                .Columns("TUBRFR").ColumnName = "Almacen"
                                intIndice += 1



                                .Columns("LOTE").ColumnName = "Lote"
                                .Columns("LOTE").SetOrdinal(intIndice)
                                intIndice += 1

                                .Columns("CI").SetOrdinal(intIndice)
                                .Columns("CI").ColumnName = "Cuenta Imputación"
                                intIndice += 1

                                .Columns("NSRCN1").SetOrdinal(intIndice)
                                .Columns("NSRCN1").ColumnName = "Serie Contenedor"
                                intIndice += 1

                                .Columns("CPRCN1").SetOrdinal(intIndice)
                                .Columns("CPRCN1").ColumnName = "Contenedor"
                                intIndice += 1

                                .Columns("TSRVC").SetOrdinal(intIndice)
                                .Columns("TSRVC").ColumnName = "Observación"
                                intIndice += 1

                                .Columns("TRFSRC").SetOrdinal(intIndice)
                                .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                                intIndice += 1

                                '=======si no es de tipo item no debe ir los datos del mismo===============
                                If strTipoRep <> "I" Then
                                    If Not .Columns("NRITOC") Is Nothing Then .Columns.Remove("NRITOC")
                                    If Not .Columns("TDITES") Is Nothing Then .Columns.Remove("TDITES")
                                    If Not .Columns("TLUGEN") Is Nothing Then .Columns.Remove("TLUGEN")
                                    If Not .Columns("QBLTSR") Is Nothing Then .Columns.Remove("QBLTSR")
                                End If



                                'If Not .Columns("NRITOC") Is Nothing Then .Columns("NRITOC").ColumnName = "Item"
                                'If Not .Columns("TDITES") Is Nothing Then .Columns("TDITES").ColumnName = "Descripción"
                                'If Not .Columns("TLUGEN") Is Nothing Then .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                                'If Not .Columns("QBLTSR") Is Nothing Then .Columns("QBLTSR").ColumnName = "Cantidad Item"

                                'If Not .Columns("TCTCST") Is Nothing Then .Columns("TCTCST").ColumnName = "C.I Terrestre"
                                'If Not .Columns("TCTCSA") Is Nothing Then .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                                'If Not .Columns("TCTCSF") Is Nothing Then .Columns("TCTCSF").ColumnName = "C.I Aereo"


                                If Not .Columns("NSEQIN") Is Nothing Then .Columns.Remove("NSEQIN")


                            End If



                        End With

                    Case "1" 'Deposito Simple

                        Dim NSECFC As String = ""
                        Dim TIPRO As String = ""
                        Dim TCMPCL As String = ""
                        Dim NOPRCN As String = ""
                        Dim TMNDA As String = ""
                        Dim NRTFSV As String = ""
                        Dim SERVICIO As String = ""
                        Dim IVLSRV As String = "" 'tarida
                        Dim QATNAN As Decimal = 0 'cantidad
                        Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                        Dim SESTRG_SERV As String = ""
                        Dim NCRROP As String = String.Empty




                        Dim blExiste As Boolean = False
                        Dim blExisteOper As Boolean = False
                        Dim blExisteRev As Boolean = False


                        With oDtDetalle

                            For i As Integer = 0 To .Rows.Count - 1

                                blExiste = False
                                blExisteOper = False
                                blExisteRev = False

                                If i = 0 Then
                                    TIPRO = .Rows(i).Item("TIPRO")
                                    NSECFC = .Rows(i).Item("NSECFC")
                                    NOPRCN = .Rows(i).Item("NOPRCN")
                                    TMNDA = .Rows(i).Item("TMNDA")
                                    NRTFSV = .Rows(i).Item("NRTFSV")
                                    SERVICIO = .Rows(i).Item("SERVICIO")
                                    IVLSRV = .Rows(i).Item("IVLSRV")
                                    QATNAN = .Rows(i).Item("QATNAN")
                                    SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                    SESTRG_SERV = .Rows(i).Item("SESTRG_SERV")
                                    NCRROP = .Rows(i).Item("NCRROP")

                                End If


                                If NOPRCN = .Rows(i).Item("NOPRCN") And _
                                                            TMNDA = .Rows(i).Item("TMNDA") And _
                                                            NRTFSV = .Rows(i).Item("NRTFSV") And _
                                                            SERVICIO = .Rows(i).Item("SERVICIO") And _
                                                            IVLSRV = .Rows(i).Item("IVLSRV") And _
                                                            SESTRG_SERV = .Rows(i).Item("SESTRG_SERV") And _
                                                            QATNAN = .Rows(i).Item("QATNAN") And _
                                                            NCRROP = .Rows(i).Item("NCRROP") And _
                                                            SUB_TOTAL = .Rows(i).Item("SUB_TOTAL") Then

                                    blExiste = True

                                End If


                                If NSECFC = .Rows(i).Item("NSECFC") Then
                                    blExisteRev = True
                                End If

                                If NOPRCN = .Rows(i).Item("NOPRCN") Then
                                    blExisteOper = True
                                End If


                                TIPRO = .Rows(i).Item("TIPRO")
                                NSECFC = .Rows(i).Item("NSECFC")
                                NOPRCN = .Rows(i).Item("NOPRCN")
                                TMNDA = .Rows(i).Item("TMNDA")
                                NRTFSV = .Rows(i).Item("NRTFSV")
                                SERVICIO = .Rows(i).Item("SERVICIO")
                                IVLSRV = .Rows(i).Item("IVLSRV")
                                QATNAN = .Rows(i).Item("QATNAN")
                                SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                SESTRG_SERV = .Rows(i).Item("SESTRG_SERV")
                                NCRROP = .Rows(i).Item("NCRROP")



                                If blExisteRev And i > 0 Then
                                    .Rows(i).Item("NSECFC") = 0
                                End If

                                If blExisteOper And i > 0 Then
                                    .Rows(i).Item("NOPRCN") = 0
                                    .Rows(i).Item("TIPRO") = ""
                                    .Rows(i).Item("SERVICIO") = ""
                                    .Rows(i).Item("TRDCCL") = ""
                                End If

                                If blExiste And i > 0 Then
                                    .Rows(i).Item("TMNDA") = ""
                                    .Rows(i).Item("NRTFSV") = 0
                                    .Rows(i).Item("SERVICIO") = ""
                                    .Rows(i).Item("TCMTRF") = ""
                                    .Rows(i).Item("IVLSRV") = 0
                                    .Rows(i).Item("QATNAN") = 0
                                    .Rows(i).Item("SUB_TOTAL") = 0
                                    .Rows(i).Item("SESTRG_SERV") = ""
                                    '.Rows(i).Item("FECINI") = ""
                                    .Rows(i).Item("TRFSRC") = ""
                                    .Rows(i).Item("TRFSRC") = ""


                                End If




                            Next

                            .Columns.Remove("NCRROP")
                            .Columns.Remove("CCLNT")
                            .Columns.Remove("TIPO_CAMBIO")
                            .Columns.Remove("NOMSER")
                            .Columns.Remove("TDSDES")
                            .Columns.Remove("TCMPCL")



                            '.Columns("NSECFC").ColumnName = "Nro Revisión"
                            Dim intIndice As Integer = 0
                            .Columns("NOPRCN").SetOrdinal(intIndice)
                            .Columns("NOPRCN").ColumnName = "Operacion"
                            intIndice += 1

                            .Columns("TIPRO").SetOrdinal(intIndice)
                            .Columns("TIPRO").ColumnName = "Proceso"
                            intIndice += 1

                            .Columns("TRDCCL").SetOrdinal(intIndice)
                            .Columns("TRDCCL").ColumnName = "Referencia Operación"
                            intIndice += 1

                            .Columns("NRTFSV").SetOrdinal(intIndice)
                            .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                            intIndice += 1

                            .Columns("SERVICIO").SetOrdinal(intIndice)
                            .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                            intIndice += 1

                            .Columns("TCMTRF").SetOrdinal(intIndice)
                            .Columns("TCMTRF").ColumnName = "Servicio"
                            intIndice += 1

                            .Columns("QATNAN").SetOrdinal(intIndice)
                            .Columns("QATNAN").ColumnName = "Cantidad"
                            intIndice += 1
                            .Columns("IVLSRV").SetOrdinal(intIndice)
                            .Columns("IVLSRV").ColumnName = "Importe tarifa"
                            intIndice += 1
                            .Columns("TMNDA").SetOrdinal(intIndice)
                            .Columns("TMNDA").ColumnName = "Moneda"
                            intIndice += 1
                            .Columns("SUB_TOTAL").SetOrdinal(intIndice)
                            .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                            intIndice += 1
                            .Columns("SESTRG_SERV").SetOrdinal(intIndice)
                            .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                            intIndice += 1
                            '.Columns("FECINI").SetOrdinal(intIndice)
                            '.Columns("FECINI").ColumnName = "Fecha Operación"
                            'intIndice += 1
                            .Columns("CMRCLR").SetOrdinal(intIndice)
                            .Columns("CMRCLR").ColumnName = "Mercadería"
                            intIndice += 1
                            .Columns("TMRCD2").SetOrdinal(intIndice)
                            .Columns("TMRCD2").ColumnName = "Descripción"
                            intIndice += 1
                            .Columns("CUNCN6").SetOrdinal(intIndice)
                            .Columns("CUNCN6").ColumnName = "Unidad"
                            intIndice += 1
                            .Columns("NGUICL").SetOrdinal(intIndice)
                            .Columns("NGUICL").ColumnName = "Guía Proveedor"
                            intIndice += 1
                            .Columns("TPRVCL").SetOrdinal(intIndice)
                            .Columns("TPRVCL").ColumnName = "Proveedor"
                            intIndice += 1
                            .Columns("NORCCL").SetOrdinal(intIndice)
                            .Columns("NORCCL").ColumnName = "Orden de Compra"
                            intIndice += 1
                            .Columns("NGUIRN").SetOrdinal(intIndice)
                            .Columns("NGUIRN").ColumnName = "Guía Ransa"
                            intIndice += 1

                            .Columns("QTRMC").SetOrdinal(intIndice)
                            .Columns("QTRMC").ColumnName = "Cantidad "
                            intIndice += 1

                            .Columns("QTRMP").SetOrdinal(intIndice)
                            .Columns("QTRMP").ColumnName = "Peso"
                            intIndice += 1

                            .Columns("NSRCN1").SetOrdinal(intIndice)
                            .Columns("NSRCN1").ColumnName = "Serie Contenedor"
                            intIndice += 1

                            .Columns("CPRCN1").SetOrdinal(intIndice)
                            .Columns("CPRCN1").ColumnName = "Contenedor"
                            intIndice += 1

                            .Columns("TRFSRC").SetOrdinal(intIndice)
                            .Columns("TRFSRC").ColumnName = "Servicio Operación"
                            intIndice += 1


                        End With

                End Select


            Case "S"

                '==========SIL============
                oDtDetalle.Columns.Remove("TCMPCL")
                oDtDetalle.Columns.Remove("CCMPN")
                oDtDetalle.Columns.Remove("CDVSN")
                oDtDetalle.Columns.Remove("CCLNT")
                oDtDetalle.Columns.Remove("TIPO_CAMBIO")
                If Not oDtDetalle.Columns("CMEDTR_VALUE") Is Nothing Then oDtDetalle.Columns.Remove("CMEDTR_VALUE")
                If Not oDtDetalle.Columns("OS") Is Nothing Then oDtDetalle.Columns.Remove("OS")

                Dim blExiste As Boolean = False
                Dim blExisteOper As Boolean = False
                Dim blExisteRev As Boolean = False
                Dim blExisteEmb As Boolean = False

                Dim NSECFC As String = ""
                Dim TIPRO As String = ""
                Dim NOPRCN As String = ""
                Dim TMNDA As String = ""
                Dim NRTFSV As String = ""
                Dim SERVICIO As String = ""
                Dim IVLSRV As String = "" 'tarida
                Dim QATNAN As Decimal = 0 'cantidad
                Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                Dim NCRROP As String = String.Empty


                Try
                    For i As Integer = 0 To oDtDetalle.Rows.Count - 1

                        blExiste = False
                        blExisteOper = False
                        blExisteRev = False
                        blExisteEmb = False

                        With oDtDetalle


                            If i = 0 Then
                                NSECFC = .Rows(i).Item("NSECFC")
                                NOPRCN = .Rows(i).Item("NOPRCN")
                                TMNDA = .Rows(i).Item("TMNDA")
                                NRTFSV = .Rows(i).Item("NRTFSV")
                                SERVICIO = .Rows(i).Item("SERVICIO")
                                IVLSRV = .Rows(i).Item("IVLSRV")
                                QATNAN = .Rows(i).Item("QATNAN")
                                SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                NCRROP = .Rows(i).Item("NCRROP")
                            End If


                            If NOPRCN = .Rows(i).Item("NOPRCN") And _
                                                              TMNDA = .Rows(i).Item("TMNDA") And _
                                                              NRTFSV = .Rows(i).Item("NRTFSV") And _
                                                              SERVICIO = .Rows(i).Item("SERVICIO") And _
                                                              IVLSRV = .Rows(i).Item("IVLSRV") And _
                                                              QATNAN = .Rows(i).Item("QATNAN") And _
                                                              NCRROP = .Rows(i).Item("NCRROP") And _
                                                              SUB_TOTAL = .Rows(i).Item("SUB_TOTAL") Then
                                blExiste = True
                            End If


                            If NSECFC = .Rows(i).Item("NSECFC") Then
                                blExisteRev = True
                            End If

                            If NOPRCN = .Rows(i).Item("NOPRCN") Then
                                blExisteOper = True
                            End If

                            NSECFC = .Rows(i).Item("NSECFC")

                            NOPRCN = .Rows(i).Item("NOPRCN")
                            TMNDA = .Rows(i).Item("TMNDA")
                            NRTFSV = .Rows(i).Item("NRTFSV")
                            SERVICIO = .Rows(i).Item("SERVICIO")
                            IVLSRV = .Rows(i).Item("IVLSRV")
                            QATNAN = .Rows(i).Item("QATNAN")
                            SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                            NCRROP = .Rows(i).Item("NCRROP")


                            If blExisteRev And i > 0 Then
                                .Rows(i).Item("NSECFC") = 0
                            End If

                            If blExisteOper And i > 0 Then
                                .Rows(i).Item("NOPRCN") = 0
                            End If


                            If blExiste And i > 0 Then

                                .Rows(i).Item("TMNDA") = ""
                                .Rows(i).Item("NRTFSV") = 0
                                .Rows(i).Item("SERVICIO") = ""
                                .Rows(i).Item("TCMTRF") = ""
                                .Rows(i).Item("IVLSRV") = 0
                                .Rows(i).Item("QATNAN") = 0
                                .Rows(i).Item("SUB_TOTAL") = 0
                                .AcceptChanges()
                            End If
                        End With
                    Next
                Catch ex As Exception

                End Try

                With oDtDetalle

                    .Columns("NSECFC").SetOrdinal(0)
                    .Columns("NOPRCN").SetOrdinal(1)


                    .Columns("NSECFC").ColumnName = "Nro Revisión"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("QATNAN").ColumnName = "Cantidad"
                    .Columns("NORSCI").ColumnName = "Embarque"
                    .Columns("NDOCEM").ColumnName = "Doc. Embarque"
                    .Columns("CZNFCC").ColumnName = "Cod. Zona"
                    .Columns("TZNFCC").ColumnName = "Zona"
                    .Columns("PNNMOS").ColumnName = "O/S"
                    .Columns("TNRODU").ColumnName = "DUA"
                    .Columns("TCANAL").ColumnName = "Canal"
                    .Columns("CMEDTR").ColumnName = "Medio Transporte"
                    .Columns("CPAIS").ColumnName = "Cod. Pais"
                    .Columns("TCMPPS").ColumnName = "Pais"
                    .Columns("TCMPVP").ColumnName = "Nave"
                    .Columns("FAPREV").ColumnName = "ETD"
                    .Columns("FAPRAR").ColumnName = "ETA"
                    .Columns("FORSCI").ColumnName = "Fec. Apertura"

                End With



            Case Else

        End Select

        '==================Solo se genera una cuenta cargo plan si es de tipo reembolso========
        If obj_Servicio.CTPALJ = "RE" Then oDtDetalle = GeneraCargoPlanDetalle(oDtDetalle, tipo_cambio)
        '=============================================================================

        If oDtDetalle.Columns("Cliente") IsNot Nothing Then oDtDetalle.Columns.Remove("Cliente")
        If oDtDetalle.Columns("CCLNT") IsNot Nothing Then oDtDetalle.Columns.Remove("CCLNT")
        If oDtDetalle.Columns("FOPRCN") IsNot Nothing Then oDtDetalle.Columns.Remove("FOPRCN")
        If oDtDetalle.Columns("FATNSR") IsNot Nothing Then oDtDetalle.Columns.Remove("FATNSR")
        If oDtDetalle.Columns("Nro Secuencia") IsNot Nothing Then oDtDetalle.Columns.Remove("Nro Secuencia")
        If oDtDetalle.Columns("CCMPN") IsNot Nothing Then oDtDetalle.Columns.Remove("CCMPN")
        If oDtDetalle.Columns("CDVSN") IsNot Nothing Then oDtDetalle.Columns.Remove("CDVSN")

        If Not bolTipoRevision Then
            If oDtDetalle.Columns("NSECFC") IsNot Nothing Then oDtDetalle.Columns.Remove("NSECFC")
        Else
            If oDtDetalle.Columns("NSECFC") IsNot Nothing Then oDtDetalle.Columns("NSECFC").ColumnName = "Nro Revisión"
        End If


        If oDtDetalle.Columns("SESTRG") IsNot Nothing Then oDtDetalle.Columns.Remove("SESTRG")
        If oDtDetalle.Columns("NCRROP") IsNot Nothing Then oDtDetalle.Columns.Remove("NCRROP")
        If oDtDetalle.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalle.Columns.Remove("TIPO_CAMBIO")
        If oDtDetalle.Columns("NSLCSR") IsNot Nothing Then oDtDetalle.Columns.Remove("NSLCSR")
        If oDtDetalle.Columns("NGUITR") IsNot Nothing Then oDtDetalle.Columns.Remove("NGUITR")
        If oDtDetalle.Columns("CTRMNC") IsNot Nothing Then oDtDetalle.Columns.Remove("CTRMNC")
        If oDtDetalle.Columns("COD") IsNot Nothing Then oDtDetalle.Columns.Remove("COD")

        If oDtDetalle.Columns("VALCTE") IsNot Nothing Then oDtDetalle.Columns.Remove("VALCTE")
        If oDtDetalle.Columns("ITPCMT") IsNot Nothing Then oDtDetalle.Columns.Remove("ITPCMT")
        If oDtDetalle.Columns("TOBS") IsNot Nothing Then oDtDetalle.Columns.Remove("TOBS")

        oDtDetalle.TableName = "Detalle"
        Return oDtDetalle

    End Function

    Private Function ResumenTableDetalle(ByVal objDt As DataTable, ByVal Tipo As Servicio_BE) As DataTable

        Dim oDtDetalle As DataTable = objDt


        Dim Revision As String = ""
        Dim Operacion As String = ""
        Dim Guia As String = ""
        Dim FechaInicio As String = ""

        Dim TipoServicio As String = ""
        Dim Bulto As String = ""
        Dim ChoferProveedor As String = ""
        Dim Placa As String = ""
        Dim Unidad As String = ""
        Dim TipoBulto As String = ""
        Dim CantidadBulto As String = ""
        Dim OrdenCompra As String = ""
        Dim tarifa As String = String.Empty

        Dim Cantidad As Integer = 0
        Dim Monto As Integer = 0

        Dim nCount As Integer = 0
        Dim blExisteOperacion As Boolean = False
        Dim blExisteRevision As Boolean = False
        Dim blExisteBulto As Boolean = False



        For i As Integer = 0 To oDtDetalle.Rows.Count - 1


            blExisteOperacion = False
            blExisteRevision = False
            blExisteBulto = False
            Select Case Tipo.CDVSN

                Case "R"
                    Select Case Tipo.STPODP
                        Case "7" ' almacen de transito
                            If Not Tipo.CTPALJ = "RE" Then

                                If i = 0 Then
                                    Operacion = oDtDetalle.Rows(i).Item("Operación")
                                    Guia = oDtDetalle.Rows(i).Item("Guía").ToString.Trim
                                    FechaInicio = oDtDetalle.Rows(i).Item("Fecha Servicio").ToString

                                    TipoServicio = oDtDetalle.Rows(i).Item("Tipo de Servicio").ToString

                                    Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim

                                    ChoferProveedor = oDtDetalle.Rows(i).Item("Chofer / Proveedor").ToString.Trim
                                    Placa = oDtDetalle.Rows(i).Item("Placa").ToString
                                    Unidad = oDtDetalle.Rows(i).Item("Unidad").ToString
                                    TipoBulto = oDtDetalle.Rows(i).Item("Tipo de Bulto").ToString
                                    CantidadBulto = oDtDetalle.Rows(i).Item("Cantidad de Bulto").ToString
                                    OrdenCompra = oDtDetalle.Rows(i).Item("Orden de Compra").ToString.Trim

                                    If bolTipoRevision Then
                                        Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                                    End If

                                End If

                                If bolTipoRevision Then
                                    If Revision = oDtDetalle.Rows(i).Item("Nro Revisión") Then
                                        blExisteRevision = True
                                    End If
                                End If


                                If Operacion = oDtDetalle.Rows(i).Item("Operación") Then
                                    blExisteOperacion = True
                                End If

                                If Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim And blExisteOperacion Then
                                    blExisteBulto = True
                                End If


                                If bolTipoRevision Then
                                    Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                                End If

                                Operacion = oDtDetalle.Rows(i).Item("Operación").ToString
                                Guia = oDtDetalle.Rows(i).Item("Guía").ToString.Trim
                                FechaInicio = oDtDetalle.Rows(i).Item("Fecha Servicio").ToString

                                TipoServicio = oDtDetalle.Rows(i).Item("Tipo de Servicio").ToString

                                Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim

                                ChoferProveedor = oDtDetalle.Rows(i).Item("Chofer / Proveedor").ToString.Trim
                                Placa = oDtDetalle.Rows(i).Item("Placa").ToString
                                Unidad = oDtDetalle.Rows(i).Item("Unidad").ToString
                                TipoBulto = oDtDetalle.Rows(i).Item("Tipo de Bulto").ToString
                                CantidadBulto = oDtDetalle.Rows(i).Item("Cantidad de Bulto").ToString
                                OrdenCompra = oDtDetalle.Rows(i).Item("Orden de Compra").ToString.Trim
                                TipoBulto = oDtDetalle.Rows(i).Item("Tipo de Bulto").ToString



                                If blExisteRevision And i > 0 And bolTipoRevision Then
                                    oDtDetalle.Rows(i).Item("Nro Revisión") = 0
                                End If

                                If blExisteOperacion And i > 0 Then
                                    oDtDetalle.Rows(i).Item("Operación") = 0
                                    oDtDetalle.Rows(i).Item("Fecha Operación") = ""
                                    oDtDetalle.Rows(i).Item("Fecha Servicio") = ""
                                    oDtDetalle.Rows(i).Item("Tipo de Servicio") = ""
                                    oDtDetalle.Rows(i).Item("Referencia Operación") = ""
                                End If

                                If blExisteBulto And i > 0 Then
                                    oDtDetalle.Rows(i).Item("Bulto") = ""
                                    oDtDetalle.Rows(i).Item("Referencia de Mercaderia") = ""
                                    oDtDetalle.Rows(i).Item("Cantidad de Bulto") = 0
                                    oDtDetalle.Rows(i).Item("Tipo de Bulto") = ""
                                    oDtDetalle.Rows(i).Item("Fecha de Ingreso") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Fecha de Salida") = DBNull.Value
                                    'oDtDetalle.Rows(i).Item("Días") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Periodo Inicial") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Periodo Final") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Periodos x Aplicar") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Cantidad de Bulto") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Tipo de Bulto") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Peso (Kgs). Bulto") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("Tipo de almacen") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("MT2") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("C.I Terrestre") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("C.I Fluvial") = DBNull.Value
                                    oDtDetalle.Rows(i).Item("C.I Aereo") = DBNull.Value

                                End If
                                oDtDetalle.AcceptChanges()


                            Else
                                '==============================Solo de tipo Reembolso===============================
                                If i = 0 Then
                                    Operacion = oDtDetalle.Rows(i).Item("Operación")
                                    If bolTipoRevision Then
                                        Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                                    End If

                                End If

                                If bolTipoRevision Then
                                    If Revision = oDtDetalle.Rows(i).Item("Nro Revisión") Then
                                        blExisteRevision = True
                                    End If
                                End If


                                If Operacion = oDtDetalle.Rows(i).Item("Operación") Then
                                    blExisteOperacion = True
                                End If

                                Operacion = oDtDetalle.Rows(i).Item("Operación")
                                If bolTipoRevision Then
                                    Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                                End If



                                If blExisteRevision And i > 0 And bolTipoRevision Then
                                    oDtDetalle.Rows(i).Item("Nro Revisión") = 0
                                End If

                                If blExisteOperacion And i > 0 Then
                                    oDtDetalle.Rows(i).Item("Operación") = 0
                                    oDtDetalle.Rows(i).Item("Fecha Servicio") = ""
                                    oDtDetalle.Rows(i).Item("Tipo Proceso") = ""
                                    oDtDetalle.Rows(i).Item("Código de Tarifa") = 0
                                End If

                            End If


                        Case "1" 'deposito simple
                            If i = 0 Then

                                If bolTipoRevision Then
                                    Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                                End If


                                Operacion = oDtDetalle.Rows(i).Item("Operación")
                                TipoServicio = oDtDetalle.Rows(i).Item("Tipo Servicio")
                                FechaInicio = oDtDetalle.Rows(i).Item("Fecha Servicio")
                                tarifa = oDtDetalle.Rows(i).Item("Código Tarifa")
                            End If


                            If bolTipoRevision Then
                                If Revision = oDtDetalle.Rows(i).Item("Nro Revisión") Then
                                    blExisteRevision = True
                                End If
                            End If

                            If Operacion = oDtDetalle.Rows(i).Item("Operación") Then
                                blExisteOperacion = True
                            End If



                            If bolTipoRevision Then
                                Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                            End If

                            Operacion = oDtDetalle.Rows(i).Item("Operación")


                            If blExisteRevision And i > 0 And bolTipoRevision Then
                                oDtDetalle.Rows(i).Item("Nro Revisión") = 0
                            End If

                            If blExisteOperacion And i > 0 Then
                                oDtDetalle.Rows(i).Item("Operación") = 0
                                oDtDetalle.Rows(i).Item("Fecha Operación") = ""
                                oDtDetalle.Rows(i).Item("Fecha Servicio") = ""
                                oDtDetalle.Rows(i).Item("Tipo Servicio") = ""
                                oDtDetalle.Rows(i).Item("Código Tarifa") = 0
                            End If

                            oDtDetalle.AcceptChanges()

                    End Select

                Case "S" 'SIL : SEGUIMIENTO INTERNACIONAL DE LOGISTICO

                    Try
                        If i = 0 Then

                            If bolTipoRevision Then
                                Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                            End If


                            Operacion = oDtDetalle.Rows(i).Item("Operación")
                            TipoServicio = oDtDetalle.Rows(i).Item("Tipo Servicio")
                            tarifa = oDtDetalle.Rows(i).Item("Código de Tarifa")
                            Cantidad = oDtDetalle.Rows(i).Item("Cantidad")
                            Monto = oDtDetalle.Rows(i).Item("Monto a Cobrar")

                        End If

                        If bolTipoRevision Then
                            If Revision = oDtDetalle.Rows(i).Item("Nro Revisión") Then
                                blExisteRevision = True
                            End If
                        End If



                        If Operacion = oDtDetalle.Rows(i).Item("Operación") And _
                        tarifa = oDtDetalle.Rows(i).Item("Código de Tarifa") And _
                        Cantidad = oDtDetalle.Rows(i).Item("Cantidad") And _
                        Monto = oDtDetalle.Rows(i).Item("Monto a Cobrar") Then
                            blExisteOperacion = True
                        End If





                        If bolTipoRevision Then
                            Revision = oDtDetalle.Rows(i).Item("Nro Revisión")
                        End If

                        Operacion = oDtDetalle.Rows(i).Item("Operación")
                        TipoServicio = oDtDetalle.Rows(i).Item("Tipo Servicio")
                        tarifa = oDtDetalle.Rows(i).Item("Código de Tarifa")
                        Cantidad = oDtDetalle.Rows(i).Item("Cantidad")
                        Monto = oDtDetalle.Rows(i).Item("Monto a Cobrar")

                        If blExisteRevision And i > 0 And bolTipoRevision Then
                            oDtDetalle.Rows(i).Item("Nro Revisión") = 0
                        End If

                        If blExisteOperacion And i > 0 Then
                            oDtDetalle.Rows(i).Item("Operación") = 0
                            oDtDetalle.Rows(i).Item("Tipo Servicio") = ""
                            oDtDetalle.Rows(i).Item("Tipo Servicio") = ""
                            oDtDetalle.Rows(i).Item("Código de Tarifa") = 0
                            oDtDetalle.Rows(i).Item("Cantidad") = 0
                            oDtDetalle.Rows(i).Item("Monto a Cobrar") = 0

                            oDtDetalle.Rows(i).Item("Fecha Servicio") = ""
                            oDtDetalle.Rows(i).Item("Moneda") = ""
                            oDtDetalle.Rows(i).Item("Servicio") = ""
                            oDtDetalle.Rows(i).Item("Importe tarifa") = 0
                        End If
                        oDtDetalle.AcceptChanges()

                    Catch ex As Exception

                    End Try
            End Select







        Next

        Return oDtDetalle
    End Function

    Private Function GeneraCICargoPlan(ByVal _oServicio As Servicio_BE) As DataTable
        Dim oServicioNeg As New clsServicio_BL
        Dim oDs As New DataSet
        Dim oDtCI As New DataTable
        Dim oDtOC_Dist As New DataTable

        Dim oDtCIFiltro As New DataTable
        Dim where As String = ""
        Dim sumaCI As Double = 0D

        Dim oDtTemp As New DataTable
        Dim oDtOCTemp As New DataTable

        ' === Creamos Structura Tabla Distribución === 
        oDtOCTemp.Columns.Add("FLG")
        oDtOCTemp.Columns.Add("CI")
        oDtOCTemp.Columns.Add("POR")
        ' ========== ========== ========== ============

        oDs = oServicioNeg.Importa_CI_CargoPlan(_oServicio)
        oDtCI = oDs.Tables(0)
        oDtOC_Dist = oDs.Tables(1)
        Dim oDtFinal As New DataTable

        oDtFinal.Columns.Add("CI", GetType(String))
        oDtFinal.Columns.Add("PRCRMT", GetType(Decimal))
        Dim drFinal As DataRow
        If oDtOC_Dist.Rows.Count = 0 Then
            '============Distribución Simple================
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                where = "CI = '" & oDtCI.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = filtraDatatable(oDtCI, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("PRCRMT")
                Next

                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        Else
            '============Hacemos distribucion adicional por OC============
            Dim iRow As DataRow
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                '=========================Buscamos OC=========================
                where = "NORCML = '" & oDtCI.Rows(i).Item("NORCML").ToString.Trim & "' "
                oDtTemp = filtraDatatable(oDtOC_Dist, where)
                If oDtTemp.Rows.Count > 0 Then
                    For Each oDrOC As DataRow In oDtTemp.Rows
                        iRow = oDtOCTemp.NewRow
                        iRow("FLG") = "DISTRIBUIDOS"
                        Select Case oDtCI.Rows(i).Item("CMEDTR")
                            Case "4" 'TERRESTRE
                                iRow("CI") = oDrOC("TCTCST")
                            Case "1" 'AEREO
                                iRow("CI") = oDrOC("TCTCSA")
                            Case "5" ' FLUVIAL
                                iRow("CI") = oDrOC("TCTCSF")
                        End Select
                        iRow("POR") = oDtCI.Rows(i).Item("PRCRMT") * oDrOC("IPRCTJ") * 0.01 ' VALOR DEL PORCENTAJE DISTRIBUIDO
                        oDtOCTemp.Rows.Add(iRow)
                    Next
                Else
                    iRow = oDtOCTemp.NewRow
                    iRow("FLG") = "NORMAL"
                    iRow("CI") = oDtCI.Rows(i).Item("CI")
                    iRow("POR") = oDtCI.Rows(i).Item("PRCRMT")
                    oDtOCTemp.Rows.Add(iRow)
                End If
            Next
            oDtOCTemp.DefaultView.Sort = "CI"
            oDtOCTemp = oDtOCTemp.DefaultView.ToTable()
            For i As Integer = 0 To oDtOCTemp.Rows.Count - 1
                where = "CI = '" & oDtOCTemp.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = filtraDatatable(oDtOCTemp, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("POR")
                Next


                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtOCTemp.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        End If

        Return oDtFinal
    End Function

    Private Function GeneraCI(ByVal oDtDetalle As DataTable, ByVal tipo_cambio As Decimal) As DataTable
        Dim oDtCI As New DataTable
        Dim oDtCiPrint As New DataTable
        Dim oDtCiPrintFinal As New DataTable
        Dim dtFiltro As New DataTable
        oDtCI = oDtDetalle.Copy
        Dim oDvCI As New DataView(oDtCI)
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Ransa.Controls.ServicioOperacion.Servicio_BE
        Dim objDataRow As DataRow = Nothing
        Dim TotMntSoles As Decimal = 0D
        Dim TotMntDolares As Decimal = 0D


        oDtCI = oDvCI.ToTable(True, "NOPRCN", "NRTFSV", "CI", "TMNDA", "NCRROP", "NGUITR", "CTRMNC", "QATNAN", "VALCTE", "SUB_TOTAL", "IMPORTE")
        Dim OriginalCount As Integer = oDtCI.Rows.Count

        oDtCI.Columns.Remove("NOPRCN")

        oDtCiPrint.Columns.Add("CI")
        oDtCiPrint.Columns.Add("MONEDA")
        oDtCiPrint.Columns.Add("SOLES")
        oDtCiPrint.Columns.Add("DOLARES")
        oDtCiPrintFinal = oDtCiPrint.Clone

        oDtCI.DefaultView.Sort = "CI"
        oDtCI = oDtCI.DefaultView.ToTable

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0

            '=============EN CASO DE QUE LA CUENTA IMPUTACION SEA DESDE UN CARGO PLAN==================
            If oDtCI.Rows(i)("CI").ToString.Trim = "IMP_CARGO_PLAN" Then

                obe.NGUITR = oDtCI.Rows(i)("NGUITR")
                obe.CTRMNC = oDtCI.Rows(i)("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)

                For Each dr As DataRow In oDtCagoPlan.Rows

                    If oDtCI.Rows(i)("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("SUB_TOTAL") * tipo_cambio 'oDtCI.Rows(i)("QATNAN") * tipo_cambio + (oDtCI.Rows(i)("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE"))
                            TotMntDolares = oDtCI.Rows(i)("SUB_TOTAL") 'oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = Convert.ToDouble(oDtCI.Rows(i)("QATNAN")) * tipo_cambio
                            TotMntDolares = Convert.ToDouble(oDtCI.Rows(i)("QATNAN"))
                        End If


                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("SUB_TOTAL") * tipo_cambio 'oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = oDtCI.Rows(i)("QATNAN")
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else

                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares = oDtCI.Rows(i)("SUB_TOTAL") 'oDtCI.Rows(i)("QATNAN") / tipo_cambio + (oDtCI.Rows(i)("QATNAN") / tipo_cambio * oDtCI.Rows(i)("ITPCMT") / 100)
                            Else
                                TotMntDolares = Convert.ToDouble(oDtCI.Rows(i)("QATNAN")) / tipo_cambio
                            End If

                        End If
                    End If

                    TotMntSoles = (TotMntSoles * dr("PRCRMT") / 100)
                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = dr("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                Next


            Else
                '=============CUENTA DE IMPUTACION NORMAL
                dtFiltro = filtraDatatable(oDtCI, "CI = '" + oDtCI.Rows(i)("CI").ToString.Trim + "'")
                For Each dr As DataRow In dtFiltro.Rows

                    If dr("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("QATNAN") * tipo_cambio + (dr("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            TotMntDolares += dr("QATNAN") + (dr("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles += Convert.ToDouble(dr("QATNAN")) * tipo_cambio
                            TotMntDolares += Convert.ToDouble(dr("QATNAN"))
                        End If




                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("QATNAN") + (dr("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles += Convert.ToDouble(dr("QATNAN"))
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares += dr("QATNAN") / tipo_cambio + (dr("QATNAN") / tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            Else
                                TotMntDolares += Convert.ToDouble(dr("QATNAN")) / tipo_cambio
                            End If

                        End If
                    End If

                Next

                If dtFiltro.Rows.Count > 0 Then

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim

                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                    i = i + dtFiltro.Rows.Count - 1
                End If


            End If

        Next i


        '=====se recorre nuevamente para saber si se encontro la misma cuenta ya sea en un cargo plan o registro normal=========
        oDtCiPrint.DefaultView.Sort = "CI"
        oDtCiPrint = oDtCiPrint.DefaultView.ToTable

        OriginalCount = oDtCiPrint.Rows.Count

        For i As Integer = 0 To OriginalCount - 1

            TotMntDolares = 0
            TotMntSoles = 0

            dtFiltro = filtraDatatable(oDtCiPrint, "CI = '" + oDtCiPrint.Rows(i)("CI").ToString.Trim + "'")
            For Each dr As DataRow In dtFiltro.Rows

                If dr("MONEDA").ToString.Trim = "USD" Then
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    TotMntDolares += Convert.ToDouble(dr("DOLARES"))

                Else
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    If tipo_cambio = 0 Then
                        TotMntDolares += 0
                    Else
                        TotMntDolares += Convert.ToDouble(dr("SOLES"))
                    End If
                End If

            Next

            If dtFiltro.Rows.Count > 0 Then

                objDataRow = oDtCiPrintFinal.NewRow
                objDataRow.Item("CI") = oDtCiPrint.Rows(i)("CI").ToString.Trim
                objDataRow.Item("MONEDA") = oDtCiPrint.Rows(i)("MONEDA").ToString.Trim

                objDataRow.Item("SOLES") = TotMntSoles
                objDataRow.Item("DOLARES") = TotMntDolares
                oDtCiPrintFinal.Rows.Add(objDataRow)

                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        If oDtCiPrintFinal.Rows.Count > 0 Then oDtCiPrint = oDtCiPrintFinal


        Return oDtCiPrint
    End Function

    Private Function GeneraCargoPlanDetalle(ByVal oDt As DataTable, ByVal tipo_cambio As Decimal) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow

        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("Moneda").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("Monto a Cobrar"))

                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("Monto a Cobrar")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Cobrar") = TotMntDolares


                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("Monto a Cobrar") = TotMntDolares
                        drAux("Estado Facturación") = row("Estado Facturación")
                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        Return oDtAux
    End Function

    Private Function GeneraCargoPlanDetalleReemb(ByVal oDt As DataTable, ByVal tipo_cambio As Decimal) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        Dim TotMntSoles As Decimal = 0
        Dim TotMntDolaresRem As Decimal = 0
        Dim TotMntSolesRem As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow


        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("Moneda").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("Monto a Pagar USD/."))
                        TotMntSoles = Val("" & row("Monto a Pagar S/.") & "")

                        TotMntDolaresRem = Val("" & row("Monto a Reeembolsar USD/.") & "")
                        TotMntSolesRem = Val("" & row("Monto a Reeembolsar S/.") & "")

                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("Monto a Pagar USD/.")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If TotMntSoles > 0 Then TotMntSoles = (TotMntSoles * dr("PRCRMT") / 100)
                    If TotMntDolaresRem > 0 Then TotMntDolaresRem = (TotMntDolaresRem * dr("PRCRMT") / 100)
                    If TotMntSolesRem > 0 Then TotMntDolaresRem = (TotMntSolesRem * dr("PRCRMT") / 100)



                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Pagar USD/.") = TotMntDolares.ToString("N2")

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Pagar S/.") = TotMntSoles.ToString("N2")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Reeembolsar USD/.") = TotMntDolaresRem.ToString("N2")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Reeembolsar S/.") = TotMntSolesRem.ToString("N2")

                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("Monto a Pagar USD/.") = TotMntDolares
                        drAux("FEE") = row("FEE")

                        If TotMntSoles > 0 Then drAux("Monto a Pagar S/.") = TotMntSoles.ToString("N2")
                        If TotMntDolaresRem > 0 Then drAux("Monto a Reeembolsar USD/.") = TotMntDolaresRem.ToString("N2")
                        If TotMntSolesRem > 0 Then drAux("Monto a Reeembolsar S/.") = TotMntSolesRem.ToString("N2")

                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        oDtAux.Columns.Remove("SUB_TOTAL")
        Return oDtAux
    End Function

    Private Function EmitirReporteExcelReembolso(ByVal oDtReemb As DataTable, ByVal Tipo_Cambio As Decimal) As DataTable

        With oDtReemb

            Dim otblAlm As DataTable = oDtReemb

            Dim NSECFC As String = ""
            Dim TCMPCL As String = ""
            Dim NOPRCN As String = ""
            Dim TMNDA As String = ""
            Dim SERVICIO As String = ""
            Dim TCMTRF As String = ""
            Dim IVLSRV As String = ""
            Dim SESTRG_SERV As String = ""
            Dim FATNSR As String = String.Empty
            Dim blExiste As Boolean = False
            Dim blExisteOper As Boolean = False
            Dim blExisteRev As Boolean = False


            For i As Integer = 0 To otblAlm.Rows.Count - 1


                blExiste = False
                blExisteOper = False
                blExisteRev = False

                If i = 0 Then
                    NSECFC = otblAlm.Rows(i).Item("NSECFC")
                    TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                    NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                    TMNDA = otblAlm.Rows(i).Item("TMNDA")
                    SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                    TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                    IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                    SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                    FATNSR = otblAlm.Rows(i).Item("FATNSR")

                End If


                If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                          NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                          TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                          SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                          TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                          IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                          SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") And _
                                                          FATNSR = otblAlm.Rows(i).Item("FATNSR") Then

                    blExiste = True
                End If



                If NSECFC = otblAlm.Rows(i).Item("NSECFC") Then
                    blExisteRev = True
                End If


                If NOPRCN = otblAlm.Rows(i).Item("NOPRCN") Then
                    blExisteOper = True
                End If


                NSECFC = otblAlm.Rows(i).Item("NSECFC")
                TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")


                If blExisteRev And i > 0 Then
                    otblAlm.Rows(i).Item("NSECFC") = 0
                End If

                If blExisteOper And i > 0 Then
                    otblAlm.Rows(i).Item("NOPRCN") = 0
                    otblAlm.Rows(i).Item("TIPRO") = ""
                End If



                If blExiste And i > 0 Then

                    otblAlm.Rows(i).Item("TCMPCL") = ""
                    otblAlm.Rows(i).Item("SERVICIO") = ""
                    otblAlm.Rows(i).Item("TCMTRF") = ""
                    otblAlm.Rows(i).Item("NRTFSV") = 0
                    otblAlm.Rows(i).Item("FATNSR") = ""

                    otblAlm.AcceptChanges()



                End If

            Next
            oDtReemb = otblAlm
            '================================================

            If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
            If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
            If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")



            oDtReemb.Columns.Add("TOTAL_SOLES", GetType(Decimal))
            oDtReemb.Columns.Add("REEMBOLSO_SOL", GetType(Decimal))
            oDtReemb.Columns.Add("REEMBOLSO_DOL", GetType(Decimal))

            Dim strFactura As String = String.Empty

            For i As Integer = 0 To oDtReemb.Rows.Count - 1

                If oDtReemb.Rows(i).Item("ITPCMT") > 0 Then

                    oDtReemb.Rows(i).Item("TOTAL_SOLES") = oDtReemb.Rows(i).Item("ITPCMT") * oDtReemb.Rows(i).Item("SUB_TOTAL")
                    oDtReemb.Rows(i).Item("REEMBOLSO_SOL") = Math.Round((oDtReemb.Rows(i).Item("TOTAL_SOLES") * oDtReemb.Rows(i).Item("VALCTE") / 100) + oDtReemb.Rows(i).Item("TOTAL_SOLES"), 2)
                    oDtReemb.Rows(i).Item("REEMBOLSO_DOL") = Math.Round(oDtReemb.Rows(i).Item("REEMBOLSO_SOL") / oDtReemb.Rows(i).Item("ITPCMT"), 2)

                Else
                    oDtReemb.Rows(i).Item("REEMBOLSO_DOL") = 0
                End If

                If oDtReemb.Rows(i).Item("NUMERO_DOC") > 0 Then
                    strFactura = oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Substring(0, 3)
                    strFactura = strFactura & "-" & oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Substring(3, oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Length - 3)
                    oDtReemb.Rows(i).Item("NUMERO_DOC") = strFactura
                Else
                    oDtReemb.Rows(i).Item("NUMERO_DOC") = 0
                End If


                oDtReemb.AcceptChanges()
            Next


            .Columns("NSECFC").SetOrdinal(0)
            .Columns("NOPRCN").SetOrdinal(1)
            .Columns("SERVICIO").SetOrdinal(2)
            .Columns("PROVEEDOR").SetOrdinal(3)
            .Columns("NUMERO_DOC").SetOrdinal(4)
            .Columns("TOBS").SetOrdinal(5)
            .Columns("OBSERVACION").SetOrdinal(6)
            '.Columns("FOPRCN").SetOrdinal(7)
            .Columns("FATNSR").SetOrdinal(7)
            .Columns("LOTE").SetOrdinal(8)
            '.Columns("SUB_TOTAL").SetOrdinal(9)
            .Columns("QATNAN").SetOrdinal(9)
            .Columns("TOTAL_SOLES").SetOrdinal(10)
            .Columns("PORCENTAJE").SetOrdinal(11)
            .Columns("VALCTE").SetOrdinal(12)
            .Columns("REEMBOLSO_SOL").SetOrdinal(13)
            .Columns("REEMBOLSO_DOL").SetOrdinal(14)
            .Columns("CI").SetOrdinal(15)
            .Columns("ITPCMT").SetOrdinal(16)



            .Columns("TCMPCL").ColumnName = "Cliente"
            .Columns("NOPRCN").ColumnName = "Operacion"
            .Columns("SERVICIO").ColumnName = "Tipo Servicio"
            .Columns("TCMTRF").ColumnName = "Servicio"
            .Columns("PROVEEDOR").ColumnName = "Proveedor"
            .Columns("NUMERO_DOC").ColumnName = "Factura"
            .Columns("TOBS").ColumnName = "Descripción del Servicio"
            .Columns("OBSERVACION").ColumnName = "Observación"
            .Columns("FATNSR").ColumnName = "Fecha Servicio"
            .Columns("LOTE").ColumnName = "Lote"

            .Columns("QATNAN").ColumnName = "Monto a Pagar USD/."
            .Columns("TOTAL_SOLES").ColumnName = "Monto a Pagar S/."
            .Columns("VALCTE").ColumnName = "FEE"
            .Columns("REEMBOLSO_SOL").ColumnName = "Monto a Reeembolsar S/."
            .Columns("REEMBOLSO_DOL").ColumnName = "Monto a Reeembolsar USD/."
            .Columns("ITPCMT").ColumnName = "T/C"
            .Columns("TMNDA").ColumnName = "Moneda"


        End With

        oDtReemb = GeneraCargoPlanDetalleReemb(oDtReemb, Tipo_Cambio)

        oDtReemb.TableName = "Detalle"


        If oDtReemb.Columns("TCMTRF") IsNot Nothing Then oDtReemb.Columns.Remove("TCMTRF")
        If oDtReemb.Columns("Cliente") IsNot Nothing Then oDtReemb.Columns.Remove("Cliente")
        If oDtReemb.Columns("CCLNT") IsNot Nothing Then oDtReemb.Columns.Remove("CCLNT")
        'If oDtReemb.Columns("FATNSR") IsNot Nothing Then oDtReemb.Columns.Remove("FATNSR")
        If oDtReemb.Columns("FOPRCN") IsNot Nothing Then oDtReemb.Columns.Remove("FOPRCN")
        If oDtReemb.Columns("Nro Secuencia") IsNot Nothing Then oDtReemb.Columns.Remove("Nro Secuencia")
        If oDtReemb.Columns("CCMPN") IsNot Nothing Then oDtReemb.Columns.Remove("CCMPN")
        If oDtReemb.Columns("CDVSN") IsNot Nothing Then oDtReemb.Columns.Remove("CDVSN")

        If bolTipoRevision Then
            If oDtReemb.Columns("NSECFC") IsNot Nothing Then oDtReemb.Columns("NSECFC").ColumnName = "Nro Revisión"
        Else
            If oDtReemb.Columns("NSECFC") IsNot Nothing Then oDtReemb.Columns.Remove("NSECFC")
        End If


        If oDtReemb.Columns("SESTRG") IsNot Nothing Then oDtReemb.Columns.Remove("SESTRG")
        If oDtReemb.Columns("NCRROP") IsNot Nothing Then oDtReemb.Columns.Remove("NCRROP")
        If oDtReemb.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtReemb.Columns.Remove("TIPO_CAMBIO")
        If oDtReemb.Columns("NSLCSR") IsNot Nothing Then oDtReemb.Columns.Remove("NSLCSR")
        If oDtReemb.Columns("NGUITR") IsNot Nothing Then oDtReemb.Columns.Remove("NGUITR")
        If oDtReemb.Columns("CTRMNC") IsNot Nothing Then oDtReemb.Columns.Remove("CTRMNC")
        If oDtReemb.Columns("COD") IsNot Nothing Then oDtReemb.Columns.Remove("COD")



        If oDtReemb.Columns("TIPRO") IsNot Nothing Then oDtReemb.Columns.Remove("TIPRO")
        If oDtReemb.Columns("QATNAN") IsNot Nothing Then oDtReemb.Columns.Remove("QATNAN")
        If oDtReemb.Columns("IVLSRV") IsNot Nothing Then oDtReemb.Columns.Remove("IVLSRV")
        If oDtReemb.Columns("Moneda") IsNot Nothing Then oDtReemb.Columns.Remove("Moneda")
        If oDtReemb.Columns("SESTRG_SERV") IsNot Nothing Then oDtReemb.Columns.Remove("SESTRG_SERV")
        If oDtReemb.Columns("NRTFSV") IsNot Nothing Then oDtReemb.Columns.Remove("NRTFSV")
        If oDtReemb.Columns("SERVICIO") IsNot Nothing Then oDtReemb.Columns.Remove("SERVICIO")
        If oDtReemb.Columns("RUC") IsNot Nothing Then oDtReemb.Columns.Remove("RUC")
        If oDtReemb.Columns("DOCUMENTO") IsNot Nothing Then oDtReemb.Columns.Remove("DOCUMENTO")
        If oDtReemb.Columns("OC") IsNot Nothing Then oDtReemb.Columns.Remove("OC")



        Return oDtReemb
    End Function

    Public Function pLista_Detalle_Servicios_Por_Revision(ByVal obj_Servicio As Servicio_BE) As DataSet
        Dim oDs As DataSet = oServicioDat.Lista_Detalle_Servicios_Por_Revision(obj_Servicio)
        Return oDs
    End Function

#End Region



    Public Function Cargar_Servicios(ByVal oServicio As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.Cargar_Servicios(oServicio)
        Return oDt
    End Function

    Public Function Cargar_Bultos(ByVal oServicio As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.Cargar_Bultos(oServicio)
        Return oDt
    End Function

    Public Function fintActualizaClienteFacturarPorRevision(ByVal oServicios As Servicio_BE) As Integer
        Return oServicioDat.fintActualizaClienteFacturarPorRevision(oServicios)
    End Function

#Region "Datos de clientes SOLMIN"

    Public Function ListaClienteSolmin(ByVal oServicio As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.ListaClienteSolmin(oServicio)
        Return oDt
    End Function

    Public Function ListarRegionVenta(ByVal oServicio As Servicio_BE) As DataTable
        Dim oDt As DataTable = oServicioDat.ListarRegionVenta(oServicio)
        Return oDt
    End Function



    Public Function fblnIsLocked(ByVal Cliente As Int64, ByVal FnVerificacion As String, ByRef strMensaje As String, ByVal strCompania As String, ByVal strDivision As String, ByVal strReg As String) As Boolean
        Dim btnResultado As Boolean = False
        Dim sPARAM_SFLGB1 As String = String.Empty
        Dim sPARAM_SFLGB2 As String = String.Empty
        Dim sMensaje As String = String.Empty

        If oServicioDat.fdtGetInfLocked(Cliente, FnVerificacion, "", "", sPARAM_SFLGB1, sPARAM_SFLGB2, sMensaje, strCompania, strDivision, strReg) Then
            ' Se bloquea solamente al ser C y B 
            If sPARAM_SFLGB1 = "C" And sPARAM_SFLGB2 = "B" Then
                btnResultado = True
                strMensaje = sMensaje
            Else
                strMensaje = "El Cliente esta habilitado"

            End If
        Else
            strMensaje = "Error en la ejecución del Proceso de Verificación"
            ' Se bloquea al no tener respuesta
            btnResultado = True
        End If
        Return btnResultado
    End Function



#End Region


    Public Function fdtListaOperaciones(ByVal oServicios As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaOperaciones(oServicios)
    End Function


    Public Function fdtListaOpListadoServicios(ByVal oServicio As Servicio_BE) As DataTable
        Return oServicioDat.fdtListaOpListadoServicios(oServicio)
    End Function

    Public Function fdsReporteDeOperacionesResumido(ByVal oServicio As Servicio_BE) As DataSet
        Return oServicioDat.fdsReporteDeOperacionesResumido(oServicio)
    End Function

    Public Function fdsReporteDeOperacionesDetallado(ByVal oServicio As Servicio_BE) As DataSet
        Return oServicioDat.fdsReporteDeOperacionesDetallado(oServicio)
    End Function
    Public Function ListaTarifaClienteSolmin(ByVal pobjCliente As Servicio_BE) As DataTable
        Return oServicioDat.ListaTarifaClienteSolmin(pobjCliente)
    End Function



    Public Function fblnUsuarioPermitidoRevertirProvision(ByVal strUsuario As String) As Boolean
        Dim oDt As DataTable
        Try
            oDt = oServicioDat.fdtUsuarioPermitidoRevertirProvision(strUsuario)
            If oDt.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return False
    End Function

    Public Function Validar_Direccion_Servicio(ByVal compania As String, ByVal division As String, ByVal listaoperaciones As String, ByVal listaconsistencias As String) As String

        Dim mensaje As String = String.Empty
        Dim dt As New DataTable

        dt = oServicioDat.Validar_Direccion_Servicio(compania, division, listaoperaciones, listaconsistencias)

        For Each row As DataRow In dt.Rows

            If row.Item("STATUS") = "N" Then
                mensaje = mensaje & row.Item("OBSRESULT") & vbNewLine
            End If
        Next

        Return mensaje
    End Function


    Public Function Validar_Dirección_Servicio(ByVal CCMPN As String) As Boolean 'ECM-HUNDRED-SOPORTE[180716]
        Dim resultado As New DataTable
        resultado = oServicioDat.Validar_Dirección_Servicio(CCMPN)

        If resultado.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fdtListaDirServicxDefecto(ByVal PSCCMPN As String, _
                                              ByVal PSCDVSN As String, _
                                              ByVal PNCCLNTOP As Decimal, _
                                              ByVal PNCCLNTFC As Decimal, _
                                              ByVal PNCPLNDVOP As Decimal, _
                                              ByVal PNCPLNDVFC As Decimal) As DataTable
        Return oServicioDat.fdtListaDirServicxDefecto(PSCCMPN, PSCDVSN, PNCCLNTOP, PNCCLNTFC, PNCPLNDVOP, PNCPLNDVFC)
    End Function

    'ListarTipoDocAprobacionCliente
    Public Function ListarTipoDocAprobacionCliente() As DataTable
        Return oServicioDat.ListarTipoDocAprobacionCliente()
    End Function
    Public Function AsignarDocumentoAprobacionCliente(CCMPN As String, CCLNT As Decimal, strConsistencia As String, TIPODOC As String, DCCLNT As String, SBCLNT As String, CULUSA As String, NTRMNL As String) As String
        Return oServicioDat.AsignarDocumentoAprobacionCliente(CCMPN, CCLNT, strConsistencia, TIPODOC, DCCLNT, SBCLNT, CULUSA, NTRMNL)
    End Function
    Public Sub QuitarDocumentoAprobacionCliente(CCMPN As String, CCLNT As Decimal, strConsistencia As String, CULUSA As String, NTRMNL As String)
        oServicioDat.QuitarDocumentoAprobacionCliente(CCMPN, CCLNT, strConsistencia, CULUSA, NTRMNL)
    End Sub

    Public Function ValidarAccesoModificarOpValorizada(CCMPN As String, CULUSA As String) As Boolean
        Return oServicioDat.ValidarAccesoModificarOpValorizada(CCMPN, CULUSA)
    End Function

    Public Function ListarValorizacionOperacion(CCMPN As String, CDVSN As String, CCLNT As Decimal, strOperaciones As String, strConsistencia As String) As DataTable
        Return oServicioDat.ListarValorizacionOperacion(CCMPN, CDVSN, CCLNT, strOperaciones, strConsistencia)
    End Function

    Public Sub validar_anulacion_consistencia(ByVal poServiciosAtendidos As Servicio_BE, ByRef estado As String, ByRef msgvalidacion As String)
        oServicioDat.validar_anulacion_consistencia(poServiciosAtendidos, estado, msgvalidacion)
    End Sub


End Class
