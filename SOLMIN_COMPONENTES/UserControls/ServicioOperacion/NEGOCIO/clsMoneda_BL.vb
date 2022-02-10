
Public Class clsMoneda_BL




    Private oMonedaDato As Ransa.Controls.ServicioOperacion.clsMoneda_DAL
    Private oDt As DataTable

    Sub New()
        oMonedaDato = New Ransa.Controls.ServicioOperacion.clsMoneda_DAL
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property
    Public Function Lista_Moneda(ByVal pdblCodLiq As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("NPRLQD='" & pdblCodLiq & "'")
        objDt = oDt.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function


    Public Function Lista_Moneda_x_All(ByVal pdblCodLiq As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("NPRLQD='" & pdblCodLiq & "'")
        objDt = oDt.Copy

        objDt.Rows.Clear()


        objDr = objDt.NewRow
        objDr(1) = "-1"
        objDr(2) = "TODOS"
        objDt.Rows.InsertAt(objDr, 0)

        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function

    Public Sub Crea_Lista()
        'oDt = oDivisionDato.Lista_Division
        oDt = oMonedaDato.Lista_Moneda()
    End Sub

    Function Lista_Moneda_Sol_Dol() As DataTable

        Dim dt As New DataTable

        dt = oMonedaDato.Lista_Moneda()

        Return dt

    End Function


End Class
