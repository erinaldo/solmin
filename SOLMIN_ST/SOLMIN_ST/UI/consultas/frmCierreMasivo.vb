Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports System
Imports System.Globalization

Public Class frmCierreMasivo

    Private CheckBool As Boolean = False
    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try
            Me.gwdDatos.DataSource = Nothing
            Me.Listar()
        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
     
    Private Sub Listar()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objParameter As New Hashtable
        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim lstr_FecIni_GT As Int32 = 0
        Dim lstr_FecFin_GT As Int32 = 0
        Dim estado_entrega As String = ""
        Dim PlantasSel As String = ""

        lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
        lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)

        lstr_FecIni_GT = HelpClass.CtypeDate(Me.dtpInicioViaje.Value)
        lstr_FecFin_GT = HelpClass.CtypeDate(Me.dtpFinInicioViaje.Value)

        objParameter.Add("CCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
        objParameter.Add("CDVSN", Me.cmbDivision.Division)
        objParameter.Add("CCLNT", txtClienteFiltro.pCodigo)
        PlantasSel = Me.GetPlanta()
        objParameter.Add("CPLNDV", PlantasSel)
        objParameter.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)
        objParameter.Add("FECINI", lstr_FecIni)
        objParameter.Add("FECFIN", lstr_FecFin)
        If chkGuia.Checked = True Then
            objParameter.Add("PNFECINI_GT", lstr_FecIni_GT)
            objParameter.Add("PNFECFIN_GT", lstr_FecFin_GT)
        Else
            objParameter.Add("PNFECINI_GT", 0)
            objParameter.Add("PNFECFIN_GT", 0)
        End If
     
      
        Dim dt As New DataTable
        gwdDatos.DataSource = Nothing
        dt = objSolicitudTransporte.Listar_GuiasPendientesCierre(objParameter)
        Me.gwdDatos.DataSource = dt


        Dim CantDias As Decimal = 0
        Dim ConfigcionAutomat As String = ""
        Dim FechaInicio As Date
        Dim isFecha As Boolean = False
        Dim Validacion As Boolean = False
        Dim HoraFin As Integer = 0
        'Dim FechaFin As Integer = 0
        Dim fechafinformat As String = ""

        For Each item As DataGridViewRow In gwdDatos.Rows
            CantDias = Val("" & item.Cells("DIAS_CIERRE").Value)
            ConfigcionAutomat = ("" & item.Cells("ETA_AUTOMATICO").Value).ToString.Trim

            If ConfigcionAutomat = "SI" Then

                isFecha = Date.TryParse(item.Cells("F_INI_TRASL_P").Value.ToString, FechaInicio)
                Validacion = (CantDias > 0 And isFecha = True)
                fechafinformat = FechaInicio.AddDays(CantDias - 1).ToString("dd/MM/yyyy")

                item.Cells("F_LLEGD_TRASL_P").Value = fechafinformat

            End If

        Next


        CheckBool = False

    End Sub


    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

   
    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Dim oDr As DataRow
        oDr = objTabla.NewRow
        oDr.Item("CMEDTR") = 0
        oDr.Item("TNMMDT") = "TODOS"
        objTabla.Rows.Add(oDr)
        objTabla.Select("", "")

        Dim dv As DataView
        dv = New DataView(objTabla, "", "CMEDTR ASC", DataViewRowState.CurrentRows)

        Me.cboMedioTransporteFiltro.DataSource = dv
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"

    End Sub



 
    Private Sub frmConsultaPasajero_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gwdDatos.AutoGenerateColumns = False

            Me.Cargar_Compania()
            Me.Carga_MedioTransporte()
            chkGuia_CheckedChanged(chkGuia, Nothing)
        Catch ex As Exception
            MessageBox.Show("Aviso", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
      
    End Sub

 

    Private Function GetPlanta() As String
        Dim CodPlanta As String = ""
        Dim strCodPlanta As String = ""
        Dim PlantaTodos As Boolean = False
        For i As Integer = 0 To cmbChkPlanta.CheckedItems.Count - 1
            CodPlanta = cmbChkPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","
        Next
        If PlantaTodos = True Then
            strCodPlanta = ""
            For i As Integer = 1 To cmbChkPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cmbChkPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If

        Return strCodPlanta
    End Function


    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

        Try
            Dim ODs As New DataSet
            Dim objDt As DataTable
            'objDt = TransformarGrilla(Me.gwdDatos, HelpClass.GetDataSetNative(Me.gwdDatos.DataSource))
            objDt = TransformarGrilla(Me.gwdDatos)
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "COMPAÑIA : " & " " & Me.cmbCompania.CCMPN_Descripcion))
            loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "CLIENTE : " & IIf(txtClienteFiltro.pCodigo = 0, "TODOS", txtClienteFiltro.pCodigo & " - " & txtClienteFiltro.pRazonSocial)))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "CONSULTA DE TRASLADOS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "0.00"))
            ODs.Tables.Add(objDt.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub


    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        'Try
        Me.cmbChkPlanta.Text = ""
        If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing AndAlso Me.cmbDivision.Division IsNot Nothing) Then

            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next

            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = "0"
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)

            cmbChkPlanta.DisplayMember = "TPLNTA"
            cmbChkPlanta.ValueMember = "CPLNDV"
            Me.cmbChkPlanta.DataSource = objLisEntidad
            
        End If

    End Sub


 

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim reg As Integer = 0
            Dim objLogicaHito As New ControlHitos_BLL
            Dim objHito As New HitoOperacion
            Dim oListGuiasRemision As New List(Of HitoOperacion)
            Dim msg As String = ""
            gwdDatos.EndEdit()
            'Dim FechaInicio As Date
            Dim FechaFinD As Date
            Dim FechaFin As Integer = 0
            Dim CantDias As Double = 0
            Dim isFecha As Boolean = False
            Dim Validacion As Boolean = False
            Dim HoraFin As Integer = 0
            Dim ConfigcionAutomat As String = ""
            Dim fechaformat As String = ""
            Dim msgval As String = ""
            For Each item As DataGridViewRow In gwdDatos.Rows
                'CantDias = Val("" & item.Cells("DIAS_CIERRE").Value)
                'ConfigcionAutomat = ("" & item.Cells("ETA_AUTOMATICO").Value).ToString.Trim

                'If item.Cells("CHK").Value = True And CantDias > 0 And ConfigcionAutomat = "SI" Then

                '    isFecha = Date.TryParse(item.Cells("F_INI_TRASL_P").Value.ToString, FechaInicio)
                '    Validacion = (CantDias > 0 And isFecha = True)

                '    FechaFin = FechaInicio.AddDays(CantDias - 1).ToString("yyyyMMdd")
                '    If ("" & item.Cells("H_INI_TRASL_P").Value).ToString.Trim = "" Then
                '        HoraFin = 0
                '    Else
                '        HoraFin = Ransa.Utilitario.HelpClass.ConvertHoraNumeric(item.Cells("H_INI_TRASL_P").Value)
                '    End If



                '    If Validacion = True Then

                '        objHito = New HitoOperacion
                '        objHito.NOPRCN = item.Cells("NOPRCN_P").Value
                '        objHito.CTRMNC = item.Cells("CTRMNC_P").Value
                '        objHito.NGUITR = item.Cells("NGUITR_P").Value
                '        objHito.FRETES = FechaFin
                '        objHito.HRAREA = HoraFin
                '        objHito.CUSCRT = ""
                '        objHito.NTRMCR = ""
                '        msg = objLogicaHito.ActualizarMasivoHito(objHito)
                '        If msg.Length > 0 Then
                '            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '            Exit Sub
                '        End If
                '        reg = reg + 1

                '    End If


                'End If

                fechaformat = ("" & item.Cells("F_LLEGD_TRASL_P").Value.ToString).Trim

                If item.Cells("CHK").Value = True And fechaformat <> "" Then

                    isFecha = Date.TryParse(item.Cells("F_LLEGD_TRASL_P").Value.ToString, FechaFinD)
                    'Validacion = (CantDias > 0 And isFecha = True)
                    Validacion = isFecha

                    msgval = ""
                    If Validacion = True Then

                        FechaFin = FechaFinD.ToString("yyyyMMdd")

                        'If ("" & item.Cells("H_INI_TRASL_P").Value).ToString.Trim = "" Then
                        '    HoraFin = 0
                        'Else
                        '    HoraFin = Ransa.Utilitario.HelpClass.ConvertHoraNumeric(item.Cells("H_INI_TRASL_P").Value)
                        'End If
                        HoraFin = 0

                    Else
                        msgval = "Verifique formato ingreso en fecha : dd/mm/YYYY"

                    End If

                    If msgval <> "" Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                 


                    If Validacion = True Then

                        objHito = New HitoOperacion
                        objHito.NOPRCN = item.Cells("NOPRCN_P").Value
                        objHito.CTRMNC = item.Cells("CTRMNC_P").Value
                        objHito.NGUITR = item.Cells("NGUITR_P").Value
                        objHito.FRETES = FechaFin
                        objHito.HRAREA = HoraFin
                        objHito.CUSCRT = ""
                        objHito.NTRMCR = "TIMASIVO"
                        msg = objLogicaHito.ActualizarMasivoHito(objHito)
                        If msg.Length > 0 Then
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                        reg = reg + 1

                    End If


                End If


            Next
            If reg = 0 Then
                MessageBox.Show("Registros válidos no seleccionados.(cantidad>0,config. ETA).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Viajes cerrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listar()
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkGuia_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuia.CheckedChanged

        'chkGuia
        dtpFinInicioViaje.Enabled = chkGuia.Checked
        dtpInicioViaje.Enabled = chkGuia.Checked

    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Function TransformarGrilla(ByVal gv As DataGridView) As DataTable
        Dim dtData As New DataTable
        For Each Item As DataGridViewColumn In gv.Columns
            If Item.Visible = True Then
                dtData.Columns.Add(Item.Name)
            End If
        Next

        Dim dr As DataRow
        Dim NameColumna As String = ""
        For Each Item As DataGridViewRow In gv.Rows
            dr = dtData.NewRow
            For Each dcColumna As DataColumn In dtData.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = Item.Cells(NameColumna).Value
            Next
            dtData.Rows.Add(dr)
        Next

        For Each Item As DataColumn In dtData.Columns
            Item.ColumnName = gv.Columns(Item.ColumnName).HeaderText
        Next

        Return dtData

    End Function

    'Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick, gwdDatos.CellContentDoubleClick
    '    Try
    '        Dim colName As String = gwdDatos.Columns(e.ColumnIndex).Name
    '        Dim diasEstimado As Integer = 0
    '        If Me.gwdDatos.RowCount = 0 Then Exit Sub
    '        Select Case colName
    '            Case "CHK"
    '                diasEstimado = Val("" & gwdDatos.CurrentRow.Cells("DIAS_CIERRE").Value)
    '                If diasEstimado = 0 Then
    '                    Me.gwdDatos.Item("CHK", e.RowIndex).Value = False
    '                    Me.gwdDatos.EndEdit()
    '                    Exit Sub
    '                End If

    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        gwdDatos.EndEdit()
        CheckBool = Not CheckBool
        Dim CantDias As Integer = 0
        Dim ConfigcionAutomat As String = ""
        Try
            For Each item As DataGridViewRow In gwdDatos.Rows
                CantDias = Val("" & item.Cells("DIAS_CIERRE").Value)
                ConfigcionAutomat = ("" & item.Cells("ETA_AUTOMATICO").Value).ToString.Trim
                If CantDias > 0 And ConfigcionAutomat = "SI" Then
                    item.Cells("CHK").Value = CheckBool
                End If
            Next
            gwdDatos.EndEdit()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub gwdDatos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gwdDatos.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            'If TypeOf e.Control Is TextBox Then
            '    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            'End If
            colName = gwdDatos.Columns(gwdDatos.CurrentCell.ColumnIndex).Name
            Select Case colName
                Case "F_LLEGD_TRASL_P"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 10

                Case "DIAS_CIERRE"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.MaxLength = 4

                    'Case "DOCCOSTO_MONORG"
                    '    Texto = CType(e.Control, TextBox)
                    '    Texto.Text = Texto.Text.Trim
                    '    Texto.Tag = "10-5"
                    '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                    'Case "DOCCOSTO_MONDOL"
                    '    Texto = CType(e.Control, TextBox)
                    '    Texto.Text = Texto.Text.Trim
                    '    Texto.Tag = "10-5"
                    '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellEndEdit
        Try

            If gwdDatos.Columns(e.ColumnIndex).Name = "F_LLEGD_TRASL_P" Then

                Dim FechaFinD As Date
                Dim isFecha As Boolean = True
              
                isFecha = Date.TryParse(("" & gwdDatos.CurrentRow.Cells("F_LLEGD_TRASL_P").Value).ToString.Trim, FechaFinD)
                If isFecha = False Then
                    gwdDatos.CurrentRow.Cells("F_LLEGD_TRASL_P").Value = ""
                Else
                    gwdDatos.CurrentRow.Cells("F_LLEGD_TRASL_P").Value = FechaFinD.ToString("dd/MM/yyyy")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




End Class
