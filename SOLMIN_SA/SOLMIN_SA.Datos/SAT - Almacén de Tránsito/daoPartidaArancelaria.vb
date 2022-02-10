Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.PartArancelaria

Namespace slnSOLMIN_SAT.DAO.PartidaArancelaria
    Public Class daoPartidaArancelaria
        Inherits BasicClass
#Region " Tipos de Datos "

#End Region
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        ''' <summary>
        ''' Procedimiento que se encarga de Grabar y/o Actualizar la información de la Partida Arancelaria de una Orden de Compra
        ''' </summary>
        Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal strUsuario As String, ByVal oData As TD_PartArancelaria, _
                                      ByRef strMensajeError As String) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CPTDAR", oData.pCPTDAR_PartArancelaria)
                .Add("IN_TDEPTD", oData.pTDEPTD_Detalle)
                .Add("IN_USUARI", strUsuario)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_PARTARANCELARIA_RZOL64_INS", objParametros)
                Dim htResultado As Hashtable
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoPartidaArancelaria >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_PARTARANCELARIA_RZOL64_INS >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Procedimiento que se encarga de Grabar y/o Actualizar la información de la Partida Arancelaria de una Orden de Compra a través del Web Services
        ''' </summary>
        Public Shared Function Grabar(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, _
                                      ByVal oData As TD_PartArancelaria, ByRef strMensajeError As String) As Boolean
            ' Creando el Objeto de Conexion
            Dim strCadenaConexion As String = ""
            Dim dstResultado As DataSet = Nothing
            strCadenaConexion = My.Settings.Item(strServidor).ToString()
            strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
            ' Llamada a la Rutina ya existente
            Return Grabar(objSqlManager, strUsuario, oData, strMensajeError)
            objSqlManager.Dispose()
            objSqlManager = Nothing
        End Function
#End Region
    End Class
End Namespace