Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmAsignarOperacionesSustento

    Public pCCMPN As String
    Public pCDVSN As String
    Public pCPLNDV As Double
    Public pCCLNT As Double
    Public pNOPRSD As Double
    Public pNROVLR As Double
    Private dtRangoTarifas As DataTable
    Private pCantRegistrosAnterior As Int32
    Public pDialog As Boolean = False
    Dim dsResultado As DataSet
    'Public pNCRROP As Decimal = 0
    Private Sub frmAgregarServicioValorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Actualizar_CantidadViajes()
            Cargar_Tipo_Valorizacion()
            Listar_Tarifas_Rango_Valorizacion()
            dtpFechaServicioInicio.Value = DateTime.Now.AddMonths(-1)


            ActualizarVistaTarifa()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizarVistaTarifa()
        txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
        txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
    End Sub


    Private Sub Actualizar_CantidadViajes()
        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion
        Dim dtCabecera As New DataTable
     

        With Entidad
            .CCMPN = pCCMPN
            .NROVLR = pNROVLR
            .NOPRSD = pNOPRSD
        End With

        dtCabecera = Negocio.Lista_Operacion_Administracion_Valorizacion(Entidad)

        If dtCabecera.Rows.Count > 0 Then
            pCantRegistrosAnterior = CInt(dtCabecera.Rows(0)("VALCTE").ToString)
        End If

    End Sub


    Sub Listar_Tarifas_Rango_Valorizacion()

        dtRangoTarifas = Nothing

        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion

        With Entidad
            .CCMPN = pCCMPN
            .CCLNT = pCCLNT
            .NOPRCN = pNOPRSD
        End With

        dtRangoTarifas = Negocio.Listar_Tarifas_Rango_Valorizacion(Entidad)

    End Sub

    Sub Cargar_Tipo_Valorizacion()

        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add("PSCODIGO")
        dt.Columns.Add("PSDESCRIPCION")

        dr = dt.NewRow
        dr("PSCODIGO") = "C"
        dr("PSDESCRIPCION") = "Con Guías Cargadas"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("PSCODIGO") = "S"
        dr("PSDESCRIPCION") = "Sin Guías Cargadas"
        dt.Rows.Add(dr)

        cboTipoValorizacion.DataSource = dt
        cboTipoValorizacion.ValueMember = "PSCODIGO"
        cboTipoValorizacion.DisplayMember = "PSDESCRIPCION"
        cboTipoValorizacion.SelectedValue = "C"

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
        
            Listar_Registros()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Sub Seleccionar_Registros_Check()
    '    For Each row As DataGridViewRow In Me.dtgAsignarOperacionesSustento.Rows
    '        row.Cells("CHK").Value = True
    '    Next
    '    dtgAsignarOperacionesSustento.EndEdit()
    'End Sub

    Sub Listar_Registros()

        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion
        dtgAsignarOperacionesSustento.AutoGenerateColumns = False
        dtgAsignarOperacionesSustento.DataSource = Nothing

        dsResultado = Nothing
        txtConGRCargadas.Text = "0"
        txtSinGRCargadas.Text = "0"

        Entidad.FATNSR_INI = CDec(Me.dtpFechaServicioInicio.Value.ToString("yyyyMMdd"))
        Entidad.FATNSR_FIN = CDec(Me.dtpFechaServicioFin.Value.ToString("yyyyMMdd"))
        Entidad.CCLNT = pCCLNT

        dsResultado = Negocio.Lista_Operaciones_Pendientes_Sustento_Rango_Viaje(Entidad)

        If dsResultado Is Nothing Then Exit Sub

        txtConGRCargadas.Text = dsResultado.Tables(0).Rows.Count
        txtSinGRCargadas.Text = dsResultado.Tables(1).Rows.Count

        If cboTipoValorizacion.SelectedValue = "C" Then
            dtgAsignarOperacionesSustento.DataSource = dsResultado.Tables(0)
            'txtCantViajes.Text = pCantRegistrosAnterior + dtgAsignarOperacionesSustento.Rows.Count
            'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
        Else
            dtgAsignarOperacionesSustento.DataSource = dsResultado.Tables(1)
            'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados() ' dtgAsignarOperacionesSustento.Rows.Count
            'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
        End If

        'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados() ' dtgAsignarOperacionesSustento.Rows.Count
        'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
        ActualizarVistaTarifa()

        'Seleccionar_Registros_Check()

    End Sub

    Function Buscar_Tarifa(Viajes As Decimal) As Decimal

        Dim Tarifa As Decimal = 0
        Dim filtro As String = ""

        filtro = String.Format("VALMAX >= {0} AND VALMIN <= {0}", Viajes)

        Tarifa = Val("" & dtRangoTarifas.Compute("Sum(IVLSRV)", filtro))



        Return Tarifa

    End Function

    Function Seleccionar_Registro() As Boolean

        Dim Respuesta As Boolean = False

        For Each row As DataGridViewRow In Me.dtgAsignarOperacionesSustento.Rows
            If row.Cells("CHK").Value = True Then
                Respuesta = True
                Exit For
            End If
        Next

        Return Respuesta

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim msgError As String = ""
            If dtgAsignarOperacionesSustento.Rows.Count = 0 Then Exit Sub

            Me.dtgAsignarOperacionesSustento.EndEdit()

            If Seleccionar_Registro() = False Then
                MessageBox.Show("Se debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim pMargen As Decimal = 0
            Dim pCantMargen As Int64 = 0
            For Each row As DataGridViewRow In Me.dtgAsignarOperacionesSustento.Rows
                If row.Cells("CHK").Value = True Then
                    pMargen = Val("" & row.Cells("MARGEN").Value)
                    If pMargen <> 0 Then
                        pCantMargen = pCantMargen + 1
                    End If
                End If
            Next

            If pCantMargen > 0 Then
                If MessageBox.Show("Algunas operaciones seleccionadas tienen un margen diferente a 0 ( " & pCantMargen & " )." & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If

            pDialog = True
            For Each row As DataGridViewRow In Me.dtgAsignarOperacionesSustento.Rows
                If row.Cells("CHK").Value = True Then

                    Dim Negocio As New clsMantValorizacion
                    Dim Entidad As New beMantValorizacion
                    Dim dtResultado As New DataTable

                    With Entidad
                        .CCMPN = pCCMPN
                        .CCLNT = pCCLNT
                        .NOPRSD = pNOPRSD
                        .NROVLR = pNROVLR
                        .NOPRCN = row.Cells("NOPRCN").Value

                    End With

                    dtResultado = Negocio.Adicionar_Operacion_Administrativa(Entidad)

                    If dtResultado.Rows.Count > 0 Then
                        If dtResultado.Rows(0)("STATUS").ToString = "E" Then
                            msgError = msgError + dtResultado.Rows(0)("OBSRESULT").ToString
                        End If
                    End If

                End If
            Next



            If msgError.Trim.Length = 0 Then

                MessageBox.Show("Operaciones adicionadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Actualizar_CantidadViajes()

                Listar_Registros()

            Else

                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Dim Seleccionado As Boolean = False

    Private Sub btnCheckTodo_Click(sender As Object, e As EventArgs) Handles btnCheckTodo.Click
        Try
            Seleccionado = Not Seleccionado
            For Each row As DataGridViewRow In dtgAsignarOperacionesSustento.Rows
                row.Cells("CHK").Value = Seleccionado
            Next
            dtgAsignarOperacionesSustento.EndEdit()
            'Seleccionado = Not Seleccionado

            'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
            'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
            ActualizarVistaTarifa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboTipoValorizacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTipoValorizacion.SelectionChangeCommitted
        Try
            If dsResultado Is Nothing Then Exit Sub

            If cboTipoValorizacion.SelectedValue = "C" Then
                dtgAsignarOperacionesSustento.DataSource = dsResultado.Tables(0)
                'Seleccionar_Registros_Check()
                'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
                'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
            Else

                dtgAsignarOperacionesSustento.DataSource = dsResultado.Tables(1)
                'Seleccionar_Registros_Check()
                'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
                'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
            End If

            'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
            'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))

            ActualizarVistaTarifa()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub


    Function Contar_Registros_Seleccionados() As Integer

        Dim contador As Integer = 0

        For Each row As DataGridViewRow In Me.dtgAsignarOperacionesSustento.Rows
            If row.Cells("CHK").Value = True Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Private Sub dtgAsignarOperacionesSustento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAsignarOperacionesSustento.CellContentClick
        Try
            If dtgAsignarOperacionesSustento.Columns(e.ColumnIndex).Name = "CHK" Then

                Me.dtgAsignarOperacionesSustento.EndEdit()

                'If cboTipoValorizacion.SelectedValue = "C" Then
                '    txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
                '    txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
                'Else
                '    txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
                '    txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))
                'End If
                'txtCantViajes.Text = pCantRegistrosAnterior + Contar_Registros_Seleccionados()
                'txtTarifa.Text = Buscar_Tarifa(Val(txtCantViajes.Text))

                ActualizarVistaTarifa()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
 
    Public Function TransformarGrilla(ByVal gv As DataGridView) As DataTable
        Dim dtData As New DataTable
        For Each Item As DataGridViewColumn In gv.Columns
            If Item.Visible = True And Item.Name <> "CHK" Then
                dtData.Columns.Add(Item.Name)
            End If
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
            objDt = TransformarGrilla(Me.dtgAsignarOperacionesSustento)
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


