Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_st.NEGOCIO.seguimiento_wap

Public Class frmConsultaRegistrosWAP

    Private Sub frmConsultaRegistrosWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargando los combos del formulario
        Cargar_Combos()
    End Sub

    Public Sub Cargar_Combos()
        Dim objSeguimientoWap As New SeguimientoWAP_BLL
        Try
            With Me.cboRolWAP
                .DataSource = objSeguimientoWap.Listar_Roles_Wap
                .ValueMember = "NCOROL"
                .DisplayMember = "TOBS"
                .SelectedIndex = 0
            End With

            With Me.cboUsuarioWap
                .DataSource = HelpClass.GetDataSetNative(objSeguimientoWap.Listar_Usuarios_Wap)
                .KeyField = "NROMOV"
                .ValueField = "TOBS"
                .DataBind()
            End With
        Catch : End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If dtpFechaFin.Value < dtpFechaInicio.Value Then
            HelpClass.MsgBox("La fecha de inicio no puede ser posterior a la fecha final.")
            Exit Sub
        End If
        Listado_Registro_Eventos_Wap()
    End Sub

    Private Sub Listado_Registro_Eventos_Wap()
        Dim objSeguimientoWap As New SeguimientoWAP_BLL
        Dim objParametros As New Hashtable
        Dim dw As New DataView

        If Me.cboRolWAP.SelectedIndex = 0 Then
            objParametros.Add("NCOROL", "")
        Else
            objParametros.Add("NCOROL", Me.cboRolWAP.SelectedValue.ToString.Trim)
        End If

        objParametros.Add("FECINI", HelpClass.CtypeDate(Me.dtpFechaInicio.Value).ToString.Trim)
        objParametros.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFechaFin.Value).ToString.Trim)

        dw = objSeguimientoWap.Listar_Acciones_Wap(objParametros).DefaultView

        If Me.txtPlacaTracto.Text.Trim <> "" Then
            dw.RowFilter = "NPLCTR LIKE '%" & Me.txtPlacaTracto.Text.Trim & "%'"
        End If

        If Me.cboUsuarioWap.NoHayCodigo = False Then
            If dw.RowFilter.Length > 0 Then
                dw.RowFilter += " AND NROMOV='" & Me.cboUsuarioWap.Codigo & "'"
            Else
                dw.RowFilter += " NROMOV='" & Me.cboUsuarioWap.Codigo & "'"
            End If
        End If

        Me.gwdDatos.DataSource = dw.ToTable

        Me.gwdDatos.Columns(0).Visible = False
        Me.gwdDatos.Columns(1).HeaderText = "Placa Tracto"
        Me.gwdDatos.Columns(1).Width = 70
        Me.gwdDatos.Columns(2).HeaderText = "Nro Operacion"
        Me.gwdDatos.Columns(2).Width = 70
        Me.gwdDatos.Columns(2).Visible = False
        Me.gwdDatos.Columns(3).HeaderText = "Hora"
        Me.gwdDatos.Columns(3).Width = 60
        Me.gwdDatos.Columns(4).HeaderText = "Fecha"
        Me.gwdDatos.Columns(4).Width = 70
        Me.gwdDatos.Columns(5).HeaderText = "Accion / Evento"
        Me.gwdDatos.Columns(5).Width = 400
        Me.gwdDatos.Columns(6).HeaderText = "Nro Nextel"
        Me.gwdDatos.Columns(6).Width = 80
        Me.gwdDatos.Columns(7).HeaderText = "Rol de Registro"
        Me.gwdDatos.Columns(7).Width = 150

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'averiguando si es que existe el directorio a exportar
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tempo\"

        If IO.Directory.Exists(path) = False Then
            IO.Directory.CreateDirectory(path)
        End If

        Dim archivo As String = path & "reporte" & HelpClass.NowNumeric & ".xls"

        Dim xls As New IO.StreamWriter(archivo, False)

        xls.WriteLine("<TABLE border='1'>")

        xls.WriteLine("<tr>")
        For columna As Integer = 0 To Me.gwdDatos.Columns.Count - 1
            xls.Write("<td>" & Me.gwdDatos.Columns.Item(columna).HeaderText.ToString() & "</td>")
        Next
        xls.WriteLine("</tr>")

        For fila As Integer = 0 To Me.gwdDatos.Rows.Count - 1
            xls.WriteLine("<tr>")
            For columna As Integer = 0 To Me.gwdDatos.Columns.Count - 1
                xls.Write("<td>" & Me.gwdDatos.Item(columna, fila).Value.ToString() & "</td>")
            Next
            xls.WriteLine("</tr>")
        Next

        xls.WriteLine("</TABLE>")

        xls.Flush()
        xls.Close()
        xls.Dispose()

        Help.ShowHelp(Me, archivo)
    End Sub
End Class
