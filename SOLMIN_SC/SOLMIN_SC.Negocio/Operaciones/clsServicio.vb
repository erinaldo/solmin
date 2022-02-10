Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsServicio
    Public Function Lista_Servicios_X_Operacion(ByVal oServicioSIL As beServicioFacturar) As DataTable
        Dim odaServicio As New Datos.clsServicio
        Dim odtServicio As New DataTable
        odtServicio = odaServicio.Lista_Servicios_X_Operacion(oServicioSIL)
        Return odtServicio
    End Function

    Public Function Lista_Tarifa_Servicios_Cliente_Adicionales(ByVal oServicioSIL As beServicioConsulta) As DataTable
        Dim odaServicio As New Datos.clsServicio
        Dim odtServicio As New DataTable
        odtServicio = odaServicio.Lista_Tarifa_Servicios_Cliente_Adicionales(oServicioSIL)
        Return odtServicio
    End Function
    Public Function Lista_Datos_Tarifa(ByVal PNNRTFSV As Decimal) As DataTable
        Dim odtDatosTarifa As New DataTable
        Dim odaServicio As New Datos.clsServicio
        odtDatosTarifa = odaServicio.Lista_Datos_Tarifa(PNNRTFSV)
        Return odtDatosTarifa
    End Function

    Public Function Insertar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New Datos.clsServicio
        retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Cabecera(oServicioSIL)
        Return retorno
    End Function

    Public Function Actualizar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New Datos.clsServicio
        retorno = odaServicioSC_DAL.Actualizar_Servicio_Facturar_Cabecera(oServicioSIL)
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Embarques(ByVal oListServicioSIL As List(Of beServicioFacturar)) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New Datos.clsServicio
        For Each Item As beServicioFacturar In oListServicioSIL
            retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Embarques(Item)
        Next
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Servicios(ByVal oListServicioSIL As List(Of beServicioFacturar)) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New Datos.clsServicio
        For Each Item As beServicioFacturar In oListServicioSIL
            retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Servicios(Item)
        Next
        Return retorno
    End Function


    Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Decimal = -1
        Dim odaServicioSC_DAL As New Datos.clsServicio
        retorno = odaServicioSC_DAL.Eliminar_Item_Servicio_SC(oServicioSIL)
        Return retorno
    End Function

    Public Function Eliminar_Operacion_Facturacion(ByVal oServicioSIL As beServicioFacturar) As Int32
        Dim retorno As Decimal = 0
        Dim odaServicioSC_DAL As New Datos.clsServicio
        retorno = odaServicioSC_DAL.Eliminar_Operacion_Facturacion(oServicioSIL)
        Return retorno
    End Function

    Public Function Existe_Embarque_En_Operacion(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCTPALJ As String) As DataTable
        Dim odtDatosOperacion As New DataTable
        Dim odaServicio As New Datos.clsServicio
        odtDatosOperacion = odaServicio.Existe_Embarque_En_Operacion(PNNORSCI, PNCCLNT, PSCTPALJ)
        Return odtDatosOperacion
    End Function


    Public Function fdtListaDirServicxDefecto(ByVal PSCCMPN As String, _
                                              ByVal PSCDVSN As String, _
                                              ByVal PNCCLNTOP As Decimal, _
                                              ByVal PNCCLNTFC As Decimal, _
                                              ByVal PNCPLNDVOP As Decimal, _
                                              ByVal PNCPLNDVFC As Decimal) As DataTable
        Dim odaServicio As New Datos.clsServicio
        Return odaServicio.fdtListaDirServicxDefecto(PSCCMPN, PSCDVSN, PNCCLNTOP, PNCCLNTFC, PNCPLNDVOP, PNCPLNDVFC)
    End Function

End Class
