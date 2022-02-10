Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmGuiaTransportista_Facturacion

#Region "Atributos"
  Private bolBuscar As Boolean
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private objDivision As New NEGOCIO.Division_BLL
#End Region

  Private Sub frmGuiaTransportista_Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      bolBuscar = False
      Me.Alinear_Columnas_Grilla()
      Me.Cargar_Compania()
      Me.Listar_Solicitudes_Guia_Transportista()
    Catch : End Try
  End Sub

  Private Sub Cargar_Compania()
    objCompaniaBLL.Crea_Lista()
    bolBuscar = False
    Me.cboCompania.DataSource = objCompaniaBLL.Lista
    Me.cboCompania.ValueMember = "CCMPN"
    bolBuscar = True
    Me.cboCompania.DisplayMember = "TCMPCM"
        ' Me.cboCompania.SelectedIndex = 0
        cboCompania.SelectedValue = "EZ"
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
  End Sub

  Private Sub Cargar_Division()
    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
      bolBuscar = False
      objDivision.Crea_Lista()
      Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
      Me.cboDivision.ValueMember = "CDVSN"
      bolBuscar = True
      Me.cboDivision.DisplayMember = "TCMPDV"
      Me.cboDivision.SelectedIndex = 0
      Me.Cursor = System.Windows.Forms.Cursors.Default
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Planta()
    Try
      If bolBuscar Then
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        bolBuscar = False
        objPlanta.Crea_Lista()
        Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
        Me.cboPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        Me.cboPlanta.DisplayMember = "TPLNTA"
        Me.cboPlanta.SelectedIndex = 0
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
    If bolBuscar Then
      Me.Cargar_Division()
    End If
  End Sub

  Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
    If bolBuscar Then
      Me.Cargar_Planta()
    End If
  End Sub

  Private Sub Agregar_Guia_Remision_Para_Facturacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    If Me.gwdDatos.RowCount = 0 Then Exit Sub
    Me.Agregar_Guia_Remision(Me.gwdDatos.CurrentCellAddress.Y)
  End Sub

  Private Sub Agregar_Guia_Remision(ByVal lint_Indice As Integer)
    Dim frm_frmGuiaRemision_Facturacion As New frmGuiaRemision_Facturacion

    With frm_frmGuiaRemision_Facturacion
      .NGUIRM = Me.gwdDatos.Item("NGUITR", lint_Indice).Value
      .CTRMNC = Me.gwdDatos.Item("CTRSPT", lint_Indice).Value
      If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      Me.Listar_Guias_Remision(CType(Me.gwdDatos.Item("NOPRCN", Me.gwdDatos.CurrentCellAddress.Y).Value, Double))
    End With
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdGuiaRemision.AutoGenerateColumns = False

    For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_Contador As Integer = 0 To Me.gwdGuiaRemision.ColumnCount - 1
      Me.gwdGuiaRemision.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.RowCount > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub gwdGuiaRemision_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdGuiaRemision.DataBindingComplete
    If Me.gwdGuiaRemision.RowCount > 0 Then
      Me.gwdGuiaRemision.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Listar_Solicitudes_Guia_Transportista()
  End Sub

  Private Sub Listar_Solicitudes_Guia_Transportista()
    Dim objetoParametro As New Hashtable
    Dim objetoLogica As New GuiaTransportista_BLL

    objetoParametro.Add("PNNGUIRM", Me.txtGuiaTransportista.Text)
    objetoParametro.Add("PSNPLCUN", Me.txtPlaca.Text)
    objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
    objetoParametro.Add("PNCPLNDV", Me.cboPlanta.SelectedValue)
    objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
        objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
        objetoParametro.Add("CCMPN", Me.cboCompania.SelectedValue)

    Me.gwdDatos.DataSource = objetoLogica.Listar_Solicitudes_Guia_Transportista(objetoParametro)
  End Sub

  Private Sub Listar_Guias_Remision_x_Operacion(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    If Me.gwdDatos.RowCount = 0 Then Exit Sub
    If e.RowIndex = -1 Then Exit Sub
    Me.Listar_Guias_Remision(CType(Me.gwdDatos.Item("NOPRCN", e.RowIndex).Value, Double))
  End Sub

  Private Sub Listar_Guias_Remision(ByVal ldbl_NOPRCN As Double)
    Dim objetoParametro As New Hashtable
    Dim objetoLogica As New GuiaTransportista_BLL
        objetoParametro.Add("PNNOPRCN", ldbl_NOPRCN)
    objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)

    Me.gwdGuiaRemision.DataSource = objetoLogica.Listar_Guia_Remision_x_Operacion(objetoParametro)
  End Sub

  Private Sub Cambiar_A_Estado_Cerrar_Operacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarGuia.Click

  End Sub

  Private Sub txtGuiaTransportista_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransportista.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub
End Class
