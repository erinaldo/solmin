Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF
Public Class frmGenerarERI

#Region "Propiedades"

    Private _PSCCMPN As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PSDESCCLNT As String

    ''' <summary>
    ''' Propiedad Campaña
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Planta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Cod. Cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Razon Social
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSDESCCLNT() As String
        Get
            Return _PSDESCCLNT
        End Get
        Set(ByVal value As String)
            _PSDESCCLNT = value
        End Set
    End Property

#End Region

#Region "Variables"
    Private dtInventarioxFecha As New DataTable
#End Region

#Region "Metodos y Funciones"
    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub CargarCompania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(PSCCMPN) '"EZ"
    End Sub

    'Private Sub CargarPlanta()
    '    If Not UcCompania_Cmb011.CCMPN_CodigoCompania <> Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
    '        Return
    '    End If
    '    UcPLanta_Cmb011.CodigoDivision = "R"
    '    UcPLanta_Cmb011.CodigoCompania = PSCCMPN
    '    UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
    '    UcPLanta_Cmb011.pActualizar()

    'End Sub

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por los siguientes errores: {0}", Environment.NewLine)
        If dteFechaInvInicial.Value = Nothing Then
            'MessageBox.Show("Debe seleccionar la Fecha.")
            strMensajeError += String.Format("- Debe seleccionar la Fecha. {0}", Environment.NewLine)
            booOk = False
        End If
        If Not booOk Then
            MessageBox.Show(strMensajeError, "Generar ERI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function

    Private Function GetEntCabEri() As beCabERI
        Dim objbeCabEri As New beCabERI
        objbeCabEri.PSCCMPN = PSCCMPN
        objbeCabEri.PSCRGVTA = txtCliente.pNegocio
        objbeCabEri.PNCPLNDV = PNCPLNDV
        objbeCabEri.PNCCLNT = PNCCLNT
        objbeCabEri.PNFECINV = Convert.ToDecimal(HelpClass.CDate_a_Numero8Digitos(dteFechaInvInicial.Value))
        objbeCabEri.PSCUSERI = objSeguridadBN.pUsuario
        objbeCabEri.PNTRMCR = objSeguridadBN.pstrPCName
        Return objbeCabEri
    End Function

    Private Function ObtenerObjetobeInventarioxFecha() As beInventarioxFecha
        Dim objbeInventarioxFecha As New beInventarioxFecha
        objbeInventarioxFecha.PSCCMPN = PSCCMPN
        objbeInventarioxFecha.PSCCVSN = "R"
        objbeInventarioxFecha.PNCPLNDV = PNCPLNDV
        objbeInventarioxFecha.PNCCLNT = txtCliente.pCodigo
        objbeInventarioxFecha.PSCTPDP6 = "1"
        objbeInventarioxFecha.PNFECINV = Convert.ToDecimal(HelpClass.CDate_a_Numero8Digitos(dteFechaInvInicial.Value))
        Return objbeInventarioxFecha
    End Function

    Private Sub CargarPlanta()
        Dim obrGeneral As New brGeneral
        cmbPlanta.DataSource = obrGeneral.ListaDePlanta()
        cmbPlanta.DisplayMember = "PSTPLNTA"
        cmbPlanta.ValueMember = "PNCPLNDV"
    End Sub
#End Region

#Region "Eventos de Formulario"
    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click
        If Not AsValidarFiltro() Then
            Return
        End If
        ListaInventarioXFecha()
    End Sub

    Private Sub ListaInventarioXFecha()
        Try
            Dim oblInventarioMercaderia As New blRegistroInventario()
            Dim dtReporte As New DataTable
            dtInventarioxFecha = oblInventarioMercaderia.ListaInventarioXFecha(ObtenerObjetobeInventarioxFecha()).Tables(0)
            dtReporte = dtInventarioxFecha.Copy()
            dgDetInventario.AutoGenerateColumns = False
            dgDetInventario.DataSource = dtReporte
            If dgDetInventario.RowCount > 0 Then
                tsbGenerar.Enabled = True
                Dim intConta As Integer = 0
                For i1 As Integer = 0 To dgDetInventario.RowCount - 1
                    intConta = intConta + 1
                    dgDetInventario.Rows(i1).Cells("nroCorrelativo").Value = intConta.ToString()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmGenerarERI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarCompania()
        CargarPlanta()
        'CargarPlanta1()
        txtCliente.pCargar(PNCCLNT)
        dteFechaInvInicial.Value = Now
        dteFechaInvInicial.Format = DateTimePickerFormat.Custom
        dteFechaInvInicial.CustomFormat = "dd/MM/yyyy"
        'UcPLanta_Cmb011.HabilitarPlantaActual(PNCPLNDV.ToString())
        cmbPlanta.SelectedValue = PNCPLNDV
    End Sub



    Private Sub tsbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerar.Click
        If MessageBox.Show("¿Desea generar el inventario?", "Generar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim objbeDetEri As beDetERI
            Dim lstBeDetEri As New List(Of beDetERI)
            For Each row As DataRow In dtInventarioxFecha.Rows
                objbeDetEri = New beDetERI
                objbeDetEri.PSCCMPN = PSCCMPN
                objbeDetEri.PSCRGVTA = txtCliente.pNegocio
                objbeDetEri.PNCPLNDV = PNCPLNDV
                objbeDetEri.PNCCLNT = PNCCLNT
                objbeDetEri.PNNORDSR = row("NORDSR") 'NORDSR
                objbeDetEri.PSCMRCLR = row("CMRCLR") 'CMRCLR
                objbeDetEri.PNQSLMC = row("QSLMC") 'QSLMC
                objbeDetEri.PNQSLMP = row("QSLMP") 'QSLMP
                objbeDetEri.PSCUNCN5 = row("CUNCN5") 'CUNCN5
                objbeDetEri.PSCUNPS5 = row("CUNPS5") 'CUNPS5
                objbeDetEri.PSCUSERI = objSeguridadBN.pUsuario
                objbeDetEri.PNTRMCR = objSeguridadBN.pstrPCName
                lstBeDetEri.Add(objbeDetEri)
            Next
            Dim strNroEri As String
            Dim oblInventarioMercaderia As New blRegistroInventario()
            strNroEri = oblInventarioMercaderia.GenerarCabeceraERI(GetEntCabEri(), lstBeDetEri)
            If strNroEri.Trim() = String.Empty Then
                MessageBox.Show(" Error al generar el ERI. ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                MessageBox.Show("Se creó el Nro. Doc. ERI:  " + strNroEri, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

#End Region

End Class