Public Class frmAyuda

    Public Event Resultado(ByVal objResult As Object)

    Private _DataSource As Object

    Public Property DataSource() As Object
        Get
            Return _DataSource
        End Get
        Set(ByVal value As Object)
            _DataSource = value
        End Set
    End Property


    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property


    Private _DataMember As String = ""
    Public Property DataMember() As String
        Get
            Return _DataMember
        End Get
        Set(ByVal value As String)
            _DataMember = value
        End Set
    End Property

    Private _DataValue As String = ""
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal value As String)
            _DataValue = value
        End Set
    End Property

    Private Sub frmAyuda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GenerarGrilla()
        Me.dtgAyuda.AutoGenerateColumns = False
        Me.dtgAyuda.DataSource = _DataSource
    End Sub

    Private Sub dtgAyuda_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgAyuda.CellMouseDoubleClick
        If Me.dtgAyuda.CurrentCellAddress.Y = -1 Then Exit Sub
        objResultado = Me.dtgAyuda.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GenerarGrilla()

        Dim oDgvText As New Windows.Forms.DataGridViewTextBoxColumn()
        oDgvText.Name = _DataMember
        oDgvText.AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        oDgvText.DataPropertyName = _DataMember
        oDgvText.HeaderText = "Código"

        Me.dtgAyuda.Columns.Add(oDgvText)
        oDgvText = New Windows.Forms.DataGridViewTextBoxColumn()
        oDgvText.Name = _DataValue
        oDgvText.AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        oDgvText.DataPropertyName = _DataValue
        oDgvText.HeaderText = "Valor"

        Me.dtgAyuda.Columns.Add(oDgvText)


    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        dtgAyuda_CellMouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        objResultado = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
