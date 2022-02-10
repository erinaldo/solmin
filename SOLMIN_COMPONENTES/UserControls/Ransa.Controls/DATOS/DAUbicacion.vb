Imports Ransa.DATA

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef
Imports RANSA.TypeDef.Mercaderia

Imports RANSA.TypeDef.beMercaderia
Imports RANSA.Utilitario

Public Class daUbicacion
    Inherits daBase(Of beUbicacion)


    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_MOVIMIENTO_POSICION_LISTAR"
        SPUpdate = "SP_SOLMIN_SA_MOVIMIENTO_POSICION_INSERT"
    End Sub

    Public Overrides Sub ToParameters(ByVal obj As beUbicacion)
        With obj
            SetParameter(.PSCTPALM)
            SetParameter(.PSCALMC)
            SetParameter(.PSCSECTR)
            SetParameter(.PSCPSCN)
            SetParameter(.PNNORDSR)
            SetParameter(.PNNCRRIN)
            SetParameter(.PNNSLCSR)
            SetParameter(.PNFTRNS)
            SetParameter(.PNQTRMC1)
            SetParameter(.PSCCMPN)
            SetParameter(.PSCDVSN)
            SetParameter(.PNCSRVC)
            SetParameter(.PSCUSCRT)
            SetParameter(.PNFCHCRT)
            SetParameter(.PNHRACRT)
            SetParameter(.PSNTRMCR)
            SetParameter(.PNFULTAC)
            SetParameter(.PNHULTAC)
            SetParameter(.PSCULUSA)
            SetParameter(.PSNTRMNL)
            SetParameter(.PSSESTRG)
            SetParameter(.PNNGUIRN)
            SetParameter(.PNUPDATE_IDENT)
        End With
    End Sub

    'CSR-HUNDRED
    Public Function ListarDespachos(ByVal nOrdenServicio As Int32, ByVal sTipoAlmacen As String, ByVal sAlmacen As String, ByVal sZona As String, ByVal nPedido As Int32, ByVal nLote As Int32)
        Return Me.Listar("SP_SOLMIN_SA_MOVIMIENTO_POSICION_LISTAR_DESPACHO", nOrdenServicio, sTipoAlmacen, sAlmacen, sZona, nPedido, nLote)
    End Function

    Public Sub RegistrarInventario_X_Ubicacion(ByVal obj As beUbicacion)
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As New Parameter
        With objParametros
            .Add("PSCTPALM", obj.PSCTPALM)
            .Add("PSCALMC", obj.PSCALMC)
            .Add("PSCSECTR", obj.PSCSECTR)
            .Add("PSCPSCN", obj.PSCPSCN)
            .Add("PNNORDSR", obj.PNNORDSR)
            .Add("PNNCRRIN", obj.PNNCRRIN)
            .Add("PNNSLCSR", obj.PNNSLCSR)
            .Add("PNFTRNS", obj.PNFTRNS)
            .Add("PNQTRMC1", obj.PNQTRMC1)
            .Add("PSCCMPN", obj.PSCCMPN)
            .Add("PSCDVSN", obj.PSCDVSN)
            '.Add("PNCSRVC", obj.PNCSRVC)
            .Add("PNCSRVC", obj.PNCSRVC)
            .Add("PSCULUSA", obj.PSCULUSA)
            .Add("PSNTRMNL", obj.PSNTRMNL)
            .Add("PNNGUIRN", obj.PNNGUIRN)
        End With
        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_MOVIMIENTO_POSICION_INSERT", objParametros)

    End Sub
End Class
