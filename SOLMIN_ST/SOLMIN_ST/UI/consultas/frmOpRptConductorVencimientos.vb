Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOpRptConductorVencimientos
    Private _objChofer As New Chofer

    Public WriteOnly Property Chofer()
        Set(ByVal value)
            _objChofer = value
        End Set
    End Property

    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            imprimir()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub imprimir()
        Dim objDs As New DataSet
        Dim objPrintForm = New PrintForm
        Dim objReporte As New ReportClass
        'Try

        Dim ht As New Hashtable
        Dim fecIni As String = HelpClass.CDate_a_Numero8Digitos(CDate(dtpLimiteInicial.Value))
        Dim fecFin As String = HelpClass.CDate_a_Numero8Digitos(CDate(dtpLimiteFinal.Value))
        ht.Add("PSSINDRC", _objChofer.SINDRC)
        ht.Add("PNFECHA_LIMITE1", fecIni)
        ht.Add("PNFECHA_LIMITE2", fecFin)
        ht.Add("CCMPN", _objChofer.CCMPN)

        'Vencimientos Capacitaciones
        If rbtnCapacitaciones.Checked Then
            objReporte = New rptVencimientosCapacitaciones
            Dim objLogicaChofer As New CapacitacionConductor_BLL
            Dim dtbCapacitacion As New DataTable
            ht.Add("PNNCOCPT", cboCapacitaciones.Codigo)
            dtbCapacitacion = HelpClass.GetDataSetNative(objLogicaChofer.Listar_VencimientoCapacitacion_Reporte(ht))
            If dtbCapacitacion.Rows.Count > 0 Then
                dtbCapacitacion.TableName = "CAPACITACION"
                objReporte.SetDataSource(dtbCapacitacion.Copy)
            End If
            HelpClass.CrystalReportTextObject(objReporte, "lblTipoCapacitacion", "Tipo Capacitación: " & cboCapacitaciones.Descripcion)

            'Vencimientos Pases--------------------------
        ElseIf rbtnPases.Checked Then
            objReporte = New rptVencimientosPases
            Dim objLogicaPase As New PaseConductor_BLL
            Dim dtPases As New DataTable
            ht.Add("PNNCOPSE", cboPases.Codigo)
            dtPases = HelpClass.GetDataSetNative(objLogicaPase.Listar_VencimientoPase_Reporte(ht))
            If dtPases.Rows.Count > 0 Then
                dtPases.TableName = "PASE"
                objReporte.SetDataSource(dtPases.Copy)
            End If
            HelpClass.CrystalReportTextObject(objReporte, "lblTipoPase", "Tipo Pase: " & cboPases.Descripcion)


            'Vencimientos Vacunas--------------------------
        ElseIf rbtnVacunas.Checked Then
            objReporte = New rptVencimientosVacunas
            Dim objLogicaPase As New RecordMedico_BLL
            Dim dtRecdMed As New DataTable
            ht.Add("PNNCOVAC", cboRecordMedico.Codigo)
            dtRecdMed = HelpClass.GetDataSetNative(objLogicaPase.Listar_VencimientoVacuna_Reporte(ht))
            If dtRecdMed.Rows.Count > 0 Then
                dtRecdMed.TableName = "VACUNA"
                objReporte.SetDataSource(dtRecdMed.Copy)
            End If
            HelpClass.CrystalReportTextObject(objReporte, "lblTipoVacuna", "TipoVacuna: " & cboRecordMedico.Descripcion)
        End If

        objPrintForm.ShowForm(objReporte, Me)
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub frmOpRptConductorVencimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargarComboCapacitaciones()
            cargarComboPases()
            cargarComboRecordMedico()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub rbtnCapacitaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCapacitaciones.CheckedChanged, rbtnPases.CheckedChanged, rbtnVacunas.CheckedChanged
        disableCodeTextBoxes(CType(sender, ComponentFactory.Krypton.Toolkit.KryptonRadioButton))
    End Sub

    Private Sub disableCodeTextBoxes(ByVal rbtn As ComponentFactory.Krypton.Toolkit.KryptonRadioButton)
        cboCapacitaciones.Enabled = (cboCapacitaciones.Name.Equals(rbtn.Tag))
        cboPases.Enabled = (cboPases.Name.Equals(rbtn.Tag))
        cboRecordMedico.Enabled = (cboRecordMedico.Name.Equals(rbtn.Tag))
    End Sub

    Private Sub cargarComboCapacitaciones()
        'Try
        Dim objCapacitacion As New TipoCapacitacionConductor_BLL
        Dim objEntidad As New TipoCapacitacionConductor
        objEntidad.CCMPN = _objChofer.CCMPN
        cboCapacitaciones.DataSource = HelpClass.GetDataSetNative(objCapacitacion.Listar_TipoCapacitacionConductor(objEntidad))
        cboCapacitaciones.DisplayMember = "NOMCPT"
        cboCapacitaciones.ValueMember = "NCOCPT"
        cboCapacitaciones.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cargarComboPases()
        'Try
        Dim objLogica As New TipoPaseConductor_BLL
        Dim objEntidad As New TipoPaseConductor
        objEntidad.NOMPSE = ""
        objEntidad.CCMPN = _objChofer.CCMPN
        cboPases.DataSource = HelpClass.GetDataSetNative(objLogica.Lista_Tipo_Pases(objEntidad))
        cboPases.DisplayMember = "NOMPSE"
        cboPases.ValueMember = "NCOPSE"
        cboPases.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cargarComboRecordMedico()
        'Try
        Dim objLogica As New Vacunas_BLL
        Dim objEntidad As New Vacunas
        objEntidad.CCMPN = _objChofer.CCMPN
        cboRecordMedico.DataSource = HelpClass.GetDataSetNative(objLogica.Listar_Vacunas(objEntidad))
        cboRecordMedico.DisplayMember = "NOMVAC"
        cboRecordMedico.ValueMember = "NCOVAC"
        cboRecordMedico.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

End Class
