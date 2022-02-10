Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class daSerieMercaderia
    'Inherits daBase(Of RANSA.TYPEDEF.beSerie)
    Inherits daBase(Of RANSA.Controls.Serie.beSerie)


    Public Function RegistrarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As RANSA.Controls.Serie.beSerie

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", obeSerie.PNNORDSR)
            objParam.Add("PSCSRECL", obeSerie.PSCSRECL)
            objParam.Add("PNCCLNT", obeSerie.PNCCLNT)
            objParam.Add("PSTDSMDL", obeSerie.PSTDSMDL)
            objParam.Add("PSTOBSRV", obeSerie.PSTOBSRV)
            objParam.Add("PSCUSCRT", obeSerie.PSCUSCRT)
            objParam.Add("CREACION", "", ParameterDirection.Output)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_SDS_INSERTAR_SERIES_MANTENIMIENTO", objParam)
            obeSerie.CREACION = objSqlManager.ParameterCollection("CREACION").ToString
        Catch ex As Exception
            obeSerie.CREACION = "FALSE"
        End Try
        Return obeSerie
    End Function

    'Public Function ActualizarSerie(ByVal obeSerie As TypeDef.beSerie) As TypeDef.beSerie
    Public Function ActualizarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As RANSA.Controls.Serie.beSerie

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", obeSerie.PNNORDSR)
            objParam.Add("PSCSRECL", obeSerie.PSCSRECL)
            objParam.Add("PSCSRECL_ANT", obeSerie.PSCSRECL_ANT)
            objParam.Add("PNNCRPLL", obeSerie.PNNCRPLL)
            objParam.Add("PNCCLNT", obeSerie.PNCCLNT)
            objParam.Add("PSTDSMDL", obeSerie.PSTDSMDL)
            objParam.Add("PSTOBSRV", obeSerie.PSTOBSRV)
            objParam.Add("PSCULUSA", obeSerie.PSCULUSA)
            objParam.Add("CREACION", "", ParameterDirection.Output)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_SDS_ACTUALIZAR_SERIES_MANTENIMIENTO", objParam)
            obeSerie.CREACION = objSqlManager.ParameterCollection("CREACION").ToString
        Catch ex As Exception
            obeSerie.CREACION = "FALSE"
        End Try
        Return obeSerie
    End Function
    'Public Function EliminarSerie(ByVal obeSerie As TYPEDEF.beSerie) As Int32
    Public Function EliminarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As Int32

        Dim objSqlManager As New SqlManager
        Dim retorno As Int32 = 0
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNORDSR", obeSerie.PNNORDSR)
            objParam.Add("PSCSRECL", obeSerie.PSCSRECL)
            objParam.Add("PNNCRPLL", obeSerie.PNNCRPLL)
            objParam.Add("PSCULUSA", obeSerie.PSCULUSA)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_SDS_ELIMINAR_SERIES_MANTENIMIENTO", objParam)
            retorno = 1
            Return retorno
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub



    'Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beSerie)

    'End Sub
    Public Overloads Overrides Sub ToParameters(ByVal obj As RANSA.Controls.Serie.beSerie)

    End Sub
End Class
