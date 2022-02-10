Imports RANSA.NEGO
Public Class frmRelClienteTerceroCMasivo

   
 

#Region "Eventos"

    Private Sub frmListaClienteTercero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgPlantaCliente.AutoGenerateColumns = False
            'Dim objAppConfig As cAppConfig = New cAppConfig
            'Dim intTemp As Int64 = 0
            'Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            'txtCliente.pCargar(ClientePK)
            'CargarControles()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub


 

 

   

#End Region
 
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Listar_Lista_Proveedores()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Listar_Lista_Proveedores()
        Dim obr As New brPlantaClienteProveedor()
        Dim dt As New DataTable
        Dim pCod As Decimal = txtCliente.pCodigo
        Dim Ruc As String = txtRuc.Text.Trim.ToUpper
        Dim RazonSocial As String = txtProveedor.Text.Trim.ToUpper
        Dim CantPag As Decimal = 0
        Dim CodProvCliente As String = txtCodProvCliente.Text.ToUpper

        dt = obr.Listado_Planta_x_Cliente_Tercero_RZOL05A(pCod, Ruc, RazonSocial, CodProvCliente, ucpPaginacion.PageNumber, ucpPaginacion.PageSize, CantPag)
        ucpPaginacion.PageCount = CantPag
        dgPlantaCliente.DataSource = dt
    End Sub

    Private Sub ucpPaginacion_PageChanged(sender As Object, e As EventArgs) Handles ucpPaginacion.PageChanged
        Try
            Listar_Lista_Proveedores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            dgPlantaCliente.EndEdit()
            Dim cant_reg As Decimal = 0
            For Each item As DataGridViewRow In dgPlantaCliente.Rows
                If item.Cells("CHK").Value = True Then
                    cant_reg = cant_reg + 1
                End If
            Next
            If cant_reg = 0 Then
                MessageBox.Show("No ha seleccionado registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Está seguro de anular la relación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                Exit Sub
            End If

            Dim obr As New brPlantaClienteProveedor()
            Dim pCodCliente As Decimal = 0
            Dim CodProvCliente As String = ""

            Dim msg As String = ""
            For Each item As DataGridViewRow In dgPlantaCliente.Rows
                If item.Cells("CHK").Value = True Then
                    pCodCliente = item.Cells("CCLNT").Value
                    CodProvCliente = item.Cells("CPRPCL").Value
                    msg = msg & obr.EliminarRelacionTercero_RZOL05A(pCodCliente, CodProvCliente) & Chr(10)
                    msg = msg.Trim
                End If
            Next
            If msg.Length = 0 Then
                MessageBox.Show("Relación anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listar_Lista_Proveedores()
            Else
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            If txtCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim ofrmCMasivaCodProvClienteRZOL05A As New frmCMasivaCodProvClienteRZOL05A
            ofrmCMasivaCodProvClienteRZOL05A.ShowDialog()
            If ofrmCMasivaCodProvClienteRZOL05A.pDialog = True Then
                Listar_Lista_Proveedores()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
