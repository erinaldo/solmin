Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO


Public Class frmAsignacionManual

 

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
       


    End Sub


#Region "Atributo"
    Private _obj_Entidad As New Detalle_Solicitud_Transporte
    Private _Registro_AgenciasRansa As Boolean = False
    Private lstr_codigo_cliente As String = ""
    Private lintMedioTransporte As Int32 = 0
    Private oSeguridad As NEGOCIO.Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private strResultado As String = ""

    Public oHasLimiteCredito As New Hashtable
    Public oHasHomologacionTransportista As New Hashtable
    Public RucCargaTransportista As String = ""
    Public RucRansa As String = "20100039207"
#End Region

#Region "Properties"
    Public Property obj_Entidad() As Detalle_Solicitud_Transporte
        Get
            Return _obj_Entidad
        End Get
        Set(ByVal value As Detalle_Solicitud_Transporte)
            _obj_Entidad = value
        End Set
    End Property

    Public CLCLOR As Decimal = 0
    Public CLCLDS As Decimal = 0
    Public NPRASG As Decimal = 0
    Public CCMPN As String = ""
    Public NUMREQT As Decimal = 0
    Private _Entidad_Unid_Prog As New ENTIDADES.Programacion_Unidad
    Public CDVSN As String
    Public CPLNDV As Double = 0
    Public NDCORM As Decimal = 0D
    Public PNCDTR As String = ""
    Public CDDRSP As String = ""
    Public es_OS_TipoSeguimiento As Boolean = False ' si es verdadero no se creará Orden Interna
    Public WriteOnly Property MedioTransporte() As Int32
        Set(ByVal value As Int32)
            lintMedioTransporte = value
        End Set
    End Property


#End Region

#Region "Eventos"

    Private pPlantaRelacion As Decimal = 0
    Private Sub frmReasignarRecurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obj As New TipoDatoGeneral_BLL
            Dim lista As New List(Of TipoDatoGeneral)
            lista = obj.Lista_Tipo_Dato_General("", "STPLMT")
            If lista.Count > 0 Then
                pPlantaRelacion = lista(0).CODIGO_TIPO
            End If
            If pPlantaRelacion = 0 Then
                pPlantaRelacion = CPLNDV
            End If


            Me.CargarTransportista()
            Me.txtNroSolicitud.Text = Me._obj_Entidad.NCSOTR
            Me.txtItemSolicitud.Text = Me._obj_Entidad.NCRRSR
            Me.lstr_codigo_cliente = Me._obj_Entidad.CCLNT
            Me.ckbOSAgenciaRansa.Checked = False
            Asignacion_OS_Agencia_Ransa()
            If Me.CCMPN <> "EZ" Then
                Me.ckbOSAgenciaRansa.Visible = False
            End If

            If NUMREQT > 0 Then
                btnUnidProgramadas.Enabled = True
                btnUnidProgramadas.Visible = True
                btnVerPreAsignacionUnid.Enabled = False
                btnVerPreAsignacionUnid.Visible = False
            Else
                btnUnidProgramadas.Enabled = False
                btnUnidProgramadas.Visible = False
                btnVerPreAsignacionUnid.Enabled = True
                btnVerPreAsignacionUnid.Visible = True
            End If

            If NDCORM > 0D Then
                ckbOSAgenciaRansa.Checked = True
                _Registro_AgenciasRansa = True
                Me.txtOsAgenciasRansa.Text = NDCORM
                Me.txtNroOperacionAgenciasRansa.Text = PNCDTR
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Asignacion_OS_Agencia_Ransa()
        'FRAGMENTO DE CODIGO HARD-CODING, AGENCIAS RANSA : 22-04-2010
        If Me.ckbOSAgenciaRansa.Checked = True Then
            Me.pnlAgenciasRansa.Visible = True
            'Me.Height = 375
            Me.txtOrdenServicioMineria.Text = obj_Entidad.NORSRT
            _Registro_AgenciasRansa = True
        Else
            Me.pnlAgenciasRansa.Visible = False
            'Me.Height = 285
            Me.txtOrdenServicioMineria.Text = ""
            Me.txtOsAgenciasRansa.Text = ""
            Me.txtNroOperacionAgenciasRansa.Text = ""
            _Registro_AgenciasRansa = False
        End If
    End Sub

    'Private Sub Generar_Operacion_Agencias_Ransa()
    '    Try
    '        If Me.txtOsAgenciasRansa.Text = "" Then
    '            HelpClass.MsgBox("Debe de Ingresar el Nro de Orden de Servicio de Trasportes")
    '            Exit Sub
    '        End If
    '        If Me.lstr_codigo_cliente = "" Then
    '            HelpClass.MsgBox("Debe de Ingresar el Nro de cliente")
    '            Exit Sub
    '        End If

    '        Dim objParametros As New Hashtable
    '        Dim objAgenciasRansa As New NEGOCIO.Operaciones.OrdenServicioAgenciaRansa_BLL
    '        objParametros.Add("AGE_NORSRT", Me.txtOsAgenciasRansa.Text)
    '        objParametros.Add("PNCDTR", Me.txtNroOperacionAgenciasRansa.Text)
    '        objParametros.Add("NORSRT", Me.txtOrdenServicioMineria.Text)
    '        objParametros.Add("HORA", HelpClass.NowNumeric)
    '        objParametros.Add("HOY", HelpClass.TodayNumeric)
    '        ' objParametros.Add("CCLNT", "000606")
    '        objParametros.Add("CCLNT", lstr_codigo_cliente)

    '        objAgenciasRansa.Registrar_Orden_Servicio(objParametros)

    '    Catch ex As Exception
    '        HelpClass.MsgBox(ex.ToString)
    '    End Try
    'End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = CCMPN
        If RucCargaTransportista.Length > 0 Then
            obeTransportista.pNRUCTR_RucTransportista = RucCargaTransportista
            cboTransportista.pCargar(obeTransportista)
            cboTransportista_InformationChanged()
        Else
            cboTransportista.pCargar(obeTransportista)
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            Dim tipoAccion As String = ""
            If es_OS_TipoSeguimiento = True Then
                tipoAccion = "SEGUIMIENTO"
            Else
                tipoAccion = "SERVICIO"
            End If
            Dim esModoTerrestre As Boolean = (lintMedioTransporte = 4)


            Dim solicitudTransporteBL As New Solicitud_Transporte_BLL
            Dim solicitudTransporteBE As New Solicitud_Transporte
            Dim msgVal As String = ""
            Dim HoraAtencion As String = (txtHoraInicio.Text.Replace(":", "").Trim & "00").PadLeft(6, "0")

            If Validar_Recursos_Asignados() = True Then Exit Sub

            
            Dim hrainicio As Date
            If Val(HoraAtencion) > 0 Then
                If DateTime.TryParse(Me.txtHoraInicio.Text, hrainicio) = False Then
                    MessageBox.Show("Ingrese hora atención correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            '--Verificación de Bloqueo Linea de Credito
            solicitudTransporteBE.NORSRT = obj_Entidad.NORSRT

            REM ECM-HUNDRED-INICIO

            ' validar Generacion De Operacion 
            Dim oblGuiaTransportista As New GuiaTransportista_BLL
            Dim msjGeneracionOp As String = String.Empty
            Dim oFiltro As New Hashtable
            oFiltro.Add("NCSOTR", obj_Entidad.NCSOTR)
            'oFiltro.Add("NORSRT", obj_Entidad.NORSRT)
            oFiltro.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
            oFiltro.Add("TRACTO", cboTracto.pNroPlacaUnidad)
            oFiltro.Add("ACOPLADO", cboAcoplado.pNroAcoplado)
            oFiltro.Add("HATNSR", HoraAtencion)

            msjGeneracionOp = oblGuiaTransportista.validarGeneracionDeOperacion(oFiltro)
            msjGeneracionOp = msjGeneracionOp.Trim
            If msjGeneracionOp.Trim.Length > 0 Then
                MessageBox.Show(msjGeneracionOp, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Select Case tipoAccion
                Case "SERVICIO"


                    If Not oHasLimiteCredito.ContainsKey(lstr_codigo_cliente) Then

                        'Dim mensaje As String = oSeguridad.VerificarLineaCreditoCliente(CCMPN, lstr_codigo_cliente)
                        Dim mensaje As String = oSeguridad.Validar_Limite_Credito_Cliente_General(CCMPN, lstr_codigo_cliente)
                        If mensaje.ToString() <> "" Then
                            MessageBox.Show(mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            oHasLimiteCredito(lstr_codigo_cliente) = "OK"
                        End If

                    End If

                    Dim RucT As String = cboTransportista.pRucTransportista.ToString.Trim


                    If RucT <> RucRansa Then

                        If Not oHasHomologacionTransportista.ContainsKey(RucT) Then

                            If esModoTerrestre = True Then
                                'strResultado = Validar_Proveedor_Homologado()
                                Dim objNegocioVal As New Solicitud_Transporte_BLL
                                strResultado = objNegocioVal.Valida_Homologacion_GeneralTransportista(Me.CCMPN, RucT)
                                If strResultado.Trim <> "" Then
                                    HelpClass.MsgBox("Advertencia : " & strResultado, MessageBoxIcon.Information)
                                    Exit Sub
                                Else
                                    oHasHomologacionTransportista(RucT) = "OK"
                                End If
                            End If
                        End If


                    End If


                    'If Not oHasHomologacionTransportista.ContainsKey(Me.cboTransportista.pRucTransportista.ToString) Then

                    '    If Me.lintMedioTransporte = 4 Then
                    '        strResultado = Validar_Proveedor_Homologado()
                    '        If strResultado.Trim <> "" Then
                    '            HelpClass.MsgBox("Advertencia : " & strResultado, MessageBoxIcon.Information)
                    '            Exit Sub
                    '        Else
                    '            oHasHomologacionTransportista(Me.cboTransportista.pRucTransportista.ToString) = "OK"

                    '        End If
                    '    End If

                    'End If
                    '-- Validación Homologación Proveedores


            End Select

            If Me._Registro_AgenciasRansa = True Then
                If Me.txtOsAgenciasRansa.Text = "" Then
                    HelpClass.MsgBox("Debe seleccionar una orden de servicio de Agencias Ransa")
                    Exit Sub
                End If
            End If


            If tipoAccion = "SERVICIO" Then
                Try
                    Dim dtvalidarPlacasAlq As New DataTable
                    Dim msgValAsignacion As String = ""
                    Dim msgValPlacaTracto As String = ""
                    Dim msgValPlacaAcoplado As String = ""
                    dtvalidarPlacasAlq = solicitudTransporteBL.Lista_Validacion_Placa(CCMPN)
                    If dtvalidarPlacasAlq.Rows.Count > 0 Then
                        If ("" & dtvalidarPlacasAlq.Rows(0)("TDSDES")).ToString.Trim = "1" Then
                            msgValPlacaTracto = ValidarPlacasAsignacion("T", cboTracto.pNroPlacaUnidad)
                            msgValPlacaAcoplado = ValidarPlacasAsignacion("A", cboAcoplado.pNroAcoplado)
                            msgValAsignacion = (msgValPlacaTracto & Chr(13) & msgValPlacaAcoplado).Trim
                            If msgValAsignacion.Length > 0 Then
                                MessageBox.Show(msgValAsignacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            Dim ItemSolicitud As Decimal = Generar_Detalle_Solicitud_Transporte()
            If ItemSolicitud > 0 Then              
                Registrar_Operacion_Transporte(ItemSolicitud)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
             
             
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Function ValidarPlacasAsignacion(ByVal Tipo_Recurso As String, ByVal Placa As String) As String
        If Placa = "" Then Return ""
        Dim objEntidad As New Solicitud_Transporte
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim msgVal As String = ""
        Dim recurso As String = ""
        objEntidad.CCMPN = CCMPN
        objEntidad.CDVSN = CDVSN
        objEntidad.CPLNDV = CPLNDV
        Select Case Tipo_Recurso
            Case "T"
                objEntidad.NPLRCS = Placa
                objEntidad.STPRCS = "T"
                recurso = "Tracto"
            Case "A"
                objEntidad.NPLRCS = Placa
                objEntidad.STPRCS = "A"
                recurso = "Acoplado"
        End Select

        objEntidad.NRUCTR = cboTransportista.pRucTransportista

        Dim dsDatosPlaca As New DataSet
        Dim dtPropPlaca As New DataTable
        Dim dtDatoPlacaAsigando As New DataTable
        If cboTransportista.pPropioTercero = "P" Then
            dsDatosPlaca = objNegocio.Validacion_Placa_Propietario_Placa(objEntidad)
            dtDatoPlacaAsigando = dsDatosPlaca.Tables(0).Copy
            dtPropPlaca = dsDatosPlaca.Tables(1).Copy

            

            If dtPropPlaca.Rows.Count > 0 Then

                Dim RucPropietarioRecurso As String = ("" & dtPropPlaca.Rows(0)("NRUCTR")).ToString.Trim
                Dim DesRucPropietarioRecurso As String = ("" & dtPropPlaca.Rows(0)("TCMTRT")).ToString.Trim
                If RucPropietarioRecurso <> cboTransportista.pRucTransportista Then
                    Dim dtAlquilerVigente As New DataTable
                    Dim ExisteAlquiler As Boolean = False
                    Dim NRALQT As Decimal = 0
                    dtAlquilerVigente = objNegocio.Mostar_Alquiler_VIGENTE(CCMPN, CDVSN, RucPropietarioRecurso, Tipo_Recurso, Placa, dtpFechaAtencionServicio.Value.ToString("yyyyMMdd"))
                    For Each Item As DataRow In dtAlquilerVigente.Rows
                        If ("" & Item("FLGAPR")).ToString.Trim = "X" Then
                            ExisteAlquiler = True
                            Exit For
                        End If
                    Next
                    If dtAlquilerVigente.Rows.Count = 0 Then
                        msgVal = "El " & recurso & " " & Placa & " no cuenta con alquiler(vigente)."
                    Else
                        If ExisteAlquiler = False Then
                            msgVal = "El alquiler en el " & recurso & " " & Placa & " requiere ser aprobado."
                        End If
                    End If

                End If

                
            End If

        End If
        Return msgVal
    End Function
    

    Private Sub ctbTracto_Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If Me.cboTracto.pNroPlacaUnidad.Trim.Equals("") Then
                Me.cboTracto.pClear()
                Me.cboAcoplado.pClear()
                Me.cmbConductor.pClear()
                Me.cmbSegundoConductor.pClear()
                Exit Sub
            End If
            Dim obj_Entidad As New TransportistaTracto
            Dim obj_Logica As New TransportistaTracto_BLL
            obj_Entidad.NPLCUN = Me.cboTracto.pNroPlacaUnidad
            obj_Entidad.CCMPN = CCMPN
            obj_Entidad = obj_Logica.Obtener_Informacion_Tracto(obj_Entidad)
            If obj_Entidad.NPLCAC.Trim = "" Then Me.cboAcoplado.pClear()
            If obj_Entidad.CBRCNT.Trim = "" Then Me.cmbConductor.pClear()

            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
            obeAcoplado.pCCMPN_Compania = CCMPN
            Me.cboAcoplado.pCargar(obeAcoplado)

            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
            obeConductor.pCCMPN_Compania = CCMPN
            obeConductor.pPlanta = pPlantaRelacion 'CPLNDV
            obeConductor.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            obeConductor.pCBRCNT_Brevete = obj_Entidad.CBRCNT.Trim
            Me.cmbConductor.pCargar(obeConductor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Metodos y Funciones"

    'Private Sub Cargar_Combo_Acoplado_Conductor(Optional ByVal strConductor As String = "", Optional ByVal strSegundoConductor As String = "")
    '    'Try
    '    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
    '    obeConductor.pCCMPN_Compania = _CCMPN
    '    obeConductor.pPlanta = _CPLNDV
    '    obeConductor.pCBRCNT_Brevete = strConductor
    '    obeConductor.pNRUCTR_RucTransportista = cboTransportista.pRucTransportista
    '    Me.cmbConductor.pCargar(obeConductor)

    '    obeConductor.pCBRCNT_Brevete = strSegundoConductor
    '    Me.cmbSegundoConductor.pCargar(obeConductor)

    'Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Function Validar_Recursos_Asignados() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        'Evaluando la Asignación: Transportista, Tracto, Acoplado y Conductor
        If Me.cboTransportista.pRazonSocial.Trim.Equals("") Then
            lstr_validacion += "* TRANSPORTISTA" & Chr(13)
        End If

      
        If Me.cboTracto.pNroPlacaUnidad.Trim.Equals("") Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If
        
        If lintMedioTransporte = 4 Then
            If Me.cmbConductor.pBrevete = "" Then
                lstr_validacion += "* CONDUCTOR" & Chr(13)
            End If
        End If

       

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If



        Return lbool_existe_error
    End Function

    'Private Sub Generar_Junta_Transporte()

    '    Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
    '    Dim Objeto_Logica As New Junta_Transporte_BLL
    '    Objeto_Entidad.NCSOTR = Me._obj_Entidad.NCSOTR
    '    Objeto_Entidad.CCLNT = Me._obj_Entidad.CCLNT
    '    Objeto_Entidad.NRUCTR = Me.cboTransportista.pRucTransportista

    '    Objeto_Entidad.NPLCUN = Me.cboTracto.pNroPlacaUnidad
    '    Objeto_Entidad.NPLCAC = Me.cboAcoplado.pNroAcoplado

    '    Objeto_Entidad.CBRCNT = Me.cmbConductor.pBrevete
    '    Objeto_Entidad.CBRCN2 = Me.cmbSegundoConductor.pBrevete
    '    Objeto_Entidad.CUSCRT = MainModule.USUARIO
    '    Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
    '    Objeto_Entidad.HRACRT = HelpClass.NowNumeric
    '    Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    Objeto_Entidad.CCMPN = Me._obj_Entidad.CCMPN
    '    Objeto_Entidad.CDVSN = Me._obj_Entidad.CDVSN
    '    Objeto_Entidad.CPLNDV = Me._obj_Entidad.CPLNDV
    '    Objeto_Entidad.NPLNJT = Objeto_Logica.Registrar_Junta_Transporte_Manual(Objeto_Entidad).NPLNJT


    '    'Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
    '    'Dim objAteReq As New AtencionRequerimiento
    '    'objAteReq.NUMREQT = NUMREQT
    '    'objAteReq.CCMPN = CCMPN
    '    'objAteReq.CUSCRT = MainModule.USUARIO
    '    'objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    'objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)



    '    If Objeto_Entidad.NPLNJT = "0" Then
    '        HelpClass.ErrorMsgBox()
    '        Exit Sub
    '    End If
    '    Me._obj_Entidad.NPLNJT = CType(Objeto_Entidad.NPLNJT, Double)
    '    Me._obj_Entidad.NCRRPL = 0
    '    Me._obj_Entidad.NCRRSR = CType(Objeto_Entidad.NCRRSR, Double)

    'End Sub

    Private Function Generar_Detalle_Solicitud_Transporte() As Decimal
        Dim ItemSol As Decimal = 0
        Dim CorrSolServicio As Decimal = 0
        Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        Dim Objeto_Logica As New Junta_Transporte_BLL
        Objeto_Entidad.NCSOTR = Me._obj_Entidad.NCSOTR
        Objeto_Entidad.CCLNT = Me._obj_Entidad.CCLNT
        Objeto_Entidad.NRUCTR = Me.cboTransportista.pRucTransportista

        Objeto_Entidad.NPLCUN = Me.cboTracto.pNroPlacaUnidad
        Objeto_Entidad.NPLCAC = Me.cboAcoplado.pNroAcoplado

        Objeto_Entidad.CBRCNT = Me.cmbConductor.pBrevete
        Objeto_Entidad.CBRCN2 = Me.cmbSegundoConductor.pBrevete
        Objeto_Entidad.CUSCRT = MainModule.USUARIO
      
        Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        Objeto_Entidad.CCMPN = Me._obj_Entidad.CCMPN
        Objeto_Entidad.CDVSN = Me._obj_Entidad.CDVSN
        Objeto_Entidad.CPLNDV = Me._obj_Entidad.CPLNDV



        Dim msg As String = ""

        Dim oRespuesta As New beRespuestaOperacion
        oRespuesta = Objeto_Logica.Registrar_Detalle_Solicitud_Transporte(Objeto_Entidad, msg)
        If msg.Length > 0 Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Exit Function
        End If
        ItemSol = oRespuesta.NCRRSR

        Return ItemSol

      


    End Function



    Private Sub Registrar_Operacion_Transporte(ItemSolicitud As Decimal)

        Try

            Dim objOperacionTransporte As New OperacionTransporte_BLL
          

            Dim HoraAtencion As Decimal = (txtHoraInicio.Text.Replace(":", "").Trim & "00").PadLeft(6, "0")

            Dim oParam_OP As New ENTIDADES.beRespuestaOperacion
            oParam_OP.NCSOTR = Me._obj_Entidad.NCSOTR
            oParam_OP.NCRRSR = ItemSolicitud ' Me._obj_Entidad.NCRRSR
            'oParam_OP.NORSRT = Me._obj_Entidad.NORSRT
            'oParam_OP.CCMPN = Me._obj_Entidad.CCMPN
            'oParam_OP.CDVSN = Me._obj_Entidad.CDVSN
            'oParam_OP.CPLNDV = Me._obj_Entidad.CPLNDV
            oParam_OP.CUSCRT = MainModule.USUARIO
            oParam_OP.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            oParam_OP.TIPO_REGISTRO = "NUEVO"
            oParam_OP.SORGMV = IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), "", "A")
            oParam_OP.NDCORM = IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), 0, Me.txtOsAgenciasRansa.Text)
            oParam_OP.PNCDTR = Me.txtNroOperacionAgenciasRansa.Text
            oParam_OP.FATNSR = HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
            oParam_OP.HATNSR = HoraAtencion
            oParam_OP.CTPOVJ = Me._obj_Entidad.CTPOVJ

            Dim oRespuestaOP As New ENTIDADES.beRespuestaOperacion
            Dim msgError As String = ""

            oRespuestaOP = objOperacionTransporte.Registrar_Operacion_Transporte(oParam_OP, msgError)
            If msgError.Length > 0 Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            Else

                If es_OS_TipoSeguimiento = False Then
                    Dim msg_oi As String = ""

                    Me.Generar_Orden_Interna(oRespuestaOP, msg_oi)
                    If msg_oi.Length > 0 Then
                        MessageBox.Show(msg_oi, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                End If



                Dim objHito As New HitoOperacion
                Dim objLogicaHito As New ControlHitos_BLL
                Dim msg As String = ""
                With objHito
                    .NOPRCN = oRespuestaOP.NOPRCN
                    .NGUIRM = 0
                    .CTRMNC = 0
                    .FRETES = HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
                    .HRAREA = HoraAtencion
                    .CUSCRT = MainModule.USUARIO
                    .TIPO_HITO = "F_INICIO"
                End With
                msg = objLogicaHito.RegistrarHito_Actualizacion(objHito)

                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                End If

            End If

            

        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    'Private Sub Asignar_Unidades(ByVal Operacion As Double)

    '    Dim oPreAsignacionUnidades_BE As New SOLMIN_ST.ENTIDADES.PreAsignacionUnidades_BE
    '    Dim oPreAsignacionUnidades_BLL As New SOLMIN_ST.NEGOCIO.PreAsignacionUnidades_BLL
    '    oPreAsignacionUnidades_BE.PNNPRASG = NPRASG
    '    'oPreAsignacionUnidades_BE.PNNPRASG = _NPRASG
    '    oPreAsignacionUnidades_BE.PNNOPRCN = Operacion
    '    oPreAsignacionUnidades_BLL.Asignar_PreAsignacionUnidades(oPreAsignacionUnidades_BE)

    'End Sub

    'Private Sub Generar_Orden_Interna(ByVal ldbl_NOPRCN As Double)
    '    Dim objOrdenInterna As New OrdenInterna_BLL
    '    Dim objEntidad As New Planeamiento
    '    Dim objParametros As New List(Of String)
    '    Try
    '        objParametros.Add(ldbl_NOPRCN)
    '        objParametros.Add(MainModule.USUARIO)
    '        objParametros.Add(HelpClass.TodayNumeric)
    '        objParametros.Add(HelpClass.NowNumeric)
    '        objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)

    '        objParametros.Add(Me.cboTracto.pNroPlacaUnidad)
    '        objParametros.Add(Me.cboAcoplado.pNroAcoplado)


    '        objParametros.Add(Me.cmbConductor.pBrevete)
    '        objParametros.Add(Me._obj_Entidad.CCMPN)
    '        objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)

    '        ddd()
    '        If (objEntidad.OI_SAP = 0) Then
    '            MessageBox.Show("No se generó Orden Interna", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Return
    '        End If

    '    Catch ex As Exception
    '        HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub Generar_Orden_Interna(oRespuesta As ENTIDADES.beRespuestaOperacion, ByRef msgError As String)
        Dim objOrdenInterna As New OrdenInterna_BLL
       
        Try
            


            Dim msg_oi As String = ""
            Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
            oFiltroRecurso.NOPRCN = oRespuesta.NOPRCN
            oFiltroRecurso.NCRRPL = oRespuesta.NCRRPL
            oFiltroRecurso.NSBCRP = oRespuesta.NSBCRP
            oFiltroRecurso.CULUSA = MainModule.USUARIO
            oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            Dim orptaOI As New ENTIDADES.beRespuestaOperacion
            orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)
            msgError = msg_oi

         

        Catch ex As Exception
            msgError = ex.Message
        End Try

    End Sub


    Private Sub NoMostrar()
        Me.btnNuevoAcoplado.Visible = False
        Me.btnNuevoCia.Visible = False
        Me.btnNuevoContudtor2.Visible = False
        Me.btnNuevoContudtor1.Visible = False
        Me.btnNuevoTracto.Visible = False
    End Sub

#End Region

    'Private Sub btnNuevoCia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCia.Click
    '    Dim ofrmNuevoTransportista As New frmNuevoTransportista
    '    With ofrmNuevoTransportista
    '        .CCMPN = _CCMPN
    '        .CDVSN = _CDVSN
    '        CPLNDV = _CPLNDV
    '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    '            obeTransportista.pCCMPN_Compania = _CCMPN
    '            obeTransportista.pNRUCTR_RucTransportista = .NRUCTR
    '            Me.cboTransportista.pCargar(obeTransportista)
    '        End If
    '    End With
    'End Sub

    'Private Sub Registrar_VehiculoTransportista(ByVal strVehiculo As String, ByVal STPVHP As String)
    '    Dim objEntidadTT As New TransportistaTracto
    '    Dim objLogica As New TransportistaTracto_BLL

    '    objEntidadTT.NRUCTR = Me.cboTransportista.pRucTransportista
    '    objEntidadTT.NPLCUN = strVehiculo
    '    objEntidadTT.FECINI = HelpClass.TodayNumeric
    '    objEntidadTT.FECFIN = HelpClass.TodayNumeric
    '    objEntidadTT.TOBS = ""
    '    objEntidadTT.CUSCRT = MainModule.USUARIO
    '    objEntidadTT.FCHCRT = HelpClass.TodayNumeric
    '    objEntidadTT.HRACRT = HelpClass.NowNumeric
    '    objEntidadTT.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTT.POS_RUC_ANTERIOR = ""
    '    objEntidadTT.FLAG_SKIPCHECKS = 0
    '    objEntidadTT.SESTCM = ""
    '    objEntidadTT.CCMPN = _CCMPN
    '    objEntidadTT.CDVSN = _CDVSN
    '    objEntidadTT.CPLNDV = _CPLNDV
    '    objEntidadTT.STPVHP = STPVHP

    '    Dim objExisteTT As New TransportistaTracto
    '    objExisteTT = objEntidadTT
    '    objExisteTT.CCMPN = _CCMPN
    '    objExisteTT = objLogica.Registrar_TransportistaTracto_V2(objExisteTT)



    '    If objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
    '        objEntidadTT.FLAG_SKIPCHECKS = 1
    '        objEntidadTT.CCMPN = _CCMPN
    '        objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)


    '    ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

    '        Dim objLogicaCia As New Transportista_BLL

    '        'valida q no se asigne a la misma cia q ya lo tiene
    '        If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
    '            'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
    '            If objExisteTT.SESTCM = "*" Then
    '                objEntidadTT.FLAG_SKIPCHECKS = 1
    '                objEntidadTT.CCMPN = _CCMPN
    '                objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)

    '            Else

    '                If STPVHP.ToString.Trim <> "" Then

    '                    Dim objBLL As New Tracto_BLL
    '                    Dim objBE As New Tracto

    '                    objBE.CCMPN = _CCMPN
    '                    objBE.CDVSN = _CDVSN
    '                    objBE.CPLNDV = _CPLNDV
    '                    objBE.NRUCTR = Me.cboTransportista.pRucTransportista
    '                    objBE.NPLCUN = strVehiculo
    '                    objBE.STPVHP = STPVHP
    '                    objBE.CULUSA = MainModule.USUARIO
    '                    objBE.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

    '                    objBLL.Modificar_Asignacion_Tracto_Transportista(objBE)

    '                End If

    '                MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)


    '                Exit Sub
    '            End If

    '        Else 'cambio de otra compañia
    '            Dim objCia1 As New Transportista
    '            objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
    '            objCia1.CCMPN = _CCMPN
    '            objCia1.CDVSN = _CDVSN
    '            objCia1.CPLNDV = _CPLNDV

    '            Dim olbeCia1 As New List(Of Transportista)
    '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
    '            If olbeCia1.Count = 0 Then Exit Sub

    '            objCia1 = olbeCia1.Item(0)

    '            Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
    '                                    "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
    '                                    "Compañía: " & objCia1.TCMTRT & vbCrLf & _
    '                                    "¿Desea cambiarlo a la compañía " & Me.cboTransportista.pRazonSocial & " ?"
    '            If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    '                objEntidadTT.FLAG_SKIPCHECKS = 1
    '                objEntidadTT.CCMPN = _CCMPN
    '                objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)

    '            End If
    '        End If

    '    End If


    'End Sub

    'Private Sub Registrar_AcopladoTransportista(ByVal strAcoplado As String, ByVal STPACP As String)

    '    Dim objEntidadTA As New TransportistaAcoplado
    '    Dim objLogica As New TransportistaAcoplado_BLL

    '    objEntidadTA.NRUCTR = cboTransportista.pRucTransportista
    '    objEntidadTA.NPLCAC = strAcoplado 'cboAcoplados.Codigo
    '    objEntidadTA.FECINI = HelpClass.TodayNumeric
    '    objEntidadTA.FECFIN = HelpClass.TodayNumeric
    '    objEntidadTA.TOBS = ""
    '    objEntidadTA.CUSCRT = MainModule.USUARIO
    '    objEntidadTA.FCHCRT = HelpClass.TodayNumeric
    '    objEntidadTA.HRACRT = HelpClass.NowNumeric
    '    objEntidadTA.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTA.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTA.POS_RUC_ANTERIOR = ""
    '    objEntidadTA.FLAG_SKIPCHECKS = 0
    '    objEntidadTA.SESTAC = ""
    '    objEntidadTA.CCMPN = _CCMPN
    '    objEntidadTA.CDVSN = _CDVSN
    '    objEntidadTA.CPLNDV = _CPLNDV
    '    objEntidadTA.STPACP = STPACP

    '    Dim objExisteTA As New TransportistaAcoplado
    '    objExisteTA = objEntidadTA
    '    objExisteTA = objLogica.Registrar_TransportistaAcoplado_V2(objExisteTA)


    '    If objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
    '        objEntidadTA.FLAG_SKIPCHECKS = 1
    '        objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)

    '    ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
    '        Dim objLogicaCia As New Transportista_BLL

    '        'valida q no se asigne a la misma cia q ya lo tiene
    '        If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
    '            'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
    '            If objExisteTA.SESTAC = "*" Then
    '                objEntidadTA.FLAG_SKIPCHECKS = 1
    '                objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)

    '            Else

    '                If STPACP.ToString.Trim <> "" Then

    '                    Dim objBLL As New Acoplado_BLL
    '                    Dim objBE As New Acoplado

    '                    objBE.CCMPN = _CCMPN
    '                    objBE.CDVSN = _CDVSN
    '                    objBE.CPLNDV = _CPLNDV
    '                    objBE.NRUCTR = cboTransportista.pRucTransportista
    '                    objBE.NPLCAC = strAcoplado
    '                    objBE.STPACP = STPACP
    '                    objBE.CULUSA = MainModule.USUARIO
    '                    objBE.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

    '                    objBLL.Modificar_Asignacion_Acoplado_Transportista(objBE)

    '                End If


    '                MessageBox.Show("Acoplado ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Exit Sub
    '            End If
    '        Else ' cambio de otra compañia
    '            Dim objCia1 As New Transportista
    '            objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
    '            objCia1.CCMPN = _CCMPN
    '            objCia1.CDVSN = _CDVSN
    '            objCia1.CPLNDV = _CPLNDV

    '            Dim olbeCia1 As New List(Of Transportista)
    '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
    '            If olbeCia1.Count = 0 Then Exit Sub

    '            objCia1 = olbeCia1.Item(0)

    '            Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
    '                                    "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
    '                                    "Compañía: " & objCia1.TCMTRT & vbCrLf & _
    '                                    "¿Desea cambiarlo a la compañía " & Me.cboTransportista.pRazonSocial & " ?"

    '            If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    '                objEntidadTA.FLAG_SKIPCHECKS = 1
    '                objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)

    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub btnNuevoAcoplado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoAcoplado.Click
    '    Try
    '        If Me.cboTransportista.pCodigoRNS.ToString.Equals("0") Then : HelpClass.MsgBox("Seleccione el transportista") : Exit Sub : End If
    '        Dim ofrmNewAcoplado As New frmNuevoAcoplado
    '        Dim obrAcoplado As New Acoplado_BLL
    '        With ofrmNewAcoplado
    '            .TIPO = Me.cboTransportista.pPropioTercero
    '            .CCMPN = _CCMPN
    '            .CDVSN = _CDVSN
    '            .CPLNDV = _CPLNDV
    '            .NRUCTR = Me.cboTransportista.pRucTransportista
    '            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Registrar_AcopladoTransportista(.NPLCAC, .STPACP)
    '                .objEntidad.CTRSPT = cboTransportista.pCodigoRNS
    '                obrAcoplado.Registrar_Acoplado_Antiguo(.objEntidad)
    '                'Cargar_Combo_Acoplado_Conductor()
    '                Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    '                obeAcoplado.pCCMPN_Compania = _CCMPN
    '                obeAcoplado.pCDVSN_Division = _CDVSN
    '                obeAcoplado.pCPLNDV_Planta = _CPLNDV
    '                obeAcoplado.pNPLCAC_NroAcoplado = .NPLCAC
    '                obeAcoplado.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '                Me.cboAcoplado.pCargar(obeAcoplado)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub btnNuevoContudtor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContudtor1.Click
    '    Try
    '        If Me.cboTransportista.pCodigoRNS.ToString.Equals("0") Then : HelpClass.MsgBox("Seleccione el transportista") : Exit Sub : End If
    '        Dim ofrmNuevoConductor As New frmNuevoConductor
    '        Dim obrConductor As New Chofer_BLL
    '        With ofrmNuevoConductor
    '            .CCMPN = _CCMPN
    '            .chkTercero.Visible = False
    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                Registrar_ConductorTransportista(.CBRCNT)
    '                .objEntidad.CTRSPT = cboTransportista.pCodigoRNS
    '                obrConductor.Registrar_Chofer_Antiguo(.objEntidad)
    '                'Cargar_Combo_Acoplado_Conductor(.CBRCNT)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub Registrar_ConductorTransportista(ByVal strConductor As String)
    '    Dim objEntidadTC As New TransportistaConductor
    '    Dim objLogica As New TransportistaConductor_BLL
    '    objEntidadTC.NRUCTR = cboTransportista.pRucTransportista
    '    objEntidadTC.CBRCNT = strConductor
    '    objEntidadTC.FECINI = HelpClass.TodayNumeric
    '    objEntidadTC.FECFIN = HelpClass.TodayNumeric
    '    objEntidadTC.TOBS = ""
    '    objEntidadTC.CUSCRT = MainModule.USUARIO
    '    objEntidadTC.FCHCRT = HelpClass.TodayNumeric
    '    objEntidadTC.HRACRT = HelpClass.NowNumeric
    '    objEntidadTC.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTC.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidadTC.POS_RUC_ANTERIOR = ""
    '    objEntidadTC.FLAG_SKIPCHECKS = 0
    '    objEntidadTC.SESTCH = ""
    '    objEntidadTC.CCMPN = _CCMPN
    '    objEntidadTC.CDVSN = _CDVSN
    '    objEntidadTC.CPLNDV = _CPLNDV

    '    Dim objExisteTC As New TransportistaConductor
    '    objExisteTC = objEntidadTC
    '    objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)


    '    If objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
    '        objEntidadTC.FLAG_SKIPCHECKS = 1
    '        objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)


    '    ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
    '        Dim objLogicaCia As New Transportista_BLL

    '        'valida q no se asigne a la misma cia q ya lo tiene
    '        If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
    '            'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
    '            If objExisteTC.SESTCH = "*" Then
    '                objEntidadTC.FLAG_SKIPCHECKS = 1
    '                objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)

    '            Else
    '                'HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Exclamation)
    '                MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)


    '                Exit Sub
    '            End If
    '        Else ' cambio de otra compañia
    '            Dim objCia1 As New Transportista
    '            objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
    '            objCia1.CCMPN = _CCMPN
    '            objCia1.CDVSN = _CDVSN
    '            objCia1.CPLNDV = _CPLNDV

    '            Dim olbeCia1 As New List(Of Transportista)
    '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
    '            If olbeCia1.Count = 0 Then Exit Sub
    '            objCia1 = olbeCia1.Item(0)
    '            'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

    '            Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
    '                                    "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
    '                                    "Compañía: " & objCia1.TCMTRT & vbCrLf & _
    '                                    "¿Desea cambiarlo a la compañía " & Me.cboTransportista.pRazonSocial & " ?"

    '            If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    '                objEntidadTC.FLAG_SKIPCHECKS = 1
    '                objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)

    '            End If

    '        End If
    '    End If

    'End Sub

    'Private Sub btnNuevoContudtor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContudtor2.Click
    '    Try
    '        If Me.cboTransportista.pCodigoRNS.ToString.Equals("0") Then : HelpClass.MsgBox("Seleccione el transportista") : Exit Sub : End If
    '        Dim ofrmNuevoConductor As New frmNuevoConductor
    '        Dim obrConductor As New Chofer_BLL
    '        With ofrmNuevoConductor
    '            .chkTercero.Visible = False
    '            .CCMPN = _CCMPN
    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                Registrar_ConductorTransportista(.CBRCNT)
    '                .objEntidad.CTRSPT = cboTransportista.pCodigoRNS
    '                obrConductor.Registrar_Chofer_Antiguo(.objEntidad)
    '                'Cargar_Combo_Acoplado_Conductor()
    '                'Cargar_Combo_Acoplado_Conductor(, .CBRCNT)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub btnNuevoTracto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTracto.Click

    '    Try
    '        If Me.cboTransportista.pCodigoRNS.ToString.Equals("0") Then : HelpClass.MsgBox("Seleccione el transportista") : Exit Sub : End If
    '        Dim obrTracto As New Tracto_BLL
    '        Dim ofrmNewTracto As New frmNuevoTracto
    '        With ofrmNewTracto
    '            .TIPO = Me.cboTransportista.pPropioTercero
    '            .CCMPN = _CCMPN
    '            .CDVSN = _CDVSN
    '            .CPLNDV = _CPLNDV
    '            .NRUCTR = Me.cboTransportista.pRucTransportista
    '            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Registrar_VehiculoTransportista(.NPLCUN, .STPVHP)
    '                .objEntidad.CTRSPT = cboTransportista.pCodigoRNS 'ctbTransportista.Codigo
    '                obrTracto.Registrar_Tracto_Antiguo(.objEntidad)
    '                Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    '                obeTracto.pCCMPN_Compania = _CCMPN
    '                obeTracto.pCDVSN_Division = _CDVSN
    '                obeTracto.pCPLNDV_Planta = _CPLNDV
    '                obeTracto.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '                obeTracto.pNPLCUN_NroPlacaUnidad = .NPLCUN
    '                cboTracto.pCargar(obeTracto)
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private RucTransportista As String

    Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged, cboTransportista.ExitFocusWithOutData
        Try
           
            Me.cboTracto.pClear()
            Me.cboAcoplado.pClear()
            Me.cmbConductor.pClear()
            Me.cmbSegundoConductor.pClear()
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            obeTracto.pCCMPN_Compania = CCMPN
            obeTracto.pCDVSN_Division = CDVSN
            obeTracto.pCPLNDV_Planta = pPlantaRelacion ' CPLNDV
            obeTracto.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            cboTracto.pCargar(obeTracto)
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
            obeAcoplado.pCCMPN_Compania = CCMPN
            obeAcoplado.pCDVSN_Division = CDVSN
            obeAcoplado.pCPLNDV_Planta = pPlantaRelacion ' CPLNDV
            obeAcoplado.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            Me.cboAcoplado.pCargar(obeAcoplado)
            'Me.Cargar_Combo_Acoplado_Conductor()

            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
            obeConductor.pCCMPN_Compania = CCMPN
            obeConductor.pPlanta = pPlantaRelacion ' CPLNDV
            obeConductor.pCDVSN = CDVSN
            obeConductor.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            cmbConductor.pCargar(obeConductor)


            Dim obeConductor2 As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
            obeConductor2.pCCMPN_Compania = CCMPN
            obeConductor2.pPlanta = pPlantaRelacion ' CPLNDV
            obeConductor2.pCDVSN = CDVSN
            obeConductor2.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
            cmbSegundoConductor.pCargar(obeConductor2)




            Me.hgReasignarRecurso.ValuesSecondary.Heading = "   "




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAsignarOSAgencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOSAgencias.Click
        Try
            Dim objfrmOSAgenciasRansa As New frmOperacionAgenciasRansaPopup
            objfrmOSAgenciasRansa.ShowDialog(Me)
            Me.txtOsAgenciasRansa.Text = objfrmOSAgenciasRansa.OrdenServio_AgenciasRansa
            Me.txtNroOperacionAgenciasRansa.Text = objfrmOSAgenciasRansa.Operacion_Agencias
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ckbOSAgenciaRansa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbOSAgenciaRansa.CheckedChanged
        Asignacion_OS_Agencia_Ransa()
    End Sub

    'Private Function Validar_Proveedor_Homologado() As String
    '    Dim objNegocio As New Solicitud_Transporte_BLL
    '    Dim objHashTable As New Hashtable
    '    objHashTable.Add("CCMPN", Me.CCMPN)
    '    objHashTable.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
    '    objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
    '    Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    'End Function


    'Private Function Validar_Proveedor_Homologado_General() As String
    '    Dim objNegocio As New Solicitud_Transporte_BLL
    '    Dim objHashTable As New Hashtable
    '    objHashTable.Add("CCMPN", Me.CCMPN)
    '    objHashTable.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
    '    objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
    '    Return objNegocio.Valida_Homologacion_GeneralTransportista(Me.CCMPN, Me.cboTransportista.pRucTransportista)
    'End Function







    'Private Sub VerPreAsignacionUnidades(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPreAsignacionUnid.Click
    '    Try

    '        Dim objForm As New frmVerPreAsignacionUnidades

    '        objForm.oListInicial.PSCCMPN = _CCMPN
    '        objForm.oListInicial.PSCDVSN = _CDVSN
    '        objForm.oListInicial.PNCPLNDV = _CPLNDV
    '        objForm.oListInicial.PNCCLNT = Val(_obj_Entidad.CCLNT)
    '        objForm.oListInicial.PNCMEDTR = lintMedioTransporte
    '        'objForm.oListInicial.PNCLCLOR = _CLCLOR
    '        'objForm.oListInicial.PNCLCLDS = _CLCLDS
    '        objForm.oListInicial.PNCLCLOR = CLCLOR
    '        objForm.oListInicial.PNCLCLDS = CLCLDS
    '        If objForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            cargar_Datos_PreAsignacion(objForm.pSeleccion.PNNRUCTR, objForm.pSeleccion.PSNPLCUN, objForm.pSeleccion.PSNPLCAC, objForm.pSeleccion.PSCBRCNT, objForm.pSeleccion.PSCBRCN2)
    '            '_NPRASG = objForm.pSeleccion.PNNPRASG 'numero de pre-asignacion
    '            NPRASG = objForm.pSeleccion.PNNPRASG 'numero de pre-asignacion
    '        Else
    '            '_NPRASG = 0
    '            NPRASG = 0
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Sub cargar_Datos_PreAsignacion(Optional ByVal trans As Long = 0, Optional ByVal tracto As String = "", Optional ByVal acoplado As String = "", Optional ByVal conductor1 As String = "", Optional ByVal conductor2 As String = "")

        'Cargar transportista
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = CCMPN
        obeTransportista.pNRUCTR_RucTransportista = trans.ToString.Trim
        cboTransportista.pCargar(obeTransportista)

        'Cargar Tracto
        cboTracto.pClear()
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = CCMPN
        obeTracto.pCDVSN_Division = CDVSN
        obeTracto.pCPLNDV_Planta = CPLNDV
        obeTracto.pNRUCTR_RucTransportista = trans.ToString.Trim
        obeTracto.pNPLCUN_NroPlacaUnidad = tracto.ToString.Trim
        Me.cboTracto.pCargar(obeTracto)

        'Cargar Acoplado
        cboAcoplado.pClear()
        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
        obeAcoplado.pCCMPN_Compania = CCMPN
        obeAcoplado.pCDVSN_Division = CDVSN
        obeAcoplado.pCPLNDV_Planta = CPLNDV
        obeAcoplado.pNRUCTR_RucTransportista = trans.ToString.Trim
        obeAcoplado.pNPLCAC_NroAcoplado = acoplado.ToString.Trim
        Me.cboAcoplado.pCargar(obeAcoplado)

        'Cargar Conductores
        Me.cmbConductor.pClear()
        Me.cmbSegundoConductor.pClear()

        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorTransportistaPK
        obeConductor.pCCMPN_Compania = CCMPN
        obeConductor.pPlanta = CPLNDV
        obeConductor.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
        obeConductor.pCBRCNT_Brevete = conductor1.ToString.Trim
        Me.cmbConductor.pCargar(obeConductor)
        'obeConductor.pNRUCTR_RucTransportista = txtTransportista.pRucTransportista

        obeConductor.pCBRCNT_Brevete = conductor2.ToString.Trim
        Me.cmbSegundoConductor.pCargar(obeConductor)

    End Sub

    'Private Sub Ver_Unidades_Programadas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnidProgramadas.Click
    '    Try

    '        Dim objFrm As New frmVerUnidadesProgramadas_Junta

    '        objFrm.pCCMPN = _CCMPN
    '        objFrm.pNUMREQT = _NUMREQT

    '        If objFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            cargar_Datos_PreAsignacion(objFrm.Entidad.NRUCTR, objFrm.Entidad.NPLCUN, objFrm.Entidad.NPLCAC, objFrm.Entidad.CBRCNT, objFrm.Entidad.CBRCN2)
    '            _Entidad_Unid_Prog = objFrm.Entidad
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub






End Class
