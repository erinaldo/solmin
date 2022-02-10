Imports SOLMIN_SC.Negocio
Imports System.Web
Public Class frmProveedor_UC
    'Private oCliente As Negocio.clsCliente
    Private CCLNT As Decimal = 0

    Private Sub ActualizarLista()
        If (cmbCliente.pCodigo = 0) Then
            MessageBox.Show("Seleccione Cliente", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        UcProveedor_DgCab1.pCCLNT = cmbCliente.pCodigo
        UcProveedor_DgCab1.pNRUCPRSTR = txtRUC.Text.Trim
        UcProveedor_DgCab1.pUsuario = HelpUtil.UserName
        UcProveedor_DgCab1.pPSTPRVCL = txtDescripcion.Text.Trim
        UcProveedor_DgCab1.pMostrarTituloOpcion1 = True
        UcProveedor_DgCab1.ActualizarListaProveedor()
        CCLNT = cmbCliente.pCodigo
    End Sub
    Private Sub frmProveedor_UC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'oCliente = New clsCliente
            'oCliente.Lista = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente).Lista.Copy
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
    Private Sub cmbCliente_ExitFocusWithOutData() Handles cmbCliente.ExitFocusWithOutData
        If (CCLNT <> cmbCliente.pCodigo) Then ' verifica que verdaderamente ha cambiado de cliente
            UcProveedor_DgCab1.DataSourceNothing(True)
        End If
    End Sub

    Private Sub cmbCliente_InformationChanged() Handles cmbCliente.InformationChanged
        If (CCLNT <> cmbCliente.pCodigo) Then ' verifica que verdaderamente ha cambiado de cliente
            UcProveedor_DgCab1.DataSourceNothing(True)
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                ActualizarLista()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRUC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUC.KeyPress
        Try

            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                ActualizarLista()
            Else
                If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                    e.Handled = True
                End If
                Select Case AscW(e.KeyChar)
                    Case 8
                        e.Handled = False
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
  '    Try
  '        ActualizarLista()
  '    Catch ex As Exception
  '    End Try
  'End Sub

  Private Sub UcProveedor_DgCab1_Buscar() Handles UcProveedor_DgCab1.Buscar
    Try
      ActualizarLista()
    Catch ex As Exception
    End Try
  End Sub
End Class
