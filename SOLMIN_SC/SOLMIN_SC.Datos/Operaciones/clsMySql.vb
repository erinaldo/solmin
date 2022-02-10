Imports MySql.Data.MySqlClient

Public Class clsMySql

    Public Function Listar_Partida_ASCINSA(ByVal pstrAnho As String, ByVal pstrOrden As String) As DataTable
        Dim MySqlConexion As MySqlConnection
        Dim MySqlAdapter As MySqlDataAdapter
        Dim strSql As String = ""
        Dim oDt As New DataTable

        MySqlConexion = Conexion()
        strSql = "        SELECT CONCAT(DETDUA.ANO_PRESE,  TRIM(DETDUA.NUME_ORDEN)) AS ORDEN_SERVICIO,"
        strSql = strSql & "      DETDUA.CODI_ADUAN,"
        strSql = strSql & "      DETDUA.NUME_SERIE,"
        strSql = strSql & "      DETDUA.NUME_FACTU,"
        strSql = strSql & "      DETDUA.CODI_ITEM,"
        strSql = strSql & "      DETDUA.ORD_COMPRA,"
        strSql = strSql & "      DETDUA.ITEM_OC,"
        strSql = strSql & "      IFNULL(DETTPN.TRAT_PREFE,' ') AS TRAT_PREFE"
        strSql = strSql & " FROM ADU008 DETDUA,"
        strSql = strSql & "      ADU006 DETTPN "
        strSql = strSql & "WHERE DETDUA.ANO_PRESE = '" & pstrAnho & "'"
        strSql = strSql & "  AND DETDUA.NUME_ORDEN = '" & pstrOrden.PadLeft(6, "0") & "'"
        strSql = strSql & "  AND DETTPN.ANO_PRESE = DETDUA.ANO_PRESE"
        strSql = strSql & "  AND DETTPN.NUME_ORDEN = DETDUA.NUME_ORDEN"
        strSql = strSql & "  AND DETDUA.NUME_SERIE = DETTPN.NUME_SERIE"
        strSql = strSql & "  AND DETDUA.CODI_REGI = DETTPN.CODI_REGI"
        strSql = strSql & "  AND DETDUA.CODI_ADUAN = DETTPN.CODI_ADUAN"
        strSql = strSql & "  AND DETDUA.ORD_COMPRA <> ''"

        MySqlAdapter = New MySqlDataAdapter(strSql, MySqlConexion)
        MySqlAdapter.Fill(oDt)
        MySqlConexion.Close()

        Return oDt
    End Function

    Private Function Conexion() As MySqlConnection
        Dim myConnString As String
        Dim enlace As MySqlConnection

        myConnString = "database=ADUANAS;Data source=RANCALASC2;User Id=sa;Password=rbt86572a;default command timeout=0 "
        enlace = New MySqlConnection(myConnString)
        enlace.Open()

        Return enlace
    End Function

End Class
