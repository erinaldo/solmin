Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Servicios
Imports RANSA.DAO.Servicios
Imports System.Drawing

Public Class ucServicios_DgF02
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal strMensaje As String)
    Public Event Message(ByVal strMensaje As String)
    Public Event Confirm(ByVal strPregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Servicio As TD_Inf_Servicio_Adquiridos_F01)
    Public Event RegistrationCompleted(ByVal Servicio As TD_Inf_Servicio_Adquiridos_F01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Servicio As TD_Inf_Servicio_Adquiridos_F01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private dtResultado As DataTable
    Private TD_ServDispPK As TD_Qry_Servicios_Adquiridos_L02 = New Ransa.TypeDef.Servicios.TD_Qry_Servicios_Adquiridos_L02
    Private TD_ServAdquActual As TD_Inf_Servicio_Adquiridos_F01 = New Ransa.TypeDef.Servicios.TD_Inf_Servicio_Adquiridos_F01
    Private strMensajeError As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnCargando As Boolean = False
    Private blnConfirm As Boolean = True
    Private intFilaActual As Int32 = 0
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property AskForConfirmation() As Boolean
        Get
            Return blnConfirm
        End Get
        Set(ByVal value As Boolean)
            blnConfirm = value
        End Set
    End Property

    Public Property BackGround() As Color
        Get
            Return dgServicio.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgServicio.StateCommon.Background.Color1 = value
        End Set
    End Property

    Public ReadOnly Property pListaServiciosREG() As List(Of TD_Inf_Servicio_Adquiridos_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Adquiridos_F01) = New List(Of TD_Inf_Servicio_Adquiridos_F01)
            Dim oTemp As TD_Inf_Servicio_Adquiridos_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgServicio.RowCount - 1
                If ("" & dgServicio.Rows(intIndice).Tag) = "R" Then
                    oTemp = New TD_Inf_Servicio_Adquiridos_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
                        .pNRTFSV_Tarifa = dgServicio.Rows(intIndice).Cells("M_NRTFSV").Value
                        .pNOMSER_Descripcion_Servicio = dgServicio.Rows(intIndice).Cells("M_NOMSER").Value
                        .pQCNESP_CantBase = dgServicio.Rows(intIndice).Cells("M_QCNESP").Value
                        .pTUNDIT_Unidad = dgServicio.Rows(intIndice).Cells("M_TUNDIT").Value
                        .pQATNAN_CantAtendida = dgServicio.Rows(intIndice).Cells("M_QATNAN").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pListaServiciosDEL() As List(Of TD_Inf_Servicio_Adquiridos_F01)
        Get
            Dim lstTemp As List(Of TD_Inf_Servicio_Adquiridos_F01) = New List(Of TD_Inf_Servicio_Adquiridos_F01)
            Dim oTemp As TD_Inf_Servicio_Adquiridos_F01 = Nothing
            Dim intIndice As Int32 = 0
            For intIndice = 0 To dgServicio.RowCount - 1
                If ("" & dgServicio.Rows(intIndice).Tag) = "E" Then
                    oTemp = New TD_Inf_Servicio_Adquiridos_F01
                    With oTemp
                        .pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
                        .pNRTFSV_Tarifa = dgServicio.Rows(intIndice).Cells("M_NRTFSV").Value
                    End With
                    lstTemp.Add(oTemp)
                End If
            Next
            Return lstTemp
        End Get
    End Property

    Public ReadOnly Property pRowsCount() As Int32
        Get
            Return dgServicio.RowCount
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnBuscar(ByVal strCodigo As String, Optional ByVal decQtaAtendida As Decimal = 0) As Boolean
        Dim intIndice As Integer
        For intIndice = 0 To Me.dgServicio.RowCount - 1
            If strCodigo.Trim = dgServicio.Rows(intIndice).Cells("M_NRTFSV").Value.ToString.Trim Then
                If decQtaAtendida <> 0 Then
                    dgServicio.Rows(intIndice).Cells("M_QATNAN").Value = decQtaAtendida
                    dgServicio.Rows(intIndice).Tag = "R"
                    dgServicio.Rows(intIndice).DefaultCellStyle.BackColor = Nothing
                End If
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Function fblnBuscarServicioDisponible(ByVal strDetalle As String, ByRef oTemp As TD_Inf_Servicio_Disponible_F01) As Boolean
        Dim intIndice As Integer = 0
        Dim blnResultado As Boolean = False
        While intIndice < dtResultado.Rows.Count
            If strDetalle.Trim = ("" & dtResultado.Rows(intIndice).Item("DETALLE")).ToString.Trim Then
                With oTemp
                    Int64.TryParse("" & dtResultado.Rows(intIndice).Item("CODIGO"), .pNRTFSV_Tarifa_Servicio)
                    .pNOMSER_Descripcion_Servicio = ("" & dtResultado.Rows(intIndice).Item("DETALLE")).ToString.Trim
                    .pQCNESP_Cantidad_Base = dtResultado.Rows(intIndice).Item("QTBASE")
                    .pTUNDIT_Unidad = ("" & dtResultado.Rows(intIndice).Item("UNIDAD")).ToString.Trim
                End With
                blnResultado = True
                Exit While
            End If
            intIndice += 1
        End While
        Return blnResultado
    End Function

    Private Sub pCargarInformacion()
        strMensajeError = ""
        blnCargando = True
        ' Cargamos la información
        Dim oTemp As TD_ServicioPK = New TD_ServicioPK
        oTemp.pCCMPN_Compania = TD_ServDispPK.pCCMPN_Compania
        oTemp.pCDVSN_Division = TD_ServDispPK.pCDVSN_Division
        oTemp.pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
        oTemp.pNOPRCN_Operacion = TD_ServDispPK.pNOPRCN_Operacion
        dgServicio.DataSource = cServicios.fdtListar_Servicios_L02(objSqlManager, oTemp, strMensajeError)
        oTemp = Nothing
        ' Finalizamos el bloqueo de la carga de información
        blnCargando = False
        If strMensajeError <> "" Then
            TD_ServDispPK.pClear()
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            If dgServicio.RowCount > 0 Then
                ' Cargamos el servicio actual
                With TD_ServAdquActual
                    .pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
                    .pNOMSER_Descripcion_Servicio = "" & dgServicio.CurrentRow.Cells("M_NOMSER").Value
                    .pQCNESP_CantBase = dgServicio.CurrentRow.Cells("M_QCNESP").Value
                    .pNRTFSV_Tarifa = dgServicio.CurrentRow.Cells("M_NRTFSV").Value
                    .pQATNAN_CantAtendida = dgServicio.CurrentRow.Cells("M_QATNAN").Value.ToString.Trim
                    .pTUNDIT_Unidad = dgServicio.CurrentRow.Cells("M_TUNDIT").Value.ToString.Trim
                End With
                intFilaActual = 0
            Else
                TD_ServAdquActual.pClear()
                intFilaActual = -1
            End If
            RaiseEvent DataLoadCompleted(TD_ServAdquActual)
        End If
    End Sub

    Private Sub pCargarComboServiciosDisponibles()
        If TD_ServDispPK.pFOPRCN_FechaOperacion_FNum = 0 Then Exit Sub
        strMensajeError = ""
        cmbServiciosDisponibles.Items.Clear()
        ' Cargamos la información
        Dim oTemp As TD_Qry_Servicio_Disponible_L01 = New TD_Qry_Servicio_Disponible_L01
        oTemp.pCCMPN_Compania = TD_ServDispPK.pCCMPN_Compania
        oTemp.pCDVSN_Division = TD_ServDispPK.pCDVSN_Division
        oTemp.pCPLNDV_Planta = TD_ServDispPK.pCPLNDV_Planta
        oTemp.pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
        oTemp.pFOPRCN_FechaOperacion = TD_ServDispPK.pFOPRCN_FechaOperacion
        dtResultado = cServicios.fdtListar_ServiciosDisponibles_L01(objSqlManager, oTemp, strMensajeError)
        oTemp = Nothing
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
        Else
            ' Llenamos el combox
            If dtResultado.Rows.Count > 0 Then
                Dim intFila As Int32 = 0
                For intFila = 0 To dtResultado.Rows.Count - 1
                    cmbServiciosDisponibles.Items.Add(dtResultado.Rows(intFila).Item("DETALLE").ToString.Trim)
                Next
            End If
        End If
    End Sub

    Private Sub pRegistrarServicios()
        If blnConfirm Then
            Dim blnCancelar As Boolean = False
            RaiseEvent Confirm("¿ Desea registrar el Servicio Disponible ?", blnCancelar)
            If blnCancelar Then Exit Sub
        End If
        Dim oTemp As TD_Inf_Servicio_Disponible_F01 = New TD_Inf_Servicio_Disponible_F01
        Dim intNroOperacion As Int64 = 0
        ' Validamos que sea un servicio disponible
        If fblnBuscarServicioDisponible(cmbServiciosDisponibles.Text, oTemp) Then
            blnCargando = True
            If Not fblnBuscar(oTemp.pNRTFSV_Tarifa_Servicio, txtQtaAtendida.Text) Then
                Dim dtServAdqu As DataTable = CType(dgServicio.DataSource, DataTable)
                Dim rwTemp As DataRow = dtServAdqu.NewRow
                With rwTemp
                    .Item("NRTFSV") = oTemp.pNRTFSV_Tarifa_Servicio
                    .Item("NOMSER") = oTemp.pNOMSER_Descripcion_Servicio
                    .Item("QCNESP") = oTemp.pQCNESP_Cantidad_Base
                    .Item("TUNDIT") = oTemp.pTUNDIT_Unidad
                    .Item("QATNAN") = txtQtaAtendida.Text
                End With
                dtServAdqu.Rows.Add(rwTemp)
                ' Llamo a la Funcion de Busqueda para que marque el registro
                fblnBuscar(oTemp.pNRTFSV_Tarifa_Servicio, txtQtaAtendida.Text)
            End If
            blnCargando = False
            ' Cargamos el Item y lanzo el evento respectivo
            If dgServicio.RowCount > 0 Then
                With TD_ServAdquActual
                    .pCCLNT_CodigoCliente = TD_ServDispPK.pCCLNT_CodigoCliente
                    .pNOMSER_Descripcion_Servicio = dgServicio.CurrentRow.Cells("M_NOMSER").Value
                    .pQCNESP_CantBase = dgServicio.CurrentRow.Cells("M_QCNESP").Value
                    .pNRTFSV_Tarifa = dgServicio.CurrentRow.Cells("M_NRTFSV").Value
                    .pQATNAN_CantAtendida = dgServicio.CurrentRow.Cells("M_QATNAN").Value.ToString.Trim
                    .pTUNDIT_Unidad = dgServicio.CurrentRow.Cells("M_TUNDIT").Value.ToString.Trim
                End With
                intFilaActual = 0
                RaiseEvent RegistrationCompleted(TD_ServAdquActual)
            Else
                TD_ServAdquActual.pClear()
                intFilaActual = -1
                RaiseEvent TableWithOutData()
            End If
            txtQtaAtendida.SelectAll()
        Else
            RaiseEvent ErrorMessage("Servicio No Disponible.")
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TD_ServDispPK.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If cmbServiciosDisponibles.Text <> "" And txtQtaAtendida.Text <> "" Then Call pRegistrarServicios()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgServicio.RowCount > 0 Then
            If ("" & dgServicio.CurrentRow.Tag) = "E" Then
                dgServicio.CurrentRow.Tag = "R"
                dgServicio.CurrentRow.DefaultCellStyle.BackColor = Nothing
            Else
                dgServicio.CurrentRow.Tag = "E"
                dgServicio.CurrentRow.DefaultCellStyle.BackColor = Color.LightCyan
            End If
        End If
    End Sub

    Private Sub txtQtaAtendida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtaAtendida.KeyDown
        If TD_ServDispPK.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cmbServiciosDisponibles.Text <> "" And txtQtaAtendida.Text <> "" Then Call pRegistrarServicios()
        End If
    End Sub

    Private Sub ucServicios_DgF02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objSqlManager = New SqlManager()
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_Servicios_Adquiridos_L02)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With TD_ServDispPK
            .pCCMPN_Compania = Filtro.pCCMPN_Compania
            .pCDVSN_Division = Filtro.pCDVSN_Division
            .pCPLNDV_Planta = Filtro.pCPLNDV_Planta
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNOPRCN_Operacion = Filtro.pNOPRCN_Operacion
            .pFOPRCN_FechaOperacion = Filtro.pFOPRCN_FechaOperacion
            .pUsuario = Filtro.pUsuario
        End With
        ' Llamada al procedimiento de carga de información relacionada a los servicios disponibles
        Call pCargarComboServiciosDisponibles()
        ' Llamada al procedimiento de carga de información relacionada a los servicios registrados
        Call pCargarInformacion()
    End Sub
#End Region
End Class