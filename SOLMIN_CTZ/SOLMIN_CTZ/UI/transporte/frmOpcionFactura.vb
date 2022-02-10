Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOpcionFactura

#Region "Atributos"

    Private intEstado As Int32 = 0
    Private strCompania As String = ""
    Private strDivision As String = ""
    Private decPlanta As Decimal = 0
    Private odtPlantaZonaFacturacion As New DataTable
    Private boolCargado As Boolean = False
    Private iCodigoMoneda As Integer = 0

#End Region

#Region "Properties"

    Public WriteOnly Property Estado() As Int32
        Set(ByVal value As Int32)
            intEstado = value
        End Set
    End Property

    Public WriteOnly Property Compania() As String
        Set(ByVal value As String)
            strCompania = value
        End Set
    End Property
    Public WriteOnly Property Division() As String
        Set(ByVal value As String)
            strDivision = value
        End Set
    End Property
    Public WriteOnly Property CodigoMoneda() As Integer
        Set(ByVal value As Integer)
            iCodigoMoneda = value
        End Set
    End Property

    Public ReadOnly Property Planta() As Decimal
        Get
            Return decPlanta
        End Get
    End Property

#End Region

#Region "Eventos"

    Private Sub frmOpcionFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objPlantaFacturacion As New SOLMIN_CTZ.NEGOCIO.PlantaFacturacion_BLL
        Try
            If intEstado <> 0 Then
                Me.rbtnPreFactura.Checked = False
                Me.rbtnFactura.Checked = True
                Me.gpbTipoDocumento.Enabled = False
            End If
            Select Case iCodigoMoneda
                Case 1
                    'Me.gpbMoneda.Enabled = False
                    Me.rbtnDolares.Checked = False
                    Me.rbtnSoles.Checked = True
                Case 100
                    'Me.gpbMoneda.Enabled = False
                    Me.rbtnDolares.Checked = True
                    Me.rbtnSoles.Checked = False

            End Select
            Dim dtFechaActual As Date
            Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.Operaciones.Factura_Transporte_BLL
            dtFechaActual = oFacturaNeg.Obtener_Fecha_Servidor
            Me.dtpFechaFactura.Value = dtFechaActual
            Me.dtpFechaServicio.Value = dtFechaActual
            Select Case dtFechaActual.Day
                Case 1, 2
                    Me.lblFechaFactura.Visible = True
                    Me.dtpFechaFactura.Visible = True
            End Select
            Select Case dtFechaActual.Month
                Case 4
                    Me.chkFechaServicio.Visible = True
                    Me.dtpFechaServicio.Visible = True
            End Select

            Me.CargarPlanta()
            Me.Cargar_Zona_Facturación()
            Me.Cargar_Tipo_Factura()
            boolCargado = True
            odtPlantaZonaFacturacion = objPlantaFacturacion.Listar_Planta_Zona_Facturacion(strCompania, strDivision)
            ListaZonaFacturacionPorDefecto(cmbPlanta.Planta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaZonaFacturacionPorDefecto(ByVal Planta As Decimal)
        Dim CZNFCC As Decimal = 0
        Dim drPlanta() As DataRow
        drPlanta = odtPlantaZonaFacturacion.Select("CPLNDV=" & Planta)
        If (drPlanta.Length > 0) Then
            CZNFCC = drPlanta(0)("CZNFCC")
            cboZonaFacturacion.Codigo = CZNFCC
        Else
            If (strCompania = "EZ") Then
                cboZonaFacturacion.Codigo = "32"
            Else
                cboZonaFacturacion.Limpiar()
            End If
        End If
    End Sub

    Private Sub CargarPlanta()
        cmbPlanta.Usuario = ConfigurationWizard.UserName
        cmbPlanta.CodigoCompania = strCompania
        cmbPlanta.CodigoDivision = strDivision
        cmbPlanta.PlantaDefault = 1
        cmbPlanta.pActualizar()
    End Sub

    Private Sub rbtnFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnFactura.CheckedChanged
        Try
            If Me.rbtnFactura.Checked = True Then
                Me.gpbMoneda.Enabled = True
                Me.txtPreFactura.Text = ""
                Me.cboZonaFacturacion.Enabled = True
            Else
                Me.gpbMoneda.Enabled = False
                Me.txtPreFactura.Text = Me.txtPreFactura.Tag
                Me.cboZonaFacturacion.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarIngreso() As String
        Dim msgValidacion As New StringBuilder
        If cboZonaFacturacion.NoHayCodigo = True Then
            msgValidacion.Append("Selecione Zona Facturación")
        End If
        Return msgValidacion.ToString.Trim
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim msgValidacion As String
        msgValidacion = ValidarIngreso()
        If (msgValidacion.Length <> 0) Then
            MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Me.Tag = Me.cboTipoFactura.ComboBox.SelectedIndex
        'Me.Tag = Me.cboTipoFactura.SelectedIndex
        Me.Tag = Me.cboTipoFactura.SelectedValue
        decPlanta = cmbPlanta.Planta
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub chkFechaServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaServicio.CheckedChanged
        Me.dtpFechaServicio.Enabled = Me.chkFechaServicio.Checked
    End Sub

    Private Sub cmbPlanta_Seleccionar(ByVal obePlanta As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta) Handles cmbPlanta.Seleccionar
        Try
            If (boolCargado = True) Then
                ListaZonaFacturacionPorDefecto(cmbPlanta.Planta)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Métodos"
    Private Sub Cargar_Zona_Facturación()
        Dim objPlantaFacturacion As New SOLMIN_CTZ.NEGOCIO.PlantaFacturacion_BLL
        Try
            With Me.cboZonaFacturacion
                .DataSource = objPlantaFacturacion.Listar_Planta_Facturacion_Combo(strCompania)
                .KeyField = "CZNFCC"
                .ValueField = "TZNFCC"
                .DataBind()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub Cargar_Tipo_Factura()
    '  Me.cboTipoFactura.ComboBox.DisplayMember = "ESTADO"
    '  Me.cboTipoFactura.ComboBox.ValueMember = "VALUE"
    '  Me.cboTipoFactura.ComboBox.DataSource = Tipo_Factura()
    'End Sub
    Private Sub Cargar_Tipo_Factura()
        Me.cboTipoFactura.DisplayMember = "ESTADO"
        Me.cboTipoFactura.ValueMember = "VALUE"
        Me.cboTipoFactura.DataSource = Tipo_Factura()
        cboTipoFactura.SelectedValue = 0
    End Sub

    Private Function Tipo_Factura() As DataTable
        Dim odt As New DataTable
        odt.TableName = "dtListaTipoFactura"
        Dim oDr As DataRow
        odt.Columns.Add("VALUE", Type.GetType("System.Int32"))
        odt.Columns.Add("ESTADO", Type.GetType("System.String"))

        oDr = odt.NewRow
        oDr.Item("VALUE") = 0
        oDr.Item("ESTADO") = "NORMAL"
        odt.Rows.Add(oDr)

        oDr = odt.NewRow
        oDr.Item("VALUE") = 1
        oDr.Item("ESTADO") = "RESUMIDA"
        odt.Rows.Add(oDr)

        oDr = odt.NewRow
        oDr.Item("VALUE") = 2
        oDr.Item("ESTADO") = "DETALLADA"
        odt.Rows.Add(oDr)


        oDr = odt.NewRow
        oDr.Item("VALUE") = 3
        oDr.Item("ESTADO") = "LOTE"
        odt.Rows.Add(oDr)

        Return odt

    End Function

#End Region

End Class