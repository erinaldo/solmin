Public Class clsDocumento_BL
    Dim oDatos As New clsDocumento_DAL

    Public Function fintInsertarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As Integer
        Return oDatos.fintInsertarDocumentoServicio(oDocumento_BE)
    End Function
    Public Function fintActualizarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As Integer
        Return oDatos.fintActualizarDocumentoServicio(oDocumento_BE)
    End Function
    Public Function fdtListarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As DataTable
        Return oDatos.fdtListarDocumentoServicio(oDocumento_BE)

    End Function
    Public Function fintObtenerCorrelativo(ByVal oDocumento_BE As Documento_BE) As Integer
        Return oDatos.fintObtenerCorrelativo(oDocumento_BE)
    End Function
End Class