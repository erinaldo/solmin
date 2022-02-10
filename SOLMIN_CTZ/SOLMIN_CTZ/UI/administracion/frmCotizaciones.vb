Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmCotizaciones

    Private objOperacion_Cotizacion As New TipoOperacion
    Private objOperacion_Detalle_Cotizacion As New TipoOperacion

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.Limpiar_Cotizacion()
        Listar_Cotizaciones()
        Me.HGPanelCotizaciones.Collapsed = True
    End Sub

    Private Sub Listar_Cotizaciones(ByVal CodigoCliente As String, Optional ByVal NroCotizacionConsulta As String = "", Optional ByVal Estado As String = "")

        Dim objCotizacion As New CotizacionesBO
        Dim objParam As New List(Of DictionaryEntry)

        objParam.Add(New DictionaryEntry("PARAM_CCLNT", CodigoCliente))
        objParam.Add(New DictionaryEntry("PARAM_NCTZCN", NroCotizacionConsulta))
        objParam.Add(New DictionaryEntry("PARAM_FECHAINICIO", "0"))
        objParam.Add(New DictionaryEntry("PARAM_FECHAFIN", "0"))
        objParam.Add(New DictionaryEntry("PARAM_ESTADO", Estado))

        Me.dtgCotizacion.DataSource = objCotizacion.Listar_Cotizaciones(objParam)

        Formatear_Cabeceras_Grilla_Cotizacion()

    End Sub

    Private Sub Listar_Cotizaciones()
        Dim objCotizacion As New CotizacionesBO
        Dim objParam As New List(Of DictionaryEntry)
        objParam.Add(New DictionaryEntry("PARAM_CCLNT", Me.ctlClienteConsulta.Codigo))
        objParam.Add(New DictionaryEntry("PARAM_NCTZCN", Me.txtNroCotizacionConsulta.Text))
        objParam.Add(New DictionaryEntry("PARAM_FECHAINICIO", HelpClass.CtypeDate(Me.dtpDesde.Value)))
        objParam.Add(New DictionaryEntry("PARAM_FECHAFIN", HelpClass.CtypeDate(Me.dtpHasta.Value)))
        objParam.Add(New DictionaryEntry("PARAM_ESTADO", IIf(cboEstado.SelectedIndex = 0, "", cboEstado.Text.Substring(0, 1).ToUpper())))
        Me.dtgCotizacion.DataSource = objCotizacion.Listar_Cotizaciones(objParam)
        Formatear_Cabeceras_Grilla_Cotizacion()
    End Sub

    Private Sub Formatear_Cabeceras_Grilla_Cotizacion()

        Me.dtgCotizacion.Columns(0).HeaderText = "N° Cotización"
        Me.dtgCotizacion.Columns(1).HeaderText = "Nro Contrato"
        Me.dtgCotizacion.Columns(2).HeaderText = "Compañía"
        Me.dtgCotizacion.Columns(3).HeaderText = "División"
        Me.dtgCotizacion.Columns(4).HeaderText = "Cliente"
        Me.dtgCotizacion.Columns(5).HeaderText = "Fec. Registro"
        Me.dtgCotizacion.Columns(6).HeaderText = "Contacto"
        Me.dtgCotizacion.Columns(7).HeaderText = "Fecha Inicio"
        Me.dtgCotizacion.Columns(8).HeaderText = "Vencimiento"
        Me.dtgCotizacion.Columns(9).HeaderText = "Observaciones"
        Me.dtgCotizacion.Columns(10).HeaderText = "Estado"

    End Sub

    Private Sub frmCotizaciones_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        'Establienciendo el origen de datos para los diferentes combos

        'cliente
        Me.ctlCliente.DataSource = MainModule.objdst_TablasGlobales.Tables("CLIENTES").Copy()
        Me.ctlCliente.KeyField = "CCLNT"
        Me.ctlCliente.ValueField = "TCMPCL"
        Me.ctlCliente.DataBind()

        'consulta de cliente
        Me.ctlClienteConsulta.DataSource = MainModule.objdst_TablasGlobales.Tables("CLIENTES").Copy()
        Me.ctlClienteConsulta.KeyField = "CCLNT"
        Me.ctlClienteConsulta.ValueField = "TCMPCL"
        Me.ctlClienteConsulta.DataBind()

        'Compania 
        Me.ctlCompania.DataSource = MainModule.objdst_TablasGlobales.Tables("COMPANIA")
        Me.ctlCompania.KeyField = "CCMPN"
        Me.ctlCompania.ValueField = "TCMPCM"
        Me.ctlCompania.DataBind()

        'division 
        Me.ctlPlanta.DataSource = MainModule.objdst_TablasGlobales.Tables("PLANTA")
        Me.ctlPlanta.KeyField = "CPLNDV"
        Me.ctlPlanta.ValueField = "TPLNTA"
        Me.ctlPlanta.DataBind()

        'Cargando datos por defecto del usuario
        Cargar_Datos_Usuario()

        Me.HGPanelCotizaciones.Collapsed = True
        Me.cboFiltroNegocio.SelectedIndex = 0
        Me.cboEstado.SelectedIndex = 0
        Me.txtNroCotizacionConsulta.Text = ""
        Me.ctlClienteConsulta.Limpiar()
        Me.Estado_Controles_Cotizacion(False)
        Me.dtgCotizacion.DataSource = Nothing

    End Sub

    Private Sub Cargar_Datos_Usuario()

        Me.ctlCompania.Codigo = HelpClass.CacheMemory("COMPANIA")
        Me.ctlPlanta.Codigo = HelpClass.CacheMemory("PLANTA")

    End Sub

    Private Sub Limpiar_Cotizacion()

        Me.ctlCliente.Limpiar()
        Me.ctlCompania.Limpiar()
        Me.ctlPlanta.Limpiar()
        Me.txtContacto.Text = ""
        Me.txtNroContrato.Text = ""
        Me.txtObservaciones.Text = ""
        Me.dtpFechaInicio.Value = Today
        Me.dtpFechaFinalizacion.Value = Today

    End Sub

    Private Sub Estado_Controles_Cotizacion(ByVal b As Boolean)

        Me.ctlCliente.Enabled = b
        Me.ctlCompania.Enabled = b
        Me.ctlPlanta.Enabled = b
        Me.txtContacto.Enabled = b
        Me.txtNroContrato.Enabled = b
        Me.txtObservaciones.Enabled = b
        Me.dtpFechaInicio.Enabled = b
        Me.dtpFechaFinalizacion.Enabled = b

    End Sub

    Private Sub btnNuevaCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCotizacion.Click

        Limpiar_Cotizacion()
        Estado_Controles_Cotizacion(True)
        Cargar_Datos_Usuario()
        Me.objOperacion_Cotizacion = TipoOperacion.Nuevo

    End Sub

    Private Sub btnCancelarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCotizacion.Click

        Me.Limpiar_Cotizacion()
        Estado_Controles_Cotizacion(False)
        Me.objOperacion_Cotizacion = TipoOperacion.StandBy
        Me.HGPanelCotizaciones.Collapsed = True

    End Sub

    Private Sub btnGuardarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCotizacion.Click

        If Me.objOperacion_Cotizacion = TipoOperacion.StandBy Then
            Exit Sub
        End If

        Procesar_Cotizacion()

    End Sub

    Private Sub Procesar_Cotizacion()

        Dim objEntidad As Cotizacion
        Dim objCotizacion As New CotizacionesBO

        If Me.objOperacion_Cotizacion = TipoOperacion.Modificar And HelpClass.ExistCacheItem("COTIZACION") = True Then
            objEntidad = DirectCast(HelpClass.CacheMemory("COTIZACION"), Cotizacion)
        Else
            objEntidad = New Cotizacion
        End If

        objEntidad.NCTZCN = Me.txtNroCotizacion.Text
        objEntidad.NCNTRT = Me.txtNroContrato.Text
        objEntidad.CCMPN = Me.ctlCompania.Codigo
        objEntidad.CPLNDV = Me.ctlPlanta.Codigo
        objEntidad.CCLNT = Me.ctlCliente.Codigo
        objEntidad.FCHREG = HelpClass.CtypeDate(Today)
        objEntidad.TCNCLC = Me.txtContacto.Text
        objEntidad.FCTZCN = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
        objEntidad.FVGCTZ = HelpClass.CtypeDate(Me.dtpFechaFinalizacion.Value)
        objEntidad.TOBS = Me.txtObservaciones.Text
        objEntidad.SESTRG = "P"
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = HelpClass.CacheMemory("USUARIO")
        objEntidad.NTRMNL = HelpClass.CacheMemory("TERMINAL")
        objEntidad.CUSCRT = HelpClass.CacheMemory("USUARIO")
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = HelpClass.CacheMemory("TERMINAL")

        If Me.objOperacion_Cotizacion = TipoOperacion.Nuevo Then
            HelpClass.MsgBox(objCotizacion.Registrar_Cotizaciones(objEntidad))
        ElseIf Me.objOperacion_Cotizacion = TipoOperacion.Modificar Then
            HelpClass.MsgBox(objCotizacion.Modificar_Cotizacion(objEntidad))
        End If

        Me.Listar_Cotizaciones(Me.ctlCliente.Codigo, "", "P")

    End Sub

    Private Sub dtgCotizacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCotizacion.CellClick

        If Me.dtgCotizacion.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        If Me.dtgCotizacion.Item(0, Me.dtgCotizacion.CurrentCellAddress.Y).Value Is DBNull.Value Then
            Exit Sub
        End If
        If Me.dtgCotizacion.RowCount = 0 Then
            Exit Sub
        End If

        'Obteniendo el codigo de la cotizacion
        Dim objEntidad As New Cotizacion
        Dim objCotizacion As New CotizacionesBO

        objEntidad.NCTZCN = Me.dtgCotizacion.Item(0, Me.dtgCotizacion.CurrentCellAddress.Y).Value

        'Listando los datos 
        objEntidad = objCotizacion.Obtener_Datos_Cotizacion(objEntidad)

        'Estableciendo en memoria el objeto
        If HelpClass.ExistCacheItem("COTIZACION") = True Then
            HelpClass.ClearCacheMemory("COTIZACION")
        End If
        'Eliminando de la memoria el elemento de Detalle de Servicio por Cotizacion
        If HelpClass.ExistCacheItem("SERVICIO_COTIZACION") = True Then
            HelpClass.ClearCacheMemory("SERVICIO_COTIZACION")
        End If
        'Estableciendo en memoria el objeto de cotizacion seleccionado
        HelpClass.CacheMemory("COTIZACION", objEntidad)

        'mostrando en los controles
        Me.txtNroCotizacion.Text = objEntidad.NCTZCN
        Me.txtNroContrato.Text = objEntidad.NCNTRT
        Me.ctlCompania.Codigo = objEntidad.CCMPN
        Me.ctlPlanta.Codigo = objEntidad.CPLNDV
        Me.ctlCliente.Codigo = objEntidad.CCLNT
        Me.txtContacto.Text = objEntidad.TCNCLC
        Me.dtpFechaInicio.Value = HelpClass.CNumero_a_Fecha(objEntidad.FCTZCN)
        Me.dtpFechaFinalizacion.Value = HelpClass.CNumero_a_Fecha(objEntidad.FVGCTZ)
        Me.txtObservaciones.Text = objEntidad.TOBS

        'activando el modo de edicion
        Me.objOperacion_Cotizacion = TipoOperacion.Modificar
        Me.Estado_Controles_Cotizacion(True)

        'Listando las bitacoras de la cotizacion
        Me.Listar_Bitacoras()

    End Sub

    Private Sub btnEliminarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCotizacion.Click

        If Me.dtgCotizacion.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        If Me.dtgCotizacion.Item(0, Me.dtgCotizacion.CurrentCellAddress.Y).Value Is DBNull.Value Then
            Exit Sub
        End If
        If Me.dtgCotizacion.RowCount = 0 Then
            Exit Sub
        End If

        Dim objEntidad As Cotizacion
        Dim objCotizacion As New CotizacionesBO

        If Me.objOperacion_Cotizacion = TipoOperacion.Modificar And HelpClass.ExistCacheItem("COTIZACION") = True Then

            'Obteniendo el objeto de memoria
            objEntidad = DirectCast(HelpClass.CacheMemory("COTIZACION"), Cotizacion)

            If HelpClass.RspMsgBox("Desea Eliminar la cotización  N° " & objEntidad.nctzcn) = Windows.Forms.DialogResult.Yes Then
                HelpClass.MsgBox(objCotizacion.Eliminar_Cotizacion(objEntidad))
            End If

        Else
            HelpClass.MsgBox("No ha seleccionado ninguna cotización para procesar la eliminación")
            Exit Sub
        End If

        Me.Listar_Cotizaciones(Me.ctlCliente.Codigo, "", "P")
        Me.Limpiar_Cotizacion()

    End Sub
 
    Private Sub btnAceptarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarCotizacion.Click

        'Rutina para cambiar el estado
        Cambiar_estado_cotizacion("A")
        'Listando los registros actualizados
        Me.Listar_Cotizaciones(Me.ctlCliente.Codigo, "", "P")
        Me.Limpiar_Cotizacion()

    End Sub

    Private Sub Cambiar_estado_cotizacion(ByVal Estado As String)
        If Me.dtgCotizacion.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        If Me.dtgCotizacion.Item(0, Me.dtgCotizacion.CurrentCellAddress.Y).Value Is DBNull.Value Then
            Exit Sub
        End If
        If Me.dtgCotizacion.RowCount = 0 Then
            Exit Sub
        End If

        Dim objEntidad As Cotizacion
        Dim objCotizacion As New CotizacionesBO

        If Me.objOperacion_Cotizacion = TipoOperacion.Modificar And HelpClass.ExistCacheItem("COTIZACION") = True Then

            'Obteniendo el objeto de memoria
            objEntidad = DirectCast(HelpClass.CacheMemory("COTIZACION"), Cotizacion)

            If HelpClass.RspMsgBox("Desea Cambiar el estado de la Cotización  N° " & objEntidad.NCTZCN) = Windows.Forms.DialogResult.Yes Then
                HelpClass.MsgBox(objCotizacion.Cambiar_Estado_Cotizacion(objEntidad, Estado))
            End If

        Else
            HelpClass.MsgBox("No ha seleccionado ninguna cotización para procesar el cambio de estado")
            Exit Sub
        End If
    End Sub

    Private Sub frmCotizaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Eliminando las variables del formulario
        If HelpClass.ExistCacheItem("COTIZACION") = True Then
            HelpClass.ClearCacheMemory("COTIZACION")
        End If
        If HelpClass.ExistCacheItem("SERVICIO_COTIZACION") = True Then
            HelpClass.ClearCacheMemory("SERVICIO_COTIZACION")
        End If

    End Sub

    Private Sub dtgCotizacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCotizacion.CellDoubleClick

        If Me.dtgCotizacion.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        If Me.dtgCotizacion.Item(0, Me.dtgCotizacion.CurrentCellAddress.Y).Value Is DBNull.Value Then
            Exit Sub
        End If
        If Me.dtgCotizacion.RowCount = 0 Then
            Exit Sub
        End If

        HGPanelCotizaciones.Collapsed = False

    End Sub

    Private Sub btnRechazarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazarCotizacion.Click
        Cambiar_estado_cotizacion("R")
    End Sub
 
    Private Sub btnNuevoServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoServicio.Click

        HGDetalleServicio.Collapsed = False
      
    End Sub

    Private Sub Paneles_Detalle_Tarifario_Cotizacion(ByVal b As Boolean)
        Me.KryptonSplitContainer1.Panel2Collapsed = b
        If b = False Then 
            Me.lblTope.Location = New Point(Me.lblTope.Location.X + 500, Me.lblTope.Location.Y)
        Else
            Me.lblTope.Location = New Point(Me.lblTope.Location.X - 500, Me.lblTope.Location.Y)
        End If
    End Sub

    Private Sub btnRegistrarComentarioServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarComentarioServicio.Click

        Dim objEntidad As New Bitacora
        Dim objBitacora As New BitacoraBO

        'Preguntando si es que en memoria esta un detalle de servicios de cotizacion
        If HelpClass.ExistCacheItem("COTIZACION") = True Then
            objEntidad.NCTZCN = DirectCast(HelpClass.CacheMemory("COTIZACION"), Cotizacion).NCTZCN 
        ElseIf HelpClass.ExistCacheItem("SERVICIO_COTIZACION") = True Then
            objEntidad.NCTZCN = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NCTZCN
            objEntidad.NNECTZ = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NNECTZ
            objEntidad.NSENEC = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NSENEC
        Else
            Exit Sub
        End If

        objEntidad.FCHREG = HelpClass.TodayNumeric
        objEntidad.FCRECO = IIf(Me.dtpRecordatorio.Checked = True, HelpClass.CtypeDate(Me.dtpRecordatorio.Value), "0")
        objEntidad.PRIOR = "0"
        objEntidad.SESTRG = "A"
        objEntidad.TMENSAJE = Me.txtRecordatorio.Text

        HelpClass.MsgBox(objBitacora.Registar_Bitacora(objEntidad))

        Listar_Bitacoras()

    End Sub

    Public Sub Listar_Bitacoras()

        Dim objEntidad As New Bitacora
        Dim objBitacora As New BitacoraBO

        'Preguntando si es que en memoria esta un detalle de servicios de cotizacion
        If HelpClass.ExistCacheItem("COTIZACION") = True Then
            objEntidad.NCTZCN = DirectCast(HelpClass.CacheMemory("COTIZACION"), Cotizacion).NCTZCN
        ElseIf HelpClass.ExistCacheItem("SERVICIO_COTIZACION") = True Then
            objEntidad.NCTZCN = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NCTZCN
            objEntidad.NNECTZ = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NNECTZ
            objEntidad.NSENEC = DirectCast(HelpClass.CacheMemory("SERVICIO_COTIZACION"), ServicioCotizacion).NSENEC
        Else
            Exit Sub
        End If

        Me.dtgBitacora.DataSource = objBitacora.Listar_Bitacoras(objEntidad)

    End Sub

    Private Sub btnEliminarComentarioServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarComentarioServicio.Click

        If Me.dtgBitacora.CurrentCellAddress.Y = -1 Then
            Exit Sub
        End If
        If Me.dtgBitacora.Item(0, Me.dtgBitacora.CurrentCellAddress.Y).Value Is DBNull.Value Then
            Exit Sub
        End If
        If Me.dtgBitacora.RowCount = 0 Then
            Exit Sub
        End If

        Dim objEntidad As New Bitacora
        Dim objBitacora As New BitacoraBO

        objEntidad.CODMEN = Me.dtgBitacora.Item(0, Me.dtgBitacora.CurrentCellAddress.Y).Value

        HelpClass.MsgBox(objBitacora.Eliminar_Bitacora(objEntidad))

        Listar_Bitacoras()

    End Sub

    Private Sub btnCancelarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarServicio.Click

        HGDetalleServicio.Collapsed = True

    End Sub

End Class