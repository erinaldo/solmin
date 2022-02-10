Imports RANSA.NEGO
Imports Ransa.Utilitario
'Imports Ransa.TypeDef.Cliente

Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.Reportes

Public Class frmMovimientoPorProyecto


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub bgwGifAnmado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGenerarReporte()
    End Sub

    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        pReporteGuiaSalidaMercaderia()
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("ConsultaIngPorEmbarque", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteGuiaSalidaMercaderia()
        Dim dstTemp As DataSet = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        With obeFiltro
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PNCCLNT = txtCliente.pCodigo
            .PNTIPO = IIf(Me.rbtIngreso.Checked, 0, 1)
            .PNFECINI = IIf(Me.dtpFechaInicio.Checked, Me.dtpFechaInicio.Value, "")
            .PNFECFIN = IIf(Me.dtpFechaFin.Checked, Me.dtpFechaFin.Value, "")
            .PSNORCML = Me.txtOrdenDeCompra.Text
            .PNNRITOC = Val(Me.txtNrItem.Text)


        End With
        dgConsulta.AutoGenerateColumns = False
        Dim oDt As New DataTable
        oDt = obrReporteAT.fdstReporteIngDesPorEmbarque(obeFiltro)
        If Not oDt Is Nothing OrElse oDt.Rows.Count <> 0 Then
            oDt = EliminarRepetido(oDt)
        End If
        dgConsulta.DataSource = oDt
    End Sub


    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable
        'dtTemp.Select("", "TUBRFR, CREFFW  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("norcml").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("norcml").ToString.Trim) And dtTemp.Rows(i).Item("nritoc").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("nritoc").ToString.Trim) And dtTemp.Rows(i).Item("creffw").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("creffw").ToString.Trim) And dtTemp.Rows(i).Item("norsci").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("norsci").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pGenerarReporte()
    End Sub

    Private Sub frmConsultaIngPorEmbarque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        'Int64.TryParse(objAppConfig.GetValue("ConsultaIngPorEmbarque", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click

        If fblnValidaInformacion() Then
            pReporteGuiaSalidaMercaderia()

            'pcxEspera.Visible = True
            ''pcxEspera.Left = (KryptonHea.Width / 2) - (pcxEspera.Width / 2)
            ''pcxEspera.Top = (KryptonHeaderGroup2.Height / 2) - (pcxEspera.Height / 2)
            'btnExportarExcel.Enabled = False
            'btnGenerarReporte.Enabled = False
            'bgwGifAnimado.RunWorkerAsync()
        End If
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtCliente.pCodigo = 0 Then strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        Return blnResultado
    End Function

    Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        strlTitulo.Add("Fecha  :\n" & "de " & dtpFechaInicio.Value.Date & " hasta " & dtpFechaFin.Value.Date)

        For intX As Integer = dgConsulta.ColumnCount - 1 To 1 Step -1
            If Not dgConsulta.Columns(intX).Visible Then
                dgConsulta.Columns.RemoveAt(intX)
            End If
        Next
        HelpClass.ExportExcelFormatoConga(Me.dgConsulta, Me.Text, strlTitulo)
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
End Class
