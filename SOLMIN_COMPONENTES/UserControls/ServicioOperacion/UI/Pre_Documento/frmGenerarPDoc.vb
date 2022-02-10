
Imports Ransa.Controls.ServicioOperacion.frmGenerarPreDoc
 
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmGenerarPDoc

    Public desMon As String = ""
    Public Simporte As Decimal = 0
    Public ListPre_Doc As List(Of PreDoc_BE)
    Public pCCMPN As String = ""
    Public pCodMoneda As Decimal = 0
    Public pNRLQD As Decimal = 0
    Public pTIPOPL As String = ""   


    Private ListPre_DocFinal As New List(Of PreDoc_BE)
    Private Sub frmGenerarPDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pTotal As Decimal = 0
            Dim OTipoDatoGeneral_BLL As New clsDatoGeneral_DAL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(pCCMPN, "TPDCLT")  'OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(_CCMPN_1, "TPDCLT")
            obeTipoDatoGeneral.CODIGO_TIPO = ""
            obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"

            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"
            cblTipoDoc.SelectedValue = ""
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)

            txtMon.Text = desMon

            txtImporte.Text = frmGenerarPreDoc.TotalGenerarPreDoc
            dtgOpPendientes.AutoGenerateColumns = False


            Dim oListMenoresPreDoc_BE As New List(Of PreDoc_BE)
            Dim ImporteMenores As Decimal = 0
            Dim CantList As Integer = 0

            For Each item As PreDoc_BE In ListPre_Doc
                If item.PNIVLSRV < 1 Then
                    oListMenoresPreDoc_BE.Add(item)
                Else
                    ListPre_DocFinal.Add(item)
                End If
            Next

            For Each item As PreDoc_BE In oListMenoresPreDoc_BE
                ImporteMenores = ImporteMenores + item.PNIVLSRV
            Next

            CantList = ListPre_DocFinal.Count
            If CantList > 0 Then
                ListPre_DocFinal(CantList - 1).PNIVLSRV = ListPre_DocFinal(CantList - 1).PNIVLSRV + ImporteMenores
            End If

            'dtgOpPendientes.DataSource = ListPre_Doc
            dtgOpPendientes.DataSource = ListPre_DocFinal

            For intIndice As Integer = 0 To dtgOpPendientes.RowCount - 1
                pTotal = pTotal + dtgOpPendientes.Item("PNIMDOC", intIndice).Value
            Next
            txtImporte.Text = pTotal




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnProcesar_Click_1(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try

            If cblTipoDoc.SelectedValue <> "" Then
                If txtOC.Text = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            Dim oPreDocCab As New PreDoc_BE


            Dim obrPreDocCab As New clsPreDoc_BL
           
            Dim msg As String = ""
            Dim pNCRPD As Decimal = 0

            oPreDocCab.PSCCMPN = pCCMPN
            oPreDocCab.PNNRCTRL = pNRLQD
            oPreDocCab.PSTIPOPL = pTIPOPL
            oPreDocCab.PNCMNDA1 = pCodMoneda
            oPreDocCab.PSTPDCPE = cblTipoDoc.SelectedValue.ToString.Trim
            oPreDocCab.PSDCCLNT = txtOC.Text.Trim
            oPreDocCab.PSSBCLNT = txtDocRef.Text.Trim
            oPreDocCab.PSCULUSA = ConfigurationWizard.UserName
            oPreDocCab.PSNTRMNL = HelpClass.NombreMaquina
            oPreDocCab.PSTOBS = ""        
            If cblTipoDoc.SelectedValue <> "" Then
                oPreDocCab.PSDCCLNT = txtOC.Text.Trim
                oPreDocCab.PSSBCLNT = txtDocRef.Text.Trim
            End If
            msg = obrPreDocCab.RegistrarCabeceraPDoc(oPreDocCab, pNCRPD)

            If msg.Length = 0 Then
                'For Each item As PreDoc_BE In ListPre_Doc
                For Each item As PreDoc_BE In ListPre_DocFinal
                    msg = obrPreDocCab.RegistrarDetallePDoc(item, pNCRPD)
                Next
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'frmGenerarPreDoc.txtTotalG.Text = 0

            Else
                MessageBox.Show("No se pudo registrar" & Chr(13) & msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted

        Try
            txtOC.Enabled = (cblTipoDoc.SelectedValue <> "")
            txtDocRef.Enabled = (cblTipoDoc.SelectedValue <> "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class