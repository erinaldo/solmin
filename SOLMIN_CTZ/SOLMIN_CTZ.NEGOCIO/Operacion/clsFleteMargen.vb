Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsFleteMargen
    Private objDatos As New SOLMIN_CTZ.DATOS.clsFleteMargen

    Public Function ListaNegocioxCentroCosto(ByVal PSCCMPN As String, ByVal PNCCNTCS As Decimal) As DataTable
        Return objDatos.ListaNegocioxCentroCosto(PSCCMPN, PNCCNTCS)
    End Function


    Public Sub ListaMargenPemitidoxNegocio(ByVal PSCCMPN As String, ByVal PSCRGVTA As String, ByRef MARGEN As Decimal, ByRef DebeValidar As Boolean)
        objDatos.ListaMargenPemitidoxNegocio(PSCCMPN, PSCRGVTA, MARGEN, DebeValidar)
    End Sub

    Public Function ListaServicioMercaderiaValidacion(ByVal PSCCMPN As String, ByVal PNRTFSV As Decimal, ByVal PNNRCTSL As Decimal, ByVal MargenNegocio As Decimal) As DataTable
        Return objDatos.ListaServicioMercaderiaValidacion(PSCCMPN, PNRTFSV, PNNRCTSL, MargenNegocio)
    End Function

    Public Function ListaServicioCentroCosto(ByVal PSCCMPN As String, ByVal PNRTFSV As Integer, ByVal PNNRCTSL As Decimal) As DataTable
        Return objDatos.ListaServicioCentroCosto(PSCCMPN, PNRTFSV, PNNRCTSL)
    End Function

    Public Sub ActualizarEstadoOrdenServicio(ByVal obeOrdenServicio As OrdenServicioTransporte)
        objDatos.ActualizarEstadoOrdenServicio(obeOrdenServicio)
    End Sub

    'Nueva validacion
    Public Function Listar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete, ByVal MargenNegocio As Decimal) As DataTable
        Return objDatos.Listar_Detalle_Tarifa_Tipo_Flete(objEntidad, MargenNegocio)
    End Function

    'Public Function ListaServicioCentroCostoTarifa(ByVal PSCCMPN As String, ByVal PNRTFSV As Integer) As DataTable
    '    Return objDatos.ListaServicioCentroCostoTarifa(PSCCMPN, PNRTFSV)
    'End Function
End Class
