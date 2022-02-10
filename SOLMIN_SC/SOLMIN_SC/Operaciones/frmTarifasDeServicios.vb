Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports System.Text
Public Class frmTarifasDeServicios

#Region "Propiedades y atributos"


    Private CCMPN As String
    Private CPLNDV As Double
    ''' <summary>
    ''' Compañia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodCompania() As String
        Get
            Return CCMPN
        End Get
        Set(ByVal value As String)
            CCMPN = value
        End Set
    End Property


    Private CDVSN As String

    ''' <summary>
    ''' División
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodDivision() As String
        Get
            Return CDVSN
        End Get
        Set(ByVal value As String)
            CDVSN = value
        End Set
    End Property

    Public Property CodPlanta() As Double
        Get
            Return CPLNDV
        End Get
        Set(ByVal value As Double)
            CPLNDV = value
        End Set
    End Property

    Private CCLNT As Double
    ''' <summary>
    ''' Código de Cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodCliente() As Double
        Get
            Return CCLNT
        End Get
        Set(ByVal value As Double)
            CCLNT = value
        End Set
  End Property


  Private CCLNFC As Double

  Public Property CodClienteFacturacion() As Double
    Get
      Return CCLNFC
    End Get
    Set(ByVal value As Double)
      CCLNFC = value
    End Set
  End Property


    Private NORSCI As Double
    ''' <summary>
    ''' Codigo de Embarque
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Embarque() As Double
        Get
            Return NORSCI
        End Get
        Set(ByVal value As Double)
            NORSCI = value
        End Set
    End Property

    Private FECSRV As Double
    ''' <summary>
    ''' Fecha de Servicio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaDeServicio() As Double
        Get
            Return FECSRV
        End Get
        Set(ByVal value As Double)
            FECSRV = value
        End Set
    End Property


    ''' <summary>
    ''' Fecha de Servicio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PlantaFacturacion() As Double
        Get
            Return CPLNDV
        End Get
        Set(ByVal value As Double)
            CPLNDV = value
        End Set
    End Property


    '


    Private oDrTarifa As New DataGridViewRow
    Public ReadOnly Property TarifaDeServicios() As DataGridViewRow
        Get
            Return oDrTarifa
        End Get

  End Property

    Private PNCCNTCS As String
    Public Property CodCentroBeneficio() As String
        Get
            Return PNCCNTCS
        End Get
        Set(ByVal value As String)
            PNCCNTCS = value
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



#End Region

#Region "eventos"
    Private Sub frmTarifasDeServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        UcClienteFacturacion.pAccesoPorUsuario = True
        UcClienteFacturacion.pUsuario = HelpUtil.UserName
        UcClienteOperacion.pAccesoPorUsuario = True
        UcClienteOperacion.pUsuario = HelpUtil.UserName
        Dim msgVigenciaContrato As String = ""
        Try

            txtFechaServicio.Text = HelpClass.CNumero8Digitos_a_FechaDefault(FECSRV)

            UcClienteOperacion.pCargar(CCLNT)
            UcClienteOperacion.Enabled = False
            msgVigenciaContrato = ExisteContratoVigente()
            CargarPlanta()
            If msgVigenciaContrato.Length > 0 Then
                MessageBox.Show(msgVigenciaContrato, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'CargarTarifaEmbarque()
            Dim obrEmbarque As New clsEmbarque
            Dim oParametros As New Hashtable
            oParametros.Add("PSCCMPN", CCMPN)
            oParametros.Add("PSCDVSN", CDVSN)
            oParametros.Add("PNCCLNT", CCLNT)
            oParametros.Add("PNNORSCI", NORSCI)
            oParametros.Add("PNFECSRV", FECSRV)
            oParametros.Add("PNCPLNDV", CPLNDV)
            Me.dtgTarifaPorEmbarque.DataSource = obrEmbarque.CargarTarifaEmbarque(oParametros)
            If dtgTarifaPorEmbarque.Rows.Count = 0 Then
                MessageBox.Show("NO EXISTE TARIFA PARA EL SERVICIO DE MANAGEMENT FEE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'HelpUtil.MsgBox("ERROR: NO EXISTE TARIFA PARA EL SERVICIO DE MANAGEMENT FEE")
            End If
            CargarDirServicioXDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CargarPlanta()
        cmbPlanta.Enabled = False
        Try
            Dim oPlanta As New Ransa.Controls.ServicioOperacion.clsPlantaNeg
            oPlanta.Crea_Lista(HelpUtil.UserName)
            cmbPlanta.DataSource = oPlanta.Lista_Planta(CCMPN, CDVSN)
            cmbPlanta.ValueMember = "CPLNDV"
            cmbPlanta.DisplayMember = "TPLNTA"
            cmbPlanta.SelectedValue = CodPlanta
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Aceptar(Nothing, Nothing)
        If CDIRSE = 0 Then
            MessageBox.Show("Seleccione Dir. Del Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            'INI-ECM-ValidacionSectorCliente[RF001]-160516
            Dim codigoTarifa As String = String.Empty
            If Not ValidarCodCeBeObligatorio(codigoTarifa) Then
                MessageBox.Show(String.Format("La Tarifa seleccionada: {0}  no cuenta con centro de beneficio.", codigoTarifa), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                Exit Sub
            End If
            'FIN-ECM-ValidacionSectorCliente[RF001]-160516

            If Me.dtgTarifaPorEmbarque.CurrentCellAddress.Y < 0 Then Exit Sub

            Dim msgValidaciontarifa As String = ValidarTarifa()
            If msgValidaciontarifa.Length > 0 Then
                MessageBox.Show(msgValidaciontarifa, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim msgTarifa As String = DatosTarifaSeleccionada()
            If MessageBox.Show("Está seguro de la tarifa seleccionada ? " & Chr(13) & msgTarifa, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            CCLNFC = UcClienteFacturacion.pCodigo
            CPLNDV = cmbPlanta.SelectedValue
            oDrTarifa = Me.dtgTarifaPorEmbarque.CurrentRow

            'Dim ClienteFacturacion As Decimal = 0
            'Dim NOPRCN As Decimal = 0
            'If dtgTarifaPorEmbarque.Rows.Count > 0 Then
            '    Dim obrEmbarque As New clsEmbarque
            '    Dim dt As New DataTable
            '    Dim tarifa As Decimal = dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value()
            '    dt = obrEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
            '    If dt.Rows.Count > 0 Then
            '        ClienteFacturacion = dt.Rows(0).Item("CCLNFC")
            'NOPRCN = dt.Rows(0).Item("NOPRCN")
            'If ClienteFacturacion <> UcClienteFacturacion.pCodigo Then
            '    If MessageBox.Show(String.Format("Desea confirmar el cambio del Cliente Facturación de: {0}  a  {1}", ClienteFacturacion, UcClienteFacturacion.pCodigo), String.Format("Operación Nro: {0}", NOPRCN), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '        CCLNFC = UcClienteFacturacion.pCodigo
            '        Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Else : Exit Sub
            '    End If
            'Else
            '    CCLNFC = UcClienteFacturacion.pCodigo
            'End If
            '    End If
            'Else
            'UcClienteFacturacion.Enabled = True
            'CCLNFC = UcClienteFacturacion.pCodigo
            'End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    '  Private Sub CargarTarifaEmbarque()
    '      Dim obrEmbarque As New clsEmbarque
    '      'Dim oParametros As New Db2Manager.RansaData.iSeries.DataObjects.Parameter
    '      Dim oParametros As New Hashtable
    '      oParametros.Add("PSCCMPN", CCMPN)
    '      oParametros.Add("PSCDVSN", CDVSN)
    '      oParametros.Add("PNCCLNT", CCLNT)
    '      oParametros.Add("PNNORSCI", NORSCI)
    '      oParametros.Add("PNFECSRV", FECSRV)
    '  Me.dtgTarifaPorEmbarque.DataSource = obrEmbarque.CargarTarifaEmbarque(oParametros)
    '      If dtgTarifaPorEmbarque.Rows.Count = 0 Then
    '          HelpUtil.MsgBox("ERROR: NO EXISTE TARIFA PARA EL SERVICIO DE MANAGEMENT FEE")
    '      End If

    'End Sub

#End Region


  'Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTarifaPorEmbarque.CellContentClick
  '  If Me.dtgTarifaPorEmbarque.CurrentCellAddress.Y < 0 Then Exit Sub
  '  oDrTarifa = Me.dtgTarifaPorEmbarque.CurrentRow

  '  If UcClienteFacturacion.pCodigo = 0 Then
  '    MessageBox.Show("Seleccione el cliente Facturación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    Exit Sub
  '  End If

  '  If dtgTarifaPorEmbarque.Rows.Count > 0 Then
  '    Dim obrEmbarque As New clsEmbarque
  '    Variable_ClienteFacturacion = New Double
  '    Dim dt As New DataTable
  '    Dim tarifa As Double = dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value()
  '    dt = obrEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
  '    If dt.Rows.Count > 0 Then
  '      Variable_ClienteFacturacion = dt.Rows(0).Item("CCLNFC")
  '      NOPRCN = dt.Rows(0).Item("NOPRCN")
  '    End If
  '  End If

  '  If Variable_ClienteFacturacion <> UcClienteFacturacion.pCodigo Then
  '    If MessageBox.Show(String.Format("Desea confirmar el cambio del Cliente Facturación de: {0}  a  {1}", Variable_ClienteFacturacion, UcClienteFacturacion.pCodigo), String.Format("Operación Nro: {0}", NOPRCN), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
  '      CCLNFC = UcClienteFacturacion.pCodigo
  '      Me.DialogResult = Windows.Forms.DialogResult.OK
  '    Else
  '      Exit Sub
  '    End If
  '  Else
  '    CCLNFC = UcClienteFacturacion.pCodigo
  '  End If
  '  Me.DialogResult = Windows.Forms.DialogResult.OK
    'End Sub

    'Private Function VerificarTarifa(ByVal Tipo As String, ByVal Unidad As String) As String
    '    Dim EsValida As Boolean = False
    '    Dim msgValidacion As String = ""
    '    If (Tipo = "F" AndAlso Unidad = "MES") OrElse (Tipo = "C" AndAlso Unidad = "OS") Then
    '        EsValida = True
    '    Else
    '        EsValida = False
    '    End If
    '    If EsValida = False Then
    '        msgValidacion = "* Las Tarifas no son válidas.Tarifas Válidas para Cierre"
    '        msgValidacion = msgValidacion & "Automático:(Tipo-F,Unidad-MES)(Tipo-C,Unidad-OS)"
    '    End If
    '    Return msgValidacion
    'End Function
    Private Function ValidarTarifa() As String
        Dim msgValidacion As String = ""
        Dim strTipo As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("STPTRA").Value).ToString.Trim
        Dim strUnidad As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("CUNDMD").Value).ToString.Trim
        Dim dblTarifa As Decimal = dtgTarifaPorEmbarque.CurrentRow.Cells("IVLSRV").Value
        If UcClienteFacturacion.pCodigo = 0 Then
            msgValidacion = msgValidacion & "Seleccione  cliente Facturación"
        End If
        '*********VALIDACION TARIFA**************************
        Dim EsValida As Boolean = False
        If (strTipo = "F" AndAlso strUnidad = "MES") OrElse (strTipo = "C" AndAlso strUnidad = "OS") Then
            EsValida = True
        Else
            EsValida = False
        End If
        If EsValida = False Then
            msgValidacion = msgValidacion & "* Las Tarifas no son válidas para el Cierre Automático."
            msgValidacion = msgValidacion & Chr(13) & "  Verifique Tarifa:(Tipo-F,Unidad-MES) o (Tipo-C,Unidad-OS)"
        End If
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
    'Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTarifaPorEmbarque.CellContentDoubleClick
    '    If Me.dtgTarifaPorEmbarque.CurrentCellAddress.Y < 0 Then Exit Sub

    '    Dim msgValidaciontarifa As String = ValidarTarifa()
    '    If msgValidaciontarifa.Length > 0 Then
    '        MessageBox.Show(msgValidaciontarifa, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If
    '    Dim msgTarifa As String = DatosTarifaSeleccionada()
    '    If MessageBox.Show("Está seguro de la tarifa seleccionada ? " & Chr(13) & msgTarifa, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    End If
    '    CCLNFC = UcClienteFacturacion.pCodigo
    '    CPLNDV = cmbPlanta.SelectedValue
    '    oDrTarifa = Me.dtgTarifaPorEmbarque.CurrentRow

    '    'Dim ClienteFacturacion As Decimal = 0
    '    'Dim NOPRCN As Decimal = 0
    '    'If dtgTarifaPorEmbarque.Rows.Count > 0 Then
    '    '    Dim obrEmbarque As New clsEmbarque
    '    '    Dim dt As New DataTable
    '    '    Dim tarifa As Decimal = dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value()
    '    '    dt = obrEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
    '    '    If dt.Rows.Count > 0 Then
    '    '        ClienteFacturacion = dt.Rows(0).Item("CCLNFC")
    '    'NOPRCN = dt.Rows(0).Item("NOPRCN")
    '    'If ClienteFacturacion <> UcClienteFacturacion.pCodigo Then
    '    '    If MessageBox.Show(String.Format("Desea confirmar el cambio del Cliente Facturación de: {0}  a  {1}", ClienteFacturacion, UcClienteFacturacion.pCodigo), String.Format("Operación Nro: {0}", NOPRCN), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '    '        CCLNFC = UcClienteFacturacion.pCodigo
    '    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    '    Else : Exit Sub
    '    '    End If
    '    'Else
    '    '    CCLNFC = UcClienteFacturacion.pCodigo
    '    'End If
    '    '    End If
    '    'Else
    '    'UcClienteFacturacion.Enabled = True
    '    'CCLNFC = UcClienteFacturacion.pCodigo
    '    'End If
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    'End Sub


    ' If (strTipo = "F" AndAlso strUnidad = "MES")

  Private Sub Cargar_ClienteFacturacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgTarifaPorEmbarque.SelectionChanged
        Try
            If dtgTarifaPorEmbarque.Rows.Count > 0 Then
                Dim obrEmbarque As New clsEmbarque
                UcClienteFacturacion.Enabled = True
                Dim strTipo As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("STPTRA").Value)
                Dim strUnidad As String = ("" & dtgTarifaPorEmbarque.CurrentRow.Cells("CUNDMD").Value)
                Dim CCLNFC As Decimal = 0
                If (strTipo = "F" AndAlso strUnidad = "MES") Then
                    Dim dt As New DataTable
                    Dim tarifa As Double = dtgTarifaPorEmbarque.CurrentRow.Cells("NRTFSV").Value()
                    dt = obrEmbarque.CargarClienteFacturacion(tarifa, CCMPN, CDVSN, CCLNT, FECSRV)
                    If dt.Rows.Count > 0 Then
                        CCLNFC = dt.Rows(0).Item("CCLNFC")
                        UcClienteFacturacion.Enabled = False
                        If dt.Rows(0).Item("CCLNFC") = 0 Then
                            UcClienteFacturacion.Enabled = True
                        End If
                    Else
                        CCLNFC = CCLNT
                        UcClienteFacturacion.Enabled = True
                    End If
                Else
                    CCLNFC = CCLNT
                End If

                UcClienteFacturacion.pCargar(CCLNFC)
            Else
                UcClienteFacturacion.Enabled = True
                UcClienteFacturacion.pCargar(CCLNT)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    'INI-ECM-ValidacionSectorCliente[RF001]-160516
    Private Sub UcClienteFacturacion_InformationChanged() Handles UcClienteFacturacion.InformationChanged
        Dim negocioEmbarque As New clsEmbarque

        For Each row As DataGridViewRow In dtgTarifaPorEmbarque.Rows
            Dim parametro As New Entidad.InCeBePorSector
            With parametro
                .CCMPN = CCMPN
                .CCNTCS = row.Cells("CCNTCS").Value
                .CDSCSP = UcClienteFacturacion.pSector
            End With

            Dim output As Entidad.OuCeBePorSector = negocioEmbarque.CambiarCeBePorSector(parametro)
            row.Cells("CCNTCS").Value = output.CCNTCS
            row.Cells("TCNTCS").Value = output.TCNTCS
            dtgTarifaPorEmbarque.Rows(row.Index).DefaultCellStyle.BackColor = output.ColorRegistro
        Next row
    End Sub

    Private Function ValidarCodCeBeObligatorio(ByRef codigoTarifa As String) As Boolean
        For Each row As DataGridViewRow In dtgTarifaPorEmbarque.Rows
            CodCentroBeneficio = row.Cells("CCNTCS").Value
            If row.Cells("CCNTCS").Value = 0 Then
                codigoTarifa = row.Cells("NRTFSV").Value
                Return False
            End If
        Next
        Return True
    End Function
    'FIN-ECM-ValidacionSectorCliente[RF001]-160516

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
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
       

    End Sub
End Class
