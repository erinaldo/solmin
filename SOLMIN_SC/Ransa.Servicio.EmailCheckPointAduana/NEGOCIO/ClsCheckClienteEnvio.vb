Public Class ClsCheckClienteEnvio
    Private _dtListaClienteEnvio As New DataTable

    Public Function Tipo_Envio_Chk_x_Aduana() As String
        Return "SC_CHKADN"
    End Function

    Public Function Tipo_Envio_Chk_x_Local() As String
        Return "SC_CHKLOC"
    End Function

    Public Function Tipo_Envio_Chk_x_PreEmbarque() As String
        Return "SC_CHKPRB"
    End Function

    'Public Function Lista_Cliente_Envio_Notificacion(ByVal Tipo_Envio As String) As DataTable
    '    Dim odaEmbarqueEnvio As New clsEmbarqueEnvio
    '    _dtListaClienteEnvio = odaEmbarqueEnvio.LISTAR_CLIENTE_ENVIO_EMAIL_NOTIFICACION_X_TIPO_ENVIO(Tipo_Envio)
    '    Return _dtListaClienteEnvio
    'End Function

    Public Function Listar_FomatosNotificacion_X_Cliente(ByVal CCMPN As String, ByVal CDVSN As String, ByVal Tipo_Envio As String) As DataTable
        Dim odaEmbarqueEnvio As New clsEmbarqueEnvio
        _dtListaClienteEnvio = odaEmbarqueEnvio.Listar_FomatosNotificacion_X_Cliente(CCMPN, CDVSN, Tipo_Envio)
        Return _dtListaClienteEnvio
    End Function

    'Listar_FomatosNotificacion_X_Cliente


    Public Sub Asignar_Lista_Cliente_Envio_Notificacion(ByVal dtListaClienteEnvio As DataTable)
        _dtListaClienteEnvio = dtListaClienteEnvio.Copy
    End Sub

    Public Function DebeNotificarEnvio_X_Cliente(ByVal CCLNT As Decimal) As Boolean
        'si la notificacion se debe de realizar al cliente
        'Return oListCCLNTEnvioCambioChk.Contains(CCLNT.ToString)
        Dim dr() As DataRow
        Dim Enviar As Boolean = False
        dr = _dtListaClienteEnvio.Select("CCLNT='" & CCLNT & "'")
        If dr.Length > 0 Then
            Enviar = True
        End If
        Return Enviar
    End Function

    Public Function RetornaFormatoEnvio_X_Cliente(ByVal CCLNT As Decimal) As String
        'Retorna el formato a enviar al cliente
        Dim dr() As DataRow
        Dim formato As String = ""
        dr = _dtListaClienteEnvio.Select("CCLNT='" & CCLNT & "'")
        If dr.Length > 0 Then
            If Not IsDBNull(dr(0)("FORMAT_ENVIO")) Then
                formato = dr(0)("FORMAT_ENVIO").ToString().Trim()
            End If
        End If
        Return formato
    End Function
    Public Function Listar_Cliente_Check_Configurado_Notificacion(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PSNLTECL As String) As DataTable
        Dim odaEmbarqueEnvio As New clsEmbarqueEnvio
        Return odaEmbarqueEnvio.Listar_Cliente_Check_Configurado_Notificacion(PSCCMPN, PSCDVSN, PNCCLNT, PSNLTECL)
    End Function

End Class
