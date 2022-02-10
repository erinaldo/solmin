Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Public Class TransporteConsolidado_BLL
  Dim TransporteConsolidadoDAL As New TransporteConsolidado_DAL

  Public Function Listar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TransporteConsolidado)
    Return TransporteConsolidadoDAL.Listar_Transporte_Consolidado(objEntidad)
  End Function

  Public Function Registrar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
    Return TransporteConsolidadoDAL.Registrar_Transporte_Consilidado(objEntidad)
  End Function

  Public Function Modificar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As String
    Return TransporteConsolidadoDAL.Modificar_Transporte_Consilidado(objEntidad)
  End Function

  Public Function Eliminar_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As String
    Return TransporteConsolidadoDAL.Eliminar_Transporte_Consolidado(objEntidad)
  End Function

  Public Function Registrar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
    Return TransporteConsolidadoDAL.Registrar_Solicitud_Transporte_Consolidado(objEntidad)
  End Function

  Public Function Modificar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
    Return TransporteConsolidadoDAL.Modificar_Solicitud_Transporte_Consolidado(objEntidad)
  End Function

  Public Function Listar_Solicitudes_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TransporteConsolidado)
    Return TransporteConsolidadoDAL.Listar_Solicitudes_Transporte_Consolidado(objEntidad)
  End Function

  Public Function Obtener_Datos_Solicitud_Transporte(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
    Return TransporteConsolidadoDAL.Obtener_Datos_Solicitud_Transporte(objEntidad)
  End Function

  Public Function Eliminar_Solicitud_Transporte_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of String)
    'Return TransporteConsolidadoDAL.Eliminar_Solicitud_Transporte_Consolidado(objEntidad)
    Dim strResult As New List(Of String)
    Select Case TransporteConsolidadoDAL.Eliminar_Solicitud_Transporte_Consolidado(objEntidad).NCRRSR
      Case 1
                strResult.Add("LA OPERACION SE ANULÓ SATISFACTORIAMENTE")
        strResult.Add(1)
      Case 2
        strResult.Add("LA OPERACION TIENE GUIA DE REMISION CARGADA")
        strResult.Add(2)
      Case 3
        strResult.Add("LA OPERACION ESTA LIQUIDADA")
        strResult.Add(3)
      Case 4
        strResult.Add("LA OPERACION ESTA PREFACTURADO / FACTURADO")
        strResult.Add(4)
      Case 5
        strResult.Add("LA OPERACION ESTA ANULADO")
        strResult.Add(5)
      Case 6
        strResult.Add("LA OPERACION TIENE ASIGNADO AVC Y/O GASTOS")
        strResult.Add(6)
            Case 7
                strResult.Add("SE DESENLAZÓ UNA OPERACION MULTIMODAL DEL TRASLADO CONSOLIDADO")
                strResult.Add(7)
            Case 8
                strResult.Add("LAS GUIAS ANEXAS ESTAN EN PROCESO DE CARGA O LIQUIDADAS")
                strResult.Add(8)
            Case 9
                strResult.Add("LAS GUIAS ANEXAS ESTAN LIQUIDADAS")
                strResult.Add(9)
        End Select
    Return strResult
  End Function

  Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As DataTable
    Return TransporteConsolidadoDAL.Listar_Guia_Transportista(objetoParametro)
  End Function

    Public Function Eliminar_Guia_Remision_Servicio_Consolidado(ByVal objEntidad As ENTIDADES.mantenimientos.GuiaTransportista) As Integer
        Return TransporteConsolidadoDAL.Eliminar_Guia_Remision_Servicio_Consolidado(objEntidad)
    End Function

  Public Function Validar_Estado_Traslado_Consolidado(ByVal objEntidad As TransporteConsolidado) As TransporteConsolidado
    Return TransporteConsolidadoDAL.Validar_Estado_Traslado_Consolidado(objEntidad)
  End Function

  Public Function Listar_Reporte_Excel(ByVal objetoParametro As Hashtable) As DataTable
    Dim dt As DataTable = TransporteConsolidadoDAL.Listar_Reporte_Excel(objetoParametro)

    Dim NMVJCS As String = ""
    Dim FCHVJC As String = ""
    Dim RUTA As String = ""
    Dim TCMTRT As String = ""
    Dim NPLCUN As String = ""
    Dim NPLCAC As String = ""
    Dim CBRCNT As String = ""

    Dim blExiste As Boolean = False

    For i As Integer = 0 To dt.Rows.Count - 1
      blExiste = False
      If i = 0 Then
        NMVJCS = dt.Rows(i).Item("NMVJCS").ToString
        FCHVJC = dt.Rows(i).Item("FCHVJC").ToString
        RUTA = dt.Rows(i).Item("RUTA").ToString
        TCMTRT = dt.Rows(i).Item("TCMTRT").ToString
        NPLCUN = dt.Rows(i).Item("NPLCUN").ToString
        NPLCAC = dt.Rows(i).Item("NPLCAC").ToString
        CBRCNT = dt.Rows(i).Item("CBRCNT").ToString
        '        If obj_Servicio.CTPALJ <> "RE" Then CREFFW = otblAlm.Rows(i).Item("CREFFW").ToString.Trim

      End If
      If NMVJCS = dt.Rows(i).Item("NMVJCS").ToString And _
                                        FCHVJC = dt.Rows(i).Item("FCHVJC").ToString And _
                                         RUTA = dt.Rows(i).Item("RUTA").ToString And _
                                        TCMTRT = dt.Rows(i).Item("TCMTRT").ToString And _
                                          NPLCUN = dt.Rows(i).Item("NPLCUN").ToString And _
                                          NPLCAC = dt.Rows(i).Item("NPLCAC").ToString And _
                                         CBRCNT = dt.Rows(i).Item("CBRCNT").ToString Then
        blExiste = True
      End If

      NMVJCS = dt.Rows(i).Item("NMVJCS").ToString
      FCHVJC = dt.Rows(i).Item("FCHVJC").ToString
      RUTA = dt.Rows(i).Item("RUTA").ToString
      TCMTRT = dt.Rows(i).Item("TCMTRT").ToString
      NPLCUN = dt.Rows(i).Item("NPLCUN").ToString
      NPLCAC = dt.Rows(i).Item("NPLCAC").ToString
      CBRCNT = dt.Rows(i).Item("CBRCNT").ToString

      '    '======Se limpia los los datos del bulto y sus items cuando no es de tipo reembolso=======                        
      If blExiste And i > 0 Then

        dt.Rows(i).Item("NMVJCS") = ""
        dt.Rows(i).Item("FCHVJC") = ""
        dt.Rows(i).Item("RUTA") = ""
        dt.Rows(i).Item("TCMTRT") = ""
        dt.Rows(i).Item("NPLCUN") = ""
        dt.Rows(i).Item("NPLCAC") = ""
        dt.Rows(i).Item("CBRCNT") = ""
        dt.AcceptChanges()
            End If
            If dt.Rows(i).Item("FCHVJC").ToString <> "" Then
                dt.Rows(i)("FCHVJC") = Validacion.CFecha_a_Numero10Digitos(dt.Rows(i).Item("FCHVJC").ToString)
            End If

            If dt.Rows(i).Item("FCHVJC").ToString <> "" Then
                dt.Rows(i)("FCHVJC") = Validacion.CFecha_a_Numero10Digitos(dt.Rows(i).Item("FCHVJC").ToString)
            End If
    Next

    dt.Columns(0).ColumnName = "NRO TRASLADO"
    dt.Columns(1).ColumnName = "FECHA TRASLADO"
    dt.Columns(2).ColumnName = "RUTA"
    dt.Columns(3).ColumnName = "TRANSPORTISTA"
    dt.Columns(4).ColumnName = "TRACTO"
    dt.Columns(5).ColumnName = "ACOPLADO"
    dt.Columns(6).ColumnName = "CONDUCTOR"
    dt.Columns(7).ColumnName = "CLIENTE"
    dt.Columns(8).ColumnName = "DIRECCIÓN ORIGEN"
    dt.Columns(9).ColumnName = "DIRECCIÓN ENTREGA"
    dt.Columns(10).ColumnName = "NUMERO GUIA TRANSPORTISTA"
    dt.Columns(11).ColumnName = "NUMERO OPERACIÓN"
    dt.Columns(12).ColumnName = "NUMERO GUÍA REMISIÓN"
    Return dt
  End Function

End Class
