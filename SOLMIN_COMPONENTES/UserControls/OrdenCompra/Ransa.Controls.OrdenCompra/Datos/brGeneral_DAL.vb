Imports Ransa.TypeDef
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class brGeneral_DAL

    Inherits daBase(Of beGeneral)

    Private objSql As New SqlManager
    Public Function ListaLotesDeEntrega(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeGeneral.PNCCLNT)  'CLIENTE
        objParam.Add("PSNLTECL", obeGeneral.PSNLTECL.Trim) 'COD LOTE
        Return Listar("SP_SOLMIN_SA_LISTA_LOTE", objParam)
        'Catch ex As Exception
        '    Return New List(Of beGeneral)
        'End Try
    End Function

    Public Function ListaTablaAyuda(ByVal obeParam As beGeneral) As List(Of beGeneral)

        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        Dim oLisbeGeneral As New List(Of beGeneral)
        Dim obegeneral As beGeneral
        'Try
        lobjParams.Add("PSCODVAR", obeParam.PSCODVAR)
        lobjParams.Add("PSCCMPRN", obeParam.PSCCMPRN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)

        For Each Item As DataRow In dt.Rows
            obegeneral = New beGeneral
            obegeneral.PSCODVAR = ("" & Item("CODVAR")).ToString.Trim
            obegeneral.PSCCMPRN = ("" & Item("CCMPRN")).ToString.Trim
            obegeneral.PSTDSDES = ("" & Item("TDSDES")).ToString.Trim
            obegeneral.PSTDSDES2 = ("" & Item("TDSDE2")).ToString.Trim
            oLisbeGeneral.Add(obegeneral)
        Next
        Return oLisbeGeneral
        
    End Function

    Public Function ListaMedioTransporte(ByVal opbeGeneral As beGeneral) As List(Of beGeneral)
        Dim objParam As New Parameter

        If opbeGeneral.PNCMEDTR <> 0 Or Not opbeGeneral.PSTNMMDT.ToString.Trim.Equals("") Then
            objParam.Add("PNCMEDTR", opbeGeneral.PNCMEDTR)
            objParam.Add("PSTNMMDT", opbeGeneral.PSTNMMDT)
        End If
        Return Listar("SP_SOLMIN_LISTAR_MEDIO_TRANSPORTE", objParam)
     
    End Function

    Public Function LotesDeEntregaXCliente(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter

        objParam.Add("PSNLTECL", obeGeneral.PSNLTECL.Trim) 'COD LOTE
        Return Listar("SP_SOLMIN_SA_OBTENER_CLIENTE_X_LOTE", objParam)

    End Function

   

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(obj As beGeneral)

    End Sub
End Class
