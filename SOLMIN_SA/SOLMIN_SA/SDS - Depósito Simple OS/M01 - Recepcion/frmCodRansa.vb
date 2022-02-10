Imports RANSA.TYPEDEF
Imports RANSA.NEGO
Imports Ransa.Utilitario
Imports RANSA.TYPEDEF.beMercaderia

Public Class frmCodRansa

    Private _COD_PSCMRCD As String
    Public Property COD_PSCMRCD() As String
        Get
            Return _COD_PSCMRCD
        End Get
        Set(ByVal value As String)
            _COD_PSCMRCD = value
        End Set
    End Property

    Private _DES_PSCMRCD As String
    Public Property DES_PSCMRCD() As String
        Get
            Return _DES_PSCMRCD
        End Get
        Set(ByVal value As String)
            _DES_PSCMRCD = value
        End Set
    End Property

    Private ListaGeneral As List(Of RANSA.TYPEDEF.beMercaderia)
    Private bs As New BindingSource

    Private Sub frmCodRansa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtgRansa.AutoGenerateColumns = False
        Cargar_Familia()
        Cargar_Buscar()

    End Sub

    Private Sub Cargar_Buscar()

        Dim dt As New DataTable
        dt.Columns.Add("CODIGO")
        dt.Columns.Add("DESCRIPCION")

        Dim dr As DataRow
        dr = dt.NewRow
        dr("CODIGO") = 1
        dr("DESCRIPCION") = "Código"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("CODIGO") = 2
        dr("DESCRIPCION") = "Descripción"
        dt.Rows.Add(dr)

        cboBuscar.DataSource = dt
        cboBuscar.DisplayMember = "DESCRIPCION"
        cboBuscar.ValueMember = "CODIGO"

        cboBuscar.SelectedValue = 2

    End Sub

    Private Sub Cargar_Familia()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CFMLA"
        oColumnas.DataPropertyName = "PSCFMLA"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPFM"
        oColumnas.DataPropertyName = "PSTCMPFM"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        Dim obrMercaderia As New brMercaderia
        Dim obeFiltro As New beMercaderia
        Me.txtFamilia.DataSource = obrMercaderia.ListaFamiliaDeMercaderia(obeFiltro)
        Me.txtFamilia.ListColumnas = oListColum
        Me.txtFamilia.Cargas()
        Me.txtFamilia.DispleyMember = "PSTCMPFM"
        Me.txtFamilia.ValueMember = "PSCFMLA"

    End Sub

    Private Sub txtFamilia_CambioDeTexto(ByVal objData As Object) Handles txtFamilia.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CGRPO"
        oColumnas.DataPropertyName = "PSCGRPO"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPGR"
        oColumnas.DataPropertyName = "PSTCMPGR"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        If Not objData Is Nothing Then
            Dim obrMercaderia As New brMercaderia
            Me.txtGrupo.DataSource = obrMercaderia.ListaGrupoDeMercaderia(objData)
        Else
            Me.txtGrupo.DataSource = Nothing
        End If
        Me.txtGrupo.ListColumnas = oListColum
        Me.txtGrupo.Cargas()
        Me.txtGrupo.Limpiar()
        Me.txtGrupo.DispleyMember = "PSTCMPGR"
        Me.txtGrupo.ValueMember = "PSCGRPO"
    End Sub

    Private Sub txtGrupo_CambioDeTexto(ByVal objData As System.Object) Handles txtGrupo.CambioDeTexto

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CMRCD"
        oColumnas.DataPropertyName = "PSCMRCD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPMR"
        oColumnas.DataPropertyName = "PSTCMPMR"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        If Not objData Is Nothing Then
            Dim obrMercaderia As New brMercaderia
            ListaGeneral = obrMercaderia.flistListarMercaderiRansa(objData)
            'If ListaGeneral IsNot Nothing Then
            'ListaGeneral.Sort(New Ransa.Utilitario.Comparador(Of Ransa.TYPEDEF.beMercaderia))
            'End If
            bs.DataSource = ListaGeneral
            Me.dtgRansa.DataSource = bs

        Else
            Me.dtgRansa.DataSource = Nothing
        End If

    End Sub

    Function BuscarCodigo(ByVal obe As RANSA.TYPEDEF.beMercaderia) As Boolean
        Return (obe.PSCMRCD.ToUpper.StartsWith(txtDato.Text.ToUpper))
    End Function

    Function BuscarDescripcion(ByVal obe As RANSA.TYPEDEF.beMercaderia) As Boolean
        Return (obe.PSTCMPMR.ToUpper.StartsWith(txtDato.Text.ToUpper))
    End Function

    Private Sub Filtrar(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        If cboBuscar.SelectedValue = "1" Then
            Dim pred As New Predicate(Of Ransa.TYPEDEF.beMercaderia)(AddressOf BuscarCodigo)
            Dim pos As Integer = ListaGeneral.FindIndex(pred)
            If pos > -1 Then bs.Position = pos
        Else
            Dim pred As New Predicate(Of Ransa.TYPEDEF.beMercaderia)(AddressOf BuscarDescripcion)
            Dim pos As Integer = ListaGeneral.FindIndex(pred)
            If pos > -1 Then bs.Position = pos
        End If
    End Sub

    Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If dtgRansa.CurrentRow IsNot Nothing And dtgRansa.Rows.Count > 0 Then
            Dim lint_indice As Integer = Me.dtgRansa.CurrentCellAddress.Y
            _COD_PSCMRCD = Me.dtgRansa.Item("PSCMRCD", lint_indice).Value.ToString.Trim
            _DES_PSCMRCD = Me.dtgRansa.Item("PSTCMPMR", lint_indice).Value.ToString.Trim
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Seleccionar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgRansa.CellMouseDoubleClick
        If dtgRansa.CurrentRow IsNot Nothing And dtgRansa.Rows.Count > 0 Then
            Dim lint_indice As Integer = Me.dtgRansa.CurrentCellAddress.Y
            _COD_PSCMRCD = Me.dtgRansa.Item("PSCMRCD", lint_indice).Value.ToString.Trim
            _DES_PSCMRCD = Me.dtgRansa.Item("PSTCMPMR", lint_indice).Value.ToString.Trim
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class