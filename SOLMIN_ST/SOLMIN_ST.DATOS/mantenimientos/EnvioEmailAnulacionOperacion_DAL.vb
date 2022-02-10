Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Namespace mantenimientos

    'Public Class EnvioEmailAnulacionOperacion_DAL
    '    Private objSql As New SqlManager

    '    Public Function DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(ByVal PNCCLNT As Decimal, ByVal PSTIPPROC As String) As List(Of beDestinatario)

    '        Dim lobjSql As New SqlManager

    '        Dim oListDestinatarios As New List(Of beDestinatario)
    '        Dim obeDestinatario As beDestinatario
    '        Dim odtDatos As New DataTable
    '        Dim odtSeguimiento As New DataTable
    '        Dim lobjParams As New Parameter
    '        lobjParams.Add("PNCCLNT", 999999)
    '        lobjParams.Add("PSTIPPROC", PSTIPPROC)


    '        odtDatos = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EMAIL_ENVIO_RZOL05B1", lobjParams)

    '        For Each dr As DataRow In odtDatos.Rows

    '            'obeDestinatario = New beDestinatario
    '            'obeDestinatario.PNCCLNT = dr("CCLNT")
    '            'obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
    '            'obeDestinatario.PSBU = ("" & dr("NLTECL")).ToString.Trim
    '            'obeDestinatario.PSTIPPROC = ("" & dr("TIPPROC")).ToString.Trim
    '            'obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
    '            obeDestinatario = New beDestinatario
    '            obeDestinatario.PNCCLNT = dr("CCLNT")
    '            obeDestinatario.PSEMAILTO = ("" & dr("EMAILTO")).ToString.Trim
    '            obeDestinatario.PSTIPO_ENVIO = ("" & dr("TIPO_ENVIO")).ToString.Trim
    '            obeDestinatario.PSDIV_ENVIO = ("" & dr("DIV_ENVIO")).ToString.Trim
    '            obeDestinatario.PSTIP_MAIL_DEST = ("" & dr("TIP_MAIL_DEST")).ToString.Trim
    '            obeDestinatario.PSDES_CLIENTE = ("" & dr("TCMPCL")).ToString.Trim
    '            oListDestinatarios.Add(obeDestinatario)

    '        Next
    '        Return oListDestinatarios

    '    End Function
    'End Class

End Namespace