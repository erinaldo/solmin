Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports System.Text
Public Class clsPreEmbarque
    Private oPreEmbarque As Datos.clsPreEmbarque
    Private dblCliente As Double
    Private strOC As String
    Private dblParcial As Double
    Private oDt As DataTable
    Private strTipoCheckpoint As String
    Private oDtSeguimiento As DataTable
    Private oDtEstadoEmbarque As DataTable
    Private dblPreembarque As Double

    Enum TIPO_BUSQUEDA
        OC_PARCIAL
        OC_PARCIAL_ITEM
    End Enum
    Sub New()
        oPreEmbarque = New Datos.clsPreEmbarque
    End Sub

    Property Parcial()
        Get
            Return Me.dblParcial
        End Get
        Set(ByVal value)
            Me.dblParcial = value
        End Set
    End Property

    Property OC()
        Get
            Return Me.strOC
        End Get
        Set(ByVal value)
            Me.strOC = value
        End Set
    End Property

    Property Cliente()
        Get
            Return Me.dblCliente
        End Get
        Set(ByVal value)
            Me.dblCliente = value
        End Set
    End Property

    Property Tipo_CheckPoint()
        Get
            Return strTipoCheckpoint
        End Get
        Set(ByVal value)
            strTipoCheckpoint = value
        End Set
    End Property

    Property Lista_Seguimiento()
        Get
            Return Me.oDtSeguimiento
        End Get
        Set(ByVal value)
            oDtSeguimiento = value
        End Set
    End Property

    Property Lista_EstadoEmbarque()
        Get
            Return Me.oDtEstadoEmbarque
        End Get
        Set(ByVal value)
            oDtEstadoEmbarque = value
        End Set
    End Property

    Property Preembarque()
        Get
            Return Me.dblPreembarque
        End Get
        Set(ByVal value)
            dblPreembarque = value
        End Set
    End Property

    Private Sub Formato_OC_Item(ByRef oDtLista As DataTable)
        oDtLista.Columns.Add(New DataColumn("NRPEMB", GetType(System.Double)))
        oDtLista.Columns.Add(New DataColumn("NORCML", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("NRITOC", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("NESTDO", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("TDESES", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("DFECEST", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("DFECREA", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("TOBS", GetType(System.String)))
        oDtLista.Columns.Add(New DataColumn("NSEPRE", GetType(System.Int32)))
        oDtLista.Columns.Add(New DataColumn("MESTDO", GetType(System.Double)))
        oDtLista.Columns.Add(New DataColumn("CEMB", GetType(System.String)))
    End Sub

    Public Sub Busca_Nro_Parcial()
        dblParcial = Double.Parse(oPreEmbarque.Busca_Nro_Parcial(dblCliente, strOC).Rows(0).Item("PARCIAL").ToString.Trim)
    End Sub

    'Public Sub Mantenimiento_PreEmbarque(ByVal PSCCMPN As String, ByVal pstrTipo As String, ByVal pdblPreEmb As Double, ByVal pdblItem As Double, ByVal pstrSubItem As String, ByVal pdblCant As Double, ByVal pstrEstado As String)
    '    oPreEmbarque.Mantenimiento_PreEmbarque(PSCCMPN, pstrTipo, dblCliente, strOC, pdblPreEmb, pdblItem, pstrSubItem, dblParcial, pdblCant, pstrEstado)
    'End Sub
    Public Function Mantenimiento_PreEmbarque(ByVal PSCCMPN As String, ByVal pstrTipo As String, ByVal pdblPreEmb As Double, ByVal pdblItem As Double, ByVal pstrSubItem As String, ByVal pdblCant As Double, ByVal pstrEstado As String, ByVal PSCDVSN As String, ByVal PNCPLNDV As Decimal)
        Return oPreEmbarque.Mantenimiento_PreEmbarque(PSCCMPN, pstrTipo, dblCliente, strOC, pdblPreEmb, pdblItem, pstrSubItem, dblParcial, pdblCant, pstrEstado, PSCDVSN, PNCPLNDV)
    End Function


    Public Function Lista_PreEmbarque(ByVal pdblCli As Double) As DataTable
        Return oPreEmbarque.Lista_PreEmbarque(pdblCli)
    End Function

    Public Function Lista_Detalle_PreEmbarque() As DataTable
        Return oPreEmbarque.Lista_Detalle_PreEmbarque(Me.dblCliente, Me.strOC, Me.dblParcial)
    End Function

    Public Sub Elimina_PreEmbarque(ByVal NRPEMB As Decimal, ByVal CCLNT As Decimal)
        oPreEmbarque.Elimina_PreEmbarque(NRPEMB, CCLNT)
    End Sub


    Public Function Total_Item_PreEmbarque() As DataTable
        Return oPreEmbarque.Total_Item_PreEmbarque(Me.dblCliente, Me.strOC, Me.dblParcial)
    End Function

    Public Function Total_Item_OC() As DataTable
        Return oPreEmbarque.Total_Item_OC(Me.dblCliente, Me.strOC)
    End Function

    'Public Sub Crear_OC_PreEmbarque(ByVal pdblProv As Double, ByVal pstrDes As String, ByVal pdblFecha As Double, ByVal pstrIncoterm As String, ByVal pstrMedio As String, ByVal pdblMoneda As Double, ByVal pstrMoneda As String, ByVal pdblPrioridad As Double, ByVal pstrDestino As String, ByVal pstrRef As String, ByVal pstrEmp As String)
    '    oPreEmbarque.Crear_OC_PreEmbarque(dblCliente, strOC, pdblProv, pstrDes, pdblFecha, pstrIncoterm, pstrMedio, pdblMoneda, pstrMoneda, pdblPrioridad, pstrDestino, pstrRef, pstrEmp)
    'End Sub

    Public Function Crear_Embarque(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Decimal) As DataTable
        Return oPreEmbarque.Crear_Embarque(PSCCMPN, PSCDVSN, Me.dblCliente, PSTPSRVA, PNCPLNDV)
    End Function

    Public Sub Embarcar_PreEmbarque(ByVal pdblEmbarque As Double, ByVal pdblItem As Double, ByVal pdblPreembarque As Double, ByVal pdblCantidad As Double, ByVal pstrSubItem As String)
        oPreEmbarque.Embarcar_PreEmbarque(pdblEmbarque, dblCliente, strOC, Parcial, pdblItem, pdblPreembarque, pdblCantidad, pstrSubItem)
    End Sub

    Public Sub Act_Datos_Embarque(ByVal pdblEmbarque As Double)
        oPreEmbarque.Act_Datos_Embarque(pdblEmbarque, dblCliente, strOC)
    End Sub

    Public Function Lista_Observacion_PreEmbarque() As DataTable
        Return oPreEmbarque.Lista_Observacion_PreEmbarque(Me.dblPreembarque)
    End Function

    Public Sub Eliminar_Observaciones()
        oPreEmbarque.Eliminar_Observaciones(Me.dblPreembarque)
    End Sub


    Public Sub Eliminar_Observacion(ByVal strNRITEM As String)
        oPreEmbarque.Eliminar_Observacion(strNRITEM, Me.dblPreembarque)
    End Sub

    Public Sub Actualiza_Observaciones(ByVal pdblFecha As Double, ByVal pstrObs As String)
        oPreEmbarque.Actualiza_Observaciones(Me.dblPreembarque, pdblFecha, pstrObs)
    End Sub
    Public Sub Modificar_Observacion(ByVal pdblNroItem As Double, ByVal pdblFecha As Double, ByVal pstrObs As String)
        oPreEmbarque.Modificar_Observacion(Me.dblPreembarque, pdblNroItem, pdblFecha, pstrObs)
    End Sub

    Public Function Listar_Observacion(ByVal dblPreembarque As Double, ByVal pdblNroItem As Double) As DataTable
        Return oPreEmbarque.Listar_Observacion(dblPreembarque, pdblNroItem)
    End Function

    Public Function Listar_Seguimiento_Internacional_Excel(ByVal pstrTipo As String, ByVal pdblCli As Double, ByVal pstrProv As String, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pstrOC As String, ByVal pstrMTrans As String, ByVal pstrPais As String, ByVal pstrRef As String, ByVal pstrSeguimiento As String, ByVal pstrEmbarque As String, ByVal pstrEstado_Embarcado As String) As DataTable
        Dim dtSeguimiento As DataTable = oPreEmbarque.Listar_Seguimiento_Internacional_ba1(pstrTipo, pdblCli, pstrProv, pdblFecIni, pdblFecFin, pstrOC, pstrMTrans, pstrPais, pstrRef, pstrSeguimiento, pstrEmbarque, pstrEstado_Embarcado)

        Dim drCheckpointNRPEMB As DataRow()
        If dtSeguimiento.Rows.Count > 0 Then
            ''''Add Column al Seguimiento
            Dim dtCheckpoint As DataTable = oPreEmbarque.Lista_Checkpoint_Item_OC_X_Cliente(pdblCli)
            Dim view As DataView = New DataView(dtCheckpoint)
            Dim distinctValues As DataTable = view.ToTable(True, "TDESES")

            ''''Add Column al Seguimiento
            For Each row As DataRow In distinctValues.Rows
                Dim TDESES As String = row("TDESES").ToString().Trim()
                dtSeguimiento.Columns.Add(TDESES & "_DFECEST")
                dtSeguimiento.Columns(TDESES & "_DFECEST").SetOrdinal(dtSeguimiento.Columns.Count - 2)

                dtSeguimiento.Columns.Add(TDESES & "_DFECREA")
                dtSeguimiento.Columns(TDESES & "_DFECREA").SetOrdinal(dtSeguimiento.Columns.Count - 2)
            Next
            ''''Add  Info DFECEST,DFECREA
            For Each row As DataRow In dtSeguimiento.Rows
                drCheckpointNRPEMB = dtCheckpoint.Select("NRPEMB=" & row("NRPEMB").ToString())
                For Each Item As DataRow In drCheckpointNRPEMB
                    Dim TDESES As String = Item("TDESES").ToString().Trim()
                    Dim DFECEST As String = Item("DFECEST").ToString().Trim()
                    Dim DFECREA As String = Item("DFECREA").ToString().Trim()
                    row(TDESES & "_DFECEST") = DFECEST
                    row(TDESES & "_DFECREA") = DFECREA
                Next
            Next
        End If
        Return dtSeguimiento
    End Function

   


    Public Function Listar_Seguimiento_Internacional_ba1(ByVal pstrTipo As String, ByVal pdblCli As Double, ByVal pstrProv As String, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pstrOC As String, ByVal pstrMTrans As String, ByVal pstrPais As String, ByVal pstrRef As String, ByVal pstrSeguimiento As String, ByVal pstrEmbarque As String, ByVal pstrEstado_Embarcado As String) As DataTable
        Return oPreEmbarque.Listar_Seguimiento_Internacional_ba1(pstrTipo, pdblCli, pstrProv, pdblFecIni, pdblFecFin, pstrOC, pstrMTrans, pstrPais, pstrRef, pstrSeguimiento, pstrEmbarque, pstrEstado_Embarcado)
    End Function

    Public Sub Lista_Checkpoint_Item_OC_X_Cliente(ByVal pdblCli As Double)
        oDt = oPreEmbarque.Lista_Checkpoint_Item_OC_X_Cliente(pdblCli)
    End Sub

    Public Function Buscar_OC_Item_x_Preembarque(ByVal pdblPreEmb As Double) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("NRPEMB=" & pdblPreEmb)
        Formato_OC_Item(objDt)
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
1:          objDr(7) = objListaDr(lintCont).Item(7)
            objDr(8) = objListaDr(lintCont).Item(8)
            objDr(9) = objListaDr(lintCont).Item(9)
            objDr(10) = objListaDr(lintCont).Item(10)
            objDt.Rows.Add(objDr)
        Next lintCont
        Return objDt
    End Function

    Public Function Obtener_Num_PreEmbarque_X_OC(ByVal pdblPreEmb As Double, ByVal pdblChk As Double) As Double
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("NRPEMB=" & pdblPreEmb & "AND NESTDO=" & pdblChk)
        For lintCont = 0 To objListaDr.Length - 1
            Return objListaDr(0).Item(9)
        Next lintCont
        Return 0
    End Function

   

   
    Public Sub Act_Cantidad_Item_Ajuste(ByVal CCLNT As Decimal, ByVal NRPEMB As Decimal, ByVal NORCML As String, ByVal NRITOC As Decimal, ByVal SBITOC As String, ByVal QRLCSC As Decimal)
        oPreEmbarque.Act_Cantidad_Item_Ajuste(CCLNT, NRPEMB, NORCML, NRITOC, SBITOC, QRLCSC)
    End Sub

    Public Function Listar_FechasEntrega(ByVal oCargaInternacional As SOLMIN_SC.Entidad.OrdenCompra_BE) As DataTable
        Return oPreEmbarque.Listar_FechasEntrega_PreEmbarque(oCargaInternacional)
    End Function
  
    Public Function Agregar_FechasEntrega_PreEmbarque(ByVal oCargaInternacional As SOLMIN_SC.Entidad.OrdenCompra_BE) As Integer
        Try
            Return oPreEmbarque.Agregar_FechasEntrega_PreEmbarque(oCargaInternacional)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function
   

    Public Function ListaCheckPointDistinctxCliente(ByVal CCLNT As Decimal, ByVal CCMPN As String, ByVal CDVSN As String)
        Dim oListCHK As New List(Of String)
        Dim oDtCheckPointCliente As New DataTable
        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim odtListaCHK As New DataTable
        odtListaCHK.Columns.Add("NESTDO")
        odtListaCHK.Columns.Add("TDESES")
        oDtCheckPointCliente = oCheckPoint.Lista_CheckPoint_X_Cliente(CCLNT, CCMPN, CDVSN, "P", "A")
        Dim drCHK As DataRow
        For Each ItemDr As DataRow In oDtCheckPointCliente.Rows
            If (Not oListCHK.Contains(ItemDr("NESTDO"))) Then
                oListCHK.Add(ItemDr("NESTDO"))
                drCHK = odtListaCHK.NewRow
                drCHK("NESTDO") = ItemDr("NESTDO")
                drCHK("TDESES") = ItemDr("TCOLUM").ToString.Trim
                odtListaCHK.Rows.Add(drCHK)
            End If
        Next
                                    Return odtListaCHK
    End Function

    Public Function Listar_Seguimiento_Internacional_x_OrdenCompra(ByVal odtListaCHKPoint As DataTable, ByVal obeFiltro As beSeguimientoCargaFiltro) As DataTable
        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim odtListaCHK As New DataTable
        odtListaCHK = odtListaCHKPoint.Copy
        Dim CCLNT As Decimal = obeFiltro.PNCCLNT
        Dim ds As New DataSet
        Dim NORCML As String = ""
        Dim NRPARC As Decimal = 0
        Dim dtPreEmbarque As New DataTable
        Dim dtChkPreEmbarque As New DataTable
        Dim dtObsPreEmbarque As New DataTable
        Dim dtPreEmbarqueJoin As New DataTable
        Dim dtPreEmbarqueDatosAdicionales As New DataTable
       
        ds = oPreEmbarque.Listar_Seguimiento_Internacional_x_OrdenCompra_Parcial(obeFiltro)
        dtPreEmbarqueJoin = ds.Tables("dtPreEmbarque").Copy
        dtPreEmbarqueDatosAdicionales = ds.Tables("dtDatosAdicionPreEmbarque").Copy
        dtPreEmbarqueJoin.Columns.Add("TNMAGC")


        Dim TDESES_CHK As String = ""
        Dim NESTDO_CHK As String = ""
        For Each drCHKItem As DataRow In odtListaCHK.Rows
            NESTDO_CHK = drCHKItem("NESTDO")
            TDESES_CHK = drCHKItem("TDESES").ToString().Trim()
            dtPreEmbarqueJoin.Columns.Add(NESTDO_CHK & "_DFECEST")
            dtPreEmbarqueJoin.Columns.Add(NESTDO_CHK & "_DFECREA")
            dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECEST").Caption = TDESES_CHK & "| ESTIMADO"
            dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "| REAL"
        Next
        dtChkPreEmbarque = ds.Tables("dtChkPreEmbarque").Copy
        Dim obeCHKFecha As beCheckPointFecha
        For Each drItem As DataRow In dtPreEmbarqueJoin.Rows
            NORCML = drItem("NORCML").ToString.Trim
            NRPARC = drItem("NRPARC")
            drItem("TNMAGC") = Listar_AgenteCarga(dtPreEmbarqueDatosAdicionales, CCLNT, NORCML, NRPARC)
            For Each drCHKItem As DataRow In odtListaCHK.Rows
                NESTDO_CHK = drCHKItem("NESTDO")
                obeCHKFecha = New beCheckPointFecha
                obeCHKFecha = FindCHKxOC_Parcial(dtChkPreEmbarque, CCLNT, NORCML, NRPARC, NESTDO_CHK, 0, TIPO_BUSQUEDA.OC_PARCIAL)
                drItem(NESTDO_CHK & "_DFECEST") = obeCHKFecha.PSDFECEST
                drItem(NESTDO_CHK & "_DFECREA") = obeCHKFecha.PSDFECREA
            Next
        Next
        'TNMAGC
        Return dtPreEmbarqueJoin
    End Function
    Private Function Listar_AgenteCarga(ByVal odtListaAgenteCarga As DataTable, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPARC As Decimal)
        Dim drDatosAdd() As DataRow
        Dim sbAgente As New StringBuilder
        Dim TNMAGC As String
        Dim oListTNMAGC As New List(Of String)
        drDatosAdd = odtListaAgenteCarga.Select("CCLNT=" & PNCCLNT & " AND NORCML='" & PSNORCML & "' AND NRPARC=" & PNNRPARC)
        If (drDatosAdd.Length > 0) Then
            For Each Item As DataRow In drDatosAdd
                TNMAGC = Item("TNMAGC")
                If (Not oListTNMAGC.Contains(TNMAGC.ToUpper)) Then
                    oListTNMAGC.Add(TNMAGC.ToUpper)
                    sbAgente.Append(Item("TNMAGC"))
                    sbAgente.AppendLine()
                End If
            Next
        End If
        Return sbAgente.ToString
    End Function



    Public Function Listar_Seguimiento_Internacional_Rpt_OC_Items(ByVal oFiltro As beSeguimientoCargaFiltro) As DataTable
        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim odtListaCHK As New DataTable
        Dim ds As New DataSet
        Dim NORCML As String = ""
        Dim NRPARC As Decimal = 0
        Dim dtPreEmbarque As New DataTable
        Dim dtChkPreEmbarque As New DataTable
        Dim dtObsPreEmbarque As New DataTable
        Dim dtPreEmbarqueJoin As New DataTable
        Dim NRITOC As Decimal = 0

        odtListaCHK = ListaCheckPointDistinctxCliente(oFiltro.PNCCLNT, oFiltro.PSCCMPN, oFiltro.PSCDVSN)
        ds = oPreEmbarque.Listar_Seguimiento_Internacional_Rpt_OC_Items(oFiltro)
        dtPreEmbarqueJoin = ds.Tables("dtPreEmbarque").Copy
        dtPreEmbarqueJoin.Columns.Add("TOBS")

        dtPreEmbarqueJoin.Columns.Add("102_FMPDME_DIF") 'F. CARGA LISTA PROVEEDOR(REAL) VS F. ENTREGA PROMETIDA
        dtPreEmbarqueJoin.Columns("102_FMPDME_DIF").Caption = "Fecha (2) - (1)"
        dtPreEmbarqueJoin.Columns.Add("107_103_DIF") ' F. EMBARQUE(REAL) VS F. RECOJO(REAL)
        dtPreEmbarqueJoin.Columns("107_103_DIF").Caption = "Fecha (4) - (3)"

        Dim TDESES_CHK As String = ""
        Dim NESTDO_CHK As String = ""
        Dim TITULO_COLUMNA As String = ""
        For Each drCHKItem As DataRow In odtListaCHK.Rows
            NESTDO_CHK = drCHKItem("NESTDO")
            TDESES_CHK = drCHKItem("TDESES").ToString().Trim()
            dtPreEmbarqueJoin.Columns.Add(NESTDO_CHK & "_DFECEST")
            dtPreEmbarqueJoin.Columns.Add(NESTDO_CHK & "_DFECREA")
            dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECEST").Caption = TDESES_CHK & "| Fecha Estimado"
            Select Case NESTDO_CHK
                Case 102 ' FECHA CRAGA LISTA PROVEEDOR
                    dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "| Fecha Real (2)"
                Case 103 ' FECHA RECOJO
                    dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "| Fecha Real (3)"
                Case 107 'FECHA EMBARQUE
                    dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "| Fecha Real(4)"
                Case Else
                    dtPreEmbarqueJoin.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "| Fecha Real"
            End Select
        Next
        dtChkPreEmbarque = ds.Tables("dtChkPreEmbarque").Copy
        dtObsPreEmbarque = ds.Tables("dtObsPreEmbarque").Copy
        Dim ListaObsIngresadas As New List(Of String)
        Dim ListachkIngresadas As New List(Of String)
        Dim NORCML_PARCIAL As String = ""
        Dim obeCHKFecha As beCheckPointFecha
        Dim F_FMPDME As String = ""
        Dim F_102_DFECREA As String = ""
        Dim F_103_DFECREA As String = ""
        Dim F_107_DFECREA As String = ""
        For Each drItem As DataRow In dtPreEmbarqueJoin.Rows
            NORCML = drItem("NORCML").ToString.Trim
            NRPARC = drItem("NRPARC")
            NRITOC = drItem("NRITOC")
            NORCML_PARCIAL = drItem("NORCML").ToString.Trim & "-" & drItem("NRPARC").ToString.Trim
            F_102_DFECREA = ""
            F_103_DFECREA = ""
            F_107_DFECREA = ""
            F_FMPDME = ""
            If (ListaObsIngresadas.Contains(NORCML_PARCIAL)) Then
                drItem("TOBS") = ""
            ElseIf Not ListaObsIngresadas.Contains(NORCML_PARCIAL) Then
                ListaObsIngresadas.Add(NORCML_PARCIAL)
                drItem("TOBS") = FindObsxOC_Parcial(dtObsPreEmbarque, oFiltro.PNCCLNT, NORCML, NRPARC)
            End If
            For Each drCHKItem As DataRow In odtListaCHK.Rows
                NESTDO_CHK = drCHKItem("NESTDO")
                obeCHKFecha = New beCheckPointFecha
                obeCHKFecha = FindCHKxOC_Parcial(dtChkPreEmbarque, oFiltro.PNCCLNT, NORCML, NRPARC, NESTDO_CHK, NRITOC, TIPO_BUSQUEDA.OC_PARCIAL_ITEM)
                drItem(NESTDO_CHK & "_DFECEST") = obeCHKFecha.PSDFECEST
                drItem(NESTDO_CHK & "_DFECREA") = obeCHKFecha.PSDFECREA
            Next
            If (dtPreEmbarqueJoin.Columns("FMPDME") IsNot Nothing) Then
                F_FMPDME = drItem("FMPDME").ToString.Trim
            End If
            If (dtPreEmbarqueJoin.Columns("102_DFECREA") IsNot Nothing) Then
                F_102_DFECREA = drItem("102_DFECREA").ToString.Trim
            End If
            If (dtPreEmbarqueJoin.Columns("103_DFECREA") IsNot Nothing) Then
                F_103_DFECREA = drItem("103_DFECREA").ToString.Trim
            End If
            If (dtPreEmbarqueJoin.Columns("107_DFECREA") IsNot Nothing) Then
                F_107_DFECREA = drItem("107_DFECREA").ToString.Trim
            End If
            drItem("102_FMPDME_DIF") = Dif_Fecha_CheckPoint(F_102_DFECREA, F_FMPDME)
            drItem("107_103_DIF") = Dif_Fecha_CheckPoint(F_103_DFECREA, F_107_DFECREA)
        Next
        Return dtPreEmbarqueJoin
    End Function

    Private Function Dif_Fecha_CheckPoint(ByVal FechaMin As String, ByVal FechaMax As String) As String
        Dim dif As String = ""
        Dim Fecha As Date
        If (Date.TryParse(FechaMin, Fecha) AndAlso Date.TryParse(FechaMax, Fecha)) Then
            dif = DateDiff(DateInterval.Day, CDate(FechaMin), CDate(FechaMax))
        Else
            dif = ""
        End If
        Return dif
    End Function

    Private Function FindCHKxOC_Parcial(ByVal odtCHK As DataTable, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal NRPARC As Decimal, ByVal NESTDO As Decimal, ByVal NRITOC As Decimal, ByVal OTIPO_BUSQUEDA As TIPO_BUSQUEDA) As beCheckPointFecha
        Dim obeCHKFecha As New beCheckPointFecha
        Dim dr() As DataRow
        Dim DFECEST As String = ""
        Dim DFECREA As String = ""
        Dim oListDFECEST As New List(Of String)
        Dim oListDFECREA As New List(Of String)
        Dim sbDFECEST As New StringBuilder
        Dim sbDFECREA As New StringBuilder
        Dim numReg As Int32 = 0
        Dim oHasObs As New Hashtable
        Dim sb As New StringBuilder

        Select Case OTIPO_BUSQUEDA
            Case TIPO_BUSQUEDA.OC_PARCIAL
                dr = odtCHK.Select("CCLNT=" & CCLNT & " AND NORCML='" & NORCML & "' AND NRPARC=" & NRPARC & " AND NESTDO=" & NESTDO)
                For Each drItems As DataRow In dr
                    DFECEST = drItems("DFECEST").ToString.Trim
                    DFECREA = drItems("DFECREA").ToString.Trim
                    If (DFECEST.Length > 0) Then
                        If (Not oListDFECEST.Contains(DFECEST)) Then
                            oListDFECEST.Add(DFECEST)
                            sbDFECEST.Append(DFECEST)
                            sbDFECEST.AppendLine()
                        End If
                    End If
                    If (DFECREA.Length > 0) Then
                        If (Not oListDFECREA.Contains(DFECREA)) Then
                            oListDFECREA.Add(DFECREA)
                            sbDFECREA.Append(DFECREA)
                            sbDFECREA.AppendLine()
                        End If
                    End If
                Next

            Case TIPO_BUSQUEDA.OC_PARCIAL_ITEM
                dr = odtCHK.Select("CCLNT=" & CCLNT & " AND NORCML='" & NORCML & "' AND NRPARC=" & NRPARC & " AND NESTDO=" & NESTDO & " AND NRITOC=" & NRITOC)
                If (dr.Length > 0) Then
                    DFECEST = dr(0)("DFECEST").ToString.Trim
                    DFECREA = dr(0)("DFECREA").ToString.Trim

                    If (DFECEST.Length > 0) Then
                        If (Not oListDFECEST.Contains(DFECEST)) Then
                            oListDFECEST.Add(DFECEST)
                            sbDFECEST.Append(DFECEST)
                            sbDFECEST.AppendLine()
                        End If
                    End If
                    If (DFECREA.Length > 0) Then
                        If (Not oListDFECREA.Contains(DFECREA)) Then
                            oListDFECREA.Add(DFECREA)
                            sbDFECREA.Append(DFECREA)
                            sbDFECREA.AppendLine()
                        End If
                    End If
                End If

        End Select

        If (oListDFECEST.Count = 1) Then
            obeCHKFecha.PSDFECEST = oListDFECEST(0).Trim
        Else
            obeCHKFecha.PSDFECEST = sbDFECEST.ToString.Trim
        End If

        If (oListDFECREA.Count = 1) Then
            obeCHKFecha.PSDFECREA = oListDFECREA(0).Trim
        Else
            obeCHKFecha.PSDFECREA = sbDFECREA.ToString.Trim
        End If
        Return obeCHKFecha
    End Function


    Private Function FindObsxOC_Parcial(ByVal odtObs As DataTable, ByVal CCLNT As Decimal, ByVal NORCML As String, ByVal NRPARC As Decimal) As String
        Dim dr() As DataRow
        Dim TOBS As String = ""
        Dim oListObs As New List(Of String)
        Dim sb As New StringBuilder
        dr = odtObs.Select("CCLNT=" & CCLNT & " AND NORCML='" & NORCML & "' AND NRPARC=" & NRPARC)
        For Each drItems As DataRow In dr
            TOBS = drItems("TOBS").ToString.Trim
            If (Not oListObs.Contains(TOBS)) Then
                oListObs.Add(TOBS)
                sb.Append(TOBS)
                sb.AppendLine()
            End If
        Next
        Return sb.ToString
    End Function
    Public Function ListarItemsXOrdenCompraParcial_x_Item(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As New DataTable
        odt = oPreEmbarque.ListarItemsXOrdenCompraParcial_x_Item(obeOrdenPreEmbarcarda)
        Return odt
    End Function

    Public Function ListarItemsXOrdenCompraParcial(ByVal odtListaCHKPoint As DataTable, ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As New DataSet
        Dim NORCML As String = ""
        Dim NRPARC As Decimal = 0

        Dim odtJoinItemOCParcial As New DataTable
        Dim dtCHKItemOCParcial As New DataTable
        odtJoinItemOCParcial = oPreEmbarque.ListarItemsXOrdenCompraParcial(obeOrdenPreEmbarcarda)
        dtCHKItemOCParcial = oPreEmbarque.ListarCheckPointXOrdenCompraParcial(obeOrdenPreEmbarcarda)

        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim odtListaCHK As New DataTable
        odtListaCHK = odtListaCHKPoint.Copy

        Dim TDESES_CHK As String = ""
        Dim NESTDO_CHK As String = ""
        Dim CCLNT As Decimal = 0
        Dim NRITOC As Decimal = 0
        For Each drCHKItem As DataRow In odtListaCHK.Rows
            NESTDO_CHK = drCHKItem("NESTDO")
            TDESES_CHK = drCHKItem("TDESES").ToString().Trim()
            odtJoinItemOCParcial.Columns.Add(NESTDO_CHK & "_DFECEST")
            odtJoinItemOCParcial.Columns.Add(NESTDO_CHK & "_DFECREA")
            odtJoinItemOCParcial.Columns(NESTDO_CHK & "_DFECEST").Caption = TDESES_CHK & "- ESTIMADO"
            odtJoinItemOCParcial.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "- REAL"
        Next

        Dim obeCHKFecha As beCheckPointFecha
        For Each drItem As DataRow In odtJoinItemOCParcial.Rows
            NORCML = drItem("NORCML").ToString.Trim
            NRPARC = drItem("NRPARC")
            CCLNT = drItem("CCLNT")
            NRITOC = drItem("NRITOC")
            For Each drCHKItem As DataRow In odtListaCHK.Rows
                NESTDO_CHK = drCHKItem("NESTDO")
                obeCHKFecha = New beCheckPointFecha
                obeCHKFecha = FindCHKxOC_Parcial(dtCHKItemOCParcial, CCLNT, NORCML, NRPARC, NESTDO_CHK, NRITOC, TIPO_BUSQUEDA.OC_PARCIAL_ITEM)
                drItem(NESTDO_CHK & "_DFECEST") = obeCHKFecha.PSDFECEST
                drItem(NESTDO_CHK & "_DFECREA") = obeCHKFecha.PSDFECREA
            Next
        Next
        Return odtJoinItemOCParcial
    End Function
    Public Function Lista_Obs_OC_Parcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As DataTable = oPreEmbarque.Lista_Obs_OC_Parcial(obeOrdenPreEmbarcarda)
        Return odt
    End Function
    Public Function Lista_Checkpoint_OC_Parcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As DataTable = oPreEmbarque.Lista_Checkpoint_OC_Parcial(obeOrdenPreEmbarcarda)
        Return odt
    End Function
    Public Function Lista_Checkpoint_OC_Parcial_Item(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim odt As DataTable = oPreEmbarque.Lista_Checkpoint_OC_Parcial_Item(obeOrdenPreEmbarcarda)
        Return odt
    End Function
    Public Function ListarItemsXOrdenCompra_ParcialVarios(ByVal oListbeOrdenPreEmbarcarda As List(Of beOrdenPreEmbarcadaFiltro)) As DataTable
        Dim odtItemsOrdenPreEmbarcada As New DataTable
        Dim OrdeTEmp As New DataTable
        Dim dr As DataRow
        If (oListbeOrdenPreEmbarcarda.Count > 0) Then
            odtItemsOrdenPreEmbarcada = oPreEmbarque.ListarItemsXOrdenCompraParcial(oListbeOrdenPreEmbarcarda.Item(0))
        End If
        For index As Integer = 1 To oListbeOrdenPreEmbarcarda.Count - 1
            OrdeTEmp = oPreEmbarque.ListarItemsXOrdenCompraParcial(oListbeOrdenPreEmbarcarda.Item(index))
            For Each drItem As DataRow In OrdeTEmp.Rows
                dr = odtItemsOrdenPreEmbarcada.NewRow
                dr("CCLNT") = drItem("CCLNT")
                dr("NRPEMB") = drItem("NRPEMB")
                dr("NORCML") = drItem("NORCML").ToString.Trim
                dr("NRPARC") = drItem("NRPARC")
                dr("NORSCI") = drItem("NORSCI")
                dr("NRITOC") = drItem("NRITOC")
                dr("SBITOC") = drItem("SBITOC").ToString.Trim
                dr("TDITES") = drItem("TDITES").ToString.Trim
                dr("QRLCSC") = drItem("QRLCSC")
                dr("SESTRG") = drItem("SESTRG").ToString.Trim
                dr("CAGNCR") = drItem("CAGNCR").ToString.Trim
                dr("TNMAGC") = drItem("TNMAGC").ToString.Trim
                dr("IVUNIT") = drItem("IVUNIT")
                odtItemsOrdenPreEmbarcada.Rows.Add(dr)
            Next
        Next
        Return odtItemsOrdenPreEmbarcada
    End Function

    Public Function LLenarObservacionPorOrdenCompraParcial(ByVal PSCCMPN As String, ByVal CCLNT As Decimal, ByVal odtDatosPreEmbarque As DataTable) As DataTable
        Dim NORCML As String = ""
        Dim NRPARC As Decimal = 0
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Dim dtObsPreEmbarque As New DataTable
        Dim obeOrdenPreEmbarcadaFiltro As New beOrdenPreEmbarcadaFiltro
        obeOrdenPreEmbarcadaFiltro.PNCCLNT = CCLNT
        obeOrdenPreEmbarcadaFiltro.PSCCMPN = PSCCMPN
        If (odtDatosPreEmbarque.Columns("TOBS") IsNot Nothing) Then
            odtDatosPreEmbarque.Columns.Remove("TOBS")
        End If
        odtDatosPreEmbarque.Columns.Add("TOBS")
        dtObsPreEmbarque = oPreEmbarque.Lista_Observacion_OrdenCompra_PreEmbarque(obeOrdenPreEmbarcadaFiltro)
        For Each drItem As DataRow In odtDatosPreEmbarque.Rows
            NORCML = drItem("NORCML").ToString.Trim
            NRPARC = drItem("NRPARC")
            drItem("TOBS") = FindObsxOC_Parcial(dtObsPreEmbarque, CCLNT, NORCML, NRPARC)
        Next
        Return odtDatosPreEmbarque
    End Function

    Public Function Actualizar_Datos_X_Preembarque(ByVal obePreEmbarque_BE As bePreEmbarque) As Int32
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Actualizar_Datos_X_Preembarque(obePreEmbarque_BE)
    End Function

    Public Function Obtener_Dato_PreEmbarque(ByVal PNCCLNT As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Obtener_Dato_PreEmbarque(PNCCLNT, PNNRPEMB)
    End Function

    Public Function Obtener_Dato_OC_Parcial(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPARC As Decimal) As DataTable
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Obtener_Dato_OC_Parcial(PSCCMPN, PNCCLNT, PSNORCML, PNNRPARC)
    End Function

 
    Public Function Validar_Nro_Parcial_CargaInternacional(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Validar_Nro_Parcial_CargaInternacional(PSCCMPN, PNCCLNT, PSNORCML, PNNRPARC_NUEVO)
    End Function

    Public Function Validar_Nro_Parcial_CargaInternacional_Item(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Validar_Nro_Parcial_CargaInternacional_Item(PSCCMPN, PNCCLNT, PSNORCML, PNNRITOC, PSSBITOC, PNNRPARC_NUEVO)
    End Function


    Public Function Actualizar_Nro_Parcial_CargaInternacional(ByVal PNNRPEMB As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNRPARC_INI As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim oPreEmbarque As New Datos.clsPreEmbarque
        Return oPreEmbarque.Actualizar_Nro_Parcial_CargaInternacional(PNNRPEMB, PNCCLNT, PSNORCML, PNNRITOC, PSSBITOC, PNNRPARC_INI, PNNRPARC_NUEVO)
    End Function

End Class
