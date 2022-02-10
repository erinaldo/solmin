Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports System.Text
Public Class frmTarifasDeServiciosDesp

#Region "Propiedades y atributos"


    Private CCMPN As String = ""
    Public Property CodCompania() As String
        Get
            Return CCMPN
        End Get
        Set(ByVal value As String)
            CCMPN = value
        End Set
    End Property


    Private CDVSN As String = ""
    Public Property CodDivision() As String
        Get
            Return CDVSN
        End Get
        Set(ByVal value As String)
            CDVSN = value
        End Set
    End Property


    Private CCLNT As Double = 0
    Public Property CodCliente() As Double
        Get
            Return CCLNT
        End Get
        Set(ByVal value As Double)
            CCLNT = value
        End Set
    End Property


    Private CCLNFC As Double = 0

    Public Property CodClienteFacturacion() As Double
        Get
            Return CCLNFC
        End Get
        Set(ByVal value As Double)
            CCLNFC = value
        End Set
    End Property


    Private NORSCI As Double
    Public Property Embarque() As Double
        Get
            Return NORSCI
        End Get
        Set(ByVal value As Double)
            NORSCI = value
        End Set
    End Property

    Private FECSRV As Double = 0
    Public Property FechaDeServicio() As Double
        Get
            Return FECSRV
        End Get
        Set(ByVal value As Double)
            FECSRV = value
        End Set
    End Property

    Private CPLNDV As Double = 0
    Public Property PlantaFacturacion() As Double
        Get
            Return CPLNDV
        End Get
        Set(ByVal value As Double)
            CPLNDV = value
        End Set
    End Property

    Private _QFACTOR As Decimal = 0
    Public Property QFACTOR() As Decimal
        Get
            Return _QFACTOR
        End Get
        Set(ByVal value As Decimal)
            _QFACTOR = value
        End Set
    End Property


    Private _NRO_TARIFA As Decimal = 0
    Public Property NRO_TARIFA() As Decimal
        Get
            Return _NRO_TARIFA
        End Get
        Set(ByVal value As Decimal)
            _NRO_TARIFA = value
        End Set
    End Property


    Private oDrTarifa As New DataGridViewRow
    Public ReadOnly Property TarifaDeServicios() As DataGridViewRow
        Get
            Return oDrTarifa
        End Get

    End Property


    Private _TipoAsignacion As Tipo_Asignacion = Tipo_Asignacion.Tarifa
    Public Property TipoAsignacion() As Tipo_Asignacion
        Get
            Return _TipoAsignacion
        End Get
        Set(ByVal value As Tipo_Asignacion)
            _TipoAsignacion = value
        End Set
    End Property

    Private _CDIRSE As Decimal
    Public Property CDIRSE() As Decimal
        Get
            Return _CDIRSE
        End Get
        Set(ByVal value As Decimal)
            _CDIRSE = value
        End Set
    End Property

    Enum Tipo_Asignacion
        PreTarifa
        Tarifa
    End Enum


#End Region

#Region "eventos"
    Private Sub frmTarifasDeServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            dtgTarifaPorEmbarque.AutoGenerateColumns = False

            UcClienteFacturacion.pAccesoPorUsuario = True
            UcClienteFacturacion.pUsuario = HelpUtil.UserName
            UcClienteOperacion.pAccesoPorUsuario = True
            UcClienteOperacion.pUsuario = HelpUtil.UserName
            Dim msgVigenciaContrato As String = ""

            txtFechaServicio.Text = HelpClass.CNumero8Digitos_a_FechaDefault(FECSRV)
            txtCantidad.Text = Val(QFACTOR.ToString)

            UcClienteOperacion.pCargar(CCLNT)
            UcClienteOperacion.Enabled = False
            UcClienteFacturacion.pCargar(CCLNFC)
            msgVigenciaContrato = ExisteContratoVigente()
            CargarPlanta()
            If msgVigenciaContrato.Length > 0 Then
                MessageBox.Show(msgVigenciaContrato, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim obrEmbarque As New clsEmbarque
            Dim oParametros As New Hashtable
            oParametros.Add("PSCCMPN", CCMPN)
            oParametros.Add("PSCDVSN", CDVSN)
            oParametros.Add("PNCCLNT", CCLNT)
            oParametros.Add("PNNORSCI", NORSCI)
            oParametros.Add("PNFECSRV", FECSRV)
            oParametros.Add("PNNRTFSV", _NRO_TARIFA)
            Me.dtgTarifaPorEmbarque.DataSource = obrEmbarque.CargarTarifaEmbarque_x_tarifa(oParametros)
            If dtgTarifaPorEmbarque.Rows.Count = 0 Then
                MessageBox.Show("NO EXISTE TARIFA PARA EL SERVICIO DE MANAGEMENT FEE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'HelpUtil.MsgBox("ERROR: NO EXISTE TARIFA PARA EL SERVICIO DE MANAGEMENT FEE")
            End If

            If _NRO_TARIFA <> 0 Then
                lblTarifa.Text = "Nro tarifa: " & _NRO_TARIFA
            End If
            If _TipoAsignacion = Tipo_Asignacion.PreTarifa Then

                UcClienteFacturacion.Enabled = False
                lblCantidad.Visible = False
                txtCantidad.Visible = False
                lblSubtotal.Visible = False
                txtSubtotal.Visible = False
                KryptonLabel1.Visible = False
                txtFechaServicio.Visible = False

            End If
            CargarDirServicioXDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CargarPlanta()
        cmbPlanta.Enabled = False
        'Try
        Dim oPlanta As New Ransa.Controls.ServicioOperacion.clsPlantaNeg
        oPlanta.Crea_Lista(HelpUtil.UserName)
        cmbPlanta.DataSource = oPlanta.Lista_Planta(CCMPN, CDVSN)
        cmbPlanta.ValueMember = "CPLNDV"
        cmbPlanta.DisplayMember = "TPLNTA"
        cmbPlanta.SelectedValue = CPLNDV
        'Catch ex As Exception
        'End Try
    End Sub

  

  
#End Region

#Region "Metodos"
    Private Function ExisteContratoVigente() As String
        Dim obrEmbarque As New clsEmbarque
        Dim msg As String = ""
        Dim oParametros As New Hashtable
        oParametros.Add("PNCCLNT", CCLNT)
        oParametros.Add("PNFECSRV", FECSRV)
        Dim dtContrato As New DataTable
        dtContrato = obrEmbarque.CargarTarifaContrato(oParametros)
        If dtContrato.Rows.Count = 0 Then
            msg = msg & "Verificar:"
            msg = msg & Chr(13) & "* Si existe el contrato"
            msg = msg & Chr(13) & " * Si el contrato se encuentra vigente a la Fecha :" & Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(FECSRV)
            msg = msg & Chr(13) & " * Si existen tarifas para EL SERVICIO DE MANAGEMENT FEE "
        End If
        Return msg
    End Function

  
#End Region


  
    Private Function ValidarTarifa() As String
        Dim msgValidacion As String = ""
        Dim strTipo As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("STPTRA").Value).ToString.Trim
        Dim strUnidad As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("CUNDMD").Value).ToString.Trim
        Dim dblTarifa As Decimal = dtgTarifaPorEmbarque.CurrentRow.Cells("IVLSRV").Value
        If UcClienteFacturacion.pCodigo = 0 Then
            msgValidacion = msgValidacion & "Seleccione  cliente Facturación"
        End If
        '*********VALIDACION TARIFA**************************
        'Dim EsValida As Boolean = False
        'If (strTipo = "F" AndAlso strUnidad = "MES") OrElse (strTipo = "C" AndAlso strUnidad = "OS") Then
        '    EsValida = True
        'Else
        '    EsValida = False
        'End If
        'If EsValida = False Then
        '    msgValidacion = msgValidacion & "* Las Tarifas no son válidas para el Cierre Automático."
        '    msgValidacion = msgValidacion & Chr(13) & "  Verifique Tarifa:(Tipo-F,Unidad-MES) o (Tipo-C,Unidad-OS)"
        'End If
        '*****************************************
        If cmbPlanta.SelectedValue Is Nothing Then
            msgValidacion = msgValidacion & Chr(13) & " Verifique acceso a la planta"
        End If

        Return msgValidacion
    End Function

    Private Function DatosTarifaSeleccionada() As String
        Dim sb As New StringBuilder
        sb.AppendLine(String.Format("Cod Tarifa: {0}", dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value))
        sb.AppendLine(String.Format("Servicio: {0}", dtgTarifaPorEmbarque.CurrentRow.Cells("DESTAR").Value.ToString.Trim))
        sb.AppendLine(String.Format("Moneda: {0}", dtgTarifaPorEmbarque.CurrentRow.Cells("CMNDA1").Value.ToString.Trim))
        sb.Append(String.Format("Valor Servicio: {0}", dtgTarifaPorEmbarque.CurrentRow.Cells("IVLSRV").Value.ToString.Trim))
        Return sb.ToString.Trim
    End Function
   

    'Private Sub Cargar_ClienteFacturacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgTarifaPorEmbarque.SelectionChanged
    '    Try
    '        If dtgTarifaPorEmbarque.Rows.Count > 0 Then
    '            Dim obrEmbarque As New clsEmbarque
    '            UcClienteFacturacion.Enabled = True
    '            Dim strTipo As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("STPTRA").Value)
    '            Dim strUnidad As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("CUNDMD").Value)
    '            Dim CCLNFC As Decimal = 0
    '            If (strTipo = "F" AndAlso strUnidad = "MES") Then
    '                Dim dt As New DataTable
    '                Dim tarifa As Double = dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value()
    '                dt = obrEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
    '                If dt.Rows.Count > 0 Then
    '                    CCLNFC = dt.Rows(0).Item("CCLNFC")
    '                    UcClienteFacturacion.Enabled = False
    '                    If dt.Rows(0).Item("CCLNFC") = 0 Then
    '                        UcClienteFacturacion.Enabled = True
    '                    End If
    '                Else
    '                    CCLNFC = CCLNT
    '                    UcClienteFacturacion.Enabled = True
    '                End If
    '            Else
    '                CCLNFC = CCLNT
    '            End If

    '            UcClienteFacturacion.pCargar(CCLNFC)
    '        Else
    '            UcClienteFacturacion.Enabled = True
    '            UcClienteFacturacion.pCargar(CCLNT)
    '        End If
    '        If _Tipo = 1 Then
    '            UcClienteFacturacion.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Cargar_ClienteFacturacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgTarifaPorEmbarque.SelectionChanged
        Try
            Calcular_SubTotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Calcular_SubTotal()
        Dim valor_servicio As Decimal = 0
        Dim CantidadFactor As Decimal = 0
        Dim TipoTarifa As String = ""
        If dtgTarifaPorEmbarque.CurrentRow IsNot Nothing Then
            valor_servicio = dtgTarifaPorEmbarque.CurrentRow.Cells("IVLSRV").Value
            TipoTarifa = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("STPTRA").Value).ToString.Trim
        End If
        CantidadFactor = Val(txtCantidad.Text.Trim)
        Select Case TipoTarifa
            Case "C"
                txtSubtotal.Text = Val(valor_servicio * CantidadFactor)
            Case "F"
                txtSubtotal.Text = Val(valor_servicio)
            Case Else
                txtSubtotal.Text = Val(valor_servicio * CantidadFactor)
        End Select

    End Sub


    Private Sub CargarDirServicioXDefecto()

        Dim oDt As New DataTable
        Dim oServicioBL As New clsServicio
        oDt = oServicioBL.fdtListaDirServicxDefecto(CCMPN, CDVSN, UcClienteOperacion.pCodigo, UcClienteFacturacion.pCodigo, cmbPlanta.SelectedValue, 0)

        If oDt.Rows.Count > 0 Then
            txtDireccion.Text = oDt.Rows.Item(0)("DEDISE").ToString()
            txtUbigeo.Text = oDt.Rows.Item(0)("UBIGEO").ToString()
            CDIRSE = oDt.Rows.Item(0)("CDIRSE").ToString()
        Else
            txtDireccion.Text = String.Empty
            txtUbigeo.Text = String.Empty
            CDIRSE = 0
        End If


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.dtgTarifaPorEmbarque.CurrentCellAddress.Y < 0 Then Exit Sub

            Dim msgValidaciontarifa As String = ValidarTarifa()
            If msgValidaciontarifa.Length > 0 Then
                MessageBox.Show(msgValidaciontarifa, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Val(txtCantidad.Text.Trim) = 0 Then
                MessageBox.Show("Cantidad/Factor debe ser mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim msgTarifa As String = DatosTarifaSeleccionada()
            If MessageBox.Show("Está seguro de la tarifa seleccionada ? " & Chr(13) & msgTarifa, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            If CDIRSE = 0 Then
                MessageBox.Show("Seleccione Dir. Del Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If


            CCLNFC = UcClienteFacturacion.pCodigo
            CPLNDV = cmbPlanta.SelectedValue
            oDrTarifa = Me.dtgTarifaPorEmbarque.CurrentRow

            QFACTOR = CDec(IIf(txtCantidad.Text.Trim = String.Empty, 0D, txtCantidad.Text.Trim))


            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        Try
            Calcular_SubTotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim ofrm As New Ransa.Utilitario.frmBuscarDireccionServicio
            ofrm.PSCCMPN = CCMPN
            ofrm.PSCDVSN = CDVSN
            ofrm.PNCCLNTOP = UcClienteOperacion.pCodigo
            ofrm.PNCCLNTFC = UcClienteFacturacion.pCodigo
            ofrm.PNCPLNDVOP = cmbPlanta.SelectedValue
            ofrm.PNCPLNDVFC = 0
            ofrm.PSTIPODIR = "P"

            If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtDireccion.Text = ofrm.DatoDireccion
                txtUbigeo.Text = ofrm.DatoUbigeo
                CDIRSE = ofrm.DatoCodigo
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KryptonLabel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonLabel2.Paint

    End Sub
End Class
