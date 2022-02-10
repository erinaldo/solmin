Imports SOLMIN_SC.Negocio
Public Class frmRptLiquidacionPagos


    Private Sub frmRptLiquidacionPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName

            Cargar_TipoOperacion()

            dtpFecIni.Value = Now.AddMonths(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

    Private Sub Cargar_TipoOperacion()
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
    Try
      If Me.txtOS.Text.ToString.Trim <> vbNullString Then
        Dim objRep As New clsRepLiqAntamina
        Dim objCrep As New rptLiqAntamina
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim CCMPN As String = GetCompania()
        Dim TipoOperacion As String = cboTipoOperacion.SelectedValue
        If TipoOperacion = "0" Then
          TipoOperacion = ""
        End If
        objDt = objRep.dtRepLiqAntamina(CCMPN, Me.txtOS.Text.ToString.Trim, TipoOperacion)
        objDt.TableName = "dtRepLiqAntamina"
        objDs.Tables.Add(objDt.Copy)
        objCrep.SetDataSource(objDs)
        CType(objCrep.ReportDefinition.ReportObjects("txtPago"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtNroPago.Text.Trim
        VisorRep.ReportSource = objCrep
      Else
        HelpUtil.MsgBox("Debe ingresar un número de Orden de Servicio")
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

End Class
