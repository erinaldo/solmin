Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports SOLMIN_CTZ.Entidades

Public Class TipoSubServicioTransporte_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Listar_Tipo_SubServicio(ByVal objEntidad As TipoServicioTransporte) As DataTable
        Dim objResultado As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SUB_SERVICIO", objParam)
        Catch ex As Exception
        End Try
        Return objResultado
    End Function

    Public Function Obtener_TipoSubServicio(ByVal objEntidad As TipoSubServicioTransporte) As TipoSubServicioTransporte
        Try
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
            objParam.Add("PARAM_CTPSBS", objEntidad.CTPSBS)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_DATOS_SUB_SERVICIO", objParam)
            If objDataTable.Rows.Count > 0 Then
                With objDataTable.Rows(0)

                    objEntidad.CTPOSR = .Item("CTPOSR").ToString()
                    objEntidad.CTPSBS = .Item("CTPSBS").ToString()
                    objEntidad.TCMSBS = .Item("TCMSBS").ToString()
                    objEntidad.TABSBS = .Item("TABSBS").ToString()
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
