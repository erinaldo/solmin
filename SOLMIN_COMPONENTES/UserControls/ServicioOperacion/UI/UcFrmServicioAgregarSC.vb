Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Drawing
Imports System.IO.Directory
Imports System.Data
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class UcFrmServicioAgregarSC
    Private Enum Busqueda
        Embarque
        OrdenServicio
    End Enum

    Enum Accion
        Nuevo
        Modificar
    End Enum


    Private _pDialogResult As Boolean = False
    Private bolBuscar As Boolean = False
    Private _pbeServicioFacturar As Servicio_BE



    Public Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
        Set(ByVal value As Boolean)
            _pDialogResult = value
        End Set
    End Property

    Private _pAccion As Accion
    Public Property pAccion() As Accion
        Get
            Return _pAccion
        End Get
        Set(ByVal value As Accion)
            _pAccion = value
        End Set
    End Property


    Public Sub New(ByVal poServicioSIL As Servicio_BE)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        _pbeServicioFacturar = New Servicio_BE
        _pbeServicioFacturar = poServicioSIL
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CargarServicioxCliente(ByVal PNFECHA As Decimal)
        Dim oServicio_BE As New Servicio_BE
        Dim oServicioSILNeg As New clsServicio_BL
        Dim oDt As New DataTable
        Dim dr As DataRow
        oServicio_BE.CCMPN = _pbeServicioFacturar.CCMPN
        oServicio_BE.CDVSN = _pbeServicioFacturar.CDVSN
        oServicio_BE.CPLNDV = 1
        oServicio_BE.FOPRCN = PNFECHA
        oServicio_BE.CCLNT = UcClienteOperacion.pCodigo
        oDt = oServicioSILNeg.Cargar_Servicios_Tarifa_Cliente(oServicio_BE)
        dr = oDt.NewRow
        dr("NRTFSV") = "-1"
        dr("DESTAR") = "::Seleccione::"
        oDt.Rows.InsertAt(dr, 0)
        bolBuscar = False
        cmbServicio.ComboBox.DataSource = oDt
        cmbServicio.ComboBox.ValueMember = "NRTFSV"
        cmbServicio.ComboBox.DisplayMember = "DESTAR"
        cmbServicio.ComboBox.SelectedValue = "-1"
        bolBuscar = True
    End Sub

    Public Function FormatoFecha(ByVal fecha As String) As String
        Dim fechaFormato As String
        If fecha.Length = 8 Then
            fechaFormato = fecha.Substring(6, 2) & "/" & fecha.Substring(4, 2) & "/" & fecha.Substring(0, 4)
        ElseIf fecha.Length = 1 Then
            fechaFormato = ""
        Else
            fechaFormato = Microsoft.VisualBasic.Right(fecha, 2) & "/" & Microsoft.VisualBasic.Right(fecha, 2) & "/" & Microsoft.VisualBasic.Left(fecha, 4)
        End If
        Return fechaFormato
    End Function

    Private Sub frmServicioV2AgregarSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim odtTipoBusqueda As New DataTable
        dtgEmbarque.AutoGenerateColumns = False
        'Me.UcClienteOperacion.pAccesoPorUsuario = True
        'Me.UcClienteOperacion.pRequerido = True
        'Me.UcClienteOperacion.pUsuario = ConfigurationWizard.UserName
        'Me.UcClienteFacturacion.pAccesoPorUsuario = True
        'Me.UcClienteFacturacion.pRequerido = True
        'Me.UcClienteFacturacion.pUsuario = ConfigurationWizard.UserName
        Try
            If (Me.Tag = Comun.ESTADO_Nuevo) Then
                _pAccion = Accion.Nuevo
            ElseIf Me.Tag = Comun.ESTADO_Modificado Then
                _pAccion = Accion.Modificar
            End If
            odtTipoBusqueda.Columns.Add("CODIGO")
            odtTipoBusqueda.Columns.Add("DESC")
            Dim dr As DataRow
            dr = odtTipoBusqueda.NewRow
            dr("CODIGO") = "E"
            dr("DESC") = "Embarque"
            odtTipoBusqueda.Rows.Add(dr)
            dr = odtTipoBusqueda.NewRow
            dr("CODIGO") = "O"
            dr("DESC") = "Orden Servicio"
            odtTipoBusqueda.Rows.Add(dr)

            cboBusqueda.ComboBox.DataSource = odtTipoBusqueda
            cboBusqueda.ComboBox.DisplayMember = "DESC"
            cboBusqueda.ComboBox.ValueMember = "CODIGO"
            If (_pbeServicioFacturar.CCLNT <> 0) Then
                UcClienteOperacion.pCargar(_pbeServicioFacturar.CCLNT)
            End If
            If (_pbeServicioFacturar.CCLNFC <> 0) Then
                UcClienteFacturacion.pCargar(_pbeServicioFacturar.CCLNFC)
            End If
            Select Case pAccion
                Case Accion.Modificar
                    Dim CTPALJ As String = ""
                    Dim obrServicio As New clsServicioSC_BL
                    UcClienteOperacion.Enabled = False
                    Dim odtDatosOperacion As New DataTable
                    txtNroOperacion.Text = _pbeServicioFacturar.NOPRCN
                    odtDatosOperacion = obrServicio.Obtener_Datos_Operacion(UcClienteOperacion.pCodigo, _pbeServicioFacturar.NOPRCN)
                    If (odtDatosOperacion.Rows.Count > 0) Then
                        _pbeServicioFacturar.FOPRCN = odtDatosOperacion.Rows(0)("FOPRCN")
                        txtTipoOperacion.Text = odtDatosOperacion.Rows(0)("CTPALJ_DESC")
                        CTPALJ = odtDatosOperacion.Rows(0)("CTPALJ")                       
                    End If
                    dtpFechServicio.Text = FormatoFecha(_pbeServicioFacturar.FOPRCN.ToString)
                    dtpFechServicio.Enabled = False
                    Llenar_Embarques_x_Operacion(UcClienteOperacion.pCodigo, _pbeServicioFacturar.NOPRCN)
                    Llenar_Servicios_x_Operacion(UcClienteOperacion.pCodigo, _pbeServicioFacturar.NOPRCN)
                Case Accion.Nuevo
                    dtpFechServicio.Enabled = True
                    _pbeServicioFacturar.FOPRCN = dtpFechServicio.Value.ToString("yyyyMMdd")
            End Select
            CargarServicioxCliente(_pbeServicioFacturar.FOPRCN)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub Llenar_Servicios_x_Operacion(ByVal CCLNT As Decimal, ByVal PNNOPRCN As Decimal)
        Try
            Dim obrServicio As New clsServicioSC_BL
            Dim odtServicios As New DataTable
            Dim oParamServicio As New Servicio_BE
            oParamServicio.CCLNT = CCLNT
            oParamServicio.NOPRCN = PNNOPRCN
            oParamServicio.PNNORSCI = 0
            oParamServicio.PSBUSQUEDA = "OPERACION"
            odtServicios = obrServicio.Lista_Servicios_Operacion(oParamServicio)
            Dim oDrVw As DataGridViewRow
            Dim FILA As Int32 = 0
            Dim STIPPR As String = ""
            For Index As Integer = 0 To odtServicios.Rows.Count - 1
                STIPPR = odtServicios.Rows(Index)("STIPPR")
                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dgServicio)
                Me.dgServicio.Rows.Add(oDrVw)
                FILA = dgServicio.Rows.Count - 1
                dgServicio.Rows(FILA).Cells("NOPRCN").Value = odtServicios.Rows(Index)("NOPRCN")
                dgServicio.Rows(FILA).Cells("NRTFSV").Value = odtServicios.Rows(Index)("NRTFSV")
                dgServicio.Rows(FILA).Cells("DESTAR").Value = odtServicios.Rows(Index)("DESTAR")
                dgServicio.Rows(FILA).Cells("CTPALJ").Value = odtServicios.Rows(Index)("CTPALJ")
                dgServicio.Rows(FILA).Cells("NCRROP").Value = odtServicios.Rows(Index)("NCRROP")
                dgServicio.Rows(FILA).Cells("QATNAN").Value = odtServicios.Rows(Index)("QATNAN")
                dgServicio.Rows(FILA).Cells("IVLSRV").Value = odtServicios.Rows(Index)("IVLSRV")
                dgServicio.Rows(FILA).Cells("STATUS").Value = odtServicios.Rows(Index)("STATUS")
                dgServicio.Rows(FILA).Cells("CUNDMD").Value = odtServicios.Rows(Index)("CUNDMD")
                dgServicio.Rows(FILA).Cells("STIPPR").Value = STIPPR
                dgServicio.Rows(FILA).Cells("STPTRA_DESC").Value = odtServicios.Rows(Index)("STPTRA_DESC")
                dgServicio.Rows(FILA).Cells("QATNAN").ReadOnly = Not HabilitarCantidadTarifa(STIPPR)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Modificacion"
    Private Sub Llenar_Embarques_x_Operacion(ByVal CCLNT As Decimal, ByVal NOPRCN As Decimal)
        dtgEmbarque.Rows.Clear()
        Dim oDt As New DataTable
        Dim obeServicio As New Servicio_BE
        obeServicio.CCLNT = CCLNT
        obeServicio.NOPRCN = NOPRCN
        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        Dim odtServicioSC As New DataTable
        oDt = obrclsServicioSC_BL.Lista_Detalle_Servicios_SC(obeServicio)
        Dim oDrVw As DataGridViewRow
        Dim pos As Integer
        For i As Integer = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgEmbarque)
            Me.dtgEmbarque.Rows.Add(oDrVw)
            With Me.dtgEmbarque
                pos = i
                .Rows(pos).Cells("NORSCI").Value = oDt.Rows(i).Item("NORSCI").ToString.Trim
                .Rows(pos).Cells("NRITEM").Value = oDt.Rows(i).Item("NRITEM")
                .Rows(pos).Cells("ETD").Value = oDt.Rows(i).Item("ETD").ToString.Trim
                .Rows(pos).Cells("ETA").Value = oDt.Rows(i).Item("ETA").ToString.Trim
                .Rows(pos).Cells("AT").Value = oDt.Rows(i).Item("ATD").ToString.Trim
                .Rows(pos).Cells("FOB").Value = oDt.Rows(i).Item("FOB")
                .Rows(pos).Cells("FLETE").Value = oDt.Rows(i).Item("FLETE").ToString.Trim
                .Rows(pos).Cells("SEGURO").Value = oDt.Rows(i).Item("SEGURO")
                .Rows(pos).Cells("CIF").Value = oDt.Rows(i).Item("CIF").ToString.Trim
                .Rows(pos).Cells("FLAG_REGISTRO").Value = oDt.Rows(i).Item("FLAG_REGISTRO")
                .Rows(pos).Cells("ESTADO").Value = oDt.Rows(i).Item("ESTADO").ToString

                .Rows(pos).Cells("PNNMOS").Value = oDt.Rows(i).Item("PNNMOS")
                .Rows(pos).Cells("TPRVCL").Value = oDt.Rows(i).Item("TPRVCL")
                .Rows(pos).Cells("TDITES").Value = oDt.Rows(i).Item("TDITES").ToString.Trim
                .Rows(pos).Cells("NDOCEM").Value = oDt.Rows(i).Item("NDOCEM")
                .Rows(pos).Cells("CMEDTR").Value = oDt.Rows(i).Item("CMEDTR")
                .Rows(pos).Cells("TCANAL").Value = oDt.Rows(i).Item("TCANAL")
                .Rows(pos).Cells("TNMAGC").Value = oDt.Rows(i).Item("TNMAGC")
                .Rows(pos).Cells("REGIMEN").Value = oDt.Rows(i).Item("REGIMEN")
                .Rows(pos).Cells("DESPACHO").Value = oDt.Rows(i).Item("DESPACHO")
                .Rows(pos).Cells("TNRODU").Value = oDt.Rows(i).Item("TNRODU")

                .Rows(pos).Cells("FOB").Value = oDt.Rows(i).Item("FOB")
                .Rows(pos).Cells("FLETE").Value = oDt.Rows(i).Item("FLETE")
                .Rows(pos).Cells("SEGURO").Value = oDt.Rows(i).Item("SEGURO")
                .Rows(pos).Cells("CIF").Value = oDt.Rows(i).Item("CIF")


            End With
        Next
    End Sub



#End Region

#Region "Embarques para agregar"
    'Private Sub txtEmbarque_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Dim NORSCI As Decimal = 0
    '    Dim NORSCI_EXITO As Boolean = False
    '    Try
    '        If e.KeyValue = 13 And (Me.txtBusqueda.Text.Trim.Length >= 2) Then
    '            NORSCI_EXITO = Decimal.TryParse(Me.txtBusqueda.Text.Trim, NORSCI)
    '            If (NORSCI_EXITO = True) Then
    '                AgregarLista()
    '            End If
    '        Else
    '            If e.KeyValue = 13 Then
    '                MsgBox(Comun.Mensaje("MENSAJE.ERROR.EMBARQUE"), MessageBoxIcon.Error)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    'Private Sub AgregarLista()



    'End Sub

    Private Sub btnAdEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdEmbarque.Click
        Try
            txtBusqueda.Focus()
            Dim numEmbarque As Decimal = 0
            Dim msgValidacionEmbarque As String = ""
            Dim TipoBusqueda As String = ""
            Dim boolValidacion As Boolean = False
            Dim msgValidacion As New StringBuilder
            If (UcClienteOperacion.pCodigo = 0) Then
                MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If (IsPosibleAdicionarEmbarque() = False) Then
                msgValidacion.Append("No puede adicionar más servicios.Tener en cuenta:")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios servicios deben ser asignados como máximo a un Embarque o")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios Embarques deben ser asignados a un Servicio.")
                MessageBox.Show(msgValidacion.ToString.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If (Not Decimal.TryParse(txtBusqueda.Text.Trim, numEmbarque)) Then
                MessageBox.Show("Ingrese " & cboBusqueda.ComboBox.Text.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            Dim oDrVw As DataGridViewRow
            Dim oDt As DataTable
            Dim dblEmbarque As Double = 0
            Dim intCont, intRow As Integer
            Dim pos As Integer
            Dim obeServicios As New Servicio_BE
            obeServicios.CCLNT = UcClienteOperacion.pCodigo
            TipoBusqueda = cboBusqueda.ComboBox.SelectedValue
            Select Case TipoBusqueda
                Case "E" 'X EMBARQUE
                    obeServicios.NORSCI = Convert.ToDecimal(txtBusqueda.Text.Trim)
                Case "O" ' X ORDEN SERVICIO
                    obeServicios.PNNMOS = Convert.ToDecimal(txtBusqueda.Text.Trim)
            End Select
            obeServicios.PSBUSQUEDA = TipoBusqueda
            'msgValidacionEmbarque = obrclsServicioSC_BL.ValidaIngresoEmbarqueAOperacion(obeServicios.CCLNT, obeServicios.NORSCI, obeServicios.PNNMOS, obeServicios.PSBUSQUEDA)

            If (msgValidacionEmbarque.Length <> 0) Then
                MessageBox.Show(msgValidacionEmbarque, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            oDt = obrclsServicioSC_BL.Lista_OC_X_Embarque_OS(obeServicios)

            With oDt
                If oDt.Rows.Count > 0 Then
                    For intRow = 0 To dtgEmbarque.Rows.Count - 1
                        For intCont = .Rows.Count - 1 To 0 Step -1
                            If (dtgEmbarque.Rows(intRow).Cells("NORSCI").Value.ToString.Trim = .Rows(intCont).Item("NORSCI").ToString.Trim) Then
                                oDt.Rows.RemoveAt(intCont)
                            End If
                        Next intCont
                    Next
                End If
            End With

            If oDt.Rows.Count > 0 Then
                For intCont = 0 To oDt.Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgEmbarque)
                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgEmbarque.Rows.Add(oDrVw)
                    pos = dtgEmbarque.Rows.Count - 1
                    With dtgEmbarque
                        .Rows(pos).Cells("NORSCI").Value = oDt.Rows(intCont).Item("NORSCI")
                        .Rows(pos).Cells("ETD").Value = oDt.Rows(intCont).Item("ETD").ToString.Trim
                        .Rows(pos).Cells("ETA").Value = oDt.Rows(intCont).Item("ETA").ToString.Trim
                        .Rows(pos).Cells("AT").Value = oDt.Rows(intCont).Item("ATD").ToString.Trim
                        .Rows(pos).Cells("ESTADO").Value = oDt.Rows(intCont).Item("ESTADO").ToString
                        .Rows(pos).Cells("PNNMOS").Value = oDt.Rows(intCont).Item("PNNMOS")
                        .Rows(pos).Cells("TPRVCL").Value = oDt.Rows(intCont).Item("TPRVCL")
                        .Rows(pos).Cells("TDITES").Value = oDt.Rows(intCont).Item("TDITES")
                        .Rows(pos).Cells("NDOCEM").Value = oDt.Rows(intCont).Item("NDOCEM")
                        .Rows(pos).Cells("CMEDTR").Value = oDt.Rows(intCont).Item("CMEDTR")
                        .Rows(pos).Cells("TCANAL").Value = oDt.Rows(intCont).Item("TCANAL")
                        .Rows(pos).Cells("TNMAGC").Value = oDt.Rows(intCont).Item("TNMAGC")
                        .Rows(pos).Cells("REGIMEN").Value = oDt.Rows(intCont).Item("REGIMEN")
                        .Rows(pos).Cells("DESPACHO").Value = oDt.Rows(intCont).Item("DESPACHO")
                        .Rows(pos).Cells("TNRODU").Value = oDt.Rows(intCont).Item("TRANSPORTE")
                        .Rows(pos).Cells("FOB").Value = oDt.Rows(intCont).Item("FOB")
                        .Rows(pos).Cells("FLETE").Value = oDt.Rows(intCont).Item("FLETE")
                        .Rows(pos).Cells("SEGURO").Value = oDt.Rows(intCont).Item("SEGURO")
                        .Rows(pos).Cells("CIF").Value = oDt.Rows(intCont).Item("CIF")
                    End With
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Embarque Guardar"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim msgValidacion As String = ""
        Dim retorno As Int32 = 0
        Try
            msgValidacion = ValidarItemDetalleOperacion()
            If (msgValidacion.Length <> 0) Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim PNNOPRCN As Decimal = 0
            Dim obrServicio As New clsServicioSC_BL

            Decimal.TryParse(txtNroOperacion.Text.Trim, PNNOPRCN)
            Dim STATUS As String = ""
            Dim QATNAN As Decimal = 0
            Dim oServicioCabecera As New Servicio_BE
            oServicioCabecera.CCLNT = UcClienteOperacion.pCodigo
            oServicioCabecera.CCLNFC = UcClienteFacturacion.pCodigo
            oServicioCabecera.CCMPN = _pbeServicioFacturar.CCMPN
            oServicioCabecera.CDVSN = _pbeServicioFacturar.CDVSN
            oServicioCabecera.FOPRCN = Me.dtpFechServicio.Value.ToString("yyyyMMdd")
            oServicioCabecera.PSUSUARIO = ConfigurationWizard.UserName
            oServicioCabecera.NOPRCN = PNNOPRCN

            If (oServicioCabecera.NOPRCN = 0) Then
                oServicioCabecera.CTPALJ = "MA" ' OPERACION TIPO MANUAL
                oServicioCabecera.NOPRCN = obrServicio.Insertar_Servicio_Facturar_Cabecera(oServicioCabecera)
            Else
                retorno = obrServicio.Actualizar_Servicio_Facturar_Cabecera(oServicioCabecera)
            End If

            If (oServicioCabecera.NOPRCN > 0) Then
                Dim oServicioDetServicio As Servicio_BE
                Dim oListServicioDetServicio As New List(Of Servicio_BE)
                For FILA As Integer = 0 To dgServicio.Rows.Count - 1
                    oServicioDetServicio = New Servicio_BE
                    oServicioDetServicio.NOPRCN = oServicioCabecera.NOPRCN
                    oServicioDetServicio.CCLNT = oServicioCabecera.CCLNT
                    oServicioDetServicio.NCRROP = dgServicio.Rows(FILA).Cells("NCRROP").Value
                    oServicioDetServicio.NRTFSV = dgServicio.Rows(FILA).Cells("NRTFSV").Value
                    oServicioDetServicio.QATNAN = dgServicio.Rows(FILA).Cells("QATNAN").Value
                    oServicioDetServicio.CCMPN = _pbeServicioFacturar.CCMPN
                    oServicioDetServicio.CDVSN = _pbeServicioFacturar.CDVSN
                    oServicioDetServicio.PSUSUARIO = ConfigurationWizard.UserName
                    oListServicioDetServicio.Add(oServicioDetServicio)
                Next
                retorno = obrServicio.Insertar_Servicio_Facturar_Servicios(oListServicioDetServicio)
                Dim oServicioDetalleEmbarque As Servicio_BE
                Dim oListServicioDetalleEmbarque As New List(Of Servicio_BE)
                For Fila As Int32 = 0 To Me.dtgEmbarque.Rows.Count - 1
                    oServicioDetalleEmbarque = New Servicio_BE
                    oServicioDetalleEmbarque.NOPRCN = oServicioCabecera.NOPRCN
                    oServicioDetalleEmbarque.CCLNT = oServicioCabecera.CCLNT
                    oServicioDetalleEmbarque.NORSCI = dtgEmbarque.Rows(Fila).Cells("NORSCI").Value
                    oServicioDetalleEmbarque.PSUSUARIO = ConfigurationWizard.UserName
                    oListServicioDetalleEmbarque.Add(oServicioDetalleEmbarque)
                Next
                retorno = obrServicio.Insertar_Servicio_Facturar_Embarques(oListServicioDetalleEmbarque)
            End If

            MessageBox.Show("Se actualizado los servicios con número operación:" & oServicioCabecera.NOPRCN, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _pDialogResult = True
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidarIngreso()
        txtCantidad.Text = txtCantidad.Text.Trim
        Dim Cantidad As Decimal = 0.0
        Dim ExitoConv As Boolean = False
        Dim sbValidar As New StringBuilder
        If (UcClienteOperacion.pCodigo = 0) Then
            sbValidar.Append("Ingrese Cliente Operación.")
            sbValidar.AppendLine()
        End If
        If (UcClienteFacturacion.pCodigo = 0) Then
            sbValidar.Append("Ingrese Cliente Facturación.")
            sbValidar.AppendLine()
        End If
        If (cmbServicio.ComboBox.SelectedValue = "-1" OrElse cmbServicio.Items.Count <= 0) Then
            sbValidar.Append("Seleccione Servicio.")
            sbValidar.AppendLine()
        End If
        ExitoConv = Decimal.TryParse(txtCantidad.Text, Cantidad)
        If (ExitoConv = False) Then
            sbValidar.Append("Ingrese la cantidad [mayor a 0].")
            sbValidar.AppendLine()
        ElseIf Cantidad = 0 Then
            sbValidar.Append("Ingrese la cantidad [mayor a 0].")
            sbValidar.AppendLine()
        End If
        If (dtgEmbarque.Rows.Count = 0) Then
            sbValidar.Append("Ingrese Embarques.")
        End If
        Return sbValidar.ToString.Trim
    End Function
   
#End Region

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf (e.KeyChar) = "." And txtCantidad.Text.Trim <> "" And Not txtCantidad.Text.Trim.Contains(".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If

    End Sub

    Private Sub dtpFechServicio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechServicio.Leave
        Try
            If (bolBuscar = True) Then
                CargarServicioxCliente(Me.dtpFechServicio.Value.ToString("yyyyMMdd"))
                If (IsNumeric(cmbServicio.ComboBox.Tag)) Then
                    Me.cmbServicio.ComboBox.SelectedValue = cmbServicio.ComboBox.Tag
                Else
                    Me.cmbServicio.ComboBox.SelectedValue = "-1"
                End If
                cmbServicio_SelectedIndexChanged(cmbServicio, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcClienteOperacion_InformationChanged() Handles UcClienteOperacion.InformationChanged
        Try
            If (UcClienteOperacion.pCodigo <> 0) Then
                dtgEmbarque.Rows.Clear()
                dgServicio.Rows.Clear()
                CargarServicioxCliente(dtpFechServicio.Value.ToString("yyyyMMdd"))
                UcClienteFacturacion.pCargar(UcClienteOperacion.pCodigo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnElEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElEmbarque.Click
        Try
            Dim msgInformativo As String = ""
            Dim PNNORSCI As Decimal = 0
            Dim PNNRITEM As Decimal = 0
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            Dim retorno As Int32 = 0
            Dim PNFLAG_REGISTRO As Int32 = 0
            If (dtgEmbarque.CurrentRow IsNot Nothing) Then
                PNFLAG_REGISTRO = dtgEmbarque.CurrentRow.Cells("FLAG_REGISTRO").Value
                PNNORSCI = dtgEmbarque.CurrentRow.Cells("NORSCI").Value
                PNNRITEM = dtgEmbarque.CurrentRow.Cells("NRITEM").Value
                If (PNFLAG_REGISTRO = 1) Then
                    msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                    If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        Dim oEmbarqueServicio As New Servicio_BE
                        oEmbarqueServicio.CCLNT = UcClienteOperacion.pCodigo
                        oEmbarqueServicio.NOPRCN = _pbeServicioFacturar.NOPRCN
                        oEmbarqueServicio.NORSCI = PNNORSCI
                        oEmbarqueServicio.PSUSUARIO = ConfigurationWizard.UserName
                        oEmbarqueServicio.NRITEM = PNNRITEM
                        retorno = obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio)
                        If (retorno = 1) Then
                            _pDialogResult = True
                            dtgEmbarque.Rows.RemoveAt(dtgEmbarque.CurrentRow.Index)
                        End If
                    End If
                Else
                    dtgEmbarque.Rows.RemoveAt(dtgEmbarque.CurrentRow.Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarDatosServicio()
        txtTarifa.Clear()
        txtCentroCosto.Clear()
        txtTarifaAplicar.Clear()
        txtValorServicio.Clear()
        txtUnidadMedida.Clear()
    End Sub
    Private Function HabilitarCantidadTarifa(ByVal PSSTPTRA As String) As Boolean
        Dim Habilitar As Boolean = IIf(PSSTPTRA.Trim = "F", False, True)
        Return Habilitar
    End Function

    Private Sub cmbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServicio.SelectedIndexChanged
        Try
            If (bolBuscar = True) Then
                Dim PSSTPTRA As String = ""
                LimpiarDatosServicio()
                If (cmbServicio.ComboBox.SelectedValue <> "-1") Then
                    Dim odtTarifa As New DataTable
                    cmbServicio.ComboBox.Tag = cmbServicio.ComboBox.SelectedValue
                    Dim obrclsServicioSC_BL As New clsServicioSC_BL
                    odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(cmbServicio.ComboBox.SelectedValue)
                    If (odtTarifa.Rows.Count > 0) Then
                        txtTarifa.Text = cmbServicio.ComboBox.SelectedValue
                        txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
                        PSSTPTRA = odtTarifa.Rows(0)("STPTRA").ToString.Trim.ToUpper
                        txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA_DESC").ToString.Trim
                        txtTarifaAplicar.Tag = PSSTPTRA
                        txtValorServicio.Text = odtTarifa.Rows(0)("IVLSRV").ToString.Trim
                        txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
                        If (PSSTPTRA = "F") Then
                            txtCantidad.Text = 1
                        End If
                        txtCantidad.Enabled = HabilitarCantidadTarifa(PSSTPTRA)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


   
    Private Function BuscarTarifaEnAsignacion(ByVal NRTFSV As Decimal) As String
        Dim MENSAJE As String = ""
        Dim ENCONTRADO As Boolean = False
        For Each Item As DataGridViewRow In dgServicio.Rows
            If (Item.Cells("NRTFSV").Value = NRTFSV) Then
                ENCONTRADO = True
                Exit For
            End If
        Next
        If (ENCONTRADO = True) Then
            MENSAJE = "Verifique el servicio a ingresar.Este servicio ya se encuentra asignado."
        End If
        Return MENSAJE
    End Function

    Private Sub btnAdServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdServicio.Click
        Dim NRTFSV As Decimal = 0
        Dim NOPRCN As Decimal = 0
        Dim msgValidar As String = ""
        Dim STPTRA As String = ""
        Dim msgValidacion As New StringBuilder
        txtCantidad.Focus()
        Try
            If (IsPosibleAdicionarServicio() = False) Then
                msgValidacion.Append("No puede adicionar más servicios.Tener en cuenta:")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios servicios deben ser asignados como máximo a un Embarque o")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios Embarques deben ser asignados a un Servicio.")
                MessageBox.Show(msgValidacion.ToString.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            msgValidar = ValidarIngresoDatoServicio()
            If (msgValidar.Length <> 0) Then
                MessageBox.Show(msgValidar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                NRTFSV = cmbServicio.ComboBox.SelectedValue
                Dim msgBusquedaTarifa As String = BuscarTarifaEnAsignacion(NRTFSV)
                If (msgBusquedaTarifa.Length <> 0) Then
                    MessageBox.Show(msgBusquedaTarifa, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim FILA As Int32 = 0
                Dim CANTIDAD_SERV As Decimal = 0
                Dim oDrVw As New DataGridViewRow
                STPTRA = txtTarifaAplicar.Tag.ToString.Trim
                oDrVw.CreateCells(Me.dgServicio)
                Me.dgServicio.Rows.Add(oDrVw)
                FILA = dgServicio.Rows.Count - 1
                Decimal.TryParse(txtNroOperacion.Text, NOPRCN)
                Decimal.TryParse(txtCantidad.Text, CANTIDAD_SERV)
                dgServicio.Rows(FILA).Cells("NOPRCN").Value = NOPRCN
                dgServicio.Rows(FILA).Cells("NRTFSV").Value = NRTFSV
                dgServicio.Rows(FILA).Cells("DESTAR").Value = cmbServicio.ComboBox.Text.Trim
                dgServicio.Rows(FILA).Cells("CTPALJ").Value = "AD"
                dgServicio.Rows(FILA).Cells("NCRROP").Value = 0 'INDICANDO QUE EL CORRELATIVO RECIEN SE VA ADICIONAR
                dgServicio.Rows(FILA).Cells("QATNAN").Value = CANTIDAD_SERV
                dgServicio.Rows(FILA).Cells("QATNAN").ReadOnly = Not HabilitarCantidadTarifa(STPTRA)
                dgServicio.Rows(FILA).Cells("IVLSRV").Value = txtValorServicio.Text
                dgServicio.Rows(FILA).Cells("STATUS").Value = "0" 'AUN NO SE VA ADICIONAR A LA BD
                dgServicio.Rows(FILA).Cells("CUNDMD").Value = txtUnidadMedida.Text
                dgServicio.Rows(FILA).Cells("STPTRA_DESC").Value = txtTarifaAplicar.Text
                dgServicio.Rows(FILA).Cells("NRTFSV").Style.BackColor = Color.FromArgb(224, 224, 224)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnElServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElServicio.Click
        Dim msg As String = ""
        Dim Fila As Int32 = 0
        Dim msgEliminar As String = ""
        Try
            If (dgServicio.CurrentRow IsNot Nothing) Then
                Dim PSCTPALJ As String = ""
                Dim STATUS As String = ""
                Fila = dgServicio.CurrentRow.Index
                PSCTPALJ = dgServicio.Rows(Fila).Cells("CTPALJ").Value
                STATUS = dgServicio.Rows(Fila).Cells("STATUS").Value
                If (STATUS = "1") Then 'SERVICIO EN LA BASE DE DATOS
                    Dim servicio As String = ""
                    servicio = dgServicio.Rows(Fila).Cells("NRTFSV").Value & "-" & dgServicio.Rows(Fila).Cells("DESTAR").Value.ToString.Trim
                    msgEliminar = "Está seguro de eliminar el servicio:" & Chr(13) & servicio
                    'If (dgServicio.Rows.Count = 1) Then
                    '    msgEliminar = msgEliminar & Chr(13) & "Al eliminar este servicio se va a eliminar la operación y todos sus datos."
                    'End If
                    If (MessageBox.Show(msgEliminar, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        Dim retorno As Int32 = 0
                        Dim obrServicio As New clsServicioSC_BL
                        Dim obeServicioFacturar As New Servicio_BE
                        Dim obrclsServicio_BL As New clsServicio_BL
                        obeServicioFacturar.CCLNT = UcClienteOperacion.pCodigo
                        obeServicioFacturar.NOPRCN = dgServicio.Rows(Fila).Cells("NOPRCN").Value
                        obeServicioFacturar.NCRROP = dgServicio.Rows(Fila).Cells("NCRROP").Value
                        obeServicioFacturar.NRTFSV = dgServicio.Rows(Fila).Cells("NRTFSV").Value
                        obeServicioFacturar.PSUSUARIO = ConfigurationWizard.UserName
                        retorno = obrServicio.Eliminar_Item_Servicio_SC(obeServicioFacturar)
                        If (retorno = 1) Then
                            dgServicio.Rows.RemoveAt(Fila)
                            'If (dgServicio.Rows.Count = 0) Then
                            '    obrclsServicio_BL.Quitar_Servicio(obeServicioFacturar)
                            '    DialogResult = Windows.Forms.DialogResult.OK
                            'End If
                        End If
                    End If
                ElseIf STATUS = "0" Then ' SERVICIO ADICIONADO SOLO EN LA INTERFAZ
                    dgServicio.Rows.RemoveAt(Fila)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarIngresoDatoServicio() As String
        Dim sbmsg As New StringBuilder
        Dim ExitoConv As Boolean = False
        Dim Cantidad As Decimal = 0
        If (UcClienteOperacion.pCodigo = 0) Then
            sbmsg.Append("Ingrese Cliente*")
            sbmsg.AppendLine()
        End If
        ExitoConv = Decimal.TryParse(txtCantidad.Text.Trim, Cantidad)
        If (ExitoConv = False) Then
            sbmsg.Append("Ingrese cantidad. *")
            sbmsg.AppendLine()
        ElseIf Cantidad <= 0 Then
            sbmsg.Append("La cantidad debe ser mayor a cero. *")
            sbmsg.AppendLine()
        End If
        If (cmbServicio.ComboBox.SelectedValue = "-1" OrElse cmbServicio.Text.Trim.Length = 0) Then
            sbmsg.Append("Seleccione Servicio. *")
        End If
        Return sbmsg.ToString.Trim
    End Function

    Private Function ValidarItemDetalleOperacion() As String
        Dim msgValidacion As New StringBuilder
        Dim QATNAN As Decimal = 0
        Dim CantidadValida As Boolean = True
        Dim ExitoValidacion As Boolean = True
        Dim CantidadServicios As Int32 = 0
        Dim CantidadEmbarques As Int32 = 0
        Dim TipoOperacion As String = ""

        If (UcClienteOperacion.pCodigo = 0) Then
            msgValidacion.Append("Seleccione Cliente de Operación. *")
            msgValidacion.AppendLine()
        End If

        If (UcClienteFacturacion.pCodigo = 0) Then
            msgValidacion.Append("Seleccione Cliente a Facturar. *")
            msgValidacion.AppendLine()
        End If
        CantidadServicios = dgServicio.Rows.Count
        CantidadEmbarques = dtgEmbarque.Rows.Count

        If (CantidadServicios = 0) Then
            msgValidacion.Append("Debe ingresar Servicio(s). *")
            msgValidacion.AppendLine()
        End If
        For FILA As Integer = 0 To dgServicio.Rows.Count - 1
            Decimal.TryParse(dgServicio.Rows(FILA).Cells("QATNAN").Value, QATNAN)
            If (QATNAN <= 0 OrElse QATNAN > 9999999999) Then
                CantidadValida = False
                Exit For
            End If
        Next
        If (CantidadValida = False) Then
            msgValidacion.Append("Las cantidades de los servicios deben ser mayores a cero y menor a 9 999 999 999 999")
            msgValidacion.AppendLine()
        End If
        'If (CantidadServicios > 0 AndAlso CantidadEmbarques > 0) Then
        '    If (IsAsignacionCorrecta() = False) Then
        '        msgValidacion.Append("Tener en cuenta:")
        '        msgValidacion.AppendLine()
        '        msgValidacion.Append("Varios servicios deben ser asignados como máximo a un Embarque o")
        '        msgValidacion.AppendLine()
        '        msgValidacion.Append("Varios Embarques deben ser asignados a un Servicio.")
        '    End If
        'End If
        Return msgValidacion.ToString
    End Function

    'Private Function IsAsignacionCorrecta() As Boolean
    '    Dim CantidadServicios As Int32 = 0
    '    Dim CantidadEmbarques As Int32 = 0
    '    Dim ValidarAsignacion As Boolean = False
    '    CantidadServicios = dgServicio.Rows.Count
    '    CantidadEmbarques = dtgEmbarque.Rows.Count
    '    If (CantidadServicios > 0 AndAlso CantidadEmbarques > 0) Then
    '        ValidarAsignacion = (CantidadServicios = 1 And CantidadEmbarques >= 1)
    '        ValidarAsignacion = ValidarAsignacion OrElse (CantidadServicios >= 1 And CantidadEmbarques = 0)
    '    End If
    '    Return ValidarAsignacion
    'End Function

    Private Function IsPosibleAdicionarServicio() As Boolean
        Dim CantidadServicios As Int32 = 0
        Dim CantidadEmbarques As Int32 = 0
        Dim ValidarAsignacion As Boolean = False
        CantidadServicios = dgServicio.Rows.Count
        CantidadEmbarques = dtgEmbarque.Rows.Count
        If (CantidadServicios = 0 OrElse CantidadEmbarques = 0 OrElse CantidadEmbarques = 1) Then
            ValidarAsignacion = True
        End If
        Return ValidarAsignacion
    End Function
    Private Function IsPosibleAdicionarEmbarque() As Boolean
        Dim CantidadServicios As Int32 = 0
        Dim CantidadEmbarques As Int32 = 0
        Dim ValidarAsignacion As Boolean = False
        CantidadServicios = dgServicio.Rows.Count
        CantidadEmbarques = dtgEmbarque.Rows.Count
        If (CantidadEmbarques = 0 OrElse CantidadServicios = 0 OrElse CantidadServicios = 1) Then
            ValidarAsignacion = True
        End If
        Return ValidarAsignacion
    End Function



    Private Sub txtBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
End Class
