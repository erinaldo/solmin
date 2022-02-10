Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario
'****************************************************************************************************
'** Autor: Rafael gamboa
'** Descripción: capa de acceso a datos .
'****************************************************************************************************
Namespace mantenimientos

  Public Class Chofer_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Chofer(ByVal objEntidad As Chofer) As Chofer
            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT, ParameterDirection.Output)
            objParam.Add("PSTNMCMC", objEntidad.TNMCMC)
            objParam.Add("PSTAPPAC", objEntidad.TAPPAC)
            objParam.Add("PSTAPMAC", objEntidad.TAPMAC)
            objParam.Add("PNNCLICO", objEntidad.NCLICO)
            objParam.Add("PNNLELCH", objEntidad.NLELCH)
            objParam.Add("PSCSGRSC", objEntidad.CSGRSC)
            objParam.Add("PSTGRPSN", objEntidad.TGRPSN)

            objParam.Add("PNFVEDNI", objEntidad.FVEDNI)
            objParam.Add("PNFEMLIC", objEntidad.FEMLIC)
            objParam.Add("PNFVELIC", objEntidad.FVELIC)
            objParam.Add("PSCODSAP", objEntidad.CODSAP)
            'objParam.Add("PNFECING", objEntidad.FECING)
            objParam.Add("PNFCHING", objEntidad.FCHING)
            objParam.Add("PSTDRCC", objEntidad.TDRCC)
            objParam.Add("PNNRORPM", objEntidad.NRORPM)
            objParam.Add("PSTOBS", objEntidad.TOBS)

            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CHOFER", objParam)
            objEntidad.CBRCNT = objSql.ParameterCollection("POS_CBRCNT")

            If objEntidad.CBRCNT = "-1" Then
                MsgBox("El transportista existe en estado inactivo. ", MsgBoxStyle.Critical)
            End If

            'Catch ex As Exception
            '          MsgBox(ex.Message)
            '          objEntidad.CBRCNT = 0
            '      End Try

            Return objEntidad
    End Function

    Public Function Registrar_Chofer_Antiguo(ByVal objEntidad As Chofer) As Chofer
            'Try
            Dim objParam As New Parameter

            objParam.Add("POS_CBRCNT", objEntidad.CBRCNT)
            objParam.Add("PNNLELCH", objEntidad.NLELCH)
            objParam.Add("PSCSGRSC", objEntidad.CSGRSC)
            objParam.Add("PSTGRPSN", objEntidad.TGRPSN)
            objParam.Add("PSTDRCC", objEntidad.TDRCC)
            objParam.Add("PNNRORPM", 0)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PNFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CHOFER_ANTIGUO", objParam)
            objEntidad.CBRCNT = objSql.ParameterCollection("POS_CBRCNT")

            If objEntidad.CBRCNT = "-1" Then
                MsgBox("El transportista existe en estado inactivo. Comuníquese con el dpto. de sistemas para activarlo.", MsgBoxStyle.Critical)
            End If

            'Catch ex As Exception
            '          MsgBox(ex.Message)
            '          objEntidad.CBRCNT = 0
            '      End Try

            Return objEntidad
    End Function


    Public Function Modificar_Chofer(ByVal objEntidad As Chofer) As Chofer

            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSTNMCMC", objEntidad.TNMCMC)
            objParam.Add("PSTAPPAC", objEntidad.TAPPAC)
            objParam.Add("PSTAPMAC", objEntidad.TAPMAC)
            objParam.Add("PNNCLICO", objEntidad.NCLICO)
            objParam.Add("PNNLELCH", objEntidad.NLELCH)
            objParam.Add("PSCSGRSC", objEntidad.CSGRSC)
            objParam.Add("PSTGRPSN", objEntidad.TGRPSN)

            objParam.Add("PNFVEDNI", objEntidad.FVEDNI)
            objParam.Add("PNFEMLIC", objEntidad.FEMLIC)
            objParam.Add("PNFVELIC", objEntidad.FVELIC)
            objParam.Add("PSCODSAP", objEntidad.CODSAP)
            'objParam.Add("PNFECING", objEntidad.FECING)
            objParam.Add("PNFCHING", objEntidad.FCHING)
            objParam.Add("PSTDRCC", objEntidad.TDRCC)
            objParam.Add("PSNRORPM", objEntidad.NRORPM)
            objParam.Add("PSTOBS", objEntidad.TOBS)

            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_CHOFER", objParam)

            'Catch ex As Exception
            '          objEntidad.CBRCNT = "0"
            '          MsgBox(ex.Message)
            '      End Try

            Return objEntidad
    End Function

    Public Function Eliminar_Chofer(ByVal objEntidad As Chofer) As Chofer

            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CHOFER", objParam)

            'Catch ex As Exception
            '          objEntidad.CBRCNT = "0"
            '      End Try

            Return objEntidad
    End Function

    Public Function Listar_Chofer(ByVal objEntidad As Chofer) As List(Of Chofer)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Chofer)
      Dim objParam As New Parameter
      Dim objDatos As Chofer
            'Try
            'Obteniendo resultados
            objParam.Add("PSPARAM", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            If objEntidad.SINDRC IsNot "" Then
                objParam.Add("PSSINDRC", objEntidad.SINDRC)
            End If
            objParam.Add("PSESTADO", objEntidad.ESTADO)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CHOFER_T2_LA", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Chofer
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
                objDatos.TAPPAC = objDataRow("APEPAT").ToString.Trim
                objDatos.TAPMAC = objDataRow("APEMAT").ToString.Trim
                objDatos.NOMBRECOMPLETO = objDataRow("APEPAT").ToString.Trim & " " & objDataRow("APEMAT").ToString.Trim & " " & objDataRow("TNMCMC").ToString.Trim
                objDatos.NCLICO = objDataRow("NCLICO").ToString.Trim
                objDatos.NLELCH = objDataRow("NLELCH").ToString.Trim
                objDatos.CSGRSC = objDataRow("CSGRSC").ToString.Trim
                objDatos.TGRPSN = objDataRow("TGRPSN").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                '----
                objDatos.FVEDNI = HelpClass.CFecha_de_8_a_10(objDataRow("FVEDNI").ToString.Trim)
                objDatos.FEMLIC = HelpClass.CFecha_de_8_a_10(objDataRow("FEMLIC").ToString.Trim)
                objDatos.FVELIC = HelpClass.CFecha_de_8_a_10(objDataRow("FVELIC").ToString.Trim)
                objDatos.CODSAP = objDataRow("CODSAP").ToString.Trim
                'objDatos.FECING = "01/" & Right(objDataRow("FECING").ToString.Trim, 2) & "/" & Left(objDataRow("FECING").ToString.Trim, 4)
                objDatos.FCHING = HelpClass.CFecha_de_8_a_10(objDataRow("FCHING").ToString.Trim)
                objDatos.TDRCC = objDataRow("TDRCC").ToString.Trim
                objDatos.NRORPM = objDataRow("NTERPM").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                '----
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.CCATLI = objDataRow("CCATLI").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim

                objDatos.FLGAPR = objDataRow("FLGAPR").ToString.Trim
                If objDataRow("FLGAPR").ToString.Trim <> "" Then objDatos.USRAPR = objDataRow("USRAPR").ToString.Trim

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim


                objGenericCollection.Add(objDatos)

            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Chofer_Reporte(ByVal objEntidad As Chofer) As List(Of Chofer)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Chofer)
      Dim objParam As New Parameter
      Dim objDatos As Chofer
            'Try
            'Obteniendo resultados
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CHOFER_RPT2", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                objDatos = New Chofer

                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
                objDatos.TAPPAC = objDataRow("APEPAT").ToString.Trim
                objDatos.TAPMAC = objDataRow("APEMAT").ToString.Trim
                objDatos.NCLICO = objDataRow("NCLICO").ToString.Trim
                objDatos.NLELCH = objDataRow("NLELCH").ToString.Trim
                objDatos.CSGRSC = objDataRow("CSGRSC").ToString.Trim
                objDatos.TGRPSN = objDataRow("TGRPSN").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.FEMLIC = objDataRow("FEMLIC").ToString.Trim
                objDatos.FVELIC = objDataRow("FVELIC").ToString.Trim
                objDatos.CODSAP = objDataRow("CODSAP").ToString.Trim
                objDatos.FVEDNI = objDataRow("FVEDNI").ToString.Trim
                objDatos.FCHING = objDataRow("FCHING").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                objDatos.TDRCC = objDataRow("TDRCC").ToString.Trim
                objDatos.TOBS = objDataRow("TOBS").ToString.Trim
                objDatos.CCATLI = objDataRow("CCATLI").ToString.Trim
                objDatos.NRORPM = objDataRow("NRORPM").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.TCATLI = objDataRow("CCATLI").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim

                Dim lstr_URL As String = My.Settings.DAL_URL + "imagenes/solmin/conductor/"
                Dim lstr_URLArchivo As String = lstr_URL & objDataRow("CBRCNT").ToString.Trim & ".jpg"
                Dim lstr_URLDefault As String = lstr_URL & "BlankPicture.jpg"
                Try
                    objDatos.IMG = Validacion.ImageToByte(Validacion.LoadImageFromUrl(lstr_URLArchivo))
                Catch ex As Exception
                End Try
                objGenericCollection.Add(objDatos)


            Next

            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function

    Public Function Listar_Chofer_Masivo_Reporte(ByVal objEntidad As Chofer) As DataTable
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Chofer)
      Dim objParam As New Parameter
      'Dim objDatos As Chofer
            'Try
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CHOFER_MASIVO_RPT", objParam)

            'Procesandolos como una Lista
            'For Each objDataRow As DataRow In objDataTable.Rows
            '   objDatos = New Chofer
            '  objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
            '  objDatos.TNMCMC = objDataRow("TNMCMC").ToString.Trim
            '  objDatos.TAPPAC = objDataRow("TAPPAC").ToString.Trim
            '  objDatos.TAPMAC = objDataRow("TAPMAC").ToString.Trim
            '  objDatos.NCLICO = objDataRow("NCLICO").ToString.Trim
            '  objDatos.NLELCH = objDataRow("NLELCH").ToString.Trim
            '  objDatos.CSGRSC = objDataRow("CSGRSC").ToString.Trim
            '  objDatos.TGRPSN = objDataRow("TGRPSN").ToString.Trim
            '  objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
            '  objDatos.FVEDNI = objDataRow("FVEDNI").ToString.Trim
            '  objDatos.FEMLIC = objDataRow("FEMLIC").ToString.Trim
            '  objDatos.FVELIC = objDataRow("FVELIC").ToString.Trim
            '  objDatos.CODSAP = objDataRow("CODSAP").ToString.Trim
            '  objDatos.FECING = objDataRow("FECING").ToString.Trim
            '  objDatos.TDRCC = objDataRow("TDRCC").ToString.Trim
            '  objDatos.NRORPM = objDataRow("NRORPM").ToString.Trim
            '  objDatos.TOBS = objDataRow("TOBS").ToString.Trim
            '  objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
            '  objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
            '  objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
            '  objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
            '  objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
            '  objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
            '  objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
            '  objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
            '  objDatos.TCATLI = objDataRow("CCATLI").ToString.Trim
            '  objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
            '  objGenericCollection.Add(objDatos)
            'Next
            'Catch ex As Exception
            '          objDataTable = New DataTable
            '      End Try
            Return objDataTable 'objGenericCollection
    End Function

    Public Function Obtener_brevete(ByVal lobjEntidad As Chofer) As Chofer
      Dim oDt As DataTable
      Dim objEntidad As New Chofer
            'Try
            Dim objParam As New Parameter
            objParam.Add("PNCODSAP", lobjEntidad.CODSAP)
            objParam.Add("PSCCMPN", lobjEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_BREVETE_X_CODSAP", objParam)
            For Each objDr As DataRow In oDt.Rows
                objEntidad.CBRCNT = objDr.Item("CBRCNT")
            Next
            'Catch ex As Exception
            '          ' Throw New Exception(ex.Message)
            '      End Try
            Return objEntidad
    End Function

    Public Function Obtener_Estado_Chofer(ByVal lobjEntidad As Chofer) As String
      Dim strEstado As String = ""
      Dim objEntidad As New Chofer
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCBRCNT", lobjEntidad.CBRCNT)
            objParam.Add("PSCCMPN", lobjEntidad.CCMPN)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad.CCMPN)

            strEstado = objSql.ExecuteScalar("SP_SOLMIN_ST_OBTENER_ESTADO_CHOFER", objParam).ToString()
            'Catch ex As Exception
            '      End Try
            Return strEstado
    End Function

    Public Function Lista_Asistencia_Conductor(ByVal objEntidad As Hashtable) As DataTable
      Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCBRCNT", objEntidad("CBRCNT"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ASISTENCIA_LA", objParam)

            For Each dr As DataRow In objDataTable.Rows
                dr("FECOST") = HelpClass.CFecha_de_8_a_10(dr("FECOST").ToString.Trim)
                dr("FEMVLH") = HelpClass.CFecha_de_8_a_10(dr("FEMVLH").ToString.Trim)
                dr("FCHFTR") = HelpClass.CFecha_de_8_a_10(dr("FCHFTR").ToString.Trim)
            Next

            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
    End Function

    Public Function Aprobar_Conformidad_Datos_Conductor(ByVal objEntidad As Chofer) As String
      Dim strResult As String = ""
      Dim objParam As New Parameter
            'Try
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCBRCNT", objEntidad.CBRCNT)
            objParam.Add("PSFLGAPR", objEntidad.FLGAPR)
            objParam.Add("PSUSRAPR", objEntidad.USRAPR)
            objParam.Add("PNFCHAPR", objEntidad.FCHAPR)
            objParam.Add("PNHRAAPR", objEntidad.HRAAPR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PNFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_APROBAR_DATOS_CONDUCTOR", objParam)

            'Catch ex As Exception
            '          strResult = ex.Message.Trim
            '      End Try

            Return strResult
    End Function

    Public Function Reporte_Asistencia_Conductor(ByVal objEntidad As Hashtable) As DataTable
      Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCBRCNT", objEntidad("CBRCNT"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_ASISTENCIA_CONDUCTORES", objParam)
            'Catch ex As Exception
            '          objDataTable = New DataTable
            '      End Try
            Return objDataTable
        End Function

        'Public Function Lista_Asistencia_Conductor_Reporte(ByVal objEntidad As Hashtable) As DataTable
        '    Dim objDataTable As New DataTable
        '    Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PSCCMPN", objEntidad("CCMPN"))
        '        objParam.Add("PSCBRCNT", objEntidad("CBRCNT"))
        '        objParam.Add("PNFECINI", objEntidad("FECINI"))
        '        objParam.Add("PNFECFIN", objEntidad("FECFIN"))

        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

        '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ASISTENCIA_RPT", objParam)
        '    Catch ex As Exception
        '        objDataTable = New DataTable
        '    End Try
        '    Return objDataTable
        'End Function

        Public Function Lista_Asistencia_Conductor_Reporte(ByVal objEntidad As Hashtable) As DataTable
            Dim objDataTable As New DataTable
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", objEntidad("CCMPN"))
            objParam.Add("PSCBRCNT", objEntidad("CBRCNT"))
            objParam.Add("PNFECINI", objEntidad("FECINI"))
            objParam.Add("PNFECFIN", objEntidad("FECFIN"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad("CCMPN"))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_ASISTENCIA_RPT", objParam)
            'Catch ex As Exception
            '    objDataTable = New DataTable
            'End Try
            Return objDataTable
        End Function
        'CSR-HUNDRED-feature/151116_Combustibles
        Public Function Lista_Conductor_General(ByVal Compania As String) As List(Of Chofer)
            Dim objParam As New Parameter
            Dim dttemp As DataTable
            Dim objGenericCollection As New List(Of Chofer)
            Dim objDatos As Chofer

            objParam.Add("PSCCMPN", Compania)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Compania)
            dttemp = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_CONDUCTORES_GENERAL", objParam)

            For Each objDataRow As DataRow In dttemp.Rows
                objDatos = New Chofer
                objDatos.CBRCNT = objDataRow("CBRCNT").ToString.Trim
                objDatos.NOMBRECOMPLETO = objDataRow("NOMBRES").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next

            Return objGenericCollection
        End Function
        'CSR-HUNDRED-feature/151116_Combustibles

    End Class
End Namespace