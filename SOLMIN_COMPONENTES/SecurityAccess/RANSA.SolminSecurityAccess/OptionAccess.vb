Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class OptionAccess
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private dtOptionsForUser As DataTable           ' Tabla que contendrá las opciones del Usuario
    Private strUsuario As String = ""               ' Usuario quien tiene los permisos
    Private strAplicativo As String = ""            ' Aplicativo con el que trabaja el usuario
    Private strMensajeError As String               ' Mensaje de Error
#End Region
#Region " Propiedades "
    Public ReadOnly Property pUsuario() As String
        Get
            Return strUsuario
        End Get
    End Property

    Public ReadOnly Property pAplicativo() As String
        Get
            Return strAplicativo
        End Get
    End Property

    Public ReadOnly Property pMensajeError() As String
        Get
            Return strMensajeError
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub fblnLoadOptionsForUser()
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_MMCAPL", strAplicativo)
        objParametros.Add("IN_MMCUSR", strUsuario)

        Try
            strMensajeError = ""
            dtOptionsForUser = objSqlManager.ExecuteDataTable("SP_SOLMIN_ACCESO", objParametros)
        Catch ex As Exception
            dtOptionsForUser = New DataTable
            strMensajeError = "Error producido en la funcion : << fblnCargarOpcionesPorUsuario >> de la clase << OptionAccess >> " & vbNewLine & _
                              "Tipo de Consulta : SP_SOLMIN_ACCESO " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Sub

    Private Function fblnValidateOptionAccess(ByVal OptionCode As String) As Boolean
        Dim rwOpciones() As DataRow
        Dim blnResultado As Boolean = False
        Dim strCodeFather As String = OptionCode
        rwOpciones = dtOptionsForUser.Select("MMNQVB = '" & strCodeFather & "'")
        If rwOpciones.Length > 0 Then
            If ("" & rwOpciones(0).Item("MMCUSR")).ToString.Trim = strUsuario Then
                ' Armamos el Codigo Padre para validar si pertenece a un nodo superior
                strCodeFather = rwOpciones(0).Item("MMCAPL") & rwOpciones(0).Item("MMCMNU")
                If strAplicativo & "00" = strCodeFather Then
                    blnResultado = True
                Else
                    blnResultado = fblnValidateOptionAccess(strCodeFather)
                End If
            Else
                blnResultado = False
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Metodos "
    Sub New(ByVal Aplicativo As String, ByVal Usuario As String)
        strUsuario = Usuario
        strAplicativo = Aplicativo
        Call fblnLoadOptionsForUser()
    End Sub

    Public Function fblnHasAccess(ByVal Codigo As String) As Boolean
        Dim strCodeFather As String = ""
        Dim blnResultado As Boolean = False
        ' Se verifica si esta registrado en la Tabla de Permisos.
        If dtOptionsForUser.Rows.Count > 0 Then
            Dim rwOpciones() As DataRow
            ' Obtenemos la fila de la opción.
            rwOpciones = dtOptionsForUser.Select("MMNPVB = '" & Codigo & "'")
            ' Si se obtiene una cantidad mayor cero se evalúa, sino simplemente no tiene acceso.
            If rwOpciones.Length > 0 Then
                If ("" & rwOpciones(0).Item("MMCUSR")).ToString.Trim = strUsuario Then
                    strCodeFather = rwOpciones(0).Item("MMCAPL") & rwOpciones(0).Item("MMCMNU")
                    If strAplicativo & "00" = strCodeFather Then
                        blnResultado = True
                    Else
                        ' Iniciamos la recursividad
                        blnResultado = fblnValidateOptionAccess(strCodeFather)
                    End If
                Else
                    blnResultado = False
                End If
            End If
        End If
        ' Devolvemos el status de Acceso a la Opción
        Return blnResultado
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
            dtOptionsForUser.Dispose()
            dtOptionsForUser = Nothing
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