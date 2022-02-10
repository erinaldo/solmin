Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SAT.DAO
    Public Class daoSecuenciaControl
        Inherits BasicClass
#Region " Tipos de Datos "
        Enum TipoControl
            SAT_CODBULTO_REC
        End Enum
#End Region
#Region " Atributos "
        '-- Seguridad
        Private strUsuario As String = ""
#End Region
#Region " Propiedades "
       
#End Region
#Region " Funciones y Procedimientos "
        Private Shared Function fstrObtenerTipoDeposito(ByVal tcTipoDeposito As TipoControl) As String
            Dim strTipoDeposito As String = ""
            Select Case tcTipoDeposito
                Case TipoControl.SAT_CODBULTO_REC : strTipoDeposito = "I"
            End Select
            Return strTipoDeposito
        End Function
#End Region
#Region " Métodos "
        Sub New(ByVal Usuario As String)
            strUsuario = Usuario
        End Sub

        ''' <summary>
        ''' Función que nos permite obtener la Clave de Control para ubicar el último correlativo de la secuencia 
        ''' de Nros de Bultos
        ''' </summary>
        Public Shared Function fstrObtenerClaveControl(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal tcTipoDeposito As TipoControl, _
                                                       ByRef strMensajeError As String) As String
            Dim dtResultado As DataTable = Nothing
            Dim strEtiquetaControl As String = ""
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_ETCTRL_01", intCliente, fstrObtenerTipoDeposito(tcTipoDeposito))
            dtResultado.TableName = "ClaveControl"
            If strMensajeError <> "" Then
                If dtResultado.Rows.Count <= 0 Then
                    strMensajeError = "No existe Información"
                Else
                    strEtiquetaControl = "" & dtResultado.Rows(0).Item("CTPCTR")
                End If
            End If
            Return strEtiquetaControl
        End Function

        ''' <summary>
        ''' Función que nos permite obtener el último correlativo de la secuencia de Nros de Bultos
        ''' </summary>
        Public Shared Function fintObtenerUltimoNroControl(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal tcTipoDeposito As TipoControl, _
                                                           ByRef strMensajeError As String) As Int64
            Dim dtResultado As DataTable = Nothing
            Dim strEtiquetaControl As String = ""
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_NUCTRL_01", intCliente, fstrObtenerTipoDeposito(tcTipoDeposito))
            dtResultado.TableName = "ClaveControl"
            If strMensajeError <> "" Then
                If dtResultado.Rows.Count <= 0 Then
                    strMensajeError = "No existe Información"
                Else
                    strEtiquetaControl = "" & dtResultado.Rows(0).Item("NULCTR")
                End If
            End If
            Return strEtiquetaControl
        End Function

        Public Function fintIncrementarUltimoNroControl(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal tcTipoDeposito As TipoControl, _
                                                        ByVal intIncremento As Int32, ByRef strMensajeError As String) As Int64
            Dim dtResultado As DataTable = Nothing
            Dim strEtiquetaControl As String = ""
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_NUCTRL_01", intCliente, fstrObtenerTipoDeposito(tcTipoDeposito))
            dtResultado.TableName = "ClaveControl"
            If strMensajeError <> "" Then
                If dtResultado.Rows.Count <= 0 Then
                    strMensajeError = "No existe Información"
                Else
                    strEtiquetaControl = "" & dtResultado.Rows(0).Item("NULCTR")
                End If
            End If
            Return strEtiquetaControl
        End Function
#End Region
    End Class
End Namespace
