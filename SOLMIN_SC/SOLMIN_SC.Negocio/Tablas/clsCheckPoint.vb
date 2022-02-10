Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsCheckPoint
    Private oCheckPoint As Datos.clsCheckPoint
    Private oDtCliente As DataTable

    Sub New()
        oCheckPoint = New Datos.clsCheckPoint
    End Sub

    Property Lista_Cliente()
        Get
            Return Me.oDtCliente
        End Get
        Set(ByVal value)
            Me.oDtCliente = value
        End Set
    End Property

    Public Sub Crea_Lista_X_Cliente(ByVal PNCCLNT As Double, ByVal PSCCMPN As String, ByVal PSCDVSN As String)
        oDtCliente = oCheckPoint.Lista_CheckPoint(PNCCLNT, PSCCMPN, PSCDVSN)
    End Sub

   

    Public Sub Mant_CheckPoint_X_Cliente(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pstrTipo As String, ByVal PNCCLNT As Decimal, ByVal pdblCheck As Double, ByVal pstrTituloName As String, ByVal pstrEstAsigna As String, ByVal pstrEstGrilla As String, Optional ByVal OrdenCheckPoint As Double = 0)
        oCheckPoint.Mant_CheckPoint_X_Cliente(PSCCMPN, PSCDVSN, pstrTipo, PNCCLNT, pdblCheck, pstrTituloName, pstrEstAsigna, pstrEstGrilla, OrdenCheckPoint)
    End Sub

    Public Sub Mant_CheckPoint_X_Item(ByVal pstrTipo As String, ByVal PNCCLNT As Decimal, ByVal pstrOC As String, ByVal pdblItem As Double, ByVal pdblParcial As Double, ByVal pdblCant As Double, ByVal pdblCheck As Double, ByVal pdblMestdo As Double, ByVal pdblFecha As Double, ByVal pstrEst As String, Optional ByRef oSqlMan As SqlManager = Nothing)
        If oSqlMan Is Nothing Then
            oCheckPoint.Mant_CheckPoint_X_Item(pstrTipo, PNCCLNT, pstrOC, pdblItem, pdblParcial, pdblCant, pdblCheck, pdblMestdo, pdblFecha, pstrEst)
        Else
            oCheckPoint.Mant_CheckPoint_X_Item(oSqlMan, pstrTipo, PNCCLNT, pstrOC, pdblItem, pdblParcial, pdblCant, pdblCheck, pdblMestdo, pdblFecha, pstrEst)
        End If
        
    End Sub

    Public Function Lista_CheckPoint_X_PreEmbarque(ByVal PNCCLNT As Decimal, ByVal pstrOC As String, ByVal pdblParcial As Double) As DataTable
        Return oCheckPoint.Lista_CheckPoint_X_PreEmbarque(PNCCLNT, pstrOC, pdblParcial)
    End Function

    Public Function Lista_CheckPoint_X_Embarque(ByVal obeParamCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim oListCheckPoint As New List(Of beCheckPoint)
        oListCheckPoint = oCheckPoint.Lista_CheckPoint_X_Embarque(obeParamCheckPoint)
        Return oListCheckPoint
    End Function
    
    Public Function Cargar_Tipo_CheckPoint(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oCheckPoint.Cargar_Tipo_CheckPoint().Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = ""
            objDr(1) = ""
            objDr(2) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Function Lista_CheckPoint_X_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PSCEMB As String, ByVal PSSESTRG As String) As DataTable
        Return oCheckPoint.Lista_CheckPoint_X_Cliente(PNCCLNT, PSCCMPN, PSCDVSN, PSCEMB, PSSESTRG)
    End Function

    Public Function Buscar_CheckPoint_X_Cliente(ByVal PNCCLNT As Decimal, ByVal pstrTipoCheckpoint As String, ByVal pstrEstado As String, ByVal pstrCheckpoint As String, ByVal PSCCMPN As String, ByVal PSCDVSN As String) As DataTable
        Return oCheckPoint.Buscar_CheckPoint_X_Cliente(PNCCLNT, PSCCMPN, PSCDVSN, pstrTipoCheckpoint, pstrEstado, pstrCheckpoint)
    End Function

    Public Function Buscar_Maestro_CheckPoint(ByVal Compania As String, ByVal division As String) As DataTable
        Return oCheckPoint.Buscar_Maestro_CheckPoint(Compania, division)
    End Function

    Public Sub Modificar_Maestro_CheckPoint(ByVal CCMPN As String, ByVal CDVSN As String, ByVal NESTDO As Decimal, ByVal TDESES As String, ByVal CEMB As String, ByVal USER As String)
        oCheckPoint.Modificar_Maestro_CheckPoint(CCMPN, CDVSN, NESTDO, TDESES, CEMB, USER)
    End Sub

    Public Sub Insertar_Maestro_CheckPoint(ByVal CCMPN As String, ByVal CDVSN As String, ByVal TDESES As String, ByVal CEMB As String, ByVal USER As String)
        oCheckPoint.Insertar_Maestro_CheckPoint(CCMPN, CDVSN, TDESES, CEMB, USER)
    End Sub

    Public Sub Eliminar_Maestro_CheckPoint(ByVal NESTDO As Decimal, ByVal USER As String)
        oCheckPoint.Eliminar_Maestro_CheckPoint(NESTDO, USER)
    End Sub

    Public Function Buscar_CheckPoint_X_Cliente_Sec(ByVal PNCCLNT As Decimal, ByVal pstrTipoCheckpoint As String, ByVal pstrCheckpoint As String, ByVal PSCCMPN As String, ByVal PSCDVSN As String) As DataTable
        Return oCheckPoint.Buscar_CheckPoint_X_Cliente_Sec(PNCCLNT, PSCCMPN, PSCDVSN, pstrTipoCheckpoint, pstrCheckpoint)
    End Function

    Public Function Lista_CheckPoint_X_Tipo(ByVal pstrTipo As String) As DataTable
        Return oCheckPoint.Lista_CheckPoint_X_Tipo(pstrTipo)
    End Function

    Public Function Lista_CheckPoint_X_Division(ByVal division As String) As DataTable
        Return oCheckPoint.Lista_CheckPoint_X_Division(division)
    End Function

    Public Sub Actualizar_Orden_Checkpoint(ByVal obeParamCheckPoint As beCheckPoint)
        oCheckPoint.Actualizar_Orden_Checkpoint(obeParamCheckPoint)
      
    End Sub

    Public Sub Grabar_Checkpoint_X_Preembarque(ByVal obeParamCheckPoint As beCheckPoint)
        oCheckPoint.Grabar_Checkpoint_X_Preembarque(obeParamCheckPoint)
    End Sub
    Public Function Lista_All_CheckPoint_X_Cliente(ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String, ByVal PSCDVSN As String) As DataTable
        Return oCheckPoint.Lista_All_CheckPoint_X_Cliente(PNCCLNT, PSCCMPN, PSCDVSN)
    End Function

    Public Sub Actualizar_Checkpoint(ByVal obeParamCheckPoint As beCheckPoint)
        oCheckPoint.Actualizar_Checkpoint(obeParamCheckPoint)
    End Sub

    Public Function Lista_CheckPoint_X_Embarque_X_Tipo(ByVal obeParamCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim oListCheckPoint As New List(Of beCheckPoint)
        oListCheckPoint = oCheckPoint.Lista_CheckPoint_X_Embarque_X_Tipo(obeParamCheckPoint)
        Return oListCheckPoint
    End Function

    Public Function DevuelveURL_CheckPoint(ByVal PSPROCWS As String, ByVal PNCCLNT As String) As DataTable
        Return oCheckPoint.DevuelveURL_CheckPoint(PSPROCWS, PNCCLNT)
    End Function


    Public Function DevuelveDataJSON_CheckPoint(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataTable
        Return oCheckPoint.DevuelveDataJSON_CheckPoint(Compania, CodCliente, CodEmbarque)
    End Function


    Public Function Lista_DataJSON_TramaTracking(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataSet
        Return oCheckPoint.Lista_DataJSON_TramaTracking(Compania, CodCliente, CodEmbarque)
    End Function

    Public Function ListarChkTracking(ByVal Compania As String, ByVal CodCliente As Decimal, ByVal CodEmbarque As Decimal) As DataTable
        Return oCheckPoint.ListarChkTracking(Compania, CodCliente, CodEmbarque)
    End Function


End Class
