Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class brGeneral
    Private odaGeneral As New daGeneral
    Public Function ListaMedioTransporte(ByVal opbeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().ListaMedioTransporte(opbeGeneral)
    End Function
    Public Function ListaLotesDeEntrega(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().ListaLotesDeEntrega(obeGeneral)
    End Function
    Public Function LotesDeEntregaXCliente(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().LotesDeEntregaXCliente(obeGeneral)
    End Function
    Public Function ListaTicked(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().ListaTicked(obeGeneral)
    End Function
    Public Function ListaDePlanta() As List(Of beGeneral)
        Return New daGeneral().ListaDePlanta()
    End Function
    Public Function Lista_Planta_X_Usuario(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().Lista_Planta_X_Usuario(obeGeneral)
    End Function

    Public Sub BuscarCodigoPais(ByRef obeGeneral As beGeneral)
        odaGeneral.BuscarCodigoPais(obeGeneral)
    End Sub
   
    Public Function DtListaTicked(ByVal obeGeneral As beGeneral) As DataTable
        Return New daGeneral().DtListaTicked(obeGeneral)
    End Function

    Public Function ListaUnidadDeMedida(ByVal obeGeneral As beGeneral) As List(Of beGeneral)
        Return New daGeneral().ListaUnidadDeMedida(obeGeneral)
    End Function

    Public Function ListaTablaAyuda(ByVal obeParam As beGeneral) As List(Of beGeneral)
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    ''' <summary>
    ''' Retorna el equivalente de tipo movimiento Recepcion Ransa Outotec
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olEquivalenteOutotecTipoMovimientoRec(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "EOTMOV"
        obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    ''' <summary>
    ''' Retorna el equivalente de tipo movimiento Recepcion Ransa Outotec
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olEquivalenteOutotecTipoMovimientoDes(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "EOTMDS"
        obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function


    ''' <summary>
    ''' Valida que el tipo Mov Ing. es devolucion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fbolTipoIngEsDevolucion(ByVal strTipoMov As String) As Boolean
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TPMDEV"
        obeParam.PSCCMPRN = strTipoMov
        If New daGeneral().ListaTablaAyuda(obeParam).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function bolElClienteEsOutotec(ByVal intCCLNT As Integer) As Boolean
        Dim obeParam As New beGeneral
        Dim odaGeneral As New daGeneral
        obeParam.PSCODVAR = "CLIOUT"
        obeParam.PSCCMPRN = intCCLNT.ToString
        If odaGeneral.ListaTablaAyuda(obeParam).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function bolEsClienteRegistradoEnProceso(ByVal Codvar As String, ByVal intCCLNT As Decimal) As Boolean
        Dim obeParam As New beGeneral
        Dim odaGeneral As New daGeneral
        obeParam.PSCODVAR = Codvar  '"CLIABB"
        obeParam.PSCCMPRN = intCCLNT.ToString
        If odaGeneral.ListaTablaAyuda(obeParam).Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function



    ''' <summary>
    ''' Valida que el cliente tenga contrato
    ''' </summary>
    ''' <param name="obeParam"></param>
    ''' <param name="strError"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fbolValidarClienteContrato(ByVal obeParam As beGeneral, ByRef strError As String) As Boolean
        Dim Contratos As Decimal = 0
        Dim odaGeneral As New daGeneral
        Contratos = odaGeneral.fIntValidarClienteContrato(obeParam)

        Select Case Contratos
            'Case -1
            '    strError = "La operación no pudo completarse, Notifique este evento al Dpto. de Sistemas."
            '    Return False
            Case 0
                'strError = "El cliente no posee contrato comuníquese con el departamento de Administración."
                strError = "El cliente no posee contrato (Administración) . "
                Return False
            Case Else
                strError = ""
                Return True
        End Select
    End Function

     
    ''' <summary>
    ''' Tipo de movimiento de ingreso
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function floListaTipoMovimientoRecepcionCliente(ByVal intCliente As Integer) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PNCSRVC = 1
        obeParam.PNCCLNT = intCliente
        Return New daGeneral().floListaTipoMovimientoCliente(obeParam)
    End Function


    ''' <summary>
    ''' Tipo de movimiento de Despacho
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function floListaTipoMovimientoDespachoCliente(ByVal intCliente As Integer) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        Dim oList As New List(Of beGeneral)
        obeParam.PNCSRVC = 2
        obeParam.PNCCLNT = intCliente
        oList = New daGeneral().floListaTipoMovimientoCliente(obeParam)
        Return oList
    End Function

    ''' <summary>
    ''' Tipo de movimiento de ingreso
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function floListaMovimientoGuiaRemisionCliente(ByVal intCliente As Integer) As List(Of beGeneral)
        Return New daGeneral().floListaMovimientoGuiaRemisionCliente(intCliente)
    End Function


    Public Function olEquivalenteOutotecMotivoDespacho(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "EOTMDG"
        obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function
    ''' <summary>
    ''' Tipo documento Origen, esto puede ser GR, Factura, etc.
    ''' </summary>
    ''' <param name="strTipoMov"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olTipoDocumentoOrigen(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TIPORI"
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    ''' <summary>
    ''' Proveedor o cliente de procedencia 
    ''' </summary>
    ''' <param name="strTipoMov"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olTipoOrigen(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TIPORG"
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    ''' <summary>
    ''' Tipo de Orden de Compra
    ''' </summary>
    ''' <param name="strTipoMov"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olTipoOC(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TIPOC"

        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function


    ''' <summary>
    ''' Tipo Documento
    ''' </summary>
    ''' <param name="strTipoMovDoc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olTipoDocumento() As List(Of beGeneral)
        Dim obeParam As New beGeneral
        'obeParam.PSCODVAR = "TIPORG"
        Return New daGeneral().ListaTablaTipoDocumento()
    End Function

    ''' <summary>
    ''' Tipo Movimiento
    ''' </summary>
    ''' <param name="strTipoMo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function olTipoMovimiento() As List(Of beGeneral)
    '    Dim obeParam As New beGeneral
    '    Return New daGeneral().ListaTipoMovimiento()
    'End Function

    Public Function olTipoMovimiento(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "TIPMOV"
        obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    Public Function olTipoMovimientoMarcaE() As List(Of beGeneral)
        'Dim obeParam As New beGeneral
        'obeParam.PSCODVAR = "TIPMOV"
        'obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTipoMovimientoMarcaE()
    End Function

    Public Function olTipoBulto() As List(Of beGeneral)
        Dim obeParam As New beGeneral
        Return New daGeneral().ListaTipoBulto()
    End Function

    Public Function olMotivoRecepcion(ByVal strMotRec As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "MOTREC"
        'obeParam.PSCCMPRN = strTipoMov
        'Return New daGeneral().ListaMotivoRecepcion()
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    Public Function olSentidoCarga() As List(Of beGeneral)
        Dim obeParam As New beGeneral
        Return New daGeneral().ListaSentidoCarga()
    End Function

    Public Function olSentidoCargaTotal() As List(Of beGeneral)
        Dim obeParam As New beGeneral
        Return New daGeneral().ListaSentidoCargaTotal()
    End Function
    ''' <summary>
    ''' Agente Aduana
    ''' </summary>
    ''' <param name="strAgenteAdu"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olAgenteAduana(ByVal strAgenteAdu As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSTCMAA = strAgenteAdu
        Return New daGeneral().ListaTablaAgenteAduana(obeParam)
    End Function

    Public Function fstrAlmacenVituralOutotec(ByVal dblCliente As Int64, ByVal strAlmacen As String) As String
        Try
            Dim obeParam As New beGeneral
            obeParam.PSCODVAR = dblCliente.ToString
            obeParam.PSCCMPRN = strAlmacen
            Return New daGeneral().ListaTablaAyuda(obeParam).Item(0).PSTDSDES.Trim
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function ListaMoneda() As List(Of beGeneral)
        Return New daGeneral().ListaMoneda()
    End Function
    Public Function olLugarOrigen(ByVal strTipoMov As String) As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "FLGPEN"
        obeParam.PSCCMPRN = strTipoMov
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function

    Public Function olistTipoOC() As DataTable
        Dim oDt As New DataTable
        oDt.Columns.Add("ID")
        oDt.Columns.Add("DESC")
        Dim odr As DataRow

       

        odr = oDt.NewRow()
        odr.Item("ID") = "LOC"
        odr.Item("DESC") = "LOCAL"
        oDt.Rows.Add(odr)

        odr = oDt.NewRow()
        odr.Item("ID") = "IMP"
        odr.Item("DESC") = "IMPORTACIÓN"
        oDt.Rows.Add(odr)

        odr = oDt.NewRow()
        odr.Item("ID") = "OTR"
        odr.Item("DESC") = "OTROS"
        oDt.Rows.Add(odr)

        Return oDt
    End Function


    ''' <summary>
    ''' Lista de Tarifa apara Perenco
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function olstListaTarifa() As List(Of beGeneral)
        Dim obeParam As New beGeneral
        obeParam.PSCODVAR = "CLSTRF"
        Return New daGeneral().ListaTablaAyuda(obeParam)
    End Function



    Public Function flstListaColores() As List(Of beGeneral)
        Return New daGeneral().flstListaColores()
    End Function

    Public Function fIntValidarEnvioABB(ByVal strOC As String) As Integer
        Return New daGeneral().fIntValidarEnvioABB(strOC)
    End Function
End Class

