Imports SOLMIN_SC.Negocio
Imports System.Collections

Public Class frmRptSegAduaneroResum

  Dim Filtro As New Hashtable()
  Dim objCrep As New rptMenSA
    Private Sub frmRptSegAduaneroResum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            verGrafico(False)
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            CargarFiltroDatos()
            Cargar_Compania()
            dtpFecIni.Value = Now.AddMonths(-1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarFiltroDatos()

        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "::TODOS::"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "A"
        dr("DISPLAY") = "EN ATENCION"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "C"
        dr("DISPLAY") = "CERRADOS"
        dtEstado.Rows.Add(dr)

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
        drCheck("VALUE") = "124"
        drCheck("DISPLAY") = "FECHA ENTREGA ALMACEN"
        dtCheckPoint.Rows.Add(drCheck)

        For Each Item As DataRow In dtCheckPoint.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next


        cboCheckPoint.DataSource = dtCheckPoint
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = "124"
        cboCheckPoint.Enabled = False


        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim drTipo As DataRow
        drTipo = dtTipoOperacion.NewRow
        drTipo("COD") = "T"
        drTipo("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(drTipo, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        'cboTipoOperacion.SelectedValue = "T"
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


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            VisorRep.ReportSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
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
        Filtro.Add("CCMPN", GetCompania)
        Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
        Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
        Filtro.Add("Des_Cliente", Me.cmbCliente.pRazonSocial.ToString.Trim)
        Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
        If cboTipoOperacion.SelectedValue = "0" Then
            Filtro.Add("TipoOperacion", "")
        Else
            Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)
        End If

        Filtro.Add("PNNESTDO", cboCheckPoint.SelectedValue)
        Filtro.Add("PSESTADO_EMB", cboEstado.SelectedValue)

    End Sub

    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork

        Dim dblFecIni, dblFecFin, Cod_Cliente As Double
        Dim PNNESTDO As Decimal = 0
        Dim PSESTADO_EMB As String = ""

        Dim CCMPN As String = Filtro("CCMPN")
        Dim Des_Cliente As String = Filtro("Des_Cliente")
        dblFecIni = Filtro("FecIni")
        dblFecFin = Filtro("FecFin")
        Dim TipoOperacion As String = Filtro("TipoOperacion")
        Cod_Cliente = Filtro("Cod_Cliente")

        PNNESTDO = Filtro("PNNESTDO")
        PSESTADO_EMB = Filtro("PSESTADO_EMB")


        Dim objRep As New clsRepMenSA
        objCrep = New rptMenSA
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim lstrPeriodo As String
        Dim inicio As String = Filtro("Inicio")
        Dim fin As String = Filtro("Fin")
        lstrPeriodo = inicio & " al " & fin
        objDt = objRep.dtRepMenAD(CCMPN, Des_Cliente, Cod_Cliente, dblFecIni, dblFecFin, lstrPeriodo, TipoOperacion, PNNESTDO, PSESTADO_EMB)

        objDt.TableName = "dtRepMenAdn"
        objDs.Tables.Add(objDt.Copy)
        objCrep.SetDataSource(objDs)
        CType(objCrep.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SEGUIMIENTO ADUANERO " & lstrPeriodo.Trim
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
