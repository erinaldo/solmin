Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS

Public Class frmGrupoSDS
#Region " Tipo de Datos "
    Enum eTipoValidacion
        NUEVO_REGISTRO
    End Enum
#End Region
#Region " Atributos "
    Private intCCLNT As Int64 = 0
    Private strTCMPCL As String = ""
    Private strCFMCLR As String = ""
    Private strTFMCLR As String = ""
    Private dtGrupos As DataTable
    Private blnStatusCarga As Boolean = False
    Private blnStatusValidar As Boolean = False
#End Region
#Region " Propiedades "
    ' Se proporciona el Codigo del Cliente 
    Public WriteOnly Property pintCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property
    ' Se proporciona la Razón Social del Cliente
    Public WriteOnly Property pstrRazonSocial_TCMPCL() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property
    ' Se proporciona el Codigo la Familia
    Public WriteOnly Property pstrCodigoFamilia_CFMCLR() As String
        Set(ByVal value As String)
            strCFMCLR = value
        End Set
    End Property
    ' Se proporciona el detalle de la Familia
    Public WriteOnly Property pstrDescripcionFamilia_TFMCLR() As String
        Set(ByVal value As String)
            strTFMCLR = value
        End Set
    End Property
#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnBuscar(ByVal strCodigo As String, ByVal intRowIndex As Integer) As Boolean
        Dim intIndice As Integer

        For intIndice = 0 To dgGrupos.RowCount - 1
            If intIndice <> intRowIndex And strCodigo = dgGrupos.Rows(intIndice).Cells("G_CGRCLR").Value.ToString Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub pCargarGrupos()
        blnStatusCarga = True
        dtGrupos = mfdtListar_SDSGrupos(txtCliente.pCodigo, txtFamilia.Tag)
        dgGrupos.DataSource = dtGrupos
        blnStatusCarga = False
        ' Nos posicionamos en la ultima posición
        Me.BindingContext(dtGrupos).Position = Me.BindingContext(dtGrupos).Count
    End Sub

    Private Sub pEliminarRegistro()
        If dgGrupos Is Nothing Then Exit Sub
        If dgGrupos.RowCount <= 0 Then Exit Sub

        dgGrupos.CurrentRow.Tag = "E"
        dgGrupos.CurrentRow.DefaultCellStyle.BackColor = Color.IndianRed
    End Sub

    Private Sub pGrupo_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F6
                If fblnValidaInformacion(eTipoValidacion.NUEVO_REGISTRO) Then
                    dgGrupos.Focus()
                    Call pNuevoRegistro()
                End If
            Case Keys.Delete
                Call pEliminarRegistro()
        End Select
    End Sub

    Private Sub pNuevoRegistro()
        dtGrupos.Rows.Add()
        dgGrupos.CurrentRow.Cells(0).Selected = True
        Me.BindingContext(dtGrupos).Position = Me.BindingContext(dtGrupos).Count
    End Sub

    Private Sub pProcesarInformacion()
        Dim intIndice As Integer
        Dim intTope As Integer = dgGrupos.RowCount - 1
        Dim objGrupo As clsGrupo
        Dim lstGrupo_Guardar As New List(Of clsGrupo)
        Dim lstGrupo_Eliminar As New List(Of clsGrupo)

        For intIndice = 0 To intTope
            With dgGrupos
                objGrupo = New clsGrupo
                If .Rows(intIndice).Tag IsNot Nothing Then
                    If .Rows(intIndice).Tag.ToString <> "" Then
                        ' Validamos que el campo del codigo y detalle no tenga campos vacios
                        If "" & .Rows(intIndice).Cells("G_CGRCLR").Value.ToString <> "" And _
                           "" & .Rows(intIndice).Cells("G_TGRCLR").Value.ToString <> "" Then
                            ' Luego almacenamos en el objeto
                            objGrupo.pintCodigoCliente_CCLNT = txtCliente.pCodigo
                            objGrupo.pstrCodigoFamilia_CFMCLR = txtFamilia.Tag
                            objGrupo.pstrCodigoGrupo_CGRCLR = .Rows(intIndice).Cells("G_CGRCLR").Value.ToString.Trim
                            objGrupo.pstrDescripcionGrupo_TGRCLR = .Rows(intIndice).Cells("G_TGRCLR").Value.ToString.Trim
                            ' Dependiendo el tipo de operación, se guarda en la lista correspondiente
                            If .Rows(intIndice).Tag.ToString = "M" Then
                                lstGrupo_Guardar.Add(objGrupo)
                            Else
                                lstGrupo_Eliminar.Add(objGrupo)
                            End If
                        End If
                    End If
                End If
            End With
        Next
        ' Si se tiene mas de un elemento se llama al proceso de Guardar y Elimnar
        If lstGrupo_Guardar.Count > 0 Or lstGrupo_Eliminar.Count > 0 Then
            If lstGrupo_Guardar.Count > 0 Then mfdtGuardar_Grupo(lstGrupo_Guardar)
            If lstGrupo_Eliminar.Count > 0 Then mfdtEliminar_Grupo(lstGrupo_Eliminar)
            ' Actualizamos la lista de grupos
            Call pCargarGrupos()
        End If
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        Select Case eValidacion
            Case eTipoValidacion.NUEVO_REGISTRO
                If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el Cliente. " & vbNewLine
                If txtFamilia.Text = "" Then strMensajeError &= "No han seleccionado la Familia. " & vbNewLine
        End Select

        ' Mostramos el mensaje de validación si no se cumplió las condiciones establecidas
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call pProcesarInformacion()
    End Sub

    Private Sub dgGrupos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrupos.CellEndEdit
        If dgGrupos Is Nothing Then Exit Sub
        If dgGrupos.RowCount <= 0 Then Exit Sub
        dgGrupos.Rows(e.RowIndex).Tag = "M"
        dgGrupos.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub dgGrupos_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgGrupos.CellValidating
        If blnStatusCarga Then Exit Sub
        blnStatusValidar = True
        If e.ColumnIndex = 0 Then
            If e.FormattedValue.ToString <> "" Then
                If fblnBuscar(e.FormattedValue.ToString, e.RowIndex) Then
                    MessageBox.Show("Valor ya fue registrado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        End If
        blnStatusValidar = False
    End Sub

    Private Sub dgGrupos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGrupos.KeyDown
        Call pGrupo_KeyDown(e)
    End Sub

    Private Sub dgGrupos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrupos.RowEnter
        If blnStatusCarga Then Exit Sub
        If blnStatusValidar Then Exit Sub
        If dgGrupos IsNot Nothing Then
            With dgGrupos
                If "" & .Rows(e.RowIndex).Cells("G_SESTRG").Value = "" Then
                    .Columns("G_CGRCLR").ReadOnly = False
                Else
                    .Columns("G_CGRCLR").ReadOnly = True
                End If
            End With
        End If
    End Sub

    Private Sub frmGrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dtGrupos = Nothing
    End Sub

    Private Sub frmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Si no se información un Cliente se debe cerrar el mantenimiento
        If intCCLNT = 0 Then
            txtCliente.Enabled = True
            txtCliente.pUsuario = objSeguridadBN.pUsuario
        Else
            txtCliente.Enabled = False

            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intCCLNT, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)

            txtFamilia.Tag = strCFMCLR
            txtFamilia.Text = strTFMCLR
            Call pCargarGrupos()
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtCliente.pClear()
        txtFamilia.Text = ""
        txtFamilia.Tag = ""
        ' Limpiamos el Dataset y el DataTable
        blnStatusCarga = True
        dtGrupos = Nothing
        dgGrupos.DataSource = Nothing
        blnStatusCarga = False
    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
        Else
            Call pGrupo_KeyDown(e)
        End If
    End Sub

    Private Sub txtFamilia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Tag = ""
        ' Limpiamos el Dataset y el DataTable
        blnStatusCarga = True
        dtGrupos = Nothing
        dgGrupos.DataSource = Nothing
        blnStatusCarga = False
    End Sub

    Private Sub txtFamilia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFamilia.Validated
        If txtCliente.pCodigo <> 0 And txtFamilia.Text <> "" And dgGrupos.RowCount <= 0 Then
            Call pCargarGrupos()
        End If
    End Sub

    Private Sub txtFamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        If txtFamilia.Text = "" Then
            txtFamilia.Tag = ""
            Exit Sub
        Else
            If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#End Region
End Class