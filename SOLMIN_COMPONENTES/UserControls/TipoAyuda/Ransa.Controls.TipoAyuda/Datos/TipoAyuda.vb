Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.TipoAyuda

Public Class cTipoAyuda
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' Obtener el Tipo de Ayuda de la Tabla de Ayuda - RZO103
    ''' </summary>
    Public Shared Function Obtener(ByVal objSqlManager As SqlManager, ByVal strCategoria As String, ByVal strCodigo As String, _
                                   ByRef strMensajeError As String) As TD_TipoAyuda
        Dim objTipoAyuda As TD_TipoAyuda = New TD_TipoAyuda
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_CODVAR", strCategoria)
        objParametros.Add("IN_CCMPRN", strCodigo)
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_TBLAYU_RZO103_OBJ", objParametros)
            If dtTemp.Rows.Count > 0 Then
                objTipoAyuda.pCCMPRN_Codigo = dtTemp.Rows(0).Item("CCMPRN")
                objTipoAyuda.pTDSDES_Detalle = dtTemp.Rows(0).Item("TDSDES")
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TBLAYU_RZO103_OBJ >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return objTipoAyuda
    End Function

    ''' <summary>
    ''' Listado información de la Tabla de Ayuda - RZO103
    ''' </summary>
    Public Shared Function fdtListar_TablaAyuda_L01(ByVal objSqlManager As SqlManager, ByVal strCategoria As String, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_CODVAR", strCategoria)
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_TBLAYU_RZO103_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_TablaAyuda_L01 >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_TBLAYU_RZO103_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
        End Try
        Return dtTemp
    End Function

    Public Shared Function ListarTablaAyuda(ByVal categoria As String) As DataTable
        Dim dtb As New DataTable
        Dim objSql As New SqlManager
        dtb = fdtListar_TablaAyuda_L01(objSql, categoria, "")
        Return dtb
    End Function

    Public Shared Function fdtListar_TablaAyuda_Filtro(ByVal objSqlManager As SqlManager, ByVal strCategoria As String, ByVal parametro As String) As DataTable
        Dim dtb As New DataTable
        dtb = fdtListar_TablaAyuda_L01(objSqlManager, strCategoria, "")
        Dim dw As DataView = dtb.DefaultView
        dw.RowFilter = "CCMPRN=" + parametro
        Return dw.ToTable()
    End Function

#End Region
End Class