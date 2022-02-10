Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daProyecto

    Inherits daBase(Of beProyecto)

    Private objSql As New SqlManager

#Region "Mantenimiento  Proyecto"
    Public Function fIntInsertarProyectoOcRegularizacion(ByVal obeProyecto As beProyecto) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeProyecto.PNCCLNT)
            objParam.Add("PSNORCML", obeProyecto.PSNORCML.Trim)
            objParam.Add("PNNRITOC", obeProyecto.PNNRITOC)
            objParam.Add("PSNRFRPD", obeProyecto.PSNRFRPD)
            objParam.Add("PNQCNTIT", obeProyecto.PNQCNTIT)
            objParam.Add("PNQCNRCP", obeProyecto.PNQCNRCP)
            objParam.Add("PSNTRMCR", obeProyecto.PSNTRMCR)
            objParam.Add("PSNTRMNL", obeProyecto.PSNTRMNL)
            objParam.Add("PSCUSCRT", obeProyecto.PSCUSCRT)
            objParam.Add("PSCULUSA", obeProyecto.PSCULUSA)
            objParam.Add("PSSESTRG", obeProyecto.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_INSERT_PROYECTO_DETALLE_OC_REGULARIZACION", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region


    Public Function ListaProyectos(ByVal obeProyecto As beProyecto) As beList(Of beProyecto)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_NORCML", obeProyecto.PSNORCML)
            objParam.Add("IN_NRITOC", obeProyecto.PNNRITOC)
            objParam.Add("IN_CCLNT", obeProyecto.PNCCLNT)
            Return Listar("SP_SOLMIN_SA_LISTA_PROYECTOS_X_MERCADERIA", objParam)
        Catch ex As Exception
            Return New List(Of beProyecto)
        End Try
    End Function


    Public Function ListaProyectosPorMovimiento(ByVal obeProyecto As beProyecto) As beList(Of beProyecto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_NORCML", obeProyecto.PNNORDSR)
        objParam.Add("IN_NRITOC", obeProyecto.PNNSLCSR)
        Return Listar("SP_SOLMIN_SA_PROYECTO_POR_SOLICITUD_SERVICIO", objParam)
        'Catch ex As Exception
        '    Return New List(Of beProyecto)
        'End Try
    End Function

    ''' <summary>
    ''' lista de proyectos por orden de servicio
    ''' </summary>
    ''' <param name="obeProyecto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flistProyectosXOs(ByVal obeProyecto As beProyecto) As beList(Of beProyecto)
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_NORDSR", obeProyecto.PNNORDSR)
        Return Listar("SP_SOLMIN_SA_SDS_LISTAR_PEDIDO_POR_OS", objParam)
        'Catch ex As Exception
        '    Return New List(Of beProyecto)
        'End Try
    End Function


    Public Function fintEliminarProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_NORCML", obeProyecto.PSNORCML.Trim)
            objParam.Add("IN_NRITOC", obeProyecto.PNNRITOC)
            objParam.Add("IN_CCLNT", obeProyecto.PNCCLNT)
            objParam.Add("IN_NRFRPD", obeProyecto.PSNRFRPD.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ELIMINAR_PROYECTOS_X_MERCADERIA", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function fintIngresarProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_CCLNT", obeProyecto.PNCCLNT)
                .Add("IN_NORCML", obeProyecto.PSNORCML)
                .Add("IN_NRITOC", obeProyecto.PNNRITOC)
                .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
                .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
                .Add("IN_USUARIO", obeProyecto.PSUSUARIO)
                .Add("IN_NTRMNL", obeProyecto.PSNTRMNL)
            End With
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PROYECTOS_REGISTRAR_INGRESO", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function fintSalidaProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_CCLNT", obeProyecto.PNCCLNT)
                .Add("IN_NORCML", obeProyecto.PSNORCML)
                .Add("IN_NRITOC", obeProyecto.PNNRITOC)
                .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
                .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
                .Add("IN_USUARIO", obeProyecto.PSUSUARIO)
                .Add("IN_NTRMNL", obeProyecto.PSNTRMNL)
            End With
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PROYECTOS_REGISTRAR_DESPACHO", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function



    Public Function fintAnularIngresoProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Dim retorno As Integer = 0
        'Try
        With objParam
            .Add("IN_CCLNT", obeProyecto.PNCCLNT)
            .Add("IN_NORCML", obeProyecto.PSNORCML)
            .Add("IN_NRITOC", obeProyecto.PNNRITOC)
            .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
            .Add("IN_NCRRDT", obeProyecto.PNNCRRDT)
            .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
            .Add("IN_STPING", obeProyecto.PSSTPING)
            .Add("IN_USUARIO", obeProyecto.PSUSUARIO)
            .Add("IN_NTRMNL", obeProyecto.PSNTRMNL)
        End With
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_INGRESO_PROYECTO", objParam)
        retorno = 1
        Return retorno
        'Catch ex As Exception
        '    Return -1
        'End Try
    End Function


    Public Function fintRevertirIngresoProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_CCLNT", obeProyecto.PNCCLNT)
                .Add("IN_NORCML", obeProyecto.PSNORCML)
                .Add("IN_NRITOC", obeProyecto.PNNRITOC)
                .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
                .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
                .Add("IN_STPING", obeProyecto.PSSTPING)
                .Add("IN_USUARIO", obeProyecto.PSUSUARIO)
                .Add("IN_NTRMNL", obeProyecto.PSNTRMNL)
            End With
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_INGRESO_PROYECTO", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function


    Public Function fintAnularSalidaProyecto(ByVal obeProyecto As beProyecto) As Integer
        Dim objParam As New Parameter
        Dim retorno As Integer = 0
        'Try
        With objParam
            .Add("IN_CCLNT", obeProyecto.PNCCLNT)
            .Add("IN_NORCML", obeProyecto.PSNORCML)
            .Add("IN_NRITOC", obeProyecto.PNNRITOC)
            .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
            .Add("IN_NCRRDT", obeProyecto.PNNCRRDT)
            .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
            .Add("IN_USUARIO", obeProyecto.PSUSUARIO)
            .Add("IN_NTRMNL", obeProyecto.PSNTRMNL)
        End With
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_DESPACHO_PROYECTO", objParam)
        retorno = 1
        Return retorno
        'Return 1
        'Catch ex As Exception
        '    Return -1
        'End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beProyecto)

    End Sub
End Class
