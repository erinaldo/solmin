Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Imports System.Text

Public Class clsTipoDatoGeneral
    Public Function Listar_Tipo_Dato_X_Codigo(ByVal cadena As String) As DataTable
        Dim oclsTipoDatoGeneral As New Datos.clsTipoDatosGeneral
        Return oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo(cadena)
    End Function



    Public Function Listar_Tipo_Dato_X_Codigo_General(ByVal CodVar As String) As List(Of beTipoDatoGeneral)
        Dim dt As New DataTable
        Dim oclsTipoDatoGeneral As New Datos.clsTipoDatosGeneral
        dt = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo(CodVar)
        Dim obeTipoDatoGeneral As beTipoDatoGeneral
        Dim oListTipoGeneral As New List(Of beTipoDatoGeneral)
        For Each Item As DataRow In dt.Rows
            obeTipoDatoGeneral = New beTipoDatoGeneral
            obeTipoDatoGeneral.PSCCMPRN = ("" & Item("CCMPRN")).ToString.Trim
            obeTipoDatoGeneral.PSTDSDES = ("" & Item("TDSDES")).ToString.Trim
            oListTipoGeneral.Add(obeTipoDatoGeneral)
        Next
        Return oListTipoGeneral
    End Function
End Class
