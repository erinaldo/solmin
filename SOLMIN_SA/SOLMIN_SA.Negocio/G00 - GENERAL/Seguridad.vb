Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.SecurityAccess
Imports IBM.Data.DB2.iSeries
Imports System.IO

Namespace slnSOLMIN
    Public Class clsParametrosSeguridad
#Region " Atributos "
        Private strServidor As String = ""
        Private strBaseDatos As String = ""
        Private strDetalleBaseDatos As String = ""
        Private strTipoSistema As String = ""
        Private strDetalleTipoSistema As String = ""
        Private strIPConexion As String = ""
        Private strEsquema As String = ""
        Private strUsuario As String = ""
        Private strPassword As String = ""
        Private strSistema As String = ""
        Private strTipoAlmacen As String = ""
#End Region
#Region " Propiedades "
        Public Property pstrUsuario() As String
            Get
                Return strUsuario
            End Get
            Set(ByVal value As String)
                strUsuario = "" & value
            End Set
        End Property

        Public Property pstrPassword() As String
            Get
                Return strPassword
            End Get
            Set(ByVal value As String)
                strPassword = "" & value
            End Set
        End Property

        Public Property pstrServidor() As String
            Get
                Return strServidor
            End Get
            Set(ByVal value As String)
                strServidor = "" & value
            End Set
        End Property

        Public Property pstrBaseDatos() As String
            Get
                Return strBaseDatos
            End Get
            Set(ByVal value As String)
                strBaseDatos = "" & value
            End Set
        End Property

        Public Property pstrDetalleBaseDatos() As String
            Get
                Return strDetalleBaseDatos
            End Get
            Set(ByVal value As String)
                strDetalleBaseDatos = "" & value
            End Set
        End Property

        Public Property pstrTipoSistema() As String
            Get
                Return strTipoSistema
            End Get
            Set(ByVal value As String)
                strTipoSistema = value
            End Set
        End Property

        Public Property pstrDetalleTipoSistema() As String
            Get
                Return strDetalleTipoSistema
            End Get
            Set(ByVal value As String)
                strDetalleTipoSistema = value
            End Set
        End Property

        Public Property pstrIPConexion() As String
            Get
                Return strIPConexion
            End Get
            Set(ByVal value As String)
                strIPConexion = "" & value
            End Set
        End Property

        Public Property pstrEsquema() As String
            Get
                Return strEsquema
            End Get
            Set(ByVal value As String)
                strEsquema = "" & value
            End Set
        End Property

        Public Property pstrAplicativo() As String
            Get
                Return strSistema
            End Get
            Set(ByVal value As String)
                strSistema = "" & value
            End Set
        End Property

        Public Property pstrTipoAlmacen() As String
            Get
                Return strTipoAlmacen
            End Get
            Set(ByVal value As String)
                strTipoAlmacen = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsSeguridad
        Inherits clsBasicClass
        Implements IDisposable
#Region " Atributos "
        Private objParamSeguridad As clsParametrosSeguridad
        Private blnStatusConexion As Boolean = False
        Private pblnMyConnStr As Boolean = False
        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
        Private strMensajeConexion As String = ""
        Private strPCName As String = ""
        Private objOptionSecurity As OptionAccess
#End Region
#Region " Propiedades "
        Public ReadOnly Property pblnStatusConexion() As Boolean
            Get
                Return blnStatusConexion
            End Get
        End Property

        Public ReadOnly Property pUsuario() As String
            Get
                Return objParamSeguridad.pstrUsuario
            End Get
        End Property

        Public ReadOnly Property pstrPassword() As String
            Get
                Return objParamSeguridad.pstrPassword
            End Get
        End Property

        Public ReadOnly Property pCompania() As String
            Get
                Return objOptionSecurity.pCompania
            End Get
        End Property

        Public ReadOnly Property pDivision() As String
            Get
                Return objOptionSecurity.pDivision
            End Get
        End Property

        Public ReadOnly Property pstrServidor() As String
            Get
                Return objParamSeguridad.pstrServidor
            End Get
        End Property

        Public ReadOnly Property pdtPlanta() As DataTable
            Get
                Return objOptionSecurity.pPlantas
            End Get
        End Property

        Public ReadOnly Property pstrBaseDatos() As String
            Get
                Return objParamSeguridad.pstrBaseDatos
            End Get
        End Property

        Public ReadOnly Property pstrDetalleBaseDatos() As String
            Get
                Return objParamSeguridad.pstrDetalleBaseDatos
            End Get
        End Property

        Public ReadOnly Property pstrTipoSistema() As String
            Get
                Return objParamSeguridad.pstrTipoSistema
            End Get
        End Property

        Public ReadOnly Property pstrDetalleTipoSistema() As String
            Get
                Return objParamSeguridad.pstrDetalleTipoSistema
            End Get
        End Property

        Public ReadOnly Property pstrIPConexion() As String
            Get
                Return objParamSeguridad.pstrIPConexion
            End Get
        End Property

        Public ReadOnly Property pstrEsquema() As String
            Get
                Return objParamSeguridad.pstrEsquema
            End Get
        End Property

        Public ReadOnly Property pstrAplicativo() As String
            Get
                Return objParamSeguridad.pstrAplicativo
            End Get
        End Property

        Public ReadOnly Property pstrMensajeConexion() As String
            Get
                Return strMensajeConexion
            End Get
        End Property

        Public ReadOnly Property pstrPCName() As String
            Get
                Return strPCName
            End Get
        End Property

        Public ReadOnly Property pstrTipoAlmacen() As String
            Get
                Return objParamSeguridad.pstrTipoAlmacen
            End Get
        End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Metodos "
        Public Sub New(ByVal strTipoSistema As String, ByVal strDetalleTipoSistema As String, ByVal strTipoAlmacen As String, ByVal strNombrePC As String)
            ' Si existe el archivo de Conexion
            Dim objDBase_iSeries As New SqlManager
            Dim cnx As iDB2Connection
            Dim ConnStr As String = ""
            Try
                ConnStr = ConfigurationWizard.getConfigFile()
                'Estableciendo la autentificacion
                cnx = objDBase_iSeries.Conectar(ConnStr)
                cnx.Open()
                ' Obtenemos los parametros
                objParamSeguridad = New clsParametrosSeguridad
                With objParamSeguridad
                    .pstrAplicativo = "SA"
                    .pstrBaseDatos = cnx.Database
                    .pstrDetalleBaseDatos = "PRODUCCION"
                    .pstrIPConexion = cnx.DataSource
                    .pstrEsquema = cnx.DefaultCollection
                    .pstrPassword = cnx.Password
                    .pstrServidor = cnx.DataSource
                    .pstrUsuario = cnx.UserID
                    .pstrTipoSistema = strTipoSistema
                    .pstrDetalleTipoSistema = strDetalleTipoSistema
                    .pstrTipoAlmacen = strTipoAlmacen
                End With
                cnx.Close()
                strPCName = IIf(strNombrePC.ToString.Length > 10, strNombrePC.ToString.Substring(0, 10), strNombrePC)
                blnStatusConexion = True
                pblnMyConnStr = False
                ' Cargamos los permisos que tuviese el Usuario
                objOptionSecurity = New OptionAccess(objParamSeguridad.pstrAplicativo, objParamSeguridad.pstrUsuario)
                If objOptionSecurity.pMensajeError <> "" Then
                    strMensajeConexion = "Detalle: " & vbNewLine & objOptionSecurity.pMensajeError
                    blnStatusConexion = False
                End If
            Catch ex_sql As iDB2Exception
                strMensajeConexion = "Detalle: " & vbNewLine & ex_sql.Message
                blnStatusConexion = False
            Catch ex As Exception
                strMensajeConexion = "Detalle: " & vbNewLine & ex.Message
                blnStatusConexion = False
            End Try
        End Sub

        Public Sub New(ByVal objParametros As clsParametrosSeguridad, ByVal strNombrePC As String)
            ' si no existe el archivo de conexion
            Dim objDBase_iSeries As New SqlManager
            Dim cnx As iDB2Connection
            Dim ConnStr As String = ""
            ' obteniendo cadena de conexion
            With objParametros
                ConnStr = My.Settings.Item(.pstrServidor).ToString()
                ConnStr = ConnStr.Replace("UUUUUU", .pstrUsuario)
                ConnStr = ConnStr.Replace("PPPPPP", .pstrPassword)
            End With
            'Estableciendo la autentificacion
            Try
                cnx = objDBase_iSeries.Conectar(ConnStr)
                cnx.Open()
                cnx.Close()
                strPCName = IIf(strNombrePC.ToString.Length > 10, strNombrePC.ToString.Substring(0, 10), strNombrePC)
                blnStatusConexion = True
                ConfigurationWizard.WriteConfigFile(ConnStr)
                objParamSeguridad = objParametros
                strMensajeConexion = ""
                pblnMyConnStr = True
                ' Cargamos los permisos que tuviese el Usuario
                objOptionSecurity = New OptionAccess(objParamSeguridad.pstrAplicativo, objParamSeguridad.pstrUsuario)
                If objOptionSecurity.pMensajeError <> "" Then
                    strMensajeConexion = "Detalle: " & vbNewLine & objOptionSecurity.pMensajeError
                    blnStatusConexion = False
                End If
            Catch ex_sql As iDB2Exception
                strMensajeConexion = "Detalle: " & vbNewLine & ex_sql.Message
                blnStatusConexion = False
            Catch ex As Exception
                strMensajeConexion = "Detalle: " & vbNewLine & ex.Message
                blnStatusConexion = False
            End Try
        End Sub

        Public Shared Function fblnValidarAcceso(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String) As Boolean
            ' si no existe el archivo de conexion
            Dim objDBase_iSeries As New SqlManager
            Dim cnx As iDB2Connection
            Dim ConnStr As String = ""
            Dim blnStatusConexion As Boolean
            ' obteniendo cadena de conexion
            ConnStr = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            'Estableciendo la autentificacion
            Try
                cnx = objDBase_iSeries.Conectar(ConnStr)
                cnx.Open()
                cnx.Close()
                blnStatusConexion = True
            Catch ex_sql As iDB2Exception
                blnStatusConexion = False
            Catch ex As Exception
                blnStatusConexion = False
            End Try
            Return blnStatusConexion
        End Function

        Public Shared Function ConnectionFileExists() As Boolean
            Return ConfigurationWizard.ConnectionFileExists()
        End Function

        Public Shared Function LoginFileExists() As Boolean
            Return ConfigurationWizard.LoginFileExists()
        End Function

        Public Shared Function Usuario() As String
            Return ConfigurationWizard.UserName()
        End Function

        Public Shared Sub ConnectionFileDelete()
            ConfigurationWizard.DeleteConfig()
        End Sub

        Public Function fblnAccesoPorOpciones(ByVal OpcionMenu As String) As Boolean
            Return objOptionSecurity.fblnHasAccess(OpcionMenu)
        End Function

        Public Function fblnIsLocked(ByVal Cliente As Int64, ByVal FnVerificacion As String, ByRef Mensaje As String, Optional ByVal strCompania As String = "", Optional ByVal strDivision As String = "") As Boolean
            If ConfigurationWizard.Library() <> "DC@DESLIB" Then
                Return objOptionSecurity.fblnIsLocked(Cliente, FnVerificacion, Mensaje, strCompania, strDivision)
            Else
                Return False
            End If

        End Function

        Public Sub ChangeTypeSystem(ByVal strTipoSistema As String, ByVal strTipoAlmacen As String)
            With objParamSeguridad
                .pstrTipoSistema = strTipoSistema
                .pstrTipoAlmacen = strTipoAlmacen
            End With
        End Sub
#End Region
#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar recursos no administrados cuando se llamen explícitamente
                    If pblnMyConnStr Then
                        ' Si la cadena la generé, yo la elimino
                        ConfigurationWizard.DeleteConfig()
                    End If
                    objOptionSecurity.Dispose()
                    objOptionSecurity = Nothing
                End If
                ' TODO: Liberar recursos no administrados compartidos
            End If
            Me.disposedValue = True
        End Sub
        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace