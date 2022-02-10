Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class Obrero_DAL
  Private objSql As New SqlManager

  Public Function Lista_Obreros(ByVal pobjEntidad As Hashtable) As List(Of Obrero)
    Dim oDt As DataTable
    Dim objLisObrero As New List(Of Obrero)
    Dim objEntidad As Obrero
    Try
      Dim objParam As New Parameter
      objParam.Add("PNCOBRR", pobjEntidad("COBRR"))
      objParam.Add("PSTNMBOB", pobjEntidad("TNMBOB"))
      objParam.Add("PSCCMPN", pobjEntidad("PSCCMPN"))
      objParam.Add("PSCDVSN", pobjEntidad("PSCDVSN"))
            objParam.Add("PNCPLNDV", pobjEntidad("PNCPLNDV"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(pobjEntidad("PSCCMPN"))

      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OBREROS_X_CODIGO_NOMBRE", objParam)
      For Each objDr As DataRow In oDt.Rows
        objEntidad = New Obrero
        objEntidad.COBRR = objDr.Item("COBRR")
        objEntidad.TNMBOB = objDr.Item("TNMBOB")
        objEntidad.SCATEG = objDr.Item("SCATEG")
        objEntidad.SACTIN = objDr.Item("SACTIN")
        objEntidad.FINGCH = objDr.Item("FINGCH")
        objEntidad.FVNCCR = objDr.Item("FVNCCR")
        objEntidad.CMTCDS = objDr.Item("CMTCDS")
        objEntidad.TCATEG = objDr.Item("TCATEG")
        objEntidad.CCMPN = objDr.Item("CCMPN")
        objEntidad.CDVSN = objDr.Item("CDVSN")
        objEntidad.CPLNDV = objDr.Item("CPLNDV")
        objLisObrero.Add(objEntidad)
      Next
    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
    Return objLisObrero
  End Function

  Public Function Lista_Obrero_Empleado_RANSA() As List(Of ClaseGeneral)
    Dim oDt As DataTable
    Dim objLisObrero As New List(Of ClaseGeneral)
    Dim objEntidad As ClaseGeneral
    Try
      Dim objParam As New Parameter
      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OBREROS_EMPLEADOS_RANSA", Nothing)
      For Each objDr As DataRow In oDt.Rows
        objEntidad = New ClaseGeneral
        objEntidad.PERNR = objDr.Item("PERNR")
        objEntidad.TCMPEM = objDr.Item("TCMPEM")
        objLisObrero.Add(objEntidad)
      Next
    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
    Return objLisObrero
  End Function

  Public Sub Guardar_Obrero(ByVal objEntidad As Obrero)
    Try
      Dim objParam As New Parameter

      objParam.Add("PNCOBRR", objEntidad.COBRR)
      objParam.Add("PSTNMBOB", objEntidad.TNMBOB)
      objParam.Add("PSSCATEG", objEntidad.SCATEG)
      objParam.Add("PSSACTIN", objEntidad.SACTIN)
      objParam.Add("PSSESTRG", objEntidad.SESTRG)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
      objParam.Add("PNFINGCH", objEntidad.FINGCH)
      objParam.Add("PNFVNCCR", objEntidad.FVNCCR)
      objParam.Add("PSCMTCDS", objEntidad.CMTCDS)
      objParam.Add("PSCCMPN", objEntidad.CCMPN)
      objParam.Add("PSCDVSN", objEntidad.CDVSN)
      objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_GUARDAR_OBRERO", objParam)
    Catch ex As Exception
      Throw New Exception(ex.Message)
    End Try
  End Sub

  Public Function Lista_Obreros_Operacion_Placa(ByVal pobjEntidad As Hashtable) As List(Of Obrero)
    Dim oDt As DataTable
    Dim objLisObrero As New List(Of Obrero)
    Dim objEntidad As Obrero
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNOPRCN", pobjEntidad("NOPRCN"))
        objParam.Add("PSNPLCTR", pobjEntidad("NPLCTR"))
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OBREROS_OPERACION_PLACA", objParam)
        For Each objDr As DataRow In oDt.Rows
            objEntidad = New Obrero
            objEntidad.COBRR = objDr.Item("COBRR")
            objEntidad.TNMBOB = objDr.Item("TNMBOB")
            objLisObrero.Add(objEntidad)
        Next
        'Catch ex As Exception
        '    End Try
        Return objLisObrero
  End Function

End Class
