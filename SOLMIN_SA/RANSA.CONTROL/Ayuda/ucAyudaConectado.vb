Imports System.Windows.Forms
Public Class ucAyudaConectado

    Private _DispleyMember As String = ""
    Public Property DispleyMember() As String
        Get
            Return _DispleyMember
        End Get
        Set(ByVal value As String)
            _DispleyMember = value
        End Set
    End Property

    Private _ValueMember As String = ""
    Public Property ValueMember() As String
        Get
            Return _ValueMember
        End Get
        Set(ByVal value As String)
            _ValueMember = value
        End Set
    End Property

    Private Columnas As Hashtable


    Public Property ListColumnas() As Hashtable
        Get
            Return Columnas
        End Get
        Set(ByVal value As Hashtable)
            Columnas = value
        End Set
    End Property

    Private ofrmAyuda As New frmBusquedaConectado
    Private _FiltroData As Object

    Public ReadOnly Property Resultado() As Object
        Get
            Return _FiltroData
        End Get
    End Property



    Private _DataSource As Object

    Public Property DataSource() As Object
        Get
            Return _DataSource
        End Get
        Set(ByVal value As Object)
            _DataSource = value
        End Set
    End Property


#Region "Eventos"

    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event CambioDeTexto(ByVal objData As Object)
    Public Event ActivarAyuda(ByRef _DataSource As Object)
    Public Event Consultar(ByVal strData As String, ByRef objData As Object)
#End Region

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        ofrmAyuda.txtDato.Text = ""
        Ayuda()
    End Sub

    Private Sub Ayuda()
        RaiseEvent Consultar(txtAyuda.Text.Trim.ToUpper, _DataSource)
        ofrmAyuda.dtgData.AutoGenerateColumns = False
        ofrmAyuda.DataSource = _DataSource
        ofrmAyuda.cboCriterio.SelectedValue = DispleyMember
        'ofrmAyuda.
        If ofrmAyuda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _FiltroData = ofrmAyuda.objResultado
            If Not _FiltroData Is Nothing Then
                Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing)
                Me.txtAyuda.Tag = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing)
                RaiseEvent CambioDeTexto(_FiltroData)
            Else
                Me.txtAyuda.Text = ""
                Me.txtAyuda.Tag = ""
                _FiltroData = Nothing
                RaiseEvent CambioDeTexto(_FiltroData)
            End If

        Else
            Me.txtAyuda.Text = ""
            Me.txtAyuda.Tag = ""
            _FiltroData = Nothing
            RaiseEvent CambioDeTexto(_FiltroData)

        End If
    End Sub
    Public Sub Cargas()
        ofrmAyuda.dtgData.Columns.Clear()
        If Columnas Is Nothing Then Exit Sub

        For intCont As Integer = 1 To Me.Columnas.Count
            ofrmAyuda.dtgData.Columns.Add(Columnas.Item(intCont))
        Next
    End Sub


    Private Sub txtAyuda_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAyuda.GotFocus
        Try
            If Not _FiltroData Is Nothing Then
                Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
            End If
        Catch : End Try

    End Sub

    Private Sub txtAyuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAyuda.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
                txtAyuda.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtAyuda.Text = "" Then
                    _FiltroData = Nothing
                    RaiseEvent CambioDeTexto(_FiltroData)
                Else
                    If Not _FiltroData Is Nothing Then
                        If txtAyuda.Text.ToUpper.Trim <> _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim Then
                            Buscar()
                        End If
                    Else
                        Buscar()
                    End If
                End If
            Case Keys.F4
                Call btnAyuda_Click(Nothing, Nothing)
        End Select
    End Sub


    Private Sub txtAyuda_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAyuda.Validated
        If _FiltroData Is Nothing Then
            Me.txtAyuda.Text = ""
        Else
            Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing).ToString.Trim & " - " & _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
            Me.txtAyuda.SelectAll()
        End If
    End Sub

    Private Sub txtAyuda_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAyuda.Validating
        If Not _FiltroData Is Nothing Then
            If Me.txtAyuda.Tag.ToString.Trim = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing).ToString.Trim AndAlso Me.txtAyuda.Text.Trim = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim Then
                Exit Sub
            End If
        End If
        Buscar()
    End Sub


    Private Sub Buscar()
        If _DataSource Is Nothing OrElse _DataSource.Count = 0 Then Exit Sub
        If txtAyuda.Text.Trim.Equals("") Then
            Me.txtAyuda.Text = ""
            Me.txtAyuda.Tag = ""
            _FiltroData = Nothing
            RaiseEvent CambioDeTexto(_FiltroData)
            Exit Sub
        End If
        'Valor
        RaiseEvent Consultar(txtAyuda.Text.Trim.ToUpper, _DataSource)
        Dim pre1 As Type = GetType(Busqueda(Of ))
        Dim tipo1 As Type = _DataSource(0).GetType
        Dim tipos1() As Type = {tipo1}
        Dim obj1 As Type = pre1.MakeGenericType(tipos1)
        Dim oPred1 As Object = Activator.CreateInstance(obj1, ValueMember, txtAyuda.Text.Trim.ToUpper)
        _FiltroData = _DataSource.FindAll(oPred1.Predicado)
        If Not _FiltroData Is Nothing Then
            If _FiltroData.Count = 1 Then
                _FiltroData = _FiltroData.Item(0)
                ofrmAyuda.objResultado = _FiltroData
                Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
                Me.txtAyuda.Tag = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing)
                RaiseEvent CambioDeTexto(_FiltroData)
                Exit Sub
            End If
        Else
            Me.txtAyuda.Text = ""
            Me.txtAyuda.Tag = ""
            _FiltroData = Nothing
            RaiseEvent CambioDeTexto(_FiltroData)
        End If

        'Descripcion
        Dim pre2 As Type = GetType(Predicado(Of ))
        Dim tipo2 As Type = _DataSource(0).GetType
        Dim tipos2() As Type = {tipo2}
        Dim obj2 As Type = pre2.MakeGenericType(tipos2)
        Dim oPred2 As Object = Activator.CreateInstance(obj2, DispleyMember, txtAyuda.Text.Trim.ToUpper)
        _FiltroData = _DataSource.FindAll(oPred2.Predicado)
        If Not _FiltroData Is Nothing Then
            If _FiltroData.Count > 1 Then
                ofrmAyuda.txtDato.Text = txtAyuda.Text.Trim.ToUpper
                Ayuda()
            Else
                If _FiltroData.Count = 0 Then
                    Me.txtAyuda.Text = ""
                    Me.txtAyuda.Tag = ""
                    _FiltroData = Nothing
                    RaiseEvent CambioDeTexto(_FiltroData)
                Else
                    _FiltroData = _FiltroData.Item(0)
                    Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
                    Me.txtAyuda.Tag = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing)
                    RaiseEvent CambioDeTexto(_FiltroData)
                End If

            End If
        Else
            Me.txtAyuda.Text = ""
            Me.txtAyuda.Tag = ""
            _FiltroData = Nothing
            RaiseEvent CambioDeTexto(_FiltroData)
        End If
    End Sub


    ''' <summary>
    ''' Valor que se digita en el txt
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property Valor() As String
        Set(ByVal value As String)
            Me.txtAyuda.Text = value
            Buscar()
        End Set
    End Property

    Public Sub Limpiar()
        Me.txtAyuda.Text = ""
        Me.txtAyuda.Tag = ""
        _FiltroData = Nothing
        RaiseEvent CambioDeTexto(_FiltroData)
    End Sub

    Public Sub Filtrar()
        RaiseEvent Consultar(txtAyuda.Text.Trim.ToUpper, _DataSource)
    End Sub
End Class
