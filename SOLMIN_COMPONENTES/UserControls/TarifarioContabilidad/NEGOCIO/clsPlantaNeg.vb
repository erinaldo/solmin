Public Class clsPlantaNeg
    Private oPlantaDato As clsPlanta
    Private oDt As DataTable

    Sub New()
        oPlantaDato = New clsPlanta
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Lista_Planta(ByVal pdblCodCompania As String, ByVal pdblCodDivision As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        If pdblCodDivision = "-1" Then
            pdblCodDivision = "%"
        End If
        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "' AND CDVSN like '" & pdblCodDivision.Trim & "'")
        objDt = oDt.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function

    Public Function Lista_Planta_Division(ByVal pdblCodCompania As String, ByVal pdblCodDivision As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        'acd
        Dim temp As String = ""
        'fin acd
        If pdblCodDivision = "-1" Then
            pdblCodDivision = "%"
        End If
        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "' AND CDVSN like '" & pdblCodDivision.Trim & "'")
        objDt = oDt.Copy
        objDt.Rows.Clear()

        objDr = objDt.NewRow
        objDr(1) = "-1"
        objDr(3) = "TODOS"
        objDt.Rows.Add(objDr)

        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDt.Rows.Add(objDr)
            If temp = objListaDr(lintCont).Item(3) Then
                objDt.Rows.Remove(objDr)
            End If
            temp = objListaDr(lintCont).Item(3)
        Next lintCont

        Return objDt
    End Function



    Public Sub Crea_Lista(ByVal Usuario As String)
        'oDt = oPlantaDato.Lista_Planta
        oDt = oPlantaDato.Lista_Planta_X_Usuario(Usuario)
    End Sub




    Public Function Lista_Planta_Compania(ByVal pdblCodCompania As String) As DataTable
        Dim intCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        Dim objDr As DataRow

        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "'")
        objDt = oDt.Copy
        objDt.Rows.Clear()
        For intCont = 0 To oDt.Rows.Count - 1
            If Validar(objListaDr(intCont).Item("CPLNDV").ToString, objDt) Then
                objDr = objDt.NewRow
                objDr(1) = objListaDr(intCont).Item(1)
                objDr(3) = objListaDr(intCont).Item(3)
                objDt.Rows.Add(objDr)
            End If
        Next intCont
        'Return oPlantaDato.Lista_Planta_Compania

        Return objDt
    End Function

    Private Function Validar(ByVal pstrPlanta As String, ByVal poDt As DataTable) As Boolean
        Dim intCont As Integer

        For intCont = 0 To poDt.Rows.Count - 1
            If poDt.Rows(intCont).Item("CPLNDV").ToString = pstrPlanta Then
                Return False
            End If
        Next intCont
        Return True
    End Function

End Class