Imports SOLMIN_TR.DATOS.Entidades
Imports SOLMIN_TR.NEGOCIO

Public Class TBCliente
    Inherits TextBox

    Dim objEntidad As New Clientes
    Dim Tamano_Original As Integer
    Public _v_Codcli As String

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(pe)
    End Sub

    Private Sub TBCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            Busqueda_Cliente()
        End If
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            LimpiarCliente()
        End If

    End Sub

    Public Sub LimpiarCliente()
        Me.Text = ""
        objEntidad.CCLNT = ""
    End Sub

    Public Property CodigoCliente() As String
        Get
            If _v_Codcli = "" Then
                Return objEntidad.CCLNT
            Else
                Return _v_Codcli
            End If
        End Get
        Set(ByVal value As String)
            objEntidad.CCLNT = value
            Me.Text = value
            Busqueda_Cliente()
        End Set
    End Property

    Private Sub Busqueda_Cliente()

        Dim TipoBusquedaAlfanumerico As Boolean = True 'si es alfanumerico, false si es numerico

        If Me.Text.Trim.Equals("") = True Then 
            Exit Sub
        End If

        If IsNumeric(Me.Text) = False Then
            TipoBusquedaAlfanumerico = True
            If Len(Me.Text) < 3 Then
                Exit Sub
            End If
        Else
            TipoBusquedaAlfanumerico = False
        End If

        Dim objEntidad As New Clientes
        Dim objCliente As New ClienteDAO
        Dim dtb As New DataTable

        If objEntidad.CCLNT.Equals("") = False Then
            objEntidad.TCMPCL = objEntidad.CCLNT
        Else
            objEntidad.TCMPCL = Me.Text
        End If

        If TipoBusquedaAlfanumerico = True Then
            dtb = objCliente.Busqueda_Cliente(objEntidad)
        Else
            dtb = objCliente.Busqueda_Cliente_x_codigo(objEntidad)
        End If


        If dtb.Rows.Count > 0 Then

            'si es un solo resultado lo pinta y desaparece
            If dtb.Rows.Count = 1 Then
                objEntidad.CCLNT = dtb.Rows(0).Item("CODIGO")
                _v_Codcli = objEntidad.CCLNT 
                objEntidad = objCliente.Obtener_Cliente(objEntidad)
                Me.Text = CompletarCadena(objEntidad.CCLNT, 6, " ", HorizontalAlignment.Right) & " -> " & objEntidad.TCMPCL.Trim
                Exit Sub
            End If

            Dim frmBusquedaCliente As New frmBuscaCliente
            frmBusquedaCliente.ShowFormLoad(objEntidad, Me)
            objEntidad = frmBusquedaCliente.Obtener_Cliente()

            If objEntidad.CCLNT = "" Then
                Me.Text = ""
                objEntidad.CCLNT = ""
                Exit Sub
            Else
                Me.Text = CompletarCadena(objEntidad.CCLNT, 6, " ", HorizontalAlignment.Right) & " -> " & objEntidad.TCMPCL.Trim
                Exit Sub
            End If

        Else
            Me.Text = ""
            Me.objEntidad.CCLNT = ""
        End If

    End Sub
 

    Public Function CompletarCadena(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As HorizontalAlignment)

        'funcion para completar una cadena
        Dim longitudActual As Integer = Texto.Length

        For i As Integer = longitudActual To Longitud
            If Orientacion = HorizontalAlignment.Right Then
                Texto = Texto & Caracter
            Else
                Texto = Caracter & Texto
            End If
        Next

        Return Texto

    End Function

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregando el control de popup menu
        Me.ContextMenuStrip = Me.PopupMenuTexto

        'Estableciendo como Upper Casing el textbox
        Me.CharacterCasing = Windows.Forms.CharacterCasing.Upper

    End Sub

    Private Sub LimpiarTexto(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLimpiarElemento.Click
        Me.Text = ""
        objEntidad.CCLNT = ""
    End Sub

    Private Sub BusquedaAvanzada(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBusquedaAvanzada.Click

        Dim frmBusquedaCliente As New frmBuscaCliente
        frmBusquedaCliente.ShowFormLoad(objEntidad, Me)
        objEntidad = frmBusquedaCliente.Obtener_Cliente()

        If objEntidad.CCLNT = "" Then
            Me.Text = ""
            objEntidad.CCLNT = ""
            Exit Sub
        Else
            _v_Codcli = objEntidad.CCLNT
            Me.Text = CompletarCadena(objEntidad.CCLNT, 6, " ", HorizontalAlignment.Right) & " -> " & objEntidad.TCMPCL.Trim
            Exit Sub
        End If

    End Sub

    Private Function ObtenerCliente() As Clientes

        Dim frmBusquedaCliente As New frmBuscaCliente
        frmBusquedaCliente.ShowFormLoad(objEntidad, Me)
        Return frmBusquedaCliente.Obtener_Cliente()

    End Function


End Class
