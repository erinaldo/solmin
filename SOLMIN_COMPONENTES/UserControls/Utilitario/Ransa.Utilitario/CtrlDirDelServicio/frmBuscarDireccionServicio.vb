
Public Class frmBuscarDireccionServicio
    Dim blUbigeo As New clsUbigeo
    Dim blDirecServ As New clsDirDelServicio

#Region "Propiedades"
    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property

    Private _PNCCLNTOP As Decimal
    Public Property PNCCLNTOP() As Decimal
        Get
            Return _PNCCLNTOP
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNTOP = value
        End Set
    End Property

    Private _PNCCLNTFC As Decimal
    Public Property PNCCLNTFC() As Decimal
        Get
            Return _PNCCLNTFC
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNTFC = value
        End Set
    End Property

    Private _PNCPLNDVOP As Decimal
    Public Property PNCPLNDVOP() As Decimal
        Get
            Return _PNCPLNDVOP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDVOP = value
        End Set
    End Property

    Private _PNCPLNDVFC As Decimal
    Public Property PNCPLNDVFC() As Decimal
        Get
            Return _PNCPLNDVFC
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDVFC = value
        End Set
    End Property

    Private _PSTIPODIR As String
    Public Property PSTIPODIR() As String
        Get
            Return _PSTIPODIR
        End Get
        Set(ByVal value As String)
            _PSTIPODIR = value
        End Set
    End Property



    Private _datodireccion As String
    Public Property DatoDireccion() As String
        Get
            Return _datodireccion
        End Get
        Set(ByVal value As String)
            _datodireccion = value
        End Set
    End Property


    Private _CPLNDV As Integer
    Public Property CPLNDV() As Integer
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Integer)
            _CPLNDV = value
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
#End Region

    Private Sub CargarComboUbigeo()
        Try
            Dim dt As New DataTable
            dt = blUbigeo.ListarUbigeo
            Dim listUbigeo As New List(Of beUbigeo)
            Dim entidad As beUbigeo
            For Each dr As DataRow In dt.Rows
                entidad = New beUbigeo
                entidad.Codigo = dr("CUBGEO")
                entidad.Ubigeo = dr("UBIGEO")
                listUbigeo.Add(entidad)
            Next
            cboUbigeo.DataSource = listUbigeo
            cboUbigeo.ListColumnas = blUbigeo.ColumnaUbigeo()
            cboUbigeo.Cargas()
            cboUbigeo.Limpiar()
            cboUbigeo.ValueMember = "Codigo"
            cboUbigeo.DispleyMember = "Ubigeo"
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub CargaInicial()
        Dim ds As New DataSet
        ds = blDirecServ.Lista_CargaInicialDirServicio(PSCCMPN, PSCDVSN, PNCPLNDVOP, PNCPLNDVFC)
        If Not ds Is Nothing Then

            If ds.Tables.Count > 0 Then
                cboTipo.DataSource = ds.Tables(0)
                cboTipo.ValueMember = "CODIGO"
                cboTipo.DisplayMember = "DESCRIPCION"
                If Not ds.Tables(1) Is Nothing Then
                    If ds.Tables(1).Rows.Count > 0 Then
                        If Not ds.Tables(1).Rows.Item(0) Is Nothing Then
                            txtPlanta.Text = ds.Tables(1).Rows.Item(0)("PLANTA")
                            PNCPLNDVOP = ds.Tables(1).Rows.Item(0)("CPLNDV")
                        End If
                      
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub frmBuscarDireccionServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtPlanta.Enabled = False
            CargarComboUbigeo()
            CargaInicial()
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
                ubigeo = Integer.Parse(CType(cboUbigeo.Resultado, beUbigeo).Codigo)
            End If

            dtgDireccion.AutoGenerateColumns = False
            dtgDireccion.DataSource = blDirecServ.Buscar_Direccion_Servicio(codigo, _
                                                                            txtDescripcion.Text.Trim(), _
                                                                            ubigeo, _
                                                                            txtReferencia.Text.Trim(), _
                                                                            PNCCLNTOP, _
                                                                            PNCCLNTFC, _
                                                                            cboTipo.SelectedValue, _
                                                                            PSCCMPN, _
                                                                            PSCDVSN, _
                                                                            PNCPLNDVOP, _
                                                                            PNCPLNDVFC)

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
