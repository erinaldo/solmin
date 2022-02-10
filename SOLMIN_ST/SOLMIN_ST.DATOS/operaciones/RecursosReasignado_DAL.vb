Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Data
Imports Ransa.Utilitario
Public Class RecursosReasignado_DAL
    Dim objSql As SqlManager
    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Recursos_Asignados(ByVal LobjEntidad As AsigRecursoGT_BE) As List(Of AsigRecursoGT_BE)
        Dim objResultado As New DataTable
        Dim objEntidad As AsigRecursoGT_BE
        Dim objListEntidad As New List(Of AsigRecursoGT_BE)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", LobjEntidad.CCMPN)
        objParam.Add("PNCTRMNC", LobjEntidad.CTRMNC)
        objParam.Add("PNNGUITR", LobjEntidad.NGUITR)
        'objSql.DefaultSchema = Trim(Autenticacion_DAL.GetLibrary(LobjEntidad.CCMPN))
        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_REASIGNACION_RECURSO_GT", objParam)
        If Not objResultado Is Nothing Then
            If objResultado.Rows.Count <> 0 Then
                For Each objDataRow As DataRow In objResultado.Rows
                    objEntidad = New AsigRecursoGT_BE
                    objEntidad.FECHA_ASIG =   HelpClass.CFecha_de_8_a_10(objDataRow("FECHA_ASIG")) 
                    objEntidad.CTRMNC = objDataRow("CTRMNC").ToString.Trim
                    objEntidad.NGUITR = objDataRow("NGUITR").ToString.Trim
                    objEntidad.CORR = objDataRow("CORR").ToString.Trim
                    objEntidad.TRACTO = objDataRow("TRACTO").ToString.Trim
                    objEntidad.ACOPLADO = objDataRow("ACOPLADO").ToString.Trim
                    objEntidad.CONDUCTOR1 = objDataRow("CONDUCTOR1").ToString.Trim
                    objEntidad.CONDUCTOR2 = objDataRow("CONDUCTOR2").ToString.Trim
                    objEntidad.LOCALIDAD_ORIGEN = objDataRow("LOCALIDAD_ORIGEN").ToString.Trim
                    objEntidad.LOCALIDAD_DESTINO = objDataRow("LOCALIDAD_DESTINO").ToString.Trim
                    objEntidad.MOTIVO = objDataRow("MOTIVO").ToString.Trim
                    objEntidad.OBS = objDataRow("OBS").ToString.Trim
                    objListEntidad.Add(objEntidad)
                Next
            End If
        End If
        Return objListEntidad
    End Function
    Public Function Insertar_Asignacion_Recurso(ByVal param As AsigRecursoGT_BE) As String
        Dim Msg As String = ""
        Dim objParam As New Parameter
        Dim objResultado As New DataTable
        objParam.Add("PSCCMPN", param.CCMPN)
        objParam.Add("PNFECHAINICIO", param.FECHAINICIO)
        objParam.Add("PNCTRMNC", param.CTRMNC)
        objParam.Add("PNNGUITR", param.NGUITR)
        objParam.Add("PSMOTIVO", param.MOTIVO)
        objParam.Add("PNCMEDTR", param.CMEDTR)
        objParam.Add("PSTRACTO", param.TRACTO)
        objParam.Add("PSACOPLADO", param.ACOPLADO)
        objParam.Add("PSBREVETE1", param.CONDUCTOR1)
        objParam.Add("PSBREVETE2", param.CONDUCTOR2)
        objParam.Add("PSCOD_ORIGEN", param.COD_LOCALIDAD_ORIGEN)
        objParam.Add("PSCOD_DESTINO", param.COD_LOCALIDAD_DESTINO)
        objParam.Add("PSOBS", param.OBS)
        objParam.Add("PSCULUSA", param.CULUSA)
        objParam.Add("PSTERMINAL", param.TERMINAL)

        objSql.DefaultSchema = Trim(Autenticacion_DAL.GetLibrary(param.CCMPN))
        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_REASIGNACION_RECURSO_GT", objParam)

        If Not objResultado Is Nothing Then
            For Each objDataRow As DataRow In objResultado.Rows
                If objDataRow("STATUS").ToString.Trim = "N" Then
                    Msg = Msg & objDataRow("OBSRESULT").ToString.Trim & Chr(13)
                End If
            Next
        End If
        Return Msg.Trim()
    End Function
    Public Function Eliminar_Asignacion_Recurso(ByVal param As AsigRecursoGT_BE) As String
        Dim Msg As String = ""
        Dim objParam As New Parameter
        Dim objResultado As New DataTable
        objParam.Add("PSCCMPN", param.CCMPN)
        objParam.Add("PNCTRMNC", param.CTRMNC)
        objParam.Add("PNNGUITR", param.NGUITR)
        objParam.Add("PNCORR", param.CORR)
        objParam.Add("PSCULUSA", param.CULUSA)
        objParam.Add("PSTERMINAL", param.TERMINAL)
        objSql.DefaultSchema = Trim(Autenticacion_DAL.GetLibrary(param.CCMPN))
        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_ELIMINAR_REASIGNACION_RECURSO_GT", objParam)
        If Not objResultado Is Nothing Then
            For Each objDataRow As DataRow In objResultado.Rows
                If objDataRow("STATUS").ToString.Trim = "N" Then
                    Msg = Msg & objDataRow("OBSRESULT").ToString.Trim & Chr(13)
                End If
            Next
        End If
        Return Msg.Trim()
    End Function
End Class
