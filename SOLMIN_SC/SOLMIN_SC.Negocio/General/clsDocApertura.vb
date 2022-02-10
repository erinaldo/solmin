Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsDocApertura
    Private oDocApertura As Datos.clsDocApertura
    Private intCodigo As Integer
    Private oDt As DataTable

    Sub New()
        oDocApertura = New Datos.clsDocApertura
    End Sub

    Property Codigo()
        Get
            Return intCodigo
        End Get
        Set(ByVal value)
            intCodigo = value
        End Set
    End Property

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Doc_Apertura(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

   
    Public Sub Crea_Lista()
        oDt = oDocApertura.Lista_Doc_Apertura
    End Sub

    Public Function Lista_Documento() As DataTable
        Return oDocApertura.Lista_Documento
    End Function

    Public Sub Actualizar_Documentos_Adjunto(ByVal obeDocumentoAdjunto As beDocCargaInternacional)
        oDocApertura.Actualizar_Documentos_Adjunto(obeDocumentoAdjunto)
    End Sub




    Public Sub Borrar_Documentos_Adjunto_Item(ByVal obeDocumentoAdjunto As beDocCargaInternacional)
        oDocApertura.Borrar_Documentos_Adjunto_Item(obeDocumentoAdjunto)
    End Sub
   
    Public Function Lista_Doc_Embarque(ByVal PNCCLNT As Double, ByVal PNNORSCI As Double) As List(Of beDocCargaInternacional)
        Return oDocApertura.Lista_Doc_Embarque(PNCCLNT, PNNORSCI)
    End Function


    Public Sub Mant_Doc_Forol(ByVal obeDetCargaInternacional_BE As beDetalleCargaInternacional)
        oDocApertura.Mant_Doc_Forol(obeDetCargaInternacional_BE)
    End Sub



    Public Sub Borrar_Doc_Forol(ByVal pdblEmbarque As Double)
        oDocApertura.Borrar_Doc_Forol(pdblEmbarque, intCodigo)
    End Sub



    Public Function Lista_Doc_Forol(ByVal pdblEmbarque As Double) As DataTable
        Return oDocApertura.Lista_Doc_Forol(pdblEmbarque, intCodigo)
    End Function

    Public Function Lista_Documentos_Costo_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Return oDocApertura.Lista_Documentos_Costo_Embarque(pdblEmbarque)
    End Function

   
    Public Sub Grabar_Documentos_Costos_Embarque(ByVal obeDocumentoCosto As beDocumentoCostos)
        oDocApertura.Grabar_Documentos_Costos_Embarque(obeDocumentoCosto)
    End Sub

    Public Sub Grabar_Documentos_Costos_Embarque_DUA(ByVal obeDocumentoCosto As beDocumentoCostos)
        oDocApertura.Grabar_Documentos_Costos_Embarque_DUA(obeDocumentoCosto)
    End Sub


    Public Function Lista_Concepto_Costo_Embarque(ByVal pstrDescripcion As String) As DataTable
        Return oDocApertura.Lista_Concepto_Costo_Embarque(pstrDescripcion)
    End Function

    Public Sub Guardar_Costos_Totales_Embarque(ByVal PSTIPO As String, ByVal obeCostoTotalEmbarque As beCostoTotalEmbarque)
        oDocApertura.Guardar_Costos_Totales_Embarque(PSTIPO, obeCostoTotalEmbarque)
    End Sub

 
    Public Function Lista_Costos_Totales_Embarque(ByVal pdblEmbarque As Double) As DataSet
        Return oDocApertura.Lista_Costos_Totales_Embarque(pdblEmbarque)
    End Function


    Public Function Lista_Costos_Distribuidos_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Return oDocApertura.Lista_Costos_Distribuidos_Embarque(pdblEmbarque)
    End Function
    Public Function Lista_Costos_Totales_Embarque_ALL(ByVal Embarques_List As String) As DataTable
        Return oDocApertura.Lista_Costos_Totales_Embarque_ALL(Embarques_List)
    End Function

    Public Sub Guardar_Documento_Costo_Total_X_Embarque(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String, ByVal pdblCodDocumento As Double, ByVal dblNrCorrelativo As Double)
        oDocApertura.Guardar_Documentos_X_Costo_Total_Embarque(pdblEmbarque, pstrCodVariable, pdblCodDocumento, dblNrCorrelativo)
    End Sub

    Public Function Lista_Documentos_Costo_X_Costo_Total_Embarque(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String) As DataTable
        Return oDocApertura.Lista_Documentos_Costo_X_Costo_Total_Embarque(pdblEmbarque, pstrCodVariable)
    End Function

    Public Function Lista_cantidad_Doc_Costo_embarque(ByVal pdblEmbarque As Double, ByVal pstrVariable As String, ByVal pdblCorrelativo As Double) As DataTable
        Return oDocApertura.Lista_cantidad_Doc_Costo_embarque(pdblEmbarque, pstrVariable, pdblCorrelativo)
    End Function

    Public Sub Insertar_Costo_Detalle_Embarque_Rubro_Agencia(ByVal obeListDetCostoRubroAgencia As List(Of beDetCostoRubroAgencia))
        Dim Eliminar As Int32 = 0
        Dim retorno As Int32 = 0
        If (obeListDetCostoRubroAgencia.Count > 0) Then
            Eliminar = oDocApertura.Eliminar_Costo_Detalle_Embarque_Rubro_Agencia(obeListDetCostoRubroAgencia(0).PNNORSCI, obeListDetCostoRubroAgencia(0).PSCODVAR)
            If (Eliminar = 1) Then
                For Each Item As beDetCostoRubroAgencia In obeListDetCostoRubroAgencia
                    retorno = oDocApertura.Insertar_Costo_Detalle_Embarque_Rubro_Agencia(Item)
                Next
            End If
        End If
    End Sub
    Public Function Listar_Costo_Detalle_Embarque_Rubro_Agencia(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As DataTable
        Return oDocApertura.Listar_Costo_Detalle_Embarque_Rubro_Agencia(PNNORSCI, PSCODVAR)
    End Function

    Public Sub Eliminar_X_Documento_Adj_Costo_Item(ByVal obeDocumentoCosto As beDocumentoCostos)
        oDocApertura.Eliminar_X_Documento_Adj_Costo_Item(obeDocumentoCosto)
    End Sub
    Public Sub Borrar_Costos_Embarque_Distribucion_Detalle(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String)
        oDocApertura.Borrar_Costos_Embarque_Distribucion_Detalle(PNNORSCI, PSCODVAR)
    End Sub
    Public Function ExisteCostoxEmbarque(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Integer
        Return oDocApertura.ExisteCostoxEmbarque(PNNORSCI, PSCODVAR)
    End Function
#Region "Costos ABB"
    ''' <summary>
    ''' Lista de Costos para ABB
    ''' </summary>
    ''' <param name="pdblEmbarque"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Lista_Costos_Totales_Embarque_ABB(ByVal pdblEmbarque As Double) As DataSet
        Return oDocApertura.Lista_Costos_Totales_Embarque_ABB(pdblEmbarque)
    End Function
    Public Function Lista_Costos_Totales_Embarque_ABB_Cambio_CheckPoint(ByVal pdblEmbarque As Double) As DataSet
        Return oDocApertura.Lista_Costos_Totales_Embarque_ABB_Cambio_CheckPoint(pdblEmbarque)
    End Function

    Public Function ListaEmbarquesRegularizar() As DataTable
        Return oDocApertura.ListaEmbarquesRegularizar
    End Function
    Public Function Lista_Validacion_Datos_Envio_ABB(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As String
        Dim dsEnvioABB As New DataSet
        dsEnvioABB = oDocApertura.Lista_Validacion_Envio_Costos_ABB(PNNORSCI, PNCCLNT)
        Dim msg As String = ""
        Dim dtTipoCambio As New DataTable
        Dim dtCostosTotales As New DataTable
        Dim dtFechas As New DataTable
        Dim dtDistribucionItem As New DataTable
        dtTipoCambio = dsEnvioABB.Tables(0).Copy
        dtCostosTotales = dsEnvioABB.Tables(1).Copy
        dtFechas = dsEnvioABB.Tables(2).Copy
        dtDistribucionItem = dsEnvioABB.Tables(3).Copy

        If dtTipoCambio.Rows.Count > 0 Then
            If dtTipoCambio.Rows(0)("IVNTA") = 0 Then
                msg = "*El tipo de cambio no puede ser valor cero" & Chr(13) & "(Los costos se enviarán con valor cero)."
            End If
        Else
            msg = "*No existe tipo cambio a la Fecha  Numeración de DUA o Pago Derecho." & Chr(13) & "( Los costos se enviarán con valor cero)."
        End If
        msg = msg.Trim
        If dtFechas.Rows.Count > 0 Then
            Dim msgFechas As String = ""
            If dtFechas.Rows(0)("FAPREV") = 0 Then
                msgFechas = msgFechas & Chr(13) & "ETD"
            End If
            If dtFechas.Rows(0)("FAPRAR") = 0 Then
                msgFechas = msgFechas & Chr(13) & "ETA"
            End If
            If dtFechas.Rows(0)("CHK_FAPREV") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Embarque"
            End If
            If dtFechas.Rows(0)("CHK_FAPRAR") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Llegada"
            End If
            If dtFechas.Rows(0)("CHK_FECNUM") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Numeración"
            End If
            If dtFechas.Rows(0)("CHK_FECPGD") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Pago Derecho"
            End If
            If dtFechas.Rows(0)("CHK_FECLEV") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Levante"
            End If
            If dtFechas.Rows(0)("CHK_FECALM") = 0 Then
                msgFechas = msgFechas & Chr(13) & "F. Entrega Almacén"
            End If
            If msgFechas.Length > 0 Then
                msg = msg & Chr(13) & "*Checkpoint sin Fecha:"
                msg = msg & Chr(13) & msgFechas
            End If
        Else
            msg = msg & Chr(13) & "*CheckPoint no registrados."
        End If
        msg = msg.Trim
        If dtCostosTotales.Rows.Count = 0 Then
            msg = msg & Chr(13) & "*Costos generales del embarque no ingresado."
        Else
            Dim ValorOrigen As Decimal = 0
            Dim ValorDestino As Decimal = 0
            Dim msgCosto As String = ""
            Dim numCostos As Int32 = 0
            ValorOrigen = CostoEmbarque("CIF", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("CIF", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = "CIF(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("FOB", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("FOB", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "FOB(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("FLETE", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("FLETE", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "FLETE(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("SEGURO", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("SEGURO", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "SEGURO(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("ADVALO", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("ADVALO", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "ADVALOREM(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("ALMLOC", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("ALMLOC", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Almacenaje Local(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("CARDES", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("CARDES", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Carga y Descarga en Almacén(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("HANDLI", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("HANDLI", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Handling(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("TASDES", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("TASDES", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Tasa Despacho(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("SOBTAS", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("SOBTAS", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "SobreTasa(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("DERESP", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("DERESP", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Derechos Específico(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("ANTDUM", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("ANTDUM", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Antidumping(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("IMSECO", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("IMSECO", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "ISC(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("INTCOM", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("INTCOM", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Interés Compensatorio(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("MORA", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("MORA", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Mora(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If

            ValorOrigen = CostoEmbarque("ITTCAG", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("ITTCAG", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Comisión Agencia(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            ValorOrigen = CostoEmbarque("ITTGOA", dtCostosTotales)
            ValorDestino = CostoEmbarqueDetalle("ITTGOA", dtDistribucionItem)
            If ValorOrigen <> ValorDestino Then
                msgCosto = msgCosto & "Gastos Operativos(" & Convert.ToDouble((ValorOrigen - ValorDestino)) & "),"
                numCostos += 1
                msgCosto = formatoMsgValCosto(msgCosto, numCostos)
            End If
            msgCosto = msgCosto.Trim
            If msgCosto.Length > 0 Then
                msg = msg & Chr(13) & "*Existen diferencias entre el costo general y su costo distribuído:" & Chr(13) & msgCosto
            End If
        End If
        Return msg.Trim
    End Function

    Public Function ListarOCRegularizados_ABB(ByVal PNNORSCI As Decimal) As DataTable
        Return oDocApertura.ListarOCRegularizados_ABB(PNNORSCI)
    End Function
    Private Function formatoMsgValCosto(ByVal msg As String, ByVal numCostos As Int32) As String
        Dim msgRetorno As String = ""
        Select Case numCostos
            Case Is > 5
                msgRetorno = msg & Chr(13)
            Case Is > 10
                msgRetorno = msg & Chr(13)
            Case Is > 15
                msgRetorno = msg & Chr(13)
            Case Is > 20
                msgRetorno = msg & Chr(13)
        End Select
        Return msgRetorno
    End Function


    Private Function CostoEmbarque(ByVal CODVAR As String, ByVal dtCostos As DataTable) As Decimal
        Dim dr() As DataRow
        Dim Costo As Decimal = 0
        dr = dtCostos.Select("CODVAR='" & CODVAR & "'")
        If dr.Length > 0 Then
            Costo = dr(0)("IVLDOL")
        End If
        Return Costo
    End Function
    Private Function CostoEmbarqueDetalle(ByVal CODVAR As String, ByVal dtCostosItem As DataTable) As Decimal
        Dim Costo As Object
        Dim CostoEnvio As Decimal = 0
        Costo = dtCostosItem.Compute("SUM(IVLDOL)", "CODVAR='" & CODVAR & "'")
        If Costo IsNot DBNull.Value Then
            CostoEnvio = Costo
        End If
        Return CostoEnvio
    End Function
#End Region
End Class
