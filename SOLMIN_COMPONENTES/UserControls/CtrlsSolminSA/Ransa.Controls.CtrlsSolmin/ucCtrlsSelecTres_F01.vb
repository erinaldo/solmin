Public Class ucCtrlsSelecTres_F01
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

    Private sCondicion01 As String = " "
    Private sCondicion02 As String = " "
    Private sCondicion03 As String = " "

    Private sValCol01 As String = ""
    Private sValCol02 As String = ""
    Private sValCol03 As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bLoadInf As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pValCol01() As String
        Get
            Return sValCol01.Trim
        End Get
    End Property

    Public ReadOnly Property pValCol02() As String
        Get
            Return sValCol02.Trim
        End Get
    End Property

    Public ReadOnly Property pValCol03() As String
        Get
            Return sValCol03.Trim
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pFiltrarInformacion()
        If Not bLoadInf Then Exit Sub
        If sCondicion01 <> txtCampo01.Text.ToUpper.Trim Or sCondicion02 <> txtCampo02.Text.ToUpper.Trim Or _
           sCondicion03 <> txtCampo03.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim dvTemp As DataView = dtinformacion.DefaultView
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "%"
            ' Validamos de que exista información ingresada
            If txtCampo01.Text <> "" Then
                sSQL &= "Convert(CAMP01,'System.String') like '" & sTemp & txtCampo01.Text.Trim & "%'"
            End If
            If txtCampo02.Text <> "" Then
                If sSQL <> "" Then sSQL = sSQL & " And "
                sSQL &= "Convert(CAMP02,'System.String') like '" & sTemp & txtCampo02.Text.Trim & "%'"
            End If
            If txtCampo03.Text <> "" Then
                If sSQL <> "" Then sSQL = sSQL & " And "
                sSQL &= "Convert(CAMP03,'System.String') like '" & sTemp & txtCampo03.Text.Trim & "%'"
            End If
            sCondicion01 = txtCampo01.Text.ToUpper.Trim
            sCondicion02 = txtCampo02.Text.ToUpper.Trim
            sCondicion03 = txtCampo03.Text.ToUpper.Trim
            dvTemp.RowFilter = sSQL
            dgBusqueda.DataSource = dvTemp
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Informacion As DataTable, Optional ByVal sHColName01 As String = "CODIGO", Optional ByVal sHColName02 As String = "DETALLE", _
            Optional ByVal sHColName03 As String = "", Optional ByVal Titulo As String = "")
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        bLoadInf = True
        Informacion.Columns(0).ColumnName = "CAMP01"
        Informacion.Columns(1).ColumnName = "CAMP02"
        Informacion.Columns(2).ColumnName = "CAMP03"
        dtinformacion = Informacion
        dgBusqueda.DataSource = Informacion
        dgBusqueda.Columns(0).HeaderText = sHColName01
        dgBusqueda.Columns(1).HeaderText = sHColName02
        dgBusqueda.Columns(2).HeaderText = sHColName03

        lblCampo01.Text = sHColName01
        lblCampo02.Text = sHColName02
        lblCampo03.Text = sHColName03

        Me.Text = Titulo
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgBusqueda.RowCount > 0 Then
            sValCol01 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
            sValCol02 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP02").Value).ToString.Trim
            sValCol03 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP03").Value).ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        sValCol01 = ""
        sValCol02 = ""
        sValCol03 = ""
        Me.Close()
    End Sub

    Private Sub chkEnlaCadena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnLaCadena.CheckedChanged
        Call pFiltrarInformacion()
    End Sub

    Private Sub dgBusqueda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBusqueda.DoubleClick
        If dgBusqueda.RowCount > 0 Then
            sValCol01 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
            sValCol02 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP02").Value).ToString.Trim
            sValCol03 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP03").Value).ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub dgBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgBusqueda.RowCount > 0 Then
                sValCol01 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP01").Value).ToString.Trim
                sValCol02 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP02").Value).ToString.Trim
                sValCol03 = ("" & dgBusqueda.CurrentRow.Cells("MCAMP03").Value).ToString.Trim
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtCampo01_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCampo01.GotFocus
        txtCampo01.SelectAll()
    End Sub

    Private Sub txtCampo01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCampo01.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCampo01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo01.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCampo02_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCampo02.GotFocus
        txtCampo02.SelectAll()
    End Sub

    Private Sub txtCampo02_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCampo02.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCampo02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo02.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCampo03_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCampo03.GotFocus
        txtCampo03.SelectAll()
    End Sub

    Private Sub txtCampo03_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCampo03.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pFiltrarInformacion()
        End If
    End Sub

    Private Sub txtCampo03_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo03.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pFiltrarInformacion()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
