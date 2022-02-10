Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daCargaRecepcion_CC
    Inherits daBase(Of beBulto)

    Private objSql As New SqlManager
    ''' <summary>
    ''' Listado de Carga Recepcionada X Centro de Costo
    ''' </summary>
    Public Function ListarCargaRecepcionada_CentroCosto(ByVal obeBulto As beBulto) As List(Of beBulto)
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("FE_INI", obeBulto.FECHA_INI)
            .Add("FE_FIN", obeBulto.FECHA_FIN)

            .Add("PSNORCML", obeBulto.PSNORCML)
            .Add("PSTLUGEN", obeBulto.PSTLUGEN.Trim)
            If obeBulto.PNESTADO = 0 Then
                .Add("PNESTADO", obeBulto.PNESTADO)
            End If

        End With
        Try
            Return Listar("SP_SOLMIN_SA_LISTA_CARGA_RECEPCIONADA_CENTRO_COSTO", objParametros)
        Catch ex As Exception
            Return New List(Of beBulto)
        End Try
    End Function
    '-------------------------
    Public Function Actualizar_Carga_Recepcionada_Centro_Costo(ByVal obeBulto As beBulto) As Int32
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCREFFW", obeBulto.PSCREFFW.Trim)
            .Add("PNCMEDTS", obeBulto.PNCMEDTS)
            .Add("PNCMEDTC", obeBulto.PNCMEDTC)
            .Add("PSTCTCST", ("" & obeBulto.PSTCTCST & "").Trim)
            .Add("PSTCTCSA", ("" & obeBulto.PSTCTCSA & "").Trim)
            .Add("PSTCTCSF", ("" & obeBulto.PSTCTCSF & "").Trim)
            .Add("PSTCTAFE", ("" & obeBulto.PSTCTAFE & "").Trim)
            .Add("PNFRQALC", obeBulto.PNFRQALC)
            .Add("PSCULUSA", obeBulto.PSUSUARIO)
        End With
        Try
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZA_CARGA_RECEPCIONADA_CENTRO_COSTO", objParametros)
        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function
    ''' <summary>
    '''   Actualiza de Cuentas de Imputacion
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Actualizar_CuentasImputacion(ByVal obeBulto As beBulto) As Int32
        Dim dtTemp As New DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PSCCMPN", obeBulto.PSCCMPN)
            .Add("PSCDVSN", obeBulto.PSCDVSN)
            .Add("PNCPLNDV", obeBulto.PNCPLNDV)
            .Add("PNCCLNT", obeBulto.PNCCLNT)
            .Add("PSCREFFW", obeBulto.PSCREFFW.Trim)
            .Add("PSTCTCST", ("" & obeBulto.PSTCTCST & "").Trim)
            .Add("PSTCTCSA", ("" & obeBulto.PSTCTCSA & "").Trim)
            .Add("PSTCTCSF", ("" & obeBulto.PSTCTCSF & "").Trim)
            .Add("PSTCTAFE", ("" & obeBulto.PSTCTAFE & "").Trim)
            .Add("PSCULUSA", obeBulto.PSUSUARIO)
        End With
        Try
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZA_CENTRO_COSTO_CARGA", objParametros)
        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function

    '''' <summary>
    '''' Elimina Bulto del predespacho
    '''' </summary>
    '''' <param name="obeBulto"></param>
    '''' <param name="strMensajeError"></param>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Function EliminarBultoPreDespachos(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As Boolean
    '    Dim objSqlManager As SqlManager = New SqlManager
    '    Dim objParametros As Parameter = New Parameter
    '    Dim blnResultado As Boolean = True
    '    strMensajeError = ""
    '    objSqlManager.TransactionController(TransactionType.Automatic)
    '    ' Ingresamos los parametros del Procedure
    '    With objParametros
    '        .Add("IN_CCLNT", obeBulto.PNCCLNT)
    '        .Add("PSCCMPN", obeBulto.PSCCMPN)
    '        .Add("PSCDVSN", obeBulto.PSCDVSN)
    '        .Add("PNCPLNDV", obeBulto.PNCPLNDV)
    '        .Add("IN_CREFFW", obeBulto.PSCREFFW)
    '        .Add("IN_USUARI", obeBulto.PSCUSCRT)
    '    End With

    '    Try
    '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL", objParametros)
    '    Catch ex As Exception
    '        strMensajeError = "Error producido en la funcion : << fblnEliminar_BultoPreDespachos >> de la clase << clsPreDespacho >> " & vbNewLine & _
    '                          "Tipo de Consulta : SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL " & vbNewLine & _
    '                          "Motivo del Error : " & ex.Message
    '        blnResultado = False
    '    Finally
    '        objSqlManager = Nothing
    '        objParametros = Nothing
    '    End Try
    '    Return blnResultado
    'End Function
    '''' <summary>
    ''' Lista de Movimiento de Item de OC
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarMovimientoItemOrdenCompra(ByVal obeBulto As beBulto) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter

        Try
            With objParametros
                .Add("PNCCLNT", obeBulto.PNCCLNT)
                .Add("PSCCMPN", obeBulto.PSCCMPN)
                .Add("PSCDVSN", obeBulto.PSCDVSN)
                .Add("PNCPLNDV", obeBulto.PNCPLNDV)
                .Add("PSNORCML", obeBulto.PSNORCML)
                .Add("PNNRITOC", obeBulto.PNNRITOC)
            End With
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC", objParametros)
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function ListarGenerarEtiquetaBultoSAT(ByVal obeBulto As beBulto, ByRef strMensajeError As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As Parameter = New Parameter
        Dim blnResultado As Boolean = True
        strMensajeError = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParam.Add("IN_CCLNT", obeBulto.PNCCLNT)
        objParam.Add("IN_CREFFW", obeBulto.PSCREFFW)
        objParam.Add("PSCCMPN", obeBulto.PSCCMPN)
        objParam.Add("PSCDVSN", obeBulto.PSCDVSN)
        objParam.Add("PNCPLNDV", obeBulto.PNCPLNDV)
        Dim dtTemp As DataTable
        Try
            dtTemp = objSql.ExecuteDataTable("SP_SOLMIN_SA_AT_LISTA_GENERAR_ETIQUETA_BULTO", objParam)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnConsultaInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & "" & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            dtTemp = New DataTable
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
        Return dtTemp
    End Function
    '------------FIN SIN USAR--------------
    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beBulto)

    End Sub

End Class
