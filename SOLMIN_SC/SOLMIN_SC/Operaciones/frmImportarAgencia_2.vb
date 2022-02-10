Imports SOLMIN_SC.Negocio
'Imports System.IO
'Imports Microsoft.VisualBasic.Strings
Imports System.Text
Imports System.Windows.Forms
'Imports Microsoft.VisualBasic
'Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
'Imports System.Reflection
'Imports SOLMIN_SC.Utilitario.HelpClassUtility
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
'Imports UTILITY = SOLMIN_SC.Utilitario.HelpClassUtility
Imports System.Collections.Specialized

Public Class frmImportarAgencia_2
    Private oEmbarque As clsEmbarque
    Private oDtStatus As DataTable
    Private oDtStatusCI As New DataTable
    Private oDocApertura As clsDocApertura
    Private scolOCSIL As New StringCollection
    Private oDtAgenciaDetalle As New DataTable
    Private cargaDetalleSil As Boolean = False
    Dim PSNMRODC As String = ""
    Dim PNNMITOC As Decimal = 0
    Private PSVARCOSTO As String = ""
    Private oListbeCostoAgencia As New List(Of beCostoAgencia)


    Private oLitsRegimen As List(Of beRegimen)

    Private oLitsDespacho As List(Of beTipoDato)
    Private ogenDatosEmbarque_BE As New beDatosEmbarque

    Private pCCMPN As String = ""
    Private pCDVSN As String = ""
    Private pCMEDTR As Decimal = 0
    Dim IsCheckImportar As Boolean = False
    Dim IsGroup As Boolean = False

    Private oListItemAgenciaOrigen As New List(Of beDUAA1)
    Enum TipoOrigen
        ASCINSA = 0
        SIL = 1
    End Enum

    Enum TipoDetalle
        AGENCIA = 0
        SIL = 1
    End Enum

    Private _pTipoOrigen As TipoOrigen = TipoOrigen.SIL
    Public Property pTipoOrigen() As TipoOrigen
        Get
            Return _pTipoOrigen
        End Get
        Set(ByVal value As TipoOrigen)
            _pTipoOrigen = value
        End Set
    End Property

    Public Sub New(ByVal _pCCMPN As String, ByVal _pCDVSN As String, ByVal poEmbarque As clsEmbarque, ByVal poListDespacho As List(Of beTipoDato), ByVal poListRegimen As List(Of beRegimen), ByVal _pCMEDTR As Decimal)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oEmbarque = poEmbarque
        oLitsDespacho = poListDespacho
        oLitsRegimen = poListRegimen
        oDocApertura = New clsDocApertura
        pCCMPN = _pCCMPN
        pCDVSN = _pCDVSN
        pCMEDTR = _pCMEDTR
    End Sub


   
    Private Sub frmImportarAgencia_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'btnListarOriginal.Visible = False
            'btnAgruparOCItem.Visible = True

            Dim oclsEmbarque As New clsEmbarque
            ogenDatosEmbarque_BE = oclsEmbarque.Listar_Datos_Importacion_SIL(oEmbarque.pCCLNT, Me.oEmbarque.pNORSCI)

            scolOCSIL.Clear()
            dtgAgenciasDetalla.AutoGenerateColumns = False
            oDtStatus = oEmbarque.Lista_Status_X_Cliente(pCCMPN, oEmbarque.pCCLNT, "A")


            Dim obeParamCheckPoint As New beCheckPoint
            obeParamCheckPoint.PNNORSCI = oEmbarque.pNORSCI
            obeParamCheckPoint.PNCCLNT = oEmbarque.pCCLNT
            oDtStatusCI = oEmbarque.Lista_Status_CI_X_Embarque(obeParamCheckPoint) 'DEMORA



            LlenarDatosInicialesCabeceras_Agencia_SIL()
            Cargar_Tabla_Sil()
            Cargar_Tabla_Agencias()
            Cargar_Tabla_SIL_Detalle()
            Cargar_Tabla_Agencia_Detalle()
            dtgAgenciasDetalla.ClearSelection()
            dtgSILDetalle.ClearSelection()


            Dim cb As New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
            cb.Text = "Import.Costos Ítem"
            cb.Name = "chkCostoItem"
            AddHandler cb.CheckedChanged, AddressOf chkItem_CheckedChanged
            Dim host As New ToolStripControlHost(cb)
            host.Alignment = ToolStripItemAlignment.Right

            ToolStrip2.Items.Add(host)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#Region "Limpiar Grilla"
    Private Sub Limpiar_Grilla_Detalle_SIL()
        Me.dtgSILDetalle.Rows.Clear()
    End Sub
#End Region

#Region "Crear Tabla "

    Private Function ListatConceptos() As SortedList
        Dim oHas As New SortedList
        'oHas.Clear()
        'oHas.Add("C100", "Régimen Aduanero/RADUANA")
        'oHas.Add("C110", "Tipo de Despacho/TDESPACHO")
        'oHas.Add("C120", "Fecha de Levante/FLEVANTE")
        'oHas.Add("C130", "Canal/CANAL")
        'oHas.Add("C140", "Fecha de Pago/FPAGO")
        'oHas.Add("C150", "Fecha de Numeración de Dua/FNUMDUA")
        'oHas.Add("C160", "DUA/DUA")
        'oHas.Add("C170", "FOB/FOB")
        'oHas.Add("C180", "Flete/FLETE")
        'oHas.Add("C190", "Seguro/SEGURO")
        'oHas.Add("C200", "CIF/CIF")
        'oHas.Add("C210", "Advaloren/ADVALO")
        ''*******adicionados**********************
        'oHas.Add("C212", "Derecho Específico/DERESP")
        'oHas.Add("C214", "SobreTasa/SOBTAS")
        'oHas.Add("C216", "Antidumping/ANTDUM")
        'oHas.Add("C218", "ISC/IMSECO")
        ''*****************************************
        'oHas.Add("C220", "IGV/IGV")
        'oHas.Add("C230", "IPM/IPM")
        'oHas.Add("C240", "Tasa de Despacho/OTSGAS")
        ''*******adicionados***********************
        'oHas.Add("C242", "Interés Compensatorio/INTCOM")
        'oHas.Add("C244", "Mora/MORA")
        ''*****************************************
        'oHas.Add("C250", "Comisión Agenciamiento/ITTCAG")
        'oHas.Add("C260", "Gastos Operativos A.G./ITTGOA")
        'oHas.Add("C270", "Tracción/ITTRAC")
        ''NUEVOS CHECKPOINTS
        'oHas.Add("C280", "Fecha Llegada/FAPRAR")
        'oHas.Add("C290", "Volante/FCDCOR")
        'oHas.Add("C300", "Previo/CKPREV")
        'oHas.Add("C310", "Aforo Físico/FECAFI")
        'oHas.Add("C320", "Retiro de la Carga/FECRCA")
        'oHas.Add("C330", "Entrega de la carga en Almacén/FECALM")

        oHas.Clear()
        oHas.Add(oHas.Count, "Régimen Aduanero/RADUANA")
        oHas.Add(oHas.Count, "Tipo de Despacho/TDESPACHO")
        oHas.Add(oHas.Count, "Fecha de Levante/FLEVANTE")
        oHas.Add(oHas.Count, "Canal/CANAL")
        oHas.Add(oHas.Count, "Fecha de Pago/FPAGO")
        oHas.Add(oHas.Count, "Fecha de Numeración de Dua/FNUMDUA")
        oHas.Add(oHas.Count, "DUA/DUA")
        oHas.Add(oHas.Count, "FOB/FOB")
        oHas.Add(oHas.Count, "Flete/FLETE")
        oHas.Add(oHas.Count, "Seguro/SEGURO")
        oHas.Add(oHas.Count, "CIF/CIF")
        oHas.Add(oHas.Count, "Advaloren/ADVALO")
        '*******adicionados**********************
        oHas.Add(oHas.Count, "Derecho Específico/DERESP")
        oHas.Add(oHas.Count, "SobreTasa/SOBTAS")
        oHas.Add(oHas.Count, "Antidumping/ANTDUM")
        oHas.Add(oHas.Count, "ISC/IMSECO")
        '*****************************************
        oHas.Add(oHas.Count, "IGV/IGV")
        oHas.Add(oHas.Count, "IPM/IPM")
        'oHas.Add(oHas.Count, "Tasa de Despacho/OTSGAS")
        oHas.Add(oHas.Count, "Tasa de Despacho/TASDES")
        '*******adicionados***********************
        oHas.Add(oHas.Count, "Interés Compensatorio/INTCOM")
        oHas.Add(oHas.Count, "Mora/MORA")
        '*****************************************
        oHas.Add(oHas.Count, "Comisión Agenciamiento/ITTCAG")
        oHas.Add(oHas.Count, "Gastos Operativos A.G./ITTGOA")
        oHas.Add(oHas.Count, "Tracción/ITTRAC")
        'NUEVOS CHECKPOINTS
        oHas.Add(oHas.Count, "Fecha Llegada/FAPRAR")
        oHas.Add(oHas.Count, "Volante/FCDCOR")
        oHas.Add(oHas.Count, "Previo/CKPREV")
        oHas.Add(oHas.Count, "Aforo Físico/FECAFI")
        oHas.Add(oHas.Count, "Retiro de la Carga/FECRCA")
        oHas.Add(oHas.Count, "Entrega de la carga en Almacén/FECALM")

        Return oHas
    End Function

    Private oDtTablas As DataTable

    'Private Function ObtenerDescripcionGasto() As String
    '    Dim strOTROS_GASTOS As New StringBuilder
    '    'strOTROS_GASTOS.Append("Otros Gastos ->Sobretasa +  Derecho Específico + ISC + ")
    '    strOTROS_GASTOS.Append("Tasa de Despacho ->Sobretasa +  Derecho Específico + ISC + ")
    '    strOTROS_GASTOS.Append(Chr(13) & " Antidump + Interés Compensatorio + Mora + Reintegro Papel")
    '    Return strOTROS_GASTOS.ToString
    'End Function
    Public Sub LlenarDatosInicialesCabeceras_Agencia_SIL()
        Dim strOTROS_GASTOS As String = ""
        Dim strConcepto() As String
        'strOTROS_GASTOS = ObtenerDescripcionGasto()

        Dim oHas As New SortedList
        oHas = ListatConceptos()
        Dim oDrVw As DataGridViewRow
        Dim Fila As Int32 = 0
        For Each item As DictionaryEntry In oHas
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgSIL)
            dtgSIL.Rows.Add(oDrVw)
            Fila = dtgSIL.Rows.Count - 1
            strConcepto = item.Value.ToString.Split("/")
            dtgSIL.Rows(Fila).Cells("DEF").Value = strConcepto(0)
            dtgSIL.Rows(Fila).Cells("VAL").Value = ""
            dtgSIL.Rows(Fila).Cells("VAL_IMPORT").Value = ""
            dtgSIL.Rows(Fila).Cells("VARIABLE").Value = strConcepto(1)


            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgAgencias)
            dtgAgencias.Rows.Add(oDrVw)
            Fila = dtgAgencias.Rows.Count - 1
            dtgAgencias.Rows(Fila).Cells("DEF_AGENCIA").Value = strConcepto(0)
            dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = ""
            dtgAgencias.Rows(Fila).Cells("VARIABLE_AGENCIA").Value = strConcepto(1)

            'Select Case strConcepto(1)
            '    Case "RADUANA"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "IMPORTACION PARA EL CONSUMO"
            '    Case "TDESPACHO"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "NORMAL"
            '    Case "FLEVANTE"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "12/03/2013"
            '    Case "CANAL"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "ROJO"
            '    Case "FPAGO"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "11/03/2013"
            '    Case "FNUMDUA"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "13/03/2013"
            '    Case "DUA"
            '        dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = "118201310000001"
            'End Select

            'If (item.Key = "C240") Then
            '    dtgSIL.Rows(Fila).Cells("DEF").ToolTipText = strOTROS_GASTOS.ToString()
            'End If
        Next

        'For Each item As DictionaryEntry In oHas
        '    oDrVw = New DataGridViewRow
        '    oDrVw.CreateCells(Me.dtgAgencias)
        '    dtgAgencias.Rows.Add(oDrVw)
        '    strConcepto = item.Value.ToString.Split("/")
        '    Fila = dtgAgencias.Rows.Count - 1
        '    dtgAgencias.Rows(Fila).Cells("DEF_AGENCIA").Value = strConcepto(0)
        '    dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = ""
        '    dtgAgencias.Rows(Fila).Cells("VARIABLE_AGENCIA").Value = strConcepto(1)
        '    'If (item.Key = "C240") Then
        '    '    dtgAgencias.Rows(Fila).Cells("DEF_AGENCIA").ToolTipText = strOTROS_GASTOS.ToString()
        '    'End If
        'Next
    End Sub

#End Region

#Region "Cargar Tabla"

    'Private Sub Cargar_Tabla_Sil()
    '    Dim oFnEmbarqueAduana As New clsEmbarqueAduanas
    '    Dim oclsEmbarque As New clsEmbarque
    '    dtgSIL.Rows(0).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTDSCRG_REG 'REGIMEN
    '    dtgSIL.Rows(1).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTDSCRG_DESPACHO
    '    dtgSIL.Rows(2).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Levante(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(3).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTCANAL
    '    dtgSIL.Rows(4).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Pago_Derechos(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(5).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Numeracion(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(6).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTNRODU
    '    ' LLENADO FECHAS CHECK POINT
    '    dtgSIL.Rows(18).Cells("VAL").Value = oFnEmbarqueAduana.BuscarFechaLlegada(oDtStatusCI, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(19).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Volante(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(20).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Previo(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(21).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_AforoFisico(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(22).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_RetiroCarga(oDtStatus, Me.oEmbarque.pNORSCI)
    '    dtgSIL.Rows(23).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Entrega_Alm_Cliente(oDtStatus, Me.oEmbarque.pNORSCI)
    '    Llenar_Liquidacion()
    'End Sub

    Private Sub Cargar_Tabla_Sil()
        Dim oDt As DataTable
        oDt = oDocApertura.Lista_Costos_Totales_Embarque(Me.oEmbarque.pNORSCI).Tables("dtCosto")

        Dim oFnEmbarqueAduana As New clsEmbarqueAduanas
        Dim oclsEmbarque As New clsEmbarque
        dtgSIL.Rows(FilaConceptoSIL("RADUANA")).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTDSCRG_REG 'REGIMEN
        dtgSIL.Rows(FilaConceptoSIL("TDESPACHO")).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTDSCRG_DESPACHO
        dtgSIL.Rows(FilaConceptoSIL("FLEVANTE")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Levante(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("CANAL")).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTCANAL
        dtgSIL.Rows(FilaConceptoSIL("FPAGO")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Pago_Derechos(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("FNUMDUA")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Numeracion(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("DUA")).Cells("VAL").Value = ogenDatosEmbarque_BE.PSTNRODU
        ' LLENADO FECHAS CHECK POINT
        dtgSIL.Rows(FilaConceptoSIL("FAPRAR")).Cells("VAL").Value = oFnEmbarqueAduana.BuscarFechaLlegada(oDtStatusCI, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("FCDCOR")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Volante(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("CKPREV")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Previo(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("FECAFI")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_AforoFisico(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("FECRCA")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_RetiroCarga(oDtStatus, Me.oEmbarque.pNORSCI)
        dtgSIL.Rows(FilaConceptoSIL("FECALM")).Cells("VAL").Value = oFnEmbarqueAduana.Fecha_Entrega_Alm_Cliente(oDtStatus, Me.oEmbarque.pNORSCI)
        'Llenar_Liquidacion()

        dtgSIL.Rows(FilaConceptoSIL("FOB")).Cells("VAL").Value = CostoSIL(oDt, "FOB")
        dtgSIL.Rows(FilaConceptoSIL("FLETE")).Cells("VAL").Value = CostoSIL(oDt, "FLETE")
        dtgSIL.Rows(FilaConceptoSIL("SEGURO")).Cells("VAL").Value = CostoSIL(oDt, "SEGURO")
        dtgSIL.Rows(FilaConceptoSIL("CIF")).Cells("VAL").Value = CostoSIL(oDt, "CIF")
        dtgSIL.Rows(FilaConceptoSIL("ADVALO")).Cells("VAL").Value = CostoSIL(oDt, "ADVALO")
        dtgSIL.Rows(FilaConceptoSIL("DERESP")).Cells("VAL").Value = CostoSIL(oDt, "DERESP")
        dtgSIL.Rows(FilaConceptoSIL("SOBTAS")).Cells("VAL").Value = CostoSIL(oDt, "SOBTAS")
        dtgSIL.Rows(FilaConceptoSIL("ANTDUM")).Cells("VAL").Value = CostoSIL(oDt, "ANTDUM")
        dtgSIL.Rows(FilaConceptoSIL("IMSECO")).Cells("VAL").Value = CostoSIL(oDt, "IMSECO")
        dtgSIL.Rows(FilaConceptoSIL("IGV")).Cells("VAL").Value = CostoSIL(oDt, "IGV")
        dtgSIL.Rows(FilaConceptoSIL("IPM")).Cells("VAL").Value = CostoSIL(oDt, "IPM")
        'dtgSIL.Rows(FilaConceptoSIL("OTSGAS")).Cells("VAL").Value = CostoSIL(oDt, "OTSGAS")
        dtgSIL.Rows(FilaConceptoSIL("TASDES")).Cells("VAL").Value = CostoSIL(oDt, "TASDES")
        dtgSIL.Rows(FilaConceptoSIL("INTCOM")).Cells("VAL").Value = CostoSIL(oDt, "INTCOM")
        dtgSIL.Rows(FilaConceptoSIL("MORA")).Cells("VAL").Value = CostoSIL(oDt, "MORA")
        dtgSIL.Rows(FilaConceptoSIL("ITTCAG")).Cells("VAL").Value = CostoSIL(oDt, "ITTCAG")
        dtgSIL.Rows(FilaConceptoSIL("ITTGOA")).Cells("VAL").Value = CostoSIL(oDt, "ITTGOA")
        dtgSIL.Rows(FilaConceptoSIL("ITTRAC")).Cells("VAL").Value = CostoSIL(oDt, "ITTRAC")

    End Sub


    Private Function CostoSIL(ByVal dtCosto As DataTable, ByVal Codvar As String) As String
        Dim Costo As String = ""
        Dim dr() As DataRow
        dr = dtCosto.Select("CODVAR='" & Codvar & "'")
        If dr.Length > 0 Then
            Costo = dr(0)("IVLDOL")
        End If
        Return Costo
    End Function

    'Private Sub Llenar_Liquidacion()
    '    Dim oDt As DataTable
    '    Dim intCont As Integer
    '    oDt = oDocApertura.Lista_Costos_Totales_Embarque(Me.oEmbarque.pNORSCI).Tables("dtCosto")
    '    For intCont = 0 To oDt.Rows.Count - 1
    '        Select Case oDt.Rows(intCont).Item(0).ToString
    '            Case "FOB"
    '                Me.dtgSIL.Rows(7).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "FLETE"
    '                Me.dtgSIL.Rows(8).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "SEGURO"
    '                Me.dtgSIL.Rows(9).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "CIF"
    '                Me.dtgSIL.Rows(10).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "ADVALO"
    '                Me.dtgSIL.Rows(11).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '                'adicionados******************************
    '            Case "DERESP"
    '                Me.dtgSIL.Rows(12).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '                'Case "DERESP"
    '                '    Me.dtgSIL.Rows(13).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '            Case "SOBTAS"
    '                Me.dtgSIL.Rows(14).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '            Case "ANTDUM"
    '                Me.dtgSIL.Rows(15).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '            Case "IMSECO"
    '                Me.dtgSIL.Rows(16).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '                '*******************

    '            Case "IGV"
    '                Me.dtgSIL.Rows(17).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "IPM"
    '                Me.dtgSIL.Rows(18).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "OTSGAS"
    '                Me.dtgSIL.Rows(19).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")

    '                'adicionados******************************

    '            Case "INTCOM"
    '                Me.dtgSIL.Rows(20).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "MORA"
    '                Me.dtgSIL.Rows(21).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '                '****************************************

    '            Case "ITTCAG"
    '                Me.dtgSIL.Rows(22).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "ITTGOA"
    '                Me.dtgSIL.Rows(23).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '            Case "ITTRAC"
    '                Me.dtgSIL.Rows(24).Cells("VAL").Value = oDt.Rows(intCont).Item("IVLORG")
    '        End Select
    '    Next

    'End Sub

    Private Sub Cargar_Tabla_Agencia_Detalle()
        Dim blClsImportarCostos As New clsImporCostos
        Dim obeDUAA As New beDUAA
        obeDUAA.PNNORDSR = ogenDatosEmbarque_BE.PNPNNMOS
        obeDUAA.PNCZNFCC = ogenDatosEmbarque_BE.PNCZNFCC
        oListItemAgenciaOrigen.Clear()
        oListItemAgenciaOrigen = blClsImportarCostos.ListarDetalleDUAA(obeDUAA)

        Dim oListbeDUAATemp As New List(Of beDUAA1)
        Dim oCloneList As New CloneObject(Of beDUAA1)
        oListbeDUAATemp = oCloneList.CloneListObject(oListItemAgenciaOrigen)
        dtgAgenciasDetalla.DataSource = Nothing
        dtgAgenciasDetalla.DataSource = oListbeDUAATemp
    End Sub


    'Private Sub Cargar_Tabla_Agencias()
    '    Dim oDtImportacion As New DataTable
    '    Dim oDtLiquidacion As New DataTable
    '    Dim NORDSR As Decimal = 0
    '    Dim oDtCostoTraccion As New DataTable
    '    oDtImportacion = oEmbarque.Importar_Datos_Agencias(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)

    '    Dim oclsImporCostos As New clsImporCostos

    '    With oDtImportacion
    '        If oDtImportacion.Rows.Count > 0 Then
    '            dtgAgencias.Rows(0).Cells("VAL_AGENCIA").Value = .Rows(0).Item("REGIMEN").ToString.Trim
    '            dtgAgencias.Rows(1).Cells("VAL_AGENCIA").Value = .Rows(0).Item("DESPACHO").ToString.Trim
    '            'dtgAgencias.Rows(2).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(.Rows(0).Item("FECLEV").ToString.Trim)
    '            dtgAgencias.Rows(3).Cells("VAL_AGENCIA").Value = .Rows(0).Item("CANAL").ToString.Trim
    '            dtgAgencias.Rows(4).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(.Rows(0).Item("FECPAGO").ToString.Trim)
    '            dtgAgencias.Rows(5).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(.Rows(0).Item("FECNUM").ToString.Trim)
    '            dtgAgencias.Rows(6).Cells("VAL_AGENCIA").Value = .Rows(0).Item("DUA").ToString.Trim
    '        End If
    '    End With
    '    oDtLiquidacion = oEmbarque.Liquidacion_Embarque(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)
    '    With oDtLiquidacion
    '        If oDtLiquidacion.Rows.Count > 0 Then
    '            dtgAgencias.Rows(7).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALFOB")
    '            dtgAgencias.Rows(8).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALFLT")
    '            dtgAgencias.Rows(9).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALSEG")
    '            dtgAgencias.Rows(10).Cells("VAL_AGENCIA").Value = .Rows(0).Item("IMPCIF")
    '            dtgAgencias.Rows(11).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALADV")


    '            '****************adicion**************
    '            dtgAgencias.Rows(12).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALDES")
    '            dtgAgencias.Rows(13).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALSBT")
    '            dtgAgencias.Rows(14).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALADP")
    '            dtgAgencias.Rows(15).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALISC")

    '            '*********************************


    '            dtgAgencias.Rows(16).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALIGV")
    '            dtgAgencias.Rows(17).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALIPM")

    '            '****************adicion**************
    '            dtgAgencias.Rows(18).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALICP")
    '            dtgAgencias.Rows(19).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALMOR")
    '            '*********************************

    '            'dtgAgencias.Rows(20).Cells("VAL_AGENCIA").Value = Otros_Gastos(oDtLiquidacion)
    '            dtgAgencias.Rows(20).Cells("VAL_AGENCIA").Value = .Rows(0).Item("VALRNP")
    '        End If
    '    End With

    '    Dim msgTitulo As String = Me.Text.Trim
    '    Dim OS_FACTURADO As Boolean = False
    '    If oDtLiquidacion.Rows.Count > 0 Then
    '        Dim obeCostoAgencia As beCostoAgencia
    '        Dim dsCostos As New DataSet
    '        Dim odtCostosOperativos As New DataTable
    '        Dim odtCostoComisionAgencia As New DataTable
    '        Dim obeGastoOS As New beDetalleGastoXOS

    '        obeGastoOS.PNNORDSR = oDtLiquidacion.Rows(0).Item("NORDSR")
    '        obeGastoOS.PNCPLNDV = oDtLiquidacion.Rows(0).Item("CPLNDV")
    '        obeGastoOS.PNCZNFCC = oDtLiquidacion.Rows(0).Item("CZNFCC")
    '        obeGastoOS.PSTPSRVA = oDtLiquidacion.Rows(0).Item("TPSRVA").ToString.Trim
    '        dsCostos = oEmbarque.dtRepMonthlyCostoAgencias(obeGastoOS)
    '        odtCostosOperativos = dsCostos.Tables("odtCostosOperativos").Copy
    '        odtCostoComisionAgencia = dsCostos.Tables("odtComision").Copy
    '        oDtCostoTraccion = odtCostosOperativos.Copy

    '        Dim obeCalImporteBaseOfTotal As beCalculoImporte
    '        Dim ofnEmbarqueAduanas As New clsEmbarqueAduanas
    '        '****************GASTOS OPERATVOS*************************
    '        For Each ItemCosto As DataRow In odtCostosOperativos.Rows
    '            obeCostoAgencia = New beCostoAgencia
    '            obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
    '            obeCostoAgencia.PSVARCOSTO = "ITTGOA"
    '            obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
    '            obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
    '            obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
    '            obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
    '            obeCostoAgencia.PNIGV = ItemCosto("PIGVA")
    '            '******calculo importes**************
    '            obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_of_ImporteTotal(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"))
    '            obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
    '            obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
    '            obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
    '            obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL
    '            '***********************************************

    '            obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
    '            obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
    '            obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
    '            obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
    '            obeCostoAgencia.PBSELECCIONADO = True
    '            obeCostoAgencia.PBSELECCIONABLE = True
    '            oListbeCostoAgencia.Add(obeCostoAgencia)
    '        Next
    '        '************************************************************
    '        '****************TRACCION AGENCIAS***************************
    '        For Each ItemCosto As DataRow In oDtCostoTraccion.Rows
    '            obeCostoAgencia = New beCostoAgencia
    '            obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
    '            obeCostoAgencia.PSVARCOSTO = "ITTRAC"
    '            obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
    '            obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
    '            obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
    '            obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
    '            obeCostoAgencia.PNIGV = ItemCosto("PIGVA")

    '            '******calculo importes**************
    '            obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_of_ImporteTotal(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"))
    '            obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
    '            obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
    '            obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
    '            obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL
    '            '***********************************************


    '            obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
    '            obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
    '            obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
    '            obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
    '            obeCostoAgencia.PBSELECCIONADO = True
    '            obeCostoAgencia.PBSELECCIONABLE = True
    '            oListbeCostoAgencia.Add(obeCostoAgencia)
    '        Next
    '        '****************COMISION AGENCIAS*************************
    '        For Each ItemCosto As DataRow In odtCostoComisionAgencia.Rows
    '            obeCostoAgencia = New beCostoAgencia
    '            obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
    '            obeCostoAgencia.PSVARCOSTO = "ITTCAG"
    '            obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
    '            obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
    '            obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
    '            obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
    '            obeCostoAgencia.PNIGV = ItemCosto("PIGVA")
    '            '******calculo importes**************
    '            obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_of_ImporteTotal(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"))
    '            obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
    '            obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
    '            obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
    '            obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL
    '            '***********************************************

    '            obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
    '            obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
    '            obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
    '            obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
    '            obeCostoAgencia.PBSELECCIONADO = True
    '            obeCostoAgencia.PBSELECCIONABLE = True
    '            oListbeCostoAgencia.Add(obeCostoAgencia)
    '        Next
    '        '***********************************************************
    '        EvaluarItemDeSeleccion("ITTRAC")
    '        '*************COMISION AGENCIAS*****************************************
    '        dtgAgencias.Rows(15).Tag = "ITTCAG_DETALLE"
    '        dtgAgencias.Rows(15).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
    '        dtgAgencias.Rows(15).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTCAG")
    '        dtgAgencias.Rows(15).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle"
    '        If (odtCostoComisionAgencia.Rows.Count > 0) Then
    '            OS_FACTURADO = True
    '        End If
    '        '*************************************************************************
    '        '****************COSTOS OPERATIVOS********************************************
    '        dtgAgencias.Rows(16).Tag = "ITTGOA_DETALLE"
    '        dtgAgencias.Rows(16).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTGOA")
    '        dtgAgencias.Rows(16).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
    '        dtgAgencias.Rows(16).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle"
    '        '*******************************************************************************
    '    End If
    '    If (OS_FACTURADO = True) Then ' SI NO TIENE COMISION NO ESTA FACTURADO
    '        msgTitulo = msgTitulo & " | " & ogenDatosEmbarque_BE.PNPNNMOS & " :FACTURADO"
    '    Else
    '        msgTitulo = msgTitulo & " | " & ogenDatosEmbarque_BE.PNPNNMOS & " : NO FACTURADO"
    '    End If
    '    Me.Text = msgTitulo
    '    '---------------------------------------------------------
    '    'COSTOS TRACCION
    '    '-----------------------------------------------------
    '    dtgAgencias.Rows(17).Tag = "ITTRAC_DETALLE"
    '    dtgAgencias.Rows(17).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTRAC")
    '    dtgAgencias.Rows(17).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
    '    dtgAgencias.Rows(17).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle."
    '    '-----------------------------------------------------

    '    '
    '    Dim odtChkAgencia As New DataTable
    '    odtChkAgencia = oclsImporCostos.ListarCheckPointAgencia(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)
    '    If odtChkAgencia.Rows.Count > 0 Then

    '        dtgAgencias.Rows(2).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("LEVANTE"))
    '        dtgAgencias.Rows(2).Cells("VAL_AGENCIA").ToolTipText = "F. Levante"


    '        dtgAgencias.Rows(18).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("ARRIBO"))
    '        dtgAgencias.Rows(18).Cells("VAL_AGENCIA").ToolTipText = "Fecha Llegada"

    '        dtgAgencias.Rows(19).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("TARJA"))
    '        dtgAgencias.Rows(19).Cells("VAL_AGENCIA").ToolTipText = "F. Volante"

    '        dtgAgencias.Rows(20).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("PREVIO"))
    '        dtgAgencias.Rows(20).Cells("VAL_AGENCIA").ToolTipText = "F. Aforo Previo"

    '        dtgAgencias.Rows(21).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("AFORO_FISICO"))
    '        dtgAgencias.Rows(21).Cells("VAL_AGENCIA").ToolTipText = "F. Aforo Físico"

    '        dtgAgencias.Rows(22).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("RETIRO_CARGA"))
    '        dtgAgencias.Rows(22).Cells("VAL_AGENCIA").ToolTipText = "F. Retiro Carga"

    '        dtgAgencias.Rows(23).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("ENTREGA_CARGA"))
    '        dtgAgencias.Rows(23).Cells("VAL_AGENCIA").ToolTipText = "F. Entrega Carga Almacén"


    '    End If


    'End Sub

    Private Sub Cargar_Tabla_Agencias()
        Dim oDtImportacion As New DataTable
        Dim oDtLiquidacion As New DataTable
        Dim oclsImporCostos As New clsImporCostos
        Dim NORDSR As Decimal = 0
        Dim oDtCostoTraccion As New DataTable
        oDtImportacion = oEmbarque.Importar_Datos_Agencias(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)
        oDtLiquidacion = oEmbarque.Liquidacion_Embarque(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)
        'With oDtImportacion
        If oDtImportacion.Rows.Count > 0 Then
            dtgAgencias.Rows(FilaConceptoAg("RADUANA")).Cells("VAL_AGENCIA").Value = oDtImportacion.Rows(0).Item("REGIMEN").ToString.Trim
            dtgAgencias.Rows(FilaConceptoAg("TDESPACHO")).Cells("VAL_AGENCIA").Value = oDtImportacion.Rows(0).Item("DESPACHO").ToString.Trim
            'dtgAgencias.Rows(2).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(.Rows(0).Item("FECLEV").ToString.Trim)
            dtgAgencias.Rows(FilaConceptoAg("CANAL")).Cells("VAL_AGENCIA").Value = oDtImportacion.Rows(0).Item("CANAL").ToString.Trim
            dtgAgencias.Rows(FilaConceptoAg("FPAGO")).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(oDtImportacion.Rows(0).Item("FECPAGO").ToString.Trim)
            dtgAgencias.Rows(FilaConceptoAg("FNUMDUA")).Cells("VAL_AGENCIA").Value = CNumero_a_Fecha(oDtImportacion.Rows(0).Item("FECNUM").ToString.Trim)
            dtgAgencias.Rows(FilaConceptoAg("DUA")).Cells("VAL_AGENCIA").Value = oDtImportacion.Rows(0).Item("DUA").ToString.Trim
        End If
        'End With
        'With oDtLiquidacion
        If oDtLiquidacion.Rows.Count > 0 Then
            dtgAgencias.Rows(FilaConceptoAg("FOB")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALFOB")
            dtgAgencias.Rows(FilaConceptoAg("FLETE")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALFLT")
            dtgAgencias.Rows(FilaConceptoAg("SEGURO")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALSEG")
            dtgAgencias.Rows(FilaConceptoAg("CIF")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("IMPCIF")
            dtgAgencias.Rows(FilaConceptoAg("ADVALO")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALADV")


            '****************adicion**************
            dtgAgencias.Rows(FilaConceptoAg("DERESP")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALDES")
            dtgAgencias.Rows(FilaConceptoAg("SOBTAS")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALSBT")
            dtgAgencias.Rows(FilaConceptoAg("ANTDUM")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALADP")
            dtgAgencias.Rows(FilaConceptoAg("IMSECO")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALISC")

            '*********************************


            dtgAgencias.Rows(FilaConceptoAg("IGV")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALIGV")
            dtgAgencias.Rows(FilaConceptoAg("IPM")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALIPM")

            '****************adicion**************
            dtgAgencias.Rows(FilaConceptoAg("INTCOM")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALICP")
            dtgAgencias.Rows(FilaConceptoAg("MORA")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALMOR")
            '*********************************

            'dtgAgencias.Rows(20).Cells("VAL_AGENCIA").Value = Otros_Gastos(oDtLiquidacion)
            'dtgAgencias.Rows(FilaConceptoAg("OTSGAS")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALRNP")
            dtgAgencias.Rows(FilaConceptoAg("TASDES")).Cells("VAL_AGENCIA").Value = oDtLiquidacion.Rows(0).Item("VALRNP")
        End If
        'End With

        Dim msgTitulo As String = Me.Text.Trim
        Dim OS_FACTURADO As Boolean = False
        If oDtLiquidacion.Rows.Count > 0 Then
            Dim obeCostoAgencia As beCostoAgencia
            Dim dsCostos As New DataSet
            Dim odtCostosOperativos As New DataTable
            Dim odtCostoComisionAgencia As New DataTable
            Dim obeGastoOS As New beDetalleGastoXOS

            obeGastoOS.PNNORDSR = oDtLiquidacion.Rows(0).Item("NORDSR")
            obeGastoOS.PNCPLNDV = oDtLiquidacion.Rows(0).Item("CPLNDV")
            obeGastoOS.PNCZNFCC = oDtLiquidacion.Rows(0).Item("CZNFCC")
            obeGastoOS.PSTPSRVA = oDtLiquidacion.Rows(0).Item("TPSRVA").ToString.Trim
            dsCostos = oEmbarque.dtRepMonthlyCostoAgencias(obeGastoOS)
            odtCostosOperativos = dsCostos.Tables("odtCostosOperativos").Copy
            odtCostoComisionAgencia = dsCostos.Tables("odtComision").Copy
            oDtCostoTraccion = odtCostosOperativos.Copy

            Dim obeCalImporteBaseOfTotal As beCalculoImporte
            Dim ofnEmbarqueAduanas As New clsEmbarqueAduanas
            '****************GASTOS OPERATVOS*************************
            For Each ItemCosto As DataRow In odtCostosOperativos.Rows
                obeCostoAgencia = New beCostoAgencia
                obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
                obeCostoAgencia.PSVARCOSTO = "ITTGOA"
                obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
                obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
                'obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
                'obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
                obeCostoAgencia.PNIGV = ItemCosto("PIGVA")
                '******calculo importes**************
                obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_Origen(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"), "")
                obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
                obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
                obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL

                obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL

                obeCostoAgencia.PNIMPORTE_TOTAL_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_DOL
                obeCostoAgencia.PNIMPORTE_TOTAL_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_SOL

                '***********************************************

                obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
                obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
                obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
                obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
                obeCostoAgencia.PBSELECCIONADO = True
                obeCostoAgencia.PBSELECCIONABLE = True
                oListbeCostoAgencia.Add(obeCostoAgencia)
            Next
            '************************************************************
            '****************TRACCION AGENCIAS***************************
            For Each ItemCosto As DataRow In oDtCostoTraccion.Rows
                obeCostoAgencia = New beCostoAgencia
                obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
                obeCostoAgencia.PSVARCOSTO = "ITTRAC"
                obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
                obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
                'obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
                'obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
                obeCostoAgencia.PNIGV = ItemCosto("PIGVA")

                '******calculo importes**************
                obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_Origen(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"), "")
                obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
                obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
                obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
                obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL

                obeCostoAgencia.PNIMPORTE_TOTAL_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_DOL
                obeCostoAgencia.PNIMPORTE_TOTAL_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_SOL
                '***********************************************


                obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
                obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
                obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
                obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
                obeCostoAgencia.PBSELECCIONADO = True
                obeCostoAgencia.PBSELECCIONABLE = True
                oListbeCostoAgencia.Add(obeCostoAgencia)
            Next
            '****************COMISION AGENCIAS*************************
            For Each ItemCosto As DataRow In odtCostoComisionAgencia.Rows
                obeCostoAgencia = New beCostoAgencia
                obeCostoAgencia.PSIDUNICO = ItemCosto("CSRVRL") & "-" & ItemCosto("NUMDOC").ToString.Trim
                obeCostoAgencia.PSVARCOSTO = "ITTCAG"
                obeCostoAgencia.PNCSRVRL = ItemCosto("CSRVRL")
                obeCostoAgencia.PSTCMTRF = ItemCosto("TCMTRF").ToString.Trim
                'obeCostoAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto("MONTO_DOL")
                'obeCostoAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto("MONTO_SOL")
                obeCostoAgencia.PNIGV = ItemCosto("PIGVA")
                '******calculo importes**************

                obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_Origen(ItemCosto("MONTO_DOL"), ItemCosto("MONTO_SOL"), ItemCosto("PIGVA"), "COMISION")
                obeCostoAgencia.PNIMPORTE_BASE_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
                obeCostoAgencia.PNIMPORTE_IGV_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL
                obeCostoAgencia.PNIMPORTE_BASE_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
                obeCostoAgencia.PNIMPORTE_IGV_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL


                obeCostoAgencia.PNIMPORTE_TOTAL_DOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_DOL
                obeCostoAgencia.PNIMPORTE_TOTAL_SOL = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_SOL
                '***********************************************

                obeCostoAgencia.PNIMTPOC = ItemCosto("IMTPOC")
                obeCostoAgencia.PNTIPODOC = ItemCosto("TIPODOC")
                obeCostoAgencia.PNNUMDOC = ItemCosto("NUMDOC")
                obeCostoAgencia.PSTCMTPD = ItemCosto("TCMTPD")
                obeCostoAgencia.PBSELECCIONADO = True
                obeCostoAgencia.PBSELECCIONABLE = True
                oListbeCostoAgencia.Add(obeCostoAgencia)
            Next
            '***********************************************************
            EvaluarItemDeSeleccion("ITTRAC")
            '*************COMISION AGENCIAS*****************************************
            Dim FilaITTCAG As Int32 = FilaConceptoAg("ITTCAG")
            dtgAgencias.Rows(FilaITTCAG).Tag = "ITTCAG_DETALLE"
            dtgAgencias.Rows(FilaITTCAG).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
            dtgAgencias.Rows(FilaITTCAG).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTCAG")
            dtgAgencias.Rows(FilaITTCAG).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle"
            If (odtCostoComisionAgencia.Rows.Count > 0) Then
                OS_FACTURADO = True
            End If
            '*************************************************************************
            '****************COSTOS OPERATIVOS********************************************
            Dim FilaITTGOA As Int32 = FilaConceptoAg("ITTGOA")
            dtgAgencias.Rows(FilaITTGOA).Tag = "ITTGOA_DETALLE"
            dtgAgencias.Rows(FilaITTGOA).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTGOA")
            dtgAgencias.Rows(FilaITTGOA).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
            dtgAgencias.Rows(FilaITTGOA).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle"
            '*******************************************************************************
        End If
        If (OS_FACTURADO = True) Then ' SI NO TIENE COMISION NO ESTA FACTURADO
            msgTitulo = msgTitulo & " | " & ogenDatosEmbarque_BE.PNPNNMOS & " :FACTURADO"
        Else
            msgTitulo = msgTitulo & " | " & ogenDatosEmbarque_BE.PNPNNMOS & " : NO FACTURADO"
        End If
        Me.Text = msgTitulo
        '---------------------------------------------------------
        'COSTOS TRACCION
        '-----------------------------------------------------
        Dim FilaITTRAC As Int32 = FilaConceptoAg("ITTRAC")
        dtgAgencias.Rows(FilaITTRAC).Tag = "ITTRAC_DETALLE"
        dtgAgencias.Rows(FilaITTRAC).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTRAC")
        dtgAgencias.Rows(FilaITTRAC).Cells("VAL_AGENCIA").Style.BackColor = Color.FromArgb(255, 255, 192)
        dtgAgencias.Rows(FilaITTRAC).Cells("VAL_AGENCIA").ToolTipText = "Ver detalle."
        '-----------------------------------------------------

        '
        Dim odtChkAgencia As New DataTable
        odtChkAgencia = oclsImporCostos.ListarCheckPointAgencia(ogenDatosEmbarque_BE.PNPNNMOS, ogenDatosEmbarque_BE.PNCZNFCC)
        If odtChkAgencia.Rows.Count > 0 Then

            Dim FilaFLEVANTE As Int32 = FilaConceptoAg("FLEVANTE")
            dtgAgencias.Rows(FilaFLEVANTE).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("LEVANTE"))
            dtgAgencias.Rows(FilaFLEVANTE).Cells("VAL_AGENCIA").ToolTipText = "F. Levante"


            Dim FilaFAPRAR As Int32 = FilaConceptoAg("FAPRAR")
            dtgAgencias.Rows(FilaFAPRAR).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("ARRIBO"))
            dtgAgencias.Rows(FilaFAPRAR).Cells("VAL_AGENCIA").ToolTipText = "Fecha Llegada"

            Dim FilaFCDCOR As Int32 = FilaConceptoAg("FCDCOR")
            dtgAgencias.Rows(FilaFCDCOR).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("TARJA"))
            dtgAgencias.Rows(FilaFCDCOR).Cells("VAL_AGENCIA").ToolTipText = "F. Volante"

            Dim FilaCKPREV As Int32 = FilaConceptoAg("CKPREV")
            dtgAgencias.Rows(FilaCKPREV).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("PREVIO"))
            dtgAgencias.Rows(FilaCKPREV).Cells("VAL_AGENCIA").ToolTipText = "F. Aforo Previo"

            Dim FilaFECAFI As Int32 = FilaConceptoAg("FECAFI")
            dtgAgencias.Rows(FilaFECAFI).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("AFORO_FISICO"))
            dtgAgencias.Rows(FilaFECAFI).Cells("VAL_AGENCIA").ToolTipText = "F. Aforo Físico"

            Dim FilaFECRCA As Int32 = FilaConceptoAg("FECRCA")
            dtgAgencias.Rows(FilaFECRCA).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("RETIRO_CARGA"))
            dtgAgencias.Rows(FilaFECRCA).Cells("VAL_AGENCIA").ToolTipText = "F. Retiro Carga"

            Dim FilaFECALM As Int32 = FilaConceptoAg("FECALM")
            dtgAgencias.Rows(FilaFECALM).Cells("VAL_AGENCIA").Value = HelpClass.FechaNum_a_Fecha(odtChkAgencia.Rows(0)("ENTREGA_CARGA"))
            dtgAgencias.Rows(FilaFECALM).Cells("VAL_AGENCIA").ToolTipText = "F. Entrega Carga Almacén"


        End If


    End Sub



    Private Function SearchTodosCostosxCodVar(ByVal obeCostoAgencia As beCostoAgencia) As Boolean
        Return obeCostoAgencia.PSVARCOSTO = PSVARCOSTO
    End Function

    Private Function SearchSeleccionadosCostosxCodVar(ByVal obeCostoAgencia As beCostoAgencia) As Boolean
        Return obeCostoAgencia.PSVARCOSTO = PSVARCOSTO And obeCostoAgencia.PBSELECCIONADO = True
    End Function

    Private Function ListarSeleccionadosCostosxCodVar(ByVal PSCODVARIABLE As String) As List(Of beCostoAgencia)
        Dim oListaCostoGastoGen As New List(Of beCostoAgencia)
        PSVARCOSTO = PSCODVARIABLE
        oListaCostoGastoGen = oListbeCostoAgencia.FindAll(AddressOf SearchSeleccionadosCostosxCodVar)
        Return oListaCostoGastoGen
    End Function

    Private Function ListarTodosCostosxCodVar(ByVal PSCODVARIABLE As String) As List(Of beCostoAgencia)
        Dim oListaCostoGastoGen As New List(Of beCostoAgencia)
        PSVARCOSTO = PSCODVARIABLE
        oListaCostoGastoGen = oListbeCostoAgencia.FindAll(AddressOf SearchTodosCostosxCodVar)
        Return oListaCostoGastoGen
    End Function
    Private Sub ActualizarSeleccionCostos(ByVal PSCODIGOVAR As String, ByVal ListaCostoRubro As List(Of String))
        For Each Item As beCostoAgencia In oListbeCostoAgencia
            If (Item.PSVARCOSTO = PSCODIGOVAR) Then
                If (ListaCostoRubro.Contains(Item.PSIDUNICO)) Then
                    Item.PBSELECCIONADO = True
                    Item.PBSELECCIONABLE = True
                Else
                    Item.PBSELECCIONADO = False
                    Item.PBSELECCIONABLE = True
                End If
            End If
        Next
    End Sub

    Private Sub EvaluarItemDeSeleccion(ByVal PSVARIABLECOSTO As String)
        Dim oListaCostoGastoGen As New List(Of beCostoAgencia)
        Dim oListaCostoTraccion As New List(Of beCostoAgencia)
        Dim oListGatstosOpoSeleccionados As New List(Of String)
        oListaCostoGastoGen = ListarTodosCostosxCodVar("ITTGOA")
        oListaCostoTraccion = ListarTodosCostosxCodVar("ITTRAC")
        If (oListaCostoGastoGen IsNot Nothing) Then
            For Each ItemCostoAgencia As beCostoAgencia In oListaCostoGastoGen
                If (ItemCostoAgencia.PBSELECCIONADO = True) Then
                    If (Not oListGatstosOpoSeleccionados.Contains(ItemCostoAgencia.PSIDUNICO)) Then
                        oListGatstosOpoSeleccionados.Add(ItemCostoAgencia.PSIDUNICO)
                    End If
                End If
            Next
        End If
        Select Case PSVARIABLECOSTO
            Case "ITTRAC"
                For Each Item As beCostoAgencia In oListbeCostoAgencia
                    If (Item.PSVARCOSTO = "ITTRAC") Then
                        If (oListGatstosOpoSeleccionados.Contains(Item.PSIDUNICO)) Then
                            Item.PBSELECCIONABLE = False
                            Item.PBSELECCIONADO = False
                        Else
                            Item.PBSELECCIONABLE = True
                        End If

                    End If
                Next
        End Select
    End Sub


    Private Function ObtenerMontoDolarFinalXVariableCosto(ByVal PSCODIGOVAR As String) As Decimal
        Dim MontoTotal As Decimal = 0
        For Each Item As beCostoAgencia In oListbeCostoAgencia
            If (Item.PSVARCOSTO = PSCODIGOVAR AndAlso Item.PBSELECCIONADO = True) Then
                MontoTotal = MontoTotal + Item.PNIMPORTE_BASE_DOL
            End If
        Next
        Return MontoTotal
    End Function


    'Private Function Otros_Gastos(ByVal pobjDt As DataTable) As Double
    '    Dim ldblMonto As Double
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALSBT"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALDES"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALISC"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALADP"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALICP"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALMOR"))
    '    ldblMonto = ldblMonto + Double.Parse(pobjDt.Rows(0).Item("VALRNP"))
    '    Return ldblMonto
    'End Function

    Private Sub Cargar_Tabla_SIL_Detalle()

        dtgSILDetalle.Rows.Clear()
        cargaDetalleSil = False
        scolOCSIL.Clear()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        oDt = oEmbarque.Lista_Detalle_OC_Embarque_Ajuste(oEmbarque.pCCLNT, oEmbarque.pNORSCI)
        Dim Fila As Int32 = 0
        With oDt
            If oDt.Rows.Count > 0 Then
                For intCont = 0 To oDt.Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgSILDetalle)
                    dtgSILDetalle.Rows.Add(oDrVw)
                    Fila = dtgSILDetalle.Rows.Count - 1
                    dtgSILDetalle.Rows(Fila).Cells("CPTDAR").Value = .Rows(intCont).Item("CPTDAR").ToString.Trim
                    If (.Rows(intCont).Item("NSERIE") <> 0) Then
                        dtgSILDetalle.Rows(Fila).Cells("COLNSERIE").Value = .Rows(intCont).Item("NSERIE")
                    End If
                    dtgSILDetalle.Rows(Fila).Cells("ORCOM").Value = .Rows(intCont).Item("NORCML").ToString.Trim
                    dtgSILDetalle.Rows(Fila).Cells("ITEM").Value = .Rows(intCont).Item("NRITEM")
                    dtgSILDetalle.Rows(Fila).Cells("FOB").Value = .Rows(intCont).Item("TOTFOB")
                    dtgSILDetalle.Rows(Fila).Cells("FLETE").Value = .Rows(intCont).Item("TOTFLT")
                    dtgSILDetalle.Rows(Fila).Cells("SEGURO").Value = .Rows(intCont).Item("TOTSEG")
                    dtgSILDetalle.Rows(Fila).Cells("CIF").Value = .Rows(intCont).Item("TOTCIF")
                    dtgSILDetalle.Rows(Fila).Cells("ADVAL").Value = .Rows(intCont).Item("TOTADV")
                    dtgSILDetalle.Rows(Fila).Cells("IGV").Value = .Rows(intCont).Item("TOTIGV")
                    dtgSILDetalle.Rows(Fila).Cells("IPM").Value = .Rows(intCont).Item("TOTIPM")
                    'dtgSILDetalle.Rows(Fila).Cells("TOTOGS").Value = .Rows(intCont).Item("TOTOGS")
                    'dtgSILDetalle.Rows(Fila).Cells("TOTOGS").ToolTipText = "SBT+DES+ISC+ADP+ICP+MOR+RNP"
                    dtgSILDetalle.Rows(Fila).Cells("NRPEMB").Value = .Rows(intCont).Item("NRPEMB")
                    dtgSILDetalle.Rows(Fila).Cells("SBITOC").Value = .Rows(intCont).Item("SBITOC").ToString.Trim
                    dtgSILDetalle.Rows(Fila).Cells("NFCTCM").Value = .Rows(intCont).Item("NFCTCM").ToString.Trim

                    dtgSILDetalle.Rows(Fila).Cells("TDITES").Value = .Rows(intCont).Item("TDITES").ToString.Trim
                    dtgSILDetalle.Rows(Fila).Cells("QRLCSC").Value = .Rows(intCont).Item("QRLCSC").ToString.Trim
                    dtgSILDetalle.Rows(Fila).Cells("IVUNIT").Value = .Rows(intCont).Item("IVUNIT").ToString.Trim
                    dtgSILDetalle.Rows(Fila).Cells("QTPCM2").Value = .Rows(intCont).Item("QTPCM2").ToString.Trim ' TIPO DE CAMBIO

                    dtgSILDetalle.Rows(Fila).Cells("VALMRC_SIL").Value = .Rows(intCont).Item("VALMRC")
                    dtgSILDetalle.Rows(Fila).Cells("NMITFC_SIL").Value = .Rows(intCont).Item("NMITFC")

                    dtgSILDetalle.Rows(Fila).Cells("NSEQIN").Value = .Rows(intCont).Item("NSEQIN").ToString.Trim
                    scolOCSIL.Add(.Rows(intCont).Item("NORCML").ToString.Trim & "-" & .Rows(intCont).Item("NRITEM").ToString.Trim)

                Next
            End If
        End With
        cargaDetalleSil = True
    End Sub

    Public Shared Function CNumero_a_Fecha(ByVal oFecha As Object) As String

        Dim y As Integer
        Dim m As Integer
        Dim d As Integer
        If oFecha = "" Then
            Return ""
        Else
            y = oFecha.ToString.Substring(0, 4)
            m = oFecha.ToString.Substring(4, 2)
            d = oFecha.ToString.Substring(6, 2)

            Dim objDate As New Date(y, m, d)
            Return objDate
        End If
    End Function

#End Region

    Private Sub ImportarAgencias()
        Dim obeCostoTotalEmbarque As beCostoTotalEmbarque
        Dim oListCostoAgenciasSeleccionados As List(Of beCostoAgencia)
        Dim oFnEmbarqueAduanas As New clsEmbarqueAduanas
        Dim variable As String = ""
        Dim valor As Object
        'Dim valor_derecho_especifico As Decimal = 0
        Dim valor_derecho_totales As Decimal = 0
        Me.dtgAgencias.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim obeDocumentoCosto As beDocumentoCostos
        Dim NCODRG_REGIMEN As Decimal = 0
        Dim NCODRG_DESPACHO As Decimal = 0
        For Each Item As DataGridViewRow In dtgAgencias.Rows
            variable = ""
            If (Item.Cells("ESTADO").Value = True) Then
                variable = Item.Cells("VARIABLE_AGENCIA").Value.ToString.Trim
                valor = Item.Cells("VAL_AGENCIA").Value

                Select Case variable
                    Case "RADUANA"
                        NCODRG_REGIMEN = oFnEmbarqueAduanas.RegimenCodigo_X_Descripcion(oLitsRegimen, ("" & valor).ToString.Trim)
                        If NCODRG_REGIMEN > 0 Then
                            oEmbarque.Actualiza_Regimen(Me.oEmbarque.pNORSCI, NCODRG_REGIMEN)
                        End If
                    Case "TDESPACHO"
                        NCODRG_DESPACHO = oFnEmbarqueAduanas.DespachoCodigo_X_Descripcion(oLitsDespacho, ("" & valor).ToString.Trim)
                        If NCODRG_DESPACHO > 0 Then
                            oEmbarque.Actualiza_Despacho(Me.oEmbarque.pNORSCI, NCODRG_DESPACHO)
                        End If
                    Case "FLEVANTE"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_Levante(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "CANAL"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Canal(Me.oEmbarque.pNORSCI, ogenDatosEmbarque_BE.PNPNNMOS, valor)
                        End If
                    Case "FPAGO"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_Pago_Derechos(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "FNUMDUA"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_Numeracion(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "DUA"
                        'Dim strArr() As String
                        'Dim strRuta As String
                        Dim dblTotal As Double
                        obeDocumentoCosto = New beDocumentoCostos
                        If (valor <> vbNullString OrElse valor <> "") Then
                            'strArr = valor.ToString.Trim.Split("-")
                            'If strArr.Length = 1 Then
                            '    strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & Mid(valor, 8, 2)
                            '    strRuta = strRuta & "&codaduana=" & Mid(valor, 1, 3)
                            '    strRuta = strRuta & "&anoprese=" & Mid(valor, 4, 4)
                            '    strRuta = strRuta & "&numecorre=" & Mid(valor, 10, 6)
                            'Else
                            '    strRuta = "http://www.aduanet.gob.pe/servlet/SgCDUI2?option=una&n=" & strArr(2)
                            '    strRuta = strRuta & "&codaduana=" & strArr(0)
                            '    strRuta = strRuta & "&anoprese=" & strArr(1)
                            '    strRuta = strRuta & "&numecorre=" & strArr(3)
                            'End If
                            'dblTotal = Obtener_Monto_Derecho_Especifico()
                            dblTotal = Obtener_Monto_Derechos_Totales()
                            'Obtener_Monto_Derechos_Totales
                            obeDocumentoCosto.PNNORSCI = oEmbarque.pNORSCI
                            obeDocumentoCosto.PNNDOCIN = 106
                            obeDocumentoCosto.PNIVLORG = dblTotal
                            obeDocumentoCosto.PNIVLDOL = dblTotal
                            obeDocumentoCosto.PNCMNDA1 = 100
                            obeDocumentoCosto.PSNMONOC = "USD"
                            obeDocumentoCosto.PNNCRRDC = 0
                            obeDocumentoCosto.PSNDOCUM = valor
                            oDocApertura.Grabar_Documentos_Costos_Embarque_DUA(obeDocumentoCosto)
                            oEmbarque.Actualiza_DUA(obeDocumentoCosto.PNNORSCI, ogenDatosEmbarque_BE.PNPNNMOS, obeDocumentoCosto.PSNDOCUM)
                        End If


                    Case "FOB", "FLETE", "SEGURO", "CIF", _
                          "ADVALO", "IGV", "IPM", "TASDES", _
                          "DERESP", "SOBTAS", "ANTDUM", "IMSECO", "INTCOM", "MORA"
                        If (valor > 0) Then

                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = oEmbarque.pNORSCI
                            obeCostoTotalEmbarque.PSCODVAR = variable
                            obeCostoTotalEmbarque.PNIVLORG = valor
                            obeCostoTotalEmbarque.PNIVLDOL = valor
                            obeCostoTotalEmbarque.PNCMNDA1 = 100
                            obeCostoTotalEmbarque.PSNMONOC = "USD"
                            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
                        End If

                    Case "ITTGOA"
                        If (valor > 0) Then
                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = oEmbarque.pNORSCI
                            obeCostoTotalEmbarque.PSCODVAR = variable
                            obeCostoTotalEmbarque.PNIVLORG = valor
                            obeCostoTotalEmbarque.PNIVLDOL = valor
                            obeCostoTotalEmbarque.PNCMNDA1 = 100
                            obeCostoTotalEmbarque.PSNMONOC = "USD"

                            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
                            oListCostoAgenciasSeleccionados = ListarSeleccionadosCostosxCodVar("ITTGOA")
                            If (oListCostoAgenciasSeleccionados IsNot Nothing) Then
                                Dim obeDetCostoRubroAgencia As beDetCostoRubroAgencia
                                Dim oListobeDetCostoRubroAgencia As New List(Of beDetCostoRubroAgencia)
                                For Each ItemCosto As beCostoAgencia In oListCostoAgenciasSeleccionados
                                    If (ItemCosto.PBSELECCIONADO = True) Then
                                        obeDetCostoRubroAgencia = New beDetCostoRubroAgencia
                                        obeDetCostoRubroAgencia.PNNORSCI = oEmbarque.pNORSCI
                                        obeDetCostoRubroAgencia.PNCSRVRL = ItemCosto.PNCSRVRL
                                        obeDetCostoRubroAgencia.PSCODVAR = variable
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_DOL = ItemCosto.PNIMPORTE_BASE_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_SOL = ItemCosto.PNIMPORTE_BASE_SOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto.PNIMPORTE_TOTAL_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto.PNIMPORTE_TOTAL_SOL
                                        obeDetCostoRubroAgencia.PNIGV = ItemCosto.PNIGV
                                        obeDetCostoRubroAgencia.PNIMTPOC = ItemCosto.PNIMTPOC
                                        obeDetCostoRubroAgencia.PNTIPODOC = ItemCosto.PNTIPODOC
                                        obeDetCostoRubroAgencia.PNNUMDOC = ItemCosto.PNNUMDOC

                                        oListobeDetCostoRubroAgencia.Add(obeDetCostoRubroAgencia)
                                    End If
                                Next
                                oDocApertura.Insertar_Costo_Detalle_Embarque_Rubro_Agencia(oListobeDetCostoRubroAgencia)
                            End If
                        End If

                    Case "ITTCAG"
                        If (valor > 0) Then
                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = oEmbarque.pNORSCI
                            obeCostoTotalEmbarque.PSCODVAR = variable
                            obeCostoTotalEmbarque.PNIVLORG = valor
                            obeCostoTotalEmbarque.PNIVLDOL = valor
                            obeCostoTotalEmbarque.PNCMNDA1 = 100
                            obeCostoTotalEmbarque.PSNMONOC = "USD"

                            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
                            oListCostoAgenciasSeleccionados = ListarSeleccionadosCostosxCodVar("ITTCAG")
                            If (oListCostoAgenciasSeleccionados IsNot Nothing) Then
                                Dim obeDetCostoRubroAgencia As beDetCostoRubroAgencia
                                Dim oListobeDetCostoRubroAgencia As New List(Of beDetCostoRubroAgencia)
                                For Each ItemCosto As beCostoAgencia In oListCostoAgenciasSeleccionados
                                    If (ItemCosto.PBSELECCIONADO = True) Then
                                        obeDetCostoRubroAgencia = New beDetCostoRubroAgencia
                                        obeDetCostoRubroAgencia.PNNORSCI = oEmbarque.pNORSCI
                                        obeDetCostoRubroAgencia.PNCSRVRL = ItemCosto.PNCSRVRL
                                        obeDetCostoRubroAgencia.PSCODVAR = variable
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_DOL = ItemCosto.PNIMPORTE_BASE_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_SOL = ItemCosto.PNIMPORTE_BASE_SOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto.PNIMPORTE_TOTAL_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto.PNIMPORTE_TOTAL_SOL
                                        obeDetCostoRubroAgencia.PNIGV = ItemCosto.PNIGV
                                        obeDetCostoRubroAgencia.PNIMTPOC = ItemCosto.PNIMTPOC
                                        obeDetCostoRubroAgencia.PNTIPODOC = ItemCosto.PNTIPODOC
                                        obeDetCostoRubroAgencia.PNNUMDOC = ItemCosto.PNNUMDOC
                                        oListobeDetCostoRubroAgencia.Add(obeDetCostoRubroAgencia)
                                    End If
                                Next
                                oDocApertura.Insertar_Costo_Detalle_Embarque_Rubro_Agencia(oListobeDetCostoRubroAgencia)
                            End If

                        End If

                    Case "ITTRAC"
                        If (valor > 0) Then
                            obeCostoTotalEmbarque = New beCostoTotalEmbarque
                            obeCostoTotalEmbarque.PNNORSCI = oEmbarque.pNORSCI
                            obeCostoTotalEmbarque.PSCODVAR = variable
                            obeCostoTotalEmbarque.PNIVLORG = valor
                            obeCostoTotalEmbarque.PNIVLDOL = valor
                            obeCostoTotalEmbarque.PNCMNDA1 = 100
                            obeCostoTotalEmbarque.PSNMONOC = "USD"
                            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
                            oListCostoAgenciasSeleccionados = ListarSeleccionadosCostosxCodVar("ITTRAC")
                            If (oListCostoAgenciasSeleccionados IsNot Nothing) Then
                                Dim obeDetCostoRubroAgencia As beDetCostoRubroAgencia
                                Dim oListobeDetCostoRubroAgencia As New List(Of beDetCostoRubroAgencia)
                                For Each ItemCosto As beCostoAgencia In oListCostoAgenciasSeleccionados
                                    If (ItemCosto.PBSELECCIONADO = True) Then
                                        obeDetCostoRubroAgencia = New beDetCostoRubroAgencia
                                        obeDetCostoRubroAgencia.PNNORSCI = oEmbarque.pNORSCI
                                        obeDetCostoRubroAgencia.PNCSRVRL = ItemCosto.PNCSRVRL
                                        obeDetCostoRubroAgencia.PSCODVAR = variable
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_DOL = ItemCosto.PNIMPORTE_BASE_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_BASE_SOL = ItemCosto.PNIMPORTE_BASE_SOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_DOL = ItemCosto.PNIMPORTE_TOTAL_DOL
                                        obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_SOL = ItemCosto.PNIMPORTE_TOTAL_SOL
                                        obeDetCostoRubroAgencia.PNIGV = ItemCosto.PNIGV
                                        obeDetCostoRubroAgencia.PNIMTPOC = ItemCosto.PNIMTPOC
                                        obeDetCostoRubroAgencia.PNTIPODOC = ItemCosto.PNTIPODOC
                                        obeDetCostoRubroAgencia.PNNUMDOC = ItemCosto.PNNUMDOC
                                        oListobeDetCostoRubroAgencia.Add(obeDetCostoRubroAgencia)
                                    End If
                                Next
                                oDocApertura.Insertar_Costo_Detalle_Embarque_Rubro_Agencia(oListobeDetCostoRubroAgencia)
                            End If

                        End If

                    Case "FAPRAR"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_LLegada(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "FCDCOR"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_Volante(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "CKPREV"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_AforoPrevio(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "FECAFI"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_AforoFisico(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "FECRCA"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_RetiroCarga(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case "FECALM"
                        If (valor <> vbNullString) Then
                            oEmbarque.Actualiza_Status_Entrega(pCCMPN, pCDVSN, Me.oEmbarque.pNORSCI, Format(CType(valor, Date), "yyyyMMdd"))
                        End If
                    Case Else
                        variable = ""

                End Select

            End If
        Next

        'valor_derecho_especifico = Obtener_Monto_Derecho_Especifico()
        valor_derecho_totales = Obtener_Monto_Derechos_Totales()
        '  dblTotal = Obtener_Monto_Derechos_Totales()
        If (valor_derecho_totales > 0) Then
            obeCostoTotalEmbarque = New beCostoTotalEmbarque
            obeCostoTotalEmbarque.PNNORSCI = oEmbarque.pNORSCI
            obeCostoTotalEmbarque.PSCODVAR = "TOLDER"
            obeCostoTotalEmbarque.PNIVLORG = valor_derecho_totales
            obeCostoTotalEmbarque.PNIVLDOL = valor_derecho_totales
            obeCostoTotalEmbarque.PNCMNDA1 = 100
            obeCostoTotalEmbarque.PSNMONOC = "USD"
            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)
        End If

    End Sub

    'Private Function Obtener_Monto_Derecho_Especifico() As Decimal
    '    Dim valor_derecho_especifico As Decimal = 0
    '    If (dtgAgencias.Rows(11).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
    '        valor_derecho_especifico = UTILITY.ObjectToDecimal(dtgAgencias.Rows(11).Cells("VAL_AGENCIA").Value) 'ADVALOREM
    '    End If
    '    If (dtgAgencias.Rows(12).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
    '        valor_derecho_especifico += UTILITY.ObjectToDecimal(dtgAgencias.Rows(12).Cells("VAL_AGENCIA").Value) ' IGV
    '    End If
    '    If (dtgAgencias.Rows(13).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
    '        valor_derecho_especifico += UTILITY.ObjectToDecimal(dtgAgencias.Rows(13).Cells("VAL_AGENCIA").Value) 'IPM
    '    End If
    '    If dtgAgencias.Rows(14).Cells("VAL_AGENCIA").Value.ToString.Length > 0 Then
    '        valor_derecho_especifico += UTILITY.ObjectToDecimal(dtgAgencias.Rows(14).Cells("VAL_AGENCIA").Value) ' OTROS GASTOS
    '    End If
    '    Return valor_derecho_especifico
    'End Function


    '  oHas.Add("C100", "Régimen Aduanero/RADUANA")
    '    oHas.Add("C110", "Tipo de Despacho/TDESPACHO")
    '    oHas.Add("C120", "Fecha de Levante/FLEVANTE")
    '    oHas.Add("C130", "Canal/CANAL")
    '    oHas.Add("C140", "Fecha de Pago/FPAGO")
    '    oHas.Add("C150", "Fecha de Numeración de Dua/FNUMDUA")
    '    oHas.Add("C160", "DUA/DUA")
    '    oHas.Add("C170", "FOB/FOB")
    '    oHas.Add("C180", "Flete/FLETE")
    '    oHas.Add("C190", "Seguro/SEGURO")
    '    oHas.Add("C200", "CIF/CIF")
    '    oHas.Add("C210", "Advaloren/ADVALO")

    ''*******adicionados**********************
    '    oHas.Add("C212", "Derecho Específico/DERESP")
    '    oHas.Add("C214", "SobreTasa/SOBTAS")
    '    oHas.Add("C216", "Antidumping/ANTDUM")
    '    oHas.Add("C218", "ISC/IMSECO")
    ''*****************************************

    '    oHas.Add("C220", "IGV/IGV")
    '    oHas.Add("C230", "IPM/IPM")
    '    oHas.Add("C240", "Tasa de Despacho/OTSGAS")

    ''*******adicionados***********************
    '    oHas.Add("C242", "Interés Compensatorio/INTCOM")
    '    oHas.Add("C244", "Mora/MORA")
    ''*****************************************

    '    oHas.Add("C250", "Comisión Agenciamiento/ITTCAG")
    '    oHas.Add("C260", "Gastos Operativos A.G./ITTGOA")
    '    oHas.Add("C270", "Tracción/ITTRAC")


    ''NUEVOS CHECKPOINTS

    '    oHas.Add("C280", "Fecha Llegada/FAPRAR")
    '    oHas.Add("C290", "Volante/FCDCOR")
    '    oHas.Add("C300", "Previo/CKPREV")
    '    oHas.Add("C310", "Aforo Físico/FECAFI")
    '    oHas.Add("C320", "Retiro de la Carga/FECRCA")
    '    oHas.Add("C330", "Entrega de la carga en Almacén/FECALM")

    'dtgAgencias.Rows(Fila).Cells("DEF_AGENCIA").Value = strConcepto(0)
    '     dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value = ""
    '     dtgAgencias.Rows(Fila).Cells("VARIABLE_AGENCIA").Value = strConcepto(1)

    Private Function FilaConceptoSIL(ByVal Concepto As String) As Int32
        Dim FilaConcepto As Int32 = -1
        For Fila As Integer = 0 To dtgSIL.Rows.Count - 1
            If dtgSIL.Rows(Fila).Cells("VARIABLE").Value = Concepto Then
                FilaConcepto = Fila
                Exit For
            End If
        Next
        Return FilaConcepto
    End Function
    Private Function FilaConceptoAg(ByVal Concepto As String) As Int32
        Dim FilaConcepto As Int32 = -1
        For Fila As Integer = 0 To dtgAgencias.Rows.Count - 1
            If dtgAgencias.Rows(Fila).Cells("VARIABLE_AGENCIA").Value = Concepto Then
                FilaConcepto = Fila
                Exit For
            End If
        Next
        Return FilaConcepto
    End Function


    Private Function Obtener_Monto_Derechos_Totales() As Decimal
        Dim valor_derecho_total As Decimal = 0
        Dim FilaConcepto As Int32 = -1
        Dim ConceptosAgencias As String = ""
        ConceptosAgencias = "ADVALO,DERESP,SOBTAS,ANTDUM,IMSECO,IGV,IPM,TASDES,INTCOM,MORA"
        'ConceptosAgencias = "ADVALO,DERESP,SOBTAS,ANTDUM,IMSECO,IGV,IPM,TASDES"
        For Each Item As String In ConceptosAgencias.Split(",")
            FilaConcepto = FilaConceptoAg(Item)
            If (dtgAgencias.Rows(FilaConcepto).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
                valor_derecho_total = valor_derecho_total + HelpClass.ObjectToDecimal(dtgAgencias.Rows(FilaConcepto).Cells("VAL_AGENCIA").Value)
            End If
        Next
        'Dim FAdvalorem As Int32 = FilaConceptoAgencia("ADVALO")
        'Dim FDerEspecifico As Int32 = FilaConceptoAgencia("DERESP")
        'Dim FSobreTasa As Int32 = FilaConceptoAgencia("SOBTAS")
        'Dim FAntiDump As Int32 = FilaConceptoAgencia("ANTDUM")
        'Dim FISC As Int32 = FilaConceptoAgencia("IMSECO")
        'Dim FIGV As Int32 = FilaConceptoAgencia("IGV")
        'Dim FIPM As Int32 = FilaConceptoAgencia("IPM")
        'Dim FTasaDespacho As Int32 = FilaConceptoAgencia("OTSGAS") 'TASA DESPACHO

        'Dim FInteComp As Int32 = FilaConceptoAgencia("INTCOM")
        'Dim FMORA As Int32 = FilaConceptoAgencia("MORA")

        'If (dtgAgencias.Rows(FAdvalorem).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
        '    valor_derecho_total = HelpClass.ObjectToDecimal(dtgAgencias.Rows(FAdvalorem).Cells("VAL_AGENCIA").Value) 'ADVALOREM
        'End If
        'If (dtgAgencias.Rows(FIGV).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
        '    valor_derecho_total += HelpClass.ObjectToDecimal(dtgAgencias.Rows(FIGV).Cells("VAL_AGENCIA").Value) ' IGV
        'End If
        'If (dtgAgencias.Rows(FIPM).Cells("VAL_AGENCIA").Value.ToString.Length > 0) Then
        '    valor_derecho_total += HelpClass.ObjectToDecimal(dtgAgencias.Rows(FIPM).Cells("VAL_AGENCIA").Value) 'IPM
        'End If
        'If dtgAgencias.Rows(14).Cells("VAL_AGENCIA").Value.ToString.Length > 0 Then
        '    valor_derecho_total += HelpClass.ObjectToDecimal(dtgAgencias.Rows(14).Cells("VAL_AGENCIA").Value) ' OTROS GASTOS
        'End If
        Return valor_derecho_total
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub



    Private Sub ValidarEntradaDatos(ByVal Fila As Int32)
        Dim validar As Boolean = False
        Dim valor_validacion As Boolean = False
        Dim estado As Boolean = False
        Dim VAL_DATO As String = dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value
        Dim variable As String = ""
        variable = dtgAgencias.Rows(Fila).Cells("VARIABLE_AGENCIA").Value.ToString.Trim
        estado = dtgAgencias.Rows(Fila).Cells("ESTADO").Value

        Select Case variable

            Case "CANAL", "DUA", "TDESPACHO", "RADUANA"
                If (VAL_DATO <> "") Then
                    valor_validacion = True
                End If

            Case "FOB", "FLETE", "SEGURO", "CIF", _
                  "ADVALO", "IGV", "IPM", "TASDES", _
                "ITTCAG", "ITTGOA", "ITTRAC", _
                  "DERESP", "SOBTAS", "ANTDUM", "IMSECO", "INTCOM", "MORA"

                If (VAL_DATO <> "") Then
                    If (VAL_DATO > 0) Then
                        valor_validacion = True
                    End If
                End If
            Case "FPAGO", "FNUMDUA", "FLEVANTE", _
                  "FAPRAR", "FCDCOR", "CKPREV", "FECAFI", "FECRCA", "FECALM"
                If (VAL_DATO <> "") Then
                    If (Format(CType(VAL_DATO, Date), "yyyyMMdd") > 0) Then
                        valor_validacion = True
                    End If
                End If
            Case Else
                variable = ""
        End Select


        If (estado = True) Then
            If (valor_validacion = True) Then
                validar = True
                dtgSIL.Rows(Fila).Cells("VAL_IMPORT").Value = dtgAgencias.Rows(Fila).Cells("VAL_AGENCIA").Value
                dtgSIL.Rows(Fila).DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Else
            dtgSIL.Rows(Fila).Cells("VAL_IMPORT").Value = ""
            dtgSIL.Rows(Fila).DefaultCellStyle.BackColor = Color.White
        End If
        If (validar = False) Then
            dtgAgencias.Rows(Fila).Cells("ESTADO").Value = False
        End If
    End Sub


    Private Sub dtgSIL_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSIL.RowEnter
        Try
            If (dtgAgencias.CurrentRow IsNot Nothing) Then
                dtgAgencias.ClearSelection()
                dtgAgencias.Rows(e.RowIndex).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgAgencias_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAgencias.RowEnter
        Try
            If (dtgSIL.CurrentRow IsNot Nothing) Then
                dtgSIL.ClearSelection()
                dtgSIL.Rows(e.RowIndex).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgAgencias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAgencias.CellContentClick
        Try
            If (e.RowIndex < 0) Then Exit Sub
            If (e.ColumnIndex = 0) Then
                dtgAgencias.EndEdit()
                ValidarEntradaDatos(e.RowIndex)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgAgencias_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAgencias.CellContentDoubleClick
        Dim oListServicioDisponibles As New List(Of String)
        Dim NombreColumna As String = ""
        Dim COD_VAR As String = ""
        Dim VER_DETALLES As Boolean = False
        Try
            If (e.RowIndex < 0) Then Exit Sub
            If (e.ColumnIndex = 0) Then
                dtgAgencias.EndEdit()
                ValidarEntradaDatos(e.RowIndex)
            End If
            NombreColumna = dtgAgencias.Columns(e.ColumnIndex).Name
            If (NombreColumna = "VAL_AGENCIA" AndAlso dtgAgencias.Rows(e.RowIndex).Tag IsNot Nothing) Then
                COD_VAR = dtgAgencias.Rows(e.RowIndex).Tag.ToString.Split("_")(0)
                VER_DETALLES = dtgAgencias.Rows(e.RowIndex).Tag.ToString.Split("_")(1).EndsWith("DETALLE")
                If (VER_DETALLES = True) Then
                    Dim ofrmDetalleCostos As New frmDetalleCostos
                    ofrmDetalleCostos.pNORDSR = ogenDatosEmbarque_BE.PNPNNMOS
                    ofrmDetalleCostos.pListaCostoAgencias = ListarTodosCostosxCodVar(COD_VAR)
                    ofrmDetalleCostos.pCODVAR = COD_VAR
                    ofrmDetalleCostos.ShowDialog()
                    ActualizarSeleccionCostos(COD_VAR, ofrmDetalleCostos.pListaCostosSeleccionados)
                    'evaluar los costos seleccionables de traccion
                    EvaluarItemDeSeleccion("ITTRAC")
                    'dependiendo dependiendo de la seleccion de Gastos OPeratvivos
                    'dtgAgencias.Rows(15).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTCAG")
                    'dtgAgencias.Rows(16).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTGOA")
                    'dtgAgencias.Rows(17).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTRAC")

                    dtgAgencias.Rows(FilaConceptoAg("ITTCAG")).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTCAG")
                    dtgAgencias.Rows(FilaConceptoAg("ITTGOA")).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTGOA")
                    dtgAgencias.Rows(FilaConceptoAg("ITTRAC")).Cells("VAL_AGENCIA").Value = ObtenerMontoDolarFinalXVariableCosto("ITTRAC")


                    ValidarEntradaDatos(FilaConceptoAg("ITTCAG"))
                    ValidarEntradaDatos(FilaConceptoAg("ITTGOA"))
                    ValidarEntradaDatos(FilaConceptoAg("ITTRAC"))


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim count As Integer = 0
            If IsCheckImportar = True And dtgAgenciasDetalla.RowCount > 0 Then
                For Each Item As DataGridViewRow In dtgSILDetalle.Rows
                    If CDec(Item.Cells("IVUNIT").Value) = 0 Then
                        count = count + 1
                    End If
                Next
                If count > 0 Then
                    If MessageBox.Show(String.Format("Hay Valores Unitarios con valor = 0.00 {0} ¿Desea continuar?", Environment.NewLine), "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                        Exit Sub
                    End If
                End If
            End If

            ImportarAgencias()
            If IsCheckImportar = True And dtgAgenciasDetalla.RowCount > 0 Then
                Actualizar_Datos_Items_SIL()
                Procesar_Importacion_Datos_Item()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#Region "Importar Mercaderia "


    Private Sub Procesar_Importacion_Datos_Item()
        Dim oDetOC As New clsDetOC
        Dim NORCML As String = ""
        Dim SBITOC As String
        Dim NRITOC As Double = 0
        Dim CPTDAR As String = ""
        Dim NRPEMB As Decimal = 0
        Dim NFCTCM As String = ""
        Dim CCLNT As Decimal = 0
        Dim NSERIE As String = ""
        Dim NMITFC As Decimal = 0
        Dim NORSCI As Decimal = 0
        Dim BOLCOSTO As Boolean = False
        Dim VAL As Decimal = 0
        Dim CODVAR As String = ""
        Dim obeDistribucionCostos As beDistribucionCostoxItemOC
        Dim retorno As Int32 = 0
        Dim PNVALMRC As Decimal = 0

        NORSCI = oEmbarque.pNORSCI
        CCLNT = oEmbarque.pCCLNT


        For Fila As Integer = 0 To dtgSILDetalle.Rows.Count - 1
            BOLCOSTO = False
            NSERIE = ("" & dtgSILDetalle.Rows(Fila).Cells("COLNSERIE").Value).ToString.Trim
            '***ACTUALIZACION PARTIDAS Y FACURAS****************
            If IsNumeric(NSERIE) Then
                NORCML = dtgSILDetalle.Rows(Fila).Cells("ORCOM").Value.ToString.Trim
                NRITOC = dtgSILDetalle.Rows(Fila).Cells("ITEM").Value
                SBITOC = dtgSILDetalle.Rows(Fila).Cells("SBITOC").Value.ToString.Trim
                NRPEMB = dtgSILDetalle.Rows(Fila).Cells("NRPEMB").Value
                CPTDAR = dtgSILDetalle.Rows(Fila).Cells("CPTDAR").Value.ToString.Trim
                NFCTCM = dtgSILDetalle.Rows(Fila).Cells("NFCTCM").Value.ToString.Trim
                NMITFC = dtgSILDetalle.Rows(Fila).Cells("NMITFC_SIL").Value
                PNVALMRC = dtgSILDetalle.Rows(Fila).Cells("VALMRC_SIL").Value
                For COLUMNA As Int32 = 0 To dtgSILDetalle.Columns.Count - 1
                    BOLCOSTO = False
                    Select Case dtgSILDetalle.Columns.Item(COLUMNA).Name.Trim
                        Case "FOB"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("FOB").Value
                            CODVAR = "FOB"
                            BOLCOSTO = True
                        Case "FLETE"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("FLETE").Value
                            CODVAR = "FLETE"
                            BOLCOSTO = True
                        Case "SEGURO"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("SEGURO").Value
                            CODVAR = "SEGURO"
                            BOLCOSTO = True
                        Case "CIF"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("CIF").Value
                            CODVAR = "CIF"
                            BOLCOSTO = True
                        Case "ADVAL"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("ADVAL").Value
                            CODVAR = "ADVALO"
                            BOLCOSTO = True
                        Case "IGV"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("IGV").Value
                            CODVAR = "IGV"
                            BOLCOSTO = True
                        Case "IPM"
                            VAL = dtgSILDetalle.Rows(Fila).Cells("IPM").Value
                            CODVAR = "IPM"
                            BOLCOSTO = True

                           
                    End Select
                    If (BOLCOSTO = True) Then
                        If IsGroup = True Then
                            NSERIE = 0 ' EL NUMERO DE SERIE GENERADO NO SE ACTUALIZA
                        End If
                        obeDistribucionCostos = New beDistribucionCostoxItemOC
                        obeDistribucionCostos.PNNORSCI = NORSCI
                        obeDistribucionCostos.PNCCLNT = CCLNT
                        obeDistribucionCostos.PSNORCML = NORCML
                        obeDistribucionCostos.PNNRITEM = NRITOC
                        obeDistribucionCostos.PSSBITOC = SBITOC
                        obeDistribucionCostos.PNNRPEMB = NRPEMB
                        obeDistribucionCostos.PNNSERIE = NSERIE
                        obeDistribucionCostos.PNVAL = VAL
                        obeDistribucionCostos.PSCODVAR = CODVAR
                        obeDistribucionCostos.PNCMNDA1 = 100
                        obeDistribucionCostos.PSNMONOC = "USD"
                        obeDistribucionCostos.PNNMITFC = NMITFC
                        obeDistribucionCostos.PSPARTID = CPTDAR
                        obeDistribucionCostos.PSNFCTCM = NFCTCM
                        obeDistribucionCostos.PNVALMRC = PNVALMRC
                        retorno = oEmbarque.Importar_Oc_Embarcadas_Agencia_2(obeDistribucionCostos)
                    End If
                Next
            End If
        Next
    End Sub


    Private Function BuscarDatosAgencia(ByVal NSERIE As String) As beDUAA1
        Dim obeDUAA1 As New beDUAA1
        Dim existe As Boolean = False
        For Each Item As DataGridViewRow In dtgAgenciasDetalla.Rows
            If (Item.Cells("NSERIE").Value = NSERIE) Then
                obeDUAA1.PSPARTID = Item.Cells("PARTID").Value.ToString.Trim
                obeDUAA1.PSNMRFCT = Item.Cells("NMRFCT").Value.ToString.Trim

                obeDUAA1.PNVALFOB = Item.Cells("FOB_AGENCIA").Value
                obeDUAA1.PNVALFLT = Item.Cells("FLETE_AGENCIA").Value
                obeDUAA1.PNVALSEG = Item.Cells("SEGURO_AGENCIA").Value
                obeDUAA1.PNIMPCIF = Item.Cells("CIF_AGENCIA").Value
                obeDUAA1.PNVALADV = Item.Cells("ADVAL_AGENCIA").Value
                obeDUAA1.PNVALIGV = Item.Cells("IGV_AGENCIA").Value
                obeDUAA1.PNVALIPM = Item.Cells("IPM_AGENCIA").Value

                'obeDUAA1.PNVOTROSGASTOS = Item.Cells("OTSGAS").Value
                obeDUAA1.PNNMITFC = Item.Cells("NMITFC").Value
                obeDUAA1.PNVALMRC = Item.Cells("VALMRC").Value

                existe = True
                Exit For
            End If
        Next
        If existe = False Then
            obeDUAA1 = Nothing
        End If
        Return obeDUAA1
    End Function

    'Private Sub Actualizar_Datos_Items_SIL()
    '    Dim NORCML As String = ""
    '    Dim NRITOC As Decimal = 0
    '    Dim CPTDAR As String = ""
    '    Dim NSERIE As String = ""
    '    Dim obeDuaa1 As beDUAA1
    '    Dim NMRFCT As String = ""


    '    Dim dtAgencia As New DataTable
    '    'dtAgencia = dtgAgenciasDetalla.DataSource
    '    'dtAgencia = dtgSILDetalle.DataSource



    '    For Each Item As DataGridViewRow In dtgSILDetalle.Rows
    '        obeDuaa1 = New beDUAA1
    '        NSERIE = ("" & Item.Cells("COLNSERIE").Value).ToString.Trim
    '        If (IsNumeric(NSERIE)) Then
    '            obeDuaa1 = BuscarDatosAgencia(NSERIE)
    '            If obeDuaa1 IsNot Nothing Then
    '                NORCML = Item.Cells("ORCOM").Value.ToString.Trim
    '                NRITOC = Item.Cells("ITEM").Value
    '                CPTDAR = Item.Cells("CPTDAR").Value.ToString.Trim
    '                '***PARTIDAS*********************
    '                If (CPTDAR.Equals("")) Then
    '                    CPTDAR = obeDuaa1.PSPARTID
    '                    Item.Cells("CPTDAR").Value = Mid(CPTDAR, 1, 13)
    '                End If
    '                '***FACTURAS*********************
    '                NMRFCT = Item.Cells("NFCTCM").Value.ToString.Trim
    '                If (NMRFCT.Equals("")) Then
    '                    Item.Cells("NFCTCM").Value = obeDuaa1.PSNMRFCT
    '                End If
    '                '******COSTOS ITEM**************
    '                Item.Cells("FOB").Value = obeDuaa1.PNVALFOB
    '                Item.Cells("FLETE").Value = obeDuaa1.PNVALFLT
    '                Item.Cells("SEGURO").Value = obeDuaa1.PNVALSEG
    '                Item.Cells("CIF").Value = obeDuaa1.PNIMPCIF
    '                Item.Cells("ADVAL").Value = obeDuaa1.PNVALADV
    '                Item.Cells("IGV").Value = obeDuaa1.PNVALIGV
    '                Item.Cells("IPM").Value = obeDuaa1.PNVALIPM

    '                Item.Cells("NMITFC_SIL").Value = obeDuaa1.PNNMITFC
    '                Item.Cells("VALMRC_SIL").Value = obeDuaa1.PNVALMRC
    '            Else
    '                Item.Cells("COLNSERIE").Value = "0"
    '            End If
    '        End If
    '    Next
    'End Sub

    Private Sub Actualizar_Datos_Items_SIL()

        Dim NORCML As String = ""
        Dim NRITOC As Decimal = 0
        Dim CPTDAR As String = ""
        Dim NSERIE As String = ""
        Dim obeDuaa1 As beDUAA1
        Dim NMRFCT As String = ""
        Dim Count_NSerie As Integer = 0
        Dim dtAgencia As New DataTable

        Dim dtData As New DataTable
        Dim dr As DataRow
        Dim Serie_Temp As String = ""
        Dim List_Serie As New List(Of Int32)
        Dim SubTotal As Decimal = 0
        Dim Total_Compara As Decimal = 0
        Dim Resto As Decimal = 0
        Dim count As Integer = 0


        dtData.Columns.Add("SERIE", Type.GetType("System.Int32"))
        dtData.Columns.Add("CANTIDAD", Type.GetType("System.Decimal"))
        dtData.Columns.Add("SUBTOTAL", Type.GetType("System.Decimal"))

        For Each Item As DataGridViewRow In dtgSILDetalle.Rows

            dr = dtData.NewRow
            Serie_Temp = ("" & Item.Cells("COLNSERIE").Value).ToString.Trim
            If (IsNumeric(Serie_Temp)) Then
                dr("SERIE") = CInt(Item.Cells("COLNSERIE").Value)
                If Not List_Serie.Contains(CDec(Item.Cells("COLNSERIE").Value)) Then
                    List_Serie.Add(CDec(Item.Cells("COLNSERIE").Value))
                End If
                dr("CANTIDAD") = CDec(Item.Cells("QRLCSC").Value)
                dr("SUBTOTAL") = CDec(Item.Cells("IVUNIT").Value) * CDec(Item.Cells("QRLCSC").Value) * Item.Cells("QTPCM2").Value
                dtData.Rows.Add(dr)
            End If
        Next

        Dim dtSerie As New DataTable
        Dim drSerie As DataRow
        dtSerie.Columns.Add("SERIE", Type.GetType("System.Int32"))
        dtSerie.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        dtSerie.Columns.Add("COUNT", Type.GetType("System.Int32"))

        For Each n As Int32 In List_Serie
            Total_Compara = 0
            drSerie = dtSerie.NewRow
            drSerie("SERIE") = n
            drSerie("TOTAL") = dtData.Compute("Sum(SUBTOTAL)", "SERIE =" & n)
            drSerie("COUNT") = dtData.Compute("Count(SERIE)", "SERIE =" & n)
            dtSerie.Rows.Add(drSerie)
        Next

        For Each Item As DataGridViewRow In dtgSILDetalle.Rows
            SubTotal = 0
            obeDuaa1 = New beDUAA1
            NSERIE = ("" & Item.Cells("COLNSERIE").Value).ToString.Trim
            If (IsNumeric(NSERIE)) Then

                obeDuaa1 = BuscarDatosAgencia(NSERIE)

                If obeDuaa1 IsNot Nothing Then
                    NORCML = Item.Cells("ORCOM").Value.ToString.Trim
                    NRITOC = Item.Cells("ITEM").Value
                    CPTDAR = Item.Cells("CPTDAR").Value.ToString.Trim
                    '***PARTIDAS*********************
                    If (CPTDAR.Equals("")) Then
                        CPTDAR = obeDuaa1.PSPARTID
                        Item.Cells("CPTDAR").Value = Mid(CPTDAR, 1, 13)
                    End If
                    '***FACTURAS*********************
                    NMRFCT = ("" & Item.Cells("NFCTCM").Value).ToString.Trim
                    If (NMRFCT.Equals("")) Then
                        Item.Cells("NFCTCM").Value = obeDuaa1.PSNMRFCT
                        Item.Cells("NMITFC_SIL").Value = obeDuaa1.PNNMITFC
                    End If
                    '******COSTOS ITEM**************

                    Dim dr1 As DataRow()
                    dr1 = dtSerie.Select("SERIE=" & NSERIE)

                    If CInt(dr1(0).Item("COUNT")) = 1 Then
                        Item.Cells("FOB").Value = obeDuaa1.PNVALFOB
                        Item.Cells("FLETE").Value = obeDuaa1.PNVALFLT
                        Item.Cells("SEGURO").Value = obeDuaa1.PNVALSEG
                        Item.Cells("CIF").Value = obeDuaa1.PNIMPCIF
                        Item.Cells("ADVAL").Value = obeDuaa1.PNVALADV
                        Item.Cells("IGV").Value = obeDuaa1.PNVALIGV
                        Item.Cells("IPM").Value = obeDuaa1.PNVALIPM
                        Item.Cells("VALMRC_SIL").Value = obeDuaa1.PNVALMRC

                    Else
                        If CDec(dr1(0).Item("TOTAL")) = 0 Then

                            Item.Cells("FOB").Value = 0.0
                            Item.Cells("FLETE").Value = 0.0
                            Item.Cells("SEGURO").Value = 0.0
                            Item.Cells("CIF").Value = 0.0
                            Item.Cells("ADVAL").Value = 0.0
                            Item.Cells("IGV").Value = 0.0
                            Item.Cells("IPM").Value = 0.0
                            Item.Cells("VALMRC_SIL").Value = 0

                        Else
                            SubTotal = CDec(Item.Cells("QRLCSC").Value) * CDec(Item.Cells("IVUNIT").Value) * Item.Cells("QTPCM2").Value

                            Item.Cells("FOB").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALFOB) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("FLETE").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALFLT) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("SEGURO").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALSEG) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("CIF").Value = Decimal.Round((SubTotal * obeDuaa1.PNIMPCIF) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("ADVAL").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALADV) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("IGV").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALIGV) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("IPM").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALIPM) / CDec(dr1(0).Item("TOTAL")), 5)
                            Item.Cells("VALMRC_SIL").Value = Decimal.Round((SubTotal * obeDuaa1.PNVALMRC) / CDec(dr1(0).Item("TOTAL")), 2)
                        End If
                    End If
                    'Item.Cells("NMITFC_SIL").Value = obeDuaa1.PNNMITFC
                    'Item.Cells("VALMRC_SIL").Value = obeDuaa1.PNVALMRC
                Else
                    Item.Cells("COLNSERIE").Value = "0"
                End If
            End If
        Next

        Dim dtComparar As New DataTable
        Dim drCompara As DataRow

        dtComparar.Columns.Add("SERIE", Type.GetType("System.String"))
        dtComparar.Columns.Add("FOB", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("FLETE", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("SEGURO", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("CIF", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("ADVAL", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("IGV", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("IPM", Type.GetType("System.Decimal"))
        dtComparar.Columns.Add("VALMRC", Type.GetType("System.Decimal"))

        For Each Item As DataGridViewRow In dtgSILDetalle.Rows
            drCompara = dtComparar.NewRow
            drCompara("SERIE") = Item.Cells("COLNSERIE").Value
            drCompara("FOB") = CDec(Item.Cells("FOB").Value)
            drCompara("FLETE") = CDec(Item.Cells("FLETE").Value)
            drCompara("SEGURO") = CDec(Item.Cells("SEGURO").Value)
            drCompara("CIF") = CDec(Item.Cells("CIF").Value)
            drCompara("ADVAL") = CDec(Item.Cells("ADVAL").Value)
            drCompara("IGV") = CDec(Item.Cells("IGV").Value)
            drCompara("IPM") = CDec(Item.Cells("IPM").Value)
            drCompara("VALMRC") = CDec(Item.Cells("VALMRC_SIL").Value)
            dtComparar.Rows.Add(drCompara)
        Next

        Dim Actualizar As Boolean = False
        Dim cod As String = ""
        Dim ListSerieVisit As New List(Of String)
        For index As Integer = 0 To dtComparar.Rows.Count - 1
            cod = ""
            obeDuaa1 = New beDUAA1
            cod = dtComparar.Rows(index).Item("SERIE").ToString

            If (IsNumeric(cod)) Then
                obeDuaa1 = BuscarDatosAgencia(cod)

                If obeDuaa1 IsNot Nothing Then

                

                    If Not dtComparar.Compute("Sum(FOB)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALFOB Then
                        If dtComparar.Compute("Max(FOB)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("FOB").ToString Then
                            dtComparar.Rows(index).Item("FOB") = CDec(dtComparar.Rows(index).Item("FOB")) + CDec(obeDuaa1.PNVALFOB) - dtComparar.Compute("Sum(FOB)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(FLETE)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALFLT Then
                        If dtComparar.Compute("Max(FLETE)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("FLETE").ToString Then
                            dtComparar.Rows(index).Item("FLETE") = CDec(dtComparar.Rows(index).Item("FLETE")) + CDec(obeDuaa1.PNVALFLT) - dtComparar.Compute("Sum(FLETE)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(SEGURO)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALSEG Then
                        If dtComparar.Compute("Max(SEGURO)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("SEGURO").ToString Then
                            dtComparar.Rows(index).Item("SEGURO") = CDec(dtComparar.Rows(index).Item("SEGURO")) + CDec(obeDuaa1.PNVALSEG) - CDec(dtComparar.Compute("Sum(SEGURO)", "SERIE= '" & cod & "'"))
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(CIF)", "SERIE= '" & cod & "'") = obeDuaa1.PNIMPCIF Then
                        If dtComparar.Compute("Max(CIF)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("CIF").ToString Then
                            dtComparar.Rows(index).Item("CIF") = CDec(dtComparar.Rows(index).Item("CIF")) + CDec(obeDuaa1.PNIMPCIF) - dtComparar.Compute("Sum(CIF)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(ADVAL)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALADV Then
                        If dtComparar.Compute("Max(ADVAL)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("ADVAL").ToString Then
                            dtComparar.Rows(index).Item("ADVAL") = CDec(dtComparar.Rows(index).Item("ADVAL")) + CDec(obeDuaa1.PNVALADV) - dtComparar.Compute("Sum(ADVAL)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(IGV)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALIGV Then
                        If dtComparar.Compute("Max(IGV)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("IGV").ToString Then
                            dtComparar.Rows(index).Item("IGV") = CDec(dtComparar.Rows(index).Item("IGV")) + CDec(obeDuaa1.PNVALIGV) - dtComparar.Compute("Sum(IGV)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(IPM)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALIPM Then
                        If dtComparar.Compute("Max(IPM)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("IPM").ToString Then
                            dtComparar.Rows(index).Item("IPM") = CDec(dtComparar.Rows(index).Item("IPM")) + CDec(obeDuaa1.PNVALIPM) - dtComparar.Compute("Sum(IPM)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    If Not dtComparar.Compute("Sum(VALMRC)", "SERIE= '" & cod & "'") = obeDuaa1.PNVALMRC Then
                        If dtComparar.Compute("Max(VALMRC)", "SERIE= '" & cod & "'") = dtComparar.Rows(index).Item("VALMRC").ToString Then
                            dtComparar.Rows(index).Item("VALMRC") = CDec(dtComparar.Rows(index).Item("VALMRC")) + CDec(obeDuaa1.PNVALMRC) - dtComparar.Compute("Sum(VALMRC)", "SERIE= '" & cod & "'")
                            Actualizar = True
                        End If
                    End If

                    

                End If
            End If
        Next

        If Actualizar = True Then
            For index As Integer = 0 To dtComparar.Rows.Count - 1
                dtgSILDetalle.Rows(index).Cells("FOB").Value = dtComparar.Rows(index).Item("FOB")
                dtgSILDetalle.Rows(index).Cells("FLETE").Value = dtComparar.Rows(index).Item("FLETE")
                dtgSILDetalle.Rows(index).Cells("SEGURO").Value = dtComparar.Rows(index).Item("SEGURO")
                dtgSILDetalle.Rows(index).Cells("ADVAL").Value = dtComparar.Rows(index).Item("ADVAL")
                dtgSILDetalle.Rows(index).Cells("IGV").Value = dtComparar.Rows(index).Item("IGV")
                dtgSILDetalle.Rows(index).Cells("IPM").Value = dtComparar.Rows(index).Item("IPM")
                dtgSILDetalle.Rows(index).Cells("VALMRC_SIL").Value = dtComparar.Rows(index).Item("VALMRC")
            Next
        End If

    End Sub



#End Region

    Private Sub btnUpdateItemAgen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateItemAgen.Click
        Try
            EsParaAgrupar(False)
            oEmbarque.Importar_Partidas_ASCINSA(oEmbarque.pCCLNT, oEmbarque.pPNNMOS)
            Cargar_Tabla_Agencia_Detalle()
            dtgAgenciasDetalla.ClearSelection()
            dtgSILDetalle.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Event_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If HelpUtil.SoloNumerosSinComa(CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgSILDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgSILDetalle.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim colName As String = ""
            colName = dtgSILDetalle.Columns(dtgSILDetalle.CurrentCell.ColumnIndex).Name
            If colName = "COLNSERIE" Then
                Texto = CType(e.Control, TextBox)
                Texto.Text = Texto.Text.Trim
                Texto.MaxLength = 4
                AddHandler Texto.KeyPress, AddressOf Event_KeyPress
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnOCItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOCItem.Click
        Try
            Dim valor As String = ""
            Dim oListOrdenesItems As New Hashtable
            Dim NORCML As String = ""
            Dim NRITOC As String = ""
            For Each Item As DataGridViewRow In dtgAgenciasDetalla.Rows
                NORCML = Item.Cells("ORDSER").Value.ToString.Trim
                NRITOC = Item.Cells("ITEM_AGENCIA").Value.ToString
                If (NORCML.Length > 0 AndAlso Convert.ToDecimal(NRITOC) > 0) Then
                    valor = NORCML & "-" & NRITOC
                    If (valor.Length > 0) Then
                        If (Not oListOrdenesItems.Contains(valor)) Then
                            oListOrdenesItems.Add(valor, Item.Cells("NSERIE").Value.ToString.Trim)
                        End If
                    End If
                End If
            Next
            Dim nserie As String = ""
            Dim NORCMLNRITOC As String = ""
            For Each Item As DataGridViewRow In dtgSILDetalle.Rows
                Item.Cells("COLNSERIE").Style.ForeColor = Color.Black
                nserie = ("" & Item.Cells("COLNSERIE").Value).ToString.Trim
                NORCMLNRITOC = Item.Cells("ORCOM").Value.ToString.Trim & "-" & Item.Cells("ITEM").Value.ToString
                If (nserie.Length = 0) Then
                    If (oListOrdenesItems.Contains(NORCMLNRITOC)) Then
                        Item.Cells("COLNSERIE").Style.ForeColor = Color.Red
                        Item.Cells("COLNSERIE").Value = oListOrdenesItems(NORCMLNRITOC)
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub chkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim chk As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        chk = CType(sender, ComponentFactory.Krypton.Toolkit.KryptonCheckBox)
        IsCheckImportar = chk.Checked
    End Sub


    Private Function SumarizarXOCItem(ByVal oListItem As List(Of beDUAA1), ByVal NORCML_NRITOC As String) As beDUAA1
        Dim obeItemAgrupado As New beDUAA1
        'FueEncontrado : 0 --> antes de que sea encontrado por primera vez
        'FueEncontrado > 0 --> despues de haber sido encontrado
        Dim FueEncontrado As Int32 = 0
        Dim ALL_FACTURA As Boolean = True
        Dim ALL_PARTIDA As Boolean = True
        Dim PRIMERA_FAC As String = ""
        Dim PRIMERA_PARTIDA As String = ""
        Dim NORCML_ITEM As String = ""
        Dim oCloneObject As New CloneObject(Of beDUAA1)
        For Each Item As beDUAA1 In oListItem
            NORCML_ITEM = Item.PSNMRODC & "_" & Item.PNNMITOC
            If NORCML_ITEM = NORCML_NRITOC Then
                If FueEncontrado = 0 Then
                    obeItemAgrupado = oCloneObject.CloneObject(Item)
                    PRIMERA_FAC = obeItemAgrupado.PSNMRFCT
                Else
                    If obeItemAgrupado.PSNMRFCT <> PRIMERA_FAC Then
                        ALL_FACTURA = False
                        'VERIFICANDO SI TODOS LOS ITEMS TIENEN LA MISMA FACTURA
                    End If
                    If obeItemAgrupado.PSPARTID <> PRIMERA_PARTIDA Then
                        'VERIFICANDO SI TODOS LOS ITEMS TIENEN LA MISMA PARTIDA
                        ALL_PARTIDA = False
                    End If
                    obeItemAgrupado.PNVALMRC = obeItemAgrupado.PNVALMRC + Item.PNVALMRC
                    obeItemAgrupado.PNVALFOB = obeItemAgrupado.PNVALFOB + Item.PNVALFOB
                    obeItemAgrupado.PNVALFLT = obeItemAgrupado.PNVALFLT + Item.PNVALFLT
                    obeItemAgrupado.PNVALSEG = obeItemAgrupado.PNVALSEG + Item.PNVALSEG
                    obeItemAgrupado.PNIMPCIF = obeItemAgrupado.PNIMPCIF + Item.PNIMPCIF
                    obeItemAgrupado.PNVALADV = obeItemAgrupado.PNVALADV + Item.PNVALADV
                    obeItemAgrupado.PNVALIGV = obeItemAgrupado.PNVALIGV + Item.PNVALIGV
                    obeItemAgrupado.PNVALIPM = obeItemAgrupado.PNVALIPM + Item.PNVALIPM
                    obeItemAgrupado.PNVALGAS = obeItemAgrupado.PNVALGAS + Item.PNVALGAS
                    obeItemAgrupado.PNVALSBT = obeItemAgrupado.PNVALSBT + Item.PNVALSBT
                    obeItemAgrupado.PNVALDES = obeItemAgrupado.PNVALDES + Item.PNVALDES
                    obeItemAgrupado.PNVALISC = obeItemAgrupado.PNVALISC + Item.PNVALISC
                    obeItemAgrupado.PNVALADP = obeItemAgrupado.PNVALADP + Item.PNVALADP
                    obeItemAgrupado.PNVALICP = obeItemAgrupado.PNVALICP + Item.PNVALICP
                    obeItemAgrupado.PNVALMOR = obeItemAgrupado.PNVALMOR + Item.PNVALMOR
                    obeItemAgrupado.PNVALRNP = obeItemAgrupado.PNVALRNP + Item.PNVALRNP
                    obeItemAgrupado.PNVOTROSGASTOS = obeItemAgrupado.PNVOTROSGASTOS + Item.PNVOTROSGASTOS
                End If
                FueEncontrado = FueEncontrado + 1
            End If
        Next
        If FueEncontrado > 0 Then ' SI EL DATO FUE ENCONTRADO POR LO MENOS UNA VEZ

            obeItemAgrupado.PSPARTID = Nro_Partida(oListItem, NORCML_NRITOC)
            'If ALL_PARTIDA = True Then ' SI TODAS LAS PARTIDAS SON IGUALES

            '    obeItemAgrupado.PSPARTID = PRIMERA_PARTIDA
            'Else
            '    obeItemAgrupado.PSPARTID = ""
            'End If
            If ALL_FACTURA = True Then ' SI TODAS LAS FACTURAS SON IGUALES
                obeItemAgrupado.PSNMRFCT = PRIMERA_FAC
            Else
                obeItemAgrupado.PSNMRFCT = ""
            End If
            obeItemAgrupado.PNNMITFC = 0
        End If

        Return obeItemAgrupado
    End Function

    Private Function Nro_Partida(ByVal oListItem As List(Of beDUAA1), ByVal NORCML_NRITOC As String) As String
        Dim Partida As New List(Of String)
        Dim Resultado As String = ""
        For Each Item As beDUAA1 In oListItem
            If NORCML_NRITOC = Item.PSNMRODC & "_" & Item.PNNMITOC Then
                If Not Partida.Contains(Item.PSPARTID) Then
                    Partida.Add(Item.PSPARTID)
                End If
            End If
        Next
        If Partida.Count = 1 Then
            Resultado = Partida(0).ToString
        Else
            Resultado = ""
        End If
        Return Resultado
    End Function


    Private Sub btnAgruparOCItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparOCItem.Click
        Try
            EsParaAgrupar(True)
            Dim oCloneObject As New CloneObject(Of beDUAA1)
            Dim oListDataSource As New List(Of beDUAA1)
            oListDataSource = dtgAgenciasDetalla.DataSource
            Dim oListTemp As New List(Of beDUAA1)
            oListTemp = oCloneObject.CloneListObject(oListDataSource)
            Dim oListAgrupado As New List(Of beDUAA1)
            Dim obeAgrupado As beDUAA1
            Dim NORCML_NRITOC As String = ""
            Dim NRITOC As Decimal = 0
            Dim NORCML As String = ""
            Dim oListOC As New List(Of String)
            For Each Item As beDUAA1 In oListTemp
                NORCML = Item.PSNMRODC.Trim
                NRITOC = Item.PNNMITOC
                NORCML_NRITOC = NORCML & "_" & NRITOC
                If Not oListOC.Contains(NORCML_NRITOC) Then
                    oListOC.Add(NORCML_NRITOC)
                    obeAgrupado = New beDUAA1
                    obeAgrupado = SumarizarXOCItem(oListTemp, NORCML_NRITOC)
                    oListAgrupado.Add(obeAgrupado)
                End If
            Next
            Dim Correlativo As Int32 = 1
            For Each Item As beDUAA1 In oListAgrupado
                Item.PNNSERIE = Correlativo
                Correlativo = Correlativo + 1
            Next
            dtgAgenciasDetalla.DataSource = Nothing
            dtgAgenciasDetalla.DataSource = oListAgrupado

            'btnListarOriginal.Visible = True
            'btnAgruparOCItem.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub dtgAgenciasDetalla_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgAgenciasDetalla.ColumnHeaderMouseClick
        Try
            Dim selectedColumn As DataGridViewColumn
            Dim NameColumn As String = ""
            Dim oListItemAgencia As New List(Of beDUAA1)
            selectedColumn = dtgAgenciasDetalla.Columns(e.ColumnIndex)
            oListItemAgencia = dtgAgenciasDetalla.DataSource
            NameColumn = selectedColumn.DataPropertyName
            If NameColumn.Length > 0 Then
                If selectedColumn.HeaderCell.Tag Is Nothing Then
                    dtgAgenciasDetalla.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
                    dtgAgenciasDetalla.Columns(e.ColumnIndex).HeaderCell.Tag = SortOrder.Ascending
                End If
                Dim oucOrdena As ucOrdenaS(Of beDUAA1)
                Dim Orden As ucOrdenaS(Of beDUAA1).TiposOrden
                If selectedColumn.HeaderCell.Tag = SortOrder.Ascending Then
                    dtgAgenciasDetalla.Columns(e.ColumnIndex).HeaderCell.Tag = SortOrder.Descending
                    Orden = ucOrdenaS(Of Global.SOLMIN_SC.Entidad.beDUAA1).TiposOrden.Ascendente
                Else
                    dtgAgenciasDetalla.Columns(e.ColumnIndex).HeaderCell.Tag = SortOrder.Ascending
                    Orden = ucOrdenaS(Of Global.SOLMIN_SC.Entidad.beDUAA1).TiposOrden.Descendente
                End If
                oucOrdena = New ucOrdenaS(Of beDUAA1)(NameColumn, Orden, False)
                oListItemAgencia.Sort(oucOrdena)
                dtgAgenciasDetalla.DataSource = Nothing
                dtgAgenciasDetalla.DataSource = oListItemAgencia
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub EsParaAgrupar(ByVal Agrupar As Boolean)
        If Agrupar = True Then
            If dtgSILDetalle.Columns("COLNSERIE") IsNot Nothing Then
                dtgSILDetalle.Columns("COLNSERIE").HeaderText = "Correlativo"
            End If
            If dtgAgenciasDetalla.Columns("NSERIE") IsNot Nothing Then
                dtgAgenciasDetalla.Columns("NSERIE").HeaderText = "Correlativo"
            End If
            IsGroup = True
        ElseIf Agrupar = False Then
            If dtgSILDetalle.Columns("COLNSERIE") IsNot Nothing Then
                dtgSILDetalle.Columns("COLNSERIE").HeaderText = "Nro Serie"
            End If
            If dtgAgenciasDetalla.Columns("NSERIE") IsNot Nothing Then
                dtgAgenciasDetalla.Columns("NSERIE").HeaderText = "Nro Serie"
            End If
            IsGroup = False
        End If
    End Sub

    Private Sub btnListarOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarOriginal.Click
        Try
            EsParaAgrupar(False)
            dtgAgenciasDetalla.DataSource = Nothing

            Dim oListbeDUAATemp As New List(Of beDUAA1)
            Dim oCloneList As New CloneObject(Of beDUAA1)
            oListbeDUAATemp = oCloneList.CloneListObject(oListItemAgenciaOrigen)

            dtgAgenciasDetalla.DataSource = oListbeDUAATemp

            'btnListarOriginal.Visible = False
            'btnAgruparOCItem.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try     
    End Sub

    Private Sub dtgAgenciasDetalla_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgAgenciasDetalla.EditingControlShowing
        Try
            Dim Texto As New TextBox
            Dim colName As String = ""
            colName = dtgAgenciasDetalla.Columns(dtgAgenciasDetalla.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "ORDSER"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 35
                Case "ITEM_AGENCIA"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 6
                    AddHandler Texto.KeyPress, AddressOf Event_KeyPress
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub dtgSILDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgSILDetalle.EditingControlShowing
    '    Try
    '        Dim Texto As New TextBox
    '        Dim colName As String = ""
    '        colName = dtgSILDetalle.Columns(dtgSILDetalle.CurrentCell.ColumnIndex).Name
    '        If colName = "COLNSERIE" Then
    '            Texto = CType(e.Control, TextBox)
    '            Texto.Text = Texto.Text.Trim
    '            Texto.MaxLength = 4
    '            AddHandler Texto.KeyPress, AddressOf Event_KeyPress
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
End Class
