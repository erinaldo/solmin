Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmConsistenciaOperacion
  Private bolBuscar As Boolean = False
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private _lstrTipoCuenta As String
    Private objLista As New List(Of String)
    Private strPlanta As String


  Private Sub CargarEstado()
    Dim oDt As New DataTable
    Dim oDr As DataRow
    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")

    oDr = oDt.NewRow
    oDr.Item(0) = "T"
    oDr.Item(1) = "TODOS"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "P"
    oDr.Item(1) = "PENDIENTE"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "F"
    oDr.Item(1) = "FACTURADO"
    oDt.Rows.Add(oDr)

    'oDr = oDt.NewRow
    'oDr.Item(0) = "A"
    'oDr.Item(1) = "ANULADO"
    'oDt.Rows.Add(oDr)

    Me.cmbEstado.DataSource = oDt
    Me.cmbEstado.ValueMember = "COD"
    Me.cmbEstado.DisplayMember = "DES"

  End Sub

  Private Sub frmResMMOperFacturac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    bolBuscar = False
    Me.Cargar_Compania()
    Me.InicializarFormulario()
    Me.CargarEstado()
    'SE AGREGO
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        cmbEstado.SelectedIndex = 0
        'cmbCompania
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    Me.txtTransportista.pCargar(obeTracto)
    gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    gwdDatos.AutoGenerateColumns = False
    pbxProceso.Visible = False
        lblProceso.Visible = False

        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        06/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        'Cargar_Planta()

  End Sub

    'Private Sub Cargar_Compania()
    '  Try
    '    bolBuscar = False
    '    objCompaniaBLL.Crea_Lista()
    '    cmbCompania.DataSource = objCompaniaBLL.Lista
    '    cmbCompania.ValueMember = "CCMPN"
    '    cmbCompania.DisplayMember = "TCMPCM"
    '    cmbCompania.SelectedIndex = 0
    '    bolBuscar = True
    '    cmbCompania_SelectedIndexChanged(Nothing, Nothing)
    '  Catch ex As Exception
    '  End Try
    'End Sub

    'Private Sub Cargar_Division()
    '  Dim objDivision As New NEGOCIO.Division_BLL
    '  Try
    '    If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
    '      bolBuscar = False
    '      objDivision.Crea_Lista()
    '      cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
    '      cmbDivision.ValueMember = "CDVSN"
    '      cmbDivision.DisplayMember = "TCMPDV"
    '      'cmbDivision.SelectedIndex = 0
    '      bolBuscar = True
    '      Me.cmbDivision.SelectedValue = "T"
    '      If Me.cmbDivision.SelectedIndex = -1 Then
    '        Me.cmbDivision.SelectedIndex = 0
    '      End If
    '    End If
    '  Catch ex As Exception
    '    HelpClass.MsgBox(ex.Message)
    '  End Try
    'End Sub

    'Private Sub Cargar_Planta()
    '  Me.cmbPlanta.Usuario = MainModule.USUARIO
    '  Me.cmbPlanta.CodigoCompania = Me.cmbCompania.SelectedValue
    '  Me.cmbPlanta.CodigoDivision = Me.cmbDivision.SelectedValue
    '  Me.cmbPlanta.PlantaDefault = 1
    '  Me.cmbPlanta.pActualizar()
    'Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    'Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    'Try
    '  If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
    '    bolBuscar = False
    '    objPlanta.Crea_Lista()
    '    objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
    '    Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
    '    For Each objEntidad In objLisEntidad2
    '      objLisEntidad.Add(objEntidad)
    '    Next
    '    CheckedComboBox1.DisplayMember = "TPLNTA"
    '    CheckedComboBox1.ValueMember = "CPLNDV"
    '    Me.CheckedComboBox1.DataSource = objLisEntidad

    '    For i As Integer = 0 To CheckedComboBox1.Items.Count - 1
    '      If CheckedComboBox1.Items.Item(i).Value = "1" Then
    '        CheckedComboBox1.SetItemChecked(i, True)
    '      End If
    '    Next
    '    If objLisEntidad.Count > 0 Then
    '      _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
    '    Else
    '      _lstrTipoCuenta = ""
    '    End If

    '    bolBuscar = True
    '    'CheckedComboBox1.SelectedIndex = 0
    '    CheckedComboBox1_SelectedIndexChanged(Nothing, Nothing)
    '  End If
    'Catch ex As Exception
    'End Try
    'End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click

        Me.gwdDatos.DataSource = Nothing  'agregado
        If VerificarSiNoEligePlanta() = True Then  'agregado

            Try
                gwdDatos.DataSource = Nothing



                strPlanta = ""
                For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

                    strPlanta += chkcbxPlanta.CheckedItems(i).Value

                    If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                        strPlanta = String.Concat(strPlanta, ",")
                    End If

                Next
                PrepararProceesWorked()
                bgwProceso.RunWorkerAsync()
            Catch ex As Exception
                HelpClass.ErrorMsgBox()
                Me.Cursor = Cursors.Default
                ClearMemory()
            End Try
            MenuBar.Enabled = True
            Me.Cursor = Cursors.Default

        End If  'agregado



       
    End Sub

    'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar = True Then
    '        Cargar_Division()
    '    End If
    'End Sub

    'Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        Cargar_Planta()
    '    End If
    'End Sub

    'Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) HANDLES cmbPlanta.
    '  If bolBuscar = True Then
    '    InicializarFormulario()
    '  End If
    'End Sub

    Private Sub CargarTransportista()
        txtTransportista.pClear()
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'cmbCompania.CCMPN_CodigoCompania
        'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        Me.txtTransportista.pCargar(obeTracto)
    End Sub

    Private Sub InicializarFormulario()
        gwdDatos.DataSource = Nothing
        ctlCliente.pClear()
        txtTransportista.pClear()
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
        CargarTransportista()
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        TabControl1.SelectedIndex = 0
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
    '    If (Me.gwdDatos.Rows.Count = 0) Then
    '        MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If
    '    Dim objListDtg As New List(Of DataGridView)
    '    objListDtg.Add(Me.gwdDatos)
    'HelpClass.ExportarExcel_HTML(objListDtg)

    Try
      If gwdDatos.Rows.Count <= 0 Then
        MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      Dim ODs As New DataSet
      Dim objDt As New DataTable
      Dim loEncabezados As New Generic.List(Of Encabezados)

      'Envia los Parametros para la exportacion
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Consistencia de Operaciones"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Consistencia de Operaciones"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE CONSISTENCIA DE OPERACIONES"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
      objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

      ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

      For Each dc As DataColumn In ODs.Tables(0).Columns
        Select Case dc.Caption
          Case "TCMTRT", "TRFSRC", "CLCLOR", "CLCLDS", "NPLCTR", "TDEACP", "TCNFVH", "PLANTA_DESCRIPCION", "NGUITR", "NGUIRM", "NOPRCN", "NORCML", "FSLDCM", "FLLGCM"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

          Case "CAPACI"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

          Case "IMPCOB", "ASEGUR", "SEGURI", "VLRFDT"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

        End Select
      Next
      HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    Catch ex As Exception
      MessageBox.Show(ex, "Error:")
    End Try

    End Sub

    Private Sub PrepararProceesWorked()
        objLista.Clear()
        MenuBar.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        TabControl1.SelectedIndex = 0
        pbxProceso.Visible = True
        lblProceso.Visible = True
        lblProceso.Text = "Procesando..."
        'objLista.Add(Me.cmbCompania.SelectedValue)
        'objLista.Add(Me.cmbDivision.SelectedValue)

        objLista.Add(cmbCompania.CCMPN_CodigoCompania)
        objLista.Add(cmbDivision.Division)


        Dim strCodPlanta As String = ""
        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1
            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value & ","
        Next
        If strCodPlanta = "" Then
            For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                strCodPlanta += chkcbxPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        objLista.Add(strCodPlanta)

        objLista.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
        objLista.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))

        If ctlCliente.pCodigo = 0 Then
            objLista.Add(0)
        Else
            objLista.Add(Me.ctlCliente.pCodigo)
        End If
        If txtTransportista.pCodigoRNS = 0 Then
            objLista.Add(0)
        Else
            objLista.Add(txtTransportista.pCodigoRNS)
        End If
        objLista.Add(cmbEstado.SelectedValue)
        If Me.rbnFechaOperacion.Checked = True Then
            objLista.Add(0)
        Else
            objLista.Add(1)
        End If
    End Sub

    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim objLogica As New ReportesVariados_BLL
        Dim strTransportista As String = ""
        Dim intNGUIRM As Int64 = 0
        Dim intNGUITR As Int64 = 0
        Dim objTabla As DataTable = objLogica.Reporte_Consistencia_Operaciones(objLista)
        For Each objRow As DataRow In objTabla.Rows
            If strTransportista = objRow("TCMTRT") And intNGUITR = objRow("NGUITR") Then
                'objlist.Add(objRow)
                If intNGUIRM = objRow("NGUIRM") Then
                    objRow("NGUIRM") = DBNull.Value
                Else
                    intNGUIRM = objRow("NGUIRM")
                End If
                '    objRow("TPLNTA") = ""
                objRow("PLANTA_DESCRIPCION") = ""
                objRow("TCMTRT") = ""
                objRow("NGUITR") = DBNull.Value
                objRow("TRFSRC") = ""
                objRow("CLCLOR") = ""
                objRow("CLCLDS") = ""
                objRow("NPLCTR") = ""
                objRow("FSLDCM") = ""
                objRow("FLLGCM") = ""
                objRow("NOPRCN") = DBNull.Value
                objRow("TDEACP") = ""
                objRow("IMPCOB") = DBNull.Value
                objRow("ASEGUR") = DBNull.Value
                objRow("SEGURI") = DBNull.Value
                objRow("TCNFVH") = ""
                objRow("CAPACI") = DBNull.Value
                objRow("VLRFDT") = DBNull.Value
            Else
                strTransportista = objRow("TCMTRT")
                intNGUITR = objRow("NGUITR")
                intNGUIRM = objRow("NGUIRM")
            End If
            'intContador += 1
        Next

        e.Result = objTabla
    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Dim dstreporte As New DataTable
        Dim row As Integer
        dstreporte = CType(e.Result, DataTable)
        If dstreporte.Rows.Count > 0 Then
            dstreporte.TableName = "ReporteConsistenciaOperacion"
        End If
        Try
            'Generar_Reporte_Resumen(dstreporte)
            'Generar_Reporte_Detalle(dstreporte)
            For row = 0 To dstreporte.Rows.Count - 1
                dstreporte.Rows(row).Item("FSLDCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Rows(row).Item("FSLDCM").ToString)
                dstreporte.Rows(row).Item("FLLGCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Rows(row).Item("FLLGCM").ToString)
            Next
            gwdDatos.DataSource = dstreporte
            Me.Cursor = Cursors.Default
            'Visualizar mensaje
            pbxProceso.Visible = False
            lblProceso.Visible = True
            lblProceso.Text = "Finalizado..."
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            lblProceso.Text = "Finalizado..."
            ClearMemory()
        Finally
            MenuBar.Enabled = True
        End Try
    End Sub
    'se creo esta funcion 23/03/2012
    Private Function VerificarSiNoEligePlanta() As Boolean
        Dim vretorno As Boolean = False

        Dim strCodPlanta As String = ""



        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strCodPlanta = String.Concat(strCodPlanta, ",")
            End If

        Next

        If strCodPlanta = "" Then
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default

            vretorno = False
        Else
            vretorno = True

        End If
        Return vretorno

    End Function

#Region "Planta"
    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.Limpiar()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlanta.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                ' Me.cmbPlanta.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Limpiar()
        InicializarFormulario()
    End Sub


    Private Sub Cargar_Planta()

        chkcbxPlanta.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try

            If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then

                objPlanta.Crea_Lista()
                '
                objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                chkcbxPlanta.DisplayMember = "TPLNTA"
                chkcbxPlanta.ValueMember = "CPLNDV"
                Me.chkcbxPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                    If chkcbxPlanta.Items.Item(i).Value = "1" Then
                        chkcbxPlanta.SetItemChecked(i, True)
                    End If
                Next
                If chkcbxPlanta.Text = "" Then
                    chkcbxPlanta.SetItemChecked(0, True)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region


   
    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick

    End Sub
End Class