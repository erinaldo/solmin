Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmConsolidadoMultimodal
    Private _objMultimodal As Multimodal
    Public Property objMultimodal() As Multimodal
        Get
            Return _objMultimodal
        End Get
        Set(ByVal value As Multimodal)
            _objMultimodal = value
        End Set
    End Property

    Private objParamList As New Hashtable
    Private _NMOPMM As Double
    Public Property NMOPMM() As Double
        Get
            Return _NMOPMM
        End Get
        Set(ByVal value As Double)
            _NMOPMM = value
        End Set
    End Property

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            gwdDatos.DataSource = Nothing
            Me.PrepararProceesWorked()
            bgwProceso.RunWorkerAsync()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Me.Cursor = Cursors.Default
            ClearMemory()
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrepararProceesWorked()
        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."

        objParamList = New Hashtable
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        Else
            lstr_FecIni = 0
            lstr_FecFin = 0
        End If

        objParamList.Add("NMOPMM", Me.txtNroOperacionMM.Text)
        If txtClienteFiltro.pCodigo <> 0 Then
            objParamList.Add("CCLNT", txtClienteFiltro.pCodigo)
        Else
            objParamList.Add("CCLNT", 0)
        End If

        objParamList.Add("FECINI", lstr_FecIni)
        objParamList.Add("FECFIN", lstr_FecFin)
        objParamList.Add("CCMPN", _objMultimodal.CCMPN)
        objParamList.Add("CDVSN", _objMultimodal.CDVSN)
        objParamList.Add("CPLNDV", _objMultimodal.CPLNDV)

        'objParamList.Add("TNMMDT", _objMultimodal.TNMMDT)
        objParamList.Add("CMEDTR", _objMultimodal.CMEDTR)
        objParamList.Add("CTRSPT", _objMultimodal.CTRSPT)
        objParamList.Add("NPLCUN", _objMultimodal.NPLCUN)
        objParamList.Add("NPLCAC", _objMultimodal.NPLCAC)

    End Sub

    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim objOperacionMultimodal As New Multimodal_BLL
        e.Result = objOperacionMultimodal.Listar_Operaciones_Multimodal_Filtro(objParamList)
    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
        Dim dstreporte As New DataTable
        dstreporte = CType(e.Result, DataTable)
        Me.gwdDatos.Rows.Clear()
        Dim oDrVw As DataGridViewRow
        Dim FILA As Int32 = 0
        For Each dr As DataRow In dstreporte.Rows
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.gwdDatos)
            Me.gwdDatos.Rows.Add(oDrVw)

            For Each dc As DataGridViewColumn In Me.gwdDatos.Columns
                If dc.Name.ToString <> "chkSelect" Then
                    Me.gwdDatos.Rows(FILA).Cells(dc.Name.ToString).Value = dr(dc.DataPropertyName.ToString)
                Else
                    Me.gwdDatos.Rows(FILA).Cells("chkSelect").Value = False
                End If
            Next
            FILA = FILA + 1
        Next
        Me.lblProceso.Text = "Finalizado..."
        Me.pbxProceso.Visible = False
        Me.lblProceso.Visible = False
        'Me.gwdDatos.DataSource = dstreporte.Copy
    End Sub

    Private Sub frmConsolidadoMultimodal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Me.txtMedioTransporte.Text = _objMultimodal.TNMMDT
        Me.txtTransportista.Text = _objMultimodal.TCMTRT
        Me.txtPlaca.Text = _objMultimodal.NPLCUN
        Me.txtAcoplado.Text = _objMultimodal.NPLCAC

    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    End Sub

    Private Sub txtNroOperacionMM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOperacionMM.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtNroOperacionMM_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOperacionMM.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnProcesarConsulta_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub gwdDatos_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellDirtyStateChanged
        If gwdDatos.IsCurrentCellDirty Then
            gwdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.gwdDatos.EndEdit()
        For Each row As DataGridViewRow In Me.gwdDatos.Rows
            If row.Cells("chkSelect").Value Then
                Dim param As New Hashtable
                param.Add("PSCCMPN", objMultimodal.CCMPN)
                param.Add("PSNRUCTR", row.Cells("NRUCTR").Value.ToString.Trim)
                param.Add("PNNMVJCS", objMultimodal.PNNMVJCS)
                param.Add("PNNGUIRM", row.Cells("NGUITR").Value)
                param.Add("PNNCSOTR", row.Cells("NCSOTR").Value)
                Dim oblMultimodal As New Multimodal_BLL
                If oblMultimodal.Importar_Operaciones_Multimodal(param) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
            End If
        Next
    End Sub
End Class
