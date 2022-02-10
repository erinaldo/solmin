Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmAsignacionLiquidacionCombustible

#Region "Variables"
    Private mLista As New List(Of Combustible)
    Private _SumaPeso As New Double
    Private _SumaPesoLiq As New Double
    Private _GalonesTanque As New Double
    Private _GalonesAsignados As New Double
    Private _GalonesUtilizados As New Double
    Private mQGLNSA As Double
    Private _obj_Entidad_Combustible As New Combustible
    Private objLista As New List(Of Combustible)
#End Region

#Region "Properties"
    Public WriteOnly Property Lista() As List(Of Combustible)
        Set(ByVal value As List(Of Combustible))
            mLista = value
        End Set
    End Property

    Public WriteOnly Property QGLNSA() As Double
        Set(ByVal value As Double)
            mQGLNSA = value
        End Set
    End Property
#End Region

#Region "Propiedades"
    Public Property obj_Entidad_Combustible()
        Get
            Return _obj_Entidad_Combustible
        End Get
        Set(ByVal value)
            _obj_Entidad_Combustible = value
        End Set
    End Property
#End Region

#Region "Eventos"

    Private Sub frmAsignacionLiquidacionCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Alinear_Columnas_Grilla()
            ListaValeAsignadosxTracto()
            Lista_Combustible()
            Calcular_Combustible()
            _GalonesAsignados = 0
            _GalonesTanque = 0
            _GalonesUtilizados = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ListaValeAsignadosxTracto()
        dtgVales.Rows.Clear()
        Dim oListValeCombustible As New List(Of ValeCombustible)
        Dim obllValeCombustible As New ValeCombustible_BLL
        Dim objEntidad As New ValeCombustible
        objEntidad.CCMPN = _obj_Entidad_Combustible.CCMPN
        objEntidad.CDVSN = _obj_Entidad_Combustible.CDVSN
        objEntidad.CPLNDV = _obj_Entidad_Combustible.CPLNDV
        objEntidad.NRUCTR = _obj_Entidad_Combustible.NRUCTR
        objEntidad.NPLVEH = _obj_Entidad_Combustible.NPLCUN
        objEntidad.SSVLCM = "A" ' asignados
        oListValeCombustible = obllValeCombustible.Listar_Vale_Combustible_x_Tracto(objEntidad)
        Dim dgvrVale As DataGridViewRow
        Dim Fila As Int32 = 0
        For Each Item As ValeCombustible In oListValeCombustible
            dgvrVale = New DataGridViewRow
            dgvrVale.CreateCells(Me.dtgVales)
            Me.dtgVales.Rows.Add(dgvrVale)
            Fila = dtgVales.Rows.Count - 1
            dtgVales.Rows(Fila).Cells("NSLCMB").Value = Item.NSLCMB
            dtgVales.Rows(Fila).Cells("NVLGRF").Value = Item.NVLGRF
            dtgVales.Rows(Fila).Cells("FSLCMB").Value = Item.FSLCMB
            dtgVales.Rows(Fila).Cells("FCRCMB").Value = Item.FCRCMB
            dtgVales.Rows(Fila).Cells("CTPCMB").Value = Item.CTPCMB
            dtgVales.Rows(Fila).Cells("QGLNCM_V").Value = Item.QGLNCM
            dtgVales.Rows(Fila).Cells("CSTGLN_V").Value = Item.CSTGLN
            dtgVales.Rows(Fila).Cells("CGRFO").Value = Item.CGRFO
            dtgVales.Rows(Fila).Cells("NPRCN1").Value = Item.NPRCN1
            dtgVales.Rows(Fila).Cells("NPRCN2").Value = Item.NPRCN2
            dtgVales.Rows(Fila).Cells("NPRCN3").Value = Item.NPRCN3
            dtgVales.Rows(Fila).Cells("NDCCT1").Value = Item.NDCCT1
            dtgVales.Rows(Fila).Cells("CTPOD1").Value = Item.CTPOD1
            dtgVales.Rows(Fila).Cells("FDCCT1").Value = Item.FDCCT1
            dtgVales.Rows(Fila).Cells("ASIGNADO").Value = 1
        Next
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub btnAsignarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOperacion.Click
    '    Dim frm_OpcionAgregarOperacion As New frmOpcionAgregarOperacion
    '    Dim frm_BuscarGuia As New frmAgregarOperacion
    '    Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
    '    Dim frm_LiquidarOperacion As New frmLiquidarOperacion
    '    Dim obj_Entidad_Liquidacion As New LiquidacionGastos
    '    Dim obj_Logica_Liquidacion As New LiquidacionGastos_BLL
    '    Try
    '        With frm_OpcionAgregarOperacion
    '            .NPLCTR = Me.txtTracto.Text.Trim
    '            .CCMPN = Me.txtCompania.Tag
    '            .CDVSN = Me.txtDivision.Tag
    '            .CPLNDV = Me.txtPlanta.Tag
    '            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '            Dim objParameter As Hashtable
    '            Select Case .OPCION
    '                Case 1
    '                    With frm_BuscarGuia
    '                        .txtTracto.Text = Me.txtTracto.Text.Trim
    '                        .txtTracto.Tag = Me.txtTracto.Tag
    '                        .CCMPN = Me.txtCompania.Tag
    '                        .CDVSN = Me.txtDivision.Tag
    '                        .CPLNDV = Me.txtPlanta.Tag
    '                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '                        For lint_Indice As Integer = 0 To .Lista.Count - 1
    '                            objParameter = New Hashtable
    '                            objParameter.Add("NOPRCN", .Lista.Item(lint_Indice).NOPRCN)
    '                            objParameter.Add("TCMPCL", .Lista.Item(lint_Indice).TCMPCL)
    '                            objParameter.Add("RUTA", .Lista.Item(lint_Indice).RUTA)
    '                            objParameter.Add("NKMRTC", .Lista.Item(lint_Indice).QKMREC)
    '                            Me.Agregar_Operacion_Liquidar(objParameter, frm_OpcionAgregarOperacion.OPCION)
    '                        Next
    '                    End With
    '                Case 2
    '                    With frm_ListaTractosPlaneamiento
    '                        .NPLNMT_1 = frm_OpcionAgregarOperacion.NPLNMT
    '                        .CCMPN_1 = "EZ"
    '                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '                        objParameter = New Hashtable
    '                        objParameter.Add("NRUCTR", .NRUCTR_1)
    '                        objParameter.Add("NPLCTR", .NPLCTR_1)
    '                        objParameter.Add("NOPRCN", frm_OpcionAgregarOperacion.NOPRCN)
    '                        objParameter.Add("TCMPCL", frm_OpcionAgregarOperacion.TCMPCL)
    '                        objParameter.Add("RUTA", .RUTA_1)
    '                        Me.Agregar_Operacion_Liquidar(objParameter, frm_OpcionAgregarOperacion.OPCION)

    '                    End With
    '            End Select
    '        End With
    '        Me.Actualizar_Galones_Utilizados_x_Operacion()
    '        Me.Actualizar_Total_Galones_x_Operacion()

    '    Catch : End Try
    'End Sub

    'Private Sub dtgVales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVales.CellContentClick, dtgVales.CellContentDoubleClick
    '    If e.RowIndex < 0 Then Exit Sub
    '    Select Case e.ColumnIndex
    '        Case 0
    '            Me.Actualizar_Galones_Asignados()
    '    End Select
    '    Me.Actualizar_Galones_Utilizados()
    '    Me.Actualizar_Galones_Utilizados_x_Operacion()
    '    Me.Actualizar_Total_Galones_x_Operacion()
    'End Sub

    'Private Sub txtGalonesTanque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then
    '        e.Handled = True
    '    Else
    '        If 1 <= InStr(sender.Text, ".", CompareMethod.Binary) Then
    '            If e.KeyChar = "." Then
    '                e.Handled = True
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub txtGalonesTanque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Actualizar_Galones_Utilizados()
    '    Me.Actualizar_Galones_Utilizados_x_Operacion()
    '    Me.Actualizar_Total_Galones_x_Operacion()
    'End Sub

    'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    '    If Me.dtgLiquidacion.RowCount = 0 Then Exit Sub
    '    Me.dtgLiquidacion.Rows.RemoveAt(Me.dtgLiquidacion.CurrentCellAddress.Y)
    '    Me.Actualizar_Galones_Utilizados_x_Operacion()
    '    Me.Actualizar_Total_Galones_x_Operacion()
    'End Sub

    Private Sub btnGeneraLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarLiquidarCombustible.Click

        Try
            If Me.dtgVales.RowCount = 0 Then
                HelpClass.MsgBox("Asignar Vales de Combustible", MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Me.dtgLiquidacion.RowCount = 0 Then
                HelpClass.MsgBox("Insertar Operaciones a Liquidar", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Actualizar_Galones_Utilizados()
            Actualizar_Galones_Asignados()
            If _GalonesUtilizados > _GalonesAsignados Then
                HelpClass.MsgBox("Galones Utilizados es mayor a los Galones Asignados", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.Asignacion_Combustible()
            Dim Fila As String = ""
            For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
                If Me.dtgVales.Item("NSLCMB", lint_Contador).Value = -1 Then
                    If Fila <> "" Then
                        Fila = Fila & ", " & lint_Contador + 1
                    Else
                        Fila = lint_Contador + 1
                    End If
                End If
            Next
            If Fila <> "" Then
                HelpClass.MsgBox("Vale(s) Grifo la(s) fila(s) " & Fila & " ya está registrado, no se puede continuar con la Liquidación", MessageBoxIcon.Warning)

            Else
                Me.Procesar_Liquidacion()
                HelpClass.MsgBox("Combustible Registrado ", MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAgregarVale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarVale.Click
        Try
            Dim frmValeEnRuta As New frmListaValeRuta
            Dim objEntidad As New LiquidacionCombustible
            With frmValeEnRuta
                .NPLCUN = Me.txtTracto.Text
                .CCMPN = Me.txtCompania.Tag
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnAsignarCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarCombustible.Click
        Dim dgvrVale As DataGridViewRow

        Try
            Dim obj_Entidad As New Combustible
            Dim frm_AsignarCombustibleTemp As New frmAsignarCombustibleTemp
            Dim objComb As New Combustible
            For i As Integer = 0 To Me.dtgVales.RowCount - 1
                objComb.NVLGRF = dtgVales.Item(1, i).Value
                Me.objLista.Add(objComb)
            Next
            Dim Fila As Int32 = 0
            With frm_AsignarCombustibleTemp
                obj_Entidad.CCMPN = _obj_Entidad_Combustible.CCMPN
                obj_Entidad.CDVSN = _obj_Entidad_Combustible.CDVSN
                obj_Entidad.CPLNDV = _obj_Entidad_Combustible.CPLNDV
                obj_Entidad.CTRSPT = _obj_Entidad_Combustible.CTRSPT
                obj_Entidad.NRUCTR = _obj_Entidad_Combustible.NRUCTR
                obj_Entidad.NPLCUN = _obj_Entidad_Combustible.NPLCUN
                obj_Entidad.CBRCNT = _obj_Entidad_Combustible.CBRCNT
                .obj_Entidad_Combustible = obj_Entidad
                .Tag = 0
                .Lista = Me.objLista
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    dgvrVale = New DataGridViewRow
                    dgvrVale.CreateCells(Me.dtgVales)
                    Me.dtgVales.Rows.Add(dgvrVale)
                    Fila = dtgVales.Rows.Count - 1
                    dtgVales.Rows(Fila).Cells("NSLCMB").Value = .NSLCMB_1
                    dtgVales.Rows(Fila).Cells("NVLGRF").Value = .NVLGRF_1
                    dtgVales.Rows(Fila).Cells("FSLCMB").Value = HelpClass.CFecha_de_8_a_10(.FSLCMB_1.ToString.Trim)
                    dtgVales.Rows(Fila).Cells("FCRCMB").Value = HelpClass.CFecha_de_8_a_10(.FCRCMB_1.ToString.Trim)
                    dtgVales.Rows(Fila).Cells("CTPCMB").Value = .CTPCMB_1
                    dtgVales.Rows(Fila).Cells("QGLNCM_V").Value = .QGLNCM_1
                    dtgVales.Rows(Fila).Cells("CSTGLN_V").Value = .CSTGLN_1
                    dtgVales.Rows(Fila).Cells("CGRFO").Value = .CGRFO_1
                    dtgVales.Rows(Fila).Cells("NPRCN1").Value = .NPRCN1_1
                    dtgVales.Rows(Fila).Cells("NPRCN2").Value = .NPRCN2_1
                    dtgVales.Rows(Fila).Cells("NPRCN3").Value = .NPRCN3_1
                    dtgVales.Rows(Fila).Cells("NDCCT1").Value = .NDCCT1_1
                    dtgVales.Rows(Fila).Cells("CTPOD1").Value = .CTPOD1_1
                    dtgVales.Rows(Fila).Cells("FDCCT1").Value = .FDCCT1_1
                    dtgVales.Rows(Fila).Cells("ASIGNADO").Value = 0
                   
                    'dgvrVale.Cells(0).Value = .NSLCMB_1
                    'dgvrVale.Cells(1).Value = .NVLGRF_1
                    'dgvrVale.Cells(2).Value = HelpClass.CFecha_de_8_a_10(.FSLCMB_1.ToString.Trim) 'obj_Combustible.FSLCMB_D.ToShortDateString
                    'dgvrVale.Cells(3).Value = HelpClass.CFecha_de_8_a_10(.FCRCMB_1.ToString.Trim) 'obj_Combustible.FCRCMB_D.ToShortDateString
                    'dgvrVale.Cells(4).Value = .CTPCMB_1
                    'dgvrVale.Cells(5).Value = .QGLNCM_1
                    'dgvrVale.Cells(6).Value = .CSTGLN_1
                    'dgvrVale.Cells(7).Value = .CGRFO_1
                    'dgvrVale.Cells(8).Value = .NPRCN1_1
                    'dgvrVale.Cells(9).Value = .NPRCN2_1
                    'dgvrVale.Cells(10).Value = .NPRCN3_1
                    'dgvrVale.Cells(11).Value = .NDCCT1_1
                    'dgvrVale.Cells(12).Value = .CTPOD1_1
                    'dgvrVale.Cells(13).Value = .FDCCT1_1
                    'Me.dtgVales.Rows.Add(dgvrVale)

                    Calcular_Combustible()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgLiquidacion_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgLiquidacion.EditingControlShowing
        Dim txt As DataGridViewTextBoxEditingControl = e.Control
        Select Case Me.dtgLiquidacion.CurrentCell.ColumnIndex
            Case 4, 5, 6, 7
                AddHandler txt.KeyPress, AddressOf Validar_IsNumeric
        End Select
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgVales.RowCount = 0 OrElse Me.dtgVales.CurrentRow.Selected = False Then Exit Sub
            If MsgBox("Desea eliminar esta Asignación de Combustible", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Cancel Then Exit Sub
            Dim obj_Entidad As New Combustible
            Dim obj_Logica As New Combustible_BLL
            Dim lint_Indice_A As Integer = Me.dtgVales.CurrentCellAddress.Y
            dtgVales.Rows.Remove(Me.dtgVales.CurrentRow)
            Calcular_Combustible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Asignacion_Combustible()
        Dim obj_Entidad As Combustible
        Dim obj_Logica As New Combustible_BLL
        Me.dtgVales.EndEdit()
        'dtgVales.Rows(Fila).Cells("ASIGNADO")
        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            If dtgVales.Rows(lint_Contador).Cells("ASIGNADO").Value = 0 Then
                obj_Entidad = New Combustible
                obj_Entidad.FSLCMB = HelpClass.TodayNumeric
                obj_Entidad.CCMPN = _obj_Entidad_Combustible.CCMPN
                obj_Entidad.CDVSN = _obj_Entidad_Combustible.CDVSN
                obj_Entidad.CPLNDV = _obj_Entidad_Combustible.CPLNDV
                obj_Entidad.NRUCTR = _obj_Entidad_Combustible.NRUCTR
                obj_Entidad.NPLCUN = _obj_Entidad_Combustible.NPLCUN
                obj_Entidad.CBRCNT = _obj_Entidad_Combustible.CBRCNT
                obj_Entidad.CGRFO = Me.dtgVales.Item("CGRFO", lint_Contador).Value
                obj_Entidad.CTPCMB = Me.dtgVales.Item("CTPCMB", lint_Contador).Value
                obj_Entidad.FCRCMB = CType(HelpClass.CtypeDate(Me.dtgVales.Item("FCRCMB", lint_Contador).Value), Double)
                obj_Entidad.NVLGRF = Me.dtgVales.Item("NVLGRF", lint_Contador).Value
                obj_Entidad.QGLNCM = Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value
                obj_Entidad.NPRCN1 = Me.dtgVales.Item("NPRCN1", lint_Contador).Value
                obj_Entidad.NPRCN2 = Me.dtgVales.Item("NPRCN2", lint_Contador).Value
                obj_Entidad.NPRCN3 = Me.dtgVales.Item("NPRCN3", lint_Contador).Value

                If Me.dtgVales.Item("CSTGLN_V", lint_Contador).Value > 0 Then obj_Entidad.CSTGLN = Me.dtgVales.Item("CSTGLN_V", lint_Contador).Value

                obj_Entidad.NDCCT1 = Me.dtgVales.Item("NDCCT1", lint_Contador).Value
                obj_Entidad.CTPOD1 = Me.dtgVales.Item("CTPOD1", lint_Contador).Value
                obj_Entidad.FDCCT1 = Me.dtgVales.Item("FDCCT1", lint_Contador).Value

                obj_Entidad.CUSCRT = MainModule.USUARIO
                obj_Entidad.FCHCRT = HelpClass.TodayNumeric
                obj_Entidad.HRACRT = HelpClass.NowNumeric
                obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                Dim lNSLCMB As Int64

                lNSLCMB = obj_Logica.Registrar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
                Me.dtgVales.Item("NSLCMB", lint_Contador).Value = lNSLCMB
            End If
            'Me.dtgVales.EndEdit()
        Next
    End Sub

    Private Sub Agregar_Operacion_Liquidar(ByVal objParameter As Hashtable)

        If Me.Validar_Existencia_Operación(objParameter("NOPRCN")) = True Then
            HelpClass.MsgBox("Ya se Asignó esta Operación", MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim objLogica As New LiquidacionCombustible_BLL
            Dim objParam As New Hashtable
            objParam.Add("NOPRCN", objParameter("NOPRCN"))
            If objLogica.Validar_Existencia_Operacion_Liquidacion(objParam) = -1 Then
                If MsgBox("La Operación ya está Liquidado, desea agregarlo ", MsgBoxStyle.YesNo, "Liquidación") = MsgBoxResult.No Then Exit Sub
            End If
        End If

        Dim dwv As New DataGridViewRow()
        dwv.CreateCells(Me.dtgLiquidacion)
        dwv.Cells(0).Value = objParameter("NOPRCN")
        dwv.Cells(1).Value = objParameter("CCLNT")
        dwv.Cells(2).Value = objParameter("TCMPCL") 'obj_Entidad_Guia_Transporte.CCLNT
        dwv.Cells(3).Value = objParameter("RUTA")
        dwv.Cells(4).Value = objParameter("QKMREC")
        dwv.Cells(5).Value = objParameter("PMRCMC")
        dwv.Cells(6).Value = objParameter("QKMREC")
        dwv.Cells(8).Value = objParameter("CTOPVJ")
        dwv.Cells(9).Value = objParameter("NPLCUN")
        dwv.Cells(10).Value = objParameter("NGUIRM")

        'If lOpcion = 1 Then
        'dwv.Cells(4).Value = objParameter("NKMRTC_L")
        'Else
        'dwv.Cells(4).Value = obj_Entidad_Guia_Transporte.QKMREC
        'End If
        Me.dtgLiquidacion.Rows.Add(dwv)

    End Sub

    Private Sub Lista_Combustible()
        Dim obj_Logica As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        Dim olOperacionTransporte As New List(Of OperacionTransporte)
        If _obj_Entidad_Combustible.NMVJCS > 0 Then
            Try
                objParametro.Add("NOPRCN", _obj_Entidad_Combustible.NOPRCN)
                objParametro.Add("NPLCUN", _obj_Entidad_Combustible.NPLCUN)
                objParametro.Add("NMVJCS", _obj_Entidad_Combustible.NMVJCS)

                Me.dtgLiquidacion.AutoGenerateColumns = False

                olOperacionTransporte = obj_Logica.Listar_Operacion_TipViajeConsolidado_Asignar(objParametro)
            Catch : End Try
        Else
            objParametro.Add("NOPRCN", _obj_Entidad_Combustible.NOPRCN)
            objParametro.Add("NPLCUN", _obj_Entidad_Combustible.NPLCUN)

            Me.dtgLiquidacion.AutoGenerateColumns = False

            'Dim oOperacionTransporte As New OperacionTransporte
            olOperacionTransporte = obj_Logica.Listar_Operacion_Asignar(objParametro)
            'Me.dtgLiquidacion.DataSource = obj_Logica.Listar_Operacion_Asignar(objParametro)
        End If

        Dim dwv As New DataGridViewRow()
        For Each oOperacionTransporte As OperacionTransporte In olOperacionTransporte
            dwv.CreateCells(Me.dtgLiquidacion)
            dwv.Cells(0).Value = oOperacionTransporte.NOPRCN
            dwv.Cells(1).Value = oOperacionTransporte.CCLNT
            dwv.Cells(2).Value = oOperacionTransporte.TCMPCL
            dwv.Cells(3).Value = oOperacionTransporte.RUTA
            dwv.Cells(4).Value = oOperacionTransporte.QKMREC
            dwv.Cells(5).Value = oOperacionTransporte.PMRCMC
            dwv.Cells(6).Value = oOperacionTransporte.QKMREC
            dwv.Cells(8).Value = oOperacionTransporte.CTPOVJ
            dwv.Cells(9).Value = oOperacionTransporte.NPLCUN
            dwv.Cells(10).Value = oOperacionTransporte.NGUIRM
            Me.dtgLiquidacion.Rows.Add(dwv)
        Next

    End Sub

    Private Sub Actualizar_Galones_Asignados()
        Dim ldobl_Suma As Double = 0
        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            'Me.dtgVales.EndEdit()
            'If Me.dtgVales.Item(0, lint_Contador).Value Then
            ldobl_Suma += Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value
            'End If
        Next
        _GalonesAsignados = ldobl_Suma

    End Sub

    Private Sub Actualizar_Total_Galones_x_Operacion()
        Dim ldobl_Suma As Double = 0
        Me.dtgLiquidacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            If Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value <> Nothing Then
                ldobl_Suma += Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value
            End If
        Next

    End Sub

    Private Sub Actualizar_Galones_Utilizados()
        Dim ldobl_Suma As Double = 0
        For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            ldobl_Suma += Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value
        Next
        _GalonesUtilizados = ldobl_Suma
    End Sub

    Private Sub Validar_IsNumeric(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim columna As Integer = Me.dtgLiquidacion.CurrentCell.ColumnIndex
        Select Case columna
            Case 4, 5, 6
                If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
                    e.Handled = True
                Else
                    If 1 <= InStr(sender.EditingControlFormattedValue, ".", CompareMethod.Binary) Then
                        If e.KeyChar = "." Then
                            e.Handled = True
                        End If
                    End If
                End If
        End Select
        Me.dtgLiquidacion.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    'Private Function Validar_Existencia_Operación(ByVal ldob_NOPRCN As Double) As Boolean
    '    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
    '        If Me.dtgLiquidacion.Item("NOPRCN_L", lint_Contador).Value = ldob_NOPRCN Then
    '            Return True
    '        End If
    '    Next
    '    Dim objLogica As New LiquidacionCombustible_BLL

    '    For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
    '        If Me.dtgLiquidacion.Item("NOPRCN_L", lint_Contador).Value = ldob_NOPRCN Then
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function

    'Private Sub Agregar_Operacion_Liquidar(ByVal objParameter As Hashtable, ByVal lOpcion As Integer)
    '    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
    '    Dim obj_Logica_Guia As New GuiaTransportista_BLL
    '    If lOpcion = 2 Then
    '        If Me.txtTracto.Tag.ToString.Trim = objParameter("NRUCTR") And Me.txtTracto.Text.Trim = objParameter("NPLCTR") Then
    '        Else
    '            HelpClass.MsgBox("No es el mismo Tracto a Liquidar", MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        obj_Entidad_Guia_Transporte.NOPRCN = objParameter("NOPRCN")
    '        obj_Entidad_Guia_Transporte.NPLCTR = objParameter("NPLCTR")
    '        obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
    '    End If

    '    If Me.Validar_Existencia_Operación(objParameter("NOPRCN")) = True Then
    '        HelpClass.MsgBox("Ya se Asignó esta Operación", MessageBoxIcon.Information)
    '        Exit Sub
    '    Else
    '        Dim objLogica As New LiquidacionCombustible_BLL
    '        Dim objParam As New Hashtable
    '        objParam.Add("NOPRCN", objParameter("NOPRCN"))
    '        If objLogica.Validar_Existencia_Operacion_Liquidacion(objParam) = -1 Then
    '            If MsgBox("La Operación ya está Liquidado, desea agregarlo ", MsgBoxStyle.YesNo, "Liquidación") = MsgBoxResult.No Then Exit Sub
    '        End If
    '    End If

    '    Dim dwv As New DataGridViewRow()
    '    dwv.CreateCells(Me.dtgLiquidacion)
    '    dwv.Cells(0).Value = objParameter("NOPRCN")
    '    dwv.Cells(1).Value = objParameter("TCMPCL") 'obj_Entidad_Guia_Transporte.CCLNT
    '    dwv.Cells(2).Value = objParameter("RUTA")
    '    If lOpcion = 1 Then
    '        dwv.Cells(3).Value = objParameter("NKMRTC")
    '    Else
    '        dwv.Cells(3).Value = obj_Entidad_Guia_Transporte.QKMREC
    '    End If
    '    dwv.Cells(4).Value = 0
    '    dwv.Cells(5).Value = 0
    '    dwv.Cells(6).Value = 0
    '    dwv.Cells(7).Value = 0
    '    Me.dtgLiquidacion.Rows.Add(dwv)

    'End Sub

    Private Function Validar_Existencia_Operación(ByVal ldob_NOPRCN As Double) As Boolean
        For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            If Me.dtgLiquidacion.Item("NOPRCN", lint_Contador).Value = ldob_NOPRCN Then
                Return True
            End If
        Next
        Dim objLogica As New LiquidacionCombustible_BLL

        For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            If Me.dtgLiquidacion.Item("NOPRCN", lint_Contador).Value = ldob_NOPRCN Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Alinear_Columnas_Grilla()
        Me.dtgVales.AutoGenerateColumns = False
        Me.dtgLiquidacion.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.dtgVales.ColumnCount - 1
            Me.dtgVales.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador As Integer = 0 To Me.dtgLiquidacion.ColumnCount - 1
            Me.dtgLiquidacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Procesar_Liquidacion()
        Dim obj_LiquidacionCombustible_Logica As New LiquidacionCombustible_BLL
        Dim obj_Combustible_Logica As New Combustible_BLL
        Dim obj_Combustible As Combustible
        Dim obj_LiquidCombustible As New LiquidacionCombustible
        Dim list_Combustible As New List(Of Combustible)
        Dim list_LiquidCombustible As New List(Of LiquidacionCombustible)
        Dim lNLQCMB As Int64 = 0

        Actualizar_Galones_Utilizados()
        Actualizar_Galones_Asignados()

        obj_LiquidCombustible.NPLCUN = Me.txtTracto.Text.ToString.Trim
        obj_LiquidCombustible.NRUCTR = Me.txtTracto.Tag.ToString.Trim
        obj_LiquidCombustible.CCMPN = Me.txtCompania.Tag.ToString.Trim
        obj_LiquidCombustible.CDVSN = Me.txtDivision.Tag.ToString.Trim
        obj_LiquidCombustible.CPLNDV = Me.txtPlanta.Tag.ToString.Trim
        obj_LiquidCombustible.FLQDCN = HelpClass.TodayNumeric
        obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB", 0).Value
        obj_LiquidCombustible.QGLNSA = 0
        obj_LiquidCombustible.QTGLIN = _GalonesAsignados
        obj_LiquidCombustible.QGLNUT = _GalonesUtilizados 'IIf(Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value)
        obj_LiquidCombustible.USRCRT = MainModule.USUARIO
        obj_LiquidCombustible.FCHCRT = HelpClass.TodayNumeric
        obj_LiquidCombustible.HRACRT = HelpClass.NowNumeric
        obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        lNLQCMB = obj_LiquidacionCombustible_Logica.Registrar_Liquidacion_Combustible(obj_LiquidCombustible).NLQCMB

        For lint_Contador As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            Me.dtgLiquidacion.EndEdit()
            obj_LiquidCombustible = New LiquidacionCombustible
            obj_LiquidCombustible.NLQCMB = lNLQCMB
            obj_LiquidCombustible.NOPRCN = Me.dtgLiquidacion.Item("NOPRCN", lint_Contador).Value
            obj_LiquidCombustible.NKMRCR = IIf(Me.dtgLiquidacion.Item("NKMRTC", lint_Contador).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("NKMRTC", lint_Contador).Value) ' NKMRCR_L
            obj_LiquidCombustible.QGLNCM = IIf(Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value.ToString.Trim = "", 0, Me.dtgLiquidacion.Item("QGLNCM", lint_Contador).Value)
            obj_LiquidCombustible.CTPCMB = Me.dtgVales.Item("CTPCMB", 0).Value
            obj_LiquidCombustible.FULTAC = HelpClass.TodayNumeric
            obj_LiquidCombustible.HULTAC = HelpClass.NowNumeric
            obj_LiquidCombustible.CULUSA = MainModule.USUARIO
            obj_LiquidCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            list_LiquidCombustible.Add(obj_LiquidCombustible)
        Next
        obj_LiquidacionCombustible_Logica.Registrar_Detalle_Liquidacion_Combustible(list_LiquidCombustible)

        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            obj_Combustible = New Combustible
            obj_Combustible.NSLCMB = Me.dtgVales.Item("NSLCMB", lint_Contador).Value
            obj_Combustible.NLQCMB = lNLQCMB
            obj_Combustible.FCHLQD = HelpClass.TodayNumeric
            obj_Combustible.HRALQD = HelpClass.NowNumeric
            obj_Combustible.USRLQD = MainModule.USUARIO
            obj_Combustible.FULTAC = HelpClass.TodayNumeric
            obj_Combustible.HULTAC = HelpClass.NowNumeric
            obj_Combustible.CULUSA = MainModule.USUARIO
            obj_Combustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            list_Combustible.Add(obj_Combustible)
        Next
        obj_Combustible_Logica.Actualizar_Asignacion_Combustible_Tracto(list_Combustible)

    End Sub

    Private Function Verificar_Seleccion_Vales() As Boolean
        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            If Me.dtgVales.Item(0, lint_Contador).Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Lista_Asignacion_Combustible_x_Tracto()
        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim objParametro As New Hashtable
        Dim dwv As DataGridViewRow
        'Try
        objParametro.Add("PSNPLCUN", Me.txtTracto.Text)
        objParametro.Add("PSCCMPN", Me.txtCompania.Tag)
        objParametro.Add("PSCDVSN", Me.txtDivision.Tag)
        objParametro.Add("PNCPLNDV", CType(Me.txtPlanta.Tag, Double))
        objParametro.Add("PSSESSLC", "P")
        Me.dtgVales.Rows.Clear()
        For Each obj_Combustible As Combustible In obj_LogicaCombustible.Listar_Asignacion_Combustible_x_Tractos(objParametro)
            dwv = New DataGridViewRow
            dwv.CreateCells(Me.dtgVales)
            dwv.Cells(0).Value = False
            dwv.Cells(1).Value = obj_Combustible.NSLCMB
            dwv.Cells(2).Value = obj_Combustible.NVLGRF
            dwv.Cells(3).Value = obj_Combustible.FSLCMB_D.ToShortDateString
            dwv.Cells(4).Value = obj_Combustible.FCRCMB_D.ToShortDateString
            dwv.Cells(5).Value = obj_Combustible.CTPCMB
            dwv.Cells(6).Value = obj_Combustible.QGLNCM
            dwv.Cells(7).Value = obj_Combustible.CSTGLN
            Me.dtgVales.Rows.Add(dwv)
        Next
        'Catch : End Try

    End Sub

    Private Sub Guardar_Vale_Combustible(ByVal objEntidad As LiquidacionCombustible)
        Dim obj_Entidad As New Combustible
        Dim obj_Logica As New Combustible_BLL
        obj_Entidad.NSLCMB = 0
        obj_Entidad.FSLCMB = HelpClass.CFecha_a_Numero8Digitos(objEntidad.FCRCMB_S)
        obj_Entidad.CCMPN = Me.txtCompania.Tag
        obj_Entidad.CDVSN = Me.txtDivision.Tag
        obj_Entidad.CPLNDV = Me.txtPlanta.Tag
        obj_Entidad.NRUCTR = objEntidad.NRUCTR
        obj_Entidad.NPLCUN = Me.txtTracto.Text.Trim
        obj_Entidad.CBRCNT = objEntidad.CBRCNT
        obj_Entidad.CGRFO = objEntidad.CGRFO
        obj_Entidad.CTPCMB = objEntidad.CTPCMB
        obj_Entidad.FCRCMB = HelpClass.CFecha_a_Numero8Digitos(objEntidad.FCRCMB_S)
        obj_Entidad.NVLGRF = objEntidad.NVLGRF
        obj_Entidad.QGLNCM = objEntidad.QGLNCM
        obj_Entidad.CSTGLN = Format(objEntidad.CSTGLN, "####,####.##00")
        obj_Entidad.NPRCN1 = ""
        obj_Entidad.NPRCN2 = ""
        obj_Entidad.NPRCN3 = ""
        obj_Entidad.CUSCRT = MainModule.USUARIO
        obj_Entidad.FCHCRT = HelpClass.TodayNumeric
        obj_Entidad.HRACRT = HelpClass.NowNumeric
        obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obj_Entidad.NSLCMB = obj_Logica.Registrar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB
        If obj_Entidad.NSLCMB = 0 Then
            HelpClass.ErrorMsgBox()
        ElseIf obj_Entidad.NSLCMB = -1 Then
            HelpClass.MsgBox("N° Vale Grifo " & objEntidad.NVLGRF & " , está registrado", MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub Calcular_Combustible()

        'Dim ColumnIndex As Integer = Me.dtgLiquidacion.CurrentCell.ColumnIndex

        Dim ldobl_Suma As Double = 0
        Dim ldobl_SumaLiq As Double = 0
        Dim SumaPeso As Double = 0
        Dim SumaPesoLiq As Double = 0
        _SumaPeso = 0

        For lint_Contador As Integer = 0 To Me.dtgVales.RowCount - 1
            If Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value <> Nothing Then
                ldobl_Suma += Me.dtgVales.Item("QGLNCM_V", lint_Contador).Value
            End If
        Next
        _SumaPeso = ldobl_Suma

        For lint_Contador2 As Integer = 0 To Me.dtgLiquidacion.RowCount - 1
            If Me.dtgLiquidacion.Item("PMRCMC", lint_Contador2).Value <> Nothing Then
                ldobl_SumaLiq += Me.dtgLiquidacion.Item("PMRCMC", lint_Contador2).Value
            End If
        Next
        _SumaPesoLiq = ldobl_SumaLiq

        For lint_Contador3 As Integer = 0 To Me.dtgLiquidacion.RowCount - 1

            If _SumaPeso > 0 Then
                Me.dtgLiquidacion.Item("QGLNCM", lint_Contador3).Value = _SumaPeso * Me.dtgLiquidacion.Item("PMRCMC", lint_Contador3).Value / _SumaPesoLiq

            Else
                Me.dtgLiquidacion.Item("QGLNCM", lint_Contador3).Value = 0

            End If
        Next
    End Sub

#End Region

    Private Sub btnAsignarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOperacion.Click
        Try
            Dim frm_OpcionAgregarOperacion As New frmOpcionAgregarOperacion
            Dim frm_BuscarGuia As New frmAgregarOperacion
            Dim frm_ListaTractosPlaneamiento As New frmListaTractos_x_Planeamiento
            Dim frm_LiquidarOperacion As New frmLiquidarOperacion
            Dim obj_Entidad_Liquidacion As New LiquidacionGastos
            Dim obj_Logica_Liquidacion As New LiquidacionGastos_BLL

            Dim BuscarOperacion As New frmBuscarOperacion
            Dim objParam As Hashtable
            With BuscarOperacion
                .txtTracto.Text = Me.txtTracto.Text.Trim
                .txtTracto.Enabled = False
                .CCMPN = Me.txtCompania.Tag
                .CDVSN = Me.txtDivision.Tag
                .CPLNDV = Me.txtPlanta.Tag
                .FLAG = 1
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    objParam = New Hashtable
                    objParam.Add("NRUCTR", _obj_Entidad_Combustible.NRUCTR)
                    objParam.Add("NPLCTR", Me.txtTracto.Text.Trim)

                    objParam.Add("NOPRCN", .NOPRCN_1)
                    objParam.Add("CCLNT", .CCLNT_1)
                    Dim oRucTransp As Double = 0
                    oRucTransp = _obj_Entidad_Combustible.NRUCTR
                    Dim oCodCliente As Double = 0
                    oCodCliente = BuscarOperacion.CCLNT_1
                    objParam.Add("TCMPCL", .TCMPCL_2)
                    objParam.Add("RUTA", .RUTA_1)
                    'objParam.Add("PMRCMC", )
                    'QKMREC no aplica para este caso, por tanto es cero
                    Dim oOpeTra As New OperacionTransporte
                    oOpeTra = Listar_Operacion(BuscarOperacion.NOPRCN_1)
                    objParam.Add("QKMREC", oOpeTra.QKMREC)
                    objParam.Add("PMRCMC", oOpeTra.PMRCMC)
                    objParam.Add("CTOPVJ", oOpeTra.CTPOVJ)
                    objParam.Add("NPLCUN", oOpeTra.NPLCUN)
                    objParam.Add("NGUIRM", oOpeTra.NGUIRM)
                    Me.Agregar_Operacion_Liquidar(objParam)
                    'End With
                End If
            End With
            Me.Actualizar_Galones_Utilizados()
            Me.Actualizar_Total_Galones_x_Operacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Function Listar_Operacion(ByVal NroOper As Double) As OperacionTransporte
        Dim obj_Logica As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        Dim intValorCon As Int32 = 0
        'Dim rowData As DataRow
        Dim olOperacionTransporte As New List(Of OperacionTransporte)
        Dim oOperacionTransporte As New OperacionTransporte
        'Try
        objParametro.Add("NOPRCN", NroOper)
        Dim oDt As New DataTable
        oDt = obj_Logica.Listar_Operaciones_Asignacion(objParametro)
        olOperacionTransporte = Obtener_Operacion_Transporte(oDt.Rows(0).Item("NOPRCN"), oDt.Rows(0).Item("NPLCUN").ToString.Trim, oDt.Rows(0).Item("NMVJCS").ToString.Trim)
        oOperacionTransporte.NOPRCN = olOperacionTransporte.Item(0).NOPRCN
        oOperacionTransporte.CCLNT = olOperacionTransporte.Item(0).CCLNT
        oOperacionTransporte.TCMPCL = olOperacionTransporte.Item(0).TCMPCL
        oOperacionTransporte.RUTA = olOperacionTransporte.Item(0).RUTA
        oOperacionTransporte.QKMREC = olOperacionTransporte.Item(0).QKMREC
        oOperacionTransporte.PMRCMC = olOperacionTransporte.Item(0).PMRCMC
        oOperacionTransporte.CTPOVJ = olOperacionTransporte.Item(0).CTPOVJ
        oOperacionTransporte.NPLCUN = olOperacionTransporte.Item(0).NPLCUN
        oOperacionTransporte.NGUIRM = olOperacionTransporte.Item(0).NGUIRM
        'Catch : End Try
        Return oOperacionTransporte
    End Function

    Private Function Obtener_Operacion_Transporte(ByVal NroOperacion As Double, ByVal NPLCUN As String, ByVal NMVJCS As String) As List(Of OperacionTransporte)
        Dim obj_Logica As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        Dim olOpeTransporte As New List(Of OperacionTransporte)
        'Dim dQKMREC As Double
        If NMVJCS > 0 Then

            objParametro.Add("NOPRCN", NroOperacion)
            objParametro.Add("NPLCUN", NPLCUN)
            objParametro.Add("NMVJCS", NMVJCS)
            olOpeTransporte = obj_Logica.Listar_Operacion_TipViajeConsolidado_Asignar(objParametro)
        Else
            objParametro.Add("NOPRCN", NroOperacion)
            objParametro.Add("NPLCUN", NPLCUN)

            olOpeTransporte = obj_Logica.Listar_Operacion_Asignar(objParametro)
        End If
        Return olOpeTransporte
    End Function


    Private Sub btnEliminarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOperacion.Click
        Try
            If Me.dtgLiquidacion.RowCount = 0 Then Exit Sub
            Me.dtgLiquidacion.Rows.RemoveAt(Me.dtgLiquidacion.CurrentCellAddress.Y)
            Me.Actualizar_Galones_Utilizados()
            Me.Actualizar_Total_Galones_x_Operacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


   
   
End Class
