Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario
Imports System.Xml


Public Class frmGuiaTransporteEnvioInt

#Region "Variable"
    Private oDtBultos As New DataTable
    Private oDtItems As New DataTable

#End Region

#Region "Propiedades"

    Private _PNCTRMNC As Decimal
    Public Property PNCTRMNC() As Decimal
        Get
            Return _PNCTRMNC
        End Get
        Set(ByVal value As Decimal)
            _PNCTRMNC = value
        End Set
    End Property

    Private _PNNGUITR As Decimal
    Public Property PNNGUITR() As Decimal
        Get
            Return _PNNGUITR
        End Get
        Set(ByVal value As Decimal)
            _PNNGUITR = value
        End Set
    End Property


    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    'Private _MENSAJE_RESP As String = ""
    'Public Property MENSAJE_RESP() As String
    '    Get
    '        Return _MENSAJE_RESP
    '    End Get
    '    Set(ByVal value As String)
    '        _MENSAJE_RESP = value
    '    End Set
    'End Property

#End Region
 
#Region "Delegados"

    Private Sub frmGuiaTransporteEnvioInt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_UnidadMPO()
            CargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try

            If MessageBox.Show("Está seguro de Enviar la información.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim Validacion As String = ValidarGuiasBultos()
            If Validacion.Length > 0 Then
                MessageBox.Show(Validacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim msgError As String = ""


            Dim CantidadBulto As Decimal = 0
            Dim PesoBulto As Decimal = 0
            Dim numBulto As String = ""
            Dim CodMaterial As String = ""
            Dim PedidoTraslado As String = ""
            Dim PosItemPedTraslado As String = ""
            Dim CentroOrigen As String = ""
            Dim CentroDestino As String = ""
            Dim AlmacenDestino As String = ""
            Dim CantidadItemAtencion As Decimal = 0
            Dim AlmacenOrigen As String = String.Empty 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)

            Dim ListBltoSinPeso As String = ""
            Dim ListBltoSinCodMaterial As String = ""
            Dim ListBltoSinPedTraslado As String = ""
            Dim LisBltoSinCentroOr As String = ""
            Dim ListBltoSinCentroDest As String = ""
            Dim ListBltoSinAlmDest As String = ""
            Dim ListSinQatendido As String = ""
            Dim ListBltoSinAlmOrigen As String = String.Empty 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)

            Dim ListVisitBltoSinPeso As New Hashtable
            Dim ListVisitBltoSinCodMaterial As New Hashtable
            Dim ListVisitBltoSinPedTraslado As New Hashtable
            Dim LisVisitBltoSinCentroOr As New Hashtable
            Dim ListVisitBltoSinCentroDest As New Hashtable
            Dim ListVisitBltoSinAlmDest As New Hashtable
            Dim ListVisitSinQatendido As New Hashtable

            Dim ListVisitBltoSinAlmOrigen As New Hashtable 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)

            If ucResponsable.Resultado Is Nothing Then
                MessageBox.Show("Seleccione Unidad(MPO)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            For i As Integer = 0 To oDtItems.Rows.Count - 1

                numBulto = ("" & oDtItems.Rows.Item(i)("CREFFW")).ToString.Trim
                CantidadBulto = Val("" & oDtItems.Rows.Item(i)("QCANTBULTO"))
                PesoBulto = Val("" & oDtItems.Rows.Item(i)("PSOBULTO"))
                CodMaterial = ("" & oDtItems.Rows.Item(i)("CODMAT")).ToString.Trim
                PedidoTraslado = ("" & oDtItems.Rows.Item(i)("NORCMC")).ToString.Trim
                PosItemPedTraslado = ("" & oDtItems.Rows.Item(i)("NRITOC")).ToString.Trim
                CentroOrigen = ("" & oDtItems.Rows.Item(i)("CENTRO_OR")).ToString.Trim
                CentroDestino = ("" & oDtItems.Rows.Item(i)("CENTRO_DEST")).ToString.Trim
                AlmacenDestino = ("" & oDtItems.Rows.Item(i)("ALM_DEST")).ToString.Trim
                CantidadItemAtencion = Val(("" & oDtItems.Rows.Item(i)("QCNTIT")).ToString.Trim)
                AlmacenOrigen = ("" & oDtItems.Rows.Item(i)("ALM_OR")).ToString.Trim 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)
                If CantidadBulto = 0 OrElse PesoBulto = 0 Then

                    If Not ListVisitBltoSinPeso.Contains(numBulto) Then
                        ListVisitBltoSinPeso(numBulto) = numBulto
                        ListBltoSinPeso = ListBltoSinPeso & numBulto & ","
                    End If

                End If

                If PedidoTraslado = "0" Or PosItemPedTraslado = "0" Or String.IsNullOrEmpty(PedidoTraslado.Trim) Or String.IsNullOrEmpty(PosItemPedTraslado.Trim) Then
                    If Not ListVisitBltoSinPedTraslado.Contains(numBulto) Then
                        ListVisitBltoSinPedTraslado(numBulto) = numBulto
                        ListBltoSinPedTraslado = ListBltoSinPedTraslado & numBulto & " ,"
                    End If

                Else

                    If CodMaterial = "" Then
                        If Not ListVisitBltoSinCodMaterial.Contains(numBulto) Then
                            ListVisitBltoSinCodMaterial(numBulto) = numBulto
                            ListBltoSinCodMaterial = ListBltoSinCodMaterial & numBulto & " ,"
                        End If

                    End If

                    If CentroOrigen = "" Then
                        If Not LisVisitBltoSinCentroOr.Contains(numBulto) Then
                            LisVisitBltoSinCentroOr(numBulto) = numBulto
                            LisBltoSinCentroOr = LisBltoSinCentroOr & numBulto & ","
                        End If
                    End If

                    If CentroDestino = "" Then
                        If Not ListVisitBltoSinCentroDest.Contains(numBulto) Then
                            ListVisitBltoSinCentroDest(numBulto) = numBulto
                            ListBltoSinCentroDest = ListBltoSinCentroDest & numBulto & " ,"
                        End If

                    End If

                    If AlmacenDestino = "" Then
                        If Not ListVisitBltoSinAlmDest.Contains(numBulto) Then
                            ListVisitBltoSinAlmDest(numBulto) = numBulto
                            ListBltoSinAlmDest = ListBltoSinAlmDest & numBulto & " ,"
                        End If

                    End If
                    'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)-INICIO
                    If AlmacenOrigen = "" Then
                        If Not ListVisitBltoSinAlmOrigen.Contains(numBulto) Then
                            ListVisitBltoSinAlmOrigen(numBulto) = numBulto
                            ListBltoSinAlmOrigen = ListBltoSinAlmOrigen & numBulto & " ,"
                        End If
                    End If
                    'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)-FIN

                    If CantidadItemAtencion = 0 Then
                        If Not ListVisitSinQatendido.Contains(numBulto) Then
                            ListVisitSinQatendido(numBulto) = numBulto
                            ListSinQatendido = ListSinQatendido & numBulto & ","
                        End If

                    End If

                End If

            Next

            If ListBltoSinPedTraslado.Length > 0 Then
                MessageBox.Show("Bultos/item debe estar asociados a un Pedido Traslado:" & Chr(13) & ListBltoSinPedTraslado, "Aviso", MessageBoxButtons.OK)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If


            Dim msgGen As String = ""

            If ListBltoSinPeso.Length > 0 Then msgGen = "Cantidad/Peso de Bulto con valor 0: " & ListBltoSinPeso
            If ListBltoSinCodMaterial.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin Código Material(Bulto/item): " & ListBltoSinCodMaterial
            If LisBltoSinCentroOr.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin Centro origen(Bulto/item): " & LisBltoSinCentroOr
            If ListBltoSinAlmOrigen.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin Almacén origen(Bulto/item): " & ListBltoSinAlmOrigen 'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)

            If ListBltoSinCentroDest.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin Centro destino(Bulto/item): " & ListBltoSinCentroDest
            If ListBltoSinAlmDest.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin almacén destino(Bulto/item): " & ListBltoSinAlmDest
            If ListSinQatendido.Length > 0 Then msgGen = msgGen & Chr(13) & "Sin cantidad(Bulto/item): " & ListSinQatendido
            'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)-INICIO
            'If msgGen.Length > 0 Then
            '    If MessageBox.Show("Los siguientes inconvenientes podrían afectar el envío del Despacho:" & Chr(13) & msgGen & Environment.NewLine & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            '        Me.Cursor = Cursors.Default
            '        Exit Sub
            '    End If
            'End If
            If msgGen.Length > 0 Then
                MessageBox.Show("Los siguientes inconvenientes podrían afectar el envío del Despacho:" & Chr(13) & msgGen & Environment.NewLine, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            'ECM-HUNDRED-DEF-SOLICITUD-DE-CAMBIO-(RF-002)-FIN

            '----------------------------------------SW----------------------------------------
            'VARIABLES DE ENVIO Y RESPUESTA DEL SERVICIO
            Dim objServicio As New Milpo.Despacho.SI_EnvioDespachos_Ransa_OutService
            Dim objRequest() As Milpo.Despacho.DT_RespuestaEnvioDespachosReturn


            'VARIABLES DEL CUERPO DEL SERVICIO
            Dim objEnvioDespachos As New Milpo.Despacho.DT_EnvioDespachos

            Dim objListaCABECERA_GR(dgwGuiaRemision.Rows.Count - 1) As Milpo.Despacho.DT_CabGRITEMS_CABGR
            Dim objListaCABECERA_BULTO(oDtBultos.Rows.Count - 1) As Milpo.Despacho.DT_CabBultoITEMS_CABBULTO
            Dim objListaItems(oDtItems.Rows.Count - 1) As Milpo.Despacho.DT_ItemsITEMS

            'CABECERA-------------------------------------------------
            objEnvioDespachos.NUMTRA = txtGuiaTransporte.Text.Trim 'Numero Transporte 
            objEnvioDespachos.FECTRA = HelpClass.CFecha_a_Numero8Digitos(txtFechaGuia.Text.Trim) 'Fecha Transporte
            objEnvioDespachos.RUC_TRANSPORTE = txtRucTransportista.Text.Trim 'RUC/DNI Empresa de Transporte
            objEnvioDespachos.PLACA_VEHICULO = txtPlacaTracto.Text.Trim 'Placa de Vehículo
            objEnvioDespachos.COD_BREVETE = txtBreveteConductor.Text.Trim 'código del Brevete
            objEnvioDespachos.NOM_CONDUCTOR = txtNombreConductor.Text.Trim  'Nombre del Conductor
            objEnvioDespachos.TXT_ORG = txtOrigen.Text.Trim 'Texto Origen Transporte 
            objEnvioDespachos.TXT_DES = txtDestino.Text.Trim 'Texto Destino Transporte 
            objEnvioDespachos.EMATN = CType(ucResponsable.Resultado, TipoDatoGeneral).DESC_TIPO.ToString.Trim
            objEnvioDespachos.TRACTO = txtPlacaAcoplado.Text.Trim 'Tipo de vehículo

            '--------------------------------------------------------

            For i As Integer = 0 To dgwGuiaRemision.Rows.Count - 1
                objListaCABECERA_GR(i) = New Milpo.Despacho.DT_CabGRITEMS_CABGR
                objListaCABECERA_GR(i).NUMGRM = ("" & dgwGuiaRemision.Rows(i).Cells("NRGUCL").Value).ToString.Trim  'Documento referencia
                objListaCABECERA_GR(i).FECGRM = ("" & dgwGuiaRemision.Rows(i).Cells("FCGUCL").Value).ToString.Trim  'Fecha documento
                objListaCABECERA_GR(i).MOT_TRASLADO = ("" & dgwGuiaRemision.Rows(i).Cells("COD_MOTIVO").Value).ToString.Trim 'Motivo de Traslado Guia
                objListaCABECERA_GR(i).TXT_CAB_GUIA = ("" & dgwGuiaRemision.Rows(i).Cells("REF_GUIA").Value).ToString.Trim  'Texto cabecera Guia
            Next

            For i As Integer = 0 To oDtBultos.Rows.Count - 1
                objListaCABECERA_BULTO(i) = New Milpo.Despacho.DT_CabBultoITEMS_CABBULTO
                objListaCABECERA_BULTO(i).NUMGRM = ("" & oDtBultos.Rows.Item(i)("NRGUCL")).ToString.Trim 'Numero Guia Remisison
                objListaCABECERA_BULTO(i).NUMBTO = ("" & oDtBultos.Rows.Item(i)("CREFFW")).ToString.Trim 'Numero Bulto
                objListaCABECERA_BULTO(i).FECBTO = ("" & oDtBultos.Rows.Item(i)("FBULTO")).ToString.Trim 'Fecha documento
                objListaCABECERA_BULTO(i).CANBTOSpecified = True
                objListaCABECERA_BULTO(i).CANBTO = Val("" & oDtBultos.Rows.Item(i)("QCANTBULTO"))
                objListaCABECERA_BULTO(i).TIPBTO = ("" & oDtBultos.Rows.Item(i)("TIPBULTO")).ToString.Trim 'Tipo Bulto
                objListaCABECERA_BULTO(i).PSOBTOSpecified = True
                objListaCABECERA_BULTO(i).PSOBTO = Val("" & oDtBultos.Rows.Item(i)("PSOBULTO"))  'Peso a 3 decimales
                objListaCABECERA_BULTO(i).TIND = ("" & oDtBultos.Rows.Item(i)("CLS_DOC")).ToString.Trim 'Ind. Clase doc.(OC, PT, ES, ER, EM)
            Next

            For i As Integer = 0 To oDtItems.Rows.Count - 1
                objListaItems(i) = New Milpo.Despacho.DT_ItemsITEMS
                objListaItems(i).NUMGRM = ("" & oDtItems.Rows.Item(i)("NRGUCL")).ToString.Trim
                objListaItems(i).NUMBTO = ("" & oDtItems.Rows.Item(i)("CREFFW")).ToString.Trim 'número Bulto
                objListaItems(i).OC = ("" & oDtItems.Rows.Item(i)("NORCMC")).ToString.Trim 'número Orden de compra
                objListaItems(i).OC_POS = ("" & oDtItems.Rows.Item(i)("NRITOC")).ToString.Trim.PadLeft(5, "0") 'número Orden de compra posición
                objListaItems(i).MATERIAL = ("" & oDtItems.Rows.Item(i)("CODMAT")).ToString.Trim.PadLeft(18, "0") 'código de material
                objListaItems(i).CENTRO_ORIG = ("" & oDtItems.Rows.Item(i)("CENTRO_OR")).ToString.Trim 'código Centro Logístico Origen
                objListaItems(i).ALMACEN_ORIG = ("" & oDtItems.Rows.Item(i)("ALM_OR")).ToString.Trim 'código Almancen Origen
                objListaItems(i).CENTRO_DEST = ("" & oDtItems.Rows.Item(i)("CENTRO_DEST")).ToString.Trim 'código Centro Logístico Destino
                objListaItems(i).ALMACEN_DEST = ("" & oDtItems.Rows.Item(i)("ALM_DEST")).ToString.Trim 'código Almancen Destino
                objListaItems(i).CANTIDADSpecified = True
                objListaItems(i).CANTIDAD = Val("" & oDtItems.Rows.Item(i)("QCNTIT"))  'cantidad a 3 decimales
                objListaItems(i).UMEDIDA = ("" & oDtItems.Rows.Item(i)("TUNDIT")).ToString.Trim 'unidad de medida
                objListaItems(i).TXT_DET_GUIA = ("" & oDtItems.Rows.Item(i)("REF_ITEM")).ToString.Trim 'Texto detalle Guia
            Next

            objEnvioDespachos.CABECERA_GR = objListaCABECERA_GR
            objEnvioDespachos.CABECERA_BULTO = objListaCABECERA_BULTO
            objEnvioDespachos.ITEM = objListaItems

            Dim rtaMilpo As New RutaMilpo
            objServicio.Credentials = New Net.NetworkCredential(rtaMilpo.Usuario, rtaMilpo.Clave)
            objRequest = objServicio.SI_EnvioDespachos_Ransa_Out(objEnvioDespachos)

            Dim ht As New Hashtable
            Dim Respuesta As Integer = objRequest.Length - 1

            If Respuesta >= 0 Then

                Dim ResultError As String = ""
                Dim StatusEnvio As String = ""
                Dim ResultError2 As String = ""
                Dim MsgStatus As String = ""
                Dim MsgStatus2 As String = ""

                Dim MesajeMostrar As String = ""

                Dim TipoError As String = ""

                For i As Integer = 0 To Respuesta
                    Dim MsjError As String = ("" & objRequest(i).DOCNUM) & " " & ("" & objRequest(i).MESSAGE).Trim
                    TipoError = ("" & objRequest(i).TYPE).Trim
                    If TipoError.Equals("E") Or TipoError.Equals("A") Then
                        MsjError = TipoError & " Num Err:" & ("" & objRequest(i).NUMBER).Trim & " Msg:" & MsjError

                        If Not ht.Contains(MsjError.Trim) Then
                            ht.Add(MsjError.Trim, "")  '(Key , Valor)
                            If (MsgStatus & Environment.NewLine & MsjError).Trim.Length <= 250 Then
                                MsgStatus = IIf(MsgStatus = "", MsjError, MsgStatus & Environment.NewLine & MsjError)
                            Else
                                If (MsgStatus2 & Environment.NewLine & MsjError).Trim.Length <= 200 Then
                                    MsgStatus2 = IIf(MsgStatus2 = "", MsjError, MsgStatus2 & Environment.NewLine & MsjError)
                                End If
                            End If
                            MesajeMostrar = MesajeMostrar & Environment.NewLine() & MsjError

                        End If

                    End If
                Next

                'W I =S
                If MsgStatus.Length > 0 Then
                    If MsgStatus.Length >= 250 Then
                        MsgStatus = MsgStatus.Substring(0, 250)
                    End If
                    If MsgStatus2.Length >= 200 Then
                        MsgStatus2 = MsgStatus2.Substring(0, 200)
                    End If
                    StatusEnvio = "E"
                Else
                    StatusEnvio = "S"
                End If



                ' GRABAR RESPUESTA SW_MILPO
                Dim Objeto_Logica As New GuiaTransportista_BLL
                Dim objetoParametro As New Hashtable
                Dim Lista As New List(Of GuiaTransportista)
                objetoParametro.Add("PNCTRMNC", PNCTRMNC)
                objetoParametro.Add("PNNGUITR", PNNGUITR)
                objetoParametro.Add("PSCCMPN", CCMPN)
                objetoParametro.Add("PSFSTENV", StatusEnvio)
                objetoParametro.Add("PSMSTENV", MsgStatus)
                objetoParametro.Add("PSMSTEN2", MsgStatus2)
                objetoParametro.Add("PSUSUENV", MainModule.USUARIO)
                objetoParametro.Add("PSUNIREL", CType(ucResponsable.Resultado, TipoDatoGeneral).CODIGO_TIPO.ToString.Trim)
                Objeto_Logica.RegistraEnvioRespuestaSwMilpo(objetoParametro)

                If StatusEnvio = "E" Then
                    MessageBox.Show("Error al enviar Guía Transporte " & Environment.NewLine() & MesajeMostrar.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Cursor = Cursors.Default
                End If
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
 
    Private Sub cmbNrGuiaBulto_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNrGuiaBulto.SelectionChangeCommitted
        Try
            If cmbNrGuiaBulto.Items.Count > 0 Then
                Dim Bultos As New DataTable
                Dim dtBultosFinal As New DataTable
                Bultos = oDtBultos.Copy
                dtBultosFinal = oDtBultos.Copy
                dtBultosFinal.Clear()
                dgwBultos.AutoGenerateColumns = False
                If cmbNrGuiaBulto.SelectedValue <> "Todos" Then
                    Dim drs As DataRow()
                    drs = Bultos.Select("NRGUCL='" & cmbNrGuiaBulto.SelectedValue & "'")
                    For Each row As DataRow In drs
                        dtBultosFinal.ImportRow(row)
                    Next
                    dgwBultos.DataSource = dtBultosFinal
                Else
                    dgwBultos.DataSource = oDtBultos
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbNrGuiaItems_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNrGuiaItems.SelectionChangeCommitted
       
        Try
            If cmbNrGuiaItems.Items.Count > 0 Then
                Dim Items As New DataTable
                Dim dtItemsFinal As New DataTable
                Items = oDtItems.Copy
                dtItemsFinal = oDtItems.Copy
                dtItemsFinal.Clear()
                dgwItems.AutoGenerateColumns = False
                If cmbNrGuiaItems.SelectedValue <> "Todos" Then
                    Dim drs As DataRow()
                    drs = Items.Select("NRGUCL='" & cmbNrGuiaItems.SelectedValue & "'")
                    For Each row As DataRow In drs
                        dtItemsFinal.ImportRow(row)
                    Next
                    dgwItems.DataSource = dtItemsFinal
                Else
                    dgwItems.DataSource = oDtItems
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Metodos y Funciones"

    Public Sub CargarDatos()

        Dim objBeGuiaTransportista As New GuiaTransportista_BLL
        Dim objGuiaTransportista As New GuiaTransportista
        Dim Ds As New DataSet
        Dim dtDatosGuiaTransporte As New DataTable
        Dim DtGuiaRemision As New DataTable
        Dim DtGBultosItems As New DataTable

        Ds = objBeGuiaTransportista.Cargar_Envio_Despacho(PNCTRMNC, PNNGUITR, CCMPN)

        dtDatosGuiaTransporte = Ds.Tables(0).Copy
        DtGuiaRemision = Ds.Tables(1).Copy
        DtGBultosItems = Ds.Tables(2).Copy

        'LLENAR DATOS GUÍA TRANSPORTE
        Me.txtGuiaTransporte.Text = dtDatosGuiaTransporte.Rows(0).Item("NGUIRM").ToString.Trim
        Me.txtFechaGuia.Text = HelpClass.FechaNum_a_Fecha(dtDatosGuiaTransporte.Rows(0).Item("FGUIRM").ToString.Trim)
        Me.txtRucTransportista.Text = dtDatosGuiaTransporte.Rows(0).Item("NRUCTR").ToString.Trim
        Me.txtRazonTransportista.Text = dtDatosGuiaTransporte.Rows(0).Item("TCMTRT").ToString.Trim
        Me.txtPlacaTracto.Text = dtDatosGuiaTransporte.Rows(0).Item("NPLCTR").ToString.Trim
        Me.txtPlacaAcoplado.Text = dtDatosGuiaTransporte.Rows(0).Item("NPLCAC").ToString.Trim
        Me.txtBreveteConductor.Text = dtDatosGuiaTransporte.Rows(0).Item("CBRCNT").ToString.Trim
        Me.txtNombreConductor.Text = dtDatosGuiaTransporte.Rows(0).Item("NOM_CONDUCTOR1").ToString.Trim
        Me.txtOrigen.Text = dtDatosGuiaTransporte.Rows(0).Item("RUTA_ORIGEN").ToString.Trim
        Me.txtDestino.Text = dtDatosGuiaTransporte.Rows(0).Item("RUTA_DESTINO").ToString.Trim
        KryptonTextBox1.Text = dtDatosGuiaTransporte.Rows(0).Item("TIPO_ACOPLADO").ToString.Trim
        ucResponsable.Valor = dtDatosGuiaTransporte.Rows(0).Item("UNIDAD_MPO").ToString.Trim

        'LLENAR DATOS GRILLA GUÍA REMISION
        dgwGuiaRemision.AutoGenerateColumns = False
        dgwGuiaRemision.DataSource = DtGuiaRemision

        'LLENAR DATOS COMBO GUÍA REMISION
        Llenar_ComboBox(cmbNrGuiaBulto, DtGuiaRemision)
        Llenar_ComboBox(cmbNrGuiaItems, DtGuiaRemision)
        'LLENAR GRILLA BULTOSS
        llenar_Bultos(DtGBultosItems)

        'LLENAR GRILLA ITEMS
        oDtItems = DtGBultosItems
        dgwItems.AutoGenerateColumns = False
        dgwItems.DataSource = DtGBultosItems

    End Sub

    Private Sub llenar_Bultos(ByVal oDt As DataTable)

        Dim ht As New Hashtable
        Dim oDtBulto As New DataTable
        oDtBulto = oDt.Copy
        oDtBulto.Clear()
        Dim Llave As String = ""
        For Each row As DataRow In oDt.Rows
            Llave = String.Format("{0}-{1}-{2}-{3}-{4}", row("CTRMNC").ToString.Trim, row("NGUIRM").ToString.Trim, row("NRGUCL").ToString.Trim, row("CCLNT").ToString.Trim, row("CREFFW").ToString.Trim)
            If Not ht.Contains(Llave.Trim) Then
                ht.Add(Llave.Trim, "")  '(Key , Valor)
                oDtBulto.ImportRow(row)
            End If
        Next
        oDtBultos = oDtBulto
        dgwBultos.AutoGenerateColumns = False
        dgwBultos.DataSource = oDtBulto
    End Sub

    Public Sub Llenar_ComboBox(ByRef pSelectControl As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal p_dt As DataTable)
        Dim distinctDT As DataTable = p_dt.DefaultView.ToTable(True, "NRGUCL")
        Dim dr As DataRow
        dr = distinctDT.NewRow()
        dr("NRGUCL") = "Todos"
        distinctDT.Rows.InsertAt(dr, 0)

        pSelectControl.DataSource = distinctDT
        pSelectControl.ValueMember = "NRGUCL"
        pSelectControl.DisplayMember = "NRGUCL"

    End Sub

    Private Function ValidarGuiasBultos() As String
        Dim msje As String = ""
        Dim Guias As String = ""
        If dgwGuiaRemision.Rows.Count > 0 Then
            For Each Guia As DataGridViewRow In dgwGuiaRemision.Rows
                Dim dr() As DataRow
                dr = oDtBultos.Select("NRGUCL=" & Guia.Cells("NRGUCL").Value)
                If dr.Length = 0 Then
                    Guias = Guias + Guia.Cells("NRGUCL").Value + ","
                End If
            Next
        End If
        If Guias.Length > 0 Then
            msje = "Las Guías [" + Guias.Substring(0, Guias.Length - 1) + "] no tienen asignado los bultos"
        End If
        Return msje
    End Function

    Private Sub Cargar_UnidadMPO()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New TipoDatoGeneral_BLL
        Dim lista As New List(Of TipoDatoGeneral)
        lista = obj.Lista_Tipo_Dato_General(CCMPN, "TVHMLP")
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CODIGO_TIPO"
        oColumnas.DataPropertyName = "CODIGO_TIPO"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESC_TIPO"
        oColumnas.DataPropertyName = "DESC_TIPO"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.ucResponsable.Etiquetas_Form = Etiquetas
        Me.ucResponsable.DataSource = lista
        Me.ucResponsable.ListColumnas = oListColum
        Me.ucResponsable.Cargas()
        Me.ucResponsable.DispleyMember = "DESC_TIPO"
        Me.ucResponsable.ValueMember = "CODIGO_TIPO"
    End Sub
 
    'Private Function validarLongitud(ByVal Texto As String, ByVal Tamanio As Integer)
    '    Dim Respuesta As String = ""
    '    If Texto.Trim.Length > Tamanio Then
    '        Respuesta = Texto.Substring(0, Tamanio)
    '    Else
    '        Respuesta = Texto
    '    End If
    '    Return Respuesta
    'End Function


#End Region




End Class
