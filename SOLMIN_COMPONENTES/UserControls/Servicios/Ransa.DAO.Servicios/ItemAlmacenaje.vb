Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Servicios.Almacenaje

Namespace Almacenaje
    Public Class cItemAlmacenaje
        Implements IDisposable
#Region " Atributos "
        '-------------------------------------------------
        ' Manejador de la Conexion
        '-------------------------------------------------
        Private oSqlManager As SqlManager
        '-------------------------------------------------
        ' Almacenamiento de Información
        '-------------------------------------------------
        Private sErrorMessage As String = ""
        '-------------------------------------------------
        ' Información del Estado
        '-------------------------------------------------
        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
        '-------------------------------------------------
        ' Datos de Seguridad 
        '-------------------------------------------------
#End Region
#Region " Propiedades "
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return sErrorMessage
            End Get
        End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New()
            oSqlManager = New SqlManager
        End Sub

        ''' <summary>
        ''' Función para eliminar un Item del Proceso de Almacenaje, siempre en cuando esté en Proceso
        ''' </summary>
        Public Function Delete(ByVal oInf_DeleteItemAlmacenaje_L01 As TD_Inf_DeleteItemAlmacenaje_L01) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim dtTemp As DataTable = Nothing
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oInf_DeleteItemAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_NPRALM", oInf_DeleteItemAlmacenaje_L01.pNPRALM_NroOperacion)
                .Add("IN_CREFFW", oInf_DeleteItemAlmacenaje_L01.pCREFFW_CodigoBulto)
                .Add("IN_USUARI", oInf_DeleteItemAlmacenaje_L01.pUsuario)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                sErrorMessage = ""
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ALMACENAJE_RZSC33_DEL", objParametros)
                Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
                sErrorMessage = htResultado("OU_MSGERR")
            Catch ex As Exception
                blnResultado = False
                sErrorMessage = "Error producido en la funcion : << Delete >> de la clase << cItemAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC33_DEL >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Función para agregar un Item al Proceso de Almacenaje
        ''' </summary>
        Public Function Add(ByVal oInf_AddItemAlmacenaje_L01 As TD_Inf_AddItemAlmacenaje_L01) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim dtTemp As DataTable = Nothing
            Dim blnResultado As Boolean = True
            sErrorMessage = ""
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oInf_AddItemAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_NANPRC", oInf_AddItemAlmacenaje_L01.pNPRALM_NroOperacion)
                .Add("IN_CREFFW", oInf_AddItemAlmacenaje_L01.pCREFFW_CodigoBulto)
                .Add("IN_NROPLT", oInf_AddItemAlmacenaje_L01.pNROPLT_NroPaletizado)
                .Add("IN_NROCTL", oInf_AddItemAlmacenaje_L01.pNROCTL_NroPreDespacho)
                .Add("IN_NRGUSA", oInf_AddItemAlmacenaje_L01.pNRGUSA_NroGuiaSalida)
                .Add("IN_NGUIRM", oInf_AddItemAlmacenaje_L01.pNGUIRM_NroGuiaRemision)
                .Add("IN_USUARI", oInf_AddItemAlmacenaje_L01.pUsuario )
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ALMACENAJE_RZSC33_INS", objParametros)
                Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
                sErrorMessage = htResultado("OU_MSGERR")
            Catch ex As Exception
                blnResultado = False
                sErrorMessage = "Error producido en la funcion : << Add >> de la clase << cItemAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC33_INS >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Listado de los Items de un Proceso de Almacenaje registrados en el Sistema SOLMIN SAT - RZSC33
        ''' </summary>
        Public Function Listar(ByVal oQry_LstItemAlmacenaje_L01 As TD_Qry_LstItemAlmacenaje_L01) As DataTable
            Dim dtTemp As DataTable
            Dim oParametros As Parameter = New Parameter
            With oParametros
                .Add("IN_CCLNT", oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente)
                .Add("IN_NPRALM", oQry_LstItemAlmacenaje_L01.pNPRALM_NroOperacion)
                .Add("IN_USUARI", oQry_LstItemAlmacenaje_L01.pUsuario)
            End With
            Try
                sErrorMessage = ""
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SA_ALMACENAJE_RZSC33_L01", oParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cItemAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC33_L01 >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            End Try
            Return dtTemp
        End Function
#End Region
#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                    oSqlManager.Dispose()
                    oSqlManager = Nothing
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