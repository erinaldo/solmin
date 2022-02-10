Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos
  Public Class Transportista_DAL
    Private objSql As New SqlManager

    Public Function Registrar_Transportista(ByVal objEntidad As Transportista) As Transportista
           
            'Return objEntidad
            Dim objParam As New Parameter
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PON_CTRSPT", objEntidad.CTRSPT, ParameterDirection.Output)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)
            objParam.Add("PSTABTRT", objEntidad.TABTRT)
            objParam.Add("PSTDRCTR", objEntidad.TDRCTR)
            objParam.Add("PSTLFTRP", objEntidad.TLFTRP)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PSFCHCRT", objEntidad.FCHCRT)
            objParam.Add("PNHRACRT", objEntidad.HRACRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSRUCPR2", objEntidad.RUCPR2)

            objParam.Add("PSCRSPSG", objEntidad.CODRESPSEG)
            objParam.Add("PSRESPSEG", objEntidad.RESPSEG)
            objParam.Add("PNPCRSGR", objEntidad.PORSEGCARGA)

            'ejecuta el procedimiento almacenado
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objEntidad.CTRSPT = 0
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_CREAR_TRANSPORTISTA", objParam)          
            objEntidad.CTRSPT = objSql.ParameterCollection("PON_CTRSPT")
            If objEntidad.CTRSPT = "-1" Then
                MsgBox("El transportista ya existe.", MsgBoxStyle.Critical)
            ElseIf objEntidad.CTRSPT = "-2" Then
                MsgBox("El transportista ya existe en estado inactivo.", MsgBoxStyle.Critical)
            ElseIf objEntidad.CTRSPT = "-3" Then
                MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critical)
 
            End If
            Return objEntidad
        End Function

    Public Function Modificar_Transportista(ByVal objEntidad As Transportista) As Transportista

           


            Dim objParam As New Parameter
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PON_CTRSPT", objEntidad.CTRSPT, ParameterDirection.Output)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)
            objParam.Add("PSTABTRT", objEntidad.TABTRT)
            objParam.Add("PSTDRCTR", objEntidad.TDRCTR)
            objParam.Add("PSTLFTRP", objEntidad.TLFTRP)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PNNEWCTRSPT", objEntidad.NEWCTRSPT)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSRUCPR2", objEntidad.RUCPR2)

            objParam.Add("PSCRSPSG", objEntidad.CODRESPSEG)
            objParam.Add("PSRESPSEG", objEntidad.RESPSEG)
            objParam.Add("PNPCRSGR", objEntidad.PORSEGCARGA)

 

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objEntidad.CTRSPT = "0"
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_TRANSPORTISTA", objParam)
            objEntidad.CTRSPT = objSql.ParameterCollection("PON_CTRSPT")
            If objEntidad.CTRSPT = "-1" Then
                MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critical)
            End If
          
            Return objEntidad

    End Function

    Public Function Eliminar_Transportista(ByVal objEntidad As Transportista)
            Dim objParam As New Parameter
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSFULTAC", objEntidad.FULTAC)
            objParam.Add("PNHULTAC", objEntidad.HULTAC)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'ejecuta el procedimiento almacenado
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_TRANSPORTISTA", objParam)

           

      Return objEntidad
    End Function

    Public Function Listar_Transportista_DDL(ByVal objEntidad As Transportista) As List(Of Transportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Transportista)
      Dim objParam As New Parameter
      Dim objDatos As New Transportista

            'Obteniendo resultados
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA", objParam)
            'Procesandolos como una Lista
            Dim dr As DataRow = objDataTable.NewRow
            Dim objDatosTmp As New Transportista
            objDatosTmp.CTRSPT = "0"
            objDatosTmp.TCMTRT = "--- Escoja Elemento ---"
            objGenericCollection.Add(objDatosTmp)

            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Transportista
                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
          
            Return objGenericCollection
    End Function

        Public Function Listar_Transportista(ByVal objEntidad As Transportista) As List(Of Transportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter
            Dim objDatos As Transportista


            'Obteniendo resultados
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA", objParam)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA_V2", objParam)
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                objDatos = New Transportista

                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.TABTRT = objDataRow("TABTRT").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TDRCTR = objDataRow("TDRCTR").ToString.Trim
                objDatos.TLFTRP = objDataRow("TLFTRP").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                objDatos.TRACTOS_ASIGNADOS = objDataRow("TRACTOS_ASIGNADOS").ToString.Trim
                objDatos.ACOPLADOS_ASIGNADOS = objDataRow("ACOPLADOS_ASIGNADOS").ToString.Trim
                objDatos.CHOFERES_ASIGNADOS = objDataRow("CHOFERES_ASIGNADOS").ToString.Trim
                objDatos.CCMPN = objEntidad.CCMPN
                objDatos.CDVSN = objEntidad.CDVSN
                objDatos.CPLNDV = objEntidad.CPLNDV
                objDatos.RUCPR2 = objDataRow("RUCPR2").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next
            
            Return objGenericCollection
        End Function


        Public Function Listar_Transportista_Por_Tipo(ByVal objEntidad As Transportista, IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal) As List(Of Transportista)
            'Dim objDataTable As New DataTable
            TOTPAG = 0
            Dim ds As New DataSet
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter
            Dim objDatos As Transportista


            'Obteniendo resultados
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSCDVSN", objEntidad.CDVSN)
            objParam.Add("PNCPLNDV", objEntidad.CPLNDV)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)

            objParam.Add("IN_NROPAG", IN_NROPAG)
            objParam.Add("PAGESIZE", PAGESIZE)
            objParam.Add("OU_TOTPAG", 0)


            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA", objParam)
            'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA_V3", objParam)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA_V4", objParam)

            If ds.Tables(1).Rows.Count > 0 Then
                TOTPAG = ds.Tables(1).Rows(0)("NUM_PAG")
            End If
            'Procesandolos como una Lista
            For Each objDataRow As DataRow In ds.Tables(0).Rows

                objDatos = New Transportista

                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.TABTRT = objDataRow("TABTRT").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TDRCTR = objDataRow("TDRCTR").ToString.Trim
                objDatos.TLFTRP = objDataRow("TLFTRP").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.NTRMCR = objDataRow("NTRMCR").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim
                objDatos.NTRMNL = objDataRow("NTRMNL").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                objDatos.TRACTOS_ASIGNADOS = objDataRow("TRACTOS_ASIGNADOS").ToString.Trim
                objDatos.ACOPLADOS_ASIGNADOS = objDataRow("ACOPLADOS_ASIGNADOS").ToString.Trim
                objDatos.CHOFERES_ASIGNADOS = objDataRow("CHOFERES_ASIGNADOS").ToString.Trim
                objDatos.CCMPN = objEntidad.CCMPN
                objDatos.CDVSN = objEntidad.CDVSN
                objDatos.CPLNDV = objEntidad.CPLNDV
                objDatos.RUCPR2 = objDataRow("RUCPR2").ToString.Trim
                objDatos.CANT_COD_SAP = objDataRow("CANT_COD_SAP")
                objDatos.TRANSPORTISTA_AS = objDataRow("TRANSPORTISTA_AS")
                objDatos.CTRSPT_AS = objDataRow("CTRSPT_AS")

                objDatos.CODRESPSEG = objDataRow("CODRESPSEG").ToString.Trim
                'objDatos.RESPSEG = objDataRow("RESPSEG").ToString.Trim
                objDatos.PORSEGCARGA = objDataRow("PORSEGCARGA")


                 

 


                objGenericCollection.Add(objDatos)
            Next

            Return objGenericCollection
        End Function





    Public Function Listar_TransportistaRPT(ByVal objEntidad As Transportista) As DataTable
      Dim objDataTable As New DataTable
      Dim objParam As New Parameter

            'Try
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_RPT", objParam)
            'Catch ex As Exception
            '      End Try

            Return objDataTable
    End Function

    'Public Function Buscar_Transportista(ByVal objEntidad As Transportista) As List(Of Transportista)
    '  Dim objDataTable As New DataTable
    '  Dim objGenericCollection As New List(Of Transportista)
    '  Dim objDatos As Transportista
    '  Dim objParam As New Parameter
    '  Try
    '    objParam.Add("PTCMTRT", objEntidad.TCMTRT)
    '    objParam.Add("PNRUCTR", objEntidad.NRUCTR)
    '    objParam.Add("PSESTRG", objEntidad.SESTRG)
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

    '    'Obteniendo resultados
    '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA", objParam)

    '    'Procesandolos como una Lista
    '    For Each objDataRow As DataRow In objDataTable.Rows
    '      objDatos = New Transportista
    '      objDatos.CTRSPT = objDataRow("CTRSPT").ToString().Trim()
    '      objDatos.TCMTRT = objDataRow("TCMTRT").ToString().Trim()
    '      objDatos.TABTRT = objDataRow("TABTRT").ToString().Trim()
    '      objDatos.NRUCTR = objDataRow("NRUCTR").ToString().Trim()
    '      objDatos.TDRCTR = objDataRow("TDRCTR").ToString().Trim()
    '      objDatos.TLFTRP = objDataRow("TLFTRP").ToString().Trim()
    '      objGenericCollection.Add(objDatos)
    '    Next

    '  Catch ex As Exception
    '  End Try
    '  Return objGenericCollection
    'End Function

    'Public Function Busca_TransportistaTotalDet(ByVal strCompania As String) As Data.DataTable
    '  Dim objDataTable As New DataTable
    '  Dim objParam As New Parameter
    '  Try
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
    '    objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_BUSCAR_TRANSPORTISTA", Nothing)
    '    'Procesandolos como una Lista             
    '  Catch ex As Exception
    '  End Try
    '  Return objDataTable
    'End Function

    Public Function Listar_TransportistaCbo(ByVal strCompania As String) As List(Of Transportista)
      Dim objDataTable As New DataTable
      Dim objGenericCollection As New List(Of Transportista)
      Dim objDatos As Transportista
            'Try
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_CARGAR_TRANSPORTISTA", Nothing)
            'Procesandolos como una Lista       
            For Each objDataRow As DataRow In objDataTable.Rows
                objDatos = New Transportista
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next
            'Catch ex As Exception
            '      End Try
            Return objGenericCollection
    End Function

        Public Function VerificarMovimientoTransportista(ByVal PNCTRSPT As Decimal, ByVal PSCCMPN As String) As Int32
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            Dim numMovientos As Decimal = 0
            objParam.Add("PNCTRSPT", PNCTRSPT)
            objParam.Add("PSCCMPN", PSCCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_MOVIMIENTOS_TRANSPORTISTA", objParam)
            If objDataTable.Rows.Count > 0 Then
                numMovientos = objDataTable.Rows(0)("NUM_MOV")
            End If
            Return numMovientos
        End Function
   
        Public Sub ActivarTransportista(ByVal objEntidad As Transportista)
            Dim objParam As New Parameter
            Dim numMovientos As Decimal = 0
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCULUSA", objEntidad.CULUSA)
            objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTIVAR_TRANSPORTISTA", objParam)
        End Sub

        Public Function Listar_Transportista_X_RUC(ByVal objEntidad As Transportista) As DataTable
            Dim objDataTable As New DataTable
            Dim objParam As New Parameter
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("NEWCTRSPT", objEntidad.NEWCTRSPT)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRANSPORTISTA_X_RUC", objParam)
            Return objDataTable
        End Function

        Public Function Listar_Proveedor(ByVal objEntidad As Transportista) As List(Of Transportista)
            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter


            'Obteniendo resultados
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)
            'objParam.Add("PSSINDRC", objEntidad.SINDRC)
            objParam.Add("PSSESTRG", objEntidad.SESTRG)
            objParam.Add("PSFLARSO", objEntidad.FLARSO)
            objParam.Add("PSTIPO", objEntidad.TipoRecurso)
            objParam.Add("PSPLACA", objEntidad.Placa)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ASIGNACION_RECURSO_PROVEEDOR", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Transportista

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.TABTRT = objDataRow("TABTRT").ToString.Trim
                objDatos.TDRCTR = objDataRow("TDRCTR").ToString.Trim
                objDatos.RUCPR2 = objDataRow("RUCPR2").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                objDatos.SINDRC_S = objDataRow("SINDRC_S").ToString.Trim
                objDatos.CANT_TRACTO = objDataRow("CANT_TRACTO").ToString.Trim
                objDatos.CANT_ACOPLADO = objDataRow("CANT_ACOPLADO").ToString.Trim
                objDatos.CANT_EQUIPO = objDataRow("CANT_EQUIPO").ToString.Trim
                objDatos.SESTRG = objDataRow("SESTRG").ToString.Trim
                objDatos.CUSCRT = objDataRow("CUSCRT").ToString.Trim
                objDatos.FCHCRT = objDataRow("FCHCRT").ToString.Trim
                objDatos.HRACRT = objDataRow("HRACRT").ToString.Trim
                objDatos.CULUSA = objDataRow("CULUSA").ToString.Trim
                objDatos.FULTAC = objDataRow("FULTAC").ToString.Trim
                objDatos.HULTAC = objDataRow("HULTAC").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next


            Return objGenericCollection
        End Function

        Public Function Actualizar_Flag_Recurso_Proveedor(ByVal objEntidad As Transportista) As Transportista

            Dim objParam As New Parameter
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSFLARSO", objEntidad.FLARSO)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_FLAG_RECURSO_PROVEEDOR", objParam)

            Return objEntidad
        End Function

        Public Function Listar_Proveedor_Asignado(ByVal objEntidad As Transportista) As List(Of Transportista)

            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of Transportista)
            Dim objParam As New Parameter


            'Obteniendo resultados
            objParam.Add("PSCCMPN", objEntidad.CCMPN)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PROVEEDOR_ASIGNADO", objParam)

            'Procesandolos como una Lista
            For Each objDataRow As DataRow In objDataTable.Rows

                Dim objDatos As New Transportista

                objDatos.CCMPN = objDataRow("CCMPN").ToString.Trim
                objDatos.NRUCTR = objDataRow("NRUCTR").ToString.Trim
                objDatos.TCMTRT = objDataRow("TCMTRT").ToString.Trim
                objDatos.CTRSPT = objDataRow("CTRSPT").ToString.Trim
                objDatos.SINDRC = objDataRow("SINDRC").ToString.Trim
                objDatos.SINDRC_S = objDataRow("SINDRC_S").ToString.Trim

                objGenericCollection.Add(objDatos)

            Next


            Return objGenericCollection

        End Function



        Public Function Registrar_AS400_Transportista(ByVal objEntidad As Transportista) As String
            Dim dt As New DataTable
            Dim objParam As New Parameter
            Dim msg As String = ""
            objParam.Add("PNCTRSPT", objEntidad.CTRSPT)
            objParam.Add("PSNRUCTR", objEntidad.NRUCTR)
            objParam.Add("PSTCMTRT", objEntidad.TCMTRT)
            objParam.Add("PSCUSCRT", objEntidad.CUSCRT)
            objParam.Add("PSNTRMCR", objEntidad.NTRMCR)
            objParam.Add("PSRUCPR2", objEntidad.RUCPR2)


            objParam.Add("PSTDRCTR", objEntidad.TDRCTR)
            objParam.Add("PSTABTRT", objEntidad.TABTRT)
            objParam.Add("PSCRSPSG", objEntidad.CODRESPSEG)

            objParam.Add("PSRESPSEG", objEntidad.RESPSEG)


            objParam.Add("PNPCRSGR", objEntidad.PORSEGCARGA)

 
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_AS400_CREAR_TRANSPORTISTA", objParam)
            For Each item As DataRow In dt.Rows
                If item("STATUS") = "E" Then
                    msg = msg & item("OBSRESULT") & Chr(13)
                End If
            Next
            msg = msg.Trim
            If msg.Length = 0 And dt.Rows.Count > 0 Then
                objEntidad.CTRSPT = dt.Rows(0)("CTRSPT")
            End If

            Return msg
        End Function

    End Class

End Namespace
