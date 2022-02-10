Imports System.Data
Imports System.Collections
Imports System.Xml
Imports System.io
Imports CorpesaWsLib.CorpesaWebService

Public Class CorpesaWS
 
    Public Function ConsultaInformacionCargaRetorno(ByVal Cliente As String, ByVal CodigoCorpesa As String) As Generic.List(Of InformacionCarga)
 
        Dim lstInformacionCarga As New Generic.List(Of InformacionCarga)

        Dim objWebService As New WebTrackingWS
        Dim lstr_resultado As String = (objWebService.consultaInformacionCargaDespacho("RANSA", "PLUSPETROL", Cliente, CodigoCorpesa))

        Dim objXmlDocument As New XmlDocument
        objXmlDocument.LoadXml(lstr_resultado)

        If objXmlDocument.ChildNodes.Count > 0 Then

            'Leyendo las cabeceras
            For i As Integer = 0 To objXmlDocument.ChildNodes(0).ChildNodes.Count - 1

                Dim objInformacionCarga As New InformacionCarga

                objInformacionCarga.Codigooc = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
                objInformacionCarga.Fecharecepcion = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(1).InnerText
                objInformacionCarga.Codigocarga = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText
                objInformacionCarga.Codigocargaorigen = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(3).InnerText
                objInformacionCarga.descripcion = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(4).InnerText
                objInformacionCarga.GuiaPluspetrol = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).InnerText
                objInformacionCarga.Cantidadrecibida = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).InnerText
                objInformacionCarga.Tipocarga = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).InnerText
                objInformacionCarga.Pesocarga = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(8).InnerText
                objInformacionCarga.Unidadpeso = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(9).InnerText
                objInformacionCarga.volumenCarga = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(10).InnerText
                objInformacionCarga.Unidadvolumen = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(11).InnerText
                objInformacionCarga.Numeropaleta = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(12).InnerText
                objInformacionCarga.Llegadadestino = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).InnerText
                Dim lstInformacionCargaDetalle As New Generic.List(Of InformacionCarga_Detalle)
                'Levantando los detalles
                For x As Integer = 0 To objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).ChildNodes.Count - 1
                    Dim objInformacionCarga_Detalle As New InformacionCarga_Detalle
                    objInformacionCarga_Detalle.CodigoOC = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
                    objInformacionCarga_Detalle.NumeroOC = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).ChildNodes(x).ChildNodes(0).InnerText
                    objInformacionCarga_Detalle.NumeroItem = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).ChildNodes(x).ChildNodes(1).InnerText
                    objInformacionCarga_Detalle.Cantidad = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).ChildNodes(x).ChildNodes(2).InnerText
                    objInformacionCarga_Detalle.GuiaRemision = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(13).ChildNodes(x).ChildNodes(3).InnerText
                    lstInformacionCargaDetalle.Add(objInformacionCarga_Detalle)
                Next

                'Agregando el detalle
                objInformacionCarga.InformacionCargaDetalle = lstInformacionCargaDetalle

                'Agregando el objeto
                lstInformacionCarga.Add(objInformacionCarga)

            Next

        End If

        Return lstInformacionCarga

    End Function

    Public Function ConsultaRetorno_x_Fecha_x_Cliente(ByVal Cliente As String, ByVal FecIni As String, ByVal FecFin As String) As Generic.List(Of DespachoCarga)


        Dim lstDespachoCarga As New Generic.List(Of DespachoCarga)
        Dim objWebService As New WebTrackingWS
        Dim lstr_resultado As String = (objWebService.consultaDespachosCarga("RANSA", "PLUSPETROL", Cliente, FecIni, FecFin))

        Dim objXmlDocument As New XmlDocument
        objXmlDocument.LoadXml(lstr_resultado)


        lstDespachoCarga.Clear()

        If objXmlDocument.ChildNodes.Count > 0 Then 'hay resultados

            'Leyendo las cabeceras
            For i As Integer = 0 To objXmlDocument.ChildNodes(0).ChildNodes.Count - 1

                Dim objDespachoCarga As New DespachoCarga

                objDespachoCarga.Idmovimiento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
                objDespachoCarga.Origen = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(1).InnerText
                objDespachoCarga.Destino = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(2).InnerText
                objDespachoCarga.Fechamovimiento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(3).InnerText
                objDespachoCarga.Horamovimiento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(4).InnerText

                'Datos del transportista
                objDespachoCarga.Codtransporte = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).ChildNodes(0).InnerText
                objDespachoCarga.Tipotransporte = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).ChildNodes(1).InnerText
                objDespachoCarga.Marca = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).ChildNodes(2).InnerText
                objDespachoCarga.Modelo = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).ChildNodes(3).InnerText
                objDespachoCarga.Placa = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(5).ChildNodes(4).InnerText
 
                'Datos del Chofer
                objDespachoCarga.Primernombre = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(0).InnerText
                objDespachoCarga.Segundonombre = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(1).InnerText
                objDespachoCarga.Apellidopaterno = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(2).InnerText
                objDespachoCarga.Apellidomaterno = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(3).InnerText
                objDespachoCarga.Tipodocumento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(4).InnerText
                objDespachoCarga.NumeroDocumento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(6).ChildNodes(5).InnerText



                Dim lstDespachoCargaDetalle As New Generic.List(Of DespachoCargaDetalle)

                'Levantando los detalles
                For x As Integer = 0 To objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes.Count - 1

                    Dim objDespachoCargaDetalle As New DespachoCargaDetalle

                    objDespachoCargaDetalle.IdMovimiento = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(0).InnerText
                    objDespachoCargaDetalle.IdDetalle = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(0).InnerText
                    objDespachoCargaDetalle.CodBarra = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(1).InnerText
                    objDespachoCargaDetalle.NroOrden = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(2).InnerText
                    objDespachoCargaDetalle.Tipo = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(3).InnerText
                    objDespachoCargaDetalle.Cantidad = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(4).InnerText
                    objDespachoCargaDetalle.NroGuia = objXmlDocument.ChildNodes(0).ChildNodes(i).ChildNodes(7).ChildNodes(x).ChildNodes(5).InnerText

                    lstDespachoCargaDetalle.Add(objDespachoCargaDetalle)
                Next

                'Agregando el detalle
                objDespachoCarga.DespachoDetalleCollection = lstDespachoCargaDetalle

                'Agregando el objeto
                lstDespachoCarga.Add(objDespachoCarga)
            Next

        End If

        Return lstDespachoCarga

    End Function

End Class
