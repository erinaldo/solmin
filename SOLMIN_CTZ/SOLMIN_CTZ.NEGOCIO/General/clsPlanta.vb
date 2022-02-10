Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Public Class clsPlanta
    Private oPlantaDato As SOLMIN_CTZ.DATOS.clsPlanta
    Private oDt As DataTable

    Sub New()
        oPlantaDato = New SOLMIN_CTZ.DATOS.clsPlanta
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
        'For i As Integer = 0 To oDt.Rows.Count - 1
        '    oDt.Rows(i).Item("TPLNTA").ToString.Trim()
        'Next
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



    Public Sub Crea_Lista()
        oDt = oPlantaDato.Lista_Planta_X_Usuario()
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


    Public Function Listar_Planta_X_Compania(ByVal ccmpn As String, ByVal cdvsn As String) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Return oPlantaDato.Listar_Planta_X_Compania(ccmpn, cdvsn)
    End Function


    Public Function Lista_Planta() As List(Of bePlanta)
        Return oPlantaDato.Lista_Planta()
    End Function


    Public Function Lista_Planta_x_CompaniaDivision(ByVal pdblCodCompania As String, ByVal pdblCodDivision As String) As DataTable
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "' AND CDVSN ='" & pdblCodDivision.Trim & "'")
        objDt = oDt.Copy
        objDt.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = objDt.NewRow
            objDr("CPLNDV") = objListaDr(lintCont)("CPLNDV")
            objDr("TPLNTA") = ("" & objListaDr(lintCont)("TPLNTA")).ToString.Trim
            objDt.Rows.Add(objDr)
        Next lintCont

        Return objDt
    End Function


End Class