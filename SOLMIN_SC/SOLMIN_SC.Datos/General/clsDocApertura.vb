Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsDocApertura
    Public Function Lista_Doc_Apertura() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DOC_APERTURA", Nothing)
        Return dt
    End Function

    Public Function Lista_Documento() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DOCUMENTO", Nothing)
        Return dt
    End Function

    Public Sub Actualizar_Documentos_Adjunto(ByVal obeDocumentoAdjunto As beDocCargaInternacional)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDocumentoAdjunto.PNNORSCI)
        lobjParams.Add("PNNDOCIN", obeDocumentoAdjunto.PNNDOCIN)
        lobjParams.Add("PNNCRRDC", obeDocumentoAdjunto.PNNCRRDC)
        lobjParams.Add("PSNDOCLI", obeDocumentoAdjunto.PSNDOCLI)
        lobjParams.Add("PNFECORG", obeDocumentoAdjunto.PNFECORG)
        lobjParams.Add("PNFECCOP", obeDocumentoAdjunto.PNFECCOP)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DOCUMENTOS_ADJUNTOS", lobjParams)

    End Sub

 
    Public Sub Borrar_Documentos_Adjunto_Item(ByVal obeDocumentoAdjunto As beDocCargaInternacional)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDocumentoAdjunto.PNNORSCI)
        lobjParams.Add("PNNDOCIN", obeDocumentoAdjunto.PNNDOCIN)
        lobjParams.Add("PNNCRRDC", obeDocumentoAdjunto.PNNCRRDC)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_BORRAR_DOCUMENTOS_ADJUNTOS_X_ITEM", lobjParams)
    End Sub

    Public Function Lista_Doc_Embarque(ByVal PNCCLNT As Double, ByVal PNNORSCI As Double) As List(Of beDocCargaInternacional)
        Dim dt As DataTable
        Dim oListDocCargaInternacuional As New List(Of beDocCargaInternacional)
        Dim obeDocCargaInternacional_BE As beDocCargaInternacional
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_EMBARQUE", lobjParams)
        For Each Item As DataRow In dt.Rows
            obeDocCargaInternacional_BE = New beDocCargaInternacional
            obeDocCargaInternacional_BE.PNNDOCIN = Item("NDOCIN")
            obeDocCargaInternacional_BE.PSNDOCLI = Item("NDOCLI")
            obeDocCargaInternacional_BE.PSFCDCOR = Item("FCDCOR").ToString.Trim
            obeDocCargaInternacional_BE.PSFCDCCP = Item("FCDCCP").ToString.Trim
            obeDocCargaInternacional_BE.PNNORSCI = Item("NORSCI")
            obeDocCargaInternacional_BE.PNNCRRDC = Item("NCRRDC")
            obeDocCargaInternacional_BE.PNNMRGIM = Item("NMRGIM")
            obeDocCargaInternacional_BE.PNEXISTS = 1
            oListDocCargaInternacuional.Add(obeDocCargaInternacional_BE)
        Next
        Return oListDocCargaInternacuional
    End Function


    Public Sub Mant_Doc_Forol(ByVal obeDetCargaInternacional_BE As beDetalleCargaInternacional)

        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        lobjParams.Add("PNNORSCI", obeDetCargaInternacional_BE.PNNORSCI)
        lobjParams.Add("PNNTPODT", obeDetCargaInternacional_BE.PNNTPODT)
        lobjParams.Add("PNNCODRG", obeDetCargaInternacional_BE.PNNCODRG)
        lobjParams.Add("PSSORDOC", obeDetCargaInternacional_BE.PSSORDOC)
        lobjParams.Add("PNQCANTI", obeDetCargaInternacional_BE.PNQCANTI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        oSqlMan.ExecuteNonQuery("SP_SOLSC_MANT_DOC_FOROL", lobjParams)

    End Sub


    Public Sub Borrar_Doc_Forol(ByVal pdblEmbarque As Double, ByVal pdblCodDoc As Double)

        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNNTPODT", pdblCodDoc)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_BORRAR_DOC_FOROL", lobjParams)
         
    End Sub


    Public Function Lista_Doc_Forol(ByVal pdblEmbarque As Double, ByVal pdblCodDoc As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNNTPODT", pdblCodDoc)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_FOROL", lobjParams)
        Return dt
    End Function

    Public Function Lista_Documentos_Costo_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_COSTO_EMBARQUE", lobjParams)
        Return dt
    End Function


    Public Sub Grabar_Documentos_Costos_Embarque(ByVal obeDocumentoCosto As beDocumentoCostos)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNNORSCI", obeDocumentoCosto.PNNORSCI)
        lobjParams.Add("PNNDOCIN", obeDocumentoCosto.PNNDOCIN)
        lobjParams.Add("PNNCRRDC", obeDocumentoCosto.PNNCRRDC)
        lobjParams.Add("PNIVLORG", obeDocumentoCosto.PNIVLORG)
        lobjParams.Add("PNIVLDOL", obeDocumentoCosto.PNIVLDOL)
        lobjParams.Add("PNCMNDA1", obeDocumentoCosto.PNCMNDA1)
        lobjParams.Add("PSNMONOC", obeDocumentoCosto.PSNMONOC)
        lobjParams.Add("PSNDOCUM", obeDocumentoCosto.PSNDOCUM)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DOCUMENTO_ADJUNTO_COSTOS", lobjParams)
      
    End Sub

    Public Sub Grabar_Documentos_Costos_Embarque_DUA(ByVal obeDocumentoCosto As beDocumentoCostos)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNNORSCI", obeDocumentoCosto.PNNORSCI)
        lobjParams.Add("PNNDOCIN", obeDocumentoCosto.PNNDOCIN)
        lobjParams.Add("PNNCRRDC", obeDocumentoCosto.PNNCRRDC)
        lobjParams.Add("PNIVLORG", obeDocumentoCosto.PNIVLORG)
        lobjParams.Add("PNIVLDOL", obeDocumentoCosto.PNIVLDOL)
        lobjParams.Add("PNCMNDA1", obeDocumentoCosto.PNCMNDA1)
        lobjParams.Add("PSNMONOC", obeDocumentoCosto.PSNMONOC)
        lobjParams.Add("PSNDOCUM", obeDocumentoCosto.PSNDOCUM)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DOCUMENTO_ADJUNTO_COSTOS_DUA", lobjParams)

    End Sub



    Public Function Lista_Concepto_Costo_Embarque(ByVal pstrDescripcion As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCVARBL", pstrDescripcion)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
        Return dt
    End Function

    

    Public Sub Guardar_Costos_Totales_Embarque(ByVal PSTIPO As String, ByVal obeCostoTotalEmbarque As beCostoTotalEmbarque)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("TIPO", PSTIPO)
        lobjParams.Add("PNNORSCI", obeCostoTotalEmbarque.PNNORSCI)
        lobjParams.Add("PSCODVAR", obeCostoTotalEmbarque.PSCODVAR)
        lobjParams.Add("PNIVLORG", obeCostoTotalEmbarque.PNIVLORG)
        lobjParams.Add("PNIVLDOL", obeCostoTotalEmbarque.PNIVLDOL)
        lobjParams.Add("PNCMNDA1", obeCostoTotalEmbarque.PNCMNDA1)
        lobjParams.Add("PSNMONOC", obeCostoTotalEmbarque.PSNMONOC)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_COSTO_EMBARQUE", lobjParams)
    End Sub


   

    Public Function Lista_Costos_Totales_Embarque(ByVal pdblEmbarque As Double) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_COSTOS_EMBARQUE", lobjParams)
        ds.Tables(0).TableName = "dtCosto"
        ds.Tables(1).TableName = "dtDocumentoCosto"
        Return ds
    End Function



    '
    Public Function Lista_Costos_Distribuidos_Embarque(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTOS_DISTRIBUIDOS_EMBARQUE", lobjParams)
        Return dt
    End Function



    Public Function Lista_Costos_Totales_Embarque_ALL(ByVal Embarques_List As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSEMBARQUES", Embarques_List)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTOS_EMBARQUE_TODOS", lobjParams)
        Return dt
    End Function


    Public Function Lista_Costos_Totales_Embarque_ABB(ByVal pdblEmbarque As Double) As DataSet
        Dim oDs As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        oDs = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_COSTOS_EMBARQUE_ABB", lobjParams)
        Return oDs
    End Function

    Public Function Lista_Costos_Totales_Embarque_ABB_Cambio_CheckPoint(ByVal pdblEmbarque As Double) As DataSet
        Dim oDs As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        oDs = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_COSTOS_EMBARQUE_ABB_X_CAMBIO_CHECKPOINT", lobjParams)
        Return oDs
    End Function


    Public Sub Guardar_Documentos_X_Costo_Total_Embarque(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String, ByVal pdblCodDocumento As Double, ByVal dblNrCorrelativo As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSCODVAR", pstrCodVariable)
        lobjParams.Add("PNNDOCIN", pdblCodDocumento)
        lobjParams.Add("PNNCRRDC", dblNrCorrelativo)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_DOC_COSTO_EMBARQUE", lobjParams)
    End Sub

    Public Function Lista_Documentos_Costo_X_Costo_Total_Embarque(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSCODVAR", pstrCodVariable)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DOC_COSTOS_X_COSTOS_TOTALES", lobjParams)
        Return dt
    End Function

    Public Function Lista_cantidad_Doc_Costo_embarque(ByVal pdblEmbarque As Double, ByVal pstrVariable As String, ByVal pdblCorrelativo As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSCODVAR", pstrVariable)
        lobjParams.Add("PNNCRRDC", pdblCorrelativo)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CANTIDAD_DOC_COSTO_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Eliminar_Costo_Detalle_Embarque_Rubro_Agencia(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSCODVAR", PSCODVAR)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_ELIMINAR_DETALLE_COSTOS_EMBARQUE_RUBRO_AGENCIA", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function Insertar_Costo_Detalle_Embarque_Rubro_Agencia(ByVal obeDetCostoRubroAgencia As beDetCostoRubroAgencia) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDetCostoRubroAgencia.PNNORSCI)
        lobjParams.Add("PSCODVAR", obeDetCostoRubroAgencia.PSCODVAR)
        lobjParams.Add("PNCSRVRL", obeDetCostoRubroAgencia.PNCSRVRL)
        'lobjParams.Add("PNIVLDOL", obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_DOL)
        'lobjParams.Add("PNIVLSOL", obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_SOL)
        'lobjParams.Add("PNIMPVTD", obeDetCostoRubroAgencia.PNIMPORTE_BASE_DOL)
        'lobjParams.Add("PNIMPVTS", obeDetCostoRubroAgencia.PNIMPORTE_BASE_SOL)
        lobjParams.Add("PNIVLDOL", obeDetCostoRubroAgencia.PNIMPORTE_BASE_DOL)
        lobjParams.Add("PNIVLSOL", obeDetCostoRubroAgencia.PNIMPORTE_BASE_SOL)
        lobjParams.Add("PNIMPVTD", obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_DOL)
        lobjParams.Add("PNIMPVTS", obeDetCostoRubroAgencia.PNIMPORTE_TOTAL_SOL)
        lobjParams.Add("PNIGVA", obeDetCostoRubroAgencia.PNIGV)
        lobjParams.Add("PNIMTPOC", obeDetCostoRubroAgencia.PNIMTPOC)
        lobjParams.Add("PNCTPOD1", obeDetCostoRubroAgencia.PNTIPODOC)
        lobjParams.Add("PNNDCCT1", obeDetCostoRubroAgencia.PNNUMDOC)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_INSERTAR_DETALLE_COSTOS_EMBARQUE_RUBRO_AGENCIA_AJUSTE", lobjParams)
        retorno = 1
        Return retorno
    End Function
    Public Function Listar_Costo_Detalle_Embarque_Rubro_Agencia(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtCostos As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSCODVAR", PSCODVAR)
        odtCostos = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTAR_DETALLE_COSTOS_EMBARQUE_RUBRO_AGENCIA", lobjParams)
        Return odtCostos
    End Function

    Public Sub Eliminar_X_Documento_Adj_Costo_Item(ByVal obeDocumentoCosto As beDocumentoCostos)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeDocumentoCosto.PNNORSCI)
        lobjParams.Add("PNNDOCIN", obeDocumentoCosto.PNNDOCIN)
        lobjParams.Add("PNNCRRDC", obeDocumentoCosto.PNNCRRDC)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_DOCUMENTO_ADJUNTO_COSTOS", lobjParams)
    End Sub


    Public Sub Borrar_Costos_Embarque_Distribucion_Detalle(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSCODVAR", PSCODVAR)
        lobjSql.ExecuteNonQuery("SP_SOLSC_BORRAR_COSTO_EMBARQUE_DISTRUCION_DETALLE", lobjParams)
    End Sub

    Public Function ListaEmbarquesRegularizar() As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_EMBARQUE_PARA_DISTRIBUCION", lobjParams)
        Return dt
    End Function

    Public Function Lista_Validacion_Envio_Costos_ABB(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim ds As New DataSet
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_VALIDACION_ENVIO_COSTOS_EMBARQUE_ABB", lobjParams)
        Return ds
    End Function


    Public Function ListarOCRegularizados_ABB(ByVal PNNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dt As New DataTable
        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_ENVIAR_ABB", lobjParams)
        Return dt
    End Function

    Public Function ExisteCostoxEmbarque(ByVal PNNORSCI As Decimal, ByVal PSCODVAR As String) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNFILA", 0, ParameterDirection.Output)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSCODVAR", PSCODVAR)
        lobjSql.ExecuteNonQuery("SP_SOLSC_EXISTE_COSTO_EMBARQUE", lobjParams)
        Return lobjSql.ParameterCollection("PNNFILA")
    End Function

End Class
