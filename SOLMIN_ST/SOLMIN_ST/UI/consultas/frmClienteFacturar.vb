Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmClienteFacturar

#Region "Atributos"
    Public P_CCLNT As Decimal = 0
    'Public P_CPLNDV As Decimal = 0
    Public P_CCLNFC As Decimal = 0
    'Public P_TPLNTA As String = ""
    Public P_TCMPCF As String = ""
    Public P_CCMPN As String = ""
    'ECM-HUNDRED-INICIO
    Public CDSCSP As String = ""
    Public pCDSCSP_CodigoSector As String = ""
    'ECM-HUNDRED-FIN
#End Region

#Region "Properties"
    'Public Property P_CCMPN() As String
    '    Get
    '        Return mCCMPN
    '    End Get
    '    Set(ByVal value As String)
    '        mCCMPN = value
    '    End Set
    'End Property
    'Public Property P_CPLNDV() As Int32
    '    Get
    '        Return mCPLNDV
    '    End Get
    '    Set(ByVal value As Int32)
    '        mCPLNDV = value
    '    End Set
    'End Property

    'Public Property P_CCLNFC() As String
    '    Get
    '        Return mCCLNFC
    '    End Get
    '    Set(ByVal value As String)
    '        mCCLNFC = value
    '    End Set
    'End Property

    'Public Property P_TPLNTA() As String
    '  Get
    '    Return mTPLNTA
    '  End Get
    '  Set(ByVal value As String)
    '    mTPLNTA = value
    '  End Set
    'End Property

    'Public Property P_TCMPCF() As String
    '  Get
    '    Return mTCMPCF
    '  End Get
    '  Set(ByVal value As String)
    '    mTCMPCF = value
    '  End Set
    'End Property

    REM ECM-HUNDRED-INICIO
    'Public Property CDSCSP() As String
    '    Get
    '        Return _CDSCSP
    '    End Get
    '    Set(ByVal value As String)
    '        _CDSCSP = value
    '    End Set
    'End Property

    'Public Property pCDSCSP_CodigoSector() As String
    '    Get
    '        Return _pCDSCSP_CodigoSector
    '    End Get
    '    Set(ByVal value As String)
    '        _pCDSCSP_CodigoSector = value
    '    End Set
    'End Property
    REM ECM-HUNDRED-FIN
#End Region

#Region "Eventos"

  Private Sub frmClienteFacturar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim obj_Logica As New Factura_Transporte_BLL
            Dim objetoParametro As New Hashtable
            Dim dtLista As New DataTable
            dtLista = obj_Logica.Listar_Cliente_IgualCodSAP(P_CCMPN, P_CCLNT)
            Me.cmbCliente.DataSource = dtLista
            Me.cmbCliente.ValueMember = "CCLNT"
            Me.cmbCliente.DisplayMember = "TCMPCL"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Me.Listar_Planta_Cliente_Facturar(P_CCLNFC)
        'Me.cboPlanta.SelectedValue = CType(P_CPLNDV, Double)

    End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'If Me.txtCliente.pCodigo = 0 OrElse Me.cboPlanta.SelectedValue Is Nothing Then Exit Sub
        If cmbCliente.ComboBox.SelectedValue = 0 Is Nothing Then Exit Sub

        'REM ECM-HUNDRED-INICIO
        'If CDSCSP <> pCDSCSP_CodigoSector Then
        '    HelpClass.MsgBox("El cliente facturación debe pertenecer al mismo sector del CeBe de la operación.", MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        REM ECM-HUNDRED-FIN

        If cmbCliente.ComboBox.SelectedValue = P_CCLNT Then
            MessageBox.Show("Debe seleccionar cliente diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'P_CPLNDV = Me.cboPlanta.SelectedValue
        'P_CCLNFC = Me.txtCliente.pCodigo
        P_CCLNFC = cmbCliente.ComboBox.SelectedValue
        'P_TPLNTA = Me.cboPlanta.Text
        'P_TCMPCF = Me.txtCliente.pRazonSocial
        P_TCMPCF = cmbCliente.ComboBox.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

    'Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
    '  Me.Listar_Planta_Cliente_Facturar(Me.txtCliente.pCodigo)
    '  Me.cboPlanta.SelectedValue = -1.0
    'End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Listar_Planta_Cliente_Facturar(ByVal lint_CCLNT As Integer)
    Dim obj_Logica As New Factura_Transporte_BLL
    Dim objetoParametro As New Hashtable

        'objetoParametro.Add("PNCCLNT", Me.txtCliente.pCodigo)
        objetoParametro.Add("PNCCLNT", cmbCliente.ComboBox.SelectedValue)
        objetoParametro.Add("PSCCMPN", P_CCMPN)
        'pCDSCSP_CodigoSector = txtCliente.pSector 'ECM-HUNDRED
        'pCDSCSP_CodigoSector = txtCliente.pSector

    Me.cboPlanta.DataSource = obj_Logica.Listar_Planta_x_Cliente_Factura(objetoParametro)
    Me.cboPlanta.ValueMember = "CPLNCL"
        Me.cboPlanta.DisplayMember = "TDRCPL"
 
  End Sub

#End Region

    Private Sub cmbCliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCliente.SelectionChangeCommitted
        Try
            cboPlanta.DataSource = Nothing
            Listar_Planta_Cliente_Facturar(cmbCliente.ComboBox.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
