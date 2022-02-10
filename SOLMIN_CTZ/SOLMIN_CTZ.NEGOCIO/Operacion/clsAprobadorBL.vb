Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports System.Windows.Forms

Public Class clsAprobadorBL 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Dim Aprobador As New clsAprobadorDA

    Public Function ListarAprobador(ByVal codigoCompania As String) As List(Of beAprobador)
        Dim listaAprobador As New List(Of beAprobador)
        Dim output As DataTable = Aprobador.ListarAprobador(codigoCompania)

        For Each row As DataRow In output.Rows
            Dim aprobador As New beAprobador
            aprobador.Usuario = row.Item("USRCCO")
            aprobador.Nombre = row.Item("NOMBRE")
            listaAprobador.Add(aprobador)
        Next row

        Return listaAprobador
    End Function

    Public Function ColumnaAprobador() As Hashtable
        Dim listaColumnas As New Hashtable
        Dim columna As New DataGridViewTextBoxColumn
        columna.Name = "Usuario"
        columna.DataPropertyName = "Usuario"
        columna.HeaderText = "Usuario "
        listaColumnas.Add(1, columna)

        columna = New DataGridViewTextBoxColumn
        columna.Name = "Nombre"
        columna.DataPropertyName = "Nombre"
        columna.HeaderText = "Nombre "
        listaColumnas.Add(2, columna)

        Return listaColumnas
    End Function
End Class
