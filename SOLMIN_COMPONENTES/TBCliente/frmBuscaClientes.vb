Imports SOLMIN_TR.NEGOCIO
Imports SOLMIN_TR.DATOS.Entidades

Public Class frmBuscaCliente

    Dim objEntidad As New Clientes
    Dim objCliente As New ClienteDAO
    Dim CodigoCliente As String

    Private Sub frmBuscaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  
        ' Me.txtFiltro.Text = ""
        Me.txtFiltro.Focus()  

    End Sub

    Private Sub txtFiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.Busqueda_Cliente()
        End If

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Busqueda_Cliente()
    End Sub

    Private Sub Busqueda_Cliente()

        If Me.txtFiltro.Text.Trim.Equals("") = True Then
            Me.dtgDatos.DataSource = Nothing
            Exit Sub
        End If

        Dim objEntidad As New Clientes
        Dim objCliente As New ClienteDAO

        objEntidad.TCMPCL = Me.txtFiltro.Text
        Me.dtgDatos.DataSource = objCliente.Busqueda_Cliente(objEntidad)
        Me.dtgDatos.Focus()

    End Sub

    Private Sub dtgDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellDoubleClick

        seleccionar_cliente()

    End Sub

    Private Sub seleccionar_cliente()

        If Me.dtgDatos.DataSource Is Nothing Then
            Exit Sub
        End If
        If dtgDatos.Rows(dtgDatos.CurrentCellAddress.Y).Cells(0).Value Is DBNull.Value Then
            Exit Sub
        End If

        'Carga los datos del registro seleccionado
        CodigoCliente = dtgDatos.Rows(dtgDatos.CurrentCellAddress.Y).Cells(0).Value

        objEntidad.CCLNT = CodigoCliente
        objEntidad = objCliente.Obtener_Cliente(objEntidad)

        Me.Close()

    End Sub

    Public Function Obtener_Cliente() As Clientes
        Return objEntidad
    End Function
 
    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        seleccionar_cliente()
    End Sub

    Public Sub ShowFormLoad(ByVal objEntidad As Clientes, ByVal owner As IWin32Window)

        Me.txtFiltro.Text = objEntidad.TCMPCL
        Busqueda_Cliente()
        Me.ShowDialog(owner)

    End Sub

    Private Sub dtgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick



    End Sub

End Class
