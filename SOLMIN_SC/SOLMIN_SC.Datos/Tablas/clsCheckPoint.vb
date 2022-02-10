Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsCheckPoint
    'Inherits Base_DAL(Of beCheckPoint)

    Public Sub Mant_CheckPoint_X_Cliente(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pstrTipo As String, ByVal pdblCliente As Double, ByVal pdblCheck As Double, ByVal pstrTituloName As String, ByVal pstrEstAsigna As String, ByVal pstrEstGrilla As String, Optional ByVal OrdenCheckPoint As Double = 0)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNNESTDO", pdblCheck)
        lobjParams.Add("PSTCOLUM", pstrTituloName)
        lobjParams.Add("PSSTRGS", pstrEstGrilla)
        lobjParams.Add("PSSTRGE", pstrEstAsigna)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PNNSEPRE", OrdenCheckPoint)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_CHECKPOINT_X_CLIENTE", lobjParams)
    End Sub


    Public Function Lista_CheckPoint(ByVal pdblCliente As Double, ByVal pstrCompania As String, ByVal pstrDivision As String) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_CHECKPOINT_X_CLIENTE", lobjParams)

        Return dt

    End Function

    Public Function Lista_CheckPoint_CI(ByVal pdblCliente As Double, ByVal pstrCompania As String, ByVal pstrDivision As String) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_CHECKPOINT_X_CLIENTE_CI", lobjParams)

        Return dt

    End Function


    Public Sub Mant_CheckPoint_X_Item(ByVal pstrTipo As String, ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblItem As Double, ByVal pdblParcial As Double, ByVal pdblCant As Double, ByVal pdblCheck As Double, ByVal pdblMestdo As Double, ByVal pdblFecha As Double, ByVal pstrEst As String)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PNMESTDO", pdblMestdo)
        lobjParams.Add("PNNESTDO", pdblCheck)
        lobjParams.Add("PNDFECREA", pdblFecha)
        lobjParams.Add("PNNRITOC", pdblItem)
        lobjParams.Add("PNNRPARC", pdblParcial)
        lobjParams.Add("PNQRLCSC", pdblCant)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEst)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_CHECKPOINT_X_ITEM", lobjParams)

    End Sub

    Public Sub Mant_CheckPoint_X_Item(ByRef oSqlMan As SqlManager, ByVal pstrTipo As String, ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblItem As Double, ByVal pdblParcial As Double, ByVal pdblCant As Double, ByVal pdblCheck As Double, ByVal pdblMestdo As Double, ByVal pdblFecha As Double, ByVal pstrEst As String)
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PNMESTDO", pdblMestdo)
        lobjParams.Add("PNNESTDO", pdblCheck)
        lobjParams.Add("PNDFECREA", pdblFecha)
        lobjParams.Add("PNNRITOC", pdblItem)
        lobjParams.Add("PNNRPARC", pdblParcial)
        lobjParams.Add("PNQRLCSC", pdblCant)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSSESTRG", pstrEst)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_MANT_CHECKPOINT_X_ITEM", lobjParams)

    End Sub

    Public Function Lista_CheckPoint_X_PreEmbarque(ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblParcial As Double) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PCNORCML", pstrOC)
        lobjParams.Add("PNNRPARC", pdblParcial)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_PREEMBARQUE", lobjParams)

        Return dt
    End Function

    Public Function Lista_CheckPoint_X_Embarque(ByVal obeParamCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeCheckPoint As beCheckPoint
        Dim oListCheckPoint As New List(Of beCheckPoint)
        lobjParams.Add("PSCCMPN", obeParamCheckPoint.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeParamCheckPoint.PSCDVSN)
        lobjParams.Add("PSCCLNT", obeParamCheckPoint.PNCCLNT)
        lobjParams.Add("PNNORSCI", obeParamCheckPoint.PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_EMBARQUE", lobjParams)
        For Each item As DataRow In dt.Rows
            obeCheckPoint = New beCheckPoint
            obeCheckPoint.PNNESTDO = item("NESTDO")
            obeCheckPoint.PSCEMB = HelpClass.ToStringCvr(item("CEMB"))
            obeCheckPoint.PSNOMVAR = HelpClass.ToStringCvr(item("NOMVAR"))
            obeCheckPoint.PSTDESES = HelpClass.ToStringCvr(item("TDESES"))
            obeCheckPoint.PSFESEST = HelpClass.FechaNum_a_Fecha(item("FESEST"))
            obeCheckPoint.PSFRETES = HelpClass.FechaNum_a_Fecha(item("FRETES"))
            obeCheckPoint.PNNRVARB = item("NRVARB")
            obeCheckPoint.PNNSEPRE = item("NSEPRE")
            obeCheckPoint.PSTOBS = HelpClass.ToStringCvr(item("TOBS"))
            obeCheckPoint.PSTABRST = HelpClass.ToStringCvr(item("TABRST"))



            obeCheckPoint.PSSTRNSM = HelpClass.ToStringCvr(item("STRNSM"))
            obeCheckPoint.PSRFCLNT = HelpClass.ToStringCvr(item("RFCLNT"))




            oListCheckPoint.Add(obeCheckPoint)
        Next
        Return oListCheckPoint
    End Function

    Public Function Cargar_Tipo_CheckPoint() As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCVARBL", "TIPO_CHECKPOINT")
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_VARIABLES", lobjParams)
        Return dt
    End Function

    Public Function Lista_CheckPoint_X_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PSCEMB As String, ByVal PSSESTRG As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PSCEMB", PSCEMB)
        lobjParams.Add("PSSESTRG", PSSESTRG)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_CLIENTE", lobjParams)
        For Each Item As DataRow In dt.Rows
            Item("TCOLUM") = HelpClass.ToStringCvr(Item("TCOLUM"))
            Item("TDESES") = HelpClass.ToStringCvr(Item("TDESES"))
        Next
        Return dt

    End Function




    Public Function Buscar_CheckPoint_X_Cliente(ByVal pdblCliente As Double, ByVal pstrCompania As String, ByVal pstrDivision As String, ByVal pstrTipoCheckpoint As String, ByVal pstrEstado As String, ByVal pstrCheckpoint As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        lobjParams.Add("PSCEMB", pstrTipoCheckpoint.Trim)
        lobjParams.Add("PSSESTRG", pstrEstado.Trim)
        lobjParams.Add("PNNESTDO", pstrCheckpoint.Trim)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCAR_CHECKPOINT_X_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Function Buscar_Maestro_CheckPoint(ByVal Compania As String, ByVal division As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", Compania)
        lobjParams.Add("PSCDVSN", division)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_MAESTRO_CHECKPOINT", lobjParams)
        Return dt
    End Function

   
    Public Sub Modificar_Maestro_CheckPoint(ByVal CCMPN As String, ByVal CDVSN As String, ByVal NESTDO As Decimal, ByVal TDESES As String, ByVal CEMB As String, ByVal USER As String)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", CCMPN)
        lobjParams.Add("PSCDVSN", CDVSN)
        lobjParams.Add("PNNESTDO", NESTDO)
        lobjParams.Add("PSTDESES", TDESES)
        lobjParams.Add("PSCEMB", CEMB)

        lobjParams.Add("PSUSUARIO", USER)

        lobjSql.ExecuteNonQuery("SP_SOLSC_UPDATE_MAESTRO_CHECKPOINT", lobjParams)

    End Sub


    Public Sub Insertar_Maestro_CheckPoint(ByVal CCMPN As String, ByVal CDVSN As String, ByVal TDESES As String, ByVal CEMB As String, ByVal USER As String)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", CCMPN)
        lobjParams.Add("PSCDVSN", CDVSN)
        lobjParams.Add("PSTDESES", TDESES)
        lobjParams.Add("PSCEMB", CEMB)
        lobjParams.Add("PSUSUARIO", USER)

        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERT_MAESTRO_CHECKPOINT", lobjParams)

    End Sub


    Public Sub Eliminar_Maestro_CheckPoint(ByVal NESTDO As Decimal, ByVal USER As String)

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNESTDO", NESTDO)
        lobjParams.Add("PSUSUARIO", USER)

        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_MAESTRO_CHECKPOINT", lobjParams)

    End Sub


    Public Function Buscar_CheckPoint_X_Cliente_Sec(ByVal pdblCliente As Double, ByVal pstrCompania As String, ByVal pstrDivision As String, ByVal pstrTipoCheckpoint As String, ByVal pstrCheckpoint As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        lobjParams.Add("PSCEMB", pstrTipoCheckpoint.Trim)
        lobjParams.Add("PNNESTDO", pstrCheckpoint.Trim)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCAR_CHECKPOINT_X_CLIENTE_Sec", lobjParams)
        Return dt
    End Function
    Public Function Lista_CheckPoint_X_Tipo(ByVal pstrTipo As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCEMB", pstrTipo)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_TIPO", lobjParams)
        Return dt
    End Function

    Public Function Lista_CheckPoint_X_Division(ByVal division As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCDVSN", division)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_DIVISION", lobjParams)
        Return dt
    End Function


    Public Sub Actualizar_Orden_Checkpoint(ByVal obeParamCheckPoint As beCheckPoint)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeParamCheckPoint.PNCCLNT)
        lobjParams.Add("PNNESTDO", obeParamCheckPoint.PNNESTDO)
        lobjParams.Add("PNSEPRE", obeParamCheckPoint.PNNSEPRE)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_ORDEN_CHECKPOINT", lobjParams)

    End Sub

    Public Sub Grabar_Checkpoint_X_Preembarque(ByVal obeParamCheckPoint As beCheckPoint)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRPEMB", obeParamCheckPoint.PNNRPEMB)
        lobjParams.Add("PNNESTDO", obeParamCheckPoint.PNNESTDO)
        lobjParams.Add("PNDFECEST", obeParamCheckPoint.PNFESEST)
        lobjParams.Add("PNDFECREA", obeParamCheckPoint.PNFRETES)
        lobjParams.Add("PSTOBS", obeParamCheckPoint.PSTOBS)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_CHECKPOINT_X_PREEMBARQUE", lobjParams)

    End Sub


    Public Function Lista_Datos_CheckPoint_PreEmbarque_Envio_Email(ByVal PNCCLNT As Decimal, ByVal PNFECHA_REFERENCIA As Decimal) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECHA_REFERENCIA", PNFECHA_REFERENCIA)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_DATOS_ITEM_ENVIO_EMAIL_SEGUIMIENTO_INTERNACIONAL", lobjParams)
        ds.Tables(0).TableName = "dtDatosItemOC"
        ds.Tables(1).TableName = "dtDatosCheckPoint"
        ds.Tables(2).TableName = "dtCliente"
        Return ds.Copy
    End Function

    Public Function Lista_All_CheckPoint_X_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String, ByVal PSCDVSN As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_ALL_CHECKPOINT_X_CLIENTE", lobjParams)
        Return dt
    End Function


    Public Sub Actualizar_Checkpoint(ByVal obeParamCheckPoint As beCheckPoint)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeParamCheckPoint.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeParamCheckPoint.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeParamCheckPoint.PNCCLNT)
        lobjParams.Add("PNNESTDO", obeParamCheckPoint.PNNESTDO)
        lobjParams.Add("PSTCOLUM", obeParamCheckPoint.PSTCOLUM)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PNNSEPRE", obeParamCheckPoint.PNNSEPRE)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_CHECKPOINT_X_CLIENTE", lobjParams)
    End Sub

    Public Function Lista_CheckPoint_X_Embarque_X_Tipo(ByVal obeParamCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim obeCheckPoint As beCheckPoint
        Dim oListCheckPoint As New List(Of beCheckPoint)
        lobjParams.Add("PSCCMPN", obeParamCheckPoint.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeParamCheckPoint.PSCDVSN)
        lobjParams.Add("PSCCLNT", obeParamCheckPoint.PNCCLNT)
        lobjParams.Add("PNNORSCI", obeParamCheckPoint.PNNORSCI)
        lobjParams.Add("PSCEMB", obeParamCheckPoint.PSCEMB)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_X_EMBARQUE_X_TIPO", lobjParams)
        For Each item As DataRow In dt.Rows
            obeCheckPoint = New beCheckPoint
            obeCheckPoint.PNNESTDO = item("NESTDO")
            obeCheckPoint.PSCEMB = HelpClass.ToStringCvr(item("CEMB"))
            obeCheckPoint.PSNOMVAR = HelpClass.ToStringCvr(item("NOMVAR"))
            obeCheckPoint.PSTDESES = HelpClass.ToStringCvr(item("TDESES"))
            obeCheckPoint.PSFESEST = HelpClass.FechaNum_a_Fecha(item("FESEST"))
            obeCheckPoint.PSFRETES = HelpClass.FechaNum_a_Fecha(item("FRETES"))
            obeCheckPoint.PNNRVARB = item("NRVARB")
            obeCheckPoint.PNNSEPRE = item("NSEPRE")
            obeCheckPoint.PSTOBS = HelpClass.ToStringCvr(item("TOBS"))
            obeCheckPoint.PSTABRST = HelpClass.ToStringCvr(item("TABRST"))

            obeCheckPoint.PSHRAEST = HelpClass.HoraNum_a_Hora(item("HRAEST"))
            obeCheckPoint.PSHRAREA = HelpClass.HoraNum_a_Hora(item("HRAREA"))

            oListCheckPoint.Add(obeCheckPoint)
        Next

        Return oListCheckPoint
    End Function

    'Public Overrides Sub SetStoredprocedures()

    'End Sub

    'Public Overrides Sub ToParameters(ByVal obj As Entidad.beCheckPoint)

    'End Sub


    Public Function DevuelveURL_CheckPoint(ByVal PSPROCWS As String, ByVal PNCCLNT As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSAMB", "")
        lobjParams.Add("PSPROCWS", PSPROCWS)
        lobjParams.Add("PSSPRCWS", "")
        lobjParams.Add("PSTIPPROC", "")
        lobjParams.Add("PNCCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_LISTAR_CONFIGURACION_MAPEO_URL", lobjParams)
        Return dt
    End Function


    Public Function DevuelveDataJSON_CheckPoint(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", Compania)
        lobjParams.Add("PNCCLNT", CodCliente)
        lobjParams.Add("PNNORSCI", CodEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_ENVIO_EMBARQUE_TRACKING", lobjParams)
        Return dt
    End Function


    Public Function Lista_DataJSON_TramaTracking(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim ds As DataSet
        lobjParams.Add("PSCCMPN", Compania)
        lobjParams.Add("PNCCLNT", CodCliente)
        lobjParams.Add("PNNORSCI", CodEmbarque)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTAR_ENVIO_EMBARQUE_TRACKING", lobjParams)
        'ds.Tables(0).TableName = "Json_Cab"
        'ds.Tables(1).TableName = "Json_Det"

        Return ds

    End Function
    Public Function ListarChkTracking(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter


        lobjParams.Add("PSCCMPN", Compania)
        lobjParams.Add("PNCCLNT", CodCliente)
        lobjParams.Add("PNNORSCI", CodEmbarque)

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_CHK_TRACKING", lobjParams)
        Return dt
    End Function


End Class
