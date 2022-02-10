Public Class ucTipoAyuda_CmbF02
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private pTipoAyuda As New TipoAyuda_BE
    Private blnIsRequired As Boolean = False
    Private strMensajeError As String = ""
    Dim dtTemp As New DataTable
#End Region
#Region " Propiedades "


    Public WriteOnly Property pCargarPorCodigo() As String
        Set(ByVal value As String)
            Call pObtenerTipoAyuda(value)
        End Set
    End Property

    Public Property pIsRequired() As Boolean
        Get
            Return blnIsRequired
        End Get
        Set(ByVal value As Boolean)
            blnIsRequired = value
            If Not blnIsRequired Then
                cmbTipoAyuda.BackColor = Nothing
            Else
                cmbTipoAyuda.BackColor = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public ReadOnly Property pInformacionSelec() As TipoAyuda_BE
        Get
            Return pTipoAyuda
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pObtenerTipoAyuda(ByVal Codigo As String) As Boolean
        Dim CCMPRN As String = ""
        Dim Encontrado As Boolean = False
        For Each Item As DataRow In dtTemp.Rows
            CCMPRN = ("" & Item("CCMPRN")).ToString.Trim
            If Codigo = CCMPRN Then
                Encontrado = True
                Exit For
            End If
        Next
        If Encontrado = True Then
            cmbTipoAyuda.SelectedValue = Codigo
            With pTipoAyuda
                .pCCMPRN_Codigo = cmbTipoAyuda.SelectedValue
                .pTDSDES_Detalle = cmbTipoAyuda.Text.Trim
            End With
        Else
            cmbTipoAyuda.SelectedValue = "-1"
            With pTipoAyuda
                .pCCMPRN_Codigo = ""
                .pTDSDES_Detalle = ""
            End With
        End If
        Return True
    End Function
#End Region
#Region " Eventos "
    Public Sub pCargarDatos(ByVal Categoria_RZO103 As String, ByVal TextoPrimero As String)
        TextoPrimero = TextoPrimero.Trim
        Dim oTipoAyuda_DAL As New TipoAyuda_DAL
        Dim dr As DataRow
        If Categoria_RZO103 <> "" Then
            Dim CCMPRN As String = ""
            Dim TDSDES As String = ""
            dtTemp = oTipoAyuda_DAL.fdtListar_TablaAyuda_L01(Categoria_RZO103, strMensajeError)
            For Each Item As DataRow In dtTemp.Rows
                CCMPRN = ("" & Item("CCMPRN")).ToString.Trim
                TDSDES = ("" & Item("TDSDES")).ToString.Trim
                Item("TDSDES") = CCMPRN & " - " & TDSDES
            Next          
            dr = dtTemp.NewRow
            dr("CCMPRN") = "-1"
            dr("TDSDES") = TextoPrimero
            dtTemp.Rows.InsertAt(dr, 0)
            cmbTipoAyuda.DataSource = dtTemp
            cmbTipoAyuda.DisplayMember = "TDSDES"
            cmbTipoAyuda.ValueMember = "CCMPRN"
            cmbTipoAyuda.SelectedValue = "-1"
        End If
    End Sub


    Private Sub ucTipoAyuda_CmbF02_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        cmbTipoAyuda.Height = Me.Height
        cmbTipoAyuda.Width = Me.Width
        cmbTipoAyuda.DropDownWidth = Me.Width
    End Sub

    Private Sub cmbTipoAyuda_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoAyuda.SelectionChangeCommitted
        If cmbTipoAyuda.SelectedValue = "-1" Then
            With pTipoAyuda
                .pCCMPRN_Codigo = ""
                .pTDSDES_Detalle = ""
            End With
        Else
            With pTipoAyuda
                .pCCMPRN_Codigo = cmbTipoAyuda.SelectedValue
                .pTDSDES_Detalle = cmbTipoAyuda.Text.Trim
            End With
        End If
    End Sub

#End Region
#Region " Métodos "
    Public Sub pClear()
        With pTipoAyuda
            .pCCMPRN_Codigo = ""
            .pTDSDES_Detalle = ""
        End With
        cmbTipoAyuda.SelectedValue = "-1"
    End Sub
#End Region



End Class
