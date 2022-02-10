Imports SOLMIN_CTZ.Entidades

Public Class frmMantServicio


    Private _obeServicios As New Servicio_X_Rubro

    Public Property obeServicios() As Servicio_X_Rubro
        Get
            Return _obeServicios
        End Get
        Set(ByVal value As Servicio_X_Rubro)
            _obeServicios = value
        End Set
    End Property

    Private Sub frmMantServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarRubroDeVenta()
        If _obeServicios.NRSRRB <> 0 Then
            Me.txtServicio.Text = _obeServicios.NOMSER.Trim
            Me.ucRubroDeVenta.Valor = _obeServicios.CSRVNV
        End If
    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Guardar()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub CargarRubroDeVenta()
        Try

            Dim oListColum As New Hashtable

            Dim oColumnas As New DataGridViewTextBoxColumn
            oColumnas.Name = "CSRVNV"
            oColumnas.DataPropertyName = "CSRVNV"
            oColumnas.HeaderText = "Código "
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TCMTRF"
            oColumnas.DataPropertyName = "TCMTRF"
            oColumnas.HeaderText = "Descripción "
            oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TSRVIN"
            oColumnas.DataPropertyName = "TSRVIN"
            oColumnas.HeaderText = "Cod. Material "
            oListColum.Add(3, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "IAFCDT"
            oColumnas.DataPropertyName = "IAFCDT"
            oColumnas.HeaderText = "Monto detracción "
            oListColum.Add(4, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "IPRCDT"
            oColumnas.DataPropertyName = "IPRCDT"
            oColumnas.HeaderText = "Porcentaje detracción "
            oListColum.Add(5, oColumnas)

            '<[AHM]>
            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "CDSRSP"
            oColumnas.DataPropertyName = "CDSRSP"
            oColumnas.HeaderText = "Cod. MacroServicio "
            oListColum.Add(6, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TDSRSP"
            oColumnas.DataPropertyName = "TDSRSP"
            oColumnas.HeaderText = "MacroServicio "
            oListColum.Add(7, oColumnas)
            '</[AHM]>

            Dim oServicioNeg As New SOLMIN_CTZ.NEGOCIO.clsServicio
            Dim oServicioGral As New Servicio_X_Rubro


            oServicioGral.CCMPN = _obeServicios.CCMPN
            oServicioGral.CDVSN = obeServicios.CDVSN

            Me.ucRubroDeVenta.DataSource = oServicioNeg.Lista_Servicio_General(oServicioGral)
            Me.ucRubroDeVenta.ListColumnas = oListColum
            Me.ucRubroDeVenta.Cargas()
            Me.ucRubroDeVenta.DispleyMember = "TCMTRF"
            Me.ucRubroDeVenta.ValueMember = "CSRVNV"


        
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar()
        If Not fbolValidar() Then Exit Sub
        Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
        With _obeServicios
            .NOMSER = Me.txtServicio.Text
            If Me.ucRubroDeVenta.Resultado Is Nothing Then
                .CSRVNV = 0
            Else
                .CSRVNV = CType(Me.ucRubroDeVenta.Resultado, Servicio_X_Rubro).CSRVNV
            End If
        End With
        If oServicioXDivisionNeg.fintGuardarServicioEspecificos(_obeServicios) = -1 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        HelpClass.MsgBox("Se guardó correctamente")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function fbolValidar() As Boolean
        Dim strError As String = ""

        If Me.txtServicio.Text.Trim.Equals("") Then
            strError = "* Digite descripción del servicio" & Chr(10)
        End If
        If Me.ucRubroDeVenta.Resultado Is Nothing Then
            strError = strError + "* Seleccione el rubro de venta"
        End If
       
        If strError.Trim.Length > 0 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function


    Private Sub ucRubroDeVenta_CambioDeTexto(ByVal objData As Object) Handles ucRubroDeVenta.CambioDeTexto
        If Not ucRubroDeVenta.Resultado Is Nothing Then
            With CType(ucRubroDeVenta.Resultado, Servicio_X_Rubro)
                Me.txtCodMaterial.Text = .TSRVIN
                Me.txtMontoDetraccion.Text = .IAFCDT
                Me.txtPorcentajeDetraccion.Text = .IPRCDT
                '<[AHM]>
                Me.txtMacroServicio.Text = .TDSRSP
                '</[AHM]>
            End With
        Else
            Me.txtCodMaterial.Text = ""
            Me.txtMontoDetraccion.Text = 0D
            Me.txtPorcentajeDetraccion.Text = 0D
            '<[AHM]>
            Me.txtMacroServicio.Text = ""
            '</[AHM]>
        End If
    End Sub
End Class
