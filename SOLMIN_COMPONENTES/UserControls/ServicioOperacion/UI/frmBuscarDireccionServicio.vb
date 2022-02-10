'Imports SOLMIN_CTZ.Entidades
'Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmBuscarDireccionServicio
    Dim blUbigeo As New ClsUbigeo_BL
    Dim blDirecServ As New clsDirecServ_BL


    Private _datodireccion As String
    Public Property DatoDireccion() As String
        Get
            Return _datodireccion
        End Get
        Set(ByVal value As String)
            _datodireccion = value
        End Set
    End Property

    Private _datocodigo As Integer
    Public Property DatoCodigo() As Integer
        Get
            Return _datocodigo
        End Get
        Set(ByVal value As Integer)
            _datocodigo = value
        End Set
    End Property

    Private _datoubigeo As String
    Public Property DatoUbigeo() As String
        Get
            Return _datoubigeo
        End Get
        Set(ByVal value As String)
            _datoubigeo = value
        End Set
    End Property

    Private Sub CargarComboUbigeo()

        cboUbigeo.DataSource = blUbigeo.ListarUbigeo()
        cboUbigeo.ListColumnas = blUbigeo.ColumnaUbigeo()
        cboUbigeo.Cargas()
        cboUbigeo.Limpiar()
        cboUbigeo.ValueMember = "Codigo"
        cboUbigeo.DispleyMember = "Ubigeo"

    End Sub

    Private Sub frmBuscarDireccionServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            CargarComboUbigeo()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            Dim codigo As Integer
            Dim ubigeo As Integer

            If txtCodigo.Text.Trim() = String.Empty Or txtCodigo.Text.Trim() = "" Then
                codigo = 0
            Else
                codigo = Integer.Parse(txtCodigo.Text.Trim())
            End If

            If cboUbigeo.Resultado Is Nothing Then
                ubigeo = 0
            Else
                ubigeo = Integer.Parse(CType(cboUbigeo.Resultado, Ubigeo_BE).Codigo)
            End If

            dtgDireccion.AutoGenerateColumns = False
            dtgDireccion.DataSource = blDirecServ.Buscar_Direccion_Servicio(codigo, txtDireccion.Text.Trim(), ubigeo, txtReferencia.Text.Trim())

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try

            If Me.dtgDireccion.Rows.Count = 0 Then Exit Sub

            If Not (dtgDireccion.CurrentRow Is Nothing) Then
                _datocodigo = Integer.Parse(dtgDireccion.CurrentRow.Cells("CDIRSE").Value.ToString().Trim())
                _datodireccion = dtgDireccion.CurrentRow.Cells("DEDISE").Value.ToString().Trim()
                _datoubigeo = dtgDireccion.CurrentRow.Cells("UBIGEO").Value.ToString().Trim()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgDireccion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDireccion.CellDoubleClick
        Try

            If Me.dtgDireccion.Rows.Count = 0 Then Exit Sub

            If Not (dtgDireccion.CurrentRow Is Nothing) Then
                _datocodigo = Integer.Parse(dtgDireccion.CurrentRow.Cells("CDIRSE").Value.ToString().Trim())
                _datodireccion = dtgDireccion.CurrentRow.Cells("DEDISE").Value.ToString().Trim()
                _datoubigeo = dtgDireccion.CurrentRow.Cells("UBIGEO").Value.ToString().Trim()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
