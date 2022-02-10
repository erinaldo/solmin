Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.CtrlsSolminSA.Ubicacion

Namespace Ubicacion
    Public Class cUbicacion
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
        ''' Listado de las ubicaciones registradas en el Sistema SOLMIN SAT - RZOL64K para un cliente determnado y la coincidencia en ubicacion 
        ''' </summary>
        Public Function Listar(ByVal Ubicacion As TF_Ubicacion) As DataTable
            Dim dtTemp As DataTable
            Dim oParametros As Parameter = New Parameter
            With oParametros
                .Add("IN_CCLNT", Ubicacion.pCCLNT_Cliente)
                .Add("IN_TUBRFR", Ubicacion.pCondicion)
            End With
            Try
                sErrorMessage = ""
                dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_UBICACION_RZOL64K_L01", oParametros)
            Catch ex As Exception
                dtTemp = New DataTable
                sErrorMessage = "Error producido en la funcion : << Listar >> de la clase << cUbicacion >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_UBICACION_RZOL64K_L01 >> " & vbNewLine & _
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