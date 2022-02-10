Public Class UCPaginacion

    Public Event PageChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    Private bInicializo As Boolean = False

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Dock = DockStyle.Bottom
        Me.PageSize = 20
        Me.PageNumber = 1
        Me.PageCount = 0
    End Sub

    Private _PageSize As Int32
    Public Property PageSize() As Int32
        Get
            Return _PageSize
        End Get
        Set(ByVal value As Int32)

            txtNroRegPorPagina.Text = value
            _PageSize = value
            PageNumber = 1
        End Set
    End Property

    Public Property PageNumber() As Int32
        Get
            Return Val(txtPaginaActual.Text)
        End Get
        Set(ByVal value As Int32)
            txtPaginaActual.Text = value
        End Set
    End Property

    Public Property PageCount() As Int32
        Get
            Return txtNroTotalPagina.Text
        End Get
        Set(ByVal value As Int32)
            txtNroTotalPagina.Text = value
            If value > 0 Then
                bInicializo = True
            Else
                bInicializo = True = False
            End If
        End Set
    End Property

    Private Sub PageChange()
        If bInicializo = True And PageNumber >= 1 And PageNumber <= PageCount Then
            RaiseEvent PageChanged(Me, Nothing)
        Else
            PageNumber = 1
            'PageChange()
        End If
    End Sub

    Private Sub txtNroRegPorPagina_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroRegPorPagina.KeyDown
        If e.KeyCode = Keys.Enter Then
            PageSize = IIf(Val(txtNroRegPorPagina.Text) = 0, 20, txtNroRegPorPagina.Text)
            PageChange()
        End If
    End Sub

    Private Sub txtPaginaActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaginaActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            PageChange()
        End If
    End Sub

    Private Sub btnIrFinal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIrFinal.Click
        If PageNumber >= PageCount Then Exit Sub
        PageNumber = PageCount
        PageChange()
    End Sub

    Private Sub btnIrAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIrAnterior.Click
        If PageNumber <= 1 Then Exit Sub
        PageNumber -= 1
        PageChange()
    End Sub

    Private Sub btnIrSiguiente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIrSiguiente.Click
        If PageNumber >= PageCount Then Exit Sub
        PageNumber += 1
        PageChange()
    End Sub

    Private Sub btnIrInicio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIrInicio.Click
        If PageNumber <= 1 Then Exit Sub
        PageNumber = 1
        PageChange()
    End Sub

    Private Sub txtPaginaActual_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaginaActual.TextChanged
        'PageChange()
    End Sub
End Class
