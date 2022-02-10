Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmConsultaViajesRealizados

#Region "Variables"
  Private bolBuscar As Boolean
#End Region

#Region "Metodos y Funciones"

    Private Sub CargarRuta()
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim objDt As DataTable
        objDt = obj_Logica_Localidad.Listar_Localidades_Combo(Me.cboCompania.SelectedValue.ToString.Trim) 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        With Me.ctbOrigenCon1
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
        With Me.ctbOrigenCon2
            .DataSource = objDt.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With
    End Sub

  Private Sub Cargar_Compania()
    Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
    objCompaniaBLL.Crea_Lista()
    bolBuscar = False
    cboCompania.DataSource = objCompaniaBLL.Lista
    cboCompania.ValueMember = "CCMPN"
    bolBuscar = True
    cboCompania.DisplayMember = "TCMPCM"
        ' cboCompania.SelectedIndex = 0
        cboCompania.SelectedValue = "EZ"
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If

  End Sub

  Private Sub Cargar_Division()
    Dim objDivision As New NEGOCIO.Division_BLL
    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
      bolBuscar = False
      objDivision.Crea_Lista()
      cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
      cboDivision.ValueMember = "CDVSN"
      bolBuscar = True
            cboDivision.DisplayMember = "TCMPDV"
            cboDivision.SelectedValue = "T"
            If cboDivision.SelectedIndex = -1 Then
                cboDivision.SelectedIndex = 0
            End If
      Me.Cursor = System.Windows.Forms.Cursors.Default
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Planta()
    Dim objPlanta As New NEGOCIO.Planta_BLL
    Try
      If bolBuscar Then
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        bolBuscar = False
        objPlanta.Crea_Lista()
        cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
        cboPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        cboPlanta.DisplayMember = "TPLNTA"
        Me.cboPlanta.SelectedIndex = 0
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

#End Region

#Region "Eventos"

    Private Sub frmConsultaUnidadesAtendidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCliente.pUsuario = MainModule.USUARIO
        Me.Cargar_Compania()
        Me.CargarRuta()
    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Dim objLogica As New Junta_Transporte_BLL
        Dim obj_DataTable As New DataTable
        Dim obj_DataSet As New DataSet
        Dim objReporte As New rptListaViajesRealizados
        Dim objParametro As New Hashtable

        objParametro.Add("PSCCLNT", IIf(Me.txtCliente.pCodigo = 0, "", Me.txtCliente.pCodigo))
        objParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
        objParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
        objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        objParametro.Add("PNCPLNDV", Me.cboPlanta.SelectedValue)

        Me.ControlVisorLiquidacion.Muestra_Imagen()
        obj_DataTable = HelpClass.GetDataSetNative(objLogica.Lista_Viajes_Realizados(objParametro))
        If obj_DataTable.Rows.Count = 0 Then
            Me.ControlVisorLiquidacion.ReportViewer.ReportSource = Nothing
            Me.ControlVisorLiquidacion.Ocultar_Imagen()
            Exit Sub
        End If
        obj_DataTable.TableName = "RZST20"
        obj_DataSet.Tables.Add(obj_DataTable.Copy)
        objReporte.SetDataSource(obj_DataSet)
        CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = Me.dtpFechaInicio.Value.Date
        CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = Me.dtpFechaFin.Value.Date
        CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
        CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
        CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text
        Me.ControlVisorLiquidacion.ReportViewer.ReportSource = objReporte
        Me.ControlVisorLiquidacion.Ocultar_Imagen()
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
#End Region

End Class
