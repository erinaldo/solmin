Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsResumenEjecutivoSIL
    '''SIL
    Public Enum TIPO_DATO
        'REGIMEN = 3
        DOCUMENTO_ADJUNTO = 5
        TRASNPORTE_AGENCIA = 7
        TIPO_DESPACHO = 8
        TIPO_CARGA = 9
        ALMACEN_DESTINO_LOCAL = 28
    End Enum

    Enum MEDIO_TRANSPORTE
        AEREO = 1
        MARITIMO = 2
        POSTAL = 3
        TERRESTRE = 4
        FLUVIAL = 5
    End Enum
    Enum TIPO_DESPACHO
        NORMAL = 1
        ANTICIPADO = 2
        URGENTE = 3
        MUYURGENTE = 4
    End Enum

    Private _dtRegimen As New DataTable
    Private _dtDespacho As New DataTable
    Private _dtCostos As New DataTable
    Private _dtCanal As New DataTable
    Private _dtMedioTransporte As New DataTable
    Private _dtContenedor As New DataTable
    Private _dtTiempoPromedio As New DataTable
    'Agrupacion Por regimen
    Private _dtCostosXRegimen As New DataTable
    Private _dtEmbarqueXRegimen As New DataTable
    Private _dtCanalXRegimen As New DataTable
    Private _dtTiempoPromedioXRegimen As New DataTable
    Private _dtDespachoXRegimen As New DataTable
    Private _dtContenedorXRegimen As New DataTable
    Private _dtContenedorXLineNaviera As New DataTable
    Private _dtOrdenServicio As New DataTable
    Private _Vencimiento_CartaFianzaXVencerMes As Int32 = 0
    Private _Vencimiento_RegimenXVencerMes As Int32 = 0
    Private _TotalEmbarque As Int32 = 0

    Public Property dtRegimen() As DataTable
        Get
            Return _dtRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtRegimen = value
        End Set
    End Property
    Public Property dtDespacho() As DataTable
        Get
            Return _dtDespacho
        End Get
        Set(ByVal value As DataTable)
            _dtDespacho = value
        End Set
    End Property
    Public Property dtCostos() As DataTable
        Get
            Return _dtCostos
        End Get
        Set(ByVal value As DataTable)
            _dtCostos = value
        End Set
    End Property

    Public Property dtCanal() As DataTable
        Get
            Return _dtCanal
        End Get
        Set(ByVal value As DataTable)
            _dtCanal = value
        End Set
    End Property

    Public Property dtMedioTransporte() As DataTable
        Get
            Return _dtMedioTransporte
        End Get
        Set(ByVal value As DataTable)
            _dtMedioTransporte = value
        End Set
    End Property

    Public Property dtContenedor() As DataTable
        Get
            Return _dtContenedor
        End Get
        Set(ByVal value As DataTable)
            _dtContenedor = value
        End Set
    End Property

    Public Property Vencimiento_CartaFianzaXVencerMes() As Int32
        Get
            Return _Vencimiento_CartaFianzaXVencerMes
        End Get
        Set(ByVal value As Int32)
            _Vencimiento_CartaFianzaXVencerMes = value
        End Set
    End Property
    Public Property Vencimiento_RegimenXVencerMes() As Int32
        Get
            Return _Vencimiento_RegimenXVencerMes
        End Get
        Set(ByVal value As Int32)
            _Vencimiento_RegimenXVencerMes = value
        End Set
    End Property

    Public Property TotalEmbarque() As Int32
        Get
            Return _TotalEmbarque
        End Get
        Set(ByVal value As Int32)
            _TotalEmbarque = value
        End Set
    End Property

    Public Property dtTiempoPromedio() As DataTable
        Get
            Return _dtTiempoPromedio
        End Get
        Set(ByVal value As DataTable)
            _dtTiempoPromedio = value
        End Set
    End Property

  

    '///Tables De Agrupaciones Por Regimen
    Public Property dtCostosXRegimen() As DataTable
        Get
            Return _dtCostosXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtCostosXRegimen = value
        End Set
    End Property

    Public Property dtEmbarqueXRegimen() As DataTable
        Get
            Return _dtEmbarqueXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtEmbarqueXRegimen = value
        End Set
    End Property


    Public Property dtCanalXRegimen() As DataTable
        Get
            Return _dtCanalXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtCanalXRegimen = value
        End Set
    End Property

    Public Property dtTiempoPromedioXRegimen() As DataTable
        Get
            Return _dtTiempoPromedioXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtTiempoPromedioXRegimen = value
        End Set
    End Property

    Public Property dtDespachoXRegimen() As DataTable
        Get
            Return _dtDespachoXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtDespachoXRegimen = value
        End Set
    End Property

    Public Property dtContenedorXRegimen() As DataTable
        Get
            Return _dtContenedorXRegimen
        End Get
        Set(ByVal value As DataTable)
            _dtContenedorXRegimen = value
        End Set
    End Property
    Public Property dtContenedorXLineNaviera() As DataTable
        Get
            Return _dtContenedorXLineNaviera
        End Get
        Set(ByVal value As DataTable)
            _dtContenedorXLineNaviera = value
        End Set
    End Property


    Public Property dtOrdenServicio() As DataTable
        Get
            Return _dtOrdenServicio
        End Get
        Set(ByVal value As DataTable)
            _dtOrdenServicio = value
        End Set
    End Property



    Sub New()
        Dim odtDato As New DataTable
        odtDato = Lista_TipoDatos()
        Dim daRegimen As New clsRegimen
        Dim oListRegimen As New List(Of beRegimen)
        oListRegimen = daRegimen.ListarRegimen
        'Dim dr() As DataRow

        '******REGIMEN****************************
        _dtRegimen.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtRegimen.Columns.Add("REGIMEN", Type.GetType("System.String"))
        _dtRegimen.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        _dtRegimen.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        'Dim drRG() As DataRow
        'dr = odtDato.Select("NTPODT='" & TIPO_DATO.REGIMEN & "'")
        Dim drRegimen As DataRow
        For Each Item As beRegimen In oListRegimen
            drRegimen = _dtRegimen.NewRow
            drRegimen("CODIGO") = Item.PNTPORGE
            drRegimen("REGIMEN") = Item.PSTCMRGA
            drRegimen("CANTIDAD") = 0
            drRegimen("EMBARQUE") = ""
            _dtRegimen.Rows.Add(drRegimen)
        Next
        drRegimen = _dtRegimen.NewRow
        drRegimen("CODIGO") = 0
        drRegimen("REGIMEN") = "NO DEFINIDO"
        drRegimen("CANTIDAD") = 0
        drRegimen("EMBARQUE") = ""
        _dtRegimen.Rows.Add(drRegimen)

        '******CONTENEDOR****************************
        _dtContenedor.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtContenedor.Columns.Add("CONTENEDOR", Type.GetType("System.String"))
        _dtContenedor.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        _dtContenedor.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        _dtContenedor.Columns.Add("ES_CONTENEDOR", Type.GetType("System.String"))
        Dim drCT() As DataRow
        drCT = odtDato.Select("NTPODT='" & TIPO_DATO.TIPO_CARGA & "'")
        Dim drContenedor As DataRow
        For Each Item As DataRow In drCT
            drContenedor = _dtContenedor.NewRow
            drContenedor("CODIGO") = Item("NCODRG")
            drContenedor("CONTENEDOR") = ("" & Item("TDSCRG")).ToString.Trim
            drContenedor("CANTIDAD") = 0
            drContenedor("EMBARQUE") = ""
            Select Case Item("NCODRG").ToString
                'Tipo de Carga: Contenedores
                Case "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "16"
                    drContenedor("ES_CONTENEDOR") = "S"
                Case Else
                    drContenedor("ES_CONTENEDOR") = "N"
            End Select
            _dtContenedor.Rows.Add(drContenedor)
        Next
        drContenedor = _dtContenedor.NewRow
        drContenedor("CODIGO") = 0
        drContenedor("CONTENEDOR") = "NO DEFINIDO"
        drContenedor("CANTIDAD") = 0
        drContenedor("EMBARQUE") = ""
        drContenedor("ES_CONTENEDOR") = "N"
        _dtContenedor.Rows.Add(drContenedor)

        '******DESPACHO****************************
        _dtDespacho.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtDespacho.Columns.Add("DESPACHO", Type.GetType("System.String"))
        _dtDespacho.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        _dtDespacho.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        Dim drDespacho As DataRow
        Dim drTD() As DataRow
        drTD = odtDato.Select("NTPODT='" & TIPO_DATO.TIPO_DESPACHO & "'")
        For Each Item As DataRow In drTD
            drDespacho = _dtDespacho.NewRow
            drDespacho("CODIGO") = Item("NCODRG")
            drDespacho("DESPACHO") = ("" & Item("TDSCRG")).ToString.Trim
            drDespacho("CANTIDAD") = 0
            drDespacho("EMBARQUE") = ""
            _dtDespacho.Rows.Add(drDespacho)
        Next
        drDespacho = _dtDespacho.NewRow
        drDespacho("CODIGO") = 0
        drDespacho("DESPACHO") = "NO DEFINIDO"
        drDespacho("CANTIDAD") = 0
        drDespacho("EMBARQUE") = ""
        _dtDespacho.Rows.Add(drDespacho)

        '******COSTOS****************************
        Dim drCosto As DataRow

        _dtCostos.Columns.Add("EXW", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("GFOB", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("FOB", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("FLETE", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("SEGURO", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("CIF", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("ADVALO", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("OTSGAS", Type.GetType("System.Decimal")) 'OTROS GASTOS
        _dtCostos.Columns.Add("IGV", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("IPM", Type.GetType("System.Decimal"))
        _dtCostos.Columns.Add("TOLDER", Type.GetType("System.Decimal")) 'TOTAL DERECHOS
        _dtCostos.Columns.Add("ITTCAG", Type.GetType("System.Decimal")) 'COMISION AGENCIAMIENTO
        _dtCostos.Columns.Add("ITTGOA", Type.GetType("System.Decimal")) 'GASTOS OPERATIVOS
        drCosto = _dtCostos.NewRow
        Dim NameCol As String = ""
        For Columna As Integer = 0 To _dtCostos.Columns.Count - 1
            NameCol = _dtCostos.Columns(Columna).ColumnName
            drCosto(NameCol) = 0
        Next
        _dtCostos.Rows.Add(drCosto)


        '******CANAL****************************
        _dtCanal.Columns.Add("CODIGO", Type.GetType("System.String"))
        _dtCanal.Columns.Add("CANAL", Type.GetType("System.String"))
        _dtCanal.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        _dtCanal.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        Dim drCanal As DataRow

        drCanal = _dtCanal.NewRow
        drCanal("CODIGO") = "NARANJA"
        drCanal("CANAL") = "NARANJA"
        drCanal("CANTIDAD") = 0
        drCanal("EMBARQUE") = ""
        _dtCanal.Rows.Add(drCanal)

        drCanal = _dtCanal.NewRow
        drCanal("CODIGO") = "ROJO"
        drCanal("CANAL") = "ROJO"
        drCanal("CANTIDAD") = 0
        drCanal("EMBARQUE") = ""
        _dtCanal.Rows.Add(drCanal)

        drCanal = _dtCanal.NewRow
        drCanal("CODIGO") = "VERDE"
        drCanal("CANAL") = "VERDE"
        drCanal("CANTIDAD") = 0
        drCanal("EMBARQUE") = ""
        _dtCanal.Rows.Add(drCanal)

        drCanal = _dtCanal.NewRow
        drCanal("CODIGO") = ""
        drCanal("CANAL") = "NO DEFINIDO"
        drCanal("CANTIDAD") = 0
        drCanal("EMBARQUE") = ""
        _dtCanal.Rows.Add(drCanal)


        '******MEDIO TRANSPORTE****************************
        _dtMedioTransporte.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtMedioTransporte.Columns.Add("TRANSPORTE", Type.GetType("System.String"))
        _dtMedioTransporte.Columns.Add("CANTIDAD", Type.GetType("System.Int32"))
        _dtMedioTransporte.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        Dim odtMedioTransporte As New DataTable
        odtMedioTransporte = Lista_MedioTransporte()
        Dim drMT As DataRow
        For Each Item As DataRow In odtMedioTransporte.Rows
            drMT = _dtMedioTransporte.NewRow
            drMT("CODIGO") = Item("CMEDTR")
            drMT("TRANSPORTE") = ("" & Item("TNMMDT")).ToString.Trim
            drMT("CANTIDAD") = 0
            drMT("EMBARQUE") = ""
            _dtMedioTransporte.Rows.Add(drMT)
        Next

        drMT = _dtMedioTransporte.NewRow
        drMT("CODIGO") = 0
        drMT("TRANSPORTE") = "NO DEFINIDO"
        drMT("CANTIDAD") = 0
        drMT("EMBARQUE") = ""
        _dtMedioTransporte.Rows.Add(drMT)

        '******TIEMPO PROMEDIO X MEDIO TRANSPORTE****************************
        _dtTiempoPromedio.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtTiempoPromedio.Columns.Add("TRANSPORTE", Type.GetType("System.String"))
        _dtTiempoPromedio.Columns.Add("TOTAL_MEDIO_EFECTIVO", Type.GetType("System.String"))
        _dtTiempoPromedio.Columns.Add("TOTAL_DIAS", Type.GetType("System.Int32"))
        _dtTiempoPromedio.Columns.Add("PROMEDIO", Type.GetType("System.Decimal"))
        _dtTiempoPromedio.Columns.Add("EMBARQUE_SIN_ETA", Type.GetType("System.String"))
        _dtTiempoPromedio.Columns.Add("EMBARQUE_SIN_LEVANTE", Type.GetType("System.String"))
        _dtTiempoPromedio.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        Dim drTPromXTransporte As DataRow
        For Each Item As DataRow In odtMedioTransporte.Rows
            drTPromXTransporte = _dtTiempoPromedio.NewRow
            drTPromXTransporte("CODIGO") = Item("CMEDTR")
            drTPromXTransporte("TRANSPORTE") = ("" & Item("TNMMDT")).ToString.Trim
            drTPromXTransporte("TOTAL_DIAS") = 0
            drTPromXTransporte("PROMEDIO") = 0
            drTPromXTransporte("TOTAL_MEDIO_EFECTIVO") = 0
            drTPromXTransporte("EMBARQUE_SIN_ETA") = ""
            drTPromXTransporte("EMBARQUE_SIN_LEVANTE") = ""
            _dtTiempoPromedio.Rows.Add(drTPromXTransporte)
        Next
        drTPromXTransporte = _dtTiempoPromedio.NewRow
        drTPromXTransporte("CODIGO") = 0
        drTPromXTransporte("TRANSPORTE") = "NO DEFINIDO"
        drTPromXTransporte("TOTAL_DIAS") = 0
        drTPromXTransporte("PROMEDIO") = 0
        drTPromXTransporte("TOTAL_MEDIO_EFECTIVO") = 0
        drTPromXTransporte("EMBARQUE_SIN_ETA") = ""
        drTPromXTransporte("EMBARQUE_SIN_LEVANTE") = ""
        _dtTiempoPromedio.Rows.Add(drTPromXTransporte)



       
        '************************COSTOS X REGIMEN****************************
        _dtCostosXRegimen.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtCostosXRegimen.Columns.Add("REGIMEN", Type.GetType("System.String"))
        _dtCostosXRegimen.Columns.Add("EXW_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("GFOB_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("FOB_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("FLETE_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("SEGURO_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("CIF_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("ADVALO_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("OTSGAS_COSTO", Type.GetType("System.Decimal")) 'OTROS GASTOS
        _dtCostosXRegimen.Columns.Add("IGV_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("IPM_COSTO", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("TOLDER_COSTO", Type.GetType("System.Decimal")) 'TOTAL DERECHOS
        _dtCostosXRegimen.Columns.Add("ITTCAG_COSTO", Type.GetType("System.Decimal")) 'COMISION AGENCIAMIENTO
        _dtCostosXRegimen.Columns.Add("ITTGOA_COSTO", Type.GetType("System.Decimal")) 'GASTOS OPERATIVOS
        _dtCostosXRegimen.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        _dtCostosXRegimen.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        'dr = odtDato.Select("NTPODT='" & TIPO_DATO.REGIMEN & "'")
        Dim drCostoRegimen As DataRow
        Dim ColName As String = ""
        For Each Item As beRegimen In oListRegimen
            drCostoRegimen = _dtCostosXRegimen.NewRow
            drCostoRegimen("CODIGO") = Item.PNTPORGE
            drCostoRegimen("REGIMEN") = Item.PSTCMRGA
            For Each dc As DataColumn In _dtCostosXRegimen.Columns
                ColName = dc.ColumnName.Trim
                If ColName.EndsWith("_COSTO") Then
                    drCostoRegimen(ColName) = 0
                End If
            Next
            drCostoRegimen("EMBARQUE") = ""
            drCostoRegimen("TOTAL") = 0
            _dtCostosXRegimen.Rows.Add(drCostoRegimen)
        Next
        drCostoRegimen = _dtCostosXRegimen.NewRow
        drCostoRegimen("CODIGO") = 0
        drCostoRegimen("REGIMEN") = "NO DEFINIDO"
        drCostoRegimen("EMBARQUE") = ""
        For Each dc As DataColumn In _dtCostosXRegimen.Columns
            ColName = dc.ColumnName.Trim
            If ColName.EndsWith("_COSTO") Then
                drCostoRegimen(ColName) = 0
            End If
        Next
        _dtCostosXRegimen.Rows.Add(drCostoRegimen)

        '***************** TIEMPO PROMEDIO X REGIMEN ********************************
        _dtTiempoPromedioXRegimen.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        _dtTiempoPromedioXRegimen.Columns.Add("REGIMEN", Type.GetType("System.String"))
        _dtTiempoPromedioXRegimen.Columns.Add("CODIGO_TRANSPORTE", Type.GetType("System.Int32"))
        _dtTiempoPromedioXRegimen.Columns.Add("TRANSPORTE", Type.GetType("System.String"))
        _dtTiempoPromedioXRegimen.Columns.Add("TOTAL_MEDIO_EFECTIVO", Type.GetType("System.String"))
        _dtTiempoPromedioXRegimen.Columns.Add("TOTAL_DIAS", Type.GetType("System.Int32"))
        _dtTiempoPromedioXRegimen.Columns.Add("PROMEDIO", Type.GetType("System.Decimal"))
        _dtTiempoPromedioXRegimen.Columns.Add("EMBARQUE_SIN_ETA", Type.GetType("System.String"))
        _dtTiempoPromedioXRegimen.Columns.Add("EMBARQUE_SIN_LEVANTE", Type.GetType("System.String"))
        _dtTiempoPromedioXRegimen.Columns.Add("EMBARQUE", Type.GetType("System.String"))
        Dim drTPromXRegimen As DataRow

        For Each ItemReg As beRegimen In oListRegimen
            For Each Item As DataRow In odtMedioTransporte.Rows
                drTPromXRegimen = _dtTiempoPromedioXRegimen.NewRow
                drTPromXRegimen("CODIGO") = ItemReg.PNTPORGE
                drTPromXRegimen("REGIMEN") = ItemReg.PSTCMRGA
                drTPromXRegimen("CODIGO_TRANSPORTE") = Item("CMEDTR")
                drTPromXRegimen("TRANSPORTE") = ("" & Item("TNMMDT")).ToString.Trim
                drTPromXRegimen("TOTAL_DIAS") = 0
                drTPromXRegimen("PROMEDIO") = 0
                drTPromXRegimen("TOTAL_MEDIO_EFECTIVO") = 0
                drTPromXRegimen("EMBARQUE_SIN_ETA") = ""
                drTPromXRegimen("EMBARQUE_SIN_LEVANTE") = ""
                _dtTiempoPromedioXRegimen.Rows.Add(drTPromXRegimen)
            Next
            drTPromXRegimen = _dtTiempoPromedioXRegimen.NewRow
            drTPromXRegimen("CODIGO") = ItemReg.PNTPORGE
            drTPromXRegimen("REGIMEN") = ItemReg.PSTCMRGA
            drTPromXRegimen("CODIGO_TRANSPORTE") = 0
            drTPromXRegimen("TRANSPORTE") = "NO DEFINIDO"
            drTPromXRegimen("TOTAL_DIAS") = 0
            drTPromXRegimen("PROMEDIO") = 0
            drTPromXRegimen("TOTAL_MEDIO_EFECTIVO") = 0
            drTPromXRegimen("EMBARQUE_SIN_ETA") = ""
            drTPromXRegimen("EMBARQUE_SIN_LEVANTE") = ""
            _dtTiempoPromedioXRegimen.Rows.Add(drTPromXRegimen)
        Next

        '************************ Embarques X Regimen **************************

        Dim drr() As DataRow
        Me.InicializaRegimen(_dtEmbarqueXRegimen, oListRegimen, odtMedioTransporte, "CMEDTR", "TNMMDT")
        drr = dtCanal.Select("CODIGO <> ''")
        Me.InicializaRegimen(_dtCanalXRegimen, oListRegimen, ConvertTotable(drr, dtCanal), "CODIGO", "CANAL")
        drr = odtDato.Select("NTPODT='" & TIPO_DATO.TIPO_DESPACHO & "'")
        Me.InicializaRegimen(_dtDespachoXRegimen, oListRegimen, ConvertTotable(drr, odtDato), "NCODRG", "TDSCRG")
        drr = _dtContenedor.Select("CODIGO <>'0' AND ES_CONTENEDOR = 'S'")
        Me.InicializaRegimen(_dtContenedorXRegimen, oListRegimen, ConvertTotable(drr, _dtContenedor), "CODIGO", "CONTENEDOR")

    End Sub


    Private Function ConvertTotable(ByVal drr() As DataRow, ByVal odtDato As DataTable)
        Dim dt As New DataTable
        dt = odtDato.Clone
        For Each dr As DataRow In drr
            dt.ImportRow(dr)
        Next
        dt.AcceptChanges()
        Return dt
    End Function

    'Private Sub InicializaRegimen(ByVal dtResult As DataTable, ByVal drRegimen() As DataRow, ByVal dtColum As DataTable, ByVal strCodigo As String, ByVal strDescripcion As String)

    '    Dim ColName As String = ""
    '    dtResult.Columns.Add("CODIGO", Type.GetType("System.Int32"))
    '    dtResult.Columns.Add("REGIMEN", Type.GetType("System.String"))
    '    For Each dr As DataRow In dtColum.Rows
    '        dtResult.Columns.Add(dr(strCodigo).ToString.Trim & "_" & dr(strDescripcion).ToString.Trim, Type.GetType("System.Decimal"))
    '    Next
    '    dtResult.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
    '    dtResult.Columns.Add("EMBARQUE", Type.GetType("System.String"))

    '    Dim drGrupoRegimen As DataRow
    '    For Each Item As DataRow In drRegimen
    '        drGrupoRegimen = dtResult.NewRow
    '        drGrupoRegimen("CODIGO") = Item("NCODRG")
    '        drGrupoRegimen("REGIMEN") = ("" & Item("TDSCRG")).ToString.Trim
    '        For Each dc As DataColumn In dtResult.Columns
    '            ColName = dc.ColumnName.Trim
    '            If ColName.Contains("_") Then
    '                drGrupoRegimen(ColName) = 0
    '            End If
    '        Next
    '        drGrupoRegimen("EMBARQUE") = ""
    '        drGrupoRegimen("TOTAL") = 0
    '        dtResult.Rows.Add(drGrupoRegimen)
    '    Next

    '    drGrupoRegimen = dtResult.NewRow
    '    drGrupoRegimen("CODIGO") = 0
    '    drGrupoRegimen("REGIMEN") = "NO DEFINIDO"
    '    drGrupoRegimen("EMBARQUE") = ""
    '    For Each dc As DataColumn In dtResult.Columns
    '        ColName = dc.ColumnName.Trim
    '        If ColName.Contains("_") Then
    '            drGrupoRegimen(ColName) = 0
    '        End If
    '    Next
    '    drGrupoRegimen("EMBARQUE") = ""
    '    drGrupoRegimen("TOTAL") = 0
    '    dtResult.Rows.Add(drGrupoRegimen)
    'End Sub


    Private Sub InicializaRegimen(ByVal dtResult As DataTable, ByVal oListRegimen As List(Of beRegimen), ByVal dtColum As DataTable, ByVal strCodigo As String, ByVal strDescripcion As String)

        Dim ColName As String = ""
        dtResult.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        dtResult.Columns.Add("REGIMEN", Type.GetType("System.String"))
        For Each dr As DataRow In dtColum.Rows
            dtResult.Columns.Add(dr(strCodigo).ToString.Trim & "_" & dr(strDescripcion).ToString.Trim, Type.GetType("System.Decimal"))
        Next
        dtResult.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        dtResult.Columns.Add("EMBARQUE", Type.GetType("System.String"))

        Dim drGrupoRegimen As DataRow
        For Each Item As beRegimen In oListRegimen
            drGrupoRegimen = dtResult.NewRow
            drGrupoRegimen("CODIGO") = Item.PNTPORGE
            drGrupoRegimen("REGIMEN") = Item.PSTCMRGA
            For Each dc As DataColumn In dtResult.Columns
                ColName = dc.ColumnName.Trim
                If ColName.Contains("_") Then
                    drGrupoRegimen(ColName) = 0
                End If
            Next
            drGrupoRegimen("EMBARQUE") = ""
            drGrupoRegimen("TOTAL") = 0
            dtResult.Rows.Add(drGrupoRegimen)
        Next

        drGrupoRegimen = dtResult.NewRow
        drGrupoRegimen("CODIGO") = 0
        drGrupoRegimen("REGIMEN") = "NO DEFINIDO"
        drGrupoRegimen("EMBARQUE") = ""
        For Each dc As DataColumn In dtResult.Columns
            ColName = dc.ColumnName.Trim
            If ColName.Contains("_") Then
                drGrupoRegimen(ColName) = 0
            End If
        Next
        drGrupoRegimen("EMBARQUE") = ""
        drGrupoRegimen("TOTAL") = 0
        dtResult.Rows.Add(drGrupoRegimen)
    End Sub

    Private Sub InicializaLineaNaviera(ByVal dtResult As DataTable, ByVal dtlinea As DataTable, ByVal dtColum As DataTable, ByVal strCodigo As String, ByVal strDescripcion As String)

        Dim ColName As String = ""
        dtResult.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        dtResult.Columns.Add("LINEA", Type.GetType("System.String"))
        For Each dr As DataRow In dtColum.Rows
            dtResult.Columns.Add(dr(strCodigo).ToString.Trim & "_" & dr(strDescripcion).ToString.Trim, Type.GetType("System.Decimal"))
        Next
        dtResult.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
        dtResult.Columns.Add("EMBARQUE", Type.GetType("System.String"))

        Dim drGrupoRegimen As DataRow
        For Each Item As DataRow In dtlinea.Rows
            drGrupoRegimen = dtResult.NewRow
            drGrupoRegimen("CODIGO") = Item("CODIGO")
            drGrupoRegimen("LINEA") = ("" & Item("LINEA")).ToString.Trim
            For Each dc As DataColumn In dtResult.Columns
                ColName = dc.ColumnName.Trim
                If ColName.Contains("_") Then
                    drGrupoRegimen(ColName) = 0
                End If
            Next
            drGrupoRegimen("EMBARQUE") = ""
            drGrupoRegimen("TOTAL") = 0
            dtResult.Rows.Add(drGrupoRegimen)
        Next

        drGrupoRegimen = dtResult.NewRow
        drGrupoRegimen("CODIGO") = 0
        drGrupoRegimen("LINEA") = "NO DEFINIDO"
        drGrupoRegimen("EMBARQUE") = ""
        For Each dc As DataColumn In dtResult.Columns
            ColName = dc.ColumnName.Trim
            If ColName.Contains("_") Then
                drGrupoRegimen(ColName) = 0
            End If
        Next
        drGrupoRegimen("EMBARQUE") = ""
        drGrupoRegimen("TOTAL") = 0
        dtResult.Rows.Add(drGrupoRegimen)
    End Sub

    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function

    Private Function Lista_Datos_Embarque_Aduanero(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjFiltro.PSCCMPN)
        lobjParams.Add("PNCCLNT", pobjFiltro.PNCCLNT)
        lobjParams.Add("PNFECINI", pobjFiltro.PNFECINI)
        lobjParams.Add("PNFECFIN", pobjFiltro.PNFECFIN)
     
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_REP_AGENCIAMIENTO_ADUANERO_RPT", lobjParams)
        ds.Tables(0).TableName = "dtDatosEmbarque"
        ds.Tables(1).TableName = "dtContenedor"
        ds.Tables(2).TableName = "dtCartaFianza"
        ds.Tables(3).TableName = "dtDiaNoLaborable"
        ds.Tables(4).TableName = "dtRegimenxVencer"
        ds.Tables(5).TableName = "dtOrdenServicio"
        lobjSql.Dispose()
        lobjSql = Nothing
        Return ds.Copy
    End Function

    Private Function Lista_TipoDatos() As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_TIPO_DATOS_DETALLE_ALL_RPT", Nothing)
        Return dt
    End Function

    Private Function Lista_MedioTransporte() As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_ENVIO_RPT", Nothing)
        Return dt
    End Function


    Private Sub Cuenta_Regimen(ByVal NORSCI As Decimal, ByVal COD_REGIMEN As Decimal)
        For Each Item As DataRow In _dtRegimen.Rows
            If (Item("CODIGO") = COD_REGIMEN) Then
                Item("CANTIDAD") = Item("CANTIDAD") + 1
                If COD_REGIMEN = 0 Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Cuenta_TipoDespacho(ByVal NORSCI As Decimal, ByVal COD_DESPACHO As Decimal)
        For Each Item As DataRow In _dtDespacho.Rows
            If (Item("CODIGO") = COD_DESPACHO) Then
                Item("CANTIDAD") = Item("CANTIDAD") + 1
                If COD_DESPACHO = 0 Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Cuenta_Canal(ByVal NORSCI As Decimal, ByVal COD_CANAL As String)
        Dim REG_ENCONTRADO As Int32 = 0
        For Each Item As DataRow In _dtCanal.Rows
            If (Item("CODIGO") = COD_CANAL) Then
                Item("CANTIDAD") = Item("CANTIDAD") + 1
                If COD_CANAL = "" Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Cuenta_MedioTransporte(ByVal NORSCI As Decimal, ByVal COD_MEDIO As Decimal)
        For Each Item As DataRow In _dtMedioTransporte.Rows
            If (Item("CODIGO") = COD_MEDIO) Then
                Item("CANTIDAD") = Item("CANTIDAD") + 1
                If COD_MEDIO = 0 Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Cuenta_Contenedor(ByVal NORSCI As Decimal, ByVal COD_CONTENEDOR As Decimal, ByVal QCANTI As Decimal)
        For Each Item As DataRow In _dtContenedor.Rows
            If (Item("CODIGO") = COD_CONTENEDOR) Then
                Item("CANTIDAD") = Item("CANTIDAD") + QCANTI
                If COD_CONTENEDOR = 0 Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If
                Exit For
            End If
        Next
    End Sub


    Private Sub PromediarETA_VS_DocCompleto(ByVal dtTiempo As DataTable)
        Dim TotalMedio As Int32 = 0
        Dim Prom As Decimal = 0
        For Each Item As DataRow In dtTiempo.Rows
            TotalMedio = Item("TOTAL_MEDIO_EFECTIVO")
            If TotalMedio = 0 Then
                Prom = 0
            Else
                Prom = Math.Round(Item("TOTAL_DIAS") / Item("TOTAL_MEDIO_EFECTIVO"), 2)
            End If
            Item("PROMEDIO") = Prom
        Next
    End Sub


    Private Sub CuentaDiaETA_VS_FechaLevante(ByVal dtDiaLaborable As DataTable, ByVal NORSCI As Decimal, ByVal COD_MEDIO As Decimal, ByVal FECHA_LEVANTE As Decimal, ByVal ETA As Decimal)
        Dim lobjDrList As DataRow()
        Dim NumDias As Int32 = 0
        Dim lintDias As Int32 = 0
        Dim lstrLevante As String = FechaNum_a_Fecha(FECHA_LEVANTE)
        Dim lstrETA As String = FechaNum_a_Fecha(ETA)
        Dim Validacion As Boolean = False
        Validacion = FECHA_LEVANTE <> 0 AndAlso ETA <> 0
        If Validacion = True Then
            lobjDrList = dtDiaLaborable.Select("FFRDO >= " & ETA & " AND FFRDO <= " & FECHA_LEVANTE)
            lintDias = fintDiferencia_Dia_V2(lstrLevante, lstrETA, lobjDrList.Length)
            For FILA As Int32 = 0 To _dtTiempoPromedio.Rows.Count - 1
                If _dtTiempoPromedio.Rows(FILA)("CODIGO") = COD_MEDIO Then
                    If COD_MEDIO = 0 Then
                        _dtTiempoPromedio.Rows(FILA)("EMBARQUE") = _dtTiempoPromedio.Rows(FILA)("EMBARQUE") & NORSCI & ","
                    Else
                        _dtTiempoPromedio.Rows(FILA)("TOTAL_MEDIO_EFECTIVO") = _dtTiempoPromedio.Rows(FILA)("TOTAL_MEDIO_EFECTIVO") + 1
                        _dtTiempoPromedio.Rows(FILA)("TOTAL_DIAS") = _dtTiempoPromedio.Rows(FILA)("TOTAL_DIAS") + lintDias
                    End If
                    Exit For
                End If
            Next
        Else
            For FILA As Int32 = 0 To _dtTiempoPromedio.Rows.Count - 1
                If _dtTiempoPromedio.Rows(FILA)("CODIGO") = COD_MEDIO Then
                    If FECHA_LEVANTE = 0 Then
                        _dtTiempoPromedio.Rows(FILA)("EMBARQUE_SIN_LEVANTE") = _dtTiempoPromedio.Rows(FILA)("EMBARQUE_SIN_LEVANTE") & NORSCI & ","
                    End If
                    If ETA = 0 Then
                        _dtTiempoPromedio.Rows(FILA)("EMBARQUE_SIN_ETA") = _dtTiempoPromedio.Rows(FILA)("EMBARQUE_SIN_ETA") & NORSCI & ","
                    End If
                    If COD_MEDIO = 0 Then
                        _dtTiempoPromedio.Rows(FILA)("EMBARQUE") = _dtTiempoPromedio.Rows(FILA)("EMBARQUE") & NORSCI & ","
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Function fintDiferencia_Dia_V2(ByVal pstrDiaFinal As String, ByVal pstrDiaInicio As String, ByVal pintDia As Integer) As Integer
        Dim lintDif As Integer = 0
        lintDif = DateDiff(DateInterval.Day, CType(pstrDiaInicio, Date), CType(pstrDiaFinal, Date))
        lintDif = Math.Abs(lintDif) - pintDia
        Return lintDif
    End Function

    Public Sub CalcularDatos(ByVal pobjFiltro As beResumenEjecutivo)
        Dim dtDatoEmbarque As New DataTable
        Dim dtContenedor As New DataTable
        Dim dtCartaFianza As New DataTable
        Dim dtDiaLaborable As New DataTable
        Dim dtRegimenxVencer As New DataTable

        Dim ds As New DataSet
        ds = Lista_Datos_Embarque_Aduanero(pobjFiltro)
        dtDatoEmbarque = ds.Tables("dtDatosEmbarque")
        dtContenedor = ds.Tables("dtContenedor")
        dtCartaFianza = ds.Tables("dtCartaFianza")
        dtDiaLaborable = ds.Tables("dtDiaNoLaborable")
        dtRegimenxVencer = ds.Tables("dtRegimenxVencer")
        _dtOrdenServicio = ds.Tables("dtOrdenServicio")

        _TotalEmbarque = dtDatoEmbarque.Rows.Count

        'Inicializa la tabla de Contenedores_Por Linea naviera

        '''**********************************
        ''' 
        'Crea El grupo de Contenedores por línea naviera
        'InicializaLineaNaviera()
        'Busca Todas lineas de los Contenedores
        Dim dtLinea As New DataTable
        dtLinea.Columns.Add("CODIGO", Type.GetType("System.Int32"))
        dtLinea.Columns.Add("LINEA", Type.GetType("System.String"))

        Dim dr As DataRow
        For Each Item As DataRow In dtContenedor.Rows
            Select Case Item("COD_CONTENEDOR").ToString
                Case "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "16"
                    If Item("CCIANV") <> 0 Then
                        dr = dtLinea.NewRow
                        dr("CODIGO") = Item("CCIANV")
                        dr("LINEA") = Item("TNMCIN")
                        dtLinea.Rows.Add(dr)
                    End If
            End Select
        Next

        Dim dtLineaTemp As DataTable
        Dim dtw As New DataView(dtLinea)
        dtLineaTemp = dtw.ToTable(True, "CODIGO", "LINEA")
        Dim drr() As DataRow
        drr = _dtContenedor.Select("CODIGO <>'0' AND ES_CONTENEDOR = 'S'")
        Me.InicializaLineaNaviera(_dtContenedorXLineNaviera, dtLineaTemp, ConvertTotable(drr, _dtContenedor), "CODIGO", "CONTENEDOR")
        '''**********************************
        ''' 

        For Each Item As DataRow In dtDatoEmbarque.Rows
            Cuenta_Regimen(Item("NORSCI"), Item("COD_REGIMEN"))
            Cuenta_TipoDespacho(Item("NORSCI"), Item("COD_DESPACHO"))
            Cuenta_Canal(Item("NORSCI"), ("" & Item("TCANAL")).ToString.Trim)
            Cuenta_MedioTransporte(Item("NORSCI"), Item("COD_TNMMDT"))
            Totalizar_Costo_Embarque(Item)
            Costo_Embarque_X_Regimen(Item("NORSCI"), Item("COD_REGIMEN"), Item)
            CuentaDiaETA_VS_FechaLevante(dtDiaLaborable, Item("NORSCI"), Item("COD_TNMMDT"), Item("FECLEV_LEVANTE"), Item("ETA"))
            '
            AgrupaXRegimen(_dtEmbarqueXRegimen, Item, "COD_REGIMEN", "COD_TNMMDT")
            AgrupaXRegimen(_dtCanalXRegimen, Item, "COD_REGIMEN", "TCANAL")
            AgrupaXRegimen(_dtDespachoXRegimen, Item, "COD_REGIMEN", "COD_DESPACHO")
            CuentaDiaETA_VS_FechaLevante_X_REGIMEN(dtDiaLaborable, Item)
        Next

        PromediarETA_VS_DocCompleto(_dtTiempoPromedio)
        PromediarETA_VS_DocCompleto(_dtTiempoPromedioXRegimen)

        For Each Item As DataRow In dtContenedor.Rows
            Cuenta_Contenedor(Item("NORSCI"), Item("COD_CONTENEDOR"), Item("QCANTI"))
            AgrupaXRegimen(_dtContenedorXRegimen, Item, "COD_REGIMEN", "COD_CONTENEDOR", Item("QCANTI"))
            AgrupaXRegimen(_dtContenedorXLineNaviera, Item, "CCIANV", "COD_CONTENEDOR", Item("QCANTI"))
        Next

        Vencimiento_CartaFianzaXVencerMes = dtCartaFianza.Rows.Count
        Vencimiento_RegimenXVencerMes = dtRegimenxVencer.Rows.Count

        'OrdenServicio
        For Each Item As DataRow In _dtOrdenServicio.Rows
            Item("FECVEN_REG") = FechaNum_a_Fecha(Item("FECVEN_REG"))
            Item("FECVEN_CF") = FechaNum_a_Fecha(Item("FECVEN_CF"))
        Next

    End Sub

    Private Sub Totalizar_Costo_Embarque(ByVal drCosto As DataRow)
        _dtCostos.Rows(0)("EXW") = _dtCostos.Rows(0)("EXW") + drCosto("EXW")
        _dtCostos.Rows(0)("GFOB") = _dtCostos.Rows(0)("GFOB") + drCosto("GFOB")
        _dtCostos.Rows(0)("FOB") = _dtCostos.Rows(0)("FOB") + drCosto("FOB")
        _dtCostos.Rows(0)("FLETE") = _dtCostos.Rows(0)("FLETE") + drCosto("FLETE")
        _dtCostos.Rows(0)("SEGURO") = _dtCostos.Rows(0)("SEGURO") + drCosto("SEGURO")
        _dtCostos.Rows(0)("CIF") = _dtCostos.Rows(0)("CIF") + drCosto("CIF")
        _dtCostos.Rows(0)("ADVALO") = _dtCostos.Rows(0)("ADVALO") + drCosto("ADVALO")
        _dtCostos.Rows(0)("OTSGAS") = _dtCostos.Rows(0)("OTSGAS") + drCosto("OTSGAS")
        _dtCostos.Rows(0)("IGV") = _dtCostos.Rows(0)("IGV") + drCosto("IGV")
        _dtCostos.Rows(0)("IPM") = _dtCostos.Rows(0)("IPM") + drCosto("IPM")
        _dtCostos.Rows(0)("TOLDER") = _dtCostos.Rows(0)("TOLDER") + drCosto("TOLDER")
        _dtCostos.Rows(0)("ITTCAG") = _dtCostos.Rows(0)("ITTCAG") + drCosto("ITTCAG")
        _dtCostos.Rows(0)("ITTGOA") = _dtCostos.Rows(0)("ITTGOA") + drCosto("ITTGOA")
    End Sub

    Private Sub Costo_Embarque_X_Regimen(ByVal NORSCI As Decimal, ByVal COD_REGIMEN As Decimal, ByVal drCosto As DataRow)
        Dim SumaMonto As Decimal = 0
        Dim ColName As String = ""
        For Each Item As DataRow In _dtCostosXRegimen.Rows
            SumaMonto = 0
            If (Item("CODIGO") = COD_REGIMEN) Then
                Item("EXW_COSTO") = Item("EXW_COSTO") + drCosto("EXW")
                Item("GFOB_COSTO") = Item("GFOB_COSTO") + drCosto("GFOB")
                Item("FOB_COSTO") = Item("FOB_COSTO") + drCosto("FOB")
                Item("FLETE_COSTO") = Item("FLETE_COSTO") + drCosto("FLETE")
                Item("SEGURO_COSTO") = Item("SEGURO_COSTO") + drCosto("SEGURO")
                Item("CIF_COSTO") = Item("CIF_COSTO") + drCosto("CIF")
                Item("ADVALO_COSTO") = Item("ADVALO_COSTO") + drCosto("ADVALO")
                Item("OTSGAS_COSTO") = Item("OTSGAS_COSTO") + drCosto("OTSGAS")
                Item("IGV_COSTO") = Item("IGV_COSTO") + drCosto("IGV")
                Item("IPM_COSTO") = Item("IPM_COSTO") + drCosto("IPM")
                Item("TOLDER_COSTO") = Item("TOLDER_COSTO") + drCosto("TOLDER")
                Item("ITTCAG_COSTO") = Item("ITTCAG_COSTO") + drCosto("ITTCAG")
                Item("ITTGOA_COSTO") = Item("ITTGOA_COSTO") + drCosto("ITTGOA")

                '//////TOTALIZA MONTOS DE COSTOS/////////////////////
                For Each dc As DataColumn In _dtCostosXRegimen.Columns
                    ColName = dc.ColumnName.Trim
                    If ColName.EndsWith("_COSTO") AndAlso ColName <> "TOLDER_COSTO" AndAlso ColName <> "CIF_COSTO" Then
                        SumaMonto = SumaMonto + Item(ColName)
                    End If
                Next
                Item("TOTAL") = SumaMonto
                '/////////////////////////////////////////////////////
                If COD_REGIMEN = 0 Then
                    Item("EMBARQUE") = Item("EMBARQUE") & NORSCI & ","
                End If

                Exit For
            End If
        Next
    End Sub

    ''TIEMPO PROMEDIO POR REGIMEN
    Private Sub CuentaDiaETA_VS_FechaLevante_X_REGIMEN(ByVal dtDiaLaborable As DataTable, ByVal drEmbarque As DataRow)
        Dim lobjDrList As DataRow()
        Dim NumDias As Int32 = 0
        Dim lintDias As Int32 = 0
        Dim lstrLevante As String = FechaNum_a_Fecha(drEmbarque("FECLEV_LEVANTE"))
        Dim lstrETA As String = FechaNum_a_Fecha(drEmbarque("ETA"))
        Dim Validacion As Boolean = False
        Validacion = drEmbarque("FECLEV_LEVANTE") <> 0 AndAlso drEmbarque("ETA") <> 0
        If Validacion = True Then
            lobjDrList = dtDiaLaborable.Select("FFRDO >= " & drEmbarque("ETA") & " AND FFRDO <= " & drEmbarque("FECLEV_LEVANTE"))
            lintDias = fintDiferencia_Dia_V2(lstrLevante, lstrETA, lobjDrList.Length)

            For FILA As Int32 = 0 To _dtTiempoPromedioXRegimen.Rows.Count - 1

                If _dtTiempoPromedioXRegimen.Rows(FILA)("CODIGO") = drEmbarque("COD_REGIMEN") AndAlso _
                    _dtTiempoPromedioXRegimen.Rows(FILA)("CODIGO_TRANSPORTE") = drEmbarque("COD_TNMMDT") Then

                    If drEmbarque("COD_TNMMDT") = 0 Then
                        _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE") = _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE") & drEmbarque("NORSCI") & ","
                    Else
                        _dtTiempoPromedioXRegimen.Rows(FILA)("TOTAL_MEDIO_EFECTIVO") = _dtTiempoPromedioXRegimen.Rows(FILA)("TOTAL_MEDIO_EFECTIVO") + 1
                        _dtTiempoPromedioXRegimen.Rows(FILA)("TOTAL_DIAS") = _dtTiempoPromedioXRegimen.Rows(FILA)("TOTAL_DIAS") + lintDias
                    End If

                    Exit For
                End If
            Next


        Else
            For FILA As Int32 = 0 To _dtTiempoPromedioXRegimen.Rows.Count - 1
                If _dtTiempoPromedioXRegimen.Rows(FILA)("CODIGO") = drEmbarque("COD_REGIMEN") AndAlso _
                    _dtTiempoPromedioXRegimen.Rows(FILA)("CODIGO_TRANSPORTE") = drEmbarque("COD_TNMMDT") Then
                    If drEmbarque("FECLEV_LEVANTE") = 0 Then
                        _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE_SIN_LEVANTE") = _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE_SIN_LEVANTE") & drEmbarque("NORSCI") & ","
                    End If
                    If drEmbarque("ETA") = 0 Then
                        _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE_SIN_ETA") = _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE_SIN_ETA") & drEmbarque("NORSCI") & ","
                    End If
                    If drEmbarque("COD_TNMMDT") = 0 Then
                        _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE") = _dtTiempoPromedioXRegimen.Rows(FILA)("EMBARQUE") & drEmbarque("NORSCI") & ","
                    End If
                    Exit For
                End If
            Next
        End If
    End Sub

    ''/// Resumen de Embarques Por Regimen
    Private Sub AgrupaXRegimen(ByVal dtResult As DataTable, ByVal drEmbarque As DataRow, ByVal strCoAgrupador As String, ByVal strCodigo As String, Optional ByVal dblCantidad As Decimal = -1)
        Dim ColName As String = ""

        For Each Item As DataRow In dtResult.Rows
            If (Item("CODIGO") = drEmbarque(strCoAgrupador)) Then
                For Each Dc As DataColumn In dtResult.Columns
                    ColName = Dc.ColumnName.Trim
                    'El primer Valor de la Columna separada del Split será el codigo
                    If ColName.Contains("_") AndAlso Split(ColName, "_")(0).ToString.Trim = drEmbarque(strCodigo).ToString.Trim Then
                        If dblCantidad = -1 Then
                            Item(ColName) = Item(ColName) + 1
                            Item("TOTAL") = Item("TOTAL") + 1
                        Else
                            Item(ColName) = Item(ColName) + dblCantidad
                            Item("TOTAL") = Item("TOTAL") + dblCantidad
                        End If

                        Exit For
                    End If
                Next
                ' Para el Caso de los contenedores, estos graban los que no tienen asignados sin importar que sean de tipo "contenedor = S"
                If drEmbarque(strCoAgrupador).ToString.Trim = "0" OrElse drEmbarque(strCoAgrupador).ToString.Trim = "" Then
                    Item("EMBARQUE") = Item("EMBARQUE") & drEmbarque("NORSCI") & ","
                End If
                Exit For
            End If
        Next
    End Sub



End Class
