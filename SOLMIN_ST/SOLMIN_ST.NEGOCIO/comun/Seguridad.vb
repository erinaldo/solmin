Imports SOLMIN_ST.DATOS

Public Class Seguridad
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private oOptionAccess As OptionAccess
#End Region
#Region " Propiedades "
    Public ReadOnly Property pUsuario() As String
        Get
            Dim strUsuario As String = ""
            If Not oOptionAccess Is Nothing Then
                strUsuario = oOptionAccess.pUsuario
            End If
            Return strUsuario
        End Get
    End Property

    Public ReadOnly Property pMensajeError() As String
        Get
            Dim strMensajeError As String = ""
            If Not oOptionAccess Is Nothing Then
                strMensajeError = oOptionAccess.pMensajeError
            End If
            Return strMensajeError
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Metodos "
    Sub New(ByVal Usuario As String)
        oOptionAccess = New OptionAccess(Usuario)
    End Sub

  Public Function fblnIsLocked(ByVal Compania As String, ByVal Division As String, ByVal Cliente As Int64, ByVal FnVerificacion As String, _
                               ByRef Mensaje As String, ByVal lstrRegionVenta As String) As Boolean
    Return oOptionAccess.fblnIsLocked(Compania, Division, Cliente, FnVerificacion, Mensaje, lstrRegionVenta)
    End Function

    REM ECM-HUNDRED-INICIO
    Public Function VerificarLineaCreditoCliente(ByVal Compania As String, ByVal Cliente As String) As String
        Cliente = Cliente.PadLeft(6, "0")

        Dim dtLimiteCredito As DataTable = oOptionAccess.Limite_Credito_Liberado(Compania, Cliente)
        Dim dtCliente As DataTable = oOptionAccess.ListarDatosClientes(Compania, Cliente)
        Dim msjeRef As String = String.Empty
        Dim Descliente As String = String.Empty
        Dim codSap As String = String.Empty
        Dim sector As String = String.Empty

        If dtCliente.Rows.Count > 0 Then
            Descliente = dtCliente.Rows(0)("CCLNT").ToString.Trim() & " " & dtCliente.Rows(0)("TCMPCL").ToString.Trim()
            codSap = dtCliente.Rows(0)("CODSAP").ToString.Trim()
            sector = "(" & dtCliente.Rows(0)("CODSECTOR").ToString.Trim() & " " & dtCliente.Rows(0)("CRGVTA").ToString.Trim() & " )"
            sector = sector & dtCliente.Rows(0)("SECTOR").ToString.Trim() & " (Org. Vta " & dtCliente.Rows(0)("ORGVENTA").ToString.Trim() & " )"
            msjeRef = String.Format("Ref :{0} Cod SAP: {1} Sector: {2}", Descliente, codSap, sector)
        End If


        If dtLimiteCredito.Rows.Count = 0 Then
            Dim mensaje As String = oOptionAccess.VerificarLineaCreditoCliente(Compania, Cliente)
            If mensaje.ToString() <> "" Then
                Return String.Format("El cliente se encuentra bloqueado por:{0}{1}" & Environment.NewLine & "{2}", vbNewLine, mensaje, msjeRef)
            End If
        End If

        Return ""

    End Function

    Public Function Validar_Limite_Credito_Cliente_General(ByVal Compania As String, ByVal Cliente As String) As String
        Return oOptionAccess.Validar_Limite_Credito_Cliente_General(Compania, Cliente)
    End Function

    REM ECM-HUNDRED-FIN

    Public Function ListarDatosClientes(ByVal Compania, ByVal Cliente) As DataTable
        Return oOptionAccess.ListarDatosClientes(Compania, Cliente)
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
            If Not oOptionAccess Is Nothing Then oOptionAccess.Dispose()
            oOptionAccess = Nothing
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