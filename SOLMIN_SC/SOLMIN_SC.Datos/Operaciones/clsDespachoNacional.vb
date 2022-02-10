Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsDespachoNacional

    'Public Function Listar_Tipo_Tarifa() As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_TIPO_TARIFA", Nothing)
    '    Return dt
    'End Function



    Public Function Listar_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional, ByVal PNFECINI As Decimal, ByVal PNFECFIN As Decimal) As List(Of beDespachoNacional)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objbeDespNac As beDespachoNacional
        Dim lstobeDespNac As New List(Of beDespachoNacional)

        lobjParams.Add("PSCCMPN", obeDespachoNacional.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeDespachoNacional.PSCDVSN)
        lobjParams.Add("PNCPLNDV", obeDespachoNacional.PNCPLNDV)
        lobjParams.Add("PNCCLNT", obeDespachoNacional.PNCCLNT)
        lobjParams.Add("PSTPSRVA", obeDespachoNacional.PSTPSRVA)
        lobjParams.Add("PSSESTRG", obeDespachoNacional.PSSESTRG)
        lobjParams.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_EMBARQUE_NACIONAL", lobjParams)
        For Each dr As DataRow In dt.Rows
            objbeDespNac = New beDespachoNacional

            objbeDespNac.PSCCMPN = dr("CCMPN").ToString.Trim
            objbeDespNac.PSCDVSN = dr("CDVSN").ToString.Trim
            objbeDespNac.PNCPLNDV = dr("CPLNDV")
            objbeDespNac.PNCCLNT = dr("CCLNT")
            objbeDespNac.PSTCMPCL = dr("TCMPCL").ToString.Trim
            objbeDespNac.PSTPSRVA = dr("TPSRVA").ToString.Trim
            objbeDespNac.PSSESTRG = dr("SESTRG").ToString.Trim
            objbeDespNac.PNNORSCI = dr("NORSCI")
            objbeDespNac.PSFORSCI = HelpClass.FechaNum_a_Fecha(dr("FORSCI"))
            objbeDespNac.PSNDOCEM = dr("NDOCEM").ToString.Trim
            'objbeDespNac.PNCPRVCL = dr("CPRVCL")
            'objbeDespNac.PSTPRVCL = dr("TPRVCL").ToString.Trim
            objbeDespNac.PNCCIANV = dr("CCIANV")
            objbeDespNac.PSTNMCIN = dr("TNMCIN").ToString.Trim
            objbeDespNac.PNCMEDTR = dr("CMEDTR")
            objbeDespNac.PSTNMMDT = dr("TNMMDT").ToString.Trim
            objbeDespNac.PSTOBERV = dr("TOBERV").ToString.Trim
            objbeDespNac.PSNREFCL = dr("NREFCL").ToString.Trim
            objbeDespNac.PSREFDO1 = dr("REFDO1").ToString.Trim
            objbeDespNac.PNCLCLOR = dr("CLCLOR")
            objbeDespNac.PSORIGEN = dr("TCMLCL_ORIGEN").ToString.Trim
            objbeDespNac.PNCLCLDS = dr("CLCLDS")
            objbeDespNac.PSDESTIN = dr("TCMLCL_DESTINO").ToString.Trim
            objbeDespNac.PSFLGTRF = dr("FLGTRF").ToString.Trim
            objbeDespNac.PSTDSDES = dr("TIPO_TARIFA").ToString.Trim
            objbeDespNac.PSTDRCOR = dr("TDRCOR").ToString.Trim
            objbeDespNac.PSTDREN2 = dr("TDREN2").ToString.Trim
            objbeDespNac.PNQVOLMR = Val(dr("QVOLMR"))
            objbeDespNac.PNQPSOAR = Val(dr("QPSOAR"))
            objbeDespNac.PSTRECOR = dr("TRECOR").ToString.Trim
            'objbeDespNac.PSCVPRCN = dr("CVPRCN").ToString.Trim
            'objbeDespNac.PSREFNAV = dr("REFNAV").ToString.Trim
            objbeDespNac.PSREFNAV_DES = dr("REFNAV_DESC").ToString.Trim

            objbeDespNac.PNNRTFSV = dr("NRTFSV")

            objbeDespNac.PSCTRMAL = ("" & dr("CTRMAL")).ToString.Trim
            objbeDespNac.PNCAGNCR = dr("CAGNCR")
            objbeDespNac.PSTTRMAL = ("" & dr("TTRMAL")).ToString.Trim
            objbeDespNac.PSTNMAGC = ("" & dr("TNMAGC")).ToString.Trim

            objbeDespNac.PSFTRTSG = ("" & dr("FTRTSG")).ToString.Trim

            lstobeDespNac.Add(objbeDespNac)

        Next
        Return lstobeDespNac
    End Function

    Public Function Grabar_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("S_NORSCI", obeDespachoNacional.PNNORSCI, ParameterDirection.Output)
        lobjParams.Add("PSCCMPN", obeDespachoNacional.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeDespachoNacional.PSCDVSN)
        lobjParams.Add("PNCPLNDV", obeDespachoNacional.PNCPLNDV)
        lobjParams.Add("PSTPSRVA", obeDespachoNacional.PSTPSRVA)
        lobjParams.Add("PSSESTRG", obeDespachoNacional.PSSESTRG)
        lobjParams.Add("PNCCLNT", obeDespachoNacional.PNCCLNT)
        lobjParams.Add("PNFORSCI", obeDespachoNacional.PNFORSCI)
        lobjParams.Add("PSNDOCEM", obeDespachoNacional.PSNDOCEM)
        lobjParams.Add("PSREFNAV", obeDespachoNacional.PSREFNAV)
        lobjParams.Add("PSTOBERV", obeDespachoNacional.PSTOBERV)
        lobjParams.Add("PSNREFCL", obeDespachoNacional.PSNREFCL)
        lobjParams.Add("PSREFDO1", obeDespachoNacional.PSREFDO1)
        lobjParams.Add("PNCPRVCL", obeDespachoNacional.PNCPRVCL)
        lobjParams.Add("PNCCIANV", obeDespachoNacional.PNCCIANV)
        lobjParams.Add("PSCVPRCN", obeDespachoNacional.PSCVPRCN)
        lobjParams.Add("PSFLGTRF", obeDespachoNacional.PSFLGTRF)
        lobjParams.Add("PNCMEDTR", obeDespachoNacional.PNCMEDTR)
        lobjParams.Add("PNCLCLOR", obeDespachoNacional.PNCLCLOR)
        lobjParams.Add("PSTDRCOR", obeDespachoNacional.PSTDRCOR)
        lobjParams.Add("PNCLCLDS", obeDespachoNacional.PNCLCLDS)
        lobjParams.Add("PSTDREN2", obeDespachoNacional.PSTDREN2)
        lobjParams.Add("PNQVOLMR", obeDespachoNacional.PNQVOLMR)
        lobjParams.Add("PNQPSOAR", obeDespachoNacional.PNQPSOAR)
        lobjParams.Add("PSTRECOR", obeDespachoNacional.PSTRECOR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNNRTFSV", obeDespachoNacional.PNNRTFSV)
        lobjParams.Add("PNCAGNCR", obeDespachoNacional.PNCAGNCR)
        lobjParams.Add("PSCTRMAL", obeDespachoNacional.PSCTRMAL)

        lobjParams.Add("PSFTRTSG", obeDespachoNacional.PSFTRTSG)

        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_DESPACHO_NACIONAL", lobjParams)
        retorno = lobjSql.ParameterCollection("S_NORSCI")

        Return retorno

    End Function


    Public Function Mant_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Boolean
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        lobjParams.Add("PSNDOCEM", obeDespachoNacional.PSNDOCEM)
        lobjParams.Add("PSREFNAV", obeDespachoNacional.PSREFNAV)
        lobjParams.Add("PSTOBERV", obeDespachoNacional.PSTOBERV)
        lobjParams.Add("PSNREFCL", obeDespachoNacional.PSNREFCL)
        lobjParams.Add("PSREFDO1", obeDespachoNacional.PSREFDO1)
        lobjParams.Add("PNCPRVCL", obeDespachoNacional.PNCPRVCL)
        lobjParams.Add("PNCCIANV", obeDespachoNacional.PNCCIANV)
        lobjParams.Add("PSCVPRCN", obeDespachoNacional.PSCVPRCN)
        lobjParams.Add("PSFLGTRF", obeDespachoNacional.PSFLGTRF)
        lobjParams.Add("PNCMEDTR", obeDespachoNacional.PNCMEDTR)
        lobjParams.Add("PNCLCLOR", obeDespachoNacional.PNCLCLOR)
        lobjParams.Add("PSTDRCOR", obeDespachoNacional.PSTDRCOR)
        lobjParams.Add("PNCLCLDS", obeDespachoNacional.PNCLCLDS)
        lobjParams.Add("PSTDREN2", obeDespachoNacional.PSTDREN2)
        lobjParams.Add("PNQVOLMR", obeDespachoNacional.PNQVOLMR)
        lobjParams.Add("PNQPSOAR", obeDespachoNacional.PNQPSOAR)
        lobjParams.Add("PSTRECOR", obeDespachoNacional.PSTRECOR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNNRTFSV", obeDespachoNacional.PNNRTFSV)

        lobjParams.Add("PNCAGNCR", obeDespachoNacional.PNCAGNCR)
        lobjParams.Add("PSCTRMAL", obeDespachoNacional.PSCTRMAL)

        lobjParams.Add("PSFTRTSG", obeDespachoNacional.PSFTRTSG)

        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_EMBARQUE_NACIONAL", lobjParams)
        retorno = True

        Return retorno

    End Function

    Public Function Anular_Despacho_Nacional(ByVal obeDespachoNacional As beDespachoNacional) As Boolean
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ANULAR_EMBARQUE_NACIONAL", lobjParams)

        retorno = True

        Return retorno
    End Function

    Public Sub Anular_Tarifa_Local(ByVal obeDespachoNacional As beDespachoNacional)
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ANULAR_TARIFA_EMBARQUE_LOCAL", lobjParams)


    End Sub

    Public Function Listar_Costos_Despacho_Nacional() As List(Of beCostoTotalEmbarqueNacional)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lstbeCostoTotalEmbarqueNacional As New List(Of beCostoTotalEmbarqueNacional)
        Dim obeCostoTotalEmbarqueNacional As beCostoTotalEmbarqueNacional
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTOS_EMBARQUE_NACIONAL", Nothing)

        For Each dr As DataRow In dt.Rows
            obeCostoTotalEmbarqueNacional = New beCostoTotalEmbarqueNacional
            obeCostoTotalEmbarqueNacional.PNNORSCI = dr("NORSCI")
            obeCostoTotalEmbarqueNacional.PSCODVAR = dr("CODVAR").ToString
            obeCostoTotalEmbarqueNacional.PSNOMVAR = dr("NOMVAR").ToString
            obeCostoTotalEmbarqueNacional.PNIVLORG = dr("IVLORG")
            obeCostoTotalEmbarqueNacional.PNIVLDOL = dr("IVLDOL")
            obeCostoTotalEmbarqueNacional.PNCMNDA1 = dr("CMNDA1")
            obeCostoTotalEmbarqueNacional.PSNMONOC = dr("NMONOC").ToString
            lstbeCostoTotalEmbarqueNacional.Add(obeCostoTotalEmbarqueNacional)
        Next
        Return lstbeCostoTotalEmbarqueNacional
    End Function


    Public Function Listar_Costos_Despacho_Nacional_X_Embarque(ByVal PNNORSCI As Decimal, ByVal TIPO As String) As List(Of beCostoTotalEmbarqueNacional)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim obeCostoTotalEmbarqueNacional As beCostoTotalEmbarqueNacional
        Dim lstbeCostoTotalEmbarqueNacional As New List(Of beCostoTotalEmbarqueNacional)
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("TIPO", TIPO)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_COSTOS_GENERALES_EMBARQUE_X_TIPO", lobjParams)

        For Each dr As DataRow In dt.Rows
            obeCostoTotalEmbarqueNacional = New beCostoTotalEmbarqueNacional
            obeCostoTotalEmbarqueNacional.PSCVARBL = dr("CVARBL").ToString
            obeCostoTotalEmbarqueNacional.PSNOMVAR = dr("NOMVAR").ToString
            obeCostoTotalEmbarqueNacional.PSVALVAR = dr("VALVAR").ToString

            If IsDBNull(dr("CODVAR")) Then
                obeCostoTotalEmbarqueNacional.PSCODVAR = String.Empty
            Else
                obeCostoTotalEmbarqueNacional.PSCODVAR = dr("CODVAR").ToString
            End If

            If IsDBNull(dr("IVLORG")) Then
                obeCostoTotalEmbarqueNacional.PNIVLORG = Nothing
            Else
                obeCostoTotalEmbarqueNacional.PNIVLORG = Val(dr("IVLORG"))
            End If

            If IsDBNull(dr("IVLDOL")) Then
                obeCostoTotalEmbarqueNacional.PNIVLDOL = Nothing
            Else
                obeCostoTotalEmbarqueNacional.PNIVLDOL = Val(dr("IVLDOL"))
            End If

            If IsDBNull(dr("CMNDA1")) Then
                obeCostoTotalEmbarqueNacional.PNCMNDA1 = Nothing
            Else
                obeCostoTotalEmbarqueNacional.PNCMNDA1 = Val(dr("CMNDA1"))
            End If

            If IsDBNull(dr("NMRGIM")) Then
                obeCostoTotalEmbarqueNacional.PNNMRGIM = Nothing
            Else
                obeCostoTotalEmbarqueNacional.PNNMRGIM = Val(dr("NMRGIM"))
            End If


            lstbeCostoTotalEmbarqueNacional.Add(obeCostoTotalEmbarqueNacional)
        Next
        Return lstbeCostoTotalEmbarqueNacional
    End Function


    Public Sub Guardar_Costos_Totales_Embarque(ByVal PSTIPO As String, ByVal obeCostoTotalEmbarqueNacional As beCostoTotalEmbarqueNacional)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("TIPO", PSTIPO)
        lobjParams.Add("PNNORSCI", obeCostoTotalEmbarqueNacional.PNNORSCI.Value)
        lobjParams.Add("PSCODVAR", obeCostoTotalEmbarqueNacional.PSCODVAR)
        lobjParams.Add("PNIVLORG", obeCostoTotalEmbarqueNacional.PNIVLORG.Value)
        lobjParams.Add("PNIVLDOL", obeCostoTotalEmbarqueNacional.PNIVLDOL.Value)
        lobjParams.Add("PNCMNDA1", obeCostoTotalEmbarqueNacional.PNCMNDA1.Value)
        lobjParams.Add("PSNMONOC", obeCostoTotalEmbarqueNacional.PSNMONOC)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_GUARDAR_COSTO_EMBARQUE", lobjParams)
    End Sub

  

    Public Function Listar_Carga_Asignada_x_Embarque(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim ds As New DataSet
      

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_CARGA_ASIGNADA_X_EMBARQUE", lobjParams)


        For Each Item As DataRow In ds.Tables(0).Rows
            Item("QPSOMR") = Val(Item("QPSOMR"))
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("PSOVOL") = Val(Item("PSOVOL"))
            Item("QSEDNA") = Val(Item("QSEDNA"))
            Item("NCRRDT") = Val(Item("NCRRDT"))

            Item("FING_ALM") = HelpClass.FechaNum_a_Fecha(Item("FING_ALM"))
            Item("FSAL_ALM") = HelpClass.FechaNum_a_Fecha(Item("FSAL_ALM"))
         
        Next

        For Each Item As DataRow In ds.Tables(1).Rows
            Item("QSEG") = Val("" & Item("QSEG"))
            Item("IVUNIT") = Val("" & Item("IVUNIT"))
            Item("QTPCM2") = Val("" & Item("QTPCM2"))
        Next

        For Each Item As DataRow In ds.Tables(2).Rows
            Item("QCTPQT") = Val(Item("QCTPQT"))
            Item("QMTLRG") = Val(Item("QMTLRG"))
            Item("QMTALT") = Val(Item("QMTALT"))
            Item("QMTANC") = Val(Item("QMTANC"))
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("QPSOMR") = Val(Item("QPSOMR"))
        Next

        Return ds

    End Function

    Public Function Listar_Dimension_Todos_x_Embarque(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Dim dt1 As DataTable
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)

        dt1 = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DIMENSIONES_TODOS_X_EMBARQUE", lobjParams)

        Return dt1

    End Function

    Public Sub Eliminar_Item_Carga_Asignada(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As String, ByVal PNNRPEMB As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRITEM", PNNRITEM)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_ITEM_CARGA_ASIGNADA", lobjParams)

    End Sub



    


  



    

   
    Public Function Registrar_Item_Carga_Manual(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga) As Decimal
        Dim retorno As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PSCTPCRG", obeOrdenEmbarqueCarga.PSCTPCRG)
        'lobjParams.Add("PSNUMDCR", obeOrdenEmbarqueCarga.PSNUMDCR)
        lobjParams.Add("PSCREFFW", obeOrdenEmbarqueCarga.PSCREFFW)
        lobjParams.Add("PSTDSCIT", obeOrdenEmbarqueCarga.PSTDSCIT)
        lobjParams.Add("PNQRLCSC", obeOrdenEmbarqueCarga.PNQRLCSC)
        lobjParams.Add("PSTIPBTO", obeOrdenEmbarqueCarga.PSTIPBTO)
        lobjParams.Add("PNQPSOMR", obeOrdenEmbarqueCarga.PNQPSOMR)
        lobjParams.Add("PNQVOLMR", obeOrdenEmbarqueCarga.PNQVOLMR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB, ParameterDirection.Output)

        lobjSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_ITEM_CARGA_MANUAL", lobjParams)

        retorno = lobjSql.ParameterCollection("PNNRPEMB")

        Return retorno
    End Function


    Public Sub Actualizar_Item_Carga(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim retorno As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PSNUMDCR", obeOrdenEmbarqueCarga.PSNUMDCR)
        lobjParams.Add("PSCREFFW", obeOrdenEmbarqueCarga.PSCREFFW)
        lobjParams.Add("PSTDSCIT", obeOrdenEmbarqueCarga.PSTDSCIT)
        lobjParams.Add("PNQRLCSC", obeOrdenEmbarqueCarga.PNQRLCSC)
        lobjParams.Add("PSTIPBTO", obeOrdenEmbarqueCarga.PSTIPBTO)
        lobjParams.Add("PNQPSOMR", obeOrdenEmbarqueCarga.PNQPSOMR)
        lobjParams.Add("PNQVOLMR", obeOrdenEmbarqueCarga.PNQVOLMR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_ITEM_CARGA", lobjParams)
    End Sub

    Public Sub Actualizar_Datos_Item(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim retorno As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PNQPSOMR", obeOrdenEmbarqueCarga.PNQPSOMR)
        lobjParams.Add("PNQVOLMR", obeOrdenEmbarqueCarga.PNQVOLMR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DATOS_ITEM", lobjParams)
    End Sub

    


    Public Function Registrar_Dimension_Item_Carga(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga) As Boolean
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PNNCRRIN", obeOrdenEmbarqueCarga.PNNCRRIN)
        lobjParams.Add("PNQCTPQTC", obeOrdenEmbarqueCarga.PNQCTPQT)
        lobjParams.Add("PNQMTLRG", obeOrdenEmbarqueCarga.PNQMTLRG)
        lobjParams.Add("PNQMTANC", obeOrdenEmbarqueCarga.PNQMTANC)
        lobjParams.Add("PNQMTALT", obeOrdenEmbarqueCarga.PNQMTALT)
        lobjParams.Add("PNQPSOMR", obeOrdenEmbarqueCarga.PNQPSOMR)
        lobjParams.Add("PNQVOLMR", obeOrdenEmbarqueCarga.PNQVOLMR)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_DIMENSION_ITEM_CARGA", lobjParams)

        retorno = True
        Return retorno
    End Function

   
    Public Sub Eliminar_Dimension_Item_Carga(ByVal ObeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", ObeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", ObeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", ObeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", ObeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", ObeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PNNCRRIN", ObeOrdenEmbarqueCarga.PNNCRRIN)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_DIMENSION_ITEM_CARGA", lobjParams)


    End Sub

    Public Function Enviar_Operacion_Facturacion_Despacho(ByVal pstrCompania As String, ByVal pstrDivision As String, ByVal pdblEmbarque As Double, ByVal pdblCli As Double, ByVal pdblFecSrv As Double, _
    ByVal pdblTarifa As Double, ByVal pstrTipoTarifa As String, ByVal pstrUnidadMedida As String, ByVal pdblValor As Double, ByVal PNCCLNFC As Double, ByVal CPLNDV As Decimal, ByVal QFACTOR As Decimal, ByVal CDIRSE As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PNFECSRV", pdblFecSrv)

        'MODIFICADO POR ABRAHAM ZORRILLA
        lobjParams.Add("PNNRTFSV", pdblTarifa)
        lobjParams.Add("PSSTPTRA", pstrTipoTarifa)
        lobjParams.Add("PSCUNDMD", pstrUnidadMedida)
        lobjParams.Add("PNVALCTE", pdblValor)
        '======================================

        lobjParams.Add("PNCCLNFC", PNCCLNFC)   ' Cliente Facturación agregado 17/09/2012

        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PNCPLNDV", CPLNDV)
        lobjParams.Add("PNQATNAN", QFACTOR)
        lobjParams.Add("CDIRSE", CDIRSE)
        'dt = lobjSql.ExecuteDataTable("SP_SOLCT_REGISTRAR_OPERACION_SIL", lobjParams)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_REGISTRAR_OPERACION_DESPACHO", lobjParams)
        Return dt
    End Function


    Public Function Lista_Guia_Salida_Zona_GR(ByVal CCLNT1 As Decimal, ByVal NUMDOC As Decimal, ByVal CCMPN As String, ByVal CDVSN As String, ByVal CPLNDV As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", CCLNT1)
        objParam.Add("PNNGUIRM", NUMDOC)
        objParam.Add("PSCCMPN", CCMPN)
        objParam.Add("PSCDVSN", CDVSN)
        objParam.Add("PNCPLNDV", CPLNDV)

        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_GUIA_SALIDA_ZONA_GR", objParam)
        Return objDataTable

    End Function

    Public Function Listar_Unidades_Medida_Carga() As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_UNIDADES_MEDIDA_CARGA", Nothing)
        Return objDataTable
    End Function
    Public Function Listar_Unidades_Medida_Carga_Item() As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_UNIDADES_MEDIDA_CARGA_ITEM", Nothing)
        Return objDataTable
    End Function

    Public Function Listar_CheckPoint(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSCDVSN As String, ByVal PSCEMB As String) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCDVSN", PSCDVSN)
        objParam.Add("PSCEMB", PSCEMB)

        objDataTable = lobjSql.ExecuteDataTable("", objParam)
        Return objDataTable

    End Function

    Public Function Datos_X_Embarque_Despacho(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As beDespachoNacional
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeDespachoNacional As New beDespachoNacional

        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_X_EMBARQUE_DESPACHO", lobjParams)

        For Each dr As DataRow In dt.Rows

            With obeDespachoNacional
                .PSCCMPN = dr("CCMPN").ToString.Trim
                .PSCDVSN = dr("CDVSN").ToString.Trim
                .PNCPLNDV = dr("CPLNDV")
                .PNCCLNT = dr("CCLNT")
                .PSSESTRG = dr("SESTRG").ToString.Trim
                .PNNRTFSV = dr("NRTFSV")
                .PNNORSCI = PNNORSCI 'ECM-CorrectivoSolmin(SA_SC_CTZ)-[300516]
                .PSFTRTSG = dr("FTRTSG")
            End With
        Next
        Return obeDespachoNacional
    End Function

    Public Function Listar_Embarque_Nacional_Consulta_Exportar(ByVal Filtro As Hashtable) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

    
        lobjParams.Add("PSCCMPN", Filtro("PSCCMPN"))
        lobjParams.Add("PSCDVSN", Filtro("PSCDVSN"))
        lobjParams.Add("PNCPLNDV", Filtro("PNCPLNDV"))
        lobjParams.Add("PNCCLNT", Filtro("PNCCLNT"))
        lobjParams.Add("PSTPSRVA", Filtro("PSTPSRVA"))
        lobjParams.Add("PSSESTRG", Filtro("PSSESTRG"))
        lobjParams.Add("PNNORSCI", Filtro("PNNORSCI"))
        lobjParams.Add("PNFECINI_APERTURA", Filtro("PNFECINI_APERTURA"))
        lobjParams.Add("PNFECFIN_APERTURA", Filtro("PNFECFIN_APERTURA"))
        lobjParams.Add("PNCLCLOR", Filtro("PNCLCLOR"))
        lobjParams.Add("PNCLCLDS", Filtro("PNCLCLDS"))

        lobjParams.Add("PNNESTDO", Filtro("PNNESTDO"))
        lobjParams.Add("PNCHK_INICIO", Filtro("PNCHK_INICIO"))
        lobjParams.Add("PNCHK_FIN", Filtro("PNCHK_FIN"))



        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_EMBARQUE_NACIONAL_CONSULTA_EXPORTAR", lobjParams)

        ds.Tables(0).TableName = "dtDatosEmbarque"
        ds.Tables(1).TableName = "dtOrdenesEmbarque"
        ds.Tables(2).TableName = "dtMovChekPoint"
        ds.Tables(3).TableName = "dtMovObservaciones"
        ds.Tables(4).TableName = "dtMovCostos"
        ds.Tables(5).TableName = "dtListaCheckPoint"
        ds.Tables(6).TableName = "dtListaCostos"
        'JM   17-11-2014
        ds.Tables(7).TableName = "dtBultosEmbarque"
        ds.Tables(8).TableName = "dtTipoTarifa"

        Return ds.Copy

    End Function

 

    Public Function Lista_Despacho_Bulto_Guia_Remision(ByVal PSNUMDCR As String, ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PNNRGUSA As Decimal, ByVal PSNGRPRV As String, ByVal PSNORCML As String, ByVal PNNORSCI As Decimal) As DataSet
        Dim objDataSet As New DataSet
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PSNUMDCR", PSNUMDCR)
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNCPLNDV", PNCPLNDV)
        objParam.Add("PNCCLNT1", PNCCLNT)
        objParam.Add("PNNRGUSA", PNNRGUSA)
        objParam.Add("PSNGRPRV", PSNGRPRV)
        objParam.Add("PSNORCML", PSNORCML)
        objParam.Add("PNNORSCI", PNNORSCI)



        objDataSet = lobjSql.ExecuteDataSet("SP_SOLMIN_SC_DESPACHO_LISTAR_BULTOS_GUIAREMISION", objParam)

        For Each Item As DataRow In objDataSet.Tables(0).Rows
            Item("CREFFW") = ("" & Item("CREFFW")).ToString.Trim
            Item("NORCML") = ("" & Item("NORCML")).ToString.Trim

            Item("QREFFW") = Val(Item("QREFFW"))
            Item("QPSOBL") = Val(Item("QPSOBL"))
            Item("QVLBTO") = Val(Item("QVLBTO"))
        Next

        For Each Item As DataRow In objDataSet.Tables(1).Rows
            Item("CREFFW") = ("" & Item("CREFFW")).ToString.Trim
            Item("NORCML") = ("" & Item("NORCML")).ToString.Trim

            Item("QCTPQT") = Val(Item("QCTPQT"))
            Item("QMTLRG") = Val(Item("QMTLRG"))
            Item("QMTALT") = Val(Item("QMTALT"))
            Item("QMTANC") = Val(Item("QMTANC"))
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("QPSOMR") = Val(Item("QPSOMR"))
        Next

        For Each Item As DataRow In objDataSet.Tables(2).Rows
            Item("CREFFW") = ("" & Item("CREFFW")).ToString.Trim
            Item("NORCML") = ("" & Item("NORCML")).ToString.Trim
            Item("TDITES") = ("" & Item("TDITES")).ToString.Trim
            Item("TUNDIT") = ("" & Item("TUNDIT")).ToString.Trim
            Item("NUMDCR") = ("" & Item("NUMDCR")).ToString.Trim
            Item("NGRPRV") = ("" & Item("NGRPRV")).ToString.Trim
            Item("QSEG") = Val(Item("QSEG"))
        Next

        Return objDataSet

    End Function

    Public Function Lista_Despacho_Bulto_Detalle_Dimension(ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCREFFW As String, ByVal PNNSEQIN As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNCPLNDV", PNCPLNDV)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCREFFW", PSCREFFW)
        objParam.Add("PNNSEQIN", PNNSEQIN)
        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_DESPACHO_LISTAR_BULTOS_DETALLE_DIMENSIONES", objParam)
        For Each Item As DataRow In objDataTable.Rows
            Item("QCTPQT") = Val(Item("QCTPQT"))
            Item("QMTLRG") = Val(Item("QMTLRG"))
            Item("QMTALT") = Val(Item("QMTALT"))
            Item("QMTANC") = Val(Item("QMTANC"))
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("QPSOMR") = Val(Item("QPSOMR"))
        Next
        Return objDataTable

    End Function

    Public Function Lista_Despacho_Bulto_Detalle_Items(ByVal PSCCMPN As String, ByVal PNCPLNDV As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCREFFW As String, ByVal PNNSEQIN As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNCPLNDV", PNCPLNDV)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCREFFW", PSCREFFW)
        objParam.Add("PNNSEQIN", PNNSEQIN)

        objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_DESPACHO_LISTAR_BULTOS_DETALLE_ITEMS", objParam)

        Return objDataTable

    End Function
    Public Sub Registrar_Bulto_Guia_Remision(ByVal obeCarga As beOrdenEmbarqueCarga)
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim retorno As Decimal = 0
        objParam.Add("PNNORSCI", obeCarga.PNNORSCI)
        objParam.Add("PSCCMPN", obeCarga.PSCCMPN)
        objParam.Add("PNCPLNDV", obeCarga.PNCPLNDV)
        objParam.Add("PSCTPCRG", obeCarga.PSCTPCRG)
        'objParam.Add("PSNUMDCR", obeCarga.PSNUMDCR)
        objParam.Add("PNCCLNT", obeCarga.PNCCLNT)
        'objParam.Add("PNCCLNT1", obeCarga.PNCCLNT1)
        objParam.Add("PSNORCML", obeCarga.PSNORCML)
        objParam.Add("PSCREFFW", obeCarga.PSCREFFW)
        'objParam.Add("PSNGRPRV", obeCarga.PSNGRPRV)
        objParam.Add("PNNSEQIN", obeCarga.PNNSEQIN)
        objParam.Add("PNQRLCSC", obeCarga.PNQRLCSC)
        objParam.Add("PSTIPBTO", obeCarga.PSTIPBTO)
        objParam.Add("PNQPSOMR", obeCarga.PNQPSOMR)
        objParam.Add("PNQVOLMR", obeCarga.PNQVOLMR)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_REGISTRAR_DESPACHO_BULTO_X_GUIA_REMISION", objParam)


    End Sub
 

    Public Function Listar_Dimnesiones_x_Carga_Item(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PNNORSCI", PNNORSCI)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSNORCML", PSNORCML)
        objParam.Add("PNNRITEM", PNNRITEM)
        objParam.Add("PNNRPEMB", PNNRPEMB)


        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DIMENSIONES_X_CARGA_ITEM", objParam)

        For Each Item As DataRow In dt.Rows
            Item("QCTPQT") = Val(Item("QCTPQT"))
            Item("QMTLRG") = Val(Item("QMTLRG"))
            Item("QMTALT") = Val(Item("QMTALT"))
            Item("QMTANC") = Val(Item("QMTANC"))
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("QPSOMR") = Val(Item("QPSOMR"))
        Next
        Return dt
    End Function

    Public Function Listar_ItemsOC_x_Carga_Item(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPEMB As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PNNORSCI", PNNORSCI)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSNORCML", PSNORCML)
        objParam.Add("PNNRPEMB", PNNRPEMB)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_ITEMSOC_X_CARGA_ITEM", objParam)


        Return dt
    End Function

    '


    Public Function Listar_Datos_Exportar_Formato2(ByVal obeDespachoNacional As beDespachoNacional) As DataSet
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim ds As New DataSet
        objParam.Add("PSCCMPN", obeDespachoNacional.PSCCMPN)
        objParam.Add("PSCDVSN", obeDespachoNacional.PSCDVSN)
        objParam.Add("PNCPLNDV", obeDespachoNacional.PNCPLNDV)
        objParam.Add("PNCCLNT", obeDespachoNacional.PNCCLNT)
        objParam.Add("PSTPSRVA", obeDespachoNacional.PSTPSRVA)
        objParam.Add("PSSESTRG", obeDespachoNacional.PSSESTRG)
        objParam.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        objParam.Add("PNFECINI", obeDespachoNacional.PNFECINI)
        objParam.Add("PNFECFIN", obeDespachoNacional.PNFECFIN)
        objParam.Add("PNCLCLOR", obeDespachoNacional.PNCLCLOR)
        objParam.Add("PNCLCLDS", obeDespachoNacional.PNCLCLDS)


        objParam.Add("PNNESTDO", obeDespachoNacional.PNNESTDO)
        objParam.Add("PNCHK_INI", obeDespachoNacional.PNCHK_INI)
        objParam.Add("PNCHK_FIN", obeDespachoNacional.PNCHK_FIN)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_EMBARQUE_NACIONAL_FORMATO_DETALLE", objParam)
        Return ds
    End Function

    Public Function Listar_Datos_Exportar_General(ByVal obeDespachoNacional As beDespachoNacional) As DataSet
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim ds As New DataSet
        objParam.Add("PSCCMPN", obeDespachoNacional.PSCCMPN)
        objParam.Add("PSCDVSN", obeDespachoNacional.PSCDVSN)
        objParam.Add("PNCPLNDV", obeDespachoNacional.PNCPLNDV)
        objParam.Add("PNCCLNT", obeDespachoNacional.PNCCLNT)
        objParam.Add("PSTPSRVA", obeDespachoNacional.PSTPSRVA)
        objParam.Add("PSSESTRG", obeDespachoNacional.PSSESTRG)
        objParam.Add("PNNORSCI", obeDespachoNacional.PNNORSCI)
        objParam.Add("PNFECINI", obeDespachoNacional.PNFECINI)
        objParam.Add("PNFECFIN", obeDespachoNacional.PNFECFIN)
        objParam.Add("PNCLCLOR", obeDespachoNacional.PNCLCLOR)
        objParam.Add("PNCLCLDS", obeDespachoNacional.PNCLCLDS)


        objParam.Add("PNNESTDO", obeDespachoNacional.PNNESTDO)
        objParam.Add("PNCHK_INI", obeDespachoNacional.PNCHK_INI)
        objParam.Add("PNCHK_FIN", obeDespachoNacional.PNCHK_FIN)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_EMBARQUE_NACIONAL_FORMATO_GENERAL", objParam)
        Return ds
    End Function

    Public Function Listar_Datos_Item_Carga(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITEM As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PNNORSCI", PNNORSCI)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSNORCML", PSNORCML)
        objParam.Add("PNNRITEM", PNNRITEM)
        objParam.Add("PNNRPEMB", PNNRPEMB)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DATOS_ITEM_CARGA", objParam)

        For Each Item As DataRow In dt.Rows
            Item("QVOLMR") = Val(Item("QVOLMR"))
            Item("QPSOMR") = Val(Item("QPSOMR"))
        Next
        Return dt
    End Function

    Public Function Listar_Datos_Tarifa_Asignada(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNNRTFSV As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PSCDVSN", PSCDVSN)
        objParam.Add("PNNRTFSV", PNNRTFSV)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DATOS_TARIFA_ASIGNADA", objParam)
        Return dt
    End Function


    Public Function Listar_Dimension_Todos_x_Embarque_Calculo_Factor(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Dim dt1 As DataTable
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNCCLNT", PNCCLNT)

        dt1 = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DIMENSIONES_TODOS_X_EMBARQUE_CALCULO_FACTOR", lobjParams)

        Return dt1

    End Function


    Public Sub Actualizar_Documento_Salida_Despacho(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal)
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PNNORSCI", PNNORSCI)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_SALIDA_DESPACHO_DOCUMENTO", objParam)


    End Sub

    Public Sub Eliminar_Item_OC_Carga(ByVal ObeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)
        Dim retorno As Boolean = False
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", ObeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", ObeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", ObeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", ObeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", ObeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_ITEM_OC_CARGA_ASIGNADA", lobjParams)


    End Sub

    Public Function Listar_Items_OC_X_Bulto(ByVal PNNORSCI As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPEMB As Decimal) As DataTable
        Dim objDataTable As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PNNORSCI", PNNORSCI)
        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSNORCML", PSNORCML)
        objParam.Add("PNNRPEMB", PNNRPEMB)


        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_ITEMS_OC_X_BULTO", objParam)


        Return dt
    End Function


    Public Sub Registrar_Item_OC_Manual(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PSCTPCRG", obeOrdenEmbarqueCarga.PSCTPCRG)
        lobjParams.Add("PSNUMDCR", obeOrdenEmbarqueCarga.PSNUMDCR)
        lobjParams.Add("PSTDSCIT", obeOrdenEmbarqueCarga.PSTDSCIT)
        lobjParams.Add("PNQRLCSC", obeOrdenEmbarqueCarga.PNQRLCSC)

        lobjParams.Add("PSNGRPRV", obeOrdenEmbarqueCarga.PSNGRPRV)
        lobjParams.Add("PSTUNDIT", obeOrdenEmbarqueCarga.PSTUNDIT)
        lobjParams.Add("PNIVUNIT", obeOrdenEmbarqueCarga.PNIVUNIT)
        lobjParams.Add("PNCMNDA1", obeOrdenEmbarqueCarga.PNCMNDA1)
        lobjParams.Add("PNCPRVCL", obeOrdenEmbarqueCarga.PNCPRVCL)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_ITEM_OC_MANUAL", lobjParams)
 
    End Sub


    Public Function Listar_Datos_Despacho_Nacional(ByVal NORSCI As Decimal) As beDespachoNacional
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim objbeDespNac As New beDespachoNacional

        lobjParams.Add("PNNORSCI", NORSCI)
 
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_DATOS_EMBARQUE_NACIONAL", lobjParams)
        If dt.Rows.Count > 0 Then
            objbeDespNac = New beDespachoNacional
            objbeDespNac.PSCCMPN = dt.Rows(0)("CCMPN").ToString.Trim
            objbeDespNac.PSCDVSN = dt.Rows(0)("CDVSN").ToString.Trim
            objbeDespNac.PNCPLNDV = dt.Rows(0)("CPLNDV")
            objbeDespNac.PNCCLNT = dt.Rows(0)("CCLNT")
            objbeDespNac.PSTCMPCL = dt.Rows(0)("TCMPCL").ToString.Trim
            objbeDespNac.PSTPSRVA = dt.Rows(0)("TPSRVA").ToString.Trim
            objbeDespNac.PSSESTRG = dt.Rows(0)("SESTRG").ToString.Trim
            objbeDespNac.PNNORSCI = dt.Rows(0)("NORSCI")
            objbeDespNac.PSFORSCI = HelpClass.FechaNum_a_Fecha(dt.Rows(0)("FORSCI"))
            objbeDespNac.PSNDOCEM = dt.Rows(0)("NDOCEM").ToString.Trim
            objbeDespNac.PNCPRVCL = dt.Rows(0)("CPRVCL")
            objbeDespNac.PNCCIANV = dt.Rows(0)("CCIANV")
            'objbeDespNac.PSTNMCIN = dt.Rows(0)("TNMCIN").ToString.Trim
            objbeDespNac.PNCMEDTR = dt.Rows(0)("CMEDTR")
            'objbeDespNac.PSTNMMDT = dt.Rows(0)("TNMMDT").ToString.Trim
            objbeDespNac.PSTOBERV = dt.Rows(0)("TOBERV").ToString.Trim
            objbeDespNac.PSNREFCL = dt.Rows(0)("NREFCL").ToString.Trim
            objbeDespNac.PSREFDO1 = dt.Rows(0)("REFDO1").ToString.Trim
            objbeDespNac.PNCLCLOR = dt.Rows(0)("CLCLOR")
            ' objbeDespNac.PSORIGEN = dt.Rows(0)("TCMLCL_ORIGEN").ToString.Trim
            objbeDespNac.PNCLCLDS = dt.Rows(0)("CLCLDS")
            ' objbeDespNac.PSDESTIN = dt.Rows(0)("TCMLCL_DESTINO").ToString.Trim
            objbeDespNac.PSFLGTRF = dt.Rows(0)("FLGTRF").ToString.Trim
            ' objbeDespNac.PSTDSDES = dt.Rows(0)("TIPO_TARIFA").ToString.Trim
            objbeDespNac.PSTDRCOR = dt.Rows(0)("TDRCOR").ToString.Trim
            objbeDespNac.PSTDREN2 = dt.Rows(0)("TDREN2").ToString.Trim
            objbeDespNac.PNQVOLMR = Val(dt.Rows(0)("QVOLMR"))
            objbeDespNac.PNQPSOAR = Val(dt.Rows(0)("QPSOAR"))
            objbeDespNac.PSTRECOR = dt.Rows(0)("TRECOR").ToString.Trim

            objbeDespNac.PSREFNAV = dt.Rows(0)("REFNAV").ToString.Trim
            objbeDespNac.PNNRTFSV = dt.Rows(0)("NRTFSV")

            objbeDespNac.PSCTRMAL = ("" & dt.Rows(0)("CTRMAL")).ToString.Trim
            objbeDespNac.PNCAGNCR = dt.Rows(0)("CAGNCR")
            'objbeDespNac.PSTTRMAL = ("" & dt.Rows(0)("TTRMAL")).ToString.Trim
            'objbeDespNac.PSTNMAGC = ("" & dt.Rows(0)("TNMAGC")).ToString.Trim
            objbeDespNac.PSFTRTSG = dt.Rows(0)("FTRTSG").ToString.Trim

        End If


        Return objbeDespNac
    End Function

    Public Sub Actualizar_Datos_Item_OC(ByVal obeOrdenEmbarqueCarga As beOrdenEmbarqueCarga)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", obeOrdenEmbarqueCarga.PNNORSCI)
        lobjParams.Add("PNCCLNT", obeOrdenEmbarqueCarga.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenEmbarqueCarga.PSNORCML)
        lobjParams.Add("PNNRITEM", obeOrdenEmbarqueCarga.PNNRITEM)
        lobjParams.Add("PNNRPEMB", obeOrdenEmbarqueCarga.PNNRPEMB)
        lobjParams.Add("PNQTPCM2", obeOrdenEmbarqueCarga.PNQTPCM2)

        lobjParams.Add("PSNUMDCR", obeOrdenEmbarqueCarga.PSNUMDCR)
        lobjParams.Add("PSNGRPRV", obeOrdenEmbarqueCarga.PSNGRPRV)

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DATOS_ITEM_OC", lobjParams)

    End Sub
    'JM
    'Public Function LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PSTPSRVA As String, ByVal PNFECINI As String, ByVal PNFECFIN As Decimal, ByVal PNANIO As Integer, ByVal PSMESES As String) As DataTable
    '    Dim ds As New DataSet
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PSCCMPN", PSCCMPN)
    '    lobjParams.Add("PSCDVSN", PSCDVSN)
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    '    lobjParams.Add("PNFECINI", PNFECINI)
    '    lobjParams.Add("PNFECFIN", PNFECFIN)
    '    lobjParams.Add("PNANIO", PNANIO)
    '    lobjParams.Add("PSMESES", PSMESES)
    '    ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR", lobjParams)
    '    Return ds.Tables(0)
    'End Function

    Public Function LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR(ByVal Param As Hashtable) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", Param("PSCCMPN"))
        lobjParams.Add("PSCDVSN", Param("PSCDVSN"))
        lobjParams.Add("PNCCLNT", Param("PNCCLNT"))
        lobjParams.Add("PSTPSRVA", Param("PSTPSRVA"))
        lobjParams.Add("PNFECINI", Param("PNFECINI"))
        lobjParams.Add("PNFECFIN", Param("PNFECFIN"))
        lobjParams.Add("PNANIO", Param("PNANIO"))
        lobjParams.Add("PSMESES", Param("PSMESES"))
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_EMBARQUE_FACTURACION_CONSULTA_EXPORTAR", lobjParams)
        dt.Columns.Add("F_FDCCTC", Type.GetType("System.String"))
        dt.Columns.Add("F_FORSCI", Type.GetType("System.String"))
        For Each Item As DataRow In dt.Rows
            Item("F_FDCCTC") = HelpClass.CNumero8Digitos_a_FechaDefault(Item("FDCCTC"))
            Item("F_FORSCI") = HelpClass.CNumero8Digitos_a_FechaDefault(Item("FORSCI"))
        Next
        Return dt
    End Function

End Class
