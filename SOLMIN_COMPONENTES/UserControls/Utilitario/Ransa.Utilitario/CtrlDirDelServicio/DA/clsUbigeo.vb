Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsUbigeo


    Public Function ListarUbigeo() As DataTable
        Dim output As DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter
            output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_UBIGEO", Nothing)
        Catch ex As Exception
            output = Nothing
        End Try
        Return output
    End Function

    Public Function ColumnaUbigeo() As Hashtable
        Dim listaColumnas As New Hashtable
        Dim columna As New DataGridViewTextBoxColumn
        columna.Name = "Codigo"
        columna.DataPropertyName = "Codigo"
        columna.HeaderText = "Codigo "
        listaColumnas.Add(1, columna)

        columna = New DataGridViewTextBoxColumn
        columna.Name = "Ubigeo"
        columna.DataPropertyName = "Ubigeo"
        columna.HeaderText = "Ubigeo"
        listaColumnas.Add(2, columna)

        Return listaColumnas
    End Function


End Class
