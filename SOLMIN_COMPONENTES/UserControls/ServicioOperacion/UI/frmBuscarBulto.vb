Public Class frmBuscarBulto
    Private oServicio As Servicio_BE
    Private oServicioSILNeg As clsServicio_BL
    Private olServicio As List(Of Servicio_BE)

    Public Sub New(ByVal poServicioAlmacen As Servicio_BE)
        oServicio = poServicioAlmacen
        InitializeComponent()
    End Sub

    Private Sub frmBuscarBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oServicioSILNeg = New clsServicio_BL
    End Sub

    Private Sub txtBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If oServicio.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cmbTerminoBusqueda.Text <> "" And txtBusqueda.Text <> "" Then Waybills_Registrar()
        End If
    End Sub

    Private Sub Waybills_Registrar()
        Dim oSerAlm As New Servicio_BE
        With oSerAlm
            .CCLNT = oServicio.CCLNT
            .NOPRCN = oServicio.NOPRCN
            .TIPOALM = oServicio.TIPOALM
            .CCMPN = oServicio.CCMPN
            .CDVSN = oServicio.CDVSN
            .CPLNDV = oServicio.CPLNDV

            Select Case Mid(cmbTerminoBusqueda.Text, 1, 1)
                Case "B"
                    .CREFFW = txtBusqueda.Text
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.PALETA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROPLT = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROCTL = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NRGUSA = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.GUIA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRM = intTemp
                    End If
            End Select
            ' Ahora registramos los Bultos
            Dim oSerAlm2 As New Servicio_BE
            oSerAlm2.CCLNT = .CCLNT
            oSerAlm2.NOPRCN = .NOPRCN
            oSerAlm2.TIPOALM = .TIPOALM
            oSerAlm2.CREFFW = .CREFFW
            oSerAlm2.NROPLT = .NROPLT
            oSerAlm2.NROCTL = .NROCTL
            oSerAlm2.NRGUSA = .NRGUSA
            oSerAlm2.NGUIRM = .NGUIRM
            oSerAlm2.CCMPN = .CCMPN
            oSerAlm2.CDVSN = .CDVSN
            oSerAlm2.CPLNDV = .CPLNDV
            WayBills_Cargar(oSerAlm2)
        End With
    End Sub

    Private Sub WayBills_Cargar(ByVal oSerAlm2 As Servicio_BE)
        Dim dtTemp As DataTable = oServicioSILNeg.fdtListaBultoFacturarSA(oSerAlm2)
        If Not oSerAlm2.PSERROR.Trim.Equals("") Then
            MsgBox(oSerAlm2.PSERROR)
        End If
        Dim dtWayBill As DataTable
        Dim oDrVw As DataGridViewRow
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            dtWayBill = dtTemp.Clone
            For Each dwFila In dtTemp.Rows
                If Not fblnBuscarBulto(dwFila.Item("CREFFW").ToString.Trim, dwFila.Item("QREFFW")) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgBultos)
                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    Me.dtgBultos.Rows.Add(oDrVw)
                    With Me.dtgBultos
                        dtgBultos.CurrentRow.ToString()
                        Dim pos As Integer = dtgBultos.Rows.Count - 1
                        .Rows(pos).Cells("CREFFW").Value = dwFila.Item("CREFFW").ToString.Trim
                        .Rows(pos).Cells("NCRRDC").Value = 0
                        .Rows(pos).Cells("DESCWB").Value = dwFila.Item("DESCWB").ToString.Trim
                        .Rows(pos).Cells("TUBRFR").Value = dwFila.Item("TUBRFR").ToString.Trim
                        .Rows(pos).Cells("QREFFW").Value = dwFila.Item("QREFFW")
                        .Rows(pos).Cells("TIPBTO").Value = dwFila.Item("TIPBTO").ToString.Trim
                        .Rows(pos).Cells("QPSOBL").Value = dwFila.Item("QPSOBL")
                        .Rows(pos).Cells("TUNPSO").Value = dwFila.Item("TUNPSO").ToString.Trim
                        .Rows(pos).Cells("QVLBTO").Value = dwFila.Item("QVLBTO")
                        .Rows(pos).Cells("TUNVOL").Value = dwFila.Item("TUNVOL").ToString.Trim
                        .Rows(pos).Cells("QAROCP").Value = dwFila.Item("QAROCP")
                        .Rows(pos).Cells("SESTRG").Value = dwFila.Item("SESTRG").ToString.Trim
                        .Rows(pos).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(pos).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        dtgBultos.Rows(pos).Tag = "N"
                    End With
                    ' ========Si estamos en Batch, debemos marcar el registro para poderlo distiguirlo===========PARA VERIFICAR EXISTENCIA
                    'If Not blnOnLine Then fblnBuscar(dwFila.Item("CREFFW"), True)
                End If
            Next
        End If
        ' Cargamos el Item y lanzo el evento respectivo
    End Sub

    Private Function fblnBuscarBulto(ByVal strCodigo As String, Optional ByVal blnStatus As Boolean = False) As Boolean
        Dim blnResultado As Boolean = False
        Dim intIndice As Integer
        For intIndice = 0 To dtgBultos.RowCount - 1
            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim Then
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function



    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case oServicio.STPODP
            Case "7"
                GrabarBultos()
        End Select

    End Sub

    Private Function GrabarBultos() As Boolean
        Dim blnResultado As Boolean = True
        If dtgBultos.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dtgBultos.Rows.Count > 0 Then
                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                    oServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                    oServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                    oServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                    oServicio.NCRRDC = Val(dtgBultos.Rows(i).Cells("NCRRDC").Value)
                    If dtgBultos.Rows(i).Tag = "N" OrElse oServicio.TAG = "N" Then
                        oServicio.PSERROR = oServicioSILNeg.fstrInsertarDetalleServiciosFacturacionSA(oServicio)
                        If Not oServicio.PSERROR.Equals("") Then
                            MsgBox(oServicio.PSERROR, MessageBoxIcon.Error)
                            blnResultado = False
                            Exit For
                        End If
                    Else
                        If oServicioSILNeg.fintActualizarDetalleServiciosFacturacionSA(oServicio) = 0 Then
                            MsgBox(oServicio.PSERROR, MessageBoxIcon.Error)
                            blnResultado = False
                            Exit For
                        End If
                    End If
                Next
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Function

    Private Sub BtnEliminarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTermino.Click
        If Me.dtgBultos.RowCount <= 0 Then
            MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value = 0 Then
            dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
            Exit Sub
        End If
    End Sub

 
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
