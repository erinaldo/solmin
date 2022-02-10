Imports SOLMIN_ST.DATOS.Operaciones
Imports System.Windows.Forms
Namespace Operaciones
  Public Class ReFacturacion_BLL

    Public Function Listar_Operaciones_Liquidadas(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Dim dtQuery As DataTable
            Dim dtResult As DataTable
            Dim _NumeroFactura As Decimal = 0

            Dim drRow As DataRow
            dtQuery = ReFacturacionDAL.Listar_Operaciones_Liquidadas(param)
            dtResult = dtQuery.Clone
            Dim dvDatos As New DataView(dtQuery)
            dvDatos.Sort = "NDCMFC ASC"
            dtQuery = dvDatos.ToTable()
            For Each drFila As DataRow In dtQuery.Rows
                If _NumeroFactura <> drFila("NDCMFC") Then
                    Dim _CentroCosto As String = ""
                    For Each dr As DataRow In dtQuery.Select(String.Format("NDCMFC={0}", drFila("NDCMFC")))
                        _CentroCosto += dr("TCNTCS").ToString.Trim & Chr(10)
                    Next
                    If _CentroCosto.Length > 0 Then
                        _CentroCosto = _CentroCosto.Substring(0, _CentroCosto.Length - 1)
                    End If
                    drRow = dtResult.NewRow
                    drRow("TCMTPD") = drFila("TCMTPD").ToString.Trim
                    drRow("NDCMFC") = drFila("NDCMFC")
                    drRow("FECFAC") = drFila("FECFAC")
                    drRow("CCLNT") = drFila("CCLNT")
                    drRow("TCMPCL") = drFila("TCMPCL").ToString.Trim
                    drRow("CCLNFC") = drFila("CCLNFC")
                    drRow("TCMPCF") = drFila("TCMPCF").ToString.Trim
                    drRow("CPLNCL") = drFila("CPLNCL")
                    drRow("TPLNTA") = drFila("TPLNTA").ToString.Trim
                    drRow("CTPOSR") = drFila("CTPOSR")
                    drRow("TCMTPS") = drFila("TCMTPS").ToString.Trim
                    drRow("TCMSBS") = drFila("TCMSBS").ToString.Trim
                    drRow("TDRCNS") = drFila("TDRCNS").ToString.Trim
                    drRow("NRUCCN") = drFila("NRUCCN")
                    drRow("TCNTCS") = _CentroCosto
                    drRow("CRGVTA") = drFila("CRGVTA")
                    drRow("TCRVTA") = drFila("TCRVTA").ToString.Trim
                    drRow("CMNDA") = drFila("CMNDA")
                    drRow("MONEDA") = drFila("MONEDA").ToString.Trim
                    dtResult.Rows.Add(drRow)
                    _NumeroFactura = drFila("NDCMFC")
                End If
            Next
            Return dtResult
    End Function
        Public Sub Insertar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable)
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            ReFacturacionDAL.Insertar_Importes_X_Operaciones_Facturadas(param)
        End Sub
        Public Sub Eliminar_Servicios_A_ReFacturar(ByVal param As Hashtable)
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            ReFacturacionDAL.Eliminar_Servicios_A_ReFacturar(param)
        End Sub
        Public Function Listar_Importes_X_Operaciones_Facturadas(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Listar_Importes_X_Operaciones_Facturadas(param)
        End Function
        Public Function Listar_Guias_X_Operaciones(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Listar_Guias_X_Operaciones(param)
        End Function
    Public Function Listar_Documentos_Emitidos_x_Operacion(ByVal param As Hashtable) As DataTable
      Dim ReFacturacionDAL As New ReFacturacion_DAL
      Return ReFacturacionDAL.Listar_Documentos_Emitidos_x_Operacion(param)
    End Function
    Public Function Traer_Importe_Refactura(ByVal param As Hashtable) As DataTable
      Dim ReFacturacionDAL As New ReFacturacion_DAL
      Return ReFacturacionDAL.Traer_Importe_Refactura(param)
    End Function
    Public Function Listar_Operaciones_Nota_Credito(ByVal param As Hashtable) As DataTable
      Dim ReFacturacionDAL As New ReFacturacion_DAL
      Return ReFacturacionDAL.Listar_Operaciones_Nota_Credito(param)
        End Function


#Region "RefacturacionElectronica"

        Public Function Lista_Cuenta_Corriente_Refactura(ByVal param As Hashtable, ByRef Num_pag As Integer) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Cuenta_Corriente_Refactura(param, Num_pag)
        End Function

        'Public Function Listar_Operaciones_Servicio_X_Documento(ByVal param As Hashtable) As DataTable
        '    Dim ReFacturacionDAL As New ReFacturacion_DAL
        '    Return ReFacturacionDAL.Listar_Operaciones_Servicio_X_Documento(param)
        'End Function
        Public Function Listar_SegHistorial_Documento_Refactura(ByVal param As Hashtable) As DataSet
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Listar_SegHistorial_Documento_Refactura(param)
        End Function

        'Public Function Lista_Cuenta_Corriente_Refactura_Referencia(ByVal param As Hashtable) As DataTable
        '    Dim ReFacturacionDAL As New ReFacturacion_DAL
        '    Return ReFacturacionDAL.Lista_Cuenta_Corriente_Refactura_Referencia(param)
        'End Function

        'Public Function Lista_CtaCte_Venta(ByVal param As Hashtable) As DataTable
        '    Dim ReFacturacionDAL As New ReFacturacion_DAL
        '    Return ReFacturacionDAL.Lista_CtaCte_Venta(param)
        'End Function

        Public Function Lista_Dato_General_Documento(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Dato_General_Documento(param)
        End Function

        Public Function Verifica_Doc_Historial_Refactura(ByVal PNCTPODC As Decimal, ByVal PNNDCFCC As Decimal) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Verifica_Doc_Historial_Refactura(PNCTPODC, PNNDCFCC)
        End Function

        Public Function Grabar_Historial_Documento_Cabecera(ByVal param As Object) As Decimal
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Grabar_Historial_Documento_Cabecera(param)
        End Function

        Public Sub Grabar_Historial_Documento_Detalle(ByVal param As Object)
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            ReFacturacionDAL.Grabar_Historial_Documento_Detalle(param)
        End Sub


        Public Function Lista_Operacion_Refactura(ByVal param As Object) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Operacion_Refactura(param)
        End Function

        Public Function Lista_Operacion_Servicio_Refactura(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Operacion_Servicio_Refactura(param)
        End Function

        Public Function Lista_Motivos_Notas(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Motivos_Notas(param)
        End Function

        Public Function Traer_Importe_Refactura_E(ByVal param As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Traer_Importe_Refactura_E(param)
        End Function

        Public Function Lista_Detalle_Servicios_Notas(ByVal objParametro As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Detalle_Servicios_Notas(objParametro)
        End Function


        Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Tipo_Cambio(objParametro)
        End Function

        Public Function Lista_Region_Venta_X_Operacion(ByVal objParametro As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Region_Venta_X_Operacion(objParametro)
        End Function

        Public Function Lista_Giro_Negocio(ByVal objParametro As Hashtable) As DataTable
            Dim ReFacturacionDAL As New ReFacturacion_DAL
            Return ReFacturacionDAL.Lista_Giro_Negocio(objParametro)
        End Function
#End Region

  End Class
End Namespace


