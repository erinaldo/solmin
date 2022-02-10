Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Data
 
Public Class frmAsignacionOrdenServicio

  Private _lstr_NroJunta As String = ""

  Public Property NroJunta() As String
    Get
      Return _lstr_NroJunta
    End Get
    Set(ByVal value As String)
      _lstr_NroJunta = value
    End Set
  End Property

  Private Sub frmAsignacionOrdenServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    If Me.NroJunta = "" Then
      HelpClass.MsgBox("Debe de seleccionar una junta de transporte")
      Me.Close()
    End If

    Dim objJuntaTransporte As New Junta_Transporte_BLL
    Dim objEntidad As New Junta_Transporte
    Dim objListado As New List(Of Object)
    objEntidad.NPLNJT = _lstr_NroJunta

    objListado = objJuntaTransporte.Listar_Solicitudes_x_Junta(objEntidad)

    'Se itera los registros de la coleccion y los agregamos a la grilla
    For Each obj As Object In objListado

      Dim objdatarow(6) As Object
      objdatarow(0) = obj(0)
      objdatarow(1) = obj(1)
      objdatarow(2) = ""
      objdatarow(3) = obj(2)

      If obj(3) <> "0" Then
        objdatarow(4) = SOLMIN_ST.My.Resources.button_ok
      Else
        objdatarow(4) = SOLMIN_ST.My.Resources.runprog
      End If

      objdatarow(5) = obj(3)
      objdatarow(6) = obj(4)

      'volviendo a preguntar si ya existe, sino para actualizar solo
      'si tiene el numero de operacion establecido

      Me.gwdDatos.Rows.Add(objdatarow)

    Next


    'Cargando los combos de Compañia, Division y Planta
    Cargar_Combos()

    'Seleccionando los valores por defecto
    Me.ctbCompania.Codigo = HelpClass.getSetting("Compania")
    Me.ctbDivision.Codigo = HelpClass.getSetting("Division")
    Me.ctbPlanta.Codigo = HelpClass.getSetting("Planta")

  End Sub

  Public Sub Cargar_Combos()

    With Me.ctbCompania
      .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("COMPANIA"), DataTable).Copy()
      .KeyField = "CCMPN"
      .ValueField = "TCMPCM"
      .DataBind()
    End With

    With Me.ctbDivision
      .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("DIVISION"), DataTable).Copy()
      .KeyField = "CDVSN"
      .ValueField = "TCMPDV"
      .DataBind()
    End With

    With Me.ctbPlanta
      .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("PLANTA"), DataTable).Copy()
      .KeyField = "CPLNDV"
      .ValueField = "TPLNTA"
      .DataBind()
    End With

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub gwdDatos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellEndEdit

    If e.RowIndex = -1 Then
      Exit Sub
    End If

    'Valida la columna de 
    If e.ColumnIndex = 2 Then

      If IsNumeric(gwdDatos.Item(2, e.RowIndex).Value.ToString().Trim()) = False Then
        HelpClass.MsgBox("Ingrese un numero de orden de servicio")
        gwdDatos.Item(2, e.RowIndex).Value = ""
        Exit Sub
      End If

      If gwdDatos.Item(5, e.RowIndex).Value.ToString().Trim() <> "0" Then
        HelpClass.MsgBox("Ya tiene numero de Operacion Generada")
        gwdDatos.Item(2, e.RowIndex).Value = ""
        Exit Sub
      End If

      If gwdDatos.Item(2, e.RowIndex).Value.ToString().Trim() = "" Then
        Exit Sub
      End If

      'capturando los datos basicos de la fila y enviarlos a la capa de  negocio
      Dim objOperacionTransporte As New OperacionTransporte_BLL
      Dim objLista As New List(Of String)
      Dim objStatus As String

      objLista.Add(gwdDatos.Item(0, e.RowIndex).Value.ToString().Trim())
      objLista.Add(gwdDatos.Item(2, e.RowIndex).Value.ToString().Trim())
      objLista.Add(gwdDatos.Item(6, e.RowIndex).Value.ToString().Trim())

      objStatus = objOperacionTransporte.Validar_Asignacion_Operacion_Transporte(objLista)
      If objStatus.StartsWith("ERROR") Then
        Me.gwdDatos.Item(4, e.RowIndex).Value = SOLMIN_ST.My.Resources.runprog
        gwdDatos.Item(2, e.RowIndex).Value = ""
        HelpClass.MsgBox(objStatus)
      Else
        Me.gwdDatos.Item(4, e.RowIndex).Value = SOLMIN_ST.My.Resources.button_ok
      End If

    End If


  End Sub

  Private Sub btnGenerarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOperacion.Click

    Dim lbool_status_ok As Boolean = True
    Dim lint_cantidad_vacios As Integer = 0
    Dim objOperacionTransporte As New OperacionTransporte_BLL
    Dim objLista As New List(Of String)
    Dim lstr_NroOperacion As String = ""

    For i As Integer = 0 To Me.gwdDatos.Rows.Count - 1

      Dim objFila As New DataGridViewRow
      objFila = Me.gwdDatos.Rows(i)

      If objFila.Cells(2).Value Is DBNull.Value Then
        GoTo NextIteration
      End If

      If objFila.Cells(2).Value.ToString().Trim() = "" Then
        GoTo NextIteration
      End If

      objLista.Clear()
      lstr_NroOperacion = ""

      objLista.Add(objFila.Cells(0).Value.ToString().Trim())
      objLista.Add(objFila.Cells(2).Value.ToString().Trim())
      objLista.Add(Me._lstr_NroJunta)
      objLista.Add(Me.ctbCompania.Codigo)
      objLista.Add(Me.ctbDivision.Codigo)
      objLista.Add(Me.ctbPlanta.Codigo)
      objLista.Add(MainModule.USUARIO)
      objLista.Add(HelpClass.TodayNumeric)
      objLista.Add(HelpClass.NowNumeric)
            objLista.Add(Ransa.Utilitario.HelpClass.NombreMaquina)

      If objFila.Cells(5).Value.ToString.Trim = "0" Then

        lstr_NroOperacion = objOperacionTransporte.Registrar_Operacion_Transporte(objLista)

        If lstr_NroOperacion.StartsWith("ERROR") Or lstr_NroOperacion = "-1" Then
          objFila.Cells(4).Value = SOLMIN_ST.My.Resources._stop
        Else
          objFila.Cells(4).Value = SOLMIN_ST.My.Resources.button_ok
          objFila.Cells(5).Value = lstr_NroOperacion
        End If

      End If

NextIteration:
    Next

    Try
      'Establenciendo como Atendida la Junta
      If HelpClass.RspMsgBox("Desea que la Junta Nro° " & NroJunta & " pase al estado ATENDIDO?") = Windows.Forms.DialogResult.Yes Then
        Dim objJuntaTransporte As New Junta_Transporte_BLL
        Dim objEntidad As New Junta_Transporte
        objEntidad.NPLNJT = NroJunta
        objEntidad.SESPLN = "A"
        objJuntaTransporte.Actualizar_Junta_Transporte(objEntidad)
        HelpClass.MsgBox("La junta Nro° " & NroJunta & " está como ATENDIDA")
      End If
    Catch ex As Exception
      HelpClass.MsgBox("Error" & Chr(13) & ex.Message)
    End Try

  End Sub

  Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
    Me.Close()
  End Sub
End Class