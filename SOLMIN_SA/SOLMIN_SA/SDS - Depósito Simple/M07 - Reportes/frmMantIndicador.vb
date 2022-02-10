Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports RANSA.NEGO
Imports System.Text
Public Class frmMantIndicador
#Region "Propiedades Publicas"
    Public odtInfoIndicador As New DataTable
    Public myDialogOk As Boolean = False
    Public oInfoIndicador As New beIndicador
#End Region
#Region "Propiedades Privadas"
    Private MaxDiaMes As Int32 = 0
    Private AbrevMes As String = ""
    Private oHasColumnasTabla As New Hashtable
    Private odtInfoIndicadorInicio As New DataTable
    Private CalculoUnitario As Boolean = False
    Private odtCalculo As New DataTable
    Private MaxDiasMesCalculable As Int32 = 0


#End Region
    Private Sub HabilitarEscrituraCelda()
        Dim FechaActual As String = HelpClass.TodayNumeric
        Dim anioActual As Int32 = HelpClass.TodayAnio
        Dim mesActual As Int32 = HelpClass.TodayMes

        If (anioActual = FechaActual.Substring(0, 4) And mesActual = FechaActual.Substring(4, 2)) Then
            MaxDiasMesCalculable = FechaActual.Substring(6, 2)
        Else
            MaxDiasMesCalculable = oInfoIndicador.PNMAXDIAS
        End If
        Dim numCol As Int32 = 0
        Dim columna As String = ""
        numCol = dgIndicador.Columns.Count - 1
        oHasColumnasTabla.Clear()
        For index As Integer = 1 To 31
            columna = FormatoNombreColumna(index)
            If (index <= MaxDiasMesCalculable) Then
                dgIndicador.Columns(columna).ReadOnly = False
            Else
                dgIndicador.Columns(columna).ReadOnly = True
            End If
        Next
    End Sub
    Private Function HaCambiadoValorCelda(ByVal CTPOIN As Int64, ByVal QDIA As Object, ByVal ColumnaDia As String) As Boolean
        Dim objectOrigen As Object
        Dim objectEdit As Object
        Dim filtro As String = ""
        Dim retorno As Boolean = False
        filtro = "CTPOIN=" & CTPOIN
        objectOrigen = odtInfoIndicadorInicio.Select(filtro)(0).Item(ColumnaDia)
        objectEdit = QDIA
        If (objectEdit.Equals(objectOrigen)) Then
            retorno = False
        Else
            retorno = True
        End If
        Return retorno
    End Function
   
    Private Sub frmMantIndicador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgIndicador.DataSource = Nothing

            txtCompania.Text = oInfoIndicador.PSCCMPN & " - " & oInfoIndicador.PSTCMPCM
            txtCliente.Text = oInfoIndicador.PNCCLNT & " - " & oInfoIndicador.PSTCMPL
            txtDivision.Text = oInfoIndicador.PSCDVSN & " - " & oInfoIndicador.PSTCMPDV
            txtAnio.Text = oInfoIndicador.PNANIOEMI & " - " & oInfoIndicador.PSABREVMES
            txtCompania.ReadOnly = True
            txtDivision.ReadOnly = True
            txtCliente.ReadOnly = True
            txtAnio.ReadOnly = True


            dgIndicador.AutoGenerateColumns = False
            LlenarColumnasDiaTabla()
            pcxEspera.Visible = False

            MaxDiaMes = oInfoIndicador.PNMAXDIAS
            AbrevMes = oInfoIndicador.PSABREVMES
            ActualizarDatos()
            odtInfoIndicadorInicio = odtInfoIndicador.Copy()
            odtCalculo = odtInfoIndicador.Copy()
            odtCalculo.Rows.Clear()

            HabilitarEscrituraCelda()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LlenarColumnasDiaTabla()
        Dim numCol As Int32 = 0
        Dim columna As String = ""
        numCol = dgIndicador.Columns.Count - 1
        oHasColumnasTabla.Clear()
        For index As Integer = 1 To 31
            columna = FormatoNombreColumna(index)
            oHasColumnasTabla.Add(columna, columna)
        Next
    End Sub

   
    Private Sub ActualizarDatos()

        If (CalculoUnitario = False) Then
            dgIndicador.DataSource = odtInfoIndicador
            FormatearCabeceraColumna(True)
            FormatearFilas()
        Else
            ActualizarRegistroCalculado()
        End If    
    End Sub
    
    
    Private Sub FormatearFilas()
        dgIndicador.ReadOnly = False
        For Each dr As DataGridViewRow In dgIndicador.Rows
            If (dr.Cells("FLAG_TIPO").Value IsNot DBNull.Value) Then
                If (EsFilaCalculable(dr.Cells("FLAG_TIPO").Value) = False) Then
                    dr.Cells("TIPOCALCULO").Value = My.Resources.cell_layout
                    dr.Cells("TIPOCALCULO").ToolTipText = "Los valores deben ser ingresados " & Chr(13) & "manualmente."
                Else
                    dr.Cells("TIPOCALCULO").Value = My.Resources.Procesar
                    dr.Cells("TIPOCALCULO").ToolTipText = "Calcula los valores de la fila " & Chr(13) & "según Indicador"
                End If
            End If          
        Next
    End Sub
    Private Function EsFilaEditable(ByVal Valor As String) As Boolean
        Dim retorno As Boolean = False
        If (Valor.Trim = "") Then
            retorno = True
        End If
        Return retorno
    End Function
    Private Function EsFilaCalculable(ByVal Valor As String) As Boolean
        Dim retorno As Boolean = False
        If (Valor.Trim = "C") Then
            retorno = True
        End If
        Return retorno
    End Function


    Private Sub FormatearCabeceraColumna(ByVal VerTodasColumnas As Boolean)
        Dim numColumnas As Int32 = 0
        Dim columna As String = ""
        numColumnas = 31
        For index As Integer = 1 To numColumnas
            columna = FormatoNombreColumna(index)
            dgIndicador.Columns(columna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgIndicador.Columns(columna).SortMode = DataGridViewColumnSortMode.NotSortable
            If (VerTodasColumnas = True) Then
                dgIndicador.Columns(columna).HeaderText = AbrevMes & "-" & HelpClass.StringRight(columna, 2)
                If (index <= MaxDiaMes) Then
                    dgIndicador.Columns(columna).Visible = True
                Else
                    dgIndicador.Columns(columna).Visible = False
                End If
            Else
                dgIndicador.Columns(columna).Visible = False
            End If
        Next
    End Sub
    Private Function FormatoNombreColumna(ByVal numeroDia As Int32) As String
        Dim retorno As String = "DIA"
        Dim strDia As String = ""
        strDia = numeroDia.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function

#Region "Validacion Grilla"
    Private Sub dgIndicador_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellValidated
        Try
            Dim total As Decimal = 0, Monto = 0
            Dim CTPOIN As Int32 = 0
            If (EvaluarColumna(e.ColumnIndex) = False) Then Exit Sub
            CTPOIN = dgIndicador.Item("CTPOIN", e.RowIndex).Value
            For index As Integer = 1 To MaxDiaMes
                Monto = HelpClass.ObjectToDecimal(dgIndicador.Item(FormatoNombreColumna(index), e.RowIndex).Value)
                If (Monto > 0) Then
                    total = total + Monto
                End If
            Next
            If (CTPOIN = 12 Or CTPOIN = 22 Or CTPOIN = 31 Or CTPOIN = 32) Then
                dgIndicador.Item("TOTAL", e.RowIndex).Value = IIf(dgIndicador.Item(FormatoNombreColumna(MaxDiasMesCalculable), e.RowIndex).Value Is DBNull.Value, 0, dgIndicador.Item(FormatoNombreColumna(MaxDiasMesCalculable), e.RowIndex).Value)
            Else
                dgIndicador.Item("TOTAL", e.RowIndex).Value = total
            End If
            dgIndicador.Item("PROMEDIO", e.RowIndex).Value = Math.Round(total / MaxDiasMesCalculable, 2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgIndicador_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgIndicador.CellValidating
        Try

            If dgIndicador.CurrentCellAddress.X < 0 Then Exit Sub
            If (EvaluarColumna(e.ColumnIndex) = False) Then Exit Sub
            If dgIndicador.CurrentCell.Value Is DBNull.Value Then Exit Sub

            If HelpClass.ObjectToString(dgIndicador.CurrentCell.Value) = "" Or HelpClass.ObjectToString(dgIndicador.CurrentCell.Value).Equals("0") Then
                dgIndicador.CurrentCell.Value = 0D
            Else
                If (IsNumeric(dgIndicador.CurrentCell.Value)) Then
                    If (HelpClass.ObjectToString(dgIndicador.CurrentCell.Value).Length > 10) Then
                        dgIndicador.CurrentCell.Value = DBNull.Value
                    End If
                    If (dgIndicador.CurrentCell.Value IsNot DBNull.Value) Then
                        If dgIndicador.CurrentCell.Value < 0 Then
                            dgIndicador.CurrentCell.Value = DBNull.Value
                        End If
                        Dim cadena As String = ""
                        cadena = HelpClass.ObjectToString(dgIndicador.CurrentCell.Value)
                        If (InStr(".", cadena) = 0) Then
                            dgIndicador.CurrentCell.Value = HelpClass.ObjectToUInt64(HelpClass.ParteNumerica(cadena))
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgIndicador_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgIndicador.DataError
        Try
            If dgIndicador.CurrentCellAddress.X < 0 Then Exit Sub
            If (EvaluarColumna(e.ColumnIndex) = False) Then Exit Sub
            If dgIndicador.CurrentCell.Value Is DBNull.Value Then Exit Sub

            If (oHasColumnasTabla.ContainsKey(dgIndicador.Columns(e.ColumnIndex).Name)) Then

                If (IsNumeric(dgIndicador.CurrentCell.Value)) Then
                    If (dgIndicador.CurrentCell.Value.ToString.Length > 10) Then
                        dgIndicador.CurrentCell.Value = DBNull.Value
                    End If

                    If (dgIndicador.CurrentCell.Value IsNot DBNull.Value) Then
                        If dgIndicador.CurrentCell.Value < 0 Then
                            dgIndicador.CurrentCell.Value = DBNull.Value
                        End If
                        Dim cadena As String = ""
                        cadena = HelpClass.ObjectToString(dgIndicador.CurrentCell.Value)
                        If (InStr(".", cadena) = 0) Then
                            dgIndicador.CurrentCell.Value = HelpClass.ObjectToDecimal(HelpClass.ParteNumerica(cadena))
                        End If
                    End If


                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    
    Private Function EvaluarColumna(ByVal columna As Int32) As Boolean
        Dim retorno As Boolean = False
        Select Case columna
            Case 1 To 4
            Case 43 To 44          
                retorno = False
            Case Else
                retorno = True
        End Select
        Return retorno
    End Function
    Private Sub dgIndicador_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellEndEdit
        Try
            If dgIndicador.CurrentCellAddress.X < 0 Then Exit Sub
            If (EvaluarColumna(e.ColumnIndex) = False) Then Exit Sub
            If dgIndicador.CurrentCell.Value Is DBNull.Value Then Exit Sub
            If (oHasColumnasTabla.ContainsKey(dgIndicador.Columns(e.ColumnIndex).Name)) Then
                If (IsNumeric(dgIndicador.CurrentCell.Value)) Then
                    If (HelpClass.ObjectToString(dgIndicador.CurrentCell.Value).Length > 10) Then
                        dgIndicador.CurrentCell.Value = DBNull.Value
                    End If
                    If (dgIndicador.CurrentCell.Value IsNot DBNull.Value) Then
                        If dgIndicador.CurrentCell.Value < 0 Then
                            dgIndicador.CurrentCell.Value = DBNull.Value
                        End If
                        Dim cadena As String = ""
                        cadena = HelpClass.ObjectToString(dgIndicador.CurrentCell.Value)
                        If (InStr(".", cadena) = 0) Then
                            dgIndicador.CurrentCell.Value = HelpClass.ObjectToDecimal(HelpClass.ParteNumerica(cadena))
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Try
            Dim obrIndicador As New brIndicador()
            If (CalculoUnitario = False) Then
                odtInfoIndicador = obrIndicador.CalcularListarIndicador(oInfoIndicador).Tables(0)
            Else
                odtCalculo = obrIndicador.CalcularListarIndicador(oInfoIndicador).Tables(0)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try
            ActualizarDatos()
            pcxEspera.Visible = False
            tspOpcion.Enabled = True
            dgIndicador.Enabled = True
        Catch ex As Exception
            pcxEspera.Visible = False
            dgIndicador.Enabled = True
            tspOpcion.Enabled = True
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            dgIndicador.EndEdit()
            Dim str As String = ""
            Dim oListIndicadores As New List(Of beIndicador)
            Dim obrIndicador As New brIndicador
            Dim obeIndicador As beIndicador
            Dim strDia As String = ""
            Dim retorno As Int32 = 0
            Dim row_count As Int32 = dgIndicador.Rows.Count - 1
            For indexFila As Integer = 0 To row_count
                If (EsFilaEditable(HelpClass.ObjectToString(dgIndicador.Item("SINDC", indexFila).Value).ToUpper)) Then
                    For indexCol As Integer = 1 To MaxDiaMes
                        If (HaCambiadoValorCelda(dgIndicador.Item("CTPOIN", indexFila).Value, dgIndicador.Item(FormatoNombreColumna(indexCol), indexFila).Value, FormatoNombreColumna(indexCol)) = True) Then
                            obeIndicador = New beIndicador
                            obeIndicador.PNCCLNT = oInfoIndicador.PNCCLNT
                            obeIndicador.PNANIOEMI = oInfoIndicador.PNANIOEMI
                            obeIndicador.PSCCMPN = oInfoIndicador.PSCCMPN
                            obeIndicador.PSCDVSN = oInfoIndicador.PSCDVSN
                            obeIndicador.PNMESEMI = oInfoIndicador.PNMESEMI
                            obeIndicador.PNCTPOIN = HelpClass.ObjectToDecimal(dgIndicador.Item("CTPOIN", indexFila).Value)
                            obeIndicador.PSCULUSA = objSeguridadBN.pUsuario
                            obeIndicador.PSNTRMNL = objSeguridadBN.pstrPCName
                            obeIndicador.PNDDEMI = indexCol
                            obeIndicador.PNQAINSM = HelpClass.ObjectToDecimal(dgIndicador.Item(FormatoNombreColumna(indexCol), indexFila).Value)
                            oListIndicadores.Add(obeIndicador)
                        End If
                    Next
                End If
            Next
            If (oListIndicadores.Count > 0) Then
                retorno = obrIndicador.ActualizarResumenIndicadorMensual(oListIndicadores, MaxDiaMes)
            Else
                retorno = 2
            End If
            If (retorno = 0) Then
                MessageBox.Show("La operación no se pudo realizar", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf retorno = 1 Then
                MessageBox.Show("La operación se realizó satisfactoriamente", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myDialogOk = True
                Me.Close()
            ElseIf retorno = 2 Then
                MessageBox.Show("No existen datos que  actualizar", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Function ObtenerIndicadores() As String
        Dim strFiltroTMP As New StringBuilder()
        Dim strFiltro As String = ""
        For Each dr As DataRow In odtInfoIndicadorInicio.Rows
            strFiltroTMP.Append(dr.Item("CTPOIN").ToString & ",")
        Next
        strFiltro = strFiltroTMP.ToString.Substring(0, strFiltroTMP.ToString.Length - 1)
        Return strFiltro
    End Function
    Private Sub btnCalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculo.Click
        Try
            odtInfoIndicador.Rows.Clear()
            dgIndicador.Enabled = False
            dgIndicador.DataSource = Nothing
            pcxEspera.Visible = True
            tspOpcion.Enabled = False
            CalculoUnitario = False
            oInfoIndicador.PSFILTRO_CTPOIN = ObtenerIndicadores()
            bgwGifAnimado.RunWorkerAsync()
        Catch ex As Exception
            pcxEspera.Visible = False
            dgIndicador.Enabled = True
        End Try
    End Sub
    Private Sub dgIndicador_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If (e.ColumnIndex = 0) Then

                If (EsFilaCalculable(dgIndicador.Rows(e.RowIndex).Cells("FLAG_TIPO").Value)) Then
                    odtCalculo.Rows.Clear()
                    dgIndicador.Enabled = False
                    oInfoIndicador.PSFILTRO_CTPOIN = dgIndicador.Rows(e.RowIndex).Cells("CTPOIN").Value.ToString
                    oInfoIndicador.PNFILA = e.RowIndex
                    For Each drv As DataGridViewRow In dgIndicador.Rows
                        drv.DefaultCellStyle.BackColor = Color.White
                    Next
                    pcxEspera.Visible = True
                    CalculoUnitario = True
                    tspOpcion.Enabled = False
                    bgwGifAnimado.RunWorkerAsync()
                Else
 

                    If CInt(dgIndicador.Rows(e.RowIndex).Cells("CTPOIN").Value.ToString) > 120 Then

                        Me.dgIndicador.EditMode = DataGridViewEditMode.EditProgrammatically
                        Dim objMantIncidencia As New frmMantIncidencia
                        objMantIncidencia.Indicador = oInfoIndicador
                        objMantIncidencia.Mes = oInfoIndicador.PNMESEMI
                        objMantIncidencia.Anio = oInfoIndicador.PNANIOEMI
                        objMantIncidencia.Indicador.PNCTPOIN = dgIndicador.Rows(e.RowIndex).Cells("CTPOIN").Value.ToString
                        objMantIncidencia.ShowDialog(Me)

                        Dim lbool_result As Boolean = objMantIncidencia.resultado
                        Dim lint_dia As Integer = objMantIncidencia.DiaActualizable
                        Dim lcadena As String = ""

                        If lbool_result = True Then 'reemplaza el valor por uno mas y graba
                            Dim lbuscado As String = ""

                            For i As Integer = 0 To Me.dgIndicador.ColumnCount - 1

                                If lint_dia < 10 Then
                                    lcadena = AbrevMes & "-0" & lint_dia
                                Else
                                    lcadena = AbrevMes & "-" & lint_dia
                                End If

                                lcadena = lcadena.Replace(" ", "")
                                lbuscado = Me.dgIndicador.Columns(i).HeaderText.ToString().Replace(" ", "")

                                'reemplazando el texto encontrado
                                If lbuscado = lcadena Then

                                    Dim valor As Integer = 0

                                    If dgIndicador.Rows(e.RowIndex).Cells(i).Value Is DBNull.Value Then
                                        valor = 0
                                    Else
                                        valor = CInt(dgIndicador.Rows(e.RowIndex).Cells(i).Value)
                                    End If

                                    dgIndicador.Rows(e.RowIndex).Cells(i).Value = valor + 1

                                    Dim valor_original As Integer
                                    If dgIndicador.Rows(e.RowIndex).Cells(i).Value Is DBNull.Value Then
                                        valor_original = 0
                                    Else
                                        If dgIndicador.Rows(e.RowIndex).Cells(i).Value = "" Then
                                            valor_original = 0
                                        Else
                                            valor_original = CInt(dgIndicador.Rows(e.RowIndex).Cells(i).Value)
                                        End If
                                    End If

                                    dgIndicador.Rows(e.RowIndex).Cells(i).Value = valor_original + +1
                                End If

                            Next

                        End If

                        MsgBox("Pulse el boton guardar para actualizar los cambios en el sistema.Gracias")

                    Else
                        Me.dgIndicador.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                        MessageBox.Show("Ingrese manualmente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If
            End If
        Catch ex As Exception

        End Try
      
    End Sub
    Private Sub ActualizarRegistroCalculado()
        Dim columna As String = ""
        For Each drv As DataGridViewRow In dgIndicador.Rows
            If (drv.Cells("CTPOIN").Value = HelpClass.ObjectToDecimal(oInfoIndicador.PSFILTRO_CTPOIN)) Then
                For index As Integer = 1 To MaxDiaMes
                    columna = FormatoNombreColumna(index)
                    drv.Cells(columna).Value = odtCalculo.Rows(0).Item(columna)
                Next
                drv.Cells("TOTAL").Value = odtCalculo.Rows(0).Item("TOTAL")
                drv.Cells("PROMEDIO").Value = odtCalculo.Rows(0).Item("PROMEDIO")
                Exit For
            End If
        Next
        dgIndicador.Rows(oInfoIndicador.PNFILA).DefaultCellStyle.BackColor = Color.LightYellow
    End Sub

    Private Sub dgIndicador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If (e.ColumnIndex = 0) Then
 
                If CInt(dgIndicador.Rows(e.RowIndex).Cells("CTPOIN").Value.ToString) > 120 Then
                    Me.dgIndicador.EditMode = DataGridViewEditMode.EditProgrammatically  
                Else
                    Me.dgIndicador.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                End If

            End If 
        Catch ex As Exception

        End Try

    End Sub
End Class
