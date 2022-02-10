Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Public Class frmEditPLDOCvb
    Public pNPRLQD As Decimal = 0
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cblTipoDoc.SelectedValue <> "" Then
                If txtDocCliente.Text.Trim = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
          

            Dim oPreLiquidacion_BLL As New PreLiquidacion_BLL
            Dim objParam As New Hashtable
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PSCDVSN", pCDVSN)
            objParam.Add("PNNPRLQD", pNPRLQD)
            objParam.Add("PSTPDCPE", cblTipoDoc.SelectedValue)
            If cblTipoDoc.SelectedValue <> "" Then
                objParam.Add("PSDCCLNT", txtDocCliente.Text.Trim)
                objParam.Add("PSSBCLNT", txtSubDocCliente.Text.Trim)
            Else
                objParam.Add("PSDCCLNT", "")
                objParam.Add("PSSBCLNT", "")
            End If
            objParam.Add("PSCULUSA", MainModule.USUARIO)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            oPreLiquidacion_BLL.ActualizarDatosAdPreLiquidacion(objParam)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEditPLDOCvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim OTipoDatoGeneral_BLL As New TipoDatoGeneral_BLL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(pCCMPN, "TPDCLT")
            obeTipoDatoGeneral.CODIGO_TIPO = ""
            obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"
            cblTipoDoc.SelectedValue = ""

            Dim dt As New DataTable
            Dim oPreLiquidacion_BLL As New PreLiquidacion_BLL
            Dim objParam As New Hashtable
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PNNPRLQD", pNPRLQD)

            dt = oPreLiquidacion_BLL.ListaDatosAdPreLiquidacion(objParam)
            If dt.Rows.Count > 0 Then
                cblTipoDoc.SelectedValue = ("" & dt.Rows(0)("TPDCPE")).ToString.Trim
                txtDocCliente.Text = ("" & dt.Rows(0)("DCCLNT")).ToString.Trim
                txtSubDocCliente.Text = ("" & dt.Rows(0)("SBCLNT")).ToString.Trim
            End If
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted
        Try
            txtDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
            txtSubDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class