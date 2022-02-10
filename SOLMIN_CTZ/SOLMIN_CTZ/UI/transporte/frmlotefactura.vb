Imports SOLMIN_CTZ.NEGOCIO.operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class frmlotefactura

#Region "Variables"

    Private _odtListLote As DataTable
    Private _odtListLote_Original As DataTable

#End Region

#Region "Properties"
    Public Property odtListLote_Original() As DataTable
        Set(ByVal value As DataTable)
            _odtListLote_Original = value
        End Set
        Get
            Return _odtListLote_Original
        End Get
    End Property
    Public Property odtListLote() As DataTable
        Set(ByVal value As DataTable)
            _odtListLote = value
        End Set
        Get
            Return _odtListLote
        End Get
    End Property
#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.txtLote.Text.Trim().Equals("") Then
            Exit Sub
        End If

        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Me.gwdDatos.EndEdit()
        Dim strLote As String = String.Empty
        Dim sbLote As New System.Text.StringBuilder

        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                sbLote.Append("'")
                sbLote.Append(Me.gwdDatos.Item("LOTE", lint_Contador).Value)
                sbLote.Append("',")
            End If
        Next
        strLote = sbLote.ToString()
        If strLote.Contains(",") Then
            strLote = strLote.Substring(0, strLote.Length - 1)
        End If
        If strLote.ToString.Equals("") Then
            Exit Sub
        End If
        Dim drSelect As DataRow()
        drSelect = odtListLote.Select("Lote in (" & strLote & " )")
        For Each row As DataRow In drSelect
            row.Item("Lote") = Me.txtLote.Text.Trim
            row.AcceptChanges()
        Next
        Dim oDs As New DataSet
        odtListLote.TableName = "Lote"
        oDs.Tables.Add(odtListLote.Copy)
        Dim dsHelper As New DataSetHelper(oDs)
        dsHelper.SelectGroupByInto("GroupLote", oDs.Tables(0), _
        "LOTE,TIPO,CCLNT,NOPRCN,NGUIRM,NRGUCL,sum(PESO_VOL) PESO_VOL,sum(PESO) PESO", "", "LOTE,TIPO,CCLNT,NOPRCN,NGUIRM,NRGUCL")
        odtListLote = oDs.Tables("GroupLote").Copy
        Me.txtLote.Text = ""
        frmlotefactura_Load(Nothing, Nothing)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmlotefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fact As New Factura_Transporte_BLL
        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.DataSource = fact.SelectDistinct(_odtListLote.Copy, "LOTE", "TIPO").Copy

    End Sub
    Private Sub gwdDatos_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gwdDatos.CellFormatting
        Try
            Select Case gwdDatos.Columns(e.ColumnIndex).Name
                Case "SELEC_C"
                    If Me.gwdDatos.Item("TIPO", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim.Equals("MANUAL") Then
                        Me.gwdDatos.EndEdit()
                        Me.gwdDatos.Item("SELEC_C", Me.gwdDatos.CurrentCellAddress.Y).ReadOnly = True
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick
        Try
            If gwdDatos.Columns(e.ColumnIndex).Name = "ImageOp" Then
                Dim objfrmOperacion As New frmOperacionesXLoteFactura
                objfrmOperacion.odtListLote = odtListLote
                objfrmOperacion.strLote = Me.gwdDatos.Item("LOTE", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
                objfrmOperacion.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class