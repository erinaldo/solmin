Public Class clsPreDoc_BL

    Private oPreDoc As Ransa.Controls.ServicioOperacion.clsPreDoc_DAL
    Private oSumaDato As Ransa.Controls.ServicioOperacion.clsPreDoc_DAL


   

    Private oDT As DataTable
    Public Property lista() As DataTable
        Get
            Return oDT
        End Get
        Set(ByVal value As DataTable)
            oDT = value
        End Set
    End Property

    Sub New()
        oPreDoc = New Ransa.Controls.ServicioOperacion.clsPreDoc_DAL
    End Sub
    Public Sub ActualizarPreDocumento(ByVal objParametros As Hashtable)
        oPreDoc.ActualizarPreDocumento(objParametros)
    End Sub
    Public Function ListarCabMonedaPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Return oPreDoc.ListarCabMonedaPreDoc(obePreDoc)
    End Function
    '----------------------------------------------------------------------
    '-------------------------------------------------------------------
    Public Function LiberarPL(ByVal obePreDoc As PreDoc_BE) As String
        Return oPreDoc.LiberarPL(obePreDoc)
    End Function
    Public Function ListarOperacionesXPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Return oPreDoc.ListarOperacionesXPreDoc(obePreDoc)
    End Function
    Public Function ListarPreDocument(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE) As DataTable
        Return oPreDoc.ListarPreDoc(obePreDoc)
    End Function

    Public Function RegistrarDetallePDoc(ByVal obePreDoc As PreDoc_BE, ByRef pNCRPD As Decimal) As String
        Return oPreDoc.RegistrarDetallePDoc(obePreDoc, pNCRPD)
    End Function
    Public Function RegistrarCabeceraPDoc(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE, ByRef pNCRPD As Decimal) As String
        Return oPreDoc.RegistrarCabeceraPDoc(obePreDoc, pNCRPD)
    End Function
    Public Function EliminarCabDoc(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE) As String
        Return oPreDoc.EliminarCabeceraPDoc(obePreDoc)
    End Function
    Public Function ListarPendDoc(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE) As DataTable
        Return oPreDoc.ListarPendDoc(obePreDoc)
    End Function
    Public Function ListarPLDocumentos(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE) As DataTable
        Return oPreDoc.ListarPLDocumentos(obePreDoc)
    End Function

    ' Public Function ListarPLDocumentos_ADMIN(ByVal obePreDoc As Ransa.Controls.ServicioOperacion.PreDoc_BE) As DataTable
    '     Return oPreDoc.ListarPLDocumentos_ADMIN(obePreDoc)
    ' End Function
    ' Public Function ListarDatosPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
    '     Return oPreDoc.ListarDatosPreDoc(obePreDoc)
    ' End Function
    Public Function ValidarAjuste(ByVal obePreDoc As PreDoc_BE) As String
        Return oPreDoc.ValidarAjuste(obePreDoc)
    End Function

    Public Function ListarEstadoPL(ByVal obePreDoc As PreDoc_BE) As DataTable
        Return oPreDoc.ListarEstadoPL(obePreDoc)
    End Function
    Public Function ListarDetallePL_ValorReferencial(ByVal obePreDoc As PreDoc_BE) As DataSet
        Return oPreDoc.ListarDetallePL_ValorReferencial(obePreDoc)
    End Function
    Public Sub ActualizarDetallePL_ValorReferencial(ByVal obePreDoc As PreDoc_BE)
        oPreDoc.ActualizarDetallePL_ValorReferencial(obePreDoc)
    End Sub

    Public Function AnularLiberacionPL(ByVal obePreDoc As PreDoc_BE) As String
        Return oPreDoc.AnularLiberacionPL(obePreDoc)
    End Function
End Class


