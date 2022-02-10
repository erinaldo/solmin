Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos

Public Class frmTractoPropio_Mant

    Private _STPVHP As String
    Public Property STPVHP() As String
        Get
            Return _STPVHP
        End Get
        Set(ByVal value As String)
            _STPVHP = value
        End Set
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNDV As Decimal
    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property

    Private _NRUCTR As String
    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Private _NPLCUN As String
    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

    Private _pRazonSocial As String
    Public Property pRazonSocial() As String
        Get
            Return _pRazonSocial
        End Get
        Set(ByVal value As String)
            _pRazonSocial = value
        End Set
    End Property



    Private Sub frmTractoPropio_Mant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cargar_Compania()
            Cargar_Tipo()

            'cmbCompania.SelectedValue = _CCMPN
            'cmbDivision.SelectedValue = _CDVSN
            'cmbPlanta.SelectedValue = _CPLNDV
            txtRUC.Text = _NRUCTR
            txtPlacaUnidad.Text = _NPLCUN
            txtRazonSocial.Text = _pRazonSocial

            If _STPVHP.ToString.Trim = "" Then
                cboTipo.SelectedValue = "0"
            Else
                cboTipo.SelectedValue = _STPVHP
            End If

            'cmbDivision.Enabled = False
            'cmbPlanta.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Cargar_Tipo()

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("STPVHP", Type.GetType("System.String"))
        dt.Columns.Add("STPVHP_S", Type.GetType("System.String"))

        dr = dt.NewRow
        dr("STPVHP") = "0"
        dr("STPVHP_S") = "::Seleccione::"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("STPVHP") = "P"
        dr("STPVHP_S") = "Propio"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("STPVHP") = "A"
        dr("STPVHP_S") = "Alquilado"
        dt.Rows.Add(dr)

        cboTipo.DataSource = dt.Copy
        cboTipo.DisplayMember = "STPVHP_S"
        cboTipo.ValueMember = "STPVHP"

    End Sub

    'Private Sub Cargar_Compania()

    '    Dim objCompaniaBLL As New NEGOCIO.Compania_BLL

    '    objCompaniaBLL.Crea_Lista()
    '    cmbCompania.DataSource = objCompaniaBLL.Lista
    '    cmbCompania.ValueMember = "CCMPN"
    '    cmbCompania.DisplayMember = "TCMPCM"

    '    Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    '    cmbCompania_SelectionChangeCommitted(Nothing, Nothing)

    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Dim objTracto As New Tracto_BLL
            Dim Entidad As New Tracto

            Entidad.CCMPN = _CCMPN 'cmbCompania.SelectedValue
            Entidad.CDVSN = _CDVSN 'cmbDivision.SelectedValue
            Entidad.CPLNDV = _CPLNDV 'cmbPlanta.SelectedValue
            Entidad.NRUCTR = txtRUC.Text
            Entidad.NPLCUN = txtPlacaUnidad.Text

            If cboTipo.SelectedValue = "0" Then
                MessageBox.Show("Seleccione un tipo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Entidad.STPVHP = cboTipo.SelectedValue
            Entidad.CULUSA = MainModule.USUARIO
            Entidad.FULTAC = HelpClass.TodayNumeric
            Entidad.HULTAC = HelpClass.NowNumeric
            Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            If objTracto.Modificar_Asignacion_Tracto_Transportista(Entidad) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim objDivision As New NEGOCIO.Division_BLL

        '    objDivision.Crea_Lista()
        '    cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
        '    cmbDivision.ValueMember = "CDVSN"
        '    cmbDivision.DisplayMember = "TCMPDV"
        '    Me.cmbDivision.SelectedValue = "T"

        '    If Me.cmbDivision.SelectedIndex = -1 Then
        '        Me.cmbDivision.SelectedIndex = 0
        '    End If
        '    cmbDivision_SelectionChangeCommitted(Nothing, Nothing)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    Dim objPlanta As New NEGOCIO.Planta_BLL
        '    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)

        '    objPlanta.Crea_Lista()
        '    objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
        '    cmbPlanta.DataSource = objLisEntidad
        '    cmbPlanta.ValueMember = "CPLNDV"
        '    cmbPlanta.DisplayMember = "TPLNTA"

        '    Me.cmbPlanta.SelectedIndex = 0
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class
