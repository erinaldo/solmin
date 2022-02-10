
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES

Namespace Operaciones
  Public Class SolicitudPedidoEfectivo_DAL

    Private objSql As New SqlManager

    Public Function ListaSolicitud_Pedido_Efectivo(ByVal objPedidoEfectivo As PedidoEfectivo) As List(Of PedidoEfectivo)
      Dim objDataTable As New DataTable
      Dim objEntidad As PedidoEfectivo
      Dim objLisEntidad As New List(Of PedidoEfectivo)
      Dim objParam As New Parameter
      Try
        objParam.Add("PSCCMPN", objPedidoEfectivo.CCMPN)
        objParam.Add("PSCDVSN", objPedidoEfectivo.CDVSN)
        objParam.Add("PSCPLNDV", objPedidoEfectivo.CPLNDV)
        objParam.Add("PNFECINI", objPedidoEfectivo.FECINI)
        objParam.Add("PNFECFIN", objPedidoEfectivo.FECFIN)
        objParam.Add("PNCOBRR", objPedidoEfectivo.COBRR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objPedidoEfectivo.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_PEDIDO_EFECTIVO", objParam)

        For Each objDataRow As DataRow In objDataTable.Rows
          objEntidad = New PedidoEfectivo
          objEntidad.NMSLPE = objDataRow("NMSLPE").ToString.Trim
          objEntidad.FCSLPE = objDataRow("FCSLPE").ToString.Trim
          objEntidad.FESLPE = objDataRow("FESLPE").ToString.Trim
          objEntidad.TMNDA = objDataRow("TMNDA").ToString.Trim
          objEntidad.ISLPES = objDataRow("ISLPES").ToString.Trim
          objEntidad.ISLPED = objDataRow("ISLPED").ToString.Trim
          objEntidad.IMTPOC = objDataRow("IMTPOC").ToString.Trim
          objEntidad.MOTIVO = objDataRow("MOTIVO").ToString.Trim
          objEntidad.TNMBOB = objDataRow("TNMBOB").ToString.Trim
          objEntidad.NORDSR = objDataRow("NORDSR").ToString.Trim
          objEntidad.FSTTRS = objDataRow("FSTTRS").ToString.Trim
          objEntidad.NRFSAP = objDataRow("NRFSAP").ToString.Trim
          objEntidad.MTVGRO = objDataRow("MTVGRO").ToString.Trim
          objEntidad.CODDES = objDataRow("CODDES").ToString.Trim
          If objDataRow("FCUSPV").ToString.Trim <> "00/00/0000" Then
            objEntidad.FCUSPV = objDataRow("FCUSPV").ToString.Trim
          End If
          objEntidad.HRUSPV = objDataRow("HRUSPV").ToString.Trim
          objEntidad.USRSPV = objDataRow("USRSPV").ToString.Trim
          objEntidad.NPLCUN = objDataRow("NPLCUN").ToString.Trim
          objEntidad.NORINS = objDataRow("NORINS").ToString.Trim

          If objEntidad.NRFSAP <> 0 Then
            If objEntidad.FSTTRS.Equals("*") Then
              objEntidad.ESTADO = "*"
            End If
            objEntidad.ESTADO = "S"
          Else
            If objDataRow("SESTRG").Equals("*") Then
              objEntidad.ESTADO = "*"
            Else
              objEntidad.ESTADO = "P"
            End If

          End If
          objEntidad.SCNTR = objDataRow("SCNTR").ToString.Trim
          objLisEntidad.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objLisEntidad
    End Function

    Public Function Lista_Obrero() As List(Of ClaseGeneral)
      Dim objLisClaseGeneral As New List(Of ClaseGeneral)
      Dim objEntidad As ClaseGeneral
      Dim oDt As DataTable
      Try
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OBREROS", Nothing)
        For Each objDataRow As DataRow In oDt.Rows

          objEntidad = New ClaseGeneral
          objEntidad.COBRR = objDataRow("COBRR").ToString.Trim
          objEntidad.TNMBOB = objDataRow("TNMBOB").ToString.Trim
          objLisClaseGeneral.Add(objEntidad)
        Next
      Catch ex As Exception
      End Try
      Return objLisClaseGeneral
    End Function

    Public Function Validar_Numero_Operacion(ByVal Operacion As Double) As Boolean
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNOPERN", 0, ParameterDirection.Output)
        objParam.Add("PNNOPRCN", Operacion)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_NUMERO_OPERACION", objParam)

        If objSql.ParameterCollection("PNNOPERN") <> 0 Then
          Return True
        Else
          Return False
        End If
      Catch ex As Exception
        Return False
      End Try
    End Function

    Public Function Lista_Obrero_x_Codigo(ByVal objetoParametro As Hashtable) As ClaseGeneral
      Dim objParam As New Parameter
      Dim oDt As DataTable
      Dim objEntidad As New ClaseGeneral

      Try
        objParam.Add("PNCOBRR", objetoParametro("COBRR"))

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OBRERO_X_CODIGO", objParam)

        For Each objDataRow As DataRow In oDt.Rows
          objEntidad.COBRR = objDataRow("COBRR").ToString.Trim()
          objEntidad.CMTCDS = objDataRow("CMTCDS").ToString.Trim()
        Next
        Return objEntidad
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function Validar_Usuario_Autorizado(ByVal objetoParametro As Hashtable) As ClaseGeneral
      Dim objParam As New Parameter
      Dim oDt As DataTable
      Dim objEntidad As New ClaseGeneral
      Try
        objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
        objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
        objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_USUARIO_AUTORIZADO_SOL_PED_EFECTIVO", objParam)
        For Each objDataRow As DataRow In oDt.Rows
          objEntidad.STSOP1 = objDataRow("STSOP1").ToString.Trim()
          objEntidad.STSOP2 = objDataRow("STSOP2").ToString.Trim()
          objEntidad.STSADI = objDataRow("STSADI").ToString.Trim()
        Next
        Return objEntidad
      Catch ex As Exception
        Return objEntidad
      End Try
    End Function

    Public Function Obtener_Placa_X_Operacion(ByVal objetoParametro As Hashtable) As List(Of SolicitudEfectivoSAP)
      Dim objParam As New Parameter
      Dim oDt As DataTable
      Dim objEntidad As New SolicitudEfectivoSAP
      Dim objLisEntidad As New List(Of SolicitudEfectivoSAP)
            'Try
            objParam.Add("PNNOPRCN", objetoParametro("NOPRCN"))
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_PLACA_X_OPERACION", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad = New SolicitudEfectivoSAP
                objEntidad.NPLCUN = objDataRow("NPLCTR").ToString.Trim()
                objEntidad.NORINS = objDataRow("NORINS").ToString.Trim()
                objEntidad.RUTA = objDataRow("ORIGEN").ToString.Trim() + " - " + objDataRow("DESTINO").ToString.Trim()
                objEntidad.CLCLOR = objDataRow("CLCLOR").ToString.Trim()
                objEntidad.CLCLDS = objDataRow("CLCLDS").ToString.Trim()
                objEntidad.NORSRT = objDataRow("NORSRT").ToString.Trim()
                objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim()
                objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim()
                objEntidad.CONDUCTOR1 = objDataRow("CONDUCTOR1").ToString.Trim()
                objEntidad.CBRCN2 = objDataRow("CBRCN2").ToString.Trim()
                objEntidad.CONDUCTOR2 = objDataRow("CONDUCTOR2").ToString.Trim()
                objEntidad.COMENTARIO = objEntidad.NPLCUN + " - " + objEntidad.CBRCNT + " - " + objEntidad.CONDUCTOR1
                objEntidad.CODSAP = ("" & objDataRow("CODSAP")).ToString.Trim()
                objEntidad.CODSAP2 = ("" & objDataRow("CODSAP2")).ToString.Trim()
                objLisEntidad.Add(objEntidad)
            Next
            Return objLisEntidad
            'Catch ex As Exception
            'Return objLisEntidad
            'End Try
    End Function

    Public Function Reporte_Lista_Pedido_Efectivo(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
      Dim objParam As New Parameter
      Dim oDt As DataTable
      Dim objGenericCollection As New List(Of ClaseGeneral)
      Dim objEntidad As New ClaseGeneral
      Try
        objParam.Add("PSCCMPN", objetoParametro("CCMPN"))
        objParam.Add("PSCDVSN", objetoParametro("CDVSN"))
        objParam.Add("PSCPLNDV", objetoParametro("CPLNDV"))
        objParam.Add("PNFECINI", objetoParametro("FECINI"))
        objParam.Add("PNFECFIN", objetoParametro("FECFIN"))
        objParam.Add("PNCOBRR", objetoParametro("COBRR"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_LISTA_PEDIDO_EFECTIVO", objParam)
        For Each objData As DataRow In oDt.Rows
          objEntidad = New ClaseGeneral
          objEntidad.NMSLPE = objData("NMSLPE")
          objEntidad.COBRR = objData("COBRR")
          objEntidad.NOMCHOFER = objData("TNMBOB")
          objEntidad.FCJSPE = objData("FCJSPE")
          objEntidad.FESLPE = objData("FCSLPE")
          objEntidad.NOPRCN = objData("NORDSR")
          objEntidad.ORIGEN = objData("ORIGEN")
          objEntidad.DESTIN = objData("DESTIN")
          objEntidad.ISLPES = objData("ISLPESA")
          If objData("ISLPESP") Is DBNull.Value Then
            objEntidad.ISLPESP = 0
          Else
            objEntidad.ISLPESP = objData("ISLPESP")
          End If

          objEntidad.ESTADO = objData("ESTADO")
          objEntidad.FECINI = Validacion.CNumero_a_Fecha(objetoParametro("FECINI"))
          objEntidad.FECFIN = Validacion.CNumero_a_Fecha(objetoParametro("FECFIN"))
          objEntidad.USUARIO = objetoParametro("USUARIO")
          objGenericCollection.Add(objEntidad)
        Next
        Return objGenericCollection
      Catch ex As Exception
        Return objGenericCollection
      End Try
    End Function

  End Class
End Namespace

