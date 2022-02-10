
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmEditPreDoc
    Public pNPRLQD As Decimal = 0
    Public pSubDoc As String = ""
    Public pDoc As String = ""
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pTIPOPL As String = ""
    Public pNCRRPD As Decimal = 0
    'Public pTPDCPE As String = ""
    Public pTPDCPE As String = ""
    Public pUser As String = ""
    Public pMachine As String = ""
    Public pTPCTRL As String = ""
   

    Private Sub frmEditPreDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim OTipoDatoGeneral_BLL As New clsDatoGeneral_BLL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(pCCMPN, "TPDCLT")
            obeTipoDatoGeneral.CODIGO_TIPO = ""
            obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"


          
            cblTipoDoc.SelectedValue = pTPDCPE
            txtDocCliente.Text = pDoc
            txtSubDocCliente.Text = pSubDoc
           
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If cblTipoDoc.SelectedValue <> "" Then
                If txtDocCliente.Text.Trim = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If


            Dim oPreLiquidacion_BLL As New clsPreDoc_BL
            Dim objParam As New Hashtable
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PNNRCTRL", pNPRLQD)
            objParam.Add("PNNCRRPD", pNCRRPD)
            objParam.Add("PSTPCTRL", pTPCTRL)
            objParam.Add("PSTPDCPE", cblTipoDoc.SelectedValue)
            If cblTipoDoc.SelectedValue <> "" Then
                objParam.Add("PSDCCLNT", txtDocCliente.Text.Trim)
                objParam.Add("PSSBCLNT", txtSubDocCliente.Text.Trim)
            Else
                objParam.Add("PSDCCLNT", "")
                objParam.Add("PSSBCLNT", "")
            End If
            objParam.Add("PSCULUSA", pUser)
            objParam.Add("PSNTRMNL", pMachine)
            oPreLiquidacion_BLL.ActualizarPreDocumento(objParam)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Exit Sub
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