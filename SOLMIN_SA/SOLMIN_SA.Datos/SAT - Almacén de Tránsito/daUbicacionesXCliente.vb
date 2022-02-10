Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario

Public Class daUbicacionesXCliente
    Inherits daBase(Of beGeneral)

    Private objSql As New SqlManager

    Function Lista_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String) As DataTable
        Dim dt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", cliente)
        objParam.Add("PSTUBRFR", ubicacion)

        Return objSql.ExecuteDataTable("SP_SOLMIN_SA_UBICACIONES_X_CLIENTE", objParam)
    End Function

    Function folistUbicacionXCliente(ByVal strCodCliente As String) As List(Of beGeneral)
        Dim dt As New DataTable
        Dim objSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PSCCLNT", strCodCliente)
        objParam.Add("PSTUBRFR", "")

        Return Listar("SP_SOLMIN_SA_UBICACIONES_X_CLIENTE", objParam)
    End Function



    Function Insert_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String, ByVal usuario As String) As Int32

        Dim respuesta As Int32 = 0
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", cliente)
        objParam.Add("PSTUBRFR", ubicacion)
        objParam.Add("PSCUSCRT", usuario)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_UBICACIONES_X_CLIENTE_INSERT", objParam)
        respuesta = objSql.ParameterCollection("PSRESULT")
        Return respuesta

    End Function

    Function Update_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String, ByVal anterior As String, ByVal usuario As String, ByVal Estado As String) As Boolean

        Dim respuesta As Boolean = False
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", cliente)
        objParam.Add("PSTUBRFR", ubicacion)
        objParam.Add("ANTERIOR", anterior)
        objParam.Add("PSCUSCRT", usuario)
        objParam.Add("PSSESTRG", Estado)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_UBICACIONES_X_CLIENTE_UPDATE", objParam)
        respuesta = True

        Return respuesta

    End Function

    Function Delete_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String) As Int32

        Dim respuesta As Int32 = 0
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", cliente)
        objParam.Add("PSTUBRFR", ubicacion)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_UBICACIONES_X_CLIENTE_DELETE", objParam)
        respuesta = objSql.ParameterCollection("PSRESULT")
        Return respuesta

    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beGeneral)

    End Sub
End Class
