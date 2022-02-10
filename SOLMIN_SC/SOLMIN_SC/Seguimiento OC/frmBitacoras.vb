Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmBitacoras

    Private _beCheckPoint As beBitacora
    Public Property beCheckPoint() As beBitacora
        Get
            Return _beCheckPoint
        End Get
        Set(ByVal value As beBitacora)
            _beCheckPoint = value
        End Set
    End Property

    ''' <summary>
    ''' Se utiliza para saber si se agregó o eliminó algún registro
    ''' </summary>
    ''' <remarks></remarks>
    Private bolModificado As Boolean = False
    Private Sub frmBitacoras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTabla()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim obeCheckPoint As beBitacora
        Dim obrCheckPoint As New clsBitacora
        Me.dgvBitacora.EndEdit()
        Dim bolResult As Boolean = True
        If validarDatos() = False Then
            MsgBox("Debe corregir las celdas marcadas", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            For intX As Integer = 0 To Me.dgvBitacora.Rows.Count - 1
                obeCheckPoint = _beCheckPoint
                If Me.dgvBitacora.Item("TFCOBS", intX).Value = Nothing OrElse Me.dgvBitacora.Item("TFCOBS", intX).Value.ToString = "" Then
                    obeCheckPoint.PNTFCOBS = 0
                Else
                    obeCheckPoint.PNTFCOBS = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(Me.dgvBitacora.Item("TFCOBS", intX).Value)
                End If
                If Me.dgvBitacora.Item("TOBS", intX).Value = Nothing OrElse Me.dgvBitacora.Item("TOBS", intX).Value.ToString = "" Then
                    obeCheckPoint.PSTOBS = ""
                Else
                    obeCheckPoint.PSTOBS = Me.dgvBitacora.Item("TOBS", intX).Value.ToString
                End If
                If Me.dgvBitacora.Item("NRITEM", intX).Value = Nothing Then
                    obeCheckPoint.PNNRITEM = -1
                Else
                    obeCheckPoint.PNNRITEM = Me.dgvBitacora.Item("NRITEM", intX).Value
                End If
                obeCheckPoint.PSCUSCRT = HelpUtil.UserName
                If obrCheckPoint.insertar_bitacora_itemOC(obeCheckPoint) = False Then
                    bolResult = False
                    Exit For
                End If
            Next
            If bolResult = True Then
                MsgBox("Se grabó correctamente", MsgBoxStyle.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("Ocurrio un error al grabar", MsgBoxStyle.Critical)
            End If
           
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.dgvBitacora.Rows.Add(1)
        ' Me.dgvBitacora.Item("NRITEM", Me.dgvBitacora.CurrentRow.Index).Value = -1
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim obeCheckPoint As beBitacora
        Dim obrCheckPoint As New clsBitacora
        Me.dgvBitacora.EndEdit()
        If Me.dgvBitacora.RowCount = 0 Then
            Exit Sub
        End If
        If Me.dgvBitacora.Item("NRITEM", Me.dgvBitacora.CurrentCellAddress.Y).Value IsNot Nothing Then
            If MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                obeCheckPoint = _beCheckPoint
                obeCheckPoint.PNNRITEM = Me.dgvBitacora.Item("NRITEM", Me.dgvBitacora.CurrentRow.Index).Value
                obeCheckPoint.PSCUSCRT = HelpUtil.UserName
                If obrCheckPoint.eliminar_bitacora_itemOC(obeCheckPoint) = False Then
                    MsgBox("Ocurrio un error al grabar")
                    Exit Sub
                End If
                loadTabla()
                bolModificado = True
            End If
        Else
            dgvBitacora.Rows.Remove(Me.dgvBitacora.CurrentRow)
        End If

    End Sub

    Private Sub dgvBitacora_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvBitacora.UserDeletingRow
        If Me.dgvBitacora.Item("NRITEM", Me.dgvBitacora.CurrentCellAddress.Y).Value IsNot Nothing Then
            e.Cancel = True
        End If
    End Sub
    Private Sub loadTabla()
        Dim lstResult As List(Of beBitacora)
        Dim obrCheckPoint As New clsBitacora
        Me.dgvBitacora.AutoGenerateColumns = False
        lstResult = obrCheckPoint.listar_bitacora_itemOC(_beCheckPoint)
        Me.dgvBitacora.Rows.Clear()
        For intX As Integer = 0 To lstResult.Count - 1
            Me.dgvBitacora.Rows.Add(1)
            Me.dgvBitacora.Item("NRITEM", intX).Value = lstResult(intX).PNNRITEM
            Me.dgvBitacora.Item("TFCOBS", intX).Value = Date.Parse(Ransa.Utilitario.HelpClass.CNumero8Digitos_a_Fecha(lstResult(intX).PNTFCOBS))
            Me.dgvBitacora.Item("TOBS", intX).Value = lstResult(intX).PSTOBS
        Next
    End Sub
    Private Function validarDatos() As Boolean
        Dim result As Boolean = True
        For intX As Integer = 0 To Me.dgvBitacora.RowCount - 1
            If Me.dgvBitacora.Item("TFCOBS", intX).Value = Nothing OrElse Me.dgvBitacora.Item("TFCOBS", intX).Value.ToString = "" Then
                Me.dgvBitacora.Item("TFCOBS", intX).ErrorText = "La Fecha no es valida"
                result = False
            Else
                Me.dgvBitacora.Item("TFCOBS", intX).ErrorText = ""
            End If
            If Me.dgvBitacora.Item("TOBS", intX).Value = Nothing OrElse Me.dgvBitacora.Item("TOBS", intX).Value.ToString = "" Then
                Me.dgvBitacora.Item("TOBS", intX).ErrorText = "Ingrese una Obervación"
                result = False
            Else
                Me.dgvBitacora.Item("TOBS", intX).ErrorText = ""
            End If
        Next
        Return result
    End Function

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        If bolModificado Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub
End Class
