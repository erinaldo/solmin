Imports RANSA.TypeDef
Imports RANSA.DATA

Public Class brDespachoMasivo

    Dim oDatos As New DATA.daDespachoMasivo

    Public Function ListarStockMercaderiaClienteAlmacen(ByVal PNCCLNT As Decimal, ByVal PSCFMCLR As String, ByVal PSCGRCLR As String, ByVal PSCTPALM As String, ByVal PSCALMC As String, ByVal PSCZNALM As String) As DataTable
        Dim oDt As DataTable = oDatos.ListarStockMercaderiaClienteAlmacen(PNCCLNT, PSCFMCLR, PSCGRCLR, PSCTPALM, PSCALMC, PSCZNALM)
        Return oDt
    End Function

    Public Function ValidarAlmacenConfigAlmacenCliente(ByVal PSCTPALM As String, ByVal PSCALMC As String, ByVal PSCZNALM As String) As DataTable
        Dim oDt As DataTable = oDatos.ValidarAlmacenConfigAlmacenCliente(PSCTPALM, PSCALMC, PSCZNALM)
        Return oDt
    End Function

    Public Function ValidarGrupoFamilia(ByVal PNCCLNT As Decimal, ByVal PSCFMCLR As String, ByVal PSCGRCLR As String) As DataTable
        Dim oDt As DataTable = oDatos.ValidarGrupoFamilia(PNCCLNT, PSCFMCLR, PSCGRCLR)
        Return oDt
    End Function
    Public Function ListarAlmacenValidacionCarga() As DataTable
        Dim oDt As New DataTable
        oDt = oDatos.ListarAlmacenValidacionCarga()
        Return oDt
    End Function

    Public Function ListarGrupoFamiliaValidacionCarga(ByVal PNCCLNT As Decimal) As DataTable
        Dim oDt As New DataTable
        oDt = oDatos.ListarGrupoFamiliaValidacionCarga(PNCCLNT)
        Return oDt
    End Function

    Public Function ActualizarRelacionadoOS(ByVal PNNORDSR As Decimal) As Boolean
        Dim result As Boolean = False
        result = oDatos.ActualizarRelacionadoOS(PNNORDSR)
        Return result
    End Function

    Public Function ListarTablaVCalidacionCarga(ByVal PNCCLNT As Decimal) As DataSet
        Dim oDs As New DataSet
        oDs = oDatos.ListarTablaVCalidacionCarga(PNCCLNT)
        Return oDs
    End Function


End Class
