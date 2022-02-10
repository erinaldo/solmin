Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.CtrlsSolmin
'Imports Ransa.DAO.CtrlsSolminSA.Ubicacion
'Imports Ransa.TypeDef.CtrlsSolminSA.Ubicacion

Public Class ucCtrlsSolminSA_TxUbicAlm
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    'Private oUbicacion As cUbicacion
    Private oUbicacion As Ubicacion.cUbicacion
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    'Private oTD_Ubicacion As TD_Ubicacion = New TD_Ubicacion
    'Private oTF_Ubicacion As TF_Ubicacion = New TF_Ubicacion
    Private oTD_Ubicacion As Ubicacion.TD_Ubicacion = New Ubicacion.TD_Ubicacion
    Private oTF_Ubicacion As Ubicacion.TF_Ubicacion = New Ubicacion.TF_Ubicacion
    Private dtUbicacion As DataTable = Nothing
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bCargando As Boolean = False
    Private bIsRequired As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Overrides Property Text() As String
        Get
            Return oTD_Ubicacion.pTUBRFR_Ubicacion
        End Get
        Set(ByVal value As String)
            If oTD_Ubicacion.pCCLNT_Cliente <> 0 Then
                oTD_Ubicacion.pTUBRFR_Ubicacion = value
                txtUbicacion.Text = value
            End If
        End Set
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtUbicacion.StateCommon.Back.Color1 = Nothing
            Else
                txtUbicacion.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fbBuscar(ByVal Condicion As String) As Boolean
        While bCargando
            If Not bCargando Then Exit While
        End While
        '--------------
        ' Variables
        '--------------
        Dim blnCancelar As Boolean = False
        Dim dvTemp As DataView = dtUbicacion.DefaultView
        Dim sSQL As String = " TUBRFR like '%" & Condicion.ToUpper.Trim & "%'"
        '--------------
        ' Proceso
        '--------------
        oTF_Ubicacion.pCondicion = Condicion
        Try
            dvTemp.RowFilter = sSQL
            If dvTemp.Count = 0 Then
                RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
                txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
                txtUbicacion.SelectAll()
                blnCancelar = True
            Else
                If dvTemp.Count = 1 Then
                    oTD_Ubicacion.pTUBRFR_Ubicacion = ("" & dvTemp.ToTable.Rows(0).Item(0)).ToString.Trim
                    txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
                    txtUbicacion.SelectAll()
                    blnCancelar = False
                Else
                    Dim ofbusqueda As ucCtrlsSelecUnica_F01 = New ucCtrlsSelecUnica_F01(dvTemp.ToTable, "UBICACIÓN", "BUSQUEDA : Ubicación")
                    ofbusqueda.ShowDialog()
                    If ofbusqueda.pCampoSeleccionado <> "" Then
                        oTD_Ubicacion.pTUBRFR_Ubicacion = ofbusqueda.pCampoSeleccionado
                    End If
                    txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
                    txtUbicacion.SelectAll()
                End If
            End If
        Catch ex As Exception
            RaiseEvent ErrorMessage("Error en la condición de búsqueda.")
            txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
            txtUbicacion.SelectAll()
            blnCancelar = True
        End Try
        Return blnCancelar
    End Function
#End Region
#Region " Eventos "
    Private Sub bgwGetData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGetData.DoWork
        dtUbicacion = oUbicacion.Listar(oTF_Ubicacion)
    End Sub

    Private Sub bgwGetData_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGetData.RunWorkerCompleted
        bCargando = False
    End Sub

    Private Sub bsaBuscarUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBuscarUbicacion.Click
        Dim sTemp As String = ""
        ' Busca segun los ingresado sino muestra todo
        If txtUbicacion.Text.ToUpper.Trim <> oTD_Ubicacion.pTUBRFR_Ubicacion.ToUpper Then sTemp = txtUbicacion.Text.ToUpper.Trim
        Call fbBuscar(sTemp)
        txtUbicacion.Focus()
    End Sub

    Private Sub ucCtrlsSolminSA_TxUbicAlm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oUbicacion.Dispose()
        oUbicacion = Nothing
    End Sub

    Private Sub ucCtrlsSolminSA_TxUbicAlm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUbicacion.Width = Width
        Me.Height = txtUbicacion.Height
    End Sub

    Private Sub ucCtrlsSolminSA_TxUbicAlm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtUbicacion.Width = Width
        Me.Height = txtUbicacion.Height
    End Sub

    Private Sub txtUbicacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbicacion.GotFocus
        txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
        txtUbicacion.SelectAll()
    End Sub

    Private Sub txtUbicacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUbicacion.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
                txtUbicacion.SelectAll()
            Case Keys.Enter
                Dim sTemp As String = ""
                ' Busca segun los ingresado sino muestra todo
                If txtUbicacion.Text.ToUpper.Trim <> oTD_Ubicacion.pTUBRFR_Ubicacion.ToUpper.Trim Then
                    sTemp = txtUbicacion.Text.ToUpper.Trim
                    Call fbBuscar(sTemp)
                Else
                    txtUbicacion.SelectAll()
                End If
            Case Keys.F4
                Dim sTemp As String = ""
                ' Busca segun los ingresado sino muestra todo
                If txtUbicacion.Text.ToUpper.Trim <> oTD_Ubicacion.pTUBRFR_Ubicacion.ToUpper.Trim Then sTemp = txtUbicacion.Text.ToUpper.Trim
                Call fbBuscar(sTemp)
        End Select
    End Sub

    Private Sub txtUbicacion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbicacion.Validated
        If oUbicacion.ErrorMessage = "" Then
            If oTD_Ubicacion.pTUBRFR_Ubicacion <> "" Then
                txtUbicacion.Text = oTD_Ubicacion.pTUBRFR_Ubicacion
            Else
                txtUbicacion.Text = ""
                oTD_Ubicacion.pClear()
            End If
        Else
            txtUbicacion.Text = ""
        End If
    End Sub

    Private Sub txtUbicacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUbicacion.Validating
        If txtUbicacion.Text = "" Then
            oTD_Ubicacion.pClear()
        Else
            If txtUbicacion.Text.ToUpper.Trim <> oTD_Ubicacion.pTUBRFR_Ubicacion.ToUpper.Trim Then e.Cancel = fbBuscar(txtUbicacion.Text.ToUpper.Trim)
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'oUbicacion = New cUbicacion
        oUbicacion = New Ubicacion.cUbicacion
    End Sub

    Public Sub pCargarInformacion(ByVal pCCLNT_Cliente As Int64)
        oTF_Ubicacion.pCCLNT_Cliente = pCCLNT_Cliente
        bCargando = True
        bgwGetData.RunWorkerAsync()
    End Sub

    Public Sub pClear()
        txtUbicacion.Text = ""
        oTD_Ubicacion.pClear()
    End Sub
#End Region
End Class