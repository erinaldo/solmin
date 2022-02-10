Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmProveedorAsignado
    Private Compania As String
    Private strRUC As String = ""
    Private strProveedor As String = ""

    Public ReadOnly Property RUC()
        Get
            Return strRUC
        End Get
    End Property

    Public ReadOnly Property Proveedor()
        Get
            Return strProveedor
        End Get
    End Property

    Sub New(ByVal strCompania As String)
        Compania = strCompania
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmProveedorAsignado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Listar_Proveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            strRUC = gwdDatos.CurrentRow.Cells("NRUCTR").Value
            strProveedor = gwdDatos.CurrentRow.Cells("TCMTRT").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            Listar_Proveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar_Proveedor()
        Dim objEntidad As New Transportista
        Dim objTransportistaBLL As New Transportista_BLL
        objEntidad.CCMPN = Compania
        objEntidad.NRUCTR = txtRUC.Text.Trim
        objEntidad.TCMTRT = txtRazonSocial.Text.Trim

        gwdDatos.AutoGenerateColumns = False
        gwdDatos.DataSource = objTransportistaBLL.Listar_Proveedor_Asignado(objEntidad)
    End Sub

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            strRUC = gwdDatos.CurrentRow.Cells("NRUCTR").Value
            strProveedor = gwdDatos.CurrentRow.Cells("TCMTRT").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
