Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.ServTransp

Public Class cServTransp
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
    ''' Obtener la Moneda - RZIK20
    ''' </summary>
    Public Function Obtener(ByVal sCompania As String, ByVal sDivision As String, ByVal strCodigo As String, ByRef strMensajeError As String) As TD_Obj_ServTransp
        Dim oServTransp As TD_Obj_ServTransp = New TD_Obj_ServTransp
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("IN_CCMPN", sCompania)
        objParametros.Add("IN_CDVSN", sDivision)
        objParametros.Add("IN_CSRVNV", strCodigo)
    Try
      strMensajeError = ""
      oSqlManager.DefaultSchema = Libreria.GetLibrary(sCompania)
      dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SERVICIO_TRANSPORTE_RZIK20_OBJ", objParametros)
      If dtTemp.Rows.Count > 0 Then
        oServTransp.pCCMPN_Compania = sCompania
        oServTransp.pCDVSN_División = sDivision
        oServTransp.pCSRVNV_Servicio = dtTemp.Rows(0).Item("CSRVNV")
        oServTransp.pTCMTRF_Descripcion = ("" & dtTemp.Rows(0).Item("TCMTRF")).ToString.Trim
      End If
    Catch ex As Exception
      strMensajeError = "Error producido en la funcion : << Obtener >> de la clase << cServTransp >> " & vbNewLine & _
                        "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SERVICIO_TRANSPORTE_RZIK20_OBJ >> " & vbNewLine & _
                        "Motivo del Error : " & ex.Message
    End Try
        Return oServTransp
    End Function

    ''' <summary>
    ''' Listado de los Servicios asociados a Transportes registradas en el Sistema SOLMIN - RZIK20
    ''' </summary>
    Public Function fdtListar(ByVal sCompania As String, ByVal sDivision As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCMPN", sCompania)
            .Add("IN_CDVSN", sDivision)
        End With
        Try
      sErrorMessage = ""
      oSqlManager.DefaultSchema = Libreria.GetLibrary(sCompania)
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SERVICIO_TRANSPORTE_RZIK20_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            sErrorMessage = "Error producido en la funcion : << fdtListarAll >> de la clase << cServTransp >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SERVICIO_TRANSPORTE_RZIK20_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
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