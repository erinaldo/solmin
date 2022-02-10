Public Class frmEditDocSubDocCliente


    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pCCLNT As Decimal = 0
    Public pListConsistencia As String = ""
    Private Sub frmEditDocSubDocCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ListarTipoDocAprobacionCliente
            Dim oclsServicio_BL As New clsServicio_BL
            Dim dt As New DataTable
            Dim dr As DataRow
            'Dim OTipoDatoGeneral_BLL As New TipoDatoGeneral_BLL
            'Dim obeTipoDatoGeneral As New TipoDatoGeneral
            'Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            dt = oclsServicio_BL.ListarTipoDocAprobacionCliente()
            dr = dt.NewRow
            dr("CODIGO_TIPO") = ""
            dr("DESC_TIPO") = "::Seleccione::"
            dt.Rows.InsertAt(dr, 0)
            'obeTipoDatoGeneral.DIGO_TIPO = ""
            'obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            'oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = dt
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"
            cblTipoDoc.SelectedValue = ""

            'Dim dt As New DataTable
            'Dim oPreLiquidacion_BLL As New PreLiquidacion_BLL
            'Dim objParam As New Hashtable
            'objParam.Add("PSCCMPN", pCCMPN)
            'objParam.Add("PNNPRLQD", pNPRLQD)

            'dt = oPreLiquidacion_BLL.ListaDatosAdPreLiquidacion(objParam)
            'If dt.Rows.Count > 0 Then
            '    cblTipoDoc.SelectedValue = ("" & dt.Rows(0)("TPDCPE")).ToString.Trim
            '    txtDocCliente.Text = ("" & dt.Rows(0)("DCCLNT")).ToString.Trim
            '    txtSubDocCliente.Text = ("" & dt.Rows(0)("SBCLNT")).ToString.Trim
            'End If
            'cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'If cblTipoDoc.SelectedValue <> "" Then
            '    If txtDocCliente.Text.Trim = "" Then
            '        MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'End If
            If cblTipoDoc.SelectedValue = "" Then
                MessageBox.Show("Seleccione/Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim strTipoDoc As String = ""
            Dim DocCliente As String = ""
            Dim SubDocCliente As String = ""
            Dim user As String = ""
            Dim terminal As String = ""
            Dim msgError As String = ""
            Dim oclsServicio_BL As New clsServicio_BL
            Dim objParam As New Hashtable
            strTipoDoc = cblTipoDoc.SelectedValue
            DocCliente = txtDocCliente.Text.Trim
            SubDocCliente = txtSubDocCliente.Text.Trim
            user = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
            terminal = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server
            msgError = oclsServicio_BL.AsignarDocumentoAprobacionCliente(pCCMPN, pCCLNT, pListConsistencia, strTipoDoc, DocCliente, SubDocCliente, user, terminal)
            If msgError.Length > 0 Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted
    '    Try
    '        txtDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
    '        txtSubDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class