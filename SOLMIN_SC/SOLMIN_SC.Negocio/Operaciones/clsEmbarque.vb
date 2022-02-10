Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports System.Text
Imports Ransa.Utilitario

Public Class clsEmbarque
    Private oEmbarque As Datos.clsEmbarque
    Private oMySql As Datos.clsMySql
    Private obeDatosEmbarque As beDatosEmbarque
    Private _pCCLNT As Decimal = 0
    Private _pNORSCI As Decimal = 0
    Private _pPNNMOS As Decimal = 0
    Private _pCZNFCC As Decimal = 0
    Private _EmbarqueEstado As String = ""
    Private _pCCMPN As String = ""
    Private _pCDVSN As String = ""
    Private _pNCPLNDV As Decimal = 0
    Private _pCMEDTR As Decimal = 0
    Private _pNOREMB As String = ""
    Private _pCCLNT_PORTAL As Decimal = 0
    Sub New()
        oEmbarque = New Datos.clsEmbarque
        obeDatosEmbarque = New beDatosEmbarque
    End Sub

    Public Sub Inicializar()
        _pNORSCI = 0
        _pPNNMOS = 0
        _pCZNFCC = 0
        _EmbarqueEstado = ""
        _pCCMPN = ""
        _pCDVSN = ""
        _pCMEDTR = 0
        _pNOREMB = ""
        _pCCLNT_PORTAL = 0
        _pNCPLNDV = 0
    End Sub

    Public Property DatosEmbarque() As beDatosEmbarque
        Get
            Return obeDatosEmbarque
        End Get
        Set(ByVal value As beDatosEmbarque)
            obeDatosEmbarque = value
        End Set
    End Property


    Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Property pCZNFCC() As Decimal
        Get
            Return _pCZNFCC
        End Get
        Set(ByVal value As Decimal)
            _pCZNFCC = value
        End Set
    End Property

    Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property

    Property pPNNMOS() As Decimal
        Get
            Return _pPNNMOS
        End Get
        Set(ByVal value As Decimal)
            _pPNNMOS = value
        End Set
    End Property


    Public Property EmbarqueEstado() As String
        Get
            Return _EmbarqueEstado
        End Get
        Set(ByVal value As String)
            _EmbarqueEstado = value
        End Set
    End Property

    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    Public Property pNCPLNDV() As Decimal
        Get
            Return _pNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _pNCPLNDV = value
        End Set
    End Property

    Property pCMEDTR() As Decimal
        Get
            Return _pCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _pCMEDTR = value
        End Set
    End Property

    Public Property pNOREMB() As String
        Get
            Return _pNOREMB
        End Get
        Set(ByVal value As String)
            _pNOREMB = value
        End Set
    End Property

    Property pCCLNT_PORTAL() As Decimal
        Get
            Return _pCCLNT_PORTAL
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT_PORTAL = value
        End Set
    End Property

    '


    Public Function Lista_Embarque(ByVal CCLNT) As DataTable
        Return oEmbarque.Lista_Embarque(CCLNT)
    End Function

    Public Function Lista_Embarque_Aduana(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataTable
        Return oEmbarque.Lista_Embarque_Aduana(oFiltroEmbarque)
    End Function


    Public Function Lista_Detalle_OC_Embarque(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Return oEmbarque.Lista_Detalle_OC_Embarque(CCLNT, NORSCI)
    End Function

    Public Function Lista_Detalle_OC_Embarque_Ajuste(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Dim odtOC As New DataTable
        Dim odtCostos As New DataTable
        Dim NORCML As String = ""
        Dim NRITOC As Decimal = 0
        Dim NRPEMB As Decimal = 0
        Dim CODVAR As String = ""
        Dim SB_EXPRESION As New StringBuilder
        Dim MONTO_DOLAR As Decimal = 0
        Dim oColumnasCostos As New Hashtable
        ' Nombre Columna | Codigo Costo
        oColumnasCostos.Add("TOTFOB", "FOB")
        oColumnasCostos.Add("TOTFLT", "FLETE")
        oColumnasCostos.Add("TOTSEG", "SEGURO")
        oColumnasCostos.Add("TOTCIF", "CIF")
        oColumnasCostos.Add("TOTADV", "ADVALO")
        oColumnasCostos.Add("TOTIGV", "IGV")
        oColumnasCostos.Add("TOTIPM", "IPM")
        'oColumnasCostos.Add("TOTOGS", "OTSGAS")
        oColumnasCostos.Add("TASDES", "TASDES")
        oColumnasCostos.Add("TOLDER", "CALCULO_TOLDER") 'CALCULO IGV + IPM +ADVALO + OTSGAS
        oColumnasCostos.Add("ITTCAG", "ITTCAG")
        oColumnasCostos.Add("ITTGOA", "ITTGOA")
        oColumnasCostos.Add("ITTRAC", "ITTRAC")
        oColumnasCostos.Add("HANDLI", "HANDLI")
        oColumnasCostos.Add("DESALM", "DESALM")
        oColumnasCostos.Add("ITTAAG", "ITTAAG")
        oColumnasCostos.Add("ITTEXW", "ITTEXW")
        oColumnasCostos.Add("GFOB", "GFOB")
        oColumnasCostos.Add("ITTGAM", "ITTGAM")
        oColumnasCostos.Add("ITTTRM", "ITTTRM")
        oColumnasCostos.Add("ITTCEM", "ITTCEM")
        oColumnasCostos.Add("ITTCRS", "ITTCRS")
        oColumnasCostos.Add("ALMLOC", "ALMLOC")
        oColumnasCostos.Add("CARDES", "CARDES")
        oColumnasCostos.Add("ITTTRA", "ITTTRA")
        oColumnasCostos.Add("CARDEC", "CARDEC")
        oColumnasCostos.Add("INLAD", "INLAD")
        oColumnasCostos.Add("MONIMP", "GASADU")

        oColumnasCostos.Add("DERESP", "DERESP")
        oColumnasCostos.Add("SOBTAS", "SOBTAS")
        oColumnasCostos.Add("ANTDUM", "ANTDUM")
        oColumnasCostos.Add("IMSECO", "IMSECO")
        oColumnasCostos.Add("MORA", "MORA")
        oColumnasCostos.Add("INTCOM", "INTCOM")

        odtOC = oEmbarque.Lista_Detalle_OC_Embarque_Ajuste(CCLNT, NORSCI)
        odtCostos = oEmbarque.Lista_Costos_OC_X_Embarque(CCLNT, NORSCI)

        For Each item As DictionaryEntry In oColumnasCostos
            odtOC.Columns.Add(item.Key, GetType(System.Decimal))
        Next
        Dim dr() As DataRow
        Dim TOT_DERECHOS As Decimal = 0
        For FILA As Integer = 0 To odtOC.Rows.Count - 1
            NORCML = odtOC.Rows(FILA)("NORCML").ToString.Trim
            NRITOC = odtOC.Rows(FILA)("NRITEM")
            NRPEMB = odtOC.Rows(FILA)("NRPEMB")
            For Each item As DictionaryEntry In oColumnasCostos
                CODVAR = item.Value
                SB_EXPRESION.Length = 0
                MONTO_DOLAR = 0
                Select Case CODVAR
                    Case "CALCULO_TOLDER"

                        SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
                        SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
                        'SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR IN ('IGV','IPM','ADVALO','OTSGAS','DERESP','SOBTAS','ANTDUM','IMSECO','MORA','INTCOM')")
                        SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR IN ('IGV','IPM','ADVALO','TASDES','DERESP','SOBTAS','ANTDUM','IMSECO','MORA','INTCOM')")
                    Case Else
                        SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
                        SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
                        SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR='" & CODVAR & "'")
                End Select
                dr = odtCostos.Select(SB_EXPRESION.ToString)
                If dr.Length > 0 Then
                    For Each drItem As DataRow In dr
                        MONTO_DOLAR = MONTO_DOLAR + drItem("IVLDOL")
                    Next
                Else
                    MONTO_DOLAR = 0
                End If
                odtOC.Rows(FILA)(item.Key) = MONTO_DOLAR
            Next
        Next
        Return odtOC
    End Function

    ''' <summary>
    ''' PARA ENVIAR COSTOS A ABB EN SOLES
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Lista_Detalle_OC_Embarque_ABB(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Return oEmbarque.Lista_Detalle_OC_Embarque_ABB(CCLNT, NORSCI)
    End Function
    Public Function Lista_Detalle_OC_Embarque_ABB_Cambio_CheckPoint(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
        Return oEmbarque.Lista_Detalle_OC_Embarque_ABB_Cambio_CheckPoint(CCLNT, NORSCI)
    End Function

    Public Sub Datos_Embarque_VB(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal)
        obeDatosEmbarque = oEmbarque.Datos_Embarque_VB(CCLNT, NORSCI)
    End Sub

    Public Function Mantenimiento_Datos_Embarque_VB(ByVal obeDatosEmbarque As beDatosEmbarque) As Int32
        Return oEmbarque.Mantenimiento_Datos_Embarque_VB(obeDatosEmbarque)
    End Function

    Public Function Mantenimiento_Datos_Forol_Completo(ByVal obeDatosEmbarque As beDatosEmbarque) As Int32
        Return oEmbarque.Mantenimiento_Datos_Forol_Completo(obeDatosEmbarque)
    End Function



    Public Sub Actualiza_Agente_Carga(ByVal PNNORSCI As Decimal, ByVal PNCAGNCR As Decimal)
        oEmbarque.Actualiza_Agente_Carga(PNNORSCI, PNCAGNCR)
    End Sub


    Public Sub Actualiza_Regimen(ByVal PNNORSCI As Decimal, ByVal pdblRegimen As Double)
        oEmbarque.Actualiza_Regimen(PNNORSCI, pdblRegimen)
       
    End Sub

    Public Sub Actualiza_Despacho(ByVal PNNORSCI As Decimal, ByVal pdblDespacho As Double)

        oEmbarque.Actualiza_Despacho(PNNORSCI, pdblDespacho)
       
    End Sub

    Public Sub Actualiza_Canal(ByVal pdblEmbarque As Double, ByVal pdblOS As Double, ByVal pstrCanal As String)

        oEmbarque.Actualiza_Canal(pdblEmbarque, pdblOS, pstrCanal)
       
    End Sub

    Public Sub Actualiza_DUA(ByVal pdblEmbarque As Double, ByVal pdblOS As Double, ByVal pstrDUA As String)

        oEmbarque.Actualiza_DUA(pdblEmbarque, pdblOS, pstrDUA)
       
    End Sub

    Public Sub Actualiza_Status_Documentos(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 120
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
       
    End Sub

    Public Sub Actualiza_Status_Numeracion(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 121
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
       
    End Sub


    Public Sub Actualiza_Status_AforoPrevio(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)
        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 117
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
    End Sub


    Public Sub Actualiza_Status_Volante(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)
        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 116
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
    End Sub


    Public Sub Actualiza_Status_LLegada(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)
        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 108
        obeCheckPoint.PSCEMB = "P"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
    End Sub



    Public Sub Actualiza_Status_RetiroCarga(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 151
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)

    End Sub

    Public Sub Actualiza_Status_AforoFisico(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 150
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)

    End Sub


    Public Sub Actualiza_Status_Pago_Derechos(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 122
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
       
    End Sub


    Public Sub Actualiza_Status_Levante(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 123
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
      
    End Sub


    Public Sub Actualiza_Status_Entrega(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 124
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = PNFRETES
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
      
    End Sub


  

    Public Sub Actualiza_Status_Pago_Proforma(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 138
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
       
    End Sub


   

    Public Sub Actualiza_Status_Proforma(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNORSCI As Decimal, ByVal PNFRETES As Decimal)

        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint.PNNORSCI = PNNORSCI
        obeCheckPoint.PNNESTDO = 137
        obeCheckPoint.PSCEMB = "A"
        obeCheckPoint.PNFRETES = PNFRETES
        obeCheckPoint.PNFESEST = -1
        obeCheckPoint.PSTOBS = ""
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
       
    End Sub

    Public Sub Actualiza_Observaciones(ByVal obeObservacion As beObservacionCarga)
        oEmbarque.Actualiza_Observaciones(obeObservacion)
    End Sub


    Public Sub Actualiza_Carga(ByVal obeCargaEmbarque As beDetalleCargaInternacional)
        oEmbarque.Actualiza_Carga(obeCargaEmbarque)
    End Sub

    Public Sub Actualiza_Proforma(ByVal pdblEmbarque As Double, ByVal pstrProforma As String)
        oEmbarque.Actualiza_Proforma(pdblEmbarque, pstrProforma)

    End Sub

    Public Sub Actualiza_Tipo_Transporte(ByVal pdblEmbarque As Double, ByVal pstrTipo As String)
        oEmbarque.Actualiza_Tipo_Transporte(pdblEmbarque, pstrTipo)

    End Sub

    Public Sub Actualiza_Doc_Pendiente(ByVal pdblEmbarque As Double, ByVal pstrPendiente As String)
        oEmbarque.Actualiza_Doc_Pendiente(pdblEmbarque, pstrPendiente)
       
    End Sub

    Public Sub Eliminar_Observaciones_X_Item(ByVal PNNORSCI As Decimal, ByVal PNNRITEM As Decimal)
        oEmbarque.Eliminar_Observaciones_X_Item(PNNORSCI, PNNRITEM)
    End Sub
   
    Public Sub Elimina_Carga_Tipo(ByVal obeCargaEmbarque As beDetalleCargaInternacional)
        oEmbarque.Elimina_Carga_Tipo(obeCargaEmbarque)
    End Sub

    Public Function Liquidacion_Embarque(ByVal pdblOS As Double, ByVal pdblZona As Double) As DataTable
        Return oEmbarque.Liquidacion_Embarque(pdblOS, pdblZona)
    End Function

   
   
    Public Function Lista_Seguimiento_Aduanero_Resumido(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataTable
        Return oEmbarque.Lista_Seguimiento_Aduanero_Resumido(oFiltroEmbarque)
    End Function

    'Public Sub Actualiza_Liquidacion(ByVal pdblAdvalorem As Double, ByVal pdblIGV As Double, ByVal pdblIPM As Double, ByVal pdblOGastos As Double, ByVal pdblComAge As Double, ByVal pdblEXW As Double, ByVal pdblGFOB As Double, ByVal pdblFOB As Double, ByVal pdblSeguro As Double, ByVal pdblFlete As Double, ByVal pdblCIF As Double, ByVal pdblCEmb As Double, ByVal pdblCRns As Double, ByVal pdblTra As Double, ByVal pdblOper As Double, ByVal pdblAgen As Double, ByVal pdblTerm As Double)
    '    oEmbarque.Actualiza_Liquidacion(Me.pNORSCI, pdblAdvalorem, pdblIGV, pdblIPM, pdblOGastos, pdblComAge, pdblEXW, pdblGFOB, pdblFOB, pdblSeguro, pdblFlete, pdblCIF, pdblCEmb, pdblCRns, pdblTra, pdblOper, pdblAgen, pdblTerm)
    'End Sub

    Public Function Lista_Documento_Cliente(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal pstrEst As String) As DataTable
        Return oEmbarque.Lista_Documento_Cliente(PSCCMPN, CCLNT, pstrEst)
    End Function

    Public Function Lista_Datos_X_Cliente(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal pstrEst As String) As DataTable
        Return oEmbarque.Lista_Datos_X_Cliente(PSCCMPN, CCLNT, pstrEst)
    End Function

    Public Function Busca_Embarque_OS(ByVal pdblOS As Double, ByVal pdblZona As Double) As DataTable
        Return oEmbarque.Busca_Embarque_OS(pdblOS, pdblZona)
    End Function

    Public Function Lista_Status_X_Cliente(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal pstrEst As String) As DataTable
        Return oEmbarque.Lista_Status_X_Cliente(PSCCMPN, CCLNT, pstrEst)
    End Function

    Public Function Lista_Status_CI_X_Embarque(ByVal obeParamCheckPoint As beCheckPoint) As DataTable
        Return oEmbarque.Lista_Status_CI_X_Embarque(obeParamCheckPoint)
    End Function

    Public Function Lista_Unidades_X_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Return oEmbarque.Lista_Unidades_X_Embarque(pdblEmbarque)
    End Function

    Public Function Lista_Observacion_Embarque(ByVal PNNORSCI As Decimal) As List(Of beObservacionCarga)
        Return oEmbarque.Lista_Observacion_Embarque(PNNORSCI)
    End Function

    Public Function Lista_Carga_Embarque(ByVal PNNORSCI As Decimal) As List(Of beDetalleCargaInternacional)
        Dim oLisCarga As New List(Of beDetalleCargaInternacional)
        oLisCarga = oEmbarque.Lista_Carga_Embarque(PNNORSCI)
        Return oLisCarga
    End Function

    Public Function Lista_Observacion_X_Cliente(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal pstrEst As String) As DataTable
        Return oEmbarque.Lista_Observacion_X_Cliente(PSCCMPN, CCLNT, pstrEst)
    End Function

    Public Function Lista_Observacion_CI_X_Embarque(ByVal CCLNT As Decimal, ByVal pdblEmbarque As Double) As DataTable
        Return oEmbarque.Lista_Observacion_CI_X_Embarque(CCLNT, pdblEmbarque)
    End Function

    'Public Sub Embarcar_OC(ByRef oSqlMan As SqlManager, ByVal pdblEmbarque As Double, ByVal pstrOC As String, ByVal pdblParcial As Double)
    '    oEmbarque.Embarcar_OC(oSqlMan, Me.pCCLNT, pdblEmbarque, pstrOC, pdblParcial)
    'End Sub

    Public Sub Cerrar_Embarque(ByVal NORSCI As Decimal)
        oEmbarque.Cerrar_Embarque(NORSCI)
    End Sub



   
    Public Sub Mantenimiento_ETD_Embarque(ByVal pdblEmbarque As Double, ByVal pdblETD As Double)
        oEmbarque.Mantenimiento_ETD_Embarque(pdblEmbarque, pdblETD)
    End Sub

    Public Sub Mantenimiento_ETA_Embarque(ByVal pdblEmbarque As Double, ByVal pdblETA As Double)
        oEmbarque.Mantenimiento_ETA_Embarque(pdblEmbarque, pdblETA)
    End Sub


    Public Function Importar_Partidas_Arancelarias(ByVal pdblOS As Double, ByVal pdblZona As Double) As DataTable
        Return oEmbarque.Importar_Partidas_Arancelarias(pdblOS, pdblZona)
    End Function

    Public Function Importar_Partidas_Mercaderia(ByVal pstrMercaderia As String) As DataTable
        Return oEmbarque.Importar_Partidas_Mercaderia(Me.pCCLNT, pstrMercaderia)
    End Function

    Public Sub Actualiza_Embarque_Datos(ByVal PNCCLNT As Double, ByVal PNNRPEMB As Double, ByVal PNNORSCI As Double, ByVal PNQTPCM2 As Decimal, ByVal PSNFCTCM As String, ByVal PNNMITFC As Decimal, ByVal PNNSEQIN As Decimal)
        oEmbarque.Actualiza_Embarque_Datos(PNCCLNT, PNNRPEMB, PNNORSCI, PNQTPCM2, PSNFCTCM, PNNMITFC, PNNSEQIN)
    End Sub



    Public Sub Mantenimiento_Checkpoint(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal obeCheckPoint As beCheckPoint)
        oEmbarque.Actualiza_Status_Embarque(PSCCMPN, PSCDVSN, obeCheckPoint)
    End Sub


    Public Sub Actualiza_Checkpoint_Embarque_General(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal obeCheckPoint As beCheckPoint)
        oEmbarque.Actualiza_Checkpoint_Embarque_General(PSCCMPN, PSCDVSN, obeCheckPoint)
    End Sub


    'Public Sub Actualiza_Documentacion(ByVal pdblEmbarque As Double, ByVal pstrgDocumento As String)
    '    oEmbarque.Actualiza_Documentacion(pdblEmbarque, pstrgDocumento)
    'End Sub


    Public Function Importar_Datos_Agencias(ByVal strlOS As String, ByVal strZona As String) As DataTable
        Return oEmbarque.Importar_Datos_Agencias(strlOS, strZona)
    End Function

    Public Function Lista_Documento_Costo_Seguimiento()
        Return oEmbarque.Lista_Documento_Costo_Seguimiento
    End Function

    Public Function Lista_Para_Crear_TabPages()
        Return oEmbarque.Lista_Variable("COSTO_TOTAL")
    End Function

    Public Function Lista_Campos_Embarque()
        Return oEmbarque.Lista_Variable("CSEGAD")
    End Function

    Public Function Lista_OC_X_Embarque_OS(ByVal dblCliente As Double, ByVal pdblEmbarque As Double) As DataTable
        Return oEmbarque.Lista_OC_X_Embarque_OS(dblCliente, pdblEmbarque)
    End Function

    Public Function Lista_Partidas_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Return oEmbarque.Lista_Partidas_Embarque(pdblEmbarque)
    End Function
    Public Function Lista_Maestro_Partidas_Arancelarias_Embarque() As DataTable
        Return oEmbarque.Lista_Maestro_Partidas_Arancelarias_Embarque()
    End Function


    Public Function Lista_Datos_Mensaje_Texto(ByVal pdblEmbarque As Double) As DataTable
        Return oEmbarque.Lista_Datos_Mensaje_Texto(pdblEmbarque)
    End Function

    Public Function Lista_Numero_X_Operador(ByVal pdblCliente As Double) As DataTable
        Return oEmbarque.Lista_Numero_X_Operador(pdblCliente)
    End Function

    Public Sub Importar_Partidas_ASCINSA(ByVal pdblCliente As Double, ByVal pdblOS As Double)
        Dim oDt As DataTable
        Dim intCont As Integer

        oMySql = New Datos.clsMySql
        oDt = oMySql.Listar_Partida_ASCINSA(pdblOS.ToString.Substring(0, 4), pdblOS.ToString.Substring(4, pdblOS.ToString.Length - 4))
        Dim NORCML As String = ""
        Dim NRITOC As Decimal = 0
        Dim NUME_FACTU As String = ""
        Dim NUME_SERIE As Decimal = 0
        Dim TRAT_PREFE As String = ""
        Dim CODI_ADUAN As String = ""
        Dim CODI_ITEM As Decimal = 0
        For intCont = 0 To oDt.Rows.Count - 1
            NORCML = Ransa.Utilitario.HelpClass.ToStringCvr(oDt.Rows(intCont).Item("ORD_COMPRA"))
            NRITOC = Ransa.Utilitario.HelpClass.ToDecimalCvr(oDt.Rows(intCont).Item("ITEM_OC"))
            NUME_FACTU = Ransa.Utilitario.HelpClass.ToStringCvr(oDt.Rows(intCont).Item("NUME_FACTU"))
            CODI_ADUAN = Ransa.Utilitario.HelpClass.ToStringCvr(oDt.Rows(intCont).Item("CODI_ADUAN"))
            NUME_SERIE = Ransa.Utilitario.HelpClass.ToDecimalCvr(oDt.Rows(intCont).Item("NUME_SERIE"))
            TRAT_PREFE = Ransa.Utilitario.HelpClass.ToStringCvr(oDt.Rows(intCont).Item("TRAT_PREFE"))
            CODI_ITEM = Ransa.Utilitario.HelpClass.ToDecimalCvr(oDt.Rows(intCont).Item("CODI_ITEM"))
            oEmbarque.Actualiza_Partidas_DUAA1(pdblCliente, NORCML, NRITOC, NUME_FACTU, CODI_ITEM, pdblOS, CODI_ADUAN, NUME_SERIE, TRAT_PREFE)
        Next intCont
       
    End Sub

    Public Function Importar_Costos_Agencias(ByVal pdblOS As Double, ByVal pdblZona As Double, ByVal pstrTipo As String, ByVal pintPlanta As Integer) As DataTable
        Dim oRepMonthly As New Datos.clsRepMonthly
        Return oRepMonthly.dtRepMonthlyFacturacionImportacionDatos(pdblOS, pdblZona, pstrTipo, pintPlanta)
    End Function

    Public Function dtRepMonthlyDetalleDebito_Costo_Operativo_ImportacionDatos(ByVal pdblOS As Double, ByVal pstrZona As String, ByVal pstrTipoImp As String, ByVal pdblPlanta As Double) As DataTable
        Dim odt As New DataTable
        Dim oRepMonthly As New Datos.clsRepMonthly
        odt = oRepMonthly.dtRepMonthlyDetalleDebito_Costo_Operativo_ImportacionDatos(pdblOS, pstrZona, pstrTipoImp, pdblPlanta)
        Return odt
    End Function


    Public Sub Cargar_Informacion_Inicial(ByVal NORSCI As Decimal)
        Dim oDt As DataTable
        oDt = oEmbarque.Lista_Informacion_Inicial_Embarque(NORSCI)
        Me.pPNNMOS = Double.Parse(oDt.Rows(0).Item("PNNMOS"))
        Me.pCZNFCC = oDt.Rows(0).Item("CZNFCC")
        Me.pCCLNT = oDt.Rows(0).Item("CCLNT")
        Me.pCCMPN = ("" & oDt.Rows(0).Item("CCMPN")).ToString.Trim
        Me.pCDVSN = ("" & oDt.Rows(0).Item("CDVSN")).ToString.Trim
        Me.pNCPLNDV = oDt.Rows(0).Item("CPLNDV")
        Me.pCMEDTR = oDt.Rows(0).Item("CMEDTR")
        Me.pNOREMB = ("" & oDt.Rows(0).Item("NOREMB")).ToString.Trim
        Me.pCCLNT_PORTAL = oDt.Rows(0).Item("CCLNT_PORTAL")
    End Sub

    Public Function CargarTarifaEmbarque(ByVal oParametros As Hashtable) As DataTable
        Return oEmbarque.CargarTarifaEmbarque(oParametros)
    End Function
    Public Function CargarTarifaEmbarque_x_tarifa(ByVal oParametros As Hashtable) As DataTable
        Return oEmbarque.CargarTarifaEmbarque_x_tarifa(oParametros)
    End Function
    Public Function CargarTarifaContrato(ByVal oParametros As Hashtable) As DataTable
        Return oEmbarque.CargarTarifaContrato(oParametros)
    End Function

  Public Function CargarClienteFacturacion(ByVal tarifa As Double, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CCLNT As Double, ByVal FECSRV As Double) As DataTable
    Return oEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
  End Function

   
    Enum EliminarItemPreEmbarque
        SI
        NO
    End Enum
    Public Sub Mantenimiento_Anular_Embarque(ByVal pdbNORSCI As Double, ByVal pEliminarItemPreEmbarque As EliminarItemPreEmbarque)
        Dim opcionEliminarItemPreEmb As String = ""
        Select Case pEliminarItemPreEmbarque
            Case EliminarItemPreEmbarque.SI
                opcionEliminarItemPreEmb = "S"
            Case EliminarItemPreEmbarque.NO
                opcionEliminarItemPreEmb = "N"
            Case Else
                opcionEliminarItemPreEmb = "N"
        End Select
        oEmbarque.Mantenimiento_Anular_Embarque(pdbNORSCI, opcionEliminarItemPreEmb)
    End Sub

    Public Function Importar_Oc_Embarcadas_Agencia_2(ByVal objeto As beDistribucionCostoxItemOC) As Integer
        Return oEmbarque.Importar_Oc_Embarcadas_Agencia_2(objeto)
    End Function

    Public Function Distribuir_Costos_Totales_x_Concepto(ByVal objeto As beDistribucionCostoxItemOC) As Integer
        Return oEmbarque.Distribuir_Costos_Totales_x_Concepto(objeto)
    End Function
   
    Public Function Lista_Almacen_Todos_Local() As DataTable
        Return oEmbarque.Lista_Almacen_Todos_Local()
    End Function

    Public Function ListarSeguimientoAduaneroVistaReducido(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataTable
        Dim odtSeguimientoReducido As New DataTable
        odtSeguimientoReducido = oEmbarque.Lista_Seguimiento_Carga_Internacional_Vista_Reducida(oFiltroEmbarque)
        Return odtSeguimientoReducido
    End Function

    Public Function VERIFICA_EXISTENCIA_OS_EN_AGENCIA(ByVal PNPNNMOS As Decimal, ByVal PNCZNFCC As Decimal) As beAgencia
        Return oEmbarque.VERIFICA_EXISTENCIA_OS_EN_AGENCIA(PNPNNMOS, PNCZNFCC)
    End Function

    Public Function Enviar_Operacion_Facturacion(ByVal pCCMPN As String, ByVal pCDVSN As String, ByVal pdblCli As Double, ByVal pdblFecSrv As Double, ByVal pdblTarifa As Double, ByVal pstrTipoTarifa As String, ByVal pstrUnidadMedida As String, ByVal pdblValor As Double, ByVal PNCCLNFC As Decimal, ByVal CPLNDV As Decimal, ByVal PNCCNTCS As String, ByVal CDIRSE As Decimal) As DataTable
        Return oEmbarque.Enviar_Operacion_Facturacion(pCCMPN, pCDVSN, Me.pNORSCI, pdblCli, pdblFecSrv, pdblTarifa, pstrTipoTarifa, pstrUnidadMedida, pdblValor, PNCCLNFC, CPLNDV, PNCCNTCS, CDIRSE)
    End Function

    Public Function dtRepMonthlyCostoAgencias(ByVal obeDetalleGastoXOS As beDetalleGastoXOS) As DataSet
        Dim odt As New DataTable
        Dim oRepMonthly As New Datos.clsRepMonthly
        Return oRepMonthly.dtRepMonthlyCostoAgencias(obeDetalleGastoXOS)
    End Function

    Public Function EnviaMensajeTexto(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As String
        Dim strMensaje As String = ""
        Dim TextoEnvia As String
        Dim intCont As Integer
        Dim oDt As DataTable
        Dim bolEnvio As Boolean = True
        Dim msg As String = ""
        Try
            oDt = oEmbarque.Lista_Numero_X_Operador(PNCCLNT)
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To oDt.Rows.Count - 1
                    If oDt.Rows(intCont).Item("TXTOPR").ToString.Trim = "N" Then
                        strMensaje = Dame_Mensaje(PNNORSCI)
                        TextoEnvia = "http://demosdata.nextel.com.pe/sms_demourl/web/mensajes/enviar2.asp?usuarios=" & oDt.Rows(intCont).Item("TLFNO1").ToString.Trim & ";&grupos=test&asunto=SOLMIN&mensaje=" & strMensaje
                        If strMensaje <> "" Then
                            Dim fr As System.Net.HttpWebRequest
                            Dim targetURI As New Uri(TextoEnvia)
                            fr = DirectCast(System.Net.HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
                            If (fr.GetResponse().ContentLength > 0) Then
                                Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                                Dim strCadena As String
                                strCadena = str.ReadToEnd()
                                str.Close()
                                If strCadena.Substring(145, 2) <> "OK" Then
                                    bolEnvio = False
                                End If
                            End If
                        End If
                    End If
                    If Not bolEnvio Then
                        msg = "No se pudo enviar el mensaje de Texto al número: " & oDt.Rows(intCont).Item("TLFNO1").ToString.Trim
                    End If
                    bolEnvio = True
                Next intCont
            End If
        Catch ex As System.Net.WebException
            msg = ex.Message
        End Try
        Return msg
    End Function

    Private Function Dame_Mensaje(ByVal pdblEmbarque As Double) As String
        Dim strCadena As String = ""
        Dim oDt As DataTable
        oDt = oEmbarque.Lista_Datos_Mensaje_Texto(pdblEmbarque)
        If oDt.Rows.Count > 0 Then
            With oDt.Rows(0)
                If Not IsDBNull(.Item("NORSCI")) Then
                    strCadena = "Embarque : " & .Item("NORSCI").ToString.Trim & " "
                End If
                If Not IsDBNull(.Item("PNNMOS")) Then
                    If .Item("PNNMOS").ToString.Trim <> "" Then
                        strCadena = strCadena & "O/S : " & .Item("PNNMOS").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("FECNUM")) Then
                    If .Item("FECNUM").ToString.Trim <> "" Then
                        strCadena = strCadena & "Fecha Numeracion : " & .Item("FECNUM").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("FECLEV")) Then
                    If .Item("FECLEV").ToString.Trim <> "" Then
                        strCadena = strCadena & "Fecha Levante : " & .Item("FECLEV").ToString.Trim & " "
                    End If
                End If
                If Not IsDBNull(.Item("TCANAL")) Then
                    If .Item("TCANAL").ToString.Trim <> "" Then
                        strCadena = strCadena & "Canal : " & .Item("TCANAL").ToString.Trim
                    End If
                End If
            End With
        End If
        Return strCadena
    End Function


    Public Function Datos_CheckPoint_Carga_Internacional_x_Embarque(ByVal PNCCLNT As Decimal, ByVal PSLISTANORSCIS As String) As DataTable
        Return oEmbarque.Datos_CheckPoint_Carga_Internacional_x_Embarque(PNCCLNT, PSLISTANORSCIS)
    End Function

    Public Function Datos_Ordenes_Compra_X_Embarques(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSLISTANORSCIS As String) As DataTable
        Return oEmbarque.Datos_Ordenes_Compra_X_Embarques(PSCCMPN, PNCCLNT, PSLISTANORSCIS)
    End Function

    Public Function Listar_Embarques_Actualizacion_Partida(ByVal PNFECHA As Decimal, ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataTable
        Return oEmbarque.Listar_Embarques_Actualizacion_Partida(PNFECHA, PNNORSCI, PNCCLNT)
    End Function
    Public Function Listar_Datos_Detalle_Dua(ByVal PNNORDSR As Decimal, ByVal PNCZNFCC As Decimal) As DataTable
        Return oEmbarque.Listar_Datos_Detalle_Dua(PNNORDSR, PNCZNFCC)
    End Function


    Public Function Listar_Log_X_Carga_Internacional(ByVal PNCCLNT As Decimal, ByVal PNNRPEMB As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Return oEmbarque.Listar_Log_X_Carga_Internacional(PNCCLNT, PNNRPEMB, PNNESTDO)
    End Function

    Public Function Listar_Log_X_Embarque_Aduana(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Return oEmbarque.Listar_Log_X_Embarque_Aduana(PNCCLNT, PNNORSCI, PNNESTDO)
    End Function
    Public Function Listar_Log_X_Carga_Internacional_Embarque_Aduana(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNESTDO As Decimal) As DataTable
        Return oEmbarque.Listar_Log_X_Carga_Internacional_Embarque_Aduana(PNCCLNT, PNNORSCI, PNNESTDO)
    End Function


  Public Function Listar_Regimen_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String) As DataTable
    Return oEmbarque.Listar_Regimen_X_Vencer(PSCCMPN, PNCCLNT, PNFECINI, PNFECVEN, PNPORVENCER, PSTPSRVA)
  End Function

  Public Function Listar_TipoCarga_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String) As DataTable
    Return oEmbarque.Listar_TipoCarga_X_Vencer(PSCCMPN, PNCCLNT, PNFECINI, PNFECVEN, PNPORVENCER, PSTPSRVA)
  End Function

    Public Function Listar_CartaFianza_X_Vencer(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PNFECINI As Decimal, ByVal PNFECVEN As Decimal, ByVal PNPORVENCER As Decimal, ByVal PSTPSRVA As String, ByVal PSESTADO As String) As DataTable
        Return oEmbarque.Listar_CartaFianza_X_Vencer(PSCCMPN, PNCCLNT, PNFECINI, PNFECVEN, PNPORVENCER, PSTPSRVA, PSESTADO)
    End Function

    Public Function Listar_Datos_Importacion_SIL(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As beDatosEmbarque
        Return oEmbarque.Listar_Datos_Importacion_SIL(PNCCLNT, PNNORSCI)
    End Function
    Public Function Listar_Datos_Validacion_Embarque(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As beDatosEmbarque
        Return oEmbarque.Listar_Datos_Validacion_Embarque(PNCCLNT, PNNORSCI)
    End Function

    Public Sub Eliminar_Item_Embarcado(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal)
        oEmbarque.Eliminar_Item_Embarcado(PNNORSCI, PNCCLNT, PSNORCML, PNNRITEM, PNNRPEMB)
    End Sub


    Public Function VerificarExistenciaOrdenServicio(ByVal PNPNNMOS As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Return oEmbarque.VerificarExistenciaOrdenServicio(PNPNNMOS, PNNORSCI)
    End Function

  

    Public Function Lista_Datos_Seguimiento_Extendido(ByVal oFiltroEmbarque As beSeguimientoCargaFiltro) As DataSet
        Return oEmbarque.Lista_Datos_Seguimiento_Extendido(oFiltroEmbarque)
    End Function

    Public Function ListarOrdenesRegularizacion(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Return oEmbarque.ListarOrdenesRegularizacion(PNCCLNT, PNNORSCI)
    End Function


    Public Function ListarMercaderiaSeguimiento(ByVal obeFiltro As beFiltroBusquedaItem) As DataTable

        Dim dtResult As New DataTable
        Dim dtChkCI As New DataTable
        Dim dtChkEmb As New DataTable
        Dim dtChk As New DataTable
        Dim dtCostos As New DataTable
        Dim dtLista_Costo As New DataTable


        'Dim ADVALO As Decimal ' ADVALOREM
        'Dim DERESP As Decimal ' DERECHO ESPECIFICO
        'Dim SOBTAS As Decimal ' SOBRETASA
        'Dim ANTDUM As Decimal ' ANTIDUMPING  
        'Dim IMSECO As Decimal ' ISC 
        'Dim IGV As Decimal    ' IGV
        'Dim IPM As Decimal    ' IPM
        'Dim MORA As Decimal   ' MORA
        'Dim INTCOM As Decimal ' INTERES COMPENSATORIO 
        'Dim TASDES As Decimal ' TASA DE DESPACHOS

        Dim oclsEmbarqueAduanas As New clsEmbarqueAduanas
        Dim ds As New DataSet

        ds = oEmbarque.ListarMercaderiaSeguimiento(obeFiltro)

        dtResult = ds.Tables(0).Copy 'LISTADO PRINCIPAL
        dtChkCI = ds.Tables(1).Copy 'CHECKPOINT CI
        dtChkEmb = ds.Tables(2).Copy ' CHECKPOINT EMBARQUE
        dtChk = ds.Tables(3).Copy 'CHECKPOINT X CLIENTE
        dtCostos = ds.Tables(4).Copy 'COSTOS
        dtLista_Costo = ds.Tables(5).Copy 'COSTOS

        Dim oCloneList As New CloneObject(Of beTipoDato)
        Dim oListAlmacenDestinoLocal As New List(Of beTipoDato)
        'oListAlmacenDestinoLocal = oCloneList.CloneListObject(oListGenAlmacenDestinoLocal)

        Dim ColChk As String = ""
        For Fila As Integer = 0 To dtChk.Rows.Count - 1
            ColChk = dtChk.Rows(Fila)("NESTDO") & "_" & ("" & dtChk.Rows(Fila)("CEMB")).ToString.Trim & "_CHK"
            dtResult.Columns.Add(ColChk)
            dtResult.Columns(ColChk).Caption = dtChk.Rows(Fila)("TCOLUM")
        Next

        For Fila As Integer = 0 To dtLista_Costo.Rows.Count - 1
            ColChk = ("" & dtLista_Costo.Rows(Fila)("VALVAR")).ToString.Trim & "_COSTO"
            dtResult.Columns.Add(ColChk)
            dtResult.Columns(ColChk).Caption = dtLista_Costo.Rows(Fila)("NOMVAR")
        Next

        Dim DatoChk() As String
        Dim TipoChk As String = ""
        Dim NRPEMB As Decimal = 0
        Dim NORSCI As Decimal = 0
        Dim NESTDO As Decimal = 0
        Dim TotReg As Int64 = dtResult.Rows.Count - 1

        Dim CHK_Fecha_Evaluar As Decimal = 0
        Dim IsRangoChk As Boolean = False
        Dim CHK_Fecha As String = 0
        Dim FECHA_VAL As Date


        dtResult.Columns.Add("CKCLPV")
        dtResult.Columns.Add("FECNUM")
        dtResult.Columns.Add("FECINSP")
        dtResult.Columns.Add("FECLEV")
        dtResult.Columns.Add("FECRCA")
        dtResult.Columns.Add("FECALM")



        '        CKCLPV()
        '121:    _A_CHK(FECNUM)
        '        FECINSP()
        '        FECLEV()
        '        FECRCA()
        '124:    _A_CHK()



        'dtResult.Columns.Add("FORSCI1", Type.GetType("System.String"))
        'dtResult.Columns.Add("FCEMSN1", Type.GetType("System.String"))
        'dtResult.Columns.Add("SEGURO", Type.GetType("System.String"))
        'dtResult.Columns.Add("ITTCAG", Type.GetType("System.String"))

        'dtResult.Columns.Add("CKCLPV", Type.GetType("System.String")) 'fecha entrega proveedor

        'dtResult.Columns.Add("IMPUESTOS_USD", Type.GetType("System.Decimal")) '
        'dtResult.Columns.Add("FECINSP", Type.GetType("System.String")) 'fecha de inspeccion
        'dtResult.Columns.Add("FECLEV", Type.GetType("System.String")) 'fecha de levante
        'dtResult.Columns.Add("FECRCA", Type.GetType("System.String")) 'fecha de retiro

        'dtResult.Columns.Add("ALMDES", Type.GetType("System.String")) 'almacen de entrega


        For Fila As Integer = 0 To TotReg
            If Fila <= TotReg Then
                IsRangoChk = True
                dtResult.Rows(Fila)("TPRVCL") = IIf(("" & dtResult.Rows(Fila)("NRUCPR")).ToString.Trim = "0", ("" & dtResult.Rows(Fila)("TPRVCL")).ToString.Trim, ("" & dtResult.Rows(Fila)("NRUCPR")).ToString.Trim & " - " & ("" & dtResult.Rows(Fila)("TPRVCL")).ToString.Trim)

                NRPEMB = dtResult.Rows(Fila)("NRPEMB")
                NORSCI = dtResult.Rows(Fila)("NORSCI")

                For Columna As Integer = 0 To dtResult.Columns.Count - 1

                    ColChk = dtResult.Columns(Columna).ColumnName
                  If ColChk.EndsWith("_CHK") Then
                        DatoChk = ColChk.Split("_")
                        TipoChk = DatoChk(1)

                        NESTDO = DatoChk(0)
                        CHK_Fecha = ""
                        Select Case TipoChk
                            Case "P"
                                CHK_Fecha = oclsEmbarqueAduanas.ObtieneChkCI(dtChkCI, NRPEMB, NESTDO)
                            Case "A"
                                CHK_Fecha = oclsEmbarqueAduanas.ObtieneChkEmb(dtChkEmb, NORSCI, NESTDO)
                        End Select
                        dtResult.Rows(Fila)(Columna) = CHK_Fecha

                        If obeFiltro.PNCHK <> 0 Then
                            If NESTDO = obeFiltro.PNCHK Then
                                If (Date.TryParse(CHK_Fecha, FECHA_VAL)) Then
                                    CHK_Fecha_Evaluar = FECHA_VAL.ToString("yyyyMMdd")
                                    If (CHK_Fecha_Evaluar >= obeFiltro.PNCHK_FECHA_INI AndAlso CHK_Fecha_Evaluar <= obeFiltro.PNCHK_FECHA_FIN) Then
                                        IsRangoChk = True
                                    Else
                                        IsRangoChk = False
                                    End If
                                Else
                                    IsRangoChk = False
                                End If
                            End If

                        End If
                    End If
                    If ColChk.EndsWith("_COSTO") Then
                        DatoChk = ColChk.Split("_")
                        TipoChk = DatoChk(0)
                        dtResult.Rows(Fila)(Columna) = oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(NORSCI, TipoChk, dtCostos)

                    End If


                


                    'If ColChk.EndsWith("_CHK") Then
                    '    DatoChk = ColChk.Split("_")
                    '    TipoChk = DatoChk(1)
                    '    NRPEMB = dtResult.Rows(Fila)("NRPEMB")
                    '    NORSCI = dtResult.Rows(Fila)("NORSCI")
                    '    NESTDO = DatoChk(0)
                    '    CHK_Fecha = ""
                    '    Select Case TipoChk
                    '        Case "P"
                    '            CHK_Fecha = ObtieneChkCI(dtChkCI, NRPEMB, NESTDO)
                    '        Case "A"
                    '            CHK_Fecha = ObtieneChkEmb(dtChkEmb, NORSCI, NESTDO)
                    '    End Select
                    '    dtResult.Rows(Fila)(Columna) = CHK_Fecha

                    '    If obeFiltro.PNCHK <> 0 Then
                    '        If NESTDO = obeFiltro.PNCHK Then
                    '            If (Date.TryParse(CHK_Fecha, FECHA_VAL)) Then
                    '                CHK_Fecha_Evaluar = FECHA_VAL.ToString("yyyyMMdd")
                    '                If (CHK_Fecha_Evaluar >= obeFiltro.PNCHK_FECHA_INI AndAlso CHK_Fecha_Evaluar <= obeFiltro.PNCHK_FECHA_FIN) Then
                    '                    IsRangoChk = True
                    '                Else
                    '                    IsRangoChk = False
                    '                End If
                    '            Else
                    '                IsRangoChk = False
                    '            End If
                    '        End If

                    '    End If

                    'End If


                Next

                ' LAS DEMAS

                dtResult.Rows(Fila)("FORSCI") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FORSCI"))
                dtResult.Rows(Fila)("FCEMSN") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FCEMSN"))
                dtResult.Rows(Fila)("FORCML") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FORCML"))
                dtResult.Rows(Fila)("FSOLIC") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FSOLIC"))
                dtResult.Rows(Fila)("FAPREV") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FAPREV"))
                dtResult.Rows(Fila)("FAPRAR") = HelpClass.FechaNum_a_Fecha(dtResult.Rows(Fila)("FAPRAR"))


                dtResult.Rows(Fila)("CKCLPV") = oclsEmbarqueAduanas.Fecha_EntregaProv(dtChkCI, NORSCI)
                dtResult.Rows(Fila)("FECNUM") = oclsEmbarqueAduanas.Fecha_Numeracion(dtChkEmb, NORSCI)
                dtResult.Rows(Fila)("FECINSP") = oclsEmbarqueAduanas.Fecha_Inspeccion(dtChkEmb, NORSCI)
                dtResult.Rows(Fila)("FECLEV") = oclsEmbarqueAduanas.Fecha_Levante(dtChkEmb, NORSCI)
                dtResult.Rows(Fila)("FECRCA") = oclsEmbarqueAduanas.Fecha_RetiroCarga(dtChkEmb, NORSCI)
                dtResult.Rows(Fila)("FECALM") = oclsEmbarqueAduanas.Fecha_Entrega_Alm_Cliente(dtChkEmb, NORSCI)


                If dtResult.Rows(Fila)("TCMPVP").ToString.Trim <> "" And dtResult.Rows(Fila)("TNMCIN").ToString.Trim <> "" Then
                    dtResult.Rows(Fila)("TCMPVP") = dtResult.Rows(Fila)("TCMPVP").ToString.Trim & " / " & dtResult.Rows(Fila)("TNMCIN").ToString.Trim
                End If
 

                If dtResult.Rows(Fila)("PAI_ORIGEN").ToString.Trim <> "" And dtResult.Rows(Fila)("PUE_ORIGEN").ToString.Trim <> "" Then
                    dtResult.Rows(Fila)("PAI_ORIGEN") = dtResult.Rows(Fila)("PAI_ORIGEN").ToString.Trim & " / " & dtResult.Rows(Fila)("PUE_ORIGEN").ToString.Trim
                End If
                If dtResult.Rows(Fila)("PAI_DESTINO").ToString.Trim <> "" And dtResult.Rows(Fila)("PUE_DESTINO").ToString.Trim <> "" Then
                    dtResult.Rows(Fila)("PAI_DESTINO") = dtResult.Rows(Fila)("PAI_DESTINO").ToString.Trim & " / " & dtResult.Rows(Fila)("PUE_DESTINO").ToString.Trim
                End If


                If dtResult.Rows(Fila)("TCMPVP").ToString.Trim <> "" And dtResult.Rows(Fila)("TNMCIN").ToString.Trim = "" Then
                    dtResult.Rows(Fila)("TCMPVP") = dtResult.Rows(Fila)("TCMPVP").ToString.Trim
                ElseIf dtResult.Rows(Fila)("TCMPVP").ToString.Trim = "" And dtResult.Rows(Fila)("TNMCIN").ToString.Trim <> "" Then
                    dtResult.Rows(Fila)("TCMPVP") = dtResult.Rows(Fila)("TNMCIN").ToString.Trim
                ElseIf dtResult.Rows(Fila)("TCMPVP").ToString.Trim = "" And dtResult.Rows(Fila)("TNMCIN").ToString.Trim <> "" Then
                    dtResult.Rows(Fila)("TCMPVP") = ""
                End If


                If (IsRangoChk = False) Then
                    dtResult.Rows.RemoveAt(Fila)
                    Fila = Fila - 1
                    TotReg = TotReg - 1
                End If
            End If
        Next

        'dtResult.Columns.Add("FORSCI1", Type.GetType("System.String"))
        'dtResult.Columns.Add("FCEMSN1", Type.GetType("System.String"))
        'dtResult.Columns.Add("SEGURO", Type.GetType("System.String"))
        'dtResult.Columns.Add("ITTCAG", Type.GetType("System.String"))

        'dtResult.Columns.Add("CKCLPV", Type.GetType("System.String")) 'fecha entrega proveedor

        'dtResult.Columns.Add("IMPUESTOS_USD", Type.GetType("System.Decimal")) '
        'dtResult.Columns.Add("FECINSP", Type.GetType("System.String")) 'fecha de inspeccion
        'dtResult.Columns.Add("FECLEV", Type.GetType("System.String")) 'fecha de levante
        'dtResult.Columns.Add("FECRCA", Type.GetType("System.String")) 'fecha de retiro

        'dtResult.Columns.Add("ALMDES", Type.GetType("System.String")) 'almacen de entrega

        'Dim ListaSeguro As New Hashtable

        'For Each dr As DataRow In dtResult.Rows

        'dr("FORSCI1") = HelpClass.FechaNum_a_Fecha(dr("FORSCI"))
        'dr("FCEMSN1") = HelpClass.FechaNum_a_Fecha(dr("FCEMSN"))

        'If dr("TCMPVP").ToString.Trim <> "" And dr("TNMCIN").ToString.Trim <> "" Then
        '    dr("TCMPVP") = dr("TCMPVP").ToString.Trim & " / " & dr("TNMCIN").ToString.Trim
        'End If

        'If dr("PAI_ORIGEN").ToString.Trim <> "" And dr("PUE_ORIGEN").ToString.Trim <> "" Then
        '    dr("PAI_ORIGEN") = dr("PAI_ORIGEN").ToString.Trim & " / " & dr("PUE_ORIGEN").ToString.Trim
        'End If
        'If dr("PAI_DESTINO").ToString.Trim <> "" And dr("PUE_DESTINO").ToString.Trim <> "" Then
        '    dr("PAI_DESTINO") = dr("PAI_DESTINO").ToString.Trim & " / " & dr("PUE_DESTINO").ToString.Trim
        'End If


        'If dr("TCMPVP").ToString.Trim <> "" And dr("TNMCIN").ToString.Trim = "" Then
        '    dr("TCMPVP") = dr("TCMPVP").ToString.Trim
        'ElseIf dr("TCMPVP").ToString.Trim = "" And dr("TNMCIN").ToString.Trim <> "" Then
        '    dr("TCMPVP") = dr("TNMCIN").ToString.Trim
        'ElseIf dr("TCMPVP").ToString.Trim = "" And dr("TNMCIN").ToString.Trim <> "" Then
        '    dr("TCMPVP") = ""
        'End If

        'dr("SEGURO") = oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(CDec(dr("NORSCI")), "SEGURO", dtCostos)
        'dr("ITTCAG") = oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(CDec(dr("NORSCI")), "ITTCAG", dtCostos)

        'If ListaSeguro.Contains(dr("NORSCI")) Then
        '    dr("SEGURO") = 0D
        '    dr("ITTCAG") = 0D
        'Else
        '    ListaSeguro.Add(dr("NORSCI"), dr("NORSCI"))
        'End If

        'dr("CKCLPV") = ObtieneChkCI(dtChkCI, CDec(dr("NRPEMB")), 102) 'oclsEmbarqueAduanas.Fecha_EntregaProv(dtChkCI, CDec(dr("NORSCI")))
        'dr("FECINSP") = oclsEmbarqueAduanas.Fecha_Inspeccion(dtChkEmb, CDec(dr("NORSCI"))) 'fecha de inspección
        'dr("FECLEV") = oclsEmbarqueAduanas.Fecha_Levante(dtChkEmb, CDec(dr("NORSCI"))) 'fecha de levante
        'dr("FECRCA") = oclsEmbarqueAduanas.Fecha_RetiroCarga(dtChkEmb, CDec(dr("NORSCI"))) 'fecha de retiro

        'dr("ALMDES") = oclsEmbarqueAduanas.AlmacenDestinoLocalDesc_X_Embarque(oListAlmacenDestinoLocal, dtResult, CDec(dr("NORSCI")), CDec(dr("CCLNT"))) 'almacen de entrega

        ' COSTOS

        'ADVALO = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "ADVALO", dtCostos)) ' ADVALOREM
        'DERESP = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "DERESP", dtCostos)) ' DERECHO ESPECIFICO
        'SOBTAS = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "SOBTAS", dtCostos)) ' SOBRETASA
        'ANTDUM = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "ANTDUM", dtCostos)) ' ANTIDUMPING  
        'IMSECO = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "IMSECO", dtCostos)) ' ISC 
        'IGV = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "IGV", dtCostos)) ' IGV
        'IPM = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "IPM", dtCostos)) ' IPM
        'MORA = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "MORA", dtCostos)) ' MORA
        'INTCOM = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "INTCOM", dtCostos)) ' INTERES COMPENSATORIO 
        'TASDES = Val(oclsEmbarqueAduanas.Buscar_Costo_Total_X_Embarque(dr("NORSCI"), "TASDES", dtCostos)) ' TASA DE DESPACHOS

        'dr("IMPUESTOS_USD") = ADVALO + DERESP + SOBTAS + ANTDUM + IMSECO + IGV + IPM + MORA + INTCOM + TASDES

        'Next

        'dtResult.Columns.Remove("FORSCI")
        'dtResult.Columns.Remove("FCEMSN")

        Return dtResult

    End Function

    'INI-ECM-ValidacionSectorCliente[RF001]-160516
    Public Function CambiarCeBePorSector(ByVal input As InCeBePorSector) As OuCeBePorSector
        Dim output As New OuCeBePorSector
        output = oEmbarque.CambiarCeBePorSector(input)
        output.ColorRegistro = Drawing.Color.White

        If output.CCNTCS = "" Then
            output.CCNTCS = 0
            output.ColorRegistro = Drawing.ColorTranslator.FromHtml("#FFCDD2")
        End If
        Return output
    End Function
    'FIN-ECM-ValidacionSectorCliente[RF001]-160516
    Public Function ListarLogTracking(pCCMPN As String, ByVal pNORSCI As Decimal) As DataTable
        Dim oEmbarque As New Datos.clsEmbarque
        Return oEmbarque.ListarLogTracking(pCCMPN, pNORSCI)



    End Function

End Class
