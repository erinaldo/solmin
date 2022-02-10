
Imports SOLMIN_ST.NEGOCIO.mantenimientos
 
Public Class frmLiquidacionesConsultaProveedor

    Private _pNOPRCN As Decimal = 0
    Public Property pNOPRCN() As Decimal
        Get
            Return _pNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _pNOPRCN = value
        End Set
    End Property

    Private _pNGUIRM As Decimal = 0
    Public Property pNGUIRM() As Decimal
        Get
            Return _pNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _pNGUIRM = value
        End Set
    End Property
    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _pCDVSN As String = ""
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    ''
    Private _pCPLNDV As String = ""
    Public Property pCPLNDV() As String
        Get
            Return _pCPLNDV
        End Get
        Set(ByVal value As String)
            _pCPLNDV = value
        End Set
    End Property

    Private Sub frmLiquidacionesConsultaProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oblGuiaTransporte As New GuiaTransportista_BLL
            Dim dtServicio As New DataTable
            dtGRemCargGTransLiq.AutoGenerateColumns = False
            Dim dt As New DataTable
            dtServicio = oblGuiaTransporte.Listar_Servicio_Guia_ProvVarios(_pCCMPN, _pNOPRCN, _pNGUIRM)
            For Each Item As DataRow In dtServicio.Rows
                Item("FLQDCN") = HelpClass.FechaNum_a_Fecha(Item("FLQDCN"))
            Next
            dtGRemCargGTransLiq.DataSource = dtServicio
            If dtGRemCargGTransLiq.RowCount > 0 Then
                Listar_Servicios_X_Liquidacion(Me.dtGRemCargGTransLiq.Item("NLQDCN", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtGRemCargGTransLiq_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGRemCargGTransLiq.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Listar_Servicios_X_Liquidacion(Me.dtGRemCargGTransLiq.Item("NLQDCN", e.RowIndex).Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Listar_Servicios_X_Liquidacion(ByVal pNLQDCN As Decimal)
        dtgLiquidacionSAP.AutoGenerateColumns = False
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        Dim lintResult As Int32 = 0

        objetoParametro.Add("PNNLQDCN", pNLQDCN) ''dtGRemCargGTransLiq.CurrentRow.Cells("NLQDCN").Value) ''mNLQDCN
        objetoParametro.Add("PSCCMPN", _pCCMPN)
        objetoParametro.Add("PSCDVSN", _pCDVSN)
        objetoParametro.Add("PNCPLNDV", _pCPLNDV)

        Dim oLiOperacion As New List(Of ENTIDADES.Operaciones.LiquidacionOperacion)
        oLiOperacion = Objeto_Logica.Lista_Servicio_X_Liquidacion_Flete(objetoParametro)

        Me.dtgLiquidacionSAP.DataSource = oLiOperacion

    End Sub

    Private Sub dtGRemCargGTransLiq_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtGRemCargGTransLiq.KeyUp
        If Me.dtGRemCargGTransLiq.RowCount = 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Listar_Servicios_X_Liquidacion(Me.dtGRemCargGTransLiq.Item("NLQDCN", Me.dtGRemCargGTransLiq.CurrentCellAddress.Y).Value)
        End Select
    End Sub
End Class
