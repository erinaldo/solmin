Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades.mantenimientos

Public Class clsUM
    Private oUMDato As SOLMIN_CTZ.DATOS.clsUM
    Private oDt As DataTable

    Sub New()
        oUMDato = New SOLMIN_CTZ.DATOS.clsUM
    End Sub

    Public Sub Crear_UM()
        oDt = oUMDato.Lista_UM()
    End Sub

    Public Function Lista() As DataTable
        Dim oDrNew As DataRow
        Dim intCont As Integer
        Dim oDtAux As DataTable

        oDtAux = oDt.Copy
        oDtAux.Rows.Clear()
        oDrNew = oDtAux.NewRow
        oDrNew.Item("CUNDMD") = "NADA"
        oDrNew.Item("TCMPUN") = "------------------"
        oDtAux.Rows.Add(oDrNew)
        For intCont = 0 To oDt.Rows.Count - 1
            oDrNew = oDtAux.NewRow
            oDrNew.Item("CUNDMD") = oDt.Rows(intCont).Item("CUNDMD")
            oDrNew.Item("TCMPUN") = oDt.Rows(intCont).Item("TCMPUN")
            oDtAux.Rows.Add(oDrNew)
        Next intCont

        Return oDtAux
    End Function

    Public Function Listar_UnidadMedida() As List(Of ClaseGeneral)
        Return oUMDato.Listar_UnidadMedida()
    End Function

    'Public Function Lista_UM() As DataTable
    '    Dim oDr() As DataRow
    '    Dim oDrNew As DataRow
    '    Dim intCont As Integer
    '    Dim oDtAux As DataTable

    '    oDr = oDt.Select("TIPO='M'")
    '    oDtAux = oDt.Copy
    '    oDtAux.Rows.Clear()
    '    oDrNew = oDtAux.NewRow
    '    oDrNew.Item("TUNDIT") = "NADA"
    '    oDrNew.Item("TCMPUN") = "------------------"
    '    oDtAux.Rows.Add(oDrNew)
    '    For intCont = 0 To oDr.Length - 1
    '        oDrNew = oDtAux.NewRow
    '        oDrNew.Item("TUNDIT") = oDr(intCont).Item("TUNDIT")
    '        oDrNew.Item("TCMPUN") = oDr(intCont).Item("TCMPUN")
    '        oDtAux.Rows.Add(oDrNew)
    '    Next intCont

    '    Return oDtAux
    'End Function

    'Public Function Lista_UT() As DataTable
    '    Dim oDr() As DataRow
    '    Dim oDrNew As DataRow
    '    Dim intCont As Integer
    '    Dim oDtAux As DataTable

    '    oDr = oDt.Select("TIPO='T'")
    '    oDtAux = oDt.Copy
    '    oDtAux.Rows.Clear()
    '    oDrNew = oDtAux.NewRow
    '    oDrNew.Item("TUNDIT") = "NADA"
    '    oDrNew.Item("TCMPUN") = "------------------"
    '    oDtAux.Rows.Add(oDrNew)
    '    For intCont = 0 To oDr.Length - 1
    '        oDrNew = oDtAux.NewRow
    '        oDrNew.Item("TUNDIT") = oDr(intCont).Item("TUNDIT")
    '        oDrNew.Item("TCMPUN") = oDr(intCont).Item("TCMPUN")
    '        oDtAux.Rows.Add(oDrNew)
    '    Next intCont

    '    Return oDtAux
    'End Function

    'Public Function Lista_CT() As DataTable
    '    Dim oDr() As DataRow
    '    Dim oDrNew As DataRow
    '    Dim intCont As Integer
    '    Dim oDtAux As DataTable

    '    oDr = oDt.Select("TIPO='C'")
    '    oDtAux = oDt.Copy
    '    oDtAux.Rows.Clear()
    '    oDrNew = oDtAux.NewRow
    '    oDrNew.Item("TUNDIT") = "NADA"
    '    oDrNew.Item("TCMPUN") = "--------"
    '    oDtAux.Rows.Add(oDrNew)
    '    For intCont = 0 To oDr.Length - 1
    '        oDrNew = oDtAux.NewRow
    '        oDrNew.Item("TUNDIT") = oDr(intCont).Item("TUNDIT")
    '        oDrNew.Item("TCMPUN") = oDr(intCont).Item("TCMPUN")
    '        oDtAux.Rows.Add(oDrNew)
    '    Next intCont

    '    Return oDtAux
    'End Function
End Class
