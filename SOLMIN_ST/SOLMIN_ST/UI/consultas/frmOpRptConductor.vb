Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOpRptConductor

    Private _CBRCNT As String = ""
    Private _rutaImagen As String = ""

    Public Property rutaImagen()
        Get
            Return _rutaImagen
        End Get
        Set(ByVal value)
            _rutaImagen = value
        End Set
    End Property

    Private _CCMPN As String

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        imprimir()
        Me.Close()
    End Sub

    Private Sub imprimir()
        Dim objCrep As New rptChofer

        Dim objPrintForm = New PrintForm

        Dim objChofer As New Chofer
        Dim objRepChofer As New Chofer_BLL

        Dim objCapChofer As New CapacitacionConductor
        Dim objRepCapChofer As New CapacitacionConductor_BLL

        Dim objPaseChofer As New PaseConductor
        Dim objRepPaseChofer As New PaseConductor_BLL

        Dim objRecordMedico As New RecordMedico
        Dim objRepRecordMedico As New RecordMedico_BLL

        Dim objRecordGeneral As New RecordGeneral
        Dim objRepRecordGeneral As New RecordGeneral_BLL

        Dim objVacacionesConductor As New VacacionesConductor
        Dim objRepVacacionesConductor As New VacacionesConductor_BLL

        Dim objTransportistaConductor As New TransportistaConductor
        Dim objRepTransportistaConductor As New TransportistaConductor_BLL

        Dim objRepDocAdjuntoConductor As New DocAdjuntoConductor_BLL

        objChofer.CBRCNT = _CBRCNT
        objChofer.CCMPN = _CCMPN

        Try
      objCrep.SetDataSource(AgregarDT(HelpClass.GetDataSetNative(objRepChofer.Listar_Chofer_Reporte(objChofer)), "CHOFER").Copy)

            'Lista de Asistencia
            'If Me.chkListaAsistencia.Checked Then
            '    Dim objHash As New Hashtable

            '    objHash.Add("CBRCNT", objChofer.CBRCNT)
            '    objHash.Add("CCMPN", _CCMPN)
            '    Dim dtbAsistencia As New DataTable
            '    dtbAsistencia = objRepChofer.Lista_Asistencia_Conductor_Reporte(objHash)
            '    If dtbAsistencia.Rows.Count > 0 Then
            '        'objCrep.OpenSubreport("Subreport5").SetDataSource(dtbAsistencia)
            '        objCrep.Subreports.Item("rptListaAsistencia.rpt").SetDataSource(dtbAsistencia.Copy)
            '    End If
            'End If

            'Datos de Capacitacion
            If Me.chkCapacitaciones.Checked Then
                objCapChofer.CBRCNT = objChofer.CBRCNT
                objCapChofer.CCMPN = _CCMPN

                Dim dtbCapacitacion As DataTable = objRepCapChofer.Listar_CapacitacionConductor_Reporte(objCapChofer)
                If dtbCapacitacion.Rows.Count > 0 Then
                    'objCrep.OpenSubreport("rptCapacitacion.rpt").SetDataSource(dtbCapacitacion)
                    objCrep.Subreports.Item("rptCapacitacion.rpt").SetDataSource(dtbCapacitacion.Copy)
                End If
            End If

            'Datos de Pase de Conductor
            If Me.chkPase.Checked Then
                objPaseChofer.CBRCNT = objChofer.CBRCNT
                objPaseChofer.CCMPN = _CCMPN
                Dim dtbPaseChofer As DataTable = objRepPaseChofer.Lista_Pases_Chofer_DT(objPaseChofer)
                If dtbPaseChofer.Rows.Count > 0 Then
                    'objCrep.OpenSubreport("rptPases.rpt").SetDataSource(dtbPaseChofer.Copy)
                    objCrep.Subreports.Item("rptPases.rpt").SetDataSource(dtbPaseChofer.Copy)
                End If
            End If

            'Datos de Record Médico
            If Me.chVacunas.Checked Then
                objRecordMedico.CBRCNT = objChofer.CBRCNT
                objRecordMedico.CCMPN = _CCMPN
                Dim dtbRecordMedico As DataTable = objRepRecordMedico.Listar_Record_Medico_DT(objRecordMedico)
                If dtbRecordMedico.Rows.Count > 0 Then
                    'objCrep.OpenSubreport("rptRecordMedico.rpt").SetDataSource(dtbRecordMedico)
                    objCrep.Subreports.Item("rptRecordMedico.rpt").SetDataSource(dtbRecordMedico.Copy)
                End If
            End If

            'Datos de Record General
            If Me.chkRecordGral.Checked Then
                objRecordGeneral.CBRCNT = objChofer.CBRCNT
                objRecordGeneral.CCMPN = _CCMPN
                Dim dtbRecordGeneral As DataTable = objRepRecordGeneral.Listar_Record_General_DT(objRecordGeneral)
                If dtbRecordGeneral.Rows.Count > 0 Then
                    'objCrep.OpenSubreport("rptRecordGeneral.rpt").SetDataSource(dtbRecordGeneral)
                    objCrep.Subreports.Item("rptRecordGeneral.rpt").SetDataSource(dtbRecordGeneral.Copy)
                End If
            End If

            'Vacaciones
            'If Me.chkVacaciones.Checked Then
            '    objVacacionesConductor.CBRCNT = objChofer.CBRCNT
            '    objVacacionesConductor.CCMPN = _CCMPN
            '    Dim dtbVacaciones As DataTable = objRepVacacionesConductor.Listar_Vacaciones_Conductor_Rpt(objVacacionesConductor)
            '    If dtbVacaciones.Rows.Count > 0 Then
            '        'objCrep.OpenSubreport("rptRecordGeneral.rpt").SetDataSource(dtbRecordGeneral)
            '        objCrep.Subreports.Item("rptVacaciones.rpt").SetDataSource(dtbVacaciones.Copy)
            '    End If
            'End If

            'Historial
            'If Me.chkHistorial.Checked Then
            '    objTransportistaConductor.CBRCNT = objChofer.CBRCNT
            '    objTransportistaConductor.CCMPN = _CCMPN
            '    Dim dtbHistorial As DataTable = objRepTransportistaConductor.Listar_TransportistaConductor_Historial_Rpt(objTransportistaConductor)
            '    objCrep.Subreports.Item("rptHistorial.rpt").SetDataSource(dtbHistorial.Copy)
            'End If

            'Documentos Adjuntos
            'If chkDocAdjunto.Checked Then
            '    Dim objHash2 As New Hashtable()
            '    objHash2.Add("CBRCNT", objChofer.CBRCNT)
            '    objHash2.Add("NCRRDC", 0)
            '    objHash2.Add("CCMPN", _CCMPN)
            '    Dim dtbDocAdjunto As DataTable = objRepDocAdjuntoConductor.Listar_Documentos_Adjuntos_Rpt(objHash2)
            '    objCrep.Subreports.Item("rptDocumentoAdjunto.rpt").SetDataSource(dtbDocAdjunto.Copy)
            'End If

            'objCrep.SetParameterValue("pMostrarSubRptLisAsist", Not Me.chkListaAsistencia.Checked) '
            objCrep.SetParameterValue("pMostrarSubRptCapac", Not Me.chkCapacitaciones.Checked)
            objCrep.SetParameterValue("pMostrarSubRptPase", Not Me.chkPase.Checked)
            objCrep.SetParameterValue("pMostrarSubRptRecMed", Not Me.chVacunas.Checked)
            objCrep.SetParameterValue("pMostrarSubRptRecGral", Not Me.chkRecordGral.Checked)
            'objCrep.SetParameterValue("pMostrarSubRptVacaciones", Not Me.chkVacaciones.Checked)
            'objCrep.SetParameterValue("pMostrarSubRptHistorial", Not Me.chkHistorial.Checked)
            'objCrep.SetParameterValue("pMostrarSubRptDocAdjunto", Not Me.chkDocAdjunto.Checked)

            objPrintForm.ShowForm(objCrep, Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
        dt.TableName = dtName
        Return dt
    End Function

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
