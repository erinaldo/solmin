Imports Ransa.Utilitario
Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports Ransa.NEGO
Imports Ransa.TYPEDEF.bePedidoPorPlanta
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

'Imports RANSA.DATA.slnSOLMIN_SDS.DAO.Mercaderia
'Imports RANSA.TYPEDEF

Public Class frmProcesarDespachoMasivo

    Private CCMPN As String
    Private CDVSN As String
    Private resultado As New DataTable
    Private resumen As New DataTable
    Private txtCliente As New Ransa.Controls.Cliente.ucCliente_TxtF01
    Private objMovimientoMercaderia As clsMovimientoMercaderia
    Private objNeg As New Ransa.NEGO.brDespachoMasivo

    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum

    Public Sub New(ByVal _resultado As DataTable, ByVal _Resumen As DataTable, ByVal cliente As Ransa.Controls.Cliente.ucCliente_TxtF01)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        resultado = _resultado
        resumen = _Resumen
        txtCliente = cliente

    End Sub

    Private Sub frmProcesarDespachoMasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtFechaDespacho.Value = Now.Date
            dgMercaderias.AutoGenerateColumns = False
            dgMercaderias.DataSource = resultado
            txtFechaDespacho.Value = Now
            'txtOrdenCompra.Text = "DESPACHO MASIVO"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try

            If txtFechaDespacho.Value.ToString = String.Empty Then
                MessageBox.Show("Ingrese Orden de Compra y Fecha")
                Exit Sub
            End If

            If resultado.Rows.Count > 0 Then
                ' GuardarPedido(resumen) 'resumen minimo
                DespachoMasivo(resultado) 'original sin ceros
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarPedido(ByVal Dt As DataTable)

        Dim obePedidoPlanta As New Ransa.TYPEDEF.bePedidoPorPlanta
        Dim olbePedidoPlanta As New List(Of Ransa.TYPEDEF.bePedidoPorPlanta)
        Dim obrPedidoPlanta As New brDespacho
        Dim intRow As Integer = 1

        For Each row As DataRow In Dt.Rows
            obePedidoPlanta = New Ransa.TYPEDEF.bePedidoPorPlanta
            With obePedidoPlanta
                .PNCDREGP = intRow
                .PNNORDSR = row("NORDSR") 'oDrMercaderia.Cells("NORDSR1").Value
                .PSCMRCLR = ("" & row("CMRCLR")).ToString.Trim  'oDrMercaderia.Cells("CMRCLR").Value
                .PNFCHSPE = Now.ToString("yyyyMMdd")
                .PNHRASPE = HelpClass.NowNumeric
                .PNCCLNT = txtCliente.pCodigo
                .PNCPLNCL = 0
                .PNCPRVCL = 0
                .PNCPLCLP = 0
                .PNQSRVC = row("QSLMC2") 'oDrMercaderia.Cells("QSRVC").Value
                .PSCUNCN6 = row("CUNCN5") 'oDrMercaderia.Cells("CUNCN6").Value
                .PNPSRVC = 0 'oDrMercaderia.Cells("PSRVC").Value
                .PSCUNPS6 = row("CUNPS5") 'oDrMercaderia.Cells("CUNPS6").Value
                .PSNRFTPD = String.Empty 'pobePedidoPlanta.PSNRFTPD
                .PNNDCFCC = 0 'pobePedidoPlanta.PNNDCFCC
                .PSSATSLS = "P"
                .PSSATNAL = "P"
                .PSTCTCST = String.Empty 'oDrMercaderia.Cells("TCTCST").Value
                .PSNRFRPD = String.Empty 'pobePedidoPlanta.PSNRFRPD
                .PSFLGAPR = String.Empty
                .PSFLGURG = String.Empty
                .PSSBCKRD = String.Empty
                '.PSNORCML = "DESPMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric
                .PSNORCML = "DESPACHO MASIVO"
                .PNFDSPAL = txtFechaDespacho.Value.ToString("yyyyMMdd")
                .PSTOBSMD = txtObservacion.Text.Trim ' pobePedidoPlanta.PSTOBSMD
                .PNNRITOC = intRow
                .PSNLTECL = String.Empty
                .PNNROSEQ = 0
                .PNFULTAC = Now.ToString("yyyyMMdd")
                .PNHULTAC = HelpClass.NowNumeric
                .PSCULUSA = objSeguridadBN.pUsuario
                .PNFCHCRT = Now.ToString("yyyyMMdd")
                .PNHRACRT = HelpClass.NowNumeric
                .PSCUSCRT = objSeguridadBN.pUsuario
                .PSSESTRG = "A"

                intRow = intRow + 1
            End With
            olbePedidoPlanta.Add(obePedidoPlanta)
        Next

        Dim intResultado As Double = 0
        intResultado = obrPedidoPlanta.GuardarPedidoPlanta(olbePedidoPlanta)
        If intResultado <> 0 Then
            HelpClass.MsgBox("Se ha creado el Pedido N° " & intResultado, MessageBoxIcon.Information)
            'DespachoMasivo(resultado)
        Else
            HelpClass.ErrorMsgBox()
        End If

    End Sub

    Private Sub DespachoMasivo(ByVal Dt As DataTable)

        'Dim strMensaje As String = ""
        'If objSeguridadBN.fblnIsLocked(txtCliente.pCodigo, "SOLMIN_SA", strMensaje) Then
        '    If strMensaje <> "" Then MessageBox.Show(strMensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        Dim objMovimientoMercaderia = New clsMovimientoMercaderia

        ' Obtenemos la información de la cabecera registrada
        objMovimientoMercaderia.pintAnioUnidad_NANOCM = 0
        objMovimientoMercaderia.pintCodigoCliente_CCLNT = txtCliente.pCodigo
        objMovimientoMercaderia.pintEmpresaTransporte_CTRSP = 9
        objMovimientoMercaderia.pintNroDocIdentidadChofer_NLELCH = 0
        objMovimientoMercaderia.pintNroRUCEmpTransporte_NRUCT = 0
        objMovimientoMercaderia.pintServicio_CSRVC = 2
        objMovimientoMercaderia.pstrChofer_TNMBCH = String.Empty
        objMovimientoMercaderia.pstrCompania_CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        objMovimientoMercaderia.pstrDivision_CDVSN = GLOBAL_DIVISION
        objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = String.Empty
        objMovimientoMercaderia.pstrNroBrevete_NBRVCH = String.Empty
        objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM = String.Empty
        objMovimientoMercaderia.pstrObservaciones_TOBSER = txtObservacion.Text.Trim
        objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = txtCliente.pRazonSocial
        objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = "VARIOS"
        objMovimientoMercaderia.pintFechaRealizacion_FRLZSR = Now.ToString("yyyyMMdd")

        ' Recuperamos la información ingresada en el datatable a la Lista de Clases
        Dim iCont As Integer = 0
        While iCont < Dt.Rows.Count
            Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
            With objTemp
                .pintOrdenServicio_NORDSR = Dt.Rows(iCont).Item("NORDSR")
                .pintNroContrato_NCNTR = Dt.Rows(iCont).Item("NCNTR")

                .pintNroCorrDetalleContrato_NCRCTC = Dt.Rows(iCont).Item("NCRCTC")
                .pintNroAutorizacion_NAUTR = Dt.Rows(iCont).Item("NAUTR")
                .pstrCodigoMercaderia_CMRCLR = ("" & Dt.Rows(iCont).Item("CMRCLR")).ToString.Trim
                .pstrCodigoRANSA_CMRCD = Dt.Rows(iCont).Item("CMRCD")
                .pstrNroOrdenCompraCliente_NORCCL = String.Empty
                .pstrNroGuiaCliente_NGUICL = String.Empty
                .pstrNroRUCCliente_NRUCLL = String.Empty
                .pstrTipoAlmacen_CTPALM = Dt.Rows(iCont).Item("CTPALM")
                .pstrAlmacen_CALMC = Dt.Rows(iCont).Item("CALMC")
                .pstrZonaAlmacen_CZNALM = Dt.Rows(iCont).Item("CZNALM")
                .pdecCantidad_QTRMC = Dt.Rows(iCont).Item("QSLMC2")
                .PNQTRMC = Dt.Rows(iCont).Item("QSLMC2")
                .pdecPeso_QTRMP = Dt.Rows(iCont).Item("QSLMP2")
                .PNQTRMP = Dt.Rows(iCont).Item("QSLMP2")
                .pstrUnidadCantidad_CUNCNT = Dt.Rows(iCont).Item("CUNCN5")
                .pstrUnidadPeso_CUNPST = Dt.Rows(iCont).Item("CUNPS5")
                .pstrUnidadValorTransaccion_CUNVLT = Dt.Rows(iCont).Item("CUNVL5")
                .pstrTipoMovimiento_STPING = "A"
                .pintNroDiasVigencia_QDSVGN = 0
                .pstrSatusUnidadDespacho_FUNDS2 = Dt.Rows(iCont).Item("FUNDS2")
                .pstrTipoDeposito_CTPDPS = 1
                .pstrObservaciones_TOBSRV = String.Empty
            End With
            objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
            iCont += 1
        End While
        ' Procedemos con el procesamiento de la información
        'Call pProcesarDespacho(.pCheckServicio)
        Call pProcesarDespacho(objMovimientoMercaderia)

    End Sub

    Private Sub pProcesarDespacho(ByVal objMovimientoMercaderia As clsMovimientoMercaderia)
        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intNroGuiaRansa As Int64 = 0
            Dim obrMercaderia As New brMercaderia
            Dim resultadoEnvioInterfaz As String = ""
            If mfblnDespacho_Mercaderia(resultadoEnvioInterfaz, objMovimientoMercaderia, False, intNroGuiaRansa) Then

                '============== Despacho de Ubicación
                Dim olistUbicacion As List(Of Ransa.TYPEDEF.beMercaderia)
                Dim olbeMercaderia As New List(Of Ransa.TYPEDEF.beMercaderia)
                Dim obeMercaderia As New List(Of Ransa.TYPEDEF.beMercaderia)
                Dim pstrError As String = ""
                Dim item As Ransa.TYPEDEF.beMercaderia
                Dim retorno As Integer = 0

                For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    item = New Ransa.TYPEDEF.beMercaderia
                    item.PNNORDSR = objItemMovimientoMercaderia.pintOrdenServicio_NORDSR
                    item.PSCTPALM = objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM
                    item.PSCALMC = objItemMovimientoMercaderia.pstrAlmacen_CALMC
                    olbeMercaderia.Add(item)
                Next


                For Each obeMercaUbicacion As Ransa.TYPEDEF.beMercaderia In olbeMercaderia

                    olistUbicacion = New List(Of Ransa.TYPEDEF.beMercaderia)
                    olistUbicacion = obrMercaderia.flistUbicacionesPorOSKardex(obeMercaUbicacion)

                    'Si hay error ejecuta la consulta de mercaderia ubicación
                    If olistUbicacion Is Nothing Then
                        pstrError = "Error producido al consultar la ubicación"
                        retorno = -1
                        Exit For
                    End If

                    If olistUbicacion.Count > 0 Then
                        'Proceso de despacho de ubicación
                        For Each obeUbicacion As Ransa.TYPEDEF.beMercaderia In olistUbicacion
                            obeUbicacion.PNCSRVC = 2
                            obeUbicacion.PNNGUIRN = intNroGuiaRansa
                            If obrMercaderia.fintInsertarPosicionMercaderia(obeUbicacion) = -1 Then
                                pstrError = "Error al despachar la ubicación"
                                retorno = -1
                                Exit For
                            End If
                        Next

                    End If
                    obeMercaUbicacion.Ubicacion = olistUbicacion
                Next
                '============== Despacho de Ubicación
                If retorno = -1 Then
                    MessageBox.Show(pstrError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim objFiltro As New Reportes.clsFiltros_ReporteGuiaDespacho
                    With objFiltro
                        .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                        .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                        .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                    End With
                    pVisualizarGuiaRansa(objFiltro)

                    Dim HasVisitado As New Hashtable
                    For Each obeMercaUbicacion As Ransa.TYPEDEF.beMercaderia In olbeMercaderia
                        If Not HasVisitado.Contains(obeMercaUbicacion.PNNORDSR) Then
                            HasVisitado.Add(obeMercaUbicacion.PNNORDSR, obeMercaUbicacion.PNNORDSR)
                            objNeg.ActualizarRelacionadoOS(obeMercaUbicacion.PNNORDSR)
                        End If
                    Next

                End If


            End If

        End If
    End Sub

    Private Sub pVisualizarGuiaRansa(ByVal pobjFiltro As Reportes.clsFiltros_ReporteGuiaDespacho)
        Dim objFiltro As New Ransa.TYPEDEF.beDespacho
        Dim objDespacho As New Ransa.NEGO.brDespacho

        With objFiltro
            .PNCCLNT = pobjFiltro.pintCodigoCliente_CCLNT
            .PNNGUIRN = pobjFiltro.pintNroGuiaRansa_NGUIRN
        End With
        Dim dtResultado As DataTable = Nothing
        dtResultado = objDespacho.fdtReporteGuiaRansa(objFiltro)
        dtResultado.TableName = "dtInformacionGuiaDespacho"
        If dtResultado.Rows.Count > 0 Then
            Dim rdocGuiaRemision As New Ransa.NEGO.rptGuiaDespacho
            rdocGuiaRemision.SetDataSource(dtResultado)
            rdocGuiaRemision.Refresh()
            rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.PNCCLNT)
            rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", pobjFiltro.pstrRazonSocialEmpresa)
            rdocGuiaRemision.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.PNNGUIRN)
            rdocGuiaRemision.SetParameterValue("pEmpresa", GLOBAL_EMRESA)
            rdocGuiaRemision.SetParameterValue("pProceso", objFiltro.PSCTPOAT)
            With frmVisorRPT
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill
                .pReportDocument = rdocGuiaRemision
                .ShowDialog()
            End With
        End If
    End Sub

End Class
