Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class TipoCarroceria_DAL
    Private objSql As New SqlManager

    Public Function Listar_TipoCarroceria(ByVal strCompania As String) As List(Of TipoCarroceria)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TipoCarroceria)
        Try
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_CARROCERIA", Nothing)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TipoCarroceria
                objDatos.CTPCRA = objDataRow("CTPCRA").ToString.Trim
                objDatos.TCMCRA = objDataRow("TCMCRA").ToString.Trim
                objDatos.TARCRA = objDataRow("TARCRA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function

    Public Function Listar_TipoCarroceria_DeBitacoraVehiculo(ByVal objEntidad As TipoCarroceria) As List(Of TipoCarroceria)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of TipoCarroceria)
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            'Obteniendo resultados
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_CARROCERIA_DE_BIT_VEH", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New TipoCarroceria
                objDatos.CTPCRA = objDataRow("CTPCRA").ToString.Trim
                objDatos.TCMCRA = objDataRow("TCMCRA").ToString.Trim
                objDatos.TARCRA = objDataRow("TARCRA").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection

    End Function
End Class
