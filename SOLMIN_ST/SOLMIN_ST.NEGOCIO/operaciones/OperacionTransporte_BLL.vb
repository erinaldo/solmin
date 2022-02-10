Imports SOLMIN_ST
Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones

  Public Class OperacionTransporte_BLL

    Dim objDataAccessLayer As New OperacionTransporte_DAL

    Sub New()
    End Sub

    Public Function Validar_Asignacion_Operacion_Transporte(ByVal objEntidad As List(Of String)) As String
      Return objDataAccessLayer.Validar_Asignacion_Operacion_Transporte(objEntidad).Replace("$", Chr(13))
    End Function

        'Public Function Registrar_Operacion_Transporte(ByVal objLista As List(Of String)) As String
        '  Return objDataAccessLayer.Registrar_Operacion_Transporte(objLista)
        '    End Function
        Public Function Registrar_Operacion_Transporte(ByVal objLista As ENTIDADES.beRespuestaOperacion, ByRef msgError As String) As ENTIDADES.beRespuestaOperacion
            Return objDataAccessLayer.Registrar_Operacion_Transporte(objLista, msgError)
        End Function



    Public Function Verificacion_Existencia_Operacion_Solicitud(ByVal objLista As List(Of String)) As String
      Return objDataAccessLayer.Verificacion_Existencia_Operacion_Solicitud(objLista)
    End Function

        Public Function Validar_Existe_Operacion(ByVal lint_NOPRCN As Double, ByVal strCompania As String) As Double
            Return objDataAccessLayer.Validar_Existe_Operacion(lint_NOPRCN, strCompania)
        End Function

    Public Function Listar_Guias_X_Operacion(ByVal objLista As List(Of String)) As DataTable
      Dim obj_DataTableRow As New DataTable
      Dim obj_DataTableColumn As DataTable
      Dim obj_DataViewRow As DataView
      Dim obj_DataViewColumn As New DataView
      Dim obj_DataTableGuiaXOperacion As New DataTable
      Dim obj_DataRow As DataRow
      Dim obj_DtRow As DataRow
      Dim lint_Estado As Integer = 0

      obj_DataTableColumn = objDataAccessLayer.Listar_Operacion(objLista)
      obj_DataViewRow = objDataAccessLayer.Listar_Guias_X_Operacion(objLista).DefaultView

      For lint_Columns As Integer = 0 To 13
        obj_DataTableGuiaXOperacion.Columns.Add("Columna" & lint_Columns)
      Next

      For Each lobj_DataRow As DataRow In obj_DataTableColumn.Rows
        Dim obj_DataTable As New DataTable
        If lint_Estado = 0 Then
          obj_DataRow = obj_DataTableGuiaXOperacion.NewRow
          obj_DataRow(0) = "N° Operación"
          obj_DataRow(1) = "Servico"
          obj_DataRow(2) = "Tipo Servicio"
          obj_DataRow(3) = "Fecha Operación"
          obj_DataRow(4) = "Estado Operación"
          obj_DataRow(5) = "Ref. Serv. Cliente"
          obj_DataRow(6) = "Cantidad Merc."
          obj_DataRow(7) = "Peso  Merc."
          obj_DataRow(8) = "Valor Merc."
          obj_DataRow(9) = "Ref. Merc. Cliente"
          obj_DataRow(10) = "Cliente"
          obj_DataTableGuiaXOperacion.Rows.Add(obj_DataRow)
          lint_Estado = 2
        End If
        obj_DataRow = obj_DataTableGuiaXOperacion.NewRow
        obj_DataRow(0) = lobj_DataRow(0).ToString.Trim
        obj_DataRow(1) = lobj_DataRow(1).ToString.Trim
        obj_DataRow(2) = lobj_DataRow(2).ToString.Trim
        obj_DataRow(3) = lobj_DataRow(3).ToString.Trim
        obj_DataRow(4) = lobj_DataRow(4).ToString.Trim
        obj_DataRow(5) = lobj_DataRow(5).ToString.Trim
        obj_DataRow(6) = lobj_DataRow(6).ToString.Trim
        obj_DataRow(7) = lobj_DataRow(7).ToString.Trim
        obj_DataRow(8) = lobj_DataRow(8).ToString.Trim
        obj_DataRow(9) = lobj_DataRow(9).ToString.Trim
        obj_DataRow(10) = lobj_DataRow(10).ToString.Trim
        obj_DataTableGuiaXOperacion.Rows.Add(obj_DataRow)
        obj_DataViewRow.RowFilter = "NOPRCN = " & lobj_DataRow.Item(0)
        obj_DataTable = obj_DataViewRow.ToTable

        For Each lobj_DataRow1 As DataRow In obj_DataTable.Rows
          obj_DtRow = obj_DataTableGuiaXOperacion.NewRow
          If lint_Estado = 2 Then
            obj_DataRow = obj_DataTableGuiaXOperacion.NewRow
            obj_DataRow(1) = "N° Guía"
            obj_DataRow(2) = "Fecha Guía"
            obj_DataRow(3) = "Estado Guía"
            obj_DataRow(4) = "N° Liquidación"
            obj_DataRow(5) = "Localidad Origen"
            obj_DataRow(6) = "Localidad Destino"
            obj_DataRow(7) = "N° Doc. Referencial"
            obj_DataRow(8) = "Fecha Guía Ref."
            obj_DataRow(9) = "Cod. Transportista"
            obj_DataRow(10) = "N° Placa Vehiculo"
            obj_DataRow(11) = "Cod. Conductor"
            obj_DataRow(12) = "Fecha Salida Vehiculo"
            obj_DataRow(13) = "Fecha Llegada Vehiculo"
            obj_DataTableGuiaXOperacion.Rows.Add(obj_DataRow)
            lint_Estado = 0
          End If
          obj_DtRow(1) = lobj_DataRow1(11).ToString.Trim
          obj_DtRow(2) = lobj_DataRow1(12).ToString.Trim
          obj_DtRow(3) = lobj_DataRow1(13).ToString.Trim
          obj_DtRow(4) = lobj_DataRow1(14).ToString.Trim
          obj_DtRow(5) = lobj_DataRow1(15).ToString.Trim
          obj_DtRow(6) = lobj_DataRow1(16).ToString.Trim
          obj_DtRow(7) = lobj_DataRow1(17).ToString.Trim
          obj_DtRow(8) = lobj_DataRow1(18).ToString.Trim
          obj_DtRow(9) = lobj_DataRow1(19).ToString.Trim
          obj_DtRow(10) = lobj_DataRow1(20).ToString.Trim
          obj_DtRow(11) = lobj_DataRow1(21).ToString.Trim
          obj_DtRow(12) = lobj_DataRow1(22).ToString.Trim
          obj_DtRow(13) = lobj_DataRow1(23).ToString.Trim
          obj_DataTableGuiaXOperacion.Rows.Add(obj_DtRow)
        Next
      Next
      Return obj_DataTableGuiaXOperacion
    End Function

    Public Function Listar_Operaciones_x_Cliente(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
      Return objDataAccessLayer.Listar_Operacion_x_Cliente(objParametro)
    End Function

    Public Function Listar_Operacion_x_Guia_y_Tracto(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
      Return objDataAccessLayer.Listar_Operacion_x_Guia_y_Tracto(objParametro)
    End Function

    Public Function Obtener_Numero_Planeamiento(ByVal objEntidad As OperacionTransporte) As OperacionTransporte
      Return objDataAccessLayer.Obtener_Numero_Planeamiento(objEntidad)
    End Function

    Public Function Registrar_Pase_Administrativo_Operacion(ByVal ht As Hashtable) As Int16
      Return objDataAccessLayer.Registrar_Pase_Administrativo_Operacion(ht)
        End Function

        Public Function Listar_Operaciones(ByVal objParametro As Hashtable) As DataTable 'List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operaciones(objParametro)
        End Function
        Public Function Listar_Operacion_Asignar(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operacion_Asignar(objParametro)
        End Function

        Public Function Listar_Operacion_TipViajeConsolidado_Asignar(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operacion_TipViajeConsolidado_Asignar(objParametro)
        End Function

        Public Function Validar_Existe_Vale_Combustible(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Validar_Existe_Vale_Combustible(objParametro)
        End Function

        Public Function Listar_Operaciones_Asignacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_Asignacion(objParametro)
        End Function

        Public Function Lista_Operaciones_Liq_Combustible_X_Cliente(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Lista_Operaciones_Liq_Combustible_X_Cliente(objParametro)
        End Function

        Public Function Listar_Operacion_Asignar_ImpExcel(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operacion_Asignar_ImpExcel(objParametro)
        End Function

        'Public Function Listar_Operaciones_Consumo_Neumatico(ByVal objParametro As Hashtable) As DataTable
        '    Return objDataAccessLayer.Listar_Operaciones_Consumo_Neumatico(objParametro)
        'End Function

        'Public Function Listar_Operaciones_Consumo_Mantenimiento(ByVal objParametro As Hashtable) As DataTable
        '    Return objDataAccessLayer.Listar_Operaciones_Consumo_Mantenimiento(objParametro)
        'End Function

        Public Function Listar_Operacion_X_Fecha_CN(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operacion_X_Fecha_CN(objParametro)
        End Function

        Public Function Listar_Operacion_X_Fecha_CM(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Return objDataAccessLayer.Listar_Operacion_X_Fecha_CM(objParametro)
        End Function

        Public Function Carga_InfEscaner(ByVal objParametro As Hashtable) As DataTable
            Dim obj_DataTableColumn As DataTable
            Dim obj_DataTableGuiaXOperacion As New DataTable
            obj_DataTableColumn = objDataAccessLayer.Carga_InfEscaner(objParametro)
            Return obj_DataTableColumn
        End Function
        Public Function Cargar_Ultimo_KM_Final_Unidad(CCMPN As String, NPLCUN As String) As DataTable
            Dim dt As New DataTable
            dt = objDataAccessLayer.Cargar_Ultimo_KM_Final_Unidad(CCMPN, NPLCUN)
            Return dt
        End Function

        Public Function Registrar_Recurso_Planeamiento_Operacion(oFiltro As ENTIDADES.Operaciones.OperacionTransporte, msgError As String) As DataTable
            Return objDataAccessLayer.Registrar_Recurso_Planeamiento_Operacion(oFiltro, msgError)

        End Function
        Public Function Actualizar_Fecha_Hora_Atencion_Servicio_Operacion(ByVal beOp As ENTIDADES.Operaciones.OperacionTransporte) As String
            Return objDataAccessLayer.Actualizar_Fecha_Hora_Atencion_Servicio_Operacion(beOp)
        End Function

    End Class

End Namespace