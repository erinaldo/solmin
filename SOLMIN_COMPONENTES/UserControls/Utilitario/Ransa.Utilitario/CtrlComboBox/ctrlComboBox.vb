Public Class ctrlComboBox
#Region "Datos"
    Private bInicializo As Boolean = False
    Private oDt As DataTable = Nothing
    Private bIsRequired As Boolean = False
    Private bIsRequired2 As Boolean = False
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Carga un ComboBox Mediante un DataTable colocando como key a la primera columna
    ''' y como descripcion a la segunda columna
    ''' Indica si se va a mostrar el codigo del Item o no
    ''' </summary>
    ''' <returns>ComboBox</returns>
    ''' <remarks></remarks>
    Public Property pMuestraKey() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            txtKey.Visible = bIsRequired
            If bIsRequired = True Then
                cmbValue.Dock = DockStyle.None
            Else
                cmbValue.Dock = DockStyle.Top
            End If
        End Set
    End Property
    ''' <summary>
    ''' Indica si el Campo es Obligatorio o No
    ''' </summary>
    ''' <returns>ComboBox</returns>
    ''' <remarks></remarks>
    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired2
        End Get
        Set(ByVal value As Boolean)
            bIsRequired2 = value
            If Not bIsRequired2 Then
                cmbValue.StateCommon.Back.Color1 = Nothing
                txtKey.StateCommon.Back.Color1 = Nothing
            Else
                cmbValue.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0")
                txtKey.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0")
            End If
        End Set
    End Property
    Public WriteOnly Property pDataSource() As DataTable
        Set(ByVal value As DataTable)
            oDt = value
            CargarCombos(oDt)
        End Set
    End Property
    Public ReadOnly Property pCodigo() As String
        Get
            Return cmbValue.SelectedValue
        End Get
    End Property
    Public ReadOnly Property pDescripcion() As String
        Get
            Return cmbValue.Text
        End Get
    End Property
#End Region
#Region "Metodos"
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.pMuestraKey = True
    End Sub
    Private Sub CargarCombos(ByVal Datos As DataTable) ', ByVal llave As String, ByVal valor As String
        If Not Datos Is Nothing Then
            bInicializo = False
            cmbValue.DataSource = Datos
            cmbValue.ValueMember = Datos.Columns(0).ColumnName
            cmbValue.DisplayMember = Datos.Columns(1).ColumnName
            bInicializo = True
            CargarKey()
        End If
    End Sub
    Private Sub CargarKey()
        txtKey.Text = cmbValue.SelectedValue
    End Sub
    Private Sub cmbValue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbValue.SelectedIndexChanged
        If bInicializo = True Then
            CargarKey()
        End If
    End Sub
#End Region


End Class
