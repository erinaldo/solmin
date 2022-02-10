Imports SOLMIN_CTZ.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades
Public Class ucCalendario
    Private MaxDiasMes As Int64 = 0
    Private AbrMes As String = ""
    Private odtMeses As New DataTable
    Private odtCalendario As New DataTable
    Private CargaMes As Boolean = False
    Private CargaAnio As Boolean = False
    Private oHashListFeriados As New Hashtable
    Private Mes As Int32 = 50
    Private Anio As Int32 = -1
    Public Sub ActualizarCalendario(ByVal PNANIO As Int32, ByVal PNMES As Int32, ByVal Cargar As Boolean)

        Try
            Dim ci As Globalization.CultureInfo
            ci = New Globalization.CultureInfo("es-ES")

            If (Cargar = False) Then
                dgvCalendario.DataSource = Nothing
                lblTitulo.Text = Convert.ToDateTime(HelpClass.CNumero8Digitos_a_FechaDefault(Anio.ToString & ClsCalendarioFeriado.StringRight("0" & Mes, 2) & "01")).ToString("MMMM", ci)
                lblTitulo.Text = StrConv(lblTitulo.Text, VbStrConv.ProperCase)
            Else
                Anio = PNANIO
                Mes = PNMES
                lblTitulo.Text = Anio & " - " & Convert.ToDateTime(HelpClass.CNumero8Digitos_a_FechaDefault(Anio.ToString & ClsCalendarioFeriado.StringRight("0" & Mes, 2) & "01")).ToString("MMMM", ci)
                lblTitulo.Text = StrConv(lblTitulo.Text, VbStrConv.ProperCase)
                dgvCalendario.AutoGenerateColumns = False
                Actualizar()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Actualizar()
        ClsCalendarioFeriado.MaxDiasAbrevMes(Anio, Mes, MaxDiasMes, AbrMes)
        odtCalendario = ClsCalendarioFeriado.CalendarioFormato(Anio, Mes)
        dgvCalendario.DataSource = odtCalendario
        RepintarFeriados()
    End Sub
    Private Function nomColDiaSemana(ByVal dia As Int32)
        Dim strNomDia As String = dia.ToString
        strNomDia = "0" & strNomDia
        strNomDia = ClsCalendarioFeriado.StringRight(strNomDia, 2)
        strNomDia = "DIASEM" & strNomDia
        Return strNomDia
    End Function
    Private Sub RepintarFeriados()
        Dim FechaInicial As String = "", Fecha = "", numDiaSem = ""
        Dim obrCalendario As New clsCalendario()
        Dim odtFeriados As New DataTable
        Dim obeCalendario As New beCalendario
        Dim FILAS As Int32 = 0

        obeCalendario = ObtenerEntidad()
        odtFeriados = obrCalendario.ListarCalendarioMensual(obeCalendario)
        oHashListFeriados.Clear()
        For Each dr As DataRow In odtFeriados.Rows
            oHashListFeriados.Add(dr.Item("FFRDO").ToString, dr.Item("TFRDO").ToString.Trim)
        Next

        dgvCalendario.DataSource = Nothing
        dgvCalendario.DataSource = odtCalendario

        FechaInicial = Anio.ToString & ClsCalendarioFeriado.StringRight("0" & Mes, 2)
        FILAS = dgvCalendario.Rows.Count - 1

        For i As Integer = 0 To FILAS
            For j As Integer = 1 To 7
                numDiaSem = dgvCalendario.Item(nomColDiaSemana(j), i).Value
                If (numDiaSem <> "") Then
                    Fecha = FechaInicial & ClsCalendarioFeriado.StringRight(("0" & numDiaSem), 2)
                    If (oHashListFeriados.ContainsKey(Fecha) = True) Then
                        dgvCalendario.Item(nomColDiaSemana(j), i).Style.ForeColor = Color.Red
                        dgvCalendario.Item(nomColDiaSemana(j), i).Tag = "F" & oHashListFeriados(Fecha)
                    End If
                End If
            Next
        Next
    End Sub
    Private Function ObtenerEntidad() As beCalendario
        Dim obeCalendario As New beCalendario
        obeCalendario.PNANIO = Anio
        obeCalendario.PNMES = Mes
        obeCalendario.PNMAXDIAMES = MaxDiasMes
        Return obeCalendario
    End Function


    Private Sub dgvCalendario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCalendario.CellDoubleClick
        Try
            Dim PNDIA As Int64 = 0
            Dim strTag As String = "", strDia = ""
            Dim PNFFRDO As Int32 = 0

            strDia = dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Value
            If (strDia = "") Then
                Exit Sub
            End If
            Dim obeCalendario As New beCalendario
            PNFFRDO = Ransa.Utilitario.HelpClass.ObjectToInt32(Anio.ToString & ClsCalendarioFeriado.StringRight("0" & Mes, 2) & ClsCalendarioFeriado.StringRight("0" & strDia, 2))
            PNDIA = dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Value
            dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Style.SelectionForeColor = dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Style.ForeColor
            obeCalendario = ObtenerEntidad()
            obeCalendario.PNDIA = PNDIA
            obeCalendario.PNFFRDO = PNFFRDO
            strTag = Ransa.Utilitario.HelpClass.ObjectToString(dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Tag)
            If (strTag <> "") Then
                obeCalendario.PSFERIADO = strTag.Substring(0, 1)
                obeCalendario.PSTFRDO = strTag.Substring(1, strTag.Length - 1)
            End If
            Dim ofrmOpcionCalendario As New frmOpcionCalendario()
            ofrmOpcionCalendario.oInfoEntidad = obeCalendario
            ofrmOpcionCalendario.ShowDialog(Me)
            If (ofrmOpcionCalendario.myDialogResultOk = True) Then
                RepintarFeriados()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvCalendario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCalendario.CellClick
        Try
            dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Style.SelectionForeColor = dgvCalendario.CurrentRow.Cells(e.ColumnIndex).Style.ForeColor
        Catch ex As Exception
        End Try

    End Sub
End Class
