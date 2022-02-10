Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports System.Text 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

Public Class clsCuentaCorriente
    Private oCuentaCorrienteDato As SOLMIN_CTZ.DATOS.clsCuentaCorriente
    Private oDt As DataTable

    Sub New()
        oCuentaCorrienteDato = New SOLMIN_CTZ.DATOS.clsCuentaCorriente
    End Sub

    ReadOnly Property Lista_CuentaCorrientes() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property

    Public Sub Buscar_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente)
        oDt = oCuentaCorrienteDato.Lista_CuentaCorriente(pobjCuentaCorriente)
    End Sub
    Public Function Listar_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente(pobjCuentaCorriente)
    End Function
    Public Function Listar_CuentaCorriente_Rubros(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente_Rubro(pobjCuentaCorriente)
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Perido(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente_X_Cliente_Periodo(pobjCuentaCorriente)
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Perido_Detalle(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente_X_Cliente_Periodo_Detalle(pobjCuentaCorriente)
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Anio(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente_X_Cliente_Anio(pobjCuentaCorriente)
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Anio_Detalle(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CuentaCorriente_X_Cliente_Anio_Detalle(pobjCuentaCorriente)
    End Function
    Public Function Lista_CtaCte_OrdenesInternas(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Lista_CtaCte_OrdenesInternas(pobjCuentaCorriente)
    End Function

    Public Function Cargar_Reporte_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Cargar_Reporte_CuentaCorriente(pobjCuentaCorriente)
    End Function

    Public Function Cargar_Reporte_Ventas_General(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Cargar_Reporte_Ventas_General(pobjCuentaCorriente)
    End Function

    Public Function Cargar_Reporte_Ventas_Detallado(ByVal pobjCuentaCorriente As CuentaCorriente) As DataSet
        Return oCuentaCorrienteDato.Cargar_Reporte_Ventas_Detallado(pobjCuentaCorriente)
    End Function

    Public Function Cargar_Reporte_Ventas_Detallado_Documento(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Cargar_Reporte_Ventas_Detallado_Documento(pobjCuentaCorriente)
    End Function


    Public Function Cargar_Reporte_Ventas_CentroCosto(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Cargar_Reporte_Ventas_CentroCosto(pobjCuentaCorriente)
    End Function

    Public Sub AnularCuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente)
        Try
            oCuentaCorrienteDato.AnularCuentaCorriente(pobjCuentaCorriente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Generar_SAP_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente)
        Try
            oCuentaCorrienteDato.Generar_SAP_CuentaCorriente(pobjCuentaCorriente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Listar_Sustento_Factura(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Listar_Sustento_Factura(pobjCuentaCorriente)
    End Function

    Public Function Listar_Compara_Servicio(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Return oCuentaCorrienteDato.Listar_Compara_Servicio(pobjCuentaCorriente)
    End Function
    Public Function Listar_FacturadoSOLMIN(ByVal pobjCuentaCorriente As CuentaCorriente) As DataSet
        Return oCuentaCorrienteDato.Listar_FacturadoSOLMIN(pobjCuentaCorriente)
    End Function

    Public Function ActualizaEstadoDocumento(ByVal pobjCuentaCorriente As CuentaCorriente) As Integer
        Return oCuentaCorrienteDato.ActualizaEstadoDocumento(pobjCuentaCorriente)
    End Function

    Public Function Buscar_PorNumero_Documento(ByVal psNumero As Integer, ByVal pnTipo As Integer) As DataTable
        Return oCuentaCorrienteDato.Buscar_PorNumero_Documento(psNumero, pnTipo)
    End Function

    Public Function ObtenerCorrelativo(ByVal strCadena As String) As DataTable
        Dim oDt As DataTable = oCuentaCorrienteDato.ObtenerCorrelativo(strCadena)
        Return oDt
    End Function

    Public Function Buscar_Documento_Masivo(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim oDt As DataTable = oCuentaCorrienteDato.Buscar_Documento_Masivo(pobjCuentaCorriente)
        Return oDt
    End Function

    Public Function Lista_CuentaCorriente_X_NRelCobranza(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim oDt As DataTable = oCuentaCorrienteDato.Lista_CuentaCorriente_X_NRelCobranza(pobjCuentaCorriente)
        Return oDt
    End Function

    Public Function Anular_Cuenta_Corriente(ByVal pobjCuentaCorriente As CuentaCorriente) As String
        Dim msg As String = ""
        Dim retorno As Int32 = 0
        retorno = oCuentaCorrienteDato.Anular_Cuenta_Corriente(pobjCuentaCorriente)
        msg = retorno
        'Select Case retorno
        '    Case 0
        '        msg = pobjCuentaCorriente.PNNDCCTC & " - Debe ser Eliminado antes."
        '    Case 1
        '        msg = "" ' satisfactorio
        '    Case 2
        '        msg = pobjCuentaCorriente.PNNDCCTC & " - Registro no procesado desde el Sistema"
        'End Select
        Return msg
    End Function

    Public Function Lista_Tipo_Cambio_Actual(ByVal PNCMNDA1 As Decimal) As DataTable
        Dim oDt As DataTable = oCuentaCorrienteDato.Lista_Tipo_Cambio_Actual(PNCMNDA1)
        Return oDt
    End Function

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Function ValidarAnulacionDocumento(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As String
        Dim mensaje As New StringBuilder
        For Each row As DataRow In oCuentaCorrienteDato.ValidarAnulacionDocumento(ccmpn, ctpodc, ndcctc).Rows
            If row("STATUS").ToString.Trim = "N" Then
                mensaje.AppendLine(row("OBSRESULT").ToString.Trim)
            End If
        Next row
        Return mensaje.ToString()
    End Function

    Public Function AnulacionCuentaCorriente(ByVal cuentaCorriente As CuentaCorriente) As String
        Dim mensaje As New StringBuilder
        For Each row As DataRow In oCuentaCorrienteDato.AnulacionCuentaCorriente(cuentaCorriente).Rows
            If row("STATUS").ToString.Trim = "N" Then
                mensaje.AppendLine(row("OBSRESULT").ToString.Trim)
            End If
        Next row
        Return mensaje.ToString()
    End Function
    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
End Class




