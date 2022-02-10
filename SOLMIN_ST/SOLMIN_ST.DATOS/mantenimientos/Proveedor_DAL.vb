Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class Proveedor_DAL
    Private objSql As New SqlManager

    Public Function Listar_Tipos(ByVal strCompania As String, ByVal strCodVar As String) As DataTable ''List(Of Proveedor)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PSCODVAR", strCodVar)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPOS", objParam)

        For Each Item As DataRow In objDataTable.Rows
            Item("CCMPRN") = ("" & Item("CCMPRN")).ToString.Trim
            Item("TDSDES") = ("" & Item("TDSDES")).ToString.Trim
        Next
        Return objDataTable
    End Function

    Public Function Listar_Proveedores_Alquiler(ByVal objEntidad As Proveedor) As List(Of Proveedor)
        Dim objDataTable As New DataTable
        Dim objDataSet As New DataSet
        Dim objGenericCollection As New List(Of Proveedor)
        Dim objParam As New Parameter

            'Obteniendo resultados
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSSTPRCS", objEntidad.STPRCS)
            objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
            objParam.Add("PSSESRCS", objEntidad.SESRCS)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ASIGNACION_RECURSO_PROVEEDOR_ALQUILER", objParam)

            'For Each objDt As DataTable In objDataSet.Tables
            '    If objDt.Rows.Count > 0 Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Proveedor
            objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
            objDatos.CDVSN = objDataRow("CDVSN").ToString.Trim
                objDatos.STPRCS = objDataRow("STPRCS").ToString.Trim
                objDatos.TDSDES = objDataRow("TDSDES").ToString.Trim
                objDatos.NPLRCS = objDataRow("NPLRCS").ToString.Trim
                objDatos.MARCA = objDataRow("MARCA").ToString.Trim
                objDatos.TIPO_UNIDAD = objDataRow("TIPO_UNIDAD").ToString.Trim
            objDatos.FECINI_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FECINI").ToString.Trim)
            objDatos.FECFIN_S = HelpClass.CNumero8Digitos_a_FechaDefault(objDataRow("FECFIN").ToString.Trim)

                objGenericCollection.Add(objDatos)
            Next

            Return objGenericCollection

    End Function

    Public Function Listar_Placa(ByVal objEntidad As Proveedor) As List(Of Proveedor)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objGenericCollection As New List(Of Proveedor)

        'Obteniendo resultados
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PLACA", objParam)
        If objEntidad.STPRCS = "T" Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Proveedor
                'objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
                objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
                objDatos.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                objDatos.PLACA = objDataRow("PLACA").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        ElseIf objEntidad.STPRCS = "A" Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Proveedor
                'objDatos.CTIACP = objDataRow("CTIACP").ToString.Trim
                objDatos.TDEACP = objDataRow("TDEACP").ToString.Trim
                objDatos.TMRCVH = objDataRow("TMRCVH").ToString.Trim
                objDatos.PLACA = objDataRow("PLACA").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        ElseIf objEntidad.STPRCS = "E" Then
            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New Proveedor
                'objDatos.CTIEQP = objDataRow("CTIEQP").ToString.Trim
                objDatos.TDEEQP = objDataRow("TDEEQP").ToString.Trim
                objDatos.TMRCTR = objDataRow("TMRCTR").ToString.Trim
                objDatos.PLACA = objDataRow("PLACA").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
        End If
        Return objGenericCollection
    End Function

    Public Sub Registrar_Asignacion_Proveedor_Recurso(ByVal objEntidad As Proveedor, ByVal PSREASIGNAR As String)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
        objParam.Add("PSREASIGNAR", PSREASIGNAR)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_INSERTAR_ASIGNACION_PROVEEDOR_RECURSO", objParam)

    End Sub

    Public Function Validar_Existe_Placa_Proveedor(ByVal objEntidad As Proveedor, ByRef strMensajeError As String) As Boolean
        Dim bResultado As Boolean = True
        'Try
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_PLACA_PROVEEDOR", objParam)
        strMensajeError = "" & objSql.ParameterCollection("OU_MSGERR")
        strMensajeError = strMensajeError.Trim


        If strMensajeError <> "" Then bResultado = False
        'Catch ex As Exception
        '    strMensajeError = ex.Message
        '    bResultado = False
        'End Try
        Return bResultado
    End Function

    Public Function Eliminar_Asignacion_Proveedor_Recurso(ByVal objEntidad As Proveedor) As Integer
        Dim objParam As New Parameter
        Dim intResultado As Integer
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
        objParam.Add("PSSTPRCS", objEntidad.STPRCS)
        objParam.Add("PSNPLRCS", objEntidad.NPLRCS)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PON_RESULT", 1, ParameterDirection.Output)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_ASIGNACION_PROVEEDOR_RECURSO", objParam)
        intResultado = objSql.ParameterCollection("PON_RESULT")
        Return intResultado
    End Function


    Public Function Listar_Placa_Recurso_Asignado(ByVal PSCCMPN As String, ByVal PSTIPO As String, ByVal PSPLACA As String) As DataTable
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PSTIPO", PSTIPO)
        objParam.Add("PSPLACA", PSPLACA)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PLACAS_ASIGNADAS", objParam)

        Return dt
    End Function


End Class
