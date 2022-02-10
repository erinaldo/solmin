Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports SOLMIN_CTZ.Entidades   'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

Public Class clsClaseGeneral
    Private oClaseGeneral As New SOLMIN_CTZ.DATOS.clsGeneral
    Public Function Listar_Mercaderia() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Mercaderia()
    End Function

    Public Function Listar_Unidad_Transporte() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Unidad_Transporte()
    End Function

    Public Function Listar_Parametros_Facturacion() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Parametros_Facturacion()
    End Function

    Public Function Listar_Compania_Seguro() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Compania_Seguro()
    End Function

    Public Function Listar_Tipo_Servicio_Transp() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_Servicio_Transp()
    End Function

    Public Function Listar_Tipo_SubServicio(ByVal objEntidad As ClaseGeneral) As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_SubServicio(objEntidad)
    End Function

    Public Function Listar_UnidadMedida_Combo() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_UnidadMedida_Combo()
    End Function

    Public Function Listar_Localidad_Origen() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Localidad_Origen()
    End Function

    Public Function Listar_Moneda() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Moneda()
    End Function

    Public Function Listar_Ubigeo() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Ubigeo()
    End Function

    Public Function Lista_SectorXGastos() As List(Of ClaseGeneral)
        Dim oDt As New DataTable
        Dim oDr As DataRow

        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")
        oDr = oDt.NewRow()
        oDr.Item(0) = "C"
        oDr.Item(1) = "Consumo"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "M"
        oDr.Item(1) = "Minero"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "P"
        oDr.Item(1) = "Paita"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "I"
        oDr.Item(1) = "Internacional"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "A"
        oDr.Item(1) = "Mesa de Carga"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "B"
        oDr.Item(1) = "Traslados OLR"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow()
        oDr.Item(0) = "T"
        oDr.Item(1) = "Traslados General"
        oDt.Rows.Add(oDr)

        Dim objEntidad As ClaseGeneral
        Dim olSectorGasto As New List(Of ClaseGeneral)
        For Each objDataRow As DataRow In oDt.Rows
            objEntidad = New ClaseGeneral
            objEntidad.CODIGO = objDataRow("COD")
            objEntidad.VALOR = objDataRow("DES").ToString.Trim()
            olSectorGasto.Add(objEntidad)
        Next
        Return olSectorGasto

    End Function

    Public Function Listar_Logica_Facturacion(ByVal strNegocio As String) As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Logica_Facturacion(strNegocio)
    End Function


    Public Function intInsertarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As Integer
        Return oClaseGeneral.intInsertarUsuarioReversionProvision(obeGeneral)
    End Function

    Public Function intActualizarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As Integer
        Return oClaseGeneral.intActualizarUsuarioReversionProvision(obeGeneral)
    End Function

    Public Function dtListarUsuarioReversionProvision(ByVal obeGeneral As ClaseGeneral) As DataTable
        Return oClaseGeneral.dtListarUsuarioReversionProvision(obeGeneral)
    End Function

    Public Function ListaTipoDeAlmacen() As List(Of ClaseGeneral)
        Return oClaseGeneral.ListaTipoDeAlmacen()
    End Function

    Public Function ListaTipoDeMaterial() As List(Of ClaseGeneral)
        Return oClaseGeneral.ListaTipoDeMaterial()
    End Function

    '<[AHM]>
    Public Function Listar_Tipo_Servicio_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_Servicio_SAP(PSCDSRSP)
    End Function

    Public Function Listar_Tipo_UnidadProductiva_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)
    End Function


    Public Function Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String) As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(PSCDSRSP, PSCDSPSP)
    End Function
    ' Public Function Listar_Tipo_UnidadProductiva_SAP(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String) As List(Of ClaseGeneral)



    Public Function Listar_Tipo_Activo_SAP() As List(Of ClaseGeneral)
        Return oClaseGeneral.Listar_Tipo_Activo_SAP()
    End Function
    '</[AHM]>
	
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Function Listar_Datos_Estructura_Cebe()
        Return oClaseGeneral.Listar_Datos_Estructura_Cebe()
    End Function

    Public Function Buscar_CeCo(ByVal objCentroCosto As CentroCosto) As DataTable
        Return oClaseGeneral.Buscar_CeCo2(objCentroCosto)
    End Function
    'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

    Public Function Buscar_CeBe(ByVal objImput As beImputCeBe) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        If objImput.Codigo = String.Empty Then
            objImput.Codigo = "0"
        End If

        If objImput.TipoOrigen = "T" Then
            objImput.CodTipoActivoSAP = objImput.CodTipoActivoSAP_T
        End If

        Return oClaseGeneral.Buscar_CeBe(objImput)
    End Function

    Public Function Buscar_CeCo(ByVal objImput As beImputCeCo) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        If objImput.Codigo = String.Empty Then
            objImput.Codigo = "0"
        End If

        Return oClaseGeneral.Buscar_CeCo(objImput)
    End Function


    Public Function Listar_Autorizacion_Liquidacion_Opcion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Return oClaseGeneral.Listar_Autorizacion_Liquidacion_Opcion(obeGeneral)
    End Function
    Public Function Listar_Autorizacion_Usuario(ByVal obeGeneral As ClaseGeneral) As DataTable
        Return oClaseGeneral.Listar_Autorizacion_Usuario(obeGeneral)
    End Function

    Public Function Listar_Registro_Autorizacion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Return oClaseGeneral.Listar_Registro_Autorizacion(obeGeneral)
    End Function
    Public Function Listar_Opciones_Autorizacion(ByVal obeGeneral As ClaseGeneral) As DataTable
        Return oClaseGeneral.Listar_Opciones_Autorizacion(obeGeneral)
    End Function


    ' Public Function Listar_Opciones_Autorizacion(ByVal obeGeneral As ClaseGeneral) As DataTable
    'Public Function Insertar_Registro_Autorizacion(ByVal obeGeneral As ClaseGeneral) As Boolean
    '    Return oClaseGeneral.Insertar_Registro_Autorizacion(obeGeneral)
    'End Function
    Public Function Asignar_autorizacion_usuario(ByVal obeGeneral As ClaseGeneral) As String
        Return oClaseGeneral.Asignar_autorizacion_usuario(obeGeneral)
    End Function

    Public Function Eliminar_autorizacion_usuario(ByVal obeGeneral As ClaseGeneral) As String
        Return oClaseGeneral.Eliminar_autorizacion_usuario(obeGeneral)
    End Function



End Class
