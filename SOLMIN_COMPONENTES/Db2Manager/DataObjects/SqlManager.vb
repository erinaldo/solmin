
Imports IBM.Data.DB2.iSeries
Imports System.Data
Imports Microsoft.VisualBasic 
Imports System.Data.common

Namespace RansaData.iSeries.DataObjects
    ''' <summary>
    '''  Modified: Miguel Dagnino 20/10/2015
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SqlManager
        Implements IDisposable

        'Variable que establece la cadena de conexion
        Private BaseDatos As String
        'Cadena de Conexion establecida por el usuario
        Private CadenaConexion As String = ""
        'Variable que establece el tipo de control de transacción
        Private TipoControlTransaccion As TransactionType = TransactionType.Automatic
        'Objeto que Obtiene la conexión para todas las transacciones
        'siempre y cuando sea del tipo de control de transacción manual
        Private objGlobalConnection As iDB2Connection
        'Objeto que Establece el punto de control de transacción global
        'para todas las transacciones
        Private objGlobalTransaction As iDB2Transaction
        'Variable que establece el tiempo de respuesta (Por defecto 60 está a segundos)
        Private _TiempoRespuesta As Integer = 3900 '900
        'Objeto Conexion Unico por toda la Clase
        Private objConneccion As New iDB2Connection
        'Objeto que retendra la coleccion de los ultimos parametros utilizados en un stored procedure
        Private ObjParameterCollection As New Hashtable
        'variable que tiene el catalogo o schema por defecto o al que apunte en tiempo de
        'ejecucion
        Private _defaultSchema As String = ""


        ''' <summary>
        ''' Clase que facilita el acceso a datos para iSeries DB2 AS400.
        ''' Posee 5 Funciones y 2 Procedimientos, cada uno con sobrecarga de parametros.
        ''' Indique la llave o clave del archivo de configuracion app.config
        ''' </summary>

        Sub New(ByVal ConfigKey As String)
            CadenaConexion = ConfigKey
        End Sub

        ''' <summary>
        ''' Clase que facilita el acceso a datos para iSeries DB2 AS400.
        ''' Posee 5 Funciones y 2 Procedimientos, cada uno con sobrecarga de parametros.
        ''' Este tipo de inicialización leerá el archivo de configuracion
        ''' </summary>

        Sub New()
            'Default config (por defecto, infomado en la documentación)
            BaseDatos = "DataBase"

        End Sub

        ''' <summary>
        '''  Propiedad que establece el tipo de control de transacción.
        ''' Puede ser: Automatica ->El Procedimiento se encarga de establecer el Begin, commit o rollback  .
        '' 	Manual -> el programador tiene que establecer el begin, Commit y RollBack de toda la conexion.
        ''' </summary>

        Public Sub TransactionController(ByVal Value As TransactionType)
            TipoControlTransaccion = Value
        End Sub


        Public Property TiempoRespuesta() As Integer
            Get
                Return _TiempoRespuesta
            End Get
            Set(ByVal value As Integer)
                _TiempoRespuesta = value
            End Set
        End Property


        Public Property Transaction_Controller() As TransactionType
            Get
                Return TipoControlTransaccion
            End Get
            Set(ByVal value As TransactionType)
                TipoControlTransaccion = value
            End Set
        End Property

        Public ReadOnly Property ParameterCollection() As Hashtable
            Get
                'Procedimiento que lista la coleccion de parametros del stored procedures
                Return ObjParameterCollection
            End Get
        End Property

        ''' <summary>
        '''  Procedimiento que Inicia el control de transacción e instancia la conexion al servidor
        ''' </summary>

        Public Sub BeginGlobalTransaction()
            Try
                Me.objGlobalConnection = New iDB2Connection(Me.Conectar())
                objGlobalConnection.Open()
                Me.objGlobalTransaction = Me.objGlobalConnection.BeginTransaction(IsolationLevel.Chaos)

            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
        End Sub

        ''' <summary>
        '''  Procedimiento que Confirma el control de transacción y cierra la conexion
        ''' </summary>

        Public Sub CommitGlobalTransaction()
            Try
                Me.objGlobalTransaction.Commit()
                Me.objGlobalConnection.Close()
                objGlobalConnection.Dispose()

            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
        End Sub

        ''' <summary>
        '''  Procedimiento que Restaura el control de transacción y cierra la conexion
        ''' </summary>

        Public Sub RollBackGlobalTransaction()
            Try
                Me.objGlobalTransaction.Rollback()
                Me.objGlobalConnection.Close()
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
        End Sub


        Public Function ExecuteDataSet(ByVal StoreProcedure As String, ByVal idb2params As Parameter) As DataSet

            Dim objData As New DataSet
            Dim objTransaction As iDB2Transaction

            Try

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmdAdaptador As iDB2DataAdapter
                    Dim cmd As New iDB2Command

                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = StoreProcedure
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    Dim i As Integer
                    Dim idb2Parametro As iDB2Parameter

                    If Not (idb2params Is Nothing) Then
                        For i = 1 To idb2params.Count
                            ' idb2Parametro = CType(idb2params.Item(i), idb2Parameter)
                            cmd.Parameters.Add(CType(idb2params.Item(i), iDB2Parameter))
                        Next
                    End If

                    'Verificando el tipo de control de transacción

                    cnx.Open()

                    cmdAdaptador = New iDB2DataAdapter(cmd)
                    cmdAdaptador.Fill(objData)
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    idb2Parametro = Nothing
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objData

        End Function

        ''' <summary>
        '''  Función que devuelve un DataSet en base a una cadena idb2
        ''' </summary>

        Public Function ExecuteDataSet(ByVal Query As String) As DataSet

            Dim objData As New DataSet
            Dim objTransaction As iDB2Transaction

            Try

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmdAdaptador As iDB2DataAdapter
                    Dim cmd As New iDB2Command

                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Query
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    cnx.Open()

                    cmdAdaptador = New iDB2DataAdapter(cmd)

                    cmdAdaptador.Fill(objData)
                    cnx.Close()
                    cmd.Dispose()
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objData

        End Function

        ''' <summary>
        '''  Procedimiento que ejecuta una instrucción idb2 en base a un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>

        Public Sub ExecuteNonQuery(ByVal StoreProcedure As String, ByVal idb2params As Parameter)




            Dim objResultado As String = ""
            Dim objTransaction As iDB2Transaction

            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = StoreProcedure
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    Dim i As Integer
                    Dim idb2Parametro As iDB2Parameter
                    Dim s As String = ""
                    If Not (idb2params Is Nothing) Then
                        For i = 1 To idb2params.Count
                            'idb2Parametro = CType(idb2params.Item(i), idb2Parameter)
                            'cmd.Parameters.Add(idb2Parametro.ParameterName, idb2Parametro.Value)
                            cmd.Parameters.Add(CType(idb2params.Item(i), iDB2Parameter))
                            s = s & "'" & idb2params.Item(i).Value & "',"
                        Next
                    End If

                    cnx.Open()

                    cmd.ExecuteNonQuery()
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    idb2Parametro = Nothing
                    cmd = Nothing

                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing

        End Sub

        ''' <summary>
        '''  Procedimiento que ejecuta una instrucción idb2 en base a un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>

        Public Sub ExecuteNonQuery(ByVal Query As String)

            Dim objResultado As String = ""

            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Query
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    cnx.Open()

                    cmd.ExecuteNonQuery()

                    cnx.Close()
                    cmd.Dispose()
                    cmd = Nothing

                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

        End Sub

        ''' <summary>
        '''  Función que puede devolver (opcional) un objeto, (confirmación de operación)
        '''  en base a un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>

        Public Function ExecuteNoQuery(ByVal StoreProcedure As String, ByVal idb2params As Parameter) As String


            Dim objResultado As String = ""
            Dim objTransaction As iDB2Transaction
            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = StoreProcedure
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    Dim i As Integer
                    Dim idb2Parametro As iDB2Parameter

                    If Not (idb2params Is Nothing) Then
                        For i = 1 To idb2params.Count
                            'idb2Parametro = CType(idb2params.Item(i), idb2Parameter)
                            cmd.Parameters.Add(CType(idb2params.Item(i), iDB2Parameter))
                        Next
                    End If

                    cnx.Open()

                    objResultado = cmd.ExecuteScalar()
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    idb2Parametro = Nothing
                    cmd = Nothing
                End Using


            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objResultado

        End Function

        ''' <summary>
        '''  Función que puede devolver (opcional) un objeto, (confirmación de operación)
        '''  en base a una instrucción idb2
        ''' </summary>

        Public Function ExecuteNoQuery(ByVal Query As String) As String
            Dim objResultado As String = ""
            Dim objTransaction As iDB2Transaction
            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Query
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    If Me.TipoControlTransaccion = TransactionType.Automatic Then
                        cnx.Open()
                        objTransaction = cnx.BeginTransaction(IsolationLevel.RepeatableRead)
                        cmd.Transaction = objTransaction
                    Else
                        cmd.Transaction = Me.objGlobalTransaction
                    End If

                    objResultado = cmd.ExecuteScalar()
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())

            End Try
            objTransaction = Nothing
            Return objResultado

        End Function

        ''' <summary>
        '''  Función que devuelve un único resultado 
        '''  en base a un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>

        Public Function ExecuteScalar(ByVal StoreProcedure As String, ByVal idb2params As Parameter) As String
            Dim objResultado As String = ""

            Dim objTransaction As iDB2Transaction
            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = StoreProcedure
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    Dim i As Integer
                    Dim idb2Parametro As iDB2Parameter

                    If Not (idb2params Is Nothing) Then
                        For i = 1 To idb2params.Count
                            ' idb2Parametro = CType(idb2params.Item(i), idb2Parameter)
                            cmd.Parameters.Add(CType(idb2params.Item(i), iDB2Parameter))
                        Next
                    End If

                    cnx.Open()

                    objResultado = cmd.ExecuteScalar().ToString()
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    idb2Parametro = Nothing
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objResultado
        End Function

        ''' <summary>
        '''  Función que devuelve un único resultado 
        '''  en base a una instucción idb2
        ''' </summary>

        Public Function ExecuteScalar(ByVal Query As String) As String
            Dim objResultado As String = ""
            Dim objTransaction As iDB2Transaction
            Try
                'Obteniendo una conexion a la base de datos

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmd As New iDB2Command
                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Query
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    cnx.Open()

                    objResultado = cmd.ExecuteScalar().ToString()

                    cnx.Close()
                    cmd.Dispose()
                    cmd = Nothing

                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objResultado

        End Function

        ''' <summary>
        '''  Función que devuelve una Lista de objetos dependiento de la clase que se envia utilizando
        '''   un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>
        Public Function getStatement(Of t)(ByVal storedProcedure As String, Optional ByVal idb2Params As Parameter = Nothing) As List(Of t)

            Dim objList As New List(Of t)

            Using cnx As New iDB2Connection(Me.Conectar)
                Dim cmd As New iDB2Command()

                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = storedProcedure
                cmd.Connection = cnx
                cmd.CommandTimeout = Me.TimeOutCommand

                Dim i As Integer
                Dim idb2Parametro As iDB2Parameter

                If Not (idb2Params Is Nothing) Then
                    For i = 1 To idb2Params.Count
                        cmd.Parameters.Add(CType(idb2Params.Item(i), iDB2Parameter))
                    Next
                End If

                cmd.Connection.Open()

                Dim objDataReader As iDB2DataReader = cmd.ExecuteReader()

                If objDataReader.HasRows = True Then
                    While objDataReader.Read()
                        Dim objBaseObject As t = Activator.CreateInstance(Of t)()

                        For Each objProp As Reflection.PropertyInfo In objBaseObject.GetType.GetProperties
                            Try
                                'verifica si el dato existe dentro de la coleccion de propiedades
                                Dim lbool_existe As Boolean = False
                                For i_existe As UInt16 = 0 To objDataReader.FieldCount - 1
                                    If objDataReader.GetName(i_existe) = objProp.Name Then
                                        lbool_existe = True
                                    End If
                                Next

                                If lbool_existe = True Then
                                    If objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name)) Is DBNull.Value Then
                                        objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Nothing, Nothing)
                                    Else

                                        Dim typename As String = String.Format("{0}.{1}", objBaseObject.GetType.GetProperty(objProp.Name).PropertyType.Namespace, objBaseObject.GetType.GetProperty(objProp.Name).PropertyType.Name)
                                        Dim member_typecode As TypeCode = Type.GetTypeCode(Type.GetType(typename))

                                        If member_typecode = TypeCode.Boolean Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToBoolean(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.DateTime Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToDateTime(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Decimal Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToDecimal(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Double Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToDouble(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Int16 Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToInt16(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Int32 Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToInt32(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Int64 Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToInt64(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.Single Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToSingle(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        ElseIf member_typecode = TypeCode.String Then
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, Convert.ToString(objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name))), Nothing)
                                        Else 'Object
                                            objBaseObject.GetType.GetProperty(objProp.Name).SetValue(objBaseObject, objDataReader.GetValue(objDataReader.GetOrdinal(objProp.Name)), Nothing)
                                        End If


                                    End If
                                End If
                            Catch ex As Exception
                                Throw New Exception(String.Format("{0} : {1} {2}", ex.ToString, ex.Message, ex.StackTrace))
                            End Try
                        Next
                        objList.Add(objBaseObject)
                    End While
                End If

                cnx.Close()
                cmd.Dispose()
            End Using

            Return objList
        End Function

        ''' <summary>
        '''  Función que devuelve un DataTable 
        '''  en base a un stored procedure [StoredPocedure param] y
        '''  un objeto (tipo colección) de parametros
        ''' </summary>

        Public Function ExecuteDataTable(ByVal StoreProcedure As String, ByVal idb2params As Parameter) As DataTable

            Dim objData As New DataSet
            Dim objTransaction As iDB2Transaction

            Try

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmdAdaptador As iDB2DataAdapter
                    Dim cmd As New iDB2Command

                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = StoreProcedure
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    Dim i As Integer
                    Dim idb2Parametro As iDB2Parameter

                    If Not (idb2params Is Nothing) Then
                        For i = 1 To idb2params.Count
                            '  idb2Parametro = CType(idb2params.Item(i), idb2Parameter)
                            cmd.Parameters.Add(CType(idb2params.Item(i), iDB2Parameter))
                        Next
                    End If

                    cmdAdaptador = New iDB2DataAdapter(cmd)

                    cnx.Open()

                    cmdAdaptador.Fill(objData)
                    fillParameterCollection(cmd.Parameters)

                    cnx.Close()
                    cmd.Dispose()
                    cnx.Dispose()
                    idb2Parametro = Nothing
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            If objData.Tables.Count > 0 Then
                Return objData.Tables(0).Copy()
            Else
                Return Nothing
            End If
        End Function

        ''' <summary>
        '''  Función que devuelve un único resultado 
        '''  en base a una instucción idb2
        ''' </summary>

        Public Function ExecuteDataTable(ByVal Query As String) As DataTable
            Dim objData As New DataSet
            Dim objTransaction As iDB2Transaction

            Try

                Using cnx As New iDB2Connection(Me.Conectar())

                    Dim cmdAdaptador As iDB2DataAdapter
                    Dim cmd As New iDB2Command

                    cmd.Connection = cnx
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Query
                    cmd.CommandTimeout = Me.TiempoRespuesta

                    cmdAdaptador = New iDB2DataAdapter(cmd)

                    cnx.Open()

                    cmdAdaptador.Fill(objData)

                    cnx.Close()
                    cmd.Dispose()
                    cmd = Nothing
                End Using

            Catch ex As Exception

                Throw New Exception(ex.ToString())
            End Try

            objTransaction = Nothing
            Return objData.Tables(0).Copy()
        End Function



        Private Sub fillParameterCollection(ByVal objCmdParams As iDB2ParameterCollection)

            ObjParameterCollection.Clear()

            For i As Integer = 0 To objCmdParams.Count - 1
                If objCmdParams(i).Direction = ParameterDirection.Output Or objCmdParams(i).Direction = ParameterDirection.InputOutput Then
                    ObjParameterCollection.Add(objCmdParams(i).ParameterName, objCmdParams(i).Value)
                End If
            Next

        End Sub

        Public Function Conectar() As String

            Dim ConnStr As String = ""
            Try

                If CadenaConexion = "" Then
                    ConnStr = Configuration.ConfigurationSettings.AppSettings(BaseDatos)
                Else
                    ConnStr = CadenaConexion
                End If

                Try
                    If System.Web.HttpContext.Current.Session("DataBase") IsNot Nothing Then
                        ConnStr = System.Web.HttpContext.Current.Session("DataBase").ToString()
                        If Me._defaultSchema <> "" Then 'si tiene default catalog modificado cambia
                            ConnStr = ConfigurationWizard.ReplaceSchema(Me._defaultSchema, ConnStr)
                        End If

                    End If
                    If System.Web.HttpContext.Current.Session("DataBaseP") IsNot Nothing Then
                        ConnStr = System.Web.HttpContext.Current.Session("DataBaseP").ToString()
                        If Me._defaultSchema <> "" Then 'si tiene default catalog modificado cambia
                            ConnStr = ConfigurationWizard.ReplaceSchema(Me._defaultSchema, ConnStr)
                        End If
                    End If
                   
                Catch : End Try

                'verificando si el archivo de conexion está
                'establecido
                If CadenaConexion.Equals("") = True And ConfigurationWizard.ConnectionFileExists() = True Then
                    ConnStr = ConfigurationWizard.getConfigFile()
                    If Me._defaultSchema <> "" Then 'si tiene default catalog modificado cambia
                        ConnStr = ConfigurationWizard.ReplaceSchema(Me._defaultSchema)
                    End If
                End If

         



            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
            'Devolviendo la cadena de Conexion a la Base de Datos
            Return ConnStr

        End Function

        Public Function Conectar(ByVal ConnStr As String) As iDB2Connection

            Dim cnx As iDB2Connection = Nothing
            Try
                cnx = New iDB2Connection(ConnStr)
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
            'Devolviendo la cadena de Conexion a la Base de Datos
            Return cnx

        End Function

        Public Function IConectar(ByVal ConnStr As String) As IDbConnection

            Dim cnx As iDB2Connection = Nothing
            Try
                cnx = New iDB2Connection(ConnStr)
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
            'Devolviendo la cadena de Conexion a la Base de Datos
            Return DirectCast(cnx, IDbConnection)

        End Function

        ''' <summary>
        ''' Funcion para obtener si un usuario tiene o no acceso al AS-400
        ''' </summary>
        Public Property DefaultSchema() As String
            Get
                Return _defaultSchema
            End Get
            Set(ByVal value As String)
                _defaultSchema = value
            End Set
        End Property

        ''' <summary>
        ''' Funcion para obtener si un usuario tiene o no acceso al AS-400
        ''' </summary>
        Public Function Probar_Conexion(ByVal ConnStr As String) As Boolean
            Dim cnx As iDB2Connection = Nothing
            Dim resultado As Boolean = False
            Try
                cnx = New iDB2Connection(ConnStr)
                cnx.Open()
                resultado = True
                cnx.Close()
                cnx.Dispose()
                Try
                    System.Web.HttpContext.Current.Session("ses") = "ENABLED"
                Catch ex As Exception

                End Try
            Catch ex As Exception

                resultado = False
            End Try
            'Devolviendo la cadena de Conexion a la Base de Datos
            Return resultado
        End Function

        ''' <summary>
        ''' Propiedad para establecer el tiempo de respuesta de un comando IDB2
        ''' </summary>
        Public Property TimeOutCommand() As Integer
            Get
                Return Me.TiempoRespuesta
            End Get
            Set(ByVal value As Integer)
                Me.TiempoRespuesta = value
            End Set
        End Property

        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    Me.Dispose()
                End If
                ' TODO: Liberar recursos no administrados compartidos
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support "
        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            'Dispose(True)
            Try
                If Me.Transaction_Controller = TransactionType.Manual Then
                    objGlobalConnection.Close()
                    objGlobalTransaction.Dispose()
                    objGlobalConnection.Dispose()
                End If

                GC.SuppressFinalize(Me)
            Catch : End Try
        End Sub
#End Region

        Public ReadOnly Property NombreEnsamblado() As String
            Get
                Return My.Application.Info.AssemblyName
            End Get
        End Property

    End Class

End Namespace
