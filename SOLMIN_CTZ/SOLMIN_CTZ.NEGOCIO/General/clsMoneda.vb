Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsMoneda
    Private oMoneda As SOLMIN_CTZ.DATOS.clsMoneda
    Private oDt As DataTable

    Sub New()
        oMoneda = New SOLMIN_CTZ.DATOS.clsMoneda
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property


    Public Function Lista_Moneda(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "-------"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Function Lista_Moneda_x_All(Optional ByVal pintFlag As Integer = 0) As DataTable
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

    Public Function Listar_Moneda() As List(Of Moneda)
        Return oMoneda.Listar_Moneda()
    End Function

    Public Sub Crea_Moneda()
        oDt = oMoneda.Lista_Moneda()
    End Sub

End Class
