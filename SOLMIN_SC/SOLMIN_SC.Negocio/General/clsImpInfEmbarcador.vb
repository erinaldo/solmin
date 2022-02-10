Imports SOLMIN_SC.Negocio.WSmiqpowerplus
Imports SOLMIN_SC.Entidad

Public Class clsImpInfEmbarcador
    Private objRansYrc As WSmiqpowerplus.AddData
    Private strEmbarque As String
    Private objImpInfEmbarcador As SOLMIN_SC.Datos.clsImpInfEmbarcador
    Private objPortalDetalle As SOLMIN_SC.Entidad.bePortalDetalle

    Sub New()
        objRansYrc = New WSmiqpowerplus.AddData
        objImpInfEmbarcador = New SOLMIN_SC.Datos.clsImpInfEmbarcador
    End Sub

    Property Embarque()
        Get
            Return strEmbarque
        End Get
        Set(ByVal value)
            strEmbarque = value
        End Set
    End Property

    Public Function Obtener_Informacion_Embarque() As DataTable
        Dim dstTemp As DataSet = Nothing

        dstTemp = objRansYrc.GetDataSet(typeTable.t005, "SNROEMB", strEmbarque)
        Return dstTemp.Tables("t005")
    End Function

    Public Function Obtener_Informacion_Total() As DataTable
        Dim dstTemp As DataSet = Nothing

        dstTemp = objRansYrc.GetDataSet(typeTable.t005)
        Return dstTemp.Tables("t005")
    End Function

    Public Function Enviar_T005(ByVal pdblEmbarque As Double) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String
        Dim oDt As DataTable
        oDt = objImpInfEmbarcador.Lista_Datos_T005(pdblEmbarque)
        dstTemp.Tables.Add(oDt.Copy)
        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t005, "SIDRNS , NORDAGE , DORDAGE , STIPREG , SNOMTER ,SCANAL , SDIALIB , SSOBEST ,SOBS ,SDUA")
        Return strCadena
    End Function

    Public Function Enviar_T008(ByVal pdblEmbarque As Double) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String = ""
        Dim oDt As DataTable

        oDt = objImpInfEmbarcador.Lista_Datos_T008(pdblEmbarque)
        'oDt.Rows.RemoveAt(2)
        'oDt.Rows.RemoveAt(1)
        'If oDt.Rows.Count > 0 Then

        '    Dim DT_t008 As New DataTable
        '    DT_t008 = oDt.Copy
        '    Dim dstt008 As DataSet = New DataSet
        '    Dim TOT_FILA_t008 As Int32 = 0
        '    Dim drt008 As DataRow
        '    Dim dtt008TMP As New DataTable
        '    dtt008TMP = DT_t008.Clone
        '    TOT_FILA_t008 = DT_t008.Rows.Count - 1
        '    For FILA As Integer = 0 To TOT_FILA_t008
        '        dtt008TMP.Rows.Clear()
        '        dstTemp.Tables.Clear()
        '        drt008 = dtt008TMP.NewRow
        '        For COLUMNA As Integer = 0 To dtt008TMP.Columns.Count - 1
        '            drt008(COLUMNA) = DT_t008.Rows(FILA)(COLUMNA)
        '        Next
        '        dtt008TMP.Rows.Add(drt008)
        '        dstTemp.Tables.Add(dtt008TMP.Copy)
        '        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t008)
        '    Next

        'End If     
        dstTemp.Tables.Add(oDt.Copy)



        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t008)
        Return strCadena
    End Function

    Public Function Enviar_T007(ByVal pdblEmbarque As Double) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String
        Dim oDt As DataTable
        oDt = objImpInfEmbarcador.Lista_Datos_T007(pdblEmbarque)
        dstTemp.Tables.Add(oDt.Copy)
        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t007)
        Return strCadena
    End Function

    Public Function Enviar_T013(ByVal pdblEmbarque As Double) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String
        Dim oDt As DataTable

        oDt = objImpInfEmbarcador.Lista_Datos_T013(pdblEmbarque)
        dstTemp.Tables.Add(oDt.Copy)
        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t013)
        Return strCadena
    End Function

    Public Function Cambiar_Status_T002(ByVal pdblEmbarque As Double, ByVal pstrAlmacen As String) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String
        Dim oDt As DataTable

        oDt = objImpInfEmbarcador.Lista_Cambiar_Status_T002(pdblEmbarque, pstrAlmacen)

        If oDt.Rows.Count > 0 Then
            Dim sCliente As String = ""
            Dim sOrdenCompra As String = ""
            Dim sItem As String = ""
            Dim dAduanasYRC As Decimal = 0.0
            Dim dValorAlmacenRNS As Decimal = 0.0
            Dim dValorBondedRNS As Decimal = 0.0
            Dim dValorAlmacenYRC As Decimal = 0.0
            Dim dValorBondedYRC As Decimal = 0.0
            Dim strOrdenCompraAnterior As String = ""
            Dim intCont As Integer = 0
            ' Resultado de la Consulta a la Tabla de YRC
            Dim rwResultado() As DataRow
            Dim dtTempYRC As DataTable = Nothing

            While intCont < oDt.Rows.Count
                ' Obtenemos los valores a ser consultados
                sCliente = oDt.Rows(intCont).Item("CCLIENT")
                sOrdenCompra = oDt.Rows(intCont).Item("SNROOC")
                sItem = oDt.Rows(intCont).Item("SNROITE")
                dValorAlmacenRNS = oDt.Rows(intCont).Item("NCNTRECALM")
                dValorBondedRNS = oDt.Rows(intCont).Item("NCNTSTKALM")

                ' Obtenemos información del WebServices solo si la orden de compra a cambiado
                If strOrdenCompraAnterior <> sOrdenCompra Then
                    dtTempYRC = objRansYrc.GetDataSet(typeTable.t002, "CCLIENT=" & sCliente & " AND SNROOC='" & sOrdenCompra & "'").Tables(0).Copy
                    strOrdenCompraAnterior = sOrdenCompra
                End If

                rwResultado = dtTempYRC.Select("SNROITE='" & sItem & "'")
                If rwResultado.Length > 0 Then
                    dAduanasYRC = rwResultado(0).Item("NCNTRECDES")
                    dValorAlmacenYRC = rwResultado(0).Item("NCNTRECALM")
                    dValorBondedYRC = rwResultado(0).Item("NCNTSTKALM")
                End If
                dAduanasYRC = dAduanasYRC - (dValorAlmacenRNS + dValorBondedRNS)
                If dAduanasYRC < 0 Then dAduanasYRC = 0
                oDt.Rows(intCont).Item("NCNTRECDES") = dAduanasYRC
                oDt.Rows(intCont).Item("NCNTRECALM") = dValorAlmacenRNS + dValorAlmacenYRC
                oDt.Rows(intCont).Item("NCNTSTKALM") = dValorBondedRNS + dValorBondedYRC

                intCont += 1
            End While
        End If
        dstTemp.Tables.Add(oDt)
        strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t002, "NCNTRECDES,NCNTRECALM,NCNTSTKALM")
        Return strCadena
    End Function

    Public Function Lista_Status_Envio_Embarcador(ByVal pdblEmbarque As Double) As DataTable
        Return objImpInfEmbarcador.Lista_Status_Envio_Embarcador(pdblEmbarque)
    End Function

    Public Sub Agregar_Cambio_Status(ByVal pdblEmbarque As Double)
        Try
            objImpInfEmbarcador.Agregar_Cambio_Status(pdblEmbarque)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Enviar_T006(ByVal pdblEmbarque As Double) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String = ""
        dstTemp = objImpInfEmbarcador.Lista_Datos_T006(pdblEmbarque)

        If dstTemp.Tables(0).Rows.Count > 0 Then
            Dim DT_T011 As New DataTable
            DT_T011 = dstTemp.Tables(0).Copy
            Dim dstT011 As DataSet = New DataSet
            Dim TOT_FILA_T011 As Int32 = 0
            Dim drT011 As DataRow
            Dim dtT011TMP As New DataTable
            dtT011TMP = DT_T011.Clone
            TOT_FILA_T011 = dstTemp.Tables(0).Rows.Count - 1
            For FILA As Integer = 0 To TOT_FILA_T011
                dtT011TMP.Rows.Clear()
                dstT011.Tables.Clear()
                drT011 = dtT011TMP.NewRow
                For COLUMNA As Integer = 0 To dtT011TMP.Columns.Count - 1
                    drT011(COLUMNA) = DT_T011.Rows(FILA)(COLUMNA)
                Next
                dtT011TMP.Rows.Add(drT011)
                dstT011.Tables.Add(dtT011TMP.Copy)
                strCadena = objRansYrc.sendDataSet(dstT011, typeTable.t006)
            Next

        End If
        If dstTemp.Tables(1).Rows.Count > 0 Then
            Dim DT_T006 As New DataTable
            DT_T006 = dstTemp.Tables(1).Copy
            Dim dstT006 As DataSet = New DataSet
            Dim TOT_FILA_T006 As Int32 = 0
            Dim drT006 As DataRow
            Dim dtT006TMP As New DataTable
            dtT006TMP = DT_T006.Clone
            TOT_FILA_T006 = DT_T006.Rows.Count - 1
            For FILA As Integer = 0 To TOT_FILA_T006
                dtT006TMP.Rows.Clear()
                dstT006.Tables.Clear()
                drT006 = dtT006TMP.NewRow
                For COLUMNA As Integer = 0 To dtT006TMP.Columns.Count - 1
                    drT006(COLUMNA) = DT_T006.Rows(FILA)(COLUMNA)
                Next
                dtT006TMP.Rows.Add(drT006)
                dstT006.Tables.Add(dtT006TMP.Copy)
                strCadena = objRansYrc.sendDataSet(dstT006, typeTable.t006)
            Next
        End If
        'dstT011.Tables.Add(dstTemp.Tables(0).Copy)
        'dstT006.Tables.Add(dstTemp.Tables(1).Copy)
        'strCadena = objRansYrc.sendDataSet(dstT011, typeTable.t011)
        'strCadena = objRansYrc.sendDataSet(dstT006, typeTable.t006)
        Return strCadena
    End Function

    Public Function Actualizar_Status_OC_Almacenes(ByVal CCLNT As Decimal, ByVal CCLNT_PORTAL As Decimal) As String
        Dim dstTemp As New DataSet
        Dim strCadena As String = ""
        Dim dtEnviarT002 As DataTable = Nothing
        Dim bStatusEnviar As Boolean = False
        'Dim CCLNT_PORTAL As Decimal = 0
        'Dim oCliente As New clsCliente
        Try
            'CCLNT_PORTAL = oCliente.fdsCodigoClienteDelPortar(CCLNT)
            dstTemp = objRansYrc.GetDataSet(typeTable.t002, " CCLIENT='" & CCLNT_PORTAL & "'")
            'objRansYrc.GetDataSet(
            If dstTemp.Tables("t002").Rows.Count > 0 Then
                dtEnviarT002 = dstTemp.Tables("t002").Clone
            Else
                Return strCadena = "No existe información."
                Exit Function
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try

        Dim iCont As Int32 = 0
        Dim sOrdenCompra As String = ""
        Dim sErrorMessage As String = ""
        Dim dtInfRNS As DataTable = Nothing
        ' Comenzamos a recorrer cada item de la T002
        With dstTemp.Tables("t002")
            While iCont < .Rows.Count '211
                ' Si cambia la Orden de Compra 
                If sOrdenCompra <> .Rows(iCont).Item("SNROOC") Then
                    sOrdenCompra = .Rows(iCont).Item("SNROOC")
                    'dtInfRNS = objImpInfEmbarcador.Lista_Datos_T002_Actualizar_Status(2287, sOrdenCompra)
                    dtInfRNS = objImpInfEmbarcador.Lista_Datos_T002_Actualizar_Status(CCLNT, sOrdenCompra)
                    If sErrorMessage <> "" Then
                        strCadena = sErrorMessage
                        Return strCadena
                        Exit Function
                    End If
                End If
                ' Si tiene Filas, se evalua el Item de YRC y el Item de RNS
                If dtInfRNS.Rows.Count > 0 Then
                    Dim iCont2 As Int32 = 0
                    Dim iCol1 As Int32 = 0
                    ' Encontramos el Item
                    While iCont2 < dtInfRNS.Rows.Count
                        ' Si encontramos el Item, procedemos a evaluar
                        If .Rows(iCont).Item("SNROITE") = dtInfRNS.Rows(iCont2).Item("NRITOC").ToString.Trim Then
                            ' Evaluamos que la cantidad despachada sea diferente de Cero
                            If dtInfRNS.Rows(iCont2).Item("QCNDPC") > 0 Then
                                ' Evaluamos que la cantidad despachada sea diferente al valor YRC
                                If .Rows(iCont).Item("NCNTALMDES") <> dtInfRNS.Rows(iCont2).Item("QCNDPC") Then
                                    .Rows(iCont).Item("NCNTALMDES") = dtInfRNS.Rows(iCont2).Item("QCNDPC")
                                    If .Rows(iCont).Item("NCNTRECALM") <> 0 Then _
                                        .Rows(iCont).Item("NCNTRECALM") = dtInfRNS.Rows(iCont2).Item("QSTKIT")
                                    If .Rows(iCont).Item("NCNTSTKALM") <> 0 Then _
                                        .Rows(iCont).Item("NCNTSTKALM") = dtInfRNS.Rows(iCont2).Item("QSTKIT")
                                End If
                                bStatusEnviar = True
                                ' Guardamos la fila Modificada en otra tabla perteneciente a otro dataset para luego ser enviada
                                iCol1 = 0
                                Dim rwTemp As DataRow = dtEnviarT002.NewRow
                                While iCol1 < .Columns.Count
                                    rwTemp.Item(iCol1) = .Rows(iCont).Item(iCol1)
                                    iCol1 += 1
                                End While
                                dtEnviarT002.Rows.Add(rwTemp)
                            End If
                            Exit While
                        End If
                        iCont2 += 1
                    End While
                End If
                iCont += 1
            End While
            If bStatusEnviar Then
                If dtEnviarT002.Rows.Count > 0 Then
                    'Dim dstEnviarT002 As DataSet = New DataSet
                    Dim DT_T002 As New DataTable
                    DT_T002 = dtEnviarT002.Copy
                    Dim dstT002 As DataSet = New DataSet
                    Dim TOT_FILA_T002 As Int32 = 0
                    Dim drT002 As DataRow
                    Dim dtT002TMP As New DataTable
                    dtT002TMP = DT_T002.Clone
                    TOT_FILA_T002 = DT_T002.Rows.Count - 1
                    For FILA As Integer = 0 To TOT_FILA_T002
                        dtT002TMP.Rows.Clear()
                        dstT002.Tables.Clear()
                        drT002 = dtT002TMP.NewRow
                        For COLUMNA As Integer = 0 To dtT002TMP.Columns.Count - 1
                            drT002(COLUMNA) = DT_T002.Rows(FILA)(COLUMNA)
                        Next
                        dtT002TMP.Rows.Add(drT002)
                        dstT002.Tables.Add(dtT002TMP.Copy)
                        strCadena = objRansYrc.sendDataSet(dstT002, typeTable.t002)
                    Next
                    'dstEnviarT002.Tables.Add(dtEnviarT002)
                    'strCadena = objRansYrc.sendDataSet(dstEnviarT002, typeTable.t002)
                End If
            Else
                strCadena = "No existe información para actualizar."
            End If
        End With
        Return strCadena

    End Function

    Public Function Obtener_Informacion_T002_OC_ITEMS(ByVal codCliYRC As Integer) As DataTable
        Return objRansYrc.GetDataSet(WSyrcRns.typeTable.t002, "CCLIENT=" & codCliYRC).Tables("t002")
    End Function

    Public Function Valida_Resumen_Filtro(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow() = Nothing

        If objPD.PSFILTRO = "REDE" Then
            objListaDr = objPD.PSTABLA.Select("NCNTRECDES <> 0 ", "SNROOC, SNROITE ASC")
        End If
        If objPD.PSFILTRO = "REAL" Then
            objListaDr = objPD.PSTABLA.Select("NCNTRECALM <> 0", "SNROOC, SNROITE ASC")
        End If
        objDt = objPD.PSTABLA.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
            objDr(7) = objListaDr(lintCont).Item(7)
            objDr(8) = objListaDr(lintCont).Item(8)
            objDr(9) = objListaDr(lintCont).Item(9)
            objDr(10) = objListaDr(lintCont).Item(10)
            objDr(11) = objListaDr(lintCont).Item(11)
            objDr(12) = objListaDr(lintCont).Item(12)
            objDr(13) = objListaDr(lintCont).Item(13)
            objDr(14) = objListaDr(lintCont).Item(14)
            objDr(15) = objListaDr(lintCont).Item(15)
            objDr(16) = objListaDr(lintCont).Item(16)
            objDr(17) = objListaDr(lintCont).Item(17)
            objDr(18) = objListaDr(lintCont).Item(18)
            objDr(19) = objListaDr(lintCont).Item(19)
            objDr(20) = objListaDr(lintCont).Item(20)
            objDr(21) = objListaDr(lintCont).Item(21)
            objDr(22) = objListaDr(lintCont).Item(22)
            objDr(23) = objListaDr(lintCont).Item(23)
            objDr(24) = objListaDr(lintCont).Item(24)
            objDr(25) = objListaDr(lintCont).Item(25)
            objDr(26) = objListaDr(lintCont).Item(26)
            objDr(27) = objListaDr(lintCont).Item(27)
            objDr(28) = objListaDr(lintCont).Item(28)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function
    Public Function Valida_Resumen_T002_Aduanas(ByVal oDtValidado As DataTable, ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As DataTable
        Dim cuentaEncontrados As Integer = 0
        Dim encontro As Boolean = False
        Dim filtro As String = ""
        Dim sumaA As Integer = 0
        Dim sumaC As Integer = 0
        Dim sumaEmbarcado As Integer = 0
        Dim sumaTempA As Integer = 0
        Dim sumaTempC As Integer = 0

        Dim dtEmbarcado As New DataTable
        dtEmbarcado = objImpInfEmbarcador.Obtener_Informacion_T002_OC_EMBARQUE(objPD.PSCLIENTE_SOL)

        Dim dtNew As New DataTable
        dtNew = oDtValidado.Clone
        dtNew.Columns(2).DataType = GetType(String)
        dtNew.Columns.Add("Status")
        dtNew.Columns.Add("QRLCSC_C")
        dtNew.Columns.Add("QRLCSC_A")
        dtNew.Columns.Add("SESTRG_C")
        dtNew.Columns.Add("SESTRG_A")

        Dim dtRepetidos As New DataTable

        If oDtValidado.Rows.Count > 0 Then
            For i As Integer = 0 To oDtValidado.Rows.Count - 1
                dtNew.ImportRow(oDtValidado.Rows(i))
                '--------------Buscamos Registro en MINERIA ADUANAS------------------------
                If dtEmbarcado.Rows.Count > 0 Then
                    For k As Integer = 0 To dtEmbarcado.Rows.Count - 1
                        'Validamos Cantidad Recibida
                        If CStr(oDtValidado.Rows(i).Item("SNROOC")).Trim = CStr(dtEmbarcado.Rows(k).Item("NORCML")).Trim Then
                            If CStr(oDtValidado.Rows(i).Item("SNROITE")).Trim = CStr(dtEmbarcado.Rows(k).Item("NRITEM")).Trim Then
                                cuentaEncontrados = cuentaEncontrados + 1
                                If cuentaEncontrados < 2 Then
                                    dtNew.Rows(i).Item("Status") = 1
                                    If dtEmbarcado.Rows(k).Item("SESTRG") = "A" Then
                                        dtNew.Rows(i).Item("QRLCSC_A") = dtEmbarcado.Rows(k).Item("QRLCSC")
                                        dtNew.Rows(i).Item("SESTRG_A") = dtEmbarcado.Rows(k).Item("SESTRG")
                                        sumaTempA = sumaTempA + dtEmbarcado.Rows(k).Item("QRLCSC")
                                    End If
                                    If dtEmbarcado.Rows(k).Item("SESTRG") = "C" Then
                                        dtNew.Rows(i).Item("QRLCSC_C") = dtEmbarcado.Rows(k).Item("QRLCSC")
                                        dtNew.Rows(i).Item("SESTRG_C") = dtEmbarcado.Rows(k).Item("SESTRG")
                                        sumaTempC = sumaTempC + dtEmbarcado.Rows(k).Item("QRLCSC")
                                    End If
                                    encontro = True
                                Else
                                    If dtEmbarcado.Rows(k).Item("SESTRG") = "A" Then
                                        sumaEmbarcado = sumaEmbarcado + dtEmbarcado.Rows(k).Item("QRLCSC") + sumaTempA
                                        filtro = "CCLIENT=" & objPD.PSCLIENTE & " AND SNROOC = '" & CStr(dtEmbarcado.Rows(k).Item("NORCML")).Trim & "' AND SNROITE = '" & CStr(dtEmbarcado.Rows(k).Item("NRITEM")).Trim & "' AND SIDYRC='" & CStr(dtEmbarcado.Rows(k).Item("NOREMB")).Trim & "'"
                                        dtRepetidos = objRansYrc.GetDataSet(WSyrcRns.typeTable.t003, filtro).Tables("t003")
                                        If dtRepetidos.Rows.Count > 0 Then
                                            For z As Integer = 0 To dtRepetidos.Rows.Count - 1
                                                sumaA = sumaA + dtRepetidos.Rows(z).Item("NCANT")
                                            Next
                                        End If
                                        dtNew.Rows(i).Item("QRLCSC_A") = dtNew.Rows(i).Item("NCNTRECDES") - sumaA + sumaEmbarcado
                                    End If
                                    If dtEmbarcado.Rows(k).Item("SESTRG") = "C" Then
                                        sumaEmbarcado = sumaEmbarcado + dtEmbarcado.Rows(k).Item("QRLCSC") + sumaTempC
                                        sumaC = sumaC + sumaEmbarcado
                                        dtNew.Rows(i).Item("QRLCSC_C") = sumaC
                                    End If
                                    Console.WriteLine("Caso Atipico para validar" & CStr(cuentaEncontrados) & " - " & _
                                                  CStr(oDtValidado.Rows(i).Item("SNROITE")).Trim & " - " & _
                                                  CStr(oDtValidado.Rows(i).Item("SNROOC")).Trim & " - " & _
                                                  CStr(dtEmbarcado.Rows(k).Item("SESTRG")) & ".")
                                End If
                            End If
                        End If
                    Next
                    'Inicializo contadores y sumadores
                    cuentaEncontrados = 0
                    sumaA = 0
                    sumaC = 0
                    sumaEmbarcado = 0
                    sumaTempA = 0
                    sumaTempC = 0
                    '---------------------------------
                End If
                'Termina de Buscar y no encuentra Guardamos como no encontrado
                If encontro = False Then
                    dtNew.Rows(i).Item("Status") = 2
                Else
                    encontro = False
                End If
            Next
        End If
        Return dtNew
    End Function
    Public Function Valida_Resumen_T002_Aduanas_Validados(ByVal odtValidado As DataTable) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = odtValidado.Select("Status = 1")

        objDt = odtValidado.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
            objDr(7) = objListaDr(lintCont).Item(7)
            objDr(8) = objListaDr(lintCont).Item(8)
            objDr(9) = objListaDr(lintCont).Item(9)
            objDr(10) = objListaDr(lintCont).Item(10)
            objDr(11) = objListaDr(lintCont).Item(11)
            objDr(12) = objListaDr(lintCont).Item(12)
            objDr(13) = objListaDr(lintCont).Item(13)
            objDr(14) = objListaDr(lintCont).Item(14)
            objDr(15) = objListaDr(lintCont).Item(15)
            objDr(16) = objListaDr(lintCont).Item(16)
            objDr(17) = objListaDr(lintCont).Item(17)
            objDr(18) = objListaDr(lintCont).Item(18)
            objDr(19) = objListaDr(lintCont).Item(19)
            objDr(20) = objListaDr(lintCont).Item(20)
            objDr(21) = objListaDr(lintCont).Item(21)
            objDr(22) = objListaDr(lintCont).Item(22)
            objDr(23) = objListaDr(lintCont).Item(23)
            objDr(24) = objListaDr(lintCont).Item(24)
            objDr(25) = objListaDr(lintCont).Item(25)
            objDr(26) = objListaDr(lintCont).Item(26)
            objDr(27) = objListaDr(lintCont).Item(27)
            objDr(28) = objListaDr(lintCont).Item(28)

            objDr(29) = objListaDr(lintCont).Item(29)
            objDr(30) = objListaDr(lintCont).Item(30)
            objDr(31) = objListaDr(lintCont).Item(31)
            objDr(32) = objListaDr(lintCont).Item(32)
            objDr(33) = objListaDr(lintCont).Item(33)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function
    '---------Actualiza toda la Grilla al nivelSiguiente (Almacen)---------------------
    Public Function Actualiza_Aduanas_T002(ByVal oDtValidos As DataTable) As String
        'REEMPLAZAMOS LA CANTIDAD
        For i As Integer = 0 To oDtValidos.Rows.Count - 1
            If IsDBNull(oDtValidos.Rows(i).Item("QRLCSC_A")) Then
                oDtValidos.Rows(i).Item("QRLCSC_A") = 0
            End If
            If oDtValidos.Rows(i).Item("QRLCSC_A") <> oDtValidos.Rows(i).Item("NCNTRECDES") Then
                oDtValidos.Rows(i).Item("NCNTRECALM") = oDtValidos.Rows(i).Item("NCNTRECALM") + oDtValidos.Rows(i).Item("NCNTRECDES")
                oDtValidos.Rows(i).Item("NCNTRECDES") = IIf(IsDBNull(oDtValidos.Rows(i).Item("QRLCSC_A")), 0, oDtValidos.Rows(i).Item("QRLCSC_A"))
            End If
        Next
        'Quitamos Columnas no pertenecietnes al DataSet
        oDtValidos.Columns.Remove("Status")
        oDtValidos.Columns.Remove("QRLCSC_A")
        oDtValidos.Columns.Remove("QRLCSC_C")
        oDtValidos.Columns.Remove("SESTRG_A")
        oDtValidos.Columns.Remove("SESTRG_C")

        Dim strCadena As String = ""
        Dim dstTemp As New DataSet
        dstTemp.Tables.Add(oDtValidos)
        Try
            strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t002)
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
        Return strCadena
    End Function
   
    '---------Actualiza Registro al nivel Siguiente (Almacen)---------------------
    Public Function Actualiza_Almacen_Unitario(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As String
        Dim strCadena As String = ""
        Dim filtro As String = ""
        Dim oDtValido As DataTable
        Dim oDtEnviar As DataTable
        Dim dstTemp As New DataSet
        filtro = "CCLIENT=" & objPD.PSCLIENTE & " AND SNROOC = '" & objPD.PSORDENCOMPRA & "' AND SNROITE = '" & objPD.PSITEM & "' "
        Try
            oDtValido = objRansYrc.GetDataSet(WSyrcRns.typeTable.t002, filtro).Tables("t002")
            oDtEnviar = oDtValido.Clone
            oDtEnviar = oDtValido.Copy
            For i As Integer = 0 To oDtEnviar.Rows.Count - 1
                oDtEnviar.Rows(i).Item("NCNTRECALM") = oDtEnviar.Rows(i).Item("NCNTRECALM") + oDtEnviar.Rows(i).Item("NCNTRECDES") - objPD.PNCNTALMACEN
                oDtEnviar.Rows(i).Item("NCNTRECDES") = objPD.PNCNTALMACEN
            Next
            dstTemp.Tables.Add(oDtEnviar)
            strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t002)
            'strCadena = "Se actualizo - " & filtro
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
        Return strCadena
    End Function
    '---------Actualiza Registro al nivel Siguiente (Destino Cliente)---------------------
    Public Function Actualiza_Destino_Cliente_Unitario(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As String
        Dim strCadena As String = ""
        Dim filtro As String = ""
        Dim oDtValido As DataTable
        Dim oDtEnviar As DataTable
        Dim dstTemp As New DataSet
        filtro = "CCLIENT=" & objPD.PSCLIENTE & " AND SNROOC = '" & objPD.PSORDENCOMPRA & "' AND SNROITE = '" & objPD.PSITEM & "' "
        Try
            oDtValido = objRansYrc.GetDataSet(WSyrcRns.typeTable.t002, filtro).Tables("t002")
            oDtEnviar = oDtValido.Clone
            oDtEnviar = oDtValido.Copy
            For i As Integer = 0 To oDtEnviar.Rows.Count - 1
                If objPD.PSFILTRO = "REDE" Then
                    oDtEnviar.Rows(i).Item("NCNTTRADES") = oDtEnviar.Rows(i).Item("NCNTTRADES") + oDtEnviar.Rows(i).Item("NCNTRECDES") - objPD.PNCNTALMACEN
                    oDtEnviar.Rows(i).Item("NCNTRECDES") = objPD.PNCNTALMACEN
                Else
                    oDtEnviar.Rows(i).Item("NCNTTRADES") = oDtEnviar.Rows(i).Item("NCNTTRADES") + oDtEnviar.Rows(i).Item("NCNTRECALM") - objPD.PNCNTCLIENTE
                    oDtEnviar.Rows(i).Item("NCNTRECALM") = objPD.PNCNTCLIENTE
                End If
            Next
            dstTemp.Tables.Add(oDtEnviar)
            strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.t002)
            'strCadena = "Se actualizo - " & filtro
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
        Return strCadena
    End Function

    Public Function Valida_Resumen_T002_Almacen(ByVal oDtValidado As DataTable, ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As DataTable
        Dim cuentaEncontrados As Integer = 0
        Dim encontro As Boolean = False
        Dim filtro As String = ""
        Dim sumaA As Integer = 0
        Dim sumaC As Integer = 0
        Dim sumaEmbarcado As Integer = 0
        Dim sumaTempA As Integer = 0
        Dim sumaTempC As Integer = 0

        Dim dtAlmacen As New DataTable

        Dim dtNew As New DataTable
        dtNew = oDtValidado.Clone
        dtNew.Columns(2).DataType = GetType(String)
        dtNew.Columns.Add("Status")
        dtNew.Columns.Add("QRLCSC_C")
        dtNew.Columns.Add("QRLCSC_A")
        dtNew.Columns.Add("SESTRG_C")
        dtNew.Columns.Add("SESTRG_A")

        dtAlmacen = objImpInfEmbarcador.Obtener_Informacion_T002_OC_ALMACEN(objPD)
        Dim dtRepetidos As New DataTable

        If oDtValidado.Rows.Count > 0 Then
            For i As Integer = 0 To oDtValidado.Rows.Count - 1
                dtNew.ImportRow(oDtValidado.Rows(i))
                '--------------Buscamos Registro en MINERIA ALMACEN------------------------
                If dtAlmacen.Rows.Count > 0 Then
                    For x As Integer = 0 To dtAlmacen.Rows.Count - 1
                        If CStr(dtAlmacen.Rows(x).Item("NORCML")).Trim = CStr(oDtValidado.Rows(i).Item("SNROOC")).Trim() Then
                            If CStr(dtAlmacen.Rows(x).Item("NRITOC")).Trim = CStr(oDtValidado.Rows(i).Item("SNROITE")).Trim() Then
                                If dtAlmacen.Rows(x).Item("QSLCNB") <= oDtValidado.Rows(i).Item("NCNTRECALM") Then
                                    dtNew.Rows(i).Item("Status") = 1
                                    dtNew.Rows(i).Item("QRLCSC_C") = dtAlmacen.Rows(x).Item("QSLCNB")
                                    dtNew.Rows(i).Item("SESTRG_C") = dtAlmacen.Rows(x).Item("SESTRG")
                                    encontro = True
                                End If
                            End If
                        End If
                    Next
                End If
                If encontro = False Then
                    dtNew.Rows(i).Item("Status") = 2
                    dtNew.Rows(i).Item("QRLCSC_C") = 0
                Else
                    encontro = False
                End If
            Next
        End If
        Return dtNew
    End Function

    Public Function Obtener_Informacion_T005(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As DataTable
        'T005 - Embarques
        Dim oDtT005 As DataTable
        'T003 - OC Item Parcial (YRC)
        Dim oDtT003 As DataTable

        Dim filtroT005 As String
        Dim filtroT003 As String
        'Dim pSIDYRC As String = "200808AI00027"

        filtroT003 = "CCLIENT=" & objPD.PSCLIENTE & " AND SNROOC = '" & objPD.PSORDENCOMPRA & "' AND SNROITE = '" & objPD.PSITEM & "' "

        oDtT003 = objRansYrc.GetDataSet(WSyrcRns.typeTable.t007, filtroT003).Tables("t007")
        If oDtT003.Rows.Count = 0 Then
            oDtT003 = objRansYrc.GetDataSet(WSyrcRns.typeTable.t003, filtroT003).Tables("t003")
        End If
        If oDtT003.Rows.Count > 0 Then
            If Not IsDBNull(oDtT003.Rows(0).Item("SIDYRC")) Then
                filtroT005 = "SIDYRC = '" & oDtT003.Rows(0).Item("SIDYRC") & "'"
                oDtT005 = objRansYrc.GetDataSet(WSyrcRns.typeTable.t005, filtroT005).Tables("t005")
                Return oDtT005
            Else
                Return Nothing
                Exit Function
            End If
        Else
            Return Nothing
            Exit Function
        End If
    End Function
    'Maestros YRC
    Public Function Obtener_Informacion_M001_Clientes(ByVal nRuc As String) As String
        'Obtenemos Codigo Cliente YRC
        Try
            Dim dtYrcCliente As DataTable = objRansYrc.GetDataSet(WSyrcRns.typeTable.m001, "SCODFIS='" & nRuc & "'").Tables("m001")
            Dim codCliYRC As Integer
            If dtYrcCliente.Rows.Count > 0 Then
                codCliYRC = dtYrcCliente.Rows(0).Item("CCLIENT")
                Return codCliYRC
            Else
                Return 0
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
    End Function

    Public Function Obtener_Info_M005_Terminal(ByVal key As String) As String
        Try
            Dim dtYrc As DataTable = objRansYrc.GetDataSet(WSyrcRns.typeTable.m005, "CINCOTE='" & key & "'").Tables("m005")
            Dim sYRC As String
            If dtYrc.Rows.Count > 0 Then
                sYRC = dtYrc.Rows(0).Item("SNOMINC")
                Return sYRC
            Else
                Return key
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
    End Function
    Public Function Obtener_Info_M008_Pais(ByVal key As String) As String
        Try
            Dim dtYrc As DataTable = objRansYrc.GetDataSet(WSyrcRns.typeTable.m008, "CPAIS='" & key & "'").Tables("m008")
            Dim sYRC As String
            If dtYrc.Rows.Count > 0 Then
                sYRC = dtYrc.Rows(0).Item("SNOMPAI")
                Return sYRC
            Else
                Return key
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
    End Function
    Public Function Obtener_Info_M009_Puerto(ByVal key1 As String, ByVal key2 As String) As String
        Try
            Dim dtYrc As DataTable = objRansYrc.GetDataSet(WSyrcRns.typeTable.m009, "CPAIS='" & key1 & "' AND  CPTO = '" & key2 & "' ").Tables("m009")
            Dim sYRC As String
            If dtYrc.Rows.Count > 0 Then
                sYRC = dtYrc.Rows(0).Item("SNOMPTO")
                Return sYRC
            Else
                Return key2
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
    End Function
    Public Function Obtener_Info_M011_TipoTransporte(ByVal key As String) As String
        Try
            Dim dtYrc As DataTable = objRansYrc.GetDataSet(WSyrcRns.typeTable.m011, "CTIPTRA='" & key & "'").Tables("m011")
            Dim sYRC As String
            If dtYrc.Rows.Count > 0 Then
                sYRC = dtYrc.Rows(0).Item("STIPTRA")
                Return sYRC
            Else
                Return key
            End If
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
    End Function


    Public Function ObtnerInfoLibre() As DataTable
        Dim odt As New DataTable
        Try
            odt = objRansYrc.GetDataSet(WSyrcRns.typeTable.m004).Tables("M004") ' maestros checkpoint
            'odt = objRansYrc.GetDataSet(WSyrcRns.typeTable.t008, "CCLIENT=88 and  SNROOC='X09501'").Tables("t008")
            '  odt = objRansYrc.GetDataSet(WSyrcRns.typeTable.t004, "CCLIENT=88 and  SNROOC='X09501'").Tables("t004")

            odt.Rows.Clear()
            Dim dr As DataRow
            dr = odt.NewRow
            dr(0) = "RNS124"
            dr(1) = "ENTREGA DE LA CARGA EN ALMACEN DE TRANSITO"
            dr(2) = 1
            dr(3) = 0
            dr(4) = "30/12/2012"
            dr(5) = 0
            dr(6) = "30/12/2012"
            dr(7) = 1

            '
            odt.Rows.Add(dr)
            Dim dstTemp As New DataSet
            Dim strCadena As String = ""
            dstTemp.Tables.Add(odt.Copy)
            '  strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.m004, "CCODCP,FACTIVO")
            ' strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.m004, "CCODCP,SNOMCP,FACTIVO")
            'strCadena = objRansYrc.sendDataSet(dstTemp, typeTable.m004)



            Dim r As String = ""


        Catch ex As Exception
        End Try
        Return odt
    End Function


End Class


