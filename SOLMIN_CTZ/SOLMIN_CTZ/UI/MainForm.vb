Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = HelpClass.getSetting("Titulo")
        Me.lblStatusBar.Text = HelpClass.getSetting("Titulo")
        Me.MenuSolmin1.ImageBind = Me.ImageList1
        Me.SolminToolBar1.DataBind = True
        Me.MenuSolmin1.DataBind = True
        Ransa.Utilitario.MainModuleDeploy.SetQueryStringParametersDeploy()

    End Sub

    Private Sub LoadForm(ByVal objForm As Form)
        objForm.MdiParent = Me
        objForm.WindowState = FormWindowState.Maximized
        objForm.BringToFront()
        objForm.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem1.Click
        'LoadForm(New frmReportes())
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not Existe_Ventana("frmContrato") Then
        '    LoadForm(New frmContrato())
        'End If
        'If Not Existe_Ventana("frmNewContrato") Then
        '    LoadForm(New frmNewContrato())
        'End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Existe_Ventana("frmReportes") Then
            'LoadForm(New frmReportes())
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Existe_Ventana("frmServicio") Then
            'LoadForm(New frmServicio())
        End If
    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.MdiChildren(intCont).Activate()
                Return True
            End If
        Next intCont

        Return False
    End Function

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not Existe_Ventana("frmEstructura") Then
        '    LoadForm(New frmEstructura())
        'End If
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
        'If Not Existe_Ventana("frmNewContrato") Then
        '    LoadForm(New frmNewContrato())
        'End If
    End Sub

    Private Sub TarifarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarifarioToolStripMenuItem.Click
        'If Not Existe_Ventana("frmEstructura") Then
        '    LoadForm(New frmEstructura())
        'End If
    End Sub
End Class
