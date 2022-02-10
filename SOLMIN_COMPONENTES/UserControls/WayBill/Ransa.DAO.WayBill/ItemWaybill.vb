Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.WayBill

Public Class cItemWayBill
    Implements IDisposable
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private oSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private pUsuario As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property ErrorMessage() As String
        Get
            Return sErrorMessage
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New(ByVal Usuario As String)
        oSqlManager = New SqlManager
        pUsuario = Usuario
    End Sub

    ''' <summary>
    ''' Procedimiento para Grabar un Item del Bulto
    ''' </summary>
    Public Function Grabar(ByRef ItemBulto As TD_Obj_ItemBulto) As Boolean
        Dim objParametros As Parameter = Nothing
        Dim blnResultado As Boolean = True
        objParametros = New Parameter
        With ItemBulto
            objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
            objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
            objParametros.Add("IN_NSEQIN", .PNSEQIN_NrCorrelativo)
            objParametros.Add("IN_NORCML", .pNORCML_NroOrdenCompra)
            objParametros.Add("IN_NRITOC", .pNRITOC_NroItemOC)
            objParametros.Add("IN_NFACPR", .pNFACPR_NroFacturaProveedor)
            objParametros.Add("IN_FFACPR", .pFFACPR_FechaFacturaProveedor_Num)
            objParametros.Add("IN_NGRPRV", .pNGRPRV_NroGuiaRemisionProveedor)
            objParametros.Add("IN_QBLTSR", .pQBLTSR_CantidadRecibida)
            objParametros.Add("IN_QPEPQT", .pQPEPQT_PesoCantRecibida)
            objParametros.Add("IN_TUNPSO", .pTUNPSO_UnidadPeso)
            objParametros.Add("IN_QVOPQT", .pQVOPQT_VolumenCantRecibida)
            objParametros.Add("IN_TUNVOL", .pTUNVOL_UnidadVolumen)
            objParametros.Add("IN_TDAITM", .pTDAITM_Observaciones)
            objParametros.Add("IN_USUARI", pUsuario)
            If .pESTADO_estado.Trim.ToUpper.Equals("DEVOLUCION") Then
                objParametros.Add("IN_ESTADO", .pESTADO_estado)
            End If

            'Adicioanles
            objParametros.Add("IN_CCMPN", .pCCMPN_CodigoCompania)
            objParametros.Add("IN_CDVSN", .pCDVSN_CodigoDivision)
            objParametros.Add("IN_CPLNDV", .pCPLNDV_CodigoPlanta)

            objParametros.Add("OU_CIDPAQ", "", ParameterDirection.Output)
            ' Registramos el Bulto asociado a la Paleta


            'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
            objParametros.Add("IN_CMATPE", .pCMATPE_CboCondicionGrilla)
            objParametros.Add("IN_FGIQBF", .pFGIQBF_CheckGrilla)
            objParametros.Add("IN_CCLMAT", .pCCLMAT_CboValorGrilla)
            objParametros.Add("IN_CPRFUN", .pCPRFUN_DesUnGrilla)
            objParametros.Add("IN_CUNMAT", .pCUNMAT_CodUnGrilla)
            objParametros.Add("IN_FCHCAD", .pFCHCAD_FechaGrilla)
            'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

            ' objParametros.Add("IN_FCHCAD", .pCIDPAQ_CodItentificadorPaquetes)
            Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_BULTO_INSET", objParametros)
                .pCIDPAQ_CodItentificadorPaquetes = oSqlManager.ParameterCollection("OU_CIDPAQ").ToString
            Catch ex As Exception
                sErrorMessage = "Error producido en la funcion : << Grabar >> de la clase << cItemWayBill >> " & vbNewLine & _
                                "Tipo de Consulta : SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_INS " & vbNewLine & _
                                "Motivo del, Error : " & ex.Message
                blnResultado = False
            End Try
        End With
        Return blnResultado
    End Function

    ''' <summary>
    ''' Procedimiento para Grabar una lista de Items del Bulto
    ''' </summary>
    Public Function Grabar(ByRef lstItemsBulto As List(Of TD_Obj_ItemBulto)) As Boolean
        Dim blnResultado As Boolean = True
        Dim oTemp As TD_Obj_ItemBulto = New TD_Obj_ItemBulto
        ' Ingresamos los parametros del Procedure
        With oTemp
            For Each oTemp In lstItemsBulto
                blnResultado = Grabar(oTemp)
                If Not blnResultado Then Exit For
            Next
        End With
        Return blnResultado
    End Function

    ''' <summary>
    ''' Actualiza El campo  custodia
    ''' </summary>
    ''' <param name="ItemBulto">Entidad Bulto</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCustodia(ByVal ItemBulto As TD_Obj_ItemBulto) As Boolean
        Dim objParametros As Parameter = Nothing
        Dim blnResultado As Boolean = True
        objParametros = New Parameter
        ' Ingresamos los parametros del Procedure
        With ItemBulto
            objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
            objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
            objParametros.Add("IN_NORCML", .pNORCML_NroOrdenCompra)
            objParametros.Add("IN_NRITOC", .pNRITOC_NroItemOC)
            objParametros.Add("IN_CIDPAQ", .pCIDPAQ_CodItentificadorPaquetes)
            objParametros.Add("IN_MARRET", .pMARRET_MarcaRetencion)
            objParametros.Add("IN_CULUSA", pUsuario)
            ' Registramos el Bulto asociado a la Paleta
            Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_UPD_CUSTODIA", objParametros)
            Catch ex As Exception
                sErrorMessage = "Error producido en la funcion : << Grabar >> de la clase << cItemWayBill >> " & vbNewLine & _
                                "Tipo de Consulta : SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_UPD_CUSTODIA " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
                blnResultado = False
            End Try
        End With
        Return blnResultado
    End Function
#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                oSqlManager.Dispose()
                oSqlManager = Nothing
            End If
            ' TODO: Liberar recursos no administrados compartidos
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