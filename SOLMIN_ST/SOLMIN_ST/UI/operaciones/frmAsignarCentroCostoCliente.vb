Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmAsignarCentroCostoCliente

#Region "Eventos"

  Private Sub frmAsignarCentroCostoCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.ddlEstado.SelectedIndex = 1
    Me.Cargar_Compania()
    Me.Alinear_Columnas_Grilla()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Cursor = Cursors.WaitCursor
    Me.Listar()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnActualizarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarInfo.Click
    Dim intIndice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    If Me.gwdDatos.RowCount = 0 OrElse intIndice < 0 Then Exit Sub
    Dim frm_CentroCostoCliente As New frmCentroCostoCliente
    Dim objEntidad As New Solicitud_Transporte
    objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    objEntidad.CDVSN = Me.cmbDivision.Division
    objEntidad.CPLNDV = Me.cmbPlanta.Planta
    objEntidad.TCMPCL = Me.gwdDatos.Item("CCLNT", intIndice).Value.ToString.Trim
    objEntidad.CCTCSC = Me.gwdDatos.Item("CCTCSC", intIndice).Value.ToString.Trim
    objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", intIndice).Value
    With frm_CentroCostoCliente
      .Entidad_Solicitud = objEntidad
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Me.gwdDatos.Item("CCTCSC", intIndice).Value = .Entidad_Solicitud.CCTCSC
      End If
    End With
  End Sub

#End Region

#Region "Métodos"

  Private Sub Listar()
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
    Dim objParamList As New List(Of String)

    If txtClienteFiltro.pCodigo <> 0 Then
      objParamList.Add(txtClienteFiltro.pCodigo)
    Else
      objParamList.Add("0")
    End If

    If Me.txtNroSolicitud.Text.Trim = "" Then
      objParamList.Add("0")
    Else
      objParamList.Add(Me.txtNroSolicitud.Text)
    End If

    objParamList.Add(Asignar_Valor)
    objParamList.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
    objParamList.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
    objParamList.Add(Me.cmbCompania.CCMPN_CodigoCompania)
    objParamList.Add(Me.cmbDivision.Division)
    objParamList.Add(Me.cmbPlanta.Planta)

    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Selva(objParamList)

  End Sub

  Private Function Asignar_Valor() As String
    Dim cadena As String = ""

    If Me.ddlEstado.SelectedIndex = 0 Then
      cadena = ""
    ElseIf Me.ddlEstado.SelectedIndex = 1 Then
      cadena = "P"
    ElseIf Me.ddlEstado.SelectedIndex = 2 Then
      cadena = "C"
    End If
    Return cadena

  End Function

  Private Sub Cargar_Compania()
    Try
      Me.cmbCompania.Usuario = MainModule.USUARIO
            'Me.cmbCompania.CCMPN_CompaniaDefault = "EZ"
            Me.cmbCompania.pActualizar()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    Catch ex As Exception
    End Try
  End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar

        Me.cmbDivision.Usuario = MainModule.USUARIO
        Me.cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        Me.cmbDivision.DivisionDefault = "T"
        Me.cmbDivision.pActualizar()

        If (Me.cmbCompania.CCMPN_ANTERIOR <> Me.cmbCompania.CCMPN_CodigoCompania) Then
            gwdDatos.DataSource = Nothing
            Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
        End If

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Me.cmbPlanta.Usuario = MainModule.USUARIO
        Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        Me.cmbPlanta.PlantaDefault = 1
        Me.cmbPlanta.pActualizar()

    End Sub

  Private Sub Alinear_Columnas_Grilla()

    Me.dgSolicitudCuenta.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dgSolicitudCuenta.ColumnCount - 1
      Me.dgSolicitudCuenta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next

  End Sub

#End Region

End Class
