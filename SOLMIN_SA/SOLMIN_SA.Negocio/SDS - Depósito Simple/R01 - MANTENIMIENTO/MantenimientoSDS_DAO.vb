Namespace slnSOLMIN_SDS.MantenimientoSDS
    Public Class clsPrimaryKey_Chofer
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNBRVCH As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVCH() As String
            Get
                Return strNBRVCH
            End Get
            Set(ByVal value As String)
                strNBRVCH = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsPrimaryKey_Camion
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNPLCCM As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NPLCCM() As String
            Get
                Return strNPLCCM
            End Get
            Set(ByVal value As String)
                strNPLCCM = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsPrimaryKey_Mercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strCMRCLR As String = ""
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

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrCodigoGrupo_CGRCLR() As String
            Get
                Return strCGRCLR
            End Get
            Set(ByVal value As String)
                strCGRCLR = value
            End Set
        End Property

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsChofer
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNBRVCH As String = ""
        Private strNLELCH As String = ""
        Private strNTRMNL As String = ""
        Private strTNMBCH As String = ""
        Private strSESTCH As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVCH() As String
            Get
                Return strNBRVCH
            End Get
            Set(ByVal value As String)
                strNBRVCH = value
            End Set
        End Property

        Public Property pstrDocumentoIdentidad_NLELCH() As String
            Get
                Return strNLELCH
            End Get
            Set(ByVal value As String)
                strNLELCH = value
            End Set
        End Property

        Public Property pstrNroTerminalUsado_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property

        Public Property pstrNombreChofer_TNMBCH() As String
            Get
                Return strTNMBCH
            End Get
            Set(ByVal value As String)
                strTNMBCH = value
            End Set
        End Property

        Public Property pstrEstadoChofer_SESTCH() As String
            Get
                Return strSESTCH
            End Get
            Set(ByVal value As String)
                strSESTCH = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsCamion
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNPLCCM As String = ""

        Private decPTRCM As Decimal = 0.0
        Private intNANOCM As Integer = 0
        Private strTMRCCM As String = ""
        Private strNMTRCM As String = ""
        Private strSESTCM As String = ""
        Private strNROPLA As String = ""
        Private strNBRVC1 As String = ""
        Private strNPLCAC As String = ""
        Private intNTRNLL As Integer = 0
        Private dteFASGTR As Date
        Private intHASGTR As Int16 = 0
        Private strNTRMNL As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NPLCCM()
            Get
                Return strNPLCCM
            End Get
            Set(ByVal value)
                strNPLCCM = value
            End Set
        End Property

        Public Property pdecCantidadPesoTara_PTRCM() As Decimal
            Get
                Return decPTRCM
            End Get
            Set(ByVal value As Decimal)
                decPTRCM = value
            End Set
        End Property

        Public Property pintNroAnioCamion_NANOCM() As Integer
            Get
                Return intNANOCM
            End Get
            Set(ByVal value As Integer)
                intNANOCM = value
            End Set
        End Property

        Public Property pstrMarcaCamion_TMRCCM() As String
            Get
                Return strTMRCCM
            End Get
            Set(ByVal value As String)
                strTMRCCM = value
            End Set
        End Property

        Public Property pstrNroMotorCamion_NMTRCM() As String
            Get
                Return strNMTRCM
            End Get
            Set(ByVal value As String)
                strNMTRCM = value
            End Set
        End Property

        Public Property pstrEstadoCamion_SESTCM() As String
            Get
                Return strSESTCM
            End Get
            Set(ByVal value As String)
                strSESTCM = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NROPLA() As String
            Get
                Return strNROPLA
            End Get
            Set(ByVal value As String)
                strNROPLA = value
            End Set
        End Property

        Public Property pstrNroBrevete_NBRVC1() As String
            Get
                Return strNBRVC1
            End Get
            Set(ByVal value As String)
                strNBRVC1 = value
            End Set
        End Property

        Public Property pstrNroAcoplado_NPLCAC() As String
            Get
                Return strNPLCAC
            End Get
            Set(ByVal value As String)
                strNPLCAC = value
            End Set
        End Property

        Public Property pintNroTurnoLLegada_NTRNLL() As Integer
            Get
                Return intNTRNLL
            End Get
            Set(ByVal value As Integer)
                intNTRNLL = value
            End Set
        End Property

        Public Property pdteFechaAsignacionTurno_FASGTR() As Date
            Get
                Return dteFASGTR
            End Get
            Set(ByVal value As Date)
                dteFASGTR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaAsignacionTurno_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If dteFASGTR.Year > 1 Then strResultado = dteFASGTR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaAsignacionTurno_FASGTR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFASGTR.Year > 1 Then Integer.TryParse(dteFASGTR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pintHoraAsignacionTurno_HASGTR() As Int16
            Get
                Return intHASGTR
            End Get
            Set(ByVal value As Int16)
                intHASGTR = value
            End Set
        End Property

        Public Property pstrNroTerminalUsado_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFamilia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strTFMCLR As String = ""
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

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrDescripcionFamilia_TFMCLR() As String
            Get
                Return strTFMCLR
            End Get
            Set(ByVal value As String)
                strTFMCLR = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsGrupo
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strTGRCLR As String = ""
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

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrCodigoGrupo_CGRCLR() As String
            Get
                Return strCGRCLR
            End Get
            Set(ByVal value As String)
                strCGRCLR = value
            End Set
        End Property

        Public Property pstrDescripcionGrupo_TGRCLR() As String
            Get
                Return strTGRCLR
            End Get
            Set(ByVal value As String)
                strTGRCLR = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsMercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCMRCLR As String = ""
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strCMRCRR As String = ""
        Private strCMRCD As String = ""
        Private strTMRCD2 As String = ""
        Private strTMRCD3 As String = ""
        Private intCPRVCL As Int64 = 0
        Private intCMNCT As Integer = 0
        Private decQIMCT As Decimal = 0.0
        Private decQIMCTP As Decimal = 0.0
        Private strMARCRE As String = ""
        Private decIMVTA As Decimal = 0.0
        Private decIMVTAS As Decimal = 0.0
        Private decIMVLM2 As Decimal = 0.0
        Private decPDSCTO As Decimal = 0.0
        Private strTMRCTR As String = ""
        Private strUBICA1 As String = ""
        Private strTOBSRV As String = ""
        Private decQMRSRC As Decimal = 0.0
        Private decQMRSRP As Decimal = 0.0
        Private decQMRODC As Decimal = 0.0
        Private decQMRODP As Decimal = 0.0
        Private decQLRGMR As Decimal = 0.0
        Private decQANCMR As Decimal = 0.0
        Private decQALTMR As Decimal = 0.0
        Private decQARMT2 As Decimal = 0.0
        Private decQARMT3 As Decimal = 0.0
        Private decQPSODC As Decimal = 0.0
        Private decQTMPCR As Decimal = 0.0
        Private decQTMPDS As Decimal = 0.0
        Private strCUNCNC As String = ""
        Private dteFVNCMR As Date
        Private strCPRFMR As String = ""
        Private strCINFMR As String = ""
        Private strCROTMR As String = ""
        Private strCAPIMR As String = ""
        Private strDUN14 As String = ""
        Private strEAN13 As String = ""

        Private decQICOPS As Decimal = 0.0
        Private decQMRPRD As Decimal = 0.0
        Private decQVOLEQ As Decimal = 0.0
        Private strCUNCNI As String = ""
        Private strFPUWEB As String = ""
        Private dteFINVRN As Date

        Public CPTDAR_PartidaArancelaria As String = ""

        Private strSESTRG As String = ""
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

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrCodigoGrupo_CGRCLR() As String
            Get
                Return strCGRCLR
            End Get
            Set(ByVal value As String)
                strCGRCLR = value
            End Set
        End Property

        Public Property pstrCodigoMercaderiaReemplazo_CMRCRR() As String
            Get
                Return strCMRCRR
            End Get
            Set(ByVal value As String)
                strCMRCRR = value
            End Set
        End Property

        Public Property pstrCodigoRANSA_CMRCD() As String
            Get
                Return strCMRCD
            End Get
            Set(ByVal value As String)
                strCMRCD = value
            End Set
        End Property

        Public Property pstrDescripcion_TMRCD2() As String
            Get
                Return strTMRCD2
            End Get
            Set(ByVal value As String)
                strTMRCD2 = value
            End Set
        End Property

        Public Property pstrDescripcion_TMRCD3() As String
            Get
                Return strTMRCD3
            End Get
            Set(ByVal value As String)
                strTMRCD3 = value
            End Set
        End Property

        Public Property pintProveedor_CPRVCL() As Int64
            Get
                Return intCPRVCL
            End Get
            Set(ByVal value As Int64)
                intCPRVCL = value
            End Set
        End Property

        Public Property pintCodigoMoneda_CMNCT() As Integer
            Get
                Return intCMNCT
            End Get
            Set(ByVal value As Integer)
                intCMNCT = value
            End Set
        End Property

        Public Property pdecImporteCosto_QIMCT() As Decimal
            Get
                Return decQIMCT
            End Get
            Set(ByVal value As Decimal)
                decQIMCT = value
            End Set
        End Property

        Public Property pdecImporteCostoPromedio_QIMCTP() As Decimal
            Get
                Return decQIMCTP
            End Get
            Set(ByVal value As Decimal)
                decQIMCTP = value
            End Set
        End Property

        Public Property pstrMarcaReembolso_MARCRE() As String
            Get
                Return strMARCRE
            End Get
            Set(ByVal value As String)
                strMARCRE = value
            End Set
        End Property

        Public Property pblnMarcaReembolso_MARCRE() As Boolean
            Get
                Dim blnResultado As Boolean = False
                If strMARCRE = "X" Then blnResultado = True
                Return blnResultado
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    strMARCRE = "X"
                Else
                    strMARCRE = ""
                End If
            End Set
        End Property

        Public Property pdecImporteVentaDolar_IMVTAD() As Decimal
            Get
                Return decIMVTA
            End Get
            Set(ByVal value As Decimal)
                decIMVTA = value
            End Set
        End Property

        Public Property pdecImporteVentaDolar_IMVTAS() As Decimal
            Get
                Return decIMVTAS
            End Get
            Set(ByVal value As Decimal)
                decIMVTAS = value
            End Set
        End Property

        Public Property pdecImportePorMts2_IMVLM2() As Decimal
            Get
                Return decIMVLM2
            End Get
            Set(ByVal value As Decimal)
                decIMVLM2 = value
            End Set
        End Property

        Public Property pdecPorcentajeDescuento_PDSCTO() As Decimal
            Get
                Return decPDSCTO
            End Get
            Set(ByVal value As Decimal)
                decPDSCTO = value
            End Set
        End Property

        Public Property pstrMarcaModelo_TMRCTR() As String
            Get
                Return strTMRCTR
            End Get
            Set(ByVal value As String)
                strTMRCTR = value
            End Set
        End Property

        Public Property pstrUbicacion_UBICA1() As String
            Get
                Return strUBICA1
            End Get
            Set(ByVal value As String)
                strUBICA1 = value
            End Set
        End Property

        Public Property pstrObservacion_TOBSRV() As String
            Get
                Return strTOBSRV
            End Get
            Set(ByVal value As String)
                strTOBSRV = value
            End Set
        End Property

        Public Property pdecCantidadMinimaReqServicio_QMRSRC() As Decimal
            Get
                Return decQMRSRC
            End Get
            Set(ByVal value As Decimal)
                decQMRSRC = value
            End Set
        End Property

        Public Property pdecPesoMinimoReqServicio_QMRSRP() As Decimal
            Get
                Return decQMRSRP
            End Get
            Set(ByVal value As Decimal)
                decQMRSRP = value
            End Set
        End Property

        Public Property pdecCantidadMercaderiaPtoReorden_QMRODC() As Decimal
            Get
                Return decQMRODC
            End Get
            Set(ByVal value As Decimal)
                decQMRODC = value
            End Set
        End Property

        Public Property pdecPesoMercaderiaPtoReorden_QMRODP() As Decimal
            Get
                Return decQMRODP
            End Get
            Set(ByVal value As Decimal)
                decQMRODP = value
            End Set
        End Property

        Public Property pdecLargoMercaderia_QLRGMR() As Decimal
            Get
                Return decQLRGMR
            End Get
            Set(ByVal value As Decimal)
                decQLRGMR = value
            End Set
        End Property

        Public Property pdecAnchoMercaderia_QANCMR() As Decimal
            Get
                Return decQANCMR
            End Get
            Set(ByVal value As Decimal)
                decQANCMR = value
            End Set
        End Property

        Public Property pdecAlturaMercaderia_QALTMR() As Decimal
            Get
                Return decQALTMR
            End Get
            Set(ByVal value As Decimal)
                decQALTMR = value
            End Set
        End Property

        Public Property pdecAreaMts2_QARMT2() As Decimal
            Get
                Return decQARMT2
            End Get
            Set(ByVal value As Decimal)
                decQARMT2 = value
            End Set
        End Property

        Public Property pdecVolumenMts3_QARMT3() As Decimal
            Get
                Return decQARMT3
            End Get
            Set(ByVal value As Decimal)
                decQARMT3 = value
            End Set
        End Property

        Public Property pdecCantidadPesoDeclarado_QPSODC() As Decimal
            Get
                Return decQPSODC
            End Get
            Set(ByVal value As Decimal)
                decQPSODC = value
            End Set
        End Property

        Public Property pdecTiempoCargaMercaderia_QTMPCR() As Decimal
            Get
                Return decQTMPCR
            End Get
            Set(ByVal value As Decimal)
                decQTMPCR = value
            End Set
        End Property

        Public Property pdecTiempoDesargaMercaderia_QTMPDS() As Decimal
            Get
                Return decQTMPDS
            End Get
            Set(ByVal value As Decimal)
                decQTMPDS = value
            End Set
        End Property

        Public Property pstrUnidad_CUNCNC() As String
            Get
                Return strCUNCNC
            End Get
            Set(ByVal value As String)
                strCUNCNC = value
            End Set
        End Property

        Public Property pdteFechaVencimiento_FVNCMR() As Date
            Get
                Return dteFVNCMR
            End Get
            Set(ByVal value As Date)
                dteFVNCMR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaVencimiento_FVNCMR() As String
            Get
                Dim strResultado As String = ""
                If dteFVNCMR.Year > 1 Then strResultado = dteFVNCMR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaVencimiento_FVNCMR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFVNCMR.Year > 1 Then Integer.TryParse(dteFVNCMR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrCodigoPerfumancia_CPRFMR() As String
            Get
                Return strCPRFMR
            End Get
            Set(ByVal value As String)
                strCPRFMR = value
            End Set
        End Property

        Public Property pstrCodigoInflamabilidad_CINFMR() As String
            Get
                Return strCINFMR
            End Get
            Set(ByVal value As String)
                strCINFMR = value
            End Set
        End Property

        Public Property pstrCodigoRotacion_CROTMR() As String
            Get
                Return strCROTMR
            End Get
            Set(ByVal value As String)
                strCROTMR = value
            End Set
        End Property

        Public Property pstrCodigoApilabilidad_CAPIMR() As String
            Get
                Return strCAPIMR
            End Get
            Set(ByVal value As String)
                strCAPIMR = value
            End Set
        End Property

        Public Property pstrCodigoDUN14() As String
            Get
                Return strDUN14
            End Get
            Set(ByVal value As String)
                strDUN14 = value
            End Set
        End Property

        Public Property pstrCodigoEAN13() As String
            Get
                Return strEAN13
            End Get
            Set(ByVal value As String)
                strEAN13 = value
            End Set
        End Property

        Public Property pdecImporteCostoPromedioSoles_QICOPS() As Decimal
            Get
                Return decQICOPS
            End Get
            Set(ByVal value As Decimal)
                decQICOPS = value
            End Set
        End Property

        Public Property pdecCantidadMinimaProducir_QMRPRD() As Decimal
            Get
                Return decQMRPRD
            End Get
            Set(ByVal value As Decimal)
                decQMRPRD = value
            End Set
        End Property

        Public Property pdecVolumenEquivalente_QVOLEQ() As Decimal
            Get
                Return decQVOLEQ
            End Get
            Set(ByVal value As Decimal)
                decQVOLEQ = value
            End Set
        End Property

        Public Property pstrUnidadInventario_CUNCNI() As String
            Get
                Return strCUNCNI
            End Get
            Set(ByVal value As String)
                strCUNCNI = value
            End Set
        End Property

        Public Property pstrStatusPublicacionWEB_FPUWEB() As String
            Get
                Return strFPUWEB
            End Get
            Set(ByVal value As String)
                If value = "S" Then strFPUWEB = value
                If Not value = "S" Then strFPUWEB = "N"
            End Set
        End Property



        Private _FUNCTL As String
        Public Property FUNCTL() As String
            Get
                Return _FUNCTL
            End Get
            Set(ByVal value As String)
                _FUNCTL = value
            End Set
        End Property

        Public Property pblnStatusPublicacionWEB_FPUWEB() As Boolean
            Get
                Dim blnResultado As Boolean = False
                If strFPUWEB <> "N" Then blnResultado = True
                Return blnResultado
            End Get
            Set(ByVal value As Boolean)
                If value Then strFPUWEB = "S"
                If Not value Then strFPUWEB = "N"
            End Set
        End Property

        Public Property pdteFechaInventario_FINVRN() As Date
            Get
                Return dteFINVRN
            End Get
            Set(ByVal value As Date)
                dteFINVRN = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaInventario_FINVRN() As String
            Get
                Dim strResultado As String = ""
                If dteFINVRN.Year > 1 Then strResultado = dteFINVRN.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaInventario_FINVRN() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFINVRN.Year > 1 Then Integer.TryParse(dteFINVRN.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrSituacion_SESTRG() As String
            Get
                Return strSESTRG
            End Get
            Set(ByVal value As String)
                strSESTRG = value
            End Set
        End Property


        Private _SCNTSR_MarcaControlSerie As String
        Public Property SCNTSR_MarcaControlSerie() As String
            Get
                Return _SCNTSR_MarcaControlSerie
            End Get
            Set(ByVal value As String)
                _SCNTSR_MarcaControlSerie = value
            End Set
        End Property


  

#End Region
    End Class
End Namespace