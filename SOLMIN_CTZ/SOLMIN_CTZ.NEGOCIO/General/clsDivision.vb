Imports SOLMIN_CTZ.DATOS

Public Class clsDivision
    Private oDivisionDato As SOLMIN_CTZ.DATOS.clsDivision
    Private oDt As DataTable

    Sub New()
        oDivisionDato = New SOLMIN_CTZ.DATOS.clsDivision
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

    Public Sub Crea_Lista()
        'oDt = oDivisionDato.Lista_Division
        oDt = oDivisionDato.Lista_Division_X_Usuario()
    End Sub
    Public Function Lista_Division_X_CompaniaUsuario(Cccmpn As String, Usuario As String) As DataTable
        Return oDivisionDato.Lista_Division_X_CompaniaUsuario(Cccmpn, Usuario)
    End Function

    Public Function Lista_Division_X_CompaniaUsuario_OS(Cccmpn As String, Usuario As String) As DataTable
        Return oDivisionDato.Lista_Division_X_CompaniaUsuario_OS(Cccmpn, Usuario)
    End Function

End Class

