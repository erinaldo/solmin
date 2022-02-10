Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SAT.DAO
    Public Class daoEtiquetasBarras
        Inherits BasicClass
#Region " Tipos de Datos "
        Public Class TD_PaletaParaEtiquetar
            Public pintCliente As Int64 = 0
            Public pintNroPaleta As Int64 = 0
            Public pstrUsuario As String = ""
        End Class

        Public Class TD_BultoParaEtiquetar
            Public pintCliente As Int64 = 0
            Public pstrBulto As String = ""
            Public pstrUsuario As String = ""
            Public pstrCompania As String = ""

            Public pstrDivision As String = ""
            Public pdecPlanta As Decimal = 0

        End Class
#End Region
#Region " Atributos "
        '-- Seguridad
        Private strUsuario As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New(ByVal Usuario As String)
            strUsuario = Usuario
        End Sub

        ''' <summary>
        ''' Verifica los bultos correspondientes a un cliente que aún no han sido Etiquetados
        ''' </summary>
        Public Shared Function fblnExiste_BultosSinEtiqueta(ByVal objSqlManager As SqlManager, ByVal strCliente As String, ByRef strMensajeError As String) As Boolean
            Return fblnExiste_Informacion(objSqlManager, strMensajeError, "SAT_GENE_BULTO_01", strCliente)
        End Function

        ''' <summary>
        ''' Verifica las Paletas correspondientes a un cliente que aún no han sido Etiquetadas
        ''' </summary>
        Public Shared Function fblnExiste_PaletasSinEtiqueta(ByVal objSqlManager As SqlManager, ByVal strCliente As String, ByRef strMensajeError As String) As Boolean
            Return fblnExiste_Informacion(objSqlManager, strMensajeError, "SAT_GENE_PALETA_01", strCliente)
        End Function

        ''' <summary>
        ''' Listado de las Paletas correspondientes a un cliente que aún no han sido Etiquetadas
        ''' </summary>
        Public Shared Function fdtListar_BultosSinEtiquetas(ByVal objSqlManager As SqlManager, ByVal strCliente As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_BULTO_01", strCliente)
            dtResultado.TableName = "Bulto"
            Return dtResultado
        End Function

        ''' <summary>
        ''' Listado de las Paletas correspondientes a un cliente que aún no han sido Etiquetadas
        ''' </summary>
        Public Shared Function fdtListar_PaletaSinEtiquetas(ByVal objSqlManager As SqlManager, ByVal strCliente As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_PALETA_01", strCliente)
            dtResultado.TableName = "Paletas"
            Return dtResultado
        End Function

        ''' <summary>
        ''' Función que devuelve una lista de cadenas que contiene la respectiva etiqueta generada para el Bulto,
        ''' además, se puede determinar si se imprime según el Nro. de Bultos o según lo que el usuario necesita.
        ''' </summary>
        Public Shared Function flstrEtiquetas_Bulto(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal strBulto As String, _
                                                    ByVal blnStNroEtiqSegunBulto As Boolean, ByVal intNroCopias As Int32, _
                                                    ByRef strMensajeError As String) As List(Of String)
            Dim dtResultado As DataTable = Nothing
            Dim lstrEtiquetaBulto As List(Of String) = New List(Of String)
            dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_ETIBTO_01", intCliente, strBulto)
            If strMensajeError = "" Then
                If dtResultado.Rows.Count > 0 Then
                    ' Obtenemos el contenido del archivo
                    Dim strEtiqueta As String = My.Resources.txtEtiquetaBultoCINF_F01
                    Dim intContador As Int32 = 0
                    Dim intNroCopiasEtiqueta As Int32 = intNroCopias
                    If blnStNroEtiqSegunBulto Then Int32.TryParse(dtResultado.Rows(0).Item("QREFFW"), intNroCopiasEtiqueta)
                    ' Iniciamos el Proceso
                    strEtiqueta = strEtiqueta.Replace("xUBICACION", ("" & dtResultado.Rows(0).Item("TUBRFR")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xPROVEEDOR", ("" & dtResultado.Rows(0).Item("TPRVCL")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xORDEN_COMPRA", ("" & dtResultado.Rows(0).Item("NORCML")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xGUIA_PROVEEDOR", ("" & dtResultado.Rows(0).Item("NGRPRV")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xOBSERVACIONES", ("" & dtResultado.Rows(0).Item("DESCWB")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xCANTIDAD", dtResultado.Rows(0).Item("QREFFW"))
                    strEtiqueta = strEtiqueta.Replace("xPESO", dtResultado.Rows(0).Item("QPSOBL"))
                    strEtiqueta = strEtiqueta.Replace("xNROWAYBILL", ("" & dtResultado.Rows(0).Item("CREFFW")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & dtResultado.Rows(0).Item("TLUGEN")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("xDIRIGIDO", ("" & dtResultado.Rows(0).Item("TDSCIT")).ToString.Trim)
                    strEtiqueta = strEtiqueta.Replace("FF", intNroCopiasEtiqueta)
                    intContador = 0
                    While intContador < intNroCopiasEtiqueta
                        intContador += 1
                        lstrEtiquetaBulto.Add(strEtiqueta.Replace("II", intContador))
                    End While
                End If
            End If
            Return lstrEtiquetaBulto
        End Function

        ''' <summary>
        ''' Función que devuelve una lista de cadenas que contiene la respectiva etiqueta generada para la paleta.
        ''' </summary>
        Public Shared Function flstrEtiquetas_SecuenciaBultos(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal strPrefijo As String, _
                                                              ByVal intInicial As Int64, ByVal intFinal As Int64, ByVal intNroCopias As Int32, _
                                                              ByRef strMensajeError As String) As List(Of String)
            'Dim dtResultado As DataTable = Nothing
            Dim lstrEtiquetaBulto As List(Of String) = New List(Of String)
            'dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_ETIBTO_01", intCliente, strBulto)
            If strMensajeError = "" Then
                'If dtResultado.Rows.Count > 0 Then
                ' Obtenemos el contenido del archivo
                Dim strEtiqueta As String = My.Resources.txtEtiquetaBultoSINF_F01
                Dim strEtiquetaTemp As String = ""
                Dim intContador As Int32 = 0
                Dim intTemp As Int64 = 0
                Dim strCodigoActual As String = ""
                ' Iniciamos el Proceso
                'strEtiqueta = strEtiqueta.Replace("xUBICACION", ("" & dtResultado.Rows(0).Item("TUBRFR")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xPROVEEDOR", ("" & dtResultado.Rows(0).Item("TPRVCL")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xORDEN_COMPRA", ("" & dtResultado.Rows(0).Item("NORCML")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xGUIA_PROVEEDOR", ("" & dtResultado.Rows(0).Item("NGRPRV")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xOBSERVACIONES", ("" & dtResultado.Rows(0).Item("DESCWB")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xCANTIDAD", dtResultado.Rows(0).Item("QREFFW"))
                'strEtiqueta = strEtiqueta.Replace("xPESO", dtResultado.Rows(0).Item("QPSOBL"))
                'strEtiqueta = strEtiqueta.Replace("xNROWAYBILL", ("" & dtResultado.Rows(0).Item("CREFFW")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & dtResultado.Rows(0).Item("TLUGEN")).ToString.Trim)
                strEtiqueta = strEtiqueta.Replace("FF", intNroCopias)
                intTemp = intInicial
                While intTemp <= intFinal
                    strCodigoActual = strPrefijo & Microsoft.VisualBasic.Right("00000000" & intTemp, 6)
                    strEtiquetaTemp = strEtiqueta.Replace("R123456789", strCodigoActual)
                    intContador = 0
                    While intContador < intNroCopias
                        intContador += 1
                        lstrEtiquetaBulto.Add(strEtiquetaTemp.Replace("II", intContador))
                    End While
                    intTemp += 1
                End While
                'End If
            End If
            Return lstrEtiquetaBulto
        End Function

        ''' <summary>
        ''' Función que devuelve una lista de cadenas que contiene la respectiva etiqueta generada para la paleta.
        ''' </summary>
        Public Shared Function flstrEtiquetas_Paleta(ByVal objSqlManager As SqlManager, ByVal intCliente As Int64, ByVal strPaleta As String, _
                                                    ByVal intNroCopias As Int32, ByRef strMensajeError As String) As List(Of String)
            'Dim dtResultado As DataTable = Nothing
            Dim lstrEtiquetaPaletas As List(Of String) = New List(Of String)
            'dtResultado = fdtConsulta_Informacion(objSqlManager, strMensajeError, "SAT_GENE_ETIBTO_01", intCliente, strBulto)
            If strMensajeError = "" Then
                'If dtResultado.Rows.Count > 0 Then
                ' Obtenemos el contenido del archivo
                Dim strEtiqueta As String = My.Resources.txtEtiquetaPaletaSINF_F01
                Dim intContador As Int32 = 0
                ' Iniciamos el Proceso
                strEtiqueta = strEtiqueta.Replace("xNROPALETA", strPaleta)
                'strEtiqueta = strEtiqueta.Replace("xUBICACION", ("" & dtResultado.Rows(0).Item("TUBRFR")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xPROVEEDOR", ("" & dtResultado.Rows(0).Item("TPRVCL")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xORDEN_COMPRA", ("" & dtResultado.Rows(0).Item("NORCML")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xGUIA_PROVEEDOR", ("" & dtResultado.Rows(0).Item("NGRPRV")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xOBSERVACIONES", ("" & dtResultado.Rows(0).Item("DESCWB")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xCANTIDAD", dtResultado.Rows(0).Item("QREFFW"))
                'strEtiqueta = strEtiqueta.Replace("xPESO", dtResultado.Rows(0).Item("QPSOBL"))
                'strEtiqueta = strEtiqueta.Replace("xNROWAYBILL", ("" & dtResultado.Rows(0).Item("CREFFW")).ToString.Trim)
                'strEtiqueta = strEtiqueta.Replace("xDESTINO", ("" & dtResultado.Rows(0).Item("TLUGEN")).ToString.Trim)
                strEtiqueta = strEtiqueta.Replace("FF", intNroCopias)
                intContador = 0
                While intContador < intNroCopias
                    intContador += 1
                    lstrEtiquetaPaletas.Add(strEtiqueta.Replace("II", intContador))
                End While
                'End If
            End If
            Return lstrEtiquetaPaletas
        End Function

        ''' <summary>
        ''' Funcion que actualiza el campo de Impresión de la tablas RZOL65R para que no vuelva a ser considerada
        ''' en la relación de Bultos sin impresión de etiquetas de barras.
        ''' </summary>
        Public Shared Function fblnRegistrar_BultoEtiquetado(ByVal objSqlManager As SqlManager, ByVal oBulto As TD_BultoParaEtiquetar, _
                                                             ByRef strMensajeError As String) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oBulto.pintCliente)
                .Add("IN_CREFFW", oBulto.pstrBulto)
                '-- Seguridad
                .Add("IN_USUARIO", oBulto.pstrUsuario)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_ETIQUETA_BULTO_UPD_IMPR", objParametros)
                Dim htResultado As Hashtable
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRegistrar_BultoEtiquetada >> de la clase << daoEtiquetasBarras >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SAT_ETIQUETA_BULTO_UPD_IMPR >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        ''' <summary>
        ''' Funcion que actualiza el campo de Impresión de la tablas RZOL65P para que no vuelva a ser considerada
        ''' en la relación de paletas sin impresión de etiquetas de barras.
        ''' </summary>
        Public Shared Function fblnRegistrar_PaletaEtiquetada(ByVal objSqlManager As SqlManager, ByVal oPaleta As TD_PaletaParaEtiquetar, _
                                                              ByRef strMensajeError As String) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oPaleta.pintCliente)
                .Add("IN_NROPLT", oPaleta.pintNroPaleta)
                '-- Seguridad
                .Add("IN_USUARIO", oPaleta.pstrUsuario)
                .Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_ETIQUETA_PALETA_UPD_IMPR", objParametros)
                Dim htResultado As Hashtable
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRegistrar_PaletaEtiquetada >> de la clase << daoEtiquetasBarras >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SAT_ETIQUETA_PALETA_UPD_IMPR >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Shared Function fdtReporteMaterialReceivingReport(ByVal oBulto As TD_BultoParaEtiquetar) As DataSet
            Dim objParametros As Parameter = New Parameter
            Dim objSqlManager As New SqlManager
            ' Ingresamos los parametros del Procedure
            objParametros.Add("PSCREFFW", oBulto.pstrBulto)
            objParametros.Add("PNCCLNT", oBulto.pintCliente)
            objParametros.Add("IN_CCMPN", oBulto.pstrCompania)
            objParametros.Add("IN_CDVSN", oBulto.pstrDivision)
            objParametros.Add("IN_CPLNDV", oBulto.pdecPlanta)
            Dim dtTemp As DataSet
            Try
                dtTemp = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_MATERIAL_RECEIVING_REPORT", objParametros)
            Catch ex As Exception
                dtTemp = New DataSet
            Finally
                objParametros = Nothing
            End Try
            Return dtTemp
        End Function

#End Region
    End Class
End Namespace
