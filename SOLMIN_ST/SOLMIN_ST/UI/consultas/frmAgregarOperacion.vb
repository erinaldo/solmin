Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmAgregarOperacion

#Region "Atributo"
  Private mNOPRCN As Double = 0
  Private mRUTA As String = ""
  Private mTCMPCL As String = ""
  Private mQKMREC As Double = 0
  Private mCCMPN As String = ""
  Private mCDVSN As String = ""
  Private mCPLNDV As Double = 0
  Private objLista As List(Of OperacionTransporte)
#End Region

#Region "Propiedades"
  Public ReadOnly Property NOPRCN_1() As Double
    Get
      Return mNOPRCN
    End Get
  End Property

  Public ReadOnly Property RUTA_1() As Double
    Get
      Return mRUTA
    End Get
  End Property

  Public ReadOnly Property QKMREC_1() As String
    Get
      Return mQKMREC
    End Get
  End Property

  Public ReadOnly Property TCMPCL_1() As String
    Get
      Return mTCMPCL
    End Get
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As String
    Set(ByVal value As String)
      mCPLNDV = value
    End Set
  End Property

  Public ReadOnly Property Lista() As List(Of OperacionTransporte)
    Get
      Return objLista
    End Get
  End Property

#End Region

#Region "Eventos"

  Private Sub frmBuscarOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Alinear_Columna_Grilla()

  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    Me.Asignar_Datos()
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
    Me.Lista_Operaciones_x_Guia_y_Tracto()
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick
    If Me.gwdDatos.RowCount = 0 Then Exit Sub
    Select Case e.ColumnIndex
      Case 0
        Me.gwdDatos.EndEdit()
    End Select
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Alinear_Columna_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Lista_Operaciones_x_Guia_y_Tracto()
    Dim objLogica As New OperacionTransporte_BLL
    Dim objEntidad As New OperacionTransporte
    Dim objParametro As New Hashtable
    Dim dwvrow As DataGridViewRow

    objParametro.Add("NGUITR", Me.txtGuiaTransportista.Text.Trim)
    objParametro.Add("CTRSPT", Me.txtTracto.Tag)
    objParametro.Add("NPLCTR", Me.txtTracto.Text.Trim)
    objParametro.Add("CCMPN", Me.mCCMPN)
    objParametro.Add("CDVSN", Me.mCDVSN)
    objParametro.Add("CPLNDV", Me.mCPLNDV)
    objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
    objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))

    Me.gwdDatos.Rows.Clear()
    For Each objEntidad In objLogica.Listar_Operacion_x_Guia_y_Tracto(objParametro)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)
      dwvrow.Cells(0).Value = False
      dwvrow.Cells(1).Value = objEntidad.NGUITR
      dwvrow.Cells(2).Value = objEntidad.NOPRCN
      dwvrow.Cells(3).Value = objEntidad.FINCOP_S
      dwvrow.Cells(4).Value = objEntidad.NPLNMT
      dwvrow.Cells(5).Value = objEntidad.TCMPCL
      dwvrow.Cells(6).Value = objEntidad.NORSRT
      dwvrow.Cells(7).Value = objEntidad.RUTA
      dwvrow.Cells(8).Value = objEntidad.QKMREC
      dwvrow.Cells(9).Value = objEntidad.PMRCDR
      dwvrow.Cells(10).Value = objEntidad.SESTOP
      Me.gwdDatos.Rows.Add(dwvrow)
    Next
  End Sub

  Private Sub Asignar_Datos()
    Dim objEntidad As OperacionTransporte
    objLista = New List(Of OperacionTransporte)
    Try
      For lint_Indice As Integer = 0 To Me.gwdDatos.RowCount - 1
        objEntidad = New OperacionTransporte
        If Me.gwdDatos.Item(0, lint_Indice).Value = True Then
          objEntidad.NOPRCN = Me.gwdDatos.Item("NOPRCN", lint_Indice).Value
          objEntidad.TCMPCL = Me.gwdDatos.Item("TCMPCL", lint_Indice).Value
          objEntidad.RUTA = Me.gwdDatos.Item("RUTA", lint_Indice).Value
          objEntidad.QKMREC = Me.gwdDatos.Item("QKMREC", lint_Indice).Value
          objLista.Add(objEntidad)
        End If
      Next
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Catch : End Try
  End Sub

#End Region

End Class
