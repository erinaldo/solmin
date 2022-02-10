Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.DATA.slnSOLMIN_SAT.DAO

Namespace slnSOLMIN_SAT
    '-----------------------------------------------------'
    ' CLASE CON LOS METODOS BASICOS PARA TODAS LAS CLASES '
    '-----------------------------------------------------'
    Public Class clsGeneral_SAT
        Inherits clsBasicClass
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Metodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'
        Public Shared Function fdtBuscar_MedioTransporte(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_MEDTRA_01", strCadenaBusqueda)
            dtResultado.TableName = "Medio Transporte"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Nave(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_NAVTRA_01", strCadenaBusqueda)
            dtResultado.TableName = "Nave"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_SentidoCarga(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_SITCAR_01", strCadenaBusqueda)
            dtResultado.TableName = "Sentido de la Carga"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TerminoInternacional(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_TERINT_01", strCadenaBusqueda)
            dtResultado.TableName = "Term. Internacional"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Ticket(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_TICKET_01", strCadenaBusqueda)
            dtResultado.TableName = "Tickets"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoDespacho(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_DESREM_01", strCadenaBusqueda)
            dtResultado.TableName = "Tipo de Despacho"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Ubicacion(ByRef strMensajeError As String, ByVal intCliente As Int64, _
                                                   ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "SAT_GENE_UBICAC_01", intCliente, strCadenaBusqueda)
            dtResultado.TableName = "Ubicación"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_ValoresPorDefectoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                             ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_GENE_VLSDFT_01")
            dtResultado.TableName = "ValoresPorDefecto"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_SentidoCargaWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                        ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_GENE_SITCAR_02")
            dtResultado.TableName = "SentidoCarga"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_UbicacionWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                     ByVal strCliente As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_GENE_UBICAC_01", strCliente)
            dtResultado.TableName = "Ubicacion"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Funciones para Obtener Detalle de la Información -'
        '----------------------------------------------------'
        Public Shared Function fdtObtenerDetalle_EmpresaTransporte(ByRef strMensajeError As String, ByVal strEmpresaTransporte As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SAT_GENE_EMPTRA_01", strEmpresaTransporte)
        End Function

        Public Shared Function fdtObtenerDetalle_Proveedor(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strProveedor As String) As DataTable
            Return fdtResultadoConsulta(strMensajeError, "SAT_GENE_PROVEE_01", strCliente, strProveedor)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Shared Function fintObtener_UltimoNroControlRecepcion(ByRef strMensajeError As String, ByVal strCliente As String) As Int64
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim intResultado As Int64 = 0
            Int64.TryParse(daoSecuenciaControl.fintObtenerUltimoNroControl(objSqlManager, strCliente, daoSecuenciaControl.TipoControl.SAT_CODBULTO_REC, strMensajeError), intResultado)
            Return intResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'
        Public Shared Function fdtDefecto_SentidoCarga(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SAT_GENE_SITCAR_01")
            dtResultado.TableName = "Sentido de la Carga"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_Ticket(ByRef strMensajeError As String, ByVal strNroTicketBalanza As String) As Boolean
            Return fblnExisteInformacion(strMensajeError, "GENE_EXTCKTS", strNroTicketBalanza)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'













        ' RUTINA A SER CONVERTIDAS A PROCEDURE
#Region " MEDIO DE TRANSPORTE "
        Public Function fstrObtenerMedioTransporte(ByVal strCodigoMedioTransporte As String) As String
            Dim strSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try ' Crear la cadena SQL de consulta
                strSQL = " Select Max(TRIM(TNMMDT)) " & _
                         " From   RZOL48 " & _
                         " Where  Trim(CMEDTR) = " & strCodigoMedioTransporte.ToUpper.Trim
                ' Llamar al procedimiento de la capa de Datos
                Return objSqlManager.ExecuteScalar(strSQL)
            Catch ex As Exception
                Throw
            Finally
                objSqlManager = Nothing
            End Try
        End Function
#End Region

#Region " NRO PLACA ACOPLADO "
        Public Function fdatListarNumeroPlacaAcoplado(ByVal strCodigoEmpresaTransporte As String, _
                                                      ByVal strNroAcoplado As String) As DataTable
            Dim strSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try ' Crear la cadena SQL de consulta
                If strCodigoEmpresaTransporte = "" Then strCodigoEmpresaTransporte = "0"

                strSQL = "Select Trim(RZTR21.NPLCAC) As Acoplado, " & _
                               " Trim(RZTR21.TCLRUN) As Color, " & _
                               " Trim(RZTR21.QPSTRA) As Peso_Tara, " & _
                               " Trim(RZTR21.NEJSUN) As Nro_Eje, " & _
                               " Trim(RZTR21.NCPCRU) As Capacidad " & _
                         " FROM  RZTR21 "
                '" Where RZTR21.CTRSPT = " & strCodigoEmpresaTransporte
                If strNroAcoplado <> "" Then
                    strSQL &= " Where Trim(RZTR21.NPLCAC) like '" & strNroAcoplado & "'"
                End If
                strSQL &= " Order By 1 "
                ' Llamar al procedimiento de la capa de Datos
                Return objSqlManager.ExecuteDataTable(strSQL)
            Catch ex As Exception
                Return Nothing
            Finally
                objSqlManager = Nothing
            End Try
        End Function
#End Region
#Region " NAVE "
        Public Function fstrObtenerNave(ByVal strCodigoNave As String) As String
            Dim strSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try ' Crear la cadena SQL de consulta
                strSQL = " Select Max(Trim(TCMPVP)) " & _
                         " From   RZZK08 " & _
                         " Where  Trim(CVPRCN) <> '' " & _
                         " And    Ucase(CVPRCN) = '" & strCodigoNave.ToUpper.Trim & "'"
                ' Llamar al procedimiento de la capa de Datos
                Return objSqlManager.ExecuteScalar(strSQL)
            Catch ex As Exception
                Throw
            Finally
                objSqlManager = Nothing
            End Try
        End Function
#End Region
#Region "MONEDA"
#Region " Tipos Definidos "
        Structure stMonedaStructure
            Dim strDescripcion As String
            Dim strSimbolo As String
        End Structure
#End Region

        Public Function fstrObtenerMoneda(ByVal strCodigoMoneda As String) As stMonedaStructure
            Dim pstMoneda As stMonedaStructure
            pstMoneda.strDescripcion = ""
            pstMoneda.strSimbolo = ""

            If String.IsNullOrEmpty(strCodigoMoneda) Or strCodigoMoneda = "" Then
                Return pstMoneda
                Exit Function
            End If
            Dim dtResultado As DataTable
            Dim strSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)

            ' Crear la cadena SQL de consulta
            strSQL = " Select Trim(TMNDA), " & _
                            " Trim(TSGNMN) " & _
                     " From   RZZK02 " & _
                     " Where  Trim(CMNDA1) = " & strCodigoMoneda.Trim

            ' Llamar al procedimiento de la capa de Datos
            Try
                dtResultado = objSqlManager.ExecuteDataTable(strSQL)
            Catch ex As Exception
                Return pstMoneda
                Exit Function
            Finally
                objSqlManager = Nothing
            End Try

            If dtResultado.Rows.Count = 1 Then
                pstMoneda.strDescripcion = dtResultado.Rows(0).Item(0).ToString.Trim
                pstMoneda.strSimbolo = dtResultado.Rows(0).Item(1).ToString.Trim
            End If
            Return pstMoneda
        End Function
#End Region
#Region " GENERAL "
        Public Function fstrObtenerTerminoInternacional(ByVal strTerminoInternacional As String) As String
            Dim strTerminoInternacionalTemp As String = ""
            Select Case strTerminoInternacional
                Case "LOC"
                    strTerminoInternacionalTemp = "LOCAL"
                Case "EXW"
                    strTerminoInternacionalTemp = "EX WORK"
                Case "FOB"
                    strTerminoInternacionalTemp = "FREE ON BOARD"
                Case Else
                    strTerminoInternacionalTemp = ""
            End Select
            Return strTerminoInternacionalTemp
        End Function

        Public Function fstrObtenerProveedor(ByVal strCodigoProveedor As String) As String
            'Dim mobjConexion As clsODBC
            Dim strSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                ' Crear el componente
                'mobjConexion = New clsODBC

                ' Crear la cadena SQL de consulta
                strSQL = " Select Trim(CLI.TPRVCL) " & _
                         " From   RZOL05 CLI " & _
                         " Where  Trim(CLI.TPRVCL) <> '' " & _
                         " And    Trim(CLI.CPRVCL) = " & strCodigoProveedor.ToUpper.Trim

                ' Llamar al procedimiento de la capa de Datos
                Return objSqlManager.ExecuteScalar(strSQL)
            Catch ex As Exception
                Return ""
            Finally
                objSqlManager = Nothing
            End Try
        End Function
#End Region
#End Region
    End Class
End Namespace