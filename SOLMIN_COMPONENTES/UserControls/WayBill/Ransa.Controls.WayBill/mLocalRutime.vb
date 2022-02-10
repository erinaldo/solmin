Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.Waybill


Public Module mLocalRutime

    ''' <summary>
    ''' Dagnino 09/25/2015
    ''' </summary>
    ''' <remarks></remarks>
    Public Function fblnRegistrarBultosAlPreDespacho(ByVal oWayBill As cWayBill, ByVal Bultos As List(Of TD_Sel_Bulto_L01), ByVal sCriterioLote As String, _
                                                     ByVal pUsuario As String, ByRef sMessage As String, ByRef nroPreDespacho As String) As Boolean
        ' Variable para registrar el Status de la Operación
        Dim bResultado As Boolean = True
        ' Iniciamos el proceso de Pre-Despacho
        Dim Status As TD_Secuencia = New TD_Secuencia
        Status.pCTPCTR_TipoSecuencia = "EZOL19"
        Status.pSTADEF_StatusDefinitivo = "S"
        Status.pUSUARI_Usuario = pUsuario
        Dim iNroPreDespacho As Int64 = oWayBill.fintObtener_Secuencia(Status)



        If oWayBill.ErrorMessage <> "" Then
            sMessage = oWayBill.ErrorMessage
            bResultado = False
        Else
            If iNroPreDespacho = 0 Then
                sMessage = "Error al generar Nro. de Pre-Despacho."
                bResultado = False
            Else
                If oWayBill.fblnRegistrar_PreDespacho(iNroPreDespacho, sCriterioLote, Bultos, pUsuario) Then
                    bResultado = True
                    sMessage = "Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Pre-Despacho : " & iNroPreDespacho
                    nroPreDespacho = iNroPreDespacho
                Else
                    'iNroPreDespacho = oWayBill.ErrorMessage
                    bResultado = False
                End If
            End If
        End If
        Return bResultado
    End Function




    Public Function RegistrarPreDespacho(ByVal Bultos As List(Of TD_Sel_Bulto_L01), ByVal sCriterioLote As String, _
                                                    ByVal pUsuario As String, ByRef sMessage As String, ByRef nroPreDespacho As String) As String
        ' Variable para registrar el Status de la Operación
        'Dim bResultado As Boolean = True

        Dim oWayBill As New DAO.WayBill.cWayBill
        'Dim msgError As String = ""
        sMessage = ""
        Dim iNroPreDespacho As Decimal = oWayBill.Generar_Cab_PreDespacho(Bultos(0).pCCMPN_Compania, Bultos(0).pCDVSN_Division, Bultos(0).pCPLNDV_Planta, Bultos(0).pCCLNT_CodigoCliente, "PRED", pUsuario, "", sMessage)
        nroPreDespacho = iNroPreDespacho
        'If msgError.Length > 0 Then
        '    sMessage = msgError
        '    Return sMessage
        'End If
        If sMessage.Length = 0 And iNroPreDespacho > 0 Then
            oWayBill.fblnRegistrar_Detalle_PreDespacho(iNroPreDespacho, sCriterioLote, Bultos, pUsuario)
        End If

        Return sMessage
    End Function

End Module