Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS



Public Class clsTarifa
    Private oTarifaDato As SOLMIN_CTZ.DATOS.clsTarifa
    Private oDt As DataTable

    Sub New()
        oTarifaDato = New SOLMIN_CTZ.DATOS.clsTarifa
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    'Public Sub Lista_Tarifa(ByVal pobjTarifa As Tarifa)
    '    oDt = oTarifaDato.Lista_Tarifa(pobjTarifa)
    'End Sub

    Public Function Lista_Tarifa_X_Contrato(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Tarifa_X_Contrato(pobjTarifa)
    End Function

    'Public Function Lista_Tarifa_X_Division(ByVal pobjFiltro As Filtro) As DataTable
    '    Return oTarifaDato.Lista_Tarifa_X_Division(pobjFiltro)
    'End Function

    Public Sub Eliminar_Tarifa(ByVal pobjTarifa As Tarifa)

        oTarifaDato.Eliminar_Tarifa(pobjTarifa)
       
    End Sub


    Public Sub Crear_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)

        oTarifaDato.Crear_Tarifa(oSqlMan, pobjTarifa, pobjRango)
      
    End Sub


    Public Function Crear_Tarifa_RZSC03(ByVal objEntidad As Tarifa) As String

        Return oTarifaDato.Crear_Tarifa_RZSC03(objEntidad)
        
    End Function
    Public Sub Modificar_Tarifa_RZSC03(ByVal objEntidad As Tarifa)

        oTarifaDato.Modificar_Tarifa_RZSC03(objEntidad)
      
    End Sub
    Public Sub Crear_Rango_RZSC03A(ByVal objRango As Rango, ByVal objTarifa As Tarifa)

        oTarifaDato.Crear_Rango_RZSC03A(objRango, objTarifa)
       
    End Sub

    Public Sub Elimina_Rango_RZSC03A(ByVal objRango As Rango, ByVal objTarifa As Tarifa)
        oTarifaDato.Elimina_Rango_RZSC03A(objRango, objTarifa)
    End Sub
    Public Function Lista_Rango_RZSC03A(ByVal objTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Rango_RZSC03A(objTarifa)
    End Function
    Public Function ObtenerDivTarifa_RZSC08(ByVal oTarifa As Tarifa) As Tarifa

        Return oTarifaDato.ObtenerDivTarifa_RZSC08(oTarifa)
       
    End Function


    Public Sub Actualizar_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)

        oTarifaDato.Actualizar_Tarifa(oSqlMan, pobjTarifa, pobjRango)
       
    End Sub

    'Public Function Buscar_Tarifa(ByVal pobjFiltro As Filtro) As DataTable
    '    Return oTarifaDato.Buscar_Tarifa(pobjFiltro)
    'End Function

    'Public Function Buscar_Tarifa_Faltante(ByVal pobjFiltro As Filtro) As DataTable
    '    Return oTarifaDato.Buscar_Tarifa_Faltante(pobjFiltro)
    'End Function

    Public Function Lista_Tarifa_Servicio(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Tarifa_Servicio(pobjTarifa)
    End Function

    Public Function Eliminar_Tarifa_X_Servicio(ByVal pobjTarifa As Tarifa) As Integer

        Return oTarifaDato.Eliminar_Tarifa_X_Servicio(pobjTarifa)
       
    End Function

    Public Sub Eliminar_TarifaC(ByVal pobjTarifa As Tarifa)

        oTarifaDato.Eliminar_TarifaC(pobjTarifa)

       
    End Sub

    Public Function ListaTotalServiciosXTarifa(ByVal objEntidad As Tarifa) As Integer
        Return oTarifaDato.ListaTotalServiciosXTarifa(objEntidad)
    End Function

    Public Sub Modificar_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa)

        oTarifaDato.Modificar_Tarifa_Flete_RZSC03(objEntidad)
        
    End Sub

    Public Function Crear_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa) As String

        Return oTarifaDato.Crear_Tarifa_Flete_RZSC03(objEntidad)
      
    End Function

    Public Function Obtener_Tarifa_Flete_RZSC03(ByVal objEntidad As Tarifa) As Tarifa

        Return oTarifaDato.Obtener_Tarifa_Flete_RZSC03(objEntidad)
      
    End Function

    ''' <summary>
    ''' Listar Detalle tarifa Flete
    ''' </summary>
    ''' <param name="pobjTarifa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListarDetalleTarifaFlete(ByVal pobjTarifa As Tarifa) As DataTable

        Return oTarifaDato.fdtListarDetalleTarifaFlete(pobjTarifa)
       
    End Function


    ''' <summary>
    ''' Cerrar OS
    ''' </summary>
    ''' <param name="pobjTarifa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function fintCerrarOS(ByVal pobjTarifa As Tarifa) As Integer
    '    'Try
    '    Return oTarifaDato.fintCerrarOS(pobjTarifa)
    '    'Catch ex As Exception
    '    '    Throw New Exception(ex.Message)
    '    'End Try
    'End Function
    ''' <summary>
    ''' Lista de Tarifa para Exportar 
    ''' </summary>
    ''' <param name="pobjTarifa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtListarTarifaExportar(ByVal pobjTarifa As Tarifa) As DataSet

        Return oTarifaDato.fdtListarTarifaExportar(pobjTarifa)
     
    End Function

    Public Function ListaTotalServiciosXTarifaFlete(ByVal PNNORSRT As Decimal) As DataTable
        'Try
        Return oTarifaDato.ListaTotalServiciosXTarifaFlete(PNNORSRT)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Function

    Public Sub Anular_Tarifa_X_Servicio(ByVal pobjTarifa As Tarifa)

        oTarifaDato.Anular_Tarifa_X_Servicio(pobjTarifa)

       
    End Sub

    'Public Sub Eliminar_Tarifa_X_Servicio_Fact(ByVal pobjTarifa As Tarifa)
    '    'Try
    '    oTarifaDato.Eliminar_Tarifa_X_Servicio_Fact(pobjTarifa)
    '    'Catch ex As Exception
    '    '    Throw New Exception(ex.Message)
    '    'End Try
    'End Sub

    Public Sub Eliminar_Tarifa_Flete_X_Servicio(ByVal pobjTarifa As Tarifa)

        oTarifaDato.Eliminar_Tarifa_Flete_X_Servicio(pobjTarifa)
        
    End Sub

    Public Function fintActivarTarifa(ByVal pobjTarifa As Tarifa) As Integer

        Return oTarifaDato.fintActivarTarifa(pobjTarifa)
       
    End Function

    Public Function ListaSolicitudXServicio(ByVal objTarifa As Tarifa) As Integer

        Return oTarifaDato.ListaSolicitudXServicio(objTarifa)
     
    End Function
    Public Function ListaOperacionXServicio(ByVal objTarifa As Tarifa) As Integer

        Return oTarifaDato.ListaOperacionXServicio(objTarifa)
      
    End Function

    Public Function ListaOperacionXServicio_Cerrar(ByVal objTarifa As Tarifa) As Integer

        Return oTarifaDato.ListaOperacionXServicio_Cerrar(objTarifa)
      
    End Function

    Public Function ListaTotalServiciosXTarifaCerrar(ByVal objTarifa As Tarifa) As Integer

        Return oTarifaDato.ListaTotalServiciosXTarifaCerrar(objTarifa)
        
    End Function

    Public Function ListaTarifaXCodTarifa(ByVal objTarifa As Tarifa) As DataSet

        Return oTarifaDato.ListaTarifaXCodTarifa(objTarifa)
       
    End Function
    'Public Function Anular_Cerrar_Tarifa_X_Servicio(ByVal pobjTarifa As Tarifa) As Integer
    '    Try
    '        Return oTarifaDato.fintActivarTarifa(pobjTarifa)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Function
    Public Function ListarTarifaFija(ByVal ObjEntidad As Tarifa) As List(Of Tarifa)
        Return oTarifaDato.ListaTarifaFija(ObjEntidad)
    End Function

    '<[AHM]>'
    Public Function ValidarMaterialSAP(ByVal objTarifa As Tarifa) As TarifaSAP

        'Return tarifasap
        'TODO: CUANDO EL SERVICIO DE SAP ESTE DISPONIBLE COMENTAR Y DESCOMENTAR LAS LINAS RESPECTIVAMENTE
        Return oTarifaDato.ValidarMaterialSAP(objTarifa)
    End Function
    '</[AHM]>'

    'RCS-HUNDRED-INICIO

    Public Function Cargar_Datos_Generales_Tarifa_Transporte(ByVal objTarifa As Tarifa) As DataSet 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Return oTarifaDato.Cargar_Datos_Generales_Tarifa_Transporte(objTarifa)
    End Function

    'RCS-HUNDRED-FIN

    ''' <summary>
    ''' copia la lista de tarifa seleccionada
    ''' </summary>
    ''' <param name="objTarifa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CopiarTarifa(ByVal objTarifa As Tarifa) As Integer

        Return oTarifaDato.CopiarTarifa(objTarifa)
       
    End Function

    Public Function Listar_datos_Cliente(ByVal ccmpn As String, ByVal cclnt As Double) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Return oTarifaDato.Listar_datos_Cliente(ccmpn, cclnt)
    End Function

    Public Function Cerrar_Tarifa_Flete_X_Servicio_Item(ByVal pobjTarifa As Tarifa) As String
        Return oTarifaDato.Cerrar_Tarifa_Flete_X_Servicio_Item(pobjTarifa)
    End Function

    Public Function Lista_Validar_Margen_Tarifa(ByVal pobjTarifa As Tarifa, ByRef msgError As String) As DataSet
        Return oTarifaDato.Lista_Validar_Margen_Tarifa(pobjTarifa, msgError)
    End Function
    Public Sub Enviar_Aprobar_Tarifa(ByVal pobjTarifa As Tarifa)
        oTarifaDato.Enviar_Aprobar_Tarifa(pobjTarifa)
    End Sub
    Public Function Lista_Cotizacion_por_Aprobar(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Cotizacion_por_Aprobar(pobjTarifa)
    End Function
    Public Function Lista_Servicio_Mercaderia_Aprobacion(ByVal pobjTarifa As Tarifa) As DataTable
        Return oTarifaDato.Lista_Servicio_Mercaderia_Aprobacion(pobjTarifa)
    End Function
    Public Function Actualizar_Estado_OS(ByVal pobjTarifa As Tarifa) As Integer
        Return oTarifaDato.Actualizar_Estado_OS(pobjTarifa)
    End Function
    Public Sub Cancelar_Envio_Aprobacion_tarifa(ByVal pobjTarifa As Tarifa)
        oTarifaDato.Cancelar_Envio_Aprobacion_tarifa(pobjTarifa)
    End Sub



End Class
