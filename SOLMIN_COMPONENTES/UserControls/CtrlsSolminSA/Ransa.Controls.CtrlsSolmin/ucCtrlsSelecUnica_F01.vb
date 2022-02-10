Public Class ucCtrlsSelecUnica_F01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private dtinformacion As DataTable

    Private sCondicion As String = " "
    Private sCampoSeleccionado As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bLoadInf As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pCampoSeleccionado() As String
        Get
            Return sCampoSeleccionado
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pFiltrarInformacion()
        If Not bLoadInf Then Exit Sub
        If sCondicion <> txtCondicion.Text.ToUpper.Trim Then
            Dim dvTemp As DataView = dtinformacion.DefaultView
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "%"
            ' Validamos de que exista información ingresada
            If txtCondicion.Text <> "" Then sSQL = "Convert(CAMP01,'System.String') like '" & sTemp & txtCondicion.Text & "%'"
            dvTemp.RowFilter = sSQL
            dgBusqueda.DataSource = dvTemp
            sCondicion = txtCondicion.Text.ToUpper.Trim
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Informacion As DataTable, Optional ByVal sTituloColuma As String = "CODIGO", Optional ByVal Titulo As String = "")
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        bLoadInf = True
        Informacion.Columns(0).ColumnName = "CAMP01"
        dtinformacion = Informacion
        dgBusqueda.DataSource = Informacion
        dgBusqueda.Columns(0).HeaderText = sTituloColuma
        Me.Text = Titulo
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgBusqueda.RowCount > 0 Then
            sCampoSeleccionado = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtCondicion.Text = ""
        Me.Close()
    End Sub

    Private Sub chkEnlaCadena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnLaCadena.CheckedChanged
        Call pFiltrarInformacion()
        txtCondicion.CausesValidation = False
    End Sub

    Private Sub dgBusqueda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBusqueda.DoubleClick
        If dgBusqueda.RowCount > 0 Then
            sCampoSeleccionado = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub dgBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            sCampoSeleccionado = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub txtCondicion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCondicion.GotFocus
        txtCondicion.SelectAll()
    End Sub

    Private Sub txtCondicion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCondicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCondicion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCondicion.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pFiltrarInformacion()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class