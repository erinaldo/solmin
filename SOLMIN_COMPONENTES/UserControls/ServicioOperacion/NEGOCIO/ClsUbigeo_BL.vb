Public Class ClsUbigeo_BL
    Private Ubigeo As New clsUbigeo_DAL
    Public Function ListarUbigeo() As List(Of Ubigeo_BE)

        Dim listaUbigeo As New List(Of Ubigeo_BE)
        Dim output As DataTable = Ubigeo.ListarUbigeo()

        For Each row As DataRow In output.Rows
            Dim ubigeo As New Ubigeo_BE
            ubigeo.Codigo = row.Item("CUBGEO")
            ubigeo.Ubigeo = row.Item("UBIGEO")
            listaUbigeo.Add(ubigeo)
        Next row

        Return listaUbigeo

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
