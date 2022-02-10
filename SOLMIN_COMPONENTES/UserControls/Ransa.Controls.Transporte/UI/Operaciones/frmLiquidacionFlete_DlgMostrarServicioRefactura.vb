
Imports System.Windows.Forms

Public Class frmLiquidacionFlete_DlgMostrarServicioRefactura
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
    Private Sub Listar_ServGRemCargadasGTranspLiq_Refactura()
        Dim oFiltro As New mantenimientos.TD_GRemServCargadasGTranspLiqPK
        Dim oGuiaTransportista As New mantenimientos.GuiaTransportista_BLL
        Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtGRemCargGTransLiq
       
        oFiltro.pNOPRCN_NroOperacion = pNOPRCN
        oFiltro.pNGUITR_NroGuiaRemision = pNGUITR
        oFiltro.pCCMPN_Compania = pCCMPN
        Me.dtServGRemCargGTransLiq.Rows.Clear()
        'LLENANDO EL dtGRemCargGTransLiq
        For Each oEntidad As mantenimientos.TD_Obj_GRemServCargadasGTranspLiq In oGuiaTransportista.Listar_GRemServCargadasGTranspLiquidacion_Refactura(oFiltro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtServGRemCargGTransLiq)
            dwvrow.Cells(0).Value = oEntidad.pNOPRCN_NroOperacion
            dwvrow.Cells(1).Value = oEntidad.pNGUITR_NroGuiaRemision
            dwvrow.Cells(2).Value = oEntidad.pNCRRGU_CorrServ
            dwvrow.Cells(3).Value = oEntidad.pCSRVC_Servicio
            dwvrow.Cells(4).Value = oEntidad.pTCMTRF_DetalleServicio
            ' dwvrow.Cells(5).Value = oEntidad.pSFCTTR_StatusFacturado
            dwvrow.Cells(5).Value = oEntidad.pQCNDTG_CantidadServicio
            dwvrow.Cells(6).Value = oEntidad.pCUNDSR_Unidad
            dwvrow.Cells(7).Value = oEntidad.pISRVGU_importeServicio
            dwvrow.Cells(8).Value = oEntidad.pCMNDGU_MonedaGuia_S
            'dwvrow.Cells(10).Value = oEntidad.pSLQDTR_StatusLiquTransporte
            ' dwvrow.Cells(11).Value = oEntidad.pQCNDLG_CantidadServicioLiquidacion
            ' dwvrow.Cells(12).Value = oEntidad.pCUNDTR_Unidad
            ' dwvrow.Cells(13).Value = oEntidad.pILQDTR_ImporteLiquidacionTransp
            'dwvrow.Cells(14).Value = oEntidad.pCMNLQT_Moneda_S
            'dwvrow.Cells(15).Value = oEntidad.pTRFSRG_RefrenciaServicioGuia
            dwvrow.Cells(9).Value = oEntidad.pCMNDGU_MonedaGuia
            'dwvrow.Cells(17).Value = oEntidad.pCMNLQT_Moneda
            Me.dtServGRemCargGTransLiq.Rows.Add(dwvrow)
        Next
    End Sub
#End Region
#Region " Eventos "

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarServLiqu.Click
        If dtServGRemCargGTransLiq.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim oInfServ As mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq = New mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq
        With oInfServ
            .pNOPRCN_NroOperacion = pNOPRCN
            .pNGUITR_NroGuiaRemision = pNGUITR
            .pNCRRGU_CorrServ = dtServGRemCargGTransLiq.CurrentRow.Cells("S_NCRRGU").Value
            .pCSRVC_Servicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CSRVC").Value
            ' .pTRFSRG_RefrenciaServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_TRFSRG").Value
            .pCMNDGU_MonedaGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CMNDGU").Value
            .pISRVGU_importeServicio = dtServGRemCargGTransLiq.CurrentRow.Cells("S_ISRVGU").Value
            .pQCNDTG_CantServicioGuia = dtServGRemCargGTransLiq.CurrentRow.Cells("S_QCNDTG").Value
            .pCUNDSR_Unidad = dtServGRemCargGTransLiq.CurrentRow.Cells("S_CUNDSR").Value
            ' .pSFCTTR_StatusFacturado = dtServGRemCargGTransLiq.CurrentRow.Cells("S_SFCTTR").Value

            ' .pMMCUSR_Usuario = MainModule.USUARIO
            ' .pNTRMNL_Terminal = HelpClass.NombreMaquina
            .pCCMPN_Compania = Me.pCCMPN
        End With
        Dim fTemp As frmServiciosRefactura_DlgAgregarServ = New frmServiciosRefactura_DlgAgregarServ(pCCMPN, pCDVSN, oInfServ)
        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfServ = fTemp.pInformacionServicio
            ' Instanceamos la clase de procesos
            Dim Objeto_Logica As New mantenimientos.GuiaTransportista_BLL
            Dim sMensajeError As String = ""
            If Not Objeto_Logica.Agregar_GRemServCargadasGTranspLiq_Refactura(oInfServ, sMensajeError) Then
                MessageBox.Show("Error en el proceso de Liquidación de Servicio." & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Listar_ServGRemCargadasGTranspLiq_Refactura()
            End If
        End If
    End Sub

    Private Sub btnEliminarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServLiqu.Click
        If dtServGRemCargGTransLiq.RowCount <= 0 Then
            MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
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
        If Not Objeto_Logica.Eliminar_LiquServGuiaRemisionLiqTransp_Refactura(oInfLiquServ, sMensajeError) Then
            MessageBox.Show("Error en el proceso de Eliminación del Servicio. " & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Listar_ServGRemCargadasGTranspLiq_Refactura()
        End If
    End Sub


    Private Sub frmLiquidacionFlete_DlgMostrarServicioRefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For lint_contador As Integer = 0 To Me.dtServGRemCargGTransLiq.ColumnCount - 1
            Me.dtServGRemCargGTransLiq.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        Select Case pSESTRG
            Case "F"
                Me.ToolStrip1.Visible = False
            Case "L"
              
                Me.btnEliminarServLiqu.Visible = True
                Me.ToolStripSeparator2.Visible = True
                Me.btnLiqServ.Visible = False
                Me.ToolStripSeparator3.Visible = False

            Case Else
                If pEstadoOpcion = 0 Then Me.ToolStrip1.Visible = False
        End Select
        Call Listar_ServGRemCargadasGTranspLiq_Refactura()

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
