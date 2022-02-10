Imports Ransa.Controls.CtrlsSolmin
Imports Ransa.DAO.Proveedor
Imports Ransa.TypeDef.Proveedor

Public Class ucProveedor_TxtF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Event MostrarManAlternativo()
    Public Shadows Event InformationChanged()
    Public Shadows Event TextChanged()
    Public Shadows Event ExitFocusWithOutData()
#End Region

#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private oProveedor As cProveedor
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInf_Proveedor As TD_Inf_LstProveedor_F02 = New TD_Inf_LstProveedor_F02
    Private oQry_Proveedor As TD_Qry_LstProveedor_F02 = New TD_Qry_LstProveedor_F02
    Private obeQry_Proveedor As New beProveedor()

    Private sErrorMessage As String = ""
    Private verPop As Boolean = False
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bIsRequired As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private pUsuario As String = ""

#End Region
#Region " Propiedades "
    Public Property pCodigo() As Int64
        Get
            Return oInf_Proveedor.pCPRVCL_Proveedor
        End Get
        Set(ByVal value As Int64)
            If value <> 0 Then Call pObtenerProveedor(value)
        End Set
    End Property

    Public ReadOnly Property pRazonSocial() As String
        Get
            Return oInf_Proveedor.pTPRVCL_DescripcionProveedor
        End Get
    End Property

    Public ReadOnly Property pNroRuc() As Int64
        Get
            Return oInf_Proveedor.pNRUCPR_NroRUC
        End Get
    End Property

    Public WriteOnly Property Usuario() As String
        Set(ByVal value As String)
            pUsuario = value
        End Set
    End Property

    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                txtProveedor.StateCommon.Back.Color1 = Nothing
            Else
                txtProveedor.StateCommon.Back.Color1 = Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public Property pMostarBtnNewProv() As Boolean
        Get
            Return bsaNewProv.Visible
        End Get
        Set(ByVal value As Boolean)
            bsaNewProv.Visible = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Public Sub ActualizarBusqueda(ByVal CPRVCL As String)
        CPRVCL = CPRVCL.Trim
        txtProveedor.Text = CPRVCL
        fbBuscarActualizado()
    End Sub
    Private Function fbBuscarActualizado() As Boolean
        ' Limpiamos los filtros existentes

        Dim oFiltroProveedorForm As New TD_Qry_Proveedor()

        oFiltroProveedorForm.clear()
        obeQry_Proveedor.pclear()
        obeQry_Proveedor.PageSize = 20
        obeQry_Proveedor.PageNumber = 1
        obeQry_Proveedor.PSBUSQUEDA = "D"

        ' Evaluamos la condición      
        If IsNumeric(txtProveedor.Text.Trim) Then

            If txtProveedor.Text.Trim.Length <= 6 Then
                obeQry_Proveedor.PSCPRVCLSTR = txtProveedor.Text.Trim
                obeQry_Proveedor.PSBUSQUEDA = "C" ' BUSQUEDA POR CODIGO

                oFiltroProveedorForm.PSCPRVCLSTR = txtProveedor.Text
            End If
            If txtProveedor.Text.Length > 6 Then ' BUSQUEDA POR RUC
                obeQry_Proveedor.PSNRUCPRSTR = txtProveedor.Text.Trim
                obeQry_Proveedor.PSBUSQUEDA = "R"
                oFiltroProveedorForm.PSNRUCPRSTR = txtProveedor.Text.Trim
            End If
        Else

            Dim sTemp As String = txtProveedor.Text.Trim.Replace("*", "")
            Dim iLong As Integer = sTemp.Length
            If IsNumeric(sTemp) Then
                If txtProveedor.Text.Length > 0 Then
                    ' Evaluamos la Asignación
                    If iLong < 6 Then
                        obeQry_Proveedor.PSCPRVCLSTR = txtProveedor.Text.Trim
                        oFiltroProveedorForm.PSCPRVCLSTR = txtProveedor.Text.Trim
                    End If
                    If iLong >= 6 Then
                        obeQry_Proveedor.PSNRUCPRSTR = txtProveedor.Text.Trim
                        oFiltroProveedorForm.PSNRUCPRSTR = txtProveedor.Text.Trim
                    End If

                End If
            Else
                ' Busca segun los ingresado sino muestra todo
                If txtProveedor.Text.ToUpper.Trim <> oInf_Proveedor.pTPRVCL_DescripcionProveedor.ToUpper Then
                    sTemp = txtProveedor.Text.Trim
                    obeQry_Proveedor.PSTPRVCL = sTemp
                    oFiltroProveedorForm.PSTPRVCL = sTemp

                End If
            End If


        End If

        '--------------
        ' Variables
        '--------------
        Dim blnCancelar As Boolean = False
        '--------------
        ' Proceso
        '--------------
        Try


            Dim oListaProveedor As New List(Of beProveedor)
            oListaProveedor = oProveedor.ListaProveedoresPaginado(obeQry_Proveedor)

            If oListaProveedor.Count = 0 Then
                RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
                txtProveedor.Text = oInf_Proveedor.pTPRVCL_DescripcionProveedor.Trim
                txtProveedor.SelectAll()
                blnCancelar = True

            Else
                If oListaProveedor.Count = 1 Then
                    oInf_Proveedor.pCPRVCL_Proveedor = oListaProveedor.Item(0).PNCPRVCL.ToString.Trim
                    oInf_Proveedor.pTPRVCL_DescripcionProveedor = oListaProveedor.Item(0).PSTPRVCL.Trim
                    oInf_Proveedor.pNRUCPR_NroRUC = oListaProveedor.Item(0).PNNRUCPR.ToString.Trim
                    RaiseEvent InformationChanged()

                Else

                    Dim fbusqueda As New ucProveedor_FProveedor()
                    fbusqueda.oFiltroProveedor = oFiltroProveedorForm
                    fbusqueda.ShowDialog(Me)
                    If fbusqueda.pSeleccion.PNCPRVCL <> 0 Then
                        oInf_Proveedor.pCPRVCL_Proveedor = fbusqueda.pSeleccion.PNCPRVCL.Trim
                        oInf_Proveedor.pTPRVCL_DescripcionProveedor = fbusqueda.pSeleccion.PSTPRVCL.Trim
                        oInf_Proveedor.pNRUCPR_NroRUC = fbusqueda.pSeleccion.PNNRUCPR.Trim
                        RaiseEvent InformationChanged()
                    End If


                End If
                txtProveedor.Text = oInf_Proveedor.pTPRVCL_DescripcionProveedor
                txtProveedor.SelectAll()
                RaiseEvent TextChanged()
            End If

        Catch ex As Exception
        End Try
        Return blnCancelar


    End Function
    Private Function pObtenerProveedor(ByVal Codigo As Int64) As Boolean
        Dim oObj_Proveedor As TD_Obj_Proveedor_F01 = oProveedor.Obtener(Codigo, sErrorMessage)
        Dim blnResultado As Boolean = False
        If sErrorMessage <> "" Then
            RaiseEvent ErrorMessage(sErrorMessage)
        Else
            If oObj_Proveedor.pCPRVCL_Proveedor <> 0 Then
                With oInf_Proveedor
                    .pCPRVCL_Proveedor = oObj_Proveedor.pCPRVCL_Proveedor
                    .pTPRVCL_DescripcionProveedor = oObj_Proveedor.pTPRVCL_DescripcionProveedor
                    .pNRUCPR_NroRUC = oObj_Proveedor.pNRUCPR_NroRUC
                End With
            End If
        End If
        If Me.Focused Then
            txtProveedor.Text = oObj_Proveedor.pTPRVCL_DescripcionProveedor
            txtProveedor.SelectAll()
        Else
            If oInf_Proveedor.pCPRVCL_Proveedor <> 0 Then
                txtProveedor.Text = oInf_Proveedor.pCPRVCL_Proveedor & " - " & oInf_Proveedor.pTPRVCL_DescripcionProveedor
            Else
                txtProveedor.Text = ""
            End If
        End If
        Return blnResultado
    End Function

    Private Sub pHandler_Mensaje(ByVal strMensaje As String)
        RaiseEvent ErrorMessage(strMensaje)
    End Sub
#End Region
#Region " Eventos "
    Private Sub bsaNewProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNewProv.Click
        Dim ofrmProveedor_MDatos As New frmProveedor_MDatos()
        ofrmProveedor_MDatos.IsNuevo = True
        ofrmProveedor_MDatos.ShowDialog(Me)
        If (ofrmProveedor_MDatos.oInfoProveedor.PNCPRVCL <> -1 And ofrmProveedor_MDatos.oInfoProveedor.PNCPRVCL <> 0) Then
            txtProveedor.Text = ofrmProveedor_MDatos.oInfoProveedor.PNCPRVCL
            fbBuscarActualizado()
        End If
    End Sub

    Private Sub bsaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProveedor.Click

        txtProveedor.Focus()
        Call fbBuscarActualizado()

    End Sub

    Private Sub ucProveedor_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtProveedor.Width = Width
        Me.Height = txtProveedor.Height
    End Sub

    Private Sub ucProveedor_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtProveedor.Width = Width
        Me.Height = txtProveedor.Height
    End Sub

    Private Sub txtProveedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedor.GotFocus

        txtProveedor.Text = oInf_Proveedor.pTPRVCL_DescripcionProveedor
        txtProveedor.SelectAll()

    End Sub

    Private Sub txtProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProveedor.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtProveedor.Text = oInf_Proveedor.pTPRVCL_DescripcionProveedor
                txtProveedor.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If (txtProveedor.Text.ToUpper.Trim = "") Then
                    oInf_Proveedor.pClear()
                Else
                    If txtProveedor.Text.ToUpper.Trim <> oInf_Proveedor.pTPRVCL_DescripcionProveedor.ToUpper Then
                        Call fbBuscarActualizado()
                    Else
                        txtProveedor.SelectAll()
                    End If
                End If
              
            Case Keys.F4
                Call fbBuscarActualizado()              
        End Select

    End Sub

    Private Sub txtProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedor.Validated
        If oProveedor.ErrorMessage = "" Then
            If oInf_Proveedor.pCPRVCL_Proveedor <> 0 Then
                txtProveedor.Text = oInf_Proveedor.pCPRVCL_Proveedor & " - " & oInf_Proveedor.pTPRVCL_DescripcionProveedor
            Else
                txtProveedor.Text = ""
                oInf_Proveedor.pClear()
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtProveedor.Text = ""
            RaiseEvent TextChanged()
            RaiseEvent ExitFocusWithOutData()
        End If


    End Sub

    Private Sub txtProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProveedor.Validating
        If txtProveedor.Text = "" Then
            oInf_Proveedor.pClear()
        Else
            If IsNumeric(txtProveedor.Text.Trim) Then
                If txtProveedor.Text.Trim <> oInf_Proveedor.pCPRVCL_Proveedor Then e.Cancel = fbBuscarActualizado()
            Else
                If txtProveedor.Text.ToUpper.Trim <> oInf_Proveedor.pTPRVCL_DescripcionProveedor.ToUpper.Trim Then e.Cancel = fbBuscarActualizado()
            End If
            If txtProveedor.Text.ToUpper.Trim <> oInf_Proveedor.pTPRVCL_DescripcionProveedor.ToUpper.Trim Then e.Cancel = fbBuscarActualizado()

        End If

    End Sub

   
#End Region
#Region " Métodos "
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oProveedor = New cProveedor
    End Sub

    Public Sub pClear()
        txtProveedor.Text = ""
        oInf_Proveedor.pClear()
    End Sub
#End Region
End Class