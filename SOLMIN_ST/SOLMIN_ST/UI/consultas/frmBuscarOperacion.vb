Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmBuscarOperacion

#Region "Atributo"
  Private mNOPRCN As Double = 0
  Private mNPLNMT As Double = 0
  Private mTCNTCS As String = ""
  Private mTCMPCL As String = ""
  Private mTRFMRC As String = ""
  Private mTCMPCL_1 As String = ""
  Private mCCMPN As String = ""
  Private mCDVSN As String = ""
    Private mCPLNDV As Int32 = 0
    Private mCCLNT As Double = 0
    Private mFLAG As Double = 0
    Private mRUTA As String = ""
    Private mNRUCTR As String = ""
    Private mCBRCNT As String = ""
    Private mCTRSPT As Decimal = 0
    Private mNPLCTR As String = ""
    Private _NPLCUN As String = ""
#End Region

#Region "Propiedades"
  Public Property CCMPN() As String
    Get
      Return mCCMPN
    End Get
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int32
    Set(ByVal value As Int32)
      mCPLNDV = value
    End Set
  End Property

  Public Property NOPRCN_1() As Double
    Get
      Return mNOPRCN
    End Get
    Set(ByVal value As Double)
      mNOPRCN = value
    End Set
  End Property

  Public ReadOnly Property NPLNMT_1() As Double
    Get
      Return mNPLNMT
    End Get
  End Property

  Public ReadOnly Property TCNTCS_1() As String
    Get
      Return mTCNTCS
    End Get
  End Property

  Public ReadOnly Property TCMPCL_1() As String
    Get
      Return mTCMPCL
    End Get
  End Property

  Public ReadOnly Property TRFMRC_1() As String
    Get
      Return mTRFMRC
    End Get
  End Property

  Public ReadOnly Property TCMPCL_2() As String
    Get
      Return mTCMPCL_1
    End Get
    End Property

    Public Property CCLNT_1() As Double
        Get
            Return mCCLNT
        End Get
        Set(ByVal value As Double)
            mCCLNT = value
        End Set
    End Property

    Public Property FLAG() As Double
        Get
            Return mFLAG
        End Get
        Set(ByVal value As Double)
            mFLAG = value
        End Set
    End Property

    Public ReadOnly Property RUTA_1() As String
        Get
            Return mRUTA
        End Get
    End Property


    Public ReadOnly Property NRUCTR_1() As String
        Get
            Return mNRUCTR
        End Get
    End Property
    Public ReadOnly Property CBRCNT_1() As String
        Get
            Return mCBRCNT
        End Get
    End Property
    Public ReadOnly Property CTRSPT_1() As Decimal
        Get
            Return mCTRSPT
        End Get
    End Property

    Public ReadOnly Property NPLCTR_1() As String
        Get
            Return mNPLCTR
        End Get
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

#End Region

    Public pSoloLecturaPlaca As Boolean = False

#Region "Eventos"

  Private Sub frmBuscarOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Alinear_Columna_Grilla()
        If mFLAG = 1 Then
            Lista_Operaciones_Liq_Combustible_X_Cliente()
        Else
            Me.Lista_Operaciones_x_Cliente()
        End If
        'Me.Lista_Operaciones_x_Cliente()
    txtCliente.CCMPN = mCCMPN
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
    Me.Asignar_Datos()
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        If mFLAG = 1 Then
            Lista_Operaciones_Liq_Combustible_X_Cliente()
        Else
            Me.Lista_Operaciones_x_Cliente()
        End If
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
    If Me.gwdDatos.RowCount = 0 OrElse e.RowIndex < 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
    Me.Asignar_Datos()
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Alinear_Columna_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

    Private Sub Lista_Operaciones_Liq_Combustible_X_Cliente()
        Dim objParametro As New Hashtable
        Dim objLogica As New OperacionTransporte_BLL
        If Me.txtCliente.pCodigo = 0 Then
            objParametro.Add("CCLNT", 0)
        Else
            objParametro.Add("CCLNT", CType(Me.txtCliente.pCodigo, Integer))
        End If
        objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
        objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))
        objParametro.Add("NPLCTR", Me.txtTracto.Text.Trim)
        objParametro.Add("CCMPN", mCCMPN)
        objParametro.Add("CDVSN", mCDVSN)
        objParametro.Add("CPLNDV", mCPLNDV)

        Me.gwdDatos.DataSource = objLogica.Lista_Operaciones_Liq_Combustible_X_Cliente(objParametro)
    End Sub

    Private Sub Lista_Operaciones_x_Cliente()
        Dim objParametro As New Hashtable
        Dim objLogica As New OperacionTransporte_BLL
        If Me.txtCliente.pCodigo = 0 Then
            objParametro.Add("CCLNT", 0)
        Else
            objParametro.Add("CCLNT", CType(Me.txtCliente.pCodigo, Integer))
        End If
        objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
        objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))
        objParametro.Add("NPLCTR", Me.txtTracto.Text.Trim)
        objParametro.Add("CCMPN", mCCMPN)
        objParametro.Add("CDVSN", mCDVSN)
        objParametro.Add("CPLNDV", mCPLNDV)

     

        Me.gwdDatos.DataSource = objLogica.Listar_Operaciones_x_Cliente(objParametro)
    End Sub

  Private Sub Asignar_Datos()
    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    mNOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value
    mNPLNMT = Me.gwdDatos.Item("NPLNMT", lint_Indice).Value
    mTCNTCS = Me.gwdDatos.Item("CCNCST", lint_Indice).Value.ToString + " -> " + Me.gwdDatos.Item("TCNTCS", lint_Indice).Value.ToString
    mTCMPCL = Me.gwdDatos.Item("CCLNT", lint_Indice).Value.ToString + " -> " + Me.gwdDatos.Item("TCMPCL", lint_Indice).Value.ToString
    mTRFMRC = Me.gwdDatos.Item("TRFMRC", lint_Indice).Value.ToString
        mTCMPCL_1 = Me.gwdDatos.Item("TCMPCL", lint_Indice).Value.ToString
        mCCLNT = Me.gwdDatos.Item("CCLNT", lint_Indice).Value.ToString
        mRUTA = Me.gwdDatos.Item("RUTA", lint_Indice).Value.ToString

        If mFLAG = 0 Then
            mNRUCTR = Me.gwdDatos.Item("NRUCTR", lint_Indice).Value.ToString
            mCBRCNT = Me.gwdDatos.Item("CBRCNT", lint_Indice).Value.ToString
            mCTRSPT = Me.gwdDatos.Item("CTRSPT", lint_Indice).Value.ToString
            mNPLCTR = Me.gwdDatos.Item("NPLCTR", lint_Indice).Value.ToString
        End If

    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

#End Region

End Class