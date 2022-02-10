
Public Class UcFrmEmbarqueDetalle
    Private _pNORSCI As Decimal = 0
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property
    Private _pCCLNT As Decimal
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Public Sub New(ByVal oServicio As Servicio_BE)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub UcFrmEmbarqueDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gvOrdenesEmb.AutoGenerateColumns = False
        Dim oEmbarque As New clsServicioSC_BL
        Dim oDt As DataTable
        oDt = oEmbarque.Lista_Detalle_OC_Embarque(pCCLNT, pNORSCI)
        gvOrdenesEmb.DataSource = oDt
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
