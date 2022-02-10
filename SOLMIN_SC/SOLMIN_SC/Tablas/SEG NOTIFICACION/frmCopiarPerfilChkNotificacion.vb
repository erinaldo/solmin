Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad


Public Class frmCopiarPerfilChkNotificacion


#Region "Propiedades"


    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PSNLTECL As String
    Public Property PSNLTECL() As String
        Get
            Return _PSNLTECL
        End Get
        Set(ByVal value As String)
            _PSNLTECL = value
        End Set
    End Property


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


#End Region

    Private Sub frmCopiarPerfilChkNotificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarCliente()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese un Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ListarCheckPointsNotificacion()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            dgvChkNotificacion.EndEdit()
            If dgvChkNotificacion.Rows.Count > 0 Then
                Dim brSegNotificacion As New Negocio.clsSegNotificacion
                Dim dt As New DataTable
                Dim beSegNotificacion As beSegNotificacion
                Dim countn As Integer = 0
                For Each Fila As DataGridViewRow In dgvChkNotificacion.Rows

                    If Fila.Cells("Chk").Value = True Then
                        beSegNotificacion = New beSegNotificacion
                        With beSegNotificacion
                            .PSCCMPN = PSCCMPN
                            .PSCDVSN = PSCDVSN
                            .PNCCLNT = PNCCLNT
                            .PSNLTECL = PSNLTECL
                            .PSCODFMT = Fila.Cells("CODFMT").Value
                            .PNNESTDO = Fila.Cells("NESTDO").Value
                            .PSTCOLUM = Fila.Cells("TCOLUM").Value
                            .PNNSEPRE = Fila.Cells("NSEPRE").Value
                            .PSCFMCHK = "" ' fila.Cells(" ").Value  fila("FLGEST")
                            .PSFLGEST = Fila.Cells("FLGEST").Value
                            .PSFLGNTE = Fila.Cells("FLGNTE").Value
                            .PSCULUSA = HelpUtil.UserName
                        End With
                        brSegNotificacion.RegistarCheckPointsNotificacionEmail(beSegNotificacion)
                        countn = countn + 1
                    End If
                Next
                If countn > 0 Then
                    DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("seleccione al menos un registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#Region "Metodos y Funciones"

    Private Sub ListarCliente()
        txtCliente.pAccesoPorUsuario = False
        txtCliente.pRequerido = False
        txtCliente.pUsuario = HelpUtil.UserName
    End Sub

    Private Sub ListarCheckPointsNotificacion()
        Dim brSegNotificacion As New Negocio.clsSegNotificacion
        Dim dt As New DataTable
        Dim beSegNotificacion As New beSegNotificacion
        With beSegNotificacion
            .PSCCMPN = PSCCMPN
            .PSCDVSN = PSCDVSN
            .PNCCLNT = txtCliente.pCodigo
            .PSNLTECL = PSNLTECL
        End With
        dt = brSegNotificacion.ListarCheckPointsNotificacion(beSegNotificacion)
        dgvChkNotificacion.AutoGenerateColumns = False
        dgvChkNotificacion.DataSource = dt
    End Sub
#End Region


End Class
