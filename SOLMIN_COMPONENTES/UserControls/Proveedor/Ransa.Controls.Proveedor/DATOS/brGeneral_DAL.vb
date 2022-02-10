Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class brGeneral_DAL
    Public Function ListaTablaAyuda(ByVal obeParam As Ransa.TypeDef.beGeneral) As List(Of Ransa.TypeDef.beGeneral)
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        Dim oLisbeGeneral As New List(Of Ransa.TypeDef.beGeneral)
        Dim obegeneral As Ransa.TypeDef.beGeneral
        'Try
        lobjParams.Add("PSCODVAR", obeParam.PSCODVAR)
        lobjParams.Add("PSCCMPRN", obeParam.PSCCMPRN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)

        For Each Item As DataRow In dt.Rows
            obegeneral = New Ransa.TypeDef.beGeneral
            obegeneral.PSCODVAR = ("" & Item("CODVAR")).ToString.Trim
            obegeneral.PSCCMPRN = ("" & Item("CCMPRN")).ToString.Trim
            obegeneral.PSTDSDES = ("" & Item("TDSDES")).ToString.Trim
            obegeneral.PSTDSDES2 = ("" & Item("TDSDE2")).ToString.Trim
            oLisbeGeneral.Add(obegeneral)
        Next
        Return oLisbeGeneral

    End Function



    Public Function ConsultaCodCliente(CodCliente As Decimal) As DataTable
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PNCCLNT", CodCliente)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_OBTENER_COD_CLIENTE", lobjParams)
        Return dt

    End Function


    Public Function RegistrarProveedorRelacion(obeProveedor As beProveedor) As String
        Dim objSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("IN_NRUCPR", obeProveedor.PNNRUCPR)
        lobjParams.Add("IN_TPRVCL", obeProveedor.PSTPRVCL)
        lobjParams.Add("IN_TDRPRC", obeProveedor.PSTDRPRC)
        lobjParams.Add("IN_CCLNT", obeProveedor.PNCCLNT)
        lobjParams.Add("IN_CODPROVCLIENTE", obeProveedor.PSCPRPCL)
        lobjParams.Add("IN_USUARI", Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_PROV_RZOL05_RELACION", lobjParams)
        Dim msg As String = ""
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(13)
            End If
        Next
        msg = msg.Trim
        Return msg
    End Function


 


End Class
