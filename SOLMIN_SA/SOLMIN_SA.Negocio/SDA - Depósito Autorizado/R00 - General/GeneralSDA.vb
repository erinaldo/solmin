Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SDA
    Public Class clsGeneral_SDA
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

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_OrdenesServicios(ByVal objFiltro As clsFiltro_ListarOS, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDA_GENE_LSTOSE_01", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrTipoDeposito_CTPDP, _
                                               objFiltro.pstrNroOrdenServicio_NORDSR)
            dtResultado.TableName = "OrdenServicio"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_DetalleOrdenServicio(ByVal objFiltro As clsFiltro_ListarDetalleOS, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDA_GENE_LSTDOS_01", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCompania_CCMPN, _
                                               objFiltro.pstrDivision_CDVSN, objFiltro.pintServicio_CSRVC, objFiltro.pintNroOrdenServicio_NORDSR)
            dtResultado.TableName = "DetalleOrdenServicio"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_Series(ByVal intNroDepositoRansa As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDA_GENE_LSTSER_01", intNroDepositoRansa)
            dtResultado.TableName = "Series"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Funciones para Obtener Detalle de la Información -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
#End Region
    End Class
End Namespace