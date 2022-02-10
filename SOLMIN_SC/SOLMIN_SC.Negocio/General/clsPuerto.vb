Imports SOLMIN_SC.Entidad

Public Class clsPuerto
    Private oPuerto As Datos.clsPuerto
    Private oDt As DataTable
    Private oDtFiltrado As DataTable

    Sub New()
        oPuerto = New Datos.clsPuerto
        oDtFiltrado = New DataTable
        oDtFiltrado.Columns.Add(New DataColumn("CPRTOR", GetType(System.String)))
        oDtFiltrado.Columns.Add(New DataColumn("TCMPR1", GetType(System.String)))
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Puerto(Optional ByVal pintFlag As Integer = 0) As DataTable
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
        oDt = oPuerto.Lista_Puerto
    End Sub

    Public Function Filtra_Puerto(ByVal pdblPais As Double) As DataTable
        Dim oDrCol() As DataRow
        Dim oDr As DataRow
        Dim intCont As Integer

        oDtFiltrado.Rows.Clear()
        oDrCol = oDt.Select("CPAIS1=" & pdblPais)
        For intCont = 0 To oDrCol.Length - 1
            oDr = oDtFiltrado.NewRow
            oDr.Item("CPRTOR") = oDrCol(intCont).Item("CPRTOR")
            oDr.Item("TCMPR1") = oDrCol(intCont).Item("TCMPR1")
            oDtFiltrado.Rows.Add(oDr)
        Next intCont
        Return oDtFiltrado
    End Function


    Public Function Listar_Puerto() As List(Of bePuerto)
        Dim oListPuerto As New List(Of bePuerto)
        oListPuerto = oPuerto.Listar_Puerto()
        Return oListPuerto
    End Function
End Class
