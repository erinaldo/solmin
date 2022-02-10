Public Class clsTipoCarga
    Private oTipoCarga As Datos.clsTipoCarga
    Private intCodigo As Integer
    Private oDt As DataTable

    Sub New()
        oTipoCarga = New Datos.clsTipoCarga
    End Sub

    Property Codigo()
        Get
            Return intCodigo
        End Get
        Set(ByVal value)
            intCodigo = value
        End Set
    End Property

    Public Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property


    Public Function Lista_Tipo_Carga(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_Lista()
        oDt = oTipoCarga.Lista_Tipo_Carga
    End Sub
End Class
