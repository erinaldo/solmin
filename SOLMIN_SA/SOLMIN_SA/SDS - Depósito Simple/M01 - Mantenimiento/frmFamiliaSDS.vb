Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS

Public Class frmFamiliaSDS
#Region " Tipo de Datos "
    Enum eTipoValidacion
        NUEVO_REGISTRO
    End Enum
#End Region
#Region " Atributos "
    Private intCCLNT As Int64 = 0
    Private strTCMPCL As String = ""
    Private dtFamilias As DataTable
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
#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnBuscar(ByVal strCodigo As String, ByVal intRowIndex As Integer) As Boolean
        Dim intIndice As Integer

        For intIndice = 0 To dgFamilias.RowCount - 1
            If intIndice <> intRowIndex And strCodigo = dgFamilias.Rows(intIndice).Cells("F_CFMCLR").Value.ToString Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub pCargarFamilias()
        blnStatusCarga = True
        dtFamilias = mfdtListar_SDSFamilias(txtCliente.pCodigo)
        dgFamilias.DataSource = dtFamilias
        blnStatusCarga = False
        If dtFamilias.Rows.Count > 0 Then
            ' Nos posicionamos en la ultima posición
            Me.BindingContext(dtFamilias).Position = Me.BindingContext(dtFamilias).Count
        End If
    End Sub

    Private Sub pEliminarRegistro()
        If dgFamilias Is Nothing Then Exit Sub
        If dgFamilias.RowCount <= 0 Then Exit Sub

        dgFamilias.CurrentRow.Tag = "E"
        dgFamilias.CurrentRow.DefaultCellStyle.BackColor = Color.IndianRed
    End Sub

    Private Sub pFamilia_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F6
                If fblnValidaInformacion(eTipoValidacion.NUEVO_REGISTRO) Then
                    dgFamilias.Focus()
                    Call pNuevoRegistro()
                End If
            Case Keys.Delete
                Call pEliminarRegistro()
        End Select
    End Sub

    Private Sub pNuevoRegistro()
        dtFamilias.Rows.Add()
        dgFamilias.CurrentRow.Cells(0).Selected = True
        Me.BindingContext(dtFamilias).Position = Me.BindingContext(dtFamilias).Count
    End Sub

    Private Sub pProcesarInformacion()
        Dim intIndice As Integer
        Dim intTope As Integer = dgFamilias.RowCount - 1
        Dim objFamilia As clsFamilia
        Dim lstFamilia_Guardar As New List(Of clsFamilia)
        Dim lstFamilia_Eliminar As New List(Of clsFamilia)

        For intIndice = 0 To intTope
            With dgFamilias
                objFamilia = New clsFamilia
                If .Rows(intIndice).Tag IsNot Nothing Then
                    If .Rows(intIndice).Tag.ToString <> "" Then
                        ' Validamos que el campo del codigo y detalle no tenga campos vacios
                        If "" & .Rows(intIndice).Cells("F_CFMCLR").Value.ToString <> "" And _
                           "" & .Rows(intIndice).Cells("F_TFMCLR").Value.ToString <> "" Then
                            ' Luego almacenamos en el objeto
                            objFamilia.pintCodigoCliente_CCLNT = txtCliente.pCodigo
                            objFamilia.pstrCodigoFamilia_CFMCLR = .Rows(intIndice).Cells("F_CFMCLR").Value.ToString.Trim
                            objFamilia.pstrDescripcionFamilia_TFMCLR = .Rows(intIndice).Cells("F_TFMCLR").Value.ToString.Trim
                            ' Dependiendo el tipo de operación, se guarda en la lista correspondiente
                            If .Rows(intIndice).Tag.ToString = "M" Then
                                lstFamilia_Guardar.Add(objFamilia)
                            Else
                                lstFamilia_Eliminar.Add(objFamilia)
                            End If
                        End If
                    End If
                End If
            End With
        Next
        ' Si se tiene mas de un elemento se llama al proceso de Guardar y Elimnar
        If lstFamilia_Guardar.Count > 0 Or lstFamilia_Eliminar.Count > 0 Then
            If lstFamilia_Guardar.Count > 0 Then mfblnGuardar_Familia(lstFamilia_Guardar)
            If lstFamilia_Eliminar.Count > 0 Then mfblnEliminar_Familia(lstFamilia_Eliminar)
            ' Mostramos nuevamente la información
            Call pCargarFamilias()
        End If
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        Select Case eValidacion
            Case eTipoValidacion.NUEVO_REGISTRO
                If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el Cliente. " & vbNewLine
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call pProcesarInformacion()
    End Sub

    Private Sub dgFamilias_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFamilias.CellEndEdit
        If dgFamilias Is Nothing Then Exit Sub
        If dgFamilias.RowCount <= 0 Then Exit Sub
        dgFamilias.Rows(e.RowIndex).Tag = "M"
        dgFamilias.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub dgFamilias_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgFamilias.CellValidating
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

    Private Sub dgFamilias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgFamilias.KeyDown
        Call pFamilia_KeyDown(e)
    End Sub

    Private Sub dgFamilias_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFamilias.RowEnter
        If blnStatusCarga Then Exit Sub
        If blnStatusValidar Then Exit Sub
        If dgFamilias IsNot Nothing Then
            With dgFamilias
                If "" & .Rows(e.RowIndex).Cells("F_SESTRG").Value = "" Then
                    .Columns("F_CFMCLR").ReadOnly = False
                Else
                    .Columns("F_CFMCLR").ReadOnly = True
                End If
            End With
        End If
    End Sub

    Private Sub frmFamilia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dtFamilias = Nothing
    End Sub

    Private Sub frmFamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Si no se información un Cliente se debe cerrar el mantenimiento
        If intCCLNT = 0 Then
            txtCliente.Enabled = True
            txtCliente.pUsuario = objSeguridadBN.pUsuario
        Else
            txtCliente.Enabled = False

            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intCCLNT, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)

            Call pCargarFamilias()
        End If
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgFamilias.DataSource = Nothing
    End Sub

    Private Sub txtCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Validated
        If txtCliente.pCodigo <> 0 And dgFamilias.RowCount <= 0 Then
            Call pCargarFamilias()
        End If
    End Sub
#End Region
End Class