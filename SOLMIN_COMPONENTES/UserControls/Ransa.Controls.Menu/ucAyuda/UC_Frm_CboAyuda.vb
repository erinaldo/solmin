Imports System.Windows.Forms
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class UC_Frm_CboAyuda


    Private _objayuda As ClsInformacion
    'Private _objDal As New Ransa.DAO.TipoAyuda.cTipoAyuda
    Private _objDal As New Ransa.Controls.TipoAyuda.cTipoAyuda

    Private _resultado As New DataTable
    Private _codigo As String

    Public Sub setDataSource(ByVal dtb As DataTable)
        _resultado = dtb
    End Sub
    Public ReadOnly Property pSeleccionarValor() As ClsInformacion
        Get
            Return _objayuda
        End Get
    End Property

    Public Property ClaseCodigoAyuda() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private Sub LoadControl(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvDatos.AutoGenerateColumns = False
            dgvDatos.DataSource = Nothing
            If (_resultado.Rows.Count <> 0) Then
                dgvDatos.DataSource = _resultado
                If TryCast(dgvDatos.DataSource, DataTable).Rows.Count > 0 Then
                    UcPaginacion.PageCount = TryCast(dgvDatos.DataSource, DataTable).Rows.Count
                End If
            Else
                pCargarInformacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pCargarInformacion()

        dgvDatos.DataSource = Nothing
        Dim objSQl As New SqlManager
        _resultado = _objDal.fdtListar_TablaAyuda_Filtro(objSQl, _codigo, "")
        dgvDatos.DataSource = _resultado
        If TryCast(dgvDatos.DataSource, List(Of beUsuarioUC)).Count > 0 Then
            UcPaginacion.PageCount = TryCast(dgvDatos.DataSource, DataTable).Rows.Count
        End If
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            pCargarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvUsuario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        Try

            Dim index As Int32 = dgvDatos.CurrentCellAddress.Y
            Dim dr As DataRowView = dgvDatos.Rows(index).DataBoundItem
            ' _objayuda.CODVAR = dr.Item("CODVAR")

            If _objayuda Is Nothing Then
                _objayuda = New ClsInformacion
            End If

            _objayuda.CCMPRN = dr.Row.Item(2)
            _objayuda.TDSDES = dr.Row.Item(1)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            If e.KeyCode = Keys.Enter Then
                Me.UcPaginacion.PageNumber = 1
                Call pCargarInformacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown, txtCodigo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.UcPaginacion.PageNumber = 1
                Call pCargarInformacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Call pCargarInformacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodig_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
