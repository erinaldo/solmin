Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class OptionAccess
    Implements IDisposable
#Region " Atributos "
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private dtOptionsForUser As DataTable           ' Tabla que contendrá las opciones del Usuario

    Private strUsuario As String = ""               ' Usuario quien tiene los permisos
    Private strNameUser As String = ""              ' Nombre Completo del Usuario
    Private strAplicativo As String = ""            ' Aplicativo con el que trabaja el usuario
    Private strCia As String = ""                   ' Compañía a la que pertenece EZ
    Private strDiv As String = ""                   ' División a la que pertenece R
    Private dtPlanta As DataTable                   ' plantas Asignadas por Usuario
    Private strReg As String = "R04"                ' Región de Venta
    Private strTipoOper As String = "DM"            ' Tipo de Operación
    Private strMensajeError As String               ' Mensaje de Error
#End Region
#Region " Propiedades "
    Public ReadOnly Property pUsuario() As String
        Get
            Return strUsuario
        End Get
    End Property

    Public ReadOnly Property pNombreUsuario() As String
        Get
            Return strNameUser
        End Get
    End Property

    Public ReadOnly Property pCompania() As String
        Get
            Return strCia
        End Get
    End Property

    Public ReadOnly Property pDivision() As String
        Get
            Return strDiv
        End Get
    End Property

    Public ReadOnly Property pPlantas() As DataTable
        Get
            Return dtPlanta
        End Get
    End Property

    Public ReadOnly Property pAplicativo() As String
        Get
            Return strAplicativo
        End Get
    End Property

    Public ReadOnly Property pMensajeError() As String
        Get
            Return strMensajeError
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pLoadOptionsForUser()
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_MMCAPL", strAplicativo)
        objParametros.Add("IN_MMCUSR", strUsuario)
        Try
            strMensajeError = ""
            Dim dstTemp As DataSet = objSqlManager.ExecuteDataSet("SP_SOLMIN_ACCESO", objParametros)
            dtOptionsForUser = dstTemp.Tables(0).Copy
            dtPlanta = dstTemp.Tables(2).Copy
            ' Tabla que contendrá la información del Usuario
            If dstTemp.Tables(1).Rows.Count > 0 Then
                strNameUser = ("" & dstTemp.Tables(1).Rows(0).Item("MMNUSR")).ToString.Trim
                strCia = ("" & dstTemp.Tables(1).Rows(0).Item("CCMPOR")).ToString.Trim
                strDiv = ("" & dstTemp.Tables(1).Rows(0).Item("CDVSNU")).ToString.Trim
            End If
        Catch ex As Exception
            dtOptionsForUser = New DataTable
            strMensajeError = "Error producido en la funcion : << fblnCargarOpcionesPorUsuario >> de la clase << OptionAccess >> " & vbNewLine & _
                              "Tipo de Consulta : SP_SOLMIN_ACCESO " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Sub

    Private Function fblnValidateOptionAccess(ByVal OptionCode As String) As Boolean
        Dim rwOpciones() As DataRow
        Dim blnResultado As Boolean = False
        Dim strCodeFather As String = OptionCode
        rwOpciones = dtOptionsForUser.Select("MMNQVB = '" & strCodeFather & "'")
        If rwOpciones.Length > 0 Then
            If ("" & rwOpciones(0).Item("MMCUSR")).ToString.Trim = strUsuario Then
                ' Armamos el Codigo Padre para validar si pertenece a un nodo superior
                strCodeFather = rwOpciones(0).Item("MMCAPL") & rwOpciones(0).Item("MMCMNU")
                If strAplicativo & "00" = strCodeFather Then
                    blnResultado = True
                Else
                    blnResultado = fblnValidateOptionAccess(strCodeFather)
                End If
            Else
                blnResultado = False
            End If
        End If
        Return blnResultado
    End Function

    Private Function fdtGetInfLocked(ByVal Cliente As String, ByVal FnVerificacion As String, ByVal RefServ As String, _
                                     ByVal NroOpe As String, ByRef sPARAM_SFLGB1 As String, ByRef sPARAM_SFLGB2 As String, _
                                     ByRef sPARAM_MSGBLQ As String, Optional ByVal strCompania As String = "", Optional ByVal strDivision As String = "") As Boolean
        Dim bResultado As Boolean = True
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)

        Select Case Cliente
            Case 10219, 11731, 13660, 17494, 30507, 42246, 50068, 51991, 52434, 52808, 52941, 888
                strReg = "R11"
            Case Else
                strReg = "R04"
        End Select
        Cliente = Right("000000" & Cliente, 6)
        ' Ingresamos los parametros del Procedure
        If strCompania <> "" Then
            objParametros.Add("PARAM_CCMPN", strCompania)
        Else
            objParametros.Add("PARAM_CCMPN", strCia)
        End If
        If strDivision <> "" Then
            objParametros.Add("PARAM_CDVSN", strDivision)
        Else
            objParametros.Add("PARAM_CDVSN", strDiv)
        End If
        objParametros.Add("PARAM_CRGVTA", strReg)
        objParametros.Add("PARAM_CCLNT", Cliente)
        objParametros.Add("PARAM_TPOOPE", strTipoOper)
        objParametros.Add("PARAM_TFNCVR", FnVerificacion)
        objParametros.Add("PARAM_REFSRV", RefServ)
        objParametros.Add("PARAM_NROOPE", NroOpe)
        objParametros.Add("PARAM_SFLGB1", "", ParameterDirection.Output)
        objParametros.Add("PARAM_SFLGB2", "", ParameterDirection.Output)
        objParametros.Add("PARAM_MSGBLQ", "", ParameterDirection.Output)
        Try
            Dim strSQL As String = ""

            'strSQL = "Delete from RZHT71 WHERE CULUSA='" & strUsuario & "'"
            'objSqlManager.ExecuteNoQuery(strSQL)

            'strSQL = "Delete from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            'objSqlManager.ExecuteNoQuery(strSQL)


            'strSQL = "INSERT INTO RZHT71 VALUES ('" & strUsuario & "',1)"
            'objSqlManager.ExecuteNoQuery(strSQL)

            'strSQL = "insert into RZHT70 values ('" & strCia & "','" & strDiv & "','" & strReg & "'," & Cliente & ",'" & strTipoOper & "','" & _
            '                                     FnVerificacion & "','" & RefServ & "','" & NroOpe & "','" & Moneda & "'," & ImpSoles & "," & _
            '                                     ImpDolares & ",'','','','" & strUsuario & "',1)"
            'objSqlManager.ExecuteNonQuery(strSQL)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RCC575 ", objParametros)
            Dim htResultado As Hashtable
            htResultado = objSqlManager.ParameterCollection
            sPARAM_SFLGB1 = ("" & htResultado("PARAM_SFLGB1")).ToString.Trim
            sPARAM_SFLGB2 = ("" & htResultado("PARAM_SFLGB2")).ToString.Trim
            sPARAM_MSGBLQ = ("" & htResultado("PARAM_MSGBLQ")).ToString.Trim

            'strSQL = "CALL SILEFCLP"
            'objSqlManager.ExecuteNoQuery(strSQL)

            'strSQL = "select SFLGB1,SFLGB2,MSGBLQ from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            'dtTabla = objSqlManager.ExecuteDataTable(strSQL)

            'strSQL = "Delete from RZHT71 WHERE CULUSA='" & strUsuario & "'"
            'objSqlManager.ExecuteNoQuery(strSQL)

            'strSQL = "Delete from RZHT70 WHERE CULUSA='" & strUsuario & "'"
            'objSqlManager.ExecuteNoQuery(strSQL)
        Catch ex As Exception
            sPARAM_SFLGB1 = ""
            sPARAM_SFLGB2 = ""
            sPARAM_MSGBLQ = ""
            bResultado = False
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        Return bResultado
    End Function

 

#End Region
#Region " Metodos "
    Sub New(ByVal Aplicativo As String, ByVal Usuario As String)
        strUsuario = Usuario
        strAplicativo = Aplicativo
        Call pLoadOptionsForUser()
    End Sub

    Public Function fblnHasAccess(ByVal Codigo As String) As Boolean
        Dim strCodeFather As String = ""
        Dim blnResultado As Boolean = False
        ' Se verifica si esta registrado en la Tabla de Permisos.
        If dtOptionsForUser.Rows.Count > 0 Then
            Dim rwOpciones() As DataRow
            ' Obtenemos la fila de la opción.
            rwOpciones = dtOptionsForUser.Select("MMNPVB = '" & Codigo & "'")
            ' Si se obtiene una cantidad mayor cero se evalúa, sino simplemente no tiene acceso.
            If rwOpciones.Length > 0 Then
                If ("" & rwOpciones(0).Item("MMCUSR")).ToString.Trim = strUsuario Then
                    strCodeFather = rwOpciones(0).Item("MMCAPL") & rwOpciones(0).Item("MMCMNU")
                    If strAplicativo & "00" = strCodeFather Then
                        blnResultado = True
                    Else
                        ' Iniciamos la recursividad
                        blnResultado = fblnValidateOptionAccess(strCodeFather)
                    End If
                Else
                    blnResultado = False
                End If
            End If
        End If
        ' Devolvemos el status de Acceso a la Opción
        Return blnResultado
    End Function

    Public Function fblnIsLocked(ByVal Cliente As Int64, ByVal FnVerificacion As String, ByRef strMensaje As String, Optional ByVal strCompania As String = "", Optional ByVal strDivision As String = "") As Boolean
        Dim btnResultado As Boolean = False
        Dim sPARAM_SFLGB1 As String = ""
        Dim sPARAM_SFLGB2 As String = ""
        Dim sMensaje As String = ""

        If fdtGetInfLocked(Cliente, FnVerificacion, "", "", sPARAM_SFLGB1, sPARAM_SFLGB2, sMensaje, strCompania, strDivision) Then
            ' Se bloquea solamente al ser C y B 
            If sPARAM_SFLGB1 = "C" And sPARAM_SFLGB2 = "B" Then
                btnResultado = True
                strMensaje = sMensaje
            End If
        Else
            strMensaje = "Error en la ejecución del Proceso de Verificación"
            ' Se bloquea al no tener respuesta
            btnResultado = True
        End If
        Return btnResultado
    End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If
            ' TODO: Liberar recursos no administrados compartidos
            dtOptionsForUser.Dispose()
            dtOptionsForUser = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class