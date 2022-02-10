
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class Programacion_Unid_Junta_DAL
    Private objSql As New SqlManager

    Public Sub Insertar_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad)

        Dim objParam As New Parameter

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PNFPRASG", Entidad.FPRASG)
        objParam.Add("PSNRUCTR", Entidad.NRUCTR)
        objParam.Add("PSNPLCUN", Entidad.NPLCUN)
        objParam.Add("PSNPLCAC", Entidad.NPLCAC)
        objParam.Add("PSCBRCNT", Entidad.CBRCNT)
        objParam.Add("PSCBRCN2", Entidad.CBRCN2)
        objParam.Add("PSTOBS", Entidad.TOBS)
        objParam.Add("PSCUSCRT", Entidad.CUSCRT)
        objParam.Add("PSNTRMCR", Entidad.NTRMCR)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_INSERT", objParam)

    End Sub

    Public Function Lista_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal CCMPN As String) As List(Of Programacion_Unidad)

        Dim objParam As New Parameter
        Dim Lista As New List(Of Programacion_Unidad)
        Dim Entida As Programacion_Unidad
        Dim dt As New DataTable

        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_LIST", objParam)

        For Each fila As DataRow In dt.Rows

            Entida = New Programacion_Unidad
            Entida.NPLNJT = fila("NPLNJT")
            Entida.NCRRPL = fila("NCRRPL")
            Entida.NUMREQT = fila("NUMREQT")
            Entida.NCRRPA = fila("NCRRPA")
            Entida.FPRASG = fila("FPRASG")
            Entida.FPRASG_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(fila("FPRASG"))).ToString()
            Entida.NRUCTR = fila("NRUCTR")
            Entida.TCMTRT = fila("TCMTRT")
            Entida.NPLCUN = fila("NPLCUN")
            Entida.NPLCAC = fila("NPLCAC")
            Entida.CBRCNT = fila("CBRCNT")
            Entida.TNMCMC = fila("TNMCMC")
            Entida.CBRCN2 = fila("CBRCN2")
            Entida.TNMCMC2 = fila("TNMCMC2")
            Entida.TOBS = fila("TOBS").ToString.Trim
            Entida.SESASG = fila("SESASG")
            If fila("SESASG").ToString.Trim = "P" Then
                Entida.SESASG_D = "Programado"
            Else
                Entida.SESASG_D = "Asignado"
            End If
            Entida.SESTRG = fila("SESTRG")
            Entida.NOPRCN = fila("NOPRCN")

            Lista.Add(Entida)
        Next
        Return Lista


    End Function

    Public Function Eliminar_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad) As Int32

        Dim objParam As New Parameter
        Dim Respuesta As Int32 = 0

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PNNCRRPA", Entidad.NCRRPA)
        objParam.Add("PSUSUARIO", Entidad.CULUSA)
        objParam.Add("PSTERMINAL", Entidad.NTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_ELIMINAR", objParam)
        Respuesta = 1

        Return Respuesta

    End Function

    Public Function Lista_Unidades_Programadas(ByVal CCMPN As String, ByVal NUMREQT As String, ByVal SESASG As String) As List(Of Programacion_Unidad)

        Dim objParam As New Parameter
        Dim Lista As New List(Of Programacion_Unidad)
        Dim Entida As Programacion_Unidad
        Dim dt As New DataTable

        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNNUMREQT", NUMREQT)
        objParam.Add("PSSESASG", SESASG)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_PROGRAMADAS_LIST", objParam)

        For Each fila As DataRow In dt.Rows

            Entida = New Programacion_Unidad
            Entida.NPLNJT = fila("NPLNJT")
            Entida.NCRRPL = fila("NCRRPL")
            Entida.NUMREQT = fila("NUMREQT")
            Entida.NCRRPA = fila("NCRRPA")
            Entida.FPRASG = fila("FPRASG")
            Entida.FPRASG_D = HelpClass.CNumero8Digitos_a_FechaDefault(CLng(fila("FPRASG"))).ToString()
            Entida.NRUCTR = fila("NRUCTR")
            Entida.TCMTRT = fila("TCMTRT").ToString.Trim
            Entida.NPLCUN = fila("NPLCUN")
            Entida.NPLCAC = fila("NPLCAC")
            Entida.CBRCNT = fila("CBRCNT")
            Entida.TNMCMC = fila("TNMCMC").ToString.Trim
            Entida.CBRCN2 = fila("CBRCN2")
            Entida.TNMCMC2 = fila("TNMCMC2").ToString.Trim
            Entida.TOBS = fila("TOBS")
            Entida.SESASG = fila("SESASG")
            If fila("SESASG").ToString.Trim = "P" Then
                Entida.SESASG_D = "Programado"
            Else
                Entida.SESASG_D = "Asignado"
            End If
            Entida.SESTRG = fila("SESTRG")
            Entida.NOPRCN = fila("NOPRCN")
            Lista.Add(Entida)
        Next
        Return Lista

    End Function

    Public Function Cambiar_Estado_Unidades_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal PNNOPRCN As Double) As Int32

        Dim objParam As New Parameter
        Dim Respuesta As Int32 = 0

        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PNNCRRPA", Entidad.NCRRPA)
        objParam.Add("PSSESASG", Entidad.SESASG)
        objParam.Add("PSUSUARIO", Entidad.CULUSA)
        objParam.Add("PSTERMINAL", Entidad.NTRMNL)
        objParam.Add("PNNOPRCN", CDec(PNNOPRCN))

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_ESTADO", objParam)
        Respuesta = 1

        Return Respuesta

    End Function



    Public Function Estado_Unidad_RequerimientosJunta(ByVal Entidad As Programacion_Unidad, ByVal CCMPN As String) As DataTable

        Dim objParam As New Parameter
        Dim dt As New DataTable

        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PNNPLNJT", Entidad.NPLNJT)
        objParam.Add("PNNCRRPL", Entidad.NCRRPL)
        objParam.Add("PNNUMREQT", Entidad.NUMREQT)
        objParam.Add("PNNCRRPA", Entidad.NCRRPA)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_JUNTA_X_REQUERIMIENTO_UNIDADES_ESTADO_ACT", objParam)

        Return dt

    End Function

End Class
