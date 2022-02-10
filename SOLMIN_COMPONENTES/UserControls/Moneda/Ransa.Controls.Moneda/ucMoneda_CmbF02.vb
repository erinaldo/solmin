Public Class ucMoneda_CmbF02
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private pMoneda As New Moneda_BE
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
    Dim dtTemp As New DataTable
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCargarPorCodigo() As String
        Set(ByVal value As String)
            Call pObtenerMoneda(value)
        End Set
    End Property
    Public WriteOnly Property pCargarPorAbreviatura() As String
        Set(ByVal value As String)
            Call pObtenerMonedaAbreiatura(value)
        End Set
    End Property
    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                cmbMoneda.BackColor = Nothing
            Else
                cmbMoneda.BackColor = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pInformacionSelec() As Moneda_BE
        Get
            Return pMoneda
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerMoneda(ByVal Codigo As String) As Boolean
        Dim CMNDA1 As String = ""
        Dim Encontrado As Boolean = False
        For Each Item As DataRow In dtTemp.Rows
            CMNDA1 = ("" & Item("CMNDA1")).ToString.Trim
            If Codigo = CMNDA1 AndAlso Codigo.Trim.Length > 0 Then
                Encontrado = True
                Exit For
            End If
        Next
        If Encontrado = True Then
            cmbMoneda.SelectedValue = Codigo
            With pMoneda
                .pCMNDA1_Codigo = cmbMoneda.SelectedValue
                .pTMNDA_Detalle = cmbMoneda.Text
            End With
        Else
            cmbMoneda.SelectedValue = "-1"
            With pMoneda
                .pCMNDA1_Codigo = ""
                .pTMNDA_Detalle = ""
            End With
        End If
    End Function

    Public Function pObtenerMonedaAbreiatura(ByVal Abreviatura As String) As Boolean
        Dim TSGNMN As String = ""
        Dim CMNDA1 As String = ""
        Dim Encontrado As Boolean = False
        For Each Item As DataRow In dtTemp.Rows
            TSGNMN = ("" & Item("TSGNMN")).ToString.Trim
            If Abreviatura = TSGNMN AndAlso Abreviatura.Trim.Length > 0 Then
                CMNDA1 = Item("CMNDA1")
                Encontrado = True
                Exit For
            End If
        Next
        If Encontrado = True Then
            cmbMoneda.SelectedValue = CMNDA1
            With pMoneda
                .pCMNDA1_Codigo = cmbMoneda.SelectedValue
                .pTMNDA_Detalle = cmbMoneda.Text
            End With
        Else
            cmbMoneda.SelectedValue = "-1"
            With pMoneda
                .pCMNDA1_Codigo = ""
                .pTMNDA_Detalle = ""
            End With
        End If
    End Function
#End Region
#Region " Eventos "
    Public Sub pCargarDatos()
        Dim oMoneda_DAL As New Moneda_DAL
        dtTemp = oMoneda_DAL.fdtListar_Listar_Moneda(strMensajeError)
        If strMensajeError <> "" Then RaiseEvent ErrorMessage(strMensajeError)
        Dim TMNDA As String = ""
        Dim CMNDA1 As String = ""
        Dim dr As DataRow
        For Each Item As DataRow In dtTemp.Rows
            CMNDA1 = ("" & Item("CMNDA1")).ToString.Trim
            TMNDA = ("" & Item("TMNDA")).ToString.Trim
            Item("TMNDA") = CMNDA1 & " - " & TMNDA
        Next
        dr = dtTemp.NewRow
        dr("CMNDA1") = "-1"
        dr("TMNDA") = "::Seleccione::"
        dr("TSGNMN") = ""
        dtTemp.Rows.InsertAt(dr, 0)
        cmbMoneda.DataSource = dtTemp
        cmbMoneda.DisplayMember = "TMNDA"
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.SelectedValue = "-1"
    End Sub


    Private Sub ucTipoAyuda_CmbF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Height = cmbMoneda.Height
    End Sub

#End Region
#Region " Métodos "
    Public Sub pClear()
        With pMoneda
            .pCMNDA1_Codigo = ""
            .pTMNDA_Detalle = ""
        End With
        cmbMoneda.SelectedValue = "-1"
    End Sub
#End Region

    Private Sub cmbMoneda_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectionChangeCommitted
        If cmbMoneda.SelectedValue = "-1" Then
            With pMoneda
                .pCMNDA1_Codigo = ""
                .pTMNDA_Detalle = ""
            End With
        Else
            With pMoneda
                .pCMNDA1_Codigo = cmbMoneda.SelectedValue
                .pTMNDA_Detalle = cmbMoneda.Text
            End With
        End If
    End Sub
End Class