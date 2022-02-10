Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SDS.DAO.Almacen
    Public Class cl_Almacen
        Inherits BasicClass
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        'Private intCCLNT As Int64 = 0
        'Private strCFMCLR As String = ""
        'Private strTFMCLR As String = ""
        'Private strCUSCRT As String = ""
#End Region
#Region " Propiedades "
        'Public Property pintCodigoCliente_CCLNT() As Int64
        '    Get
        '        Return intCCLNT
        '    End Get
        '    Set(ByVal value As Int64)
        '        intCCLNT = value
        '    End Set
        'End Property

        'Public Property pstrCodigoFamilia_CFMCLR() As String
        '    Get
        '        Return strCFMCLR
        '    End Get
        '    Set(ByVal value As String)
        '        strCFMCLR = value
        '    End Set
        'End Property

        'Public Property pstrDescripcionFamilia_TFMCLR() As String
        '    Get
        '        Return strTFMCLR
        '    End Get
        '    Set(ByVal value As String)
        '        strTFMCLR = value
        '    End Set
        'End Property

        'Public Property pstrUsuario_CUSCRT() As String
        '    Get
        '        Return strCUSCRT
        '    End Get
        '    Set(ByVal value As String)
        '        strCUSCRT = value
        '    End Set
        'End Property
#End Region
#Region " Funciones y Procedimientos "
        'Private Shared Function fblnRegistrarFamilia(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
        '                                             ByVal objParametros As Parameter) As Boolean
        '    Dim blnResultado As Boolean = True
        '    Try
        '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_FAMILIA_INS", objParametros)
        '    Catch ex As Exception
        '        strMensajeError = "Error producido en la funcion : << fblnRegistrarFamilia >> de la clase << Familia >> " & vbNewLine & _
        '                          "Proceso : << SP_SOLMIN_SA_SDS_FAMILIA_INS >> " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '        blnResultado = False
        '    Finally
        '        objSqlManager = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return blnResultado
        'End Function

        'Private Shared Function fblnEliminarFamilia(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
        '                                            ByVal objParametros As Parameter) As Boolean
        '    Dim blnResultado As Boolean = True
        '    Try
        '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_FAMILIA_DEL", objParametros)
        '    Catch ex As Exception
        '        strMensajeError = "Error producido en la funcion : << fblnEliminarFamilia >> de la clase << Familia >> " & vbNewLine & _
        '                          "Proceso : << SP_SOLMIN_SA_SDS_FAMILIA_DEL >> " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '        blnResultado = False
        '    Finally
        '        objSqlManager = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return blnResultado
        'End Function
#End Region
#Region " Métodos "
        Public Shared Function fdtBuscar_TipoAlmacen(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtBusqueda_Informacion(objSqlManager, strMensajeError, "GENE_TIPALM_01", strCadenaBusqueda)
            dtResultado.TableName = "Tipo de Almacén"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_ZonasAlmacen(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strTipoAlmacen As String, _
                                                      ByVal strAlmacen As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtBusqueda_Informacion(objSqlManager, strMensajeError, "GENE_ZONALM_01", strTipoAlmacen, strAlmacen, strCadenaBusqueda)
            dtResultado.TableName = "Zonas de Almacén"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Almacen(ByVal objSqlManager As SqlManager, ByRef strMensajeError As String, ByVal strTipoAlmacen As String, _
                                                 ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtBusqueda_Informacion(objSqlManager, strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strCadenaBusqueda)
            dtResultado.TableName = "Almacenes"
            Return dtResultado
        End Function

        'Public Shared Function fblnRegistrar_Familia(ByVal objFamilia As Familia, ByRef strMensajeError As String) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    With objFamilia
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
        '        objParametros.Add("IN_TFMCLR", .pstrDescripcionFamilia_TFMCLR)
        '        objParametros.Add("IN_USUARIO", .pstrUsuario_CUSCRT)
        '    End With
        '    Return fblnRegistrarFamilia(strMensajeError, objSqlManager, objParametros)
        'End Function

        'Public Shared Function fblnRegistrar_Familia(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
        '                                             ByVal objFamilia As Familia, ByRef strMensajeError As String) As Boolean
        '    ' Método utilizado solo para consultas de moviles
        '    Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
        '    ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
        '    ConnStr = ConnStr.Replace("PPPPPP", strPassword)
        '    Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
        '    Dim objParametros As Parameter = Nothing
        '    Dim blnResultado As Boolean = True
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    With objFamilia
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
        '        objParametros.Add("IN_TFMCLR", .pstrDescripcionFamilia_TFMCLR)
        '        objParametros.Add("IN_USUARIO", .pstrUsuario_CUSCRT)
        '    End With
        '    Return fblnRegistrarFamilia(strMensajeError, objSqlManager, objParametros)
        'End Function

        'Public Shared Function fblnEliminar_Familia(ByVal objFamilia As Familia, ByRef strMensajeError As String) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    With objFamilia
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
        '        objParametros.Add("IN_USUARIO", .pstrUsuario_CUSCRT)
        '    End With
        '    Return fblnEliminarFamilia(strMensajeError, objSqlManager, objParametros)
        'End Function

        'Public Shared Function fblnEliminar_Familia(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
        '                                            ByVal objFamilia As Familia, ByRef strMensajeError As String) As Boolean
        '    ' Método utilizado solo para consultas de moviles
        '    Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
        '    ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
        '    ConnStr = ConnStr.Replace("PPPPPP", strPassword)
        '    Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
        '    Dim objParametros As Parameter = Nothing
        '    Dim blnResultado As Boolean = True
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    With objFamilia
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CFMCLR", .pstrCodigoFamilia_CFMCLR)
        '        objParametros.Add("IN_USUARIO", .pstrUsuario_CUSCRT)
        '    End With
        '    Return fblnEliminarFamilia(strMensajeError, objSqlManager, objParametros)
        'End Function
#End Region
    End Class
End Namespace