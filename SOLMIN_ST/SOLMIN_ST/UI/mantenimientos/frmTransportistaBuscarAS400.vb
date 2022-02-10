Public Class frmTransportistaBuscarAS400
    Public pCCMPN As String = ""

    Public pCTRSPT As Decimal = 0
    Public pTCMTRT As String = ""
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Dim TotPag As Decimal = 0
            UcPaginacion1.PageNumber = 1
            Listar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Listar()
        gwdDatos.DataSource = Nothing
        Dim TotPag As Decimal = 0
        Dim obrTransportistaAS400_BLL As New NEGOCIO.mantenimientos.TransportistaAS400_BLL
        Dim dtAS400 As New DataTable
        Dim obj As New ENTIDADES.mantenimientos.Transportista
        obj.CTRSPT = Val(txtcod.Text.Trim)
        obj.NRUCTR = txtruc.Text.Trim.ToUpper
        obj.TCMTRT = txtrazonsocial.Text.Trim.ToUpper
        obj.CCMPN = pCCMPN
        dtAS400 = obrTransportistaAS400_BLL.Listar_TransportistaAS400_RZTR10(obj, UcPaginacion1.PageNumber, UcPaginacion1.PageSize, TotPag)
        UcPaginacion1.PageCount = TotPag
        gwdDatos.DataSource = dtAS400
    End Sub

    Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim msg As String = "Transportista seleccionado no cuenta con código SAP" & Chr(13) & "Está seguro de seleccionar?"
            If ("" & gwdDatos.CurrentRow.Cells("RUCPR2").Value).ToString.Trim = "" Then
                If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            pCTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
            pTCMTRT = ("" & gwdDatos.CurrentRow.Cells("TCMTRT").Value).ToString.Trim
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub gwdDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim msg As String = "Transportista seleccionado no cuenta con código SAP" & Chr(13) & "Está seguro de seleccionar?"
            If ("" & gwdDatos.CurrentRow.Cells("RUCPR2").Value).ToString.Trim = "" Then
                If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            pCTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
            pTCMTRT = ("" & gwdDatos.CurrentRow.Cells("TCMTRT").Value).ToString.Trim
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTransportistaBuscarAS400_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gwdDatos.AutoGenerateColumns = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNroRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress, txtruc.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub txtFiltroTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown, txtruc.KeyDown, txtrazonsocial.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Enter
                    UcPaginacion1.PageNumber = 1
                    Listar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class