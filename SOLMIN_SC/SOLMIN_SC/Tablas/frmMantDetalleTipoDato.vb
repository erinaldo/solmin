Imports SOLMIN_SC.Entidad.beTipoDato
Public Class frmMantDetalleTipoDato
    Private objTipoDato As SOLMIN_SC.Entidad.beTipoDato
    Private TipoOperacion As Integer = 0
    Public Sub New(ByVal oTipoDato As SOLMIN_SC.Entidad.beTipoDato)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objTipoDato = oTipoDato
        If objTipoDato.PNNCODRG = 0 Then
            TipoOperacion = 1 '------Inserta--------
        Else
            TipoOperacion = 2 '------Modificar------
        End If
        If TipoOperacion = 2 Then '----------Modificar
            txtTipo.Text = objTipoDato.PNNTPODT
            txtCodigoDetalle.Text = objTipoDato.PNNCODRG
            txtDescripcion.Text = objTipoDato.PSTDSCRG.Trim

            Dim ocliente As New Ransa.Controls.Cliente.TD_ClientePK
            ocliente.pCCLNT_Cliente = objTipoDato.PNCCLNT
            UcCliente.pCargar(ocliente.pCCLNT_Cliente)
            txtValor.Text = objTipoDato.PNQCNTN
        Else
            txtTipo.Text = objTipoDato.PNNTPODT
        End If
    End Sub

    Private Sub txtDescripcion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.Validated
        txtDescripcion.Text = txtDescripcion.Text.ToUpper
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmMantenimientoTipoDato.Carga_TipoDatoDetalle(objTipoDato)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtDescripcion.Text = "" Then
            HelpUtil.MsgBox("Debe Llenar campo descripción")
            Exit Sub
        End If
        If txtValor.Text = "" Then
            txtValor.Text = 0
        End If
        Try
            Dim objTipoDatoNeg As New SOLMIN_SC.Negocio.clsTipoDato
            If TipoOperacion = 2 Then
                objTipoDato.PNNTPODT = txtTipo.Text.Trim
                objTipoDato.PNNCODRG = txtCodigoDetalle.Text.Trim
                objTipoDato.PNCCLNT = UcCliente.pCodigo
                objTipoDato.PSTDSCRG = txtDescripcion.Text.ToUpper.Trim
                objTipoDato.PNQCNTN = txtValor.Text.Trim
                objTipoDatoNeg.Actualiza_TipoDatoDetalle(objTipoDato)
            Else
                objTipoDato.PNNTPODT = CInt(txtTipo.Text.Trim)
                ' objTipoDato.PNNCODRG = CInt(txtCodigoDetalle.Text.Trim)
                objTipoDato.PNCCLNT = UcCliente.pCodigo
                objTipoDato.PSTDSCRG = txtDescripcion.Text.ToUpper.Trim
                objTipoDato.PNQCNTN = CInt(txtValor.Text.Trim)
                objTipoDatoNeg.Inserta_TipoDatoDetalle(objTipoDato)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            HelpUtil.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtValor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged
        If txtValor.Text <> "" Then
            If Not IsNumeric(txtValor.Text) Then
                txtValor.Text = ""
            End If
        End If
    End Sub

End Class
