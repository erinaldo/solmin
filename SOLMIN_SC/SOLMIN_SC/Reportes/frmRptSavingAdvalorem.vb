Imports SOLMIN_SC.Negocio
Imports System.Collections

Public Class frmRptSavingAdvalorem

  Dim Filtro As New Hashtable()
  Dim objCrep As New rptSadAntamina
  Private Sub frmRptSavingAdvalorem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.IdCompaniaDeploy)

            verGrafico(False)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            TipoOperacion()
            dtpFecIni.Value = Now.AddMonths(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub TipoOperacion()
    Dim oclsEstado As New clsEstado
    Dim dtTipoOperacion As New DataTable
    dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
    Dim dr As DataRow
    dr = dtTipoOperacion.NewRow
    dr("COD") = "0"
    dr("TEX") = "TODOS"
    dtTipoOperacion.Rows.InsertAt(dr, 0)
    cboTipoOperacion.DataSource = dtTipoOperacion
    cboTipoOperacion.DisplayMember = "TEX"
    cboTipoOperacion.ValueMember = "COD"
        'cboTipoOperacion.SelectedValue = "0"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False
  End Sub

  Private Sub Cargar_Compania()
    cmbCompania.Usuario = HelpUtil.UserName
    cmbCompania.CCMPN_CompaniaDefault = "EZ"
    cmbCompania.pActualizar()
  End Sub
  Private Function GetCompania() As String
    Return cmbCompania.CCMPN_CodigoCompania
  End Function
  Private Function GetDivision(ByVal CCMPN As String) As String
    If CCMPN = "EZ" Then
      Return HelpUtil.getSetting("DivisionEZ")
    Else
      Return ""
    End If
  End Function

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    'Try
    '  If cmbCliente.pCodigo = 0 Then
    '    HelpUtil.MsgBox("Debe seleccionar un Cliente")
    '    Exit Sub
    '  End If
    '  Dim dblFecIni, dblFecFin As Double
    '  dblFecIni = Format(Me.dtpFecIni.Value, "yyyyMMdd")
    '  dblFecFin = Format(Me.dtpFecFin.Value, "yyyyMMdd")
    '  Dim objRep As New clsRepSadAntamina
    '  Dim objCrep As New rptSadAntamina
    '  Dim objDt As DataTable
    '  Dim objDs As New DataSet
    '  Dim lstrPeriodo As String
    '  lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
    '  objDt = objRep.dtRepMenADV(GetCompania, Me.cmbCliente.pRazonSocial.ToString.Trim, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, lstrPeriodo)
    '  objDt.TableName = "dtRepMenADV"
    '  objDs.Tables.Add(objDt.Copy)
    '  objCrep.SetDataSource(objDs)
    '  CType(objCrep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SAVING ADVALOREM " & lstrPeriodo.Trim
    '  VisorRep.ReportSource = objCrep
    'Catch ex As Exception
    '  MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    Try
      VisorRep.ReportSource = Nothing
      If cmbCliente.pCodigo = 0 Then
        HelpUtil.MsgBox("Debe seleccionar un Cliente")
        Exit Sub
      End If
      verGrafico(True)
      CargarFiltro()
      bgwProcesoReport.RunWorkerAsync()
    Catch ex As Exception
      verGrafico(False)
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub
  Private Sub verGrafico(ByVal ver As Boolean)
    btnBuscar.Enabled = Not ver
    lblBusqueda.Visible = ver
    lblBusqueda.Text = "..Consultando.."
    pbxBuscar.Visible = ver
  End Sub

  Public Sub CargarFiltro()
    Filtro = New Hashtable()
    Filtro.Add("FecIni", Format(Me.dtpFecIni.Value, "yyyyMMdd"))
    Filtro.Add("FecFin", Format(Me.dtpFecFin.Value, "yyyyMMdd"))
    Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
    Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
    Filtro.Add("Des_Cliente", Me.cmbCliente.pRazonSocial.ToString.Trim)
    Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
    Filtro.Add("GetCompañia", GetCompania())
    If cboTipoOperacion.SelectedValue = "0" Then
      Filtro.Add("TipoOperacion", "")
    Else
      Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)
    End If
  End Sub

  Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

    'Dim dblFecIni, dblFecFin As Double
    'dblFecIni = Format(Me.dtpFecIni.Value, "yyyyMMdd")
    'dblFecFin = Format(Me.dtpFecFin.Value, "yyyyMMdd")
    'Dim objRep As New clsRepSadAntamina
    'objCrep = New rptSadAntamina
    'Dim objDt As DataTable
    'Dim objDs As New DataSet
    'Dim lstrPeriodo As String
    'lstrPeriodo = Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
    'objDt = objRep.dtRepMenADV(GetCompania, Me.cmbCliente.pRazonSocial.ToString.Trim, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, lstrPeriodo)

    Dim dblFecIni, dblFecFin, Cod_Cliente As Double
    dblFecIni = Filtro("FecIni")
    dblFecFin = Filtro("FecFin")
    Cod_Cliente = Filtro("Cod_Cliente")
    Dim objRep As New clsRepSadAntamina
    objCrep = New rptSadAntamina
    Dim objDt As DataTable
    Dim objDs As New DataSet
    Dim Des_Cliente As String = Filtro("Des_Cliente")
    Dim COMPAÑIA As String = Filtro("GetCompañia")
    Dim lstrPeriodo As String
    Dim inicio As String = Filtro("Inicio")
    Dim fin As String = Filtro("Fin")
    Dim TipoOperacion As String = Filtro("TipoOperacion")
    lstrPeriodo = inicio & " al " & fin
    objDt = objRep.dtRepMenADV(COMPAÑIA, Des_Cliente, Cod_Cliente, dblFecIni, dblFecFin, lstrPeriodo, TipoOperacion)
    objDt.TableName = "dtRepMenADV"
    objDs.Tables.Add(objDt.Copy)
    objCrep.SetDataSource(objDs)
    CType(objCrep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SAVING ADVALOREM " & lstrPeriodo.Trim

  End Sub

  Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
    Try
      VisorRep.ReportSource = objCrep
      verGrafico(False)
    Catch ex As Exception
      verGrafico(False)
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
