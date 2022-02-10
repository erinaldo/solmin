Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF


Public Class daGeneral

    Inherits daBase(Of beGeneral)

    Public Function ListaMedioTransporte(ByVal opbeGeneral As beGeneral) As List(Of beGeneral)
        Dim objParam As New Parameter
        Try
            If opbeGeneral.PNCMEDTR <> 0 Or Not opbeGeneral.PSTNMMDT.ToString.Trim.Equals("") Then
                objParam.Add("PNCMEDTR", opbeGeneral.PNCMEDTR)
                objParam.Add("PSTNMMDT", opbeGeneral.PSTNMMDT)
            End If
            Return Listar("SP_SOLMIN_LISTAR_MEDIO_TRANSPORTE", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaTieck(ByVal opbeGeneral As beGeneral) As List(Of beGeneral)
        Dim objParam As New Parameter
        Try
            If opbeGeneral.PNCMEDTR <> 0 Or Not opbeGeneral.PSTNMMDT.ToString.Trim.Equals("") Then
                objParam.Add("PNCMEDTR", opbeGeneral.PNCMEDTR)
                objParam.Add("PSTNMMDT", opbeGeneral.PSTNMMDT)
            End If
            Return Listar("SP_SOLMIN_SA_SAT_LISTA_TICKED", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try


    End Function


    Public Function ListaTicked(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter

        Try
            objParam.Add("PNNTCKPS", obeGeneral.PNNTCKPS) 'tiched
            objParam.Add("PNFBLNIN", obeGeneral.PNFBLNIN) 'fecha
            objParam.Add("PSNPLCCM", obeGeneral.PSNPLCCM) 'placa
            objParam.Add("PSNBRVCH", obeGeneral.PSNBRVCH) 'brevete
            Return Listar("SP_SOLMIN_SA_SAT_LISTA_TICKED", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try

    End Function

    Public Function DtListaTicked(ByVal obeGeneral As beGeneral) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As New Parameter
        Try


            objParam.Add("PNNTCKPS", obeGeneral.PNNTCKPS) 'tiched
            objParam.Add("PNFBLNIN", obeGeneral.PNFBLNIN) 'fecha
            objParam.Add("PSNPLCCM", obeGeneral.PSNPLCCM) 'placa
            objParam.Add("PSNBRVCH", obeGeneral.PSNBRVCH) 'brevete



            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_LISTA_TICKED", objParam)
        Catch ex As Exception

            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
    End Function


    Public Function ListaLotesDeEntrega(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeGeneral.PNCCLNT)  'CLIENTE
            objParam.Add("PSNLTECL", obeGeneral.PSNLTECL.Trim) 'COD LOTE
            Return Listar("SP_SOLMIN_SA_LISTA_LOTE", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function LotesDeEntregaXCliente(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSNLTECL", obeGeneral.PSNLTECL.Trim) 'COD LOTE
            Return Listar("SP_SOLMIN_SA_OBTENER_CLIENTE_X_LOTE", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaDePlanta() As List(Of beGeneral)
        Dim oDt As New DataTable
        Dim olbebeGeneral As New List(Of beGeneral)
        Dim objParam As New Parameter
        Try
            Return Listar("SP_SOLMIN_SA_LISTA_PLANTA", objParam)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function
    '
    Public Function Lista_Planta_X_Usuario(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCCMPN", obeParam.PSCCMPN)
            lobjParams.Add("PSCDVSN", obeParam.PSCDVSN)
            lobjParams.Add("PSUSER", obeParam.PSUSUARIO)
            Return Listar("SP_SOLMIN_SA_LISTA_PLANTA_X_USUARIO", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

   
    Public Sub BuscarCodigoPais(ByRef obeParam As beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSTCMPPS", obeParam.PSTCMPPS)
            lobjParams.Add("PNCPAIS", 0, ParameterDirection.InputOutput)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_BUSCAR_CODIGO_PAIS", lobjParams)
            obeParam.PNCPAIS = Val(objSql.ParameterCollection("PNCPAIS"))
        Catch ex As Exception
            obeParam.PSERROR = "Error"
        End Try
    End Sub

    Public Function ListaUnidadDeMedida(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSSTPOUN", obeParam.PSSTPOUN)
            lobjParams.Add("PSCUNDMD", obeParam.PSCUNDMD)
            lobjParams.Add("PSTCMPUN", obeParam.PSTCMPUN)
            Return Listar("SP_SOLMIN_SA_UNIDAD_DE_MEDIDA_LISTAR", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

  
    ''' <summary>
    ''' Lista Tabla Ayuda
    ''' </summary>
    ''' <param name="obeParam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaTablaAyuda(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSCODVAR", obeParam.PSCODVAR)
            lobjParams.Add("PSCCMPRN", obeParam.PSCCMPRN)
            Return Listar("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function



    ''' <summary>
    ''' Lista Tabla Ayuda
    ''' </summary>
    ''' <param name="obeParam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function floListaTipoMovimientoCliente(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", obeParam.PNCCLNT)
            lobjParams.Add("PNCSRVC", obeParam.PNCSRVC)
            Return Listar("SP_SOLMIN_SA_LISTA_TIPO_MOVIMIENTO_X_CLIENTE", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    ''' <summary>
    ''' Esta funcion permite validada que el cliente tenga contrato
    ''' </summary>
    ''' <param name="obeParam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fIntValidarClienteContrato(ByVal obeParam As beGeneral) As Integer
        Dim lobjParams As New Parameter
        Try

            lobjParams.Add("PNCCLNT", obeParam.PNCCLNT)
            lobjParams.Add("PSCCMPN", obeParam.PSCCMPN)
            lobjParams.Add("QCONTRATO", 0, ParameterDirection.Output)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_VALIDAR_CLIENTE_CONTRATO", lobjParams)
            Return Val(objSql.ParameterCollection.Item("QCONTRATO"))
        Catch ex As Exception
            Return -1
        End Try
    End Function




    Public Function floListaMovimientoGuiaRemisionCliente(ByVal pIntCliente As Integer) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", pIntCliente)
            Return Listar("SP_SOLMIN_SA_LISTA_MOVIMIENTO_DESPACHO_X_CLIENTE", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaTablaTipoDocumento() As List(Of beGeneral)
        'Dim lobjParams As New Parameter
        Try
            Return Listar("SP_SOLMIN_SA_LISTA_TABLA_TIPO_DOCUMENTO", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function
    Public Function ListaTipoMovimiento() As List(Of beGeneral)
        'Dim lobjParams As New Parameter
        Try
            Return Listar("SP_SOLMIN_LISTA_TIPO_MOVIMIENTO", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaTipoMovimientoMarcaE() As List(Of beGeneral)
        Try
            Return Listar("SP_SOLMIN_LISTA_TIPO_MOVIMIENTO_E", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function


    Public Function ListaTipoBulto() As List(Of beGeneral)
        'Dim LstGe As New List(Of beGeneral)
        Try
            Return Listar("SP_SOLMIN_LISTA_TIPO_BULTO", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaMotivoRecepcion() As List(Of beGeneral)
        Try

            Return Listar("SP_SOLMIN_LISTA_MOTIVO_RECEPCION", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaSentidoCarga() As List(Of beGeneral)
        Try
            Return Listar("SP_SOLMIN_LISTA_SENTIDO_CARGA", Nothing)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaSentidoCargaTotal() As List(Of beGeneral)
        Try
            Dim oLista As New List(Of beGeneral)

            oLista = Listar("SP_SOLMIN_LISTA_SENTIDOS_CARGA", Nothing)
            'Dim objBeGeneral As New beGeneral
            'objBeGeneral.PSCCMPRN = 0
            'objBeGeneral.PSTDSDES = "TODOS"
            'oLista.Insert(0, objBeGeneral)
            Return oLista
        Catch ex As Exception
            Return New List(Of beGeneral)

        End Try
    End Function

    Public Function ListaTablaAgenteAduana(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSNTRMNL", obeParam.PSNTRMNL)
            Return Listar("SP_SOLMIN_SA_LISTA_AGENTE_ADUANA", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function

    Public Function ListaMoneda() As List(Of beGeneral)
        Dim lobjParams As New Parameter
        Try
            Return Listar("SP_SOLMIN_MONEDA_LIST", lobjParams)
        Catch ex As Exception
            Return New List(Of beGeneral)
        End Try
    End Function


    Private objSql As New SqlManager

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As beGeneral)

    End Sub
End Class
