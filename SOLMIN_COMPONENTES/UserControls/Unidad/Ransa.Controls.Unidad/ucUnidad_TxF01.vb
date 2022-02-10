Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.DAO.Unidad
'Imports Ransa.TypeDef.Unidad

Public Class ucUnidad_TxF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirm(ByVal Pregunta As String, ByRef Cancelar As Boolean)
    ' Eventos a Procesar
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    'Private oUnidad As cUnidad = New Ransa.DAO.Unidad.cUnidad
    Private oUnidad As cUnidad = New cUnidad
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private sUnidadActual As String = ""
    Private sTipoUnidad As String = ""
    Private strMensajeError As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private blnIsRequired As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property TipoUnidad() As String
        Get
            Return sTipoUnidad
        End Get
        Set(ByVal value As String)
            sTipoUnidad = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return txtUnidad.Text
        End Get
        Set(ByVal value As String)
            txtUnidad.Text = value
            sUnidadActual = value
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                txtUnidad.StateCommon.Back.Color1 = Nothing
            Else
                txtUnidad.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        Dim sDefault As String = ""
        Dim dtTemp As DataTable = oUnidad.fdtListar(sTipoUnidad, sDefault)
        If strMensajeError <> "" Then
            RaiseEvent ErrorMessage(strMensajeError)
            Exit Sub
        Else
            If dtTemp.Rows.Count > 0 Then
                Dim rwTemp As DataRow
                For Each rwTemp In dtTemp.Rows
                    txtUnidad.AutoCompleteCustomSource.Add(("" & rwTemp.Item(0)).ToString.Trim)
                Next
            End If
        End If
    End Sub
#End Region
#Region " Eventos "
    Private Sub ucUnidad_TxF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oUnidad.Dispose()
        oUnidad = Nothing
    End Sub

    Private Sub ucUnidad_TxF01_CmbF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call pCargarInformacion()
    End Sub

    Private Sub ucUnidad_TxF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        txtUnidad.Width = Width
        Me.Height = txtUnidad.Height
    End Sub

    Private Sub txtUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.GotFocus
        txtUnidad.SelectAll()
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
        If e.KeyCode = Keys.Escape Then
            If sUnidadActual <> "" Then
                txtUnidad.Text = sUnidadActual
            Else
                txtUnidad.Text = ""
            End If
        End If
    End Sub

    Private Sub txtUnidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.Validated
        sUnidadActual = txtUnidad.Text
    End Sub

    Private Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidad.Validating
        If sUnidadActual.ToUpper.Trim <> txtUnidad.Text.ToUpper.Trim Then
            Dim sTemp As String = ""
            For Each sTemp In txtUnidad.AutoCompleteCustomSource
                If sTemp.ToUpper.Trim = txtUnidad.Text.ToUpper.Trim Then
                    txtUnidad.Text = sTemp
                    Exit Sub
                End If
            Next
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        sUnidadActual = ""
        txtUnidad.Text = ""
    End Sub
#End Region
End Class