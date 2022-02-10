Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class AVC_DAL

  Private objSql As New SqlManager

  Public Function Guardar_AVC(ByVal objAVC As AVC) As AVC
    Dim objParam As New Parameter
    Dim oDt As DataTable
        'Try
        objParam.Add("PNNCSOTR", objAVC.NCSOTR)
        objParam.Add("PNNCRRSR", objAVC.NCRRSR)
        objParam.Add("PNFINAVC", objAVC.FINAVC)
        objParam.Add("PNCOBRR", objAVC.COBRR)
        objParam.Add("PNNOPRCN", objAVC.NOPRCN)
        objParam.Add("PNCTPMDT", objAVC.CTPMDT)
        objParam.Add("PNCLCLOR", objAVC.CLCLOR)
        objParam.Add("PNCLCLDS", objAVC.CLCLDS)
        objParam.Add("PNIRTAVC", objAVC.IRTAVC)
        objParam.Add("PNIARAVC", objAVC.IARAVC)

        objParam.Add("PSSESAVC", objAVC.SESAVC)

        objParam.Add("PNFCHCRT", objAVC.FCHCRT)
        objParam.Add("PNHRACRT", objAVC.HRACRT)
        objParam.Add("PSUSRCRT", objAVC.USRCRT)

        objParam.Add("PSNTRMNL", objAVC.NTRMNL)
        objParam.Add("PSNPLCUN", objAVC.NPLCUN)
        objParam.Add("PSCBRCNT", objAVC.CBRCNT)

        objParam.Add("PNNORSRT", objAVC.NORSRT)

        objParam.Add("RETORNO", objAVC.RETORNO)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GUARDAR_AVC", objParam)

        For Each objData As DataRow In oDt.Rows
            objAVC = New AVC
            objAVC.NCTAVC = oDt.Rows(0).Item("NCTAVC")
        Next
        'Catch ex As Exception
        '        objAVC.NCTAVC = 0
        '    End Try
        Return objAVC
  End Function

  Public Function Generar_Codigo() As Double
    Dim oDt As New DataTable
        'Try
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_GENERAR_CODIGO_AVC", Nothing)
        'Catch ex As Exception
        '    End Try
        Return oDt.Rows(0).Item(0)
  End Function

  Public Function Lista_Avc(ByVal pdblNrAVC As Double) As AVC
    Dim objParam As New Parameter
    Dim objAvc As New AVC
    Dim oDt As DataTable
    Try
      objParam.Add("PNNCTAVC", pdblNrAVC)

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_AVC", objParam)
      For Each objData As DataRow In oDt.Rows
        objAvc = New AVC
        objAvc.NCTAVC = oDt.Rows(0).Item("NCTAVC")
        objAvc.FINAVC = oDt.Rows(0).Item("FINAVC")
        objAvc.COBRR = oDt.Rows(0).Item("COBRR")
        objAvc.NOPRCN = oDt.Rows(0).Item("NOPRCN")
        objAvc.CTPMDT = oDt.Rows(0).Item("CTPMDT")
        objAvc.IRTAVC = oDt.Rows(0).Item("IRTAVC")
        objAvc.IARAVC = oDt.Rows(0).Item("IARAVC")
        objAvc.CCNTCS = oDt.Rows(0).Item("CCNTCS")
        objAvc.FCHCRT = oDt.Rows(0).Item("NCTAVC")
        objAvc.SESAVC = oDt.Rows(0).Item("SESAVC")
        objAvc.NRFSAP = oDt.Rows(0).Item("NRFSAP")
        objAvc.FSTTRS = oDt.Rows(0).Item("FSTTRS")
        objAvc.SFLSPE = oDt.Rows(0).Item("SFLSPE")
        objAvc.RUTA = oDt.Rows(0).Item("ORIGEN") & " - " & oDt.Rows(0).Item("DESTIN")
      Next
    Catch ex As Exception
      objAvc.NCTAVC = 0
    End Try
    Return objAvc
  End Function

  Public Function Lista_Mantenimiento_AVC(ByVal objEntidad As Hashtable) As List(Of AVC)
    Dim objParam As New Parameter
    Dim objAvc As New AVC
    Dim oDt As DataTable
    Dim objListEntidad As New List(Of AVC)
    Try
      objParam.Add("PSCCMPN", objEntidad("CCMPN"))
      objParam.Add("PSCDVSN", objEntidad("CDVSN"))
      objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
      objParam.Add("PNTIPO", objEntidad("TIPO"))
      objParam.Add("PNFECINI", objEntidad("FECINI"))
      objParam.Add("PNFECFIN", objEntidad("FECFIN"))
      objParam.Add("PNCOBRR", objEntidad("PNCOBRR"))
      objParam.Add("PSSESAVC", objEntidad("SESAVC"))
      objParam.Add("PNNCTAVC", objEntidad("NCTAVC"))

      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_MANTENIMIENTO_AVC", objParam)
      For Each objData As DataRow In oDt.Rows
        objAvc = New AVC()
        objAvc.NCTAVC = objData.Item("NCTAVC")
        objAvc.FINAVC = objData.Item("FINAVC")
        objAvc.COBRR = objData.Item("COBRR")
        objAvc.TNMBOB = objData.Item("TNMBOB")
        objAvc.NOPRCN = objData.Item("NOPRCN")
        objAvc.CLCLOR = objData.Item("CLCLOR")
        objAvc.ORIGEN = objData.Item("ORIGEN")
        objAvc.CLCLDS = objData.Item("CLCLDS")
        objAvc.DESTIN = objData.Item("DESTINO")
        objAvc.IRTAVC = objData.Item("IRTAVC")
        objAvc.IARAVC = objData.Item("IARAVC")
        objAvc.CCNTCS = objData.Item("CCNTCS")
        objAvc.SESAVC = objData.Item("SESAVC")
        objAvc.NPLCUN = objData.Item("NPLCUN")
        objAvc.CBRCNT = objData.Item("CBRCNT")
        objAvc.NRFSAP = objData.Item("NRFSAP")
        objAvc.FSTTRS = objData.Item("FSTTRS")
        objAvc.RUTA = objData.Item("ORIGEN") + " - " + objData.Item("DESTINO")
        objAvc.TTPMDT = objData.Item("TTPMDT")
        objAvc.CTPMDT = objData.Item("CTPMDT")
        objAvc.NORINS = objData.Item("NORINS")
        objAvc.FCHLQD = IIf(objData.Item("FCHLQD").ToString.Trim = "00/00/0000", "", objData.Item("FCHLQD").ToString.Trim)
        objAvc.SCATEG = objData.Item("SCATEG")
        objAvc.TCATEG = objData.Item("TCATEG")
        objAvc.QDSTKM = objData.Item("QDSTKM")
        objAvc.SFLSPE = objData.Item("SFLSPE").ToString.Trim

        objListEntidad.Add(objAvc)
      Next
    Catch ex As Exception
      Return objListEntidad
    End Try
    Return objListEntidad
  End Function

  Public Function Auditoria(ByVal objAVC As ClaseGeneral) As ClaseGeneral
    Dim objParam As New Parameter
    Dim oDt As DataTable
    Try
      objParam.Add("PNNCTAVC", objAVC.NCTAVC)

      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objAVC.CCMPN)

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AUDITORIA_AVC", objParam)
      For Each objData As DataRow In oDt.Rows
        objAVC = New ClaseGeneral()
        objAVC.CUSCRT = objData.Item("USRCRT")
        objAVC.FCHCRT = objData.Item("FCHCRT")
        objAVC.HRACRT = objData.Item("HRACRT")
        objAVC.NTRMCR = objData.Item("USRLQD")
        objAVC.FULTAC = objData.Item("FULTAC")
        objAVC.HULTAC = objData.Item("HULTAC")
        objAVC.CULUSA = objData.Item("CULUSA")
        objAVC.NTRMNL = objData.Item("NTRMNL")
      Next
    Catch ex As Exception
      Return objAVC
    End Try
    Return objAVC
  End Function

  Public Function Anular(ByVal objEntidad As AVC) As Integer
    Dim objParam As New Parameter
    Try
      objParam.Add("PNNCTAVC", objEntidad.NCTAVC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSSESAVC", objEntidad.SESAVC)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_AVC", objParam)
    Catch ex As Exception
      Return 0
    End Try
    Return 1
  End Function

  Public Function Lista_Reporte_AVC(ByVal objEntidad As Hashtable) As List(Of AVC)
    Dim objParam As New Parameter
    Dim objAvc As New AVC
    Dim oDt As DataTable
    Dim objListEntidad As New List(Of AVC)
    Try
      objParam.Add("PSCCMPN", objEntidad("CCMPN"))
      objParam.Add("PSCDVSN", objEntidad("CDVSN"))
      objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
      objParam.Add("PNTIPO", objEntidad("TIPO"))
      objParam.Add("PNFECINI", objEntidad("FECINI"))
      objParam.Add("PNFECFIN", objEntidad("FECFIN"))
      objParam.Add("PNCOBRR", objEntidad("PNCOBRR"))
      objParam.Add("PSSESAVC", objEntidad("SESAVC"))
      objParam.Add("PNNCTAVC", objEntidad("NCTAVC"))

      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_REPORTE_AVC", objParam)
      For Each objData As DataRow In oDt.Rows
        objAvc = New AVC()
        objAvc.NCTAVC = objData.Item("NCTAVC")
        objAvc.FINAVC = objData.Item("FINAVC")
        objAvc.COBRR = objData.Item("COBRR")
        objAvc.TNMBOB = objData.Item("TNMBOB")
        objAvc.NOPRCN = objData.Item("NOPRCN")
        objAvc.CLCLOR = objData.Item("CLCLOR")
        objAvc.ORIGEN = objData.Item("ORIGEN")
        objAvc.CLCLDS = objData.Item("CLCLDS")
        objAvc.DESTIN = objData.Item("DESTINO")
        objAvc.IRTAVC = objData.Item("IRTAVC")
        objAvc.IARAVC = objData.Item("IARAVC")
        objAvc.CCNTCS = objData.Item("CCNTCS")
        objAvc.SESAVC = objData.Item("SESAVC")
        objAvc.NPLCUN = objData.Item("NPLCUN")
        objAvc.CBRCNT = objData.Item("CBRCNT")
        objAvc.NRFSAP = objData.Item("NRFSAP")
        objAvc.FSTTRS = objData.Item("FSTTRS")
        objAvc.RUTA = objData.Item("ORIGEN") + " - " + objData.Item("DESTINO")
        objAvc.TTPMDT = objData.Item("TTPMDT")
        objAvc.CTPMDT = objData.Item("CTPMDT")
        objAvc.NORINS = objData.Item("NORINS")
        objAvc.FCHLQD = IIf(objData.Item("FCHLQD").ToString.Trim = "00/00/0000", "", objData.Item("FCHLQD").ToString.Trim)
        objAvc.SCATEG = objData.Item("SCATEG")
        objAvc.TCATEG = objData.Item("TCATEG")
        objAvc.QDSTKM = objData.Item("QDSTKM")
        objAvc.NGUIRM = objData.Item("NGUIRM")

        objListEntidad.Add(objAvc)
      Next
    Catch ex As Exception
      Return objListEntidad
    End Try
    Return objListEntidad
  End Function

    Public Function Lista_Reporte_AVC_Tabla(ByVal objEntidad As Hashtable) As DataTable
        Dim objParam As New Parameter
        Dim objAvc As New AVC
        Dim oDt As DataTable
        Try
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCDVSN", objEntidad("CDVSN"))
            objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
            objParam.Add("PNTIPO", objEntidad("TIPO"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))
            objParam.Add("PNCOBRR", objEntidad("PNCOBRR"))
            objParam.Add("PSSESAVC", objEntidad("SESAVC"))
            objParam.Add("PNNCTAVC", objEntidad("NCTAVC"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_REPORTE_AVC_1", objParam)
            oDt.Columns(0).ColumnName = "N° AVC"
            oDt.Columns(1).ColumnName = "FECHA AVC"
            oDt.Columns(2).ColumnName = "CODIGO"
            oDt.Columns(3).ColumnName = "CONDUCTOR"
            oDt.Columns(4).ColumnName = "OPERACION"
            oDt.Columns(5).ColumnName = "COD. CALIFICACION"
            oDt.Columns(6).ColumnName = "COD. ORIGEN"
            oDt.Columns(7).ColumnName = "ORIGEN"
            oDt.Columns(8).ColumnName = "COD. DESTINO"
            oDt.Columns(9).ColumnName = "DESTINO"
            oDt.Columns(10).ColumnName = "IMPORTE RUTA"
            oDt.Columns(11).ColumnName = "ADELANTO AVC"
            oDt.Columns(12).ColumnName = "COD. CENTRO COSTO"
            oDt.Columns(13).ColumnName = "PLACA"
            oDt.Columns(14).ColumnName = "BREVETE"
            oDt.Columns(15).ColumnName = "FECHA LIQUIDACION"
            oDt.Columns(16).ColumnName = "REFERENCIA SAP"
            oDt.Columns(17).ColumnName = "ESTADO SAP"
            oDt.Columns(18).ColumnName = "TIPO UNIDAD VEHICULAR"
            oDt.Columns(19).ColumnName = "ORDEN INTERNA"
            oDt.Columns(20).ColumnName = "COD. CATEGORIA"
            oDt.Columns(21).ColumnName = "CATEGORIA"
            oDt.Columns(22).ColumnName = "KILOMETROS RUTA"
            oDt.Columns(23).ColumnName = "ESTADO"
            'oDt.Columns(24).ColumnName = "GUIA TRANSPORTE"

            oDt.Columns.RemoveAt(5)
            oDt.Columns.RemoveAt(5)
            oDt.Columns.RemoveAt(6)
            'oDt.Columns.RemoveAt(10)
            oDt.Columns.RemoveAt(14)

            Return oDt
        Catch ex As Exception
            oDt = New DataTable
            Return oDt
        End Try
    End Function

End Class

