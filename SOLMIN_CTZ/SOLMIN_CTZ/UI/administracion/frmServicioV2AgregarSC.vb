Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Ransa.Controls
Public Class frmServicioV2AgregarSC
    Private dblFecha As Double
    Private oServicioSILNeg As New clsServicioSILNeg
    Private oServicioSIL As New ServicioSIL

    Public Sub New(ByVal poServicioSIL As ServicioSIL)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oServicioSILNeg = New clsServicioSILNeg
        oServicioSIL = New ServicioSIL
        oServicioSIL = poServicioSIL
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmServicioV2AgregarSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '====Cargar Servicios en Combo====
        Dim oDt As New DataTable
        oServicioSIL.CPLNDV = 1
        oServicioSIL.FECSER = Format(dtpFechServicio.Value, "yyyyMMdd")
        oDt = oServicioSILNeg.Cargar_Servicios_Tarifa_Cliente(oServicioSIL)
        cmbServicio.DataSource = oDt
        cmbServicio.ValueMember = "NRTFSV"
        cmbServicio.DisplayMember = "DESTAR"
        '===Cargamos Cliente ============
        'Dim ClientePK As Ransa.TypeDef.Cliente.TD_ClientePK = New Ransa.TypeDef.Cliente.TD_ClientePK(oServicioSIL.CCLNT, ConfigurationWizard.UserName)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(oServicioSIL.CCLNT, ConfigurationWizard.UserName)
        UcCliente.pCargar(ClientePK)
        If oServicioSIL.TIPO = "M" Then
            Cargar_Para_Modificar()
            Cargar_Detalle_Servicios()
        End If
    End Sub
#Region "Modificacion"
    Private Sub Cargar_Para_Modificar()
        dtpFechServicio.Enabled = False
        dtpFechServicio.Text = HelpClass.FormatoFecha(oServicioSIL.FECSER)
        txtCantidad.Text = oServicioSIL.QATNAN
        txtObservacion.Text = oServicioSIL.TOBS
        Me.cmbServicio.SelectedValue = oServicioSIL.NRTFSV
    End Sub
    Private Sub Cargar_Detalle_Servicios()
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        Dim oDt As New DataTable
        oDt = oServicioSILNeg.Lista_Detalle_Servicios_SIL(oServicioSIL)
        Dim dv As New DataView(oDt)
        Dim oDtNew As DataTable = dv.ToTable(True, "NORSCI", "NORCML", "ETA", "ETD", "ATD")
        With oDtNew
            If oDtNew.Rows.Count > 0 Then
                For intCont = 0 To .Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgEmbarqueServicios)
                    oDrVw.Cells(0).Value = .Rows(intCont).Item("NORSCI").ToString.Trim
                    oDrVw.Cells(1).Value = .Rows(intCont).Item("NORCML").ToString.Trim
                    oDrVw.Cells(2).Value = .Rows(intCont).Item("ETD").ToString.Trim
                    oDrVw.Cells(3).Value = .Rows(intCont).Item("ETA").ToString.Trim
                    oDrVw.Cells(4).Value = .Rows(intCont).Item("ATD").ToString.Trim
                    dtgEmbarqueServicios.Rows.Add(oDrVw)
                Next intCont
            End If
        End With
    End Sub
#End Region

#Region "Embarques para agregar"
    Private Sub txtEmbarque_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmbarque.KeyUp
        Me.Cursor = Cursors.WaitCursor
        If e.KeyValue = 13 And (Me.txtEmbarque.Text.Trim.Length >= 2) Then
            Limpiar_dtgEmbarqueServicios()
            LLenar_dtgListaOCEmbarque()
        Else
            If e.KeyValue = 13 Then
                HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR.EMBARQUE"), MessageBoxIcon.Error)
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub LLenar_dtgListaOCEmbarque()
        Try
            Dim oDt As DataTable
            Dim dblEmbarque As Double = 0
            Dim intCont, intRow As Integer

            If txtEmbarque.Text <> "" Then
                dblEmbarque = txtEmbarque.Text.Trim
            End If
            oDt = oServicioSILNeg.Lista_OC_X_Embarque_OS(oServicioSIL.CCLNT, dblEmbarque)
            With oDt
                If oDt.Rows.Count > 0 Then
                    For intRow = 0 To dtgEmbarqueServicios.Rows.Count - 1
                        For intCont = .Rows.Count - 1 To 0 Step -1
                            If (dtgEmbarqueServicios.Rows(intRow).Cells("NORSCI_").Value.ToString.Trim = .Rows(intCont).Item("NORSCI").ToString.Trim And dtgEmbarqueServicios.Rows(intRow).Cells("NORCML_").Value.ToString.Trim = .Rows(intCont).Item("NORCML").ToString.Trim) Then
                                oDt.Rows.RemoveAt(intCont)
                            End If
                        Next intCont
                    Next
                End If
            End With
            dtgListaOCEmbarque.AutoGenerateColumns = False
            dtgListaOCEmbarque.DataSource = oDt
            
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar_dtgEmbarqueServicios()
        Me.dtgListaOCEmbarque.DataSource = Nothing
    End Sub

    Private Sub dtgListaOCEmbarque_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaOCEmbarque.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.WaitCursor
            If dtgListaOCEmbarque.RowCount > 0 Then
                If Existe_Check() Then
                    Poner_Check_Todo(False)
                Else
                    Poner_Check_Todo(True)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.dtgListaOCEmbarque.Rows.Count - 1
            If dtgListaOCEmbarque.Rows(intCont).Cells(0).Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer

        dtgListaOCEmbarque.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For intCont = 0 To dtgListaOCEmbarque.RowCount - 1
            dtgListaOCEmbarque.Rows(intCont).Cells("VALIDAR").Value = blnEstado
        Next intCont
    End Sub

    Private Sub Agregar_Lista()
        Dim intCont As Integer
        Dim oDrVw As DataGridViewRow
        dtgListaOCEmbarque.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For intCont = dtgListaOCEmbarque.Rows.Count - 1 To 0 Step -1
            If dtgListaOCEmbarque.Rows(intCont).Cells("VALIDAR").Value = True Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgEmbarqueServicios)
                oDrVw.Cells(0).Value = dtgListaOCEmbarque.Rows(intCont).Cells("NORSCI").Value
                oDrVw.Cells(1).Value = dtgListaOCEmbarque.Rows(intCont).Cells("NORCML").Value
                oDrVw.Cells(2).Value = dtgListaOCEmbarque.Rows(intCont).Cells("ETD").Value
                oDrVw.Cells(3).Value = dtgListaOCEmbarque.Rows(intCont).Cells("ETA").Value
                oDrVw.Cells(4).Value = dtgListaOCEmbarque.Rows(intCont).Cells("AT").Value
                dtgEmbarqueServicios.Rows.Add(oDrVw)
                dtgListaOCEmbarque.Rows.RemoveAt(intCont)
            End If
        Next
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Cursor = Cursors.WaitCursor
        Agregar_Lista()
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "Embarque Guardar"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.Cursor = Cursors.WaitCursor
        Guardar_Servicios()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Guardar_Servicios()
        Dim oDt As DataTable
        Dim olServicioSIL As ServicioSIL
        Try
            If CStr(cmbServicio.SelectedValue) <> "" And IsNumeric(txtCantidad.Text) Then
                olServicioSIL = New ServicioSIL
                olServicioSIL.CCLNT = oServicioSIL.CCLNT
                olServicioSIL.CCLNFC = UcCliente.pCodigo
                olServicioSIL.FOPRCN = Format(Me.dtpFechServicio.Value, "yyyyMMdd")
                olServicioSIL.FECINI = Format(Now, "yyyyMMdd")
                olServicioSIL.FECFIN = Format(Now, "yyyyMMdd")
                olServicioSIL.CCMPN = oServicioSIL.CCMPN
                olServicioSIL.CDVSN = oServicioSIL.CDVSN
                olServicioSIL.QATNAN = CType(Me.txtCantidad.Text, Double)
                olServicioSIL.NRTFSV = cmbServicio.SelectedValue
                olServicioSIL.TOBS = txtObservacion.Text
                olServicioSIL.NOPRCN = oServicioSIL.NOPRCN
                If oServicioSIL.TIPO = "M" Then
                    oServicioSILNeg.Actualiza_Servicio(olServicioSIL)
                    olServicioSIL.NOPRCN = oServicioSIL.NOPRCN
                    olServicioSIL.TIPO = "E"
                    oServicioSILNeg.Guardar_Detalle_Servicios_SIL(olServicioSIL)
                Else
                    oDt = oServicioSILNeg.Guardar_Servicios_Atendidos(olServicioSIL)
                    If oDt.Rows.Count > 0 Then
                        olServicioSIL.NOPRCN = oDt.Rows(0).Item(0)
                    End If
                End If
                Guardar_Detalle_Servicio_SIL(olServicioSIL)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR"), MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Guardar_Detalle_Servicio_SIL(ByVal poServicioSIL As ServicioSIL)
        Dim intCont As Integer
        Try
            For intCont = 0 To Me.dtgEmbarqueServicios.Rows.Count - 1
                poServicioSIL.TIPO = "I"
                poServicioSIL.NORSCI = dtgEmbarqueServicios.Rows(intCont).Cells("NORSCI_").Value
                poServicioSIL.NORCML = dtgEmbarqueServicios.Rows(intCont).Cells("NORCML_").Value
                oServicioSILNeg.Guardar_Detalle_Servicios_SIL(poServicioSIL)
            Next
        Catch ex As Exception
            HelpClass.MsgBox(HelpClass.getSetting("MENSAJE.ERROR"), MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
