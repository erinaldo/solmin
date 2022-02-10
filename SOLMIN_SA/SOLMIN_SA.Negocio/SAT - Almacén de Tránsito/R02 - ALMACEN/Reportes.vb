Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.OrdenCompra
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra

Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen

Namespace slnSOLMIN_SAT.Almacen.Reportes
    Public Class clsFiltros_ActividadAlmacen
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCCLNT As String = ""
        Private strTCMPCL As String = ""
        Private strCREFFW As String = ""
        Private dteFINIPR As Date
        Private dteFFINPR As Date
        Private strTUBRFR As String = ""
        Private strSTPING As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrCodigoCliente_CCLNT() As String
            Get
                Return strCCLNT
            End Get
            Set(ByVal value As String)
                strCCLNT = value
            End Set
        End Property

        Public Property pstrRazonSocial_TCMPCL() As String
            Get
                Return strTCMPCL
            End Get
            Set(ByVal value As String)
                strTCMPCL = value
            End Set
        End Property

        Public Property pstrBulto_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property

        Public Property pdteFechaInicio_FINIPR() As Date
            Get
                Return dteFINIPR
            End Get
            Set(ByVal value As Date)
                dteFINIPR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaInicio_FINIPR() As String
            Get
                Dim strResultado As String = ""
                If dteFINIPR.Year > 1 Then strResultado = dteFINIPR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaInicio_FINIPR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFINIPR.Year > 1 Then Integer.TryParse(dteFINIPR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaFin_FFINPR() As Date
            Get
                Return dteFFINPR
            End Get
            Set(ByVal value As Date)
                dteFFINPR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaFin_FFINPR() As String
            Get
                Dim strResultado As String = ""
                If dteFFINPR.Year > 1 Then strResultado = dteFFINPR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaFin_FFINPR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFFINPR.Year > 1 Then Integer.TryParse(dteFFINPR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
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

        Private _pstrCompania_CCMPN As String
        Public Property pstrCompania_CCMPN() As String
            Get
                Return _pstrCompania_CCMPN
            End Get
            Set(ByVal value As String)
                _pstrCompania_CCMPN = value
            End Set
        End Property


        Private _pstrDivision_CDVSN As String
        Public Property pstrDivision_CDVSN() As String
            Get
                Return _pstrDivision_CDVSN
            End Get
            Set(ByVal value As String)
                _pstrDivision_CDVSN = value
            End Set
        End Property


        Private _pdecPLanta As Decimal
        Public Property pdecPLanta() As Decimal
            Get
                Return _pdecPLanta
            End Get
            Set(ByVal value As Decimal)
                _pdecPLanta = value
            End Set
        End Property

#End Region
    End Class

    Public Class clsFiltros_InventarioAlmacen
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private dteFPROCE As Date
        Private strTUBRFR As String = ""
        Private strSTPING As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrRazonSocial_TCMPCL() As String
            Get
                Return strTCMPCL
            End Get
            Set(ByVal value As String)
                strTCMPCL = value
            End Set
        End Property

        Public Property pdteFechaProcesoInventario_FPROCE() As Date
            Get
                Return dteFPROCE
            End Get
            Set(ByVal value As Date)
                dteFPROCE = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaProcesoInventario_FPROCE() As String
            Get
                If dteFPROCE.Year > 1 Then
                    Return dteFPROCE.ToString("yyyyMMdd")
                Else
                    Return ""
                End If
            End Get
        End Property

        Public Property pstrUbicacionReferencial_TUBRFR() As String
            Get
                Return strTUBRFR
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
End Namespace

Namespace slnSOLMIN_SAT.Almacen.Reportes.Generador
    Public Class clsReportesAlmacen
        Inherits clsBasicClass
#Region " Atributos "
        Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        '---------------------'
        '-- Seguimiento O/C --'
        '---------------------'
        Public Function frptSegOCSegunFechaEntrega(ByVal objFiltro As TD_Qry_SegOC_L01, ByRef strMensajeError As String) As TipoDato_ResultaReporte
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
            Dim dtTemp As DataTable = Nothing
            Dim strTemp As String = ""
            Dim rptTemp As ReportDocument
            dtTemp = daoOrdenCompra.fdtListar_SegOCSegunFechaEntrega_L01(objSqlManager, objFiltro, strMensajeError)
            If dtTemp.Rows.Count > 0 Then
                rptTemp = New rptSegOCSegunFechaEntrega
                dtTemp.TableName = "SegOCPorFechaEntrega"
                rptTemp.SetDataSource(dtTemp)
                rptTemp.Refresh()
                ' Ingresamos parametros adicionales
                With objFiltro
                    If .pFORCMI_FechaOCInicial_Int > 0 And .pFORCMF_FechaOCFinal_Int > 0 Then
                        strTemp = " FECHA EMISION O/C:  Desde " & .pFORCMI_FechaOCInicial.ToString("dd/MM/yyyy") & " Hasta " & .pFORCMF_FechaOCFinal.ToString("dd/MM/yyyy")
                    Else
                        If .pFORCMI_FechaOCInicial_Int > 0 Then
                            strTemp = " FECHA EMISION O/C:  Desde " & .pFORCMI_FechaOCInicial.ToString("dd/MM/yyyy")
                        End If
                        If .pFORCMF_FechaOCFinal_Int > 0 Then
                            strTemp = " FECHA EMISION O/C:  Hasta " & .pFORCMF_FechaOCFinal.ToString("dd/MM/yyyy")
                        End If
                    End If
                    If .pFMPDMI_FechaCompInicial_Int > 0 And .pFMPDMF_FechaCompFinal_Int > 0 Then
                        If strTemp <> "" Then strTemp &= vbNewLine
                        strTemp &= " FECHA DE ENTREGA:  Desde " & .pFMPDMI_FechaCompInicial.ToString("dd/MM/yyyy") & " Hasta " & .pFMPDMF_FechaCompFinal.ToString("dd/MM/yyyy")
                    Else
                        If .pFMPDMI_FechaCompInicial_Int > 0 Then
                            If strTemp <> "" Then strTemp &= vbNewLine
                            strTemp &= " FECHA DE ENTREGA:  Desde " & .pFMPDMI_FechaCompInicial.ToString("dd/MM/yyyy")
                        End If
                        If .pFMPDMF_FechaCompFinal_Int > 0 Then
                            If strTemp <> "" Then strTemp &= vbNewLine
                            strTemp &= " FECHA DE ENTREGA:  Hasta " & .pFMPDMF_FechaCompFinal.ToString("dd/MM/yyyy")
                        End If
                    End If
                End With

                rptTemp.SetParameterValue("pUsuario", strUsuarioSistema)
                rptTemp.SetParameterValue("pRangoFecha", strTemp)
                ' Generamos el Nuevo Tipo de Datos
                objTemp.add_Table(dtTemp)
                objTemp.pReporte = rptTemp
            End If
            Return objTemp
        End Function

        'Public Function frptMovimientoProductosValor(ByVal objFiltro As TD_Qry_MovProValor_L01, ByRef strMensajeError As String) As TipoDato_ResultaReporte
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
        '    Dim dtTemp As DataTable = Nothing
        '    Dim strTemp As String = ""
        '    Dim rptTemp As ReportDocument
        '    dtTemp = daoOrdenCompra.fdtMovimientoProductosValorizado_R01(objSqlManager, objFiltro, strMensajeError)
        '    If dtTemp.Rows.Count > 0 Then
        '        rptTemp = New MovimientoProductoValorizado
        '        dtTemp.TableName = "dtMovProdValor"
        '        rptTemp.SetDataSource(dtTemp)
        '        rptTemp.Refresh()
        '        ' Ingresamos parametros adicionales
        '        rptTemp.SetParameterValue("pUsuario", strUsuarioSistema)
        '        rptTemp.SetParameterValue("pFechaInicial", objFiltro.pFECINI_FechaInicial_Dte)
        '        rptTemp.SetParameterValue("pFechaFinal", objFiltro.pFECFIN_FechaFinal_Dte)
        '        ' Generamos el Nuevo Tipo de Datos
        '        objTemp.add_Table(dtTemp)
        '        objTemp.pReporte = rptTemp
        '    End If
        '    Return objTemp
        'End Function

        '--------------------------'
        '-- Actividad de Almacen --'
        '--------------------------'
        Public Shared Function fdstWSActividadAlmacen(ByVal pCodigoCliente As String, ByVal pCompania As String, ByVal pDivision As String, ByVal pPlanta As Decimal, ByVal pBulto As String, ByVal pUbicacion As String, _
                                                      ByVal pFechaRecepcionInicio As String, ByVal pFechaRecepcionFinal As String, _
                                                      ByVal strTipoMovimiento As String, ByVal strServidor As String, ByVal strUsuario As String, _
                                                      ByVal strPassword As String, ByRef strMensajeError As String) As DataSet
            Dim strCadenaConexion As String = ""
            Dim dstResultado As DataSet = Nothing
            ' strCadenaConexion = My.Settings.Item(strServidor).ToString()
            'strCadenaConexion = Replace(Replace(strCadenaConexion, "UUUUUU", strUsuario), "PPPPPP", strPassword)
            'Dim objSqlManager As SqlManager = New SqlManager(strCadenaConexion)
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParamProcedure As Parameter = New Parameter
            ' objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParamProcedure.Add("IN_CCLNT", pCodigoCliente)
            objParamProcedure.Add("IN_CCMPN", pCompania)
            objParamProcedure.Add("IN_CDVSN", pDivision)
            objParamProcedure.Add("IN_CPLNDV", pPlanta)
            objParamProcedure.Add("IN_CREFFW", pBulto)
            objParamProcedure.Add("IN_TUBRFR", pUbicacion)
            objParamProcedure.Add("IN_FREFFW_I", pFechaRecepcionInicio)
            objParamProcedure.Add("IN_FREFFW_F", pFechaRecepcionFinal)
            objParamProcedure.Add("IN_STPING", strTipoMovimiento)
            Try
                dstResultado = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_ACTMEN_ALMACEN", objParamProcedure)
                dstResultado.Tables(0).TableName = "ActividadAlmacen"
                dstResultado.Tables(1).TableName = "ResumenAlmacen"
                Return dstResultado
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fdstWSActividadAlmacen >> de la clase << clsReportesAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : << Consulta Actividad de Almacén >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return New DataSet
            Finally
                objSqlManager = Nothing
                objParamProcedure = Nothing
            End Try
        End Function

        Public Function frptActividadAlmacen(ByVal objFiltro As clsFiltros_ActividadAlmacen, ByRef strMensajeError As String, _
                                                    ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String) As DataSet 'TipoDato_ResultaReporte
            'Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
            Dim dstTemp As DataSet = Nothing
            Dim rptTemp As ReportDocument

            With objFiltro
                dstTemp = fdstWSActividadAlmacen(.pstrCodigoCliente_CCLNT, .pstrCompania_CCMPN, .pstrDivision_CDVSN, .pdecPLanta, .pstrBulto_CREFFW, .pstrUbicacionReferencial_TUBRFR, .pintFechaInicio_FINIPR, _
                                                 .pintFechaFin_FFINPR, .pstrTipoMovimiento_STPING, strServidor, strUsuario, strPassword, strMensajeError)
            End With
            'If dstTemp.Tables.Count > 0 Then
            'rptTemp = New rptActividadAlmacen
            'rptTemp.SetDataSource(dstTemp)
            'rptTemp.Refresh()
            'rptTemp.SetParameterValue("pUsuario", strUsuario)
            'rptTemp.SetParameterValue("pFechaInicio", objFiltro.pdteFechaInicio_FINIPR)
            'rptTemp.SetParameterValue("pFechaFinal", objFiltro.pdteFechaFin_FFINPR)
            ' Generamos el Nuevo Tipo de Datos
            'objTemp.add_Tables(dstTemp)
            'objTemp.pReporte = rptTemp
            'End If
            Return dstTemp
        End Function

        '--------------------------'
        '-- Ingresos por Almacen --'
        '--------------------------'
        'Public Function frptIngresosPorAlmacen(ByVal objFiltro As clsFiltro_IngresoPorAlmacen, ByRef strMensajeError As String) As TipoDato_ResultaReporte
        '    Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
        '    Dim dstTemp As DataSet = Nothing
        '    Dim rptTemp As ReportDocument
        '    dstTemp = fdstResultadoConsulta(strMensajeError, "ALMA_INGRES_01", objFiltro.pintCodigoCliente_CCLNT, _
        '                                    objFiltro.pstrCodigoRecepcion_CREFFW, objFiltro.pstrFechaRecepcionInicio_FNum_FREFFW, _
        '                                    objFiltro.pstrFechaRecepcionFinal_FNum_FREFFW, objFiltro.pstrUbicacionReferencial_TUBRFR, _
        '                                    objFiltro.pSTPING_TipoMovimiento)
        '    If dstTemp.Tables.Count > 0 Then
        '        rptTemp = New rptIngresosPorAlmacen
        '        dstTemp.Tables(0).TableName = "IngresoPorAlmacen"
        '        rptTemp.SetDataSource(dstTemp)
        '        rptTemp.Refresh()
        '        ' Ingresamos parametros adicionales
        '        rptTemp.SetParameterValue("pUsuario", strUsuarioSistema)
        '        rptTemp.SetParameterValue("pFechaInicial", objFiltro.pdteFechaRecepcionInicio_FREFFW)
        '        rptTemp.SetParameterValue("pFechaFinal", objFiltro.pdteFechaRecepcionFinal_FREFFW)
        '        ' Generamos el Nuevo Tipo de Datos
        '        objTemp.add_Tables(dstTemp)
        '        objTemp.pReporte = rptTemp
        '    End If
        '    Return objTemp
        'End Function

        '------------------------'
        '-- Inventario Almacen --'
        '------------------------'
        'Public Function frptInventarioAlmacen(ByVal objFiltro As clsFiltros_InventarioAlmacen, ByRef strMensajeError As String) As TipoDato_ResultaReporte
        '    Dim dtTemp As DataTable = Nothing
        '    Dim rptTemp As ReportDocument
        '    Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
        '    Dim objSqlManager As SqlManager = New SqlManager()
        '    Dim objParamProcedure As Parameter = New Parameter
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    objParamProcedure.Add("IN_CCLNT", objFiltro.pintCodigoCliente_CCLNT)
        '    objParamProcedure.Add("IN_FINVE", objFiltro.pstrFechaProcesoInventario_FPROCE)
        '    objParamProcedure.Add("IN_TUBRFR", objFiltro.pstrUbicacionReferencial_TUBRFR)
        '    objParamProcedure.Add("IN_STPING", objFiltro.pstrTipoMovimiento_STPING)
        '    Try
        '        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_RZOL65_R01", objParamProcedure)
        '    Catch ex As Exception
        '        strMensajeError = "Error producido en la funcion : << frptInventarioAlmacen >> de la clase << clsReportesAlmacen >> " & vbNewLine & _
        '                          "Tipo de Consulta : << Inventario de Almacén de Tránsito >> " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '    Finally
        '        objSqlManager = Nothing
        '        objParamProcedure = Nothing
        '    End Try

        '    If dtTemp.Rows.Count > 0 Then
        '        rptTemp = New rptInventarioAlmacen
        '        dtTemp.TableName = "InventarioAlmacen"
        '        rptTemp.SetDataSource(dtTemp)
        '        rptTemp.Refresh()
        '        ' Ingresamos parametros adicionales
        '        rptTemp.SetParameterValue("pUsuario", strUsuarioSistema)
        '        rptTemp.SetParameterValue("pCliente", objFiltro.pintCodigoCliente_CCLNT)
        '        rptTemp.SetParameterValue("pRazonSocial", objFiltro.pstrRazonSocial_TCMPCL)
        '        rptTemp.SetParameterValue("pFecha", objFiltro.pdteFechaProcesoInventario_FPROCE)
        '        ' Generamos el Nuevo Tipo de Datos
        '        objTemp.add_Table(dtTemp)
        '        objTemp.pReporte = rptTemp
        '    End If
        '    Return objTemp
        'End Function

#End Region
    End Class
End Namespace