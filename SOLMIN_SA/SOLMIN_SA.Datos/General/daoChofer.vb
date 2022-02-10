Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Namespace slnSOLMIN.DAO
    Public Class daoChofer

        Inherits daBase(Of beChofer)

#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNBRVCH As String = ""
        Private strTNMBCH As String = ""
        Private intNLELCH As Int32 = 0
        Private strNTRMNL As String = ""
        Private strSESTCH As String = ""
        Private strSTACTU As String = "S"
        '-- Seguridad
        Private strUSER As String = ""
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

        Public Property pstrChofer_TNMBCH() As String
            Get
                Return strTNMBCH
            End Get
            Set(ByVal value As String)
                strTNMBCH = value
            End Set
        End Property

        Public Property pintNroDocIdentidadChofer_NLELCH() As Int32
            Get
                Return intNLELCH
            End Get
            Set(ByVal value As Int32)
                intNLELCH = value
            End Set
        End Property

        Public Property pstrNroTerminal_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property

        Public Property pStatusChofer_SESTCH() As String
            Get
                Return strSESTCH
            End Get
            Set(ByVal value As String)
                strSESTCH = value
            End Set
        End Property

        Public ReadOnly Property pstrStatusActualizarSiExiste_STACTU() As String
            Get
                Return strSTACTU
            End Get
        End Property

        Public Property pblnStatusActualizarSiExiste_STACTU() As Boolean
            Get
                Dim blnStatus As Boolean = False
                If strSTACTU = "S" Then blnStatus = True
                Return blnStatus
            End Get
            Set(ByVal value As Boolean)
                Select Case value
                    Case True : strSTACTU = "S"
                    Case False : strSTACTU = "N"
                End Select
            End Set
        End Property

        '-- Seguridad
        Public Property pstrUsuario() As String
            Get
                Return strUSER
            End Get
            Set(ByVal value As String)
                strUSER = value
            End Set
        End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal oChofer As daoChofer, ByRef strMensajeError As String) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CTRSP", oChofer.pintEmpresaTransporte_CTRSP)
                .Add("IN_NBRVCH", oChofer.pstrNroBrevete_NBRVCH)
                .Add("IN_NLELCH", oChofer.pintNroDocIdentidadChofer_NLELCH)
                .Add("IN_NTRMNL", oChofer.pstrNroTerminal_NTRMNL)
                .Add("IN_TNMBCH", oChofer.pstrChofer_TNMBCH)
                .Add("IN_SESTCH", oChofer.pStatusChofer_SESTCH)
                .Add("IN_STACTU", oChofer.pstrStatusActualizarSiExiste_STACTU)
                '-- Seguridad
                .Add("IN_USUARI", oChofer.pstrUsuario)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_CHOFER_RZIK03_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoChofer >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_CHOFER_RZIK03_INS >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

      

#End Region

        Public Overrides Sub SetStoredprocedures()

        End Sub

        Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beChofer)

        End Sub
    End Class
End Namespace