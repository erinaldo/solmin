Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration
Imports Ransa.Utilitario
'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmChofer


#Region " Atributos "
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private eSystemTime As SYSTEMTIME
   
  Private vFCHCRT As String = ""
  Private vHRACRT As String = ""
  Private contador As Integer = 0
  Private objPrintForm As PrintForm
    Private dtCapacitacionDatosCaptBD As DataTable
    Private dtCapacitacionDatosCapt_tmp As DataTable

    Private dtPase_TipoPaseBD As DataTable
    Private dtPase_TipoPase_tmp As DataTable

    Private dtRecordMedicoBD As DataTable
    Private dtRecordMedico_tmp As DataTable

    Private dtRecordGeneralBD As DataTable
    Private dtRecordGeneral_tmp As DataTable

  Private _prevPase As Integer = 0
  Private _prevRecord As String = ""

    Private _rutaImagen As String = "C:\IMG.bmp"
    Private oHasTabActivo As New Hashtable

 

  Friend WithEvents picBox As MyPictureBox
  Dim _NCOIMG As Integer = -1
  Dim NombrePictueSel As String = ""

    Private Lector As StreamReader
    Private strDestino As Stream
    Private x1, y1 As Single
#End Region

  Private Sub frmChofer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim fi As FileInfo = New FileInfo(_rutaImagen)
    If fi.Exists Then
      fi.Delete()
    End If
  End Sub

    Private Sub frmChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.gwdDatos.AutoGenerateColumns = False
            gwdDatos.AutoGenerateColumns = False
            gwdHistorial.AutoGenerateColumns = False
            Me.gwdHistorial.AutoGenerateColumns = False
            Me.gwdDatos.AutoGenerateColumns = False
            Me.gwdPase_TipoPase.AutoGenerateColumns = False
            Me.gwdRecordGeneral.AutoGenerateColumns = False
            Me.gwdRecordMedico.AutoGenerateColumns = False
            Me.dtgListaAsistencia.AutoGenerateColumns = False
            Me.gwdVacaciones.AutoGenerateColumns = False
            Me.gwdPase_TipoPase.AutoGenerateColumns = False
            Me.Cargar_Compania()
            Me.CargarEstado()
            Me.CargarCombos()
            Me.Validar_Acceso_Opciones_Usuario()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub LimpiarGrillas()
    Me.gwdCapacitacionDatosCapt.Rows.Clear()
    Me.gwdPase_TipoPase.Rows.Clear()
    Me.gwdRecordMedico.Rows.Clear()
    Me.gwdRecordGeneral.Rows.Clear()
    Me.gwdHistorial.DataSource = Nothing
  End Sub

  Private Sub Validar_Acceso_Opciones_Usuario()
    Dim objParametro As New Hashtable
    Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
    Dim objEntidad As New ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
    If objEntidad.STSOP1 = "" Then
      Me.btnValidar.Visible = False
      Me.Separator8.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      Me.btnReactivar.Visible = False
    End If

  End Sub

    Private Sub CargarCombos()
     
        LimpiarGrillas()
        Limpiar_Controles_Chofer()
        CargarComboTipoLicenciaConducir()
     
        Estado_Controles_Capacitacion(False)
        Estado_Controles_Pase(False)
        Estado_Controles_Record_Medico(False)
        Estado_Controles_RecordGral(False)

        'Inicializa Combos
        gwdDatos.DataSource = Nothing
        cargarComboCapacitacionGWD()
        cargarComboPaseGWD()
        cargarComboVacunaGWD()
        Cargar_Tipo_Record()

       

        gwdCapacitacionDatosCapt.ReadOnly = False
        gwdCapacitacionDatosCapt.RowTemplate.ReadOnly = False

        gwdPase_TipoPase.ReadOnly = False
        gwdPase_TipoPase.RowTemplate.ReadOnly = False

        gwdRecordMedico.ReadOnly = False
        gwdRecordMedico.RowTemplate.ReadOnly = False

        gwdRecordGeneral.ReadOnly = False
        gwdRecordGeneral.RowTemplate.ReadOnly = False

        'CentrarCabeceraColumna()

        txtFiltroBrevete.CharacterCasing = CharacterCasing.Upper
        

        TabControl1.Controls.Remove(TabPageImg)


    End Sub

  Private Sub CargarEstado()
    Dim oDt As New DataTable
    Dim oDr As DataRow
    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")

    oDr = oDt.NewRow

    oDr.Item(0) = "A"
    oDr.Item(1) = "Activos"

    oDt.Rows.Add(oDr)
    oDr = oDt.NewRow
    oDr.Item(0) = "I"
    oDr.Item(1) = "Inactivos"
    oDt.Rows.Add(oDr)

    Me.cmbEstado.DataSource = oDt
    Me.cmbEstado.ValueMember = "COD"
    Me.cmbEstado.DisplayMember = "DES"
    Me.cmbEstado.SelectedIndex = 0

  End Sub

    'Private Sub CentrarCabeceraColumna()

    '  For lint_contador As Integer = 0 To Me.gwdHistorial.ColumnCount - 1
    '    Me.gwdHistorial.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
    '    Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  For lint_contador As Integer = 0 To Me.gwdPase_TipoPase.ColumnCount - 1
    '    Me.gwdPase_TipoPase.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  For lint_contador As Integer = 0 To Me.gwdRecordGeneral.ColumnCount - 1
    '    Me.gwdRecordGeneral.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  For lint_contador As Integer = 0 To Me.gwdRecordMedico.ColumnCount - 1
    '    Me.gwdRecordMedico.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  For lint_contador As Integer = 0 To Me.dtgListaAsistencia.ColumnCount - 1
    '    Me.dtgListaAsistencia.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next


    'End Sub

#Region "Abraham"

  Private Sub Cargar_Tipo_Record()
    Dim obj As New TipoRecord_BLL
    Dim objEntidad As New TipoRecord
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    TTPRCD.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tipo_Record(objEntidad))
    TTPRCD.ValueMember = "STPRCD"
    TTPRCD.DisplayMember = "TTPRCD"
  End Sub

  Private Sub pNuevoRegistroChoferRecord()


    Dim row As New DataGridViewRow
    row.CreateCells(Me.gwdRecordGeneral)
    gwdRecordGeneral.Rows.Add(row)
    gwdRecordGeneral.Columns("FRGTRO").ReadOnly = True
    Dim idx As Integer = gwdRecordGeneral.Rows.Count - 1
    gwdRecordGeneral.Item("FRGTRO", idx).Value = HelpClass.CNumero8Digitos_a_Fecha(HelpClass.TodayNumeric)
    gwdRecordGeneral.Item(1, idx).Selected = True

    gwdRecordGeneral.CurrentRow.Tag = ""
  End Sub

     

    Private Sub ListarRecordGeneral()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim obj As New RecordGeneral_BLL
        Dim objEntidad As New RecordGeneral
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim()  '_vBrevete
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        dtRecordGeneral_tmp = HelpClass.GetDataSetNative(obj.Listar_Record_General(objEntidad))

        For Each Item As DataRow In dtRecordGeneral_tmp.Rows

            If Item("FECINI").ToString.Trim.Equals("0") Then
                Item("FECINI") = ""
            End If
            If Item("FECTER").ToString.Trim.Equals("0") Then
                Item("FECTER") = ""
            End If

        Next


        


        gwdRecordGeneral.Rows.Clear()

        Dim dgrow As DataGridViewRow
        Dim FecIni As String = ""
        Dim FecFin As String = ""

        For i As Integer = 0 To dtRecordGeneral_tmp.Rows.Count - 1
            dgrow = New DataGridViewRow
            dgrow.CreateCells(gwdRecordGeneral)
            dgrow.Cells(0).Value = dtRecordGeneral_tmp.Rows(i).Item("NCRRLT")
            dgrow.Cells(1).Value = dtRecordGeneral_tmp.Rows(i).Item("STPRCD")
            dgrow.Cells(1).ReadOnly = True
            dgrow.Cells(2).Value = dtRecordGeneral_tmp.Rows(i).Item("NRPPLT").ToString.Trim
            dgrow.Cells(3).Value = dtRecordGeneral_tmp.Rows(i).Item("MTVEVN").ToString.Trim
            dgrow.Cells(4).Value = dtRecordGeneral_tmp.Rows(i).Item("QCNESP").ToString.Trim
            dgrow.Cells(5).Value = dtRecordGeneral_tmp.Rows(i).Item("CUNCNA").ToString.Trim
            dgrow.Cells(6).Value = dtRecordGeneral_tmp.Rows(i).Item("FRGTRO").ToString.Trim

            FecIni = dtRecordGeneral_tmp.Rows(i).Item("FECINI").ToString.Trim
            dgrow.Cells(7).Value = FecIni
            dgrow.Cells(7).ReadOnly = True
            If FecIni.Equals("00/00/0000") Then
                dgrow.Cells(7).Value = Now.Date
            End If

            FecFin = dtRecordGeneral_tmp.Rows(i).Item("FECTER").ToString.Trim
            dgrow.Cells(8).Value = FecFin
            If FecFin.Equals("00/00/0000") Then
                dgrow.Cells(8).Value = Now.Date
            End If

            dgrow.Cells(9).Value = dtRecordGeneral_tmp.Rows(i).Item("TOBSMD").ToString.Trim
            dgrow.Cells(10).Value = dtRecordGeneral_tmp.Rows(i).Item("STPRCD").ToString.Trim
            dgrow.Cells(11).Value = dtRecordGeneral_tmp.Rows(i).Item("FCHCRT").ToString.Trim
            dgrow.Cells(12).Value = dtRecordGeneral_tmp.Rows(i).Item("HRACRT").ToString.Trim

            If dtRecordGeneral_tmp.Rows(i).Item("STPRCD") = "D" OrElse dtRecordGeneral_tmp.Rows(i).Item("STPRCD") = "P" Then
                dgrow.Cells(15).Value = My.Resources.printer2
            Else
                dgrow.Cells(15).Value = My.Resources.Nada_1
            End If

            dgrow.Cells(0).Tag = "ReadOnly"
            dgrow.Cells(6).Tag = "ReadOnly"


            dgrow.ReadOnly = True

            gwdRecordGeneral.Rows.Add(dgrow)
        Next

       
    End Sub

  Private Sub pGuardarRegistroChoferRecord(ByVal rowIdx As Integer)
    If gwdRecordGeneral.RowCount <= 0 Then Exit Sub

    Dim objLogica As New RecordGeneral_BLL
    Dim objEntidad As New RecordGeneral

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

    Dim valor As Object = gwdRecordGeneral.Rows(rowIdx).Cells("NCRRLT").Value
    If Not celdaTieneData(valor) Then
      objEntidad.NCRRLT = -1
    Else
      objEntidad.NCRRLT = valor
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("TTPRCD").Value
    If Not celdaTieneData(valor) Then
      objEntidad.STPRCD = ""
    Else
      objEntidad.STPRCD = valor
    End If

    objEntidad.FRGTRO = HelpClass.TodayNumeric
    objEntidad.HRGTRO = HelpClass.NowNumeric

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("FECINI").Value
    If Not celdaTieneData(valor) Then
      objEntidad.FECINI = 0
    Else
      objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(valor)
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("FECTER").Value
    If Not celdaTieneData(valor) Then
      objEntidad.FECTER = 0
    Else
      objEntidad.FECTER = HelpClass.CFecha_a_Numero8Digitos(valor)
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("NRPPLT").Value
    If Not celdaTieneData(valor) Then
      objEntidad.NRPPLT = 0
    Else
      objEntidad.NRPPLT = valor
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("MTVEVN").Value
    If Not celdaTieneData(valor) Then
      objEntidad.MTVEVN = ""
    Else
      objEntidad.MTVEVN = valor
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("TOBSMD").Value
    If Not celdaTieneData(valor) Then
      objEntidad.TOBSMD = ""
    Else
      objEntidad.TOBSMD = valor
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("QCNESP").Value
    If Not celdaTieneData(valor) Then
      objEntidad.QCNESP = 0
    Else
      objEntidad.QCNESP = valor
    End If

    valor = gwdRecordGeneral.Rows(rowIdx).Cells("CUNCNA").Value
    If Not celdaTieneData(valor) Then
      objEntidad.CUNCNA = 0
    Else
      objEntidad.CUNCNA = valor
    End If

    objEntidad.CUSCRT = MainModule.USUARIO
    objEntidad.FCHCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

    'validaciones
    Dim lboolError As Boolean = False
    If objEntidad.STPRCD = "" OrElse _
        objEntidad.FECINI = "" OrElse _
        objEntidad.FECTER = "" OrElse _
        objEntidad.FECTER < objEntidad.FECINI Then
      lboolError = True
    End If

        If Not lboolError Then
            objEntidad = objLogica.Registrar_Record_General(objEntidad)
           
            gwdRecordGeneral.Rows(rowIdx).Tag = ""
            gwdRecordGeneral.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White

        Else
            gwdRecordGeneral.Rows(rowIdx).DefaultCellStyle.BackColor = Color.Yellow
        End If

    End Sub

#End Region

  Private Sub CargarComboTipoLicenciaConducir()

        Dim obj As New TipoLicenciaConducir_BLL
        Dim objEntidad As New TipoLicenciaConducir
        objEntidad.CCATLI = ""
        CboTipoLicenciaConducir.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tipo_Licencia_Conducir(objEntidad))

        CboTipoLicenciaConducir.ValueField = "CCATLI"
        CboTipoLicenciaConducir.KeyField = "NCLICO"
        CboTipoLicenciaConducir.DataBind()
       
  End Sub

  ''version nueva
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
           

            Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            EstadoBoton(gEnum_Mantenimiento)
            

            If lstr_PestanaActiva = "DatosConductor" Then

                Limpiar_Controles_Chofer()

            ElseIf lstr_PestanaActiva = "Capacitaciones" Then

                pNuevoRegistroChoferCapac()

            ElseIf lstr_PestanaActiva = "Pases" Then

                pNuevoRegistroChoferPase()

            ElseIf lstr_PestanaActiva = "Vacunas" Then

                pNuevoRegistroChoferVacuna()

            ElseIf lstr_PestanaActiva = "Record" Then

                pNuevoRegistroChoferRecord()

            ElseIf lstr_PestanaActiva = "Vacaciones" Then

                pNuevoRegistroChoferVacaciones()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub
 

  Private Sub pNuevoRegistroChoferCapac()


    Dim row As New DataGridViewRow
    row.CreateCells(Me.gwdCapacitacionDatosCapt)
        row.Cells(0).Value = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
    gwdCapacitacionDatosCapt.Rows.Add(row)

    gwdCapacitacionDatosCapt.Columns(2).ReadOnly = True
    Dim idx As Integer = gwdCapacitacionDatosCapt.Rows.Count - 1
    gwdCapacitacionDatosCapt.Item("Fecha_RegistroCapt", idx).Value = HelpClass.CNumero8Digitos_a_Fecha(HelpClass.TodayNumeric)
    gwdCapacitacionDatosCapt.Item(1, idx).Selected = True

    gwdCapacitacionDatosCapt.CurrentRow.Tag = ""
  End Sub

  Private Sub pNuevoRegistroChoferPase()


    Dim row As New DataGridViewRow
    row.CreateCells(Me.gwdPase_TipoPase)
        row.Cells(0).Value = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
    row.Cells(8).Value = 0
    row.Cells(9).Value = 0
    gwdPase_TipoPase.Rows.Add(row)

    gwdPase_TipoPase.Columns("Fecha_Registro_Pase").ReadOnly = True
    Dim idx As Integer = gwdPase_TipoPase.Rows.Count - 1
    gwdPase_TipoPase.Item("Fecha_Registro_Pase", idx).Value = HelpClass.CNumero8Digitos_a_Fecha(HelpClass.TodayNumeric)
    gwdPase_TipoPase.Item(1, idx).Selected = True

    gwdPase_TipoPase.CurrentRow.Tag = ""
  End Sub

  Private Sub pNuevoRegistroChoferVacuna()


    Dim row As New DataGridViewRow
    row.CreateCells(Me.gwdRecordMedico)
        row.Cells(0).Value = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
    gwdRecordMedico.Rows.Add(row)

    gwdRecordMedico.Columns(2).ReadOnly = True
    Dim idx As Integer = gwdRecordMedico.Rows.Count - 1
    gwdRecordMedico.Item("FECREG", idx).Value = HelpClass.CNumero8Digitos_a_Fecha(HelpClass.TodayNumeric)
    gwdRecordMedico.Item(1, idx).Selected = True

    gwdRecordMedico.CurrentRow.Tag = ""
  End Sub

  Private Sub pNuevoRegistroChoferVacaciones()


    Dim row As New DataGridViewRow
    row.CreateCells(Me.gwdVacaciones)
    gwdVacaciones.Rows.Add(row)
    gwdVacaciones.Columns("CUNCNA_V").ReadOnly = True
    Dim idx As Integer = gwdVacaciones.Rows.Count - 1
    gwdVacaciones.Item("ANOINI", idx).Value = Date.Today.Year - 1
    gwdVacaciones.Item("ANOFIN", idx).Value = Date.Today.Year
    gwdVacaciones.Item("CUNCNA_V", idx).Value = "DIA"
    gwdVacaciones.Item("ANOINI", idx).Selected = True

    gwdVacaciones.CurrentRow.Tag = ""
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try
          

      Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name
      '======================================================================================================
      If lstr_PestanaActiva = "DatosConductor" Then
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
          If validarChofer() = 1 Then
                        Nuevo_Registro_Chofer()
                        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                        EstadoBoton(gEnum_Mantenimiento)
                      
          End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    'If txtCodigoBrevete.Text <> "" And validarChofer() = 1 Then
                    If validarChofer() = 1 Then
                        Modificar_Registro_Chofer()
                        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                        EstadoBoton(gEnum_Mantenimiento)
                        

                    End If
                   
        End If
        '======================================================================================================

      ElseIf lstr_PestanaActiva = "Capacitaciones" Then
                gwdCapacitacionDatosCapt.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    Dim lstr_accion As String = ""
                    For rowIdx As Integer = 0 To gwdCapacitacionDatosCapt.Rows.Count - 1
                        lstr_accion = gwdCapacitacionDatosCapt.Rows(rowIdx).Tag
                        If lstr_accion IsNot Nothing Then
                            If lstr_accion.StartsWith("M") Then
                                pGuardarRegistroChoferCapac(rowIdx)
                            End If
                        End If
                    Next
                  
                    Listar_Capacitacion()
                    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    EstadoBoton(gEnum_Mantenimiento)


                    
                End If

                '======================================================================================================
            ElseIf lstr_PestanaActiva = "Pases" Then
                ''VERSION NUEVA
                gwdPase_TipoPase.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    Dim lstr_accion As String = ""
                    For rowIdx As Integer = 0 To gwdPase_TipoPase.Rows.Count - 1
                        lstr_accion = gwdPase_TipoPase.Rows(rowIdx).Tag
                        If lstr_accion IsNot Nothing Then
                            If lstr_accion.StartsWith("M") Then
                                pGuardarRegistroChoferPase(rowIdx)
                            End If
                        End If
                    Next
                    Listar_Pase()
                    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    EstadoBoton(gEnum_Mantenimiento)
                  

                    
                End If
                '======================================================================================================
            ElseIf lstr_PestanaActiva = "Vacunas" Then
                gwdRecordMedico.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    Dim lstr_accion As String = ""
                    For rowIdx As Integer = 0 To gwdRecordMedico.Rows.Count - 1
                        lstr_accion = gwdRecordMedico.Rows(rowIdx).Tag
                        If lstr_accion IsNot Nothing Then
                            If lstr_accion.StartsWith("M") Then
                                pGuardarRegistroChoferVacuna(rowIdx)
                            End If
                        End If
                    Next
                    ListarRecordMedico()
                    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    EstadoBoton(gEnum_Mantenimiento)
                   

                    
                End If
                '======================================================================================================
            ElseIf lstr_PestanaActiva = "Record" Then
                gwdRecordGeneral.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    Dim lstr_accion As String = ""
                    For rowIdx As Integer = 0 To gwdRecordGeneral.Rows.Count - 1
                        lstr_accion = gwdRecordGeneral.Rows(rowIdx).Tag
                        If lstr_accion IsNot Nothing Then
                            If lstr_accion.StartsWith("M") Then
                                pGuardarRegistroChoferRecord(rowIdx)
                            End If
                        End If
                    Next
                    ListarRecordGeneral()
                    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    EstadoBoton(gEnum_Mantenimiento)
                    
                End If
            ElseIf lstr_PestanaActiva = "Vacaciones" Then
                gwdVacaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    Dim lstr_accion As String = ""
                    For rowIdx As Integer = 0 To gwdVacaciones.Rows.Count - 1
                        lstr_accion = gwdVacaciones.Rows(rowIdx).Tag
                        If lstr_accion IsNot Nothing Then
                            If Not Validar_Datos(rowIdx) Then Exit Sub
                            If lstr_accion.StartsWith("M") Then
                                pGuardarRegistroChoferVacaciones(rowIdx)
                            End If
                        End If
                    Next
                    ListarRecordGeneral()
                    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    EstadoBoton(gEnum_Mantenimiento)
                    
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

   
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try

            Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            If oHasTabActivo.ContainsKey(lstr_PestanaActiva) Then
                oHasTabActivo.Remove(lstr_PestanaActiva)
            End If
            MostrarDetalleRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
  End Sub

  ''version nueva
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name

            If lstr_PestanaActiva = "DocAdjuntos" Then
                If (_NCOIMG = -1) Then
                    MsgBox("Seleccione un documento")
                Else
                    If MsgBox("Desea eliminar el documento?", MsgBoxStyle.OkCancel, "Eliminar Documento") = MsgBoxResult.Ok Then
                        Dim objLogica As New DocAdjuntoConductor_BLL
                        Dim objEntidad As New DocAdjuntoConductor
                        objEntidad.NCOIMG = CInt(_NCOIMG)
                        objEntidad.CULUSA = MainModule.USUARIO
                        objEntidad.FULTAC = HelpClass.TodayNumeric
                        objEntidad.HULTAC = HelpClass.NowNumeric
                        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                        objEntidad = objLogica.Eliminar_Documento_Adjunto(objEntidad)
                        cargarDocLinks()
                        
                    End If

                End If
            Else
                'btnNuevo.Enabled = True
                If lstr_PestanaActiva = "DatosConductor" Then
                    'antes de eliminar verifica si tiene registros en tablas relacionadas
                    If gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then
                        'If Me.txtCodigoBrevete.Text <> "" Then
                        Dim objEntidad As New Chofer
                        Dim objTransChofer As New TransportistaConductor_BLL
                    
                        objEntidad.CBRCNT = gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim
                        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        
                        Dim str3 As String = "Desea dar de baja al conductor?"
                        If MsgBox(str3, MsgBoxStyle.OkCancel, "Dar de baja") = MsgBoxResult.Cancel Then Exit Sub
                        Mostrar_Formulario_Para_Activar_ReactivarConductor("I")
                        
                    End If
                ElseIf lstr_PestanaActiva = "Capacitaciones" Then
                    pEliminarRegistroChoferCapac(gwdCapacitacionDatosCapt.CurrentCellAddress.Y)

                ElseIf lstr_PestanaActiva = "Pases" Then
                    pEliminarRegistroChoferPase(gwdPase_TipoPase.CurrentCellAddress.Y)

                ElseIf lstr_PestanaActiva = "Vacunas" Then
                    pEliminarRegistroChoferVacuna(gwdRecordMedico.CurrentCellAddress.Y)

                ElseIf lstr_PestanaActiva = "Record" Then
                    pEliminarRegistroChoferEval(gwdRecordGeneral.CurrentCellAddress.Y)

                ElseIf lstr_PestanaActiva = "Vacaciones" Then
                    pEliminarRegistroChoferVacaciones(gwdVacaciones.CurrentCellAddress.Y)

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'posicionado en el tab conductor
        Try
            Realizar_Busqueda()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

  End Sub

  Private Sub Realizar_Busqueda()
    TabConductor.SelectedIndex = 0
       
        gwdDatos.DataSource = Nothing
        Limpiar_Controles_Chofer()

        oHasTabActivo.Clear()
        Listar_Chofer()

        
  End Sub

    

    
#Region "CONDUCTOR"

    Private Sub Nuevo_Registro_Chofer()
        Dim objEntidad As New Chofer
        Dim objChofer As New Chofer_BLL

        objEntidad.CBRCNT = Me.txtCodigoBrevete.Text.Trim
        objEntidad.TNMCMC = Me.txtNombres.Text.Trim
        objEntidad.TAPPAC = Me.txtApellidoPaterno.Text.Trim
        objEntidad.TAPMAC = Me.txtApellidoMaterno.Text.Trim
        objEntidad.NLELCH = Me.txtDni.Text.Trim
        objEntidad.CSGRSC = Me.txtSeguroSocial.Text.Trim
        objEntidad.TGRPSN = Me.txtGrupoSanguineo.Text.Trim
        objEntidad.NCLICO = CboTipoLicenciaConducir.Codigo

        objEntidad.FVEDNI = Format(Me.dtpDatFecVencDNI.Value, "yyyyMMdd")
        objEntidad.FEMLIC = Format(Me.dtpDatFecEmLic.Value, "yyyyMMdd")
        objEntidad.FVELIC = Format(Me.dtpDatFecVencLic.Value, "yyyyMMdd")
        objEntidad.CODSAP = Me.txtDatCodSAP.Text.Trim

        objEntidad.FCHING = Format(Me.dtpDatFecIng.Value, "yyyyMMdd")
        objEntidad.TDRCC = Me.txtDatDireccion.Text.Trim
        objEntidad.NRORPM = IIf(Me.txtDatRPM.Text.Trim = "", 0, Me.txtDatRPM.Text.Trim)
        objEntidad.TOBS = Me.txtDatObservaciones.Text.Trim

        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.SINDRC = IIf(chkTercero.Checked, "T", "P")
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue

        objEntidad = objChofer.Registrar_Chofer(objEntidad)

        MessageBox.Show("Registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

         
        txtFiltroBrevete.Text = objEntidad.CBRCNT
        Listar_Chofer(chkTercero.Checked)
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
       
    End Sub

  Private Sub Modificar_Registro_Chofer()
    Dim objEntidad As New Chofer
    Dim objChofer As New Chofer_BLL

        objEntidad.CBRCNT = gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.TNMCMC = Me.txtNombres.Text.Trim
        objEntidad.TAPPAC = Me.txtApellidoPaterno.Text.Trim
        objEntidad.TAPMAC = Me.txtApellidoMaterno.Text.Trim
        objEntidad.NLELCH = Me.txtDni.Text.Trim
        objEntidad.CSGRSC = Me.txtSeguroSocial.Text.Trim
        objEntidad.TGRPSN = Me.txtGrupoSanguineo.Text.Trim
    objEntidad.NCLICO = CboTipoLicenciaConducir.Codigo

    objEntidad.FVEDNI = Format(Me.dtpDatFecVencDNI.Value, "yyyyMMdd")
    objEntidad.FEMLIC = Format(Me.dtpDatFecEmLic.Value, "yyyyMMdd")
    objEntidad.FVELIC = Format(Me.dtpDatFecVencLic.Value, "yyyyMMdd")
        objEntidad.CODSAP = Me.txtDatCodSAP.Text.Trim
    objEntidad.FCHING = Format(Me.dtpDatFecIng.Value, "yyyyMMdd")
        objEntidad.TDRCC = Me.txtDatDireccion.Text.Trim
        objEntidad.NRORPM = IIf(Me.txtDatRPM.Text.Trim.ToString.Trim = "", 0, Me.txtDatRPM.Text.Trim)
        objEntidad.TOBS = Me.txtDatObservaciones.Text.Trim

    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.SINDRC = IIf(chkTercero.Checked, "T", "P")
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad = objChofer.Modificar_Chofer(objEntidad)

        MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)

        Listar_Chofer(chkTercero.Checked)
       

  End Sub

    Private Sub Listar_Chofer()
        Dim obj As New Chofer_BLL
        Dim objEntidad As New Chofer

        objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.ESTADO = Me.cmbEstado.SelectedValue.ToString().Trim().ToUpper()
        objEntidad.SINDRC = IIf(rbtnPropio.Checked, "P", "T")
        Me.gwdDatos.DataSource = HelpClass.GetDataSetNative(obj.Listar_Chofer(objEntidad))

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
    End Sub

  Private Sub Listar_Chofer(ByVal b As Boolean)
    Dim obj As New Chofer_BLL
    Dim objEntidad As New Chofer

    objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim
    objEntidad.SINDRC = IIf(b, "T", "P")
    objEntidad.ESTADO = Me.cmbEstado.SelectedValue
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value


    Me.gwdDatos.DataSource = HelpClass.GetDataSetNative(obj.Listar_Chofer(objEntidad))


  End Sub

  Private Function validarChofer() As Integer
    If Me.txtCodigoBrevete.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el código de brevete.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtNombres.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el nombre del chofer.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtApellidoPaterno.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el apellido paterno.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtApellidoMaterno.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el apellido materno.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.CboTipoLicenciaConducir.Codigo = "" Or Me.CboTipoLicenciaConducir.Codigo = "0" Then
      MsgBox("Seleccione el tipo de licencia.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtDni.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el DNI.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtDni.Text.Length <> 8 Then
      HelpClass.MsgBox("El DNI debe tener 8 digitos.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf dtpDatFecEmLic.Value > dtpDatFecVencLic.Value Then
      HelpClass.MsgBox("La fecha de vencimiento debe ser posterior a la fecha de emisión de licencia.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf chkTercero.Checked AndAlso txtDatCodSAP.Text.Trim <> "" Then
      HelpClass.MsgBox("Los terceros no pueden tener Código SAP.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Not chkTercero.Checked AndAlso txtDatCodSAP.Text.Trim = "" Then
      HelpClass.MsgBox("Debe especificar un Código SAP.", MsgBoxStyle.Exclamation)
      Return 0
    End If

    Return 1
  End Function

  Private Sub Limpiar_Controles_Chofer()
    txtApellidoMaterno.Text = ""
    txtApellidoPaterno.Text = ""
    txtCodigoBrevete.Text = ""
    txtDni.Text = ""
    txtGrupoSanguineo.Text = ""
    txtNombres.Text = ""
    txtSeguroSocial.Text = ""
    CboTipoLicenciaConducir.Limpiar()
    Me.dtpDatFecVencDNI.Value = Now
    Me.dtpDatFecEmLic.Value = Now
    Me.dtpDatFecVencLic.Value = Now
    Me.txtDatCodSAP.Text = ""
    Me.dtpDatFecIng.Value = Now
    Me.txtDatDireccion.Text = ""
    Me.txtDatRPM.Text = ""
    Me.txtDatObservaciones.Text = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Conductor."
    Me.imgConductor.Image = Nothing


    _NCOIMG = -1
  End Sub

  Private Sub Estado_Controles_Chofer(ByVal lbool_Estado As Boolean)
        'Me.txtCodigoBrevete.Enabled = lbool_Estado
        txtCodigoBrevete.ReadOnly = Not lbool_Estado
        'If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
        '  Me.txtCodigoBrevete.Enabled = Not lbool_Estado
        'End If
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            'txtCodigoBrevete.Enabled = True
            txtCodigoBrevete.ReadOnly = False
        Else
            'txtCodigoBrevete.Enabled = False
            txtCodigoBrevete.ReadOnly = True
        End If
    Me.txtApellidoMaterno.Enabled = lbool_Estado
    Me.txtApellidoPaterno.Enabled = lbool_Estado
    Me.txtDni.Enabled = lbool_Estado
    Me.txtGrupoSanguineo.Enabled = lbool_Estado
    Me.txtNombres.Enabled = lbool_Estado
    Me.txtSeguroSocial.Enabled = lbool_Estado
    Me.CboTipoLicenciaConducir.Enabled = lbool_Estado
    Me.KryptonButton1.Enabled = lbool_Estado

    Me.dtpDatFecVencDNI.Enabled = lbool_Estado
    Me.dtpDatFecEmLic.Enabled = lbool_Estado
    Me.dtpDatFecVencLic.Enabled = lbool_Estado
    Me.txtDatCodSAP.Enabled = lbool_Estado
    Me.dtpDatFecIng.Enabled = lbool_Estado
    Me.txtDatDireccion.Enabled = lbool_Estado
    Me.txtDatRPM.Enabled = lbool_Estado
    Me.txtDatObservaciones.Enabled = lbool_Estado
    Me.chkTercero.Enabled = lbool_Estado

  End Sub

    
    Private Sub cargarDocLinks()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        _NCOIMG = -1
        Dim objLogica As New DocAdjuntoConductor_BLL
        Dim dtb As New DataTable
        Dim NomCarpetaConductor As String = ""
        NomCarpetaConductor = ConfigurationManager.AppSettings("RUTA_CONDUCTOR").ToString()
        Dim miHash As New Hashtable()

        Dim objParamentro As New Hashtable
        If gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then
            'If txtCodigoBrevete.Text.Trim <> vbNullString Then
            'miHash.Add("CBRCNT", txtCodigoBrevete.Text.Trim)
            miHash.Add("CBRCNT", gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim)
            miHash.Add("NCRRDC", 0)
            miHash.Add("CCMPN", Me.gwdDatos.CurrentRow.Cells("CCMPN").Value)
        Else
            Exit Sub
        End If
        NomCarpetaConductor = (NomCarpetaConductor & miHash("CBRCNT").ToString()).Trim()

        'lee los doclinks de la BD
        dtb = objLogica.Listar_Documentos_Adjuntos(miHash)
        Me.lwDoc.Items.Clear()
        Me.lwImg.Items.Clear()

        'crear componentes con sus imagenes
        If dtb.Rows.Count > 0 Then

            'Agregar Columnas a dtb 
            dtb.Columns.Add("RUTA", Type.GetType("System.String"))
            dtb.Columns.Add("TIPO", Type.GetType("System.String"))

            For Each dr As DataRow In dtb.Rows
                Dim lpNombreDoc As String = dr.Item("CLINK").ToString.Trim
                Dim ext As String = lpNombreDoc.Substring(lpNombreDoc.LastIndexOf("."), lpNombreDoc.Length - lpNombreDoc.LastIndexOf("."))
                ext = ext.ToLower

                dr.Item("RUTA") = Obtener_Ruta(dr.Item("CLINK").ToString.Trim, NomCarpetaConductor)
                dr.Item("TIPO") = ext
                dr.AcceptChanges()
            Next

            For Each dr As DataRow In dtb.Rows
                Dim lpNombreDoc As String = dr.Item("CLINK").ToString.Trim
                Dim ext As String = lpNombreDoc.Substring(lpNombreDoc.LastIndexOf("."), lpNombreDoc.Length - lpNombreDoc.LastIndexOf("."))
                ext = ext.ToLower
                If dr.Item("CTIIMG").ToString.Trim = "DOC" Then
                    Dim itemDoc As New ListViewItem
                    Select Case ext
                        Case ".doc"
                            itemDoc.ImageKey = "word"
                        Case ".docx"
                            itemDoc.ImageKey = "word"
                        Case ".xls"
                            itemDoc.ImageKey = "excel"
                        Case ".xlsx"
                            itemDoc.ImageKey = "excel"
                        Case ".ppt"
                            itemDoc.ImageKey = "ppt"
                        Case ".pdf"
                            itemDoc.ImageKey = "pdf"
                        Case ".txt"
                            itemDoc.ImageKey = "text"
                        Case ".jpg"
                            itemDoc.ImageKey = "image"
                        Case ".jpeg"
                            itemDoc.ImageKey = "image"
                        Case ".bmp"
                            itemDoc.ImageKey = "image"
                        Case ".png"
                            itemDoc.ImageKey = "image"
                        Case ".tiff"
                            itemDoc.ImageKey = "image"
                        Case ".gif"
                            itemDoc.ImageKey = "image"
                        Case Else
                            itemDoc.ImageKey = "filex"
                    End Select

                    itemDoc.SubItems.Add(dr.Item("CLINK"))
                    itemDoc.SubItems.Add(dr.Item("TIPO"))
                    itemDoc.SubItems.Add(HelpClass.CFecha_de_8_a_10(dr.Item("FCHCRT")))
                    itemDoc.SubItems.Add(dr.Item("TOBS"))
                    'itemDoc.SubItems.Add(dr.Item("CBRCNT"))
                    'itemDoc.SubItems.Add(dr.Item("NCRRDC"))
                    itemDoc.SubItems.Add(dr.Item("NCOIMG"))
                    Me.lwDoc.Items.Add(itemDoc)

                ElseIf dr.Item("CTIIMG").ToString.Trim = "IMG" Then
                    Dim itemImg As New ListViewItem
                    Select Case ext
                        Case ".jpg"
                            itemImg.ImageKey = "image"
                        Case ".jpeg"
                            itemImg.ImageKey = "image"
                        Case ".bmp"
                            itemImg.ImageKey = "image"
                        Case ".png"
                            itemImg.ImageKey = "image"
                        Case ".tiff"
                            itemImg.ImageKey = "image"
                        Case ".gif"
                            itemImg.ImageKey = "image"
                    End Select

                    itemImg.SubItems.Add(dr.Item("CLINK"))
                    itemImg.SubItems.Add(dr.Item("TIPO"))
                    itemImg.SubItems.Add(HelpClass.CFecha_de_8_a_10(dr.Item("FCHCRT")))
                    itemImg.SubItems.Add(dr.Item("TOBS"))
                  
                    itemImg.SubItems.Add(dr.Item("NCOIMG"))
                    Me.lwImg.Items.Add(itemImg)

                End If
            Next
        End If
        Cambiar_Ancho_Columna()

    End Sub
    Private Sub Cambiar_Ancho_Columna()
        If lwDoc.Items.Count > 0 Then
            For Each clh As ColumnHeader In lwDoc.Columns
                If clh.Index = 5 Then
                    clh.Width = 0
                Else
                    clh.Width = -2
                End If
            Next
        End If

        For Each clhi As ColumnHeader In lwImg.Columns
            If clhi.Index = 5 Then
                clhi.Width = 0
            Else
                clhi.Width = -2
            End If
        Next
    End Sub

    Private Function Obtener_Ruta(ByVal lpNombreDoc As String, ByVal strCarpeta As String) As String
        Dim URL As String

        Dim lstr_URLDoc As String = My.Settings.ST_URL + "imagenes/solmin/" & strCarpeta
        URL = lstr_URLDoc & "/" & lpNombreDoc
        Return URL
    End Function

    Private Sub metalDobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            Dim pb As New MyPictureBox
            pb = sender
            Process.Start(pb.URL)
        End If
      
    End Sub

    Private Sub metalClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TypeOf sender Is PictureBox Then
            For Each oControldoc As Control In Me.PnlDocs.Controls()
                For Each oControldoc1 As Control In oControldoc.Controls()
                    Dim opbx As New PictureBox()
                    opbx = CType(oControldoc1, PictureBox)
                    opbx.Size = New System.Drawing.Size(50, 50)
                Next
            Next
            Dim pb As New MyPictureBox
            pb = sender
            pb.Size = New System.Drawing.Size(100, 100)
            pb.BackColor = Color.Blue
            _NCOIMG = pb.Name
        End If
       
    End Sub

    Private Sub Cargar_Detalle_Chofer()
        
        Limpiar_Controles_Chofer()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim Fila As Integer = gwdDatos.CurrentRow.Index

        If Me.gwdDatos.Item("FLGAPR", Fila).Value <> "" Then
            btnValidar.Text = "Anular Verificación"
        Else
            btnValidar.Text = "Verificar Datos"
        End If
        Cargar_Datos_Conductor(Fila)

    End Sub

    Private Sub Cargar_Datos_Conductor(ByVal lint_indice As Int32)
        Me.txtCodigoBrevete.Text = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() ' _vBrevete
        Me.txtNombres.Text = Me.gwdDatos.Item("TNMCMC", lint_indice).Value.ToString().Trim()
        Me.txtApellidoPaterno.Text = Me.gwdDatos.Item("TAPPAC", lint_indice).Value.ToString().Trim()
        Me.txtApellidoMaterno.Text = Me.gwdDatos.Item("TAPMAC", lint_indice).Value.ToString().Trim()
        Me.CboTipoLicenciaConducir.Codigo = Me.gwdDatos.Item("NCLICO", lint_indice).Value.ToString().Trim()
        Me.txtDni.Text = Me.gwdDatos.Item("NLELCH", lint_indice).Value.ToString().Trim()
        Me.txtSeguroSocial.Text = Me.gwdDatos.Item("CSGRSC", lint_indice).Value.ToString().Trim()
        Me.txtGrupoSanguineo.Text = Me.gwdDatos.Item("TGRPSN", lint_indice).Value.ToString().Trim()
        Me.HeaderDatos.ValuesPrimary.Heading = "Información del Conductor " & txtNombres.Text & " " & txtApellidoPaterno.Text & " " & txtApellidoMaterno.Text & " / " & "Brevete: " & Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() ' _vBrevete
        vFCHCRT = Me.gwdDatos.Item("FCHCRT_CNT", lint_indice).Value.ToString().Trim()
        vHRACRT = Me.gwdDatos.Item("HRACRT_CNT", lint_indice).Value.ToString().Trim()
        chkTercero.Checked = Me.gwdDatos.Item("SINDRC", lint_indice).Value.ToString().Trim().Equals("T")

        'fecha vencimiento dni
        If Me.gwdDatos.Item("FVEDNI", lint_indice).Value.ToString().Trim() = "" Then
            Me.dtpDatFecVencDNI.Value = Today
        Else
            'La conversión de la cadena "0" en el tipo 'Date' no es válida.
            Me.dtpDatFecVencDNI.Value = Me.gwdDatos.Item("FVEDNI", lint_indice).Value.ToString().Trim()
        End If

        If Me.gwdDatos.Item("FEMLIC", lint_indice).Value.ToString().Trim() = "" Then
            Me.dtpDatFecEmLic.Value = Today
        Else
            Me.dtpDatFecEmLic.Value = Me.gwdDatos.Item("FEMLIC", lint_indice).Value.ToString().Trim()
        End If

        If Me.gwdDatos.Item("FVELIC", lint_indice).Value.ToString().Trim() = "" Then
            Me.dtpDatFecVencLic.Value = Today
        Else
            Me.dtpDatFecVencLic.Value = Me.gwdDatos.Item("FVELIC", lint_indice).Value.ToString().Trim()
        End If

        Me.txtDatCodSAP.Text = Me.gwdDatos.Item("CODSAP", lint_indice).Value.ToString().Trim()

        If Me.gwdDatos.Item("FCHING", lint_indice).Value.ToString().Trim() = "" Then
            Me.dtpDatFecIng.Value = Today
        Else
            Me.dtpDatFecIng.Value = Me.gwdDatos.Item("FCHING", lint_indice).Value.ToString().Trim()
        End If

        Me.txtDatDireccion.Text = Me.gwdDatos.Item("TDRCC", lint_indice).Value.ToString().Trim()
        Me.txtDatRPM.Text = Me.gwdDatos.Item("NRORPM", lint_indice).Value.ToString().Trim()
        Me.txtDatObservaciones.Text = Me.gwdDatos.Item("TOBS_DAT", lint_indice).Value.ToString().Trim()

        'tratando de cargar la foto del conductor 
        Dim objImage As Image
        Try
            objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/" & Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() & ".jpg", True)
        Catch ex As Exception
            objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/truck.jpg", True)
        End Try

        Me.imgConductor.Image = objImage
    End Sub

    Private Sub Lista_Asistencia_Conductor()
        If Me.gwdDatos.RowCount = 0 Then Exit Sub
        Dim obj As New Chofer_BLL
        Dim objHash As New Hashtable

        objHash.Add("CBRCNT", Me.gwdDatos.Item("CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHash.Add("CCMPN", Me.cmbCompania.SelectedValue)

        Me.dtgListaAsistencia.DataSource = obj.Lista_Asistencia_Conductor(objHash)
    End Sub

#End Region

#Region "CONDUCTOR - RECORD MEDICO"



    Private Sub Nuevo_Registro_Record_Medico()
        Dim objEntidad As New RecordMedico
        Dim objChofer As New RecordMedico_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.FECREG = Format(Me.dtpRecordMedicoFechaRegistro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtRecordMedicoObservaciones.Text.Trim
        objEntidad.NCOVAC = Me.cboRecordMedicoVacuna.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objChofer.Registrar_Record_Medico(objEntidad)
        ListarRecordMedico()
    
    End Sub

    Private Sub Modificar_Record_Medico()
        Dim objEntidad As New RecordMedico
        Dim objChofer As New RecordMedico_BLL

        objEntidad.NCORMD = txtRecordMedicoCodigo.Text.Trim
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.FECREG = Format(Me.dtpRecordMedicoFechaRegistro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtRecordMedicoObservaciones.Text.Trim
        objEntidad.NCOVAC = Me.cboRecordMedicoVacuna.Codigo
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objChofer.Modificar_Record_Medico(objEntidad)
        ListarRecordMedico()
      
    End Sub

    Private Sub Eliminar_RecordMedico()
        Dim objEntidad As New RecordMedico
        Dim objChofer As New RecordMedico_BLL

        objEntidad.NCORMD = txtRecordMedicoCodigo.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objChofer.Eliminar_Record_Medico(objEntidad)
        ListarRecordMedico()
     
    End Sub

    Private Sub Limpiar_Controles_Record_Medico()
        txtRecordMedicoCodigo.Text = "0"
        txtRecordMedicoObservaciones.Text = ""
        cboRecordMedicoVacuna.Limpiar()
    End Sub

    Private Sub Estado_Controles_Record_Medico(ByVal lbool_Estado As Boolean)
        Me.cboRecordMedicoVacuna.Enabled = lbool_Estado
        
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Me.cboRecordMedicoVacuna.Enabled = Not lbool_Estado
        End If
        txtRecordMedicoObservaciones.Enabled = lbool_Estado
        dtpRecordMedicoFechaRegistro.Enabled = lbool_Estado
    End Sub

    Private Sub CargarComboVacuna()

        Dim obj As New Vacunas_BLL
        Dim objEntidad As New Vacunas
        objEntidad.CCMPN = cmbCompania.SelectedValue.ToString().Trim()
        cboRecordMedicoVacuna.DataSource = HelpClass.GetDataSetNative(obj.Listar_Vacunas(objEntidad))
        cboRecordMedicoVacuna.ValueField = "NOMVAC"
        cboRecordMedicoVacuna.KeyField = "NCOVAC"
        cboRecordMedicoVacuna.DataBind()
      
    End Sub
    Private Sub Cargar_Datos_Historial()

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obj As New TransportistaConductor()
        Dim objBll As New TransportistaConductor_BLL()
        Dim dt As New DataTable()
        obj.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        obj.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        gwdHistorial.DataSource = objBll.Listar_TransportistaConductor_Historial(obj)
       

    End Sub

    Private Sub ListarRecordMedico()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim obj As New RecordMedico_BLL
        Dim objEntidad As New RecordMedico
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim()
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value


        dtRecordMedico_tmp = HelpClass.GetDataSetNative(obj.Listar_Record_Medico(objEntidad))

        For Each Item As DataRow In dtRecordMedico_tmp.Rows

            If Item("FECINI").ToString.Trim.Equals("0") Then
                Item("FECINI") = ""
            End If
            If Item("FECFIN").ToString.Trim.Equals("0") Then
                Item("FECFIN") = ""
            End If

        Next

        
        gwdRecordMedico.Rows.Clear()

        Dim dgrow As DataGridViewRow
        Dim FecIni As String = ""
        Dim FecFin As String = ""

        For i As Integer = 0 To dtRecordMedico_tmp.Rows.Count - 1
            dgrow = New DataGridViewRow
            dgrow.CreateCells(gwdRecordMedico)
            dgrow.Cells(0).Value = dtRecordMedico_tmp.Rows(i).Item("CBRCNT").ToString.Trim
            dgrow.Cells(1).Value = dtRecordMedico_tmp.Rows(i).Item("NCOVAC")
            dgrow.Cells(1).ReadOnly = True
            dgrow.Cells(2).Value = dtRecordMedico_tmp.Rows(i).Item("FECREG").ToString.Trim

            FecIni = dtRecordMedico_tmp.Rows(i).Item("FECINI").ToString.Trim
            dgrow.Cells(3).Value = FecIni
            dgrow.Cells(3).ReadOnly = True
            If FecIni.Equals("00/00/0000") Then
                dgrow.Cells(3).Value = Now
            End If

            FecFin = dtRecordMedico_tmp.Rows(i).Item("FECFIN").ToString.Trim
            dgrow.Cells(4).Value = FecFin
            If FecFin.Equals("00/00/0000") Then
                dgrow.Cells(4).Value = Now
            End If

            dgrow.Cells(5).Value = dtRecordMedico_tmp.Rows(i).Item("TOBS").ToString.Trim
            dgrow.Cells(6).Value = dtRecordMedico_tmp.Rows(i).Item("NCORMD").ToString.Trim

            dgrow.Cells(1).Tag = "Readonly"
            dgrow.Cells(2).Tag = "Readonly"
           
            dgrow.ReadOnly = True

            gwdRecordMedico.Rows.Add(dgrow)
        Next

        

    End Sub

    Private Sub gwdRecordMedico_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdRecordMedico.CellBeginEdit
        gwdRecordMedico.Rows(e.RowIndex).Tag = "M"

    End Sub

    ''version nueva
    Private Sub gwdRecordMedico_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecordMedico.CellClick, gwdRecordMedico.CellEnter
        Try

            If e.RowIndex < 0 OrElse Me.gwdRecordMedico.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If

            gwdRecordMedico.CommitEdit(DataGridViewDataErrorContexts.Commit)

           

           

            Dim obj As Object = gwdRecordMedico.Item("Fecha_Inicio_Vacuna", gwdRecordMedico.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                obj = CType(obj, Date)
                gwdRecordMedico.Item("OLD_PNFECINI_VAC", gwdRecordMedico.CurrentCellAddress.Y).Value = HelpClass.CDate_a_Numero8Digitos(obj)
            End If

            obj = gwdRecordMedico.Item("NCOVAC", gwdRecordMedico.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                gwdRecordMedico.Item("NEW_NCOVAC", gwdRecordMedico.CurrentCellAddress.Y).Value = obj.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "CONDUCTOR - PASE"

    Private Sub Nuevo_Pase_Conductor()
        Dim objEntidad As New PaseConductor
        Dim objPaseConductor As New PaseConductor_BLL

        objEntidad.CBRCNT = gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCOPSE = cboPase_TipoPase.Codigo
        objEntidad.FECREG = Format(Me.timePase_Registro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtPase_Observacion.Text.ToString.Trim
        objEntidad.FECINI = Format(Me.timePase_Inicio.Value, "yyyyMMdd")
        objEntidad.FECFIN = Format(Me.timePase_Fin.Value, "yyyyMMdd")
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objPaseConductor.Registra_Pases(objEntidad)
        Listar_Pase()
       

    End Sub

    Private Sub Modificar_Pase_Conductor()
        Dim objEntidad As New PaseConductor
        Dim objPaseConductor As New PaseConductor_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCOPSE = cboPase_TipoPase.Codigo
        objEntidad.FECREG = Format(Me.timePase_Registro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtPase_Observacion.Text.ToString.Trim
        objEntidad.FECINI = Format(Me.timePase_Inicio.Value, "yyyyMMdd")
        objEntidad.FECFIN = Format(Me.timePase_Fin.Value, "yyyyMMdd")
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FCHCRT = vFCHCRT
        objEntidad.HRACRT = vHRACRT

        objEntidad = objPaseConductor.Modifica_Pases(objEntidad)
        Listar_Pase()
        
    End Sub

    Private Sub Eliminar_Pase()
        Dim objEntidad As New PaseConductor
        Dim objPaseConductor As New PaseConductor_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCOPSE = cboPase_TipoPase.Codigo
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FCHCRT = vFCHCRT
        objEntidad.HRACRT = vHRACRT

        objEntidad = objPaseConductor.Elimina_Pases(objEntidad)
        Listar_Pase()
       
    End Sub

    Private Sub gwdPase_TipoPase_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdPase_TipoPase.CellBeginEdit
        gwdPase_TipoPase.Rows(e.RowIndex).Tag = "M"
    End Sub

    ''VERSION NUEVA
    Private Sub gwTipoPase_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdPase_TipoPase.CellClick, gwdPase_TipoPase.CellEnter
        Try

            If e.RowIndex < 0 OrElse Me.gwdPase_TipoPase.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If

            gwdPase_TipoPase.CommitEdit(DataGridViewDataErrorContexts.Commit)

           

          

            Dim obj As Object = gwdPase_TipoPase.Item("Fecha_Inicio", gwdPase_TipoPase.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                Try
                    obj = CType(obj, Date)
                Catch ex As InvalidCastException
                    obj = Now
                End Try
                gwdPase_TipoPase.Item("OLD_PNFECINI", gwdPase_TipoPase.CurrentCellAddress.Y).Value = HelpClass.CDate_a_Numero8Digitos(obj)
            End If

            obj = gwdPase_TipoPase.Item("CodPase", gwdPase_TipoPase.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                _prevPase = obj.ToString
                gwdPase_TipoPase.Item("NEW_NCOPSE", gwdPase_TipoPase.CurrentCellAddress.Y).Value = obj.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar_Controles_Pase()
        Me.cboPase_TipoPase.Limpiar()
        Me.txtPase_Observacion.Text = ""
        Me.timePase_Registro.Text = ""
        Me.timePase_Inicio.Text = ""
        Me.timePase_Fin.Text = ""
    End Sub

    Private Sub Estado_Controles_Capacitacion(ByVal lbool_Estado As Boolean)
        Me.cboCapacitacionCodCapt.Enabled = lbool_Estado
        
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Me.cboCapacitacionCodCapt.Enabled = Not lbool_Estado
        End If
        Me.timeCapacitacionRegistro.Enabled = lbool_Estado
        Me.txtCapacitacionObservaciones.Enabled = lbool_Estado
    End Sub

    Private Sub Estado_Controles_Pase(ByVal lbool_Estado As Boolean)
        Me.cboPase_TipoPase.Enabled = lbool_Estado
       
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Me.cboPase_TipoPase.Enabled = Not lbool_Estado
        End If
        Me.txtPase_Observacion.Enabled = lbool_Estado
        Me.timePase_Registro.Enabled = lbool_Estado
        Me.timePase_Inicio.Enabled = lbool_Estado
        Me.timePase_Fin.Enabled = lbool_Estado
    End Sub

    Private Sub Listar_Pase()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim obj As New PaseConductor_BLL
        Dim objEntidad As New PaseConductor
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        dtPase_TipoPase_tmp = HelpClass.GetDataSetNative(obj.Lista_Pases(objEntidad))

        For Each Item As DataRow In dtPase_TipoPase_tmp.Rows

            If Item("FECINI").ToString.Trim.Equals("0") Then
                Item("FECINI") = ""
            End If
            If Item("FECFIN").ToString.Trim.Equals("0") Then
                Item("FECFIN") = ""
            End If

        Next
        
        gwdPase_TipoPase.Rows.Clear()

        Dim dgrow As DataGridViewRow
        Dim FecIni As String = ""
        Dim FecFin As String = ""

        For i As Integer = 0 To dtPase_TipoPase_tmp.Rows.Count - 1
            dgrow = New DataGridViewRow
            dgrow.CreateCells(gwdPase_TipoPase)
            dgrow.Cells(0).Value = dtPase_TipoPase_tmp.Rows(i).Item("CBRCNT").ToString.Trim
            dgrow.Cells(1).Value = dtPase_TipoPase_tmp.Rows(i).Item("NCOPSE")
            dgrow.Cells(1).ReadOnly = True
            dgrow.Cells(2).Value = dtPase_TipoPase_tmp.Rows(i).Item("FECREG").ToString.Trim
            dgrow.Cells(2).ReadOnly = True

            FecIni = dtPase_TipoPase_tmp.Rows(i).Item("FECINI").ToString.Trim
            dgrow.Cells(3).Value = FecIni
            dgrow.Cells(3).ReadOnly = True
            If FecIni.Equals("00/00/0000") Then
                dgrow.Cells(3).Value = Now
            End If

            FecFin = dtPase_TipoPase_tmp.Rows(i).Item("FECFIN").ToString.Trim
            dgrow.Cells(4).Value = FecFin
            If FecFin.Equals("00/00/0000") Then
                dgrow.Cells(4).Value = Now
            End If

            dgrow.Cells(5).Value = dtPase_TipoPase_tmp.Rows(i).Item("TOBS").ToString.Trim
            dgrow.Cells(6).Value = dtPase_TipoPase_tmp.Rows(i).Item("FCHCRT").ToString.Trim
            dgrow.Cells(7).Value = dtPase_TipoPase_tmp.Rows(i).Item("HRACRT").ToString.Trim

            dgrow.Cells(1).Tag = "Readonly"
            dgrow.Cells(2).Tag = "Readonly"
            

            dgrow.ReadOnly = True

            gwdPase_TipoPase.Rows.Add(dgrow)
        Next

       

    End Sub

    Private Sub Cargar_TipoPase()

        Dim TipoPaseCondBL As New TipoPaseConductor_BLL
        Dim objEntidad As New TipoPaseConductor
        Me.cboPase_TipoPase.DataSource = HelpClass.GetDataSetNative(TipoPaseCondBL.Lista_Tipo_Pases(objEntidad))
        Me.cboPase_TipoPase.ValueField = "NOMPSE"
        Me.cboPase_TipoPase.KeyField = "NCOPSE"
        cboPase_TipoPase.DataBind()
        
    End Sub

#End Region

#Region "CONDUCTOR - CAPACITACION"

    Private Sub Nueva_CapacitacionConductor()
        Dim objCapacitacionConductor As New CapacitacionConductor_BLL
        Dim objEntidad As New CapacitacionConductor
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCOCPT = cboCapacitacionCodCapt.Codigo
        objEntidad.FECREG = Format(Me.timeCapacitacionRegistro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtCapacitacionObservaciones.Text.ToString.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = cmbCompania.SelectedValue.ToString()
        objEntidad = objCapacitacionConductor.Registrar_CapacitacionConductor(objEntidad)
        Listar_Capacitacion()
      
    End Sub

    Private Sub Modificar_CapacitacionConductor()
        Dim objCapacitacionConductor As New CapacitacionConductor_BLL
        Dim objEntidad As New CapacitacionConductor
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCOCPT = cboCapacitacionCodCapt.Codigo
        objEntidad.FECREG = Format(Me.timeCapacitacionRegistro.Value, "yyyyMMdd")
        objEntidad.TOBS = Me.txtCapacitacionObservaciones.Text.ToString.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FCHCRT = vFCHCRT
        objEntidad.HRACRT = vHRACRT
        objEntidad.CCMPN = cmbCompania.SelectedValue.ToString().Trim()

        objEntidad = objCapacitacionConductor.Modificar_CapacitacionConductor(objEntidad)
        Listar_Capacitacion()
       
    End Sub

    Private Sub Eliminar_Capacitacion()
        If cboCapacitacionCodCapt.Codigo.ToString.Trim <> "0" And _
                cboCapacitacionCodCapt.Codigo.ToString.Trim <> "" Then

            Dim objEntidad As New CapacitacionConductor
            Dim obj As New CapacitacionConductor_BLL
            objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
            objEntidad.NCOCPT = cboCapacitacionCodCapt.Codigo
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.FCHCRT = vFCHCRT
            objEntidad.HRACRT = vHRACRT
            objEntidad.CCMPN = cmbCompania.SelectedValue.ToString().Trim()

            objEntidad = obj.Eliminar_CapacitacionConductor(objEntidad)
            Listar_Capacitacion()
           
        End If
    End Sub

    Private Sub Cargar_TipoCapacitacion()

        Dim objCapacitacion As New TipoCapacitacionConductor_BLL
        Dim objEntidad As New TipoCapacitacionConductor
        Me.cboCapacitacionCodCapt.DataSource = HelpClass.GetDataSetNative(objCapacitacion.Listar_TipoCapacitacionConductor(objEntidad))
        Me.cboCapacitacionCodCapt.ValueField = "NOMCPT"
        Me.cboCapacitacionCodCapt.KeyField = "NCOCPT"
        Me.cboCapacitacionCodCapt.DataBind()
       
    End Sub

    Private Sub gwdCapacitacionDatosCapt_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdCapacitacionDatosCapt.CellBeginEdit
        gwdCapacitacionDatosCapt.Rows(e.RowIndex).Tag = "M"
    End Sub

    

     

    Private Sub Limpiar_ControlesCapacitacion()
        Me.cboCapacitacionCodCapt.Limpiar()
        Me.txtCapacitacionObservaciones.Text = ""
        Me.timeCapacitacionRegistro.Value = Today
    End Sub

    Private Sub Estado_ControlesCapacitacion(ByVal estado As Boolean)
        Me.cboCapacitacionCodCapt.Enabled = estado
        Me.txtCapacitacionObservaciones.Enabled = estado
        Me.timeCapacitacionRegistro.Enabled = estado
    End Sub

    Private Sub Listar_Capacitacion()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim obj As New CapacitacionConductor_BLL
        Dim objEntidad As New CapacitacionConductor
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        Me.gwdCapacitacionDatosCapt.AutoGenerateColumns = False

        dtCapacitacionDatosCapt_tmp = HelpClass.GetDataSetNative(obj.Listar_CapacitacionConductor(objEntidad))

        For Each Item As DataRow In dtCapacitacionDatosCapt_tmp.Rows

            If Item("FECINI").ToString.Trim.Equals("0") Then
                Item("FECINI") = ""
            End If
            If Item("FECFIN").ToString.Trim.Equals("0") Then
                Item("FECFIN") = ""
            End If

        Next

        


        gwdCapacitacionDatosCapt.Rows.Clear()

        Dim dgrow As DataGridViewRow
        Dim FecIni As String = ""
        Dim FecFin As String = ""

        For i As Integer = 0 To dtCapacitacionDatosCapt_tmp.Rows.Count - 1
            dgrow = New DataGridViewRow
            dgrow.CreateCells(gwdCapacitacionDatosCapt)
            dgrow.Cells(0).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("CBRCNT").ToString.Trim
            dgrow.Cells(1).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("NCOCPT")
            dgrow.Cells(1).ReadOnly = True
            dgrow.Cells(2).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("FECREG").ToString.Trim
            dgrow.Cells(2).ReadOnly = True
            dgrow.Cells(3).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("FCHCRT").ToString.Trim
            dgrow.Cells(4).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("HRACRT").ToString.Trim

            FecIni = dtCapacitacionDatosCapt_tmp.Rows(i).Item("FECINI").ToString.Trim
            dgrow.Cells(5).Value = FecIni
            dgrow.Cells(5).ReadOnly = True
            If FecIni.Equals("00/00/0000") Then
                dgrow.Cells(5).Value = Now
            End If

            FecFin = dtCapacitacionDatosCapt_tmp.Rows(i).Item("FECFIN").ToString.Trim
            dgrow.Cells(6).Value = FecFin
            If FecFin.Equals("00/00/0000") Then
                dgrow.Cells(6).Value = Now
            End If

            dgrow.Cells(7).Value = dtCapacitacionDatosCapt_tmp.Rows(i).Item("TOBS").ToString.Trim

            dgrow.Cells(1).Tag = "ReadOnly"
            dgrow.Cells(2).Tag = "ReadOnly"
            'dgrow.Cells(5).Tag = "ReadOnly"

            dgrow.ReadOnly = True

            gwdCapacitacionDatosCapt.Rows.Add(dgrow)
        Next

       

    End Sub

#End Region

#Region "CONDUCTOR - RECORD GENERAL"

    Private Sub Nuevo_Registro_Record_General(ByVal rowIdx As Integer)
        Dim objEntidad As New RecordGeneral
        Dim obj As New RecordGeneral_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCRRLT = 0
        objEntidad.STPRCD = gwdRecordGeneral.Rows(rowIdx).Cells("TTPRCD").Value
        objEntidad.FRGTRO = HelpClass.CDate_a_Numero8Digitos(gwdRecordGeneral.Rows(rowIdx).Cells("FRGTRO").Value)
        objEntidad.HRGTRO = HelpClass.NowNumeric
        objEntidad.FECINI = HelpClass.CDate_a_Numero8Digitos(gwdRecordGeneral.Rows(rowIdx).Cells("FECINI").Value)
        objEntidad.FECTER = HelpClass.CDate_a_Numero8Digitos(gwdRecordGeneral.Rows(rowIdx).Cells("FECTER").Value)
        objEntidad.NRPPLT = gwdRecordGeneral.Rows(rowIdx).Cells("NRPPLT").Value
        objEntidad.TOBSMD = gwdRecordGeneral.Rows(rowIdx).Cells("TOBSMD").Value
        objEntidad.QCNESP = IIf(gwdRecordGeneral.Rows(rowIdx).Cells("QCNESP").Value = "", 0, gwdRecordGeneral.Rows(rowIdx).Cells("QCNESP").Value)
        objEntidad.CUNCNA = gwdRecordGeneral.Rows(rowIdx).Cells("CUNCNA").Value
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = obj.Registrar_Record_General(objEntidad)
        ListarRecordGeneral()
       
    End Sub

    Private Sub Modificar_Record_General()
        Dim objEntidad As New RecordGeneral
        Dim obj As New RecordGeneral_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        objEntidad.NCRRLT = 0
        objEntidad.STPRCD = Me.cboRecordGeneralTipoRecord.Codigo
        objEntidad.FRGTRO = Format(Me.dtpRecordGeneralFechaRegistro.Value, "yyyyMMdd")
        objEntidad.HRGTRO = HelpClass.NowNumeric
        objEntidad.FECINI = Format(Me.dtpRecordGeneralFechaInicio.Value, "yyyyMMdd")
        objEntidad.FECTER = Format(Me.dtpRecordGeneralFechaFinal.Value, "yyyyMMdd")
        objEntidad.NRPPLT = Me.txtRecordGeneralPapeleta.Text
        ' DDEZELAP
        ' objEntidad.MTVEVN = 
        objEntidad.TOBSMD = Me.txtRecordGeneralObservaciones.Text
        objEntidad.QCNESP = Me.txtRecordGeneralCantidad.Text
        objEntidad.CUNCNA = Me.txtRecordGeneralCodigoUnidad.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FCHCRT = vFCHCRT
        objEntidad.HRACRT = vHRACRT

        objEntidad = obj.Modificar_Record_General(objEntidad)
        ListarRecordGeneral()
       
    End Sub

    Private Sub Eliminar_RecordGeneral(ByVal intCont As Integer)
        Dim objEntidad As New RecordGeneral
        Dim obj As New RecordGeneral_BLL

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCRRLT = Me.gwdRecordGeneral.Rows(intCont).Cells("NCRRLT").Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FCHCRT = vFCHCRT
        objEntidad.HRACRT = vHRACRT

        objEntidad = obj.Eliminar_Record_General(objEntidad)
        ListarRecordGeneral()
       
    End Sub

    Private Sub Limpiar_Controles_RecordGral()
        Me.cboRecordGeneralTipoRecord.Limpiar()
        Me.txtRecordGeneralObservaciones.Text = ""
        Me.dtpRecordGeneralFechaRegistro.Text = ""
        Me.dtpRecordGeneralFechaInicio.Text = ""
        Me.dtpRecordGeneralFechaFinal.Text = ""
        Me.txtRecordGeneralPapeleta.Text = ""
        Me.txtRecordGeneralCodigoUnidad.Text = ""
        Me.txtRecordGeneralCantidad.Text = ""
    End Sub

    Private Sub Estado_Controles_RecordGral(ByVal lbool_Estado As Boolean)
        Me.cboRecordGeneralTipoRecord.Enabled = lbool_Estado
         
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Me.cboRecordGeneralTipoRecord.Enabled = Not lbool_Estado
        End If
        Me.txtRecordGeneralObservaciones.Enabled = lbool_Estado
        Me.dtpRecordGeneralFechaRegistro.Enabled = lbool_Estado
        Me.dtpRecordGeneralFechaInicio.Enabled = lbool_Estado
        Me.dtpRecordGeneralFechaFinal.Enabled = lbool_Estado
        Me.txtRecordGeneralPapeleta.Enabled = lbool_Estado
        Me.txtRecordGeneralCodigoUnidad.Enabled = lbool_Estado
        Me.txtRecordGeneralCantidad.Enabled = lbool_Estado
    End Sub

    Private Sub gwdRecordGeneral_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdRecordGeneral.CellBeginEdit
        If Me.gwdRecordGeneral.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
        gwdRecordGeneral.Rows(e.RowIndex).Tag = "M"
    End Sub

    Private Sub gwdRecordGeneral_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecordGeneral.CellClick, gwdRecordGeneral.CellEnter
        Try
            If Me.gwdRecordGeneral.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub

            gwdRecordGeneral.CommitEdit(DataGridViewDataErrorContexts.Commit)

          

          

            Dim obj As Object = gwdRecordGeneral.Item("FECINI", gwdRecordGeneral.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                Try
                    obj = CType(obj, Date)
                Catch ex As InvalidCastException
                    obj = Now
                End Try
                gwdRecordGeneral.Item("OLD_PNFECINI_EVAL", gwdRecordGeneral.CurrentCellAddress.Y).Value = HelpClass.CDate_a_Numero8Digitos(obj)
            End If
            obj = gwdRecordGeneral.Item("TTPRCD", gwdRecordGeneral.CurrentCellAddress.Y).Value
            If celdaTieneData(obj) Then
                _prevRecord = obj.ToString
                gwdRecordGeneral.Item("NEW_TTPRCD", gwdRecordGeneral.CurrentCellAddress.Y).Value = obj.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdRecordGeneral_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecordGeneral.CellDoubleClick
        Try
            If Me.gwdRecordGeneral.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.gwdRecordGeneral.Columns(e.ColumnIndex).Name = "IMAGE" And (Me.gwdRecordGeneral.Item("STPRCD", e.RowIndex).Value = "P" OrElse Me.gwdRecordGeneral.Item("STPRCD", e.RowIndex).Value = "D") Then
                Dim objCrep As New rptFormatoPermisoConductor 'nuevas modificaciones
                Dim objPrintForm As New PrintForm
                Dim strConductor As String = Me.txtApellidoPaterno.Text.Trim & " " & Me.txtApellidoMaterno.Text.Trim & " , " & Me.txtNombres.Text.Trim
                HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
                HelpClass.CrystalReportTextObject(objCrep, "lblFechaRegistro", Me.gwdRecordGeneral.Item("FRGTRO", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblSolicitud", Obtener_Descripcion_Tipo_Record(Me.gwdRecordGeneral.Item("TTPRCD", e.RowIndex).Value))
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor", strConductor)
                HelpClass.CrystalReportTextObject(objCrep, "lblDNI", Me.txtDni.Text.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblMotivo", Me.gwdRecordGeneral.Item("TOBSMD", e.RowIndex).Value.ToString.Trim.ToUpper)
                HelpClass.CrystalReportTextObject(objCrep, "lblDias", Me.gwdRecordGeneral.Item("QCNESP", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecInicio", Me.gwdRecordGeneral.Item("FECINI", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecFin", Me.gwdRecordGeneral.Item("FECTER", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_1", strConductor)

                HelpClass.CrystalReportTextObject(objCrep, "lblCompania_1", Me.cmbCompania.Text)
                HelpClass.CrystalReportTextObject(objCrep, "lblFechaRegistro_1", Me.gwdRecordGeneral.Item("FRGTRO", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblSolicitud_1", Obtener_Descripcion_Tipo_Record(Me.gwdRecordGeneral.Item("TTPRCD", e.RowIndex).Value))
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_2", strConductor)
                HelpClass.CrystalReportTextObject(objCrep, "lblDNI_1", Me.txtDni.Text.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblMotivo_1", Me.gwdRecordGeneral.Item("TOBSMD", e.RowIndex).Value.ToString.Trim.ToUpper)
                HelpClass.CrystalReportTextObject(objCrep, "lblDias_1", Me.gwdRecordGeneral.Item("QCNESP", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecInicio_1", Me.gwdRecordGeneral.Item("FECINI", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecFin_1", Me.gwdRecordGeneral.Item("FECTER", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_3", strConductor)

                objPrintForm.ShowForm(objCrep, Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Obtener_Descripcion_Tipo_Record(ByVal strCodigo As String) As String
        Dim strResult As String = CType(TTPRCD.DataSource, DataTable).Select("STPRCD = '" + strCodigo + "'")(0)("TTPRCD").ToString.Trim
        Return strResult
    End Function

#End Region

#Region "CONDUCTOR - VACACIONES"

    Private Sub ListarVacaciones()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim obj As New VacacionesConductor_BLL
        Dim objEntidad As New VacacionesConductor
        Dim dtVacacionesCondutor As New DataTable
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value


        dtVacacionesCondutor = obj.Listar_Vacaciones_Conductor(objEntidad)
        For Each Item As DataRow In dtVacacionesCondutor.Rows

            If Item("FECINI").ToString.Trim.Equals("0") Then
                Item("FECINI") = ""
            End If
            If Item("FECFIN").ToString.Trim.Equals("0") Then
                Item("FECFIN") = ""
            End If

        Next
        
        Me.gwdVacaciones.Rows.Clear()

        Dim dgrow As DataGridViewRow
        Dim FecIni As String = ""
        Dim FecFin As String = ""
        For i As Integer = 0 To dtVacacionesCondutor.Rows.Count - 1
            dgrow = New DataGridViewRow
            dgrow.CreateCells(gwdVacaciones)
            dgrow.Cells(0).Value = dtVacacionesCondutor.Rows(i).Item("CCMPN").ToString.Trim
            dgrow.Cells(1).Value = dtVacacionesCondutor.Rows(i).Item("CBRCNT").ToString.Trim
            dgrow.Cells(2).Value = dtVacacionesCondutor.Rows(i).Item("NCRRLT")
            dgrow.Cells(3).Value = dtVacacionesCondutor.Rows(i).Item("ANOINI")
            dgrow.Cells(4).Value = dtVacacionesCondutor.Rows(i).Item("ANOFIN")
            dgrow.Cells(5).Value = dtVacacionesCondutor.Rows(i).Item("QCNESP")
            dgrow.Cells(6).Value = "DIA"

            FecIni = dtVacacionesCondutor.Rows(i).Item("FECINI").ToString.Trim
            dgrow.Cells(7).Value = FecIni
            If FecIni.Equals("00/00/0000") Then
                dgrow.Cells(7).Value = Now
            End If
            FecFin = dtVacacionesCondutor.Rows(i).Item("FECFIN").ToString.Trim
            dgrow.Cells(8).Value = FecFin
            If FecFin.Equals("00/00/0000") Then
                dgrow.Cells(8).Value = Now
            End If
            dgrow.Cells(9).Value = dtVacacionesCondutor.Rows(i).Item("TOBS").ToString.Trim
            dgrow.Cells(10).Value = dtVacacionesCondutor.Rows(i).Item("FRGTRO").ToString.Trim
            dgrow.Cells(11).Value = My.Resources.printer2
            dgrow.Cells(6).Tag = "ReadOnly"
            dgrow.ReadOnly = True
            gwdVacaciones.Rows.Add(dgrow)
        Next

        

    End Sub

    Private Sub gwdVacaciones_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdVacaciones.CellBeginEdit
        If Me.gwdVacaciones.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
        gwdVacaciones.Rows(e.RowIndex).Tag = "M"
    End Sub

   
    
    Private Sub gwdVacaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdVacaciones.CellDoubleClick
        Try
            If Me.gwdVacaciones.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.gwdVacaciones.Columns(e.ColumnIndex).Name = "IMAGE_V" And (Not Me.gwdVacaciones.Item("FRGTRO_V", e.RowIndex).Value Is Nothing) Then
                Dim objCrep As New rptFormatoVacacionesConductor 'nuevas modificaciones
                Dim objPrintForm As New PrintForm
                Dim strConductor As String = Me.txtApellidoPaterno.Text.Trim & " " & Me.txtApellidoMaterno.Text.Trim & " , " & Me.txtNombres.Text.Trim
                HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
                HelpClass.CrystalReportTextObject(objCrep, "lblFechaRegistro", Me.gwdVacaciones.Item("FRGTRO_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblSolicitud", "VACACIONES")
                HelpClass.CrystalReportTextObject(objCrep, "lblPeriodo", Me.gwdVacaciones.Item("ANOINI", e.RowIndex).Value.ToString.Trim & " - " & Me.gwdVacaciones.Item("ANOFIN", e.RowIndex).Value.ToString.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor", strConductor)
                HelpClass.CrystalReportTextObject(objCrep, "lblDNI", Me.txtDni.Text.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblMotivo", Me.gwdVacaciones.Item("TOBS_V", e.RowIndex).Value.ToString.Trim.ToUpper)
                HelpClass.CrystalReportTextObject(objCrep, "lblDias", Me.gwdVacaciones.Item("QCNESP_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecInicio", Me.gwdVacaciones.Item("FECINI_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecFin", Me.gwdVacaciones.Item("FECFIN_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_1", strConductor)

                HelpClass.CrystalReportTextObject(objCrep, "lblCompania_1", Me.cmbCompania.Text)
                HelpClass.CrystalReportTextObject(objCrep, "lblFechaRegistro_1", Me.gwdVacaciones.Item("FRGTRO_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblSolicitud_1", "VACACIONES")
                HelpClass.CrystalReportTextObject(objCrep, "lblPeriodo_1", Me.gwdVacaciones.Item("ANOINI", e.RowIndex).Value.ToString.Trim & " - " & Me.gwdVacaciones.Item("ANOFIN", e.RowIndex).Value.ToString.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_2", strConductor)
                HelpClass.CrystalReportTextObject(objCrep, "lblDNI_1", Me.txtDni.Text.Trim)
                HelpClass.CrystalReportTextObject(objCrep, "lblMotivo_1", Me.gwdVacaciones.Item("TOBS_V", e.RowIndex).Value.ToString.Trim.ToUpper)
                HelpClass.CrystalReportTextObject(objCrep, "lblDias_1", Me.gwdVacaciones.Item("QCNESP_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecInicio_1", Me.gwdVacaciones.Item("FECINI_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblFecFin_1", Me.gwdVacaciones.Item("FECFIN_V", e.RowIndex).Value)
                HelpClass.CrystalReportTextObject(objCrep, "lblConductor_3", strConductor)

                objPrintForm.ShowForm(objCrep, Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

     

    

    Private Sub GetHorMinSeg()
        Dim fecAct As DateTime = DateTime.Now
    End Sub

    Private Sub txtDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

   
    

     

    Private Sub txtRecordGeneralPapeleta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecordGeneralPapeleta.KeyPress, txtRecordGeneralCantidad.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

    

    Private Sub gwdPase_TipoPase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdPase_TipoPase.CellEndEdit

        Try
            If gwdPase_TipoPase.RowCount < 0 Then Exit Sub


            Dim strNomCol As String = gwdPase_TipoPase.Columns(gwdPase_TipoPase.CurrentCellAddress.X).Name

            If strNomCol.Equals("CodPase") OrElse strNomCol.Equals("Fecha_Inicio") Then
                Dim valorCodPase As Object = gwdPase_TipoPase.Item("CodPase", gwdPase_TipoPase.CurrentCellAddress.Y).Value
                Dim valorFecIni As Object = gwdPase_TipoPase.Item("Fecha_Inicio", gwdPase_TipoPase.CurrentCellAddress.Y).Value

                If celdaTieneData(valorCodPase) AndAlso celdaTieneData(valorFecIni) Then
                    Dim valorCodPaseTmp, valorFecIniTmp As Object
                    For i As Integer = 0 To gwdPase_TipoPase.Rows.Count - 1
                        If i <> gwdPase_TipoPase.CurrentCellAddress.Y Then
                            valorCodPaseTmp = gwdPase_TipoPase.Rows(i).Cells("CodPase").Value
                            valorFecIniTmp = gwdPase_TipoPase.Rows(i).Cells("Fecha_Inicio").Value
                            If celdaTieneData(valorCodPaseTmp) AndAlso celdaTieneData(valorFecIniTmp) Then
                                'Try
                                valorFecIniTmp = CType(valorFecIniTmp, Date)
                              
                                If valorCodPaseTmp.Equals(valorCodPase) AndAlso valorFecIniTmp.Equals(valorFecIni) Then
                                    MsgBox("No se puede repetir el pase en la misma fecha de inicio.", MsgBoxStyle.Exclamation)
                                    If strNomCol.Equals("CodPase") Then
                                        gwdPase_TipoPase.Item("CodPase", gwdPase_TipoPase.CurrentCellAddress.Y).Value = Nothing
                                    Else
                                        gwdPase_TipoPase.Item("Fecha_Inicio", gwdPase_TipoPase.CurrentCellAddress.Y).Value = Nothing
                                    End If
                                    Exit Sub
                                Else
                                    gwdPase_TipoPase.Item("NEW_NCOPSE", gwdPase_TipoPase.CurrentCellAddress.Y).Value = valorCodPase
                                    gwdPase_TipoPase.Item("OLD_PNFECINI", gwdPase_TipoPase.CurrentCellAddress.Y).Value = valorFecIni
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            gwdPase_TipoPase.Rows(e.RowIndex).Tag = "M"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    

    Private Sub gwdRecordMedico_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecordMedico.CellEndEdit
        Try
            If gwdRecordMedico.RowCount < 0 Then Exit Sub


            Dim strNomCol As String = gwdRecordMedico.Columns(gwdRecordMedico.CurrentCellAddress.X).Name

            If strNomCol.Equals("NCOVAC") OrElse strNomCol.Equals("Fecha_Inicio_Vacuna") Then
                Dim valorVacuna As Object = gwdRecordMedico.Item("NCOVAC", gwdRecordMedico.CurrentCellAddress.Y).Value
                Dim valorFecIni As Object = gwdRecordMedico.Item("Fecha_Inicio_Vacuna", gwdRecordMedico.CurrentCellAddress.Y).Value

                If celdaTieneData(valorVacuna) AndAlso celdaTieneData(valorFecIni) Then
                    Dim valorVacTmp, valorFecIniTmp As Object
                    For i As Integer = 0 To gwdRecordMedico.Rows.Count - 1
                        If i <> gwdRecordMedico.CurrentCellAddress.Y Then
                            valorVacTmp = gwdRecordMedico.Rows(i).Cells("NCOVAC").Value
                            valorFecIniTmp = gwdRecordMedico.Rows(i).Cells("Fecha_Inicio_Vacuna").Value
                            If celdaTieneData(valorVacTmp) AndAlso celdaTieneData(valorFecIniTmp) Then

                                valorFecIniTmp = CType(valorFecIniTmp, Date)
                                
                                If valorVacTmp.Equals(valorVacuna) AndAlso valorFecIniTmp.Equals(valorFecIni) Then
                                    MsgBox("No se puede repetir la vacuna en la misma fecha de inicio.", MsgBoxStyle.Exclamation)
                                    If strNomCol.Equals("NCOVAC") Then
                                        gwdRecordMedico.Item("NCOVAC", gwdRecordMedico.CurrentCellAddress.Y).Value = Nothing
                                    Else
                                        gwdRecordMedico.Item("Fecha_Inicio_Vacuna", gwdRecordMedico.CurrentCellAddress.Y).Value = Nothing
                                    End If
                                    Exit Sub
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            gwdRecordMedico.Rows(e.RowIndex).Tag = "M"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name

           
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Me.gwdDatos.Rows.Count > 0 And gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then ' txtCodigoBrevete.Text <> "" Then

                Dim f As New frmOpRptConductor(gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim)
                f.rutaImagen = _rutaImagen
                f.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                f.ShowForm(Me)
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        uploadImagenConductor()
    End Sub

    Private Sub uploadImagenConductor()

        If gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then
            Dim objformLoad As New frmUploadImagen

            objformLoad.ShowForm("conductor", gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim, Me)
        End If
    End Sub

    
    Private Sub chkTercero_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTercero.CheckedChanged
        rbtnTercero.Checked = chkTercero.Checked
        rbtnPropio.Checked = Not rbtnTercero.Checked
    End Sub

    Private Function celdaTieneData(ByVal obj As Object) As Boolean
        Return Not (obj Is DBNull.Value OrElse obj Is Nothing)
    End Function

    Private Sub gwdCapacitacionDatosCapt_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdCapacitacionDatosCapt.CellEndEdit

        Try
            If gwdCapacitacionDatosCapt.RowCount < 0 Then Exit Sub
            'btnGuardar.Enabled = True

            Dim strNomCol As String = gwdCapacitacionDatosCapt.Columns(gwdCapacitacionDatosCapt.CurrentCellAddress.X).Name

            If strNomCol.Equals("Cod_Capacitacion") OrElse strNomCol.Equals("FECINI_CAPACITACION") Then
                Dim valorCapac As Object = gwdCapacitacionDatosCapt.Item("Cod_Capacitacion", gwdCapacitacionDatosCapt.CurrentCellAddress.Y).Value
                Dim valorFecIni As Object = gwdCapacitacionDatosCapt.Item("FECINI_CAPACITACION", gwdCapacitacionDatosCapt.CurrentCellAddress.Y).Value

                If celdaTieneData(valorCapac) AndAlso celdaTieneData(valorFecIni) Then
                    Dim valorCapacTmp, valorFecIniTmp As Object
                    For i As Integer = 0 To gwdCapacitacionDatosCapt.Rows.Count - 1
                        If i <> gwdCapacitacionDatosCapt.CurrentCellAddress.Y Then
                            valorCapacTmp = gwdCapacitacionDatosCapt.Rows(i).Cells("Cod_capacitacion").Value
                            valorFecIniTmp = gwdCapacitacionDatosCapt.Rows(i).Cells("FECINI_CAPACITACION").Value
                            If celdaTieneData(valorCapacTmp) AndAlso celdaTieneData(valorFecIniTmp) Then
                                valorFecIniTmp = CType(valorFecIniTmp, Date)
                                If valorCapacTmp.Equals(valorCapac) AndAlso valorFecIniTmp.Equals(valorFecIni) Then
                                    MsgBox("No se puede repetir la capacitación en la misma fecha de inicio.", MsgBoxStyle.Exclamation)
                                    gwdCapacitacionDatosCapt.Item(gwdCapacitacionDatosCapt.CurrentCellAddress.X, gwdCapacitacionDatosCapt.CurrentCellAddress.Y).Value = Nothing
                                    Exit Sub
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            gwdCapacitacionDatosCapt.Rows(e.RowIndex).Tag = "M"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub pGuardarRegistroChoferCapac(ByVal rowIdx As Integer)
        Dim objLogica As New CapacitacionConductor_BLL
        Dim objEntidad As New CapacitacionConductor

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() ' _vBrevete

        Dim valor As Object = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(1).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.NCOCPT = -1
        Else
            objEntidad.NCOCPT = valor
        End If

        valor = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(2).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.FECREG = HelpClass.TodayNumeric
        Else
            objEntidad.FECREG = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(5).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.FECINI = ""
        Else
            objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(6).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.FECFIN = ""
        Else
            objEntidad.FECFIN = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(7).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.TOBS = ""
        Else
            objEntidad.TOBS = valor
        End If
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        'validaciones
        Dim lboolError As Boolean = False
        If objEntidad.NCOCPT <= 0 OrElse _
            objEntidad.FECINI = "" OrElse _
            objEntidad.FECFIN = "" OrElse _
            objEntidad.FECFIN < objEntidad.FECINI Then
            lboolError = True
        End If

        If Not lboolError Then
            objEntidad = objLogica.Registrar_CapacitacionConductor(objEntidad)
            
            gwdCapacitacionDatosCapt.Rows(rowIdx).Tag = ""
            gwdCapacitacionDatosCapt.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White
            
        Else
            gwdCapacitacionDatosCapt.Rows(rowIdx).DefaultCellStyle.BackColor = Color.Yellow

        End If
    End Sub

    Private Sub pGuardarRegistroChoferPase(ByVal rowIdx As Integer)
        Dim objLogica As New PaseConductor_BLL
        Dim objEntidad As New PaseConductor

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        Dim valor As Object = gwdPase_TipoPase.Rows(rowIdx).Cells(1).Value
        If Not celdaTieneData(valor) Then
            objEntidad.NCOPSE = -1
        Else
            objEntidad.NCOPSE = valor
        End If

        objEntidad.FECREG = HelpClass.TodayNumeric

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells(5).Value
        If Not celdaTieneData(valor) Then
            objEntidad.TOBS = ""
        Else
            objEntidad.TOBS = valor
        End If

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells(3).Value
        If Not celdaTieneData(valor) Then
            objEntidad.FECINI = ""
        Else
            objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells(4).Value
        If Not celdaTieneData(valor) Then
            objEntidad.FECFIN = ""
        Else
            objEntidad.FECFIN = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells("NEW_NCOPSE").Value
        If Not celdaTieneData(valor) Then
            objEntidad.NEW_NCOPSE = 0
        Else
            objEntidad.NEW_NCOPSE = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells("OLD_PNFECINI").Value
        If Not celdaTieneData(valor) Then
            objEntidad.OLD_PNFECINI = 0
        Else
            objEntidad.OLD_PNFECINI = valor
        End If

        'validaciones
        Dim lboolError As Boolean = False
        If objEntidad.NCOPSE <= 0 OrElse _
            objEntidad.FECINI = "" OrElse _
            objEntidad.FECFIN = "" OrElse _
            objEntidad.FECFIN < objEntidad.FECINI Then
            lboolError = True
        End If

        If Not lboolError Then
            objEntidad = objLogica.Registra_Pases(objEntidad)
            
            gwdPase_TipoPase.Rows(rowIdx).Tag = ""
            gwdPase_TipoPase.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White

        Else
            gwdPase_TipoPase.Rows(rowIdx).DefaultCellStyle.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub pGuardarRegistroChoferVacuna(ByVal rowIdx As Integer)

        Dim objLogica As New RecordMedico_BLL
        Dim objEntidad As New RecordMedico

        objEntidad.NCORMD = 0
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        Dim valor As Object = gwdRecordMedico.Rows(rowIdx).Cells(2).Value
        If Not celdaTieneData(valor) Then
            objEntidad.FECREG = HelpClass.TodayNumeric
        Else
            objEntidad.FECREG = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdRecordMedico.Rows(rowIdx).Cells(3).Value
        If Not celdaTieneData(valor) Then
            objEntidad.FECINI = ""
        Else
            objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdRecordMedico.Rows(rowIdx).Cells(4).Value
        If Not celdaTieneData(valor) Then
            objEntidad.FECFIN = ""
        Else
            objEntidad.FECFIN = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        valor = gwdRecordMedico.Rows(rowIdx).Cells(5).Value
        If Not celdaTieneData(valor) Then
            objEntidad.TOBS = ""
        Else
            objEntidad.TOBS = valor
        End If

        valor = gwdRecordMedico.Rows(rowIdx).Cells(1).Value
        If Not celdaTieneData(valor) Then
            objEntidad.NCOVAC = -1
        Else
            objEntidad.NCOVAC = valor
        End If

        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        valor = gwdRecordMedico.Rows(rowIdx).Cells(7).Value
        If Not celdaTieneData(valor) Then
            objEntidad.NEW_NCOVAC = 0
        Else
            objEntidad.NEW_NCOVAC = valor
        End If

        valor = gwdRecordMedico.Rows(rowIdx).Cells(8).Value
        If Not celdaTieneData(valor) Then
            objEntidad.OLD_PNFECINI = 0
        Else
            objEntidad.OLD_PNFECINI = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric

        'validaciones
        Dim lboolError As Boolean = False
        If objEntidad.NCOVAC <= 0 OrElse _
            objEntidad.FECINI = "" OrElse _
            objEntidad.FECFIN = "" OrElse _
            objEntidad.FECFIN < objEntidad.FECINI Then
            lboolError = True
        End If

        If Not lboolError Then

            objEntidad = objLogica.Registrar_Record_Medico(objEntidad)
            gwdRecordMedico.Rows(rowIdx).Tag = ""
            gwdRecordMedico.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White
            
        Else
            gwdRecordMedico.Rows(rowIdx).DefaultCellStyle.BackColor = Color.Yellow
        End If
       

    End Sub

    Private Function Validar_Datos(ByVal rowIdx As Integer) As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = True
        Dim valor As Object = gwdVacaciones.Rows(rowIdx).Cells("ANOINI").Value
        If Not celdaTieneData(valor) OrElse Not IsNumeric(valor) Then
            lstr_validacion += "* AÑO INICIAL DEL PERIODO DE VACACIONES " & Chr(13)
        End If
        valor = gwdVacaciones.Rows(rowIdx).Cells("ANOFIN").Value
        If Not celdaTieneData(valor) OrElse Not IsNumeric(valor) Then
            lstr_validacion += "* AÑO FINAL DEL PERIODO DE VACACIONES " & Chr(13)
        End If
        valor = gwdVacaciones.Rows(rowIdx).Cells("FECINI_V").Value
        If Not celdaTieneData(valor) Then
            lstr_validacion += "* FECHA DE INICIO DE VACACIONES " & Chr(13)
        End If
        valor = gwdVacaciones.Rows(rowIdx).Cells("FECFIN_V").Value
        If Not celdaTieneData(valor) Then
            lstr_validacion += "* FECHA DE FIN DE VACACIONES " & Chr(13)
        End If
        valor = gwdVacaciones.Rows(rowIdx).Cells("QCNESP_V").Value
        If Not celdaTieneData(valor) OrElse Not IsNumeric(valor) OrElse valor < 0 Then
            lstr_validacion += "* N° DE DIAS " & Chr(13)
        End If
        Dim objIni As Object = gwdVacaciones.Rows(rowIdx).Cells("FECINI_V").Value
        Dim objFin As Object = gwdVacaciones.Rows(rowIdx).Cells("FECFIN_V").Value
        If celdaTieneData(objIni) And celdaTieneData(objFin) Then
            If HelpClass.CtypeDate(objIni) > HelpClass.CtypeDate(objFin) Then
                lstr_validacion += "* FECHA INICIO VACACIONES MAYOR A FECHA FIN VACACIONES" & Chr(13)
            End If
        End If
        valor = gwdVacaciones.Rows(rowIdx).Cells("TOBS_V").Value
        If Not celdaTieneData(valor) Then
            gwdVacaciones.Rows(rowIdx).Cells("TOBS_V").Value = ""
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = False

        End If

        Return lbool_existe_error
    End Function

    Private Sub pGuardarRegistroChoferVacaciones(ByVal rowIdx As Integer)
        Dim objLogica As New VacacionesConductor_BLL
        Dim objEntidad As New VacacionesConductor
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.ANOINI = gwdVacaciones.Rows(rowIdx).Cells("ANOINI").Value
        objEntidad.ANOFIN = gwdVacaciones.Rows(rowIdx).Cells("ANOFIN").Value
        objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(gwdVacaciones.Rows(rowIdx).Cells("FECINI_V").Value)
        objEntidad.FECFIN = HelpClass.CFecha_a_Numero8Digitos(gwdVacaciones.Rows(rowIdx).Cells("FECFIN_V").Value)
        objEntidad.TOBS = gwdVacaciones.Rows(rowIdx).Cells("TOBS_V").Value.ToString.Trim
        objEntidad.QCNESP = gwdVacaciones.Rows(rowIdx).Cells("QCNESP_V").Value
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            objEntidad.SESTRG = "A"
            objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.FCHCRT = HelpClass.TodayNumeric
            objEntidad.HRACRT = HelpClass.NowNumeric
            objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad = objLogica.Registrar_Vacaciones_Conductor(objEntidad)
        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.NCRRLT = gwdVacaciones.Rows(rowIdx).Cells("NCRRLT_V").Value
            objEntidad = objLogica.Modificar_Vacaciones_Conductor(objEntidad)
        End If
        Select Case objEntidad.QCNESP
            Case -1
                HelpClass.MsgBox("Excede días de Vacaciones según lo establecido", MessageBoxIcon.Information)
                gwdVacaciones.Rows(rowIdx).Tag = ""
                gwdVacaciones.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White
                
            Case Else
                gwdVacaciones.Rows(rowIdx).Tag = ""
                gwdVacaciones.Rows(rowIdx).DefaultCellStyle.BackColor = Color.White
        End Select

    End Sub

    Private Sub pEliminarRegistroChoferVacaciones(ByVal rowIdx As Integer)
        If gwdVacaciones.RowCount <= 0 OrElse gwdVacaciones.CurrentCellAddress.Y < 0 Then Exit Sub

        If MessageBox.Show("Está seguro de eliminar el registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim objLogica As New VacacionesConductor_BLL
        Dim objEntidad As New VacacionesConductor
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.NCRRLT = gwdVacaciones.Rows(rowIdx).Cells("NCRRLT_V").Value
        objEntidad.SESTRG = "*"
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        gwdVacaciones.Rows.RemoveAt(gwdVacaciones.CurrentCellAddress.Y)

        objEntidad = objLogica.Eliminar_Vacaciones_Conductor(objEntidad)
        ListarVacaciones()
       
    End Sub

    Private Sub pEliminarRegistroChoferCapac(ByVal rowIdx As Integer)
        If gwdCapacitacionDatosCapt.RowCount <= 0 Then Exit Sub

        If MessageBox.Show("Está seguro de eliminar el registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim objLogica As New CapacitacionConductor_BLL
        Dim objEntidad As New CapacitacionConductor

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        Dim valor As Object = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(1).Value
        If Not celdaTieneData(valor) Then
            objEntidad.NCOCPT = -1
        Else
            objEntidad.NCOCPT = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        valor = gwdCapacitacionDatosCapt.Rows(rowIdx).Cells(5).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.FECINI = -1
        Else
            objEntidad.FECINI = HelpClass.CFecha_a_Numero8Digitos(valor)
        End If

        objEntidad = objLogica.Eliminar_CapacitacionConductor(objEntidad)
        Listar_Capacitacion()

        

    End Sub

    Private Sub pEliminarRegistroChoferPase(ByVal rowIdx As Integer)
        If gwdPase_TipoPase.RowCount <= 0 Then Exit Sub

        If MessageBox.Show("Está seguro de eliminar el registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim objLogica As New PaseConductor_BLL
        Dim objEntidad As New PaseConductor

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        Dim valor As Object = gwdPase_TipoPase.Rows(rowIdx).Cells(1).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.NCOPSE = -1
        Else
            objEntidad.NCOPSE = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells(6).Value 'FCHCRT
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.FCHCRT = -1
        Else
            objEntidad.FCHCRT = valor
        End If

        valor = gwdPase_TipoPase.Rows(rowIdx).Cells(7).Value 'HRACRT
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.HRACRT = -1
        Else
            objEntidad.HRACRT = valor
        End If

        gwdPase_TipoPase.Rows.RemoveAt(gwdPase_TipoPase.CurrentCellAddress.Y)

        'validaciones 
        Dim lbool_error As Boolean = False
        If objEntidad.FCHCRT = -1 OrElse _
            objEntidad.NCOPSE = -1 OrElse _
            objEntidad.HRACRT = -1 Then
            lbool_error = True
        End If

        'borra de la BD
        If Not lbool_error Then
            objEntidad = objLogica.Elimina_Pases(objEntidad)
            Listar_Pase()
           
        End If

    End Sub

    Private Sub pEliminarRegistroChoferVacuna(ByVal rowIdx As Integer)
        If gwdRecordMedico.RowCount <= 0 Then Exit Sub

        If MessageBox.Show("Está seguro de eliminar el registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim objLogica As New RecordMedico_BLL
        Dim objEntidad As New RecordMedico

        Dim valor As Object = gwdRecordMedico.Rows(rowIdx).Cells(6).Value
        If Not celdaTieneData(valor) Then
            objEntidad.NCORMD = -1
        Else
            objEntidad.NCORMD = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        gwdRecordMedico.Rows.RemoveAt(gwdRecordMedico.CurrentCellAddress.Y)

        'validaciones 
        Dim lbool_error As Boolean = False
        If objEntidad.NCORMD = -1 Then
            lbool_error = True
        End If

        'borra de la BD
        If Not lbool_error Then
            objEntidad = objLogica.Eliminar_Record_Medico(objEntidad)
            ListarRecordMedico()
           
        End If

    End Sub

    Private Sub pEliminarRegistroChoferEval(ByVal rowIdx As Integer)
        If gwdRecordGeneral.RowCount <= 0 Then Exit Sub

        If MessageBox.Show("Está seguro de eliminar el registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim objLogica As New RecordGeneral_BLL
        Dim objEntidad As New RecordGeneral

        objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete

        Dim valor As Object = gwdRecordGeneral.Rows(rowIdx).Cells(0).Value
        If valor Is DBNull.Value OrElse valor Is Nothing Then
            objEntidad.NCRRLT = -1
        Else
            objEntidad.NCRRLT = valor
        End If

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        gwdRecordGeneral.Rows.RemoveAt(gwdRecordGeneral.CurrentCellAddress.Y)

        'validaciones 
        Dim lbool_error As Boolean = False
        If objEntidad.NCRRLT = -1 Then
            lbool_error = True
        End If


        If Not lbool_error Then
            objEntidad = objLogica.Eliminar_Record_General(objEntidad)
            ListarRecordGeneral()
           
        End If
    End Sub

    Private Sub cargarComboCapacitacionGWD()
        Dim objCapacitacion As New TipoCapacitacionConductor_BLL
        Dim objEntidad As New TipoCapacitacionConductor
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        Cod_Capacitacion.DataSource = HelpClass.GetDataSetNative(objCapacitacion.Listar_TipoCapacitacionConductor(objEntidad))
        Cod_Capacitacion.DisplayMember = "NOMCPT"
        Cod_Capacitacion.ValueMember = "NCOCPT"
    End Sub

    Private Sub cargarComboPaseGWD()
        Dim objLogica As New TipoPaseConductor_BLL
        Dim objEntidad As New TipoPaseConductor
        objEntidad.NOMPSE = ""
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        CodPase.DataSource = HelpClass.GetDataSetNative(objLogica.Lista_Tipo_Pases(objEntidad))
        CodPase.DisplayMember = "NOMPSE"
        CodPase.ValueMember = "NCOPSE"
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
         

            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & intCantRuta.ToString))
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & intCantPasajero.ToString))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado Conductores"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Conductores"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE LISTA CONDUCTORES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

            'For Each dr As DataRow In objDt.Rows
            '    dr("NORCML") = dr("NORCML").ToString.Replace(",", "," + Chr(10)).ToString
            '    dr.AcceptChanges()
            'Next
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

           
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cargarComboVacunaGWD()
        Dim obj As New Vacunas_BLL
        Dim objEntidad As New Vacunas
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        NCOVAC.DataSource = HelpClass.GetDataSetNative(obj.Listar_Vacunas(objEntidad))
        NCOVAC.DisplayMember = "NOMVAC"
        NCOVAC.ValueMember = "NCOVAC"
    End Sub

    Private Sub gwdRecordGeneral_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecordGeneral.CellEndEdit
        Try
            If gwdRecordGeneral.RowCount < 0 Then Exit Sub
            'btnGuardar.Enabled = True

            Dim strNomCol As String = gwdRecordGeneral.Columns(gwdRecordGeneral.CurrentCellAddress.X).Name

            If strNomCol.Equals("TTPRCD") OrElse strNomCol.Equals("FECINI") Then
                Dim valorCodTipoRec As Object = gwdRecordGeneral.Item("TTPRCD", gwdRecordGeneral.CurrentCellAddress.Y).Value
                Dim valorFecIni As Object = gwdRecordGeneral.Item("FECINI", gwdRecordGeneral.CurrentCellAddress.Y).Value

                If celdaTieneData(valorCodTipoRec) AndAlso celdaTieneData(valorFecIni) Then
                    Dim valorCodTipoRecTmp, valorFecIniTmp As Object
                    For i As Integer = 0 To gwdRecordGeneral.Rows.Count - 1
                        If i <> gwdRecordGeneral.CurrentCellAddress.Y Then
                            valorCodTipoRecTmp = gwdRecordGeneral.Rows(i).Cells("TTPRCD").Value
                            valorFecIniTmp = gwdRecordGeneral.Rows(i).Cells("FECINI").Value
                            If celdaTieneData(valorCodTipoRecTmp) AndAlso celdaTieneData(valorFecIniTmp) Then
                                Try
                                    valorFecIniTmp = CType(valorFecIniTmp, Date)
                                Catch ex As InvalidCastException
                                    valorFecIniTmp = CType(Now, Date)
                                    gwdRecordGeneral.Rows(i).Cells("FECINI").Value = valorFecIniTmp
                                End Try
                                If valorCodTipoRecTmp.Equals(valorCodTipoRec) AndAlso valorFecIniTmp.Equals(valorFecIni) Then
                                    MsgBox("No se puede repetir el tipo de record en la misma fecha de inicio.", MsgBoxStyle.Exclamation)
                                    If strNomCol.Equals("TTPRCD") Then
                                        gwdRecordGeneral.Item("TTPRCD", gwdRecordGeneral.CurrentCellAddress.Y).Value = _prevRecord
                                    Else
                                        gwdRecordGeneral.Item("FECINI", gwdRecordGeneral.CurrentCellAddress.Y).Value = Nothing
                                    End If
                                    Exit Sub
                                Else
                                    gwdRecordGeneral.Item("NEW_TTPRCD", gwdRecordGeneral.CurrentCellAddress.Y).Value = valorCodTipoRec
                                    gwdRecordGeneral.Item("OLD_PNFECINI_EVAL", gwdRecordGeneral.CurrentCellAddress.Y).Value = valorFecIni
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            gwdRecordGeneral.Rows(e.RowIndex).Tag = "M"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimirListadoChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListadoChoferes.Click
        If Me.gwdDatos.Rows.Count > 0 Then
            Dim objDs As New DataSet
            Dim objPrintForm = New PrintForm
            Dim objCrep As New rptListadoChoferes

            Dim objChofer As New Chofer
            Dim objLogica As New Chofer_BLL
            objChofer.SINDRC = IIf(rbtnPropio.Checked, "P", "T")
            objChofer.CCMPN = Me.cmbCompania.SelectedValue
            Try
                Dim dtChoferes As DataTable = objLogica.Listar_Chofer_Masivo_Reporte(objChofer)
                'HelpClass.GetDataSetNative(objLogica.Listar_Chofer_Masivo_Reporte(objChofer))
                If dtChoferes.Rows.Count > 0 Then
                    HelpClass.CrystalReportTextObject(objCrep, "lblFlag", IIf(rbtnPropio.Checked, "PROPIOS", "TERCEROS"))
                    HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
                    HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
                    objCrep.SetDataSource(AgregarDT(dtChoferes, "CHOFER").Copy())
                    objPrintForm.ShowForm(objCrep, Me)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
        dt.TableName = dtName
        Return dt
    End Function

    Private Sub btnDocAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocAdjunto.Click

        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim NomCarpetaConductor As String = ConfigurationManager.AppSettings("RUTA_CONDUCTOR").ToString()
            'NomCarpetaConductor = NomCarpetaConductor & txtCodigoBrevete.Text.Trim
            NomCarpetaConductor = NomCarpetaConductor & gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim

            'Dim strNomFile As String = txtCodigoBrevete.Text.Trim & "_" & HelpClass.TodayNumeric & HelpClass.NowNumeric
            Dim strNomFile As String = gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim & "_" & HelpClass.TodayNumeric & HelpClass.NowNumeric
            Dim objfrmSA As New frmSubirArchivo(NomCarpetaConductor, strNomFile)
            If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim objCargarImagen As New SolminWeb
                Dim extension As String = ""
                extension = objCargarImagen.getFileExtension(NomCarpetaConductor, strNomFile)
                If objCargarImagen.ExisteImagen(NomCarpetaConductor, strNomFile & extension) Then
                    Dim objEntidad As New DocAdjuntoConductor
                    'objEntidad.CBRCNT = txtCodigoBrevete.Text.Trim
                    objEntidad.CBRCNT = gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim
                    objEntidad.NCRRDC = "0"
                    objEntidad.CLINK = strNomFile & extension
                    If TabControl1.SelectedTab.Name = "TabPageDocs" Then
                        objEntidad.CTIIMG = "DOC"
                    ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
                        objEntidad.CTIIMG = "IMG"
                    End If
                    objEntidad.TOBS = objfrmSA.PSTOBS

                    objEntidad.CUSCRT = MainModule.USUARIO
                    objEntidad.FCHCRT = HelpClass.TodayNumeric
                    objEntidad.HRACRT = HelpClass.NowNumeric
                    objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

                    Dim objLogica As New DocAdjuntoConductor_BLL
                    objEntidad = objLogica.Registrar_Documento_Adjunto(objEntidad)
                    cargarDocLinks()
                    'If objEntidad.CBRCNT = "0" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'Else
                    '    cargarDocLinks()

                    'End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimirVencimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirVencimientos.Click
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Dim objChofer As New Chofer
                objChofer.SINDRC = IIf(rbtnPropio.Checked, "P", "T")
                objChofer.CCMPN = Me.cmbCompania.SelectedValue
                Dim f As New frmOpRptConductorVencimientos()
                f.Chofer = objChofer
                f.ShowForm(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

#Region "COMPAÑIA "

    Private Sub Cargar_Compania()
        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        objCompaniaBLL.Crea_Lista()
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
       

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

#End Region

    Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click

        Try
            Auditoria()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Auditoria()

        If gwdDatos.CurrentRow.Cells("CBRCNT").Value.ToString.Trim = "" Then Exit Sub


        Dim obj As New Chofer_BLL
        Dim objEntidad As New Chofer
        objEntidad.CBRCNT = txtCodigoBrevete.Text.Trim
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.SINDRC = IIf(rbtnPropio.Checked, "P", "T")
        objEntidad.ESTADO = Me.cmbEstado.SelectedValue
        Me.gwdDatos.AutoGenerateColumns = False

        Dim olbeChofer As New List(Of Chofer)
        olbeChofer = obj.Listar_Chofer(objEntidad)
        If olbeChofer.Count > 0 Then
            Dim objfrmAuditoria As New frmAuditoria
            objfrmAuditoria.USUARIO_CREACION = olbeChofer.Item(0).CUSCRT
            If olbeChofer.Item(0).FCHCRT = 0 Then
                objfrmAuditoria.FECHA_CREACION = ""
            Else
                objfrmAuditoria.FECHA_CREACION = HelpClass.CNumero_a_Fecha(olbeChofer.Item(0).FCHCRT)
            End If
            objfrmAuditoria.HORA_CREACION = IIf(olbeChofer.Item(0).HRACRT = 0, "", HelpClass.CNumero_a_Hora(olbeChofer.Item(0).HRACRT))
            objfrmAuditoria.TERMINAL_CREACION = olbeChofer.Item(0).NTRMCR
            objfrmAuditoria.USUARIO_ACTUALIZACION = olbeChofer.Item(0).CULUSA

            If olbeChofer.Item(0).FULTAC = 0 Then
                objfrmAuditoria.FECHA_ACTUALIZACION = ""
            Else
                objfrmAuditoria.FECHA_ACTUALIZACION = HelpClass.CNumero_a_Fecha(olbeChofer.Item(0).FULTAC)
            End If

            objfrmAuditoria.HORA_ACTUALIZACION = IIf(olbeChofer.Item(0).HULTAC = 0, "", HelpClass.CNumero_a_Hora(olbeChofer.Item(0).HULTAC))
            objfrmAuditoria.TERMINAL_ACTUALIZACION = olbeChofer.Item(0).NTRMNL
            objfrmAuditoria.ShowDialog()
        End If
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub Mostrar_Formulario_Para_Activar_ReactivarConductor(ByVal strSTPRCD As String)

        Dim oRecordGeneral As New RecordGeneral()
        Dim index As Int32 = Me.gwdDatos.CurrentCellAddress.Y
        oRecordGeneral = Obtener_EntidadConductorRecord(index, strSTPRCD)
        Dim ofrmActivacionConductor As New frmActivacionConductor()
        If Me.gwdDatos.RowCount = 0 Then Exit Sub

        ofrmActivacionConductor.ShowForm(oRecordGeneral, Me)
        Me.Realizar_Busqueda()

    End Sub

    Private Function Obtener_EntidadConductorRecord(ByVal rowIdx As Int32, ByVal strSTPRCD As String) As RecordGeneral

        Dim objEntidad As New RecordGeneral

        objEntidad.CBRCNT = gwdDatos.Rows(rowIdx).Cells("CBRCNT").Value
        If (strSTPRCD.ToUpper() = "A") Then
            objEntidad.ESTADOABR = "A"
        Else
            objEntidad.ESTADOABR = "I"
        End If
        objEntidad.BRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim() '_vBrevete
        objEntidad.TNMCMC = Me.gwdDatos.Item("TNMCMC", rowIdx).Value.ToString().Trim()
        objEntidad.TAPPAC = Me.gwdDatos.Item("TAPPAC", rowIdx).Value.ToString().Trim()
        objEntidad.TAPMAC = Me.gwdDatos.Item("TAPMAC", rowIdx).Value.ToString().Trim()
        objEntidad.STPRCD = strSTPRCD
        objEntidad.SESTRG = "A"
        objEntidad.FRGTRO = HelpClass.TodayNumeric
        objEntidad.HRGTRO = HelpClass.NowNumeric
        objEntidad.FECINI = HelpClass.TodayNumeric
        objEntidad.FECTER = HelpClass.TodayNumeric
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        
        Return objEntidad
    End Function

    Private Sub btnReactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReactivar.Click

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
           
            Me.Mostrar_Formulario_Para_Activar_ReactivarConductor("A")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim lintEstado As Int16 = 0
            If Me.btnValidar.Text = "Anular Verificación" Then
                If MessageBox.Show("Los datos del Conductor no están conforme", "Anular Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.No Then Exit Sub
                lintEstado = 1
            Else
                If MessageBox.Show("Los datos del Conductor están conforme", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.No Then Exit Sub
                lintEstado = 2
            End If
            Dim objEntidad As New Chofer
            Dim objChofer As New Chofer_BLL
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", gwdDatos.CurrentRow.Index).Value.ToString().Trim()
            objEntidad.FLGAPR = IIf(lintEstado = 1, "", "X")
            objEntidad.USRAPR = IIf(lintEstado = 1, "", MainModule.USUARIO)
            objEntidad.FCHAPR = IIf(lintEstado = 1, 0, HelpClass.TodayNumeric)
            objEntidad.HRAAPR = IIf(lintEstado = 1, 0, HelpClass.NowNumeric)
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            Dim intEstado As Int16 = lintEstado
            Dim strResult As String = objChofer.Aprobar_Conformidad_Datos_Conductor(objEntidad, intEstado)
            If lintEstado = 2 And intEstado = 0 Then
                Me.gwdDatos.Item("FLGAPR", gwdDatos.CurrentRow.Index).Value = "X"
                Me.gwdDatos.Item("USRAPR", gwdDatos.CurrentRow.Index).Value = MainModule.USUARIO & " - " & HelpClass.CNumero8Digitos_a_Fecha(HelpClass.TodayNumeric)
                Me.btnValidar.Text = "Anular Verificación"
            ElseIf lintEstado = 1 And intEstado = 0 Then
                Me.gwdDatos.Item("FLGAPR", gwdDatos.CurrentRow.Index).Value = ""
                Me.gwdDatos.Item("USRAPR", gwdDatos.CurrentRow.Index).Value = ""
                Me.btnValidar.Text = "Verificar Datos"
            End If
            HelpClass.MsgBox(strResult, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimirVacaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirVacaciones.Click
        Try
            Dim oVacacionesConductor As New rptControlVacacionesConductor
            objPrintForm = New PrintForm
            Dim odtTabla As New DataTable
            odtTabla = Lista_Vacaciones_Conductor("")
            If odtTabla.Rows.Count <= 0 Then
                MsgBox("No existe información a imprimir.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim strConductor As String = Me.txtApellidoPaterno.Text.Trim & " " & Me.txtApellidoMaterno.Text.Trim & " , " & Me.txtNombres.Text.Trim
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblFlag", IIf(rbtnPropio.Checked, "PROPIOS", "TERCEROS"))
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblCompania", Me.cmbCompania.Text)
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblUsuario", USUARIO)
            oVacacionesConductor.SetDataSource(AgregarDT(odtTabla, "CHOFER").Copy())
            objPrintForm.ShowForm(oVacacionesConductor, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Lista_Vacaciones_Conductor(ByVal strConductor As String) As DataTable
        Dim objNegocio As New VacacionesConductor_BLL
        Dim objEntidad As New VacacionesConductor
        Dim odtTabla As New DataTable
        objEntidad.CBRCNT = strConductor
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.SINDRC = IIf(rbtnPropio.Checked, "P", "T")
        odtTabla = objNegocio.Reporte_Vacaciones_Conductor(objEntidad)
        Return odtTabla
    End Function

#Region "CONDUCTOR - DOC. ADJUNTOS"

    Private Sub Cargar_Imagen()
        Dim NomCarpetaConductor As String = ""
        Dim lwi As ListViewItem
        Dim strRuta As String
        Dim strDestino As String
        NomCarpetaConductor = ConfigurationManager.AppSettings("RUTA_CONDUCTOR").ToString()
        NomCarpetaConductor = (NomCarpetaConductor & txtCodigoBrevete.Text.Trim())
        strDestino = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        If TabControl1.SelectedTab.Name = "TabPageDocs" Then
            If lwDoc.SelectedItems.Count > 0 Then
                lwi = lwDoc.FocusedItem
                strRuta = Obtener_Ruta(lwDoc.Items(lwi.Index).SubItems(1).Text, NomCarpetaConductor)
                Dim strNomArcDes As String = String.Format("{0}_{1:yyyyMMddHHmmss}{2}", "TEMP", DateTime.Now, lwDoc.Items(lwi.Index).SubItems(2).Text)
                My.Computer.Network.DownloadFile(strRuta, strDestino & "\" & strNomArcDes)
                Help.ShowHelp(New Form(), strDestino & "\" & strNomArcDes)
            End If
        ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
            If lwImg.SelectedItems.Count > 0 Then
                lwi = lwImg.FocusedItem
                strRuta = Obtener_Ruta(lwImg.Items(lwi.Index).SubItems(1).Text, NomCarpetaConductor)
                Dim strNomArcDes As String = String.Format("{0}_{1:yyyyMMddHHmmss}{2}", "TEMP", DateTime.Now, lwImg.Items(lwi.Index).SubItems(2).Text)
                My.Computer.Network.DownloadFile(strRuta, strDestino & "\" & strNomArcDes)
                Help.ShowHelp(New Form(), strDestino & "\" & strNomArcDes)
            End If
        End If

    End Sub

    Private Sub lwDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lwDoc.DoubleClick
        Cargar_Imagen()
    End Sub

    Private Sub lwDoc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lwDoc.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmsOpciones.Show(Me.lwDoc, New Point(Me.x1, Me.y1))
         
        End If
    End Sub

    Public Shared Function sInputBox(ByVal title As String, ByVal promptText As String, ByRef value As String) As DialogResult
        Dim form As New Form()
        Dim label As New Label()
        Dim textBox As New TextBox()
        Dim buttonOk As New Button()
        Dim buttonCancel As New Button()

        form.Text = title
        label.Text = promptText
        textBox.Text = value

        buttonOk.Text = "OK"
        buttonCancel.Text = "Cancel"
        buttonOk.DialogResult = DialogResult.OK
        buttonCancel.DialogResult = DialogResult.Cancel

        label.SetBounds(9, 20, 372, 13)
        textBox.SetBounds(12, 36, 372, 20)
        buttonOk.SetBounds(228, 72, 75, 23)
        buttonCancel.SetBounds(309, 72, 75, 23)

        label.AutoSize = True
        textBox.Anchor = textBox.Anchor Or AnchorStyles.Right
        buttonOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        buttonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right

        form.ClientSize = New Size(396, 107)
        form.Controls.AddRange(New Control() {label, textBox, buttonOk, buttonCancel})
        form.ClientSize = New Size(Math.Max(300, label.Right + 10), form.ClientSize.Height)
        form.FormBorderStyle = FormBorderStyle.FixedDialog
        form.StartPosition = FormStartPosition.CenterScreen
        form.MinimizeBox = False
        form.MaximizeBox = False
        form.AcceptButton = buttonOk
        form.CancelButton = buttonCancel

        Dim dialogResult__1 As DialogResult = form.ShowDialog()
        value = textBox.Text
        Return dialogResult__1
    End Function

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Try
            Dim lwi As ListViewItem
            Dim objEntidad As New DocAdjuntoConductor
            Dim objLogica As New DocAdjuntoConductor_BLL

            If TabControl1.SelectedTab.Name = "TabPageDocs" Then
                If lwDoc.SelectedItems.Count > 0 Then
                    lwi = lwDoc.FocusedItem

                    Dim strTOBS As String = lwDoc.Items(lwi.Index).SubItems(4).Text.Trim()
                    If sInputBox("Conductor", "Observación: ", strTOBS) = Windows.Forms.DialogResult.OK Then
                        objEntidad.TOBS = strTOBS
                        'objEntidad.CBRCNT = lwDoc.Items(lwi.Index).SubItems(5).Text 'txtCodigoBrevete.Text.Trim
                        'objEntidad.NCRRDC = lwDoc.Items(lwi.Index).SubItems(6).Text
                        objEntidad.NCOIMG = lwDoc.Items(lwi.Index).SubItems(5).Text
                        objEntidad.CULUSA = MainModule.USUARIO
                        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        objEntidad = objLogica.Modificar_Documento_Adjunto_Obs(objEntidad)
                        cargarDocLinks()
                    End If
                End If
            ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
                If lwImg.SelectedItems.Count > 0 Then
                    lwi = lwImg.FocusedItem

                    Dim strTOBS As String = lwImg.Items(lwi.Index).SubItems(4).Text.Trim()
                    If sInputBox("Conductor", "Observación: ", strTOBS) = Windows.Forms.DialogResult.OK Then
                        objEntidad.TOBS = strTOBS
                        'objEntidad.CBRCNT = lwImg.Items(lwi.Index).SubItems(5).Text 'txtCodigoBrevete.Text.Trim
                        'objEntidad.NCRRDC = lwImg.Items(lwi.Index).SubItems(6).Text
                        objEntidad.NCOIMG = lwImg.Items(lwi.Index).SubItems(5).Text
                        objEntidad.CULUSA = MainModule.USUARIO
                        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        objEntidad = objLogica.Modificar_Documento_Adjunto_Obs(objEntidad)
                        cargarDocLinks()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Dim lwi As ListViewItem
        Dim objEntidad As New DocAdjuntoConductor
        If TabControl1.SelectedTab.Name = "TabPageDocs" Then
            If lwDoc.SelectedItems.Count > 0 Then
                lwi = lwDoc.FocusedItem
                objEntidad.NCOIMG = lwDoc.Items(lwi.Index).SubItems(5).Text
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

                Dim objLogica As New DocAdjuntoConductor_BLL
                objEntidad = objLogica.Eliminar_Documento_Adjunto(objEntidad)
                cargarDocLinks()
            End If

        ElseIf TabControl1.SelectedTab.Name = "TabPageImg" Then
            If lwImg.SelectedItems.Count > 0 Then
                lwi = lwImg.FocusedItem
                objEntidad.NCOIMG = lwImg.Items(lwi.Index).SubItems(5).Text
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

                Dim objLogica As New DocAdjuntoConductor_BLL
                objEntidad = objLogica.Eliminar_Documento_Adjunto(objEntidad)
                cargarDocLinks()
            End If
        End If
    End Sub

    Private Sub lwDoc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lwDoc.MouseMove
        Me.x1 = e.X
        Me.y1 = e.Y
    End Sub
#End Region

    Private Sub btnImprimirAsistencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimirAsistencia.Click
        Try
            Dim odtTabla As DataTable
            If dtgListaAsistencia.RowCount <= 0 Then
                MsgBox("No existe información a imprimir.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim oAsistenciaConductor As New rptControlAsistenciaConductor
            Dim objNegocio As New Chofer_BLL
            Dim objHash As New Hashtable
            objPrintForm = New PrintForm
            odtTabla = New DataTable
            objHash.Add("CBRCNT", Me.gwdDatos.Item("CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
            objHash.Add("CCMPN", Me.cmbCompania.SelectedValue)
            odtTabla = objNegocio.Reporte_Asistencia_Conductor(objHash)
            Dim strConductor As String = Me.txtApellidoPaterno.Text.Trim & " " & Me.txtApellidoMaterno.Text.Trim & " , " & Me.txtNombres.Text.Trim
            HelpClass.CrystalReportTextObject(oAsistenciaConductor, "lblFlag", IIf(rbtnPropio.Checked, "PROPIOS", "TERCEROS"))
            HelpClass.CrystalReportTextObject(oAsistenciaConductor, "lblCompania", Me.cmbCompania.Text)
            HelpClass.CrystalReportTextObject(oAsistenciaConductor, "lblUsuario", USUARIO)
            oAsistenciaConductor.SetDataSource(AgregarDT(odtTabla, "CHOFER").Copy())
            objPrintForm.ShowForm(oAsistenciaConductor, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimirRecord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimirRecord.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
               
                MsgBox("Debe guardar el nuevo chofer o cancelarlo.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If gwdRecordGeneral.RowCount <= 0 Then
                MsgBox("No existe información a imprimir.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim oRecordConductor As New rptRecordConductor
            Dim objPrintForm = New PrintForm
            oRecordConductor.SetParameterValue("pTipoRecord", CType(gwdRecordGeneral.CurrentRow.Cells("TTPRCD"), Object).EditedFormattedValue.ToString.Trim)
            oRecordConductor.SetParameterValue("pConductor", txtApellidoPaterno.Text.Trim & " " & txtApellidoMaterno.Text.Trim & ", " & txtNombres.Text.Trim)
            oRecordConductor.SetParameterValue("pObservacion", gwdRecordGeneral.CurrentRow.Cells("TOBSMD").Value)
            oRecordConductor.SetParameterValue("pDocIdentidad", txtDni.Text.Trim)
            oRecordConductor.SetParameterValue("pFechaRegRecord", gwdRecordGeneral.CurrentRow.Cells("FRGTRO").Value)
            oRecordConductor.SetParameterValue("pFechaInicio", gwdRecordGeneral.CurrentRow.Cells("FECINI").Value)
            oRecordConductor.SetParameterValue("pFechaFinal", gwdRecordGeneral.CurrentRow.Cells("FECTER").Value)
            oRecordConductor.SetParameterValue("pTelefono", txtDatRPM.Text.Trim)
            oRecordConductor.SetParameterValue("pPapeleta", gwdRecordGeneral.CurrentRow.Cells("NRPPLT").Value)
            oRecordConductor.SetParameterValue("pMotivo", gwdRecordGeneral.CurrentRow.Cells("MTVEVN").Value)
            objPrintForm.ShowForm(oRecordConductor, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimirVacaciones2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimirVacaciones2.Click
        Try
            Dim odtTabla As DataTable
            If gwdVacaciones.RowCount <= 0 Then
                MsgBox("No existe información a imprimir.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim oVacacionesConductor As New rptControlVacacionesConductor
            objPrintForm = New PrintForm
            odtTabla = New DataTable
            odtTabla = Lista_Vacaciones_Conductor(gwdDatos.Item("CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
            Dim strConductor As String = Me.txtApellidoPaterno.Text.Trim & " " & Me.txtApellidoMaterno.Text.Trim & " , " & Me.txtNombres.Text.Trim
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblFlag", IIf(rbtnPropio.Checked, "PROPIOS", "TERCEROS"))
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblCompania", Me.cmbCompania.Text)
            HelpClass.CrystalReportTextObject(oVacacionesConductor, "lblUsuario", USUARIO)
            oVacacionesConductor.SetDataSource(AgregarDT(odtTabla, "CHOFER").Copy())
            objPrintForm.ShowForm(oVacacionesConductor, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    



    Private Sub EstadoBoton(ByVal op As MANTENIMIENTO)
        Dim lstr_PestanaActiva As String = ""
        Dim lbool_estado As Boolean = False
        Select Case op
            Case MANTENIMIENTO.NEUTRAL

                btnNuevo.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnModificar.Enabled = True
                btnEliminar.Enabled = True
                btnReactivar.Enabled = True
                btnValidar.Enabled = True
                btnDocAdjunto.Enabled = False


                btnImprimir.Visible = True
                btnImprimirAsistencia.Visible = False
                btnImprimirRecord.Visible = False
                btnImprimirVacaciones2.Visible = False

                lstr_PestanaActiva = Me.TabConductor.SelectedTab.Name
                Select Case lstr_PestanaActiva
                    Case "Asistencia"
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = False

                        btnImprimirAsistencia.Visible = True

                    Case "DocAdjuntos"

                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = True
                        btnDocAdjunto.Enabled = True


                    Case "Historial"
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = False


                    Case "Record"
                        btnImprimirRecord.Visible = True

                    Case "Vacaciones"
                        btnImprimirVacaciones2.Visible = True

                End Select


                lbool_estado = False

            Case MANTENIMIENTO.EDITAR

                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnDocAdjunto.Enabled = False
                btnReactivar.Enabled = False
                btnValidar.Enabled = False

                btnImprimir.Enabled = False
                btnImprimirAsistencia.Visible = False
                btnImprimirRecord.Visible = False
                btnImprimirVacaciones2.Visible = False



                lbool_estado = True

            Case MANTENIMIENTO.NUEVO
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnDocAdjunto.Enabled = False
                btnReactivar.Enabled = False
                btnValidar.Enabled = False


                btnImprimir.Enabled = False
                btnImprimirAsistencia.Visible = False
                btnImprimirRecord.Visible = False
                btnImprimirVacaciones2.Visible = False

                lbool_estado = True
        End Select

        lstr_PestanaActiva = Me.TabConductor.SelectedTab.Name
                Select lstr_PestanaActiva
            Case "DatosConductor"
                Estado_Controles_Chofer(lbool_estado)
        End Select

        If gwdDatos.CurrentRow IsNot Nothing Then
            Dim strEstado As String = gwdDatos.CurrentRow.Cells("SESTRG").Value.ToString.Trim
            If strEstado = "I" Or strEstado = "*" Then
                btnReactivar.Enabled = True
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnDocAdjunto.Enabled = False
                btnValidar.Enabled = False
            Else
                btnReactivar.Enabled = False
            End If
        End If

        

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            '======================================================================================================
            Select Case lstr_PestanaActiva
                Case "DatosConductor"
                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)
                Case "Capacitaciones"
                    If gwdCapacitacionDatosCapt.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)
                    Dim obj As Object
                    For i As Integer = 0 To gwdCapacitacionDatosCapt.Columns.Count - 1
                        obj = gwdCapacitacionDatosCapt.Item(i, gwdCapacitacionDatosCapt.CurrentRow.Index).Tag
                        If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                            If obj.ToString = "ReadOnly" Then
                                gwdCapacitacionDatosCapt.Item(i, gwdCapacitacionDatosCapt.CurrentRow.Index).ReadOnly = True

                            End If
                        Else
                            gwdCapacitacionDatosCapt.Item(i, gwdCapacitacionDatosCapt.CurrentRow.Index).ReadOnly = False
                            gwdCapacitacionDatosCapt.Item(i, gwdCapacitacionDatosCapt.CurrentRow.Index).Style.BackColor = Color.LightYellow

                        End If
                    Next


                Case "Pases"
                    If gwdPase_TipoPase.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)

                    Dim obj As Object
                    For i As Integer = 0 To gwdPase_TipoPase.Columns.Count - 1
                        obj = gwdPase_TipoPase.Item(i, gwdPase_TipoPase.CurrentRow.Index).Tag
                        If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                            If obj.ToString = "ReadOnly" Then
                                gwdPase_TipoPase.Item(i, gwdPase_TipoPase.CurrentRow.Index).ReadOnly = True
                            End If
                        Else
                            gwdPase_TipoPase.Item(i, gwdPase_TipoPase.CurrentRow.Index).ReadOnly = False
                            gwdPase_TipoPase.Item(i, gwdPase_TipoPase.CurrentRow.Index).Style.BackColor = Color.LightYellow
                        End If
                    Next


                Case "Vacunas"
                    If gwdRecordMedico.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)

                    Dim obj As Object
                    For i As Integer = 0 To gwdRecordMedico.Columns.Count - 1
                        obj = gwdRecordMedico.Item(i, gwdRecordMedico.CurrentRow.Index).Tag
                        If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                            If obj.ToString = "ReadOnly" Then
                                gwdRecordMedico.Item(i, gwdRecordMedico.CurrentRow.Index).ReadOnly = True
                            End If
                        Else
                            gwdRecordMedico.Item(i, gwdRecordMedico.CurrentRow.Index).ReadOnly = False
                            gwdRecordMedico.Item(i, gwdRecordMedico.CurrentRow.Index).Style.BackColor = Color.LightYellow
                        End If
                    Next


                Case "Record"
                    If gwdRecordGeneral.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)

                    Dim obj As Object
                    For i As Integer = 0 To gwdRecordGeneral.Columns.Count - 1
                        obj = gwdRecordGeneral.Item(i, gwdRecordGeneral.CurrentRow.Index).Tag
                        If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                            If obj.ToString = "ReadOnly" Then
                                gwdRecordGeneral.Item(i, gwdRecordGeneral.CurrentRow.Index).ReadOnly = True
                            End If
                        Else
                            gwdRecordGeneral.Item(i, gwdRecordGeneral.CurrentRow.Index).ReadOnly = False
                            gwdRecordGeneral.Item(i, gwdRecordGeneral.CurrentRow.Index).Style.BackColor = Color.LightYellow
                        End If
                    Next


                Case "Vacaciones"
                    If gwdVacaciones.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    EstadoBoton(gEnum_Mantenimiento)

                    Dim obj As Object
                    For i As Integer = 0 To gwdVacaciones.Columns.Count - 1
                        obj = gwdVacaciones.Item(i, gwdVacaciones.CurrentRow.Index).Tag
                        If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                            If obj.ToString = "ReadOnly" Then
                                gwdVacaciones.Item(i, gwdVacaciones.CurrentRow.Index).ReadOnly = True
                            End If
                        Else
                            gwdVacaciones.Item(i, gwdVacaciones.CurrentRow.Index).ReadOnly = False
                            gwdVacaciones.Item(i, gwdVacaciones.CurrentRow.Index).Style.BackColor = Color.LightYellow
                        End If
                    Next

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            oHasTabActivo.Clear()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

            dtgListaAsistencia.DataSource = Nothing
            gwdCapacitacionDatosCapt.Rows.Clear()
            gwdPase_TipoPase.Rows.Clear()
            gwdRecordMedico.Rows.Clear()
            gwdRecordGeneral.Rows.Clear()
            gwdVacaciones.Rows.Clear()
            'gwdHistorial.Rows.Clear()
            gwdHistorial.DataSource = Nothing
            Me.lwDoc.Items.Clear()
            Me.lwImg.Items.Clear()


            EstadoBoton(gEnum_Mantenimiento)
            MostrarDetalleRegistro()

          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarDetalleRegistro()
        Dim lstr_PestanaActiva As String = Me.TabConductor.SelectedTab.Name
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
        Me.Cargar_Detalle_Chofer()
       
        If lstr_PestanaActiva = "Asistencia" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                Lista_Asistencia_Conductor()
            End If

        ElseIf lstr_PestanaActiva = "Capacitaciones" Then
            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                Listar_Capacitacion()
            End If
        ElseIf lstr_PestanaActiva = "Pases" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                Listar_Pase()
            End If

        ElseIf lstr_PestanaActiva = "Vacunas" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                ListarRecordMedico()
            End If

        ElseIf lstr_PestanaActiva = "Record" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                ListarRecordGeneral()
            End If

        ElseIf lstr_PestanaActiva = "Vacaciones" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                ListarVacaciones()
            End If

        ElseIf lstr_PestanaActiva = "Historial" Then

            If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                Cargar_Datos_Historial()
            End If
        ElseIf lstr_PestanaActiva = "DocAdjuntos" Then
            Dim lstr_PestanaActiva_sub As String = Me.TabControl1.SelectedTab.Name

            If lstr_PestanaActiva_sub = "TabPageDocs" Then
                If Not oHasTabActivo.Contains(lstr_PestanaActiva) Then
                    cargarDocLinks()
                End If
            ElseIf lstr_PestanaActiva_sub = "TabPageImg" Then

            End If

        End If
        oHasTabActivo(lstr_PestanaActiva) = lstr_PestanaActiva
    End Sub

    Private Sub TabConductor_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabConductor.Selected
        Try
            'oHasTabActivo
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            MostrarDetalleRegistro()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class