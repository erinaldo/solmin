Imports RANSA.TYPEDEF
Public Class TipoTransporte
    Public Function Listar_Tipo_Transporte() As List(Of TD_TipoTransporte)
        Dim oListTipoTransporte As New List(Of TD_TipoTransporte)
        Dim obeTipoTRansporte As TD_TipoTransporte

        obeTipoTRansporte = New TD_TipoTransporte
        obeTipoTRansporte.CODIGO = "T"
        obeTipoTRansporte.DESCRIPCION = "Terrestre"
        oListTipoTransporte.Add(obeTipoTRansporte)

        obeTipoTRansporte = New TD_TipoTransporte
        obeTipoTRansporte.CODIGO = "A"
        obeTipoTRansporte.DESCRIPCION = "Aereo"
        oListTipoTransporte.Add(obeTipoTRansporte)

        obeTipoTRansporte = New TD_TipoTransporte
        obeTipoTRansporte.CODIGO = "F"
        obeTipoTRansporte.DESCRIPCION = "Fluvial"
        oListTipoTransporte.Add(obeTipoTRansporte)

        obeTipoTRansporte = New TD_TipoTransporte
        obeTipoTRansporte.CODIGO = "R"
        obeTipoTRansporte.DESCRIPCION = "Ferroviario"
        oListTipoTransporte.Add(obeTipoTRansporte)

        Return oListTipoTransporte
    End Function
End Class
