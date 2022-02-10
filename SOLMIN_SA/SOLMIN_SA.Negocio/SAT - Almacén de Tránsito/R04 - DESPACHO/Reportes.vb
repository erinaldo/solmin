Imports IBM.Data.DB2.iSeries
Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario
Imports RANSA.TypeDef.Reportes
Imports RANSA.TYPEDEF

Namespace slnSOLMIN_SAT.Despacho.Reportes
    Public Class clsFiltros_DespachoPorAlmacen
#Region " Atributos "
        Private intCCLNT As Int32 = 0
        Private strCREFFW As String = ""
        Private dteFSLDAL_Inicio As Date
        Private dteFSLDAL_Final As Date
        Private strTUBRFR As String = ""
        Private strSTPING As String = ""
#End Region
#Region " Propiedades "
        Public Property pCodigoCliente_CCLNT() As Int32
            Get
                pCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int32)
                intCCLNT = value
            End Set
        End Property

        Public Property pCodigoRecepcion_CREFFW() As String
            Get
                pCodigoRecepcion_CREFFW = strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaSalidaAlmacenInicio_FSLDAL() As Date
            Get
                Return dteFSLDAL_Inicio
            End Get
            Set(ByVal value As Date)
                dteFSLDAL_Inicio = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaSalidaAlmacenInicio_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_Inicio.Year > 1 Then strResultado = dteFSLDAL_Inicio.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaSalidaAlmacenInicio_FSLDAL() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLDAL_Inicio.Year > 1 Then Integer.TryParse(dteFSLDAL_Inicio.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaSalidaAlmacenFinal_FSLDAL() As Date
            Get
                Return dteFSLDAL_Final
            End Get
            Set(ByVal value As Date)
                dteFSLDAL_Final = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaSalidaAlmacenFinal_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_Final.Year > 1 Then strResultado = dteFSLDAL_Final.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaSalidaAlmacenFinal_FSLDAL() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLDAL_Final.Year > 1 Then Integer.TryParse(dteFSLDAL_Final.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pUbicacionReferencial_TUBRFR() As String
            Get
                pUbicacionReferencial_TUBRFR = strTUBRFR
            End Get
            Set(ByVal value As String)
                strTUBRFR = value
            End Set
        End Property

        Public Property pstrTipoMovimiento_STPING() As String
            Get
                Return strSTPING
            End Get
            Set(ByVal value As String)
                strSTPING = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsPARAM_GuiaRemisionAT
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private intCCLNGR As Int64 = 0
        Private strNRGUSA As String = ""
        Private strSMTGRM As String = ""
        Private strTOBORM As String = ""
        Private strNGUIRM As String = ""
        Private intCPLNOR As Integer = 0
        Private intCPLNCL As Integer = 0
        Private intCPRVCL As Integer = 0
        Private intCPLCLP As Integer = 0
        Private intCTRSPT As Integer = 0
        Private strNPLCCM As String = ""
        Private strNPLACP As String = ""
        Private strNBRVCH As String = ""
        Private strTOBSRM As String = ""
        Private intNDCMRF As Integer = 0
        Private dteFGUIRM As Date
        Private dteFINTRA As Date
        Private intCMEDTR As Integer = 0
        Private intTipoRep As Integer = 0
        Private intCTPODC As Integer = 0
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property
        Public Property pintCodigoClienteGuia_intCCLNGR() As Int64
            Get
                pintCodigoClienteGuia_intCCLNGR = intCCLNGR
            End Get
            Set(ByVal value As Int64)
                intCCLNGR = value
            End Set
        End Property


        Public Property pstrNroGuiaSalida_NRGUSA() As String
            Get
                pstrNroGuiaSalida_NRGUSA = strNRGUSA
            End Get
            Set(ByVal value As String)
                strNRGUSA = value
            End Set
        End Property

        Public Property pstrMotivoTraslado_SMTGRM() As String
            Get
                pstrMotivoTraslado_SMTGRM = strSMTGRM
            End Get
            Set(ByVal value As String)
                strSMTGRM = value
            End Set
        End Property

        Public Property pdteFechaEmision_FGUIRM() As Date
            Get
                Return dteFGUIRM
            End Get
            Set(ByVal value As Date)
                dteFGUIRM = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaEmision_FFec_FGUIRM() As String
            Get
                Dim strResultado As String = ""
                If dteFGUIRM.Year > 1 Then strResultado = dteFGUIRM.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property


        Public Property pdteFechaTraslado_FINTRA() As Date
            Get
                Return dteFINTRA
            End Get
            Set(ByVal value As Date)
                dteFINTRA = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaTraslado_FFec_FINTRA() As String
            Get
                Dim strResultado As String = ""
                If dteFINTRA.Year > 1 Then strResultado = dteFINTRA.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public Property pstrObservacionesOtroMotivoTraslado_TOBORM() As String
            Get
                pstrObservacionesOtroMotivoTraslado_TOBORM = strTOBORM
            End Get
            Set(ByVal value As String)
                strTOBORM = value
            End Set
        End Property

        Public Property pstrNroGuiaRemision_NGUIRM() As String
            Get
                pstrNroGuiaRemision_NGUIRM = strNGUIRM
            End Get
            Set(ByVal value As String)
                strNGUIRM = value
            End Set
        End Property

        Public Property pintPlantaOrigen_CPLNOR() As Integer
            Get
                pintPlantaOrigen_CPLNOR = intCPLNOR
            End Get
            Set(ByVal value As Integer)
                intCPLNOR = value
            End Set
        End Property

        Public Property pintPlantaDestino_CPLNCL() As Integer
            Get
                pintPlantaDestino_CPLNCL = intCPLNCL
            End Get
            Set(ByVal value As Integer)
                intCPLNCL = value
            End Set
        End Property

        Public Property pintClienteTercero_CPRVCL() As Integer
            Get
                pintClienteTercero_CPRVCL = intCPRVCL
            End Get
            Set(ByVal value As Integer)
                intCPRVCL = value
            End Set
        End Property

        Public Property pintPlantaClienteTercero_CPLCLP() As Integer
            Get
                pintPlantaClienteTercero_CPLCLP = intCPLCLP
            End Get
            Set(ByVal value As Integer)
                intCPLCLP = value
            End Set
        End Property

        Public Property pintEmpresaTransporte_CTRSPT() As Integer
            Get
                pintEmpresaTransporte_CTRSPT = intCTRSPT
            End Get
            Set(ByVal value As Integer)
                intCTRSPT = value
            End Set
        End Property

        Public Property pstrPlacaUnidad_NPLCCM() As String
            Get
                pstrPlacaUnidad_NPLCCM = strNPLCCM
            End Get
            Set(ByVal value As String)
                strNPLCCM = value
            End Set
        End Property

        Public Property pstrPlacaAcoplado_NPLACP() As String
            Get
                pstrPlacaAcoplado_NPLACP = strNPLACP
            End Get
            Set(ByVal value As String)
                strNPLACP = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVCH() As String
            Get
                pstrNroBrevete_NBRVCH = strNBRVCH
            End Get
            Set(ByVal value As String)
                strNBRVCH = value
            End Set
        End Property

        Public Property pstrObservacionesGuiaRemision_TOBSRM() As String
            Get
                pstrObservacionesGuiaRemision_TOBSRM = strTOBSRM
            End Get
            Set(ByVal value As String)
                strTOBSRM = value
            End Set
        End Property

        Public Property pintEmpresaTransporte2doTramo_NDCMRF() As Integer
            Get
                pintEmpresaTransporte2doTramo_NDCMRF = intNDCMRF
            End Get
            Set(ByVal value As Integer)
                intNDCMRF = value
            End Set
        End Property
        Public Property pintMedioTransporte_CMEDTR() As Integer
            Get
                pintMedioTransporte_CMEDTR = intCMEDTR
            End Get
            Set(ByVal value As Integer)
                intCMEDTR = value
            End Set
        End Property
        Public Property TipoRep() As Integer
            Get
                TipoRep = intTipoRep
            End Get
            Set(ByVal value As Integer)
                intTipoRep = value
            End Set
        End Property
        Private pstrCPRCN1 As String = String.Empty
        Public Property pstrSiglaContenedor_CPRCN1() As String
            Get
                pstrSiglaContenedor_CPRCN1 = pstrCPRCN1
            End Get
            Set(ByVal value As String)
                pstrCPRCN1 = value
            End Set
        End Property
        Private pstrNSRCN1 As String = String.Empty
        Public Property pstrNumeroContenedor_NSRCN1() As String
            Get
                pstrNumeroContenedor_NSRCN1 = pstrNSRCN1
            End Get
            Set(ByVal value As String)
                pstrNSRCN1 = value
            End Set
        End Property

        Public Property pintTipoDoc_CTPODC() As Integer
            Get
                pintTipoDoc_CTPODC = intCTPODC
            End Get
            Set(ByVal value As Integer)
                intCTPODC = value
            End Set
        End Property

#End Region
    End Class

    Public Class clsParametrosGuiaSalida
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private intNRGUSA As Int64 = 0
        Private strTCMPCL As String = ""
        Private _PSCCMPN As String = ""
        Private _PSCDVSN As String = ""
        Private _PNCPLNDV As Int64 = 0
#End Region
#Region " Propiedades "

        Public Property PSCCMPN() As String
            Get
                PSCCMPN = _PSCCMPN
            End Get
            Set(ByVal value As String)
                _PSCCMPN = value
            End Set
        End Property

        Public Property PSCDVSN() As String
            Get
                PSCDVSN = _PSCDVSN
            End Get
            Set(ByVal value As String)
                _PSCDVSN = value
            End Set
        End Property

        Public Property PNCPLNDV() As Int64
            Get
                PNCPLNDV = _PNCPLNDV
            End Get
            Set(ByVal value As Int64)
                _PNCPLNDV = value
            End Set
        End Property


        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrDescripcionCliente_CCLNT() As String
            Get
                pstrDescripcionCliente_CCLNT = strTCMPCL
            End Get
            Set(ByVal value As String)
                strTCMPCL = value
            End Set
        End Property

        Public Property pintNroGuiaSalida_NRGUSA() As Int64
            Get
                pintNroGuiaSalida_NRGUSA = intNRGUSA
            End Get
            Set(ByVal value As Int64)
                intNRGUSA = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsReportesDespacho
        Inherits clsBasicClass
#Region " Tipo Definidos "

#End Region
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "
#End Region
#Region " Procedimientos y Funciones "
        ' Función para obtener los Parametros de Impresión de la Guia de Remision
        Private Function fobjParamatrosGuiaRemision(ByVal intCliente As Int64, ByVal strAplicacion As String, ByRef strMensajeError As String) As clsParamImprGuiaRemision
            Dim dstParametrosGenerales As DataSet
            Dim objParametros As clsParamImprGuiaRemision = New clsParamImprGuiaRemision
            Dim rwListaBaseDatos As DataRow()
            Try
                dstParametrosGenerales = New DataSet()
                dstParametrosGenerales.ReadXml(strAplicacion & "\Servidores.xml")
                rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionAT").Select("Cliente='" & intCliente.ToString & "'")
                If rwListaBaseDatos.Length = 0 Then
                    rwListaBaseDatos = dstParametrosGenerales.Tables("ParamGuiaRemisionAT").Select("Cliente='999999'")
                End If
                With objParametros
                    .pintNroLineasPorGuiaRemision = rwListaBaseDatos(0).Item("NroLineaPorGuia")
                    .pstrModeloGuiaRemision = rwListaBaseDatos(0).Item("ModReporte")
                    .pstrConsolidarDetalle = rwListaBaseDatos(0).Item("ConsDescripcion")
                    .pstrMostrarInformacionGuiaProveedor = rwListaBaseDatos(0).Item("MostrarGF")
                    .pstrMostrarInfGuiaProveedorAlFinal = rwListaBaseDatos(0).Item("MostrarGFFinal")
                    .pstrMostrarObservaciones = rwListaBaseDatos(0).Item("IncluirOBS")
                    .pstrMostrarTotalPorBulto = rwListaBaseDatos(0).Item("MostrarTBulto")
                End With
            Catch ex As Exception
                strMensajeError = ex.Message
            End Try
            Return objParametros
        End Function

        ' Funciones relacionadas a las Guías
        Private Function fdstDataGuiaSalida(ByVal objParametrosGuiaSalida As clsParametrosGuiaSalida) As EstructuraDespachos
            Dim objData As New EstructuraDespachos
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)

            With objParametrosGuiaSalida
                ' Ingresamos los parametros del Procedure
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_NRGUSA", .pintNroGuiaSalida_NRGUSA)
                objParametros.Add("PSCCMPN", .PSCCMPN)
                objParametros.Add("PSCDVSN", .PSCDVSN)
                objParametros.Add("PNCPLNDV", .PNCPLNDV)
            End With
            Try
                Dim cnx As iDB2Connection = objSqlManager.Conectar(objSqlManager.Conectar())
                Dim cmdAdaptador As iDB2DataAdapter
                Dim cmd As New iDB2Command

                cmd.Connection = cnx
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_SOLMIN_SA_IMPRIMIR_GUIA_SALIDA"


                Dim i As Integer
                Dim SqlParametro As iDB2Parameter

                If Not (objParametros Is Nothing) Then
                    For i = 1 To objParametros.Count
                        SqlParametro = CType(objParametros.Item(i), iDB2Parameter)
                        cmd.Parameters.Add(SqlParametro.ParameterName, SqlParametro.Value)
                    Next
                End If

                cnx.Open()
                cmdAdaptador = New iDB2DataAdapter(cmd)
                cmdAdaptador.Fill(objData, "dtGuiaSalida")
                cnx.Close()
                cmd = Nothing
                cnx = Nothing
                objSqlManager = Nothing
                objParametros = Nothing
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try
            Return objData
        End Function

        'Private Function fdstDataGuiaRemision(ByVal objParam As clsPARAM_GuiaRemisionAT, ByVal objParametro As clsParamImprGuiaRemision, _
        '                                      ByRef strMensajeError As String) As EstructuraDespachos
        '    Dim objData As New EstructuraDespachos
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    objSqlManager.TransactionController(TransactionType.Automatic)

        '    With objParam
        '        ' Ingresamos los parametros del Procedure
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CCLNGR", .pintCodigoClienteGuia_intCCLNGR)
        '        objParametros.Add("IN_NRGUSA", .pstrNroGuiaSalida_NRGUSA)
        '        objParametros.Add("IN_NGUIRM", .pstrNroGuiaRemision_NGUIRM)
        '        objParametros.Add("IN_FGUIRM", HelpClass.CDate_a_Numero8Digitos(.pstrFechaEmision_FFec_FGUIRM))
        '        objParametros.Add("IN_FINTRA", HelpClass.CDate_a_Numero8Digitos(.pstrFechaTraslado_FFec_FINTRA))
        '        objParametros.Add("IN_SMTGRM", .pstrMotivoTraslado_SMTGRM)
        '        objParametros.Add("IN_TOBORM", .pstrObservacionesOtroMotivoTraslado_TOBORM)
        '        objParametros.Add("IN_CPLNOR", .pintPlantaOrigen_CPLNOR)
        '        objParametros.Add("IN_CPLNCL", .pintPlantaDestino_CPLNCL)
        '        objParametros.Add("IN_CPRVCL", .pintClienteTercero_CPRVCL)
        '        objParametros.Add("IN_CPLCLP", .pintPlantaClienteTercero_CPLCLP)
        '        objParametros.Add("IN_CPRVCO", 0)
        '        objParametros.Add("IN_CPLCLO", 0)
        '        objParametros.Add("IN_CTRSPT", .pintEmpresaTransporte_CTRSPT)
        '        objParametros.Add("IN_NDCMRF", .pintEmpresaTransporte2doTramo_NDCMRF)
        '        objParametros.Add("IN_NPLCCM", .pstrPlacaUnidad_NPLCCM)
        '        objParametros.Add("IN_NPLACP", .pstrPlacaAcoplado_NPLACP)
        '        objParametros.Add("IN_NBRVCH", .pstrNroBrevete_NBRVCH)
        '        objParametros.Add("IN_TOBSRM", .pstrObservacionesGuiaRemision_TOBSRM)
        '        objParametros.Add("IN_CMEDTR", .pintMedioTransporte_CMEDTR) 'Código Medio Transporte Agregado
        '        'objParam.TipoRep = 1 : Reporte Guia Remision
        '        'objParam.TipoRep = 2 : Reporte Guia Regularizacion
        '        If objParam.TipoRep = 1 Then
        '            objParametros.Add("IN_NLINGR", objParametro.pintNroLineasPorGuiaRemision)
        '        Else
        '            objParametros.Add("IN_NLINGR", 1000)
        '        End If
        '        objParametros.Add("IN_DECONC", objParametro.pstrConsolidarDetalle)
        '        objParametros.Add("IN_MGUIFA", objParametro.pstrMostrarInformacionGuiaProveedor)
        '        objParametros.Add("IN_MGFFIN", objParametro.pstrMostrarInfGuiaProveedorAlFinal)
        '        objParametros.Add("IN_MOBSER", objParametro.pstrMostrarObservaciones)
        '        objParametros.Add("IN_TOXBUL", objParametro.pstrMostrarTotalPorBulto)

        '        objParametros.Add("IN_CPRCN1", objParam.pstrSiglaContenedor_CPRCN1)
        '        objParametros.Add("IN_NSRCN1", objParam.pstrNumeroContenedor_NSRCN1)

        '        objParametros.Add("IN_USUARI", strUsuarioSistema)
        '        objParametros.Add("IN_FCREAC", Now.ToString("yyyyMMdd"))
        '        objParametros.Add("IN_HCREAC", Now.ToString("hhmmss"))


        '    End With
        '    Try
        '        Dim cnx As iDB2Connection = objSqlManager.Conectar(objSqlManager.Conectar())
        '        Dim cmdAdaptador As iDB2DataAdapter
        '        Dim cmd As New iDB2Command


        '        cmd.Connection = cnx
        '        cmd.CommandType = CommandType.StoredProcedure

        '        cmd.CommandText = "SP_SOLMIN_SA_GENERAR_GUIA_REMISION"


        '        Dim i As Integer
        '        Dim SqlParametro As iDB2Parameter

        '        If Not (objParametros Is Nothing) Then
        '            For i = 1 To objParametros.Count
        '                SqlParametro = CType(objParametros.Item(i), iDB2Parameter)
        '                cmd.Parameters.Add(SqlParametro.ParameterName, SqlParametro.Value)
        '            Next
        '        End If
        '        cnx.Open()
        '        cmdAdaptador = New iDB2DataAdapter(cmd)
        '        cmdAdaptador.Fill(objData, "dtGuiaRemision")
        '        cnx.Close()
        '        cmd = Nothing
        '        cnx = Nothing
        '    Catch ex As Exception
        '        strMensajeError = ex.Message
        '    End Try

        '    objSqlManager = Nothing
        '    objParametros = Nothing
        '    Return objData
        'End Function


        Private Function fdstDataGuiaRemisionMasivo(ByVal intCliente As Int64, ByVal strNroGuiaRemision As String, ByVal objParametro As clsParamImprGuiaRemision, _
                                              ByRef strMensajeError As String, ByVal Compañia As String, ByVal Division As String, ByVal Planta As Double) As DataSet
            Dim objData As New DataSet
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)

            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_NGUIRM", strNroGuiaRemision)
            objParametros.Add("IN_NLINGR", objParametro.pintNroLineasPorGuiaRemision)
            objParametros.Add("IN_DECONC", objParametro.pstrConsolidarDetalle)
            objParametros.Add("IN_MGUIFA", objParametro.pstrMostrarInformacionGuiaProveedor)
            objParametros.Add("IN_MGFFIN", objParametro.pstrMostrarInfGuiaProveedorAlFinal)
            objParametros.Add("IN_MOBSER", objParametro.pstrMostrarObservaciones)
            objParametros.Add("IN_TOXBUL", objParametro.pstrMostrarTotalPorBulto)
            objParametros.Add("IN_CCMPN", Compañia)
            objParametros.Add("IN_CDVSN", Division)
            objParametros.Add("IN_CPLNDV", Planta)
            Try
                Dim cnx As iDB2Connection = objSqlManager.Conectar(objSqlManager.Conectar())
                Dim cmdAdaptador As iDB2DataAdapter
                Dim cmd As New iDB2Command

                cmd.Connection = cnx
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_SOLMIN_SA_IMPRIMIR_GUIA_REMISION_MASIVO"

                Dim i As Integer
                Dim SqlParametro As iDB2Parameter

                If Not (objParametros Is Nothing) Then
                    For i = 1 To objParametros.Count
                        SqlParametro = CType(objParametros.Item(i), iDB2Parameter)
                        cmd.Parameters.Add(SqlParametro.ParameterName, SqlParametro.Value)
                    Next
                End If

                cnx.Open()
                cmdAdaptador = New iDB2DataAdapter(cmd)
                cmdAdaptador.Fill(objData, "dtGuiaRemision")
                cnx.Close()
                cmd = Nothing
                cnx = Nothing
                objSqlManager = Nothing
                objParametros = Nothing
            Catch ex As Exception
                Throw New Exception(ex.ToString())
            End Try

            Return objData
        End Function
#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub


        ' Procesos relacionados a la Guías
        Public Function frptGenerarGuiaSalida(ByVal objParametrosGuiaSalida As clsParametrosGuiaSalida) As rptGuiaDeSalida
            Dim info As rptGuiaDeSalida = New rptGuiaDeSalida
            Dim DtsReporte As DataSet = fdstDataGuiaSalida(objParametrosGuiaSalida)
            Dim TotalPeso As Decimal = 0
            Dim TotalBulto As Decimal = 0
            ObtenerPesos(TotalPeso, TotalBulto, DtsReporte)
            info.SetDataSource(DtsReporte)
            info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            info.Refresh()
            info.SetParameterValue("pCliente", objParametrosGuiaSalida.pstrDescripcionCliente_CCLNT)
            info.SetParameterValue("pUsuario", strUsuarioSistema)
            info.SetParameterValue("pTotalPeso", TotalPeso)
            info.SetParameterValue("pTotalBulto", TotalBulto)
            Return info
        End Function

        'Public Function frptGenerarGuiaRemision(ByVal objParam As clsPARAM_GuiaRemisionAT, _
        'ByVal strAplicacion As String, _
        '                                        ByRef strMensajeError As String) As ReportDocument
        '    Dim rdocGuiaRemision As ReportDocument = Nothing
        '    ' Cargamos los valores de los parametros de impresión de la Guia
        '    Dim objParametro As clsParamImprGuiaRemision
        '    objParametro = fobjParamatrosGuiaRemision(objParam.pintCodigoCliente_CCLNT, strAplicacion, strMensajeError)
        '    If strMensajeError = "" Then
        '        Select Case objParametro.pstrModeloGuiaRemision
        '            Case "M1"
        '                rdocGuiaRemision = New rptGuiaRemisionM01
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M2"
        '                rdocGuiaRemision = New rptGuiaRemisionM02
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M3"
        '                rdocGuiaRemision = New rptGuiaRemisionM03
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M4"
        '                rdocGuiaRemision = New rptGuiaRemisionM04
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M5"
        '                rdocGuiaRemision = New rptGuiaRemisionM05
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        '            Case "M5A"
        '                rdocGuiaRemision = New rptGuiaRemisionM05A
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M5B"
        '                rdocGuiaRemision = New rptGuiaRemisionM05B
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M6"
        '                rdocGuiaRemision = New rptGuiaRemisionM06
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M7"
        '                rdocGuiaRemision = New rptGuiaRemisionM07
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M9"
        '                rdocGuiaRemision = New rptGuiaRemisionM09
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        '            Case "M9B"
        '                rdocGuiaRemision = New rptGuiaRemisionM09B
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M10"
        '                rdocGuiaRemision = New rptGuiaRemisionM10
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        '            Case "M12"
        '                rdocGuiaRemision = New rptGuiaRemisionM012
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        '            Case "M13"
        '                rdocGuiaRemision = New rptGuiaRemisionM013
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        '            Case "M14"
        '                rdocGuiaRemision = New rptGuiaRemisionM14
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '            Case "M15"
        '                rdocGuiaRemision = New rptGuiaRemisionM15
        '                rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        '            Case Else
        '                rdocGuiaRemision = New rptGuiaRemisionM01
        '        End Select
        '        rdocGuiaRemision.SetDataSource(fdstDataGuiaRemision(objParam, objParametro, strMensajeError))
        '        rdocGuiaRemision.Refresh()
        '    End If
        '    Return rdocGuiaRemision
        'End Function

        Private Function formatear_nro_guia_remision(Tipo As String, Nro_Guia_S As String) As String
            Dim guia_final As String = ""
            Select Case Tipo
                Case "F"
                    Nro_Guia_S = Nro_Guia_S.PadLeft(10, "0")
                    guia_final = Nro_Guia_S.Substring(0, 3) & "-" & Nro_Guia_S.Substring(3, 7)
                Case "E"
                    'Nro_Guia_S = Nro_Guia_S.PadLeft(12, "0")
                    'guia_final = Nro_Guia_S.Substring(0, 4) & "-" & Nro_Guia_S.Substring(4, 8)
                    guia_final = Nro_Guia_S.Substring(0, 4) & "-" & Nro_Guia_S.Substring(4)
                Case Else
            End Select
            Return guia_final
        End Function

        Public Function frptImprimirGuiaRemision(ByRef obeGuiaRemision As RANSA.TYPEDEF.beGuiaRemision) As ReportDocument
            Dim rdocGuiaRemision As ReportDocument = Nothing
            Dim oDs As DataSet
            Dim obrGuiaRemision As New RANSA.NEGO.DespachoSAT.brGuiasRemision
            ' Cargamos los valores de los parametros de impresión de la Guia
            oDs = obrGuiaRemision.fdstDataGuiaRemision(obeGuiaRemision)

            For Each item As DataRow In oDs.Tables(0).Rows
                item("NGUIRM") = formatear_nro_guia_remision(item("CTDGRM"), item("NGUIRS"))
            Next

            Select Case obeGuiaRemision.PSMODELO
                Case "M1"
                    rdocGuiaRemision = New rptGuiaRemisionM01
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M2"
                    rdocGuiaRemision = New rptGuiaRemisionM02
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M3"
                    rdocGuiaRemision = New rptGuiaRemisionM03
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M4"
                    rdocGuiaRemision = New rptGuiaRemisionM04
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M5"
                    rdocGuiaRemision = New rptGuiaRemisionM05
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M5A"
                    rdocGuiaRemision = New rptGuiaRemisionM05A
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                    ' Dim str As String = rdocGuiaRemision.PrintOptions.PaperSize
                Case "M5B"

                    rdocGuiaRemision = New rptGuiaRemisionM05B
                    'rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                    ' Di

                Case "M6"
                    rdocGuiaRemision = New rptGuiaRemisionM06
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M7"
                    rdocGuiaRemision = New rptGuiaRemisionM07
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M9"
                    rdocGuiaRemision = New rptGuiaRemisionM09
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                Case "M9B"
                    rdocGuiaRemision = New rptGuiaRemisionM09B
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M10"
                    rdocGuiaRemision = New rptGuiaRemisionM10

                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                Case "M12"

                    rdocGuiaRemision = New rptGuiaRemisionM012
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                Case "M13"
                    rdocGuiaRemision = New rptGuiaRemisionM013
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                Case "M14"
                    rdocGuiaRemision = New rptGuiaRemisionM14
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                Case "M15"
                    rdocGuiaRemision = New rptGuiaRemisionM15
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                    'agregado 17-02-2013
                Case "CH2M"
                    rdocGuiaRemision = New rptGuiaRemisionCH2M
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

                Case "M16"
                    rdocGuiaRemision = New rptGuiaRemisionM16
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case "M17"
                    rdocGuiaRemision = New rptGuiaRemisionM17
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                Case "M18"
                    rdocGuiaRemision = New rptGuiaRemisionM18
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                Case "M19"
                    rdocGuiaRemision = New rptGuiaRemisionM19
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                Case "M20"
                    rdocGuiaRemision = New rptGuiaRemisionM20
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                Case Else
                    rdocGuiaRemision = New rptGuiaRemisionM01
                    rdocGuiaRemision.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                   
            End Select

            rdocGuiaRemision.SetDataSource(oDs)
            rdocGuiaRemision.Refresh()
            Return rdocGuiaRemision

        End Function

        Private Sub ObtenerPesos(ByRef TotalPeso As Decimal, ByRef TotalBulto As Decimal, ByVal dts As DataSet)
            Dim Bulto As String = String.Empty
            For Each dr As DataRow In dts.Tables(1).Rows
                If Bulto <> dr("CREFFW") Then
                    TotalPeso = TotalPeso + dr("QREFFW")
                    TotalBulto = TotalBulto + dr("QPSOBL")
                    Bulto = dr("CREFFW")
                End If
            Next
        End Sub
#End Region
    End Class
End Namespace

