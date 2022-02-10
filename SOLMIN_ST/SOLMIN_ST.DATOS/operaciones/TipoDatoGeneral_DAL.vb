Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Namespace Operaciones

    Public Class TipoDatoGeneral_DAL
        Private objSql As New SqlManager

        Public Function Lista_Tipo_Dato_General(ByVal CCMPN As String, ByVal CODVAR As String) As List(Of TipoDatoGeneral)
            Dim Lista As New List(Of TipoDatoGeneral)
            Dim tb As New DataTable
            Dim tipoDatoGeneral As TipoDatoGeneral
            Dim objParam As New Parameter
            'Try
            objParam.Add("PSCODVAR", CODVAR)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            tb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_DATO_GENERAL_X_CODIGO", objParam)
            For Each Item As DataRow In tb.Rows
                tipoDatoGeneral = New TipoDatoGeneral
                tipoDatoGeneral.CODIGO_TIPO = Item("CODIGO_TIPO").ToString.Trim
                tipoDatoGeneral.DESC_TIPO = Item("DESC_TIPO").ToString.Trim
                Lista.Add(tipoDatoGeneral)
            Next
            'Catch ex As Exception
            '    Lista = New List(Of TipoDatoGeneral)
            'End Try
            Return Lista
        End Function



        Public Function Lista_Tipo_Dato_General_RZPR05(ByVal PRTABL As String) As List(Of TipoDatoGeneral)
            Dim Lista As New List(Of TipoDatoGeneral)
            Dim tb As New DataTable
            Dim tipoDatoGeneral As TipoDatoGeneral
            Dim objParam As New Parameter
            'Try
            objParam.Add("PRTABL", PRTABL)
            'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(CCMPN)
            tb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_DATO_GENERAL_X_TABLA_RZPR05", objParam)
            For Each Item As DataRow In tb.Rows
                tipoDatoGeneral = New TipoDatoGeneral
                tipoDatoGeneral.CODIGO_TIPO = Item("CODIGO_TIPO").ToString.Trim
                tipoDatoGeneral.DESC_TIPO = Item("DESC_TIPO").ToString.Trim
                Lista.Add(tipoDatoGeneral)
            Next
            'Catch ex As Exception
            '    Lista = New List(Of TipoDatoGeneral)
            'End Try
            Return Lista
        End Function

    End Class

End Namespace


