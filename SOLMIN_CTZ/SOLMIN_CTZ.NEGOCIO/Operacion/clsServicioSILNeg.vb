Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Public Class clsServicioSILNeg
    Private oServicioDat As clsServicioSILDat

    Sub New()
        oServicioDat = New clsServicioSILDat
    End Sub

    Public Sub Agregar_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            oServicioDat.Agregar_Servicio(pobjServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Agregar_Detalle_Servicio(ByVal pobjServicioSILDet As ServicioSILDet)
        Try
            oServicioDat.Agregar_Detalle_Servicio(pobjServicioSILDet)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Servicio_X_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double, ByVal pstrCompania As String, ByVal pstrDivision As String) As DataTable
        Return oServicioDat.Lista_Servicio_X_Embarque(pdblCli, pdblEmbarque, pstrCompania, pstrDivision)
    End Function

    Public Sub Actualiza_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            oServicioDat.Actualiza_Servicio(pobjServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Quitar_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            oServicioDat.Quitar_Servicio(pobjServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Servicios_x_Cliente(ByVal oServicioSIL As ServicioSIL) As DataTable
        Try
            Return oServicioDat.Lista_Servicios_x_Cliente(oServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Lista_Servicios_x_Operacion(ByVal oServicioSIL As ServicioSIL) As DataTable
        Try
            Return oServicioDat.Lista_Servicios_x_Operacion(oServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Guardar_Servicios_Atendidos(ByVal oServicioSIL As ServicioSIL) As DataTable
        Try
            Return oServicioDat.Guardar_Servicios_Atendidos(oServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Guardar_Detalle_Servicios_SIL(ByVal oServicioSIL As ServicioSIL)
        Try
            oServicioDat.Guardar_Detalle_Servicios_SIL(oServicioSIL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Detalle_Servicios_SIL(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Lista_Detalle_Servicios_SIL(oServicioSIL)
    End Function
    Public Function Lista_Detalle_Servicios_Almacen(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Lista_Detalle_Servicios_Almacen(oServicioSIL)
    End Function

    Public Function Verificar_Servicios_Atendidos(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Verificar_Servicios_Atendidos(oServicioSIL)
    End Function
    Public Function Cargar_Servicios_Tarifa_Cliente(ByVal oServicioSIL As ServicioSIL) As DataTable
        'ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecha As Double
        Return oServicioDat.Lista_Tarifa_Servicios_Cliente(oServicioSIL) 'pstrComp, pstrDiv, pstrPlt, pdblCliente, pdblFecha
    End Function

    'Embarque
    Public Function Lista_OC_X_Embarque_OS(ByVal dblCliente As Double, ByVal pdblEmbarque As Double) As DataTable
        Return oServicioDat.Lista_OC_X_Embarque_OS(dblCliente, pdblEmbarque)
    End Function
    'Tipo Proceso
    Public Function Listar_TablaAyuda_L01(ByVal strCategoria As String) As DataTable
        Return oServicioDat.Listar_TablaAyuda_L01(strCategoria)
    End Function
    'Almacen Listar Para Modificar
    Public Function Lista_Servicio_Almacen_Modificar(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Lista_Servicio_Almacen_Modificar(oServicioSIL)
    End Function
    'Almacen Listar Bultos de la operacion Para Modificar
    Public Function Lista_Bultos_Servicio_Almacen_Modificar(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Lista_Bultos_Servicio_Almacen_Modificar(oServicioSIL)
    End Function
    'ALMACEN AGREGAR BULTOS
    Public Function AgregarDetalleServicio(ByVal oServicioAlm As ServicioAlmacen)
        Return oServicioDat.AgregarDetalleServicio(oServicioAlm)
    End Function
    'Almacen Listar Bultos 
    Public Function fdtServicios_Detalle_L02(ByVal oServAlm As ServicioAlmacen) As DataTable
        Return oServicioDat.fdtServicios_Detalle_L02(oServAlm)
    End Function
    'Guardar Servicios de Almacen
    '======
    Public Function AgregarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen, ByVal intOperacion As Int64) As Boolean
        Return oServicioDat.AgregarServicioAdquiridoSA(oServAlm, intOperacion)
    End Function
    Public Function EditarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen) As Boolean
        Return oServicioDat.EditarServicioAdquiridoSA(oServAlm)
    End Function
    Public Function EliminarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen, ByVal strStatus As String) As Boolean
        Return oServicioDat.EliminarServicioAdquiridoSA(oServAlm)
    End Function
    Public Function EliminarDetalleServicioSA(ByVal oServAlm As ServicioAlmacen) As Boolean
        Return oServicioDat.EliminarDetalleServicioSA(oServAlm)
    End Function
End Class