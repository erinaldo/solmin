Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.TipoAyuda
Public Class TipoAyuda_DAL
    Public Function fdtListar_TablaAyuda_L01(ByVal strCategoria As String, ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objSqlManager As New SqlManager
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
    Public Function fdtListar_TablaAyuda_Filtro(ByVal strCategoria As String, ByVal parametro As String) As DataTable
        Dim dtb As New DataTable
        dtb = Me.fdtListar_TablaAyuda_L01(strCategoria, "")
        Dim dw As DataView = dtb.DefaultView
        dw.RowFilter = "CCMPRN=" + parametro
        Return dw.ToTable()
    End Function
End Class
