Imports Ransa.DAO
Imports Ransa.DAO.WayBill

Public Class frmGenPallet

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public pCCLNT As Decimal = 0
    Public pNRPLTS As String = ""
    Public GenerarAutomatico As Boolean = False
    Public pDialog As Boolean = False

#Region "Eventos"
    Private Sub frmGenPallet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#End Region


    Private Sub chkAuto_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuto.CheckedChanged

        If chkAuto.Checked = True Then
            txtNroPallet.Enabled = False
        Else
            txtNroPallet.Enabled = True
        End If
    End Sub

    Private Sub btnGenPallet_Click(sender As Object, e As EventArgs) Handles btnGenPallet.Click
        Try
            If chkAuto.Checked = False Then
                GenerarAutomatico = False

                Dim NroPallet As String = txtNroPallet.Text.Trim.ToUpper
                If NroPallet.Length = 0 Then
                    MessageBox.Show("Ingrese número de Pallet")
                    Exit Sub
                End If
                Dim oWayBill As cWayBill = New Ransa.DAO.WayBill.cWayBill
                Dim msg_val As String = oWayBill.fblnValidar_NroPallet(pCCLNT, NroPallet)
                If msg_val.Length > 0 Then
                    MessageBox.Show(msg_val, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                pNRPLTS = NroPallet
                pDialog = True
                Me.Close()
            Else
                GenerarAutomatico = True
                pDialog = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
     


    End Sub
End Class
