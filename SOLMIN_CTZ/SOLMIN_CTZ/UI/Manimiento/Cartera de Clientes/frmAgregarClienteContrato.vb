Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Public Class frmAgregarClienteContrato

    Public pCCMPN As String = ""
    Public pNRCTCL As Decimal = 0
    Public pNRCTSL As Decimal = 0
    Public pDialog As Boolean = False
    Public pClienteEnLista As New List(Of String)
    Private Sub frmAgregarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_ClientesXGrupo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '</[AHM]>

    Private Sub Cargar_ClientesXGrupo()
        'Cargar Cliente 
        Dim oCliente As New clsCliente
        Dim obeCliente As New Cliente
        obeCliente.CCMPN = pCCMPN
        obeCliente.NRCTCL = pNRCTCL
        dtgRelacionCliente.AutoGenerateColumns = False

        Dim oList As New List(Of Cliente)
        Dim oListFinal As New List(Of Cliente)
        oList = oCliente.floListaClienteXGrupo(obeCliente)

        For Each item As Cliente In oList
            If pClienteEnLista.Contains(item.CCLNT.ToString) = False Then
                oListFinal.Add(item)
            End If
        Next
        Me.dtgRelacionCliente.DataSource = oListFinal
        'Me.dtgRelacionCliente.DataSource = oCliente.floListaClienteXGrupo(obeCliente)


    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    

    


    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        Try
            Dim obrContrato As New clsContrato
            Dim olisClienteContrato As New List(Of SOLMIN_CTZ.Entidades.Contrato)
            Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
            dtgRelacionCliente.EndEdit()


            For intX As Integer = 0 To Me.dtgRelacionCliente.RowCount - 1
                If dtgRelacionCliente.Rows(intX).Cells("Chk").Value Then
                    oContrato = New SOLMIN_CTZ.Entidades.Contrato
                    oContrato.NRCTSL = pNRCTSL
                    oContrato.CCMPN = pCCMPN
                    oContrato.CCLNT = dtgRelacionCliente.Rows(intX).Cells("CCLNT_R").Value
                    olisClienteContrato.Add(oContrato)

                End If

            Next
            If olisClienteContrato.Count = 0 Then
                MessageBox.Show("No ha seleccionado clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            pDialog = True
            If obrContrato.fIntInsertarClienteXContrato(olisClienteContrato) = -1 Then
                MessageBox.Show("Error al guardar los clientes del contrato", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            MessageBox.Show("Clientes fueron adicionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
End Class
