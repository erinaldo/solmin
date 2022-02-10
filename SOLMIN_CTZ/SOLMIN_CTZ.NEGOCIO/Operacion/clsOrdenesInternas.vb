Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsOrdenesInternas

    Private oOrdenesInternasDato As SOLMIN_CTZ.DATOS.clsOrdenesInternas
    Private oDt As DataTable

    Sub New()
        oOrdenesInternasDato = New SOLMIN_CTZ.DATOS.clsOrdenesInternas
    End Sub

    ReadOnly Property Lista_OrdenInterna() As DataTable
        Get
            Return (Me.oDt)
        End Get
    End Property
    ''' <summary>
    ''' Lista Las Ordenes Internas
    ''' </summary>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function Lista_Ordenes_Internas(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.Lista_Ordenes_Internas(pobjOrdenesInternas)
    End Function

    Public Function Lista_Ordenes_Internas_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.Lista_Ordenes_Internas_RSAP22(pobjOrdenesInternas)
    End Function

    Public Function ObtieneSociedad(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.ObtieneSociedad(pobjOrdenesInternas)
    End Function

    Public Function Lista_Ordenes_Internas_Detalle(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.Lista_Ordenes_Internas_Detalle(pobjOrdenesInternas)
    End Function

    Public Function Lista_Ordenes_Internas_Resumen(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.Lista_Ordenes_Internas_Resumen(pobjOrdenesInternas)
    End Function

    Public Function Lista_Ordenes_Internas_Resumen_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Return oOrdenesInternasDato.Lista_Ordenes_Internas_Resumen_RSAP22(pobjOrdenesInternas)
    End Function
    ''' <summary>
    ''' Lista Las Ordenes Internas V1 Formateadas para el Reporte
    ''' En caso de Error devuelve Nothing
    ''' </summary>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function Lista_Ordenes_Internas_Reporte(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Try
            'Se hace el formateo Necesario

            Dim oDt As DataTable = oOrdenesInternasDato.Lista_Ordenes_Internas_Reporte(pobjOrdenesInternas)
            Dim oDtFormato As New DataTable
            Dim filaNueva As DataRow
            oDtFormato = oDt.Clone
            oDtFormato.Columns(6).DataType = GetType(String)
            oDtFormato.Columns(8).DataType = GetType(String)
            oDtFormato.Columns(10).DataType = GetType(String)
            oDtFormato.Columns(12).DataType = GetType(String)
            oDtFormato.Columns(14).DataType = GetType(String)
            For i As Integer = 0 To oDt.Rows.Count - 1
                filaNueva = oDtFormato.NewRow()
                filaNueva(0) = oDt.Rows(i).Item("CSCDSP")
                filaNueva(1) = oDt.Rows(i).Item("NORSAP")
                filaNueva(2) = oDt.Rows(i).Item("CCLORI")
                filaNueva(3) = oDt.Rows(i).Item("TOBSOI")
                filaNueva(4) = oDt.Rows(i).Item("CCEBEN")
                filaNueva(5) = oDt.Rows(i).Item("CFAOAB")
                filaNueva(6) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FFAOAB"))
                filaNueva(7) = oDt.Rows(i).Item("CFAOLI")
                filaNueva(8) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FFAOLI"))
                filaNueva(9) = oDt.Rows(i).Item("CFAOCT")
                filaNueva(10) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FFAOCT"))
                filaNueva(11) = oDt.Rows(i).Item("CFAOCE")
                filaNueva(12) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FFAOCE"))
                filaNueva(13) = oDt.Rows(i).Item("NORDEX")
                filaNueva(14) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FFACTU"))
                oDtFormato.Rows.Add(filaNueva)
            Next
            'Se hace el formateo Necesario
            Return oDtFormato
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Lista Las Ordenes Internas V2 Formateadas para el Reporte
    ''' En caso de Error devuelve Nothing
    ''' </summary>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function Lista_Ordenes_Internas_Reporte_V2(ByVal pobjOrdenesInternas As OrdenesInternas) As DataTable
        Try
            Dim oDt As DataTable = oOrdenesInternasDato.Lista_Ordenes_Internas_Reporte_V2(pobjOrdenesInternas)
            Dim oDtFormato As New DataTable
            Dim filaNueva As DataRow
            oDtFormato = oDt.Clone
            oDtFormato.Columns(2).DataType = GetType(String)
            oDtFormato.Columns(10).DataType = GetType(String)
            oDtFormato.Columns(12).DataType = GetType(String)
            oDtFormato.Columns(14).DataType = GetType(String)
            For i As Integer = 0 To oDt.Rows.Count - 1
                filaNueva = oDtFormato.NewRow()
                filaNueva(0) = oDt.Rows(i).Item("CCLORI")
                filaNueva(1) = oDt.Rows(i).Item("AUFNR")
                filaNueva(2) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("ZFECALTA"))
                filaNueva(3) = oDt.Rows(i).Item("NORSRT")
                filaNueva(4) = oDt.Rows(i).Item("NOPRCN")
                filaNueva(5) = oDt.Rows(i).Item("NDCMFC")
                filaNueva(6) = oDt.Rows(i).Item("SESTOP")
                filaNueva(7) = oDt.Rows(i).Item("NPLVHT")
                filaNueva(8) = oDt.Rows(i).Item("WERKS")
                filaNueva(9) = oDt.Rows(i).Item("ZSTALIB")
                filaNueva(10) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("ZFECLIB"))
                filaNueva(11) = oDt.Rows(i).Item("ZSTACIE")
                filaNueva(12) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("XFECCIE"))
                filaNueva(13) = oDt.Rows(i).Item("ZSTAFI")
                filaNueva(14) = HelpClass.CNumero8Digitos_a_FechaDefault(oDt.Rows(i).Item("FCIEFI"))
                filaNueva(15) = oDt.Rows(i).Item("ZSALDO")
                oDtFormato.Rows.Add(filaNueva)
            Next
            'Se hace el formateo Necesario
            Return oDtFormato
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub Actualiza_SAP_OrdenInterna(ByVal pobjOrdenesInternas As OrdenesInternas)
        Try
            oOrdenesInternasDato.Actualiza_SAP_OrdenInterna(pobjOrdenesInternas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub Actualiza_SAP_OrdenInterna_RSAP22(ByVal pobjOrdenesInternas As OrdenesInternas)
        Try
            oOrdenesInternasDato.Actualiza_SAP_OrdenInterna_RSAP22(pobjOrdenesInternas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
