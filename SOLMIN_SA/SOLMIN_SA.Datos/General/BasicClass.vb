Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Configuration
Public Class BasicClass
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    
#End Region
    '-----------------------------------------'
    ' La información es devuelta en DATATABLE '
    '-----------------------------------------'
    Protected Shared Function fblnExiste_Informacion(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strTipoQuery As String, _
                                                     Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                     Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                     Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                     Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                     Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As Boolean
        Dim objParametros As Parameter = New Parameter
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

        Dim blnResultado As Boolean = True
        Dim intCount As Integer = 0
        Try
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
            strMensajeError = "Error producido en la funcion : << fblnExisteInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function

    Protected Shared Function fdtBusqueda_Informacion(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strTipoBusqueda As String, _
                                                      Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                      Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                      Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                      Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                      Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
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

        Dim dtTemp As DataTable
        Try
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GEN_FILTROS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnBusquedaInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Búsqueda : << " & strTipoBusqueda & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            dtTemp = New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    Protected Shared Function fdtConsulta_Informacion(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strTipoQuery As String, _
                                                      Optional ByVal strPar01 As String = "", Optional ByVal strPar02 As String = "", _
                                                      Optional ByVal strPar03 As String = "", Optional ByVal strPar04 As String = "", _
                                                      Optional ByVal strPar05 As String = "", Optional ByVal strPar06 As String = "", _
                                                      Optional ByVal strPar07 As String = "", Optional ByVal strPar08 As String = "", _
                                                      Optional ByVal strPar09 As String = "", Optional ByVal strPar10 As String = "") As DataTable
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("iSTR_TIPO_FILTRO", strTipoQuery)
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

        Dim dtTemp As DataTable
        Try
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GEN_CONSULTAS", objParametros)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnConsultaInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Consulta : << " & strTipoQuery & " >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            dtTemp = New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    Public Function fdsCodigoClienteDelPortar(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strCliente As String) As Double

        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_CCLNT", strCliente)
        objParametros.Add("IN_VALVAR", "", ParameterDirection.Output)
        Dim blnResultado As Double = 0
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_CODIGO_CLIENTE_DEL_PORTAL", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            If Not htResultado("IN_VALVAR").ToString.Trim.Equals("") Then
                blnResultado = htResultado("IN_VALVAR")
            End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << fblnExisteInformacion >> de la clase << BasicClass >> " & vbNewLine & _
                              "Tipo de Consulta EXISTS : <<  SP_SOLMIN_CODIGO_CLIENTE_DEL_PORTAL >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
            blnResultado = 0
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return blnResultado
    End Function
    Public Function ABB_Puede_ImportarOC(ByVal CCLNT As Int64) As Boolean
        Dim encontrado As Boolean = False
        Try
            Dim Lista As String = ""
            Lista = ConfigurationManager.AppSettings("IO_IMPORTAR_OC")
            Dim ListaClienteConPermisos As String()
            ListaClienteConPermisos = Lista.Split(New Char() {"/"c})
            For Each str As String In ListaClienteConPermisos
                If (CCLNT = Convert.ToInt64(str)) Then
                    encontrado = True
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
        Return encontrado
    End Function
   
    '.Add("OU_MSGERR", "", ParameterDirection.Output)
    '    End With
    '    Try
    '        strMensajeError = ""
    '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_OC_RZOL38_DEL", objParametros)
    'Dim htResultado As Hashtable
    '        htResultado = objSqlManager.ParameterCollection
    '        strMensajeError = htResultado("OU_MSGERR")
    '        If strMensajeError <> "" Then blnResultado = False
End Class