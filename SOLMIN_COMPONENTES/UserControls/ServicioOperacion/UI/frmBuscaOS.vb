Public Class frmBuscarOs
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
            If cmbTerminoBusqueda.Text <> "" And txtBusqueda.Text <> "" Then BuscarSolicituServicio()
        End If
    End Sub



    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case oServicio.STPODP
            Case "1"
                GrabarSolicitudServicio()
                'Case "5"
                '    bStatusSalir = pGrabarMercaderias(intNroOperInicial)
                'Case "5"
                '    GrabarSolicitudServicio()

        End Select

    End Sub

    Private Function GrabarSolicitudServicio() As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim oServicioAlmacen As New Servicio_BE

        Dim blnResultado As Boolean = True
        If Me.dtgMercaderia.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------

            For Each oDrmercaderia As DataRow In dtgMercaderia.DataSource.Rows  'Registros Hechos
                With oServicioAlmacen
                    .NOPRCN = oServicio.NOPRCN
                    .CCLNT = oServicio.CCLNT
                    .NORDSR = oDrmercaderia.Item("NORDSR")
                    .NSLCSR = oDrmercaderia.Item("NSLCSR")
                    .CPRCN1 = "" & oDrmercaderia.Item("CPRCN1") & ""
                    .NSRCN1 = "" & oDrmercaderia.Item("NSRCN1") & ""
                    .NCRRDC = Val(IIf(oDrmercaderia.Item("NCRRDC") Is DBNull.Value, 0, oDrmercaderia.Item("NCRRDC")))
                    .CPLNDV = oServicio.CPLNDV
                    .STPODP = oServicio.STPODP
                End With
                If oDrmercaderia.Item("NCRRDC").ToString.Equals("") OrElse oServicio.TIPO = "N" Then
                    oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA(oServicioAlmacen)
                    If Not oServicio.PSERROR.Equals("") Then
                        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                        blnResultado = False
                        Exit For
                    End If
                Else
                    If oServicioBL.fintActualizarDetalleServiciosFacturacionSA(oServicioAlmacen) = 0 Then
                        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                        blnResultado = False
                        Exit For
                    End If
                End If
            Next
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Function

    ''' <summary>
    ''' Busca Solicitud de servicio por Nr. guia Ingreso, Nr. Guia Salida o Nr. Guia Proveedor
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSolicituServicio()
        Dim oServicioAlmacen As New Servicio_BE
        Dim oServicioBL As New clsServicio_BL

        With oServicioAlmacen
            .CCLNT = oServicio.CCLNT
            .NOPRCN = oServicio.NOPRCN
            .CCMPN = oServicio.CCMPN
            .CDVSN = oServicio.CDVSN
            .CPLNDV = oServicio.CPLNDV
            Select Case Mid(cmbTerminoBusqueda.Text, 1, 1)
                Case "P"
                    .NGUICL = txtBusqueda.Text.ToUpper
                Case "I"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.INGRESO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 1
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtBusqueda.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 2
                    End If
            End Select
            ' Ahora registramos los Bultos
            Dim dtTemp As DataTable = oServicioBL.fdtListaSolicitudDeServicioSDS(oServicioAlmacen)
            If Me.dtgMercaderia.DataSource Is Nothing And Not dtTemp Is Nothing Then
                dtTemp.Columns.Add("CPRCN1")
                dtTemp.Columns.Add("NSRCN1")
                dtTemp.Columns.Add("NCRRDC", GetType(String))
                Me.dtgMercaderia.DataSource = dtTemp
            ElseIf (Not dtTemp Is Nothing) Then
                For Each oDr As DataRow In dtTemp.Rows
                    If Not fblnBuscarSolicitudServicio(oDr) Then
                        Dim oDrMercaderia As DataRow
                        oDrMercaderia = Me.dtgMercaderia.DataSource.NewRow
                        For intColumna As Integer = 0 To dtTemp.Columns.Count - 1
                            oDrMercaderia.Item(intColumna) = oDr.Item(intColumna)
                        Next
                        Me.dtgMercaderia.DataSource.Rows.Add(oDrMercaderia)
                    End If
                Next
            End If
        End With

    End Sub


    ''' <summary>
    ''' Busca si la solicitud de servicio ya esta asignada a la operación
    ''' </summary>
    ''' <param name="oDr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarSolicitudServicio(ByVal oDr As DataRow) As Boolean
        For Each oDrMercaderia As DataRow In Me.dtgMercaderia.DataSource.Rows
            If oDrMercaderia.Item("NORDSR") = oDr.Item("NORDSR") And oDrMercaderia.Item("NSLCSR") = oDr.Item("NSLCSR") Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BtnEliminarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTermino.Click
        Dim oServicioBL As New clsServicio_BL
        If Me.dtgMercaderia.RowCount <= 0 Then
            MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Information, "Validación")
            Exit Sub
        End If
        If Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC").ToString.Trim.Equals("") Then
            CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
            Exit Sub
        End If
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgMercaderia_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dtgMercaderia.UserAddedRow
        e.Row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
        e.Row.Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        e.Row.Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub
End Class
