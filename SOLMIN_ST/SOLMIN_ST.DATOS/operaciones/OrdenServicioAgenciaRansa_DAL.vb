Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones

    Public Class OrdenServicioAgenciaRansa_DAL

        Dim objSql As SqlManager

        Sub New()
            objSql = New SqlManager()
        End Sub

        Sub New(ByVal Value As String)
            objSql = New SqlManager(Value)
        End Sub

        Public Function Listar_Tablas_LIGORDAG() As DataSet
            Dim objResultado As New DataSet
            Try
                objResultado = objSql.ExecuteDataSet("SP_SOLMIN_TR_LISTAR_TABLAS_LIBORDAG", Nothing)
            Catch ex As Exception
            End Try
            Return objResultado
        End Function

    Public Function Listar_OS_Agencias_Ransa(ByVal objLista As List(Of String)) As DataTable
      Dim dtbTabla As New DataTable
      Try

        Dim objParams As New Parameter
        objParams.Add("PARAM_CCLNT", objLista(0))
        objParams.Add("PARAM_PNNMOS", objLista(1))
        objParams.Add("PARAM_COMPANIA", objLista(2))
        objParams.Add("PARAM_UN", objLista(3))
        objParams.Add("PARAM_ZONA", objLista(4))
        objParams.Add("PARAM_PLANTA", objLista(5))

        If objLista.Count > 6 Then
          objParams.Add("PARAM_FECINI", objLista(6))
          objParams.Add("PARAM_FECFIN", objLista(7))
        End If

        dtbTabla = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_AGENCIA_RANSA", objParams)

      Catch ex As Exception
      End Try
      Return dtbTabla

    End Function

        Public Function Registrar_Operacion_Agencia_Ransa(ByVal objEntidad As OrdenServicioAgenciaRansa, ByVal PNCDTR As String, ByVal PNCDAC As String) As String
            Dim lstr_resultado As String = ""

            Try
                Dim objParam As New Parameter

                objParam.Add("PARAM_NOPRCN", 0, ParameterDirection.Output)
                objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
                objParam.Add("PARAM_CPLNDV", IIf(objEntidad.CPLNDV = "", "0", objEntidad.CPLNDV))
                objParam.Add("PARAM_CTPOSR", objEntidad.CTPOSR)
                objParam.Add("PARAM_CTPSBS", objEntidad.CTPSBS)
                objParam.Add("PARAM_FINCOP", IIf(objEntidad.FINCOP = "", "0", objEntidad.FINCOP))
                objParam.Add("PARAM_SESTOP", objEntidad.SESTOP)
                objParam.Add("PARAM_TRFSRC", objEntidad.TRFSRC)
                objParam.Add("PARAM_NORSRT", IIf(objEntidad.NORSRT = "", "0", objEntidad.NORSRT))
                objParam.Add("PARAM_QMRCDR", IIf(objEntidad.QMRCDR = "", "0", objEntidad.QMRCDR))
                objParam.Add("PARAM_PMRCDR", IIf(objEntidad.PMRCDR = "", "0", objEntidad.PMRCDR))
                objParam.Add("PARAM_CMRCDR", IIf(objEntidad.CMRCDR = "", "0", objEntidad.CMRCDR))
                objParam.Add("PARAM_TRFMRC", objEntidad.TRFMRC)
                objParam.Add("PARAM_CCLNT", IIf(objEntidad.CCLNT = "", "0", objEntidad.CCLNT))
                objParam.Add("PARAM_CCLNFC", IIf(objEntidad.CCLNFC = "", "0", objEntidad.CCLNFC))
                objParam.Add("PARAM_CPLNCL", IIf(objEntidad.CPLNCL = "", "0", objEntidad.CPLNCL))
                objParam.Add("PARAM_SORGMV", objEntidad.SORGMV)
                objParam.Add("PARAM_NDCORM", IIf(objEntidad.NDCORM = "", "0", objEntidad.NDCORM))
                objParam.Add("PARAM_SINDPS", objEntidad.SINDPS)
                objParam.Add("PARAM_CCNCST", IIf(objEntidad.CCNCST = "", "0", objEntidad.CCNCST))
                objParam.Add("PARAM_FCHCRT", IIf(objEntidad.FCHCRT = "", "0", objEntidad.FCHCRT))
                objParam.Add("PARAM_HRACRT", IIf(objEntidad.HRACRT = "", "0", objEntidad.HRACRT))
                objParam.Add("PARAM_CUSCRT", objEntidad.CUSCRT)
                objParam.Add("PARAM_NTRMCR", objEntidad.NTRMCR)
                'Parametros para registrar la interface en Agencias Ransa
                objParam.Add("PARAM_PNCDTR", PNCDTR)
                objParam.Add("PARAM_PNCDAC", PNCDAC)

                'Dim objsql As New SqlManager("Data Source=10.3.104.41; UserId=RORTIZP; Password=REDHAT1; Datacompression=True;DefaultCollection=DC@DESLIB; Pooling=True")
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_INTERFACE_AGENCIA_RANSA", objParam)

                Dim OutputParams As New Hashtable
                OutputParams = objSql.ParameterCollection()
                lstr_resultado = "Nro de Operación : " & OutputParams("PARAM_NOPRCN")

            Catch ex As Exception
                lstr_resultado = "ERROR : " & ex.ToString()
            End Try

            Return lstr_resultado
        End Function

        Public Function Obtener_Mecaderia_OS_TR(ByVal objParametro As List(Of String)) As String
            Dim lstr_resultado As String
            Try

                Dim objParams As New Parameter
                objParams.Add("PARAM_NORSRT", objParametro(0))
                lstr_resultado = objSql.ExecuteScalar("SP_SOLMIN_ST_LISTAR_MERCADERIA_AGENCIAS", objParams)

                If lstr_resultado = "" Then
                    Throw New Exception("")
                End If
            Catch ex As Exception
                lstr_resultado = "0"
            End Try

            Return lstr_resultado
        End Function

        Public Function Obtener_Cliente_OS_TR(ByVal objParametro As List(Of String)) As String

            Dim lstr_resultado As String
            Try

                Dim objParams As New Parameter
                objParams.Add("PARAM_DCASCI", objParametro(0))
                lstr_resultado = objSql.ExecuteScalar("SP_SOLMIN_ST_LISTAR_CLIENTE_AGENCIAS", objParams)

                If lstr_resultado = "" Then
                    Throw New Exception("")
                End If
            Catch ex As Exception
                lstr_resultado = "0"
            End Try

            Return lstr_resultado

        End Function

        Public Function Obtener_Informacion_OS_Agencia_Ransa(ByVal objParametro As List(Of String)) As Hashtable

            Dim objResultado As New Hashtable

            Try

                Dim dtbDatos As New DataTable
                Dim objParams As New Parameter
                objParams.Add("PARAM_PNCDTR", objParametro(0))
                dtbDatos = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_DATOS_ORDEN_AGENCIAS_RANSA", objParams)

                If dtbDatos.Rows.Count > 0 Then 
                    objResultado.Add("PNNMOS", dtbDatos.Rows(0).Item("PNNMOS").ToString())
                    objResultado.Add("DCTPOS", Mid(Trim(dtbDatos.Rows(0).Item("DCTPOS").ToString), 1, 1))
                    objResultado.Add("DCASCI", dtbDatos.Rows(0).Item("DCASCI").ToString)
                    objResultado.Add("TRFSRC", Mid(Trim(dtbDatos.Rows(0).Item("DCREFE").ToString), 1, 40))
                    objResultado.Add("TRFMRC", Trim(dtbDatos.Rows(0).Item("PNNMOS").ToString()) + " " + Mid(Trim(dtbDatos.Rows(0).Item("DCDSME").ToString), 1, 30))
                    objResultado.Add("PNCDAC", IIf(dtbDatos.Rows(0).Item("DCTPOS").ToString.Equals("I") = True, "I18", "E13"))
                End If
 
            Catch ex As Exception
                objResultado.Add("PNNMOS", "0")
                objResultado.Add("DCTPOS", "0")
                objResultado.Add("DCASCI", "0")
                objResultado.Add("TRFSRC", "0")
                objResultado.Add("TRFMRC", "0")
                objResultado.Add("PNCDAC", "0")
            End Try

            Return objResultado

        End Function

        Public Function Listar_Cantidad_Volumen_OS_Agencias(ByVal objParametro As List(Of String)) As Hashtable

            Dim objResultado As New Hashtable

            Try

                Dim dtbDatos As New DataTable
                Dim objParams As New Parameter
                Dim lint_cantidad As Double = 0
                Dim ldbl_peso As Double = 0

                objParams.Add("PARAM_PNCDTR", objParametro(0))
                dtbDatos = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_INFO_MERCADERIAS", objParams)

                For i As Integer = 0 To dtbDatos.Rows.Count - 1 
                    lint_cantidad = lint_cantidad + CDbl(IIf(dtbDatos.Rows(0).Item("DNBULT").ToString = "", 0, dtbDatos.Rows(0).Item("DNBULT").ToString))
                    ldbl_peso = ldbl_peso + CDbl(IIf(dtbDatos.Rows(0).Item("DNPBRU").ToString = "", 0, dtbDatos.Rows(0).Item("DNPBRU").ToString))
                Next

                objResultado.Add("cantidad", lint_cantidad)
                objResultado.Add("peso", ldbl_peso)

            Catch ex As Exception
                objResultado.Clear()
            End Try

            Return objResultado

        End Function

    End Class

End Namespace