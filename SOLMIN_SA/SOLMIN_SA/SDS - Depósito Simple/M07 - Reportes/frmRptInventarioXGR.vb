
Imports RANSA.TypeDef.OrdenCompra
Imports Ransa.TypeDef.Cliente
 
Imports RANSA.TypeDef.Reportes
Imports RANSA.TypeDef
Imports RANSA.TypeDef.ItemGR
Imports Ransa.TypeDef.GuiaRemision
 
Imports RANSA.Utilitario
Imports Ransa.DATA



Public Class frmRptInventarioXGR
  
    Private TD_Filtro As TD_QRY_GuiaRemision_L01 = New RANSA.TypeDef.GuiaRemision.TD_QRY_GuiaRemision_L01
    Private TD_GR_Actual As TD_GuiaRemisionPK = New RANSA.TypeDef.GuiaRemision.TD_GuiaRemisionPK
   
    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcPLanta_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmRptInventarioXGR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Compania()
            dgReporteGR.AutoGenerateColumns = False
            Dim intTemp As Int64 = 0
            Dim objAppConfig As cAppConfig = New cAppConfig
            Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)

            objAppConfig = Nothing
            chkfecha.Checked = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
 
 

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Dim objAppConfig As cAppConfig = New cAppConfig
       

        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If chkfecha.Checked = False Then
            If Val(txtGuiaRemision.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese Guía Remisión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If



        'Dim dt As New DataTable
        Dim oFILTRO As New TD_QRY_GuiaRemision_L01
        oFILTRO.PNCCLNT = txtCliente.pCodigo
        oFILTRO.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        oFILTRO.PSCDVSN = UcDivision_Cmb011.Division
        oFILTRO.PNCPLNDV = UcPLanta_Cmb011.Planta
        oFILTRO.NGUIRM = Val(txtGuiaRemision.Text.Trim)
        'oFILTRO.GUIASALIDA = Val(txtGuiaSalida.Text.Trim)
        If chkfecha.Checked = True Then
            oFILTRO.pFGUIRM_FechaGR_Inicio = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date)
            oFILTRO.pFGUIRM_FechaGR_Fin = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date)
        Else
            oFILTRO.pFGUIRM_FechaGR_Inicio = 0
            oFILTRO.pFGUIRM_FechaGR_Fin = 0
        End If
       
      
        Dim dtTemp As New DataTable
        dtTemp = cGuiaRemision.fdtListar_Reporte_Por_GR(oFILTRO)
        dgReporteGR.DataSource = dtTemp
        



        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RecepcionGR_CodigoCliente", txtCliente.pCodigo)
        objAppConfig.SetValue("RecepcionGR_DetalleCliente", txtCliente.pRazonSocial)
        objAppConfig = Nothing

 

    End Sub


     

    
 

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click


        Try
             
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
           
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado Guías"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Listado Guías"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Listado Guías"))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.dgReporteGR.DataSource, DataTable).Copy


    
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgReporteGR, objDt))

            
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
   
    
    

    Private Sub chkfecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkfecha.CheckedChanged
        If chkfecha.Checked Then
            GrpBoxFechas.Enabled = True
            lblFechaFinal.Enabled = True
            lblFechaInicial.Enabled = True
            dteFechaFinal.Enabled = True
            dteFechaInicial.Enabled = True
        Else
            GrpBoxFechas.Enabled = False
            lblFechaFinal.Enabled = False
            lblFechaInicial.Enabled = False
            dteFechaFinal.Enabled = False
            dteFechaInicial.Enabled = False
        End If
    End Sub


End Class