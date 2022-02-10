Imports System.Reflection

Public Class UcMedioTransporte

    Private _DataSource As Object

    Public Property DataSource() As Object
        Get
            Return _DataSource
        End Get
        Set(ByVal value As Object)
            _DataSource = value
        End Set
    End Property


    Private _objResult As Object
    Public Property objResult() As Object
        Get
            Return _objResult
        End Get
        Set(ByVal value As Object)
            _objResult = value
        End Set
    End Property


    Private _DataMember As String = ""
    Public Property DataMember() As String
        Get
            Return _DataMember
        End Get
        Set(ByVal value As String)
            _DataMember = value
        End Set
    End Property

    Private _DataValue As String = ""
    Public Property DataValue() As String
        Get
            Return _DataValue
        End Get
        Set(ByVal value As String)
            _DataValue = value
        End Set
    End Property

#Region "Eventos"
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event CambioDeTexto(ByVal strData As String, ByRef objData As Object)
    Public Event ObtenerData(ByVal strData As String)
    Public Event ActivarAyuda(ByRef objData As Object)
#End Region
    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click

        RaiseEvent ActivarAyuda(_DataSource)
        Dim ofrmAyuda As New frmAyuda
        ofrmAyuda.DataMember = _DataMember
        ofrmAyuda.DataValue = _DataValue
        ofrmAyuda.DataSource = _DataSource
        If ofrmAyuda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            objResult = ofrmAyuda.objResultado
            Me.txtMedioTransporte.Text = objResult.GetType.GetProperty(_DataValue).GetValue(objResult, Nothing)
            Me.txtMedioTransporte.Tag = objResult.GetType.GetProperty(_DataMember).GetValue(objResult, Nothing)
        Else
            _objResult = Nothing
            _DataSource = Nothing
        End If
    End Sub

    Private Sub txtMedioTransporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedioTransporte.TextChanged
        'RaiseEvent CambioDeTexto(Me.txtMedioTransporte.Text)
    End Sub

    Private Sub txtMedioTransporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedioTransporte.Validated
        If objResult Is Nothing Then
            Me.txtMedioTransporte.Text = ""
        Else
            Me.txtMedioTransporte.Text = objResult.GetType.GetProperty(_DataValue).GetValue(objResult, Nothing).ToString.Trim
        End If

    End Sub

    Private Sub txtMedioTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMedioTransporte.Validating

        If Not _objResult Is Nothing Then
            If Me.txtMedioTransporte.Text.Trim = objResult.GetType.GetProperty(_DataValue).GetValue(objResult, Nothing).ToString.Trim Then
                Exit Sub
            End If
        End If
        RaiseEvent CambioDeTexto(Me.txtMedioTransporte.Text, _DataSource)
        If Not _DataSource Is Nothing Then
            If _DataSource.Count > 1 Then
                btnAyuda_Click(Nothing, Nothing)
            Else
                If _DataSource.Count = 0 Then
                    objResult = Nothing
                    Me.txtMedioTransporte.Text = ""
                    Me.txtMedioTransporte.Tag = ""
                    Exit Sub
                End If
                objResult = _DataSource.Item(0)
                Me.txtMedioTransporte.Text = objResult.GetType.GetProperty(_DataValue).GetValue(objResult, Nothing).ToString.Trim
                Me.txtMedioTransporte.Tag = objResult.GetType.GetProperty(_DataMember).GetValue(objResult, Nothing)
            End If
        Else
            _objResult = Nothing
        End If
        _DataSource = Nothing
    End Sub
    Public Sub Refrescar(ByVal strDato As String)
        Me.txtMedioTransporte.Text = strDato
        txtMedioTransporte_Validating(Nothing, Nothing)
    End Sub
End Class
