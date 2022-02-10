Public Class UcFrmConsistencia
    Private objServicio As New Servicio_BE
    Private tipo_cambio As Double = 0D
    Private valor_igv As Double = 0D
    Private strTipoAlmacen As String = ""
    Private bolBuscar As New Boolean
    Private oCompania As clsCompaniaNeg = New clsCompaniaNeg
    Private oDivision As clsDivisionNeg = New clsDivisionNeg
    Private oPlanta As clsPlantaNeg = New clsPlantaNeg
    Private oEstadoPendiente As clsEstadoNeg = New clsEstadoNeg
    Private oEstadoFactura As clsEstadoNeg = New clsEstadoNeg
    Private oDtPlanta As New DataTable
    Private oConsistencia As clsConsistencia_BL = New clsConsistencia_BL
    Private oServicio As clsServicio_BL = New clsServicio_BL
    Private Estatico As New Estaticos
    Public Revision As Integer = 0
    Public Property TipoAlmacen() As String 
        Get
            Return strTipoAlmacen
        End Get
        Set(ByVal value As String)
            strTipoAlmacen = value
        End Set
    End Property
    Public Sub New(ByVal oServicio As Servicio_BE)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objServicio = oServicio
    End Sub

    Private Sub UcFrmConsistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(objServicio.CCLNT, objServicio.PSUSUARIO)
        UcCliente.pCargar(ClientePK)
        oCompania.Crea_Lista(objServicio.PSUSUARIO)
        oDivision.Crea_Lista(objServicio.PSUSUARIO)
        oPlanta.Crea_Lista(objServicio.PSUSUARIO)
        Cargar_Compania()
        Cargar_Division()
        Cargar_Estado()
        Cargar_CriterioBusqueda()
        Cargar_TipoServicio()
        If Revision > 0 Then
            cmbCriterioReporte.SelectedValue = 3
            txtBusqueda.Text = Revision.ToString

        End If
    End Sub

    Private Sub Cargar_Compania()
        bolBuscar = False
        cmbCompania.DataSource = oCompania.Lista
        cmbCompania.ValueMember = "CCMPN"
        bolBuscar = True
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedValue = objServicio.CCMPN
    End Sub
    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            cmbDivision.DataSource = oDivision.Lista_Division_Opcion(Me.cmbCompania.SelectedValue.ToString.Trim, 0)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            cmbDivision.SelectedValue = objServicio.CDVSN
            cmbDivision_SelectedIndexChanged(Nothing, Nothing)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Planta()
        Try
            Dim oDtAux As New DataTable
            Dim oDr As DataRow

            oDtAux.Columns.Add("CPLNDV", GetType(String))
            oDtAux.Columns.Add("TPLNTA", GetType(String))

            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                oDtPlanta = oPlanta.Lista_Planta_Division(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                For Each dr As DataRow In oDtPlanta.Rows
                    oDr = oDtAux.NewRow
                    oDr("CPLNDV") = dr("CPLNDV")
                    oDr("TPLNTA") = dr("TPLNTA")
                    oDtAux.Rows.Add(oDr)
                Next
                oDtPlanta = oDtAux
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                cmbPlanta.DisplayMember = "TPLNTA"
                cmbPlanta.DataSource = oDtPlanta
                Dim oDtPlantaSel As New List(Of Integer)
                For Each s As String In objServicio.TIPO_PLANTA.Split(",")
                    oDtPlantaSel.Add(s)
                Next

                For i As Integer = 0 To cmbPlanta.Items.Count - 1
                    If cmbPlanta.Items.Item(i).Value = "0" Then
                        cmbPlanta.SetItemChecked(i, True)
                    End If
                    For j As Integer = 0 To oDtPlantaSel.Count - 1
                        If cmbPlanta.Items.Item(i).Value = oDtPlantaSel.Item(j).ToString Then
                            cmbPlanta.SetItemChecked(i, True)
                        End If
                    Next
                Next

            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub Cargar_Estado()

        oEstadoFactura.Estado_Servicio()
        bolBuscar = False
        cmbEstadoFactura.DataSource = oEstadoFactura.Tabla
        cmbEstadoFactura.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoFactura.DisplayMember = "TEX"
        cmbEstadoFactura.SelectedValue = "N"

        oEstadoPendiente.Estado_Pendiente()
        bolBuscar = False
        cmbEstadoPendiente.DataSource = oEstadoPendiente.Tabla
        cmbEstadoPendiente.ValueMember = "COD"
        bolBuscar = True
        cmbEstadoPendiente.DisplayMember = "TEX"
        cmbEstadoPendiente.SelectedValue = objServicio.FLGPEN

        cmbEstadoFactura.SelectedValue = objServicio.FLGFAC

        If Not objServicio.FechaInicio.Trim.Equals("") Then
            Me.dtFeInicial.Value = objServicio.FechaInicio
            Me.dtFeFinal.Value = objServicio.FechaFin

            If Revision > 0 Then
                Me.chkFecha.Checked = False
                chkFecha_CheckedChanged(Nothing, Nothing)
            Else
                Me.chkFecha.Checked = True
            End If
        Else
            Me.chkFecha.Checked = False
            chkFecha_CheckedChanged(Nothing, Nothing)
        End If

    End Sub
    Private Sub Cargar_CriterioBusqueda()
        bolBuscar = False
        cmbCriterioReporte.DataSource = oConsistencia.ListaCriterioBusqueda()
        cmbCriterioReporte.ValueMember = "COD"
        bolBuscar = True
        cmbCriterioReporte.DisplayMember = "VAL"
    End Sub
    Private Sub Cargar_TipoServicio()
        '====Cargamos tipo de Almacenaje====
        bolBuscar = False
        Me.cmbTipoAlmacenaje.DataSource = oServicio.ListaTipoAlmacenaje(cmbDivision.SelectedValue)
        Me.cmbTipoAlmacenaje.ValueMember = "COD"
        Me.cmbTipoAlmacenaje.DisplayMember = "VAL"
        If strTipoAlmacen <> "0" Then
            If strTipoAlmacen <> Estatico.E_ESP_Almacenaje Then
                cmbTipoAlmacenaje.SelectedValue = strTipoAlmacen
                cmbTipoAlmacenaje.Enabled = False
                cmbTipoServicio.Enabled = False
            End If
        Else
            cmbTipoServicio.Enabled = True
        End If
        '===Carga los Servicios Especiales===
        Me.cmbTipoServicio.DataSource = oServicio.ListaServiciosEsp(cmbDivision.SelectedValue, 1)
        Me.cmbTipoServicio.ValueMember = "CCMPRN"
        bolBuscar = True
        Me.cmbTipoServicio.DisplayMember = "TDSDES"
        If objServicio.CTPALJ <> "0" Then
            cmbTipoServicio.SelectedValue = objServicio.CTPALJ
        End If
    End Sub

    Private Sub cmbTipoAlmacenaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAlmacenaje.SelectedIndexChanged
        If bolBuscar Then
            If cmbTipoAlmacenaje.SelectedValue = "1" Then
                cmbTipoServicio.Enabled = False
                cmbTipoServicio.SelectedValue = Estatico.E_ESP_General
            Else
                cmbTipoServicio.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub
    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
            Cargar_TipoServicio()
        End If
    End Sub
    '=======================================================================
    '=======================================================================
    '=======================================================================
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function GenerarSustento(ByVal objDsSustentos As DataSet)

        Dim oDtResLotePrint As New DataTable
        Dim dtFiltro As New DataTable
        Dim odsExcel As New DataSet


        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")




        For Each dt As DataTable In objDsSustentos.Tables
            Dim objDt As New DataTable
            Dim objDs As New DataSet
            objDt = dt

            If objDt.Rows.Count = 0 Then Continue For


            objDt.Columns.Add("TIPO_CAMBIO")
            For i As Integer = 0 To objDt.Rows.Count - 1
                objDt.Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next
            '========================TABLA APOYO======================
            Dim oDtUtil As New DataTable
            oDtUtil.TableName = "UTILES"
            oDtUtil.Columns.Add("IGV")
            oDtUtil.Columns.Add("TIPO_CAMBIO")
            Dim rowUtil As DataRow
            rowUtil = oDtUtil.NewRow
            rowUtil(0) = valor_igv
            rowUtil(1) = tipo_cambio
            oDtUtil.Rows.Add(rowUtil)
            oDtUtil.TableName = "UTILES"
            '====================================DANDO FORMATO A TABLAS============================
            '======================================================================================
            Dim oDtFiltro As New DataTable
            Dim oDtDetalle As New DataTable
            oDtDetalle = objDt.Copy
            '===PARA EL FILTRO===
            oDtFiltro.TableName = "Filtro"
            oDtFiltro.Columns.Add("Filtro")
            oDtFiltro.Columns.Add("Valor")
            Dim row As DataRow

            row = oDtFiltro.NewRow
            row(0) = "Compañia :"
            row(1) = cmbCompania.Text
            oDtFiltro.Rows.Add(row)

            row = oDtFiltro.NewRow
            row(0) = "División :"
            row(1) = cmbDivision.Text
            oDtFiltro.Rows.Add(row)

         

            row = oDtFiltro.NewRow
            row(0) = "Nro. Consistencia :"
            row(1) = txtBusqueda.Text
            oDtFiltro.Rows.Add(row)

            '==== PARA EL RESUMEN =====
            Dim oDtResumen As DataTable = oDtDetalle.Copy
            Dim colResumen As Integer = oDtResumen.Columns.Count - 1
            Dim tarifa1 As Integer = 0
            Dim tarifa2 As Integer = 0
            Dim bTrfInicia As Boolean = True
            Dim ldblSub_total As Double = 0D
            Dim iPosIni As Integer = 0
            Dim oDv As New DataView(oDtResumen)
            oDv.Sort = "NRTFSV ASC"
            oDtResumen = oDv.ToTable(True, "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")

            Dim dtRes As DataTable = oDv.ToTable(True, "NRTFSV", "TCMTRF")

            For i As Integer = 0 To oDtResumen.Rows.Count - 1
                If i = 0 Then
                    tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                    iPosIni = i
                Else
                    tarifa2 = oDtResumen.Rows(i).Item("NRTFSV")
                    If tarifa1 = tarifa2 Then
                        oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") = oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") + oDtResumen.Rows(i).Item("SUB_TOTAL")
                        oDtResumen.Rows(iPosIni).Item("QATNAN") = oDtResumen.Rows(iPosIni).Item("QATNAN") + oDtResumen.Rows(i).Item("QATNAN")
                        oDtResumen.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                        iPosIni = i
                    End If
                End If
            Next
            oDtResumen.Columns.RemoveAt(0) 'QUITO LA OPERACION USADA COMO FLAG
            Dim objListaDr As DataRow() = oDtResumen.Select("QATNAN > 0")
            Dim objDr As DataRow
            Dim lintCont As Integer
            Dim objDtDet As New DataTable
            objDtDet.Columns.Add("NRTFSV")
            objDtDet.Columns.Add("TCMTRF")
            objDtDet.Columns.Add("MONEDA")
            objDtDet.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDet.Columns.Add("QATNAN", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_DOLARES", GetType(System.Double))
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDtDet.NewRow
                objDr(0) = objListaDr(lintCont).Item("NRTFSV") 'TARIFA
                objDr(1) = objListaDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDr(2) = objListaDr(lintCont).Item("TMNDA")  'MONEDA
                objDr(3) = objListaDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDr(4) = objListaDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_total = objListaDr(lintCont).Item("SUB_TOTAL")
                If objDr(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDr(5) = Math.Round(ldblSub_total, 2)  'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDr(5) = Math.Round(ldblSub_total * tipo_cambio, 2) 'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total, 2) 'IMPORTE DOLARES
                End If
                objDtDet.Rows.Add(objDr)
            Next lintCont

            '=======================================
            '====== PARA EL RESUMEN DE LOTES =======
            '=======================================
            Dim oDtResLote As DataTable = oDtDetalle.Copy
            Dim oDvLote As New DataView(oDtResLote)

            Dim objDataRow As DataRow
            Dim TotMntSoles As Double = 0D
            Dim TotMntDolares As Double = 0D
            oDvLote.Sort = "LOTE ASC"
            oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP")

            oDtResLote.Columns.Remove("NOPRCN")

            Dim OriginalCount As Integer = oDtResLote.Rows.Count

            For i As Integer = 0 To OriginalCount - 1

                dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")
                TotMntSoles = 0
                TotMntDolares = 0
                For Each dr As DataRow In dtFiltro.Rows
                    If dr("TMNDA").ToString.Trim = "USD" Then
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If
                Next
                If dtFiltro.Rows.Count > 0 Then
                    objDataRow = oDtResLotePrint.NewRow
                    objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtResLotePrint.Rows.Add(objDataRow)
                    i = i + dtFiltro.Rows.Count - 1
                End If
            Next i
            '=======================================
            '=======================================

            '======================================================================================    
            objDs.Tables.Add(objDt.Copy) 'Detallle
            objDs.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDs.Tables.Add(objDtDet.Copy) 'Resumen
            objDs.Tables.Add(oDtResLotePrint.Copy) 'Resumen Lotes
            '==============================FORMATEANDO EL EXCEL======================================

            ''''Reset la tabla ''''
            Dim otblAlm As New DataTable
            otblAlm = objDs.Tables(0).Copy
            '==========ALMACEN============  

            odsExcel.Tables.Add(ResumenFacturacion(otblAlm).Copy)
            odsExcel.Tables.Add(objDs.Tables(1).Copy)
            odsExcel.Tables.Add(objDs.Tables(2).Copy)
            odsExcel.Tables.Add(oDtResLotePrint.Copy)

        Next

        Return odsExcel
    End Function
    Private Function ResumenFacturacion(ByVal objDt As DataTable) As DataTable

        Dim oDtDetalle As DataTable = objDt

        Dim oDtResumenAlmacen As New DataTable


        oDtResumenAlmacen = oDtDetalle.Clone



        Dim TCMPCL As String = ""
        Dim NOPRCN As String = ""
        Dim TMNDA As String = ""
        Dim NRTFSV As String = ""
        Dim SERVICIO As String = ""
        Dim TCMTRF As String = ""
        Dim IVLSRV As String = ""
        Dim QATNAN As String = ""
        Dim SUB_TOTAL As String = ""
        Dim SESTRG_SERV As String = ""
        Dim NCRROP As String = ""
        Dim Division As String = ""

        Dim nCount As Integer = 0
        Dim blExiste As Boolean = False
        Dim blExisteOper As Boolean = False

        For Each dr As DataRow In oDtDetalle.Rows

            blExiste = False



            If nCount = 0 Then
                TCMPCL = dr("TCMPCL")
                NOPRCN = dr("NOPRCN")
                TMNDA = dr("TMNDA")
                NRTFSV = dr("NRTFSV")
                SERVICIO = dr("SERVICIO")
                TCMTRF = dr("TCMTRF")
                IVLSRV = dr("IVLSRV")
                QATNAN = dr("QATNAN")
                SUB_TOTAL = dr("SUB_TOTAL")
                NCRROP = dr("NCRROP")
                Division = dr("CDVSN")
                If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
            End If

            If dr("CDVSN") = "R" Then
                If TCMPCL = dr("TCMPCL") And _
                                                      NOPRCN = dr("NOPRCN") And _
                                                      TMNDA = dr("TMNDA") And _
                                                      NRTFSV = dr("NRTFSV") And _
                                                      SERVICIO = dr("SERVICIO") And _
                                                      TCMTRF = dr("TCMTRF") And _
                                                      IVLSRV = dr("IVLSRV") And _
                                                      QATNAN = dr("QATNAN") And _
                                                      SUB_TOTAL = dr("SUB_TOTAL") And _
                                                      NCRROP = dr("NCRROP") And _
                                                      SESTRG_SERV = dr("SESTRG_SERV") Then
                    blExiste = True
                End If
            Else
                If TCMPCL = dr("TCMPCL") And _
                                                                      NOPRCN = dr("NOPRCN") And _
                                                                      TMNDA = dr("TMNDA") And _
                                                                      NRTFSV = dr("NRTFSV") And _
                                                                      SERVICIO = dr("SERVICIO") And _
                                                                      TCMTRF = dr("TCMTRF") And _
                                                                      IVLSRV = dr("IVLSRV") And _
                                                                      QATNAN = dr("QATNAN") And _
                                                                      SUB_TOTAL = dr("SUB_TOTAL") Then
                    blExiste = True
                End If
            End If


            nCount += 1

            If blExiste And nCount > 1 Then
                Continue For

            Else
                oDtResumenAlmacen.ImportRow(dr)
            End If
            TCMPCL = dr("TCMPCL")
            NOPRCN = dr("NOPRCN")
            TMNDA = dr("TMNDA")
            NRTFSV = dr("NRTFSV")
            SERVICIO = dr("SERVICIO")
            TCMTRF = dr("TCMTRF")
            IVLSRV = dr("IVLSRV")
            QATNAN = dr("QATNAN")
            SUB_TOTAL = dr("SUB_TOTAL")
            NCRROP = dr("NCRROP")
            If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
        Next



        oDtDetalle = oDtResumenAlmacen
        '=============================================================================
        TCMPCL = ""
        NOPRCN = ""
        TMNDA = ""
        NRTFSV = ""
        SERVICIO = ""
        TCMTRF = ""
        IVLSRV = ""
        QATNAN = ""
        SUB_TOTAL = ""
        SESTRG_SERV = ""

        For i As Integer = 0 To oDtDetalle.Rows.Count - 1
            blExiste = False
            blExisteOper = False
            If i = 0 Then
                TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
                NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

            End If
            If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then

                If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                      NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                      TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                      NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                      SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                      TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                      IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                      SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV") Then
                    blExiste = True
                End If
            Else

                If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                      NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                      TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                      NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                      SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                      TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                      IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                      QATNAN = oDtDetalle.Rows(i).Item("QATNAN") And _
                      SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL") Then
                    blExiste = True
                End If
            End If

            If NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") Then
                blExisteOper = True
            End If




            TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
            NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
            TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
            NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
            SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
            TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
            IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
            QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
            SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
            If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

            If blExisteOper And i > 0 Then
                oDtDetalle.Rows(i).Item("NOPRCN") = 0
            End If


            If blExiste And i > 0 Then
                oDtDetalle.Rows(i).Item("TCMPCL") = ""
                oDtDetalle.Rows(i).Item("TIPRO") = ""
                oDtDetalle.Rows(i).Item("NRTFSV") = 0
                oDtDetalle.Rows(i).Item("SERVICIO") = ""
                oDtDetalle.Rows(i).Item("TCMTRF") = ""

                oDtDetalle.AcceptChanges()
            End If

        Next

        With oDtDetalle
            If .Columns("cclnt") IsNot Nothing Then .Columns.Remove("cclnt")
            If .Columns("ccmpn") IsNot Nothing Then .Columns.Remove("ccmpn")
            If .Columns("cdvsn") IsNot Nothing Then .Columns.Remove("cdvsn")
            If .Columns("SESTRG") IsNot Nothing Then .Columns.Remove("SESTRG")
            If .Columns("TIPO_CAMBIO") IsNot Nothing Then .Columns.Remove("TIPO_CAMBIO")

            If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
            If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
            If .Columns("NSECFC") IsNot Nothing Then .Columns.Remove("NSECFC")



            If .Columns("CREFFW") IsNot Nothing Then .Columns.Remove("CREFFW")
            If .Columns("NCRRDC") IsNot Nothing Then .Columns.Remove("NCRRDC")
            If .Columns("NDIAPL") IsNot Nothing Then .Columns.Remove("NDIAPL")
            If .Columns("DESCWB") IsNot Nothing Then .Columns.Remove("DESCWB")
            If .Columns("TUBRFR") IsNot Nothing Then .Columns.Remove("TUBRFR")
            If .Columns("QREFFW") IsNot Nothing Then .Columns.Remove("QREFFW")
            If .Columns("TIPBTO") IsNot Nothing Then .Columns.Remove("TIPBTO")
            If .Columns("QPSOBL") IsNot Nothing Then .Columns.Remove("QPSOBL")
            If .Columns("TUNPSO") IsNot Nothing Then .Columns.Remove("TUNPSO")
            If .Columns("QVLBTO") IsNot Nothing Then .Columns.Remove("QVLBTO")
            If .Columns("TUNVOL") IsNot Nothing Then .Columns.Remove("TUNVOL")
            If .Columns("NSRCN1") IsNot Nothing Then .Columns.Remove("NSRCN1")
            If .Columns("CPRCN1") IsNot Nothing Then .Columns.Remove("CPRCN1")

            If .Columns("PROVEEDOR") IsNot Nothing Then .Columns.Remove("PROVEEDOR")
            If .Columns("RUC") IsNot Nothing Then .Columns.Remove("RUC")
            If .Columns("COD") IsNot Nothing Then .Columns.Remove("COD")
            If .Columns("DOCUMENTO") IsNot Nothing Then .Columns.Remove("DOCUMENTO")
            If .Columns("NUMERO_DOC") IsNot Nothing Then .Columns.Remove("NUMERO_DOC")
            If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")


            If .Columns("CORR") IsNot Nothing Then .Columns.Remove("CORR")
            If .Columns("FECHA") IsNot Nothing Then .Columns.Remove("FECHA")
            If .Columns("PESO") IsNot Nothing Then .Columns.Remove("PESO")
            If .Columns("VOLUMEN") IsNot Nothing Then .Columns.Remove("VOLUMEN")
            If .Columns("AREA") IsNot Nothing Then .Columns.Remove("AREA")





            .Columns("TCMPCL").SetOrdinal(0)
            .Columns("NOPRCN").SetOrdinal(1)
            .Columns("TIPRO").SetOrdinal(2)
            .Columns("NRTFSV").SetOrdinal(3)
            .Columns("SERVICIO").SetOrdinal(4)
            .Columns("TCMTRF").SetOrdinal(5)
            .Columns("QATNAN").SetOrdinal(6)
            .Columns("IVLSRV").SetOrdinal(7)
            .Columns("TMNDA").SetOrdinal(8)
            .Columns("SUB_TOTAL").SetOrdinal(9)
            .Columns("SESTRG_SERV").SetOrdinal(10)


            .Columns("TCMPCL").ColumnName = "Cliente"
            .Columns("NOPRCN").ColumnName = "Operacion"
            .Columns("TIPRO").ColumnName = "Proceso"
            .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
            .Columns("SERVICIO").ColumnName = "Tipo Servicio"
            .Columns("TCMTRF").ColumnName = "Servicio"
            .Columns("QATNAN").ColumnName = "Cantidad"
            .Columns("IVLSRV").ColumnName = "Importe tarifa"
            .Columns("TMNDA").ColumnName = "Moneda"
            .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
            .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
            If .Columns("TSRVC") IsNot Nothing Then .Columns("TSRVC").ColumnName = "Observación"
            If .Columns("OBSERVACION") IsNot Nothing Then .Columns("OBSERVACION").ColumnName = "Observación"
            .Columns.Remove("Cliente")
            If .Columns("FOPRCN") IsNot Nothing Then .Columns.Remove("FOPRCN")
            If .Columns("FATNSR") IsNot Nothing Then .Columns.Remove("FATNSR")
            If .Columns("NCRROP") IsNot Nothing Then .Columns.Remove("NCRROP")
        End With
        oDtDetalle.TableName = "Servicio"
        Return oDtDetalle
    End Function
    Private Function pExportarSustentoFacturado(ByVal obj_Servicio As Servicio_BE, ByVal strTipoRep As String) As DataSet
        Dim oDs As New DataSet
        Dim oDtRep As New DataTable
        Dim oDtRepTarif As New DataTable
        Dim oDtRepServTarif As New DataTable
        Dim oDtRepFiltros As New DataTable
        Dim oDtTempFiltro As New DataTable
        Dim posFiltros As Integer = 0
        Dim oDr As DataRow
        Dim lastOrdinal As Integer = 0
        Dim nombreColmun As String = ""
        Dim tipoColumn As String = ""
        Dim cadenaWhere As String = ""
        Dim subTotalAcum As Double = 0D
        Dim z As Integer = 0
        Dim x As Integer = 0
        'Dim oDsAdd As New DataSet
        Dim oServicioAtendidoNeg As New clsServicio_BL

        Try
            '===================
            Dim oServicioAtendido As New Servicio_BE
            oServicioAtendido.NSECFC = obj_Servicio.NSECFC
            oServicioAtendido.CTPALJ = IIf(cmbDivision.SelectedValue = "S", "SL", obj_Servicio.CTPALJ)
            oDtRep = oServicioAtendidoNeg.DetalleFactura(oServicioAtendido)

            '=============================
            Dim obj_Logica As New Ransa.Controls.ServicioOperacion.clsConsistencia_BL

            Dim guia As String = ""
            Dim nCountGuia As Integer = 0
            Dim dtGuia As New DataTable
            Dim drAux As DataRow
            dtGuia = oDtRep.Clone

            If obj_Servicio.CTPALJ <> "RE" And obj_Servicio.CDVSN = "R" Then

                For i As Integer = 0 To oDtRep.Rows.Count - 1

                    nCountGuia = 0
                    drAux = dtGuia.NewRow()
                    drAux("CREFFW") = oDtRep.Rows(i).Item("CREFFW")
                    drAux("NSEQIN") = oDtRep.Rows(i).Item("NSEQIN")

                    drAux("QPSOBL") = oDtRep.Rows(i).Item("QPSOBL")
                    dtGuia.Rows.Add(drAux)
                    For Each drGuia As DataRow In dtGuia.Select("CREFFW='" & oDtRep.Rows(i).Item("CREFFW") & "'AND QPSOBL > 0 AND NSEQIN=" & oDtRep.Rows(i).Item("NSEQIN"))
                        nCountGuia += 1
                        If nCountGuia > 1 Then Exit For
                    Next
                    If nCountGuia > 1 Then oDtRep.Rows(i).Item("QPSOBL") = 0.0
                    oDtRep.AcceptChanges()
                Next

            End If


            obj_Servicio.CMNDA1 = 100
            obj_Servicio.FULTAC = Format(Now, "yyyyMMdd")

            obj_Servicio.CCLNT = UcCliente.pCodigo
            obj_Servicio.CCMPN = cmbCompania.SelectedValue
            obj_Servicio.CDVSN = cmbDivision.SelectedValue
            obj_Servicio.CPLNDV = cmbPlanta.SelectedValue
            obj_Servicio.NSECFC = obj_Servicio.NSECFC
            obj_Servicio.FLGPEN = "S"
            obj_Servicio.STPODP = obj_Servicio.STPODP
            obj_Servicio.CTPALJ = obj_Servicio.CTPALJ

            Dim objDt As New DataTable

            objDt = obj_Logica.Lista_Detalle_Servicios_Almacen(obj_Servicio)

            tipo_cambio = obj_Logica.Obtener_Tipo_Cambio(obj_Servicio)

            '===================


            '' ''Buscamos Las tarifas existentes en la consistencia
            Dim oDtv As New DataView(oDtRep.Copy)
            oDtv.Sort = "NSECFC ASC, TDSDES DESC"
            oDtRepServTarif = oDtv.ToTable(True, "NRTFSV", "IVLSRV", "NRSRRB", "NRRUBR", "NOMSER", "TDSDES")
            '' ''Le damos el nombre de columna a los captions'' ''
            For i As Integer = 0 To oDtRep.Columns.Count - 1
                oDtRep.Columns(i).Caption = oDtRep.Columns(i).ColumnName.ToString
            Next

            Dim rowsDinamic As Integer = oDtRep.Rows.Count

            If obj_Servicio.CTPALJ <> "RE" Then

                If obj_Servicio.CDVSN = "S" Then

                    lastOrdinal = 28

                    'Creamos La cantidad de Columnas Como Servicios Existan
                    For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                        nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                        tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                        oDtRep.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                        oDtRep.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                        oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                        oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                    Next
                    lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                    oDtRep.Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

                    With oDtRep
                        '===Ordenamos las Columnas y Seteamos sus nombres===


                        .Columns("FECINI").ColumnName = "Fecha Inicio Servicio"
                        .Columns("FECFIN").ColumnName = "Fecha Fin Servicio"
                        .Columns("TMNDA").ColumnName = "Moneda"
                        .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                        .Columns("NOMSER").ColumnName = "Tipo Servicio"
                        .Columns("TCMTRF").ColumnName = "Servicio"
                        .Columns("NORSCI").ColumnName = "Embarque"
                        .Columns("NDOCEM").ColumnName = "Doc. Embarque"
                        .Columns("CZNFCC").ColumnName = "Cod. Zona"
                        .Columns("TZNFCC").ColumnName = "Zona"
                        .Columns("PNNMOS").ColumnName = "O/S"
                        .Columns("TNRODU").ColumnName = "DUA"
                        .Columns("TCANAL").ColumnName = "Canal"
                        .Columns("CMEDTR").ColumnName = "Medio Transporte"
                        .Columns("CPAIS").ColumnName = "Cod. Pais"
                        .Columns("TCMPPS").ColumnName = "Pais"
                        .Columns("TCMPVP").ColumnName = "Nave"
                        .Columns("FAPREV").ColumnName = "ETD"
                        .Columns("FAPRAR").ColumnName = "ETA"
                        .Columns("FORSCI").ColumnName = "Fec. Apertura"
                        .Columns("REGIMEN").ColumnName = "REGIMEN"
                        .Columns("DESPACHO").ColumnName = "DESPACHO"
                        .Columns("TRANSPORTE").ColumnName = "TRANSPORTE"
                    End With

                Else
                    With oDtRep
                        '=====================Detalle de bultos===============
                        '===Ordenamos las Columnas y Seteamos sus nombres===
                        .Columns("NSECFC").SetOrdinal(0)
                        .Columns("NOPRCN").SetOrdinal(1)
                        .Columns("TDSDES").SetOrdinal(2)

                        .Columns("FECINI").SetOrdinal(3)
                        .Columns("FECINI").ColumnName = "Fecha Inicio Servicio"

                        .Columns("CREFFW").SetOrdinal(4)


                        .Columns("DESCWB").SetOrdinal(5)
                        .Columns("DESCWB").ColumnName = "Referencia de Mercaderia"

                        .Columns("QREFFW").SetOrdinal(6)
                        .Columns("QREFFW").ColumnName = "Cantidad de Bulto"

                        .Columns("TIPBTO").SetOrdinal(7)
                        .Columns("TIPBTO").ColumnName = "Tipo de Bulto"

                        .Columns("NORCML").SetOrdinal(8) 'orden de compra

                        .Columns("QPSOBL").SetOrdinal(9)
                        .Columns("QPSOBL").ColumnName = "Peso (Kgs). Bulto"

                        .Columns("TCTCST").SetOrdinal(10)
                        .Columns("TCTCST").ColumnName = "C.I Terrestre"

                        .Columns("TCTCSA").SetOrdinal(11)
                        .Columns("TCTCSA").ColumnName = "C.I Fluvial"

                        .Columns("TCTCSF").SetOrdinal(12)
                        .Columns("TCTCSF").ColumnName = "C.I Aereo"


                        If strTipoRep = "I" Then

                            '=======================================================
                            .Columns("NRITOC").SetOrdinal(13) 'item
                            .Columns("TDITES").SetOrdinal(14)
                            .Columns("TDITES").ColumnName = "Descripción"
                            .Columns("TLUGEN").SetOrdinal(15)
                            .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                            .Columns("QBLTSR").SetOrdinal(16)
                            .Columns("QBLTSR").ColumnName = "Cantidad Item"
                            '========================================================

                            .Columns("GUIA").SetOrdinal(17)
                            .Columns("GUIA").ColumnName = "Guía"

                            .Columns("CHOFER").SetOrdinal(18)
                            .Columns("CHOFER").ColumnName = "Chofer / Proveedor"
                            .Columns("PLACA").SetOrdinal(19)
                            .Columns("PLACA").ColumnName = "Placa"
                            .Columns("UNIDAD").SetOrdinal(20)
                            .Columns("UNIDAD").ColumnName = "Unidad"

                            lastOrdinal = 21

                        Else
                            .Columns("GUIA").SetOrdinal(13)
                            .Columns("GUIA").ColumnName = "Guía"
                            .Columns("CHOFER").SetOrdinal(14)
                            .Columns("CHOFER").ColumnName = "Chofer / Proveedor"
                            .Columns("PLACA").SetOrdinal(15)
                            .Columns("PLACA").ColumnName = "Placa"
                            .Columns("UNIDAD").SetOrdinal(16)
                            .Columns("UNIDAD").ColumnName = "Unidad"

                            lastOrdinal = 17
                        End If


                        'Creamos La cantidad de Columnas Como Servicios Existan
                        For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                            nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                            tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                            .Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                            .Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                            oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                            oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                        Next
                        lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                        .Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

                        .Columns("TMNDA").SetOrdinal(lastOrdinal + 2)
                        .Columns("CCLNT").SetOrdinal(lastOrdinal + 3)
                        .Columns("NRTFSV").SetOrdinal(lastOrdinal + 4)
                        .Columns("FECHA").SetOrdinal(lastOrdinal + 5)
                        .Columns("QATNAN").SetOrdinal(lastOrdinal + 6)
                        .Columns("TOTAL").SetOrdinal(lastOrdinal + 7)
                        .Columns("NRSRRB").SetOrdinal(lastOrdinal + 8)
                        .Columns("SERVICIO").SetOrdinal(lastOrdinal + 9)
                        .Columns("IVLSRV").SetOrdinal(lastOrdinal + 10)

                    End With
                End If

            Else

                'Creamos La cantidad de Columnas Como Servicios Existan
                lastOrdinal = 16
                For i As Integer = 0 To oDtRepServTarif.Rows.Count - 1
                    nombreColmun = i.ToString & "-" & oDtRepServTarif.Rows(i).Item("NOMSER")
                    tipoColumn = oDtRepServTarif.Rows(i).Item("NRTFSV") & "-" & oDtRepServTarif.Rows(i).Item("TDSDES")
                    oDtRep.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(lastOrdinal + i)
                    oDtRep.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                    oDtRepTarif.Columns.Add(nombreColmun.Trim, GetType(System.Double)).SetOrdinal(i)
                    oDtRepTarif.Columns(nombreColmun.Trim).Caption = tipoColumn.Trim
                Next
                lastOrdinal = lastOrdinal + oDtRepServTarif.Rows.Count
                oDtRep.Columns.Add("SubTotal", GetType(System.Double)).SetOrdinal(lastOrdinal)

            End If
            '' '' Cargamos las tarifas '' ''
            oDr = oDtRepTarif.NewRow
            For i As Integer = 0 To oDtRepTarif.Columns.Count - 1
                cadenaWhere = "NRTFSV = " & oDtRepTarif.Columns(i).Caption.ToString.Split("-")(0)
                oDr(i) = filtraDatatable(oDtRepServTarif, cadenaWhere).Rows(0).Item("IVLSRV")
                cadenaWhere = ""
            Next
            oDtRepTarif.Rows.Add(oDr)
            '' '' Buscamos las cantidades y pintamos en columnas correspondientes'' ''
            For i As Integer = 0 To oDtRep.Rows.Count - 1
                cadenaWhere = "NSECFC= " & oDtRep.Rows(i).Item("NSECFC") & " AND NOPRCN = " & oDtRep.Rows(i).Item("NOPRCN") '& " AND NRTFSV = " & oDtRep.Rows(i).Item("NRTFSV")
                oDtRepFiltros = oDtRep.Copy
                oDtRepFiltros.DefaultView.RowFilter = cadenaWhere
                oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable()
                posFiltros = oDtRepFiltros.Rows.Count
                oDtRepFiltros = oDtRepFiltros.DefaultView.ToTable(True, "NSECFC", "NOPRCN", "NRTFSV", "IVLSRV", "QATNAN", "TDSDES", "NCRROP") 'Encontramos las tarifas asociadas ala operacion
                If oDtRepFiltros.Rows.Count > 0 Then 'Pintamos en caso sea mayor a 0 
                    For j As Integer = 0 To oDtRepFiltros.Rows.Count - 1 'Empezamos la busqueda de su columna segun cantidad de tarifas encontradas
                        For k As Integer = (lastOrdinal - oDtRepServTarif.Rows.Count) To lastOrdinal 'Buscamos dentro de las columnas creadas dinamicamente
                            If CInt(oDtRep.Columns(k).Caption.ToString.Split("-")(0)) = oDtRepFiltros.Rows(j).Item("NRTFSV") And _
                                oDtRep.Columns(k).Caption.ToString.Split("-")(1).Trim = oDtRepFiltros.Rows(j).Item("TDSDES").ToString.Trim Then 'Lo encuentra comparando con el caption

                                If Val("" & oDtRep.Rows(i).Item(k) & "") = 0 Then ' si el registro no tiene ningun valor, se asigna el valor y se acumula el subtotal
                                    oDtRep.Rows(i).Item(k) = oDtRepFiltros.Rows(j).Item("QATNAN")
                                    subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                Else ' si registro ya tiene un valor, es pq son del mismo servicio asi es q al sub total se le quita el valor anterior y se suma el nuevo valor acumulado
                                    subTotalAcum = subTotalAcum - (oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV"))
                                    oDtRep.Rows(i).Item(k) = Val("" & oDtRep.Rows(i).Item(k) & "") + oDtRepFiltros.Rows(j).Item("QATNAN")
                                    subTotalAcum = subTotalAcum + oDtRep.Rows(i).Item(k) * oDtRepFiltros.Rows(j).Item("IVLSRV") 'Sumamos para obtener el Subtotal
                                End If

                                Exit For
                            End If
                        Next
                    Next
                    oDtRep.Rows(i).Item("SubTotal") = subTotalAcum
                    subTotalAcum = 0
                End If
                i = i + posFiltros - 1 'Nos ubicamos en la siguiente operacion
            Next


            '' '' ---------------------------------------------------------------------
            '' '' ---------------------QUITAMOS LOS ROWS REPETIDOS---------------------

            cadenaWhere = ""
            If obj_Servicio.CDVSN <> "S" Then

                With oDtRep

                    If obj_Servicio.CTPALJ <> "RE" Then

                        '============Registros eliminados por item===========================
                        If strTipoRep = "I" Then
                            While z < rowsDinamic
                                x = rowsDinamic - 1
                                cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & " AND CREFFW ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & "' AND NSEQIN = " & oDtRep.Rows(x).Item("NSEQIN").ToString.Trim & " And NORCML='" & oDtRep.Rows(x).Item("NORCML").ToString.Trim & "' AND NRITOC = '" & oDtRep.Rows(x).Item("NRITOC").ToString.Trim & "'"
                                oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
                                If oDtTempFiltro.Rows.Count > 1 Then
                                    oDtRep.Rows.RemoveAt(x)
                                End If
                                rowsDinamic -= 1
                            End While
                        Else
                            '=============Registros por orden de compra=======================
                            While z < rowsDinamic
                                x = rowsDinamic - 1
                                cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & _
                                " AND TRIM(CREFFW) ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & _
                                "' AND NSEQIN = " & oDtRep.Rows(x).Item("NSEQIN").ToString.Trim & _
                                " And NORCML='" & oDtRep.Rows(x).Item("NORCML").ToString.Trim & "'"



                                oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
                                If oDtTempFiltro.Rows.Count > 1 Then
                                    oDtRep.Rows.RemoveAt(x)
                                End If
                                rowsDinamic -= 1
                            End While
                        End If

                    Else

                        '===Ordenamos las Columnas y Seteamos sus nombres===


                        .Columns("FECINI").ColumnName = "Fecha Inicio Servicio"
                        .Columns("FECFIN").ColumnName = "Fecha Fin Servicio"
                        .Columns("TDSDES").ColumnName = "Tipo Proceso"
                        .Columns("TLUGEN").ColumnName = "LOTE"



                    End If

                End With
            End If


            With oDtRep
                '    '===Seteamos sus nombres a las columnas que usan llaves===
                If Not .Columns("TDSDES") Is Nothing Then .Columns("TDSDES").ColumnName = "Tipo de Servicio"
                If Not .Columns("NORCML") Is Nothing Then .Columns("NORCML").ColumnName = "Orden de Compra"
                If Not .Columns("NRITOC") Is Nothing Then .Columns("NRITOC").ColumnName = "Item"


                .Columns("NOPRCN").ColumnName = "Operación"
                If Not .Columns("CREFFW") Is Nothing Then .Columns("CREFFW").ColumnName = "Bulto"
                .Columns("NRTFSV").ColumnName = "Código de Tarifa"
                .Columns("IVLSRV").ColumnName = "Importe tarifa"
                .Columns("QATNAN").ColumnName = "Cantidad"

                .Columns.Remove("NSECFC")
                .Columns.Remove("NCRROP")
                If Not .Columns("NSEQIN") Is Nothing Then .Columns.Remove("NSEQIN")


            End With


            oDtRep.TableName = "Detalles"
            If obj_Servicio.CTPALJ <> "RE" And obj_Servicio.CDVSN = "R" Then
                oDs.Tables.Add(ResumenTableDetalle(oDtRep).Copy)
            Else
                oDs.Tables.Add(oDtRep.Copy)
            End If

            oDtRepTarif.TableName = "Tarifas"
            oDs.Tables.Add(oDtRepTarif)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return oDs
    End Function


    Private Sub EmitirReporteExcel(ByVal objDs As DataSet, ByVal obj_Servicio As Servicio_BE, ByVal tipoReporte As TipoReporte)
        Dim odsExcel As New DataSet
        Dim oDtDetalle As DataTable = objDs.Tables(0)
        Dim oDtFiltro As DataTable = objDs.Tables(1)
        Dim oDtResumen As DataTable = objDs.Tables(2)
        Dim oDtResLote As New DataTable

        Dim oDtResumenAlmacen As New DataTable
        Dim drResumen As DataRow
        Dim blExisteAlmacen As Boolean = False
        oDtResumenAlmacen = oDtDetalle.Clone

        Dim oDtReemb As DataTable = Nothing



        '===PARA EL DETALLE===
        Select Case obj_Servicio.CDVSN
            Case "R"
                oDtResLote = objDs.Tables(4)
                Select Case obj_Servicio.STPODP
                    Case "", "7"
                        '==========ALMACEN============
                        If Not chkDetallado.Checked Then

                            If obj_Servicio.CTPALJ = "RE" Then
                                If Not oDtDetalle.Columns("QATNRL") Is Nothing Then
                                    oDtDetalle.Columns.Remove("QATNRL")
                                End If
                            End If
                            oDtDetalle = ResumenTable(oDtDetalle, tipoReporte)
                            oDtDetalle.TableName = "Servicio"

                        Else

                            If Not obj_Servicio.CTPALJ = "RE" Then
                                oDtDetalle = DeleteRowsRepits(oDtDetalle)
                            Else
                                oDtReemb = oDtDetalle.Copy
                                oDtReemb = EmitirReporteExcelReembolso(oDtReemb)
                            End If



                            With oDtDetalle

                                Dim otblAlm As New DataTable
                                otblAlm = oDtDetalle

                                Dim TCMPCL As String = ""
                                Dim NOPRCN As String = ""
                                Dim TMNDA As String = ""
                                Dim NRTFSV As String = ""
                                Dim SERVICIO As String = ""
                                Dim TCMTRF As String = ""
                                Dim IVLSRV As String = "" 'tarida
                                Dim QATNAN As Decimal = 0 'cantidad
                                Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                                Dim sQATNAN As String = "" 'cantidad
                                Dim sSUB_TOTAL As String = "" 'monto a cobrar
                                Dim SESTRG_SERV As String = ""
                                Dim NCRROP As String = ""
                                Dim CREFFW As String = ""

                                Dim blExiste As Boolean = False
                                Dim blExisteOper As Boolean = False
                                Dim blExisteBulto As Boolean = False



                                For i As Integer = 0 To otblAlm.Rows.Count - 1


                                    blExiste = False
                                    blExisteOper = False
                                    blExisteBulto = False

                                    If i = 0 Then
                                        TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                                        NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                                        TMNDA = otblAlm.Rows(i).Item("TMNDA")
                                        NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                                        SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                                        TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                                        IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                                        sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                                        sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                                        SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                                        NCRROP = otblAlm.Rows(i).Item("NCRROP")
                                        If obj_Servicio.CTPALJ <> "RE" Then CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim

                                    End If

                                    If Not obj_Servicio.CTPALJ = "RE" Then
                                        If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                              NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                              TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                              NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                                              SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                              TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                              IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                              SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") And _
                                                              sQATNAN = otblAlm.Rows(i).Item("QATNAN") And _
                                                              NCRROP = otblAlm.Rows(i).Item("NCRROP") And _
                                                              sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL") Then
                                            blExiste = True
                                        End If
                                    Else
                                        If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                                                  NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                                                  TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                                                  NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                                                                  SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                                                  TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                                                  IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                                                  SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") Then
                                            blExiste = True
                                        End If
                                    End If


                                    If NOPRCN = otblAlm.Rows(i).Item("NOPRCN") Then
                                        blExisteOper = True
                                    End If


                                    If obj_Servicio.CTPALJ <> "RE" Then

                                        If CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim Then
                                            blExisteBulto = True
                                        End If

                                    End If



                                    TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                                    NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                                    TMNDA = otblAlm.Rows(i).Item("TMNDA")
                                    NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                                    SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                                    TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                                    IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                                    sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                                    sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                                    SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                                    NCRROP = otblAlm.Rows(i).Item("NCRROP")
                                    If obj_Servicio.CTPALJ <> "RE" Then CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim

                                    If blExisteOper And i > 0 Then
                                        otblAlm.Rows(i).Item("NOPRCN") = 0
                                        otblAlm.Rows(i).Item("TIPRO") = ""
                                        otblAlm.Rows(i).Item("TRDCCL") = ""
                                    End If

                                    '======Se limpia los los datos del bulto y sus items===============
                                    If obj_Servicio.CTPALJ <> "RE" Then
                                        If blExisteOper And blExisteBulto And i > 0 Then

                                            otblAlm.Rows(i).Item("CREFFW") = "" 'bulto
                                            'otblAlm.Rows(i).Item("OC") = "" ' orden de compra
                                            otblAlm.Rows(i).Item("NCRRDC") = 0 ' corrida
                                            otblAlm.Rows(i).Item("NDIAPL") = 0 ' dias
                                            otblAlm.Rows(i).Item("DESCWB") = "" 'des bulto
                                            otblAlm.Rows(i).Item("QREFFW") = 0 'cantidad de bulto
                                            otblAlm.Rows(i).Item("TIPBTO") = "" 'tipo bulto
                                            otblAlm.Rows(i).Item("QPSOBL") = 0 'cantidad peso
                                            otblAlm.Rows(i).Item("TUNPSO") = "" 'unidad peso

                                        End If
                                    End If


                                    If blExiste And i > 0 Then
                                        If Not obj_Servicio.CTPALJ = "RE" Then
                                            otblAlm.Rows(i).Item("TCMPCL") = ""
                                            otblAlm.Rows(i).Item("TMNDA") = ""
                                            otblAlm.Rows(i).Item("NRTFSV") = 0
                                            otblAlm.Rows(i).Item("SERVICIO") = ""
                                            otblAlm.Rows(i).Item("TCMTRF") = ""
                                            otblAlm.Rows(i).Item("IVLSRV") = 0
                                            otblAlm.Rows(i).Item("QATNAN") = 0
                                            If Not otblAlm.Columns("QATNRL") Is Nothing Then
                                                otblAlm.Rows(i).Item("QATNRL") = 0
                                            End If


                                            otblAlm.Rows(i).Item("SUB_TOTAL") = 0
                                            otblAlm.Rows(i).Item("SESTRG_SERV") = ""
                                            otblAlm.Rows(i).Item("TRFSRC") = ""
                                            otblAlm.AcceptChanges()
                                        Else
                                            otblAlm.Rows(i).Item("TCMPCL") = ""
                                            otblAlm.Rows(i).Item("SERVICIO") = ""
                                            otblAlm.Rows(i).Item("TCMTRF") = ""
                                            otblAlm.Rows(i).Item("NRTFSV") = 0


                                            otblAlm.AcceptChanges()
                                        End If


                                    End If

                                Next
                                oDtDetalle = otblAlm
                                '================================================

                                If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
                                'If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
                                If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")
                                'If .Columns("ALMACEN") IsNot Nothing Then .Columns.Remove("ALMACEN")

                                Dim intX As Integer = 0
                                .Columns("TCMPCL").SetOrdinal(intX)
                                intX += 1
                                .Columns("NOPRCN").SetOrdinal(intX)
                                intX += 1
                                .Columns("FOPRCN").SetOrdinal(intX)
                                intX += 1
                                .Columns("TIPRO").SetOrdinal(intX)
                                intX += 1

                                .Columns("TRDCCL").SetOrdinal(intX)
                                intX += 1

                                .Columns("NRTFSV").SetOrdinal(intX)
                                intX += 1
                                .Columns("SERVICIO").SetOrdinal(intX)
                                intX += 1
                                .Columns("TCMTRF").SetOrdinal(intX)
                                intX += 1
                                .Columns("FATNSR").SetOrdinal(intX)
                                intX += 1
                                .Columns("QATNAN").SetOrdinal(intX)
                                intX += 1
                                If Not .Columns("QATNRL") Is Nothing Then

                                    .Columns("QATNRL").SetOrdinal(intX)
                                    .Columns("QATNRL").ColumnName = "Cantidad real"
                                    intX += 1
                                End If
                                .Columns("IVLSRV").SetOrdinal(intX)
                                intX += 1
                                .Columns("TMNDA").SetOrdinal(intX)
                                intX += 1
                                .Columns("SUB_TOTAL").SetOrdinal(intX)
                                intX += 1
                                .Columns("SESTRG_SERV").SetOrdinal(intX)
                                intX += 1

                                .Columns("TCMPCL").ColumnName = "Cliente"
                                .Columns("NOPRCN").ColumnName = "Operacion"
                                .Columns("FOPRCN").ColumnName = "Fecha de Operación"
                                .Columns("TIPRO").ColumnName = "Proceso"
                                .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                                .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                                .Columns("TCMTRF").ColumnName = "Servicio"

                                .Columns("FATNSR").ColumnName = "Fecha de Servicio"

                                .Columns("TRDCCL").ColumnName = "Referencia Operación"
                                .Columns("QATNAN").ColumnName = "Cantidad"
                                .Columns("IVLSRV").ColumnName = "Importe tarifa"
                                .Columns("TMNDA").ColumnName = "Moneda"
                                .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                                .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"

                                If cmbTipoServicio.SelectedValue = Estatico.E_ESP_General Or _
                                                                  cmbTipoServicio.SelectedValue = Estatico.E_ESP_AlmacenajePeso Or _
                                                                  cmbTipoServicio.SelectedValue = Estatico.E_ESP_ManipuleoPeso Or _
                                                                  cmbTipoServicio.SelectedValue = Estatico.E_ESP_Permanencia Then


                                    .Columns("CREFFW").SetOrdinal(intX)
                                    .Columns("CREFFW").ColumnName = "Bulto"
                                    intX += 1

                                    .Columns("FREFFW").SetOrdinal(intX)
                                    .Columns("FREFFW").ColumnName = "Fecha de recepción"
                                    intX += 1

                                    .Columns("NCRRDC").SetOrdinal(intX)
                                    .Columns("NCRRDC").ColumnName = "Corr"
                                    intX += 1

                                    .Columns("NDIAPL").SetOrdinal(intX)
                                    .Columns("NDIAPL").ColumnName = "Dias"
                                    intX += 1

                                    .Columns("DESCWB").SetOrdinal(intX)
                                    .Columns("DESCWB").ColumnName = "Descripcion Bulto"
                                    intX += 1

                                    .Columns("QREFFW").SetOrdinal(intX)
                                    .Columns("QREFFW").ColumnName = "Cantidad Bulto"
                                    intX += 1

                                    .Columns("TIPBTO").SetOrdinal(intX)
                                    .Columns("TIPBTO").ColumnName = "Tipo Bulto"
                                    intX += 1

                                    .Columns("QPSOBL").SetOrdinal(intX)
                                    .Columns("QPSOBL").ColumnName = "Cantidad peso"
                                    intX += 1

                                    .Columns("QAROCP").SetOrdinal(intX)
                                    .Columns("QAROCP").ColumnName = "M2"
                                    intX += 1

                                    .Columns("ALMACEN").SetOrdinal(intX)
                                    .Columns("ALMACEN").ColumnName = "Tipo de almacen "
                                    intX += 1

                                    .Columns("TUNPSO").SetOrdinal(intX)
                                    .Columns("TUNPSO").ColumnName = "Unidad  Peso"
                                    intX += 1

                                    .Columns("TCTCST").SetOrdinal(intX)
                                    .Columns("TCTCST").ColumnName = "C.I Terrestre"
                                    intX += 1

                                    .Columns("TCTCSA").SetOrdinal(intX)
                                    .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                                    intX += 1

                                    .Columns("TCTCSF").SetOrdinal(intX)
                                    .Columns("TCTCSF").ColumnName = "C.I Aereo"
                                    intX += 1

                                    .Columns("OC").SetOrdinal(intX)
                                    .Columns("OC").ColumnName = "O/C"
                                    intX += 1

                                    .Columns("NORAGN").SetOrdinal(intX)
                                    .Columns("NORAGN").ColumnName = "N°Orden Servicio - Agencia"
                                    intX += 1

                                    .Columns("NRITOC").SetOrdinal(intX)
                                    .Columns("NRITOC").ColumnName = "Item"
                                    intX += 1

                                    .Columns("TDITES").SetOrdinal(intX)
                                    .Columns("TDITES").ColumnName = "Descripción"
                                    intX += 1

                                    .Columns("TLUGEN").SetOrdinal(intX)
                                    .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                                    intX += 1

                                    .Columns("QBLTSR").SetOrdinal(intX)
                                    .Columns("QBLTSR").ColumnName = "Cantidad Item"
                                    intX += 1

                                    .Columns("TUBRFR").SetOrdinal(intX)
                                    .Columns("TUBRFR").ColumnName = "Almacen"
                                    intX += 1

                                    .Columns("QVLBTO").SetOrdinal(intX)
                                    .Columns("QVLBTO").ColumnName = "Cantidad Volumen "
                                    intX += 1


                                    .Columns("TUNVOL").SetOrdinal(intX)
                                    .Columns("TUNVOL").ColumnName = "Unidad de Volumen"
                                    intX += 1

                                    .Columns("LOTE").ColumnName = "Lote"
                                    .Columns("LOTE").SetOrdinal(intX)
                                    intX += 1

                                    .Columns("CI").SetOrdinal(intX)
                                    .Columns("CI").ColumnName = "Cuenta Imputación"
                                    intX += 1

                                    .Columns("NSRCN1").SetOrdinal(intX)
                                    .Columns("NSRCN1").ColumnName = "Serie Contenedor"
                                    intX += 1

                                    .Columns("CPRCN1").SetOrdinal(intX)
                                    .Columns("CPRCN1").ColumnName = "Contenedor"
                                    intX += 1

                                    .Columns("TSRVC").SetOrdinal(intX)
                                    .Columns("TSRVC").ColumnName = "Observación"
                                    intX += 1

                                    .Columns("TRFSRC").SetOrdinal(intX)
                                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                                    intX += 1

                                    If chkDetallado.Checked And Not rbItem.Checked Then
                                        If Not .Columns("NRITOC") Is Nothing Then .Columns.Remove("NRITOC")
                                        If Not .Columns("TDITES") Is Nothing Then .Columns.Remove("TDITES")
                                        If Not .Columns("TLUGEN") Is Nothing Then .Columns.Remove("TLUGEN")
                                        If Not .Columns("QBLTSR") Is Nothing Then .Columns.Remove("QBLTSR")

                                    End If

                                    If Not .Columns("NRITOC") Is Nothing Then .Columns("NRITOC").ColumnName = "Item"
                                    If Not .Columns("TDITES") Is Nothing Then .Columns("TDITES").ColumnName = "Descripción"
                                    If Not .Columns("TLUGEN") Is Nothing Then .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                                    If Not .Columns("QBLTSR") Is Nothing Then .Columns("QBLTSR").ColumnName = "Cantidad Item"
                                    If Not .Columns("TCTCST") Is Nothing Then .Columns("TCTCST").ColumnName = "C.I Terrestre"
                                    If Not .Columns("TCTCSA") Is Nothing Then .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                                    If Not .Columns("TCTCSF") Is Nothing Then .Columns("TCTCSF").ColumnName = "C.I Aereo"
                                    If Not .Columns("NSEQIN") Is Nothing Then .Columns.Remove("NSEQIN")

                                End If

                            End With
                            oDtDetalle.TableName = "Detalle"

                        End If

                    Case "1" 'Deposito Simple

                        Dim NSECFC As String = ""
                        Dim TIPRO As String = ""
                        Dim TCMPCL As String = ""
                        Dim NOPRCN As String = ""
                        Dim TMNDA As String = ""
                        Dim NRTFSV As String = ""
                        Dim SERVICIO As String = ""
                        Dim IVLSRV As String = "" 'tarida
                        Dim QATNAN As Decimal = 0 'cantidad
                        Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                        Dim SESTRG_SERV As String = ""
                        Dim NCRROP As String = String.Empty

                        Dim blExiste As Boolean = False
                        Dim blExisteOper As Boolean = False
                        Dim blExisteRev As Boolean = False

                        With oDtDetalle
                            If Not chkDetallado.Checked Then
                                oDtDetalle = ResumenTable(oDtDetalle, tipoReporte)
                                oDtDetalle.TableName = "Servicio"
                            Else

                                For i As Integer = 0 To .Rows.Count - 1
                                    blExiste = False
                                    blExisteOper = False
                                    blExisteRev = False

                                    If i = 0 Then
                                        TIPRO = .Rows(i).Item("TIPRO")
                                        NSECFC = .Rows(i).Item("NSECFC")
                                        NOPRCN = .Rows(i).Item("NOPRCN")
                                        TMNDA = .Rows(i).Item("TMNDA")
                                        NRTFSV = .Rows(i).Item("NRTFSV")
                                        SERVICIO = .Rows(i).Item("SERVICIO")
                                        IVLSRV = .Rows(i).Item("IVLSRV")
                                        QATNAN = .Rows(i).Item("QATNAN")
                                        SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                        SESTRG_SERV = .Rows(i).Item("SESTRG_SERV")
                                        NCRROP = .Rows(i).Item("NCRROP")

                                    End If


                                    If NOPRCN = .Rows(i).Item("NOPRCN") And _
                                                                TMNDA = .Rows(i).Item("TMNDA") And _
                                                                NRTFSV = .Rows(i).Item("NRTFSV") And _
                                                                SERVICIO = .Rows(i).Item("SERVICIO") And _
                                                                IVLSRV = .Rows(i).Item("IVLSRV") And _
                                                                SESTRG_SERV = .Rows(i).Item("SESTRG_SERV") And _
                                                                QATNAN = .Rows(i).Item("QATNAN") And _
                                                                NCRROP = .Rows(i).Item("NCRROP") And _
                                                                SUB_TOTAL = .Rows(i).Item("SUB_TOTAL") Then

                                        blExiste = True

                                    End If


                                    If NSECFC = .Rows(i).Item("NSECFC") Then
                                        blExisteRev = True
                                    End If

                                    If NOPRCN = .Rows(i).Item("NOPRCN") Then
                                        blExisteOper = True
                                    End If


                                    TIPRO = .Rows(i).Item("TIPRO")
                                    NSECFC = .Rows(i).Item("NSECFC")
                                    NOPRCN = .Rows(i).Item("NOPRCN")
                                    TMNDA = .Rows(i).Item("TMNDA")
                                    NRTFSV = .Rows(i).Item("NRTFSV")
                                    SERVICIO = .Rows(i).Item("SERVICIO")
                                    IVLSRV = .Rows(i).Item("IVLSRV")
                                    QATNAN = .Rows(i).Item("QATNAN")
                                    SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                    SESTRG_SERV = .Rows(i).Item("SESTRG_SERV")
                                    NCRROP = .Rows(i).Item("NCRROP")



                                    If blExisteRev And i > 0 Then
                                        .Rows(i).Item("NSECFC") = 0
                                    End If

                                    If blExisteOper And i > 0 Then
                                        .Rows(i).Item("NOPRCN") = 0
                                        .Rows(i).Item("FOPRCN") = ""
                                        .Rows(i).Item("TIPRO") = ""
                                        .Rows(i).Item("SERVICIO") = ""
                                        .Rows(i).Item("FATNSR") = ""
                                        .Rows(i).Item("TRDCCL") = ""


                                    End If

                                    If blExiste And i > 0 Then
                                        .Rows(i).Item("TMNDA") = ""
                                        .Rows(i).Item("NRTFSV") = 0
                                        .Rows(i).Item("SERVICIO") = ""
                                        .Rows(i).Item("FATNSR") = ""
                                        .Rows(i).Item("TCMTRF") = ""
                                        .Rows(i).Item("IVLSRV") = 0
                                        .Rows(i).Item("QATNAN") = 0
                                        If Not .Columns("QATNRL") Is Nothing Then
                                            .Rows(i).Item("QATNRL") = 0
                                        End If
                                        .Rows(i).Item("SUB_TOTAL") = 0
                                        .Rows(i).Item("SESTRG_SERV") = ""
                                        .Rows(i).Item("TRFSRC") = ""

                                        '.Rows(i).Item("FECINI") = ""
                                    End If
                                Next

                                .Columns.Remove("NCRROP")
                                .Columns.Remove("CCLNT")
                                .Columns.Remove("TIPO_CAMBIO")
                                .Columns.Remove("NOMSER")
                                .Columns.Remove("TDSDES")
                                .Columns.Remove("NSECFC")
                                .Columns.Remove("TCMPCL")

                                Dim intX As Integer = 0
                                .Columns("NOPRCN").SetOrdinal(intX)
                                .Columns("NOPRCN").ColumnName = "Operacion"
                                intX = intX + 1


                                .Columns("FOPRCN").SetOrdinal(intX)
                                .Columns("FOPRCN").ColumnName = "Fecha Operación"
                                intX = intX + 1

                                .Columns("TIPRO").SetOrdinal(intX)
                                .Columns("TIPRO").ColumnName = "Proceso"
                                intX = intX + 1

                                .Columns("TRDCCL").SetOrdinal(intX)
                                .Columns("TRDCCL").ColumnName = "Referencia Operación"
                                intX = intX + 1

                                .Columns("NRTFSV").SetOrdinal(intX)
                                .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                                intX = intX + 1

                                .Columns("SERVICIO").SetOrdinal(intX)
                                .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                                intX = intX + 1

                                .Columns("TCMTRF").SetOrdinal(intX)
                                .Columns("TCMTRF").ColumnName = "Servicio"
                                intX = intX + 1

                                .Columns("FATNSR").SetOrdinal(intX)
                                .Columns("FATNSR").ColumnName = "Fecha Servicio"
                                intX = intX + 1

                                .Columns("QATNAN").SetOrdinal(intX)
                                .Columns("QATNAN").ColumnName = "Cantidad"
                                intX = intX + 1

                                If Not .Columns("QATNRL") Is Nothing Then
                                    .Columns("QATNRL").SetOrdinal(intX)
                                    .Columns("QATNRL").ColumnName = "Cantidad real"
                                    intX = intX + 1

                                End If
                                .Columns("IVLSRV").SetOrdinal(intX)
                                .Columns("IVLSRV").ColumnName = "Importe tarifa"
                                intX = intX + 1

                                .Columns("TMNDA").SetOrdinal(intX)
                                .Columns("TMNDA").ColumnName = "Moneda"
                                intX = intX + 1

                                .Columns("SUB_TOTAL").SetOrdinal(intX)
                                .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                                intX = intX + 1

                                .Columns("SESTRG_SERV").SetOrdinal(intX)
                                .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                                intX = intX + 1

                                .Columns("CMRCLR").SetOrdinal(intX)
                                .Columns("CMRCLR").ColumnName = "Mercadería"
                                intX = intX + 1

                                .Columns("TMRCD2").SetOrdinal(intX)
                                .Columns("TMRCD2").ColumnName = "Descripción"
                                intX = intX + 1

                                .Columns("CUNCN6").SetOrdinal(intX)
                                .Columns("CUNCN6").ColumnName = "Unidad"
                                intX = intX + 1

                                .Columns("NGUICL").SetOrdinal(intX)
                                .Columns("NGUICL").ColumnName = "Guía Proveedor"
                                intX = intX + 1

                                .Columns("TPRVCL").SetOrdinal(intX)
                                .Columns("TPRVCL").ColumnName = "Proveedor"
                                intX = intX + 1

                                .Columns("NORCCL").SetOrdinal(intX)
                                .Columns("NORCCL").ColumnName = "Orden de Compra"
                                intX = intX + 1

                                .Columns("NGUIRN").SetOrdinal(intX)
                                .Columns("NGUIRN").ColumnName = "Guía Ransa"
                                intX = intX + 1

                                .Columns("QTRMC").SetOrdinal(intX)
                                .Columns("QTRMC").ColumnName = "Cantidad "
                                intX = intX + 1

                                .Columns("QTRMP").SetOrdinal(intX)
                                .Columns("QTRMP").ColumnName = "Peso"
                                intX = intX + 1

                                .Columns("NSRCN1").SetOrdinal(intX)
                                .Columns("NSRCN1").ColumnName = "Serie Contenedor"
                                intX = intX + 1

                                .Columns("CPRCN1").SetOrdinal(intX)
                                .Columns("CPRCN1").ColumnName = "Contenedor"
                                intX = intX + 1

                                If Not .Columns("QATNRL") Is Nothing Then
                                    .Columns("QATNRL").SetOrdinal(intX)
                                    .Columns("QATNRL").ColumnName = "Cantidad real"
                                    intX = intX + 1
                                End If
                                .Columns("TRFSRC").SetOrdinal(intX)
                                .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                                intX = intX + 1
                            End If
                        End With
                End Select
               

            Case "S", "T"

                '==========SIL============
                oDtDetalle.Columns.Remove("CCMPN")
                oDtDetalle.Columns.Remove("CDVSN")
                oDtDetalle.Columns.Remove("CCLNT")
                oDtDetalle.Columns.Remove("TIPO_CAMBIO")
                oDtDetalle.Columns.Remove("CMEDTR_VALUE")
                oDtDetalle.Columns.Remove("OS")




                If chkDetallado.Checked Then
                    With oDtDetalle

                        Dim blExiste As Boolean = False
                        Dim blExisteOper As Boolean = False
                        Dim blExisteRev As Boolean = False
                        Dim blExisteEmb As Boolean = False

                        Dim NSECFC As String = ""
                        Dim TIPRO As String = ""
                        Dim NOPRCN As String = ""
                        Dim TMNDA As String = ""
                        Dim NRTFSV As String = ""
                        Dim SERVICIO As String = ""
                        Dim IVLSRV As String = "" 'tarida
                        Dim QATNAN As Decimal = 0 'cantidad
                        Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
                        Dim NCRROP As String = String.Empty

                        For i As Integer = 0 To oDtDetalle.Rows.Count - 1
                            blExiste = False
                            blExisteOper = False
                            blExisteRev = False
                            blExisteEmb = False

                            If i = 0 Then
                                NSECFC = .Rows(i).Item("NSECFC")
                                NOPRCN = .Rows(i).Item("NOPRCN")
                                TMNDA = .Rows(i).Item("TMNDA")
                                NRTFSV = .Rows(i).Item("NRTFSV")
                                SERVICIO = .Rows(i).Item("SERVICIO")
                                IVLSRV = .Rows(i).Item("IVLSRV")
                                QATNAN = .Rows(i).Item("QATNAN")
                                SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                                NCRROP = .Rows(i).Item("NCRROP")
                            End If

                            If NOPRCN = .Rows(i).Item("NOPRCN") And _
                                                            TMNDA = .Rows(i).Item("TMNDA") And _
                                                            NRTFSV = .Rows(i).Item("NRTFSV") And _
                                                            SERVICIO = .Rows(i).Item("SERVICIO") And _
                                                            IVLSRV = .Rows(i).Item("IVLSRV") And _
                                                            QATNAN = .Rows(i).Item("QATNAN") And _
                                                            NCRROP = .Rows(i).Item("NCRROP") And _
                                                            SUB_TOTAL = .Rows(i).Item("SUB_TOTAL") Then
                                blExiste = True
                            End If


                            If NSECFC = .Rows(i).Item("NSECFC") Then
                                blExisteRev = True
                            End If

                            If NOPRCN = .Rows(i).Item("NOPRCN") Then
                                blExisteOper = True
                            End If

                            NSECFC = .Rows(i).Item("NSECFC")

                            NOPRCN = .Rows(i).Item("NOPRCN")
                            TMNDA = .Rows(i).Item("TMNDA")
                            NRTFSV = .Rows(i).Item("NRTFSV")
                            SERVICIO = .Rows(i).Item("SERVICIO")
                            IVLSRV = .Rows(i).Item("IVLSRV")
                            QATNAN = .Rows(i).Item("QATNAN")
                            SUB_TOTAL = .Rows(i).Item("SUB_TOTAL")
                            NCRROP = .Rows(i).Item("NCRROP")


                            If blExisteRev And i > 0 Then
                                .Rows(i).Item("NSECFC") = 0
                            End If

                            If blExisteOper And i > 0 Then
                                .Rows(i).Item("NOPRCN") = 0
                            End If


                            If blExiste And i > 0 Then

                                .Rows(i).Item("TMNDA") = ""
                                .Rows(i).Item("NRTFSV") = 0
                                .Rows(i).Item("SERVICIO") = ""
                                .Rows(i).Item("TCMTRF") = ""
                                .Rows(i).Item("IVLSRV") = 0
                                .Rows(i).Item("QATNAN") = 0
                                .Rows(i).Item("SUB_TOTAL") = 0
                                .AcceptChanges()
                            End If


                        Next


                        .Columns("TCMPCL").ColumnName = "Cliente"
                        .Columns("NOPRCN").ColumnName = "Operacion"
                        .Columns("FOPRCN").ColumnName = "Fecha de Operacion"
                        .Columns("NSECFC").ColumnName = "Nro Secuencia"
                        .Columns("TMNDA").ColumnName = "Moneda"
                        .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                        .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                        .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                        .Columns("TCMTRF").ColumnName = "Servicio"
                        .Columns("IVLSRV").ColumnName = "Importe tarifa"
                        .Columns("QATNAN").ColumnName = "Cantidad"
                        .Columns("NORSCI").ColumnName = "Embarque"
                        .Columns("NDOCEM").ColumnName = "Doc. Embarque"
                        .Columns("CZNFCC").ColumnName = "Cod. Zona"
                        .Columns("TZNFCC").ColumnName = "Zona"
                        .Columns("PNNMOS").ColumnName = "O/S"
                        .Columns("TNRODU").ColumnName = "DUA"
                        .Columns("TCANAL").ColumnName = "Canal"
                        .Columns("CMEDTR").ColumnName = "Medio Transporte"
                        .Columns("CPAIS").ColumnName = "Cod. Pais"
                        .Columns("TCMPPS").ColumnName = "Pais"
                        .Columns("TCMPVP").ColumnName = "Nave"
                        .Columns("FAPREV").ColumnName = "ETD"
                        .Columns("FAPRAR").ColumnName = "ETA"
                        .Columns("FORSCI").ColumnName = "Fec. Apertura"

                    End With
                Else

                    oDtResumenAlmacen = oDtDetalle.Clone

                    For Each dr As DataRow In oDtDetalle.Rows

                        blExisteAlmacen = False

                        For Each drAux As DataRow In oDtResumenAlmacen.Select("TCMPCL='" & dr("TCMPCL") & _
                                                                             "' and NOPRCN='" & dr("NOPRCN") & _
                                                                             "' and TMNDA='" & dr("TMNDA") & _
                                                                             "' and NRTFSV=" & dr("NRTFSV") & _
                                                                             "  and SERVICIO='" & dr("SERVICIO").ToString.Replace("'", "") & _
                                                                             "' and TCMTRF='" & dr("TCMTRF").ToString.Replace("'", "") & _
                                                                             "' and IVLSRV=" & dr("IVLSRV") & _
                                                                             "  and QATNAN=" & dr("QATNAN"))
                            blExisteAlmacen = True
                        Next

                        If blExisteAlmacen Then Continue For

                        drResumen = oDtResumenAlmacen.NewRow

                        drResumen("TCMPCL") = dr("TCMPCL")
                        drResumen("NOPRCN") = dr("NOPRCN")
                        drResumen("TMNDA") = dr("TMNDA")
                        drResumen("NRTFSV") = dr("NRTFSV")
                        drResumen("SUB_TOTAL") = dr("SUB_TOTAL")
                        drResumen("SERVICIO") = dr("SERVICIO").ToString.Replace("'", "")
                        drResumen("TCMTRF") = dr("TCMTRF").ToString.Replace("'", "")
                        drResumen("IVLSRV") = dr("IVLSRV")
                        drResumen("QATNAN") = dr("QATNAN")
                        drResumen("FOPRCN") = dr("FOPRCN")
                        drResumen("FATNSR") = dr("FATNSR")


                        oDtResumenAlmacen.Rows.Add(drResumen)
                    Next


                    oDtDetalle = oDtResumenAlmacen

                    oDtDetalle.Columns.Remove("TRANSPORTE")
                    oDtDetalle.Columns.Remove("DESPACHO")
                    oDtDetalle.Columns.Remove("REGIMEN")
                    oDtDetalle.Columns.Remove("FORSCI")
                    oDtDetalle.Columns.Remove("FAPRAR")
                    oDtDetalle.Columns.Remove("TCMPVP")
                    oDtDetalle.Columns.Remove("TCMPPS")
                    oDtDetalle.Columns.Remove("CPAIS")
                    oDtDetalle.Columns.Remove("CMEDTR")
                    oDtDetalle.Columns.Remove("TCANAL")
                    oDtDetalle.Columns.Remove("TNRODU")
                    oDtDetalle.Columns.Remove("PNNMOS")
                    oDtDetalle.Columns.Remove("TZNFCC")
                    oDtDetalle.Columns.Remove("CZNFCC")
                    oDtDetalle.Columns.Remove("NDOCEM")
                    oDtDetalle.Columns.Remove("NORSCI")
                    oDtDetalle.Columns.Remove("FAPREV")

                    oDtDetalle.Columns("TCMPCL").ColumnName = "Cliente"
                    oDtDetalle.Columns("NOPRCN").ColumnName = "Operacion"
                    oDtDetalle.Columns("FOPRCN").ColumnName = "Fecha Operación"
                    oDtDetalle.Columns("TMNDA").ColumnName = "Moneda"
                    oDtDetalle.Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    oDtDetalle.Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    oDtDetalle.Columns("SERVICIO").ColumnName = "Servicio-Rubro"
                    oDtDetalle.Columns("TCMTRF").ColumnName = "Servicio"
                    oDtDetalle.Columns("FATNSR").ColumnName = "Fecha servicio"
                    oDtDetalle.Columns("IVLSRV").ColumnName = "Importe tarifa"
                    oDtDetalle.Columns("QATNAN").ColumnName = "Cantidad"


                    oDtDetalle.TableName = "Servicio"

                End If



            Case Else
        End Select

        If obj_Servicio.CTPALJ = "RE" Then oDtDetalle = GeneraCargoPlanDetalle(oDtDetalle)

        If oDtDetalle.Columns("Cliente") IsNot Nothing Then oDtDetalle.Columns.Remove("Cliente")
        If oDtDetalle.Columns("CCLNT") IsNot Nothing Then oDtDetalle.Columns.Remove("CCLNT")
        'If oDtDetalle.Columns("FOPRCN") IsNot Nothing Then oDtDetalle.Columns.Remove("FOPRCN")
        'If oDtDetalle.Columns("FATNSR") IsNot Nothing Then oDtDetalle.Columns.Remove("FATNSR")
        If oDtDetalle.Columns("ALMACEN") IsNot Nothing Then oDtDetalle.Columns.Remove("ALMACEN")
        If oDtDetalle.Columns("Nro Secuencia") IsNot Nothing Then oDtDetalle.Columns.Remove("Nro Secuencia")


        If oDtDetalle.Columns("CCMPN") IsNot Nothing Then oDtDetalle.Columns.Remove("CCMPN")
        If oDtDetalle.Columns("CDVSN") IsNot Nothing Then oDtDetalle.Columns.Remove("CDVSN")
        If oDtDetalle.Columns("NSECFC") IsNot Nothing Then oDtDetalle.Columns.Remove("NSECFC")
        If oDtDetalle.Columns("SESTRG") IsNot Nothing Then oDtDetalle.Columns.Remove("SESTRG")
        If oDtDetalle.Columns("NCRROP") IsNot Nothing Then oDtDetalle.Columns.Remove("NCRROP")
        If oDtDetalle.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtDetalle.Columns.Remove("TIPO_CAMBIO")
        If oDtDetalle.Columns("NSLCSR") IsNot Nothing Then oDtDetalle.Columns.Remove("NSLCSR")
        If oDtDetalle.Columns("NGUITR") IsNot Nothing Then oDtDetalle.Columns.Remove("NGUITR")
        If oDtDetalle.Columns("CTRMNC") IsNot Nothing Then oDtDetalle.Columns.Remove("CTRMNC")
        If oDtDetalle.Columns("COD") IsNot Nothing Then oDtDetalle.Columns.Remove("COD")

        If oDtDetalle.Columns("VALCTE") IsNot Nothing Then oDtDetalle.Columns.Remove("VALCTE")
        If oDtDetalle.Columns("ITPCMT") IsNot Nothing Then oDtDetalle.Columns.Remove("ITPCMT")
        If oDtDetalle.Columns("TOBS") IsNot Nothing Then oDtDetalle.Columns.Remove("TOBS")

        If Not oDtDetalle.Columns("NGUITR1") Is Nothing Then oDtDetalle.Columns("NGUITR1").ColumnName = "Guía de Transporte"
        If Not oDtDetalle.Columns("TCMTRT") Is Nothing Then oDtDetalle.Columns("TCMTRT").ColumnName = "Empresa de Transporte"
        If Not oDtDetalle.Columns("FEMVLH") Is Nothing Then oDtDetalle.Columns("FEMVLH").ColumnName = "Fecha de Zarpe"
        If Not oDtDetalle.Columns("EMBARCACION") Is Nothing Then oDtDetalle.Columns("EMBARCACION").ColumnName = "Embarcación"
        If Not obj_Servicio.CTPALJ = "RE" And Not chkDetallado.Checked Then

            If oDtDetalle.Columns("NRITOC") IsNot Nothing Then oDtDetalle.Columns.Remove("NRITOC")
            If oDtDetalle.Columns("TDITES") IsNot Nothing Then oDtDetalle.Columns.Remove("TDITES")
            If oDtDetalle.Columns("TLUGEN") IsNot Nothing Then oDtDetalle.Columns.Remove("TLUGEN")
            If oDtDetalle.Columns("QBLTSR") IsNot Nothing Then oDtDetalle.Columns.Remove("QBLTSR")
            If oDtDetalle.Columns("NSEQIN") IsNot Nothing Then oDtDetalle.Columns.Remove("NSEQIN")
        End If


        odsExcel.Tables.Add(oDtDetalle.Copy)
        odsExcel.Tables.Add(oDtFiltro.Copy)
        odsExcel.Tables.Add(oDtResumen.Copy)
        odsExcel.Tables.Add(oDtResLote.Copy)


        If obj_Servicio.CTPALJ = "RE" Then
            odsExcel.Tables.Add(objDs.Tables(5).Copy)
        End If


        Ransa.Utilitario.HelpClass_NPOI.ExportExcel_RZC20(odsExcel, IIf(oDtReemb Is Nothing, 1, 2), oDtReemb)


    End Sub


    Private Function EmitirReporteExcelReembolso(ByVal oDtReemb As DataTable) As DataTable

        With oDtReemb

            Dim otblAlm As DataTable = oDtReemb

            Dim TCMPCL As String = ""
            Dim NOPRCN As String = ""
            Dim TMNDA As String = ""
            Dim SERVICIO As String = ""
            Dim TCMTRF As String = ""
            Dim IVLSRV As String = ""
            Dim SESTRG_SERV As String = ""

            Dim blExiste As Boolean = False
            Dim blExisteOper As Boolean = False


            For i As Integer = 0 To otblAlm.Rows.Count - 1


                blExiste = False
                blExisteOper = False


                If i = 0 Then
                    TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                    NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                    TMNDA = otblAlm.Rows(i).Item("TMNDA")
                    SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                    TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                    IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                    SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")

                End If


                If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                          NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                          TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                          SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                          TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                          IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                          SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") Then

                    blExiste = True
                End If



                If NOPRCN = otblAlm.Rows(i).Item("NOPRCN") Then
                    blExisteOper = True
                End If


                TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")

                If blExisteOper And i > 0 Then
                    otblAlm.Rows(i).Item("NOPRCN") = 0
                    otblAlm.Rows(i).Item("TIPRO") = ""
                End If



                If blExiste And i > 0 Then

                    otblAlm.Rows(i).Item("TCMPCL") = ""
                    otblAlm.Rows(i).Item("SERVICIO") = ""
                    otblAlm.Rows(i).Item("TCMTRF") = ""
                    otblAlm.Rows(i).Item("NRTFSV") = 0
                    otblAlm.Rows(i).Item("FOPRCN") = ""

                    otblAlm.AcceptChanges()



                End If

            Next
            oDtReemb = otblAlm
            '================================================

            If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
            If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
            If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")



            oDtReemb.Columns.Add("TOTAL_SOLES", GetType(Decimal))
            oDtReemb.Columns.Add("REEMBOLSO_SOL", GetType(Decimal))
            oDtReemb.Columns.Add("REEMBOLSO_DOL", GetType(Decimal))

            Dim strFactura As String = String.Empty

            For i As Integer = 0 To oDtReemb.Rows.Count - 1



                If oDtReemb.Rows(i).Item("ITPCMT") > 0 Then

                    'oDtReemb.Rows(i).Item("TOTAL_SOLES") = oDtReemb.Rows(i).Item("ITPCMT") * oDtReemb.Rows(i).Item("SUB_TOTAL")
                    oDtReemb.Rows(i).Item("TOTAL_SOLES") = oDtReemb.Rows(i).Item("ITPCMT") * oDtReemb.Rows(i).Item("QATNAN")
                    oDtReemb.Rows(i).Item("REEMBOLSO_SOL") = Math.Round((oDtReemb.Rows(i).Item("TOTAL_SOLES") * oDtReemb.Rows(i).Item("VALCTE") / 100) + oDtReemb.Rows(i).Item("TOTAL_SOLES"), 2)
                    oDtReemb.Rows(i).Item("REEMBOLSO_DOL") = Math.Round(oDtReemb.Rows(i).Item("REEMBOLSO_SOL") / oDtReemb.Rows(i).Item("ITPCMT"), 2)
                Else
                    oDtReemb.Rows(i).Item("REEMBOLSO_DOL") = 0
                End If

                If oDtReemb.Rows(i).Item("NUMERO_DOC") > 0 Then
                    strFactura = oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Substring(0, 3)
                    strFactura = strFactura & "-" & oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Substring(3, oDtReemb.Rows(i).Item("NUMERO_DOC").ToString.Length - 3)
                    oDtReemb.Rows(i).Item("NUMERO_DOC") = strFactura
                Else
                    oDtReemb.Rows(i).Item("NUMERO_DOC") = 0
                End If

                oDtReemb.AcceptChanges()

            Next

            If Not .Columns("QATNRL") Is Nothing Then
                .Columns.Remove("QATNRL")
            End If

            .Columns("TCMPCL").SetOrdinal(0)
            .Columns("NOPRCN").SetOrdinal(1)
            .Columns("SERVICIO").SetOrdinal(2)
            .Columns("PROVEEDOR").SetOrdinal(3)
            .Columns("NUMERO_DOC").SetOrdinal(4)
            .Columns("TOBS").SetOrdinal(5)
            .Columns("OBSERVACION").SetOrdinal(6)
            .Columns("FOPRCN").SetOrdinal(7)
            .Columns("LOTE").SetOrdinal(8)
            '.Columns("SUB_TOTAL").SetOrdinal(9)
            .Columns("QATNAN").SetOrdinal(9)


            .Columns("TOTAL_SOLES").SetOrdinal(10)
            .Columns("PORCENTAJE").SetOrdinal(11)
            .Columns("VALCTE").SetOrdinal(12)
            .Columns("REEMBOLSO_SOL").SetOrdinal(13)
            .Columns("REEMBOLSO_DOL").SetOrdinal(14)
            .Columns("CI").SetOrdinal(15)
            .Columns("ITPCMT").SetOrdinal(16)



            .Columns("TCMPCL").ColumnName = "Cliente"
            .Columns("NOPRCN").ColumnName = "Operacion"
            .Columns("SERVICIO").ColumnName = "Tipo Servicio"
            .Columns("PROVEEDOR").ColumnName = "Proveedor"
            .Columns("NUMERO_DOC").ColumnName = "Factura"
            .Columns("TOBS").ColumnName = "Descripción del Servicio"
            .Columns("OBSERVACION").ColumnName = "Observación"
            .Columns("FOPRCN").ColumnName = "Fecha Servicio"
            .Columns("LOTE").ColumnName = "Lote"
            '.Columns("SUB_TOTAL").ColumnName = "Monto a Pagar USD/."
            .Columns("QATNAN").ColumnName = "Monto a Pagar USD/."
            .Columns("TOTAL_SOLES").ColumnName = "Monto a Pagar S/."
            .Columns("VALCTE").ColumnName = "FEE"
            .Columns("REEMBOLSO_SOL").ColumnName = "Monto a Reeembolsar S/."
            .Columns("REEMBOLSO_DOL").ColumnName = "Monto a Reeembolsar USD/."
            .Columns("ITPCMT").ColumnName = "T/C"
            .Columns("TMNDA").ColumnName = "Moneda"


        End With

        oDtReemb = GeneraCargoPlanDetalleReemb(oDtReemb)

        oDtReemb.TableName = "Detalle"


        If oDtReemb.Columns("Cliente") IsNot Nothing Then oDtReemb.Columns.Remove("Cliente")
        If oDtReemb.Columns("CCLNT") IsNot Nothing Then oDtReemb.Columns.Remove("CCLNT")
        If oDtReemb.Columns("FATNSR") IsNot Nothing Then oDtReemb.Columns.Remove("FATNSR")
        If oDtReemb.Columns("Nro Secuencia") IsNot Nothing Then oDtReemb.Columns.Remove("Nro Secuencia")
        If oDtReemb.Columns("CCMPN") IsNot Nothing Then oDtReemb.Columns.Remove("CCMPN")
        If oDtReemb.Columns("CDVSN") IsNot Nothing Then oDtReemb.Columns.Remove("CDVSN")
        If oDtReemb.Columns("NSECFC") IsNot Nothing Then oDtReemb.Columns.Remove("NSECFC")
        If oDtReemb.Columns("SESTRG") IsNot Nothing Then oDtReemb.Columns.Remove("SESTRG")
        If oDtReemb.Columns("NCRROP") IsNot Nothing Then oDtReemb.Columns.Remove("NCRROP")
        If oDtReemb.Columns("TIPO_CAMBIO") IsNot Nothing Then oDtReemb.Columns.Remove("TIPO_CAMBIO")
        If oDtReemb.Columns("NSLCSR") IsNot Nothing Then oDtReemb.Columns.Remove("NSLCSR")
        If oDtReemb.Columns("NGUITR") IsNot Nothing Then oDtReemb.Columns.Remove("NGUITR")
        If oDtReemb.Columns("CTRMNC") IsNot Nothing Then oDtReemb.Columns.Remove("CTRMNC")
        If oDtReemb.Columns("COD") IsNot Nothing Then oDtReemb.Columns.Remove("COD")



        If oDtReemb.Columns("TIPRO") IsNot Nothing Then oDtReemb.Columns.Remove("TIPRO")
        If oDtReemb.Columns("QATNAN") IsNot Nothing Then oDtReemb.Columns.Remove("QATNAN")
        If oDtReemb.Columns("IVLSRV") IsNot Nothing Then oDtReemb.Columns.Remove("IVLSRV")
        If oDtReemb.Columns("Moneda") IsNot Nothing Then oDtReemb.Columns.Remove("Moneda")
        If oDtReemb.Columns("SESTRG_SERV") IsNot Nothing Then oDtReemb.Columns.Remove("SESTRG_SERV")
        If oDtReemb.Columns("NRTFSV") IsNot Nothing Then oDtReemb.Columns.Remove("NRTFSV")
        If oDtReemb.Columns("TCMTRF") IsNot Nothing Then oDtReemb.Columns.Remove("TCMTRF")
        If oDtReemb.Columns("RUC") IsNot Nothing Then oDtReemb.Columns.Remove("RUC")
        If oDtReemb.Columns("DOCUMENTO") IsNot Nothing Then oDtReemb.Columns.Remove("DOCUMENTO")
        If oDtReemb.Columns("OC") IsNot Nothing Then oDtReemb.Columns.Remove("OC")



        Return oDtReemb
    End Function

    Private Function GeneraCargoPlanDetalleReemb(ByVal oDt As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        Dim TotMntSoles As Decimal = 0
        Dim TotMntDolaresRem As Decimal = 0
        Dim TotMntSolesRem As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow

        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("Moneda").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("Monto a Pagar USD/."))

                        TotMntSoles = Val("" & row("Monto a Pagar S/.") & "")

                        TotMntDolaresRem = Val("" & row("Monto a Reeembolsar USD/.") & "")
                        TotMntSolesRem = Val("" & row("Monto a Reeembolsar S/.") & "")


                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("Monto a Pagar USD/.")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If TotMntSoles > 0 Then TotMntSoles = (TotMntSoles * dr("PRCRMT") / 100)
                    If TotMntDolaresRem > 0 Then TotMntDolaresRem = (TotMntDolaresRem * dr("PRCRMT") / 100)
                    If TotMntSolesRem > 0 Then TotMntSolesRem = (TotMntSolesRem * dr("PRCRMT") / 100)


                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Pagar USD/.") = TotMntDolares.ToString("N2")

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Pagar S/.") = TotMntSoles.ToString("N2")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Reeembolsar USD/.") = TotMntDolaresRem.ToString("N2")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Reeembolsar S/.") = TotMntSolesRem.ToString("N2")


                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("Monto a Pagar USD/.") = TotMntDolares.ToString("N2")
                        drAux("FEE") = row("FEE")

                        If TotMntSoles > 0 Then drAux("Monto a Pagar S/.") = TotMntSoles.ToString("N2")
                        If TotMntDolaresRem > 0 Then drAux("Monto a Reeembolsar USD/.") = TotMntDolaresRem.ToString("N2")
                        If TotMntSolesRem > 0 Then drAux("Monto a Reeembolsar S/.") = TotMntSolesRem.ToString("N2")

                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        oDtAux.Columns.Remove("SUB_TOTAL")
        Return oDtAux
    End Function

  
    Private Function DeleteRowsRepits(ByVal oDtRep As DataTable) As DataTable
        Dim cadenaWhere As String = ""
        Dim z As Integer = 0
        Dim x As Integer = 0
        Dim oDtTempFiltro As New DataTable
        Dim rowsDinamic As Integer = oDtRep.Rows.Count


        While z < rowsDinamic
            x = rowsDinamic - 1

            cadenaWhere = "NOPRCN=" & oDtRep.Rows(x).Item("NOPRCN") & _
            " AND TRIM(CREFFW) ='" & oDtRep.Rows(x).Item("CREFFW").ToString.Trim & _
            "' AND NSEQIN = " & oDtRep.Rows(x).Item("NSEQIN").ToString.Trim & _
            "  AND OC = '" & oDtRep.Rows(x).Item("OC").ToString.Trim & _
            "' AND NRITOC =  " & oDtRep.Rows(x).Item("NRITOC").ToString.Trim & _
            " AND NRTFSV = " & oDtRep.Rows(x).Item("NRTFSV").ToString

            oDtTempFiltro = filtraDatatable(oDtRep, cadenaWhere)
            If oDtTempFiltro.Rows.Count > 1 Then
                oDtRep.Rows.RemoveAt(x)
            End If
            rowsDinamic -= 1
        End While


        Return oDtRep
    End Function

    Private Function ResumenTable(ByVal objDt As DataTable, ByVal tipoReporte As TipoReporte) As DataTable


        Dim oDtDetalle As DataTable = objDt

        Dim oDtResumenAlmacen As New DataTable


        oDtResumenAlmacen = oDtDetalle.Clone

        Select Case cmbTipoAlmacenaje.SelectedValue
            Case "", "7"
                Dim TCMPCL As String = ""
                Dim NOPRCN As String = ""
                Dim TMNDA As String = ""
                Dim NRTFSV As String = ""
                Dim SERVICIO As String = ""
                Dim TCMTRF As String = ""
                Dim IVLSRV As String = ""
                Dim QATNAN As String = ""
                Dim SUB_TOTAL As String = ""
                Dim SESTRG_SERV As String = ""
                Dim NCRROP As String = ""
                Dim Division As String = ""

                Dim nCount As Integer = 0
                Dim blExiste As Boolean = False
                Dim blExisteOper As Boolean = False

                For Each dr As DataRow In oDtDetalle.Rows

                    blExiste = False



                    If nCount = 0 Then
                        TCMPCL = dr("TCMPCL")
                        NOPRCN = dr("NOPRCN")
                        TMNDA = dr("TMNDA")
                        NRTFSV = dr("NRTFSV")
                        SERVICIO = dr("SERVICIO")
                        TCMTRF = dr("TCMTRF")
                        IVLSRV = dr("IVLSRV")
                        QATNAN = dr("QATNAN")
                        SUB_TOTAL = dr("SUB_TOTAL")
                        NCRROP = dr("NCRROP")
                        Division = dr("CDVSN")
                        If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
                    End If

                    If dr("CDVSN") = "R" Then
                        If TCMPCL = dr("TCMPCL") And _
                                                              NOPRCN = dr("NOPRCN") And _
                                                              TMNDA = dr("TMNDA") And _
                                                              NRTFSV = dr("NRTFSV") And _
                                                              SERVICIO = dr("SERVICIO") And _
                                                              TCMTRF = dr("TCMTRF") And _
                                                              IVLSRV = dr("IVLSRV") And _
                                                              QATNAN = dr("QATNAN") And _
                                                              SUB_TOTAL = dr("SUB_TOTAL") And _
                                                              NCRROP = dr("NCRROP") And _
                                                              SESTRG_SERV = dr("SESTRG_SERV") Then
                            blExiste = True
                        End If
                    Else
                        If TCMPCL = dr("TCMPCL") And _
                                                                              NOPRCN = dr("NOPRCN") And _
                                                                              TMNDA = dr("TMNDA") And _
                                                                              NRTFSV = dr("NRTFSV") And _
                                                                              SERVICIO = dr("SERVICIO") And _
                                                                              TCMTRF = dr("TCMTRF") And _
                                                                              IVLSRV = dr("IVLSRV") And _
                                                                              QATNAN = dr("QATNAN") And _
                                                                              SUB_TOTAL = dr("SUB_TOTAL") Then
                            blExiste = True
                        End If
                    End If


                    nCount += 1

                    If blExiste And nCount > 1 Then
                        Continue For

                    Else
                        oDtResumenAlmacen.ImportRow(dr)
                    End If
                    TCMPCL = dr("TCMPCL")
                    NOPRCN = dr("NOPRCN")
                    TMNDA = dr("TMNDA")
                    NRTFSV = dr("NRTFSV")
                    SERVICIO = dr("SERVICIO")
                    TCMTRF = dr("TCMTRF")
                    IVLSRV = dr("IVLSRV")
                    QATNAN = dr("QATNAN")
                    SUB_TOTAL = dr("SUB_TOTAL")
                    NCRROP = dr("NCRROP")
                    If dr("CDVSN") = "R" Then SESTRG_SERV = dr("SESTRG_SERV")
                Next



                oDtDetalle = oDtResumenAlmacen
                '=============================================================================
                TCMPCL = ""
                NOPRCN = ""
                TMNDA = ""
                NRTFSV = ""
                SERVICIO = ""
                TCMTRF = ""
                IVLSRV = ""
                QATNAN = ""
                SUB_TOTAL = ""
                SESTRG_SERV = ""

                For i As Integer = 0 To oDtDetalle.Rows.Count - 1
                    blExiste = False
                    blExisteOper = False
                    If i = 0 Then
                        TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
                        NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                        TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                        NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                        SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                        TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                        IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                        QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                        SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                        If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

                    End If
                    If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then

                        If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                              NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                              TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                              NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                              SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                              TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                              IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                              SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV") Then
                            blExiste = True
                        End If
                    Else

                        If TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL") And _
                              NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                              TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                              NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                              SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                              TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                              IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                              QATNAN = oDtDetalle.Rows(i).Item("QATNAN") And _
                              SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL") Then
                            blExiste = True
                        End If
                    End If

                    If NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") Then
                        blExisteOper = True
                    End If




                    TCMPCL = oDtDetalle.Rows(i).Item("TCMPCL")
                    NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                    TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                    NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                    SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                    TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                    IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                    QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                    SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                    If oDtDetalle.Rows(i).Item("CDVSN") = "R" Then SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

                    If blExisteOper And i > 0 Then
                        oDtDetalle.Rows(i).Item("NOPRCN") = 0
                        oDtDetalle.Rows(i).Item("FOPRCN") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""

                    End If


                    If blExiste And i > 0 Then
                        oDtDetalle.Rows(i).Item("TCMPCL") = ""
                        oDtDetalle.Rows(i).Item("TIPRO") = ""
                        oDtDetalle.Rows(i).Item("NRTFSV") = 0
                        oDtDetalle.Rows(i).Item("SERVICIO") = ""
                        oDtDetalle.Rows(i).Item("TCMTRF") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""
                        oDtDetalle.AcceptChanges()
                    End If

                Next
                'If Not chkDetallado.Checked And ServicioOperacion.TipoReporte.Excel = tipoReporte Then
                With oDtDetalle
                    If .Columns("cclnt") IsNot Nothing Then .Columns.Remove("cclnt")
                    If .Columns("ccmpn") IsNot Nothing Then .Columns.Remove("ccmpn")
                    If .Columns("cdvsn") IsNot Nothing Then .Columns.Remove("cdvsn")
                    If .Columns("SESTRG") IsNot Nothing Then .Columns.Remove("SESTRG")
                    If .Columns("TIPO_CAMBIO") IsNot Nothing Then .Columns.Remove("TIPO_CAMBIO")

                    If .Columns("Qprdfc") IsNot Nothing Then .Columns.Remove("Qprdfc")
                    If .Columns("QAROCP") IsNot Nothing Then .Columns.Remove("QAROCP")
                    If .Columns("NSECFC") IsNot Nothing Then .Columns.Remove("NSECFC")



                    If .Columns("CREFFW") IsNot Nothing Then .Columns.Remove("CREFFW")
                    If .Columns("NCRRDC") IsNot Nothing Then .Columns.Remove("NCRRDC")
                    If .Columns("NDIAPL") IsNot Nothing Then .Columns.Remove("NDIAPL")
                    If .Columns("DESCWB") IsNot Nothing Then .Columns.Remove("DESCWB")
                    If .Columns("TUBRFR") IsNot Nothing Then .Columns.Remove("TUBRFR")
                    If .Columns("QREFFW") IsNot Nothing Then .Columns.Remove("QREFFW")
                    If .Columns("TIPBTO") IsNot Nothing Then .Columns.Remove("TIPBTO")
                    If .Columns("QPSOBL") IsNot Nothing Then .Columns.Remove("QPSOBL")
                    If .Columns("TUNPSO") IsNot Nothing Then .Columns.Remove("TUNPSO")
                    If .Columns("QVLBTO") IsNot Nothing Then .Columns.Remove("QVLBTO")
                    If .Columns("TUNVOL") IsNot Nothing Then .Columns.Remove("TUNVOL")
                    If .Columns("NSRCN1") IsNot Nothing Then .Columns.Remove("NSRCN1")
                    If .Columns("CPRCN1") IsNot Nothing Then .Columns.Remove("CPRCN1")

                    If .Columns("PROVEEDOR") IsNot Nothing Then .Columns.Remove("PROVEEDOR")
                    If .Columns("RUC") IsNot Nothing Then .Columns.Remove("RUC")
                    If .Columns("COD") IsNot Nothing Then .Columns.Remove("COD")
                    If .Columns("DOCUMENTO") IsNot Nothing Then .Columns.Remove("DOCUMENTO")
                    If .Columns("NUMERO_DOC") IsNot Nothing Then .Columns.Remove("NUMERO_DOC")
                    If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")


                    If .Columns("CORR") IsNot Nothing Then .Columns.Remove("CORR")
                    If .Columns("FECHA") IsNot Nothing Then .Columns.Remove("FECHA")
                    If .Columns("PESO") IsNot Nothing Then .Columns.Remove("PESO")
                    If .Columns("VOLUMEN") IsNot Nothing Then .Columns.Remove("VOLUMEN")
                    If .Columns("AREA") IsNot Nothing Then .Columns.Remove("AREA")

                    If .Columns("TCTCST") IsNot Nothing Then .Columns.Remove("TCTCST")
                    If .Columns("TCTCSA") IsNot Nothing Then .Columns.Remove("TCTCSA")
                    If .Columns("TCTCSF") IsNot Nothing Then .Columns.Remove("TCTCSF")
                    If .Columns("NORAGN") IsNot Nothing Then .Columns.Remove("NORAGN")
                    If .Columns("FREFFW") IsNot Nothing Then .Columns.Remove("FREFFW")

                    If .Columns("FSLFFW") IsNot Nothing Then .Columns.Remove("FSLFFW")
                    If .Columns("PERINI") IsNot Nothing Then .Columns.Remove("PERINI")
                    If .Columns("PERFIN") IsNot Nothing Then .Columns.Remove("PERFIN")




                    Dim intX As Integer = 0
                    .Columns("TCMPCL").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("NOPRCN").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("FOPRCN").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TIPRO").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TRDCCL").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("NRTFSV").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SERVICIO").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TCMTRF").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("FATNSR").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("QATNAN").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("IVLSRV").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TMNDA").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SUB_TOTAL").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SESTRG_SERV").SetOrdinal(intX)
                    intX = intX + 1
                    If Not .Columns("QATNRL") Is Nothing Then
                        intX = intX - 4
                        .Columns("QATNRL").SetOrdinal(intX)
                        intX = intX + 1
                        .Columns("IVLSRV").SetOrdinal(intX)
                        intX = intX + 1
                        .Columns("TMNDA").SetOrdinal(intX)
                        intX = intX + 1
                        .Columns("SUB_TOTAL").SetOrdinal(intX)
                        intX = intX + 1
                        .Columns("SESTRG_SERV").SetOrdinal(intX)

                        .Columns("QATNRL").ColumnName = "Cantidad real"
                    End If


                    .Columns("TCMPCL").ColumnName = "Cliente"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("TIPRO").ColumnName = "Proceso"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("QATNAN").ColumnName = "Cantidad"
                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                    .Columns("FOPRCN").ColumnName = "Fecha Operación"


                    .Columns("FATNSR").ColumnName = "Fecha Servicio"

                    .Columns("TRDCCL").ColumnName = "Referencia Operación"
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                    If .Columns("TSRVC") IsNot Nothing Then .Columns("TSRVC").ColumnName = "Observación"
                    If .Columns("OBSERVACION") IsNot Nothing Then .Columns("OBSERVACION").ColumnName = "Observación"
                    .Columns.Remove("Cliente")
                    'If .Columns("FOPRCN") IsNot Nothing Then .Columns.Remove("FOPRCN")
                    'If .Columns("FATNSR") IsNot Nothing Then .Columns.Remove("FATNSR")
                    If .Columns("NCRROP") IsNot Nothing Then .Columns.Remove("NCRROP")

                End With

            Case "1" ' Deposito Simple

                Dim NOPRCN As String = ""
                Dim TMNDA As String = ""
                Dim NRTFSV As String = ""
                Dim SERVICIO As String = ""
                Dim TCMTRF As String = ""
                Dim IVLSRV As String = ""
                Dim QATNAN As String = ""
                Dim SUB_TOTAL As String = ""
                Dim SESTRG_SERV As String = ""
                Dim NCRROP As String = ""

                Dim nCount As Integer = 0
                Dim blExiste As Boolean = False
                Dim blExisteOper As Boolean = False

                For Each dr As DataRow In oDtDetalle.Rows
                    blExiste = False

                    If nCount = 0 Then
                        NOPRCN = dr("NOPRCN")
                        TMNDA = dr("TMNDA")
                        NRTFSV = dr("NRTFSV")
                        SERVICIO = dr("SERVICIO")
                        TCMTRF = dr("TCMTRF")
                        IVLSRV = dr("IVLSRV")
                        QATNAN = dr("QATNAN")
                        SUB_TOTAL = dr("SUB_TOTAL")
                        NCRROP = dr("NCRROP")
                    End If


                    If NOPRCN = dr("NOPRCN") And _
                                                 TMNDA = dr("TMNDA") And _
                                                 NRTFSV = dr("NRTFSV") And _
                                                 SERVICIO = dr("SERVICIO") And _
                                                 TCMTRF = dr("TCMTRF") And _
                                                 IVLSRV = dr("IVLSRV") And _
                                                 QATNAN = dr("QATNAN") And _
                                                 SUB_TOTAL = dr("SUB_TOTAL") And _
                                                 NCRROP = dr("NCRROP") And _
                                                 SESTRG_SERV = dr("SESTRG_SERV") Then
                        blExiste = True
                    End If

                    nCount += 1
                    If blExiste And nCount > 1 Then
                        Continue For

                    Else
                        oDtResumenAlmacen.ImportRow(dr)
                    End If

                    NOPRCN = dr("NOPRCN")
                    TMNDA = dr("TMNDA")
                    NRTFSV = dr("NRTFSV")
                    SERVICIO = dr("SERVICIO")
                    TCMTRF = dr("TCMTRF")
                    IVLSRV = dr("IVLSRV")
                    QATNAN = dr("QATNAN")
                    SUB_TOTAL = dr("SUB_TOTAL")
                    NCRROP = dr("NCRROP")
                    SESTRG_SERV = dr("SESTRG_SERV")

                Next
                '=============================================================================
                oDtDetalle = oDtResumenAlmacen
                NOPRCN = ""
                TMNDA = ""
                NRTFSV = ""
                SERVICIO = ""
                TCMTRF = ""
                IVLSRV = ""
                QATNAN = ""
                SUB_TOTAL = ""
                SESTRG_SERV = ""
                For i As Integer = 0 To oDtDetalle.Rows.Count - 1
                    blExiste = False
                    blExisteOper = False
                    If i = 0 Then
                        NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                        TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                        NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                        SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")
                        TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                        IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                        QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                        SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                        SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")
                    End If



                    If NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") And _
                          TMNDA = oDtDetalle.Rows(i).Item("TMNDA") And _
                          NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV") And _
                          SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO") And _
                          TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF") And _
                          IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV") And _
                          SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV") Then
                        blExiste = True
                    End If


                    If NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN") Then
                        blExisteOper = True
                    End If


                    NOPRCN = oDtDetalle.Rows(i).Item("NOPRCN")
                    TMNDA = oDtDetalle.Rows(i).Item("TMNDA")
                    NRTFSV = oDtDetalle.Rows(i).Item("NRTFSV")
                    SERVICIO = oDtDetalle.Rows(i).Item("SERVICIO")

                    TCMTRF = oDtDetalle.Rows(i).Item("TCMTRF")
                    IVLSRV = oDtDetalle.Rows(i).Item("IVLSRV")
                    QATNAN = oDtDetalle.Rows(i).Item("QATNAN")
                    SUB_TOTAL = oDtDetalle.Rows(i).Item("SUB_TOTAL")
                    SESTRG_SERV = oDtDetalle.Rows(i).Item("SESTRG_SERV")

                    If blExisteOper And i > 0 Then
                        oDtDetalle.Rows(i).Item("NOPRCN") = 0
                        oDtDetalle.Rows(i).Item("FOPRCN") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""
                    End If

                    If blExiste And i > 0 Then

                        oDtDetalle.Rows(i).Item("TIPRO") = ""
                        oDtDetalle.Rows(i).Item("NRTFSV") = 0
                        oDtDetalle.Rows(i).Item("SERVICIO") = ""
                        oDtDetalle.Rows(i).Item("FATNSR") = ""
                        oDtDetalle.Rows(i).Item("TCMTRF") = ""
                        'oDtDetalle.Rows(i).Item("FECINI") = ""
                        oDtDetalle.Rows(i).Item("TRDCCL") = ""
                        oDtDetalle.AcceptChanges()
                    End If

                Next
                With oDtDetalle



                    Dim intX As Integer = 0
                    .Columns("TCMPCL").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("NOPRCN").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("FOPRCN").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TIPRO").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TRDCCL").SetOrdinal(intX)
                    'intX = intX + 1
                    '.Columns("FECINI").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("NRTFSV").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SERVICIO").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TCMTRF").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("FATNSR").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("QATNAN").SetOrdinal(intX)
                    intX = intX + 1
                    If Not .Columns("QATNRL") Is Nothing Then
                        .Columns("QATNRL").SetOrdinal(intX)
                        intX = intX + 1
                    End If
                    .Columns("IVLSRV").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TMNDA").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SUB_TOTAL").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("SESTRG_SERV").SetOrdinal(intX)
                    intX = intX + 1
                    .Columns("TRFSRC").SetOrdinal(intX)
                    intX = intX + 1

                    .Columns("TCMPCL").ColumnName = "Cliente"
                    .Columns("NOPRCN").ColumnName = "Operacion"
                    .Columns("FOPRCN").ColumnName = "Fecha Operación"
                    .Columns("TIPRO").ColumnName = "Proceso"
                    '.Columns("FECINI").ColumnName = "Fecha Inicio Servicio"
                    .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                    .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                    .Columns("TCMTRF").ColumnName = "Servicio"
                    .Columns("FATNSR").ColumnName = "Fecha Servicio"
                    .Columns("QATNAN").ColumnName = "Cantidad"

                    If Not .Columns("QATNRL") Is Nothing Then
                        .Columns("QATNRL").ColumnName = "Cantidad real"
                    End If

                    .Columns("IVLSRV").ColumnName = "Importe tarifa"
                    .Columns("TMNDA").ColumnName = "Moneda"
                    .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                    .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"

                    .Columns("TRDCCL").ColumnName = "Referencia Operación"
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"

                    .Columns.Remove("TDSDES")
                    .Columns.Remove("NOMSER")
                    .Columns.Remove("CPRCN1")
                    .Columns.Remove("NSRCN1")
                    .Columns.Remove("LOTE")
                    .Columns.Remove("QTRMP")
                    .Columns.Remove("QTRMC")
                    .Columns.Remove("NGUIRN")
                    .Columns.Remove("NORCCL")
                    .Columns.Remove("TPRVCL")
                    .Columns.Remove("NGUICL")
                    .Columns.Remove("CUNCN6")
                    .Columns.Remove("TMRCD2")
                    .Columns.Remove("CMRCLR")


                End With



        End Select

        Return oDtDetalle
    End Function

    Private Sub EmitirReportePantalla(ByVal objDs As DataSet, ByVal obj_Servicio As Servicio_BE)
        Dim objPrintForm As New PrintForm
        Select Case obj_Servicio.CDVSN
            Case "S"
                '================SIL================                    
                objDs.Tables(0).TableName = "ConsistenciaSIL"
                Dim objetoRepSIL As New rptConsistenciaSIL
                Dim objetoRepResumenSIL As New rptConsistenciaResumenSIL

                If chkDetallado.Checked Then
                    objetoRepSIL.SetDataSource(objDs)
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.PSUSUARIO
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CCMPN_DESC
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CDVSN_DESC
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CPLNDV_DESC
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCliente.pCodigo & " - " & UcCliente.pRazonSocial
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblEtiqueta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, "Nro Operación :", "Revisión :"))
                    CType(objetoRepSIL.ReportDefinition.ReportObjects("lblvalor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, obj_Servicio.NOPRCN, obj_Servicio.NSECFC))
                    objetoRepSIL.SetParameterValue("blVerCliente", IIf(UcCliente.pCodigo = 0, False, True))

                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRepSIL, Me)
                Else
                    objetoRepResumenSIL.SetDataSource(objDs)
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.PSUSUARIO
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CCMPN_DESC
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CDVSN_DESC
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obj_Servicio.CPLNDV_DESC
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = UcCliente.pCodigo & " - " & UcCliente.pRazonSocial
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblEtiqueta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, "Nro Operación :", "Revisión :"))
                    CType(objetoRepResumenSIL.ReportDefinition.ReportObjects("lblvalor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, obj_Servicio.NOPRCN, obj_Servicio.NSECFC))
                    objetoRepResumenSIL.SetParameterValue("blVerCliente", IIf(UcCliente.pCodigo = 0, False, True))

                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRepResumenSIL, Me)

                End If




            Case "R"
                '================Almacen================   


                objDs.Tables(0).TableName = "ConsistenciaAlmacen"

                Dim objetoRepALMDetalle As New rptConsistenciaDetalle
                Dim objetoRepALM As New rptConsistencia

                If chkDetallado.Checked Then
                    objetoRepALMDetalle.SetDataSource(objDs)
                    objetoRepALMDetalle.SetParameterValue("pUsuario", obj_Servicio.PSUSUARIO)
                    objetoRepALMDetalle.SetParameterValue("pCompania", obj_Servicio.CCMPN_DESC)
                    objetoRepALMDetalle.SetParameterValue("pDivision", obj_Servicio.CDVSN_DESC)
                    objetoRepALMDetalle.SetParameterValue("pPlanta", obj_Servicio.CPLNDV_DESC)
                    objetoRepALMDetalle.SetParameterValue("pCliente", UcCliente.pCodigo & " - " & UcCliente.pRazonSocial)
                    objetoRepALMDetalle.SetParameterValue("blVerCliente", IIf(UcCliente.pCodigo = 0, False, True))

                    CType(objetoRepALMDetalle.ReportDefinition.ReportObjects("lblEtiqueta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, "Nro Operación :", "Revisión :"))
                    CType(objetoRepALMDetalle.ReportDefinition.ReportObjects("lblvalor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, obj_Servicio.NOPRCN, obj_Servicio.NSECFC))

                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRepALMDetalle, Me)

                Else
                    objetoRepALM.SetDataSource(objDs)
                    objetoRepALM.SetParameterValue("pUsuario", obj_Servicio.PSUSUARIO)
                    objetoRepALM.SetParameterValue("pCompania", obj_Servicio.CCMPN_DESC)
                    objetoRepALM.SetParameterValue("pDivision", obj_Servicio.CDVSN_DESC)
                    objetoRepALM.SetParameterValue("pPlanta", obj_Servicio.CPLNDV_DESC)
                    objetoRepALM.SetParameterValue("pCliente", UcCliente.pCodigo & " - " & UcCliente.pRazonSocial)
                    objetoRepALM.SetParameterValue("blVerCliente", IIf(UcCliente.pCodigo = 0, False, True))

                    CType(objetoRepALM.ReportDefinition.ReportObjects("lblEtiqueta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, "Nro Operación :", "Revisión :"))
                    CType(objetoRepALM.ReportDefinition.ReportObjects("lblvalor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = IIf(cmbCriterioReporte.SelectedIndex = 0, "", IIf(cmbCriterioReporte.SelectedIndex = 1, obj_Servicio.NOPRCN, obj_Servicio.NSECFC))

                    objPrintForm.WindowState = FormWindowState.Maximized
                    objPrintForm.ShowForm(objetoRepALM, Me)

                End If


        End Select
    End Sub

    Private Function Lista_Tipo_Planta() As String
        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                    strCadDocumentos += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                End If
            Next
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub ObtenerInformacionReporte(ByVal tipoReporte As TipoReporte)

        Dim obj_Logica As New clsConsistencia_BL
        Dim obj_Servicio As New Servicio_BE
        Dim obj_Negocio As New clsServicio_BL
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        Dim objDtRes As New DataTable
        Dim dtFiltro As New DataTable
        Try
            obj_Servicio.CCLNT = UcCliente.pCodigo
            obj_Servicio.CMNDA1 = 100
            obj_Servicio.FULTAC = Format(Now, "yyyyMMdd")
            obj_Servicio.CCMPN = cmbCompania.SelectedValue
            obj_Servicio.CDVSN = cmbDivision.SelectedValue
            'obj_Servicio.CPLNDV = cmbPlanta.SelectedValue
            obj_Servicio.TIPO_PLANTA = Lista_Tipo_Planta() 'objServicio.TIPO_PLANTA
            obj_Servicio.PSUSUARIO = objServicio.PSUSUARIO
            obj_Servicio.CCMPN_DESC = objServicio.CCMPN_DESC.Trim
            obj_Servicio.CDVSN_DESC = objServicio.CDVSN_DESC.Trim
            obj_Servicio.CPLNDV_DESC = objServicio.CPLNDV_DESC.Trim
            obj_Servicio.FLGPEN = cmbEstadoPendiente.SelectedValue
            If Me.cmbEstadoFactura.Visible Then
                obj_Servicio.FLGFAC = Me.cmbEstadoFactura.SelectedValue
            Else
                obj_Servicio.FLGFAC = "0"
            End If

            obj_Servicio.STPODP = cmbTipoAlmacenaje.SelectedValue
            obj_Servicio.CTPALJ = cmbTipoServicio.SelectedValue
            obj_Servicio.FechaInicio = IIf(Me.chkFecha.Checked, Me.dtFeInicial.Value, "")
            obj_Servicio.FechaFin = IIf(Me.chkFecha.Checked, Me.dtFeFinal.Value, "")
            txtBusqueda.Text = IIf(txtBusqueda.Text = "", 0, txtBusqueda.Text)
            Select Case cmbCriterioReporte.SelectedIndex
                Case 0
                    If obj_Servicio.CCLNT = 0 Then
                        MsgBox("Debe Seleccionar un Cliente", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Case 1
                    If txtBusqueda.Text = 0 Then
                        MsgBox("Debe Seleccionar un Nro. de Operación", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    obj_Servicio.NOPRCN = txtBusqueda.Text
                    obj_Servicio.NSECFC = 0
                Case 2
                    If txtBusqueda.Text = 0 Then
                        MsgBox("Debe Seleccionar un Nro. de Revisión", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    obj_Servicio.NOPRCN = 0
                    obj_Servicio.NSECFC = txtBusqueda.Text
            End Select
            '==========OBTENEMOS TIPO DE CAMBIO DEL DIA=========            
            tipo_cambio = obj_Logica.Obtener_Tipo_Cambio(obj_Servicio)
            valor_igv = obj_Logica.Obtener_igv_actual(obj_Servicio)
            If tipo_cambio = 0 Then
                MsgBox("No existe Tipo de Cambio para el Dia de Hoy")
                Exit Sub
            End If
            '======================================================
            If obj_Servicio.CDVSN = "S" OrElse obj_Servicio.CDVSN = "T" Then
                '================SIL================
                'If obj_Servicio.NSECFC > 0 And chkDetallado.Checked Then
                '    Dim strMensaje As String = String.Empty
                '    obj_Negocio.pExportarConsistenciaRevisionExcel(obj_Servicio, tipo_cambio, valor_igv, IIf(rbOc.Checked, "O", "I"), strMensaje)
                '    If strMensaje <> String.Empty Then
                '        MsgBox(strMensaje)
                '    End If
                '    Exit Sub
                'Else
                objDt = obj_Logica.Lista_Detalle_Servicios_SIL(obj_Servicio)
                'End If
            ElseIf obj_Servicio.CDVSN = "R" Then
            obj_Servicio.TIPO = IIf(chkDetallado.Checked, "1", "0")
            '================Almacen================

            If obj_Servicio.CTPALJ = "0" Then
                Dim objDsSustentos As New DataSet
                objDsSustentos = obj_Logica.Lista_Detalle_Servicios_Almacen_All(obj_Servicio)

                If chkDetallado.Checked Then

                    GenerarSustenoDetalladoExcel(objDsSustentos, obj_Servicio)
                Else
                    GenerarSustenoResumenExcel(objDsSustentos, obj_Servicio)
                End If
                Exit Sub
            Else
                If obj_Servicio.NSECFC > 0 And chkDetallado.Checked Then
                    Dim strMensaje As String = String.Empty
                    obj_Negocio.pExportarConsistenciaRevisionExcel(obj_Servicio, tipo_cambio, valor_igv, IIf(rbOc.Checked, "O", "I"), strMensaje)
                    If strMensaje <> String.Empty Then
                        MsgBox(strMensaje)
                    End If
                    Exit Sub
                Else
                    objDt = obj_Logica.Lista_Detalle_Servicios_Almacen(obj_Servicio)
                End If

            End If
            Else : Exit Sub
            End If

                If objDt.Rows.Count = 0 Then
                    MsgBox("No tiene registros", MessageBoxIcon.Information)
                    Exit Sub
                End If

                objDt.Columns.Add("TIPO_CAMBIO")

                For i As Integer = 0 To objDt.Rows.Count - 1
                    objDt.Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
                Next

                '========================TABLA APOYO======================

                Dim oDtUtil As New DataTable
                oDtUtil.TableName = "UTILES"
                oDtUtil.Columns.Add("IGV")
                oDtUtil.Columns.Add("TIPO_CAMBIO")
                Dim rowUtil As DataRow
                rowUtil = oDtUtil.NewRow
                rowUtil(0) = valor_igv
                rowUtil(1) = tipo_cambio
                oDtUtil.Rows.Add(rowUtil)
                oDtUtil.TableName = "UTILES"
                '====================================DANDO FORMATO A TABLAS============================
                '======================================================================================
                Dim oDtFiltro As New DataTable
                Dim oDtDetalle As New DataTable
                oDtDetalle = objDt.Copy
                '===PARA EL FILTRO===
                oDtFiltro.TableName = "Filtro"
                oDtFiltro.Columns.Add("Filtro")
                oDtFiltro.Columns.Add("Valor")
                Dim row As DataRow
                row = oDtFiltro.NewRow
                row(0) = "Compañia :"
                row(1) = cmbCompania.Text
                oDtFiltro.Rows.Add(row)
                row = oDtFiltro.NewRow
                row(0) = "División :"
                row(1) = cmbDivision.Text
                oDtFiltro.Rows.Add(row)
                row = oDtFiltro.NewRow
                row(0) = "Planta :"
                row(1) = cmbPlanta.Text
                oDtFiltro.Rows.Add(row)
                If UcCliente.pCodigo > 0 Then
                    row = oDtFiltro.NewRow
                    row(0) = "Cliente :"
                    row(1) = UcCliente.pCodigo & " - " & UcCliente.pRazonSocial
                    oDtFiltro.Rows.Add(row)
                End If
                If obj_Servicio.NSECFC > 0 Then
                    row = oDtFiltro.NewRow
                    row(0) = "Nro. Consistencia :"
                    row(1) = obj_Servicio.NSECFC.ToString
                    oDtFiltro.Rows.Add(row)
                End If


                '============================
                '==== PARA EL RESUMEN =======
                '============================
                Dim oDtResumen As DataTable = oDtDetalle.Copy
                Dim colResumen As Integer = oDtResumen.Columns.Count - 1
                Dim tarifa1 As Integer = 0
                Dim tarifa2 As Integer = 0
                Dim bTrfInicia As Boolean = True
                Dim ldblSub_total As Double = 0D
                Dim iPosIni As Integer = 0
                Dim oDv As New DataView(oDtResumen)
                oDv.Sort = "NRTFSV ASC"

                oDtResumen = oDv.ToTable(True, "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")


                For i As Integer = 0 To oDtResumen.Rows.Count - 1
                    If i = 0 Then
                        tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                        iPosIni = i
                    Else
                        tarifa2 = oDtResumen.Rows(i).Item("NRTFSV")
                        If tarifa1 = tarifa2 Then
                            oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") = oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") + oDtResumen.Rows(i).Item("SUB_TOTAL")
                            oDtResumen.Rows(iPosIni).Item("QATNAN") = oDtResumen.Rows(iPosIni).Item("QATNAN") + oDtResumen.Rows(i).Item("QATNAN")
                            oDtResumen.Rows(i).Item("QATNAN") = 0
                        Else
                            tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                            iPosIni = i
                        End If
                    End If
                Next
                oDtResumen.Columns.RemoveAt(0) ' QUITO LA OPERACION USADA COMO FLAG
                Dim objListaDr As DataRow() = oDtResumen.Select("QATNAN > 0")
                Dim objDr As DataRow
                Dim lintCont As Integer
                Dim objDtDet As New DataTable
                objDtDet.Columns.Add("NRTFSV")
                objDtDet.Columns.Add("TCMTRF")
                objDtDet.Columns.Add("MONEDA")
                objDtDet.Columns.Add("IVLSRV", GetType(System.Double))
                objDtDet.Columns.Add("QATNAN", GetType(System.Double))
                objDtDet.Columns.Add("TOTAL_SOLES", GetType(System.Double))
                objDtDet.Columns.Add("TOTAL_DOLARES", GetType(System.Double))
                For lintCont = 0 To objListaDr.Length - 1
                    objDr = objDtDet.NewRow
                    objDr(0) = objListaDr(lintCont).Item("NRTFSV") 'TARIFA
                    objDr(1) = objListaDr(lintCont).Item("TCMTRF") 'SERVICIO
                    objDr(2) = objListaDr(lintCont).Item("TMNDA")  'MONEDA
                    objDr(3) = objListaDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                    objDr(4) = objListaDr(lintCont).Item("QATNAN") 'CANTIDAD
                    ldblSub_total = objListaDr(lintCont).Item("SUB_TOTAL")
                    If objDr(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                        objDr(5) = Math.Round(ldblSub_total, 2)  'IMPORTE SOLES
                        objDr(6) = Math.Round(ldblSub_total / tipo_cambio, 2) 'IMPORTE DOLARES
                    Else 'CUANDO ES EN DOLARES
                        objDr(5) = Math.Round(ldblSub_total * tipo_cambio, 2) 'IMPORTE SOLES
                        objDr(6) = Math.Round(ldblSub_total, 2) 'IMPORTE DOLARES
                    End If
                    objDtDet.Rows.Add(objDr)
            Next lintCont

            Dim oDtResLotePrint As New DataTable
            Dim oDtCiPrint As New DataTable

            If obj_Servicio.CDVSN = "R" Then

                '=======================================
                '====== PARA EL RESUMEN DE LOTES =======
                '=======================================
                oDtResLotePrint = GenerarLote(obj_Servicio.CTPALJ, oDtDetalle)

                '==================RESUMEN PARA LA CUENTA DE IMPUTACION===========================
                If obj_Servicio.CTPALJ = "RE" Then
                    oDtCiPrint = GeneraCI(oDtDetalle)

                End If

            End If
            '=======================================
            '=======================================

            objDt.TableName = "Detallle"

            If obj_Servicio.CDVSN = "R" Then objDt.DefaultView.Sort = "NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA,NCRROP" Else _
            objDt.DefaultView.Sort = "NOPRCN,NRTFSV,TCMTRF, IVLSRV, QATNAN, SUB_TOTAL, TMNDA"
            objDt = objDt.DefaultView.ToTable
            oDtFiltro.TableName = "Filtro"
            oDtResumen.TableName = "Resumen"
            objDtDet.TableName = "Resumen"

            If tipoReporte = ServicioOperacion.TipoReporte.Excel Then
                objDs.Tables.Add(objDt.Copy) 'Detallle
            Else
                If tipoReporte = ServicioOperacion.TipoReporte.Rpt And Not chkDetallado.Checked Then
                    objDs.Tables.Add(ResumenTable(objDt, tipoReporte).Copy) 'Resumen para el reporte
                Else
                    objDs.Tables.Add(objDt.Copy) 'Detallle
                End If

            End If


            objDs.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDs.Tables.Add(objDtDet.Copy) 'Resumen
            objDs.Tables.Add(oDtUtil.Copy) 'Utiles



            If objServicio.CDVSN = "R" Then objDs.Tables.Add(oDtResLotePrint.Copy) 'Resumen Lotes
            If objServicio.CTPALJ = "RE" Then objDs.Tables.Add(oDtCiPrint.Copy) 'Resumen CI


            EmitirReporteExcel(objDs, obj_Servicio, tipoReporte)

           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GenerarLote(ByVal TipoSev As String, ByVal oDtDetalle As DataTable) As DataTable
        Dim dtFiltro As New DataTable
        Dim oDtResLotePrint As New DataTable


        Dim oDtResLote As DataTable = oDtDetalle.Copy

        Dim oDvLote As New DataView(oDtResLote)
        Dim objDataRow As DataRow
        Dim TotMntSoles As Double = 0D
        Dim TotMntDolares As Double = 0D
        oDvLote.Sort = "LOTE ASC"
        oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP", "QATNAN", "VALCTE")
        Dim OriginalCount As Integer = oDtResLote.Rows.Count

        oDtResLote.Columns.Remove("NOPRCN")

        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0
            dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")

            If TipoSev = "RE" Then
                For Each dr As DataRow In dtFiltro.Rows '
                    If dr("TMNDA").ToString.Trim = "USD" Then

                        If Val(dr("VALCTE")) > 0 Then
                            TotMntSoles += dr("QATNAN") * tipo_cambio + (dr("QATNAN") * tipo_cambio * dr("VALCTE") / 100)
                            TotMntDolares += dr("QATNAN") + (dr("QATNAN") * dr("VALCTE") / 100)
                        Else
                            TotMntSoles += Convert.ToDouble(dr("QATNAN")) * tipo_cambio
                            TotMntDolares += Convert.ToDouble(dr("QATNAN"))
                        End If
                       
                    Else
                        If Val(dr("VALCTE")) > 0 Then
                            TotMntSoles += dr("QATNAN") + (dr("QATNAN") * dr("VALCTE") / 100)
                        Else
                            TotMntSoles += dr("QATNAN")
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            If Val(dr("VALCTE")) > 0 Then
                                TotMntDolares += dr("QATNAN") / tipo_cambio + (dr("QATNAN") / tipo_cambio * dr("VALCTE") / 100)
                            Else
                                TotMntDolares += dr("QATNAN") / tipo_cambio
                            End If


                        End If
                    End If
                Next
            Else
                For Each dr As DataRow In dtFiltro.Rows '
                    If dr("TMNDA").ToString.Trim = "USD" Then
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If
                Next
            End If
            


            If dtFiltro.Rows.Count > 0 Then
                objDataRow = oDtResLotePrint.NewRow
                objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                objDataRow.Item("SOLES") = TotMntSoles.ToString("N2")
                objDataRow.Item("DOLARES") = TotMntDolares.ToString("N2")
                oDtResLotePrint.Rows.Add(objDataRow)
                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        Return oDtResLotePrint
    End Function

    Private Function GeneraCargoPlanDetalle(ByVal oDt As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow

        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("Moneda").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("Monto a Cobrar"))

                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("Monto a Cobrar")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("Monto a Cobrar") = TotMntDolares


                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("Monto a Cobrar") = TotMntDolares
                        drAux("Estado Facturación") = row("Estado Facturación")
                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        Return oDtAux
    End Function

    Private Function GeneraCargoPlanDetalle_ALL(ByVal oDt As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE

        Dim TotMntDolares As Decimal = 0
        oDtAux = oDt.Clone
        Dim drAux As DataRow

        Dim cantCargoPlan As Integer = 0
        For Each row As DataRow In oDt.Rows

            If row("CI").ToString.Trim = "IMP_CARGO_PLAN" Then
                obe.NGUITR = row("NGUITR")
                obe.CTRMNC = row("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)
                cantCargoPlan = 0
                For Each dr As DataRow In oDtCagoPlan.Rows


                    If row("TMNDA").ToString.Trim = "USD" Then

                        TotMntDolares = Convert.ToDouble(row("SUB_TOTAL"))

                    Else

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            TotMntDolares = Convert.ToDouble(row("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If


                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    If cantCargoPlan = 0 Then

                        oDtAux.ImportRow(row)

                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("CI") = dr("CI")
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("PORCENTAJE") = dr("PRCRMT")
                        
                        oDtAux.Rows(oDtAux.Rows.Count - 1).Item("SUB_TOTAL") = TotMntDolares


                        oDtAux.AcceptChanges()
                    Else
                        drAux = oDtAux.NewRow
                        drAux("CI") = dr("CI")
                        drAux("PORCENTAJE") = dr("PRCRMT")
                        drAux("SUB_TOTAL") = TotMntDolares

                        'drAux("TMNDA") = row("TMNDA")
                        'drAux("QATNAN") = row("QATNAN")
                        'drAux("IVLSRV") = row("IVLSRV")
                        drAux("SESTRG_SERV") = row("SESTRG_SERV")
                        oDtAux.Rows.Add(drAux)

                    End If


                    cantCargoPlan += 1
                Next
            Else
                oDtAux.ImportRow(row)
            End If


        Next
        Return oDtAux
    End Function

    Private Function GeneraCICargoPlan(ByVal _oServicio As Servicio_BE) As DataTable
        Dim oServicioNeg As New clsServicio_BL
        Dim oDs As New DataSet
        Dim oDtCI As New DataTable
        Dim oDtOC_Dist As New DataTable

        Dim oDtCIFiltro As New DataTable
        Dim where As String = ""
        Dim sumaCI As Double = 0D

        Dim oDtTemp As New DataTable
        Dim oDtOCTemp As New DataTable

        ' === Creamos Structura Tabla Distribución === 
        oDtOCTemp.Columns.Add("FLG")
        oDtOCTemp.Columns.Add("CI")
        oDtOCTemp.Columns.Add("POR")
        ' ========== ========== ========== ============

        oDs = oServicioNeg.Importa_CI_CargoPlan(_oServicio)
        oDtCI = oDs.Tables(0)
        oDtOC_Dist = oDs.Tables(1)
        Dim oDtFinal As New DataTable

        oDtFinal.Columns.Add("CI", GetType(String))
        oDtFinal.Columns.Add("PRCRMT", GetType(Decimal))
        Dim drFinal As DataRow
        If oDtOC_Dist.Rows.Count = 0 Then
            '============Distribución Simple================
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                where = "CI = '" & oDtCI.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtCI, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("PRCRMT")
                Next

                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        Else
            '============Hacemos distribucion adicional por OC============
            Dim iRow As DataRow
            For i As Integer = 0 To oDtCI.Rows.Count - 1
                '=========================Buscamos OC=========================
                where = "NORCML = '" & oDtCI.Rows(i).Item("NORCML").ToString.Trim & "' "
                oDtTemp = BuscarDatatable(oDtOC_Dist, where)
                If oDtTemp.Rows.Count > 0 Then
                    For Each oDrOC As DataRow In oDtTemp.Rows
                        iRow = oDtOCTemp.NewRow
                        iRow("FLG") = "DISTRIBUIDOS"
                        Select Case oDtCI.Rows(i).Item("CMEDTR")
                            Case "4" 'TERRESTRE
                                iRow("CI") = oDrOC("TCTCST")
                            Case "1" 'AEREO
                                iRow("CI") = oDrOC("TCTCSA")
                            Case "5" ' FLUVIAL
                                iRow("CI") = oDrOC("TCTCSF")
                        End Select
                        iRow("POR") = oDtCI.Rows(i).Item("PRCRMT") * oDrOC("IPRCTJ") * 0.01 ' VALOR DEL PORCENTAJE DISTRIBUIDO
                        oDtOCTemp.Rows.Add(iRow)
                    Next
                Else
                    iRow = oDtOCTemp.NewRow
                    iRow("FLG") = "NORMAL"
                    iRow("CI") = oDtCI.Rows(i).Item("CI")
                    iRow("POR") = oDtCI.Rows(i).Item("PRCRMT")
                    oDtOCTemp.Rows.Add(iRow)
                End If
            Next
            oDtOCTemp.DefaultView.Sort = "CI"
            oDtOCTemp = oDtOCTemp.DefaultView.ToTable()
            For i As Integer = 0 To oDtOCTemp.Rows.Count - 1
                where = "CI = '" & oDtOCTemp.Rows(i)("CI").ToString.Trim & "' "
                oDtCIFiltro = BuscarDatatable(oDtOCTemp, where)
                For Each oDrSuma As DataRow In oDtCIFiltro.Rows
                    sumaCI = sumaCI + oDrSuma("POR")
                Next


                drFinal = oDtFinal.NewRow

                drFinal("CI") = oDtOCTemp.Rows(i)("CI").ToString.Trim
                drFinal("PRCRMT") = Math.Round(sumaCI, 4)
                oDtFinal.Rows.Add(drFinal)

                sumaCI = 0D
                i = i + oDtCIFiltro.Rows.Count - 1
            Next
            Return oDtFinal
        End If

        Return oDtFinal
    End Function

    Private Function BuscarDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function

    Private Sub GenerarSustenoResumenExcel(ByVal objDsSustentos As DataSet, ByVal obj_Servicio As Servicio_BE)
        Dim oDtResLotePrint As New DataTable
        Dim dtFiltro As New DataTable
        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")
        Dim ListDs As New List(Of DataSet)
        Dim tipoConsistencia As String = ""
        Dim Nrorepo As Integer = 1
        For Each dt As DataTable In objDsSustentos.Tables
            Dim objDt As New DataTable
            Dim objDs As New DataSet
            objDt = dt
            If objDt.Rows.Count = 0 Then
                Nrorepo += 1
                Continue For
            Else
                Select Case Nrorepo
                    Case 1
                        tipoConsistencia = "Servicio_Bultos"
                    Case 2
                        tipoConsistencia = "Servicio_Mercaderia"
                    Case 3
                        tipoConsistencia = "Servicio_Reembolso"
                    Case 4
                        tipoConsistencia = "Servicio_Promedio"
                End Select
                Nrorepo += 1
            End If
            objDt.Columns.Add("TIPO_CAMBIO")
            For i As Integer = 0 To objDt.Rows.Count - 1
                objDt.Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next
            '========================TABLA APOYO======================
            Dim oDtUtil As New DataTable
            oDtUtil.TableName = "UTILES"
            oDtUtil.Columns.Add("IGV")
            oDtUtil.Columns.Add("TIPO_CAMBIO")
            Dim rowUtil As DataRow
            rowUtil = oDtUtil.NewRow
            rowUtil(0) = valor_igv
            rowUtil(1) = tipo_cambio
            oDtUtil.Rows.Add(rowUtil)
            oDtUtil.TableName = "UTILES"
            '====================================DANDO FORMATO A TABLAS============================
            '======================================================================================
            Dim oDtFiltro As New DataTable
            Dim oDtDetalle As New DataTable
            oDtDetalle = objDt.Copy
            '===PARA EL FILTRO===
            oDtFiltro.TableName = "Filtro"
            oDtFiltro.Columns.Add("Filtro")
            oDtFiltro.Columns.Add("Valor")
            Dim row As DataRow
            row = oDtFiltro.NewRow
            row(0) = "Compañia :"
            row(1) = cmbCompania.Text
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "División :"
            row(1) = cmbDivision.Text
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "Planta :"
            row(1) = cmbPlanta.Text
            oDtFiltro.Rows.Add(row)
            If UcCliente.pCodigo > 0 Then
                row = oDtFiltro.NewRow
                row(0) = "Cliente :"
                row(1) = UcCliente.pCodigo & " - " & UcCliente.pRazonSocial
                oDtFiltro.Rows.Add(row)
            End If



            '==== PARA EL RESUMEN =====
            Dim oDtResumen As DataTable = oDtDetalle.Copy
            Dim colResumen As Integer = oDtResumen.Columns.Count - 1
            Dim tarifa1 As Integer = 0
            Dim tarifa2 As Integer = 0
            Dim bTrfInicia As Boolean = True
            Dim ldblSub_total As Double = 0D
            Dim iPosIni As Integer = 0
            Dim oDv As New DataView(oDtResumen)
            oDv.Sort = "NRTFSV ASC"
            oDtResumen = oDv.ToTable(True, "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")

            Dim dtRes As DataTable = oDv.ToTable(True, "NRTFSV", "TCMTRF")

            For i As Integer = 0 To oDtResumen.Rows.Count - 1
                If i = 0 Then
                    tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                    iPosIni = i
                Else
                    tarifa2 = oDtResumen.Rows(i).Item("NRTFSV")
                    If tarifa1 = tarifa2 Then
                        oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") = oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") + oDtResumen.Rows(i).Item("SUB_TOTAL")
                        oDtResumen.Rows(iPosIni).Item("QATNAN") = oDtResumen.Rows(iPosIni).Item("QATNAN") + oDtResumen.Rows(i).Item("QATNAN")
                        oDtResumen.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                        iPosIni = i
                    End If
                End If
            Next
            oDtResumen.Columns.RemoveAt(0) 'QUITO LA OPERACION USADA COMO FLAG
            Dim objListaDr As DataRow() = oDtResumen.Select("QATNAN > 0")
            Dim objDr As DataRow
            Dim lintCont As Integer
            Dim objDtDet As New DataTable
            objDtDet.Columns.Add("NRTFSV")
            objDtDet.Columns.Add("TCMTRF")
            objDtDet.Columns.Add("MONEDA")
            objDtDet.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDet.Columns.Add("QATNAN", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_DOLARES", GetType(System.Double))
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDtDet.NewRow
                objDr(0) = objListaDr(lintCont).Item("NRTFSV") 'TARIFA
                objDr(1) = objListaDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDr(2) = objListaDr(lintCont).Item("TMNDA")  'MONEDA
                objDr(3) = objListaDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDr(4) = objListaDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_total = objListaDr(lintCont).Item("SUB_TOTAL")
                If objDr(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDr(5) = Math.Round(ldblSub_total, 2)  'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDr(5) = Math.Round(ldblSub_total * tipo_cambio, 2) 'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total, 2) 'IMPORTE DOLARES
                End If
                objDtDet.Rows.Add(objDr)
            Next lintCont

            '=======================================
            '====== PARA EL RESUMEN DE LOTES =======
            '=======================================
            Dim oDtResLote As DataTable = oDtDetalle.Copy
            Dim oDvLote As New DataView(oDtResLote)

            Dim objDataRow As DataRow
            Dim TotMntSoles As Double = 0D
            Dim TotMntDolares As Double = 0D
            oDvLote.Sort = "LOTE ASC"
            oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP")

            oDtResLote.Columns.Remove("NOPRCN")

            Dim OriginalCount As Integer = oDtResLote.Rows.Count

            For i As Integer = 0 To OriginalCount - 1
                'drSelect = oDtResLote.Select("LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")
                dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")
                TotMntSoles = 0
                TotMntDolares = 0
                For Each dr As DataRow In dtFiltro.Rows
                    If dr("TMNDA").ToString.Trim = "USD" Then
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If
                Next
                If dtFiltro.Rows.Count > 0 Then
                    objDataRow = oDtResLotePrint.NewRow
                    objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtResLotePrint.Rows.Add(objDataRow)
                    i = i + dtFiltro.Rows.Count - 1
                End If
            Next i
            '=======================================
            '=======================================
            '==================RESUMEN PARA LA CUENTA DE IMPUTACION SOLO PARA REEMBOLSO============
            Dim oDtCiPrint As New DataTable
            If tipoConsistencia = "Servicio_Reembolso" Then oDtCiPrint = GeneraCI(objDt)
            '======================================================================================    

            objDs.Tables.Add(objDt.Copy) 'Detallle
            objDs.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDs.Tables.Add(objDtDet.Copy) 'Resumen
            objDs.Tables.Add(oDtResLotePrint.Copy) 'Resumen Lotes
            '==============================FORMATEANDO EL EXCEL======================================
            Dim odsExcel As New DataSet
            ''''Reset la tabla ''''
            Dim otblAlm As New DataTable
            otblAlm = objDs.Tables(0).Copy
            '==========ALMACEN============  
            Dim oDtResumenAlmacen As New DataTable

            Dim blExisteAlmacen As Boolean = False
            Dim Rubro As String = String.Empty
            Dim Servicio As String = String.Empty
            Dim NOPRCN As String = String.Empty

            'Nombra las columnas
            oDtResumenAlmacen = ResumenTable(otblAlm, TipoReporte.Excel)
            otblAlm = oDtResumenAlmacen

            If otblAlm.Columns("NGUITR") IsNot Nothing Then otblAlm.Columns.Remove("NGUITR")
            If otblAlm.Columns("CTRMNC") IsNot Nothing Then otblAlm.Columns.Remove("CTRMNC")
            If otblAlm.Columns("COD") IsNot Nothing Then otblAlm.Columns.Remove("COD")

            If otblAlm.Columns("TCTCST") IsNot Nothing Then otblAlm.Columns.Remove("TCTCST")
            If otblAlm.Columns("TCTCSA") IsNot Nothing Then otblAlm.Columns.Remove("TCTCSA")
            If otblAlm.Columns("TCTCSF") IsNot Nothing Then otblAlm.Columns.Remove("TCTCSF")

            If otblAlm.Columns("NRITOC") IsNot Nothing Then otblAlm.Columns.Remove("NRITOC")
            If otblAlm.Columns("TDITES") IsNot Nothing Then otblAlm.Columns.Remove("TDITES")
            If otblAlm.Columns("TLUGEN") IsNot Nothing Then otblAlm.Columns.Remove("TLUGEN")
            If otblAlm.Columns("QBLTSR") IsNot Nothing Then otblAlm.Columns.Remove("QBLTSR")
            If otblAlm.Columns("NSEQIN") IsNot Nothing Then otblAlm.Columns.Remove("NSEQIN")
            If otblAlm.Columns("VALCTE") IsNot Nothing Then otblAlm.Columns.Remove("VALCTE")
            If otblAlm.Columns("ITPCMT") IsNot Nothing Then otblAlm.Columns.Remove("ITPCMT")
            If otblAlm.Columns("ALMACEN") IsNot Nothing Then otblAlm.Columns.Remove("ALMACEN")

            otblAlm.TableName = tipoConsistencia
            odsExcel.Tables.Add(otblAlm.Copy)
            odsExcel.Tables.Add(objDs.Tables(1).Copy)
            odsExcel.Tables.Add(objDs.Tables(2).Copy)
            odsExcel.Tables.Add(oDtResLotePrint.Copy) 'LOTE
            odsExcel.Tables.Add(oDtCiPrint.Copy) 'CI
            oDtResLotePrint.Rows.Clear()
            ListDs.Add(odsExcel)
        Next

        Ransa.Utilitario.HelpClass_NPOI.ExportExcel_RZC20_General_List(ListDs)
    End Sub

    Private Function GeneraCI(ByVal oDtDetalle As DataTable) As DataTable
        Dim oDtCI As New DataTable
        Dim oDtCiPrint As New DataTable
        Dim oDtCiPrintFinal As New DataTable
        Dim dtFiltro As New DataTable
        oDtCI = oDtDetalle.Copy
        Dim oDvCI As New DataView(oDtCI)
        Dim oDtCagoPlan As New DataTable
        Dim obe As New Servicio_BE
        Dim objDataRow As DataRow = Nothing
        Dim TotMntSoles As Decimal = 0D
        Dim TotMntDolares As Decimal = 0D


        oDtCI = oDvCI.ToTable(True, "NOPRCN", "NRTFSV", "CI", "TMNDA", "NCRROP", "NGUITR", "CTRMNC", "QATNAN", "VALCTE")
        Dim OriginalCount As Integer = oDtCI.Rows.Count

        oDtCI.Columns.Remove("NOPRCN")

        oDtCiPrint.Columns.Add("CI")
        oDtCiPrint.Columns.Add("MONEDA")
        oDtCiPrint.Columns.Add("SOLES")
        oDtCiPrint.Columns.Add("DOLARES")
        oDtCiPrintFinal = oDtCiPrint.Clone

        oDtCI.DefaultView.Sort = "CI"
        oDtCI = oDtCI.DefaultView.ToTable

        For i As Integer = 0 To OriginalCount - 1

            TotMntSoles = 0
            TotMntDolares = 0

            '=============EN CASO DE QUE LA CUENTA IMPUTACION SEA DESDE UN CARGO PLAN==================
            If oDtCI.Rows(i)("CI").ToString.Trim = "IMP_CARGO_PLAN" Then

                obe.NGUITR = oDtCI.Rows(i)("NGUITR")
                obe.CTRMNC = oDtCI.Rows(i)("CTRMNC")
                oDtCagoPlan = GeneraCICargoPlan(obe)

                For Each dr As DataRow In oDtCagoPlan.Rows

                    If oDtCI.Rows(i)("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") * tipo_cambio + (oDtCI.Rows(i)("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            TotMntDolares = oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") * tipo_cambio
                            TotMntDolares = oDtCI.Rows(i)("QATNAN")
                        End If
                        

                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles = oDtCI.Rows(i)("QATNAN") + (oDtCI.Rows(i)("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles = oDtCI.Rows(i)("QATNAN")
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares = 0
                        Else
                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares = oDtCI.Rows(i)("QATNAN") / tipo_cambio + (oDtCI.Rows(i)("QATNAN") / tipo_cambio * oDtCI.Rows(i)("ITPCMT") / 100)
                            Else
                                TotMntDolares = oDtCI.Rows(i)("QATNAN") / tipo_cambio
                            End If

                        End If
                    End If

                    TotMntSoles = (TotMntSoles * dr("PRCRMT") / 100)
                    TotMntDolares = (TotMntDolares * dr("PRCRMT") / 100)

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = dr("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                Next


            Else
                '=============CUENTA DE IMPUTACION NORMAL
                dtFiltro = filtraDatatable(oDtCI, "CI = '" + oDtCI.Rows(i)("CI").ToString.Trim + "'")
                For Each dr As DataRow In dtFiltro.Rows

                    If dr("TMNDA").ToString.Trim = "USD" Then
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("QATNAN") * tipo_cambio + (dr("QATNAN") * tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            TotMntDolares += dr("QATNAN") + (dr("QATNAN") * oDtCI.Rows(i)("VALCTE") / 100)
                        Else
                            TotMntSoles += dr("QATNAN") * tipo_cambio + (dr("QATNAN") * tipo_cambio / 100)
                            TotMntDolares += dr("QATNAN")
                        End If
                       
                    Else
                        If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                            TotMntSoles += dr("QATNAN") * oDtCI.Rows(i)("VALCTE")
                        Else
                            TotMntSoles += Convert.ToDouble(dr("QATNAN"))
                        End If

                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            If Val("" & oDtCI.Rows(i)("VALCTE") & "") Then
                                TotMntDolares += dr("QATNAN") / tipo_cambio * oDtCI.Rows(i)("VALCTE") + (dr("QATNAN") / tipo_cambio * oDtCI.Rows(i)("VALCTE") / 100)
                            Else
                                TotMntDolares += dr("QATNAN") / tipo_cambio + (dr("QATNAN") / tipo_cambio / 100)
                            End If

                        End If
                    End If

                Next

                If dtFiltro.Rows.Count > 0 Then

                    objDataRow = oDtCiPrint.NewRow
                    objDataRow.Item("CI") = oDtCI.Rows(i)("CI").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtCI.Rows(i)("TMNDA").ToString.Trim

                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtCiPrint.Rows.Add(objDataRow)

                    i = i + dtFiltro.Rows.Count - 1
                End If


            End If

        Next i


        '=====se recorre nuevamente para saber si se encontro la misma cuenta ya sea en un cargo plan o registro normal=========
        oDtCiPrint.DefaultView.Sort = "CI"
        oDtCiPrint = oDtCiPrint.DefaultView.ToTable

        OriginalCount = oDtCiPrint.Rows.Count

        For i As Integer = 0 To OriginalCount - 1

            TotMntDolares = 0
            TotMntSoles = 0

            dtFiltro = filtraDatatable(oDtCiPrint, "CI = '" + oDtCiPrint.Rows(i)("CI").ToString.Trim + "'")
            For Each dr As DataRow In dtFiltro.Rows

                If dr("MONEDA").ToString.Trim = "USD" Then
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    TotMntDolares += Convert.ToDouble(dr("DOLARES"))

                Else
                    TotMntSoles += Convert.ToDouble(dr("SOLES"))
                    If tipo_cambio = 0 Then
                        TotMntDolares += 0
                    Else
                        TotMntDolares += Convert.ToDouble(dr("SOLES"))
                    End If
                End If

            Next

            If dtFiltro.Rows.Count > 0 Then

                objDataRow = oDtCiPrintFinal.NewRow
                objDataRow.Item("CI") = oDtCiPrint.Rows(i)("CI").ToString.Trim
                objDataRow.Item("MONEDA") = oDtCiPrint.Rows(i)("MONEDA").ToString.Trim

                objDataRow.Item("SOLES") = TotMntSoles
                objDataRow.Item("DOLARES") = TotMntDolares
                oDtCiPrintFinal.Rows.Add(objDataRow)

                i = i + dtFiltro.Rows.Count - 1
            End If
        Next i

        If oDtCiPrintFinal.Rows.Count > 0 Then oDtCiPrint = oDtCiPrintFinal


        Return oDtCiPrint
    End Function

    Private Function ResumenTableDetalle(ByVal objDt As DataTable) As DataTable

        Dim oDtDetalle As DataTable = objDt
        Dim oDtResumenAlmacen As New DataTable
        oDtResumenAlmacen = oDtDetalle.Clone


        Dim Operacion As String = ""
        Dim Guia As String = ""
        Dim FechaInicio As String = ""
        Dim FechaFin As String = ""
        Dim TipoServicio As String = ""
        Dim Bulto As String = ""
        Dim ChoferProveedor As String = ""
        Dim Placa As String = ""
        Dim Unidad As String = ""
        Dim TipoBulto As String = ""
        Dim CantidadBulto As String = ""
        Dim OrdenCompra As String = ""




        Dim nCount As Integer = 0
        Dim blExisteOperacion As Boolean = False
        Dim blExisteBulto As Boolean = False



        For i As Integer = 0 To oDtDetalle.Rows.Count - 1

            blExisteOperacion = False
            blExisteBulto = False

            If i = 0 Then
                Operacion = oDtDetalle.Rows(i).Item("Operación")
                Guia = oDtDetalle.Rows(i).Item("Guía").ToString
                FechaInicio = oDtDetalle.Rows(i).Item("Fecha Inicio Servicio").ToString
                Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim
                TipoServicio = oDtDetalle.Rows(i).Item("Tipo de Servicio").ToString
                ChoferProveedor = oDtDetalle.Rows(i).Item("Chofer / Proveedor").ToString
                Placa = oDtDetalle.Rows(i).Item("Placa").ToString
                Unidad = oDtDetalle.Rows(i).Item("Unidad").ToString
                TipoBulto = oDtDetalle.Rows(i).Item("Tipo de Bulto").ToString
                CantidadBulto = oDtDetalle.Rows(i).Item("Cantidad de Bulto").ToString
                OrdenCompra = oDtDetalle.Rows(i).Item("Orden de Compra").ToString

            End If



            
            If Operacion = oDtDetalle.Rows(i).Item("Operación") Then
                blExisteOperacion = True
            End If

            If Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim And blExisteOperacion Then
                blExisteBulto = True
            End If


            Operacion = oDtDetalle.Rows(i).Item("Operación").ToString
            Guia = oDtDetalle.Rows(i).Item("Guía").ToString
            FechaInicio = oDtDetalle.Rows(i).Item("Fecha Inicio Servicio").ToString
            Bulto = oDtDetalle.Rows(i).Item("Bulto").ToString.Trim
            TipoServicio = oDtDetalle.Rows(i).Item("Tipo de Servicio").ToString
            ChoferProveedor = oDtDetalle.Rows(i).Item("Chofer / Proveedor").ToString
            Placa = oDtDetalle.Rows(i).Item("Placa").ToString
            Unidad = oDtDetalle.Rows(i).Item("Unidad").ToString
            TipoBulto = oDtDetalle.Rows(i).Item("Tipo de Bulto").ToString
            CantidadBulto = oDtDetalle.Rows(i).Item("Cantidad de Bulto").ToString
            OrdenCompra = oDtDetalle.Rows(i).Item("Orden de Compra").ToString





            If blExisteOperacion And i > 0 Then
                oDtDetalle.Rows(i).Item("Operación") = 0
                oDtDetalle.Rows(i).Item("Fecha Inicio Servicio") = ""
                oDtDetalle.Rows(i).Item("Tipo de Servicio") = ""
            End If

            If blExisteBulto And i > 0 Then
                oDtDetalle.Rows(i).Item("Bulto") = ""
                oDtDetalle.Rows(i).Item("Referencia de Mercaderia") = ""
                oDtDetalle.Rows(i).Item("Cantidad de Bulto") = 0
                oDtDetalle.Rows(i).Item("Tipo de Bulto") = ""
                oDtDetalle.Rows(i).Item("Orden de Compra") = ""
            End If


            oDtDetalle.AcceptChanges()


        Next

        Return oDtDetalle
    End Function

    Private Sub GenerarSustenoDetalladoExcel(ByVal objDsSustentos As DataSet, ByVal obj_Servicio As Servicio_BE)
        Dim oDsConsistencia As New DataSet

        Dim oDtResLotePrint As New DataTable
        Dim dtFiltro As New DataTable
        oDtResLotePrint.Columns.Add("LOTE")
        oDtResLotePrint.Columns.Add("MONEDA")
        oDtResLotePrint.Columns.Add("SOLES")
        oDtResLotePrint.Columns.Add("DOLARES")
        Dim ListDs As New List(Of DataSet)
        Dim tipoConsistencia As String = ""
        Dim Nrorepo As Integer = 1
        For Each dt As DataTable In objDsSustentos.Tables
            Dim objDt As New DataTable
            Dim objDs As New DataSet
            objDt = dt
            If objDt.Rows.Count = 0 Then
                Nrorepo += 1
                Continue For
            Else
                Select Case Nrorepo
                    Case 1
                        tipoConsistencia = "Detalle_Bultos"
                    Case 2
                        tipoConsistencia = "Detalle_Mercaderia"
                    Case 3
                        tipoConsistencia = "Detalle_Reembolso"
                    Case 4
                        tipoConsistencia = "Detalle_Promedio"
                End Select
                Nrorepo += 1
            End If
            objDt.Columns.Add("TIPO_CAMBIO")
            For i As Integer = 0 To objDt.Rows.Count - 1
                objDt.Rows(i).Item("TIPO_CAMBIO") = tipo_cambio
            Next
            '========================TABLA APOYO======================
            Dim oDtUtil As New DataTable
            oDtUtil.TableName = "UTILES"
            oDtUtil.Columns.Add("IGV")
            oDtUtil.Columns.Add("TIPO_CAMBIO")
            Dim rowUtil As DataRow
            rowUtil = oDtUtil.NewRow
            rowUtil(0) = valor_igv
            rowUtil(1) = tipo_cambio
            oDtUtil.Rows.Add(rowUtil)
            oDtUtil.TableName = "UTILES"
            '====================================DANDO FORMATO A TABLAS============================
            '======================================================================================
            Dim oDtFiltro As New DataTable
            Dim oDtDetalle As New DataTable
            oDtDetalle = objDt.Copy
            '===PARA EL FILTRO===
            oDtFiltro.TableName = "Filtro"
            oDtFiltro.Columns.Add("Filtro")
            oDtFiltro.Columns.Add("Valor")
            Dim row As DataRow
            row = oDtFiltro.NewRow
            row(0) = "Compañia :"
            row(1) = cmbCompania.Text
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "División :"
            row(1) = cmbDivision.Text
            oDtFiltro.Rows.Add(row)
            row = oDtFiltro.NewRow
            row(0) = "Planta :"
            row(1) = cmbPlanta.Text
            oDtFiltro.Rows.Add(row)

            If cmbCriterioReporte.SelectedIndex = 0 Then
                row = oDtFiltro.NewRow
                row(0) = "Cliente :"
                row(1) = UcCliente.pCodigo & " - " & UcCliente.pRazonSocial
                oDtFiltro.Rows.Add(row)
            End If

            '==== PARA EL RESUMEN =====
            Dim oDtResumen As DataTable = oDtDetalle.Copy
            Dim colResumen As Integer = oDtResumen.Columns.Count - 1
            Dim tarifa1 As Integer = 0
            Dim tarifa2 As Integer = 0
            Dim bTrfInicia As Boolean = True
            Dim ldblSub_total As Double = 0D
            Dim iPosIni As Integer = 0
            Dim oDv As New DataView(oDtResumen)
            oDv.Sort = "NRTFSV ASC"
            oDtResumen = oDv.ToTable(True, "NOPRCN", "NRTFSV", "TCMTRF", "IVLSRV", "QATNAN", "SUB_TOTAL", "TMNDA", "NCRROP")

            For i As Integer = 0 To oDtResumen.Rows.Count - 1
                If i = 0 Then
                    tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                    iPosIni = i
                Else
                    tarifa2 = oDtResumen.Rows(i).Item("NRTFSV")
                    If tarifa1 = tarifa2 Then
                        oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") = oDtResumen.Rows(iPosIni).Item("SUB_TOTAL") + oDtResumen.Rows(i).Item("SUB_TOTAL")
                        oDtResumen.Rows(iPosIni).Item("QATNAN") = oDtResumen.Rows(iPosIni).Item("QATNAN") + oDtResumen.Rows(i).Item("QATNAN")
                        oDtResumen.Rows(i).Item("QATNAN") = 0
                    Else
                        tarifa1 = oDtResumen.Rows(i).Item("NRTFSV")
                        iPosIni = i
                    End If
                End If
            Next

            oDtResumen.Columns.RemoveAt(0) 'QUITO LA OPERACION USADA COMO FLAG

            Dim objListaDr As DataRow() = oDtResumen.Select("QATNAN > 0")
            Dim objDr As DataRow
            Dim lintCont As Integer
            Dim objDtDet As New DataTable
            objDtDet.Columns.Add("NRTFSV")
            objDtDet.Columns.Add("TCMTRF")
            objDtDet.Columns.Add("MONEDA")
            objDtDet.Columns.Add("IVLSRV", GetType(System.Double))
            objDtDet.Columns.Add("QATNAN", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_SOLES", GetType(System.Double))
            objDtDet.Columns.Add("TOTAL_DOLARES", GetType(System.Double))
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDtDet.NewRow
                objDr(0) = objListaDr(lintCont).Item("NRTFSV") 'TARIFA
                objDr(1) = objListaDr(lintCont).Item("TCMTRF") 'SERVICIO
                objDr(2) = objListaDr(lintCont).Item("TMNDA")  'MONEDA
                objDr(3) = objListaDr(lintCont).Item("IVLSRV") 'IMP TARIFA
                objDr(4) = objListaDr(lintCont).Item("QATNAN") 'CANTIDAD
                ldblSub_total = objListaDr(lintCont).Item("SUB_TOTAL")
                If objDr(2).ToString.Trim = "S/." Then 'CUANDO ES EN SOLES
                    objDr(5) = Math.Round(ldblSub_total, 2)  'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total / tipo_cambio, 2) 'IMPORTE DOLARES
                Else 'CUANDO ES EN DOLARES
                    objDr(5) = Math.Round(ldblSub_total * tipo_cambio, 2) 'IMPORTE SOLES
                    objDr(6) = Math.Round(ldblSub_total, 2) 'IMPORTE DOLARES
                End If
                objDtDet.Rows.Add(objDr)
            Next lintCont

            '=======================================
            '====== PARA EL RESUMEN DE LOTES =======
            '=======================================
            Dim oDtResLote As DataTable = oDtDetalle.Copy
            Dim oDvLote As New DataView(oDtResLote)

            Dim objDataRow As DataRow
            Dim TotMntSoles As Double = 0D
            Dim TotMntDolares As Double = 0D
            oDvLote.Sort = "LOTE ASC"
            oDtResLote = oDvLote.ToTable(True, "NOPRCN", "NRTFSV", "LOTE", "SUB_TOTAL", "TMNDA", "NCRROP")

            oDtResLote.Columns.Remove("NOPRCN")

            Dim OriginalCount As Integer = oDtResLote.Rows.Count

            For i As Integer = 0 To OriginalCount - 1
                'drSelect = oDtResLote.Select("LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")
                dtFiltro = filtraDatatable(oDtResLote, "LOTE = '" + oDtResLote.Rows(i)("LOTE").ToString.Trim + "'")
                TotMntSoles = 0
                TotMntDolares = 0
                For Each dr As DataRow In dtFiltro.Rows
                    If dr("TMNDA").ToString.Trim = "USD" Then
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL")) * tipo_cambio
                        TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL"))
                    Else
                        TotMntSoles += Convert.ToDouble(dr("SUB_TOTAL"))
                        If tipo_cambio = 0 Then
                            TotMntDolares += 0
                        Else
                            TotMntDolares += Convert.ToDouble(dr("SUB_TOTAL")) / tipo_cambio
                        End If
                    End If
                Next
                If dtFiltro.Rows.Count > 0 Then
                    objDataRow = oDtResLotePrint.NewRow
                    objDataRow.Item("LOTE") = oDtResLote.Rows(i)("LOTE").ToString.Trim
                    objDataRow.Item("MONEDA") = oDtResLote.Rows(i)("TMNDA").ToString.Trim
                    objDataRow.Item("SOLES") = TotMntSoles
                    objDataRow.Item("DOLARES") = TotMntDolares
                    oDtResLotePrint.Rows.Add(objDataRow)
                    i = i + dtFiltro.Rows.Count - 1
                End If
            Next i
            '=======================================
            Dim oDtCiPrint As New DataTable
            '=========RESUMEN DE CUENTA DE IMPUTACION=================
            If tipoConsistencia = "Detalle_Reembolso" Then
                oDtCiPrint = GeneraCI(oDtDetalle)
            End If
            '======================================================================================    
            objDs.Tables.Add(objDt.Copy) 'Detallle
            objDs.Tables.Add(oDtFiltro.Copy) 'Filtro
            objDs.Tables.Add(objDtDet.Copy) 'Resumen
            objDs.Tables.Add(oDtResLotePrint.Copy) 'Resumen Lotes
            '==============================FORMATEANDO EL EXCEL======================================
            Dim odsExcel As New DataSet
            ''''Reset la tabla ''''
            Dim otblAlm As New DataTable
            otblAlm = objDs.Tables(0).Copy

            Dim TCMPCL As String = ""
            Dim NOPRCN As String = ""
            Dim TMNDA As String = ""
            Dim NRTFSV As String = ""
            Dim SERVICIO As String = ""
            Dim TCMTRF As String = ""
            Dim IVLSRV As String = "" 'tarida
            Dim QATNAN As Decimal = 0 'cantidad
            Dim SUB_TOTAL As Decimal = 0 'monto a cobrar
            Dim sQATNAN As String = "" 'cantidad
            Dim sSUB_TOTAL As String = "" 'monto a cobrar
            Dim SESTRG_SERV As String = ""
            Dim NCRROP As String = ""


            Dim blExiste As Boolean = False
            Dim blExisteOper As Boolean = False
            For i As Integer = 0 To otblAlm.Rows.Count - 1


                blExiste = False
                blExisteOper = False
                If i = 0 Then
                    TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                    NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                    TMNDA = otblAlm.Rows(i).Item("TMNDA")
                    NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                    SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                    TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                    IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                    sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                    sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                    SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                    NCRROP = otblAlm.Rows(i).Item("NCRROP")


                End If
                If Not tipoConsistencia = "Detalle_Reembolso" Then
                    If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                          NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                          TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                          NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                          SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                          TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                          IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                          SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") And _
                                          sQATNAN = otblAlm.Rows(i).Item("QATNAN") And _
                                          NCRROP = otblAlm.Rows(i).Item("NCRROP") And _
                                          sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL") Then
                        blExiste = True
                    End If
                Else
                    If TCMPCL = otblAlm.Rows(i).Item("TCMPCL") And _
                                                              NOPRCN = otblAlm.Rows(i).Item("NOPRCN") And _
                                                              TMNDA = otblAlm.Rows(i).Item("TMNDA") And _
                                                              NRTFSV = otblAlm.Rows(i).Item("NRTFSV") And _
                                                              SERVICIO = otblAlm.Rows(i).Item("SERVICIO") And _
                                                              TCMTRF = otblAlm.Rows(i).Item("TCMTRF") And _
                                                              IVLSRV = otblAlm.Rows(i).Item("IVLSRV") And _
                                                              SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV") Then
                        blExiste = True
                    End If
                End If


                If NOPRCN = otblAlm.Rows(i).Item("NOPRCN") Then
                    blExisteOper = True
                End If




                TCMPCL = otblAlm.Rows(i).Item("TCMPCL")
                NOPRCN = otblAlm.Rows(i).Item("NOPRCN")
                TMNDA = otblAlm.Rows(i).Item("TMNDA")
                NRTFSV = otblAlm.Rows(i).Item("NRTFSV")
                SERVICIO = otblAlm.Rows(i).Item("SERVICIO")
                TCMTRF = otblAlm.Rows(i).Item("TCMTRF")
                IVLSRV = otblAlm.Rows(i).Item("IVLSRV")
                sQATNAN = otblAlm.Rows(i).Item("QATNAN")
                sSUB_TOTAL = otblAlm.Rows(i).Item("SUB_TOTAL")
                SESTRG_SERV = otblAlm.Rows(i).Item("SESTRG_SERV")
                NCRROP = otblAlm.Rows(i).Item("NCRROP")


                If blExisteOper And i > 0 Then
                    otblAlm.Rows(i).Item("NOPRCN") = 0
                    otblAlm.Rows(i).Item("TIPRO") = ""
                    otblAlm.Rows(i).Item("FOPRCN") = ""
                    otblAlm.Rows(i).Item("TRDCCL") = ""
                End If


                If blExiste And i > 0 Then
                    If Not tipoConsistencia = "Detalle_Reembolso" Then
                        otblAlm.Rows(i).Item("TCMPCL") = ""
                        otblAlm.Rows(i).Item("TMNDA") = ""
                        otblAlm.Rows(i).Item("NRTFSV") = 0
                        otblAlm.Rows(i).Item("SERVICIO") = ""
                        otblAlm.Rows(i).Item("TCMTRF") = ""
                        otblAlm.Rows(i).Item("FATNSR") = ""
                        otblAlm.Rows(i).Item("IVLSRV") = 0
                        otblAlm.Rows(i).Item("QATNAN") = 0
                        If Not otblAlm.Columns("QATNRL") Is Nothing Then
                            otblAlm.Rows(i).Item("QATNRL") = 0
                        End If
                        otblAlm.Rows(i).Item("SUB_TOTAL") = 0
                        otblAlm.Rows(i).Item("SESTRG_SERV") = ""
                        otblAlm.Rows(i).Item("TRFSRC") = ""
                        otblAlm.AcceptChanges()
                    Else
                        otblAlm.Rows(i).Item("TCMPCL") = ""
                        otblAlm.Rows(i).Item("SERVICIO") = ""
                        otblAlm.Rows(i).Item("TCMTRF") = ""
                        otblAlm.Rows(i).Item("NRTFSV") = 0
                        otblAlm.AcceptChanges()
                    End If


                End If

            Next




            '==========ALMACEN============         
            With otblAlm
                .Columns.Remove("cclnt")
                .Columns.Remove("ccmpn")
                .Columns.Remove("cdvsn")
                .Columns.Remove("SESTRG")
                .Columns.Remove("TIPO_CAMBIO")
                .Columns.Remove("NSECFC")

              
                'If .Columns("QAROCP") IsNot Nothing Then
                '    .Columns.Remove("QAROCP")
                'End If
                Dim index As Integer = 0
                .Columns("TCMPCL").SetOrdinal(index)
                index += 1
                .Columns("NOPRCN").SetOrdinal(index)
                index += 1
                .Columns("FOPRCN").SetOrdinal(index)
                index += 1
                .Columns("TIPRO").SetOrdinal(index)
                index += 1

                .Columns("TRDCCL").SetOrdinal(index)
                index += 1

                .Columns("NRTFSV").SetOrdinal(index)
                index += 1
                .Columns("SERVICIO").SetOrdinal(index)
                index += 1
                .Columns("TCMTRF").SetOrdinal(index)
                index += 1
                .Columns("FATNSR").SetOrdinal(index)
                index += 1
                .Columns("QATNAN").SetOrdinal(index)
                index += 1
                .Columns("IVLSRV").SetOrdinal(index)
                index += 1
                .Columns("TMNDA").SetOrdinal(index)
                index += 1
                .Columns("SUB_TOTAL").SetOrdinal(index)
                index += 1
                .Columns("SESTRG_SERV").SetOrdinal(index)
                index += 1
                'If tipoConsistencia <> "Detalle_Reembolso" And obj_Servicio.CDVSN = "R" Then otblAlm = DeleteRowsRepits(otblAlm)
                If tipoConsistencia = "Detalle_Bultos" And obj_Servicio.CDVSN = "R" Then otblAlm = DeleteRowsRepits(otblAlm)

                ' index = 13
                If Not .Columns("QATNRL") Is Nothing Then
                    index = index - 4
                    .Columns("QATNRL").SetOrdinal(index)
                    index += 1
                    .Columns("IVLSRV").SetOrdinal(index)
                    index += 1
                    .Columns("TMNDA").SetOrdinal(index)
                    index += 1
                    .Columns("SUB_TOTAL").SetOrdinal(index)
                    index += 1
                    .Columns("SESTRG_SERV").SetOrdinal(index)
                    index += 1
                    .Columns("QATNRL").ColumnName = "Cantidad real"
                    index += 1
                    ' index = 14
                End If

                .Columns("TCMPCL").ColumnName = "Cliente"
                .Columns("NOPRCN").ColumnName = "Operación"
                .Columns("TIPRO").ColumnName = "Proceso"
                .Columns("TMNDA").ColumnName = "Moneda"
                .Columns("NRTFSV").ColumnName = "Codigo de Tarifa"
                .Columns("SERVICIO").ColumnName = "Tipo Servicio"
                .Columns("TCMTRF").ColumnName = "Servicio"
                .Columns("IVLSRV").ColumnName = "Importe tarifa"
                .Columns("QATNAN").ColumnName = "Cantidad"
                .Columns("SUB_TOTAL").ColumnName = "Monto a Cobrar"
                .Columns("SESTRG_SERV").ColumnName = "Estado Facturación"
                .Columns("FOPRCN").ColumnName = "Fecha Operación"
                .Columns("FATNSR").ColumnName = "Fecha Servicio"

                .Columns("TRDCCL").ColumnName = "Referencia Operación"

                If tipoConsistencia = "Detalle_Reembolso" Then
                    If Not .Columns("QATNRL") Is Nothing Then
                        .Columns.Remove("QATNRL")
                    End If
                    otblAlm = GeneraCargoPlanDetalle(otblAlm)
                    index -= 1
                End If



                If tipoConsistencia = "Detalle_Bultos" Then

                    .Columns("CREFFW").SetOrdinal(index)
                    .Columns("CREFFW").ColumnName = "Bulto"
                    index += 1
                    .Columns("DESCWB").SetOrdinal(index)
                    .Columns("DESCWB").ColumnName = "Descripcion Bulto"
                    index += 1
                    .Columns("FREFFW").SetOrdinal(index)
                    .Columns("FREFFW").ColumnName = "Fecha de Ingreso"
                    index += 1
                    .Columns("FSLFFW").SetOrdinal(index)
                    .Columns("FSLFFW").ColumnName = "Fecha de Salida"
                    index += 1
                    .Columns("NCRRDC").SetOrdinal(index)
                    .Columns("NCRRDC").ColumnName = "Corr"
                    index += 1
                    .Columns("NDIAPL").SetOrdinal(index)
                    .Columns("NDIAPL").ColumnName = "Dias"
                    index += 1
                    .Columns("QREFFW").SetOrdinal(index)
                    .Columns("QREFFW").ColumnName = "Cantidad Bulto"
                    index += 1
                    .Columns("TIPBTO").SetOrdinal(index)
                    .Columns("TIPBTO").ColumnName = "Tipo Bulto"
                    index += 1
                    .Columns("QPSOBL").SetOrdinal(index)
                    .Columns("QPSOBL").ColumnName = "Peso"
                    index += 1
                    .Columns("TUNPSO").SetOrdinal(index)
                    .Columns("TUNPSO").ColumnName = "Unidad Peso"
                    index += 1
                    .Columns("QAROCP").SetOrdinal(index)
                    .Columns("QAROCP").ColumnName = "MT2"
                    index += 1
                    .Columns("QVLBTO").SetOrdinal(index)
                    .Columns("QVLBTO").ColumnName = "Volumen "
                    index += 1
                    .Columns("TUNVOL").SetOrdinal(index)
                    .Columns("TUNVOL").ColumnName = "Unidad Volumen"
                    index += 1
                    .Columns("PERINI").SetOrdinal(index)
                    .Columns("PERINI").ColumnName = "Periodo Inicial"
                    index += 1
                    .Columns("PERFIN").SetOrdinal(index)
                    .Columns("PERFIN").ColumnName = "Periodo Final"
                    index += 1
                    .Columns("QPRDFC").SetOrdinal(index)
                    .Columns("QPRDFC").ColumnName = "Periodos x Aplicar"
                    index += 1
                    .Columns("TUBRFR").SetOrdinal(index)
                    .Columns("TUBRFR").ColumnName = "Almacen"
                    index += 1
                    .Columns("TCTCST").SetOrdinal(index)
                    .Columns("TCTCST").ColumnName = "C.I Terrestre"
                    index += 1
                    .Columns("TCTCSA").SetOrdinal(index)
                    .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                    index += 1
                    .Columns("TCTCSF").SetOrdinal(index)
                    .Columns("TCTCSF").ColumnName = "C.I Aereo"
                    index += 1
                    .Columns("OC").SetOrdinal(index)
                    .Columns("OC").ColumnName = "O/C"
                    index += 1
                    .Columns("NORAGN").SetOrdinal(index)
                    .Columns("NORAGN").ColumnName = "N°Orden Servicio - Agencia"
                    index += 1
                    .Columns("NRITOC").SetOrdinal(index)
                    .Columns("NRITOC").ColumnName = "Item"
                    index += 1
                    .Columns("TDITES").SetOrdinal(index)
                    .Columns("TDITES").ColumnName = "Descripción"
                    index += 1
                    .Columns("TLUGEN").SetOrdinal(index)
                    .Columns("TLUGEN").ColumnName = "Unidad Operativa"
                    index += 1
                    .Columns("QBLTSR").SetOrdinal(index)
                    .Columns("QBLTSR").ColumnName = "Cantidad Item"
                    index += 1
                    .Columns("ALMACEN").SetOrdinal(index)
                    .Columns("ALMACEN").ColumnName = "Tipo de almacen "
                    index += 1
                    .Columns("LOTE").ColumnName = "Lote"
                    .Columns("LOTE").SetOrdinal(index)
                    index += 1
                    .Columns("CI").SetOrdinal(index)
                    .Columns("CI").ColumnName = "Cuenta Imputación"
                    index += 1
                    .Columns("NSRCN1").SetOrdinal(index)
                    .Columns("NSRCN1").ColumnName = "Serie Contenedor"
                    index += 1
                    .Columns("CPRCN1").SetOrdinal(index)
                    .Columns("CPRCN1").ColumnName = "Contenedor"
                    index += 1
                    .Columns("TSRVC").SetOrdinal(index)
                    .Columns("TSRVC").ColumnName = "Observación"
                    index += 1
                    .Columns("TRFSRC").SetOrdinal(index)
                    .Columns("TRFSRC").ColumnName = "Referencia Servicio"
                    index += 1

                End If
            End With
            otblAlm.TableName = tipoConsistencia
            With otblAlm
                'If .Columns("FOPRCN") IsNot Nothing Then .Columns.Remove("FOPRCN")
                'If .Columns("FATNSR") IsNot Nothing Then .Columns.Remove("FATNSR")
                If .Columns("NCRROP") IsNot Nothing Then .Columns.Remove("NCRROP")
                If .Columns("IMPORTE") IsNot Nothing Then .Columns.Remove("IMPORTE")
                If .Columns("NGUITR") IsNot Nothing Then .Columns.Remove("NGUITR")
                If .Columns("CTRMNC") IsNot Nothing Then .Columns.Remove("CTRMNC")
                If .Columns("COD") IsNot Nothing Then .Columns.Remove("COD")

                If Not .Columns("NRITOC") Is Nothing Then .Columns.Remove("NRITOC")
                If Not .Columns("TDITES") Is Nothing Then .Columns.Remove("TDITES")
                If Not .Columns("TLUGEN") Is Nothing Then .Columns.Remove("TLUGEN")
                If Not .Columns("QBLTSR") Is Nothing Then .Columns.Remove("QBLTSR")
                If Not .Columns("NSEQIN") Is Nothing Then .Columns.Remove("NSEQIN")

                If Not .Columns("TCTCST") Is Nothing Then .Columns("TCTCST").ColumnName = "C.I Terrestre"
                If Not .Columns("TCTCSA") Is Nothing Then .Columns("TCTCSA").ColumnName = "C.I Fluvial"
                If Not .Columns("TCTCSF") Is Nothing Then .Columns("TCTCSF").ColumnName = "C.I Aereo"
                If .Columns("VALCTE") IsNot Nothing Then .Columns.Remove("VALCTE")
                If .Columns("ITPCMT") IsNot Nothing Then .Columns.Remove("ITPCMT")


            End With


            If cmbCriterioReporte.SelectedIndex = 0 Then otblAlm.Columns.Remove("Cliente")

            odsExcel.Tables.Add(otblAlm.Copy)
            odsExcel.Tables.Add(objDs.Tables(1).Copy)
            odsExcel.Tables.Add(objDs.Tables(2).Copy)
            odsExcel.Tables.Add(oDtResLotePrint.Copy)
            odsExcel.Tables.Add(oDtCiPrint.Copy) 'CI
            oDtResLotePrint.Rows.Clear()
            ListDs.Add(odsExcel)
        Next

        Ransa.Utilitario.HelpClass_NPOI.ExportExcel_RZC20_General_List(ListDs)
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ObtenerInformacionReporte(TipoReporte.Excel)
    End Sub

    Private Sub btnPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPantalla.Click
        ObtenerInformacionReporte(TipoReporte.Rpt)
    End Sub

    Private Sub cmbCriterioReporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCriterioReporte.SelectedIndexChanged

        Select Case cmbCriterioReporte.SelectedIndex
            Case 0
                txtBusqueda.Enabled = False
                UcCliente.Enabled = True
                txtBusqueda.Text = ""
                rbItem.Visible = False
                rbOc.Visible = False
            Case 1
                txtBusqueda.Enabled = True
                lblBusqueda.Text = "Nro. Operación : "
                UcCliente.Enabled = False
                UcCliente.pClear()
                rbItem.Visible = False
                rbOc.Visible = False
            Case 2
                txtBusqueda.Enabled = True
                lblBusqueda.Text = "Nro. Revisión : "
                UcCliente.Enabled = False
                UcCliente.pClear()
                txtBusqueda.Text = ""

                If chkDetallado.Checked Then
                    rbItem.Visible = True
                    rbOc.Visible = True
                Else
                    rbItem.Visible = False
                    rbOc.Visible = False
                End If
        End Select

    End Sub

    Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If Comun.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Function filtraDatatable(ByVal tbl As DataTable, ByVal where As String) As DataTable
        Dim dt As New DataTable
        dt = tbl.Copy
        dt.DefaultView.RowFilter = where
        Return dt.DefaultView.ToTable
    End Function


    Private Sub chkDetallado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetallado.CheckedChanged

        If chkDetallado.Checked And cmbCriterioReporte.SelectedValue = "3" Then
            rbItem.Visible = True
            rbOc.Visible = True
        Else
            rbItem.Visible = False
            rbOc.Visible = False
        End If

    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If chkFecha.Checked Then
            Me.dtFeInicial.Enabled = True
            Me.dtFeFinal.Enabled = True
            dtFeFinal.Value = Now
            dtFeInicial.Value = Now.AddDays(1 - CInt(Today.Day.ToString))
        Else
            Me.dtFeInicial.Enabled = False
            Me.dtFeFinal.Enabled = False
        End If
    End Sub

    Private Sub cmbEstadoPendiente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoPendiente.SelectedValueChanged
        If bolBuscar Then
            Select Case cmbEstadoPendiente.SelectedValue
                'Todos
                Case "0"
                    cmbEstadoFactura.Visible = False
                    lblFacturacion.Visible = False

                    'Revisado
                Case "S"
                    cmbEstadoFactura.Visible = True
                    lblFacturacion.Visible = True

                    'Por revisar
                Case "N"
                    cmbEstadoFactura.Visible = False
                    lblFacturacion.Visible = False

            End Select


        End If
    End Sub
End Class

Enum TipoReporte
    Excel
    Rpt
End Enum
