Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Controls.TreeNode
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Text
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.IO
Imports Ransa.Utilitario


Public Class frmVerRutaOptima
#Region "Atributos"
    Private bool As Boolean = False
    Private olGuiaTransportista2 As New List(Of GuiaTransportista)
    Private root As TreeNode(Of CircleNode)
    Private TreeNodeP As String
    Private strMensajeError As String = ""
    Private intFilaActual As Integer = 0
    Private iFilaMod As Integer
    Private picTree As System.Windows.Forms.PictureBox
    Private ContReg As Integer = 0
    Private oGuia As GuiaTransportista

#End Region

#Region "Properties"
    Public Property Guia() As GuiaTransportista
        Get
            Return oGuia
        End Get
        Set(ByVal value As GuiaTransportista)
            oGuia = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Public Event ErrorMessage(ByVal strMensaje As String)

    Public Sub New(ByVal olGuiaTransportista As List(Of GuiaTransportista))
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        bool = True
        If olGuiaTransportista.Count > 0 Then
            olGuiaTransportista2 = olGuiaTransportista
        End If
    End Sub

    Private Sub frmVerRutaOptima_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If olGuiaTransportista2 IsNot Nothing And olGuiaTransportista2.Count > 0 Then
            Cargar_Destinos()
            Cargar_Grilla()
        End If
    End Sub

    Private Sub picTree_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) 'Handles picTree.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
        root.DrawTree(e.Graphics, Pens.White, Pens.Green, TreeNodeP)
        For Each child As TreeNode(Of CircleNode) In root.Children
            child.DrawTree(e.Graphics, Pens.Red, Pens.Green, TreeNodeP)
        Next
    End Sub

    Private Sub picTree_Resize(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles picTree.Resize
        If bool = True Then
            If olGuiaTransportista2 IsNot Nothing And olGuiaTransportista2.Count > 0 Then
                For Each objEntidad As GuiaTransportista In olGuiaTransportista2
                    Dim KM As Single = 0
                    If (objEntidad.QKMREC < 200) Then
                        KM = 3 * objEntidad.QKMREC
                    Else
                        KM = objEntidad.QKMREC
                    End If

                    ArrangeTree(KM)
                Next
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim myPrintDocument1 As System.Drawing.Printing.PrintDocument = New System.Drawing.Printing.PrintDocument
        'Dim myPrinDialog1 As PrintDialog = New PrintDialog
        AddHandler myPrintDocument1.PrintPage, AddressOf Me.Imagen_PrintPage
        ContReg = 0
        Dim ppd As New PrintPreviewDialog
        ppd.Document = myPrintDocument1
        ppd.ShowDialog()

    End Sub

    Private Sub Imagen_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        ContReg = 0
        Dim fuente As Font
        Dim brocha As Brush = Brushes.Black
        Dim X As Integer = e.MarginBounds.Left
        Dim Xi As Integer = e.MarginBounds.Left
        Dim Y As Integer = 30 'picTree.Height + 10 
        Dim LogoRansa As New Bitmap(Global.SOLMIN_ST.My.Resources.pe_es_logo, 100, 50)
        e.Graphics.DrawImage(LogoRansa, 0, 0)
        Y = Y + 20
        fuente = New Font("Arial", 6)
        e.Graphics.DrawString("Compañía : " & Guia.CCMPN.ToString.Trim, fuente, brocha, 0, Y)
        Y = Y + 15
        e.Graphics.DrawString("División : " & oGuia.CDVSN.ToString.Trim, fuente, brocha, 0, Y)
        Y = Y + 15
        e.Graphics.DrawString("Planta   : " & oGuia.CPLNDV_S.ToString.Trim, fuente, brocha, 0, Y)
        Y = 30
        e.Graphics.DrawString("Usuario : " & oGuia.USRCRT.ToString.Trim, fuente, brocha, 0 + 650, Y)
        Y = Y + 15
        e.Graphics.DrawString("Fecha   : " & HelpClass.CNumero8Digitos_a_Fecha(oGuia.FCHCRT), fuente, brocha, 0 + 650, Y)
        Y = Y + 15
        e.Graphics.DrawString("Hora    : " & HelpClass.Now_Hora(), fuente, brocha, 0 + 650, Y)
        Y = Y + 15
        fuente = New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString("RUTA ÓPTIMA", fuente, brocha, X + 230, Y)
        Dim bmp As Bitmap = New Bitmap(picTree.Width, picTree.Height)
        picTree.DrawToBitmap(bmp, New Rectangle(0, Y - 50, picTree.Width, picTree.Height))
        e.Graphics.DrawImage(bmp, 0, Y)
        Y = Y + 670
        fuente = New Font("Arial", 11, FontStyle.Bold)
        X = e.MarginBounds.Left
        e.Graphics.DrawString("Item", fuente, brocha, New PointF(X, Y))
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi - 55, fuente.GetHeight))
        X = X + 50
        e.Graphics.DrawString("Operación", fuente, brocha, New PointF(X, Y))
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 47, fuente.GetHeight))
        X = X + 100
        e.Graphics.DrawString("Localidad Origen", fuente, brocha, New PointF(X, Y))
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 200, fuente.GetHeight))
        X = X + 150
        e.Graphics.DrawString("Localidad Destino", fuente, brocha, New PointF(X, Y))
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 350, fuente.GetHeight))
        X = X + 150
        e.Graphics.DrawString("KM. Recorridos", fuente, brocha, New PointF(X, Y))
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 470, fuente.GetHeight))
        'X = X + 200
        Y += fuente.GetHeight
        Dim TLP As Integer = e.MarginBounds.Height / (fuente.GetHeight + 20)
        fuente = New Font("Arial", 9)
        For I As Integer = 1 To TLP
            If (ContReg = olGuiaTransportista2.Count) Then Exit For
            X = e.MarginBounds.Left
            Xi = e.MarginBounds.Left
            e.Graphics.DrawString(olGuiaTransportista2(ContReg).NMOPRP, fuente, brocha, New PointF(X, Y))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi - 55, fuente.GetHeight))
            X = X + 50
            e.Graphics.DrawString(olGuiaTransportista2(ContReg).NOPRCN, fuente, brocha, New PointF(X, Y))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 47, fuente.GetHeight))
            X = X + 100
            e.Graphics.DrawString(olGuiaTransportista2(ContReg).TDIROR, fuente, brocha, New PointF(X, Y))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 200, fuente.GetHeight))
            X = X + 150
            e.Graphics.DrawString(olGuiaTransportista2(ContReg).TDIRDS, fuente, brocha, New PointF(X, Y))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 350, fuente.GetHeight))
            X = X + 150
            e.Graphics.DrawString(olGuiaTransportista2(ContReg).QKMREC, fuente, brocha, New PointF(X, Y))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(Xi, Y, Xi + 470, fuente.GetHeight))
            Y += fuente.GetHeight
            ContReg += 1
        Next
        e.HasMorePages = (ContReg < olGuiaTransportista2.Count)
        bmp.Dispose()

    End Sub

    Private Sub gwdDatos_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gwdDatos.CellBeginEdit
        iFilaMod = gwdDatos.CurrentRow.Cells("NMOPRP").Value
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick
        With gwdDatos
            If e.ColumnIndex = 0 Then
                If .CurrentCellAddress.Y < 0 Then Exit Sub
                If .CurrentCell.Value Then
                    Call pMarcarFila(e.RowIndex, True)
                Else
                    If .CurrentRow.Cells("NMOPRP").Value <= 0 Or .CurrentRow.Cells("NMOPRP").Value > .RowCount Then Exit Sub
                    .CurrentCell.Value = True
                    Call pMarcarFila(e.RowIndex, True)
                End If
            End If
        End With
    End Sub

    Private Sub gwdDatos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellEndEdit
        Dim intCont As Integer = 0
        Dim ColumName As String
        Dim lint_Indice_A As Integer = Me.gwdDatos.CurrentCellAddress.Y
        With gwdDatos
            Select Case .Columns(e.ColumnIndex).Name
                Case "NMOPRP"
                    If .CurrentCell.Value <= 0 Then
                        strMensajeError = "El Nro. de Item debe ser mayor a cero."
                        MessageBox.Show(strMensajeError, "Error: ", MessageBoxButtons.OK)
                        .CurrentCell.Value = iFilaMod
                        Exit Sub
                    ElseIf .CurrentCell.Value > gwdDatos.RowCount Then
                        strMensajeError = "El Nro. de Item no debe ser mayor a " + gwdDatos.RowCount.ToString
                        MessageBox.Show(strMensajeError, "Error: ", MessageBoxButtons.OK)
                        .CurrentCell.Value = iFilaMod
                        Exit Sub
                    Else
                        intCont = 0
                        If .CurrentCell.Value.ToString.Trim = "" Then
                            .CurrentCell.Value = iFilaMod
                        Else
                            Dim decTemp As Integer = 1
                            Decimal.TryParse("" & .CurrentCell.Value, decTemp)
                            .CurrentCell.Value = decTemp
                            For i As Integer = 0 To gwdDatos.RowCount - 1
                                If i <> lint_Indice_A Then
                                    If Me.gwdDatos.Item(0, i).Value = decTemp Then
                                        .Item(0, i).Value = iFilaMod
                                    End If
                                End If
                            Next

                            olGuiaTransportista2.Sort(AddressOf SortItem)
                            gwdDatos.EndEdit()
                            gwdDatos.DataSource = Nothing
                            gwdDatos.DataSource = olGuiaTransportista2
                            Dim num_con As Int32 = Me.SplitContainer1.Panel1.Controls.Count - 1
                            For n As Integer = num_con To 0 Step -1
                                Dim ctrl As Windows.Forms.Control = Me.SplitContainer1.Panel1.Controls(n)
                                Me.SplitContainer1.Panel1.Controls.Remove(ctrl)
                                ctrl.Dispose()
                            Next
                            Cargar_Destinos()
                        End If
                    End If
            End Select
            ColumName = .Columns(e.ColumnIndex).Name
        End With
    End Sub

    Private Function SortItem(ByVal Item1 As GuiaTransportista, ByVal Item2 As GuiaTransportista) As Integer
        Dim retorno As Integer = Item1.NMOPRP.CompareTo(Item2.NMOPRP)
        Return retorno
    End Function

    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        If gwdDatos.CurrentCell Is Nothing Then
            intFilaActual = -1
            Exit Sub
        End If
    End Sub
#End Region

#Region "Procedimientos y Funciones"
    Private Sub Agregar_PicTree()
        picTree = New System.Windows.Forms.PictureBox
        Me.SplitContainer1.Panel1.Controls.Add(picTree)
        picTree.BackColor = System.Drawing.Color.White
        picTree.Dock = System.Windows.Forms.DockStyle.Fill
        picTree.Location = New System.Drawing.Point(0, 0)
        picTree.Name = "picTree"
        picTree.Size = New System.Drawing.Size(525, 391)
        picTree.TabIndex = 0
        picTree.TabStop = False
        AddHandler picTree.Resize, AddressOf picTree_Resize
        AddHandler picTree.Paint, AddressOf picTree_Paint

    End Sub

    Private Sub Cargar_Destinos()
        Agregar_PicTree()
        root = New TreeNode(Of CircleNode)(New CircleNode(olGuiaTransportista2.Item(0).TDIROR.ToString.Trim))
        Dim Node As New System.Windows.Forms.TreeNode
        If olGuiaTransportista2 IsNot Nothing And olGuiaTransportista2.Count > 0 Then

            Dim ListTreeNode As New List(Of TreeNode(Of CircleNode))

            For i As Integer = 0 To olGuiaTransportista2.Count - 1
                Dim KM As Single = 0
                If olGuiaTransportista2.Count < 4 Then
                    If (olGuiaTransportista2.Item(i).QKMREC < 200) Then
                        KM = 4 * olGuiaTransportista2.Item(i).QKMREC
                    Else
                        KM = olGuiaTransportista2.Item(i).QKMREC
                    End If
                ElseIf olGuiaTransportista2.Count >= 4 And olGuiaTransportista2.Count < 10 Then
                    If (olGuiaTransportista2.Item(i).QKMREC < 200) Then
                        KM = 2 * olGuiaTransportista2.Item(i).QKMREC
                    Else
                        KM = olGuiaTransportista2.Item(i).QKMREC
                    End If
                Else
                    KM = olGuiaTransportista2.Item(i).QKMREC
                End If

                Dim TreeNo1 As String = olGuiaTransportista2.Item(i).NMOPRP.ToString.Trim & " - " & olGuiaTransportista2.Item(i).TDIRDS.ToString.Trim
                If i = 0 Then
                    Dim a_node As New TreeNode(Of CircleNode)(New CircleNode(olGuiaTransportista2.Item(i).NMOPRP.ToString.Trim & " - " & olGuiaTransportista2.Item(i).TDIRDS.ToString.Trim), New Font("Arial", 11, FontStyle.Bold), KM, Pens.Red, TreeNo1)
                    root.AddChild(a_node)
                    ListTreeNode.Add(a_node)
                    TreeNodeP = olGuiaTransportista2.Item(i).NMOPRP.ToString.Trim & " - " & olGuiaTransportista2.Item(i).TDIRDS.ToString.Trim
                Else
                    If i >= 1 Then
                        Dim Color As Pen = Pens.White
                        Dim b_node As New TreeNode(Of CircleNode)(New CircleNode(olGuiaTransportista2.Item(i).NMOPRP.ToString.Trim & " - " & olGuiaTransportista2.Item(i).TDIRDS.ToString.Trim), New Font("Arial", 11, FontStyle.Bold), KM, Color, TreeNo1)
                        root.AddChild(b_node)
                        ListTreeNode.Item(0).AddChild(b_node)
                        ListTreeNode.Clear()
                        ListTreeNode.Add(b_node)
                    End If
                End If
                ArrangeTree(olGuiaTransportista2.Item(i).QKMREC)
            Next
        End If
    End Sub

    Private Sub Cargar_Grilla()
        gwdDatos.AutoGenerateColumns = False
        gwdDatos.DataSource = olGuiaTransportista2
    End Sub

    'Private Function ConvertirPictureBoxAArrayByte(ByVal pbImagen As System.Windows.Forms.PictureBox) As Byte()
    '    Dim ms As New MemoryStream()
    '    'pbImagen.Image =
    '    Dim bmp As New Bitmap(pbImagen.Image)
    '    'picTree.Image = pbImagen.Image
    '    bmp.Save(ms, Imaging.ImageFormat.Jpeg)
    '    'picTree.Image.Save(ms, Imaging.ImageFormat.Jpeg)
    '    Return ms.GetBuffer()
    'End Function

    Private Sub ArrangeTree(ByVal DistVert As Double)
        Using gr As Graphics = picTree.CreateGraphics()
            ' Arrange the tree once to see how big it is.  
            Dim xmin As Single = 0, ymin As Single = 0
            root.Arrange(gr, xmin, ymin, root.KM)
            ' Arrange the tree again to center it horizontally.  
            xmin = (Me.picTree.Width - xmin) / 2
            ymin = 30
            root.Arrange(gr, xmin, ymin, root.KM)
        End Using
        Me.Refresh()
    End Sub

    Private Sub pMarcarFila(ByVal Indice As Int32, ByVal Status As Boolean)
        If Indice = -1 Then Exit Sub
        If Status Then
            gwdDatos.Rows(Indice).Cells("NMOPRP").Value = gwdDatos.Rows(Indice).Cells("NMOPRP").Value
            gwdDatos.Rows(Indice).Cells("NMOPRP").ReadOnly = False
        Else
            gwdDatos.Rows(Indice).Cells("NMOPRP").ReadOnly = False
        End If

    End Sub
#End Region

End Class
