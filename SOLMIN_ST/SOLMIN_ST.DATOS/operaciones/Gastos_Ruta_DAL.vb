Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class Gastos_Ruta_DAL

    Private objSql As New SqlManager

    Public Function Lista_Solicitud_Gastos_Ruta(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objGenericCollection As New List(Of ClaseGeneral)
        Try

            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
            objParam.Add("PSNRUCTR", objetoParametro("PSNRUCTR"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_GASTO_RUTA", objParam)

            For Each objData As DataRow In objDataTable.Rows
                Dim objEntidad As New ClaseGeneral
                objEntidad.NCSOTR = objData("NCSOTR")
                objEntidad.NCRRSR = objData("NCRRSR")
                objEntidad.FECOST = objData("FECOST")
                objEntidad.CCLNT = objData("CCLNT")
                objEntidad.TCMPCL = objData("TCMPCL")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.RUTA = objData("ORIGEN") & " - " & objData("DESTIN")
                objEntidad.NPLCUN = objData("NPLCUN")
                objEntidad.NRUCTR = objData("NRUCTR")
                objEntidad.CBRCNT = objData("CBRCNT")
                objEntidad.CONDUCTOR = objData("CONDUCTOR")
                objEntidad.CBRCN2 = objData("CBRCN2")
                objEntidad.CONDUCTOR2 = objData("CONDUCTOR2")
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.NORSRT = objData("NORSRT")
                objEntidad.NCTAVC = objData("NCTAVC")
                objEntidad.NCSLPE = objData("NCSLPE")
                objEntidad.NCTAV2 = objData("NCTAV2")
                objEntidad.NCSLP2 = objData("NCSLP2")
                objEntidad.NORINS = objData("NORINS")
                objEntidad.NCTAV3 = objData("NCTAV3")
                objEntidad.NCTAV4 = objData("NCTAV4")
                'STATUS
                objGenericCollection.Add(objEntidad)
            Next
        Catch : End Try
        Return objGenericCollection
    End Function

  Public Function Calular_Importe_Ruta(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)

    Dim objDataTable As New DataTable
    Dim objParam As New Parameter
    Dim objGenericCollection As New List(Of ClaseGeneral)
    Try
      objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
      objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
      objParam.Add("PNCCLNT", objetoParametro("PNCCLNT"))
      objParam.Add("PNCTPMDT", objetoParametro("PNCTPMDT"))
      objParam.Add("PNCLCLOR", objetoParametro("PNCLCLOR"))
      objParam.Add("PNCLCLDS", objetoParametro("PNCLCLDS"))
      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_IMPORTE_RUTA", objParam)

      If objDataTable.Rows.Count > 0 Then
        For Each objData As DataRow In objDataTable.Rows
          Dim objEntidad As New ClaseGeneral
          If objData("IRTAVC") Is DBNull.Value Then
            objEntidad.IARAVC = 0
            objEntidad.COBRR = 0
            objEntidad.IGSTVJ = 0
            If objData("IFCTPG") Is DBNull.Value Then
              objEntidad.IFCTPG = 0
            Else
              objEntidad.IFCTPG = objData("IFCTPG")
            End If
            objEntidad.IFCTPG = 0
            If objData("QDSTKM") Is DBNull.Value Then
              objEntidad.QDSTKM = 0
            Else
              objEntidad.QDSTKM = objData("QDSTKM")
            End If

          Else
            objEntidad.IARAVC = objData("IRTAVC")
            objEntidad.COBRR = objData("COBRR")
            objEntidad.IGSTVJ = objData("IGSTVJ")
            objEntidad.IFCTPG = objData("IFCTPG")
            objEntidad.QDSTKM = objData("QDSTKM")
          End If
          objGenericCollection.Add(objEntidad)
        Next
      Else
        Dim objEntidad As New ClaseGeneral
        objEntidad.IARAVC = 0
        objEntidad.COBRR = 0
        objGenericCollection.Add(objEntidad)
      End If

    Catch ex As Exception
    End Try
    Return objGenericCollection
  End Function

    Public Function Obtener_Datos_Obrero(ByVal objetoParametro As Hashtable) As ENTIDADES.Obrero

        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objEntidad As New Obrero
        'Try
        objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_OBRERO", objParam)
        For Each objData As DataRow In objDataTable.Rows
            objEntidad.COBRR = objData("COBRR")
            objEntidad.CMTCDS = objData("CMTCDS")
        Next
        'Catch : End Try
        Return objEntidad

    End Function

    Public Function ReporteControlGastos(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objEntidad As New ClaseGeneral
        Dim objNumeroLetra As New Validacion
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        Try
            objParam.Add("PNNCTAVC", objetoParametro("NCTAVC"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONTROL_GASTOS_RUTA", objParam)

            For Each objData As DataRow In objDataTable.Rows

                objEntidad.FCSLPE = objData("FCSLPE")
                objEntidad.COBRR = objData("COBRR")
                objEntidad.TNMBOB = objData("TNMBOB")
                objEntidad.NPLCUN = objData("NPLCUN")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.ORIGEN = objData("ORIGEN")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.DESTIN = objData("DESTIN")
                objEntidad.IRTAVC = objData("IRTAVC")
                objEntidad.IARAVC = objData("IARAVC")
                objEntidad.NCTAVC = objData("NCTAVC")
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.CCNTCS = objData("CCNTCS")
                objEntidad.TCNTCS = objData("TCNTCS")
                objEntidad.IMPAVCSTR = objNumeroLetra.Num2Text(objData("IARAVC")) & " y  00/100 Nuevos Soles"
                objLisClaseGeneral.Add(objEntidad)

            Next
        Catch ex As Exception
        End Try
        Return objLisClaseGeneral

    End Function

    Public Function Reporte_Pedido_Efectivo(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objEntidad As New ClaseGeneral
        Dim objNumeroLetra As New Validacion
        Dim strMonto As String = ""
        Dim objLisClaseGeneral As New List(Of ClaseGeneral)
        'Try
        objParam.Add("PNNMSLPE", objetoParametro("NCSLPE"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_PEDIDO_EFECTIVO", objParam)

        For Each objData As DataRow In objDataTable.Rows
            objEntidad.NMSLPE = objData("NMSLPE")
            objEntidad.ISLPES = objData("ISLPES")
            objEntidad.MOTIVO = objData("MOTIVO")
            objEntidad.RUTA = objData("ORIGEN") & " - " & objData("DESTIN")
            objEntidad.NPLCUN = objData("NPLCUN")
            objEntidad.COBRR = objData("COBRR")
            objEntidad.TNMBOB = objData("TNMBOB")
            objEntidad.NOPRCN = objData("NOPRCN")
            objEntidad.CMTCDS = objData("CMTCDS")
            strMonto = objNumeroLetra.Num2Text(objData("ISLPES"))

            If strMonto.Length < 5 Then
                objEntidad.IMPAVCSTR = objNumeroLetra.Num2Text(objData("ISLPES")) & " y 00/100 Nuevos Soles"
            Else
                If strMonto.Trim.Substring(strMonto.Length - 4, 4) <> "/100" Then
                    objEntidad.IMPAVCSTR = objNumeroLetra.Num2Text(objData("ISLPES")) & " y 00/100 Nuevos Soles"
                Else
                    objEntidad.IMPAVCSTR = objNumeroLetra.Num2Text(objData("ISLPES")) & "  Nuevos Soles"
                End If
            End If


            objLisClaseGeneral.Add(objEntidad)
        Next
        'Catch ex As Exception
        'End Try
        Return objLisClaseGeneral
    End Function

    Public Function Reporte_Lista_Asignacion_AVC(ByVal objetoParametro As Hashtable) As List(Of ClaseGeneral)
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Dim objGenericCollection As New List(Of ClaseGeneral)
        Try
            objParam.Add("PSNRUCTR", objetoParametro("PSNRUCTR"))
            objParam.Add("PSCBRCNT", objetoParametro("PSCBRCNT"))
            objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
            objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
            objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
            objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
            objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_LISTA_ASIGNACIONES_AVC", objParam)

            For Each objData As DataRow In objDataTable.Rows
                Dim objEntidad As New ClaseGeneral
                objEntidad.CBRCNT = objData("CBRCNT")
                objEntidad.COBRR = objData("COBRR")
                objEntidad.NOMCHOFER = objData("CONDUCTOR")
                objEntidad.NCTAVC = objData("NCTAVC")
                objEntidad.FINAVC = objData("FINAVC")
                objEntidad.FCHLQD = objData("FCHLQD")
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.TTPMDT = objData("TTPMDT")
                objEntidad.ORIGEN = objData("ORIGEN")
                objEntidad.DESTIN = objData("DESTIN")
                objEntidad.NCSLPE = objData("NCSLPE")
                objEntidad.IARAVC = objData("IARAVC")
                objEntidad.ISLPES = objData("ISLPES")
                objEntidad.ESTADO = objData("ESTADO")
                objEntidad.FECINI = Validacion.CNumero_a_Fecha(objetoParametro("PNFECINI"))
                objEntidad.FECFIN = Validacion.CNumero_a_Fecha(objetoParametro("PNFECFIN"))
                objEntidad.SESAVC = objData("SESAVC")
                objEntidad.IRTAVC = objData("IRTAVC")
                objEntidad.QDSTKM = objData("QDSTKM")
                objEntidad.SCATEG = objData("SCATEG")
        objEntidad.TCATEG = objData("TCATEG")
        objEntidad.NGUIRM = objData("NGUIRM")
                objGenericCollection.Add(objEntidad)
            Next
        Catch : End Try
        Return objGenericCollection
    End Function

  Public Function Actualizar_Estado_Imprimir_AVC(ByVal intNMSLPE As Int64, ByVal stsTipo As String) As Int32
    Dim objParam As New Parameter
    Dim intResultado As Int32 = 0
        'Try
        objParam.Add("PNNMSLPE", intNMSLPE)
        objParam.Add("PSSTSTIP", stsTipo)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ESTADO_IMPRESION_AVC", objParam)
        intResultado = 1
        'Catch ex As Exception
        '        intResultado = 0
        '    End Try
        Return 1

  End Function


End Class
