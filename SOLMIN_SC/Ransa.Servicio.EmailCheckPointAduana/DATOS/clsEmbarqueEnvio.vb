Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsEmbarqueEnvio
    'Public Function DATO_EMBARQUE_ENVIO_EMAIL_CHEKPOINT(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim odtDatos As New DataTable
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PNNORSCI", PNNORSCI)
    '    odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_EMBARQUE_ENVIO_EMAIL", lobjParams)
    '    Return odtDatos
    'End Function
    'Public Function OBS_EMBARQUE_ENVIO_EMAIL_CHEKPOINT(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim odtDatos As New DataTable
    '    Dim odsDatos As New DataSet
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PNNORSCI", PNNORSCI)
    '    odsDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_ENVIO_EMAIL", lobjParams)
    '    odtDatos = odsDatos.Tables(1).Copy()
    '    Return odtDatos
    'End Function
    'Public Function DETALLE_OC_EMBARQUE_ENVIO_EMAIL(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataSet
    '    Dim lobjSql As New SqlManager
    '    Dim odtDatos As New DataSet
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PNNORSCI", PNNORSCI)
    '    odtDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DETALLE_OC_EMBARQUE_ENVIO_EMAIL", lobjParams)
    '    Return odtDatos
    'End Function
    'Public Function DESTINATARIO_ENVIO_EMAIL_CHECKPOINT(ByVal PNCCLNT As Decimal) As List(Of beDestinatario)
    '    Dim lobjSql As New SqlManager
    '    Dim oListDestinatarios As New List(Of beDestinatario)
    '    Dim obeDestinatario As beDestinatario
    '    Dim odtDatos As New DataTable
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_DESTINATARIO_ENVIO_EMAILS", lobjParams)
    '    For Each dr As DataRow In odtDatos.Rows
    '        obeDestinatario = New beDestinatario
    '        obeDestinatario.PNCCLNT = dr("CCLNT")
    '        obeDestinatario.PSEMAILTO = dr("EMAILTO").ToString.Trim
    '        obeDestinatario.PSBU = dr("BU").ToString.Trim
    '        oListDestinatarios.Add(obeDestinatario)
    '    Next
    '    Return oListDestinatarios
    'End Function

    'Public Function DESTINATARIO_ENVIO_EMAIL_X_TIPO_ENVIO(ByVal PNCCLNT As Decimal, ByVal PSTIPO_ENVIO As String) As List(Of beDestinatario)

    '    Dim lobjSql As New SqlManager

    '    Dim oListDestinatarios As New List(Of beDestinatario)
    '    Dim obeDestinatario As beDestinatario
    '    Dim odtDatos As New DataTable
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PSTIPPROC", PSTIPO_ENVIO)

    '    odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_DESTINATARIO_ENVIO_EMAILS_X_TIPO_ENVIO", lobjParams)

    '    For Each dr As DataRow In odtDatos.Rows

    '        obeDestinatario = New beDestinatario
    '        obeDestinatario.PNCCLNT = dr("CCLNT")
    '        obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
    '        obeDestinatario.PSTIPO_ENVIO = ("" & dr("TIPO_ENVIO")).ToString.Trim
    '        obeDestinatario.PSDIV_ENVIO = ("" & dr("DIV_ENVIO")).ToString.Trim
    '        obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
    '        obeDestinatario.PSDES_CLIENTE = ("" & dr("TCMPCL")).ToString.Trim
    '        oListDestinatarios.Add(obeDestinatario)


    '    Next
    '    Return oListDestinatarios

    'End Function

    'Public Function LISTAR_CLIENTE_ENVIO_EMAIL_NOTIFICACION_X_TIPO_ENVIO(ByVal PSTIPO_ENVIO As String) As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim odtDatos As New DataTable
    '    Dim odtSeguimiento As New DataTable
    '    Dim lobjParams As New Parameter
    '    lobjParams.Add("PSTIPO_ENVIO", PSTIPO_ENVIO)
    '    odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CLIENTE_ENVIO_EMAILS_X_TIPO_ENVIO", lobjParams)
    '    Return odtDatos
    'End Function


    Public Function Listar_FomatosNotificacion_X_Cliente(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PSTIPO_ENVIO As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PSTIPO_ENVIO", PSTIPO_ENVIO)
        odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CLIENTE_ENVIO_EMAILS_X_TIPO_ENVIO", lobjParams)
        Return odtDatos
    End Function

    Public Function Listar_Cliente_Check_Configurado_Notificacion(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PSNLTECL As String) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNLTECL", PSNLTECL)
        odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_CLIENTE_CHECKPOINTS_CONFIGURADOS_NOTIFICACION", lobjParams)
        Return odtDatos
    End Function

    Public Function Listar_datos_Embarque_Chk_Notificacion(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PSNLTECL As String) As DataSet
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataSet
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSNLTECL", PSNLTECL)
        odtDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_CHECKPOINT_NOTIFICACION", lobjParams)
        Return odtDatos
    End Function

    Public Function Listar_Datos_Cuerpo_Envio_Email(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataSet
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataSet
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        odtDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_CUERPO_ENVIO_EMAIL", lobjParams)
        Return odtDatos
    End Function


    Public Function Listar_datos_Embarque_Chk_Notificacion_Local(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PSNLTECL As String) As DataSet
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataSet
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PSNLTECL", PSNLTECL)


        odtDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_CHECKPOINT_NOTIFICACION_LOCAL", lobjParams)
        Return odtDatos
    End Function

   

    Public Function Listar_Datos_Cuerpo_Envio_Email_Local(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataSet
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataSet
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        odtDatos = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_EMBARQUE_CUERPO_ENVIO_EMAIL_LOCAL", lobjParams)
        Return odtDatos
    End Function

    Public Function Listar_Destinatarios_Envio_Notificacion(ByVal PNCCLNT As Decimal, ByVal PSTIPO_ENVIO As String, ByRef dtClienteNotifBU As DataTable) As List(Of beDestinatario)

        Dim lobjSql As New SqlManager

        Dim result As New DataSet

        Dim oListDestinatarios As New List(Of beDestinatario)
        Dim obeDestinatario As beDestinatario
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSTIPPROC", PSTIPO_ENVIO)

        result = lobjSql.ExecuteDataSet("SP_SOLSC_DATOS_DESTINATARIO_ENVIO_NOTIFICACION_TIPO_PROC", lobjParams)
        odtDatos = result.Tables(0).Copy
        dtClienteNotifBU = result.Tables(1).Copy

        For Each dr As DataRow In odtDatos.Rows

            obeDestinatario = New beDestinatario
            obeDestinatario.PNCCLNT = dr("CCLNT")
            obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
            obeDestinatario.PSTIPO_ENVIO = ("" & dr("TIPO_ENVIO")).ToString.Trim
            obeDestinatario.PSDIV_ENVIO = ("" & dr("DIV_ENVIO")).ToString.Trim
            obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
            obeDestinatario.PSDES_CLIENTE = ("" & dr("TCMPCL")).ToString.Trim
            oListDestinatarios.Add(obeDestinatario)


        Next
        Return oListDestinatarios

    End Function

    Public Function Listar_datos_Embarque_Chk_Actual(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim odtDatos As New DataTable
        Dim odtSeguimiento As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)

        odtDatos = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_EMBARQUE_CHECKPOINT_ACTUAL", lobjParams)
        Return odtDatos
    End Function

End Class
