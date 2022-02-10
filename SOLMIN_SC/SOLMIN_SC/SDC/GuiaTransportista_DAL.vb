Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES

Namespace mantenimientos

  Public Class GuiaTransportista_DAL
    Private objSql As New SqlManager

    Public Function Verificacion_Existencia_Operacion_Transporte(ByVal objEntidad As OperacionTransporte) As OperacionTransporte
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PON_NPLNMT", 0, ParameterDirection.Output)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_PLANEAMIENTO_DE_OPERACION", objParam)

        objEntidad.NPLNMT = objSql.ParameterCollection("PON_NPLNMT")
      Catch ex As Exception
        objEntidad.NPLNMT = 0
      End Try
      Return objEntidad
    End Function

        Public Function Obtener_Numero_Guia_Transporte(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
                objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
                objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_GUIA_DE_TRANSPORTE", objParam)

                objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
            Catch ex As Exception
                objEntidad.NGUIRM = 0
            End Try
            Return objEntidad
        End Function

    Public Function Obtener_Informacion_Orden_Servicio(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PNCLCLOR", objEntidad.CLCLOR, ParameterDirection.Output)
        objParam.Add("PNCLCLDS", objEntidad.CLCLDS, ParameterDirection.Output)
        objParam.Add("PNQMRCDR", objEntidad.QMRCMC, ParameterDirection.Output)
        objParam.Add("PNCUNDMD", objEntidad.CUNDMD, ParameterDirection.Output)
        objParam.Add("PNCMNFLT", objEntidad.CMNFLT, ParameterDirection.Output)
        objParam.Add("PNQKMREC", objEntidad.QKMREC, ParameterDirection.Output)
        objParam.Add("PSTNMBRM", objEntidad.TNMBRM, ParameterDirection.Output)
        objParam.Add("PSTDRCRM", objEntidad.TDRCRM, ParameterDirection.Output)
        objParam.Add("PSTPDCIR", objEntidad.TPDCIR, ParameterDirection.Output)
        objParam.Add("PNNRUCRM", objEntidad.NRUCRM, ParameterDirection.Output)

        'EN MODIFICACION
        '------------------------------------------------------
        objParam.Add("PSNPLCTR", objEntidad.NPLCTR)
        objParam.Add("PSTCNFVH", objEntidad.TCNFVH, ParameterDirection.Output)

        objParam.Add("PNCCNCST", objEntidad.CCNCST, ParameterDirection.Output)
        objParam.Add("PSTDSCAR", objEntidad.TDSCAR, ParameterDirection.Output)
        objParam.Add("PNCCLNT", objEntidad.CCLNT, ParameterDirection.Output)

        '------------------------------------------------------

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_INFORMACION_ORDEN_SERVICIO", objParam)

        objEntidad.CLCLOR = objSql.ParameterCollection("PNCLCLOR")
        objEntidad.CLCLDS = objSql.ParameterCollection("PNCLCLDS")
        objEntidad.QMRCMC = objSql.ParameterCollection("PNQMRCDR")
        objEntidad.CUNDMD = objSql.ParameterCollection("PNCUNDMD")
        objEntidad.CMNFLT = objSql.ParameterCollection("PNCMNFLT")
        objEntidad.QKMREC = objSql.ParameterCollection("PNQKMREC")
        objEntidad.TNMBRM = objSql.ParameterCollection("PSTNMBRM").ToString.Trim
        objEntidad.TDRCRM = objSql.ParameterCollection("PSTDRCRM").ToString.Trim
        objEntidad.TPDCIR = objSql.ParameterCollection("PSTPDCIR").ToString.Trim
        objEntidad.NRUCRM = objSql.ParameterCollection("PNNRUCRM")
        objEntidad.CCLNT = objSql.ParameterCollection("PNCCLNT")
        objEntidad.TNMBCN = objEntidad.TNMBRM
        objEntidad.TDRCNS = objEntidad.TDRCRM
        objEntidad.TPDCIC = objEntidad.TPDCIR
        objEntidad.NRUCCN = objEntidad.NRUCRM

        'EN MODIFICACION
        '------------------------------------------------------
        objEntidad.TCNFVH = objSql.ParameterCollection("PSTCNFVH").ToString.Trim
        If objEntidad.TCNFVH = "0" OrElse objEntidad.TCNFVH = "" Then objEntidad.TCNFVH = ""

        objEntidad.CCNCST = objSql.ParameterCollection("PNCCNCST")
        objEntidad.TDSCAR = objSql.ParameterCollection("PSTDSCAR").ToString.Trim
        If objEntidad.TDSCAR.Length > 30 Then
          objEntidad.TDSCAR = objEntidad.TDSCAR.Substring(0, 30)
        End If
        '------------------------------------------------------

      Catch ex As Exception
        Return New GuiaTransportista
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Tractos_x_Planeamiento(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNPLNMT", objEntidad.NPLNMT)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTO_X_PLANEAMIENTO", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          obj_Entidad.NRUCTR = objData("NRUCTR").ToString.Trim
          obj_Entidad.NPLCTR = objData("NPLCTR").ToString.Trim
          obj_Entidad.NPLCAC = objData("NPLCAC").ToString.Trim
          obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
          obj_Entidad.CBRCND = objData("CBRCND").ToString.Trim
          obj_Entidad.CBRCN2 = objData("CBRCN2").ToString.Trim
          obj_Entidad.CBRCND2 = objData("CBRCND2").ToString.Trim
          obj_Entidad.RUTA = objData("RUTA").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Guias_x_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNFGUIRM", objEntidad.FGUIRM)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT")
          obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Guias_x_Transportista(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objEntidad("CCLNT"))
        objParam.Add("PNNGUIRM", objEntidad("NGUIRM"))
        objParam.Add("PNFECINI", objEntidad("FECINI"))
        objParam.Add("PNFECFIN", objEntidad("FECFIN"))
        objParam.Add("PSCCMPN", objEntidad("CCMPN"))
        objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          obj_Entidad.NGUIRM_S = objData("NGUIRM")
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.TCMPCL = objData("CCLNT") & " - " & objData("TCMPCL").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT")
          obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Guias_x_Transportista_Proveedor(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", objEntidad("CCLNT"))
        objParam.Add("PNNGUIRM", objEntidad("NGUIRM"))
        objParam.Add("PNFECINI", objEntidad("FECINI"))
        objParam.Add("PNFECFIN", objEntidad("FECFIN"))
        objParam.Add("PSCCMPN", objEntidad("CCMPN"))
        objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_REMISION_CLIENTE_PROVEEDOR", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          'If IsNumeric(objData("NGUIRM")) Then
          obj_Entidad.NGUIRM_S = objData("NGUIRM")
          obj_Entidad.TCMPCL = objData("CPRVCL") & " - " & objData("TCMPCL").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT")
          obj_Entidad.CPRVCL = objData("CPRVCL")
          obj_Entidad.NGUIRM = 0
          obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
          'End If
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Registrar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
        objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
        objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
        objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
        objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
        objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
        objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
        objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)
        objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
        objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
        objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
        objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
        objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
        objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
        objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
        objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
        objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
        objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
        objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
        objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
        objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
        objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
        objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
        objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
        objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
        objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
        objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
        objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
        objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
        objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
        objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
        objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
        objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
        objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
        objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
        objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
        objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
        objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
        objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
        objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
        objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
        objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
        objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
        objParam.Add("PARAM_FECETD", objEntidad.FECETD)
        objParam.Add("PARAM_FECETA", objEntidad.FECETA)
        objParam.Add("PARAM_TOBS", objEntidad.TOBS)
        objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
        'EN MODIFICACION
        objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
        objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
        objParam.Add("PARAM_CTPOV2", objEntidad.CTPOV2)

        objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
        objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
        objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GUIA_TRANSPORTISTA_AUTOGENERADA", objParam)

        objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
      Catch ex As Exception
        objEntidad.NGUIRM = 0
      End Try
      Return objEntidad
    End Function

    Public Function Registrar_Guia_Transportista_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
        objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
        objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
        objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
        objParam.Add("PARAM_CLCLOR", objEntidad.CLCLOR)
        objParam.Add("PARAM_CLCLDS", objEntidad.CLCLDS)
        objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
        objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)
        objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
        objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
        objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
        objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
        objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
        objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
        objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
        objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
        objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
        objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
        objParam.Add("PARAM_NPLCAC", objEntidad.NPLCAC)
        objParam.Add("PARAM_CBRCNT", objEntidad.CBRCNT)
        objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
        objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
        objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
        objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
        objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
        objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
        objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
        objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
        objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
        objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
        objParam.Add("PARAM_SESTRG", objEntidad.SESTRG)
        objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
        objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
        objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
        objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
        objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
        objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
        objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
        objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
        objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
        objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
        objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
        objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
        objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
        objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
        objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
        objParam.Add("PARAM_FECETD", objEntidad.FECETD)
        objParam.Add("PARAM_FECETA", objEntidad.FECETA)
        objParam.Add("PARAM_TOBS", objEntidad.TOBS)
        objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
        'EN MODIFICACION
        objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
        objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)
        objParam.Add("PARAM_CTPOV2", objEntidad.CTPOV2)

        objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
        objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
        objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_GUIA_TRANSPORTISTA_MANUAL", objParam)

        objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
      Catch ex As Exception
        objEntidad.NGUIRM = 0
      End Try
      Return objEntidad
    End Function

    Public Function Modificar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PARAM_CTRMNC", objEntidad.CTRMNC)
        objParam.Add("PARAM_NGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
        objParam.Add("PARAM_NPLNMT", objEntidad.NPLNMT)
        objParam.Add("PARAM_NOPRCN", objEntidad.NOPRCN)
        objParam.Add("PARAM_TRFRGU", objEntidad.TRFRGU)
        objParam.Add("PARAM_QMRCMC", objEntidad.QMRCMC)
        objParam.Add("PARAM_PMRCMC", objEntidad.PMRCMC)
        objParam.Add("PARAM_CUNDMD", objEntidad.CUNDMD)
        objParam.Add("PARAM_QGLGSL", objEntidad.QGLGSL)
        objParam.Add("PARAM_QGLDSL", objEntidad.QGLDSL)
        objParam.Add("PARAM_NRHJCR", objEntidad.NRHJCR)
        objParam.Add("PARAM_TNMBRM", objEntidad.TNMBRM)
        objParam.Add("PARAM_TDRCRM", objEntidad.TDRCRM)
        objParam.Add("PARAM_TPDCIR", objEntidad.TPDCIR)
        objParam.Add("PARAM_NRUCRM", objEntidad.NRUCRM)
        objParam.Add("PARAM_TNMBCN", objEntidad.TNMBCN)
        objParam.Add("PARAM_TDRCNS", objEntidad.TDRCNS)
        objParam.Add("PARAM_TPDCIC", objEntidad.TPDCIC)
        objParam.Add("PARAM_NRUCCN", objEntidad.NRUCCN)
        objParam.Add("PARAM_SACRGO", objEntidad.SACRGO)
        objParam.Add("PARAM_CMNFLT", objEntidad.CMNFLT)
        objParam.Add("PARAM_SIDAVL", objEntidad.SIDAVL)
        objParam.Add("PARAM_QKMREC", objEntidad.QKMREC)
        objParam.Add("PARAM_ICSTRM", objEntidad.ICSTRM)
        objParam.Add("PARAM_QPSOBR", objEntidad.QPSOBR)
        objParam.Add("PARAM_QVLMOR", objEntidad.QVLMOR)
        objParam.Add("PARAM_SMRPLG", objEntidad.SMRPLG)
        objParam.Add("PARAM_SMRPRC", objEntidad.SMRPRC)
        objParam.Add("PARAM_IVLPRT", objEntidad.IVLPRT)
        objParam.Add("PARAM_CMNVLP", objEntidad.CMNVLP)
        objParam.Add("PARAM_FULTAC", objEntidad.FULTAC)
        objParam.Add("PARAM_HULTAC", objEntidad.HULTAC)
        objParam.Add("PARAM_CULUSA", objEntidad.CULUSA)
        objParam.Add("PARAM_NTRMNL", objEntidad.NTRMNL)
        objParam.Add("PARAM_CUBORI", objEntidad.CUBORI)
        objParam.Add("PARAM_CUBDES", objEntidad.CUBDES)
        objParam.Add("PARAM_FGUIRM", objEntidad.FGUIRM)
        objParam.Add("PARAM_FEMVLH", objEntidad.FEMVLH)
        objParam.Add("PARAM_FECETD", objEntidad.FECETD)
        objParam.Add("PARAM_FECETA", objEntidad.FECETA)
        objParam.Add("PARAM_TOBS", objEntidad.TOBS)
        'EN MODIFICACION
        objParam.Add("PARAM_NPLCTR", objEntidad.NPLCTR)
        objParam.Add("PARAM_TCNFVH", objEntidad.TCNFVH)
        objParam.Add("PARAM_TDIROR", objEntidad.TDIROR)
        objParam.Add("PARAM_TDIRDS", objEntidad.TDIRDS)

        objParam.Add("PARAM_NOREMB", objEntidad.NOREMB)
        objParam.Add("PARAM_CTPOVJ", objEntidad.CTPOVJ)

        objParam.Add("PARAM_NMVJCS", objEntidad.NMVJCS)
        objParam.Add("PARAM_NMOPMM", objEntidad.NMOPMM)
        objParam.Add("PARAM_NMOPRP", objEntidad.NMOPRP)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_GUIA_TRANSPORTISTA_AUTOGENERADA", objParam)

        objEntidad.NGUIRM = objSql.ParameterCollection("PARAM_NGUIRM")
      Catch ex As Exception
        objEntidad.NGUIRM = 0
      End Try
      Return objEntidad
    End Function

        Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            Try

                objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
                objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
                objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
                objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
                Select Case objetoParametro("ESTADO")
                    Case 0
                        objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V2", objParam)
                    Case 1
                        objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                        objParam.Add("PNNORSRT", objetoParametro("PNNORSRT"))
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V5", objParam)
                    Case 2
                        objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V3", objParam)
                    Case 3
                        objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V4", objParam)
                End Select

                For Each objData As DataRow In objDataTable.Rows
                    objEntidad = New GuiaTransportista

                    objEntidad.CHECK = True
                    objEntidad.CTRMNC = objData("CTRMNC")
                    objEntidad.NGUIRM = objData("NGUIRM")
                    objEntidad.FGUIRM_S = objData("FGUIRM")
                    objEntidad.NPLNMT = objData("NPLNMT")
                    objEntidad.CLCLOR = objData("CLCLOR")
                    objEntidad.CLCLDS = objData("CLCLDS")
                    objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                    objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                    objEntidad.NOPRCN = objData("NOPRCN")
                    objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                    objEntidad.QMRCMC = objData("QMRCMC")
                    objEntidad.PMRCMC = objData("PMRCMC")
                    objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                    objEntidad.QGLGSL = objData("QGLGSL")
                    objEntidad.QGLDSL = objData("QGLDSL")
                    objEntidad.NRHJCR = objData("NRHJCR")
                    objEntidad.CTRSPT = objData("CTRSPT")
                    objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                    objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                    objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                    objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                    objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                    objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                    objEntidad.NRUCRM = objData("NRUCRM")
                    objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                    objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                    objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                    objEntidad.NRUCCN = objData("NRUCCN")
                    objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                    objEntidad.CMNFLT = objData("CMNFLT")
                    objEntidad.SESTRG = objData("SESTRG").ToString.Trim
                    objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                    objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                    objEntidad.QKMREC = objData("QKMREC")
                    objEntidad.ICSTRM = objData("ICSTRM")
                    objEntidad.QPSOBR = objData("QPSOBR")
                    objEntidad.QVLMOR = objData("QVLMOR")
                    objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                    objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                    objEntidad.IVLPRT = objData("IVLPRT")
                    objEntidad.CMNVLP = objData("CMNVLP")
                    objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objData("CPLNDV")
                    objEntidad.CUBORI = objData("CUBORI")
                    objEntidad.CUBDES = objData("CUBDES")
                    objEntidad.FEMVLH = objData("FEMVLH")
                    objEntidad.FEMVLH_S = objData("FEMVLH_S")
                    objEntidad.FCHFTR_S = objData("FCHFTR_S")
                    objEntidad.FECETA_S = objData("FECETA_S")
                    objEntidad.FECETD_S = objData("FECETD_S")
                    objEntidad.RUTA = objData("RUTA").ToString.Trim
                    objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                    objEntidad.TOBS = objData("TOBS").ToString.Trim
                    'EN MODIFICACION
                    objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                    objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                    objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                    objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

                    objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                    objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                    objEntidad.CMRCDR = objData("CMRCDR")
                    objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                    objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                    objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                    objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
                    objEntidad.NOREMB = objData("NOREMB").ToString.Trim

                    objEntidad.NCSOTR = objData("NCSOTR").ToString.Trim
                    objEntidad.QSLCIT = objData("QSLCIT").ToString.Trim
                    objEntidad.NDCORM = objData("NDCORM").ToString.Trim
                    objEntidad.NMVJCS = objData("NMVJCS").ToString.Trim
                    objEntidad.NRUCTR = objData("NRUCTR")
                    objEntidad.SSINVJ = objData("SSINVJ").ToString.Trim

                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Dim s As String = ""
            End Try
            Return objGenericCollection
        End Function

    Public Function Listar_Guia_Transportista_Reparto(ByVal objetoParametro As Hashtable) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Try

        objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
        objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_X_OPERACION_REPARTO", objParam)

      Catch ex As Exception
        Dim s As String = ""
      End Try
      Return objDataTable
    End Function

    Public Function Listar_Viaje_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim objEntidad As GuiaTransportista
      Try
        objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
        objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
        objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_VIAJE_CONSOLIDADO", objParam)

        For Each objData As DataRow In objDataTable.Rows
          objEntidad = New GuiaTransportista
          objEntidad.CHECK = True
          objEntidad.NMVJCS = objData("NMVJCS")
          objEntidad.CTRMNC = objData("CTRMNC")
          objEntidad.FCHVJC_S = Validacion.CFecha_a_Numero10Digitos(objData("FCHVJC").ToString)
          objEntidad.RUTA = objData("RUTA").ToString.Trim
          objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim
          objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
          objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
          objEntidad.CBRCND = objData("CBRCND").ToString.Trim
          objEntidad.PSOVOL = Format(objData("PSOVOL"), "###,###.00")
          objEntidad.PMRCMC = Format(objData("PMRCMC"), "###,###.00")
          objEntidad.QPSOBR = Format(objData("QPSOBR"), "###,###.00")
          objEntidad.FLGSTS = objData("FLGSTS").ToString.Trim
          objEntidad.CCMPN = objData("CCMPN").ToString.Trim
          objEntidad.CDVSN = objData("CDVSN").ToString.Trim
          objEntidad.CPLNDV = objData("CPLNDV")
          objGenericCollection.Add(objEntidad)
        Next
      Catch ex As Exception
        Dim s As String = ""
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Moneda(ByVal strCompania As String) As DataTable
      Dim objDataTable As New DataTable
      Try
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_MONEDA", Nothing)
      Catch : End Try

      Return objDataTable
    End Function

    Public Function Obtener_Codigo_Transportista(ByVal lstr_RUC As String, ByVal strCompania As String) As Double
      Dim lstr_Codigo As Double = 0

      Try
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", strCompania)
        objParam.Add("PSNRUCTR", lstr_RUC)
        objParam.Add("PNCTRSPT", 0, ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_CODIGO_TRANSPORTISTA", objParam)

        lstr_Codigo = objSql.ParameterCollection("PNCTRSPT").ToString
      Catch : End Try

      Return lstr_Codigo
    End Function

    Public Function Obtener_RUC_Transportista(ByVal lstr_Codigo As Double, ByVal strCompania As String) As String
      Dim lstr_RUC As String = ""

      Try
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", strCompania)
        objParam.Add("PNCTRSPT", lstr_Codigo)
        objParam.Add("PSNRUCTR", "", ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_RUC_TRANSPORTISTA", objParam)

        lstr_RUC = objSql.ParameterCollection("PSNRUCTR").ToString
      Catch : End Try

      Return lstr_RUC
    End Function

    Public Function Obtener_Guia_Transportista_RPT(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Dim obj_Entidad As New GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        For Each objData As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_GUIA_TRANSPORTISTA_RPT", objParam).Rows

          obj_Entidad.CTRMNC = objData("CTRMNC")
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.FGUIRM = objData("FGUIRM")
          obj_Entidad.TRFRGU = objData("TRFRGU").ToString.Trim
          obj_Entidad.QMRCMC = objData("QMRCMC")
          obj_Entidad.PMRCMC = objData("PMRCMC")
          obj_Entidad.CUNDMD = objData("CUNDMD").ToString.Trim
          obj_Entidad.QGLGSL = objData("QGLGSL")
          obj_Entidad.QGLDSL = objData("QGLDSL")
          obj_Entidad.NRHJCR = objData("NRHJCR")
          obj_Entidad.CTRSPT = objData("CTRSPT")
          obj_Entidad.NPLCTR = objData("NPLCTR").ToString.Trim
          obj_Entidad.NPLCAC = objData("NPLCAC").ToString.Trim
          obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
          obj_Entidad.TNMBRM = objData("TNMBRM").ToString.Trim
          obj_Entidad.TDRCRM = objData("TDRCRM").ToString.Trim
          obj_Entidad.TPDCIR = objData("TPDCIR").ToString.Trim
          obj_Entidad.NRUCRM = objData("NRUCRM")
          obj_Entidad.TNMBCN = objData("TNMBCN").ToString.Trim
          obj_Entidad.TDRCNS = objData("TDRCNS").ToString.Trim
          obj_Entidad.TPDCIC = objData("TPDCIC").ToString.Trim
          obj_Entidad.NRUCCN = objData("NRUCCN")
          obj_Entidad.NOPRCN = objData("NOPRCN")
          obj_Entidad.NPLNMT = objData("NPLNMT")
          obj_Entidad.NORSRT = objData("NORSRT").ToString.Trim
          obj_Entidad.NRGUCL_S = objData("NRGUCL").ToString.Trim
          obj_Entidad.QKMREC = objData("QKMREC")
          obj_Entidad.ICSTRM = objData("ICSTRM")
          obj_Entidad.QPSOBR = objData("QPSOBR")
          obj_Entidad.QVLMOR = objData("QVLMOR")
          obj_Entidad.SMRPLG = objData("SMRPLG").ToString.Trim
          obj_Entidad.SMRPRC = objData("SMRPRC").ToString.Trim
          obj_Entidad.IVLPRT = objData("IVLPRT")
          obj_Entidad.CMNVLP = objData("CMNVLP")
          obj_Entidad.CUBORI_S = objData("CUBORI").ToString.Trim
          obj_Entidad.CUBDES_S = objData("CUBDES").ToString.Trim
          obj_Entidad.TDIROR = objData("TDIROR").ToString.Trim
          obj_Entidad.TDIRDS = objData("TDIRDS").ToString.Trim
          obj_Entidad.FEMVLH = objData("FEMVLH")
          obj_Entidad.TOBS = objData("TOBS").ToString.Trim
          obj_Entidad.TCNFG1 = objData("TCNFG1").ToString.Trim
          obj_Entidad.TCNFVH = objData("TCNFVH").ToString.Trim
        Next
      Catch : End Try
      Return obj_Entidad
    End Function

    Public Function Registrar_GuiasCliente_Automatico(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter
        '-- SE MODIFICO, SE AGREGO OPERACION
        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
        objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
        objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
        objParam.Add("TIPOGUIA", objEntidad.FLAG_PSOVOL)
        objParam.Add("PNNGRPRV", objEntidad.TOBS)
        objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
        '------------------------------------------
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE", objParam)

      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Registrar_GuiasCliente_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter
        '-- SE MODIFICO, SE AGREGO OPERACION
        objParam.Add("PNCTRMNC", objEntidad.CTRMNC, ParameterDirection.Output)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM, ParameterDirection.Output)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL, ParameterDirection.Output)
        objParam.Add("PNFCGUCL", objEntidad.FCGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        'objParam.Add("PNNRSERI", objEntidad.NRSERI)
        'objParam.Add("PNNPRGUI", objEntidad.NPRGUI)
        objParam.Add("PNCPRVCL", objEntidad.CPRVCL)
        objParam.Add("PNNRGUSA", objEntidad.NRGUSA)
        '------------------------------------------
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PNPSOVOL", objEntidad.PSOVOL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_DETALLE_GUIA_CLIENTE_MANUAL", objParam)
        objEntidad.NRGUCL = objSql.ParameterCollection("PNNRGUCL")
        objEntidad.CTRMNC = objSql.ParameterCollection("PNCTRMNC")
        objEntidad.NGUIRM = objSql.ParameterCollection("PNNGUIRM")
      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Registrar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSNORCMC", objEntidad.NORCMC)
        objParam.Add("PNNRITOC", objEntidad.NRITOC)
        objParam.Add("PNQCNTIT", objEntidad.QCNTIT)
        objParam.Add("PSCREFFW", objEntidad.CREFFW)
        objParam.Add("PNNSEQIN", objEntidad.NSEQIN)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_ORDEN_COMPRA", objParam)

      Catch ex As Exception
        objEntidad.NORCMC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Registrar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNGUIAD", objEntidad.NGUIAD)
        objParam.Add("PNFGUIRM", objEntidad.FGUIRM)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_ANEXO_GUIA_TRANSPORTISTA", objParam)

      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function


    Public Function Agregar_Guia_Transportista_Adicional(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte

      Try
        Dim objParam As New Parameter

        objParam.Add("PNNCSOTR", objEntidad.NCSOTR)
        objParam.Add("PNNCRRSR", objEntidad.NCRRSR)
        objParam.Add("PNNGUITR", objEntidad.NGUITR)
        objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PNHRACRT", objEntidad.HRACRT)
        objParam.Add("PSNTRMCR", objEntidad.NTRMCR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_GUIA_TRANSPORTISTA_ADICIONAL", objParam)

      Catch ex As Exception
        objEntidad.NGUITR = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista

      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNGUIAD", objEntidad.NGUIAD)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA_ANEXA", objParam)

      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_GuiasCliente(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_CLIENTE", objParam)

      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_ORDEN_COMPRA_CLIENTE", objParam)

      Catch ex As Exception
        objEntidad.NORCMC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Orden_Compra(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSNORCMC", objEntidad.NORCMC)
        objParam.Add("PNNRITOC", objEntidad.NRITOC)
        objParam.Add("PNNCRRGR", objEntidad.NCRRGR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_ORDEN_COMPRA", objParam)

      Catch ex As Exception
        objEntidad.NORCMC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PNFULTAC", objEntidad.FULTAC)
        objParam.Add("PNHULTAC", objEntidad.HULTAC)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSSESTRG", objEntidad.SESTRG)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA", objParam)

      Catch ex As Exception
        objEntidad.CTRMNC = 0
      End Try
      Return objEntidad
    End Function

    Public Function Listar_Guias_Anexas_Cliente(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ANEXO_GUIA_CLIENTE", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.NRGUCL = objData("NRGUCL") 'objData("NRGUCL").ToString.Substring(0, 3) & "-" & objData("NRGUCL").ToString.Substring(3, 7)
          obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT")
          obj_Entidad.FCGUCL_S = objData("FCGUCL").ToString.Trim
          obj_Entidad.SESTRG = objData("CASE").ToString.Trim
          obj_Entidad.NOPRCN = objData("NOPRCN")
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Guias_Anexas_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ANEXO_GUIA_TRANSPORTISTA", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.NGUIAD = objData("NGUIAD")
          obj_Entidad.FGUIRM_S = objData("FGUIRM").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Ordenes_Compra_x_MC(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As List(Of ENTIDADES.GuiaOCManifiestoCarga)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
      Dim obj_Entidad As ENTIDADES.GuiaOCManifiestoCarga
      Try
        Dim objParam As New Parameter

        objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
        objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
        
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ORDENES_COMPRA_X_GUIA_TRANSPORTISTA", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New ENTIDADES.GuiaOCManifiestoCarga
          obj_Entidad.NGUIRM = objData("NGUIRM")
          obj_Entidad.NRGUCL = objData("NRGUCL")
          obj_Entidad.NORCMC = objData("NORCMC").ToString.Trim
          obj_Entidad.NRITOC = objData("NRITOC")
          obj_Entidad.TDITES = objData("TDITES").ToString.Trim
          obj_Entidad.TUNDIT = objData("TUNDIT").ToString.Trim
          obj_Entidad.QCNTIT = objData("QCNTIT")
          obj_Entidad.CREFFW = objData("CREFFW").ToString.Trim
          obj_Entidad.NSEQIN = objData("NSEQIN")
          obj_Entidad.NCRRGR = objData("NCRRGR")
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Solicitudes_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of Detalle_Solicitud_Transporte)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Detalle_Solicitud_Transporte)
      Dim obj_Entidad As Detalle_Solicitud_Transporte
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNGUIRM", objetoParametro("PNNGUIRM"))
        objParam.Add("PSNPLCUN", objetoParametro("PSNPLCUN"))
        objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
        objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
        objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
        objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
        objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SOLICITUD_GUIA_TRANSPORTISTA", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New Detalle_Solicitud_Transporte
          obj_Entidad.NCSOTR = objData("NCSOTR").ToString.Trim
          obj_Entidad.NCRRSR = objData("NCRRSR").ToString.Trim
          obj_Entidad.FASGTR = objData("FASGTR").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT").ToString.Trim
          obj_Entidad.TCMPCL = objData("TCMPCL").ToString.Trim
          obj_Entidad.CTRSPT = objData("CTRSPT").ToString.Trim
          obj_Entidad.NPLCUN = objData("NPLCUN").ToString.Trim
          obj_Entidad.NGUITR = objData("NGUITR").ToString.Trim
          obj_Entidad.NPLNMT = objData("NPLNMT").ToString.Trim
          obj_Entidad.NOPRCN = objData("NOPRCN").ToString.Trim
          obj_Entidad.SESTOP = objData("SESTOP").ToString.Trim
          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        Return New List(Of Detalle_Solicitud_Transporte)
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Guia_Remision_x_Operacion(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of GuiaTransportista)
      Dim obj_Entidad As GuiaTransportista
      Try
        Dim objParam As New Parameter

        objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_REMISION_x_OPERACION", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New GuiaTransportista

          obj_Entidad.NOPRCN = objData("NOPRCN").ToString.Trim
          obj_Entidad.NGUIRM = objData("NGUITR").ToString.Trim
          obj_Entidad.FGUIRM = objData("FGUITR").ToString.Trim
          obj_Entidad.CTRSPT = objData("CTRSPT").ToString.Trim
          obj_Entidad.NPLCTR = objData("NPLVHT").ToString.Trim
          obj_Entidad.CBRCNT = objData("CBRCNT").ToString.Trim
          obj_Entidad.CBRCND = objData("TDSTRT").ToString.Trim
          obj_Entidad.SRPTRM = objData("SRPTRM").ToString.Trim
          obj_Entidad.FSLDCM = objData("FSLDCM").ToString.Trim
          obj_Entidad.FLLGCM = objData("FLLGCM").ToString.Trim
          obj_Entidad.QPSOBR = objData("PBRTOR").ToString.Trim
          obj_Entidad.QMRCMC = objData("QBLORG").ToString.Trim
          obj_Entidad.QVLMOR = objData("QVLMOR").ToString.Trim
          obj_Entidad.QKMREC = objData("QKLMRC").ToString.Trim
          obj_Entidad.CCLNT = objData("CCLNT1").ToString.Trim
          obj_Entidad.TCMPCL = objData("TRFMRC").ToString.Trim
          obj_Entidad.CCMPN = objData("CCMPN").ToString.Trim
          obj_Entidad.CDVSN = objData("CDVSN").ToString.Trim
          obj_Entidad.CPLNDV = objData("CPLNDV").ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        Return New List(Of GuiaTransportista)
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_Configuracion_Vehicular(ByVal strCompania As String) As List(Of ClaseGeneral)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of ClaseGeneral)
      Dim obj_Entidad As ClaseGeneral
      Try
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CONFIGURACION_VEHICULAR", Nothing)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New ClaseGeneral

          obj_Entidad.TCNFVH = objData("TCNFVH").ToString.Trim
          obj_Entidad.TDSCM1 = objData("TDSCM1").ToString.Trim
          obj_Entidad.QCRUTV = objData("QCRUTV")

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        Return New List(Of ClaseGeneral)
      End Try
      Return objGenericCollection
    End Function

    ' Liquidación de Fletes
    Public Function Listar_GRemPendientesGTranspLiquidacion(ByVal oFiltro As TD_GuiaTransportistaPK) As List(Of TD_Obj_GuiaRemisionGTransp)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GuiaRemisionGTransp)
      Dim oGuiaRemisionGTransp As TD_Obj_GuiaRemisionGTransp
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_CTRMNC", oFiltro.pCTRMNC_CodigoTransportista)
        objParam.Add("IN_NGUIRM", oFiltro.pNGUIRM_NroGuiaTransportista)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Ccompania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_PENDIENTES_PARA_LIQ", objParam)

        For Each objData As DataRow In objDataTable.Rows
          oGuiaRemisionGTransp = New TD_Obj_GuiaRemisionGTransp()

          oGuiaRemisionGTransp.pCTRMNC_CodigoTransportista = oFiltro.pCTRMNC_CodigoTransportista
          oGuiaRemisionGTransp.pNGUIRM_NroGuiaTransportista = oFiltro.pNGUIRM_NroGuiaTransportista
          oGuiaRemisionGTransp.pNRGUCL_NroGuiaRemision = objData("NRGUCL")
          oGuiaRemisionGTransp.pTCMPCL_RazonSocialCliente = objData("TCMPCL")
          oGuiaRemisionGTransp.pCCLNT_CodigoCliente = objData("CCLNT")
          oGuiaRemisionGTransp.pFCGUCL_FechaGuiaRemision = objData("FCGUCL")

          objGenericCollection.Add(oGuiaRemisionGTransp)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function

    Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
      Dim sErrorMessage As String = ""
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
        objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
          obj_Entidad.pNGUIRM_NroGuiaTransportista = objEntidad.pNGUIRM_NroGuiaTransportista
          obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
          obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
          obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
          obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
          obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
          obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
          obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
          Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
          obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
          obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
          obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        sErrorMessage = ex.ToString
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As Hashtable) As List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
      Dim sErrorMessage As String = ""
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_CTRMNC", objEntidad("CTRMNC"))
        objParam.Add("IN_NGUIRM", objEntidad("NGUIRM"))

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_GUIA_TRANSPORTE_PARA_LIQ", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
          obj_Entidad.pNGUIRM_NroGuiaTransportista = objEntidad("NGUIRM") 'objEntidad.pNGUIRM_NroGuiaTransportista
          obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
          obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
          obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
          obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
          obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
          obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
          obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
          Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
          obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
          obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
          obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        sErrorMessage = ex.ToString
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_GRemCargadasGTranspLiquidacion_Reparto(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
      Dim sErrorMessage As String = ""
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ_REPARTO", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
          obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
          obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
          obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
          obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
          obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
          obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
          obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
          obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
          Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
          obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
          obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
          obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        sErrorMessage = ex.ToString
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_GRemCargadasGTranspLiquidacion_Multimodal(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
      Dim sErrorMessage As String = ""
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_CARGADAS_PARA_LIQ_MULTIMODAL", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
          obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
          obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
          obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
          obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
          obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
          obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
          obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
          obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
          Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
          obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
          obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
          obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch ex As Exception
        sErrorMessage = ex.ToString
      End Try
      Return objGenericCollection
    End Function

    Public Function Listar_GRemHijasCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemHijasCargadasGTranspLiqPK) As List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemHijasCargadasGTranspLiq
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
        objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_HIJAS_CARGADAS_PARA_LIQ", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemHijasCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = objEntidad.pNOPRCN_NroOperacion
          obj_Entidad.pNGUITR_GuiaRemisionCargada = objEntidad.pNGUITR_GuiaRemisionCargada
          obj_Entidad.pNGUIRF_NroDocumentoReferencia = objData("NGUIRF")
          obj_Entidad.pQCCMP1_CantidadComponente1Gsl = objData("QCCMP1")
          obj_Entidad.pQCCMP2_CantidadComponente2Dsl = objData("QCCMP2")
          obj_Entidad.pTDSEXO_Observacion = objData("TDSEXO").ToString.Trim
          obj_Entidad.pCCLNT1_CodigoCliente = objData("CCLNT1")

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
    End Function
        
    Public Function Listar_GRemServCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
      Dim obj_Entidad As TD_Obj_GRemServCargadasGTranspLiq
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
        objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_PARA_LIQ", objParam)

        For Each objData As DataRow In objDataTable.Rows
          obj_Entidad = New TD_Obj_GRemServCargadasGTranspLiq

          obj_Entidad.pNOPRCN_NroOperacion = oFiltro.pNOPRCN_NroOperacion
          obj_Entidad.pNGUITR_NroGuiaRemision = oFiltro.pNGUITR_NroGuiaRemision
          obj_Entidad.pNCRRGU_CorrServ = objData("NCRRGU")
          obj_Entidad.pCSRVC_Servicio = objData("CSRVC")
          obj_Entidad.pTCMTRF_DetalleServicio = ("" & objData("TCMTRF")).ToString.Trim
          obj_Entidad.pISRVGU_importeServicio = objData("ISRVGU")
          obj_Entidad.pCMNDGU_MonedaGuia = objData("CMNDGU")
          obj_Entidad.pCMNDGU_MonedaGuia_S = ("" & objData("CMNDGU_S")).ToString.Trim

          obj_Entidad.pQCNDTG_CantidadServicio = objData("QCNDTG")
          obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
          obj_Entidad.pSFCTTR_StatusFacturado = ("" & objData("SFCTTR")).ToString.Trim

          obj_Entidad.pILQDTR_ImporteLiquidacionTransp = objData("ILQDTR")
          obj_Entidad.pQCNDLG_CantidadServicioLiquidacion = objData("QCNDLG")
          obj_Entidad.pCUNDTR_Unidad = ("" & objData("CUNDTR")).ToString.Trim
          obj_Entidad.pSLQDTR_StatusLiquTransporte = ("" & objData("SLQDTR")).ToString.Trim

          obj_Entidad.pTRFSRG_RefrenciaServicioGuia = ("" & objData("TRFSRG")).ToString.Trim
          obj_Entidad.pCMNLQT_Moneda = objData("CMNLQT")
          obj_Entidad.pCMNLQT_Moneda_S = ("" & objData("CMNLQT_S")).ToString.Trim

          objGenericCollection.Add(obj_Entidad)
        Next
      Catch : End Try
      Return objGenericCollection
        End Function
        Public Function Listar_GRemServCargadasGTranspLiquidacion_Refactura(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemServCargadasGTranspLiq
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_SERV_CARGADAS_PARA_LIQ_REFACTURA", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    obj_Entidad = New TD_Obj_GRemServCargadasGTranspLiq

                    obj_Entidad.pNOPRCN_NroOperacion = oFiltro.pNOPRCN_NroOperacion
                    obj_Entidad.pNGUITR_NroGuiaRemision = oFiltro.pNGUITR_NroGuiaRemision
                    obj_Entidad.pNCRRGU_CorrServ = objData("NCRRGU")
                    obj_Entidad.pCSRVC_Servicio = objData("CSRVC")
                    obj_Entidad.pTCMTRF_DetalleServicio = ("" & objData("TCMTRF")).ToString.Trim
                    obj_Entidad.pISRVGU_importeServicio = objData("ISRVGU")
                    obj_Entidad.pCMNDGU_MonedaGuia = objData("CMNDGU")
                    obj_Entidad.pCMNDGU_MonedaGuia_S = ("" & objData("CMNDGU_S")).ToString.Trim

                    obj_Entidad.pQCNDTG_CantidadServicio = objData("QCNDTG")
                    obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                    objGenericCollection.Add(obj_Entidad)
                Next
            Catch : End Try
            Return objGenericCollection
        End Function

    Public Function Listar_ServiciosPorDefectoPorCliente(ByVal oFiltro As TD_Qry_ServiciosFijosPorCliente) As DataTable
      Dim objDataTable As New DataTable
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_CCMPN", oFiltro.pCCMPN_Compania)
        objParam.Add("IN_CDVSN", oFiltro.pCDVSN_Division)
        objParam.Add("IN_CPLNDV", oFiltro.pCPLNDV_Planta)
        objParam.Add("IN_CCLNT", oFiltro.pCCLNT_CodigoCliente)
        objParam.Add("IN_NORSRT", oFiltro.pNORSRT_OrdenServicio)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIOS_TRANSP_POR_CLIENTE", objParam)
      Catch
        objDataTable = New DataTable
      End Try
      Return objDataTable
    End Function

    Public Function Registrar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
      Dim bResultado As Boolean = True
      Try
        Dim objParam As New Parameter

        objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
        objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
        objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)
        objParam.Add("IN_FGUITR", objEntidad.pFGUITR_FechaGuiaRemisionFNum)
        objParam.Add("IN_RELGUI", objEntidad.pRELGUI_RelacionGuiaHijas)
        objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
        objParam.Add("IN_NLQDCN", objEntidad.pNLQDCN_NroLiquidacion)
        objParam.Add("IN_CTRSPT", objEntidad.pCTRSPT_Transportista)
        objParam.Add("IN_NPLVHT", objEntidad.pNPLVHT_Tracto)
        objParam.Add("IN_CBRCNT", objEntidad.pCBRCNT_Brevete)
        objParam.Add("IN_CMRCDR", objEntidad.pCMRCDR_Mercaderia)
        objParam.Add("IN_CCLNT1", objEntidad.pCCLNT1_CodigoCliente)
        objParam.Add("IN_CLCLOR", objEntidad.pCLCLOR_CodigoLocalidadOrigen)
        objParam.Add("IN_CLCLDS", objEntidad.pCLCLDS_CodigoLocalidadDestino)
        objParam.Add("IN_FRCGRM", objEntidad.pFRCGRM_FechaRecepGuiaRemisionFNum)
        objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
        objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
        objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
        objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
        objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
        objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
        objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
        objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
        objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
        objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
        objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
        objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
        objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
        objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
        objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
        objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
        objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
        objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
                objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
                objParam.Add("IN_SSINVJ", objEntidad.pSSINVJ_FlagSiniestroViaje)
        objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
        objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
        objParam.Add("OU_ERRMSG", "", ParameterDirection.Output)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

        objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_GUIA_TRANSPORTISTA_PARA_LIQ", objParam)
        sErrorMesage = objSql.ParameterCollection("OU_ERRMSG")
        If sErrorMesage <> "" Then bResultado = False
      Catch ex As Exception
        sErrorMesage = ex.Message
        bResultado = False
      End Try
      Return bResultado
    End Function

    'Public Function Registrar_GuiaRemisionLiqTransp_Reparto(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
    '  Dim bResultado As Boolean = True
    '  Try
    '    Dim objParam As New Parameter

    '    objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
    '    objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
    '    objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)
    '    objParam.Add("IN_FGUITR", objEntidad.pFGUITR_FechaGuiaRemisionFNum)
    '    objParam.Add("IN_RELGUI", objEntidad.pRELGUI_RelacionGuiaHijas)
    '    objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
    '    objParam.Add("IN_NLQDCN", objEntidad.pNLQDCN_NroLiquidacion)
    '    objParam.Add("IN_CTRSPT", objEntidad.pCTRSPT_Transportista)
    '    objParam.Add("IN_NPLVHT", objEntidad.pNPLVHT_Tracto)
    '    objParam.Add("IN_CBRCNT", objEntidad.pCBRCNT_Brevete)
    '    objParam.Add("IN_CMRCDR", objEntidad.pCMRCDR_Mercaderia)
    '    objParam.Add("IN_CCLNT1", objEntidad.pCCLNT1_CodigoCliente)
    '    objParam.Add("IN_CLCLOR", objEntidad.pCLCLOR_CodigoLocalidadOrigen)
    '    objParam.Add("IN_CLCLDS", objEntidad.pCLCLDS_CodigoLocalidadDestino)
    '    objParam.Add("IN_FRCGRM", objEntidad.pFRCGRM_FechaRecepGuiaRemisionFNum)
    '    objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
    '    objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
    '    objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
    '    objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
    '    objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
    '    objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
    '    objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
    '    objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
    '    objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
    '    objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
    '    objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
    '    objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
    '    objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
    '    objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
    '    objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
    '    objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
    '    objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
    '    objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
    '    objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
    '    objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
    '    objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
    '    objParam.Add("OU_ERRMSG", "", ParameterDirection.Output)

    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

    '    objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_GUIA_TRANSPORTISTA_PARA_LIQ_REPARTO", objParam)
    '    sErrorMesage = objSql.ParameterCollection("OU_ERRMSG")
    '    If sErrorMesage <> "" Then bResultado = False
    '  Catch ex As Exception
    '    sErrorMesage = ex.Message
    '    bResultado = False
    '  End Try
    '  Return bResultado
    'End Function
        'Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean

        Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As Int32
            'Dim bResultado As Boolean = True
            Dim bResultado As Int32 = 0
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_FTRMOP", objEntidad.pFTRMOP_FechaOperacionFNum)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP2", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByVal sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_REPARTO2", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False

            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_FCHVJC", objEntidad.FCHVJC)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_CONSOLIDADO", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(ByVal objEntidad As TransporteConsolidado) As Int32
            'Dim bResultado As Boolean = True
            Dim bResultado As Int32 = 0
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_FTRMOP", objEntidad.FCHVJC)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_CONSOLIDADO2", objParam)
            Catch ex As Exception
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CMNLQT", objEntidad.pCMNLQT_Moneda)
                objParam.Add("IN_ILQDTR", objEntidad.pILQDTR_ImporteLiquidacionTransp)
                objParam.Add("IN_QCNDLG", objEntidad.pQCNDLG_CantidadServicioLiquidacion)
                objParam.Add("IN_CUNDTR", objEntidad.pCUNDTR_Unidad)
                objParam.Add("IN_SLQDTR", objEntidad.pSLQDTR_StatusLiquTransporte)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK, ByRef sErrorMensaje As String) As Boolean
            Dim bResultado As Boolean = True
            sErrorMensaje = ""
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_CTRMNC", oFiltro.pCTRMNC_CodigoTransportista)
                objParam.Add("IN_NGUIRM", oFiltro.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_MMCUSR", oFiltro.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", oFiltro.pNTRMNL_Terminal)
                objParam.Add("OU_ERRMSG", "", ParameterDirection.InputOutput)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GREMISION_CARGADAS_PARA_LIQ", objParam)

                sErrorMensaje = ("" & objSql.ParameterCollection("OU_ERRMSG"))
                If sErrorMensaje <> "" Then bResultado = False
            Catch ex As Exception
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Eliminar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        Public Function Eliminar_LiquServGuiaRemisionLiqTransp_Refactura(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_LIQUIDACION_SERVICIO_LIQTRANSP_REFACTURA", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Agregar_GRemServCargadasGTranspLiq(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CSRVC", objEntidad.pCSRVC_Servicio)

                objParam.Add("IN_TRFSRG", objEntidad.pTRFSRG_RefrenciaServicioGuia)
                objParam.Add("IN_CMNDGU", objEntidad.pCMNDGU_MonedaGuia)
                objParam.Add("IN_ISRVGU", objEntidad.pISRVGU_importeServicio)
                objParam.Add("IN_QCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
                objParam.Add("IN_CUNDSR", objEntidad.pCUNDSR_Unidad)
                objParam.Add("IN_SFCTTR", objEntidad.pSFCTTR_StatusFacturado)

                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIO_LIQTRANSP", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        Public Function Agregar_GRemServCargadasGTranspLiq_ReFactura(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_NroGuiaRemision)
                objParam.Add("IN_NCRRGU", objEntidad.pNCRRGU_CorrServ)
                objParam.Add("IN_CSRVC", objEntidad.pCSRVC_Servicio)

                'objParam.Add("IN_TRFSRG", objEntidad.pTRFSRG_RefrenciaServicioGuia)
                objParam.Add("IN_CMNDGU", objEntidad.pCMNDGU_MonedaGuia)
                objParam.Add("IN_ISRVGU", objEntidad.pISRVGU_importeServicio)
                objParam.Add("IN_QCNDTG", objEntidad.pQCNDTG_CantServicioGuia)
                objParam.Add("IN_CUNDSR", objEntidad.pCUNDSR_Unidad)
                ' objParam.Add("IN_SFCTTR", objEntidad.pSFCTTR_StatusFacturado)

                ' objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                'objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_AGREGAR_LIQUIDACION_SERVICIO_LIQTRANSP_REFACTURA", objParam)
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Obtener_Guia_Remision(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As TD_Obj_InfGRemCargada
            Dim objDataSet As New DataSet
            'Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of TD_Obj_InfGRemCargada)
            Dim obj_Entidad As New TD_Obj_InfGRemCargada
            Dim strGuiaReferencia As String = ""
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", oFiltro.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUITR", oFiltro.pNGUITR_NroGuiaRemision)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.pCCMPN_Compania)

                objDataSet = objSql.ExecuteDataSet("SP_SOLMIN_ST_OBTENER_GREMISION_SERV_CARGADA", objParam)
                For Each objData As DataRow In objDataSet.Tables(1).Rows
                    strGuiaReferencia = strGuiaReferencia + objData("NGUIRF").ToString.Trim + ","
                Next
                If strGuiaReferencia.Trim.Length > 0 Then strGuiaReferencia = strGuiaReferencia.Trim.Substring(0, strGuiaReferencia.Length - 1)
                For Each objData As DataRow In objDataSet.Tables(0).Rows
                    'obj_Entidad = New TD_Obj_InfGRemCargada
                    obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                    obj_Entidad.pFSLDCM_FechaSalidaCamion = objData("FSLDCM")
                    obj_Entidad.pCPRCN1_CodigoPropietarioContenedor1 = objData("CPRCN1")
                    obj_Entidad.pNSRCN1_SerieContenedor1 = objData("NSRCN1")
                    obj_Entidad.pCPRCN2_CodigoPropietarioContenedor2 = objData("CPRCN2")
                    obj_Entidad.pNSRCN2_SerieContenedor2 = objData("NSRCN2")
                    obj_Entidad.pQGLGSL_CantidadGlsGasolina = objData("QGLGSL")
                    obj_Entidad.pQGLDSL_CantidadGlsDiesel = objData("QGLDSL")
                    obj_Entidad.pNRHJCR_NroHojasCargui = objData("NRHJCR")
                    obj_Entidad.pQKLMRC_KilometrosRecorridos = objData("QKLMRC")
                    obj_Entidad.pQBLRMS_CantidadBultosRemision = objData("QBLRMS")
                    obj_Entidad.pQBLRCP_CantidadBultosRecepcion = objData("QBLRCP")
                    obj_Entidad.pPBRTOR_PesoBrutoRemision = objData("PBRTOR")
                    obj_Entidad.pPBRDST_PesoBrutoRecepcion = objData("PBRDST")
                    obj_Entidad.pPTRAOR_PesoTaraRemision = objData("PTRAOR")
                    obj_Entidad.pPTRDST_PesoTaraRecepcion = objData("PTRDST")
                    obj_Entidad.pQVLMOR_VolumenRemision = objData("QVLMOR")
                    obj_Entidad.pQVLMDS_VolumenRecepcion = objData("QVLMDS")
                    obj_Entidad.pQHRSRV_CantidadHorasServicio = objData("QHRSRV")
                    obj_Entidad.pRELGUI_RelacionGuiaHijas = strGuiaReferencia

                    obj_Entidad.pCTRMNC_CodigoTransportista = objData("CTRSPT")
                    obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM")
                    obj_Entidad.pCCLNT1_CodigoCliente = objData("CCLNT1")
                    obj_Entidad.pCLCLOR_CodigoLocalidadOrigen = objData("CLCLOR")
                    obj_Entidad.pTCMLCO_LocalidadOrigen = objData("TCMLCO")
                    obj_Entidad.pCLCLDS_CodigoLocalidadDestino = objData("CLCLDS")
                    obj_Entidad.pTCMLCD_LocalidadDestino = objData("TCMLCD")
                    obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                    obj_Entidad.pTCMTRT_RazSocialTransportista = objData("TCMTRT")
                    obj_Entidad.pNPLVHT_Tracto = objData("NPLVHT")
                    obj_Entidad.pCBRCNT_Brevete = objData("CBRCNT")
                    obj_Entidad.pCMRCDR_Mercaderia = objData("CMRCDR")
                    obj_Entidad.pTAMRCD_DetalleMercaderia = objData("TCMRCD").ToString
                    If IsDBNull(objData("FLLGCM")) = True Then
                        obj_Entidad.pFLLGCM_FechaLlegadaCamion = New Date
                    Else
                        obj_Entidad.pFLLGCM_FechaLlegadaCamion = objData("FLLGCM")
                    End If
                    obj_Entidad.pNOREMB_OrdenEmbarcador = objData("NOREMB")
                    obj_Entidad.pSSINVJ_FlagSiniestroViaje = objData("SSINVJ")
                    'objGenericCollection.Add(obj_Entidad)
                Next
            Catch : End Try
            Return obj_Entidad
        End Function

        Public Function Modificar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CTRMNC", objEntidad.pCTRMNC_CodigoTransportista)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_NGUITR", objEntidad.pNGUITR_GuiaRemisionCargada)
                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_QGLGSL", objEntidad.pQGLGSL_CantidadGlsGasolina)
                objParam.Add("IN_QGLDSL", objEntidad.pQGLDSL_CantidadGlsDiesel)
                objParam.Add("IN_NRHJCR", objEntidad.pNRHJCR_NroHojasCargui)
                objParam.Add("IN_CPRCN1", objEntidad.pCPRCN1_CodigoPropietarioContenedor1)
                objParam.Add("IN_NSRCN1", objEntidad.pNSRCN1_SerieContenedor1)
                objParam.Add("IN_CPRCN2", objEntidad.pCPRCN2_CodigoPropietarioContenedor2)
                objParam.Add("IN_NSRCN2", objEntidad.pNSRCN2_SerieContenedor2)
                objParam.Add("IN_FLLGCM", objEntidad.pFLLGCM_FechaLlegadaCamionFNum)
                objParam.Add("IN_FSLDCM", objEntidad.pFSLDCM_FechaSalidaCamionFNum)
                objParam.Add("IN_QKLMRC", objEntidad.pQKLMRC_KilometrosRecorridos)
                objParam.Add("IN_QHRSRV", objEntidad.pQHRSRV_CantidadHorasServicio)
                objParam.Add("IN_QBLRMS", objEntidad.pQBLRMS_CantidadBultosRemision)
                objParam.Add("IN_PBRTOR", objEntidad.pPBRTOR_PesoBrutoRemision)
                objParam.Add("IN_PTRAOR", objEntidad.pPTRAOR_PesoTaraRemision)
                objParam.Add("IN_QVLMOR", objEntidad.pQVLMOR_VolumenRemision)
                objParam.Add("IN_QBLRCP", objEntidad.pQBLRCP_CantidadBultosRecepcion)
                objParam.Add("IN_PBRDST", objEntidad.pPBRDST_PesoBrutoRecepcion)
                objParam.Add("IN_PTRDST", objEntidad.pPTRDST_PesoTaraRecepcion)
                objParam.Add("IN_QVLMDS", objEntidad.pQVLMDS_VolumenRecepcion)
                objParam.Add("IN_SSINVJ", objEntidad.pSSINVJ_FlagSiniestroViaje)
                objParam.Add("IN_FULTAC", Format(Now, "yyyyMMdd"))
                objParam.Add("IN_HULTAC", Format(Now, "HHmmss"))
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_MODIFICAR_GUIA_TRANSPORTISTA_PARA_LIQ", objParam)
                bResultado = True
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function
        '____ACD____

        Public Function Listar_Consistencia_Liquidacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Dim strServicio As String = ""
            Try
                objParam.Add("PNNOPRCN", objParametro("PNNOPRCN"))
                objParam.Add("PNNGUIRM", objParametro("PSNGUIRM"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
                objParam.Add("PNFECACT", objParametro("PNFECHA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_ORDEN_SERVICIOS", objParam).Rows
                    objEntidad = New Factura_Transporte

                    objEntidad.NMNFCR = objDataRow("NMNFCR")
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.CCLNFC = objDataRow("CCLNFC")
                    objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                    objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                    objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                    objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                    objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                    objEntidad.NGUITR = objDataRow("NGUITR")
                    objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                    objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.CTRSPT = objDataRow("CTRSPT")
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                    objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                    objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                    objEntidad.ISRVGU = objDataRow("ISRVGU")
                    objEntidad.QCNDTG = objDataRow("QCNDTG")
                    objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                    objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                    objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                    objEntidad.ILQDTR = objDataRow("ILQDTR")
                    objEntidad.VLRFDT = objDataRow("VLRFDT")
                    'OJO CSRVC
                    objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim 'IIf(objDataRow("TCMTRF").ToString.Trim = "FLETE", "1 " & objDataRow("TCMTRF").ToString.Trim, objDataRow("TCMTRF").ToString.Trim)

                    objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                    objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                    objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                    objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                    objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                    objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                    objEntidad.SFCTTR = objDataRow("SFCTTR")
                    objEntidad.SLQDTR = objDataRow("SLQDTR")

                    objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                    objEntidad.CPRCN1 = objDataRow("CPRCN1")
                    objEntidad.NSRCN1 = objDataRow("NSRCN1")
                    objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                    objEntidad.CPRCN2 = objDataRow("CPRCN2")
                    objEntidad.NSRCN2 = objDataRow("NSRCN2")
                    objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                    objEntidad.CTIGVA = objDataRow("CTIGVA")
                    objEntidad.PIGVA = objDataRow("PIGVA")
                    objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                    objEntidad.PESOL = objDataRow("PESOL") / 1000
                    objEntidad.QCNDLG = objDataRow("QCNDLG")
                    objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                    objEntidad.CSTNDT = objDataRow("CSTNDT")  'ACD... IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                    objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                    objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                    objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                    objEntidad.QMRCDR = objDataRow("QMRCDR")
                    objEntidad.TCMCRA = objDataRow("TCMCRA")
                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Reparto(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("PNNMOPRP", objParametro("PNNMOPRP"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
                objParam.Add("PNFECACT", objParametro("PNFECHA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_REPARTO", objParam).Rows
                    objEntidad = New Factura_Transporte

                    objEntidad.NMNFCR = objDataRow("NMNFCR")
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.CCLNFC = objDataRow("CCLNFC")
                    objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                    objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                    objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                    objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                    objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                    objEntidad.NGUITR = objDataRow("NGUITR")
                    objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                    objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.CTRSPT = objDataRow("CTRSPT")
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                    objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                    objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                    objEntidad.ISRVGU = objDataRow("ISRVGU")
                    objEntidad.QCNDTG = objDataRow("QCNDTG")
                    objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                    objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                    objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                    objEntidad.ILQDTR = objDataRow("ILQDTR")
                    objEntidad.VLRFDT = objDataRow("VLRFDT")
                    'ojo
                    objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim

                    objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                    objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                    objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                    objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                    objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                    objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                    objEntidad.SFCTTR = objDataRow("SFCTTR")
                    objEntidad.SLQDTR = objDataRow("SLQDTR")

                    objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                    objEntidad.CPRCN1 = objDataRow("CPRCN1")
                    objEntidad.NSRCN1 = objDataRow("NSRCN1")
                    objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                    objEntidad.CPRCN2 = objDataRow("CPRCN2")
                    objEntidad.NSRCN2 = objDataRow("NSRCN2")
                    objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                    objEntidad.CTIGVA = objDataRow("CTIGVA")
                    objEntidad.PIGVA = objDataRow("PIGVA")
                    objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                    objEntidad.PESOL = objDataRow("PESOL") / 1000
                    objEntidad.QCNDLG = objDataRow("QCNDLG")
                    objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                    objEntidad.CSTNDT = objDataRow("CSTNDT") 'IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                    objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                    objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                    objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                    objEntidad.QMRCDR = objDataRow("QMRCDR")
                    objEntidad.TCMCRA = objDataRow("TCMCRA")
                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Multimodal(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("PNNMOPMM", objParametro("PNNMOPMM"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
                objParam.Add("PNFECACT", objParametro("PNFECHA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_MULTIMODAL", objParam).Rows
                    objEntidad = New Factura_Transporte

                    objEntidad.NMNFCR = objDataRow("NMNFCR")
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.CCLNFC = objDataRow("CCLNFC")
                    objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                    objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                    objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                    objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                    objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                    objEntidad.NGUITR = objDataRow("NGUITR")
                    objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                    objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.CTRSPT = objDataRow("CTRSPT")
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                    objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                    objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                    objEntidad.ISRVGU = objDataRow("ISRVGU")
                    objEntidad.QCNDTG = objDataRow("QCNDTG")
                    objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                    objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                    objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                    objEntidad.ILQDTR = objDataRow("ILQDTR")
                    objEntidad.VLRFDT = objDataRow("VLRFDT")
                    'ojo
                    objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim

                    objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                    objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                    objEntidad.MONEDA_COBRAR = objDataRow("MONEDA_COBRAR")
                    objEntidad.MONEDA_PAGAR = objDataRow("MONEDA_PAGAR")

                    objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                    objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                    objEntidad.SFCTTR = objDataRow("SFCTTR")
                    objEntidad.SLQDTR = objDataRow("SLQDTR")
                    objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                    objEntidad.CPRCN1 = objDataRow("CPRCN1")
                    objEntidad.NSRCN1 = objDataRow("NSRCN1")
                    objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                    objEntidad.CPRCN2 = objDataRow("CPRCN2")
                    objEntidad.NSRCN2 = objDataRow("NSRCN2")
                    objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                    objEntidad.CTIGVA = objDataRow("CTIGVA")
                    objEntidad.PIGVA = objDataRow("PIGVA")
                    objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                    objEntidad.PESOL = objDataRow("PESOL") / 1000
                    objEntidad.QCNDLG = objDataRow("QCNDLG")
                    objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                    objEntidad.CSTNDT = objDataRow("CSTNDT") ' IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                    objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                    objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                    objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                    objEntidad.QMRCDR = objDataRow("QMRCDR")
                    objEntidad.TCMCRA = objDataRow("TCMCRA")
                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function
        '____FIN ACD____

        Public Function Existe_Guia_Remision_Anexo_Guia_Cliente(ByVal objParametro As Hashtable) As Int32
            Dim retorno As Int32 = 0
            Dim objParam As New Parameter
            Dim odt As New DataTable
            Try
                objParam.Add("PARAM_CTRMNC", objParametro("PNCTRMNC"))
                objParam.Add("PARAM_NGUIRM", objParametro("PNNGUIRM"))
                objParam.Add("PARAM_NRGUCL", objParametro("PNNRGUCL"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                odt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_GUIA_DE_REMISION_ANEXO_GUIAS_CLIENTE", objParam)
                If (odt.Rows.Count > 0) Then
                    retorno = 1
                Else
                    retorno = 0
                End If
            Catch ex As Exception
                retorno = 0
            End Try
            Return retorno
        End Function

        Public Function Listar_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("PNCTRSPT", objParametro("PNCTRSPT"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))
                objParam.Add("PNFECINI", objParametro("PNFECINI"))
                objParam.Add("PNFECFIN", objParametro("PNFECFIN"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                Select Case objParametro("ESTADO")
                    Case 0
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_NORMAL", objParam)
                    Case 1
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ENVIADO", objParam)
                    Case 2
                        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_ANULADO", objParam)
                End Select

                For Each objDataRow As DataRow In objDataTable.Rows
                    objEntidad = New LiquidacionOperacion
                    objEntidad.NLQDCN = objDataRow("NLQDCN")
                    objEntidad.FLQDCN_S = objDataRow("FLQDCN").ToString.Trim
                    objEntidad.NRFSAP = objDataRow("NRFSAP")
                    objEntidad.TSTERS = objDataRow("TSTERS").ToString.Trim
                    objEntidad.FSTTRS = objDataRow("FSTTRS").ToString.Trim
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NUMOPG = objDataRow("NUMOPG")
                    objEntidad.ILQDTR = objDataRow("ILQDTR")
                    objEntidad.ITCCTC = objDataRow("ITCCTC")
                    objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objDataRow("CPLNDV")

                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of LiquidacionOperacion)
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operacion_x_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
            Dim objEntidad As ClaseGeneral
            Dim objGenericCollection As New List(Of ClaseGeneral)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objParametro("PNCPLNDV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_X_LIQUIDACION_FLETE", objParam).Rows
                    objEntidad = New ClaseGeneral
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.FECINI = objDataRow("FINCOP").ToString.Trim
                    objEntidad.NPLNMT = objDataRow("NPLNMT")
                    objEntidad.NORINS = objDataRow("NORINS")
                    objEntidad.NGUITR = objDataRow("NMNFCR")
                    objEntidad.NGUIRM = objDataRow("NGUITR")
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.RUTA = objDataRow("ORIGEN").ToString.Trim & " <-> " & objDataRow("DESTINO").ToString.Trim
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NPLCUN = objDataRow("NPLVHT").ToString.Trim
                    objEntidad.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                    objEntidad.CBRCND = objDataRow("TNMCMC").ToString.Trim & ", " & objDataRow("APEPAT").ToString.Trim & " " & objDataRow("APEMAT").ToString.Trim
                    objEntidad.SESPLN = objDataRow("SESTOP").ToString.Trim
                    objEntidad.IMPSOL = objDataRow("IMPORTE")
                    objEntidad.CCMPN = objDataRow("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objDataRow("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objDataRow("CPLNDV")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.CCNTCS = objDataRow("CCNCST").ToString.Trim
                    objEntidad.CCNCS1 = objDataRow("CCNCS1").ToString.Trim

                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of ClaseGeneral)
            End Try
            Return objGenericCollection
        End Function

        Public Function Liquidacion_Flete_Enviar_SAP(ByVal objParametro As Hashtable) As Int64
            Dim objParam As New Parameter
            Dim lintResultado As Int64 = 0
            Try
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN").ToString.PadLeft(10, "0"))
                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP012C", objParam)
                objParam = New Parameter
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNRESULT", 0, ParameterDirection.Output)
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_LIQUIDACION_FLETE_ENVIAR_SAP", objParam)
                lintResultado = objSql.ParameterCollection("PNRESULT")
            Catch ex As Exception
                lintResultado = 0
            End Try
            Return lintResultado
        End Function

        Public Function Verificar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim lintResult As Int32 = 0

            Try
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PNRESULT", 0, ParameterDirection.InputOutput)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICAR_LIQUIDACION_FLETE_SAP", objParam)
                lintResult = objSql.ParameterCollection("PNRESULT")
            Catch ex As Exception
                lintResult = -1
            End Try
            Return lintResult
        End Function


        Public Function Lista_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Dim objParam As New Parameter
            Dim objEntidad As LiquidacionOperacion
            Dim objGenericCollection As New List(Of LiquidacionOperacion)
            Dim objDataTable As New DataTable

            Try

                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))
                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_LIQUIDACION_FLETE_SAP", objParam).Rows
                    objEntidad = New LiquidacionOperacion
                    objEntidad.NCRRRT = objDataRow("NCRRLT")
                    objEntidad.NGUITR = objDataRow("NGUITR")
                    objEntidad.CSRVC = objDataRow("CSRVC")
                    objEntidad.TABTRF = objDataRow("TABTRF").ToString.Trim
                    objEntidad.NORINS = objDataRow("NORINS")
                    objEntidad.NRFSAP = objDataRow("NRFSAP")
                    objEntidad.NENMRS = objDataRow("NENMRS")
                    objEntidad.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.FCHCRT_S = objDataRow("FCHCRT_S").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of LiquidacionOperacion)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Anular_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As String
            Dim objParam As New Parameter
            Dim lintResultado As String = ""
            Try

                objParam.Add("PARAM_NRFSAP", objParametro("NRFSAP").ToString.PadLeft(10, "0"))
                objParam.Add("PARAM_NCRROP", objParametro("NCRROP").ToString.PadLeft(4, "0"))
                objParam.Add("PARAM_FCHANU", objParametro("FCHANU").ToString.PadLeft(8, "0"))
                objParam.Add("PARAM_FSTTRS", objParametro("FSTTRS").ToString.PadLeft(1, " "), ParameterDirection.Output)

                objSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_SAP12AC", objParam)
                lintResultado = objSql.ParameterCollection("PARAM_FSTTRS").ToString.Trim

            Catch ex As Exception
                lintResultado = ""
            End Try
            Return lintResultado
        End Function

        Public Function Eliminar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim lintResultado As Int32 = 0
            Try

                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PNNRFSAP", objParametro("PNNRFSAP"))
                objParam.Add("PNNCRRLT", objParametro("PNNCRRLT"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_FLETE_SAP", objParam)
                lintResultado = 1
            Catch ex As Exception
                lintResultado = 0
            End Try
            Return lintResultado
        End Function

        Public Function Actualizar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Hashtable
            Dim objParam As New Parameter
            Dim hasResultado As New Hashtable
            Try

                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCULUSA", objParametro("PSCULUSA"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))
                objParam.Add("PNRESULT", 0, ParameterDirection.Output)
                objParam.Add("PSRESULT", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_LIQUIDACION_FLETE_SAP", objParam)
                hasResultado.Add("INTRESULT", objSql.ParameterCollection("PNRESULT"))
                hasResultado.Add("STRRESULT", objSql.ParameterCollection("PSRESULT"))
            Catch ex As Exception
                hasResultado.Add("INTRESULT", 0)
                hasResultado.Add("STRRESULT", "")
            End Try
            Return hasResultado
        End Function

        Public Function Anular_Liquidacion_Flete_Propio(ByVal objParametro As Hashtable) As Int32
            Dim objParam As New Parameter
            Dim intResultado As Int32 = 0
            Try
                objParam.Add("PSCCMPN", objParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objParametro("PSCDVSN"))
                objParam.Add("PNNLQDCN", objParametro("PNNLQDCN"))
                objParam.Add("PSCULUSA", objParametro("PSMMCUSR"))
                objParam.Add("PNFULTAC", objParametro("PNFULTAC"))
                objParam.Add("PNHULTAC", objParametro("PNHULTAC"))
                objParam.Add("PSNTRMNL", objParametro("PSNTRMNL"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("PSCCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ANULAR_LIQUIDACION_FLETE_PROPIO", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

        '------------ACD
        Public Function Lista_Bultos_x_Dia(ByVal objParametro As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCCLNT", objParametro("CCLNT"))
                objParam.Add("PSNGRPRV", objParametro("NGRPRV"))
                objParam.Add("PSCREFFW", objParametro("CREFFW"))
                objParam.Add("PNFECINI", objParametro("FECINI"))
                objParam.Add("PNFECFIN", objParametro("FECFIN"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_BULTO_1", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Function Auditoria(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Dim objParam As New Parameter
            Dim oDt As DataTable
            Try
                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)

                'ejecuta el procedimiento almacenado
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AUDITORIA_GUIA_TRANSPORTISTA", objParam)
                For Each objData As DataRow In oDt.Rows
                    objEntidad = New GuiaTransportista()
                    objEntidad.USRCRT = objData.Item("CUSCRT")
                    objEntidad.FCHCRT_S = objData.Item("FCHCRT")
                    objEntidad.HRACRT_S = objData.Item("HRACRT")
                    objEntidad.NTRMCR = objData.Item("NTRMCR")
                    objEntidad.FULTAC_S = objData.Item("FULTAC")
                    objEntidad.HULTAC_S = objData.Item("HULTAC")
                    objEntidad.CULUSA = objData.Item("CULUSA")
                    objEntidad.NTRMNL = objData.Item("NTRMNL")
                Next
            Catch ex As Exception
                Return objEntidad
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Consistencia_Bulto_x_Operacion(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of Multimodal)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRMNC", objEntidad.CTRSPT)
                objParam.Add("PNNGUITR", objEntidad.NGUITR)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CONSISTENCIA_BULTO_X_OPERACION", objParam)
            Catch
                objDataTable = New DataTable
            End Try

            Return objDataTable
        End Function

        Public Function Lista_Guia_Salida_Zona_GR(ByVal objEntidad As GuiaTransportista) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PNNGUIRM", objEntidad.NRGUCL)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIA_SALIDA_ZONA_GR", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Function Lista_Movimiento_Bulto_Zona_GP(ByVal objEntidad As GuiaTransportista) As DataTable
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PSNGRPRV", objEntidad.TOBS)
                objParam.Add("PSCCMPN", objEntidad.CCMPN)
                objParam.Add("PSCDVSN", objEntidad.CDVSN)
                objParam.Add("PNCPLNDV", objEntidad.CPLNDV)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_BULTO_ZONA_GP", objParam)
                Return objDataTable
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Function Importar_Bulto_Guia_Remision(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNCCLNT_GT", objEntidad.CCLNT)
                objParam.Add("PNCCLNT_GR", objEntidad.NRHJCR)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL)
                objParam.Add("PNNRGUSA", objEntidad.NRGUSA)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_MIGRAR_BULTO_X_GUIA_REMISION", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Guia_Remision_Actualizacion(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNCCLNT", objEntidad.CCLNT)
                objParam.Add("PNNRGUCL", objEntidad.NRGUCL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUI_REMISION_CARGO_PLAN", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Actualizar_Datos_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int16
            Dim objParam As New Parameter
            Dim intResultado As Int16 = 0
            Try
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))
                objParam.Add("PNCPLNDV", objParametro("CPLNDV"))
                objParam.Add("PNNLQDCN", objParametro("NLQDCN"))
                objParam.Add("PNFECACT", objParametro("FECACT"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_DATOS_LIQUIDACION_SAP", objParam)
                intResultado = 1
            Catch ex As Exception
                intResultado = 0
            End Try
            Return intResultado
        End Function

        Public Function Listar_Pasajeros_x_Programacion(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Viaje_Ruta)
            Dim obj_Entidad As Viaje_Ruta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCCLNT", objEntidad("CCLNT"))
                objParam.Add("PNNPRGVJ", objEntidad("NPRGVJ"))
                objParam.Add("PNFECINI", objEntidad("FECINI"))
                objParam.Add("PNFECFIN", objEntidad("FECFIN"))
                objParam.Add("PNCLCLOR", objEntidad("CLCLOR"))
                objParam.Add("PNCLCLDS", objEntidad("CLCLDS"))
                objParam.Add("PNCMEDTR", objEntidad("CMEDTR"))
                objParam.Add("PSCCMPN", objEntidad("CCMPN"))
                objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PASAJEROS_PROGRAMACION", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    obj_Entidad = New Viaje_Ruta
                    obj_Entidad.PNNPRGVJ = objData("NPRGVJ")
                    obj_Entidad.RUTA = objData("RUTA").ToString.Trim
                    obj_Entidad.PSFSLDRT = objData("FSLDRT").ToString.Trim
                    obj_Entidad.PSHSLDRT = objData("HSLDRT").ToString.Trim
                    obj_Entidad.PSNMBPER = objData("NMBPER").ToString.Trim
                    obj_Entidad.PNNCRRRT = objData("NCRRRT")
                    obj_Entidad.PNNCRRIN = objData("NCRRIN")
                    objGenericCollection.Add(obj_Entidad)
                Next
            Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Pasajeros_Guia_Transporte(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Viaje_Ruta)
            Dim obj_Entidad As Viaje_Ruta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad("CTRMNC"))
                objParam.Add("PNNGUITR", objEntidad("NGUITR"))
                objParam.Add("PSCCMPN", objEntidad("CCMPN"))
                objParam.Add("PNCPLNDV", objEntidad("CPLNDV"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PASAJEROS_GUIA_TRANSPORTE", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    obj_Entidad = New Viaje_Ruta
                    obj_Entidad.PNNPRGVJ = objData("NPRGVJ")
                    obj_Entidad.RUTA = objData("RUTA").ToString.Trim
                    obj_Entidad.PSFSLDRT = objData("FSLDRT").ToString.Trim
                    obj_Entidad.PSHSLDRT = objData("HSLDRT").ToString.Trim
                    obj_Entidad.PSNMBPER = objData("NMBPER").ToString.Trim
                    obj_Entidad.PNNGUITR = objData("NGUITR")
                    obj_Entidad.PNNCRRRT = objData("NCRRRT")
                    obj_Entidad.PNNCRRIN = objData("NCRRIN")
                    objGenericCollection.Add(obj_Entidad)
                Next
            Catch : End Try
            Return objGenericCollection
        End Function

        Public Function Registrar_Pasajero_Automatico(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Try
                Dim objParam As New Parameter
                objParam.Add("PNNPRGVJ", objEntidad.PNNPRGVJ)
                objParam.Add("PNNCRRRT", objEntidad.PNNCRRRT)
                objParam.Add("PNNCRRIN", objEntidad.PNNCRRIN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNFULTAC", objEntidad.PNFULTAC)
                objParam.Add("PNHULTAC", objEntidad.PNHULTAC)
                objParam.Add("PSCULUSA", objEntidad.PSCULUSA)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_REGISTRAR_PASAJERO_GUIA_TRANSPORTE", objParam)

            Catch ex As Exception
                objEntidad.PNNPRGVJ = 0
            End Try
            Return objEntidad
        End Function

        Public Function Eliminar_Pasajero_Guia_Transporte(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Try
                Dim objParam As New Parameter

                objParam.Add("PNNPRGVJ", objEntidad.PNNPRGVJ)
                objParam.Add("PNNCRRRT", objEntidad.PNNCRRRT)
                objParam.Add("PNNCRRIN", objEntidad.PNNCRRIN)
                objParam.Add("PNCTRMNC", objEntidad.PNCTRMNC)
                objParam.Add("PNNGUITR", objEntidad.PNNGUITR)
                objParam.Add("PNFULTAC", objEntidad.PNFULTAC)
                objParam.Add("PNHULTAC", objEntidad.PNHULTAC)
                objParam.Add("PSCULUSA", objEntidad.PSCULUSA)
                objParam.Add("PSNTRMNL", objEntidad.PSNTRMNL)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.PSCCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_PASAJERO_GUIA_TRANSPORTE", objParam)

            Catch ex As Exception
                objEntidad.PNNPRGVJ = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Guia_Transportista_Mercaderia(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            Try

                objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
                objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
                objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
                objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_MERCADERIA", objParam)

                'Select Case objetoParametro("ESTADO")
                '  Case 0
                '    objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V2", objParam)
                '  Case 1
                '    objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V1", objParam)
                '  Case 2
                '    objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V3", objParam)
                '  Case 3
                '    objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V4", objParam)
                'End Select

                For Each objData As DataRow In objDataTable.Rows
                    objEntidad = New GuiaTransportista

                    objEntidad.CHECK = True
                    objEntidad.CTRMNC = objData("CTRMNC")
                    objEntidad.NGUIRM = objData("NGUIRM")
                    objEntidad.FGUIRM_S = objData("FGUIRM")
                    objEntidad.NPLNMT = objData("NPLNMT")
                    objEntidad.CLCLOR = objData("CLCLOR")
                    objEntidad.CLCLDS = objData("CLCLDS")
                    objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                    objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                    objEntidad.NOPRCN = objData("NOPRCN")
                    objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                    objEntidad.QMRCMC = objData("QMRCMC")
                    objEntidad.PMRCMC = objData("PMRCMC")
                    objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                    objEntidad.QGLGSL = objData("QGLGSL")
                    objEntidad.QGLDSL = objData("QGLDSL")
                    objEntidad.NRHJCR = objData("NRHJCR")
                    objEntidad.CTRSPT = objData("CTRSPT")
                    objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                    objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                    objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                    objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                    objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                    objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                    objEntidad.NRUCRM = objData("NRUCRM")
                    objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                    objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                    objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                    objEntidad.NRUCCN = objData("NRUCCN")
                    objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                    objEntidad.CMNFLT = objData("CMNFLT")
                    objEntidad.SESTRG = objData("SESTRG").ToString.Trim
                    objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                    objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                    objEntidad.QKMREC = objData("QKMREC")
                    objEntidad.ICSTRM = objData("ICSTRM")
                    objEntidad.QPSOBR = objData("QPSOBR")
                    objEntidad.QVLMOR = objData("QVLMOR")
                    objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                    objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                    objEntidad.IVLPRT = objData("IVLPRT")
                    objEntidad.CMNVLP = objData("CMNVLP")
                    objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objData("CPLNDV")
                    objEntidad.CUBORI = objData("CUBORI")
                    objEntidad.CUBDES = objData("CUBDES")
                    objEntidad.FEMVLH = objData("FEMVLH")
                    objEntidad.FEMVLH_S = objData("FEMVLH_S")
                    objEntidad.FCHFTR_S = objData("FCHFTR_S")
                    objEntidad.FECETA_S = objData("FECETA_S")
                    objEntidad.FECETD_S = objData("FECETD_S")
                    objEntidad.RUTA = objData("RUTA").ToString.Trim
                    objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                    objEntidad.TOBS = objData("TOBS").ToString.Trim
                    'EN MODIFICACION
                    objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                    objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                    objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                    objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

                    objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                    objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                    objEntidad.CMRCDR = objData("CMRCDR")
                    objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                    objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                    objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                    objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
                    objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                    Select Case objData("CTPOVJ").ToString.Trim
                        Case "E"
                            objEntidad.CTPOV2 = "EXCLUSIVO"
                        Case "R"
                            objEntidad.CTPOV2 = "REPARTO"
                        Case "M"
                            objEntidad.CTPOV2 = "MULTIMODAL"
                        Case "C"
                            objEntidad.CTPOV2 = "CONSOLIDADO"
                    End Select
                    'objEntidad.CTPOVJ = IIf(objData("CTPOVJ").ToString.Trim = "C", "CONSOLIDADO", "NORMAL")
                    objEntidad.NMRGIM = objData("NMRGIM")

                    objEntidad.NMOPMM = objData("NMOPMM")
                    objEntidad.NMOPRP = objData("NMOPRP")
                    objEntidad.NMVJCS = objData("NMVJCS")
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Dim s As String = ""
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Guia_Transportista_Pasajero(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            Try

                objParam.Add("PNCTRMNC", objetoParametro("PNCTRMNC"))
                objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))
                objParam.Add("PNFECINI", objetoParametro("PNFECINI"))
                objParam.Add("PNFECFIN", objetoParametro("PNFECFIN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_PASAJERO", objParam)

                'Select Case objetoParametro("ESTADO")
                '  Case 0
                '    objParam.Add("PNNGUITR", objetoParametro("PNNGUITR"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V2", objParam)
                '  Case 1
                '    objParam.Add("PNNOPRCN", objetoParametro("PNNOPRCN"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V1", objParam)
                '  Case 2
                '    objParam.Add("PNNMOPRP", objetoParametro("PNNMOPRP"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V3", objParam)
                '  Case 3
                '    objParam.Add("PNNMOPMM", objetoParametro("PNNMOPMM"))
                '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_V4", objParam)
                'End Select

                For Each objData As DataRow In objDataTable.Rows
                    objEntidad = New GuiaTransportista

                    objEntidad.CHECK = True
                    objEntidad.CTRMNC = objData("CTRMNC")
                    objEntidad.NGUIRM = objData("NGUIRM")
                    objEntidad.FGUIRM_S = objData("FGUIRM")
                    objEntidad.NPLNMT = objData("NPLNMT")
                    objEntidad.CLCLOR = objData("CLCLOR")
                    objEntidad.CLCLDS = objData("CLCLDS")
                    objEntidad.TDIROR = objData("TDIROR").ToString.Trim
                    objEntidad.TDIRDS = objData("TDIRDS").ToString.Trim
                    objEntidad.NOPRCN = objData("NOPRCN")
                    objEntidad.TRFRGU = objData("TRFRGU").ToString.Trim
                    objEntidad.QMRCMC = objData("QMRCMC")
                    objEntidad.PMRCMC = objData("PMRCMC")
                    objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                    objEntidad.QGLGSL = objData("QGLGSL")
                    objEntidad.QGLDSL = objData("QGLDSL")
                    objEntidad.NRHJCR = objData("NRHJCR")
                    objEntidad.CTRSPT = objData("CTRSPT")
                    objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                    objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                    objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                    objEntidad.TNMBRM = objData("TNMBRM").ToString.Trim
                    objEntidad.TDRCRM = objData("TDRCRM").ToString.Trim
                    objEntidad.TPDCIR = objData("TPDCIR").ToString.Trim
                    objEntidad.NRUCRM = objData("NRUCRM")
                    objEntidad.TNMBCN = objData("TNMBCN").ToString.Trim
                    objEntidad.TDRCNS = objData("TDRCNS").ToString.Trim
                    objEntidad.TPDCIC = objData("TPDCIC").ToString.Trim
                    objEntidad.NRUCCN = objData("NRUCCN")
                    objEntidad.SACRGO = objData("SACRGO").ToString.Trim
                    objEntidad.CMNFLT = objData("CMNFLT")
                    objEntidad.SESTRG = objData("SESTRG").ToString.Trim
                    objEntidad.FLGADC = objData("FLGADC").ToString.Trim
                    objEntidad.SIDAVL = objData("SIDAVL").ToString.Trim
                    objEntidad.QKMREC = objData("QKMREC")
                    objEntidad.ICSTRM = objData("ICSTRM")
                    objEntidad.QPSOBR = objData("QPSOBR")
                    objEntidad.QVLMOR = objData("QVLMOR")
                    objEntidad.SMRPLG = objData("SMRPLG").ToString.Trim
                    objEntidad.SMRPRC = objData("SMRPRC").ToString.Trim
                    objEntidad.IVLPRT = objData("IVLPRT")
                    objEntidad.CMNVLP = objData("CMNVLP")
                    objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objData("CPLNDV")
                    objEntidad.CUBORI = objData("CUBORI")
                    objEntidad.CUBDES = objData("CUBDES")
                    objEntidad.FEMVLH = objData("FEMVLH")
                    objEntidad.FEMVLH_S = objData("FEMVLH_S")
                    objEntidad.FCHFTR_S = objData("FCHFTR_S")
                    objEntidad.FECETA_S = objData("FECETA_S")
                    objEntidad.FECETD_S = objData("FECETD_S")
                    objEntidad.RUTA = objData("RUTA").ToString.Trim
                    objEntidad.CBRCND = objData("CBRCND").ToString.Trim
                    objEntidad.TOBS = objData("TOBS").ToString.Trim
                    'EN MODIFICACION
                    objEntidad.TCNFVH = objData("TCNFVH").ToString.Trim
                    objEntidad.TCNFG1 = objData("TCNFG1").ToString.Trim
                    objEntidad.TCNFG2 = objData("TCNFG2").ToString.Trim
                    objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim

                    objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                    objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                    objEntidad.CMRCDR = objData("CMRCDR")
                    objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim

                    objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                    objEntidad.NORSRT = objData("NORSRT").ToString.Trim
                    objEntidad.TCMPCL = objData("TCMPCL").ToString.Trim
                    objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                    objEntidad.CMEDTR = objData("CMEDTR").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Dim s As String = ""
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_Liquidacion_Correo(ByVal objetoParametro As Hashtable) As DataTable
            Dim objDataTable As DataTable
            Dim objParam As New Parameter
            Try
                objDataTable = New DataTable
                objParam.Add("PNNLQDCN", objetoParametro("PNNLQDCN"))
                objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACION_LIQUIDACION_CORREO", objParam)
            Catch ex As Exception
                objDataTable = New DataTable
            End Try
            Return objDataTable
        End Function

        Public Function Actualizar_Operaciones_Guia_Transporte(ByVal objetoParametro As Hashtable) As Int16

            Dim objParam As New Parameter
            Try
                objParam.Add("PNCTRSPT", objetoParametro("CTRSPT"))
                objParam.Add("PNNGUIRM", objetoParametro("NGUIRM"))
                objParam.Add("PNFGUIRM", objetoParametro("FGUIRM"))
                objParam.Add("PSNOPRCN", objetoParametro("NOPRCN"))
                objParam.Add("PSCCMPN", objetoParametro("CCMPN"))
                objParam.Add("PSCULUSA", objetoParametro("CULUSA"))
                objParam.Add("PNFULTAC", objetoParametro("FULTAC"))
                objParam.Add("PNHULTAC", objetoParametro("HULTAC"))
                objParam.Add("PSNTRMNL", objetoParametro("NTRMNL"))
                objParam.Add("PSSESTRG", objetoParametro("SESTRG"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_OPERACION_GUIA_TRANSPORTE", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function Listar_Operaciones_Guia_Transporte(ByVal objetoParametro As Hashtable, ByRef intTipoViaje As Int16) As DataTable
            Dim objDataTable As DataTable
            Dim objParam As New Parameter
            Dim strTipoViaje As String = ""
            Try
                objParam.Add("PNCTRSPT", objetoParametro("CTRMNC"))
                objParam.Add("PNNGUIRM", objetoParametro("NGUITR"))
                objParam.Add("PSTPOVJ", 0, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_OPERACIONES_GUIA_TRANSPORTE", objParam)
                strTipoViaje = objSql.ParameterCollection("PSTPOVJ")
                intTipoViaje = IIf(strTipoViaje = "N", 0, 1)
            Catch ex As Exception
                objDataTable = New DataTable
            End Try
            Return objDataTable
        End Function

        Public Function Validar_Operacion_Guia_Remision(ByVal objetoParametro As Hashtable, ByRef intCMRCDR As Integer, ByRef strTCMRCD As String) As Int16
            Dim objParam As New Parameter
            Dim intTipoViaje As Int16 = 0
            Try
                objParam.Add("PNNOPRCN", objetoParametro("NOPRCN"))
                objParam.Add("PNNGUIRM", objetoParametro("NGUIRM"))
                objParam.Add("PNCMRCDR", 0, ParameterDirection.Output)
                objParam.Add("PSTCMRCD", "", ParameterDirection.Output)
                objParam.Add("PNSTATUS", 0, ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDAR_OPERACION_GUIA_REMISION", objParam)
                intTipoViaje = objSql.ParameterCollection("PNSTATUS")
                intCMRCDR = objSql.ParameterCollection("PNCMRCDR")
                strTCMRCD = objSql.ParameterCollection("PSTCMRCD").ToString.Trim
            Catch ex As Exception
                intTipoViaje = 0
            End Try
            Return intTipoViaje
        End Function
        Public Function Actualizar_Guia_Numero_Imagen(ByVal objHash As Hashtable) As Boolean
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION
                objParam.Add("PNCTRMNC", objHash("PARAM_CTRMNC"))
                objParam.Add("PNNGUIRM", objHash("PARAM_NGUIRM"))
                objParam.Add("PNNMRGIM", objHash("PARAM_NMRGIM"))
                objParam.Add("PSCULUSA", objHash("PARAM_CULUSA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_GUIA_NUMERO_IMAGEN", objParam)

            Catch ex As Exception
                Return False

            End Try
            Return True
        End Function

        Public Function Eliminar_Correlativo_Imagen(ByVal objHash As Hashtable) As Boolean
            Try
                Dim objParam As New Parameter
                '-- SE MODIFICO, SE AGREGO OPERACION                
                objParam.Add("PNNMRGIM", objHash("PARAM_NMRGIM"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("PARAM_CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CORRELATIVO_IMAGEN", objParam)

            Catch ex As Exception
                Return False

            End Try
            Return True
        End Function

        Public Function Lista_Guia_Transporte_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objEntidad As GuiaTransportista
            Try
                objParam.Add("PNNMVJCS", objetoParametro("PNNMVJCS"))
                objParam.Add("PSCCMPN", objetoParametro("PSCCMPN"))
                objParam.Add("PSCDVSN", objetoParametro("PSCDVSN"))
                objParam.Add("PNCPLNDV", objetoParametro("PNCPLNDV"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("PSCCMPN"))

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GUIAS_TRANSPORTISTA_CONSOLIDADO", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    objEntidad = New GuiaTransportista
                    objEntidad.CTRMNC = objData("CTRMNC")
                    objEntidad.NGUIRM = objData("NGUIRM")
                    objEntidad.FGUIRM_S = Validacion.CFecha_a_Numero10Digitos(objData("FGUIRM"))
                    objEntidad.NPLNMT = objData("NPLNMT")
                    objEntidad.CLCLOR = objData("CLCLOR")
                    objEntidad.CLCLDS = objData("CLCLDS")
                    objEntidad.TCMLCO = objData("TCMLCO").ToString.Trim
                    objEntidad.TCMLCD = objData("TCMLCD").ToString.Trim
                    objEntidad.NOPRCN = objData("NOPRCN")
                    objEntidad.QMRCMC = objData("QMRCMC")
                    objEntidad.PMRCMC = objData("PMRCMC")
                    objEntidad.CUNDMD = objData("CUNDMD").ToString.Trim
                    objEntidad.QGLGSL = objData("QGLGSL")
                    objEntidad.QGLDSL = objData("QGLDSL")
                    objEntidad.NRHJCR = objData("NRHJCR")
                    objEntidad.CTRSPT = objData("CTRMNC")
                    objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                    objEntidad.NPLCAC = objData("NPLCAC").ToString.Trim
                    objEntidad.CBRCNT = objData("CBRCNT").ToString.Trim
                    objEntidad.QKMREC = objData("QKMREC")
                    objEntidad.QPSOBR = objData("QPSOBR")
                    objEntidad.QVLMOR = objData("QVLMOR")
                    objEntidad.CCMPN = objData("CCMPN").ToString.Trim
                    objEntidad.CDVSN = objData("CDVSN").ToString.Trim
                    objEntidad.CPLNDV = objData("CPLNDV")
                    objEntidad.CCLNT = objData("CCLNT")
                    objEntidad.TCMTRT = objData("TCMTRT").ToString.Trim
                    objEntidad.CMRCDR = objData("CMRCDR")
                    objEntidad.TCMRCD = objData("TCMRCD").ToString.Trim
                    objEntidad.SESGRP = objData("SESGRP").ToString.Trim
                    objEntidad.NOREMB = objData("NOREMB").ToString.Trim
                    objEntidad.SSINVJ = objData("SSINVJ").ToString.Trim
                    objGenericCollection.Add(objEntidad)
                Next
            Catch ex As Exception
                Dim s As String = ""
            End Try
            Return objGenericCollection
        End Function
        '------PENDIENTE
        Public Function Listar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of TD_Obj_GRemCargadasGTranspLiq)
            Dim obj_Entidad As TD_Obj_GRemCargadasGTranspLiq
            Dim sErrorMessage As String = ""
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GREMISION_GUIA_TRANSPORTE_PARA_LIQ_CONSOLIDADO", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    obj_Entidad = New TD_Obj_GRemCargadasGTranspLiq

                    obj_Entidad.pNOPRCN_NroOperacion = objData("NOPRCN")
                    obj_Entidad.pNGUIRM_NroGuiaTransportista = objData("NGUIRM") 'objEntidad.pNGUIRM_NroGuiaTransportista
                    obj_Entidad.pNGUITR_GuiaRemisionCargada = objData("NGUITR")
                    obj_Entidad.pFGUITR_FechaGuiaRemision = objData("FGUITR")
                    obj_Entidad.pCTRSPT_Transportista = objData("CTRSPT")
                    obj_Entidad.pTCMTRT_RazSocialTransportista = ("" & objData("TCMTRT")).ToString.Trim
                    obj_Entidad.pNPLVHT_Tracto = ("" & objData("NPLVHT")).ToString.Trim
                    obj_Entidad.pCBRCNT_Brevete = ("" & objData("CBRCNT")).ToString.Trim
                    obj_Entidad.pTNMCMC_NomApeChofer = ("" & objData("TNMCMC")).ToString.Trim
                    Decimal.TryParse(("" & objData("QCNDTG")), obj_Entidad.pQCNDTG_CantServicioGuia)
                    obj_Entidad.pCUNDSR_Unidad = ("" & objData("CUNDSR")).ToString.Trim
                    obj_Entidad.pNLQDCN_NroLiquidacion = objData("NLQDCN")
                    obj_Entidad.pSGUIFC_StatusFacturado = ("" & objData("SGUIFC")).ToString.Trim
                    obj_Entidad.pPSOVOL_PesoVolumen = Format(objData("PSOVOL"), "###,###.00")
                    obj_Entidad.pPMRCMC_PesoNeto = Format(objData("PMRCMC"), "###,###.00")
                    obj_Entidad.pPBRTOR_PesoBruto = Format(objData("PBRTOR"), "###,###.00")
                    objGenericCollection.Add(obj_Entidad)
                Next
            Catch ex As Exception
                sErrorMessage = ex.ToString
            End Try
            Return objGenericCollection
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal oFiltro As TransporteConsolidado, ByRef sErrorMensaje As String) As Boolean
            Dim bResultado As Boolean = True
            sErrorMensaje = ""
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CCMPN", oFiltro.CCMPN)
                objParam.Add("IN_NMVJCS", oFiltro.NMVJCS)
                objParam.Add("IN_MMCUSR", oFiltro.CUSCTR)
                objParam.Add("IN_NTRMNL", oFiltro.NTRMNL)
                objParam.Add("OU_ERRMSG", "", ParameterDirection.InputOutput)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(oFiltro.CCMPN)

                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_GREMISION_CARGADAS_PARA_LIQ_CONSOLIDADO", objParam)

                sErrorMensaje = ("" & objSql.ParameterCollection("OU_ERRMSG"))
                If sErrorMensaje <> "" Then bResultado = False
            Catch ex As Exception
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Consolidado(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objParam As New Parameter
            Dim objDataTable As New DataTable
            Try
                objParam.Add("IN_NMVJCS", objParametro("NMVJCS"))
                objParam.Add("IN_CCMPN", objParametro("CCMPN"))
                objParam.Add("IN_CDVSN", objParametro("CDVSN"))
                objParam.Add("IN_CPLNDV", objParametro("CPLNDV"))
                objParam.Add("IN_FECACT", objParametro("FECHA"))

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))

                For Each objDataRow As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_CONSISTENCIA_LIQUIDACION_SERVICIOS_CONSOLIDADO", objParam).Rows
                    objEntidad = New Factura_Transporte

                    objEntidad.NMNFCR = objDataRow("NMNFCR")
                    objEntidad.NOPRCN = objDataRow("NOPRCN")
                    objEntidad.NORSRT = objDataRow("NORSRT")
                    objEntidad.CCLNT = objDataRow("CCLNT")
                    objEntidad.TCMPCL = objDataRow("TCMPCL").ToString.Trim
                    objEntidad.CCLNFC = objDataRow("CCLNFC")
                    objEntidad.TCMPFC = objDataRow("TCMPFC").ToString.Trim
                    objEntidad.TDRCFC = objDataRow("TDRCFC").ToString.Trim
                    objEntidad.NRUCFC = IIf(objDataRow("NRUCFC") = 0, objDataRow("NLBTEL"), objDataRow("NRUCFC"))
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.TCMRCD = objDataRow("TCMRCD").ToString.Trim
                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.TCMTPS = objDataRow("TCMTPS").ToString.Trim
                    objEntidad.CTPSBS = objDataRow("CTPSBS").ToString.Trim
                    objEntidad.TCMSBS = objDataRow("TCMSBS").ToString.Trim
                    objEntidad.NGUITR = objDataRow("NGUITR")
                    objEntidad.FGUITR_S = objDataRow("FGUITR").ToString.Trim
                    objEntidad.SRPTRM = objDataRow("SRPTRM").ToString.Trim
                    objEntidad.RUTA = objDataRow("RUTA").ToString.Trim
                    objEntidad.CTRSPT = objDataRow("CTRSPT")
                    objEntidad.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                    objEntidad.NPLVHT = objDataRow("NPLVHT").ToString.Trim
                    objEntidad.CMNDGU = objDataRow("CMNDGU").ToString.Trim
                    objEntidad.TSGNMN_S = objDataRow("TSGNMN_S").ToString.Trim
                    objEntidad.ISRVGU = objDataRow("ISRVGU")
                    objEntidad.QCNDTG = objDataRow("QCNDTG")
                    objEntidad.CUNDSR = objDataRow("CUNDSR").ToString.Trim
                    objEntidad.CMNLQT = objDataRow("CMNLQT").ToString.Trim
                    objEntidad.TSGNMN_L = objDataRow("TSGNMN_L").ToString.Trim
                    objEntidad.ILQDTR = objDataRow("ILQDTR")
                    objEntidad.VLRFDT = objDataRow("VLRFDT")
                    'ojo
                    objEntidad.TCMTRF = objDataRow("TCMTRF").ToString.Trim
                    objEntidad.IVNTA = objDataRow("IVNTA")
                    objEntidad.PBRTOR = objDataRow("PBRTOR") / 1000
                    objEntidad.CPRCN1 = objDataRow("CPRCN1")
                    objEntidad.NSRCN1 = objDataRow("NSRCN1")
                    objEntidad.TMNCNT = IIf(objDataRow("TMNCNT") = 0, "", objDataRow("TMNCNT"))
                    objEntidad.CPRCN2 = objDataRow("CPRCN2")
                    objEntidad.NSRCN2 = objDataRow("NSRCN2")
                    objEntidad.TMNCN1 = IIf(objDataRow("TMNCN1") = 0, "", objDataRow("TMNCN1"))
                    objEntidad.CTIGVA = objDataRow("CTIGVA")
                    objEntidad.PIGVA = objDataRow("PIGVA")
                    objEntidad.INDICE = objEntidad.TCMTRF & objEntidad.CUNDSR

                    objEntidad.PESOL = objDataRow("PESOL") / 1000
                    objEntidad.QCNDLG = objDataRow("QCNDLG")
                    objEntidad.CUNDTR = objDataRow("CUNDTR").ToString.Trim
                    objEntidad.CSTNDT = objDataRow("CSTNDT") 'IIf(objEntidad.PESOL > 0, (objEntidad.VLRFDT / objEntidad.PESOL), 0) 'objDataRow("CSTNDT")
                    objEntidad.TCNFVH = objDataRow("TCNFVH").ToString.Trim
                    objEntidad.PBRDST = objDataRow("PBRDST") / 1000
                    objEntidad.PMRCDR = objDataRow("PMRCDR") / 1000
                    objEntidad.QMRCDR = objDataRow("QMRCDR")
                    objEntidad.TCMCRA = objDataRow("TCMCRA")
                    ' NUEVO
                    '-------------------------------
                    objEntidad.CMNDA_COBRAR = objDataRow("CMNDA_COBRAR")
                    objEntidad.CMNDA_PAGAR = objDataRow("CMNDA_PAGAR")
                    objEntidad.TC_COBRAR = objDataRow("TC_COBRAR")
                    objEntidad.TC_PAGAR = objDataRow("TC_PAGAR")
                    '-------------------------------
                    objGenericCollection.Add(objEntidad)
                Next

            Catch ex As Exception
                objGenericCollection = New List(Of Factura_Transporte)()
            End Try
            Return objGenericCollection
        End Function

        Public Function Listar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable) As DataTable
            Dim objParam As New Parameter
            Dim dtOperaciones As DataTable
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                dtOperaciones = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACIONES_X_SERV_IMPORTES", objParam)
            Catch ex As Exception
                dtOperaciones = New DataTable
            End Try
            Return dtOperaciones
        End Function

        Public Function Actualizar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable)
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNOPRCN", objParametro("NOPRCN"))
                'objParam.Add("PNCMNDGU", objParametro("CMNDGU"))
                objParam.Add("PNISRVGU", objParametro("ISRVGU"))
                'objParam.Add("PNCMNLQT", objParametro("CMNLQT"))
                objParam.Add("PNILQDTR", objParametro("ILQDTR"))
                objParam.Add("PSCCMPN", objParametro("CCMPN"))
                objParam.Add("PSCDVSN", objParametro("CDVSN"))


                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametro("CCMPN"))
                objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_OPERACIONES_X_SERV_IMPORTES", objParam)
            Catch ex As Exception
            End Try
        End Function

        Public Function Eliminar_Guia_Transportista_Reparto(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Try
                Dim objParam As New Parameter

                objParam.Add("PNCTRMNC", objEntidad.CTRMNC)
                objParam.Add("PNNGUIRM", objEntidad.NGUIRM)
                objParam.Add("PNNOPRCN", objEntidad.NOPRCN)
                objParam.Add("PSCULUSA", objEntidad.CULUSA)
                objParam.Add("PNFULTAC", objEntidad.FULTAC)
                objParam.Add("PNHULTAC", objEntidad.HULTAC)
                objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
                objParam.Add("PSSESTRG", objEntidad.SESTRG)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
                objSql.ExecuteNoQuery("SP_SOLMIN_ST_ELIMINAR_GUIA_TRANSPORTISTA_REPARTO", objParam)

            Catch ex As Exception
                objEntidad.CTRMNC = 0
            End Try
            Return objEntidad
        End Function

        Public Function Listar_Ruta_Optima_Reparto(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of GuiaTransportista)
            Dim objGuiaTransportista As GuiaTransportista
            Dim objParam As New Parameter
            Try
                objParam.Add("PNNMOPRP", objEntidad.NMOPRP)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_RUTA_OPTIMA_X_OPERACION_REPARTO", objParam)

                For Each objData As DataRow In objDataTable.Rows
                    objGuiaTransportista = New GuiaTransportista
                    objGuiaTransportista.NMOPRP = objData("NMOPRP")
                    objGuiaTransportista.ITEMAN = objData("NMOPRP")
                    objGuiaTransportista.CTRSPT = objData("CTRSPT")
                    'objGuiaTransportista.NRHJCR = objData("NRHJCR")
                    objGuiaTransportista.TDIROR = objData("TDIROR")
                    objGuiaTransportista.TDIRDS = objData("TDIRDS")
                    objGuiaTransportista.TCMRCD = objData("TCMRCD")
                    objGuiaTransportista.QKMREC = objData("QKMREC")
                    objGuiaTransportista.CBRCNT = objData("CBRCNT")
                    objGuiaTransportista.CBRCND = objData("CBRCND")
                    objGuiaTransportista.SESGRP = objData("SESGRP")
                    objGuiaTransportista.CLCLOR = objData("CLCLOR")
                    objGuiaTransportista.CLCLDS = objData("CLCLDS")
                    objGuiaTransportista.NOPRCN = objData("NOPRCN")
                    objGuiaTransportista.CMRCDR = objData("CMRCDR")
                    objGenericCollection.Add(objGuiaTransportista)
                Next
            Catch ex As Exception
                Dim s As String = ""
            End Try
            Return objGenericCollection
        End Function

        Public Function Validar_GuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NOPRCN", objEntidad.pNOPRCN_NroOperacion)
                objParam.Add("IN_NGUIRM", objEntidad.pNGUIRM_NroGuiaTransportista)
                objParam.Add("IN_FTRMOP", objEntidad.pFTRMOP_FechaOperacionFNum)
                objParam.Add("IN_MMCUSR", objEntidad.pMMCUSR_Usuario)
                objParam.Add("IN_NTRMNL", objEntidad.pNTRMNL_Terminal)
                objParam.Add("IN_TIPO", objEntidad.pTipo)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.pCCMPN_Compania)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("IN_TIPO", objEntidad.TIPO)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_REPARTO", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete(ByVal objEntidad As Repartos) As Int32
            Dim bResultado As Int32 = 0 'As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMOPRP", objEntidad.NMOPRP)
                objParam.Add("IN_FTRMOP", objEntidad.FECREP)
                objParam.Add("IN_MMCUSR", objEntidad.CUSCRT)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                'objParam.Add("OU_MSGERR", "", ParameterDirection.Output)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_PROCESAR_LIQUIDACION_GUIA_TRANSP_REPARTO2", objParam)
                'sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                'If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                'sErrorMesage = ex.Message
                'bResultado = False
                bResultado = 1
            End Try
            Return bResultado
        End Function

        Public Function Validar_GuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Dim bResultado As Boolean = True
            Try
                Dim objParam As New Parameter

                objParam.Add("IN_NMVJCS", objEntidad.NMVJCS)
                objParam.Add("IN_FTRMOP", objEntidad.FCHVJC) 'IN_FCHVJC
                objParam.Add("IN_MMCUSR", objEntidad.CUSCTR)
                objParam.Add("IN_NTRMNL", objEntidad.NTRMNL)
                objParam.Add("IN_CCMPN", objEntidad.CCMPN)
                objParam.Add("IN_CDVSN", objEntidad.CDVSN)
                objParam.Add("IN_CPLNDV", objEntidad.CPLNDV)
                objParam.Add("IN_TIPO", objEntidad.TIPO)
                objParam.Add("OU_MSGERR", "", ParameterDirection.Output)
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

                objSql.ExecuteNoQuery("SP_SOLMIN_ST_VALIDAR_GUIA_TRANSP_CONSOLIDADO", objParam)
                sErrorMesage = "" & objSql.ParameterCollection("OU_MSGERR")
                If sErrorMesage <> "" Then bResultado = False
            Catch ex As Exception
                sErrorMesage = ex.Message
                bResultado = False
            End Try
            Return bResultado
        End Function

    End Class
End Namespace
