Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class FrmHistorialOperacion


 
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNNOPRCN As Decimal = 0

    Sub New(ByVal _CCMPN As String, ByVal _CDVSN As String, ByVal _NOPRCN As Decimal)
        InitializeComponent()
        _PSCCMPN = _CCMPN
        _PSCDVSN = _CDVSN
        _PNNOPRCN = _NOPRCN
    End Sub


    Private Sub FrmHistorialOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim parametros As New Hashtable
            Dim ReFacturaBLL As New clsFactura
            parametros.Add("PSCCMPN", _PSCCMPN)
            parametros.Add("PSCDVSN", _PSCDVSN)
            parametros.Add("PNNOPRCN", _PNNOPRCN)
            dtgServiciosOperacion.AutoGenerateColumns = False
            Dim dtHistorialOp As New DataTable
            dtHistorialOp = ReFacturaBLL.Listar_Documentos_Emitidos_x_Operacion(parametros)
            dtgServiciosOperacion.DataSource = dtHistorialOp
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
