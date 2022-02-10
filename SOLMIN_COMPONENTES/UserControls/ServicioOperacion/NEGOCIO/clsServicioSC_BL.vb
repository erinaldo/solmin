Public Class clsServicioSC_BL
    'Public Function Eliminar_Item_Detalle_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    retorno = odaServicioSC_DAL.Eliminar_Item_Detalle_Servicio_SC(oServicioSIL)
    '    Return retorno
    'End Function

    Public Function Eliminar_Item_Embarque_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.Eliminar_Item_Embarque_Servicio_SC(oServicioSIL)
        Return retorno
    End Function

    'Public Function Lista_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    retorno = odaServicioSC_DAL.Lista_Item_Servicio_SC(oServicioSIL)
    '    Return retorno
    'End Function

    'Public Function Insertar_Servicio_Facturacion_SC(ByVal oServicios As Servicio_BE) As Decimal
    '    Dim retorno As Decimal = -1
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    retorno = odaServicioSC_DAL.Insertar_Servicio_Facturacion_SC(oServicios)
    '    Return retorno

    'End Function

    'Public Function Actualizar_Servicio_Facturacion_SC(ByVal oServicios As Servicio_BE) As Decimal
    '    Dim retorno As Decimal = -1
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    retorno = odaServicioSC_DAL.Actualizar_Servicio_Facturacion_SC(oServicios)
    '    Return retorno
    'End Function


    'Public Function Insertar_Detalle_Servicio_Facturacion_SC(ByVal oListServicios As List(Of Servicio_BE)) As Int32
    '    Dim retorno As Int32 = 0
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    For Each objServicio As Servicio_BE In oListServicios
    '        retorno = odaServicioSC_DAL.Insertar_Detalle_Servicio_Facturacion_SC(objServicio)
    '    Next
    '    Return retorno
    'End Function
    '*********************************FUNCIONES EN SIL******************************


    'Public Function Lista_Servicios_X_Operacion_Embarque(ByVal oServicioSIL As Servicio_BE) As DataTable
    '    Dim odaServicio As New clsServicioSC_DAL
    '    Dim odtServicio As New DataTable
    '    odtServicio = odaServicio.Lista_Servicios_X_Operacion_Embarque(oServicioSIL)
    '    Return odtServicio
    'End Function

    Public Function Lista_Servicios_Operacion(ByVal oServicioSIL As Servicio_BE) As DataTable
        Dim odaServicio As New clsServicioSC_DAL
        Dim odtServicio As New DataTable
        odtServicio = odaServicio.Lista_Servicios_Operacion(oServicioSIL)
        Return odtServicio
    End Function

   
    Public Function Lista_Datos_Tarifa(ByVal PNNRTFSV As Decimal) As DataTable
        Dim odtDatosTarifa As New DataTable
        Dim odaServicio As New clsServicioSC_DAL
        odtDatosTarifa = odaServicio.Lista_Datos_Tarifa(PNNRTFSV)
        Return odtDatosTarifa
    End Function

    Public Function Insertar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Cabecera(oServicioSIL)
        Return retorno
    End Function

    Public Function Actualizar_Servicio_Facturar_Cabecera(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.Actualizar_Servicio_Facturar_Cabecera(oServicioSIL)
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Embarques(ByVal oListServicioSIL As List(Of Servicio_BE)) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        For Each Item As Servicio_BE In oListServicioSIL
            retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Embarques(Item)
        Next
        Return retorno
    End Function
    Public Function Insertar_Servicio_Facturar_Embarques(ByVal oServicio As Servicio_BE) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Embarques(oServicio)
        Return retorno
    End Function

    Public Function Insertar_Servicio_Facturar_Servicios(ByVal oListServicioSIL As List(Of Servicio_BE)) As Int32
        Dim retorno As Int32 = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        For Each Item As Servicio_BE In oListServicioSIL
            retorno = odaServicioSC_DAL.Insertar_Servicio_Facturar_Servicios(Item)
        Next
        Return retorno
    End Function


    Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
        Dim retorno As Decimal = 0
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.Eliminar_Item_Servicio_SC(oServicioSIL)
        Return retorno
    End Function

    Public Function Obtener_Datos_Operacion(ByVal PNCCLNT As Decimal, ByVal PNNOPRCN As Decimal) As DataTable
        Dim odtOperacion As New DataTable
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        odtOperacion = odaServicioSC_DAL.Obtener_Datos_Operacion(PNCCLNT, PNNOPRCN)
        Return odtOperacion
    End Function
    '**********************************************************************************


    Public Function Lista_Detalle_Servicios_SC(ByVal oServicios As Servicio_BE) As DataTable
        Dim odt As New DataTable
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        odt = odaServicioSC_DAL.Lista_Detalle_Servicios_SC(oServicios)
        Return odt
    End Function
    Public Function Lista_OC_X_Embarque_OS(ByVal oServicios As Servicio_BE) As DataTable
        Dim odt As New DataTable
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        odt = odaServicioSC_DAL.Lista_OC_X_Embarque_OS(oServicios)
        Return odt
    End Function



    'Public Function Eliminar_Operacion_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim retorno As Decimal = -1
    '    Dim odaServicioSC_DAL As New clsServicioSC_DAL
    '    retorno = odaServicioSC_DAL.Eliminar_Operacion_Servicio_SC(oServicioSIL)
    '    Return retorno
    'End Function
    Public Function Lista_Detalle_OC_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim odt As New DataTable
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        odt = odaServicioSC_DAL.Lista_Detalle_OC_Embarque(pdblCli, pdblEmbarque)
        Return odt
    End Function

    Public Function ValidaIngresoEmbarqueAOperacion(ByVal oSerAlmacen As Servicio_BE) As String
        Dim retorno As String = ""
        Dim odaServicioSC_DAL As New clsServicioSC_DAL
        retorno = odaServicioSC_DAL.ValidaIngresoEmbarqueAOperacion(oSerAlmacen)
        Return retorno
    End Function

    'Public Function Lista_Servicios_X_Operacion_Embarque(ByVal oServicioSIL As Servicio_BE) As DataTable
    '    Dim odaServicio As New clsServicioSC_DAL
    '    Dim odtServicio As New DataTable
    '    odtServicio = odaServicio.Lista_Servicios_X_Operacion_Embarque(oServicioSIL)
    '    Return odtServicio
    'End Function
    'Public Function Eliminar_Item_Servicio_SC(ByVal oServicioSIL As Servicio_BE) As Int32
    '    Dim odaServicio As New clsServicioSC_DAL
    '    Dim retorno As Int32 = 0
    '    retorno = odaServicio.Eliminar_Item_Servicio_SC(oServicioSIL)
    '    Return retorno
    'End Function
End Class
