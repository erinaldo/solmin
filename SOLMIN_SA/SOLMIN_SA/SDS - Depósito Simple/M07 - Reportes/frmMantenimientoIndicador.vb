Imports Ransa.NEGO
Imports Ransa.DATA
Imports Ransa.TYPEDEF
Imports Ransa.DAO
Imports System.Data
Imports Ransa.Utilitario

Public Class frmMantenimientoIndicador

    Private cod_cliente As String
    Private cod_empresa As String
    Private cod_division As String
    Private cod_planta As String
    Private _mes As String = ""
    Private _anio As String = ""
    Private _NombreCliente As String
    Private _tipooperacion As Integer = 0 'cero neutral
    Private objDatatableReference As New DataTable


    Private Sub frmMantenimientoIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ClientePK As Ransa.TYPEDEF.Cliente.TD_ClientePK = New Ransa.TYPEDEF.Cliente.TD_ClientePK(0, objSeguridadBN.pUsuario)
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar() 
        txtCliente.pCargar(ClientePK)

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()


        'Listando los tipos de indicadores
        Dim dtbData As New DataTable
        Dim objIndicador As New brIndicador
        dtbData = objIndicador.ListarTipoIndicador()

        Me.ddlTipoIndicador.DataSource = dtbData.Copy
        Me.ddlTipoIndicador.DisplayMember = "ttpoin"
        Me.ddlTipoIndicador.ValueMember = "ttpoin"

        Me.ddlTipoIndicadorConsulta.DataSource = dtbData.Copy
        Me.ddlTipoIndicadorConsulta.DisplayMember = "ttpoin"
        Me.ddlTipoIndicadorConsulta.ValueMember = "ttpoin"

        ddlTipoIndicador.SelectedValue = "Incidencias"
        ddlTipoIndicador.Enabled = False
        ddlTipoIndicadorConsulta.SelectedValue = "Incidencias"
        ddlTipoIndicadorConsulta.Enabled = False
 
        'Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Me.cod_empresa
        ' Me.UcDivision_Cmb011.Division = Me.cod_division
        Me.lblCliente.Text = "Cliente : " & _NombreCliente
        MostrarMeses_x_Anio()
        cargar_planta_neutral()
    End Sub

    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Public Property Anio() As String
        Get
            Return _anio
        End Get
        Set(ByVal value As String)
            _anio = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return cod_cliente
        End Get
        Set(ByVal value As String)
            cod_cliente = value
            Me.txtCliente.pCargar(Convert.ToInt64(cod_cliente))
        End Set
    End Property

    Public Property Empresa() As String
        Get
            Return cod_empresa
        End Get
        Set(ByVal value As String)
            cod_empresa = value
        End Set
    End Property

    Public Property Division() As String
        Get
            Return cod_division
        End Get
        Set(ByVal value As String)
            cod_division = value
        End Set
    End Property

    Public Property Planta() As String
        Get
            Return cod_planta
        End Get
        Set(ByVal value As String)
            cod_planta = value
        End Set
    End Property

    Public Property NombreCliente() As String
        Get
            Return _NombreCliente
        End Get
        Set(ByVal value As String)
            _NombreCliente = value
        End Set
    End Property

    Private Sub ddlTipoIndicador_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlTipoIndicador.SelectedIndexChanged

        Try
            'mantenimientos
            Dim dtbData As New DataTable
            Dim objIndicador As New brIndicador
            dtbData = objIndicador.Listar_Indicador_x_Tipo(Me.ddlTipoIndicador.SelectedValue.ToString)

            Me.ddlIndicador.DataSource = dtbData
            Me.ddlIndicador.DisplayMember = "INDICADOR"
            Me.ddlIndicador.ValueMember = "CTPOIN"
        Catch : End Try

    End Sub

    Private Sub MostrarMeses_x_Anio()
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("idmes")
        odtMeses.Columns.Add("nombre")
        odtMeses.Rows.Clear()

        odtMeses.Rows.Add(New Object() {1, "Enero"})
        odtMeses.Rows.Add(New Object() {2, "Febrero"})
        odtMeses.Rows.Add(New Object() {3, "Marzo"})
        odtMeses.Rows.Add(New Object() {4, "Abril"})
        odtMeses.Rows.Add(New Object() {5, "Mayo"})
        odtMeses.Rows.Add(New Object() {6, "Junio"})
        odtMeses.Rows.Add(New Object() {7, "Julio"})
        odtMeses.Rows.Add(New Object() {8, "Agosto"})
        odtMeses.Rows.Add(New Object() {9, "Setiembre"})
        odtMeses.Rows.Add(New Object() {10, "Octubre"})
        odtMeses.Rows.Add(New Object() {11, "Noviembre"})
        odtMeses.Rows.Add(New Object() {12, "Diciembre"})
 
        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "idmes"
        dbMes.DisplayMember = "nombre"

        If _anio = "" Then
            Me.ndAnio.Value = Today.Year
            Me.dbMes.SelectedIndex = Today.Month - 1
        Else
            dbMes.SelectedIndex = _mes - 1
        End If

    End Sub


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As RANSA.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub
 
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me._tipooperacion = 0 Then
            Nuevo()
        Else
            Modificar()
        End If


     

    End Sub
    Public Sub Modificar()

        'validando si es que los datos estan llenos
        Dim validacion As String = ""
        Dim objIncidencias As New brIncidencias

        If Me.txtCliente.pRazonSocial = "" Then
            validacion += "Debe de seleccionar un cliente" & Chr(13)
        End If
        If Me.txtAlmacen.Text = "" Then
            validacion += "Debe de Ingresar el Almacen" & Chr(13)
        End If
        If Me.txtTipoAlmacen.Text = "" Then
            validacion += "Debe de Ingresar el Tipo de Almacen" & Chr(13)
        End If
        If Me.txtZonaAlmacen.Text = "" Then
            validacion += "Debe de Ingresar la Zona de Almacen" & Chr(13)
        End If
        If Me.txtHora.Text.Replace(":", "") = "" Then
            validacion += "Debe de Ingresar la hora" & Chr(13)
        End If
        If Me.txtResponsable.Text = "" Then
            validacion += "Debe de Ingresar el Responsable" & Chr(13)
        End If
        If Me.txtDescripcion.Text = "" Then
            validacion += "Debe de Ingresar la descripcion de la incidencia" & Chr(13)
        End If 
        If txtClienteTercero.pRazonSocial = "" Then
            validacion += "Debe de seleccionar un cliente tercero" & Chr(13)
        End If
        If validacion <> "" Then
            MsgBox(validacion)
            Exit Sub
        End If

        _anio = Me.ndAnio.Value
        _mes = Me.dbMes.SelectedValue


        Dim objparam As New List(Of String)
        objparam.Add(Me.UcCompania_Cmb011.CCMPN_CodigoCompania) 'PARAM_CCMPN 
        objparam.Add(Me.UcDivision_Cmb011.Division) 'PARAM_CDVSN 
        objparam.Add(txtCliente.pCodigo) 'PARAM_CCLNT 
        objparam.Add(_anio) 'PARAM_AÑOEMI
        objparam.Add(_mes) 'PARAM_MESEMI
        objparam.Add(Me.ddlDia.SelectedIndex + 1) 'PARAM_DDEMI 
        objparam.Add(Me.ddlIndicador.SelectedValue) 'PARAM_CTPOIN
        objparam.Add(Me.txtHora.Text.Replace(":", "")) 'PARAM_HRAEMI
        objparam.Add(Me.txtTipoAlmacen.Tag) 'PARAM_CTPALM
        objparam.Add(Me.txtAlmacen.Tag) 'PARAM_CALMC 
        objparam.Add(Me.txtZonaAlmacen.Tag) 'PARAM_CZNALM
        objparam.Add(Me.txtClienteTercero.pCodigo) 'PARAM_CPRVCL
        objparam.Add(Me.txtPlanta.SelectedValue) 'PARAM_CPLCLP
        objparam.Add(Me.txtResponsable.Text) 'PARAM_TIRALC
        objparam.Add(Me.txtResponsable.Text) 'PARAM_PRSCNT

        If Me.txtDescripcion.Text.Length < 250 Then 'PARAM_TOBAC 
            objparam.Add(Me.txtDescripcion.Text)
        Else
            objparam.Add(Me.txtDescripcion.Text.Substring(0, 250))
        End If

        If Me.txtDescripcion.Text.Length > 250 Then 'PARAM_TOBAC1
            objparam.Add(Me.txtDescripcion.Text.Substring(250))
        Else
            objparam.Add("")
        End If

        objparam.Add("A") 'PARAM_SESTRG
        objparam.Add(mMain.objSeguridadBN.pUsuario) 'PARAM_CUSCRT
        objparam.Add(HelpClass.TodayNumeric) 'PARAM_FCHCRT
        objparam.Add(HelpClass.NowNumeric) 'PARAM_HRACRT
        objparam.Add(mMain.objSeguridadBN.pstrPCName) 'PARAM_NTRMCR
        objparam.Add(mMain.objSeguridadBN.pUsuario) 'PARAM_CULUSA
        objparam.Add(HelpClass.TodayNumeric) 'PARAM_FULTAC
        objparam.Add(HelpClass.NowNumeric) 'PARAM_HULTAC
        objparam.Add(mMain.objSeguridadBN.pstrPCName) 'PARAM_NTRMNL
        objparam.Add(Me.txtCosto.Text)

        If (objIncidencias.Modificar_Incidencia(objparam)) = False Then
            MsgBox("Error al Modificar")
        Else
            MsgBox("Operacion Completa!")
            limpiar()
            habilitar(False) 
            Me.dtgDatos.Enabled = True
            Me.btnBuscar_Click(New Object(), New EventArgs())
        End If

    End Sub

    Private Sub Nuevo()



        'validando si es que los datos estan llenos
        Dim validacion As String = ""
        Dim objIncidencias As New brIncidencias

        If Me.txtCliente.pRazonSocial = "" Then
            validacion += "Debe de seleccionar un cliente" & Chr(13)
        End If
        If Me.txtAlmacen.Text = "" Then
            validacion += "Debe de Ingresar el Almacen" & Chr(13)
        End If
        If Me.txtTipoAlmacen.Text = "" Then
            validacion += "Debe de Ingresar el Tipo de Almacen" & Chr(13)
        End If
        If Me.txtZonaAlmacen.Text = "" Then
            validacion += "Debe de Ingresar la Zona de Almacen" & Chr(13)
        End If
        If Me.txtHora.Text.Replace(":", "") = "" Then
            validacion += "Debe de Ingresar la hora" & Chr(13)
        End If
        If Me.txtResponsable.Text = "" Then
            validacion += "Debe de Ingresar el Responsable" & Chr(13)
        End If
        If Me.txtDescripcion.Text = "" Then
            validacion += "Debe de Ingresar la descripcion de la incidencia" & Chr(13)
        End If 
        If txtClienteTercero.pRazonSocial = "" Then
            validacion += "Debe de seleccionar un cliente tercero" & Chr(13)
        End If 

        If validacion <> "" Then
            MsgBox(validacion)
            Exit Sub
        End If

        _anio = Me.ndAnio.Value
        _mes = Me.dbMes.SelectedValue


        Dim objparam As New List(Of String)
        objparam.Add(Me.UcCompania_Cmb011.CCMPN_CodigoCompania) 'PARAM_CCMPN 
        objparam.Add(Me.UcDivision_Cmb011.Division) 'PARAM_CDVSN 
        objparam.Add(txtCliente.pCodigo) 'PARAM_CCLNT 
        objparam.Add(_anio) 'PARAM_AÑOEMI
        objparam.Add(_mes) 'PARAM_MESEMI
        objparam.Add(Me.ddlDia.SelectedIndex + 1) 'PARAM_DDEMI 
        objparam.Add(Me.ddlIndicador.SelectedValue) 'PARAM_CTPOIN
        objparam.Add(HelpClass.NowNumeric) 'PARAM_HRAEMI
        objparam.Add(Me.txtTipoAlmacen.Tag) 'PARAM_CTPALM
        objparam.Add(Me.txtAlmacen.Tag) 'PARAM_CALMC 
        objparam.Add(Me.txtZonaAlmacen.Tag) 'PARAM_CZNALM
        objparam.Add(Me.txtClienteTercero.pCodigo) 'PARAM_CPRVCL
        objparam.Add(Me.txtPlanta.SelectedValue) 'PARAM_CPLCLP
        objparam.Add(Me.txtResponsable.Text) 'PARAM_TIRALC
        objparam.Add(Me.txtResponsable.Text) 'PARAM_PRSCNT

        If Me.txtDescripcion.Text.Length < 250 Then 'PARAM_TOBAC 
            objparam.Add(Me.txtDescripcion.Text)
        Else
            objparam.Add(Me.txtDescripcion.Text.Substring(0, 250))
        End If

        If Me.txtDescripcion.Text.Length > 250 Then 'PARAM_TOBAC1
            objparam.Add(Me.txtDescripcion.Text.Substring(250))
        Else
            objparam.Add("")
        End If

        objparam.Add("A") 'PARAM_SESTRG
        objparam.Add(mMain.objSeguridadBN.pUsuario) 'PARAM_CUSCRT
        objparam.Add(HelpClass.TodayNumeric) 'PARAM_FCHCRT
        objparam.Add(HelpClass.NowNumeric) 'PARAM_HRACRT
        objparam.Add(mMain.objSeguridadBN.pstrPCName) 'PARAM_NTRMCR
        objparam.Add(mMain.objSeguridadBN.pUsuario) 'PARAM_CULUSA
        objparam.Add(HelpClass.TodayNumeric) 'PARAM_FULTAC
        objparam.Add(HelpClass.NowNumeric) 'PARAM_HULTAC
        objparam.Add(mMain.objSeguridadBN.pstrPCName) 'PARAM_NTRMNL
        objparam.Add(Me.txtCosto.Text)

        If (objIncidencias.Registrar_Incidencia(objparam)) = False Then
            MsgBox("Error al registrar")
        Else
            MsgBox("Operacion Completa!")
            Actualiza_Tablas()
            limpiar()
            habilitar(False)
            Me.dtgDatos.Enabled = True
            Me.btnBuscar_Click(New Object(), New EventArgs())
        End If


    End Sub
 

    Private Sub Actualiza_Tablas()

        Try 
            Dim str As String = ""
            Dim oListIndicadores As New List(Of beIndicador)
            Dim obrIndicador As New brIndicador
            Dim obeIndicador As New beIndicador
            Dim strDia As String = ""
            Dim retorno As Int32 = 0
 

            obeIndicador.PNCCLNT = Me.txtCliente.pCodigo
            obeIndicador.PNANIOEMI = _anio
            obeIndicador.PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            obeIndicador.PSCDVSN = Me.UcDivision_Cmb011.Division
            obeIndicador.PNMESEMI = _mes
            obeIndicador.PNCTPOIN = Me.ddlIndicador.SelectedValue
            obeIndicador.PSCULUSA = objSeguridadBN.pUsuario
            obeIndicador.PSNTRMNL = objSeguridadBN.pstrPCName
            obeIndicador.PNDDEMI = Me.ddlDia.SelectedIndex + 1
            obeIndicador.PNQAINSM = 1
            oListIndicadores.Add(obeIndicador)


            If (oListIndicadores.Count > 0) Then
                retorno = obrIndicador.ActualizarResumenIndicadorMensual2(oListIndicadores, 30)
            Else
                retorno = 2
            End If
            If (retorno = 0) Then
                MessageBox.Show("La operación no se pudo realizar", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf retorno = 1 Then
                MessageBox.Show("La operación se realizó satisfactoriamente", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' myDialogOk = True
                '  Me.Close()
            ElseIf retorno = 2 Then
                MessageBox.Show("No existen datos que  actualizar", "Indicador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try

    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        _anio = Me.ndAnio.Value
        _mes = Me.dbMes.SelectedValue

        Me.dtgDatos.DataSource = Generar_Reporte_Incidencias(Me.txtCliente.pCodigo, Me._anio, _mes)
 
        'verifiacando si la columna es numerica, la escondemos
        For i As Integer = 0 To dtgDatos.Columns.Count - 1
            dtgDatos.Columns(i).Visible = True
            dtgDatos.Columns(i).Width = 250
            If i <= 26 Then
                dtgDatos.Columns(i).Visible = False
            End If
        Next
  
        If Me.ckbDetallado.Checked = True Then
            dtgDatos.Columns(0).Visible = False
        End If

        Me.dtgDatos.Columns(27).Width = 80
        Me.dtgDatos.Columns(28).Width = 300
        Me.dtgDatos.Columns(29).Width = 60
        Me.dtgDatos.Columns(30).Width = 80
        Me.dtgDatos.Columns(31).Width = 80
        Me.dtgDatos.Columns(32).Width = 80
        Me.dtgDatos.Columns(33).Width = 300
        Me.dtgDatos.Columns(34).Width = 150
        Me.dtgDatos.Columns(35).Width = 150


        habilitar(False)

    End Sub

    Private Function Generar_Reporte_Incidencias(ByVal cliente As String, ByVal anio As Integer, ByVal mes As Integer) As DataTable

        Dim dtbReporte As New DataTable

        Try

            Dim objIncidencias As New brIncidencias

            'creando las columnas al datatable
            dtbReporte.Columns.Add("dia1")
            dtbReporte.Columns.Add("dia")

            'creando las columnas dinamicamente
            'mantenimientos
            Dim dtbData As New DataTable
            Dim objIndicador As New brIndicador
            dtbData = objIndicador.Listar_Indicador_x_Tipo(Me.ddlTipoIndicadorConsulta.SelectedValue.ToString)

            For i As Integer = 0 To dtbData.Rows.Count - 1
                dtbReporte.Columns.Add(dtbData.Rows(i).Item(0).ToString().Trim())
                dtbReporte.Columns.Add(dtbData.Rows(i).Item(1).ToString().Trim().Replace(" ", "0"))
            Next

            dtbReporte.Columns.Add("observaciones")

            'armando una estructura temporal
            For i As Integer = 1 To 30

                Dim dr As DataRow = dtbReporte.NewRow
                dr(0) = (i & mes & anio)
                dr(1) = IIf(i < 10, "0" & i, i) & "/" & IIf(mes < 10, "0" & mes, mes) & "/" & anio

                For x As Integer = 2 To dtbReporte.Columns.Count - 2
                    dr(x) = "0"
                Next

                dr("observaciones") = " "

                dtbReporte.Rows.Add(dr)
            Next 

            'Obteniendo la colsulta inicial por rango de fechas
            Dim dtbTemporal As New DataTable
            Dim objParametros As New List(Of String)
            objParametros.Add(cliente)
            objParametros.Add(anio)
            objParametros.Add(mes)
            If Me.ckbDetallado.checked = True Then
                dtbTemporal = objIncidencias.Reporte_Incidencias(objParametros, 1)
            Else
                dtbReporte = objIncidencias.Reporte_Incidencias(objParametros, 2)
                Me.objDatatableReference = objIncidencias.Listado_Incidencias(objParametros)
                GoTo zonasalida
            End If

            For i As Integer = 0 To dtbTemporal.Rows.Count - 1

                Dim dia_temporal As String = (dtbTemporal.Rows(i).Item("DDEMI").ToString().Trim() & dtbTemporal.Rows(i).Item("MESEMI").ToString().Trim() & dtbTemporal.Rows(i).Item("AÑOEMI").ToString().Trim())

                'recorre el reporte para rellenar los campos
                For x As Integer = 0 To dtbReporte.Rows.Count - 1

                    If dtbReporte.Rows(x).Item("dia1") = dia_temporal Then

                

                        For j As Integer = 0 To dtbReporte.Columns.Count - 1

                            If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = dtbReporte.Columns(j).ColumnName Then
                                dtbReporte.Rows(x).Item(j) = CInt(dtbReporte.Rows(x).Item(j)) + 1
                                dtbReporte.Rows(x).Item(j + 1) = CInt(dtbReporte.Rows(x).Item(j + 1)) + 1
                            End If

                        Next

                        'lo que se tiene que hacer es ver si el tipo es igual al codigo que esta

                        dtbReporte.Rows(x).Item("observaciones") = (dtbTemporal.Rows(i).Item("TOBACT") & dtbTemporal.Rows(i).Item("TOBAC1")) & Chr(13)

                    End If

                Next

            Next

cicloborrado:
            For j As Integer = 0 To dtbReporte.Rows.Count - 1

                Dim parcial As Integer = 0

                For c As Integer = 1 To 9
                    Try
                        If IsNumeric(dtbReporte.Rows(j).Item(c).ToString.Trim) Then
                            parcial = CInt(dtbReporte.Rows(j).Item(c).ToString.Trim) + parcial
                        End If
                    Catch : End Try
                Next

                If parcial = 0 Then
                    dtbReporte.Rows.RemoveAt(j)
                    GoTo cicloborrado
                    Exit For
                End If

            Next


zonasalida:

        Catch ex As Exception

        End Try


        Return dtbReporte
    End Function


    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub ddlTipoIndicadorConsulta_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlTipoIndicadorConsulta.SelectedIndexChanged
        Try
            'consulta
            Dim dtbData As New DataTable
            Dim objIndicador As New brIndicador
            dtbData = objIndicador.Listar_Indicador_x_Tipo(Me.ddlTipoIndicadorConsulta.SelectedValue.ToString)

            'Me.ddlIndicadorConsulta.DataSource = dtbData
            'Me.ddlIndicadorConsulta.DisplayMember = "INDICADOR"
            'Me.ddlIndicadorConsulta.ValueMember = "CTPOIN"
        Catch : End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        habilitar(True)
        Me.btnModificar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.btnEliminar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.dtgDatos.Enabled = False
        limpiar()
    End Sub

    Private Sub Cargar_Dias_Mes()
        Try
            Me.ddlDia.Items.Clear()
            For i As Integer = 1 To LastDay(Me.ndAnio.Value, Me.dbMes.SelectedValue)
                Me.ddlDia.Items.Add(i)
            Next
            Me.ddlDia.SelectedIndex = Today.Day - 1
        Catch : End Try
    End Sub

    Public Function LastDay( _
    ByVal testYear As Integer, _
    ByVal testMonth As Integer _
    ) As Integer

        LastDay = System.DateTime.DaysInMonth(testYear, testMonth)

    End Function
    Private Sub limpiar()

        ddlIndicador.SelectedIndex = 0
        Me.ddlDia.SelectedIndex = Today.Day - 1
        Me.txtHora.Text = ""
        Me.txtResponsable.Text = ""
        cargar_planta_neutral()
        Me.txtClienteTercero.pClear()
        Me.txtAlmacen.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtTipoAlmacen.Text = ""
        Me.txtZonaAlmacen.Text = ""
        Me.txtCosto.Text = "0"
        Me._tipooperacion = 0 

    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Dim l As New List(Of DataGridView)
        l.Add(Me.dtgDatos)
        HelpClass.ExportarExcel_Add0(l)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        limpiar()
        habilitar(False)
        Me.btnModificar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Me.btnEliminar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Me.btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Me.btnNuevo.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Me.dtgDatos.Enabled = True
    End Sub
 

    Private Sub ndAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndAnio.ValueChanged
        Cargar_Dias_Mes()
    End Sub


    Private Sub dtgDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellClick

        Try
            If dtgDatos.CurrentRow IsNot Nothing Then
                If e.RowIndex > -1 Then
                    With Me.objDatatableReference.Rows(e.RowIndex)

                        Me.ddlDia.SelectedIndex = CInt(Me.dtgDatos.Rows(e.RowIndex).Cells(5).Value.ToString().Trim()) - 1 'PARAM_DDEMI 
                        Me.ddlIndicador.SelectedValue = Me.dtgDatos.Rows(e.RowIndex).Cells(6).Value.ToString().Trim()  'PARAM_CTPOIN

                        If Me.dtgDatos.Rows(e.RowIndex).Cells(11).Value.ToString().Trim() = "0" Or Me.dtgDatos.Rows(e.RowIndex).Cells(11).Value.ToString().Trim() = "1" Or Me.dtgDatos.Rows(e.RowIndex).Cells(11).Value.ToString().Trim() = "" Then
                            Me.txtClienteTercero.pClear()
                            Me.cargar_planta_neutral()
                        Else
                            Me.txtClienteTercero.pCodigo = Me.dtgDatos.Rows(e.RowIndex).Cells(11).Value.ToString().Trim()
                            cargar_planta(Me.dtgDatos.Rows(e.RowIndex).Cells(12).Value.ToString().Trim())
                        End If

                        Me.txtHora.Text = Me.dtgDatos.Rows(e.RowIndex).Cells(7).Value.ToString().Trim()
                        Me.txtDescripcion.Text = Me.dtgDatos.Rows(e.RowIndex).Cells(15).Value.ToString().Trim() & " " & Me.dtgDatos.Rows(e.RowIndex).Cells(16).Value.ToString().Trim()
                        Me.txtResponsable.Text = Me.dtgDatos.Rows(e.RowIndex).Cells(13).Value.ToString().Trim()
                        Me.txtCosto.Text = Me.dtgDatos.Rows(e.RowIndex).Cells(17).Value.ToString().Trim()

                        Dim obrAlmacen As New brAlmacen
                        Dim obeAlmacen As New beAlmacen
                        Dim obeAlmTemp As New beAlmacen

                        obeAlmacen.PSCTPALM = Me.dtgDatos.Rows(e.RowIndex).Cells(8).Value.ToString().Trim()
                        obeAlmacen.PSCALMC = Me.dtgDatos.Rows(e.RowIndex).Cells(9).Value.ToString().Trim()
                        obeAlmacen.PSCZNALM = Me.dtgDatos.Rows(e.RowIndex).Cells(10).Value.ToString().Trim()

                        obeAlmTemp = obrAlmacen.TipoDeAlmacen(obeAlmacen)
                        txtTipoAlmacen.Text = obeAlmTemp.PSTALMC
                        txtTipoAlmacen.Tag = obeAlmTemp.PSCTPALM

                        obeAlmTemp = obrAlmacen.Almacen(obeAlmacen)
                        txtAlmacen.Text = obeAlmTemp.PSTCMPAL
                        txtAlmacen.Tag = obeAlmTemp.PSCALMC

                        obeAlmTemp = obrAlmacen.ZonaDeAlmacen(obeAlmacen)
                        txtZonaAlmacen.Text = obeAlmTemp.PSTCMZNA
                        txtZonaAlmacen.Tag = obeAlmTemp.PSCZNALM
                        _tipooperacion = 1

                        Me.ddlIndicador.Enabled = False
                        Me.ddlDia.Enabled = False
                        Me.txtHora.Enabled = False
                        txtTipoAlmacen.Enabled = False
                        txtAlmacen.Enabled = False
                        txtZonaAlmacen.Enabled = False

                    End With
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        If _tipooperacion = 1 Then

            If HelpClass.RspMsgBox("Desea eliminar el registro?") = Windows.Forms.DialogResult.Yes Then

                Dim objIncidencias As New brIncidencias
                Dim objparam As New List(Of String)
                objparam.Add(Me.UcCompania_Cmb011.CCMPN_CodigoCompania) 'PARAM_CCMPN 
                objparam.Add(Me.UcDivision_Cmb011.Division) 'PARAM_CDVSN 
                objparam.Add(txtCliente.pCodigo) 'PARAM_CCLNT 
                objparam.Add(_anio) 'PARAM_AÑOEMI
                objparam.Add(_mes) 'PARAM_MESEMI
                objparam.Add(Me.ddlDia.SelectedIndex + 1) 'PARAM_DDEMI 
                objparam.Add(Me.ddlIndicador.SelectedValue) 'PARAM_CTPOIN
                objparam.Add(txtHora.Text.Replace(":", "")) 'PARAM_HRAEMI

                If objIncidencias.Eliminar_Incidencia(objparam) = False Then
                    MsgBox("Error en la Operacion")
                Else
                    MsgBox("Operacion completa!")
                    limpiar()
                    Me.btnBuscar_Click(sender, e)
                End If

            End If

        End If

    End Sub

    Private Sub dtgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick

    End Sub

    Private Sub txtClienteTercero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClienteTercero.Load

    End Sub

    Private Sub txtClienteTercero_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClienteTercero.Validating

        cargar_planta()

    End Sub

    Private Sub cargar_planta(Optional ByVal pcodigo As String = "0")
        Try
            Dim objClase As New Ransa.NEGO.blPlanta()
            Dim dtb As New DataTable
            Dim objParametros As New List(Of String)
            objParametros.Add(Me.txtClienteTercero.pCodigo)
            dtb = objClase.Listado_Plantas_x_Cliente_Tercero(objParametros)
            Dim dr As DataRow = dtb.NewRow
            dr(0) = "0"
            dr(1) = "--- Escoja Elemento ---"
            dtb.Rows.InsertAt(dr, 0)

            Me.txtPlanta.DataSource = dtb
            Me.txtPlanta.DisplayMember = "TCMPCP"
            Me.txtPlanta.ValueMember = "CPLCLP"
            Me.txtPlanta.SelectedValue = pcodigo
        Catch
            cargar_planta_neutral()


        End Try
    End Sub

    Private Sub cargar_planta_neutral()
        Dim dtb As New DataTable
        dtb.Columns.Add("CPLCLP")
        dtb.Columns.Add("TCMPCP")
        dtb.Rows.Add(New Object() {"0", "--- Escoja Elemento ---"})
        Me.txtPlanta.DataSource = dtb
        Me.txtPlanta.DisplayMember = "TCMPCP"
        Me.txtPlanta.ValueMember = "CPLCLP"
        Me.txtPlanta.SelectedIndex = 0

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        habilitar(True)
        Me.btnNuevo.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.btnEliminar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.dtgDatos.Enabled = False

    End Sub

    Private Sub habilitar(ByVal b As Boolean)
 
        Me.ddlIndicador.Enabled = b
        Me.ddlDia.Enabled = b
        Me.txtHora.Enabled = b
        txtTipoAlmacen.Enabled = b
        txtAlmacen.Enabled = b
        txtZonaAlmacen.Enabled = b 
        Me.txtResponsable.Enabled = b
        Me.txtPlanta.Enabled = b
        Me.txtClienteTercero.Enabled = b
        Me.txtDescripcion.Enabled = b
        Me.btnBuscar.Enabled = b
        Me.txtCosto.Enabled = b

    End Sub

    Private Sub dbMes_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbMes.SelectedIndexChanged
        Cargar_Dias_Mes()
    End Sub
End Class
