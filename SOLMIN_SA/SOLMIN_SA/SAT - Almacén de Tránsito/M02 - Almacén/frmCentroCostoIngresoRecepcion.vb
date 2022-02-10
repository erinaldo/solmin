

' Librerías del Framework  
Imports System.IO
' Librerías del Proyecto
Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.Waybill
Imports RANSA.NEGO.CargaRecepcion_CC
Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.UbicacionPlanta
Imports Ransa.Utilitario
Imports Ransa.TypeDef
Imports RANSA.NEGO

Public Class frmCentroCostoIngresoRecepcion
    Dim CargaRecepcionNeg As New Ransa.NEGO.CargaRecepcion_CC
    Dim param As New RANSA.TypeDef.beBulto

    Private Sub frmCentroCostoIngresoRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dteFechaInicial.Value = Now.AddYears(-1)
        dteFechaFinal.Value = Now
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtClient.pCargar(ClientePK)

        Call mpMostrarClienteMDI(txtClient.pCodigo)
        objAppConfig = Nothing
        UcCompania.Usuario = objSeguridadBN.pUsuario
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        CargarMedioDeEnvio()
    End Sub

#Region "Metodos"
    Private Sub CargarMedioDeEnvio()
        Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
        Dim obeMedioTransporte As New RANSA.TypeDef.beGeneral
        Dim olbeMedioTransporte As New List(Of RANSA.TypeDef.beGeneral)

        olbeMedioTransporte = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        obeMedioTransporte = New Ransa.TypeDef.beGeneral
        With obeMedioTransporte
            .PSTNMMDT = "Seleccione"
            .PNCMEDTR = 0D
        End With
        olbeMedioTransporte.Add(obeMedioTransporte)

        Me.MedioConfirmado.DataSource = olbeMedioTransporte
        Me.MedioConfirmado.DisplayMember = "PSTNMMDT"
        Me.MedioConfirmado.ValueMember = "PNCMEDTR"

        Me.MedioSugerido.DataSource = olbeMedioTransporte
        Me.MedioSugerido.DisplayMember = "PSTNMMDT"
        Me.MedioSugerido.ValueMember = "PNCMEDTR"

    End Sub
#End Region
#Region "Comun"
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = objSeguridadBN.pUsuario
        UcDivision.pActualizar()
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        UcPLanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta.Usuario = objSeguridadBN.pUsuario
        UcPLanta.pActualizar()
    End Sub


#End Region

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            param = New beBulto
            param.PSCCMPN = UcCompania.CCMPN_CodigoCompania
            param.PSCDVSN = UcDivision.Division
            param.PNCPLNDV = UcPLanta.Planta
            param.PNCCLNT = txtClient.pCodigo

            If Not Me.UcLote.objResult Is Nothing Then
                param.PSTLUGEN = Me.UcLote.objResult.PSTLUGEN
            End If
            param.PSNORCML = Me.txtOrdenDeCompra.Text.Trim

            param.FECHA_INI = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value) 'Fecha_To_Numero(dteFechaInicial.Value) '20081201 'dteFechaInicial.Text
            param.FECHA_FIN = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value) 'Fecha_To_Numero(dteFechaFinal.Value) '20101231 'dteFechaFinal.Text
            If Me.chkPendientes.Checked Then
                param.PNESTADO = 0
            Else
                param.PNESTADO = -1
            End If
            If txtClient.pCodigo <> 0 Then
                Cargar_Grilla()
            Else
                HelpClass.MsgBox("Ingrese un Cliente")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Cargar_Grilla()
        dtgCentroCostoREcepcion.AutoGenerateColumns = False
        Me.dtgCentroCostoREcepcion.DataSource = Nothing
        Me.dtgCentroCostoREcepcion.DataSource = CargaRecepcionNeg.ListarCargaRecepcion_CC(param)
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        ''--------------------------

        Dim dstTemp As New DataSet
        Dim odt As New DataTable
        'dstTemp = HelpClass.GetDataSetNative(Me.dtgCentroCostoREcepcion.DataSource)
        odt = HelpClass.GetDataSetNative(Me.dtgCentroCostoREcepcion.DataSource)
        dstTemp.Tables.Add(odt.Copy)
        For i As Integer = dstTemp.Tables(0).Columns.Count - 1 To 1 Step -1
            Select Case dstTemp.Tables(0).Columns(i).ColumnName
                Case "FechaIngAlmacenCL", "PSFechaReqAlmacen", "PSLOTE", "PSNORCML", "PSNREFCL", "PSTPRVCL", "PSCREFFW", "PSNGRPRV", "PSDESCWB", "PNQREFFW", "PNQPSOBL", "PNQVLBTO", "PSMEDSUG", "PSMEDCONF", "PSTCTCST", "PSTCTCSA", "PSTCTCSF", "PSLOTE", "PSTCTAFE"
                Case Else
                    dstTemp.Tables(0).Columns.RemoveAt(i)
            End Select
        Next

        ' For Each oDt In dtTemp.Tables
        With dstTemp.Tables(0)
            dstTemp.Tables(0).TableName = "CENTRO DE COSTO"
            .Columns("FechaIngAlmacenCL").SetOrdinal(0)
            .Columns("FechaIngAlmacenCL").ColumnName = "FECHA INGRESO"

            .Columns("PSNORCML").SetOrdinal(1)
            .Columns("PSNORCML").ColumnName = "O/C"

            .Columns("PSNREFCL").SetOrdinal(2)
            .Columns("PSNREFCL").ColumnName = "OR"

            .Columns("PSTPRVCL").SetOrdinal(3)
            .Columns("PSTPRVCL").ColumnName = "PROVEEDOR"

            .Columns("PSCREFFW").SetOrdinal(4)
            .Columns("PSCREFFW").ColumnName = "BULTO"

            .Columns("PSNGRPRV").SetOrdinal(5)
            .Columns("PSNGRPRV").ColumnName = "GUÍA DEL PROVEEDOR"

            .Columns("PSDESCWB").SetOrdinal(6)
            .Columns("PSDESCWB").ColumnName = "DESCRIPCION"

            .Columns("PNQREFFW").SetOrdinal(7)
            .Columns("PNQREFFW").DataType = GetType(Decimal)
            .Columns("PNQREFFW").ColumnName = "CANTIDAD"

            .Columns("PNQPSOBL").SetOrdinal(8)
            .Columns("PNQPSOBL").DataType = GetType(Decimal)
            .Columns("PNQPSOBL").ColumnName = "PESO"

            .Columns("PNQVLBTO").SetOrdinal(9)
            .Columns("PNQVLBTO").DataType = GetType(Decimal)
            .Columns("PNQVLBTO").ColumnName = "M3"

            .Columns("PSMEDSUG").SetOrdinal(10)
            .Columns("PSMEDSUG").ColumnName = "VIA SUGERIDA"
            .Columns("PSMEDCONF").SetOrdinal(11)
            .Columns("PSMEDCONF").ColumnName = "VIA CONFIRMADA"
            .Columns("PSFechaReqAlmacen").SetOrdinal(12)
            .Columns("PSFechaReqAlmacen").ColumnName = "Fecha Req. Alm. del Cliente"
            .Columns("PSTCTCST").SetOrdinal(13)

            .Columns("PSTCTCST").DataType = GetType(String)
            .Columns("PSTCTCST").ColumnName = "CUENTA IMPUTACIÓN TERRESTRE"

            .Columns("PSTCTCSA").SetOrdinal(14)
            .Columns("PSTCTCSA").DataType = GetType(String)
            .Columns("PSTCTCSA").ColumnName = "CUENTA IMPUTACIÓN AEREO"

            .Columns("PSTCTCSF").SetOrdinal(15)
            .Columns("PSTCTCSF").DataType = GetType(String)
            .Columns("PSTCTCSF").ColumnName = "CUENTA IMPUTACIÓN FLUVIAL"

            .Columns("PSTCTAFE").SetOrdinal(16)
            .Columns("PSTCTAFE").DataType = GetType(String)
            .Columns("PSTCTAFE").ColumnName = "CUENTA DE AFECTACIÓN(AFE)"

            .Columns("PSLOTE").SetOrdinal(17)
            .Columns("PSLOTE").ColumnName = "LOTE"
        End With
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtClient.pCodigo = 0, "TODOS", Me.txtClient.pCodigo & " - " & Me.txtClient.pRazonSocial))
        strlTitulo.Add("Planta :\n" & Me.UcPLanta.DescripcionPlanta)
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(dstTemp, strlTitulo)


    End Sub


   

    Private Function Guardar() As Boolean
        Dim objParam2 As New Ransa.TypeDef.beBulto
        Dim flag As Integer = 0
        Me.dtgCentroCostoREcepcion.EndEdit()
        For Each obebulto As beBulto In Me.dtgCentroCostoREcepcion.DataSource
            'If obebulto.PNCMEDTS <> 0 OrElse obebulto.PNCMEDTC <> 0 OrElse Not ("" & obebulto.PSTCTCST & "").Trim.Equals("") OrElse Not ("" & obebulto.PSTCTCSA & "").Trim.Equals("") OrElse Not ("" & obebulto.PSTCTCSF & "").Trim.Equals("") Then
            obebulto.PNCCLNT = Me.txtClient.pCodigo
            obebulto.PSUSUARIO = objSeguridadBN.pUsuario
            If CargaRecepcionNeg.Actualizar_Carga_Recepcionada_Centro_Costo(obebulto) = 0 Then
                HelpClass.ErrorMsgBox()
            Else
                If obebulto.PNISDIST = 0 Then
                    Dim obeOrdenCompra As New beOrdenCompra
                    With obeOrdenCompra
                        .PNCCLNT = Me.txtClient.pCodigo
                        .PSNORCML = obebulto.PSNORCML
                        .PSTCTCST = ("" & obebulto.PSTCTCST & "").Trim
                        .PSTCTCSA = ("" & obebulto.PSTCTCSA & "").Trim
                        .PSTCTAFE = ("" & obebulto.PSTCTAFE & "").Trim
                        .PSTCTCSF = ("" & obebulto.PSTCTCSF & "").Trim
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .PSNTRMNL = objSeguridadBN.pstrPCName
                        .PSTLUGEN = obebulto.PSTLUGEN
                        .PNCMEDTS = obebulto.PNCMEDTS
                        .PNFRQALC = obebulto.PNFRQALC
                    End With
                    If Not (obeOrdenCompra.PSTCTCST.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTCSA.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTAFE.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTCSF.Trim.Equals("")) Then
                        InsertarCuentaImputacion(obeOrdenCompra)
                    End If
                End If
                
            End If
        Next

        HelpClass.MsgBox("Se guardaron los registros")
        Cargar_Grilla()
        Return True
    End Function



    Private Sub UcMedioTransporte1_ActivarAyuda(ByRef objData As Object) Handles UcLote.ActivarAyuda
        'dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strData)

        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
        With obeMedioTransporte
            .PNCCLNT = txtClient.pCodigo
        End With
        objData = obrMedioTransporte.ListaLotesDeEntrega(obeMedioTransporte)
    End Sub


    Private Sub UcMedioTransporte1_CambioDeTexto1(ByVal strData As String, ByRef objData As Object) Handles UcLote.CambioDeTexto
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
            Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
            With obeMedioTransporte
                .PNCCLNT = txtClient.pCodigo
            End With
            objData = obrMedioTransporte.ListaLotesDeEntrega(obeMedioTransporte)
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Me.btnEditar.Text = "Editar"
            Me.btnEditar.Image = My.Resources.Resources.db_add
            Me.btnGuardar.Visible = False
            CambiarDeEstado()
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If Me.btnEditar.Text = "Editar" Then
            Me.btnGuardar.Visible = True
            Me.btnEditar.Text = "Cancelar"
            Me.btnEditar.Image = My.Resources.button_cancel
            CambiarDeEstado()
        Else
            Me.btnEditar.Text = "Editar"
            Me.btnEditar.Image = My.Resources.Resources.db_add
            Me.btnGuardar.Visible = False
            CambiarDeEstado()
            Cargar_Grilla()
        End If
    End Sub

    Private Sub CambiarDeEstado()
        Me.dtgCentroCostoREcepcion.Columns("MedioConfirmado").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("MedioConfirmado").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("MedioSugerido").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("MedioSugerido").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("TCTCST").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("TCTCST").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("PSTCTCSA").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("PSTCTCSA").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("PSTCTCSF").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("PSTCTCSF").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("PSTCTAFE").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("PSTCTAFE").ReadOnly
        Me.dtgCentroCostoREcepcion.Columns("PSFRQALC").ReadOnly = Not Me.dtgCentroCostoREcepcion.Columns("PSFRQALC").ReadOnly
    End Sub
    Private Sub InsertarCuentaImputacion(ByVal obeOrdenCompra As beOrdenCompra)
        Dim obrOrdenCompra As New brOrdenDeCompra
        If obrOrdenCompra.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenCompra) = 0 Then
            HelpClass.ErrorMsgBox()
        End If
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        If txtClient.pCodigo > 0 Then
            Dim frmCi As New frmImportarCI
            frmCi.nCliente = txtClient.pCodigo
            frmCi.Division = UcDivision.Division
            frmCi.Campania = UcCompania.CCMPN_CodigoCompania
            frmCi.ShowDialog()
        Else
            MessageBox.Show("Ingrese Cliente", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
       
    End Sub
End Class
