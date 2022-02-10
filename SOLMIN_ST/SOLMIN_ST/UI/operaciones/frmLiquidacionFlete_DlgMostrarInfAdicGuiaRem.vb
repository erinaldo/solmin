Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Public Class frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem
#Region " Atributos "
    Private pCCMPN As String = ""
    Private pCDVSN As String = ""
    Private pNOPRCN As Int64 = 0
    Private pNGUITR As Int64 = 0
    Private pSESTRG As String = ""
    Private pSESGRP As String = ""
    Public frmInvocado As String = ""
    Public frmInvocadoNombre As String = ""

    Public pEstado As String = ""
    Public pCRGVTA As String = ""



    Private pRucProveedor As String = ""
    Private pEstadoMrgAprobacion As String = ""
    Public pPostLiquidacion As String = ""
    Private pEstadoEstimacion As String = ""
    Private pbeAutorizacionLiq As New beAutorizacionLiquidacion
    Private nro_valorizacion As Decimal = 0
#End Region
#Region " Propiedades "
    

    Public PSStatusLiquidacion_SESGRP As String = ""
   
    '----- Ini -----
    Public pMONEDA_OS As Decimal = 0




#End Region
#Region " Procedimientos y Funciones "
    'Private Sub Listar_GRemHijasCargadasGTranspLiq()
    '    Dim oFiltro As New TD_GRemHijasCargadasGTranspLiqPK
    '    Dim oGuiaTransportista As New GuiaTransportista_BLL

    '    dtGRemHijasCargGTransLiq.AutoGenerateColumns = False


    '    oFiltro.pNOPRCN_NroOperacion = pNOPRCN
    '    oFiltro.pNGUITR_GuiaRemisionCargada = pNGUITR
    '    oFiltro.pCCMPN_Compania = pCCMPN

    '    Dim oList As New List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
    '    oList = oGuiaTransportista.Listar_GRemHijasCargadasGTranspLiquidacion(oFiltro)

    '    dtGRemHijasCargGTransLiq.DataSource = oList

    'End Sub

    Private Sub Listar_ServGRemCargadasGTranspLiq()
        Dim oFiltro As New TD_GRemServCargadasGTranspLiqPK
        Dim oGuiaTransportista As New GuiaTransportista_BLL





        oFiltro.pNOPRCN_NroOperacion = pNOPRCN
        oFiltro.pNGUITR_NroGuiaRemision = pNGUITR
        oFiltro.pCCMPN_Compania = pCCMPN

        Dim oList As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
        oList = oGuiaTransportista.Listar_GRemServCargadasGTranspLiquidacion(oFiltro)

        dtServGRemCargGTransLiq.DataSource = oList
        

    End Sub
#End Region
#Region " Eventos "

    Private Function fblnValidarRevertirOperacionEstimada() As Boolean

        'Private Function fblnValidarProvision(ByVal obeOrdenServicioTransporte) As Boolean
        '================verificamos si la liquidación esta provisionada
        'Dim intResultado As Integer = 0
        'Dim obrOrdenServicio As New SOLMIN_ST.NEGOCIO.Operaciones.OrdenServicio_BLL

        'intResultado = obrOrdenServicio.intTieneProvision(obeOrdenServicioTransporte)
        'If intResultado = 2 Then
        '    If obrOrdenServicio.fblnUsuarioPermitidoRevertirProvision(MainModule.USUARIO) Then
        '        If MsgBox("La Operación :" & obeOrdenServicioTransporte.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '            Return True
        '        End If
        '    Else
        '        'Usuario No puede Generar un revisado o Eliminar la provisión
        '        MsgBox("Usted no tiene  autorización para administrar la Operación :" & obeOrdenServicioTransporte.NOPRCN & " porque se encuentra provisionada.")
        '        Return True
        '    End If
        'End If

        If pEstadoEstimacion = "P" Then
            If pbeAutorizacionLiq.RevertirOperacionEstimada = "X" Then
                If MessageBox.Show("La Operación :" & pNOPRCN & " está estimada, desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                    Return True
                End If
            Else
                'Usuario No puede Generar un revisado o Eliminar la provisión
                MessageBox.Show("No cuenta con autorización para administrar la Operación :" & pNOPRCN & " porque se encuentra estimada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True

            End If
        End If


        '=================verificamos si la liquidación esta provisionada
        Return False
    End Function
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub



    'Private Function TieneRegistroActualServiciosEnRSAP12() As Boolean
    '    Dim Objeto_LogicaVal As New GuiaTransportista_BLL
    '    Dim dtServicioSAP As New DataTable
    '    Dim TieneServicios As Boolean = False
    '    Dim oHasParm As New Hashtable
    '    oHasParm("CCMPN") = Me.pCCMPN
    '    oHasParm("CDVSN") = Me.pCDVSN
    '    oHasParm("NLQDCN") = Val("" & dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value)
    '    oHasParm("NGUITR") = Val("" & dtServGRemCargGTransLiq.CurrentRow.Cells("S_NGUITR").Value)
    '    oHasParm("NCRRGU") = Val("" & dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value)
    '    oHasParm("CSRVC") = Val("" & dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value)
    '    oHasParm("NOPRCN") = pNOPRCN
    '    dtServicioSAP = Objeto_LogicaVal.Listar_servicios_liquidacion_servicios_sap(oHasParm)
    '    If dtServicioSAP.Rows.Count > 0 Then
    '        TieneServicios = True
    '    End If
    '    Return TieneServicios
    'End Function

    Private Sub btnEliminarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServLiqu.Click

        Try
            'JMC--------------
            'If pEstadoAprobMargen.Equals("P") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'ElseIf pEstadoAprobMargen.Equals("A") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            Select Case pEstadoMrgAprobacion
                Case "P"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case "A"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select

            '-----------------------------

            If dtServGRemCargGTransLiq.RowCount <= 0 Then
                MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If dtServGRemCargGTransLiq.CurrentRow.Cells("SFCTOP_SERV").Value = "F" Then
                MessageBox.Show("No se puede eliminar. La operación se encuentra facturada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Dim TieneServicioSAP12 As Boolean = False
            'TieneServicioSAP12 = TieneRegistroActualServiciosEnRSAP12()
            'If TieneServicioSAP12 = True Then
            '    MessageBox.Show("No se puede eliminar." & Chr(13) & "El servicio se encuentra liquidado(SAP).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            If dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value > 0 Then
                MessageBox.Show("No se puede eliminar. El servicio se encuentra liquidado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'NLQDCN

            '=============Validamos esta de provisión de la operación
            'Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
            'With obeOrdenServicioTransporte
            '    .CCMPN = Me.pCCMPN
            '    .CDVSN = pCDVSN
            '    .NLQDCN = 0
            '    .NOPRCN = pNOPRCN
            '    .TIPO = 2
            'End With
            'If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
            '============Aquí validación anulacion tarifa interna
            If fblnValidarRevertirOperacionEstimada() Then Exit Sub
         

            If fblnValidarRevertirOperacionValorizada() = False Then Exit Sub

            '=============Validamos esta de provisión de la operación
            Dim strMsjDetraccion As String = ""
            If dtServGRemCargGTransLiq.CurrentRow.Cells("VLRFDT").Value > 0 Then
                strMsjDetraccion = "El servicio a eliminar tiene detracción referencial de la operación (S/. " & dtServGRemCargGTransLiq.CurrentRow.Cells("VLRFDT").Value.ToString.Trim & "). "
            End If
            If MessageBox.Show(strMsjDetraccion & "¿Desea eliminar el registro?", "Mensaje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim oInfLiquServ As TD_Obj_GRemLiquServCargadasGTranspLiqPK = New TD_Obj_GRemLiquServCargadasGTranspLiqPK
            With oInfLiquServ
                .pNOPRCN_NroOperacion = pNOPRCN
                .pNGUITR_NroGuiaRemision = pNGUITR
                .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                .pMMCUSR_Usuario = MainModule.USUARIO
                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                .pCCMPN_Compania = Me.pCCMPN



              
 


            End With

            Dim Objeto_Logica As New GuiaTransportista_BLL

            Dim oInfoLog As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
            With oInfoLog
                .pNOPRCN_NroOperacion = pNOPRCN
                .pNGUITR_NroGuiaRemision = pNGUITR
                .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                .pMMCUSR_Usuario = MainModule.USUARIO
                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina

            End With
            'Dim Observacion As String = frmInvocadoNombre & "-" & "ELIM"
            Dim Observacion As String = "ELIM-SERV"
            Objeto_Logica.Grabar_Log_Servicio(oInfoLog, Observacion, "M")

            ' Instanceamos la clase de procesos

            'Dim sMensajeError As String = ""
            Objeto_Logica.Eliminar_LiquServGuiaRemisionLiqTransp(oInfLiquServ)
           




            Call Listar_ServGRemCargadasGTranspLiq()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub btnLiqServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiqServ.Click

        Try
            'JMC----------------------
            'If pEstadoAprobMargen.Equals("P") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'ElseIf pEstadoAprobMargen.Equals("A") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Select Case pEstadoMrgAprobacion
                Case "P"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case "A"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select

            '------------------------
            If dtServGRemCargGTransLiq.RowCount <= 0 Then
                MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If



            '******************************
            'se verifica si el proveedor ya se encuentra liquidado
            '(se encuetra en rsap12.Si es el caso no se puede modificar
            'Dim tieneLiqSAP As Boolean = False
            'tieneLiqSAP = TieneRegActualLiquidacionSAP()
            'If tieneLiqSAP = True Then
            '    MessageBox.Show("No se puede modificar.El servicio se encuentra liquidado(SAP)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            If dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value > 0 Then
                MessageBox.Show("No se puede modificar.El servicio se encuentra liquidado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'NLQDCN

            '******************************

            '=============Validamos esta de provisión de la operación
            'Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
            'With obeOrdenServicioTransporte
            '    .CCMPN = Me.pCCMPN
            '    .CDVSN = pCDVSN
            '    .NLQDCN = 0
            '    .NOPRCN = pNOPRCN
            '    .TIPO = 2
            'End With
            'If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub

            If fblnValidarRevertirOperacionEstimada() Then Exit Sub
            '=============Validamos esta de provisión de la operación

            Dim oInfLiquServ As TD_Obj_GRemLiquServCargadasGTranspLiq = New TD_Obj_GRemLiquServCargadasGTranspLiq
            With oInfLiquServ
                .pNOPRCN_NroOperacion = pNOPRCN
                .pNGUITR_NroGuiaRemision = pNGUITR
                .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                .pCSRVC_Servicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value
                .pTCMTRF_DetalleServicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_TCMTRF").Value
                .pCMNLQT_Moneda = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CMNLQT").Value
                .pILQDTR_ImporteLiquidacionTransp = dtServGRemCargGTransLiq.CurrentRow.Cells("S_ILQDTR").Value
                .pQCNDLG_CantidadServicioLiquidacion = dtServGRemCargGTransLiq.CurrentRow.Cells("S_QCNDLG").Value
                .pCUNDTR_Unidad = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CUNDTR").Value
                .pSLQDTR_StatusLiquTransporte = dtServGRemCargGTransLiq.CurrentRow.Cells("S_SLQDTR").Value
                .pMMCUSR_Usuario = MainModule.USUARIO
                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                .pCCMPN_Compania = Me.pCCMPN


                '----- Ini -----
                .pMONEDA_OS = pMONEDA_OS

                '----- Fin -----

            End With
            Dim fTemp As frmLiquidacionFlete_DlgLiquServicio = New frmLiquidacionFlete_DlgLiquServicio(oInfLiquServ)
            fTemp.pbeAutorizacionLiq = pbeAutorizacionLiq
            fTemp.pFlagTarifaOS = dtServGRemCargGTransLiq.CurrentRow.Cells("Flag_TarifaOS").Value.ToString.Trim

            If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
                oInfLiquServ = fTemp.pInformacionServicio
                ' Instanceamos la clase de procesos
                Dim Objeto_Logica As New GuiaTransportista_BLL


                '---------------------Valida el Servicio actual  JMC ----------------
                If frmInvocado = "X" Or frmInvocado = "L" Then
                    Dim oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
                    With oInfServ
                        .pCMNLQT_Moneda = oInfLiquServ.pCMNLQT_Moneda
                        .pILQDTR_ImporteLiquidacionTransp = oInfLiquServ.pILQDTR_ImporteLiquidacionTransp
                        .pQCNDLG_CantidadServicioLiquidacion = oInfLiquServ.pQCNDLG_CantidadServicioLiquidacion
                        .pSLQDTR_StatusLiquTransporte = oInfLiquServ.pSLQDTR_StatusLiquTransporte
                    End With
                    'Validar_Modificacion(pNOPRCN, pNGUITR, oInfServ, "M")

                End If
                '---------------------JMC--fin---------------------------------------------------- 
                Objeto_Logica.Registrar_LiquServGuiaRemisionLiqTransp(oInfLiquServ)

                'Dim Observacion As String = frmInvocadoNombre & "-" & "MODIF-LIQ"
                Dim Observacion As String = "MODIF-PAGO"

                'Dim obeLog As New TD_Obj_GRemAgregarServCargadasGTranspLiq
                'With (obeLog)
                '    .pNOPRCN_NroOperacion = oInfLiquServ.pNOPRCN_NroOperacion
                '    .pNGUITR_NroGuiaRemision = oInfLiquServ.pNGUITR_NroGuiaRemision
                '    .pNCRRGU_CorrServ = oInfLiquServ.pNCRRGU_CorrServ
                '    .pCSRVC_Servicio = oInfLiquServ.pCSRVC_Servicio
                '    .pCMNDGU_MonedaGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CMNDGU").Value
                '    .pISRVGU_importeServicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_ISRVGU").Value
                '    .pQCNDTG_CantServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_QCNDTG").Value
                '    .pSFCTTR_StatusFacturado = dtServGRemCargGTransLiq.CurrentRow.Cells("S_SFCTTR").Value
                '    .pSLQDTR_StatusLiquTransporte = .pSLQDTR_StatusLiquTransporte
                '    .pCMNLQT_Moneda = oInfLiquServ.pCMNLQT_Moneda
                '    .pILQDTR_ImporteLiquidacionTransp = oInfLiquServ.pILQDTR_ImporteLiquidacionTransp
                '    .pQCNDLG_CantidadServicioLiquidacion = oInfLiquServ.pQCNDLG_CantidadServicioLiquidacion
                '    .pMMCUSR_Usuario = MainModule.USUARIO
                '    .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                '    .pSESTRG = "A"
                'End With


                Dim oInLog As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
                oInLog.pNOPRCN_NroOperacion = pNOPRCN
                oInLog.pNGUITR_NroGuiaRemision = pNGUITR
                oInLog.pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                oInLog.pMMCUSR_Usuario = MainModule.USUARIO
                oInLog.pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                oInLog.pCCMPN_Compania = Me.pCCMPN

                Objeto_Logica.Grabar_Log_Servicio(oInLog, Observacion, "M")


                Listar_ServGRemCargadasGTranspLiq()

                'DDDD()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtServGRemCargGTransLiq.AutoGenerateColumns = False

            Dim oFacturaNeg As New Factura_Transporte_BLL


            Select Case pSESTRG
                Case "F"
                    Me.ToolStrip1.Visible = False
                Case "L"

                    Me.btnLiqServ.Visible = False


            End Select


            If frmInvocado = "X" Then
                Me.ToolStrip1.Visible = False
            End If


            Call Listar_ServGRemCargadasGTranspLiq()
            'Call Listar_GRemHijasCargadasGTranspLiq()
            Validar_Acceso_Opciones_Usuario()

            ' Listar_Estado_Operacion_Guia

            Dim Objeto_Logica As New GuiaTransportista_BLL
            Dim dtDatosEstadoOP As New DataTable
            'Dim objParamGuia As New Hashtable
            ''objParamGuia.Add("CCMPN", Me.pCCMPN)
            ''objParamGuia.Add("CDVSN", Me.pCDVSN)
            ''objParamGuia.Add("NOPRCN", pNOPRCN)
            ''objParamGuia.Add("NGUITR ", pNGUITR)
            dtDatosEstadoOP = Objeto_Logica.Listar_Estado_Operacion_Guia(pNOPRCN, pNGUITR)
            If dtDatosEstadoOP.Rows.Count > 0 Then
                pRucProveedor = ("" & dtDatosEstadoOP.Rows(0)("RUC_PROV")).ToString.Trim
                pEstadoMrgAprobacion = ("" & dtDatosEstadoOP.Rows(0)("ESTADO_MRG_APROB")).ToString.Trim
                If pPostLiquidacion = "SI" Then
                    pEstadoMrgAprobacion = ""
                End If
                pEstadoEstimacion = ("" & dtDatosEstadoOP.Rows(0)("ESTADO_ESTIMACION")).ToString.Trim
                nro_valorizacion = dtDatosEstadoOP.Rows(0)("NRO_VALORIZACION")
             

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        'Dim objEntidad As New ClaseGeneral
        'Dim oList As New List(Of beAutorizacion)
        Dim dt As New DataTable
        'Dim obeAutorizacionLiq As New beAutorizacionLiquidacion

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("NCROPC", 15)

        'objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        dt = objLogica.Listar_Autorizacion_Usuario_X_NroOPC(objParametro)
        Dim cod_accion As String = ""
        If dt.Rows.Count > 0 Then
            For Each item As DataRow In dt.Rows
                cod_accion = ("" & item("COD_ACCION")).ToString.Trim
                Select Case cod_accion
                    Case "0010"
                        pbeAutorizacionLiq.RevertirOperacionEstimada = "X"
                    Case "0011"
                        pbeAutorizacionLiq.ModifTarifaOS = "X"
                    Case "0012"
                        pbeAutorizacionLiq.RevertirOperacionValorizada = "X"
                End Select
            Next
        End If

        'For Each item As DataRow In dt.Rows
        '    'If item("COD_ACCION") = "V" Then
        '    '    obeAutorizacionLiq.Visualizar = "X"
        '    'End If
        '    'If item("COD_ACCION") = "M" Then
        '    '    obeAutorizacionLiq.Modificar = "X"
        '    'End If
        '    'If item("COD_ACCION") = "A" Then
        '    '    obeAutorizacionLiq.Adicionar = "X"
        '    'End If
        '    'If item("COD_ACCION") = "E" Then
        '    '    obeAutorizacionLiq.Eliminar = "X"
        '    'End If
        '    If item("COD_ACCION") = "0011" Then
        '        obeAutorizacionLiq.ModifTarifaOS = "X"
        '    End If
        'Next


    End Sub





    'Private Function ObtenerRUCViaje() As String
    '    Dim Objeto_Logica As New GuiaTransportista_BLL
    '    Dim dtDatosGuiaOperacion As New DataTable
    '    Dim objParamGuia As New Hashtable
    '    objParamGuia.Add("CCMPN", Me.pCCMPN)
    '    objParamGuia.Add("CDVSN", Me.pCDVSN)
    '    objParamGuia.Add("NOPRCN", pNOPRCN)
    '    objParamGuia.Add("NGUITR ", pNGUITR)
    '    dtDatosGuiaOperacion = Objeto_Logica.Listar_Datos_Guia_Cargada(objParamGuia)
    '    Dim RUC_VIAJE As String = ""
    '    If dtDatosGuiaOperacion.Rows.Count > 0 Then
    '        RUC_VIAJE = ("" & dtDatosGuiaOperacion.Rows(0)("RUC_SERV")).ToString.Trim
    '        If RUC_VIAJE.Length = 0 Then
    '            RUC_VIAJE = ("" & dtDatosGuiaOperacion.Rows(0)("NRUCTR_VJE")).ToString.Trim
    '        End If
    '    End If
    '    Return RUC_VIAJE

    '    ssss()
    'End Function
    Private Sub btnAgregarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarServ.Click

        Try

            'JMC----------------------------
            'If pEstadoAprobMargen.Equals("P") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'ElseIf pEstadoAprobMargen.Equals("A") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If


            Select Case pEstadoMrgAprobacion
                Case "P"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case "A"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select

            '---------------------------------
            Dim oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq

            If dtServGRemCargGTransLiq.Rows.Count > 0 Then
                If dtServGRemCargGTransLiq.Rows(0).Cells("SFCTOP_SERV").Value = "F" Then
                    MessageBox.Show("No se puede adicionar. La operación se encuentra facturada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            With oInfServ
                .pNOPRCN_NroOperacion = pNOPRCN
                .pNGUITR_NroGuiaRemision = pNGUITR
                .pMMCUSR_Usuario = MainModule.USUARIO
                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                .pCCMPN_Compania = Me.pCCMPN
                '.pNRUCTR_RucProveedor = ObtenerRUCViaje()
                .pNRUCTR_RucProveedor = pRucProveedor
            End With

            'Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
            'With obeOrdenServicioTransporte
            '    .CCMPN = Me.pCCMPN
            '    .CDVSN = pCDVSN
            '    .NLQDCN = 0
            '    .NOPRCN = pNOPRCN
            '    .TIPO = 2
            'End With
            'If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub

            If fblnValidarRevertirOperacionEstimada() Then Exit Sub

            If fblnValidarRevertirOperacionValorizada() = False Then Exit Sub



            Dim fTemp As frmLiquidacionFlete_DlgAgregarServicio = New frmLiquidacionFlete_DlgAgregarServicio(pCCMPN, pCDVSN, oInfServ, Me.pSESTRG, "A", pCRGVTA)

            fTemp.PSStatusLiquidacion = PSStatusLiquidacion_SESGRP

            If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
                oInfServ = fTemp.pInformacionServicio

                Dim NCRRGU As Decimal = 0
                Dim Objeto_Logica As New GuiaTransportista_BLL
                Objeto_Logica.Agregar_GRemServProCargadasGTranspLiq(oInfServ, NCRRGU)
                'If frmInvocado = "X" Or frmInvocado = "L" Then

                'Dim oInLog As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
                'oInLog.pNOPRCN_NroOperacion = pNOPRCN
                'oInLog.pNGUITR_NroGuiaRemision = pNGUITR
                'oInLog.pNCRRGU_CorrServ = NCRRGU
                'oInLog.pMMCUSR_Usuario = MainModule.USUARIO
                'oInLog.pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                'oInLog.pCCMPN_Compania = Me.pCCMPN
                Dim oInLog As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
                oInLog.pNOPRCN_NroOperacion = pNOPRCN
                oInLog.pNGUITR_NroGuiaRemision = pNGUITR
                oInLog.pNCRRGU_CorrServ = NCRRGU
                oInLog.pMMCUSR_Usuario = MainModule.USUARIO
                oInLog.pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                oInLog.pCCMPN_Compania = Me.pCCMPN
                'Dim Observacion As String = frmInvocadoNombre & "-" & "NUEVO"
                Dim Observacion As String = "NUEVO-SERV"
                Objeto_Logica.Grabar_Log_Servicio(oInLog, Observacion, "N")
                'End If
                Call Listar_ServGRemCargadasGTranspLiq()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function fblnValidarRevertirOperacionValorizada() As Boolean
        Dim EsValido As Boolean = True

        'Dim obrOrdenServicio As New SOLMIN_ST.NEGOCIO.Operaciones.OrdenServicio_BLL
        'Dim obeOSValorizacion As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
        'obeOSValorizacion.CCMPN = Me.pCCMPN
        'obeOSValorizacion.NOPRCN = pNOPRCN
        'obeOSValorizacion.NGUITR = 0
        'obeOSValorizacion.NGUIRM = pNGUITR
        'obeOSValorizacion.CULUSA = MainModule.USUARIO
        'Dim dtOPValorizada As New DataTable
        'Dim TieneAccesoAccionOPValorizada As Boolean = False
        'dtOPValorizada = obrOrdenServicio.Listar_operacion_Valorizada(obeOSValorizacion)
        'If dtOPValorizada.Rows.Count > 0 Then
        '    TieneAccesoAccionOPValorizada = obrOrdenServicio.TieneAccesoAccionOperacionesValorizadas(obeOSValorizacion)
        '    If TieneAccesoAccionOPValorizada = True Then
        '        If MessageBox.Show("La operación se encuentra valorizada con Nro " & dtOPValorizada.Rows(0)("NROVLR") & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        '            EsValido = False
        '        Else
        '            EsValido = True
        '        End If
        '    Else
        '        MessageBox.Show("La operación se encuentra valorizada con Nro " & dtOPValorizada.Rows(0)("NROVLR") & Chr(13) & " No tiene permiso para ejecutar la acción.")
        '        EsValido = False
        '    End If
        'End If



        If nro_valorizacion > 0 Then

            If pbeAutorizacionLiq.RevertirOperacionValorizada = "X" Then
                If MessageBox.Show("La operación se encuentra valorizada con Nro " & nro_valorizacion & Chr(13) & "Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    EsValido = False
                Else
                    EsValido = True
                End If
            Else
                MessageBox.Show("La operación se encuentra valorizada con Nro " & nro_valorizacion & Chr(13) & " No tiene permiso para ejecutar la acción.")
                EsValido = False
            End If
        End If


        Return EsValido
    End Function

    'Private Function TieneRegActualLiquidacionSAP() As Boolean
    '    Dim Objeto_LogicaVal As New GuiaTransportista_BLL
    '    Dim dtLiquidacionSAP As New DataTable
    '    Dim TieneLiqSAP As Boolean = False
    '    Dim oHasParm As New Hashtable
    '    oHasParm("CCMPN") = Me.pCCMPN
    '    oHasParm("CDVSN") = Me.pCDVSN
    '    oHasParm("NLQDCN") = Val("" & dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value)
    '    dtLiquidacionSAP = Objeto_LogicaVal.Listar_servicios_liquidacion_sap_validacion(oHasParm)
    '    If dtLiquidacionSAP.Rows.Count > 0 Then
    '        TieneLiqSAP = True
    '    End If
    '    Return TieneLiqSAP

    'End Function



    Private Sub btnModificarServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarServ.Click

        Try
            'JMC --------------------------------
            'If pEstadoAprobMargen.Equals("P") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'ElseIf pEstadoAprobMargen.Equals("A") Then
            '    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Select Case pEstadoMrgAprobacion
                Case "P"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra por aprobar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case "A"
                    MessageBox.Show("No puede realizar la acción. La operación se encuentra aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
            End Select

            '-------------------------------
            If dtServGRemCargGTransLiq.RowCount <= 0 Then
                MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '=============Validamos esta de provisión de la operación
            'Dim obeOrdenServicioTransporte As New SOLMIN_ST.ENTIDADES.Operaciones.OrdenServicioTransporte
            'With obeOrdenServicioTransporte
            '    .CCMPN = Me.pCCMPN
            '    .CDVSN = pCDVSN
            '    .NLQDCN = 0
            '    .NOPRCN = pNOPRCN
            '    .TIPO = 2
            'End With

            If dtServGRemCargGTransLiq.CurrentRow.Cells("SFCTOP_SERV").Value = "F" Then
                MessageBox.Show("No se puede modificar. La operación se encuentra facturada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
            If fblnValidarRevertirOperacionEstimada() Then Exit Sub
            If fblnValidarRevertirOperacionValorizada() = False Then Exit Sub

            Dim PuedeModificarProveedor As Boolean = True
            Dim PuedeModificarServicio As Boolean = True
            '******************************
            'se verifica si el proveedor ya se encuentra liquidado
            '(se encuetra en rsap12.Si es el caso no se puede modificar
            'Dim tieneLiqSAP As Boolean = False
            'tieneLiqSAP = TieneRegActualLiquidacionSAP()
            'If tieneLiqSAP = True Then
            '    PuedeModificarProveedor = False
            'End If

            '******************************

            'Dim tieneLiqServiciosSAP As Boolean = False
            'tieneLiqServiciosSAP = TieneRegistroActualServiciosEnRSAP12()
            'If tieneLiqServiciosSAP = True Then
            '    PuedeModificarProveedor = False
            '    PuedeModificarServicio = False
            'End If

            If dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value > 0 Then
                PuedeModificarProveedor = False
                PuedeModificarServicio = False
            End If



            '=============Validamos esta de provisión de la operación

            Dim oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
            With oInfServ
                .pNOPRCN_NroOperacion = pNOPRCN
                .pNGUITR_NroGuiaRemision = pNGUITR
                .pNLQDCN_NroLiquidacion = dtServGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value
                .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                .pNRUCTR_RucProveedor = dtServGRemCargGTransLiq.CurrentRow.Cells("NRUCTR").Value
                .pCSRVC_Servicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value
                .pTRFSRG_RefrenciaServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_TRFSRG").Value
                .pCMNDGU_MonedaGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CMNDGU").Value
                .pISRVGU_importeServicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_ISRVGU").Value
                .pQCNDTG_CantServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_QCNDTG").Value
                .pCUNDSR_Unidad = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CUNDSR").Value
                .pSFCTTR_StatusFacturado = dtServGRemCargGTransLiq.CurrentRow.Cells("S_SFCTTR").Value
                .pMMCUSR_Usuario = MainModule.USUARIO
                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                .pCCMPN_Compania = Me.pCCMPN




            End With
            Dim fTemp As frmLiquidacionFlete_DlgAgregarServicio = New frmLiquidacionFlete_DlgAgregarServicio(pCCMPN, pCDVSN, oInfServ, Me.pSESTRG, "M", pCRGVTA)
            fTemp.pModificarProv = PuedeModificarProveedor
            fTemp.pModificarServ = PuedeModificarServicio

            fTemp.PSStatusLiquidacion = PSStatusLiquidacion_SESGRP

            fTemp.pbeAutorizacionLiq = pbeAutorizacionLiq
            fTemp.pFlagTarifaOS = dtServGRemCargGTransLiq.CurrentRow.Cells("Flag_TarifaOS").Value.ToString.Trim
          

            If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
                oInfServ = fTemp.pInformacionServicio
                ' Instanceamos la clase de procesos
                Dim Objeto_Logica As New GuiaTransportista_BLL
                Dim sMensajeError As String = ""

                Dim NCRRGU As Decimal = 0
                '---------------------JMC--------------------
                'If frmInvocado = "X" Or frmInvocado = "L" Then
                '    Adicionar_log(pNOPRCN, pNGUITR, oInfServ, "M")
                'End If
                '--------------------------------------------
                Objeto_Logica.Agregar_GRemServProCargadasGTranspLiq(oInfServ, NCRRGU)

                'Dim Observacion As String = frmInvocadoNombre & "-" & "MODIF"
                Dim Observacion As String = "MODIF-SERV"
                'oInfServ.pSESTRG = "A"
                Dim oInLog As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
                oInLog.pNOPRCN_NroOperacion = pNOPRCN
                oInLog.pNGUITR_NroGuiaRemision = pNGUITR
                oInLog.pNCRRGU_CorrServ = NCRRGU
                oInLog.pMMCUSR_Usuario = MainModule.USUARIO
                oInLog.pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                oInLog.pCCMPN_Compania = Me.pCCMPN

                Objeto_Logica.Grabar_Log_Servicio(oInfServ, Observacion, "M")


                Call Listar_ServGRemCargadasGTranspLiq()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
#End Region
#Region " Métodos "


    Sub New(ByVal Compania As String, ByVal Division As String, ByVal NroOperacion As Int64, ByVal pNroGuiaRemision As Int64, ByVal pEstado As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pCCMPN = Compania
        pCDVSN = Division
        pNOPRCN = NroOperacion
        pNGUITR = pNroGuiaRemision
        pSESTRG = pEstado

    End Sub

#End Region





    Private Sub dtServGRemCargGTransLiq_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtServGRemCargGTransLiq.CellContentClick
        Try
            If dtServGRemCargGTransLiq.RowCount <= 0 Then Exit Sub
            Select Case dtServGRemCargGTransLiq.Columns(e.ColumnIndex).Name
                Case "btnServicio"
                    Dim objEntidad As New TD_Obj_GRemAgregarServCargadasGTranspLiq()

                    Dim ofrmVerActualizacionServicios As New frmVerActualizacionServicios()
                    ofrmVerActualizacionServicios.pCCMPN = ""
                    ofrmVerActualizacionServicios.NOPRCN = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NOPRCN").Value
                    ofrmVerActualizacionServicios.NGUITR = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NGUITR").Value
                    ofrmVerActualizacionServicios.NCRRGU = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
                    ofrmVerActualizacionServicios.Servicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value & " - " & dtServGRemCargGTransLiq.CurrentRow.Cells("S_TCMTRF").Value
                    ofrmVerActualizacionServicios.ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Public Sub Validar_Modificacion(ByVal pNOPRCN As Decimal, ByVal pNGUITR As Decimal, ByVal oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByVal Tipo As String)
    'Public Sub Adicionar_log(ByVal pNOPRCN As Decimal, ByVal pNGUITR As Decimal, ByVal oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByVal Tipo As String)

    '    Dim Objeto_Logica As New GuiaTransportista_BLL
    '    Dim EntidadOrininal As New TD_Obj_GRemAgregarServCargadasGTranspLiq
    '    Dim dt As New DataTable

    '    Dim NCRRGU As Int32 = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
    '    dt = Objeto_Logica.lISTAR_SERVICIO_OPERACION_VALIDACION_LOG(Me.pCCMPN, pNOPRCN, pNGUITR, NCRRGU)

    '    For Each Item As DataRow In dt.Rows

    '        If Item("CMNDGU") <> oInfServ.pCMNDGU_MonedaGuia Or Item("ISRVGU") <> oInfServ.pISRVGU_importeServicio Or Item("QCNDTG") <> oInfServ.pQCNDTG_CantServicioGuia Or Item("SFCTTR") <> oInfServ.pSFCTTR_StatusFacturado Or Item("CMNLQT") <> oInfServ.pCMNLQT_Moneda Or Item("ILQDTR") <> oInfServ.pILQDTR_ImporteLiquidacionTransp Or Item("QCNDLG") <> oInfServ.pQCNDLG_CantidadServicioLiquidacion Or Item("SLQDTR") <> oInfServ.pSLQDTR_StatusLiquTransporte Then


    '            With (EntidadOrininal)
    '                .pNOPRCN_NroOperacion = Item("NOPRCN")
    '                .pNGUITR_NroGuiaRemision = Item("NGUITR")
    '                .pNCRRGU_CorrServ = Item("NCRRGU")
    '                .pCSRVC_Servicio = Item("CSRVC")
    '                .pCMNDGU_MonedaGuia = Item("CMNDGU")
    '                .pISRVGU_importeServicio = Item("ISRVGU")
    '                .pQCNDTG_CantServicioGuia = Item("QCNDTG")
    '                .pSFCTTR_StatusFacturado = Item("SFCTTR")
    '                .pSLQDTR_StatusLiquTransporte = Item("SLQDTR")
    '                .pCMNLQT_Moneda = Item("CMNLQT")
    '                .pILQDTR_ImporteLiquidacionTransp = Item("ILQDTR")
    '                .pQCNDLG_CantidadServicioLiquidacion = Item("QCNDLG")
    '                .pMMCUSR_Usuario = MainModule.USUARIO
    '                .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
    '            End With
    '            Dim Observacion As String = frmInvocadoNombre & "-" & "MODIF"
    '            Objeto_Logica.Grabar_Log_Servicio(EntidadOrininal, Observacion, Tipo)
    '        End If
    '    Next
    'End Sub




End Class
