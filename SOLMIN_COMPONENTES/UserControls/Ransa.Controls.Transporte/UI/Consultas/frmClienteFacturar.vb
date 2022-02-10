

Public Class frmClienteFacturar

#Region "Atributos"
  Private mCPLNDV As Int32 = 0
  Private mCCLNFC As Int32 = 0
  Private mTPLNTA As String = ""
    Private mTCMPCF As String = ""
    Private mCCMPN As String = ""

#End Region

#Region "Properties"
    Public Property P_CCMPN() As String
        Get
            Return mCCMPN
        End Get
        Set(ByVal value As String)
            mCCMPN = value
        End Set
    End Property
    Public Property P_CPLNDV() As Int32
        Get
            Return mCPLNDV
        End Get
        Set(ByVal value As Int32)
            mCPLNDV = value
        End Set
    End Property

  Public Property P_CCLNFC() As String
    Get
      Return mCCLNFC
    End Get
    Set(ByVal value As String)
      mCCLNFC = value
    End Set
  End Property

  Public Property P_TPLNTA() As String
    Get
      Return mTPLNTA
    End Get
    Set(ByVal value As String)
      mTPLNTA = value
    End Set
  End Property

  Public Property P_TCMPCF() As String
    Get
      Return mTCMPCF
    End Get
    Set(ByVal value As String)
      mTCMPCF = value
    End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

#End Region

#Region "Eventos"

  Private Sub frmClienteFacturar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCliente.pUsuario = _pUsuario 'USUARIO
        Me.txtCliente.CCMPN = P_CCMPN
    Me.txtCliente.pCargar(P_CCLNFC)
    Me.Listar_Planta_Cliente_Facturar(P_CCLNFC)
    Me.cboPlanta.SelectedValue = CType(P_CPLNDV, Double)
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.txtCliente.pCodigo = 0 OrElse Me.cboPlanta.SelectedValue Is Nothing Then Exit Sub
    P_CPLNDV = Me.cboPlanta.SelectedValue
    P_CCLNFC = Me.txtCliente.pCodigo
    P_TPLNTA = Me.cboPlanta.Text
    P_TCMPCF = Me.txtCliente.pRazonSocial
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
    Me.Listar_Planta_Cliente_Facturar(Me.txtCliente.pCodigo)
    Me.cboPlanta.SelectedValue = -1.0
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Listar_Planta_Cliente_Facturar(ByVal lint_CCLNT As Integer)
        Dim obj_Logica As New Operaciones.Factura_Transporte_BLL
    Dim objetoParametro As New Hashtable

        objetoParametro.Add("PNCCLNT", Me.txtCliente.pCodigo)
        objetoParametro.Add("PSCCMPN", P_CCMPN)

    Me.cboPlanta.DataSource = obj_Logica.Listar_Planta_x_Cliente_Factura(objetoParametro)
    Me.cboPlanta.ValueMember = "CPLNCL"
    Me.cboPlanta.DisplayMember = "TDRCPL"
  End Sub

#End Region

End Class
