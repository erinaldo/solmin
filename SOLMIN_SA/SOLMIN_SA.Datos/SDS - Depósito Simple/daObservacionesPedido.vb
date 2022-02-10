Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports RANSA.TYPEDEF

Public Class daObservacionesPedido
    Inherits daBase(Of beObservacionPedido)

    Dim objSql As New SqlManager

    Public Function Registro_Observaciones(ByVal objLista As List(Of String)) As Boolean
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter
            objParameter.Add("PARAM_CDPEPL", objLista(0))
            objParameter.Add("PARAM_CDREGP", objLista(1))
            objParameter.Add("PARAM_NCRRLT", objLista(2))
            objParameter.Add("PARAM_TOBSGS", objLista(3))
            objParameter.Add("PARAM_FULTAC", objLista(4))
            objParameter.Add("PARAM_HULTAC", objLista(5))
            objParameter.Add("PARAM_CULUSA", objLista(6))
            objParameter.Add("PARAM_SESTRG", objLista(7))
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRAR_OBSERVACION_RECEPCION", objParameter)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function Modificar_Observaciones(ByVal objLista As List(Of String)) As Boolean
        Dim lbool_resultado As Boolean = False
        Try

            Dim objParameter As New Parameter
            objParameter.Add("PARAM_CDPEPL", objLista(0))
            objParameter.Add("PARAM_CDREGP", objLista(1))
            objParameter.Add("PARAM_NCRRLT", objLista(2))
            objParameter.Add("PARAM_TOBSGS", objLista(3))
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MODIFICAR_OBSERVACION_RECEPCION", objParameter)
            lbool_resultado = True
        Catch ex As Exception
            lbool_resultado = False
        End Try
        Return lbool_resultado
    End Function

    Public Function Listado_Observaciones(ByVal obeFiltro As beObservacionPedido) As List(Of beObservacionPedido)
    Dim objDatatable As New DataTable
    Dim obeObservacionPedido As beObservacionPedido
    Dim lsbeObservacionPedido As New List(Of beObservacionPedido)

    Try
      Dim objParam As New Parameter
      objParam.Add("PARAM_CDPEPL", obeFiltro.PNCDPEPL)
      objParam.Add("PARAM_CDREGP", obeFiltro.PNCDREGP)
      lsbeObservacionPedido = Listar("SP_SOLMIN_SA_LISTAR_OBSERVACIONES_RECEPCION_X_ITEM", objParam)

      For Each obeObservacionPedido In lsbeObservacionPedido
        obeObservacionPedido.PSTOBSGS = obeObservacionPedido.PSTOBSGS.ToString.Trim
      Next

      Return lsbeObservacionPedido
    Catch ex As Exception
      Return New List(Of beObservacionPedido)
    End Try
    End Function


    Public Function Listado_Observaciones_General(ByVal obeFiltro As beObservacionPedido) As List(Of beObservacionPedido)
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CDPEPL", obeFiltro.PNCDPEPL)
            Return Listar("SP_SOLMIN_SA_LISTAR_OBSERVACIONES_RECEPCION", objParam)
        Catch ex As Exception
            Return New List(Of beObservacionPedido)
        End Try
    End Function

    Public Function fintEliminar_Observaciones_Pedido(ByVal obeFiltro As beObservacionPedido) As Integer
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CDPEPL", obeFiltro.PNCDPEPL)
            objParam.Add("PARAM_CDREGP", obeFiltro.PNCDREGP)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ELIMINAR_OBSERVACION_PEDIDO", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function fintRegistrarObeservaciones(ByVal obeFiltro As beObservacionPedido) As Integer
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CDPEPL", obeFiltro.PNCDPEPL)
            objParam.Add("PARAM_CDREGP", obeFiltro.PNCDREGP)
            objParam.Add("PARAM_TOBSGS", obeFiltro.PSTOBSGS)
            objParam.Add("PARAM_CULUSA", obeFiltro.PSUSUARIO)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRAR_OBSERVACION_PEDIDO", objParam)
            Return 1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beObservacionPedido)

    End Sub

End Class
