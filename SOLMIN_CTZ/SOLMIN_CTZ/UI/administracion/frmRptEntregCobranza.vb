Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmRptEntregCobranza

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            txtNrpEntreCob.Text = txtNrpEntreCob.Text.Trim
            If txtNrpEntreCob.Text.Length = 0 OrElse txtNrpEntreCob.Text = "0" Then
                MessageBox.Show("Ingrese Nro Entrega de Cobranza", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            Else
                Dim dtEntrega As New DataTable
                Dim orptCtaCte As New rptCuentaCteRelCobranza
                Dim oclsCuentaCorriente As New clsCuentaCorriente
                Dim obeCuentaCorriente As New CuentaCorriente
                Dim dtCtaCte As New DataTable
                obeCuentaCorriente.NRLENC = txtNrpEntreCob.Text
                dtCtaCte = oclsCuentaCorriente.Lista_CuentaCorriente_X_NRelCobranza(obeCuentaCorriente)
                Dim CMNDA As String = ""
                For Each Item As DataRow In dtCtaCte.Rows
                    CMNDA = ("" & Item("CMNDA")).ToString.Trim
                    If Item("NINDRN") = "0" Then
                        Item("NINDRN") = ""
                    End If
                    Select Case CMNDA
                        Case "1" 'SOLES
                            Item("ITTFCD") = 0
                        Case "100" 'DOLARES
                            Item("ITTFCS") = 0
                    End Select
                Next
                Dim objPrintForm As New PrintForm
                dtCtaCte.TableName = "CUENTA_CORRIENTE"
                Dim dtResumen As New DataTable
                Dim drResumen As DataRow
                dtResumen.Columns.Add("COD_UNICO")
                dtResumen.Columns.Add("COD_UB_COBRO")
                dtResumen.Columns.Add("DES_UB_COBRO")
                dtResumen.Columns.Add("CCLNT")             
                dtResumen.Columns.Add("CLIENTE")
                dtResumen.Columns.Add("DIRECCION")
                dtResumen.Columns.Add("NUMDOC", Type.GetType("System.Int64"))
                dtResumen.TableName = "RESUMEN_CORRIENTE"
                ''--------------------------------------------------------
                If dtCtaCte.Rows.Count = 0 Then
                    MessageBox.Show("No hay información con el nro entrega ingresado", "Aviso", MessageBoxButtons.OK)
                    Exit Sub
                End If

                Dim Cod_Unico As String = ""
                Dim ListVisitados As New Hashtable
                For FILA As Integer = 0 To dtCtaCte.Rows.Count - 1
                    Cod_Unico = dtCtaCte.Rows(FILA)("CUBGE1") & "_" & dtCtaCte.Rows(FILA)("CCLNT")
                    If Not ListVisitados.Contains(Cod_Unico) Then
                        ListVisitados.Add(Cod_Unico, 0)
                        drResumen = dtResumen.NewRow
                        drResumen("COD_UNICO") = Cod_Unico
                        drResumen("COD_UB_COBRO") = dtCtaCte.Rows(FILA)("CUBGE1")
                        drResumen("DES_UB_COBRO") = ("" & dtCtaCte.Rows(FILA)("TDPRT")).ToString.Trim & "/" & ("" & dtCtaCte.Rows(FILA)("TPRVN")).ToString.Trim & "/" & ("" & dtCtaCte.Rows(FILA)("TDSTR")).ToString.Trim
                        drResumen("CCLNT") = dtCtaCte.Rows(FILA)("CCLNT")
                        drResumen("CLIENTE") = ("" & dtCtaCte.Rows(FILA)("TCMPCL")).ToString.Trim
                        drResumen("DIRECCION") = ("" & dtCtaCte.Rows(FILA)("TDRCCB")).ToString.Trim
                        drResumen("NUMDOC") = 1
                        dtResumen.Rows.Add(drResumen)
                    Else
                        ActualizarResumenCtaCte(dtResumen, Cod_Unico)
                    End If
                Next
                HelpClass.CrystalReportTextObject(orptCtaCte, "lblUsuario", ConfigurationWizard.UserName)
                HelpClass.CrystalReportTextObject(orptCtaCte, "lblNumDoc", dtCtaCte.Rows.Count)
                orptCtaCte.SetDataSource(dtCtaCte)
                orptCtaCte.Subreports("rptResumen").SetDataSource(dtResumen)
                objPrintForm.StartPosition = FormStartPosition.CenterParent
                objPrintForm.MaximizeBox = True
                objPrintForm.ShowForm(orptCtaCte, Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ActualizarResumenCtaCte(ByRef dtResumen As DataTable, ByVal Cod_Unico As String)
        For Each Item As DataRow In dtResumen.Rows
            If Item("COD_UNICO") = Cod_Unico Then
                Item("NUMDOC") = Item("NUMDOC") + 1
                Exit For
            End If
        Next
    End Sub

    Private Sub txtNrpEntreCob_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrpEntreCob.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub
End Class
