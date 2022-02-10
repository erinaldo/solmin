Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES

Public Class frmRecursosAsignados

    Private strRucProveedor As String = ""
    Private strProveedor As String = ""
    Private strCompania As String = ""
    Private strTipoRecurso As String = ""
    Private objProveedorBLL As New Proveedor_BLL
    Private objAlquilerUnidadBLL As New AlquilerUnidad_BLL
    Private strPlaca As String = ""
    Private strTipo As String = ""
    Private strCodTipo As String = ""

    Public ReadOnly Property Placa()
        Get
            Return strPlaca
        End Get
    End Property

    Public ReadOnly Property Tipo()
        Get
            Return strTipo
        End Get
    End Property

    Public ReadOnly Property CodTipo()
        Get
            Return strCodTipo
        End Get
    End Property


    Sub New(ByVal Compania As String, ByVal RucProveedor As String, ByVal Proveedor As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        strCompania = Compania
        strRucProveedor = RucProveedor
        strProveedor = Proveedor
        ''strTipoRecurso = TipoRecurso
    End Sub

    Private Sub frmRecursosAsignados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtProveedor.Text = strProveedor
            txtProveedor.Tag = strRucProveedor
            Cargar_Tipo_Recurso()
            btnBuscar_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Tipo_Recurso()
        cmbTipoRecurso.DataSource = objProveedorBLL.Listar_Tipos(strCompania, "TIRSO")
        cmbTipoRecurso.ValueMember = "CCMPRN"
        cmbTipoRecurso.DisplayMember = "TDSDES"
        cmbTipoRecurso.SelectedValue = "T"
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim objEntidad As New AlquilerUnidad
            objEntidad.CCMPN = strCompania
            objEntidad.NRUCTR = strRucProveedor
            objEntidad.STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
            objEntidad.NPLRCS = txtPlaca.Text.Trim
            gwdRecAsg.AutoGenerateColumns = False
            gwdRecAsg.DataSource = objAlquilerUnidadBLL.Listar_Recursos_Asignados(objEntidad)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.gwdRecAsg.RowCount = 0 OrElse Me.gwdRecAsg.CurrentCellAddress.Y < 0 Then Exit Sub
            strCodTipo = gwdRecAsg.CurrentRow.Cells("STPRCS").Value
            strTipo = gwdRecAsg.CurrentRow.Cells("TDSDES").Value
            strPlaca = gwdRecAsg.CurrentRow.Cells("NPLRCS").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdRecAsg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdRecAsg.CellDoubleClick
        Try
            If Me.gwdRecAsg.RowCount = 0 OrElse Me.gwdRecAsg.CurrentCellAddress.Y < 0 Then Exit Sub
            strCodTipo = gwdRecAsg.CurrentRow.Cells("STPRCS").Value
            strTipo = gwdRecAsg.CurrentRow.Cells("TDSDES").Value
            strPlaca = gwdRecAsg.CurrentRow.Cells("NPLRCS").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
