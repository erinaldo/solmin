Imports Ransa.Utilitario
Imports System.Windows.Forms

Public Class frmMIncidencias

    Private _PSUSER As String = ""
    Public Property PSUSER() As String
        Get
            Return _PSUSER
        End Get
        Set(ByVal value As String)
            _PSUSER = value
        End Set
    End Property


    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCARINC As String = ""
    Public Property PSCARINC() As String
        Get
            Return _PSCARINC
        End Get
        Set(ByVal value As String)
            _PSCARINC = value
        End Set
    End Property


    Private _PNCINCID As String = ""
    Public Property PNCINCID() As String
        Get
            Return _PNCINCID
        End Get
        Set(ByVal value As String)
            _PNCINCID = value
        End Set
    End Property


    Private _PNCTPINC As Decimal
    Public Property PNCTPINC() As Decimal
        Get
            Return _PNCTPINC
        End Get
        Set(ByVal value As Decimal)
            _PNCTPINC = value
        End Set
    End Property


    Private _PSTINCSI As String
    Public Property PSTINCSI() As String
        Get
            Return _PSTINCSI
        End Get
        Set(ByVal value As String)
            _PSTINCSI = value
        End Set
    End Property

    Private _PSTDARINC As String
    Public Property PSTDARINC() As String
        Get
            Return _PSTDARINC
        End Get
        Set(ByVal value As String)
            _PSTDARINC = value
        End Set
    End Property
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
    Private _PSSTIPPR As String
    Public Property PSSTIPPR() As String
        Get
            Return _PSSTIPPR
        End Get
        Set(ByVal value As String)
            _PSSTIPPR = value
        End Set
    End Property
    'END: JDT-Almacén Repuestos On Side - Piura[RF003]-190516

    Dim Codigo_anterior As Decimal

    Private Sub frmMIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Codigo_anterior = _PNCTPINC

            Me.txtCodigo.Text = _PNCINCID


            Cargar_Area()
            If _PSCARINC.Trim <> "" Then
                Me.txtDesIncidencia.Text = _PSTINCSI
                cmbArea.SelectedValue = _PSCARINC
            End If

            Lista_Inc_Para()
            Lista_Proceso() 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516

            'If _PNCTPINC = 0D Then
            'cmbIncPara.SelectedValue = 0
            'Else
            Codigo_anterior = _PNCTPINC
            cmbIncPara.SelectedValue = _PNCTPINC

            'End If
            cbxProceso.SelectedValue = _PSSTIPPR 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516

            If _PNCINCID.Trim <> "" Then
                cmbArea.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Area()

        Dim objBLL As New brIncidencias

        cmbArea.DataSource = objBLL.Lista_Areas
        cmbArea.DisplayMember = "TDARINC"
        cmbArea.ValueMember = "CARINC"
        cmbArea.SelectedValue = "S"

    End Sub

    Sub Lista_Inc_Para()

        Dim objBLL As New brIncidencias
        Dim dtIncPara As New DataTable
        Dim dr As DataRow

        dtIncPara = objBLL.Lista_Inc_Para
        If _PNCINCID.Length = 0 Then

            dr = dtIncPara.NewRow
            dr("CTPINC") = 0
            dr("TTPINC") = ":: Seleccione ::"
            dtIncPara.Rows.InsertAt(dr, 0)
        End If

        cmbIncPara.DataSource = dtIncPara
        cmbIncPara.DisplayMember = "TTPINC"
        cmbIncPara.ValueMember = "CTPINC"
        cmbIncPara.SelectedValue = 0

    End Sub
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
    Sub Lista_Proceso()
        Dim objBLL As New brIncidencias
        Dim dtProceso As New DataTable
        Dim dr As DataRow

        dtProceso = objBLL.Lista_Proceso
        If _PNCINCID.Length = 0 Then

            dr = dtProceso.NewRow
            dr("STIPPR") = "V"
            dr("DESPRO") = ":: Seleccione ::"
            dtProceso.Rows.InsertAt(dr, 0)
        End If

        cbxProceso.DataSource = dtProceso
        cbxProceso.DisplayMember = "DESPRO"
        cbxProceso.ValueMember = "STIPPR"
        cbxProceso.SelectedValue = "v"
    End Sub
    'END: JDT-Almacén Repuestos On Side - Piura[RF003]-190516

    Private Function Validar() As Boolean
        Dim strError As String = ""

        If cmbIncPara.SelectedValue = 0 Then
            strError = "*Seleccionar Inc. Para."
        End If
        'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
        If cbxProceso.SelectedValue.ToString.Trim = "V" Then
            strError = "*Seleccionar un Proceso."
        End If
        'END: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
        If Me.txtDesIncidencia.Text.Trim.Length = 0 Then
            strError = strError & Environment.NewLine & "*Ingresar la descripción."
        End If

        If strError.Length > 0 Then
            MessageBox.Show(strError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        Try
            If Validar() Then Exit Sub
            Dim obr As New brIncidencias
            Dim obe As New beIncidencias

            With obe
                .PSCCMPN = _PSCCMPN
                .PSCARINC = Me.cmbArea.SelectedValue '_PSCDVSN

                If _PNCINCID.Length <> 0 Then
                    .PNCINCID = _PNCINCID
                End If
                .PSTINCSI = Me.txtDesIncidencia.Text.Trim
                .PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .PSUSUARIO = _PSUSER
                .PNCTPINC = cmbIncPara.SelectedValue
                .PSSESTRG = "A"
                .PSSTIPPR = cbxProceso.SelectedValue.ToString.Trim 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516
            End With

            If _PNCINCID.Length = 0 Then
                Dim codigo As Int32 = 0
                codigo = obr.intInsertarMaestroIncidencias(obe)
                MessageBox.Show("Registro ingresado, código tipo incidencia generado : " & codigo, "Información: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else

                obr.intActualizarMaestroIncidencias(obe)
                Me.DialogResult = Windows.Forms.DialogResult.OK

                'If obr.intActualizarMaestroIncidencias_Confirmacion(obe, Codigo_anterior) > 0 Then
                '    MessageBox.Show(" No se puede modificar Inc. Para . Existen registros asociados a la incidencia", "Información: ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Else
                '    obr.intActualizarMaestroIncidencias(obe)
                '    Me.DialogResult = Windows.Forms.DialogResult.OK
                'End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
