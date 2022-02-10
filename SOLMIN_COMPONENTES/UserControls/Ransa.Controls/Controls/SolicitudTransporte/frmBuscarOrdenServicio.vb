Imports Ransa.Controls.Operaciones
Imports System.Data
Imports System.Windows.Forms

Public Class frmBuscarOrdenServicio

  Private _CodigoCliente As String = ""
  Private _OrdenServicio As String = ""
    Public objOrdenServicioTransporteBE As OrdenServicioTransporte
  Private objListOrdenServicioTransporteBE As New List(Of OrdenServicioTransporte)
  Private _CCMPN As String = ""
    Private _CDVSN As String = ""

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public Property CodigoCliente() As String
    Get
      Return _CodigoCliente
    End Get
    Set(ByVal value As String)
      _CodigoCliente = value
    End Set
    End Property


    Private Sub Cargar_Combos()
        'MainModule.ClearMemory()
        ' MainModule.CargarTablasGlobales()
        Dim objDbBridge As New DbBridge_BLL
        If MainModule.gobj_TablasGeneralesdelSistema.Count > 0 Then
            MainModule.gobj_TablasGeneralesdelSistema.Clear()
        End If
        MainModule.gobj_TablasGeneralesdelSistema.Add("PLANTA", objDbBridge.GetTable("CALL SP_SOLMIN_TR_LISTAR_PLANTAS('" & _CCMPN & "','" & _CDVSN & "')"))

        With Me.ctlPlanta
            .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("PLANTA"), DataTable).Copy()
            .KeyField = "CPLNDV"
            .ValueField = "TPLNTA"
            .DataBind()
            ' .Codigo = IIf(_CCMPN = "EZ", HelpClass.getSetting("Planta"), 38)

            .Codigo = IIf(_CCMPN = "EZ", 1, 38)
        End With

    End Sub


  Private Sub frmBuscarOrdenServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCliente.pUsuario = _pUsuario
    bolEstado = False
    Cargar_Combos()
    txtCliente.CCMPN = _CCMPN
    txtCliente.pCargar(CodigoCliente)
    If CodigoCliente <> "" Then
      Listar_Orden_Servicio()
      bolEstado = True
    End If
  End Sub

  Private Sub Listar_Orden_Servicio()
    Dim objOrdenServicio As New OrdenServicio_BLL
    Dim objParametros As New List(Of String)
    objParametros.Add(Me.txtOrdenServicio.Text)
    objParametros.Add(Me.txtCliente.pCodigo)
    objParametros.Add(Me.CCMPN)
    objParametros.Add(Me.CDVSN)
    objParametros.Add(Me.ctlPlanta.Codigo)
    Me.gdwDatos.AutoGenerateColumns = False
    objListOrdenServicioTransporteBE = objOrdenServicio.Listar_Ordenes_Servicio(objParametros)
    Me.gdwDatos.DataSource = Nothing
    Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE
    Llenar_Combo(objParametros)
    If gintEstado <> 100 Then gintEstado = -1
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    If Me.txtCliente.pCodigo = 0 Then
      Exit Sub
    End If
    Listar_Orden_Servicio()
    If Me.gdwDatos.RowCount > 0 Then bolEstado = True
  End Sub

#Region "Llenar Combos"

  Private Sub Limpiar_Combo()
    cmbOrigen.DataSource = Nothing
    cmbDestino.DataSource = Nothing
  End Sub

  Private Sub Llenar_Combo(ByVal objParametros As List(Of String))
    Limpiar_Combo()
    Llenar_Punto_Origen(objParametros)
    Llenar_Punto_Destino(objParametros)
  End Sub

  Private Sub Llenar_Punto_Origen(ByVal objParametros As List(Of String))
    Dim objOrdenServicio As New OrdenServicio_BLL

    cmbOrigen.DataSource = Llenar_Combo_Origen(objParametros)
    cmbOrigen.DisplayMember = "CLCLOR"
    cmbOrigen.ValueMember = "PNTORG"
  End Sub

  Private Sub Llenar_Punto_Destino(ByVal objParametros As List(Of String))
    Dim objOrdenServicio As New OrdenServicio_BLL

    cmbDestino.DataSource = Llenar_Combo_Destino(objParametros)
    cmbDestino.DisplayMember = "CLCLDS"
    cmbDestino.ValueMember = "PNTDES"
  End Sub

  Private Function Llenar_Combo_Origen(ByVal objParametros As List(Of String)) As List(Of OrdenServicioTransporte)
    Dim objLisResulOrdenServicioTransporteBE As New List(Of OrdenServicioTransporte)
    Dim intCont As Integer
    Dim intRow As Integer
    Dim intExiste As Integer = 1
    If Me.objListOrdenServicioTransporteBE.Count > 0 Then
      objOrdenServicioTransporteBE = New OrdenServicioTransporte
      objOrdenServicioTransporteBE.PNTORG = ""
      objOrdenServicioTransporteBE.CLCLOR = "TODOS"
      objLisResulOrdenServicioTransporteBE.Add(objOrdenServicioTransporteBE)
    End If
    For intRow = objListOrdenServicioTransporteBE.Count - 1 To 0 Step -1
      For intCont = 0 To objLisResulOrdenServicioTransporteBE.Count - 1
        If objLisResulOrdenServicioTransporteBE.Item(intCont).PNTORG.Trim = objListOrdenServicioTransporteBE.Item(intRow).PNTORG.Trim Then

          intExiste = 0
          Exit For
        Else
          intExiste = 1
        End If
      Next
      If intExiste = 1 Then
        If objListOrdenServicioTransporteBE.Item(intRow).PNTORG.Trim <> 0 Then
          objLisResulOrdenServicioTransporteBE.Add(objListOrdenServicioTransporteBE.Item(intRow))
        End If
      End If
    Next
    Return objLisResulOrdenServicioTransporteBE
  End Function

  Private Function Llenar_Combo_Destino(ByVal objParametros As List(Of String)) As List(Of OrdenServicioTransporte)
    Dim objLisResulOrdenServicioTransporteBE As New List(Of OrdenServicioTransporte)
    Dim intCont As Integer
    Dim intRow As Integer
    Dim intExiste As Integer = 1

    If Me.objListOrdenServicioTransporteBE.Count > 0 Then
      objOrdenServicioTransporteBE = New OrdenServicioTransporte
      objOrdenServicioTransporteBE.PNTDES = ""
      objOrdenServicioTransporteBE.CLCLDS = "TODOS"
      objLisResulOrdenServicioTransporteBE.Add(objOrdenServicioTransporteBE)
    End If

    For intRow = objListOrdenServicioTransporteBE.Count - 1 To 0 Step -1
      For intCont = 0 To objLisResulOrdenServicioTransporteBE.Count - 1
        If objLisResulOrdenServicioTransporteBE.Item(intCont).PNTDES.Trim = objListOrdenServicioTransporteBE.Item(intRow).PNTDES.Trim Then

          intExiste = 0
          Exit For
        Else
          intExiste = 1
        End If
      Next
      If intExiste = 1 Then
        If objListOrdenServicioTransporteBE.Item(intRow).PNTDES.Trim <> 0 Then
          objLisResulOrdenServicioTransporteBE.Add(objListOrdenServicioTransporteBE.Item(intRow))
        End If
      End If
    Next
    Return objLisResulOrdenServicioTransporteBE
  End Function

#End Region

#Region "Búsqueda"

  Private bolEstado As Boolean

  Private Sub cmbOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.SelectedIndexChanged
    If bolEstado Then
      If Me.cmbOrigen.SelectedValue = "" Then
        If Me.cmbDestino.SelectedValue = "" Then
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Total)
        Else
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Total_Normal)
        End If
      Else
        If Me.cmbDestino.SelectedValue = "" Then
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Normal_Total)
        Else
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Normal)
        End If
      End If
    End If
  End Sub

  Private match_Normal As New Predicate(Of OrdenServicioTransporte)(AddressOf Busca_Normal)

  Private match_Total As New Predicate(Of OrdenServicioTransporte)(AddressOf Busca_Total)

  Private match_Total_Normal As New Predicate(Of OrdenServicioTransporte)(AddressOf Busca_Total_Normal)

  Private match_Normal_Total As New Predicate(Of OrdenServicioTransporte)(AddressOf Busca_Normal_Total)

  Public Function Busca_Normal(ByVal RolOpcionBE As OrdenServicioTransporte) As Boolean
    If RolOpcionBE.PNTORG.Trim = Me.cmbOrigen.SelectedValue And RolOpcionBE.PNTDES.Trim = Me.cmbDestino.SelectedValue Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Busca_Total(ByVal RolOpcionBE As OrdenServicioTransporte) As Boolean
    If (RolOpcionBE.PNTORG.Trim.IndexOf(Me.cmbOrigen.SelectedValue) <> -1 And RolOpcionBE.PNTORG.ToUpper.Trim <> "0") And (RolOpcionBE.PNTDES.Trim.IndexOf(Me.cmbDestino.SelectedValue) <> -1 And RolOpcionBE.PNTDES.ToUpper.Trim <> "0") Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Busca_Total_Normal(ByVal RolOpcionBE As OrdenServicioTransporte) As Boolean
    If (RolOpcionBE.PNTORG.Trim.IndexOf(Me.cmbOrigen.SelectedValue) <> -1) And RolOpcionBE.PNTDES.Trim = Me.cmbDestino.SelectedValue Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function Busca_Normal_Total(ByVal RolOpcionBE As OrdenServicioTransporte) As Boolean
    If RolOpcionBE.PNTORG.Trim = Me.cmbOrigen.SelectedValue And RolOpcionBE.PNTDES.Trim.IndexOf(Me.cmbDestino.SelectedValue) <> -1 Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub cmbDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDestino.SelectedIndexChanged
    If bolEstado Then
      If Me.cmbOrigen.SelectedValue = "" Then
        If Me.cmbDestino.SelectedValue = "" Then
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Total)
        Else
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Total_Normal)
        End If
      Else
        If Me.cmbDestino.SelectedValue = "" Then
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Normal_Total)
        Else
          Me.gdwDatos.DataSource = objListOrdenServicioTransporteBE.FindAll(match_Normal)
        End If
      End If
    End If
  End Sub

#End Region


  Private Sub gdwDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gdwDatos.CellClick
    If gintEstado <> 100 Then
      If e.RowIndex = -1 Then
        gintEstado = -1
        Exit Sub
      End If
      If Me.gdwDatos.CurrentRow Is Nothing Then Exit Sub

      Dim intFila As Integer = e.RowIndex
      For Each obj As DataGridViewRow In Me.gdwDatos.Rows
                obj.Cells(0).Value = My.Resources.runprog
      Next
            Me.gdwDatos.Rows(intFila).Cells(0).Value = My.Resources.button_ok1
      Me._OrdenServicio = Me.gdwDatos.Rows(intFila).Cells(1).Value
            objOrdenServicioTransporteBE = New OrdenServicioTransporte
      objOrdenServicioTransporteBE.CLCLOR = gdwDatos.Rows(intFila).Cells("PNTORG").Value
      objOrdenServicioTransporteBE.CLCLDS = gdwDatos.Rows(intFila).Cells("PNTDES").Value
      objOrdenServicioTransporteBE.NORSRT = gdwDatos.Rows(intFila).Cells("NORSRT").Value
      objOrdenServicioTransporteBE.CTPOSR = gdwDatos.Rows(intFila).Cells("TIPSRV").Value
      objOrdenServicioTransporteBE.CMRCDR = gdwDatos.Rows(intFila).Cells("CODMER").Value
      objOrdenServicioTransporteBE.CUNDMD = gdwDatos.Rows(intFila).Cells("CUNDMD").Value
      objOrdenServicioTransporteBE.QMRCDR = gdwDatos.Rows(intFila).Cells("QMRCDR").Value
      objOrdenServicioTransporteBE.NCRRCT = gdwDatos.Rows(intFila).Cells("NCRRCT").Value
      objOrdenServicioTransporteBE.NCRRSR = gdwDatos.Rows(intFila).Cells("NCRRSR").Value
      gintEstado = 2
    Else
      If e.RowIndex = -1 Then Exit Sub
      Dim intFila As Integer = e.RowIndex
      For Each obj As DataGridViewRow In Me.gdwDatos.Rows
        obj.Cells(0).Value = My.Resources.runprog
      Next
      Me.gdwDatos.Rows(intFila).Cells(0).Value = My.Resources.button_ok1
            objOrdenServicioTransporteBE = New OrdenServicioTransporte
      objOrdenServicioTransporteBE.NORSRT = gdwDatos.Rows(intFila).Cells("NORSRT").Value
      objOrdenServicioTransporteBE.CLCLOR = gdwDatos.Rows(intFila).Cells("PNTORG").Value
      objOrdenServicioTransporteBE.CLCLDS = gdwDatos.Rows(intFila).Cells("PNTDES").Value
      objOrdenServicioTransporteBE.NCRRCT = gdwDatos.Rows(intFila).Cells("NCRRCT").Value
      objOrdenServicioTransporteBE.NCRRSR = gdwDatos.Rows(intFila).Cells("NCRRSR").Value

    End If

  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Select Case gintEstado
      Case 2
        Me.Close()
      Case 100
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Select
  End Sub

  'Propiedades

  Public Property OrdenServicio() As String
    Get
      Return _OrdenServicio
    End Get
    Set(ByVal value As String)
      _OrdenServicio = value
    End Set
  End Property

  Private Sub gdwDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gdwDatos.CellDoubleClick
    If gintEstado = 100 Then
      If e.RowIndex = -1 Then Exit Sub
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Else
      If e.RowIndex = -1 Then
        gintEstado = -1
        Exit Sub
      End If
      Me.Close()
    End If

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    If gintEstado = 100 Then
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
    Else
      gintEstado = -1
      Me.Close()
    End If

  End Sub
End Class
