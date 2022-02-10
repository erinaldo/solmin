Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Unidad

Public Class cUnidad
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
    ''' Listado de las unidades registradas en el Sistema SOLMIN - RZZM03
    ''' Nota : Solo se obtiene la descripción de las unidades
    ''' </summary>
    Public Function fsBuscarAbreviatura(ByVal strAbreviatura As String, ByRef sDefault As String) As String
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CUNDMD", strAbreviatura.Trim)
            .Add("OU_TABRUN", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
             oSqlManager.ExecuteNonQuery("SP_SOLMIN_UNIDAD_RZZM03_OBJ", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sDefault = htResultado("OU_TABRUN")
        Catch ex As Exception
            dtTemp = New DataTable
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cUnidad >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_UNIDAD_RZZM03_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return sDefault
    End Function

    ''' <summary>
    ''' Listado de las unidades registradas en el Sistema SOLMIN - RZZM03
    ''' Nota : Solo se obtiene la descripción de las unidades
    ''' </summary>
    Public Function fdtListar(ByVal sTipoUnidad As String, ByRef sDefault As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_STPOUN", sTipoUnidad)
            .Add("OU_TABRUN", "", ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_UNIDAD_RZZM03_L01", objParametros)
            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            sDefault = "" & htResultado("OU_TABRUN")
        Catch ex As Exception
            dtTemp = New DataTable
            sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cUnidad >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_UNIDAD_RZZM03_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objParametros = Nothing
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de las unidades registradas en el Sistema SOLMIN - RZZM03
    ''' Nota : Se obtiene el código y la descripción de las unidades
    ''' </summary>
  Public Function fdtListar(ByVal sTipoUnidad As String, ByRef sCodigo As String, ByRef sDefault As String, ByVal sCompania As String) As DataTable
    Dim dtTemp As DataTable
    Dim objParametros As Parameter = New Parameter
    ' Ingresamos los parametros del Procedure
    With objParametros
      .Add("IN_STPOUN", sTipoUnidad)
      .Add("OU_CUNDMD", "", ParameterDirection.Output)
      .Add("OU_TABRUN", "", ParameterDirection.Output)
    End With
    Try
      sErrorMessage = ""
      oSqlManager.DefaultSchema = Libreria.GetLibrary(sCompania)
      dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_UNIDAD_RZZM03_L02", objParametros)
      Dim htResultado As Hashtable
      htResultado = oSqlManager.ParameterCollection
      sCodigo = "" & htResultado("OU_CUNDMD")
      sDefault = "" & htResultado("OU_TABRUN")
    Catch ex As Exception
      dtTemp = New DataTable
      sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cUnidad >> " & vbNewLine & _
                        "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_UNIDAD_RZZM03_L02 >> " & vbNewLine & _
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