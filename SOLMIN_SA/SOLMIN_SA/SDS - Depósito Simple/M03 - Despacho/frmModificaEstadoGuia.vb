Imports RANSA.NEGO
Imports RANSA.TypeDef
Public Class frmModificaEstadoGuia
    Public _obeGuiaRemision As New beGuiaRemision
    Private Sub frmModificaEstadoGuia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llena_Estado()
    End Sub
    Private Sub Llena_Estado()
        Dim oDtEstado As New DataTable
        Dim oDtAux As New DataTable
        oDtEstado = New DespachoSAT.brGuiasRemision().finListaEstadoGuiaRemision()

        oDtEstado.DefaultView.RowFilter = "CCMPRN NOT IN ( '" & CodigoEstado(lblEstado.Text) & "' )"
        oDtEstado = oDtEstado.DefaultView.ToTable
        Me.cboEstado.DataSource = oDtEstado
        Me.cboEstado.ValueMember = "CCMPRN"
        Me.cboEstado.DisplayMember = "TDSDES"

    End Sub
    Private Function CodigoEstado(ByVal strEstado As String)
        Dim CodEstado As String = String.Empty
        Select Case strEstado
            Case "EMITIDA"
                CodEstado = ""

            Case "EN TRANSITO"
                CodEstado = "T"

            Case "EN CLIENTE"
                CodEstado = "E"

            Case "EMITIDA"
                CodEstado = "C"

            Case "EN RANSA"
                CodEstado = "R"

        End Select
        Return CodEstado
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim nRetorno As Integer = 0
        _obeGuiaRemision.PSSESDCM = cboEstado.SelectedValue.ToString
        nRetorno = New DespachoSAT.brGuiasRemision().fintActualizarEstadoGuias(_obeGuiaRemision)
        If nRetorno = 0 Then
            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
