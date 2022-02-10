Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class PedidoEfectivo_DAL
    Private objSql As New SqlManager

    Public Function Guardar_Pedido_Efectivo(ByVal objPedidoEfectivo As PedidoEfectivo) As PedidoEfectivo
        Dim oDt As DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNCSOTR", objPedidoEfectivo.NCSOTR)
            objParam.Add("PNNCRRSR", objPedidoEfectivo.NCRRSR)
            objParam.Add("PSCCMPN", objPedidoEfectivo.CCMPN)
            objParam.Add("PSCDVSN", objPedidoEfectivo.CDVSN)
            objParam.Add("PNCPLNDV", objPedidoEfectivo.CPLNDV)
            objParam.Add("PSTPSLPE", objPedidoEfectivo.TPSLPE)
            objParam.Add("PNFCSLPE", objPedidoEfectivo.FCJSPE)
            objParam.Add("PNISLPES", objPedidoEfectivo.ISLPES)
            objParam.Add("PSMOTIVO", objPedidoEfectivo.MOTIVO)
            objParam.Add("PNNORDSR", objPedidoEfectivo.NORDSR)
            objParam.Add("PSNPLCUN", objPedidoEfectivo.NPLCUN)
            objParam.Add("PSSESTRG", objPedidoEfectivo.SESTRG)
            If objPedidoEfectivo.MTVGRO.Trim.Length > 30 Then
                objParam.Add("PSMTVGRO", objPedidoEfectivo.MTVGRO.Trim.Substring(0, 30))
            Else
                objParam.Add("PSMTVGRO", objPedidoEfectivo.MTVGRO.Trim)
            End If
            objParam.Add("PNDATCRT", objPedidoEfectivo.DATCRT)
            objParam.Add("PNHRACRT", objPedidoEfectivo.HRACRT)
            objParam.Add("PSUSRCRT", objPedidoEfectivo.USRCRT)
            objParam.Add("PSNTRMNL", objPedidoEfectivo.NTRMNL)
            objParam.Add("PNCODDES", objPedidoEfectivo.CODDES)
            objParam.Add("PSCBRCNT", objPedidoEfectivo.CBRCNT)
            objParam.Add("PNNOPRCN", objPedidoEfectivo.NOPRCN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objPedidoEfectivo.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_PEDIDO_EFECTIVO", objParam)

            For Each objData As DataRow In oDt.Rows
                objPedidoEfectivo = New PedidoEfectivo
                objPedidoEfectivo.NMSLPE = oDt.Rows(0).Item("NMSLPE")
            Next
        Catch ex As Exception
            objPedidoEfectivo.NMSLPE = 0
        End Try
        Return objPedidoEfectivo
    End Function

    Public Function Generar_Codigo(ByVal pstrCompañia As String, ByVal pdblZona As Double) As Double
        Dim oDt As DataTable
        Dim dblCodigo As Double
        'Try
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", pstrCompañia)
        objParam.Add("PNCPLNDV", pdblZona)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pstrCompañia)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GENERAR_CODIGO_PEDIDO_EFECTIVO", objParam)
        If oDt.Rows.Count > 0 Then
            dblCodigo = oDt.Rows(0).Item(0)
        Else
            dblCodigo = 0
        End If
        'Catch ex As Exception
        '    dblCodigo = 0
        'End Try
        Return dblCodigo
    End Function

    Public Function Lista_Pedido_Efectivo(ByVal pdblNrPedido As Double) As PedidoEfectivo
        Dim objParam As New Parameter
        Dim objEntidad As New PedidoEfectivo
        Dim oDt As DataTable
        Try
            objParam.Add("PNNCTAVC", pdblNrPedido)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PEDIDO_EFECTIVO", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New PedidoEfectivo
                objEntidad.NMSLPE = oDt.Rows(0).Item("NMSLPE")
                objEntidad.FCSLPE = oDt.Rows(0).Item("FCSLPE")
                objEntidad.CMSLPE = oDt.Rows(0).Item("CMSLPE")
                objEntidad.ISLPES = oDt.Rows(0).Item("ISLPES")
                objEntidad.ISLPED = oDt.Rows(0).Item("ISLPED")
                objEntidad.MOTIVO = oDt.Rows(0).Item("MOTIVO")
                objEntidad.MTVGRO = oDt.Rows(0).Item("MTVGRO")
                objEntidad.NRFSAP = oDt.Rows(0).Item("NRFSAP")
                objEntidad.FSTTRS = oDt.Rows(0).Item("FSTTRS")
            Next
        Catch ex As Exception
            objEntidad.NMSLPE = 0
        End Try
        Return objEntidad
    End Function

    Public Sub Actualizar_Supervisor(ByVal objEntidad As PedidoEfectivo)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objParam.Add("PNNMSLPE", objEntidad.NMSLPE)
        objParam.Add("PNFCUSPV", objEntidad.FCUSPV)
        objParam.Add("PNHRUSPV", objEntidad.HRUSPV)
        objParam.Add("PSUSRSPV", objEntidad.USRSPV)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ACTUALIZAR_SUPERVISOR_PEDIDO_EFECTIVO", objParam)

        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Function Auditoria(ByVal objPedidoEfectivo As PedidoEfectivo) As PedidoEfectivo
        Dim objParam As New Parameter
        Dim oDt As DataTable
        Try
            objParam.Add("PSCCMPN", objPedidoEfectivo.CCMPN)
            objParam.Add("PSCDVSN", objPedidoEfectivo.CDVSN)
            objParam.Add("PNCPLNDV", objPedidoEfectivo.CPLNDV)
            objParam.Add("PSTPSLPE", objPedidoEfectivo.TPSLPE)
            objParam.Add("PNNMSLPE", objPedidoEfectivo.NMSLPE)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objPedidoEfectivo.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AUDITORIA_PEDIDO_EFECTIVO", objParam)
            For Each objData As DataRow In oDt.Rows
                objPedidoEfectivo = New PedidoEfectivo()
                objPedidoEfectivo.USRCRT = objData.Item("USRCRT")
                objPedidoEfectivo.DATCRT = objData.Item("DATCRT")
                objPedidoEfectivo.HRACRT = objData.Item("HRACRT")
                objPedidoEfectivo.FULTAC = objData.Item("FULTAC")
                objPedidoEfectivo.HULTAC = objData.Item("HULTAC")
                objPedidoEfectivo.CULUSA = objData.Item("CULUSA")
                objPedidoEfectivo.NTRMNL = objData.Item("NTRMNL")
            Next
        Catch ex As Exception
            Return objPedidoEfectivo
        End Try
        Return objPedidoEfectivo
    End Function

  Public Function Anular_Pedido_Efectivo(ByVal objEntidad As PedidoEfectivo) As Integer
    Dim objParam As New Parameter
    Try
      objParam.Add("PSCCMPN", objEntidad.CCMPN)
      objParam.Add("PSCDVSN", objEntidad.CDVSN)
      objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
      objParam.Add("PNNMSLPE", objEntidad.NMSLPE)
      objParam.Add("PSSESTRG", objEntidad.SESTRG)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_PEDIDO_EFECTIVO", objParam)
    Catch ex As Exception
      Return 0
    End Try
    Return 1
  End Function

  'Public Function Anular_Pedido_Efectivo_SAP(ByVal objEntidad As PedidoEfectivo) As Integer
  '  Dim objParam As New Parameter
  '  Try
  '    objParam.Add("PNNMSLPE", objEntidad.NMSLPE)
  '    objParam.Add("PSSESTRG", objEntidad.SESTRG)
  '    objParam.Add("PSCULUSA", objEntidad.CULUSA)
  '    objParam.Add("PNFULTAC", objEntidad.FULTAC)
  '    objParam.Add("PNHULTAC", objEntidad.HULTAC)
  '    objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_PEDIDO_EFECTIVO", objParam)
  '  Catch ex As Exception
  '    Return 0
  '  End Try
  '  Return 1
  'End Function

End Class
