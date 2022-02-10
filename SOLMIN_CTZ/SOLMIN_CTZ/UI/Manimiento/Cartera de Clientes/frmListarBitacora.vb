Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmListarBitacora

    Private _oContrato As SOLMIN_CTZ.Entidades.Contrato
    Public Property oContrato() As SOLMIN_CTZ.Entidades.Contrato
        Get
            Return _oContrato
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.Contrato)
            _oContrato = value
        End Set
    End Property

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Agrega_Row_Observacion()
    End Sub

    Private Sub Agrega_Row_Observacion()
        Dim oDrVw As New DataGridViewRow

        oDrVw.CreateCells(Me.dtgObservaciones)
        Me.dtgObservaciones.Rows.Add(oDrVw)
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Grabar_Bitacora_Contrato()
    End Sub

    Private Sub Cargar()
        Me.txtDatNumContrato.Text = _oContrato.NCNTRT
        Me.mskDatIniContrato.Text = _oContrato.FechaInicio
        Me.mskDatFinContrato.Text = _oContrato.FechaFin
        Llenar_Observaciones_Contrato()
    End Sub



    Private Sub Grabar_Bitacora_Contrato()
        Dim oSqlMan As New SqlManager
        Dim intCont As Integer
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.dtgObservaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
            oSqlMan.TransactionController(TransactionType.Manual)
            oSqlMan.BeginGlobalTransaction()

            Dim oContratoNeg As New clsContrato
            Dim oBitacora_Contrato As New Bitacora_Contrato

            oContratoNeg.Eliminar_Observaciones(oSqlMan, oContrato)

            oBitacora_Contrato.NRCTSL = oContrato.NRCTSL
            With Me.dtgObservaciones
                For intCont = 0 To .Rows.Count - 1
                    If (Not .Rows(intCont).Cells("TFCOBS").Value = Nothing) And (Not .Rows(intCont).Cells("TOBS_B").Value = Nothing) Then
                        oBitacora_Contrato.NRITOC = intCont + 1
                        oBitacora_Contrato.TFCOBS = Format(CType(.Rows(intCont).Cells("TFCOBS").Value, Date), "yyyyMMdd")
                        oBitacora_Contrato.TOBS = .Rows(intCont).Cells("TOBS_B").Value.ToString.Trim
                        oContratoNeg.Grabar_Observacion(oSqlMan, oBitacora_Contrato)
                    End If
                Next intCont
            End With
            oSqlMan.CommitGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            oSqlMan.RollBackGlobalTransaction()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        Finally
            oSqlMan = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End Try
    End Sub

    Private Sub frmListarBitacora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Private Sub Llenar_Observaciones_Contrato()
        Dim oDt As DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer
        Dim oContratoNeg As New clsContrato
        oDt = oContratoNeg.Lista_Observacion_Cliente(oContrato)
        For intCont = 0 To oDt.Rows.Count - 1
            If oDt.Rows(intCont).Item("TOBS").ToString.Trim <> vbNullString Then
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgObservaciones)
                oDrVw.Cells(0).Value = oDt.Rows(intCont).Item("NRITOC").ToString.Trim
                oDrVw.Cells(1).Value = oDt.Rows(intCont).Item("TFCOBS").ToString.Trim
                oDrVw.Cells(2).Value = oDt.Rows(intCont).Item("TOBS").ToString.Trim
                Me.dtgObservaciones.Rows.Add(oDrVw)
            End If
        Next intCont

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dtgObservaciones.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.dtgObservaciones.Rows.Remove(Me.dtgObservaciones.CurrentRow)
    End Sub

End Class
