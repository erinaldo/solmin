Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario

Namespace Operaciones
  Public Class PreLiquidacion_DAL
    Private objSql As New SqlManager

        Public Function Listar_Operaciones_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
            objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(1))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_PRELIQUIDACION", objParam)
         
            Return objDataTable
        End Function

        Public Function Listar_Operaciones_PreFactura(ByVal objParametros As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", objParametros("PNCCLNT"))
            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
            objParam.Add("PNNDCPRF", objParametros("PNNDCPRF"))
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(1))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_PREFACTURA", objParam)
            'Catch ex As Exception
            'End Try
            Return objDataTable
        End Function

    Public Function Listar_PreLiquidacion_Factura(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim dtresult As New DataTable

      Dim objGenericCollection As New List(Of OperacionTransporte)
      Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objParam.Add("PNFECINI", objParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PRELIQUIDACION_FACTURA", objParam)
            For Each objDataRow As DataRow In dtresult.Rows
                objEntidad = New OperacionTransporte
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                objEntidad.NRUCRM = objDataRow("NRUC")
                objEntidad.TDRCRM = objDataRow("TDRCOR").ToString.Trim
                objEntidad.IMPOCOS = objDataRow("IMPOCOS")
                objEntidad.IMPOCOD = objDataRow("IMPOCOD")

              
                objGenericCollection.Add(objEntidad)
            Next
          
            Return objGenericCollection
    End Function

    Public Function Listar_PreFactura_Factura(ByVal objParametro As Hashtable) As List(Of OperacionTransporte)
            Dim objEntidad As OperacionTransporte
            Dim dtresult As New DataTable

      Dim objGenericCollection As New List(Of OperacionTransporte)
      Dim objParam As New Parameter

            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objParam.Add("PNFECINI", objParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objParametro("PNFECFIN"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            dtresult = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PREFACTURA_FACTURA", objParam)
            For Each objDataRow As DataRow In dtresult.Rows
                objEntidad = New OperacionTransporte
                objEntidad.CCLNFC = objDataRow("CCLNFC")
                objEntidad.CCLNT = objDataRow("CCLNT")
                objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                'objEntidad.NRUCRM = objDataRow("NRUC")
                'objEntidad.TDRCRM = objDataRow("TDRCOR").ToString.Trim
                objEntidad.IMPOCOS = objDataRow("IMPOCOS")
                objEntidad.IMPOCOD = objDataRow("IMPOCOD")
                
                objGenericCollection.Add(objEntidad)
            Next
          
            Return objGenericCollection
    End Function


    Public Function Listar_PreFactura(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As New Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
          
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

            Dim dt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PRE_FACTURA_2_LA", objParam)
            For Each objDataRow As DataRow In dt.Rows
                objEntidad = New Factura_Transporte
                objEntidad.NDCPRF = objDataRow("NDCPRF")
                objEntidad.FDCPRF_S = HelpClass.CFecha_de_8_a_10(objDataRow("FDCPRF"))
                objEntidad.IMPOCOS = Val(("" & objDataRow("IMPOCOS")).ToString.Trim)
                objEntidad.IMPOCOD = Val(("" & objDataRow("IMPOCOD")).ToString.Trim)
                objEntidad.TCRVTA = objDataRow("TCRVTA").ToString
                objEntidad.CRGVTA = objDataRow("CRGVTA").ToString
                
                objGenericCollection.Add(objEntidad)
            Next
          
            Return objGenericCollection
        End Function


    Public Function Listar_Liquidacion(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As New Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter
            'Try
            objParam.Add("PNCCLNT", objParametro("PNCCLNT"))
            objParam.Add("PNCCLNFC", objParametro("PNCCLNFC"))
            objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
          

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            Dim oDt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_2", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad = New Factura_Transporte
                objEntidad.NPRLQD = objDataRow("NPRLQD")
                objEntidad.IMPOCOS = Val(("" & objDataRow("IMPOCOS")).ToString.Trim)
                objEntidad.IMPOCOD = Val(("" & objDataRow("IMPOCOD")).ToString.Trim)
                objEntidad.TCRVTA = objDataRow("TCRVTA").ToString
                objEntidad.CRGVTA = objDataRow("CRGVTA").ToString

                objEntidad.TIPODOC = objDataRow("TIPODOC").ToString
                objEntidad.DCCLNT = objDataRow("DCCLNT").ToString
                'objEntidad.SBCLNT = objDataRow("SBCLNT").ToString
                objEntidad.ESTADO_PL = objDataRow("ESTADO_PL").ToString
                objEntidad.DESC_ESTPL = objDataRow("DESC_ESTPL").ToString
                objEntidad.VLRFDT = objDataRow("VLRFDT").ToString
               


              
                objGenericCollection.Add(objEntidad)
            Next
          
            Return objGenericCollection
    End Function

    Public Function ListarPreFacturas_x_PreLiquidacion(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
      Dim objEntidad As New Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter

            objParam.Add("PNPRLQD", objParametro("NPRLQD"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
            Dim oDt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_PRE_FACTURA_X_PRE_LIQUIDACION", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                objEntidad = New Factura_Transporte
                objEntidad.NDCPRF = objDataRow("NDCPRF")
                objEntidad.FDCPRF = objDataRow("FDCPRF")
                objEntidad.IMPOCOS = Val("" & objDataRow("IMPOCOS")).ToString.Trim
                objEntidad.IMPOCOD = Val("" & objDataRow("IMPOCOD")).ToString.Trim
                objEntidad.TCRVTA = objDataRow("TCRVTA").ToString

                

                'objEntidad.CRGVTA = objDataRow("CRGVTA").ToString
                objGenericCollection.Add(objEntidad)
            Next


      
            Return objGenericCollection
    End Function

    Public Function Obtener_Nro_PreLiquidacion(ByVal objParametro As Hashtable) As Integer
      Dim objEntidad As New Factura_Transporte
      Dim Nro_PreLiquidacion As Integer
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNPRLQD", 0, ParameterDirection.Output)
        objParam.Add("PNESTADO", objParametro("PNESTADO"))
        objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NUMERADOR_PRE_LIQUIDACION", objParam)
        Nro_PreLiquidacion = Convert.ToInt64(objSql.ParameterCollection("PNNPRLQD").ToString)

      Catch ex As Exception
        Nro_PreLiquidacion = 0
      End Try
      Return Nro_PreLiquidacion
    End Function

        ' Public Function Registrar_PreLiquidacion(ByVal objEntidad As Factura_Transporte, ByVal NDCPRF As String, ByVal FDCPRF As String, ByRef NPRLQD As Decimal) As String
        Public Function Registrar_PreLiquidacion(ByVal objEntidad As Factura_Transporte, ByVal NDCPRF As String, ByRef NPRLQD As Decimal, ACCION As String) As String

            Dim objParam As New Parameter
            Dim dt As New DataTable
            Dim msg As String = ""
            
            objParam.Add("PNNPRLQD", NPRLQD)
            objParam.Add("PSACCION", ACCION)
            objParam.Add("PSNDCPRF", NDCPRF)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNCL)

            objParam.Add("PSTPDCPE", objEntidad.TPDCPE)
            objParam.Add("PSDCCLNT", objEntidad.DCCLNT)
            objParam.Add("PSSBCLNT", objEntidad.SBCLNT)
          
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_PRE_LIQUIDACION_LA", objParam)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_REGISTRAR_PRE_LIQUIDACION_LA", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
                End If
            Next
            msg = msg.Trim
            If msg.Length = 0 And dt.Rows.Count > 0 Then
                NPRLQD = dt.Rows(0)("NPRLQD")
            End If

          
            Return msg
        End Function

    Public Function Imprimir_Reporte_Pre_Liquidacion(ByVal objParametros As List(Of String)) As DataSet

      Dim objDataSet As New DataSet
      Dim objParam As New Parameter

            objParam.Add("PNNPRLQD", objParametros(0))
            objParam.Add("PSCCMPN", objParametros(1))
            objParam.Add("PSCDVSN", objParametros(2))
            objParam.Add("PNCPLNDV", objParametros(3))
            objParam.Add("PNFECACT", objParametros(4))

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(1))

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_PRE_LIQUIDACION", objParam)
 

            Return objDataSet
    End Function

    Public Function Imprimir_Consistencia_Pre_Liquidacion(ByVal objParametros As List(Of String)) As DataSet

      Dim objDataSet As New DataSet
      Dim objParam As New Parameter

            objParam.Add("PNNPRFAC", objParametros(0))
            objParam.Add("PSCCMPN", objParametros(1))
            objParam.Add("PSCDVSN", objParametros(2))
            objParam.Add("PNCPLNDV", objParametros(3))
            objParam.Add("PNFECACT", objParametros(4))
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(1))

            objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_CONSISTENCIA_PRE_LIQUIDACION", objParam)

          

            Return objDataSet
    End Function
    Public Function ObtenerTipoReportePreLiquidacion(ByVal objEntidad As Factura_Transporte) As DataTable
      Dim oDtb As New DataTable
      Dim objParam As New Parameter

            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            ' 0 = Todos
            ' 1 = Pluspetrol
            ' 2 = Perenco
            oDtb = objSql.ExecuteDataTable("SP_SOLST_LISTA_TIPO_FACTURA_PRELIQUIDACION", objParam)

       
            Return oDtb
    End Function

    Public Function Obtener_Reporte_Resumen_X_Lote(ByVal objEntidad As Factura_Transporte) As DataTable
      Dim oDs As New DataSet
      Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", 0)
            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            'Ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_MONTOS_X_LOTE", objParam)
            For i As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                oDs.Tables(0).Rows(i).Item("SUMA_OPERACION") = oDs.Tables(1).Select("NOPRCN = " & oDs.Tables(0).Rows(i).Item("NOPRCN"))(0).Item("QPSOBL")
            Next
            For j As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                oDs.Tables(0).Rows(j).Item("COSTO") = oDs.Tables(0).Rows(j).Item("ISRVGU") * oDs.Tables(0).Rows(j).Item("QPSOBL") / oDs.Tables(0).Rows(j).Item("SUMA_OPERACION")
            Next
         
            Return oDs.Tables(0)
    End Function
    Public Function Lista_Operacion_Liquidacion(ByVal objEntidad As Factura_Transporte) As List(Of Factura_Transporte)

      Dim objResultado As New Factura_Transporte
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim objParam As New Parameter

            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            Dim dt As DataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_LIQUIDACION", objParam)

            For Each objDataRow As DataRow In dt.Rows
                objResultado = New Factura_Transporte
                objResultado.NOPRCN = objDataRow("NOPRCN")
                objGenericCollection.Add(objResultado)
            Next
        
            Return objGenericCollection
    End Function

        Public Sub Anular_PreFactura(ByVal objEntidad As Factura_Transporte)
            'Dim Nro_PreLiquidacion As Integer
            Dim objParam As New Parameter
         
            objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
            objParam.Add("PNFDCPRF", objEntidad.FDCPRF)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_PRE_FACTURA", objParam)
         
        End Sub


    Public Function Quitar_Pre_Factura(ByVal objEntidad As Factura_Transporte) As Integer
      Dim Nro_PreLiquidacion As Integer
      Dim objParam As New Parameter
      Try
        objParam.Add("PNNDCPRF", objEntidad.NDCPRF)
        objParam.Add("PNPRLQD", objEntidad.NPRLQD)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_PRE_FACTURA_DE_PRE_LIQUIDACION", objParam)
        Nro_PreLiquidacion = 1

      Catch ex As Exception
        Nro_PreLiquidacion = 0
      End Try
      Return Nro_PreLiquidacion
    End Function


        Public Sub Anular_PreLiquidacion(ByVal objEntidad As Factura_Transporte)
            'Dim Nro_PreLiquidacion As Integer
            Dim objParam As New Parameter


            objParam.Add("PNNPRLQD", objEntidad.NPRLQD)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_PRE_LIQUIDACION", objParam)
         
        End Sub

    Public Function ListarMovimiento_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable

      Dim objParam As New Parameter
      Dim objDataTable As New DataTable

            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PSNPRLQD", objParametros("NPRLQD"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_MOVIMIENTO_DESPACHO_BULTO_LM", objParam)

          
            Return objDataTable
        End Function

        Public Function ListaDatosAdPreLiquidacion(ByVal objParametros As Hashtable) As DataTable

            Dim objParam As New Parameter
            Dim objDataTable As New DataTable

            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_INFO_PL", objParam)
 
            Return objDataTable
        End Function


        Public Sub ActualizarDatosAdPreLiquidacion(ByVal objParametros As Hashtable)

            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
         
            objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
            objParam.Add("PSCDVSN", objParametros("PSCDVSN"))
            objParam.Add("PNNPRLQD", objParametros("PNNPRLQD"))
            objParam.Add("PSTPDCPE", objParametros("PSTPDCPE"))
            objParam.Add("PSDCCLNT", objParametros("PSDCCLNT"))
            objParam.Add("PSSBCLNT", objParametros("PSSBCLNT"))
            objParam.Add("PSCULUSA", objParametros("PSCULUSA"))
            objParam.Add("PSNTRMNL", HelpClass.NombreMaquina)
            'MainModule.USUARIO

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_UPDATE_INFO_PL", objParam)

            


        End Sub


        Public Function ListaDatosCliente(CCMPN As String, PNCCLNT As Decimal) As DataTable
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            objParam.Add("PNCCLNT", PNCCLNT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DATOS_CLIENTE", objParam)
            Return objDataTable
        End Function


  End Class
End Namespace