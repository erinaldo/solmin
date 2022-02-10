Imports System.Windows.Forms
Public Class clsUbigeo


    Dim Ubigeo As New SOLMIN_CTZ.DATOS.clsUbigeo

    Public Function ListarUbigeo() As List(Of beUbigeo)

        Dim listaUbigeo As New List(Of beUbigeo)
        Dim output As DataTable = Ubigeo.ListarUbigeo()

        For Each row As DataRow In output.Rows
            Dim ubigeo As New beUbigeo
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

End Class
