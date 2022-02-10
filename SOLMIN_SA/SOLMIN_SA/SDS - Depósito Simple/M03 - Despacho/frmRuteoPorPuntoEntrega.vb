Imports RANSA.TypeDef.Cliente
Imports Ransa.NEGO
Imports ransa.TypeDef
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.Utilitario

Public Class frmRuteoPorPuntoEntrega

#Region "Atributos"
    Private _CodCliente As String
    Private _Fecha As Date

    Public Property CodCliente() As String
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As String)
            _CodCliente = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property




#End Region

#Region "Metodos y Funciones"

    Private Sub CargarClientes()

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(Me.CodCliente, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

    End Sub

    Private Sub pProcesar()

        If fblnValidaInformacion() Then
            Call pListarRuteoxPuntoEntrega()
        End If
    End Sub

    Private Sub pListarRuteoxPuntoEntrega()

        Dim obeRutaTienda As New beRutaTienda
        Dim obrRutaTienda As New brRutaTienda
        With obeRutaTienda
            .PNCCLNT = txtCliente.pCodigo
            .PNFECDES = HelpClass.CFecha_a_Numero8Digitos(Me.dtpFecha.Value)
        End With
        dtgRuteoxPedido.DataSource = obrRutaTienda.ListarRuteoxPuntoEntrega(obeRutaTienda)
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        'If eValidacion = eTipoValidacion.PROCESAR Then
        '    If txtCliente.pClienteSeleccionado .pCCLNT_Cliente = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        'Else
        '    Dim objPrimaryKey_Despacho As clsPrimaryKey_Despacho = New clsPrimaryKey_Despacho
        '    With objPrimaryKey_Despacho
        '        .pintCodigoCliente_CCLNT = txtCliente.pClienteSeleccionado .pCCLNT_Cliente
        '        .pstrNroGuiaSalida_NRGUSA = dgGuiasRansa.CurrentRow.Cells("GS_NGUIRN").Value
        '    End With
        '    If dgGuiasRansa.RowCount <= 0 Then strMensajeError &= "No existe Guías de Salida para realizar el Proceso. " & vbNewLine
        '    ' Validamos los valores de la Guía de Salida
        '    With dgGuiasRansa
        '        Select Case eValidacion
        '            Case eTipoValidacion.ANULAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida ya se encuentra anulada. " & vbNewLine
        '                If mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "La presente Guía de Salida tiene Guía(s) de Remisión. " & vbNewLine
        '            Case eTipoValidacion.GENERAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida esta anulada. " & vbNewLine
        '                If mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "Ya se han generado las Guías de Remisión. " & vbNewLine
        '            Case eTipoValidacion.RESTAURAR
        '                If .CurrentRow.Cells("GS_SESTRG").Value = "*" Then strMensajeError &= "Guía de Salida se encuentra anulada. " & vbNewLine
        '                If Not mfblnExiste_GuiaSalidaConGuiaRemision(objPrimaryKey_Despacho) Then _
        '                    strMensajeError &= "La presente Guía de Salida no tiene Guía(s) de Remisión. " & vbNewLine
        '        End Select
        '    End With
        'End If
        'If strMensajeError <> "" Then
        '    blnResultado = False
        '    MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        Return blnResultado
    End Function

    Private Function OrdenarCorrelativo() As List(Of beRutaTienda)
        Dim mRutaTienda As New List(Of beRutaTienda)  ' creamos lista de objetos
        Dim obeRutaTienda As beRutaTienda  ' creamos el objeto entidad 
        Me.dtgRuteoxPedido.EndEdit()
        For Each row As DataGridViewRow In dtgRuteoxPedido.Rows ' asignamos el datagrid a la coleccion de filas y lo recorremos
            If row.Cells("check").Value = "S" Then  'comrpobamos ke la fila tenga el checkbox en true
                obeRutaTienda = New beRutaTienda    ' limpiamos el objeto entidad por cada recorrido
                obeRutaTienda.PNNCRRRT = Val(row.Cells("NCRRRT").Value.ToString.Trim) 'asignamos datos al objeto entidad
                obeRutaTienda.PSGPSLAT = Val(row.Cells("GPSLAT").Value.ToString.Trim)
                obeRutaTienda.PSGPSLON = Val(row.Cells("GPSLON").Value.ToString.Trim)
                mRutaTienda.Add(obeRutaTienda) 'agregamos el objeto a la lista
            End If
        Next
        mRutaTienda.Sort(AddressOf Me.SortRuta) 'ordenamos la lista de objetos
        Return mRutaTienda ' retornamos la lista
    End Function

    Private Function SortRuta(ByVal b1 As beRutaTienda, ByVal b2 As beRutaTienda) As Integer
        Return b1.PNNCRRRT.CompareTo(b2.PNNCRRRT) ' ordenamos la lista
    End Function

#End Region

#Region "Eventos"

    Private Sub frmRuteoPorPuntoEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        bsaOcultarFiltros.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

        UCDataGridView.Alinear_Columnas_Grilla(Me.dtgRuteoxPedido)
        Me.dtgRuteoxPedido.AutoGenerateColumns = False
        CargarClientes()
        Me.dtpFecha.Value = Fecha
        Call pProcesar()
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Call pProcesar()
    End Sub

    Private Sub dtgRuteoxPedido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRuteoxPedido.CellContentClick
        Try
            If Me.dtgRuteoxPedido.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.dtgRuteoxPedido.CurrentRow.Selected = False Then Exit Sub
            Select Case Me.dtgRuteoxPedido.Columns(e.ColumnIndex).Name
                Case "SEGUIMIENTO"
                    Dim objGpsBrowser As New frmMapa
                    With objGpsBrowser

                        .Latitud = dtgRuteoxPedido.Item("GPSLAT", dtgRuteoxPedido.CurrentCellAddress.Y).Value.ToString.Trim()
                        .Longitud = dtgRuteoxPedido.Item("GPSLON", dtgRuteoxPedido.CurrentCellAddress.Y).Value.ToString.Trim()
                        .Cliente = Me.txtCliente.pRazonSocial
                        .Fecha = Date.Now
                        .Hora = Me.dtpFecha.Value.ToString("HH:mm:ss")
                        .WindowState = FormWindowState.Maximized
                        .ShowForm(.Latitud, .Longitud, Me)
                    End With
            End Select
        Catch : End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.dtgRuteoxPedido.Rows.Count > 0 Then
                Dim str_NumPedido As String = ""
                Me.dtgRuteoxPedido.EndEdit()
                For Each row As DataGridViewRow In dtgRuteoxPedido.Rows
                    If row.Cells("check").Value = "S" Then
                        str_NumPedido = str_NumPedido & row.Cells("CDPEPL").Value & ","
                    End If
                Next
                str_NumPedido = str_NumPedido.TrimEnd(",")
                ShowFormImprimir(str_NumPedido)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ShowFormImprimir(ByVal str_NumPedido As String)
        Try
            Dim frmPrintForm As New PrintForm
            Dim oblPedido As New brPedido
            Dim objetoParametro As New Hashtable
            Dim orptRuteoPorPuntoEntrega_1 As New rptRuteoPorPuntoEntrega_1
            Dim odsRPT As New DataSet
            Dim odtReport As New DataTable()
            Dim odtReportResumen As New DataTable
            objetoParametro.Add("PNCDPEPL", str_NumPedido)
            odsRPT = oblPedido.ReporteGuiaDeRemisionXPedido(objetoParametro)
            orptRuteoPorPuntoEntrega_1.SetDataSource(odsRPT.Tables(0))
            orptRuteoPorPuntoEntrega_1.Subreports.Item("rptRutas").SetDataSource(odsRPT.Tables(1))
            orptRuteoPorPuntoEntrega_1.Refresh()
            orptRuteoPorPuntoEntrega_1.SetParameterValue("lblUsuario", objSeguridadBN.pUsuario)
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(orptRuteoPorPuntoEntrega_1, Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub brnRuteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnRuteo.Click
        Try
            If Me.dtgRuteoxPedido.Rows.Count > 0 Then
                Dim lstr_posicion_gps As String = ""
                Dim lstr_documento_xml As String = ""
                Dim archivo As String = ""
                Dim pStart As New System.Diagnostics.Process
                Dim str_localizacion As String = ""
                Dim lint_indice As Integer = 0
                Dim Cont As Integer = 0
                Me.dtgRuteoxPedido.EndEdit()
                Dim mRutaTienda1 As New List(Of beRutaTienda)
                mRutaTienda1 = Me.OrdenarCorrelativo()
                For lint_Contador As Integer = 0 To mRutaTienda1.Count - 1
                    str_localizacion += "" & mRutaTienda1(lint_Contador).PSGPSLAT & "," & mRutaTienda1(lint_Contador).PSGPSLON & "|"
                    Cont = Cont + 1
                Next
                str_localizacion = (Cont) & "|" & str_localizacion.Substring(0, str_localizacion.Length - 2)
                Dim objGpsBrowser As New frmMapa
                With objGpsBrowser
                    .localiza = str_localizacion
                    .Cliente = Me.txtCliente.pRazonSocial
                    .Fecha = Date.Now
                    .Hora = Me.dtpFecha.Value.ToString("HH:mm:ss")
                    .WindowState = FormWindowState.Maximized
                    .ShowForm_1(.localiza, Me)
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtgRuteoxPedido_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgRuteoxPedido.ColumnHeaderMouseClick
        If Me.dtgRuteoxPedido.RowCount = 0 Then Exit Sub
        Dim obeRutaTienda As New List(Of beRutaTienda)
        obeRutaTienda = dtgRuteoxPedido.DataSource
        Dim oucOrdena As UCOrdena(Of beRutaTienda)
        oucOrdena = New UCOrdena(Of beRutaTienda)(Me.dtgRuteoxPedido.Columns(e.ColumnIndex).Name, UCOrdena(Of beRutaTienda).TipoOrdenacion.Ascendente)
        obeRutaTienda.Sort(oucOrdena)
        Me.dtgRuteoxPedido.DataSource = obeRutaTienda
        Me.dtgRuteoxPedido.Refresh()
    End Sub

#End Region

  
End Class
