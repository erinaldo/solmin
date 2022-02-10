Imports RANSA.DATA
Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class TipoDato_ResultaReporte
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

Public Class clsBasicClass
    '-----------------------------------------'
    ' La información es devuelta en DATATABLE '
    '-----------------------------------------'
    Protected Shared Function fblnExisteInformacion(ByRef strMensajeError As String, ByVal strTipoQuery As String, _
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
            If Integer.TryParse(objSqlManager.ExecuteScalar("SP_SOLMIN_SA_GEN_EXISTS", objParametros), intCount) Then
                If intCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnExisteInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fblnExisteInformacionWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
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
            If Integer.TryParse(objSqlManager.ExecuteScalar("SP_SOLMIN_SA_GEN_EXISTS", objParametros), intCount) Then
                If intCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnExisteInformacion >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fblnInsertInformacion(ByRef strMensajeError As String, ByVal strTipoInsercion As String, _
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
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INSERT", objParametros)
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

    Protected Shared Function fdtResultadoBusqueda(ByRef strMensajeError As String, ByVal strTipoBusqueda As String, _
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
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GEN_FILTROS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtResultadoBusqueda >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Búsqueda : << " & strTipoBusqueda & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function


    Protected Shared Function fdtLista_TipoBulto(abrTipoBulto As String) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Dim dt As New DataTable
        objParametros.Add("PSTABRUN", abrTipoBulto)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LITAR_TIPO_BULTO", objParametros)
        Return dt
        
    End Function


    Protected Shared Function fdtResultadoConsulta(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
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
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GEN_CONSULTAS1", objParametros)
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

    Protected Shared Function fdtResultadoConsultaWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
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
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GEN_CONSULTAS", objParametros)
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

    Protected Shared Function fblnUpdateInformacion(ByRef strMensajeError As String, ByVal strTipoUpdate As String, _
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
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_UPDATE", objParametros)
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

    '-------------------------------SE AGREGO-----------------------------------------------------------------------
    Protected Shared Function fdtResultadoConsultaGuia(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                       Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "") As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_CCLNT", strPar01)
        objParametros.Add("IN_NGUIRM", strPar02)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_MERCADERIA_GUIA_RZOL66_R01", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtResultadoConsultaGuia >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Protected Shared Function fdtResultadoConsultaGuia_Info_Adicional(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
                                                       Optional ByVal strPar01 As String = "") As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_NORDSR", strPar01)
        Try
            strMensajeError = ""
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_INFO_MERCADERIA_GUIA_RZOL66_R01", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fdtResultadoConsultaGuia_Info_Adicional >> de la clase << clsBasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTIPO_QUERY & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    '---------------------------------------'
    ' La información es devuelta en DATASET '
    '---------------------------------------'
    Protected Shared Function fdstResultadoConsulta(ByRef strMensajeError As String, ByVal strTIPO_QUERY As String, _
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
            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_GEN_CONSULTAS", objParametros)
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

    Public Function fdsCodigoClienteDelPortar(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strCliente As String) As Double
        Dim odaBasicClass As New BasicClass
        Return odaBasicClass.fdsCodigoClienteDelPortar(objSqlManager, strMensajeError, strCliente)
    End Function
    Public Function ABB_Puede_ImportarOC(ByVal CCLNT As Int64) As Boolean
        Dim odaBasicClass As New BasicClass
        Return odaBasicClass.ABB_Puede_ImportarOC(CCLNT)
    End Function
    'daOrdenCompra
End Class
