Imports SOLMIN_SC.Negocio

Public Class frmCheckPoint
    Private oCliente As clsCliente
    Private oCheckPoint As clsCheckPoint
    Private bolBuscarCheck As Boolean
    Private strAccion As String
    Private strSeguimiento As String

    Sub New(ByVal pobj As DataTable, ByVal pstrComp As String, ByVal pstrNomComp As String, ByVal pstrDiv As String, ByVal pstrNomDiv As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oCliente = New clsCliente
        oCliente.Lista = pobj
        oCheckPoint = New clsCheckPoint()
        oCheckPoint.Compania = pstrComp
        oCheckPoint.Division = pstrDiv
        oCheckPoint.Crea_Lista()
        Me.KryptonSplitContainer2.Panel2Collapsed = True
        Me.txtComp.Text = pstrNomComp
        Me.txtDiv.Text = pstrNomDiv
    End Sub

    Private Sub frmCheckPoint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbCliente.DataSource = oCliente.Lista
        bolBuscarCheck = False
        cmbCliente.ValueMember = "CCLNT"
        bolBuscarCheck = True
        cmbCliente.DisplayMember = "TCMPCL"

        Crear_Arbol()
        Me.tvwCheckPoint.ExpandAll()
    End Sub

    Private Sub Crear_Arbol()
        Dim tndNodo As TreeNode
        Dim lintCont As Integer

        Me.tvwCheckPoint.Nodes(0).Nodes(0).Nodes.Clear()
        Me.tvwCheckPoint.Nodes(0).Nodes(1).Nodes.Clear()

        With CType(oCheckPoint.Lista, DataTable)
            For lintCont = 0 To .Rows.Count - 1
                If .Rows(lintCont).Item("SESTRG") = "A" Then
                    tndNodo = New TreeNode(.Rows(lintCont).Item("TDESES"), 4, 4)
                Else
                    tndNodo = New TreeNode(.Rows(lintCont).Item("TDESES"), 5, 5)
                End If
                Dim obj(2) As Object
                obj(0) = .Rows(lintCont).Item("NESTDO").ToString.Trim
                obj(1) = .Rows(lintCont).Item("TABRST").ToString.Trim
                obj(2) = .Rows(lintCont).Item("TDESES").ToString.Trim
                tndNodo.Tag = obj
                tndNodo.Name = .Rows(lintCont).Item("NESTDO").ToString.Trim
                If .Rows(lintCont).Item("CEMB") = "P" Then
                    Me.tvwCheckPoint.Nodes(0).Nodes(0).Nodes.Add(tndNodo)
                Else
                    If .Rows(lintCont).Item("CEMB") = "A" Then
                        Me.tvwCheckPoint.Nodes(0).Nodes(1).Nodes.Add(tndNodo)
                    End If
                End If
            Next lintCont
        End With
    End Sub

    Private Sub tvwCheckPoint_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwCheckPoint.MouseDown
        Me.KryptonSplitContainer2.Panel2Collapsed = True
        strAccion = ""
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmsArbol.Items(0).Visible = False
            Me.cmsArbol.Items(1).Visible = False
            Me.cmsArbol.Items(2).Visible = False
            Me.cmsArbol.Items(3).Visible = False
            Me.cmsArbol.Items(4).Visible = False
            If Me.tvwCheckPoint.SelectedNode.Name = "CI" Or Me.tvwCheckPoint.SelectedNode.Name = "AD" Then
                Me.cmsArbol.Items(0).Visible = True
            Else
                If Me.tvwCheckPoint.SelectedNode.Name = "Raiz" Then
                    Exit Sub
                Else
                    If Me.tvwCheckPoint.SelectedNode.ImageIndex = 4 Then
                        Me.cmsArbol.Items(1).Visible = True
                        Me.cmsArbol.Items(2).Visible = True
                        Me.cmsArbol.Items(4).Visible = True
                    Else
                        Me.cmsArbol.Items(3).Visible = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.KryptonSplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        strAccion = "I" 'Insertar
        Me.txtCheck.Text = ""
        Me.txtSeg.Text = Me.tvwCheckPoint.SelectedNode.Text
        Me.KryptonSplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        strAccion = "U" 'Editar
        Me.txtCheck.Text = Me.tvwCheckPoint.SelectedNode.Text.Trim
        Me.txtSeg.Text = Me.tvwCheckPoint.SelectedNode.Parent.Text.Trim
        Me.KryptonSplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub ActivarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarToolStripMenuItem.Click
        Try
            strAccion = ""
            If HelpClass.RspMsgBox("Está seguro de activar el CheckPoint?") = Windows.Forms.DialogResult.Yes Then
                oCheckPoint.Mant_CheckPoint("U", Me.tvwCheckPoint.SelectedNode.Tag(0), Me.tvwCheckPoint.SelectedNode.Text.Trim, "*", "A")
                HelpClass.MsgBox("Se activó correctamente el checkpoint")
                oCheckPoint.Crea_Lista()
                Crear_Arbol()
                Me.tvwCheckPoint.ExpandAll()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DesactivarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesactivarToolStripMenuItem.Click
        Try
            strAccion = ""
            If HelpClass.RspMsgBox("Está seguro de desactivar el CheckPoint?") = Windows.Forms.DialogResult.Yes Then
                oCheckPoint.Mant_CheckPoint("U", Me.tvwCheckPoint.SelectedNode.Tag, Me.tvwCheckPoint.SelectedNode.Text.Trim, "*", "*")
                HelpClass.MsgBox("Se desactivó correctamente el checkpoint")
                oCheckPoint.Crea_Lista()
                Crear_Arbol()
                Me.tvwCheckPoint.ExpandAll()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AsignarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarToolStripMenuItem.Click
        Try
            strAccion = ""
            If Verificar_Nodo Then
                If HelpClass.RspMsgBox("Está seguro de asignar el CheckPoint al cliente?") = Windows.Forms.DialogResult.Yes Then
                    oCheckPoint.Mant_CheckPoint_X_Cliente("I", Double.Parse(cmbCliente.SelectedValue.ToString.Trim), Double.Parse(Me.tvwCheckPoint.SelectedNode.Tag(0)), Me.tvwCheckPoint.SelectedNode.Tag(1), Me.tvwCheckPoint.SelectedNode.Tag(2), 1)
                    HelpClass.MsgBox("Se agregó el checkpoint correctamente")
                    oCheckPoint.Crea_Lista_X_Cliente(Double.Parse(cmbCliente.SelectedValue.ToString.Trim))
                    Crear_Arbol_Cliente()
                End If
            Else
                HelpClass.MsgBox("El checkpoint ya está asignado al cliente")
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Verificar_Nodo() As Boolean
        If Me.tvwCI.Nodes(0).Nodes.Find(Me.tvwCheckPoint.SelectedNode.Name, True).Length > 0 Or Me.tvwSA.Nodes(0).Nodes.Find(Me.tvwCheckPoint.SelectedNode.Name, True).Length > 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        Dim strCliente As String
        If Me.cmbCliente.Items.Count > 0 And bolBuscarCheck Then
            If Me.cmbCliente.SelectedIndex > 0 Then
                strCliente = Me.cmbCliente.SelectedValue.ToString.Trim
            Else
                strCliente = CType(Me.cmbCliente.Items(0), DataRowView).Item(0).ToString
            End If
            oCheckPoint.Crea_Lista_X_Cliente(Double.Parse(strCliente))
            Crear_Arbol_Cliente()
        End If
    End Sub

    Private Sub Crear_Arbol_Cliente()
        Dim tndNodo As TreeNode
        Dim lintCont As Integer

        Me.tvwCI.Nodes(0).Nodes.Clear()
        Me.tvwSA.Nodes(0).Nodes.Clear()

        With CType(oCheckPoint.Lista_Cliente, DataTable)
            For lintCont = 0 To .Rows.Count - 1
                tndNodo = New TreeNode(.Rows(lintCont).Item("TDESES").ToString.Trim, 0, 0)
                tndNodo.Name = .Rows(lintCont).Item("NESTDO").ToString.Trim
                tndNodo.Tag = .Rows(lintCont).Item("NESTDO").ToString.Trim
                If .Rows(lintCont).Item("CEMB") = "P" Then
                    Me.tvwCI.Nodes(0).Nodes.Add(tndNodo)
                Else
                    If .Rows(lintCont).Item("CEMB") = "A" Then
                        Me.tvwSA.Nodes(0).Nodes.Add(tndNodo)
                    End If
                End If
            Next lintCont
        End With
        Me.tvwSA.ExpandAll()
        Me.tvwCI.ExpandAll()
    End Sub

    Private Sub tvwCI_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwCI.MouseDown
        strSeguimiento = "CI"
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmsCheck.Items(0).Visible = False
            If Me.tvwCI.SelectedNode.Name = "Raiz" Then
                Exit Sub
            Else
                Me.cmsCheck.Items(0).Visible = True
            End If
        End If
    End Sub

    Private Sub tvwSA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwSA.MouseDown
        strSeguimiento = "SA"
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cmsCheck.Items(0).Visible = False
            If Me.tvwSA.SelectedNode.Name = "Raiz" Then
                Exit Sub
            Else
                Me.cmsCheck.Items(0).Visible = True
            End If
        End If
    End Sub

    Private Sub DesasignarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesasignarToolStripMenuItem.Click
        Try
            If HelpClass.RspMsgBox("Está seguro de quitar el CheckPoint al cliente?") = Windows.Forms.DialogResult.Yes Then
                Select Case strSeguimiento
                    Case "CI"
                        oCheckPoint.Mant_CheckPoint_X_Cliente("D", Double.Parse(cmbCliente.SelectedValue.ToString.Trim), Double.Parse(Me.tvwCI.SelectedNode.Tag), "", "", 1)
                        HelpClass.MsgBox("Se quitó correctamente el checkpoint")
                    Case "SA"
                        oCheckPoint.Mant_CheckPoint_X_Cliente("D", Double.Parse(cmbCliente.SelectedValue.ToString.Trim), Double.Parse(Me.tvwSA.SelectedNode.Tag), "", "", 1)
                        HelpClass.MsgBox("Se quitó correctamente el checkpoint")
                End Select
                oCheckPoint.Crea_Lista_X_Cliente(Double.Parse(cmbCliente.SelectedValue.ToString.Trim))
                Crear_Arbol_Cliente()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If HelpClass.RspMsgBox("Está seguro de guardar la información del checkpoint?") = Windows.Forms.DialogResult.Yes Then
                Select Case strAccion
                    Case "I"
                        If Me.txtSeg.Text.Trim.ToUpper = "ADUANERO" Then
                            oCheckPoint.Mant_CheckPoint(strAccion, 0, Me.txtCheck.Text.Trim, "A", "A")
                        Else
                            oCheckPoint.Mant_CheckPoint(strAccion, 0, Me.txtCheck.Text.Trim, "P", "A")
                        End If
                    Case "U"
                        If Me.txtSeg.Text.Trim.ToUpper = "ADUANERO" Then
                            oCheckPoint.Mant_CheckPoint(strAccion, Me.tvwCheckPoint.SelectedNode.Tag, Me.txtCheck.Text.Trim, "A", "A")
                        Else
                            oCheckPoint.Mant_CheckPoint(strAccion, Me.tvwCheckPoint.SelectedNode.Tag, Me.txtCheck.Text.Trim, "P", "A")
                        End If
                End Select
                Me.KryptonSplitContainer2.Panel2Collapsed = True
                strAccion = ""
                HelpClass.MsgBox("Se grabó correctamente el checkpoint")
                oCheckPoint.Crea_Lista()
                Crear_Arbol()
                Me.tvwCheckPoint.ExpandAll()
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
End Class
