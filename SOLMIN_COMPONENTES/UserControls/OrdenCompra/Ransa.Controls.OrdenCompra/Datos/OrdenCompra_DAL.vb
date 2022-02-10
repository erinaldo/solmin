Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Configuration

Public Class OrdenCompra_DAL

    Public Function ListarOCDistintas(ByVal PNCCLNT As Decimal) As List(Of String)
        Dim oListOC As New List(Of String)
        Dim odt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        objParametros.Add("PNCCLNT", PNCCLNT)
        odt = objSqlManager.ExecuteDataTable("SP_LISTAR_OC_DISTINTAS_CLIENTE", objParametros)
        Dim NORCML As String = ""
        For Each Item As DataRow In odt.Rows
            NORCML = ("" & Item("NORCML")).ToString.Trim
            If Not oListOC.Contains(NORCML) And NORCML.Length <> 0 Then
                oListOC.Add(NORCML)
            End If
        Next
        Return oListOC
    End Function


    Public Function ListarServicio(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal pGUIARANSA As Decimal) As DataTable
        Dim odt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        objParametros.Add("IN_CCLNT", PNCCLNT)
        objParametros.Add("IN_NORCML", PSNORCML)
        objParametros.Add("IN_NRITOC", PNNRITOC)
        objParametros.Add("IN_GUIARANSA", pGUIARANSA)
        odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_SOLICITUD_SERVICIO_LM", objParametros)
        Return odt
    End Function

    Public Function ListarDetalleServicio(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNGUIRN As Decimal, ByVal PNNRITOC As Decimal) As DataTable
        Dim odt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        objParametros.Add("IN_CCLNT", PNCCLNT)
        objParametros.Add("IN_NORCML", PSNORCML)
        objParametros.Add("IN_NGUIRN", PNNGUIRN)
        objParametros.Add("IN_NRITOC", PNNRITOC)
        odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_SOLICITUD_SERVICIO_DETALLE_LM", objParametros)
        Return odt
    End Function


    Public Function ListarOCPlantas(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String) As DataTable
        Dim odt As New DataTable
        Dim dtBulto As New DataTable
        Dim ds As New DataSet
        Dim objParametros As Parameter = New Parameter
        Dim objSqlManager As New SqlManager
        objParametros.Add("PSCCMPN", PSCCMPN)
        objParametros.Add("PNCCLNT", PNCCLNT)
        objParametros.Add("PSNORCML", PSNORCML)
        ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC_PLANTAS", objParametros)
        odt = ds.Tables(0).Copy
        dtBulto = ds.Tables(1).Copy
        odt.Columns.Add("TOT_IN_CANTIDAD")
        odt.Columns.Add("TOT_SAL_CANTIDAD")
        odt.Columns.Add("TOT_IN_PESO")
        Dim Filtro As String = ""
        For Each Item As DataRow In odt.Rows
            Filtro = String.Format("CCMPN='{0}' AND CDVSN='{1}' AND CPLNDV='{2}' AND CCLNT='{3}'", Item("CCMPN"), Item("CDVSN"), Item("CPLNDV"), Item("CCLNT"))
            Item("TOT_IN_CANTIDAD") = dtBulto.Compute("SUM(QREFFW)", Filtro)
            Item("TOT_SAL_CANTIDAD") = dtBulto.Compute("SUM(QREFFW)", Filtro & " AND SSTINV='1'")
            Item("TOT_IN_PESO") = dtBulto.Compute("SUM(QPSOBL)", Filtro)
        Next
        Return odt
    End Function

    Public Function fdtsListarOcPendientes(ByVal nCodigo As Integer) As DataSet
        Dim db As Database = DatabaseFactory.CreateDatabase("CatalogoConnection")
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_LISTA_ORDEN_DE_COMPRA_PENDIENTE"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, nCodigo)

                Return db.ExecuteDataSet(dbcmd)
            Catch dbex As DbException

                Throw New System.Exception(dbex.Message)

            End Try
        End Using
    End Function



    Public Function fdtsObtenerOc(ByVal nCodigo As Integer, ByVal strOc As String) As DataSet
        Dim db As Database = DatabaseFactory.CreateDatabase("CatalogoConnection")
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_OBTENER_ORDEN_DE_COMPRA"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, nCodigo)
                db.AddInParameter(dbcmd, "@vc_PurchaseOrder", DbType.Int32, strOc)

                Return db.ExecuteDataSet(dbcmd)
            Catch dbex As DbException

                Throw New System.Exception(dbex.Message)

            End Try
        End Using
    End Function


    Public Function fintActualizarEstado(ByVal oParametro As Hashtable) As Integer
        Dim db As Database = DatabaseFactory.CreateDatabase("CatalogoConnection")
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_ACTUALIZAR_ORDEN_DE_COMPRA_DETALLE"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, oParametro.Item("CodCliente"))
                db.AddInParameter(dbcmd, "@in_PurchaseOrder", DbType.Int32, oParametro.Item("OC"))
                db.AddInParameter(dbcmd, "@in_PurchaseOrderLine", DbType.Int32, oParametro.Item("CodItem"))
                db.AddInParameter(dbcmd, "@vc_TipDoc", DbType.String, oParametro.Item("TipDoc"))
                db.AddInParameter(dbcmd, "@vc_norden", DbType.String, oParametro.Item("norden"))
                db.AddInParameter(dbcmd, "@vc_Usuario", DbType.String, oParametro.Item("Usuario"))

                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

    Public Function fintActualizarEstadoDetallePed(ByVal oParametro As Hashtable) As Integer
        Dim db As Database = DatabaseFactory.CreateDatabase("CatalogoConnection")
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_ACTUALIZAR_ORDEN_DE_COMPRA_DETALLE_PED"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@vc_TipDoc", DbType.String, oParametro.Item("TipDoc"))
                db.AddInParameter(dbcmd, "@vc_PurchaseOrder", DbType.String, oParametro.Item("NumDoc"))
                db.AddInParameter(dbcmd, "@in_PurchaseOrderLine", DbType.Int32, oParametro.Item("NumOrd"))

                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

End Class
