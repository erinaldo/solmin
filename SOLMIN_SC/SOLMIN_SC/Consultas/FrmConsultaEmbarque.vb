Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class FrmConsultaEmbarque
    Enum ENUM_TIPO_EMBARQUE
        EX
        IM
    End Enum
    Private pCCMPN As String = ""
    Private pCCLNT As Decimal = 0
    Private pTPSRVA As String = ""

    Private _pNORSCI_REG As Decimal = 0
    Public ReadOnly Property pNORSCI_REG() As Decimal
        Get
            Return _pNORSCI_REG
        End Get
    End Property

    Private _pPNNMOS_REG As Decimal = 0
    Public ReadOnly Property pPNNMOS_REG() As Decimal
        Get
            Return _pPNNMOS_REG
        End Get
    End Property

    Private _pTIPO_EMBARQUE As String = ""
    Public Property pTIPO_EMBARQUE() As String
        Get
            Return _pTIPO_EMBARQUE
        End Get
        Set(ByVal value As String)
            _pTIPO_EMBARQUE = value
        End Set
    End Property

    Sub New(ByVal CCMPN As String, ByVal CCLNT As Decimal, ByVal NORSCI_REG As Decimal, ByVal TipoEmbarque As ENUM_TIPO_EMBARQUE)
        InitializeComponent()
        pCCMPN = CCMPN
        pCCLNT = CCLNT
        _pNORSCI_REG = NORSCI_REG
        pTPSRVA = TipoEmbarque.ToString
    End Sub

    Private Sub FrmConsultaEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgSegAduaneroReducido.AutoGenerateColumns = False
            CargarOpcionesBusqueda()
            Dim oclsEstado As New clsEstado
            Dim dtTipoOperacion As New DataTable
            cboTipoOperacion.DataSource = oclsEstado.Listar_TipoOperacionEmbarque
            cboTipoOperacion.DisplayMember = "TEX"
            cboTipoOperacion.ValueMember = "COD"
            cboTipoOperacion.SelectedValue = pTPSRVA
            cboTipoOperacion.Enabled = False
            If _pNORSCI_REG > 0 Then
                cboOpcion.SelectedValue = "EM"
                txtBusqueda.Text = _pNORSCI_REG
                btnBuscar.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If txtBusqueda.Text.Length = 0 Then
                MessageBox.Show("Ingrese valor a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.dtgSegAduaneroReducido.DataSource = Nothing
            Dim odtSegBasico As New DataTable
            Dim obrEmbarque As New clsEmbarque
            Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
            oFiltroEmbarque = ObtenerFiltroDatos()
            odtSegBasico = obrEmbarque.ListarSeguimientoAduaneroVistaReducido(oFiltroEmbarque)
            Dim NumFilas As Int32 = odtSegBasico.Rows.Count - 1
            dtgSegAduaneroReducido.DataSource = odtSegBasico
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarOpcionesBusqueda()
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("DISPLAY")
        dt.Columns.Add("VALUE")
        dr = dt.NewRow
        dr("DISPLAY") = "ORDEN DE SERVICIO"
        dr("VALUE") = "OS"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "EMBARQUE"
        dr("VALUE") = "EM"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "ORDEN DE COMPRA"
        dr("VALUE") = "OC"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("DISPLAY") = "B/L AWB"
        dr("VALUE") = "BL"
        dt.Rows.Add(dr)

        cboOpcion.DataSource = dt
        cboOpcion.ValueMember = "VALUE"
        cboOpcion.DisplayMember = "DISPLAY"
        cboOpcion.SelectedValue = "OS"
    End Sub


    Private Function ObtenerFiltroDatos() As beSeguimientoCargaFiltro
        Dim oFiltroEmbarque As New beSeguimientoCargaFiltro
        txtBusqueda.Text = txtBusqueda.Text.Trim
        Dim IsNumero As Boolean = False
        Dim NORSCI As Decimal = 0
        Dim PNNMOS As Decimal = 0
        oFiltroEmbarque.PSCCMPN = pCCMPN
        oFiltroEmbarque.PNCCLNT = pCCLNT
        oFiltroEmbarque.PNFECINI = 0
        oFiltroEmbarque.PNFECFIN = 99999999
        If cboOpcion.SelectedValue = "OC" Then
            oFiltroEmbarque.PSNORCML = txtBusqueda.Text.Trim
        End If
        oFiltroEmbarque.PSCPRVCL = 0
        If cboOpcion.SelectedValue = "OS" Then
            IsNumero = Decimal.TryParse(txtBusqueda.Text, PNNMOS)
            oFiltroEmbarque.PSPNNMOS = PNNMOS
        End If
        If cboOpcion.SelectedValue = "BL" Then
            oFiltroEmbarque.PSDOCEMB = txtBusqueda.Text
        End If
        If cboOpcion.SelectedValue = "EM" Then
            IsNumero = Decimal.TryParse(txtBusqueda.Text, NORSCI)
            oFiltroEmbarque.PSNORSCI = NORSCI
        End If
        oFiltroEmbarque.PSTPSRVA = cboTipoOperacion.SelectedValue
        oFiltroEmbarque.PSSESTRG = ""
        Return oFiltroEmbarque
    End Function

    Private Sub SeleccionarEmbarque()
        Dim Fila As Int32 = dtgSegAduaneroReducido.CurrentRow.Index
        If dtgSegAduaneroReducido.CurrentRow IsNot Nothing Then
            _pNORSCI_REG = dtgSegAduaneroReducido.Rows(Fila).Cells("NORSCI_R").Value
            _pPNNMOS_REG = Val("" & dtgSegAduaneroReducido.Rows(Fila).Cells("PNNMOS_R").Value)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dtgSegAduaneroReducido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSegAduaneroReducido.CellDoubleClick
        Try
            SeleccionarEmbarque()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'Dim Fila As Int32 = dtgSegAduaneroReducido.CurrentRow.Index
            'If dtgSegAduaneroReducido.CurrentRow IsNot Nothing Then
            '    _pNORSCI_REG = dtgSegAduaneroReducido.Rows(Fila).Cells("NORSCI_R").Value
            '    _pPNNMOS_REG = Val("" & dtgSegAduaneroReducido.Rows(Fila).Cells("PNNMOS_R").Value)
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'End If
            SeleccionarEmbarque()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboOpcion_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOpcion.SelectionChangeCommitted
        Dim opc As String = cboOpcion.SelectedValue
        Try
            RemoveHandler txtBusqueda.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            Select Case opc
                Case "OS", "EM"
                    txtBusqueda.Tag = "10-0"
                    AddHandler txtBusqueda.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "OC"
                    txtBusqueda.MaxLength = 35
                Case "BL"
                    txtBusqueda.MaxLength = 25
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
End Class
