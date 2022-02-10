Imports MySql.Data.MySqlClient
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Diagnostics
Imports System.Configuration


Public Class MigracionAgencias_DAL

    Dim objSql As SqlManager

    Sub New()
        objSql = New SqlManager()
    End Sub

    Public Function Obtener_Orden_Servicio(ByVal objParametros As List(Of String)) As DataTable
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NORDSR", objParametros(0))
            objParam.Add("PARAM_CZNFCC", objParametros(1))
            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SC_OBTENER_OS_MIGRACION_AGENCIA", objParam)
        Catch ex As Exception
        End Try
        Return objDatatable
    End Function

    Public Function Actualizar_Informacion_Agencias(ByVal objParametros As List(Of String))

        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_NMRODC", objParametros(0))
            objParam.Add("PARAM_NMITOC", objParametros(1))
            objParam.Add("PARAM_NMRFCT", objParametros(2))
            objParam.Add("PARAM_NMITFC", objParametros(3))
            objParam.Add("PARAM_NORDSR", objParametros(4))
            objParam.Add("PARAM_CZNFCC", objParametros(5))
            objParam.Add("PARAM_NSERIE", objParametros(6))
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_INFO_ADUANA_MIGRACION_AGENCIA", objParam)
        Catch ex As Exception
        End Try
    End Function

    Public Function Obtener_Zona_Migracion(ByVal objParametros As List(Of String)) As DataTable
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_PNCDIN", objParametros(0)) 
            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SC_OBTENER_ZONA_MIGRACION", objParam)
        Catch ex As Exception
        End Try
        Return objDatatable
    End Function

    Public Function Listar_Ordenes_Proceso_Migracion(ByVal Anio As Int32) As DataTable


        Dim lstr_MySqlStatement As String

        'Cadena de Instruccion al motor InnoDB
        lstr_MySqlStatement = "SELECT CONCAT(ANO_PRESE, SUBSTR(NUME_ORDEN, 2, 5)) AS ORDEN_SERVICIO, " & _
                       "       CODI_ADUAN, NUME_SERIE, NUME_FACTU, CODI_ITEM, ORD_COMPRA,   " & _
                       "       ITEM_OC, CONCAT(ANO_PRESE, SUBSTR(NUME_ORDEN, 1, 6)) " & _
                       "FROM ADU008 " & _
                       "WHERE ANO_PRESE = " & Anio & " " & _
                       "  AND ORD_COMPRA <> '' " & _
                       " ORDER BY ORDEN_SERVICIO "

        'Dim dtbDatosMySql As New DataTable

        Return getMySqlDataTable(lstr_MySqlStatement)

    End Function
    Public Function Listar_CostoIntegracion(ByVal nCliente As Int32, ByVal sOrdenConpra As String) As DataTable


        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", nCliente)
            objParam.Add("PSNORCML", sOrdenConpra)
            objDatatable = objSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTO_X_ITEM_OC_DATOS_COMPRACION", objParam)
            'objDatatable = objSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTO_X_ITEM_OC_DATOS_COMPRACION_PREEMBARQUE", objParam)
        Catch ex As Exception
        End Try
        Return objDatatable

    End Function



    Public Function getMySqlDataTable(ByVal Query As String) As DataTable
        Dim objData As New DataSet

        Try

            Dim cnx As MySqlConnection = New MySqlConnection(Configuration.ConfigurationSettings.AppSettings("MySqlDataBase"))

            Dim cmdAdaptador As MySqlDataAdapter
            Dim cmd As New MySqlCommand

            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Query
            cmd.CommandTimeout = 12000

            cmdAdaptador = New MySqlDataAdapter(cmd)

            cnx.Open()

            cmdAdaptador.Fill(objData)

        Catch ex As Exception
            Throw New Exception(ex.ToString())
        End Try

        Return objData.Tables(0).Copy()
    End Function


End Class
