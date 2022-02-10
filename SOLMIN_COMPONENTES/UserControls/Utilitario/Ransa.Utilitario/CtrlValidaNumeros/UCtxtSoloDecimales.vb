Public Class UCtxtSoloDecimales


    Private _NumerosEnteros As Integer = 15
    Private _NumerosDecimales As Integer = 2
    Private _TextSizeWidth As Integer = 0
    Private _Texto As String = String.Empty


    Public Property NumerosEnteros() As Integer
        Get
            Return _NumerosEnteros
        End Get
        Set(ByVal value As Integer)
            _NumerosEnteros = value
        End Set
    End Property

    Public Property NumerosDecimales() As Integer
        Get
            Return _NumerosDecimales
        End Get
        Set(ByVal value As Integer)
            _NumerosDecimales = value
        End Set
    End Property

    Public Property Obligatorio() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                txtDecimales.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            End If
        End Set
        Get
            If txtDecimales.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property


    Private Sub txtDecimales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDecimales.KeyDown
        Clipboard.Clear()
    End Sub


    Private Sub txtDecimales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDecimales.KeyPress
        Dim dig As Integer = Len(txtDecimales.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Try

            If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57 Then
                e.Handled = False

            Else
                If Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If

            End If



            If NumerosDecimales = 0 Then
                'se valida que solo sea enteros
                If e.KeyChar = "." Then
                    e.Handled = True
                End If
            Else
                ' se verifica si es un digito o un punto 
                If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                    Exit Sub
                Else
                    e.Handled = True
                End If
            End If




            ' se verifica que el primer digito ingresado no sea un punto al seleccionar
            If txtDecimales.SelectedText <> "" Then
                If e.KeyChar = "." Then
                    e.Handled = True
                    Exit Sub
                End If
            End If
            If dig = 1 And e.KeyChar = "." Then
                e.Handled = True
                Exit Sub
            End If
            'aqui se hace la verificacion cuando es seleccionado el valor del texto
            'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
            If txtDecimales.SelectedText = "" Then
                ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
                Dim inti As Integer = 0
                Dim intc As Integer = 0

                ''''

                inti = 0
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtDecimales.Text & e.KeyChar)
                    If car.Substring(a, 1) = "." Then
                        inti = inti + 1
                        If inti > 1 Then e.Handled = True
                    End If
                Next

                esDec = False
                inti = 0
                ' se valida los numeros enteros
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtDecimales.Text & e.KeyChar)


                    If car.Substring(a, 1) = "." Then
                        esDec = True
                    End If


                    If Not esDec Then
                        inti += 1
                        If inti >= NumerosEnteros + 1 Then
                            If Not Char.IsControl(e.KeyChar) Then
                                e.Handled = True
                                Exit Sub
                            Else
                                e.Handled = False
                            End If

                        End If

                    End If


                Next


                esDec = False
                'Se controlo la cantidad de decimales
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtDecimales.Text & e.KeyChar)
                    If car.Substring(a, 1) = "." Then
                        esDecimal = esDecimal + 1
                        esDec = True
                    End If
                    If esDec = True Then
                        NumDecimales = NumDecimales + 1
                    End If
                    ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 

                    If NumDecimales > NumerosDecimales + 1 Then
                        e.Handled = True
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

  
   
End Class
