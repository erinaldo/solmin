Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

  Public Class TipodeTracto_DAL

    Private objSql As New SqlManager

    Public Function Registrar_TipodeTracto(ByVal objEntidad As TipodeTracto) As TipodeTracto

      Try
        Dim objParam As New Parameter

        objParam.Add("PTDETRA", objEntidad.TDETRA)
        objParam.Add("PTABDES", objEntidad.TABDES)
        objParam.Add("PTCNFVH", objEntidad.TCNFVH)
        objParam.Add("PIMGTRA", objEntidad.IMGTRA)
        objParam.Add("PSESTRG", objEntidad.SESTRG)
        objParam.Add("PCUSCRT", objEntidad.CUSCRT)
        objParam.Add("PFCHCRT", objEntidad.FCHCRT)
        objParam.Add("PHRACRT", objEntidad.HRACRT)
        objParam.Add("PNTRMCR", objEntidad.NTRMCR)
        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TIPOTRACTO", objParam)

      Catch ex As Exception
        MsgBox(ex.Message)

        objEntidad.CTITRA = "0"
      End Try

      Return objEntidad
    End Function

    Public Function Modificar_TipodeTracto(ByVal objEntidad As TipodeTracto) As TipodeTracto

      Try

        Dim objParam As New Parameter
        objParam.Add("PCTITRA", objEntidad.CTITRA)
        objParam.Add("PTDETRA", objEntidad.TDETRA)
        objParam.Add("PTABDES", objEntidad.TABDES)
        objParam.Add("PTCNFVH", objEntidad.TCNFVH)
        objParam.Add("PIMGTRA", objEntidad.IMGTRA)
        objParam.Add("PSESTRG", objEntidad.SESTRG)
        objParam.Add("PCULUSA", objEntidad.CULUSA)
        objParam.Add("PFULTAC", objEntidad.FULTAC)
        objParam.Add("PHULTAC", objEntidad.HULTAC)
        objParam.Add("PNTRMNL", objEntidad.NTRMNL)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TIPOTRACTO", objParam)

      Catch ex As Exception

        objEntidad.CTITRA = "0"
      End Try

      Return objEntidad
    End Function

    Public Function Cambiar_Estado_TipodeTracto(ByVal objEntidad As TipodeTracto)

      Try

        Dim objParam As New Parameter
        objParam.Add("PCTITRA", objEntidad.CTITRA)
        objParam.Add("PSESTRG", objEntidad.SESTRG)
        objParam.Add("PCULUSA", objEntidad.CULUSA)
        objParam.Add("PFULTAC", objEntidad.FULTAC)
        objParam.Add("PHULTAC", objEntidad.HULTAC)
        objParam.Add("PNTRMNL", objEntidad.NTRMNL)

        'ejecuta el procedimiento almacenado
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TIPOTRACTO", objParam)

      Catch ex As Exception
        'Caso ser erroneo el procedimiento, pasa a mostrar el numero cero
        'que indica que no ha podido realizar la operación
        objEntidad.CTITRA = "0"
      End Try

      Return objEntidad
    End Function

    Public Function Listar_TipodeTracto(ByVal objEntidad As TipodeTracto) As List(Of TipodeTracto)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TipodeTracto)
      Dim objParam As New Parameter

      Try
        'Obteniendo resultados
        objParam.Add("PSTDETRA", objEntidad.TDETRA)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPOTRACTO", objParam)

        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows

          Dim objDatos As New TipodeTracto

          objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
          objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
          objDatos.TABDES = objDataRow("TABDES").ToString.Trim
          objDatos.TCNFVH = objDataRow("TCNFVH").ToString.Trim
          objDatos.IMGTRA = objDataRow("IMGTRA").ToString.Trim
          objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
          objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
          objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
          objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
          objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
          objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
          objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
          objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
          objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim

          Dim lstr_URL As String = My.Settings.DAL_URL + "imagenes/solmin/tracto/"
          Dim lstr_URLArchivo As String = lstr_URL & objDataRow("CTITRA").ToString.Trim & ".jpg"
          Dim lstr_URLDefault As String = lstr_URL & "BlankPicture.jpg"

          Try
            objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLArchivo))
          Catch ex As Exception
            objDatos.IMAGEN = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLDefault))
          End Try

          objGenericCollection.Add(objDatos)

        Next

      Catch ex As Exception
                MsgBox(ex.Message)
      End Try
      Return objGenericCollection
    End Function

    Public Function Buscar_TipodeTracto(ByVal objEntidad As TipodeTracto) As List(Of TipodeTracto)

      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TipodeTracto)
      Dim objParam As New Parameter

      Try
        objParam.Add("PTDETRA", objEntidad.TDETRA)
        objParam.Add("PSESTRG", objEntidad.SESTRG)
        'Obteniendo resultados
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TIPOTRACTO", objParam)
        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New TipodeTracto
          objDatos.CTITRA = objDataRow("CTITRA").ToString().Trim()
          objDatos.TDETRA = objDataRow("TDETRA").ToString().Trim()
          objDatos.TABDES = objDataRow("TABDES").ToString().Trim()
          objDatos.TCNFVH = objDataRow("TCNFVH").ToString().Trim()
          objGenericCollection.Add(objDatos)
        Next

      Catch ex As Exception
      End Try
      Return objGenericCollection

    End Function

    Public Function Listar_TipodeTractoCbo() As List(Of TipodeTracto)

      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of TipodeTracto)
      Try
        'Obteniendo resultados
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_TIPOTRACTO", Nothing)
        'Procesandolos como una Lista
        For Each objDataRow As DataRow In objDataTable.Rows
          Dim objDatos As New TipodeTracto
          objDatos.CTITRA = objDataRow("CTITRA").ToString().Trim()
          objDatos.TDETRA = objDataRow("TDETRA").ToString().Trim()
          objGenericCollection.Add(objDatos)
        Next

      Catch ex As Exception
      End Try
      Return objGenericCollection

        End Function


        Public Function Listar_TipodeTracto_seleccion(ByVal CCMPN As String) As DataTable
            Dim objDataTable As New DataTable
            'Dim objGenericCollection As New List(Of TipodeTracto)
            Dim objParam As New Parameter
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPOTRACTO_SELECCION", objParam)

            For Each Item As DataRow In objDataTable.Rows
                Item("CTITRA") = Item("CTITRA").ToString.Trim
                Item("TDETRA") = Item("TDETRA").ToString.Trim
            Next

            'Dim objDatos As TipodeTracto
            'For Each objDataRow As DataRow In objDataTable.Rows
            '    objDatos = New TipodeTracto
            '    objDatos.CTITRA = objDataRow("CTITRA").ToString.Trim
            '    objDatos.TDETRA = objDataRow("TDETRA").ToString.Trim
            '    objGenericCollection.Add(objDatos)

            'Next

            Return objDataTable
        End Function

  End Class

End Namespace