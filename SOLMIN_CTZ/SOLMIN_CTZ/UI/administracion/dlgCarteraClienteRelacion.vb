Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class dlgCarteraClienteRelacion
    Private oClienteNeg As New clsCliente
    Private oCliente As New Cliente
    Private frmCliente As frmCarteraCliente
    Sub New(ByVal pobjfrm As frmCarteraCliente)

        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
        frmCliente = New frmCarteraCliente
        frmCliente = pobjfrm
    End Sub

    Private Sub btnCancelarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarRelacion.Click
        Me.Close()
    End Sub

    Private Sub btnGuardarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarRelacion.Click
        oCliente.CCLNT = UcCliente.pCodigo
        oCliente.NRCTCL = txtCodGrupoCliente.Text
        Try
            If oCliente.CCLNT <> 0 Then
                If oCliente.NRCTCL <> 0 Then
                    oClienteNeg.Agregar_Cliente_Cartera_Relacion(oCliente)
                    If oCliente.Correcto = 1 Then
                        MsgBox("Se guardo con �xito el registro", MsgBoxStyle.Information, "Mensaje De Informaci�n")
                    Else
                        MsgBox("No se pudo registrar la relaci�n", MsgBoxStyle.Information, "Mensaje De Informaci�n")
                    End If
                    frmCliente.Buscar_Cartera_Cliente()
                    Me.Close()
                Else
                    MsgBox("Debe Seleccionar Un Grupo Cliente", MsgBoxStyle.Information, "Mensaje De Informaci�n")
                End If
            Else
                MsgBox("Debe Seleccionar Un Cliente", MsgBoxStyle.Information, "Mensaje De Informaci�n")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub dlgCarteraClienteRelacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
