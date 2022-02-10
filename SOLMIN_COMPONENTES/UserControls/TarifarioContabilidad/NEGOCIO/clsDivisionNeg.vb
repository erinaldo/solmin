
Public Class clsDivisionNeg
    Private oDivisionDato As clsDivision
    Private oDt As DataTable

    Sub New()
        oDivisionDato = New clsDivision
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Lista_Division(ByVal pdblCodCompania As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania & "'")
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


    Public Function Lista_Division_x_All(ByVal pdblCodCompania As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania & "'")
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

    Public Sub Crea_Lista(ByVal Usuario As String)
        'oDt = oDivisionDato.Lista_Division
        oDt = oDivisionDato.Lista_Division_X_Usuario(Usuario)
    End Sub
End Class

