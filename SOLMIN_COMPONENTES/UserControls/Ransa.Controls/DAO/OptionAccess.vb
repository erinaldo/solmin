Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class OptionAccess
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    Private strUsuario As String = ""               ' Usuario quien tiene los permisos
    Private strReg As String = "R04"                ' Región de Venta
    Private strTipoOper As String = "DM"            ' Tipo de Operación
    Private strMensajeError As String               ' Mensaje de Error
#End Region
#Region " Propiedades "
    Public ReadOnly Property pUsuario() As String
        Get
            Return strUsuario
        End Get
    End Property

    Public ReadOnly Property pMensajeError() As String
        Get
            Return strMensajeError
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
  Private Function fdtGetInfLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As String, ByVal FnVerificacion As String, _
                                   ByVal RefServ As String, ByVal NroOpe As String, ByRef sPARAM_SFLGB1 As String, ByRef sPARAM_SFLGB2 As String, _
                                   ByRef sPARAM_MSGBLQ As String, ByVal lstrRegionVenta As String) As Boolean
    Dim bResultado As Boolean = True
    Dim objSqlManager As SqlManager = New SqlManager
    Dim objParametros As Parameter = New Parameter
    objSqlManager.TransactionController(TransactionType.Automatic)
    Cliente = Right("000000" & Cliente, 6)
    ' Ingresamos los parametros del Procedure
    objParametros.Add("PARAM_CCMPN", Compania)
    objParametros.Add("PARAM_CDVSN", Division)
    objParametros.Add("PARAM_CRGVTA", lstrRegionVenta)
    objParametros.Add("PARAM_CCLNT", Cliente)
    objParametros.Add("PARAM_TPOOPE", strTipoOper)
    objParametros.Add("PARAM_TFNCVR", FnVerificacion)
    objParametros.Add("PARAM_REFSRV", RefServ)
    objParametros.Add("PARAM_NROOPE", NroOpe)
    objParametros.Add("PARAM_SFLGB1", "", ParameterDirection.Output)
    objParametros.Add("PARAM_SFLGB2", "", ParameterDirection.Output)
    objParametros.Add("PARAM_MSGBLQ", "", ParameterDirection.Output)
    Try
      Dim strSQL As String = ""
      'objSqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(Compania)
      objSqlManager.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RCC575 ", objParametros)
      Dim htResultado As Hashtable
      htResultado = objSqlManager.ParameterCollection
      sPARAM_SFLGB1 = ("" & htResultado("PARAM_SFLGB1")).ToString.Trim
      sPARAM_SFLGB2 = ("" & htResultado("PARAM_SFLGB2")).ToString.Trim
      sPARAM_MSGBLQ = ("" & htResultado("PARAM_MSGBLQ")).ToString.Trim
    Catch ex As Exception
      sPARAM_SFLGB1 = ""
      sPARAM_SFLGB2 = ""
      sPARAM_MSGBLQ = ""
      bResultado = False
    Finally
      objSqlManager = Nothing
      objParametros = Nothing
    End Try
    Return bResultado
  End Function
#End Region
#Region " Metodos "
    Sub New(ByVal Usuario As String)
        strUsuario = Usuario
    End Sub

  Public Function fblnIsLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As Int64, ByVal FnVerificacion As String, _
                               ByRef strMensaje As String, ByVal lstrRegionVenta As String) As Boolean
    Dim btnResultado As Boolean = False
    Dim sPARAM_SFLGB1 As String = ""
    Dim sPARAM_SFLGB2 As String = ""
    Dim sMensaje As String = ""

    If fdtGetInfLocked(Compania, Division, Cliente, FnVerificacion, "", "", sPARAM_SFLGB1, sPARAM_SFLGB2, sMensaje, lstrRegionVenta) Then
      ' Se bloquea solamente al ser C y B 
      If sPARAM_SFLGB1 = "C" And sPARAM_SFLGB2 = "B" Then
        btnResultado = True
        strMensaje = sMensaje
      End If
    Else
      strMensaje = "Error en la ejecución del Proceso de Verificación"
      ' Se bloquea al no tener respuesta
      btnResultado = True
    End If
    Return btnResultado
  End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
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
