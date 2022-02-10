Imports CorpesaWsLib

Public Class InterfaseCorpesa

    Public Function fdtListObtenerCabeceraDocumento(ByVal oParametros As Hashtable) As List(Of CorpesaWsLib.DespachoCarga)
        Dim obeCabeceraDoc As New CorpesaWsLib.InformacionCarga

        Dim x As New CorpesaWsLib.CorpesaWS
        'Return x.ConsultaRetorno_x_Fecha_x_Cliente(oParametros.Item("CodCliente").ToString, oParametros.Item("FechaIni"), oParametros.Item("FechaFin"))
        Return x.ConsultaRetorno_x_Fecha_x_Cliente(oParametros.Item("CodCliente").ToString, HelpClass.CtypeDate(oParametros.Item("FechaIni")), HelpClass.CtypeDate(oParametros.Item("FechaFin")))
    End Function

    Public Function fdtObtenerCabeceraDocumento(ByVal oParametros As Hashtable) As List(Of CorpesaWsLib.InformacionCarga)
        Dim obeCabeceraDoc As New CorpesaWsLib.InformacionCarga

        Dim x As New CorpesaWsLib.CorpesaWS
        Return x.ConsultaInformacionCargaRetorno(oParametros.Item("CodCliente").ToString, oParametros.Item("NrDoc").ToString)
    End Function



End Class
