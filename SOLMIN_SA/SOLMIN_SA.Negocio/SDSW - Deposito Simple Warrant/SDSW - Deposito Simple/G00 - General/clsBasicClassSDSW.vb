Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class TipoDato_ResultaReporteSDSW
#Region " Atributos "
    Dim rdocReporte As ReportDocument
    Dim lstDataSource As List(Of DataTable)
#End Region
#Region " Propiedades "
    Public Property pReporte() As ReportDocument
        Get
            Return rdocReporte
        End Get
        Set(ByVal value As ReportDocument)
            rdocReporte = value
        End Set
    End Property

    Public ReadOnly Property Tables() As List(Of DataTable)
        Get
            Return lstDataSource
        End Get
    End Property
#End Region
#Region " Métodos "
    Sub New()
        lstDataSource = New List(Of DataTable)
    End Sub

    Public Sub add_Table(ByVal dtTemp As DataTable)
        lstDataSource.Add(dtTemp)
    End Sub

    Public Sub del_Table(ByVal dtTemp As DataTable)
        lstDataSource.Remove(dtTemp)
    End Sub

    Public Sub add_Tables(ByVal dstTemp As DataSet)
        For Each dtTemp As DataTable In dstTemp.Tables
            lstDataSource.Add(dtTemp)
        Next
    End Sub

    Public Function count_tables() As Integer
        Return lstDataSource.Count
    End Function
#End Region
End Class

Public Class clsBasicClassSDSW
    '-----------------------------------------'
    ' La información es devuelta en DATATABLE '
    '-----------------------------------------'
    Protected Shared Function fblnSDSWExisteInformacion(ByRef strMensajeError As String, ByVal strTipoQuery As String, _
                                                    Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                    Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                    Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                    Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                    Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO", strTipoQuery)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            If Integer.TryParse(objSqlManager.ExecuteScalar("SP_SOLMIN_SDSW_GEN_EXISTS", objParametros), intCount) Then
                If intCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnSDSWExisteInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fblnSDSWExisteInformacionWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                      ByRef strMensajeError As String, ByVal strTipoQuery As String, _
                                                      Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                       Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                      Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                      Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                      Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As Boolean
        ' Método utilizado solo para consultas de moviles
        Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
        ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
        ConnStr = ConnStr.Replace("PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO", strTipoQuery)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            If Integer.TryParse(objSqlManager.ExecuteScalar("SP_SOLMIN_SDSW_GEN_EXISTS", objParametros), intCount) Then
                If intCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnSDSWExisteInformacionWS >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fblnSDSWInsertInformacion(ByRef strMensajeError As String, ByVal strTipoInsercion As String, _
                                                    Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                    Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                    Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                    Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                    Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO", strTipoInsercion)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_INSERT", objParametros)
            Return True
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnInsertInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Inserción : << " & strTipoInsercion & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fdtSDSWResultadoBusqueda(ByRef strMensajeError As String, ByVal strTipoBusqueda As String, _
                                                 Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                 Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                 Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                 Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                 Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO_FILTRO", strTipoBusqueda)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDSW_GEN_FILTROS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtSDSWResultadoBusqueda >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Búsqueda : << " & strTipoBusqueda & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fdtSDSWResultadoConsulta(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                   Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                   Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                   Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                   Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                   Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("TIPO_FILTRO", strTIPO_QUERY)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDSW_GEN_CONSULTAS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtSDSWResultadoConsulta >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fdtSDSWResultadoConsultaWrrnt(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                   Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                   Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                   Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                   Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                   Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("TIPO_FILTRO", strTIPO_QUERY)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)

        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDSW_GEN_CONSULTAS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtResultadoConsulta >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fdtSDSWResultadoConsultaWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                     ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                     Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                     Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                     Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                     Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                     Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
        ' Método utilizado solo para consultas de moviles
        Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
        ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
        ConnStr = ConnStr.Replace("PPPPPP", strPassword)
        Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("TIPO_FILTRO", strTIPO_QUERY)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDSW_GEN_CONSULTAS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtResultadoConsulta >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fblnSDSWUpdateInformacion(ByRef strMensajeError As String, ByVal strTipoUpdate As String, _
                                                    Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                    Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                    Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                    Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                    Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As Boolean
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim intCount As Integer = 0
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO", strTipoUpdate)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_UPDATE", objParametros)
            Return True
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnUpdateInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Actualización : << " & strTipoUpdate & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    '---------------------------------------'
    ' La información es devuelta en DATASET '
    '---------------------------------------'
    Protected Shared Function fdstSDSWResultadoConsulta(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                    Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                    Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                    Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                    Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                    Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("TIPO_FILTRO", strTIPO_QUERY)
        objParametros.Add("PARAM_001", strPar01)
        objParametros.Add("PARAM_002", strPar02)
        objParametros.Add("PARAM_003", strPar03)
        objParametros.Add("PARAM_004", strPar04)
        objParametros.Add("PARAM_005", strPar05)
        objParametros.Add("PARAM_006", strPar06)
        objParametros.Add("PARAM_007", strPar07)
        objParametros.Add("PARAM_008", strPar08)
        objParametros.Add("PARAM_009", strPar09)
        objParametros.Add("PARAM_010", strPar10)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SDSW_GEN_CONSULTAS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdstResultadoConsulta >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataSet
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function
End Class
