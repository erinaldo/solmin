Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmRevisarOCPortalResumen
    Private odtGlobalResumen As DataTable
    Private objPortalDetalle As New SOLMIN_SC.Entidad.bePortalDetalle

    Public Sub New(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        objPortalDetalle = objPD
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'objPortalDetalle.PSTABLA.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub btnRecibido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibido.Click
        If txtCargaRecibida.Text <> "0" Then
            Muestra_Detalle("REOR", "Recibido en Origen")
        Else
            HelpUtil.MsgBox("No hay Informacion por Mostrar")
        End If
    End Sub

    Private Sub btnEmbarcado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmbarcado.Click
        If txtCargaEmbarcada.Text <> "0" Then
            Muestra_Detalle("EMBA", "Embarcado en Origen")
        Else
            HelpUtil.MsgBox("No hay Informacion por Mostrar")
        End If
    End Sub

    Private Sub btnAtendido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtendido.Click
        If txtCargaAtendida.Text <> "0" Then
            Muestra_Detalle("REDE", "ADUANAS")
        Else
            HelpUtil.MsgBox("No hay Informacion por Mostrar")
        End If
    End Sub

    Private Sub btnRecibidoAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibidoAlmacen.Click
        If txtRecibidoAlmacen.Text <> "0" Then
            Muestra_Detalle("REAL", "Recibido en Almacen")
        Else
            HelpUtil.MsgBox("No hay Informacion por Mostrar")
        End If
    End Sub

    Private Sub btntrasladoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrasladoCliente.Click
        If txtCargaTrasladoCliente.Text <> "0" Then
            Muestra_Detalle("TRCL", "Trasladado al Destino Cliente")
        Else
            HelpUtil.MsgBox("No hay Informacion por Mostrar")
        End If
    End Sub
    Private Sub Muestra_Detalle(ByVal tipo As String, ByVal titulo As String)
        Me.Cursor = Cursors.WaitCursor
        objPortalDetalle.PSFILTRO = tipo

        Dim frmDetalle As frmRevisarOCPortalDetalle
        '--------------------------------------------------ACD
        'frmDetalle = New frmRevisarOCPortalDetalle(odtGlobalResumen, tipo)
        '--------------------------------------------------ACD
        frmDetalle = New frmRevisarOCPortalDetalle(objPortalDetalle)
        frmDetalle.HGCabecera.ValuesPrimary.Heading = titulo
        frmDetalle.StartPosition = FormStartPosition.CenterScreen
        frmDetalle.ShowInTaskbar = False
        frmDetalle.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub
End Class
