Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class Acceso_Opciones_Usuario_DAL
  Private objSql As New SqlManager

  Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As ClaseGeneral
    Dim objParam As New Parameter
    Dim oDt As New DataTable
    Dim objEntidad As New ClaseGeneral
    Try
      objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
      objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
            objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))
            '  objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
      oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_ACCESO_OPCIONES_USUARIO", objParam)
      For Each objDataRow As DataRow In oDt.Rows
        objEntidad.STSVIS = objDataRow("STSVIS").ToString.Trim()
        objEntidad.STSADI = objDataRow("STSADI").ToString.Trim()
        objEntidad.STSCHG = objDataRow("STSCHG").ToString.Trim()
        objEntidad.STSELI = objDataRow("STSELI").ToString.Trim()
        objEntidad.STSOP1 = objDataRow("STSOP1").ToString.Trim()
        objEntidad.STSOP2 = objDataRow("STSOP2").ToString.Trim()
        objEntidad.STSOP3 = objDataRow("STSOP3").ToString.Trim()
      Next
      Return objEntidad
    Catch ex As Exception
      Return objEntidad
    End Try
  End Function

  Public Function Nombre_Usuario(ByVal objetoParametro As Hashtable) As String
    Dim objParam As New Parameter
    Dim oDt As New DataTable
    Dim objResult As String = ""
    Try
      objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
      objParam.Add("PSMMNUSR", "", ParameterDirection.Output)
      '  objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objetoParametro("CCMPN"))
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_OBTENER_NOMBRE_USUARIO", objParam)
      objResult = objSql.ParameterCollection("PSMMNUSR").ToString.Trim
    Catch ex As Exception
      objResult = ""
    End Try
    Return objResult
    End Function


    Public Function Listar_Autorizacion_Usuario(ByVal objetoParametro As Hashtable) As DataTable
        Dim objParam As New Parameter
        Dim oDS As New DataSet
        Dim oDt As New DataTable
        'Dim objEntidad As beAutorizacion
        Dim oList As New List(Of beAutorizacion)


        objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
        objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
        objParam.Add("PSMMNPVB", objetoParametro("MMNPVB"))

        oDS = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_AUTORIZACION_USUARIO", objParam)

        Dim dt As New DataTable
        Dim dr As DataRow
        dt = oDS.Tables(1).Copy
        'dr = dt.NewRow
        'dr("COD_ACCION") = ""
        'dr("ACCION") = ""
        'dt.Rows.Add(dr)


        For Each objDataRow As DataRow In oDS.Tables(0).Rows

            If objDataRow("STSVIS") = "X" Then
                'objEntidad = New beAutorizacion
                'objEntidad.COD_ACCION = "V"
                'objEntidad.ACCION = "VISUALIZAR"
                'oList.Add(objEntidad)
                dr = dt.NewRow
                dr("COD_ACCION") = "V"
                dr("ACCION") = "VISUALIZAR"
                dt.Rows.Add(dr)
            End If
            If objDataRow("STSADI") = "X" Then
                'objEntidad = New beAutorizacion
                'objEntidad.COD_ACCION = "A"
                'objEntidad.ACCION = "ADICIONAR"
                'oList.Add(objEntidad)
                dr = dt.NewRow
                dr("COD_ACCION") = "A"
                dr("ACCION") = "ADICIONAR"
                dt.Rows.Add(dr)
            End If

            If objDataRow("STSCHG") = "X" Then
                'objEntidad = New beAutorizacion
                'objEntidad.COD_ACCION = "M"
                'objEntidad.ACCION = "MODIFICAR"
                'oList.Add(objEntidad)
                dr = dt.NewRow
                dr("COD_ACCION") = "M"
                dr("ACCION") = "MODIFICAR"
                dt.Rows.Add(dr)
            End If

            If objDataRow("STSELI") = "X" Then
                'objEntidad = New beAutorizacion
                'objEntidad.COD_ACCION = "E"
                'objEntidad.ACCION = "ELIMINAR"
                'oList.Add(objEntidad)
                dr = dt.NewRow
                dr("COD_ACCION") = "E"
                dr("ACCION") = "ELIMINAR"
                dt.Rows.Add(dr)
            End If
        Next
        'For Each objDataRow As DataRow In oDS.Tables(1).Rows
        '    objEntidad = New beAutorizacion
        '    objEntidad.COD_ACCION = objDataRow("COD_ACCION")
        '    objEntidad.ACCION = objDataRow("ACCION")
        '    oList.Add(objEntidad)
        'Next
        Return dt

    End Function


    Public Function Listar_Autorizacion_Usuario_X_NroOPC(ByVal objetoParametro As Hashtable) As DataTable
        Dim objParam As New Parameter

        Dim oDt As New DataTable

        Dim oList As New List(Of beAutorizacion)


        objParam.Add("PSMMCAPL", objetoParametro("MMCAPL"))
        objParam.Add("PSMMCUSR", objetoParametro("MMCUSR"))
        objParam.Add("PNNCROPC", objetoParametro("NCROPC"))

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_AUTORIZACION_USUARIO_X_NROOPCION", objParam)

        Return oDt

    End Function


End Class
