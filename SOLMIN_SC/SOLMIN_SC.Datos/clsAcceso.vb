Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Configuration


Public Class clsAcceso

#Region " Bloqueo de Clientes "
    Private Function fdtGetInfLocked(ByVal strCia As String, ByVal strDiv As String, ByVal Cliente As String, ByVal FnVerificacion As String, _
                                     Optional ByVal RefServ As String = "", Optional ByVal NroOpe As String = "", Optional ByVal Moneda As String = "", _
                                     Optional ByVal ImpSoles As Decimal = 0.0, Optional ByVal ImpDolares As Decimal = 0.0) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim strUsuario As String = ConfigurationWizard.UserName
        ' Parametros de Bloqueos Fijos
        Dim strReg As String = "R04"                ' Región de Venta
        Dim strTipoOper As String = "DM"            ' Tipo de Operación
        ' Iniciamos el proceso de verificación
        objSqlManager.TransactionController(TransactionType.Automatic)
        Try
            Dim strSQL As String = ""
            Dim dtTabla As DataTable

            strSQL = "Delete from RZHT71 WHERE CULUSA='" & strUsuario & "'"
            objSqlManager.ExecuteNoQuery(strSQL)

            strSQL = "Delete from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            objSqlManager.ExecuteNoQuery(strSQL)


            strSQL = "INSERT INTO RZHT71 VALUES ('" & strUsuario & "',1)"
            objSqlManager.ExecuteNoQuery(strSQL)

            strSQL = "insert into RZHT70 values ('" & strCia & "','" & strDiv & "','" & strReg & "'," & Cliente & ",'" & strTipoOper & "','" & _
                                                 FnVerificacion & "','" & RefServ & "','" & NroOpe & "','" & Moneda & "'," & ImpSoles & "," & _
                                                 ImpDolares & ",'','','','" & strUsuario & "',1)"
            objSqlManager.ExecuteNonQuery(strSQL)

            strSQL = "CALL SILEFCLP"
            objSqlManager.ExecuteNoQuery(strSQL)

            strSQL = "select SFLGB1,SFLGB2,MSGBLQ from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            dtTabla = objSqlManager.ExecuteDataTable(strSQL)

            strSQL = "Delete from RZHT71 WHERE CULUSA='" & strUsuario & "'"
            objSqlManager.ExecuteNoQuery(strSQL)

            strSQL = "Delete from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            objSqlManager.ExecuteNoQuery(strSQL)

            Return dtTabla
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Public Function fblnIsLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As Int64, _
                                 ByVal FnVerificacion As String, ByRef strMensaje As String) As Boolean
        Dim btnResultado As Boolean = False
        Dim lblMensaje1 As String = ""
        Dim lblMensaje2 As String = ""
        Dim dtTablaCL As DataTable

        dtTablaCL = fdtGetInfLocked(Compania, Division, Cliente, FnVerificacion)

        If dtTablaCL.Rows.Count > 0 Then
            lblMensaje1 = dtTablaCL.Rows(0).Item(0).ToString
            lblMensaje2 = dtTablaCL.Rows(0).Item(1).ToString
            strMensaje = dtTablaCL.Rows(0).Item(2).ToString
        End If
        If lblMensaje1 = "C" And lblMensaje2 = "B" Then btnResultado = True

        Return btnResultado
    End Function
#End Region

    Public Function Verifica_Archivo() As Boolean
        Return ConfigurationWizard.ConnectionFileExists()
    End Function

    Public Function Valida_Acceso(ByVal pstrUser As String, ByVal pstrPass As String) As Boolean
        Try
            'Verifica que el usuario tenga permiso para conectarse al AS-400
            Dim objDBase_iSeries As New SqlManager
            Dim ConnStr As String

            'Verificando el tipo de origen de datos,escoge el servidor
            ' a controlar la autentificación


            ConnStr = Configuration.ConfigurationSettings.AppSettings("DataBase").ToString()
            ' ConnStr = ConfigurationManager.AppSettings("DataBase").ToString()




            'reemplazando en la cadena, el usuario y password
            ConnStr = ConnStr.Replace("$USER", pstrUser)
            ConnStr = ConnStr.Replace("$PASS", pstrPass)

            'Estableciendo la autentificacion
            objDBase_iSeries.Conectar(ConnStr).Open()
            objDBase_iSeries.Conectar(ConnStr).Close()

            'Guardando cadena de conexión en archivo
            ConfigurationWizard.WriteConfigFile(ConnStr)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub Destruir()
        'Elimina todos los objetos creados en memoria
        ConfigurationWizard.DeleteConfig()
    End Sub

    Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As Entidad.beAcceso
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Dim objSql As New SqlManager
        Dim objEntidad As New Entidad.beAcceso
        Try
            objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
            objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
            objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))
            '  objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_ACCESO_OPCIONES_USUARIO", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad.STSVIS = objDataRow("STSVIS").ToString.Trim()
                objEntidad.STSADI = objDataRow("STSADI").ToString.Trim()
                objEntidad.STSCHG = objDataRow("STSCHG").ToString.Trim()
                objEntidad.STSELI = objDataRow("STSELI").ToString.Trim()
                objEntidad.STSOP1 = objDataRow("STSOP1").ToString.Trim()
                objEntidad.STSOP2 = objDataRow("STSOP2").ToString.Trim()
                objEntidad.STSOP3 = objDataRow("STSOP3").ToString.Trim()
            Next
            Return objEntidad
        Catch ex As Exception
            Return objEntidad
        End Try
    End Function

    Public Function getAppSetting(ByVal Nombre As String) As String
        Dim retorno As String = ""
        Try
            retorno = Configuration.ConfigurationSettings.AppSettings(Nombre)
            'retorno = ConfigurationManager.AppSettings(Nombre)
        Catch ex As Exception
            retorno = ""
        End Try
        Return retorno
    End Function


End Class
