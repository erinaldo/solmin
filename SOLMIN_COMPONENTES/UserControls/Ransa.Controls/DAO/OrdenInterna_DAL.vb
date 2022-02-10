Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones

  Public Class OrdenInterna_DAL

    Private objSql As New SqlManager

    Public Function Generar_Orden_Interna(ByVal objParamList As List(Of String)) As Planeamiento

      Dim objResultado As New Planeamiento
      Try

        Dim objParam As New Parameter
        Dim lstr_ordeninterna As String

        objParam.Add("PARAM_NORINS", 0, ParameterDirection.Output)
        objParam.Add("PARAM_NOPRCN", objParamList(0))
        objParam.Add("PARAM_CUSCRT", objParamList(1))
        objParam.Add("PARAM_FCHCRT", objParamList(2))
        objParam.Add("PARAM_HRACRT", objParamList(3))
        objParam.Add("PARAM_NTRMCR", objParamList(4))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(8))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_ORDEN_INTERNA", objParam)

        lstr_ordeninterna = objSql.ParameterCollection("PARAM_NORINS")

        'si ha obteniedo resultados
        If lstr_ordeninterna.Length > 0 Then
          If Int64.Parse(lstr_ordeninterna) <> 0 Then
            objResultado.NORINS = Int64.Parse(lstr_ordeninterna)
          End If
        Else
          Throw New Exception("No hay resultado")
        End If

      Catch ex As Exception
        objResultado.NORINS = -1
      End Try

      Return objResultado

    End Function

    Public Function Actualizar_Planeamiento(ByVal objParametros As List(Of String)) As Boolean

      Dim objResultado As Boolean = False

      Try

        Dim objParam As New Parameter

        objParam.Add("PARAM_NORINS", objParametros(0))
        objParam.Add("PARAM_NOPRCN", objParametros(1))
        objParam.Add("PARAM_NPLCTR", objParametros(2))
        objParam.Add("PARAM_NPLCAC", objParametros(3))
        objParam.Add("PARAM_CBRCNT", objParametros(4))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros(5))
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_PLANEAMIENTO", objParam)

        objResultado = True
      Catch ex As Exception
        objResultado = False
      End Try

      Return objResultado

    End Function

  End Class

End Namespace