Imports SOLMIN_SC.Entidad
Public Class frmRegimen
    Private _ListRegimen As New List(Of beRegimen)
    Public Property ListRegimen() As List(Of beRegimen)
        Get
            Return _ListRegimen
        End Get
        Set(ByVal value As List(Of beRegimen))
            _ListRegimen = value
        End Set
    End Property

    Private _pCodRegimen As Decimal = 0
    Public Property pCodRegimen() As Decimal
        Get
            Return _pCodRegimen
        End Get
        Set(ByVal value As Decimal)
            _pCodRegimen = value
        End Set
    End Property
    Private _pRegimen As String = ""
    Public Property pRegimen() As String
        Get
            Return _pRegimen
        End Get
        Set(ByVal value As String)
            _pRegimen = value
        End Set
    End Property

    Private Sub SeleccionarFila()
        If dgvDatos.CurrentRow IsNot Nothing Then
            Dim Fila As Int32 = dgvDatos.CurrentRow.Index
            _pCodRegimen = Val(dgvDatos.Rows(Fila).Cells("PNTPORGE").Value)
            _pRegimen = ("" & dgvDatos.Rows(Fila).Cells("PSTCMRGA").Value).ToString.Trim
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmRegimen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvDatos.AutoGenerateColumns = False
            dgvDatos.DataSource = _ListRegimen
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        Try
            SeleccionarFila()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            SeleccionarFila()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        dgvDatos.DataSource = Nothing
        txtBusqueda.Text = txtBusqueda.Text.Trim
        If txtBusqueda.Text.Trim.Length = 0 Then
            dgvDatos.DataSource = _ListRegimen
        Else
            PSREGIMEN = txtBusqueda.Text
            Dim oListBusRegimen As List(Of beRegimen)
            Dim pred As New Predicate(Of beRegimen)(AddressOf BuscarRegimenxDescripcion)
            oListBusRegimen = _ListRegimen.FindAll(pred)
            dgvDatos.DataSource = oListBusRegimen
        End If
    End Sub
    Private PSREGIMEN As String = ""
    Private Function BuscarRegimenxDescripcion(ByVal obeRegimen As beRegimen) As Boolean
        Return obeRegimen.PSTCMRGA.ToUpper.Contains(PSREGIMEN.ToUpper)
    End Function
End Class
