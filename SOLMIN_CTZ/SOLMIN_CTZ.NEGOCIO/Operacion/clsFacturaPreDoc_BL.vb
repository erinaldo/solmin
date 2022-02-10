Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class clsFacturaPreDoc_BL
    Private objCompaniaDato As New clsFacturaPreDoc_DA
    Private oDt As List(Of ClaseGeneral)
    Private objDataAccessLayer As New clsFacturaPreDoc_DA
    Private ldblCodCompania As String

    Private oDivisionDato As New clsFacturaPreDoc_DA

    Public Function Listar_Liquidacion_ADMIN(ByVal oEntidad As FacturaPreDoc_BE, codTipoVista As String) As DataTable
        Return objDataAccessLayer.Lista_Liquidacion_ADMIN(oEntidad, codTipoVista)
    End Function
    Public Sub Anular_Liquidacion_ADMIN(ByVal objListFactura_Transporte As List(Of FacturaPreDoc_BE))
        'Try
        For Each objEntidad As FacturaPreDoc_BE In objListFactura_Transporte
            objDataAccessLayer.Anular_PreLiquidacion_Admin(objEntidad)
        Next
        '      Return 1
        'Catch ex As Exception
        '          Return 0
        '      End Try

    End Sub
    Public Function Listar_Operaciones_PreLiquidacion(ByVal objParametros As Hashtable) As DataTable
        Return objDataAccessLayer.Listar_Operaciones_PreLiquidacion(objParametros)
    End Function
    Public Function ListarPLDocumentos_ADMIN(ByVal obePreDoc As FacturaPreDoc_BE) As DataTable
        Return objDataAccessLayer.ListarPLDocumentos_ADMIN(obePreDoc)
    End Function
    
    Public Function ListaDatosLiquidacion_ADMIN(ByVal objParametros As Hashtable) As DataTable
        Return objDataAccessLayer.ListaDatosAdPreLiquidacion(objParametros)
    End Function
    Public Sub ActualizarDatosLiquidacion_ADMIN(ByVal objParametros As Hashtable)
        objDataAccessLayer.ActualizarDatosLiquidacion_admin(objParametros)
    End Sub
    Public Function Listar_PreLiquidacion_Factura(ByVal objetoParametro As Hashtable) As List(Of FacturaPreDoc_BE)
        Return objDataAccessLayer.Listar_PreLiquidacion_Factura(objetoParametro)
    End Function
    Public Function Lista_Tipo_Cambio(ByVal objParametro As Hashtable) As DataTable
        Return objDataAccessLayer.Lista_Tipo_Cambio(objParametro)
    End Function

    Public Function Listar_Liquidacion(ByVal objetoParametro As Hashtable) As List(Of FacturaPreDoc_BE)
        Return objDataAccessLayer.Listar_Liquidacion(objetoParametro)
    End Function

    '--------------COMPANIA---------------------------------------------------
    Sub New()
        objCompaniaDato = New clsFacturaPreDoc_DA

    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Sub Crea_Lista()
        oDt = objCompaniaDato.Lista_Compania_X_Usuario()
    End Sub

    '--------------------------DIVISION--------------------------

    Public Function Lista_Division(ByVal pdblCodCompania As String) As List(Of Entidades.mantenimientos.ClaseGeneral)
        ldblCodCompania = pdblCodCompania
        'oDt.FindAll(match_Total)

        Return oDt.FindAll(match_Total)
    End Function

    Private match_Total As New Predicate(Of Entidades.mantenimientos.ClaseGeneral)(AddressOf Busca_Total)

    Public Function Busca_Total(ByVal RolOpcionBE As Entidades.mantenimientos.ClaseGeneral) As Boolean
        If (RolOpcionBE.CCMPN = ldblCodCompania) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub Crea_ListaD(Optional ByVal strCompania As String = "EZ")
        oDt = oDivisionDato.Lista_Division_X_Usuario(strCompania)
    End Sub
    'Public Function Listar_Revisiones_ADMIN(ByVal oEntidad As FacturaPreDoc_BE) As DataTable
    '    Return objDataAccessLayer.Lista_Revision_ADMIN(oEntidad)
    'End Function


    Public Function ListarPreFacturas_x_PreLiquidacion(ByVal objetoParametro As Hashtable) As DataTable 'List(Of FacturaPreDoc_BE)
        Return objDataAccessLayer.ListarPreFacturas_x_PreLiquidacion(objetoParametro)
    End Function
    Public Function Listar_PreFactura(ByVal objetoParametro As Hashtable) As DataTable ' List(Of FacturaPreDoc_BE)
        Return objDataAccessLayer.Listar_PreFactura(objetoParametro)
    End Function


    Public Function Quitar_Pre_Factura(ByVal objListFactura_Transporte As List(Of FacturaPreDoc_BE)) As Integer
        'Try
        For Each objEntidad As FacturaPreDoc_BE In objListFactura_Transporte
            objDataAccessLayer.Quitar_Pre_Factura(objEntidad)
        Next
        Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try

    End Function


    Public Function Actualizar_PreLiquidacion(ByVal objEntidad As FacturaPreDoc_BE, ByVal NSECFC As String) As String  'PreLiquidar_BE
      
        Return objDataAccessLayer.Actualizar_PreLiquidacion(objEntidad, NSECFC)
       
    End Function

End Class
