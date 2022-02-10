Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmOperacionesSustento

    Public pCCMPN As String
    Public pCCLNT As Double
    Public pNROVLR As Double
    Public pCantRegistros As Int32
    Public pDialog As Boolean = False
    Public pValorizConDocGenerado As String = ""
    Public pOperacionAdmin As Decimal = 0
    'Private pNCRROP As Decimal = 0
    Private Sub frmAgregarServicioValorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'LISTA DATOS CABECERA
            Lista_Operacion_Administracion_Valorizacion()

            'VISUALIZAR LISTADO
            Lista_Operaciones_Sustento_Por_Operacion_Administrativa()


            If pValorizConDocGenerado = "X" Then 'si la valorización ya tiene documento generado
                btnAgregar.Enabled = False
                btnEliminar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Lista_Operaciones_Sustento_Por_Operacion_Administrativa()
        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion
        dtgOperacionesSustento.DataSource = Nothing
        dtgOperacionesSustento.AutoGenerateColumns = False

        With Entidad
            .CCMPN = pCCMPN
            .CCLNT = pCCLNT
            .NOPRSD = Val(txtOpAdmin.Text)
        End With
        dtgOperacionesSustento.DataSource = Negocio.Lista_Operaciones_Sustento_Por_Operacion_Administrativa(Entidad)
        'pCantRegistros = dtgOperacionesSustento.Rows.Count

    End Sub

    Sub Lista_Operacion_Administracion_Valorizacion()

        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion
        Dim dtCabecera As New DataTable
        dtgOperacionesSustento.DataSource = Nothing
        dtgOperacionesSustento.AutoGenerateColumns = False

        With Entidad
            .CCMPN = pCCMPN
            .NROVLR = pNROVLR
            .NOPRSD = pOperacionAdmin
        End With

        dtCabecera = Negocio.Lista_Operacion_Administracion_Valorizacion(Entidad)

        If dtCabecera.Rows.Count > 0 Then
            txtOpAdmin.Text = dtCabecera.Rows(0)("NOPRCN").ToString
            txtMoneda.Text = dtCabecera.Rows(0)("TSGNMN").ToString
            txtCantViajes.Text = CInt(dtCabecera.Rows(0)("VALCTE").ToString)
            txtTarifa.Text = Math.Round(dtCabecera.Rows(0)("IVLSRV"), 3)
            'pNCRROP = dtCabecera.Rows(0)("NCRROP")
        End If

    End Sub


    Private Sub Agregar(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            Dim ofrmAsignarOperacionesSustento As New frmAsignarOperacionesSustento
            ofrmAsignarOperacionesSustento.pCCMPN = pCCMPN
            ofrmAsignarOperacionesSustento.pCCLNT = pCCLNT
            ofrmAsignarOperacionesSustento.pNOPRSD = Val(txtOpAdmin.Text)
            ofrmAsignarOperacionesSustento.pNROVLR = pNROVLR
            'ofrmAsignarOperacionesSustento.pNCRROP = pNCRROP
            'ofrmAsignarOperacionesSustento.pCantRegistrosAnterior = pCantRegistros

            'If ofrmAsignarOperacionesSustento.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    'VISUALIZAR LISTADO
            '    Lista_Operaciones_Sustento_Por_Operacion_Administrativa()
            'End If

            ofrmAsignarOperacionesSustento.ShowDialog()
            pDialog = ofrmAsignarOperacionesSustento.pDialog
            'LISTA DATOS CABECERA
            Lista_Operacion_Administracion_Valorizacion()

            'VISUALIZAR LISTADO
            Lista_Operaciones_Sustento_Por_Operacion_Administrativa()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Eliminar(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim msgError As String = ""
            Dim ListaMsgError As String = ""
            If dtgOperacionesSustento.Rows.Count = 0 Then Exit Sub

            Me.dtgOperacionesSustento.EndEdit()

            If dtgOperacionesSustento.CurrentRow Is Nothing Then Exit Sub

            If Seleccionar_Registro() = False Then
                MessageBox.Show("Se debe seleccionar mínimo un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If
            'If dtgOperacionesSustento.CurrentRow Is Nothing Then Exit Sub

            pDialog = True

            For Each row As DataGridViewRow In Me.dtgOperacionesSustento.Rows
                If row.Cells("CHK").Value = True Then

                    Dim Negocio As New clsMantValorizacion
                    Dim Entidad As New beMantValorizacion


                    With Entidad
                        .CCMPN = pCCMPN
                        .CCLNT = pCCLNT
                        .NROVLR = pNROVLR
                        .NOPRSD = CDbl(row.Cells("NOPRSD").Value)
                        .NRITEM = CDec(row.Cells("NRITEM").Value)
                        '.NOPRCN = CDec(row.Cells("NOPRCN").Value)
                    End With

                    msgError = Negocio.Eliminar_Operacion_Administrativa(Entidad)

                    If msgError.Trim.Length > 0 Then
                        ListaMsgError = ListaMsgError + " | " + msgError
                    End If

                End If
            Next

            If ListaMsgError.Trim.Length = 0 Then
                MessageBox.Show("Operaciones sustento eliminadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Lista_Operacion_Administracion_Valorizacion()
                Lista_Operaciones_Sustento_Por_Operacion_Administrativa()
            Else
                MessageBox.Show(ListaMsgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'Else
            '    MessageBox.Show("Se debe seleccionar mínimo un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Seleccionar_Registro() As Boolean

        Dim Respuesta As Boolean = False

        For Each row As DataGridViewRow In Me.dtgOperacionesSustento.Rows
            If row.Cells("CHK").Value = True Then
                Respuesta = True
            End If
        Next

        Return Respuesta

    End Function


    Dim Seleccionado As Boolean = True

    Private Sub btnCheckTodo_Click(sender As Object, e As EventArgs) Handles btnCheckTodo.Click
        Try
            For Each row As DataGridViewRow In dtgOperacionesSustento.Rows
                row.Cells("CHK").Value = Seleccionado
            Next
            dtgOperacionesSustento.EndEdit()
            Seleccionado = Not Seleccionado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Public Function TransformarGrilla(ByVal gv As DataGridView) As DataTable
        Dim dtData As New DataTable
        For Each Item As DataGridViewColumn In gv.Columns
            'If Item.Visible = True And (Item.Name <> "ENVIOS" And Item.Name <> "RPTA_A_TIEMPO") Then
            If Item.Visible = True And Item.Name <> "CHK" Then
                dtData.Columns.Add(Item.Name)
            End If


            'End If
        Next


        Dim dr As DataRow
        Dim NameColumna As String = ""
        For Each Item As DataGridViewRow In gv.Rows
            dr = dtData.NewRow
            For Each dcColumna As DataColumn In dtData.Columns
                NameColumna = dcColumna.ColumnName
                dr(NameColumna) = Item.Cells(NameColumna).Value
            Next
            dtData.Rows.Add(dr)
        Next

        For Each Item As DataColumn In dtData.Columns
            Item.ColumnName = gv.Columns(Item.ColumnName).HeaderText
        Next

        Return dtData

    End Function


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim ODs As New DataSet
            Dim objDt As DataTable
            objDt = TransformarGrilla(Me.dtgOperacionesSustento)
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "COMPAÑIA : " & " " & cboCompania.CCMPN_Descripcion))
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TIPOENCABEZADO.FILTRO, "CLIENTE : " & IIf(UcCliente.pCodigo = 0, "TODOS", UcCliente.pCodigo & " - " & UcCliente.pRazonSocial)))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "OPERACIONES"))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "0.00"))
            'If objDt.Columns("N° DOCUMENTO") IsNot Nothing Then
            '    objDt.Columns("N° DOCUMENTO").Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            'End If
            ODs.Tables.Add(objDt.Copy)
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


