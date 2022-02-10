
Public Class ucCliente_Check


    Public Property Obligatorio() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                txtAyuda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            End If
        End Set
        Get
            If txtAyuda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

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

    Private ofrmAyuda As New frmCliente_Check
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
#End Region

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        ofrmAyuda.txtDato.Text = ""
        txtAyuda.Text = ""
        txtAyuda.Tag = ""
        Ayuda()
    End Sub

    Private Sub Ayuda()

        ofrmAyuda.dtgData.AutoGenerateColumns = False
        ofrmAyuda.DataSource = _DataSource
        ofrmAyuda.DispleyMember = _DispleyMember
        ofrmAyuda.ValueMember = _ValueMember
        ofrmAyuda.Valida_Booleam = True
        ofrmAyuda.Buscar()
        If ofrmAyuda.ShowDialog() = Windows.Forms.DialogResult.OK Then

            _FiltroData = ofrmAyuda.ItemsV

            If Not ofrmAyuda.ItemsS Is Nothing Then
                'Me.txtAyuda.Text = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing)
                'Me.txtAyuda.Tag = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing)
                Me.txtAyuda.Text = ""
                For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                    Me.txtAyuda.Text += i & ","
                Next

                If Me.txtAyuda.Text <> "" Then Me.txtAyuda.Text = Me.txtAyuda.Text.Trim.Substring(0, Me.txtAyuda.Text.Trim.Length - 1)

                Me.txtAyuda.Tag = Me.txtAyuda.Text

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
                If _FiltroData.GetType.Name.ToString.Trim = "beCliente" Then

                    'If Me.txtAyuda.Tag.ToString.Trim = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing).ToString.Trim AndAlso Me.txtAyuda.Text.Trim = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim Then

                    Me.txtAyuda.Text = ""
                    Me.txtAyuda.Text = CType(_FiltroData, beCliente).Descripcion.ToString.Trim
                    'End If

                    Exit Sub
                Else

                    Dim str As String = ""
                    For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                        str += i & ","
                    Next
                    If str <> "" Then str = str.Trim.Substring(0, str.Trim.Length - 1)

                    'If Me.txtAyuda.Tag.ToString.Trim = str.Trim Then
                    '_FiltroData = Nothing
                    'Exit Sub
                    'Else
                    Me.txtAyuda.Text = str.Trim
                    'End If

                    'Me.txtAyuda.Text = ""
                    'For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                    '    Me.txtAyuda.Text += i & ","
                    'Next

                    'If Me.txtAyuda.Text <> "" Then Me.txtAyuda.Text = Me.txtAyuda.Text.Trim.Substring(0, Me.txtAyuda.Text.Trim.Length - 1)

                End If

            End If
        Catch : End Try

    End Sub

    Private Sub txtAyuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAyuda.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtAyuda.Text = ""
                _FiltroData = Nothing
                RaiseEvent CambioDeTexto(_FiltroData)
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtAyuda.Text = "" Then
                    _FiltroData = Nothing
                    RaiseEvent CambioDeTexto(_FiltroData)
                Else
                    If Not _FiltroData Is Nothing Then

                        Dim str As String = ""
                        For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                            str += i & ","
                        Next
                        If str <> "" Then str = str.Trim.Substring(0, str.Trim.Length - 1)

                        If txtAyuda.Text.ToUpper.Trim <> str.ToUpper.Trim Then '_FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim Then
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

        If _FiltroData Is Nothing Or txtAyuda.Text.Trim = "" Then
            Me.txtAyuda.Text = ""
            Me.txtAyuda.Tag = ""
            _FiltroData = Nothing

        Else
            If _FiltroData.GetType.Name.ToString.Trim = "beCliente" Then
                Me.txtAyuda.Text = CType(_FiltroData, beCliente).Descripcion.ToString.Trim
            Else

                Dim str As String = ""
                For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                    str += i & ","
                Next
                If str <> "" Then str = str.Trim.Substring(0, str.Trim.Length - 1)

                Me.txtAyuda.Text = str '_FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing).ToString.Trim & " - " & _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim
                Me.txtAyuda.SelectAll()
            End If

        End If

    End Sub

    Private Sub txtAyuda_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAyuda.Validating

        If Not _FiltroData Is Nothing Then

            If _FiltroData.GetType.Name.ToString.Trim = "beCliente" Then

                'If Me.txtAyuda.Tag.ToString.Trim = _FiltroData.GetType.GetProperty(ValueMember).GetValue(_FiltroData, Nothing).ToString.Trim AndAlso Me.txtAyuda.Text.Trim = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing).ToString.Trim Then

                If Me.txtAyuda.Tag.ToString.Trim = CType(_FiltroData, beCliente).Descripcion.ToString.Trim AndAlso Me.txtAyuda.Tag.ToString.Trim = txtAyuda.Text.ToString.Trim Then
                    Exit Sub
                End If

                ' Exit Sub
                'End If
            Else

                Dim str As String = ""
                'Dim str1 As String = ""

                For Each i As String In CType(ofrmAyuda.ItemsS, List(Of String))
                    str += i & ","
                Next
                If str <> "" Then str = str.Trim.Substring(0, str.Trim.Length - 1)

                'For Each j As String In CType(ofrmAyuda.ItemsV, List(Of String))
                '    str1 += j & ","
                'Next
                'If str1 <> "" Then str1 = str1.Trim.Substring(0, str1.Trim.Length - 1)

                If Me.txtAyuda.Tag.ToString.Trim = str.Trim AndAlso Me.txtAyuda.Tag.ToString.Trim = txtAyuda.Text.ToString.Trim Then
                    '_FiltroData = Nothing
                    Exit Sub
                End If


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

                Me.txtAyuda.Text = CType(_FiltroData, beCliente).Descripcion
                Me.txtAyuda.Tag = CType(_FiltroData, beCliente).Descripcion
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
                ofrmAyuda.txtDato.Text = txtAyuda.Text.Trim.ToUpper()
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
                    Me.txtAyuda.Tag = _FiltroData.GetType.GetProperty(DispleyMember).GetValue(_FiltroData, Nothing)
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

    Private Sub txtAyuda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAyuda.TextChanged

        
    End Sub

End Class
