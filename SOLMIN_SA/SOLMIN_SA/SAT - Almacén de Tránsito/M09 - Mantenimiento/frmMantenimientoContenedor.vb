Imports RANSA.TypeDef
Imports RANSA.NEGO
Imports Ransa.Utilitario
Public Class frmMantenimientoContenedor

#Region "Declaracion de Variables"

    Public PNCCLNT As Decimal
    Public PSCCMPN As String
    Public Cliente As String
    Public Compania As String
    Private obrContenedor As New brContenedor
    Private obeContenedor As New beContenedor
    Public PubContenedor As New beContenedor
    Public ActualizarDatos As Boolean = False
    Public Grabar As Boolean = False

#End Region

#Region "Procedimientos y Funciones"

    Private Sub Llenardatos()

        txtSigla.Text = PubContenedor.PSCPRPCN.Trim
        txtNumero.Text = PubContenedor.PSNSRECN.Trim

        cmbMaterial.SelectedValue = PubContenedor.PSCMTRCN
        cboDimension.Text = PubContenedor.PSCDMNCN
        cmbColor.SelectedValue = PubContenedor.PSCCLOR
        cmbTipo.SelectedValue = PubContenedor.PSCTPOC1
        txtTara.Text = PubContenedor.PNQTRACN.ToString("N2")
        txtCargaUtil.Text = PubContenedor.PNQPSMXC.ToString("N2")
        txtCubica.Text = PubContenedor.PNQCPCBC.ToString("N2")
        dtFechabricacion.Value = CType(PubContenedor.PSDESFFACCN, Date)
        dtInspeccion.Value = CType(PubContenedor.PSDESFINCSC, Date)
        txtObs.Text = PubContenedor.PSTOBSCN.Trim
        chkEstado.Checked = IIf(PubContenedor.PSSESCN1 = "1", True, False)
        txtSigla.Enabled = False
        txtNumero.Enabled = False

    End Sub

    Private Function fnvalidaGuardar() As Boolean
        Dim strMensaje As String = String.Empty

        If txtSigla.Text.Trim.Length = 0 Then
            strMensaje = "-Ingrese Sigla" & System.Environment.NewLine

        End If
        If txtNumero.Text.Trim.Length = 0 Then
            strMensaje = strMensaje & "-Ingrese Número " & System.Environment.NewLine

        End If
        If cboDimension.Text.Trim.Length = 0 Then
            strMensaje = strMensaje & "-Ingrese Dimensión " & System.Environment.NewLine

        End If
        If txtTara.Text.Trim.Length = 0 Then
            strMensaje = strMensaje & "-Ingrese tara" & System.Environment.NewLine

        End If

        If txtCubica.Text.Trim.Length = 0 Then
            strMensaje = strMensaje & "-Ingrese Capacidad Cubica " & System.Environment.NewLine

        End If

        If txtCargaUtil.Text.Trim.Length = 0 Then
            strMensaje = strMensaje & "-Ingrese Carga Util" & System.Environment.NewLine

        End If

        If strMensaje.Length > 0 Then
            HelpClass.MsgBox(strMensaje, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub cargarCombos()
        Try
            cmbColor.DataSource = obrContenedor.dtListaColorContenedor()
            cmbColor.ValueMember = "CCLRS"
            cmbColor.DisplayMember = "TABCLR"

            cmbMaterial.DataSource = obrContenedor.dtListaMaterialContenedor()
            cmbMaterial.ValueMember = "CMTRCN"
            cmbMaterial.DisplayMember = "TABMCN"

            cmbTipo.DataSource = obrContenedor.dtListaTipoContenedor()
            cmbTipo.ValueMember = "CTPCN1"
            cmbTipo.DisplayMember = "TATPC1"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


#End Region

#Region "Eventos de Control"
    Public Function BuscarOrdendeCompra(ByVal pbeOrdenCompra As beContenedor) As Boolean
        If PNCCLNT = 0 Then

            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If fnvalidaGuardar() = False Then
                Exit Sub
            End If

            obeContenedor = New beContenedor
            Dim strMensaje As String = String.Empty
            obeContenedor.PNCCLNT = PNCCLNT
            obeContenedor.PSCCMPN = PSCCMPN

            obeContenedor.PSCPRPCN = txtSigla.Text.Trim
            obeContenedor.PSNSRECN = txtNumero.Text.Trim

            obeContenedor.PSCMTRCN = cmbMaterial.SelectedValue
            obeContenedor.PSCDMNCN = cboDimension.Text
            obeContenedor.PSCCLOR = cmbColor.SelectedValue
            obeContenedor.PSCTPOC1 = cmbTipo.SelectedValue
            obeContenedor.PNQTRACN = txtTara.Text
            obeContenedor.PNQPSMXC = txtCargaUtil.Text
            obeContenedor.PNQCPCBC = txtCubica.Text
            obeContenedor.PNFFACCN = HelpClass.CDate_a_Numero8Digitos(dtFechabricacion.Value)
            obeContenedor.PNFINCSC = HelpClass.CDate_a_Numero8Digitos(dtInspeccion.Value)
            obeContenedor.PSTOBSCN = txtObs.Text.Trim
            obeContenedor.PSSESCN1 = IIf(chkEstado.Checked, "1", "0")
            obeContenedor.PSNTRMNL = objSeguridadBN.pstrPCName
            obeContenedor.PSCUSCRT = objSeguridadBN.pUsuario
            obeContenedor.PSSESTRG = "A"
            Grabar = True
            If ActualizarDatos Then


                If obrContenedor.ActualizarContenedor(obeContenedor) = 1 Then
                    HelpClass.MsgBox("Se Actualizaron los datos satisfactoriamente", MessageBoxIcon.Information)

                Else
                    HelpClass.MsgBox("Hubo un error, Comunique a Sistemas", MessageBoxIcon.Error)
                End If
            Else
                obeContenedor.nPageNumber = 1
                obeContenedor.nPageSize = 20
                'Dim List As List(Of beContenedor)
                'obrContenedor.ListarContenedor(obeContenedor)
                'List.ForEach(New Action(Of beContenedor)(AddressOf BuscarOrdendeCompra))
                'obrContenedor.ListarContenedor(obeContenedor).ForEach(new Action(Of beContenedor)addressof  obrContenedor.ListarContenedor(obeContenedor)

                'For Each h As beContenedor In obrContenedor.ListarContenedor(obeContenedor)

                'Next


                'obrContenedor.ListarContenedor(obeContenedor).ForEach(Function(h As beContenedor) Do


                'End Function)


                If obrContenedor.ListarContenedor(obeContenedor).Count > 0 Then
                    HelpClass.MsgBox("Contenedor ya se encuetra registrado", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If obrContenedor.InsertarContenedor(obeContenedor) = 1 Then
                    HelpClass.MsgBox("Se grabaron los datos satisfactoriamente", MessageBoxIcon.Information)

                Else
                    HelpClass.MsgBox("Hubo un error, Comunique a Sistemas", MessageBoxIcon.Error)
                End If
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub frmMantenimientoContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCliente.Text = Cliente
            txtCompania.Text = Compania
            cboDimension.SelectedIndex = 0
            cargarCombos()
            If ActualizarDatos Then
                Llenardatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Grabar = False
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub txtTara_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTara.KeyPress
        Dim dig As Integer = Len(txtTara.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Try


            ' se verifica si es un digito o un punto 
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Return
            Else
                e.Handled = True
            End If

            ' se verifica que el primer digito ingresado no sea un punto al seleccionar
            If txtTara.SelectedText <> "" Then
                If e.KeyChar = "." Then
                    e.Handled = True
                    Return
                End If
            End If
            If dig = 1 And e.KeyChar = "." Then
                e.Handled = True
                Return
            End If
            'aqui se hace la verificacion cuando es seleccionado el valor del texto
            'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
            If txtTara.SelectedText = "" Then
                ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
                Dim inti As Integer = 0
                Dim intc As Integer = 0
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtTara.Text & e.KeyChar)
                    inti = car.IndexOf(".")
                    If inti > 6 Then

                        e.Handled = True
                    End If

                    If car.Substring(a, 1) = "." Then
                        esDec = True
                    End If

                    If esDec = False And intc = 6 Then
                        e.Handled = True
                    End If
                    intc = intc + 1

                Next

                ''''
                esDec = False


                For a = 0 To dig - 1
                    Dim car As String = CStr(txtTara.Text & e.KeyChar)
                    If car.Substring(a, 1) = "." Then
                        esDecimal = esDecimal + 1
                        esDec = True
                    End If
                    If esDec = True Then
                        NumDecimales = NumDecimales + 1
                    End If
                    ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                    If NumDecimales >= 4 Or esDecimal >= 2 Then
                        e.Handled = True
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCubica_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCubica.KeyPress
        Dim dig As Integer = Len(txtCubica.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Try


            ' se verifica si es un digito o un punto 
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Return
            Else
                e.Handled = True
            End If

            ' se verifica que el primer digito ingresado no sea un punto al seleccionar
            If txtCubica.SelectedText <> "" Then
                If e.KeyChar = "." Then
                    e.Handled = True
                    Return
                End If
            End If
            If dig = 1 And e.KeyChar = "." Then
                e.Handled = True
                Return
            End If
            'aqui se hace la verificacion cuando es seleccionado el valor del texto
            'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
            If txtCubica.SelectedText = "" Then
                ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
                Dim inti As Integer = 0
                Dim intc As Integer = 0
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtCubica.Text & e.KeyChar)
                    inti = car.IndexOf(".")
                    If inti > 6 Then

                        e.Handled = True
                    End If

                    If car.Substring(a, 1) = "." Then
                        esDec = True
                    End If

                    If esDec = False And intc = 6 Then
                        e.Handled = True
                    End If
                    intc = intc + 1

                Next

                ''''
                esDec = False


                For a = 0 To dig - 1
                    Dim car As String = CStr(txtCubica.Text & e.KeyChar)
                    If car.Substring(a, 1) = "." Then
                        esDecimal = esDecimal + 1
                        esDec = True
                    End If
                    If esDec = True Then
                        NumDecimales = NumDecimales + 1
                    End If
                    ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                    If NumDecimales >= 4 Or esDecimal >= 2 Then
                        e.Handled = True
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCargaUtil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargaUtil.KeyPress
        Dim dig As Integer = Len(txtCargaUtil.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        Try


            ' se verifica si es un digito o un punto 
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Return
            Else
                e.Handled = True
            End If

            ' se verifica que el primer digito ingresado no sea un punto al seleccionar
            If txtCargaUtil.SelectedText <> "" Then
                If e.KeyChar = "." Then
                    e.Handled = True
                    Return
                End If
            End If
            If dig = 1 And e.KeyChar = "." Then
                e.Handled = True
                Return
            End If
            'aqui se hace la verificacion cuando es seleccionado el valor del texto
            'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
            If txtCargaUtil.SelectedText = "" Then
                ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
                Dim inti As Integer = 0
                Dim intc As Integer = 0
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtCargaUtil.Text & e.KeyChar)
                    inti = car.IndexOf(".")
                    If inti > 6 Then

                        e.Handled = True
                    End If

                    If car.Substring(a, 1) = "." Then
                        esDec = True
                    End If

                    If esDec = False And intc = 6 Then
                        e.Handled = True
                    End If
                    intc = intc + 1

                Next

                ''''
                esDec = False


                For a = 0 To dig - 1
                    Dim car As String = CStr(txtCargaUtil.Text & e.KeyChar)
                    If car.Substring(a, 1) = "." Then
                        esDecimal = esDecimal + 1
                        esDec = True
                    End If
                    If esDec = True Then
                        NumDecimales = NumDecimales + 1
                    End If
                    ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                    If NumDecimales >= 4 Or esDecimal >= 2 Then
                        e.Handled = True
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDimension_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



#End Region

End Class
