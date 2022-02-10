Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Public Class ControlHito_DAL
    Private objSql As New SqlManager

    Public Function RegistrarHito(ByVal objeto As HitoOperacion) As String
        Dim objParam As New Parameter
        Dim intResultado As Int32 = 0
        Dim dt As New DataTable
        Dim msg As String = ""
        objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
        objParam.Add("PARAM_NESTDO", objeto.NESTDO)
        objParam.Add("PARAM_NGUIRM", objeto.NGUIRM)
        objParam.Add("PARAM_CTRMNC", objeto.CTRMNC)
        objParam.Add("PARAM_FRETES", objeto.FRETES)
        objParam.Add("PARAM_HRAREA", objeto.HRAREA)
        objParam.Add("PARAM_TOBEST", objeto.TOBEST)
        objParam.Add("PARAM_INCVJE", objeto.INCVJE)
        objParam.Add("PARAM_CUSCRT", objeto.CUSCRT)
        objParam.Add("PARAM_NTRMCR", objeto.NTRMCR)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRO_OPERACION_HITO_CONTROL", objParam)

        For Each Item As DataRow In dt.Rows
            If Item("STATUS") = "E" Then
                msg = msg & Item("OBSRESULT") & Chr(13)
            End If
        Next
        Return msg.Trim
    End Function
  
    'Public Sub ActualizarControlHito(ByVal objeto As HitoOperacion)
    '    Dim objParam As New Parameter
    '    objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
    '    objParam.Add("PARAM_NESTDO", objeto.NESTDO)
    '    objParam.Add("PARAM_NGUIRM", objeto.NGUIRM)
    '    objParam.Add("PARAM_CTRMNC", objeto.CTRMNC)
    '    objParam.Add("PARAM_FRETES", objeto.FRETES)
    '    objParam.Add("PARAM_HRAREA", objeto.HRAREA)
    '    objParam.Add("PARAM_TOBEST", objeto.TOBEST)
    '    objParam.Add("PARAM_INCVJE", objeto.INCVJE)
    '    objParam.Add("PARAM_CUSCRT", objeto.CUSCRT)
    '    objParam.Add("PARAM_NTRMCR", objeto.NTRMCR)
    '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_OPERACION_HITO_CONTROL", objParam)

    'End Sub

    Public Function ConsultaHito(ByVal objeto As HitoOperacion) As DataTable
        Dim objParam As New Parameter
        Dim dtb As New DataTable
        objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
        dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_HITOS_OPERACION", objParam)
        Return dtb
    End Function

    Public Function ConsultaHitoRegistrado(ByVal objeto As HitoOperacion) As DataSet
        Dim objParam As New Parameter
        Dim ds As New DataSet

        objParam.Add("PARAM_CTRMNC", objeto.CTRMNC)
        objParam.Add("PARAM_NGUIRM", objeto.NGUIRM)
        objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
        objParam.Add("PARAM_CCLNT", objeto.CCLNT)
        objParam.Add("PARAM_SNTVJE", objeto.SNTVJE)
        ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_HITO_X_CLIENTE", objParam)

        For Each Item As DataRow In ds.Tables(0).Rows
            Item("FECHA") = HelpClass.FechaNum_a_Fecha(Item("FECHA"))
            Item("HORA") = HelpClass.HoraNum_a_Hora_Cadena(Item("HORA"))

        Next

        For Each Item As DataRow In ds.Tables(1).Rows
            Item("FECHA_DESTINO") = HelpClass.FechaNum_a_Fecha(Item("FECHA_DESTINO"))
        Next

        Return ds
    End Function

    'Public Function ListaGuiasporHito(ByVal objeto As ControlHito) As DataTable
    '    Dim objParam As New Parameter
    '    Dim dtb As New DataTable
    '    objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
    '    objParam.Add("PARAM_CCLNT", objeto.CCLNT)
    '    dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_OPERACION_HITOS", objParam)
    '    Return dtb
    'End Function


    Public Function ListarHitos(ByVal objeto As ControlHito) As DataTable
        Dim objParam As New Parameter
        Dim dtb As New DataTable
        objParam.Add("PARAM_CCLNT", objeto.CCLNT)
        objParam.Add("PARAM_SNTVJE", objeto.SNTVJE)
        dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_HITOS", objParam)
        Return dtb
    End Function


      
       

    Public Sub ActualizarGuiaRemision(ByVal objeto As HitoOperacion)
        Dim objParam As New Parameter
        Dim intResultado As Int32 = 0
        Dim dt As New DataTable
        Dim msg As String = ""

        objParam.Add("PNCTRMNC", objeto.CTRMNC)
        objParam.Add("PNNGUITR", objeto.NGUITR)
        objParam.Add("PNNOPRCN", objeto.NOPRCN)
        objParam.Add("PNNESTDO", objeto.NESTDO)
        objParam.Add("PSGUIA_REMISION", objeto.GR_CLIENTE)
        objParam.Add("PNFECHA_ENTREGA", objeto.FRETES)
        objParam.Add("PNHORA_ENTREGA", objeto.HRAREA)
        objParam.Add("PSLUG_ENTREGA", objeto.LUGENTREGA)
        objParam.Add("PSCULUSA", objeto.CUSCRT)
        objParam.Add("PSTERMINAL", objeto.NTRMCR)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ESTADO_GUIA_TRANSPORTES", objParam)

    End Sub


    Public Function EliminarHito(ByVal objeto As HitoOperacion) As String
        Dim objParam As New Parameter
        Dim intResultado As Int32 = 0
        Dim dt As New DataTable
        Dim msg As String = ""
        objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
        objParam.Add("PARAM_NESTDO", objeto.NESTDO)
        objParam.Add("PARAM_NGUIRM", objeto.NGUIRM)
        objParam.Add("PARAM_CTRMNC", objeto.CTRMNC)
        objParam.Add("PARAM_CULUSA", objeto.CUSCRT)
        objParam.Add("PARAM_TERMINAL", objeto.NTRMCR)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_ELIMINAR_HITO_CONTROL", objParam)
        For Each Item As DataRow In dt.Rows
            If Item("STATUS") = "E" Then
                msg = msg & Item("OBSRESULT") & Chr(13)
            End If
        Next
        Return msg.Trim
    End Function



    Public Function ActualizarMasivoHito(ByVal objeto As HitoOperacion) As String
        Dim objParam As New Parameter
        Dim intResultado As Int32 = 0
        Dim dt As New DataTable
        Dim msg As String = ""


        objParam.Add("PNNOPRCN", objeto.NOPRCN)
        objParam.Add("PNCTRMNC", objeto.CTRMNC)
        objParam.Add("PNNGUITR", objeto.NGUITR)
        objParam.Add("PNFECHA_ENTREGA", objeto.FRETES)
        objParam.Add("PNHORA_ENTREGA", objeto.HRAREA)
        objParam.Add("PSCULUSA", objeto.CUSCRT)
        objParam.Add("PSTERMINAL", objeto.NTRMCR)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRO_CIERRE_MASIVO_HITO_CONTROL", objParam)

        For Each Item As DataRow In dt.Rows
            If Item("STATUS") = "E" Then
                msg = msg & Item("OBSRESULT") & Chr(13)
            End If
        Next
        Return msg
    End Function


    Public Function RegistrarHito_Actualizacion(ByVal objeto As HitoOperacion) As String
        Dim msg As String = ""
        Try
            Dim objParam As New Parameter
            Dim intResultado As Int32 = 0
            Dim dt As New DataTable

            objParam.Add("PARAM_NOPRCN", objeto.NOPRCN)
            objParam.Add("PARAM_NGUIRM", objeto.NGUIRM)
            objParam.Add("PARAM_CTRMNC", objeto.CTRMNC)
            objParam.Add("PARAM_TIPO_HITO", objeto.TIPO_HITO)
            objParam.Add("PARAM_FRETES", objeto.FRETES)
            objParam.Add("PARAM_HRAREA", objeto.HRAREA)
            objParam.Add("PARAM_TOBEST", objeto.TOBEST)
            objParam.Add("PARAM_INCVJE", objeto.INCVJE)
            objParam.Add("PARAM_CUSCRT", objeto.CUSCRT)
            objParam.Add("PARAM_NTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRO_HITO_ACTUALIZACION", objParam)

            For Each Item As DataRow In dt.Rows
                If Item("STATUS") = "E" Then
                    msg = msg & Item("OBSRESULT") & Chr(13)
                End If
            Next
        Catch ex As Exception
            msg = ex.Message
        End Try
        Return msg.Trim
    End Function


End Class
