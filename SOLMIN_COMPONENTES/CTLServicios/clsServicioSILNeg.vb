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

    Public Function Lista_Detalle_Servicios_SIL(ByVal pdblCliente As Double, ByVal pdblOperacion As Double, ByVal pdblTarifaServicio As Double) As DataTable
        Return oServicioDat.Lista_Detalle_Servicios_SIL(pdblCliente, pdblOperacion, pdblTarifaServicio)
    End Function

    Public Function Verificar_Servicios_Atendidos(ByVal oServicioSIL As ServicioSIL) As DataTable
        Return oServicioDat.Verificar_Servicios_Atendidos(oServicioSIL)
    End Function

End Class
