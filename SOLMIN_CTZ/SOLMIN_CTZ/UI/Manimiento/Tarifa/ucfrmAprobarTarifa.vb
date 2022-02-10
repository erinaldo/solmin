Imports System.Windows.Forms
Imports System.Drawing
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class ucfrmAprobarTarifa

    Public AprobSugerido As String = ""
    Public MrgAprobacion As Double = 0
    Public pDialog As Boolean = False
  
    
    Private Sub ucfrmAprobarTarifa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.txtAprobSugerido.Text = ""
        Me.txtMrgAprobacion.Text = ""
        Me.txtAprobadorPor.Text = ""
        Me.txtAprobSugerido.Text = AprobSugerido
        Me.txtMrgAprobacion.Text = Format(Val(CDec(MrgAprobacion)), "##0.00000")
        Me.txtObs.Text = ""
    End Sub
   
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If txtAprobadorPor.Text = "" Then
                MessageBox.Show("Ingresar Aprobador", "Aprobar Tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf dtFeInicial.Text = "" Then
                MessageBox.Show("Ingresar Fecha de Aprobación", "Aprobar Tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Dim objTarifa As New Tarifa
            'Dim obrTarifa As New clsTarifa
            'With objTarifa
            '    .CCMPN = Compania
            '    .NRCTSL = IdContrato
            '    .NRTFSV = IdTarifa
            '    .APRBTF = Me.txtAprobadorPor.Text
            '    .FCHAPR = Format(CDate(Me.dtFeInicial.Text), "yyyyMMdd")
            '    .OBSAPR = Me.txtObs.Text
            'End With
            'If (obrTarifa.Actualizar_Estado_OS(objTarifa) = 1) Then
            '    MessageBox.Show("Aprobado", "Aprobar Tarifa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Dim oFrmPadre As New frmAprobarTarifa()
            '    oFrmPadre = _oFrmPadre
            '    oFrmPadre.Lista_Cotizacione_Por_Aprobar()
            '    Me.Close()
            'End If
            pDialog = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class