Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDSW
'Agregado para Almaceneras
Module mAlmacenOrden
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    'Agregado para Alamceneras
    '-------------------------------------------'
    '- Funciones para Anular Ticket -'
    '-------------------------------------------'
    Public Function mfblnProceso_AnularTicket(ByVal objfiltro As clsFiltros_SDSWAnularTicket) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objticket As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objticket.fblnSDSWAnularTicket(strMensajeError, objfiltro)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objticket = Nothing
        Return blnResultado
    End Function

    Public Function mfblnProceso_CerrarTicket(ByVal objfiltro As clsFiltros_SDSWAnularTicket) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objticket As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objticket.fblSDSWCerrarTicket(strMensajeError, objfiltro)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objticket = Nothing
        Return blnResultado
    End Function
  
#End Region
End Module


