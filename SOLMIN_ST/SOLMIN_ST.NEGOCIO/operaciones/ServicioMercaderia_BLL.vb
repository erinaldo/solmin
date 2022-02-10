Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES

Public Class ServicioMercaderia_BLL
    Private objDatos As New ServicioMercaderia_DAL

    Public Function fdtListar_Moneda_L01() As DataTable
        Return objDatos.fdtListar_Moneda_L01()
    End Function

    Public Function ListaDetalleCotizacion(ByVal lobjEntidad As Hashtable) As List(Of ServicioMercaderia)
        Return objDatos.ListaServicioMercaderia(lobjEntidad)
    End Function

    Public Function ListaServicioFlete(ByVal lobjEntidad As Hashtable) As DataTable
        Return objDatos.ListaServicioFlete(lobjEntidad)
    End Function

    Public Function Guardar_Servicio_Mercadia(ByVal lobjEntidad As ServicioMercaderia) As ServicioMercaderia
        Return objDatos.Guardar_Servicio_Mercadia(lobjEntidad)
    End Function

    Public Function Modificar_Servicio_Mercadia(ByVal lobjEntidad As ServicioMercaderia) As String
        Return objDatos.Modificar_Servicio_Mercadia(lobjEntidad)
    End Function

    Public Function Cantidad_Detalle_Cotizacion(ByVal lobjEntidad As ServicioMercaderia) As Double
        Return objDatos.Cantidad_Detalle_Cotizacion(lobjEntidad)
    End Function

    Public Function Eliminar(ByVal lobjEntidad As ServicioMercaderia) As Double
        Return objDatos.Eliminar(lobjEntidad)
    End Function

  Public Function Existe_Servicio(ByVal lobjEntidad As ServicioMercaderia) As Int32
    Return objDatos.Existe_Servicio(lobjEntidad)
    End Function


    Public Function Existe_FleteRuta(ByVal lobjEntidad As ServicioMercaderia) As Int32
        Return objDatos.Existe_FleteRuta(lobjEntidad)
    End Function


    ''' <summary>
    ''' Método que permite obtener el servicio relacionado al detalle
    ''' </summary>
    ''' <param name="lobjEntidad"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Create :      Hugo Pérez Ryan
    ''' Creaton Date: 20/02/2012
    ''' </remarks>
    Public Function Detectar_Servicio(ByVal lobjEntidad As ServicioMercaderia) As Double
        Return objDatos.Detectar_Servicio(lobjEntidad)
    End Function

    Public Function ListaServicioMercaderiaValidacion(ByVal PSCCMPN As String, ByVal PNNCTZCN As Decimal, ByVal MargenNegocio As Decimal) As DataTable
        Return objDatos.ListaServicioMercaderiaValidacion(PSCCMPN, PNNCTZCN, MargenNegocio)
    End Function
    Public Function ListaNegocioxCentroCosto(ByVal PSCCMPN As String, ByVal PNCCNTCS As Decimal) As DataTable
        Return objDatos.ListaNegocioxCentroCosto(PSCCMPN, PNCCNTCS)
    End Function
    Public Function ListaMargenPemitidoxNegocio(ByVal PSCCMPN As String, ByVal PSCRGVTA As String) As Decimal
        Return objDatos.ListaMargenPemitidoxNegocio(PSCCMPN, PSCRGVTA)
    End Function



    Public Function ListaServicioMercaderia_Aprobacion(ByVal lobjEntidad As Hashtable, ByVal MargenNegocio As Decimal) As DataTable
        Return objDatos.ListaServicioMercaderia_Aprobacion(lobjEntidad, MargenNegocio)
    End Function

    Public Function Lista_Tipo_Cambio_Actual(ByVal objParametro As Hashtable) As DataTable
        Return objDatos.Lista_Tipo_Cambio_Actual(objParametro)
    End Function
    Public Function ListaServicioMercaderiaVerificacionDia(ByVal FECHA_INICIO As Decimal, ByVal FECHA_FIN As Decimal, ByVal PSCCMPN As String) As DataTable
        Return objDatos.ListaServicioMercaderiaVerificacionDia(FECHA_INICIO, FECHA_FIN, PSCCMPN)
    End Function


End Class
