Public Class frmResultadoMasivo
#Region " Atributos "
    Dim dtResultado As DataTable
#End Region
#Region " Propiedades "
    Public WriteOnly Property pdtResultado() As DataTable
        Set(ByVal value As DataTable)
            dtResultado = value
        End Set
    End Property
#End Region
#Region " Procedimientos y Funciones "

#End Region
#Region " Metodos "
    Private Sub frmResultadoMasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgResultado.DataSource = dtResultado
    End Sub
#End Region
End Class
