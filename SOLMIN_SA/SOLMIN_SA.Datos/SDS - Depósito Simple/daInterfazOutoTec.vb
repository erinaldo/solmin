Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Microsoft.Practices.EnterpriseLibrary.Data


Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Configuration

Public Class daInterfazOutoTec

    Public Function fintInsertarCabeceraProceso(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_INSERTAR_CABECERA_PROCESO"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@ctpdoc", DbType.String, oParametro.ctpdoc)
                db.AddInParameter(dbcmd, "@npensa", DbType.Int32, oParametro.npensa)
                db.AddInParameter(dbcmd, "@codcli", DbType.String, oParametro.codcli)
                db.AddInParameter(dbcmd, "@calmac", DbType.String, oParametro.calmac)
                db.AddInParameter(dbcmd, "@femisi", DbType.Date, oParametro.femisi)
                db.AddInParameter(dbcmd, "@cconce", DbType.String, oParametro.cconce)
                db.AddInParameter(dbcmd, "@ctpode", DbType.String, oParametro.ctpode)
                db.AddInParameter(dbcmd, "@coride", DbType.String, oParametro.coride)
                db.AddInParameter(dbcmd, "@ctpref", DbType.String, oParametro.ctpref)
                db.AddInParameter(dbcmd, "@ndcref", DbType.String, oParametro.ndcref)
                db.AddInParameter(dbcmd, "@dobser", DbType.String, oParametro.dobser)
                db.AddInParameter(dbcmd, "@ctporc", DbType.String, oParametro.ctporc)
                db.AddInParameter(dbcmd, "@nordco", DbType.String, oParametro.nordco)
                db.AddInParameter(dbcmd, "@nordpr", DbType.String, oParametro.nordpr)
                db.AddInParameter(dbcmd, "@noccli", DbType.String, oParametro.noccli)
                db.AddInParameter(dbcmd, "@ccosto", DbType.String, oParametro.ccosto)
                db.AddInParameter(dbcmd, "@icosmn", DbType.Double, oParametro.icosmn)
                db.AddInParameter(dbcmd, "@icosme", DbType.Double, oParametro.icosme)
                db.AddInParameter(dbcmd, "@dvisbu", DbType.String, oParametro.dvisbu)
                db.AddInParameter(dbcmd, "@spensa", DbType.String, oParametro.spensa)
                db.AddInParameter(dbcmd, "@fstatu", DbType.Date, oParametro.fstatu)
                db.AddInParameter(dbcmd, "@cmtanu", DbType.String, oParametro.cmtanu)
                db.AddInParameter(dbcmd, "@sregul", DbType.String, oParametro.sregul)
                db.AddInParameter(dbcmd, "@stempo", DbType.String, oParametro.stempo)
                db.AddInParameter(dbcmd, "@cusuar", DbType.String, oParametro.cusuar)
                db.AddInParameter(dbcmd, "@itpcam", DbType.Double, oParametro.itpcam)
                db.AddInParameter(dbcmd, "@sgaran", DbType.String, oParametro.sgaran)

                db.AddInParameter(dbcmd, "@sentat", DbType.String, oParametro.sentat)
                db.AddInParameter(dbcmd, "@semboc", DbType.String, oParametro.semboc)

                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1
            End Try
        End Using
    End Function

    Public Function fintInsertarDetalleProceso(ByVal oParametro As beDetInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_INSERTAR_DETALLE_PROCESO"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@ctpdoc", DbType.String, oParametro.ctpdoc)
                db.AddInParameter(dbcmd, "@npensa", DbType.Int32, oParametro.npensa)
                db.AddInParameter(dbcmd, "@codcli", DbType.String, oParametro.codcli)
                db.AddInParameter(dbcmd, "@norden", DbType.Int32, oParametro.norden)
                db.AddInParameter(dbcmd, "@citems", DbType.String, oParametro.citems)
                db.AddInParameter(dbcmd, "@nserie", DbType.String, oParametro.nserie)
                db.AddInParameter(dbcmd, "@cunmed", DbType.String, oParametro.cunmed)
                db.AddInParameter(dbcmd, "@qitems", DbType.Double, oParametro.qitems)
                db.AddInParameter(dbcmd, "@qunida", DbType.Double, oParametro.qunida)
                db.AddInParameter(dbcmd, "@icosmn", DbType.Double, oParametro.icosmn)
                db.AddInParameter(dbcmd, "@icosme", DbType.Double, oParametro.icosme)
                db.AddInParameter(dbcmd, "@cubica", DbType.String, oParametro.cubica)
                db.AddInParameter(dbcmd, "@norped", DbType.Int16, oParametro.norped)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

    Public Function fintInsertarProyectoProceso(ByVal oParametro As beDetInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_INSERTAR_PROYECTO_PROCESO"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@ctpdoc", DbType.String, oParametro.ctpdoc)
                db.AddInParameter(dbcmd, "@npensa", DbType.Int32, oParametro.npensa)
                db.AddInParameter(dbcmd, "@norden", DbType.Int32, oParametro.norden)
                db.AddInParameter(dbcmd, "@citems", DbType.String, oParametro.citems)
                db.AddInParameter(dbcmd, "@nordpr", DbType.String, oParametro.nordpr)
                db.AddInParameter(dbcmd, "@qitems", DbType.Double, oParametro.qitems)
                db.AddInParameter(dbcmd, "@cubica", DbType.String, oParametro.cubica)

                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

    Public Function fintProveedorPerteneceAlmacen(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_PROVEEDOR_PERTENECE_ALMACEN"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@cprove", DbType.String, oParametro.cprove)
                db.AddInParameter(dbcmd, "@calmac", DbType.String, oParametro.calmac)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

    Public Function fintAnularProcesoIngDesp(ByVal oParametro As beCabInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.[SP_ANULAR_PARTE_INOUT]"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@CodCliente", DbType.Int64, oParametro.codCliente)
                db.AddInParameter(dbcmd, "@npensa", DbType.Int64, oParametro.npensa)
                db.AddInParameter(dbcmd, "@ctpdoc", DbType.String, oParametro.ctpdoc)
                db.AddInParameter(dbcmd, "@vc_usuario", DbType.String, oParametro.usuario)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function




#Region " Pedido"

    Public Function flistObtenerPedidoOutotec(ByVal oParametro As beCabInfzPedidoOuototec) As DataSet
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_OBTENER_PEDIDO"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, oParametro.in_CodCliente)
                db.AddInParameter(dbcmd, "@nordpe", DbType.String, oParametro.nordpe)
                db.AddInParameter(dbcmd, "@ctpope", DbType.String, oParametro.ctpope)
                Return db.ExecuteDataSet(dbcmd)
            Catch dbex As DbException
                Throw New System.Exception(dbex.Message)
            End Try
        End Using
    End Function

    Public Function flistPedidosPendientesOutotec(ByVal oParametro As beCabInfzPedidoOuototec) As DataSet
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.[SP_LISTA_PEDIDOS_PENDIENTES]"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, oParametro.in_CodCliente)
                Return db.ExecuteDataSet(dbcmd)
            Catch dbex As DbException
                Throw New System.Exception(dbex.Message)
            End Try
        End Using
    End Function

    Public Function fintActualizarPedidosOutotec(ByVal oParametro As beDetInfzPedidoOuototec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "[SP_ACTUALIZAR_ESTADO_PEDIDO]"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@in_CodCliente", DbType.Int32, oParametro.codcli)
                db.AddInParameter(dbcmd, "@nordpe", DbType.String, oParametro.nordpe)
                db.AddInParameter(dbcmd, "@norden", DbType.Int32, oParametro.norden)
                db.AddInParameter(dbcmd, "@vc_Usuario", DbType.String, oParametro.usuario)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Throw New System.Exception(dbex.Message)
            End Try
        End Using
    End Function


    Public Function fintInsertarCabeceraGuia(ByVal oParametro As beCabGuiaInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.[SP_INSERTAR_CABECERA_GUIA]"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@nguias", DbType.String, oParametro.nguias)
                db.AddInParameter(dbcmd, "@codcli", DbType.String, oParametro.codcli)
                db.AddInParameter(dbcmd, "@nserof", DbType.String, oParametro.nserof)
                db.AddInParameter(dbcmd, "@ndocof", DbType.String, oParametro.ndocof)
                db.AddInParameter(dbcmd, "@ctpdoc", DbType.String, oParametro.ctpdoc)
                db.AddInParameter(dbcmd, "@npensa", DbType.Int64, oParametro.npensa)
                db.AddInParameter(dbcmd, "@femisi", DbType.Date, oParametro.femisi)

                If oParametro.finitr <> Nothing Then
                    db.AddInParameter(dbcmd, "@finitr", DbType.Date, oParametro.finitr)
                Else
                    db.AddInParameter(dbcmd, "@finitr", DbType.Date, DBNull.Value)
                End If


                db.AddInParameter(dbcmd, "@ctpope", DbType.String, oParametro.ctpope)
                db.AddInParameter(dbcmd, "@nordpr", DbType.String, oParametro.nordpr)
                db.AddInParameter(dbcmd, "@nordcl", DbType.String, oParametro.nordcl)
                db.AddInParameter(dbcmd, "@clcori", DbType.String, oParametro.clcori)
                db.AddInParameter(dbcmd, "@ddiori", DbType.String, oParametro.ddiori)
                db.AddInParameter(dbcmd, "@ctpode", DbType.String, oParametro.ctpode)
                db.AddInParameter(dbcmd, "@coride", DbType.String, oParametro.coride)
                db.AddInParameter(dbcmd, "@ddirec01", DbType.String, oParametro.ddirec01)
                db.AddInParameter(dbcmd, "@dvehic", DbType.String, oParametro.dvehic)
                db.AddInParameter(dbcmd, "@nconst", DbType.String, oParametro.nconst)
                db.AddInParameter(dbcmd, "@nplaca01", DbType.String, oParametro.nplaca01)
                db.AddInParameter(dbcmd, "@dobser", DbType.String, oParametro.dobser)
                db.AddInParameter(dbcmd, "@ctpfac", DbType.String, oParametro.ctpfac)
                db.AddInParameter(dbcmd, "@nfactu01", DbType.String, oParametro.nfactu01)

                If oParametro.fecdoc <> Nothing Then
                    db.AddInParameter(dbcmd, "@fecdoc", DbType.Date, oParametro.fecdoc)
                Else
                    db.AddInParameter(dbcmd, "@fecdoc", DbType.Date, DBNull.Value)
                End If

                db.AddInParameter(dbcmd, "@senlac", DbType.String, oParametro.senlac)
                db.AddInParameter(dbcmd, "@sguias", DbType.String, oParametro.sguias)
                'db.AddInParameter(dbcmd, "@fstatu", DbType.Date, oParametro.fstatu)
                db.AddInParameter(dbcmd, "@ctpgui", DbType.String, oParametro.ctpgui)
                db.AddInParameter(dbcmd, "@dtpgui", DbType.String, oParametro.dtpgui)
                db.AddInParameter(dbcmd, "@cusuar", DbType.String, oParametro.cusuar)
                db.AddInParameter(dbcmd, "@sgepes", DbType.String, oParametro.sgepes)
                db.AddInParameter(dbcmd, "@drztra", DbType.String, oParametro.drztra)
                db.AddInParameter(dbcmd, "@cructr", DbType.String, oParametro.cructr)
                db.AddInParameter(dbcmd, "@dchofe", DbType.String, oParametro.dchofe)
                db.AddInParameter(dbcmd, "@nbreve", DbType.String, oParametro.nbreve)
                db.AddInParameter(dbcmd, "@cciatr", DbType.String, oParametro.cciatr)
                db.AddInParameter(dbcmd, "@cchofe", DbType.String, oParametro.cchofe)
                db.AddInParameter(dbcmd, "@qtotpe", DbType.String, oParametro.qtotpe)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1
            End Try
        End Using
    End Function

    Public Function fintInsertarDetalleGuia(ByVal oParametro As beDetGuiaInfzOutotec) As Integer
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.[SP_INSERTAR_DETALLE_GUIA]"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@nguias", DbType.Int64, oParametro.nguias)
                db.AddInParameter(dbcmd, "@codcli", DbType.String, oParametro.codcli)
                db.AddInParameter(dbcmd, "@norden", DbType.Int32, oParametro.norden)
                db.AddInParameter(dbcmd, "@citems", DbType.String, oParametro.citems)
                db.AddInParameter(dbcmd, "@ditems", DbType.String, oParametro.ditems)
                db.AddInParameter(dbcmd, "@nserie", DbType.String, oParametro.nserie)
                db.AddInParameter(dbcmd, "@cunmed", DbType.String, oParametro.cunmed)
                db.AddInParameter(dbcmd, "@qitems", DbType.Decimal, oParametro.qitems)
                db.AddInParameter(dbcmd, "@qunida", DbType.String, oParametro.qunida)
                db.AddInParameter(dbcmd, "@qsaldo", DbType.String, oParametro.qsaldo)
                Return db.ExecuteScalar(dbcmd)
            Catch dbex As DbException
                Return -1

            End Try
        End Using
    End Function

    ''' <summary>
    ''' Lista de Pedido por Item
    ''' </summary>
    ''' <param name="oParametro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flistObtenerPedidoOutotecXItem(ByVal oParametro As beDetInfzPedidoOuototec) As DataSet
        Dim db As Database
        If ConfigurationWizard.Library() = "DC@DESLIB" Then
            db = DatabaseFactory.CreateDatabase("CatalogoConnectionPrueba")
        Else
            db = DatabaseFactory.CreateDatabase("CatalogoConnection")
        End If
        Using ObjCnn As DbConnection = db.CreateConnection()

            Try
                Dim lcsStore As String = "dbo.SP_LISTA_PEDIDOS_X_ITEM"
                Dim dbcmd As DbCommand = ObjCnn.CreateCommand()
                dbcmd = db.GetStoredProcCommand(lcsStore)
                db.AddInParameter(dbcmd, "@nordpe", DbType.String, oParametro.nordpe)
                db.AddInParameter(dbcmd, "@citems", DbType.String, oParametro.citems)
                Return db.ExecuteDataSet(dbcmd)
            Catch dbex As DbException
                Throw New System.Exception(dbex.Message)
            End Try
        End Using
    End Function


#End Region
End Class
