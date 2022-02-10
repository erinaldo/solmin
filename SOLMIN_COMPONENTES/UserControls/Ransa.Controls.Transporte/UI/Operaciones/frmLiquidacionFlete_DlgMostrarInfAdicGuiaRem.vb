
Imports System.Windows.Forms

Public Class frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem

#Region " Atributos "
    Private pCCMPN As String = ""
    Private pCDVSN As String = ""
    Private pNOPRCN As Int64 = 0
    Private pNGUITR As Int64 = 0
    Private pSESTRG As String = ""
    Private pEstadoOpcion As Int32 = 0
    Private intProceso As Integer
#End Region
#Region " Propiedades "
    Public Property Proceso() As Integer
        Get
            Return intProceso
        End Get
        Set(ByVal value As Integer)
            intProceso = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


#End Region
#Region " Procedimientos y Funciones "
    Private Sub Listar_GRemHijasCargadasGTranspLiq()
        Dim oFiltro As New mantenimientos.TD_GRemHijasCargadasGTranspLiqPK
        Dim oGuiaTransportista As New mantenimientos.GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtGRemCargGTransLiq
        Me.dtGRemHijasCargGTransLiq.Rows.Clear()

        oFiltro.pNOPRCN_NroOperacion = pNOPRCN
        oFiltro.pNGUITR_GuiaRemisionCargada = pNGUITR
        oFiltro.pCCMPN_Compania = pCCMPN

        'LLENANDO EL dtGRemCargGTransLiq
        For Each oEntidad As mantenimientos.TD_Obj_GRemHijasCargadasGTranspLiq In oGuiaTransportista.Listar_GRemHijasCargadasGTranspLiquidacion(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtGRemHijasCargGTransLiq)
            dwvrow.Cells(0).Value = oEntidad.pNOPRCN_NroOperacion
            dwvrow.Cells(1).Value = oEntidad.pNGUITR_GuiaRemisionCargada
            dwvrow.Cells(2).Value = oEntidad.pNGUIRF_NroDocumentoReferencia
            dwvrow.Cells(3).Value = oEntidad.pQCCMP1_CantidadComponente1Gsl
            dwvrow.Cells(4).Value = oEntidad.pQCCMP2_CantidadComponente2Dsl
            dwvrow.Cells(5).Value = oEntidad.pTDSEXO_Observacion
            dwvrow.Cells(6).Value = oEntidad.pCCLNT1_CodigoCliente
            Me.dtGRemHijasCargGTransLiq.Rows.Add(dwvrow)
        Next
    End Sub

    Private Sub Listar_ServGRemCargadasGTranspLiq()
        Dim oFiltro As New mantenimientos.TD_GRemServCargadasGTranspLiqPK
        Dim oGuiaTransportista As New mantenimientos.GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtGRemCargGTransLiq
        Me.dtServGRemCargGTransLiq.Rows.Clear()

        oFiltro.pNOPRCN_NroOperacion = pNOPRCN
        oFiltro.pNGUITR_NroGuiaRemision = pNGUITR
        oFiltro.pCCMPN_Compania = pCCMPN

        'LLENANDO EL dtGRemCargGTransLiq
        For Each oEntidad As mantenimientos.TD_Obj_GRemServCargadasGTranspLiq In oGuiaTransportista.Listar_GRemServCargadasGTranspLiquidacion(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtServGRemCargGTransLiq)
            dwvrow.Cells(0).Value = oEntidad.pNOPRCN_NroOperacion
            dwvrow.Cells(1).Value = oEntidad.pNGUITR_NroGuiaRemision
            dwvrow.Cells(2).Value = oEntidad.pNCRRGU_CorrServ
            dwvrow.Cells(3).Value = oEntidad.pCSRVC_Servicio
            dwvrow.Cells(4).Value = oEntidad.pTCMTRF_DetalleServicio
            dwvrow.Cells(5).Value = oEntidad.pSFCTTR_StatusFacturado
            dwvrow.Cells(6).Value = oEntidad.pQCNDTG_CantidadServicio
            dwvrow.Cells(7).Value = oEntidad.pCUNDSR_Unidad
            dwvrow.Cells(8).Value = oEntidad.pISRVGU_importeServicio
            dwvrow.Cells(9).Value = oEntidad.pCMNDGU_MonedaGuia_S
            dwvrow.Cells(10).Value = oEntidad.pSLQDTR_StatusLiquTransporte
            dwvrow.Cells(11).Value = oEntidad.pQCNDLG_CantidadServicioLiquidacion
            dwvrow.Cells(12).Value = oEntidad.pCUNDTR_Unidad
            dwvrow.Cells(13).Value = oEntidad.pILQDTR_ImporteLiquidacionTransp
            dwvrow.Cells(14).Value = oEntidad.pCMNLQT_Moneda_S
            dwvrow.Cells(15).Value = oEntidad.pTRFSRG_RefrenciaServicioGuia
            dwvrow.Cells(16).Value = oEntidad.pCMNDGU_MonedaGuia
            dwvrow.Cells(17).Value = oEntidad.pCMNLQT_Moneda
            Me.dtServGRemCargGTransLiq.Rows.Add(dwvrow)
        Next
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarServLiqu.Click
        Dim oInfServ As mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq = New mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq

        With oInfServ
            .pNOPRCN_NroOperacion = pNOPRCN
            .pNGUITR_NroGuiaRemision = pNGUITR
            .pMMCUSR_Usuario = _pUsuario 'MainModule.USUARIO
            .pNTRMNL_Terminal = HelpClassST.NombreMaquina
            .pCCMPN_Compania = Me.pCCMPN
        End With

        Dim obeOrdenServicioTransporte As New Operaciones.OrdenServicioTransporte
        With obeOrdenServicioTransporte
            .CCMPN = Me.pCCMPN
            .CDVSN = pCDVSN
            .NLQDCN = 0
            .NOPRCN = pNOPRCN
            .TIPO = 2
        End With
        If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub

        Dim fTemp As frmLiquidacionFlete_DlgAgregarServ = New frmLiquidacionFlete_DlgAgregarServ(pCCMPN, pCDVSN, oInfServ)
        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfServ = fTemp.pInformacionServicio
            ' Instanceamos la clase de procesos
            Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
            Dim sMensajeError As String = ""
            If Not Objeto_Logica.Agregar_GRemServCargadasGTranspLiq(oInfServ, sMensajeError) Then
                MessageBox.Show("Error en el proceso de Liquidación de Servicio." & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Listar_ServGRemCargadasGTranspLiq()
                If Proceso <> 0 Then
                    Actualizar_Operaciones_Servicios_Importes()
                End If
            End If
        End If
    End Sub

    Private Function fblnValidarProvision(ByVal obeOrdenServicioTransporte) As Boolean
        '================verificamos si la liquidación esta provisionada
        Dim intResultado As Integer = 0
        Dim obrOrdenServicio As New Operaciones.OrdenServicio_BLL

        intResultado = obrOrdenServicio.intTieneProvision(obeOrdenServicioTransporte)
        Select Case intResultado
            Case -1
                MessageBox.Show("Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                If obrOrdenServicio.fblnUsuarioPermitidoRevertirProvision(_pUsuario) Then
                    If MsgBox("La Operación :" & obeOrdenServicioTransporte.NOPRCN & " está provisionada, desea seguir con la operación", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Return True
                    End If
                Else
                    'Usuario No puede Generar un revisado o Eliminar la provisión
                    MsgBox("Usted no tiene  autorización para administrar la Operación :" & obeOrdenServicioTransporte.NOPRCN & " porque se encuentra provisionada.")
                    Return True
                End If
        End Select
        '=================verificamos si la liquidación esta provisionada
        Return False
    End Function
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnModificarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarServLiqu.Click

        If dtServGRemCargGTransLiq.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '=============Validamos esta de provisión de la operación
        Dim obeOrdenServicioTransporte As New Operaciones.OrdenServicioTransporte
        With obeOrdenServicioTransporte
            .CCMPN = Me.pCCMPN
            .CDVSN = pCDVSN
            .NLQDCN = 0
            .NOPRCN = pNOPRCN
            .TIPO = 2
        End With
        If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
        '=============Validamos esta de provisión de la operación

        Dim oInfServ As mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq = New mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq
        With oInfServ
            .pNOPRCN_NroOperacion = pNOPRCN
            .pNGUITR_NroGuiaRemision = pNGUITR
            .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
            .pCSRVC_Servicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value
            .pTRFSRG_RefrenciaServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_TRFSRG").Value
            .pCMNDGU_MonedaGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CMNDGU").Value
            .pISRVGU_importeServicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_ISRVGU").Value
            .pQCNDTG_CantServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_QCNDTG").Value
            .pCUNDSR_Unidad = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CUNDSR").Value
            .pSFCTTR_StatusFacturado = dtServGRemCargGTransLiq.CurrentRow.Cells("S_SFCTTR").Value


            .pMMCUSR_Usuario = _pUsuario 'MainModule.USUARIO
            .pNTRMNL_Terminal = HelpClassST.NombreMaquina
            .pCCMPN_Compania = Me.pCCMPN
        End With
        Dim fTemp As frmLiquidacionFlete_DlgAgregarServ = New frmLiquidacionFlete_DlgAgregarServ(pCCMPN, pCDVSN, oInfServ)
        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfServ = fTemp.pInformacionServicio
            ' Instanceamos la clase de procesos
            Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
            Dim sMensajeError As String = ""
            If Not Objeto_Logica.Agregar_GRemServCargadasGTranspLiq(oInfServ, sMensajeError) Then
                MessageBox.Show("Error en el proceso de Liquidación de Servicio." & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Listar_ServGRemCargadasGTranspLiq()
                If Proceso <> 0 Then
                    Actualizar_Operaciones_Servicios_Importes()
                End If
            End If
        End If
    End Sub


    Private Sub btnEliminarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServLiqu.Click
        If dtServGRemCargGTransLiq.RowCount <= 0 Then
            MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '=============Validamos esta de provisión de la operación
        Dim obeOrdenServicioTransporte As New Operaciones.OrdenServicioTransporte
        With obeOrdenServicioTransporte
            .CCMPN = Me.pCCMPN
            .CDVSN = pCDVSN
            .NLQDCN = 0
            .NOPRCN = pNOPRCN
            .TIPO = 2
        End With
        If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
        '=============Validamos esta de provisión de la operación

        If MessageBox.Show("¿Desea eliminar el registro?", "Mensaje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim oInfLiquServ As mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiqPK = New mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiqPK
        With oInfLiquServ
            .pNOPRCN_NroOperacion = pNOPRCN
            .pNGUITR_NroGuiaRemision = pNGUITR
            .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
            .pMMCUSR_Usuario = _pUsuario 'MainModule.USUARIO
            .pNTRMNL_Terminal = HelpClassST.NombreMaquina
            .pCCMPN_Compania = Me.pCCMPN
        End With
        ' Instanceamos la clase de procesos
        Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
        Dim sMensajeError As String = ""
        If Not Objeto_Logica.Eliminar_LiquServGuiaRemisionLiqTransp(oInfLiquServ, sMensajeError) Then
            MessageBox.Show("Error en el proceso de Eliminación del Servicio. " & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Listar_ServGRemCargadasGTranspLiq()
            If Proceso <> 0 Then
                Actualizar_Operaciones_Servicios_Importes()
            End If
        End If
    End Sub


    Private Sub btnLiqServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiqServ.Click
        If dtServGRemCargGTransLiq.RowCount <= 0 Then
            MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '=============Validamos esta de provisión de la operación
        Dim obeOrdenServicioTransporte As New Operaciones.OrdenServicioTransporte
        With obeOrdenServicioTransporte
            .CCMPN = Me.pCCMPN
            .CDVSN = pCDVSN
            .NLQDCN = 0
            .NOPRCN = pNOPRCN
            .TIPO = 2
        End With
        If fblnValidarProvision(obeOrdenServicioTransporte) Then Exit Sub
        '=============Validamos esta de provisión de la operación

        Dim oInfLiquServ As mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq = New mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq
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
            .pMMCUSR_Usuario = _pUsuario 'MainModule.USUARIO
            .pNTRMNL_Terminal = HelpClassST.NombreMaquina
            .pCCMPN_Compania = Me.pCCMPN
        End With
        Dim fTemp As frmLiquidacionFlete_DlgLiquServicio = New frmLiquidacionFlete_DlgLiquServicio(oInfLiquServ)
        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfLiquServ = fTemp.pInformacionServicio
            ' Instanceamos la clase de procesos
            Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
            Dim sMensajeError As String = ""
            If Not Objeto_Logica.Registrar_LiquServGuiaRemisionLiqTransp(oInfLiquServ, sMensajeError) Then
                MessageBox.Show("Error en el proceso de Liquidación de Servicio." & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Listar_ServGRemCargadasGTranspLiq()
            End If
        End If
    End Sub


    Private Sub frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For lint_contador As Integer = 0 To Me.dtServGRemCargGTransLiq.ColumnCount - 1
            Me.dtServGRemCargGTransLiq.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        Select Case pSESTRG
            Case "F"
                Me.ToolStrip1.Visible = False
            Case "L"
                If pEstadoOpcion = 0 Then
                    Me.ToolStrip1.Visible = False
                Else
                    Me.btnEliminarServLiqu.Visible = False
                    Me.ToolStripSeparator2.Visible = False
                    Me.btnLiqServ.Visible = False
                    Me.ToolStripSeparator3.Visible = False
                End If
            Case Else
                If pEstadoOpcion = 0 Then Me.ToolStrip1.Visible = False
        End Select
        Call Listar_ServGRemCargadasGTranspLiq()
        Call Listar_GRemHijasCargadasGTranspLiq()
    End Sub
    Private Sub Actualizar_Operaciones_Servicios_Importes()
        Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
        Dim dtOperaciones As DataTable
        Dim objParametro As New Hashtable
        Dim objParam As New Hashtable
        Dim MonedaGuia As Integer = 1
        Dim MonedaLiquida As Integer = 1
        Dim aSolesGuia As Boolean = True
        Dim aSolesLiq As Boolean = True
        Dim SumISRVGU As Double = 0
        Dim SumILQDTR As Double = 0

        Try
            objParametro.Add("NOPRCN", Me.pNOPRCN)
            objParametro.Add("CCMPN", Me.pCCMPN)
            objParametro.Add("CDVSN", Me.pCDVSN)

            dtOperaciones = Objeto_Logica.Listar_Operaciones_X_Servicios_Importes(objParametro)
            If dtOperaciones.Rows.Count > 0 Then
                'If MonedaGuia <> dtOperaciones.Rows(0).Item("CMNDGU") Then ' SI ES DIFERENTE DE SOLES IMPORTE A COBRAR
                '    MonedaGuia = 100
                '    aSolesGuia = False
                'End If
                'If MonedaLiquida <> dtOperaciones.Rows(0).Item("CMNLQT") Then ' SI ES DIFERENTE DE SOLES IMPORTE A PAGAR
                '    MonedaLiquida = 100
                '    aSolesLiq = False
                'End If

                For indice As Integer = 0 To dtOperaciones.Rows.Count - 1
                    If aSolesGuia = True Then ' SI SE CONVIERTE A SOLES IMPORTE A COBRAR
                        If dtOperaciones.Rows(indice).Item("CMNDGU") = 100 Then
                            dtOperaciones.Rows(indice).Item("ISRVGU") = dtOperaciones.Rows(indice).Item("ISRVGU") * dtOperaciones.Rows(indice).Item("IVNTA")
                        End If
                    Else 'SI SE CONVIERTE A DOLAR IMPORTE A COBRAR
                        If dtOperaciones.Rows(indice).Item("CMNDGU") = 1 Then
                            dtOperaciones.Rows(indice).Item("ISRVGU") = dtOperaciones.Rows(indice).Item("ISRVGU") / dtOperaciones.Rows(indice).Item("IVNTA")
                        End If
                    End If
                    If aSolesLiq = True Then ' SI SE CONVIERTE A SOLES IMPORTE A PAGAR
                        If dtOperaciones.Rows(indice).Item("CMNLQT") = 100 Then
                            dtOperaciones.Rows(indice).Item("ILQDTR") = dtOperaciones.Rows(indice).Item("ILQDTR") * dtOperaciones.Rows(indice).Item("IVNTA")
                        End If
                    Else 'SI SE CONVIERTE A DOLAR IMPORTE A PAGAR
                        If dtOperaciones.Rows(indice).Item("CMNLQT") = 1 Then
                            dtOperaciones.Rows(indice).Item("ILQDTR") = dtOperaciones.Rows(indice).Item("ILQDTR") / dtOperaciones.Rows(indice).Item("IVNTA")
                        End If
                    End If

                    SumISRVGU = SumISRVGU + dtOperaciones.Rows(indice).Item("ISRVGU")
                    SumILQDTR = SumILQDTR + dtOperaciones.Rows(indice).Item("ILQDTR")
                Next
            Else
                MonedaGuia = 0
                MonedaLiquida = 0
            End If
            SumISRVGU = Math.Round(SumISRVGU, 2)
            SumILQDTR = Math.Round(SumILQDTR, 2)

            objParam.Add("NOPRCN", Me.pNOPRCN)
            'objParam.Add("CMNDGU", MonedaGuia)
            objParam.Add("ISRVGU", SumISRVGU)
            'objParam.Add("CMNLQT", MonedaLiquida)
            objParam.Add("ILQDTR", SumILQDTR)
            objParam.Add("CCMPN", Me.pCCMPN)
            objParam.Add("CDVSN", Me.pCDVSN)

            Objeto_Logica.Actualizar_Operaciones_X_Servicios_Importes(objParam)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal NroOperacion As Int64, ByVal pNroGuiaRemision As Int64, ByVal pEstado As String, ByVal Estado_Opcion As Int32)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pCCMPN = Compania
        pCDVSN = Division
        pNOPRCN = NroOperacion
        pNGUITR = pNroGuiaRemision
        pSESTRG = pEstado
        pEstadoOpcion = Estado_Opcion
    End Sub
#End Region

End Class
