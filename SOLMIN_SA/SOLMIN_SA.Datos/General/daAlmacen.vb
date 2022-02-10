Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daAlmacen
    Inherits daBase(Of beAlmacen)

    Private objSql As New SqlManager


    ''' <summary>
    ''' Retorna Tipo de Almacen de acuerdo al código enviado
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TipoDeAlmacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
            Return Listar("SP_SOLMIN_SA_TIPO_ALMACEN", objParam).Item(0)
        Catch ex As Exception
            Return New beAlmacen
        End Try
    End Function

    Public Function ListaTipoDeAlmacen() As List(Of beAlmacen)
        Dim objParam As New Parameter
        'Try
        Return Listar("SP_SOLMIN_SA_LISTA_TIPO_ALMACEN", objParam)
        'Catch ex As Exception
        '    Return New List(Of beAlmacen)
        'End Try
    End Function


    ''' <summary>
    ''' Retorna Almacen de acuerdo al código enviado
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Almacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
            objParam.Add("PSCALMC", obeAlmacen.PSCALMC)
            Return Listar("SP_SOLMIN_SA_ALMACEN", objParam).Item(0)
        Catch ex As Exception
            Return New beAlmacen
        End Try
    End Function

    Public Function ListaAlmacen(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCPLNFC", obeAlmacen.PNCPLNFC)
        objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
        Return Listar("SP_SOLMIN_SA_LISTA_ALMACEN", objParam)
        'Catch ex As Exception
        '    Return New List(Of beAlmacen)
        'End Try
    End Function





    ''' <summary>
    ''' Zonas de almacen por Tipo de almacen  y almacen
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ZonaDeAlmacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
            objParam.Add("PSCALMC", obeAlmacen.PSCALMC)
            objParam.Add("PSCZNALM", obeAlmacen.PSCZNALM)
            Return Listar("SP_SOLMIN_SA_ZONA_ALMACEN", objParam).Item(0)
        Catch ex As Exception
            Return New beAlmacen
        End Try
    End Function

    Public Function ListaZonaDeAlmacen(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
        objParam.Add("PSCALMC", obeAlmacen.PSCALMC)
        Return Listar("SP_SOLMIN_SA_LISTA_ZONA_ALMACEN", objParam)
        'Catch ex As Exception
        '    Return New List(Of beAlmacen)
        'End Try
    End Function




    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beAlmacen)

    End Sub


    'Miguel  31.01.2014

    Public Function TipoDeMaterial(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Dim objParam As New Parameter
        Try
            objParam.Add("CODVAR", obeAlmacen.PSCODVAR)
            objParam.Add("CCMPRN", obeAlmacen.PSCCMPRN)

            Return Listar("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", objParam)
        Catch ex As Exception
            Return New List(Of beAlmacen)
        End Try
    End Function

    Public Function Listar_Almacen_x_Tipo(ByVal obeAlmacen As beAlmacen) As DataTable
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PNCPLNFC", obeAlmacen.PNCPLNFC)
        objParam.Add("PSCTPALM", obeAlmacen.PSCTPALM)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_ALMACEN_X_TIPO", objParam)
        Return dt
    End Function


End Class