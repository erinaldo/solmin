Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO


Public Class frmAsignacionManualRecurso

   
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
    'Public CLCLOR As Decimal = 0
    'Public CLCLDS As Decimal = 0
    'Public NPRASG As Decimal = 0
    Public CCMPN As String = ""
    Private _Entidad_Unid_Prog As New ENTIDADES.Programacion_Unidad
    Public CDVSN As String
    Public CPLNDV As Double = 0
    Public NDCORM As Decimal = 0D
    Public PNCDTR As String = ""
    'Public CDDRSP As String = ""
    Public NOPRCN_MULTIGT As Decimal = 0
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
            'Me.ckbOSAgenciaRansa.Checked = False
            'Asignacion_OS_Agencia_Ransa()
            'If Me.CCMPN <> "EZ" Then
            '    Me.ckbOSAgenciaRansa.Visible = False
            'End If

            

            'If NDCORM > 0D Then
            '    ckbOSAgenciaRansa.Checked = True
            '    _Registro_AgenciasRansa = True
            '    Me.txtOsAgenciasRansa.Text = NDCORM
            '    Me.txtNroOperacionAgenciasRansa.Text = PNCDTR
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub Asignacion_OS_Agencia_Ransa()
    '    'FRAGMENTO DE CODIGO HARD-CODING, AGENCIAS RANSA : 22-04-2010
    '    If Me.ckbOSAgenciaRansa.Checked = True Then
    '        Me.pnlAgenciasRansa.Visible = True
    '        Me.Height = 375
    '        Me.txtOrdenServicioMineria.Text = obj_Entidad.NORSRT
    '        _Registro_AgenciasRansa = True
    '    Else
    '        Me.pnlAgenciasRansa.Visible = False
    '        Me.Height = 285
    '        Me.txtOrdenServicioMineria.Text = ""
    '        Me.txtOsAgenciasRansa.Text = ""
    '        Me.txtNroOperacionAgenciasRansa.Text = ""
    '        _Registro_AgenciasRansa = False
    '    End If
    'End Sub

   

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = CCMPN
        cboTransportista.pCargar(obeTransportista)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            Dim tipoAccion As String = ""
            If es_OS_TipoSeguimiento = True Then
                tipoAccion = "SERVICIO"
            End If
            If es_OS_TipoSeguimiento = False Then
                tipoAccion = "SEGUIMIENTO"
            End If

            'Dim estado As Int32 = 0
            Dim solicitudTransporteBL As New Solicitud_Transporte_BLL
            Dim solicitudTransporteBE As New Solicitud_Transporte
            Dim msgVal As String = ""

            If Validar_Recursos_Asignados() = True Then Exit Sub
            '--Verificación de Bloqueo Linea de Credito
            solicitudTransporteBE.NORSRT = obj_Entidad.NORSRT

            REM ECM-HUNDRED-INICIO

            ' validar Generacion De Operacion 
            Dim oblGuiaTransportista As New GuiaTransportista_BLL
            Dim msjGeneracionOp As String = String.Empty
            Dim oFiltro As New Hashtable
            oFiltro.Add("NCSOTR", obj_Entidad.NCSOTR)
            oFiltro.Add("NORSRT", obj_Entidad.NORSRT)
            oFiltro.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
            oFiltro.Add("TRACTO", cboTracto.pNroPlacaUnidad)
            oFiltro.Add("ACOPLADO", cboAcoplado.pNroAcoplado)


            msjGeneracionOp = oblGuiaTransportista.validarGeneracionDeOperacion(oFiltro)
            msjGeneracionOp = msjGeneracionOp.Trim
            If msjGeneracionOp.Trim.Length > 0 Then
                MessageBox.Show(msjGeneracionOp, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Select Case tipoAccion
                Case "SERVICIO"

                    Dim mensaje As String = oSeguridad.VerificarLineaCreditoCliente(CCMPN, lstr_codigo_cliente)
                    If mensaje.ToString() <> "" Then
                        MessageBox.Show(mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    '-- Validación Homologación Proveedores
                    If Me.lintMedioTransporte = 4 Then
                        strResultado = Validar_Proveedor_Homologado()
                        If strResultado.Trim <> "" Then
                            HelpClass.MsgBox("Advertencia : " & strResultado, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

            End Select

            'If Me._Registro_AgenciasRansa = True Then
            '    If Me.txtOsAgenciasRansa.Text = "" Then
            '        HelpClass.MsgBox("Debe seleccionar una orden de servicio de Agencias Ransa")
            '        Exit Sub
            '    End If
            'End If

            Dim intResult As Integer = 0
            intResult = solicitudTransporteBL.Validar_Unidades_Atendidas(Me._obj_Entidad.NCSOTR, Me._obj_Entidad.CCMPN)

            Select Case intResult
                Case 0
                    HelpClass.MsgBox("La Solicitud N° " & Me._obj_Entidad.NCSOTR & " tiene sus unidades asignadas completas", MessageBoxIcon.Information)
                    Exit Sub
                Case 1
                    Dim objOperacionTransporte As New OperacionTransporte_BLL
                    Dim msg As String = ""
                   
                    Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
                    oFiltroRecurso.CCMPN = Me.CCMPN
                    oFiltroRecurso.NOPRCN = Me.NOPRCN_MULTIGT
                    oFiltroRecurso.NRUCTR = Me.cboTransportista.pRucTransportista
                    oFiltroRecurso.NPLCUN = cboTracto.pNroPlacaUnidad.Trim
                    oFiltroRecurso.NPLCAC = cboAcoplado.pNroAcoplado
                    oFiltroRecurso.CBRCNT = cmbConductor.pBrevete
                    oFiltroRecurso.CBRCN2 = cmbSegundoConductor.pBrevete
                    oFiltroRecurso.QPLNPL = Val(txtnro_viajes.Text.Trim)
                    oFiltroRecurso.CULUSA = MainModule.USUARIO

                    Dim msgError As String = ""
                    Dim dt As New DataTable
                    dt = objOperacionTransporte.Registrar_Recurso_Planeamiento_Operacion(oFiltroRecurso, msgError)
                    If msgError.Length > 0 Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If


                    If tipoAccion = "SERVICIO" Then

                        Dim pNCRRPL As Decimal = 0
                        Dim pNSBCRP As Decimal = 0
                        If dt.Rows.Count > 0 Then
                            pNCRRPL = dt.Rows(0)("NCRRPL")
                            pNSBCRP = dt.Rows(0)("NSBCRP")
                        End If
                        'Me.Generar_Orden_Interna(NOPRCN_MULTIGT)

                        Dim msg_oi As String = ""
                        oFiltroRecurso = New ENTIDADES.Operaciones.OperacionTransporte
                        oFiltroRecurso.NOPRCN = NOPRCN_MULTIGT
                        oFiltroRecurso.NCRRPL = pNCRRPL
                        oFiltroRecurso.NSBCRP = pNSBCRP
                        oFiltroRecurso.CULUSA = MainModule.USUARIO
                        oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

                        Dim objOrdenInterna As New OrdenInterna_BLL
                        Dim orptaOI As New ENTIDADES.beRespuestaOperacion
                        orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)

                        If msg_oi.Length > 0 Then
                            MessageBox.Show("No se generó Orden Interna", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    End If
                    'Me.Registrar_Operacion_Transporte()
                    

                Case 2
                    HelpClass.MsgBox("La Solicitud N° " & Me._obj_Entidad.NCSOTR & " está anulada", MessageBoxIcon.Information)
                    Exit Sub
            End Select
        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub



 


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

    'Private Sub Registrar_Operacion_Transporte()
    '    'Private Sub Registrar_Operacion_Transporte(ByVal intEstado As Int32)
    '    Try
    '        Dim objEntidad As New List(Of String)
    '        Dim objOperacionTransporte As New OperacionTransporte_BLL
    '        Dim lstr_resultado As String = ""
    '        Dim objListaTemporal As New List(Of String)

    '        objEntidad.Add(Me._obj_Entidad.NPLNJT)
    '        objEntidad.Add(Me._obj_Entidad.NCRRPL)
    '        objEntidad.Add(Me._obj_Entidad.NCSOTR)
    '        objEntidad.Add(Me._obj_Entidad.NCRRSR)
    '        objEntidad.Add(Me._obj_Entidad.NORSRT)
    '        objEntidad.Add(Me._obj_Entidad.CCMPN)
    '        objEntidad.Add(Me._obj_Entidad.CDVSN)
    '        objEntidad.Add(Me._obj_Entidad.CPLNDV)
    '        objEntidad.Add(MainModule.USUARIO)
    '        objEntidad.Add(HelpClass.TodayNumeric)
    '        objEntidad.Add(HelpClass.NowNumeric)
    '        objEntidad.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
    '        objEntidad.Add("NUEVO")
    '        objEntidad.Add(IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), "", "A"))
    '        objEntidad.Add(IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), 0, Me.txtOsAgenciasRansa.Text))
    '        objEntidad.Add(Me.txtNroOperacionAgenciasRansa.Text)
    '        objEntidad.Add(HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value))
    '        objEntidad.Add(Me._obj_Entidad.CTPOVJ)

    '        lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
    '        If IsNumeric(lstr_resultado) Then
    '            If lstr_resultado.Trim.Equals("-1") OrElse lstr_resultado.Trim.Equals("0") Then
    '                HelpClass.ErrorMsgBox()
    '                Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '                Exit Sub
    '            Else


    '                Dim objBLL As New Solicitud_Transporte_BLL



    '                If es_OS_TipoSeguimiento = False Then
    '                    lll()
    '                    Me.Generar_Orden_Interna(CType(lstr_resultado, Double))


    '                End If



    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '            End If
    '        Else
    '            HelpClass.MsgBox(lstr_resultado, MessageBoxIcon.Error)
    '            Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '        End If

    '    Catch ex As Exception
    '        HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
    '        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '    End Try
    'End Sub

   
 
    'Private Sub Generar_Orden_Interna(ByVal pNOPRCN As Double, pNCRRPL As Decimal, pNSBCRP As Decimal)
    '    Dim objOrdenInterna As New OrdenInterna_BLL
    '    'Dim objEntidad As New Planeamiento
    '    'Dim objParametros As New List(Of String)
    '    Try
    '        'objParametros.Add(ldbl_NOPRCN)
    '        'objParametros.Add(MainModule.USUARIO)
    '        'objParametros.Add(HelpClass.TodayNumeric)
    '        'objParametros.Add(HelpClass.NowNumeric)
    '        'objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)

    '        'objParametros.Add(Me.cboTracto.pNroPlacaUnidad)
    '        'objParametros.Add(Me.cboAcoplado.pNroAcoplado)


    '        'objParametros.Add(Me.cmbConductor.pBrevete)
    '        'objParametros.Add(Me._obj_Entidad.CCMPN)

    '        Dim msg As String = ""
    '        Dim oFiltro As New ENTIDADES.Operaciones.OperacionTransporte
    '        oFiltro.NOPRCN = pNOPRCN
    '        oFiltro.NCRRPL = pNCRRPL
    '        oFiltro.NSBCRP = pNSBCRP
    '        oFiltro.CULUSA = MainModule.USUARIO
    '        oFiltro.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

    '        msg = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltro)

    '        If msg.Length > 0 Then
    '            MessageBox.Show("No se generó Orden Interna", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Return
    '        End If


    '        'If (objEntidad.OI_SAP = 0) Then
    '        '    MessageBox.Show("No se generó Orden Interna", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '    Return
    '        'End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    

#End Region

 
    Private RucTransportista As String

    Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged, cboTransportista.ExitFocusWithOutData
        Try
            Select Case Me.lintMedioTransporte
                Case 1, 4, 5
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


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAsignarOSAgencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objfrmOSAgenciasRansa As New frmOperacionAgenciasRansaPopup
            objfrmOSAgenciasRansa.ShowDialog(Me)
            'Me.txtOsAgenciasRansa.Text = objfrmOSAgenciasRansa.OrdenServio_AgenciasRansa
            'Me.txtNroOperacionAgenciasRansa.Text = objfrmOSAgenciasRansa.Operacion_Agencias
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub ckbOSAgenciaRansa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Asignacion_OS_Agencia_Ransa()
    'End Sub

    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", Me.CCMPN)
        objHashTable.Add("NRUCTR", Me.cboTransportista.pRucTransportista)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

    
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

   






End Class
