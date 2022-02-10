Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsCliente

    Inherits clsBase(Of Cliente)


    Public Function Lista_Cliente_X_Usuario() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CLIENTE_X_USUARIO", lobjParams)
        Return dt
    End Function
    Public Function Busca_Cliente_Grupo(ByVal CodigoGrupo As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTCL", CodigoGrupo)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_CLIENTE_GRUPO", lobjParams)
        Return dt
    End Function
    '-----Mantenimiento de Cartera Cliente----------
    Public Function Lista_Cliente_Cartera() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_CARTERA_CLIENTE", Nothing)
        Return dt
    End Function

    Public Sub Actualizar_Cliente_Cartera(ByVal pobjCliente As Cliente)
        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNNRCTCL", pobjCliente.NRCTCL)
        lobjParams.Add("PSDESCAR", pobjCliente.DESCAR)
        lobjParams.Add("PSNOMCAR", pobjCliente.NOMCAR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSCRGVTA", pobjCliente.CRGVTA)
        lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_CARTERA_CLIENTE", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Sub Agregar_Cliente_Cartera(ByVal pobjCliente As Cliente)
        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSDESCAR", pobjCliente.DESCAR)
        lobjParams.Add("PSNOMCAR", pobjCliente.NOMCAR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
        lobjParams.Add("PSCRGVTA", pobjCliente.CRGVTA)
        lobjSql.ExecuteNonQuery("SP_SOLCT_AGREGAR_CARTERA_CLIENTE", lobjParams)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    Public Function Eliminar_Cliente_Cartera(ByVal pobjCliente As Cliente) As String
        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim msg As String = ""

        lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
        lobjParams.Add("PNNRCTCL", pobjCliente.NRCTCL)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        'lobjParams.Add("PNERROR", 0, ParameterDirection.Output)

        'lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_CARTERA_CLIENTE", lobjParams)
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_ANULAR_CARTERA_CLIENTE_V2", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim
        'Return lobjSql.ParameterCollection.Item("PNERROR")
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Return msg
    End Function
    '-------------------------------Mantenimiento Relacion Cliente-----------------------------------------
    Public Function Lista_Cliente_Cartera_Relacion() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_CARTERA_CLIENTE_RELACION", Nothing)
        Return dt
    End Function
    Public Function Eliminar_Cliente_Cartera_Relacion_V2(ByVal pobjCliente As Cliente) As String
        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim msg_val As String = ""


        lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
        lobjParams.Add("PNNRCTCL", pobjCliente.NRCTCL)
        lobjParams.Add("PNCCLNT", pobjCliente.CCLNT)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        'lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        'lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_CARTERA_CLIENTE_RELACION", lobjParams)
        Dim dt As New DataTable
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_ANULAR_CARTERA_CLIENTE_RELACION", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg_val = msg_val & item("OBSRESULT") & Chr(10)
            End If
        Next
        Return msg_val
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Function


    

    Public Sub Agregar_Cliente_Cartera_Relacion(ByVal pobjCliente As Cliente)
        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNNRCTCL", pobjCliente.NRCTCL)
        lobjParams.Add("PNCCLNT", pobjCliente.CCLNT)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        'lobjParams.Add("VS_REGISTRO", 0, ParameterDirection.Output)
        lobjParams.Add("PSCCMPN", pobjCliente.CCMPN)
        lobjSql.ExecuteNonQuery("SP_SOLCT_AGREGAR_CARTERA_CLIENTE_RELACION", lobjParams)
        'pobjCliente.Correcto = lobjSql.ParameterCollection("VS_REGISTRO")
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub


#Region "Lista Cartera Cliente"

    Public Function floListaCarteCliente(ByVal oCliente As Cliente, ByRef TotalPag As Decimal) As List(Of Cliente)

        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSCCMPN", oCliente.CCMPN)
        lobjParams.Add("PNNRCTCL", oCliente.NRCTCL)
        lobjParams.Add("PNCCLNT", oCliente.CCLNT)
        lobjParams.Add("PSSESTRG", oCliente.SESTRG)
        lobjParams.Add("PSLIST_CRGVTA", oCliente.LIST_CRGVTA)

        lobjParams.Add("IN_NROPAG", oCliente.NROPAG)
        lobjParams.Add("PAGESIZE", oCliente.PageSize)

        Dim oList As New List(Of Cliente)
        Dim beCliente As Cliente

        Dim ds As New DataSet
        ds = lobjSql.ExecuteDataSet("SP_SOLCT_BUSCA_CARTERA_CLIENTE_V1", lobjParams)

        For Each item As DataRow In ds.Tables(0).Rows
            beCliente = New Cliente
            beCliente.CCMPN = item("CCMPN")
            beCliente.NRCTCL = item("NRCTCL")
            beCliente.DESCAR = item("DESCAR")
            beCliente.NOMCAR = item("NOMCAR")
            beCliente.SESTRG = item("SESTRG")
            beCliente.CRGVTA = item("CRGVTA")
            beCliente.TCRVTA = item("TCRVTA")
            beCliente.CRGVTA = item("CRGVTA")
            beCliente.DESCP_ESTADO = item("DESCP_ESTADO")
            oList.Add(beCliente)
        Next
       
        TotalPag = ds.Tables(1).Rows(0)("NUM_PAG")

        'Return Listar("SP_SOLCT_BUSCA_CARTERA_CLIENTE_V1", lobjParams)
        'Return Listar("SP_SOLCT_BUSCA_CARTERA_CLIENTE", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of Cliente)
        'End Try

        Return oList
    End Function

    Public Function floListaClienteXGrupo(ByVal oCliente As Cliente) As List(Of Cliente)

        'Try
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", oCliente.CCMPN)
        lobjParams.Add("PNNRCTCL", oCliente.NRCTCL)
        Return Listar("SP_SOLCT_BUSCA_CARTERA_CLIENTE_RELACION", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of Cliente)
        'End Try
    End Function


    Public Function ListaCarteraAsociadoxCliente(ByVal PNNRCTCL As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PNNRCTCL", PNNRCTCL)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCCMPN", PSCCMPN)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CARTERA_ASOCIADOS_X_CLIENTE", lobjParams)
        Return dt
    End Function

    '<[AHM]>
    Public Function PerteneceASalmon(ByVal PSCMCPN As String) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("IN_CODVAR", "SALMON")
        lobjParams.Add("IN_CCMPRN", PSCMCPN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TABLA_AYUDA", lobjParams)
        Return dt
    End Function
    '</[AHM]>
#End Region


#Region "Resumen Mensual Almacens"
    'SP_SOLCT_LISTA_CLIENTE_SOMIN
    Public Function fodtListaClientesSOLMIN(ByVal obeCliente As Cliente) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PSCCMPN", obeCliente.CCMPN)
        lobjParams.Add("PSLIST_CRGVTA", obeCliente.LIST_CRGVTA)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CLIENTE_SOMIN", lobjParams)
        'Catch ex As Exception
        '    dt = New DataTable
        'End Try
        Return dt
    End Function
#End Region

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidades.Cliente)

    End Sub

    'RCS-HUNDRED-INICIO
    Public Function Validar_Cliente_Interno(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("CCMPN", CCMPN)
        lobjParams.Add("PNNRCTSL", PNNRCTSL)
        Return Listar("SP_SOLMIN_CT_VALIDAR_CLIENTE_INTERNO_X_CONTRATO", lobjParams)
    End Function

    Public Function Validar_Cliente_Interno_Factura(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal) As List(Of Cliente)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        Return Listar("SP_SOLMIN_ST_VALIDAR_CLIENTE_INTERNO", lobjParams)
    End Function
    'RCS-HUNDRED-FIN



    'JM  09-11-2015
    Public Function Validar_Cliente_Interno_v2(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("CCMPN", CCMPN)
        lobjParams.Add("PNNRCTSL", PNNRCTSL)
        Return Listar("SP_SOLMIN_CT_VALIDAR_CLIENTE_INTERNO", lobjParams)
    End Function


    Public Function Lista_Cliente() As List(Of Cliente)
        Dim output As New List(Of Cliente)
        Dim dt As New DataTable
        Dim sqlManager As New SqlManager
        Dim lobjParams As New Parameter
        dt = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_DIRECCIONES_PROPIO", lobjParams)
        Dim entidad As Cliente
        For Each dr As DataRow In dt.Rows
            entidad = New Cliente
            entidad.CCLNT = dr("CCLNT5")
            entidad.DESCAR = dr("TSCDSP")
            output.Add(entidad)
        Next
        Return output
    End Function


End Class
