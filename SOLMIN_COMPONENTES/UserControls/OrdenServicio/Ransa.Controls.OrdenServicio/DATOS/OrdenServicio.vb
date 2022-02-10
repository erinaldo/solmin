Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.OrdenServicio

Public Class cOrdenServicio
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private oSqlManager As SqlManager
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New()
        oSqlManager = New SqlManager()
    End Sub

    ''' <summary>
    ''' Función que elimina el último movimiento de la Orden de Servicio.
    ''' </summary>
    Public Function Delete(ByVal DeleteOrdenServicio As TD_Inf_DeleteOrdenServicio_F01, ByRef MessageError As String) As Boolean
        Dim bResultado As Boolean = False
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", DeleteOrdenServicio.pCCLNT_CodigoCliente)
            .Add("IN_NORDSR", DeleteOrdenServicio.pNORDSR_OrdenServicio)
            .Add("IN_NSLCSR", DeleteOrdenServicio.pNSLCSR_NroSolicitud)
            .Add("IN_STPODP", DeleteOrdenServicio.pCTPDPS_TipoDeposito)
            .Add("IN_LIMDIA", DeleteOrdenServicio.pNroDiasLimite)
            .Add("IN_NTRMNL", DeleteOrdenServicio.pNTRMNL_NombreTerminal)
            .Add("IN_USUARI", DeleteOrdenServicio.pUsuario)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            MessageError = ""
            oSqlManager.ExecuteNonQuery("SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_D01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            MessageError = "" & htResultado("OU_MSGERR")
            If MessageError = "" Then bResultado = True
        Catch ex As Exception
            MessageError = "Error producido en la funcion : << Delete >> de la clase << cOrdenServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_D01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return bResultado
    End Function

    ''' <summary>
    ''' Listado Ordenes de Servicio asociadas a una mercadería
    ''' </summary>
    Public Function LstOrdenServPorMercaderia_F01(ByVal TD_Filtro As TD_Qry_LstOrdenServPorMercaderia_F01, ByRef MessageError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CMRCLR", TD_Filtro.pCMRCLR_Mercaderia)
            .Add("IN_CTPDPS", TD_Filtro.pCTPDPS_TipoDeposito)
        End With
        Try
            MessageError = ""
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_ORDEN_SERV_RZIT05_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            MessageError = "Error producido en la funcion : << LstOrdenServPorMercaderia_F01 >> de la clase << cOrdenServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_ORDEN_SERV_RZIT05_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado Solicitudes de Ordenes de Servicios
    ''' </summary>
    Public Function LstSolicOrdenServPorMercaderia_F01(ByVal TD_Filtro As TD_Qry_LstSolicOrdenServ_F01, ByRef MessageError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CMRCLR", TD_Filtro.pCMRCLR_Mercaderia)
            .Add("IN_CTPDPS", TD_Filtro.pCTPDPS_TipoDeposito)
            .Add("IN_NORDSR", TD_Filtro.pNORDSR_OrdenServicio)
        End With
        Try
            MessageError = ""
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_ORDEN_SERV_RZIT06_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            MessageError = "Error producido en la funcion : << LstSolicOrdenServPorMercaderia_F01 >> de la clase << cOrdenServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_ORDEN_SERV_RZIT06_L01 >> " & vbNewLine & _
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