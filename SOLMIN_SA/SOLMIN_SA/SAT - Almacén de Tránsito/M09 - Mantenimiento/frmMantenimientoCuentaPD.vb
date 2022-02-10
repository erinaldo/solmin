
Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Public Class frmMantenimientoCuentaPD

#Region "Declaracion de variables"
    Public PNCCLNT As Decimal = 0
    Public PNNSEQIN As Decimal = 0
    Public Porcentaje As Decimal = 0

    Private PNNCRRDT = 0
    Public PSNORCML As String = String.Empty
    Public obeOrdenCompra As New beOrdenCompra
    Private obrOrdeCompra As New brOrdenDeCompra
    Public ActualizarDatos As Boolean = False
    Public Grabar As Boolean = False
    Private nNuevoPorcentaje, nAnteriorPorcentaje As Decimal
#End Region

#Region "Metodos y funciones"
    Private Function Validar() As String
        Dim strMensaje As String = ""

        nNuevoPorcentaje = 0


        If (txtCentroCosto.Text.Trim = "" And txtCuentaAfectacion.Text.Trim = "" And txtCostoAereo.Text.Trim = "" And txtCostoFluvial.Text.Trim = "") Then
            If (txtCentroCosto.Text.Trim = "") Then
                strMensaje = "* Ingrese C.I Terrestre"
                txtCentroCosto.Focus()
                Return strMensaje
            End If
           
            If (txtCostoAereo.Text.Trim = "") Then
                strMensaje = "* Ingrese C.I Aereo"
                txtCostoAereo.Focus()
                Return strMensaje
            End If
            If (txtCostoFluvial.Text.Trim = "") Then
                strMensaje = "* Ingrese C.I Fluvial"
                txtCostoFluvial.Focus()
                Return strMensaje
            End If

            If (txtCuentaAfectacion.Text.Trim = "") Then
                strMensaje = "* Ingrese C.I Afectación"
                txtCuentaAfectacion.Focus()
                Return strMensaje
            End If
        End If

        If txtPorcentaje.Text.Length = 0 Or txtPorcentaje.Text = "0" Then
            strMensaje = "* Ingrese porcentaje mayor cero"
            Return strMensaje
        Else
            If ActualizarDatos = False Then
                If (Porcentaje + Convert.ToDecimal(txtPorcentaje.Text)) > 100 Then
                    strMensaje = "* No puede superar el 100 porciento"
                    Return strMensaje
                End If
            Else

                nNuevoPorcentaje = Convert.ToDecimal(txtPorcentaje.Text)
                If nAnteriorPorcentaje > 0 And nNuevoPorcentaje > 0 Then
                    If nAnteriorPorcentaje <> nNuevoPorcentaje Then
                        If ((Porcentaje - nAnteriorPorcentaje) + nNuevoPorcentaje) > 100 Then
                            strMensaje = "* No puede superar el 100 porciento"
                            Return strMensaje
                        End If
                    End If
                End If
            End If

        End If


        Return strMensaje
    End Function
   

    Private Function ObtenerDatos() As beOrdenCompra
        Dim obeOrdenCompra = New beOrdenCompra

        obeOrdenCompra.PNCCLNT = PNCCLNT
        obeOrdenCompra.PSNORCML = PSNORCML
        obeOrdenCompra.PNNSEQIN = PNNSEQIN
        obeOrdenCompra.PNNCRRDT = PNNCRRDT
        obeOrdenCompra.PSTCTCST = txtCentroCosto.Text
        obeOrdenCompra.PSTCTCSA = txtCostoAereo.Text
        obeOrdenCompra.PSTCTCSF = txtCostoFluvial.Text
        obeOrdenCompra.PSTCTAFE = txtCuentaAfectacion.Text
        obeOrdenCompra.PNIPRCTJ = IIf(txtPorcentaje.Text.Length = 0, "0", txtPorcentaje.Text)

        obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
        obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario
        obeOrdenCompra.PSCUSCRT = objSeguridadBN.pUsuario
        obeOrdenCompra.PSNTRMCR = objSeguridadBN.pstrPCName

        Return obeOrdenCompra
    End Function

    Private Sub InicializarControles()
        txtCentroCosto.Text = ""
        txtCuentaAfectacion.Text = ""
        txtCostoAereo.Text = ""
        txtCostoFluvial.Text = ""

    End Sub

    Private Sub VisualizarDatos()

        txtCentroCosto.Text = obeOrdenCompra.PSTCTCST.Trim
        txtCostoAereo.Text = obeOrdenCompra.PSTCTCSA.Trim
        txtCostoFluvial.Text = obeOrdenCompra.PSTCTCSF.Trim
        txtCuentaAfectacion.Text = obeOrdenCompra.PSTCTAFE.Trim
        txtPorcentaje.Text = Math.Round(obeOrdenCompra.PNIPRCTJ, 2)
        nAnteriorPorcentaje = Math.Round(obeOrdenCompra.PNIPRCTJ, 2)
        PNNSEQIN = obeOrdenCompra.PNNSEQIN
        PNCCLNT = obeOrdenCompra.PNCCLNT
        PNNCRRDT = obeOrdenCompra.PNNCRRDT
        PSNORCML = obeOrdenCompra.PSNORCML
    End Sub
#End Region

#Region "Eventos de Control"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try


            Dim resultado As Int32 = 0
            Dim obeOrdenCompra As New beOrdenCompra
            obrOrdeCompra = New brOrdenDeCompra
            Dim strmensajeValidacion As String = Validar()

            If (strmensajeValidacion <> "") Then
                MessageBox.Show(strmensajeValidacion, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If (ActualizarDatos = True) Then
                resultado = obrOrdeCompra.fintInsertarCuentaImputacionDistribucion(ObtenerDatos())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente ", "Actualización Cuenta Imputación")
                    Grabar = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Actualización Cuenta Imputación")
                End If
            Else
                resultado = obrOrdeCompra.fintInsertarCuentaImputacionDistribucion(ObtenerDatos())
                If (resultado = 1) Then
                    MessageBox.Show("Se ha grabado satisfactoriamente  ", "Registro Cuenta Imputación")
                    Grabar = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("No se pudo realizar la operación ", "Registro Cuenta Imputación")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmMantenimientoCuentaPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializarControles()
        txtPorcentaje.Enabled = False
        If (ActualizarDatos = True) Then
            VisualizarDatos()

        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
#End Region




   
    Private Sub txtPorcentaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        Dim dig As Integer = Len(txtPorcentaje.Text & e.KeyChar)
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
            If txtPorcentaje.Text.Length > 1 Then
                If Val(txtPorcentaje.Text & e.KeyChar) > 100 Then
                    txtPorcentaje.Text = "100"
                    e.Handled = True
                End If
            End If

            ' se verifica que el primer digito ingresado no sea un punto al seleccionar
            If txtPorcentaje.SelectedText <> "" Then
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
            If txtPorcentaje.SelectedText = "" Then
                ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
                Dim inti As Integer = 0
                Dim intc As Integer = 0
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
                    inti = car.IndexOf(".")
                    If inti > 3 Then

                        e.Handled = True
                    End If

                    If car.Substring(a, 1) = "." Then
                        esDec = True
                    End If

                    If esDec = False And intc = 3 Then
                        e.Handled = True
                    End If
                    intc = intc + 1

                Next

                ''''
                esDec = False
                For a = 0 To dig - 1
                    Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
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

End Class
