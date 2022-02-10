Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Imports System.Collections.Generic
Imports Newtonsoft
Imports Newtonsoft.Json

Public Class clsFactura
    Private oFacturaDato As SOLMIN_CTZ.DATOS.clsFactura
    Private oDtCabecera As DataTable
    Private dblTipoCambio As Double
    Private dblTipoCambioDocOrigen As Double
    Private strGiroNeg As String
    Private strPlantaCli As String
    Private strPtoVenta As String
    Private strCodTabla As String

    Public oDtDocumentos As DataTable
    Public oTipoDocumento As Decimal = 0
    Public oFlagSoloConsulta As String = ""

    Private ReadOnly objRegistroItemFactura As New List(Of Int32)()

    Public dtServiciosTodosOp As New DataTable

    Dim ListaFactor ' Copia valores de la lista ListaFact 'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16
    Public objTipoDetraccion As New Hashtable
    Public objMontoDetraccion As New Hashtable
    Public objValorOC_Cliente As New Hashtable

 

    Public CTPDCO As Decimal = 0


    Public NDCMOR As Decimal = 0



    Public FDCMOR As Decimal = 0





    Private intAccion As Integer
    Public Property AccionRefactura() As Integer
        Get
            Return intAccion
        End Get
        Set(ByVal value As Integer)
            intAccion = value
        End Set
    End Property


    Sub New()
        oFacturaDato = New SOLMIN_CTZ.DATOS.clsFactura
        oDtCabecera = New DataTable
    End Sub

    Property PlantaCliente()
        Get
            Return strPlantaCli
        End Get
        Set(ByVal value)
            strPlantaCli = value
        End Set
    End Property

    Property PuntoVenta()
        Get
            Return strPtoVenta
        End Get
        Set(ByVal value)
            strPtoVenta = value
        End Set
    End Property

    Property GiroNegocio()
        Get
            Return strGiroNeg
        End Get
        Set(ByVal value)
            strGiroNeg = value
        End Set
    End Property

    Property TipoCambio()
        Get
            Return dblTipoCambio
        End Get
        Set(ByVal value)
            dblTipoCambio = value
        End Set
    End Property

    Property TipoCambioDocOrigen()
        Get
            Return dblTipoCambioDocOrigen
        End Get
        Set(ByVal value)
            dblTipoCambioDocOrigen = value
        End Set
    End Property

    Public ReadOnly Property NroItemFactura() As List(Of Int32)
        Get
            Return objRegistroItemFactura
        End Get
    End Property

    Private _ListaoFact As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
    Public Property ListaoFact() As List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Get
            Return _ListaoFact
        End Get
        Set(ByVal value As List(Of SOLMIN_CTZ.Entidades.FacturaSIL))
            _ListaoFact = value
        End Set
    End Property

    Public Sub Llenar_Documentos(ByVal pobjFiltro As Filtro)
        oDtDocumentos = oFacturaDato.Lista_Documentos_Permitidos(pobjFiltro)
    End Sub


    Public Function Lista_Giro_Negocio(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Giro_Negocio(pobjFiltro)
    End Function




    Public Function Lista_Tipo_Cambio(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Tipo_Cambio(pobjFiltro)
    End Function

    Public Function Lista_Region_Venta(ByVal pobjFactura As FacturaSIL) As DataTable
        Return oFacturaDato.Lista_Region_Venta(pobjFactura)
    End Function


    Public Function Lista_Planta_Cliente(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Planta_Cliente(pobjFiltro)
    End Function


    Public Function Lista_Planta_Facturar(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Planta_Facturar(pobjFiltro)
    End Function


    Public Function Lista_Datos_Cliente(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Datos_Cliente(pobjFiltro)
    End Function

    Public Function Lista_Punto_Venta(ByVal pobjFiltro As Filtro) As DataTable
        Dim oDr() As DataRow
        Dim oDrNew As DataRow
        Dim oDt As DataTable
        Dim intCont As Integer

        oDr = oDtDocumentos.Select("CGRONG = '" & pobjFiltro.Parametro1 & "'")
        oDt = New DataTable
        oDt.Columns.Add(New DataColumn("NPTOVT", GetType(System.String)))
        oDt.Columns.Add(New DataColumn("TOBSAD", GetType(System.String)))
        For intCont = 0 To oDr.Length - 1
            oDrNew = oDt.NewRow
            oDrNew.Item("NPTOVT") = oDr(intCont).Item("NPTOVT").ToString.Trim
            oDrNew.Item("TOBSAD") = oDr(intCont).Item("NPTOVT").ToString.Trim
            oDt.Rows.Add(oDrNew)
        Next intCont

        Return oDt
    End Function



    Public Function Cantidad_Facturas_General(ParamFac As Hashtable, ByRef dtServicioFactura As DataTable) As Integer 'csr-hotfix/031116_Visualizacion_Formato_Factura

        Dim oDt As New DataTable
        Dim intCant As Integer = 0

        Dim oDtAux As New DataTable
        Dim oDr() As DataRow
        Dim strDetraccion, strIGV, strMoneda As String
        Dim dblMonto As Decimal = 0D

        Dim OCCliente As String = ""

        Dim CodCliente As Decimal = ParamFac("CCLNT")
        Dim ListadoCad As String = ParamFac("LISTADO")
        Dim TipoListadoCad As String = ParamFac("TIPO_LIST")
        Dim FechaFac As Decimal = ParamFac("FECHA_FACT")
        Dim EsRecupero As Boolean = ParamFac("ES_RECUPERO")


        objTipoDetraccion = New Hashtable
        objMontoDetraccion = New Hashtable
        objValorOC_Cliente = New Hashtable


        oDt = oFacturaDato.Lista_Detalle_ServiciosGeneral(EsRecupero, CodCliente, ListadoCad, TipoListadoCad, FechaFac)
        dtServicioFactura = oDt.Copy

        If oTipoDocumento = 51 Or oTipoDocumento = 52 Then
            While (1)
                If oDt.Rows.Count = 0 Then
                    Exit While
                End If
                intCant = intCant + 1

                dblMonto = oDt.Rows(0).Item("IAFCDT")
                strDetraccion = oDt.Rows(0).Item("IPRCDT").ToString.Trim
                strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
                strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
                OCCliente = oDt.Rows(0).Item("OCCLIENTE").ToString.Trim

                oDr = oDt.Select("IPRCDT <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR CMNDA1 <> " & strMoneda & " OR IAFCDT <>" & dblMonto)

                objTipoDetraccion.Add(intCant, oDt.Rows(0).Item("IPRCDT"))
                objMontoDetraccion.Add(intCant, oDt.Rows(0).Item("IAFCDT").ToString.Trim)
                objValorOC_Cliente.Add(intCant, OCCliente)

                If oDr.Length = 0 Then
                    Exit While
                Else
                    Eliminar_Rows_Detalles(oDt, strDetraccion, strIGV, strMoneda, dblMonto)
                End If
            End While

        End If



        If oTipoDocumento = 57 Or oTipoDocumento = 6 Then
            intCant = 1
        End If




        Return intCant
    End Function


    Public Function Cantidad_Facturas_General_PreDocumentos(ParamFac As Hashtable, ByRef dtServicioFactura As DataTable) As Integer 'csr-hotfix/031116_Visualizacion_Formato_Factura

        Dim oDt As New DataTable
        Dim intCant As Integer = 0

        Dim oDtAux As New DataTable
        Dim oDr() As DataRow
        Dim strDetraccion, strIGV, strMoneda As String
        Dim dblMonto As Decimal = 0D

        Dim OCCliente As String = ""
        Dim PDocumento As String = ""

        Dim CodCliente As Decimal = ParamFac("CCLNT")
        Dim NroPL As String = ParamFac("NRO_PL")
        Dim PreDocList As String = ParamFac("PREDOC_LIST")
        Dim FechaFac As Decimal = ParamFac("FECHA_FACT")


        objTipoDetraccion = New Hashtable
        objMontoDetraccion = New Hashtable
        objValorOC_Cliente = New Hashtable


        oDt = oFacturaDato.Lista_Detalle_ServiciosGeneral_PreDocumentos(CodCliente, NroPL, PreDocList, FechaFac)
        dtServicioFactura = oDt.Copy

        If oTipoDocumento = 51 Or oTipoDocumento = 52 Then
            While (1)
                If oDt.Rows.Count = 0 Then
                    Exit While
                End If
                intCant = intCant + 1

                dblMonto = oDt.Rows(0).Item("IAFCDT")
                strDetraccion = oDt.Rows(0).Item("IPRCDT").ToString.Trim
                strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
                strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
                OCCliente = oDt.Rows(0).Item("OCCLIENTE").ToString.Trim
                'csr-hotfix/031116_Visualizacion_Formato_Factura               
                PDocumento = oDt.Rows(0).Item("NPREDOC").ToString.Trim

                oDr = oDt.Select("IPRCDT <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR CMNDA1 <> " & strMoneda & " OR IAFCDT <>'" & dblMonto & "' OR NPREDOC = '" & PDocumento & "'")

                objTipoDetraccion.Add(intCant, oDt.Rows(0).Item("IPRCDT"))
                objMontoDetraccion.Add(intCant, oDt.Rows(0).Item("IAFCDT").ToString.Trim)
                objValorOC_Cliente.Add(intCant, OCCliente)



                'csr-hotfix/031116_Visualizacion_Formato_Factura
                If oDr.Length = 0 Then
                    Exit While
                Else

                    Eliminar_Rows_Detalles_PreDocumento(oDt, strDetraccion, strIGV, strMoneda, dblMonto, PDocumento)

                End If
            End While

        End If

        If oTipoDocumento = 57 Or oTipoDocumento = 6 Then
            intCant = 1
        End If

        Return intCant
    End Function





    Public Sub Eliminar_Rows_Detalles_DirServ(ByRef poDt As DataTable, ByVal pstrDetraccion As String, ByVal pstrIGV As String, ByVal pstrMoneda As String, ByVal dblMonto As Decimal, ByVal diServ As String)
        Dim intCont As Integer

        For intCont = poDt.Rows.Count - 1 To 0 Step -1

            If poDt.Rows(intCont).Item("IPRCDT").ToString.Trim = pstrDetraccion And poDt.Rows(intCont).Item("CTIGVA").ToString.Trim = pstrIGV And poDt.Rows(intCont).Item("CMNDA1").ToString.Trim = pstrMoneda And poDt.Rows(intCont).Item("IAFCDT") = dblMonto Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub




    Public Sub Eliminar_Rows_Detalles(ByRef poDt As DataTable, ByVal pstrDetraccion As String, ByVal pstrIGV As String, ByVal pstrMoneda As String, ByVal dblMonto As Decimal)
        Dim intCont As Integer

        For intCont = poDt.Rows.Count - 1 To 0 Step -1
            If poDt.Rows(intCont).Item("IPRCDT").ToString.Trim = pstrDetraccion And poDt.Rows(intCont).Item("CTIGVA").ToString.Trim = pstrIGV And poDt.Rows(intCont).Item("CMNDA1").ToString.Trim = pstrMoneda And poDt.Rows(intCont).Item("IAFCDT") = dblMonto Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub

    Public Sub Eliminar_Rows_Detalles_PreDocumento(ByRef poDt As DataTable, ByVal pstrDetraccion As String, ByVal pstrIGV As String, ByVal pstrMoneda As String, ByVal dblMonto As Decimal, ByVal PDocumento As String)
        Dim intCont As Integer

        For intCont = poDt.Rows.Count - 1 To 0 Step -1
            If poDt.Rows(intCont).Item("IPRCDT").ToString.Trim = pstrDetraccion And poDt.Rows(intCont).Item("CTIGVA").ToString.Trim = pstrIGV And poDt.Rows(intCont).Item("CMNDA1").ToString.Trim = pstrMoneda And poDt.Rows(intCont).Item("IAFCDT") = dblMonto And poDt.Rows(intCont).Item("NPREDOC").ToString.Trim = PDocumento Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub


    Public Function Lista_Cabecera_Factura(ByVal pobjFiltro As Filtro) As DataTable
        Dim oDtCliente As DataTable
        Dim oDtPlantaCliente As DataTable
        Dim oDtPlanta As DataTable
        Dim oDr As DataRow
        Dim intCont As Integer

        Dim objFiltro As New Hashtable



        If oDtCabecera.Columns.Count = 0 Then
            Crear_Estructura_Cabecera(oDtCabecera)
        End If
        objFiltro("CCLNT") = pobjFiltro.Parametro3

        oDtCliente = oFacturaDato.Lista_Datos_Cliente(objFiltro)

        objFiltro = New Hashtable
        objFiltro("CCLNT") = pobjFiltro.Parametro3
        objFiltro("CPLNCL") = strPlantaCli
        oDtPlantaCliente = oFacturaDato.Lista_Datos_Planta_Cliente(objFiltro)


        objFiltro = New Hashtable
        objFiltro("CCMPN") = pobjFiltro.Parametro5
        objFiltro("CDVSN") = pobjFiltro.Parametro4
        objFiltro("CPLNDV") = pobjFiltro.Parametro7 'Planta

        oDtPlanta = oFacturaDato.Lista_Datos_Planta(objFiltro)
        Buscar_Documento() 'Obtiene el código de RZZM04
        For intCont = 0 To pobjFiltro.Parametro2 - 1
            oDr = oDtCabecera.NewRow
            oDr.Item("CCMPN") = pobjFiltro.Parametro5

            oDr.Item("CTPODC") = oTipoDocumento
            oDr.Item("NDCCTC") = intCont + 1
            oDr.Item("NINDRN") = "0"
            oDr.Item("CDVSN") = pobjFiltro.Parametro4
            oDr.Item("CGRONG") = strGiroNeg
            oDr.Item("CZNFCC") = oDtPlanta.Rows(0).Item("CZNFCC").ToString.Trim
            oDr.Item("CCBRD") = oDtPlantaCliente.Rows(0).Item("CCBRD").ToString.Trim
            oDr.Item("CCLNT") = oDtCliente.Rows(0).Item("CCLNT").ToString.Trim
            oDr.Item("CPLNCL") = strPlantaCli
            oDr.Item("NRUC") = oDtCliente.Rows(0).Item("NRUC").ToString.Trim
            oDr.Item("CSTCDC") = "ZZ"
            oDr.Item("CPLNDV") = pobjFiltro.Parametro7
            oDr.Item("SABOPN") = "P"
            oDr.Item("FDCCTC") = IIf(pobjFiltro.Parametro10.ToString.Length = 8, pobjFiltro.Parametro10, Format(pobjFiltro.Parametro10, "yyyMMdd"))
            oDr.Item("CMNDA") = IIf(pobjFiltro.Parametro8 = "DOL" Or pobjFiltro.Parametro8 = "100", 100, 1)
            oDr.Item("ITTPGS") = 0
            oDr.Item("ITTPGD") = 0
            oDr.Item("ITCCTC") = dblTipoCambio
            oDr.Item("SFLLTR") = IIf(oDtCliente.Rows(0).Item("CTPOCL").ToString.Trim = "F", "F", "T")
            oDr.Item("NCTDCC") = intCont
            oDr.Item("CZNCBD") = oDtCliente.Rows(0).Item("CZNCBR").ToString.Trim
            oDr.Item("CRGVTA") = pobjFiltro.Parametro9

            'FACTURA
            oDr.Item("FACTURA") = oDr.Item("NDCCTC")




            oDr.Item("OCOMPRA") = ""

            oDtCabecera.Rows.Add(oDr)
        Next intCont

        Return oDtCabecera
    End Function

    Public Function Lista_Cabecera_Factura_General(ByVal pobjFiltro As Hashtable) As DataTable
        Dim oDtCliente As DataTable
        Dim oDtPlantaCliente As DataTable
        Dim oDtPlanta As DataTable
        Dim oDr As DataRow
        Dim intCont As Integer
        Dim CantFact As Int64 = 0

        Dim objFiltro As New Hashtable
        Dim OrdenCompraFact As String = ""




        'CCLNT
        CantFact = pobjFiltro("CANTFACT")
        If oDtCabecera.Columns.Count = 0 Then
            Crear_Estructura_Cabecera(oDtCabecera)
        End If

        objFiltro("CCLNT") = pobjFiltro("CCLNFC")

        oDtCliente = oFacturaDato.Lista_Datos_Cliente(objFiltro)

        objFiltro = New Hashtable

        objFiltro("CCLNT") = pobjFiltro("CCLNFC")
        objFiltro("CPLNCL") = strPlantaCli
        oDtPlantaCliente = oFacturaDato.Lista_Datos_Planta_Cliente(objFiltro)


        objFiltro = New Hashtable
        objFiltro("CCMPN") = pobjFiltro("CCMPN")
        objFiltro("CDVSN") = pobjFiltro("CDVSN")
        objFiltro("CPLNDV") = pobjFiltro("CPLNFC") 'Planta

        oDtPlanta = oFacturaDato.Lista_Datos_Planta(objFiltro)
        Buscar_Documento() 'Obtiene el código de RZZM04
        For intCont = 0 To CantFact - 1

            oDr = oDtCabecera.NewRow

            oDr.Item("CCMPN") = pobjFiltro("CCMPN")

            oDr.Item("CTPODC") = oTipoDocumento
            oDr.Item("NDCCTC") = intCont + 1
            oDr.Item("NINDRN") = "0"

            oDr.Item("CDVSN") = pobjFiltro("CDVSN")
            oDr.Item("CGRONG") = strGiroNeg
            oDr.Item("CZNFCC") = oDtPlanta.Rows(0).Item("CZNFCC").ToString.Trim
            oDr.Item("CCBRD") = oDtPlantaCliente.Rows(0).Item("CCBRD").ToString.Trim
            oDr.Item("CCLNT") = oDtCliente.Rows(0).Item("CCLNT").ToString.Trim
            oDr.Item("CPLNCL") = strPlantaCli
            oDr.Item("NRUC") = oDtCliente.Rows(0).Item("NRUC").ToString.Trim
            oDr.Item("CSTCDC") = "ZZ"

            oDr.Item("CPLNDV") = pobjFiltro("CPLNFC")
            oDr.Item("SABOPN") = "P"

            oDr.Item("FDCCTC") = IIf(pobjFiltro("FECFAC").ToString.Length = 8, pobjFiltro("FECFAC"), Format(pobjFiltro("FECFAC"), "yyyyMMdd"))

            oDr.Item("CMNDA") = IIf(pobjFiltro("MONEDA") = "DOL" Or pobjFiltro("MONEDA") = "100", 100, 1)
            oDr.Item("ITTPGS") = 0
            oDr.Item("ITTPGD") = 0
            oDr.Item("ITCCTC") = dblTipoCambio
            oDr.Item("SFLLTR") = IIf(oDtCliente.Rows(0).Item("CTPOCL").ToString.Trim = "F", "F", "T")
            oDr.Item("NCTDCC") = intCont
            oDr.Item("CZNCBD") = oDtCliente.Rows(0).Item("CZNCBR").ToString.Trim

            oDr.Item("CRGVTA") = pobjFiltro("CRGVTA")
            oDr.Item("FACTURA") = oDr.Item("NDCCTC")



            If objValorOC_Cliente.ContainsKey(intCont + 1) Then
                OrdenCompraFact = objValorOC_Cliente(intCont + 1)
            Else
                OrdenCompraFact = ""
            End If
            oDr.Item("OCOMPRA") = OrdenCompraFact
            oDr.Item("CDDRSP") = oDtCliente.Rows(0).Item("CDDRSP").ToString.Trim
            oDr.Item("CCLNOP") = pobjFiltro("CCLNOP")



            oDtCabecera.Rows.Add(oDr)
        Next intCont

        Return oDtCabecera
    End Function

    Private Sub Buscar_Documento()
        Dim intCont As Integer


        For intCont = 0 To oDtDocumentos.Rows.Count - 1
            If oDtDocumentos.Rows(intCont).Item("NPTOVT").ToString.Trim = strPtoVenta Then
                strCodTabla = oDtDocumentos.Rows(intCont).Item("CTPCTR").ToString.Trim
                Exit For
            End If
        Next intCont
    End Sub



    Private Sub Validar_Detalles(ByVal poDr() As DataRow, ByRef pbolMismoCentro As Boolean, ByRef pbolMismaUnidad As Boolean, ByRef pbolMismaTarifa As Boolean, ByRef pbolValorServicio As Boolean)
        Dim intCont As Integer
        Dim strCentro As String
        Dim strUnidad As String
        Dim dblTarifa As Double = 0
        Dim dblCodTarifa As Double = 0
        Dim dblValorServicio As Double = 0

        pbolMismoCentro = True
        pbolMismaUnidad = True
        pbolMismaTarifa = True
        strCentro = poDr(0).Item("CCNTCS").ToString.Trim
        strUnidad = poDr(0).Item("CUNDMD").ToString.Trim
        dblTarifa = poDr(0).Item("IVLSRV").ToString.Trim
        dblCodTarifa = poDr(0).Item("NRTFSV").ToString.Trim

        For intCont = 0 To poDr.Length - 1
            If poDr(intCont).Item("CCNTCS").ToString.Trim <> strCentro Then
                pbolMismoCentro = False
                Exit For
            End If
        Next intCont
        For intCont = 0 To poDr.Length - 1
            If poDr(intCont).Item("CUNDMD").ToString.Trim <> strUnidad Then
                pbolMismaUnidad = False
                Exit For
            End If
        Next intCont

        For intCont = 0 To poDr.Length - 1
            If poDr(intCont).Item("IVLSRV").ToString.Trim <> dblTarifa Then
                pbolValorServicio = False
                Exit For
            End If
        Next intCont

        For intCont = 0 To poDr.Length - 1
            If poDr(intCont).Item("NRTFSV").ToString.Trim <> dblCodTarifa Then
                pbolMismaTarifa = False
                Exit For
            End If
        Next intCont

    End Sub


    Private Function Detalle_Factura(ByRef poDt As DataTable, ByVal pintNumFact As Integer) As DataTable
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intCol As Integer
        Dim oDr() As DataRow
        Dim oDrNew As DataRow
        Dim strDetraccion, strIGV, strMoneda As String
        Dim dblMonto As Decimal = 0D

        oDt = poDt.Copy
        oDt.Clear()

        dblMonto = poDt.Rows(0).Item("IAFCDT")
        strDetraccion = poDt.Rows(0).Item("IPRCDT").ToString.Trim
        strIGV = poDt.Rows(0).Item("CTIGVA").ToString.Trim
        strMoneda = poDt.Rows(0).Item("CMNDA1").ToString.Trim

        'csr-hotfix/031116_Visualizacion_Formato_Factura
        oDr = poDt.Select("IPRCDT = '" & strDetraccion & "' AND CTIGVA = " & strIGV & " AND CMNDA1 = " & strMoneda & " AND IAFCDT =" & dblMonto)


        For intCont = 0 To oDr.Length - 1
            oDrNew = oDt.NewRow
            For intCol = 0 To oDt.Columns.Count - 1
                oDrNew.Item(intCol) = oDr(intCont).Item(intCol).ToString.Trim
            Next intCol
            oDt.Rows.Add(oDrNew)
        Next intCont

      
        Eliminar_Rows_Detalles(poDt, strDetraccion, strIGV, strMoneda, dblMonto)


        Return oDt
    End Function

    Private Function Detalle_Factura_PreDocumentos(ByRef poDt As DataTable, ByVal pintNumFact As Integer) As DataTable
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intCol As Integer
        Dim oDr() As DataRow
        Dim oDrNew As DataRow
        Dim strDetraccion, strIGV, strMoneda As String
        Dim dblMonto As Decimal = 0D
        Dim PDocumento As String = ""

        oDt = poDt.Copy
        oDt.Clear()

        dblMonto = poDt.Rows(0).Item("IAFCDT")
        strDetraccion = poDt.Rows(0).Item("IPRCDT").ToString.Trim
        strIGV = poDt.Rows(0).Item("CTIGVA").ToString.Trim
        strMoneda = poDt.Rows(0).Item("CMNDA1").ToString.Trim
        PDocumento = poDt.Rows(0).Item("NPREDOC").ToString.Trim

        oDr = poDt.Select("IPRCDT = '" & strDetraccion & "' AND CTIGVA ='" & strIGV & "' AND CMNDA1 = '" & strMoneda & "' AND IAFCDT ='" & dblMonto & "' AND NPREDOC = '" & PDocumento & "'")


        For intCont = 0 To oDr.Length - 1
            oDrNew = oDt.NewRow
            For intCol = 0 To oDt.Columns.Count - 1
                oDrNew.Item(intCol) = oDr(intCont).Item(intCol).ToString.Trim
            Next intCol
            oDt.Rows.Add(oDrNew)
        Next intCont

        Eliminar_Rows_Detalles_PreDocumento(poDt, strDetraccion, strIGV, strMoneda, dblMonto, PDocumento)

        Return oDt
    End Function


    Private Function Lista_Items_Igual_CCosto(ByRef pbolUnidad As Boolean, ByVal poDr() As DataRow) As List(Of Hashtable)
        Dim objLista As New List(Of Hashtable)
        Dim objHas As Hashtable = Nothing
        Dim sCentCstFirst As String = ""
        Dim sUnidad As String = ""
        Dim dblTarifa As Decimal = 0
        Dim dblCodTarifa As Decimal = 0

        For lint As Int32 = 0 To poDr.Length - 1
            If lint = 0 Then
                sCentCstFirst = poDr(lint).Item("CCNTCS")
                dblTarifa = poDr(lint).Item("IVLSRV")
                sUnidad = poDr(lint).Item("CUNDMD")
                dblCodTarifa = poDr(lint).Item("NRTFSV")
                'agrega
                '===Logica de Carga===           
                For i As Integer = 0 To poDr(lint).ItemArray.Length - 1
                    objHas = New Hashtable
                    objHas.Add("TOTAL", poDr(lint).Item("TOTAL"))
                    objHas.Add("QATNAN", poDr(lint).Item("QATNAN"))
                    objHas.Add("CCNTCS", poDr(lint).Item("CCNTCS"))
                    objHas.Add("CCMPN", poDr(lint).Item("CCMPN"))
                    objHas.Add("CSRVNV", poDr(lint).Item("CSRVNV"))

                    objHas.Add("TCMTRF", poDr(lint).Item("TCMTRF"))


                    objHas.Add("CUNDMD", poDr(lint).Item("CUNDMD"))
                    objHas.Add("CDVSN", poDr(lint).Item("CDVSN"))
                    objHas.Add("IVLSRV", poDr(lint).Item("IVLSRV"))
                    objHas.Add("NRTFSV", poDr(lint).Item("NRTFSV"))
                    objHas.Add("NRRUBR", poDr(lint).Item("NRRUBR"))

                    objHas.Add("IMP_ORIGEN_SOL", poDr(lint).Item("IMP_ORIGEN_SOL"))

                Next
                objLista.Add(objHas)
            Else
                'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - INICIO 
                If oTipoDocumento = 6 Then
                    'If ListaFactor(0).PSCTPDCI = "PT" Then
                    objHas = New Hashtable
                    For i As Integer = 0 To poDr(lint).ItemArray.Length - 1
                        objHas = New Hashtable
                        objHas.Add("TOTAL", poDr(lint).Item("TOTAL"))
                        objHas.Add("QATNAN", poDr(lint).Item("QATNAN"))
                        objHas.Add("CCNTCS", poDr(lint).Item("CCNTCS"))
                        objHas.Add("CCMPN", poDr(lint).Item("CCMPN"))
                        objHas.Add("CSRVNV", poDr(lint).Item("CSRVNV"))


                        objHas.Add("TCMTRF", poDr(lint).Item("TCMTRF"))

                        objHas.Add("CUNDMD", poDr(lint).Item("CUNDMD"))
                        objHas.Add("CDVSN", poDr(lint).Item("CDVSN"))
                        objHas.Add("IVLSRV", poDr(lint).Item("IVLSRV"))
                        objHas.Add("NRTFSV", poDr(lint).Item("NRTFSV")) 'tarifa
                        objHas.Add("NRRUBR", poDr(lint).Item("NRRUBR")) 'rubro

                        objHas.Add("IMP_ORIGEN_SOL", poDr(lint).Item("IMP_ORIGEN_SOL"))
                    Next
                    objLista.Add(objHas)
                    'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - FIN 
                Else

                    If sCentCstFirst = poDr(lint).Item("CCNTCS") And dblTarifa = poDr(lint).Item("IVLSRV") And sUnidad = poDr(lint).Item("CUNDMD") And dblCodTarifa = poDr(lint).Item("NRTFSV") Then
                        'actualiza
                        objLista(objLista.Count - 1).Item("QATNAN") = objLista(objLista.Count - 1).Item("QATNAN") + poDr(lint).Item("QATNAN")
                        objLista(objLista.Count - 1).Item("TOTAL") = objLista(objLista.Count - 1).Item("TOTAL") + poDr(lint).Item("TOTAL")

                        objLista(objLista.Count - 1).Item("IMP_ORIGEN_SOL") = objLista(objLista.Count - 1).Item("IMP_ORIGEN_SOL") + poDr(lint).Item("IMP_ORIGEN_SOL")

                    Else
                        'agrega
                        '===Logica de Carga===
                        objHas = New Hashtable
                        For i As Integer = 0 To poDr(lint).ItemArray.Length - 1
                            objHas = New Hashtable
                            objHas.Add("TOTAL", poDr(lint).Item("TOTAL"))
                            objHas.Add("QATNAN", poDr(lint).Item("QATNAN"))
                            objHas.Add("CCNTCS", poDr(lint).Item("CCNTCS"))
                            objHas.Add("CCMPN", poDr(lint).Item("CCMPN"))
                            objHas.Add("CSRVNV", poDr(lint).Item("CSRVNV"))

                            objHas.Add("TCMTRF", poDr(lint).Item("TCMTRF"))


                            objHas.Add("CUNDMD", poDr(lint).Item("CUNDMD"))
                            objHas.Add("CDVSN", poDr(lint).Item("CDVSN"))
                            objHas.Add("IVLSRV", poDr(lint).Item("IVLSRV"))
                            objHas.Add("NRTFSV", poDr(lint).Item("NRTFSV")) 'tarifa
                            objHas.Add("NRRUBR", poDr(lint).Item("NRRUBR")) 'rubro


                            objHas.Add("IMP_ORIGEN_SOL", poDr(lint).Item("IMP_ORIGEN_SOL"))

                        Next
                        objLista.Add(objHas)
                    End If
                End If
            End If
            sCentCstFirst = poDr(lint).Item("CCNTCS")
            sUnidad = poDr(lint).Item("CUNDMD")
            dblTarifa = poDr(lint).Item("IVLSRV")
            dblCodTarifa = poDr(lint).Item("NRTFSV")
        Next
        Return objLista
    End Function



    Public oHasResumenVista As Hashtable
 
    Public Function Lista_Detalle_Factura_General(obeFact As beFactParam, ByRef phashIGV As Hashtable, ByRef pHtOperacioFacturar As Hashtable) As DataTable


        Dim Cant_Facturas As Integer = obeFact.CantFact
        Dim pintTipo As Integer = obeFact.pintTipo
        Dim pChkAprobador As String = obeFact.ChkAprobador
        Dim pAprobador As String = obeFact.Aprobador
        Dim EsxPreDocumento As Boolean = obeFact.EsxPreDocumento





        Dim SubTotalSol As Decimal = 0

        Dim oDt As New DataTable
        Dim oDtServicios As DataTable = Nothing
        Dim oDtFactura As DataTable
        Dim intCont, intDetalle As Integer
        Dim intNumFactura As Integer = 0
        Dim dblCenCos, dblCenCosMax As Double
        Dim dblTotalCant As Double
        Dim dblTotalMonto As Double
        Dim bolMismaUnidad As Boolean = True
        Dim bolMismaTarifa As Boolean = True
        Dim bolMismoCCosto As Boolean = True
        'ListaFactor = ListaFact
        '***adicionado************
        Dim bolValorServicio As Boolean = True
        '**********************

        Dim dblTarifaAnt As Double = 0
        Dim oDr As DataRow
        Dim oDrDet() As DataRow
        Dim sUnidad As String = ""
        Dim CodServicio As String
        Dim intTotalItems, intNumItems, intContador As Integer
        Dim oDrItemCenCos() As DataRow
        Dim dblPorIgv As Double
        Dim oDtAux As New DataTable

        '--Agregado ACD--
        Dim objHas As Hashtable
        Dim objLista As List(Of Hashtable)
        '--FIN Agregado ACD--

        '--Agregado Por Abraham Zorrilla
        Dim oDtDetalleFac As New DataTable
        oHasResumenVista = New Hashtable
        '--Fin AZP--

        If oDt.Columns.Count = 0 Then
            Crear_Estructura_Detalle(oDt)
            oDtDetalleFac = oDt.Clone
        End If

        oDtServicios = obeFact.dtServicos
        oDtServicios = oDtServicios.DefaultView.ToTable


        Dim oDsFactura As New DataSet
        Dim oDtOperacionFacturar As New DataTable
        Dim oDtDetalleFactura As New DataTable
        oDtOperacionFacturar.TableName = "SERVICIOS"
        oDtDetalleFactura.TableName = "DETALLE_FACTURA"

        pHtOperacioFacturar = New Hashtable
        'Limpiamos la variable
        objRegistroItemFactura.Clear()



        While (1) 'Se repite por la cantidad de Facturas
            '-------------------------------------------------------------------------------
            intNumFactura = intNumFactura + 1
            oDsFactura = New DataSet

            If intNumFactura > Cant_Facturas Then
                Exit While
            End If





            If oTipoDocumento = 1 OrElse oTipoDocumento = 51 Then
                If EsxPreDocumento = True Then
                    oDtFactura = Detalle_Factura_PreDocumentos(oDtServicios, intNumFactura)
                Else
                    oDtFactura = Detalle_Factura(oDtServicios, intNumFactura)
                End If
            Else
                oDtFactura = oDtServicios.Copy
            End If









            oDtOperacionFacturar = New DataTable
            oDtOperacionFacturar.Columns.Add("NOPRCN")
            oDtOperacionFacturar.Columns.Add("NRTFSV")
            oDtOperacionFacturar.Columns.Add("FACTURA")
            oDtOperacionFacturar.Columns.Add("NRRUBR")
            oDtOperacionFacturar.Columns.Add("NCRDCC")

            oDtOperacionFacturar.Columns.Add("CSRVNV")
            oDtOperacionFacturar.Columns.Add("CCNTCS")
            oDtOperacionFacturar.Columns.Add("IVLSRV")

            oDtOperacionFacturar.Columns.Add("NCRROP")
            oDtOperacionFacturar.Columns.Add("CTPODC")
            oDtOperacionFacturar.Columns.Add("NDCCTC")
            oDtOperacionFacturar.Columns.Add("FDCCTC")
            oDtOperacionFacturar.Columns.Add("CCMPN")
            oDtOperacionFacturar.Columns.Add("CCLNT")
            oDtOperacionFacturar.Columns.Add("CMNDA1")
            oDtOperacionFacturar.Columns.Add("QATNAN")
            oDtOperacionFacturar.Columns.Add("TOTAL")
            oDtOperacionFacturar.Columns.Add("CDVSN")
            oDtOperacionFacturar.Columns.Add("CUNDMD")
            'AGREGADO PARA REFRENCIAS
            oDtOperacionFacturar.Columns.Add("TRDCCL")
            oDtOperacionFacturar.Columns.Add("TRFSRC")

            oDtOperacionFacturar.Columns.Add("FLGAPR")
            oDtOperacionFacturar.Columns.Add("USRCCO")

            oDtOperacionFacturar.Columns.Add("NPRLQD")
            oDtOperacionFacturar.Columns.Add("NPREDOC")



            Dim oDrNew As DataRow
            For intX As Integer = 0 To oDtFactura.Rows.Count - 1
                oDrNew = oDtOperacionFacturar.NewRow
                oDrNew.Item("NOPRCN") = oDtFactura.Rows(intX).Item("NOPRCN")
                oDrNew.Item("NRTFSV") = oDtFactura.Rows(intX).Item("NRTFSV")
                oDrNew.Item("FACTURA") = intNumFactura
                oDrNew.Item("NRRUBR") = oDtFactura.Rows(intX).Item("NRRUBR")
                oDrNew.Item("CSRVNV") = oDtFactura.Rows(intX).Item("CSRVNV")
                oDrNew.Item("CCNTCS") = oDtFactura.Rows(intX).Item("CCNTCS")
                oDrNew.Item("IVLSRV") = oDtFactura.Rows(intX).Item("IVLSRV")

                oDrNew.Item("NCRROP") = oDtFactura.Rows(intX).Item("NCRROP")
                oDrNew.Item("CCLNT") = oDtFactura.Rows(intX).Item("CCLNT")
                oDrNew.Item("CCMPN") = oDtFactura.Rows(intX).Item("CCMPN")
                oDrNew.Item("CMNDA1") = oDtFactura.Rows(intX).Item("CMNDA1")
                oDrNew.Item("QATNAN") = oDtFactura.Rows(intX).Item("QATNAN")
                oDrNew.Item("TOTAL") = oDtFactura.Rows(intX).Item("TOTAL")
                oDrNew.Item("CDVSN") = oDtFactura.Rows(intX).Item("CDVSN")
                oDrNew.Item("CUNDMD") = oDtFactura.Rows(intX).Item("CUNDMD")
                'REFRENCIAS
                oDrNew.Item("TRDCCL") = oDtFactura.Rows(intX).Item("TRDCCL")
                oDrNew.Item("TRFSRC") = oDtFactura.Rows(intX).Item("TRFSRC")

                oDrNew.Item("FLGAPR") = pChkAprobador
                oDrNew.Item("USRCCO") = pAprobador

                oDrNew.Item("NPRLQD") = oDtFactura.Rows(intX).Item("NPRLQD")
                oDrNew.Item("NPREDOC") = oDtFactura.Rows(intX).Item("NPREDOC")

                oDtOperacionFacturar.Rows.Add(oDrNew)
            Next

            '=======================================Por Servicio
            dblCenCosMax = oDtFactura.Rows(0).Item("CCNTCS").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
            intTotalItems = oDtFactura.Rows.Count
            intNumItems = 0
            intDetalle = 0

            If oTipoDocumento = 6 Then
                dblPorIgv = 0
            Else
                dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
            End If


            phashIGV.Add(intNumFactura, dblPorIgv)

            'csr-hotfix/031116_Visualizacion_Formato_Factura
            oDtCabecera.Rows(intNumFactura - 1).Item("CDIRSE") = oDtFactura.Rows(0).Item("CDIRSE").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("DIRSEV") = oDtFactura.Rows(0).Item("DIRSEV").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("CUBIGE") = oDtFactura.Rows(0).Item("CUBGEO").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("DEDISE") = oDtFactura.Rows(0).Item("DEDISE").ToString.Trim ''INTEGRACION-041116-RANSASELVA
            'csr-hotfix/031116_Visualizacion_Formato_Factura
            '-------------------------------------------------------------------------------
            While (1) 'Se repite por la cantidad de Detalles de la Factura
                If intNumItems > intTotalItems - 1 Then
                    Exit While
                End If
                dblTotalCant = 0
                dblTotalMonto = 0

                CodServicio = oDtFactura.Rows(0).Item("CSRVNV").ToString.Trim
                oDrDet = oDtFactura.Select("CSRVNV=" & CodServicio)

                Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad, bolMismaTarifa, bolValorServicio) 'Indica si tiene mismo centro o misma unidad

                If bolMismoCCosto And bolMismaUnidad And bolMismaTarifa And bolValorServicio And oTipoDocumento <> 6 Then 'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 

                    'Es el mismo centro de costo o el mismo tipo de unidades
                    '--Agregado ACD--

                    objLista = New List(Of Hashtable)
                    For lint As Int32 = 0 To oDrDet.Length - 1
                        objHas = New Hashtable
                        objHas.Add("NRTFSV", oDrDet(lint).Item("NRTFSV"))   ' 1
                        objHas.Add("TOTAL", oDrDet(lint).Item("TOTAL"))     ' 2
                        objHas.Add("QATNAN", oDrDet(lint).Item("QATNAN"))   ' 3
                        objHas.Add("CUNDMD", oDrDet(lint).Item("CUNDMD"))   ' 4
                        objHas.Add("CCNTCS", oDrDet(lint).Item("CCNTCS"))   ' 5
                        objHas.Add("IVLSRV", oDrDet(lint).Item("IVLSRV"))   ' 6
                        objHas.Add("NRRUBR", oDrDet(lint).Item("NRRUBR"))
                        objHas.Add("NOPRCN", oDrDet(lint).Item("NOPRCN"))

                        ' adicionado 2020
                        objHas.Add("IMP_ORIGEN_SOL", oDrDet(lint).Item("IMP_ORIGEN_SOL"))


                        objLista.Add(objHas)
                    Next
                    While (1)
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        intContador = 0
                        SubTotalSol = 0
                        If objLista.Count <= 0 Then
                            Exit While
                        End If
                        ''Correlativo del detalle
                        intDetalle = intDetalle + 1

                        For lintIndice As Integer = 0 To objLista.Count - 1
                            If lintIndice = 0 Then
                                dblTarifaAnt = objLista(lintIndice).Item("NRTFSV")
                                sUnidad = objLista(lintIndice).Item("CUNDMD")
                                dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")

                                SubTotalSol = SubTotalSol + objLista(lintIndice).Item("IMP_ORIGEN_SOL")


                                intNumItems += 1
                                intContador += 1

                                For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1

                                    If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                        oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                    End If

                                Next

                            Else
                                If dblTarifaAnt = objLista(lintIndice).Item("NRTFSV") Then
                                    dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                    dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")

                                    SubTotalSol = SubTotalSol + objLista(lintIndice).Item("IMP_ORIGEN_SOL")

                                    intNumItems += 1
                                    intContador += 1

                                    For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                                        If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                            oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                        End If
                                    Next
                                End If
                            End If
                        Next


                        oDr = oDt.NewRow
                        oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"
                        oDr("NCRDCC") = intDetalle
                        oDr("CRBCTC") = oDrDet(0).Item("CSRVNV").ToString.Trim

                        oDr("STCCTC") = "" 'Flag tipo control

                        If bolMismaUnidad Then
                            oDr("CUNCNA") = oDrDet(0).Item("CUNDMD").ToString.Trim
                        Else
                            oDr("CUNCNA") = objLista(0).Item("CUNDMD")
                        End If
                        oDr("QAPCTC") = Math.Round(dblTotalCant, 5)
                        oDr("ITRCTC") = Math.Round(objLista(0).Item("IVLSRV"), 5)
                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim

                        dblTotalMonto = Math.Round(CType(oDr("QAPCTC"), Double) * CType(oDr("ITRCTC"), Double), 2)

                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                            oDr("IVLDCS") = dblTotalMonto
                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else
                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")
                            oDr("IVLDCD") = dblTotalMonto
                        End If

                        oDr("OIVLDCS") = SubTotalSol


                        'OIVLDCS

                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = objLista(0).Item("CCNTCS")
                        oDr("NRTFSV") = objLista(0).Item("NRTFSV")
                        oDr("NRRUBR") = objLista(0).Item("NRRUBR")

                        'adicionado2020
                        oDr("TCMTRF") = oDrDet(0).Item("TCMTRF").ToString.Trim
                        oDr("TOBS") = oDrDet(0).Item("TOBS").ToString.Trim
                        oDr("NOMSER") = oDrDet(0).Item("NOMSER").ToString.Trim


                        oDt.Rows.Add(oDr)

                        objLista.RemoveRange(0, intContador)

                    End While
                    '--FIN Agregado ACD--                
                Else
                    Dim oListaCC As New List(Of Hashtable)
                    oListaCC = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet
                    intNumItems += oDrDet.Length





                    While (1)
                        If oListaCC.Count = 0 Then
                            Exit While
                        End If

                        intContador += 1
                        intDetalle = intDetalle + 1
                        dblTotalMonto = oListaCC(0).Item("TOTAL")
                        dblTotalCant = oListaCC(0).Item("QATNAN")

                        oDr = oDt.NewRow
                        oDr("CCMPN") = oListaCC(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"

                        oDr("NCRDCC") = intDetalle

                        oDr("CRBCTC") = oListaCC(0).Item("CSRVNV").ToString.Trim
                        oDr("STCCTC") = "" 'Flag tipo control


                        oDr("CUNCNA") = oListaCC(0).Item("CUNDMD").ToString.Trim
                        oDr("QAPCTC") = Math.Round(dblTotalCant, 5)
                        oDr("ITRCTC") = Math.Round(oListaCC(0).Item("IVLSRV"), 5)


                        dblTotalMonto = Math.Round(CType(oDr("QAPCTC"), Double) * CType(oDr("ITRCTC"), Double), 2)
                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                            oDr("IVLDCS") = Math.Round(dblTotalMonto, 2)
                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else
                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")
                            oDr("IVLDCD") = Math.Round(dblTotalMonto, 2)
                        End If






                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oListaCC(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = oListaCC(0).Item("CCNTCS")

                        oDr("NRTFSV") = oListaCC(0).Item("NRTFSV")
                        oDr("NRRUBR") = oListaCC(0).Item("NRRUBR")


                        oDr("TCMTRF") = oDrDet(0).Item("TCMTRF").ToString.Trim
                        oDr("TOBS") = oDrDet(0).Item("TOBS").ToString.Trim
                        oDr("NOMSER") = oDrDet(0).Item("NOMSER").ToString.Trim


                        oDr("OIVLDCS") = Math.Round(oListaCC(0).Item("IMP_ORIGEN_SOL"), 2)

                        oDt.Rows.Add(oDr)

                        For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                            If oDtOperacionFacturar.Rows(intX).Item("CSRVNV") = oListaCC(0).Item("CSRVNV") And oDtOperacionFacturar.Rows(intX).Item("CCNTCS") = oListaCC(0).Item("CCNTCS") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = oListaCC(0).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = oListaCC(0).Item("IVLSRV") Then
                                oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                            End If
                        Next

                        oListaCC.RemoveRange(0, 1)
                    End While
                End If

                'esta variable es utilizado

                Quitar_Detalles_UtilizadosXServicio(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
            End While



            Select Case pintTipo
                Case 1

                    Dim IntCodRubro As Integer = 0
                    Dim dblMontoSoles As Double = 0
                    Dim dblMontoDolare As Double = 0
                    Dim IntCantidadRows As Integer = 0
                    Dim OrigenImporteSol As Decimal = 0
                    Dim oDrTemp() As DataRow
                    Dim oDtTemp As DataTable
                    intDetalle = 0
                    oDtTemp = oDt.Copy
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        If oDtTemp.Rows.Count = 0 Then
                            Exit While
                        End If
                        dblMontoSoles = 0
                        dblMontoDolare = 0
                        intDetalle = intDetalle + 1
                        IntCodRubro = oDtTemp.Rows(0).Item("NRRUBR")
                        oDrTemp = oDtTemp.Select("NRRUBR='" & IntCodRubro & "'")
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            dblMontoSoles = oDrTemp(IntCantidadRows).Item("IVLDCS") + dblMontoSoles
                            dblMontoDolare = oDrTemp(IntCantidadRows).Item("IVLDCD") + dblMontoDolare

                            OrigenImporteSol = OrigenImporteSol + oDrTemp(IntCantidadRows).Item("OIVLDCS")

                        Next

                        oDrTemp(0).Item("IVLDCS") = dblMontoSoles
                        oDrTemp(0).Item("IVLDCD") = dblMontoDolare


                        oDrTemp(0).Item("CUNCNA") = "UNI"
                        oDrTemp(0).Item("QAPCTC") = 0
                        oDrTemp(0).Item("ITRCTC") = 0
                        oDrTemp(0).Item("NCRDCC") = intDetalle


                        oDrTemp(0).Item("OIVLDCS") = OrigenImporteSol


                        oDtDetalleFac.ImportRow(oDrTemp(0))
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            oDtTemp.Rows.Remove(oDrTemp(IntCantidadRows))
                        Next

                    End While

                    'dtVistaDetalle

                    objRegistroItemFactura.Add(intDetalle)
                Case 2
                    intDetalle = 0
                    For Each dr As DataRow In oDt.Rows
                        oDtDetalleFac.ImportRow(dr)
                        intDetalle = intDetalle + 1
                    Next
                    objRegistroItemFactura.Add(intDetalle)


            End Select
            If dblPorIgv > 0 Then
                Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                Agregar_Detalle_IGV(oDtDetalleFac, intNumFactura, dblPorIgv)
            End If
            Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)

            Actualizar_Spot(intNumFactura, oTipoDocumento, EsxPreDocumento)

            Dim dtVistaImpresion As New DataTable
            dtVistaImpresion = oDtDetalleFac.Copy
            dtVistaImpresion.Rows.Clear()
            Dim _NCRDCC As Int64 = 0

            Select Case pintTipo
                Case 1
                    Dim dr As DataRow
                    _NCRDCC = 1
                    For Each item As DataRow In oDtDetalleFac.Rows
                        If item("CRBCTC") <> "999" And item("NDCCTC") = intNumFactura Then
                            dr = dtVistaImpresion.NewRow
                            dr("CCMPN") = item("CCMPN")
                            dr("NDCCTC") = item("NDCCTC")
                            dr("CTPODC") = item("CTPODC")
                            dr("NINDRN") = item("NINDRN")
                            dr("NCRDCC") = _NCRDCC
                            dr("CRBCTC") = item("CRBCTC")
                            dr("TCMTRF") = ("" & item("TCMTRF")).ToString.Trim
                            dr("TOBS") = ("" & item("TOBS")).ToString.Trim
                            dr("QAPCTC") = 1
                            dr("CUNCNA") = item("CUNCNA")
                            dr("CUTCTC") = item("CUTCTC")
                            If item("CUTCTC") = "SOL" Then
                                dr("ITRCTC") = item("IVLDCS")
                                dr("IVLDCS") = item("IVLDCS")
                                dr("IVLDCD") = 0
                            End If
                            If item("CUTCTC") = "DOL" Then
                                dr("ITRCTC") = item("IVLDCD")
                                dr("IVLDCD") = item("IVLDCD")
                                dr("IVLDCS") = 0
                            End If
                            _NCRDCC = _NCRDCC + 1
                            dtVistaImpresion.Rows.Add(dr)
                        End If

                    Next

                Case 2

                    Dim dr As DataRow
                    _NCRDCC = 1
                    For Each item As DataRow In oDtDetalleFac.Rows
                        If item("CRBCTC") <> "999" And item("NDCCTC") = intNumFactura Then

                            dr = dtVistaImpresion.NewRow
                            dr("CCMPN") = item("CCMPN")
                            dr("NDCCTC") = item("NDCCTC")
                            dr("CTPODC") = item("CTPODC")
                            dr("NINDRN") = item("NINDRN")
                            dr("NCRDCC") = _NCRDCC
                            dr("CRBCTC") = item("CRBCTC")
                            dr("TCMTRF") = ("" & item("NOMSER")).ToString.Trim
                            dr("TOBS") = ("" & item("TOBS")).ToString.Trim
                            dr("QAPCTC") = item("QAPCTC")
                            dr("CUNCNA") = item("CUNCNA")
                            dr("ITRCTC") = item("ITRCTC")
                            dr("CUTCTC") = item("CUTCTC")
                            If item("CUTCTC") = "SOL" Then
                                dr("IVLDCS") = item("IVLDCS")
                                dr("IVLDCD") = 0
                            End If
                            If item("CUTCTC") = "DOL" Then
                                dr("IVLDCD") = item("IVLDCD")
                                dr("IVLDCS") = 0
                            End If
                            _NCRDCC = _NCRDCC + 1
                            dtVistaImpresion.Rows.Add(dr)
                        End If

                    Next

            End Select

            If dblPorIgv > 0 Then
                Agregar_Detalle_IGV(dtVistaImpresion, intNumFactura, dblPorIgv)
            End If

            oHasResumenVista(intNumFactura) = dtVistaImpresion
            'Se agregar el regitro que se va guardar en el detalle de la factura
            oDt.TableName = "DetalleFactura"
            oDsFactura.Tables.Add(oDtOperacionFacturar)
            oDsFactura.Tables.Add(oDt.Copy)
            oDt.Rows.Clear()
            'Guardamos en un Data set Las operaciones y el detalle de la factura
            pHtOperacioFacturar.Add(intNumFactura, oDsFactura)
        End While


        Return oDtDetalleFac
    End Function


    Private Sub Actualizar_Spot(ByVal pintFactura As Integer, ByVal TipoDoc As Decimal, EsPorPredocumento As Boolean)
        Dim MontoFactura As Decimal = 0
        Dim MontoDetraccion As Decimal = 0
        Dim PorcentajeDetraccion As Decimal = 0

        Dim MontoFacturaServicioOrigen As Decimal = 0

        If objMontoDetraccion.Contains(pintFactura) Then
            MontoDetraccion = objMontoDetraccion(pintFactura)
        End If
        If objTipoDetraccion.Contains(pintFactura) Then
            PorcentajeDetraccion = objTipoDetraccion(pintFactura)
        End If
        MontoFactura = Convert.ToDecimal(oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS")) + Convert.ToDecimal(oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS"))

        MontoFacturaServicioOrigen = Convert.ToDecimal(oDtCabecera.Rows(pintFactura - 1).Item("OIVLAFS")) + Convert.ToDecimal(oDtCabecera.Rows(pintFactura - 1).Item("OIVLIGS"))

        If EsPorPredocumento = True Then ' Para predocumentos se verifica el importe del servicio original antes de su particionamiento.
            MontoFactura = MontoFacturaServicioOrigen
        End If



        Select Case TipoDoc
            Case 1, 51
                If MontoFactura > MontoDetraccion And PorcentajeDetraccion > 0 Then
                    oDtCabecera.Rows(pintFactura - 1).Item("NDSPGD") = PorcentajeDetraccion
                Else
                    oDtCabecera.Rows(pintFactura - 1).Item("NDSPGD") = 0
                End If

            Case 2, 52
                If MontoFactura > MontoDetraccion And PorcentajeDetraccion > 0 Then

                    oDtCabecera.Rows(pintFactura - 1).Item("NDSPGD") = PorcentajeDetraccion
                Else
                    oDtCabecera.Rows(pintFactura - 1).Item("NDSPGD") = 0
                End If

            Case Else
                oDtCabecera.Rows(pintFactura - 1).Item("NDSPGD") = 0
        End Select

    End Sub


    Public Function Lista_Detalle_Factura(ByVal ListaFact As List(Of SOLMIN_CTZ.Entidades.FacturaSIL), ByVal pobjFiltro As Filtro, ByRef phashIGV As Hashtable, ByRef pHtOperacioFacturar As Hashtable, ByVal pintTipo As Integer, ByVal FE As Boolean) As DataTable 'ByRef pdblIGV As Decimal 'csr-hotfix/031116_Visualizacion_Formato_Factura

        Dim oDt As New DataTable
        Dim oDtServicios As DataTable = Nothing
        Dim oDtFactura As DataTable
        Dim intCont, intDetalle As Integer
        Dim intNumFactura As Integer = 0
        Dim dblCenCos, dblCenCosMax As Double
        Dim dblTotalCant As Double
        Dim dblTotalMonto As Double
        Dim bolMismaUnidad As Boolean = True
        Dim bolMismaTarifa As Boolean = True
        Dim bolMismoCCosto As Boolean = True
        'ListaFactor = ListaFact
        '***adicionado************
        Dim bolValorServicio As Boolean = True
        '**********************

        Dim dblTarifaAnt As Double = 0
        Dim oDr As DataRow
        Dim oDrDet() As DataRow
        Dim sUnidad As String = ""
        Dim CodServicio As String
        Dim intTotalItems, intNumItems, intContador As Integer
        Dim oDrItemCenCos() As DataRow
        Dim dblPorIgv As Double
        Dim oDtAux As New DataTable

        '--Agregado ACD--
        Dim objHas As Hashtable
        Dim objLista As List(Of Hashtable)
        '--FIN Agregado ACD--

        '--Agregado Por Abraham Zorrilla
        Dim oDtDetalleFac As New DataTable
        '--Fin AZP--

        If oDt.Columns.Count = 0 Then
            Crear_Estructura_Detalle(oDt)
            oDtDetalleFac = oDt.Clone
        End If
        For intCant As Integer = 0 To ListaFact.Count - 1
            If ListaFact(intCant).NSECFC = 0 Then
                pobjFiltro.Parametro1 = ListaFact(intCant).NOPRCN

                oDtAux = oFacturaDato.Lista_Detalle_ServiciosXOperacion_V2(pobjFiltro)
            Else
                pobjFiltro.Parametro1 = ListaFact(intCant).NSECFC

                oDtAux = oFacturaDato.Lista_Detalle_ServiciosXRevision_V2(pobjFiltro)
            End If
            If intCant = 0 Then oDtServicios = oDtAux.Clone

            For Each dr As DataRow In oDtAux.Rows
                oDtServicios.ImportRow(dr)
            Next
        Next


        If FE = False Then
            For Each Item As DataRow In oDtServicios.Rows
                Item("DEDISE") = ""
            Next
        End If


        oDtServicios.DefaultView.Sort = "CSRVNV, NRTFSV,CCNTCS,CUNDMD,IVLSRV ASC"
        oDtServicios = oDtServicios.DefaultView.ToTable


        Dim oDsFactura As New DataSet
        Dim oDtOperacionFacturar As New DataTable
        Dim oDtDetalleFactura As New DataTable
        oDtOperacionFacturar.TableName = "SERVICIOS"
        oDtDetalleFactura.TableName = "DETALLE_FACTURA"

        pHtOperacioFacturar = New Hashtable
        'Limpiamos la variable
        objRegistroItemFactura.Clear()



        While (1) 'Se repite por la cantidad de Facturas
            '-------------------------------------------------------------------------------
            intNumFactura = intNumFactura + 1
            oDsFactura = New DataSet
            If intNumFactura > pobjFiltro.Parametro2 Then
                Exit While
            End If



            If FE = True Then

                Select Case ListaFact(0).PSCTPDCI
                    Case "PT"
                        oDtFactura = oDtServicios.Copy
                    Case "LE"
                        oDtFactura = Detalle_BE(oDtServicios, intNumFactura)
                    Case Else
                        oDtFactura = Detalle_Factura(oDtServicios, intNumFactura)
                End Select

            Else

                If ListaFact(0).PSCTPDCI = "LE" Or ListaFact(0).PSCTPDCI = "PT" Then 'JM
                    oDtFactura = oDtServicios.Copy
                Else
                    oDtFactura = Detalle_Factura(oDtServicios, intNumFactura)
                End If

            End If

           

            oDtOperacionFacturar = New DataTable
            oDtOperacionFacturar.Columns.Add("NOPRCN")
            oDtOperacionFacturar.Columns.Add("NRTFSV")
            oDtOperacionFacturar.Columns.Add("FACTURA")
            oDtOperacionFacturar.Columns.Add("NRRUBR")
            oDtOperacionFacturar.Columns.Add("NCRDCC")

            oDtOperacionFacturar.Columns.Add("CSRVNV")
            oDtOperacionFacturar.Columns.Add("CCNTCS")
            oDtOperacionFacturar.Columns.Add("IVLSRV")

            oDtOperacionFacturar.Columns.Add("NCRROP")
            oDtOperacionFacturar.Columns.Add("CTPODC")
            oDtOperacionFacturar.Columns.Add("NDCCTC")
            oDtOperacionFacturar.Columns.Add("FDCCTC")
            oDtOperacionFacturar.Columns.Add("CCMPN")
            oDtOperacionFacturar.Columns.Add("CCLNT")
            oDtOperacionFacturar.Columns.Add("CMNDA1")
            oDtOperacionFacturar.Columns.Add("QATNAN")
            oDtOperacionFacturar.Columns.Add("TOTAL")
            oDtOperacionFacturar.Columns.Add("CDVSN")
            oDtOperacionFacturar.Columns.Add("CUNDMD")
            'AGREGADO PARA REFRENCIAS
            oDtOperacionFacturar.Columns.Add("TRDCCL")
            oDtOperacionFacturar.Columns.Add("TRFSRC")

            Dim oDrNew As DataRow
            For intX As Integer = 0 To oDtFactura.Rows.Count - 1
                oDrNew = oDtOperacionFacturar.NewRow
                oDrNew.Item("NOPRCN") = oDtFactura.Rows(intX).Item("NOPRCN")
                oDrNew.Item("NRTFSV") = oDtFactura.Rows(intX).Item("NRTFSV")
                oDrNew.Item("FACTURA") = intNumFactura
                oDrNew.Item("NRRUBR") = oDtFactura.Rows(intX).Item("NRRUBR")
                oDrNew.Item("CSRVNV") = oDtFactura.Rows(intX).Item("CSRVNV")
                oDrNew.Item("CCNTCS") = oDtFactura.Rows(intX).Item("CCNTCS")
                oDrNew.Item("IVLSRV") = oDtFactura.Rows(intX).Item("IVLSRV")

                oDrNew.Item("NCRROP") = oDtFactura.Rows(intX).Item("NCRROP")
                oDrNew.Item("CCLNT") = oDtFactura.Rows(intX).Item("CCLNT")
                oDrNew.Item("CCMPN") = oDtFactura.Rows(intX).Item("CCMPN")
                oDrNew.Item("CMNDA1") = oDtFactura.Rows(intX).Item("CMNDA1")
                oDrNew.Item("QATNAN") = oDtFactura.Rows(intX).Item("QATNAN")
                oDrNew.Item("TOTAL") = oDtFactura.Rows(intX).Item("TOTAL")
                oDrNew.Item("CDVSN") = oDtFactura.Rows(intX).Item("CDVSN")
                oDrNew.Item("CUNDMD") = oDtFactura.Rows(intX).Item("CUNDMD")
                'REFRENCIAS
                oDrNew.Item("TRDCCL") = oDtFactura.Rows(intX).Item("TRDCCL")
                oDrNew.Item("TRFSRC") = oDtFactura.Rows(intX).Item("TRFSRC")

                oDtOperacionFacturar.Rows.Add(oDrNew)
            Next

            '=======================================Por Servicio
            dblCenCosMax = oDtFactura.Rows(0).Item("CCNTCS").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
            intTotalItems = oDtFactura.Rows.Count
            intNumItems = 0
            intDetalle = 0


            If ListaFact(0).PSCTPDCI = "PT" Then 'JM
                dblPorIgv = 0
            Else
                dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
                'pdblIGV = dblPorIgv
            End If

            phashIGV.Add(intNumFactura, dblPorIgv)

            'csr-hotfix/031116_Visualizacion_Formato_Factura
            oDtCabecera.Rows(intNumFactura - 1).Item("CDIRSE") = oDtFactura.Rows(0).Item("CDIRSE").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("DIRSEV") = oDtFactura.Rows(0).Item("DIRSEV").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("CUBIGE") = oDtFactura.Rows(0).Item("CUBGEO").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("DEDISE") = oDtFactura.Rows(0).Item("DEDISE").ToString.Trim ''INTEGRACION-041116-RANSASELVA
            'csr-hotfix/031116_Visualizacion_Formato_Factura
            '-------------------------------------------------------------------------------
            While (1) 'Se repite por la cantidad de Detalles de la Factura
                If intNumItems > intTotalItems - 1 Then
                    Exit While
                End If
                dblTotalCant = 0
                dblTotalMonto = 0

                CodServicio = oDtFactura.Rows(0).Item("CSRVNV").ToString.Trim
                oDrDet = oDtFactura.Select("CSRVNV=" & CodServicio)

                Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad, bolMismaTarifa, bolValorServicio) 'Indica si tiene mismo centro o misma unidad

                If bolMismoCCosto And bolMismaUnidad And bolMismaTarifa And bolValorServicio And ListaFact(0).PSCTPDCI <> "PT" Then 'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 
                    'Es el mismo centro de costo o el mismo tipo de unidades
                    '--Agregado ACD--

                    objLista = New List(Of Hashtable)
                    For lint As Int32 = 0 To oDrDet.Length - 1
                        objHas = New Hashtable
                        objHas.Add("NRTFSV", oDrDet(lint).Item("NRTFSV"))   ' 1
                        objHas.Add("TOTAL", oDrDet(lint).Item("TOTAL"))     ' 2
                        objHas.Add("QATNAN", oDrDet(lint).Item("QATNAN"))   ' 3
                        objHas.Add("CUNDMD", oDrDet(lint).Item("CUNDMD"))   ' 4
                        objHas.Add("CCNTCS", oDrDet(lint).Item("CCNTCS"))   ' 5
                        objHas.Add("IVLSRV", oDrDet(lint).Item("IVLSRV"))   ' 6
                        objHas.Add("NRRUBR", oDrDet(lint).Item("NRRUBR"))
                        objHas.Add("NOPRCN", oDrDet(lint).Item("NOPRCN"))
                        objLista.Add(objHas)
                    Next
                    While (1)
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        intContador = 0
                        If objLista.Count <= 0 Then
                            Exit While
                        End If
                        ''Correlativo del detalle
                        intDetalle = intDetalle + 1

                        For lintIndice As Integer = 0 To objLista.Count - 1
                            If lintIndice = 0 Then
                                dblTarifaAnt = objLista(lintIndice).Item("NRTFSV")
                                sUnidad = objLista(lintIndice).Item("CUNDMD")
                                dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")

                                intNumItems += 1
                                intContador += 1

                                For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1

                                    If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                        oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                    End If

                                Next

                            Else
                                If dblTarifaAnt = objLista(lintIndice).Item("NRTFSV") Then
                                    dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                    dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")
                                    intNumItems += 1
                                    intContador += 1

                                    For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                                        If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                            oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                        End If
                                    Next
                                End If
                            End If
                        Next


                        oDr = oDt.NewRow
                        oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"
                        oDr("NCRDCC") = intDetalle
                        oDr("CRBCTC") = oDrDet(0).Item("CSRVNV").ToString.Trim

                        oDr("STCCTC") = "" 'Flag tipo control
                        If bolMismaUnidad Then
                            oDr("CUNCNA") = oDrDet(0).Item("CUNDMD").ToString.Trim


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(objLista(0).Item("IVLSRV"), 5)
                        Else
                            oDr("CUNCNA") = objLista(0).Item("CUNDMD")


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(objLista(0).Item("IVLSRV"), 5)
                        End If
                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim

                        dblTotalMonto = Math.Round(CType(oDr("QAPCTC"), Double) * CType(oDr("ITRCTC"), Double), 2)
                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                            oDr("IVLDCS") = dblTotalMonto

                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else

                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")
                            oDr("IVLDCD") = dblTotalMonto
                        End If
                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = objLista(0).Item("CCNTCS")
                        oDr("NRTFSV") = objLista(0).Item("NRTFSV")
                        oDr("NRRUBR") = objLista(0).Item("NRRUBR")

                        oDt.Rows.Add(oDr)

                        objLista.RemoveRange(0, intContador)

                    End While
                    '--FIN Agregado ACD--                
                Else
                    Dim oListaCC As New List(Of Hashtable)
                    oListaCC = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet
                    intNumItems += oDrDet.Length

                    While (1)
                        If oListaCC.Count = 0 Then
                            Exit While
                        End If

                        intContador += 1
                        intDetalle = intDetalle + 1
                        dblTotalMonto = oListaCC(0).Item("TOTAL")
                        dblTotalCant = oListaCC(0).Item("QATNAN")

                        oDr = oDt.NewRow
                        oDr("CCMPN") = oListaCC(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"

                        oDr("NCRDCC") = intDetalle

                        oDr("CRBCTC") = oListaCC(0).Item("CSRVNV").ToString.Trim
                        oDr("STCCTC") = "" 'Flag tipo control

                        If bolMismaUnidad Then
                            oDr("CUNCNA") = oListaCC(0).Item("CUNDMD").ToString.Trim  ' VALOR UNIDAD


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)             'CANTIDAD


                            oDr("ITRCTC") = Math.Round(oListaCC(0).Item("IVLSRV"), 5) 'TARIFA
                        Else
                            oDr("CUNCNA") = oListaCC(0).Item("CUNDMD")


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(oListaCC(0).Item("IVLSRV"), 5)
                        End If
                        dblTotalMonto = Math.Round(CType(oDr("QAPCTC"), Double) * CType(oDr("ITRCTC"), Double), 2)
                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then

                            oDr("IVLDCS") = Math.Round(dblTotalMonto, 2)

                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else

                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")

                            oDr("IVLDCD") = Math.Round(dblTotalMonto, 2)
                        End If

                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oListaCC(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = oListaCC(0).Item("CCNTCS")

                        oDr("NRTFSV") = oListaCC(0).Item("NRTFSV")
                        oDr("NRRUBR") = oListaCC(0).Item("NRRUBR")
                        oDt.Rows.Add(oDr)

                        For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                            If oDtOperacionFacturar.Rows(intX).Item("CSRVNV") = oListaCC(0).Item("CSRVNV") And oDtOperacionFacturar.Rows(intX).Item("CCNTCS") = oListaCC(0).Item("CCNTCS") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = oListaCC(0).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = oListaCC(0).Item("IVLSRV") Then
                                oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                            End If



                        Next

                        oListaCC.RemoveRange(0, 1)
                    End While
                End If

                'esta variable es utilizado

                Quitar_Detalles_UtilizadosXServicio(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
            End While


            Select Case pintTipo
                Case 1

                    Dim IntCodRubro As Integer = 0
                    Dim dblMontoSoles As Double = 0
                    Dim dblMontoDolare As Double = 0
                    Dim IntCantidadRows As Integer = 0
                    Dim oDrTemp() As DataRow
                    Dim oDtTemp As DataTable
                    intDetalle = 0
                    oDtTemp = oDt.Copy
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        If oDtTemp.Rows.Count = 0 Then
                            Exit While
                        End If
                        dblMontoSoles = 0
                        dblMontoDolare = 0
                        intDetalle = intDetalle + 1
                        IntCodRubro = oDtTemp.Rows(0).Item("NRRUBR")
                        oDrTemp = oDtTemp.Select("NRRUBR='" & IntCodRubro & "'")
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            dblMontoSoles = oDrTemp(IntCantidadRows).Item("IVLDCS") + dblMontoSoles
                            dblMontoDolare = oDrTemp(IntCantidadRows).Item("IVLDCD") + dblMontoDolare
                        Next

                        oDrTemp(0).Item("IVLDCS") = dblMontoSoles
                        oDrTemp(0).Item("IVLDCD") = dblMontoDolare
                        oDrTemp(0).Item("CUNCNA") = ""
                        oDrTemp(0).Item("QAPCTC") = 0
                        oDrTemp(0).Item("ITRCTC") = 0
                        oDrTemp(0).Item("NCRDCC") = intDetalle
                        oDtDetalleFac.ImportRow(oDrTemp(0))
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            oDtTemp.Rows.Remove(oDrTemp(IntCantidadRows))
                        Next




                    End While
                    objRegistroItemFactura.Add(intDetalle)
                Case 2
                    intDetalle = 0
                    For Each dr As DataRow In oDt.Rows
                        oDtDetalleFac.ImportRow(dr)
                        intDetalle = intDetalle + 1
                    Next
                    objRegistroItemFactura.Add(intDetalle)

                 
            End Select
            If dblPorIgv > 0 Then
                Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                Agregar_Detalle_IGV(oDtDetalleFac, intNumFactura, dblPorIgv)
            End If
            Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)

            'Se agregar el regitro que se va guardar en el detalle de la factura
            oDt.TableName = "DetalleFactura"
            oDsFactura.Tables.Add(oDtOperacionFacturar)
            oDsFactura.Tables.Add(oDt.Copy)
            oDt.Rows.Clear()
            'Guardamos en un Data set Las operaciones y el detalle de la factura
            pHtOperacioFacturar.Add(intNumFactura, oDsFactura)
        End While


        Return oDtDetalleFac
    End Function


    Private Sub Quitar_Detalles_UtilizadosXServicio(ByRef poDt As DataTable, ByVal pdblServicio As Double)
        Dim intCont As Integer

        For intCont = poDt.Rows.Count - 1 To 0 Step -1
            If poDt.Rows(intCont).Item("CSRVNV") = pdblServicio Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub


    Private Sub Quitar_Detalles_UtilizadosXRubro(ByRef poDt As DataTable, ByVal pIntCodRubro As Integer)
        Dim intCont As Integer
        For intCont = poDt.Rows.Count - 1 To 0 Step -1
            If poDt.Rows(intCont).Item("CSRVNV") = pIntCodRubro Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub

    Private Sub Actualizar_Montos_Cabecera(ByVal poDt As DataTable, ByVal pintFactura As Integer, ByVal pdblIGV As Integer)
        Dim intCont As Integer
        Dim dblTotalAfecto As Double = 0
        Dim dblTotalInAfecto As Double = 0
        Dim bolSol As Boolean = False
        Dim dblOrigenTotalAfectoSol As Decimal = 0
        If pdblIGV > 0 Then
            For intCont = 0 To poDt.Rows.Count - 1
                If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura And poDt.Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                    If poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                        bolSol = True
                        dblTotalAfecto = dblTotalAfecto + poDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                    Else
                        bolSol = False
                        dblTotalAfecto = dblTotalAfecto + poDt.Rows(intCont).Item("IVLDCD").ToString.Trim
                    End If

                    dblOrigenTotalAfectoSol = dblOrigenTotalAfectoSol + CDec(poDt.Rows(intCont).Item("OIVLDCS"))

                End If
            Next intCont
        Else
            For intCont = 0 To poDt.Rows.Count - 1
                If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura Then
                    If poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                        bolSol = True
                        dblTotalInAfecto = dblTotalInAfecto + poDt.Rows(intCont).Item("IVLDCS").ToString.Trim
                    Else
                        bolSol = False
                        dblTotalInAfecto = dblTotalInAfecto + poDt.Rows(intCont).Item("IVLDCD").ToString.Trim
                    End If
                End If
            Next intCont
        End If

        If bolSol Then
            oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS") = dblTotalAfecto
            oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS") = dblTotalInAfecto

            oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS") = IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,##0.00"), pdblIGV)

            oDtCabecera.Rows(pintFactura - 1).Item("ITTFCS") = CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS"), Decimal)

            oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD") = Format((dblTotalAfecto / dblTipoCambio), "###,###,###,###,##0.00")

            oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD") = Format((dblTotalInAfecto / dblTipoCambio), "###,###,###,###,##0.00")

            oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD") = IIf(pdblIGV > 0, Format((dblTotalAfecto / dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,##0.00"), pdblIGV)

            oDtCabecera.Rows(pintFactura - 1).Item("ITTFCD") = CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD"), Decimal)
        Else

            oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS") = Format((dblTotalAfecto * dblTipoCambio), "###,###,###,###,##0.00")

            oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS") = Format((dblTotalInAfecto * dblTipoCambio), "###,###,###,###,##0.00")

            oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS") = IIf(pdblIGV > 0, Format((dblTotalAfecto * dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,##0.00"), pdblIGV)

            oDtCabecera.Rows(pintFactura - 1).Item("ITTFCS") = CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLAFS"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLNAS"), Decimal) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLIGS"), Decimal)
            oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD") = dblTotalAfecto
            oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD") = dblTotalInAfecto

            oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD") = IIf(pdblIGV > 0, Format(dblTotalAfecto * (pdblIGV / 100), "###,###,###,###,##0.00"), pdblIGV)

            oDtCabecera.Rows(pintFactura - 1).Item("ITTFCD") = CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLAFD"), Double) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLNAD"), Double) + CType(oDtCabecera.Rows(pintFactura - 1).Item("IVLIGD"), Double)
        End If

        oDtCabecera.Rows(pintFactura - 1).Item("OIVLAFS") = dblOrigenTotalAfectoSol
        oDtCabecera.Rows(pintFactura - 1).Item("OIVLIGS") = IIf(pdblIGV > 0, Format(dblOrigenTotalAfectoSol * (pdblIGV / 100), "###,###,###,###,###.00"), pdblIGV)


    End Sub

    Private Sub Agregar_Detalle_IGV(ByRef poDt As DataTable, ByVal pintFactura As Integer, ByVal pdblIGV As Integer)
        Dim oDr As DataRow
        Dim intCont As Integer
        Dim intDet As Integer = 1
        Dim dblTotal As Decimal = 0

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("NDCCTC").ToString.Trim = pintFactura Then
                intDet = intDet + 1
                If poDt.Rows(intCont).Item("CUTCTC").ToString.Trim = "SOL" Then
                    dblTotal = dblTotal + CDec(poDt.Rows(intCont).Item("IVLDCS"))
                Else
                    dblTotal = dblTotal + CDec(poDt.Rows(intCont).Item("IVLDCD"))
                End If
            End If
        Next intCont
        oDr = poDt.NewRow

        oDr("CCMPN") = poDt.Rows(0).Item("CCMPN").ToString.Trim

        oDr("CTPODC") = oTipoDocumento
        oDr("NDCCTC") = pintFactura
        oDr("NINDRN") = "0"
        oDr("NCRDCC") = intDet
        oDr("CRBCTC") = "999"
        oDr("QAPCTC") = "0"
        oDr("ITRCTC") = "0"
        oDr("STCCTC") = "" 'Flag tipo control
        If poDt.Rows(0).Item("CUTCTC").ToString.Trim = "SOL" Then
            oDr("IVLDCS") = Format(dblTotal * (pdblIGV / 100), "###,###,###,###,##0.00")
            oDr("IVLDCD") = Format((dblTotal / dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,##0.00")
        Else
            oDr("IVLDCS") = Format((dblTotal * dblTipoCambio) * (pdblIGV / 100), "###,###,###,###,##0.00")
            oDr("IVLDCD") = Format(dblTotal * (pdblIGV / 100), "###,###,###,###,##0.00")
        End If
        oDr("NCTDCC") = pintFactura
        oDr("FDCCTC") = oDtCabecera.Rows(pintFactura - 1).Item("FDCCTC").ToString.Trim
        oDr("CDVSN") = poDt.Rows(0).Item("CDVSN").ToString.Trim
        oDr("CCNCSD") = poDt.Rows(0).Item("CCNCSD").ToString.Trim
        poDt.Rows.Add(oDr)
    End Sub

    Private Sub Crear_Estructura_Detalle(ByRef poDt As DataTable)
        poDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String))) 'Compañia
        poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
        poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento
        poDt.Columns.Add(New DataColumn("NINDRN", GetType(System.String))) 'Indice de Renovacion = 0
        poDt.Columns.Add(New DataColumn("NCRDCC", GetType(System.String))) 'Correlativo del Detalle
        poDt.Columns.Add(New DataColumn("CRBCTC", GetType(System.String))) 'Servicio
        poDt.Columns.Add(New DataColumn("STCCTC", GetType(System.String))) 'Flag tipo control = ""
        poDt.Columns.Add(New DataColumn("CUNCNA", GetType(System.String))) 'Unidad del Servicio
        poDt.Columns.Add(New DataColumn("QAPCTC", GetType(System.String))) 'Cantidad del Servicio
        poDt.Columns.Add(New DataColumn("CUTCTC", GetType(System.String))) 'Moneda de la Tarifa
        poDt.Columns.Add(New DataColumn("ITRCTC", GetType(System.String))) 'Tarifa del Servicio
        poDt.Columns.Add(New DataColumn("IVLDCS", GetType(System.String))) 'Monto Total Soles
        poDt.Columns.Add(New DataColumn("IVLDCD", GetType(System.String))) 'Monto Total Dolares
        poDt.Columns.Add(New DataColumn("NCTDCC", GetType(System.String))) 'Control Documento
        poDt.Columns.Add(New DataColumn("FDCCTC", GetType(System.String))) 'Fecha de Emision
        poDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String))) 'Division
        poDt.Columns.Add(New DataColumn("CGRNGD", GetType(System.String))) 'Giro de Negocio
        poDt.Columns.Add(New DataColumn("CCNCSD", GetType(System.String))) 'Centro de Costo
        poDt.Columns.Add(New DataColumn("NRTFSV", GetType(System.String))) 'TARIFA
        poDt.Columns.Add(New DataColumn("NRRUBR", GetType(System.String))) 'TARIFA


        poDt.Columns.Add(New DataColumn("TCMTRF", GetType(System.String)))
        poDt.Columns.Add(New DataColumn("TOBS", GetType(System.String)))
        poDt.Columns.Add(New DataColumn("NOMSER", GetType(System.String)))
        poDt.Columns.Add(New DataColumn("OIVLDCS", GetType(System.Decimal)))






    End Sub

    Private Sub Crear_Estructura_Cabecera(ByRef poDt As DataTable)
        poDt.Columns.Add(New DataColumn("CCMPN", GetType(System.String))) 'Compañia
        poDt.Columns.Add(New DataColumn("CTPODC", GetType(System.String))) 'Tipo de Documento
        poDt.Columns.Add(New DataColumn("NDCCTC", GetType(System.String))) 'Numero de Documento
        poDt.Columns.Add(New DataColumn("NINDRN", GetType(System.String))) 'Indice de Renovacion = 0
        poDt.Columns.Add(New DataColumn("CDVSN", GetType(System.String))) 'Division
        poDt.Columns.Add(New DataColumn("CGRONG", GetType(System.String))) 'Giro de Negocio
        poDt.Columns.Add(New DataColumn("CZNFCC", GetType(System.String))) 'Zona de Facturacion
        poDt.Columns.Add(New DataColumn("CCBRD", GetType(System.String))) 'Codigo de Cobrador
        poDt.Columns.Add(New DataColumn("CCLNT", GetType(System.String))) 'Cliente
        poDt.Columns.Add(New DataColumn("CPLNCL", GetType(System.String))) 'Planta Cliente
        poDt.Columns.Add(New DataColumn("NRUC", GetType(System.String))) 'RUC
        poDt.Columns.Add(New DataColumn("CSTCDC", GetType(System.String))) 'Situacion Documento ='ZZ'
        poDt.Columns.Add(New DataColumn("CPLNDV", GetType(System.String))) 'Planta
        poDt.Columns.Add(New DataColumn("SABOPN", GetType(System.String))) 'Abono Pendiente='P'
        poDt.Columns.Add(New DataColumn("FDCCTC", GetType(System.String))) 'Fecha de Emision
        poDt.Columns.Add(New DataColumn("CMNDA", GetType(System.String))) 'Moneda
        poDt.Columns.Add(New DataColumn("IVLAFS", GetType(System.String))) 'Monto Afecto Soles
        poDt.Columns.Add(New DataColumn("IVLNAS", GetType(System.String))) 'Monto No Afecto Soles
        poDt.Columns.Add(New DataColumn("IVLIGS", GetType(System.String))) 'Monto IGV Soles
        poDt.Columns.Add(New DataColumn("ITTFCS", GetType(System.String))) 'Total Monto Soles
        poDt.Columns.Add(New DataColumn("ITTPGS", GetType(System.String))) 'Pago Soles = 0
        poDt.Columns.Add(New DataColumn("IVLAFD", GetType(System.String))) 'Monto Afecto Dolares
        poDt.Columns.Add(New DataColumn("IVLNAD", GetType(System.String))) 'Monto No Afecto Dolares
        poDt.Columns.Add(New DataColumn("IVLIGD", GetType(System.String))) 'Monto IGV Dolares
        poDt.Columns.Add(New DataColumn("ITTFCD", GetType(System.String))) 'Total Monto Dolares
        poDt.Columns.Add(New DataColumn("ITTPGD", GetType(System.String))) 'Pago Dolares = 0
        poDt.Columns.Add(New DataColumn("ITCCTC", GetType(System.String))) 'Tipo Cambio
        poDt.Columns.Add(New DataColumn("SFLLTR", GetType(System.String))) 'Filial / Tercero
        poDt.Columns.Add(New DataColumn("NCTDCC", GetType(System.String))) 'Control Documento
        poDt.Columns.Add(New DataColumn("CZNCBD", GetType(System.String))) 'Zona Cobrador
        poDt.Columns.Add(New DataColumn("CCNCSC", GetType(System.String))) 'Centro de Costo
        poDt.Columns.Add(New DataColumn("CRGVTA", GetType(System.String))) 'Codigo Region Venta -.- Nuevo ACD

        poDt.Columns.Add(New DataColumn("CTPDCO", GetType(System.String))) 'Tipo Doc Origen -.- Nuevo ACD
        poDt.Columns.Add(New DataColumn("NDCMOR", GetType(System.String))) 'Doc ref origen -.- Nuevo ACD
        poDt.Columns.Add(New DataColumn("FDCMOR", GetType(System.String))) 'Fecha Doc origen -.- Nuevo ACD

        poDt.Columns.Add(New DataColumn("FACTURA", GetType(System.Decimal))) 'FACTURA SECUENCIA
        'csr-hotfix/031116_Visualizacion_Formato_Factura
        poDt.Columns.Add(New DataColumn("CUBIGE", GetType(System.String))) ' Codigo Ubigeo
        poDt.Columns.Add(New DataColumn("DIRSEV", GetType(System.String))) 'Direccion servicio
        poDt.Columns.Add(New DataColumn("CDIRSE", GetType(System.String)))
        'csr-hotfix/031116_Visualizacion_Formato_Factura
        poDt.Columns.Add(New DataColumn("DEDISE", GetType(System.String))) ''INTEGRACION-041116-RANSASELVA


        poDt.Columns.Add(New DataColumn("OCOMPRA", GetType(System.String))) ''OMVB REQ11072019 Orden de Compra
        poDt.Columns.Add(New DataColumn("CDDRSP", GetType(System.String))) ' CODIGO SAP CLIENTE
        poDt.Columns.Add(New DataColumn("CCLNOP", GetType(System.String)))

        poDt.Columns.Add(New DataColumn("NDSPGD", GetType(System.Decimal)))
        poDt.Columns.Add(New DataColumn("OIVLAFS", GetType(System.Decimal)))
        poDt.Columns.Add(New DataColumn("OIVLIGS", GetType(System.Decimal)))



    End Sub

    Public Sub Grabar_Factura_General(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtCabOperacion As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As String, dtVistaImpresionFact As DataTable, lstrIGV As Decimal, OCCliente As String, Es_PreDocumento As Boolean)

        Dim intCont As Integer
        Dim intRow As Integer
        Dim obj(2) As Object

        Dim objCab(30) As Object


        'Dim objDet(18) As Object
        Dim oDt As DataTable
        Dim dblNumFactura As Double
        Dim dblNumControl As Double

        Dim esFilaFinal As Boolean = False
        Dim oListFactDetMasivo As List(Of beFactura_Transporte)
        Dim oFactDet As beFactura_Transporte


        Dim oFactDetItem As FacturaElectronicaDet

        Dim listJsDetFact As New List(Of Dictionary(Of String, Object))
        Dim JsDetFact As Dictionary(Of String, Object)
        Dim MaxLineasDetFact As Integer = 100

        Dim drDet() As DataRow
        Dim CodCompania As String = ""

        For intCont = 0 To poDtCabFact.Rows.Count - 1
            If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                CodCompania = poDtCabFact.Rows(intCont).Item("CCMPN")
                objCab(0) = CodCompania
                objCab(1) = strCodTabla
                objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                objCab(27) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                objCab(28) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                objCab(29) = poDtCabFact.Rows(intCont).Item("CCNCSC")
                objCab(30) = poDtCabFact.Rows(intCont).Item("CRGVTA")
                oDt = oFacturaDato.Grabar_Cabecera_Factura(objCab)


                dblNumFactura = oDt.Rows(0).Item("NULCTR")
                dblNumControl = oDt.Rows(0).Item("NCTRRL")
                poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl


                For Each Item As DataRow In poDtCabOperacion.Rows
                    If Item("FACTURA") = pintFact Then
                        Item("NDCCTC") = dblNumFactura
                        Item("FDCCTC") = poDtCabFact.Rows(intCont).Item("FDCCTC")
                        Item("CTPODC") = poDtCabFact.Rows(intCont).Item("CTPODC")

                    End If

                Next

                drDet = poDtDetFact.Select("NDCCTC='" & pintFact & "'")

                oListFactDetMasivo = New List(Of beFactura_Transporte)


                For intRow = 0 To drDet.Length - 1


                    oFactDetItem = New FacturaElectronicaDet
                    oFactDetItem.CTPODC = drDet(intRow)("CTPODC")
                    oFactDetItem.NINDRN = drDet(intRow)("NINDRN")
                    oFactDetItem.NCRDCC = drDet(intRow)("NCRDCC")
                    oFactDetItem.CRBCTC = drDet(intRow)("CRBCTC")
                    oFactDetItem.STCCTC = ("" & drDet(intRow)("STCCTC")).ToString.Trim
                    oFactDetItem.CUNCNA = ("" & drDet(intRow)("CUNCNA")).ToString.Trim
                    oFactDetItem.QAPCTC = drDet(intRow)("QAPCTC")
                    oFactDetItem.CUTCTC = ("" & drDet(intRow)("CUTCTC")).ToString.Trim
                    oFactDetItem.ITRCTC = drDet(intRow)("ITRCTC")
                    oFactDetItem.IVLDCS = drDet(intRow)("IVLDCS")
                    oFactDetItem.IVLDCD = drDet(intRow)("IVLDCD")

                    oFactDetItem.FDCCTC = drDet(intRow)("FDCCTC")
                    oFactDetItem.CDVSN = drDet(intRow)("CDVSN")
                    oFactDetItem.CGRNGD = ("" & drDet(intRow)("CGRNGD")).ToString.Trim
                    oFactDetItem.CCNCSD = drDet(intRow)("CCNCSD")


                    JsDetFact = New Dictionary(Of String, Object)
                  
                    JsDetFact.Add("NCRDCC", oFactDetItem.NCRDCC)
                    JsDetFact.Add("CRBCTC", oFactDetItem.CRBCTC)
                    JsDetFact.Add("STCCTC", oFactDetItem.STCCTC)
                    JsDetFact.Add("CUNCNA", oFactDetItem.CUNCNA)
                    JsDetFact.Add("QAPCTC", oFactDetItem.QAPCTC)
                    JsDetFact.Add("CUTCTC", oFactDetItem.CUTCTC)
                    JsDetFact.Add("ITRCTC", oFactDetItem.ITRCTC)
                    JsDetFact.Add("IVLDCS", oFactDetItem.IVLDCS)
                    JsDetFact.Add("IVLDCD", oFactDetItem.IVLDCD)                   
                    JsDetFact.Add("CDVSN", oFactDetItem.CDVSN)
                    JsDetFact.Add("CGRNGD", oFactDetItem.CGRNGD)
                    JsDetFact.Add("CCNCSD", oFactDetItem.CCNCSD)

                    listJsDetFact.Add(JsDetFact)

                    esFilaFinal = (intRow = drDet.Length - 1)

                    If (listJsDetFact.Count >= MaxLineasDetFact Or esFilaFinal = True) Then
                        Dim StrJson As String = JsonConvert.SerializeObject(listJsDetFact)
                        oFactDet = New beFactura_Transporte
                        oFactDet.CCMPN = CodCompania
                        oFactDet.LISTJSON = StrJson
                        oFactDet.CTPODC = oFactDetItem.CTPODC
                        oFactDet.NDCCTC = dblNumFactura
                        oFactDet.NINDRN = oFactDetItem.NINDRN
                        oFactDet.NCTDCC = dblNumControl
                        oFactDet.FDCCTC = oFactDetItem.FDCCTC
 

                        oListFactDetMasivo.Add(oFactDet)

                        listJsDetFact = New List(Of Dictionary(Of String, Object))

                    End If


                Next

                For Each item As beFactura_Transporte In oListFactDetMasivo
                    oFacturaDato.Grabar_Detalle_Factura_Masivo(item)
                Next
                For intRow = 0 To poDtDetFact.Rows.Count - 1
                    If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                        poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                        poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                    End If
                Next
                Grabar_Vista_Factura_Electronica(poDtCabFact.Rows(intCont), dtVistaImpresionFact, OCCliente, lstrIGV, Es_PreDocumento)


                If oTipoDocumento = 51 OrElse oTipoDocumento = 52 OrElse oTipoDocumento = 1 OrElse oTipoDocumento = 2 Then

                    Dim obeEntidad As New FacturaHistorialCab
                    With obeEntidad
                        .PSCCMPN = poDtCabFact.Rows(intCont).Item("CCMPN")
                        .PNCTPODC = poDtCabFact.Rows(intCont).Item("CTPODC")
                        .PNNDCFCC = poDtCabFact.Rows(intCont).Item("NDCCTC")
                    End With
                    fintActualizarFacturaDetracionSPOT(obeEntidad)

                End If


                Exit For
            End If
        Next intCont
        pstrNumFac = dblNumFactura


        Dim JsDetHist As Dictionary(Of String, Object)
        Dim ListJsDetHist As New List(Of Dictionary(Of String, Object))
        Dim MaxLineasHistorial As Integer = 100
        Dim oHistDet As FacturaHistorialDet
        Dim oHistEnvio As FacturaHistorialDet
        Dim oListoHistDetMasivo As New List(Of FacturaHistorialDet)
        Dim FlagAprob As String = ""
        Dim UsuAprob As String = ""

        For intCount As Integer = 0 To poDtCabOperacion.Rows.Count - 1
            oHistDet = New FacturaHistorialDet

            FlagAprob = ("" & poDtCabOperacion.Rows(intCount)("FLGAPR")).ToString.Trim
            UsuAprob = ("" & poDtCabOperacion.Rows(intCount)("USRCCO")).ToString.Trim
            oHistDet.PNNOPRCN = poDtCabOperacion.Rows(intCount)("NOPRCN")
            oHistDet.PNNRTFSV = poDtCabOperacion.Rows(intCount)("NRTFSV")
            oHistDet.PNCTPODC = poDtCabOperacion.Rows(intCount)("CTPODC")
            oHistDet.PNNDCFCC = poDtCabOperacion.Rows(intCount)("NDCCTC")
            oHistDet.PNNCRDCC = poDtCabOperacion.Rows(intCount)("NCRDCC")
            oHistDet.PNNCRROP = poDtCabOperacion.Rows(intCount)("NCRROP")
            oHistDet.PNNPRLQD = poDtCabOperacion.Rows(intCount)("NPRLQD")
            oHistDet.PNNPREDOC = poDtCabOperacion.Rows(intCount)("NPREDOC")
            oHistDet.PNCCLNT = poDtCabOperacion.Rows(intCount)("CCLNT")


            JsDetHist = New Dictionary(Of String, Object)

            JsDetHist.Add("NOPRCN", oHistDet.PNNOPRCN)
            JsDetHist.Add("NRTFSV", oHistDet.PNNRTFSV)
            JsDetHist.Add("NCRDCC", oHistDet.PNNCRDCC)
            JsDetHist.Add("FLGAPR", oHistDet.PSFLGAPR)
            JsDetHist.Add("USRCCO", oHistDet.PSUSRCCO)
            JsDetHist.Add("NCRROP", oHistDet.PNNCRROP)
            JsDetHist.Add("CCLNT", oHistDet.PNCCLNT)
            JsDetHist.Add("NPRLQD", oHistDet.PNNPRLQD)
            JsDetHist.Add("NPREDOC", oHistDet.PNNPREDOC)
            ListJsDetHist.Add(JsDetHist)

            esFilaFinal = (intCount = poDtCabOperacion.Rows.Count - 1)

            If (ListJsDetHist.Count >= MaxLineasHistorial Or esFilaFinal = True) Then
                Dim StrJson As String = JsonConvert.SerializeObject(ListJsDetHist)
                oHistEnvio = New FacturaHistorialDet
                oHistEnvio.PSCCMPN = poDtCabOperacion.Rows(0)("CCMPN")
                oHistEnvio.PNCTPODC = oHistDet.PNCTPODC
                oHistEnvio.PNNDCFCC = oHistDet.PNNDCFCC
                oHistEnvio.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                oHistEnvio.LISTJSON = StrJson
                oListoHistDetMasivo.Add(oHistEnvio)
                ListJsDetHist = New List(Of Dictionary(Of String, Object))

            End If

        Next

        For Each item As FacturaHistorialDet In oListoHistDetMasivo
            oFacturaDato.Actualizar_Detalle_Facturado_X_Operacion_Masivo(item)
        Next




    End Sub

    Private Sub Grabar_Vista_Factura_Electronica(poDtCabFact As DataRow, dtVistaImpresion As DataTable, OCCliente As String, lstrIGV As Decimal, Es_PreDocumento As Boolean)

        Dim objFact_Cab_FE As New FacturaElectronica
        Dim objFact_Det_FE As FacturaElectronicaDet
        Dim Negocio_FE As New SOLMIN_CTZ.NEGOCIO.clsFactura

        Dim C_IVLIGS, C_ITTFCS, C_IVLDCS As Decimal

        Dim SOLDOL As String = ("" & poDtCabFact("CMNDA")).ToString.Trim
        Dim strIVLDC As String = IIf(SOLDOL = 100, "IVLDCD", "IVLDCS")

        For Each ITEM As DataRow In dtVistaImpresion.Rows
            If ITEM("CRBCTC") <> "999" Then
                C_IVLDCS = C_IVLDCS + CDec(ITEM(strIVLDC))
            End If
            If ITEM("CRBCTC") = "999" Then
                C_IVLIGS = C_IVLIGS + CDec(ITEM(strIVLDC))
            End If
        Next
        C_ITTFCS = C_IVLDCS + C_IVLIGS


        objFact_Cab_FE.CCMPN = poDtCabFact("CCMPN")
        objFact_Cab_FE.NDCCTC = poDtCabFact("NDCCTC")
        objFact_Cab_FE.CTPODC = poDtCabFact("CTPODC")
        objFact_Cab_FE.NINDRN = poDtCabFact("NINDRN")
        objFact_Cab_FE.FDCCTC = poDtCabFact("FDCCTC")
        objFact_Cab_FE.CRGVTA = poDtCabFact("CRGVTA")
        objFact_Cab_FE.CTPCTR = PuntoVenta
        objFact_Cab_FE.CCLNT = poDtCabFact("CCLNT") ' Código  cliente
        objFact_Cab_FE.CUBIGE = poDtCabFact("CUBIGE")
        objFact_Cab_FE.DIRSEV = poDtCabFact("DEDISE")
        'csr-hotfix/031116_Visualizacion_Formato_Factura     
        objFact_Cab_FE.CCLNOP = poDtCabFact("CCLNOP")
        objFact_Cab_FE.CDDRSP = poDtCabFact("CDDRSP")   'Código Cliente SAP 
        objFact_Cab_FE.CGRONG = poDtCabFact("CGRONG")    'Código Tipo de deposito
        objFact_Cab_FE.CZNFCC = poDtCabFact("CZNFCC")   ' Zona Cobranza        
        objFact_Cab_FE.CMNDA = poDtCabFact("CMNDA")   'pIdMoneda
        objFact_Cab_FE.NFORFA = 0 'Estado de forma de impresion  
        objFact_Cab_FE.OC_CLIENTE = OCCliente '  strOCompra
        objFact_Cab_FE.NDSPGD = poDtCabFact("NDSPGD")
        objFact_Cab_FE.IVLDCS = C_IVLDCS
        objFact_Cab_FE.PIGVA = lstrIGV
        objFact_Cab_FE.IVLIGS = C_IVLIGS
        objFact_Cab_FE.ITTFCS = C_ITTFCS

        If Es_PreDocumento = True Then
            objFact_Cab_FE.ES_PREDOCUMENTO = "S"
        Else
            objFact_Cab_FE.ES_PREDOCUMENTO = ""
        End If


        Negocio_FE.Grabar_Cabecera_Factura_ELectronica(objFact_Cab_FE) 'GRABAR FACTURA ELECTRONICA CABECERA

        Dim drDet() As DataRow

      
        

        drDet = dtVistaImpresion.Select("CRBCTC<>'" & 999 & "'")
        Dim JsDetFactE = New Dictionary(Of String, Object)
        Dim listJsDetFactE As New List(Of Dictionary(Of String, Object))

        Dim intCont As Integer = 0
        Dim esFilaFinal As Boolean = False
        Dim MaxLineasDetFact As Integer = 100

        Dim odetFactE As FacturaElectronicaDet
        Dim oListdetFactEMasivo As New List(Of FacturaElectronicaDet)

        For intCont = 0 To drDet.Length - 1
            objFact_Det_FE = New FacturaElectronicaDet

            objFact_Det_FE.CCMPN = drDet(intCont)("CCMPN")
            objFact_Det_FE.NDCCTC = poDtCabFact("NDCCTC")
            objFact_Det_FE.CTPODC = drDet(intCont)("CTPODC")
            objFact_Det_FE.NCRDCC = drDet(intCont)("NCRDCC")
            objFact_Det_FE.NINDRN = drDet(intCont)("NINDRN")
            objFact_Det_FE.NOMSER = ("" & drDet(intCont)("TCMTRF"))  'Descripcion del rubro
            objFact_Det_FE.TOBCTC = ("" & drDet(intCont)("TOBS"))   ' observacion
            objFact_Det_FE.CSRVNV = drDet(intCont)("CRBCTC")   'codigo rubro
            objFact_Det_FE.QAPCTC = drDet(intCont)("QAPCTC")   'Cantidad 
            objFact_Det_FE.CUNCNA = drDet(intCont)("CUNCNA")  ' Unidad Medida
            objFact_Det_FE.ITRCTC = drDet(intCont)("ITRCTC")  'Tarifa
            objFact_Det_FE.IVLDCS = drDet(intCont)(strIVLDC)


            JsDetFactE = New Dictionary(Of String, Object)

            JsDetFactE.Add("NCRDCC", objFact_Det_FE.NCRDCC)
            JsDetFactE.Add("CSRVNV", objFact_Det_FE.CSRVNV)
            JsDetFactE.Add("NOMSER", objFact_Det_FE.NOMSER)
            JsDetFactE.Add("TOBCTC", objFact_Det_FE.TOBCTC)
            JsDetFactE.Add("QAPCTC", objFact_Det_FE.QAPCTC)
            JsDetFactE.Add("CUNCNA", objFact_Det_FE.CUNCNA)
            JsDetFactE.Add("ITRCTC", objFact_Det_FE.ITRCTC)
            JsDetFactE.Add("IVLDCS", objFact_Det_FE.IVLDCS)
            listJsDetFactE.Add(JsDetFactE)

            esFilaFinal = (intCont = drDet.Length - 1)

            If (listJsDetFactE.Count >= MaxLineasDetFact Or esFilaFinal = True) Then
                Dim StrJson As String = JsonConvert.SerializeObject(listJsDetFactE)

                odetFactE = New FacturaElectronicaDet
                odetFactE.CCMPN = objFact_Det_FE.CCMPN
                odetFactE.CTPODC = objFact_Det_FE.CTPODC
                odetFactE.NDCCTC = objFact_Det_FE.NDCCTC
                odetFactE.NINDRN = objFact_Det_FE.NINDRN
                odetFactE.LISTJSON = StrJson
                oListdetFactEMasivo.Add(odetFactE)
                listJsDetFactE = New List(Of Dictionary(Of String, Object))

            End If
        Next

        For Each item As FacturaElectronicaDet In oListdetFactEMasivo
            oFacturaDato.Grabar_Detalle_Factura_Electronica_Masivo(item)
        Next



    End Sub
    Public Sub Grabar_Factura(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As String)

        Dim intCont As Integer
        Dim intRow As Integer
        Dim obj(2) As Object

        Dim objCab(30) As Object


        Dim objDet(18) As Object
        Dim oDt As DataTable
        Dim dblNumFactura As Double
        Dim dblNumControl As Double

        For intCont = 0 To poDtCabFact.Rows.Count - 1
            If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                objCab(0) = poDtCabFact.Rows(intCont).Item("CCMPN")
                objCab(1) = strCodTabla
                objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                objCab(27) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                objCab(28) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                objCab(29) = poDtCabFact.Rows(intCont).Item("CCNCSC")

                objCab(30) = poDtCabFact.Rows(intCont).Item("CRGVTA")

                 

                oDt = oFacturaDato.Grabar_Cabecera_Factura(objCab)




                dblNumFactura = oDt.Rows(0).Item("NULCTR")
                dblNumControl = oDt.Rows(0).Item("NCTRRL")
                poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl
                For intRow = 0 To poDtDetFact.Rows.Count - 1
                    If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                        objDet(0) = poDtDetFact.Rows(intRow).Item("CCMPN")
                        objDet(1) = poDtDetFact.Rows(intRow).Item("CTPODC")
                        objDet(2) = dblNumFactura
                        objDet(3) = poDtDetFact.Rows(intRow).Item("NINDRN")
                        objDet(4) = poDtDetFact.Rows(intRow).Item("NCRDCC")
                        objDet(5) = poDtDetFact.Rows(intRow).Item("CRBCTC")
                        objDet(6) = poDtDetFact.Rows(intRow).Item("STCCTC")
                        objDet(7) = poDtDetFact.Rows(intRow).Item("CUNCNA")
                        objDet(8) = poDtDetFact.Rows(intRow).Item("QAPCTC")
                        objDet(9) = poDtDetFact.Rows(intRow).Item("CUTCTC")
                        objDet(10) = poDtDetFact.Rows(intRow).Item("ITRCTC")
                        objDet(11) = poDtDetFact.Rows(intRow).Item("IVLDCS")
                        objDet(12) = poDtDetFact.Rows(intRow).Item("IVLDCD")
                        objDet(13) = dblNumControl
                        objDet(14) = poDtDetFact.Rows(intRow).Item("FDCCTC")
                        objDet(15) = poDtDetFact.Rows(intRow).Item("CDVSN")
                        objDet(16) = poDtDetFact.Rows(intRow).Item("CGRNGD")
                        If IsDBNull(poDtDetFact.Rows(intRow).Item("CCNCSD")) Then
                            objDet(17) = 0
                        Else
                            objDet(17) = poDtDetFact.Rows(intRow).Item("CCNCSD")
                        End If
                        oFacturaDato.Grabar_Detalle_Factura(objDet)
                        poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                        poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                    End If
                Next intRow




                Exit For
            End If
        Next intCont
        pstrNumFac = dblNumFactura

    End Sub



    Private Function EsParaRefactura(ByVal pintFact As Int32) As String

        Dim FlgRefact As String = ""
        Dim FlgLib As String = ""

        If ListaoFact IsNot Nothing AndAlso ListaoFact.Count > 0 Then

            For Each Item As FacturaSIL In ListaoFact
                If Item.LIBERAR = "S" Then
                    FlgLib = "SI"
                    Exit For
                End If
            Next

        End If


        If FlgLib = "SI" Then
            FlgRefact = "X"
        Else
            FlgRefact = ""
        End If
        Return FlgRefact




    End Function

   


    Private Function ListaReferenciaFilas(ByVal pstrObs As String, ByVal numFilasMax As Int32) As SortedList
        Dim itemFila As Int32 = 0
        Dim HasFilas As New SortedList
        Dim textoTempo As String = ""
        For Each Item As String In pstrObs.Split(Chr(13))
            textoTempo = Item
            If itemFila > 0 Then
                textoTempo = "|" & Item
            End If
            textoTempo = textoTempo.Replace(Chr(10), "")
            If textoTempo.Trim.Length > 0 Then
                While textoTempo.Length > 0
                    If textoTempo.Length > 70 Then
                        HasFilas(HasFilas.Count - 1) = textoTempo.Substring(0, 69)
                        textoTempo = textoTempo.Substring(69, textoTempo.Length - 69)
                    Else
                        HasFilas(HasFilas.Count - 1) = textoTempo
                        textoTempo = ""
                    End If
                End While
                itemFila = itemFila + 1
                If itemFila >= numFilasMax Then
                    Exit For
                End If
            End If
        Next
        Return HasFilas
    End Function

     
    Public Sub Grabar_Referencia_Factura(ByVal pintFact As Integer, ByVal pintReferencia As Integer, ByVal poDtCabFact As DataTable, ByVal pstrObs As String, ByVal strNumFact As String)

        If pstrObs.Trim <> "" Then
        
            Dim objObs(6) As Object
            Dim strObs() As String
            Dim strObservacion As String = ""

            Dim CodCompania As String = ""
            Dim TipoDoc As Decimal = 0
            Dim IndRenov As Decimal = 0
            Dim drFact() As DataRow
            drFact = poDtCabFact.Select("NDCCTC='" & pintFact & "'")
            If drFact.Length > 0 Then
                CodCompania = drFact(0)("CCMPN").ToString.Trim
                TipoDoc = drFact(0)("CTPODC")
                IndRenov = drFact(0)("NINDRN")
            End If
 

            Dim MaxFilasTipoRef As Int32 = 0
            Select Case pintReferencia
                Case 1
                    MaxFilasTipoRef = 4
                    If pstrObs.Length > 340 Then
                        pstrObs = pstrObs.Substring(0, 340)
                    End If
                Case 2
                    If pstrObs.Length > 920 Then
                        pstrObs = pstrObs.Substring(0, 920)
                    End If
                    MaxFilasTipoRef = 8
            End Select

            Dim itemFila As Int32 = 0
            Dim textoTempo As String = ""
            Dim NumFilasAd As Int32 = 0
            For Each Item As String In pstrObs.Split(Chr(13))
                textoTempo = Item.Trim
                textoTempo = textoTempo.Replace(Chr(10), "")
                If textoTempo.Length > 0 Then
                    If textoTempo.Length > 70 Then
                        strObservacion = Mid(textoTempo, 1, 70)
                    Else
                        strObservacion = textoTempo.Trim
                    End If

                    objObs(0) = CodCompania

                    objObs(1) = TipoDoc
                    objObs(2) = strNumFact

                    objObs(3) = IndRenov
                    objObs(4) = pintReferencia
                    objObs(5) = strObservacion
                    oFacturaDato.Grabar_Referencia_Factura(objObs)
                    NumFilasAd = NumFilasAd + 1
                    If NumFilasAd >= MaxFilasTipoRef Then
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub


    Public Function Formar_Referencia_Factura(ByVal pintReferencia As Integer, ByVal pstrObs As String) As DataTable

        Dim dtObs As New DataTable
        Dim dr As DataRow
        dtObs.Columns.Add("TIPO")
        dtObs.Columns.Add("OBS")

 

        If pstrObs.Trim <> "" Then
            Dim strObservacion As String = ""
            Dim MaxFilasTipoRef As Int32 = 0
            Select Case pintReferencia
                Case 1
                    MaxFilasTipoRef = 4
                    If pstrObs.Length > 340 Then
                        pstrObs = pstrObs.Substring(0, 340)
                    End If
                Case 2
                    If pstrObs.Length > 920 Then
                        pstrObs = pstrObs.Substring(0, 920)
                    End If
                    MaxFilasTipoRef = 8
            End Select

            Dim itemFila As Int32 = 0
            Dim textoTempo As String = ""
            Dim NumFilasAd As Int32 = 0
            For Each Item As String In pstrObs.Split(Chr(13))
                textoTempo = Item.Trim
                textoTempo = textoTempo.Replace(Chr(10), "")
                If textoTempo.Length > 0 Then
                    If textoTempo.Length > 70 Then
                        strObservacion = Mid(textoTempo, 1, 70)
                    Else
                        strObservacion = textoTempo.Trim
                    End If
                    dr = dtObs.NewRow
                    dr("TIPO") = pintReferencia
                    dr("OBS") = strObservacion
                    dtObs.Rows.Add(dr)
                    NumFilasAd = NumFilasAd + 1
                    If NumFilasAd >= MaxFilasTipoRef Then
                        Exit For
                    End If
                End If
            Next
        End If
        Return dtObs
    End Function



  


    Public Sub Grabar_ReferenciaMasivaJS_Factura(oFact As FacturaElectronicaDet, dtobsCab As DataTable, ByVal dtobsDet As DataTable)
 

        Dim StrJson As String = ""
        Dim dr As DataRow

        Dim JsObs As Dictionary(Of String, Object)
        Dim listJsObs As New List(Of Dictionary(Of String, Object))


        For Each item As DataRow In dtobsDet.Rows
            dr = dtobsCab.NewRow()
            dr("TIPO") = item("TIPO")
            dr("OBS") = item("OBS")
            dtobsCab.Rows.Add(dr)
        Next

        For FILA As Int32 = 0 To dtobsCab.Rows.Count - 1
            JsObs = New Dictionary(Of String, Object)
            JsObs.Add("TIPO", dtobsCab.Rows(FILA)("TIPO"))
            JsObs.Add("OBS", dtobsCab.Rows(FILA)("OBS"))

            listJsObs.Add(JsObs)
        Next
        If listJsObs.Count > 0 Then
            StrJson = JsonConvert.SerializeObject(listJsObs)
            oFact.LISTJSON = StrJson
            oFacturaDato.Grabar_Referencia_Factura_MasivoJS(oFact)
        End If

    End Sub
   



    Public Sub Limpiar_Datos_Factura()
        oDtCabecera = New DataTable
    End Sub

    Public Function Lista_Datos_Servicio(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Datos_Servicio(pobjFiltro)
    End Function

    Public Sub Enviar_Documento_SAP(ByVal pobjFiltro As Filtro)
        Try
            oFacturaDato.Enviar_Documento_SAP(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Detalle_Facturado(ByVal pobjFiltro As Filtro)
        Try
            oFacturaDato.Actualizar_Detalle_Facturado(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Detalle_Facturado_X_Revision(ByVal pobjFiltro As Filtro)
        Try
            oFacturaDato.Actualizar_Detalle_Facturado_X_Revision(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub Actualizar_Detalle_Facturado_X_Operacion_V2(ByVal obeFacturaHistorialDet As FacturaHistorialDet)

        oFacturaDato.Actualizar_Detalle_Facturado_X_Operacion_V2(obeFacturaHistorialDet)

    End Sub

 


    Public Function fintRevertirProvisionXFacturaAdmin(ByVal pobjFiltro As Hashtable, EsxPorPreDocumento As Boolean) As Integer
        Return oFacturaDato.fintRevertirProvisionXFacturaAdmin(pobjFiltro, EsxPorPreDocumento)
    End Function


    Public Function Comprobar_Envio_Documento_SAP(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Comprobar_Envio_Documento_SAP(pobjFiltro)
    End Function

    Public Function Lista_Datos_Factura(ByVal pobjFiltro As Filtro) As DataSet
        Return oFacturaDato.Lista_Datos_Factura(pobjFiltro)
    End Function

    Public Function Lista_Datos_Factura_Transporte(ByVal pobjFiltro As Hashtable) As DataSet
        Return oFacturaDato.Lista_Datos_Factura_Transporte(pobjFiltro)
    End Function

    Public Function Obtener_Valor_Referencial(ByVal pobjFiltro As Hashtable) As Double
        Return oFacturaDato.Obtener_Valor_Referencial(pobjFiltro)
    End Function

    Public Function Obtener_Tipo_Factura(ByVal pobjFiltro As Hashtable) As Double
        Return oFacturaDato.Obtener_Tipo_Factura(pobjFiltro)
    End Function

    Public Function Lista_Referencia_Factura_SIL(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Referencia_Factura_SIL(pobjFiltro)
    End Function


    Public Function Lista_Referencia_RecuperoSeguroCarga(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Referencia_RecuperoSeguroCarga(pobjFiltro)
    End Function

    Public Function Lista_Observacion_Factura_SIL(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Observacion_Factura_SIL(pobjFiltro)
    End Function



    Public Function FechaActualServidor() As Date
        Return oFacturaDato.FechaActualServidor()
    End Function

    Public Function fstrValidarClienteSAP(ByVal objParameter As Hashtable, ByRef strEstado As String) As String
        Dim strResultado As String = ""
        Dim strMensaje As String = ""
        strResultado = oFacturaDato.fstrValidarClienteSAP(objParameter)
        If strResultado <> "" Then
            strEstado = strResultado.Substring(0, 1)
            Select Case strEstado
                Case "B"
                    strMensaje = strResultado.Substring(2)
                Case "C"
                    strMensaje = strResultado.Substring(2)
                Case "D"
                    strMensaje = strResultado.Substring(2)
            End Select

        End If
        Return strMensaje
    End Function


    Public Function Lista_Detalle_ServiciosXRevision_V2(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Detalle_ServiciosXRevision_V2(pobjFiltro)
    End Function

    Public Function Lista_Detalle_ServiciosXOperacion_V2(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Detalle_ServiciosXOperacion_V2(pobjFiltro)
    End Function



    Public Function Lista_Operaciones_Historial_x_Cliente(ByVal CCLNT As Decimal, ByVal NOPRCN As Decimal, ByVal LIST_NCRROP As String, ByVal CTPODC As Decimal, ByVal NDCCTC As Decimal) As DataTable
        Dim dt As New DataTable

        dt = oFacturaDato.Lista_Operaciones_Historial_x_Cliente(CCLNT, NOPRCN, LIST_NCRROP, CTPODC, NDCCTC)

        Return dt
    End Function



    Public Function Lista_Dato_General_Documento(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As DataTable
        Return oFacturaDato.Lista_Dato_General_Documento(obeFacturaHistorialCab)
    End Function

    Public Function fintActualizarFacturaDetracionSPOT(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As Integer
        Return oFacturaDato.fintActualizarFacturaDetracionSPOT(obeFacturaHistorialCab)
    End Function

    Public Function Lista_Datos_Adicionales_Factura(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Datos_Adicionales_Factura(pobjFiltro)
    End Function

    'CSR-HUNDRED-INICIO

    Public Function Estimacion_Ingreso_Revertir(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Estimacion_Ingreso_Revertir(pobjFiltro)
    End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

#Region "REFACTURA"

    Public Function ListaServiciosxOperacionActualizados(ByVal NOPRCN As Decimal) As DataTable
        Dim odtFormatoServicio As New DataTable
        odtFormatoServicio.Columns.Add("CCLNT", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("CCMPN", GetType(System.String))
        odtFormatoServicio.Columns.Add("CDVSN", GetType(System.String))
        odtFormatoServicio.Columns.Add("CSRVNV", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("NOPRCN", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("TCMTRF", GetType(System.String))
        odtFormatoServicio.Columns.Add("QATNAN", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("CUNDMD", GetType(System.String))
        odtFormatoServicio.Columns.Add("NRTFSV", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("IVLSRV", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("TOTAL", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("CTIGVA", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("PIGVA", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("SRBAFD", GetType(System.String))
        odtFormatoServicio.Columns.Add("IAFCDT", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("IPRCDT", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("CMNDA1", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("TSGNMN", GetType(System.String))
        odtFormatoServicio.Columns.Add("CCNTCS", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("NRRUBR", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("NCRDCC", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("NDCFCC", GetType(System.Decimal))
        odtFormatoServicio.Columns.Add("NCRROP", GetType(System.String))
        odtFormatoServicio.Columns.Add("DEDISE", GetType(System.String)) 'csr-hotfix/031116_Visualizacion_Formato_Factura
        odtFormatoServicio.Columns.Add("IMP_ORIGEN_SOL", GetType(System.Decimal))

        Dim drS() As DataRow
        Dim dr As DataRow

        drS = dtServiciosTodosOp.Select("NOPRCN='" & NOPRCN & "'")
        Dim ListVisitado As New Hashtable
        Dim CodUnico As String = ""
        Dim FilaUpdate As Int64 = 0
        For FILA As Int64 = 0 To drS.Length - 1
            CodUnico = ""
            CodUnico = drS(FILA)("CCLNT") & "_" & drS(FILA)("CSRVNV") & "_" & drS(FILA)("NRTFSV") & "_" & drS(FILA)("CCNTCS") & "_" & drS(FILA)("IVLSRV")

            If Not ListVisitado.Contains(CodUnico) Then
                dr = odtFormatoServicio.NewRow
                dr("CCLNT") = drS(FILA)("CCLNT")
                dr("CCMPN") = drS(FILA)("CCMPN")
                dr("CDVSN") = drS(FILA)("CDVSN")
                dr("CSRVNV") = drS(FILA)("CSRVNV")
                dr("NOPRCN") = drS(FILA)("NOPRCN")
                dr("TCMTRF") = drS(FILA)("TCMTRF")
                dr("CUNDMD") = drS(FILA)("CUNDMD")
                dr("NRTFSV") = drS(FILA)("NRTFSV")
                dr("CTIGVA") = drS(FILA)("CTIGVA")
                dr("PIGVA") = drS(FILA)("PIGVA")
                dr("SRBAFD") = drS(FILA)("SRBAFD")
                dr("IAFCDT") = drS(FILA)("IAFCDT")
                dr("IPRCDT") = drS(FILA)("IPRCDT")
                dr("CMNDA1") = drS(FILA)("CMNDA1")
                dr("CCNTCS") = drS(FILA)("CCNTCS")
                dr("NRRUBR") = drS(FILA)("NRRUBR")
                dr("TSGNMN") = drS(FILA)("TSGNMN")
                dr("TOTAL") = drS(FILA)("MONTO")
                dr("NCRDCC") = drS(FILA)("NCRDCC")
                dr("NDCFCC") = drS(FILA)("NDCFCC")
                dr("QATNAN") = drS(FILA)("QATNAN")
                dr("IVLSRV") = drS(FILA)("IVLSRV")
                dr("NCRROP") = drS(FILA)("NCRROP")
                dr("DEDISE") = drS(FILA)("DEDISE") 'csr-hotfix/031116_Visualizacion_Formato_Factura
                dr("IMP_ORIGEN_SOL") = drS(FILA)("IMP_ORIGEN_SOL")
                odtFormatoServicio.Rows.Add(dr)

                ListVisitado.Add(CodUnico, odtFormatoServicio.Rows.Count - 1)
            Else
                FilaUpdate = ListVisitado(CodUnico)

                odtFormatoServicio.Rows(FilaUpdate)("TOTAL") = odtFormatoServicio.Rows(FilaUpdate)("TOTAL") + drS(FILA)("MONTO")
                odtFormatoServicio.Rows(FilaUpdate)("QATNAN") = odtFormatoServicio.Rows(FilaUpdate)("QATNAN") + drS(FILA)("QATNAN")
            End If
        Next
        Return odtFormatoServicio
    End Function

    Public Sub Lista_Documentos_Permitidos_Refactura(ByVal pobjFiltro As Filtro)
        oDtDocumentos = oFacturaDato.Lista_Documentos_Permitidos_Refactura(pobjFiltro)
    End Sub

 
    Public Function Lista_Punto_Venta_FE(ByVal pobjFiltro As Hashtable) As DataTable
        Return oFacturaDato.Lista_Punto_Venta_FE(pobjFiltro)
    End Function

   

    Public Function Lista_Detalle_Factura_Refactura(ByVal ListaFact As List(Of SOLMIN_CTZ.Entidades.FacturaSIL), ByVal pobjFiltro As Filtro, ByRef phashIGV As Hashtable, ByRef pHtOperacioFacturar As Hashtable, ByVal pintTipo As Integer) As DataTable 'ByRef pdblIGV As Decimal
        Dim SubTotalSol As Decimal = 0
        Dim oDt As New DataTable
        Dim oDtServicios As DataTable = Nothing
        Dim oDtFactura As DataTable
        Dim intCont, intDetalle As Integer
        Dim intNumFactura As Integer = 0
        Dim dblCenCos, dblCenCosMax As Double
        Dim dblTotalCant As Double
        Dim dblTotalMonto As Double
        Dim bolMismaUnidad As Boolean = True
        Dim bolMismaTarifa As Boolean = True
        Dim bolMismoCCosto As Boolean = True

        ListaFactor = ListaFact

        '****adicionado
        Dim bolValorServicio As Boolean = True
        '************
        Dim dblTarifaAnt As Double = 0
        Dim oDr As DataRow
        Dim oDrDet() As DataRow
        Dim sUnidad As String = ""
        Dim CodServicio As String
        Dim intTotalItems, intNumItems, intContador As Integer
        Dim oDrItemCenCos() As DataRow
        Dim dblPorIgv As Double
        Dim oDtAux As New DataTable

        '--Agregado ACD--
        Dim objHas As Hashtable
        Dim objLista As List(Of Hashtable)
        '--FIN Agregado ACD--

        '--Agregado Por Abraham Zorrilla
        Dim oDtDetalleFac As New DataTable
        '--Fin AZP--

        'If AccionRefactura = 1 And dblTipoDoc = 3 Then 'cargar datos
        If AccionRefactura = 1 And oTipoDocumento = 3 Then 'cargar datos
            dblTipoCambio = dblTipoCambioDocOrigen
        End If


        If oDt.Columns.Count = 0 Then
            Crear_Estructura_Detalle(oDt)
            oDtDetalleFac = oDt.Clone
        End If
        For intCant As Integer = 0 To ListaFact.Count - 1
            pobjFiltro.Parametro1 = ListaFact(intCant).NOPRCN
            oDtAux = ListaServiciosxOperacionActualizados(ListaFact(intCant).NOPRCN)
            If intCant = 0 Then oDtServicios = oDtAux.Clone
            For Each dr As DataRow In oDtAux.Rows
                oDtServicios.ImportRow(dr)
            Next
        Next

        oDtServicios.DefaultView.Sort = "CSRVNV, NRTFSV,CCNTCS,CUNDMD,IVLSRV ASC"
        oDtServicios = oDtServicios.DefaultView.ToTable

        Dim oDsFactura As New DataSet
        Dim oDtOperacionFacturar As New DataTable
        Dim oDtDetalleFactura As New DataTable
        oDtOperacionFacturar.TableName = "SERVICIOS"
        oDtDetalleFactura.TableName = "DETALLE_FACTURA"

        pHtOperacioFacturar = New Hashtable
        'Limpiamos la variable
        objRegistroItemFactura.Clear()

 


        While (1) 'Se repite por la cantidad de Facturas
            '-------------------------------------------------------------------------------
            intNumFactura = intNumFactura + 1
            oDsFactura = New DataSet
            If intNumFactura > pobjFiltro.Parametro2 Then
                Exit While
            End If
            If Not (ListaFact(0).CTPODC = "57" Or ListaFact(0).CTPODC = "7") Then
                oDtFactura = Detalle_Factura(oDtServicios, intNumFactura)
            Else
                oDtFactura = oDtServicios.Copy
            End If

 

            'Agregamos las operaciones que se van actualizar al grabar la factura
            oDtOperacionFacturar = New DataTable
            oDtOperacionFacturar.Columns.Add("NOPRCN")
            oDtOperacionFacturar.Columns.Add("NRTFSV")
            oDtOperacionFacturar.Columns.Add("FACTURA")
            oDtOperacionFacturar.Columns.Add("NRRUBR")
            oDtOperacionFacturar.Columns.Add("NCRDCC")

            oDtOperacionFacturar.Columns.Add("CSRVNV")
            oDtOperacionFacturar.Columns.Add("CCNTCS")
            oDtOperacionFacturar.Columns.Add("IVLSRV")

            oDtOperacionFacturar.Columns.Add("NCRROP")
            oDtOperacionFacturar.Columns.Add("CTPODC")
            oDtOperacionFacturar.Columns.Add("NDCCTC")
            oDtOperacionFacturar.Columns.Add("FDCCTC")
            oDtOperacionFacturar.Columns.Add("CCMPN")
            oDtOperacionFacturar.Columns.Add("CCLNT")
            oDtOperacionFacturar.Columns.Add("CMNDA1")
            oDtOperacionFacturar.Columns.Add("QATNAN")
            oDtOperacionFacturar.Columns.Add("TOTAL")
            oDtOperacionFacturar.Columns.Add("CDVSN")
            oDtOperacionFacturar.Columns.Add("CUNDMD")
            oDtOperacionFacturar.Columns.Add("IMP_ORIGEN_SOL")



            Dim oDrNew As DataRow
            For intX As Integer = 0 To oDtFactura.Rows.Count - 1
                oDrNew = oDtOperacionFacturar.NewRow
                oDrNew.Item("NOPRCN") = oDtFactura.Rows(intX).Item("NOPRCN")
                oDrNew.Item("NRTFSV") = oDtFactura.Rows(intX).Item("NRTFSV")
                oDrNew.Item("FACTURA") = intNumFactura
                oDrNew.Item("NRRUBR") = oDtFactura.Rows(intX).Item("NRRUBR")
                oDrNew.Item("CSRVNV") = oDtFactura.Rows(intX).Item("CSRVNV")
                oDrNew.Item("CCNTCS") = oDtFactura.Rows(intX).Item("CCNTCS")
                oDrNew.Item("IVLSRV") = oDtFactura.Rows(intX).Item("IVLSRV")

                oDrNew.Item("NCRROP") = oDtFactura.Rows(intX).Item("NCRROP")
                oDrNew.Item("CCLNT") = oDtFactura.Rows(intX).Item("CCLNT")
                oDrNew.Item("CCMPN") = oDtFactura.Rows(intX).Item("CCMPN")
                oDrNew.Item("CMNDA1") = oDtFactura.Rows(intX).Item("CMNDA1")
                oDrNew.Item("QATNAN") = oDtFactura.Rows(intX).Item("QATNAN")
                oDrNew.Item("TOTAL") = oDtFactura.Rows(intX).Item("TOTAL")
                oDrNew.Item("CDVSN") = oDtFactura.Rows(intX).Item("CDVSN")
                oDrNew.Item("CUNDMD") = oDtFactura.Rows(intX).Item("CUNDMD")

                oDrNew.Item("IMP_ORIGEN_SOL") = oDtFactura.Rows(intX).Item("IMP_ORIGEN_SOL")

                oDtOperacionFacturar.Rows.Add(oDrNew)
            Next

            '=======================================Por Servicio
            dblCenCosMax = oDtFactura.Rows(0).Item("CCNTCS").ToString.Trim
            oDtCabecera.Rows(intNumFactura - 1).Item("CCNCSC") = dblCenCosMax
            intTotalItems = oDtFactura.Rows.Count
            intNumItems = 0
            intDetalle = 0
            dblPorIgv = oDtFactura.Rows(0).Item("PIGVA").ToString.Trim
            'pdblIGV = dblPorIgv

            phashIGV.Add(intNumFactura, dblPorIgv)

            '-------------------------------------------------------------------------------
            While (1) 'Se repite por la cantidad de Detalles de la Factura
                If intNumItems > intTotalItems - 1 Then
                    Exit While
                End If
                dblTotalCant = 0
                dblTotalMonto = 0

                CodServicio = oDtFactura.Rows(0).Item("CSRVNV").ToString.Trim
                oDrDet = oDtFactura.Select("CSRVNV=" & CodServicio)

                Validar_Detalles(oDrDet, bolMismoCCosto, bolMismaUnidad, bolMismaTarifa, bolValorServicio) 'Indica si tiene mismo centro o misma unidad
                If bolMismoCCosto And bolMismaUnidad And bolMismaTarifa And bolValorServicio Then 'Es el mismo centro de costo o el mismo tipo de unidades
                    '--Agregado ACD--
                    objLista = New List(Of Hashtable)
                    For lint As Int32 = 0 To oDrDet.Length - 1
                        objHas = New Hashtable
                        objHas.Add("NRTFSV", oDrDet(lint).Item("NRTFSV"))   ' 1
                        objHas.Add("TOTAL", oDrDet(lint).Item("TOTAL"))     ' 2
                        objHas.Add("QATNAN", oDrDet(lint).Item("QATNAN"))   ' 3
                        objHas.Add("CUNDMD", oDrDet(lint).Item("CUNDMD"))   ' 4
                        objHas.Add("CCNTCS", oDrDet(lint).Item("CCNTCS"))   ' 5
                        objHas.Add("IVLSRV", oDrDet(lint).Item("IVLSRV"))   ' 6
                        objHas.Add("NRRUBR", oDrDet(lint).Item("NRRUBR"))
                        objHas.Add("NOPRCN", oDrDet(lint).Item("NOPRCN"))

                        objHas.Add("IMP_ORIGEN_SOL", oDrDet(lint).Item("IMP_ORIGEN_SOL"))
                        objLista.Add(objHas)
                    Next
                    While (1)
                        dblTotalMonto = 0
                        dblTotalCant = 0
                        intContador = 0
                        SubTotalSol = 0
                        If objLista.Count <= 0 Then
                            Exit While
                        End If
                        ''Correlativo del detalle
                        intDetalle = intDetalle + 1

                        For lintIndice As Integer = 0 To objLista.Count - 1
                            If lintIndice = 0 Then
                                dblTarifaAnt = objLista(lintIndice).Item("NRTFSV")
                                sUnidad = objLista(lintIndice).Item("CUNDMD")
                                dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")

                                SubTotalSol = SubTotalSol + objLista(lintIndice).Item("IMP_ORIGEN_SOL")

                                intNumItems += 1
                                intContador += 1

                                For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1

                                    If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                        oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                    End If

                                Next

                            Else
                                If dblTarifaAnt = objLista(lintIndice).Item("NRTFSV") Then
                                    dblTotalMonto = dblTotalMonto + objLista(lintIndice).Item("TOTAL")
                                    dblTotalCant = dblTotalCant + objLista(lintIndice).Item("QATNAN")

                                    SubTotalSol = SubTotalSol + objLista(lintIndice).Item("IMP_ORIGEN_SOL")

                                    intNumItems += 1
                                    intContador += 1

                                    For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                                        If oDtOperacionFacturar.Rows(intX).Item("NOPRCN") = objLista(lintIndice).Item("NOPRCN") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = objLista(lintIndice).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = objLista(lintIndice).Item("IVLSRV") Then
                                            oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                                        End If
                                    Next
                                End If
                            End If
                        Next


                        oDr = oDt.NewRow
                        oDr("CCMPN") = oDrDet(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"
                        oDr("NCRDCC") = intDetalle
                        oDr("CRBCTC") = oDrDet(0).Item("CSRVNV").ToString.Trim
                        oDr("TCMTRF") = oDrDet(0).Item("TCMTRF").ToString.Trim

                        oDr("STCCTC") = "" 'Flag tipo control
                        If bolMismaUnidad Then
                            oDr("CUNCNA") = oDrDet(0).Item("CUNDMD").ToString.Trim  ' oDrDet(0).Item("TUNDIT").ToString.Trim


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(objLista(0).Item("IVLSRV"), 5)
                        Else
                            oDr("CUNCNA") = objLista(0).Item("CUNDMD") '"UNI"


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(objLista(0).Item("IVLSRV"), 5)
                        End If
                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim

                        dblTotalMonto = Math.Round(oDr("QAPCTC") * oDr("ITRCTC"), 2)
                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then

                            oDr("IVLDCS") = dblTotalMonto

                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else

                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")
                            oDr("IVLDCD") = dblTotalMonto
                        End If

                        oDr("OIVLDCS") = SubTotalSol

                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oDrDet(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = objLista(0).Item("CCNTCS")
                        oDr("NRTFSV") = objLista(0).Item("NRTFSV")
                        oDr("NRRUBR") = objLista(0).Item("NRRUBR")


                        oDr("OIVLDCS") = SubTotalSol

                        oDt.Rows.Add(oDr)

                        objLista.RemoveRange(0, intContador)

                    End While
                    '--FIN Agregado ACD--                
                Else
                    Dim oListaCC As New List(Of Hashtable)
                    oListaCC = Lista_Items_Igual_CCosto(bolMismaUnidad, oDrDet) 'Devuelve los items que tienen el mismo centro de costo y elimina estos registros de oDrDet
                    intNumItems += oDrDet.Length

                    While (1)
                        If oListaCC.Count = 0 Then
                            Exit While
                        End If

                        intContador += 1
                        intDetalle = intDetalle + 1
                        dblTotalMonto = oListaCC(0).Item("TOTAL")
                        dblTotalCant = oListaCC(0).Item("QATNAN")

                        oDr = oDt.NewRow
                        oDr("CCMPN") = oListaCC(0).Item("CCMPN").ToString.Trim

                        oDr("CTPODC") = oTipoDocumento
                        oDr("NDCCTC") = intNumFactura 'Numero del documento
                        oDr("NINDRN") = "0"

                        oDr("NCRDCC") = intDetalle

                        oDr("CRBCTC") = oListaCC(0).Item("CSRVNV").ToString.Trim
                        oDr("TCMTRF") = oListaCC(0).Item("TCMTRF").ToString.Trim

                        oDr("STCCTC") = "" 'Flag tipo control

                        If bolMismaUnidad Then
                            oDr("CUNCNA") = oListaCC(0).Item("CUNDMD").ToString.Trim


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(oListaCC(0).Item("IVLSRV"), 5)
                        Else
                            oDr("CUNCNA") = oListaCC(0).Item("CUNDMD")


                            oDr("QAPCTC") = Math.Round(dblTotalCant, 5)


                            oDr("ITRCTC") = Math.Round(oListaCC(0).Item("IVLSRV"), 5)
                        End If

                        oDr("CUTCTC") = oDrDet(0).Item("TSGNMN").ToString.Trim
                        dblTotalMonto = Math.Round(oDr("QAPCTC") * oDr("ITRCTC"), 2)
                        If oDrDet(0).Item("TSGNMN").ToString.Trim = "SOL" Then
                            oDr("IVLDCS") = dblTotalMonto

                            oDr("IVLDCD") = Format(dblTotalMonto / dblTipoCambio, "###,###,###,###,##0.00")
                        Else

                            oDr("IVLDCS") = Format(dblTotalMonto * dblTipoCambio, "###,###,###,###,##0.00")
                            oDr("IVLDCD") = dblTotalMonto
                        End If

                        oDr("NCTDCC") = intNumFactura
                        oDr("FDCCTC") = oDtCabecera.Rows(intNumFactura - 1).Item("FDCCTC").ToString.Trim
                        oDr("CDVSN") = oListaCC(0).Item("CDVSN").ToString.Trim
                        oDr("CGRNGD") = oDtCabecera.Rows(intNumFactura - 1).Item("CGRONG").ToString.Trim
                        oDr("CCNCSD") = oListaCC(0).Item("CCNTCS")

                        oDr("NRTFSV") = oListaCC(0).Item("NRTFSV")
                        oDr("NRRUBR") = oListaCC(0).Item("NRRUBR")

                        oDr("OIVLDCS") = Math.Round(oListaCC(0).Item("IMP_ORIGEN_SOL"), 2)

                        oDt.Rows.Add(oDr)

                        For intX As Integer = 0 To oDtOperacionFacturar.Rows.Count - 1
                            If oDtOperacionFacturar.Rows(intX).Item("CSRVNV") = oListaCC(0).Item("CSRVNV") And oDtOperacionFacturar.Rows(intX).Item("CCNTCS") = oListaCC(0).Item("CCNTCS") And oDtOperacionFacturar.Rows(intX).Item("NRTFSV") = oListaCC(0).Item("NRTFSV") And oDtOperacionFacturar.Rows(intX).Item("IVLSRV") = oListaCC(0).Item("IVLSRV") Then
                                oDtOperacionFacturar.Rows(intX).Item("NCRDCC") = intDetalle
                            End If
                           
                        Next

                        oListaCC.RemoveRange(0, 1)
                    End While
                End If

                'esta variable es utilizado

                Quitar_Detalles_UtilizadosXServicio(oDtFactura, CodServicio) 'Eliminar los registros utilizados de oDtFactura
            End While


            Select Case pintTipo
                Case 1

                    Dim IntCodRubro As Integer = 0
                    Dim dblMontoSoles As Double = 0
                    Dim dblMontoDolare As Double = 0
                    Dim IntCantidadRows As Integer = 0
                    Dim OrigenImporteSol As Decimal = 0
                    Dim oDrTemp() As DataRow
                    Dim oDtTemp As DataTable
                    intDetalle = 0
                    oDtTemp = oDt.Copy
                    While (1) 'Se repite por la cantidad de Detalles de la Factura
                        If oDtTemp.Rows.Count = 0 Then
                            Exit While
                        End If
                        dblMontoSoles = 0
                        dblMontoDolare = 0
                        intDetalle = intDetalle + 1
                        IntCodRubro = oDtTemp.Rows(0).Item("NRRUBR")
                        oDrTemp = oDtTemp.Select("NRRUBR='" & IntCodRubro & "'")
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            dblMontoSoles = oDrTemp(IntCantidadRows).Item("IVLDCS") + dblMontoSoles
                            dblMontoDolare = oDrTemp(IntCantidadRows).Item("IVLDCD") + dblMontoDolare

                            OrigenImporteSol = OrigenImporteSol + oDrTemp(IntCantidadRows).Item("OIVLDCS")
                        Next

                        oDrTemp(0).Item("IVLDCS") = dblMontoSoles
                        oDrTemp(0).Item("IVLDCD") = dblMontoDolare
                        oDrTemp(0).Item("CUNCNA") = ""
                        oDrTemp(0).Item("QAPCTC") = 0
                        oDrTemp(0).Item("ITRCTC") = 0
                        oDrTemp(0).Item("NCRDCC") = intDetalle

                        oDrTemp(0).Item("OIVLDCS") = OrigenImporteSol
                        oDtDetalleFac.ImportRow(oDrTemp(0))
                        For IntCantidadRows = 0 To oDrTemp.Length - 1
                            oDtTemp.Rows.Remove(oDrTemp(IntCantidadRows))
                        Next

                    End While
                    objRegistroItemFactura.Add(intDetalle)
                Case 2
                    intDetalle = 0
                    For Each dr As DataRow In oDt.Rows
                        oDtDetalleFac.ImportRow(dr)
                        intDetalle = intDetalle + 1
                    Next
                    objRegistroItemFactura.Add(intDetalle)

            End Select
            If dblPorIgv > 0 Then
                Agregar_Detalle_IGV(oDt, intNumFactura, dblPorIgv)
                Agregar_Detalle_IGV(oDtDetalleFac, intNumFactura, dblPorIgv)
            End If
            Actualizar_Montos_Cabecera(oDt, intNumFactura, dblPorIgv)


            'Se agregar el regitro que se va guardar en el detalle de la factura
            oDt.TableName = "DetalleFactura"
            oDsFactura.Tables.Add(oDtOperacionFacturar)
            oDsFactura.Tables.Add(oDt.Copy)
            oDt.Rows.Clear()
            'Guardamos en un Data set Las operaciones y el detalle de la factura
            pHtOperacioFacturar.Add(intNumFactura, oDsFactura)
        End While


        Return oDtDetalleFac
    End Function


    Public Function Cantidad_Facturas_Refactura(ByVal ListaFact As List(Of Filtro)) As Integer
        Dim oDt As DataTable = Nothing
        Dim intCant As Integer = 0
        Dim pobjFiltro As New Filtro
        Dim oDtAux As New DataTable
        Dim oDr() As DataRow
        Dim strDetraccion, strIGV, strMoneda As String
        Dim dblMonto As Decimal = 0D
        For intLista As Integer = 0 To ListaFact.Count - 1
            pobjFiltro = New Filtro
            'CONSULTA 
            If ListaFact(intLista).Parametro1 = 0 Then
                pobjFiltro.Parametro1 = ListaFact(intLista).Parametro4
                oDtAux = ListaServiciosxOperacionActualizados(pobjFiltro.Parametro1)
            End If
            If intLista = 0 Then oDt = oDtAux.Clone
            For Each dr As DataRow In oDtAux.Rows
                oDt.ImportRow(dr)
            Next
        Next

        If Not (ListaFact(0).Parametro5 = "57" Or ListaFact(0).Parametro5 = "7") Then
            While (1)
                If oDt.Rows.Count = 0 Then
                    Exit While
                End If
                intCant = intCant + 1


                dblMonto = oDt.Rows(0).Item("IAFCDT")
                strDetraccion = oDt.Rows(0).Item("IPRCDT").ToString.Trim
                strIGV = oDt.Rows(0).Item("CTIGVA").ToString.Trim
                strMoneda = oDt.Rows(0).Item("CMNDA1").ToString.Trim
                oDr = oDt.Select("IPRCDT <> '" & strDetraccion & "' OR CTIGVA <> " & strIGV & " OR CMNDA1 <> " & strMoneda & " OR IAFCDT <>" & dblMonto)
                If oDr.Length = 0 Then
                    Exit While
                Else
                    Eliminar_Rows_Detalles(oDt, strDetraccion, strIGV, strMoneda, dblMonto)
                End If
            End While
        Else
            intCant = 1
        End If

        Return intCant
    End Function

    Public Sub Grabar_Factura_Refactura(ByVal pintFact As Integer, ByRef poDtCabFact As DataTable, ByRef poDtDetFact As DataTable, ByRef pstrNumFac As String)
        'Try
        Dim intCont As Integer
        Dim intRow As Integer
        Dim obj(2) As Object
        Dim objCab(33) As Object
        Dim objDet(18) As Object
        Dim oDt As DataTable
        Dim dblNumFactura As Double
        Dim dblNumControl As Double

        For intCont = 0 To poDtCabFact.Rows.Count - 1
            If poDtCabFact.Rows(intCont).Item("NDCCTC") = pintFact Then
                objCab(0) = poDtCabFact.Rows(intCont).Item("CCMPN")
                objCab(1) = strCodTabla
                objCab(2) = poDtCabFact.Rows(intCont).Item("CTPODC")
                objCab(3) = poDtCabFact.Rows(intCont).Item("NINDRN")
                objCab(4) = poDtCabFact.Rows(intCont).Item("CDVSN")
                objCab(5) = poDtCabFact.Rows(intCont).Item("CGRONG")
                objCab(6) = poDtCabFact.Rows(intCont).Item("CZNFCC")
                objCab(7) = poDtCabFact.Rows(intCont).Item("CCBRD")
                objCab(8) = poDtCabFact.Rows(intCont).Item("CCLNT")
                objCab(9) = poDtCabFact.Rows(intCont).Item("CPLNCL")
                objCab(10) = poDtCabFact.Rows(intCont).Item("NRUC")
                objCab(11) = poDtCabFact.Rows(intCont).Item("CSTCDC")
                objCab(12) = poDtCabFact.Rows(intCont).Item("CPLNDV")
                objCab(13) = poDtCabFact.Rows(intCont).Item("SABOPN")
                objCab(14) = poDtCabFact.Rows(intCont).Item("FDCCTC")
                objCab(15) = poDtCabFact.Rows(intCont).Item("CMNDA")
                objCab(16) = poDtCabFact.Rows(intCont).Item("IVLAFS")
                objCab(17) = poDtCabFact.Rows(intCont).Item("IVLNAS")
                objCab(18) = poDtCabFact.Rows(intCont).Item("IVLIGS")
                objCab(19) = poDtCabFact.Rows(intCont).Item("ITTFCS")
                objCab(20) = poDtCabFact.Rows(intCont).Item("ITTPGS")
                objCab(21) = poDtCabFact.Rows(intCont).Item("IVLAFD")
                objCab(22) = poDtCabFact.Rows(intCont).Item("IVLNAD")
                objCab(23) = poDtCabFact.Rows(intCont).Item("IVLIGD")
                objCab(24) = poDtCabFact.Rows(intCont).Item("ITTFCD")
                objCab(25) = poDtCabFact.Rows(intCont).Item("ITTPGD")
                objCab(26) = poDtCabFact.Rows(intCont).Item("ITCCTC")
                objCab(27) = poDtCabFact.Rows(intCont).Item("SFLLTR")
                objCab(28) = poDtCabFact.Rows(intCont).Item("CZNCBD")
                objCab(29) = poDtCabFact.Rows(intCont).Item("CCNCSC")
                objCab(30) = poDtCabFact.Rows(intCont).Item("CRGVTA")

                objCab(31) = poDtCabFact.Rows(intCont).Item("CTPDCO")
                objCab(32) = poDtCabFact.Rows(intCont).Item("NDCMOR")
                objCab(33) = poDtCabFact.Rows(intCont).Item("FDCMOR")



                oDt = oFacturaDato.Grabar_Cabecera_ReFactura(objCab)
                dblNumFactura = oDt.Rows(0).Item("NULCTR")
                dblNumControl = oDt.Rows(0).Item("NCTRRL")
                poDtCabFact.Rows(intCont).Item("NDCCTC") = dblNumFactura
                poDtCabFact.Rows(intCont).Item("NCTDCC") = dblNumControl
                For intRow = 0 To poDtDetFact.Rows.Count - 1
                    If poDtDetFact.Rows(intRow).Item("NDCCTC") = pintFact Then
                        objDet(0) = poDtDetFact.Rows(intRow).Item("CCMPN")
                        objDet(1) = poDtDetFact.Rows(intRow).Item("CTPODC")
                        objDet(2) = dblNumFactura
                        objDet(3) = poDtDetFact.Rows(intRow).Item("NINDRN")
                        objDet(4) = poDtDetFact.Rows(intRow).Item("NCRDCC")
                        objDet(5) = poDtDetFact.Rows(intRow).Item("CRBCTC")
                        objDet(6) = poDtDetFact.Rows(intRow).Item("STCCTC")
                        objDet(7) = poDtDetFact.Rows(intRow).Item("CUNCNA")
                        objDet(8) = poDtDetFact.Rows(intRow).Item("QAPCTC")
                        objDet(9) = poDtDetFact.Rows(intRow).Item("CUTCTC")
                        objDet(10) = poDtDetFact.Rows(intRow).Item("ITRCTC")
                        objDet(11) = poDtDetFact.Rows(intRow).Item("IVLDCS")
                        objDet(12) = poDtDetFact.Rows(intRow).Item("IVLDCD")
                        objDet(13) = dblNumControl
                        objDet(14) = poDtDetFact.Rows(intRow).Item("FDCCTC")
                        objDet(15) = poDtDetFact.Rows(intRow).Item("CDVSN")
                        objDet(16) = poDtDetFact.Rows(intRow).Item("CGRNGD")
                        If IsDBNull(poDtDetFact.Rows(intRow).Item("CCNCSD")) Then
                            objDet(17) = 0
                        Else
                            objDet(17) = poDtDetFact.Rows(intRow).Item("CCNCSD")
                        End If
                        oFacturaDato.Grabar_Detalle_Factura_Refactura(objDet)
                        poDtDetFact.Rows(intRow).Item("NDCCTC") = dblNumFactura
                        poDtDetFact.Rows(intRow).Item("NCTDCC") = dblNumControl
                    End If
                Next intRow

 

                Exit For
            End If
        Next intCont
        pstrNumFac = dblNumFactura
      
    End Sub

    Public Function Listar_Documentos_Emitidos_x_Operacion(ByVal param As Hashtable) As DataTable
        Return oFacturaDato.Listar_Documentos_Emitidos_x_Operacion(param)
    End Function


    Public Function Traer_Importe_Refactura(ByVal param As Hashtable) As DataTable
        Return oFacturaDato.Traer_Importe_Refactura(param)
    End Function


   

    Public Function Grabar_Historial_Documento_Cabecera(ByVal obeFacturaHistorialCab As FacturaHistorialCab) As Decimal
        Dim clsFacturaDato As New SOLMIN_CTZ.DATOS.clsFactura
        Return clsFacturaDato.Grabar_Historial_Documento_Cabecera(obeFacturaHistorialCab)
    End Function

    Public Sub Grabar_Historial_Documento_Detalle(ByVal obeFacturaHistorialDet As FacturaHistorialDet)
        Dim clsFacturaDato As New SOLMIN_CTZ.DATOS.clsFactura
        clsFacturaDato.Grabar_Historial_Documento_Detalle(obeFacturaHistorialDet)
    End Sub



    Public Sub Grabar_Historial_Documento(ByRef dtOperacionDocHistCab As DataTable, ByRef dtOperacionDocHistDet As DataTable, ByVal pintFact As Int32)
        Dim obeFacturaHistorialCab As FacturaHistorialCab
        Dim obeFacturaHistorialDet As FacturaHistorialDet
        Dim NCRRFC_CAB As Decimal = 0
        Dim CCLNT_CAB As Decimal = 0
        Dim NOPRCN_CAB As Decimal = 0
        Dim drServDet() As DataRow
        For Each ItemCabOp As DataRow In dtOperacionDocHistCab.Rows
            If ItemCabOp("FACTURA") = pintFact Then
                obeFacturaHistorialCab = New FacturaHistorialCab
                obeFacturaHistorialCab.PSCCMPN = ItemCabOp("CCMPN")
                obeFacturaHistorialCab.PNCCLNT = ItemCabOp("CCLNT")
                obeFacturaHistorialCab.PNNOPRCN = ItemCabOp("NOPRCN")
                obeFacturaHistorialCab.PNCTPODC = ItemCabOp("CTPODC")
                obeFacturaHistorialCab.PNNDCFCC = ItemCabOp("NDCCTC")
                obeFacturaHistorialCab.PNFDCFCC = ItemCabOp("FDCCTC")
                obeFacturaHistorialCab.PNCMNDA1 = ItemCabOp("CMNDA1")
                obeFacturaHistorialCab.PNIVLSRV = ItemCabOp("IVLSRV")
                NCRRFC_CAB = oFacturaDato.Grabar_Historial_Documento_Cabecera(obeFacturaHistorialCab)

                If NCRRFC_CAB > 0 Then
                    ItemCabOp("NCRRFC") = NCRRFC_CAB

                    CCLNT_CAB = ItemCabOp("CCLNT")
                    NOPRCN_CAB = ItemCabOp("NOPRCN")
                    For Each ItemDetOp As DataRow In dtOperacionDocHistDet.Rows
                        If ItemDetOp("FACTURA") = pintFact AndAlso ItemDetOp("NOPRCN") = NOPRCN_CAB Then
                            ItemDetOp("NCRRFC") = NCRRFC_CAB
                        End If
                    Next

                    drServDet = dtOperacionDocHistDet.Select("FACTURA='" & pintFact & "' AND NOPRCN='" & NOPRCN_CAB & "' AND NCRRFC='" & NCRRFC_CAB & "'")
                    For FILA As Int32 = 0 To drServDet.Length - 1
                        obeFacturaHistorialDet = New FacturaHistorialDet
                        obeFacturaHistorialDet.PSCCMPN = drServDet(FILA)("CCMPN")
                        obeFacturaHistorialDet.PNCCLNT = drServDet(FILA)("CCLNT")
                        obeFacturaHistorialDet.PNNOPRCN = drServDet(FILA)("NOPRCN")
                        obeFacturaHistorialDet.PNNCRRFC = drServDet(FILA)("NCRRFC")
                        obeFacturaHistorialDet.PNNCRROP = drServDet(FILA)("NCRROP")
                        obeFacturaHistorialDet.PNNRTFSV = drServDet(FILA)("NRTFSV")
                        obeFacturaHistorialDet.PNQATNAN = drServDet(FILA)("QATNAN")
                        obeFacturaHistorialDet.PSCUNDMD = drServDet(FILA)("CUNDMD")
                        obeFacturaHistorialDet.PNIVLSRV = drServDet(FILA)("IVLSRV")
                        obeFacturaHistorialDet.PNNCRDCC = drServDet(FILA)("NCRDCC")
                        oFacturaDato.Grabar_Historial_Documento_Detalle(obeFacturaHistorialDet)
                    Next
                End If
            End If
        Next



    End Sub


    Public Sub Grabar_Historial_DocumentoMasivo(dtHistFact As DataTable)

        Dim JsHistFact As Dictionary(Of String, Object)
        Dim listJsHistFact As New List(Of Dictionary(Of String, Object))
        Dim CodCompania As String = ""

        Dim intCont As Integer = 0
        Dim esFilaFinal As Boolean = False
        Dim MaxLineasDetFact As Integer = 100

        Dim oFact As FacturaHistorialCab
        Dim obejs As FacturaHistorialDet

        Dim oListMasivo As New List(Of FacturaHistorialCab)
        If dtHistFact.Rows.Count > 0 Then
            CodCompania = dtHistFact.Rows(0)("CCMPN")
        End If

        For FILA As Int32 = 0 To dtHistFact.Rows.Count - 1
            obejs = New FacturaHistorialDet

            obejs.PNCTPODC = dtHistFact.Rows(FILA)("CTPODC")
            obejs.PNNDCFCC = dtHistFact.Rows(FILA)("NDCCTC")
            obejs.PNCMNDA1 = dtHistFact.Rows(FILA)("CMNDA1")
            obejs.PNCCLNT = dtHistFact.Rows(FILA)("CCLNT")
            obejs.PNNOPRCN = dtHistFact.Rows(FILA)("NOPRCN")
            obejs.PNNCRROP = dtHistFact.Rows(FILA)("NCRROP")
            obejs.PNNRTFSV = dtHistFact.Rows(FILA)("NRTFSV")
            obejs.PNQATNAN = dtHistFact.Rows(FILA)("QATNAN")
            obejs.PSCUNDMD = dtHistFact.Rows(FILA)("CUNDMD")
            obejs.PNIVLSRV = dtHistFact.Rows(FILA)("IVLSRV")
            obejs.PNNCRDCC = dtHistFact.Rows(FILA)("NCRDCC")

            obejs.PNCSRVNV = dtHistFact.Rows(FILA)("CSRVNV")
            obejs.PNCCNTCS = dtHistFact.Rows(FILA)("CCNTCS")
            obejs.PSCDVSN = dtHistFact.Rows(FILA)("CDVSN")

     

             

            JsHistFact = New Dictionary(Of String, Object)
          

            JsHistFact.Add("CDVSN", obejs.PSCDVSN)
            JsHistFact.Add("CSRVC", obejs.PNCSRVNV)
            JsHistFact.Add("CCNTCS", obejs.PNCCNTCS)

            JsHistFact.Add("CMNDA1", obejs.PNCMNDA1)
            JsHistFact.Add("CCLNT", obejs.PNCCLNT)
            JsHistFact.Add("NOPRCN", obejs.PNNOPRCN)
            JsHistFact.Add("NCRROP", obejs.PNNCRROP)
            JsHistFact.Add("NRTFSV", obejs.PNNRTFSV)
            JsHistFact.Add("QATNAN", obejs.PNQATNAN)
            JsHistFact.Add("CUNDMD", obejs.PSCUNDMD)
            JsHistFact.Add("IVLSRV", obejs.PNIVLSRV)
            JsHistFact.Add("NCRDCC", obejs.PNNCRDCC)
            listJsHistFact.Add(JsHistFact)

            esFilaFinal = (FILA = dtHistFact.Rows.Count - 1)

            If (listJsHistFact.Count >= MaxLineasDetFact Or esFilaFinal = True) Then
                Dim StrJson As String = JsonConvert.SerializeObject(listJsHistFact)

                oFact = New FacturaHistorialCab
                oFact.PSCCMPN = CodCompania
                oFact.PNCTPODC = obejs.PNCTPODC
                oFact.PNNDCFCC = obejs.PNNDCFCC
                oFact.LISTJSON = StrJson
                oListMasivo.Add(oFact)
                listJsHistFact = New List(Of Dictionary(Of String, Object))

            End If

             
        Next

        For Each item As FacturaHistorialCab In oListMasivo
            oFacturaDato.Grabar_Historial_Documento_Masivo(item)
        Next

 
    End Sub



    Private Sub CrearEstructuraHistorialDocCabecera(ByVal dtHistDocCab As DataTable)
        If dtHistDocCab.Rows.Count > 0 Then dtHistDocCab.Rows.Clear()
        dtHistDocCab.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtHistDocCab.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("NOPRCN", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("NCRRFC", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("CTPODC", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("NDCCTC", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("FDCCTC", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("CMNDA1", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("IVLSRV", Type.GetType("System.Decimal"))
        dtHistDocCab.Columns.Add("FACTURA", Type.GetType("System.Decimal"))
    End Sub
    Private Sub CrearEstructuraHistorialDocDetalle(ByVal dtHistDocDet As DataTable)
        dtHistDocDet.Columns.Clear()
        If dtHistDocDet.Rows.Count > 0 Then dtHistDocDet.Rows.Clear()
        dtHistDocDet.Columns.Add("CCMPN", Type.GetType("System.String"))
        dtHistDocDet.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NOPRCN", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NCRRFC", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NCRROP", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NRTFSV", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("CUNDMD", Type.GetType("System.String"))
        dtHistDocDet.Columns.Add("QATNAN", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("IVLSRV", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("CTPODC", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NDCCTC", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("FACTURA", Type.GetType("System.Decimal"))
        dtHistDocDet.Columns.Add("NCRDCC", Type.GetType("System.Decimal"))
    End Sub

    Private Function ListarOperacionesDifxFactura(ByVal dtServiciosFacturar As DataTable, ByVal pintFact As Int32) As List(Of String)
        Dim ListOperacionesDifxFactura As New List(Of String)
        Dim NOPRCN As String = ""
        For FILA As Integer = 0 To dtServiciosFacturar.Rows.Count - 1
            If dtServiciosFacturar.Rows(FILA)("FACTURA") = pintFact Then
                NOPRCN = dtServiciosFacturar.Rows(FILA)("NOPRCN")
                If Not ListOperacionesDifxFactura.Contains(NOPRCN) Then
                    ListOperacionesDifxFactura.Add(NOPRCN)
                End If
            End If
        Next
        Return ListOperacionesDifxFactura
    End Function

    Public Sub Formar_Cabecera_Detalle_Historial(ByRef dtOperacionDocHistCab As DataTable, ByRef dtOperacionDocHistDet As DataTable, ByVal dtServiciosFacturar As DataTable, ByVal pintFact As Int32)

        Dim ListOperacionesDifxFactura As New List(Of String)
        ListOperacionesDifxFactura = ListarOperacionesDifxFactura(dtServiciosFacturar.Copy, pintFact)


        dtOperacionDocHistCab = New DataTable
        dtOperacionDocHistDet = New DataTable
        CrearEstructuraHistorialDocCabecera(dtOperacionDocHistCab)
        CrearEstructuraHistorialDocDetalle(dtOperacionDocHistDet)
        Dim drServicio() As DataRow
        Dim drOpCab As DataRow
        Dim drOpDet As DataRow
        Dim CodUnico As String = ""
        Dim LisOpVisitados As New Hashtable
        Dim FilaUpdate As Int32 = 0
        For Each ItemOperacion As String In ListOperacionesDifxFactura
            drServicio = dtServiciosFacturar.Select("FACTURA='" & pintFact & "' AND NOPRCN='" & ItemOperacion & "'")
            If drServicio.Length > 0 Then
                For Fila As Integer = 0 To drServicio.Length - 1
                    CodUnico = drServicio(Fila)("FACTURA") & "_" & drServicio(Fila)("NOPRCN")
                    If Not LisOpVisitados.Contains(CodUnico) Then
                        drOpCab = dtOperacionDocHistCab.NewRow
                        drOpCab("CCMPN") = drServicio(Fila)("CCMPN")
                        drOpCab("CCLNT") = drServicio(Fila)("CCLNT")
                        drOpCab("NOPRCN") = drServicio(Fila)("NOPRCN")
                        drOpCab("NCRRFC") = 0
                        drOpCab("CTPODC") = drServicio(Fila)("CTPODC")
                        drOpCab("NDCCTC") = drServicio(Fila)("NDCCTC")
                        drOpCab("FDCCTC") = drServicio(Fila)("FDCCTC")
                        drOpCab("IVLSRV") = drServicio(Fila)("TOTAL")
                        drOpCab("FACTURA") = drServicio(Fila)("FACTURA")
                        drOpCab("CMNDA1") = drServicio(Fila)("CMNDA1")
                        dtOperacionDocHistCab.Rows.Add(drOpCab)
                        FilaUpdate = Fila
                        LisOpVisitados.Add(CodUnico, FilaUpdate)
                    Else
                        FilaUpdate = LisOpVisitados(CodUnico)
                        dtOperacionDocHistCab.Rows(FilaUpdate)("IVLSRV") = dtOperacionDocHistCab.Rows(FilaUpdate)("IVLSRV") + drServicio(Fila)("TOTAL")
                    End If
                Next

                For Fila As Integer = 0 To drServicio.Length - 1
                    drOpDet = dtOperacionDocHistDet.NewRow
                    drOpDet("CCMPN") = drServicio(Fila)("CCMPN")
                    drOpDet("CCLNT") = drServicio(Fila)("CCLNT")
                    drOpDet("NOPRCN") = drServicio(Fila)("NOPRCN")
                    drOpDet("NCRRFC") = 0
                    drOpDet("NCRROP") = drServicio(Fila)("NCRROP")
                    drOpDet("NRTFSV") = drServicio(Fila)("NRTFSV")
                    drOpDet("CUNDMD") = drServicio(Fila)("CUNDMD")
                    drOpDet("QATNAN") = drServicio(Fila)("QATNAN")
                    drOpDet("IVLSRV") = drServicio(Fila)("IVLSRV")
                    drOpDet("NDCCTC") = drServicio(Fila)("NDCCTC")
                    drOpDet("CTPODC") = drServicio(Fila)("CTPODC")
                    drOpDet("FACTURA") = drServicio(Fila)("FACTURA")
                    drOpDet("NCRDCC") = drServicio(Fila)("NCRDCC")
                    dtOperacionDocHistDet.Rows.Add(drOpDet)
                Next
            End If
        Next



    End Sub


   

    Public Sub Liberar_Operacion_Servicio_Refactura(ByVal _ListaoFacturacion As List(Of SOLMIN_CTZ.Entidades.FacturaSIL), ByVal dtOperacionDocHistCab As DataTable, ByVal pintFact As Int32)

        Dim obeFacturaHistorialCab As FacturaHistorialCab
        For Each Item As SOLMIN_CTZ.Entidades.FacturaSIL In _ListaoFacturacion
            For FILA As Integer = 0 To dtOperacionDocHistCab.Rows.Count - 1
                If dtOperacionDocHistCab.Rows(FILA)("FACTURA") = pintFact AndAlso Item.NOPRCN = dtOperacionDocHistCab.Rows(FILA)("NOPRCN") Then
                    If Item.LIBERAR = "S" Then
                        obeFacturaHistorialCab = New FacturaHistorialCab
                        obeFacturaHistorialCab.PSCCMPN = Item.PSCCMPN
                        obeFacturaHistorialCab.PSCDVSN = Item.PSCDVSN
                        obeFacturaHistorialCab.PNNOPRCN = Item.NOPRCN
                        obeFacturaHistorialCab.PNCCLNT = Item.PNCCLNT
                        obeFacturaHistorialCab.PNCTPODC = Item.CTPODC
                        obeFacturaHistorialCab.PNNDCFCC = Item.NDCCTC
                        oFacturaDato.Liberar_Operacion_Servicio_Refactura(obeFacturaHistorialCab, Item.LIBERAR)
                    End If
                End If
            Next
        Next
     
    End Sub



    Public Function Lista_Datos_ReFactura(ByVal pobjFiltro As Filtro) As DataSet
        Return oFacturaDato.Lista_Datos_ReFactura(pobjFiltro)
    End Function

    Public Function Lista_Unidad_Consistencia_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Unidad_Consistencia_SIL_Refactura(pobjFiltro)
    End Function
    Public Function Lista_Referencia_Factura_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Referencia_Factura_SIL_Refactura(pobjFiltro)
    End Function
    Public Function Lista_Observacion_Factura_SIL_Refactura(ByVal pobjFiltro As Filtro) As DataTable
        Return oFacturaDato.Lista_Observacion_Factura_SIL_Refactura(pobjFiltro)
    End Function
    Public Function Lista_Doc_Origen_Operacion(ByVal PNNOPRCN As String) As DataTable
        Return oFacturaDato.Lista_Doc_Origen_Operacion(PNNOPRCN)
    End Function

    Public Sub Anular_Cuenta_corriente_Historial_RZCT34(ByVal pobjFiltro As Hashtable)
        oFacturaDato.Anular_Cuenta_corriente_Historial_RZCT34(pobjFiltro)
    End Sub



    '<[AHM]>
    Public Function ValidarClienteSAP(ByVal codigoCompania As String, ByVal codRegionVenta As String, ByVal codCliente As String) As String
    
        Dim DataTable As New DataTable
        Dim msgValError As String = ""
        DataTable = oFacturaDato.ValidarClienteSAP(codigoCompania, codRegionVenta, codCliente, msgValError)
        If msgValError.Length = 0 Then
            If (DataTable.Rows.Count = 0) Then
                msgValError = "No se pudo obtener datos del cliente"
            End If
            If DataTable.Rows.Count > 0 Then
                If (DataTable.Rows(0).Item("FLSTSE").ToString().Trim() <> "1") Then
                    msgValError = "Cliente no habilitado para Facturación electrónica"
                End If
            End If
        End If
        Return msgValError
    End Function
    '</[AHM]>


#End Region


#Region "Factura - Electronica"   'JM

    Public Sub Grabar_Cabecera_Factura_ELectronica(ByVal objCabecera_FE As FacturaElectronica)
        oFacturaDato.Grabar_Cabecera_Factura_ELectronica(objCabecera_FE)
    End Sub

    Public Sub Grabar_Detalle_Factura_Electronica(ByVal objDetalle_FE As FacturaElectronicaDet)
        oFacturaDato.Grabar_Detalle_Factura_Electronica(objDetalle_FE)
    End Sub


    Public Sub Lista_Documentos_Facturacion_Electronico(ByVal pobjFiltro As Hashtable)
        oDtDocumentos = oFacturaDato.Lista_Documentos_Permitidos_Facturacion_Electronico(pobjFiltro)
    End Sub

    Public Function Lista_Tipo_Nota_Electronico(ByVal pCCMPN As String, ByVal pCTPODC As Integer) As DataTable
        Return oFacturaDato.Lista_Tipo_Nota_Electronico(pCCMPN, pCTPODC)
    End Function

    Public Function Lista_Documentos_Permitidos_Refactura_FE(ByVal pobjFiltro As Filtro)
        Return oFacturaDato.Lista_Documentos_Permitidos_Refactura_FE(pobjFiltro)
    End Function

    Public Function Lista_Datos_Factura_Electronica(ByVal pobjFiltro As Filtro) As DataSet
        Return oFacturaDato.Lista_Datos_Factura_Electronica(pobjFiltro)

    End Function

    Public Sub Enviar_Documento_SAP_FE(ByVal pobjFiltro As Filtro)
        Try
            oFacturaDato.Enviar_Documento_SAP_FE(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub Reenviar_Documento_SAP_FE(ByVal pobjFiltro As Filtro)
        Try
            oFacturaDato.Reenviar_Documento_SAP_FE(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Function Lista_Datos_Planta(ByVal objFiltro As Hashtable)
        Return oFacturaDato.Lista_Datos_Planta(objFiltro)
    End Function


    Public Function fstrValidarClienteSAPFE(ByVal objParameter As Hashtable, ByRef strEstado As String) As String
        Dim strResultado As String = ""
        strResultado = oFacturaDato.fstrValidarClienteSAPFE(objParameter)
        Return strResultado
    End Function



#Region "RE-FACTURACION ELECTRONICO"
    Public Function Lista_Datos_ReFactura_Electronica(ByVal pobjFiltro As Filtro) As DataSet
        Return oFacturaDato.Lista_Datos_ReFactura_Electronica(pobjFiltro)
    End Function
#End Region


#End Region

#Region "Parte Transferencia"
    Public Function Lista_UsuarioAprobador_ParteTransferencia() As List(Of FacturaHistorialDet)
        Return oFacturaDato.Lista_UsuarioAprobador_ParteTransferencia()
    End Function
    'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - INICIO 
    Public Function Lista_Datos_Documento_Emitido(ByVal PSCCMPN As String, ByVal PNCTPODC As Decimal, ByVal PNNDCCTC As Decimal) As DataSet
        Return oFacturaDato.Lista_Datos_Documento_Emitido(PSCCMPN, PNCTPODC, PNNDCCTC)
    End Function
    'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - FIN 



#End Region




    Public Function Validar_Listado_Facturacion(ByVal compania As String, ByVal division As String, cliente As Decimal, Listado As String, TipoLista As String) As String

        Dim mensaje As String = String.Empty
        Dim dt As New DataTable


        dt = oFacturaDato.Validar_Listado_Facturacion(compania, division, cliente, Listado, TipoLista)
        For Each row As DataRow In dt.Rows
            If row.Item("STATUS") = "E" Then
                mensaje = mensaje & row.Item("OBSRESULT") & vbNewLine
            End If
        Next

        Return mensaje
    End Function



    '



    Public Function Obtener_Factura_Servicio_SUNAT(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PNNOPRCN As Decimal, ByVal PNNSECFC As Decimal) As DataTable

        Return oFacturaDato.Obtener_Factura_Servicio_SUNAT(PSCCMPN, PSCDVSN, PNCCLNT, PNNOPRCN, PNNSECFC)

    End Function

    Private Function Detalle_BE(ByRef poDt As DataTable, ByVal pintNumFact As Integer) As DataTable
        Dim oDt As DataTable
        Dim intCont As Integer
        Dim intCol As Integer
        Dim oDr() As DataRow
        Dim oDrNew As DataRow
        Dim DirServ As String
        oDt = poDt.Copy
        oDt.Clear()
        DirServ = poDt.Rows(0).Item("DEDISE")
        oDr = poDt.Select("DEDISE ='" & DirServ & "'")
        For intCont = 0 To oDr.Length - 1
            oDrNew = oDt.NewRow
            For intCol = 0 To oDt.Columns.Count - 1
                oDrNew.Item(intCol) = oDr(intCont).Item(intCol).ToString.Trim
            Next intCol
            oDt.Rows.Add(oDrNew)
        Next intCont
        Eliminar_Rows_Detalles_BE(poDt, DirServ)
        Return oDt
    End Function

    Public Function Cantidad_BE(ByVal ListaFact As List(Of Filtro)) As Integer
        Dim oDt As DataTable = Nothing
        Dim intCant As Integer = 0
        Dim pobjFiltro As New Filtro
        Dim oDtAux As New DataTable
        Dim oDr() As DataRow
        Dim DirServ As String = ""

        For intLista As Integer = 0 To ListaFact.Count - 1
            pobjFiltro = New Filtro
            If ListaFact(intLista).Parametro1 = 0 Then
                pobjFiltro.Parametro1 = ListaFact(intLista).Parametro4
                pobjFiltro.Parametro3 = ListaFact(intLista).Parametro3
                oDtAux = oFacturaDato.Lista_Detalle_ServiciosXOperacion_V2(pobjFiltro)
            Else
                pobjFiltro.Parametro1 = ListaFact(intLista).Parametro1
                pobjFiltro.Parametro3 = ListaFact(intLista).Parametro3
                oDtAux = oFacturaDato.Lista_Detalle_ServiciosXRevision_V2(pobjFiltro)
            End If
            If intLista = 0 Then oDt = oDtAux.Clone
            For Each dr As DataRow In oDtAux.Rows
                oDt.ImportRow(dr)
            Next

        Next

        While (1)
            If oDt.Rows.Count = 0 Then
                Exit While
            End If
            intCant = intCant + 1

            DirServ = oDt.Rows(0).Item("DEDISE").ToString.Trim
            oDr = oDt.Select("DEDISE <> ' " & DirServ & "'")

            If oDr.Length = 0 Then
                Exit While
            Else
                Eliminar_Rows_Detalles_BE(oDt, DirServ)
            End If
        End While
        Return intCant
    End Function

    Public Sub Eliminar_Rows_Detalles_BE(ByRef poDt As DataTable, ByVal diServ As String)
        Dim intCont As Integer
        For intCont = poDt.Rows.Count - 1 To 0 Step -1
            If poDt.Rows(intCont).Item("DEDISE") = diServ Then
                poDt.Rows.RemoveAt(intCont)
            End If
        Next intCont
    End Sub

    Public Function Lista_OrgVenta_Cliente(pCCMPN As String, pCCLNFC As Decimal) As DataTable
        Return oFacturaDato.Lista_OrgVenta_Cliente(pCCMPN, pCCLNFC)
    End Function

End Class
