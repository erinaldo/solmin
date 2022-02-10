Imports System.Collections
Imports SOLMIN_SC.Negocio

Public Class frmRptCargInternac

  Dim Filtro As New Hashtable()

  Dim objCrep1 As rptMenCI
    Private Sub frmRptCargInternac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.IdCompaniaDeploy)
            verGrafico(False)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName

            CargarFiltroDatos()
            dtpFecIni.Value = Now.AddMonths(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
  
  Private Sub Cargar_Compania()
    cmbCompania.Usuario = HelpUtil.UserName
    cmbCompania.CCMPN_CompaniaDefault = "EZ"
    cmbCompania.pActualizar()
    End Sub


    Private Sub CargarFiltroDatos()

        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "T"
        dr("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(dr, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        'cboTipoOperacion.SelectedValue = "T"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False


        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim drEstado As DataRow
        drEstado = dtEstado.NewRow
        drEstado("VALUE") = "T"
        drEstado("DISPLAY") = "::TODOS::"
        dtEstado.Rows.Add(drEstado)

        drEstado = dtEstado.NewRow
        drEstado("VALUE") = "A"
        drEstado("DISPLAY") = "EN ATENCION"
        dtEstado.Rows.Add(drEstado)

        drEstado = dtEstado.NewRow
        drEstado("VALUE") = "C"
        drEstado("DISPLAY") = "CERRADOS"
        dtEstado.Rows.Add(drEstado)

        cboEstado.DataSource = dtEstado
        cboEstado.ValueMember = "VALUE"
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.SelectedValue = "T"
        cboEstado.Enabled = False

        Dim dtCheckPoint As New DataTable
        dtCheckPoint.Columns.Add("VALUE")
        dtCheckPoint.Columns.Add("DISPLAY")
        Dim drCheck As DataRow
        drCheck = dtCheckPoint.NewRow
        drCheck("VALUE") = "107"
        drCheck("DISPLAY") = "FECHA EMBARQUE"
        dtCheckPoint.Rows.Add(drCheck)

        For Each Item As DataRow In dtCheckPoint.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next

        cboCheckPoint.DataSource = dtCheckPoint
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = "107"
        cboCheckPoint.Enabled = False


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

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            VisorRep.ReportSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
    End Sub

    Private Sub verGrafico(ByVal ver As Boolean)
        btnBuscar.Enabled = Not ver
        lblBusqueda.Visible = ver
        lblBusqueda.Text = "..Consultando.."
        pbxBuscar.Visible = ver
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
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

    Public Sub CargarFiltro()
        Filtro = New Hashtable()
        Filtro.Add("FecIni", Format(Me.dtpFecIni.Value, "yyyyMMdd"))
        Filtro.Add("FecFin", Format(Me.dtpFecFin.Value, "yyyyMMdd"))
        Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
        Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
        Filtro.Add("CCMPN", GetCompania())
        Filtro.Add("Des_Cliente", Me.cmbCliente.pRazonSocial.ToString.Trim)
        Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
        Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)

        Filtro.Add("Cod_Estado_Emb", cboEstado.SelectedValue)
        Filtro.Add("Cod_NESTDO", cboCheckPoint.SelectedValue)

    End Sub


    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

        objCrep1 = New rptMenCI
        Dim dblFecIni, dblFecFin As Double
        Dim NESTDO As Decimal = 0
        Dim CodEstadoEmb As String = ""
        Dim Des_Cliente As String = Filtro("Des_Cliente")
        Dim Cod_Cliente As Double = Filtro("Cod_Cliente")
        dblFecIni = Filtro("FecIni")
        dblFecFin = Filtro("FecFin")
        Dim inicio As String = Filtro("Inicio")
        Dim fin As String = Filtro("Fin")
        CodEstadoEmb = Filtro("Cod_Estado_Emb")
        NESTDO = Filtro("Cod_NESTDO")


        Dim objRep As New clsRptMenCI
        Dim objCrep As New rptMenCI
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim lstrPeriodo, TipoOperacion As String
        Dim CCMPN As String = Filtro("CCMPN")
        TipoOperacion = Filtro("TipoOperacion")
        lstrPeriodo = inicio & " al " & fin
        objDt = objRep.dtRepMenCI(CCMPN, Des_Cliente, Cod_Cliente, dblFecIni, dblFecFin, TipoOperacion, NESTDO, CodEstadoEmb)
        objDt.TableName = "dtRepMenCI"
        objDs.Tables.Add(objDt.Copy)
        objDt = objRep.TotalEnvio
        objDt.TableName = "dtTotalEnvio"
        objDs.Tables.Add(objDt.Copy)
        objCrep1.SetDataSource(objDs)
        CType(objCrep1.ReportDefinition.ReportObjects("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = lstrPeriodo

    End Sub

    Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
        Try
            VisorRep.ReportSource = objCrep1
            verGrafico(False)
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
