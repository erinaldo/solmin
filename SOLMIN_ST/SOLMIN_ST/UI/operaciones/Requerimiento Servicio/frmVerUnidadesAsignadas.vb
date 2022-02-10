
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario

Public Class frmVerUnidadesAsignadas


    Private _Entidad As AtencionRequerimiento
    Public Property Entidad() As AtencionRequerimiento
        Get
            Return _Entidad
        End Get
        Set(ByVal value As AtencionRequerimiento)
            _Entidad = value
        End Set
    End Property


    Private Sub frmVerUnidadesAsignadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'Alinear_Columnas_Grilla()
            dtgRecursosAsignados.AutoGenerateColumns = False
            Cargar_Unidades_Asignadas()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Alinear_Columnas_Grilla()

        Me.dtgRecursosAsignados.AutoGenerateColumns = False

        For lint_contador As Integer = 0 To Me.dtgRecursosAsignados.ColumnCount - 1
            Me.dtgRecursosAsignados.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        dtgRecursosAsignados.Columns.Item(2).DisplayIndex = 0
        dtgRecursosAsignados.Columns.Item(3).DisplayIndex = 1
        dtgRecursosAsignados.Columns.Item(4).DisplayIndex = 2
        dtgRecursosAsignados.Columns.Item(5).DisplayIndex = 3
        dtgRecursosAsignados.Columns.Item(6).DisplayIndex = 4
        dtgRecursosAsignados.Columns.Item(28).DisplayIndex = 5
        dtgRecursosAsignados.Columns.Item(7).DisplayIndex = 6
        dtgRecursosAsignados.Columns.Item(8).DisplayIndex = 7
        dtgRecursosAsignados.Columns.Item(9).DisplayIndex = 8
        dtgRecursosAsignados.Columns.Item(10).DisplayIndex = 9
        dtgRecursosAsignados.Columns.Item(24).DisplayIndex = 10
        dtgRecursosAsignados.Columns.Item(11).DisplayIndex = 11
        dtgRecursosAsignados.Columns.Item(12).DisplayIndex = 12
        dtgRecursosAsignados.Columns.Item(13).DisplayIndex = 13
        dtgRecursosAsignados.Columns.Item(14).DisplayIndex = 14
        dtgRecursosAsignados.Columns.Item(15).DisplayIndex = 15
        dtgRecursosAsignados.Columns.Item(16).DisplayIndex = 16

        dtgRecursosAsignados.Columns.Item(18).DisplayIndex = 17
        dtgRecursosAsignados.Columns.Item(19).DisplayIndex = 18
        dtgRecursosAsignados.Columns.Item(20).DisplayIndex = 19
        dtgRecursosAsignados.Columns.Item(21).DisplayIndex = 20
        dtgRecursosAsignados.Columns.Item(22).DisplayIndex = 21

        dtgRecursosAsignados.Columns.Item(17).DisplayIndex = 22
        dtgRecursosAsignados.Columns.Item(23).DisplayIndex = 23

        dtgRecursosAsignados.Columns.Item(25).DisplayIndex = 24
        dtgRecursosAsignados.Columns.Item(26).DisplayIndex = 25

        dtgRecursosAsignados.Columns.Item(0).DisplayIndex = 26
        dtgRecursosAsignados.Columns.Item(1).DisplayIndex = 27
        dtgRecursosAsignados.Columns.Item(27).DisplayIndex = 28
        dtgRecursosAsignados.Columns.Item(29).DisplayIndex = 29
        dtgRecursosAsignados.Columns.Item(30).DisplayIndex = 30
    End Sub

    Private Sub Cargar_Unidades_Asignadas()
        Dim dwvrow As DataGridViewRow
        Dim objEntidad As New ClaseGeneral
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim Lista As New List(Of ClaseGeneral)
        Lista = Nothing

        Me.dtgRecursosAsignados.Rows.Clear()

        objEntidad.NCSOTR = _Entidad.NCSOTR
        objEntidad.CCMPN = _Entidad.CCMPN

        Lista = objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)
        dtgRecursosAsignados.DataSource = Lista




        'Dim Reg As Int32 = 0
        'For Each obj_Entidad As ClaseGeneral In Lista
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.dtgRecursosAsignados)
        '    dtgRecursosAsignados.Rows.Add(dwvrow)
        '    Reg = dtgRecursosAsignados.Rows.Count - 1
        '    '  dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
        '    dtgRecursosAsignados.Rows(Reg).Cells("SEGUIMIENTO").Value = obj_Entidad.SEGUIMIENTO
        '    '  dwvrow.Cells(2).Value = obj_Entidad.NCSOTR
        '    dtgRecursosAsignados.Rows(Reg).Cells("NCSOT").Value = obj_Entidad.NCSOTR
        '    'dwvrow.Cells(3).Value = obj_Entidad.NCRRSR
        '    dtgRecursosAsignados.Rows(Reg).Cells("NCRRSR").Value = obj_Entidad.NCRRSR
        '    ' dwvrow.Cells(4).Value = obj_Entidad.NPLNJT
        '    dtgRecursosAsignados.Rows(Reg).Cells("NPLNJT").Value = obj_Entidad.NPLNJT
        '    ' dwvrow.Cells(5).Value = obj_Entidad.NCRRPL
        '    dtgRecursosAsignados.Rows(Reg).Cells("NCRRPL").Value = obj_Entidad.NCRRPL
        '    ' dwvrow.Cells(6).Value = obj_Entidad.NRUCTR
        '    dtgRecursosAsignados.Rows(Reg).Cells("NRUCTR").Value = obj_Entidad.NRUCTR
        '    ' dwvrow.Cells(7).Value = obj_Entidad.NPLCUN
        '    dtgRecursosAsignados.Rows(Reg).Cells("NPLCUN").Value = obj_Entidad.NPLCUN
        '    'dwvrow.Cells(8).Value = obj_Entidad.NPLCAC
        '    dtgRecursosAsignados.Rows(Reg).Cells("NPLCAC").Value = obj_Entidad.NPLCAC
        '    'dwvrow.Cells(9).Value = obj_Entidad.CBRCND
        '    dtgRecursosAsignados.Rows(Reg).Cells("CBRCNT").Value = obj_Entidad.CBRCND
        '    'dwvrow.Cells(10).Value = obj_Entidad.CBRCNT
        '    dtgRecursosAsignados.Rows(Reg).Cells("CBRCND").Value = obj_Entidad.CBRCNT
        '    'dwvrow.Cells(11).Value = obj_Entidad.FASGTR
        '    dtgRecursosAsignados.Rows(Reg).Cells("FASGTR").Value = obj_Entidad.FASGTR
        '    'dwvrow.Cells(12).Value = obj_Entidad.HASGTR
        '    dtgRecursosAsignados.Rows(Reg).Cells("HASGTR").Value = obj_Entidad.HASGTR
        '    'dwvrow.Cells(13).Value = obj_Entidad.FATALM
        '    dtgRecursosAsignados.Rows(Reg).Cells("FATALM").Value = obj_Entidad.FATALM
        '    ' dwvrow.Cells(14).Value = obj_Entidad.HATALM
        '    dtgRecursosAsignados.Rows(Reg).Cells("HATALM").Value = obj_Entidad.HATALM
        '    ' dwvrow.Cells(15).Value = obj_Entidad.FSLALM
        '    dtgRecursosAsignados.Rows(Reg).Cells("FSLALM").Value = obj_Entidad.FSLALM
        '    ' dwvrow.Cells(16).Value = obj_Entidad.HSLALM
        '    dtgRecursosAsignados.Rows(Reg).Cells("HSLALM").Value = obj_Entidad.HSLALM
        '    ' dwvrow.Cells(17).Value = obj_Entidad.NGUITR
        '    dtgRecursosAsignados.Rows(Reg).Cells("NGUITR").Value = obj_Entidad.NGUITR
        '    'dwvrow.Cells(18).Value = obj_Entidad.SESPLN
        '    dtgRecursosAsignados.Rows(Reg).Cells("SESPLN").Value = obj_Entidad.SESPLN
        '    'dwvrow.Cells(19).Value = obj_Entidad.GPSLAT
        '    dtgRecursosAsignados.Rows(Reg).Cells("GPSLAT").Value = obj_Entidad.GPSLAT
        '    ' dwvrow.Cells(20).Value = obj_Entidad.GPSLON
        '    dtgRecursosAsignados.Rows(Reg).Cells("GPSLON").Value = obj_Entidad.GPSLON
        '    ' dwvrow.Cells(21).Value = obj_Entidad.FECGPS
        '    dtgRecursosAsignados.Rows(Reg).Cells("HORGPS").Value = obj_Entidad.HORGPS
        '    'dwvrow.Cells(22).Value = obj_Entidad.HORGPS

        '    'If obj_Entidad.NCOREG <> 0 Then
        '    '    dwvrow.Cells(1).Value = My.Resources.button_ok1
        '    'Else
        '    '    dwvrow.Cells(1).Value = My.Resources.Nada_1
        '    'End If
        '    If obj_Entidad.NCOREG <> 0 Then
        '        dtgRecursosAsignados.Rows(Reg).Cells("NCOREG").Value = My.Resources.button_ok1
        '    Else
        '        dtgRecursosAsignados.Rows(Reg).Cells("NCOREG").Value = My.Resources.Nada_1
        '    End If
        '    'dwvrow.Cells(23).Value = obj_Entidad.NOPRCN
        '    dtgRecursosAsignados.Rows(Reg).Cells("NOPRCN").Value = obj_Entidad.NOPRCN
        '    'dwvrow.Cells(24).Value = obj_Entidad.CBRCN2
        '    dtgRecursosAsignados.Rows(Reg).Cells("CBRCN2").Value = obj_Entidad.CBRCN2
        '    '   dwvrow.Cells(25).Value = obj_Entidad.NORINSS
        '    dtgRecursosAsignados.Rows(Reg).Cells("NORINS").Value = obj_Entidad.NORINSS
        '    If obj_Entidad.NORINSS.Trim.ToString = "" OrElse obj_Entidad.NORINSS <= 0 Then
        '        '  dwvrow.Cells(25).Style.ForeColor = Color.Blue
        '        dtgRecursosAsignados.Rows(Reg).Cells("NORINS").Style.ForeColor = Color.Blue
        '        dtgRecursosAsignados.Rows(Reg).Cells("NORINS").Value = "Enviar SAP"
        '        dtgRecursosAsignados.Rows(Reg).Cells("NORINS").ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
        '    End If
        '    ' dwvrow.Cells(26).Value = obj_Entidad.NPLNMT
        '    dtgRecursosAsignados.Rows(Reg).Cells("NPLNMT").Value = obj_Entidad.NPLNMT
        '    ' dwvrow.Cells(27).Value = My.Resources.button_ok  
        '    dtgRecursosAsignados.Rows(Reg).Cells("MODIFICAR").Value = My.Resources.button_ok
        '    '  dwvrow.Cells(28).Value = obj_Entidad.TCMTRT
        '    dtgRecursosAsignados.Rows(Reg).Cells("TCMTRT").Value = obj_Entidad.TCMTRT
        '    '  dwvrow.Cells(29).Value = obj_Entidad.NGSGWP
        '    dtgRecursosAsignados.Rows(Reg).Cells("NGSGWP").Value = obj_Entidad.NGSGWP
        '    '  dwvrow.Cells(30).Value = obj_Entidad.NCOREG
        '    dtgRecursosAsignados.Rows(Reg).Cells("NCOREG").Value = obj_Entidad.NCOREG
        '    ' dwvrow.Cells(31).Value = obj_Entidad.CTRSPT
        '    dtgRecursosAsignados.Rows(Reg).Cells("CTRSPT").Value = obj_Entidad.CTRSPT
        '    'Me.dtgRecursosAsignados.Rows.Add(dwvrow)
        'Next



    End Sub

    'Private Sub dtgRecursosAsignados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellDoubleClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        Dim hash As New Hashtable()
    '        hash("CCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString()
    '        Select Case e.ColumnIndex
    '            Case 1
    '                If Me.dtgRecursosAsignados.Item("GPSLON", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then
    '                    Dim objGpsBrowser As New frmMapa
    '                    With objGpsBrowser
    '                        .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT", e.RowIndex).Value
    '                        .Longitud = Me.dtgRecursosAsignados.Item("GPSLON", e.RowIndex).Value
    '                        .Fecha = Me.dtgRecursosAsignados.Item("FECGPS", e.RowIndex).Value
    '                        .Hora = Me.dtgRecursosAsignados.Item("HORGPS", e.RowIndex).Value.ToString.Trim
    '                        .WindowState = FormWindowState.Maximized
    '                        .ShowForm(.Latitud, .Longitud, Me)
    '                    End With
    '                End If
    '            Case 7
    '                Informacion_Detallada_Transportista(1, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '            Case 8
    '                Informacion_Detallada_Transportista(2, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '            Case 9
    '                Informacion_Detallada_Transportista(3, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '            Case 25
    '                If dtgRecursosAsignados.Item(25, e.RowIndex).Value.ToString = "Enviar SAP" Then
    '                    Enviar_Orden_Interna_SAP()
    '                End If
    '            Case 27
    '                Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
    '                Dim obj_Entidad As New Detalle_Solicitud_Transporte
    '                Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
    '                Dim lstr_Estado As String = ""

    '                obj_Entidad.NCSOTR = Me.dtgRecursosAsignados.Item(2, lint_indice).Value
    '                obj_Entidad.NCRRSR = Me.dtgRecursosAsignados.Item(3, lint_indice).Value
    '                obj_Entidad.NPLNJT = Me.dtgRecursosAsignados.Item(4, lint_indice).Value
    '                obj_Entidad.NCRRPL = Me.dtgRecursosAsignados.Item(5, lint_indice).Value
    '                obj_Entidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

    '                obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Existencias_PAG(obj_Entidad)

    '                If obj_Entidad.NGUITR <> "0" Then
    '                    lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
    '                    If obj_Entidad.NCTAVC <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
    '                    If obj_Entidad.NCSLPE <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
    '                    If obj_Entidad.NCTAV2 <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
    '                    If obj_Entidad.NCSLP2 <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
    '                    lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
    '                    HelpClass.MsgBox(lstr_Estado)
    '                    Exit Sub
    '                End If

    '                obj_Entidad.NRUCTR = Me.dtgRecursosAsignados.Item(6, lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
    '                obj_Entidad.NPLCUN = Me.dtgRecursosAsignados.Item(7, lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
    '                obj_Entidad.NPLCAC = Me.dtgRecursosAsignados.Item(8, lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
    '                obj_Entidad.CBRCNT = Me.dtgRecursosAsignados.Item(9, lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
    '                obj_Entidad.CBRCN2 = Me.dtgRecursosAsignados.Item(24, lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value

    '                Dim frmReasignarRecurso As New frmReasignarRecurso
    '                frmReasignarRecurso.IsMdiContainer = True
    '                With frmReasignarRecurso
    '                    ._obj_Entidad = obj_Entidad
    '                    .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    '                    .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    '                    .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
    '                    If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

    '                    Me.dtgRecursosAsignados.Item(7, lint_indice).Value = .ctbTracto.pNroPlacaUnidad
    '                    Me.dtgRecursosAsignados.Item(8, lint_indice).Value = .ctbAcoplado.pNroAcoplado
    '                    Me.dtgRecursosAsignados.Item(9, lint_indice).Value = .cmbConductor.pBrevete
    '                    Me.dtgRecursosAsignados.Item(10, lint_indice).Value = .cmbConductor.pNombreChofer
    '                    Me.dtgRecursosAsignados.Item(24, lint_indice).Value = .cmbSegundoConductor.pBrevete

    '                End With
    '        End Select
    '    Catch : End Try
    'End Sub

    Private Sub dtgRecursosAsignados_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgRecursosAsignados.DataBindingComplete
        Try

            For Each Item As DataGridViewRow In dtgRecursosAsignados.Rows
                If (Item.Cells("NCOREG").Value > 0) Then
                    Item.Cells("MODIFICAR").Value = My.Resources.button_ok1
                Else
                    Item.Cells("MODIFICAR").Value = My.Resources.EnBlanco
                End If

                'If Item.Cells("NORINS").Value.ToString.Trim = "" OrElse Item.Cells("NORINS").Value <= 0 Then
                'Item.Cells("NORINS").Style.ForeColor = Color.Blue
                'Item.Cells("NORINS").Value = "Enviar SAP"
                'Item.Cells("NORINS").ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
                'End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
