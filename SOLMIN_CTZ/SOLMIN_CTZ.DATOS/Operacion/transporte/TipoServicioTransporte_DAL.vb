Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports System.Data

Public Class TipoServicioTransporte_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Tipo_Servicio_Combo(ByVal strCompania As String) As DataTable
        Dim objResultado As New DataTable
        Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS", Nothing)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

    Public Function Obtener_TipoServicio(ByVal objEntidad As TipoServicioTransporte) As TipoServicioTransporte
        Try
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_TR_OBTENER_DATOS_SERVICIO", objParam)
            If objDataTable.Rows.Count > 0 Then
                With objDataTable.Rows(0)

                    objEntidad.CTPOSR = .Item("CTPOSR").ToString()
                    objEntidad.TCMTPS = .Item("TCMTPS").ToString()
                    objEntidad.TABTPS = .Item("TABTPS").ToString()
                    objEntidad.FULTAC = .Item("FULTAC").ToString()
                    objEntidad.HULTAC = .Item("HULTAC").ToString()
                    objEntidad.CULUSA = .Item("CULUSA").ToString()
                    objEntidad.NTRMNL = .Item("NTRMNL").ToString()
                    objEntidad.CUSCRT = .Item("CUSCRT").ToString()
                    objEntidad.FCHCRT = .Item("FCHCRT").ToString()
                    objEntidad.HRACRT = .Item("HRACRT").ToString()
                    objEntidad.NTRMCR = .Item("NTRMCR").ToString()
                End With
            End If
        Catch ex As Exception
        End Try
        Return objEntidad
    End Function

End Class
