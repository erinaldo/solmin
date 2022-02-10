Imports SOLMIN_ST.NEGOCIO.Consultas
Imports SOLMIN_ST.ENTIDADES.Consultas
Imports SOLMIN_ST.NEGOCIO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmIndicadoresTransporte
    Private strPlanta As String
    Private objPlanta As New NEGOCIO.Planta_BLL

#Region "Carga de Datos"
  Private Sub Cargar_Compania()
    Try
      cmbCompania.Usuario = MainModule.USUARIO
            'cmbCompania.CCMPN_CompaniaDefault = "EZ"
            cmbCompania.pActualizar()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    Catch ex As Exception
    End Try
  End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        cmbDivision.Usuario = MainModule.USUARIO
        cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
        cmbDivision.DivisionDefault = "T"
        cmbDivision.pActualizar()
        Me.CargarTransportista()
        If cmbCompania.CCMPN_ANTERIOR <> obeCompania.CCMPN_CodigoCompania Then
            ControlVisorCliente.ReportViewer.ReportSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = obeCompania.CCMPN_CodigoCompania
        End If
    End Sub
    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        cmbPlanta.Usuario = MainModule.USUARIO
        cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        cmbPlanta.PlantaDefault = 1
        ' cmbPlanta.pActualizar()
        Cargar_Planta()
    End Sub
    Private Sub CargarTransportista()
        cboTransportista.pClear()
        Me.cboTracto.pClear()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        cboTransportista.pCargar(obeTransportista)
    End Sub
  Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged, cboTransportista.ExitFocusWithOutData
    Me.cboTracto.pClear()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    obeTracto.pCDVSN_Division = cmbDivision.Division
    obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
    obeTracto.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    cboTracto.pCargar(obeTracto)
  End Sub

  Private Sub frmIndicadoresTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Cargar_Compania()
    Me.Carga_MedioTransporte()
    ndAnio.Minimum = 0
    ndAnio.Maximum = HelpClass.TodayAnio
    ndAnio.Value = HelpClass.TodayAnio
        MostrarMeses_x_Anio()
        
        ' Me.Cargar_Planta()
  End Sub

  Private Sub Carga_MedioTransporte()
    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    Me.cboMedioTransporte.DataSource = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
    Me.cboMedioTransporte.ValueMember = "CMEDTR"
    Me.cboMedioTransporte.DisplayMember = "TNMMDT"
   
  End Sub

  Private Sub MostrarMeses_x_Anio()

    Dim odtMeses As New DataTable
    odtMeses.Columns.Add("key")
    odtMeses.Columns.Add("value")

    odtMeses.Rows.Add(New Object() {"01", "Enero"})
    odtMeses.Rows.Add(New Object() {"02", "Febrero"})
    odtMeses.Rows.Add(New Object() {"03", "Marzo"})
    odtMeses.Rows.Add(New Object() {"04", "Abril"})
    odtMeses.Rows.Add(New Object() {"05", "Mayo"})
    odtMeses.Rows.Add(New Object() {"06", "Junio"})
    odtMeses.Rows.Add(New Object() {"07", "Julio"})
    odtMeses.Rows.Add(New Object() {"08", "Agosto"})
    odtMeses.Rows.Add(New Object() {"09", "Setiembre"})
    odtMeses.Rows.Add(New Object() {"10", "Octubre"})
    odtMeses.Rows.Add(New Object() {"11", "Noviembre"})
    odtMeses.Rows.Add(New Object() {"12", "Diciembre"})

    dbMes.DataSource = odtMeses
    dbMes.ValueMember = "key"
    dbMes.DisplayMember = "value"
    dbMes.SelectedIndex = 0
  End Sub

    Private Sub Cargar_Planta()

        chkcbxPlanta.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try

            If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then

                objPlanta.Crea_Lista()
                '
                objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                chkcbxPlanta.DisplayMember = "TPLNTA"
                chkcbxPlanta.ValueMember = "CPLNDV"
                Me.chkcbxPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                    If chkcbxPlanta.Items.Item(i).Value = "1" Then
                        chkcbxPlanta.SetItemChecked(i, True)
                    End If
                Next

                If chkcbxPlanta.Text = "" Then
                    chkcbxPlanta.SetItemChecked(0, True)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

  Private Function ObtenerFiltroIndicador() As Hashtable
    Dim FEC As DateTime = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes.SelectedValue.ToString() + "/01")
    Dim NDS As Integer = DateTime.DaysInMonth(FEC.Year, FEC.Month)
    Dim FECINI As String = Me.ndAnio.Value.ToString() + "" + Me.dbMes.SelectedValue.ToString() + "01"
    Dim FECFIN As String = Me.ndAnio.Value.ToString() + "" + Me.dbMes.SelectedValue.ToString() + "" + NDS.ToString()
    Dim objParametro As New Hashtable
    objParametro.Add("PSCCMPN", Me.cmbCompania.CCMPN_CodigoCompania)
    objParametro.Add("PSCDVSN", Me.cmbDivision.Division)
        Dim strCodPlanta As String = ""
       
        'For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1
        '    strCodPlanta += chkcbxPlanta.CheckedItems(i).Value & ","
        'Next
        'If strCodPlanta = "" Then
        '    For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
        '        strCodPlanta += chkcbxPlanta.Items(i).Value & ","
        '    Next
        'End If



        strCodPlanta = ""
        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strCodPlanta = String.Concat(strCodPlanta, ",")
            End If

        Next

        'If strCodPlanta = "" Then
        '    'objcoleccion.Add("")
        '    HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
        '    Me.Cursor = Cursors.Default
        '    ControlVisorCliente.Ocultar_Imagen()
        '    Exit Function




        'End If


        'If strCodPlanta.Trim.Length > 0 Then
        '    strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        'End If
        objParametro.Add("PNCPLNDV", strCodPlanta)
        '   objParametro.Add("PNCPLNDV", strPlanta)
    objParametro.Add("PNFECINI", FECINI)
    objParametro.Add("PNFECFIN", FECFIN)
    objParametro.Add("PNCCLNT", Me.txtCliente.pCodigo)
    objParametro.Add("PNCTRMNC", Me.cboTransportista.pCodigoRNS)
    objParametro.Add("PSNPLCUN", Me.cboTracto.pNroPlacaUnidad)
    objParametro.Add("PNCMEDTR", Me.cboMedioTransporte.SelectedValue)

    objParametro.Add("PNESTADO", 0)
    If Me.cboTransportista.pRucTransportista <> "" Then
      objParametro("PNESTADO") = 1
    End If
    If Me.cboTransportista.pRucTransportista <> "" And Me.cboTracto.pNroPlacaUnidad <> "" Then
      objParametro("PNESTADO") = 2
    End If
    If Me.txtCliente.pCodigo <> 0 Then
      objParametro("PNESTADO") = 3
    End If
    If Me.txtCliente.pCodigo <> 0 And Me.cboTransportista.pRucTransportista <> "" Then
      objParametro("PNESTADO") = 4
    End If
    If Me.txtCliente.pCodigo <> 0 And Me.cboTransportista.pRucTransportista <> "" And Me.cboTracto.pNroPlacaUnidad <> "" Then
      objParametro("PNESTADO") = 5
    End If

    Return objParametro
  End Function

  Private Sub fnProcesarReporte()
    Dim FEC As DateTime = Convert.ToDateTime(Me.ndAnio.Value.ToString() + "/" + Me.dbMes.SelectedValue.ToString() + "/01")
    Dim orptIndicadoresTransporte As New rptIndicadoresTransporte


    Dim odsRPT As DataSet = New Indicadores_BLL().Indicador_Operativo(ObtenerFiltroIndicador, FEC)

    orptIndicadoresTransporte.SetDataSource(odsRPT)

    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = USUARIO
    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblTituloMes"), TextObject).Text = "DEL MES DE " & dbMes.Text.ToUpper()
    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblMesDiaCuadro1"), TextObject).Text = dbMes.Text.ToUpper()
    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblMesDiaCuadro2"), TextObject).Text = dbMes.Text.ToUpper()
    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblMesDiaCuadro3"), TextObject).Text = dbMes.Text.ToUpper()
    CType(orptIndicadoresTransporte.ReportDefinition.ReportObjects("lblMesDiaCuadro4"), TextObject).Text = dbMes.Text.ToUpper()

    orptIndicadoresTransporte.Subreports.Item("rptKilometrosPorDiaBarras").SetDataSource(odsRPT.Tables("dtKilometrosPorDiaBarras"))
    orptIndicadoresTransporte.Subreports.Item("rptKilometrosPorTipoPie").SetDataSource(odsRPT.Tables("dtKilometrosPorTipoPie"))

    orptIndicadoresTransporte.Subreports.Item("rptPesosPorDiaBarras").SetDataSource(odsRPT.Tables("dtPesosPorDiaBarras"))
    orptIndicadoresTransporte.Subreports.Item("rptPesosPorTipoPie").SetDataSource(odsRPT.Tables("dtPesosPorTipoPie"))

    orptIndicadoresTransporte.Subreports.Item("rptViajesPorDiaBarras").SetDataSource(odsRPT.Tables("dtViajesPorDiaBarras"))
    orptIndicadoresTransporte.Subreports.Item("rptViajesPorTipoPie").SetDataSource(odsRPT.Tables("dtViajesPorTipoPie"))

    orptIndicadoresTransporte.Subreports.Item("rptCantidadesPorDiaBarras").SetDataSource(odsRPT.Tables("dtCantidadesPorDiaBarras"))
    orptIndicadoresTransporte.Subreports.Item("rptCantidadesPorTipoPie").SetDataSource(odsRPT.Tables("dtCantidadesPorTipoPie"))

    orptIndicadoresTransporte.Subreports.Item("rptRutasKilometros").SetDataSource(odsRPT.Tables("dtRutasKilometros"))
    orptIndicadoresTransporte.Subreports.Item("rptRutasPesos").SetDataSource(odsRPT.Tables("dtRutasPesos"))
    orptIndicadoresTransporte.Subreports.Item("rptRutasViajes").SetDataSource(odsRPT.Tables("dtRutasViajes"))
    orptIndicadoresTransporte.Subreports.Item("rptRutasCantidades").SetDataSource(odsRPT.Tables("dtRutasCantidades"))

        ' Me.ControlVisorCliente.Muestra_Imagen()
        Me.ControlVisorCliente.ReportViewer.ReportSource = orptIndicadoresTransporte
        Me.ControlVisorCliente.Ocultar_Imagen()

  End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        'se agrego esta condicion 23/03/2012 
        Me.ControlVisorCliente.ReportViewer.ReportSource = Nothing
        If VerificarSiNoEligePlanta() = True Then


            Me.fnProcesarReporte()
        End If




    End Sub

   
    'se creo esta funcion 23/03/2012
    Private Function VerificarSiNoEligePlanta() As Boolean
        Dim vretorno As Boolean = False

        Dim strCodPlanta As String = ""



        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strCodPlanta = String.Concat(strCodPlanta, ",")
            End If

        Next

        If strCodPlanta = "" Then
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
            ControlVisorCliente.Ocultar_Imagen()
            vretorno = False
        Else
            vretorno = True

        End If
        Return vretorno

    End Function

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub
End Class

